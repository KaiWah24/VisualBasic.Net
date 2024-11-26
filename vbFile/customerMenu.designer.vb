<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class customerMenu
    Inherits System.Windows.Forms.Form

    Dim CustomerDataSet As New CustomerManagement.CustomerDataSet
    Dim CustomerDataSet1 As New CustomerManagement.CustomerDataSet1
    Dim CustomerDataSet2 As New CustomerManagement.CustomerDataSet2
    Dim CustomerDataSet3 As New CustomerManagement.CustomerDataSet3
    Dim CustomerDataSet4 As New CustomerManagement.CustomerDataSet4


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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(customerMenu))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.lblTotalCount = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Panel8 = New System.Windows.Forms.Panel()
        Me.lblActiveCount = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.PictureBox5 = New System.Windows.Forms.PictureBox()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.lblInactiveCount = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnEdit = New System.Windows.Forms.Button()
        Me.btnViewDetails = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.PictureBox20 = New System.Windows.Forms.PictureBox()
        Me.btnAddCustomer = New System.Windows.Forms.Button()
        Me.dgvMenu = New System.Windows.Forms.DataGridView()
        Me.grpCustomer = New System.Windows.Forms.GroupBox()
        Me.btnSearchCustomer = New System.Windows.Forms.Button()
        Me.cboSearch = New System.Windows.Forms.ComboBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.btnCustClear = New System.Windows.Forms.Button()
        Me.txtSearhCust = New System.Windows.Forms.TextBox()
        Me.CustomerBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CustomerDataSet = New CustomerManagement.CustomerDataSet()
        Me.Panel1.SuspendLayout()
        Me.Panel3.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel8.SuspendLayout()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel5.SuspendLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.PictureBox20, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvMenu, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpCustomer.SuspendLayout()
        CType(Me.CustomerBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CustomerDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Panel1.Controls.Add(Me.Panel3)
        Me.Panel1.Controls.Add(Me.Panel8)
        Me.Panel1.Controls.Add(Me.PictureBox4)
        Me.Panel1.Controls.Add(Me.Label12)
        Me.Panel1.Controls.Add(Me.Panel6)
        Me.Panel1.Controls.Add(Me.Panel5)
        Me.Panel1.Location = New System.Drawing.Point(6, -4)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1446, 286)
        Me.Panel1.TabIndex = 0
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(164, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(96, Byte), Integer))
        Me.Panel3.Controls.Add(Me.lblTotalCount)
        Me.Panel3.Controls.Add(Me.Label3)
        Me.Panel3.Controls.Add(Me.PictureBox1)
        Me.Panel3.Location = New System.Drawing.Point(68, 117)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(262, 134)
        Me.Panel3.TabIndex = 0
        '
        'lblTotalCount
        '
        Me.lblTotalCount.Font = New System.Drawing.Font("Tahoma", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalCount.ForeColor = System.Drawing.Color.White
        Me.lblTotalCount.Location = New System.Drawing.Point(216, 38)
        Me.lblTotalCount.Name = "lblTotalCount"
        Me.lblTotalCount.Size = New System.Drawing.Size(129, 37)
        Me.lblTotalCount.TabIndex = 2
        Me.lblTotalCount.Text = "0"
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(114, 86)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(129, 37)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Total Customers"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.CustomerManagement.My.Resources.Resources._3126647
        Me.PictureBox1.Location = New System.Drawing.Point(16, 38)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(60, 60)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'Panel8
        '
        Me.Panel8.BackColor = System.Drawing.Color.FromArgb(CType(CType(164, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(96, Byte), Integer))
        Me.Panel8.Controls.Add(Me.lblActiveCount)
        Me.Panel8.Controls.Add(Me.Label11)
        Me.Panel8.Controls.Add(Me.PictureBox5)
        Me.Panel8.Location = New System.Drawing.Point(574, 117)
        Me.Panel8.Name = "Panel8"
        Me.Panel8.Size = New System.Drawing.Size(262, 134)
        Me.Panel8.TabIndex = 5
        '
        'lblActiveCount
        '
        Me.lblActiveCount.Font = New System.Drawing.Font("Tahoma", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblActiveCount.ForeColor = System.Drawing.Color.White
        Me.lblActiveCount.Location = New System.Drawing.Point(207, 38)
        Me.lblActiveCount.Name = "lblActiveCount"
        Me.lblActiveCount.Size = New System.Drawing.Size(55, 37)
        Me.lblActiveCount.TabIndex = 4
        Me.lblActiveCount.Text = "0"
        '
        'Label11
        '
        Me.Label11.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.White
        Me.Label11.Location = New System.Drawing.Point(105, 86)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(139, 37)
        Me.Label11.TabIndex = 3
        Me.Label11.Text = "Active Customers"
        '
        'PictureBox5
        '
        Me.PictureBox5.Image = Global.CustomerManagement.My.Resources.Resources.active
        Me.PictureBox5.Location = New System.Drawing.Point(20, 38)
        Me.PictureBox5.Name = "PictureBox5"
        Me.PictureBox5.Size = New System.Drawing.Size(60, 60)
        Me.PictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox5.TabIndex = 1
        Me.PictureBox5.TabStop = False
        '
        'PictureBox4
        '
        Me.PictureBox4.Image = CType(resources.GetObject("PictureBox4.Image"), System.Drawing.Image)
        Me.PictureBox4.Location = New System.Drawing.Point(7, 41)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(85, 60)
        Me.PictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox4.TabIndex = 32
        Me.PictureBox4.TabStop = False
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(98, 51)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(259, 29)
        Me.Label12.TabIndex = 31
        Me.Label12.Text = "Customer Dashboard"
        '
        'Panel6
        '
        Me.Panel6.BackColor = System.Drawing.Color.FromArgb(CType(CType(164, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(96, Byte), Integer))
        Me.Panel6.Location = New System.Drawing.Point(-8, 3)
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
        Me.Label8.Location = New System.Drawing.Point(100, 86)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(144, 37)
        Me.Label8.TabIndex = 5
        Me.Label8.Text = "Inactive Customers"
        '
        'PictureBox3
        '
        Me.PictureBox3.Image = Global.CustomerManagement.My.Resources.Resources.inactive
        Me.PictureBox3.Location = New System.Drawing.Point(20, 38)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(60, 60)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox3.TabIndex = 2
        Me.PictureBox3.TabStop = False
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Panel2.Controls.Add(Me.GroupBox1)
        Me.Panel2.Controls.Add(Me.dgvMenu)
        Me.Panel2.Controls.Add(Me.grpCustomer)
        Me.Panel2.Location = New System.Drawing.Point(8, 288)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1680, 1050)
        Me.Panel2.TabIndex = 1
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnEdit)
        Me.GroupBox1.Controls.Add(Me.btnViewDetails)
        Me.GroupBox1.Controls.Add(Me.GroupBox2)
        Me.GroupBox1.Location = New System.Drawing.Point(701, 32)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(729, 136)
        Me.GroupBox1.TabIndex = 63
        Me.GroupBox1.TabStop = False
        '
        'btnEdit
        '
        Me.btnEdit.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(36, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.btnEdit.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEdit.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnEdit.Location = New System.Drawing.Point(341, 88)
        Me.btnEdit.Name = "btnEdit"
        Me.btnEdit.Size = New System.Drawing.Size(124, 33)
        Me.btnEdit.TabIndex = 61
        Me.btnEdit.Text = "&Edit"
        Me.btnEdit.UseVisualStyleBackColor = False
        '
        'btnViewDetails
        '
        Me.btnViewDetails.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(36, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.btnViewDetails.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnViewDetails.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnViewDetails.Location = New System.Drawing.Point(592, 88)
        Me.btnViewDetails.Name = "btnViewDetails"
        Me.btnViewDetails.Size = New System.Drawing.Size(124, 33)
        Me.btnViewDetails.TabIndex = 62
        Me.btnViewDetails.Text = "View &Details"
        Me.btnViewDetails.UseVisualStyleBackColor = False
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.PictureBox20)
        Me.GroupBox2.Controls.Add(Me.btnAddCustomer)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(6, 9)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(310, 120)
        Me.GroupBox2.TabIndex = 62
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Manage Customer"
        '
        'PictureBox20
        '
        Me.PictureBox20.Image = Global.CustomerManagement.My.Resources.Resources.manage
        Me.PictureBox20.Location = New System.Drawing.Point(16, 25)
        Me.PictureBox20.Name = "PictureBox20"
        Me.PictureBox20.Size = New System.Drawing.Size(95, 80)
        Me.PictureBox20.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox20.TabIndex = 5
        Me.PictureBox20.TabStop = False
        '
        'btnAddCustomer
        '
        Me.btnAddCustomer.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(36, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.btnAddCustomer.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAddCustomer.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnAddCustomer.Location = New System.Drawing.Point(160, 79)
        Me.btnAddCustomer.Name = "btnAddCustomer"
        Me.btnAddCustomer.Size = New System.Drawing.Size(124, 33)
        Me.btnAddCustomer.TabIndex = 60
        Me.btnAddCustomer.Text = "&Add"
        Me.btnAddCustomer.UseVisualStyleBackColor = False
        '
        'dgvMenu
        '
        Me.dgvMenu.AllowUserToAddRows = False
        Me.dgvMenu.AllowUserToDeleteRows = False
        Me.dgvMenu.BackgroundColor = System.Drawing.Color.LightSeaGreen
        Me.dgvMenu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvMenu.Location = New System.Drawing.Point(17, 174)
        Me.dgvMenu.Name = "dgvMenu"
        Me.dgvMenu.ReadOnly = True
        Me.dgvMenu.Size = New System.Drawing.Size(1413, 498)
        Me.dgvMenu.TabIndex = 61
        '
        'grpCustomer
        '
        Me.grpCustomer.Controls.Add(Me.btnSearchCustomer)
        Me.grpCustomer.Controls.Add(Me.cboSearch)
        Me.grpCustomer.Controls.Add(Me.Label9)
        Me.grpCustomer.Controls.Add(Me.btnCustClear)
        Me.grpCustomer.Controls.Add(Me.txtSearhCust)
        Me.grpCustomer.Font = New System.Drawing.Font("Tahoma", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpCustomer.Location = New System.Drawing.Point(17, 21)
        Me.grpCustomer.Name = "grpCustomer"
        Me.grpCustomer.Size = New System.Drawing.Size(659, 147)
        Me.grpCustomer.TabIndex = 57
        Me.grpCustomer.TabStop = False
        Me.grpCustomer.Text = "Search Customer"
        '
        'btnSearchCustomer
        '
        Me.btnSearchCustomer.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(36, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.btnSearchCustomer.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSearchCustomer.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnSearchCustomer.Location = New System.Drawing.Point(392, 99)
        Me.btnSearchCustomer.Name = "btnSearchCustomer"
        Me.btnSearchCustomer.Size = New System.Drawing.Size(124, 33)
        Me.btnSearchCustomer.TabIndex = 61
        Me.btnSearchCustomer.Text = "&Search"
        Me.btnSearchCustomer.UseVisualStyleBackColor = False
        '
        'cboSearch
        '
        Me.cboSearch.AutoCompleteCustomSource.AddRange(New String() {"Customer ID", "Customer Name", "Customer Phone Number"})
        Me.cboSearch.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboSearch.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboSearch.FormattingEnabled = True
        Me.cboSearch.Items.AddRange(New Object() {"All", "ID", "Name", "Phone number", "Email"})
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
        'txtSearhCust
        '
        Me.txtSearhCust.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSearhCust.Location = New System.Drawing.Point(119, 84)
        Me.txtSearhCust.Multiline = True
        Me.txtSearhCust.Name = "txtSearhCust"
        Me.txtSearhCust.Size = New System.Drawing.Size(226, 27)
        Me.txtSearhCust.TabIndex = 55
        Me.txtSearhCust.Text = "Search..."
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
        'customerMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1468, 1008)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "customerMenu"
        Me.Text = "customerMenu"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel8.ResumeLayout(False)
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel5.ResumeLayout(False)
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.PictureBox20, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvMenu, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpCustomer.ResumeLayout(False)
        Me.grpCustomer.PerformLayout()
        CType(Me.CustomerBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CustomerDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel5 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents Label3 As Label
    Friend WithEvents lblInactiveCount As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents lblTotalCount As Label
    Friend WithEvents btnCustClear As Button
    Friend WithEvents txtSearhCust As TextBox
    Friend WithEvents grpCustomer As GroupBox
    Friend WithEvents Label9 As Label
    Friend WithEvents cboSearch As ComboBox
    Friend WithEvents Label12 As Label
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents btnAddCustomer As Button
    Friend WithEvents btnSearchCustomer As Button
    Friend WithEvents Panel8 As Panel
    Friend WithEvents lblActiveCount As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents PictureBox5 As PictureBox
    Friend WithEvents Panel6 As Panel
    Friend WithEvents dgvMenu As DataGridView
    Friend WithEvents CustomerBindingSource As BindingSource
    Friend WithEvents CustomerTableAdapter As CustomerDataSetTableAdapters.CustomerTableAdapter
    Friend WithEvents btnViewDetails As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents CustomerpointsDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents PictureBox20 As PictureBox
    Friend WithEvents btnEdit As Button
    Friend WithEvents CustomerBindingSource1 As BindingSource
    Friend WithEvents CustomerTableAdapter1 As CustomerDataSet4TableAdapters.CustomerTableAdapter
    Friend WithEvents CustomerBindingSource2 As BindingSource
End Class
