<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class promotionReport
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(promotionReport))
        Me.Label2 = New System.Windows.Forms.Label()
        Me.CustomerDataSetBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CustomerDataSet = New CustomerManagement.CustomerDataSet()
        Me.CustomerTableAdapter = New CustomerManagement.CustomerDataSet3TableAdapters.CustomerTableAdapter()
        Me.lblTotalCustomer = New System.Windows.Forms.Label()
        Me.cboSelectedType = New System.Windows.Forms.ComboBox()
        Me.doc = New System.Drawing.Printing.PrintDocument()
        Me.dlgPreview = New System.Windows.Forms.PrintPreviewDialog()
        Me.btnPrint = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dgvPromotionReport = New System.Windows.Forms.DataGridView()
        Me.PromotionBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CustomerDataSet4BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CustomerDataSet4 = New CustomerManagement.CustomerDataSet4()
        Me.CustomerBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CustomerDataSet3 = New CustomerManagement.CustomerDataSet3()
        Me.CustomerBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.TableAdapterManager = New CustomerManagement.CustomerDataSet1TableAdapters.TableAdapterManager()
        Me.PromotionTableAdapter = New CustomerManagement.CustomerDataSet1TableAdapters.PromotionTableAdapter()
        Me.FillByToolStrip = New System.Windows.Forms.ToolStrip()
        Me.FillByToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.CustomerDataSet1 = New CustomerManagement.CustomerDataSet1()
        Me.PromotionTableAdapter1 = New CustomerManagement.CustomerDataSet4TableAdapters.PromotionTableAdapter()
        Me.PromotionidDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PromotionnameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.StartdateDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EnddateDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PromotiontypeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DiscounttypeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DiscountvalueDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PromotionstatusDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ProductidDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.VouchercodeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UsagelimitDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UsagecountDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.CustomerDataSetBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CustomerDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvPromotionReport, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PromotionBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CustomerDataSet4BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CustomerDataSet4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CustomerBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CustomerDataSet3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CustomerBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.FillByToolStrip.SuspendLayout()
        CType(Me.CustomerDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(945, 200)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(243, 28)
        Me.Label2.TabIndex = 53
        Me.Label2.Text = "Search through type..."
        '
        'CustomerDataSetBindingSource
        '
        Me.CustomerDataSetBindingSource.DataSource = Me.CustomerDataSet
        Me.CustomerDataSetBindingSource.Position = 0
        '
        'CustomerDataSet
        '
        Me.CustomerDataSet.DataSetName = "CustomerDataSet"
        Me.CustomerDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'CustomerTableAdapter
        '
        Me.CustomerTableAdapter.ClearBeforeFill = True
        '
        'lblTotalCustomer
        '
        Me.lblTotalCustomer.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalCustomer.Location = New System.Drawing.Point(142, 582)
        Me.lblTotalCustomer.Name = "lblTotalCustomer"
        Me.lblTotalCustomer.Size = New System.Drawing.Size(401, 30)
        Me.lblTotalCustomer.TabIndex = 55
        Me.lblTotalCustomer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'cboSelectedType
        '
        Me.cboSelectedType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboSelectedType.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboSelectedType.FormattingEnabled = True
        Me.cboSelectedType.Items.AddRange(New Object() {"Product", "Voucher"})
        Me.cboSelectedType.Location = New System.Drawing.Point(1194, 200)
        Me.cboSelectedType.Name = "cboSelectedType"
        Me.cboSelectedType.Size = New System.Drawing.Size(172, 28)
        Me.cboSelectedType.TabIndex = 54
        '
        'doc
        '
        Me.doc.OriginAtMargins = True
        '
        'dlgPreview
        '
        Me.dlgPreview.AutoScrollMargin = New System.Drawing.Size(0, 0)
        Me.dlgPreview.AutoScrollMinSize = New System.Drawing.Size(0, 0)
        Me.dlgPreview.ClientSize = New System.Drawing.Size(400, 300)
        Me.dlgPreview.Enabled = True
        Me.dlgPreview.Icon = CType(resources.GetObject("dlgPreview.Icon"), System.Drawing.Icon)
        Me.dlgPreview.Name = "dlgPreview"
        Me.dlgPreview.UseAntiAlias = True
        Me.dlgPreview.Visible = False
        '
        'btnPrint
        '
        Me.btnPrint.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(36, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.btnPrint.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPrint.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnPrint.Location = New System.Drawing.Point(1278, 582)
        Me.btnPrint.Name = "btnPrint"
        Me.btnPrint.Size = New System.Drawing.Size(108, 40)
        Me.btnPrint.TabIndex = 56
        Me.btnPrint.Text = "&Print"
        Me.btnPrint.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(36, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label1.Location = New System.Drawing.Point(135, 124)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(574, 49)
        Me.Label1.TabIndex = 52
        Me.Label1.Text = "Super Grocer's Promotional Report"
        '
        'dgvPromotionReport
        '
        Me.dgvPromotionReport.AllowUserToAddRows = False
        Me.dgvPromotionReport.AllowUserToDeleteRows = False
        Me.dgvPromotionReport.AutoGenerateColumns = False
        Me.dgvPromotionReport.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvPromotionReport.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.PromotionidDataGridViewTextBoxColumn, Me.PromotionnameDataGridViewTextBoxColumn, Me.StartdateDataGridViewTextBoxColumn, Me.EnddateDataGridViewTextBoxColumn, Me.PromotiontypeDataGridViewTextBoxColumn, Me.DiscounttypeDataGridViewTextBoxColumn, Me.DiscountvalueDataGridViewTextBoxColumn, Me.PromotionstatusDataGridViewTextBoxColumn, Me.ProductidDataGridViewTextBoxColumn, Me.VouchercodeDataGridViewTextBoxColumn, Me.UsagelimitDataGridViewTextBoxColumn, Me.UsagecountDataGridViewTextBoxColumn})
        Me.dgvPromotionReport.DataSource = Me.PromotionBindingSource
        Me.dgvPromotionReport.Location = New System.Drawing.Point(142, 239)
        Me.dgvPromotionReport.Name = "dgvPromotionReport"
        Me.dgvPromotionReport.ReadOnly = True
        Me.dgvPromotionReport.Size = New System.Drawing.Size(1244, 331)
        Me.dgvPromotionReport.TabIndex = 51
        '
        'PromotionBindingSource
        '
        Me.PromotionBindingSource.DataMember = "Promotion"
        Me.PromotionBindingSource.DataSource = Me.CustomerDataSet4BindingSource
        '
        'CustomerDataSet4BindingSource
        '
        Me.CustomerDataSet4BindingSource.DataSource = Me.CustomerDataSet4
        Me.CustomerDataSet4BindingSource.Position = 0
        '
        'CustomerDataSet4
        '
        Me.CustomerDataSet4.DataSetName = "CustomerDataSet4"
        Me.CustomerDataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'CustomerBindingSource
        '
        Me.CustomerBindingSource.DataMember = "Customer"
        Me.CustomerBindingSource.DataSource = Me.CustomerDataSet3
        '
        'CustomerDataSet3
        '
        Me.CustomerDataSet3.DataSetName = "CustomerDataSet3"
        Me.CustomerDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'CustomerBindingSource1
        '
        Me.CustomerBindingSource1.DataMember = "Customer"
        Me.CustomerBindingSource1.DataSource = Me.CustomerDataSetBindingSource
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.PromotionTableAdapter = Me.PromotionTableAdapter
        Me.TableAdapterManager.UpdateOrder = CustomerManagement.CustomerDataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'PromotionTableAdapter
        '
        Me.PromotionTableAdapter.ClearBeforeFill = True
        '
        'FillByToolStrip
        '
        Me.FillByToolStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FillByToolStripButton})
        Me.FillByToolStrip.Location = New System.Drawing.Point(0, 0)
        Me.FillByToolStrip.Name = "FillByToolStrip"
        Me.FillByToolStrip.Size = New System.Drawing.Size(1510, 25)
        Me.FillByToolStrip.TabIndex = 57
        Me.FillByToolStrip.Text = "FillByToolStrip"
        '
        'FillByToolStripButton
        '
        Me.FillByToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.FillByToolStripButton.Name = "FillByToolStripButton"
        Me.FillByToolStripButton.Size = New System.Drawing.Size(39, 22)
        Me.FillByToolStripButton.Text = "FillBy"
        '
        'CustomerDataSet1
        '
        Me.CustomerDataSet1.DataSetName = "CustomerDataSet1"
        Me.CustomerDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'PromotionTableAdapter1
        '
        Me.PromotionTableAdapter1.ClearBeforeFill = True
        '
        'PromotionidDataGridViewTextBoxColumn
        '
        Me.PromotionidDataGridViewTextBoxColumn.DataPropertyName = "promotion_id"
        Me.PromotionidDataGridViewTextBoxColumn.HeaderText = "promotion_id"
        Me.PromotionidDataGridViewTextBoxColumn.Name = "PromotionidDataGridViewTextBoxColumn"
        Me.PromotionidDataGridViewTextBoxColumn.ReadOnly = True
        '
        'PromotionnameDataGridViewTextBoxColumn
        '
        Me.PromotionnameDataGridViewTextBoxColumn.DataPropertyName = "promotion_name"
        Me.PromotionnameDataGridViewTextBoxColumn.HeaderText = "promotion_name"
        Me.PromotionnameDataGridViewTextBoxColumn.Name = "PromotionnameDataGridViewTextBoxColumn"
        Me.PromotionnameDataGridViewTextBoxColumn.ReadOnly = True
        '
        'StartdateDataGridViewTextBoxColumn
        '
        Me.StartdateDataGridViewTextBoxColumn.DataPropertyName = "start_date"
        Me.StartdateDataGridViewTextBoxColumn.HeaderText = "start_date"
        Me.StartdateDataGridViewTextBoxColumn.Name = "StartdateDataGridViewTextBoxColumn"
        Me.StartdateDataGridViewTextBoxColumn.ReadOnly = True
        '
        'EnddateDataGridViewTextBoxColumn
        '
        Me.EnddateDataGridViewTextBoxColumn.DataPropertyName = "end_date"
        Me.EnddateDataGridViewTextBoxColumn.HeaderText = "end_date"
        Me.EnddateDataGridViewTextBoxColumn.Name = "EnddateDataGridViewTextBoxColumn"
        Me.EnddateDataGridViewTextBoxColumn.ReadOnly = True
        '
        'PromotiontypeDataGridViewTextBoxColumn
        '
        Me.PromotiontypeDataGridViewTextBoxColumn.DataPropertyName = "promotion_type"
        Me.PromotiontypeDataGridViewTextBoxColumn.HeaderText = "promotion_type"
        Me.PromotiontypeDataGridViewTextBoxColumn.Name = "PromotiontypeDataGridViewTextBoxColumn"
        Me.PromotiontypeDataGridViewTextBoxColumn.ReadOnly = True
        '
        'DiscounttypeDataGridViewTextBoxColumn
        '
        Me.DiscounttypeDataGridViewTextBoxColumn.DataPropertyName = "discount_type"
        Me.DiscounttypeDataGridViewTextBoxColumn.HeaderText = "discount_type"
        Me.DiscounttypeDataGridViewTextBoxColumn.Name = "DiscounttypeDataGridViewTextBoxColumn"
        Me.DiscounttypeDataGridViewTextBoxColumn.ReadOnly = True
        '
        'DiscountvalueDataGridViewTextBoxColumn
        '
        Me.DiscountvalueDataGridViewTextBoxColumn.DataPropertyName = "discount_value"
        Me.DiscountvalueDataGridViewTextBoxColumn.HeaderText = "discount_value"
        Me.DiscountvalueDataGridViewTextBoxColumn.Name = "DiscountvalueDataGridViewTextBoxColumn"
        Me.DiscountvalueDataGridViewTextBoxColumn.ReadOnly = True
        '
        'PromotionstatusDataGridViewTextBoxColumn
        '
        Me.PromotionstatusDataGridViewTextBoxColumn.DataPropertyName = "promotion_status"
        Me.PromotionstatusDataGridViewTextBoxColumn.HeaderText = "promotion_status"
        Me.PromotionstatusDataGridViewTextBoxColumn.Name = "PromotionstatusDataGridViewTextBoxColumn"
        Me.PromotionstatusDataGridViewTextBoxColumn.ReadOnly = True
        '
        'ProductidDataGridViewTextBoxColumn
        '
        Me.ProductidDataGridViewTextBoxColumn.DataPropertyName = "product_id"
        Me.ProductidDataGridViewTextBoxColumn.HeaderText = "product_id"
        Me.ProductidDataGridViewTextBoxColumn.Name = "ProductidDataGridViewTextBoxColumn"
        Me.ProductidDataGridViewTextBoxColumn.ReadOnly = True
        '
        'VouchercodeDataGridViewTextBoxColumn
        '
        Me.VouchercodeDataGridViewTextBoxColumn.DataPropertyName = "voucher_code"
        Me.VouchercodeDataGridViewTextBoxColumn.HeaderText = "voucher_code"
        Me.VouchercodeDataGridViewTextBoxColumn.Name = "VouchercodeDataGridViewTextBoxColumn"
        Me.VouchercodeDataGridViewTextBoxColumn.ReadOnly = True
        '
        'UsagelimitDataGridViewTextBoxColumn
        '
        Me.UsagelimitDataGridViewTextBoxColumn.DataPropertyName = "usage_limit"
        Me.UsagelimitDataGridViewTextBoxColumn.HeaderText = "usage_limit"
        Me.UsagelimitDataGridViewTextBoxColumn.Name = "UsagelimitDataGridViewTextBoxColumn"
        Me.UsagelimitDataGridViewTextBoxColumn.ReadOnly = True
        '
        'UsagecountDataGridViewTextBoxColumn
        '
        Me.UsagecountDataGridViewTextBoxColumn.DataPropertyName = "usage_count"
        Me.UsagecountDataGridViewTextBoxColumn.HeaderText = "usage_count"
        Me.UsagecountDataGridViewTextBoxColumn.Name = "UsagecountDataGridViewTextBoxColumn"
        Me.UsagecountDataGridViewTextBoxColumn.ReadOnly = True
        '
        'promotionReport
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1510, 688)
        Me.Controls.Add(Me.FillByToolStrip)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.lblTotalCustomer)
        Me.Controls.Add(Me.cboSelectedType)
        Me.Controls.Add(Me.btnPrint)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.dgvPromotionReport)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "promotionReport"
        Me.Text = "promotionReport"
        CType(Me.CustomerDataSetBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CustomerDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvPromotionReport, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PromotionBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CustomerDataSet4BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CustomerDataSet4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CustomerBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CustomerDataSet3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CustomerBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.FillByToolStrip.ResumeLayout(False)
        Me.FillByToolStrip.PerformLayout()
        CType(Me.CustomerDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label2 As Label
    Friend WithEvents CustomerDataSetBindingSource As BindingSource
    Friend WithEvents CustomerDataSet As CustomerDataSet
    Friend WithEvents CustomerTableAdapter As CustomerDataSet3TableAdapters.CustomerTableAdapter
    Friend WithEvents lblTotalCustomer As Label
    Friend WithEvents cboSelectedType As ComboBox
    Friend WithEvents doc As Printing.PrintDocument
    Friend WithEvents dlgPreview As PrintPreviewDialog
    Friend WithEvents btnPrint As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents dgvPromotionReport As DataGridView
    Friend WithEvents CustomerBindingSource As BindingSource
    Friend WithEvents CustomerDataSet3 As CustomerDataSet3
    Friend WithEvents CustomerBindingSource1 As BindingSource
    Friend WithEvents CustomerDataSet1 As CustomerDataSet1
    Friend WithEvents PromotionTableAdapter As CustomerDataSet1TableAdapters.PromotionTableAdapter
    Friend WithEvents TableAdapterManager As CustomerDataSet1TableAdapters.TableAdapterManager
    Friend WithEvents FillByToolStrip As ToolStrip
    Friend WithEvents CustomerDataSet4BindingSource As BindingSource
    Friend WithEvents CustomerDataSet4 As CustomerDataSet4
    Friend WithEvents PromotionBindingSource As BindingSource
    Friend WithEvents PromotionTableAdapter1 As CustomerDataSet4TableAdapters.PromotionTableAdapter
    Friend WithEvents FillByToolStripButton As ToolStripButton
    Friend WithEvents PromotionidDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PromotionnameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents StartdateDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents EnddateDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PromotiontypeDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DiscounttypeDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DiscountvalueDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PromotionstatusDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ProductidDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents VouchercodeDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents UsagelimitDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents UsagecountDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
End Class
