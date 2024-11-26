Public Class Customer
    Sub childform(Panel As Form)
        PanelCustomer.Controls.Clear()
        Panel.TopLevel = False
        Panel.FormBorderStyle = Windows.Forms.FormBorderStyle.None
        Panel.Dock = DockStyle.Fill
        PanelCustomer.Controls.Add(Panel)
        Panel.Show()
    End Sub


    Private Sub lblCustDash_Click(sender As Object, e As EventArgs) Handles lblCustDash.Click, picCustHome.Click
        childform(customerMenu)
    End Sub

    Private Sub lblCustAdd_Click(sender As Object, e As EventArgs) Handles lblCustAdd.Click, picAddCust.Click
        childform(addCustomer)
    End Sub

    Private Sub lblViewCust_Click(sender As Object, e As EventArgs) Handles lblViewCust.Click, picViewCust.Click
        childform(customerMenu)
    End Sub

    Private Sub lblViewReportCust_Click(sender As Object, e As EventArgs) Handles lblViewReportCust.Click, picViewReportCust.Click
        childform(customerReport)
    End Sub

    Private Sub Customer_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        customerMenu.Update()

        customerMenu.dgvMenu.Update()
        customerMenu.Refresh()
    End Sub
End Class