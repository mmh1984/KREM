Imports System.Data.SqlClient
Imports System.IO
Public Class frmViewImage
    Dim con As SqlConnection
    Public icpassport As String
    Public rowselected As Integer

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
    Private Sub frmViewImage_Load(sender As Object, e As EventArgs) Handles Me.Load
        Panel1.AutoScroll = True
        btnRotate.Enabled = False
        btnok.Enabled = False
    End Sub

    Private Sub btnbrowse_Click(sender As Object, e As EventArgs) Handles btnbrowse.Click
        OpenFileDialog1.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyPictures)

        OpenFileDialog1.Title = "Browse IC or Passport"
        OpenFileDialog1.Filter = "Image Files|*.jpg;*.png;*.jpeg"
        If (OpenFileDialog1.ShowDialog() = DialogResult.OK) Then
            If (OpenFileDialog1.FileName <> "") Then

                pbPic.Load(OpenFileDialog1.FileName)
                pbPic.Refresh()
                OpenFileDialog1.Dispose()
                btnRotate.Enabled = True
                btnok.Enabled = True
            End If

        End If



    End Sub

    Private Sub btnRotate_Click(sender As Object, e As EventArgs) Handles btnRotate.Click
        pbPic.Image.RotateFlip(RotateFlipType.Rotate90FlipNone)
        pbPic.Refresh()
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
    Private Sub btnok_Click(sender As Object, e As EventArgs) Handles btnok.Click
        Try
            load_connection()
            Dim path As String
            path = frmCustomerList.get_path() & icpassport & ".jpg"

            pbPic.Image.Save(path)



            Dim cmd As SqlCommand
            Dim qry As String

            qry = "UPDATE tblsenderdetails SET imgpath=@path WHERE rowno=@rowno AND ic_passport=@ic"


            cmd = New SqlCommand(qry, con)
            cmd.Parameters.AddWithValue("@path", icpassport & ".jpg")
            cmd.Parameters.AddWithValue("@rowno", rowselected)
            cmd.Parameters.AddWithValue("@ic", icpassport)


            If (cmd.ExecuteNonQuery()) Then
                MsgBox("Picture successfully updated", MsgBoxStyle.Information)


            End If
            cmd.Dispose()
            con.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
End Class