Imports System.Text
Imports System.Data.SqlClient
Imports System.Text.RegularExpressions

Public Class addCustomer
    Friend intCustCount As Integer
    Private strCustomerGender As String

    Private Sub addCustomer_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Set the DateTimePickerDOJ to today's date when the form loads
        dtpDOB.Value = DateTime.Now.AddYears(-20)
        dtpDOB.Value.ToShortDateString()
        dtpDOJ.Value = DateTime.Now.ToShortDateString

        '' Set the format for dateTimePickerDOB and dateTimePicker DOJ
        dtpDOB.Format = DateTimePickerFormat.Custom
        dtpDOB.CustomFormat = "dd/MM/yyyy"
        dtpDOJ.Format = DateTimePickerFormat.Custom
        dtpDOJ.CustomFormat = "dd/MM/yyyy"

        'set customer status when the form load as "active"
        cboStatus.SelectedIndex = 0
        'set the status as false so that the customer cannot change the status
        cboStatus.Enabled = False
        'set customer tier when the form load as "Standard"
        cboTier.SelectedIndex = 0
        cboTier.Enabled = False

        'set the customer points to a default value of 500 points
        txtPoints.Text = "500"

        LoadInitialCustomerID()

    End Sub
    Private Sub LoadInitialCustomerID()
        Try
            Dim lastCustomerID As String = GetLastCustomerID()
            Dim newCustomerID As String = GenerateNextCustomerID(lastCustomerID)

            lblCustomerID.Text = newCustomerID
        Catch ex As Exception
            MessageBox.Show("Error loading initial customer ID.", "Error")
        End Try
    End Sub
    Private Sub btnApplyAddress_Click(sender As Object, e As EventArgs) Handles btnApplyAddress.Click
        txtPermanentAdd.Text = txtPresentAdd.Text
    End Sub

    Private Sub DateTimePickerDOJ_ValueChanged(sender As Object, e As EventArgs) Handles dtpDOJ.ValueChanged
        dtpDOJ.Enabled = False
    End Sub

    'Function'
    Private Function CalculateAge(birthdate As DateTime) As Integer
        ' Calculate the age based on the selected date of birth and the current date
        Dim today As DateTime = DateTime.Now
        Dim age As Integer = today.Year - birthdate.Year

        ' Check if the birthday for this year has occurred or not
        If today.Month < birthdate.Month OrElse (today.Month = birthdate.Month AndAlso today.Day < birthdate.Day) Then
            age -= 1 ' Subtract 1 if the birthday hasn't occurred yet
        End If

        Return age
    End Function

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        dtpDOJ.Value = Today
        cboStatus.Text = "Active"
        txtCustName.Text = ""
        radMale.Checked = False
        radFemale.Checked = False
        txtEmail.Text = ""
        mskCustPhone.Text = ""
        dtpDOB.Value = DateTime.Now.AddYears(-20)
        lblCustAge.Text = ""
        txtPermanentAdd.Text = ""
        txtPresentAdd.Text = ""
        cboStaff.SelectedIndex = -1
        cboTier.SelectedIndex = -1
        txtCustName.Focus()
    End Sub

    Private Sub btnCreate_Click(sender As Object, e As EventArgs) Handles btnCreate.Click
        Dim err As New StringBuilder()
        Dim ctr As Control = Nothing

        Dim dlgResult As DialogResult
        Try
            Dim strCustID, strCustName, strCustPhone, strCustEmail, strCustDOB, strCustDOJ, strCustPresent, strCustPermanent, strCustStatus, strCustTier, strCustPoints, strCustAge, strCreateBy As String

            Dim lastCustomerID As String = GetLastCustomerID()
            Dim newCustomerID As String = GenerateNextCustomerID(lastCustomerID)

            lblCustomerID.Text = newCustomerID

            If radMale.Checked Then
                strCustomerGender = radMale.Text
            ElseIf radFemale.Checked Then
                strCustomerGender = radFemale.Text
            Else
                MessageBox.Show("Please select one gender", "Error")
            End If


            strCustID = lblCustomerID.Text
            strCustDOJ = dtpDOJ.Value
            strCustStatus = cboStatus.SelectedItem
            strCustName = txtCustName.Text
            strCustEmail = txtEmail.Text
            strCustPhone = mskCustPhone.Text
            strCustDOB = dtpDOB.Value
            strCustAge = lblCustAge.Text
            strCustTier = cboTier.SelectedItem
            strCustPoints = txtPoints.Text
            strCustPresent = txtPresentAdd.Text
            strCustPermanent = txtPermanentAdd.Text
            strCreateBy = cboStaff.SelectedItem

            If strCustID = "" Then
                err.AppendLine("-Invalid Customer ID")
                ctr = If(ctr, lblCustomerID)
            End If

            'Check date of joined'
            If strCustDOJ = "" Then
                err.AppendLine("-Invalid Date of Join")
                ctr = If(ctr, dtpDOJ)
            End If

            'Check customer status'
            If strCustStatus = "" Then
                err.AppendLine("-Invalid Customer Status")
                ctr = If(ctr, cboStaff)
            End If

            'Check customer name'
            If strCustName = "" Then
                err.AppendLine("-Customer Name empty")
                ctr = If(ctr, txtCustName)
            ElseIf Not System.Text.RegularExpressions.Regex.IsMatch(txtCustName.Text, "^[A-Za-z ]+$") Then
                err.AppendLine("- Only Letters Accepted in Customer Name!")
                ctr = If(ctr, txtCustName)
            End If

            'Check customer gender'
            If strCustomerGender = "" Then
                err.AppendLine("- Please Select a Gender!")
                ctr = If(ctr, strCustomerGender)
            End If

            'Check customer email'
            If strCustEmail = "" Then
                err.AppendLine("-Customer Email empty")
                ctr = If(ctr, txtEmail)
            ElseIf Not System.Text.RegularExpressions.Regex.IsMatch(txtEmail.Text, "^[_a-z0-9-]+(.[a-z0-9-]+)@[a-z0-9-]+(.[a-z0-9-]+)*(.[a-z]{2,4})$") Then
                err.AppendLine("- Invalid Email Format!")
                ctr = If(ctr, txtEmail)
            End If

            'Check customer phone '
            If strCustPhone = "" Then
                err.AppendLine("-Customer Phone number empty")
                ctr = If(ctr, mskCustPhone)
            ElseIf IsPhoneNumberDuplicated(mskCustPhone.Text) Then
                err.AppendLine("- This Phone Number already exist in the record!")
                ctr = If(ctr, mskCustPhone)
            End If


            'Check customer date of birth'
            If strCustDOB = "" Then
                err.AppendLine("-Invalid Date of Birth")
                ctr = If(ctr, dtpDOB)
            End If

            'Check customer tier ship'
            If strCustTier = "" Then
                err.AppendLine("-Customer Tier empty")
                ctr = If(ctr, cboTier)
            End If

            'Check customer present address'
            If strCustPresent = "" Then
                err.AppendLine("-Customer Present address empty")
                ctr = If(ctr, txtPresentAdd)
            End If

            'Check customer permanent address'
            If strCustPermanent = "" Then
                err.AppendLine("-Customer Permanent address empty")
                ctr = If(ctr, txtPermanentAdd)
            End If

            If err.Length > 0 Then
                MessageBox.Show(err.ToString(), "Input Error")
                ctr.Focus()
                Return
            End If

            If Not CheckValidate() Then
                Return
            End If
            dlgResult = MessageBox.Show("Are you sure you want to add this customer?", "Add Customer", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                If dlgResult = DialogResult.Yes Then
                AddCustomer()
                Dim dlgContinue As DialogResult = MessageBox.Show("Do you want to continue adding customers?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

                If dlgContinue = DialogResult.No Then
                    Customer.lblCustDash.Show()
                    Me.Close()
                End If
            Else
                btnClear_Click(Nothing, Nothing)
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub


    Private Sub mskCustPhone_MaskInputRejected(sender As Object, e As MaskInputRejectedEventArgs)
        If mskCustPhone.Text.Length = 10 OrElse mskCustPhone.Text.Length = 11 Then
            mskCustPhone.BackColor = Color.White
        Else
            'show a message like today's lecture class error 
        End If
    End Sub


    Private Sub dtpDOB_ValueChanged(sender As Object, e As EventArgs) Handles dtpDOB.ValueChanged
        Dim minimumAge As Integer = 18

        Dim selectedDate As DateTime = dtpDOB.Value

        Dim age As Integer = DateTime.Now.Year - selectedDate.Year

        If dtpDOB.Value.Date <= DateTime.Now.Date Then
            Dim age2 As Integer = CalculateAge(dtpDOB.Value)

            ' Display the calculated age in the AgeLabel
            lblCustAge.Text = age2.ToString()
        Else
            MessageBox.Show("Date of Birth cannot be later than today!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            dtpDOB.Focus()
        End If
        If DateTime.Now < selectedDate.AddYears(age) Then
            age -= 1
        End If

        If age < minimumAge Then
            MessageBox.Show("Customer must be atleast 18 years old!", "Invalid Age", MessageBoxButtons.OK, MessageBoxIcon.Error)

            dtpDOB.Value = DateTime.Now.AddYears(-minimumAge)
        End If
    End Sub

    Private Function ValidateAge(selectedDate As DateTime, minimumAge As Integer) As Boolean
        Dim age As Integer = DateTime.Now.Year - selectedDate.Year

        If DateTime.Now < selectedDate.AddYears(age) Then
            age -= 1
        End If

        Return age >= minimumAge
    End Function

    Private Sub AddCustomer()
        OpenConnection()

        'Add new customer

        Dim strSql As String

        strSql = "INSERT INTO Customer (customer_id, customer_date_joined, customer_status, customer_name, customer_gender, customer_email, customer_phone_number, customer_date_of_birth, customer_age, customer_tier, customer_present_address, customer_permanent_address, customer_current_points, total_points_redeem, customer_lifetime_earned_points)Values(@customer_id, @customer_date_joined, @customer_status, @customer_name, @customer_gender, @customer_email, @customer_phone_number, @customer_date_of_birth, @customer_age, @customer_tier, @customer_present_address, @customer_permanent_address, @customer_current_points, @total_points_redeem, @customer_lifetime_earned_points)"


        Using Mysqlcommand As New SqlCommand()

            With Mysqlcommand
                .Connection = connection
                .CommandType = CommandType.Text
                .CommandText = strSql

                .Parameters.AddWithValue("@customer_id", lblCustomerID.Text)
                .Parameters.AddWithValue("@customer_date_joined", dtpDOJ.Value.ToShortDateString)
                .Parameters.AddWithValue("@customer_status", cboStatus.SelectedItem)
                .Parameters.AddWithValue("@customer_name", txtCustName.Text)
                .Parameters.AddWithValue("@customer_gender", strCustomerGender.ToString())
                .Parameters.AddWithValue("@customer_email", txtEmail.Text)
                .Parameters.AddWithValue("@customer_phone_number", mskCustPhone.Text)
                .Parameters.AddWithValue("@customer_date_of_birth", dtpDOB.Value.ToShortDateString)
                .Parameters.AddWithValue("@customer_age", lblCustAge.Text)
                .Parameters.AddWithValue("@customer_tier", cboTier.SelectedItem)
                .Parameters.AddWithValue("@customer_present_address", txtPresentAdd.Text)
                .Parameters.AddWithValue("@customer_permanent_address", txtPermanentAdd.Text)
                .Parameters.AddWithValue("@customer_current_points", txtPoints.Text)
                .Parameters.AddWithValue("@total_points_redeem", txtPoints.Text)
                .Parameters.AddWithValue("@customer_lifetime_earned_points", txtPoints.Text)
                MessageBox.Show("Customer Added.", "Add", MessageBoxButtons.OK, MessageBoxIcon.Information)

                lblCustomerID.Text = GenerateNextCustomerID(lblCustomerID.Text)
                dtpDOJ.Value = Today
                cboStatus.Text = "Active"
                txtCustName.Text = ""
                radMale.Checked = False
                radFemale.Checked = False
                txtEmail.Text = ""
                mskCustPhone.Text = ""
                dtpDOB.Value = DateTime.Now.AddYears(-20)
                lblCustAge.Text = ""
                txtPermanentAdd.Text = ""
                txtPresentAdd.Text = ""
                cboStaff.SelectedIndex = -1
                txtCustName.Focus()
            End With

            Mysqlcommand.ExecuteNonQuery()
        End Using
        CloseConnection()

    End Sub

    Private Function GetLastCustomerID() As String
        OpenConnection()

        Dim lastCustomerID As String = ""
        Dim strSql As String = "SELECT TOP 1 customer_id FROM Customer ORDER BY customer_id DESC"


        Using sqlCommand As New SqlCommand()
            With sqlCommand
                .Connection = connection
                .CommandType = CommandType.Text
                .CommandText = strSql
            End With

            'sqldatareader only read the next row 
            Dim reader As SqlDataReader = sqlCommand.ExecuteReader()

            ' this is to check if there is atleast one row or not in the data 
            If reader.Read() Then
                lastCustomerID = reader("customer_id").ToString()
            End If

            reader.Close()
        End Using

        CloseConnection()

        Return lastCustomerID
    End Function

    Private Function GenerateNextCustomerID(lastCustomerID As String) As String
        Dim nextCustID As Integer

        If String.IsNullOrEmpty(lastCustomerID) Then
            ' If there are no existing records, start with C1001
            nextCustID = 1001
        ElseIf Int32.TryParse(lastCustomerID.Substring(1), nextCustID) Then
            ' Increment the custID for the current record
            nextCustID += 1
        Else
            ' Handle the case where parsing fails
            nextCustID = 1
        End If
        Return "C" & nextCustID.ToString("D4")
    End Function

    Private Function IsPhoneNumberDuplicated(phoneNumber As String) As Boolean
        Dim strSql As String = "SELECT COUNT(*) FROM Customer WHERE customer_phone_number = @customer_phone_number"
        OpenConnection()
        Using sqlCommand As New SqlCommand(strSql, connection)
            sqlCommand.Parameters.AddWithValue("@customer_phone_number", phoneNumber)

            Dim count As Integer = CInt(sqlCommand.ExecuteScalar())

            Return count > 0
        End Using
        CloseConnection()
    End Function

    Private Sub txtCustName_Leave(sender As Object, e As EventArgs) Handles txtCustName.Leave
        If String.IsNullOrEmpty(txtCustName.Text) = True Then
            txtCustName.Focus()
            ErrorProvider1.SetError(Me.txtCustName, "- Please Enter Customer Name!")
        ElseIf Not System.Text.RegularExpressions.Regex.IsMatch(txtCustName.Text, "^[A-Za-z ]+$") Then
            txtCustName.Focus()
            ErrorProvider1.SetError(Me.txtCustName, "- Only Letters Allowed in Customer Name!")
        Else
            ErrorProvider1.Clear()
        End If
    End Sub

    Private Sub txtEmail_Leave(sender As Object, e As EventArgs) Handles txtEmail.Leave
        Dim pattern As String = "^[_a-z0-9-]+(.[a-z0-9-]+)@[a-z0-9-]+(.[a-z0-9-]+)*(.[a-z]{2,4})$"
        If String.IsNullOrEmpty(txtEmail.Text) = True Then
            txtEmail.Focus()
            ErrorProvider2.SetError(Me.txtEmail, "- Please Enter Email Address!")
        ElseIf Not Regex.IsMatch(txtEmail.Text, pattern) Then
            txtEmail.Focus()
            ErrorProvider2.SetError(Me.txtEmail, "- Invalid Email Address!")
        Else
            ErrorProvider2.Clear()
        End If
    End Sub

    Private Sub mskCustPhone_Leave(sender As Object, e As EventArgs)
        Dim pattern As String = "^(\+?6?01)[0|1|2|3|4|6|7|8|9]\-*[0-9]{7,8}$"
        If Regex.IsMatch(mskCustPhone.Text, pattern) Then
            mskCustPhone.Focus()
            ErrorProvider3.SetError(Me.mskCustPhone, "- Please Enter a valid Phone Number!")
        End If
    End Sub

    Private Sub txtPresentAdd_Leave(sender As Object, e As EventArgs) Handles txtPresentAdd.Leave
        If String.IsNullOrEmpty(txtPresentAdd.Text) = True Then
            txtPresentAdd.Focus()
            ErrorProvider4.SetError(Me.txtPresentAdd, "- Please Enter Present Address!")
        End If
    End Sub

    Private Function CheckValidate() As Boolean
        Dim err As New StringBuilder()
        Dim ctr As Control = Nothing

        ' Validate customer name
        If String.IsNullOrWhiteSpace(txtCustName.Text) Then
            err.AppendLine(" - Customer Name cannot be empty.")
            ctr = If(ctr, txtCustName)
        ElseIf Not System.Text.RegularExpressions.Regex.IsMatch(txtCustName.Text, "^[A-Za-z ]+$") Then
            err.AppendLine(" - Only Letters Allowed in Customer Name!")
            ctr = If(ctr, txtCustName)
        End If

        ' Validate customer gender
        If Not (radMale.Checked Or radFemale.Checked) Then
            err.AppendLine(" - Please select a Gender.")
            ctr = If(ctr, radMale)
        End If

        ' Validate customer email
        Dim emailPattern As String = "^[_a-z0-9-]+(.[a-z0-9-]+)@[a-z0-9-]+(.[a-z0-9-]+)*(.[a-z]{2,4})$"
        If String.IsNullOrWhiteSpace(txtEmail.Text) Then
            err.AppendLine(" - Customer Email cannot be empty.")
            ctr = If(ctr, txtEmail)
        ElseIf Not Regex.IsMatch(txtEmail.Text, emailPattern) Then
            err.AppendLine(" - Invalid Email Address.")
            ctr = If(ctr, txtEmail)
        End If

        ' Validate customer phone
        Dim phonePattern As String = "^(\+?6?01)[0|1|2|3|4|6|7|8|9]\-*[0-9]{7,8}$"
        If String.IsNullOrWhiteSpace(mskCustPhone.Text) OrElse Not Regex.IsMatch(mskCustPhone.Text, phonePattern) Then
            err.AppendLine(" - Please Enter a valid Phone Number.")
            ctr = If(ctr, mskCustPhone)
        ElseIf IsPhoneNumberDuplicated(mskCustPhone.Text) Then
            err.AppendLine(" - This Phone Number already exists in the record.")
            ctr = If(ctr, mskCustPhone)
        End If

        ' Validate customer date of birth
        If dtpDOB.Value > DateTime.Now.Date Then
            err.AppendLine(" - Date of Birth cannot be later than today.")
            ctr = If(ctr, dtpDOB)
        End If

        ' Validate customer tier
        If cboTier.SelectedItem Is Nothing Then
            err.AppendLine(" - Please select a Customer Tier.")
            ctr = If(ctr, cboTier)
        End If

        ' Validate customer present address
        If String.IsNullOrWhiteSpace(txtPresentAdd.Text) Then
            err.AppendLine(" - Customer Present Address cannot be empty.")
            ctr = If(ctr, txtPresentAdd)
        End If

        ' Display error messages and set focus
        If err.Length > 0 Then
            MessageBox.Show(err.ToString(), "Input Error")
            ctr.Focus()
            Return False
        Else
            Return True
        End If
    End Function
End Class
