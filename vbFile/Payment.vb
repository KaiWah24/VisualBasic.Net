Imports System.Drawing.Printing
Imports QRCoder
Imports System.Text
Imports System.Data.SqlClient

Public Class frmPayment
    Private connectionString As String = "Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\fungp\source\repos\posSystem\posSystem\Pos.mdf;Integrated Security=True"
    Public connection As New SqlConnection


    Private dblTtlPrice As Double = CDbl(frmSales.lblTtlPrice.Text)
    Private strTtlPrice As String = frmSales.lblTtlPrice.Text

    Private salesId As String = ""

    Private Sub Payment_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        HideAllPanels()
        pnlCash.Visible = True

        'update total from form sales
        lblTtlCash.Text = strTtlPrice
        lblTtlVisa.Text = strTtlPrice
        lblTtlMasterCard.Text = strTtlPrice
        lblTtlEWallet.Text = strTtlPrice

    End Sub

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

    Private Sub pnlEWallet_Paint(sender As Object, e As PaintEventArgs) Handles pnlEWallet.Paint
        Dim generator As New QRCodeGenerator
        Dim data = generator.CreateQrCode(frmSales.lblTtlPrice.Text, QRCodeGenerator.ECCLevel.Q)
        Dim code As New QRCode(data)
        picQrCode.Image = code.GetGraphic(6)
    End Sub

    Private Sub btnPayByVisa_Click(sender As Object, e As EventArgs) Handles btnPayByVisa.Click
        HideAllPanels()
        pnlVisa.Visible = True
    End Sub
    Private Sub btnPayByEWallet_Click(sender As Object, e As EventArgs) Handles btnPayByEWallet.Click
        HideAllPanels()
        pnlEWallet.Visible = True
    End Sub

    Private Sub btnPayByMasterCard_Click(sender As Object, e As EventArgs) Handles btnPayByMasterCard.Click
        HideAllPanels()
        pnlMasterCard.Visible = True
    End Sub

    Private Sub btnPayByCash_Click(sender As Object, e As EventArgs) Handles btnPayByCash.Click
        HideAllPanels()
        pnlCash.Visible = True
    End Sub

    Private Sub HideAllPanels()
        pnlCash.Visible = False
        pnlVisa.Visible = False
        pnlMasterCard.Visible = False
        pnlEWallet.Visible = False
    End Sub

    Private Sub btnPayByCash_Click_1(sender As Object, e As EventArgs) Handles btnPayByCash.Click
        HideAllPanels()
        pnlCash.Visible = True
    End Sub
    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click

        If rtfTendered.Text = "" Then
            rtfTendered.Text = lblTtlCash.Text
        End If

        If Helper.ValidateNumericInput(rtfTendered.Text) Then

            Dim dblChange As Double = Double.Parse(rtfTendered.Text) - Double.Parse(lblTtlCash.Text)
            lblChange.Text = dblChange.ToString()

        Else
            MessageBox.Show("Invalid input, please enter only numeric input", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub


    Private Sub btnCashCancel_Click(sender As Object, e As EventArgs) Handles btnCashCancel.Click
        Me.Close()
    End Sub

    Private Sub btnCashCompleted_Click(sender As Object, e As EventArgs) Handles btnCashCompleted.Click
        MakePayment("Cash")
    End Sub

    Private Function MakePayment(strPaymentMethod As String)
        Dim strCardNumber As String = Nothing

        Select Case strPaymentMethod
            Case lblVisaCardType.Text
                strCardNumber = mskVisaCardNumber.Text
            Case lblMasterCardType.Text
                strCardNumber = mskMasterCardNumber.Text
            Case Else
                strCardNumber = ""
        End Select
        Dim dblTtlPrice As Double = Double.Parse(strTtlPrice)

        Dim dataTable As New DataTable()

        If strPaymentMethod = "Cash" Then
            If rtfTendered.Text = "" Then
                MessageBox.Show("Please enter amount to proceed", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return Nothing
            End If
        End If

        connection.ConnectionString = connectionString

        OpenConnection()
        Dim sql As String = "INSERT INTO Payment (payment_method, card_number, total_amount_paid, status, payment_date_time) VALUES (@Value1, @Value2, @Value3, @Value4, @Value5)"
        Using command As New SqlCommand(sql, connection)

            command.Parameters.AddWithValue("@Value1", strPaymentMethod)
            command.Parameters.AddWithValue("@Value2", strCardNumber)
            command.Parameters.AddWithValue("@Value3", dblTtlPrice)
            command.Parameters.AddWithValue("@Value4", "Completed")
            command.Parameters.AddWithValue("@Value5", DateTime.Now())

            command.ExecuteNonQuery()

        End Using

        Dim strGetLatestPaymentIdQuery As New SqlCommand(" SELECT MAX( id ) FROM Payment ", connection)

        Dim dataAdapterPayment As New SqlDataAdapter(strGetLatestPaymentIdQuery)
        dataAdapterPayment.Fill(dataTable)
        Dim strPaymentId As String = ""

        'validation records from sales table
        If dataTable.Rows.Count > 0 Then

            Dim row As DataRow = dataTable.Rows(0)

            strPaymentId = row(0).ToString()

        End If

        Dim strCustId As String = ""

        'create sales table entry into db
        If frmCustomer.strValidCustomerId <> "" Then
            strCustId = frmCustomer.strValidCustomerId
        End If
        'replace with actual customer id
        Dim intPaymentId As Integer = CInt(strPaymentId)
        Dim dtPurchasedDateTime As DateTime = DateTime.Now()
        Dim intStaffId As Integer = 1 'from friend loggedInStaffId         'TODO


        sql = "INSERT INTO Sales (total_price, customer_id, payment_id, purchased_date_time,staff_id) VALUES (@Value1, @Value2, @Value3, @Value4,@Value5)"
        Using command As New SqlCommand(sql, connection)
            ' Set parameter values for the other columns
            command.Parameters.AddWithValue("@Value1", dblTtlPrice)
            command.Parameters.AddWithValue("@Value2", strCustId)
            command.Parameters.AddWithValue("@Value3", intPaymentId)
            command.Parameters.AddWithValue("@Value4", dtPurchasedDateTime)
            command.Parameters.AddWithValue("@Value5", intStaffId)

            ' Execute the insert command
            command.ExecuteNonQuery()

        End Using


        Dim salesDataTable As New DataTable()


        'get latest sale id
        Dim strGetSaleIdQuery As New SqlCommand("SELECT MAX( id ) FROM Sales", connection)

        Dim dataAdapter As New SqlDataAdapter(strGetSaleIdQuery)
        dataAdapter.Fill(salesDataTable)

        'validation records from sales table
        If salesDataTable.Rows.Count > 0 Then

            Dim row As DataRow = salesDataTable.Rows(0)

            salesId = row(0).ToString()

        End If


        ' for loop to get all the product id from datagridview
        For Each dgvRow In frmSales.DataGridView1.Rows
            If dgvRow.Cells("colItemCode").Value Is Nothing Then
                Continue For
            End If

            Dim strProductBarcode As String = dgvRow.Cells("colItemCode").Value.ToString()
            Dim intCurrentQty As Integer = dgvRow.Cells("colQTY").Value

            sql = "INSERT INTO SalesItem (sales_id, product_barcode, quantity) VALUES (@Value1, @Value2, @Value3)"
            Using command As New SqlCommand(sql, connection)
                command.Parameters.AddWithValue("@Value1", salesId)
                command.Parameters.AddWithValue("@Value2", strProductBarcode)
                command.Parameters.AddWithValue("@Value3", intCurrentQty)
                command.ExecuteNonQuery()
            End Using
        Next

        'TODO add voucher entry
        If frmSales.chkRedeemPoint.Checked = True Then

            'use point
            sql = "UPDATE CUSTOMER SET customer_current_points = @Value1 WHERE customer_id = @Value2"
            Using command As New SqlCommand(sql, connection)

                Dim dblAdjustedPoint As Double = CDbl(frmSales.lblLoyaltyPoint.Text) - CDbl(frmSales.lblPointsRedeemed.Text * frmSales.dblPOINT_FOR_CONVERSION)

                command.Parameters.AddWithValue("@Value1", dblAdjustedPoint)
                command.Parameters.AddWithValue("@Value2", Helper.strValidCustomerId)

                command.ExecuteNonQuery()
            End Using
        Else

            'add points
            'TODO add condition if lblDiscount OR points redeemed != "" or "0.00" then means customer used discount/voucher hence do not allow add point 
            Dim strCustomerStatus As String = "Standard Tier"
            'do not allow cusotomer with discount to earn point
            If frmSales.lblDiscount.Text <> "" Or frmSales.lblDiscount.Text <> "0.00" Then
                Dim intCustomerPoint As Integer = 0
                Dim intCustomerLifetimePoints As Integer = 0

                'earn point
                sql = "SELECT * FROM CUSTOMER WHERE customer_id = @Value1"
                Using command As New SqlCommand(sql, connection)
                    command.Parameters.AddWithValue("@Value1", Helper.strValidCustomerId)

                    Dim customerDataTable As New DataTable()

                    Dim customerDataAdapter As New SqlDataAdapter(command)

                    customerDataAdapter.Fill(customerDataTable)

                    If customerDataTable.Rows.Count > 0 Then
                        Dim row As DataRow = customerDataTable.Rows(0)
                        intCustomerPoint = row("customer_current_points")
                        strCustomerStatus = row("customer_tier")
                        intCustomerLifetimePoints = row("customer_lifetime_earned_points")

                    End If
                End Using

                Dim intTierToPoints As Integer
                Select Case strCustomerStatus.ToUpper()
                    Case "GOLD TIER"
                        intTierToPoints = 2
                    Case "PLATINUM TIER"
                        intTierToPoints = 3
                    Case "DIAMOND TIER"
                        intTierToPoints = 4
                    Case Else
                        intTierToPoints = 1
                End Select

                sql = "UPDATE CUSTOMER SET customer_current_points = @Value1, customer_lifetime_earned_points = @Value2 WHERE customer_id = @Value3"
                Using command As New SqlCommand(sql, connection)

                    Dim intEarnedPoint As Integer = Math.Floor(CDbl(frmSales.lblTtlPrice.Text) * intTierToPoints)
                    Dim intCustomerCurrentPoint As Integer = intCustomerPoint + intEarnedPoint

                    command.Parameters.AddWithValue("@Value1", intCustomerCurrentPoint)
                    command.Parameters.AddWithValue("@Value2", intCustomerLifetimePoints + intCustomerCurrentPoint)
                    command.Parameters.AddWithValue("@Value3", Helper.strValidCustomerId)

                    command.ExecuteNonQuery()
                End Using

            End If


            'update usage limit and total redemption
            Dim intUsageCount As Integer = 0
            sql = "SELECT * FROM Promotion WHERE voucher_code = @Value1"
            Using command As New SqlCommand(sql, connection)
                command.Parameters.AddWithValue("@Value1", frmSales.strVoucher)

                Dim promotionDataTable As New DataTable()

                Dim promotionDataAdapter As New SqlDataAdapter(command)

                promotionDataAdapter.Fill(promotionDataTable)

                If promotionDataTable.Rows.Count > 0 Then
                    Dim row As DataRow = promotionDataTable.Rows(0)
                    intUsageCount = row("usage_count")

                End If
            End Using


            sql = "UPDATE Promotion SET usage_count = @Value1 WHERE voucher_code = @Value2"
            Using command As New SqlCommand(sql, connection)
                command.Parameters.AddWithValue("@Value1", intUsageCount + 1)
                command.Parameters.AddWithValue("@Value2", frmSales.strVoucher)

                command.ExecuteNonQuery()
            End Using

        End If

        CloseConnection()

        'message box indicate success of payment
        Dim dlgResult As DialogResult = MessageBox.Show("Payment successful, print receipt?", "Successful", MessageBoxButtons.YesNo)

        If dlgResult = DialogResult.Yes Then

            dlgPreview.Document = docReceipt
            dlgPreview.ShowDialog(Me)
            docReceipt.Print()

        End If

        frmSales.btnClear_Click(Nothing, Nothing)
        MessageBox.Show("Thank you come again", "Next Transaction", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Me.Close()
    End Function

    Private Sub docReceipt_PrintPage(sender As Object, e As PrintPageEventArgs) Handles docReceipt.PrintPage
        Dim logoHeader As New StringBuilder()
        Dim strCompanyAddress As New StringBuilder()
        Dim receiptContent As New StringBuilder()

        logoHeader.AppendLine("SUPER GROCERY")
        logoHeader.AppendLine("PICK, PAY AND GO")

        strCompanyAddress.AppendLine("Super 33 SuperMarket (M) Sdn Bhd (774997-T)")
        strCompanyAddress.AppendLine("PG-01 Super 33")
        strCompanyAddress.AppendLine("3, Jln Wong One Section 711 45600 KL")
        strCompanyAddress.AppendLine("Tel: 03-1234 5678")

        Dim strDottedDash As String = "-----------------------------------------------------------------------------"


        receiptContent.AppendLine(logoHeader.ToString())
        receiptContent.AppendLine(strCompanyAddress.ToString())
        receiptContent.AppendLine("Sales Order Id: " & salesId.ToString())

        receiptContent.AppendLine(strDottedDash)
        receiptContent.AppendLine(String.Format("{0,-50} {1,-5} {2,10}", "Item Description", "QTY", "Price (RM)"))
        receiptContent.AppendLine(strDottedDash)

        Dim bolQtyFromSalesItem As Boolean = True

        Dim salesDataTable As DataTable = GetSalesItemBySalesId(salesId)
        Dim salesQtyDataTable As DataTable = GetSalesItemBySalesId(salesId, bolQtyFromSalesItem)


        If salesDataTable.Rows.Count > 0 Then
            For i As Integer = 0 To salesDataTable.Rows.Count - 1
                Dim strDescription As String = salesDataTable.Rows(i)("product_description").ToString
                Dim quantity As Integer = CInt(salesQtyDataTable.Rows(i)("quantity"))
                Dim dblPrice As Double = CDbl(salesDataTable.Rows(i)("product_price"))

                ' Adjust the width for proper alignment
                receiptContent.AppendLine(String.Format("{0,-50} {1,-4} {2,10:C}", strDescription, quantity, dblPrice * quantity))
                receiptContent.AppendLine(strDottedDash)
            Next
        End If

        Dim dblSubTtl As Double = CDbl(frmSales.lblSubTotal.Text)
        Dim dblDiscount As Double = CDbl(frmSales.lblDiscount.Text)
        Dim dblRounding As Double = CDbl(frmSales.lblRounding.Text)
        Dim dblTotal As Double = CDbl(frmSales.lblTtlPrice.Text)

        ' Use consistent formatting and adjust the width
        receiptContent.AppendLine(String.Format("{0,55} {1,-7} {2,10:N}", "SubTotal", "", dblSubTtl))
        receiptContent.AppendLine(String.Format("{0,55} {1,-6} {2,10:N}", "Discount", "", dblDiscount))
        receiptContent.AppendLine(String.Format("{0,55} {1,-4} {2,10:N}", "SST(6%)", "", (dblSubTtl * frmSales.dblSERVICE_SALES_TAX)))
        receiptContent.AppendLine(String.Format("{0,50} {1,-6} {2,10:N}", "Points Used (RM)", "", ("(" & frmSales.lblPointsRedeemed.Text)) & ")")
        receiptContent.AppendLine(String.Format("{0,55} {1,-4} {2,10:N}", "Rounding", "", dblRounding))
        receiptContent.AppendLine(String.Format("{0,55} {1,-10} {2,10:N}", "Total", "", dblTotal))
        receiptContent.AppendLine(strDottedDash)

        ' Append terms and conditions
        receiptContent.AppendLine("Terms and Conditions:")
        receiptContent.AppendLine("1. All sales are final.")
        receiptContent.AppendLine("2. No refunds or exchanges with invalid reasons.")
        receiptContent.AppendLine("3. Receipts needed for refund/return")
        receiptContent.AppendLine(strDottedDash)

        ' Append footer
        receiptContent.AppendLine("Thank you for shopping with us!")
        receiptContent.AppendLine(strDottedDash)
        receiptContent.AppendLine("Visit us online at www.supergrocery.com")
        receiptContent.AppendLine("Follow us on social media: @superGrocery")
        receiptContent.AppendLine(strDottedDash)


        Dim xPos As Single = 100
        Dim yPos As Single = 10

        Dim font As New Font("Arial", 12)
        Dim brush As New SolidBrush(Color.Black)

        With e.Graphics
            .DrawString(receiptContent.ToString(), font, brush, xPos, yPos)

        End With
    End Sub

    Private Sub btnVisaCompleted_Click(sender As Object, e As EventArgs) Handles btnVisaCompleted.Click
        If mskVisaCardNumber.Text = "" Or mskVisaCVV.Text = "" Or mskVisaExpiry.Text = "" Then
            MessageBox.Show("Invalid Input, empty", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
        MakePayment(lblVisaCardType.Text)
    End Sub

    Private Sub btnMasterCardCompleted_Click(sender As Object, e As EventArgs) Handles btnMasterCardCompleted.Click
        If mskMasterCardNumber.Text = "" Or mskMasterCVV.Text = "" Or mskMasterExpiry.Text = "" Then
            MessageBox.Show("Invalid Input, empty", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
        MakePayment(lblMasterCardType.Text)
    End Sub


    Friend Function GetSalesItemBySalesId(strSalesId As String) As DataTable
        Dim sqlGetSalesItem As New SqlCommand("SELECT * FROM SalesItem WHERE sales_id = @Value1 AND refunded = @Value2 AND voided = @Value3", connection)
        sqlGetSalesItem.Parameters.AddWithValue("@Value1", strSalesId)
        sqlGetSalesItem.Parameters.AddWithValue("@Value2", False) '0 for false
        sqlGetSalesItem.Parameters.AddWithValue("@Value3", False) '0 for false


        Dim arrProductBarcode() As String

        Dim salesItemDataTable As New DataTable()
        connection.ConnectionString = connectionString

        OpenConnection()

        Dim dataAdapter As New SqlDataAdapter(sqlGetSalesItem)
        dataAdapter.Fill(salesItemDataTable)


        If salesItemDataTable.Rows.Count > 0 Then
            ReDim arrProductBarcode(salesItemDataTable.Rows.Count - 1)

            For i As Integer = 0 To salesItemDataTable.Rows.Count - 1
                arrProductBarcode(i) = salesItemDataTable.Rows(i)("product_barcode").ToString()
            Next

            Dim soldProductDataTable As New DataTable()

            For i As Integer = 0 To arrProductBarcode.Length - 1
                Dim sqlGetProductByBarcode As New SqlCommand(" SELECT * FROM Product WHERE product_barcode = @Value1", connection)
                sqlGetProductByBarcode.Parameters.AddWithValue("@Value1", arrProductBarcode(i))

                Dim productDataAdapter As New SqlDataAdapter(sqlGetProductByBarcode)
                productDataAdapter.Fill(soldProductDataTable)

            Next

            If soldProductDataTable.Rows.Count > 0 Then
                CloseConnection()
                Return soldProductDataTable
            End If

        End If

        CloseConnection()

        Return Nothing


    End Function

    Friend Function GetSalesItemBySalesId(strSalesId As String, bolGetSalesQty As Boolean) As DataTable
        Dim sqlGetSalesItem As New SqlCommand(" SELECT * FROM SalesItem WHERE sales_id = @Value1 AND refunded = @Value2 AND voided = @Value3", connection)
        sqlGetSalesItem.Parameters.AddWithValue("@Value1", strSalesId)
        sqlGetSalesItem.Parameters.AddWithValue("@Value2", False) '0 for false
        sqlGetSalesItem.Parameters.AddWithValue("@Value3", False) '0 for false

        Dim arrProductBarcode() As String

        Dim salesItemDataTable As New DataTable()
        connection.ConnectionString = connectionString

        OpenConnection()

        Dim dataAdapter As New SqlDataAdapter(sqlGetSalesItem)
        dataAdapter.Fill(salesItemDataTable)


        If salesItemDataTable.Rows.Count > 0 Then
            ReDim arrProductBarcode(salesItemDataTable.Rows.Count - 1)

            If bolGetSalesQty Then
                CloseConnection()

                Return salesItemDataTable
            End If
        End If
        CloseConnection()

        Return Nothing


    End Function

    Private Sub btnEWalletCompleted_Click(sender As Object, e As EventArgs) Handles btnEWalletCompleted.Click
        MakePayment("EWallet")
    End Sub

    Private Sub mskMasterCardNumber_MaskInputRejected(sender As Object, e As MaskInputRejectedEventArgs) Handles mskMasterCardNumber.MaskInputRejected

    End Sub


End Class