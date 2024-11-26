<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmInventoryFreshProduce
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
        Me.btnFreshProduceCreate = New System.Windows.Forms.Button()
        Me.btnFreshProduceEdit = New System.Windows.Forms.Button()
        Me.btnFreshProduceRefresh = New System.Windows.Forms.Button()
        Me.txtSearch = New System.Windows.Forms.TextBox()
        Me.lblSearch = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnFreshProduceCreate
        '
        Me.btnFreshProduceCreate.Font = New System.Drawing.Font("Modern No. 20", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnFreshProduceCreate.Location = New System.Drawing.Point(654, 31)
        Me.btnFreshProduceCreate.Name = "btnFreshProduceCreate"
        Me.btnFreshProduceCreate.Size = New System.Drawing.Size(116, 50)
        Me.btnFreshProduceCreate.TabIndex = 28
        Me.btnFreshProduceCreate.Text = "Create"
        Me.btnFreshProduceCreate.UseVisualStyleBackColor = True
        '
        'btnFreshProduceEdit
        '
        Me.btnFreshProduceEdit.Font = New System.Drawing.Font("Modern No. 20", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnFreshProduceEdit.Location = New System.Drawing.Point(788, 31)
        Me.btnFreshProduceEdit.Name = "btnFreshProduceEdit"
        Me.btnFreshProduceEdit.Size = New System.Drawing.Size(116, 50)
        Me.btnFreshProduceEdit.TabIndex = 29
        Me.btnFreshProduceEdit.Text = "Edit"
        Me.btnFreshProduceEdit.UseVisualStyleBackColor = True
        '
        'btnFreshProduceRefresh
        '
        Me.btnFreshProduceRefresh.Font = New System.Drawing.Font("Modern No. 20", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnFreshProduceRefresh.Location = New System.Drawing.Point(922, 31)
        Me.btnFreshProduceRefresh.Name = "btnFreshProduceRefresh"
        Me.btnFreshProduceRefresh.Size = New System.Drawing.Size(116, 50)
        Me.btnFreshProduceRefresh.TabIndex = 30
        Me.btnFreshProduceRefresh.Text = "Refresh"
        Me.btnFreshProduceRefresh.UseVisualStyleBackColor = True
        '
        'txtSearch
        '
        Me.txtSearch.Location = New System.Drawing.Point(132, 47)
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(196, 22)
        Me.txtSearch.TabIndex = 31
        '
        'lblSearch
        '
        Me.lblSearch.BackColor = System.Drawing.Color.White
        Me.lblSearch.Location = New System.Drawing.Point(33, 50)
        Me.lblSearch.Name = "lblSearch"
        Me.lblSearch.Size = New System.Drawing.Size(81, 17)
        Me.lblSearch.TabIndex = 32
        Me.lblSearch.Text = "Search :"
        '
        'frmInventoryFreshProduce
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(36, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1662, 1003)
        Me.Controls.Add(Me.lblSearch)
        Me.Controls.Add(Me.txtSearch)
        Me.Controls.Add(Me.btnFreshProduceRefresh)
        Me.Controls.Add(Me.btnFreshProduceEdit)
        Me.Controls.Add(Me.btnFreshProduceCreate)
        Me.MaximumSize = New System.Drawing.Size(1680, 1050)
        Me.Name = "frmInventoryFreshProduce"
        Me.Text = "frmInventoryFreshProduce"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnFreshProduceCreate As Button
    Friend WithEvents btnFreshProduceEdit As Button
    Friend WithEvents btnFreshProduceRefresh As Button
    Friend WithEvents txtSearch As TextBox
    Friend WithEvents lblSearch As Label
End Class
