Imports System.Data.SqlClient
Public Class frmRemittance
    Dim con As SqlConnection
    Dim icselected As String
    Dim totalremittance, totalamount As Double
    Dim totaltransactionas As Integer
    Dim today As DateTime
    Dim month, year As String

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
    Private Sub frmRemittance_Load(sender As Object, e As EventArgs) Handles Me.Load
        load_connection()
        today = DateTime.Today
        month = today.Month
        year = today.Year
        lblmonthyear.Text = today.Month.ToString & "/" & today.Year.ToString
        gbReceiver.Enabled = False
        gbRemDetails.Enabled = False
        gbSender.Enabled = False
        txtsearch.Focus()

    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        search_sender()
    End Sub
    Private Sub search_sender()
        Dim senderDialog As frmsenderlist

        If (txtsearch.Text.Length > 0) Then
            senderDialog = New frmsenderlist
            senderDialog.load_sender(txtsearch.Text)

            If (senderDialog.ShowDialog() = DialogResult.OK) Then
                Dim index As Integer
                index = senderDialog.lvCustomers.SelectedIndices(0)
                icselected = senderDialog.lvCustomers.Items(index).SubItems(0).Text
                lblicpassport.Text = senderDialog.lvCustomers.Items(index).SubItems(0).Text
                lblsender.Text = senderDialog.lvCustomers.Items(index).SubItems(1).Text
                gbSender.Enabled = True
                senderDialog.Close()
                load_remittance(icselected)

            Else
                senderDialog.Close()
            End If

        Else
            MsgBox("Enter sender's name in the search box and press send", MsgBoxStyle.Critical)
        End If
    End Sub

    Public Sub load_remittance(ByVal stric As String)
        Try


            Dim cmd As SqlCommand
            Dim qry As String
            Dim rs As SqlDataReader

            qry = "SELECT * FROM tbltransaction WHERE ic_passport=@ic AND (month(datesent)=@month AND year(datesent)=@year)"
            cmd = New SqlCommand(qry, con)
            cmd.Parameters.AddWithValue("@ic", stric)
            cmd.Parameters.AddWithValue("@month", month)
            cmd.Parameters.AddWithValue("@year", year)
            'cmd.Parameters.AddWithValue("@month", "11")
            ' cmd.Parameters.AddWithValue("@year", "2018")

            rs = cmd.ExecuteReader
            Dim remlist As ListViewItem

            totalamount = 0.0
            totalremittance = 0.0
            totaltransactionas = 0
            If rs.HasRows Then

                While rs.Read
                    Dim remdate As Date
                    remdate = Convert.ToDateTime(rs(15))
                    remlist = lvremhistory.Items.Add(remdate.ToString("dd/MM/yyyy"))
                    remlist.SubItems.Add(rs(2))
                    remlist.SubItems.Add(rs(5))
                    remlist.SubItems.Add(rs(6))
                    remlist.SubItems.Add(rs(7))
                    remlist.SubItems.Add((Convert.ToDouble(rs(10))).ToString("C"))
                    remlist.SubItems.Add((Convert.ToDouble(rs(8))).ToString("C"))
                    remlist.SubItems.Add((Convert.ToDouble(rs(9))).ToString("C"))
                    remlist.SubItems.Add(rs(18))
                    totaltransactionas += 1
                    totalamount += Convert.ToDouble(rs(10))
                    totalremittance += Convert.ToDouble(rs(8))


                End While
            Else
                MsgBox("There are currently no remittances from this sender for " & lblmonthyear.Text, MsgBoxStyle.Information)
                totalamount = 0
                totalremittance = 0
                totaltransactionas = 0
                lvremhistory.Items.Clear()
                gbReceiver.Enabled = True

            End If
            rs.Close()
            cmd.Dispose()
            display_summary()
        Catch ex As Exception
            MsgBox("Load Remittance: " & ex.Message)
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
    Public Sub display_summary()
        lblremamount.Text = "B$" & totalremittance.ToString("N")
        lbltotalamount.Text = "B$" & totalamount.ToString("N")
        lblremcount.Text = totaltransactionas

        If (totalamount < 10000) Then

            gbReceiver.Enabled = True
            load_receivers(icselected)
            cbxcountry.Focus()
        Else
            MsgBox("Remittances for every month cannot exceed $10,000 BND. Supervisor approval is required")
            Dim approvaldialog = New frmapproval
            approvaldialog.ShowDialog()
            If (approvaldialog.msg = "yes") Then
                gbReceiver.Enabled = True
                load_receivers(icselected)
                cbxcountry.Focus()
            Else
                Me.Close()
            End If


        End If
    End Sub

    Private Sub txtamount_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtamount.KeyPress
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

    Private Sub txtrate_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtrate.KeyPress
        e.Handled = Not (Char.IsDigit(e.KeyChar) Or Asc(e.KeyChar) = 8 Or ((e.KeyChar = "." Or e.KeyChar = ",") And (sender.Text.IndexOf(".") = -1 And sender.Text.IndexOf(",") = -1)))
    End Sub

    Private Sub txtcharge_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtcharge.KeyPress
        e.Handled = Not (Char.IsDigit(e.KeyChar) Or Asc(e.KeyChar) = 8 Or ((e.KeyChar = "." Or e.KeyChar = ",") And (sender.Text.IndexOf(".") = -1 And sender.Text.IndexOf(",") = -1)))
    End Sub

    Private Sub cbxreceiver_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbxreceiver.SelectedIndexChanged
        If (cbxreceiver.SelectedIndex = 0) Then
            Dim strnewreceiver As String
            strnewreceiver = InputBox("Enter new receiver name", "Name")
            txtreceiver.Text = strnewreceiver
        Else
            txtreceiver.Text = cbxreceiver.Text
            receiver_bank()
        End If

    End Sub
    Private Sub receiver_bank()
        Dim strsender As String
        strsender = cbxreceiver.SelectedItem
        txtreceiver.Text = strsender
        Try
            Dim cmd As SqlCommand
            Dim query As String
            Dim rs As SqlDataReader
            query = "SELECT accountno,bank,branch FROM tbltransaction WHERE receiver=@receiver AND ic_passport=@ic"
            cmd = New SqlCommand(query, con)
            cmd.Parameters.AddWithValue("@receiver", strsender)
            cmd.Parameters.AddWithValue("@ic", icselected)
            rs = cmd.ExecuteReader

            While (rs.Read)
                txtaccountno.Text = rs(0)
                txtbank.Text = rs(1)
                txtbranch.Text = rs(2)

            End While
            rs.Close()
            cmd.Dispose()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub txtaccountno_TextChanged(sender As Object, e As EventArgs) Handles txtaccountno.TextChanged
        gbRemDetails.Enabled = False
    End Sub

    Private Sub GunaButton3_Click(sender As Object, e As EventArgs) Handles GunaButton3.Click
        If txtaccountno.Text.Length = 0 Then
            MsgBox("Enter account number to check", MsgBoxStyle.Critical)
        Else
            check_acc(txtaccountno.Text)
        End If
    End Sub
    Public Sub check_acc(ByVal accountselected As String)


        Try
            Dim cmd As SqlCommand
            Dim qry As String
            qry = "SELECT COUNT(accno) FROM tblblacc WHERE accno=@accno"
            cmd = New SqlCommand(qry, con)
            cmd.Parameters.AddWithValue("@accno", accountselected)
            If (cmd.ExecuteScalar > 0) Then

                MsgBox("This account has been blacklisted. Contact administrator or change account number", MsgBoxStyle.Critical)
                cbBlacklisted.Checked = True
                cbBlacklisted.Text = "ACCOUNT BLACKLISTED"
                cbBlacklisted.ForeColor = Color.Red
                gbRemDetails.Enabled = False
                txtaccountno.Focus()
            Else
                txtbank.Focus()
                MsgBox("Account is valid", MsgBoxStyle.Information)
                cbBlacklisted.Checked = False
                cbBlacklisted.Text = "ACCOUNT CLEARED"
                cbBlacklisted.ForeColor = Color.Green
                gbRemDetails.Enabled = True
            End If
            cmd.Dispose()
        Catch ex As Exception
            MsgBox("Error:" & ex.Message)
        End Try

    End Sub



    Public Sub save_transaction()
        Try
            Dim receiptno, pu As Integer
            Dim serialno, receiver, country, city, accno, bank, branch, reason As String
            Dim rate, amount, total, charge, amountpluscharge As Decimal
            Dim datesent As Date

            datesent = DateTime.Today
            rate = Convert.ToDecimal(txtrate.Text)
            amount = Convert.ToDecimal(txtamount.Text)
            charge = Convert.ToDecimal(txtcharge.Text)
            total = rate * amount
            amountpluscharge = amount + charge

            receiptno = get_last(CounterDashboard.counterno)
            serialno = "KD0000"
            receiver = txtreceiver.Text
            country = cbxcountry.Text
            city = txtcity.Text
            accno = txtaccountno.Text
            bank = txtbank.Text
            branch = txtbranch.Text
            reason = "Personal"
            pu = 0

            Dim cmd As SqlCommand
            Dim qry As String
            qry = "INSERT INTO tbltransaction (receiptno,serialno,receiver,country,city,accountno,bank,branch,totalamountsent,rate,amountsent,servicecharge,"
            qry &= "amountpluscharge,reason,pu,datesent,ic_passport,timesent,counterno) "
            qry &= "VALUES (@r1,@r2,@r3,@r4,@r5,@r6,@r7,@r8,@r9,@r10,@r11,@r12,@r13,@r14,@r15,@r16,@r17,@r18,@r19)"
            cmd = New SqlCommand(qry, con)
            cmd.Parameters.AddWithValue("@r1", receiptno)
            cmd.Parameters.AddWithValue("@r2", serialno)
            cmd.Parameters.AddWithValue("@r3", receiver)
            cmd.Parameters.AddWithValue("@r4", country)
            cmd.Parameters.AddWithValue("@r5", city)
            cmd.Parameters.AddWithValue("@r6", accno)
            cmd.Parameters.AddWithValue("@r7", bank)
            cmd.Parameters.AddWithValue("@r8", branch)
            cmd.Parameters.AddWithValue("@r9", total)
            cmd.Parameters.AddWithValue("@r10", rate)
            cmd.Parameters.AddWithValue("@r11", amount)
            cmd.Parameters.AddWithValue("@r12", charge)
            cmd.Parameters.AddWithValue("@r13", amountpluscharge)
            cmd.Parameters.AddWithValue("@r14", reason)
            cmd.Parameters.AddWithValue("@r15", pu)
            cmd.Parameters.AddWithValue("@r16", today.ToString("yyyy-MM-dd"))
            cmd.Parameters.AddWithValue("@r17", icselected)
            cmd.Parameters.AddWithValue("@r18", Format(Now, "hh:mm:ss tt"))
            cmd.Parameters.AddWithValue("@r19", CounterDashboard.counterno)

            If cmd.ExecuteNonQuery Then
                MsgBox("Transaction Completed!", MsgBoxStyle.Information)
                Dim dlreceipt = New frmPrint

                If dlreceipt.ShowDialog() = DialogResult.OK Then
                    MsgBox("Receipt Printed!", MsgBoxStyle.Information)
                    Me.Close()

                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Function get_last(ByVal counterno As Integer) As Integer
        Dim receiptno As Integer

        Try
            Dim cmd As SqlCommand
            Dim qry As String
            Dim rs As SqlDataReader
            qry = "select TOP 1(receiptno)+1 FROM tbltransaction ORDER BY receiptno DESC"
            cmd = New SqlCommand(qry, con)
            cmd.Parameters.AddWithValue("@counter", counterno)
            rs = cmd.ExecuteReader
            If (rs.HasRows) Then
                While rs.Read
                    receiptno = rs(0)
                End While

            End If
            rs.Close()
            cmd.Dispose()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        Return receiptno
    End Function

    Private Sub btnFinish_Click_1(sender As Object, e As EventArgs) Handles btnFinish.Click
        Try
            If (cbxcountry.SelectedIndex = -1) Then
                MsgBox("Select the recepient's country", MsgBoxStyle.Critical)
                cbxcountry.Focus()
            ElseIf txtcity.Text.Length = 0 Then
                MsgBox("Enter the recepient's city", MsgBoxStyle.Critical)
                txtcity.Focus()
            ElseIf txtreceiver.Text.Length = 0 Then
                MsgBox("Enter the recepient's name", MsgBoxStyle.Critical)
                txtreceiver.Focus()
            ElseIf txtaccountno.Text.Length = 0 Then
                MsgBox("Enter the recepient's account number", MsgBoxStyle.Critical)
                txtaccountno.Focus()
            ElseIf txtbank.Text.Length = 0 Then
                MsgBox("Enter the recepient's bank", MsgBoxStyle.Critical)
                txtbank.Focus()
            ElseIf txtbranch.Text.Length = 0 Then
                MsgBox("Enter the recepient's bank branch", MsgBoxStyle.Critical)
                txtbranch.Focus()
            ElseIf txtamount.Text = 0.0 Or txtamount.Text.Length = 0 Then
                MsgBox("Enter the amount to send", MsgBoxStyle.Critical)
                txtamount.Focus()

            ElseIf txtcharge.Text = 0.0 Or txtcharge.Text.Length = 0 Then
                MsgBox("Enter the service charge amount", MsgBoxStyle.Critical)
                txtcharge.Focus()
            ElseIf txtrate.Text = 0.0 Or txtrate.Text.Length = 0 Then
                MsgBox("Enter the exchange rate", MsgBoxStyle.Critical)
                txtrate.Focus()
            ElseIf txttotal.Text = 0.0 Or txttotal.Text.Length = 0 Then
                MsgBox("Click on the calculator button to calculate the total", MsgBoxStyle.Critical)
                txtcharge.Focus()

            Else
                If (Convert.ToDouble(txtamount.Text) + totalamount) >= 10000 Then
                    MsgBox("The total amount would exceed the maximum allowed remittance for this month ($10,000). Supervisor approval is required", MsgBoxStyle.Critical)
                    Dim approvaldialog = New frmapproval
                    approvaldialog.ShowDialog()
                    If (approvaldialog.msg = "yes") Then

                        save_transaction()
                    Else
                        txtamount.Focus()
                    End If


                Else
                    save_transaction()
                End If




            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btnSenderDetails_Click(sender As Object, e As EventArgs) Handles btnSenderDetails.Click
        Dim senderdialog = New frmsenderdetails
        senderdialog.icselected = lblicpassport.Text

        senderdialog.ShowDialog()

    End Sub

    Private Sub txtamount_Leave(sender As Object, e As EventArgs) Handles txtamount.Leave
        Dim rate As Double
        Dim amount As Double
        Dim total As Double
        rate = Convert.ToDecimal(txtrate.Text)
        amount = Convert.ToDecimal(txtamount.Text)
        total = rate * amount
        txttotal.Text = total.ToString("N2")
        txtamount.Text = amount.ToString("N2")
    End Sub

    Private Sub txtrate_Leave(sender As Object, e As EventArgs) Handles txtrate.Leave
        Dim rate As Double
        Dim amount As Double
        Dim total As Double
        rate = Convert.ToDecimal(txtrate.Text)
        amount = Convert.ToDecimal(txtamount.Text)
        total = rate * amount
        txttotal.Text = total.ToString("N2")
        txtrate.Text = rate.ToString("N2")
    End Sub

    Private Sub txtsearch_KeyDown(sender As Object, e As KeyEventArgs) Handles txtsearch.KeyDown
        If e.KeyCode = Keys.Enter Then
            Dim senderDialog As frmsenderlist

            If (txtsearch.Text.Length > 0) Then
                senderDialog = New frmsenderlist
                senderDialog.load_sender(txtsearch.Text)

                If (senderDialog.ShowDialog() = DialogResult.OK) Then
                    Dim index As Integer
                    index = senderDialog.lvCustomers.SelectedIndices(0)
                    icselected = senderDialog.lvCustomers.Items(index).SubItems(0).Text
                    lblicpassport.Text = senderDialog.lvCustomers.Items(index).SubItems(0).Text
                    lblsender.Text = senderDialog.lvCustomers.Items(index).SubItems(1).Text
                    gbSender.Enabled = True
                    senderDialog.Close()
                    load_remittance(icselected)

                Else
                    senderDialog.Close()
                End If

            Else
                MsgBox("Enter sender's name in the search box and press send", MsgBoxStyle.Critical)
            End If
        End If
    End Sub
End Class