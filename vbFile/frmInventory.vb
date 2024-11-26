Imports System.Data.SqlClient
Imports System.IO
Imports System.Text
Imports System.Windows.Forms.DataVisualization.Charting
Public Class frmInventory
    Private ds As DataSet = New DataSet()
    Private da As SqlDataAdapter
    Sub childform(ByVal panel As Form)
        pnlCategory.Controls.Clear()
        panel.TopLevel = False
        panel.FormBorderStyle = Windows.Forms.FormBorderStyle.None
        panel.Dock = DockStyle.Fill
        pnlCategory.Controls.Add(panel)
        panel.Show()
        panel.AutoScroll = True


    End Sub

    Private Sub btnFreshProduce_Click(sender As Object, e As EventArgs) Handles btnFreshProduce.Click
        childform(frmInventoryFreshProduce)
    End Sub

    Private Sub frmInventory_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim intScreenWidth As Integer = Screen.PrimaryScreen.Bounds.Width
        Dim intScreenHeight As Integer = Screen.PrimaryScreen.Bounds.Height
        Dim intPnlCategoryWidth As Integer = pnlCategory.Width
        Dim intPnlCategoryHeight As Integer = pnlCategory.Height
        Dim intPnlCategoryX As Integer = (intScreenWidth - intPnlCategoryWidth) \ 2
        Dim intPnlCategoryY As Integer = (intScreenHeight - intPnlCategoryHeight) \ 2

        pnlAlertBackground.AutoScroll = True


        With btnAllItem
            .Image = My.Resources.action.GetThumbnailImage(35, 35, Nothing, IntPtr.Zero)
            .Location = New Point(50, 690)
        End With

        With btnFreshProduce
            .Image = My.Resources.broccoli__1_.GetThumbnailImage(35, 35, Nothing, IntPtr.Zero)
            .Location = New Point(190, 690)
        End With

        With btnFreshFruit
            .Image = My.Resources.fruit__1_.GetThumbnailImage(35, 35, Nothing, IntPtr.Zero)
            .Location = New Point(330, 690)
        End With

        With btnFrozenSeafood
            .Image = My.Resources.seafood__1_.GetThumbnailImage(35, 35, Nothing, IntPtr.Zero)
            .Location = New Point(470, 690)
        End With

        With btnFrozenMeat
            .Image = My.Resources.meat__1_.GetThumbnailImage(35, 35, Nothing, IntPtr.Zero)
            .Location = New Point(610, 690)
        End With

        With btnBeverage
            .Image = My.Resources.drinks__1_.GetThumbnailImage(35, 35, Nothing, IntPtr.Zero)
            .Location = New Point(750, 690)
        End With

        With btnReport
            .Location = New Point(1010, 720)
        End With

        With btnRestock
            .Location = New Point(1110, 720)
        End With

        With btnOther
            .Location = New Point(910, 720)
        End With

        With pnlCategory
            .Size = New Size(pnlCategory.Width, pnlCategory.Height + 50)
        End With

        With pnlAlertBackground
            .Location = New Point(900, 130)
            .Size = New Size(pnlAlertBackground.Width + 20, pnlAlertBackground.Height - 40)
        End With

        With pnlLabelBackGround
            .Size = New Size(pnlLabelBackGround.Width, pnlLabelBackGround.Height)
        End With

        lblStock.Location = New Point(lblStock.Width - 35, lblStock.Height)
        lblAllItem.Location = New Point(65, 775)
        lblFreshProduce.Location = New Point(180, 775)
        lblFreshFruit.Location = New Point(330, 775)
        lblFrozenSeafood.Location = New Point(460, 775)
        lblFrozenMeat.Location = New Point(610, 775)
        lblBeverage.Location = New Point(760, 775)

        LoadInventoryData()
    End Sub

    Private Sub btnFreshFruit_Click(sender As Object, e As EventArgs) Handles btnFreshFruit.Click
        childform(frmInventoryFreshFruit)
    End Sub

    Private Sub btnFrozenSeafood_Click(sender As Object, e As EventArgs) Handles btnFrozenSeafood.Click
        childform(frmInventoryFrozenSeafood)
    End Sub

    Private Sub btnFrozenMeat_Click(sender As Object, e As EventArgs) Handles btnFrozenMeat.Click
        childform(frmInventoryFrozenMeat)
    End Sub

    Private Sub btnBeverage_Click(sender As Object, e As EventArgs) Handles btnBeverage.Click
        childform(frmInventoryBeverage)
    End Sub

    Private Sub btnAllItem_Click(sender As Object, e As EventArgs) Handles btnAllItem.Click
        childform(frmInventoryAllItem)
        ClearLable()
        LoadInventoryData()
    End Sub

    Private Sub btnRestock_Click(sender As Object, e As EventArgs) Handles btnRestock.Click
        frmInventoryRestock.ShowDialog()
    End Sub


    Private Sub btnReport_Click(sender As Object, e As EventArgs) Handles btnReport.Click
        frmInventoryReport.ShowDialog()
    End Sub

    Private Sub btnOther_Click(sender As Object, e As EventArgs) Handles btnOther.Click
        childform(frmInventoryOther)
    End Sub


    Private Sub LoadInventoryData()
        Dim intAlertCount As Integer = 0I
        Dim strSql As String
        Dim lblAlert As New Label
        ClearLable()

        With lblAlert
            .Text = "Alert!"
            .ForeColor = Color.Red
            .Font = New Font("showcard Gothic", 20, FontStyle.Italic)
            .Location = New Point(120, 20)
            .Size = New Size(120, 100)
        End With

        If OpenConnection() = True Then
            strSql = "Select * From Product Where product_status = 'on shelves'"
            Dim cmd As New SqlCommand(strSql, connection)

            da = New SqlDataAdapter(cmd)
            ds.Clear()
            da.Fill(ds, "Product")
            For intIndexI As Integer = 0 To ds.Tables("Product").Rows.Count - 1
                If ds.Tables("Product").Rows(intIndexI).Item(3) <= 20 Then
                    Dim lblAlertName As New Label
                    Dim lblAlertStock As New Label
                    Dim lblAlertPrice As New Label
                    Dim intAccumulateNum As Integer = 30
                    Dim intRowCount As Integer = 0I
                    Dim intPosY As Integer = 150 + intAlertCount * intAccumulateNum
                    Dim dblPrice As Double

                    With lblAlertName
                        .Text = ds.Tables("Product").Rows(intIndexI).Item(1)
                        .ForeColor = Color.Red
                        .Location = New Point(20, intPosY)
                        .Font = New Font("Century", 9, FontStyle.Regular)
                    End With

                    With lblAlertStock
                        .Text = ds.Tables("Product").Rows(intIndexI).Item(3)
                        .ForeColor = Color.Red
                        .Location = New Point(160, intPosY)
                        .Size = New Size(70, 20)
                        .Font = New Font("Century", 9, FontStyle.Regular)
                    End With

                    dblPrice = ds.Tables("Product").Rows(intIndexI).Item(2)
                    With lblAlertPrice
                        .Text = dblPrice.ToString("C", System.Globalization.CultureInfo.GetCultureInfo("ms-MY"))
                        .ForeColor = Color.Red
                        .Size = New Size(80, 20)
                        .TextAlign = ContentAlignment.TopCenter
                        .Location = New Point(240, intPosY)
                        .Font = New Font("Century", 9, FontStyle.Regular)
                    End With


                    pnlAlertBackground.Controls.Add(lblAlertName)
                    pnlAlertBackground.Controls.Add(lblAlertStock)
                    pnlAlertBackground.Controls.Add(lblAlertPrice)

                    intAlertCount += 1
                End If
            Next
            If intAlertCount > 0 Then
                MessageBox.Show("There have " & intAlertCount & " item in lower stock level", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End If

            CloseConnection()
        Else
            MessageBox.Show("Error in connecting to database server", "Error", MessageBoxButtons.OK)

        End If
        pnlAlertBackground.Controls.Add(lblAlert)
    End Sub

    Private Sub ClearLable()
        For Each control As Control In pnlAlertBackground.Controls
            If TypeOf control Is Label Then
                pnlAlertBackground.Controls.Remove(control)
                control.Dispose()
            End If
        Next
    End Sub
End Class