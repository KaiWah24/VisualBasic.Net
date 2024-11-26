Public Class Promotion
    Sub childform(Panel As Form)
        PanelPromotion.Controls.Clear()
        Panel.TopLevel = False
        Panel.FormBorderStyle = Windows.Forms.FormBorderStyle.None
        Panel.Dock = DockStyle.Fill
        PanelPromotion.Controls.Add(Panel)
        Panel.Show()
    End Sub
    Private Sub lblPromotionDash_Click(sender As Object, e As EventArgs) Handles lblPromotionDash.Click, picPromotionDash.Click
        childform(promotionMenu)
    End Sub

    Private Sub lblPromotionAdd_Click(sender As Object, e As EventArgs) Handles lblPromotionAdd.Click, picPromotionAdd.Click
        childform(addPromotion)
    End Sub

    Private Sub lblPromotionView_Click(sender As Object, e As EventArgs) Handles lblPromotionView.Click, picPromotionView.Click
        childform(promotionMenu)
    End Sub

    Private Sub lblPromotionReport_Click(sender As Object, e As EventArgs) Handles lblPromotionReport.Click, picPromotionReport.Click
        childform(promotionReport)
    End Sub
End Class