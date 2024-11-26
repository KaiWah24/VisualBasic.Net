Imports System.Data.SqlClient
Imports System.Drawing.Printing
Imports System.Text

Public Class customerReport
    ' Declare variables to store the information to be printed
    Private printData As String = ""
    Private Sub LoadLoyaltyStatus()
        Try
            OpenConnection()

            ' Base SELECT query
            Dim query As String = "SELECT customer_id, customer_date_joined, customer_tier, total_points_redeem, customer_lifetime_earned_points FROM Customer"

            If cboSelectedTier.SelectedIndex <> -1 Then
                If Not query.Contains("WHERE") Then
                    query &= " WHERE"
                Else
                    query &= " AND"
                End If

                Dim selectedTier As String = cboSelectedTier.SelectedItem.ToString()
                query &= $" customer_tier = '{selectedTier}'"
            End If

            ' Execute the query
            Using command As New SqlCommand(query, connection)
                Using reader As SqlDataReader = command.ExecuteReader()
                    ' Create a DataTable to hold the data
                    Dim loyaltyStatusTable As New DataTable()
                    loyaltyStatusTable.Load(reader)

                    ' Bind the DataTable to the DataGridView
                    dgvCustomerReport.DataSource = loyaltyStatusTable

                    ' Display the total number of customers for the selected tier on a label
                    lblTotalCustomer.Text = $"Total Customers that reached  '{cboSelectedTier.SelectedItem}' : {loyaltyStatusTable.Rows.Count}"
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Error loading loyalty status: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub


    Private Sub cboSelectMonth_SelectedIndexChanged(sender As Object, e As EventArgs)
        LoadLoyaltyStatus()
    End Sub

    Private Sub cboSelectYear_SelectedIndexChanged(sender As Object, e As EventArgs)
        LoadLoyaltyStatus()
    End Sub

    Private Sub cboSelectedTier_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboSelectedTier.SelectedIndexChanged
        LoadLoyaltyStatus()

    End Sub

    Private Sub doc_PrintPage(sender As Object, e As Printing.PrintPageEventArgs) Handles doc.PrintPage


        Dim body As New StringBuilder

        Dim intCount As Integer
        Dim strParts() As String

        ' Get the selected tier from the combo box
        Dim selectedTier As String = cboSelectedTier.SelectedItem.ToString()

        ' Build the query to retrieve data for the selected tier
        Dim query As String = $"SELECT customer_id, customer_date_joined, customer_tier, total_points_redeem, customer_lifetime_earned_points FROM Customer WHERE customer_tier = '{selectedTier}'"

        Dim fntHeader As New Font("Calibri", 26, FontStyle.Bold)
        Dim fntSubHeader As New Font("Calibri", 14, FontStyle.Bold)
        Dim fntBody As New Font("Consolas", 10)

        Dim strSubHeader As String = "Super 33 SuperMarket (M) Sdn Bhd (774997-T)" & Environment.NewLine &
                             "PG-01 Super 33 3, Jln Wong One Section 711" & Environment.NewLine &
                             "45600 KL Tel: 03-1234 5678"
        Dim xPos As Integer = 50
        Dim yPos As Integer = 50

        Dim strSubHeader2 As String = $"Customer Report of - {selectedTier}"

        Dim strSubHeader3 As String = $"No      Customer ID      Date Joined      Life-Time Earning Points      Points Redeemed{Environment.NewLine}" &
                              $"--      -----------      -----------      ------------------------      ---------------"
        Dim strSubHeader4 As String = $"--------------------------------------------------------------------------------------------"
        Dim strSubHeader5 As String = $"End of Report"


        Dim totalPointsRedeemed As Integer = 0

        For Each row As DataGridViewRow In dgvCustomerReport.Rows
            Dim dateJoined As Date = Convert.ToDateTime(row.Cells(1).Value) ' Convert the date to DateTime
            Dim formattedDateJoined As String = dateJoined.ToString("dd/MM/yyyy")
            totalPointsRedeemed += Convert.ToInt32(row.Cells(3).Value)

            intCount += 1
            Dim rowText As String = $"{intCount,-12} {row.Cells(0).Value,-11} {formattedDateJoined,-5} {row.Cells(2).Value,29} {row.Cells(3).Value,20}"

            e.Graphics.DrawString(rowText, fntBody, Brushes.Black, xPos + 95, yPos + 365)
            yPos += fntBody.Height * 2

        Next

        Dim bodyHeight As Single = e.MarginBounds.Height - fntBody.GetHeight(e.Graphics)
        Dim strTotalPointsRedeemed As String = $"Total Points Redeemed by Customers: {totalPointsRedeemed} points"

        ' Create a rectangle to define the printable area
        Dim layoutRect As New RectangleF(e.MarginBounds.Left, e.MarginBounds.Top + fntHeader.GetHeight(e.Graphics), e.MarginBounds.Width, bodyHeight)
        Dim customColor As Color = Color.FromArgb(26, 36, 66)

        ' Draw the print content within the printable area
        With e.Graphics
            .DrawImage(My.Resources.loginBg, 235, 30, 550, 200)
            .DrawString(strSubHeader, fntSubHeader, Brushes.Black, 313, 235)
            .DrawString(strSubHeader2, fntHeader, New SolidBrush(customColor), 240, 310)
            .DrawString(strSubHeader3, fntBody, Brushes.Black, 140, 375)
            .DrawString(body.ToString(), fntBody, Brushes.Black, 200, 430)
            .DrawString(strSubHeader4, fntBody, Brushes.Black, 120, 690)
            .DrawString(strSubHeader5, fntBody, Brushes.Black, 450, 720)
            .DrawString(strTotalPointsRedeemed, fntBody, Brushes.Black, 460, 660)
        End With

            ' Indicate that there are more pages to print
            e.HasMorePages = False
        'Catch ex As Exception
        '    MessageBox.Show("Error loading loyalty status: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        'Finally
        '    CloseConnection()
        'End Try

    End Sub

    Private Sub btnPrint_Click(sender As Object, e As EventArgs) Handles btnPrint.Click
        doc = New Printing.PrintDocument()
        doc.DefaultPageSettings.PaperSize = New PaperSize("Custom", 1024, 768) ' Set the width and height as needed
        doc.DefaultPageSettings.Landscape = False ' Set to True if you want landscape orientation

        dlgPreview.Document = doc
        dlgPreview.ShowDialog(Me)
    End Sub

    Private Sub customerReport_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cboSelectedTier.SelectedIndex = 0
    End Sub
End Class
