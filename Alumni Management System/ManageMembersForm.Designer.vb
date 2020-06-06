<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ManageMembersForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ManageMembersForm))
        Me.btnHome = New System.Windows.Forms.Button()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Title = New System.Windows.Forms.Label()
        Me.btnRefresh = New System.Windows.Forms.Button()
        Me.lblRegNo = New System.Windows.Forms.Label()
        Me.btnView = New System.Windows.Forms.Button()
        Me.txtRegNo = New System.Windows.Forms.TextBox()
        Me.btnEdit = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cboYExit = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cboYAdmit = New System.Windows.Forms.ComboBox()
        Me.lblRank = New System.Windows.Forms.Label()
        Me.cboRank = New System.Windows.Forms.ComboBox()
        Me.btnFilter = New System.Windows.Forms.Button()
        Me.lblRegion = New System.Windows.Forms.Label()
        Me.lblState = New System.Windows.Forms.Label()
        Me.lblLocalGovt = New System.Windows.Forms.Label()
        Me.lblNationality = New System.Windows.Forms.Label()
        Me.cboRegion = New System.Windows.Forms.ComboBox()
        Me.cboState = New System.Windows.Forms.ComboBox()
        Me.cboSectionExit = New System.Windows.Forms.ComboBox()
        Me.lblSection = New System.Windows.Forms.Label()
        Me.cboSectionAdm = New System.Windows.Forms.ComboBox()
        Me.lblPrefect = New System.Windows.Forms.Label()
        Me.cboLocalGovt = New System.Windows.Forms.ComboBox()
        Me.cboNationality = New System.Windows.Forms.ComboBox()
        Me.lblGender = New System.Windows.Forms.Label()
        Me.lblStatus = New System.Windows.Forms.Label()
        Me.cboGender = New System.Windows.Forms.ComboBox()
        Me.cboStatus = New System.Windows.Forms.ComboBox()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.txtSearchName = New System.Windows.Forms.TextBox()
        Me.DataGridViewMembers = New System.Windows.Forms.DataGridView()
        Me.RegNoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FullnameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GenderDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SectionAdmittedDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.YearAdmittedDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ClassAdmittedDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SectionExitedDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.YearExitedDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ClassExitedDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PresentSchDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AddressDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BirthDateDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.WorkPlaceDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RankDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PrefectDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MSSDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PhoneDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EmailDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.WorkAddressDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NationalityDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RegionDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.StateDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LGADataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.StatusDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SchRegNoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MemberBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.AlumniDataSet = New Global.Alumni_Management_System.AlumniDataSet()
        Me.lblFullname = New System.Windows.Forms.Label()
        Me.MemberTableAdapter = New Global.Alumni_Management_System.AlumniDataSetTableAdapters.MemberTableAdapter()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.DataGridViewMembers, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MemberBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AlumniDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnHome
        '
        Me.btnHome.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(82, Byte), Integer), CType(CType(135, Byte), Integer))
        Me.btnHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnHome.Image = Global.Alumni_Management_System.My.Resources.Resources.Home
        Me.btnHome.Location = New System.Drawing.Point(12, 12)
        Me.btnHome.Name = "btnHome"
        Me.btnHome.Size = New System.Drawing.Size(41, 35)
        Me.btnHome.TabIndex = 72
        Me.btnHome.UseVisualStyleBackColor = True
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = Global.Alumni_Management_System.My.Resources.Resources.Members
        Me.PictureBox2.Location = New System.Drawing.Point(847, 12)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(56, 39)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 71
        Me.PictureBox2.TabStop = False
        '
        'Title
        '
        Me.Title.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(117, Byte), Integer), CType(CType(182, Byte), Integer))
        Me.Title.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Title.Font = New System.Drawing.Font("Rockwell", 18.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Title.ForeColor = System.Drawing.Color.FromArgb(CType(CType(220, Byte), Integer), CType(CType(56, Byte), Integer), CType(CType(118, Byte), Integer))
        Me.Title.Location = New System.Drawing.Point(199, 2)
        Me.Title.Name = "Title"
        Me.Title.Size = New System.Drawing.Size(507, 48)
        Me.Title.TabIndex = 70
        Me.Title.Text = "MANAGE MEMBER"
        Me.Title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnRefresh
        '
        Me.btnRefresh.BackColor = System.Drawing.Color.Silver
        Me.btnRefresh.FlatAppearance.BorderColor = System.Drawing.Color.Gray
        Me.btnRefresh.FlatAppearance.BorderSize = 2
        Me.btnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRefresh.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRefresh.Location = New System.Drawing.Point(617, 517)
        Me.btnRefresh.Name = "btnRefresh"
        Me.btnRefresh.Size = New System.Drawing.Size(157, 37)
        Me.btnRefresh.TabIndex = 82
        Me.btnRefresh.Text = "Refresh"
        Me.btnRefresh.UseVisualStyleBackColor = False
        '
        'lblRegNo
        '
        Me.lblRegNo.AutoSize = True
        Me.lblRegNo.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRegNo.ForeColor = System.Drawing.Color.Black
        Me.lblRegNo.Location = New System.Drawing.Point(712, 74)
        Me.lblRegNo.Name = "lblRegNo"
        Me.lblRegNo.Size = New System.Drawing.Size(60, 19)
        Me.lblRegNo.TabIndex = 77
        Me.lblRegNo.Text = "Reg. No"
        '
        'btnView
        '
        Me.btnView.BackColor = System.Drawing.Color.Silver
        Me.btnView.FlatAppearance.BorderColor = System.Drawing.Color.Gray
        Me.btnView.FlatAppearance.BorderSize = 2
        Me.btnView.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnView.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnView.Location = New System.Drawing.Point(445, 517)
        Me.btnView.Name = "btnView"
        Me.btnView.Size = New System.Drawing.Size(157, 37)
        Me.btnView.TabIndex = 81
        Me.btnView.Text = "View record"
        Me.btnView.UseVisualStyleBackColor = False
        '
        'txtRegNo
        '
        Me.txtRegNo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRegNo.Location = New System.Drawing.Point(716, 96)
        Me.txtRegNo.Name = "txtRegNo"
        Me.txtRegNo.Size = New System.Drawing.Size(184, 27)
        Me.txtRegNo.TabIndex = 76
        '
        'btnEdit
        '
        Me.btnEdit.BackColor = System.Drawing.Color.Silver
        Me.btnEdit.FlatAppearance.BorderColor = System.Drawing.Color.Gray
        Me.btnEdit.FlatAppearance.BorderSize = 2
        Me.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEdit.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEdit.Location = New System.Drawing.Point(273, 517)
        Me.btnEdit.Name = "btnEdit"
        Me.btnEdit.Size = New System.Drawing.Size(157, 37)
        Me.btnEdit.TabIndex = 80
        Me.btnEdit.Text = "Edit"
        Me.btnEdit.UseVisualStyleBackColor = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.cboYExit)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.cboYAdmit)
        Me.GroupBox1.Controls.Add(Me.lblRank)
        Me.GroupBox1.Controls.Add(Me.cboRank)
        Me.GroupBox1.Controls.Add(Me.btnFilter)
        Me.GroupBox1.Controls.Add(Me.lblRegion)
        Me.GroupBox1.Controls.Add(Me.lblState)
        Me.GroupBox1.Controls.Add(Me.lblLocalGovt)
        Me.GroupBox1.Controls.Add(Me.lblNationality)
        Me.GroupBox1.Controls.Add(Me.cboRegion)
        Me.GroupBox1.Controls.Add(Me.cboState)
        Me.GroupBox1.Controls.Add(Me.cboSectionExit)
        Me.GroupBox1.Controls.Add(Me.lblSection)
        Me.GroupBox1.Controls.Add(Me.cboSectionAdm)
        Me.GroupBox1.Controls.Add(Me.lblPrefect)
        Me.GroupBox1.Controls.Add(Me.cboLocalGovt)
        Me.GroupBox1.Controls.Add(Me.cboNationality)
        Me.GroupBox1.Controls.Add(Me.lblGender)
        Me.GroupBox1.Controls.Add(Me.lblStatus)
        Me.GroupBox1.Controls.Add(Me.cboGender)
        Me.GroupBox1.Controls.Add(Me.cboStatus)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 121)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(894, 125)
        Me.GroupBox1.TabIndex = 75
        Me.GroupBox1.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(742, 69)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(123, 19)
        Me.Label1.TabIndex = 69
        Me.Label1.Text = "Year of Exit/Grad."
        '
        'cboYExit
        '
        Me.cboYExit.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboYExit.FormattingEnabled = True
        Me.cboYExit.Location = New System.Drawing.Point(746, 91)
        Me.cboYExit.Name = "cboYExit"
        Me.cboYExit.Size = New System.Drawing.Size(142, 28)
        Me.cboYExit.TabIndex = 68
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(744, 16)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(125, 19)
        Me.Label2.TabIndex = 67
        Me.Label2.Text = "Year of Admission"
        '
        'cboYAdmit
        '
        Me.cboYAdmit.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboYAdmit.FormattingEnabled = True
        Me.cboYAdmit.Location = New System.Drawing.Point(746, 38)
        Me.cboYAdmit.Name = "cboYAdmit"
        Me.cboYAdmit.Size = New System.Drawing.Size(142, 28)
        Me.cboYAdmit.TabIndex = 66
        '
        'lblRank
        '
        Me.lblRank.AutoSize = True
        Me.lblRank.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRank.ForeColor = System.Drawing.Color.Black
        Me.lblRank.Location = New System.Drawing.Point(298, 16)
        Me.lblRank.Name = "lblRank"
        Me.lblRank.Size = New System.Drawing.Size(41, 19)
        Me.lblRank.TabIndex = 65
        Me.lblRank.Text = "Rank"
        '
        'cboRank
        '
        Me.cboRank.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboRank.FormattingEnabled = True
        Me.cboRank.Location = New System.Drawing.Point(302, 38)
        Me.cboRank.Name = "cboRank"
        Me.cboRank.Size = New System.Drawing.Size(142, 28)
        Me.cboRank.TabIndex = 64
        '
        'btnFilter
        '
        Me.btnFilter.BackColor = System.Drawing.Color.Silver
        Me.btnFilter.FlatAppearance.BorderColor = System.Drawing.Color.Gray
        Me.btnFilter.FlatAppearance.BorderSize = 2
        Me.btnFilter.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnFilter.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnFilter.Location = New System.Drawing.Point(6, 72)
        Me.btnFilter.Name = "btnFilter"
        Me.btnFilter.Size = New System.Drawing.Size(142, 47)
        Me.btnFilter.TabIndex = 63
        Me.btnFilter.Text = "Filter"
        Me.btnFilter.UseVisualStyleBackColor = False
        '
        'lblRegion
        '
        Me.lblRegion.AutoSize = True
        Me.lblRegion.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRegion.ForeColor = System.Drawing.Color.Black
        Me.lblRegion.Location = New System.Drawing.Point(300, 69)
        Me.lblRegion.Name = "lblRegion"
        Me.lblRegion.Size = New System.Drawing.Size(54, 19)
        Me.lblRegion.TabIndex = 37
        Me.lblRegion.Text = "Region"
        '
        'lblState
        '
        Me.lblState.AutoSize = True
        Me.lblState.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblState.ForeColor = System.Drawing.Color.Black
        Me.lblState.Location = New System.Drawing.Point(446, 69)
        Me.lblState.Name = "lblState"
        Me.lblState.Size = New System.Drawing.Size(42, 19)
        Me.lblState.TabIndex = 36
        Me.lblState.Text = "State"
        '
        'lblLocalGovt
        '
        Me.lblLocalGovt.AutoSize = True
        Me.lblLocalGovt.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLocalGovt.ForeColor = System.Drawing.Color.Black
        Me.lblLocalGovt.Location = New System.Drawing.Point(594, 69)
        Me.lblLocalGovt.Name = "lblLocalGovt"
        Me.lblLocalGovt.Size = New System.Drawing.Size(77, 19)
        Me.lblLocalGovt.TabIndex = 35
        Me.lblLocalGovt.Text = "Local Govt"
        '
        'lblNationality
        '
        Me.lblNationality.AutoSize = True
        Me.lblNationality.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNationality.ForeColor = System.Drawing.Color.Black
        Me.lblNationality.Location = New System.Drawing.Point(154, 69)
        Me.lblNationality.Name = "lblNationality"
        Me.lblNationality.Size = New System.Drawing.Size(80, 19)
        Me.lblNationality.TabIndex = 33
        Me.lblNationality.Text = "Nationality"
        '
        'cboRegion
        '
        Me.cboRegion.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboRegion.FormattingEnabled = True
        Me.cboRegion.Location = New System.Drawing.Point(302, 91)
        Me.cboRegion.Name = "cboRegion"
        Me.cboRegion.Size = New System.Drawing.Size(142, 28)
        Me.cboRegion.TabIndex = 32
        '
        'cboState
        '
        Me.cboState.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboState.FormattingEnabled = True
        Me.cboState.Location = New System.Drawing.Point(450, 91)
        Me.cboState.Name = "cboState"
        Me.cboState.Size = New System.Drawing.Size(142, 28)
        Me.cboState.TabIndex = 31
        '
        'cboSectionExit
        '
        Me.cboSectionExit.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboSectionExit.FormattingEnabled = True
        Me.cboSectionExit.Location = New System.Drawing.Point(598, 38)
        Me.cboSectionExit.Name = "cboSectionExit"
        Me.cboSectionExit.Size = New System.Drawing.Size(142, 28)
        Me.cboSectionExit.TabIndex = 21
        '
        'lblSection
        '
        Me.lblSection.AutoSize = True
        Me.lblSection.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSection.ForeColor = System.Drawing.Color.Black
        Me.lblSection.Location = New System.Drawing.Point(594, 16)
        Me.lblSection.Name = "lblSection"
        Me.lblSection.Size = New System.Drawing.Size(100, 19)
        Me.lblSection.TabIndex = 26
        Me.lblSection.Text = "Section Exited"
        '
        'cboSectionAdm
        '
        Me.cboSectionAdm.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboSectionAdm.FormattingEnabled = True
        Me.cboSectionAdm.Location = New System.Drawing.Point(450, 38)
        Me.cboSectionAdm.Name = "cboSectionAdm"
        Me.cboSectionAdm.Size = New System.Drawing.Size(142, 28)
        Me.cboSectionAdm.TabIndex = 22
        '
        'lblPrefect
        '
        Me.lblPrefect.AutoSize = True
        Me.lblPrefect.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPrefect.ForeColor = System.Drawing.Color.Black
        Me.lblPrefect.Location = New System.Drawing.Point(448, 16)
        Me.lblPrefect.Name = "lblPrefect"
        Me.lblPrefect.Size = New System.Drawing.Size(128, 19)
        Me.lblPrefect.TabIndex = 27
        Me.lblPrefect.Text = "Section Amitted to"
        '
        'cboLocalGovt
        '
        Me.cboLocalGovt.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboLocalGovt.FormattingEnabled = True
        Me.cboLocalGovt.Location = New System.Drawing.Point(598, 91)
        Me.cboLocalGovt.Name = "cboLocalGovt"
        Me.cboLocalGovt.Size = New System.Drawing.Size(142, 28)
        Me.cboLocalGovt.TabIndex = 30
        '
        'cboNationality
        '
        Me.cboNationality.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboNationality.FormattingEnabled = True
        Me.cboNationality.Location = New System.Drawing.Point(154, 91)
        Me.cboNationality.Name = "cboNationality"
        Me.cboNationality.Size = New System.Drawing.Size(142, 28)
        Me.cboNationality.TabIndex = 28
        '
        'lblGender
        '
        Me.lblGender.AutoSize = True
        Me.lblGender.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblGender.ForeColor = System.Drawing.Color.Black
        Me.lblGender.Location = New System.Drawing.Point(150, 16)
        Me.lblGender.Name = "lblGender"
        Me.lblGender.Size = New System.Drawing.Size(56, 19)
        Me.lblGender.TabIndex = 25
        Me.lblGender.Text = "Gender"
        '
        'lblStatus
        '
        Me.lblStatus.AutoSize = True
        Me.lblStatus.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStatus.ForeColor = System.Drawing.Color.Black
        Me.lblStatus.Location = New System.Drawing.Point(6, 16)
        Me.lblStatus.Name = "lblStatus"
        Me.lblStatus.Size = New System.Drawing.Size(49, 19)
        Me.lblStatus.TabIndex = 23
        Me.lblStatus.Text = "Status"
        '
        'cboGender
        '
        Me.cboGender.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboGender.FormattingEnabled = True
        Me.cboGender.Items.AddRange(New Object() {"Male", "Female"})
        Me.cboGender.Location = New System.Drawing.Point(154, 38)
        Me.cboGender.Name = "cboGender"
        Me.cboGender.Size = New System.Drawing.Size(142, 28)
        Me.cboGender.TabIndex = 20
        '
        'cboStatus
        '
        Me.cboStatus.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboStatus.FormattingEnabled = True
        Me.cboStatus.Items.AddRange(New Object() {"Active", "Deceased"})
        Me.cboStatus.Location = New System.Drawing.Point(6, 38)
        Me.cboStatus.Name = "cboStatus"
        Me.cboStatus.Size = New System.Drawing.Size(142, 28)
        Me.cboStatus.TabIndex = 18
        '
        'btnAdd
        '
        Me.btnAdd.BackColor = System.Drawing.Color.Silver
        Me.btnAdd.FlatAppearance.BorderColor = System.Drawing.Color.Gray
        Me.btnAdd.FlatAppearance.BorderSize = 2
        Me.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAdd.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAdd.Location = New System.Drawing.Point(101, 517)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(157, 37)
        Me.btnAdd.TabIndex = 79
        Me.btnAdd.Text = "Add new member"
        Me.btnAdd.UseVisualStyleBackColor = False
        '
        'txtSearchName
        '
        Me.txtSearchName.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSearchName.Location = New System.Drawing.Point(18, 96)
        Me.txtSearchName.Name = "txtSearchName"
        Me.txtSearchName.Size = New System.Drawing.Size(692, 27)
        Me.txtSearchName.TabIndex = 74
        '
        'DataGridViewMembers
        '
        Me.DataGridViewMembers.AllowUserToAddRows = False
        Me.DataGridViewMembers.AllowUserToDeleteRows = False
        Me.DataGridViewMembers.AutoGenerateColumns = False
        Me.DataGridViewMembers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridViewMembers.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.RegNoDataGridViewTextBoxColumn, Me.FullnameDataGridViewTextBoxColumn, Me.GenderDataGridViewTextBoxColumn, Me.SectionAdmittedDataGridViewTextBoxColumn, Me.YearAdmittedDataGridViewTextBoxColumn, Me.ClassAdmittedDataGridViewTextBoxColumn, Me.SectionExitedDataGridViewTextBoxColumn, Me.YearExitedDataGridViewTextBoxColumn, Me.ClassExitedDataGridViewTextBoxColumn, Me.PresentSchDataGridViewTextBoxColumn, Me.AddressDataGridViewTextBoxColumn, Me.BirthDateDataGridViewTextBoxColumn, Me.WorkPlaceDataGridViewTextBoxColumn, Me.RankDataGridViewTextBoxColumn, Me.PrefectDataGridViewTextBoxColumn, Me.MSSDataGridViewTextBoxColumn, Me.PhoneDataGridViewTextBoxColumn, Me.EmailDataGridViewTextBoxColumn, Me.WorkAddressDataGridViewTextBoxColumn, Me.NationalityDataGridViewTextBoxColumn, Me.RegionDataGridViewTextBoxColumn, Me.StateDataGridViewTextBoxColumn, Me.LGADataGridViewTextBoxColumn, Me.StatusDataGridViewTextBoxColumn, Me.SchRegNoDataGridViewTextBoxColumn})
        Me.DataGridViewMembers.DataSource = Me.MemberBindingSource
        Me.DataGridViewMembers.Location = New System.Drawing.Point(12, 252)
        Me.DataGridViewMembers.Name = "DataGridViewMembers"
        Me.DataGridViewMembers.ReadOnly = True
        Me.DataGridViewMembers.Size = New System.Drawing.Size(894, 256)
        Me.DataGridViewMembers.TabIndex = 78
        '
        'RegNoDataGridViewTextBoxColumn
        '
        Me.RegNoDataGridViewTextBoxColumn.DataPropertyName = "RegNo"
        Me.RegNoDataGridViewTextBoxColumn.HeaderText = "RegNo"
        Me.RegNoDataGridViewTextBoxColumn.Name = "RegNoDataGridViewTextBoxColumn"
        Me.RegNoDataGridViewTextBoxColumn.ReadOnly = True
        '
        'FullnameDataGridViewTextBoxColumn
        '
        Me.FullnameDataGridViewTextBoxColumn.DataPropertyName = "Fullname"
        Me.FullnameDataGridViewTextBoxColumn.HeaderText = "Fullname"
        Me.FullnameDataGridViewTextBoxColumn.Name = "FullnameDataGridViewTextBoxColumn"
        Me.FullnameDataGridViewTextBoxColumn.ReadOnly = True
        '
        'GenderDataGridViewTextBoxColumn
        '
        Me.GenderDataGridViewTextBoxColumn.DataPropertyName = "Gender"
        Me.GenderDataGridViewTextBoxColumn.HeaderText = "Gender"
        Me.GenderDataGridViewTextBoxColumn.Name = "GenderDataGridViewTextBoxColumn"
        Me.GenderDataGridViewTextBoxColumn.ReadOnly = True
        '
        'SectionAdmittedDataGridViewTextBoxColumn
        '
        Me.SectionAdmittedDataGridViewTextBoxColumn.DataPropertyName = "SectionAdmitted"
        Me.SectionAdmittedDataGridViewTextBoxColumn.HeaderText = "SectionAdmitted"
        Me.SectionAdmittedDataGridViewTextBoxColumn.Name = "SectionAdmittedDataGridViewTextBoxColumn"
        Me.SectionAdmittedDataGridViewTextBoxColumn.ReadOnly = True
        '
        'YearAdmittedDataGridViewTextBoxColumn
        '
        Me.YearAdmittedDataGridViewTextBoxColumn.DataPropertyName = "YearAdmitted"
        Me.YearAdmittedDataGridViewTextBoxColumn.HeaderText = "YearAdmitted"
        Me.YearAdmittedDataGridViewTextBoxColumn.Name = "YearAdmittedDataGridViewTextBoxColumn"
        Me.YearAdmittedDataGridViewTextBoxColumn.ReadOnly = True
        '
        'ClassAdmittedDataGridViewTextBoxColumn
        '
        Me.ClassAdmittedDataGridViewTextBoxColumn.DataPropertyName = "ClassAdmitted"
        Me.ClassAdmittedDataGridViewTextBoxColumn.HeaderText = "ClassAdmitted"
        Me.ClassAdmittedDataGridViewTextBoxColumn.Name = "ClassAdmittedDataGridViewTextBoxColumn"
        Me.ClassAdmittedDataGridViewTextBoxColumn.ReadOnly = True
        '
        'SectionExitedDataGridViewTextBoxColumn
        '
        Me.SectionExitedDataGridViewTextBoxColumn.DataPropertyName = "SectionExited"
        Me.SectionExitedDataGridViewTextBoxColumn.HeaderText = "SectionExited"
        Me.SectionExitedDataGridViewTextBoxColumn.Name = "SectionExitedDataGridViewTextBoxColumn"
        Me.SectionExitedDataGridViewTextBoxColumn.ReadOnly = True
        '
        'YearExitedDataGridViewTextBoxColumn
        '
        Me.YearExitedDataGridViewTextBoxColumn.DataPropertyName = "YearExited"
        Me.YearExitedDataGridViewTextBoxColumn.HeaderText = "YearExited"
        Me.YearExitedDataGridViewTextBoxColumn.Name = "YearExitedDataGridViewTextBoxColumn"
        Me.YearExitedDataGridViewTextBoxColumn.ReadOnly = True
        '
        'ClassExitedDataGridViewTextBoxColumn
        '
        Me.ClassExitedDataGridViewTextBoxColumn.DataPropertyName = "ClassExited"
        Me.ClassExitedDataGridViewTextBoxColumn.HeaderText = "ClassExited"
        Me.ClassExitedDataGridViewTextBoxColumn.Name = "ClassExitedDataGridViewTextBoxColumn"
        Me.ClassExitedDataGridViewTextBoxColumn.ReadOnly = True
        '
        'PresentSchDataGridViewTextBoxColumn
        '
        Me.PresentSchDataGridViewTextBoxColumn.DataPropertyName = "PresentSch"
        Me.PresentSchDataGridViewTextBoxColumn.HeaderText = "PresentSch"
        Me.PresentSchDataGridViewTextBoxColumn.Name = "PresentSchDataGridViewTextBoxColumn"
        Me.PresentSchDataGridViewTextBoxColumn.ReadOnly = True
        '
        'AddressDataGridViewTextBoxColumn
        '
        Me.AddressDataGridViewTextBoxColumn.DataPropertyName = "Address"
        Me.AddressDataGridViewTextBoxColumn.HeaderText = "Address"
        Me.AddressDataGridViewTextBoxColumn.Name = "AddressDataGridViewTextBoxColumn"
        Me.AddressDataGridViewTextBoxColumn.ReadOnly = True
        '
        'BirthDateDataGridViewTextBoxColumn
        '
        Me.BirthDateDataGridViewTextBoxColumn.DataPropertyName = "BirthDate"
        Me.BirthDateDataGridViewTextBoxColumn.HeaderText = "BirthDate"
        Me.BirthDateDataGridViewTextBoxColumn.Name = "BirthDateDataGridViewTextBoxColumn"
        Me.BirthDateDataGridViewTextBoxColumn.ReadOnly = True
        '
        'WorkPlaceDataGridViewTextBoxColumn
        '
        Me.WorkPlaceDataGridViewTextBoxColumn.DataPropertyName = "WorkPlace"
        Me.WorkPlaceDataGridViewTextBoxColumn.HeaderText = "WorkPlace"
        Me.WorkPlaceDataGridViewTextBoxColumn.Name = "WorkPlaceDataGridViewTextBoxColumn"
        Me.WorkPlaceDataGridViewTextBoxColumn.ReadOnly = True
        '
        'RankDataGridViewTextBoxColumn
        '
        Me.RankDataGridViewTextBoxColumn.DataPropertyName = "Rank"
        Me.RankDataGridViewTextBoxColumn.HeaderText = "Rank"
        Me.RankDataGridViewTextBoxColumn.Name = "RankDataGridViewTextBoxColumn"
        Me.RankDataGridViewTextBoxColumn.ReadOnly = True
        '
        'PrefectDataGridViewTextBoxColumn
        '
        Me.PrefectDataGridViewTextBoxColumn.DataPropertyName = "Prefect"
        Me.PrefectDataGridViewTextBoxColumn.HeaderText = "Post Held"
        Me.PrefectDataGridViewTextBoxColumn.Name = "PrefectDataGridViewTextBoxColumn"
        Me.PrefectDataGridViewTextBoxColumn.ReadOnly = True
        '
        'MSSDataGridViewTextBoxColumn
        '
        Me.MSSDataGridViewTextBoxColumn.DataPropertyName = "MSS"
        Me.MSSDataGridViewTextBoxColumn.HeaderText = "MSS"
        Me.MSSDataGridViewTextBoxColumn.Name = "MSSDataGridViewTextBoxColumn"
        Me.MSSDataGridViewTextBoxColumn.ReadOnly = True
        '
        'PhoneDataGridViewTextBoxColumn
        '
        Me.PhoneDataGridViewTextBoxColumn.DataPropertyName = "Phone"
        Me.PhoneDataGridViewTextBoxColumn.HeaderText = "Phone"
        Me.PhoneDataGridViewTextBoxColumn.Name = "PhoneDataGridViewTextBoxColumn"
        Me.PhoneDataGridViewTextBoxColumn.ReadOnly = True
        '
        'EmailDataGridViewTextBoxColumn
        '
        Me.EmailDataGridViewTextBoxColumn.DataPropertyName = "Email"
        Me.EmailDataGridViewTextBoxColumn.HeaderText = "Email"
        Me.EmailDataGridViewTextBoxColumn.Name = "EmailDataGridViewTextBoxColumn"
        Me.EmailDataGridViewTextBoxColumn.ReadOnly = True
        '
        'WorkAddressDataGridViewTextBoxColumn
        '
        Me.WorkAddressDataGridViewTextBoxColumn.DataPropertyName = "WorkAddress"
        Me.WorkAddressDataGridViewTextBoxColumn.HeaderText = "WorkAddress"
        Me.WorkAddressDataGridViewTextBoxColumn.Name = "WorkAddressDataGridViewTextBoxColumn"
        Me.WorkAddressDataGridViewTextBoxColumn.ReadOnly = True
        '
        'NationalityDataGridViewTextBoxColumn
        '
        Me.NationalityDataGridViewTextBoxColumn.DataPropertyName = "Nationality"
        Me.NationalityDataGridViewTextBoxColumn.HeaderText = "Nationality"
        Me.NationalityDataGridViewTextBoxColumn.Name = "NationalityDataGridViewTextBoxColumn"
        Me.NationalityDataGridViewTextBoxColumn.ReadOnly = True
        '
        'RegionDataGridViewTextBoxColumn
        '
        Me.RegionDataGridViewTextBoxColumn.DataPropertyName = "Region"
        Me.RegionDataGridViewTextBoxColumn.HeaderText = "Region"
        Me.RegionDataGridViewTextBoxColumn.Name = "RegionDataGridViewTextBoxColumn"
        Me.RegionDataGridViewTextBoxColumn.ReadOnly = True
        '
        'StateDataGridViewTextBoxColumn
        '
        Me.StateDataGridViewTextBoxColumn.DataPropertyName = "State"
        Me.StateDataGridViewTextBoxColumn.HeaderText = "State"
        Me.StateDataGridViewTextBoxColumn.Name = "StateDataGridViewTextBoxColumn"
        Me.StateDataGridViewTextBoxColumn.ReadOnly = True
        '
        'LGADataGridViewTextBoxColumn
        '
        Me.LGADataGridViewTextBoxColumn.DataPropertyName = "LGA"
        Me.LGADataGridViewTextBoxColumn.HeaderText = "LGA"
        Me.LGADataGridViewTextBoxColumn.Name = "LGADataGridViewTextBoxColumn"
        Me.LGADataGridViewTextBoxColumn.ReadOnly = True
        '
        'StatusDataGridViewTextBoxColumn
        '
        Me.StatusDataGridViewTextBoxColumn.DataPropertyName = "Status"
        Me.StatusDataGridViewTextBoxColumn.HeaderText = "Status"
        Me.StatusDataGridViewTextBoxColumn.Name = "StatusDataGridViewTextBoxColumn"
        Me.StatusDataGridViewTextBoxColumn.ReadOnly = True
        '
        'SchRegNoDataGridViewTextBoxColumn
        '
        Me.SchRegNoDataGridViewTextBoxColumn.DataPropertyName = "SchRegNo"
        Me.SchRegNoDataGridViewTextBoxColumn.HeaderText = "SchRegNo"
        Me.SchRegNoDataGridViewTextBoxColumn.Name = "SchRegNoDataGridViewTextBoxColumn"
        Me.SchRegNoDataGridViewTextBoxColumn.ReadOnly = True
        '
        'MemberBindingSource
        '
        Me.MemberBindingSource.DataMember = "Member"
        Me.MemberBindingSource.DataSource = Me.AlumniDataSet
        '
        'AlumniDataSet
        '
        Me.AlumniDataSet.DataSetName = "AlumniDataSet"
        Me.AlumniDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'lblFullname
        '
        Me.lblFullname.AutoSize = True
        Me.lblFullname.BackColor = System.Drawing.Color.Transparent
        Me.lblFullname.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFullname.ForeColor = System.Drawing.Color.Black
        Me.lblFullname.Location = New System.Drawing.Point(18, 72)
        Me.lblFullname.Name = "lblFullname"
        Me.lblFullname.Size = New System.Drawing.Size(111, 19)
        Me.lblFullname.TabIndex = 73
        Me.lblFullname.Text = "Search by name"
        '
        'MemberTableAdapter
        '
        Me.MemberTableAdapter.ClearBeforeFill = True
        '
        'ManageMembersForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(82, Byte), Integer), CType(CType(135, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(918, 570)
        Me.ControlBox = False
        Me.Controls.Add(Me.btnRefresh)
        Me.Controls.Add(Me.lblRegNo)
        Me.Controls.Add(Me.btnView)
        Me.Controls.Add(Me.txtRegNo)
        Me.Controls.Add(Me.btnEdit)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.txtSearchName)
        Me.Controls.Add(Me.DataGridViewMembers)
        Me.Controls.Add(Me.lblFullname)
        Me.Controls.Add(Me.btnHome)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.Title)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Location = New System.Drawing.Point(238, 90)
        Me.Name = "ManageMembersForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.DataGridViewMembers, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MemberBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AlumniDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnHome As System.Windows.Forms.Button
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents Title As System.Windows.Forms.Label
    Friend WithEvents btnRefresh As System.Windows.Forms.Button
    Friend WithEvents lblRegNo As System.Windows.Forms.Label
    Friend WithEvents btnView As System.Windows.Forms.Button
    Friend WithEvents txtRegNo As System.Windows.Forms.TextBox
    Friend WithEvents btnEdit As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents lblRank As System.Windows.Forms.Label
    Friend WithEvents cboRank As System.Windows.Forms.ComboBox
    Friend WithEvents btnFilter As System.Windows.Forms.Button
    Friend WithEvents lblRegion As System.Windows.Forms.Label
    Friend WithEvents lblState As System.Windows.Forms.Label
    Friend WithEvents lblLocalGovt As System.Windows.Forms.Label
    Friend WithEvents lblNationality As System.Windows.Forms.Label
    Friend WithEvents cboRegion As System.Windows.Forms.ComboBox
    Friend WithEvents cboState As System.Windows.Forms.ComboBox
    Friend WithEvents cboLocalGovt As System.Windows.Forms.ComboBox
    Friend WithEvents cboNationality As System.Windows.Forms.ComboBox
    Friend WithEvents lblPrefect As System.Windows.Forms.Label
    Friend WithEvents lblSection As System.Windows.Forms.Label
    Friend WithEvents lblGender As System.Windows.Forms.Label
    Friend WithEvents lblStatus As System.Windows.Forms.Label
    Friend WithEvents cboSectionAdm As System.Windows.Forms.ComboBox
    Friend WithEvents cboSectionExit As System.Windows.Forms.ComboBox
    Friend WithEvents cboGender As System.Windows.Forms.ComboBox
    Friend WithEvents cboStatus As System.Windows.Forms.ComboBox
    Friend WithEvents btnAdd As System.Windows.Forms.Button
    Friend WithEvents txtSearchName As System.Windows.Forms.TextBox
    Friend WithEvents DataGridViewMembers As System.Windows.Forms.DataGridView
    Friend WithEvents lblFullname As System.Windows.Forms.Label
    Friend WithEvents MemberBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents AlumniDataSet As Global.Alumni_Management_System.AlumniDataSet
    Friend WithEvents MemberTableAdapter As Global.Alumni_Management_System.AlumniDataSetTableAdapters.MemberTableAdapter
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cboYExit As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents cboYAdmit As System.Windows.Forms.ComboBox
    Friend WithEvents RegNoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FullnameDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents GenderDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SectionAdmittedDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents YearAdmittedDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ClassAdmittedDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SectionExitedDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents YearExitedDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ClassExitedDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PresentSchDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents AddressDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents BirthDateDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents WorkPlaceDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents RankDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PrefectDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents MSSDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PhoneDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents EmailDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents WorkAddressDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NationalityDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents RegionDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents StateDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents LGADataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents StatusDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SchRegNoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
