<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmInventoryEdit
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmInventoryEdit))
        Me.grpEdit = New System.Windows.Forms.GroupBox()
        Me.txtEditDescription = New System.Windows.Forms.TextBox()
        Me.lblEditDescription = New System.Windows.Forms.Label()
        Me.btnEditCancel = New System.Windows.Forms.Button()
        Me.btnEditConfirm = New System.Windows.Forms.Button()
        Me.txtEditPrice = New System.Windows.Forms.TextBox()
        Me.lblEditPrice = New System.Windows.Forms.Label()
        Me.txtEditName = New System.Windows.Forms.TextBox()
        Me.lblEditName = New System.Windows.Forms.Label()
        Me.btnEdit = New System.Windows.Forms.Button()
        Me.cboEdit = New System.Windows.Forms.ComboBox()
        Me.picEdit = New System.Windows.Forms.PictureBox()
        Me.err = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.lblEditRm = New System.Windows.Forms.Label()
        Me.grpEdit.SuspendLayout()
        CType(Me.picEdit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.err, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'grpEdit
        '
        Me.grpEdit.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.grpEdit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.grpEdit.Controls.Add(Me.lblEditRm)
        Me.grpEdit.Controls.Add(Me.txtEditDescription)
        Me.grpEdit.Controls.Add(Me.lblEditDescription)
        Me.grpEdit.Controls.Add(Me.btnEditCancel)
        Me.grpEdit.Controls.Add(Me.btnEditConfirm)
        Me.grpEdit.Controls.Add(Me.txtEditPrice)
        Me.grpEdit.Controls.Add(Me.lblEditPrice)
        Me.grpEdit.Controls.Add(Me.txtEditName)
        Me.grpEdit.Controls.Add(Me.lblEditName)
        Me.grpEdit.Controls.Add(Me.btnEdit)
        Me.grpEdit.Controls.Add(Me.cboEdit)
        Me.grpEdit.Controls.Add(Me.picEdit)
        Me.grpEdit.Location = New System.Drawing.Point(239, 68)
        Me.grpEdit.Name = "grpEdit"
        Me.grpEdit.Size = New System.Drawing.Size(635, 738)
        Me.grpEdit.TabIndex = 1
        Me.grpEdit.TabStop = False
        '
        'txtEditDescription
        '
        Me.txtEditDescription.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEditDescription.Location = New System.Drawing.Point(295, 495)
        Me.txtEditDescription.Multiline = True
        Me.txtEditDescription.Name = "txtEditDescription"
        Me.txtEditDescription.Size = New System.Drawing.Size(295, 149)
        Me.txtEditDescription.TabIndex = 10
        '
        'lblEditDescription
        '
        Me.lblEditDescription.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEditDescription.Location = New System.Drawing.Point(86, 500)
        Me.lblEditDescription.Name = "lblEditDescription"
        Me.lblEditDescription.Size = New System.Drawing.Size(203, 23)
        Me.lblEditDescription.TabIndex = 9
        Me.lblEditDescription.Text = "Product Description :"
        '
        'btnEditCancel
        '
        Me.btnEditCancel.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEditCancel.Location = New System.Drawing.Point(466, 671)
        Me.btnEditCancel.Name = "btnEditCancel"
        Me.btnEditCancel.Size = New System.Drawing.Size(124, 49)
        Me.btnEditCancel.TabIndex = 8
        Me.btnEditCancel.Text = "Cancel"
        Me.btnEditCancel.UseVisualStyleBackColor = True
        '
        'btnEditConfirm
        '
        Me.btnEditConfirm.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEditConfirm.Location = New System.Drawing.Point(296, 671)
        Me.btnEditConfirm.Name = "btnEditConfirm"
        Me.btnEditConfirm.Size = New System.Drawing.Size(132, 49)
        Me.btnEditConfirm.TabIndex = 7
        Me.btnEditConfirm.Text = "Confirm"
        Me.btnEditConfirm.UseVisualStyleBackColor = True
        '
        'txtEditPrice
        '
        Me.txtEditPrice.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEditPrice.Location = New System.Drawing.Point(295, 433)
        Me.txtEditPrice.Name = "txtEditPrice"
        Me.txtEditPrice.Size = New System.Drawing.Size(295, 28)
        Me.txtEditPrice.TabIndex = 6
        '
        'lblEditPrice
        '
        Me.lblEditPrice.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEditPrice.Location = New System.Drawing.Point(86, 433)
        Me.lblEditPrice.Name = "lblEditPrice"
        Me.lblEditPrice.Size = New System.Drawing.Size(144, 23)
        Me.lblEditPrice.TabIndex = 5
        Me.lblEditPrice.Text = "Product Price :"
        '
        'txtEditName
        '
        Me.txtEditName.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEditName.Location = New System.Drawing.Point(295, 378)
        Me.txtEditName.Name = "txtEditName"
        Me.txtEditName.Size = New System.Drawing.Size(295, 28)
        Me.txtEditName.TabIndex = 4
        '
        'lblEditName
        '
        Me.lblEditName.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEditName.Location = New System.Drawing.Point(86, 381)
        Me.lblEditName.Name = "lblEditName"
        Me.lblEditName.Size = New System.Drawing.Size(167, 23)
        Me.lblEditName.TabIndex = 3
        Me.lblEditName.Text = "Product Name:"
        '
        'btnEdit
        '
        Me.btnEdit.Font = New System.Drawing.Font("Modern No. 20", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEdit.Location = New System.Drawing.Point(253, 281)
        Me.btnEdit.Name = "btnEdit"
        Me.btnEdit.Size = New System.Drawing.Size(175, 49)
        Me.btnEdit.TabIndex = 2
        Me.btnEdit.Text = "Upload Image"
        Me.btnEdit.UseVisualStyleBackColor = True
        '
        'cboEdit
        '
        Me.cboEdit.FormattingEnabled = True
        Me.cboEdit.Location = New System.Drawing.Point(253, 235)
        Me.cboEdit.Name = "cboEdit"
        Me.cboEdit.Size = New System.Drawing.Size(175, 24)
        Me.cboEdit.TabIndex = 1
        '
        'picEdit
        '
        Me.picEdit.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.picEdit.Location = New System.Drawing.Point(253, 32)
        Me.picEdit.Name = "picEdit"
        Me.picEdit.Size = New System.Drawing.Size(175, 173)
        Me.picEdit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picEdit.TabIndex = 0
        Me.picEdit.TabStop = False
        '
        'err
        '
        Me.err.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink
        Me.err.ContainerControl = Me
        '
        'lblEditRm
        '
        Me.lblEditRm.AutoSize = True
        Me.lblEditRm.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEditRm.ForeColor = System.Drawing.Color.Black
        Me.lblEditRm.Location = New System.Drawing.Point(250, 439)
        Me.lblEditRm.Name = "lblEditRm"
        Me.lblEditRm.Size = New System.Drawing.Size(34, 18)
        Me.lblEditRm.TabIndex = 17
        Me.lblEditRm.Text = "RM"
        '
        'frmInventoryEdit
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1111, 848)
        Me.Controls.Add(Me.grpEdit)
        Me.DoubleBuffered = True
        Me.MaximumSize = New System.Drawing.Size(1680, 1050)
        Me.Name = "frmInventoryEdit"
        Me.Text = "frmInventoryEdit"
        Me.grpEdit.ResumeLayout(False)
        Me.grpEdit.PerformLayout()
        CType(Me.picEdit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.err, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents grpEdit As GroupBox
    Friend WithEvents btnEditCancel As Button
    Friend WithEvents btnEditConfirm As Button
    Friend WithEvents txtEditPrice As TextBox
    Friend WithEvents lblEditPrice As Label
    Friend WithEvents txtEditName As TextBox
    Friend WithEvents lblEditName As Label
    Friend WithEvents btnEdit As Button
    Friend WithEvents cboEdit As ComboBox
    Friend WithEvents picEdit As PictureBox
    Friend WithEvents lblEditDescription As Label
    Friend WithEvents txtEditDescription As TextBox
    Friend WithEvents err As ErrorProvider
    Friend WithEvents lblEditRm As Label
End Class
