<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ActivityForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ActivityForm))
        Me.Title = New System.Windows.Forms.Label()
        Me.txtTitle = New System.Windows.Forms.TextBox()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.lblExpence = New System.Windows.Forms.Label()
        Me.lblExpenseDiscription = New System.Windows.Forms.Label()
        Me.lblDate = New System.Windows.Forms.Label()
        Me.lblTitleDescription = New System.Windows.Forms.Label()
        Me.lblVenue = New System.Windows.Forms.Label()
        Me.txtTitleDescription = New System.Windows.Forms.TextBox()
        Me.txtVenue = New System.Windows.Forms.TextBox()
        Me.txtExpense = New System.Windows.Forms.TextBox()
        Me.txtExpenseDescription = New System.Windows.Forms.TextBox()
        Me.DateTimePickerDate = New System.Windows.Forms.DateTimePicker()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnLoad = New System.Windows.Forms.Button()
        Me.btnClearPic = New System.Windows.Forms.Button()
        Me.PicActivity = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.btnHome = New System.Windows.Forms.Button()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.txtNum = New System.Windows.Forms.TextBox()
        Me.lblNo = New System.Windows.Forms.Label()
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar()
        Me.lblPleaseWait = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        CType(Me.PicActivity, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Title
        '
        Me.Title.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(117, Byte), Integer), CType(CType(182, Byte), Integer))
        Me.Title.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Title.Font = New System.Drawing.Font("Rockwell", 18.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Title.ForeColor = System.Drawing.Color.FromArgb(CType(CType(220, Byte), Integer), CType(CType(56, Byte), Integer), CType(CType(118, Byte), Integer))
        Me.Title.Location = New System.Drawing.Point(267, 3)
        Me.Title.Name = "Title"
        Me.Title.Size = New System.Drawing.Size(410, 48)
        Me.Title.TabIndex = 24
        Me.Title.Text = "ADD NEW ACTIVITY"
        Me.Title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtTitle
        '
        Me.txtTitle.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTitle.Location = New System.Drawing.Point(395, 98)
        Me.txtTitle.Name = "txtTitle"
        Me.txtTitle.Size = New System.Drawing.Size(467, 31)
        Me.txtTitle.TabIndex = 29
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Font = New System.Drawing.Font("Berlin Sans FB", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.ForeColor = System.Drawing.Color.Black
        Me.lblTitle.Location = New System.Drawing.Point(301, 100)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(40, 19)
        Me.lblTitle.TabIndex = 28
        Me.lblTitle.Text = "Title"
        '
        'lblExpence
        '
        Me.lblExpence.AutoSize = True
        Me.lblExpence.Font = New System.Drawing.Font("Berlin Sans FB", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblExpence.ForeColor = System.Drawing.Color.Black
        Me.lblExpence.Location = New System.Drawing.Point(301, 257)
        Me.lblExpence.Name = "lblExpence"
        Me.lblExpence.Size = New System.Drawing.Size(65, 19)
        Me.lblExpence.TabIndex = 30
        Me.lblExpence.Text = "Expense"
        '
        'lblExpenseDiscription
        '
        Me.lblExpenseDiscription.AutoSize = True
        Me.lblExpenseDiscription.Font = New System.Drawing.Font("Berlin Sans FB", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblExpenseDiscription.ForeColor = System.Drawing.Color.Black
        Me.lblExpenseDiscription.Location = New System.Drawing.Point(301, 290)
        Me.lblExpenseDiscription.Name = "lblExpenseDiscription"
        Me.lblExpenseDiscription.Size = New System.Drawing.Size(89, 19)
        Me.lblExpenseDiscription.TabIndex = 31
        Me.lblExpenseDiscription.Text = "Description"
        '
        'lblDate
        '
        Me.lblDate.AutoSize = True
        Me.lblDate.Font = New System.Drawing.Font("Berlin Sans FB", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDate.ForeColor = System.Drawing.Color.Black
        Me.lblDate.Location = New System.Drawing.Point(301, 374)
        Me.lblDate.Name = "lblDate"
        Me.lblDate.Size = New System.Drawing.Size(44, 19)
        Me.lblDate.TabIndex = 32
        Me.lblDate.Text = "Date"
        '
        'lblTitleDescription
        '
        Me.lblTitleDescription.AutoSize = True
        Me.lblTitleDescription.Font = New System.Drawing.Font("Berlin Sans FB", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitleDescription.ForeColor = System.Drawing.Color.Black
        Me.lblTitleDescription.Location = New System.Drawing.Point(301, 138)
        Me.lblTitleDescription.Name = "lblTitleDescription"
        Me.lblTitleDescription.Size = New System.Drawing.Size(89, 19)
        Me.lblTitleDescription.TabIndex = 33
        Me.lblTitleDescription.Text = "Description"
        '
        'lblVenue
        '
        Me.lblVenue.AutoSize = True
        Me.lblVenue.Font = New System.Drawing.Font("Berlin Sans FB", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblVenue.ForeColor = System.Drawing.Color.Black
        Me.lblVenue.Location = New System.Drawing.Point(301, 224)
        Me.lblVenue.Name = "lblVenue"
        Me.lblVenue.Size = New System.Drawing.Size(54, 19)
        Me.lblVenue.TabIndex = 34
        Me.lblVenue.Text = "Venue"
        '
        'txtTitleDescription
        '
        Me.txtTitleDescription.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTitleDescription.Location = New System.Drawing.Point(395, 135)
        Me.txtTitleDescription.Multiline = True
        Me.txtTitleDescription.Name = "txtTitleDescription"
        Me.txtTitleDescription.Size = New System.Drawing.Size(467, 79)
        Me.txtTitleDescription.TabIndex = 58
        '
        'txtVenue
        '
        Me.txtVenue.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtVenue.Location = New System.Drawing.Point(395, 220)
        Me.txtVenue.Name = "txtVenue"
        Me.txtVenue.Size = New System.Drawing.Size(467, 27)
        Me.txtVenue.TabIndex = 59
        '
        'txtExpense
        '
        Me.txtExpense.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtExpense.Location = New System.Drawing.Point(395, 253)
        Me.txtExpense.Name = "txtExpense"
        Me.txtExpense.Size = New System.Drawing.Size(467, 27)
        Me.txtExpense.TabIndex = 60
        '
        'txtExpenseDescription
        '
        Me.txtExpenseDescription.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtExpenseDescription.Location = New System.Drawing.Point(395, 286)
        Me.txtExpenseDescription.Multiline = True
        Me.txtExpenseDescription.Name = "txtExpenseDescription"
        Me.txtExpenseDescription.Size = New System.Drawing.Size(467, 76)
        Me.txtExpenseDescription.TabIndex = 61
        '
        'DateTimePickerDate
        '
        Me.DateTimePickerDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateTimePickerDate.Location = New System.Drawing.Point(395, 368)
        Me.DateTimePickerDate.Name = "DateTimePickerDate"
        Me.DateTimePickerDate.Size = New System.Drawing.Size(467, 27)
        Me.DateTimePickerDate.TabIndex = 62
        '
        'btnSave
        '
        Me.btnSave.BackColor = System.Drawing.Color.Silver
        Me.btnSave.FlatAppearance.BorderColor = System.Drawing.Color.Gray
        Me.btnSave.FlatAppearance.BorderSize = 2
        Me.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSave.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSave.Location = New System.Drawing.Point(705, 416)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(157, 37)
        Me.btnSave.TabIndex = 68
        Me.btnSave.Text = "Save"
        Me.btnSave.UseVisualStyleBackColor = False
        '
        'btnClear
        '
        Me.btnClear.BackColor = System.Drawing.Color.Silver
        Me.btnClear.FlatAppearance.BorderColor = System.Drawing.Color.Gray
        Me.btnClear.FlatAppearance.BorderSize = 2
        Me.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnClear.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClear.Location = New System.Drawing.Point(395, 416)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(157, 37)
        Me.btnClear.TabIndex = 67
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = False
        '
        'btnLoad
        '
        Me.btnLoad.BackColor = System.Drawing.Color.Silver
        Me.btnLoad.FlatAppearance.BorderColor = System.Drawing.Color.Gray
        Me.btnLoad.FlatAppearance.BorderSize = 2
        Me.btnLoad.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLoad.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLoad.Location = New System.Drawing.Point(12, 382)
        Me.btnLoad.Name = "btnLoad"
        Me.btnLoad.Size = New System.Drawing.Size(232, 38)
        Me.btnLoad.TabIndex = 80
        Me.btnLoad.Text = "Load"
        Me.btnLoad.UseVisualStyleBackColor = False
        '
        'btnClearPic
        '
        Me.btnClearPic.BackColor = System.Drawing.Color.Gray
        Me.btnClearPic.FlatAppearance.BorderColor = System.Drawing.Color.Gray
        Me.btnClearPic.FlatAppearance.BorderSize = 2
        Me.btnClearPic.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnClearPic.Image = Global.Alumni_Management_System.My.Resources.Resources.Delete
        Me.btnClearPic.Location = New System.Drawing.Point(250, 382)
        Me.btnClearPic.Name = "btnClearPic"
        Me.btnClearPic.Size = New System.Drawing.Size(38, 38)
        Me.btnClearPic.TabIndex = 81
        Me.btnClearPic.UseVisualStyleBackColor = False
        '
        'PicActivity
        '
        Me.PicActivity.BackgroundImage = Global.Alumni_Management_System.My.Resources.Resources.Activity1
        Me.PicActivity.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.PicActivity.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PicActivity.Location = New System.Drawing.Point(12, 91)
        Me.PicActivity.Name = "PicActivity"
        Me.PicActivity.Size = New System.Drawing.Size(276, 285)
        Me.PicActivity.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PicActivity.TabIndex = 27
        Me.PicActivity.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = Global.Alumni_Management_System.My.Resources.Resources.Activity
        Me.PictureBox2.Location = New System.Drawing.Point(882, 12)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(49, 39)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 26
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
        Me.btnHome.TabIndex = 82
        Me.btnHome.UseVisualStyleBackColor = True
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'txtNum
        '
        Me.txtNum.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.txtNum.Enabled = False
        Me.txtNum.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNum.ForeColor = System.Drawing.Color.White
        Me.txtNum.Location = New System.Drawing.Point(395, 63)
        Me.txtNum.Name = "txtNum"
        Me.txtNum.Size = New System.Drawing.Size(157, 29)
        Me.txtNum.TabIndex = 84
        '
        'lblNo
        '
        Me.lblNo.AutoSize = True
        Me.lblNo.Font = New System.Drawing.Font("Berlin Sans FB", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNo.ForeColor = System.Drawing.Color.Black
        Me.lblNo.Location = New System.Drawing.Point(301, 67)
        Me.lblNo.Name = "lblNo"
        Me.lblNo.Size = New System.Drawing.Size(92, 19)
        Me.lblNo.TabIndex = 83
        Me.lblNo.Text = "Activity No."
        '
        'ProgressBar1
        '
        Me.ProgressBar1.Location = New System.Drawing.Point(91, 459)
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(680, 10)
        Me.ProgressBar1.TabIndex = 85
        Me.ProgressBar1.Visible = False
        '
        'lblPleaseWait
        '
        Me.lblPleaseWait.AutoSize = True
        Me.lblPleaseWait.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPleaseWait.Location = New System.Drawing.Point(392, 472)
        Me.lblPleaseWait.Name = "lblPleaseWait"
        Me.lblPleaseWait.Size = New System.Drawing.Size(95, 15)
        Me.lblPleaseWait.TabIndex = 86
        Me.lblPleaseWait.Text = "Please Wait..."
        Me.lblPleaseWait.Visible = False
        '
        'Timer1
        '
        '
        'ActivityForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(82, Byte), Integer), CType(CType(135, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(874, 496)
        Me.ControlBox = False
        Me.Controls.Add(Me.lblPleaseWait)
        Me.Controls.Add(Me.ProgressBar1)
        Me.Controls.Add(Me.txtNum)
        Me.Controls.Add(Me.lblNo)
        Me.Controls.Add(Me.btnHome)
        Me.Controls.Add(Me.btnClearPic)
        Me.Controls.Add(Me.btnLoad)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.DateTimePickerDate)
        Me.Controls.Add(Me.txtExpenseDescription)
        Me.Controls.Add(Me.txtExpense)
        Me.Controls.Add(Me.txtVenue)
        Me.Controls.Add(Me.txtTitleDescription)
        Me.Controls.Add(Me.lblVenue)
        Me.Controls.Add(Me.lblTitleDescription)
        Me.Controls.Add(Me.lblDate)
        Me.Controls.Add(Me.lblExpenseDiscription)
        Me.Controls.Add(Me.lblExpence)
        Me.Controls.Add(Me.txtTitle)
        Me.Controls.Add(Me.lblTitle)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.Title)
        Me.Controls.Add(Me.PicActivity)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Location = New System.Drawing.Point(246, 148)
        Me.Name = "ActivityForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        CType(Me.PicActivity, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents Title As System.Windows.Forms.Label
    Friend WithEvents PicActivity As System.Windows.Forms.PictureBox
    Friend WithEvents txtTitle As System.Windows.Forms.TextBox
    Friend WithEvents lblTitle As System.Windows.Forms.Label
    Friend WithEvents lblExpence As System.Windows.Forms.Label
    Friend WithEvents lblExpenseDiscription As System.Windows.Forms.Label
    Friend WithEvents lblDate As System.Windows.Forms.Label
    Friend WithEvents lblTitleDescription As System.Windows.Forms.Label
    Friend WithEvents lblVenue As System.Windows.Forms.Label
    Friend WithEvents txtTitleDescription As System.Windows.Forms.TextBox
    Friend WithEvents txtVenue As System.Windows.Forms.TextBox
    Friend WithEvents txtExpense As System.Windows.Forms.TextBox
    Friend WithEvents txtExpenseDescription As System.Windows.Forms.TextBox
    Friend WithEvents DateTimePickerDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents btnClear As System.Windows.Forms.Button
    Friend WithEvents btnClearPic As System.Windows.Forms.Button
    Friend WithEvents btnLoad As System.Windows.Forms.Button
    Friend WithEvents btnHome As System.Windows.Forms.Button
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents txtNum As System.Windows.Forms.TextBox
    Friend WithEvents lblNo As System.Windows.Forms.Label
    Friend WithEvents ProgressBar1 As System.Windows.Forms.ProgressBar
    Friend WithEvents lblPleaseWait As System.Windows.Forms.Label
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
End Class
