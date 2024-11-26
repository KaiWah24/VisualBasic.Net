Imports System.Data.SqlClient
Imports System.Drawing.Printing

Public Class report
    Private Sub report_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim strSqlCalc As String = "SELECT staff_id, staff_name, staff_date_hired, staff_status, staff_position FROM staff"
        Dim MySqlCommand As New SqlCommand(strSqlCalc, connection)
        Dim currentMonth As Integer = DateTime.Now.Month
        Dim currentYear As Integer = DateTime.Now.Year

        Dim staffCount As Integer = 0
        Dim newStaff As Integer = 0
        Dim staffTerminated As Integer = 0

        OpenConnection()
        Dim reader As SqlDataReader = MySqlCommand.ExecuteReader()
        While reader.Read()
            Dim dateHired As DateTime = reader.GetDateTime(reader.GetOrdinal("staff_date_hired"))
            Dim staffStatus As String = reader.GetString(reader.GetOrdinal("staff_status"))

            If staffStatus = "Active" Then
                staffCount += 1
            Else
                staffTerminated += 1
            End If

            If dateHired.Month = currentMonth AndAlso dateHired.Year = currentYear AndAlso staffStatus = "Active" Then
                newStaff += 1
            End If

        End While
        reader.Close()

        lblTotalStaff.Text = staffCount
        lblNewHired.Text = newStaff
        lblTermination.Text = staffTerminated
        lblReportName.Text = "Human Capital Report for " & DateTime.Now.ToString("MMMM")
        lbltodayDate.Text = Date.Now

        Dim strSqlStaff As String = "SELECT staff_id, staff_name, staff_date_hired, staff_status, staff_position FROM staff WHERE staff_status = @staff_status"
        Dim showDataCommand As New SqlCommand(strSqlStaff, connection)
        showDataCommand.Parameters.AddWithValue("@staff_status", "Active")

        Dim allStaffDA As New SqlDataAdapter(showDataCommand)
        Dim allStaffDT As New DataTable()
        allStaffDA.Fill(allStaffDT)
        dgvStaff.DataSource = allStaffDT


        CloseConnection()

    End Sub


    Private printDocument As New PrintDocument()
    Private printPreviewDialog As New PrintPreviewDialog()

    Private Sub btnPrint_Click(sender As Object, e As EventArgs) Handles btnPrint.Click
        ' Add a PrintPage event handler
        AddHandler printDocument.PrintPage, AddressOf doc_PrintPage

        ' Optionally, add PrintDialog to allow the user to choose a printer
        Dim printDialog As New PrintDialog()
        printDialog.Document = printDocument

        If printDialog.ShowDialog() = DialogResult.OK Then
            Me.FormBorderStyle = FormBorderStyle.None
            btnPrint.Visible = False
            ' Show the print preview dialog
            printPreviewDialog.Document = printDocument
            printPreviewDialog.ShowDialog()
        End If
        Me.FormBorderStyle = FormBorderStyle.Sizable
        btnPrint.Visible = True
    End Sub

    Private Sub doc_PrintPage(sender As Object, e As Printing.PrintPageEventArgs) Handles doc.PrintPage
        ' Create a bitmap with the form size
        Dim formBitmap As New Bitmap(Me.Width, Me.Height)

        ' Draw the form content onto the bitmap
        Me.DrawToBitmap(formBitmap, New Rectangle(0, 0, Me.Width, Me.Height))

        ' Draw the bitmap onto the printed page
        e.Graphics.DrawImage(formBitmap, e.MarginBounds.Left, e.MarginBounds.Top)
    End Sub


End Class