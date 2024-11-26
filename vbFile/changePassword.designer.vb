<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class changePassword
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(changePassword))
        Me.LinkForgetPassword = New System.Windows.Forms.LinkLabel()
        Me.txtOldPw = New System.Windows.Forms.TextBox()
        Me.lblOLd = New System.Windows.Forms.Label()
        Me.chkShowPassword = New System.Windows.Forms.CheckBox()
        Me.btnBack = New System.Windows.Forms.Button()
        Me.btnConfirm = New System.Windows.Forms.Button()
        Me.txtConfirmPw = New System.Windows.Forms.TextBox()
        Me.txtNewPw = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LinkForgetPassword
        '
        Me.LinkForgetPassword.AutoSize = True
        Me.LinkForgetPassword.BackColor = System.Drawing.Color.Transparent
        Me.LinkForgetPassword.Location = New System.Drawing.Point(267, 410)
        Me.LinkForgetPassword.Name = "LinkForgetPassword"
        Me.LinkForgetPassword.Size = New System.Drawing.Size(116, 16)
        Me.LinkForgetPassword.TabIndex = 44
        Me.LinkForgetPassword.TabStop = True
        Me.LinkForgetPassword.Text = "Forgot Password?"
        '
        'txtOldPw
        '
        Me.txtOldPw.Font = New System.Drawing.Font("Arial Rounded MT Bold", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtOldPw.Location = New System.Drawing.Point(28, 169)
        Me.txtOldPw.Name = "txtOldPw"
        Me.txtOldPw.Size = New System.Drawing.Size(361, 32)
        Me.txtOldPw.TabIndex = 40
        Me.txtOldPw.UseSystemPasswordChar = True
        '
        'lblOLd
        '
        Me.lblOLd.Font = New System.Drawing.Font("Arial Rounded MT Bold", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblOLd.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.lblOLd.Location = New System.Drawing.Point(24, 139)
        Me.lblOLd.Name = "lblOLd"
        Me.lblOLd.Size = New System.Drawing.Size(160, 27)
        Me.lblOLd.TabIndex = 52
        Me.lblOLd.Text = "Old Password :"
        '
        'chkShowPassword
        '
        Me.chkShowPassword.AutoSize = True
        Me.chkShowPassword.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.chkShowPassword.Location = New System.Drawing.Point(30, 410)
        Me.chkShowPassword.Name = "chkShowPassword"
        Me.chkShowPassword.Size = New System.Drawing.Size(122, 20)
        Me.chkShowPassword.TabIndex = 43
        Me.chkShowPassword.Text = "Show Password"
        Me.chkShowPassword.UseVisualStyleBackColor = True
        '
        'btnBack
        '
        Me.btnBack.Font = New System.Drawing.Font("Arial Rounded MT Bold", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBack.Location = New System.Drawing.Point(165, 470)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(129, 44)
        Me.btnBack.TabIndex = 46
        Me.btnBack.Text = "Back"
        Me.btnBack.UseVisualStyleBackColor = True
        '
        'btnConfirm
        '
        Me.btnConfirm.BackColor = System.Drawing.SystemColors.Highlight
        Me.btnConfirm.Font = New System.Drawing.Font("Arial Rounded MT Bold", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnConfirm.ForeColor = System.Drawing.SystemColors.Control
        Me.btnConfirm.Location = New System.Drawing.Point(30, 470)
        Me.btnConfirm.Name = "btnConfirm"
        Me.btnConfirm.Size = New System.Drawing.Size(129, 44)
        Me.btnConfirm.TabIndex = 45
        Me.btnConfirm.Text = "Confirm"
        Me.btnConfirm.UseVisualStyleBackColor = False
        '
        'txtConfirmPw
        '
        Me.txtConfirmPw.Font = New System.Drawing.Font("Arial Rounded MT Bold", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtConfirmPw.Location = New System.Drawing.Point(28, 361)
        Me.txtConfirmPw.Name = "txtConfirmPw"
        Me.txtConfirmPw.Size = New System.Drawing.Size(361, 32)
        Me.txtConfirmPw.TabIndex = 42
        Me.txtConfirmPw.UseSystemPasswordChar = True
        '
        'txtNewPw
        '
        Me.txtNewPw.Font = New System.Drawing.Font("Arial Rounded MT Bold", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNewPw.Location = New System.Drawing.Point(28, 264)
        Me.txtNewPw.Name = "txtNewPw"
        Me.txtNewPw.Size = New System.Drawing.Size(361, 32)
        Me.txtNewPw.TabIndex = 41
        Me.txtNewPw.UseSystemPasswordChar = True
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Arial Rounded MT Bold", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.Label2.Location = New System.Drawing.Point(24, 331)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(200, 27)
        Me.Label2.TabIndex = 50
        Me.Label2.Text = "Confirm Password :"
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Arial Rounded MT Bold", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.Label3.Location = New System.Drawing.Point(24, 234)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(160, 27)
        Me.Label3.TabIndex = 49
        Me.Label3.Text = "New Password :"
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Arial Rounded MT Bold", 22.2!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.Label1.Location = New System.Drawing.Point(100, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(380, 61)
        Me.Label1.TabIndex = 47
        Me.Label1.Text = "Change Password"
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(1, 16)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(93, 69)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 51
        Me.PictureBox2.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(423, 2)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(377, 543)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 48
        Me.PictureBox1.TabStop = False
        '
        'changePassword
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ClientSize = New System.Drawing.Size(802, 554)
        Me.Controls.Add(Me.LinkForgetPassword)
        Me.Controls.Add(Me.txtOldPw)
        Me.Controls.Add(Me.lblOLd)
        Me.Controls.Add(Me.chkShowPassword)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.btnConfirm)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.txtConfirmPw)
        Me.Controls.Add(Me.txtNewPw)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox1)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(818, 593)
        Me.MinimumSize = New System.Drawing.Size(818, 593)
        Me.Name = "changePassword"
        Me.Text = "changePassword"
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LinkForgetPassword As LinkLabel
    Friend WithEvents txtOldPw As TextBox
    Friend WithEvents lblOLd As Label
    Friend WithEvents chkShowPassword As CheckBox
    Friend WithEvents btnBack As Button
    Friend WithEvents btnConfirm As Button
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents txtConfirmPw As TextBox
    Friend WithEvents txtNewPw As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox1 As PictureBox
End Class
