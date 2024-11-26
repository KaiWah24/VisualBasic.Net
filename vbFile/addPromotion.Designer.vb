<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class addPromotion
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.btnSavePromotion = New System.Windows.Forms.Button()
        Me.grpVoucher = New System.Windows.Forms.GroupBox()
        Me.btnRandomGenerate = New System.Windows.Forms.Button()
        Me.txtVoucherCode = New System.Windows.Forms.TextBox()
        Me.numUsageLimit = New System.Windows.Forms.NumericUpDown()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.lblPromoStatus = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.radStartLater = New System.Windows.Forms.RadioButton()
        Me.radStartNow = New System.Windows.Forms.RadioButton()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.grpProduct = New System.Windows.Forms.GroupBox()
        Me.btnCalculate = New System.Windows.Forms.Button()
        Me.lblPriceAfterDiscount = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.lblProductPrice = New System.Windows.Forms.Label()
        Me.lblProductID = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.cboProduct = New System.Windows.Forms.ComboBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.numDiscountValue = New System.Windows.Forms.NumericUpDown()
        Me.lblDiscountValue = New System.Windows.Forms.Label()
        Me.cboDiscountType = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.cboPromotionType = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.dtpEndDate = New System.Windows.Forms.DateTimePicker()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.dtpStartDate = New System.Windows.Forms.DateTimePicker()
        Me.txtPromoName = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.ErrorProvider2 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.ErrorProvider3 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.ErrorProvider4 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.ErrorProvider5 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.ErrorProvider6 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.PictureBox7 = New System.Windows.Forms.PictureBox()
        Me.PictureBox6 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.GroupBox1.SuspendLayout()
        Me.grpVoucher.SuspendLayout()
        CType(Me.numUsageLimit, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.grpProduct.SuspendLayout()
        CType(Me.numDiscountValue, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ErrorProvider2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ErrorProvider3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ErrorProvider4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ErrorProvider5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ErrorProvider6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnClear)
        Me.GroupBox1.Controls.Add(Me.btnCancel)
        Me.GroupBox1.Controls.Add(Me.btnSavePromotion)
        Me.GroupBox1.Controls.Add(Me.grpVoucher)
        Me.GroupBox1.Controls.Add(Me.GroupBox4)
        Me.GroupBox1.Controls.Add(Me.GroupBox3)
        Me.GroupBox1.Controls.Add(Me.GroupBox2)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.dtpEndDate)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.dtpStartDate)
        Me.GroupBox1.Controls.Add(Me.txtPromoName)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(105, 207)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(1237, 706)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "***Promotion***"
        '
        'btnClear
        '
        Me.btnClear.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(36, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.btnClear.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.btnClear.Location = New System.Drawing.Point(844, 626)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(151, 38)
        Me.btnClear.TabIndex = 18
        Me.btnClear.Text = "&Clear"
        Me.btnClear.UseVisualStyleBackColor = False
        '
        'btnCancel
        '
        Me.btnCancel.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(36, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.btnCancel.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancel.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.btnCancel.Location = New System.Drawing.Point(670, 626)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(151, 38)
        Me.btnCancel.TabIndex = 17
        Me.btnCancel.Text = "&Cancel"
        Me.btnCancel.UseVisualStyleBackColor = False
        '
        'btnSavePromotion
        '
        Me.btnSavePromotion.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(36, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.btnSavePromotion.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnSavePromotion.Location = New System.Drawing.Point(1011, 626)
        Me.btnSavePromotion.Name = "btnSavePromotion"
        Me.btnSavePromotion.Size = New System.Drawing.Size(220, 38)
        Me.btnSavePromotion.TabIndex = 16
        Me.btnSavePromotion.Text = "Save promotion"
        Me.btnSavePromotion.UseVisualStyleBackColor = False
        '
        'grpVoucher
        '
        Me.grpVoucher.Controls.Add(Me.PictureBox1)
        Me.grpVoucher.Controls.Add(Me.btnRandomGenerate)
        Me.grpVoucher.Controls.Add(Me.txtVoucherCode)
        Me.grpVoucher.Controls.Add(Me.numUsageLimit)
        Me.grpVoucher.Controls.Add(Me.Label7)
        Me.grpVoucher.Controls.Add(Me.Label8)
        Me.grpVoucher.Location = New System.Drawing.Point(52, 435)
        Me.grpVoucher.Name = "grpVoucher"
        Me.grpVoucher.Size = New System.Drawing.Size(664, 166)
        Me.grpVoucher.TabIndex = 13
        Me.grpVoucher.TabStop = False
        Me.grpVoucher.Text = "Voucher Details"
        Me.grpVoucher.Visible = False
        '
        'btnRandomGenerate
        '
        Me.btnRandomGenerate.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRandomGenerate.Location = New System.Drawing.Point(223, 122)
        Me.btnRandomGenerate.Name = "btnRandomGenerate"
        Me.btnRandomGenerate.Size = New System.Drawing.Size(151, 38)
        Me.btnRandomGenerate.TabIndex = 18
        Me.btnRandomGenerate.Text = "Random Generate"
        Me.btnRandomGenerate.UseVisualStyleBackColor = True
        '
        'txtVoucherCode
        '
        Me.txtVoucherCode.Location = New System.Drawing.Point(27, 85)
        Me.txtVoucherCode.Name = "txtVoucherCode"
        Me.txtVoucherCode.Size = New System.Drawing.Size(347, 31)
        Me.txtVoucherCode.TabIndex = 13
        '
        'numUsageLimit
        '
        Me.numUsageLimit.Location = New System.Drawing.Point(478, 91)
        Me.numUsageLimit.Name = "numUsageLimit"
        Me.numUsageLimit.Size = New System.Drawing.Size(120, 31)
        Me.numUsageLimit.TabIndex = 12
        Me.numUsageLimit.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(474, 64)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(125, 25)
        Me.Label7.TabIndex = 9
        Me.Label7.Text = "Usage Limit"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(22, 51)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(145, 25)
        Me.Label8.TabIndex = 7
        Me.Label8.Text = "Voucher code"
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.lblPromoStatus)
        Me.GroupBox4.Location = New System.Drawing.Point(1030, 41)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(165, 106)
        Me.GroupBox4.TabIndex = 15
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = " Status"
        '
        'lblPromoStatus
        '
        Me.lblPromoStatus.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblPromoStatus.Location = New System.Drawing.Point(21, 41)
        Me.lblPromoStatus.Name = "lblPromoStatus"
        Me.lblPromoStatus.Size = New System.Drawing.Size(128, 40)
        Me.lblPromoStatus.TabIndex = 14
        Me.lblPromoStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.PictureBox2)
        Me.GroupBox3.Controls.Add(Me.radStartLater)
        Me.GroupBox3.Controls.Add(Me.radStartNow)
        Me.GroupBox3.Location = New System.Drawing.Point(355, 30)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(343, 119)
        Me.GroupBox3.TabIndex = 10
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Schedule Promotions"
        '
        'radStartLater
        '
        Me.radStartLater.AutoSize = True
        Me.radStartLater.Location = New System.Drawing.Point(25, 71)
        Me.radStartLater.Name = "radStartLater"
        Me.radStartLater.Size = New System.Drawing.Size(186, 29)
        Me.radStartLater.TabIndex = 9
        Me.radStartLater.TabStop = True
        Me.radStartLater.Tag = ""
        Me.radStartLater.Text = "Schedule a date"
        Me.radStartLater.UseVisualStyleBackColor = True
        '
        'radStartNow
        '
        Me.radStartNow.AutoSize = True
        Me.radStartNow.Location = New System.Drawing.Point(25, 37)
        Me.radStartNow.Name = "radStartNow"
        Me.radStartNow.Size = New System.Drawing.Size(213, 29)
        Me.radStartNow.TabIndex = 8
        Me.radStartNow.TabStop = True
        Me.radStartNow.Tag = ""
        Me.radStartNow.Text = "Start Immediatetely"
        Me.radStartNow.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.PictureBox3)
        Me.GroupBox2.Controls.Add(Me.grpProduct)
        Me.GroupBox2.Controls.Add(Me.numDiscountValue)
        Me.GroupBox2.Controls.Add(Me.lblDiscountValue)
        Me.GroupBox2.Controls.Add(Me.cboDiscountType)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.cboPromotionType)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Location = New System.Drawing.Point(24, 165)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(1207, 250)
        Me.GroupBox2.TabIndex = 6
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Promotion details"
        '
        'grpProduct
        '
        Me.grpProduct.Controls.Add(Me.btnCalculate)
        Me.grpProduct.Controls.Add(Me.lblPriceAfterDiscount)
        Me.grpProduct.Controls.Add(Me.Label13)
        Me.grpProduct.Controls.Add(Me.Label12)
        Me.grpProduct.Controls.Add(Me.lblProductPrice)
        Me.grpProduct.Controls.Add(Me.lblProductID)
        Me.grpProduct.Controls.Add(Me.Label6)
        Me.grpProduct.Controls.Add(Me.cboProduct)
        Me.grpProduct.Controls.Add(Me.Label10)
        Me.grpProduct.Location = New System.Drawing.Point(463, 30)
        Me.grpProduct.Name = "grpProduct"
        Me.grpProduct.Size = New System.Drawing.Size(708, 195)
        Me.grpProduct.TabIndex = 15
        Me.grpProduct.TabStop = False
        Me.grpProduct.Text = "Applies to "
        Me.grpProduct.Visible = False
        '
        'btnCalculate
        '
        Me.btnCalculate.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(36, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.btnCalculate.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnCalculate.Location = New System.Drawing.Point(17, 135)
        Me.btnCalculate.Name = "btnCalculate"
        Me.btnCalculate.Size = New System.Drawing.Size(202, 46)
        Me.btnCalculate.TabIndex = 27
        Me.btnCalculate.Text = "Calculate Discount"
        Me.btnCalculate.UseVisualStyleBackColor = False
        '
        'lblPriceAfterDiscount
        '
        Me.lblPriceAfterDiscount.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.lblPriceAfterDiscount.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblPriceAfterDiscount.Location = New System.Drawing.Point(512, 102)
        Me.lblPriceAfterDiscount.Name = "lblPriceAfterDiscount"
        Me.lblPriceAfterDiscount.Size = New System.Drawing.Size(171, 36)
        Me.lblPriceAfterDiscount.TabIndex = 26
        Me.lblPriceAfterDiscount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label13
        '
        Me.Label13.Location = New System.Drawing.Point(497, 65)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(205, 25)
        Me.Label13.TabIndex = 25
        Me.Label13.Text = "Price after discount*"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(6, 31)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(148, 25)
        Me.Label12.TabIndex = 24
        Me.Label12.Text = "Product Name"
        '
        'lblProductPrice
        '
        Me.lblProductPrice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblProductPrice.Location = New System.Drawing.Point(240, 140)
        Me.lblProductPrice.Name = "lblProductPrice"
        Me.lblProductPrice.Size = New System.Drawing.Size(240, 36)
        Me.lblProductPrice.TabIndex = 22
        Me.lblProductPrice.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblProductID
        '
        Me.lblProductID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblProductID.Location = New System.Drawing.Point(240, 65)
        Me.lblProductID.Name = "lblProductID"
        Me.lblProductID.Size = New System.Drawing.Size(240, 36)
        Me.lblProductID.TabIndex = 21
        Me.lblProductID.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(236, 30)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(112, 25)
        Me.Label6.TabIndex = 21
        Me.Label6.Text = "Product ID"
        '
        'cboProduct
        '
        Me.cboProduct.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboProduct.FormattingEnabled = True
        Me.cboProduct.Items.AddRange(New Object() {"Percentage", "Fixed Amount"})
        Me.cboProduct.Location = New System.Drawing.Point(11, 62)
        Me.cboProduct.Name = "cboProduct"
        Me.cboProduct.Size = New System.Drawing.Size(208, 33)
        Me.cboProduct.TabIndex = 14
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(235, 113)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(218, 25)
        Me.Label10.TabIndex = 23
        Me.Label10.Text = "Product Current Price"
        '
        'numDiscountValue
        '
        Me.numDiscountValue.Location = New System.Drawing.Point(245, 119)
        Me.numDiscountValue.Name = "numDiscountValue"
        Me.numDiscountValue.Size = New System.Drawing.Size(152, 31)
        Me.numDiscountValue.TabIndex = 12
        Me.numDiscountValue.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblDiscountValue
        '
        Me.lblDiscountValue.AutoSize = True
        Me.lblDiscountValue.Location = New System.Drawing.Point(241, 89)
        Me.lblDiscountValue.Name = "lblDiscountValue"
        Me.lblDiscountValue.Size = New System.Drawing.Size(157, 25)
        Me.lblDiscountValue.TabIndex = 11
        Me.lblDiscountValue.Text = "Discount Value"
        '
        'cboDiscountType
        '
        Me.cboDiscountType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboDiscountType.FormattingEnabled = True
        Me.cboDiscountType.Items.AddRange(New Object() {"Percentage", "Fixed Amount"})
        Me.cboDiscountType.Location = New System.Drawing.Point(27, 143)
        Me.cboDiscountType.Name = "cboDiscountType"
        Me.cboDiscountType.Size = New System.Drawing.Size(208, 33)
        Me.cboDiscountType.TabIndex = 10
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(23, 116)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(150, 25)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Discount Type"
        '
        'cboPromotionType
        '
        Me.cboPromotionType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboPromotionType.FormattingEnabled = True
        Me.cboPromotionType.Items.AddRange(New Object() {"Product", "Voucher"})
        Me.cboPromotionType.Location = New System.Drawing.Point(27, 69)
        Me.cboPromotionType.Name = "cboPromotionType"
        Me.cboPromotionType.Size = New System.Drawing.Size(208, 33)
        Me.cboPromotionType.TabIndex = 8
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(23, 42)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(163, 25)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Promotion Type"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(723, 90)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(98, 25)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "End date"
        '
        'dtpEndDate
        '
        Me.dtpEndDate.Location = New System.Drawing.Point(737, 116)
        Me.dtpEndDate.Name = "dtpEndDate"
        Me.dtpEndDate.Size = New System.Drawing.Size(258, 31)
        Me.dtpEndDate.TabIndex = 4
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(723, 26)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(105, 25)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Start date"
        '
        'dtpStartDate
        '
        Me.dtpStartDate.Location = New System.Drawing.Point(737, 53)
        Me.dtpStartDate.Name = "dtpStartDate"
        Me.dtpStartDate.Size = New System.Drawing.Size(258, 31)
        Me.dtpStartDate.TabIndex = 2
        '
        'txtPromoName
        '
        Me.txtPromoName.Location = New System.Drawing.Point(10, 65)
        Me.txtPromoName.Name = "txtPromoName"
        Me.txtPromoName.Size = New System.Drawing.Size(325, 31)
        Me.txtPromoName.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 38)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(168, 25)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Promotion name"
        '
        'Label11
        '
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(139, 161)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(260, 34)
        Me.Label11.TabIndex = 34
        Me.Label11.Text = "Add Promotion"
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.ContainerControl = Me
        '
        'ErrorProvider2
        '
        Me.ErrorProvider2.ContainerControl = Me
        '
        'ErrorProvider3
        '
        Me.ErrorProvider3.ContainerControl = Me
        '
        'ErrorProvider4
        '
        Me.ErrorProvider4.ContainerControl = Me
        '
        'ErrorProvider5
        '
        Me.ErrorProvider5.ContainerControl = Me
        '
        'ErrorProvider6
        '
        Me.ErrorProvider6.ContainerControl = Me
        '
        'PictureBox7
        '
        Me.PictureBox7.Image = Global.CustomerManagement.My.Resources.Resources.promotionPIC
        Me.PictureBox7.Location = New System.Drawing.Point(474, 95)
        Me.PictureBox7.Name = "PictureBox7"
        Me.PictureBox7.Size = New System.Drawing.Size(507, 113)
        Me.PictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox7.TabIndex = 36
        Me.PictureBox7.TabStop = False
        '
        'PictureBox6
        '
        Me.PictureBox6.Image = Global.CustomerManagement.My.Resources.Resources.addpromotion
        Me.PictureBox6.Location = New System.Drawing.Point(51, 129)
        Me.PictureBox6.Name = "PictureBox6"
        Me.PictureBox6.Size = New System.Drawing.Size(85, 72)
        Me.PictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox6.TabIndex = 35
        Me.PictureBox6.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.CustomerManagement.My.Resources.Resources.promo_code
        Me.PictureBox1.Location = New System.Drawing.Point(173, 28)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(72, 48)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 21
        Me.PictureBox1.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = Global.CustomerManagement.My.Resources.Resources.schedule
        Me.PictureBox2.Location = New System.Drawing.Point(265, 5)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(72, 52)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 19
        Me.PictureBox2.TabStop = False
        '
        'PictureBox3
        '
        Me.PictureBox3.Image = Global.CustomerManagement.My.Resources.Resources.discount
        Me.PictureBox3.Location = New System.Drawing.Point(345, 37)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(53, 49)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox3.TabIndex = 20
        Me.PictureBox3.TabStop = False
        '
        'addPromotion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1454, 971)
        Me.Controls.Add(Me.PictureBox7)
        Me.Controls.Add(Me.PictureBox6)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "addPromotion"
        Me.Text = "CreatePromotion"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.grpVoucher.ResumeLayout(False)
        Me.grpVoucher.PerformLayout()
        CType(Me.numUsageLimit, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.grpProduct.ResumeLayout(False)
        Me.grpProduct.PerformLayout()
        CType(Me.numDiscountValue, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ErrorProvider2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ErrorProvider3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ErrorProvider4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ErrorProvider5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ErrorProvider6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents txtPromoName As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents dtpEndDate As DateTimePicker
    Friend WithEvents Label2 As Label
    Friend WithEvents dtpStartDate As DateTimePicker
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents lblDiscountValue As Label
    Friend WithEvents cboDiscountType As ComboBox
    Friend WithEvents Label5 As Label
    Friend WithEvents cboPromotionType As ComboBox
    Friend WithEvents Label4 As Label
    Friend WithEvents numDiscountValue As NumericUpDown
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents radStartLater As RadioButton
    Friend WithEvents radStartNow As RadioButton
    Friend WithEvents lblPromoStatus As Label
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents grpVoucher As GroupBox
    Friend WithEvents txtVoucherCode As TextBox
    Friend WithEvents numUsageLimit As NumericUpDown
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents btnCancel As Button
    Friend WithEvents btnSavePromotion As Button
    Friend WithEvents grpProduct As GroupBox
    Friend WithEvents cboProduct As ComboBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents Label6 As Label
    Friend WithEvents lblProductID As Label
    Friend WithEvents btnRandomGenerate As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents lblProductPrice As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents PictureBox6 As PictureBox
    Friend WithEvents Label11 As Label
    Friend WithEvents lblPriceAfterDiscount As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents ErrorProvider1 As ErrorProvider
    Friend WithEvents ErrorProvider2 As ErrorProvider
    Friend WithEvents ErrorProvider3 As ErrorProvider
    Friend WithEvents ErrorProvider4 As ErrorProvider
    Friend WithEvents ErrorProvider5 As ErrorProvider
    Friend WithEvents ErrorProvider6 As ErrorProvider
    Friend WithEvents PictureBox7 As PictureBox
    Friend WithEvents btnClear As Button
    Friend WithEvents btnCalculate As Button
End Class
