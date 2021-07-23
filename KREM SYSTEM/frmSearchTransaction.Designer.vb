<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSearchTransaction
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
        Me.gbRemDetails = New Guna.UI.WinForms.GunaGroupBox()
        Me.txttotal = New Guna.UI.WinForms.GunaTextBox()
        Me.GunaLabel22 = New Guna.UI.WinForms.GunaLabel()
        Me.btncalculate = New Bunifu.Framework.UI.BunifuImageButton()
        Me.txtrate = New Guna.UI.WinForms.GunaTextBox()
        Me.GunaLabel17 = New Guna.UI.WinForms.GunaLabel()
        Me.txtcharge = New Guna.UI.WinForms.GunaTextBox()
        Me.GunaLabel18 = New Guna.UI.WinForms.GunaLabel()
        Me.txtamount = New Guna.UI.WinForms.GunaTextBox()
        Me.GunaLabel19 = New Guna.UI.WinForms.GunaLabel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.GunaLabel24 = New Guna.UI.WinForms.GunaLabel()
        Me.txtdate = New Guna.UI.WinForms.GunaDateTimePicker()
        Me.lblserialno = New Guna.UI.WinForms.GunaLabel()
        Me.btnEdit = New Guna.UI.WinForms.GunaAdvenceButton()
        Me.btnUpdate = New Guna.UI.WinForms.GunaAdvenceButton()
        Me.btnCancel = New Guna.UI.WinForms.GunaAdvenceButton()
        Me.btndelete = New Guna.UI.WinForms.GunaAdvenceButton()
        Me.GunaLabel23 = New Guna.UI.WinForms.GunaLabel()
        Me.gbReceiver = New Guna.UI.WinForms.GunaGroupBox()
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
        Me.gbSenderDetails = New Guna.UI.WinForms.GunaGroupBox()
        Me.GunaLabel25 = New Guna.UI.WinForms.GunaLabel()
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
        Me.GunaLabel3 = New Guna.UI.WinForms.GunaLabel()
        Me.txtsearch = New Guna.UI.WinForms.GunaLineTextBox()
        Me.GunaLabel2 = New Guna.UI.WinForms.GunaLabel()
        Me.btnSearch = New Guna.UI.WinForms.GunaButton()
        Me.btnPrint = New Guna.UI.WinForms.GunaImageButton()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.gbRemDetails.SuspendLayout()
        CType(Me.btncalculate, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel3.SuspendLayout()
        Me.gbReceiver.SuspendLayout()
        Me.gbSenderDetails.SuspendLayout()
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
        Me.Panel1.TabIndex = 4
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
        Me.GunaLabel1.Size = New System.Drawing.Size(94, 15)
        Me.GunaLabel1.TabIndex = 0
        Me.GunaLabel1.Text = "Edit Transaction"
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.gbRemDetails)
        Me.Panel2.Controls.Add(Me.Panel3)
        Me.Panel2.Controls.Add(Me.gbReceiver)
        Me.Panel2.Controls.Add(Me.gbSenderDetails)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel2.Location = New System.Drawing.Point(0, 91)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(881, 556)
        Me.Panel2.TabIndex = 5
        '
        'gbRemDetails
        '
        Me.gbRemDetails.BackColor = System.Drawing.Color.Transparent
        Me.gbRemDetails.BaseColor = System.Drawing.Color.Gainsboro
        Me.gbRemDetails.BorderColor = System.Drawing.Color.Gainsboro
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
        Me.gbRemDetails.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbRemDetails.ForeColor = System.Drawing.Color.White
        Me.gbRemDetails.LineBottom = 1
        Me.gbRemDetails.LineColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.gbRemDetails.LineLeft = 1
        Me.gbRemDetails.LineRight = 1
        Me.gbRemDetails.Location = New System.Drawing.Point(455, 321)
        Me.gbRemDetails.Name = "gbRemDetails"
        Me.gbRemDetails.Size = New System.Drawing.Size(423, 232)
        Me.gbRemDetails.TabIndex = 3
        Me.gbRemDetails.Text = "Remittance Details"
        Me.gbRemDetails.TextLocation = New System.Drawing.Point(10, 8)
        '
        'txttotal
        '
        Me.txttotal.BaseColor = System.Drawing.Color.White
        Me.txttotal.BorderColor = System.Drawing.Color.Silver
        Me.txttotal.BorderSize = 1
        Me.txttotal.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txttotal.Enabled = False
        Me.txttotal.FocusedBaseColor = System.Drawing.Color.White
        Me.txttotal.FocusedBorderColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txttotal.FocusedForeColor = System.Drawing.SystemColors.ControlText
        Me.txttotal.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txttotal.ForeColor = System.Drawing.Color.Black
        Me.txttotal.Location = New System.Drawing.Point(151, 187)
        Me.txttotal.MaxLength = 128
        Me.txttotal.Name = "txttotal"
        Me.txttotal.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txttotal.Size = New System.Drawing.Size(262, 32)
        Me.txttotal.TabIndex = 21
        '
        'GunaLabel22
        '
        Me.GunaLabel22.AutoSize = True
        Me.GunaLabel22.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel22.ForeColor = System.Drawing.Color.Black
        Me.GunaLabel22.Location = New System.Drawing.Point(22, 195)
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
        Me.btncalculate.Location = New System.Drawing.Point(151, 149)
        Me.btncalculate.Name = "btncalculate"
        Me.btncalculate.Size = New System.Drawing.Size(32, 32)
        Me.btncalculate.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.btncalculate.TabIndex = 36
        Me.btncalculate.TabStop = False
        Me.btncalculate.Zoom = 10
        '
        'txtrate
        '
        Me.txtrate.BaseColor = System.Drawing.Color.White
        Me.txtrate.BorderColor = System.Drawing.Color.Silver
        Me.txtrate.BorderSize = 1
        Me.txtrate.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtrate.FocusedBaseColor = System.Drawing.Color.White
        Me.txtrate.FocusedBorderColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtrate.FocusedForeColor = System.Drawing.SystemColors.ControlText
        Me.txtrate.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtrate.ForeColor = System.Drawing.Color.Black
        Me.txtrate.Location = New System.Drawing.Point(152, 111)
        Me.txtrate.MaxLength = 128
        Me.txtrate.Name = "txtrate"
        Me.txtrate.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtrate.Size = New System.Drawing.Size(262, 32)
        Me.txtrate.TabIndex = 20
        '
        'GunaLabel17
        '
        Me.GunaLabel17.AutoSize = True
        Me.GunaLabel17.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel17.ForeColor = System.Drawing.Color.Black
        Me.GunaLabel17.Location = New System.Drawing.Point(23, 119)
        Me.GunaLabel17.Name = "GunaLabel17"
        Me.GunaLabel17.Size = New System.Drawing.Size(123, 21)
        Me.GunaLabel17.TabIndex = 34
        Me.GunaLabel17.Text = "Petukaran Wang"
        '
        'txtcharge
        '
        Me.txtcharge.BaseColor = System.Drawing.Color.White
        Me.txtcharge.BorderColor = System.Drawing.Color.Silver
        Me.txtcharge.BorderSize = 1
        Me.txtcharge.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtcharge.FocusedBaseColor = System.Drawing.Color.White
        Me.txtcharge.FocusedBorderColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtcharge.FocusedForeColor = System.Drawing.SystemColors.ControlText
        Me.txtcharge.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtcharge.ForeColor = System.Drawing.Color.Black
        Me.txtcharge.Location = New System.Drawing.Point(152, 73)
        Me.txtcharge.MaxLength = 128
        Me.txtcharge.Name = "txtcharge"
        Me.txtcharge.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtcharge.Size = New System.Drawing.Size(262, 32)
        Me.txtcharge.TabIndex = 19
        '
        'GunaLabel18
        '
        Me.GunaLabel18.AutoSize = True
        Me.GunaLabel18.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel18.ForeColor = System.Drawing.Color.Black
        Me.GunaLabel18.Location = New System.Drawing.Point(23, 80)
        Me.GunaLabel18.Name = "GunaLabel18"
        Me.GunaLabel18.Size = New System.Drawing.Size(114, 21)
        Me.GunaLabel18.TabIndex = 32
        Me.GunaLabel18.Text = "Service Charge"
        '
        'txtamount
        '
        Me.txtamount.BaseColor = System.Drawing.Color.White
        Me.txtamount.BorderColor = System.Drawing.Color.Silver
        Me.txtamount.BorderSize = 1
        Me.txtamount.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtamount.FocusedBaseColor = System.Drawing.Color.White
        Me.txtamount.FocusedBorderColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtamount.FocusedForeColor = System.Drawing.SystemColors.ControlText
        Me.txtamount.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtamount.ForeColor = System.Drawing.Color.Black
        Me.txtamount.Location = New System.Drawing.Point(152, 35)
        Me.txtamount.MaxLength = 128
        Me.txtamount.Name = "txtamount"
        Me.txtamount.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtamount.Size = New System.Drawing.Size(261, 32)
        Me.txtamount.TabIndex = 18
        '
        'GunaLabel19
        '
        Me.GunaLabel19.AutoSize = True
        Me.GunaLabel19.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel19.ForeColor = System.Drawing.Color.Black
        Me.GunaLabel19.Location = New System.Drawing.Point(23, 41)
        Me.GunaLabel19.Name = "GunaLabel19"
        Me.GunaLabel19.Size = New System.Drawing.Size(42, 21)
        Me.GunaLabel19.TabIndex = 30
        Me.GunaLabel19.Text = "BND"
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Panel3.Controls.Add(Me.GunaLabel24)
        Me.Panel3.Controls.Add(Me.txtdate)
        Me.Panel3.Controls.Add(Me.lblserialno)
        Me.Panel3.Controls.Add(Me.btnEdit)
        Me.Panel3.Controls.Add(Me.btnUpdate)
        Me.Panel3.Controls.Add(Me.btnCancel)
        Me.Panel3.Controls.Add(Me.btndelete)
        Me.Panel3.Controls.Add(Me.GunaLabel23)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel3.Location = New System.Drawing.Point(0, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(881, 45)
        Me.Panel3.TabIndex = 2
        '
        'GunaLabel24
        '
        Me.GunaLabel24.AutoSize = True
        Me.GunaLabel24.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel24.Location = New System.Drawing.Point(229, 17)
        Me.GunaLabel24.Name = "GunaLabel24"
        Me.GunaLabel24.Size = New System.Drawing.Size(66, 15)
        Me.GunaLabel24.TabIndex = 34
        Me.GunaLabel24.Text = "Date Sent:"
        '
        'txtdate
        '
        Me.txtdate.BaseColor = System.Drawing.Color.White
        Me.txtdate.BorderColor = System.Drawing.Color.Silver
        Me.txtdate.CustomFormat = "dd/MM/yyyy"
        Me.txtdate.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right
        Me.txtdate.Enabled = False
        Me.txtdate.FocusedColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtdate.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtdate.ForeColor = System.Drawing.Color.Black
        Me.txtdate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.txtdate.Location = New System.Drawing.Point(313, 9)
        Me.txtdate.MaxDate = New Date(9998, 12, 31, 0, 0, 0, 0)
        Me.txtdate.MinDate = New Date(1753, 1, 1, 0, 0, 0, 0)
        Me.txtdate.Name = "txtdate"
        Me.txtdate.OnHoverBaseColor = System.Drawing.Color.White
        Me.txtdate.OnHoverBorderColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtdate.OnHoverForeColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtdate.OnPressedColor = System.Drawing.Color.Black
        Me.txtdate.Size = New System.Drawing.Size(141, 30)
        Me.txtdate.TabIndex = 33
        Me.txtdate.Text = "19/11/2019"
        Me.txtdate.Value = New Date(2019, 11, 19, 21, 47, 38, 515)
        '
        'lblserialno
        '
        Me.lblserialno.AutoSize = True
        Me.lblserialno.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblserialno.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblserialno.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblserialno.ForeColor = System.Drawing.Color.White
        Me.lblserialno.Location = New System.Drawing.Point(110, 13)
        Me.lblserialno.Name = "lblserialno"
        Me.lblserialno.Size = New System.Drawing.Size(84, 23)
        Me.lblserialno.TabIndex = 18
        Me.lblserialno.Text = "00000000"
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
        Me.btnEdit.Dock = System.Windows.Forms.DockStyle.Right
        Me.btnEdit.FocusedColor = System.Drawing.Color.Empty
        Me.btnEdit.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btnEdit.ForeColor = System.Drawing.Color.White
        Me.btnEdit.Image = Global.KREM_SYSTEM.My.Resources.Resources.icons8_edit_50
        Me.btnEdit.ImageSize = New System.Drawing.Size(20, 20)
        Me.btnEdit.LineColor = System.Drawing.Color.Empty
        Me.btnEdit.Location = New System.Drawing.Point(485, 0)
        Me.btnEdit.Name = "btnEdit"
        Me.btnEdit.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(189, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnEdit.OnHoverBorderColor = System.Drawing.Color.Black
        Me.btnEdit.OnHoverForeColor = System.Drawing.Color.White
        Me.btnEdit.OnHoverImage = Nothing
        Me.btnEdit.OnHoverLineColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.btnEdit.OnPressedColor = System.Drawing.Color.Black
        Me.btnEdit.Size = New System.Drawing.Size(99, 45)
        Me.btnEdit.TabIndex = 18
        Me.btnEdit.Text = "Edit"
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
        Me.btnUpdate.Dock = System.Windows.Forms.DockStyle.Right
        Me.btnUpdate.FocusedColor = System.Drawing.Color.Empty
        Me.btnUpdate.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btnUpdate.ForeColor = System.Drawing.Color.White
        Me.btnUpdate.Image = Global.KREM_SYSTEM.My.Resources.Resources.icons8_checkmark_50
        Me.btnUpdate.ImageSize = New System.Drawing.Size(20, 20)
        Me.btnUpdate.LineColor = System.Drawing.Color.Empty
        Me.btnUpdate.Location = New System.Drawing.Point(584, 0)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(79, Byte), Integer))
        Me.btnUpdate.OnHoverBorderColor = System.Drawing.Color.Black
        Me.btnUpdate.OnHoverForeColor = System.Drawing.Color.White
        Me.btnUpdate.OnHoverImage = Nothing
        Me.btnUpdate.OnHoverLineColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.btnUpdate.OnPressedColor = System.Drawing.Color.Black
        Me.btnUpdate.Size = New System.Drawing.Size(99, 45)
        Me.btnUpdate.TabIndex = 17
        Me.btnUpdate.Text = "Update"
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
        Me.btnCancel.Dock = System.Windows.Forms.DockStyle.Right
        Me.btnCancel.FocusedColor = System.Drawing.Color.Empty
        Me.btnCancel.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btnCancel.ForeColor = System.Drawing.Color.White
        Me.btnCancel.Image = Global.KREM_SYSTEM.My.Resources.Resources.Cancel_32
        Me.btnCancel.ImageSize = New System.Drawing.Size(20, 20)
        Me.btnCancel.LineColor = System.Drawing.Color.Empty
        Me.btnCancel.Location = New System.Drawing.Point(683, 0)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(229, Byte), Integer), CType(CType(178, Byte), Integer), CType(CType(23, Byte), Integer))
        Me.btnCancel.OnHoverBorderColor = System.Drawing.Color.Black
        Me.btnCancel.OnHoverForeColor = System.Drawing.Color.White
        Me.btnCancel.OnHoverImage = Nothing
        Me.btnCancel.OnHoverLineColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.btnCancel.OnPressedColor = System.Drawing.Color.Black
        Me.btnCancel.Size = New System.Drawing.Size(99, 45)
        Me.btnCancel.TabIndex = 19
        Me.btnCancel.Text = "Cancel"
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
        Me.btndelete.Dock = System.Windows.Forms.DockStyle.Right
        Me.btndelete.FocusedColor = System.Drawing.Color.Empty
        Me.btndelete.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btndelete.ForeColor = System.Drawing.Color.White
        Me.btndelete.Image = Global.KREM_SYSTEM.My.Resources.Resources.delete1
        Me.btndelete.ImageSize = New System.Drawing.Size(20, 20)
        Me.btndelete.LineColor = System.Drawing.Color.Empty
        Me.btndelete.Location = New System.Drawing.Point(782, 0)
        Me.btndelete.Name = "btndelete"
        Me.btndelete.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(153, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.btndelete.OnHoverBorderColor = System.Drawing.Color.Black
        Me.btndelete.OnHoverForeColor = System.Drawing.Color.White
        Me.btndelete.OnHoverImage = Nothing
        Me.btndelete.OnHoverLineColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.btndelete.OnPressedColor = System.Drawing.Color.Black
        Me.btndelete.Size = New System.Drawing.Size(99, 45)
        Me.btndelete.TabIndex = 20
        Me.btndelete.Text = "Delete"
        '
        'GunaLabel23
        '
        Me.GunaLabel23.AutoSize = True
        Me.GunaLabel23.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel23.Location = New System.Drawing.Point(12, 17)
        Me.GunaLabel23.Name = "GunaLabel23"
        Me.GunaLabel23.Size = New System.Drawing.Size(90, 15)
        Me.GunaLabel23.TabIndex = 9
        Me.GunaLabel23.Text = "Serial Number:"
        '
        'gbReceiver
        '
        Me.gbReceiver.BackColor = System.Drawing.Color.Transparent
        Me.gbReceiver.BaseColor = System.Drawing.Color.White
        Me.gbReceiver.BorderColor = System.Drawing.Color.Gainsboro
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
        Me.gbReceiver.LineBottom = 1
        Me.gbReceiver.LineColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(163, Byte), Integer), CType(CType(69, Byte), Integer))
        Me.gbReceiver.LineLeft = 1
        Me.gbReceiver.LineRight = 1
        Me.gbReceiver.Location = New System.Drawing.Point(455, 45)
        Me.gbReceiver.Name = "gbReceiver"
        Me.gbReceiver.Size = New System.Drawing.Size(423, 276)
        Me.gbReceiver.TabIndex = 1
        Me.gbReceiver.Text = "Receiver"
        Me.gbReceiver.TextLocation = New System.Drawing.Point(10, 8)
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
        Me.txtcity.Location = New System.Drawing.Point(116, 65)
        Me.txtcity.MaxLength = 128
        Me.txtcity.Name = "txtcity"
        Me.txtcity.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtcity.Size = New System.Drawing.Size(297, 30)
        Me.txtcity.TabIndex = 12
        '
        'GunaLabel20
        '
        Me.GunaLabel20.AutoSize = True
        Me.GunaLabel20.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.GunaLabel20.Location = New System.Drawing.Point(23, 71)
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
        Me.cbxcountry.Location = New System.Drawing.Point(116, 37)
        Me.cbxcountry.Name = "cbxcountry"
        Me.cbxcountry.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cbxcountry.OnHoverItemForeColor = System.Drawing.Color.White
        Me.cbxcountry.Size = New System.Drawing.Size(297, 26)
        Me.cbxcountry.TabIndex = 11
        '
        'GunaLabel21
        '
        Me.GunaLabel21.AutoSize = True
        Me.GunaLabel21.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.GunaLabel21.Location = New System.Drawing.Point(23, 42)
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
        Me.txtbranch.Location = New System.Drawing.Point(116, 221)
        Me.txtbranch.MaxLength = 128
        Me.txtbranch.Name = "txtbranch"
        Me.txtbranch.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtbranch.Size = New System.Drawing.Size(297, 30)
        Me.txtbranch.TabIndex = 17
        '
        'GunaLabel16
        '
        Me.GunaLabel16.AutoSize = True
        Me.GunaLabel16.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.GunaLabel16.Location = New System.Drawing.Point(23, 228)
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
        Me.txtbank.Location = New System.Drawing.Point(116, 189)
        Me.txtbank.MaxLength = 128
        Me.txtbank.Name = "txtbank"
        Me.txtbank.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtbank.Size = New System.Drawing.Size(297, 30)
        Me.txtbank.TabIndex = 16
        '
        'GunaLabel15
        '
        Me.GunaLabel15.AutoSize = True
        Me.GunaLabel15.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.GunaLabel15.Location = New System.Drawing.Point(23, 195)
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
        Me.txtaccountno.Location = New System.Drawing.Point(116, 157)
        Me.txtaccountno.MaxLength = 128
        Me.txtaccountno.Name = "txtaccountno"
        Me.txtaccountno.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtaccountno.Size = New System.Drawing.Size(297, 30)
        Me.txtaccountno.TabIndex = 15
        '
        'GunaLabel14
        '
        Me.GunaLabel14.AutoSize = True
        Me.GunaLabel14.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.GunaLabel14.Location = New System.Drawing.Point(23, 163)
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
        Me.txtreceiver.Location = New System.Drawing.Point(116, 125)
        Me.txtreceiver.MaxLength = 128
        Me.txtreceiver.Name = "txtreceiver"
        Me.txtreceiver.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtreceiver.Size = New System.Drawing.Size(297, 30)
        Me.txtreceiver.TabIndex = 14
        '
        'GunaLabel13
        '
        Me.GunaLabel13.AutoSize = True
        Me.GunaLabel13.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.GunaLabel13.Location = New System.Drawing.Point(23, 131)
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
        Me.cbxreceiver.Location = New System.Drawing.Point(116, 97)
        Me.cbxreceiver.Name = "cbxreceiver"
        Me.cbxreceiver.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cbxreceiver.OnHoverItemForeColor = System.Drawing.Color.White
        Me.cbxreceiver.Size = New System.Drawing.Size(297, 26)
        Me.cbxreceiver.TabIndex = 13
        '
        'GunaLabel11
        '
        Me.GunaLabel11.AutoSize = True
        Me.GunaLabel11.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.GunaLabel11.Location = New System.Drawing.Point(23, 102)
        Me.GunaLabel11.Name = "GunaLabel11"
        Me.GunaLabel11.Size = New System.Drawing.Size(51, 15)
        Me.GunaLabel11.TabIndex = 26
        Me.GunaLabel11.Text = "Receiver"
        '
        'gbSenderDetails
        '
        Me.gbSenderDetails.BackColor = System.Drawing.Color.Transparent
        Me.gbSenderDetails.BaseColor = System.Drawing.Color.White
        Me.gbSenderDetails.BorderColor = System.Drawing.Color.Gainsboro
        Me.gbSenderDetails.Controls.Add(Me.GunaLabel25)
        Me.gbSenderDetails.Controls.Add(Me.txtplaceofbirth)
        Me.gbSenderDetails.Controls.Add(Me.GunaLabel12)
        Me.gbSenderDetails.Controls.Add(Me.cbxincome)
        Me.gbSenderDetails.Controls.Add(Me.GunaLabel10)
        Me.gbSenderDetails.Controls.Add(Me.txtoccupation)
        Me.gbSenderDetails.Controls.Add(Me.GunaLabel9)
        Me.gbSenderDetails.Controls.Add(Me.txtdob)
        Me.gbSenderDetails.Controls.Add(Me.GunaLabel8)
        Me.gbSenderDetails.Controls.Add(Me.txtphone)
        Me.gbSenderDetails.Controls.Add(Me.GunaLabel7)
        Me.gbSenderDetails.Controls.Add(Me.txtaddress)
        Me.gbSenderDetails.Controls.Add(Me.GunaLabel6)
        Me.gbSenderDetails.Controls.Add(Me.cbxnationality)
        Me.gbSenderDetails.Controls.Add(Me.GunaLabel5)
        Me.gbSenderDetails.Controls.Add(Me.txticpassport)
        Me.gbSenderDetails.Controls.Add(Me.GunaLabel4)
        Me.gbSenderDetails.Controls.Add(Me.txtsender)
        Me.gbSenderDetails.Controls.Add(Me.GunaLabel3)
        Me.gbSenderDetails.Enabled = False
        Me.gbSenderDetails.LineBottom = 1
        Me.gbSenderDetails.LineColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(163, Byte), Integer), CType(CType(69, Byte), Integer))
        Me.gbSenderDetails.LineLeft = 1
        Me.gbSenderDetails.LineRight = 1
        Me.gbSenderDetails.Location = New System.Drawing.Point(0, 45)
        Me.gbSenderDetails.Name = "gbSenderDetails"
        Me.gbSenderDetails.Size = New System.Drawing.Size(454, 508)
        Me.gbSenderDetails.TabIndex = 0
        Me.gbSenderDetails.Text = "Sender Detail"
        Me.gbSenderDetails.TextLocation = New System.Drawing.Point(10, 8)
        '
        'GunaLabel25
        '
        Me.GunaLabel25.AutoSize = True
        Me.GunaLabel25.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel25.Location = New System.Drawing.Point(96, 48)
        Me.GunaLabel25.Name = "GunaLabel25"
        Me.GunaLabel25.Size = New System.Drawing.Size(343, 15)
        Me.GunaLabel25.TabIndex = 35
        Me.GunaLabel25.Text = "*to Edit the sender, close this form and open ""Customer List"""
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
        Me.txtplaceofbirth.Location = New System.Drawing.Point(110, 386)
        Me.txtplaceofbirth.MaxLength = 128
        Me.txtplaceofbirth.Name = "txtplaceofbirth"
        Me.txtplaceofbirth.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtplaceofbirth.Size = New System.Drawing.Size(297, 30)
        Me.txtplaceofbirth.TabIndex = 10
        '
        'GunaLabel12
        '
        Me.GunaLabel12.AutoSize = True
        Me.GunaLabel12.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.GunaLabel12.Location = New System.Drawing.Point(20, 394)
        Me.GunaLabel12.Name = "GunaLabel12"
        Me.GunaLabel12.Size = New System.Drawing.Size(77, 15)
        Me.GunaLabel12.TabIndex = 36
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
        Me.cbxincome.ForeColor = System.Drawing.Color.Black
        Me.cbxincome.FormattingEnabled = True
        Me.cbxincome.Items.AddRange(New Object() {"SALARY", "BUSINESS"})
        Me.cbxincome.Location = New System.Drawing.Point(110, 356)
        Me.cbxincome.Name = "cbxincome"
        Me.cbxincome.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cbxincome.OnHoverItemForeColor = System.Drawing.Color.White
        Me.cbxincome.Size = New System.Drawing.Size(297, 26)
        Me.cbxincome.TabIndex = 9
        '
        'GunaLabel10
        '
        Me.GunaLabel10.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.GunaLabel10.Location = New System.Drawing.Point(20, 357)
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
        Me.txtoccupation.Location = New System.Drawing.Point(110, 322)
        Me.txtoccupation.MaxLength = 32
        Me.txtoccupation.Name = "txtoccupation"
        Me.txtoccupation.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtoccupation.Size = New System.Drawing.Size(297, 30)
        Me.txtoccupation.TabIndex = 8
        '
        'GunaLabel9
        '
        Me.GunaLabel9.AutoSize = True
        Me.GunaLabel9.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.GunaLabel9.Location = New System.Drawing.Point(17, 328)
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
        Me.txtdob.ForeColor = System.Drawing.Color.Black
        Me.txtdob.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.txtdob.Location = New System.Drawing.Point(110, 288)
        Me.txtdob.MaxDate = New Date(9998, 12, 31, 0, 0, 0, 0)
        Me.txtdob.MinDate = New Date(1753, 1, 1, 0, 0, 0, 0)
        Me.txtdob.Name = "txtdob"
        Me.txtdob.OnHoverBaseColor = System.Drawing.Color.White
        Me.txtdob.OnHoverBorderColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtdob.OnHoverForeColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtdob.OnPressedColor = System.Drawing.Color.Black
        Me.txtdob.Size = New System.Drawing.Size(297, 30)
        Me.txtdob.TabIndex = 7
        Me.txtdob.Text = "19/11/2019"
        Me.txtdob.Value = New Date(2019, 11, 19, 21, 47, 38, 515)
        '
        'GunaLabel8
        '
        Me.GunaLabel8.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.GunaLabel8.Location = New System.Drawing.Point(17, 295)
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
        Me.txtphone.Location = New System.Drawing.Point(110, 254)
        Me.txtphone.MaxLength = 11
        Me.txtphone.Name = "txtphone"
        Me.txtphone.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtphone.Size = New System.Drawing.Size(297, 30)
        Me.txtphone.TabIndex = 6
        Me.txtphone.Text = "+673"
        '
        'GunaLabel7
        '
        Me.GunaLabel7.AutoSize = True
        Me.GunaLabel7.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.GunaLabel7.Location = New System.Drawing.Point(17, 261)
        Me.GunaLabel7.Name = "GunaLabel7"
        Me.GunaLabel7.Size = New System.Drawing.Size(88, 15)
        Me.GunaLabel7.TabIndex = 28
        Me.GunaLabel7.Text = "Phone Number"
        '
        'txtaddress
        '
        Me.txtaddress.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtaddress.Location = New System.Drawing.Point(110, 187)
        Me.txtaddress.MaxLength = 1024
        Me.txtaddress.Name = "txtaddress"
        Me.txtaddress.Size = New System.Drawing.Size(297, 63)
        Me.txtaddress.TabIndex = 5
        Me.txtaddress.Text = ""
        '
        'GunaLabel6
        '
        Me.GunaLabel6.AutoSize = True
        Me.GunaLabel6.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.GunaLabel6.Location = New System.Drawing.Point(17, 189)
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
        Me.cbxnationality.ForeColor = System.Drawing.Color.Black
        Me.cbxnationality.FormattingEnabled = True
        Me.cbxnationality.Items.AddRange(New Object() {"Indonesia", "Brunei", "Malaysia", "Philippines", "Thailand", "Indonesia"})
        Me.cbxnationality.Location = New System.Drawing.Point(110, 157)
        Me.cbxnationality.Name = "cbxnationality"
        Me.cbxnationality.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cbxnationality.OnHoverItemForeColor = System.Drawing.Color.White
        Me.cbxnationality.Size = New System.Drawing.Size(297, 26)
        Me.cbxnationality.TabIndex = 4
        '
        'GunaLabel5
        '
        Me.GunaLabel5.AutoSize = True
        Me.GunaLabel5.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.GunaLabel5.Location = New System.Drawing.Point(17, 162)
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
        Me.txticpassport.Location = New System.Drawing.Point(110, 123)
        Me.txticpassport.MaxLength = 32
        Me.txticpassport.Name = "txticpassport"
        Me.txticpassport.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txticpassport.Size = New System.Drawing.Size(297, 30)
        Me.txticpassport.TabIndex = 3
        '
        'GunaLabel4
        '
        Me.GunaLabel4.AutoSize = True
        Me.GunaLabel4.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.GunaLabel4.Location = New System.Drawing.Point(17, 129)
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
        Me.txtsender.Location = New System.Drawing.Point(110, 89)
        Me.txtsender.MaxLength = 128
        Me.txtsender.Name = "txtsender"
        Me.txtsender.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtsender.Size = New System.Drawing.Size(297, 30)
        Me.txtsender.TabIndex = 2
        '
        'GunaLabel3
        '
        Me.GunaLabel3.AutoSize = True
        Me.GunaLabel3.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.GunaLabel3.Location = New System.Drawing.Point(17, 94)
        Me.GunaLabel3.Name = "GunaLabel3"
        Me.GunaLabel3.Size = New System.Drawing.Size(86, 15)
        Me.GunaLabel3.TabIndex = 20
        Me.GunaLabel3.Text = "Sender's Name"
        '
        'txtsearch
        '
        Me.txtsearch.Animated = True
        Me.txtsearch.BackColor = System.Drawing.Color.White
        Me.txtsearch.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtsearch.FocusedLineColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtsearch.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtsearch.LineColor = System.Drawing.Color.Gainsboro
        Me.txtsearch.Location = New System.Drawing.Point(135, 53)
        Me.txtsearch.MaxLength = 16
        Me.txtsearch.Name = "txtsearch"
        Me.txtsearch.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtsearch.Size = New System.Drawing.Size(160, 26)
        Me.txtsearch.TabIndex = 0
        '
        'GunaLabel2
        '
        Me.GunaLabel2.AutoSize = True
        Me.GunaLabel2.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.GunaLabel2.Location = New System.Drawing.Point(15, 59)
        Me.GunaLabel2.Name = "GunaLabel2"
        Me.GunaLabel2.Size = New System.Drawing.Size(115, 15)
        Me.GunaLabel2.TabIndex = 7
        Me.GunaLabel2.Text = "Enter Serial Number:"
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
        Me.btnSearch.Location = New System.Drawing.Point(313, 51)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnSearch.OnHoverBorderColor = System.Drawing.Color.Black
        Me.btnSearch.OnHoverForeColor = System.Drawing.Color.White
        Me.btnSearch.OnHoverImage = Nothing
        Me.btnSearch.OnPressedColor = System.Drawing.Color.Black
        Me.btnSearch.Size = New System.Drawing.Size(160, 30)
        Me.btnSearch.TabIndex = 1
        Me.btnSearch.Text = "Search"
        '
        'btnPrint
        '
        Me.btnPrint.BackColor = System.Drawing.Color.White
        Me.btnPrint.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnPrint.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btnPrint.Image = Global.KREM_SYSTEM.My.Resources.Resources.printer
        Me.btnPrint.ImageSize = New System.Drawing.Size(40, 40)
        Me.btnPrint.Location = New System.Drawing.Point(818, 45)
        Me.btnPrint.Name = "btnPrint"
        Me.btnPrint.OnHoverImage = Nothing
        Me.btnPrint.OnHoverImageOffset = New System.Drawing.Point(0, 0)
        Me.btnPrint.Size = New System.Drawing.Size(51, 46)
        Me.btnPrint.TabIndex = 15
        '
        'frmSearchTransaction
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(881, 647)
        Me.Controls.Add(Me.btnPrint)
        Me.Controls.Add(Me.btnSearch)
        Me.Controls.Add(Me.GunaLabel2)
        Me.Controls.Add(Me.txtsearch)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmSearchTransaction"
        Me.Text = "frmSearchTransaction"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.gbRemDetails.ResumeLayout(False)
        Me.gbRemDetails.PerformLayout()
        CType(Me.btncalculate, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.gbReceiver.ResumeLayout(False)
        Me.gbReceiver.PerformLayout()
        Me.gbSenderDetails.ResumeLayout(False)
        Me.gbSenderDetails.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents btnClose As Guna.UI.WinForms.GunaImageButton
    Friend WithEvents GunaLabel1 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents txtsearch As Guna.UI.WinForms.GunaLineTextBox
    Friend WithEvents GunaLabel2 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents btnSearch As Guna.UI.WinForms.GunaButton
    Friend WithEvents gbSenderDetails As Guna.UI.WinForms.GunaGroupBox
    Friend WithEvents gbReceiver As Guna.UI.WinForms.GunaGroupBox
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
    Friend WithEvents GunaLabel3 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents gbRemDetails As Guna.UI.WinForms.GunaGroupBox
    Friend WithEvents btncalculate As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents txtrate As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents GunaLabel17 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents txtcharge As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents GunaLabel18 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents txtamount As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents GunaLabel19 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents txtcity As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents GunaLabel20 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents cbxcountry As Guna.UI.WinForms.GunaComboBox
    Friend WithEvents GunaLabel21 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents txttotal As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents GunaLabel22 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents lblserialno As Guna.UI.WinForms.GunaLabel
    Friend WithEvents btnEdit As Guna.UI.WinForms.GunaAdvenceButton
    Friend WithEvents btnUpdate As Guna.UI.WinForms.GunaAdvenceButton
    Friend WithEvents btnCancel As Guna.UI.WinForms.GunaAdvenceButton
    Friend WithEvents btndelete As Guna.UI.WinForms.GunaAdvenceButton
    Friend WithEvents GunaLabel23 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents GunaLabel24 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents txtdate As Guna.UI.WinForms.GunaDateTimePicker
    Friend WithEvents btnPrint As Guna.UI.WinForms.GunaImageButton
    Friend WithEvents GunaLabel25 As Guna.UI.WinForms.GunaLabel
End Class
