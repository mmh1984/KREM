Public Class frmLogin
    Private Sub PictureBox1_Click(sender As Object, e As EventArgs)
        Me.Close()

    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Application.Exit()

    End Sub

    Private Sub btnloginasadmin_Click(sender As Object, e As EventArgs) Handles btnloginasadmin.Click
        Dim admindialog = New frmAdminPassword
        admindialog.ShowDialog()


        If (admindialog.msg = "yes") Then
            MsgBox("Login Accepted", MsgBoxStyle.Information)
            Me.Hide()
            Dim admindashboard = New AdminDashboard
            admindashboard.ShowDialog()

            Me.Close()
        End If

    End Sub

    Private Sub btnlogincounter_Click(sender As Object, e As EventArgs) Handles btnlogincounter.Click
        Dim counterdialog = New frmcounterlogin
        counterdialog.ShowDialog()


        If (counterdialog.msg = "yes") Then
            MsgBox("Login Accepted", MsgBoxStyle.Information)
            Me.Hide()
            Dim counterdashboard = New CounterDashboard
            counterdashboard.ShowDialog()

            Me.Close()
        End If
    End Sub
End Class
