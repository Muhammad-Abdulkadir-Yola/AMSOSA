Imports System.IO

Public Class ManageMembersForm

    Private Sub ManageMembersForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'AlumniDataSet.Member' table. You can move, or remove it, as needed.
        txtRegNo.Text = "AMSOSA/"
        Me.MemberTableAdapter.Fill(Me.AlumniDataSet.Member)

        Dim db As New AlumniDataClassesDataContext

        Dim RankList = From p In db.Ranks
                       Select p Order By p.ID Ascending

        cboRank.Items.Clear()
        If RankList.Count <> 0 Then
            For j = 1 To RankList.Count
                cboRank.Items.Add(RankList.ToList(j - 1).Title)
            Next
        End If

        Dim SectionExitList = From p In db.Sections
                        Select p Order By p.ID Ascending

        cboSectionExit.Items.Clear()
        If SectionExitList.Count <> 0 Then
            For j = 1 To SectionExitList.Count
                cboSectionExit.Items.Add(SectionExitList.ToList(j - 1).Name)
            Next
        End If

        Dim SectionAdmList = From p In db.Sections
                        Select p Order By p.ID Ascending

        cboSectionAdm.Items.Clear()
        If SectionAdmList.Count <> 0 Then
            For j = 1 To SectionAdmList.Count
                cboSectionAdm.Items.Add(SectionAdmList.ToList(j - 1).Name)
            Next
        End If

        Dim startYear = 2001
        Dim Yrs = Today.Year - startYear
        cboYAdmit.Items.Clear()
        cboYExit.Items.Clear()
        For j = 1 To Yrs
            cboYAdmit.Items.Add(startYear & "/" & startYear + 1)
            cboYExit.Items.Add(startYear & "/" & startYear + 1)
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

    Private Sub txtSearchName_KeyUp(sender As Object, e As KeyEventArgs) Handles txtSearchName.KeyUp
        If txtSearchName.Text <> "" Then
            'Me.MemberTableAdapter.FillBySearchName(Me.AlumniDataSet.Member, txtSearchName.Text & "%")

        End If
    End Sub

    Private Sub txtRegNo_KeyUp(sender As Object, e As KeyEventArgs) Handles txtRegNo.KeyUp
        If txtRegNo.Text <> "" Then
            'Me.MemberTableAdapter.FillBySearchRegNo(Me.AlumniDataSet.Member, txtRegNo.Text & "%")

        End If
    End Sub

    Private Sub btnHome_Click(sender As Object, e As EventArgs) Handles btnHome.Click
        Me.Close()
    End Sub

    Private Sub btnFilter_Click(sender As Object, e As EventArgs) Handles btnFilter.Click
        Dim db As New AlumniDataClassesDataContext
        If cboStatus.Text <> "" And cboGender.Text <> "" And cboLocalGovt.Text <> "" And cboNationality.Text <> "" And cboRank.Text <> "" And cboRegion.Text <> "" And cboSectionAdm.Text <> "" And cboSectionExit.Text <> "" And cboState.Text <> "" And cboYAdmit.Text <> "" And cboYExit.Text <> "" Then
            Dim Alllist = From p In db.Members
                          Where p.Status = cboStatus.Text And p.Gender = cboGender.Text And p.LGA = cboLocalGovt.Text And p.Nationality = cboNationality.Text And p.Rank = cboRank.Text And p.Region = cboRegion.Text And p.SectionAdmitted = cboSectionAdm.Text And p.SectionExited = cboSectionExit.Text And p.State = cboState.Text And p.YearAdmitted = cboYAdmit.Text And p.YearExited = cboYExit.Text
                          Select p

            Me.DataGridViewMembers.DataSource = Alllist

        ElseIf cboStatus.Text = "" And cboGender.Text <> "" And cboLocalGovt.Text <> "" And cboNationality.Text <> "" And cboRank.Text <> "" And cboRegion.Text <> "" And cboSectionAdm.Text <> "" And cboSectionExit.Text <> "" And cboState.Text <> "" And cboYAdmit.Text <> "" And cboYExit.Text <> "" Then
            Dim Alllist = From p In db.Members
                          Where p.Gender = cboGender.Text And p.LGA = cboLocalGovt.Text And p.Nationality = cboNationality.Text And p.Rank = cboRank.Text And p.Region = cboRegion.Text And p.SectionAdmitted = cboSectionAdm.Text And p.SectionExited = cboSectionExit.Text And p.State = cboState.Text And p.YearAdmitted = cboYAdmit.Text And p.YearExited = cboYExit.Text
                          Select p

            Me.DataGridViewMembers.DataSource = Alllist

        ElseIf cboStatus.Text <> "" And cboGender.Text = "" And cboLocalGovt.Text <> "" And cboNationality.Text <> "" And cboRank.Text <> "" And cboRegion.Text <> "" And cboSectionAdm.Text <> "" And cboSectionExit.Text <> "" And cboState.Text <> "" And cboYAdmit.Text <> "" And cboYExit.Text <> "" Then
            Dim Alllist = From p In db.Members
                          Where p.Status = cboStatus.Text And p.LGA = cboLocalGovt.Text And p.Nationality = cboNationality.Text And p.Rank = cboRank.Text And p.Region = cboRegion.Text And p.SectionAdmitted = cboSectionAdm.Text And p.SectionExited = cboSectionExit.Text And p.State = cboState.Text And p.YearAdmitted = cboYAdmit.Text And p.YearExited = cboYExit.Text
                          Select p

            Me.DataGridViewMembers.DataSource = Alllist

        ElseIf cboStatus.Text <> "" And cboGender.Text <> "" And cboLocalGovt.Text = "" And cboNationality.Text <> "" And cboRank.Text <> "" And cboRegion.Text <> "" And cboSectionAdm.Text <> "" And cboSectionExit.Text <> "" And cboState.Text <> "" And cboYAdmit.Text <> "" And cboYExit.Text <> "" Then
            Dim Alllist = From p In db.Members
                          Where p.Status = cboStatus.Text And p.Gender = cboGender.Text And p.Nationality = cboNationality.Text And p.Rank = cboRank.Text And p.Region = cboRegion.Text And p.SectionAdmitted = cboSectionAdm.Text And p.SectionExited = cboSectionExit.Text And p.State = cboState.Text And p.YearAdmitted = cboYAdmit.Text And p.YearExited = cboYExit.Text
                          Select p

            Me.DataGridViewMembers.DataSource = Alllist

        ElseIf cboStatus.Text <> "" And cboGender.Text <> "" And cboLocalGovt.Text <> "" And cboNationality.Text = "" And cboRank.Text <> "" And cboRegion.Text <> "" And cboSectionAdm.Text <> "" And cboSectionExit.Text <> "" And cboState.Text <> "" And cboYAdmit.Text <> "" And cboYExit.Text <> "" Then
            Dim Alllist = From p In db.Members
                          Where p.Status = cboStatus.Text And p.Gender = cboGender.Text And p.LGA = cboLocalGovt.Text And p.Rank = cboRank.Text And p.Region = cboRegion.Text And p.SectionAdmitted = cboSectionAdm.Text And p.SectionExited = cboSectionExit.Text And p.State = cboState.Text And p.YearAdmitted = cboYAdmit.Text And p.YearExited = cboYExit.Text
                          Select p

            Me.DataGridViewMembers.DataSource = Alllist

        ElseIf cboStatus.Text <> "" And cboGender.Text <> "" And cboLocalGovt.Text <> "" And cboNationality.Text <> "" And cboRank.Text = "" And cboRegion.Text <> "" And cboSectionAdm.Text <> "" And cboSectionExit.Text <> "" And cboState.Text <> "" And cboYAdmit.Text <> "" And cboYExit.Text <> "" Then
            Dim Alllist = From p In db.Members
                          Where p.Status = cboStatus.Text And p.Gender = cboGender.Text And p.LGA = cboLocalGovt.Text And p.Nationality = cboNationality.Text And p.Region = cboRegion.Text And p.SectionAdmitted = cboSectionAdm.Text And p.SectionExited = cboSectionExit.Text And p.State = cboState.Text And p.YearAdmitted = cboYAdmit.Text And p.YearExited = cboYExit.Text
                          Select p

            Me.DataGridViewMembers.DataSource = Alllist

        ElseIf cboStatus.Text <> "" And cboGender.Text <> "" And cboLocalGovt.Text <> "" And cboNationality.Text <> "" And cboRank.Text <> "" And cboRegion.Text = "" And cboSectionAdm.Text <> "" And cboSectionExit.Text <> "" And cboState.Text <> "" And cboYAdmit.Text <> "" And cboYExit.Text <> "" Then
            Dim Alllist = From p In db.Members
                          Where p.Status = cboStatus.Text And p.Gender = cboGender.Text And p.LGA = cboLocalGovt.Text And p.Nationality = cboNationality.Text And p.Rank = cboRank.Text And p.SectionAdmitted = cboSectionAdm.Text And p.SectionExited = cboSectionExit.Text And p.State = cboState.Text And p.YearAdmitted = cboYAdmit.Text And p.YearExited = cboYExit.Text
                          Select p

            Me.DataGridViewMembers.DataSource = Alllist

        ElseIf cboStatus.Text <> "" And cboGender.Text <> "" And cboLocalGovt.Text <> "" And cboNationality.Text <> "" And cboRank.Text <> "" And cboRegion.Text <> "" And cboSectionAdm.Text = "" And cboSectionExit.Text <> "" And cboState.Text <> "" And cboYAdmit.Text <> "" And cboYExit.Text <> "" Then
            Dim Alllist = From p In db.Members
                          Where p.Status = cboStatus.Text And p.Gender = cboGender.Text And p.LGA = cboLocalGovt.Text And p.Nationality = cboNationality.Text And p.Rank = cboRank.Text And p.Region = cboRegion.Text And p.SectionExited = cboSectionExit.Text And p.State = cboState.Text And p.YearAdmitted = cboYAdmit.Text And p.YearExited = cboYExit.Text
                          Select p

            Me.DataGridViewMembers.DataSource = Alllist

        ElseIf cboStatus.Text <> "" And cboGender.Text <> "" And cboLocalGovt.Text <> "" And cboNationality.Text <> "" And cboRank.Text <> "" And cboRegion.Text <> "" And cboSectionAdm.Text <> "" And cboSectionExit.Text = "" And cboState.Text <> "" And cboYAdmit.Text <> "" And cboYExit.Text <> "" Then
            Dim Alllist = From p In db.Members
                          Where p.Status = cboStatus.Text And p.Gender = cboGender.Text And p.LGA = cboLocalGovt.Text And p.Nationality = cboNationality.Text And p.Rank = cboRank.Text And p.Region = cboRegion.Text And p.SectionAdmitted = cboSectionAdm.Text And p.State = cboState.Text And p.YearAdmitted = cboYAdmit.Text And p.YearExited = cboYExit.Text
                          Select p

            Me.DataGridViewMembers.DataSource = Alllist

        ElseIf cboStatus.Text <> "" And cboGender.Text <> "" And cboLocalGovt.Text <> "" And cboNationality.Text <> "" And cboRank.Text <> "" And cboRegion.Text <> "" And cboSectionAdm.Text <> "" And cboSectionExit.Text <> "" And cboState.Text = "" And cboYAdmit.Text <> "" And cboYExit.Text <> "" Then
            Dim Alllist = From p In db.Members
                          Where p.Status = cboStatus.Text And p.Gender = cboGender.Text And p.LGA = cboLocalGovt.Text And p.Nationality = cboNationality.Text And p.Rank = cboRank.Text And p.Region = cboRegion.Text And p.SectionAdmitted = cboSectionAdm.Text And p.SectionExited = cboSectionExit.Text And p.YearAdmitted = cboYAdmit.Text And p.YearExited = cboYExit.Text
                          Select p

            Me.DataGridViewMembers.DataSource = Alllist

        ElseIf cboStatus.Text <> "" And cboGender.Text <> "" And cboLocalGovt.Text <> "" And cboNationality.Text <> "" And cboRank.Text <> "" And cboRegion.Text <> "" And cboSectionAdm.Text <> "" And cboSectionExit.Text <> "" And cboState.Text <> "" And cboYAdmit.Text <> "" And cboYExit.Text <> "" Then
            Dim Alllist = From p In db.Members
                          Where p.Status = cboStatus.Text And p.Gender = cboGender.Text And p.LGA = cboLocalGovt.Text And p.Nationality = cboNationality.Text And p.Rank = cboRank.Text And p.Region = cboRegion.Text And p.SectionAdmitted = cboSectionAdm.Text And p.SectionExited = cboSectionExit.Text And p.State = cboState.Text And p.YearAdmitted = cboYAdmit.Text And p.YearExited = cboYExit.Text
                          Select p

            Me.DataGridViewMembers.DataSource = Alllist

        ElseIf cboStatus.Text <> "" And cboGender.Text <> "" And cboLocalGovt.Text <> "" And cboNationality.Text <> "" And cboRank.Text <> "" And cboRegion.Text <> "" And cboSectionAdm.Text <> "" And cboSectionExit.Text <> "" And cboState.Text <> "" And cboStatus.Text <> "" And cboYAdmit.Text = "" And cboYExit.Text <> "" Then
            Dim Alllist = From p In db.Members
                          Where p.Status = cboStatus.Text And p.Gender = cboGender.Text And p.LGA = cboLocalGovt.Text And p.Nationality = cboNationality.Text And p.Rank = cboRank.Text And p.Region = cboRegion.Text And p.SectionAdmitted = cboSectionAdm.Text And p.SectionExited = cboSectionExit.Text And p.State = cboState.Text And p.Status = cboStatus.Text And p.YearExited = cboYExit.Text
                          Select p

            Me.DataGridViewMembers.DataSource = Alllist

        ElseIf cboStatus.Text <> "" And cboGender.Text <> "" And cboLocalGovt.Text <> "" And cboNationality.Text <> "" And cboRank.Text <> "" And cboRegion.Text <> "" And cboSectionAdm.Text <> "" And cboSectionExit.Text <> "" And cboState.Text <> "" And cboStatus.Text <> "" And cboYAdmit.Text <> "" And cboYExit.Text = "" Then
            Dim Alllist = From p In db.Members
                          Where p.Status = cboStatus.Text And p.Gender = cboGender.Text And p.LGA = cboLocalGovt.Text And p.Nationality = cboNationality.Text And p.Rank = cboRank.Text And p.Region = cboRegion.Text And p.SectionAdmitted = cboSectionAdm.Text And p.SectionExited = cboSectionExit.Text And p.State = cboState.Text And p.Status = cboStatus.Text And p.YearAdmitted = cboYAdmit.Text
                          Select p

            Me.DataGridViewMembers.DataSource = Alllist
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

    Private Sub btnRefresh_Click(sender As Object, e As EventArgs) Handles btnRefresh.Click
        cboGender.Text = ""
        cboLocalGovt.Text = ""
        cboNationality.Text = ""
        cboRank.Text = ""
        cboRegion.Text = ""
        cboSectionAdm.Text = ""
        cboSectionExit.Text = ""
        cboState.Text = ""
        cboStatus.Text = ""
        cboYAdmit.Text = ""
        cboYExit.Text = ""
        txtRegNo.Text = "AMSOSA/"
        txtSearchName.Text = ""
        ManageMembersForm_Load(sender, e)
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        RegMemberForm.ShowDialog()
        RegMemberForm.Title.Text = "REGISTER AS MEMBER"
        RegMemberForm.btnRegister.Text = "Register"
    End Sub

    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        Try
            RegMemberForm.Title.Text = "EDIT"
            RegMemberForm.btnRegister.Text = "Update"
            Dim db As New AlumniDataClassesDataContext
            Dim editMem = From p In db.Members
                          Where p.RegNo = DataGridViewMembers.CurrentRow.Cells(0).Value.ToString
                          Select p

            With editMem.FirstOrDefault
                RegMemberForm.txtRegNo.Text = .RegNo
                RegMemberForm.txtSchRegNo.Text = .SchRegNo
                RegMemberForm.txtFullname.Text = .Fullname
                RegMemberForm.cboGender.Text = .Gender
                RegMemberForm.DateTimePickerBirth.Text = .BirthDate
                RegMemberForm.cboStatus.Text = .Status
                RegMemberForm.cboRank.Text = .Rank
                RegMemberForm.cboSectionAdm.Text = .SectionAdmitted
                RegMemberForm.cboSectionExit.Text = .SectionExited
                RegMemberForm.cboYAdmit.Text = .YearAdmitted
                RegMemberForm.cboYExit.Text = .YearExited
                RegMemberForm.cboCAdmit.Text = .ClassAdmitted
                RegMemberForm.cboCExit.Text = .ClassExited
                RegMemberForm.cboPrefect.Text = .Prefect
                RegMemberForm.cboMSS.Text = .MSS
                RegMemberForm.txtPhone.Text = .Phone
                RegMemberForm.txtEmail.Text = .Email
                RegMemberForm.txtRAddress.Text = .Address
                RegMemberForm.cboNationality.Text = .Nationality
                RegMemberForm.cboRegion.Text = .Region
                RegMemberForm.cboState.Text = .State
                RegMemberForm.cboLGA.Text = .LGA
                RegMemberForm.txtPassword.Text = .LoginPassword
                RegMemberForm.txtSchool.Text = .PresentSch
                RegMemberForm.txtWork.Text = .WorkPlace
                RegMemberForm.txtWAddress.Text = .WorkAddress
                Dim img As Byte()
                img = .Picture.ToArray
                Dim ms As New MemoryStream(img)
                RegMemberForm.PicProfile.Image = Image.FromStream(ms)
            End With
            RegMemberForm.ShowDialog()
        Catch ex As Exception
            MsgBox("Please, Click on the member to Edit", MsgBoxStyle.Information + MsgBoxStyle.OkOnly)
        End Try
    End Sub

    Private Sub btnView_Click(sender As Object, e As EventArgs) Handles btnView.Click
        'Try
        '    Dim db As New AlumniDataClassesDataContext
        '    Dim mem = From p In db.Members
        '              Where p.RegNo = Me.DataGridViewMembers.CurrentRow.Cells(0).Value.ToString
        '              Select p

        '    With mem.FirstOrDefault
        '        MemberReportView.lblRegNo.Text = .RegNo
        '    End With
        'Catch ex As Exception
        '    MsgBox("Please, click on the member to view!!!", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly)
        '    Exit Sub
        'End Try
        'MemberReportView.ShowDialog()
    End Sub
End Class