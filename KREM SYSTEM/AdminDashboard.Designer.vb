﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AdminDashboard
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AdminDashboard))
        Me.bgpanel = New Guna.UI.WinForms.GunaPanel()
        Me.mainpanel = New System.Windows.Forms.Panel()
        Me.toppanel = New Guna.UI.WinForms.GunaPanel()
        Me.lbldate = New Guna.UI.WinForms.GunaLabel()
        Me.lbltime = New Guna.UI.WinForms.GunaLabel()
        Me.BunifuGradientPanel1 = New Bunifu.Framework.UI.BunifuGradientPanel()
        Me.GunaLinePanel8 = New Guna.UI.WinForms.GunaLinePanel()
        Me.GunaLinePanel9 = New Guna.UI.WinForms.GunaLinePanel()
        Me.btnBackupDB = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.btnModifyUser = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.btnChangePass = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.GunaLinePanel10 = New Guna.UI.WinForms.GunaLinePanel()
        Me.GunaLabel6 = New Guna.UI.WinForms.GunaLabel()
        Me.GunaLinePanel2 = New Guna.UI.WinForms.GunaLinePanel()
        Me.GunaLinePanel5 = New Guna.UI.WinForms.GunaLinePanel()
        Me.btnBlacklist = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.btnSearch = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.btnRemHistory = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.GunaLinePanel7 = New Guna.UI.WinForms.GunaLinePanel()
        Me.GunaLabel5 = New Guna.UI.WinForms.GunaLabel()
        Me.GunaLinePanel3 = New Guna.UI.WinForms.GunaLinePanel()
        Me.GunaLinePanel4 = New Guna.UI.WinForms.GunaLinePanel()
        Me.btncustomerlist = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.btndailyreport = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.btnCustomReport = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.GunaLinePanel6 = New Guna.UI.WinForms.GunaLinePanel()
        Me.GunaLabel4 = New Guna.UI.WinForms.GunaLabel()
        Me.GunaLinePanel1 = New Guna.UI.WinForms.GunaLinePanel()
        Me.btnlogout = New Guna.UI.WinForms.GunaTileButton()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog()
        Me.bgpanel.SuspendLayout()
        Me.toppanel.SuspendLayout()
        Me.BunifuGradientPanel1.SuspendLayout()
        Me.GunaLinePanel8.SuspendLayout()
        Me.GunaLinePanel10.SuspendLayout()
        Me.GunaLinePanel2.SuspendLayout()
        Me.GunaLinePanel7.SuspendLayout()
        Me.GunaLinePanel3.SuspendLayout()
        Me.GunaLinePanel6.SuspendLayout()
        Me.GunaLinePanel1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'bgpanel
        '
        Me.bgpanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.bgpanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.bgpanel.Controls.Add(Me.mainpanel)
        Me.bgpanel.Controls.Add(Me.toppanel)
        Me.bgpanel.Controls.Add(Me.BunifuGradientPanel1)
        Me.bgpanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.bgpanel.Location = New System.Drawing.Point(0, 0)
        Me.bgpanel.Name = "bgpanel"
        Me.bgpanel.Size = New System.Drawing.Size(1100, 680)
        Me.bgpanel.TabIndex = 0
        '
        'mainpanel
        '
        Me.mainpanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.mainpanel.Location = New System.Drawing.Point(217, 31)
        Me.mainpanel.Name = "mainpanel"
        Me.mainpanel.Size = New System.Drawing.Size(881, 647)
        Me.mainpanel.TabIndex = 5
        '
        'toppanel
        '
        Me.toppanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(69, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(135, Byte), Integer))
        Me.toppanel.Controls.Add(Me.lbldate)
        Me.toppanel.Controls.Add(Me.lbltime)
        Me.toppanel.Dock = System.Windows.Forms.DockStyle.Top
        Me.toppanel.Location = New System.Drawing.Point(217, 0)
        Me.toppanel.Name = "toppanel"
        Me.toppanel.Size = New System.Drawing.Size(881, 31)
        Me.toppanel.TabIndex = 4
        '
        'lbldate
        '
        Me.lbldate.AutoSize = True
        Me.lbldate.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbldate.ForeColor = System.Drawing.Color.White
        Me.lbldate.Location = New System.Drawing.Point(20, 5)
        Me.lbldate.Name = "lbldate"
        Me.lbldate.Size = New System.Drawing.Size(50, 21)
        Me.lbldate.TabIndex = 8
        Me.lbldate.Text = "00:00"
        '
        'lbltime
        '
        Me.lbltime.AutoSize = True
        Me.lbltime.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbltime.ForeColor = System.Drawing.Color.Yellow
        Me.lbltime.Location = New System.Drawing.Point(785, 8)
        Me.lbltime.Name = "lbltime"
        Me.lbltime.Size = New System.Drawing.Size(39, 17)
        Me.lbltime.TabIndex = 7
        Me.lbltime.Text = "00:00"
        '
        'BunifuGradientPanel1
        '
        Me.BunifuGradientPanel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(55, Byte), Integer), CType(CType(79, Byte), Integer))
        Me.BunifuGradientPanel1.BackgroundImage = CType(resources.GetObject("BunifuGradientPanel1.BackgroundImage"), System.Drawing.Image)
        Me.BunifuGradientPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BunifuGradientPanel1.Controls.Add(Me.GunaLinePanel8)
        Me.BunifuGradientPanel1.Controls.Add(Me.GunaLinePanel2)
        Me.BunifuGradientPanel1.Controls.Add(Me.GunaLinePanel3)
        Me.BunifuGradientPanel1.Controls.Add(Me.GunaLinePanel1)
        Me.BunifuGradientPanel1.Dock = System.Windows.Forms.DockStyle.Left
        Me.BunifuGradientPanel1.GradientBottomLeft = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(55, Byte), Integer), CType(CType(79, Byte), Integer))
        Me.BunifuGradientPanel1.GradientBottomRight = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(55, Byte), Integer), CType(CType(79, Byte), Integer))
        Me.BunifuGradientPanel1.GradientTopLeft = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(55, Byte), Integer), CType(CType(79, Byte), Integer))
        Me.BunifuGradientPanel1.GradientTopRight = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(55, Byte), Integer), CType(CType(79, Byte), Integer))
        Me.BunifuGradientPanel1.Location = New System.Drawing.Point(0, 0)
        Me.BunifuGradientPanel1.Name = "BunifuGradientPanel1"
        Me.BunifuGradientPanel1.Quality = 10
        Me.BunifuGradientPanel1.Size = New System.Drawing.Size(217, 678)
        Me.BunifuGradientPanel1.TabIndex = 1
        '
        'GunaLinePanel8
        '
        Me.GunaLinePanel8.Controls.Add(Me.GunaLinePanel9)
        Me.GunaLinePanel8.Controls.Add(Me.btnBackupDB)
        Me.GunaLinePanel8.Controls.Add(Me.btnModifyUser)
        Me.GunaLinePanel8.Controls.Add(Me.btnChangePass)
        Me.GunaLinePanel8.Controls.Add(Me.GunaLinePanel10)
        Me.GunaLinePanel8.Dock = System.Windows.Forms.DockStyle.Top
        Me.GunaLinePanel8.LineBottom = 1
        Me.GunaLinePanel8.LineColor = System.Drawing.Color.Silver
        Me.GunaLinePanel8.LineStyle = System.Windows.Forms.BorderStyle.None
        Me.GunaLinePanel8.LineTop = 1
        Me.GunaLinePanel8.Location = New System.Drawing.Point(0, 444)
        Me.GunaLinePanel8.Name = "GunaLinePanel8"
        Me.GunaLinePanel8.Size = New System.Drawing.Size(217, 199)
        Me.GunaLinePanel8.TabIndex = 7
        '
        'GunaLinePanel9
        '
        Me.GunaLinePanel9.Dock = System.Windows.Forms.DockStyle.Top
        Me.GunaLinePanel9.LineBottom = 1
        Me.GunaLinePanel9.LineColor = System.Drawing.Color.Silver
        Me.GunaLinePanel9.LineStyle = System.Windows.Forms.BorderStyle.None
        Me.GunaLinePanel9.Location = New System.Drawing.Point(0, 172)
        Me.GunaLinePanel9.Name = "GunaLinePanel9"
        Me.GunaLinePanel9.Size = New System.Drawing.Size(217, 201)
        Me.GunaLinePanel9.TabIndex = 9
        '
        'btnBackupDB
        '
        Me.btnBackupDB.Activecolor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(55, Byte), Integer), CType(CType(79, Byte), Integer))
        Me.btnBackupDB.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(55, Byte), Integer), CType(CType(79, Byte), Integer))
        Me.btnBackupDB.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnBackupDB.BorderRadius = 0
        Me.btnBackupDB.ButtonText = "      Backup Database"
        Me.btnBackupDB.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnBackupDB.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnBackupDB.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.btnBackupDB.Iconcolor = System.Drawing.Color.Transparent
        Me.btnBackupDB.Iconimage = Global.KREM_SYSTEM.My.Resources.Resources.icons8_briefcase_50
        Me.btnBackupDB.Iconimage_right = Nothing
        Me.btnBackupDB.Iconimage_right_Selected = Nothing
        Me.btnBackupDB.Iconimage_Selected = Nothing
        Me.btnBackupDB.IconZoom = 50.0R
        Me.btnBackupDB.IsTab = False
        Me.btnBackupDB.Location = New System.Drawing.Point(0, 124)
        Me.btnBackupDB.Name = "btnBackupDB"
        Me.btnBackupDB.Normalcolor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(55, Byte), Integer), CType(CType(79, Byte), Integer))
        Me.btnBackupDB.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(70, Byte), Integer), CType(CType(86, Byte), Integer), CType(CType(137, Byte), Integer))
        Me.btnBackupDB.OnHoverTextColor = System.Drawing.Color.White
        Me.btnBackupDB.selected = False
        Me.btnBackupDB.Size = New System.Drawing.Size(217, 48)
        Me.btnBackupDB.TabIndex = 8
        Me.btnBackupDB.Textcolor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.btnBackupDB.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'btnModifyUser
        '
        Me.btnModifyUser.Activecolor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(55, Byte), Integer), CType(CType(79, Byte), Integer))
        Me.btnModifyUser.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(55, Byte), Integer), CType(CType(79, Byte), Integer))
        Me.btnModifyUser.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnModifyUser.BorderRadius = 0
        Me.btnModifyUser.ButtonText = "      Add/Modify User"
        Me.btnModifyUser.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnModifyUser.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnModifyUser.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.btnModifyUser.Iconcolor = System.Drawing.Color.Transparent
        Me.btnModifyUser.Iconimage = Global.KREM_SYSTEM.My.Resources.Resources.icons8_people_50
        Me.btnModifyUser.Iconimage_right = Nothing
        Me.btnModifyUser.Iconimage_right_Selected = Nothing
        Me.btnModifyUser.Iconimage_Selected = Nothing
        Me.btnModifyUser.IconZoom = 50.0R
        Me.btnModifyUser.IsTab = False
        Me.btnModifyUser.Location = New System.Drawing.Point(0, 76)
        Me.btnModifyUser.Name = "btnModifyUser"
        Me.btnModifyUser.Normalcolor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(55, Byte), Integer), CType(CType(79, Byte), Integer))
        Me.btnModifyUser.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(70, Byte), Integer), CType(CType(86, Byte), Integer), CType(CType(137, Byte), Integer))
        Me.btnModifyUser.OnHoverTextColor = System.Drawing.Color.White
        Me.btnModifyUser.selected = False
        Me.btnModifyUser.Size = New System.Drawing.Size(217, 48)
        Me.btnModifyUser.TabIndex = 7
        Me.btnModifyUser.Textcolor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.btnModifyUser.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'btnChangePass
        '
        Me.btnChangePass.Activecolor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(55, Byte), Integer), CType(CType(79, Byte), Integer))
        Me.btnChangePass.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(55, Byte), Integer), CType(CType(79, Byte), Integer))
        Me.btnChangePass.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnChangePass.BorderRadius = 0
        Me.btnChangePass.ButtonText = "      Change Password"
        Me.btnChangePass.CausesValidation = False
        Me.btnChangePass.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnChangePass.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnChangePass.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.btnChangePass.Iconcolor = System.Drawing.Color.Transparent
        Me.btnChangePass.Iconimage = Global.KREM_SYSTEM.My.Resources.Resources.Hide_password_32
        Me.btnChangePass.Iconimage_right = Nothing
        Me.btnChangePass.Iconimage_right_Selected = Nothing
        Me.btnChangePass.Iconimage_Selected = Nothing
        Me.btnChangePass.IconZoom = 50.0R
        Me.btnChangePass.IsTab = False
        Me.btnChangePass.Location = New System.Drawing.Point(0, 28)
        Me.btnChangePass.Name = "btnChangePass"
        Me.btnChangePass.Normalcolor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(55, Byte), Integer), CType(CType(79, Byte), Integer))
        Me.btnChangePass.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(70, Byte), Integer), CType(CType(86, Byte), Integer), CType(CType(137, Byte), Integer))
        Me.btnChangePass.OnHoverTextColor = System.Drawing.Color.White
        Me.btnChangePass.selected = False
        Me.btnChangePass.Size = New System.Drawing.Size(217, 48)
        Me.btnChangePass.TabIndex = 6
        Me.btnChangePass.Textcolor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.btnChangePass.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'GunaLinePanel10
        '
        Me.GunaLinePanel10.BackColor = System.Drawing.Color.FromArgb(CType(CType(73, Byte), Integer), CType(CType(86, Byte), Integer), CType(CType(140, Byte), Integer))
        Me.GunaLinePanel10.Controls.Add(Me.GunaLabel6)
        Me.GunaLinePanel10.Dock = System.Windows.Forms.DockStyle.Top
        Me.GunaLinePanel10.LineBottom = 1
        Me.GunaLinePanel10.LineColor = System.Drawing.Color.Gainsboro
        Me.GunaLinePanel10.LineStyle = System.Windows.Forms.BorderStyle.None
        Me.GunaLinePanel10.Location = New System.Drawing.Point(0, 0)
        Me.GunaLinePanel10.Name = "GunaLinePanel10"
        Me.GunaLinePanel10.Size = New System.Drawing.Size(217, 28)
        Me.GunaLinePanel10.TabIndex = 4
        '
        'GunaLabel6
        '
        Me.GunaLabel6.AutoSize = True
        Me.GunaLabel6.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel6.ForeColor = System.Drawing.Color.White
        Me.GunaLabel6.Location = New System.Drawing.Point(52, 3)
        Me.GunaLabel6.Name = "GunaLabel6"
        Me.GunaLabel6.Size = New System.Drawing.Size(66, 21)
        Me.GunaLabel6.TabIndex = 0
        Me.GunaLabel6.Text = "Settings"
        '
        'GunaLinePanel2
        '
        Me.GunaLinePanel2.Controls.Add(Me.GunaLinePanel5)
        Me.GunaLinePanel2.Controls.Add(Me.btnBlacklist)
        Me.GunaLinePanel2.Controls.Add(Me.btnSearch)
        Me.GunaLinePanel2.Controls.Add(Me.btnRemHistory)
        Me.GunaLinePanel2.Controls.Add(Me.GunaLinePanel7)
        Me.GunaLinePanel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.GunaLinePanel2.LineBottom = 1
        Me.GunaLinePanel2.LineColor = System.Drawing.Color.Silver
        Me.GunaLinePanel2.LineStyle = System.Windows.Forms.BorderStyle.None
        Me.GunaLinePanel2.LineTop = 1
        Me.GunaLinePanel2.Location = New System.Drawing.Point(0, 270)
        Me.GunaLinePanel2.Name = "GunaLinePanel2"
        Me.GunaLinePanel2.Size = New System.Drawing.Size(217, 174)
        Me.GunaLinePanel2.TabIndex = 6
        '
        'GunaLinePanel5
        '
        Me.GunaLinePanel5.Dock = System.Windows.Forms.DockStyle.Top
        Me.GunaLinePanel5.LineBottom = 1
        Me.GunaLinePanel5.LineColor = System.Drawing.Color.Silver
        Me.GunaLinePanel5.LineStyle = System.Windows.Forms.BorderStyle.None
        Me.GunaLinePanel5.Location = New System.Drawing.Point(0, 172)
        Me.GunaLinePanel5.Name = "GunaLinePanel5"
        Me.GunaLinePanel5.Size = New System.Drawing.Size(217, 201)
        Me.GunaLinePanel5.TabIndex = 9
        '
        'btnBlacklist
        '
        Me.btnBlacklist.Activecolor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(55, Byte), Integer), CType(CType(79, Byte), Integer))
        Me.btnBlacklist.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(55, Byte), Integer), CType(CType(79, Byte), Integer))
        Me.btnBlacklist.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnBlacklist.BorderRadius = 0
        Me.btnBlacklist.ButtonText = "      Blacklisted Accounts"
        Me.btnBlacklist.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnBlacklist.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnBlacklist.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.btnBlacklist.Iconcolor = System.Drawing.Color.Transparent
        Me.btnBlacklist.Iconimage = Global.KREM_SYSTEM.My.Resources.Resources.icons8_disapprove_50
        Me.btnBlacklist.Iconimage_right = Nothing
        Me.btnBlacklist.Iconimage_right_Selected = Nothing
        Me.btnBlacklist.Iconimage_Selected = Nothing
        Me.btnBlacklist.IconZoom = 50.0R
        Me.btnBlacklist.IsTab = False
        Me.btnBlacklist.Location = New System.Drawing.Point(0, 124)
        Me.btnBlacklist.Name = "btnBlacklist"
        Me.btnBlacklist.Normalcolor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(55, Byte), Integer), CType(CType(79, Byte), Integer))
        Me.btnBlacklist.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(70, Byte), Integer), CType(CType(86, Byte), Integer), CType(CType(137, Byte), Integer))
        Me.btnBlacklist.OnHoverTextColor = System.Drawing.Color.White
        Me.btnBlacklist.selected = False
        Me.btnBlacklist.Size = New System.Drawing.Size(217, 48)
        Me.btnBlacklist.TabIndex = 8
        Me.btnBlacklist.Textcolor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.btnBlacklist.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'btnSearch
        '
        Me.btnSearch.Activecolor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(55, Byte), Integer), CType(CType(79, Byte), Integer))
        Me.btnSearch.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(55, Byte), Integer), CType(CType(79, Byte), Integer))
        Me.btnSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnSearch.BorderRadius = 0
        Me.btnSearch.ButtonText = "      Search"
        Me.btnSearch.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSearch.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnSearch.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.btnSearch.Iconcolor = System.Drawing.Color.Transparent
        Me.btnSearch.Iconimage = Global.KREM_SYSTEM.My.Resources.Resources.icons8_search_50
        Me.btnSearch.Iconimage_right = Nothing
        Me.btnSearch.Iconimage_right_Selected = Nothing
        Me.btnSearch.Iconimage_Selected = Nothing
        Me.btnSearch.IconZoom = 50.0R
        Me.btnSearch.IsTab = False
        Me.btnSearch.Location = New System.Drawing.Point(0, 76)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Normalcolor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(55, Byte), Integer), CType(CType(79, Byte), Integer))
        Me.btnSearch.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(70, Byte), Integer), CType(CType(86, Byte), Integer), CType(CType(137, Byte), Integer))
        Me.btnSearch.OnHoverTextColor = System.Drawing.Color.White
        Me.btnSearch.selected = False
        Me.btnSearch.Size = New System.Drawing.Size(217, 48)
        Me.btnSearch.TabIndex = 7
        Me.btnSearch.Textcolor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.btnSearch.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'btnRemHistory
        '
        Me.btnRemHistory.Activecolor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(55, Byte), Integer), CType(CType(79, Byte), Integer))
        Me.btnRemHistory.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(55, Byte), Integer), CType(CType(79, Byte), Integer))
        Me.btnRemHistory.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnRemHistory.BorderRadius = 0
        Me.btnRemHistory.ButtonText = "      Remittance History"
        Me.btnRemHistory.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnRemHistory.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnRemHistory.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.btnRemHistory.Iconcolor = System.Drawing.Color.Transparent
        Me.btnRemHistory.Iconimage = Global.KREM_SYSTEM.My.Resources.Resources.icons8_accounting_50
        Me.btnRemHistory.Iconimage_right = Nothing
        Me.btnRemHistory.Iconimage_right_Selected = Nothing
        Me.btnRemHistory.Iconimage_Selected = Nothing
        Me.btnRemHistory.IconZoom = 50.0R
        Me.btnRemHistory.IsTab = False
        Me.btnRemHistory.Location = New System.Drawing.Point(0, 28)
        Me.btnRemHistory.Name = "btnRemHistory"
        Me.btnRemHistory.Normalcolor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(55, Byte), Integer), CType(CType(79, Byte), Integer))
        Me.btnRemHistory.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(70, Byte), Integer), CType(CType(86, Byte), Integer), CType(CType(137, Byte), Integer))
        Me.btnRemHistory.OnHoverTextColor = System.Drawing.Color.White
        Me.btnRemHistory.selected = False
        Me.btnRemHistory.Size = New System.Drawing.Size(217, 48)
        Me.btnRemHistory.TabIndex = 6
        Me.btnRemHistory.Textcolor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.btnRemHistory.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'GunaLinePanel7
        '
        Me.GunaLinePanel7.BackColor = System.Drawing.Color.FromArgb(CType(CType(73, Byte), Integer), CType(CType(86, Byte), Integer), CType(CType(140, Byte), Integer))
        Me.GunaLinePanel7.Controls.Add(Me.GunaLabel5)
        Me.GunaLinePanel7.Dock = System.Windows.Forms.DockStyle.Top
        Me.GunaLinePanel7.LineBottom = 1
        Me.GunaLinePanel7.LineColor = System.Drawing.Color.Gainsboro
        Me.GunaLinePanel7.LineStyle = System.Windows.Forms.BorderStyle.None
        Me.GunaLinePanel7.Location = New System.Drawing.Point(0, 0)
        Me.GunaLinePanel7.Name = "GunaLinePanel7"
        Me.GunaLinePanel7.Size = New System.Drawing.Size(217, 28)
        Me.GunaLinePanel7.TabIndex = 4
        '
        'GunaLabel5
        '
        Me.GunaLabel5.AutoSize = True
        Me.GunaLabel5.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel5.ForeColor = System.Drawing.Color.White
        Me.GunaLabel5.Location = New System.Drawing.Point(52, 3)
        Me.GunaLabel5.Name = "GunaLabel5"
        Me.GunaLabel5.Size = New System.Drawing.Size(89, 21)
        Me.GunaLabel5.TabIndex = 0
        Me.GunaLabel5.Text = "Transaction"
        '
        'GunaLinePanel3
        '
        Me.GunaLinePanel3.Controls.Add(Me.GunaLinePanel4)
        Me.GunaLinePanel3.Controls.Add(Me.btncustomerlist)
        Me.GunaLinePanel3.Controls.Add(Me.btndailyreport)
        Me.GunaLinePanel3.Controls.Add(Me.btnCustomReport)
        Me.GunaLinePanel3.Controls.Add(Me.GunaLinePanel6)
        Me.GunaLinePanel3.Dock = System.Windows.Forms.DockStyle.Top
        Me.GunaLinePanel3.LineBottom = 1
        Me.GunaLinePanel3.LineColor = System.Drawing.Color.Silver
        Me.GunaLinePanel3.LineStyle = System.Windows.Forms.BorderStyle.None
        Me.GunaLinePanel3.LineTop = 1
        Me.GunaLinePanel3.Location = New System.Drawing.Point(0, 96)
        Me.GunaLinePanel3.Name = "GunaLinePanel3"
        Me.GunaLinePanel3.Size = New System.Drawing.Size(217, 174)
        Me.GunaLinePanel3.TabIndex = 5
        '
        'GunaLinePanel4
        '
        Me.GunaLinePanel4.Dock = System.Windows.Forms.DockStyle.Top
        Me.GunaLinePanel4.LineBottom = 1
        Me.GunaLinePanel4.LineColor = System.Drawing.Color.Silver
        Me.GunaLinePanel4.LineStyle = System.Windows.Forms.BorderStyle.None
        Me.GunaLinePanel4.Location = New System.Drawing.Point(0, 172)
        Me.GunaLinePanel4.Name = "GunaLinePanel4"
        Me.GunaLinePanel4.Size = New System.Drawing.Size(217, 201)
        Me.GunaLinePanel4.TabIndex = 9
        '
        'btncustomerlist
        '
        Me.btncustomerlist.Activecolor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(55, Byte), Integer), CType(CType(79, Byte), Integer))
        Me.btncustomerlist.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(55, Byte), Integer), CType(CType(79, Byte), Integer))
        Me.btncustomerlist.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btncustomerlist.BorderRadius = 0
        Me.btncustomerlist.ButtonText = "      Customer List"
        Me.btncustomerlist.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btncustomerlist.Dock = System.Windows.Forms.DockStyle.Top
        Me.btncustomerlist.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.btncustomerlist.Iconcolor = System.Drawing.Color.Transparent
        Me.btncustomerlist.Iconimage = Global.KREM_SYSTEM.My.Resources.Resources.icons8_applicant_50
        Me.btncustomerlist.Iconimage_right = Nothing
        Me.btncustomerlist.Iconimage_right_Selected = Nothing
        Me.btncustomerlist.Iconimage_Selected = Nothing
        Me.btncustomerlist.IconZoom = 50.0R
        Me.btncustomerlist.IsTab = False
        Me.btncustomerlist.Location = New System.Drawing.Point(0, 124)
        Me.btncustomerlist.Name = "btncustomerlist"
        Me.btncustomerlist.Normalcolor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(55, Byte), Integer), CType(CType(79, Byte), Integer))
        Me.btncustomerlist.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(70, Byte), Integer), CType(CType(86, Byte), Integer), CType(CType(137, Byte), Integer))
        Me.btncustomerlist.OnHoverTextColor = System.Drawing.Color.White
        Me.btncustomerlist.selected = False
        Me.btncustomerlist.Size = New System.Drawing.Size(217, 48)
        Me.btncustomerlist.TabIndex = 8
        Me.btncustomerlist.Textcolor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.btncustomerlist.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'btndailyreport
        '
        Me.btndailyreport.Activecolor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(55, Byte), Integer), CType(CType(79, Byte), Integer))
        Me.btndailyreport.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(55, Byte), Integer), CType(CType(79, Byte), Integer))
        Me.btndailyreport.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btndailyreport.BorderRadius = 0
        Me.btndailyreport.ButtonText = "      Daily Report"
        Me.btndailyreport.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btndailyreport.Dock = System.Windows.Forms.DockStyle.Top
        Me.btndailyreport.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.btndailyreport.Iconcolor = System.Drawing.Color.Transparent
        Me.btndailyreport.Iconimage = Global.KREM_SYSTEM.My.Resources.Resources.icons8_ledger_50
        Me.btndailyreport.Iconimage_right = Nothing
        Me.btndailyreport.Iconimage_right_Selected = Nothing
        Me.btndailyreport.Iconimage_Selected = Nothing
        Me.btndailyreport.IconZoom = 50.0R
        Me.btndailyreport.IsTab = False
        Me.btndailyreport.Location = New System.Drawing.Point(0, 76)
        Me.btndailyreport.Name = "btndailyreport"
        Me.btndailyreport.Normalcolor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(55, Byte), Integer), CType(CType(79, Byte), Integer))
        Me.btndailyreport.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(70, Byte), Integer), CType(CType(86, Byte), Integer), CType(CType(137, Byte), Integer))
        Me.btndailyreport.OnHoverTextColor = System.Drawing.Color.White
        Me.btndailyreport.selected = False
        Me.btndailyreport.Size = New System.Drawing.Size(217, 48)
        Me.btndailyreport.TabIndex = 7
        Me.btndailyreport.Textcolor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.btndailyreport.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'btnCustomReport
        '
        Me.btnCustomReport.Activecolor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(55, Byte), Integer), CType(CType(79, Byte), Integer))
        Me.btnCustomReport.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(55, Byte), Integer), CType(CType(79, Byte), Integer))
        Me.btnCustomReport.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnCustomReport.BorderRadius = 0
        Me.btnCustomReport.ButtonText = "      Custom Report"
        Me.btnCustomReport.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCustomReport.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnCustomReport.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.btnCustomReport.Iconcolor = System.Drawing.Color.Transparent
        Me.btnCustomReport.Iconimage = Global.KREM_SYSTEM.My.Resources.Resources.icons8_planner_50
        Me.btnCustomReport.Iconimage_right = Nothing
        Me.btnCustomReport.Iconimage_right_Selected = Nothing
        Me.btnCustomReport.Iconimage_Selected = Nothing
        Me.btnCustomReport.IconZoom = 50.0R
        Me.btnCustomReport.IsTab = False
        Me.btnCustomReport.Location = New System.Drawing.Point(0, 28)
        Me.btnCustomReport.Name = "btnCustomReport"
        Me.btnCustomReport.Normalcolor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(55, Byte), Integer), CType(CType(79, Byte), Integer))
        Me.btnCustomReport.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(70, Byte), Integer), CType(CType(86, Byte), Integer), CType(CType(137, Byte), Integer))
        Me.btnCustomReport.OnHoverTextColor = System.Drawing.Color.White
        Me.btnCustomReport.selected = False
        Me.btnCustomReport.Size = New System.Drawing.Size(217, 48)
        Me.btnCustomReport.TabIndex = 6
        Me.btnCustomReport.Textcolor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.btnCustomReport.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'GunaLinePanel6
        '
        Me.GunaLinePanel6.BackColor = System.Drawing.Color.FromArgb(CType(CType(73, Byte), Integer), CType(CType(86, Byte), Integer), CType(CType(140, Byte), Integer))
        Me.GunaLinePanel6.Controls.Add(Me.GunaLabel4)
        Me.GunaLinePanel6.Dock = System.Windows.Forms.DockStyle.Top
        Me.GunaLinePanel6.LineBottom = 1
        Me.GunaLinePanel6.LineColor = System.Drawing.Color.Gainsboro
        Me.GunaLinePanel6.LineStyle = System.Windows.Forms.BorderStyle.None
        Me.GunaLinePanel6.Location = New System.Drawing.Point(0, 0)
        Me.GunaLinePanel6.Name = "GunaLinePanel6"
        Me.GunaLinePanel6.Size = New System.Drawing.Size(217, 28)
        Me.GunaLinePanel6.TabIndex = 4
        '
        'GunaLabel4
        '
        Me.GunaLabel4.AutoSize = True
        Me.GunaLabel4.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel4.ForeColor = System.Drawing.Color.White
        Me.GunaLabel4.Location = New System.Drawing.Point(64, 3)
        Me.GunaLabel4.Name = "GunaLabel4"
        Me.GunaLabel4.Size = New System.Drawing.Size(64, 21)
        Me.GunaLabel4.TabIndex = 0
        Me.GunaLabel4.Text = "Reports"
        '
        'GunaLinePanel1
        '
        Me.GunaLinePanel1.Controls.Add(Me.btnlogout)
        Me.GunaLinePanel1.Controls.Add(Me.Panel1)
        Me.GunaLinePanel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.GunaLinePanel1.LineBottom = 1
        Me.GunaLinePanel1.LineColor = System.Drawing.Color.Silver
        Me.GunaLinePanel1.LineStyle = System.Windows.Forms.BorderStyle.None
        Me.GunaLinePanel1.Location = New System.Drawing.Point(0, 0)
        Me.GunaLinePanel1.Name = "GunaLinePanel1"
        Me.GunaLinePanel1.Size = New System.Drawing.Size(217, 96)
        Me.GunaLinePanel1.TabIndex = 4
        '
        'btnlogout
        '
        Me.btnlogout.AnimationHoverSpeed = 0.07!
        Me.btnlogout.AnimationSpeed = 0.03!
        Me.btnlogout.BackColor = System.Drawing.Color.FromArgb(CType(CType(56, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(90, Byte), Integer))
        Me.btnlogout.BaseColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(55, Byte), Integer), CType(CType(79, Byte), Integer))
        Me.btnlogout.BorderColor = System.Drawing.Color.Black
        Me.btnlogout.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnlogout.FocusedColor = System.Drawing.Color.Empty
        Me.btnlogout.Font = New System.Drawing.Font("Segoe UI Light", 15.75!)
        Me.btnlogout.ForeColor = System.Drawing.Color.White
        Me.btnlogout.Image = Global.KREM_SYSTEM.My.Resources.Resources.logo
        Me.btnlogout.ImageSize = New System.Drawing.Size(30, 30)
        Me.btnlogout.Location = New System.Drawing.Point(0, 25)
        Me.btnlogout.Name = "btnlogout"
        Me.btnlogout.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(151, Byte), Integer), CType(CType(143, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnlogout.OnHoverBorderColor = System.Drawing.Color.Black
        Me.btnlogout.OnHoverForeColor = System.Drawing.Color.White
        Me.btnlogout.OnHoverImage = Nothing
        Me.btnlogout.OnPressedColor = System.Drawing.Color.Black
        Me.btnlogout.Size = New System.Drawing.Size(217, 71)
        Me.btnlogout.TabIndex = 2
        Me.btnlogout.Text = "Logout"
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(217, 25)
        Me.Panel1.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(65, 5)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(80, 15)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Administrator"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(3, 5)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(63, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Logged as:"
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 1000
        '
        'AdminDashboard
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(55, Byte), Integer), CType(CType(79, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1100, 680)
        Me.Controls.Add(Me.bgpanel)
        Me.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "AdminDashboard"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "AdminDashboard"
        Me.bgpanel.ResumeLayout(False)
        Me.toppanel.ResumeLayout(False)
        Me.toppanel.PerformLayout()
        Me.BunifuGradientPanel1.ResumeLayout(False)
        Me.GunaLinePanel8.ResumeLayout(False)
        Me.GunaLinePanel10.ResumeLayout(False)
        Me.GunaLinePanel10.PerformLayout()
        Me.GunaLinePanel2.ResumeLayout(False)
        Me.GunaLinePanel7.ResumeLayout(False)
        Me.GunaLinePanel7.PerformLayout()
        Me.GunaLinePanel3.ResumeLayout(False)
        Me.GunaLinePanel6.ResumeLayout(False)
        Me.GunaLinePanel6.PerformLayout()
        Me.GunaLinePanel1.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents bgpanel As Guna.UI.WinForms.GunaPanel
    Friend WithEvents BunifuGradientPanel1 As Bunifu.Framework.UI.BunifuGradientPanel
    Friend WithEvents GunaLinePanel3 As Guna.UI.WinForms.GunaLinePanel
    Friend WithEvents GunaLinePanel4 As Guna.UI.WinForms.GunaLinePanel
    Friend WithEvents btncustomerlist As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents btndailyreport As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents btnCustomReport As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents GunaLinePanel6 As Guna.UI.WinForms.GunaLinePanel
    Friend WithEvents GunaLabel4 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents GunaLinePanel1 As Guna.UI.WinForms.GunaLinePanel
    Friend WithEvents GunaLinePanel8 As Guna.UI.WinForms.GunaLinePanel
    Friend WithEvents GunaLinePanel9 As Guna.UI.WinForms.GunaLinePanel
    Friend WithEvents btnBackupDB As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents btnModifyUser As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents btnChangePass As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents GunaLinePanel10 As Guna.UI.WinForms.GunaLinePanel
    Friend WithEvents GunaLabel6 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents GunaLinePanel2 As Guna.UI.WinForms.GunaLinePanel
    Friend WithEvents GunaLinePanel5 As Guna.UI.WinForms.GunaLinePanel
    Friend WithEvents btnBlacklist As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents btnSearch As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents btnRemHistory As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents GunaLinePanel7 As Guna.UI.WinForms.GunaLinePanel
    Friend WithEvents GunaLabel5 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents toppanel As Guna.UI.WinForms.GunaPanel
    Friend WithEvents lbldate As Guna.UI.WinForms.GunaLabel
    Friend WithEvents lbltime As Guna.UI.WinForms.GunaLabel
    Friend WithEvents Timer1 As Timer
    Friend WithEvents mainpanel As Panel
    Friend WithEvents btnlogout As Guna.UI.WinForms.GunaTileButton
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents SaveFileDialog1 As SaveFileDialog
End Class
