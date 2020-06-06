<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ManageUserForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ManageUserForm))
        Me.Title = New System.Windows.Forms.Label()
        Me.lstExistingUsers = New System.Windows.Forms.ListBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cboRank = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnLoad = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.PicUser = New System.Windows.Forms.PictureBox()
        Me.txtRPassword = New System.Windows.Forms.TextBox()
        Me.txtPassword = New System.Windows.Forms.TextBox()
        Me.lblRPassword = New System.Windows.Forms.Label()
        Me.lblPassword = New System.Windows.Forms.Label()
        Me.txtUsername = New System.Windows.Forms.TextBox()
        Me.txtFullname = New System.Windows.Forms.TextBox()
        Me.lblUsername = New System.Windows.Forms.Label()
        Me.lblFullname = New System.Windows.Forms.Label()
        Me.lblExistingUsers = New System.Windows.Forms.Label()
        Me.btnRemove = New System.Windows.Forms.Button()
        Me.btnHome = New System.Windows.Forms.Button()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar()
        Me.lblPleasewait = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.GroupBox1.SuspendLayout()
        CType(Me.PicUser, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Title
        '
        Me.Title.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(117, Byte), Integer), CType(CType(182, Byte), Integer))
        Me.Title.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Title.Font = New System.Drawing.Font("Rockwell", 18.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Title.ForeColor = System.Drawing.Color.FromArgb(CType(CType(220, Byte), Integer), CType(CType(56, Byte), Integer), CType(CType(118, Byte), Integer))
        Me.Title.Location = New System.Drawing.Point(206, 2)
        Me.Title.Name = "Title"
        Me.Title.Size = New System.Drawing.Size(507, 48)
        Me.Title.TabIndex = 26
        Me.Title.Text = "MANAGE USER"
        Me.Title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lstExistingUsers
        '
        Me.lstExistingUsers.Font = New System.Drawing.Font("Berlin Sans FB", 12.75!)
        Me.lstExistingUsers.FormattingEnabled = True
        Me.lstExistingUsers.ItemHeight = 19
        Me.lstExistingUsers.Location = New System.Drawing.Point(12, 86)
        Me.lstExistingUsers.Name = "lstExistingUsers"
        Me.lstExistingUsers.Size = New System.Drawing.Size(292, 308)
        Me.lstExistingUsers.TabIndex = 28
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.cboRank)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.btnLoad)
        Me.GroupBox1.Controls.Add(Me.btnSave)
        Me.GroupBox1.Controls.Add(Me.PicUser)
        Me.GroupBox1.Controls.Add(Me.txtRPassword)
        Me.GroupBox1.Controls.Add(Me.txtPassword)
        Me.GroupBox1.Controls.Add(Me.lblRPassword)
        Me.GroupBox1.Controls.Add(Me.lblPassword)
        Me.GroupBox1.Controls.Add(Me.txtUsername)
        Me.GroupBox1.Controls.Add(Me.txtFullname)
        Me.GroupBox1.Controls.Add(Me.lblUsername)
        Me.GroupBox1.Controls.Add(Me.lblFullname)
        Me.GroupBox1.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(319, 53)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(535, 392)
        Me.GroupBox1.TabIndex = 30
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Add new User"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Calibri", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(6, 208)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(106, 21)
        Me.Label2.TabIndex = 77
        Me.Label2.Text = "User's Picture"
        '
        'cboRank
        '
        Me.cboRank.Font = New System.Drawing.Font("Berlin Sans FB", 12.75!)
        Me.cboRank.FormattingEnabled = True
        Me.cboRank.Location = New System.Drawing.Point(141, 166)
        Me.cboRank.Name = "cboRank"
        Me.cboRank.Size = New System.Drawing.Size(200, 27)
        Me.cboRank.TabIndex = 76
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Calibri", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(6, 168)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(44, 21)
        Me.Label1.TabIndex = 75
        Me.Label1.Text = "Rank"
        '
        'btnLoad
        '
        Me.btnLoad.BackColor = System.Drawing.Color.Silver
        Me.btnLoad.FlatAppearance.BorderColor = System.Drawing.Color.Gray
        Me.btnLoad.FlatAppearance.BorderSize = 2
        Me.btnLoad.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLoad.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLoad.Location = New System.Drawing.Point(306, 291)
        Me.btnLoad.Name = "btnLoad"
        Me.btnLoad.Size = New System.Drawing.Size(96, 37)
        Me.btnLoad.TabIndex = 74
        Me.btnLoad.Text = "Load"
        Me.btnLoad.UseVisualStyleBackColor = False
        '
        'btnSave
        '
        Me.btnSave.BackColor = System.Drawing.Color.Silver
        Me.btnSave.FlatAppearance.BorderColor = System.Drawing.Color.Gray
        Me.btnSave.FlatAppearance.BorderSize = 2
        Me.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSave.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSave.Location = New System.Drawing.Point(306, 334)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(182, 52)
        Me.btnSave.TabIndex = 72
        Me.btnSave.Text = "Save New User Details"
        Me.btnSave.UseVisualStyleBackColor = False
        '
        'PicUser
        '
        Me.PicUser.BackgroundImage = Global.Alumni_Management_System.My.Resources.Resources.User2
        Me.PicUser.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.PicUser.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PicUser.Location = New System.Drawing.Point(141, 202)
        Me.PicUser.Name = "PicUser"
        Me.PicUser.Size = New System.Drawing.Size(159, 184)
        Me.PicUser.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PicUser.TabIndex = 69
        Me.PicUser.TabStop = False
        '
        'txtRPassword
        '
        Me.txtRPassword.Font = New System.Drawing.Font("Berlin Sans FB", 12.75!)
        Me.txtRPassword.Location = New System.Drawing.Point(141, 132)
        Me.txtRPassword.Name = "txtRPassword"
        Me.txtRPassword.Size = New System.Drawing.Size(388, 26)
        Me.txtRPassword.TabIndex = 68
        Me.txtRPassword.UseSystemPasswordChar = True
        '
        'txtPassword
        '
        Me.txtPassword.Font = New System.Drawing.Font("Berlin Sans FB", 12.75!)
        Me.txtPassword.ForeColor = System.Drawing.Color.Yellow
        Me.txtPassword.Location = New System.Drawing.Point(141, 99)
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.Size = New System.Drawing.Size(388, 26)
        Me.txtPassword.TabIndex = 67
        Me.txtPassword.UseSystemPasswordChar = True
        '
        'lblRPassword
        '
        Me.lblRPassword.AutoSize = True
        Me.lblRPassword.Font = New System.Drawing.Font("Calibri", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRPassword.ForeColor = System.Drawing.Color.Black
        Me.lblRPassword.Location = New System.Drawing.Point(6, 135)
        Me.lblRPassword.Name = "lblRPassword"
        Me.lblRPassword.Size = New System.Drawing.Size(129, 21)
        Me.lblRPassword.TabIndex = 65
        Me.lblRPassword.Text = "Retype Password"
        '
        'lblPassword
        '
        Me.lblPassword.AutoSize = True
        Me.lblPassword.Font = New System.Drawing.Font("Calibri", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPassword.ForeColor = System.Drawing.Color.Black
        Me.lblPassword.Location = New System.Drawing.Point(6, 102)
        Me.lblPassword.Name = "lblPassword"
        Me.lblPassword.Size = New System.Drawing.Size(77, 21)
        Me.lblPassword.TabIndex = 66
        Me.lblPassword.Text = "Password"
        '
        'txtUsername
        '
        Me.txtUsername.Font = New System.Drawing.Font("Berlin Sans FB", 12.75!)
        Me.txtUsername.Location = New System.Drawing.Point(141, 66)
        Me.txtUsername.Name = "txtUsername"
        Me.txtUsername.Size = New System.Drawing.Size(388, 26)
        Me.txtUsername.TabIndex = 64
        '
        'txtFullname
        '
        Me.txtFullname.Font = New System.Drawing.Font("Berlin Sans FB", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFullname.Location = New System.Drawing.Point(141, 33)
        Me.txtFullname.Name = "txtFullname"
        Me.txtFullname.Size = New System.Drawing.Size(388, 26)
        Me.txtFullname.TabIndex = 63
        '
        'lblUsername
        '
        Me.lblUsername.AutoSize = True
        Me.lblUsername.Font = New System.Drawing.Font("Calibri", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUsername.ForeColor = System.Drawing.Color.Black
        Me.lblUsername.Location = New System.Drawing.Point(6, 69)
        Me.lblUsername.Name = "lblUsername"
        Me.lblUsername.Size = New System.Drawing.Size(81, 21)
        Me.lblUsername.TabIndex = 61
        Me.lblUsername.Text = "Username"
        '
        'lblFullname
        '
        Me.lblFullname.AutoSize = True
        Me.lblFullname.Font = New System.Drawing.Font("Calibri", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFullname.ForeColor = System.Drawing.Color.Black
        Me.lblFullname.Location = New System.Drawing.Point(6, 36)
        Me.lblFullname.Name = "lblFullname"
        Me.lblFullname.Size = New System.Drawing.Size(78, 21)
        Me.lblFullname.TabIndex = 62
        Me.lblFullname.Text = "Full name"
        '
        'lblExistingUsers
        '
        Me.lblExistingUsers.AutoSize = True
        Me.lblExistingUsers.Font = New System.Drawing.Font("Calibri", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblExistingUsers.ForeColor = System.Drawing.Color.Black
        Me.lblExistingUsers.Location = New System.Drawing.Point(17, 62)
        Me.lblExistingUsers.Name = "lblExistingUsers"
        Me.lblExistingUsers.Size = New System.Drawing.Size(105, 21)
        Me.lblExistingUsers.TabIndex = 29
        Me.lblExistingUsers.Text = "Existing Users"
        '
        'btnRemove
        '
        Me.btnRemove.BackColor = System.Drawing.Color.Silver
        Me.btnRemove.FlatAppearance.BorderColor = System.Drawing.Color.Gray
        Me.btnRemove.FlatAppearance.BorderSize = 2
        Me.btnRemove.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRemove.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRemove.Location = New System.Drawing.Point(12, 408)
        Me.btnRemove.Name = "btnRemove"
        Me.btnRemove.Size = New System.Drawing.Size(292, 37)
        Me.btnRemove.TabIndex = 73
        Me.btnRemove.Text = "Remove Selected User"
        Me.btnRemove.UseVisualStyleBackColor = False
        '
        'btnHome
        '
        Me.btnHome.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(82, Byte), Integer), CType(CType(135, Byte), Integer))
        Me.btnHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnHome.Image = Global.Alumni_Management_System.My.Resources.Resources.Home
        Me.btnHome.Location = New System.Drawing.Point(12, 12)
        Me.btnHome.Name = "btnHome"
        Me.btnHome.Size = New System.Drawing.Size(41, 35)
        Me.btnHome.TabIndex = 74
        Me.btnHome.UseVisualStyleBackColor = True
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'ProgressBar1
        '
        Me.ProgressBar1.Location = New System.Drawing.Point(152, 459)
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(569, 10)
        Me.ProgressBar1.TabIndex = 75
        Me.ProgressBar1.Visible = False
        '
        'lblPleasewait
        '
        Me.lblPleasewait.AutoSize = True
        Me.lblPleasewait.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPleasewait.Location = New System.Drawing.Point(397, 472)
        Me.lblPleasewait.Name = "lblPleasewait"
        Me.lblPleasewait.Size = New System.Drawing.Size(95, 15)
        Me.lblPleasewait.TabIndex = 76
        Me.lblPleasewait.Text = "Please Wait..."
        Me.lblPleasewait.Visible = False
        '
        'Timer1
        '
        '
        'ManageUserForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(82, Byte), Integer), CType(CType(135, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(874, 496)
        Me.ControlBox = False
        Me.Controls.Add(Me.lblPleasewait)
        Me.Controls.Add(Me.ProgressBar1)
        Me.Controls.Add(Me.btnHome)
        Me.Controls.Add(Me.btnRemove)
        Me.Controls.Add(Me.lblExistingUsers)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.lstExistingUsers)
        Me.Controls.Add(Me.Title)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Location = New System.Drawing.Point(246, 148)
        Me.Name = "ManageUserForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.PicUser, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Title As System.Windows.Forms.Label
    Friend WithEvents lstExistingUsers As System.Windows.Forms.ListBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents lblExistingUsers As System.Windows.Forms.Label
    Friend WithEvents PicUser As System.Windows.Forms.PictureBox
    Friend WithEvents txtRPassword As System.Windows.Forms.TextBox
    Friend WithEvents txtPassword As System.Windows.Forms.TextBox
    Friend WithEvents lblRPassword As System.Windows.Forms.Label
    Friend WithEvents lblPassword As System.Windows.Forms.Label
    Friend WithEvents txtUsername As System.Windows.Forms.TextBox
    Friend WithEvents txtFullname As System.Windows.Forms.TextBox
    Friend WithEvents lblUsername As System.Windows.Forms.Label
    Friend WithEvents lblFullname As System.Windows.Forms.Label
    Friend WithEvents btnLoad As System.Windows.Forms.Button
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents btnRemove As System.Windows.Forms.Button
    Friend WithEvents btnHome As System.Windows.Forms.Button
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents ProgressBar1 As System.Windows.Forms.ProgressBar
    Friend WithEvents lblPleasewait As System.Windows.Forms.Label
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents cboRank As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
End Class
