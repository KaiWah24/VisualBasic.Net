Imports System.Data.Common
Imports System.Data.SqlClient
Imports System.IO
Imports System.Windows.Documents

Public Class frmSales

    Friend Const dblSERVICE_SALES_TAX = 0.06
    Friend Const dblPOINT_FOR_CONVERSION = 100
    Friend strVoucher As String = ""


    Private Sub timerCurrent_Tick(sender As Object, e As EventArgs) Handles timerCurrent.Tick
        lblCurrentTime.Text = Date.Now.ToString("F")
    End Sub
    Private Sub btnPayment_Click(sender As Object, e As EventArgs) Handles btnPayment.Click
        If DataGridView1.RowCount > 1 Then
            frmPayment.Show()
        Else
            MessageBox.Show("No items entered", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Friend Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        'Customer information
        lblCustomerName.Text = "N/A"
        lblCustomerStatus.Text = "N/A"
        lblLoyaltyPoint.Text = "N/A"
        lblConvertedToCash.Text = "N/A"
        chkRedeemPoint.Checked = False

        'Data
        DataGridView1.Rows.Clear()
        lblTtlPrice.Text = "0.00"
        rtfBarcode.Text = ""
        rtfSalesOrder.Text = ""
        rtfVoucher.Text = ""
        lblSubTotal.Text = "0.00"
        lblDiscount.Text = "0.00"
        lblPointsRedeemed.Text = "0.00"
        lblRounding.Text = "0.00"
        chkRounding.Checked = False


        'Buttons
        lblCurrentSalesOrder.Text = ""
        btnSearchSalesOrder.Enabled = True
        btnRemoveSelected.Enabled = True
        btnPayment.Enabled = True
        btnAddQty.Enabled = True
        btnReduceQty.Enabled = True
        btnRefundSelected.Enabled = False
        btnVoid.Enabled = False
        btnSearchVoucher.Enabled = True


        UpdateTotalPrice()
    End Sub


    Private Sub btnCustomer_Click(sender As Object, e As EventArgs) Handles btnCustomer.Click
        frmCustomer.Show()
    End Sub


    Private Sub btnCustomer_MouseEnter(sender As Object, e As EventArgs) Handles btnCustomer.MouseEnter, btnPayment.MouseEnter, btnVoid.MouseEnter, btnClear.MouseEnter, btnRefundSelected.MouseEnter, btnRemoveSelected.MouseEnter
        Dim btn As Button = DirectCast(sender, Button)
        btn.BackColor = Color.FromArgb(204, 217, 231)
    End Sub

    Private Sub btnCustomer_MouseLeave(sender As Object, e As EventArgs) Handles btnCustomer.MouseLeave, btnPayment.MouseLeave, btnVoid.MouseLeave, btnClear.MouseLeave, btnRefundSelected.MouseLeave, btnRemoveSelected.MouseLeave
        Dim btn As Button = DirectCast(sender, Button)
        btn.BackColor = Color.FromArgb(153, 180, 209)
    End Sub

    Private Sub btnLogout_Click(sender As Object, e As EventArgs) Handles btnLogout.Click
        Main.Show()
        Me.Close()
    End Sub

    Private Sub btnVoid_Click(sender As Object, e As EventArgs) Handles btnVoid.Click

        If lblCurrentSalesOrder.Text <> "N/A" Then
            If DataGridView1.Rows.Count > 1 Then
                For i As Integer = DataGridView1.SelectedRows.Count - 1 To 0 Step -1
                    Dim dgvRow As DataGridViewRow = DataGridView1.SelectedRows(i)
                    Dim sql As String = "UPDATE SalesItem SET voided = @Value1, refunded_amount = @Value2 WHERE sales_id = @Value3"
                    Dim dblPriceAftTax As Double = CDbl(dgvRow.Cells("colPriceAftTax").Value)
                    Dim intQTY As Integer = dgvRow.Cells("colQTY").Value
                    connection.ConnectionString = connectionString

                    OpenConnection()
                    Using command As New SqlCommand(sql, connection)

                        command.Parameters.AddWithValue("@Value1", True)
                        command.Parameters.AddWithValue("@Value2", dblPriceAftTax * intQTY)
                        command.Parameters.AddWithValue("@Value3", lblCurrentSalesOrder.Text)

                        command.ExecuteNonQuery()

                    End Using


                    sql = "UPDATE Sales SET total_price = @Value1 WHERE id = @Value2"

                    Using command As New SqlCommand(sql, connection)

                        Dim dblAdjustedTtlPrice = CDbl(lblTtlPrice.Text) - dblPriceAftTax * intQTY

                        command.Parameters.AddWithValue("@Value1", dblAdjustedTtlPrice)
                        command.Parameters.AddWithValue("@Value2", lblCurrentSalesOrder.Text)

                        command.ExecuteNonQuery()

                    End Using

                Next

                CloseConnection()
            End If
        Else
            MessageBox.Show("Sales order not found, please key in sales order id at the designated place", "Error not found", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub btnSearchBarCode_Click(sender As Object, e As EventArgs) Handles btnSearchBarCode.Click
        'search product from database
        Dim strInput As String = rtfBarcode.Text
        Dim dataTable As New DataTable()
        connection.ConnectionString = connectionString

        OpenConnection()

        'perform operation here 
        Dim command As New SqlCommand("SELECT * FROM Product WHERE product_barcode = @Barcode", connection)
        command.Parameters.AddWithValue("@Barcode", strInput)
        Dim dataAdapter As New SqlDataAdapter(command)
        dataAdapter.Fill(dataTable)

        If dataTable.Rows.Count > 0 Then
            btnSearchSalesOrder.Enabled = False

            Dim dblTotal As Double = 0
            Dim intQty As Integer = 1

            Dim row As DataRow = dataTable.Rows(0)

            'from database
            Dim strProductBarcode As String = row("product_barcode").ToString()
            Dim strItemDesc As String = row("product_description").ToString()

            Dim dblPriceBeforeTax As Double = Double.Parse(row("product_price"))
            Dim dblPriceAfterTax As Double = dblPriceBeforeTax + (dblPriceBeforeTax * dblSERVICE_SALES_TAX)

            dblTotal += dblPriceAfterTax * Double.Parse(intQty)

            Dim bolDuplicatedItem As Boolean = False

            For Each dgvRow In DataGridView1.Rows
                Dim dblCurrentColQty As Double = CDbl(dgvRow.Cells("colQTY").Value)

                Dim dblCurrentColTotal As Double = CDbl(dgvRow.Cells("colTotal").Value)

                Dim dblCurrentColPriceAftTax As Double = CDbl(dgvRow.Cells("colPriceAftTax").Value)


                If DataGridView1.Columns.Contains("colItemCode") Then
                    ' Prevent null pointer
                    If dgvRow.Cells("colItemCode").Value IsNot Nothing Then
                        Dim intCurrentQty As Integer = CInt(dblCurrentColQty)
                        Dim strItemCode As String = dgvRow.Cells("colItemCode").Value.ToString()

                        If strProductBarcode.Equals(strItemCode) Then
                            dgvRow.Cells("colQTY").Value = intCurrentQty + 1
                            dgvRow.Cells("colTotal").Value = dblCurrentColPriceAftTax * dgvRow.Cells("colQTY").Value
                            bolDuplicatedItem = True
                            Exit For
                        End If
                    End If
                End If
            Next

            If bolDuplicatedItem = False Then
                DataGridView1.Rows.Add(strProductBarcode, strItemDesc, intQty, dblPriceBeforeTax, dblSERVICE_SALES_TAX, dblPriceAfterTax, dblTotal)
            End If

        Else
            MessageBox.Show("No product found with the specified barcode.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If

        CloseConnection()
    End Sub

    Private Sub UpdateTotalPrice()
        Dim dblTtlPrice As Double = 0
        Dim dblsubTtlPrice As Double = 0

        If DataGridView1 IsNot Nothing AndAlso DataGridView1.Rows.Count > 0 Then
            For Each dgvRow As DataGridViewRow In DataGridView1.Rows
                If dgvRow IsNot Nothing AndAlso dgvRow.Cells("colTotal") IsNot Nothing Then

                    Dim dblPriceAftTax As Double = CDbl(dgvRow.Cells("colPriceAftTax").Value)

                    If dblPriceAftTax <> Nothing AndAlso IsNumeric(dblPriceAftTax) Then
                        dblTtlPrice += Convert.ToDouble(dblPriceAftTax) * dgvRow.Cells("colQTY").Value
                        dblsubTtlPrice += Convert.ToDouble(dblPriceAftTax) * dgvRow.Cells("colQTY").Value
                    End If
                End If
            Next

        End If

        If chkRedeemPoint.Checked Then
            Dim dblPointsRedeemed As Double = dblsubTtlPrice - CDbl(lblConvertedToCash.Text)

            lblPointsRedeemed.Text = dblPointsRedeemed

            If dblPointsRedeemed <= 0 Then
                lblPointsRedeemed.Text = CDbl(lblSubTotal.Text).ToString("N2")

                lblTtlPrice.Text = "0.00"
            Else
                lblPointsRedeemed.Text = lblConvertedToCash.Text

            End If
        Else
            lblPointsRedeemed.Text = "0.00"
        End If

        dblTtlPrice = dblsubTtlPrice - CDbl(lblDiscount.Text) - CDbl(lblPointsRedeemed.Text)

        If dblTtlPrice < 0 Then
            lblTtlPrice.Text = "0.00"
        Else
            lblTtlPrice.Text = dblTtlPrice.ToString("N2")
        End If

        lblSubTotal.Text = dblsubTtlPrice.ToString("N2")
        lblRounding.Text = "0.00"

        chkRounding_Click(Nothing, Nothing)


    End Sub

    Private Sub DataGridView1_CellValueChanged(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellValueChanged

        If DataGridView1.Rows.Count > 1 Then
            UpdateTotalPrice()
        End If
    End Sub

    Private Sub DataGridView1_RowsAdded(sender As Object, e As DataGridViewRowsAddedEventArgs) Handles DataGridView1.RowsAdded
        AddHandler DataGridView1.CellValueChanged, AddressOf DataGridView1_CellValueChanged

        If DataGridView1.Rows.Count > 1 Then
            UpdateTotalPrice()
        End If

    End Sub

    Private Sub btnSearchSalesOrder_Click(sender As Object, e As EventArgs) Handles btnSearchSalesOrder.Click
        If rtfSalesOrder.Text <> "" Then
            Dim salesDataTable As DataTable = frmPayment.GetSalesItemBySalesId(rtfSalesOrder.Text)
            Dim salesQtyDataTable As DataTable = frmPayment.GetSalesItemBySalesId(rtfSalesOrder.Text, True)
            Dim strCustomerId As String = ""
            'sales order found
            If salesDataTable IsNot Nothing Then
                btnRefundSelected.Enabled = True

                btnVoid.Enabled = True

                btnSearchBarCode.Enabled = False
                btnSearchVoucher.Enabled = False


                connection.ConnectionString = connectionString

                OpenConnection()

                Dim sql As String = "SELECT * FROM SALES WHERE id = @Value1"
                Using command As New SqlCommand(sql, connection)
                    command.Parameters.AddWithValue("@Value1", rtfSalesOrder.Text)

                    Dim salesCustomerDataTable As New DataTable()

                    Dim salesCustomerDataAdapter As New SqlDataAdapter(command)

                    salesCustomerDataAdapter.Fill(salesCustomerDataTable)

                    If salesCustomerDataTable.Rows.Count > 0 Then
                        Dim row As DataRow = salesCustomerDataTable.Rows(0)
                        strCustomerId = row("customer_id")
                    End If
                End Using


                sql = "SELECT * FROM Customer WHERE customer_id = @Value1"
                Using command As New SqlCommand(sql, connection)
                    command.Parameters.AddWithValue("@Value1", strCustomerId)

                    Dim customerDataTable As New DataTable()

                    Dim customerDataAdapter As New SqlDataAdapter(command)

                    customerDataAdapter.Fill(customerDataTable)

                    If customerDataTable.Rows.Count > 0 Then
                        Dim row As DataRow = customerDataTable.Rows(0)
                        Dim strCustomerName As String = row("customer_name")
                        Dim strCustomerStatus As String = row("customer_status")
                        Dim intCustomerPoints As Integer = row("customer_points")

                        lblCustomerName.Text = strCustomerName
                        lblCustomerStatus.Text = strCustomerStatus
                        lblLoyaltyPoint.Text = intCustomerPoints.ToString()
                    End If
                End Using


                For i As Integer = 0 To salesDataTable.Rows.Count - 1
                    Dim strDescription As String = salesDataTable.Rows(i)("product_description").ToString
                    Dim strProductBarcode As String = salesDataTable.Rows(i)("product_barcode").ToString
                    Dim dblPriceBefTax As Double = CDbl(salesDataTable.Rows(i)("product_price"))

                    Dim intQty As Integer = CInt(salesQtyDataTable.Rows(i)("quantity"))

                    Dim dblPriceAftTax As Double = dblPriceBefTax + (dblPriceBefTax * dblSERVICE_SALES_TAX)

                    Dim dblTtl As Double = dblPriceAftTax * intQty

                    lblCurrentSalesOrder.Text = rtfSalesOrder.Text
                    btnSearchBarCode.Enabled = False
                    btnSearchSalesOrder.Enabled = False
                    btnSearchVoucher.Enabled = False

                    btnRemoveSelected.Enabled = False
                    btnPayment.Enabled = False
                    btnAddQty.Enabled = False
                    btnReduceQty.Enabled = False
                    btnCustomer.Enabled = False
                    btnVoid.Enabled = False

                    DataGridView1.Rows.Add(strProductBarcode, strDescription, intQty, dblPriceBefTax, dblSERVICE_SALES_TAX, dblPriceAftTax, dblTtl)
                Next
            Else
                MessageBox.Show("Sales not found, invalid sales order id", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)

            End If
        Else
            MessageBox.Show("Invalid input, empty input", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If

        CloseConnection()

    End Sub

    Private Sub btnRefundSelected_Click(sender As Object, e As EventArgs) Handles btnRefundSelected.Click
        If DataGridView1.Rows.Count > 1 Then
            If DataGridView1.SelectedRows.Count <> -1 And Not (DataGridView1.SelectedRows.Count > 1) Then

                For i As Integer = 0 To DataGridView1.SelectedRows.Count - 1
                    Dim dgvRow As DataGridViewRow = DataGridView1.SelectedRows(i)

                    Dim sql As String = "UPDATE SalesItem SET refunded = @Value1, refunded_amount = @Value2 WHERE sales_id = @Value3"
                    Dim dblPriceAftTax As Double = CDbl(dgvRow.Cells("colPriceAftTax").Value)
                    Dim intQTY As Integer = dgvRow.Cells("colQTY").Value

                    connection.ConnectionString = connectionString

                    OpenConnection()
                    Using command As New SqlCommand(sql, connection)

                        command.Parameters.AddWithValue("@Value1", True)
                        command.Parameters.AddWithValue("@Value2", dblPriceAftTax * intQTY)
                        command.Parameters.AddWithValue("@Value3", lblCurrentSalesOrder.Text)

                        command.ExecuteNonQuery()

                    End Using


                    sql = "UPDATE Sales SET total_price = @Value1 WHERE id = @Value2"

                    Using command As New SqlCommand(sql, connection)

                        Dim dblAdjustedTtlPrice = CDbl(lblTtlPrice.Text) - dblPriceAftTax * intQTY

                        command.Parameters.AddWithValue("@Value1", dblAdjustedTtlPrice)
                        command.Parameters.AddWithValue("@Value2", lblCurrentSalesOrder.Text)

                        command.ExecuteNonQuery()

                    End Using

                    DataGridView1.Rows.Remove(dgvRow)

                Next
                Dim dlgResult As DialogResult = MessageBox.Show("Refund successfully, do you want to continue?", "Successful", MessageBoxButtons.YesNo)

                If dlgResult = DialogResult.No Then
                    btnClear_Click(Nothing, Nothing)
                End If

            Else
                MessageBox.Show("Please select only 1 row per refund", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End If
        Else
            MessageBox.Show("Invalid input, empty input", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If


        CloseConnection()



    End Sub

    Private Sub btnRemoveSelected_Click(sender As Object, e As EventArgs) Handles btnRemoveSelected.Click
        If DataGridView1.SelectedRows.Count > 0 Then
            For i As Integer = DataGridView1.SelectedRows.Count - 1 To 0 Step -1
                Dim dgvRow As DataGridViewRow = DataGridView1.SelectedRows(i)
                If dgvRow.Cells("colItemCode").Value IsNot Nothing Or dgvRow.Cells("colItemCode").Value <> "" Then
                    DataGridView1.Rows.Remove(DataGridView1.SelectedRows(i))
                Else
                    GetErrorMessage("INVALID ROW SELECTED")
                End If

            Next
        End If

        UpdateTotalPrice()
    End Sub

    Private Sub btnAddQty_Click(sender As Object, e As EventArgs) Handles btnAddQty.Click
        If DataGridView1.Rows.Count > 1 Then
            For i As Integer = DataGridView1.SelectedRows.Count - 1 To 0 Step -1
                Dim dgvRow As DataGridViewRow = DataGridView1.SelectedRows(i)

                Dim intQTY As Integer = dgvRow.Cells("colQTY").Value
                If dgvRow.Cells("colItemCode").Value IsNot Nothing Or dgvRow.Cells("colItemCode").Value <> "" Then
                    dgvRow.Cells("colQTY").Value = intQTY + 1
                End If

            Next

        End If

    End Sub

    Private Sub btnReduceQty_Click(sender As Object, e As EventArgs) Handles btnReduceQty.Click
        If DataGridView1.Rows.Count > 1 Then
            For i As Integer = DataGridView1.SelectedRows.Count - 1 To 0 Step -1
                Dim dgvRow As DataGridViewRow = DataGridView1.SelectedRows(i)

                If dgvRow.Cells("colQTY").Value > 1 Then
                    Dim intQTY As Integer = dgvRow.Cells("colQTY").Value
                    dgvRow.Cells("colQTY").Value = intQTY - 1
                ElseIf dgvRow.Cells("colItemCode").Value IsNot Nothing Or dgvRow.Cells("colItemCode").Value <> "" Then
                    DataGridView1.Rows.Remove(DataGridView1.SelectedRows(i))
                    UpdateTotalPrice()
                End If

            Next

        End If
    End Sub

    Private Sub chkRounding_Click(sender As Object, e As EventArgs) Handles chkRounding.Click
        Dim decRounding As Decimal = 0.00

        Dim dblAdjustedPrice As Double = CDbl(lblSubTotal.Text) - CDbl(lblPointsRedeemed.Text) - CDbl(lblDiscount.Text)
        If chkRounding.Checked Then

            If lblSubTotal.Text <> "0.00" Then
                lblTtlPrice.Text = Helper.RoundToNearestSen(dblAdjustedPrice, decRounding).ToString("N2")
                lblRounding.Text = decRounding.ToString("N2")

            End If

        Else
            lblTtlPrice.Text = dblAdjustedPrice.ToString("N2")
            lblRounding.Text = "0.00"

        End If

    End Sub

    Private Sub chkRedeemPoint_Click(sender As Object, e As EventArgs) Handles chkRedeemPoint.Click
        If chkRedeemPoint.Checked = True Then
            If lblLoyaltyPoint.Text <> "N/A" Then
                Try
                    Dim dblLoyaltyPoint As Double = CDbl(lblLoyaltyPoint.Text)

                    UpdateTotalPrice()

                Catch ex As FormatException
                    MessageBox.Show("Invalid format", "Error", MessageBoxButtons.OK)
                End Try
            End If
        Else
            UpdateTotalPrice()
        End If
    End Sub

    Private Sub rtf_Enter(sender As Object, e As EventArgs) Handles rtfBarcode.Enter, rtfSalesOrder.Enter, rtfVoucher.Enter
        If sender Is rtfBarcode Then
            Me.AcceptButton = btnSearchBarCode
        ElseIf sender Is rtfSalesOrder Then
            Me.AcceptButton = btnSearchSalesOrder
        ElseIf sender Is rtfVoucher Then
            Me.AcceptButton = btnSearchVoucher
        End If
    End Sub

    Private Sub btnSearchVoucher_Click(sender As Object, e As EventArgs) Handles btnSearchVoucher.Click
        If DataGridView1.Rows.Count > 1 Then

            Dim dataTable As New DataTable()
            connection.ConnectionString = connectionString

            OpenConnection()

            Dim sql As New SqlCommand("SELECT * FROM PROMOTION WHERE voucher_code = @Value1 AND promotion_status = @Value2", connection)
            sql.Parameters.AddWithValue("@Value1", rtfVoucher.Text)
            sql.Parameters.AddWithValue("@Value2", "Active")


            Dim dataAdapter As New SqlDataAdapter(sql)
            dataAdapter.Fill(dataTable)

            If dataTable.Rows.Count > 0 Then
                Dim row As DataRow = dataTable.Rows(0)

                Dim strDiscountType As String = row("discount_type").ToString()
                Dim dblDiscountValue As String = row("discount_value").ToString()
                Dim intMaxUsageLimit As Integer = row("usage_limit")
                Dim intUsageCounter As Integer = row("usage_count")
                Dim startDate As Date = row("start_date")
                Dim endDate As Date = row("end_date")


                Dim todayDate As Date = Date.Today

                Dim dblActualDiscountValue As Double = 0.00R


                If todayDate >= startDate AndAlso todayDate <= endDate Then

                    If intUsageCounter < intMaxUsageLimit Then
                        If strDiscountType.ToUpper() = "FIXED AMOUNT" Then
                            dblActualDiscountValue = dblDiscountValue
                        ElseIf strDiscountType.ToUpper = "PERCENTAGE" Then
                            dblActualDiscountValue = CDbl(lblSubTotal.Text) * (dblDiscountValue / 100)
                        End If

                        btnSearchVoucher.Enabled = False
                        lblDiscount.Text = dblActualDiscountValue.ToString("N2")

                        UpdateTotalPrice()

                        MessageBox.Show("Voucher applied to current transaction", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)

                        strVoucher = rtfVoucher.Text
                    Else
                        MessageBox.Show("Voucher is fully redeemed", "Sorry", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    End If
                Else
                    MessageBox.Show("Voucher is expired, please try again", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                End If
            End If

        Else
            MessageBox.Show("Please enter product before proceeding", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If

        CloseConnection()

    End Sub
End Class