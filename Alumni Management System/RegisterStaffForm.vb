Imports System.IO

Public Class RegisterStaffForm

    Private Sub btnHome_Click(sender As Object, e As EventArgs) Handles btnHome.Click
        Close()
    End Sub

    Private Sub btnLoad_Click(sender As Object, e As EventArgs) Handles btnLoad.Click
        Dim opf As New OpenFileDialog
        opf.Title = "Select a Jpeg Image"
        opf.Filter = "Jpeg Images Only|*.jpg"
        opf.Multiselect = False
        If opf.ShowDialog = Windows.Forms.DialogResult.OK Then

            PicProfile.Image = Image.FromFile(opf.FileName)

        End If
        Dim ms As New MemoryStream
        PicProfile.Image.Save(ms, PicProfile.Image.RawFormat)

    End Sub

    Private Sub btnDelPic_Click(sender As Object, e As EventArgs) Handles btnDelPic.Click
        PicProfile.Image = Nothing
    End Sub

    Private Sub RegisterStaffForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtStaffNo.Focus()

        Dim db As New AlumniDataClassesDataContext

        Dim SectionadList = From p In db.Sections
                        Select p Order By p.ID Ascending

        cboSection.Items.Clear()
        If SectionadList.Count <> 0 Then
            For j = 1 To SectionadList.Count
                cboSection.Items.Add(SectionadList.ToList(j - 1).Name)
            Next
        End If

        Dim startYear = 2001
        Dim Yr = Today.Year - startYear
        cboYrAdmit.Items.Clear()
        cboYrExited.Items.Clear()
        For j = 1 To Yr
            cboYrAdmit.Items.Add(startYear & "/" & startYear + 1)
            cboYrExited.Items.Add(startYear & "/" & startYear + 1)
            startYear += 1
        Next
        Dim NationList = From p In db.Nationalities
                         Select p Order By p.ID Ascending

        cboNationality.Items.Clear()
        If NationList.Count <> 0 Then
            For j = 1 To NationList.Count
                cboNationality.Items.Add(NationList.ToList(j - 1).Name)
            Next
        End If
    End Sub

    Private Sub cboNationality_TextChanged(sender As Object, e As EventArgs) Handles cboNationality.TextChanged
        Dim db As New AlumniDataClassesDataContext

        Dim RegionList = From p In db.Regions
                       Select p Order By p.ID Where p.Country = cboNationality.Text

        cboRegion.Items.Clear()
        If RegionList.Count <> 0 Then
            For j = 1 To RegionList.Count
                cboRegion.Items.Add(RegionList.ToList(j - 1).Name)
            Next
        End If
    End Sub

    Private Sub cboRegion_TextChanged(sender As Object, e As EventArgs) Handles cboRegion.TextChanged
        Dim db As New AlumniDataClassesDataContext

        Dim StateList = From p In db.States
                       Select p Order By p.ID Where p.Region = cboRegion.Text

        cboState.Items.Clear()
        If StateList.Count <> 0 Then
            For j = 1 To StateList.Count
                cboState.Items.Add(StateList.ToList(j - 1).Name)
            Next
        End If
    End Sub

    Private Sub cboState_TextChanged(sender As Object, e As EventArgs) Handles cboState.TextChanged
        Dim db As New AlumniDataClassesDataContext

        Dim LGAList = From p In db.LGAs
                       Select p Order By p.ID Where p.State = cboState.Text

        cboLocalGovt.Items.Clear()
        If LGAList.Count <> 0 Then
            For j = 1 To LGAList.Count
                cboLocalGovt.Items.Add(LGAList.ToList(j - 1).Name)
            Next
        End If
    End Sub

    Private Sub btnRegister_Click(sender As Object, e As EventArgs) Handles btnRegister.Click
        Try
            Dim ms As New MemoryStream
            PicProfile.Image.Save(ms, PicProfile.Image.RawFormat)
        Catch ex As Exception
            MsgBox("Your picture is required, Please load it!!!", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly)
            Exit Sub
        End Try
        If txtFullname.Text = "" Or txtStaffNo.Text = "" Or cboGender.Text = "" Or cboStatus.Text = "" Or cboSection.Text = "" Or cboYrAdmit.Text = "" Or cboYrExited.Text = "" Or txtPassword.Text = "" Then
            MsgBox("Staff No., Fullname, Gender, Status, Section, Year Admit, Year Exit and Login Password all are required", MsgBoxStyle.Information + MsgBoxStyle.OkOnly)
            txtFullname.Focus()
            Exit Sub
        End If
        If txtPassword.Text <> txtRPassword.Text Then
            MsgBox("Login Password doesn't match!!!", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly)
            txtPassword.Focus()
            Exit Sub
        End If
        If btnRegister.Text = "Update" Then
            
        ElseIf btnRegister.Text = "Register" Then
            Dim db As New AlumniDataClassesDataContext
            If txtStaffNo.Text <> "" Then
                Dim SchRegCheck = From p In db.Staffs
                                Where p.StaffNo = txtStaffNo.Text
                                Select p

                If SchRegCheck.Count <> 0 Then
                    MsgBox("A person with the same Staff number 'Staff No.' already exist!!!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly)
                    Exit Sub
                End If
            End If

        End If
        ProgressBar1.Visible = True
        lblPleaseWait.Visible = True
        Timer1.Start()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        ProgressBar1.Increment(5)
        If ProgressBar1.Value = 100 Then
            Dim db As New AlumniDataClassesDataContext
            Dim AlumninNo = 1
            Dim mems = From p In db.Members
                       Select p Order By p.ID

            If mems.Count <> 0 Then
                For j = 1 To mems.Count
                    AlumninNo += 1
                Next
            End If
            Dim AlumninN As String
            If AlumninNo <= 9 Then
                AlumninN = "0000" & AlumninNo.ToString
            ElseIf AlumninNo <= 99 Then
                AlumninN = "000" & AlumninNo.ToString
            ElseIf AlumninNo <= 999 Then
                AlumninN = "00" & AlumninNo.ToString
            ElseIf AlumninNo <= 9999 Then
                AlumninN = "0" & AlumninNo.ToString
            ElseIf AlumninNo <= 99999 Then
                AlumninN = AlumninNo.ToString
            End If
            Dim username As String
            Dim name = txtFullname.Text.ToLower
            Dim f1 = name.First
            Dim s1 = name.IndexOf(" ")
            If s1 <> -1 Then
                Dim f2 = name.ElementAt(s1 + 1)
                Dim s2 = name.IndexOf(" ", s1 + 1)
                If s2 <> -1 Then
                    Dim f3 = name.ElementAt(s2 + 1)
                    username = f1 & f2 & f3 & AlumninN & ".staff@amsosa.org"
                Else
                    username = f1 & f2 & AlumninN & ".staff@amsosa.org"
                End If
            Else
                username = f1 & AlumninN & ".staff@amsosa.org"
            End If
            If btnRegister.Text = "Register" Then
                'Dim db As New AlumniDataClassesDataContext

                Dim ms As New MemoryStream
                PicProfile.Image.Save(ms, PicProfile.Image.RawFormat)
                Dim img As Byte()
                img = ms.ToArray

                Dim newStaff As New Staff With {.Username = username, .StaffNo = txtStaffNo.Text, .Fullname = txtFullname.Text, .Gender = cboGender.Text, .BirthDate = DateTimePickerBirth.Text, .Status = cboStatus.Text, .Rank = cboRank.Text, .Section = cboSection.Text, .YearAdmitted = cboYrAdmit.Text, .YearExited = cboYrExited.Text, .Phone = txtPhone.Text, .Email = txtEmail.Text, .Address = txtResAddress.Text, .Nationality = cboNationality.Text, .Region = cboRegion.Text, .State = cboState.Text, .LGA = cboLocalGovt.Text, .LoginPassword = txtPassword.Text, .CurrentWorkplace = txtWorkPlace.Text, .WorkAddress = txtWorkAddress.Text, .Picture = img, .SubjectTaught = txtSubjTaught.Text}
                db.Staffs.InsertOnSubmit(newStaff)
                db.SubmitChanges()
                Timer1.Stop()
                MsgBox("Registration successful!!!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly)
                InfoForm.lblInfo.Text = "Your Username is: " & username
                InfoForm.Title.Text = "USERNAME"
                InfoForm.ShowDialog()
                If InfoForm.ShowDialog Then
                    Beep()
                End If

                btnCancel_Click(sender, e)
            ElseIf btnRegister.Text = "Update" Then
                'Dim db As New AlumniDataClassesDataContext

                Dim EditStaff = From p In db.Staffs
                                 Where p.StaffNo = txtStaffNo.Text
                                 Select p

                If EditStaff.Count = 0 Then
                    MsgBox("The Staff No. entered does not exist", MsgBoxStyle.Information + MsgBoxStyle.OkOnly)
                    Exit Sub
                End If

                With EditStaff.FirstOrDefault
                    .StaffNo = txtStaffNo.Text
                    .Fullname = txtFullname.Text
                    .Gender = cboGender.Text
                    .BirthDate = DateTimePickerBirth.Text
                    .Status = cboStatus.Text
                    .Rank = cboRank.Text
                    .Section = cboSection.Text
                    .YearAdmitted = cboYrAdmit.Text
                    .YearExited = cboYrExited.Text
                    .Phone = txtPhone.Text
                    .Email = txtEmail.Text
                    .Address = txtResAddress.Text
                    .Nationality = cboNationality.Text
                    .Region = cboRegion.Text
                    .State = cboState.Text
                    .LGA = cboLocalGovt.Text
                    .LoginPassword = txtPassword.Text
                    .CurrentWorkplace = txtWorkPlace.Text
                    .WorkAddress = txtWorkAddress.Text
                    .Username = username
                    Dim ms As New MemoryStream
                    PicProfile.Image.Save(ms, PicProfile.Image.RawFormat)
                    Dim img() As Byte
                    img = ms.ToArray
                    .Picture = img
                    .SubjectTaught = txtSubjTaught.Text
                End With
                db.SubmitChanges()
                Timer1.Stop()
                MsgBox("Update successful!!!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly)
                InfoForm.lblInfo.Text = "Your Username is: " & username
                InfoForm.Title.Text = "USERNAME"
                InfoForm.ShowDialog()
                If InfoForm.ShowDialog Then
                    Beep()
                End If
                btnCancel_Click(sender, e)
            End If
        End If
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Timer1.Stop()
        ProgressBar1.Visible = False
        lblPleaseWait.Visible = False
        txtStaffNo.Clear()
        txtFullname.Clear()
        cboGender.Text = ""
        DateTimePickerBirth.Text = ""
        cboStatus.Text = ""
        cboRank.Text = ""
        cboSection.Text = ""
        cboYrAdmit.Text = ""
        cboYrExited.Text = ""
        txtPhone.Clear()
        txtEmail.Clear()
        txtResAddress.Clear()
        cboNationality.Text = ""
        cboRegion.Text = ""
        cboState.Text = ""
        cboLocalGovt.Text = ""
        txtPassword.Clear()
        txtRPassword.Clear()
        txtWorkPlace.Clear()
        txtWorkAddress.Clear()
        PicProfile.Image = Nothing
        ProgressBar1.Value = 0
        RegisterStaffForm_Load(sender, e)
        If btnRegister.Text = "Update" Then
            Me.Close()
        End If
    End Sub
End Class