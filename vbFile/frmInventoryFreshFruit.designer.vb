<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmInventoryFreshFruit
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
        Me.btnFreshFruitCreate = New System.Windows.Forms.Button()
        Me.btnFreshFruitEdit = New System.Windows.Forms.Button()
        Me.btnFreshFruitRefresh = New System.Windows.Forms.Button()
        Me.lblSearch = New System.Windows.Forms.Label()
        Me.txtSearch = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'btnFreshFruitCreate
        '
        Me.btnFreshFruitCreate.Font = New System.Drawing.Font("Modern No. 20", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnFreshFruitCreate.Location = New System.Drawing.Point(654, 31)
        Me.btnFreshFruitCreate.Name = "btnFreshFruitCreate"
        Me.btnFreshFruitCreate.Size = New System.Drawing.Size(116, 50)
        Me.btnFreshFruitCreate.TabIndex = 0
        Me.btnFreshFruitCreate.Text = "Create"
        Me.btnFreshFruitCreate.UseVisualStyleBackColor = True
        '
        'btnFreshFruitEdit
        '
        Me.btnFreshFruitEdit.Font = New System.Drawing.Font("Modern No. 20", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnFreshFruitEdit.Location = New System.Drawing.Point(788, 31)
        Me.btnFreshFruitEdit.Name = "btnFreshFruitEdit"
        Me.btnFreshFruitEdit.Size = New System.Drawing.Size(116, 50)
        Me.btnFreshFruitEdit.TabIndex = 1
        Me.btnFreshFruitEdit.Text = "Edit"
        Me.btnFreshFruitEdit.UseVisualStyleBackColor = True
        '
        'btnFreshFruitRefresh
        '
        Me.btnFreshFruitRefresh.Font = New System.Drawing.Font("Modern No. 20", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnFreshFruitRefresh.Location = New System.Drawing.Point(922, 31)
        Me.btnFreshFruitRefresh.Name = "btnFreshFruitRefresh"
        Me.btnFreshFruitRefresh.Size = New System.Drawing.Size(116, 50)
        Me.btnFreshFruitRefresh.TabIndex = 2
        Me.btnFreshFruitRefresh.Text = "Refresh"
        Me.btnFreshFruitRefresh.UseVisualStyleBackColor = True
        '
        'lblSearch
        '
        Me.lblSearch.BackColor = System.Drawing.Color.White
        Me.lblSearch.Location = New System.Drawing.Point(33, 50)
        Me.lblSearch.Name = "lblSearch"
        Me.lblSearch.Size = New System.Drawing.Size(81, 17)
        Me.lblSearch.TabIndex = 34
        Me.lblSearch.Text = "Search :"
        '
        'txtSearch
        '
        Me.txtSearch.Location = New System.Drawing.Point(132, 47)
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(196, 22)
        Me.txtSearch.TabIndex = 33
        '
        'frmInventoryFreshFruit
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(36, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1640, 694)
        Me.Controls.Add(Me.lblSearch)
        Me.Controls.Add(Me.txtSearch)
        Me.Controls.Add(Me.btnFreshFruitRefresh)
        Me.Controls.Add(Me.btnFreshFruitEdit)
        Me.Controls.Add(Me.btnFreshFruitCreate)
        Me.Name = "frmInventoryFreshFruit"
        Me.Text = "frmInventoryFreshFruit"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnFreshFruitCreate As Button
    Friend WithEvents btnFreshFruitEdit As Button
    Friend WithEvents btnFreshFruitRefresh As Button
    Friend WithEvents lblSearch As Label
    Friend WithEvents txtSearch As TextBox
End Class
