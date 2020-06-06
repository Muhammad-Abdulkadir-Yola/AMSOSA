Public Class membersHistoryViewForm


    Private Sub btnHome_Click(sender As Object, e As EventArgs) Handles btnHome.Click
        Me.Close()

    End Sub

    Private Sub membersHistoryViewForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'AlumniDataSet.Member' table. You can move, or remove it, as needed.
        Me.MemberTableAdapter.Fill(Me.AlumniDataSet.Member)
        'TODO: This line of code loads data into the 'AlumniDataSet.Member' table. You can move, or remove it, as needed.
        
        Me.ReportViewer1.RefreshReport()
    End Sub

    Private Sub btnRefresh_Click(sender As Object, e As EventArgs) Handles btnRefresh.Click
        If cboChapter.Text = "" Then
            Me.MemberTableAdapter.Fill(Me.AlumniDataSet.Member)

            Me.ReportViewer1.RefreshReport()
        Else
            Me.MemberTableAdapter.FillByChapter(Me.AlumniDataSet.Member, cboChapter.Text)

            Me.ReportViewer1.RefreshReport()
        End If
        
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked Then
            cboChapter.Text = ""
            cboChapter.Enabled = False
        Else
            cboChapter.Enabled = True
        End If
    End Sub
End Class