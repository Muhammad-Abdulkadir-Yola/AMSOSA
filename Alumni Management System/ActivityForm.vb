Imports System.IO

Public Class ActivityForm

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnHome.Click
        Close()
    End Sub

    Private Sub btnLoad_Click(sender As Object, e As EventArgs) Handles btnLoad.Click
        With OpenFileDialog1
            .Title = "Select a Jpeg Image"
            .FileName = ""
            .Multiselect = False
            .Filter = "Jpeg Images Only|*.jpg"

            If OpenFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then

                PicActivity.Image = Image.FromFile(.FileName)

            End If
            Dim ms As New MemoryStream
            PicActivity.Image.Save(ms, PicActivity.Image.RawFormat)

        End With
    End Sub

    Private Sub btnClearPic_Click(sender As Object, e As EventArgs) Handles btnClearPic.Click
        PictureBox2.Image = Nothing
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtExpense.Clear()
        txtExpenseDescription.Clear()
        txtTitle.Clear()
        txtTitleDescription.Clear()
        txtVenue.Clear()
        DateTimePickerDate.Value = Today
        PictureBox2.Image = Nothing
        ActivityForm_Load(sender, e)
    End Sub

    Private Sub ActivityForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim db As New AlumniDataClassesDataContext
        Dim ActNo = 1
        Dim Acts = From p In db.Activities
                 Select p Order By p.ID Ascending

        If Acts.Count <> 0 Then
            For j = 1 To Acts.Count
                ActNo += 1
            Next
        End If
        txtNum.Text = ActNo

    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Try
            Dim ms As New MemoryStream
            PicActivity.Image.Save(ms, PicActivity.Image.RawFormat)
        Catch ex As Exception
            MsgBox("A picture is required, Please load it!!!", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly)
            Exit Sub
        End Try
        If txtTitle.Text = "" Or txtExpense.Text = "" Or txtExpenseDescription.Text = "" Or txtTitleDescription.Text = "" Or txtVenue.Text = "" Then
            MsgBox("All fields are required!!!", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly)
            Exit Sub
        End If
        If Me.btnSave.Text = "Save" Then
            Dim db As New AlumniDataClassesDataContext
            Dim Act = From p In db.Activities
                         Where p.Title = txtTitle.Text
                         Select p

            If Act.Count <> 0 Then
                MsgBox("Activity with the same 'Title' exist", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly)
                Exit Sub
            End If
        End If
        Me.btnClear.Enabled = False
        Me.btnSave.Enabled = False
        ProgressBar1.Visible = True
        lblPleaseWait.Visible = True
        Timer1.Start()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        ProgressBar1.Increment(5)
        If ProgressBar1.Value = 100 Then
            Dim db As New AlumniDataClassesDataContext
            If Me.btnSave.Text = "Save" Then
                Dim ms As New MemoryStream
                PicActivity.Image.Save(ms, PicActivity.Image.RawFormat)
                Dim img() As Byte
                img = ms.ToArray

                Dim NewAc As New Activity With {.Title = txtTitle.Text, .ActivityNum = txtNum.Text, .Cost = txtExpense.Text, .CostDescription = txtExpenseDescription.Text, .Date = DateTimePickerDate.Text, .Description = txtTitleDescription.Text, .Venue = txtVenue.Text, .Picture = img}
                db.Activities.InsertOnSubmit(NewAc)
                db.SubmitChanges()
                Timer1.Stop()
                MsgBox("Activity succesfully added!!!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly)
                btnClear_Click(sender, e)
                ProgressBar1.Value = 0
                Timer1.Stop()
                Me.btnClear.Enabled = True
                Me.btnSave.Enabled = True
                ProgressBar1.Visible = False
                lblPleaseWait.Visible = False

            ElseIf Me.btnSave.Text = "Update" Then
                Dim EditAc = From p In db.Activities
                             Where p.ActivityNum = txtNum.Text
                             Select p

                With EditAc.FirstOrDefault
                    .Cost = txtExpense.Text
                    .CostDescription = txtExpenseDescription.Text
                    .Date = DateTimePickerDate.Text
                    .Description = txtTitleDescription.Text
                    .Title = txtTitle.Text
                    .Venue = txtVenue.Text
                    Dim ms As New MemoryStream
                    PicActivity.Image.Save(ms, PicActivity.Image.RawFormat)
                    Dim img As Byte()
                    img = ms.ToArray
                    .Picture = img
                End With
                db.SubmitChanges()
                MsgBox("Update succesful!!!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly)
                Timer1.Stop()
                Me.btnClear.Enabled = True
                Me.btnSave.Enabled = True
                ProgressBar1.Visible = False
                lblPleaseWait.Visible = False
                ProgressBar1.Value = 0
                btnClear_Click(sender, e)
            End If
            Timer1.Stop()
            btnClear_Click(sender, e)
        End If

    End Sub
End Class