Imports System.Text
Imports System.Data.SqlClient

Public Class Login
    Friend intloggedInStaff As Integer
    Friend dateLoginDate As DateTime
    Private Sub LinkForgetPassword_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkForgetPassword.LinkClicked
        Password.ShowDialog()

    End Sub

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        Dim MySqlCommand As New SqlCommand
        Dim strSql As String = "SELECT * FROM Staff WHERE staff_id = @staff_id AND staff_password = @staff_password"
        Dim strLoginDateSql As String = "INSERT INTO login(login_staff_id, login_date_time) VALUES (@staff_id, @login_date_time)"
        Dim err As New StringBuilder()
        Dim ctr As Control = Nothing

        'validate empty input
        If txtID.Text = "" Then
            err.AppendLine("- Staff ID is empty ")
            ctr = If(ctr, txtID)
        End If

        If txtPassword.Text = "" Then
            err.AppendLine("- Password is empty ")
            ctr = If(ctr, txtPassword)
        End If

        If err.Length > 0 Then
            MessageBox.Show(err.ToString(), "Login fail", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            ctr.Focus()
            Return
        End If

        'validate with database 
        OpenConnection()
        MySqlCommand = New SqlCommand(strSql, connection)
        MySqlCommand.Parameters.AddWithValue("@staff_id", txtID.Text)
        MySqlCommand.Parameters.AddWithValue("@staff_password", txtPassword.Text)
        Dim reader As SqlDataReader = MySqlCommand.ExecuteReader()
        reader.Read()
        If reader.HasRows Then
            If reader("staff_status") = "Active" Then
                intloggedInStaff = reader("staff_id")
                dateLoginDate = DateTime.Now

                ' Close the reader before executing the next command
                reader.Close()

                Using loginDateCommand = New SqlCommand(strLoginDateSql, connection)
                    loginDateCommand.Parameters.AddWithValue("@staff_id", txtID.Text)
                    loginDateCommand.Parameters.AddWithValue("@login_date_time", dateLoginDate)
                    loginDateCommand.ExecuteNonQuery()
                End Using

                Main.ShowDialog()
            Else
                MessageBox.Show("Your account has been terminated.", "Login failed", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Else
            MessageBox.Show("Invalid login credentials. Please try again.", "Login failed", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
        CloseConnection()

    End Sub

    'show password
    Private Sub chkShowPassword_Click(sender As Object, e As EventArgs) Handles chkShowPassword.Click
        If chkShowPassword.Checked = True Then
            txtPassword.UseSystemPasswordChar = False
        Else
            txtPassword.UseSystemPasswordChar = True
        End If
    End Sub

    Private Sub Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
