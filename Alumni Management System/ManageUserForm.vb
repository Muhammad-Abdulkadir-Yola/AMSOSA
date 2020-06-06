Imports System.IO

Public Class ManageUserForm

    Private Sub btnHome_Click(sender As Object, e As EventArgs) Handles btnHome.Click
        Close()
    End Sub

    Private Sub btnRemove_Click(sender As Object, e As EventArgs) Handles btnRemove.Click
        If lstExistingUsers.Text = "" Then
            MsgBox("Please select an existing user first!!!", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly)
            Exit Sub
        End If
        If lstExistingUsers.Items.Count = 1 Then
            MsgBox("You can't remove all the users, one must be left so that the system can be accessible!!!", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly)
            Exit Sub
        End If
        'MsgBox("Are you sure you want to delete the selected user!", MsgBoxStyle.Information + MsgBoxStyle.YesNo)
        If MsgBoxResult.Yes Then
            Dim db As New AlumniDataClassesDataContext
            Dim deluser = From p In db.Users
                          Where p.Username = lstExistingUsers.Text
                          Select p

            db.Users.DeleteOnSubmit(deluser.FirstOrDefault)
            db.SubmitChanges()
            MsgBox("User successfully deleted!!!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly)
            ManageUserForm_Load(sender, e)
        ElseIf MsgBoxResult.No Then
            Exit Sub
        End If

    End Sub

    Private Sub btnLoad_Click(sender As Object, e As EventArgs) Handles btnLoad.Click
        Try
            Dim opf As New OpenFileDialog

            opf.Filter = "Select a Jpeg Image|*.jpg"
            opf.FileName = ""
            opf.Multiselect = False
            opf.Title = "Select a Jpeg Image"
            If opf.ShowDialog = Windows.Forms.DialogResult.OK Then

                PicUser.Image = Image.FromFile(opf.FileName)

            End If

            Dim ms As New MemoryStream
            PicUser.Image.Save(ms, PicUser.Image.RawFormat)
        Catch ex As Exception

        End Try

    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Try
            Dim ms As New MemoryStream
            PicUser.Image.Save(ms, PicUser.Image.RawFormat)
        Catch ex As Exception
            MsgBox("Your picture is required, Please load it!!!", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly)
            Exit Sub
        End Try
        If txtFullname.Text = "" Or txtPassword.Text = "" Or txtRPassword.Text = "" Or txtUsername.Text = "" Then
            MsgBox("All fields are reguired!!!", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly)
            Exit Sub
        End If
        If txtPassword.Text <> txtRPassword.Text Then
            MsgBox("Password doesn't match!!!", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly)
            Exit Sub
        End If
        Dim db As New AlumniDataClassesDataContext
        Dim check = From p In db.Users
                    Where p.Username = txtUsername.Text
                    Select p

        If check.Count <> 0 Then
            MsgBox("User with the same 'Username' exist, Please change!!!", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly)
            Exit Sub
        End If
        ProgressBar1.Visible = True
        lblPleasewait.Visible = True
        Timer1.Start()
    End Sub

    Private Sub ManageUserForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtFullname.Focus()
        Dim db As New AlumniDataClassesDataContext
        Dim userList = From p In db.Users
                       Select p Order By p.Username Ascending

        lstExistingUsers.Items.Clear()
        If userList.Count <> 0 Then
            For j = 1 To userList.Count
                lstExistingUsers.Items.Add(userList.ToList(j - 1).Username)
            Next
        End If
        Dim rank = From p In db.Ranks
                   Select p Order By p.ID Ascending

        cboRank.Items.Clear()
        If rank.Count <> 0 Then
            For j = 1 To rank.Count
                cboRank.Items.Add(rank.ToList(j - 1).Title)
            Next
        End If
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        ProgressBar1.Increment(5)
        If ProgressBar1.Value = 100 Then
            Dim db As New AlumniDataClassesDataContext

            Dim newUser As New User With {.Username = txtUsername.Text, .Fullname = txtFullname.Text, .Password = txtPassword.Text, .Rank = cboRank.Text, .Picture = PicUser.ImageLocation}
            db.Users.InsertOnSubmit(newUser)
            db.SubmitChanges()
            Timer1.Stop()
            MsgBox("Details saved successfully!!!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly)
            ProgressBar1.Visible = False
            lblPleasewait.Visible = False
            txtFullname.Clear()
            txtPassword.Clear()
            txtRPassword.Clear()
            txtUsername.Clear()
            PicUser.Image = Nothing
            ProgressBar1.Value = 0

            ManageUserForm_Load(sender, e)

            Exit Sub

        End If
    End Sub

End Class