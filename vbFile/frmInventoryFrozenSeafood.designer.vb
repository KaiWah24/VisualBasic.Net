<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmInventoryFrozenSeafood
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
        Me.btnFrozenSeafoodCreate = New System.Windows.Forms.Button()
        Me.btnFrozenSeafoodEdit = New System.Windows.Forms.Button()
        Me.btnFrozenSeafoodRefresh = New System.Windows.Forms.Button()
        Me.lblSearch = New System.Windows.Forms.Label()
        Me.txtSearch = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'btnFrozenSeafoodCreate
        '
        Me.btnFrozenSeafoodCreate.Font = New System.Drawing.Font("Modern No. 20", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnFrozenSeafoodCreate.Location = New System.Drawing.Point(654, 31)
        Me.btnFrozenSeafoodCreate.Name = "btnFrozenSeafoodCreate"
        Me.btnFrozenSeafoodCreate.Size = New System.Drawing.Size(116, 50)
        Me.btnFrozenSeafoodCreate.TabIndex = 0
        Me.btnFrozenSeafoodCreate.Text = "Create"
        Me.btnFrozenSeafoodCreate.UseVisualStyleBackColor = True
        '
        'btnFrozenSeafoodEdit
        '
        Me.btnFrozenSeafoodEdit.Font = New System.Drawing.Font("Modern No. 20", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnFrozenSeafoodEdit.Location = New System.Drawing.Point(788, 31)
        Me.btnFrozenSeafoodEdit.Name = "btnFrozenSeafoodEdit"
        Me.btnFrozenSeafoodEdit.Size = New System.Drawing.Size(116, 50)
        Me.btnFrozenSeafoodEdit.TabIndex = 1
        Me.btnFrozenSeafoodEdit.Text = "Edit"
        Me.btnFrozenSeafoodEdit.UseVisualStyleBackColor = True
        '
        'btnFrozenSeafoodRefresh
        '
        Me.btnFrozenSeafoodRefresh.Font = New System.Drawing.Font("Modern No. 20", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnFrozenSeafoodRefresh.Location = New System.Drawing.Point(922, 31)
        Me.btnFrozenSeafoodRefresh.Name = "btnFrozenSeafoodRefresh"
        Me.btnFrozenSeafoodRefresh.Size = New System.Drawing.Size(116, 50)
        Me.btnFrozenSeafoodRefresh.TabIndex = 2
        Me.btnFrozenSeafoodRefresh.Text = "Refresh"
        Me.btnFrozenSeafoodRefresh.UseVisualStyleBackColor = True
        '
        'lblSearch
        '
        Me.lblSearch.BackColor = System.Drawing.Color.White
        Me.lblSearch.Location = New System.Drawing.Point(33, 50)
        Me.lblSearch.Name = "lblSearch"
        Me.lblSearch.Size = New System.Drawing.Size(81, 17)
        Me.lblSearch.TabIndex = 40
        Me.lblSearch.Text = "Search :"
        '
        'txtSearch
        '
        Me.txtSearch.Location = New System.Drawing.Point(132, 47)
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(196, 22)
        Me.txtSearch.TabIndex = 39
        '
        'frmInventoryFrozenSeafood
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(36, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1643, 450)
        Me.Controls.Add(Me.lblSearch)
        Me.Controls.Add(Me.txtSearch)
        Me.Controls.Add(Me.btnFrozenSeafoodRefresh)
        Me.Controls.Add(Me.btnFrozenSeafoodEdit)
        Me.Controls.Add(Me.btnFrozenSeafoodCreate)
        Me.Name = "frmInventoryFrozenSeafood"
        Me.Text = "frmInventoryFrozenSeafood"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnFrozenSeafoodCreate As Button
    Friend WithEvents btnFrozenSeafoodEdit As Button
    Friend WithEvents btnFrozenSeafoodRefresh As Button
    Friend WithEvents lblSearch As Label
    Friend WithEvents txtSearch As TextBox
End Class
