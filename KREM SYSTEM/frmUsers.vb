Imports System.Data.SqlClient
Public Class frmUsers
    Dim con As SqlConnection
    Dim buttonaction As String

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

    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        gbUserDetails.Text = "Add New User"
        buttonaction = "save"
        btnSave.Text = "Save"
        txtusername.Enabled = True
        cbCounter.Enabled = True
        gbUserDetails.Enabled = True
        txtusername.Focus()
    End Sub

    Private Sub frmUsers_Load(sender As Object, e As EventArgs) Handles Me.Load
        gbUserDetails.Enabled = False
        load_users()
        btnDelete.Visible = False
        cbCounter.SelectedIndex = 0
    End Sub
    Private Sub load_users()
        Try

            load_connection()
            Dim cmd As SqlCommand
            Dim rs As SqlDataReader
            Dim qry As String
            Dim userlist As ListViewItem
            Dim count As Integer = 0
            qry = "SELECT * FROM tblusers WHERE userlevel <> 'administrator'"
            cmd = New SqlCommand(qry, con)
            rs = cmd.ExecuteReader
            lvUsers.Items.Clear()
            If rs.HasRows Then

                While rs.Read
                    count += 1
                    userlist = lvUsers.Items.Add(count)
                    userlist.SubItems.Add(rs(0))
                    userlist.SubItems.Add(rs(2))
                    userlist.SubItems.Add(rs(3))
                End While
                gbUsers.Text = "List of Users: " & count
            Else
                gbUsers.Text = "List of Users: 0"
            End If
            rs.Close()
            cmd.Dispose()
            con.Close()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub cbshowpass_CheckedChanged(sender As Object, e As EventArgs) Handles cbshowpass.CheckedChanged
        If cbshowpass.Checked = True Then
            txtpassword.PasswordChar = ""
        Else
            txtpassword.PasswordChar = "*"c
        End If

    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        gbUserDetails.Enabled = False
        txtusername.Text = ""
        txtpassword.Text = ""
        btnDelete.Visible = False
        cbCounter.SelectedIndex = 0
        btnSave.Text = "Save"
        btnAdd.Focus()
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        If buttonaction = "save" Then
            save_user()
        ElseIf buttonaction = "update" Then
            update_password()

        End If
        btnAdd.Focus()
    End Sub
    Private Sub update_password()
        Try
            If txtpassword.Text.Length > 6 Then
                load_connection()
                Dim cmd As SqlCommand
                Dim qry As String
                qry = "UPDATE tblusers SET userpass=@pass WHERE username=@user AND counternumber=@counter"
                cmd = New SqlCommand(qry, con)
                cmd.Parameters.AddWithValue("@user", txtusername.Text)
                cmd.Parameters.AddWithValue("@pass", txtpassword.Text)
                cmd.Parameters.AddWithValue("@counter", cbCounter.Text)
                If cmd.ExecuteNonQuery Then
                    MsgBox("Password updated for user " & txtusername.Text)
                    gbUserDetails.Enabled = False
                    btnSave.Text = "Save"
                    btnDelete.Visible = False
                    txtpassword.Text = ""
                    txtusername.Text = ""
                    cbCounter.SelectedIndex = 0

                    btnSave.Text = "Save"
                End If
                cmd.Dispose()
                con.Close()
            Else
                MsgBox("Password must be at least 6 characters long")
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub save_user()
        If txtusername.Text <> "" Or txtpassword.Text <> "" Then
            If (username_exists(txtusername.Text, cbCounter.Text) = False) Then
                load_connection()
                Try
                    Dim cmd As SqlCommand
                    Dim query As String

                    query = "INSERT INTO tblusers (username,userpass,counternumber,userlevel)  "
                    query &= "VALUES (@user,@pass,@counter,@level) "

                    cmd = New SqlCommand(query, con)

                    cmd.Parameters.AddWithValue("@user", txtusername.Text)
                    cmd.Parameters.AddWithValue("@pass", txtpassword.Text)
                    cmd.Parameters.AddWithValue("@counter", cbCounter.Text)
                    cmd.Parameters.AddWithValue("@level", "counter")

                    If (cmd.ExecuteNonQuery) Then
                        MsgBox("New user created", MsgBoxStyle.Information)
                        txtusername.Text = ""
                        txtpassword.Text = ""
                        gbUserDetails.Enabled = False
                        load_users()
                    End If
                    cmd.Dispose()
                    con.Close()
                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try

            Else
                MsgBox("This username/counter is already taken", MsgBoxStyle.Critical)
            End If

        Else
            MsgBox("Please enter your username and password", MsgBoxStyle.Critical)
        End If
    End Sub


    Public Function username_exists(ByVal user As String, ByVal counter As String) As Boolean
        Dim userex As Boolean = False
        Try
            load_connection()
            Dim cmd As SqlCommand
            Dim query As String
            Dim x As Integer
            query = "SELECT COUNT(*) FROM tblusers WHERE username=@user or counternumber=@counter"
            cmd = New SqlCommand(query, con)
            cmd.Parameters.AddWithValue("@user", user)
            cmd.Parameters.AddWithValue("@counter", counter)
            x = cmd.ExecuteScalar

            If (x > 0) Then
                userex = True
            End If
            cmd.Dispose()
            con.Close()
        Catch ex As Exception
            MsgBox(ex.Message & "err")
        End Try
        Return userex
    End Function

    Private Sub lvUsers_Click(sender As Object, e As EventArgs) Handles lvUsers.Click
        If lvUsers.Items.Count > 0 Then
            Dim user As String
            Dim counterno As String
            user = lvUsers.SelectedItems(0).SubItems(1).Text
            counterno = lvUsers.SelectedItems(0).SubItems(3).Text

            btnSave.Enabled = True
            btnDelete.Visible = True
            txtusername.Text = user
            cbCounter.Text = counterno
            gbUserDetails.Enabled = True
            txtusername.Enabled = False
            cbCounter.Enabled = False
            btnSave.Text = "Update"
            buttonaction = "update"

        End If
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        Try
            Dim x As Integer
            x = MessageBox.Show("Delete this user?", "KREM", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If x = vbYes Then
                load_connection()

                Dim cmd As SqlCommand
                Dim qry As String
                qry = "DELETE FROM tblusers WHERE username=@user AND counternumber=@counter"
                cmd = New SqlCommand(qry, con)
                cmd.Parameters.AddWithValue("@user", txtusername.Text)
                cmd.Parameters.AddWithValue("@counter", cbCounter.Text)
                If (cmd.ExecuteNonQuery) Then
                    MsgBox("User Deleted!", MsgBoxStyle.Information)
                    txtusername.Text = ""
                    txtpassword.Text = ""
                    cbCounter.SelectedIndex = 0
                    gbUserDetails.Enabled = False
                    btnDelete.Visible = False
                    btnSave.Text = "Save"
                    load_users()
                    btnAdd.Focus()
                End If
            End If


        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btnsearch_Click(sender As Object, e As EventArgs) Handles btnsearch.Click
        Try
            If txtsearch.Text.Length > 0 Then

                load_connection()
                Dim cmd As SqlCommand
                Dim rs As SqlDataReader
                Dim qry As String
                Dim userlist As ListViewItem
                Dim count As Integer = 0
                qry = "SELECT * FROM tblusers WHERE userlevel <> 'administrator' AND username LIKE @user"
                cmd = New SqlCommand(qry, con)
                cmd.Parameters.AddWithValue("@user", txtsearch.Text & "%")
                rs = cmd.ExecuteReader
                lvUsers.Items.Clear()
                If rs.HasRows Then

                    While rs.Read
                        count += 1
                        userlist = lvUsers.Items.Add(count)
                        userlist.SubItems.Add(rs(0))
                        userlist.SubItems.Add(rs(2))
                        userlist.SubItems.Add(rs(3))
                    End While
                    gbUsers.Text = "List of Users: " & count
                Else
                    MsgBox("Username not found", MsgBoxStyle.Critical)
                    gbUsers.Text = "List of Users: 0"
                End If
                rs.Close()
                cmd.Dispose()
                con.Close()
            Else
                MsgBox("Enter the username to search", MsgBoxStyle.Critical)
            End If


        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
End Class