<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmInventory
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmInventory))
        Me.pnlCategory = New System.Windows.Forms.Panel()
        Me.btnBeverage = New System.Windows.Forms.Button()
        Me.btnFreshProduce = New System.Windows.Forms.Button()
        Me.btnFreshFruit = New System.Windows.Forms.Button()
        Me.btnAllItem = New System.Windows.Forms.Button()
        Me.btnFrozenSeafood = New System.Windows.Forms.Button()
        Me.btnFrozenMeat = New System.Windows.Forms.Button()
        Me.grpNavigationBar = New System.Windows.Forms.GroupBox()
        Me.btnReport = New System.Windows.Forms.Button()
        Me.pnlAlertBackground = New System.Windows.Forms.Panel()
        Me.pnlLabelBackGround = New System.Windows.Forms.Panel()
        Me.lblPrice = New System.Windows.Forms.Label()
        Me.lblStock = New System.Windows.Forms.Label()
        Me.lblProductName = New System.Windows.Forms.Label()
        Me.lblAlert = New System.Windows.Forms.Label()
        Me.btnRestock = New System.Windows.Forms.Button()
        Me.doc = New System.Drawing.Printing.PrintDocument()
        Me.dlgPreview = New System.Windows.Forms.PrintPreviewDialog()
        Me.lblAllItem = New System.Windows.Forms.Label()
        Me.lblFreshProduce = New System.Windows.Forms.Label()
        Me.lblFreshFruit = New System.Windows.Forms.Label()
        Me.lblFrozenSeafood = New System.Windows.Forms.Label()
        Me.lblFrozenMeat = New System.Windows.Forms.Label()
        Me.lblBeverage = New System.Windows.Forms.Label()
        Me.btnOther = New System.Windows.Forms.Button()
        Me.pnlAlertBackground.SuspendLayout()
        Me.pnlLabelBackGround.SuspendLayout()
        Me.SuspendLayout()
        '
        'pnlCategory
        '
        Me.pnlCategory.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(36, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.pnlCategory.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlCategory.Location = New System.Drawing.Point(49, 158)
        Me.pnlCategory.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.pnlCategory.Name = "pnlCategory"
        Me.pnlCategory.Size = New System.Drawing.Size(1109, 616)
        Me.pnlCategory.TabIndex = 6
        '
        'btnBeverage
        '
        Me.btnBeverage.BackColor = System.Drawing.Color.White
        Me.btnBeverage.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBeverage.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.btnBeverage.Location = New System.Drawing.Point(987, 827)
        Me.btnBeverage.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnBeverage.Name = "btnBeverage"
        Me.btnBeverage.Size = New System.Drawing.Size(141, 104)
        Me.btnBeverage.TabIndex = 5
        Me.btnBeverage.UseVisualStyleBackColor = False
        '
        'btnFreshProduce
        '
        Me.btnFreshProduce.BackColor = System.Drawing.Color.White
        Me.btnFreshProduce.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnFreshProduce.ForeColor = System.Drawing.SystemColors.Menu
        Me.btnFreshProduce.Location = New System.Drawing.Point(227, 827)
        Me.btnFreshProduce.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnFreshProduce.Name = "btnFreshProduce"
        Me.btnFreshProduce.Size = New System.Drawing.Size(141, 104)
        Me.btnFreshProduce.TabIndex = 1
        Me.btnFreshProduce.UseVisualStyleBackColor = False
        '
        'btnFreshFruit
        '
        Me.btnFreshFruit.BackColor = System.Drawing.Color.White
        Me.btnFreshFruit.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnFreshFruit.ForeColor = System.Drawing.SystemColors.InactiveBorder
        Me.btnFreshFruit.Location = New System.Drawing.Point(419, 827)
        Me.btnFreshFruit.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnFreshFruit.Name = "btnFreshFruit"
        Me.btnFreshFruit.Size = New System.Drawing.Size(141, 104)
        Me.btnFreshFruit.TabIndex = 2
        Me.btnFreshFruit.UseVisualStyleBackColor = False
        '
        'btnAllItem
        '
        Me.btnAllItem.BackColor = System.Drawing.Color.White
        Me.btnAllItem.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAllItem.ForeColor = System.Drawing.SystemColors.AppWorkspace
        Me.btnAllItem.Location = New System.Drawing.Point(49, 827)
        Me.btnAllItem.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnAllItem.Name = "btnAllItem"
        Me.btnAllItem.Size = New System.Drawing.Size(141, 104)
        Me.btnAllItem.TabIndex = 0
        Me.btnAllItem.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnAllItem.UseVisualStyleBackColor = False
        '
        'btnFrozenSeafood
        '
        Me.btnFrozenSeafood.BackColor = System.Drawing.Color.White
        Me.btnFrozenSeafood.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnFrozenSeafood.ForeColor = System.Drawing.SystemColors.InactiveBorder
        Me.btnFrozenSeafood.Location = New System.Drawing.Point(606, 827)
        Me.btnFrozenSeafood.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnFrozenSeafood.Name = "btnFrozenSeafood"
        Me.btnFrozenSeafood.Size = New System.Drawing.Size(141, 104)
        Me.btnFrozenSeafood.TabIndex = 3
        Me.btnFrozenSeafood.UseVisualStyleBackColor = False
        '
        'btnFrozenMeat
        '
        Me.btnFrozenMeat.BackColor = System.Drawing.Color.White
        Me.btnFrozenMeat.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnFrozenMeat.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.btnFrozenMeat.Location = New System.Drawing.Point(796, 827)
        Me.btnFrozenMeat.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnFrozenMeat.Name = "btnFrozenMeat"
        Me.btnFrozenMeat.Size = New System.Drawing.Size(141, 104)
        Me.btnFrozenMeat.TabIndex = 4
        Me.btnFrozenMeat.UseVisualStyleBackColor = False
        '
        'grpNavigationBar
        '
        Me.grpNavigationBar.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(36, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.grpNavigationBar.Location = New System.Drawing.Point(1, -10)
        Me.grpNavigationBar.MaximumSize = New System.Drawing.Size(1680, 141)
        Me.grpNavigationBar.Name = "grpNavigationBar"
        Me.grpNavigationBar.Size = New System.Drawing.Size(1680, 141)
        Me.grpNavigationBar.TabIndex = 9
        Me.grpNavigationBar.TabStop = False
        '
        'btnReport
        '
        Me.btnReport.BackColor = System.Drawing.Color.Transparent
        Me.btnReport.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnReport.Location = New System.Drawing.Point(1326, 920)
        Me.btnReport.Name = "btnReport"
        Me.btnReport.Size = New System.Drawing.Size(118, 65)
        Me.btnReport.TabIndex = 0
        Me.btnReport.Text = "Report"
        Me.btnReport.UseVisualStyleBackColor = False
        '
        'pnlAlertBackground
        '
        Me.pnlAlertBackground.BackColor = System.Drawing.Color.White
        Me.pnlAlertBackground.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlAlertBackground.Controls.Add(Me.pnlLabelBackGround)
        Me.pnlAlertBackground.Controls.Add(Me.lblAlert)
        Me.pnlAlertBackground.Location = New System.Drawing.Point(1188, 158)
        Me.pnlAlertBackground.Name = "pnlAlertBackground"
        Me.pnlAlertBackground.Size = New System.Drawing.Size(391, 753)
        Me.pnlAlertBackground.TabIndex = 10
        '
        'pnlLabelBackGround
        '
        Me.pnlLabelBackGround.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(244, Byte), Integer))
        Me.pnlLabelBackGround.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlLabelBackGround.Controls.Add(Me.lblPrice)
        Me.pnlLabelBackGround.Controls.Add(Me.lblStock)
        Me.pnlLabelBackGround.Controls.Add(Me.lblProductName)
        Me.pnlLabelBackGround.Location = New System.Drawing.Point(-1, 92)
        Me.pnlLabelBackGround.Name = "pnlLabelBackGround"
        Me.pnlLabelBackGround.Size = New System.Drawing.Size(433, 68)
        Me.pnlLabelBackGround.TabIndex = 1
        '
        'lblPrice
        '
        Me.lblPrice.Font = New System.Drawing.Font("Century", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPrice.Location = New System.Drawing.Point(342, 23)
        Me.lblPrice.Name = "lblPrice"
        Me.lblPrice.Size = New System.Drawing.Size(100, 23)
        Me.lblPrice.TabIndex = 2
        Me.lblPrice.Text = "Price"
        '
        'lblStock
        '
        Me.lblStock.Font = New System.Drawing.Font("Century", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStock.Location = New System.Drawing.Point(120, 23)
        Me.lblStock.Name = "lblStock"
        Me.lblStock.Size = New System.Drawing.Size(185, 23)
        Me.lblStock.TabIndex = 1
        Me.lblStock.Text = "Remaining Stock"
        '
        'lblProductName
        '
        Me.lblProductName.Font = New System.Drawing.Font("Century", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblProductName.Location = New System.Drawing.Point(30, 23)
        Me.lblProductName.Name = "lblProductName"
        Me.lblProductName.Size = New System.Drawing.Size(100, 23)
        Me.lblProductName.TabIndex = 0
        Me.lblProductName.Text = "Name "
        '
        'lblAlert
        '
        Me.lblAlert.AutoSize = True
        Me.lblAlert.Font = New System.Drawing.Font("Showcard Gothic", 19.8!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAlert.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.lblAlert.Location = New System.Drawing.Point(139, 29)
        Me.lblAlert.Name = "lblAlert"
        Me.lblAlert.Size = New System.Drawing.Size(112, 33)
        Me.lblAlert.TabIndex = 0
        Me.lblAlert.Text = "Alert !"
        '
        'btnRestock
        '
        Me.btnRestock.BackColor = System.Drawing.Color.Transparent
        Me.btnRestock.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnRestock.Location = New System.Drawing.Point(1461, 920)
        Me.btnRestock.Name = "btnRestock"
        Me.btnRestock.Size = New System.Drawing.Size(118, 65)
        Me.btnRestock.TabIndex = 11
        Me.btnRestock.Text = "Restock"
        Me.btnRestock.UseVisualStyleBackColor = False
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
        'lblAllItem
        '
        Me.lblAllItem.AutoSize = True
        Me.lblAllItem.Font = New System.Drawing.Font("Showcard Gothic", 10.2!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAllItem.Location = New System.Drawing.Point(73, 964)
        Me.lblAllItem.Name = "lblAllItem"
        Me.lblAllItem.Size = New System.Drawing.Size(67, 18)
        Me.lblAllItem.TabIndex = 12
        Me.lblAllItem.Text = "All Item"
        '
        'lblFreshProduce
        '
        Me.lblFreshProduce.AutoSize = True
        Me.lblFreshProduce.Font = New System.Drawing.Font("Showcard Gothic", 10.2!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFreshProduce.Location = New System.Drawing.Point(223, 964)
        Me.lblFreshProduce.Name = "lblFreshProduce"
        Me.lblFreshProduce.Size = New System.Drawing.Size(119, 18)
        Me.lblFreshProduce.TabIndex = 13
        Me.lblFreshProduce.Text = "FreshProduce"
        '
        'lblFreshFruit
        '
        Me.lblFreshFruit.AutoSize = True
        Me.lblFreshFruit.Font = New System.Drawing.Font("Showcard Gothic", 10.2!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFreshFruit.Location = New System.Drawing.Point(439, 964)
        Me.lblFreshFruit.Name = "lblFreshFruit"
        Me.lblFreshFruit.Size = New System.Drawing.Size(95, 18)
        Me.lblFreshFruit.TabIndex = 14
        Me.lblFreshFruit.Text = "FreshFruit"
        '
        'lblFrozenSeafood
        '
        Me.lblFrozenSeafood.AutoSize = True
        Me.lblFrozenSeafood.Font = New System.Drawing.Font("Showcard Gothic", 10.2!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFrozenSeafood.Location = New System.Drawing.Point(602, 964)
        Me.lblFrozenSeafood.Name = "lblFrozenSeafood"
        Me.lblFrozenSeafood.Size = New System.Drawing.Size(126, 18)
        Me.lblFrozenSeafood.TabIndex = 15
        Me.lblFrozenSeafood.Text = "FrozenSeafood"
        '
        'lblFrozenMeat
        '
        Me.lblFrozenMeat.AutoSize = True
        Me.lblFrozenMeat.Font = New System.Drawing.Font("Showcard Gothic", 10.2!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFrozenMeat.Location = New System.Drawing.Point(804, 964)
        Me.lblFrozenMeat.Name = "lblFrozenMeat"
        Me.lblFrozenMeat.Size = New System.Drawing.Size(99, 18)
        Me.lblFrozenMeat.TabIndex = 16
        Me.lblFrozenMeat.Text = "FrozenMeat"
        '
        'lblBeverage
        '
        Me.lblBeverage.AutoSize = True
        Me.lblBeverage.Font = New System.Drawing.Font("Showcard Gothic", 10.2!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBeverage.Location = New System.Drawing.Point(1012, 964)
        Me.lblBeverage.Name = "lblBeverage"
        Me.lblBeverage.Size = New System.Drawing.Size(80, 18)
        Me.lblBeverage.TabIndex = 17
        Me.lblBeverage.Text = "Beverage"
        '
        'btnOther
        '
        Me.btnOther.BackColor = System.Drawing.Color.Transparent
        Me.btnOther.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnOther.Location = New System.Drawing.Point(1188, 920)
        Me.btnOther.Name = "btnOther"
        Me.btnOther.Size = New System.Drawing.Size(118, 65)
        Me.btnOther.TabIndex = 18
        Me.btnOther.Text = "Other"
        Me.btnOther.UseVisualStyleBackColor = False
        '
        'frmInventory
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(244, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1662, 1003)
        Me.Controls.Add(Me.btnOther)
        Me.Controls.Add(Me.lblBeverage)
        Me.Controls.Add(Me.lblFrozenMeat)
        Me.Controls.Add(Me.lblFrozenSeafood)
        Me.Controls.Add(Me.lblFreshFruit)
        Me.Controls.Add(Me.lblFreshProduce)
        Me.Controls.Add(Me.lblAllItem)
        Me.Controls.Add(Me.btnRestock)
        Me.Controls.Add(Me.btnReport)
        Me.Controls.Add(Me.pnlAlertBackground)
        Me.Controls.Add(Me.grpNavigationBar)
        Me.Controls.Add(Me.btnBeverage)
        Me.Controls.Add(Me.btnFreshProduce)
        Me.Controls.Add(Me.btnFreshFruit)
        Me.Controls.Add(Me.btnAllItem)
        Me.Controls.Add(Me.pnlCategory)
        Me.Controls.Add(Me.btnFrozenSeafood)
        Me.Controls.Add(Me.btnFrozenMeat)
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.MaximumSize = New System.Drawing.Size(1680, 1050)
        Me.Name = "frmInventory"
        Me.Text = "frmInventory"
        Me.pnlAlertBackground.ResumeLayout(False)
        Me.pnlAlertBackground.PerformLayout()
        Me.pnlLabelBackGround.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnAllItem As Button
    Friend WithEvents btnFreshProduce As Button
    Friend WithEvents btnFreshFruit As Button
    Friend WithEvents btnFrozenSeafood As Button
    Friend WithEvents btnFrozenMeat As Button
    Friend WithEvents btnBeverage As Button
    Friend WithEvents pnlCategory As Panel
    Friend WithEvents grpNavigationBar As GroupBox
    Friend WithEvents pnlAlertBackground As Panel
    Friend WithEvents lblAlert As Label
    Friend WithEvents pnlLabelBackGround As Panel
    Friend WithEvents lblStock As Label
    Friend WithEvents lblProductName As Label
    Friend WithEvents lblPrice As Label
    Friend WithEvents btnReport As Button
    Friend WithEvents btnRestock As Button
    Friend WithEvents doc As Printing.PrintDocument
    Friend WithEvents dlgPreview As PrintPreviewDialog
    Friend WithEvents lblAllItem As Label
    Friend WithEvents lblFreshProduce As Label
    Friend WithEvents lblFreshFruit As Label
    Friend WithEvents lblFrozenSeafood As Label
    Friend WithEvents lblFrozenMeat As Label
    Friend WithEvents lblBeverage As Label
    Friend WithEvents btnOther As Button
End Class
