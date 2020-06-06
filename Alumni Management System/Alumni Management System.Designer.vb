<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Alumni_Management_System
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Alumni_Management_System))
        Me.MenuStrip = New System.Windows.Forms.MenuStrip()
        Me.FILEToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.VIEWToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MemberHistoryToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.StaffHistoryToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ActivityHistoryToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.HELPToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FileMenu = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EditMenu = New System.Windows.Forms.ToolStripMenuItem()
        Me.MemberHistoryToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.StaffHistoryToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ActivityHistoryToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HelpMenu = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStrip = New System.Windows.Forms.ToolStrip()
        Me.ToolStripButton2 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripStatusLabel = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolTip = New System.Windows.Forms.ToolTip(Me.components)
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.lblQuote = New System.Windows.Forms.Label()
        Me.btnActivity = New System.Windows.Forms.Button()
        Me.btnActivities = New System.Windows.Forms.Button()
        Me.btnMembs = New System.Windows.Forms.Button()
        Me.btnStaffs = New System.Windows.Forms.Button()
        Me.btnStaff = New System.Windows.Forms.Button()
        Me.btnAddmem = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Rb7 = New System.Windows.Forms.RadioButton()
        Me.Rb6 = New System.Windows.Forms.RadioButton()
        Me.Rb2 = New System.Windows.Forms.RadioButton()
        Me.Rb1 = New System.Windows.Forms.RadioButton()
        Me.Rb3 = New System.Windows.Forms.RadioButton()
        Me.Rb5 = New System.Windows.Forms.RadioButton()
        Me.Rb4 = New System.Windows.Forms.RadioButton()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.ToolStripMenuItem5 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripTextBox()
        Me.ToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem4 = New System.Windows.Forms.ToolStripMenuItem()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.ToolStripButton1 = New System.Windows.Forms.ToolStripButton()
        Me.MenuStrip.SuspendLayout()
        Me.ToolStrip.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MenuStrip
        '
        Me.MenuStrip.BackColor = System.Drawing.Color.White
        Me.MenuStrip.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MenuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FILEToolStripMenuItem, Me.VIEWToolStripMenuItem, Me.HELPToolStripMenuItem})
        Me.MenuStrip.Location = New System.Drawing.Point(0, 41)
        Me.MenuStrip.Name = "MenuStrip"
        Me.MenuStrip.Size = New System.Drawing.Size(1160, 29)
        Me.MenuStrip.TabIndex = 5
        Me.MenuStrip.Text = "MenuStrip"
        '
        'FILEToolStripMenuItem
        '
        Me.FILEToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ExitToolStripMenuItem1})
        Me.FILEToolStripMenuItem.Name = "FILEToolStripMenuItem"
        Me.FILEToolStripMenuItem.Size = New System.Drawing.Size(51, 25)
        Me.FILEToolStripMenuItem.Text = "&FILE"
        '
        'ExitToolStripMenuItem1
        '
        Me.ExitToolStripMenuItem1.Image = Global.Alumni_Management_System.My.Resources.Resources.Switch
        Me.ExitToolStripMenuItem1.Name = "ExitToolStripMenuItem1"
        Me.ExitToolStripMenuItem1.Size = New System.Drawing.Size(106, 26)
        Me.ExitToolStripMenuItem1.Text = "Exit"
        '
        'VIEWToolStripMenuItem
        '
        Me.VIEWToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MemberHistoryToolStripMenuItem1, Me.StaffHistoryToolStripMenuItem1, Me.ActivityHistoryToolStripMenuItem1})
        Me.VIEWToolStripMenuItem.Name = "VIEWToolStripMenuItem"
        Me.VIEWToolStripMenuItem.Size = New System.Drawing.Size(60, 25)
        Me.VIEWToolStripMenuItem.Text = "&VIEW"
        '
        'MemberHistoryToolStripMenuItem1
        '
        Me.MemberHistoryToolStripMenuItem1.Name = "MemberHistoryToolStripMenuItem1"
        Me.MemberHistoryToolStripMenuItem1.Size = New System.Drawing.Size(208, 26)
        Me.MemberHistoryToolStripMenuItem1.Text = "&Members History"
        '
        'StaffHistoryToolStripMenuItem1
        '
        Me.StaffHistoryToolStripMenuItem1.Name = "StaffHistoryToolStripMenuItem1"
        Me.StaffHistoryToolStripMenuItem1.Size = New System.Drawing.Size(208, 26)
        Me.StaffHistoryToolStripMenuItem1.Text = "&Teachers History"
        '
        'ActivityHistoryToolStripMenuItem1
        '
        Me.ActivityHistoryToolStripMenuItem1.Name = "ActivityHistoryToolStripMenuItem1"
        Me.ActivityHistoryToolStripMenuItem1.Size = New System.Drawing.Size(208, 26)
        Me.ActivityHistoryToolStripMenuItem1.Text = "&Activity History"
        '
        'HELPToolStripMenuItem
        '
        Me.HELPToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AToolStripMenuItem})
        Me.HELPToolStripMenuItem.Name = "HELPToolStripMenuItem"
        Me.HELPToolStripMenuItem.Size = New System.Drawing.Size(59, 25)
        Me.HELPToolStripMenuItem.Text = "&HELP"
        '
        'AToolStripMenuItem
        '
        Me.AToolStripMenuItem.Image = Global.Alumni_Management_System.My.Resources.Resources.About
        Me.AToolStripMenuItem.Name = "AToolStripMenuItem"
        Me.AToolStripMenuItem.Size = New System.Drawing.Size(339, 26)
        Me.AToolStripMenuItem.Text = "About Alumni Management System"
        '
        'FileMenu
        '
        Me.FileMenu.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ExitToolStripMenuItem})
        Me.FileMenu.ImageTransparentColor = System.Drawing.SystemColors.ActiveBorder
        Me.FileMenu.Name = "FileMenu"
        Me.FileMenu.Size = New System.Drawing.Size(40, 20)
        Me.FileMenu.Text = "&FILE"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Image = Global.Alumni_Management_System.My.Resources.Resources.Switch
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(92, 22)
        Me.ExitToolStripMenuItem.Text = "&Exit"
        '
        'EditMenu
        '
        Me.EditMenu.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MemberHistoryToolStripMenuItem, Me.StaffHistoryToolStripMenuItem, Me.ActivityHistoryToolStripMenuItem})
        Me.EditMenu.Name = "EditMenu"
        Me.EditMenu.Size = New System.Drawing.Size(46, 20)
        Me.EditMenu.Text = "&VIEW"
        '
        'MemberHistoryToolStripMenuItem
        '
        Me.MemberHistoryToolStripMenuItem.Name = "MemberHistoryToolStripMenuItem"
        Me.MemberHistoryToolStripMenuItem.Size = New System.Drawing.Size(160, 22)
        Me.MemberHistoryToolStripMenuItem.Text = "&Member History"
        '
        'StaffHistoryToolStripMenuItem
        '
        Me.StaffHistoryToolStripMenuItem.Name = "StaffHistoryToolStripMenuItem"
        Me.StaffHistoryToolStripMenuItem.Size = New System.Drawing.Size(160, 22)
        Me.StaffHistoryToolStripMenuItem.Text = "&Staff History"
        '
        'ActivityHistoryToolStripMenuItem
        '
        Me.ActivityHistoryToolStripMenuItem.Name = "ActivityHistoryToolStripMenuItem"
        Me.ActivityHistoryToolStripMenuItem.Size = New System.Drawing.Size(160, 22)
        Me.ActivityHistoryToolStripMenuItem.Text = "&Activity History"
        '
        'HelpMenu
        '
        Me.HelpMenu.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AboutToolStripMenuItem})
        Me.HelpMenu.Name = "HelpMenu"
        Me.HelpMenu.Size = New System.Drawing.Size(47, 20)
        Me.HelpMenu.Text = "&HELP"
        '
        'AboutToolStripMenuItem
        '
        Me.AboutToolStripMenuItem.Image = Global.Alumni_Management_System.My.Resources.Resources.About
        Me.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        Me.AboutToolStripMenuItem.Size = New System.Drawing.Size(264, 22)
        Me.AboutToolStripMenuItem.Text = "About Alumn&i Management System"
        '
        'ToolStrip
        '
        Me.ToolStrip.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(82, Byte), Integer), CType(CType(135, Byte), Integer))
        Me.ToolStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripButton2})
        Me.ToolStrip.Location = New System.Drawing.Point(0, 70)
        Me.ToolStrip.Name = "ToolStrip"
        Me.ToolStrip.Size = New System.Drawing.Size(1160, 32)
        Me.ToolStrip.TabIndex = 6
        Me.ToolStrip.Text = "ToolStrip"
        '
        'ToolStripButton2
        '
        Me.ToolStripButton2.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStripButton2.ForeColor = System.Drawing.Color.White
        Me.ToolStripButton2.Image = Global.Alumni_Management_System.My.Resources.Resources.User
        Me.ToolStripButton2.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.ToolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton2.Name = "ToolStripButton2"
        Me.ToolStripButton2.Size = New System.Drawing.Size(77, 29)
        Me.ToolStripButton2.Text = "User"
        '
        'ToolStripStatusLabel
        '
        Me.ToolStripStatusLabel.Name = "ToolStripStatusLabel"
        Me.ToolStripStatusLabel.Size = New System.Drawing.Size(39, 17)
        Me.ToolStripStatusLabel.Text = "Status"
        '
        'Timer1
        '
        Me.Timer1.Interval = 5000
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.Controls.Add(Me.StatusStrip1)
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 102)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1160, 598)
        Me.Panel1.TabIndex = 9
        '
        'StatusStrip1
        '
        Me.StatusStrip1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(82, Byte), Integer), CType(CType(135, Byte), Integer))
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 576)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(1160, 22)
        Me.StatusStrip1.TabIndex = 2
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.Panel3)
        Me.Panel2.Controls.Add(Me.btnActivity)
        Me.Panel2.Controls.Add(Me.btnActivities)
        Me.Panel2.Controls.Add(Me.btnMembs)
        Me.Panel2.Controls.Add(Me.btnStaffs)
        Me.Panel2.Controls.Add(Me.btnStaff)
        Me.Panel2.Controls.Add(Me.btnAddmem)
        Me.Panel2.Controls.Add(Me.PictureBox1)
        Me.Panel2.Controls.Add(Me.GroupBox1)
        Me.Panel2.Location = New System.Drawing.Point(246, 65)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(874, 496)
        Me.Panel2.TabIndex = 1
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(82, Byte), Integer), CType(CType(135, Byte), Integer))
        Me.Panel3.Controls.Add(Me.lblQuote)
        Me.Panel3.Location = New System.Drawing.Point(3, 444)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(867, 49)
        Me.Panel3.TabIndex = 7
        '
        'lblQuote
        '
        Me.lblQuote.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblQuote.Font = New System.Drawing.Font("Berlin Sans FB", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblQuote.ForeColor = System.Drawing.Color.White
        Me.lblQuote.Location = New System.Drawing.Point(0, 0)
        Me.lblQuote.Name = "lblQuote"
        Me.lblQuote.Padding = New System.Windows.Forms.Padding(7)
        Me.lblQuote.Size = New System.Drawing.Size(867, 49)
        Me.lblQuote.TabIndex = 0
        Me.lblQuote.Text = "Label1"
        '
        'btnActivity
        '
        Me.btnActivity.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnActivity.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnActivity.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnActivity.ForeColor = System.Drawing.Color.White
        Me.btnActivity.Image = Global.Alumni_Management_System.My.Resources.Resources.Activity
        Me.btnActivity.Location = New System.Drawing.Point(3, 297)
        Me.btnActivity.Name = "btnActivity"
        Me.btnActivity.Size = New System.Drawing.Size(245, 141)
        Me.btnActivity.TabIndex = 5
        Me.btnActivity.Text = "Add Activity"
        Me.btnActivity.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.ToolTip.SetToolTip(Me.btnActivity, "Add new activity")
        Me.btnActivity.UseVisualStyleBackColor = False
        '
        'btnActivities
        '
        Me.btnActivities.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnActivities.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnActivities.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnActivities.ForeColor = System.Drawing.Color.White
        Me.btnActivities.Image = Global.Alumni_Management_System.My.Resources.Resources.Activities
        Me.btnActivities.Location = New System.Drawing.Point(254, 297)
        Me.btnActivities.Name = "btnActivities"
        Me.btnActivities.Size = New System.Drawing.Size(245, 141)
        Me.btnActivities.TabIndex = 4
        Me.btnActivities.Text = "Manage Activities"
        Me.btnActivities.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.ToolTip.SetToolTip(Me.btnActivities, "View and edit activities")
        Me.btnActivities.UseVisualStyleBackColor = False
        '
        'btnMembs
        '
        Me.btnMembs.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnMembs.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnMembs.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMembs.ForeColor = System.Drawing.Color.White
        Me.btnMembs.Image = CType(resources.GetObject("btnMembs.Image"), System.Drawing.Image)
        Me.btnMembs.Location = New System.Drawing.Point(254, 3)
        Me.btnMembs.Name = "btnMembs"
        Me.btnMembs.Size = New System.Drawing.Size(245, 141)
        Me.btnMembs.TabIndex = 3
        Me.btnMembs.Text = "Manage Members"
        Me.btnMembs.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.ToolTip.SetToolTip(Me.btnMembs, "View and edit members")
        Me.btnMembs.UseVisualStyleBackColor = False
        '
        'btnStaffs
        '
        Me.btnStaffs.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnStaffs.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnStaffs.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnStaffs.ForeColor = System.Drawing.Color.White
        Me.btnStaffs.Image = Global.Alumni_Management_System.My.Resources.Resources.Staffs
        Me.btnStaffs.Location = New System.Drawing.Point(254, 150)
        Me.btnStaffs.Name = "btnStaffs"
        Me.btnStaffs.Size = New System.Drawing.Size(245, 141)
        Me.btnStaffs.TabIndex = 2
        Me.btnStaffs.Text = "Manage Teachers"
        Me.btnStaffs.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.ToolTip.SetToolTip(Me.btnStaffs, "View and edit teacher")
        Me.btnStaffs.UseVisualStyleBackColor = False
        '
        'btnStaff
        '
        Me.btnStaff.BackColor = System.Drawing.Color.Gray
        Me.btnStaff.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnStaff.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnStaff.ForeColor = System.Drawing.Color.White
        Me.btnStaff.Image = Global.Alumni_Management_System.My.Resources.Resources.Staff
        Me.btnStaff.Location = New System.Drawing.Point(3, 150)
        Me.btnStaff.Name = "btnStaff"
        Me.btnStaff.Size = New System.Drawing.Size(245, 141)
        Me.btnStaff.TabIndex = 1
        Me.btnStaff.Text = "Add Teacher"
        Me.btnStaff.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.ToolTip.SetToolTip(Me.btnStaff, "Add new teacher")
        Me.btnStaff.UseVisualStyleBackColor = False
        '
        'btnAddmem
        '
        Me.btnAddmem.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnAddmem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnAddmem.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAddmem.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAddmem.ForeColor = System.Drawing.Color.White
        Me.btnAddmem.Image = CType(resources.GetObject("btnAddmem.Image"), System.Drawing.Image)
        Me.btnAddmem.Location = New System.Drawing.Point(3, 3)
        Me.btnAddmem.Name = "btnAddmem"
        Me.btnAddmem.Size = New System.Drawing.Size(245, 141)
        Me.btnAddmem.TabIndex = 0
        Me.btnAddmem.Text = "Add Member"
        Me.btnAddmem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.ToolTip.SetToolTip(Me.btnAddmem, "Add new Member")
        Me.btnAddmem.UseVisualStyleBackColor = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Silver
        Me.PictureBox1.Image = Global.Alumni_Management_System.My.Resources.Resources.YAMS_2
        Me.PictureBox1.Location = New System.Drawing.Point(505, 3)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(364, 396)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 6
        Me.PictureBox1.TabStop = False
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(82, Byte), Integer), CType(CType(135, Byte), Integer))
        Me.GroupBox1.Controls.Add(Me.Rb7)
        Me.GroupBox1.Controls.Add(Me.Rb6)
        Me.GroupBox1.Controls.Add(Me.Rb2)
        Me.GroupBox1.Controls.Add(Me.Rb1)
        Me.GroupBox1.Controls.Add(Me.Rb3)
        Me.GroupBox1.Controls.Add(Me.Rb5)
        Me.GroupBox1.Controls.Add(Me.Rb4)
        Me.GroupBox1.Location = New System.Drawing.Point(505, 393)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(364, 45)
        Me.GroupBox1.TabIndex = 14
        Me.GroupBox1.TabStop = False
        '
        'Rb7
        '
        Me.Rb7.Appearance = System.Windows.Forms.Appearance.Button
        Me.Rb7.BackColor = System.Drawing.Color.FromArgb(CType(CType(233, Byte), Integer), CType(CType(126, Byte), Integer), CType(CType(167, Byte), Integer))
        Me.Rb7.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(220, Byte), Integer), CType(CType(56, Byte), Integer), CType(CType(118, Byte), Integer))
        Me.Rb7.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(190, Byte), Integer), CType(CType(210, Byte), Integer))
        Me.Rb7.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Rb7.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Rb7.Location = New System.Drawing.Point(294, 12)
        Me.Rb7.Name = "Rb7"
        Me.Rb7.Size = New System.Drawing.Size(42, 27)
        Me.Rb7.TabIndex = 14
        Me.Rb7.TabStop = True
        Me.Rb7.UseVisualStyleBackColor = False
        '
        'Rb6
        '
        Me.Rb6.Appearance = System.Windows.Forms.Appearance.Button
        Me.Rb6.BackColor = System.Drawing.Color.FromArgb(CType(CType(233, Byte), Integer), CType(CType(126, Byte), Integer), CType(CType(167, Byte), Integer))
        Me.Rb6.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(220, Byte), Integer), CType(CType(56, Byte), Integer), CType(CType(118, Byte), Integer))
        Me.Rb6.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(190, Byte), Integer), CType(CType(210, Byte), Integer))
        Me.Rb6.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Rb6.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Rb6.Location = New System.Drawing.Point(246, 12)
        Me.Rb6.Name = "Rb6"
        Me.Rb6.Size = New System.Drawing.Size(42, 27)
        Me.Rb6.TabIndex = 9
        Me.Rb6.TabStop = True
        Me.Rb6.UseVisualStyleBackColor = False
        '
        'Rb2
        '
        Me.Rb2.Appearance = System.Windows.Forms.Appearance.Button
        Me.Rb2.BackColor = System.Drawing.Color.FromArgb(CType(CType(233, Byte), Integer), CType(CType(126, Byte), Integer), CType(CType(167, Byte), Integer))
        Me.Rb2.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(220, Byte), Integer), CType(CType(56, Byte), Integer), CType(CType(118, Byte), Integer))
        Me.Rb2.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(190, Byte), Integer), CType(CType(210, Byte), Integer))
        Me.Rb2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Rb2.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Rb2.Location = New System.Drawing.Point(54, 12)
        Me.Rb2.Name = "Rb2"
        Me.Rb2.Size = New System.Drawing.Size(42, 27)
        Me.Rb2.TabIndex = 13
        Me.Rb2.TabStop = True
        Me.Rb2.UseVisualStyleBackColor = False
        '
        'Rb1
        '
        Me.Rb1.Appearance = System.Windows.Forms.Appearance.Button
        Me.Rb1.BackColor = System.Drawing.Color.FromArgb(CType(CType(233, Byte), Integer), CType(CType(126, Byte), Integer), CType(CType(167, Byte), Integer))
        Me.Rb1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(220, Byte), Integer), CType(CType(56, Byte), Integer), CType(CType(118, Byte), Integer))
        Me.Rb1.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(190, Byte), Integer), CType(CType(210, Byte), Integer))
        Me.Rb1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Rb1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Rb1.Location = New System.Drawing.Point(6, 12)
        Me.Rb1.Name = "Rb1"
        Me.Rb1.Size = New System.Drawing.Size(42, 27)
        Me.Rb1.TabIndex = 8
        Me.Rb1.TabStop = True
        Me.Rb1.UseVisualStyleBackColor = False
        '
        'Rb3
        '
        Me.Rb3.Appearance = System.Windows.Forms.Appearance.Button
        Me.Rb3.BackColor = System.Drawing.Color.FromArgb(CType(CType(233, Byte), Integer), CType(CType(126, Byte), Integer), CType(CType(167, Byte), Integer))
        Me.Rb3.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(220, Byte), Integer), CType(CType(56, Byte), Integer), CType(CType(118, Byte), Integer))
        Me.Rb3.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(190, Byte), Integer), CType(CType(210, Byte), Integer))
        Me.Rb3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Rb3.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Rb3.Location = New System.Drawing.Point(102, 12)
        Me.Rb3.Name = "Rb3"
        Me.Rb3.Size = New System.Drawing.Size(42, 27)
        Me.Rb3.TabIndex = 12
        Me.Rb3.TabStop = True
        Me.Rb3.UseVisualStyleBackColor = False
        '
        'Rb5
        '
        Me.Rb5.Appearance = System.Windows.Forms.Appearance.Button
        Me.Rb5.BackColor = System.Drawing.Color.FromArgb(CType(CType(233, Byte), Integer), CType(CType(126, Byte), Integer), CType(CType(167, Byte), Integer))
        Me.Rb5.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(220, Byte), Integer), CType(CType(56, Byte), Integer), CType(CType(118, Byte), Integer))
        Me.Rb5.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(190, Byte), Integer), CType(CType(210, Byte), Integer))
        Me.Rb5.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Rb5.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Rb5.Location = New System.Drawing.Point(198, 12)
        Me.Rb5.Name = "Rb5"
        Me.Rb5.Size = New System.Drawing.Size(42, 27)
        Me.Rb5.TabIndex = 10
        Me.Rb5.TabStop = True
        Me.Rb5.UseVisualStyleBackColor = False
        '
        'Rb4
        '
        Me.Rb4.Appearance = System.Windows.Forms.Appearance.Button
        Me.Rb4.BackColor = System.Drawing.Color.FromArgb(CType(CType(233, Byte), Integer), CType(CType(126, Byte), Integer), CType(CType(167, Byte), Integer))
        Me.Rb4.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(220, Byte), Integer), CType(CType(56, Byte), Integer), CType(CType(118, Byte), Integer))
        Me.Rb4.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(190, Byte), Integer), CType(CType(210, Byte), Integer))
        Me.Rb4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Rb4.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Rb4.Location = New System.Drawing.Point(150, 12)
        Me.Rb4.Name = "Rb4"
        Me.Rb4.Size = New System.Drawing.Size(42, 27)
        Me.Rb4.TabIndex = 11
        Me.Rb4.TabStop = True
        Me.Rb4.UseVisualStyleBackColor = False
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.Color.White
        Me.MenuStrip1.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem5, Me.ToolStripMenuItem1, Me.ToolStripMenuItem2, Me.ToolStripMenuItem4})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1160, 41)
        Me.MenuStrip1.TabIndex = 11
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'ToolStripMenuItem5
        '
        Me.ToolStripMenuItem5.AccessibleRole = System.Windows.Forms.AccessibleRole.None
        Me.ToolStripMenuItem5.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripMenuItem5.Font = New System.Drawing.Font("Berlin Sans FB", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStripMenuItem5.Image = Global.Alumni_Management_System.My.Resources.Resources.AMS
        Me.ToolStripMenuItem5.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.ToolStripMenuItem5.Name = "ToolStripMenuItem5"
        Me.ToolStripMenuItem5.Size = New System.Drawing.Size(42, 37)
        Me.ToolStripMenuItem5.Text = "Al-Ameen Model School Old Students Association - Alumni Management System AMSOSA " & _
    "- AMS"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.AccessibleRole = System.Windows.Forms.AccessibleRole.None
        Me.ToolStripMenuItem1.BackColor = System.Drawing.Color.White
        Me.ToolStripMenuItem1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.ToolStripMenuItem1.CausesValidation = False
        Me.ToolStripMenuItem1.Enabled = False
        Me.ToolStripMenuItem1.Font = New System.Drawing.Font("Berlin Sans FB", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(852, 37)
        Me.ToolStripMenuItem1.Text = "Al-Ameen Model School Old Students Association - Alumni Management System AMSOSA " & _
    "- AMS"
        '
        'ToolStripMenuItem2
        '
        Me.ToolStripMenuItem2.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.ToolStripMenuItem2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripMenuItem2.Image = Global.Alumni_Management_System.My.Resources.Resources.Close
        Me.ToolStripMenuItem2.Name = "ToolStripMenuItem2"
        Me.ToolStripMenuItem2.Size = New System.Drawing.Size(28, 37)
        Me.ToolStripMenuItem2.Text = "ToolStripMenuItem2"
        '
        'ToolStripMenuItem4
        '
        Me.ToolStripMenuItem4.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.ToolStripMenuItem4.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripMenuItem4.Image = Global.Alumni_Management_System.My.Resources.Resources.Minimize
        Me.ToolStripMenuItem4.Name = "ToolStripMenuItem4"
        Me.ToolStripMenuItem4.Size = New System.Drawing.Size(28, 37)
        Me.ToolStripMenuItem4.Text = "ToolStripMenuItem4"
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.White
        Me.PictureBox2.Image = Global.Alumni_Management_System.My.Resources.Resources.AMS
        Me.PictureBox2.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(50, 41)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.PictureBox2.TabIndex = 13
        Me.PictureBox2.TabStop = False
        '
        'ToolStripButton1
        '
        Me.ToolStripButton1.Font = New System.Drawing.Font("Segoe UI", 12.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStripButton1.ForeColor = System.Drawing.Color.White
        Me.ToolStripButton1.Image = Global.Alumni_Management_System.My.Resources.Resources.User
        Me.ToolStripButton1.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.ToolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton1.Name = "ToolStripButton1"
        Me.ToolStripButton1.Size = New System.Drawing.Size(82, 29)
        Me.ToolStripButton1.Text = "Users"
        '
        'Alumni_Management_System
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1160, 700)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.ToolStrip)
        Me.Controls.Add(Me.MenuStrip)
        Me.Controls.Add(Me.MenuStrip1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip
        Me.Name = "Alumni_Management_System"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Alumni Management System"
        Me.MenuStrip.ResumeLayout(False)
        Me.MenuStrip.PerformLayout()
        Me.ToolStrip.ResumeLayout(False)
        Me.ToolStrip.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents HelpMenu As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolTip As System.Windows.Forms.ToolTip
    Friend WithEvents ToolStripStatusLabel As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents ToolStrip As System.Windows.Forms.ToolStrip
    Friend WithEvents ExitToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents FileMenu As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MenuStrip As System.Windows.Forms.MenuStrip
    Friend WithEvents EditMenu As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AboutToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripButton1 As System.Windows.Forms.ToolStripButton
    Friend WithEvents MemberHistoryToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents StaffHistoryToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ActivityHistoryToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents FILEToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents VIEWToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MemberHistoryToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents StaffHistoryToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ActivityHistoryToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents HELPToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripButton2 As System.Windows.Forms.ToolStripButton
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents btnActivity As System.Windows.Forms.Button
    Friend WithEvents btnActivities As System.Windows.Forms.Button
    Friend WithEvents btnMembs As System.Windows.Forms.Button
    Friend WithEvents btnStaffs As System.Windows.Forms.Button
    Friend WithEvents btnStaff As System.Windows.Forms.Button
    Friend WithEvents btnAddmem As System.Windows.Forms.Button
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Rb7 As System.Windows.Forms.RadioButton
    Friend WithEvents Rb6 As System.Windows.Forms.RadioButton
    Friend WithEvents Rb2 As System.Windows.Forms.RadioButton
    Friend WithEvents Rb1 As System.Windows.Forms.RadioButton
    Friend WithEvents Rb3 As System.Windows.Forms.RadioButton
    Friend WithEvents Rb5 As System.Windows.Forms.RadioButton
    Friend WithEvents Rb4 As System.Windows.Forms.RadioButton
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents ToolStripMenuItem2 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem4 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents ToolStripMenuItem5 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem1 As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents lblQuote As System.Windows.Forms.Label

End Class
