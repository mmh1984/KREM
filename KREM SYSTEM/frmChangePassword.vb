Imports System.Data.SqlClient

Public Class frmChangePassword
    Public account As String
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
    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
        con.Close()

    End Sub

    Private Sub cbshowpass_CheckedChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()

    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        If (txtnewpass.Text.Length < 6 Or txtconfirmpass.Text.Length < 6) Then
            MsgBox("Password must be at least 6 characters long", MsgBoxStyle.Critical)
        Else
            If (txtnewpass.Text.Trim <> txtconfirmpass.Text.Trim) Then
                MsgBox("Passwords didn't match", MsgBoxStyle.Critical)

            Else
                update_password(account)
            End If
        End If
    End Sub

    Private Sub update_password(ByVal user As String)
        Try

            Dim cmd As SqlCommand
            Dim qry As String
            qry = "UPDATE tblusers SET userpass=@newpass WHERE username=@username"
            cmd = New SqlCommand(qry, con)
            cmd.Parameters.AddWithValue("@newpass", txtnewpass.Text.Trim)
            cmd.Parameters.AddWithValue("@username", account)
            If (cmd.ExecuteNonQuery) Then
                MsgBox("Password successfully updated", MsgBoxStyle.Information)
                cmd.Dispose()

                Me.Close()
            Else
                MsgBox("Error updating password", MsgBoxStyle.Critical)
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub frmChangePassword_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        load_connection()
    End Sub

    Private Sub cbshowpass_CheckedChanged_1(sender As Object, e As EventArgs) Handles cbshowpass.CheckedChanged
        If (cbshowpass.Checked = True) Then
            txtnewpass.PasswordChar = ""
            txtconfirmpass.PasswordChar = ""
        Else
            txtnewpass.PasswordChar = "*"c
            txtconfirmpass.PasswordChar = "*"c
        End If
    End Sub
End Class