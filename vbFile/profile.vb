Imports System.Data.SqlClient
Imports System.IO
Imports System.Text.RegularExpressions

Public Class profile

    Private Sub profile_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        getStaffData()

    End Sub
    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click

        If btnEdit.Text = "Edit" Then
            SetButtonForEdit()

        Else
            ' Clear the errors before revalidation
            ClearAllErrors()

            ' Perform the validation
            If Not ValidateName() Or
           Not ValidateEmail() Or
           Not ValidatePhoneNum() Or
           Not ValidateSalary() Or
           Not ValidateAddress() Or
           Not ValidatePosition() Or
           Not ValidateRelationship() Or
           Not ValidateBirthday() Then

                MessageBox.Show("Please fill in all the required fields with valid data.", "Validation Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return
            End If

            updateData()
            SetButtonForSave()
        End If

    End Sub

    Private Sub btnPrint_Click(sender As Object, e As EventArgs) Handles btnPrint.Click
        If btnPrint.Text = "Cancel" Then
            getStaffData()
            SetButtonForSave()
        Else
            'print 
        End If
    End Sub

    Sub getStaffData()
        Dim MySqlCommand As New SqlCommand
        Dim strSql As String = "SELECT * FROM Staff WHERE staff_id = @staff_id"

        getCboPositionData()
        OpenConnection()
        MySqlCommand = New SqlCommand(strSql, connection)
        MySqlCommand.Parameters.AddWithValue("@staff_id", Login.intloggedInStaff)
        Dim reader As SqlDataReader = MySqlCommand.ExecuteReader()

        reader.Read()
        lblStaffId.Text = Login.intloggedInStaff
        txtName.Text = reader("staff_name")
        mskIC.Text = reader("staff_ic")
        txtEmail.Text = reader("staff_email")
        txtPhoneNum.Text = reader("staff_phone_num")

        If reader("staff_gender") = "Male" Then
            radMale.Checked = True
        Else
            radMale.Checked = True
        End If

        dtpBirthday.Value = reader("staff_birthday")
        cboRelationship.Text = reader("staff_relationship")
        lblAge.Text = Integer.Parse(Today.Year - dtpBirthday.Value.Year)
        txtAddress.Text = reader("staff_address")
        cboPosition.Text = reader("staff_position")
        txtSalary.Text = reader("staff_salary")
        lblDateHired.Text = reader("staff_date_hired")
        cboStatus.Text = reader("staff_status")

        'Dim img() As Byte
        'img = reader("staff_image")
        'Dim ms As New MemoryStream(img)
        'picStaff.Image = Image.FromStream(ms)

        reader.Close()

        CloseConnection()
    End Sub

    'updateData
    Private Sub updateData()
        Dim strSql As String
        Dim MySqlCommand As New SqlCommand
        Dim strGender As String
        Dim ms As New MemoryStream

        picStaff.Image.Save(ms, picStaff.Image.RawFormat)

        If radMale.Checked = True Then
            strGender = "Male"
        Else
            strGender = "Female"
        End If

        strSql = "UPDATE Staff SET staff_name = @staff_name, staff_ic = @staff_ic, staff_email = @staff_email, staff_phone_num = @staff_phone_num,
                 staff_gender = @staff_gender, staff_birthday = @staff_birthday, staff_age = @staff_age, staff_relationship = @staff_relationship, 
                 staff_address = @staff_address, staff_status = @staff_status, staff_position = @staff_position, staff_salary = @staff_salary, 
                 staff_date_hired = @staff_date_hired, staff_image = @staff_image WHERE staff_id = @staff_id"

        OpenConnection()
        MySqlCommand = New SqlCommand(strSql, connection)
        With MySqlCommand.Parameters
            .AddWithValue("@staff_id", lblStaffId.Text)
            .AddWithValue("@staff_name", txtName.Text)
            .AddWithValue("@staff_ic", mskIC.Text)
            .AddWithValue("@staff_email", txtEmail.Text)
            .AddWithValue("@staff_phone_num", txtPhoneNum.Text)
            .AddWithValue("@staff_gender", strGender)
            .AddWithValue("@staff_birthday", dtpBirthday.Value)
            .AddWithValue("@staff_age", lblAge.Text)
            .AddWithValue("@staff_relationship", cboRelationship.SelectedItem.ToString)
            .AddWithValue("@staff_address", txtAddress.Text)
            .AddWithValue("@staff_status", cboStatus.SelectedItem.ToString)
            .AddWithValue("@staff_position", cboPosition.SelectedItem.ToString)
            .AddWithValue("@staff_salary", Decimal.Parse(txtSalary.Text))
            .AddWithValue("@staff_date_hired", Date.Today)
            .AddWithValue("@staff_image", ms.ToArray())
        End With
        MySqlCommand.ExecuteNonQuery()
        MessageBox.Show("Profile Updated.", "Update Profile", MessageBoxButtons.OK, MessageBoxIcon.Information)
        CloseConnection()

    End Sub

    Private Sub SetButtonForEdit()
        Dim strSql As String = "SELECT * FROM RoleAccess WHERE role_name = @role_name"
        Dim MySqlCommand As New SqlCommand

        OpenConnection()
        MySqlCommand = New SqlCommand(strSql, connection)
        MySqlCommand.Parameters.AddWithValue("@role_name", cboPosition.SelectedItem.ToString)

        Dim reader As SqlDataReader = MySqlCommand.ExecuteReader()

        reader.Read()


        If reader("role_name") = cboPosition.SelectedItem.ToString And reader("access_type") = "Root_Access" And reader("role_name") <> "SUPER_ADMIN" Then
            txtSalary.Enabled = True
            cboPosition.Enabled = True
        End If

        reader.Close()

        btnEdit.Text = "Save"
        btnPrint.Text = "Cancel"


        txtName.Enabled = True
        mskIC.Enabled = True
        txtEmail.Enabled = True
        txtPhoneNum.Enabled = True
        dtpBirthday.Enabled = True
        cboRelationship.Enabled = True
        btnUpload.Visible = True
        btnClear.Visible = True
        radFemale.Enabled = True
        radMale.Enabled = True

    End Sub

    Private Sub SetButtonForSave()
        btnEdit.Text = "Edit"
        btnPrint.Text = "Print"

        txtName.Enabled = False
        mskIC.Enabled = False
        txtEmail.Enabled = False
        txtPhoneNum.Enabled = False
        txtSalary.Enabled = False
        dtpBirthday.Enabled = False
        cboRelationship.Enabled = False
        btnUpload.Visible = False
        btnClear.Visible = False
        cboPosition.Enabled = False
        radFemale.Enabled = False
        radMale.Enabled = False


    End Sub

    Private Sub dtpBirthday_ValueChanged(sender As Object, e As EventArgs) Handles dtpBirthday.ValueChanged
        lblAge.Text = Integer.Parse(Today.Year - dtpBirthday.Value.Year)
    End Sub

    Private Sub btnUpload_Click(sender As Object, e As EventArgs) Handles btnUpload.Click
        If dlgOpenFile.ShowDialog() = DialogResult.OK Then
            Dim photo = Image.FromFile(dlgOpenFile.FileName)
            picStaff.Image = photo
        End If
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        picStaff.Image = Image.FromFile("C:\Users\User\OneDrive\Desktop\Login+Staff\Login+Staff\Resources\blank-profile-picture-973460_640.png")
    End Sub


    Sub getCboPositionData()
        Try
            ' Open the database connection
            OpenConnection()

            ' Define the SQL query to retrieve data from the database
            Dim query As String = "SELECT role_name FROM RoleAccess"

            ' Create a SqlCommand object
            Using command As New SqlCommand(query, connection)
                ' Create a SqlDataReader to read the data
                Using reader As SqlDataReader = command.ExecuteReader()
                    ' Clear existing items in the ComboBox
                    cboPosition.Items.Clear()

                    ' Loop through the result set and add each item to the ComboBox
                    While reader.Read()
                        ' Assuming the column index is 0; adjust as needed
                        Dim itemName As String = reader.GetString(0)
                        cboPosition.Items.Add(itemName)
                    End While

                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            ' Close the database connection
            CloseConnection()
        End Try
    End Sub

    Private Sub ClearAllErrors()
        errStaffAddress.Clear()
        errStaffBirthday.Clear()
        errStaffEmail.Clear()
        errStaffName.Clear()
        errStaffPhoneNum.Clear()
        errStaffPosition.Clear()
        errStaffRelationship.Clear()
        errStaffSalary.Clear()
    End Sub

    Private Function ValidateName() As Boolean
        Dim format As String = "^[a-zA-Z\s]+$"
        Dim reName As New Regex(format)

        If String.IsNullOrWhiteSpace(txtName.Text) Then
            txtName.Focus()
            errStaffName.SetError(Me.txtName, "Please Enter Staff Name.")
            Return False
        ElseIf Not reName.IsMatch(txtName.Text) Then
            txtName.Focus()
            errStaffName.SetError(Me.txtName, "Please Enter Alphabetic Characters Only.")
            Return False
        Else
            errStaffName.Clear()
            Return True
        End If
    End Function

    Private Function ValidateEmail() As Boolean
        Dim strEmail As String = txtEmail.Text
        If String.IsNullOrEmpty(strEmail) Then
            txtEmail.Focus()
            errStaffEmail.SetError(Me.txtEmail, "Please Enter Email Address")
            Return False
        ElseIf Not ValidateEmailFormat(strEmail) Then
            txtEmail.Focus()
            errStaffEmail.SetError(Me.txtEmail, "Invalid Email Address!")
            Return False
        Else
            errStaffEmail.Clear()
            Return True
        End If
    End Function

    Private Function ValidateEmailFormat(ByVal strEmail As String) As Boolean
        Try
            Dim vEmailAddress As New System.Net.Mail.MailAddress(strEmail)
        Catch ex As Exception
            Return False
        End Try
        Return True
    End Function

    Private Function ValidatePhoneNum() As Boolean
        Dim format011 As String = "^011-[1-9]\d{3}-\d{4}$"
        Dim format010 As String = "^01[0-9&&[^1]]-[1-9]\d{2}-\d{4}$"
        If String.IsNullOrEmpty(txtPhoneNum.Text) Then
            txtPhoneNum.Focus()
            errStaffPhoneNum.SetError(Me.txtPhoneNum, "Please Enter Phone Number")
            Return False
        ElseIf Not Regex.IsMatch(txtPhoneNum.Text, format011) AndAlso Not Regex.IsMatch(txtPhoneNum.Text, format010) Then
            txtPhoneNum.Focus()
            errStaffPhoneNum.SetError(Me.txtPhoneNum, "Invalid Phone Number Format! Please use either '011-XXXX-XXXX' or '01X-XXX-XXXX' (X represents digits).")
            Return False
        Else
            errStaffPhoneNum.Clear()
            Return True
        End If
    End Function

    Private Function ValidateRelationship() As Boolean
        If cboRelationship.SelectedIndex = -1 Then
            errStaffRelationship.SetError(Me.cboRelationship, "Please Select a Relationship Status.")
            Return False
        Else
            errStaffRelationship.Clear()
            Return True
        End If
    End Function

    Private Function ValidateBirthday() As Boolean
        Dim selectedDate As Date = dtpBirthday.Value
        Dim minimumBirthYear As Integer = Date.Now.Year - 18

        If selectedDate > Date.Now.AddYears(-18) AndAlso selectedDate.Year > minimumBirthYear Then
            ' The selected date does not make the staff more than 18 years old
            errStaffBirthday.SetError(dtpBirthday, $"Staff age must be 18 or more, the staff birthday year must be at least {minimumBirthYear}.")
            Return False
        Else
            errStaffBirthday.Clear()
            Return True
        End If
    End Function

    Private Function ValidateAddress() As Boolean
        If String.IsNullOrEmpty(txtAddress.Text) Then
            txtAddress.Focus()
            errStaffAddress.SetError(Me.txtAddress, "Please Enter Staff Address.")
            Return False
        ElseIf txtAddress.TextLength < 5 Then
            txtAddress.Focus()
            errStaffAddress.SetError(Me.txtAddress, "Minimum enter 5 character.")
            Return False
        Else
            errStaffAddress.Clear()
            Return True
        End If
    End Function

    Private Function ValidatePosition() As Boolean
        If cboPosition.SelectedIndex = -1 Then
            errStaffPosition.SetError(Me.cboPosition, "Please Select a Position.")
            Return False
        Else
            errStaffPosition.Clear()
            Return True
        End If
    End Function

    Private Function ValidateSalary() As Boolean
        Dim parsedSalary As Decimal

        If String.IsNullOrEmpty(txtSalary.Text) Then
            txtSalary.Focus()
            errStaffSalary.SetError(Me.txtSalary, "Please Enter staff Basic Salary.")
            Return False
        ElseIf Not Decimal.TryParse(txtSalary.Text, parsedSalary) Then
            txtSalary.Focus()
            ' Conversion failed, show an error message
            errStaffSalary.SetError(Me.txtSalary, "Invalid salary format. Please enter a valid numeric value.")
            Return False
        Else
            txtSalary.Text = parsedSalary.ToString("N2")
            errStaffSalary.Clear()
            Return True
        End If
    End Function

    ' Validate the entire form
    Private Function ValidateForm() As Boolean
        Return ValidateName() AndAlso
               ValidateEmail() AndAlso
               ValidatePhoneNum() AndAlso
               ValidateSalary() AndAlso
               ValidateAddress() AndAlso
               ValidatePosition() AndAlso
               ValidateRelationship() AndAlso
               ValidateBirthday()
    End Function

    Private Sub txtName_Leave(sender As Object, e As EventArgs) Handles txtName.Leave
        ValidateName()
    End Sub

    Private Sub txtEmail_Leave(sender As Object, e As EventArgs) Handles txtEmail.Leave
        ValidateEmail()
    End Sub

    Private Sub txtPhoneNum_Leave(sender As Object, e As EventArgs) Handles txtPhoneNum.Leave
        ValidatePhoneNum()
    End Sub

    Private Sub txtSalary_Leave(sender As Object, e As EventArgs)
        ValidateSalary()
    End Sub

    Private Sub txtAddress_Leave(sender As Object, e As EventArgs) Handles txtAddress.Leave
        ValidateAddress()
    End Sub

    Private Sub cboPosition_Leave(sender As Object, e As EventArgs) Handles cboPosition.Leave
        ValidatePosition()
    End Sub

    Private Sub cboRelationship_Leave(sender As Object, e As EventArgs) Handles cboRelationship.Leave
        ValidateRelationship()
    End Sub

    Private Sub dtpBirthday_Leave(sender As Object, e As EventArgs) Handles dtpBirthday.Leave
        ValidateBirthday()
    End Sub

End Class