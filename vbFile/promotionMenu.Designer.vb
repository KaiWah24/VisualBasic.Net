<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class promotionMenu
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
        Me.CustomerBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CustomerDataSet = New CustomerManagement.CustomerDataSet()
        Me.btnEditPromotion = New System.Windows.Forms.Button()
        Me.btnAddPromotion = New System.Windows.Forms.Button()
        Me.grpCustomer = New System.Windows.Forms.GroupBox()
        Me.btnSearchPromo = New System.Windows.Forms.Button()
        Me.cboSearch = New System.Windows.Forms.ComboBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.btnCustClear = New System.Windows.Forms.Button()
        Me.txtSearhPromo = New System.Windows.Forms.TextBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel8 = New System.Windows.Forms.Panel()
        Me.lblOnGoingCount = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.PictureBox5 = New System.Windows.Forms.PictureBox()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.lblInactiveCount = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.lblPendingCount = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.PictureBox20 = New System.Windows.Forms.PictureBox()
        Me.Panel11 = New System.Windows.Forms.Panel()
        Me.lblTotalPromotion = New System.Windows.Forms.Label()
        Me.Label123 = New System.Windows.Forms.Label()
        Me.PictureBox8 = New System.Windows.Forms.PictureBox()
        Me.dgvPromoMenu = New System.Windows.Forms.DataGridView()
        Me.PromotionBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CustomerDataSet1 = New CustomerManagement.CustomerDataSet1()
        Me.PromotionTableAdapter = New CustomerManagement.CustomerDataSet1TableAdapters.PromotionTableAdapter()
        CType(Me.CustomerBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CustomerDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpCustomer.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.Panel8.SuspendLayout()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel5.SuspendLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel3.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.PictureBox20, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel11.SuspendLayout()
        CType(Me.PictureBox8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvPromoMenu, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PromotionBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CustomerDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'CustomerBindingSource
        '
        Me.CustomerBindingSource.DataMember = "Customer"
        Me.CustomerBindingSource.DataSource = Me.CustomerDataSet
        '
        'CustomerDataSet
        '
        Me.CustomerDataSet.DataSetName = "CustomerDataSet"
        Me.CustomerDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'btnEditPromotion
        '
        Me.btnEditPromotion.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(36, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.btnEditPromotion.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEditPromotion.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnEditPromotion.Location = New System.Drawing.Point(269, 83)
        Me.btnEditPromotion.Name = "btnEditPromotion"
        Me.btnEditPromotion.Size = New System.Drawing.Size(124, 33)
        Me.btnEditPromotion.TabIndex = 59
        Me.btnEditPromotion.Text = "&Edit"
        Me.btnEditPromotion.UseVisualStyleBackColor = False
        '
        'btnAddPromotion
        '
        Me.btnAddPromotion.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(36, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.btnAddPromotion.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAddPromotion.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnAddPromotion.Location = New System.Drawing.Point(139, 83)
        Me.btnAddPromotion.Name = "btnAddPromotion"
        Me.btnAddPromotion.Size = New System.Drawing.Size(124, 33)
        Me.btnAddPromotion.TabIndex = 60
        Me.btnAddPromotion.Text = "&Add"
        Me.btnAddPromotion.UseVisualStyleBackColor = False
        '
        'grpCustomer
        '
        Me.grpCustomer.Controls.Add(Me.btnSearchPromo)
        Me.grpCustomer.Controls.Add(Me.cboSearch)
        Me.grpCustomer.Controls.Add(Me.Label9)
        Me.grpCustomer.Controls.Add(Me.btnCustClear)
        Me.grpCustomer.Controls.Add(Me.txtSearhPromo)
        Me.grpCustomer.Font = New System.Drawing.Font("Tahoma", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpCustomer.Location = New System.Drawing.Point(17, 21)
        Me.grpCustomer.Name = "grpCustomer"
        Me.grpCustomer.Size = New System.Drawing.Size(659, 147)
        Me.grpCustomer.TabIndex = 57
        Me.grpCustomer.TabStop = False
        Me.grpCustomer.Text = "Search Promotion"
        '
        'btnSearchPromo
        '
        Me.btnSearchPromo.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(36, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.btnSearchPromo.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSearchPromo.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnSearchPromo.Location = New System.Drawing.Point(392, 99)
        Me.btnSearchPromo.Name = "btnSearchPromo"
        Me.btnSearchPromo.Size = New System.Drawing.Size(124, 33)
        Me.btnSearchPromo.TabIndex = 61
        Me.btnSearchPromo.Text = "&Search"
        Me.btnSearchPromo.UseVisualStyleBackColor = False
        '
        'cboSearch
        '
        Me.cboSearch.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboSearch.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboSearch.FormattingEnabled = True
        Me.cboSearch.Location = New System.Drawing.Point(119, 38)
        Me.cboSearch.Name = "cboSearch"
        Me.cboSearch.Size = New System.Drawing.Size(226, 27)
        Me.cboSearch.TabIndex = 58
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(19, 38)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(94, 19)
        Me.Label9.TabIndex = 56
        Me.Label9.Text = "Search by : "
        '
        'btnCustClear
        '
        Me.btnCustClear.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(36, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.btnCustClear.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCustClear.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnCustClear.Location = New System.Drawing.Point(522, 99)
        Me.btnCustClear.Name = "btnCustClear"
        Me.btnCustClear.Size = New System.Drawing.Size(124, 33)
        Me.btnCustClear.TabIndex = 53
        Me.btnCustClear.Text = "&Clear"
        Me.btnCustClear.UseVisualStyleBackColor = False
        '
        'txtSearhPromo
        '
        Me.txtSearhPromo.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSearhPromo.Location = New System.Drawing.Point(119, 84)
        Me.txtSearhPromo.Multiline = True
        Me.txtSearhPromo.Name = "txtSearhPromo"
        Me.txtSearhPromo.Size = New System.Drawing.Size(226, 27)
        Me.txtSearhPromo.TabIndex = 55
        Me.txtSearhPromo.Text = "Search..."
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Panel1.Controls.Add(Me.Panel8)
        Me.Panel1.Controls.Add(Me.PictureBox4)
        Me.Panel1.Controls.Add(Me.Label12)
        Me.Panel1.Controls.Add(Me.Panel6)
        Me.Panel1.Controls.Add(Me.Panel5)
        Me.Panel1.Controls.Add(Me.Panel3)
        Me.Panel1.Location = New System.Drawing.Point(12, 12)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1480, 286)
        Me.Panel1.TabIndex = 34
        '
        'Panel8
        '
        Me.Panel8.BackColor = System.Drawing.Color.FromArgb(CType(CType(164, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(96, Byte), Integer))
        Me.Panel8.Controls.Add(Me.lblOnGoingCount)
        Me.Panel8.Controls.Add(Me.Label11)
        Me.Panel8.Controls.Add(Me.PictureBox5)
        Me.Panel8.Location = New System.Drawing.Point(71, 117)
        Me.Panel8.Name = "Panel8"
        Me.Panel8.Size = New System.Drawing.Size(262, 134)
        Me.Panel8.TabIndex = 5
        '
        'lblOnGoingCount
        '
        Me.lblOnGoingCount.Font = New System.Drawing.Font("Tahoma", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblOnGoingCount.ForeColor = System.Drawing.Color.White
        Me.lblOnGoingCount.Location = New System.Drawing.Point(207, 38)
        Me.lblOnGoingCount.Name = "lblOnGoingCount"
        Me.lblOnGoingCount.Size = New System.Drawing.Size(55, 37)
        Me.lblOnGoingCount.TabIndex = 4
        Me.lblOnGoingCount.Text = "0"
        '
        'Label11
        '
        Me.Label11.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.White
        Me.Label11.Location = New System.Drawing.Point(86, 86)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(186, 37)
        Me.Label11.TabIndex = 3
        Me.Label11.Text = "On going promotions"
        '
        'PictureBox5
        '
        Me.PictureBox5.Image = Global.CustomerManagement.My.Resources.Resources.ongoing
        Me.PictureBox5.Location = New System.Drawing.Point(20, 38)
        Me.PictureBox5.Name = "PictureBox5"
        Me.PictureBox5.Size = New System.Drawing.Size(60, 60)
        Me.PictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox5.TabIndex = 1
        Me.PictureBox5.TabStop = False
        '
        'PictureBox4
        '
        Me.PictureBox4.Image = Global.CustomerManagement.My.Resources.Resources.promotion_dashboard
        Me.PictureBox4.Location = New System.Drawing.Point(7, 41)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(95, 70)
        Me.PictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox4.TabIndex = 32
        Me.PictureBox4.TabStop = False
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(108, 41)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(267, 29)
        Me.Label12.TabIndex = 31
        Me.Label12.Text = "Promotion Dashboard"
        '
        'Panel6
        '
        Me.Panel6.BackColor = System.Drawing.Color.FromArgb(CType(CType(164, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(96, Byte), Integer))
        Me.Panel6.Location = New System.Drawing.Point(0, 3)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(1622, 35)
        Me.Panel6.TabIndex = 30
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.Color.FromArgb(CType(CType(164, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(96, Byte), Integer))
        Me.Panel5.Controls.Add(Me.lblInactiveCount)
        Me.Panel5.Controls.Add(Me.Label8)
        Me.Panel5.Controls.Add(Me.PictureBox3)
        Me.Panel5.Location = New System.Drawing.Point(1088, 117)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(262, 134)
        Me.Panel5.TabIndex = 1
        '
        'lblInactiveCount
        '
        Me.lblInactiveCount.Font = New System.Drawing.Font("Tahoma", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblInactiveCount.ForeColor = System.Drawing.Color.White
        Me.lblInactiveCount.Location = New System.Drawing.Point(202, 38)
        Me.lblInactiveCount.Name = "lblInactiveCount"
        Me.lblInactiveCount.Size = New System.Drawing.Size(129, 37)
        Me.lblInactiveCount.TabIndex = 6
        Me.lblInactiveCount.Text = "0"
        '
        'Label8
        '
        Me.Label8.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.White
        Me.Label8.Location = New System.Drawing.Point(98, 86)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(173, 37)
        Me.Label8.TabIndex = 5
        Me.Label8.Text = "Ended Promotions"
        '
        'PictureBox3
        '
        Me.PictureBox3.Image = Global.CustomerManagement.My.Resources.Resources._end
        Me.PictureBox3.Location = New System.Drawing.Point(20, 38)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(60, 60)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox3.TabIndex = 2
        Me.PictureBox3.TabStop = False
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(164, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(96, Byte), Integer))
        Me.Panel3.Controls.Add(Me.lblPendingCount)
        Me.Panel3.Controls.Add(Me.Label3)
        Me.Panel3.Controls.Add(Me.PictureBox1)
        Me.Panel3.Location = New System.Drawing.Point(574, 117)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(262, 134)
        Me.Panel3.TabIndex = 0
        '
        'lblPendingCount
        '
        Me.lblPendingCount.Font = New System.Drawing.Font("Tahoma", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPendingCount.ForeColor = System.Drawing.Color.White
        Me.lblPendingCount.Location = New System.Drawing.Point(216, 38)
        Me.lblPendingCount.Name = "lblPendingCount"
        Me.lblPendingCount.Size = New System.Drawing.Size(129, 37)
        Me.lblPendingCount.TabIndex = 2
        Me.lblPendingCount.Text = "0"
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(100, 86)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(175, 37)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Pending promotions"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.CustomerManagement.My.Resources.Resources.pending
        Me.PictureBox1.Location = New System.Drawing.Point(16, 38)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(60, 60)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Panel2.Controls.Add(Me.GroupBox1)
        Me.Panel2.Controls.Add(Me.dgvPromoMenu)
        Me.Panel2.Controls.Add(Me.grpCustomer)
        Me.Panel2.Location = New System.Drawing.Point(12, 303)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1456, 719)
        Me.Panel2.TabIndex = 35
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.GroupBox2)
        Me.GroupBox1.Controls.Add(Me.Panel11)
        Me.GroupBox1.Location = New System.Drawing.Point(704, 21)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(734, 153)
        Me.GroupBox1.TabIndex = 64
        Me.GroupBox1.TabStop = False
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.PictureBox20)
        Me.GroupBox2.Controls.Add(Me.btnEditPromotion)
        Me.GroupBox2.Controls.Add(Me.btnAddPromotion)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(322, 19)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(406, 120)
        Me.GroupBox2.TabIndex = 61
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Manage Promotion"
        '
        'PictureBox20
        '
        Me.PictureBox20.Image = Global.CustomerManagement.My.Resources.Resources.manage
        Me.PictureBox20.Location = New System.Drawing.Point(17, 26)
        Me.PictureBox20.Name = "PictureBox20"
        Me.PictureBox20.Size = New System.Drawing.Size(95, 80)
        Me.PictureBox20.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox20.TabIndex = 5
        Me.PictureBox20.TabStop = False
        '
        'Panel11
        '
        Me.Panel11.BackColor = System.Drawing.Color.FromArgb(CType(CType(164, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(96, Byte), Integer))
        Me.Panel11.Controls.Add(Me.lblTotalPromotion)
        Me.Panel11.Controls.Add(Me.Label123)
        Me.Panel11.Controls.Add(Me.PictureBox8)
        Me.Panel11.Location = New System.Drawing.Point(15, 22)
        Me.Panel11.Name = "Panel11"
        Me.Panel11.Size = New System.Drawing.Size(284, 113)
        Me.Panel11.TabIndex = 6
        '
        'lblTotalPromotion
        '
        Me.lblTotalPromotion.Font = New System.Drawing.Font("Tahoma", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalPromotion.ForeColor = System.Drawing.Color.White
        Me.lblTotalPromotion.Location = New System.Drawing.Point(207, 38)
        Me.lblTotalPromotion.Name = "lblTotalPromotion"
        Me.lblTotalPromotion.Size = New System.Drawing.Size(55, 37)
        Me.lblTotalPromotion.TabIndex = 4
        Me.lblTotalPromotion.Text = "0"
        '
        'Label123
        '
        Me.Label123.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label123.ForeColor = System.Drawing.Color.White
        Me.Label123.Location = New System.Drawing.Point(127, 80)
        Me.Label123.Name = "Label123"
        Me.Label123.Size = New System.Drawing.Size(157, 22)
        Me.Label123.TabIndex = 3
        Me.Label123.Text = "Total Promotions"
        Me.Label123.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'PictureBox8
        '
        Me.PictureBox8.Image = Global.CustomerManagement.My.Resources.Resources.promotionPIC
        Me.PictureBox8.Location = New System.Drawing.Point(20, 38)
        Me.PictureBox8.Name = "PictureBox8"
        Me.PictureBox8.Size = New System.Drawing.Size(74, 60)
        Me.PictureBox8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox8.TabIndex = 1
        Me.PictureBox8.TabStop = False
        '
        'dgvPromoMenu
        '
        Me.dgvPromoMenu.AllowUserToAddRows = False
        Me.dgvPromoMenu.AllowUserToDeleteRows = False
        Me.dgvPromoMenu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvPromoMenu.Location = New System.Drawing.Point(17, 191)
        Me.dgvPromoMenu.Name = "dgvPromoMenu"
        Me.dgvPromoMenu.ReadOnly = True
        Me.dgvPromoMenu.Size = New System.Drawing.Size(1402, 490)
        Me.dgvPromoMenu.TabIndex = 63
        '
        'PromotionBindingSource
        '
        Me.PromotionBindingSource.DataMember = "Promotion"
        Me.PromotionBindingSource.DataSource = Me.CustomerDataSet1
        '
        'CustomerDataSet1
        '
        Me.CustomerDataSet1.DataSetName = "CustomerDataSet1"
        Me.CustomerDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'PromotionTableAdapter
        '
        Me.PromotionTableAdapter.ClearBeforeFill = True
        '
        'promotionMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1664, 1011)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "promotionMenu"
        Me.Text = "PromotionMenu"
        CType(Me.CustomerBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CustomerDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpCustomer.ResumeLayout(False)
        Me.grpCustomer.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel8.ResumeLayout(False)
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel5.ResumeLayout(False)
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel3.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.PictureBox20, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel11.ResumeLayout(False)
        CType(Me.PictureBox8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvPromoMenu, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PromotionBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CustomerDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents CustomerBindingSource As BindingSource
    Friend WithEvents CustomerDataSet As CustomerDataSet
    Friend WithEvents btnEditPromotion As Button
    Friend WithEvents btnAddPromotion As Button
    Friend WithEvents grpCustomer As GroupBox
    Friend WithEvents btnSearchPromo As Button
    Friend WithEvents cboSearch As ComboBox
    Friend WithEvents Label9 As Label
    Friend WithEvents btnCustClear As Button
    Friend WithEvents txtSearhPromo As TextBox
    Friend WithEvents PictureBox5 As PictureBox
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel8 As Panel
    Friend WithEvents lblOnGoingCount As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Panel6 As Panel
    Friend WithEvents Panel5 As Panel
    Friend WithEvents lblInactiveCount As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Panel3 As Panel
    Friend WithEvents lblPendingCount As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents dgvPromoMenu As DataGridView
    Friend WithEvents CustomerDataSet1 As CustomerDataSet1
    Friend WithEvents PromotionBindingSource As BindingSource
    Friend WithEvents PromotionTableAdapter As CustomerDataSet1TableAdapters.PromotionTableAdapter
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Panel11 As Panel
    Friend WithEvents lblTotalPromotion As Label
    Friend WithEvents Label123 As Label
    Friend WithEvents PictureBox8 As PictureBox
    Friend WithEvents PictureBox20 As PictureBox
    Friend WithEvents GroupBox2 As GroupBox
End Class
