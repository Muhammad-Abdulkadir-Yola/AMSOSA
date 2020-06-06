Imports System.IO

Public Class RegMemberForm

    Private Sub btnHome_Click(sender As Object, e As EventArgs) Handles btnHome.Click
        Close()
    End Sub

    Private Sub RegMemberForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        
        'TODO: This line of code loads data into the 'AlumniDataSet._Class' table. You can move, or remove it, as needed.
        'Me.ClassTableAdapter.Fill(Me.AlumniDataSet._Class)
        txtSchRegNo.Focus()

        Dim db As New AlumniDataClassesDataContext

        Dim AlumninNo = 1
        Dim mems = From p In db.Members
                   Select p Order By p.ID


        If mems.Count <> 0 Then
            For j = 1 To mems.Count
                AlumninNo += 1
            Next
        End If
        'If mems.Count <> 0 Then
        '    For j = 1 To mems.Count
        '        AlumninNo += 1
        '    Next
        'End If
        If AlumninNo <= 9 Then
            txtRegNo.Text = "AMSOSA/0000" & AlumninNo
        ElseIf AlumninNo <= 99 Then
            txtRegNo.Text = "AMSOSA/000" & AlumninNo
        ElseIf AlumninNo <= 999 Then
            txtRegNo.Text = "AMSOSA/00" & AlumninNo
        ElseIf AlumninNo <= 9999 Then
            txtRegNo.Text = "AMSOSA/0" & AlumninNo
        ElseIf AlumninNo <= 99999 Then
            txtRegNo.Text = "AMSOSA/" & AlumninNo
        End If

        Dim RankList = From p In db.Ranks
                       Select p Order By p.ID Ascending

        cboRank.Items.Clear()
        If RankList.Count <> 0 Then
            For j = 1 To RankList.Count
                cboRank.Items.Add(RankList.ToList(j - 1).Title)
            Next
        End If

        Dim SectionadList = From p In db.Sections
                        Select p Order By p.ID Ascending

        cboSectionAdm.Items.Clear()
        If SectionadList.Count <> 0 Then
            For j = 1 To SectionadList.Count
                cboSectionAdm.Items.Add(SectionadList.ToList(j - 1).Name)
            Next
        End If

        Dim Sectionexlist = From p In db.Sections
                            Select p Order By p.ID Ascending

        cboSectionExit.Items.Clear()
        If Sectionexlist.Count <> 0 Then
            For j = 1 To Sectionexlist.Count
                cboSectionExit.Items.Add(Sectionexlist.ToList(j - 1).Name)
            Next
        End If
        Dim PrefectList = From p In db.Prefects
                          Select p Order By p.ID Ascending

        cboPrefect.Items.Clear()
        If PrefectList.Count <> 0 Then
            For j = 1 To PrefectList.Count
                cboPrefect.Items.Add(PrefectList.ToList(j - 1).Title)
            Next
        End If

        Dim NationList = From p In db.Nationalities
                         Select p Order By p.ID Ascending

        cboNationality.Items.Clear()
        If NationList.Count <> 0 Then
            For j = 1 To NationList.Count
                cboNationality.Items.Add(NationList.ToList(j - 1).Name)
            Next
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

                PicProfile.Image = Image.FromFile(opf.FileName)

            End If

            Dim ms As New MemoryStream
            PicProfile.Image.Save(ms, PicProfile.Image.RawFormat)
        Catch ex As Exception

        End Try
        
    End Sub

    Private Sub btnDelPic_Click(sender As Object, e As EventArgs) Handles btnDelPic.Click
        PicProfile.Image = Nothing

    End Sub

    Private Sub cboSectionExit_TextChanged(sender As Object, e As EventArgs) Handles cboSectionExit.TextChanged
        Dim db As New AlumniDataClassesDataContext

        Dim ClassExlist = From p In db.Classes
                        Select p Order By p.ID Ascending Where p.Section = cboSectionExit.Text

        cboCExit.Items.Clear()
        If ClassExlist.Count <> 0 Then
            For j = 1 To ClassExlist.Count
                cboCExit.Items.Add(ClassExlist.ToList(j - 1).Name)
            Next
        End If
        If cboSectionExit.Text = "Secondary" Then
            Dim MSSlist = From p In db.MSSes
                        Select p Order By p.ID Ascending

            cboMSS.Items.Clear()
            If MSSlist.Count <> 0 Then
                For j = 1 To MSSlist.Count
                    cboMSS.Items.Add(MSSlist.ToList(j - 1).Title)
                Next
            End If
        Else
            cboMSS.Items.Clear()
        End If

        If cboSectionExit.Text = "Primary" Then
            Dim PristartYear = 2001
            Dim PriYr = Today.Year - PristartYear
            cboYExit.Items.Clear()
            For j = 1 To PriYr
                cboYExit.Items.Add(PristartYear & "/" & PristartYear + 1)
                PristartYear += 1
            Next

        ElseIf cboSectionExit.Text = "Secondary" Then
            Dim SecstartYear = 2007
            Dim SecYr = Today.Year - SecstartYear
            cboYExit.Items.Clear()
            For j = 1 To SecYr
                cboYExit.Items.Add(SecstartYear & "/" & SecstartYear + 1)
                SecstartYear += 1
            Next

        ElseIf cboSectionExit.Text = "Primary Islamiyya" Then
            Dim IPristartYear = 2008
            Dim IPYr = Today.Year - IPristartYear
            cboYExit.Items.Clear()
            For j = 1 To IPYr
                cboYExit.Items.Add(IPristartYear & "/" & IPristartYear + 1)
                IPristartYear += 1
            Next

        ElseIf cboSectionExit.Text = "Secondary Islamiyya" Then
            Dim ISecstartYear = 2016
            Dim ISYr = Today.Year - ISecstartYear
            cboYExit.Items.Clear()
            For j = 1 To ISYr
                cboYExit.Items.Add(ISecstartYear & "/" & ISecstartYear + 1)
                ISecstartYear += 1
            Next

        End If
    End Sub

    Private Sub cboSectionAdm_TextChanged(sender As Object, e As EventArgs) Handles cboSectionAdm.TextChanged
        Dim db As New AlumniDataClassesDataContext

        Dim ClassAdlist = From p In db.Classes
                          Select p Order By p.ID Where p.Section = cboSectionAdm.Text


        cboCAdmit.Items.Clear()
        If ClassAdlist.Count <> 0 Then
            cboYAdmit.Items.Clear()
            For j = 1 To ClassAdlist.Count
                cboCAdmit.Items.Add(ClassAdlist.ToList(j - 1).Name)
            Next
        End If

        If cboSectionAdm.Text = "Primary" Then
            Dim PristartYear = 2001
            Dim PriYr = Today.Year - PristartYear
            cboYAdmit.Items.Clear()
            For j = 1 To PriYr
                cboYAdmit.Items.Add(PristartYear & "/" & PristartYear + 1)
                PristartYear += 1
            Next

        ElseIf cboSectionAdm.Text = "Secondary" Then
            Dim SecstartYear = 2007
            Dim SecYr = Today.Year - SecstartYear
            cboYAdmit.Items.Clear()
            For j = 1 To SecYr
                cboYAdmit.Items.Add(SecstartYear & "/" & SecstartYear + 1)
                SecstartYear += 1
            Next

        ElseIf cboSectionAdm.Text = "Primary Islamiyya" Then
            Dim IPristartYear = 2008
            Dim IPYr = Today.Year - IPristartYear
            cboYAdmit.Items.Clear()
            For j = 1 To IPYr
                cboYAdmit.Items.Add(IPristartYear & "/" & IPristartYear + 1)
                IPristartYear += 1
            Next

        ElseIf cboSectionAdm.Text = "Secondary Islamiyya" Then
            Dim ISecstartYear = 2016
            Dim ISYr = Today.Year - ISecstartYear
            cboYAdmit.Items.Clear()
            For j = 1 To ISYr
                cboYAdmit.Items.Add(ISecstartYear & "/" & ISecstartYear + 1)
                ISecstartYear += 1
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

        cboLGA.Items.Clear()
        If LGAList.Count <> 0 Then
            For j = 1 To LGAList.Count
                cboLGA.Items.Add(LGAList.ToList(j - 1).Name)
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
        If txtFullname.Text = "" Or cboGender.Text = "" Or cboStatus.Text = "" Or cboSectionAdm.Text = "" Or cboSectionExit.Text = "" Or cboYAdmit.Text = "" Or cboYExit.Text = "" Or cboCAdmit.Text = "" Or cboCExit.Text = "" Or txtPassword.Text = "" Then
            MsgBox("Fullname, Gender, Status, Section Admited to (Section Ad.), Section Exit, Year Admit, Year Exit, Class Admit, Class Exit and Login Password all are required", MsgBoxStyle.Information + MsgBoxStyle.OkOnly)
            txtFullname.Focus()
            Exit Sub
        End If
        If txtPassword.Text <> txtRPassword.Text Then
            MsgBox("Login Password doesn't match!!!", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly)
            txtPassword.Focus()
            Exit Sub
        End If
        If btnRegister.Text = "Update" Then
            Dim db As New AlumniDataClassesDataContext

            Dim checkMember = From p In db.Members
                                  Where p.RegNo <> txtRegNo.Text And p.SchRegNo = txtSchRegNo.Text
                                  Select p

            If checkMember.Count <> 0 Then
                MsgBox("A member with the same School Registration Number(Sch. Reg. No) already exist", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly)
                Exit Sub
            End If
        ElseIf btnRegister.Text = "Register" Then
            Dim db As New AlumniDataClassesDataContext
            If txtSchRegNo.Text <> "" Then
                Dim SchRegCheck = From p In db.Members
                                Where p.SchRegNo = txtSchRegNo.Text
                                Select p

                If SchRegCheck.Count <> 0 Then
                    MsgBox("A person with the same School Registration number 'Sch. Reg. No' already exist!!!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly)
                    Exit Sub
                End If
            End If

        End If
        ProgressBar1.Visible = True
        lblPleaseWait.Visible = True
        Timer1.Start()

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Me.Enabled = False
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
            'Generate chapter of the system 2016/2018
            Dim yr As Integer
            Yr = cboYExit.Text.Remove(0, 5)
            Dim chapter As String
            If (cboCExit.Text = "SSS Three") Then
                chapter = yr
            ElseIf (cboCExit.Text = "SSS Two") Then
                chapter = yr + 1
            ElseIf (cboCExit.Text = "SSS One") Then
                chapter = yr + 2
            ElseIf (cboCExit.Text = "JSS Three") Then
                chapter = yr + 3
            ElseIf (cboCExit.Text = "JSS Two") Then
                chapter = yr + 4
            ElseIf (cboCExit.Text = "JSS One") Then
                chapter = yr + 5
            ElseIf (cboCExit.Text = "Grade Five") Then
                chapter = yr + 6
            ElseIf (cboCExit.Text = "Grade Four") Then
                chapter = yr + 7
            ElseIf (cboCExit.Text = "Grade Three") Then
                chapter = yr + 8
            ElseIf (cboCExit.Text = "Grade Two") Then
                chapter = yr + 9
            ElseIf (cboCExit.Text = "Grade Two") Then
                chapter = yr + 10
            ElseIf (cboCExit.Text = "Grade One") Then
                chapter = yr + 11
            ElseIf (cboCExit.Text = "Nusery Three") Then
                chapter = yr + 12
            ElseIf (cboCExit.Text = "Nusery Two") Then
                chapter = yr + 13
            ElseIf (cboCExit.Text = "Nusery One") Then
                chapter = yr + 14
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
                    username = f1 & f2 & f3 & AlumninN & ".member@amsosa.org"
                Else
                    username = f1 & f2 & AlumninN & ".member@amsosa.org"
                End If
            Else
                username = f1 & AlumninN & ".member@amsosa.org"
            End If

            If btnRegister.Text = "Register" Then
                'Dim db As New AlumniDataClassesDataContext

                Dim ms As New MemoryStream
                PicProfile.Image.Save(ms, PicProfile.Image.RawFormat)

                Dim img() As Byte
                img = ms.ToArray


                Dim newMember As New Member With {.RegNo = txtRegNo.Text, .SchRegNo = txtSchRegNo.Text, .Fullname = txtFullname.Text, .Gender = cboGender.Text, .BirthDate = DateTimePickerBirth.Text, .Status = cboStatus.Text, .Rank = cboRank.Text, .SectionAdmitted = cboSectionAdm.Text, .SectionExited = cboSectionExit.Text, .YearAdmitted = cboYAdmit.Text, .YearExited = cboYExit.Text, .ClassAdmitted = cboCAdmit.Text, .ClassExited = cboCExit.Text, .Prefect = cboPrefect.Text, .MSS = cboMSS.Text, .Phone = txtPhone.Text, .Email = txtEmail.Text, .Address = txtRAddress.Text, .Nationality = cboNationality.Text, .Region = cboRegion.Text, .State = cboState.Text, .LGA = cboLGA.Text, .LoginPassword = txtPassword.Text, .PresentSch = txtSchool.Text, .WorkPlace = txtWork.Text, .WorkAddress = txtWAddress.Text, .Picture = img, .Username = username, .Chapter = chapter}
                db.Members.InsertOnSubmit(newMember)

                db.SubmitChanges()
                Me.Enabled = True

                Timer1.Stop()
                MsgBox("Registration successful!!!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly)
                InfoForm.lblInfo.Text = "You belong to " & chapter & " Chapter and Your Username is: " & username
                InfoForm.Title.Text = "USERNAME"
                InfoForm.ShowDialog()
                If InfoForm.ShowDialog Then
                    Beep()
                End If
                Me.Enabled = True
                btnCancel_Click(sender, e)
            ElseIf btnRegister.Text = "Update" Then
                'Dim db As New AlumniDataClassesDataContext

                Dim EditMember = From p In db.Members
                                    Where p.RegNo = txtRegNo.Text
                                    Select p

                With EditMember.FirstOrDefault
                    .RegNo = txtRegNo.Text
                    .SchRegNo = txtSchRegNo.Text
                    .Fullname = txtFullname.Text
                    .Gender = cboGender.Text
                    .BirthDate = DateTimePickerBirth.Text
                    .Status = cboStatus.Text
                    .Rank = cboRank.Text
                    .SectionAdmitted = cboSectionAdm.Text
                    .SectionExited = cboSectionExit.Text
                    .YearAdmitted = cboYAdmit.Text
                    .YearExited = cboYExit.Text
                    .ClassAdmitted = cboCAdmit.Text
                    .ClassExited = cboCExit.Text
                    .Prefect = cboPrefect.Text
                    .MSS = cboMSS.Text
                    .Phone = txtPhone.Text
                    .Email = txtEmail.Text
                    .Address = txtRAddress.Text
                    .Nationality = cboNationality.Text
                    .Region = cboRegion.Text
                    .State = cboState.Text
                    .LGA = cboLGA.Text
                    .LoginPassword = txtPassword.Text
                    .PresentSch = txtSchool.Text
                    .WorkPlace = txtWork.Text
                    .WorkAddress = txtWAddress.Text
                    Dim ms As New MemoryStream
                    PicProfile.Image.Save(ms, PicProfile.Image.RawFormat)
                    Dim img As Byte()
                    img = ms.ToArray
                    .Picture = img
                    .Username = username
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
                Me.Enabled = True
                btnCancel_Click(sender, e)
            End If

        End If


    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Timer1.Stop()
        ProgressBar1.Visible = False
        lblPleaseWait.Visible = False
        txtSchRegNo.Text = ""
        txtFullname.Text = ""
        cboGender.Text = ""
        DateTimePickerBirth.Text = ""
        cboStatus.Text = ""
        cboRank.Text = ""
        cboSectionAdm.Text = ""
        cboSectionExit.Text = ""
        cboYAdmit.Text = ""
        cboYExit.Text = ""
        cboCAdmit.Text = ""
        cboCExit.Text = ""
        cboPrefect.Text = ""
        cboMSS.Text = ""
        txtPhone.Text = ""
        txtEmail.Text = ""
        txtRAddress.Text = ""
        cboNationality.Text = ""
        cboRegion.Text = ""
        cboState.Text = ""
        cboLGA.Text = ""
        txtPassword.Text = ""
        txtRPassword.Text = ""
        txtSchool.Text = ""
        txtWork.Text = ""
        txtWAddress.Text = ""
        PicProfile.Image = Nothing
        ProgressBar1.Value = 0
        RegMemberForm_Load(sender, e)
        If btnRegister.Text = "Update" Then
            Me.Close()
        End If
    End Sub

    Private Sub RegMemberForm_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles MyBase.Validating
        Form1.ShowDialog()
    End Sub
End Class