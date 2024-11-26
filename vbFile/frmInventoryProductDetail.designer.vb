<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmInventoryProductDetail
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
        Me.grpProductDetail = New System.Windows.Forms.GroupBox()
        Me.txtProductDetailDescription = New System.Windows.Forms.TextBox()
        Me.picProductDetailQrCode = New System.Windows.Forms.PictureBox()
        Me.btnQR = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnProductDetailCancel = New System.Windows.Forms.Button()
        Me.lblProductDetailQuantity = New System.Windows.Forms.Label()
        Me.lblProductDetailQuantityTag = New System.Windows.Forms.Label()
        Me.btnProductDetailDelete = New System.Windows.Forms.Button()
        Me.lblProductDeatilDescriptionTag = New System.Windows.Forms.Label()
        Me.lblProductDetailPrice = New System.Windows.Forms.Label()
        Me.lblProductDetailPriceTag = New System.Windows.Forms.Label()
        Me.lblProductDetailName = New System.Windows.Forms.Label()
        Me.lblProductDetailNameTag = New System.Windows.Forms.Label()
        Me.picProductDetailBarcode = New System.Windows.Forms.PictureBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.grpProductDetail.SuspendLayout()
        CType(Me.picProductDetailQrCode, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picProductDetailBarcode, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'grpProductDetail
        '
        Me.grpProductDetail.BackColor = System.Drawing.Color.White
        Me.grpProductDetail.Controls.Add(Me.txtProductDetailDescription)
        Me.grpProductDetail.Controls.Add(Me.picProductDetailQrCode)
        Me.grpProductDetail.Controls.Add(Me.btnQR)
        Me.grpProductDetail.Controls.Add(Me.Label4)
        Me.grpProductDetail.Controls.Add(Me.Label3)
        Me.grpProductDetail.Controls.Add(Me.Label2)
        Me.grpProductDetail.Controls.Add(Me.Label1)
        Me.grpProductDetail.Controls.Add(Me.btnProductDetailCancel)
        Me.grpProductDetail.Controls.Add(Me.lblProductDetailQuantity)
        Me.grpProductDetail.Controls.Add(Me.lblProductDetailQuantityTag)
        Me.grpProductDetail.Controls.Add(Me.btnProductDetailDelete)
        Me.grpProductDetail.Controls.Add(Me.lblProductDeatilDescriptionTag)
        Me.grpProductDetail.Controls.Add(Me.lblProductDetailPrice)
        Me.grpProductDetail.Controls.Add(Me.lblProductDetailPriceTag)
        Me.grpProductDetail.Controls.Add(Me.lblProductDetailName)
        Me.grpProductDetail.Controls.Add(Me.lblProductDetailNameTag)
        Me.grpProductDetail.Controls.Add(Me.picProductDetailBarcode)
        Me.grpProductDetail.Controls.Add(Me.Label5)
        Me.grpProductDetail.Location = New System.Drawing.Point(127, 46)
        Me.grpProductDetail.Name = "grpProductDetail"
        Me.grpProductDetail.Size = New System.Drawing.Size(823, 880)
        Me.grpProductDetail.TabIndex = 0
        Me.grpProductDetail.TabStop = False
        '
        'txtProductDetailDescription
        '
        Me.txtProductDetailDescription.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtProductDetailDescription.Location = New System.Drawing.Point(328, 561)
        Me.txtProductDetailDescription.Multiline = True
        Me.txtProductDetailDescription.Name = "txtProductDetailDescription"
        Me.txtProductDetailDescription.Size = New System.Drawing.Size(358, 150)
        Me.txtProductDetailDescription.TabIndex = 17
        '
        'picProductDetailQrCode
        '
        Me.picProductDetailQrCode.Location = New System.Drawing.Point(251, 67)
        Me.picProductDetailQrCode.Name = "picProductDetailQrCode"
        Me.picProductDetailQrCode.Size = New System.Drawing.Size(328, 206)
        Me.picProductDetailQrCode.TabIndex = 16
        Me.picProductDetailQrCode.TabStop = False
        Me.picProductDetailQrCode.Visible = False
        '
        'btnQR
        '
        Me.btnQR.Location = New System.Drawing.Point(674, 150)
        Me.btnQR.Name = "btnQR"
        Me.btnQR.Size = New System.Drawing.Size(86, 51)
        Me.btnQR.TabIndex = 15
        Me.btnQR.Text = "QR Code"
        Me.btnQR.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.Gainsboro
        Me.Label4.Location = New System.Drawing.Point(6, 862)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(104, 27)
        Me.Label4.TabIndex = 13
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.Gainsboro
        Me.Label3.Location = New System.Drawing.Point(-3, 779)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(23, 101)
        Me.Label3.TabIndex = 12
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.Gainsboro
        Me.Label2.Location = New System.Drawing.Point(800, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(23, 101)
        Me.Label2.TabIndex = 11
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Gainsboro
        Me.Label1.Location = New System.Drawing.Point(705, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(161, 23)
        Me.Label1.TabIndex = 1
        '
        'btnProductDetailCancel
        '
        Me.btnProductDetailCancel.Font = New System.Drawing.Font("Modern No. 20", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnProductDetailCancel.Location = New System.Drawing.Point(654, 779)
        Me.btnProductDetailCancel.Name = "btnProductDetailCancel"
        Me.btnProductDetailCancel.Size = New System.Drawing.Size(146, 45)
        Me.btnProductDetailCancel.TabIndex = 10
        Me.btnProductDetailCancel.Text = "Cancel"
        Me.btnProductDetailCancel.UseVisualStyleBackColor = True
        '
        'lblProductDetailQuantity
        '
        Me.lblProductDetailQuantity.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblProductDetailQuantity.Font = New System.Drawing.Font("Microsoft YaHei UI", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblProductDetailQuantity.Location = New System.Drawing.Point(328, 484)
        Me.lblProductDetailQuantity.Name = "lblProductDetailQuantity"
        Me.lblProductDetailQuantity.Size = New System.Drawing.Size(358, 35)
        Me.lblProductDetailQuantity.TabIndex = 9
        Me.lblProductDetailQuantity.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblProductDetailQuantityTag
        '
        Me.lblProductDetailQuantityTag.Font = New System.Drawing.Font("Microsoft YaHei", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblProductDetailQuantityTag.Location = New System.Drawing.Point(73, 493)
        Me.lblProductDetailQuantityTag.Name = "lblProductDetailQuantityTag"
        Me.lblProductDetailQuantityTag.Size = New System.Drawing.Size(191, 35)
        Me.lblProductDetailQuantityTag.TabIndex = 8
        Me.lblProductDetailQuantityTag.Text = "Product Quantity :"
        '
        'btnProductDetailDelete
        '
        Me.btnProductDetailDelete.Font = New System.Drawing.Font("Modern No. 20", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnProductDetailDelete.Location = New System.Drawing.Point(479, 779)
        Me.btnProductDetailDelete.Name = "btnProductDetailDelete"
        Me.btnProductDetailDelete.Size = New System.Drawing.Size(146, 45)
        Me.btnProductDetailDelete.TabIndex = 7
        Me.btnProductDetailDelete.Text = "Off Shelves"
        Me.btnProductDetailDelete.UseVisualStyleBackColor = True
        '
        'lblProductDeatilDescriptionTag
        '
        Me.lblProductDeatilDescriptionTag.Font = New System.Drawing.Font("Microsoft YaHei", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblProductDeatilDescriptionTag.Location = New System.Drawing.Point(73, 561)
        Me.lblProductDeatilDescriptionTag.Name = "lblProductDeatilDescriptionTag"
        Me.lblProductDeatilDescriptionTag.Size = New System.Drawing.Size(236, 35)
        Me.lblProductDeatilDescriptionTag.TabIndex = 5
        Me.lblProductDeatilDescriptionTag.Text = "Product Description :"
        '
        'lblProductDetailPrice
        '
        Me.lblProductDetailPrice.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblProductDetailPrice.Font = New System.Drawing.Font("Microsoft YaHei UI", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblProductDetailPrice.Location = New System.Drawing.Point(328, 420)
        Me.lblProductDetailPrice.Name = "lblProductDetailPrice"
        Me.lblProductDetailPrice.Size = New System.Drawing.Size(358, 35)
        Me.lblProductDetailPrice.TabIndex = 4
        Me.lblProductDetailPrice.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblProductDetailPriceTag
        '
        Me.lblProductDetailPriceTag.Font = New System.Drawing.Font("Microsoft YaHei", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblProductDetailPriceTag.Location = New System.Drawing.Point(73, 420)
        Me.lblProductDetailPriceTag.Name = "lblProductDetailPriceTag"
        Me.lblProductDetailPriceTag.Size = New System.Drawing.Size(191, 35)
        Me.lblProductDetailPriceTag.TabIndex = 3
        Me.lblProductDetailPriceTag.Text = "Product Price :"
        '
        'lblProductDetailName
        '
        Me.lblProductDetailName.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblProductDetailName.Font = New System.Drawing.Font("Microsoft YaHei UI", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblProductDetailName.Location = New System.Drawing.Point(328, 354)
        Me.lblProductDetailName.Name = "lblProductDetailName"
        Me.lblProductDetailName.Size = New System.Drawing.Size(358, 35)
        Me.lblProductDetailName.TabIndex = 2
        Me.lblProductDetailName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblProductDetailNameTag
        '
        Me.lblProductDetailNameTag.Font = New System.Drawing.Font("Microsoft YaHei", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblProductDetailNameTag.Location = New System.Drawing.Point(73, 354)
        Me.lblProductDetailNameTag.Name = "lblProductDetailNameTag"
        Me.lblProductDetailNameTag.Size = New System.Drawing.Size(191, 35)
        Me.lblProductDetailNameTag.TabIndex = 1
        Me.lblProductDetailNameTag.Text = "Product Name :"
        '
        'picProductDetailBarcode
        '
        Me.picProductDetailBarcode.Location = New System.Drawing.Point(251, 67)
        Me.picProductDetailBarcode.Name = "picProductDetailBarcode"
        Me.picProductDetailBarcode.Size = New System.Drawing.Size(328, 206)
        Me.picProductDetailBarcode.TabIndex = 0
        Me.picProductDetailBarcode.TabStop = False
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.Color.PaleGreen
        Me.Label5.Location = New System.Drawing.Point(241, 57)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(347, 226)
        Me.Label5.TabIndex = 14
        '
        'frmInventoryProductDetail
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(36, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1095, 1003)
        Me.Controls.Add(Me.grpProductDetail)
        Me.MaximumSize = New System.Drawing.Size(1680, 1050)
        Me.Name = "frmInventoryProductDetail"
        Me.Text = "frmInventoryProductDetail"
        Me.grpProductDetail.ResumeLayout(False)
        Me.grpProductDetail.PerformLayout()
        CType(Me.picProductDetailQrCode, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picProductDetailBarcode, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents grpProductDetail As GroupBox
    Friend WithEvents btnProductDetailDelete As Button
    Friend WithEvents lblProductDeatilDescriptionTag As Label
    Friend WithEvents lblProductDetailPrice As Label
    Friend WithEvents lblProductDetailPriceTag As Label
    Friend WithEvents lblProductDetailName As Label
    Friend WithEvents lblProductDetailNameTag As Label
    Friend WithEvents picProductDetailBarcode As PictureBox
    Friend WithEvents lblProductDetailQuantity As Label
    Friend WithEvents lblProductDetailQuantityTag As Label
    Friend WithEvents btnProductDetailCancel As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents btnQR As Button
    Friend WithEvents picProductDetailQrCode As PictureBox
    Friend WithEvents txtProductDetailDescription As TextBox
End Class
