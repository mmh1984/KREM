Imports System.Data.SqlClient
Public Class frmBlacklist
    Public accountselected As String
    Dim con As SqlConnection
    Dim totalremittance, totalamount As Double
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
    Private Sub frmBlacklist_Load(sender As Object, e As EventArgs) Handles Me.Load
        load_connection()
        load_accounts()
        load_blacklisted()
        gbRemhistory.Enabled = False
        txtsearch.Focus()
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
        con.Close()
    End Sub

    Private Sub load_accounts()
        Try

            Dim cmd As SqlCommand
            Dim qry As String
            Dim rs As SqlDataReader
            Dim lvacc As ListViewItem
            If (txtsearch.Text.Length = 0) Then
                qry = "SELECT DISTINCT TOP 100 accountno,receiver,bank,branch FROM tbltransaction ORDER BY accountno "
            Else
                qry = "SELECT DISTINCT TOP 100 accountno,receiver,bank,branch FROM tbltransaction,tblblacc WHERE receiver LIKE @accno"
            End If

            cmd = New SqlCommand(qry, con)
            cmd.Parameters.AddWithValue("@accno", txtsearch.Text.Trim & "%")
            rs = cmd.ExecuteReader
            lvaccounts.Items.Clear()
            If (rs.HasRows) Then

                While rs.Read
                    lvacc = lvaccounts.Items.Add(rs(0))
                    lvacc.SubItems.Add(rs(1))
                    lvacc.SubItems.Add(rs(2))
                    lvacc.SubItems.Add(rs(3))


                End While

            End If

            cmd.Dispose()
            rs.Close()


        Catch ex As Exception
            MsgBox("Load Error:" & ex.Message)
        End Try
    End Sub

    Private Sub txtsearch_TextChanged(sender As Object, e As EventArgs) Handles txtsearch.TextChanged
        load_accounts()

    End Sub

    Private Sub load_blacklisted()
        Try


            Dim cmd As SqlCommand
            Dim qry As String
            Dim rs As SqlDataReader
            Dim lvbl As ListViewItem
            If (txtsearch1.Text.Length = 0) Then
                qry = "SELECT TOP 100 accno,reason,datemodified FROM tblblacc"
            Else
                qry = "SELECT TOP 100 accno,reason,datemodified FROM tblblacc WHERE accno LIKE @accno"
            End If

            cmd = New SqlCommand(qry, con)
            cmd.Parameters.AddWithValue("@accno", txtsearch1.Text.Trim & "%")
            rs = cmd.ExecuteReader
            lvblacklist.Items.Clear()
            If (rs.HasRows) Then

                While rs.Read
                    lvbl = lvblacklist.Items.Add(rs(0))
                    lvbl.SubItems.Add(rs(1))
                    lvbl.SubItems.Add(rs(2))


                End While
            Else

            End If

            cmd.Dispose()
            rs.Close()


        Catch ex As Exception
            MsgBox("Load Error:" & ex.Message)
        End Try
    End Sub

    Private Sub btnblacklist_Click(sender As Object, e As EventArgs) Handles btnblacklist.Click
        Try
            If (txtreason.Text.Length > 0) Then

                Dim cmd As SqlCommand
                Dim qry As String

                If (check_acc()) Then
                    MsgBox("This account is already in the blacklisted account.", MsgBoxStyle.Critical)

                Else
                    Dim datemodified As Date
                    datemodified = DateTime.Now
                    qry = "INSERT INTO tblblacc (accno,accstatus,reason,datemodified) VALUES (@accno,@status,@reason,@datemodified)"
                    cmd = New SqlCommand(qry, con)
                    cmd.Parameters.AddWithValue("@accno", accountselected)
                    cmd.Parameters.AddWithValue("@status", "BLACKLISTED")
                    cmd.Parameters.AddWithValue("@reason", txtreason.Text)
                    cmd.Parameters.AddWithValue("@datemodified", datemodified.ToString("yyyy-MM-dd"))
                    If (cmd.ExecuteNonQuery) Then
                        MsgBox("This account is added to the blacklisted accounts", MsgBoxStyle.Information)
                        load_blacklisted()
                        txtreason.Text = ""
                        gbRemhistory.Enabled = False

                    Else
                        MsgBox("Error")
                    End If

                End If
            Else
                MsgBox("Enter the reason for this account to be blacklisted", MsgBoxStyle.Information)
            End If



        Catch ex As Exception
            MsgBox("Error:" & ex.Message)
        End Try
    End Sub
    Public Function check_acc() As Boolean
        Dim flag As Boolean

        Try
            Dim cmd As SqlCommand
            Dim qry As String
            qry = "SELECT COUNT(accno) FROM tblblacc WHERE accno=@accno"
            cmd = New SqlCommand(qry, con)
            cmd.Parameters.AddWithValue("@accno", accountselected)
            If (cmd.ExecuteScalar > 0) Then

                cmd.Dispose()
                flag = True
            Else
                flag = False
            End If

        Catch ex As Exception
            MsgBox("Error:" & ex.Message)
        End Try
        Return flag
    End Function

    Private Sub txtsearch1_TextChanged(sender As Object, e As EventArgs) Handles txtsearch1.TextChanged
        load_blacklisted()

    End Sub

    Private Sub lvblacklist_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lvblacklist.SelectedIndexChanged

    End Sub

    Private Sub lvaccounts_Click(sender As Object, e As EventArgs) Handles lvaccounts.Click
        If lvaccounts.Items.Count > 0 Then

            Dim accno As String

            accno = lvaccounts.SelectedItems(0).Text.ToString
            accountselected = accno
            If (check_acc()) Then
                MsgBox("This account is already in the blacklisted account.", MsgBoxStyle.Critical)
            Else
                lblaccselected.Text = accno.ToString
                gbRemhistory.Enabled = True
                txtreason.Focus()
            End If


        End If

    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub lvblacklist_DoubleClick(sender As Object, e As EventArgs) Handles lvblacklist.DoubleClick
        Dim x As Integer
        x = MessageBox.Show("Delete this account from the blacklist?", "KREM", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If (x = vbYes) Then
            Try

                Dim cmd As SqlCommand
                Dim qry As String
                Dim accno As String

                accno = lvblacklist.SelectedItems(0).Text.ToString
                qry = "DELETE FROM tblblacc WHERE accno=@accno"
                cmd = New SqlCommand(qry, con)
                cmd.Parameters.AddWithValue("@accno", accno)
                If (cmd.ExecuteNonQuery > 0) Then
                    MsgBox("Account " & accno & " deleted from the blacklisted accounts", MsgBoxStyle.Information)
                    load_blacklisted()

                Else
                    MsgBox("Error ")
                End If
            Catch ex As Exception
                MsgBox("Error:" & ex.Message)
            End Try
        End If

    End Sub
End Class