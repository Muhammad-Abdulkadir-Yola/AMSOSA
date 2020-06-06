Imports System.IO

Public Class ManageActivitiesForm
    Private Sub btnHome_Click(sender As Object, e As EventArgs) Handles btnHome.Click
        Me.Close()
    End Sub

    Private Sub btnRefresh_Click(sender As Object, e As EventArgs) Handles btnRefresh.Click
        ManageActivitiesForm_Load(sender, e)

    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        ActivityForm.Title.Text = "ADD NEW ACTIVITY"
        ActivityForm.btnSave.Text = "Save"
        ActivityForm.ShowDialog()
    End Sub

    Private Sub ManageActivitiesForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'AlumniDataSet.Activities' table. You can move, or remove it, as needed.
        Me.ActivitiesTableAdapter.Fill(Me.AlumniDataSet.Activities)

    End Sub

    Private Sub txtSearchTitle_KeyUp(sender As Object, e As KeyEventArgs) Handles txtSearchTitle.KeyUp
        If txtSearchTitle.Text <> "" Then
            Me.ActivitiesTableAdapter.FillBySearchTitle(Me.AlumniDataSet.Activities, txtSearchTitle.Text & "%")

        End If
    End Sub

    Private Sub DateTimePickerDate_ValueChanged(sender As Object, e As EventArgs) Handles DateTimePickerDate.ValueChanged
        Me.ActivitiesTableAdapter.FillBySearchDate(Me.AlumniDataSet.Activities, DateTimePickerDate.Text & "%")

    End Sub

    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        Try
            Dim db As New AlumniDataClassesDataContext
            Dim edit = From p In db.Activities
                       Where p.ActivityNum = DataGridView1.CurrentRow.Cells(0).ToString
                       Select p

            With edit.FirstOrDefault
                ActivityForm.txtNum.Text = .ActivityNum
                ActivityForm.txtExpense.Text = .Cost
                ActivityForm.txtExpenseDescription.Text = .CostDescription
                ActivityForm.txtTitle.Text = .Title
                ActivityForm.txtTitleDescription.Text = .Description
                ActivityForm.txtVenue.Text = .Venue
                ActivityForm.DateTimePickerDate.Text = .Date
                Dim img As Byte()
                img = .Picture.ToArray
                Dim ms As New MemoryStream(img)
                ActivityForm.PicActivity.Image = Image.FromStream(ms)
            End With
            ActivityForm.Title.Text = "EDIT"
            ActivityForm.btnSave.Text = "Update"
            ActivityForm.ShowDialog()
        Catch ex As Exception
            MsgBox("Please, select the Activity to edit!", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly)
        End Try
    End Sub

    Private Sub btnView_Click(sender As Object, e As EventArgs) Handles btnView.Click
        Try
            Dim db As New AlumniDataClassesDataContext
            Dim act = From p In db.Activities
                    Where p.ActivityNum = DataGridView1.CurrentRow.Cells(0).Value.ToString
                    Select p

            With act.FirstOrDefault
                ActivityRecord.lblActivityNo.Text = .ActivityNum
            End With
            ActivityRecord.Show()
        Catch ex As Exception
            MsgBox("Please, click on the Activity to view!!!", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly)
            Exit Sub
        End Try
    End Sub
End Class