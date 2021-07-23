Imports System.Data.SqlClient

Public Class frmcounterlogin
    Dim con As SqlConnection
    Public msg As String
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
    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        login()

    End Sub

    Private Sub txtpassword_TextChanged(sender As Object, e As EventArgs) Handles txtpassword.TextChanged

    End Sub

    Private Sub txtpassword_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtpassword.KeyPress

    End Sub

    Private Sub txtpassword_KeyDown(sender As Object, e As KeyEventArgs) Handles txtpassword.KeyDown
        If e.KeyCode = Keys.Enter Then
            login()
        End If
    End Sub
    Private Sub login()
        If txtpassword.Text.Length <> 0 And txtusername.Text.Length <> 0 Then
            Try
                load_connection()
                Dim cmd As SqlCommand
                Dim qry As String

                qry = "SELECT * FROM tblusers WHERE username=@user AND userpass=@pass"
                cmd = New SqlCommand(qry, con)
                cmd.Parameters.AddWithValue("@user", txtusername.Text.Trim)
                cmd.Parameters.AddWithValue("@pass", txtpassword.Text.Trim)
                Dim rs As SqlDataReader
                rs = cmd.ExecuteReader
                If rs.HasRows Then
                    Dim cno As Integer = 0
                    Dim username As String = ""

                    While rs.Read

                        username = rs(0).ToString
                        cno = rs(3)
                    End While
                    CounterDashboard.counterno = cno
                    CounterDashboard.countername = username
                    msg = "yes"
                Else
                    MsgBox("Incorrect username/password", MsgBoxStyle.Critical)
                End If

                rs.Close()
                cmd.Dispose()
                con.Close()
                Me.Close()
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        Else
            MsgBox("Enter your username and password", MsgBoxStyle.Critical)
        End If
    End Sub
End Class