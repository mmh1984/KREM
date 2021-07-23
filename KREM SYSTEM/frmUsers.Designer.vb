<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmUsers
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
        Me.gbUsers = New Guna.UI.WinForms.GunaGroupBox()
        Me.gbUserDetails = New Guna.UI.WinForms.GunaGroupBox()
        Me.GunaLabel7 = New Guna.UI.WinForms.GunaLabel()
        Me.cbCounter = New Guna.UI.WinForms.GunaComboBox()
        Me.cbshowpass = New Guna.UI.WinForms.GunaCheckBox()
        Me.GunaLabel5 = New Guna.UI.WinForms.GunaLabel()
        Me.GunaLabel4 = New Guna.UI.WinForms.GunaLabel()
        Me.btnCancel = New Guna.UI.WinForms.GunaButton()
        Me.btnDelete = New Guna.UI.WinForms.GunaButton()
        Me.btnSave = New Guna.UI.WinForms.GunaButton()
        Me.GunaLabel3 = New Guna.UI.WinForms.GunaLabel()
        Me.txtpassword = New Guna.UI.WinForms.GunaLineTextBox()
        Me.GunaLabel2 = New Guna.UI.WinForms.GunaLabel()
        Me.txtusername = New Guna.UI.WinForms.GunaLineTextBox()
        Me.lvUsers = New System.Windows.Forms.ListView()
        Me.No = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Username = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.btnAdd = New Guna.UI.WinForms.GunaButton()
        Me.txtsearch = New Guna.UI.WinForms.GunaTextBox()
        Me.GunaLabel6 = New Guna.UI.WinForms.GunaLabel()
        Me.btnsearch = New Guna.UI.WinForms.GunaButton()
        Me.Panel1.SuspendLayout()
        Me.gbUsers.SuspendLayout()
        Me.gbUserDetails.SuspendLayout()
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
        Me.GunaLabel1.Size = New System.Drawing.Size(38, 15)
        Me.GunaLabel1.TabIndex = 0
        Me.GunaLabel1.Text = "Users"
        '
        'gbUsers
        '
        Me.gbUsers.BackColor = System.Drawing.Color.Transparent
        Me.gbUsers.BaseColor = System.Drawing.Color.White
        Me.gbUsers.BorderColor = System.Drawing.Color.Gainsboro
        Me.gbUsers.Controls.Add(Me.gbUserDetails)
        Me.gbUsers.Controls.Add(Me.lvUsers)
        Me.gbUsers.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.gbUsers.ForeColor = System.Drawing.Color.White
        Me.gbUsers.LineColor = System.Drawing.Color.FromArgb(CType(CType(107, Byte), Integer), CType(CType(117, Byte), Integer), CType(CType(125, Byte), Integer))
        Me.gbUsers.Location = New System.Drawing.Point(0, 101)
        Me.gbUsers.Name = "gbUsers"
        Me.gbUsers.Size = New System.Drawing.Size(881, 546)
        Me.gbUsers.TabIndex = 4
        Me.gbUsers.Text = "List of Users"
        Me.gbUsers.TextLocation = New System.Drawing.Point(10, 8)
        '
        'gbUserDetails
        '
        Me.gbUserDetails.BackColor = System.Drawing.Color.Transparent
        Me.gbUserDetails.BaseColor = System.Drawing.Color.White
        Me.gbUserDetails.BorderColor = System.Drawing.Color.Gainsboro
        Me.gbUserDetails.Controls.Add(Me.GunaLabel7)
        Me.gbUserDetails.Controls.Add(Me.cbCounter)
        Me.gbUserDetails.Controls.Add(Me.cbshowpass)
        Me.gbUserDetails.Controls.Add(Me.GunaLabel5)
        Me.gbUserDetails.Controls.Add(Me.GunaLabel4)
        Me.gbUserDetails.Controls.Add(Me.btnCancel)
        Me.gbUserDetails.Controls.Add(Me.btnDelete)
        Me.gbUserDetails.Controls.Add(Me.btnSave)
        Me.gbUserDetails.Controls.Add(Me.GunaLabel3)
        Me.gbUserDetails.Controls.Add(Me.txtpassword)
        Me.gbUserDetails.Controls.Add(Me.GunaLabel2)
        Me.gbUserDetails.Controls.Add(Me.txtusername)
        Me.gbUserDetails.LineBottom = 1
        Me.gbUserDetails.LineColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(163, Byte), Integer), CType(CType(69, Byte), Integer))
        Me.gbUserDetails.LineLeft = 1
        Me.gbUserDetails.LineRight = 1
        Me.gbUserDetails.Location = New System.Drawing.Point(462, 29)
        Me.gbUserDetails.Name = "gbUserDetails"
        Me.gbUserDetails.Size = New System.Drawing.Size(419, 457)
        Me.gbUserDetails.TabIndex = 1
        Me.gbUserDetails.Text = "Add User"
        Me.gbUserDetails.TextLocation = New System.Drawing.Point(10, 8)
        '
        'GunaLabel7
        '
        Me.GunaLabel7.AutoSize = True
        Me.GunaLabel7.Font = New System.Drawing.Font("Segoe UI Semilight", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel7.ForeColor = System.Drawing.Color.Black
        Me.GunaLabel7.Location = New System.Drawing.Point(12, 163)
        Me.GunaLabel7.Name = "GunaLabel7"
        Me.GunaLabel7.Size = New System.Drawing.Size(98, 15)
        Me.GunaLabel7.TabIndex = 13
        Me.GunaLabel7.Text = "Counter Number:"
        '
        'cbCounter
        '
        Me.cbCounter.BackColor = System.Drawing.Color.Transparent
        Me.cbCounter.BaseColor = System.Drawing.Color.White
        Me.cbCounter.BorderColor = System.Drawing.Color.Silver
        Me.cbCounter.BorderSize = 1
        Me.cbCounter.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cbCounter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbCounter.FocusedColor = System.Drawing.Color.Empty
        Me.cbCounter.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.cbCounter.ForeColor = System.Drawing.Color.Black
        Me.cbCounter.FormattingEnabled = True
        Me.cbCounter.Items.AddRange(New Object() {"1", "2", "3", "4"})
        Me.cbCounter.Location = New System.Drawing.Point(132, 158)
        Me.cbCounter.Name = "cbCounter"
        Me.cbCounter.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cbCounter.OnHoverItemForeColor = System.Drawing.Color.White
        Me.cbCounter.Size = New System.Drawing.Size(121, 26)
        Me.cbCounter.TabIndex = 12
        '
        'cbshowpass
        '
        Me.cbshowpass.BaseColor = System.Drawing.Color.White
        Me.cbshowpass.CheckedOffColor = System.Drawing.Color.Gray
        Me.cbshowpass.CheckedOnColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cbshowpass.FillColor = System.Drawing.Color.White
        Me.cbshowpass.ForeColor = System.Drawing.Color.Black
        Me.cbshowpass.Location = New System.Drawing.Point(283, 182)
        Me.cbshowpass.Name = "cbshowpass"
        Me.cbshowpass.Size = New System.Drawing.Size(111, 20)
        Me.cbshowpass.TabIndex = 11
        Me.cbshowpass.Text = "Show Password"
        '
        'GunaLabel5
        '
        Me.GunaLabel5.AutoSize = True
        Me.GunaLabel5.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel5.ForeColor = System.Drawing.Color.Red
        Me.GunaLabel5.Location = New System.Drawing.Point(62, 63)
        Me.GunaLabel5.Name = "GunaLabel5"
        Me.GunaLabel5.Size = New System.Drawing.Size(302, 15)
        Me.GunaLabel5.TabIndex = 10
        Me.GunaLabel5.Text = "*Username must be at least 4 charcters (maximum of 16)"
        '
        'GunaLabel4
        '
        Me.GunaLabel4.AutoSize = True
        Me.GunaLabel4.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel4.ForeColor = System.Drawing.Color.Red
        Me.GunaLabel4.Location = New System.Drawing.Point(62, 46)
        Me.GunaLabel4.Name = "GunaLabel4"
        Me.GunaLabel4.Size = New System.Drawing.Size(332, 15)
        Me.GunaLabel4.TabIndex = 9
        Me.GunaLabel4.Text = "*Password must be at least 6 characters long (Maximum of 16)"
        '
        'btnCancel
        '
        Me.btnCancel.AnimationHoverSpeed = 0.07!
        Me.btnCancel.AnimationSpeed = 0.03!
        Me.btnCancel.BaseColor = System.Drawing.Color.FromArgb(CType(CType(254, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(1, Byte), Integer))
        Me.btnCancel.BorderColor = System.Drawing.Color.Black
        Me.btnCancel.FocusedColor = System.Drawing.Color.Empty
        Me.btnCancel.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btnCancel.ForeColor = System.Drawing.Color.White
        Me.btnCancel.Image = Global.KREM_SYSTEM.My.Resources.Resources.Cancel_32
        Me.btnCancel.ImageSize = New System.Drawing.Size(20, 20)
        Me.btnCancel.Location = New System.Drawing.Point(152, 222)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.OnHoverBaseColor = System.Drawing.Color.Maroon
        Me.btnCancel.OnHoverBorderColor = System.Drawing.Color.Black
        Me.btnCancel.OnHoverForeColor = System.Drawing.Color.White
        Me.btnCancel.OnHoverImage = Nothing
        Me.btnCancel.OnPressedColor = System.Drawing.Color.Black
        Me.btnCancel.Size = New System.Drawing.Size(123, 42)
        Me.btnCancel.TabIndex = 8
        Me.btnCancel.Text = "Cancel"
        '
        'btnDelete
        '
        Me.btnDelete.AnimationHoverSpeed = 0.07!
        Me.btnDelete.AnimationSpeed = 0.03!
        Me.btnDelete.BaseColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.btnDelete.BorderColor = System.Drawing.Color.Black
        Me.btnDelete.FocusedColor = System.Drawing.Color.Empty
        Me.btnDelete.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btnDelete.ForeColor = System.Drawing.Color.White
        Me.btnDelete.Image = Global.KREM_SYSTEM.My.Resources.Resources.delete
        Me.btnDelete.ImageSize = New System.Drawing.Size(20, 20)
        Me.btnDelete.Location = New System.Drawing.Point(281, 222)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.OnHoverBaseColor = System.Drawing.Color.Maroon
        Me.btnDelete.OnHoverBorderColor = System.Drawing.Color.Black
        Me.btnDelete.OnHoverForeColor = System.Drawing.Color.White
        Me.btnDelete.OnHoverImage = Nothing
        Me.btnDelete.OnPressedColor = System.Drawing.Color.Black
        Me.btnDelete.Size = New System.Drawing.Size(123, 42)
        Me.btnDelete.TabIndex = 7
        Me.btnDelete.Text = "delete"
        '
        'btnSave
        '
        Me.btnSave.AnimationHoverSpeed = 0.07!
        Me.btnSave.AnimationSpeed = 0.03!
        Me.btnSave.BaseColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(163, Byte), Integer), CType(CType(69, Byte), Integer))
        Me.btnSave.BorderColor = System.Drawing.Color.Black
        Me.btnSave.FocusedColor = System.Drawing.Color.Empty
        Me.btnSave.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btnSave.ForeColor = System.Drawing.Color.White
        Me.btnSave.Image = Global.KREM_SYSTEM.My.Resources.Resources.Save_48
        Me.btnSave.ImageSize = New System.Drawing.Size(20, 20)
        Me.btnSave.Location = New System.Drawing.Point(15, 222)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnSave.OnHoverBorderColor = System.Drawing.Color.Black
        Me.btnSave.OnHoverForeColor = System.Drawing.Color.White
        Me.btnSave.OnHoverImage = Nothing
        Me.btnSave.OnPressedColor = System.Drawing.Color.Black
        Me.btnSave.Size = New System.Drawing.Size(126, 42)
        Me.btnSave.TabIndex = 6
        Me.btnSave.Text = "Save"
        '
        'GunaLabel3
        '
        Me.GunaLabel3.AutoSize = True
        Me.GunaLabel3.Font = New System.Drawing.Font("Segoe UI Semilight", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel3.ForeColor = System.Drawing.Color.Black
        Me.GunaLabel3.Location = New System.Drawing.Point(44, 131)
        Me.GunaLabel3.Name = "GunaLabel3"
        Me.GunaLabel3.Size = New System.Drawing.Size(59, 15)
        Me.GunaLabel3.TabIndex = 5
        Me.GunaLabel3.Text = "Password:"
        '
        'txtpassword
        '
        Me.txtpassword.Animated = True
        Me.txtpassword.BackColor = System.Drawing.Color.White
        Me.txtpassword.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtpassword.FocusedLineColor = System.Drawing.Color.Green
        Me.txtpassword.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtpassword.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtpassword.LineColor = System.Drawing.Color.DodgerBlue
        Me.txtpassword.Location = New System.Drawing.Point(132, 120)
        Me.txtpassword.MaxLength = 16
        Me.txtpassword.Name = "txtpassword"
        Me.txtpassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtpassword.Size = New System.Drawing.Size(262, 26)
        Me.txtpassword.TabIndex = 4
        Me.txtpassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'GunaLabel2
        '
        Me.GunaLabel2.AutoSize = True
        Me.GunaLabel2.Font = New System.Drawing.Font("Segoe UI Semilight", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel2.ForeColor = System.Drawing.Color.Black
        Me.GunaLabel2.Location = New System.Drawing.Point(44, 99)
        Me.GunaLabel2.Name = "GunaLabel2"
        Me.GunaLabel2.Size = New System.Drawing.Size(62, 15)
        Me.GunaLabel2.TabIndex = 3
        Me.GunaLabel2.Text = "Username:"
        '
        'txtusername
        '
        Me.txtusername.Animated = True
        Me.txtusername.BackColor = System.Drawing.Color.White
        Me.txtusername.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtusername.FocusedLineColor = System.Drawing.Color.Green
        Me.txtusername.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtusername.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtusername.LineColor = System.Drawing.Color.DodgerBlue
        Me.txtusername.Location = New System.Drawing.Point(132, 88)
        Me.txtusername.MaxLength = 16
        Me.txtusername.Name = "txtusername"
        Me.txtusername.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtusername.Size = New System.Drawing.Size(262, 26)
        Me.txtusername.TabIndex = 2
        Me.txtusername.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lvUsers
        '
        Me.lvUsers.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.No, Me.Username, Me.ColumnHeader1, Me.ColumnHeader2})
        Me.lvUsers.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lvUsers.FullRowSelect = True
        Me.lvUsers.GridLines = True
        Me.lvUsers.Location = New System.Drawing.Point(0, 29)
        Me.lvUsers.Name = "lvUsers"
        Me.lvUsers.Size = New System.Drawing.Size(464, 457)
        Me.lvUsers.TabIndex = 0
        Me.lvUsers.UseCompatibleStateImageBehavior = False
        Me.lvUsers.View = System.Windows.Forms.View.Details
        '
        'No
        '
        Me.No.Text = "No"
        '
        'Username
        '
        Me.Username.Text = "User Name"
        Me.Username.Width = 200
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "User Level"
        Me.ColumnHeader1.Width = 100
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Counter Number"
        Me.ColumnHeader2.Width = 100
        '
        'btnAdd
        '
        Me.btnAdd.AnimationHoverSpeed = 0.07!
        Me.btnAdd.AnimationSpeed = 0.03!
        Me.btnAdd.BaseColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(163, Byte), Integer), CType(CType(69, Byte), Integer))
        Me.btnAdd.BorderColor = System.Drawing.Color.Black
        Me.btnAdd.FocusedColor = System.Drawing.Color.Empty
        Me.btnAdd.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btnAdd.ForeColor = System.Drawing.Color.White
        Me.btnAdd.Image = Global.KREM_SYSTEM.My.Resources.Resources.User_32
        Me.btnAdd.ImageSize = New System.Drawing.Size(20, 20)
        Me.btnAdd.Location = New System.Drawing.Point(12, 53)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnAdd.OnHoverBorderColor = System.Drawing.Color.Black
        Me.btnAdd.OnHoverForeColor = System.Drawing.Color.White
        Me.btnAdd.OnHoverImage = Nothing
        Me.btnAdd.OnPressedColor = System.Drawing.Color.Black
        Me.btnAdd.Size = New System.Drawing.Size(126, 42)
        Me.btnAdd.TabIndex = 7
        Me.btnAdd.Text = "Add New User"
        '
        'txtsearch
        '
        Me.txtsearch.BaseColor = System.Drawing.Color.White
        Me.txtsearch.BorderColor = System.Drawing.Color.Silver
        Me.txtsearch.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtsearch.FocusedBaseColor = System.Drawing.Color.White
        Me.txtsearch.FocusedBorderColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtsearch.FocusedForeColor = System.Drawing.SystemColors.ControlText
        Me.txtsearch.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtsearch.Location = New System.Drawing.Point(641, 58)
        Me.txtsearch.Name = "txtsearch"
        Me.txtsearch.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtsearch.Size = New System.Drawing.Size(160, 30)
        Me.txtsearch.TabIndex = 8
        '
        'GunaLabel6
        '
        Me.GunaLabel6.AutoSize = True
        Me.GunaLabel6.Font = New System.Drawing.Font("Segoe UI Semilight", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel6.Location = New System.Drawing.Point(591, 66)
        Me.GunaLabel6.Name = "GunaLabel6"
        Me.GunaLabel6.Size = New System.Drawing.Size(44, 15)
        Me.GunaLabel6.TabIndex = 9
        Me.GunaLabel6.Text = "Search:"
        '
        'btnsearch
        '
        Me.btnsearch.AnimationHoverSpeed = 0.07!
        Me.btnsearch.AnimationSpeed = 0.03!
        Me.btnsearch.BaseColor = System.Drawing.Color.White
        Me.btnsearch.BorderColor = System.Drawing.Color.Black
        Me.btnsearch.FocusedColor = System.Drawing.Color.Empty
        Me.btnsearch.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btnsearch.ForeColor = System.Drawing.Color.White
        Me.btnsearch.Image = Global.KREM_SYSTEM.My.Resources.Resources.icons8_search_50
        Me.btnsearch.ImageSize = New System.Drawing.Size(20, 20)
        Me.btnsearch.Location = New System.Drawing.Point(807, 58)
        Me.btnsearch.Name = "btnsearch"
        Me.btnsearch.OnHoverBaseColor = System.Drawing.Color.LimeGreen
        Me.btnsearch.OnHoverBorderColor = System.Drawing.Color.Black
        Me.btnsearch.OnHoverForeColor = System.Drawing.Color.White
        Me.btnsearch.OnHoverImage = Nothing
        Me.btnsearch.OnPressedColor = System.Drawing.Color.Black
        Me.btnsearch.Size = New System.Drawing.Size(46, 30)
        Me.btnsearch.TabIndex = 10
        '
        'frmUsers
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(881, 647)
        Me.Controls.Add(Me.btnsearch)
        Me.Controls.Add(Me.GunaLabel6)
        Me.Controls.Add(Me.txtsearch)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.gbUsers)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmUsers"
        Me.Text = "frmUsers"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.gbUsers.ResumeLayout(False)
        Me.gbUserDetails.ResumeLayout(False)
        Me.gbUserDetails.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents btnClose As Guna.UI.WinForms.GunaImageButton
    Friend WithEvents GunaLabel1 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents gbUsers As Guna.UI.WinForms.GunaGroupBox
    Friend WithEvents lvUsers As ListView
    Friend WithEvents No As ColumnHeader
    Friend WithEvents Username As ColumnHeader
    Friend WithEvents ColumnHeader1 As ColumnHeader
    Friend WithEvents ColumnHeader2 As ColumnHeader
    Friend WithEvents gbUserDetails As Guna.UI.WinForms.GunaGroupBox
    Friend WithEvents GunaLabel3 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents txtpassword As Guna.UI.WinForms.GunaLineTextBox
    Friend WithEvents GunaLabel2 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents txtusername As Guna.UI.WinForms.GunaLineTextBox
    Friend WithEvents btnDelete As Guna.UI.WinForms.GunaButton
    Friend WithEvents btnSave As Guna.UI.WinForms.GunaButton
    Friend WithEvents btnCancel As Guna.UI.WinForms.GunaButton
    Friend WithEvents btnAdd As Guna.UI.WinForms.GunaButton
    Friend WithEvents GunaLabel5 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents GunaLabel4 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents cbshowpass As Guna.UI.WinForms.GunaCheckBox
    Friend WithEvents txtsearch As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents GunaLabel6 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents btnsearch As Guna.UI.WinForms.GunaButton
    Friend WithEvents GunaLabel7 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents cbCounter As Guna.UI.WinForms.GunaComboBox
End Class
