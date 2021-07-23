Public Class frmRemittanceReport

    Private Sub frmRemittanceReport_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Public Sub load_report(ByVal ic As String)
        ReportViewer2.Visible = False
        ReportViewer2.Dock = DockStyle.None
        ReportViewer1.Visible = True
            ReportViewer1.Dock = DockStyle.Fill
            Me.dtRemittanceHistoryTableAdapter.Fill(Me.dataset.dtRemittanceHistory, ic)

            Me.ReportViewer1.RefreshReport()

    End Sub

    Public Sub load_report2(ByVal ic As String, ByVal dStart As String, ByVal dEnd As String)
        ReportViewer1.Visible = False
        ReportViewer1.Dock = DockStyle.None
        ReportViewer2.Visible = True
        ReportViewer2.Dock = DockStyle.Fill
        'TODO: This line of code loads data into the 'dataset.dtRemittanceHistoryRange' table. You can move, or remove it, as needed.
        Me.dtRemittanceHistoryRangeTableAdapter.Fill(Me.dataset.dtRemittanceHistoryRange, ic, dStart, dEnd)
        'TODO: This line of code loads data into the 'dataset.dtRemittanceHistory' table. You can move, or remove it, as needed.

        Me.ReportViewer2.RefreshReport()
    End Sub
End Class