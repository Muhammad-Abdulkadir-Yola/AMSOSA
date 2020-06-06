Public Class ActvityListView

    Private Sub btnHome_Click(sender As Object, e As EventArgs) Handles btnHome.Click
        Me.Close()

    End Sub

    Private Sub ActvityListView_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'AlumniDataSet.Activities' table. You can move, or remove it, as needed.
        Me.ActivitiesTableAdapter.Fill(Me.AlumniDataSet.Activities)

        Me.ReportViewer1.RefreshReport()
    End Sub

    Private Sub btnRefresh_Click(sender As Object, e As EventArgs) Handles btnRefresh.Click
        ActvityListView_Load(sender, e)

    End Sub
End Class