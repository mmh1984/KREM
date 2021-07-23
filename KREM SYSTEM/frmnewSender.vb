Imports System.Data.SqlClient
Imports System.IO
Public Class frmnewSender
    Dim con As SqlConnection
    Dim imgpath As String
    Dim imagename As Boolean
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
        con.Close()
        Me.Close()
    End Sub

    Private Sub frmnewSender_Load(sender As Object, e As EventArgs) Handles Me.Load
        load_connection()
        gbsenderdetails.Enabled = False
        btnSave.Enabled = False
        btnRotate.Enabled = False
    End Sub
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
    Private Sub load_photo(ByVal path As String)
        Try
            Dim fs As FileStream
            fs = New FileStream(path, FileMode.Open, FileAccess.Read)
            pbPic.Image = Image.FromStream(fs)
            fs.Close()
            fs.Dispose()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        con.Close()
        Me.Close()

    End Sub

    Private Sub btnNew_Click(sender As Object, e As EventArgs) Handles btnNew.Click
        imgpath = get_path() & "\noimage.png"
        load_photo(imgpath)
        gbsenderdetails.Enabled = True
        txtsender.Focus()
        btnNew.Enabled = False
        btnSave.Enabled = True

    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        If txtsender.Text.Length = 0 Or txtsender.Text.Length < 4 Then
            MsgBox("Sender's name cannot be empty (minimum of 4 characters)", MsgBoxStyle.Critical)
            txtsender.Focus()

        ElseIf txticpassport.Text.Length = 0 Or txticpassport.Text.Length < 8 Then
            MsgBox("IC/Passport cannot be empty (minimum of 8 characters)", MsgBoxStyle.Critical)
            txticpassport.Focus()

        ElseIf txtaddress.Text.Length = 0 Then
            MsgBox("Address cannot be empty", MsgBoxStyle.Critical)
            txtaddress.Focus()
        ElseIf (txtphone.Text.Length = 0 Or txtphone.Text.Length < 11) Or (txtphone.Text.Substring(0, 4) <> "+673") Then
            MsgBox("Brunei phone number must be 11 characters (including +673)", MsgBoxStyle.Critical)
            txtphone.Focus()
        ElseIf txtoccupation.Text.Length = 0 Then
            MsgBox("Occupation cannot be empty", MsgBoxStyle.Critical)
            txtoccupation.Focus()
        ElseIf txtplaceofbirth.Text.Length = 0 Then
            MsgBox("Place of birth cannot be empty", MsgBoxStyle.Critical)
            txtplaceofbirth.Focus()
        ElseIf (ic_taken(txticpassport.Text) = 1) Then
            MsgBox("This IC/Passport is already assigned to another user", MsgBoxStyle.Critical)
            txticpassport.Focus()
        ElseIf imagename = False Then
            MsgBox("You have to select a photo for the passport/ic", MsgBoxStyle.Critical)
            btnViewPhoto.Focus()
        Else
            save_sender()
        End If






    End Sub
    Private Sub save_sender()
        Try
            Dim cmd As SqlCommand
            Dim qry As String
            qry = "INSERT INTO tblsenderdetails (ic_passport,sender,nationality,localaddress,phoneno,dob,occupation,"
            qry &= "sourceofincome,placeofbirth,imgpath,status) "
            qry &= "VALUES (@r1,@r2,@r3,@r4,@r5,@r6,@r7,@r8,@r9,@r10,@r11)"
            cmd = New SqlCommand(qry, con)
            Dim dob As Date
            dob = txtdob.Value
            Dim path As String
            path = get_path() & txticpassport.Text & ".jpg"

            pbPic.Image.Save(path)
            cmd.Parameters.AddWithValue("@r1", txticpassport.Text)
            cmd.Parameters.AddWithValue("@r2", txtsender.Text)
            cmd.Parameters.AddWithValue("@r3", cbxnationality.Text)
            cmd.Parameters.AddWithValue("@r4", txtaddress.Text)
            cmd.Parameters.AddWithValue("@r5", txtphone.Text)
            cmd.Parameters.AddWithValue("@r6", dob.ToString("yyyy-MM-dd"))
            cmd.Parameters.AddWithValue("@r7", txtoccupation.Text)
            cmd.Parameters.AddWithValue("@r8", cbxincome.Text)
            cmd.Parameters.AddWithValue("@r9", txtplaceofbirth.Text)
            cmd.Parameters.AddWithValue("@r10", txticpassport.Text & ".jpg")
            cmd.Parameters.AddWithValue("@r11", "ACTIVE")

            If (cmd.ExecuteNonQuery) Then
                MsgBox("New sender created!", MsgBoxStyle.Information)
                Me.Close()
            End If
            cmd.Dispose()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Function ic_taken(ByVal icno As String) As Integer
        Dim x As Integer
        Try

            Dim cmd As SqlCommand
            Dim qry As String

            qry = "Select count(*) FROM tblsenderdetails WHERE ic_passport=@icno"
            cmd = New SqlCommand(qry, con)
            cmd.Parameters.AddWithValue("@icno", icno)

            x = cmd.ExecuteScalar


            cmd.Dispose()


        Catch ex As Exception
            MsgBox("IC Error: " & ex.Message)
        End Try
        Return x
    End Function

    Private Sub btnViewPhoto_Click(sender As Object, e As EventArgs) Handles btnViewPhoto.Click
        OpenFileDialog1.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyPictures)

        OpenFileDialog1.Title = "Browse IC or Passport"
        OpenFileDialog1.Filter = "Image Files|*.jpg;*.png;*.jpeg"
        If (OpenFileDialog1.ShowDialog() = DialogResult.OK) Then
            If (OpenFileDialog1.FileName <> "") Then

                pbPic.Load(OpenFileDialog1.FileName)
                pbPic.Refresh()
                OpenFileDialog1.Dispose()
                btnRotate.Enabled = True
                imagename = True
            Else
                imagename = False

            End If

        End If
    End Sub

    Private Sub btnRotate_Click(sender As Object, e As EventArgs) Handles btnRotate.Click
        pbPic.Image.RotateFlip(RotateFlipType.Rotate90FlipNone)
        pbPic.Refresh()
    End Sub
End Class