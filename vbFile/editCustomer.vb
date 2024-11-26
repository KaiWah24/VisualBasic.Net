Imports System.Data.SqlClient
Imports System.Text
Imports System.Text.RegularExpressions

Public Class editCustomer
    Private strCustomerGender As String
    Private Sub editCustomer_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        SetControlDisabled()

        lblCustomerID.Text = customerMenu.strCurrentCustID.ToString()
        txtCustName.Text = customerMenu.strCurrentName.ToString()
        lblTier.Text = customerMenu.strCurrentTier.ToString()
        cboStatus.Text = customerMenu.strCurrentCustStatus.ToString()
        dtpDOJ.Value = customerMenu.strCurrentDateJoined.ToString()
        txtEmail.Text = customerMenu.strCurrentEmail.ToString()
        lblGender.Text = customerMenu.strCurrentGender.ToString()
        mskCustPhone.Text = customerMenu.strCurrentPhone.ToString()
        dtpDOB.Value = customerMenu.strCurrentDateOfBirth.ToString()
        lblCustAge.Text = customerMenu.strCurrentAge.ToString()
        txtPresentAdd.Text = customerMenu.strCurrentCaddress.ToString()
        txtPermanentAdd.Text = customerMenu.strCurrentPaddress.ToString()
        txtPoints.Text = customerMenu.strCurrentPoints.ToString()

        If lblGender.Text = "Male" Then
            radMale.Checked = True
        ElseIf lblGender.Text = "Female" Then
            radFemale.Checked = True
        End If
    End Sub

    Private Sub SetControlsEnabled()

        btnSaveEdit.Text = "Update"

        cboStatus.Enabled = False
        lblCustomerID.Enabled = True
        dtpDOJ.Enabled = True
        txtCustName.Enabled = True
        txtEmail.Enabled = True
        mskCustPhone.Enabled = True
        dtpDOB.Enabled = True
        txtPoints.Enabled = True
        txtPresentAdd.Enabled = True
        txtPermanentAdd.Enabled = True
        btnSaveEdit.Enabled = True
        radFemale.Enabled = True
        radMale.Enabled = True
    End Sub
    Private Sub SetControlDisabled()

        btnSaveEdit.Text = "Edit"
        cboStatus.Enabled = False
        lblCustomerID.Enabled = False
        dtpDOJ.Enabled = False
        txtCustName.Enabled = False
        txtEmail.Enabled = False
        mskCustPhone.Enabled = False
        dtpDOB.Enabled = False
        txtPoints.Enabled = False
        txtPresentAdd.Enabled = False
        txtPermanentAdd.Enabled = False
        radFemale.Enabled = False
        radMale.Enabled = False
    End Sub
    Private Sub btnSaveEdit_Click_1(sender As Object, e As EventArgs) Handles btnSaveEdit.Click
        If btnSaveEdit.Text = "Edit" Then
            SetControlsEnabled()
        Else
            If CheckValidate() Then
                SaveandUpdateDetails()
                SetControlDisabled()
                Customer.lblCustDash.Show()
            End If
        End If
    End Sub

    Private Sub SaveandUpdateDetails()
        Dim err As New StringBuilder()
        Dim ctr As Control = Nothing
        If radMale.Checked Then
            strCustomerGender = radMale.Text
        ElseIf radFemale.Checked Then
            strCustomerGender = radFemale.Text
        Else
            MessageBox.Show("Please select one gender", "Error")
            Return
        End If

        Try
            Dim strCustID, strCustName, strCustPhone, strCustEmail, strCustDOB, strCustDOJ, strCustPresent, strCustPermanent, strCustStatus, strCustPoints, strCustAge As String


            strCustID = lblCustomerID.Text
            strCustDOJ = dtpDOJ.Value
            strCustStatus = cboStatus.SelectedItem
            strCustName = txtCustName.Text
            strCustEmail = txtEmail.Text
            strCustPhone = mskCustPhone.Text
            strCustDOB = dtpDOB.Value
            strCustAge = lblCustAge.Text
            strCustPoints = txtPoints.Text
            strCustPresent = txtPresentAdd.Text
            strCustPermanent = txtPermanentAdd.Text

            Dim strSql As String = "UPDATE Customer SET " &
                                   "customer_status = @customer_status, " &
                                   "customer_name = @customer_name, " &
                                   "customer_gender = @customer_gender, " &
                                   "customer_email = @customer_email, " &
                                   "customer_phone_number = @customer_phone_number, " &
                                   "customer_date_of_birth = @customer_date_of_birth, " &
                                   "customer_age = @customer_age, " &
                                   "customer_tier = @customer_tier, " &
                                   "customer_present_address = @customer_present_address, " &
                                   "customer_permanent_address = @customer_permanent_address, " &
                                   "customer_current_points = @customer_current_points " &
                                   "WHERE customer_id = @customer_id"

            'Check date of joined'
            If strCustDOJ = "" Then
                err.AppendLine("-Invalid Date of Join")
                ctr = If(ctr, dtpDOJ)
            End If

            'Check customer status'
            If strCustStatus = "" Then
                err.AppendLine("-Invalid Customer Status")
                ctr = If(ctr, cboStatus)
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

            OpenConnection()
            Using Mysqlcommand As New SqlCommand()

                With Mysqlcommand
                    .Connection = connection
                    .CommandType = CommandType.Text
                    .CommandText = strSql

                    .Parameters.AddWithValue("@customer_id", lblCustomerID.Text)
                    .Parameters.AddWithValue("@customer_status", cboStatus.SelectedItem.ToString())
                    .Parameters.AddWithValue("@customer_name", txtCustName.Text)
                    .Parameters.AddWithValue("@customer_gender", strCustomerGender)
                    .Parameters.AddWithValue("@customer_email", txtEmail.Text)
                    .Parameters.AddWithValue("@customer_phone_number", mskCustPhone.Text)
                    .Parameters.AddWithValue("@customer_date_of_birth", dtpDOB.Value.ToShortDateString)
                    .Parameters.AddWithValue("@customer_age", lblCustAge.Text)
                    .Parameters.AddWithValue("@customer_tier", lblTier.Text)
                    .Parameters.AddWithValue("@customer_present_address", txtPresentAdd.Text)
                    .Parameters.AddWithValue("@customer_permanent_address", txtPermanentAdd.Text)
                    .Parameters.AddWithValue("@customer_current_points", txtPoints.Text)

                End With
                Mysqlcommand.ExecuteNonQuery()
                MessageBox.Show("Details updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End Using
        Catch ex As Exception
            MessageBox.Show("Error updating details: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            CloseConnection()
        End Try
    End Sub
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
    Private Sub dtpDOB_ValueChanged(sender As Object, e As EventArgs) Handles dtpDOB.ValueChanged
        Dim minimumAge As Integer = 18

        Dim selectedDate As DateTime = dtpDOB.Value

        ' Check if the age label has a valid value before performing age-related validations
        If Not String.IsNullOrEmpty(lblCustAge.Text) AndAlso Integer.TryParse(lblCustAge.Text, Nothing) Then
            Dim age As Integer = Integer.Parse(lblCustAge.Text)

            ' Perform age-related validations only if the age is greater than or equal to zero
            If age >= 0 Then
                If DateTime.Now < selectedDate.AddYears(age) Then
                    age -= 1
                End If

                If age < minimumAge Then
                    MessageBox.Show("Customer must be at least 18 years old!", "Invalid Age", MessageBoxButtons.OK, MessageBoxIcon.Error)

                    ' Adjust the date of birth to meet the minimum age requirement
                    dtpDOB.Value = DateTime.Now.AddYears(-minimumAge)
                End If
            End If
        End If
    End Sub

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
    Private Sub btnApplyAddress_Click(sender As Object, e As EventArgs)
        txtPermanentAdd.Text = txtPresentAdd.Text
    End Sub
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

    Private Sub btnCancel_Click(sender As Object, e As EventArgs)
        Customer.Show()
    End Sub
    Private Sub btnClear_Click(sender As Object, e As EventArgs)
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
        lblTier.Text = ""
        txtCustName.Focus()
    End Sub


End Class