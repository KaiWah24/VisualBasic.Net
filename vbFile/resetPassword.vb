Imports System.Data.SqlClient

Public Class resetPassword
    Private Sub resetPassword_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        password.Text = "ResetPassword"
    End Sub

    Private Sub btnConfirm_Click(sender As Object, e As EventArgs) Handles btnConfirm.Click
        Dim strNewPw As String = txtNewPw.Text
        Dim strConfirmPW As String = txtConfirmPw.Text
        Dim strSql As String
        Dim MySqlCommand As New SqlCommand

        If strNewPw = strConfirmPW Then
            strSql = "UPDATE Staff SET staff_password = @staffPassword WHERE staff_email = @staffEmail"
            OpenConnection()
            MySqlCommand = New SqlCommand(strSql, connection)
            MySqlCommand.Parameters.AddWithValue("@staffPassword", txtConfirmPw.Text)
            MySqlCommand.Parameters.AddWithValue("@staffEmail", forgotPassword.strResetPwEmail)
            MySqlCommand.ExecuteNonQuery()
            CloseConnection()
            MessageBox.Show("Reset Password successful !!!", "Reset Password", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
            password.Close()
        Else
            MessageBox.Show("New Password did not match with confirm password", "Failed Reset", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtNewPw.Focus()
        End If
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        password.childform(verification)
    End Sub

    Private Sub chkShowPassword_CheckedChanged(sender As Object, e As EventArgs) Handles chkShowPassword.CheckedChanged
        If chkShowPassword.Checked = True Then
            txtNewPw.UseSystemPasswordChar = False
            txtConfirmPw.UseSystemPasswordChar = False
        Else
            txtNewPw.UseSystemPasswordChar = True
            txtConfirmPw.UseSystemPasswordChar = True
        End If
    End Sub


End Class