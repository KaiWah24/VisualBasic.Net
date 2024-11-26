<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmInventoryRestock
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
        Me.dgvRestock = New System.Windows.Forms.DataGridView()
        Me.dgvRestockColumnProductId = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgvRestockColumnName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgvRestockColumnPrice = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgvRestockColumnRemainingStock = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgvRestockColumnRestockQuantity = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgvRestockColumnRestockPrice = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgvRestockColumnTotalPrice = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgvRestockColumnSupplier = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.dgvRestockColumnTodayDate = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgvRestockColumnHandleBy = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.dgvRestock, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgvRestock
        '
        Me.dgvRestock.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvRestock.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvRestock.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.dgvRestockColumnProductId, Me.dgvRestockColumnName, Me.dgvRestockColumnPrice, Me.dgvRestockColumnRemainingStock, Me.dgvRestockColumnRestockQuantity, Me.dgvRestockColumnRestockPrice, Me.dgvRestockColumnTotalPrice, Me.dgvRestockColumnSupplier, Me.dgvRestockColumnTodayDate, Me.dgvRestockColumnHandleBy})
        Me.dgvRestock.Location = New System.Drawing.Point(12, 34)
        Me.dgvRestock.Name = "dgvRestock"
        Me.dgvRestock.RowHeadersWidth = 51
        Me.dgvRestock.RowTemplate.Height = 24
        Me.dgvRestock.Size = New System.Drawing.Size(1638, 586)
        Me.dgvRestock.TabIndex = 0
        '
        'dgvRestockColumnProductId
        '
        Me.dgvRestockColumnProductId.HeaderText = "Product ID"
        Me.dgvRestockColumnProductId.MinimumWidth = 6
        Me.dgvRestockColumnProductId.Name = "dgvRestockColumnProductId"
        Me.dgvRestockColumnProductId.Width = 90
        '
        'dgvRestockColumnName
        '
        Me.dgvRestockColumnName.FillWeight = 80.0!
        Me.dgvRestockColumnName.HeaderText = "Name"
        Me.dgvRestockColumnName.MinimumWidth = 6
        Me.dgvRestockColumnName.Name = "dgvRestockColumnName"
        Me.dgvRestockColumnName.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvRestockColumnName.Width = 125
        '
        'dgvRestockColumnPrice
        '
        Me.dgvRestockColumnPrice.FillWeight = 80.0!
        Me.dgvRestockColumnPrice.HeaderText = "Price"
        Me.dgvRestockColumnPrice.MinimumWidth = 6
        Me.dgvRestockColumnPrice.Name = "dgvRestockColumnPrice"
        Me.dgvRestockColumnPrice.Width = 125
        '
        'dgvRestockColumnRemainingStock
        '
        Me.dgvRestockColumnRemainingStock.HeaderText = "Remaining Stock"
        Me.dgvRestockColumnRemainingStock.MinimumWidth = 6
        Me.dgvRestockColumnRemainingStock.Name = "dgvRestockColumnRemainingStock"
        Me.dgvRestockColumnRemainingStock.Width = 150
        '
        'dgvRestockColumnRestockQuantity
        '
        Me.dgvRestockColumnRestockQuantity.HeaderText = "Restock Quantity"
        Me.dgvRestockColumnRestockQuantity.MinimumWidth = 6
        Me.dgvRestockColumnRestockQuantity.Name = "dgvRestockColumnRestockQuantity"
        Me.dgvRestockColumnRestockQuantity.Width = 145
        '
        'dgvRestockColumnRestockPrice
        '
        Me.dgvRestockColumnRestockPrice.HeaderText = "Restock Price"
        Me.dgvRestockColumnRestockPrice.MinimumWidth = 6
        Me.dgvRestockColumnRestockPrice.Name = "dgvRestockColumnRestockPrice"
        Me.dgvRestockColumnRestockPrice.Width = 125
        '
        'dgvRestockColumnTotalPrice
        '
        Me.dgvRestockColumnTotalPrice.HeaderText = "Total Price of Restock"
        Me.dgvRestockColumnTotalPrice.MinimumWidth = 6
        Me.dgvRestockColumnTotalPrice.Name = "dgvRestockColumnTotalPrice"
        Me.dgvRestockColumnTotalPrice.Width = 180
        '
        'dgvRestockColumnSupplier
        '
        Me.dgvRestockColumnSupplier.HeaderText = "Supplier"
        Me.dgvRestockColumnSupplier.MinimumWidth = 6
        Me.dgvRestockColumnSupplier.Name = "dgvRestockColumnSupplier"
        Me.dgvRestockColumnSupplier.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvRestockColumnSupplier.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.dgvRestockColumnSupplier.Width = 125
        '
        'dgvRestockColumnTodayDate
        '
        Me.dgvRestockColumnTodayDate.HeaderText = "Today's Date"
        Me.dgvRestockColumnTodayDate.MinimumWidth = 6
        Me.dgvRestockColumnTodayDate.Name = "dgvRestockColumnTodayDate"
        Me.dgvRestockColumnTodayDate.Width = 125
        '
        'dgvRestockColumnHandleBy
        '
        Me.dgvRestockColumnHandleBy.HeaderText = "Handle By"
        Me.dgvRestockColumnHandleBy.MinimumWidth = 6
        Me.dgvRestockColumnHandleBy.Name = "dgvRestockColumnHandleBy"
        Me.dgvRestockColumnHandleBy.Width = 125
        '
        'frmInventoryRestock
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(36, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1662, 658)
        Me.Controls.Add(Me.dgvRestock)
        Me.MaximumSize = New System.Drawing.Size(1680, 1050)
        Me.Name = "frmInventoryRestock"
        Me.Text = "frmInventoryRestock"
        CType(Me.dgvRestock, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents dgvRestock As DataGridView
    Friend WithEvents dgvRestockColumnProductId As DataGridViewTextBoxColumn
    Friend WithEvents dgvRestockColumnName As DataGridViewTextBoxColumn
    Friend WithEvents dgvRestockColumnPrice As DataGridViewTextBoxColumn
    Friend WithEvents dgvRestockColumnRemainingStock As DataGridViewTextBoxColumn
    Friend WithEvents dgvRestockColumnRestockQuantity As DataGridViewTextBoxColumn
    Friend WithEvents dgvRestockColumnRestockPrice As DataGridViewTextBoxColumn
    Friend WithEvents dgvRestockColumnTotalPrice As DataGridViewTextBoxColumn
    Friend WithEvents dgvRestockColumnSupplier As DataGridViewComboBoxColumn
    Friend WithEvents dgvRestockColumnTodayDate As DataGridViewTextBoxColumn
    Friend WithEvents dgvRestockColumnHandleBy As DataGridViewTextBoxColumn
End Class
