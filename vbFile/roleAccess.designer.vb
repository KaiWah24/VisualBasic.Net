<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class roleAccess
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
        Me.Label8 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.dgvGeneralAccess = New System.Windows.Forms.DataGridView()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.dgvRootAccess = New System.Windows.Forms.DataGridView()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.cboRole = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnRemove = New System.Windows.Forms.Button()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.radRootAccess = New System.Windows.Forms.RadioButton()
        Me.radGeneralAccess = New System.Windows.Forms.RadioButton()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.dgvRole = New System.Windows.Forms.DataGridView()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.btnCreate = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtStaffRoleDesc = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtStaffRole = New System.Windows.Forms.TextBox()
        Me.errRoleName = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.errRoleDescription = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.errCboRole = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.errAccessType = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.GroupBox1.SuspendLayout()
        CType(Me.dgvGeneralAccess, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        CType(Me.dgvRootAccess, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        CType(Me.dgvRole, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.errRoleName, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.errRoleDescription, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.errCboRole, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.errAccessType, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(12, 9)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(418, 69)
        Me.Label8.TabIndex = 96
        Me.Label8.Text = "Role && Access"
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.GroupBox1.Controls.Add(Me.dgvGeneralAccess)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(933, 86)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(431, 407)
        Me.GroupBox1.TabIndex = 97
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "General access user"
        '
        'dgvGeneralAccess
        '
        Me.dgvGeneralAccess.AllowUserToAddRows = False
        Me.dgvGeneralAccess.AllowUserToDeleteRows = False
        Me.dgvGeneralAccess.AllowUserToResizeColumns = False
        Me.dgvGeneralAccess.AllowUserToResizeRows = False
        Me.dgvGeneralAccess.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvGeneralAccess.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvGeneralAccess.Location = New System.Drawing.Point(22, 48)
        Me.dgvGeneralAccess.Name = "dgvGeneralAccess"
        Me.dgvGeneralAccess.RowHeadersWidth = 51
        Me.dgvGeneralAccess.RowTemplate.Height = 24
        Me.dgvGeneralAccess.Size = New System.Drawing.Size(387, 339)
        Me.dgvGeneralAccess.TabIndex = 1
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.GroupBox2.Controls.Add(Me.dgvRootAccess)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(461, 86)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(431, 407)
        Me.GroupBox2.TabIndex = 98
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Root access user"
        '
        'dgvRootAccess
        '
        Me.dgvRootAccess.AllowUserToAddRows = False
        Me.dgvRootAccess.AllowUserToDeleteRows = False
        Me.dgvRootAccess.AllowUserToResizeColumns = False
        Me.dgvRootAccess.AllowUserToResizeRows = False
        Me.dgvRootAccess.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvRootAccess.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvRootAccess.Location = New System.Drawing.Point(23, 48)
        Me.dgvRootAccess.Name = "dgvRootAccess"
        Me.dgvRootAccess.RowHeadersWidth = 51
        Me.dgvRootAccess.RowTemplate.Height = 24
        Me.dgvRootAccess.Size = New System.Drawing.Size(387, 339)
        Me.dgvRootAccess.TabIndex = 0
        '
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.GroupBox3.Controls.Add(Me.cboRole)
        Me.GroupBox3.Controls.Add(Me.Label3)
        Me.GroupBox3.Controls.Add(Me.btnRemove)
        Me.GroupBox3.Controls.Add(Me.btnAdd)
        Me.GroupBox3.Controls.Add(Me.GroupBox5)
        Me.GroupBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.Location = New System.Drawing.Point(24, 106)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(406, 387)
        Me.GroupBox3.TabIndex = 99
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Manage Access"
        '
        'cboRole
        '
        Me.cboRole.FormattingEnabled = True
        Me.cboRole.Location = New System.Drawing.Point(115, 69)
        Me.cboRole.Name = "cboRole"
        Me.cboRole.Size = New System.Drawing.Size(211, 37)
        Me.cboRole.TabIndex = 6
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(47, 69)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(62, 25)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Role :"
        '
        'btnRemove
        '
        Me.btnRemove.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRemove.Location = New System.Drawing.Point(222, 313)
        Me.btnRemove.Name = "btnRemove"
        Me.btnRemove.Size = New System.Drawing.Size(104, 30)
        Me.btnRemove.TabIndex = 5
        Me.btnRemove.Text = "Remove"
        Me.btnRemove.UseVisualStyleBackColor = True
        '
        'btnAdd
        '
        Me.btnAdd.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAdd.Location = New System.Drawing.Point(101, 313)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(104, 30)
        Me.btnAdd.TabIndex = 4
        Me.btnAdd.Text = "Add"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.radRootAccess)
        Me.GroupBox5.Controls.Add(Me.radGeneralAccess)
        Me.GroupBox5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox5.Location = New System.Drawing.Point(52, 136)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(274, 153)
        Me.GroupBox5.TabIndex = 2
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "Access Type"
        '
        'radRootAccess
        '
        Me.radRootAccess.AutoSize = True
        Me.radRootAccess.Location = New System.Drawing.Point(34, 36)
        Me.radRootAccess.Name = "radRootAccess"
        Me.radRootAccess.Size = New System.Drawing.Size(149, 29)
        Me.radRootAccess.TabIndex = 0
        Me.radRootAccess.TabStop = True
        Me.radRootAccess.Text = "Root_Access"
        Me.radRootAccess.UseVisualStyleBackColor = True
        '
        'radGeneralAccess
        '
        Me.radGeneralAccess.AutoSize = True
        Me.radGeneralAccess.Location = New System.Drawing.Point(34, 80)
        Me.radGeneralAccess.Name = "radGeneralAccess"
        Me.radGeneralAccess.Size = New System.Drawing.Size(178, 29)
        Me.radGeneralAccess.TabIndex = 1
        Me.radGeneralAccess.TabStop = True
        Me.radGeneralAccess.Text = "General_Access"
        Me.radGeneralAccess.UseVisualStyleBackColor = True
        '
        'GroupBox4
        '
        Me.GroupBox4.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.GroupBox4.Controls.Add(Me.dgvRole)
        Me.GroupBox4.Controls.Add(Me.btnDelete)
        Me.GroupBox4.Controls.Add(Me.btnCreate)
        Me.GroupBox4.Controls.Add(Me.Label2)
        Me.GroupBox4.Controls.Add(Me.txtStaffRoleDesc)
        Me.GroupBox4.Controls.Add(Me.Label1)
        Me.GroupBox4.Controls.Add(Me.txtStaffRole)
        Me.GroupBox4.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox4.Location = New System.Drawing.Point(24, 531)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(1340, 387)
        Me.GroupBox4.TabIndex = 100
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Manage Access"
        '
        'dgvRole
        '
        Me.dgvRole.AllowUserToAddRows = False
        Me.dgvRole.AllowUserToDeleteRows = False
        Me.dgvRole.AllowUserToResizeColumns = False
        Me.dgvRole.AllowUserToResizeRows = False
        Me.dgvRole.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvRole.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvRole.Location = New System.Drawing.Point(437, 33)
        Me.dgvRole.Name = "dgvRole"
        Me.dgvRole.RowHeadersWidth = 51
        Me.dgvRole.RowTemplate.Height = 24
        Me.dgvRole.Size = New System.Drawing.Size(881, 339)
        Me.dgvRole.TabIndex = 1
        '
        'btnDelete
        '
        Me.btnDelete.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDelete.Location = New System.Drawing.Point(302, 292)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(104, 30)
        Me.btnDelete.TabIndex = 3
        Me.btnDelete.Text = "Delete"
        Me.btnDelete.UseVisualStyleBackColor = True
        '
        'btnCreate
        '
        Me.btnCreate.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCreate.Location = New System.Drawing.Point(181, 292)
        Me.btnCreate.Name = "btnCreate"
        Me.btnCreate.Size = New System.Drawing.Size(104, 30)
        Me.btnCreate.TabIndex = 2
        Me.btnCreate.Text = "Create"
        Me.btnCreate.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(17, 113)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(120, 25)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Description :"
        '
        'txtStaffRoleDesc
        '
        Me.txtStaffRoleDesc.Location = New System.Drawing.Point(181, 113)
        Me.txtStaffRoleDesc.Multiline = True
        Me.txtStaffRoleDesc.Name = "txtStaffRoleDesc"
        Me.txtStaffRoleDesc.Size = New System.Drawing.Size(225, 155)
        Me.txtStaffRoleDesc.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(75, 57)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(62, 25)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Role :"
        '
        'txtStaffRole
        '
        Me.txtStaffRole.Location = New System.Drawing.Point(181, 57)
        Me.txtStaffRole.Name = "txtStaffRole"
        Me.txtStaffRole.Size = New System.Drawing.Size(225, 34)
        Me.txtStaffRole.TabIndex = 0
        '
        'errRoleName
        '
        Me.errRoleName.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink
        Me.errRoleName.ContainerControl = Me
        '
        'errRoleDescription
        '
        Me.errRoleDescription.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink
        Me.errRoleDescription.ContainerControl = Me
        '
        'errCboRole
        '
        Me.errCboRole.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink
        Me.errCboRole.ContainerControl = Me
        '
        'errAccessType
        '
        Me.errAccessType.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink
        Me.errAccessType.ContainerControl = Me
        '
        'roleAccess
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = My.Resources.Resources.bg3
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1411, 1033)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label8)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(1411, 1033)
        Me.MinimumSize = New System.Drawing.Size(1411, 1033)
        Me.Name = "roleAccess"
        Me.Text = " "
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.dgvGeneralAccess, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.dgvRootAccess, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        CType(Me.dgvRole, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.errRoleName, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.errRoleDescription, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.errCboRole, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.errAccessType, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label8 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents cboRole As ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents btnRemove As Button
    Friend WithEvents btnAdd As Button
    Friend WithEvents GroupBox5 As GroupBox
    Friend WithEvents radRootAccess As RadioButton
    Friend WithEvents radGeneralAccess As RadioButton
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents btnDelete As Button
    Friend WithEvents btnCreate As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents txtStaffRoleDesc As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txtStaffRole As TextBox
    Friend WithEvents dgvGeneralAccess As DataGridView
    Friend WithEvents dgvRootAccess As DataGridView
    Friend WithEvents dgvRole As DataGridView
    Friend WithEvents errRoleName As ErrorProvider
    Friend WithEvents errRoleDescription As ErrorProvider
    Friend WithEvents errCboRole As ErrorProvider
    Friend WithEvents errAccessType As ErrorProvider
End Class
