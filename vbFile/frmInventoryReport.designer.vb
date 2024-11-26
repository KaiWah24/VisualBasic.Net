<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmInventoryReport
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmInventoryReport))
        Me.grpRestockReport = New System.Windows.Forms.GroupBox()
        Me.picReport = New System.Windows.Forms.PictureBox()
        Me.cboFromMonth = New System.Windows.Forms.ComboBox()
        Me.lblFromMonth = New System.Windows.Forms.Label()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.btnPrint = New System.Windows.Forms.Button()
        Me.cboProductName = New System.Windows.Forms.ComboBox()
        Me.lblProductName = New System.Windows.Forms.Label()
        Me.cboFromYear = New System.Windows.Forms.ComboBox()
        Me.lblFromYear = New System.Windows.Forms.Label()
        Me.docInventoryReport = New System.Drawing.Printing.PrintDocument()
        Me.dlgPreviewInventoryReport = New System.Windows.Forms.PrintPreviewDialog()
        Me.err = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.grpRestockReport.SuspendLayout()
        CType(Me.picReport, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.err, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'grpRestockReport
        '
        Me.grpRestockReport.BackColor = System.Drawing.Color.White
        Me.grpRestockReport.Controls.Add(Me.picReport)
        Me.grpRestockReport.Controls.Add(Me.cboFromMonth)
        Me.grpRestockReport.Controls.Add(Me.lblFromMonth)
        Me.grpRestockReport.Controls.Add(Me.btnCancel)
        Me.grpRestockReport.Controls.Add(Me.btnPrint)
        Me.grpRestockReport.Controls.Add(Me.cboProductName)
        Me.grpRestockReport.Controls.Add(Me.lblProductName)
        Me.grpRestockReport.Controls.Add(Me.cboFromYear)
        Me.grpRestockReport.Controls.Add(Me.lblFromYear)
        Me.grpRestockReport.Font = New System.Drawing.Font("Modern No. 20", 10.2!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpRestockReport.Location = New System.Drawing.Point(171, 74)
        Me.grpRestockReport.Name = "grpRestockReport"
        Me.grpRestockReport.Size = New System.Drawing.Size(748, 557)
        Me.grpRestockReport.TabIndex = 0
        Me.grpRestockReport.TabStop = False
        Me.grpRestockReport.Text = "Printing Restock Report"
        '
        'picReport
        '
        Me.picReport.Image = My.Resources.Resources.loginBg
        Me.picReport.Location = New System.Drawing.Point(168, 44)
        Me.picReport.Name = "picReport"
        Me.picReport.Size = New System.Drawing.Size(411, 205)
        Me.picReport.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picReport.TabIndex = 12
        Me.picReport.TabStop = False
        '
        'cboFromMonth
        '
        Me.cboFromMonth.FormattingEnabled = True
        Me.cboFromMonth.Location = New System.Drawing.Point(323, 349)
        Me.cboFromMonth.Name = "cboFromMonth"
        Me.cboFromMonth.Size = New System.Drawing.Size(121, 28)
        Me.cboFromMonth.TabIndex = 11
        '
        'lblFromMonth
        '
        Me.lblFromMonth.AutoSize = True
        Me.lblFromMonth.Font = New System.Drawing.Font("Modern No. 20", 10.8!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFromMonth.Location = New System.Drawing.Point(164, 357)
        Me.lblFromMonth.Name = "lblFromMonth"
        Me.lblFromMonth.Size = New System.Drawing.Size(118, 21)
        Me.lblFromMonth.TabIndex = 10
        Me.lblFromMonth.Text = "From Month :"
        '
        'btnCancel
        '
        Me.btnCancel.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(36, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.btnCancel.Font = New System.Drawing.Font("Modern No. 20", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancel.ForeColor = System.Drawing.Color.White
        Me.btnCancel.Location = New System.Drawing.Point(559, 485)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(118, 44)
        Me.btnCancel.TabIndex = 9
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = False
        '
        'btnPrint
        '
        Me.btnPrint.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(36, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.btnPrint.Font = New System.Drawing.Font("Modern No. 20", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPrint.ForeColor = System.Drawing.Color.White
        Me.btnPrint.Location = New System.Drawing.Point(381, 485)
        Me.btnPrint.Name = "btnPrint"
        Me.btnPrint.Size = New System.Drawing.Size(118, 44)
        Me.btnPrint.TabIndex = 8
        Me.btnPrint.Text = "Print"
        Me.btnPrint.UseVisualStyleBackColor = False
        '
        'cboProductName
        '
        Me.cboProductName.FormattingEnabled = True
        Me.cboProductName.Location = New System.Drawing.Point(323, 399)
        Me.cboProductName.Name = "cboProductName"
        Me.cboProductName.Size = New System.Drawing.Size(121, 28)
        Me.cboProductName.TabIndex = 7
        '
        'lblProductName
        '
        Me.lblProductName.AutoSize = True
        Me.lblProductName.Font = New System.Drawing.Font("Modern No. 20", 10.8!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblProductName.Location = New System.Drawing.Point(164, 407)
        Me.lblProductName.Name = "lblProductName"
        Me.lblProductName.Size = New System.Drawing.Size(129, 21)
        Me.lblProductName.TabIndex = 6
        Me.lblProductName.Text = "Product Name :"
        '
        'cboFromYear
        '
        Me.cboFromYear.FormattingEnabled = True
        Me.cboFromYear.Location = New System.Drawing.Point(323, 298)
        Me.cboFromYear.Name = "cboFromYear"
        Me.cboFromYear.Size = New System.Drawing.Size(121, 28)
        Me.cboFromYear.TabIndex = 2
        '
        'lblFromYear
        '
        Me.lblFromYear.AutoSize = True
        Me.lblFromYear.Font = New System.Drawing.Font("Modern No. 20", 10.8!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFromYear.Location = New System.Drawing.Point(164, 306)
        Me.lblFromYear.Name = "lblFromYear"
        Me.lblFromYear.Size = New System.Drawing.Size(104, 21)
        Me.lblFromYear.TabIndex = 0
        Me.lblFromYear.Text = "From Year :"
        '
        'docInventoryReport
        '
        Me.docInventoryReport.OriginAtMargins = True
        '
        'dlgPreviewInventoryReport
        '
        Me.dlgPreviewInventoryReport.AutoScrollMargin = New System.Drawing.Size(0, 0)
        Me.dlgPreviewInventoryReport.AutoScrollMinSize = New System.Drawing.Size(0, 0)
        Me.dlgPreviewInventoryReport.ClientSize = New System.Drawing.Size(400, 300)
        Me.dlgPreviewInventoryReport.Enabled = True
        Me.dlgPreviewInventoryReport.Icon = CType(resources.GetObject("dlgPreviewInventoryReport.Icon"), System.Drawing.Icon)
        Me.dlgPreviewInventoryReport.Name = "dlgPreviewInventoryReport"
        Me.dlgPreviewInventoryReport.Visible = False
        '
        'err
        '
        Me.err.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink
        Me.err.ContainerControl = Me
        '
        'frmInventoryReport
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1054, 707)
        Me.Controls.Add(Me.grpRestockReport)
        Me.Name = "frmInventoryReport"
        Me.Text = "frmInventoryReport"
        Me.grpRestockReport.ResumeLayout(False)
        Me.grpRestockReport.PerformLayout()
        CType(Me.picReport, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.err, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents grpRestockReport As GroupBox
    Friend WithEvents btnCancel As Button
    Friend WithEvents btnPrint As Button
    Friend WithEvents cboProductName As ComboBox
    Friend WithEvents lblProductName As Label
    Friend WithEvents cboFromYear As ComboBox
    Friend WithEvents lblFromYear As Label
    Friend WithEvents picReport As PictureBox
    Friend WithEvents cboFromMonth As ComboBox
    Friend WithEvents lblFromMonth As Label
    Friend WithEvents docInventoryReport As Printing.PrintDocument
    Friend WithEvents dlgPreviewInventoryReport As PrintPreviewDialog
    Friend WithEvents err As ErrorProvider
End Class
