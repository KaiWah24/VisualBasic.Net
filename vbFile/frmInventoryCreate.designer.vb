<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmInventoryCreate
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
        Me.grpCreate = New System.Windows.Forms.GroupBox()
        Me.txtCreateDescription = New System.Windows.Forms.TextBox()
        Me.lblCreateDescriptionTag = New System.Windows.Forms.Label()
        Me.txtCreateQuantity = New System.Windows.Forms.TextBox()
        Me.lblCreateQuantity = New System.Windows.Forms.Label()
        Me.lblCreateCategory = New System.Windows.Forms.Label()
        Me.lblCreateCategoryTag = New System.Windows.Forms.Label()
        Me.btnCreateCancel = New System.Windows.Forms.Button()
        Me.btnCreateConfirm = New System.Windows.Forms.Button()
        Me.lblCreatePrice = New System.Windows.Forms.Label()
        Me.txtCreatePrice = New System.Windows.Forms.TextBox()
        Me.txtCreateName = New System.Windows.Forms.TextBox()
        Me.lblCreateName = New System.Windows.Forms.Label()
        Me.picCreate = New System.Windows.Forms.PictureBox()
        Me.btnCreateImage = New System.Windows.Forms.Button()
        Me.err = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.lblCreateRm = New System.Windows.Forms.Label()
        Me.grpCreate.SuspendLayout()
        CType(Me.picCreate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.err, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'grpCreate
        '
        Me.grpCreate.BackColor = System.Drawing.Color.FromArgb(CType(CType(23, Byte), Integer), CType(CType(36, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.grpCreate.Controls.Add(Me.lblCreateRm)
        Me.grpCreate.Controls.Add(Me.txtCreateDescription)
        Me.grpCreate.Controls.Add(Me.lblCreateDescriptionTag)
        Me.grpCreate.Controls.Add(Me.txtCreateQuantity)
        Me.grpCreate.Controls.Add(Me.lblCreateQuantity)
        Me.grpCreate.Controls.Add(Me.lblCreateCategory)
        Me.grpCreate.Controls.Add(Me.lblCreateCategoryTag)
        Me.grpCreate.Controls.Add(Me.btnCreateCancel)
        Me.grpCreate.Controls.Add(Me.btnCreateConfirm)
        Me.grpCreate.Controls.Add(Me.lblCreatePrice)
        Me.grpCreate.Controls.Add(Me.txtCreatePrice)
        Me.grpCreate.Controls.Add(Me.txtCreateName)
        Me.grpCreate.Controls.Add(Me.lblCreateName)
        Me.grpCreate.Controls.Add(Me.picCreate)
        Me.grpCreate.Controls.Add(Me.btnCreateImage)
        Me.grpCreate.Location = New System.Drawing.Point(119, 44)
        Me.grpCreate.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.grpCreate.Name = "grpCreate"
        Me.grpCreate.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.grpCreate.Size = New System.Drawing.Size(530, 803)
        Me.grpCreate.TabIndex = 3
        Me.grpCreate.TabStop = False
        '
        'txtCreateDescription
        '
        Me.txtCreateDescription.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtCreateDescription.BackColor = System.Drawing.SystemColors.Window
        Me.txtCreateDescription.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCreateDescription.Location = New System.Drawing.Point(239, 497)
        Me.txtCreateDescription.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtCreateDescription.Multiline = True
        Me.txtCreateDescription.Name = "txtCreateDescription"
        Me.txtCreateDescription.Size = New System.Drawing.Size(236, 130)
        Me.txtCreateDescription.TabIndex = 15
        '
        'lblCreateDescriptionTag
        '
        Me.lblCreateDescriptionTag.BackColor = System.Drawing.Color.Transparent
        Me.lblCreateDescriptionTag.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCreateDescriptionTag.ForeColor = System.Drawing.Color.White
        Me.lblCreateDescriptionTag.Location = New System.Drawing.Point(50, 499)
        Me.lblCreateDescriptionTag.Name = "lblCreateDescriptionTag"
        Me.lblCreateDescriptionTag.Size = New System.Drawing.Size(156, 22)
        Me.lblCreateDescriptionTag.TabIndex = 13
        Me.lblCreateDescriptionTag.Text = "Description :"
        '
        'txtCreateQuantity
        '
        Me.txtCreateQuantity.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCreateQuantity.Location = New System.Drawing.Point(239, 405)
        Me.txtCreateQuantity.Name = "txtCreateQuantity"
        Me.txtCreateQuantity.Size = New System.Drawing.Size(236, 24)
        Me.txtCreateQuantity.TabIndex = 12
        '
        'lblCreateQuantity
        '
        Me.lblCreateQuantity.AutoSize = True
        Me.lblCreateQuantity.BackColor = System.Drawing.Color.Transparent
        Me.lblCreateQuantity.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCreateQuantity.ForeColor = System.Drawing.Color.White
        Me.lblCreateQuantity.Location = New System.Drawing.Point(50, 402)
        Me.lblCreateQuantity.Name = "lblCreateQuantity"
        Me.lblCreateQuantity.Size = New System.Drawing.Size(170, 24)
        Me.lblCreateQuantity.TabIndex = 11
        Me.lblCreateQuantity.Text = "Product Quantity:"
        '
        'lblCreateCategory
        '
        Me.lblCreateCategory.BackColor = System.Drawing.Color.White
        Me.lblCreateCategory.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblCreateCategory.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCreateCategory.ForeColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(36, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.lblCreateCategory.Location = New System.Drawing.Point(239, 453)
        Me.lblCreateCategory.Name = "lblCreateCategory"
        Me.lblCreateCategory.Size = New System.Drawing.Size(236, 22)
        Me.lblCreateCategory.TabIndex = 10
        Me.lblCreateCategory.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblCreateCategoryTag
        '
        Me.lblCreateCategoryTag.BackColor = System.Drawing.Color.Transparent
        Me.lblCreateCategoryTag.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCreateCategoryTag.ForeColor = System.Drawing.Color.White
        Me.lblCreateCategoryTag.Location = New System.Drawing.Point(50, 450)
        Me.lblCreateCategoryTag.Name = "lblCreateCategoryTag"
        Me.lblCreateCategoryTag.Size = New System.Drawing.Size(156, 35)
        Me.lblCreateCategoryTag.TabIndex = 9
        Me.lblCreateCategoryTag.Text = "Category :"
        '
        'btnCreateCancel
        '
        Me.btnCreateCancel.Font = New System.Drawing.Font("Microsoft YaHei", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCreateCancel.Location = New System.Drawing.Point(370, 736)
        Me.btnCreateCancel.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnCreateCancel.Name = "btnCreateCancel"
        Me.btnCreateCancel.Size = New System.Drawing.Size(105, 43)
        Me.btnCreateCancel.TabIndex = 8
        Me.btnCreateCancel.Text = "Cancel"
        Me.btnCreateCancel.UseVisualStyleBackColor = True
        '
        'btnCreateConfirm
        '
        Me.btnCreateConfirm.Font = New System.Drawing.Font("Microsoft YaHei", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCreateConfirm.Location = New System.Drawing.Point(239, 736)
        Me.btnCreateConfirm.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnCreateConfirm.Name = "btnCreateConfirm"
        Me.btnCreateConfirm.Size = New System.Drawing.Size(104, 43)
        Me.btnCreateConfirm.TabIndex = 7
        Me.btnCreateConfirm.Text = "Confirm"
        Me.btnCreateConfirm.UseVisualStyleBackColor = True
        '
        'lblCreatePrice
        '
        Me.lblCreatePrice.BackColor = System.Drawing.Color.Transparent
        Me.lblCreatePrice.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCreatePrice.ForeColor = System.Drawing.Color.White
        Me.lblCreatePrice.Location = New System.Drawing.Point(50, 354)
        Me.lblCreatePrice.Name = "lblCreatePrice"
        Me.lblCreatePrice.Size = New System.Drawing.Size(156, 22)
        Me.lblCreatePrice.TabIndex = 6
        Me.lblCreatePrice.Text = "Product Price:"
        '
        'txtCreatePrice
        '
        Me.txtCreatePrice.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCreatePrice.Location = New System.Drawing.Point(239, 354)
        Me.txtCreatePrice.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtCreatePrice.Name = "txtCreatePrice"
        Me.txtCreatePrice.Size = New System.Drawing.Size(236, 24)
        Me.txtCreatePrice.TabIndex = 5
        '
        'txtCreateName
        '
        Me.txtCreateName.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCreateName.Location = New System.Drawing.Point(239, 308)
        Me.txtCreateName.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtCreateName.Name = "txtCreateName"
        Me.txtCreateName.Size = New System.Drawing.Size(236, 24)
        Me.txtCreateName.TabIndex = 4
        '
        'lblCreateName
        '
        Me.lblCreateName.BackColor = System.Drawing.Color.Transparent
        Me.lblCreateName.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCreateName.ForeColor = System.Drawing.Color.White
        Me.lblCreateName.Location = New System.Drawing.Point(49, 308)
        Me.lblCreateName.MaximumSize = New System.Drawing.Size(1680, 1050)
        Me.lblCreateName.Name = "lblCreateName"
        Me.lblCreateName.Size = New System.Drawing.Size(157, 22)
        Me.lblCreateName.TabIndex = 3
        Me.lblCreateName.Text = "Product Name:"
        '
        'picCreate
        '
        Me.picCreate.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(36, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.picCreate.BackgroundImage = My.Resources.Resources.inventoryImg
        Me.picCreate.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.picCreate.Location = New System.Drawing.Point(174, 39)
        Me.picCreate.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.picCreate.Name = "picCreate"
        Me.picCreate.Size = New System.Drawing.Size(175, 173)
        Me.picCreate.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picCreate.TabIndex = 2
        Me.picCreate.TabStop = False
        '
        'btnCreateImage
        '
        Me.btnCreateImage.Font = New System.Drawing.Font("Modern No. 20", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCreateImage.Location = New System.Drawing.Point(201, 226)
        Me.btnCreateImage.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnCreateImage.Name = "btnCreateImage"
        Me.btnCreateImage.Size = New System.Drawing.Size(120, 50)
        Me.btnCreateImage.TabIndex = 1
        Me.btnCreateImage.Text = "Image"
        Me.btnCreateImage.UseVisualStyleBackColor = True
        '
        'err
        '
        Me.err.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink
        Me.err.ContainerControl = Me
        '
        'lblCreateRm
        '
        Me.lblCreateRm.AutoSize = True
        Me.lblCreateRm.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCreateRm.ForeColor = System.Drawing.Color.White
        Me.lblCreateRm.Location = New System.Drawing.Point(199, 358)
        Me.lblCreateRm.Name = "lblCreateRm"
        Me.lblCreateRm.Size = New System.Drawing.Size(34, 18)
        Me.lblCreateRm.TabIndex = 16
        Me.lblCreateRm.Text = "RM"
        '
        'frmInventoryCreate
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = My.Resources.Resources.createInventoryBckgrd
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1460, 901)
        Me.Controls.Add(Me.grpCreate)
        Me.MaximumSize = New System.Drawing.Size(1680, 1050)
        Me.Name = "frmInventoryCreate"
        Me.Text = "frmInventoryCreate"
        Me.grpCreate.ResumeLayout(False)
        Me.grpCreate.PerformLayout()
        CType(Me.picCreate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.err, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents grpCreate As GroupBox
    Friend WithEvents lblCreateCategory As Label
    Friend WithEvents lblCreateCategoryTag As Label
    Friend WithEvents btnCreateCancel As Button
    Friend WithEvents btnCreateConfirm As Button
    Friend WithEvents lblCreatePrice As Label
    Friend WithEvents txtCreatePrice As TextBox
    Friend WithEvents txtCreateName As TextBox
    Friend WithEvents lblCreateName As Label
    Friend WithEvents picCreate As PictureBox
    Friend WithEvents btnCreateImage As Button
    Friend WithEvents txtCreateQuantity As TextBox
    Friend WithEvents lblCreateQuantity As Label
    Friend WithEvents lblCreateDescriptionTag As Label
    Friend WithEvents err As ErrorProvider
    Friend WithEvents txtCreateDescription As TextBox
    Friend WithEvents lblCreateRm As Label
End Class
