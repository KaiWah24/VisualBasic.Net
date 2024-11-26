Imports System.Data.SqlClient

Public Class customerMenu
    Friend strCurrentCustID As String
    Friend strCurrentCustStatus As String
    Friend strCurrentDateJoined As String
    Friend strCurrentName As String
    Friend strCurrentGender As String
    Friend strCurrentEmail As String
    Friend strCurrentPhone As String
    Friend strCurrentDateOfBirth As String
    Friend strCurrentAge As String
    Friend strCurrentTier As String
    Friend strCurrentCaddress As String
    Friend strCurrentPaddress As String
    Friend strCurrentPoints As String
    Friend strTotalRedeemPoints As String

    'Private selectedRowIndex As Integer = -1
    'Private intSelectedCustomer As Integer = -1

    Private Sub txtSearhCust_GotFocus(sender As Object, e As EventArgs) Handles txtSearhCust.GotFocus
        ' Clear the preview text when the TextBox gets focus
        If txtSearhCust.Text = "Enter search text..." Then
            txtSearhCust.Text = ""
            txtSearhCust.ForeColor = Color.Black ' Set the text color back to black
        End If
    End Sub

    Private Sub txtSearhCust_LostFocus(sender As Object, e As EventArgs) Handles txtSearhCust.LostFocus
        ' Restore the preview text if the TextBox is empty
        If String.IsNullOrWhiteSpace(txtSearhCust.Text) Then
            txtSearhCust.Text = "Enter search text..."
            txtSearhCust.ForeColor = Color.Gray ' Set the text color to gray for the preview
        End If
    End Sub
    Private Sub btnCustClear_Click(sender As Object, e As EventArgs) Handles btnCustClear.Click
        ' Check if the textbox has text and it's not the preview text
        If Not String.IsNullOrEmpty(txtSearhCust.Text) AndAlso txtSearhCust.Text <> "Enter search text..." Then
            ' Clear the text
            txtSearhCust.Text = ""
        End If
    End Sub

    Private Sub btnAddCustomer_Click(sender As Object, e As EventArgs) Handles btnAddCustomer.Click
        Customer.lblCustAdd.Show()
        addCustomer.ShowDialog()
    End Sub
    Private Sub customerMenu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'set the text of search to enter search text when the form load
        ' set the color so that user may think this is preview text
        txtSearhCust.Text = "Enter search text..."
        txtSearhCust.ForeColor = Color.Gray

        cboSearch.SelectedItem = 0

        'Me.CustomerTableAdapter.Fill(Me.CustomerDataSet.Customer)
        Try

            If OpenConnection() = True Then
                'Active customer count'
                Dim strActiveCountSql As String = "SELECT COUNT(*) FROM Customer WHERE customer_Status = 'Active'"
                Dim intActiveCustomerCount As Integer = GetCount(strActiveCountSql)

                ' Inactive customer count
                Dim strInactiveCountSql As String = "SELECT COUNT(*) FROM Customer WHERE customer_Status = 'Inactive'"
                Dim intInactiveCustomerCount As Integer = GetCount(strInactiveCountSql)

                ' Total customer count
                Dim strTotalCustomerCountSql As String = "SELECT COUNT(*) FROM Customer"
                Dim intTotalCustomerCount As Integer = GetCount(strTotalCustomerCountSql)

                lblActiveCount.Text = intActiveCustomerCount.ToString()
                lblInactiveCount.Text = intInactiveCustomerCount.ToString()
                lblTotalCount.Text = intTotalCustomerCount.ToString()
            End If
        Catch ex As Exception
            MessageBox.Show("Error loading customer counts.", "Error")
        Finally
            CloseConnection()
        End Try
        LoadDataGrid()

        UpdateCustomerTier(strCurrentCustID, Convert.ToInt32(strCurrentPoints))

        dgvMenu.Update()
        dgvMenu.Refresh()
    End Sub

    Private Sub LoadDataGrid()
        ' Your existing code to load data goes here...
        Try
            If OpenConnection() = True Then
                Dim strSql As String = "SELECT * FROM Customer"
                Dim MySqlCommand As New SqlCommand(strSql, connection)
                Dim da As New SqlDataAdapter(MySqlCommand)
                Dim dataTable As New DataTable()

                da.Fill(dataTable)
                dgvMenu.DataSource = dataTable
            End If
        Catch ex As Exception
            MessageBox.Show("Error loading data.", "Error")
        Finally
            CloseConnection()
        End Try
    End Sub
    Private Sub PerformSearch()
        If cboSearch.SelectedItem IsNot Nothing Then
            Dim searchBy As String = cboSearch.SelectedItem.ToString()
            Dim searchTerm As String = txtSearhCust.Text.Trim()

            If OpenConnection() Then
                Dim strSql As String

                If cboSearch.SelectedItem.ToString() = "All" Then
                    ' Generate SQL query to search across all columns
                    strSql = "SELECT * FROM Customer WHERE "
                    Dim isFirstColumn As Boolean = True

                    For Each column As DataColumn In dgvMenu.DataSource.Columns
                        If isFirstColumn Then
                            isFirstColumn = False
                        Else
                            strSql &= " OR "
                        End If

                        strSql &= "[" & column.ColumnName & "] LIKE @searchTerm"
                    Next
                Else
                    ' Handle other cases based on the selected criteria
                    Select Case searchBy
                        Case "ID"
                            strSql = "SELECT * FROM Customer WHERE customer_id LIKE @searchTerm"
                        Case "Name"
                            strSql = "SELECT * FROM Customer WHERE customer_name LIKE @searchTerm"
                        Case "Phone number"
                            strSql = "SELECT * FROM Customer WHERE customer_phone_number LIKE @searchTerm"
                        Case "Email"
                            strSql = "SELECT * FROM Customer WHERE customer_email LIKE @searchTerm"
                    End Select
                End If

                Dim MySqlCommand As New SqlCommand(strSql, connection)
                MySqlCommand.Parameters.AddWithValue("@SearchTerm", "%" & searchTerm & "%")

                Dim da As New SqlDataAdapter(MySqlCommand)
                Dim dataTable As New DataTable()

                Try
                    da.Fill(dataTable)
                    dgvMenu.DataSource = dataTable
                Catch ex As Exception
                    MessageBox.Show("Error performing search: " & ex.Message, "Error")
                Finally
                    CloseConnection()
                End Try
            End If
        End If
    End Sub

    Private Function GetCount(query As String) As Integer
        Using sqlCommand As New SqlCommand()
            With sqlCommand
                .Connection = connection
                .CommandType = CommandType.Text
                .CommandText = query
            End With

            Return Convert.ToInt32(sqlCommand.ExecuteScalar())
        End Using
    End Function

    Private Sub btnSearchCustomer_Click(sender As Object, e As EventArgs) Handles btnSearchCustomer.Click
        PerformSearch()
    End Sub
    Private Sub txtSearhCust_TextChanged(sender As Object, e As EventArgs) Handles txtSearhCust.TextChanged
        ' Ensure there is at least one item in the ComboBox
        If cboSearch.Items.Count > 0 Then
            ' Perform the search when the text in the TextBox changes
            PerformSearch()
        End If
    End Sub
    Private Sub dgvMenu_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvMenu.CellClick
        If e.RowIndex >= 0 Then ' Make sure a valid row is selected
            ' Get the selected customer ID from the first column (assuming it's in the first column)
            Dim selectedRow As DataGridViewRow = dgvMenu.Rows(e.RowIndex)


            strCurrentCustID = selectedRow.Cells(0).Value.ToString()
            strCurrentDateJoined = selectedRow.Cells(1).Value.ToString()
            strCurrentCustStatus = selectedRow.Cells(2).Value.ToString()
            strCurrentName = selectedRow.Cells(3).Value.ToString()
            strCurrentGender = selectedRow.Cells(4).Value.ToString()
            strCurrentEmail = selectedRow.Cells(5).Value.ToString()
            strCurrentPhone = selectedRow.Cells(6).Value.ToString()
            strCurrentDateOfBirth = selectedRow.Cells(7).Value.ToString()
            strCurrentAge = selectedRow.Cells(8).Value.ToString()
            strCurrentTier = selectedRow.Cells(9).Value.ToString()
            strCurrentCaddress = selectedRow.Cells(10).Value.ToString()
            strCurrentPaddress = selectedRow.Cells(11).Value.ToString()
            strCurrentPoints = selectedRow.Cells(12).Value.ToString()
            strTotalRedeemPoints = selectedRow.Cells(13).Value.ToString()
        End If
    End Sub

    Private Sub btnViewDetails_Click(sender As Object, e As EventArgs) Handles btnViewDetails.Click
        customerDetails.Show()
        dgvMenu.DataSource = GetCustomer()
        Me.Close()
    End Sub
    Private Function GetCustomer() As DataTable
        Dim strSql As String = "SELECT * FROM Customer"
        OpenConnection()

        Dim MySqlCommand As New SqlCommand(strSql, connection)
        Dim adapter As New SqlDataAdapter(MySqlCommand)
        Dim table As New DataTable()

        adapter.Fill(table)
        CloseConnection()

        Return table
    End Function
    Private Sub UpdateCustomerTier(customerID As String, earnedPoints As Integer)
        Try
            If OpenConnection() = True Then
                Dim tableName As String = "Customer"
                Dim pointsColumnName As String = "customer_lifetime_earned_points"
                Dim tierColumnName As String = "customer_tier"

                Dim query As String = "UPDATE " & tableName & " SET " & tierColumnName & " = " &
                                      "CASE " &
                                      "   WHEN " & pointsColumnName & " >= 500 AND " & pointsColumnName & " <= 749 THEN 'Standard Tier' " &
                                      "   WHEN " & pointsColumnName & " >= 750 AND " & pointsColumnName & " <= 1250 THEN 'Silver Tier' " &
                                      "   WHEN " & pointsColumnName & " >= 1251 AND " & pointsColumnName & " <= 3500 THEN 'Gold Tier' " &
                                      "   WHEN " & pointsColumnName & " >= 3551 AND " & pointsColumnName & " <= 6000 THEN 'Platinum Tier' " &
                                      "   WHEN " & pointsColumnName & " > 10000 THEN 'Diamond Tier' " &
                                      "END"

                Using updateCommand As New SqlCommand(query, connection)
                    updateCommand.ExecuteNonQuery()
                End Using
            End If
        Catch ex As Exception
            MessageBox.Show("Error updating customer tier: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            CloseConnection()
        End Try
    End Sub

    Private Sub PictureBox16_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        editCustomer.ShowDialog()

    End Sub

    Private Sub dgvMenu_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvMenu.CellContentClick

    End Sub
End Class