<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class membersHistoryViewForm
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
        Dim ReportDataSource1 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Me.Title = New System.Windows.Forms.Label()
        Me.btnRefresh = New System.Windows.Forms.Button()
        Me.lblChapter = New System.Windows.Forms.Label()
        Me.cboChapter = New System.Windows.Forms.ComboBox()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.btnHome = New System.Windows.Forms.Button()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.AlumniDataSet = New Global.Alumni_Management_System.AlumniDataSet()
        Me.MemberBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.MemberTableAdapter = New Global.Alumni_Management_System.AlumniDataSetTableAdapters.MemberTableAdapter()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AlumniDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MemberBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Title
        '
        Me.Title.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(117, Byte), Integer), CType(CType(182, Byte), Integer))
        Me.Title.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Title.Font = New System.Drawing.Font("Rockwell", 18.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Title.ForeColor = System.Drawing.Color.FromArgb(CType(CType(220, Byte), Integer), CType(CType(56, Byte), Integer), CType(CType(118, Byte), Integer))
        Me.Title.Location = New System.Drawing.Point(186, 8)
        Me.Title.Name = "Title"
        Me.Title.Size = New System.Drawing.Size(507, 48)
        Me.Title.TabIndex = 82
        Me.Title.Text = "MEMBERS LISTS"
        Me.Title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnRefresh
        '
        Me.btnRefresh.BackColor = System.Drawing.Color.Silver
        Me.btnRefresh.FlatAppearance.BorderColor = System.Drawing.Color.Gray
        Me.btnRefresh.FlatAppearance.BorderSize = 2
        Me.btnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRefresh.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRefresh.Location = New System.Drawing.Point(717, 59)
        Me.btnRefresh.Name = "btnRefresh"
        Me.btnRefresh.Size = New System.Drawing.Size(145, 31)
        Me.btnRefresh.TabIndex = 87
        Me.btnRefresh.Text = "Print"
        Me.btnRefresh.UseVisualStyleBackColor = False
        '
        'lblChapter
        '
        Me.lblChapter.AutoSize = True
        Me.lblChapter.Font = New System.Drawing.Font("Calibri", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblChapter.ForeColor = System.Drawing.Color.Black
        Me.lblChapter.Location = New System.Drawing.Point(12, 65)
        Me.lblChapter.Name = "lblChapter"
        Me.lblChapter.Size = New System.Drawing.Size(65, 21)
        Me.lblChapter.TabIndex = 89
        Me.lblChapter.Text = "Chapter"
        '
        'cboChapter
        '
        Me.cboChapter.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cboChapter.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cboChapter.DisplayMember = "Name"
        Me.cboChapter.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboChapter.FormattingEnabled = True
        Me.cboChapter.Items.AddRange(New Object() {"2012", "2013", "2014", "2015", "2016", "2017", "2018", "2019"})
        Me.cboChapter.Location = New System.Drawing.Point(83, 62)
        Me.cboChapter.Name = "cboChapter"
        Me.cboChapter.Size = New System.Drawing.Size(165, 28)
        Me.cboChapter.TabIndex = 90
        Me.cboChapter.ValueMember = "Name"
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Font = New System.Drawing.Font("Berlin Sans FB", 12.75!)
        Me.CheckBox1.Location = New System.Drawing.Point(263, 69)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(86, 23)
        Me.CheckBox1.TabIndex = 92
        Me.CheckBox1.Text = "View All"
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'btnHome
        '
        Me.btnHome.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(82, Byte), Integer), CType(CType(135, Byte), Integer))
        Me.btnHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnHome.Image = Global.Alumni_Management_System.My.Resources.Resources.Home
        Me.btnHome.Location = New System.Drawing.Point(12, 17)
        Me.btnHome.Name = "btnHome"
        Me.btnHome.Size = New System.Drawing.Size(41, 35)
        Me.btnHome.TabIndex = 84
        Me.btnHome.UseVisualStyleBackColor = True
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = Global.Alumni_Management_System.My.Resources.Resources.Members
        Me.PictureBox2.Location = New System.Drawing.Point(803, 17)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(56, 39)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 83
        Me.PictureBox2.TabStop = False
        '
        'ReportViewer1
        '
        ReportDataSource1.Name = "mambersDS"
        ReportDataSource1.Value = Me.MemberBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "Alumni_Management_System.AMSOSA_MEMBERS.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(12, 124)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.Size = New System.Drawing.Size(850, 360)
        Me.ReportViewer1.TabIndex = 93
        '
        'AlumniDataSet
        '
        Me.AlumniDataSet.DataSetName = "AlumniDataSet"
        Me.AlumniDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'MemberBindingSource
        '
        Me.MemberBindingSource.DataMember = "Member"
        Me.MemberBindingSource.DataSource = Me.AlumniDataSet
        '
        'MemberTableAdapter
        '
        Me.MemberTableAdapter.ClearBeforeFill = True
        '
        'membersHistoryViewForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(82, Byte), Integer), CType(CType(135, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(874, 496)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Controls.Add(Me.CheckBox1)
        Me.Controls.Add(Me.cboChapter)
        Me.Controls.Add(Me.lblChapter)
        Me.Controls.Add(Me.btnRefresh)
        Me.Controls.Add(Me.btnHome)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.Title)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "membersHistoryViewForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "membersHistoryViewForm"
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AlumniDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MemberBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents btnHome As System.Windows.Forms.Button
    Friend WithEvents Title As System.Windows.Forms.Label
    Friend WithEvents btnRefresh As System.Windows.Forms.Button
    'Friend WithEvents Member1TableAdapter As Global.Alumni_Management_System.AlumniDataSetTableAdapters.Member1TableAdapter
    Friend WithEvents lblChapter As System.Windows.Forms.Label
    Friend WithEvents cboChapter As System.Windows.Forms.ComboBox
    Friend WithEvents CheckBox1 As System.Windows.Forms.CheckBox
    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents MemberBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents AlumniDataSet As Global.Alumni_Management_System.AlumniDataSet
    Friend WithEvents MemberTableAdapter As Global.Alumni_Management_System.AlumniDataSetTableAdapters.MemberTableAdapter
End Class
