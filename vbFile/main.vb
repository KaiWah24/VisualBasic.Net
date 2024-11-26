Imports System.Data.SqlClient
Public Class Main
    Friend myProfile As Boolean
    Friend strStaffName As String
    Private Sub Main_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim MySqlCommand As New SqlCommand


        Dim strSql As String = "SELECT * FROM Staff WHERE staff_id = @staff_id"

        OpenConnection()
        MySqlCommand = New SqlCommand(strSql, connection)
        MySqlCommand.Parameters.AddWithValue("@staff_id", Login.intloggedInStaff)
        Dim reader As SqlDataReader = MySqlCommand.ExecuteReader()

        reader.Read()
        strStaffName = reader("staff_name")
        lblWelcome.Text = "Welcome " & strStaffName
        reader.Close()


        CloseConnection()
    End Sub

    'fp part
    Private Sub picSales_Click(sender As Object, e As EventArgs) Handles picSales.Click, grpSales.Click, lblSales.Click
        SalesMenu.Show()
    End Sub

    'ck part
    Private Sub picInventory_Click(sender As Object, e As EventArgs) Handles picInventory.Click, grpInventory.Click, lblInventory.Click
        frmInventory.Show()
    End Sub

    'kw part
    Private Sub picPromotion_Click(sender As Object, e As EventArgs) Handles picPromotion.Click, grpPromotion.Click, lblPromotion.Click

    End Sub

    Private Sub picCustomer_Click(sender As Object, e As EventArgs) Handles picCustomer.Click, grpCustomer.Click, lblCustomer.Click
    End Sub

    'mk part
    Private Sub picProfile_Click(sender As Object, e As EventArgs) Handles picProfile.Click, grpProfile.Click, lblProfile.Click
        myProfile = True
        staff.ShowDialog()

    End Sub


    Private Sub picStaff_Click(sender As Object, e As EventArgs) Handles picStaff.Click, grpStaff.Click, lblStaff.Click
        staff.ShowDialog()
    End Sub

    Private Sub picExit_Click(sender As Object, e As EventArgs) Handles picExit.Click
        Me.Close()
        myProfile = False
    End Sub

    Private Sub Main_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        logout()

    End Sub

    Private Sub logout()
        Dim MySqlCommand As New SqlCommand
        Dim strLoginDateSql As String = "UPDATE login SET logout_date_time = @logout_date_time WHERE login_date_time = @login_date_time AND login_staff_id = @login_staff_id"

        OpenConnection()
        MySqlCommand = New SqlCommand(strLoginDateSql, connection)
        With MySqlCommand.Parameters
            .AddWithValue("@logout_date_time", DateTime.Now)
            .AddWithValue("@login_date_time", Login.dateLoginDate)
            .AddWithValue("@Login_staff_id", Login.intloggedInStaff)

        End With
        MySqlCommand.ExecuteNonQuery()
        MessageBox.Show("Logout Successful.", "Logout")
        CloseConnection()

    End Sub


End Class