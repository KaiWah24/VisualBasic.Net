Imports System.Data.SqlClient
Imports System.Drawing.Printing
Imports System.Text

Public Class SalesMenu
    Private connectionString As String = "Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\fungp\source\repos\posSystem\posSystem\Pos.mdf;Integrated Security=True"
    Public connection As New SqlConnection

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

    Private Const placeholderText As String = "0.00"
    Private placeholderCleared As Boolean = False
    Private decimalPosition As Integer = 0
    Private cashValue As Decimal = 0

    Private Sub btnOpenCashier_Click(sender As Object, e As EventArgs) Handles btnOpenCashier.Click
        grpShowDrawingCash.Visible = True
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click, PictureBox9.Click
        grpShowDrawingCash.Visible = True
    End Sub

    Private Sub txtCashInput_GotFocus(sender As Object, e As EventArgs) Handles txtCashInput.GotFocus
        If txtCashInput.Text = placeholderText Then
            txtCashInput.Text = String.Empty
        End If
    End Sub

    Private Sub txtCashInput_LostFocus(sender As Object, e As EventArgs) Handles txtCashInput.LostFocus
        If String.IsNullOrWhiteSpace(txtCashInput.Text) Then
            txtCashInput.Text = placeholderText
        End If
    End Sub

    Private Sub txtCashInput_Leave(sender As Object, e As EventArgs) Handles txtCashInput.Leave
        ValidateCashInput()
    End Sub

    Private Sub ValidateCashInput()
        If Not Decimal.TryParse(txtCashInput.Text, cashValue) Then
            MessageBox.Show("Invalid cash input. Please enter a valid numeric value.")
            txtCashInput.Text = placeholderText
            cashValue = 0
        End If
    End Sub

    Private Sub txtCashInput_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCashInput.KeyPress
        e.Handled = True
    End Sub

    Private Sub NumericButton_Click(sender As Object, e As EventArgs) Handles btn1.Click, btn2.Click, btn3.Click, btn4.Click, btn5.Click, btn6.Click, btn7.Click, btn8.Click, btn9.Click
        Dim clickedButton As Button = DirectCast(sender, Button)

        If Not placeholderCleared Then
            txtCashInput.Text = String.Empty
            placeholderCleared = True
            decimalPosition = 0
        End If

        cashValue = cashValue * 10 + Decimal.Parse(clickedButton.Text) / 100
        txtCashInput.Text = cashValue.ToString("0.00")
        decimalPosition += 1
        txtCashInput.SelectionStart = decimalPosition
        txtCashInput.ScrollToCaret()
    End Sub

    Private Sub btnAddPoint_Click(sender As Object, e As EventArgs) Handles btnAddPoint.Click
        If Not placeholderCleared Then
            txtCashInput.Text = String.Empty
            placeholderCleared = True
            decimalPosition = 0
        End If

        If Not txtCashInput.Text.Contains(".") Then
            cashValue *= 10
            txtCashInput.Text = cashValue.ToString("0.00")
            txtCashInput.Text += "."
            decimalPosition += 1
            txtCashInput.SelectionStart = decimalPosition
            txtCashInput.ScrollToCaret()
        End If
    End Sub

    Private Sub btn0_Click(sender As Object, e As EventArgs) Handles btn0.Click
        If Not placeholderCleared Then
            txtCashInput.Text = String.Empty
            placeholderCleared = True
            decimalPosition = 0
        End If

        cashValue *= 10
        txtCashInput.Text = cashValue.ToString("0.00")
        decimalPosition += 1
        txtCashInput.SelectionStart = decimalPosition
        txtCashInput.ScrollToCaret()
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        If Not placeholderCleared Then
            txtCashInput.Text = String.Empty
            placeholderCleared = True
            decimalPosition = 0
        End If

        If txtCashInput.Text.Length > 0 Then
            Dim currentCursorPosition As Integer = txtCashInput.SelectionStart

            ' Check if the character at the current cursor position is a decimal point
            Dim isDecimalPointAtCursorPosition As Boolean = currentCursorPosition > 0 AndAlso txtCashInput.Text(currentCursorPosition - 1) = "."

            ' Remove the last character
            txtCashInput.Text = txtCashInput.Text.Substring(0, txtCashInput.Text.Length - 1)

            ' Update the cash value
            If Decimal.TryParse(txtCashInput.Text, cashValue) Then
                ' If the character removed was a decimal point, adjust the decimal position
                If isDecimalPointAtCursorPosition Then
                    decimalPosition = currentCursorPosition - 1
                End If
            Else
                cashValue = 0
            End If

            ' Set the cursor position
            txtCashInput.SelectionStart = decimalPosition
            txtCashInput.ScrollToCaret()
        ElseIf txtCashInput.Text = "0.00" Then
            txtCashInput.Text = "0.00"
        Else
            ' If txtCashInput is empty, set the placeholder
            txtCashInput.Text = placeholderText
            ' Move the cursor to the end of the placeholder
            txtCashInput.SelectionStart = txtCashInput.Text.Length
        End If
    End Sub


    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        ' Clear the input and set the placeholder
        txtCashInput.Text = placeholderText
        ' Move the cursor to the end of the placeholder
        txtCashInput.SelectionStart = txtCashInput.Text.Length
        ' Reset other variables
        placeholderCleared = False
        decimalPosition = 0
        cashValue = 0
    End Sub

    Private Sub btnStartShift_Click(sender As Object, e As EventArgs) Handles btnStartShift.Click

        frmSales.Show()

        Me.Hide()
    End Sub

    Private Sub SalesMenu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblStaffName.Text = "Hello " & Main.strStaffName
    End Sub

    Private Sub btnPrintReport_Click(sender As Object, e As EventArgs) Handles btnPrintReport.Click
        dlgPrintPreview.Document = docSalesReport
        dlgPrintPreview.ShowDialog(Me)

    End Sub

    Private Sub docSalesReport_PrintPage(sender As Object, e As PrintPageEventArgs) Handles docSalesReport.PrintPage
        Dim fntHeader As New Font("Calibri", 24, FontStyle.Bold)
        Dim fntSubHeader As New Font("Calibri", 12, FontStyle.Bold)

        Dim fntBody As New Font("Consolas", 10)
        Dim brush As New SolidBrush(Color.Black)

        Dim strCompanyAddress As New StringBuilder()

        strCompanyAddress.AppendLine("Super 33 SuperMarket (M) Sdn Bhd (774997-T)")
        strCompanyAddress.AppendLine("PG-01 Super 33")
        strCompanyAddress.AppendLine("3, Jln Wong One Section 711 45600 KL")
        strCompanyAddress.AppendLine("Tel: 03-1234 5678")

        'hardcoded value to be replaced
        'TODO 

        connection.ConnectionString = connectionString

        OpenConnection()

        Dim sql As New SqlCommand("SELECT
    CAST(s.purchased_date_time AS DATE) AS sales_date,
    SUM(s.total_price) AS total_sales,
    COUNT(*) AS number_of_transactions,
    AVG(s.total_price) AS average_transaction_value,
    SUM(CASE WHEN si.refunded = 1 THEN si.refunded_amount ELSE 0 END) AS total_refunds,
    SUM(si.refunded) AS total_refunds_count,
    SUM(si.voided) AS number_of_voided_transactions,
    MAX(s.total_price) AS highest_sales_amount,
    p.payment_method AS most_used_payment_method
FROM
    Sales s
JOIN
    SalesItem si ON s.Id = si.sales_id
JOIN
    Payment p ON s.payment_id = p.Id
WHERE
    CAST(s.purchased_date_time AS DATE) = @Value1
GROUP BY
    CAST(s.purchased_date_time AS DATE), p.payment_method;
", connection)

        sql.Parameters.AddWithValue("@Value1", Date.Today.ToString("yyyy-MM-dd"))
        Dim previousDate As Date = Date.Today.AddDays(-1)

        'today
        Dim ttlProfitTdy As Decimal = 0
        Dim intTransactionTdy As Integer = 0
        Dim intRefundedTdy As Integer = 0
        Dim dblAvgTransacationValueTdy As Double = 0
        Dim intNumberOfVoidedTransactionTdy As Double = 0

        'previous
        Dim ttlProfitPrevDay As Decimal = 0
        Dim intTransactionPrevDay As String = 0
        Dim intRefundedPrevDay As String = 0
        Dim dblAvgTransacationValuePrev As Double = 0
        Dim intNumberOfVoidedTransactionPrevDay As Double = 0

        Dim incOrDec As String = "Increase"



        Dim dataAdapter As New SqlDataAdapter(sql)

        Dim salesReportDataTable As New DataTable()


        dataAdapter.Fill(salesReportDataTable)

        If salesReportDataTable.Rows.Count > 0 Then
            Dim row As DataRow = salesReportDataTable.Rows(0)
            ttlProfitTdy = row("total_sales")
            intTransactionTdy = row("number_of_transactions")
            dblAvgTransacationValueTdy = row("average_transaction_value")
            intRefundedTdy = row("total_refunds_count")
            intNumberOfVoidedTransactionTdy = row("number_of_voided_transactions")
        End If

        Dim sqlForPreviousDate As New SqlCommand("SELECT
    CAST(s.purchased_date_time AS DATE) AS sales_date,
    SUM(s.total_price) AS total_sales,
    COUNT(*) AS number_of_transactions,
    AVG(s.total_price) AS average_transaction_value,
    SUM(CASE WHEN si.refunded = 1 THEN si.refunded_amount ELSE 0 END) AS total_refunds,
    SUM(si.refunded) AS total_refunds_count,
    SUM(si.voided) AS number_of_voided_transactions,
    MAX(s.total_price) AS highest_sales_amount,
    p.payment_method AS most_used_payment_method
FROM
    Sales s
JOIN
    SalesItem si ON s.Id = si.sales_id
JOIN
    Payment p ON s.payment_id = p.Id
WHERE
    CAST(s.purchased_date_time AS DATE) = @Value2
GROUP BY
    CAST(s.purchased_date_time AS DATE), p.payment_method;
", connection)

        sqlForPreviousDate.Parameters.AddWithValue("@Value2", previousDate)
        Dim previousDateReportAdapater As New SqlDataAdapter(sqlForPreviousDate)

        Dim previousSalesReportDataTable As New DataTable()


        previousDateReportAdapater.Fill(previousSalesReportDataTable)

        If previousSalesReportDataTable.Rows.Count > 0 Then
            Dim row As DataRow = previousSalesReportDataTable.Rows(0)
            ttlProfitPrevDay = row("total_sales")
            intTransactionPrevDay = row("number_of_transactions")
            dblAvgTransacationValuePrev = row("average_transaction_value")
            intRefundedPrevDay = row("total_refunds_count")
            intNumberOfVoidedTransactionPrevDay = row("number_of_voided_transactions")
        End If



        Dim strHeader As String = "Daily Sales Report"

        Dim strSalesReportColHeader As String = String.Format("{0,-60} {1,-26} {2,-30} {3,-5}", "Metrics", "Today", "Previous", "%")
        Dim strSeperator As String = "--------------------------------------------------------------------------------------------------------------------------"
        Dim strMetricsRowTtlProfit As String = String.Format("{0,-60} {1,-25} {2,-25} {3,-5}", "Total Price", ttlProfitTdy, ttlProfitPrevDay, If(ttlProfitTdy > ttlProfitPrevDay, "Increase", "Decrease"))
        Dim strMetricsRowTransaction As String = String.Format("{0,-60} {1,-30} {2,-28} {3,-5}", "Transaction", intTransactionTdy, intTransactionPrevDay, If(intTransactionTdy > intTransactionPrevDay, "Increase", "Decrease"))
        Dim strMetricsRowVoided As String = String.Format("{0,-64} {1,-30} {2,-25} {3,-5}", "Voided", intNumberOfVoidedTransactionTdy, intNumberOfVoidedTransactionPrevDay, If(intNumberOfVoidedTransactionTdy > intNumberOfVoidedTransactionPrevDay, "Increase", "Decrease"))
        Dim strMetricsRowRefund As String = String.Format("{0,-60} {1,-30} {2,-25} {3,-5}", "Refunded", intRefundedTdy, intRefundedPrevDay, If(intRefundedTdy > intRefundedPrevDay, "Increase", "Decrease"))


        Dim strSubHeader As String = String.Format(
        "Generated on {0:dd-MMMM-yyyy hh:mm:ss tt}", DateTime.Now
        )

        With e.Graphics
            .DrawImage(My.Resources.loginBg, 100, 50, 450, 150)
            .DrawString(strCompanyAddress.ToString(), fntSubHeader, brush, 180, 220)
            .DrawString(strSeperator.ToString(), fntSubHeader, brush, 0, 300)

            .DrawString(strHeader.ToString(), fntHeader, brush, 190, 310)
            .DrawString(strSubHeader.ToString(), fntSubHeader, brush, 150, 350)

            .DrawString(strSeperator.ToString(), fntSubHeader, brush, 0, 360)

            'summary
            .DrawString("Summary", fntHeader, brush, 250, 380)


            .DrawImage(My.Resources.salesReportProfit, 30, 450, 250, 150)
            .DrawString(ttlProfitTdy, fntSubHeader, brush, 80, 525)
            .DrawImage(My.Resources.salesReportTransaction, 380, 450, 250, 150)
            'transacation count
            .DrawString(intTransactionTdy, fntSubHeader, brush, 455, 500)
            'avg transaction value
            .DrawString(dblAvgTransacationValueTdy.ToString("C"), fntSubHeader, brush, 455, 555)
            .DrawString(strSeperator.ToString(), fntSubHeader, brush, 0, 610)

            .DrawString(strSalesReportColHeader, fntSubHeader, brush, 0, 630)
            .DrawString(strSeperator, fntSubHeader, brush, 0, 640)
            .DrawString(strMetricsRowTtlProfit, fntSubHeader, brush, 0, 670)
            .DrawString(strSeperator.ToString(), fntSubHeader, brush, 0, 700)

            .DrawString(strMetricsRowTransaction, fntSubHeader, brush, 0, 730)
            .DrawString(strSeperator.ToString(), fntSubHeader, brush, 0, 760)

            .DrawString(strMetricsRowVoided, fntSubHeader, brush, 0, 790)
            .DrawString(strSeperator.ToString(), fntSubHeader, brush, 0, 820)

            .DrawString(strMetricsRowRefund, fntSubHeader, brush, 0, 850)
            .DrawString(strSeperator.ToString(), fntSubHeader, brush, 0, 880)


            'FOOTER
            .DrawString(strSeperator.ToString(), fntSubHeader, brush, 0, 950)
            .DrawString("End of report", fntSubHeader, brush, 245, 970)

            CloseConnection()
        End With
    End Sub

    Private Sub lblReport_Click(sender As Object, e As EventArgs) Handles lblReport.Click

    End Sub
End Class
