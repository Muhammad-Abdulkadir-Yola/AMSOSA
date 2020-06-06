Public Class StaffRecordViewForm

    Private Sub StaffRecordViewForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'AlumniDataSet.Staff' table. You can move, or remove it, as needed.
        Me.StaffTableAdapter.Fill(Me.AlumniDataSet.Staff)
        'TODO: This line of code loads data into the 'AlumniDataSet.Member' table. You can move, or remove it, as needed.
        'Me.MemberTableAdapter.Fill(Me.AlumniDataSet.Member)

        'Me.ReportViewer1.RefreshReport()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Me.StaffTableAdapter.FillByStaffNo(Me.AlumniDataSet.Staff, txtStaffNo.Text)

        ReportViewer1.RefreshReport()
    End Sub

    Private Sub btnHome_Click(sender As Object, e As EventArgs) Handles btnHome.Click
        Me.Close()

    End Sub
End Class