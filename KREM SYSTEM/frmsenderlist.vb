Imports System.Data.SqlClient
Public Class frmsenderlist
    Dim con As SqlConnection



    Private Sub frmsenderlist_Load(sender As Object, e As EventArgs) Handles Me.Load
        btnok.Enabled = False

    End Sub

    Public Sub load_sender(ByVal keyword As String)
        load_connection()
        Try
            Dim cmd As SqlCommand
            Dim rs As SqlDataReader
            Dim qry As String
            qry = "SELECT * FROM tblsenderdetails where (sender LIKE @sender  or ic_passport=@sender2) AND status='ACTIVE'"

            cmd = New SqlCommand(qry, con)
            cmd.Parameters.AddWithValue("@sender", "%" & keyword & "%")
            cmd.Parameters.AddWithValue("@sender2", keyword)

            rs = cmd.ExecuteReader
            Dim senderlist As ListViewItem
            lvCustomers.Items.Clear()
            If rs.HasRows Then

                While rs.Read
                    senderlist = lvCustomers.Items.Add(rs(0))
                    senderlist.SubItems.Add(rs(1))
                    senderlist.SubItems.Add(rs(2))

                End While
                rs.Close()
                cmd.Dispose()

            Else
                MsgBox("There are no results to display", MsgBoxStyle.Information)
            End If

        Catch ex As Exception
            MsgBox(ex.Message & " error ")
        End Try
    End Sub
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

    Private Sub lvCustomers_Click(sender As Object, e As EventArgs) Handles lvCustomers.Click
        If (lvCustomers.Items.Count > 0) Then

            btnok.Enabled = True


        End If
    End Sub

    Private Sub lvCustomers_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lvCustomers.SelectedIndexChanged

    End Sub
End Class