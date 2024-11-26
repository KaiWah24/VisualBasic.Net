Imports System.Net
Imports System.Net.Mail
Public Class forgotPassword
    Friend verificationCode As String = Guid.NewGuid().ToString
    Friend strResetPwEmail As String
    Dim username As String = "supergrocery123@gmail.com"
    Dim passwords As String = "fqtwxpbacwpbclsq"
    Dim randomNum As Random = New Random()



    Private Sub forgotPassword_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        password.AcceptButton = btnNext
    End Sub
    Private Sub btnNext_Click(sender As Object, e As EventArgs) Handles btnNext.Click
        strResetPwEmail = txtEmail.Text

        If strResetPwEmail = Nothing Then
            MessageBox.Show("Please enter the email address", "Input error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        ElseIf ValidateEmail(strResetPwEmail) = False Then
            MessageBox.Show("Invalid email address format", "Input error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        Else
            sendVerificationCode()
            password.childform(verification)
        End If

    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        password.Close()
    End Sub





    '-----function------

    'check email
    Function ValidateEmail(ByVal strResetPwEmail As String) As Boolean
        Try
            Dim vEmailAddress As New System.Net.Mail.MailAddress(strResetPwEmail)
        Catch ex As Exception
            Return False
        End Try
        Return True
    End Function

    'send email
    Sub sendVerificationCode()
        Try
            verificationCode = randomNum.Next(100000, 999999)
            Dim fromAddress As New MailAddress("noReply@grocery.com", "SuperGrocery")
            Dim toAddress As New MailAddress(txtEmail.Text)
            Dim subject As String = "Reset Password verification"
            Dim body As String = "Please use the 6-digits password recovery code below to reset your SuperGrocery account." & Environment.NewLine & Environment.NewLine &
                                 "Password recovery code: " & verificationCode & Environment.NewLine &
                                 Environment.NewLine & Environment.NewLine &
                                 "Regrads," & Environment.NewLine &
                                 "SuperGrocery Team" & Environment.NewLine &
                                 "-----This is an auto-generated email, please do not reply.-----"

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
            MessageBox.Show("Failed to send the verification code", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub




End Class