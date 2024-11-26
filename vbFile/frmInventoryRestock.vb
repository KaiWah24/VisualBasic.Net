Imports System.Data.SqlClient
Imports System.Text.RegularExpressions

Public Class frmInventoryRestock
    Private ds As DataSet = New DataSet()
    Private da As SqlDataAdapter
    Private intCount As Integer = 0I
    Private buttonColumn As New DataGridViewButtonColumn()
    Private Sub frmInventoryRestock_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        dgvRestock.Width = Me.ClientSize.Width - dgvRestock.Left * 2
        dgvRestock.Height = Me.ClientSize.Height - dgvRestock.Top * 2
        LoadData()

        Reload()
        dgvRestock.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill

    End Sub
    Private Sub Reload()
        ' Check if the button column exists
        For Each column As DataGridViewColumn In dgvRestock.Columns
            If column.Name = "btnColumn" Then
                dgvRestock.Columns.Remove(column) ' Remove the button column if it exists
                Exit For ' Exit the loop once removed
            End If
        Next

        ' Clear ComboBox items and re-add
        dgvRestockColumnSupplier.Items.Clear()
        dgvRestockColumnSupplier.Items.Add("KW Sdn Bhd")
        dgvRestockColumnSupplier.Items.Add("FP Sdn Bhd")
        dgvRestockColumnSupplier.Items.Add("MK Sdn Bhd")

        ' Create the button column
        Dim buttonColumn As New DataGridViewButtonColumn()
        buttonColumn.HeaderText = "Action"
        buttonColumn.Text = "Restock"
        buttonColumn.Name = "btnColumn"
        buttonColumn.UseColumnTextForButtonValue = True

        ' Add the button column to the DataGridView
        dgvRestock.Columns.Add(buttonColumn)
    End Sub
    Private Sub LoadData()
        Dim strSql As String

        If OpenConnection() = True Then
            strSql = "Select * From Product WHERE product_status = 'on shelves'"
            Dim cmd As New SqlCommand(strSql, connection)

            da = New SqlDataAdapter(cmd)
            ds.Clear()
            da.Fill(ds, "Product")
            dgvRestock.Rows.Clear()

            dgvRestock.Columns("dgvRestockColumnName").ReadOnly = True
            dgvRestock.Columns("dgvRestockColumnPrice").ReadOnly = True
            dgvRestock.Columns("dgvRestockColumnRemainingStock").ReadOnly = True
            dgvRestock.Columns("dgvRestockColumnTodayDate").ReadOnly = True
            dgvRestock.Columns("dgvRestockColumnTotalPrice").ReadOnly = True
            dgvRestock.Columns("dgvRestockColumnRestockPrice").ReadOnly = True
            dgvRestock.Columns("dgvRestockColumnHandleBy").ReadOnly = True

            For i As Integer = 0 To ds.Tables("Product").Rows.Count - 1

                Dim row As DataRow = ds.Tables("Product").Rows(i)
                Dim decPrice As Decimal = row(2)
                Dim decRestockPrice As Decimal = row(2) * 0.2
                Dim decSubTotal As Decimal = row(2) - decRestockPrice
                Dim intRemainingQuantity As Integer = row(3)


                dgvRestock.Rows.Add()
                dgvRestock.Rows(i).Cells("dgvRestockColumnProductId").Value = row(0)
                dgvRestock.Rows(i).Cells("dgvRestockColumnName").Value = row(1)
                dgvRestock.Rows(i).Cells("dgvRestockColumnPrice").Value = decPrice.ToString("C", System.Globalization.CultureInfo.GetCultureInfo("ms-MY"))
                dgvRestock.Rows(i).Cells("dgvRestockColumnRemainingStock").Value = intRemainingQuantity
                dgvRestock.Rows(i).Cells("dgvRestockColumnRestockPrice").Value = decSubTotal.ToString("C", System.Globalization.CultureInfo.GetCultureInfo("ms-MY"))
                dgvRestock.Rows(i).Cells("dgvRestockColumnTodayDate").Value = DateTime.Now.Date.ToString("d")
                dgvRestock.Rows(i).Cells("dgvRestockColumnHandleBy").Value = Main.strStaffName


                If intRemainingQuantity <= 20 Then
                    dgvRestock.Rows(i).Cells("dgvRestockColumnRemainingStock").Style.ForeColor = Color.Red
                    dgvRestock.Rows(i).Cells("dgvRestockColumnRemainingStock").Style.BackColor = Color.LightPink ' Set the background color
                Else
                    dgvRestock.Rows(i).Cells("dgvRestockColumnRemainingStock").Style.ForeColor = dgvRestock.DefaultCellStyle.ForeColor ' Reset to default text color
                    dgvRestock.Rows(i).Cells("dgvRestockColumnRemainingStock").Style.BackColor = dgvRestock.DefaultCellStyle.BackColor ' Reset to default background color
                End If
            Next
            CloseConnection()
        Else
            MessageBox.Show("Error in connecting to database server", "Error", MessageBoxButtons.OK)

        End If

    End Sub


    Private Sub dgvRestock_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvRestock.CellContentClick
        If e.ColumnIndex = dgvRestock.Columns("btnColumn").Index AndAlso e.RowIndex >= 0 Then
            Dim productName As String = dgvRestock.Rows(e.RowIndex).Cells("dgvRestockColumnName").Value.ToString()
            Dim restockQuantity As Integer = Convert.ToInt32(dgvRestock.Rows(e.RowIndex).Cells("dgvRestockColumnRestockQuantity").Value)

            If e.ColumnIndex = dgvRestock.Columns("btnColumn").Index AndAlso e.RowIndex >= 0 Then
                ' Check if the quantity and supplier have been entered
                Dim quantityCellValue As Object = dgvRestock.Rows(e.RowIndex).Cells("dgvRestockColumnRestockQuantity").Value
                Dim supplierCellValue As Object = dgvRestock.Rows(e.RowIndex).Cells("dgvRestockColumnSupplier").Value

                If quantityCellValue IsNot Nothing AndAlso Not String.IsNullOrWhiteSpace(quantityCellValue.ToString()) AndAlso
           supplierCellValue IsNot Nothing AndAlso Not String.IsNullOrWhiteSpace(supplierCellValue.ToString()) Then
                    If OpenConnection() Then
                        Dim strSql As String = "INSERT INTO Restock (restock_id,restock_productId,restock_productName,restock_productPrice,restock_remainingQuantity,restock_quantity,restock_price,restock_totalPrice,restock_supplier,restock_date,restock_staffName) VALUES (@restock_id,@restock_productId,@restock_productName,@restock_productPrice,@restock_remainingQuantity,@restock_quantity,@restock_price,@restock_totalPrice,@restock_supplier,@restock_date,@restock_staffName)"
                        Dim decProductPrice As Decimal = NumberConvertion(dgvRestock.Rows(e.RowIndex).Cells("dgvRestockColumnPrice").Value)
                        Dim decRestockPrice As Decimal = NumberConvertion(dgvRestock.Rows(e.RowIndex).Cells("dgvRestockColumnRestockPrice").Value)
                        Dim decTotalPrice As Decimal = NumberConvertion(dgvRestock.Rows(e.RowIndex).Cells("dgvRestockColumnTotalPrice").Value)

                        Using cmd As New SqlCommand(strSql, connection)
                            cmd.Parameters.AddWithValue("@restock_id", GetNextId())
                            cmd.Parameters.AddWithValue("@restock_productId", dgvRestock.Rows(e.RowIndex).Cells("dgvRestockColumnProductId").Value)
                            cmd.Parameters.AddWithValue("@restock_productName", dgvRestock.Rows(e.RowIndex).Cells("dgvRestockColumnName").Value)
                            cmd.Parameters.AddWithValue("@restock_productPrice", decProductPrice.ToString)
                            cmd.Parameters.AddWithValue("@restock_remainingQuantity", dgvRestock.Rows(e.RowIndex).Cells("dgvRestockColumnRemainingStock").Value)
                            cmd.Parameters.AddWithValue("@restock_quantity", dgvRestock.Rows(e.RowIndex).Cells("dgvRestockColumnRestockQuantity").Value)
                            cmd.Parameters.AddWithValue("@restock_price", decRestockPrice.ToString)
                            cmd.Parameters.AddWithValue("@restock_totalPrice", decTotalPrice.ToString)
                            cmd.Parameters.AddWithValue("@restock_supplier", dgvRestock.Rows(e.RowIndex).Cells("dgvRestockColumnSupplier").Value)
                            cmd.Parameters.AddWithValue("@restock_date", dgvRestock.Rows(e.RowIndex).Cells("dgvRestockColumnTodayDate").Value)
                            cmd.Parameters.AddWithValue("@restock_staffName", dgvRestock.Rows(e.RowIndex).Cells("dgvRestockColumnHandleBy").Value)
                            UpdateQuantity(dgvRestock.Rows(e.RowIndex).Cells("dgvRestockColumnProductId").Value, dgvRestock.Rows(e.RowIndex).Cells("dgvRestockColumnRemainingStock").Value, dgvRestock.Rows(e.RowIndex).Cells("dgvRestockColumnRestockQuantity").Value)
                            cmd.ExecuteNonQuery()
                            MessageBox.Show("Item has been restocked", "Successful", MessageBoxButtons.OK)
                            CloseConnection()
                            LoadData()
                            Reload()
                        End Using
                    End If
                Else
                    MessageBox.Show("Please enter the quantity and choose a supplier.", "Incomplete Information", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                End If
            End If
        End If
    End Sub
    Public Function GetNextId() As String
        Dim strSql As String
        strSql = "Select * From Restock"
        da = New SqlDataAdapter(strSql, connection)
        ds.Clear()
        da.Fill(ds, "Restock")
        intCount = ds.Tables("Restock").Rows.Count
        Return (intCount + 1).ToString("R1000")
    End Function
    Private Sub dgvRestock_CellEndEdit(sender As Object, e As DataGridViewCellEventArgs) Handles dgvRestock.CellEndEdit
        ' Get the DataGridView column index by its name
        Dim restockPriceIndex As Integer = dgvRestock.Columns("dgvRestockColumnRestockPrice").Index
        Dim restockQuantityIndex As Integer = dgvRestock.Columns("dgvRestockColumnRestockQuantity").Index

        ' Check if the editing cell is in the restock quantity column
        If e.ColumnIndex = restockQuantityIndex AndAlso e.RowIndex >= 0 Then
            ' Check if the quantity cell is not empty and contains only digits
            Dim cellValue As String = dgvRestock.Rows(e.RowIndex).Cells(restockQuantityIndex).Value?.ToString()
            If Not String.IsNullOrEmpty(cellValue) AndAlso IsNumeric(cellValue) AndAlso Integer.TryParse(cellValue, Nothing) Then
                ' Retrieve the subtotal and quantity values
                Dim strSubtotal As String = dgvRestock.Rows(e.RowIndex).Cells(restockPriceIndex).Value.ToString()
                Dim intRestockQuantity As Integer = CInt(cellValue)

                ' Calculate total if the quantity is a valid integer
                Dim total As Decimal = NumberConvertion(strSubtotal) * intRestockQuantity
                dgvRestock.Rows(e.RowIndex).Cells("dgvRestockColumnTotalPrice").Value = total.ToString("C", System.Globalization.CultureInfo.GetCultureInfo("ms-MY"))
            Else
                ' Quantity cell is empty or contains non-numeric characters
                MessageBox.Show("Please enter a valid quantity (digits only).")
                ' You might also consider setting a default value or handling the invalid input case accordingly.
            End If
        End If
    End Sub

    Private Sub UpdateQuantity(strId As String, decProductQuantity As Decimal, decRestockQuantity As Decimal)
        Dim strSql As String
        Dim decTotal As Decimal

        strSql = "Update Product set product_quantity=@product_quantity Where product_id=@product_id"
        Dim cmd As New SqlCommand(strSql, connection)

        decTotal = decProductQuantity + decRestockQuantity
        cmd.Parameters.AddWithValue("@product_id", strId)
        cmd.Parameters.AddWithValue("@product_quantity", decTotal)
        cmd.ExecuteNonQuery()

    End Sub
    Private Function NumberConvertion(strNumber As String) As Single
        Dim pattern As String = "\d+(\.\d+)?"
        Dim priceMatch As Match = Regex.Match(strNumber, pattern)

        If priceMatch.Success Then
            Dim number As Single
            If Single.TryParse(priceMatch.Value, number) Then
                ' Format the number to two decimal places
                Return Math.Round(number, 2)
            End If
        End If

        ' Return a default value if the parsing fails
        Return 0.0F ' Or any default value you prefer
    End Function
End Class