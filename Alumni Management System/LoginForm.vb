Public Class LoginForm

    Private Sub lblShowPass_Click(sender As Object, e As EventArgs) Handles lblShowPass.Click
        If lblShowPass.Text = "SHOW" Then
            lblShowPass.Text = "HIDE"
            txtPassword.PasswordChar = ""
        Else
            lblShowPass.Text = "SHOW"
            txtPassword.PasswordChar = "*"
        End If
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        End
    End Sub

    Private Sub LoginForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblShowPass.Text = "SHOW"

    End Sub

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        If txtPassword.Text = "" Or txtUsername.Text = "" Or cboStatus.Text = "" Then
            MsgBox("All fields are required!!!", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly)
            Exit Sub
        End If
        If cboStatus.Text = "Admin" Or cboStatus.Text = "Member" Or cboStatus.Text = "Teacher" Then
            Timer1.Start()
        Else
            MsgBox("Select a your status from the given options!!!", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly)
        End If

        
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        ProgressBar1.Increment(5)
        If ProgressBar1.Value = 100 Then
            Dim db As New AlumniDataClassesDataContext
            If cboStatus.Text = "Admin" Then
                'Search for the admin in the users table
                Dim user = From p In db.Users
                           Where p.Username = txtUsername.Text And p.Password = txtPassword.Text
                           Select p

                If user.Count <> 0 Then
                    Me.Close()
                    Alumni_Management_System.ShowDialog()
                Else
                    Timer1.Stop()
                    MsgBox("Incorrect status, username or password!!!", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly)
                    Exit Sub
                End If
            ElseIf cboStatus.Text = "Member" Then
                'Search for the user in the members table
                Dim mUser = From p In db.Members
                            Where p.Username = txtUsername.Text And p.LoginPassword = txtPassword.Text
                            Select p

                If mUser.Count <> 0 Then
                    Me.Close()
                    Alumni_Management_System.ShowDialog()
                Else
                    Timer1.Stop()
                    MsgBox("Incorrect status, username or password!!!", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly)
                    Exit Sub
                End If
            Else
                'Search for the user in the Teachers table
                Dim tUser = From p In db.Staffs
                            Where p.Username = txtUsername.Text And p.LoginPassword = txtPassword.Text
                            Select p

                If tUser.Count <> 0 Then
                    Me.Close()
                    Alumni_Management_System.ShowDialog()
                Else
                    Timer1.Stop()
                    MsgBox("Incorrect status, username or password!!!", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly)
                    Exit Sub
                End If
            End If

        End If
        
    End Sub
End Class