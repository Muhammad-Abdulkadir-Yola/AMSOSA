<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RegMemberForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(RegMemberForm))
        Me.Title = New System.Windows.Forms.Label()
        Me.lblReg = New System.Windows.Forms.Label()
        Me.lblFullname = New System.Windows.Forms.Label()
        Me.lblGender = New System.Windows.Forms.Label()
        Me.lblYAdmit = New System.Windows.Forms.Label()
        Me.lblYExit = New System.Windows.Forms.Label()
        Me.lblPrefect = New System.Windows.Forms.Label()
        Me.lblPhone = New System.Windows.Forms.Label()
        Me.lblAddress = New System.Windows.Forms.Label()
        Me.lblNationality = New System.Windows.Forms.Label()
        Me.lblRegion = New System.Windows.Forms.Label()
        Me.txtRegNo = New System.Windows.Forms.TextBox()
        Me.txtFullname = New System.Windows.Forms.TextBox()
        Me.lblRank = New System.Windows.Forms.Label()
        Me.cboGender = New System.Windows.Forms.ComboBox()
        Me.cboPrefect = New System.Windows.Forms.ComboBox()
        Me.cboYExit = New System.Windows.Forms.ComboBox()
        Me.cboYAdmit = New System.Windows.Forms.ComboBox()
        Me.txtPhone = New System.Windows.Forms.TextBox()
        Me.txtRAddress = New System.Windows.Forms.TextBox()
        Me.cboNationality = New System.Windows.Forms.ComboBox()
        Me.cboRegion = New System.Windows.Forms.ComboBox()
        Me.lblLGA = New System.Windows.Forms.Label()
        Me.lblState = New System.Windows.Forms.Label()
        Me.lblEmail = New System.Windows.Forms.Label()
        Me.lblMSS = New System.Windows.Forms.Label()
        Me.lblCExit = New System.Windows.Forms.Label()
        Me.CAdmit = New System.Windows.Forms.Label()
        Me.lblBirth = New System.Windows.Forms.Label()
        Me.cboRank = New System.Windows.Forms.ComboBox()
        Me.txtEmail = New System.Windows.Forms.TextBox()
        Me.cboCExit = New System.Windows.Forms.ComboBox()
        Me.cboCAdmit = New System.Windows.Forms.ComboBox()
        Me.cboMSS = New System.Windows.Forms.ComboBox()
        Me.cboState = New System.Windows.Forms.ComboBox()
        Me.cboLGA = New System.Windows.Forms.ComboBox()
        Me.DateTimePickerBirth = New System.Windows.Forms.DateTimePicker()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.txtPassword = New System.Windows.Forms.TextBox()
        Me.txtRPassword = New System.Windows.Forms.TextBox()
        Me.cboStatus = New System.Windows.Forms.ComboBox()
        Me.txtSchool = New System.Windows.Forms.TextBox()
        Me.txtWork = New System.Windows.Forms.TextBox()
        Me.txtWAddress = New System.Windows.Forms.TextBox()
        Me.btnLoad = New System.Windows.Forms.Button()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.btnRegister = New System.Windows.Forms.Button()
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar()
        Me.lblPleaseWait = New System.Windows.Forms.Label()
        Me.btnDelPic = New System.Windows.Forms.Button()
        Me.PicProfile = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.btnHome = New System.Windows.Forms.Button()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.cboSectionExit = New System.Windows.Forms.ComboBox()
        Me.lblSection = New System.Windows.Forms.Label()
        Me.cboSectionAdm = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtSchRegNo = New System.Windows.Forms.TextBox()
        Me.lblSchRegNo = New System.Windows.Forms.Label()
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
        Me.Title.Location = New System.Drawing.Point(186, 3)
        Me.Title.Name = "Title"
        Me.Title.Size = New System.Drawing.Size(507, 48)
        Me.Title.TabIndex = 1
        Me.Title.Text = "REGISTER AS MEMBER"
        Me.Title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblReg
        '
        Me.lblReg.AutoSize = True
        Me.lblReg.Font = New System.Drawing.Font("Calibri", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblReg.ForeColor = System.Drawing.Color.Black
        Me.lblReg.Location = New System.Drawing.Point(12, 87)
        Me.lblReg.Name = "lblReg"
        Me.lblReg.Size = New System.Drawing.Size(63, 21)
        Me.lblReg.TabIndex = 4
        Me.lblReg.Text = "Reg. No"
        '
        'lblFullname
        '
        Me.lblFullname.AutoSize = True
        Me.lblFullname.Font = New System.Drawing.Font("Calibri", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFullname.ForeColor = System.Drawing.Color.Black
        Me.lblFullname.Location = New System.Drawing.Point(12, 117)
        Me.lblFullname.Name = "lblFullname"
        Me.lblFullname.Size = New System.Drawing.Size(74, 21)
        Me.lblFullname.TabIndex = 5
        Me.lblFullname.Text = "Fullname"
        '
        'lblGender
        '
        Me.lblGender.AutoSize = True
        Me.lblGender.Font = New System.Drawing.Font("Calibri", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblGender.ForeColor = System.Drawing.Color.Black
        Me.lblGender.Location = New System.Drawing.Point(12, 150)
        Me.lblGender.Name = "lblGender"
        Me.lblGender.Size = New System.Drawing.Size(61, 21)
        Me.lblGender.TabIndex = 6
        Me.lblGender.Text = "Gender"
        '
        'lblYAdmit
        '
        Me.lblYAdmit.AutoSize = True
        Me.lblYAdmit.Font = New System.Drawing.Font("Calibri", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblYAdmit.ForeColor = System.Drawing.Color.Black
        Me.lblYAdmit.Location = New System.Drawing.Point(12, 252)
        Me.lblYAdmit.Name = "lblYAdmit"
        Me.lblYAdmit.Size = New System.Drawing.Size(86, 21)
        Me.lblYAdmit.TabIndex = 7
        Me.lblYAdmit.Text = "Year Admit"
        '
        'lblYExit
        '
        Me.lblYExit.AutoSize = True
        Me.lblYExit.Font = New System.Drawing.Font("Calibri", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblYExit.ForeColor = System.Drawing.Color.Black
        Me.lblYExit.Location = New System.Drawing.Point(271, 252)
        Me.lblYExit.Name = "lblYExit"
        Me.lblYExit.Size = New System.Drawing.Size(68, 21)
        Me.lblYExit.TabIndex = 8
        Me.lblYExit.Text = "Year Exit"
        '
        'lblPrefect
        '
        Me.lblPrefect.AutoSize = True
        Me.lblPrefect.Font = New System.Drawing.Font("Calibri", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPrefect.ForeColor = System.Drawing.Color.Black
        Me.lblPrefect.Location = New System.Drawing.Point(12, 320)
        Me.lblPrefect.Name = "lblPrefect"
        Me.lblPrefect.Size = New System.Drawing.Size(77, 21)
        Me.lblPrefect.TabIndex = 9
        Me.lblPrefect.Text = "Post Held"
        '
        'lblPhone
        '
        Me.lblPhone.AutoSize = True
        Me.lblPhone.Font = New System.Drawing.Font("Calibri", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPhone.ForeColor = System.Drawing.Color.Black
        Me.lblPhone.Location = New System.Drawing.Point(12, 354)
        Me.lblPhone.Name = "lblPhone"
        Me.lblPhone.Size = New System.Drawing.Size(78, 21)
        Me.lblPhone.TabIndex = 10
        Me.lblPhone.Text = "Phone No"
        '
        'lblAddress
        '
        Me.lblAddress.AutoSize = True
        Me.lblAddress.Font = New System.Drawing.Font("Calibri", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAddress.ForeColor = System.Drawing.Color.Black
        Me.lblAddress.Location = New System.Drawing.Point(12, 387)
        Me.lblAddress.Name = "lblAddress"
        Me.lblAddress.Size = New System.Drawing.Size(66, 21)
        Me.lblAddress.TabIndex = 11
        Me.lblAddress.Text = "Address"
        '
        'lblNationality
        '
        Me.lblNationality.AutoSize = True
        Me.lblNationality.Font = New System.Drawing.Font("Calibri", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNationality.ForeColor = System.Drawing.Color.Black
        Me.lblNationality.Location = New System.Drawing.Point(12, 453)
        Me.lblNationality.Name = "lblNationality"
        Me.lblNationality.Size = New System.Drawing.Size(86, 21)
        Me.lblNationality.TabIndex = 12
        Me.lblNationality.Text = "Nationality"
        '
        'lblRegion
        '
        Me.lblRegion.AutoSize = True
        Me.lblRegion.Font = New System.Drawing.Font("Calibri", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRegion.ForeColor = System.Drawing.Color.Black
        Me.lblRegion.Location = New System.Drawing.Point(12, 487)
        Me.lblRegion.Name = "lblRegion"
        Me.lblRegion.Size = New System.Drawing.Size(57, 21)
        Me.lblRegion.TabIndex = 13
        Me.lblRegion.Text = "Region"
        '
        'txtRegNo
        '
        Me.txtRegNo.BackColor = System.Drawing.Color.Silver
        Me.txtRegNo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtRegNo.Enabled = False
        Me.txtRegNo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRegNo.Location = New System.Drawing.Point(100, 81)
        Me.txtRegNo.Name = "txtRegNo"
        Me.txtRegNo.Size = New System.Drawing.Size(165, 27)
        Me.txtRegNo.TabIndex = 14
        '
        'txtFullname
        '
        Me.txtFullname.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFullname.Location = New System.Drawing.Point(100, 114)
        Me.txtFullname.Name = "txtFullname"
        Me.txtFullname.Size = New System.Drawing.Size(441, 27)
        Me.txtFullname.TabIndex = 15
        '
        'lblRank
        '
        Me.lblRank.AutoSize = True
        Me.lblRank.Font = New System.Drawing.Font("Calibri", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRank.ForeColor = System.Drawing.Color.Black
        Me.lblRank.Location = New System.Drawing.Point(271, 184)
        Me.lblRank.Name = "lblRank"
        Me.lblRank.Size = New System.Drawing.Size(44, 21)
        Me.lblRank.TabIndex = 16
        Me.lblRank.Text = "Rank"
        '
        'cboGender
        '
        Me.cboGender.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cboGender.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cboGender.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboGender.FormattingEnabled = True
        Me.cboGender.Items.AddRange(New Object() {"Male", "Female"})
        Me.cboGender.Location = New System.Drawing.Point(100, 147)
        Me.cboGender.Name = "cboGender"
        Me.cboGender.Size = New System.Drawing.Size(165, 28)
        Me.cboGender.TabIndex = 17
        '
        'cboPrefect
        '
        Me.cboPrefect.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cboPrefect.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cboPrefect.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboPrefect.FormattingEnabled = True
        Me.cboPrefect.Location = New System.Drawing.Point(100, 317)
        Me.cboPrefect.Name = "cboPrefect"
        Me.cboPrefect.Size = New System.Drawing.Size(165, 28)
        Me.cboPrefect.TabIndex = 18
        '
        'cboYExit
        '
        Me.cboYExit.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cboYExit.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cboYExit.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboYExit.FormattingEnabled = True
        Me.cboYExit.Location = New System.Drawing.Point(376, 249)
        Me.cboYExit.Name = "cboYExit"
        Me.cboYExit.Size = New System.Drawing.Size(165, 28)
        Me.cboYExit.TabIndex = 19
        '
        'cboYAdmit
        '
        Me.cboYAdmit.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cboYAdmit.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cboYAdmit.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboYAdmit.FormattingEnabled = True
        Me.cboYAdmit.Location = New System.Drawing.Point(100, 249)
        Me.cboYAdmit.Name = "cboYAdmit"
        Me.cboYAdmit.Size = New System.Drawing.Size(165, 28)
        Me.cboYAdmit.TabIndex = 20
        '
        'txtPhone
        '
        Me.txtPhone.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPhone.Location = New System.Drawing.Point(100, 351)
        Me.txtPhone.Name = "txtPhone"
        Me.txtPhone.Size = New System.Drawing.Size(165, 27)
        Me.txtPhone.TabIndex = 21
        '
        'txtRAddress
        '
        Me.txtRAddress.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRAddress.Location = New System.Drawing.Point(100, 384)
        Me.txtRAddress.Multiline = True
        Me.txtRAddress.Name = "txtRAddress"
        Me.txtRAddress.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtRAddress.Size = New System.Drawing.Size(441, 60)
        Me.txtRAddress.TabIndex = 22
        '
        'cboNationality
        '
        Me.cboNationality.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cboNationality.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cboNationality.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboNationality.FormattingEnabled = True
        Me.cboNationality.Location = New System.Drawing.Point(100, 450)
        Me.cboNationality.Name = "cboNationality"
        Me.cboNationality.Size = New System.Drawing.Size(165, 28)
        Me.cboNationality.TabIndex = 23
        '
        'cboRegion
        '
        Me.cboRegion.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cboRegion.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cboRegion.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboRegion.FormattingEnabled = True
        Me.cboRegion.Location = New System.Drawing.Point(100, 484)
        Me.cboRegion.Name = "cboRegion"
        Me.cboRegion.Size = New System.Drawing.Size(165, 28)
        Me.cboRegion.TabIndex = 24
        '
        'lblLGA
        '
        Me.lblLGA.AutoSize = True
        Me.lblLGA.Font = New System.Drawing.Font("Calibri", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLGA.ForeColor = System.Drawing.Color.Black
        Me.lblLGA.Location = New System.Drawing.Point(271, 487)
        Me.lblLGA.Name = "lblLGA"
        Me.lblLGA.Size = New System.Drawing.Size(83, 21)
        Me.lblLGA.TabIndex = 25
        Me.lblLGA.Text = "Local Govt"
        '
        'lblState
        '
        Me.lblState.AutoSize = True
        Me.lblState.Font = New System.Drawing.Font("Calibri", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblState.ForeColor = System.Drawing.Color.Black
        Me.lblState.Location = New System.Drawing.Point(271, 453)
        Me.lblState.Name = "lblState"
        Me.lblState.Size = New System.Drawing.Size(46, 21)
        Me.lblState.TabIndex = 26
        Me.lblState.Text = "State"
        '
        'lblEmail
        '
        Me.lblEmail.AutoSize = True
        Me.lblEmail.Font = New System.Drawing.Font("Calibri", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEmail.ForeColor = System.Drawing.Color.Black
        Me.lblEmail.Location = New System.Drawing.Point(271, 354)
        Me.lblEmail.Name = "lblEmail"
        Me.lblEmail.Size = New System.Drawing.Size(48, 21)
        Me.lblEmail.TabIndex = 27
        Me.lblEmail.Text = "Email"
        '
        'lblMSS
        '
        Me.lblMSS.AutoSize = True
        Me.lblMSS.Font = New System.Drawing.Font("Calibri", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMSS.ForeColor = System.Drawing.Color.Black
        Me.lblMSS.Location = New System.Drawing.Point(271, 320)
        Me.lblMSS.Name = "lblMSS"
        Me.lblMSS.Size = New System.Drawing.Size(49, 21)
        Me.lblMSS.TabIndex = 28
        Me.lblMSS.Text = "M S S"
        '
        'lblCExit
        '
        Me.lblCExit.AutoSize = True
        Me.lblCExit.Font = New System.Drawing.Font("Calibri", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCExit.ForeColor = System.Drawing.Color.Black
        Me.lblCExit.Location = New System.Drawing.Point(271, 286)
        Me.lblCExit.Name = "lblCExit"
        Me.lblCExit.Size = New System.Drawing.Size(74, 21)
        Me.lblCExit.TabIndex = 29
        Me.lblCExit.Text = "Class Exit"
        '
        'CAdmit
        '
        Me.CAdmit.AutoSize = True
        Me.CAdmit.Font = New System.Drawing.Font("Calibri", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CAdmit.ForeColor = System.Drawing.Color.Black
        Me.CAdmit.Location = New System.Drawing.Point(12, 286)
        Me.CAdmit.Name = "CAdmit"
        Me.CAdmit.Size = New System.Drawing.Size(92, 21)
        Me.CAdmit.TabIndex = 30
        Me.CAdmit.Text = "Class Admit"
        '
        'lblBirth
        '
        Me.lblBirth.AutoSize = True
        Me.lblBirth.Font = New System.Drawing.Font("Calibri", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBirth.ForeColor = System.Drawing.Color.Black
        Me.lblBirth.Location = New System.Drawing.Point(271, 150)
        Me.lblBirth.Name = "lblBirth"
        Me.lblBirth.Size = New System.Drawing.Size(98, 21)
        Me.lblBirth.TabIndex = 31
        Me.lblBirth.Text = "Date of Birth"
        '
        'cboRank
        '
        Me.cboRank.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cboRank.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cboRank.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboRank.FormattingEnabled = True
        Me.cboRank.Location = New System.Drawing.Point(376, 181)
        Me.cboRank.Name = "cboRank"
        Me.cboRank.Size = New System.Drawing.Size(165, 28)
        Me.cboRank.TabIndex = 32
        '
        'txtEmail
        '
        Me.txtEmail.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEmail.Location = New System.Drawing.Point(376, 351)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(165, 27)
        Me.txtEmail.TabIndex = 33
        '
        'cboCExit
        '
        Me.cboCExit.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cboCExit.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cboCExit.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboCExit.FormattingEnabled = True
        Me.cboCExit.Location = New System.Drawing.Point(376, 283)
        Me.cboCExit.Name = "cboCExit"
        Me.cboCExit.Size = New System.Drawing.Size(165, 28)
        Me.cboCExit.TabIndex = 34
        '
        'cboCAdmit
        '
        Me.cboCAdmit.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cboCAdmit.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cboCAdmit.DisplayMember = "Name"
        Me.cboCAdmit.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboCAdmit.FormattingEnabled = True
        Me.cboCAdmit.Location = New System.Drawing.Point(100, 283)
        Me.cboCAdmit.Name = "cboCAdmit"
        Me.cboCAdmit.Size = New System.Drawing.Size(165, 28)
        Me.cboCAdmit.TabIndex = 35
        Me.cboCAdmit.ValueMember = "Name"
        '
        'cboMSS
        '
        Me.cboMSS.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cboMSS.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cboMSS.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboMSS.FormattingEnabled = True
        Me.cboMSS.Location = New System.Drawing.Point(376, 317)
        Me.cboMSS.Name = "cboMSS"
        Me.cboMSS.Size = New System.Drawing.Size(165, 28)
        Me.cboMSS.TabIndex = 37
        '
        'cboState
        '
        Me.cboState.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cboState.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cboState.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboState.FormattingEnabled = True
        Me.cboState.Location = New System.Drawing.Point(376, 450)
        Me.cboState.Name = "cboState"
        Me.cboState.Size = New System.Drawing.Size(165, 28)
        Me.cboState.TabIndex = 38
        '
        'cboLGA
        '
        Me.cboLGA.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cboLGA.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cboLGA.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboLGA.FormattingEnabled = True
        Me.cboLGA.Location = New System.Drawing.Point(376, 484)
        Me.cboLGA.Name = "cboLGA"
        Me.cboLGA.Size = New System.Drawing.Size(165, 28)
        Me.cboLGA.TabIndex = 39
        '
        'DateTimePickerBirth
        '
        Me.DateTimePickerBirth.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateTimePickerBirth.Location = New System.Drawing.Point(376, 148)
        Me.DateTimePickerBirth.Name = "DateTimePickerBirth"
        Me.DateTimePickerBirth.Size = New System.Drawing.Size(165, 27)
        Me.DateTimePickerBirth.TabIndex = 40
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Calibri", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.ForeColor = System.Drawing.Color.Black
        Me.Label19.Location = New System.Drawing.Point(547, 387)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(95, 21)
        Me.Label19.TabIndex = 41
        Me.Label19.Text = "Current Sch."
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("Calibri", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.ForeColor = System.Drawing.Color.Black
        Me.Label20.Location = New System.Drawing.Point(12, 184)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(54, 21)
        Me.Label20.TabIndex = 42
        Me.Label20.Text = "Status"
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Font = New System.Drawing.Font("Calibri", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.ForeColor = System.Drawing.Color.Black
        Me.Label21.Location = New System.Drawing.Point(547, 323)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(118, 21)
        Me.Label21.TabIndex = 43
        Me.Label21.Text = "Login Password"
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Font = New System.Drawing.Font("Calibri", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label23.ForeColor = System.Drawing.Color.Black
        Me.Label23.Location = New System.Drawing.Point(547, 356)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(129, 21)
        Me.Label23.TabIndex = 45
        Me.Label23.Text = "Retype Password"
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Font = New System.Drawing.Font("Calibri", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label24.ForeColor = System.Drawing.Color.Black
        Me.Label24.Location = New System.Drawing.Point(547, 422)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(87, 21)
        Me.Label24.TabIndex = 46
        Me.Label24.Text = "Work Place"
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.Font = New System.Drawing.Font("Calibri", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label25.ForeColor = System.Drawing.Color.Black
        Me.Label25.Location = New System.Drawing.Point(547, 456)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(66, 21)
        Me.Label25.TabIndex = 47
        Me.Label25.Text = "Address"
        '
        'txtPassword
        '
        Me.txtPassword.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPassword.Location = New System.Drawing.Point(682, 320)
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtPassword.Size = New System.Drawing.Size(191, 27)
        Me.txtPassword.TabIndex = 48
        '
        'txtRPassword
        '
        Me.txtRPassword.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRPassword.Location = New System.Drawing.Point(682, 353)
        Me.txtRPassword.Name = "txtRPassword"
        Me.txtRPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtRPassword.Size = New System.Drawing.Size(191, 27)
        Me.txtRPassword.TabIndex = 49
        '
        'cboStatus
        '
        Me.cboStatus.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cboStatus.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cboStatus.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboStatus.FormattingEnabled = True
        Me.cboStatus.Items.AddRange(New Object() {"Active", "Deceased"})
        Me.cboStatus.Location = New System.Drawing.Point(100, 181)
        Me.cboStatus.Name = "cboStatus"
        Me.cboStatus.Size = New System.Drawing.Size(165, 28)
        Me.cboStatus.TabIndex = 50
        '
        'txtSchool
        '
        Me.txtSchool.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSchool.Location = New System.Drawing.Point(682, 386)
        Me.txtSchool.Name = "txtSchool"
        Me.txtSchool.Size = New System.Drawing.Size(191, 27)
        Me.txtSchool.TabIndex = 51
        '
        'txtWork
        '
        Me.txtWork.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtWork.Location = New System.Drawing.Point(682, 419)
        Me.txtWork.Name = "txtWork"
        Me.txtWork.Size = New System.Drawing.Size(191, 27)
        Me.txtWork.TabIndex = 52
        '
        'txtWAddress
        '
        Me.txtWAddress.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtWAddress.Location = New System.Drawing.Point(682, 453)
        Me.txtWAddress.Name = "txtWAddress"
        Me.txtWAddress.Size = New System.Drawing.Size(191, 27)
        Me.txtWAddress.TabIndex = 53
        '
        'btnLoad
        '
        Me.btnLoad.BackColor = System.Drawing.Color.Silver
        Me.btnLoad.FlatAppearance.BorderColor = System.Drawing.Color.Gray
        Me.btnLoad.FlatAppearance.BorderSize = 2
        Me.btnLoad.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLoad.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLoad.Location = New System.Drawing.Point(682, 281)
        Me.btnLoad.Name = "btnLoad"
        Me.btnLoad.Size = New System.Drawing.Size(190, 29)
        Me.btnLoad.TabIndex = 55
        Me.btnLoad.Text = "Load"
        Me.btnLoad.UseVisualStyleBackColor = False
        '
        'btnCancel
        '
        Me.btnCancel.BackColor = System.Drawing.Color.Silver
        Me.btnCancel.FlatAppearance.BorderColor = System.Drawing.Color.Gray
        Me.btnCancel.FlatAppearance.BorderSize = 2
        Me.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCancel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancel.Location = New System.Drawing.Point(284, 520)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(157, 37)
        Me.btnCancel.TabIndex = 57
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = False
        '
        'btnRegister
        '
        Me.btnRegister.BackColor = System.Drawing.Color.Silver
        Me.btnRegister.FlatAppearance.BorderColor = System.Drawing.Color.Gray
        Me.btnRegister.FlatAppearance.BorderSize = 2
        Me.btnRegister.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRegister.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRegister.Location = New System.Drawing.Point(456, 520)
        Me.btnRegister.Name = "btnRegister"
        Me.btnRegister.Size = New System.Drawing.Size(157, 37)
        Me.btnRegister.TabIndex = 58
        Me.btnRegister.Text = "Register"
        Me.btnRegister.UseVisualStyleBackColor = False
        '
        'ProgressBar1
        '
        Me.ProgressBar1.Location = New System.Drawing.Point(163, 563)
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(570, 10)
        Me.ProgressBar1.Style = System.Windows.Forms.ProgressBarStyle.Continuous
        Me.ProgressBar1.TabIndex = 59
        Me.ProgressBar1.Visible = False
        '
        'lblPleaseWait
        '
        Me.lblPleaseWait.AutoSize = True
        Me.lblPleaseWait.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPleaseWait.Location = New System.Drawing.Point(401, 576)
        Me.lblPleaseWait.Name = "lblPleaseWait"
        Me.lblPleaseWait.Size = New System.Drawing.Size(93, 15)
        Me.lblPleaseWait.TabIndex = 60
        Me.lblPleaseWait.Text = "Please wait..."
        Me.lblPleaseWait.Visible = False
        '
        'btnDelPic
        '
        Me.btnDelPic.BackColor = System.Drawing.Color.Transparent
        Me.btnDelPic.FlatAppearance.BorderColor = System.Drawing.Color.Gray
        Me.btnDelPic.FlatAppearance.BorderSize = 2
        Me.btnDelPic.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDelPic.Image = Global.Alumni_Management_System.My.Resources.Resources.Delete
        Me.btnDelPic.Location = New System.Drawing.Point(682, 84)
        Me.btnDelPic.Name = "btnDelPic"
        Me.btnDelPic.Size = New System.Drawing.Size(30, 29)
        Me.btnDelPic.TabIndex = 56
        Me.btnDelPic.UseVisualStyleBackColor = False
        '
        'PicProfile
        '
        Me.PicProfile.BackgroundImage = Global.Alumni_Management_System.My.Resources.Resources.PicMember
        Me.PicProfile.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PicProfile.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PicProfile.Location = New System.Drawing.Point(682, 84)
        Me.PicProfile.Name = "PicProfile"
        Me.PicProfile.Size = New System.Drawing.Size(189, 196)
        Me.PicProfile.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PicProfile.TabIndex = 54
        Me.PicProfile.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = Global.Alumni_Management_System.My.Resources.Resources.Member
        Me.PictureBox2.Location = New System.Drawing.Point(831, 12)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(56, 39)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 3
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
        Me.btnHome.TabIndex = 61
        Me.btnHome.UseVisualStyleBackColor = True
        '
        'Timer1
        '
        Me.Timer1.Interval = 500
        '
        'cboSectionExit
        '
        Me.cboSectionExit.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cboSectionExit.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cboSectionExit.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboSectionExit.FormattingEnabled = True
        Me.cboSectionExit.Location = New System.Drawing.Point(376, 215)
        Me.cboSectionExit.Name = "cboSectionExit"
        Me.cboSectionExit.Size = New System.Drawing.Size(165, 28)
        Me.cboSectionExit.TabIndex = 63
        '
        'lblSection
        '
        Me.lblSection.AutoSize = True
        Me.lblSection.Font = New System.Drawing.Font("Calibri", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSection.ForeColor = System.Drawing.Color.Black
        Me.lblSection.Location = New System.Drawing.Point(271, 218)
        Me.lblSection.Name = "lblSection"
        Me.lblSection.Size = New System.Drawing.Size(89, 21)
        Me.lblSection.TabIndex = 62
        Me.lblSection.Text = "Section Exit"
        '
        'cboSectionAdm
        '
        Me.cboSectionAdm.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cboSectionAdm.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cboSectionAdm.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboSectionAdm.FormattingEnabled = True
        Me.cboSectionAdm.Location = New System.Drawing.Point(100, 215)
        Me.cboSectionAdm.Name = "cboSectionAdm"
        Me.cboSectionAdm.Size = New System.Drawing.Size(165, 28)
        Me.cboSectionAdm.TabIndex = 65
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Calibri", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(12, 218)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(87, 21)
        Me.Label2.TabIndex = 64
        Me.Label2.Text = "Section Ad."
        '
        'txtSchRegNo
        '
        Me.txtSchRegNo.BackColor = System.Drawing.Color.Silver
        Me.txtSchRegNo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtSchRegNo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSchRegNo.Location = New System.Drawing.Point(376, 81)
        Me.txtSchRegNo.Name = "txtSchRegNo"
        Me.txtSchRegNo.Size = New System.Drawing.Size(165, 27)
        Me.txtSchRegNo.TabIndex = 67
        '
        'lblSchRegNo
        '
        Me.lblSchRegNo.AutoSize = True
        Me.lblSchRegNo.Font = New System.Drawing.Font("Calibri", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSchRegNo.ForeColor = System.Drawing.Color.Black
        Me.lblSchRegNo.Location = New System.Drawing.Point(271, 87)
        Me.lblSchRegNo.Name = "lblSchRegNo"
        Me.lblSchRegNo.Size = New System.Drawing.Size(95, 21)
        Me.lblSchRegNo.TabIndex = 66
        Me.lblSchRegNo.Text = "Sch. Reg. No"
        '
        'RegMemberForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(82, Byte), Integer), CType(CType(135, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(899, 600)
        Me.ControlBox = False
        Me.Controls.Add(Me.txtSchRegNo)
        Me.Controls.Add(Me.lblSchRegNo)
        Me.Controls.Add(Me.cboSectionAdm)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.cboSectionExit)
        Me.Controls.Add(Me.lblSection)
        Me.Controls.Add(Me.btnHome)
        Me.Controls.Add(Me.lblPleaseWait)
        Me.Controls.Add(Me.ProgressBar1)
        Me.Controls.Add(Me.btnRegister)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnDelPic)
        Me.Controls.Add(Me.btnLoad)
        Me.Controls.Add(Me.PicProfile)
        Me.Controls.Add(Me.txtWAddress)
        Me.Controls.Add(Me.txtWork)
        Me.Controls.Add(Me.txtSchool)
        Me.Controls.Add(Me.cboStatus)
        Me.Controls.Add(Me.txtRPassword)
        Me.Controls.Add(Me.txtPassword)
        Me.Controls.Add(Me.Label25)
        Me.Controls.Add(Me.Label24)
        Me.Controls.Add(Me.Label23)
        Me.Controls.Add(Me.Label21)
        Me.Controls.Add(Me.Label20)
        Me.Controls.Add(Me.Label19)
        Me.Controls.Add(Me.DateTimePickerBirth)
        Me.Controls.Add(Me.cboLGA)
        Me.Controls.Add(Me.cboState)
        Me.Controls.Add(Me.cboMSS)
        Me.Controls.Add(Me.cboCAdmit)
        Me.Controls.Add(Me.cboCExit)
        Me.Controls.Add(Me.txtEmail)
        Me.Controls.Add(Me.cboRank)
        Me.Controls.Add(Me.lblBirth)
        Me.Controls.Add(Me.CAdmit)
        Me.Controls.Add(Me.lblCExit)
        Me.Controls.Add(Me.lblMSS)
        Me.Controls.Add(Me.lblEmail)
        Me.Controls.Add(Me.lblState)
        Me.Controls.Add(Me.lblLGA)
        Me.Controls.Add(Me.cboRegion)
        Me.Controls.Add(Me.cboNationality)
        Me.Controls.Add(Me.txtRAddress)
        Me.Controls.Add(Me.txtPhone)
        Me.Controls.Add(Me.cboYAdmit)
        Me.Controls.Add(Me.cboYExit)
        Me.Controls.Add(Me.cboPrefect)
        Me.Controls.Add(Me.cboGender)
        Me.Controls.Add(Me.lblRank)
        Me.Controls.Add(Me.txtFullname)
        Me.Controls.Add(Me.txtRegNo)
        Me.Controls.Add(Me.lblRegion)
        Me.Controls.Add(Me.lblNationality)
        Me.Controls.Add(Me.lblAddress)
        Me.Controls.Add(Me.lblPhone)
        Me.Controls.Add(Me.lblPrefect)
        Me.Controls.Add(Me.lblYExit)
        Me.Controls.Add(Me.lblYAdmit)
        Me.Controls.Add(Me.lblGender)
        Me.Controls.Add(Me.lblFullname)
        Me.Controls.Add(Me.lblReg)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.Title)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Location = New System.Drawing.Point(241, 90)
        Me.Name = "RegMemberForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = " "
        CType(Me.PicProfile, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Title As System.Windows.Forms.Label
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents lblReg As System.Windows.Forms.Label
    Friend WithEvents lblFullname As System.Windows.Forms.Label
    Friend WithEvents lblGender As System.Windows.Forms.Label
    Friend WithEvents lblYAdmit As System.Windows.Forms.Label
    Friend WithEvents lblYExit As System.Windows.Forms.Label
    Friend WithEvents lblPrefect As System.Windows.Forms.Label
    Friend WithEvents lblPhone As System.Windows.Forms.Label
    Friend WithEvents lblAddress As System.Windows.Forms.Label
    Friend WithEvents lblNationality As System.Windows.Forms.Label
    Friend WithEvents lblRegion As System.Windows.Forms.Label
    Friend WithEvents txtRegNo As System.Windows.Forms.TextBox
    Friend WithEvents txtFullname As System.Windows.Forms.TextBox
    Friend WithEvents lblRank As System.Windows.Forms.Label
    Friend WithEvents cboGender As System.Windows.Forms.ComboBox
    Friend WithEvents cboPrefect As System.Windows.Forms.ComboBox
    Friend WithEvents cboYExit As System.Windows.Forms.ComboBox
    Friend WithEvents cboYAdmit As System.Windows.Forms.ComboBox
    Friend WithEvents txtPhone As System.Windows.Forms.TextBox
    Friend WithEvents txtRAddress As System.Windows.Forms.TextBox
    Friend WithEvents cboNationality As System.Windows.Forms.ComboBox
    Friend WithEvents cboRegion As System.Windows.Forms.ComboBox
    Friend WithEvents lblLGA As System.Windows.Forms.Label
    Friend WithEvents lblState As System.Windows.Forms.Label
    Friend WithEvents lblEmail As System.Windows.Forms.Label
    Friend WithEvents lblMSS As System.Windows.Forms.Label
    Friend WithEvents lblCExit As System.Windows.Forms.Label
    Friend WithEvents CAdmit As System.Windows.Forms.Label
    Friend WithEvents lblBirth As System.Windows.Forms.Label
    Friend WithEvents cboRank As System.Windows.Forms.ComboBox
    Friend WithEvents txtEmail As System.Windows.Forms.TextBox
    Friend WithEvents cboCExit As System.Windows.Forms.ComboBox
    Friend WithEvents cboCAdmit As System.Windows.Forms.ComboBox
    Friend WithEvents cboMSS As System.Windows.Forms.ComboBox
    Friend WithEvents cboState As System.Windows.Forms.ComboBox
    Friend WithEvents cboLGA As System.Windows.Forms.ComboBox
    Friend WithEvents DateTimePickerBirth As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents Label24 As System.Windows.Forms.Label
    Friend WithEvents Label25 As System.Windows.Forms.Label
    Friend WithEvents txtPassword As System.Windows.Forms.TextBox
    Friend WithEvents txtRPassword As System.Windows.Forms.TextBox
    Friend WithEvents cboStatus As System.Windows.Forms.ComboBox
    Friend WithEvents txtSchool As System.Windows.Forms.TextBox
    Friend WithEvents txtWork As System.Windows.Forms.TextBox
    Friend WithEvents txtWAddress As System.Windows.Forms.TextBox
    Friend WithEvents PicProfile As System.Windows.Forms.PictureBox
    Friend WithEvents btnLoad As System.Windows.Forms.Button
    Friend WithEvents btnDelPic As System.Windows.Forms.Button
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents btnRegister As System.Windows.Forms.Button
    Friend WithEvents ProgressBar1 As System.Windows.Forms.ProgressBar
    Friend WithEvents lblPleaseWait As System.Windows.Forms.Label
    Friend WithEvents btnHome As System.Windows.Forms.Button
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents cboSectionExit As System.Windows.Forms.ComboBox
    Friend WithEvents lblSection As System.Windows.Forms.Label
    Friend WithEvents cboSectionAdm As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtSchRegNo As System.Windows.Forms.TextBox
    Friend WithEvents lblSchRegNo As System.Windows.Forms.Label
    'Friend WithEvents AlumniDataSet As Alumni_Management_System.AlumniDataSet
    'Friend WithEvents ClassTableAdapter As Alumni_Management_System.AlumniDataSetTableAdapters.ClassTableAdapter
End Class
