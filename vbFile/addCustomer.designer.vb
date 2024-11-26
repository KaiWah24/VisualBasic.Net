<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class addCustomer
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(addCustomer))
        Me.lbl11 = New System.Windows.Forms.Label()
        Me.lblDateJoined = New System.Windows.Forms.Label()
        Me.lblCustomerID = New System.Windows.Forms.Label()
        Me.lblMembershipTier = New System.Windows.Forms.Label()
        Me.lblName = New System.Windows.Forms.Label()
        Me.txtCustName = New System.Windows.Forms.TextBox()
        Me.lblDOB = New System.Windows.Forms.Label()
        Me.lblGender = New System.Windows.Forms.Label()
        Me.cboTier = New System.Windows.Forms.ComboBox()
        Me.Label = New System.Windows.Forms.Label()
        Me.lblCustAge = New System.Windows.Forms.Label()
        Me.lblPresentAddress = New System.Windows.Forms.Label()
        Me.txtPresentAdd = New System.Windows.Forms.TextBox()
        Me.txtPermanentAdd = New System.Windows.Forms.TextBox()
        Me.lblPermanentAdd = New System.Windows.Forms.Label()
        Me.btnApplyAddress = New System.Windows.Forms.Button()
        Me.lblCreateBy = New System.Windows.Forms.Label()
        Me.cboStaff = New System.Windows.Forms.ComboBox()
        Me.btnCreate = New System.Windows.Forms.Button()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.lblEmail = New System.Windows.Forms.Label()
        Me.txtEmail = New System.Windows.Forms.TextBox()
        Me.grpAddCustomer = New System.Windows.Forms.GroupBox()
        Me.mskCustPhone = New System.Windows.Forms.MaskedTextBox()
        Me.txtPoints = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.radFemale = New System.Windows.Forms.RadioButton()
        Me.radMale = New System.Windows.Forms.RadioButton()
        Me.dtpDOB = New System.Windows.Forms.DateTimePicker()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.cboStatus = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.dtpDOJ = New System.Windows.Forms.DateTimePicker()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.ToolTip2 = New System.Windows.Forms.ToolTip(Me.components)
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.ErrorProvider2 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.ErrorProvider3 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.ErrorProvider4 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.grpAddCustomer.SuspendLayout()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ErrorProvider2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ErrorProvider3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ErrorProvider4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lbl11
        '
        Me.lbl11.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl11.Location = New System.Drawing.Point(67, 63)
        Me.lbl11.Name = "lbl11"
        Me.lbl11.Size = New System.Drawing.Size(143, 29)
        Me.lbl11.TabIndex = 0
        Me.lbl11.Text = "Customer ID : "
        Me.lbl11.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblDateJoined
        '
        Me.lblDateJoined.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDateJoined.Location = New System.Drawing.Point(376, 61)
        Me.lblDateJoined.Name = "lblDateJoined"
        Me.lblDateJoined.Size = New System.Drawing.Size(141, 30)
        Me.lblDateJoined.TabIndex = 4
        Me.lblDateJoined.Text = "Date Joined : "
        Me.lblDateJoined.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lblCustomerID
        '
        Me.lblCustomerID.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblCustomerID.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCustomerID.Location = New System.Drawing.Point(216, 60)
        Me.lblCustomerID.Name = "lblCustomerID"
        Me.lblCustomerID.Size = New System.Drawing.Size(119, 32)
        Me.lblCustomerID.TabIndex = 6
        Me.lblCustomerID.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'lblMembershipTier
        '
        Me.lblMembershipTier.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMembershipTier.Location = New System.Drawing.Point(647, 227)
        Me.lblMembershipTier.Name = "lblMembershipTier"
        Me.lblMembershipTier.Size = New System.Drawing.Size(191, 25)
        Me.lblMembershipTier.TabIndex = 7
        Me.lblMembershipTier.Text = "Membership Tier : "
        Me.lblMembershipTier.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblName
        '
        Me.lblName.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblName.Location = New System.Drawing.Point(128, 113)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(82, 28)
        Me.lblName.TabIndex = 9
        Me.lblName.Text = "Name : "
        Me.lblName.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtCustName
        '
        Me.txtCustName.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCustName.Location = New System.Drawing.Point(216, 114)
        Me.txtCustName.Name = "txtCustName"
        Me.txtCustName.Size = New System.Drawing.Size(622, 31)
        Me.txtCustName.TabIndex = 10
        Me.ToolTip1.SetToolTip(Me.txtCustName, "Please enter your name")
        '
        'lblDOB
        '
        Me.lblDOB.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDOB.Location = New System.Drawing.Point(54, 220)
        Me.lblDOB.Name = "lblDOB"
        Me.lblDOB.Size = New System.Drawing.Size(161, 27)
        Me.lblDOB.TabIndex = 11
        Me.lblDOB.Text = "Date Of Birth : "
        Me.lblDOB.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblGender
        '
        Me.lblGender.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblGender.Location = New System.Drawing.Point(868, 113)
        Me.lblGender.Name = "lblGender"
        Me.lblGender.Size = New System.Drawing.Size(100, 28)
        Me.lblGender.TabIndex = 13
        Me.lblGender.Text = "Gender : "
        Me.lblGender.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'cboTier
        '
        Me.cboTier.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboTier.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboTier.FormattingEnabled = True
        Me.cboTier.Items.AddRange(New Object() {"Standard Tier", "Silver Tier", "Gold Tier", "Platinum Tier", "DIamond Tier"})
        Me.cboTier.Location = New System.Drawing.Point(831, 224)
        Me.cboTier.Name = "cboTier"
        Me.cboTier.Size = New System.Drawing.Size(190, 33)
        Me.cboTier.TabIndex = 15
        '
        'Label
        '
        Me.Label.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label.Location = New System.Drawing.Point(435, 224)
        Me.Label.Name = "Label"
        Me.Label.Size = New System.Drawing.Size(69, 28)
        Me.Label.TabIndex = 16
        Me.Label.Text = "Age : "
        Me.Label.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lblCustAge
        '
        Me.lblCustAge.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblCustAge.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCustAge.Location = New System.Drawing.Point(510, 224)
        Me.lblCustAge.Name = "lblCustAge"
        Me.lblCustAge.Size = New System.Drawing.Size(130, 33)
        Me.lblCustAge.TabIndex = 17
        Me.lblCustAge.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblPresentAddress
        '
        Me.lblPresentAddress.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPresentAddress.Location = New System.Drawing.Point(6, 282)
        Me.lblPresentAddress.Name = "lblPresentAddress"
        Me.lblPresentAddress.Size = New System.Drawing.Size(211, 47)
        Me.lblPresentAddress.TabIndex = 18
        Me.lblPresentAddress.Text = "Present Address : "
        Me.lblPresentAddress.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'txtPresentAdd
        '
        Me.txtPresentAdd.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPresentAdd.Location = New System.Drawing.Point(219, 282)
        Me.txtPresentAdd.Multiline = True
        Me.txtPresentAdd.Name = "txtPresentAdd"
        Me.txtPresentAdd.Size = New System.Drawing.Size(421, 188)
        Me.txtPresentAdd.TabIndex = 19
        Me.txtPresentAdd.Text = "No 9 Taman sri Rampai"
        '
        'txtPermanentAdd
        '
        Me.txtPermanentAdd.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPermanentAdd.Location = New System.Drawing.Point(892, 279)
        Me.txtPermanentAdd.Multiline = True
        Me.txtPermanentAdd.Name = "txtPermanentAdd"
        Me.txtPermanentAdd.Size = New System.Drawing.Size(424, 188)
        Me.txtPermanentAdd.TabIndex = 21
        '
        'lblPermanentAdd
        '
        Me.lblPermanentAdd.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPermanentAdd.Location = New System.Drawing.Point(668, 280)
        Me.lblPermanentAdd.Name = "lblPermanentAdd"
        Me.lblPermanentAdd.Size = New System.Drawing.Size(218, 49)
        Me.lblPermanentAdd.TabIndex = 20
        Me.lblPermanentAdd.Text = "Permanent Address : "
        Me.lblPermanentAdd.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'btnApplyAddress
        '
        Me.btnApplyAddress.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(36, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.btnApplyAddress.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnApplyAddress.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnApplyAddress.Location = New System.Drawing.Point(1096, 481)
        Me.btnApplyAddress.Name = "btnApplyAddress"
        Me.btnApplyAddress.Size = New System.Drawing.Size(220, 38)
        Me.btnApplyAddress.TabIndex = 22
        Me.btnApplyAddress.Text = "Same As Present"
        Me.btnApplyAddress.UseVisualStyleBackColor = False
        '
        'lblCreateBy
        '
        Me.lblCreateBy.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCreateBy.Location = New System.Drawing.Point(92, 485)
        Me.lblCreateBy.Name = "lblCreateBy"
        Me.lblCreateBy.Size = New System.Drawing.Size(123, 34)
        Me.lblCreateBy.TabIndex = 23
        Me.lblCreateBy.Text = "Create By : "
        '
        'cboStaff
        '
        Me.cboStaff.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboStaff.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboStaff.FormattingEnabled = True
        Me.cboStaff.Items.AddRange(New Object() {"Male", "Female"})
        Me.cboStaff.Location = New System.Drawing.Point(219, 486)
        Me.cboStaff.Name = "cboStaff"
        Me.cboStaff.Size = New System.Drawing.Size(421, 33)
        Me.cboStaff.TabIndex = 24
        '
        'btnCreate
        '
        Me.btnCreate.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(36, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.btnCreate.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCreate.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnCreate.Location = New System.Drawing.Point(1096, 634)
        Me.btnCreate.Name = "btnCreate"
        Me.btnCreate.Size = New System.Drawing.Size(220, 38)
        Me.btnCreate.TabIndex = 25
        Me.btnCreate.Text = "&Add Customer"
        Me.btnCreate.UseVisualStyleBackColor = False
        '
        'btnCancel
        '
        Me.btnCancel.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(36, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.btnCancel.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancel.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnCancel.Location = New System.Drawing.Point(764, 634)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(151, 38)
        Me.btnCancel.TabIndex = 26
        Me.btnCancel.Text = "&Cancel"
        Me.btnCancel.UseVisualStyleBackColor = False
        '
        'lblEmail
        '
        Me.lblEmail.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEmail.Location = New System.Drawing.Point(34, 167)
        Me.lblEmail.Name = "lblEmail"
        Me.lblEmail.Size = New System.Drawing.Size(181, 29)
        Me.lblEmail.TabIndex = 27
        Me.lblEmail.Text = "Email Address : "
        Me.lblEmail.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtEmail
        '
        Me.txtEmail.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEmail.Location = New System.Drawing.Point(216, 168)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(529, 31)
        Me.txtEmail.TabIndex = 28
        '
        'grpAddCustomer
        '
        Me.grpAddCustomer.Controls.Add(Me.mskCustPhone)
        Me.grpAddCustomer.Controls.Add(Me.txtPoints)
        Me.grpAddCustomer.Controls.Add(Me.Label11)
        Me.grpAddCustomer.Controls.Add(Me.radFemale)
        Me.grpAddCustomer.Controls.Add(Me.btnCancel)
        Me.grpAddCustomer.Controls.Add(Me.radMale)
        Me.grpAddCustomer.Controls.Add(Me.btnCreate)
        Me.grpAddCustomer.Controls.Add(Me.dtpDOB)
        Me.grpAddCustomer.Controls.Add(Me.btnClear)
        Me.grpAddCustomer.Controls.Add(Me.Label6)
        Me.grpAddCustomer.Controls.Add(Me.cboStatus)
        Me.grpAddCustomer.Controls.Add(Me.Label4)
        Me.grpAddCustomer.Controls.Add(Me.txtEmail)
        Me.grpAddCustomer.Controls.Add(Me.lblEmail)
        Me.grpAddCustomer.Controls.Add(Me.cboStaff)
        Me.grpAddCustomer.Controls.Add(Me.lblCreateBy)
        Me.grpAddCustomer.Controls.Add(Me.btnApplyAddress)
        Me.grpAddCustomer.Controls.Add(Me.txtPermanentAdd)
        Me.grpAddCustomer.Controls.Add(Me.lblPermanentAdd)
        Me.grpAddCustomer.Controls.Add(Me.txtPresentAdd)
        Me.grpAddCustomer.Controls.Add(Me.lblPresentAddress)
        Me.grpAddCustomer.Controls.Add(Me.lblCustAge)
        Me.grpAddCustomer.Controls.Add(Me.Label)
        Me.grpAddCustomer.Controls.Add(Me.cboTier)
        Me.grpAddCustomer.Controls.Add(Me.lblGender)
        Me.grpAddCustomer.Controls.Add(Me.dtpDOJ)
        Me.grpAddCustomer.Controls.Add(Me.lblDOB)
        Me.grpAddCustomer.Controls.Add(Me.txtCustName)
        Me.grpAddCustomer.Controls.Add(Me.lblName)
        Me.grpAddCustomer.Controls.Add(Me.lblMembershipTier)
        Me.grpAddCustomer.Controls.Add(Me.lblCustomerID)
        Me.grpAddCustomer.Controls.Add(Me.lblDateJoined)
        Me.grpAddCustomer.Controls.Add(Me.lbl11)
        Me.grpAddCustomer.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpAddCustomer.Location = New System.Drawing.Point(98, 118)
        Me.grpAddCustomer.Name = "grpAddCustomer"
        Me.grpAddCustomer.Size = New System.Drawing.Size(1347, 693)
        Me.grpAddCustomer.TabIndex = 31
        Me.grpAddCustomer.TabStop = False
        Me.grpAddCustomer.Text = "Personal Information"
        '
        'mskCustPhone
        '
        Me.mskCustPhone.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.mskCustPhone.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mskCustPhone.Location = New System.Drawing.Point(975, 168)
        Me.mskCustPhone.Margin = New System.Windows.Forms.Padding(2)
        Me.mskCustPhone.Mask = "999-0000000"
        Me.mskCustPhone.Name = "mskCustPhone"
        Me.mskCustPhone.PromptChar = Global.Microsoft.VisualBasic.ChrW(35)
        Me.mskCustPhone.Size = New System.Drawing.Size(264, 28)
        Me.mskCustPhone.TabIndex = 43
        '
        'txtPoints
        '
        Me.txtPoints.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPoints.Location = New System.Drawing.Point(1188, 224)
        Me.txtPoints.Name = "txtPoints"
        Me.txtPoints.ReadOnly = True
        Me.txtPoints.Size = New System.Drawing.Size(128, 31)
        Me.txtPoints.TabIndex = 42
        Me.txtPoints.Text = "500"
        Me.txtPoints.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ToolTip1.SetToolTip(Me.txtPoints, "Please enter your name")
        '
        'Label11
        '
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(1027, 227)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(165, 25)
        Me.Label11.TabIndex = 40
        Me.Label11.Text = "Reward Points :"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'radFemale
        '
        Me.radFemale.Location = New System.Drawing.Point(1071, 112)
        Me.radFemale.Name = "radFemale"
        Me.radFemale.Size = New System.Drawing.Size(107, 29)
        Me.radFemale.TabIndex = 39
        Me.radFemale.TabStop = True
        Me.radFemale.Text = "Female"
        Me.radFemale.UseVisualStyleBackColor = True
        '
        'radMale
        '
        Me.radMale.Location = New System.Drawing.Point(975, 112)
        Me.radMale.Name = "radMale"
        Me.radMale.Size = New System.Drawing.Size(90, 30)
        Me.radMale.TabIndex = 38
        Me.radMale.TabStop = True
        Me.radMale.Text = "Male"
        Me.radMale.UseVisualStyleBackColor = True
        '
        'dtpDOB
        '
        Me.dtpDOB.CustomFormat = ""
        Me.dtpDOB.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpDOB.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpDOB.Location = New System.Drawing.Point(216, 224)
        Me.dtpDOB.Name = "dtpDOB"
        Me.dtpDOB.Size = New System.Drawing.Size(203, 31)
        Me.dtpDOB.TabIndex = 37
        Me.dtpDOB.Value = New Date(2000, 2, 1, 0, 0, 0, 0)
        '
        'btnClear
        '
        Me.btnClear.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(36, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.btnClear.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClear.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnClear.Location = New System.Drawing.Point(930, 634)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(151, 38)
        Me.btnClear.TabIndex = 34
        Me.btnClear.Text = "&Clear"
        Me.btnClear.UseVisualStyleBackColor = False
        '
        'Label6
        '
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(797, 164)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(178, 35)
        Me.Label6.TabIndex = 33
        Me.Label6.Text = "Phone Number : "
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'cboStatus
        '
        Me.cboStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboStatus.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboStatus.FormattingEnabled = True
        Me.cboStatus.Items.AddRange(New Object() {"Active", "Inactive"})
        Me.cboStatus.Location = New System.Drawing.Point(975, 57)
        Me.cboStatus.Name = "cboStatus"
        Me.cboStatus.Size = New System.Drawing.Size(264, 33)
        Me.cboStatus.TabIndex = 32
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(879, 61)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(90, 31)
        Me.Label4.TabIndex = 29
        Me.Label4.Text = "Status : "
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'dtpDOJ
        '
        Me.dtpDOJ.CustomFormat = ""
        Me.dtpDOJ.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpDOJ.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpDOJ.Location = New System.Drawing.Point(523, 59)
        Me.dtpDOJ.Name = "dtpDOJ"
        Me.dtpDOJ.Size = New System.Drawing.Size(315, 31)
        Me.dtpDOJ.TabIndex = 12
        Me.dtpDOJ.Value = New Date(2023, 12, 11, 23, 59, 46, 0)
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(131, 72)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(260, 34)
        Me.Label3.TabIndex = 32
        Me.Label3.Text = "Add Customer"
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.ContainerControl = Me
        '
        'ErrorProvider2
        '
        Me.ErrorProvider2.ContainerControl = Me
        '
        'ErrorProvider3
        '
        Me.ErrorProvider3.ContainerControl = Me
        '
        'ErrorProvider4
        '
        Me.ErrorProvider4.ContainerControl = Me
        '
        'PictureBox3
        '
        Me.PictureBox3.Image = Global.CustomerManagement.My.Resources.Resources.grocer
        Me.PictureBox3.Location = New System.Drawing.Point(561, 6)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(326, 142)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox3.TabIndex = 34
        Me.PictureBox3.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(44, 40)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(85, 72)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 33
        Me.PictureBox1.TabStop = False
        '
        'addCustomer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1454, 971)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.grpAddCustomer)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "addCustomer"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        Me.grpAddCustomer.ResumeLayout(False)
        Me.grpAddCustomer.PerformLayout()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ErrorProvider2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ErrorProvider3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ErrorProvider4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents lbl11 As Label
    Friend WithEvents lblDateJoined As Label
    Friend WithEvents lblCustomerID As Label
    Friend WithEvents lblMembershipTier As Label
    Friend WithEvents lblName As Label
    Friend WithEvents txtCustName As TextBox
    Friend WithEvents lblDOB As Label
    Friend WithEvents lblGender As Label
    Friend WithEvents cboTier As ComboBox
    Friend WithEvents Label As Label
    Friend WithEvents lblCustAge As Label
    Friend WithEvents lblPresentAddress As Label
    Friend WithEvents txtPresentAdd As TextBox
    Friend WithEvents txtPermanentAdd As TextBox
    Friend WithEvents lblPermanentAdd As Label
    Friend WithEvents btnApplyAddress As Button
    Friend WithEvents lblCreateBy As Label
    Friend WithEvents cboStaff As ComboBox
    Friend WithEvents btnCreate As Button
    Friend WithEvents btnCancel As Button
    Friend WithEvents lblEmail As Label
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents grpAddCustomer As GroupBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents cboStatus As ComboBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents btnClear As Button
    Friend WithEvents Label6 As Label
    Friend WithEvents dtpDOJ As DateTimePicker
    Friend WithEvents dtpDOB As DateTimePicker
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents ToolTip2 As ToolTip
    Friend WithEvents radFemale As RadioButton
    Friend WithEvents radMale As RadioButton
    Friend WithEvents Label11 As Label
    Friend WithEvents txtPoints As TextBox
    Friend WithEvents ErrorProvider1 As ErrorProvider
    Friend WithEvents ErrorProvider2 As ErrorProvider
    Friend WithEvents ErrorProvider3 As ErrorProvider
    Friend WithEvents mskCustPhone As MaskedTextBox
    Friend WithEvents ErrorProvider4 As ErrorProvider
    Friend WithEvents PictureBox3 As PictureBox
End Class
