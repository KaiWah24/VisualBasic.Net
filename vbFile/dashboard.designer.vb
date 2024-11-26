<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class dashboard
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
        Me.components = New System.ComponentModel.Container()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.dgvLogin = New System.Windows.Forms.DataGridView()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.lblStaffName = New System.Windows.Forms.Label()
        Me.picStaff = New System.Windows.Forms.PictureBox()
        Me.lbltext = New System.Windows.Forms.Label()
        Me.lblDateTime = New System.Windows.Forms.Label()
        Me.TimerToday = New System.Windows.Forms.Timer(Me.components)
        Me.GroupBox4.SuspendLayout()
        CType(Me.dgvLogin, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.picStaff, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(36, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.Label5.Location = New System.Drawing.Point(12, 13)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(321, 69)
        Me.Label5.TabIndex = 86
        Me.Label5.Text = "Dashboard"
        '
        'GroupBox4
        '
        Me.GroupBox4.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.GroupBox4.Controls.Add(Me.dgvLogin)
        Me.GroupBox4.Font = New System.Drawing.Font("Arial Rounded MT Bold", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox4.Location = New System.Drawing.Point(24, 419)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(1364, 520)
        Me.GroupBox4.TabIndex = 90
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Login History"
        '
        'dgvLogin
        '
        Me.dgvLogin.AllowUserToAddRows = False
        Me.dgvLogin.AllowUserToDeleteRows = False
        Me.dgvLogin.AllowUserToResizeColumns = False
        Me.dgvLogin.AllowUserToResizeRows = False
        Me.dgvLogin.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvLogin.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvLogin.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvLogin.Location = New System.Drawing.Point(26, 44)
        Me.dgvLogin.Name = "dgvLogin"
        Me.dgvLogin.RowHeadersWidth = 51
        Me.dgvLogin.RowTemplate.Height = 24
        Me.dgvLogin.Size = New System.Drawing.Size(1314, 451)
        Me.dgvLogin.TabIndex = 0
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.GroupBox1.Controls.Add(Me.lblStaffName)
        Me.GroupBox1.Controls.Add(Me.picStaff)
        Me.GroupBox1.Controls.Add(Me.lbltext)
        Me.GroupBox1.Location = New System.Drawing.Point(110, 106)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(427, 242)
        Me.GroupBox1.TabIndex = 87
        Me.GroupBox1.TabStop = False
        '
        'lblStaffName
        '
        Me.lblStaffName.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStaffName.Location = New System.Drawing.Point(6, 139)
        Me.lblStaffName.Name = "lblStaffName"
        Me.lblStaffName.Size = New System.Drawing.Size(272, 58)
        Me.lblStaffName.TabIndex = 81
        Me.lblStaffName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'picStaff
        '
        Me.picStaff.BackColor = System.Drawing.Color.Transparent
        Me.picStaff.Cursor = System.Windows.Forms.Cursors.Hand
        Me.picStaff.Image = My.Resources.Resources.user__1_
        Me.picStaff.Location = New System.Drawing.Point(287, 110)
        Me.picStaff.Name = "picStaff"
        Me.picStaff.Size = New System.Drawing.Size(105, 87)
        Me.picStaff.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picStaff.TabIndex = 69
        Me.picStaff.TabStop = False
        '
        'lbltext
        '
        Me.lbltext.AutoSize = True
        Me.lbltext.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbltext.ForeColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(36, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.lbltext.Location = New System.Drawing.Point(19, 39)
        Me.lbltext.Name = "lbltext"
        Me.lbltext.Size = New System.Drawing.Size(150, 25)
        Me.lbltext.TabIndex = 80
        Me.lbltext.Text = "Good Afternoon"
        '
        'lblDateTime
        '
        Me.lblDateTime.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lblDateTime.Font = New System.Drawing.Font("Microsoft Sans Serif", 28.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDateTime.Location = New System.Drawing.Point(724, 202)
        Me.lblDateTime.Name = "lblDateTime"
        Me.lblDateTime.Size = New System.Drawing.Size(624, 111)
        Me.lblDateTime.TabIndex = 91
        Me.lblDateTime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TimerToday
        '
        '
        'dashboard
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = My.Resources.Resources.bg3
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1411, 1033)
        Me.Controls.Add(Me.lblDateTime)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(1411, 1033)
        Me.MinimumSize = New System.Drawing.Size(1411, 1033)
        Me.Name = "dashboard"
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show
        Me.Text = "dashboard"
        Me.GroupBox4.ResumeLayout(False)
        CType(Me.dgvLogin, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.picStaff, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label5 As Label
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents picStaff As PictureBox
    Friend WithEvents lbltext As Label
    Friend WithEvents dgvLogin As DataGridView
    Friend WithEvents lblDateTime As Label
    Friend WithEvents TimerToday As Timer
    Friend WithEvents lblStaffName As Label
End Class
