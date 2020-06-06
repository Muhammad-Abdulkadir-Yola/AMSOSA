Public Class ActivityRecord

    Private Sub lblRegNo_Click(sender As Object, e As EventArgs) Handles lblActivityNo.Click

    End Sub

    Private Sub ActivityRecord_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'AlumniDataSet.Activities' table. You can move, or remove it, as needed.
        
    End Sub

    Private Sub btnRefresh_Click(sender As Object, e As EventArgs) Handles btnRefresh.Click
        Me.ActivitiesTableAdapter.FillByActivityNo(Me.AlumniDataSet.Activities, lblActivityNo.Text)

        Me.ReportViewer1.RefreshReport()
    End Sub

    Private Sub btnHome_Click(sender As Object, e As EventArgs) Handles btnHome.Click
        Me.Close()

    End Sub
End Class