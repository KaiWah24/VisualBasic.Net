Imports System.Data.SqlClient
Public Class changePassword
    Private Sub LinkForgetPassword_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkForgetPassword.LinkClicked
        Password.ShowDialog()
    End Sub

    Private Sub btnConfirm_Click(sender As Object, e As EventArgs) Handles btnConfirm.Click
        Dim MySqlCommand As New SqlCommand
        Dim strSql As String = "SELECT * FROM Staff WHERE staff_id = @staff_id"
        Dim strOldPw As String
        OpenConnection()
        MySqlCommand = New SqlCommand(strSql, connection)
        MySqlCommand.Parameters.AddWithValue("@staff_id", Login.intloggedInStaff)
        Dim reader As SqlDataReader = MySqlCommand.ExecuteReader()

        reader.Read()
        strOldPw = txtOldPw.Text

        If strOldPw = reader("staff_password") Then
            If txtNewPw.Text = txtConfirmPw.Text Then
                reader.Close()
                changePassword()
                clearAll()
                Me.Close()
            Else
                MessageBox.Show("New password did not match with confirm password", "Failed Reset", MessageBoxButtons.OK, MessageBoxIcon.Error)
                txtNewPw.Focus()
            End If
        Else
            MessageBox.Show("Old password does not match", "Failed Reset", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtOldPw.Focus()
        End If
        reader.Close()
        CloseConnection()

    End Sub

    Private Sub changePassword()
        Dim strSql As String
        Dim MySqlCommand As New SqlCommand
        strSql = "UPDATE Staff SET staff_password = @staff_password WHERE staff_id = @staff_id"
        MySqlCommand = New SqlCommand(strSql, connection)

        With MySqlCommand.Parameters
            .AddWithValue("@staff_id", Login.intloggedInStaff)
            .AddWithValue("@staff_password", txtConfirmPw.Text)
        End With
        MySqlCommand.ExecuteNonQuery()
        MessageBox.Show("Password Change successful.", "Change Password")
        CloseConnection()
    End Sub

    Private Sub chkShowPassword_Click(sender As Object, e As EventArgs) Handles chkShowPassword.Click
        If chkShowPassword.Checked = True Then
            txtOldPw.UseSystemPasswordChar = False
            txtNewPw.UseSystemPasswordChar = False
            txtConfirmPw.UseSystemPasswordChar = False
        Else
            txtOldPw.UseSystemPasswordChar = True
            txtNewPw.UseSystemPasswordChar = True
            txtConfirmPw.UseSystemPasswordChar = True
        End If
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        clearAll()
        Me.Close()
    End Sub

    Private Sub clearAll()
        txtConfirmPw.Text = ""
        txtNewPw.Text = ""
        txtOldPw.Text = ""
    End Sub

End Class