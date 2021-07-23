Imports System.Data.SqlClient
Public Class AdminDashboard
    Dim con As SqlConnection
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
    Private Sub AdminDashboard_Load(sender As Object, e As EventArgs) Handles Me.Load
        lbldate.Text = "Date:" & DateTime.Now.Day & "/" & DateTime.Now.Month & "/" & DateTime.Now.Year
        load_connection()


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

    Private Sub btnCustomReport_Click(sender As Object, e As EventArgs) Handles btnCustomReport.Click
        close_form()

        change_panel(frmCustomReport)
    End Sub



    Private Sub btndailyreport_Click(sender As Object, e As EventArgs) Handles btndailyreport.Click
        close_form()
        change_panel(frmDailyReport)
    End Sub

    Private Sub btncustomerlist_Click(sender As Object, e As EventArgs) Handles btncustomerlist.Click
        close_form()
        change_panel(frmCustomerList)
    End Sub

    Private Sub BunifuFlatButton3_Click(sender As Object, e As EventArgs) Handles btnRemHistory.Click
        close_form()
        change_panel(frmRemittanceHistory)
    End Sub

    Private Sub btnBlacklist_Click(sender As Object, e As EventArgs) Handles btnBlacklist.Click
        close_form()
        change_panel(frmBlacklist)
    End Sub

    Private Sub btnChangePass_Click(sender As Object, e As EventArgs) Handles btnChangePass.Click
        close_form()
        change_panel(frmChangePassword)
        frmChangePassword.account = "admin"
    End Sub

    Private Sub btnlogout_Click_1(sender As Object, e As EventArgs) Handles btnlogout.Click
        close_form()
        Me.Hide()
        Dim login = New frmLogin
        login.ShowDialog()
        con.Close()
        Me.Close()


    End Sub

    Private Sub btnModifyUser_Click(sender As Object, e As EventArgs) Handles btnModifyUser.Click
        close_form()
        change_panel(frmUsers)
    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        close_form()
        change_panel(frmSearchTransaction)
    End Sub

    Private Sub btnBackupDB_Click(sender As Object, e As EventArgs) Handles btnBackupDB.Click
        load_connection()

        Try
            Dim cmd As SqlCommand
            Dim qry As String
            Dim today As Date


            today = DateTime.Now
            SaveFileDialog1.FileName = "KREM_" & today.ToString("dd-MM-yyyy") & ".bak"
            If (SaveFileDialog1.ShowDialog() = DialogResult.OK) Then
                qry = "BACKUP DATABASE [KREM] TO  DISK = N'" & SaveFileDialog1.FileName & " ' WITH NOFORMAT, NOINIT,  NAME = N'KREM-Full Database Backup', SKIP, NOREWIND, NOUNLOAD,  STATS = 10"
                cmd = New SqlCommand(qry, con)
                If (cmd.ExecuteNonQuery) Then
                    MsgBox("Databased saved")
                End If
            End If

            con.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
End Class