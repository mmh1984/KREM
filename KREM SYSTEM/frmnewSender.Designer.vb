<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmnewSender
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
        Me.BWorker = New System.ComponentModel.BackgroundWorker()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.rightpanel = New System.Windows.Forms.Panel()
        Me.gbsenderdetails = New Guna.UI.WinForms.GunaGroupBox()
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
        Me.filterpanel = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.btnCancel = New Guna.UI.WinForms.GunaAdvenceButton()
        Me.btnSave = New Guna.UI.WinForms.GunaAdvenceButton()
        Me.btnNew = New Guna.UI.WinForms.GunaAdvenceButton()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnClose = New Guna.UI.WinForms.GunaImageButton()
        Me.GunaLabel1 = New Guna.UI.WinForms.GunaLabel()
        Me.contentpanel = New System.Windows.Forms.Panel()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.btnRotate = New Guna.UI.WinForms.GunaButton()
        Me.rightpanel.SuspendLayout()
        Me.gbsenderdetails.SuspendLayout()
        CType(Me.pbPic, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.filterpanel.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.contentpanel.SuspendLayout()
        Me.SuspendLayout()
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 1000
        '
        'rightpanel
        '
        Me.rightpanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.rightpanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.rightpanel.Controls.Add(Me.gbsenderdetails)
        Me.rightpanel.Dock = System.Windows.Forms.DockStyle.Top
        Me.rightpanel.Location = New System.Drawing.Point(0, 0)
        Me.rightpanel.Name = "rightpanel"
        Me.rightpanel.Size = New System.Drawing.Size(881, 564)
        Me.rightpanel.TabIndex = 4
        '
        'gbsenderdetails
        '
        Me.gbsenderdetails.BackColor = System.Drawing.Color.Transparent
        Me.gbsenderdetails.BaseColor = System.Drawing.Color.White
        Me.gbsenderdetails.BorderColor = System.Drawing.Color.Gainsboro
        Me.gbsenderdetails.Controls.Add(Me.btnRotate)
        Me.gbsenderdetails.Controls.Add(Me.btnViewPhoto)
        Me.gbsenderdetails.Controls.Add(Me.pbPic)
        Me.gbsenderdetails.Controls.Add(Me.txtplaceofbirth)
        Me.gbsenderdetails.Controls.Add(Me.GunaLabel12)
        Me.gbsenderdetails.Controls.Add(Me.cbxincome)
        Me.gbsenderdetails.Controls.Add(Me.GunaLabel10)
        Me.gbsenderdetails.Controls.Add(Me.txtoccupation)
        Me.gbsenderdetails.Controls.Add(Me.GunaLabel9)
        Me.gbsenderdetails.Controls.Add(Me.txtdob)
        Me.gbsenderdetails.Controls.Add(Me.GunaLabel8)
        Me.gbsenderdetails.Controls.Add(Me.txtphone)
        Me.gbsenderdetails.Controls.Add(Me.GunaLabel7)
        Me.gbsenderdetails.Controls.Add(Me.txtaddress)
        Me.gbsenderdetails.Controls.Add(Me.GunaLabel6)
        Me.gbsenderdetails.Controls.Add(Me.cbxnationality)
        Me.gbsenderdetails.Controls.Add(Me.GunaLabel5)
        Me.gbsenderdetails.Controls.Add(Me.txticpassport)
        Me.gbsenderdetails.Controls.Add(Me.GunaLabel4)
        Me.gbsenderdetails.Controls.Add(Me.txtsender)
        Me.gbsenderdetails.Controls.Add(Me.GunaLabel2)
        Me.gbsenderdetails.ForeColor = System.Drawing.Color.White
        Me.gbsenderdetails.LineColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(105, Byte), Integer), CType(CType(91, Byte), Integer))
        Me.gbsenderdetails.Location = New System.Drawing.Point(-1, 2)
        Me.gbsenderdetails.Name = "gbsenderdetails"
        Me.gbsenderdetails.Size = New System.Drawing.Size(881, 561)
        Me.gbsenderdetails.TabIndex = 22
        Me.gbsenderdetails.Text = "Sender Details"
        Me.gbsenderdetails.TextLocation = New System.Drawing.Point(10, 8)
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
        Me.btnViewPhoto.Location = New System.Drawing.Point(442, 390)
        Me.btnViewPhoto.Name = "btnViewPhoto"
        Me.btnViewPhoto.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(167, Byte), Integer), CType(CType(69, Byte), Integer))
        Me.btnViewPhoto.OnHoverBorderColor = System.Drawing.Color.Black
        Me.btnViewPhoto.OnHoverForeColor = System.Drawing.Color.White
        Me.btnViewPhoto.OnHoverImage = Nothing
        Me.btnViewPhoto.OnPressedColor = System.Drawing.Color.Black
        Me.btnViewPhoto.Size = New System.Drawing.Size(160, 42)
        Me.btnViewPhoto.TabIndex = 11
        Me.btnViewPhoto.Text = "Select Image"
        '
        'pbPic
        '
        Me.pbPic.BackColor = System.Drawing.Color.White
        Me.pbPic.Location = New System.Drawing.Point(339, 45)
        Me.pbPic.Name = "pbPic"
        Me.pbPic.Size = New System.Drawing.Size(530, 327)
        Me.pbPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbPic.TabIndex = 39
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
        Me.txtplaceofbirth.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtplaceofbirth.Location = New System.Drawing.Point(110, 343)
        Me.txtplaceofbirth.MaxLength = 128
        Me.txtplaceofbirth.Name = "txtplaceofbirth"
        Me.txtplaceofbirth.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtplaceofbirth.Size = New System.Drawing.Size(223, 30)
        Me.txtplaceofbirth.TabIndex = 10
        '
        'GunaLabel12
        '
        Me.GunaLabel12.AutoSize = True
        Me.GunaLabel12.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.GunaLabel12.ForeColor = System.Drawing.Color.Black
        Me.GunaLabel12.Location = New System.Drawing.Point(20, 351)
        Me.GunaLabel12.Name = "GunaLabel12"
        Me.GunaLabel12.Size = New System.Drawing.Size(77, 15)
        Me.GunaLabel12.TabIndex = 37
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
        Me.cbxincome.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.cbxincome.FormattingEnabled = True
        Me.cbxincome.Items.AddRange(New Object() {"SALARY", "BUSINESS"})
        Me.cbxincome.Location = New System.Drawing.Point(110, 313)
        Me.cbxincome.Name = "cbxincome"
        Me.cbxincome.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cbxincome.OnHoverItemForeColor = System.Drawing.Color.White
        Me.cbxincome.Size = New System.Drawing.Size(223, 26)
        Me.cbxincome.TabIndex = 9
        '
        'GunaLabel10
        '
        Me.GunaLabel10.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.GunaLabel10.ForeColor = System.Drawing.Color.Black
        Me.GunaLabel10.Location = New System.Drawing.Point(20, 314)
        Me.GunaLabel10.Name = "GunaLabel10"
        Me.GunaLabel10.Size = New System.Drawing.Size(76, 30)
        Me.GunaLabel10.TabIndex = 34
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
        Me.txtoccupation.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtoccupation.Location = New System.Drawing.Point(110, 279)
        Me.txtoccupation.MaxLength = 32
        Me.txtoccupation.Name = "txtoccupation"
        Me.txtoccupation.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtoccupation.Size = New System.Drawing.Size(223, 30)
        Me.txtoccupation.TabIndex = 8
        '
        'GunaLabel9
        '
        Me.GunaLabel9.AutoSize = True
        Me.GunaLabel9.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.GunaLabel9.ForeColor = System.Drawing.Color.Black
        Me.GunaLabel9.Location = New System.Drawing.Point(20, 285)
        Me.GunaLabel9.Name = "GunaLabel9"
        Me.GunaLabel9.Size = New System.Drawing.Size(69, 15)
        Me.GunaLabel9.TabIndex = 32
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
        Me.txtdob.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtdob.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.txtdob.Location = New System.Drawing.Point(110, 245)
        Me.txtdob.MaxDate = New Date(9998, 12, 31, 0, 0, 0, 0)
        Me.txtdob.MinDate = New Date(1753, 1, 1, 0, 0, 0, 0)
        Me.txtdob.Name = "txtdob"
        Me.txtdob.OnHoverBaseColor = System.Drawing.Color.White
        Me.txtdob.OnHoverBorderColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtdob.OnHoverForeColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtdob.OnPressedColor = System.Drawing.Color.Black
        Me.txtdob.Size = New System.Drawing.Size(223, 30)
        Me.txtdob.TabIndex = 7
        Me.txtdob.Text = "19/11/2019"
        Me.txtdob.Value = New Date(2019, 11, 19, 21, 47, 38, 515)
        '
        'GunaLabel8
        '
        Me.GunaLabel8.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.GunaLabel8.ForeColor = System.Drawing.Color.Black
        Me.GunaLabel8.Location = New System.Drawing.Point(20, 252)
        Me.GunaLabel8.Name = "GunaLabel8"
        Me.GunaLabel8.Size = New System.Drawing.Size(79, 30)
        Me.GunaLabel8.TabIndex = 30
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
        Me.txtphone.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtphone.Location = New System.Drawing.Point(110, 211)
        Me.txtphone.MaxLength = 11
        Me.txtphone.Name = "txtphone"
        Me.txtphone.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtphone.Size = New System.Drawing.Size(223, 30)
        Me.txtphone.TabIndex = 6
        Me.txtphone.Text = "+673"
        '
        'GunaLabel7
        '
        Me.GunaLabel7.AutoSize = True
        Me.GunaLabel7.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.GunaLabel7.ForeColor = System.Drawing.Color.Black
        Me.GunaLabel7.Location = New System.Drawing.Point(20, 218)
        Me.GunaLabel7.Name = "GunaLabel7"
        Me.GunaLabel7.Size = New System.Drawing.Size(88, 15)
        Me.GunaLabel7.TabIndex = 28
        Me.GunaLabel7.Text = "Phone Number"
        '
        'txtaddress
        '
        Me.txtaddress.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtaddress.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtaddress.Location = New System.Drawing.Point(110, 144)
        Me.txtaddress.MaxLength = 1024
        Me.txtaddress.Name = "txtaddress"
        Me.txtaddress.Size = New System.Drawing.Size(223, 63)
        Me.txtaddress.TabIndex = 5
        Me.txtaddress.Text = ""
        '
        'GunaLabel6
        '
        Me.GunaLabel6.AutoSize = True
        Me.GunaLabel6.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.GunaLabel6.ForeColor = System.Drawing.Color.Black
        Me.GunaLabel6.Location = New System.Drawing.Point(20, 146)
        Me.GunaLabel6.Name = "GunaLabel6"
        Me.GunaLabel6.Size = New System.Drawing.Size(49, 15)
        Me.GunaLabel6.TabIndex = 26
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
        Me.cbxnationality.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.cbxnationality.FormattingEnabled = True
        Me.cbxnationality.Items.AddRange(New Object() {"Indonesia", "Brunei", "Malaysia", "Philippines", "Thailand", "Indonesia"})
        Me.cbxnationality.Location = New System.Drawing.Point(110, 114)
        Me.cbxnationality.Name = "cbxnationality"
        Me.cbxnationality.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cbxnationality.OnHoverItemForeColor = System.Drawing.Color.White
        Me.cbxnationality.Size = New System.Drawing.Size(223, 26)
        Me.cbxnationality.TabIndex = 4
        '
        'GunaLabel5
        '
        Me.GunaLabel5.AutoSize = True
        Me.GunaLabel5.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.GunaLabel5.ForeColor = System.Drawing.Color.Black
        Me.GunaLabel5.Location = New System.Drawing.Point(20, 119)
        Me.GunaLabel5.Name = "GunaLabel5"
        Me.GunaLabel5.Size = New System.Drawing.Size(65, 15)
        Me.GunaLabel5.TabIndex = 24
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
        Me.txticpassport.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txticpassport.Location = New System.Drawing.Point(110, 80)
        Me.txticpassport.MaxLength = 32
        Me.txticpassport.Name = "txticpassport"
        Me.txticpassport.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txticpassport.Size = New System.Drawing.Size(223, 30)
        Me.txticpassport.TabIndex = 3
        '
        'GunaLabel4
        '
        Me.GunaLabel4.AutoSize = True
        Me.GunaLabel4.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.GunaLabel4.ForeColor = System.Drawing.Color.Black
        Me.GunaLabel4.Location = New System.Drawing.Point(20, 86)
        Me.GunaLabel4.Name = "GunaLabel4"
        Me.GunaLabel4.Size = New System.Drawing.Size(68, 15)
        Me.GunaLabel4.TabIndex = 22
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
        Me.txtsender.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtsender.Location = New System.Drawing.Point(110, 46)
        Me.txtsender.MaxLength = 128
        Me.txtsender.Name = "txtsender"
        Me.txtsender.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtsender.Size = New System.Drawing.Size(223, 30)
        Me.txtsender.TabIndex = 2
        '
        'GunaLabel2
        '
        Me.GunaLabel2.AutoSize = True
        Me.GunaLabel2.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.GunaLabel2.ForeColor = System.Drawing.Color.Black
        Me.GunaLabel2.Location = New System.Drawing.Point(20, 51)
        Me.GunaLabel2.Name = "GunaLabel2"
        Me.GunaLabel2.Size = New System.Drawing.Size(86, 15)
        Me.GunaLabel2.TabIndex = 20
        Me.GunaLabel2.Text = "Sender's Name"
        '
        'filterpanel
        '
        Me.filterpanel.Controls.Add(Me.Panel3)
        Me.filterpanel.Controls.Add(Me.Panel1)
        Me.filterpanel.Dock = System.Windows.Forms.DockStyle.Top
        Me.filterpanel.Location = New System.Drawing.Point(0, 0)
        Me.filterpanel.Name = "filterpanel"
        Me.filterpanel.Size = New System.Drawing.Size(881, 85)
        Me.filterpanel.TabIndex = 6
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Panel3.Controls.Add(Me.btnCancel)
        Me.Panel3.Controls.Add(Me.btnSave)
        Me.Panel3.Controls.Add(Me.btnNew)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel3.Location = New System.Drawing.Point(0, 42)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(881, 45)
        Me.Panel3.TabIndex = 15
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
        Me.btnCancel.TabIndex = 13
        Me.btnCancel.Text = "Cancel"
        '
        'btnSave
        '
        Me.btnSave.AnimationHoverSpeed = 0.07!
        Me.btnSave.AnimationSpeed = 0.03!
        Me.btnSave.BaseColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(167, Byte), Integer), CType(CType(69, Byte), Integer))
        Me.btnSave.BorderColor = System.Drawing.Color.Black
        Me.btnSave.CheckedBaseColor = System.Drawing.Color.Gray
        Me.btnSave.CheckedBorderColor = System.Drawing.Color.Black
        Me.btnSave.CheckedForeColor = System.Drawing.Color.White
        Me.btnSave.CheckedImage = Global.KREM_SYSTEM.My.Resources.Resources.icons8_edit_50
        Me.btnSave.CheckedLineColor = System.Drawing.Color.DimGray
        Me.btnSave.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btnSave.Dock = System.Windows.Forms.DockStyle.Left
        Me.btnSave.FocusedColor = System.Drawing.Color.Empty
        Me.btnSave.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btnSave.ForeColor = System.Drawing.Color.White
        Me.btnSave.Image = Global.KREM_SYSTEM.My.Resources.Resources.icons8_checkmark_50
        Me.btnSave.ImageSize = New System.Drawing.Size(20, 20)
        Me.btnSave.LineColor = System.Drawing.Color.Empty
        Me.btnSave.Location = New System.Drawing.Point(99, 0)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(79, Byte), Integer))
        Me.btnSave.OnHoverBorderColor = System.Drawing.Color.Black
        Me.btnSave.OnHoverForeColor = System.Drawing.Color.White
        Me.btnSave.OnHoverImage = Nothing
        Me.btnSave.OnHoverLineColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.btnSave.OnPressedColor = System.Drawing.Color.Black
        Me.btnSave.Size = New System.Drawing.Size(99, 45)
        Me.btnSave.TabIndex = 12
        Me.btnSave.Text = "Save"
        '
        'btnNew
        '
        Me.btnNew.AnimationHoverSpeed = 0.07!
        Me.btnNew.AnimationSpeed = 0.03!
        Me.btnNew.BaseColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(123, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnNew.BorderColor = System.Drawing.Color.Black
        Me.btnNew.CheckedBaseColor = System.Drawing.Color.Gray
        Me.btnNew.CheckedBorderColor = System.Drawing.Color.Black
        Me.btnNew.CheckedForeColor = System.Drawing.Color.White
        Me.btnNew.CheckedImage = Global.KREM_SYSTEM.My.Resources.Resources.icons8_edit_50
        Me.btnNew.CheckedLineColor = System.Drawing.Color.DimGray
        Me.btnNew.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btnNew.Dock = System.Windows.Forms.DockStyle.Left
        Me.btnNew.FocusedColor = System.Drawing.Color.Empty
        Me.btnNew.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btnNew.ForeColor = System.Drawing.Color.White
        Me.btnNew.Image = Global.KREM_SYSTEM.My.Resources.Resources.User_32
        Me.btnNew.ImageSize = New System.Drawing.Size(20, 20)
        Me.btnNew.LineColor = System.Drawing.Color.Empty
        Me.btnNew.Location = New System.Drawing.Point(0, 0)
        Me.btnNew.Name = "btnNew"
        Me.btnNew.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(189, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnNew.OnHoverBorderColor = System.Drawing.Color.Black
        Me.btnNew.OnHoverForeColor = System.Drawing.Color.White
        Me.btnNew.OnHoverImage = Nothing
        Me.btnNew.OnHoverLineColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.btnNew.OnPressedColor = System.Drawing.Color.Black
        Me.btnNew.Size = New System.Drawing.Size(99, 45)
        Me.btnNew.TabIndex = 1
        Me.btnNew.Text = "New"
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
        Me.Panel1.TabIndex = 14
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
        Me.btnClose.TabIndex = 14
        '
        'GunaLabel1
        '
        Me.GunaLabel1.AutoSize = True
        Me.GunaLabel1.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel1.Location = New System.Drawing.Point(12, 15)
        Me.GunaLabel1.Name = "GunaLabel1"
        Me.GunaLabel1.Size = New System.Drawing.Size(76, 15)
        Me.GunaLabel1.TabIndex = 0
        Me.GunaLabel1.Text = "New Sender"
        '
        'contentpanel
        '
        Me.contentpanel.Controls.Add(Me.rightpanel)
        Me.contentpanel.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.contentpanel.Location = New System.Drawing.Point(0, 83)
        Me.contentpanel.Name = "contentpanel"
        Me.contentpanel.Size = New System.Drawing.Size(881, 564)
        Me.contentpanel.TabIndex = 7
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'btnRotate
        '
        Me.btnRotate.AnimationHoverSpeed = 0.07!
        Me.btnRotate.AnimationSpeed = 0.03!
        Me.btnRotate.BaseColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnRotate.BorderColor = System.Drawing.Color.Black
        Me.btnRotate.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btnRotate.FocusedColor = System.Drawing.Color.Empty
        Me.btnRotate.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btnRotate.ForeColor = System.Drawing.Color.White
        Me.btnRotate.Image = Global.KREM_SYSTEM.My.Resources.Resources.icons8_restart_50
        Me.btnRotate.ImageSize = New System.Drawing.Size(20, 20)
        Me.btnRotate.Location = New System.Drawing.Point(608, 390)
        Me.btnRotate.Name = "btnRotate"
        Me.btnRotate.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnRotate.OnHoverBorderColor = System.Drawing.Color.Black
        Me.btnRotate.OnHoverForeColor = System.Drawing.Color.White
        Me.btnRotate.OnHoverImage = Nothing
        Me.btnRotate.OnPressedColor = System.Drawing.Color.Black
        Me.btnRotate.Size = New System.Drawing.Size(180, 42)
        Me.btnRotate.TabIndex = 40
        Me.btnRotate.Text = "Rotate Image"
        '
        'frmnewSender
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(881, 647)
        Me.Controls.Add(Me.filterpanel)
        Me.Controls.Add(Me.contentpanel)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmnewSender"
        Me.Text = "frmAddUser"
        Me.rightpanel.ResumeLayout(False)
        Me.gbsenderdetails.ResumeLayout(False)
        Me.gbsenderdetails.PerformLayout()
        CType(Me.pbPic, System.ComponentModel.ISupportInitialize).EndInit()
        Me.filterpanel.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.contentpanel.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents BWorker As System.ComponentModel.BackgroundWorker
    Friend WithEvents Timer1 As Timer
    Friend WithEvents rightpanel As Panel
    Friend WithEvents gbsenderdetails As Guna.UI.WinForms.GunaGroupBox
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
    Friend WithEvents filterpanel As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents btnCancel As Guna.UI.WinForms.GunaAdvenceButton
    Friend WithEvents btnSave As Guna.UI.WinForms.GunaAdvenceButton
    Friend WithEvents btnNew As Guna.UI.WinForms.GunaAdvenceButton
    Friend WithEvents Panel1 As Panel
    Friend WithEvents btnClose As Guna.UI.WinForms.GunaImageButton
    Friend WithEvents GunaLabel1 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents contentpanel As Panel
    Friend WithEvents btnViewPhoto As Guna.UI.WinForms.GunaButton
    Friend WithEvents pbPic As PictureBox
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents btnRotate As Guna.UI.WinForms.GunaButton
End Class
