<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmInventoryFrozenMeat
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
        Me.btnFrozenMeatCreate = New System.Windows.Forms.Button()
        Me.btnFrozenMeatEdit = New System.Windows.Forms.Button()
        Me.btnFrozenMeatRefresh = New System.Windows.Forms.Button()
        Me.lblSearch = New System.Windows.Forms.Label()
        Me.txtSearch = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'btnFrozenMeatCreate
        '
        Me.btnFrozenMeatCreate.Font = New System.Drawing.Font("Modern No. 20", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnFrozenMeatCreate.Location = New System.Drawing.Point(654, 31)
        Me.btnFrozenMeatCreate.Name = "btnFrozenMeatCreate"
        Me.btnFrozenMeatCreate.Size = New System.Drawing.Size(116, 50)
        Me.btnFrozenMeatCreate.TabIndex = 0
        Me.btnFrozenMeatCreate.Text = "Create"
        Me.btnFrozenMeatCreate.UseVisualStyleBackColor = True
        '
        'btnFrozenMeatEdit
        '
        Me.btnFrozenMeatEdit.Font = New System.Drawing.Font("Modern No. 20", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnFrozenMeatEdit.Location = New System.Drawing.Point(788, 31)
        Me.btnFrozenMeatEdit.Name = "btnFrozenMeatEdit"
        Me.btnFrozenMeatEdit.Size = New System.Drawing.Size(116, 50)
        Me.btnFrozenMeatEdit.TabIndex = 1
        Me.btnFrozenMeatEdit.Text = "Edit"
        Me.btnFrozenMeatEdit.UseVisualStyleBackColor = True
        '
        'btnFrozenMeatRefresh
        '
        Me.btnFrozenMeatRefresh.Font = New System.Drawing.Font("Modern No. 20", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnFrozenMeatRefresh.Location = New System.Drawing.Point(922, 31)
        Me.btnFrozenMeatRefresh.Name = "btnFrozenMeatRefresh"
        Me.btnFrozenMeatRefresh.Size = New System.Drawing.Size(116, 50)
        Me.btnFrozenMeatRefresh.TabIndex = 2
        Me.btnFrozenMeatRefresh.Text = "Refresh"
        Me.btnFrozenMeatRefresh.UseVisualStyleBackColor = True
        '
        'lblSearch
        '
        Me.lblSearch.BackColor = System.Drawing.Color.White
        Me.lblSearch.Location = New System.Drawing.Point(33, 50)
        Me.lblSearch.Name = "lblSearch"
        Me.lblSearch.Size = New System.Drawing.Size(81, 17)
        Me.lblSearch.TabIndex = 38
        Me.lblSearch.Text = "Search :"
        '
        'txtSearch
        '
        Me.txtSearch.Location = New System.Drawing.Point(132, 47)
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(196, 22)
        Me.txtSearch.TabIndex = 37
        '
        'frmInventoryFrozenMeat
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(36, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1673, 450)
        Me.Controls.Add(Me.lblSearch)
        Me.Controls.Add(Me.txtSearch)
        Me.Controls.Add(Me.btnFrozenMeatRefresh)
        Me.Controls.Add(Me.btnFrozenMeatEdit)
        Me.Controls.Add(Me.btnFrozenMeatCreate)
        Me.Name = "frmInventoryFrozenMeat"
        Me.Text = "frmInventoryFrozenMeat"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnFrozenMeatCreate As Button
    Friend WithEvents btnFrozenMeatEdit As Button
    Friend WithEvents btnFrozenMeatRefresh As Button
    Friend WithEvents lblSearch As Label
    Friend WithEvents txtSearch As TextBox
End Class
