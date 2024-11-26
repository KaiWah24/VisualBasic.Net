Imports System.Data.SqlClient

Public Class frmCustomer

    Private connectionString As String = "Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\fungp\source\repos\posSystem\posSystem\Pos.mdf;Integrated Security=True"
    Public connection As New System.Data.SqlClient.SqlConnection
    Private Const dblPOINT_NEEDED_TO_CASH As Double = 100.0R
    Friend Shared strValidCustomerId As String = ""


    Public Sub OpenConnection()
        Try
            ' Open the database connection
            connection.Open()
            Console.WriteLine("Connection opened successfully.")
        Catch ex As Exception
            Console.WriteLine("Error opening connection: " & ex.Message)
        End Try
    End Sub

    Public Sub CloseConnection()
        Try
            ' Close the database connection
            connection.Close()
            Console.WriteLine("Connection closed successfully.")
        Catch ex As Exception
            Console.WriteLine("Error closing connection: " & ex.Message)
        End Try
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub

    Private Sub btnConfirm_Click(sender As Object, e As EventArgs) Handles btnConfirm.Click

        Dim dataTable As New DataTable()
        connection.ConnectionString = connectionString

        OpenConnection()

        Dim sql As New SqlCommand("SELECT * FROM Customer WHERE customer_phone_number = @Param1", connection)
        sql.Parameters.AddWithValue("@Param1", lblCustomerContact.Text)

        Dim dataAdapter As New SqlDataAdapter(sql)
        dataAdapter.Fill(dataTable)

        If dataTable.Rows.Count > 0 Then
            Dim row As DataRow = dataTable.Rows(0)
            Dim strCustomerId As String = row("customer_id").ToString()
            Dim strCustomerName As String = row("customer_name").ToString()
            Dim strCustomerStatus As String = row("customer_status").ToString()
            Dim intLoyaltyPoint As Integer = row("customer_current_points")

            Dim dblConveretedToCash As Double = intLoyaltyPoint / dblPOINT_NEEDED_TO_CASH

            frmSales.lblCustomerName.Text = strCustomerName
            frmSales.lblCustomerStatus.Text = strCustomerStatus
            frmSales.lblLoyaltyPoint.Text = intLoyaltyPoint.ToString("N0")
            frmSales.lblConvertedToCash.Text = dblConveretedToCash.ToString("N2")
            strValidCustomerId = strCustomerId

            SetValidCustomerId(strValidCustomerId)

        Else
            MessageBox.Show("No id found, please try again", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If

        Me.Close()
    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click

        If txtCustomerInput.Text IsNot "" Then
            Dim dataTable As New DataTable()


            OpenConnection()

            Dim strSql As New SqlCommand("SELECT * FROM Customer WHERE customer_id LIKE @Param1 Or customer_phone_number LIKE @Param1", connection)
            strSql.Parameters.AddWithValue("@Param1", "%" & txtCustomerInput.Text & "%")

            Dim dataAdapter As New SqlDataAdapter(strSql)
            dataAdapter.Fill(dataTable)

            If dataTable.Rows.Count > 0 Then

                Dim row As DataRow = dataTable.Rows(0)

                lblCustomerName.Text = row("customer_name").ToString()
                lblCustomerContact.Text = row("customer_phone_number").ToString()

            Else

            End If

        Else
            MessageBox.Show("Empty input, please enter either customer's id or customer's contact", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If

        CloseConnection()

    End Sub

    Private Sub txtCustomerInput_Enter(sender As Object, e As EventArgs) Handles txtCustomerInput.Enter
        Me.AcceptButton = btnSearch
    End Sub
End Class