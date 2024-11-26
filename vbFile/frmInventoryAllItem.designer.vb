<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmInventoryAllItem
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
        Me.btnAllItemOffShelves = New System.Windows.Forms.Button()
        Me.lblSearch = New System.Windows.Forms.Label()
        Me.txtSearch = New System.Windows.Forms.TextBox()
        Me.btnAllItemRefresh = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnAllItemOffShelves
        '
        Me.btnAllItemOffShelves.Font = New System.Drawing.Font("Modern No. 20", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAllItemOffShelves.Location = New System.Drawing.Point(747, 32)
        Me.btnAllItemOffShelves.Name = "btnAllItemOffShelves"
        Me.btnAllItemOffShelves.Size = New System.Drawing.Size(141, 50)
        Me.btnAllItemOffShelves.TabIndex = 1
        Me.btnAllItemOffShelves.Text = "Off Shelves"
        Me.btnAllItemOffShelves.UseVisualStyleBackColor = True
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
        'btnAllItemRefresh
        '
        Me.btnAllItemRefresh.Font = New System.Drawing.Font("Modern No. 20", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAllItemRefresh.Location = New System.Drawing.Point(918, 32)
        Me.btnAllItemRefresh.Name = "btnAllItemRefresh"
        Me.btnAllItemRefresh.Size = New System.Drawing.Size(141, 50)
        Me.btnAllItemRefresh.TabIndex = 39
        Me.btnAllItemRefresh.Text = "Refresh"
        Me.btnAllItemRefresh.UseVisualStyleBackColor = True
        '
        'frmInventoryAllItem
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(36, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1083, 450)
        Me.Controls.Add(Me.btnAllItemRefresh)
        Me.Controls.Add(Me.lblSearch)
        Me.Controls.Add(Me.txtSearch)
        Me.Controls.Add(Me.btnAllItemOffShelves)
        Me.Name = "frmInventoryAllItem"
        Me.Text = "frmInventoryAllItem"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnAllItemOffShelves As Button
    Friend WithEvents lblSearch As Label
    Friend WithEvents txtSearch As TextBox
    Friend WithEvents btnAllItemRefresh As Button
End Class
