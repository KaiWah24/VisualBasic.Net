<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Password
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.panelforgotPassword = New System.Windows.Forms.Panel()
        Me.SuspendLayout()
        '
        'panelforgotPassword
        '
        Me.panelforgotPassword.Location = New System.Drawing.Point(1, 1)
        Me.panelforgotPassword.Name = "panelforgotPassword"
        Me.panelforgotPassword.Size = New System.Drawing.Size(799, 449)
        Me.panelforgotPassword.TabIndex = 1
        '
        'Password
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.panelforgotPassword)
        Me.Name = "Password"
        Me.Text = "password"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents panelforgotPassword As Panel
End Class
