<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Main
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Main))
        Me.ToolTip = New System.Windows.Forms.ToolTip(Me.components)
        Me.picExit = New System.Windows.Forms.PictureBox()
        Me.grpSales = New System.Windows.Forms.GroupBox()
        Me.picSales = New System.Windows.Forms.PictureBox()
        Me.lblSales = New System.Windows.Forms.Label()
        Me.picInventory = New System.Windows.Forms.PictureBox()
        Me.lblInventory = New System.Windows.Forms.Label()
        Me.grpProfile = New System.Windows.Forms.GroupBox()
        Me.picProfile = New System.Windows.Forms.PictureBox()
        Me.lblProfile = New System.Windows.Forms.Label()
        Me.picPromotion = New System.Windows.Forms.PictureBox()
        Me.lblPromotion = New System.Windows.Forms.Label()
        Me.lblStaff = New System.Windows.Forms.Label()
        Me.grpCustomer = New System.Windows.Forms.GroupBox()
        Me.picCustomer = New System.Windows.Forms.PictureBox()
        Me.lblCustomer = New System.Windows.Forms.Label()
        Me.grpStaff = New System.Windows.Forms.GroupBox()
        Me.picStaff = New System.Windows.Forms.PictureBox()
        Me.grpPromotion = New System.Windows.Forms.GroupBox()
        Me.lblWelcome = New System.Windows.Forms.Label()
        Me.grpInventory = New System.Windows.Forms.GroupBox()
        CType(Me.picExit, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpSales.SuspendLayout()
        CType(Me.picSales, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picInventory, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpProfile.SuspendLayout()
        CType(Me.picProfile, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picPromotion, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpCustomer.SuspendLayout()
        CType(Me.picCustomer, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpStaff.SuspendLayout()
        CType(Me.picStaff, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpPromotion.SuspendLayout()
        Me.grpInventory.SuspendLayout()
        Me.SuspendLayout()
        '
        'ToolTip
        '
        Me.ToolTip.Tag = ""
        '
        'picExit
        '
        Me.picExit.BackColor = System.Drawing.Color.Transparent
        Me.picExit.Cursor = System.Windows.Forms.Cursors.Hand
        Me.picExit.Image = My.Resources.Resources.logout__2_
        Me.picExit.Location = New System.Drawing.Point(1563, 13)
        Me.picExit.Name = "picExit"
        Me.picExit.Size = New System.Drawing.Size(60, 51)
        Me.picExit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picExit.TabIndex = 68
        Me.picExit.TabStop = False
        Me.ToolTip.SetToolTip(Me.picExit, "Logout")
        '
        'grpSales
        '
        Me.grpSales.Controls.Add(Me.picSales)
        Me.grpSales.Controls.Add(Me.lblSales)
        Me.grpSales.Cursor = System.Windows.Forms.Cursors.Hand
        Me.grpSales.Location = New System.Drawing.Point(364, 328)
        Me.grpSales.Name = "grpSales"
        Me.grpSales.Size = New System.Drawing.Size(312, 257)
        Me.grpSales.TabIndex = 63
        Me.grpSales.TabStop = False
        '
        'picSales
        '
        Me.picSales.Image = CType(resources.GetObject("picSales.Image"), System.Drawing.Image)
        Me.picSales.Location = New System.Drawing.Point(72, 46)
        Me.picSales.Name = "picSales"
        Me.picSales.Size = New System.Drawing.Size(150, 124)
        Me.picSales.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picSales.TabIndex = 1
        Me.picSales.TabStop = False
        '
        'lblSales
        '
        Me.lblSales.AutoSize = True
        Me.lblSales.Font = New System.Drawing.Font("Arial Rounded MT Bold", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSales.Location = New System.Drawing.Point(109, 198)
        Me.lblSales.Name = "lblSales"
        Me.lblSales.Size = New System.Drawing.Size(95, 34)
        Me.lblSales.TabIndex = 0
        Me.lblSales.Text = "Sales"
        '
        'picInventory
        '
        Me.picInventory.Image = CType(resources.GetObject("picInventory.Image"), System.Drawing.Image)
        Me.picInventory.Location = New System.Drawing.Point(81, 46)
        Me.picInventory.Name = "picInventory"
        Me.picInventory.Size = New System.Drawing.Size(150, 124)
        Me.picInventory.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picInventory.TabIndex = 2
        Me.picInventory.TabStop = False
        '
        'lblInventory
        '
        Me.lblInventory.AutoSize = True
        Me.lblInventory.Font = New System.Drawing.Font("Arial Rounded MT Bold", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblInventory.Location = New System.Drawing.Point(80, 198)
        Me.lblInventory.Name = "lblInventory"
        Me.lblInventory.Size = New System.Drawing.Size(152, 34)
        Me.lblInventory.TabIndex = 1
        Me.lblInventory.Text = "Inventory"
        '
        'grpProfile
        '
        Me.grpProfile.Controls.Add(Me.picProfile)
        Me.grpProfile.Controls.Add(Me.lblProfile)
        Me.grpProfile.Cursor = System.Windows.Forms.Cursors.Hand
        Me.grpProfile.Location = New System.Drawing.Point(1003, 591)
        Me.grpProfile.Name = "grpProfile"
        Me.grpProfile.Size = New System.Drawing.Size(312, 257)
        Me.grpProfile.TabIndex = 64
        Me.grpProfile.TabStop = False
        '
        'picProfile
        '
        Me.picProfile.BackColor = System.Drawing.SystemColors.Control
        Me.picProfile.Image = CType(resources.GetObject("picProfile.Image"), System.Drawing.Image)
        Me.picProfile.Location = New System.Drawing.Point(81, 59)
        Me.picProfile.Name = "picProfile"
        Me.picProfile.Size = New System.Drawing.Size(150, 124)
        Me.picProfile.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picProfile.TabIndex = 5
        Me.picProfile.TabStop = False
        '
        'lblProfile
        '
        Me.lblProfile.AutoSize = True
        Me.lblProfile.Font = New System.Drawing.Font("Arial Rounded MT Bold", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblProfile.Location = New System.Drawing.Point(106, 197)
        Me.lblProfile.Name = "lblProfile"
        Me.lblProfile.Size = New System.Drawing.Size(110, 34)
        Me.lblProfile.TabIndex = 3
        Me.lblProfile.Text = "Profile"
        '
        'picPromotion
        '
        Me.picPromotion.Image = CType(resources.GetObject("picPromotion.Image"), System.Drawing.Image)
        Me.picPromotion.Location = New System.Drawing.Point(81, 46)
        Me.picPromotion.Name = "picPromotion"
        Me.picPromotion.Size = New System.Drawing.Size(150, 124)
        Me.picPromotion.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picPromotion.TabIndex = 3
        Me.picPromotion.TabStop = False
        '
        'lblPromotion
        '
        Me.lblPromotion.AutoSize = True
        Me.lblPromotion.Font = New System.Drawing.Font("Arial Rounded MT Bold", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPromotion.Location = New System.Drawing.Point(75, 198)
        Me.lblPromotion.Name = "lblPromotion"
        Me.lblPromotion.Size = New System.Drawing.Size(166, 34)
        Me.lblPromotion.TabIndex = 2
        Me.lblPromotion.Text = "Promotion"
        '
        'lblStaff
        '
        Me.lblStaff.AutoSize = True
        Me.lblStaff.Font = New System.Drawing.Font("Arial Rounded MT Bold", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStaff.Location = New System.Drawing.Point(109, 197)
        Me.lblStaff.Name = "lblStaff"
        Me.lblStaff.Size = New System.Drawing.Size(100, 34)
        Me.lblStaff.TabIndex = 1
        Me.lblStaff.Text = "Staffs"
        '
        'grpCustomer
        '
        Me.grpCustomer.Controls.Add(Me.picCustomer)
        Me.grpCustomer.Controls.Add(Me.lblCustomer)
        Me.grpCustomer.Cursor = System.Windows.Forms.Cursors.Hand
        Me.grpCustomer.Location = New System.Drawing.Point(682, 591)
        Me.grpCustomer.Name = "grpCustomer"
        Me.grpCustomer.Size = New System.Drawing.Size(312, 257)
        Me.grpCustomer.TabIndex = 65
        Me.grpCustomer.TabStop = False
        '
        'picCustomer
        '
        Me.picCustomer.Image = CType(resources.GetObject("picCustomer.Image"), System.Drawing.Image)
        Me.picCustomer.Location = New System.Drawing.Point(81, 59)
        Me.picCustomer.Name = "picCustomer"
        Me.picCustomer.Size = New System.Drawing.Size(150, 124)
        Me.picCustomer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picCustomer.TabIndex = 3
        Me.picCustomer.TabStop = False
        '
        'lblCustomer
        '
        Me.lblCustomer.AutoSize = True
        Me.lblCustomer.Font = New System.Drawing.Font("Arial Rounded MT Bold", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCustomer.Location = New System.Drawing.Point(75, 197)
        Me.lblCustomer.Name = "lblCustomer"
        Me.lblCustomer.Size = New System.Drawing.Size(174, 34)
        Me.lblCustomer.TabIndex = 2
        Me.lblCustomer.Text = "Customers"
        '
        'grpStaff
        '
        Me.grpStaff.Controls.Add(Me.picStaff)
        Me.grpStaff.Controls.Add(Me.lblStaff)
        Me.grpStaff.Cursor = System.Windows.Forms.Cursors.Hand
        Me.grpStaff.Location = New System.Drawing.Point(364, 591)
        Me.grpStaff.Name = "grpStaff"
        Me.grpStaff.Size = New System.Drawing.Size(312, 257)
        Me.grpStaff.TabIndex = 61
        Me.grpStaff.TabStop = False
        '
        'picStaff
        '
        Me.picStaff.Image = CType(resources.GetObject("picStaff.Image"), System.Drawing.Image)
        Me.picStaff.Location = New System.Drawing.Point(85, 59)
        Me.picStaff.Name = "picStaff"
        Me.picStaff.Size = New System.Drawing.Size(150, 124)
        Me.picStaff.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picStaff.TabIndex = 2
        Me.picStaff.TabStop = False
        '
        'grpPromotion
        '
        Me.grpPromotion.Controls.Add(Me.picPromotion)
        Me.grpPromotion.Controls.Add(Me.lblPromotion)
        Me.grpPromotion.Cursor = System.Windows.Forms.Cursors.Hand
        Me.grpPromotion.Location = New System.Drawing.Point(1003, 328)
        Me.grpPromotion.Name = "grpPromotion"
        Me.grpPromotion.Size = New System.Drawing.Size(312, 257)
        Me.grpPromotion.TabIndex = 66
        Me.grpPromotion.TabStop = False
        '
        'lblWelcome
        '
        Me.lblWelcome.BackColor = System.Drawing.Color.Transparent
        Me.lblWelcome.Font = New System.Drawing.Font("Arial Rounded MT Bold", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblWelcome.ForeColor = System.Drawing.Color.Black
        Me.lblWelcome.Location = New System.Drawing.Point(364, 204)
        Me.lblWelcome.Name = "lblWelcome"
        Me.lblWelcome.Size = New System.Drawing.Size(951, 79)
        Me.lblWelcome.TabIndex = 67
        Me.lblWelcome.Text = "Welcome "
        Me.lblWelcome.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'grpInventory
        '
        Me.grpInventory.Controls.Add(Me.picInventory)
        Me.grpInventory.Controls.Add(Me.lblInventory)
        Me.grpInventory.Cursor = System.Windows.Forms.Cursors.Hand
        Me.grpInventory.Location = New System.Drawing.Point(682, 328)
        Me.grpInventory.Name = "grpInventory"
        Me.grpInventory.Size = New System.Drawing.Size(312, 257)
        Me.grpInventory.TabIndex = 62
        Me.grpInventory.TabStop = False
        '
        'Main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = My.Resources.Resources.shopping_cart_filled_with_food_and_drinks_and_supermarket_shelves_in_the_background_grocery_shopping_concept_created_with_generative_ai_technology_free_photo
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1662, 1003)
        Me.Controls.Add(Me.grpSales)
        Me.Controls.Add(Me.grpProfile)
        Me.Controls.Add(Me.picExit)
        Me.Controls.Add(Me.grpCustomer)
        Me.Controls.Add(Me.grpStaff)
        Me.Controls.Add(Me.grpPromotion)
        Me.Controls.Add(Me.lblWelcome)
        Me.Controls.Add(Me.grpInventory)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(1680, 1050)
        Me.Name = "Main"
        Me.Text = "main"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.picExit, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpSales.ResumeLayout(False)
        Me.grpSales.PerformLayout()
        CType(Me.picSales, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picInventory, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpProfile.ResumeLayout(False)
        Me.grpProfile.PerformLayout()
        CType(Me.picProfile, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picPromotion, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpCustomer.ResumeLayout(False)
        Me.grpCustomer.PerformLayout()
        CType(Me.picCustomer, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpStaff.ResumeLayout(False)
        Me.grpStaff.PerformLayout()
        CType(Me.picStaff, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpPromotion.ResumeLayout(False)
        Me.grpPromotion.PerformLayout()
        Me.grpInventory.ResumeLayout(False)
        Me.grpInventory.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ToolTip As ToolTip
    Friend WithEvents picExit As PictureBox
    Friend WithEvents grpSales As GroupBox
    Friend WithEvents picSales As PictureBox
    Friend WithEvents lblSales As Label
    Friend WithEvents picInventory As PictureBox
    Friend WithEvents lblInventory As Label
    Friend WithEvents grpProfile As GroupBox
    Friend WithEvents picProfile As PictureBox
    Friend WithEvents lblProfile As Label
    Friend WithEvents picPromotion As PictureBox
    Friend WithEvents lblPromotion As Label
    Friend WithEvents lblStaff As Label
    Friend WithEvents grpCustomer As GroupBox
    Friend WithEvents picCustomer As PictureBox
    Friend WithEvents lblCustomer As Label
    Friend WithEvents grpStaff As GroupBox
    Friend WithEvents picStaff As PictureBox
    Friend WithEvents grpPromotion As GroupBox
    Friend WithEvents lblWelcome As Label
    Friend WithEvents grpInventory As GroupBox
End Class
