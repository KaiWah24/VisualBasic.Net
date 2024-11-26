<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmPayment
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnPayByEWallet = New System.Windows.Forms.Button()
        Me.btnPayByMasterCard = New System.Windows.Forms.Button()
        Me.btnPayByVisa = New System.Windows.Forms.Button()
        Me.btnPayByCash = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblTtlCash = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lblChange = New System.Windows.Forms.Label()
        Me.pnlCash = New System.Windows.Forms.Panel()
        Me.btnCalculate = New System.Windows.Forms.Button()
        Me.btnCashCancel = New System.Windows.Forms.Button()
        Me.btnCashCompleted = New System.Windows.Forms.Button()
        Me.rtfTendered = New System.Windows.Forms.RichTextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.lblCashPaymentType = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.pnlVisa = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblTtlVisa = New System.Windows.Forms.Label()
        Me.btnVisaExit = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.lblVisaCardType = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.mskVisaHolderName = New System.Windows.Forms.MaskedTextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.mskVisaExpiry = New System.Windows.Forms.MaskedTextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.mskVisaCVV = New System.Windows.Forms.MaskedTextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.mskVisaCardNumber = New System.Windows.Forms.MaskedTextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.btnVisaCompleted = New System.Windows.Forms.Button()
        Me.pnlMasterCard = New System.Windows.Forms.Panel()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lblTtlMasterCard = New System.Windows.Forms.Label()
        Me.btnMasterExit = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.lblMasterCardType = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.mskMasterHolderName = New System.Windows.Forms.MaskedTextBox()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.mskMasterExpiry = New System.Windows.Forms.MaskedTextBox()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.mskMasterCVV = New System.Windows.Forms.MaskedTextBox()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.mskMasterCardNumber = New System.Windows.Forms.MaskedTextBox()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.btnMasterCardCompleted = New System.Windows.Forms.Button()
        Me.pnlEWallet = New System.Windows.Forms.Panel()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.Button10 = New System.Windows.Forms.Button()
        Me.btnEWalletCompleted = New System.Windows.Forms.Button()
        Me.lblTtlEWallet = New System.Windows.Forms.Label()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.picQrCode = New System.Windows.Forms.PictureBox()
        Me.docReceipt = New System.Drawing.Printing.PrintDocument()
        Me.dlgPreview = New System.Windows.Forms.PrintDialog()
        Me.Panel1.SuspendLayout()
        Me.pnlCash.SuspendLayout()
        Me.pnlVisa.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.pnlMasterCard.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.pnlEWallet.SuspendLayout()
        CType(Me.picQrCode, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.ControlDark
        Me.Panel1.Controls.Add(Me.btnPayByEWallet)
        Me.Panel1.Controls.Add(Me.btnPayByMasterCard)
        Me.Panel1.Controls.Add(Me.btnPayByVisa)
        Me.Panel1.Controls.Add(Me.btnPayByCash)
        Me.Panel1.Location = New System.Drawing.Point(1, 3)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(152, 690)
        Me.Panel1.TabIndex = 1
        '
        'btnPayByEWallet
        '
        Me.btnPayByEWallet.BackgroundImage = My.Resources.Resources.qr_code_scan
        Me.btnPayByEWallet.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnPayByEWallet.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPayByEWallet.Location = New System.Drawing.Point(11, 515)
        Me.btnPayByEWallet.Name = "btnPayByEWallet"
        Me.btnPayByEWallet.Size = New System.Drawing.Size(124, 172)
        Me.btnPayByEWallet.TabIndex = 3
        Me.btnPayByEWallet.Text = "E-Wallet (F4)"
        Me.btnPayByEWallet.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnPayByEWallet.UseVisualStyleBackColor = True
        '
        'btnPayByMasterCard
        '
        Me.btnPayByMasterCard.BackgroundImage = My.Resources.Resources.card
        Me.btnPayByMasterCard.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnPayByMasterCard.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPayByMasterCard.Location = New System.Drawing.Point(11, 345)
        Me.btnPayByMasterCard.Name = "btnPayByMasterCard"
        Me.btnPayByMasterCard.Size = New System.Drawing.Size(124, 164)
        Me.btnPayByMasterCard.TabIndex = 2
        Me.btnPayByMasterCard.Text = "Mastercard (F3)"
        Me.btnPayByMasterCard.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnPayByMasterCard.UseVisualStyleBackColor = True
        '
        'btnPayByVisa
        '
        Me.btnPayByVisa.BackgroundImage = My.Resources.Resources.visa
        Me.btnPayByVisa.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnPayByVisa.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPayByVisa.Location = New System.Drawing.Point(11, 159)
        Me.btnPayByVisa.Name = "btnPayByVisa"
        Me.btnPayByVisa.Size = New System.Drawing.Size(124, 180)
        Me.btnPayByVisa.TabIndex = 1
        Me.btnPayByVisa.Text = "Visa (F2)"
        Me.btnPayByVisa.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnPayByVisa.UseVisualStyleBackColor = True
        '
        'btnPayByCash
        '
        Me.btnPayByCash.BackgroundImage = My.Resources.Resources.dollar
        Me.btnPayByCash.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnPayByCash.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPayByCash.Location = New System.Drawing.Point(11, 15)
        Me.btnPayByCash.Name = "btnPayByCash"
        Me.btnPayByCash.Size = New System.Drawing.Size(124, 129)
        Me.btnPayByCash.TabIndex = 0
        Me.btnPayByCash.Text = "Cash (F1)"
        Me.btnPayByCash.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnPayByCash.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 25.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(60, 41)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(183, 82)
        Me.Label2.TabIndex = 24
        Me.Label2.Text = "TOTAL"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblTtlCash
        '
        Me.lblTtlCash.BackColor = System.Drawing.Color.FromArgb(CType(CType(123, Byte), Integer), CType(CType(36, Byte), Integer), CType(CType(6, Byte), Integer))
        Me.lblTtlCash.Font = New System.Drawing.Font("Digital-7", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTtlCash.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(212, Byte), Integer))
        Me.lblTtlCash.Location = New System.Drawing.Point(260, 43)
        Me.lblTtlCash.Name = "lblTtlCash"
        Me.lblTtlCash.Size = New System.Drawing.Size(417, 80)
        Me.lblTtlCash.TabIndex = 25
        Me.lblTtlCash.Text = "0.00"
        Me.lblTtlCash.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 25.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(51, 455)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(194, 82)
        Me.Label3.TabIndex = 26
        Me.Label3.Text = "Change"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblChange
        '
        Me.lblChange.BackColor = System.Drawing.Color.Black
        Me.lblChange.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblChange.Font = New System.Drawing.Font("Digital-7", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblChange.ForeColor = System.Drawing.Color.White
        Me.lblChange.Location = New System.Drawing.Point(260, 455)
        Me.lblChange.Name = "lblChange"
        Me.lblChange.Size = New System.Drawing.Size(428, 82)
        Me.lblChange.TabIndex = 27
        Me.lblChange.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'pnlCash
        '
        Me.pnlCash.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.pnlCash.Controls.Add(Me.btnCalculate)
        Me.pnlCash.Controls.Add(Me.btnCashCancel)
        Me.pnlCash.Controls.Add(Me.btnCashCompleted)
        Me.pnlCash.Controls.Add(Me.rtfTendered)
        Me.pnlCash.Controls.Add(Me.Label6)
        Me.pnlCash.Controls.Add(Me.lblCashPaymentType)
        Me.pnlCash.Controls.Add(Me.Label5)
        Me.pnlCash.Controls.Add(Me.lblTtlCash)
        Me.pnlCash.Controls.Add(Me.Label3)
        Me.pnlCash.Controls.Add(Me.lblChange)
        Me.pnlCash.Controls.Add(Me.Label2)
        Me.pnlCash.Location = New System.Drawing.Point(154, 4)
        Me.pnlCash.Name = "pnlCash"
        Me.pnlCash.Size = New System.Drawing.Size(746, 690)
        Me.pnlCash.TabIndex = 28
        '
        'btnCalculate
        '
        Me.btnCalculate.BackColor = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(217, Byte), Integer), CType(CType(231, Byte), Integer))
        Me.btnCalculate.FlatAppearance.BorderColor = System.Drawing.SystemColors.MenuHighlight
        Me.btnCalculate.FlatAppearance.BorderSize = 0
        Me.btnCalculate.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnCalculate.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCalculate.ForeColor = System.Drawing.SystemColors.Desktop
        Me.btnCalculate.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCalculate.Location = New System.Drawing.Point(378, 356)
        Me.btnCalculate.Margin = New System.Windows.Forms.Padding(4)
        Me.btnCalculate.Name = "btnCalculate"
        Me.btnCalculate.Size = New System.Drawing.Size(148, 58)
        Me.btnCalculate.TabIndex = 59
        Me.btnCalculate.Text = "CALCULATE"
        Me.btnCalculate.UseVisualStyleBackColor = False
        '
        'btnCashCancel
        '
        Me.btnCashCancel.BackColor = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(217, Byte), Integer), CType(CType(231, Byte), Integer))
        Me.btnCashCancel.FlatAppearance.BorderColor = System.Drawing.SystemColors.MenuHighlight
        Me.btnCashCancel.FlatAppearance.BorderSize = 0
        Me.btnCashCancel.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnCashCancel.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCashCancel.ForeColor = System.Drawing.Color.Black
        Me.btnCashCancel.Location = New System.Drawing.Point(476, 593)
        Me.btnCashCancel.Margin = New System.Windows.Forms.Padding(4)
        Me.btnCashCancel.Name = "btnCashCancel"
        Me.btnCashCancel.Size = New System.Drawing.Size(169, 58)
        Me.btnCashCancel.TabIndex = 58
        Me.btnCashCancel.Text = "ABORT"
        Me.btnCashCancel.UseVisualStyleBackColor = False
        '
        'btnCashCompleted
        '
        Me.btnCashCompleted.BackColor = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(217, Byte), Integer), CType(CType(231, Byte), Integer))
        Me.btnCashCompleted.FlatAppearance.BorderColor = System.Drawing.SystemColors.MenuHighlight
        Me.btnCashCompleted.FlatAppearance.BorderSize = 0
        Me.btnCashCompleted.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnCashCompleted.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCashCompleted.ForeColor = System.Drawing.Color.Black
        Me.btnCashCompleted.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCashCompleted.Location = New System.Drawing.Point(73, 593)
        Me.btnCashCompleted.Margin = New System.Windows.Forms.Padding(4)
        Me.btnCashCompleted.Name = "btnCashCompleted"
        Me.btnCashCompleted.Size = New System.Drawing.Size(169, 58)
        Me.btnCashCompleted.TabIndex = 57
        Me.btnCashCompleted.Text = "COMPLETED"
        Me.btnCashCompleted.UseVisualStyleBackColor = False
        '
        'rtfTendered
        '
        Me.rtfTendered.AcceptsTab = True
        Me.rtfTendered.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rtfTendered.Location = New System.Drawing.Point(260, 255)
        Me.rtfTendered.Name = "rtfTendered"
        Me.rtfTendered.Size = New System.Drawing.Size(417, 63)
        Me.rtfTendered.TabIndex = 56
        Me.rtfTendered.Text = ""
        '
        'Label6
        '
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(54, 268)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(166, 34)
        Me.Label6.TabIndex = 31
        Me.Label6.Text = "TENDERED"
        '
        'lblCashPaymentType
        '
        Me.lblCashPaymentType.BackColor = System.Drawing.Color.Silver
        Me.lblCashPaymentType.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblCashPaymentType.Enabled = False
        Me.lblCashPaymentType.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCashPaymentType.Location = New System.Drawing.Point(314, 159)
        Me.lblCashPaymentType.Name = "lblCashPaymentType"
        Me.lblCashPaymentType.Size = New System.Drawing.Size(331, 61)
        Me.lblCashPaymentType.TabIndex = 30
        Me.lblCashPaymentType.Text = "CASH"
        Me.lblCashPaymentType.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label5
        '
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(15, 167)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(262, 40)
        Me.Label5.TabIndex = 29
        Me.Label5.Text = "PAYMENT MODE"
        '
        'pnlVisa
        '
        Me.pnlVisa.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.pnlVisa.Controls.Add(Me.Label1)
        Me.pnlVisa.Controls.Add(Me.lblTtlVisa)
        Me.pnlVisa.Controls.Add(Me.btnVisaExit)
        Me.pnlVisa.Controls.Add(Me.GroupBox1)
        Me.pnlVisa.Controls.Add(Me.btnVisaCompleted)
        Me.pnlVisa.Location = New System.Drawing.Point(156, 3)
        Me.pnlVisa.Name = "pnlVisa"
        Me.pnlVisa.Size = New System.Drawing.Size(746, 690)
        Me.pnlVisa.TabIndex = 59
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 25.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(51, 43)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(183, 82)
        Me.Label1.TabIndex = 60
        Me.Label1.Text = "TOTAL"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblTtlVisa
        '
        Me.lblTtlVisa.BackColor = System.Drawing.Color.FromArgb(CType(CType(123, Byte), Integer), CType(CType(36, Byte), Integer), CType(CType(6, Byte), Integer))
        Me.lblTtlVisa.Font = New System.Drawing.Font("Digital-7", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTtlVisa.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(212, Byte), Integer))
        Me.lblTtlVisa.Location = New System.Drawing.Point(267, 43)
        Me.lblTtlVisa.Name = "lblTtlVisa"
        Me.lblTtlVisa.Size = New System.Drawing.Size(417, 80)
        Me.lblTtlVisa.TabIndex = 69
        Me.lblTtlVisa.Text = "0.00"
        Me.lblTtlVisa.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'btnVisaExit
        '
        Me.btnVisaExit.BackColor = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(217, Byte), Integer), CType(CType(231, Byte), Integer))
        Me.btnVisaExit.FlatAppearance.BorderColor = System.Drawing.SystemColors.MenuHighlight
        Me.btnVisaExit.FlatAppearance.BorderSize = 0
        Me.btnVisaExit.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnVisaExit.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnVisaExit.ForeColor = System.Drawing.SystemColors.Desktop
        Me.btnVisaExit.Location = New System.Drawing.Point(515, 567)
        Me.btnVisaExit.Margin = New System.Windows.Forms.Padding(4)
        Me.btnVisaExit.Name = "btnVisaExit"
        Me.btnVisaExit.Size = New System.Drawing.Size(169, 58)
        Me.btnVisaExit.TabIndex = 60
        Me.btnVisaExit.Text = "ABORT"
        Me.btnVisaExit.UseVisualStyleBackColor = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.lblVisaCardType)
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Controls.Add(Me.mskVisaHolderName)
        Me.GroupBox1.Controls.Add(Me.Label14)
        Me.GroupBox1.Controls.Add(Me.mskVisaExpiry)
        Me.GroupBox1.Controls.Add(Me.Label13)
        Me.GroupBox1.Controls.Add(Me.mskVisaCVV)
        Me.GroupBox1.Controls.Add(Me.Label12)
        Me.GroupBox1.Controls.Add(Me.mskVisaCardNumber)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(35, 145)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(649, 293)
        Me.GroupBox1.TabIndex = 67
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Card details"
        '
        'lblVisaCardType
        '
        Me.lblVisaCardType.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.lblVisaCardType.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblVisaCardType.Enabled = False
        Me.lblVisaCardType.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblVisaCardType.Location = New System.Drawing.Point(248, 62)
        Me.lblVisaCardType.Name = "lblVisaCardType"
        Me.lblVisaCardType.Size = New System.Drawing.Size(268, 36)
        Me.lblVisaCardType.TabIndex = 59
        Me.lblVisaCardType.Text = "Visa"
        Me.lblVisaCardType.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(135, 73)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(88, 17)
        Me.Label11.TabIndex = 68
        Me.Label11.Text = "Card type :"
        '
        'mskVisaHolderName
        '
        Me.mskVisaHolderName.Location = New System.Drawing.Point(248, 199)
        Me.mskVisaHolderName.Name = "mskVisaHolderName"
        Me.mskVisaHolderName.Size = New System.Drawing.Size(310, 23)
        Me.mskVisaHolderName.TabIndex = 67
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(90, 202)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(119, 17)
        Me.Label14.TabIndex = 61
        Me.Label14.Text = "Name on card :"
        '
        'mskVisaExpiry
        '
        Me.mskVisaExpiry.Location = New System.Drawing.Point(248, 159)
        Me.mskVisaExpiry.Mask = "00/00"
        Me.mskVisaExpiry.Name = "mskVisaExpiry"
        Me.mskVisaExpiry.Size = New System.Drawing.Size(153, 23)
        Me.mskVisaExpiry.TabIndex = 66
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(99, 123)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(111, 17)
        Me.Label13.TabIndex = 59
        Me.Label13.Text = "Card number :"
        '
        'mskVisaCVV
        '
        Me.mskVisaCVV.Location = New System.Drawing.Point(501, 160)
        Me.mskVisaCVV.Mask = "000"
        Me.mskVisaCVV.Name = "mskVisaCVV"
        Me.mskVisaCVV.Size = New System.Drawing.Size(57, 23)
        Me.mskVisaCVV.TabIndex = 65
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(155, 160)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(62, 17)
        Me.Label12.TabIndex = 60
        Me.Label12.Text = "Expiry :"
        '
        'mskVisaCardNumber
        '
        Me.mskVisaCardNumber.Location = New System.Drawing.Point(248, 120)
        Me.mskVisaCardNumber.Mask = "0000-0000-0000-0000"
        Me.mskVisaCardNumber.Name = "mskVisaCardNumber"
        Me.mskVisaCardNumber.Size = New System.Drawing.Size(310, 23)
        Me.mskVisaCardNumber.TabIndex = 64
        Me.mskVisaCardNumber.ValidatingType = GetType(Integer)
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(431, 160)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(53, 17)
        Me.Label7.TabIndex = 63
        Me.Label7.Text = "CVV : "
        '
        'btnVisaCompleted
        '
        Me.btnVisaCompleted.BackColor = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(217, Byte), Integer), CType(CType(231, Byte), Integer))
        Me.btnVisaCompleted.FlatAppearance.BorderColor = System.Drawing.SystemColors.MenuHighlight
        Me.btnVisaCompleted.FlatAppearance.BorderSize = 0
        Me.btnVisaCompleted.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnVisaCompleted.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnVisaCompleted.ForeColor = System.Drawing.SystemColors.Desktop
        Me.btnVisaCompleted.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnVisaCompleted.Location = New System.Drawing.Point(65, 567)
        Me.btnVisaCompleted.Margin = New System.Windows.Forms.Padding(4)
        Me.btnVisaCompleted.Name = "btnVisaCompleted"
        Me.btnVisaCompleted.Size = New System.Drawing.Size(169, 58)
        Me.btnVisaCompleted.TabIndex = 59
        Me.btnVisaCompleted.Text = "COMPLETED"
        Me.btnVisaCompleted.UseVisualStyleBackColor = False
        '
        'pnlMasterCard
        '
        Me.pnlMasterCard.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.pnlMasterCard.Controls.Add(Me.Label4)
        Me.pnlMasterCard.Controls.Add(Me.lblTtlMasterCard)
        Me.pnlMasterCard.Controls.Add(Me.btnMasterExit)
        Me.pnlMasterCard.Controls.Add(Me.GroupBox2)
        Me.pnlMasterCard.Controls.Add(Me.btnMasterCardCompleted)
        Me.pnlMasterCard.Location = New System.Drawing.Point(155, 0)
        Me.pnlMasterCard.Name = "pnlMasterCard"
        Me.pnlMasterCard.Size = New System.Drawing.Size(746, 690)
        Me.pnlMasterCard.TabIndex = 70
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 25.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(51, 46)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(183, 82)
        Me.Label4.TabIndex = 70
        Me.Label4.Text = "TOTAL"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblTtlMasterCard
        '
        Me.lblTtlMasterCard.BackColor = System.Drawing.Color.FromArgb(CType(CType(123, Byte), Integer), CType(CType(36, Byte), Integer), CType(CType(6, Byte), Integer))
        Me.lblTtlMasterCard.Font = New System.Drawing.Font("Digital-7", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTtlMasterCard.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(212, Byte), Integer))
        Me.lblTtlMasterCard.Location = New System.Drawing.Point(267, 43)
        Me.lblTtlMasterCard.Name = "lblTtlMasterCard"
        Me.lblTtlMasterCard.Size = New System.Drawing.Size(417, 80)
        Me.lblTtlMasterCard.TabIndex = 69
        Me.lblTtlMasterCard.Text = "0.00"
        Me.lblTtlMasterCard.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'btnMasterExit
        '
        Me.btnMasterExit.BackColor = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(217, Byte), Integer), CType(CType(231, Byte), Integer))
        Me.btnMasterExit.FlatAppearance.BorderColor = System.Drawing.SystemColors.MenuHighlight
        Me.btnMasterExit.FlatAppearance.BorderSize = 0
        Me.btnMasterExit.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnMasterExit.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMasterExit.ForeColor = System.Drawing.SystemColors.Desktop
        Me.btnMasterExit.Location = New System.Drawing.Point(495, 563)
        Me.btnMasterExit.Margin = New System.Windows.Forms.Padding(4)
        Me.btnMasterExit.Name = "btnMasterExit"
        Me.btnMasterExit.Size = New System.Drawing.Size(169, 58)
        Me.btnMasterExit.TabIndex = 60
        Me.btnMasterExit.Text = "ABORT"
        Me.btnMasterExit.UseVisualStyleBackColor = False
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.lblMasterCardType)
        Me.GroupBox2.Controls.Add(Me.Label18)
        Me.GroupBox2.Controls.Add(Me.mskMasterHolderName)
        Me.GroupBox2.Controls.Add(Me.Label19)
        Me.GroupBox2.Controls.Add(Me.mskMasterExpiry)
        Me.GroupBox2.Controls.Add(Me.Label20)
        Me.GroupBox2.Controls.Add(Me.mskMasterCVV)
        Me.GroupBox2.Controls.Add(Me.Label21)
        Me.GroupBox2.Controls.Add(Me.mskMasterCardNumber)
        Me.GroupBox2.Controls.Add(Me.Label22)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(35, 145)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(649, 293)
        Me.GroupBox2.TabIndex = 67
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Card details"
        '
        'lblMasterCardType
        '
        Me.lblMasterCardType.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.lblMasterCardType.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblMasterCardType.Enabled = False
        Me.lblMasterCardType.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMasterCardType.Location = New System.Drawing.Point(248, 62)
        Me.lblMasterCardType.Name = "lblMasterCardType"
        Me.lblMasterCardType.Size = New System.Drawing.Size(268, 36)
        Me.lblMasterCardType.TabIndex = 59
        Me.lblMasterCardType.Text = "MasterCard"
        Me.lblMasterCardType.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.Location = New System.Drawing.Point(135, 73)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(88, 17)
        Me.Label18.TabIndex = 68
        Me.Label18.Text = "Card type :"
        '
        'mskMasterHolderName
        '
        Me.mskMasterHolderName.Location = New System.Drawing.Point(248, 199)
        Me.mskMasterHolderName.Name = "mskMasterHolderName"
        Me.mskMasterHolderName.Size = New System.Drawing.Size(310, 23)
        Me.mskMasterHolderName.TabIndex = 67
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.Location = New System.Drawing.Point(90, 202)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(119, 17)
        Me.Label19.TabIndex = 61
        Me.Label19.Text = "Name on card :"
        '
        'mskMasterExpiry
        '
        Me.mskMasterExpiry.Location = New System.Drawing.Point(248, 159)
        Me.mskMasterExpiry.Mask = "00/00"
        Me.mskMasterExpiry.Name = "mskMasterExpiry"
        Me.mskMasterExpiry.Size = New System.Drawing.Size(153, 23)
        Me.mskMasterExpiry.TabIndex = 66
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.Location = New System.Drawing.Point(99, 123)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(111, 17)
        Me.Label20.TabIndex = 59
        Me.Label20.Text = "Card number :"
        '
        'mskMasterCVV
        '
        Me.mskMasterCVV.Location = New System.Drawing.Point(501, 160)
        Me.mskMasterCVV.Mask = "000"
        Me.mskMasterCVV.Name = "mskMasterCVV"
        Me.mskMasterCVV.Size = New System.Drawing.Size(57, 23)
        Me.mskMasterCVV.TabIndex = 65
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.Location = New System.Drawing.Point(155, 160)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(62, 17)
        Me.Label21.TabIndex = 60
        Me.Label21.Text = "Expiry :"
        '
        'mskMasterCardNumber
        '
        Me.mskMasterCardNumber.Location = New System.Drawing.Point(248, 120)
        Me.mskMasterCardNumber.Mask = "0000-0000-0000-0000"
        Me.mskMasterCardNumber.Name = "mskMasterCardNumber"
        Me.mskMasterCardNumber.Size = New System.Drawing.Size(310, 23)
        Me.mskMasterCardNumber.TabIndex = 64
        Me.mskMasterCardNumber.ValidatingType = GetType(Integer)
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label22.Location = New System.Drawing.Point(431, 160)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(53, 17)
        Me.Label22.TabIndex = 63
        Me.Label22.Text = "CVV : "
        '
        'btnMasterCardCompleted
        '
        Me.btnMasterCardCompleted.BackColor = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(217, Byte), Integer), CType(CType(231, Byte), Integer))
        Me.btnMasterCardCompleted.FlatAppearance.BorderColor = System.Drawing.SystemColors.MenuHighlight
        Me.btnMasterCardCompleted.FlatAppearance.BorderSize = 0
        Me.btnMasterCardCompleted.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnMasterCardCompleted.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMasterCardCompleted.ForeColor = System.Drawing.SystemColors.Desktop
        Me.btnMasterCardCompleted.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnMasterCardCompleted.Location = New System.Drawing.Point(45, 563)
        Me.btnMasterCardCompleted.Margin = New System.Windows.Forms.Padding(4)
        Me.btnMasterCardCompleted.Name = "btnMasterCardCompleted"
        Me.btnMasterCardCompleted.Size = New System.Drawing.Size(169, 58)
        Me.btnMasterCardCompleted.TabIndex = 59
        Me.btnMasterCardCompleted.Text = "COMPLETED"
        Me.btnMasterCardCompleted.UseVisualStyleBackColor = False
        '
        'pnlEWallet
        '
        Me.pnlEWallet.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.pnlEWallet.Controls.Add(Me.Label23)
        Me.pnlEWallet.Controls.Add(Me.Button10)
        Me.pnlEWallet.Controls.Add(Me.btnEWalletCompleted)
        Me.pnlEWallet.Controls.Add(Me.lblTtlEWallet)
        Me.pnlEWallet.Controls.Add(Me.Label24)
        Me.pnlEWallet.Controls.Add(Me.picQrCode)
        Me.pnlEWallet.Location = New System.Drawing.Point(153, 2)
        Me.pnlEWallet.Name = "pnlEWallet"
        Me.pnlEWallet.Size = New System.Drawing.Size(746, 690)
        Me.pnlEWallet.TabIndex = 70
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label23.Location = New System.Drawing.Point(351, 437)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(65, 17)
        Me.Label23.TabIndex = 71
        Me.Label23.Text = "Duitnow"
        '
        'Button10
        '
        Me.Button10.BackColor = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(217, Byte), Integer), CType(CType(231, Byte), Integer))
        Me.Button10.FlatAppearance.BorderColor = System.Drawing.SystemColors.MenuHighlight
        Me.Button10.FlatAppearance.BorderSize = 0
        Me.Button10.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button10.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button10.ForeColor = System.Drawing.SystemColors.Desktop
        Me.Button10.Location = New System.Drawing.Point(498, 596)
        Me.Button10.Margin = New System.Windows.Forms.Padding(4)
        Me.Button10.Name = "Button10"
        Me.Button10.Size = New System.Drawing.Size(169, 58)
        Me.Button10.TabIndex = 60
        Me.Button10.Text = "ABORT"
        Me.Button10.UseVisualStyleBackColor = False
        '
        'btnEWalletCompleted
        '
        Me.btnEWalletCompleted.BackColor = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(217, Byte), Integer), CType(CType(231, Byte), Integer))
        Me.btnEWalletCompleted.FlatAppearance.BorderColor = System.Drawing.SystemColors.MenuHighlight
        Me.btnEWalletCompleted.FlatAppearance.BorderSize = 0
        Me.btnEWalletCompleted.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnEWalletCompleted.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEWalletCompleted.ForeColor = System.Drawing.SystemColors.Desktop
        Me.btnEWalletCompleted.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnEWalletCompleted.Location = New System.Drawing.Point(97, 596)
        Me.btnEWalletCompleted.Margin = New System.Windows.Forms.Padding(4)
        Me.btnEWalletCompleted.Name = "btnEWalletCompleted"
        Me.btnEWalletCompleted.Size = New System.Drawing.Size(169, 58)
        Me.btnEWalletCompleted.TabIndex = 59
        Me.btnEWalletCompleted.Text = "COMPLETED"
        Me.btnEWalletCompleted.UseVisualStyleBackColor = False
        '
        'lblTtlEWallet
        '
        Me.lblTtlEWallet.BackColor = System.Drawing.Color.FromArgb(CType(CType(123, Byte), Integer), CType(CType(36, Byte), Integer), CType(CType(6, Byte), Integer))
        Me.lblTtlEWallet.Font = New System.Drawing.Font("Digital-7", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTtlEWallet.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(212, Byte), Integer))
        Me.lblTtlEWallet.Location = New System.Drawing.Point(262, 40)
        Me.lblTtlEWallet.Name = "lblTtlEWallet"
        Me.lblTtlEWallet.Size = New System.Drawing.Size(417, 80)
        Me.lblTtlEWallet.TabIndex = 60
        Me.lblTtlEWallet.Text = "0.00"
        Me.lblTtlEWallet.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label24
        '
        Me.Label24.Font = New System.Drawing.Font("Microsoft Sans Serif", 25.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label24.Location = New System.Drawing.Point(38, 40)
        Me.Label24.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(183, 82)
        Me.Label24.TabIndex = 59
        Me.Label24.Text = "Total"
        Me.Label24.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'picQrCode
        '
        Me.picQrCode.BackColor = System.Drawing.Color.White
        Me.picQrCode.Location = New System.Drawing.Point(242, 159)
        Me.picQrCode.Name = "picQrCode"
        Me.picQrCode.Size = New System.Drawing.Size(288, 251)
        Me.picQrCode.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picQrCode.TabIndex = 39
        Me.picQrCode.TabStop = False
        '
        'docReceipt
        '
        Me.docReceipt.OriginAtMargins = True
        '
        'dlgPreview
        '
        Me.dlgPreview.UseEXDialog = True
        '
        'frmPayment
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(902, 697)
        Me.Controls.Add(Me.pnlMasterCard)
        Me.Controls.Add(Me.pnlEWallet)
        Me.Controls.Add(Me.pnlCash)
        Me.Controls.Add(Me.pnlVisa)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "frmPayment"
        Me.Text = "Payment"
        Me.Panel1.ResumeLayout(False)
        Me.pnlCash.ResumeLayout(False)
        Me.pnlVisa.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.pnlMasterCard.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.pnlEWallet.ResumeLayout(False)
        Me.pnlEWallet.PerformLayout()
        CType(Me.picQrCode, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnPayByCash As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents btnPayByMasterCard As Button
    Friend WithEvents btnPayByVisa As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents lblTtlCash As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents lblChange As Label
    Friend WithEvents btnPayByEWallet As Button
    Friend WithEvents pnlCash As Panel
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents lblCashPaymentType As Label
    Friend WithEvents rtfTendered As RichTextBox
    Friend WithEvents btnCashCancel As Button
    Friend WithEvents btnCashCompleted As Button
    Friend WithEvents pnlVisa As Panel
    Friend WithEvents mskVisaExpiry As MaskedTextBox
    Friend WithEvents mskVisaCVV As MaskedTextBox
    Friend WithEvents mskVisaCardNumber As MaskedTextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents mskVisaHolderName As MaskedTextBox
    Friend WithEvents lblTtlVisa As Label
    Friend WithEvents btnVisaExit As Button
    Friend WithEvents btnVisaCompleted As Button
    Friend WithEvents lblVisaCardType As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents pnlMasterCard As Panel
    Friend WithEvents lblTtlMasterCard As Label
    Friend WithEvents btnMasterExit As Button
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents lblMasterCardType As Label
    Friend WithEvents Label18 As Label
    Friend WithEvents mskMasterHolderName As MaskedTextBox
    Friend WithEvents Label19 As Label
    Friend WithEvents mskMasterExpiry As MaskedTextBox
    Friend WithEvents Label20 As Label
    Friend WithEvents mskMasterCVV As MaskedTextBox
    Friend WithEvents Label21 As Label
    Friend WithEvents mskMasterCardNumber As MaskedTextBox
    Friend WithEvents Label22 As Label
    Friend WithEvents btnMasterCardCompleted As Button
    Friend WithEvents pnlEWallet As Panel
    Friend WithEvents picQrCode As PictureBox
    Friend WithEvents lblTtlEWallet As Label
    Friend WithEvents Label24 As Label
    Friend WithEvents Button10 As Button
    Friend WithEvents btnEWalletCompleted As Button
    Friend WithEvents Label23 As Label
    Friend WithEvents btnCalculate As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents docReceipt As Printing.PrintDocument
    Friend WithEvents dlgPreview As PrintDialog
End Class
