<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RegisterStaffForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(RegisterStaffForm))
        Me.Title = New System.Windows.Forms.Label()
        Me.txtStaffNo = New System.Windows.Forms.TextBox()
        Me.lblStaffNo = New System.Windows.Forms.Label()
        Me.txtFullname = New System.Windows.Forms.TextBox()
        Me.lblFullname = New System.Windows.Forms.Label()
        Me.cboGender = New System.Windows.Forms.ComboBox()
        Me.lblGender = New System.Windows.Forms.Label()
        Me.txtPhone = New System.Windows.Forms.TextBox()
        Me.lblPhone = New System.Windows.Forms.Label()
        Me.DateTimePickerBirth = New System.Windows.Forms.DateTimePicker()
        Me.lblBirth = New System.Windows.Forms.Label()
        Me.cboYrAdmit = New System.Windows.Forms.ComboBox()
        Me.lblYrAdmit = New System.Windows.Forms.Label()
        Me.cboSection = New System.Windows.Forms.ComboBox()
        Me.lblSection = New System.Windows.Forms.Label()
        Me.cboYrExited = New System.Windows.Forms.ComboBox()
        Me.lblYrExited = New System.Windows.Forms.Label()
        Me.cboRank = New System.Windows.Forms.ComboBox()
        Me.lblRank = New System.Windows.Forms.Label()
        Me.txtSubjTaught = New System.Windows.Forms.TextBox()
        Me.lblSubjTaught = New System.Windows.Forms.Label()
        Me.txtEmail = New System.Windows.Forms.TextBox()
        Me.lblEmail = New System.Windows.Forms.Label()
        Me.txtResAddress = New System.Windows.Forms.TextBox()
        Me.lblResAddress = New System.Windows.Forms.Label()
        Me.cboState = New System.Windows.Forms.ComboBox()
        Me.lblState = New System.Windows.Forms.Label()
        Me.cboLocalGovt = New System.Windows.Forms.ComboBox()
        Me.lblLocalGovt = New System.Windows.Forms.Label()
        Me.cboNationality = New System.Windows.Forms.ComboBox()
        Me.lblNationality = New System.Windows.Forms.Label()
        Me.cboRegion = New System.Windows.Forms.ComboBox()
        Me.lblRegion = New System.Windows.Forms.Label()
        Me.txtWorkPlace = New System.Windows.Forms.TextBox()
        Me.lblWorkPlace = New System.Windows.Forms.Label()
        Me.txtPassword = New System.Windows.Forms.TextBox()
        Me.lblPassword = New System.Windows.Forms.Label()
        Me.txtRPassword = New System.Windows.Forms.TextBox()
        Me.lblRPassword = New System.Windows.Forms.Label()
        Me.txtWorkAddress = New System.Windows.Forms.TextBox()
        Me.lblWorkAddres = New System.Windows.Forms.Label()
        Me.cboStatus = New System.Windows.Forms.ComboBox()
        Me.Status = New System.Windows.Forms.Label()
        Me.btnLoad = New System.Windows.Forms.Button()
        Me.lblPleaseWait = New System.Windows.Forms.Label()
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar()
        Me.btnRegister = New System.Windows.Forms.Button()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.btnDelPic = New System.Windows.Forms.Button()
        Me.PicProfile = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.btnHome = New System.Windows.Forms.Button()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        CType(Me.PicProfile, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Title
        '
        Me.Title.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(117, Byte), Integer), CType(CType(182, Byte), Integer))
        Me.Title.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Title.Font = New System.Drawing.Font("Rockwell", 18.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Title.ForeColor = System.Drawing.Color.FromArgb(CType(CType(220, Byte), Integer), CType(CType(56, Byte), Integer), CType(CType(118, Byte), Integer))
        Me.Title.Location = New System.Drawing.Point(187, 2)
        Me.Title.Name = "Title"
        Me.Title.Size = New System.Drawing.Size(507, 48)
        Me.Title.TabIndex = 5
        Me.Title.Text = "REGISTER AS STAFF"
        Me.Title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtStaffNo
        '
        Me.txtStaffNo.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.txtStaffNo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtStaffNo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtStaffNo.Location = New System.Drawing.Point(100, 82)
        Me.txtStaffNo.Name = "txtStaffNo"
        Me.txtStaffNo.Size = New System.Drawing.Size(165, 27)
        Me.txtStaffNo.TabIndex = 16
        '
        'lblStaffNo
        '
        Me.lblStaffNo.AutoSize = True
        Me.lblStaffNo.Font = New System.Drawing.Font("Calibri", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStaffNo.ForeColor = System.Drawing.Color.Black
        Me.lblStaffNo.Location = New System.Drawing.Point(12, 85)
        Me.lblStaffNo.Name = "lblStaffNo"
        Me.lblStaffNo.Size = New System.Drawing.Size(70, 21)
        Me.lblStaffNo.TabIndex = 15
        Me.lblStaffNo.Text = "Staff No."
        '
        'txtFullname
        '
        Me.txtFullname.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFullname.Location = New System.Drawing.Point(100, 115)
        Me.txtFullname.Name = "txtFullname"
        Me.txtFullname.Size = New System.Drawing.Size(441, 27)
        Me.txtFullname.TabIndex = 18
        '
        'lblFullname
        '
        Me.lblFullname.AutoSize = True
        Me.lblFullname.Font = New System.Drawing.Font("Calibri", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFullname.ForeColor = System.Drawing.Color.Black
        Me.lblFullname.Location = New System.Drawing.Point(12, 118)
        Me.lblFullname.Name = "lblFullname"
        Me.lblFullname.Size = New System.Drawing.Size(74, 21)
        Me.lblFullname.TabIndex = 17
        Me.lblFullname.Text = "Fullname"
        '
        'cboGender
        '
        Me.cboGender.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboGender.FormattingEnabled = True
        Me.cboGender.Items.AddRange(New Object() {"Male", "Female"})
        Me.cboGender.Location = New System.Drawing.Point(101, 148)
        Me.cboGender.Name = "cboGender"
        Me.cboGender.Size = New System.Drawing.Size(165, 28)
        Me.cboGender.TabIndex = 20
        '
        'lblGender
        '
        Me.lblGender.AutoSize = True
        Me.lblGender.Font = New System.Drawing.Font("Calibri", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblGender.ForeColor = System.Drawing.Color.Black
        Me.lblGender.Location = New System.Drawing.Point(12, 151)
        Me.lblGender.Name = "lblGender"
        Me.lblGender.Size = New System.Drawing.Size(61, 21)
        Me.lblGender.TabIndex = 19
        Me.lblGender.Text = "Gender"
        '
        'txtPhone
        '
        Me.txtPhone.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPhone.Location = New System.Drawing.Point(101, 283)
        Me.txtPhone.Name = "txtPhone"
        Me.txtPhone.Size = New System.Drawing.Size(165, 27)
        Me.txtPhone.TabIndex = 35
        '
        'lblPhone
        '
        Me.lblPhone.AutoSize = True
        Me.lblPhone.Font = New System.Drawing.Font("Calibri", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPhone.ForeColor = System.Drawing.Color.Black
        Me.lblPhone.Location = New System.Drawing.Point(12, 286)
        Me.lblPhone.Name = "lblPhone"
        Me.lblPhone.Size = New System.Drawing.Size(82, 21)
        Me.lblPhone.TabIndex = 34
        Me.lblPhone.Text = "Phone No."
        '
        'DateTimePickerBirth
        '
        Me.DateTimePickerBirth.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateTimePickerBirth.Location = New System.Drawing.Point(376, 151)
        Me.DateTimePickerBirth.Name = "DateTimePickerBirth"
        Me.DateTimePickerBirth.Size = New System.Drawing.Size(165, 27)
        Me.DateTimePickerBirth.TabIndex = 42
        '
        'lblBirth
        '
        Me.lblBirth.AutoSize = True
        Me.lblBirth.Font = New System.Drawing.Font("Calibri", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBirth.ForeColor = System.Drawing.Color.Black
        Me.lblBirth.Location = New System.Drawing.Point(272, 151)
        Me.lblBirth.Name = "lblBirth"
        Me.lblBirth.Size = New System.Drawing.Size(98, 21)
        Me.lblBirth.TabIndex = 41
        Me.lblBirth.Text = "Date of Birth"
        '
        'cboYrAdmit
        '
        Me.cboYrAdmit.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboYrAdmit.FormattingEnabled = True
        Me.cboYrAdmit.Location = New System.Drawing.Point(101, 216)
        Me.cboYrAdmit.Name = "cboYrAdmit"
        Me.cboYrAdmit.Size = New System.Drawing.Size(165, 28)
        Me.cboYrAdmit.TabIndex = 44
        '
        'lblYrAdmit
        '
        Me.lblYrAdmit.AutoSize = True
        Me.lblYrAdmit.Font = New System.Drawing.Font("Calibri", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblYrAdmit.ForeColor = System.Drawing.Color.Black
        Me.lblYrAdmit.Location = New System.Drawing.Point(12, 219)
        Me.lblYrAdmit.Name = "lblYrAdmit"
        Me.lblYrAdmit.Size = New System.Drawing.Size(86, 21)
        Me.lblYrAdmit.TabIndex = 43
        Me.lblYrAdmit.Text = "Year Admit"
        '
        'cboSection
        '
        Me.cboSection.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboSection.FormattingEnabled = True
        Me.cboSection.Location = New System.Drawing.Point(101, 182)
        Me.cboSection.Name = "cboSection"
        Me.cboSection.Size = New System.Drawing.Size(165, 28)
        Me.cboSection.TabIndex = 46
        '
        'lblSection
        '
        Me.lblSection.AutoSize = True
        Me.lblSection.Font = New System.Drawing.Font("Calibri", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSection.ForeColor = System.Drawing.Color.Black
        Me.lblSection.Location = New System.Drawing.Point(12, 185)
        Me.lblSection.Name = "lblSection"
        Me.lblSection.Size = New System.Drawing.Size(60, 21)
        Me.lblSection.TabIndex = 45
        Me.lblSection.Text = "Section"
        '
        'cboYrExited
        '
        Me.cboYrExited.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboYrExited.FormattingEnabled = True
        Me.cboYrExited.Location = New System.Drawing.Point(376, 216)
        Me.cboYrExited.Name = "cboYrExited"
        Me.cboYrExited.Size = New System.Drawing.Size(165, 28)
        Me.cboYrExited.TabIndex = 48
        '
        'lblYrExited
        '
        Me.lblYrExited.AutoSize = True
        Me.lblYrExited.Font = New System.Drawing.Font("Calibri", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblYrExited.ForeColor = System.Drawing.Color.Black
        Me.lblYrExited.Location = New System.Drawing.Point(272, 219)
        Me.lblYrExited.Name = "lblYrExited"
        Me.lblYrExited.Size = New System.Drawing.Size(85, 21)
        Me.lblYrExited.TabIndex = 47
        Me.lblYrExited.Text = "Year Exited"
        '
        'cboRank
        '
        Me.cboRank.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboRank.FormattingEnabled = True
        Me.cboRank.Location = New System.Drawing.Point(376, 182)
        Me.cboRank.Name = "cboRank"
        Me.cboRank.Size = New System.Drawing.Size(165, 28)
        Me.cboRank.TabIndex = 50
        '
        'lblRank
        '
        Me.lblRank.AutoSize = True
        Me.lblRank.Font = New System.Drawing.Font("Calibri", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRank.ForeColor = System.Drawing.Color.Black
        Me.lblRank.Location = New System.Drawing.Point(272, 185)
        Me.lblRank.Name = "lblRank"
        Me.lblRank.Size = New System.Drawing.Size(44, 21)
        Me.lblRank.TabIndex = 49
        Me.lblRank.Text = "Rank"
        '
        'txtSubjTaught
        '
        Me.txtSubjTaught.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSubjTaught.Location = New System.Drawing.Point(101, 250)
        Me.txtSubjTaught.Name = "txtSubjTaught"
        Me.txtSubjTaught.Size = New System.Drawing.Size(440, 27)
        Me.txtSubjTaught.TabIndex = 52
        '
        'lblSubjTaught
        '
        Me.lblSubjTaught.AutoSize = True
        Me.lblSubjTaught.Font = New System.Drawing.Font("Calibri", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSubjTaught.ForeColor = System.Drawing.Color.Black
        Me.lblSubjTaught.Location = New System.Drawing.Point(12, 253)
        Me.lblSubjTaught.Name = "lblSubjTaught"
        Me.lblSubjTaught.Size = New System.Drawing.Size(94, 21)
        Me.lblSubjTaught.TabIndex = 51
        Me.lblSubjTaught.Text = "Subj. taught"
        '
        'txtEmail
        '
        Me.txtEmail.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEmail.Location = New System.Drawing.Point(376, 283)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(165, 27)
        Me.txtEmail.TabIndex = 54
        '
        'lblEmail
        '
        Me.lblEmail.AutoSize = True
        Me.lblEmail.Font = New System.Drawing.Font("Calibri", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEmail.ForeColor = System.Drawing.Color.Black
        Me.lblEmail.Location = New System.Drawing.Point(272, 286)
        Me.lblEmail.Name = "lblEmail"
        Me.lblEmail.Size = New System.Drawing.Size(48, 21)
        Me.lblEmail.TabIndex = 53
        Me.lblEmail.Text = "Email"
        '
        'txtResAddress
        '
        Me.txtResAddress.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtResAddress.Location = New System.Drawing.Point(101, 316)
        Me.txtResAddress.Multiline = True
        Me.txtResAddress.Name = "txtResAddress"
        Me.txtResAddress.Size = New System.Drawing.Size(440, 60)
        Me.txtResAddress.TabIndex = 56
        '
        'lblResAddress
        '
        Me.lblResAddress.AutoSize = True
        Me.lblResAddress.Font = New System.Drawing.Font("Calibri", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblResAddress.ForeColor = System.Drawing.Color.Black
        Me.lblResAddress.Location = New System.Drawing.Point(12, 319)
        Me.lblResAddress.Name = "lblResAddress"
        Me.lblResAddress.Size = New System.Drawing.Size(66, 21)
        Me.lblResAddress.TabIndex = 55
        Me.lblResAddress.Text = "Address"
        '
        'cboState
        '
        Me.cboState.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboState.FormattingEnabled = True
        Me.cboState.Location = New System.Drawing.Point(376, 382)
        Me.cboState.Name = "cboState"
        Me.cboState.Size = New System.Drawing.Size(165, 28)
        Me.cboState.TabIndex = 66
        '
        'lblState
        '
        Me.lblState.AutoSize = True
        Me.lblState.Font = New System.Drawing.Font("Calibri", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblState.ForeColor = System.Drawing.Color.Black
        Me.lblState.Location = New System.Drawing.Point(272, 387)
        Me.lblState.Name = "lblState"
        Me.lblState.Size = New System.Drawing.Size(46, 21)
        Me.lblState.TabIndex = 65
        Me.lblState.Text = "State"
        '
        'cboLocalGovt
        '
        Me.cboLocalGovt.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboLocalGovt.FormattingEnabled = True
        Me.cboLocalGovt.Location = New System.Drawing.Point(376, 416)
        Me.cboLocalGovt.Name = "cboLocalGovt"
        Me.cboLocalGovt.Size = New System.Drawing.Size(165, 28)
        Me.cboLocalGovt.TabIndex = 64
        '
        'lblLocalGovt
        '
        Me.lblLocalGovt.AutoSize = True
        Me.lblLocalGovt.Font = New System.Drawing.Font("Calibri", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLocalGovt.ForeColor = System.Drawing.Color.Black
        Me.lblLocalGovt.Location = New System.Drawing.Point(272, 419)
        Me.lblLocalGovt.Name = "lblLocalGovt"
        Me.lblLocalGovt.Size = New System.Drawing.Size(87, 21)
        Me.lblLocalGovt.TabIndex = 63
        Me.lblLocalGovt.Text = "Local Govt."
        '
        'cboNationality
        '
        Me.cboNationality.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboNationality.FormattingEnabled = True
        Me.cboNationality.Location = New System.Drawing.Point(101, 382)
        Me.cboNationality.Name = "cboNationality"
        Me.cboNationality.Size = New System.Drawing.Size(165, 28)
        Me.cboNationality.TabIndex = 62
        '
        'lblNationality
        '
        Me.lblNationality.AutoSize = True
        Me.lblNationality.Font = New System.Drawing.Font("Calibri", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNationality.ForeColor = System.Drawing.Color.Black
        Me.lblNationality.Location = New System.Drawing.Point(12, 385)
        Me.lblNationality.Name = "lblNationality"
        Me.lblNationality.Size = New System.Drawing.Size(86, 21)
        Me.lblNationality.TabIndex = 61
        Me.lblNationality.Text = "Nationality"
        '
        'cboRegion
        '
        Me.cboRegion.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboRegion.FormattingEnabled = True
        Me.cboRegion.Location = New System.Drawing.Point(101, 416)
        Me.cboRegion.Name = "cboRegion"
        Me.cboRegion.Size = New System.Drawing.Size(165, 28)
        Me.cboRegion.TabIndex = 60
        '
        'lblRegion
        '
        Me.lblRegion.AutoSize = True
        Me.lblRegion.Font = New System.Drawing.Font("Calibri", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRegion.ForeColor = System.Drawing.Color.Black
        Me.lblRegion.Location = New System.Drawing.Point(12, 419)
        Me.lblRegion.Name = "lblRegion"
        Me.lblRegion.Size = New System.Drawing.Size(57, 21)
        Me.lblRegion.TabIndex = 59
        Me.lblRegion.Text = "Region"
        '
        'txtWorkPlace
        '
        Me.txtWorkPlace.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtWorkPlace.Location = New System.Drawing.Point(682, 384)
        Me.txtWorkPlace.Name = "txtWorkPlace"
        Me.txtWorkPlace.Size = New System.Drawing.Size(225, 27)
        Me.txtWorkPlace.TabIndex = 68
        '
        'lblWorkPlace
        '
        Me.lblWorkPlace.AutoSize = True
        Me.lblWorkPlace.Font = New System.Drawing.Font("Calibri", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblWorkPlace.ForeColor = System.Drawing.Color.Black
        Me.lblWorkPlace.Location = New System.Drawing.Point(547, 384)
        Me.lblWorkPlace.Name = "lblWorkPlace"
        Me.lblWorkPlace.Size = New System.Drawing.Size(87, 21)
        Me.lblWorkPlace.TabIndex = 67
        Me.lblWorkPlace.Text = "Work Place"
        '
        'txtPassword
        '
        Me.txtPassword.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPassword.Location = New System.Drawing.Point(682, 318)
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtPassword.Size = New System.Drawing.Size(225, 27)
        Me.txtPassword.TabIndex = 70
        '
        'lblPassword
        '
        Me.lblPassword.AutoSize = True
        Me.lblPassword.Font = New System.Drawing.Font("Calibri", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPassword.ForeColor = System.Drawing.Color.Black
        Me.lblPassword.Location = New System.Drawing.Point(547, 321)
        Me.lblPassword.Name = "lblPassword"
        Me.lblPassword.Size = New System.Drawing.Size(118, 21)
        Me.lblPassword.TabIndex = 69
        Me.lblPassword.Text = "Login Password"
        '
        'txtRPassword
        '
        Me.txtRPassword.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRPassword.Location = New System.Drawing.Point(682, 351)
        Me.txtRPassword.Name = "txtRPassword"
        Me.txtRPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtRPassword.Size = New System.Drawing.Size(225, 27)
        Me.txtRPassword.TabIndex = 72
        '
        'lblRPassword
        '
        Me.lblRPassword.AutoSize = True
        Me.lblRPassword.Font = New System.Drawing.Font("Calibri", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRPassword.ForeColor = System.Drawing.Color.Black
        Me.lblRPassword.Location = New System.Drawing.Point(547, 354)
        Me.lblRPassword.Name = "lblRPassword"
        Me.lblRPassword.Size = New System.Drawing.Size(129, 21)
        Me.lblRPassword.TabIndex = 71
        Me.lblRPassword.Text = "Retype Password"
        '
        'txtWorkAddress
        '
        Me.txtWorkAddress.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtWorkAddress.Location = New System.Drawing.Point(682, 417)
        Me.txtWorkAddress.Name = "txtWorkAddress"
        Me.txtWorkAddress.Size = New System.Drawing.Size(225, 27)
        Me.txtWorkAddress.TabIndex = 74
        '
        'lblWorkAddres
        '
        Me.lblWorkAddres.AutoSize = True
        Me.lblWorkAddres.Font = New System.Drawing.Font("Calibri", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblWorkAddres.ForeColor = System.Drawing.Color.Black
        Me.lblWorkAddres.Location = New System.Drawing.Point(547, 419)
        Me.lblWorkAddres.Name = "lblWorkAddres"
        Me.lblWorkAddres.Size = New System.Drawing.Size(107, 21)
        Me.lblWorkAddres.TabIndex = 73
        Me.lblWorkAddres.Text = "Work Address"
        '
        'cboStatus
        '
        Me.cboStatus.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboStatus.FormattingEnabled = True
        Me.cboStatus.Items.AddRange(New Object() {"Active", "Deceased"})
        Me.cboStatus.Location = New System.Drawing.Point(682, 284)
        Me.cboStatus.Name = "cboStatus"
        Me.cboStatus.Size = New System.Drawing.Size(225, 28)
        Me.cboStatus.TabIndex = 76
        '
        'Status
        '
        Me.Status.AutoSize = True
        Me.Status.Font = New System.Drawing.Font("Calibri", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Status.ForeColor = System.Drawing.Color.Black
        Me.Status.Location = New System.Drawing.Point(547, 283)
        Me.Status.Name = "Status"
        Me.Status.Size = New System.Drawing.Size(54, 21)
        Me.Status.TabIndex = 75
        Me.Status.Text = "Status"
        '
        'btnLoad
        '
        Me.btnLoad.BackColor = System.Drawing.Color.Silver
        Me.btnLoad.FlatAppearance.BorderColor = System.Drawing.Color.Gray
        Me.btnLoad.FlatAppearance.BorderSize = 2
        Me.btnLoad.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLoad.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLoad.Location = New System.Drawing.Point(736, 245)
        Me.btnLoad.Name = "btnLoad"
        Me.btnLoad.Size = New System.Drawing.Size(171, 29)
        Me.btnLoad.TabIndex = 78
        Me.btnLoad.Text = "Load"
        Me.btnLoad.UseVisualStyleBackColor = False
        '
        'lblPleaseWait
        '
        Me.lblPleaseWait.AutoSize = True
        Me.lblPleaseWait.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPleaseWait.Location = New System.Drawing.Point(409, 523)
        Me.lblPleaseWait.Name = "lblPleaseWait"
        Me.lblPleaseWait.Size = New System.Drawing.Size(93, 15)
        Me.lblPleaseWait.TabIndex = 83
        Me.lblPleaseWait.Text = "Please wait..."
        Me.lblPleaseWait.Visible = False
        '
        'ProgressBar1
        '
        Me.ProgressBar1.Location = New System.Drawing.Point(171, 510)
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(570, 10)
        Me.ProgressBar1.TabIndex = 82
        Me.ProgressBar1.Visible = False
        '
        'btnRegister
        '
        Me.btnRegister.BackColor = System.Drawing.Color.Silver
        Me.btnRegister.FlatAppearance.BorderColor = System.Drawing.Color.Gray
        Me.btnRegister.FlatAppearance.BorderSize = 2
        Me.btnRegister.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRegister.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRegister.Location = New System.Drawing.Point(464, 467)
        Me.btnRegister.Name = "btnRegister"
        Me.btnRegister.Size = New System.Drawing.Size(157, 37)
        Me.btnRegister.TabIndex = 81
        Me.btnRegister.Text = "Register"
        Me.btnRegister.UseVisualStyleBackColor = False
        '
        'btnCancel
        '
        Me.btnCancel.BackColor = System.Drawing.Color.Silver
        Me.btnCancel.FlatAppearance.BorderColor = System.Drawing.Color.Gray
        Me.btnCancel.FlatAppearance.BorderSize = 2
        Me.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCancel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancel.Location = New System.Drawing.Point(292, 467)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(157, 37)
        Me.btnCancel.TabIndex = 80
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = False
        '
        'btnDelPic
        '
        Me.btnDelPic.BackColor = System.Drawing.Color.Transparent
        Me.btnDelPic.FlatAppearance.BorderColor = System.Drawing.Color.Gray
        Me.btnDelPic.FlatAppearance.BorderSize = 2
        Me.btnDelPic.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDelPic.Image = Global.Alumni_Management_System.My.Resources.Resources.Delete
        Me.btnDelPic.Location = New System.Drawing.Point(736, 65)
        Me.btnDelPic.Name = "btnDelPic"
        Me.btnDelPic.Size = New System.Drawing.Size(30, 29)
        Me.btnDelPic.TabIndex = 79
        Me.btnDelPic.UseVisualStyleBackColor = False
        '
        'PicProfile
        '
        Me.PicProfile.BackgroundImage = Global.Alumni_Management_System.My.Resources.Resources.Staff
        Me.PicProfile.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.PicProfile.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PicProfile.Location = New System.Drawing.Point(736, 65)
        Me.PicProfile.Name = "PicProfile"
        Me.PicProfile.Size = New System.Drawing.Size(171, 179)
        Me.PicProfile.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PicProfile.TabIndex = 77
        Me.PicProfile.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = Global.Alumni_Management_System.My.Resources.Resources.Staff
        Me.PictureBox2.Location = New System.Drawing.Point(851, 12)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(56, 39)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 7
        Me.PictureBox2.TabStop = False
        '
        'btnHome
        '
        Me.btnHome.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(82, Byte), Integer), CType(CType(135, Byte), Integer))
        Me.btnHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnHome.Image = Global.Alumni_Management_System.My.Resources.Resources.Home
        Me.btnHome.Location = New System.Drawing.Point(12, 12)
        Me.btnHome.Name = "btnHome"
        Me.btnHome.Size = New System.Drawing.Size(41, 35)
        Me.btnHome.TabIndex = 84
        Me.btnHome.UseVisualStyleBackColor = True
        '
        'Timer1
        '
        '
        'RegisterStaffForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(82, Byte), Integer), CType(CType(135, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(919, 557)
        Me.ControlBox = False
        Me.Controls.Add(Me.btnHome)
        Me.Controls.Add(Me.lblPleaseWait)
        Me.Controls.Add(Me.ProgressBar1)
        Me.Controls.Add(Me.btnRegister)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnDelPic)
        Me.Controls.Add(Me.btnLoad)
        Me.Controls.Add(Me.PicProfile)
        Me.Controls.Add(Me.cboStatus)
        Me.Controls.Add(Me.Status)
        Me.Controls.Add(Me.txtWorkAddress)
        Me.Controls.Add(Me.lblWorkAddres)
        Me.Controls.Add(Me.txtRPassword)
        Me.Controls.Add(Me.lblRPassword)
        Me.Controls.Add(Me.txtPassword)
        Me.Controls.Add(Me.lblPassword)
        Me.Controls.Add(Me.txtWorkPlace)
        Me.Controls.Add(Me.lblWorkPlace)
        Me.Controls.Add(Me.cboState)
        Me.Controls.Add(Me.lblState)
        Me.Controls.Add(Me.cboLocalGovt)
        Me.Controls.Add(Me.lblLocalGovt)
        Me.Controls.Add(Me.cboNationality)
        Me.Controls.Add(Me.lblNationality)
        Me.Controls.Add(Me.cboRegion)
        Me.Controls.Add(Me.lblRegion)
        Me.Controls.Add(Me.txtResAddress)
        Me.Controls.Add(Me.lblResAddress)
        Me.Controls.Add(Me.txtEmail)
        Me.Controls.Add(Me.lblEmail)
        Me.Controls.Add(Me.txtSubjTaught)
        Me.Controls.Add(Me.lblSubjTaught)
        Me.Controls.Add(Me.cboRank)
        Me.Controls.Add(Me.lblRank)
        Me.Controls.Add(Me.cboYrExited)
        Me.Controls.Add(Me.lblYrExited)
        Me.Controls.Add(Me.cboSection)
        Me.Controls.Add(Me.lblSection)
        Me.Controls.Add(Me.cboYrAdmit)
        Me.Controls.Add(Me.lblYrAdmit)
        Me.Controls.Add(Me.DateTimePickerBirth)
        Me.Controls.Add(Me.lblBirth)
        Me.Controls.Add(Me.txtPhone)
        Me.Controls.Add(Me.lblPhone)
        Me.Controls.Add(Me.cboGender)
        Me.Controls.Add(Me.lblGender)
        Me.Controls.Add(Me.txtFullname)
        Me.Controls.Add(Me.lblFullname)
        Me.Controls.Add(Me.txtStaffNo)
        Me.Controls.Add(Me.lblStaffNo)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.Title)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Location = New System.Drawing.Point(238, 100)
        Me.Name = "RegisterStaffForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        CType(Me.PicProfile, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents Title As System.Windows.Forms.Label
    Friend WithEvents txtStaffNo As System.Windows.Forms.TextBox
    Friend WithEvents lblStaffNo As System.Windows.Forms.Label
    Friend WithEvents txtFullname As System.Windows.Forms.TextBox
    Friend WithEvents lblFullname As System.Windows.Forms.Label
    Friend WithEvents cboGender As System.Windows.Forms.ComboBox
    Friend WithEvents lblGender As System.Windows.Forms.Label
    Friend WithEvents txtPhone As System.Windows.Forms.TextBox
    Friend WithEvents lblPhone As System.Windows.Forms.Label
    Friend WithEvents DateTimePickerBirth As System.Windows.Forms.DateTimePicker
    Friend WithEvents lblBirth As System.Windows.Forms.Label
    Friend WithEvents cboYrAdmit As System.Windows.Forms.ComboBox
    Friend WithEvents lblYrAdmit As System.Windows.Forms.Label
    Friend WithEvents cboSection As System.Windows.Forms.ComboBox
    Friend WithEvents lblSection As System.Windows.Forms.Label
    Friend WithEvents cboYrExited As System.Windows.Forms.ComboBox
    Friend WithEvents lblYrExited As System.Windows.Forms.Label
    Friend WithEvents cboRank As System.Windows.Forms.ComboBox
    Friend WithEvents lblRank As System.Windows.Forms.Label
    Friend WithEvents txtSubjTaught As System.Windows.Forms.TextBox
    Friend WithEvents lblSubjTaught As System.Windows.Forms.Label
    Friend WithEvents txtEmail As System.Windows.Forms.TextBox
    Friend WithEvents lblEmail As System.Windows.Forms.Label
    Friend WithEvents txtResAddress As System.Windows.Forms.TextBox
    Friend WithEvents lblResAddress As System.Windows.Forms.Label
    Friend WithEvents cboState As System.Windows.Forms.ComboBox
    Friend WithEvents lblState As System.Windows.Forms.Label
    Friend WithEvents cboLocalGovt As System.Windows.Forms.ComboBox
    Friend WithEvents lblLocalGovt As System.Windows.Forms.Label
    Friend WithEvents cboNationality As System.Windows.Forms.ComboBox
    Friend WithEvents lblNationality As System.Windows.Forms.Label
    Friend WithEvents cboRegion As System.Windows.Forms.ComboBox
    Friend WithEvents lblRegion As System.Windows.Forms.Label
    Friend WithEvents txtWorkPlace As System.Windows.Forms.TextBox
    Friend WithEvents lblWorkPlace As System.Windows.Forms.Label
    Friend WithEvents txtPassword As System.Windows.Forms.TextBox
    Friend WithEvents lblPassword As System.Windows.Forms.Label
    Friend WithEvents txtRPassword As System.Windows.Forms.TextBox
    Friend WithEvents lblRPassword As System.Windows.Forms.Label
    Friend WithEvents txtWorkAddress As System.Windows.Forms.TextBox
    Friend WithEvents lblWorkAddres As System.Windows.Forms.Label
    Friend WithEvents cboStatus As System.Windows.Forms.ComboBox
    Friend WithEvents Status As System.Windows.Forms.Label
    Friend WithEvents PicProfile As System.Windows.Forms.PictureBox
    Friend WithEvents btnDelPic As System.Windows.Forms.Button
    Friend WithEvents btnLoad As System.Windows.Forms.Button
    Friend WithEvents lblPleaseWait As System.Windows.Forms.Label
    Friend WithEvents ProgressBar1 As System.Windows.Forms.ProgressBar
    Friend WithEvents btnRegister As System.Windows.Forms.Button
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents btnHome As System.Windows.Forms.Button
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
End Class
