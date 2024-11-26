Imports System.ComponentModel
Imports System.Data.SqlClient
Imports System.Text

Public Class frmInventoryReport
    Private ds As DataSet = New DataSet()
    Private da As SqlDataAdapter
    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

    Private Sub frmInventoryReport_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim strSql As String
        cboProductName.Items.Clear()
        cboFromMonth.Items.Clear()
        cboFromYear.Items.Clear()

        If OpenConnection() = True Then
            strSql = "Select * From Product Where product_status = 'on shelves'"
            Dim cmd As New SqlCommand(strSql, connection)

            da = New SqlDataAdapter(cmd)
            ds.Clear()
            da.Fill(ds, "Product")
            If ds.Tables("Product").Rows.Count > 0 Then
                For intIndexI As Integer = 0 To ds.Tables("Product").Rows.Count - 1
                    cboProductName.Items.Add(ds.Tables("Product").Rows(intIndexI).Item(1))
                Next
            End If

            CloseConnection()
        Else
            MessageBox.Show("Error in connecting to database server", "Error", MessageBoxButtons.OK)

        End If
        YearComboBox()
        MonthComboBox()
    End Sub

    Private Sub YearComboBox()
        Dim localTime As DateTime = DateTime.Now
        Dim currentYear As Integer = localTime.Year
        Dim startYear As Integer = currentYear - 5
        Dim endYear As Integer = currentYear

        cboFromYear.Items.Clear()
        For year As Integer = startYear To endYear
            cboFromYear.Items.Add(year.ToString())
        Next
        ' Optionally, set the default selected year to the current year
        cboFromYear.SelectedItem = currentYear.ToString()

    End Sub

    Private Sub MonthComboBox()
        Dim localTime As DateTime = DateTime.Now
        Dim currentMonth As Integer = localTime.Month

        cboFromMonth.Items.Clear()

        ' Add "All" as the first option
        cboFromMonth.Items.Add("All")

        ' Add the names of the months to the combo box
        For monthIndex As Integer = 1 To 12
            cboFromMonth.Items.Add((New DateTime(1, monthIndex, 1)).ToString("MMMM"))
        Next

        ' Set the default selected month to the current month
        cboFromMonth.SelectedIndex = currentMonth ' The "All" option is at index 0, so months start at index 1
    End Sub


    Private Sub docInventoryReport_PrintPage(sender As Object, e As Printing.PrintPageEventArgs) Handles docInventoryReport.PrintPage
        Dim strSql As String
        Dim fntHeader As New Font("Calibri", 24, FontStyle.Bold)
        Dim fntSubHeader As New Font("Calibri", 12)
        Dim fntFooter As New Font("Calibri", 12)
        Dim fntBody As New Font("Consolas", 10)
        Dim intCount As Integer = 0I
        Dim strHeader As String = "Restock Report"
        Dim strSubHeader As String = "Super 33 SuperMarket (M) Sdn Bhd (774997-T)"
        Dim strSubHeader2 As String = "PG-01 Super 33"
        Dim strSubHeader3 As String = "3, Jln Wong One Section 711 45600 KL"
        Dim strSubHeader4 As String = "Tel: 03-1234 5678"
        Dim strSubHeader5 As String = "Follow us at social media @superGrocery"
        Dim strSubHeader6 As String = String.Format("Printed on {0:dd-MMMM-yyyy hh:mm:ss tt}", DateTime.Now)
        Dim strFooter As String = "End of report"
        Dim strFooterLine As String = "-------------------------------------------------------------------------------------------"
        Dim body As New StringBuilder()
        Dim selectedProductName As String = cboProductName.SelectedItem.ToString()
        Dim selectedYear As String = cboFromYear.SelectedItem.ToString()
        Dim selectedMonth As String = cboFromMonth.SelectedIndex.ToString()
        Dim dblAccumlatePayment As Double = 0R
        Dim boxPen As New Pen(Brushes.Black, 1) ' Define the pen for drawing the box
        Dim boxRect As New Rectangle(80, 700, 500, 150)
        Dim infoFont As New Font("Calibri", 10)
        Dim infoBrush As New SolidBrush(Color.Black)
        Dim infoX As Integer = 80
        Dim infoY As Integer = 700



        body.AppendFormat("{0,-14} {1,-17} {2,-21} {3,-10} {4,-18} {5,-10} " & vbNewLine,
                  "Product Name", "Restock Quantity", "Total Restock Price", "Supplier",
                  "Person In Charge", "Date")
        body.AppendFormat("{0,-14} {1,-17} {2,-21} {3,-10} {4,-18} {5,-10} " & vbNewLine,
                  "-----------", "---------------", "------------------", "---------",
                  "---------------", "----")

        If OpenConnection() = True Then


            strSql = "SELECT * FROM Restock WHERE restock_productName = @ProductName AND YEAR(restock_date) = @Year"

            If selectedMonth <> "0" Then
                strSql &= " AND MONTH(restock_date) = @Month"
            End If
            Dim cmd As New SqlCommand(strSql, connection)
            cmd.Parameters.AddWithValue("@ProductName", selectedProductName)
            cmd.Parameters.AddWithValue("@Year", selectedYear)

            ' Add parameter for month if it's selected
            If selectedMonth <> "0" Then
                cmd.Parameters.AddWithValue("@Month", selectedMonth)
            End If

            da = New SqlDataAdapter(cmd)
            ds.Clear()
            da.Fill(ds, "Restock")

            For Each row As DataRow In ds.Tables("Restock").Rows
                intCount += 1
                Dim dateWithoutTime As String = Convert.ToDateTime(row("restock_date")).ToString("dd/MM/yyyy")
                Dim dblPrice As Double = row("restock_totalPrice")
                dblAccumlatePayment += dblPrice
                dblPrice.ToString("C", System.Globalization.CultureInfo.GetCultureInfo("ms-MY"))
                body.AppendFormat("{0,-15} {1,-18} {2,-19} {3,-15} {4,-10} {5,-10} " & vbNewLine,
                  row("restock_productName"), row("restock_quantity"), dblPrice.ToString("C", System.Globalization.CultureInfo.GetCultureInfo("ms-MY")), row("restock_supplier"),
                   row("restock_staffName"), dateWithoutTime)

            Next
            CloseConnection()
        Else
            MessageBox.Show("Error in connecting to database server", "Error", MessageBoxButtons.OK)
        End If

        body.AppendLine()
        body.AppendFormat("{0,2} record(s)", intCount)

        'body.AppendLine()
        'body.AppendLine()
        'body.AppendLine()
        'body.AppendLine()
        'body.AppendFormat("{0,-20}{1,-20}{2,-25}{3,-20}" & vbNewLine, "Selected Year", "Selected Month", "Selected Product Name ", "Total Expenses")
        'body.AppendFormat("{0,-20}{1,-20}{2,-25}{3,-20}" & vbNewLine, selectedYear, selectedMonth, selectedProductName, dblAccumlatePayment.ToString("C", System.Globalization.CultureInfo.GetCultureInfo("ms-MY")))

        With e.Graphics
            .DrawImage(My.Resources.loginBg, 140, 0, 400, 180)
            .DrawString(strHeader, fntHeader, Brushes.Purple, 230, 320)
            .DrawString(strSubHeader, fntSubHeader, Brushes.Black, 170, 200)
            .DrawString(strSubHeader2, fntSubHeader, Brushes.Black, 280, 220)
            .DrawString(strSubHeader3, fntSubHeader, Brushes.Black, 200, 240)
            .DrawString(strSubHeader4, fntSubHeader, Brushes.Black, 280, 260)
            .DrawString(strSubHeader5, fntSubHeader, Brushes.Black, 200, 280)
            .DrawString(strSubHeader6, fntSubHeader, Brushes.Black, 200, 300)
            .DrawString(body.ToString(), fntBody, Brushes.Black, 0, 370)
            .DrawString(strFooter, fntFooter, Brushes.Black, 280, 950)
            .DrawString(strFooterLine, fntFooter, Brushes.Black, 90, 930)
            .DrawRectangle(boxPen, boxRect)
            .DrawString("Selected Year", infoFont, infoBrush, infoX, infoY)
            .DrawString("Selected Month", infoFont, infoBrush, infoX + 100, infoY)
            .DrawString("Selected Product Name", infoFont, infoBrush, infoX + 220, infoY)
            .DrawString("Total Expenses", infoFont, infoBrush, infoX + 380, infoY)
            .DrawString(selectedYear, infoFont, infoBrush, infoX, infoY + 20)
            .DrawString(selectedMonth, infoFont, infoBrush, infoX + 100, infoY + 20)
            .DrawString(selectedProductName, infoFont, infoBrush, infoX + 220, infoY + 20)
            .DrawString(dblAccumlatePayment.ToString("C", System.Globalization.CultureInfo.GetCultureInfo("ms-MY")), infoFont, infoBrush, infoX + 380, infoY + 20)
        End With
    End Sub

    Private Sub btnPrint_Click(sender As Object, e As EventArgs) Handles btnPrint.Click
        If Me.ValidateChildren() = False Then
            Return
        End If

        err.Clear()
        ds.Clear()
        dlgPreviewInventoryReport.Document = docInventoryReport
        dlgPreviewInventoryReport.ShowDialog(Me)
    End Sub

    Private Sub cboProductName_Validating(sender As Object, e As CancelEventArgs) Handles cboProductName.Validating
        Dim strName As String = cboProductName.Text
        If strName = "" Then
            Err.SetError(cboProductName, "Please select valid [Product Name]")
            e.Cancel = True
        End If
    End Sub
End Class