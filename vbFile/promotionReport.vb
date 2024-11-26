Imports System.Data.SqlClient
Imports System.Drawing.Printing
Imports System.Text

Public Class promotionReport
    Private printData As String = ""
    Private Sub LoadPromoStatus()
        Try
            OpenConnection()

            Dim query As String = "SELECT promotion_id, promotion_name, promotion_type, discount_type, discount_value FROM Promotion"

            If cboSelectedType.SelectedIndex <> -1 Then
                If Not query.Contains("WHERE") Then
                    query &= " WHERE"
                Else
                    query &= " AND"
                End If

                Dim selectedType As String = cboSelectedType.SelectedItem.ToString()
                query &= $" promotion_type = '{selectedType}'"
            End If

            Using command As New SqlCommand(query, connection)
                Using reader As SqlDataReader = command.ExecuteReader()
                    Dim loyaltyStatusTable As New DataTable()
                    loyaltyStatusTable.Load(reader)

                    dgvPromotionReport.DataSource = loyaltyStatusTable

                    lblTotalCustomer.Text = $"Total Promotions created based on '{cboSelectedType.SelectedItem}' : {loyaltyStatusTable.Rows.Count}"
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Error loading loyalty status: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub cboSelectedTier_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboSelectedType.SelectedIndexChanged
        LoadPromoStatus()
    End Sub

    Private Sub doc_PrintPage(sender As Object, e As Printing.PrintPageEventArgs) Handles doc.PrintPage


        Dim body As New StringBuilder

        Dim intCount As Integer
        Dim strParts() As String

        Dim selectedType As String = cboSelectedType.SelectedItem.ToString()

        Dim query As String = $"SELECT promotion_id, promotion_name, promotion_type, discount_type, discount_value FROM Promotion WHERE promotion_type = '{selectedType}'"

        Dim fntHeader As New Font("Calibri", 26, FontStyle.Bold)
        Dim fntSubHeader As New Font("Calibri", 14, FontStyle.Bold)
        Dim fntBody As New Font("Consolas", 10)

        Dim strSubHeader As String = "Super 33 SuperMarket (M) Sdn Bhd (774997-T)" & Environment.NewLine &
                             "PG-01 Super 33 3, Jln Wong One Section 711" & Environment.NewLine &
                             "45600 KL Tel: 03-1234 5678"
        Dim xPos As Integer = 50
        Dim yPos As Integer = 50

        Dim strSubHeader2 As String = $"Promotion Report of - {selectedType}"

        Dim strSubHeader3 As String = $"No      Promotion ID          Promotion Name        Discount Type        Discount Value{Environment.NewLine}" &
                              $"--      ------------          ---------------       --------------       ---------------"
        Dim strSubHeader4 As String = $"--------------------------------------------------------------------------------------------"
        Dim strSubHeader5 As String = $"End of Report"



        For Each row As DataGridViewRow In dgvPromotionReport.Rows
            Dim promotionType As String = row.Cells(1).Value.ToString()

            intCount += 1
            Dim rowText As String = $"{intCount,-15} {row.Cells(0).Value,3} {row.Cells(1).Value,24} {row.Cells(2).Value,20} {row.Cells(3).Value,21}"
            e.Graphics.DrawString(rowText, fntBody, Brushes.Black, xPos + 95, yPos + 365)
            yPos += fntBody.Height * 2
        Next
        Dim strTotalHeader As String = $"Total Number of Promotion(s) created based on '{selectedType}' : {dgvPromotionReport.Rows.Count}"

        Dim bodyHeight As Single = e.MarginBounds.Height - fntBody.GetHeight(e.Graphics)

        Dim layoutRect As New RectangleF(e.MarginBounds.Left, e.MarginBounds.Top + fntHeader.GetHeight(e.Graphics), e.MarginBounds.Width, bodyHeight)
        Dim customColor As Color = Color.FromArgb(26, 36, 66)

        With e.Graphics
            .DrawImage(My.Resources.loginBg, 235, 30, 550, 200)
            .DrawString(strSubHeader, fntSubHeader, Brushes.Black, 313, 235)
            .DrawString(strSubHeader2, fntHeader, New SolidBrush(customColor), 280, 310)
            .DrawString(strSubHeader3, fntBody, Brushes.Black, 140, 375)
            .DrawString(body.ToString(), fntBody, Brushes.Black, 200, 430)
            .DrawString(strSubHeader4, fntBody, Brushes.Black, 120, 690)
            .DrawString(strSubHeader5, fntBody, Brushes.Black, 450, 720)
            .DrawString(strTotalHeader, fntBody, Brushes.Black, 375, 660)
        End With


        e.HasMorePages = False


    End Sub

    Private Sub btnPrint_Click(sender As Object, e As EventArgs) Handles btnPrint.Click
        doc = New Printing.PrintDocument()
        doc.DefaultPageSettings.PaperSize = New PaperSize("Custom", 1024, 768)
        doc.DefaultPageSettings.Landscape = False

        dlgPreview.Document = doc
        dlgPreview.ShowDialog(Me)
    End Sub

    Private Sub promotionReport_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cboSelectedType.SelectedIndex = 0
    End Sub

    Private Sub PictureBox18_Click(sender As Object, e As EventArgs)
        promotionMenu.ShowDialog()
        Me.Close()
    End Sub

    Private Sub Label27_Click(sender As Object, e As EventArgs)
        promotionMenu.ShowDialog()
        Me.Close()
    End Sub

    Private Sub Label13_Click(sender As Object, e As EventArgs)
        promotionMenu.ShowDialog()
        Me.Close()
    End Sub

    Private Sub PictureBox16_Click(sender As Object, e As EventArgs)
        promotionMenu.ShowDialog()
        Me.Close()
    End Sub

    Private Sub PictureBox17_Click(sender As Object, e As EventArgs)
        addPromotion.ShowDialog()
        Me.Close()
    End Sub

    Private Sub Label21_Click(sender As Object, e As EventArgs)
        addPromotion.ShowDialog()
        Me.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)
        Me.Close()
        addPromotion.ShowDialog()
    End Sub
End Class