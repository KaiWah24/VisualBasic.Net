Imports System.Data.SqlClient
Imports System.IO
Imports System.Text.RegularExpressions
Imports System.Net
Imports System.Net.Mail
Public Class addStaff
    Dim username As String = "supergrocery123@gmail.com"
    Dim passwords As String = "wzkbgsfubzaiauwc"
    Private Sub addStaff_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblStaffId.Text = GetNextStaffID()
        lblDateHired.Text = Date.Today
        cboPositionData()
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

    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        txtName.Focus()
        ClearAll()
    End Sub

    Private Sub dtpBirthday_ValueChanged(sender As Object, e As EventArgs) Handles dtpBirthday.ValueChanged
        lblAge.Text = (Today.Year - dtpBirthday.Value.Year).ToString()
    End Sub

    Private Sub btnCreate_Click(sender As Object, e As EventArgs) Handles btnCreate.Click
        ' Validate the form
        If Not ValidateForm() Then
            MessageBox.Show("Please fill in all the required fields with valid data.", "Validation Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        ' add data into the database
        Dim strSql, strCheckSql As String
        Dim MySqlCommand As New SqlCommand
        Dim strGender As String
        Dim ms As New MemoryStream

        picStaff.Image.Save(ms, picStaff.Image.RawFormat)

        If radMale.Checked Then
            strGender = "Male"
        Else
            strGender = "Female"
        End If

        strSql = "INSERT INTO Staff(staff_id,staff_name,staff_password,staff_ic,staff_email,staff_phone_num,staff_gender,staff_birthday,staff_age,staff_relationship,staff_address,
                 staff_status,staff_position,staff_salary,staff_date_hired,staff_image) VALUES (@staff_id,@staff_name,@staff_password,@staff_ic,@staff_email,@staff_phone_num,@staff_gender,
                 @staff_birthday,@staff_age,@staff_relationship,@staff_address,@staff_status,@staff_position,@staff_salary,@staff_date_hired,@staff_image)"

        strCheckSql = "SELECT * FROM Staff WHERE staff_email = @staff_email"


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

        OpenConnection()
        MySqlCommand = New SqlCommand(strCheckSql, connection)
        MySqlCommand.Parameters.AddWithValue("@staff_email", txtEmail.Text)
        Dim reader As SqlDataReader = MySqlCommand.ExecuteReader()

        reader.Read()
        If reader.HasRows Then
            MessageBox.Show("Email have been used", "Create failed")
            With txtEmail
                .SelectAll()
                .Focus()
            End With
            reader.Close()

        Else
            MySqlCommand = New SqlCommand(strSql, connection)
            With MySqlCommand.Parameters
                .AddWithValue("@staff_id", lblStaffId.Text)
                .AddWithValue("@staff_name", txtName.Text)
                .AddWithValue("@staff_password", mskIC.Text)
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
            reader.Close()
            MySqlCommand.ExecuteNonQuery()
            MessageBox.Show("Record Added.", "Add Record")
            sendAccountCreation()
            ClearAll()
            lblStaffId.Text = GetNextStaffID()
            organization.RefreshAllStaffData()
        End If

        CloseConnection()

    End Sub

    Private Function GetNextStaffID() As Integer
        Dim strSql As String = "SELECT TOP 1 staff_id FROM Staff ORDER BY staff_id DESC;"
        Dim MySqlCommand As New SqlCommand

        OpenConnection()
        Dim intNextStaffID As Integer = 1

        MySqlCommand = New SqlCommand(strSql, connection)

        Dim reader As SqlDataReader = MySqlCommand.ExecuteReader()

        If reader.Read() Then
            intNextStaffID = reader("staff_id") + 1
        End If

        reader.Close()
        CloseConnection()

        Return intNextStaffID
    End Function

    Private Sub cboPositionData()

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
                        If itemName <> "SUPER_ADMIN" Then
                            cboPosition.Items.Add(itemName)
                        End If
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

    Private Sub ClearAll()
        txtName.Clear()
        txtAddress.Clear()
        txtEmail.Clear()
        txtPhoneNum.Clear()
        txtSalary.Clear()
        mskIC.Clear()
        cboPosition.SelectedIndex = -1
        cboRelationship.SelectedIndex = -1
        radMale.Checked = True
        dtpBirthday.Value = Today

        ClearAllErrors()

        picStaff.Image = Image.FromFile("C:\Users\User\OneDrive\Desktop\Login+Staff\Login+Staff\Resources\blank-profile-picture-973460_640.png")
    End Sub


    Sub sendAccountCreation()

        Dim staff_id As Integer = lblStaffId.Text
        Dim password As String = mskIC.Text
        Dim maskedPassword As String = New String("*", password.Length - 4) & password.Substring(password.Length - 4)


        Try

            Dim fromAddress As New MailAddress("noReply@grocery.com", "SuperGrocery")
            Dim toAddress As New MailAddress(txtEmail.Text)
            Dim subject As String = "Account Created Successfully"
            Dim body As String = $"Dear {txtName.Text}," & vbCrLf &
                   vbCrLf &
                   "Congratulations! Your SuperGrocery account has been successfully created." & vbCrLf &
                   vbCrLf &
                   $"User ID: {staff_id}" & vbCrLf &
                   $"Temporary Password: We've generated a temporary password for you, derived from your IC number. The last 4 digits of your IC: {maskedPassword}" & vbCrLf &
                   vbCrLf &
                   "For security reasons, it is recommended to change your password upon first login." & vbCrLf &
                   vbCrLf &
                   "You can now log in to your account and start exploring our services." & vbCrLf &
                   vbCrLf &
                   "Best regards," & vbCrLf &
                   "SuperGrocery Team"


            Dim smtp As New SmtpClient()
            smtp.Host = "smtp.gmail.com"
            smtp.Port = 587
            smtp.EnableSsl = True
            smtp.Credentials = New NetworkCredential(username, passwords)
            Dim message As New MailMessage(fromAddress, toAddress)
            message.Subject = subject
            message.Body = body

            smtp.Send(message)
        Catch ex As Exception
            MessageBox.Show("Failed to send the Account Creation", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub


    ' Validation methods
    ' ...

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

    Private Sub txtSalary_Leave(sender As Object, e As EventArgs) Handles txtSalary.Leave
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

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        ClearAll()
        Me.Close()
    End Sub
End Class
