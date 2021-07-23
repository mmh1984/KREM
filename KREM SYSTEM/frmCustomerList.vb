Imports System.ComponentModel
Imports System.Data.SqlClient
Imports System.IO
Public Class frmCustomerList
    Dim con As SqlConnection
    Dim progress As Integer
    Dim icselected As String
    Dim rowno As String
    Dim inputerror As Boolean
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
    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
        con.Close()

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

    Private Sub frmCustomerList_Load(sender As Object, e As EventArgs) Handles Me.Load
        load_connection()
        button_events("load")


    End Sub
    Public Sub count_rows()
        Try

            Dim cmd As SqlCommand
            Dim qry As String

            qry = "SELECT COUNT(*) FROM tblsenderdetails"
            cmd = New SqlCommand(qry, con)
            Dim count As Integer
            count = Convert.ToInt32(cmd.ExecuteScalar)



        Catch ex As Exception

        End Try
    End Sub



    Public Sub load_selected(ByVal ic As String)
        Dim cmd As SqlCommand
        Dim rs As SqlDataReader
        Try


            Dim qry As String
            qry = "SELECT * FROM tblsenderdetails WHERE ic_passport=@ic"
            cmd = New SqlCommand(qry, con)
            cmd.Parameters.AddWithValue("@ic", ic)
            rs = cmd.ExecuteReader
            Dim convertd As ConvertDate
            convertd = New ConvertDate


            While rs.Read


                txticpassport.Text = rs(0).ToString
                txtsender.Text = rs(1).ToString
                cbxnationality.Text = rs(2).ToString
                txtaddress.Text = rs(3).ToString
                txtphone.Text = rs(4).ToString
                txtoccupation.Text = rs(6).ToString
                cbxincome.Text = rs(7).ToString
                txtplaceofbirth.Text = rs(8).ToString
                rowno = rs(9).ToString
                If (rs(10).ToString = "none") Then
                    imgpath = get_path() & "\noimage.png"
                    load_photo(imgpath)
                Else
                    imgpath = get_path() & rs(10)
                    load_photo(imgpath)

                End If
                check_dob(rs(5))

            End While


        Catch ex As Exception
            MsgBox("Error Loading: " & ex.Message)

        End Try

        rs.Close()
        cmd.Dispose()

    End Sub
    Private Sub check_dob(ByVal strdob As String)
        Dim err As Boolean
        Dim dtconvert As Date

        dtconvert = strdob
        txtdob.Value = dtconvert.ToString("dd/MM/yyyy")

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
            MsgBox("Image Error" & ex.Message)
        End Try
    End Sub
    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click

        search_sender()
    End Sub
    Private Sub search_sender()

        If (txtsearch.Text.Length > 0) Then
            Dim customerdlg = New frmCustomerListDialog
            Dim qry As String = "SELECT * FROM tblsenderdetails where (sender LIKE @sender  or ic_passport=@sender2) AND status='ACTIVE'"
            customerdlg.load_sender(txtsearch.Text, qry)
            If (customerdlg.ShowDialog = DialogResult.OK) Then
                icselected = customerdlg.icpassport
                load_selected(customerdlg.icpassport)
                txtsearch.Text = ""
                button_events("edit")
                btnEdit.Focus()

            End If
        Else
            MsgBox("Enter sender's name in the search box and press send", MsgBoxStyle.Critical)
        End If
    End Sub
    Public Sub button_events(ByVal action As String)
        Select Case action
            Case "load"
                input_status(False)
                btnEdit.Enabled = False
                btnCancel.Enabled = False
                btnUpdate.Enabled = False
                btndelete.Enabled = False
                btnViewPhoto.Enabled = False
                clear_inputs()
                txtsearch.Focus()
            Case "edit"
                input_status(False)
                btnEdit.Enabled = True
                btnCancel.Enabled = False
                btnUpdate.Enabled = False
                btndelete.Enabled = False
                btnViewPhoto.Enabled = False
            Case "edit1"
                input_status(True)
                btnEdit.Enabled = False
                btnCancel.Enabled = True
                btnUpdate.Enabled = True
                btndelete.Enabled = True
                btnViewPhoto.Enabled = True
                btnUpdate.Focus()
            Case "cancel"
                input_status(False)
                btnEdit.Enabled = False
                btnCancel.Enabled = False
                btnUpdate.Enabled = False
                btndelete.Enabled = False
                btnViewPhoto.Enabled = False
                txtsearch.Focus()
                clear_inputs()
            Case "delete"
            Case "update"
                input_status(False)
                btnEdit.Enabled = False
                btnCancel.Enabled = False
                btnUpdate.Enabled = False
                btndelete.Enabled = False
                btnViewPhoto.Enabled = False
                clear_inputs()
                txtsearch.Focus()

        End Select
    End Sub
    Public Sub input_status(ByVal value As Boolean)
        txtsender.Enabled = value
        txticpassport.Enabled = value
        cbxnationality.Enabled = value
        txtaddress.Enabled = value
        txtphone.Enabled = value
        txtdob.Enabled = value
        txtoccupation.Enabled = value
        cbxincome.Enabled = value
        txtplaceofbirth.Enabled = value
    End Sub





    Private Sub btnCancel_Click(sender As Object, e As EventArgs)
        button_events("cancel")
    End Sub


    Private Sub update_record()
        Try

            Dim cmd As SqlCommand
            Dim qry As String

            qry = "UPDATE tblsenderdetails SET ic_passport=@v0,sender=@v1,nationality=@v2,localaddress=@v3,phoneno=@v4,dob=@v5,occupation=@v6,sourceofincome=@v7,
                    placeofbirth=@v8
                    WHERE rowno=@rowno"

            Dim dob As Date
            dob = txtdob.Value
            cmd = New SqlCommand(qry, con)
            cmd.Parameters.AddWithValue("@v0", txticpassport.Text.Trim)
            cmd.Parameters.AddWithValue("@v1", txtsender.Text.Trim)
            cmd.Parameters.AddWithValue("@v2", cbxnationality.Text.Trim)
            cmd.Parameters.AddWithValue("@v3", txtaddress.Text.Trim)
            cmd.Parameters.AddWithValue("@v4", txtphone.Text.Trim)
            cmd.Parameters.AddWithValue("@v5", dob.ToString("yyyy-MM-dd"))
            cmd.Parameters.AddWithValue("@v6", txtoccupation.Text.Trim)
            cmd.Parameters.AddWithValue("@v7", cbxincome.Text.Trim)
            cmd.Parameters.AddWithValue("@v8", txtplaceofbirth.Text.Trim)
            cmd.Parameters.AddWithValue("@rowno", rowno)

            If (cmd.ExecuteNonQuery()) Then

                cmd.Dispose()
                Dim cmd2 As SqlCommand
                cmd2 = New SqlCommand("UPDATE tbltransaction SET ic_passport=@ic WHERE ic_passport=@icselected", con)
                cmd2.Parameters.AddWithValue("@ic", txticpassport.Text.Trim)
                cmd2.Parameters.AddWithValue("@icselected", icselected)
                If (cmd2.ExecuteNonQuery) Then
                    MsgBox("Sender details successfully updated", MsgBoxStyle.Information)
                    cmd2.Dispose()
                    button_events("load")
                    imgpath = get_path() & "\noimage.png"
                    load_photo(imgpath)
                End If


            End If


        Catch ex As Exception
            MsgBox("Update Error:  " & ex.Message)
        End Try
    End Sub
    Private Sub update_record1()
        Try

            Dim cmd As SqlCommand
            Dim qry As String

            qry = "UPDATE tblsenderdetails SET sender=@v1,nationality=@v2,localaddress=@v3,phoneno=@v4,dob=@v5,occupation=@v6,sourceofincome=@v7,
                    placeofbirth=@v8
                    WHERE rowno=@rowno"

            Dim dob As Date
            dob = txtdob.Value
            cmd = New SqlCommand(qry, con)
            cmd.Parameters.AddWithValue("@v1", txtsender.Text.Trim)
            cmd.Parameters.AddWithValue("@v2", cbxnationality.Text.Trim)
            cmd.Parameters.AddWithValue("@v3", txtaddress.Text.Trim)
            cmd.Parameters.AddWithValue("@v4", txtphone.Text.Trim)
            cmd.Parameters.AddWithValue("@v5", dob.ToString("yyyy-MM-dd"))
            cmd.Parameters.AddWithValue("@v6", txtoccupation.Text.Trim)
            cmd.Parameters.AddWithValue("@v7", cbxincome.Text.Trim)
            cmd.Parameters.AddWithValue("@v8", txtplaceofbirth.Text.Trim)
            cmd.Parameters.AddWithValue("@rowno", rowno)

            If (cmd.ExecuteNonQuery()) Then
                MsgBox("Sender details successfully updated", MsgBoxStyle.Information)
                button_events("load")
                imgpath = get_path() & "\noimage.png"
                load_photo(imgpath)
            End If
            cmd.Dispose()


        Catch ex As Exception
            MsgBox("Update Error: " & ex.Message)
        End Try
    End Sub

    Private Function same_ic(ByVal icno As String) As Boolean
        If (icselected.ToLower = txticpassport.Text.ToLower) Then
            Return True
        Else
            Return False

        End If

    End Function

    Private Function ic_taken(ByVal icno As String) As Integer
        Try

            Dim cmd As SqlCommand
            Dim qry As String
            Dim x As Integer
            qry = "SELECT count(*) FROM tblsenderdetails WHERE ic_passport=@icno AND rowno <> @rowno"
            cmd = New SqlCommand(qry, con)
            cmd.Parameters.AddWithValue("@icno", icno)
            cmd.Parameters.AddWithValue("@rowno", rowno)
            x = cmd.ExecuteScalar

            Return x
            cmd.Dispose()


        Catch ex As Exception
            MsgBox("IC Error: " & ex.Message)
        End Try

    End Function

    Private Sub btndelete_Click(sender As Object, e As EventArgs)
        Dim x As Integer
        x = MessageBox.Show("Are your sure you want to delete this record?", "KREM", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If x = vbYes Then
            Try

                Dim cmd As SqlCommand
                cmd = New SqlCommand("UPDATE tblsenderdetails SET status='DELETED' WHERE rowno=@rowselected", con)
                cmd.Parameters.AddWithValue("@rowselected", rowno)
                If (cmd.ExecuteNonQuery) Then
                    MsgBox("Sender Details deleted", MsgBoxStyle.Information)
                    imgpath = get_path() & "\noimage.png"
                    load_photo(imgpath)
                    button_events("load")
                    cmd.Dispose()

                    txtsearch.Text = ""


                End If
            Catch ex As Exception
                MsgBox("Delete error: " & ex.Message)
            End Try
        End If
    End Sub

    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        button_events("edit1")
    End Sub

    Private Sub btnCancel_Click_1(sender As Object, e As EventArgs) Handles btnCancel.Click
        button_events("cancel")
    End Sub

    Private Sub btnUpdate_Click_1(sender As Object, e As EventArgs) Handles btnUpdate.Click
        If txtsender.Text.Length = 0 Or txtsender.Text.Length < 4 Then
            MsgBox("Sender's name cannot be empty (minimum of 4 characters)", MsgBoxStyle.Critical)
            inputerror = True
        ElseIf txticpassport.Text.Length = 0 Or txticpassport.Text.Length < 8 Then
            MsgBox("IC/Passport cannot be empty (minimum of 8 characters)", MsgBoxStyle.Critical)
            inputerror = True
        ElseIf txtaddress.Text.Length = 0 Then
            MsgBox("Address cannot be empty", MsgBoxStyle.Critical)
            inputerror = True
        ElseIf (txtphone.Text.Length = 0 Or txtphone.Text.Length < 11) Or (txtphone.Text.Substring(0, 4) <> "+673") Then
            MsgBox("Brunei phone number must be 11 characters (including +673)", MsgBoxStyle.Critical)
            inputerror = True
        ElseIf txtoccupation.Text.Length = 0 Then
            MsgBox("Occupation cannot be empty", MsgBoxStyle.Critical)
            inputerror = True
        ElseIf txtplaceofbirth.Text.Length = 0 Then
            MsgBox("Place of birth cannot be empty", MsgBoxStyle.Critical)
            inputerror = True
        Else
            If (same_ic(txticpassport.Text)) Then
                update_record1()
            Else
                If (ic_taken(txticpassport.Text) = 0) Then
                    update_record()
                Else
                    MsgBox("This IC/Passport is already assigned to another sender", MsgBoxStyle.Critical)
                End If

            End If
        End If


    End Sub



    Private Sub rightpanel_Paint(sender As Object, e As PaintEventArgs) Handles rightpanel.Paint

    End Sub

    Private Sub btndelete_Click_1(sender As Object, e As EventArgs) Handles btndelete.Click
        Dim x As Integer
        x = MessageBox.Show("Are your sure you want to delete this record?", "KREM", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If x = vbYes Then
            Try

                Dim cmd As SqlCommand
                cmd = New SqlCommand("UPDATE tblsenderdetails SET status='DELETED' WHERE rowno=@rowselected", con)
                cmd.Parameters.AddWithValue("@rowselected", rowno)
                If (cmd.ExecuteNonQuery) Then
                    MsgBox("Sender Details deleted", MsgBoxStyle.Information)
                    imgpath = get_path() & "\noimage.png"
                    load_photo(imgpath)
                    button_events("load")
                    cmd.Dispose()

                    txtsearch.Text = ""

                End If
            Catch ex As Exception
                MsgBox("Delete error: " & ex.Message)
            End Try
        End If
    End Sub

    Private Sub btnViewPhoto_Click_1(sender As Object, e As EventArgs) Handles btnViewPhoto.Click
        Try
            Dim viewphoto = New frmViewImage
            viewphoto.icpassport = icselected
            viewphoto.rowselected = rowno
            viewphoto.pbPic.Load(imgpath)
            If (viewphoto.ShowDialog() = DialogResult.OK) Then
                load_selected(icselected)

            End If
        Catch ex As Exception
            MsgBox("Image error: " & ex.Message)
        End Try


    End Sub

    Private Sub txtsearch_KeyDown(sender As Object, e As KeyEventArgs) Handles txtsearch.KeyDown
        If e.KeyCode = Keys.Enter Then
            search_sender()
        End If

    End Sub
    Private Sub clear_inputs()
        txtsender.Text = ""
        txticpassport.Text = ""
        cbxnationality.SelectedIndex = 0
        txtaddress.Text = ""
        txtphone.Text = "+673"
        txtoccupation.Text = ""
        cbxincome.SelectedIndex = 0
        txtplaceofbirth.Text = ""

    End Sub
End Class