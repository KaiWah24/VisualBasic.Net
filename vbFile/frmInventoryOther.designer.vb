<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmInventoryOther
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
        Me.lblSearch = New System.Windows.Forms.Label()
        Me.txtSearch = New System.Windows.Forms.TextBox()
        Me.btnOtherRefresh = New System.Windows.Forms.Button()
        Me.btnOtherEdit = New System.Windows.Forms.Button()
        Me.btnOtherCreate = New System.Windows.Forms.Button()
        Me.SuspendLayout()
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
        'btnOtherRefresh
        '
        Me.btnOtherRefresh.Font = New System.Drawing.Font("Modern No. 20", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnOtherRefresh.Location = New System.Drawing.Point(922, 31)
        Me.btnOtherRefresh.Name = "btnOtherRefresh"
        Me.btnOtherRefresh.Size = New System.Drawing.Size(116, 50)
        Me.btnOtherRefresh.TabIndex = 41
        Me.btnOtherRefresh.Text = "Refresh"
        Me.btnOtherRefresh.UseVisualStyleBackColor = True
        '
        'btnOtherEdit
        '
        Me.btnOtherEdit.Font = New System.Drawing.Font("Modern No. 20", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnOtherEdit.Location = New System.Drawing.Point(788, 31)
        Me.btnOtherEdit.Name = "btnOtherEdit"
        Me.btnOtherEdit.Size = New System.Drawing.Size(116, 50)
        Me.btnOtherEdit.TabIndex = 40
        Me.btnOtherEdit.Text = "Edit"
        Me.btnOtherEdit.UseVisualStyleBackColor = True
        '
        'btnOtherCreate
        '
        Me.btnOtherCreate.Font = New System.Drawing.Font("Modern No. 20", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnOtherCreate.Location = New System.Drawing.Point(654, 31)
        Me.btnOtherCreate.Name = "btnOtherCreate"
        Me.btnOtherCreate.Size = New System.Drawing.Size(116, 50)
        Me.btnOtherCreate.TabIndex = 39
        Me.btnOtherCreate.Text = "Create"
        Me.btnOtherCreate.UseVisualStyleBackColor = True
        '
        'frmInventoryOther
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(36, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1261, 450)
        Me.Controls.Add(Me.btnOtherRefresh)
        Me.Controls.Add(Me.btnOtherEdit)
        Me.Controls.Add(Me.btnOtherCreate)
        Me.Controls.Add(Me.lblSearch)
        Me.Controls.Add(Me.txtSearch)
        Me.MaximumSize = New System.Drawing.Size(1680, 1050)
        Me.Name = "frmInventoryOther"
        Me.Text = "frmInventoryOther"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblSearch As Label
    Friend WithEvents txtSearch As TextBox
    Friend WithEvents btnOtherRefresh As Button
    Friend WithEvents btnOtherEdit As Button
    Friend WithEvents btnOtherCreate As Button
End Class
