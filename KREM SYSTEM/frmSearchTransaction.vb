Imports System.Data.SqlClient

Public Class frmSearchTransaction
    Dim con As SqlConnection
    Dim ic As String
    Dim amount As Decimal
    Dim totalamount As Decimal
    Dim rate As Decimal
    Dim servicecharge As Integer
    Dim stricpassport As String
    Dim receiver As String
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

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        If txtsearch.Text.Length = 0 Then
            MsgBox("Enter the serial number and press search")
        Else
            search_transaction(txtsearch.Text)
        End If
    End Sub

    Private Sub txtsearch_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtsearch.KeyPress
        If (e.KeyChar < "0" OrElse e.KeyChar > "9") AndAlso 'restricts anything but number keys
    e.KeyChar <> ControlChars.Back Then 'allows use of backspace
            e.Handled = True
        End If
    End Sub

    Public Sub search_transaction(ByVal strreceipt As String)
        Try


            Dim cmd As SqlCommand
            Dim query As String
            Dim rs As SqlDataReader


            query = "SELECT * FROM tbltransaction WHERE receiptno=@receipt"

            cmd = New SqlCommand(query, con)
            cmd.Parameters.AddWithValue("@receipt", strreceipt)
            rs = cmd.ExecuteReader

            If (rs.HasRows) Then
                MsgBox("Serial number found", MsgBoxStyle.Information)
                Dim dtsent As Date
                While rs.Read

                    lblserialno.Text = rs(0)

                    txtreceiver.Text = rs(2)
                    cbxcountry.Text = rs(3)
                    txtcity.Text = rs(4)
                    txtaccountno.Text = rs(5)
                    txtbank.Text = rs(6)
                    txtbranch.Text = rs(7)
                    totalamount = rs(8)
                    rate = rs(9)
                    amount = rs(10)
                    txtrate.Text = rate
                    servicecharge = rs(11)

                    'amount = amount - servicecharge

                    txttotal.Text = totalamount.ToString("N2")
                    txtamount.Text = rate.ToString("N2")
                    txtamount.Text = amount.ToString("N2")
                    txtcharge.Text = servicecharge
                    dtsent = Convert.ToDateTime(rs(15))

                    txtdate.Value = dtsent.ToString("dd/MM/yyyy")
                    ic = rs(16)

                End While
                rs.Close()
                cmd.Dispose()
                button_events("found")
                senderfound(ic)
            Else
                MsgBox("Receipt number not found", MsgBoxStyle.Critical)
                rs.Close()
                cmd.Dispose()
                txtsearch.Focus()

            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Public Sub senderfound(ByVal icpass As String)
        Dim found As Boolean = False
        Try

            Dim cmd As SqlCommand
            Dim rs As SqlDataReader
            Dim query As String
            query = "SELECT * FROM tblsenderdetails where ic_passport=@icpass"
            cmd = New SqlCommand(query, con)
            cmd.Parameters.AddWithValue("@icpass", icpass)
            rs = cmd.ExecuteReader

            If rs.HasRows Then


                While (rs.Read)
                    Dim dtdob As Date
                    txticpassport.Text = rs(0)
                    txtsender.Text = rs(1)
                    cbxnationality.Text = rs(2)
                    txtaddress.Text = rs(3)
                    txtphone.Text = rs(4)
                    dtdob = Convert.ToDateTime(rs(5))
                    txtdob.Value = dtdob.ToString("dd/MM/yyyy")
                    txtoccupation.Text = rs(6)
                    cbxincome.Text = rs(7)
                    txtplaceofbirth.Text = rs(8)
                End While
            End If
            rs.Close()
            cmd.Dispose()

            load_receivers(txticpassport.Text)

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub
    Public Sub load_receivers(ByVal id As String)
        Try

            Dim cmd As SqlCommand
            Dim rs As SqlDataReader
            Dim query As String

            query = "SELECT DISTINCT receiver FROM tbltransaction WHERE ic_passport=@ic"
            cmd = New SqlCommand(query, con)
            cmd.Parameters.AddWithValue("@ic", id)
            rs = cmd.ExecuteReader
            cbxreceiver.Items.Clear()
            If (rs.HasRows) Then
                cbxreceiver.Items.Add("-NEW RECEIVER-")
                While rs.Read
                    cbxreceiver.Items.Add(rs(0))
                End While
            Else
                cbxreceiver.Items.Add("-NEW RECEIVER-")

            End If
            rs.Close()
            cmd.Dispose()





        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub frmSearchTransaction_Load(sender As Object, e As EventArgs) Handles Me.Load
        load_connection()
        button_events("load")

    End Sub
    Private Sub button_events(ByVal ev As String)
        Select Case ev
            Case "load"
                gbReceiver.Enabled = False
                gbRemDetails.Enabled = False
                gbSenderDetails.Enabled = False
                btnEdit.Enabled = False
                btndelete.Enabled = False
                btnUpdate.Enabled = False
                btnCancel.Enabled = False
                txtdate.Enabled = False
                btnPrint.Enabled = False
                txtsearch.Text = ""
                txtsearch.Focus()

            Case "found"
                gbReceiver.Enabled = False
                gbRemDetails.Enabled = False
                gbSenderDetails.Enabled = False
                btnEdit.Enabled = True
                btndelete.Enabled = False
                btnUpdate.Enabled = False
                btnCancel.Enabled = False
                txtdate.Enabled = False
                btnPrint.Enabled = True
                txtsearch.Text = ""
            Case "edit"

                gbReceiver.Enabled = True
                gbRemDetails.Enabled = True
                gbSenderDetails.Enabled = False
                btnEdit.Enabled = False
                btndelete.Enabled = True
                btnUpdate.Enabled = True
                btnCancel.Enabled = True
                txtdate.Enabled = True
                btnPrint.Enabled = False
            Case "cancel"
                gbReceiver.Enabled = False
                gbRemDetails.Enabled = False
                gbSenderDetails.Enabled = False
                btnEdit.Enabled = True
                btndelete.Enabled = False
                btnUpdate.Enabled = False
                btnCancel.Enabled = False
                txtdate.Enabled = False
                btnPrint.Enabled = True
                txtsearch.Text = ""
                txtsearch.Focus()
        End Select

    End Sub


    Private Sub btnPrint_Click(sender As Object, e As EventArgs) Handles btnPrint.Click
        Dim dlreceipt = New frmPrintReceipt
        dlreceipt.receiptno = lblserialno.Text
        If dlreceipt.ShowDialog() = DialogResult.OK Then
            MsgBox("Receipt Printed!", MsgBoxStyle.Information)
        End If
    End Sub

    Private Sub txtamount_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtamount.KeyPress
        e.Handled = Not (Char.IsDigit(e.KeyChar) Or Asc(e.KeyChar) = 8 Or ((e.KeyChar = "." Or e.KeyChar = ",") And (sender.Text.IndexOf(".") = -1 And sender.Text.IndexOf(",") = -1)))
    End Sub

    Private Sub txtcharge_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtcharge.KeyPress
        e.Handled = Not (Char.IsDigit(e.KeyChar) Or Asc(e.KeyChar) = 8 Or ((e.KeyChar = "." Or e.KeyChar = ",") And (sender.Text.IndexOf(".") = -1 And sender.Text.IndexOf(",") = -1)))
    End Sub

    Private Sub txtrate_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtrate.KeyPress
        e.Handled = Not (Char.IsDigit(e.KeyChar) Or Asc(e.KeyChar) = 8 Or ((e.KeyChar = "." Or e.KeyChar = ",") And (sender.Text.IndexOf(".") = -1 And sender.Text.IndexOf(",") = -1)))
    End Sub

    Private Sub btncalculate_Click(sender As Object, e As EventArgs) Handles btncalculate.Click
        Dim rate As Double
        Dim amount As Double
        Dim total As Double
        rate = Convert.ToDecimal(txtrate.Text)
        amount = Convert.ToDecimal(txtamount.Text)
        total = rate * amount
        txttotal.Text = total.ToString("N2")
    End Sub

    Private Sub cbxreceiver_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbxreceiver.SelectedIndexChanged
        If (cbxreceiver.SelectedIndex = 0) Then
            Dim strnewreceiver As String
            strnewreceiver = InputBox("Enter new receiver name", "Name")
            txtreceiver.Text = strnewreceiver
        Else
            txtreceiver.Text = cbxreceiver.Text
        End If
    End Sub

    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        button_events("edit")
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        button_events("cancel")
    End Sub

    Private Sub btndelete_Click(sender As Object, e As EventArgs) Handles btndelete.Click
        Try
            Dim x As Integer
            x = MsgBox("Are you sure you want to delete this transaction?", MsgBoxStyle.YesNo + MsgBoxStyle.Question)

            If (x = vbYes) Then
                Dim cmd As SqlCommand
                Dim query As String
                query = "DELETE FROM tblTransaction WHERE receiptno=@receipt"
                cmd = New SqlCommand(query, con)
                cmd.Parameters.AddWithValue("@receipt", lblserialno.Text)

                If (cmd.ExecuteNonQuery) Then
                    MsgBox("Receipt no " & lblserialno.Text & " deleted!", MsgBoxStyle.Information)
                    Me.Close()

                End If
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        Try
            save_transaction()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Public Sub save_transaction()
        Try
            Dim strserial, strreceiver, strcountry, strcity, stracc, strbank, strbranch, strreason, stric As String
            Dim dectotalamt, decrate, decamntsent, decamtcharge As Decimal
            Dim intservicecharge As Integer
            Dim datesent As Date

            strserial = lblserialno.Text
            strreceiver = txtreceiver.Text
            strcountry = cbxcountry.SelectedItem
            strcity = txtcity.Text
            stracc = txtaccountno.Text
            strbank = txtbank.Text
            strbranch = txtbranch.Text
            strreason = "Personal"
            stric = txticpassport.Text


            decrate = Convert.ToDecimal(txtrate.Text)

            intservicecharge = Convert.ToInt32(txtcharge.Text)
            decamntsent = Convert.ToDecimal(txtamount.Text)
            dectotalamt = Convert.ToDecimal(txttotal.Text)
            decamtcharge = decamntsent + intservicecharge

            servicecharge = intservicecharge

            datesent = txtdate.Value

            Dim cmd As SqlCommand
            Dim query As String

            query = "UPDATE tbltransaction SET receiver=@r2,country=@r3,city=@r4,accountno=@r5,"
            query &= "bank=@r6,branch=@r7,totalamountsent=@r8,rate=@r9,amountsent=@r10,servicecharge=@r11,"
            query &= "amountpluscharge=@r12,reason=@r13,datesent=@r14,ic_passport=@r15 WHERE receiptno=@r16"

            cmd = New SqlCommand(query, con)

            cmd.Parameters.AddWithValue("@r2", strreceiver)
            cmd.Parameters.AddWithValue("@r3", strcountry)
            cmd.Parameters.AddWithValue("@r4", strcity)
            cmd.Parameters.AddWithValue("@r5", stracc)
            cmd.Parameters.AddWithValue("@r6", strbank)
            cmd.Parameters.AddWithValue("@r7", strbranch)
            cmd.Parameters.AddWithValue("@r8", dectotalamt)
            cmd.Parameters.AddWithValue("@r9", decrate)
            cmd.Parameters.AddWithValue("@r10", decamntsent)
            cmd.Parameters.AddWithValue("@r11", intservicecharge)
            cmd.Parameters.AddWithValue("@r12", decamtcharge)
            cmd.Parameters.AddWithValue("@r13", strreason)
            cmd.Parameters.AddWithValue("@r14", datesent.ToString("yyyy-MM-dd"))
            cmd.Parameters.AddWithValue("@r15", stric)
            cmd.Parameters.AddWithValue("@r16", strserial)

            If (cmd.ExecuteNonQuery) Then
                MsgBox("Update complete!", MsgBoxStyle.Information)
                button_events("load")
                Me.Close()

            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub


    Private Sub txtamount_Leave(sender As Object, e As EventArgs) Handles txtamount.Leave
        Dim rate As Double
        Dim amount As Double
        Dim total As Double
        rate = Convert.ToDecimal(txtrate.Text)
        amount = Convert.ToDecimal(txtamount.Text)
        total = rate * amount
        txttotal.Text = total.ToString("N2")
    End Sub

    Private Sub txtrate_Leave(sender As Object, e As EventArgs) Handles txtrate.Leave
        Dim rate As Double
        Dim amount As Double
        Dim total As Double
        rate = Convert.ToDecimal(txtrate.Text)
        amount = Convert.ToDecimal(txtamount.Text)
        total = rate * amount
        txttotal.Text = total.ToString("N2")
    End Sub

    Private Sub txtdob_ValueChanged(sender As Object, e As EventArgs) Handles txtdob.ValueChanged

    End Sub

    Private Sub txtsearch_TextChanged(sender As Object, e As EventArgs) Handles txtsearch.TextChanged

    End Sub

    Private Sub txtsearch_KeyDown(sender As Object, e As KeyEventArgs) Handles txtsearch.KeyDown
        If e.KeyCode = Keys.Enter Then
            If txtsearch.Text.Length = 0 Then
                MsgBox("Enter the serial number and press search")
            Else
                search_transaction(txtsearch.Text)
            End If
        End If

    End Sub
End Class