Public Class staffListView

    Private Sub btnHome_Click(sender As Object, e As EventArgs) Handles btnHome.Click
        Me.Close()

    End Sub

    Private Sub staffListView_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'AlumniDataSet.Staff' table. You can move, or remove it, as needed.
        Me.StaffTableAdapter.Fill(Me.AlumniDataSet.Staff)


        Me.ReportViewer1.RefreshReport()
    End Sub

    
    Private Sub btnRefresh_Click(sender As Object, e As EventArgs) Handles btnRefresh.Click
        staffListView_Load(sender, e)


    End Sub

    Private Sub Title_Click(sender As Object, e As EventArgs) Handles Title.Click

    End Sub
End Class