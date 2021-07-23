Public Class frmPrint
    Private Sub frmPrint_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'dataset.dtReceiptTransaction' table. You can move, or remove it, as needed.
        Me.dtReceiptTransactionTableAdapter.Fill(Me.dataset.dtReceiptTransaction, CounterDashboard.counterno)
        Me.ReportViewer1.RefreshReport()
    End Sub
End Class