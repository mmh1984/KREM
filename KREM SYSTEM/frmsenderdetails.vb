Imports System.ComponentModel
Imports System.Data.SqlClient
Imports System.IO
Public Class frmsenderdetails
    Dim con As SqlConnection
    Public icselected As String
    Dim imgpath As String
    Public Function get_path() As String
        Dim path As String = ""
        Try
            Dim openpath As StreamReader
            openpath = File.OpenText("c:\connection\imagepath.txt")
            While openpath.Peek <> -1
                path = openpath.ReadLine
            End While
            openpath.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        Return path
    End Function
    Private Sub frmsenderdetails_Load(sender As Object, e As EventArgs) Handles Me.Load
        load_connection()
        load_selected(icselected)
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

    Private Sub load_photo(ByVal path As String)
        Try
            If (File.Exists(path)) Then
                Dim fs As FileStream
                fs = New FileStream(path, FileMode.Open, FileAccess.Read)
                pbPic.Image = Image.FromStream(fs)
                fs.Close()
                fs.Dispose()
            Else
                pbPic.Image = Nothing
            End If



        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Public Sub load_selected(ByVal ic As String)
        Try

            Dim cmd As SqlCommand
            Dim rs As SqlDataReader
            Dim qry As String
            qry = "SELECT * FROM tblsenderdetails WHERE ic_passport=@ic"
            cmd = New SqlCommand(qry, con)
            cmd.Parameters.AddWithValue("@ic", ic)
            rs = cmd.ExecuteReader
            Dim convertd As ConvertDate
            convertd = New ConvertDate

            While rs.Read
                check_dob(rs(5))

                lblic.Text = rs(0).ToString
                lblsender.Text = rs(1).ToString
                lblnationality.Text = rs(2).ToString
                lbladdress.Text = rs(3).ToString
                lblphone.Text = rs(4).ToString


                'txtdob.Value = convertd.convert_date(rs(5).ToString)
                lbloccupation.Text = rs(6).ToString
                lblincome.Text = rs(7).ToString
                lblpob.Text = rs(8).ToString

                If (rs(10).ToString = "none") Then
                    pbPic.Image = Image.FromFile(get_path() & "noimage.png")

                Else
                    imgpath = get_path() & rs(10)
                    load_photo(imgpath)

                End If


            End While
            rs.Close()
            cmd.Dispose()

        Catch ex As Exception
            MsgBox("Error: " & ex.Message)
        End Try



    End Sub
    Private Sub check_dob(ByVal strdob As String)
        Dim err As Boolean
        Try
            Dim dtconvert As Date
            dtconvert = Convert.ToDateTime(strdob)
            err = False
        Catch ex As Exception
            MsgBox("Date error:" & ex.Message)
            err = True
        End Try

        If err = False Then
            lbldob.Text = Convert.ToDateTime(strdob)
        Else
            lbldob.Text = DateTime.Now.ToString("dd/MM/yyyy")
        End If
    End Sub
    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        con.Close()
        Me.Close()
    End Sub
End Class