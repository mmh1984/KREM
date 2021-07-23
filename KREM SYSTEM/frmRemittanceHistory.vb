Imports System.Data.SqlClient
Public Class frmRemittanceHistory
    Public icselected As String
    Dim con As SqlConnection
    Dim totalremittance, totalamount As Double
    Dim totaltransactionas As Integer
    Dim filtertype As Integer
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

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        search_rem()

    End Sub
    Private Sub search_rem()
        Dim senderDialog As frmsenderlist
        datefilterpanel.Enabled = False
        If (txtsearch.Text.Length > 0) Then
            senderDialog = New frmsenderlist
            senderDialog.load_sender(txtsearch.Text)

            If (senderDialog.ShowDialog() = DialogResult.OK) Then
                Dim index As Integer
                index = senderDialog.lvCustomers.SelectedIndices(0)
                icselected = senderDialog.lvCustomers.Items(index).SubItems(0).Text
                lblicpassport.Text = senderDialog.lvCustomers.Items(index).SubItems(0).Text
                lblsender.Text = senderDialog.lvCustomers.Items(index).SubItems(1).Text
                senderDialog.Close()
                load_remittance(icselected, False)

            Else
                senderDialog.Close()
            End If

        Else
            MsgBox("Enter sender's name in the search box and press send", MsgBoxStyle.Critical)
        End If
    End Sub
    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
        con.Close()
    End Sub

    Public Sub load_remittance(ByVal stric As String, ByVal filter As Boolean)
        Try


            Dim cmd As SqlCommand
            Dim qry As String
            Dim rs As SqlDataReader
            If (filter = False) Then
                qry = "SELECT * FROM tbltransaction WHERE ic_passport=@ic ORDER BY datesent DESC"
                cmd = New SqlCommand(qry, con)
                cmd.Parameters.AddWithValue("@ic", stric)
                filtertype = 0
            Else
                qry = "SELECT * FROM tbltransaction WHERE ic_passport=@ic AND (datesent BETWEEN @start AND @end)"
                cmd = New SqlCommand(qry, con)
                cmd.Parameters.AddWithValue("@ic", stric)
                cmd.Parameters.AddWithValue("@start", dtstart.Value.ToString("yyyy-MM-dd"))
                cmd.Parameters.AddWithValue("@end", dtend.Value.ToString("yyyy-MM-dd"))
                filtertype = 1
            End If

            rs = cmd.ExecuteReader
            Dim remlist As ListViewItem
            lvremhistory.Items.Clear()
            totalamount = 0.0
            totalremittance = 0.0
            totaltransactionas = 0
            If rs.HasRows Then
                btnPrint.Visible = True
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
                datefilterpanel.Enabled = True
                rs.Close()
                cmd.Dispose()

            Else
                MsgBox("There are currently no remittances from this sender", MsgBoxStyle.Information)
                btnPrint.Visible = False

            End If
            display_summary()
        Catch ex As Exception
            MsgBox("Load Remittance: " & ex.Message)
        End Try
    End Sub

    Private Sub btnsearchdate_Click(sender As Object, e As EventArgs) Handles btnsearchdate.Click
        Dim startdate As Date
        Dim enddate As Date
        startdate = dtStart.Value
        enddate = dtEnd.Value




        load_remittance(icselected, True)



    End Sub

    Private Sub btnrefresh_Click(sender As Object, e As EventArgs) Handles btnrefresh.Click
        load_remittance(icselected, False)
    End Sub

    Public Sub display_summary()
        lblremamount.Text = totalremittance.ToString("C")
        lbltotalamount.Text = totalamount.ToString("C")
        lblremcount.Text = totaltransactionas
    End Sub

    Private Sub btnPrint_Click(sender As Object, e As EventArgs) Handles btnPrint.Click
        Dim frmreport = New frmRemittanceReport
        If (filtertype = 0) Then
            frmreport.load_report(icselected)
        Else
            Dim sDate, eDate As Date
            sDate = dtstart.Value
            eDate = dtend.Value
            frmreport.load_report2(icselected, sDate, eDate)
        End If
        If (frmreport.ShowDialog() = DialogResult.Cancel) Then
            frmreport.Close()

        End If

    End Sub

    Private Sub txtsearch_TextChanged(sender As Object, e As EventArgs) Handles txtsearch.TextChanged

    End Sub

    Private Sub frmRemittanceHistory_Load(sender As Object, e As EventArgs) Handles Me.Load
        datefilterpanel.Enabled = False
        dtend.Value = DateTime.Now
        dtstart.Value = (DateTime.Now.AddDays(-5))
        btnPrint.Visible = False
        load_connection()

    End Sub

    Private Sub txtsearch_KeyDown(sender As Object, e As KeyEventArgs) Handles txtsearch.KeyDown
        If e.KeyCode = Keys.Enter Then
            search_rem()
        End If
    End Sub
End Class