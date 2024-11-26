<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class addStaff
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(addStaff))
        Me.dlgOpenFile = New System.Windows.Forms.OpenFileDialog()
        Me.errStaffEmail = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.errStaffName = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblDateHired = New System.Windows.Forms.Label()
        Me.mskIC = New System.Windows.Forms.MaskedTextBox()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.lblAge = New System.Windows.Forms.Label()
        Me.lblStaffId = New System.Windows.Forms.Label()
        Me.cboStatus = New System.Windows.Forms.ComboBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.btnUpload = New System.Windows.Forms.Button()
        Me.txtPhoneNum = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.cboRelationship = New System.Windows.Forms.ComboBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.picStaff = New System.Windows.Forms.PictureBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.dtpBirthday = New System.Windows.Forms.DateTimePicker()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.radFemale = New System.Windows.Forms.RadioButton()
        Me.radMale = New System.Windows.Forms.RadioButton()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txtAddress = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtEmail = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtSalary = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.cboPosition = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.errStaffRelationship = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.errStaffBirthday = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.errStaffAddress = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.errStaffPhoneNum = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.errStaffSalary = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.btnReset = New System.Windows.Forms.Button()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.btnCreate = New System.Windows.Forms.Button()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.errStaffPosition = New System.Windows.Forms.ErrorProvider(Me.components)
        CType(Me.errStaffEmail, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.errStaffName, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.picStaff, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.errStaffRelationship, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.errStaffBirthday, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.errStaffAddress, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.errStaffPhoneNum, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.errStaffSalary, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.errStaffPosition, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dlgOpenFile
        '
        Me.dlgOpenFile.FileName = "dlgOpenFile"
        '
        'errStaffEmail
        '
        Me.errStaffEmail.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink
        Me.errStaffEmail.ContainerControl = Me
        '
        'errStaffName
        '
        Me.errStaffName.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink
        Me.errStaffName.ContainerControl = Me
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.lblDateHired)
        Me.GroupBox1.Controls.Add(Me.mskIC)
        Me.GroupBox1.Controls.Add(Me.btnClear)
        Me.GroupBox1.Controls.Add(Me.lblAge)
        Me.GroupBox1.Controls.Add(Me.lblStaffId)
        Me.GroupBox1.Controls.Add(Me.cboStatus)
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Controls.Add(Me.btnUpload)
        Me.GroupBox1.Controls.Add(Me.txtPhoneNum)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.cboRelationship)
        Me.GroupBox1.Controls.Add(Me.Label17)
        Me.GroupBox1.Controls.Add(Me.picStaff)
        Me.GroupBox1.Controls.Add(Me.Label16)
        Me.GroupBox1.Controls.Add(Me.Label15)
        Me.GroupBox1.Controls.Add(Me.dtpBirthday)
        Me.GroupBox1.Controls.Add(Me.Label14)
        Me.GroupBox1.Controls.Add(Me.radFemale)
        Me.GroupBox1.Controls.Add(Me.radMale)
        Me.GroupBox1.Controls.Add(Me.Label12)
        Me.GroupBox1.Controls.Add(Me.txtAddress)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.txtEmail)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.txtSalary)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.cboPosition)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.txtName)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label13)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 19.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.errStaffBirthday.SetIconAlignment(Me.GroupBox1, System.Windows.Forms.ErrorIconAlignment.BottomLeft)
        Me.errStaffAddress.SetIconAlignment(Me.GroupBox1, System.Windows.Forms.ErrorIconAlignment.BottomLeft)
        Me.errStaffPhoneNum.SetIconAlignment(Me.GroupBox1, System.Windows.Forms.ErrorIconAlignment.BottomLeft)
        Me.errStaffName.SetIconAlignment(Me.GroupBox1, System.Windows.Forms.ErrorIconAlignment.BottomLeft)
        Me.GroupBox1.Location = New System.Drawing.Point(46, 82)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(1320, 806)
        Me.GroupBox1.TabIndex = 85
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Add Staff"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(297, 631)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(50, 29)
        Me.Label1.TabIndex = 77
        Me.Label1.Text = "RM"
        '
        'lblDateHired
        '
        Me.lblDateHired.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblDateHired.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDateHired.Location = New System.Drawing.Point(302, 691)
        Me.lblDateHired.Name = "lblDateHired"
        Me.lblDateHired.Size = New System.Drawing.Size(298, 34)
        Me.lblDateHired.TabIndex = 76
        '
        'mskIC
        '
        Me.mskIC.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mskIC.Location = New System.Drawing.Point(302, 188)
        Me.mskIC.Mask = "000000-00-0000"
        Me.mskIC.Name = "mskIC"
        Me.mskIC.Size = New System.Drawing.Size(505, 34)
        Me.mskIC.TabIndex = 2
        '
        'btnClear
        '
        Me.btnClear.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClear.Location = New System.Drawing.Point(978, 302)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(115, 33)
        Me.btnClear.TabIndex = 13
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'lblAge
        '
        Me.lblAge.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblAge.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAge.Location = New System.Drawing.Point(821, 435)
        Me.lblAge.Name = "lblAge"
        Me.lblAge.Size = New System.Drawing.Size(298, 37)
        Me.lblAge.TabIndex = 9
        '
        'lblStaffId
        '
        Me.lblStaffId.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblStaffId.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStaffId.Location = New System.Drawing.Point(302, 69)
        Me.lblStaffId.Name = "lblStaffId"
        Me.lblStaffId.Size = New System.Drawing.Size(505, 35)
        Me.lblStaffId.TabIndex = 0
        '
        'cboStatus
        '
        Me.cboStatus.Enabled = False
        Me.cboStatus.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboStatus.FormattingEnabled = True
        Me.cboStatus.Items.AddRange(New Object() {"Active", "Terminated"})
        Me.cboStatus.Location = New System.Drawing.Point(821, 562)
        Me.cboStatus.Name = "cboStatus"
        Me.cboStatus.Size = New System.Drawing.Size(298, 37)
        Me.cboStatus.TabIndex = 10
        Me.cboStatus.Text = "Active"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(666, 565)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(91, 29)
        Me.Label11.TabIndex = 72
        Me.Label11.Text = "Status :"
        '
        'btnUpload
        '
        Me.btnUpload.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUpload.Location = New System.Drawing.Point(857, 302)
        Me.btnUpload.Name = "btnUpload"
        Me.btnUpload.Size = New System.Drawing.Size(115, 33)
        Me.btnUpload.TabIndex = 12
        Me.btnUpload.Text = "Upload"
        Me.btnUpload.UseVisualStyleBackColor = True
        '
        'txtPhoneNum
        '
        Me.txtPhoneNum.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPhoneNum.Location = New System.Drawing.Point(302, 312)
        Me.txtPhoneNum.Name = "txtPhoneNum"
        Me.txtPhoneNum.Size = New System.Drawing.Size(505, 34)
        Me.txtPhoneNum.TabIndex = 4
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(21, 317)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(188, 29)
        Me.Label10.TabIndex = 57
        Me.Label10.Text = "Phone Number :"
        '
        'cboRelationship
        '
        Me.cboRelationship.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboRelationship.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboRelationship.FormattingEnabled = True
        Me.cboRelationship.Items.AddRange(New Object() {"Single", "Married"})
        Me.cboRelationship.Location = New System.Drawing.Point(300, 433)
        Me.cboRelationship.Name = "cboRelationship"
        Me.cboRelationship.Size = New System.Drawing.Size(298, 37)
        Me.cboRelationship.TabIndex = 8
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(21, 441)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(231, 29)
        Me.Label17.TabIndex = 55
        Me.Label17.Text = "Relationship Status :"
        '
        'picStaff
        '
        Me.picStaff.Image = CType(resources.GetObject("picStaff.Image"), System.Drawing.Image)
        Me.picStaff.Location = New System.Drawing.Point(871, 69)
        Me.picStaff.Name = "picStaff"
        Me.picStaff.Size = New System.Drawing.Size(210, 220)
        Me.picStaff.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picStaff.TabIndex = 54
        Me.picStaff.TabStop = False
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(21, 696)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(140, 29)
        Me.Label16.TabIndex = 52
        Me.Label16.Text = "Date Hired :"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(667, 441)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(68, 29)
        Me.Label15.TabIndex = 50
        Me.Label15.Text = "Age :"
        '
        'dtpBirthday
        '
        Me.dtpBirthday.CalendarFont = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpBirthday.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpBirthday.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpBirthday.Location = New System.Drawing.Point(821, 374)
        Me.dtpBirthday.Name = "dtpBirthday"
        Me.dtpBirthday.Size = New System.Drawing.Size(298, 34)
        Me.dtpBirthday.TabIndex = 7
        Me.dtpBirthday.Value = New Date(2023, 12, 11, 0, 0, 0, 0)
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(667, 379)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(112, 29)
        Me.Label14.TabIndex = 48
        Me.Label14.Text = "Birthday :"
        '
        'radFemale
        '
        Me.radFemale.AutoSize = True
        Me.radFemale.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radFemale.Location = New System.Drawing.Point(428, 375)
        Me.radFemale.Name = "radFemale"
        Me.radFemale.Size = New System.Drawing.Size(116, 33)
        Me.radFemale.TabIndex = 6
        Me.radFemale.Text = "Female"
        Me.radFemale.UseVisualStyleBackColor = True
        '
        'radMale
        '
        Me.radMale.AutoSize = True
        Me.radMale.Checked = True
        Me.radMale.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radMale.Location = New System.Drawing.Point(300, 375)
        Me.radMale.Name = "radMale"
        Me.radMale.Size = New System.Drawing.Size(87, 33)
        Me.radMale.TabIndex = 5
        Me.radMale.TabStop = True
        Me.radMale.Text = "Male"
        Me.radMale.UseVisualStyleBackColor = True
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(21, 379)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(106, 29)
        Me.Label12.TabIndex = 45
        Me.Label12.Text = "Gender :"
        '
        'txtAddress
        '
        Me.txtAddress.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAddress.Location = New System.Drawing.Point(301, 498)
        Me.txtAddress.Name = "txtAddress"
        Me.txtAddress.Size = New System.Drawing.Size(818, 34)
        Me.txtAddress.TabIndex = 9
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(21, 503)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(108, 29)
        Me.Label9.TabIndex = 39
        Me.Label9.Text = "Address:"
        '
        'txtEmail
        '
        Me.txtEmail.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEmail.Location = New System.Drawing.Point(302, 240)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(505, 34)
        Me.txtEmail.TabIndex = 3
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(21, 255)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(86, 29)
        Me.Label7.TabIndex = 37
        Me.Label7.Text = "Email :"
        '
        'txtSalary
        '
        Me.txtSalary.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSalary.Location = New System.Drawing.Point(352, 628)
        Me.txtSalary.Name = "txtSalary"
        Me.txtSalary.Size = New System.Drawing.Size(248, 34)
        Me.txtSalary.TabIndex = 11
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(23, 634)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(157, 29)
        Me.Label6.TabIndex = 35
        Me.Label6.Text = "Basic Salary :"
        '
        'cboPosition
        '
        Me.cboPosition.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboPosition.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboPosition.FormattingEnabled = True
        Me.cboPosition.Items.AddRange(New Object() {"Admin", "Staff"})
        Me.cboPosition.Location = New System.Drawing.Point(302, 562)
        Me.cboPosition.Name = "cboPosition"
        Me.cboPosition.Size = New System.Drawing.Size(298, 37)
        Me.cboPosition.TabIndex = 10
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(23, 569)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(112, 29)
        Me.Label5.TabIndex = 33
        Me.Label5.Text = "Position :"
        '
        'txtName
        '
        Me.txtName.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtName.Location = New System.Drawing.Point(302, 128)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(505, 34)
        Me.txtName.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(21, 193)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(107, 29)
        Me.Label2.TabIndex = 28
        Me.Label2.Text = "Staff IC : "
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(21, 131)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(149, 29)
        Me.Label3.TabIndex = 27
        Me.Label3.Text = "Staff Name : "
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(21, 69)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(107, 29)
        Me.Label13.TabIndex = 23
        Me.Label13.Text = "Staff ID : "
        '
        'errStaffRelationship
        '
        Me.errStaffRelationship.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink
        Me.errStaffRelationship.ContainerControl = Me
        '
        'errStaffBirthday
        '
        Me.errStaffBirthday.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink
        Me.errStaffBirthday.ContainerControl = Me
        '
        'errStaffAddress
        '
        Me.errStaffAddress.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink
        Me.errStaffAddress.ContainerControl = Me
        '
        'errStaffPhoneNum
        '
        Me.errStaffPhoneNum.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink
        Me.errStaffPhoneNum.ContainerControl = Me
        '
        'errStaffSalary
        '
        Me.errStaffSalary.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink
        Me.errStaffSalary.ContainerControl = Me
        '
        'btnReset
        '
        Me.btnReset.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnReset.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnReset.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnReset.Location = New System.Drawing.Point(1082, 898)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(139, 48)
        Me.btnReset.TabIndex = 83
        Me.btnReset.Text = "Reset"
        Me.btnReset.UseVisualStyleBackColor = False
        '
        'btnCancel
        '
        Me.btnCancel.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnCancel.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancel.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnCancel.Location = New System.Drawing.Point(1227, 898)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(139, 48)
        Me.btnCancel.TabIndex = 84
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = False
        '
        'btnCreate
        '
        Me.btnCreate.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(36, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.btnCreate.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCreate.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnCreate.Location = New System.Drawing.Point(938, 898)
        Me.btnCreate.Name = "btnCreate"
        Me.btnCreate.Size = New System.Drawing.Size(139, 48)
        Me.btnCreate.TabIndex = 82
        Me.btnCreate.Text = "Create"
        Me.btnCreate.UseVisualStyleBackColor = False
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(23, 10)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(518, 69)
        Me.Label8.TabIndex = 86
        Me.Label8.Text = "Staff Management"
        '
        'errStaffPosition
        '
        Me.errStaffPosition.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink
        Me.errStaffPosition.ContainerControl = Me
        '
        'addStaff
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = My.Resources.Resources.bg3
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1388, 957)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btnReset)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnCreate)
        Me.Controls.Add(Me.Label8)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(1406, 1004)
        Me.MinimumSize = New System.Drawing.Size(1406, 1004)
        Me.Name = "addStaff"
        Me.Text = "addStaff"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.errStaffEmail, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.errStaffName, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.picStaff, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.errStaffRelationship, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.errStaffBirthday, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.errStaffAddress, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.errStaffPhoneNum, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.errStaffSalary, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.errStaffPosition, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents dlgOpenFile As OpenFileDialog
    Friend WithEvents errStaffEmail As ErrorProvider
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label1 As Label
    Friend WithEvents lblDateHired As Label
    Friend WithEvents mskIC As MaskedTextBox
    Friend WithEvents btnClear As Button
    Friend WithEvents lblAge As Label
    Friend WithEvents lblStaffId As Label
    Friend WithEvents cboStatus As ComboBox
    Friend WithEvents Label11 As Label
    Friend WithEvents btnUpload As Button
    Friend WithEvents txtPhoneNum As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents cboRelationship As ComboBox
    Friend WithEvents Label17 As Label
    Friend WithEvents picStaff As PictureBox
    Friend WithEvents Label16 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents dtpBirthday As DateTimePicker
    Friend WithEvents Label14 As Label
    Friend WithEvents radFemale As RadioButton
    Friend WithEvents radMale As RadioButton
    Friend WithEvents Label12 As Label
    Friend WithEvents txtAddress As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents txtSalary As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents cboPosition As ComboBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txtName As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents errStaffBirthday As ErrorProvider
    Friend WithEvents errStaffAddress As ErrorProvider
    Friend WithEvents errStaffPhoneNum As ErrorProvider
    Friend WithEvents errStaffName As ErrorProvider
    Friend WithEvents btnReset As Button
    Friend WithEvents btnCancel As Button
    Friend WithEvents btnCreate As Button
    Friend WithEvents Label8 As Label
    Friend WithEvents errStaffRelationship As ErrorProvider
    Friend WithEvents errStaffSalary As ErrorProvider
    Friend WithEvents errStaffPosition As ErrorProvider
End Class
