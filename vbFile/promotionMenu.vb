Imports System.Data.SqlClient

Public Class promotionMenu
    Friend strPromoID, strPromoName, strPromoStartDate, strPromoEndDate, strPromoType, strPromoDiscountType, strPromoDiscountValue, strPromoStatus, strPromoProductID, strVoucherCode, strUsageLimit, strUsageCount As String

    Private Sub dgvPromoMenu_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvPromoMenu.CellClick
        If e.RowIndex >= 0 Then ' Make sure a valid row is selected
            ' Get the selected customer ID from the first column (assuming it's in the first column)
            Dim selectedRow As DataGridViewRow = dgvPromoMenu.Rows(e.RowIndex)

            strPromoID = selectedRow.Cells(0).Value.ToString()
            strPromoName = selectedRow.Cells(1).Value.ToString()
            strPromoStartDate = selectedRow.Cells(2).Value.ToString()
            strPromoEndDate = selectedRow.Cells(3).Value.ToString()
            strPromoType = selectedRow.Cells(4).Value.ToString()
            strPromoDiscountType = selectedRow.Cells(5).Value.ToString()
            strPromoDiscountValue = selectedRow.Cells(6).Value.ToString()
            strPromoStatus = selectedRow.Cells(7).Value.ToString()
            strPromoProductID = selectedRow.Cells(8).Value.ToString()
            strVoucherCode = selectedRow.Cells(9).Value.ToString()
            strUsageLimit = selectedRow.Cells(10).Value.ToString()
            strUsageCount = selectedRow.Cells(11).Value.ToString()
        End If
    End Sub

    Private Sub btnEdit(sender As Object, e As EventArgs)
        ' Check if a row is selected in the DataGridView
        If dgvPromoMenu.SelectedRows.Count > 0 Then
            ' If a row is selected, proceed with showing details
            customerDetails.ShowDialog()
            dgvPromoMenu.DataSource = GetPromotion()
        Else
        End If
    End Sub

    Private Function GetPromotion() As DataTable
        Dim strSql As String = "SELECT * FROM Promotion"
        OpenConnection()

        Dim MySqlCommand As New SqlCommand(strSql, connection)
        Dim adapter As New SqlDataAdapter(MySqlCommand)
        Dim table As New DataTable()

        adapter.Fill(table)
        CloseConnection()

        Return table
    End Function
    Private Sub PictureBox18_Click(sender As Object, e As EventArgs)
    End Sub

    Private Sub PictureBox17_Click(sender As Object, e As EventArgs)
        Me.Hide()
        addPromotion.ShowDialog()
    End Sub

    Private Sub Label21_Click(sender As Object, e As EventArgs)
        addPromotion.ShowDialog()
        Me.Close()

    End Sub

    Private Sub PictureBox14_Click(sender As Object, e As EventArgs)
        promotionReport.ShowDialog(Me)
        Me.Close()
    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs)
        promotionReport.ShowDialog()
        Me.Close()
    End Sub

    Private Sub btnEditPromotion_Click(sender As Object, e As EventArgs) Handles btnEditPromotion.Click
        ' Check if a row is selected in the DataGridView
        If dgvPromoMenu.SelectedRows.Count > 0 Then
            ' If a row is selected, proceed with showing details
            editPromotion.ShowDialog()
            dgvPromoMenu.DataSource = GetPromotion()
        End If
    End Sub

    Private Sub Panel7_Paint(sender As Object, e As PaintEventArgs)
    End Sub

    Private Sub btnAddPromotion_Click(sender As Object, e As EventArgs) Handles btnAddPromotion.Click
        addPromotion.ShowDialog()
        Me.Hide()
    End Sub

    Private Sub PromotionMenu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'CustomerDataSet1.Promotion' table. You can move, or remove it, as needed.
        Me.PromotionTableAdapter.Fill(Me.CustomerDataSet1.Promotion)

        txtSearhPromo.Text = "Enter search text..."
        txtSearhPromo.ForeColor = Color.Gray

        cboSearch.Items.Add("All")
        cboSearch.Items.Add("Promotion Name")
        cboSearch.Items.Add("Promotion Status")
        cboSearch.Items.Add("Voucher Code")

        cboSearch.SelectedIndex = 0
        cboSearch.SelectedItem = cboSearch.Items(0)

        Try

            If OpenConnection() = True Then
                'Active promo count'
                Dim strOnGoingCountSql As String = "SELECT COUNT(*) FROM Promotion WHERE promotion_status = 'Active'"
                Dim intOnGoingPromoCount As Integer = GetCount(strOnGoingCountSql)

                ' Inactive promo count
                Dim strInactiveCountSql As String = "SELECT COUNT(*) FROM Promotion WHERE promotion_status = 'Pending'"
                Dim intInactivePromoCount As Integer = GetCount(strInactiveCountSql)

                ' ended promo count
                Dim strConcludedPromoCountSql As String = "SELECT COUNT(*) FROM Promotion WHERE promotion_status = 'Ended'"
                Dim intConcludedPromoount As Integer = GetCount(strConcludedPromoCountSql)

                ' Total customer count
                Dim strTotalPromotionCountSql As String = "SELECT COUNT(*) FROM Promotion"
                Dim intTotalPromotionCount As Integer = GetCount(strTotalPromotionCountSql)

                lblOnGoingCount.Text = intOnGoingPromoCount.ToString()
                lblPendingCount.Text = intInactivePromoCount.ToString()
                lblInactiveCount.Text = intConcludedPromoount.ToString()
                lblTotalPromotion.Text = intTotalPromotionCount.ToString()

            End If
        Catch ex As Exception
            MessageBox.Show("Error loading customer counts.", "Error")
        Finally
            CloseConnection()
        End Try
        UpdateProductPromo()
        LoadDataGrid()

        dgvPromoMenu.Refresh()
    End Sub
    Private Sub txtSearhPromo_GotFocus(sender As Object, e As EventArgs) Handles txtSearhPromo.GotFocus
        ' Clear the preview text when the TextBox gets focus
        If txtSearhPromo.Text = "Enter search text..." Then
            txtSearhPromo.Text = ""
            txtSearhPromo.ForeColor = Color.Black ' Set the text color back to black
        End If
    End Sub

    Private Sub txtSearhCust_LostFocus(sender As Object, e As EventArgs) Handles txtSearhPromo.LostFocus
        ' Restore the preview text if the TextBox is empty
        If String.IsNullOrWhiteSpace(txtSearhPromo.Text) Then
            txtSearhPromo.Text = "Enter search text..."
            txtSearhPromo.ForeColor = Color.Gray ' Set the text color to gray for the preview
        End If
    End Sub
    Private Sub btnCustClear_Click(sender As Object, e As EventArgs) Handles btnCustClear.Click
        ' Check if the textbox has text and it's not the preview text
        If Not String.IsNullOrEmpty(txtSearhPromo.Text) AndAlso txtSearhPromo.Text <> "Enter search text..." Then
            ' Clear the text
            txtSearhPromo.Text = ""
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
    Private Sub LoadDataGrid()
        Dim strTodayDate As String = Date.Now.ToShortDateString()

        Try
            If OpenConnection() = True Then
                ' Load data into DataTable
                Dim strSql As String = "SELECT * FROM Promotion"
                Dim MySqlCommand As New SqlCommand(strSql, connection)
                Dim da As New SqlDataAdapter(MySqlCommand)
                Dim dataTable As New DataTable()
                da.Fill(dataTable)
                dgvPromoMenu.DataSource = dataTable
            End If
        Catch ex As Exception
            MessageBox.Show("Error loading data: " & ex.Message, "Error")
        Finally
            CloseConnection()
        End Try
    End Sub

    Private Sub UpdateProductPromo()
        Dim strTodayDate As String = Date.Now.ToShortDateString()

        Try
            If OpenConnection() = True Then

                Dim updatePromotionSql As String = "UPDATE Promotion SET promotion_status = " &
                                        "CASE " &
                                        "WHEN start_date <= @todays_date AND end_date > @todays_date THEN 'Active' " &
                                        "WHEN start_date = @todays_date AND end_date = @todays_date THEN 'Ended' " &
                                        "ELSE promotion_status " &
                                         "END"
                Dim cmdUpdatePromotion As New SqlCommand(updatePromotionSql, connection)
                cmdUpdatePromotion.Parameters.AddWithValue("@todays_date", Date.Now)


                cmdUpdatePromotion.ExecuteNonQuery()

                Dim updatePriceSql As String = "UPDATE Product SET discounted_price = 0 WHERE Product.product_id IN (SELECT Product.product_id FROM Product LEFT JOIN Promotion ON Product.product_id = Promotion.product_id WHERE Promotion.promotion_status = 'Ended')"
                Dim cmdUpdatePrice As New SqlCommand(updatePriceSql, connection)

                ' Execute the update query for discounted_price
                cmdUpdatePrice.ExecuteNonQuery()
                dgvPromoMenu.Refresh()

            End If
        Catch ex As Exception
            MessageBox.Show("Error loading data: " & ex.Message, "Error")
        Finally
            CloseConnection()
        End Try
    End Sub

    Private Sub PerformSearch()
        If cboSearch.SelectedItem IsNot Nothing Then
            Dim searchBy As String = cboSearch.SelectedItem.ToString()
            Dim searchTerm As String = txtSearhPromo.Text.Trim()

            If OpenConnection() Then
                Dim strSql As String

                If cboSearch.SelectedItem.ToString() = "All" Then
                    ' Generate SQL query to search across all columns
                    strSql = "SELECT * FROM Promotion WHERE "
                    Dim isFirstColumn As Boolean = True

                    For Each column As DataColumn In dgvPromoMenu.DataSource.Columns
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
                        Case "Promotion Name"
                            strSql = "SELECT * FROM Promotion WHERE promotion_name LIKE @searchTerm"
                        Case "Promotion Status"
                            strSql = "SELECT * FROM Promotion WHERE promotion_status LIKE @searchTerm"
                        Case "Voucher Code"
                            strSql = "SELECT * FROM Promotion WHERE voucher_code LIKE @searchTerm"
                            ' Add additional cases as needed
                    End Select
                End If

                Dim MySqlCommand As New SqlCommand(strSql, connection)
                MySqlCommand.Parameters.AddWithValue("@SearchTerm", "%" & searchTerm & "%")

                Dim da As New SqlDataAdapter(MySqlCommand)
                Dim dataTable As New DataTable()

                Try
                    da.Fill(dataTable)
                    dgvPromoMenu.DataSource = dataTable
                Catch ex As Exception
                    MessageBox.Show("Error performing search: " & ex.Message, "Error")
                Finally
                    CloseConnection()
                End Try
            End If
        End If
    End Sub

    Private Sub btnSearchPromo_Click(sender As Object, e As EventArgs) Handles btnSearchPromo.Click
        PerformSearch()
    End Sub

    Private Sub txtSearhPromo_TextChanged(sender As Object, e As EventArgs) Handles txtSearhPromo.TextChanged
        PerformSearch()
    End Sub
End Class