Imports System.Data.SqlClient
Imports System.IO
Public Class dashboard
    Private Sub dashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        lblDateTime.Text = DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss")
        TimerToday.Enabled = True

        If DateTime.Now.Hour < 12 Then
            lbltext.Text = "Good Morning"
        Else
            lbltext.Text = "Good Afternoon"
        End If
        wlcStaff()
        getLoginHistory()
    End Sub

    Private Sub TimerToday_Tick(sender As Object, e As EventArgs) Handles TimerToday.Tick
        lblDateTime.Text = Date.Now.ToString("dd-MM-yyyy HH:mm:ss")
    End Sub

    Private Sub getLoginHistory()
        Dim MySqlCommand As New SqlCommand
        Dim strSql As String = "SELECT * FROM Login WHERE login_staff_id = @login_staff_id"

        OpenConnection()

        MySqlCommand.Connection = connection
        MySqlCommand.CommandText = strSql
        MySqlCommand.Parameters.AddWithValue("@login_staff_id", Login.intloggedInStaff)

        Dim daLoginHistory As New SqlDataAdapter(MySqlCommand)
        Dim dtLoginHistory As New DataTable
        daLoginHistory.Fill(dtLoginHistory)
        dgvLogin.DataSource = dtLoginHistory

        CloseConnection()
    End Sub

    Private Sub wlcStaff()
        Dim MySqlCommand As New SqlCommand
        Dim strSql As String = "SELECT staff_image FROM Staff WHERE staff_id = @staff_id"
        OpenConnection()
        MySqlCommand = New SqlCommand(strSql, connection)
        MySqlCommand.Parameters.AddWithValue("@staff_id", Login.intloggedInStaff)
        Console.WriteLine(Login.intloggedInStaff)
        Dim reader As SqlDataReader = MySqlCommand.ExecuteReader()

        reader.Read()
        'Dim img() As Byte
        'img = reader("staff_image")
        'Dim ms As New MemoryStream(img)
        'picStaff.Image = Image.FromStream(ms)



        lblStaffName.Text = Main.strStaffName
        reader.Close()
    End Sub
End Class