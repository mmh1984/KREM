<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmRemittance
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnClose = New Guna.UI.WinForms.GunaImageButton()
        Me.GunaLabel1 = New Guna.UI.WinForms.GunaLabel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.btnSearch = New Guna.UI.WinForms.GunaButton()
        Me.txtsearch = New Guna.UI.WinForms.GunaLineTextBox()
        Me.GunaLabel3 = New Guna.UI.WinForms.GunaLabel()
        Me.gbSender = New System.Windows.Forms.Panel()
        Me.btnSenderDetails = New Guna.UI.WinForms.GunaButton()
        Me.lblsender = New Guna.UI.WinForms.GunaLabel()
        Me.GunaLabel6 = New Guna.UI.WinForms.GunaLabel()
        Me.lblicpassport = New Guna.UI.WinForms.GunaLabel()
        Me.GunaLabel2 = New Guna.UI.WinForms.GunaLabel()
        Me.GunaGroupBox1 = New Guna.UI.WinForms.GunaGroupBox()
        Me.lvremhistory = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader4 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader5 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.lblmonthyear = New Guna.UI.WinForms.GunaLabel()
        Me.GunaGroupBox3 = New Guna.UI.WinForms.GunaGroupBox()
        Me.lblremcount = New Guna.UI.WinForms.GunaLabel()
        Me.GunaGroupBox2 = New Guna.UI.WinForms.GunaGroupBox()
        Me.lblremamount = New Guna.UI.WinForms.GunaLabel()
        Me.GunaGroupBox4 = New Guna.UI.WinForms.GunaGroupBox()
        Me.lbltotalamount = New Guna.UI.WinForms.GunaLabel()
        Me.gbReceiver = New Guna.UI.WinForms.GunaGroupBox()
        Me.cbBlacklisted = New System.Windows.Forms.CheckBox()
        Me.GunaButton3 = New Guna.UI.WinForms.GunaButton()
        Me.txtcity = New Guna.UI.WinForms.GunaTextBox()
        Me.GunaLabel20 = New Guna.UI.WinForms.GunaLabel()
        Me.cbxcountry = New Guna.UI.WinForms.GunaComboBox()
        Me.GunaLabel21 = New Guna.UI.WinForms.GunaLabel()
        Me.txtbranch = New Guna.UI.WinForms.GunaTextBox()
        Me.GunaLabel16 = New Guna.UI.WinForms.GunaLabel()
        Me.txtbank = New Guna.UI.WinForms.GunaTextBox()
        Me.GunaLabel15 = New Guna.UI.WinForms.GunaLabel()
        Me.txtaccountno = New Guna.UI.WinForms.GunaTextBox()
        Me.GunaLabel14 = New Guna.UI.WinForms.GunaLabel()
        Me.txtreceiver = New Guna.UI.WinForms.GunaTextBox()
        Me.GunaLabel13 = New Guna.UI.WinForms.GunaLabel()
        Me.cbxreceiver = New Guna.UI.WinForms.GunaComboBox()
        Me.GunaLabel11 = New Guna.UI.WinForms.GunaLabel()
        Me.gbRemDetails = New Guna.UI.WinForms.GunaGroupBox()
        Me.btnFinish = New Guna.UI.WinForms.GunaButton()
        Me.txttotal = New Guna.UI.WinForms.GunaTextBox()
        Me.GunaLabel22 = New Guna.UI.WinForms.GunaLabel()
        Me.btncalculate = New Bunifu.Framework.UI.BunifuImageButton()
        Me.txtrate = New Guna.UI.WinForms.GunaTextBox()
        Me.GunaLabel17 = New Guna.UI.WinForms.GunaLabel()
        Me.txtcharge = New Guna.UI.WinForms.GunaTextBox()
        Me.GunaLabel18 = New Guna.UI.WinForms.GunaLabel()
        Me.txtamount = New Guna.UI.WinForms.GunaTextBox()
        Me.GunaLabel19 = New Guna.UI.WinForms.GunaLabel()
        Me.GunaLabel7 = New Guna.UI.WinForms.GunaLabel()
        Me.GunaLabel5 = New Guna.UI.WinForms.GunaLabel()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.gbSender.SuspendLayout()
        Me.GunaGroupBox1.SuspendLayout()
        Me.GunaGroupBox3.SuspendLayout()
        Me.GunaGroupBox2.SuspendLayout()
        Me.GunaGroupBox4.SuspendLayout()
        Me.gbReceiver.SuspendLayout()
        Me.gbRemDetails.SuspendLayout()
        CType(Me.btncalculate, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(63, Byte), Integer))
        Me.Panel1.Controls.Add(Me.btnClose)
        Me.Panel1.Controls.Add(Me.GunaLabel1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.ForeColor = System.Drawing.Color.White
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(881, 42)
        Me.Panel1.TabIndex = 3
        '
        'btnClose
        '
        Me.btnClose.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btnClose.Dock = System.Windows.Forms.DockStyle.Right
        Me.btnClose.Image = Global.KREM_SYSTEM.My.Resources.Resources._error
        Me.btnClose.ImageSize = New System.Drawing.Size(32, 32)
        Me.btnClose.Location = New System.Drawing.Point(838, 0)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.OnHoverImage = Nothing
        Me.btnClose.OnHoverImageOffset = New System.Drawing.Point(0, 0)
        Me.btnClose.Size = New System.Drawing.Size(43, 42)
        Me.btnClose.TabIndex = 1
        '
        'GunaLabel1
        '
        Me.GunaLabel1.AutoSize = True
        Me.GunaLabel1.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel1.Location = New System.Drawing.Point(12, 15)
        Me.GunaLabel1.Name = "GunaLabel1"
        Me.GunaLabel1.Size = New System.Drawing.Size(113, 15)
        Me.GunaLabel1.TabIndex = 0
        Me.GunaLabel1.Text = "Remittance Details"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Panel2.Controls.Add(Me.btnSearch)
        Me.Panel2.Controls.Add(Me.txtsearch)
        Me.Panel2.Controls.Add(Me.GunaLabel3)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 42)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(881, 61)
        Me.Panel2.TabIndex = 13
        '
        'btnSearch
        '
        Me.btnSearch.AnimationHoverSpeed = 0.07!
        Me.btnSearch.AnimationSpeed = 0.03!
        Me.btnSearch.BaseColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(160, Byte), Integer))
        Me.btnSearch.BorderColor = System.Drawing.Color.Black
        Me.btnSearch.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btnSearch.FocusedColor = System.Drawing.Color.Empty
        Me.btnSearch.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btnSearch.ForeColor = System.Drawing.Color.White
        Me.btnSearch.Image = Global.KREM_SYSTEM.My.Resources.Resources.icons8_search_50
        Me.btnSearch.ImageSize = New System.Drawing.Size(20, 20)
        Me.btnSearch.Location = New System.Drawing.Point(486, 18)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(67, Byte), Integer), CType(CType(133, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.btnSearch.OnHoverBorderColor = System.Drawing.Color.Black
        Me.btnSearch.OnHoverForeColor = System.Drawing.Color.White
        Me.btnSearch.OnHoverImage = Nothing
        Me.btnSearch.OnPressedColor = System.Drawing.Color.Black
        Me.btnSearch.Size = New System.Drawing.Size(160, 26)
        Me.btnSearch.TabIndex = 1
        Me.btnSearch.Text = "Search"
        '
        'txtsearch
        '
        Me.txtsearch.Animated = True
        Me.txtsearch.BackColor = System.Drawing.Color.White
        Me.txtsearch.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtsearch.FocusedLineColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtsearch.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtsearch.LineColor = System.Drawing.Color.Gainsboro
        Me.txtsearch.Location = New System.Drawing.Point(192, 18)
        Me.txtsearch.Name = "txtsearch"
        Me.txtsearch.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtsearch.Size = New System.Drawing.Size(288, 26)
        Me.txtsearch.TabIndex = 0
        '
        'GunaLabel3
        '
        Me.GunaLabel3.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel3.Location = New System.Drawing.Point(12, 18)
        Me.GunaLabel3.Name = "GunaLabel3"
        Me.GunaLabel3.Size = New System.Drawing.Size(183, 30)
        Me.GunaLabel3.TabIndex = 10
        Me.GunaLabel3.Text = "Search" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "(Enter sender's name or IC):"
        '
        'gbSender
        '
        Me.gbSender.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(55, Byte), Integer), CType(CType(79, Byte), Integer))
        Me.gbSender.Controls.Add(Me.btnSenderDetails)
        Me.gbSender.Controls.Add(Me.lblsender)
        Me.gbSender.Controls.Add(Me.GunaLabel6)
        Me.gbSender.Controls.Add(Me.lblicpassport)
        Me.gbSender.Controls.Add(Me.GunaLabel2)
        Me.gbSender.Dock = System.Windows.Forms.DockStyle.Top
        Me.gbSender.Location = New System.Drawing.Point(0, 103)
        Me.gbSender.Name = "gbSender"
        Me.gbSender.Size = New System.Drawing.Size(881, 26)
        Me.gbSender.TabIndex = 14
        '
        'btnSenderDetails
        '
        Me.btnSenderDetails.AnimationHoverSpeed = 0.07!
        Me.btnSenderDetails.AnimationSpeed = 0.03!
        Me.btnSenderDetails.BaseColor = System.Drawing.Color.FromArgb(CType(CType(154, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.btnSenderDetails.BorderColor = System.Drawing.Color.Black
        Me.btnSenderDetails.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btnSenderDetails.FocusedColor = System.Drawing.Color.Empty
        Me.btnSenderDetails.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btnSenderDetails.ForeColor = System.Drawing.Color.White
        Me.btnSenderDetails.Image = Global.KREM_SYSTEM.My.Resources.Resources.User_32
        Me.btnSenderDetails.ImageSize = New System.Drawing.Size(20, 20)
        Me.btnSenderDetails.Location = New System.Drawing.Point(721, 0)
        Me.btnSenderDetails.Name = "btnSenderDetails"
        Me.btnSenderDetails.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(170, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(205, Byte), Integer))
        Me.btnSenderDetails.OnHoverBorderColor = System.Drawing.Color.Black
        Me.btnSenderDetails.OnHoverForeColor = System.Drawing.Color.White
        Me.btnSenderDetails.OnHoverImage = Nothing
        Me.btnSenderDetails.OnPressedColor = System.Drawing.Color.Black
        Me.btnSenderDetails.Size = New System.Drawing.Size(160, 26)
        Me.btnSenderDetails.TabIndex = 3
        Me.btnSenderDetails.Text = "View Sender Details"
        '
        'lblsender
        '
        Me.lblsender.AutoSize = True
        Me.lblsender.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblsender.ForeColor = System.Drawing.Color.Yellow
        Me.lblsender.Location = New System.Drawing.Point(370, 4)
        Me.lblsender.Name = "lblsender"
        Me.lblsender.Size = New System.Drawing.Size(35, 15)
        Me.lblsender.TabIndex = 4
        Me.lblsender.Text = "none"
        '
        'GunaLabel6
        '
        Me.GunaLabel6.AutoSize = True
        Me.GunaLabel6.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel6.ForeColor = System.Drawing.Color.White
        Me.GunaLabel6.Location = New System.Drawing.Point(270, 4)
        Me.GunaLabel6.Name = "GunaLabel6"
        Me.GunaLabel6.Size = New System.Drawing.Size(94, 15)
        Me.GunaLabel6.TabIndex = 3
        Me.GunaLabel6.Text = "Sender's Name:"
        '
        'lblicpassport
        '
        Me.lblicpassport.AutoSize = True
        Me.lblicpassport.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblicpassport.ForeColor = System.Drawing.Color.Yellow
        Me.lblicpassport.Location = New System.Drawing.Point(88, 4)
        Me.lblicpassport.Name = "lblicpassport"
        Me.lblicpassport.Size = New System.Drawing.Size(35, 15)
        Me.lblicpassport.TabIndex = 2
        Me.lblicpassport.Text = "none"
        '
        'GunaLabel2
        '
        Me.GunaLabel2.AutoSize = True
        Me.GunaLabel2.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel2.ForeColor = System.Drawing.Color.White
        Me.GunaLabel2.Location = New System.Drawing.Point(9, 4)
        Me.GunaLabel2.Name = "GunaLabel2"
        Me.GunaLabel2.Size = New System.Drawing.Size(73, 15)
        Me.GunaLabel2.TabIndex = 1
        Me.GunaLabel2.Text = "IC/Passport:"
        '
        'GunaGroupBox1
        '
        Me.GunaGroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GunaGroupBox1.BaseColor = System.Drawing.Color.White
        Me.GunaGroupBox1.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(105, Byte), Integer), CType(CType(91, Byte), Integer))
        Me.GunaGroupBox1.Controls.Add(Me.lvremhistory)
        Me.GunaGroupBox1.Controls.Add(Me.lblmonthyear)
        Me.GunaGroupBox1.Controls.Add(Me.GunaGroupBox3)
        Me.GunaGroupBox1.Controls.Add(Me.GunaGroupBox2)
        Me.GunaGroupBox1.Controls.Add(Me.GunaGroupBox4)
        Me.GunaGroupBox1.ForeColor = System.Drawing.Color.White
        Me.GunaGroupBox1.LineColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(105, Byte), Integer), CType(CType(91, Byte), Integer))
        Me.GunaGroupBox1.LineRight = 1
        Me.GunaGroupBox1.Location = New System.Drawing.Point(0, 129)
        Me.GunaGroupBox1.Name = "GunaGroupBox1"
        Me.GunaGroupBox1.Size = New System.Drawing.Size(462, 200)
        Me.GunaGroupBox1.TabIndex = 15
        Me.GunaGroupBox1.Text = "Remittance Summary for the month of:"
        Me.GunaGroupBox1.TextLocation = New System.Drawing.Point(10, 8)
        '
        'lvremhistory
        '
        Me.lvremhistory.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lvremhistory.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3, Me.ColumnHeader4, Me.ColumnHeader5})
        Me.lvremhistory.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lvremhistory.FullRowSelect = True
        Me.lvremhistory.GridLines = True
        Me.lvremhistory.Location = New System.Drawing.Point(2, 101)
        Me.lvremhistory.Name = "lvremhistory"
        Me.lvremhistory.Size = New System.Drawing.Size(457, 95)
        Me.lvremhistory.TabIndex = 14
        Me.lvremhistory.UseCompatibleStateImageBehavior = False
        Me.lvremhistory.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "Date Sent"
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Receiver"
        Me.ColumnHeader2.Width = 120
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "Acc No"
        Me.ColumnHeader3.Width = 80
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "Bank"
        '
        'ColumnHeader5
        '
        Me.ColumnHeader5.Text = "Branch"
        Me.ColumnHeader5.Width = 100
        '
        'lblmonthyear
        '
        Me.lblmonthyear.AutoSize = True
        Me.lblmonthyear.Font = New System.Drawing.Font("Segoe UI Black", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblmonthyear.ForeColor = System.Drawing.Color.Yellow
        Me.lblmonthyear.Location = New System.Drawing.Point(214, 7)
        Me.lblmonthyear.Name = "lblmonthyear"
        Me.lblmonthyear.Size = New System.Drawing.Size(38, 15)
        Me.lblmonthyear.TabIndex = 6
        Me.lblmonthyear.Text = "none"
        '
        'GunaGroupBox3
        '
        Me.GunaGroupBox3.BackColor = System.Drawing.Color.Transparent
        Me.GunaGroupBox3.BaseColor = System.Drawing.Color.White
        Me.GunaGroupBox3.BorderColor = System.Drawing.Color.Gainsboro
        Me.GunaGroupBox3.Controls.Add(Me.lblremcount)
        Me.GunaGroupBox3.ForeColor = System.Drawing.Color.White
        Me.GunaGroupBox3.LineBottom = 1
        Me.GunaGroupBox3.LineColor = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(1, Byte), Integer))
        Me.GunaGroupBox3.LineLeft = 1
        Me.GunaGroupBox3.LineRight = 1
        Me.GunaGroupBox3.Location = New System.Drawing.Point(1, 30)
        Me.GunaGroupBox3.Name = "GunaGroupBox3"
        Me.GunaGroupBox3.Size = New System.Drawing.Size(108, 70)
        Me.GunaGroupBox3.TabIndex = 5
        Me.GunaGroupBox3.Text = "No of Remittances"
        Me.GunaGroupBox3.TextLocation = New System.Drawing.Point(10, 8)
        '
        'lblremcount
        '
        Me.lblremcount.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblremcount.ForeColor = System.Drawing.Color.DimGray
        Me.lblremcount.Location = New System.Drawing.Point(4, 38)
        Me.lblremcount.Name = "lblremcount"
        Me.lblremcount.Size = New System.Drawing.Size(107, 23)
        Me.lblremcount.TabIndex = 1
        Me.lblremcount.Text = "0"
        Me.lblremcount.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'GunaGroupBox2
        '
        Me.GunaGroupBox2.BackColor = System.Drawing.Color.Transparent
        Me.GunaGroupBox2.BaseColor = System.Drawing.Color.White
        Me.GunaGroupBox2.BorderColor = System.Drawing.Color.Gainsboro
        Me.GunaGroupBox2.Controls.Add(Me.lblremamount)
        Me.GunaGroupBox2.ForeColor = System.Drawing.Color.White
        Me.GunaGroupBox2.LineBottom = 1
        Me.GunaGroupBox2.LineColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(126, Byte), Integer), CType(CType(52, Byte), Integer))
        Me.GunaGroupBox2.LineLeft = 1
        Me.GunaGroupBox2.LineRight = 1
        Me.GunaGroupBox2.Location = New System.Drawing.Point(261, 30)
        Me.GunaGroupBox2.Name = "GunaGroupBox2"
        Me.GunaGroupBox2.Size = New System.Drawing.Size(198, 70)
        Me.GunaGroupBox2.TabIndex = 4
        Me.GunaGroupBox2.Text = "Total Remittance Amount"
        Me.GunaGroupBox2.TextLocation = New System.Drawing.Point(10, 8)
        '
        'lblremamount
        '
        Me.lblremamount.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblremamount.ForeColor = System.Drawing.Color.DimGray
        Me.lblremamount.Location = New System.Drawing.Point(17, 38)
        Me.lblremamount.Name = "lblremamount"
        Me.lblremamount.Size = New System.Drawing.Size(175, 23)
        Me.lblremamount.TabIndex = 1
        Me.lblremamount.Text = "$0.00"
        Me.lblremamount.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'GunaGroupBox4
        '
        Me.GunaGroupBox4.BackColor = System.Drawing.Color.Transparent
        Me.GunaGroupBox4.BaseColor = System.Drawing.Color.White
        Me.GunaGroupBox4.BorderColor = System.Drawing.Color.Gainsboro
        Me.GunaGroupBox4.Controls.Add(Me.lbltotalamount)
        Me.GunaGroupBox4.ForeColor = System.Drawing.Color.White
        Me.GunaGroupBox4.LineBottom = 1
        Me.GunaGroupBox4.LineColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(203, Byte), Integer))
        Me.GunaGroupBox4.LineLeft = 1
        Me.GunaGroupBox4.LineRight = 1
        Me.GunaGroupBox4.Location = New System.Drawing.Point(112, 30)
        Me.GunaGroupBox4.Name = "GunaGroupBox4"
        Me.GunaGroupBox4.Size = New System.Drawing.Size(145, 70)
        Me.GunaGroupBox4.TabIndex = 3
        Me.GunaGroupBox4.Text = "Total Amount Sent (BND)"
        Me.GunaGroupBox4.TextLocation = New System.Drawing.Point(10, 8)
        '
        'lbltotalamount
        '
        Me.lbltotalamount.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbltotalamount.ForeColor = System.Drawing.Color.DimGray
        Me.lbltotalamount.Location = New System.Drawing.Point(3, 38)
        Me.lbltotalamount.Name = "lbltotalamount"
        Me.lbltotalamount.Size = New System.Drawing.Size(123, 23)
        Me.lbltotalamount.TabIndex = 0
        Me.lbltotalamount.Text = "$0.00"
        Me.lbltotalamount.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'gbReceiver
        '
        Me.gbReceiver.BackColor = System.Drawing.Color.Transparent
        Me.gbReceiver.BaseColor = System.Drawing.Color.White
        Me.gbReceiver.BorderColor = System.Drawing.Color.Gainsboro
        Me.gbReceiver.Controls.Add(Me.cbBlacklisted)
        Me.gbReceiver.Controls.Add(Me.GunaButton3)
        Me.gbReceiver.Controls.Add(Me.txtcity)
        Me.gbReceiver.Controls.Add(Me.GunaLabel20)
        Me.gbReceiver.Controls.Add(Me.cbxcountry)
        Me.gbReceiver.Controls.Add(Me.GunaLabel21)
        Me.gbReceiver.Controls.Add(Me.txtbranch)
        Me.gbReceiver.Controls.Add(Me.GunaLabel16)
        Me.gbReceiver.Controls.Add(Me.txtbank)
        Me.gbReceiver.Controls.Add(Me.GunaLabel15)
        Me.gbReceiver.Controls.Add(Me.txtaccountno)
        Me.gbReceiver.Controls.Add(Me.GunaLabel14)
        Me.gbReceiver.Controls.Add(Me.txtreceiver)
        Me.gbReceiver.Controls.Add(Me.GunaLabel13)
        Me.gbReceiver.Controls.Add(Me.cbxreceiver)
        Me.gbReceiver.Controls.Add(Me.GunaLabel11)
        Me.gbReceiver.ForeColor = System.Drawing.Color.White
        Me.gbReceiver.LineBottom = 1
        Me.gbReceiver.LineColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(105, Byte), Integer), CType(CType(91, Byte), Integer))
        Me.gbReceiver.LineLeft = 1
        Me.gbReceiver.LineRight = 1
        Me.gbReceiver.Location = New System.Drawing.Point(1, 329)
        Me.gbReceiver.Name = "gbReceiver"
        Me.gbReceiver.Size = New System.Drawing.Size(459, 313)
        Me.gbReceiver.TabIndex = 16
        Me.gbReceiver.Text = "Receiver Details"
        Me.gbReceiver.TextLocation = New System.Drawing.Point(10, 8)
        '
        'cbBlacklisted
        '
        Me.cbBlacklisted.AutoSize = True
        Me.cbBlacklisted.BackColor = System.Drawing.Color.White
        Me.cbBlacklisted.Enabled = False
        Me.cbBlacklisted.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbBlacklisted.ForeColor = System.Drawing.Color.Black
        Me.cbBlacklisted.Location = New System.Drawing.Point(303, 204)
        Me.cbBlacklisted.Name = "cbBlacklisted"
        Me.cbBlacklisted.Size = New System.Drawing.Size(104, 17)
        Me.cbBlacklisted.TabIndex = 41
        Me.cbBlacklisted.Text = "Account Status"
        Me.cbBlacklisted.UseVisualStyleBackColor = False
        '
        'GunaButton3
        '
        Me.GunaButton3.AnimationHoverSpeed = 0.07!
        Me.GunaButton3.AnimationSpeed = 0.03!
        Me.GunaButton3.BaseColor = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(1, Byte), Integer))
        Me.GunaButton3.BorderColor = System.Drawing.Color.Black
        Me.GunaButton3.DialogResult = System.Windows.Forms.DialogResult.None
        Me.GunaButton3.FocusedColor = System.Drawing.Color.Empty
        Me.GunaButton3.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.GunaButton3.ForeColor = System.Drawing.Color.White
        Me.GunaButton3.Image = Global.KREM_SYSTEM.My.Resources.Resources.User_32
        Me.GunaButton3.ImageSize = New System.Drawing.Size(20, 20)
        Me.GunaButton3.Location = New System.Drawing.Point(105, 198)
        Me.GunaButton3.Name = "GunaButton3"
        Me.GunaButton3.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(170, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(205, Byte), Integer))
        Me.GunaButton3.OnHoverBorderColor = System.Drawing.Color.Black
        Me.GunaButton3.OnHoverForeColor = System.Drawing.Color.White
        Me.GunaButton3.OnHoverImage = Nothing
        Me.GunaButton3.OnPressedColor = System.Drawing.Color.Black
        Me.GunaButton3.Size = New System.Drawing.Size(182, 26)
        Me.GunaButton3.TabIndex = 9
        Me.GunaButton3.Text = "Check Account Number"
        '
        'txtcity
        '
        Me.txtcity.BaseColor = System.Drawing.Color.White
        Me.txtcity.BorderColor = System.Drawing.Color.Silver
        Me.txtcity.BorderSize = 1
        Me.txtcity.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtcity.FocusedBaseColor = System.Drawing.Color.White
        Me.txtcity.FocusedBorderColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtcity.FocusedForeColor = System.Drawing.SystemColors.ControlText
        Me.txtcity.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtcity.ForeColor = System.Drawing.Color.Black
        Me.txtcity.Location = New System.Drawing.Point(105, 65)
        Me.txtcity.MaxLength = 128
        Me.txtcity.Name = "txtcity"
        Me.txtcity.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtcity.Size = New System.Drawing.Size(336, 30)
        Me.txtcity.TabIndex = 5
        '
        'GunaLabel20
        '
        Me.GunaLabel20.AutoSize = True
        Me.GunaLabel20.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.GunaLabel20.ForeColor = System.Drawing.Color.Black
        Me.GunaLabel20.Location = New System.Drawing.Point(12, 71)
        Me.GunaLabel20.Name = "GunaLabel20"
        Me.GunaLabel20.Size = New System.Drawing.Size(28, 15)
        Me.GunaLabel20.TabIndex = 38
        Me.GunaLabel20.Text = "City"
        '
        'cbxcountry
        '
        Me.cbxcountry.BackColor = System.Drawing.Color.Transparent
        Me.cbxcountry.BaseColor = System.Drawing.Color.White
        Me.cbxcountry.BorderColor = System.Drawing.Color.Silver
        Me.cbxcountry.BorderSize = 1
        Me.cbxcountry.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cbxcountry.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbxcountry.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cbxcountry.FocusedColor = System.Drawing.Color.Empty
        Me.cbxcountry.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.cbxcountry.ForeColor = System.Drawing.Color.Black
        Me.cbxcountry.FormattingEnabled = True
        Me.cbxcountry.Items.AddRange(New Object() {"Indonesia", "Brunei", "Malaysia", "Philippines", "Thailand", "Indonesia"})
        Me.cbxcountry.Location = New System.Drawing.Point(105, 37)
        Me.cbxcountry.Name = "cbxcountry"
        Me.cbxcountry.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cbxcountry.OnHoverItemForeColor = System.Drawing.Color.White
        Me.cbxcountry.Size = New System.Drawing.Size(336, 26)
        Me.cbxcountry.TabIndex = 4
        '
        'GunaLabel21
        '
        Me.GunaLabel21.AutoSize = True
        Me.GunaLabel21.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.GunaLabel21.ForeColor = System.Drawing.Color.Black
        Me.GunaLabel21.Location = New System.Drawing.Point(12, 42)
        Me.GunaLabel21.Name = "GunaLabel21"
        Me.GunaLabel21.Size = New System.Drawing.Size(50, 15)
        Me.GunaLabel21.TabIndex = 36
        Me.GunaLabel21.Text = "Country"
        '
        'txtbranch
        '
        Me.txtbranch.BaseColor = System.Drawing.Color.White
        Me.txtbranch.BorderColor = System.Drawing.Color.Silver
        Me.txtbranch.BorderSize = 1
        Me.txtbranch.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtbranch.FocusedBaseColor = System.Drawing.Color.White
        Me.txtbranch.FocusedBorderColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtbranch.FocusedForeColor = System.Drawing.SystemColors.ControlText
        Me.txtbranch.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtbranch.ForeColor = System.Drawing.Color.Black
        Me.txtbranch.Location = New System.Drawing.Point(105, 269)
        Me.txtbranch.MaxLength = 128
        Me.txtbranch.Name = "txtbranch"
        Me.txtbranch.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtbranch.Size = New System.Drawing.Size(336, 30)
        Me.txtbranch.TabIndex = 11
        '
        'GunaLabel16
        '
        Me.GunaLabel16.AutoSize = True
        Me.GunaLabel16.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.GunaLabel16.ForeColor = System.Drawing.Color.Black
        Me.GunaLabel16.Location = New System.Drawing.Point(12, 276)
        Me.GunaLabel16.Name = "GunaLabel16"
        Me.GunaLabel16.Size = New System.Drawing.Size(44, 15)
        Me.GunaLabel16.TabIndex = 34
        Me.GunaLabel16.Text = "Branch"
        '
        'txtbank
        '
        Me.txtbank.BaseColor = System.Drawing.Color.White
        Me.txtbank.BorderColor = System.Drawing.Color.Silver
        Me.txtbank.BorderSize = 1
        Me.txtbank.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtbank.FocusedBaseColor = System.Drawing.Color.White
        Me.txtbank.FocusedBorderColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtbank.FocusedForeColor = System.Drawing.SystemColors.ControlText
        Me.txtbank.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtbank.ForeColor = System.Drawing.Color.Black
        Me.txtbank.Location = New System.Drawing.Point(105, 237)
        Me.txtbank.MaxLength = 128
        Me.txtbank.Name = "txtbank"
        Me.txtbank.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtbank.Size = New System.Drawing.Size(336, 30)
        Me.txtbank.TabIndex = 10
        '
        'GunaLabel15
        '
        Me.GunaLabel15.AutoSize = True
        Me.GunaLabel15.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.GunaLabel15.ForeColor = System.Drawing.Color.Black
        Me.GunaLabel15.Location = New System.Drawing.Point(12, 243)
        Me.GunaLabel15.Name = "GunaLabel15"
        Me.GunaLabel15.Size = New System.Drawing.Size(33, 15)
        Me.GunaLabel15.TabIndex = 32
        Me.GunaLabel15.Text = "Bank"
        '
        'txtaccountno
        '
        Me.txtaccountno.BaseColor = System.Drawing.Color.White
        Me.txtaccountno.BorderColor = System.Drawing.Color.Silver
        Me.txtaccountno.BorderSize = 1
        Me.txtaccountno.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtaccountno.FocusedBaseColor = System.Drawing.Color.White
        Me.txtaccountno.FocusedBorderColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtaccountno.FocusedForeColor = System.Drawing.SystemColors.ControlText
        Me.txtaccountno.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtaccountno.ForeColor = System.Drawing.Color.Black
        Me.txtaccountno.Location = New System.Drawing.Point(105, 158)
        Me.txtaccountno.MaxLength = 128
        Me.txtaccountno.Name = "txtaccountno"
        Me.txtaccountno.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtaccountno.Size = New System.Drawing.Size(336, 30)
        Me.txtaccountno.TabIndex = 8
        '
        'GunaLabel14
        '
        Me.GunaLabel14.AutoSize = True
        Me.GunaLabel14.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.GunaLabel14.ForeColor = System.Drawing.Color.Black
        Me.GunaLabel14.Location = New System.Drawing.Point(12, 164)
        Me.GunaLabel14.Name = "GunaLabel14"
        Me.GunaLabel14.Size = New System.Drawing.Size(62, 15)
        Me.GunaLabel14.TabIndex = 30
        Me.GunaLabel14.Text = "Account #"
        '
        'txtreceiver
        '
        Me.txtreceiver.BaseColor = System.Drawing.Color.White
        Me.txtreceiver.BorderColor = System.Drawing.Color.Silver
        Me.txtreceiver.BorderSize = 1
        Me.txtreceiver.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtreceiver.Enabled = False
        Me.txtreceiver.FocusedBaseColor = System.Drawing.Color.White
        Me.txtreceiver.FocusedBorderColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtreceiver.FocusedForeColor = System.Drawing.SystemColors.ControlText
        Me.txtreceiver.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtreceiver.ForeColor = System.Drawing.Color.Black
        Me.txtreceiver.Location = New System.Drawing.Point(105, 125)
        Me.txtreceiver.MaxLength = 128
        Me.txtreceiver.Name = "txtreceiver"
        Me.txtreceiver.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtreceiver.Size = New System.Drawing.Size(336, 30)
        Me.txtreceiver.TabIndex = 7
        '
        'GunaLabel13
        '
        Me.GunaLabel13.AutoSize = True
        Me.GunaLabel13.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.GunaLabel13.ForeColor = System.Drawing.Color.Black
        Me.GunaLabel13.Location = New System.Drawing.Point(12, 131)
        Me.GunaLabel13.Name = "GunaLabel13"
        Me.GunaLabel13.Size = New System.Drawing.Size(39, 15)
        Me.GunaLabel13.TabIndex = 28
        Me.GunaLabel13.Text = "Name"
        '
        'cbxreceiver
        '
        Me.cbxreceiver.BackColor = System.Drawing.Color.Transparent
        Me.cbxreceiver.BaseColor = System.Drawing.Color.White
        Me.cbxreceiver.BorderColor = System.Drawing.Color.Silver
        Me.cbxreceiver.BorderSize = 1
        Me.cbxreceiver.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cbxreceiver.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbxreceiver.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cbxreceiver.FocusedColor = System.Drawing.Color.Empty
        Me.cbxreceiver.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.cbxreceiver.ForeColor = System.Drawing.Color.Black
        Me.cbxreceiver.FormattingEnabled = True
        Me.cbxreceiver.Location = New System.Drawing.Point(105, 97)
        Me.cbxreceiver.Name = "cbxreceiver"
        Me.cbxreceiver.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cbxreceiver.OnHoverItemForeColor = System.Drawing.Color.White
        Me.cbxreceiver.Size = New System.Drawing.Size(336, 26)
        Me.cbxreceiver.TabIndex = 6
        '
        'GunaLabel11
        '
        Me.GunaLabel11.AutoSize = True
        Me.GunaLabel11.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.GunaLabel11.ForeColor = System.Drawing.Color.Black
        Me.GunaLabel11.Location = New System.Drawing.Point(12, 102)
        Me.GunaLabel11.Name = "GunaLabel11"
        Me.GunaLabel11.Size = New System.Drawing.Size(51, 15)
        Me.GunaLabel11.TabIndex = 26
        Me.GunaLabel11.Text = "Receiver"
        '
        'gbRemDetails
        '
        Me.gbRemDetails.BackColor = System.Drawing.Color.Transparent
        Me.gbRemDetails.BaseColor = System.Drawing.Color.White
        Me.gbRemDetails.BorderColor = System.Drawing.Color.Gainsboro
        Me.gbRemDetails.Controls.Add(Me.btnFinish)
        Me.gbRemDetails.Controls.Add(Me.txttotal)
        Me.gbRemDetails.Controls.Add(Me.GunaLabel22)
        Me.gbRemDetails.Controls.Add(Me.btncalculate)
        Me.gbRemDetails.Controls.Add(Me.txtrate)
        Me.gbRemDetails.Controls.Add(Me.GunaLabel17)
        Me.gbRemDetails.Controls.Add(Me.txtcharge)
        Me.gbRemDetails.Controls.Add(Me.GunaLabel18)
        Me.gbRemDetails.Controls.Add(Me.txtamount)
        Me.gbRemDetails.Controls.Add(Me.GunaLabel19)
        Me.gbRemDetails.Enabled = False
        Me.gbRemDetails.Font = New System.Drawing.Font("Segoe UI Semibold", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbRemDetails.ForeColor = System.Drawing.Color.White
        Me.gbRemDetails.LineBottom = 1
        Me.gbRemDetails.LineColor = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(1, Byte), Integer))
        Me.gbRemDetails.LineLeft = 1
        Me.gbRemDetails.LineRight = 1
        Me.gbRemDetails.Location = New System.Drawing.Point(462, 129)
        Me.gbRemDetails.Name = "gbRemDetails"
        Me.gbRemDetails.Size = New System.Drawing.Size(415, 286)
        Me.gbRemDetails.TabIndex = 17
        Me.gbRemDetails.Text = "Amount"
        Me.gbRemDetails.TextLocation = New System.Drawing.Point(10, 8)
        '
        'btnFinish
        '
        Me.btnFinish.AnimationHoverSpeed = 0.07!
        Me.btnFinish.AnimationSpeed = 0.03!
        Me.btnFinish.BaseColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(126, Byte), Integer), CType(CType(52, Byte), Integer))
        Me.btnFinish.BorderColor = System.Drawing.Color.Black
        Me.btnFinish.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btnFinish.FocusedColor = System.Drawing.Color.Empty
        Me.btnFinish.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btnFinish.ForeColor = System.Drawing.Color.White
        Me.btnFinish.Image = Global.KREM_SYSTEM.My.Resources.Resources.printer
        Me.btnFinish.ImageSize = New System.Drawing.Size(30, 30)
        Me.btnFinish.Location = New System.Drawing.Point(249, 225)
        Me.btnFinish.Name = "btnFinish"
        Me.btnFinish.OnHoverBaseColor = System.Drawing.Color.Lime
        Me.btnFinish.OnHoverBorderColor = System.Drawing.Color.Black
        Me.btnFinish.OnHoverForeColor = System.Drawing.Color.White
        Me.btnFinish.OnHoverImage = Nothing
        Me.btnFinish.OnPressedColor = System.Drawing.Color.Black
        Me.btnFinish.Size = New System.Drawing.Size(147, 47)
        Me.btnFinish.TabIndex = 16
        Me.btnFinish.Text = "Finish and Print"
        '
        'txttotal
        '
        Me.txttotal.BaseColor = System.Drawing.Color.WhiteSmoke
        Me.txttotal.BorderColor = System.Drawing.Color.Silver
        Me.txttotal.BorderSize = 1
        Me.txttotal.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txttotal.Enabled = False
        Me.txttotal.FocusedBaseColor = System.Drawing.Color.White
        Me.txttotal.FocusedBorderColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txttotal.FocusedForeColor = System.Drawing.SystemColors.ControlText
        Me.txttotal.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txttotal.ForeColor = System.Drawing.Color.Black
        Me.txttotal.Location = New System.Drawing.Point(133, 187)
        Me.txttotal.MaxLength = 128
        Me.txttotal.Name = "txttotal"
        Me.txttotal.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txttotal.Size = New System.Drawing.Size(262, 32)
        Me.txttotal.TabIndex = 15
        Me.txttotal.Text = "0.0"
        '
        'GunaLabel22
        '
        Me.GunaLabel22.AutoSize = True
        Me.GunaLabel22.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel22.ForeColor = System.Drawing.Color.Black
        Me.GunaLabel22.Location = New System.Drawing.Point(4, 195)
        Me.GunaLabel22.Name = "GunaLabel22"
        Me.GunaLabel22.Size = New System.Drawing.Size(59, 21)
        Me.GunaLabel22.TabIndex = 37
        Me.GunaLabel22.Text = "Rupiah"
        '
        'btncalculate
        '
        Me.btncalculate.BackColor = System.Drawing.Color.White
        Me.btncalculate.Image = Global.KREM_SYSTEM.My.Resources.Resources.icons8_estimate_50
        Me.btncalculate.ImageActive = Nothing
        Me.btncalculate.Location = New System.Drawing.Point(133, 149)
        Me.btncalculate.Name = "btncalculate"
        Me.btncalculate.Size = New System.Drawing.Size(51, 32)
        Me.btncalculate.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.btncalculate.TabIndex = 36
        Me.btncalculate.TabStop = False
        Me.btncalculate.Zoom = 10
        '
        'txtrate
        '
        Me.txtrate.BaseColor = System.Drawing.Color.WhiteSmoke
        Me.txtrate.BorderColor = System.Drawing.Color.Silver
        Me.txtrate.BorderSize = 1
        Me.txtrate.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtrate.FocusedBaseColor = System.Drawing.Color.White
        Me.txtrate.FocusedBorderColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtrate.FocusedForeColor = System.Drawing.SystemColors.ControlText
        Me.txtrate.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtrate.ForeColor = System.Drawing.Color.Black
        Me.txtrate.Location = New System.Drawing.Point(134, 111)
        Me.txtrate.MaxLength = 128
        Me.txtrate.Name = "txtrate"
        Me.txtrate.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtrate.Size = New System.Drawing.Size(262, 32)
        Me.txtrate.TabIndex = 14
        Me.txtrate.Text = "0.0"
        '
        'GunaLabel17
        '
        Me.GunaLabel17.AutoSize = True
        Me.GunaLabel17.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel17.ForeColor = System.Drawing.Color.Black
        Me.GunaLabel17.Location = New System.Drawing.Point(5, 119)
        Me.GunaLabel17.Name = "GunaLabel17"
        Me.GunaLabel17.Size = New System.Drawing.Size(123, 21)
        Me.GunaLabel17.TabIndex = 34
        Me.GunaLabel17.Text = "Petukaran Wang"
        '
        'txtcharge
        '
        Me.txtcharge.BaseColor = System.Drawing.Color.WhiteSmoke
        Me.txtcharge.BorderColor = System.Drawing.Color.Silver
        Me.txtcharge.BorderSize = 1
        Me.txtcharge.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtcharge.FocusedBaseColor = System.Drawing.Color.White
        Me.txtcharge.FocusedBorderColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtcharge.FocusedForeColor = System.Drawing.SystemColors.ControlText
        Me.txtcharge.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtcharge.ForeColor = System.Drawing.Color.Black
        Me.txtcharge.Location = New System.Drawing.Point(134, 73)
        Me.txtcharge.MaxLength = 128
        Me.txtcharge.Name = "txtcharge"
        Me.txtcharge.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtcharge.Size = New System.Drawing.Size(262, 32)
        Me.txtcharge.TabIndex = 13
        Me.txtcharge.Text = "0.0"
        '
        'GunaLabel18
        '
        Me.GunaLabel18.AutoSize = True
        Me.GunaLabel18.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel18.ForeColor = System.Drawing.Color.Black
        Me.GunaLabel18.Location = New System.Drawing.Point(5, 80)
        Me.GunaLabel18.Name = "GunaLabel18"
        Me.GunaLabel18.Size = New System.Drawing.Size(114, 21)
        Me.GunaLabel18.TabIndex = 32
        Me.GunaLabel18.Text = "Service Charge"
        '
        'txtamount
        '
        Me.txtamount.BaseColor = System.Drawing.Color.WhiteSmoke
        Me.txtamount.BorderColor = System.Drawing.Color.Silver
        Me.txtamount.BorderSize = 1
        Me.txtamount.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtamount.FocusedBaseColor = System.Drawing.Color.White
        Me.txtamount.FocusedBorderColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtamount.FocusedForeColor = System.Drawing.SystemColors.ControlText
        Me.txtamount.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtamount.ForeColor = System.Drawing.Color.Black
        Me.txtamount.Location = New System.Drawing.Point(134, 35)
        Me.txtamount.MaxLength = 128
        Me.txtamount.Name = "txtamount"
        Me.txtamount.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtamount.Size = New System.Drawing.Size(261, 32)
        Me.txtamount.TabIndex = 12
        Me.txtamount.Text = "0.0"
        '
        'GunaLabel19
        '
        Me.GunaLabel19.AutoSize = True
        Me.GunaLabel19.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel19.ForeColor = System.Drawing.Color.Black
        Me.GunaLabel19.Location = New System.Drawing.Point(5, 41)
        Me.GunaLabel19.Name = "GunaLabel19"
        Me.GunaLabel19.Size = New System.Drawing.Size(42, 21)
        Me.GunaLabel19.TabIndex = 30
        Me.GunaLabel19.Text = "BND"
        '
        'GunaLabel7
        '
        Me.GunaLabel7.AutoSize = True
        Me.GunaLabel7.Font = New System.Drawing.Font("Adobe Gothic Std B", 15.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.GunaLabel7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.GunaLabel7.Location = New System.Drawing.Point(591, 423)
        Me.GunaLabel7.Name = "GunaLabel7"
        Me.GunaLabel7.Size = New System.Drawing.Size(144, 26)
        Me.GunaLabel7.TabIndex = 19
        Me.GunaLabel7.Text = "***NOTICE***"
        '
        'GunaLabel5
        '
        Me.GunaLabel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.GunaLabel5.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.GunaLabel5.Location = New System.Drawing.Point(462, 430)
        Me.GunaLabel5.Name = "GunaLabel5"
        Me.GunaLabel5.Size = New System.Drawing.Size(415, 100)
        Me.GunaLabel5.TabIndex = 18
        Me.GunaLabel5.Text = "" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Maximum remittances such as telegraphic transfers to overseas bank is $10,000" &
    " (TEN THOUSAND) Brunei Dollars on a single month"
        '
        'frmRemittance
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(881, 647)
        Me.Controls.Add(Me.GunaLabel7)
        Me.Controls.Add(Me.GunaLabel5)
        Me.Controls.Add(Me.gbRemDetails)
        Me.Controls.Add(Me.gbReceiver)
        Me.Controls.Add(Me.GunaGroupBox1)
        Me.Controls.Add(Me.gbSender)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmRemittance"
        Me.Text = "frmRemittance"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.gbSender.ResumeLayout(False)
        Me.gbSender.PerformLayout()
        Me.GunaGroupBox1.ResumeLayout(False)
        Me.GunaGroupBox1.PerformLayout()
        Me.GunaGroupBox3.ResumeLayout(False)
        Me.GunaGroupBox2.ResumeLayout(False)
        Me.GunaGroupBox4.ResumeLayout(False)
        Me.gbReceiver.ResumeLayout(False)
        Me.gbReceiver.PerformLayout()
        Me.gbRemDetails.ResumeLayout(False)
        Me.gbRemDetails.PerformLayout()
        CType(Me.btncalculate, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents btnClose As Guna.UI.WinForms.GunaImageButton
    Friend WithEvents GunaLabel1 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents btnSearch As Guna.UI.WinForms.GunaButton
    Friend WithEvents txtsearch As Guna.UI.WinForms.GunaLineTextBox
    Friend WithEvents GunaLabel3 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents gbSender As Panel
    Friend WithEvents lblsender As Guna.UI.WinForms.GunaLabel
    Friend WithEvents GunaLabel6 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents lblicpassport As Guna.UI.WinForms.GunaLabel
    Friend WithEvents GunaLabel2 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents btnSenderDetails As Guna.UI.WinForms.GunaButton
    Friend WithEvents GunaGroupBox1 As Guna.UI.WinForms.GunaGroupBox
    Friend WithEvents GunaGroupBox3 As Guna.UI.WinForms.GunaGroupBox
    Friend WithEvents lblremcount As Guna.UI.WinForms.GunaLabel
    Friend WithEvents GunaGroupBox2 As Guna.UI.WinForms.GunaGroupBox
    Friend WithEvents lblremamount As Guna.UI.WinForms.GunaLabel
    Friend WithEvents GunaGroupBox4 As Guna.UI.WinForms.GunaGroupBox
    Friend WithEvents lbltotalamount As Guna.UI.WinForms.GunaLabel
    Friend WithEvents lblmonthyear As Guna.UI.WinForms.GunaLabel
    Friend WithEvents lvremhistory As ListView
    Friend WithEvents ColumnHeader1 As ColumnHeader
    Friend WithEvents ColumnHeader2 As ColumnHeader
    Friend WithEvents ColumnHeader3 As ColumnHeader
    Friend WithEvents ColumnHeader4 As ColumnHeader
    Friend WithEvents ColumnHeader5 As ColumnHeader
    Friend WithEvents gbReceiver As Guna.UI.WinForms.GunaGroupBox
    Friend WithEvents txtcity As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents GunaLabel20 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents cbxcountry As Guna.UI.WinForms.GunaComboBox
    Friend WithEvents GunaLabel21 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents txtbranch As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents GunaLabel16 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents txtbank As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents GunaLabel15 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents txtaccountno As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents GunaLabel14 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents txtreceiver As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents GunaLabel13 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents cbxreceiver As Guna.UI.WinForms.GunaComboBox
    Friend WithEvents GunaLabel11 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents gbRemDetails As Guna.UI.WinForms.GunaGroupBox
    Friend WithEvents txttotal As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents GunaLabel22 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents btncalculate As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents txtrate As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents GunaLabel17 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents txtcharge As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents GunaLabel18 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents txtamount As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents GunaLabel19 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents GunaLabel7 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents GunaLabel5 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents GunaButton3 As Guna.UI.WinForms.GunaButton
    Friend WithEvents cbBlacklisted As CheckBox
    Friend WithEvents btnFinish As Guna.UI.WinForms.GunaButton
End Class
