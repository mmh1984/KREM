<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmRemittanceHistory
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
        Me.components = New System.ComponentModel.Container()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.BWorker = New System.ComponentModel.BackgroundWorker()
        Me.mainpanel = New System.Windows.Forms.Panel()
        Me.detailspanel = New System.Windows.Forms.Panel()
        Me.datefilterpanel = New Guna.UI.WinForms.GunaGroupBox()
        Me.btnrefresh = New Guna.UI.WinForms.GunaButton()
        Me.btnsearchdate = New Guna.UI.WinForms.GunaButton()
        Me.GunaLabel5 = New Guna.UI.WinForms.GunaLabel()
        Me.dtend = New Guna.UI.WinForms.GunaDateTimePicker()
        Me.GunaLabel4 = New Guna.UI.WinForms.GunaLabel()
        Me.dtstart = New Guna.UI.WinForms.GunaDateTimePicker()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.lblsender = New Guna.UI.WinForms.GunaLabel()
        Me.GunaLabel6 = New Guna.UI.WinForms.GunaLabel()
        Me.lblicpassport = New Guna.UI.WinForms.GunaLabel()
        Me.GunaLabel2 = New Guna.UI.WinForms.GunaLabel()
        Me.GunaGroupBox3 = New Guna.UI.WinForms.GunaGroupBox()
        Me.lblremcount = New Guna.UI.WinForms.GunaLabel()
        Me.GunaGroupBox2 = New Guna.UI.WinForms.GunaGroupBox()
        Me.lblremamount = New Guna.UI.WinForms.GunaLabel()
        Me.GunaGroupBox1 = New Guna.UI.WinForms.GunaGroupBox()
        Me.lbltotalamount = New Guna.UI.WinForms.GunaLabel()
        Me.lvremhistory = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader4 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader5 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader6 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader7 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader8 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader9 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.btnPrint = New Guna.UI.WinForms.GunaImageButton()
        Me.btnSearch = New Guna.UI.WinForms.GunaButton()
        Me.txtsearch = New Guna.UI.WinForms.GunaLineTextBox()
        Me.GunaLabel3 = New Guna.UI.WinForms.GunaLabel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnClose = New Guna.UI.WinForms.GunaImageButton()
        Me.GunaLabel1 = New Guna.UI.WinForms.GunaLabel()
        Me.contentpanel = New System.Windows.Forms.Panel()
        Me.mainpanel.SuspendLayout()
        Me.detailspanel.SuspendLayout()
        Me.datefilterpanel.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.GunaGroupBox3.SuspendLayout()
        Me.GunaGroupBox2.SuspendLayout()
        Me.GunaGroupBox1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.contentpanel.SuspendLayout()
        Me.SuspendLayout()
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 1000
        '
        'mainpanel
        '
        Me.mainpanel.Controls.Add(Me.detailspanel)
        Me.mainpanel.Controls.Add(Me.lvremhistory)
        Me.mainpanel.Controls.Add(Me.Panel2)
        Me.mainpanel.Controls.Add(Me.Panel1)
        Me.mainpanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.mainpanel.Location = New System.Drawing.Point(0, 0)
        Me.mainpanel.Name = "mainpanel"
        Me.mainpanel.Size = New System.Drawing.Size(881, 647)
        Me.mainpanel.TabIndex = 0
        '
        'detailspanel
        '
        Me.detailspanel.Controls.Add(Me.datefilterpanel)
        Me.detailspanel.Controls.Add(Me.Panel4)
        Me.detailspanel.Controls.Add(Me.GunaGroupBox3)
        Me.detailspanel.Controls.Add(Me.GunaGroupBox2)
        Me.detailspanel.Controls.Add(Me.GunaGroupBox1)
        Me.detailspanel.Dock = System.Windows.Forms.DockStyle.Top
        Me.detailspanel.Location = New System.Drawing.Point(0, 101)
        Me.detailspanel.Name = "detailspanel"
        Me.detailspanel.Size = New System.Drawing.Size(881, 121)
        Me.detailspanel.TabIndex = 14
        '
        'datefilterpanel
        '
        Me.datefilterpanel.BackColor = System.Drawing.Color.Transparent
        Me.datefilterpanel.BaseColor = System.Drawing.Color.White
        Me.datefilterpanel.BorderColor = System.Drawing.Color.Gainsboro
        Me.datefilterpanel.Controls.Add(Me.btnrefresh)
        Me.datefilterpanel.Controls.Add(Me.btnsearchdate)
        Me.datefilterpanel.Controls.Add(Me.GunaLabel5)
        Me.datefilterpanel.Controls.Add(Me.dtend)
        Me.datefilterpanel.Controls.Add(Me.GunaLabel4)
        Me.datefilterpanel.Controls.Add(Me.dtstart)
        Me.datefilterpanel.LineBottom = 1
        Me.datefilterpanel.LineColor = System.Drawing.Color.Gainsboro
        Me.datefilterpanel.LineLeft = 1
        Me.datefilterpanel.LineRight = 1
        Me.datefilterpanel.Location = New System.Drawing.Point(3, 22)
        Me.datefilterpanel.Name = "datefilterpanel"
        Me.datefilterpanel.Size = New System.Drawing.Size(361, 99)
        Me.datefilterpanel.TabIndex = 4
        Me.datefilterpanel.Text = "Filter by Date"
        Me.datefilterpanel.TextLocation = New System.Drawing.Point(10, 8)
        '
        'btnrefresh
        '
        Me.btnrefresh.AnimationHoverSpeed = 0.07!
        Me.btnrefresh.AnimationSpeed = 0.03!
        Me.btnrefresh.BaseColor = System.Drawing.Color.White
        Me.btnrefresh.BorderColor = System.Drawing.Color.Black
        Me.btnrefresh.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btnrefresh.FocusedColor = System.Drawing.Color.Empty
        Me.btnrefresh.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btnrefresh.ForeColor = System.Drawing.Color.White
        Me.btnrefresh.Image = Global.KREM_SYSTEM.My.Resources.Resources.refresh_32
        Me.btnrefresh.ImageSize = New System.Drawing.Size(20, 20)
        Me.btnrefresh.Location = New System.Drawing.Point(296, 66)
        Me.btnrefresh.Name = "btnrefresh"
        Me.btnrefresh.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(151, Byte), Integer), CType(CType(143, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnrefresh.OnHoverBorderColor = System.Drawing.Color.Black
        Me.btnrefresh.OnHoverForeColor = System.Drawing.Color.White
        Me.btnrefresh.OnHoverImage = Nothing
        Me.btnrefresh.OnPressedColor = System.Drawing.Color.Black
        Me.btnrefresh.Size = New System.Drawing.Size(46, 30)
        Me.btnrefresh.TabIndex = 5
        '
        'btnsearchdate
        '
        Me.btnsearchdate.AnimationHoverSpeed = 0.07!
        Me.btnsearchdate.AnimationSpeed = 0.03!
        Me.btnsearchdate.BaseColor = System.Drawing.Color.White
        Me.btnsearchdate.BorderColor = System.Drawing.Color.Black
        Me.btnsearchdate.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btnsearchdate.FocusedColor = System.Drawing.Color.Empty
        Me.btnsearchdate.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btnsearchdate.ForeColor = System.Drawing.Color.White
        Me.btnsearchdate.Image = Global.KREM_SYSTEM.My.Resources.Resources.icons8_search_50
        Me.btnsearchdate.ImageSize = New System.Drawing.Size(20, 20)
        Me.btnsearchdate.Location = New System.Drawing.Point(296, 33)
        Me.btnsearchdate.Name = "btnsearchdate"
        Me.btnsearchdate.OnHoverBaseColor = System.Drawing.Color.LimeGreen
        Me.btnsearchdate.OnHoverBorderColor = System.Drawing.Color.Black
        Me.btnsearchdate.OnHoverForeColor = System.Drawing.Color.White
        Me.btnsearchdate.OnHoverImage = Nothing
        Me.btnsearchdate.OnPressedColor = System.Drawing.Color.Black
        Me.btnsearchdate.Size = New System.Drawing.Size(46, 30)
        Me.btnsearchdate.TabIndex = 4
        '
        'GunaLabel5
        '
        Me.GunaLabel5.AutoSize = True
        Me.GunaLabel5.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.GunaLabel5.Location = New System.Drawing.Point(8, 72)
        Me.GunaLabel5.Name = "GunaLabel5"
        Me.GunaLabel5.Size = New System.Drawing.Size(57, 15)
        Me.GunaLabel5.TabIndex = 3
        Me.GunaLabel5.Text = "End Date:"
        '
        'dtend
        '
        Me.dtend.BaseColor = System.Drawing.Color.White
        Me.dtend.BorderColor = System.Drawing.Color.Silver
        Me.dtend.CustomFormat = "dd/MM/yyyy"
        Me.dtend.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right
        Me.dtend.FocusedColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dtend.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.dtend.ForeColor = System.Drawing.Color.Black
        Me.dtend.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtend.Location = New System.Drawing.Point(75, 66)
        Me.dtend.MaxDate = New Date(9998, 12, 31, 0, 0, 0, 0)
        Me.dtend.MinDate = New Date(1753, 1, 1, 0, 0, 0, 0)
        Me.dtend.Name = "dtend"
        Me.dtend.OnHoverBaseColor = System.Drawing.Color.White
        Me.dtend.OnHoverBorderColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dtend.OnHoverForeColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dtend.OnPressedColor = System.Drawing.Color.Black
        Me.dtend.Size = New System.Drawing.Size(202, 30)
        Me.dtend.TabIndex = 2
        Me.dtend.Text = "20/11/2019"
        Me.dtend.Value = New Date(2019, 11, 20, 21, 17, 31, 477)
        '
        'GunaLabel4
        '
        Me.GunaLabel4.AutoSize = True
        Me.GunaLabel4.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.GunaLabel4.Location = New System.Drawing.Point(8, 39)
        Me.GunaLabel4.Name = "GunaLabel4"
        Me.GunaLabel4.Size = New System.Drawing.Size(61, 15)
        Me.GunaLabel4.TabIndex = 1
        Me.GunaLabel4.Text = "Start Date:"
        '
        'dtstart
        '
        Me.dtstart.BaseColor = System.Drawing.Color.White
        Me.dtstart.BorderColor = System.Drawing.Color.Silver
        Me.dtstart.CustomFormat = "dd/MM/yyyy"
        Me.dtstart.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right
        Me.dtstart.FocusedColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dtstart.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.dtstart.ForeColor = System.Drawing.Color.Black
        Me.dtstart.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtstart.Location = New System.Drawing.Point(75, 33)
        Me.dtstart.MaxDate = New Date(9998, 12, 31, 0, 0, 0, 0)
        Me.dtstart.MinDate = New Date(1753, 1, 1, 0, 0, 0, 0)
        Me.dtstart.Name = "dtstart"
        Me.dtstart.OnHoverBaseColor = System.Drawing.Color.White
        Me.dtstart.OnHoverBorderColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dtstart.OnHoverForeColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dtstart.OnPressedColor = System.Drawing.Color.Black
        Me.dtstart.Size = New System.Drawing.Size(202, 30)
        Me.dtstart.TabIndex = 0
        Me.dtstart.Text = "20/11/2019"
        Me.dtstart.Value = New Date(2019, 11, 20, 21, 17, 31, 477)
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(55, Byte), Integer), CType(CType(79, Byte), Integer))
        Me.Panel4.Controls.Add(Me.lblsender)
        Me.Panel4.Controls.Add(Me.GunaLabel6)
        Me.Panel4.Controls.Add(Me.lblicpassport)
        Me.Panel4.Controls.Add(Me.GunaLabel2)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel4.Location = New System.Drawing.Point(0, 0)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(881, 23)
        Me.Panel4.TabIndex = 3
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
        'GunaGroupBox3
        '
        Me.GunaGroupBox3.BackColor = System.Drawing.Color.Transparent
        Me.GunaGroupBox3.BaseColor = System.Drawing.Color.White
        Me.GunaGroupBox3.BorderColor = System.Drawing.Color.Gainsboro
        Me.GunaGroupBox3.Controls.Add(Me.lblremcount)
        Me.GunaGroupBox3.ForeColor = System.Drawing.Color.White
        Me.GunaGroupBox3.LineBottom = 1
        Me.GunaGroupBox3.LineColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GunaGroupBox3.LineLeft = 1
        Me.GunaGroupBox3.LineRight = 1
        Me.GunaGroupBox3.Location = New System.Drawing.Point(374, 34)
        Me.GunaGroupBox3.Name = "GunaGroupBox3"
        Me.GunaGroupBox3.Size = New System.Drawing.Size(107, 70)
        Me.GunaGroupBox3.TabIndex = 2
        Me.GunaGroupBox3.Text = "No of Remittances"
        Me.GunaGroupBox3.TextLocation = New System.Drawing.Point(10, 8)
        '
        'lblremcount
        '
        Me.lblremcount.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblremcount.ForeColor = System.Drawing.Color.DimGray
        Me.lblremcount.Location = New System.Drawing.Point(0, 38)
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
        Me.GunaGroupBox2.LineColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.GunaGroupBox2.LineLeft = 1
        Me.GunaGroupBox2.LineRight = 1
        Me.GunaGroupBox2.Location = New System.Drawing.Point(487, 34)
        Me.GunaGroupBox2.Name = "GunaGroupBox2"
        Me.GunaGroupBox2.Size = New System.Drawing.Size(214, 70)
        Me.GunaGroupBox2.TabIndex = 1
        Me.GunaGroupBox2.Text = "Total Remittance Amount"
        Me.GunaGroupBox2.TextLocation = New System.Drawing.Point(10, 8)
        '
        'lblremamount
        '
        Me.lblremamount.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblremamount.ForeColor = System.Drawing.Color.DimGray
        Me.lblremamount.Location = New System.Drawing.Point(3, 38)
        Me.lblremamount.Name = "lblremamount"
        Me.lblremamount.Size = New System.Drawing.Size(211, 23)
        Me.lblremamount.TabIndex = 1
        Me.lblremamount.Text = "$0.00"
        Me.lblremamount.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'GunaGroupBox1
        '
        Me.GunaGroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GunaGroupBox1.BaseColor = System.Drawing.Color.White
        Me.GunaGroupBox1.BorderColor = System.Drawing.Color.Gainsboro
        Me.GunaGroupBox1.Controls.Add(Me.lbltotalamount)
        Me.GunaGroupBox1.ForeColor = System.Drawing.Color.White
        Me.GunaGroupBox1.LineBottom = 1
        Me.GunaGroupBox1.LineColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.GunaGroupBox1.LineLeft = 1
        Me.GunaGroupBox1.LineRight = 1
        Me.GunaGroupBox1.Location = New System.Drawing.Point(705, 34)
        Me.GunaGroupBox1.Name = "GunaGroupBox1"
        Me.GunaGroupBox1.Size = New System.Drawing.Size(164, 70)
        Me.GunaGroupBox1.TabIndex = 0
        Me.GunaGroupBox1.Text = "Total Amount Sent (BND)"
        Me.GunaGroupBox1.TextLocation = New System.Drawing.Point(10, 8)
        '
        'lbltotalamount
        '
        Me.lbltotalamount.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbltotalamount.ForeColor = System.Drawing.Color.DimGray
        Me.lbltotalamount.Location = New System.Drawing.Point(22, 38)
        Me.lbltotalamount.Name = "lbltotalamount"
        Me.lbltotalamount.Size = New System.Drawing.Size(123, 23)
        Me.lbltotalamount.TabIndex = 0
        Me.lbltotalamount.Text = "$0.00"
        Me.lbltotalamount.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'lvremhistory
        '
        Me.lvremhistory.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lvremhistory.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3, Me.ColumnHeader4, Me.ColumnHeader5, Me.ColumnHeader6, Me.ColumnHeader7, Me.ColumnHeader8, Me.ColumnHeader9})
        Me.lvremhistory.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.lvremhistory.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lvremhistory.FullRowSelect = True
        Me.lvremhistory.GridLines = True
        Me.lvremhistory.Location = New System.Drawing.Point(0, 228)
        Me.lvremhistory.Name = "lvremhistory"
        Me.lvremhistory.Size = New System.Drawing.Size(881, 419)
        Me.lvremhistory.TabIndex = 13
        Me.lvremhistory.UseCompatibleStateImageBehavior = False
        Me.lvremhistory.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "Date Sent"
        Me.ColumnHeader1.Width = 80
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Receiver"
        Me.ColumnHeader2.Width = 150
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "Acc No"
        Me.ColumnHeader3.Width = 100
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "Bank"
        Me.ColumnHeader4.Width = 100
        '
        'ColumnHeader5
        '
        Me.ColumnHeader5.Text = "Branch"
        Me.ColumnHeader5.Width = 100
        '
        'ColumnHeader6
        '
        Me.ColumnHeader6.Text = "Amount Sent (BND)"
        Me.ColumnHeader6.Width = 120
        '
        'ColumnHeader7
        '
        Me.ColumnHeader7.Text = "Total Amount Sent"
        Me.ColumnHeader7.Width = 150
        '
        'ColumnHeader8
        '
        Me.ColumnHeader8.Text = "Rate"
        Me.ColumnHeader8.Width = 100
        '
        'ColumnHeader9
        '
        Me.ColumnHeader9.Text = "Counter"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Panel2.Controls.Add(Me.btnPrint)
        Me.Panel2.Controls.Add(Me.btnSearch)
        Me.Panel2.Controls.Add(Me.txtsearch)
        Me.Panel2.Controls.Add(Me.GunaLabel3)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 42)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(881, 59)
        Me.Panel2.TabIndex = 12
        '
        'btnPrint
        '
        Me.btnPrint.BackColor = System.Drawing.Color.White
        Me.btnPrint.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnPrint.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btnPrint.Image = Global.KREM_SYSTEM.My.Resources.Resources.printer
        Me.btnPrint.ImageSize = New System.Drawing.Size(40, 40)
        Me.btnPrint.Location = New System.Drawing.Point(810, 4)
        Me.btnPrint.Name = "btnPrint"
        Me.btnPrint.OnHoverImage = Nothing
        Me.btnPrint.OnHoverImageOffset = New System.Drawing.Point(0, 0)
        Me.btnPrint.Size = New System.Drawing.Size(63, 50)
        Me.btnPrint.TabIndex = 13
        '
        'btnSearch
        '
        Me.btnSearch.AnimationHoverSpeed = 0.07!
        Me.btnSearch.AnimationSpeed = 0.03!
        Me.btnSearch.BaseColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnSearch.BorderColor = System.Drawing.Color.Black
        Me.btnSearch.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btnSearch.FocusedColor = System.Drawing.Color.Empty
        Me.btnSearch.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btnSearch.ForeColor = System.Drawing.Color.White
        Me.btnSearch.Image = Global.KREM_SYSTEM.My.Resources.Resources.icons8_search_50
        Me.btnSearch.ImageSize = New System.Drawing.Size(20, 20)
        Me.btnSearch.Location = New System.Drawing.Point(486, 18)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnSearch.OnHoverBorderColor = System.Drawing.Color.Black
        Me.btnSearch.OnHoverForeColor = System.Drawing.Color.White
        Me.btnSearch.OnHoverImage = Nothing
        Me.btnSearch.OnPressedColor = System.Drawing.Color.Black
        Me.btnSearch.Size = New System.Drawing.Size(160, 26)
        Me.btnSearch.TabIndex = 12
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
        Me.txtsearch.TabIndex = 11
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
        Me.Panel1.TabIndex = 2
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
        Me.GunaLabel1.Size = New System.Drawing.Size(115, 15)
        Me.GunaLabel1.TabIndex = 0
        Me.GunaLabel1.Text = "Remittance History"
        '
        'contentpanel
        '
        Me.contentpanel.Controls.Add(Me.mainpanel)
        Me.contentpanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.contentpanel.Location = New System.Drawing.Point(0, 0)
        Me.contentpanel.Name = "contentpanel"
        Me.contentpanel.Size = New System.Drawing.Size(881, 647)
        Me.contentpanel.TabIndex = 7
        '
        'frmRemittanceHistory
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(881, 647)
        Me.Controls.Add(Me.contentpanel)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmRemittanceHistory"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmRemittanceHistory"
        Me.mainpanel.ResumeLayout(False)
        Me.detailspanel.ResumeLayout(False)
        Me.datefilterpanel.ResumeLayout(False)
        Me.datefilterpanel.PerformLayout()
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.GunaGroupBox3.ResumeLayout(False)
        Me.GunaGroupBox2.ResumeLayout(False)
        Me.GunaGroupBox1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.contentpanel.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Timer1 As Timer
    Friend WithEvents BWorker As System.ComponentModel.BackgroundWorker
    Friend WithEvents mainpanel As Panel
    Friend WithEvents detailspanel As Panel
    Friend WithEvents datefilterpanel As Guna.UI.WinForms.GunaGroupBox
    Friend WithEvents btnrefresh As Guna.UI.WinForms.GunaButton
    Friend WithEvents btnsearchdate As Guna.UI.WinForms.GunaButton
    Friend WithEvents GunaLabel5 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents dtend As Guna.UI.WinForms.GunaDateTimePicker
    Friend WithEvents GunaLabel4 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents dtstart As Guna.UI.WinForms.GunaDateTimePicker
    Friend WithEvents Panel4 As Panel
    Friend WithEvents lblsender As Guna.UI.WinForms.GunaLabel
    Friend WithEvents GunaLabel6 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents lblicpassport As Guna.UI.WinForms.GunaLabel
    Friend WithEvents GunaLabel2 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents GunaGroupBox3 As Guna.UI.WinForms.GunaGroupBox
    Friend WithEvents lblremcount As Guna.UI.WinForms.GunaLabel
    Friend WithEvents GunaGroupBox2 As Guna.UI.WinForms.GunaGroupBox
    Friend WithEvents lblremamount As Guna.UI.WinForms.GunaLabel
    Friend WithEvents GunaGroupBox1 As Guna.UI.WinForms.GunaGroupBox
    Friend WithEvents lbltotalamount As Guna.UI.WinForms.GunaLabel
    Friend WithEvents lvremhistory As ListView
    Friend WithEvents ColumnHeader1 As ColumnHeader
    Friend WithEvents ColumnHeader2 As ColumnHeader
    Friend WithEvents ColumnHeader3 As ColumnHeader
    Friend WithEvents ColumnHeader4 As ColumnHeader
    Friend WithEvents ColumnHeader5 As ColumnHeader
    Friend WithEvents ColumnHeader6 As ColumnHeader
    Friend WithEvents ColumnHeader7 As ColumnHeader
    Friend WithEvents ColumnHeader8 As ColumnHeader
    Friend WithEvents ColumnHeader9 As ColumnHeader
    Friend WithEvents Panel2 As Panel
    Friend WithEvents btnSearch As Guna.UI.WinForms.GunaButton
    Friend WithEvents txtsearch As Guna.UI.WinForms.GunaLineTextBox
    Friend WithEvents GunaLabel3 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents btnClose As Guna.UI.WinForms.GunaImageButton
    Friend WithEvents GunaLabel1 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents contentpanel As Panel
    Friend WithEvents btnPrint As Guna.UI.WinForms.GunaImageButton
End Class
