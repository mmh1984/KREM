Public Class frmPrintReceipt
    Public receiptno As String
    Private Sub frmPrintReceipt_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'dataset.dtReceipt' table. You can move, or remove it, as needed.
        Me.dtReceiptTableAdapter.Fill(Me.dataset.dtReceipt, receiptno)

        Me.ReportViewer1.RefreshReport()
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click

    End Sub
End Class