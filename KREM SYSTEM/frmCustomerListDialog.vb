Imports System.Data.SqlClient


Public Class frmCustomerListDialog
    Public icpassport As String
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
    Private Sub frmCustomerListDialog_Load(sender As Object, e As EventArgs) Handles Me.Load
        btnok.Enabled = False

    End Sub
    Public Sub load_sender(ByVal sendername As String, ByVal qry As String)


        Try
            load_connection()
            Dim cmd As SqlCommand
            Dim rs As SqlDataReader
            cmd = New SqlCommand(qry, con)
            cmd.Parameters.AddWithValue("@sender", "%" & sendername & "%")
            cmd.Parameters.AddWithValue("@sender2", sendername)

            rs = cmd.ExecuteReader
            Dim senderlist As ListViewItem
            lvCustomers.Items.Clear()
            If rs.HasRows Then
                MsgBox("Select on the sender to edit")
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
            MsgBox("Error:" & ex.Message)
        End Try
    End Sub

    Private Sub lvCustomers_Click(sender As Object, e As EventArgs) Handles lvCustomers.Click
        If lvCustomers.Items.Count > 0 Then

            icpassport = lvCustomers.SelectedItems(0).Text
            btnok.Enabled = True
        End If


    End Sub
End Class