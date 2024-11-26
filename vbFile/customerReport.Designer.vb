<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class customerReport
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(customerReport))
        Me.dgvCustomerReport = New System.Windows.Forms.DataGridView()
        Me.CustomerBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CustomerDataSet3 = New CustomerManagement.CustomerDataSet3()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.CustomerDataSet = New CustomerManagement.CustomerDataSet()
        Me.CustomerDataSetBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CustomerTableAdapter = New CustomerManagement.CustomerDataSet3TableAdapters.CustomerTableAdapter()
        Me.cboSelectedTier = New System.Windows.Forms.ComboBox()
        Me.lblTotalCustomer = New System.Windows.Forms.Label()
        Me.doc = New System.Drawing.Printing.PrintDocument()
        Me.dlgPreview = New System.Windows.Forms.PrintPreviewDialog()
        Me.btnPrint = New System.Windows.Forms.Button()
        CType(Me.dgvCustomerReport, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CustomerBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CustomerDataSet3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CustomerDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CustomerDataSetBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgvCustomerReport
        '
        Me.dgvCustomerReport.AllowUserToAddRows = False
        Me.dgvCustomerReport.AllowUserToDeleteRows = False
        Me.dgvCustomerReport.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvCustomerReport.Location = New System.Drawing.Point(149, 279)
        Me.dgvCustomerReport.Name = "dgvCustomerReport"
        Me.dgvCustomerReport.ReadOnly = True
        Me.dgvCustomerReport.Size = New System.Drawing.Size(1244, 331)
        Me.dgvCustomerReport.TabIndex = 40
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
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(131, 164)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(574, 49)
        Me.Label1.TabIndex = 41
        Me.Label1.Text = "Super Grocer's Customer Report"
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(952, 240)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(243, 28)
        Me.Label2.TabIndex = 44
        Me.Label2.Text = "Search through tier..."
        '
        'CustomerDataSet
        '
        Me.CustomerDataSet.DataSetName = "CustomerDataSet"
        Me.CustomerDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'CustomerDataSetBindingSource
        '
        Me.CustomerDataSetBindingSource.DataSource = Me.CustomerDataSet
        Me.CustomerDataSetBindingSource.Position = 0
        '
        'CustomerTableAdapter
        '
        Me.CustomerTableAdapter.ClearBeforeFill = True
        '
        'cboSelectedTier
        '
        Me.cboSelectedTier.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboSelectedTier.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboSelectedTier.FormattingEnabled = True
        Me.cboSelectedTier.Items.AddRange(New Object() {"Standard Tier", "Silver Tier", "Gold Tier", "Platinum Tier", "Diamond Tier"})
        Me.cboSelectedTier.Location = New System.Drawing.Point(1201, 240)
        Me.cboSelectedTier.Name = "cboSelectedTier"
        Me.cboSelectedTier.Size = New System.Drawing.Size(172, 28)
        Me.cboSelectedTier.TabIndex = 47
        '
        'lblTotalCustomer
        '
        Me.lblTotalCustomer.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalCustomer.Location = New System.Drawing.Point(145, 632)
        Me.lblTotalCustomer.Name = "lblTotalCustomer"
        Me.lblTotalCustomer.Size = New System.Drawing.Size(401, 30)
        Me.lblTotalCustomer.TabIndex = 48
        Me.lblTotalCustomer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
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
        Me.btnPrint.Location = New System.Drawing.Point(1285, 622)
        Me.btnPrint.Name = "btnPrint"
        Me.btnPrint.Size = New System.Drawing.Size(108, 40)
        Me.btnPrint.TabIndex = 49
        Me.btnPrint.Text = "&Print"
        Me.btnPrint.UseVisualStyleBackColor = False
        '
        'customerReport
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1454, 971)
        Me.Controls.Add(Me.btnPrint)
        Me.Controls.Add(Me.lblTotalCustomer)
        Me.Controls.Add(Me.cboSelectedTier)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.dgvCustomerReport)
        Me.Name = "customerReport"
        Me.Text = "customerReport"
        CType(Me.dgvCustomerReport, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CustomerBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CustomerDataSet3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CustomerDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CustomerDataSetBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents dgvCustomerReport As DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents CustomerDataSetBindingSource As BindingSource
    Friend WithEvents CustomerDataSet As CustomerDataSet
    Friend WithEvents CustomerDataSet3 As CustomerDataSet3
    Friend WithEvents CustomerBindingSource As BindingSource
    Friend WithEvents CustomerTableAdapter As CustomerDataSet3TableAdapters.CustomerTableAdapter
    Friend WithEvents cboSelectedTier As ComboBox
    Friend WithEvents lblTotalCustomer As Label
    Friend WithEvents doc As Printing.PrintDocument
    Friend WithEvents dlgPreview As PrintPreviewDialog
    Friend WithEvents btnPrint As Button
End Class
