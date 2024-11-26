<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmSales
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmSales))
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle10 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.timerCurrent = New System.Windows.Forms.Timer(Me.components)
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lblCurrentSalesOrder = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.rtfSalesOrder = New System.Windows.Forms.RichTextBox()
        Me.btnSearchSalesOrder = New System.Windows.Forms.Button()
        Me.btnRemoveSelected = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnReduceQty = New System.Windows.Forms.Button()
        Me.btnAddQty = New System.Windows.Forms.Button()
        Me.lblPointsRedeemed = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.lblRounding = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.lblDiscount = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnRefundSelected = New System.Windows.Forms.Button()
        Me.chkRounding = New System.Windows.Forms.CheckBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.lblSubTotal = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblTtlPrice = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.colItemCode = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colItemDesc = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colQTY = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colPriceBefTax = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colPercent = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colPriceAftTax = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colTotal = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.rtfVoucher = New System.Windows.Forms.RichTextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.btnLogout = New System.Windows.Forms.Button()
        Me.lblCurrentTime = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnSearchVoucher = New System.Windows.Forms.Button()
        Me.btnCustomer = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnVoid = New System.Windows.Forms.Button()
        Me.btnSearchBarCode = New System.Windows.Forms.Button()
        Me.Panel15 = New System.Windows.Forms.Panel()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.chkRedeemPoint = New System.Windows.Forms.CheckBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.lblConvertedToCash = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.lblLoyaltyPoint = New System.Windows.Forms.Label()
        Me.lblCustomerName = New System.Windows.Forms.Label()
        Me.lblCustomerStatus = New System.Windows.Forms.Label()
        Me.label = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.btnPayment = New System.Windows.Forms.Button()
        Me.rtfBarcode = New System.Windows.Forms.RichTextBox()
        Me.MyApplicationBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Panel2.SuspendLayout()
        Me.Panel4.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.Panel15.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.MyApplicationBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'timerCurrent
        '
        '
        'Panel2
        '
        Me.Panel2.AutoScroll = True
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(215, Byte), Integer), CType(CType(217, Byte), Integer), CType(CType(219, Byte), Integer))
        Me.Panel2.Controls.Add(Me.Panel4)
        Me.Panel2.Controls.Add(Me.btnRemoveSelected)
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Controls.Add(Me.btnReduceQty)
        Me.Panel2.Controls.Add(Me.btnAddQty)
        Me.Panel2.Controls.Add(Me.lblPointsRedeemed)
        Me.Panel2.Controls.Add(Me.Label9)
        Me.Panel2.Controls.Add(Me.lblRounding)
        Me.Panel2.Controls.Add(Me.Label6)
        Me.Panel2.Controls.Add(Me.lblDiscount)
        Me.Panel2.Controls.Add(Me.Label3)
        Me.Panel2.Controls.Add(Me.btnRefundSelected)
        Me.Panel2.Controls.Add(Me.chkRounding)
        Me.Panel2.Controls.Add(Me.Label11)
        Me.Panel2.Controls.Add(Me.lblSubTotal)
        Me.Panel2.Controls.Add(Me.Label7)
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Controls.Add(Me.lblTtlPrice)
        Me.Panel2.Controls.Add(Me.DataGridView1)
        Me.Panel2.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel2.Location = New System.Drawing.Point(145, 265)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1952, 898)
        Me.Panel2.TabIndex = 0
        Me.Panel2.TabStop = True
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.FromArgb(CType(CType(23, Byte), Integer), CType(CType(36, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.Panel4.Controls.Add(Me.Label4)
        Me.Panel4.Controls.Add(Me.lblCurrentSalesOrder)
        Me.Panel4.Controls.Add(Me.Label8)
        Me.Panel4.Controls.Add(Me.rtfSalesOrder)
        Me.Panel4.Controls.Add(Me.btnSearchSalesOrder)
        Me.Panel4.Location = New System.Drawing.Point(21, 414)
        Me.Panel4.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(764, 235)
        Me.Panel4.TabIndex = 64
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(16, 130)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(217, 25)
        Me.Label4.TabIndex = 60
        Me.Label4.Text = "Sales Order"
        '
        'lblCurrentSalesOrder
        '
        Me.lblCurrentSalesOrder.BackColor = System.Drawing.Color.Silver
        Me.lblCurrentSalesOrder.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblCurrentSalesOrder.Enabled = False
        Me.lblCurrentSalesOrder.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCurrentSalesOrder.Location = New System.Drawing.Point(21, 65)
        Me.lblCurrentSalesOrder.Name = "lblCurrentSalesOrder"
        Me.lblCurrentSalesOrder.Size = New System.Drawing.Size(297, 30)
        Me.lblCurrentSalesOrder.TabIndex = 36
        Me.lblCurrentSalesOrder.Text = "N/A"
        Me.lblCurrentSalesOrder.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label8
        '
        Me.Label8.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(16, 22)
        Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(217, 25)
        Me.Label8.TabIndex = 63
        Me.Label8.Text = "Current sales order"
        '
        'rtfSalesOrder
        '
        Me.rtfSalesOrder.AcceptsTab = True
        Me.rtfSalesOrder.Location = New System.Drawing.Point(21, 170)
        Me.rtfSalesOrder.Multiline = False
        Me.rtfSalesOrder.Name = "rtfSalesOrder"
        Me.rtfSalesOrder.Size = New System.Drawing.Size(323, 35)
        Me.rtfSalesOrder.TabIndex = 0
        Me.rtfSalesOrder.Text = ""
        '
        'btnSearchSalesOrder
        '
        Me.btnSearchSalesOrder.BackgroundImage = CType(resources.GetObject("btnSearchSalesOrder.BackgroundImage"), System.Drawing.Image)
        Me.btnSearchSalesOrder.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnSearchSalesOrder.Location = New System.Drawing.Point(350, 169)
        Me.btnSearchSalesOrder.Name = "btnSearchSalesOrder"
        Me.btnSearchSalesOrder.Size = New System.Drawing.Size(39, 36)
        Me.btnSearchSalesOrder.TabIndex = 56
        Me.btnSearchSalesOrder.UseVisualStyleBackColor = True
        '
        'btnRemoveSelected
        '
        Me.btnRemoveSelected.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.btnRemoveSelected.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnRemoveSelected.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRemoveSelected.ForeColor = System.Drawing.Color.Black
        Me.btnRemoveSelected.Location = New System.Drawing.Point(1433, 109)
        Me.btnRemoveSelected.Name = "btnRemoveSelected"
        Me.btnRemoveSelected.Size = New System.Drawing.Size(90, 74)
        Me.btnRemoveSelected.TabIndex = 69
        Me.btnRemoveSelected.Text = "Remove selected item"
        Me.btnRemoveSelected.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(987, 504)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(196, 39)
        Me.Label1.TabIndex = 68
        Me.Label1.Text = "Points used (RM)"
        '
        'btnReduceQty
        '
        Me.btnReduceQty.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnReduceQty.ForeColor = System.Drawing.Color.White
        Me.btnReduceQty.Location = New System.Drawing.Point(1433, 296)
        Me.btnReduceQty.Name = "btnReduceQty"
        Me.btnReduceQty.Size = New System.Drawing.Size(90, 62)
        Me.btnReduceQty.TabIndex = 67
        Me.btnReduceQty.Text = "QTY (-)"
        Me.btnReduceQty.UseVisualStyleBackColor = False
        '
        'btnAddQty
        '
        Me.btnAddQty.BackColor = System.Drawing.Color.DarkGreen
        Me.btnAddQty.ForeColor = System.Drawing.Color.White
        Me.btnAddQty.Location = New System.Drawing.Point(1433, 206)
        Me.btnAddQty.Name = "btnAddQty"
        Me.btnAddQty.Size = New System.Drawing.Size(90, 66)
        Me.btnAddQty.TabIndex = 66
        Me.btnAddQty.Text = "QTY (+)"
        Me.btnAddQty.UseVisualStyleBackColor = False
        '
        'lblPointsRedeemed
        '
        Me.lblPointsRedeemed.BackColor = System.Drawing.Color.Silver
        Me.lblPointsRedeemed.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblPointsRedeemed.Enabled = False
        Me.lblPointsRedeemed.Font = New System.Drawing.Font("Digital-7", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPointsRedeemed.Location = New System.Drawing.Point(1211, 504)
        Me.lblPointsRedeemed.Name = "lblPointsRedeemed"
        Me.lblPointsRedeemed.Size = New System.Drawing.Size(222, 39)
        Me.lblPointsRedeemed.TabIndex = 65
        Me.lblPointsRedeemed.Text = "0.00"
        Me.lblPointsRedeemed.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label9
        '
        Me.Label9.BackColor = System.Drawing.Color.Black
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(1099, 617)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(400, 2)
        Me.Label9.TabIndex = 63
        '
        'lblRounding
        '
        Me.lblRounding.BackColor = System.Drawing.Color.Silver
        Me.lblRounding.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblRounding.Enabled = False
        Me.lblRounding.Font = New System.Drawing.Font("Digital-7", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRounding.Location = New System.Drawing.Point(1211, 558)
        Me.lblRounding.Name = "lblRounding"
        Me.lblRounding.Size = New System.Drawing.Size(222, 33)
        Me.lblRounding.TabIndex = 62
        Me.lblRounding.Text = "0.00"
        Me.lblRounding.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label6
        '
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(1056, 558)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(110, 26)
        Me.Label6.TabIndex = 61
        Me.Label6.Text = "Rounding"
        '
        'lblDiscount
        '
        Me.lblDiscount.BackColor = System.Drawing.Color.Silver
        Me.lblDiscount.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblDiscount.Enabled = False
        Me.lblDiscount.Font = New System.Drawing.Font("Digital-7", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDiscount.Location = New System.Drawing.Point(1211, 452)
        Me.lblDiscount.Name = "lblDiscount"
        Me.lblDiscount.Size = New System.Drawing.Size(222, 39)
        Me.lblDiscount.TabIndex = 60
        Me.lblDiscount.Text = "0.00"
        Me.lblDiscount.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(1056, 451)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(97, 27)
        Me.Label3.TabIndex = 59
        Me.Label3.Text = "Discount"
        '
        'btnRefundSelected
        '
        Me.btnRefundSelected.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.btnRefundSelected.Enabled = False
        Me.btnRefundSelected.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRefundSelected.ForeColor = System.Drawing.Color.Black
        Me.btnRefundSelected.Location = New System.Drawing.Point(1433, 13)
        Me.btnRefundSelected.Name = "btnRefundSelected"
        Me.btnRefundSelected.Size = New System.Drawing.Size(90, 74)
        Me.btnRefundSelected.TabIndex = 58
        Me.btnRefundSelected.Text = "Refund selected item"
        Me.btnRefundSelected.UseVisualStyleBackColor = False
        '
        'chkRounding
        '
        Me.chkRounding.Checked = True
        Me.chkRounding.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkRounding.Location = New System.Drawing.Point(949, 569)
        Me.chkRounding.Name = "chkRounding"
        Me.chkRounding.Size = New System.Drawing.Size(21, 18)
        Me.chkRounding.TabIndex = 57
        Me.chkRounding.UseVisualStyleBackColor = True
        '
        'Label11
        '
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(817, 562)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(126, 29)
        Me.Label11.TabIndex = 26
        Me.Label11.Text = "Rounding"
        '
        'lblSubTotal
        '
        Me.lblSubTotal.BackColor = System.Drawing.Color.Silver
        Me.lblSubTotal.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblSubTotal.Enabled = False
        Me.lblSubTotal.Font = New System.Drawing.Font("Digital-7", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSubTotal.Location = New System.Drawing.Point(1211, 398)
        Me.lblSubTotal.Name = "lblSubTotal"
        Me.lblSubTotal.Size = New System.Drawing.Size(222, 42)
        Me.lblSubTotal.TabIndex = 25
        Me.lblSubTotal.Text = "0.00"
        Me.lblSubTotal.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label7
        '
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(1002, 398)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(181, 25)
        Me.Label7.TabIndex = 24
        Me.Label7.Text = "Sub-Total (RM)"
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 25.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(940, 636)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(234, 64)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Total (RM)"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblTtlPrice
        '
        Me.lblTtlPrice.BackColor = System.Drawing.Color.FromArgb(CType(CType(123, Byte), Integer), CType(CType(36, Byte), Integer), CType(CType(6, Byte), Integer))
        Me.lblTtlPrice.Font = New System.Drawing.Font("Digital-7", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTtlPrice.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(212, Byte), Integer))
        Me.lblTtlPrice.Location = New System.Drawing.Point(1212, 636)
        Me.lblTtlPrice.Name = "lblTtlPrice"
        Me.lblTtlPrice.Size = New System.Drawing.Size(221, 64)
        Me.lblTtlPrice.TabIndex = 23
        Me.lblTtlPrice.Text = "0.00"
        Me.lblTtlPrice.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AllowUserToResizeColumns = False
        Me.DataGridView1.AllowUserToResizeRows = False
        DataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.DataGridView1.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle6
        Me.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridView1.BackgroundColor = System.Drawing.SystemColors.ActiveCaption
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.ActiveCaption
        DataGridViewCellStyle7.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption
        DataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle7
        Me.DataGridView1.ColumnHeadersHeight = 29
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colItemCode, Me.colItemDesc, Me.colQTY, Me.colPriceBefTax, Me.colPercent, Me.colPriceAftTax, Me.colTotal})
        Me.DataGridView1.EnableHeadersVisualStyles = False
        Me.DataGridView1.GridColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.DataGridView1.Location = New System.Drawing.Point(0, 0)
        Me.DataGridView1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        DataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle9.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.ControlDark
        DataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView1.RowHeadersDefaultCellStyle = DataGridViewCellStyle9
        Me.DataGridView1.RowHeadersWidth = 51
        DataGridViewCellStyle10.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle10.SelectionForeColor = System.Drawing.Color.Black
        Me.DataGridView1.RowsDefaultCellStyle = DataGridViewCellStyle10
        Me.DataGridView1.RowTemplate.DividerHeight = 1
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.DataGridView1.Size = New System.Drawing.Size(1427, 386)
        Me.DataGridView1.TabIndex = 22
        '
        'colItemCode
        '
        Me.colItemCode.HeaderText = "Item Code"
        Me.colItemCode.MinimumWidth = 6
        Me.colItemCode.Name = "colItemCode"
        Me.colItemCode.ReadOnly = True
        '
        'colItemDesc
        '
        Me.colItemDesc.HeaderText = "Item Description"
        Me.colItemDesc.MinimumWidth = 6
        Me.colItemDesc.Name = "colItemDesc"
        Me.colItemDesc.ReadOnly = True
        '
        'colQTY
        '
        Me.colQTY.HeaderText = "QTY"
        Me.colQTY.MinimumWidth = 6
        Me.colQTY.Name = "colQTY"
        Me.colQTY.ReadOnly = True
        '
        'colPriceBefTax
        '
        DataGridViewCellStyle8.Format = "C2"
        DataGridViewCellStyle8.NullValue = Nothing
        Me.colPriceBefTax.DefaultCellStyle = DataGridViewCellStyle8
        Me.colPriceBefTax.HeaderText = "Price before tax"
        Me.colPriceBefTax.MinimumWidth = 6
        Me.colPriceBefTax.Name = "colPriceBefTax"
        Me.colPriceBefTax.ReadOnly = True
        '
        'colPercent
        '
        Me.colPercent.HeaderText = "TAX %"
        Me.colPercent.MinimumWidth = 6
        Me.colPercent.Name = "colPercent"
        Me.colPercent.ReadOnly = True
        '
        'colPriceAftTax
        '
        Me.colPriceAftTax.HeaderText = "Price after tax"
        Me.colPriceAftTax.MinimumWidth = 6
        Me.colPriceAftTax.Name = "colPriceAftTax"
        Me.colPriceAftTax.ReadOnly = True
        '
        'colTotal
        '
        Me.colTotal.HeaderText = "Total"
        Me.colTotal.MinimumWidth = 6
        Me.colTotal.Name = "colTotal"
        Me.colTotal.ReadOnly = True
        '
        'rtfVoucher
        '
        Me.rtfVoucher.AcceptsTab = True
        Me.rtfVoucher.Location = New System.Drawing.Point(1255, 186)
        Me.rtfVoucher.Multiline = False
        Me.rtfVoucher.Name = "rtfVoucher"
        Me.rtfVoucher.Size = New System.Drawing.Size(323, 35)
        Me.rtfVoucher.TabIndex = 1
        Me.rtfVoucher.Text = ""
        '
        'Label13
        '
        Me.Label13.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(1250, 151)
        Me.Label13.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(217, 25)
        Me.Label13.TabIndex = 63
        Me.Label13.Text = "Voucher"
        '
        'btnLogout
        '
        Me.btnLogout.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnLogout.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLogout.ForeColor = System.Drawing.Color.White
        Me.btnLogout.Location = New System.Drawing.Point(1487, 9)
        Me.btnLogout.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnLogout.Name = "btnLogout"
        Me.btnLogout.Size = New System.Drawing.Size(163, 30)
        Me.btnLogout.TabIndex = 37
        Me.btnLogout.Text = "BACK TO HOME"
        Me.btnLogout.UseVisualStyleBackColor = False
        '
        'lblCurrentTime
        '
        Me.lblCurrentTime.BackColor = System.Drawing.Color.Transparent
        Me.lblCurrentTime.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCurrentTime.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lblCurrentTime.Location = New System.Drawing.Point(15, 11)
        Me.lblCurrentTime.Name = "lblCurrentTime"
        Me.lblCurrentTime.Size = New System.Drawing.Size(507, 28)
        Me.lblCurrentTime.TabIndex = 13
        Me.lblCurrentTime.Text = "Current time"
        Me.lblCurrentTime.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(36, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.Panel1.Controls.Add(Me.btnSearchVoucher)
        Me.Panel1.Controls.Add(Me.rtfVoucher)
        Me.Panel1.Controls.Add(Me.btnCustomer)
        Me.Panel1.Controls.Add(Me.Label13)
        Me.Panel1.Controls.Add(Me.btnClear)
        Me.Panel1.Controls.Add(Me.btnVoid)
        Me.Panel1.Controls.Add(Me.btnSearchBarCode)
        Me.Panel1.Controls.Add(Me.Panel15)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.btnPayment)
        Me.Panel1.Controls.Add(Me.rtfBarcode)
        Me.Panel1.Controls.Add(Me.lblCurrentTime)
        Me.Panel1.Controls.Add(Me.btnLogout)
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Location = New System.Drawing.Point(0, -1)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(2100, 1270)
        Me.Panel1.TabIndex = 0
        '
        'btnSearchVoucher
        '
        Me.btnSearchVoucher.BackgroundImage = CType(resources.GetObject("btnSearchVoucher.BackgroundImage"), System.Drawing.Image)
        Me.btnSearchVoucher.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnSearchVoucher.Location = New System.Drawing.Point(1585, 185)
        Me.btnSearchVoucher.Name = "btnSearchVoucher"
        Me.btnSearchVoucher.Size = New System.Drawing.Size(39, 36)
        Me.btnSearchVoucher.TabIndex = 62
        Me.btnSearchVoucher.UseVisualStyleBackColor = True
        '
        'btnCustomer
        '
        Me.btnCustomer.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.btnCustomer.BackgroundImage = CType(resources.GetObject("btnCustomer.BackgroundImage"), System.Drawing.Image)
        Me.btnCustomer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnCustomer.FlatAppearance.BorderColor = System.Drawing.Color.Yellow
        Me.btnCustomer.FlatAppearance.BorderSize = 5
        Me.btnCustomer.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCustomer.ForeColor = System.Drawing.Color.Black
        Me.btnCustomer.Location = New System.Drawing.Point(19, 56)
        Me.btnCustomer.Name = "btnCustomer"
        Me.btnCustomer.Size = New System.Drawing.Size(108, 188)
        Me.btnCustomer.TabIndex = 59
        Me.btnCustomer.Text = "Customer"
        Me.btnCustomer.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnCustomer.UseVisualStyleBackColor = False
        '
        'btnClear
        '
        Me.btnClear.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.btnClear.BackgroundImage = CType(resources.GetObject("btnClear.BackgroundImage"), System.Drawing.Image)
        Me.btnClear.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnClear.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btnClear.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClear.ForeColor = System.Drawing.Color.Black
        Me.btnClear.Location = New System.Drawing.Point(19, 484)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(108, 192)
        Me.btnClear.TabIndex = 58
        Me.btnClear.Text = "Clear"
        Me.btnClear.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnClear.UseVisualStyleBackColor = False
        '
        'btnVoid
        '
        Me.btnVoid.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.btnVoid.BackgroundImage = CType(resources.GetObject("btnVoid.BackgroundImage"), System.Drawing.Image)
        Me.btnVoid.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnVoid.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btnVoid.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnVoid.ForeColor = System.Drawing.Color.Black
        Me.btnVoid.Location = New System.Drawing.Point(19, 265)
        Me.btnVoid.Name = "btnVoid"
        Me.btnVoid.Size = New System.Drawing.Size(108, 192)
        Me.btnVoid.TabIndex = 57
        Me.btnVoid.Text = "Void"
        Me.btnVoid.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnVoid.UseVisualStyleBackColor = False
        '
        'btnSearchBarCode
        '
        Me.btnSearchBarCode.BackgroundImage = CType(resources.GetObject("btnSearchBarCode.BackgroundImage"), System.Drawing.Image)
        Me.btnSearchBarCode.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnSearchBarCode.Location = New System.Drawing.Point(1585, 92)
        Me.btnSearchBarCode.Name = "btnSearchBarCode"
        Me.btnSearchBarCode.Size = New System.Drawing.Size(39, 34)
        Me.btnSearchBarCode.TabIndex = 54
        Me.btnSearchBarCode.UseVisualStyleBackColor = True
        '
        'Panel15
        '
        Me.Panel15.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Panel15.Controls.Add(Me.Label12)
        Me.Panel15.Controls.Add(Me.GroupBox1)
        Me.Panel15.Location = New System.Drawing.Point(145, 56)
        Me.Panel15.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel15.Name = "Panel15"
        Me.Panel15.Size = New System.Drawing.Size(1082, 196)
        Me.Panel15.TabIndex = 40
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(16, 9)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(181, 20)
        Me.Label12.TabIndex = 29
        Me.Label12.Text = "Customer information"
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(36, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.GroupBox1.Controls.Add(Me.chkRedeemPoint)
        Me.GroupBox1.Controls.Add(Me.Label14)
        Me.GroupBox1.Controls.Add(Me.lblConvertedToCash)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.lblLoyaltyPoint)
        Me.GroupBox1.Controls.Add(Me.lblCustomerName)
        Me.GroupBox1.Controls.Add(Me.lblCustomerStatus)
        Me.GroupBox1.Controls.Add(Me.label)
        Me.GroupBox1.Controls.Add(Me.Label18)
        Me.GroupBox1.Controls.Add(Me.Label19)
        Me.GroupBox1.Location = New System.Drawing.Point(21, 36)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Size = New System.Drawing.Size(1046, 135)
        Me.GroupBox1.TabIndex = 3
        Me.GroupBox1.TabStop = False
        '
        'chkRedeemPoint
        '
        Me.chkRedeemPoint.AutoSize = True
        Me.chkRedeemPoint.Location = New System.Drawing.Point(707, 33)
        Me.chkRedeemPoint.Name = "chkRedeemPoint"
        Me.chkRedeemPoint.Size = New System.Drawing.Size(15, 14)
        Me.chkRedeemPoint.TabIndex = 35
        Me.chkRedeemPoint.UseVisualStyleBackColor = True
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.Color.White
        Me.Label14.Location = New System.Drawing.Point(554, 29)
        Me.Label14.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(108, 17)
        Me.Label14.TabIndex = 34
        Me.Label14.Text = "Redeem point"
        '
        'lblConvertedToCash
        '
        Me.lblConvertedToCash.BackColor = System.Drawing.Color.Silver
        Me.lblConvertedToCash.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblConvertedToCash.Enabled = False
        Me.lblConvertedToCash.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblConvertedToCash.Location = New System.Drawing.Point(881, 84)
        Me.lblConvertedToCash.Name = "lblConvertedToCash"
        Me.lblConvertedToCash.Size = New System.Drawing.Size(150, 30)
        Me.lblConvertedToCash.TabIndex = 33
        Me.lblConvertedToCash.Text = "N/A"
        Me.lblConvertedToCash.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label10
        '
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.White
        Me.Label10.Location = New System.Drawing.Point(637, 89)
        Me.Label10.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(241, 30)
        Me.Label10.TabIndex = 32
        Me.Label10.Text = "-> Converted to cash (RM)"
        '
        'lblLoyaltyPoint
        '
        Me.lblLoyaltyPoint.BackColor = System.Drawing.Color.Silver
        Me.lblLoyaltyPoint.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblLoyaltyPoint.Enabled = False
        Me.lblLoyaltyPoint.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLoyaltyPoint.Location = New System.Drawing.Point(467, 84)
        Me.lblLoyaltyPoint.Name = "lblLoyaltyPoint"
        Me.lblLoyaltyPoint.Size = New System.Drawing.Size(147, 30)
        Me.lblLoyaltyPoint.TabIndex = 31
        Me.lblLoyaltyPoint.Text = "N/A"
        Me.lblLoyaltyPoint.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblCustomerName
        '
        Me.lblCustomerName.BackColor = System.Drawing.Color.Silver
        Me.lblCustomerName.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblCustomerName.Enabled = False
        Me.lblCustomerName.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCustomerName.Location = New System.Drawing.Point(116, 25)
        Me.lblCustomerName.Name = "lblCustomerName"
        Me.lblCustomerName.Size = New System.Drawing.Size(377, 30)
        Me.lblCustomerName.TabIndex = 30
        Me.lblCustomerName.Text = "N/A"
        Me.lblCustomerName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblCustomerStatus
        '
        Me.lblCustomerStatus.BackColor = System.Drawing.Color.Silver
        Me.lblCustomerStatus.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblCustomerStatus.Enabled = False
        Me.lblCustomerStatus.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCustomerStatus.Location = New System.Drawing.Point(116, 89)
        Me.lblCustomerStatus.Name = "lblCustomerStatus"
        Me.lblCustomerStatus.Size = New System.Drawing.Size(147, 30)
        Me.lblCustomerStatus.TabIndex = 29
        Me.lblCustomerStatus.Text = "N/A"
        Me.lblCustomerStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'label
        '
        Me.label.AutoSize = True
        Me.label.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label.ForeColor = System.Drawing.Color.White
        Me.label.Location = New System.Drawing.Point(332, 89)
        Me.label.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.label.Name = "label"
        Me.label.Size = New System.Drawing.Size(111, 17)
        Me.label.TabIndex = 4
        Me.label.Text = "Loyalty point :"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.ForeColor = System.Drawing.Color.White
        Me.Label18.Location = New System.Drawing.Point(17, 30)
        Me.Label18.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(59, 17)
        Me.Label18.TabIndex = 1
        Me.Label18.Text = "Name :"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.ForeColor = System.Drawing.Color.White
        Me.Label19.Location = New System.Drawing.Point(17, 89)
        Me.Label19.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(64, 17)
        Me.Label19.TabIndex = 2
        Me.Label19.Text = "Status :"
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(1250, 56)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(217, 25)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Barcode"
        '
        'btnPayment
        '
        Me.btnPayment.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.btnPayment.BackgroundImage = CType(resources.GetObject("btnPayment.BackgroundImage"), System.Drawing.Image)
        Me.btnPayment.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnPayment.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btnPayment.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPayment.ForeColor = System.Drawing.Color.Black
        Me.btnPayment.Location = New System.Drawing.Point(19, 706)
        Me.btnPayment.Name = "btnPayment"
        Me.btnPayment.Size = New System.Drawing.Size(108, 196)
        Me.btnPayment.TabIndex = 44
        Me.btnPayment.Text = "Payment"
        Me.btnPayment.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnPayment.UseVisualStyleBackColor = False
        '
        'rtfBarcode
        '
        Me.rtfBarcode.AcceptsTab = True
        Me.rtfBarcode.Location = New System.Drawing.Point(1255, 92)
        Me.rtfBarcode.Multiline = False
        Me.rtfBarcode.Name = "rtfBarcode"
        Me.rtfBarcode.Size = New System.Drawing.Size(323, 34)
        Me.rtfBarcode.TabIndex = 0
        Me.rtfBarcode.Text = ""
        '
        'MyApplicationBindingSource
        '
        Me.MyApplicationBindingSource.DataSource = GetType(CustomerManagement.My.MyApplication)
        '
        'frmSales
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1672, 1003)
        Me.Controls.Add(Me.Panel1)
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.MaximumSize = New System.Drawing.Size(1690, 1050)
        Me.Name = "frmSales"
        Me.Text = "Sales"
        Me.Panel2.ResumeLayout(False)
        Me.Panel4.ResumeLayout(False)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel15.ResumeLayout(False)
        Me.Panel15.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.MyApplicationBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        timerCurrent.Enabled = True
        Panel1.HorizontalScroll.Maximum = 0
        Panel1.AutoScroll = False
        Panel1.VerticalScroll.Visible = False
        Panel1.AutoScroll = True

        'remove avoid nullPointer
        RemoveHandler DataGridView1.CellValueChanged, AddressOf DataGridView1_CellValueChanged
    End Sub
    Friend WithEvents timerCurrent As Timer
    Friend WithEvents Panel2 As Panel
    Friend WithEvents btnLogout As Button
    Friend WithEvents lblCurrentTime As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents lblTtlPrice As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents btnPayment As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents btnSearchBarCode As Button
    Friend WithEvents btnSearchSalesOrder As Button
    Friend WithEvents rtfSalesOrder As RichTextBox
    Friend WithEvents rtfBarcode As RichTextBox
    Friend WithEvents btnVoid As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents lblSubTotal As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Panel15 As Panel
    Friend WithEvents Label12 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents label As Label
    Friend WithEvents Label18 As Label
    Friend WithEvents Label19 As Label
    Friend WithEvents lblLoyaltyPoint As Label
    Friend WithEvents lblCustomerName As Label
    Friend WithEvents lblCustomerStatus As Label
    Friend WithEvents btnCustomer As Button
    Friend WithEvents chkRounding As CheckBox
    Friend WithEvents btnRefundSelected As Button
    Friend WithEvents lblRounding As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents lblDiscount As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents lblPointsRedeemed As Label
    Friend WithEvents chkRedeemPoint As CheckBox
    Friend WithEvents Label14 As Label
    Friend WithEvents lblConvertedToCash As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents MyApplicationBindingSource As BindingSource
    Friend WithEvents btnReduceQty As Button
    Friend WithEvents btnAddQty As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents rtfVoucher As RichTextBox
    Friend WithEvents btnSearchVoucher As Button
    Friend WithEvents colItemCode As DataGridViewTextBoxColumn
    Friend WithEvents colItemDesc As DataGridViewTextBoxColumn
    Friend WithEvents colQTY As DataGridViewTextBoxColumn
    Friend WithEvents colPriceBefTax As DataGridViewTextBoxColumn
    Friend WithEvents colPercent As DataGridViewTextBoxColumn
    Friend WithEvents colPriceAftTax As DataGridViewTextBoxColumn
    Friend WithEvents colTotal As DataGridViewTextBoxColumn
    Friend WithEvents btnRemoveSelected As Button
    Friend WithEvents Panel4 As Panel
    Friend WithEvents lblCurrentSalesOrder As Label
    Friend WithEvents Label8 As Label
End Class
