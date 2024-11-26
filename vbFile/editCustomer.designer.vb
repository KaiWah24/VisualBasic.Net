<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class editCustomer
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(editCustomer))
        Me.grpAddCustomer = New System.Windows.Forms.GroupBox()
        Me.btnApplyAddress = New System.Windows.Forms.Button()
        Me.lblTier = New System.Windows.Forms.Label()
        Me.txtPoints = New System.Windows.Forms.TextBox()
        Me.mskCustPhone = New System.Windows.Forms.MaskedTextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.radFemale = New System.Windows.Forms.RadioButton()
        Me.radMale = New System.Windows.Forms.RadioButton()
        Me.dtpDOB = New System.Windows.Forms.DateTimePicker()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.cboStatus = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtEmail = New System.Windows.Forms.TextBox()
        Me.lblEmail = New System.Windows.Forms.Label()
        Me.txtPermanentAdd = New System.Windows.Forms.TextBox()
        Me.lblPermanentAdd = New System.Windows.Forms.Label()
        Me.txtPresentAdd = New System.Windows.Forms.TextBox()
        Me.lblPresentAddress = New System.Windows.Forms.Label()
        Me.lblCustAge = New System.Windows.Forms.Label()
        Me.Label = New System.Windows.Forms.Label()
        Me.lblGender = New System.Windows.Forms.Label()
        Me.dtpDOJ = New System.Windows.Forms.DateTimePicker()
        Me.lblDOB = New System.Windows.Forms.Label()
        Me.txtCustName = New System.Windows.Forms.TextBox()
        Me.lblName = New System.Windows.Forms.Label()
        Me.lblMembershipTier = New System.Windows.Forms.Label()
        Me.lblCustomerID = New System.Windows.Forms.Label()
        Me.lblDateJoined = New System.Windows.Forms.Label()
        Me.lbl11 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.ErrorProvider2 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.ErrorProvider3 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.ErrorProvider4 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.btnSaveEdit = New System.Windows.Forms.Button()
        Me.grpAddCustomer.SuspendLayout()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ErrorProvider2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ErrorProvider3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ErrorProvider4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'grpAddCustomer
        '
        Me.grpAddCustomer.Controls.Add(Me.btnApplyAddress)
        Me.grpAddCustomer.Controls.Add(Me.lblTier)
        Me.grpAddCustomer.Controls.Add(Me.txtPoints)
        Me.grpAddCustomer.Controls.Add(Me.mskCustPhone)
        Me.grpAddCustomer.Controls.Add(Me.Label11)
        Me.grpAddCustomer.Controls.Add(Me.radFemale)
        Me.grpAddCustomer.Controls.Add(Me.radMale)
        Me.grpAddCustomer.Controls.Add(Me.dtpDOB)
        Me.grpAddCustomer.Controls.Add(Me.Label6)
        Me.grpAddCustomer.Controls.Add(Me.cboStatus)
        Me.grpAddCustomer.Controls.Add(Me.Label4)
        Me.grpAddCustomer.Controls.Add(Me.txtEmail)
        Me.grpAddCustomer.Controls.Add(Me.lblEmail)
        Me.grpAddCustomer.Controls.Add(Me.txtPermanentAdd)
        Me.grpAddCustomer.Controls.Add(Me.lblPermanentAdd)
        Me.grpAddCustomer.Controls.Add(Me.txtPresentAdd)
        Me.grpAddCustomer.Controls.Add(Me.lblPresentAddress)
        Me.grpAddCustomer.Controls.Add(Me.lblCustAge)
        Me.grpAddCustomer.Controls.Add(Me.Label)
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
        Me.grpAddCustomer.Location = New System.Drawing.Point(253, 124)
        Me.grpAddCustomer.Name = "grpAddCustomer"
        Me.grpAddCustomer.Size = New System.Drawing.Size(1347, 790)
        Me.grpAddCustomer.TabIndex = 37
        Me.grpAddCustomer.TabStop = False
        Me.grpAddCustomer.Text = "Personal Information"
        '
        'btnApplyAddress
        '
        Me.btnApplyAddress.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(36, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.btnApplyAddress.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnApplyAddress.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnApplyAddress.Location = New System.Drawing.Point(1096, 473)
        Me.btnApplyAddress.Name = "btnApplyAddress"
        Me.btnApplyAddress.Size = New System.Drawing.Size(220, 38)
        Me.btnApplyAddress.TabIndex = 47
        Me.btnApplyAddress.Text = "Same As Present"
        Me.btnApplyAddress.UseVisualStyleBackColor = False
        '
        'lblTier
        '
        Me.lblTier.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblTier.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTier.Location = New System.Drawing.Point(814, 226)
        Me.lblTier.Name = "lblTier"
        Me.lblTier.Size = New System.Drawing.Size(184, 33)
        Me.lblTier.TabIndex = 46
        Me.lblTier.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtPoints
        '
        Me.txtPoints.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPoints.Location = New System.Drawing.Point(1175, 226)
        Me.txtPoints.Name = "txtPoints"
        Me.txtPoints.Size = New System.Drawing.Size(157, 31)
        Me.txtPoints.TabIndex = 45
        '
        'mskCustPhone
        '
        Me.mskCustPhone.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.mskCustPhone.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mskCustPhone.Location = New System.Drawing.Point(975, 171)
        Me.mskCustPhone.Margin = New System.Windows.Forms.Padding(2)
        Me.mskCustPhone.Mask = "999-0000000"
        Me.mskCustPhone.Name = "mskCustPhone"
        Me.mskCustPhone.PromptChar = Global.Microsoft.VisualBasic.ChrW(35)
        Me.mskCustPhone.Size = New System.Drawing.Size(264, 28)
        Me.mskCustPhone.TabIndex = 44
        '
        'Label11
        '
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(1004, 228)
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
        Me.dtpDOB.Value = New Date(2023, 12, 11, 23, 59, 46, 0)
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
        'txtEmail
        '
        Me.txtEmail.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEmail.Location = New System.Drawing.Point(216, 168)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(529, 31)
        Me.txtEmail.TabIndex = 28
        Me.txtEmail.Text = "wongkw-wm21@student.tarc.edu.my"
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
        'lblCustAge
        '
        Me.lblCustAge.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblCustAge.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCustAge.Location = New System.Drawing.Point(487, 224)
        Me.lblCustAge.Name = "lblCustAge"
        Me.lblCustAge.Size = New System.Drawing.Size(130, 33)
        Me.lblCustAge.TabIndex = 17
        Me.lblCustAge.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label
        '
        Me.Label.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label.Location = New System.Drawing.Point(425, 226)
        Me.Label.Name = "Label"
        Me.Label.Size = New System.Drawing.Size(69, 28)
        Me.Label.TabIndex = 16
        Me.Label.Text = "Age : "
        Me.Label.TextAlign = System.Drawing.ContentAlignment.TopRight
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
        'txtCustName
        '
        Me.txtCustName.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCustName.Location = New System.Drawing.Point(216, 114)
        Me.txtCustName.Name = "txtCustName"
        Me.txtCustName.Size = New System.Drawing.Size(622, 31)
        Me.txtCustName.TabIndex = 10
        Me.txtCustName.Text = "Wong Kar Xin Wah"
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
        'lblMembershipTier
        '
        Me.lblMembershipTier.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMembershipTier.Location = New System.Drawing.Point(623, 227)
        Me.lblMembershipTier.Name = "lblMembershipTier"
        Me.lblMembershipTier.Size = New System.Drawing.Size(192, 25)
        Me.lblMembershipTier.TabIndex = 7
        Me.lblMembershipTier.Text = "Membership Tier : "
        Me.lblMembershipTier.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblCustomerID
        '
        Me.lblCustomerID.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblCustomerID.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCustomerID.Location = New System.Drawing.Point(216, 60)
        Me.lblCustomerID.Name = "lblCustomerID"
        Me.lblCustomerID.Size = New System.Drawing.Size(119, 32)
        Me.lblCustomerID.TabIndex = 6
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
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(286, 78)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(260, 34)
        Me.Label3.TabIndex = 38
        Me.Label3.Text = "Edit Information"
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
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(199, 46)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(85, 72)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 39
        Me.PictureBox1.TabStop = False
        '
        'btnCancel
        '
        Me.btnCancel.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(36, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.btnCancel.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancel.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnCancel.Location = New System.Drawing.Point(1214, 918)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(151, 38)
        Me.btnCancel.TabIndex = 49
        Me.btnCancel.Text = "&Cancel"
        Me.btnCancel.UseVisualStyleBackColor = False
        '
        'btnSaveEdit
        '
        Me.btnSaveEdit.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(36, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.btnSaveEdit.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSaveEdit.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnSaveEdit.Location = New System.Drawing.Point(1380, 918)
        Me.btnSaveEdit.Name = "btnSaveEdit"
        Me.btnSaveEdit.Size = New System.Drawing.Size(220, 38)
        Me.btnSaveEdit.TabIndex = 48
        Me.btnSaveEdit.Text = "Edit"
        Me.btnSaveEdit.UseVisualStyleBackColor = False
        '
        'editCustomer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1664, 1011)
        Me.Controls.Add(Me.btnSaveEdit)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.grpAddCustomer)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.PictureBox1)
        Me.Name = "editCustomer"
        Me.Text = "updateCustomer"
        Me.grpAddCustomer.ResumeLayout(False)
        Me.grpAddCustomer.PerformLayout()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ErrorProvider2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ErrorProvider3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ErrorProvider4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents grpAddCustomer As GroupBox
    Friend WithEvents Label11 As Label
    Friend WithEvents radFemale As RadioButton
    Friend WithEvents radMale As RadioButton
    Friend WithEvents dtpDOB As DateTimePicker
    Friend WithEvents Label6 As Label
    Friend WithEvents cboStatus As ComboBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents lblEmail As Label
    Friend WithEvents txtPermanentAdd As TextBox
    Friend WithEvents lblPermanentAdd As Label
    Friend WithEvents txtPresentAdd As TextBox
    Friend WithEvents lblPresentAddress As Label
    Friend WithEvents lblCustAge As Label
    Friend WithEvents Label As Label
    Friend WithEvents lblGender As Label
    Friend WithEvents dtpDOJ As DateTimePicker
    Friend WithEvents lblDOB As Label
    Friend WithEvents txtCustName As TextBox
    Friend WithEvents lblName As Label
    Friend WithEvents lblMembershipTier As Label
    Friend WithEvents lblCustomerID As Label
    Friend WithEvents lblDateJoined As Label
    Friend WithEvents lbl11 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents mskCustPhone As MaskedTextBox
    Friend WithEvents ErrorProvider1 As ErrorProvider
    Friend WithEvents ErrorProvider2 As ErrorProvider
    Friend WithEvents ErrorProvider3 As ErrorProvider
    Friend WithEvents ErrorProvider4 As ErrorProvider
    Friend WithEvents txtPoints As TextBox
    Friend WithEvents lblTier As Label
    Friend WithEvents btnApplyAddress As Button
    Friend WithEvents btnCancel As Button
    Friend WithEvents btnSaveEdit As Button
End Class
