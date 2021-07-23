<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCustomerList
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnClose = New Guna.UI.WinForms.GunaImageButton()
        Me.GunaLabel1 = New Guna.UI.WinForms.GunaLabel()
        Me.filterpanel = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.btnSearch = New Guna.UI.WinForms.GunaButton()
        Me.txtsearch = New Guna.UI.WinForms.GunaLineTextBox()
        Me.GunaLabel3 = New Guna.UI.WinForms.GunaLabel()
        Me.contentpanel = New System.Windows.Forms.Panel()
        Me.rightpanel = New System.Windows.Forms.Panel()
        Me.GunaGroupBox1 = New Guna.UI.WinForms.GunaGroupBox()
        Me.btnViewPhoto = New Guna.UI.WinForms.GunaButton()
        Me.pbPic = New System.Windows.Forms.PictureBox()
        Me.txtplaceofbirth = New Guna.UI.WinForms.GunaTextBox()
        Me.GunaLabel12 = New Guna.UI.WinForms.GunaLabel()
        Me.cbxincome = New Guna.UI.WinForms.GunaComboBox()
        Me.GunaLabel10 = New Guna.UI.WinForms.GunaLabel()
        Me.txtoccupation = New Guna.UI.WinForms.GunaTextBox()
        Me.GunaLabel9 = New Guna.UI.WinForms.GunaLabel()
        Me.txtdob = New Guna.UI.WinForms.GunaDateTimePicker()
        Me.GunaLabel8 = New Guna.UI.WinForms.GunaLabel()
        Me.txtphone = New Guna.UI.WinForms.GunaTextBox()
        Me.GunaLabel7 = New Guna.UI.WinForms.GunaLabel()
        Me.txtaddress = New System.Windows.Forms.RichTextBox()
        Me.GunaLabel6 = New Guna.UI.WinForms.GunaLabel()
        Me.cbxnationality = New Guna.UI.WinForms.GunaComboBox()
        Me.GunaLabel5 = New Guna.UI.WinForms.GunaLabel()
        Me.txticpassport = New Guna.UI.WinForms.GunaTextBox()
        Me.GunaLabel4 = New Guna.UI.WinForms.GunaLabel()
        Me.txtsender = New Guna.UI.WinForms.GunaTextBox()
        Me.GunaLabel2 = New Guna.UI.WinForms.GunaLabel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.btndelete = New Guna.UI.WinForms.GunaAdvenceButton()
        Me.btnCancel = New Guna.UI.WinForms.GunaAdvenceButton()
        Me.btnUpdate = New Guna.UI.WinForms.GunaAdvenceButton()
        Me.btnEdit = New Guna.UI.WinForms.GunaAdvenceButton()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.BWorker = New System.ComponentModel.BackgroundWorker()
        Me.Panel1.SuspendLayout()
        Me.filterpanel.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.contentpanel.SuspendLayout()
        Me.rightpanel.SuspendLayout()
        Me.GunaGroupBox1.SuspendLayout()
        CType(Me.pbPic, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel3.SuspendLayout()
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
        Me.Panel1.TabIndex = 1
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
        Me.GunaLabel1.Size = New System.Drawing.Size(83, 15)
        Me.GunaLabel1.TabIndex = 0
        Me.GunaLabel1.Text = "Customer List"
        '
        'filterpanel
        '
        Me.filterpanel.Controls.Add(Me.Panel2)
        Me.filterpanel.Dock = System.Windows.Forms.DockStyle.Top
        Me.filterpanel.Location = New System.Drawing.Point(0, 42)
        Me.filterpanel.Name = "filterpanel"
        Me.filterpanel.Size = New System.Drawing.Size(881, 64)
        Me.filterpanel.TabIndex = 3
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Panel2.Controls.Add(Me.btnSearch)
        Me.Panel2.Controls.Add(Me.txtsearch)
        Me.Panel2.Controls.Add(Me.GunaLabel3)
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(881, 64)
        Me.Panel2.TabIndex = 11
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
        Me.btnSearch.Size = New System.Drawing.Size(160, 30)
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
        Me.txtsearch.MaxLength = 64
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
        'contentpanel
        '
        Me.contentpanel.Controls.Add(Me.rightpanel)
        Me.contentpanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.contentpanel.Location = New System.Drawing.Point(0, 106)
        Me.contentpanel.Name = "contentpanel"
        Me.contentpanel.Size = New System.Drawing.Size(881, 541)
        Me.contentpanel.TabIndex = 4
        '
        'rightpanel
        '
        Me.rightpanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.rightpanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.rightpanel.Controls.Add(Me.GunaGroupBox1)
        Me.rightpanel.Controls.Add(Me.Panel3)
        Me.rightpanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.rightpanel.Location = New System.Drawing.Point(0, 0)
        Me.rightpanel.Name = "rightpanel"
        Me.rightpanel.Size = New System.Drawing.Size(881, 541)
        Me.rightpanel.TabIndex = 4
        '
        'GunaGroupBox1
        '
        Me.GunaGroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GunaGroupBox1.BaseColor = System.Drawing.Color.White
        Me.GunaGroupBox1.BorderColor = System.Drawing.Color.Gainsboro
        Me.GunaGroupBox1.Controls.Add(Me.btnViewPhoto)
        Me.GunaGroupBox1.Controls.Add(Me.pbPic)
        Me.GunaGroupBox1.Controls.Add(Me.txtplaceofbirth)
        Me.GunaGroupBox1.Controls.Add(Me.GunaLabel12)
        Me.GunaGroupBox1.Controls.Add(Me.cbxincome)
        Me.GunaGroupBox1.Controls.Add(Me.GunaLabel10)
        Me.GunaGroupBox1.Controls.Add(Me.txtoccupation)
        Me.GunaGroupBox1.Controls.Add(Me.GunaLabel9)
        Me.GunaGroupBox1.Controls.Add(Me.txtdob)
        Me.GunaGroupBox1.Controls.Add(Me.GunaLabel8)
        Me.GunaGroupBox1.Controls.Add(Me.txtphone)
        Me.GunaGroupBox1.Controls.Add(Me.GunaLabel7)
        Me.GunaGroupBox1.Controls.Add(Me.txtaddress)
        Me.GunaGroupBox1.Controls.Add(Me.GunaLabel6)
        Me.GunaGroupBox1.Controls.Add(Me.cbxnationality)
        Me.GunaGroupBox1.Controls.Add(Me.GunaLabel5)
        Me.GunaGroupBox1.Controls.Add(Me.txticpassport)
        Me.GunaGroupBox1.Controls.Add(Me.GunaLabel4)
        Me.GunaGroupBox1.Controls.Add(Me.txtsender)
        Me.GunaGroupBox1.Controls.Add(Me.GunaLabel2)
        Me.GunaGroupBox1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.GunaGroupBox1.LineColor = System.Drawing.Color.Gainsboro
        Me.GunaGroupBox1.Location = New System.Drawing.Point(0, 46)
        Me.GunaGroupBox1.Name = "GunaGroupBox1"
        Me.GunaGroupBox1.Size = New System.Drawing.Size(879, 493)
        Me.GunaGroupBox1.TabIndex = 1
        Me.GunaGroupBox1.Text = "Sender Details"
        Me.GunaGroupBox1.TextLocation = New System.Drawing.Point(10, 8)
        '
        'btnViewPhoto
        '
        Me.btnViewPhoto.AnimationHoverSpeed = 0.07!
        Me.btnViewPhoto.AnimationSpeed = 0.03!
        Me.btnViewPhoto.BaseColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(167, Byte), Integer), CType(CType(69, Byte), Integer))
        Me.btnViewPhoto.BorderColor = System.Drawing.Color.Black
        Me.btnViewPhoto.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btnViewPhoto.FocusedColor = System.Drawing.Color.Empty
        Me.btnViewPhoto.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btnViewPhoto.ForeColor = System.Drawing.Color.White
        Me.btnViewPhoto.Image = Global.KREM_SYSTEM.My.Resources.Resources.icons8_client_management_50
        Me.btnViewPhoto.ImageSize = New System.Drawing.Size(50, 50)
        Me.btnViewPhoto.Location = New System.Drawing.Point(595, 379)
        Me.btnViewPhoto.Name = "btnViewPhoto"
        Me.btnViewPhoto.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(167, Byte), Integer), CType(CType(69, Byte), Integer))
        Me.btnViewPhoto.OnHoverBorderColor = System.Drawing.Color.Black
        Me.btnViewPhoto.OnHoverForeColor = System.Drawing.Color.White
        Me.btnViewPhoto.OnHoverImage = Nothing
        Me.btnViewPhoto.OnPressedColor = System.Drawing.Color.Black
        Me.btnViewPhoto.Size = New System.Drawing.Size(160, 42)
        Me.btnViewPhoto.TabIndex = 41
        Me.btnViewPhoto.Text = "View Full Image"
        '
        'pbPic
        '
        Me.pbPic.BackColor = System.Drawing.Color.White
        Me.pbPic.Location = New System.Drawing.Point(448, 46)
        Me.pbPic.Name = "pbPic"
        Me.pbPic.Size = New System.Drawing.Size(415, 327)
        Me.pbPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbPic.TabIndex = 40
        Me.pbPic.TabStop = False
        '
        'txtplaceofbirth
        '
        Me.txtplaceofbirth.BaseColor = System.Drawing.Color.White
        Me.txtplaceofbirth.BorderColor = System.Drawing.Color.Silver
        Me.txtplaceofbirth.BorderSize = 1
        Me.txtplaceofbirth.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtplaceofbirth.FocusedBaseColor = System.Drawing.Color.White
        Me.txtplaceofbirth.FocusedBorderColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtplaceofbirth.FocusedForeColor = System.Drawing.SystemColors.ControlText
        Me.txtplaceofbirth.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtplaceofbirth.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.txtplaceofbirth.Location = New System.Drawing.Point(108, 343)
        Me.txtplaceofbirth.MaxLength = 128
        Me.txtplaceofbirth.Name = "txtplaceofbirth"
        Me.txtplaceofbirth.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtplaceofbirth.Size = New System.Drawing.Size(297, 30)
        Me.txtplaceofbirth.TabIndex = 39
        '
        'GunaLabel12
        '
        Me.GunaLabel12.AutoSize = True
        Me.GunaLabel12.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.GunaLabel12.Location = New System.Drawing.Point(18, 351)
        Me.GunaLabel12.Name = "GunaLabel12"
        Me.GunaLabel12.Size = New System.Drawing.Size(77, 15)
        Me.GunaLabel12.TabIndex = 38
        Me.GunaLabel12.Text = "Place of Birth"
        '
        'cbxincome
        '
        Me.cbxincome.BackColor = System.Drawing.Color.Transparent
        Me.cbxincome.BaseColor = System.Drawing.Color.White
        Me.cbxincome.BorderColor = System.Drawing.Color.Silver
        Me.cbxincome.BorderSize = 1
        Me.cbxincome.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cbxincome.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbxincome.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cbxincome.FocusedColor = System.Drawing.Color.Empty
        Me.cbxincome.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.cbxincome.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.cbxincome.FormattingEnabled = True
        Me.cbxincome.Items.AddRange(New Object() {"SALARY", "BUSINESS"})
        Me.cbxincome.Location = New System.Drawing.Point(108, 313)
        Me.cbxincome.Name = "cbxincome"
        Me.cbxincome.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cbxincome.OnHoverItemForeColor = System.Drawing.Color.White
        Me.cbxincome.Size = New System.Drawing.Size(297, 26)
        Me.cbxincome.TabIndex = 37
        '
        'GunaLabel10
        '
        Me.GunaLabel10.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.GunaLabel10.Location = New System.Drawing.Point(18, 314)
        Me.GunaLabel10.Name = "GunaLabel10"
        Me.GunaLabel10.Size = New System.Drawing.Size(76, 30)
        Me.GunaLabel10.TabIndex = 36
        Me.GunaLabel10.Text = "Source of Income"
        '
        'txtoccupation
        '
        Me.txtoccupation.BaseColor = System.Drawing.Color.White
        Me.txtoccupation.BorderColor = System.Drawing.Color.Silver
        Me.txtoccupation.BorderSize = 1
        Me.txtoccupation.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtoccupation.FocusedBaseColor = System.Drawing.Color.White
        Me.txtoccupation.FocusedBorderColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtoccupation.FocusedForeColor = System.Drawing.SystemColors.ControlText
        Me.txtoccupation.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtoccupation.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.txtoccupation.Location = New System.Drawing.Point(108, 279)
        Me.txtoccupation.MaxLength = 32
        Me.txtoccupation.Name = "txtoccupation"
        Me.txtoccupation.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtoccupation.Size = New System.Drawing.Size(297, 30)
        Me.txtoccupation.TabIndex = 35
        '
        'GunaLabel9
        '
        Me.GunaLabel9.AutoSize = True
        Me.GunaLabel9.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.GunaLabel9.Location = New System.Drawing.Point(15, 285)
        Me.GunaLabel9.Name = "GunaLabel9"
        Me.GunaLabel9.Size = New System.Drawing.Size(69, 15)
        Me.GunaLabel9.TabIndex = 34
        Me.GunaLabel9.Text = "Occupation"
        '
        'txtdob
        '
        Me.txtdob.BaseColor = System.Drawing.Color.White
        Me.txtdob.BorderColor = System.Drawing.Color.Silver
        Me.txtdob.CustomFormat = "dd/MM/yyyy"
        Me.txtdob.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right
        Me.txtdob.FocusedColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtdob.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtdob.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.txtdob.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.txtdob.Location = New System.Drawing.Point(108, 245)
        Me.txtdob.MaxDate = New Date(9998, 12, 31, 0, 0, 0, 0)
        Me.txtdob.MinDate = New Date(1753, 1, 1, 0, 0, 0, 0)
        Me.txtdob.Name = "txtdob"
        Me.txtdob.OnHoverBaseColor = System.Drawing.Color.White
        Me.txtdob.OnHoverBorderColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtdob.OnHoverForeColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtdob.OnPressedColor = System.Drawing.Color.Black
        Me.txtdob.Size = New System.Drawing.Size(297, 30)
        Me.txtdob.TabIndex = 33
        Me.txtdob.Text = "19/11/2019"
        Me.txtdob.Value = New Date(2019, 11, 19, 21, 47, 38, 515)
        '
        'GunaLabel8
        '
        Me.GunaLabel8.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.GunaLabel8.Location = New System.Drawing.Point(15, 252)
        Me.GunaLabel8.Name = "GunaLabel8"
        Me.GunaLabel8.Size = New System.Drawing.Size(79, 30)
        Me.GunaLabel8.TabIndex = 32
        Me.GunaLabel8.Text = "Date of Birth"
        '
        'txtphone
        '
        Me.txtphone.BaseColor = System.Drawing.Color.White
        Me.txtphone.BorderColor = System.Drawing.Color.Silver
        Me.txtphone.BorderSize = 1
        Me.txtphone.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtphone.FocusedBaseColor = System.Drawing.Color.White
        Me.txtphone.FocusedBorderColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtphone.FocusedForeColor = System.Drawing.SystemColors.ControlText
        Me.txtphone.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtphone.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.txtphone.Location = New System.Drawing.Point(108, 211)
        Me.txtphone.MaxLength = 11
        Me.txtphone.Name = "txtphone"
        Me.txtphone.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtphone.Size = New System.Drawing.Size(297, 30)
        Me.txtphone.TabIndex = 31
        Me.txtphone.Text = "+673"
        '
        'GunaLabel7
        '
        Me.GunaLabel7.AutoSize = True
        Me.GunaLabel7.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.GunaLabel7.Location = New System.Drawing.Point(15, 218)
        Me.GunaLabel7.Name = "GunaLabel7"
        Me.GunaLabel7.Size = New System.Drawing.Size(88, 15)
        Me.GunaLabel7.TabIndex = 30
        Me.GunaLabel7.Text = "Phone Number"
        '
        'txtaddress
        '
        Me.txtaddress.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtaddress.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.txtaddress.Location = New System.Drawing.Point(108, 144)
        Me.txtaddress.MaxLength = 1024
        Me.txtaddress.Name = "txtaddress"
        Me.txtaddress.Size = New System.Drawing.Size(297, 63)
        Me.txtaddress.TabIndex = 29
        Me.txtaddress.Text = ""
        '
        'GunaLabel6
        '
        Me.GunaLabel6.AutoSize = True
        Me.GunaLabel6.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.GunaLabel6.Location = New System.Drawing.Point(15, 146)
        Me.GunaLabel6.Name = "GunaLabel6"
        Me.GunaLabel6.Size = New System.Drawing.Size(49, 15)
        Me.GunaLabel6.TabIndex = 28
        Me.GunaLabel6.Text = "Address"
        '
        'cbxnationality
        '
        Me.cbxnationality.BackColor = System.Drawing.Color.Transparent
        Me.cbxnationality.BaseColor = System.Drawing.Color.White
        Me.cbxnationality.BorderColor = System.Drawing.Color.Silver
        Me.cbxnationality.BorderSize = 1
        Me.cbxnationality.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cbxnationality.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbxnationality.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cbxnationality.FocusedColor = System.Drawing.Color.Empty
        Me.cbxnationality.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.cbxnationality.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.cbxnationality.FormattingEnabled = True
        Me.cbxnationality.Items.AddRange(New Object() {"Indonesia", "Brunei", "Malaysia", "Philippines", "Thailand", "Indonesia"})
        Me.cbxnationality.Location = New System.Drawing.Point(108, 114)
        Me.cbxnationality.Name = "cbxnationality"
        Me.cbxnationality.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cbxnationality.OnHoverItemForeColor = System.Drawing.Color.White
        Me.cbxnationality.Size = New System.Drawing.Size(297, 26)
        Me.cbxnationality.TabIndex = 27
        '
        'GunaLabel5
        '
        Me.GunaLabel5.AutoSize = True
        Me.GunaLabel5.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.GunaLabel5.Location = New System.Drawing.Point(15, 119)
        Me.GunaLabel5.Name = "GunaLabel5"
        Me.GunaLabel5.Size = New System.Drawing.Size(65, 15)
        Me.GunaLabel5.TabIndex = 26
        Me.GunaLabel5.Text = "Nationality"
        '
        'txticpassport
        '
        Me.txticpassport.BaseColor = System.Drawing.Color.White
        Me.txticpassport.BorderColor = System.Drawing.Color.Silver
        Me.txticpassport.BorderSize = 1
        Me.txticpassport.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txticpassport.FocusedBaseColor = System.Drawing.Color.White
        Me.txticpassport.FocusedBorderColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txticpassport.FocusedForeColor = System.Drawing.SystemColors.ControlText
        Me.txticpassport.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txticpassport.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.txticpassport.Location = New System.Drawing.Point(108, 80)
        Me.txticpassport.MaxLength = 32
        Me.txticpassport.Name = "txticpassport"
        Me.txticpassport.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txticpassport.Size = New System.Drawing.Size(297, 30)
        Me.txticpassport.TabIndex = 25
        '
        'GunaLabel4
        '
        Me.GunaLabel4.AutoSize = True
        Me.GunaLabel4.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.GunaLabel4.Location = New System.Drawing.Point(15, 86)
        Me.GunaLabel4.Name = "GunaLabel4"
        Me.GunaLabel4.Size = New System.Drawing.Size(68, 15)
        Me.GunaLabel4.TabIndex = 24
        Me.GunaLabel4.Text = "IC/Passport"
        '
        'txtsender
        '
        Me.txtsender.BaseColor = System.Drawing.Color.White
        Me.txtsender.BorderColor = System.Drawing.Color.Silver
        Me.txtsender.BorderSize = 1
        Me.txtsender.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtsender.FocusedBaseColor = System.Drawing.Color.White
        Me.txtsender.FocusedBorderColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtsender.FocusedForeColor = System.Drawing.SystemColors.ControlText
        Me.txtsender.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtsender.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.txtsender.Location = New System.Drawing.Point(108, 46)
        Me.txtsender.MaxLength = 128
        Me.txtsender.Name = "txtsender"
        Me.txtsender.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtsender.Size = New System.Drawing.Size(297, 30)
        Me.txtsender.TabIndex = 23
        '
        'GunaLabel2
        '
        Me.GunaLabel2.AutoSize = True
        Me.GunaLabel2.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.GunaLabel2.Location = New System.Drawing.Point(15, 51)
        Me.GunaLabel2.Name = "GunaLabel2"
        Me.GunaLabel2.Size = New System.Drawing.Size(86, 15)
        Me.GunaLabel2.TabIndex = 22
        Me.GunaLabel2.Text = "Sender's Name"
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Panel3.Controls.Add(Me.btndelete)
        Me.Panel3.Controls.Add(Me.btnCancel)
        Me.Panel3.Controls.Add(Me.btnUpdate)
        Me.Panel3.Controls.Add(Me.btnEdit)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel3.Location = New System.Drawing.Point(0, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(879, 45)
        Me.Panel3.TabIndex = 0
        '
        'btndelete
        '
        Me.btndelete.AnimationHoverSpeed = 0.07!
        Me.btndelete.AnimationSpeed = 0.03!
        Me.btndelete.BaseColor = System.Drawing.Color.FromArgb(CType(CType(220, Byte), Integer), CType(CType(53, Byte), Integer), CType(CType(69, Byte), Integer))
        Me.btndelete.BorderColor = System.Drawing.Color.Black
        Me.btndelete.CheckedBaseColor = System.Drawing.Color.Gray
        Me.btndelete.CheckedBorderColor = System.Drawing.Color.Black
        Me.btndelete.CheckedForeColor = System.Drawing.Color.White
        Me.btndelete.CheckedImage = Global.KREM_SYSTEM.My.Resources.Resources.icons8_edit_50
        Me.btndelete.CheckedLineColor = System.Drawing.Color.DimGray
        Me.btndelete.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btndelete.Dock = System.Windows.Forms.DockStyle.Left
        Me.btndelete.FocusedColor = System.Drawing.Color.Empty
        Me.btndelete.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btndelete.ForeColor = System.Drawing.Color.White
        Me.btndelete.Image = Global.KREM_SYSTEM.My.Resources.Resources.delete1
        Me.btndelete.ImageSize = New System.Drawing.Size(20, 20)
        Me.btndelete.LineColor = System.Drawing.Color.Empty
        Me.btndelete.Location = New System.Drawing.Point(297, 0)
        Me.btndelete.Name = "btndelete"
        Me.btndelete.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(153, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.btndelete.OnHoverBorderColor = System.Drawing.Color.Black
        Me.btndelete.OnHoverForeColor = System.Drawing.Color.White
        Me.btndelete.OnHoverImage = Nothing
        Me.btndelete.OnHoverLineColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.btndelete.OnPressedColor = System.Drawing.Color.Black
        Me.btndelete.Size = New System.Drawing.Size(99, 45)
        Me.btndelete.TabIndex = 8
        Me.btndelete.Text = "Delete"
        '
        'btnCancel
        '
        Me.btnCancel.AnimationHoverSpeed = 0.07!
        Me.btnCancel.AnimationSpeed = 0.03!
        Me.btnCancel.BaseColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(193, Byte), Integer), CType(CType(7, Byte), Integer))
        Me.btnCancel.BorderColor = System.Drawing.Color.Black
        Me.btnCancel.CheckedBaseColor = System.Drawing.Color.Gray
        Me.btnCancel.CheckedBorderColor = System.Drawing.Color.Black
        Me.btnCancel.CheckedForeColor = System.Drawing.Color.White
        Me.btnCancel.CheckedImage = Global.KREM_SYSTEM.My.Resources.Resources.icons8_edit_50
        Me.btnCancel.CheckedLineColor = System.Drawing.Color.DimGray
        Me.btnCancel.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btnCancel.Dock = System.Windows.Forms.DockStyle.Left
        Me.btnCancel.FocusedColor = System.Drawing.Color.Empty
        Me.btnCancel.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btnCancel.ForeColor = System.Drawing.Color.White
        Me.btnCancel.Image = Global.KREM_SYSTEM.My.Resources.Resources.Cancel_32
        Me.btnCancel.ImageSize = New System.Drawing.Size(20, 20)
        Me.btnCancel.LineColor = System.Drawing.Color.Empty
        Me.btnCancel.Location = New System.Drawing.Point(198, 0)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(229, Byte), Integer), CType(CType(178, Byte), Integer), CType(CType(23, Byte), Integer))
        Me.btnCancel.OnHoverBorderColor = System.Drawing.Color.Black
        Me.btnCancel.OnHoverForeColor = System.Drawing.Color.White
        Me.btnCancel.OnHoverImage = Nothing
        Me.btnCancel.OnHoverLineColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.btnCancel.OnPressedColor = System.Drawing.Color.Black
        Me.btnCancel.Size = New System.Drawing.Size(99, 45)
        Me.btnCancel.TabIndex = 7
        Me.btnCancel.Text = "Cancel"
        '
        'btnUpdate
        '
        Me.btnUpdate.AnimationHoverSpeed = 0.07!
        Me.btnUpdate.AnimationSpeed = 0.03!
        Me.btnUpdate.BaseColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(167, Byte), Integer), CType(CType(69, Byte), Integer))
        Me.btnUpdate.BorderColor = System.Drawing.Color.Black
        Me.btnUpdate.CheckedBaseColor = System.Drawing.Color.Gray
        Me.btnUpdate.CheckedBorderColor = System.Drawing.Color.Black
        Me.btnUpdate.CheckedForeColor = System.Drawing.Color.White
        Me.btnUpdate.CheckedImage = Global.KREM_SYSTEM.My.Resources.Resources.icons8_edit_50
        Me.btnUpdate.CheckedLineColor = System.Drawing.Color.DimGray
        Me.btnUpdate.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btnUpdate.Dock = System.Windows.Forms.DockStyle.Left
        Me.btnUpdate.FocusedColor = System.Drawing.Color.Empty
        Me.btnUpdate.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btnUpdate.ForeColor = System.Drawing.Color.White
        Me.btnUpdate.Image = Global.KREM_SYSTEM.My.Resources.Resources.icons8_checkmark_50
        Me.btnUpdate.ImageSize = New System.Drawing.Size(20, 20)
        Me.btnUpdate.LineColor = System.Drawing.Color.Empty
        Me.btnUpdate.Location = New System.Drawing.Point(99, 0)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(79, Byte), Integer))
        Me.btnUpdate.OnHoverBorderColor = System.Drawing.Color.Black
        Me.btnUpdate.OnHoverForeColor = System.Drawing.Color.White
        Me.btnUpdate.OnHoverImage = Nothing
        Me.btnUpdate.OnHoverLineColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.btnUpdate.OnPressedColor = System.Drawing.Color.Black
        Me.btnUpdate.Size = New System.Drawing.Size(99, 45)
        Me.btnUpdate.TabIndex = 6
        Me.btnUpdate.Text = "Update"
        '
        'btnEdit
        '
        Me.btnEdit.AnimationHoverSpeed = 0.07!
        Me.btnEdit.AnimationSpeed = 0.03!
        Me.btnEdit.BaseColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(123, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnEdit.BorderColor = System.Drawing.Color.Black
        Me.btnEdit.CheckedBaseColor = System.Drawing.Color.Gray
        Me.btnEdit.CheckedBorderColor = System.Drawing.Color.Black
        Me.btnEdit.CheckedForeColor = System.Drawing.Color.White
        Me.btnEdit.CheckedImage = Global.KREM_SYSTEM.My.Resources.Resources.icons8_edit_50
        Me.btnEdit.CheckedLineColor = System.Drawing.Color.DimGray
        Me.btnEdit.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btnEdit.Dock = System.Windows.Forms.DockStyle.Left
        Me.btnEdit.FocusedColor = System.Drawing.Color.Empty
        Me.btnEdit.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btnEdit.ForeColor = System.Drawing.Color.White
        Me.btnEdit.Image = Global.KREM_SYSTEM.My.Resources.Resources.icons8_edit_50
        Me.btnEdit.ImageSize = New System.Drawing.Size(20, 20)
        Me.btnEdit.LineColor = System.Drawing.Color.Empty
        Me.btnEdit.Location = New System.Drawing.Point(0, 0)
        Me.btnEdit.Name = "btnEdit"
        Me.btnEdit.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(189, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnEdit.OnHoverBorderColor = System.Drawing.Color.Black
        Me.btnEdit.OnHoverForeColor = System.Drawing.Color.White
        Me.btnEdit.OnHoverImage = Nothing
        Me.btnEdit.OnHoverLineColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.btnEdit.OnPressedColor = System.Drawing.Color.Black
        Me.btnEdit.Size = New System.Drawing.Size(99, 45)
        Me.btnEdit.TabIndex = 5
        Me.btnEdit.Text = "Edit"
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 1000
        '
        'frmCustomerList
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(881, 647)
        Me.Controls.Add(Me.contentpanel)
        Me.Controls.Add(Me.filterpanel)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmCustomerList"
        Me.Text = "frmCustomerList"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.filterpanel.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.contentpanel.ResumeLayout(False)
        Me.rightpanel.ResumeLayout(False)
        Me.GunaGroupBox1.ResumeLayout(False)
        Me.GunaGroupBox1.PerformLayout()
        CType(Me.pbPic, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel3.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents btnClose As Guna.UI.WinForms.GunaImageButton
    Friend WithEvents GunaLabel1 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents filterpanel As Panel
    Friend WithEvents contentpanel As Panel
    Friend WithEvents Timer1 As Timer
    Friend WithEvents BWorker As System.ComponentModel.BackgroundWorker
    Friend WithEvents Panel2 As Panel
    Friend WithEvents txtsearch As Guna.UI.WinForms.GunaLineTextBox
    Friend WithEvents GunaLabel3 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents btnSearch As Guna.UI.WinForms.GunaButton
    Friend WithEvents rightpanel As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents btnCancel As Guna.UI.WinForms.GunaAdvenceButton
    Friend WithEvents btnUpdate As Guna.UI.WinForms.GunaAdvenceButton
    Friend WithEvents btnEdit As Guna.UI.WinForms.GunaAdvenceButton
    Friend WithEvents btndelete As Guna.UI.WinForms.GunaAdvenceButton
    Friend WithEvents GunaGroupBox1 As Guna.UI.WinForms.GunaGroupBox
    Friend WithEvents btnViewPhoto As Guna.UI.WinForms.GunaButton
    Friend WithEvents pbPic As PictureBox
    Friend WithEvents txtplaceofbirth As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents GunaLabel12 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents cbxincome As Guna.UI.WinForms.GunaComboBox
    Friend WithEvents GunaLabel10 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents txtoccupation As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents GunaLabel9 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents txtdob As Guna.UI.WinForms.GunaDateTimePicker
    Friend WithEvents GunaLabel8 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents txtphone As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents GunaLabel7 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents txtaddress As RichTextBox
    Friend WithEvents GunaLabel6 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents cbxnationality As Guna.UI.WinForms.GunaComboBox
    Friend WithEvents GunaLabel5 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents txticpassport As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents GunaLabel4 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents txtsender As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents GunaLabel2 As Guna.UI.WinForms.GunaLabel
End Class
