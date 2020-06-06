Imports System.Windows.Forms

Public Class Alumni_Management_System

    Private Sub ShowNewForm(ByVal sender As Object, ByVal e As EventArgs)
        ' Create a new instance of the child form.
        Dim ChildForm As New System.Windows.Forms.Form
        ' Make it a child of this MDI form before showing it.
        ChildForm.MdiParent = Me

        m_ChildFormNumber += 1
        ChildForm.Text = "Window " & m_ChildFormNumber

        ChildForm.Show()
    End Sub

    Private Sub OpenFile(ByVal sender As Object, ByVal e As EventArgs)
        Dim OpenFileDialog As New OpenFileDialog
        OpenFileDialog.InitialDirectory = My.Computer.FileSystem.SpecialDirectories.MyDocuments
        OpenFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*"
        If (OpenFileDialog.ShowDialog(Me) = System.Windows.Forms.DialogResult.OK) Then
            Dim FileName As String = OpenFileDialog.FileName
            ' TODO: Add code here to open the file.
        End If
    End Sub

    Private Sub SaveAsToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        Dim SaveFileDialog As New SaveFileDialog
        SaveFileDialog.InitialDirectory = My.Computer.FileSystem.SpecialDirectories.MyDocuments
        SaveFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*"

        If (SaveFileDialog.ShowDialog(Me) = System.Windows.Forms.DialogResult.OK) Then
            Dim FileName As String = SaveFileDialog.FileName
            ' TODO: Add code here to save the current contents of the form to a file.
        End If
    End Sub


    Private Sub ExitToolsStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles ExitToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub CutToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        ' Use My.Computer.Clipboard to insert the selected text or images into the clipboard
    End Sub

    Private Sub CopyToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        ' Use My.Computer.Clipboard to insert the selected text or images into the clipboard
    End Sub

    Private Sub PasteToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        'Use My.Computer.Clipboard.GetText() or My.Computer.Clipboard.GetData to retrieve information from the clipboard.
    End Sub

    Private Sub ToolBarToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        ' Me.ToolStrip.Visible = 'Me.ToolBarToolStripMenuItem.Checked
    End Sub

    Private Sub StatusBarToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        'Me.StatusStrip.Visible = 'Me.StatusBarToolStripMenuItem.Checked
    End Sub

    Private Sub CascadeToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        Me.LayoutMdi(MdiLayout.Cascade)
    End Sub

    Private Sub TileVerticalToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        Me.LayoutMdi(MdiLayout.TileVertical)
    End Sub

    Private Sub TileHorizontalToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        Me.LayoutMdi(MdiLayout.TileHorizontal)
    End Sub

    Private Sub ArrangeIconsToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        Me.LayoutMdi(MdiLayout.ArrangeIcons)
    End Sub

    Private Sub CloseAllToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        ' Close all child forms of the parent.
        For Each ChildForm As Form In Me.MdiChildren
            ChildForm.Close()
        Next
    End Sub

    Private m_ChildFormNumber As Integer

    Private Sub ExitToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem1.Click
        End
    End Sub

    Private Sub AToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AToolStripMenuItem.Click
        AboutForm.ShowDialog()
    End Sub

    Private Sub btnAddmem_Click(sender As Object, e As EventArgs) Handles btnAddmem.Click
        RegMemberForm.Title.Text = "REGISTER AS MEMBER"
        RegMemberForm.btnRegister.Text = "Register"
        RegMemberForm.ShowDialog()

    End Sub

    Private Sub Alumni_Management_System_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'size of the form
        Me.Size = My.Computer.Screen.WorkingArea.Size
        'slide pictures
        Timer1.Start()

        Rb1.Checked = True
        PictureBox1.Image = My.Resources.YAMS_2
        lblQuote.Text = "Manage Efficaciously using Alumni Management System"

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If Rb1.Checked = True Then
            Rb1.Checked = False
            Rb2.Checked = True
            PictureBox1.Image = My.Resources.YAMS_11
            lblQuote.Text = "Manage Efficiently using Alumni Management System"
        ElseIf Rb2.Checked = True Then
            Rb2.Checked = False
            Rb3.Checked = True
            PictureBox1.Image = My.Resources.YAMS
            lblQuote.Text = "Alumni Management System"
        ElseIf Rb3.Checked = True Then
            Rb3.Checked = False
            Rb4.Checked = True
            PictureBox1.Image = My.Resources.Member
            lblQuote.Text = "Register Members efficiently"
        ElseIf Rb4.Checked = True Then
            Rb4.Checked = False
            Rb5.Checked = True
            PictureBox1.Image = My.Resources.Staff
            lblQuote.Text = "Register teachers effectively"
        ElseIf Rb5.Checked = True Then
            Rb5.Checked = False
            Rb6.Checked = True
            PictureBox1.Image = My.Resources.Activity
            lblQuote.Text = "Keep track of activities and projects"
        ElseIf Rb6.Checked = True Then
            Rb6.Checked = False
            Rb7.Checked = True
            PictureBox1.Image = My.Resources.lockscreen_wallpaper
            lblQuote.Text = "By: Muhammad Abdulkadir Yola"
        ElseIf Rb7.Checked = True Then
            Rb7.Checked = False
            Rb1.Checked = True
            PictureBox1.Image = My.Resources.YAMS_2
            lblQuote.Text = "Manage Efficaciously using Alumni Management System"
        End If
    End Sub

    Private Sub Rb1_CheckedChanged(sender As Object, e As EventArgs) Handles Rb1.CheckedChanged
        PictureBox1.Image = My.Resources.YAMS_2

    End Sub

    Private Sub Rb2_CheckedChanged(sender As Object, e As EventArgs) Handles Rb2.CheckedChanged
        PictureBox1.Image = My.Resources.YAMS_11

    End Sub

    Private Sub btnMembs_Click(sender As Object, e As EventArgs) Handles btnMembs.Click
        ManageMembersForm.ShowDialog()
    End Sub

    Private Sub btnStaff_Click(sender As Object, e As EventArgs) Handles btnStaff.Click
        RegisterStaffForm.Title.Text = "REGISTER AS STAFF"
        RegisterStaffForm.btnRegister.Text = "Register"
        RegisterStaffForm.ShowDialog()
    End Sub

    Private Sub btnStaffs_Click(sender As Object, e As EventArgs) Handles btnStaffs.Click
        ManageStaffForm.ShowDialog()
    End Sub

    Private Sub btnActivity_Click(sender As Object, e As EventArgs) Handles btnActivity.Click
        ActivityForm.Title.Text = "ADD NEW ACTIVITY"
        ActivityForm.btnSave.Text = "Save"
        ActivityForm.ShowDialog()
    End Sub

    Private Sub btnActivities_Click(sender As Object, e As EventArgs) Handles btnActivities.Click
        ManageActivitiesForm.ShowDialog()

    End Sub

    Private Sub ToolStripButton2_Click(sender As Object, e As EventArgs) Handles ToolStripButton2.Click
        ManageUserForm.ShowDialog()
    End Sub

    Private Sub MemberHistoryToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles MemberHistoryToolStripMenuItem1.Click
        membersHistoryViewForm.ShowDialog()

    End Sub

    Private Sub VIEWToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles VIEWToolStripMenuItem.Click

    End Sub

    
    Private Sub ToolStripMenuItem5_MouseHover(sender As Object, e As EventArgs)
        Me.IsAccessible = True
        While Me.Focus


        End While




    End Sub

    Private Sub ToolStripMenuItem1_MouseHover(sender As Object, e As EventArgs) Handles ToolStripMenuItem1.MouseHover

    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click

    End Sub

    Private Sub ToolStripMenuItem2_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem2.Click
        End

    End Sub

    Private Sub ToolStripMenuItem4_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem4.Click
        Me.WindowState = FormWindowState.Minimized




    End Sub

    Private Sub ToolStripMenuItem3_Click(sender As Object, e As EventArgs)



    End Sub
End Class
