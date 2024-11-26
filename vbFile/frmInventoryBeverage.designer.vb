<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmInventoryBeverage
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
        Me.btnBeverageCreate = New System.Windows.Forms.Button()
        Me.btnBeverageEdit = New System.Windows.Forms.Button()
        Me.btnBeverageRefresh = New System.Windows.Forms.Button()
        Me.lblSearch = New System.Windows.Forms.Label()
        Me.txtSearch = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'btnBeverageCreate
        '
        Me.btnBeverageCreate.Font = New System.Drawing.Font("Modern No. 20", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBeverageCreate.Location = New System.Drawing.Point(654, 31)
        Me.btnBeverageCreate.Name = "btnBeverageCreate"
        Me.btnBeverageCreate.Size = New System.Drawing.Size(116, 50)
        Me.btnBeverageCreate.TabIndex = 0
        Me.btnBeverageCreate.Text = "Create"
        Me.btnBeverageCreate.UseVisualStyleBackColor = True
        '
        'btnBeverageEdit
        '
        Me.btnBeverageEdit.Font = New System.Drawing.Font("Modern No. 20", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBeverageEdit.Location = New System.Drawing.Point(788, 31)
        Me.btnBeverageEdit.Name = "btnBeverageEdit"
        Me.btnBeverageEdit.Size = New System.Drawing.Size(116, 50)
        Me.btnBeverageEdit.TabIndex = 1
        Me.btnBeverageEdit.Text = "Edit"
        Me.btnBeverageEdit.UseVisualStyleBackColor = True
        '
        'btnBeverageRefresh
        '
        Me.btnBeverageRefresh.Font = New System.Drawing.Font("Modern No. 20", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBeverageRefresh.Location = New System.Drawing.Point(922, 31)
        Me.btnBeverageRefresh.Name = "btnBeverageRefresh"
        Me.btnBeverageRefresh.Size = New System.Drawing.Size(116, 50)
        Me.btnBeverageRefresh.TabIndex = 2
        Me.btnBeverageRefresh.Text = "Refresh"
        Me.btnBeverageRefresh.UseVisualStyleBackColor = True
        '
        'lblSearch
        '
        Me.lblSearch.BackColor = System.Drawing.Color.White
        Me.lblSearch.Location = New System.Drawing.Point(33, 50)
        Me.lblSearch.Name = "lblSearch"
        Me.lblSearch.Size = New System.Drawing.Size(81, 17)
        Me.lblSearch.TabIndex = 36
        Me.lblSearch.Text = "Search :"
        '
        'txtSearch
        '
        Me.txtSearch.Location = New System.Drawing.Point(132, 47)
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(196, 22)
        Me.txtSearch.TabIndex = 35
        '
        'frmInventoryBeverage
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(36, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1662, 450)
        Me.Controls.Add(Me.lblSearch)
        Me.Controls.Add(Me.txtSearch)
        Me.Controls.Add(Me.btnBeverageRefresh)
        Me.Controls.Add(Me.btnBeverageEdit)
        Me.Controls.Add(Me.btnBeverageCreate)
        Me.MaximumSize = New System.Drawing.Size(1680, 1050)
        Me.Name = "frmInventoryBeverage"
        Me.Text = "frmInventoryBeverage"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnBeverageCreate As Button
    Friend WithEvents btnBeverageEdit As Button
    Friend WithEvents btnBeverageRefresh As Button
    Friend WithEvents lblSearch As Label
    Friend WithEvents txtSearch As TextBox
End Class
