Imports System.IO

Public Class ManageStaffForm
    Private Sub btnHome_Click(sender As Object, e As EventArgs) Handles btnHome.Click
        Close()
    End Sub

    Private Sub txtSearchName_KeyUp(sender As Object, e As KeyEventArgs) Handles txtSearchName.KeyUp
        If txtSearchName.Text <> "" Then
            Me.StaffTableAdapter.FillBySearchFullname(Me.AlumniDataSet.Staff, txtSearchName.Text & "%")
        End If
    End Sub

    Private Sub ManageStaffForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ''TODO: This line of code loads data into the 'AlumniDataSet1.Staff' table. You can move, or remove it, as needed.
        'Me.StaffTableAdapter.Fill(Me.AlumniDataSet1.Staff)
        'TODO: This line of code loads data into the 'AlumniDataSet.Staff' table. You can move, or remove it, as needed.
        Me.StaffTableAdapter.Fill(Me.AlumniDataSet.Staff)
        Dim db As New AlumniDataClassesDataContext

        Dim Section = From p In db.Sections
                      Select p Order By p.ID Ascending

        cboSection.Items.Clear()
        If Section.Count <> 0 Then
            For j = 1 To Section.Count
                cboSection.Items.Add(Section.ToList(j - 1).Name)
            Next
        End If

        Dim startYear = 2001
        Dim Yrs = Today.Year - startYear
        cboYrAdmit.Items.Clear()
        cboYrExit.Items.Clear()
        For j = 1 To Yrs
            cboYrAdmit.Items.Add(startYear & "/" & startYear + 1)
            cboYrExit.Items.Add(startYear & "/" & startYear + 1)
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

    Private Sub txtStaffNo_KeyUp(sender As Object, e As KeyEventArgs) Handles txtStaffNo.KeyUp
        If txtStaffNo.Text <> "" Then
            Me.StaffTableAdapter.FillBySearchStaffNo(Me.AlumniDataSet.Staff, txtStaffNo.Text & "%")
        End If
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        RegisterStaffForm.Text = "REGISTER AS STAFF"
        RegisterStaffForm.btnRegister.Text = "Register"
        RegisterStaffForm.ShowDialog()

    End Sub

    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        Try
            RegisterStaffForm.Title.Text = "EDIT"
            RegisterStaffForm.btnRegister.Text = "Update"
            Dim db As New AlumniDataClassesDataContext
            Dim editStaff = From p In db.Staffs
                          Where p.StaffNo = DataGridView1.CurrentRow.Cells(1).Value.ToString
                          Select p

            With editStaff.FirstOrDefault
                RegisterStaffForm.txtStaffNo.Text = .StaffNo
                RegisterStaffForm.txtFullname.Text = .Fullname
                RegisterStaffForm.cboGender.Text = .Gender
                RegisterStaffForm.DateTimePickerBirth.Text = .BirthDate
                RegisterStaffForm.cboStatus.Text = .Status
                RegisterStaffForm.cboRank.Text = .Rank
                RegisterStaffForm.cboSection.Text = .Section
                RegisterStaffForm.cboYrAdmit.Text = .YearAdmitted
                RegisterStaffForm.cboYrExited.Text = .YearExited
                RegisterStaffForm.txtPhone.Text = .Phone
                RegisterStaffForm.txtEmail.Text = .Email
                RegisterStaffForm.txtResAddress.Text = .Address
                RegisterStaffForm.cboNationality.Text = .Nationality
                RegisterStaffForm.cboRegion.Text = .Region
                RegisterStaffForm.cboState.Text = .State
                RegisterStaffForm.cboLocalGovt.Text = .LGA
                RegisterStaffForm.txtPassword.Text = .LoginPassword
                RegisterStaffForm.txtWorkPlace.Text = .CurrentWorkplace
                RegisterStaffForm.txtWorkAddress.Text = .WorkAddress
                Dim img As Byte()
                img = .Picture.ToArray
                Dim ms As New MemoryStream(img)
                RegisterStaffForm.PicProfile.Image = Image.FromStream(ms)
                RegisterStaffForm.txtSubjTaught.Text = .SubjectTaught
            End With
            RegisterStaffForm.ShowDialog()
        Catch ex As Exception
            MsgBox("Please, Click on the Staff to Edit", MsgBoxStyle.Information + MsgBoxStyle.OkOnly)
        End Try

    End Sub

    Private Sub btnFilter_Click(sender As Object, e As EventArgs) Handles btnFilter.Click
        Dim db As New AlumniDataClassesDataContext
        If cboStatus.Text <> "" And cboGender.Text <> "" And cboLocalGovt.Text <> "" And cboNationality.Text <> "" And cboRank.Text <> "" And cboRegion.Text <> "" And cboSection.Text <> "" And cboState.Text <> "" And cboYrAdmit.Text <> "" And cboYrExit.Text <> "" Then
            Dim Alllist = From p In db.Staffs
                          Where p.Status = cboStatus.Text And p.Gender = cboGender.Text And p.LGA = cboLocalGovt.Text And p.Nationality = cboNationality.Text And p.Rank = cboRank.Text And p.Region = cboRegion.Text And p.Section = cboSection.Text And p.State = cboState.Text And p.YearAdmitted = cboYrAdmit.Text And p.YearExited = cboYrExit.Text
                          Select p

            Me.DataGridView1.DataSource = Alllist
        ElseIf cboGender.Text <> "" And cboLocalGovt.Text <> "" And cboNationality.Text <> "" And cboRank.Text <> "" And cboRegion.Text <> "" And cboSection.Text <> "" And cboState.Text <> "" And cboYrAdmit.Text <> "" And cboYrExit.Text <> "" Then
            Dim Alllist = From p In db.Staffs
                          Where p.Gender = cboGender.Text And p.LGA = cboLocalGovt.Text And p.Nationality = cboNationality.Text And p.Rank = cboRank.Text And p.Region = cboRegion.Text And p.Section = cboSection.Text And p.State = cboState.Text And p.YearAdmitted = cboYrAdmit.Text And p.YearExited = cboYrExit.Text
                          Select p

            Me.DataGridView1.DataSource = Alllist
        ElseIf cboStatus.Text <> "" And cboLocalGovt.Text <> "" And cboNationality.Text <> "" And cboRank.Text <> "" And cboRegion.Text <> "" And cboSection.Text <> "" And cboState.Text <> "" And cboYrAdmit.Text <> "" And cboYrExit.Text <> "" Then
            Dim Alllist = From p In db.Staffs
                          Where p.Status = cboStatus.Text And p.LGA = cboLocalGovt.Text And p.Nationality = cboNationality.Text And p.Rank = cboRank.Text And p.Region = cboRegion.Text And p.Section = cboSection.Text And p.State = cboState.Text And p.YearAdmitted = cboYrAdmit.Text And p.YearExited = cboYrExit.Text
                          Select p

            Me.DataGridView1.DataSource = Alllist
        ElseIf cboStatus.Text <> "" And cboGender.Text <> "" And cboNationality.Text <> "" And cboRank.Text <> "" And cboRegion.Text <> "" And cboSection.Text <> "" And cboState.Text <> "" And cboYrAdmit.Text <> "" And cboYrExit.Text <> "" Then
            Dim Alllist = From p In db.Staffs
                          Where p.Status = cboStatus.Text And p.Gender = cboGender.Text And p.Nationality = cboNationality.Text And p.Rank = cboRank.Text And p.Region = cboRegion.Text And p.Section = cboSection.Text And p.State = cboState.Text And p.YearAdmitted = cboYrAdmit.Text And p.YearExited = cboYrExit.Text
                          Select p

            Me.DataGridView1.DataSource = Alllist
        ElseIf cboStatus.Text <> "" And cboGender.Text <> "" And cboLocalGovt.Text <> "" And cboRank.Text <> "" And cboRegion.Text <> "" And cboSection.Text <> "" And cboState.Text <> "" And cboYrAdmit.Text <> "" And cboYrExit.Text <> "" Then
            Dim Alllist = From p In db.Staffs
                          Where p.Status = cboStatus.Text And p.Gender = cboGender.Text And p.LGA = cboLocalGovt.Text And p.Rank = cboRank.Text And p.Region = cboRegion.Text And p.Section = cboSection.Text And p.State = cboState.Text And p.YearAdmitted = cboYrAdmit.Text And p.YearExited = cboYrExit.Text
                          Select p

            Me.DataGridView1.DataSource = Alllist
        ElseIf cboStatus.Text <> "" And cboGender.Text <> "" And cboLocalGovt.Text <> "" And cboNationality.Text <> "" And cboRank.Text <> "" And cboRegion.Text <> "" And cboSection.Text <> "" And cboState.Text <> "" And cboYrAdmit.Text <> "" And cboYrExit.Text <> "" Then
            Dim Alllist = From p In db.Staffs
                          Where p.Status = cboStatus.Text And p.Gender = cboGender.Text And p.LGA = cboLocalGovt.Text And p.Nationality = cboNationality.Text And p.Rank = cboRank.Text And p.Region = cboRegion.Text And p.Section = cboSection.Text And p.State = cboState.Text And p.YearAdmitted = cboYrAdmit.Text And p.YearExited = cboYrExit.Text
                          Select p

            Me.DataGridView1.DataSource = Alllist
        ElseIf cboStatus.Text <> "" And cboGender.Text <> "" And cboLocalGovt.Text <> "" And cboNationality.Text <> "" And cboRegion.Text <> "" And cboSection.Text <> "" And cboState.Text <> "" And cboYrAdmit.Text <> "" And cboYrExit.Text <> "" Then
            Dim Alllist = From p In db.Staffs
                          Where p.Status = cboStatus.Text And p.Gender = cboGender.Text And p.LGA = cboLocalGovt.Text And p.Nationality = cboNationality.Text And p.Region = cboRegion.Text And p.Section = cboSection.Text And p.State = cboState.Text And p.YearAdmitted = cboYrAdmit.Text And p.YearExited = cboYrExit.Text
                          Select p

            Me.DataGridView1.DataSource = Alllist
        ElseIf cboStatus.Text <> "" And cboGender.Text <> "" And cboLocalGovt.Text <> "" And cboNationality.Text <> "" And cboRank.Text <> "" And cboSection.Text <> "" And cboState.Text <> "" And cboYrAdmit.Text <> "" And cboYrExit.Text <> "" Then
            Dim Alllist = From p In db.Staffs
                          Where p.Status = cboStatus.Text And p.Gender = cboGender.Text And p.LGA = cboLocalGovt.Text And p.Nationality = cboNationality.Text And p.Rank = cboRank.Text And p.Section = cboSection.Text And p.State = cboState.Text And p.YearAdmitted = cboYrAdmit.Text And p.YearExited = cboYrExit.Text
                          Select p

            Me.DataGridView1.DataSource = Alllist
        ElseIf cboStatus.Text <> "" And cboGender.Text <> "" And cboLocalGovt.Text <> "" And cboNationality.Text <> "" And cboRank.Text <> "" And cboRegion.Text <> "" And cboState.Text <> "" And cboYrAdmit.Text <> "" And cboYrExit.Text <> "" Then
            Dim Alllist = From p In db.Staffs
                          Where p.Status = cboStatus.Text And p.Gender = cboGender.Text And p.LGA = cboLocalGovt.Text And p.Nationality = cboNationality.Text And p.Rank = cboRank.Text And p.Region = cboRegion.Text And p.State = cboState.Text And p.YearAdmitted = cboYrAdmit.Text And p.YearExited = cboYrExit.Text
                          Select p

            Me.DataGridView1.DataSource = Alllist
        ElseIf cboStatus.Text <> "" And cboGender.Text <> "" And cboLocalGovt.Text <> "" And cboNationality.Text <> "" And cboRank.Text <> "" And cboRegion.Text <> "" And cboSection.Text <> "" And cboYrAdmit.Text <> "" And cboYrExit.Text <> "" Then
            Dim Alllist = From p In db.Staffs
                          Where p.Status = cboStatus.Text And p.Gender = cboGender.Text And p.LGA = cboLocalGovt.Text And p.Nationality = cboNationality.Text And p.Rank = cboRank.Text And p.Region = cboRegion.Text And p.Section = cboSection.Text And p.YearAdmitted = cboYrAdmit.Text And p.YearExited = cboYrExit.Text
                          Select p

            Me.DataGridView1.DataSource = Alllist
        ElseIf cboStatus.Text <> "" And cboGender.Text <> "" And cboLocalGovt.Text <> "" And cboNationality.Text <> "" And cboRank.Text <> "" And cboRegion.Text <> "" And cboSection.Text <> "" And cboState.Text <> "" And cboYrExit.Text <> "" Then
            Dim Alllist = From p In db.Staffs
                          Where p.Status = cboStatus.Text And p.Gender = cboGender.Text And p.LGA = cboLocalGovt.Text And p.Nationality = cboNationality.Text And p.Rank = cboRank.Text And p.Region = cboRegion.Text And p.Section = cboSection.Text And p.State = cboState.Text And p.YearExited = cboYrExit.Text
                          Select p

            Me.DataGridView1.DataSource = Alllist
        ElseIf cboStatus.Text <> "" And cboGender.Text <> "" And cboLocalGovt.Text <> "" And cboNationality.Text <> "" And cboRank.Text <> "" And cboRegion.Text <> "" And cboSection.Text <> "" And cboState.Text <> "" And cboYrAdmit.Text <> "" Then
            Dim Alllist = From p In db.Staffs
                          Where p.Status = cboStatus.Text And p.Gender = cboGender.Text And p.LGA = cboLocalGovt.Text And p.Nationality = cboNationality.Text And p.Rank = cboRank.Text And p.Region = cboRegion.Text And p.Section = cboSection.Text And p.State = cboState.Text And p.YearAdmitted = cboYrAdmit.Text
                          Select p

            Me.DataGridView1.DataSource = Alllist
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
        ManageStaffForm_Load(sender, e)
        DataGridView1.DataSource = StaffTableAdapter
        cboGender.Text = ""
        cboLocalGovt.Text = ""
        cboNationality.Text = ""
        cboRank.Text = ""
        cboRegion.Text = ""
        cboSection.Text = ""
        cboState.Text = ""
        cboStatus.Text = ""
        cboYrAdmit.Text = ""
        cboYrExit.Text = ""
        txtStaffNo.Clear()
        txtSearchName.Clear()
    End Sub

    Private Sub btnView_Click(sender As Object, e As EventArgs) Handles btnView.Click
        Try
            Dim db As New AlumniDataClassesDataContext
            Dim staff = From p In db.Staffs
                        Where p.StaffNo = DataGridView1.CurrentRow.Cells(0).Value.ToString
                        Select p

            With staff.FirstOrDefault
                StaffRecordViewForm.txtStaffNo.Text = .StaffNo
            End With
            StaffRecordViewForm.ShowDialog()

        Catch ex As Exception
            MsgBox("Please, click on the staff to view", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly)
            Exit Sub
        End Try
    End Sub
End Class