Public Class Password
    Public Sub childform(panel As Form)
        panelforgotPassword.Controls.Clear()
        panel.TopLevel = False
        panel.FormBorderStyle = Windows.Forms.FormBorderStyle.None
        panel.Dock = DockStyle.Fill
        panelforgotPassword.Controls.Add(panel)
        panel.Show()
    End Sub

    Private Sub forgotPassword_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        childform(forgotPassword)
    End Sub
End Class