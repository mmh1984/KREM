Imports System.Data.SqlClient

Public Class CounterDashboard
    Dim con As SqlConnection
    Public Shared counterno As String  'change
    Public Shared countername As String 'change
    Public Sub load_connection()
        Try
            Dim connect As Database
            Dim getpath As String = ""
            connect = New Database

            getpath = connect.get_connection
            con = New SqlConnection(getpath)
            con.Open()



        Catch ex As Exception
            MsgBox(ex.Message & "error")
        End Try
    End Sub
    Private Sub CounterDashboard_Load(sender As Object, e As EventArgs) Handles Me.Load
        load_connection()
        lbluser.Text = countername
        lblcounterno.Text = "Counter:" & counterno
        lbldate.Text = "Date:" & DateTime.Now.Day & "/" & DateTime.Now.Month & "/" & DateTime.Now.Year
        change_panel(frmRemittance)

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        lbltime.Text = DateTime.Now.ToString("hh:mm:ss tt")
    End Sub

    Private Sub close_form()
        con.Close()

        For Each f In mainpanel.Controls.OfType(Of Form).ToList
            f.Close()
        Next
    End Sub
    Private Sub change_panel(ByVal form As Form)


        With form

            .TopLevel = False
            mainpanel.Controls.Clear()
            mainpanel.Controls.Add(form)
            .BringToFront()
            .WindowState = FormWindowState.Maximized
            mainpanel.AutoScroll = True

            .Show()
        End With

    End Sub

    Private Sub btnRemHistory_Click(sender As Object, e As EventArgs) Handles btnRemHistory.Click
        close_form()
        change_panel(frmRemittance)
    End Sub

    Private Sub BunifuFlatButton1_Click(sender As Object, e As EventArgs) Handles BunifuFlatButton1.Click
        close_form()
        change_panel(frmnewSender)
    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        close_form()
        change_panel(frmCustomerList)
    End Sub

    Private Sub btnCustomReport_Click(sender As Object, e As EventArgs) Handles btnCustomReport.Click
        close_form()
        change_panel(frmCustomReport)
    End Sub

    Private Sub btndailyreport_Click(sender As Object, e As EventArgs) Handles btndailyreport.Click
        close_form()
        change_panel(frmDailyReport)
    End Sub

    Private Sub btnChangePass_Click(sender As Object, e As EventArgs) Handles btnChangePass.Click
        close_form()
        change_panel(frmChangePassword)
        frmChangePassword.account = countername
    End Sub

    Private Sub btnlogout_Click(sender As Object, e As EventArgs) Handles btnlogout.Click
        close_form()
        Me.Hide()
        Dim login = New frmLogin
        login.ShowDialog()

        con.Close()
        Me.Close()


    End Sub
End Class