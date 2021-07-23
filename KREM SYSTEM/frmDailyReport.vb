Public Class frmDailyReport


    Private Sub frmDailyReport_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            'TODO: This line of code loads data into the 'dataset.dtSenderDetails' table. You can move, or remove it, as needed.

            'TODO: This line of code loads data into the 'dataset.dtDailyReport' table. You can move, or remove it, as needed.
            dataset.EnforceConstraints = False
            dtStart.Value = DateTime.Now.ToString("dd/MM/yyyy")
            Me.dtDailyReportTableAdapter.Fill(Me.dataset.dtDailyReport, DateTime.Now.ToString("yyyy-MM-dd"))
            Me.dtSenderDetailsTableAdapter.Fill(Me.dataset.dtSenderDetails, DateTime.Now.ToString("yyyy-MM-dd"))
            Me.ReportViewer1.RefreshReport()

            Me.ReportViewer2.RefreshReport()
        Catch ex As Exception

            MsgBox("Error:" & ex.Message)

        End Try


    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        Dim startdate As Date
        startdate = dtStart.Value



        If (startdate > DateTime.Now) Then
            MsgBox("The end date is beyond today's date", MsgBoxStyle.Critical)

        Else
            Try
                dataset.EnforceConstraints = False
                Me.dtDailyReportTableAdapter.Fill(Me.dataset.dtDailyReport, startdate.ToString("yyyy-MM-dd"))
                Me.dtSenderDetailsTableAdapter.Fill(Me.dataset.dtSenderDetails, startdate.ToString("yyyy-MM-dd"))
                If dataset.dtDailyReport.Rows.Count = 0 Then

                    MsgBox("There are no results for the date you have selected", MsgBoxStyle.Information)
                Else

                    Me.ReportViewer1.RefreshReport()
                    Me.ReportViewer2.RefreshReport()

                End If
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try





        End If
    End Sub
End Class