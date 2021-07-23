Imports System.Data.SqlClient

Public Class frmapproval
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
    Private Sub login()
        If txtpassword.Text.Length <> 0 Then
            Try
                load_connection()
                Dim cmd As SqlCommand
                Dim qry As String

                qry = "SELECT COUNT(username) FROM tblusers WHERE username='admin' AND userpass=@pass"
                cmd = New SqlCommand(qry, con)
                cmd.Parameters.AddWithValue("@pass", txtpassword.Text.Trim)
                Dim x As Integer
                x = cmd.ExecuteScalar
                If (x = 0) Then
                    MsgBox("Incorrect Password", MsgBoxStyle.Critical)
                    msg = "no"
                Else

                    msg = "yes"
                End If
                cmd.Dispose()
                con.Close()
                Me.Close()
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        Else
            MsgBox("Enter your administrator password", MsgBoxStyle.Critical)
        End If

    End Sub

    Private Sub txtpassword_KeyDown(sender As Object, e As KeyEventArgs) Handles txtpassword.KeyDown
        If e.KeyCode = Keys.Enter Then
            login()

        End If
    End Sub
End Class