Public Class frmCustomReport
    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        Try


            Dim startdate As Date
            Dim enddate As Date
            startdate = dtStart.Value
            enddate = dtEnd.Value


            If (enddate > DateTime.Now) Then
                MsgBox("The end date is beyond today's date", MsgBoxStyle.Critical)
            ElseIf (enddate = DateTime.Now) Then
                MsgBox("The end date is the same as today's date", MsgBoxStyle.Critical)
            Else
                If (DateDiff("d", startdate, enddate) > 0) Then
                    dataset.EnforceConstraints = False
                    Me.dtCustomReportTableAdapter.Fill(Me.dataset.dtCustomReport, startdate.ToString("yyyy-MM-dd"), enddate.ToString("yyyy-MM-dd"))

                    If dataset.dtCustomReport.Rows.Count = 0 Then

                        MsgBox("There are no results for the date you have selected", MsgBoxStyle.Information)
                    Else
                        Me.dtSenderDetailsCustomTableAdapter.Fill(Me.dataset.dtSenderDetailsCustom, startdate.ToString("yyyy-MM-dd"), enddate.ToString("yyyy-MM-dd"))
                        Me.ReportViewer1.RefreshReport()
                        Me.ReportViewer2.RefreshReport()
                    End If

                Else
                    MsgBox("End date must be later than start date", MsgBoxStyle.Exclamation)
                End If
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try






    End Sub

    Private Sub frmCustomReport_Load(sender As Object, e As EventArgs) Handles Me.Load
        'TODO: This line of code loads data into the 'dataset.dtSenderDetailsCustom' table. You can move, or remove it, as needed.

        dtEnd.Value = DateTime.Now.ToString("dd/MM/yyyy")

    End Sub

    Private Sub GunaImageButton1_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()

    End Sub

    Private Sub ReportViewer1_Load(sender As Object, e As EventArgs) 

    End Sub
End Class