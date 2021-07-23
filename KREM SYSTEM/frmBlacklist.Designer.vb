<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmBlacklist
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
        Me.txtsearch = New Guna.UI.WinForms.GunaLineTextBox()
        Me.GunaGroupBox1 = New Guna.UI.WinForms.GunaGroupBox()
        Me.GunaLabel2 = New Guna.UI.WinForms.GunaLabel()
        Me.GunaLabel3 = New Guna.UI.WinForms.GunaLabel()
        Me.lvaccounts = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader4 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.gbRemhistory = New Guna.UI.WinForms.GunaGroupBox()
        Me.txtreason = New System.Windows.Forms.RichTextBox()
        Me.lblaccselected = New Guna.UI.WinForms.GunaLabel()
        Me.GunaLabel6 = New Guna.UI.WinForms.GunaLabel()
        Me.btnblacklist = New Guna.UI.WinForms.GunaAdvenceButton()
        Me.GunaGroupBox2 = New Guna.UI.WinForms.GunaGroupBox()
        Me.GunaLabel4 = New Guna.UI.WinForms.GunaLabel()
        Me.GunaLabel5 = New Guna.UI.WinForms.GunaLabel()
        Me.txtsearch1 = New Guna.UI.WinForms.GunaLineTextBox()
        Me.lvblacklist = New System.Windows.Forms.ListView()
        Me.ColumnHeader7 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader8 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader9 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Panel1.SuspendLayout()
        Me.GunaGroupBox1.SuspendLayout()
        Me.gbRemhistory.SuspendLayout()
        Me.GunaGroupBox2.SuspendLayout()
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
        Me.GunaLabel1.Size = New System.Drawing.Size(121, 15)
        Me.GunaLabel1.TabIndex = 0
        Me.GunaLabel1.Text = "Blacklisted Accounts"
        '
        'txtsearch
        '
        Me.txtsearch.Animated = True
        Me.txtsearch.BackColor = System.Drawing.Color.White
        Me.txtsearch.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtsearch.FocusedLineColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtsearch.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtsearch.ForeColor = System.Drawing.Color.Black
        Me.txtsearch.LineColor = System.Drawing.Color.Green
        Me.txtsearch.Location = New System.Drawing.Point(6, 67)
        Me.txtsearch.MaxLength = 32
        Me.txtsearch.Name = "txtsearch"
        Me.txtsearch.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtsearch.Size = New System.Drawing.Size(183, 26)
        Me.txtsearch.TabIndex = 11
        '
        'GunaGroupBox1
        '
        Me.GunaGroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GunaGroupBox1.BaseColor = System.Drawing.Color.White
        Me.GunaGroupBox1.BorderColor = System.Drawing.Color.Gainsboro
        Me.GunaGroupBox1.Controls.Add(Me.GunaLabel2)
        Me.GunaGroupBox1.Controls.Add(Me.GunaLabel3)
        Me.GunaGroupBox1.Controls.Add(Me.lvaccounts)
        Me.GunaGroupBox1.Controls.Add(Me.txtsearch)
        Me.GunaGroupBox1.ForeColor = System.Drawing.Color.White
        Me.GunaGroupBox1.LineBottom = 1
        Me.GunaGroupBox1.LineColor = System.Drawing.Color.Green
        Me.GunaGroupBox1.LineLeft = 1
        Me.GunaGroupBox1.LineRight = 1
        Me.GunaGroupBox1.Location = New System.Drawing.Point(2, 41)
        Me.GunaGroupBox1.Name = "GunaGroupBox1"
        Me.GunaGroupBox1.Size = New System.Drawing.Size(407, 606)
        Me.GunaGroupBox1.TabIndex = 14
        Me.GunaGroupBox1.Text = "All Accounts"
        Me.GunaGroupBox1.TextLocation = New System.Drawing.Point(10, 8)
        '
        'GunaLabel2
        '
        Me.GunaLabel2.Font = New System.Drawing.Font("Segoe UI Semibold", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel2.ForeColor = System.Drawing.Color.Red
        Me.GunaLabel2.Location = New System.Drawing.Point(208, 49)
        Me.GunaLabel2.Name = "GunaLabel2"
        Me.GunaLabel2.Size = New System.Drawing.Size(173, 32)
        Me.GunaLabel2.TabIndex = 19
        Me.GunaLabel2.Text = "*Select account from the list to view remittance history" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'GunaLabel3
        '
        Me.GunaLabel3.AutoSize = True
        Me.GunaLabel3.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel3.ForeColor = System.Drawing.Color.DimGray
        Me.GunaLabel3.Location = New System.Drawing.Point(3, 48)
        Me.GunaLabel3.Name = "GunaLabel3"
        Me.GunaLabel3.Size = New System.Drawing.Size(120, 15)
        Me.GunaLabel3.TabIndex = 17
        Me.GunaLabel3.Text = "Type acc no or name"
        '
        'lvaccounts
        '
        Me.lvaccounts.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lvaccounts.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3, Me.ColumnHeader4})
        Me.lvaccounts.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.lvaccounts.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lvaccounts.FullRowSelect = True
        Me.lvaccounts.GridLines = True
        Me.lvaccounts.Location = New System.Drawing.Point(0, 132)
        Me.lvaccounts.Name = "lvaccounts"
        Me.lvaccounts.Size = New System.Drawing.Size(407, 474)
        Me.lvaccounts.TabIndex = 16
        Me.lvaccounts.UseCompatibleStateImageBehavior = False
        Me.lvaccounts.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "Acc No"
        Me.ColumnHeader1.Width = 80
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Receiver"
        Me.ColumnHeader2.Width = 150
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "Bank"
        Me.ColumnHeader3.Width = 80
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "Branch"
        Me.ColumnHeader4.Width = 80
        '
        'gbRemhistory
        '
        Me.gbRemhistory.BackColor = System.Drawing.Color.Transparent
        Me.gbRemhistory.BaseColor = System.Drawing.Color.White
        Me.gbRemhistory.BorderColor = System.Drawing.Color.Gainsboro
        Me.gbRemhistory.Controls.Add(Me.txtreason)
        Me.gbRemhistory.Controls.Add(Me.lblaccselected)
        Me.gbRemhistory.Controls.Add(Me.GunaLabel6)
        Me.gbRemhistory.Controls.Add(Me.btnblacklist)
        Me.gbRemhistory.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbRemhistory.LineBottom = 1
        Me.gbRemhistory.LineColor = System.Drawing.Color.Gainsboro
        Me.gbRemhistory.LineLeft = 1
        Me.gbRemhistory.LineRight = 1
        Me.gbRemhistory.Location = New System.Drawing.Point(413, 42)
        Me.gbRemhistory.Name = "gbRemhistory"
        Me.gbRemhistory.Size = New System.Drawing.Size(465, 209)
        Me.gbRemhistory.TabIndex = 16
        Me.gbRemhistory.Text = "Add to Blacklist"
        Me.gbRemhistory.TextLocation = New System.Drawing.Point(10, 8)
        '
        'txtreason
        '
        Me.txtreason.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtreason.Location = New System.Drawing.Point(13, 66)
        Me.txtreason.MaxLength = 128
        Me.txtreason.Name = "txtreason"
        Me.txtreason.Size = New System.Drawing.Size(443, 74)
        Me.txtreason.TabIndex = 24
        Me.txtreason.Text = ""
        '
        'lblaccselected
        '
        Me.lblaccselected.AutoSize = True
        Me.lblaccselected.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblaccselected.ForeColor = System.Drawing.Color.Blue
        Me.lblaccselected.Location = New System.Drawing.Point(119, 47)
        Me.lblaccselected.Name = "lblaccselected"
        Me.lblaccselected.Size = New System.Drawing.Size(23, 15)
        Me.lblaccselected.TabIndex = 23
        Me.lblaccselected.Text = "n.a"
        '
        'GunaLabel6
        '
        Me.GunaLabel6.AutoSize = True
        Me.GunaLabel6.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel6.ForeColor = System.Drawing.Color.DimGray
        Me.GunaLabel6.Location = New System.Drawing.Point(10, 47)
        Me.GunaLabel6.Name = "GunaLabel6"
        Me.GunaLabel6.Size = New System.Drawing.Size(105, 15)
        Me.GunaLabel6.TabIndex = 20
        Me.GunaLabel6.Text = "Account Number:"
        '
        'btnblacklist
        '
        Me.btnblacklist.AnimationHoverSpeed = 0.07!
        Me.btnblacklist.AnimationSpeed = 0.03!
        Me.btnblacklist.BaseColor = System.Drawing.Color.FromArgb(CType(CType(220, Byte), Integer), CType(CType(53, Byte), Integer), CType(CType(69, Byte), Integer))
        Me.btnblacklist.BorderColor = System.Drawing.Color.Black
        Me.btnblacklist.CheckedBaseColor = System.Drawing.Color.Gray
        Me.btnblacklist.CheckedBorderColor = System.Drawing.Color.Black
        Me.btnblacklist.CheckedForeColor = System.Drawing.Color.White
        Me.btnblacklist.CheckedImage = Global.KREM_SYSTEM.My.Resources.Resources.icons8_edit_50
        Me.btnblacklist.CheckedLineColor = System.Drawing.Color.DimGray
        Me.btnblacklist.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btnblacklist.FocusedColor = System.Drawing.Color.Empty
        Me.btnblacklist.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btnblacklist.ForeColor = System.Drawing.Color.White
        Me.btnblacklist.Image = Global.KREM_SYSTEM.My.Resources.Resources.icons8_disapprove_501
        Me.btnblacklist.ImageSize = New System.Drawing.Size(20, 20)
        Me.btnblacklist.LineColor = System.Drawing.Color.Empty
        Me.btnblacklist.Location = New System.Drawing.Point(311, 146)
        Me.btnblacklist.Name = "btnblacklist"
        Me.btnblacklist.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(153, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.btnblacklist.OnHoverBorderColor = System.Drawing.Color.Black
        Me.btnblacklist.OnHoverForeColor = System.Drawing.Color.White
        Me.btnblacklist.OnHoverImage = Nothing
        Me.btnblacklist.OnHoverLineColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.btnblacklist.OnPressedColor = System.Drawing.Color.Black
        Me.btnblacklist.Size = New System.Drawing.Size(145, 47)
        Me.btnblacklist.TabIndex = 22
        Me.btnblacklist.Text = "Add to Blacklist"
        '
        'GunaGroupBox2
        '
        Me.GunaGroupBox2.BackColor = System.Drawing.Color.Transparent
        Me.GunaGroupBox2.BaseColor = System.Drawing.Color.White
        Me.GunaGroupBox2.BorderColor = System.Drawing.Color.Gainsboro
        Me.GunaGroupBox2.Controls.Add(Me.GunaLabel4)
        Me.GunaGroupBox2.Controls.Add(Me.GunaLabel5)
        Me.GunaGroupBox2.Controls.Add(Me.txtsearch1)
        Me.GunaGroupBox2.Controls.Add(Me.lvblacklist)
        Me.GunaGroupBox2.ForeColor = System.Drawing.Color.White
        Me.GunaGroupBox2.LineBottom = 1
        Me.GunaGroupBox2.LineColor = System.Drawing.Color.Red
        Me.GunaGroupBox2.LineLeft = 1
        Me.GunaGroupBox2.LineRight = 1
        Me.GunaGroupBox2.Location = New System.Drawing.Point(413, 257)
        Me.GunaGroupBox2.Name = "GunaGroupBox2"
        Me.GunaGroupBox2.Size = New System.Drawing.Size(462, 378)
        Me.GunaGroupBox2.TabIndex = 17
        Me.GunaGroupBox2.Text = "Blacklisted Accounts"
        Me.GunaGroupBox2.TextLocation = New System.Drawing.Point(10, 8)
        '
        'GunaLabel4
        '
        Me.GunaLabel4.Font = New System.Drawing.Font("Segoe UI Semibold", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel4.ForeColor = System.Drawing.Color.Red
        Me.GunaLabel4.Location = New System.Drawing.Point(212, 42)
        Me.GunaLabel4.Name = "GunaLabel4"
        Me.GunaLabel4.Size = New System.Drawing.Size(228, 51)
        Me.GunaLabel4.TabIndex = 22
        Me.GunaLabel4.Text = "*Select any accounts and double click to remove it from the list"
        '
        'GunaLabel5
        '
        Me.GunaLabel5.AutoSize = True
        Me.GunaLabel5.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel5.ForeColor = System.Drawing.Color.DimGray
        Me.GunaLabel5.Location = New System.Drawing.Point(7, 48)
        Me.GunaLabel5.Name = "GunaLabel5"
        Me.GunaLabel5.Size = New System.Drawing.Size(151, 15)
        Me.GunaLabel5.TabIndex = 21
        Me.GunaLabel5.Text = "Type Acc Number to filter"
        '
        'txtsearch1
        '
        Me.txtsearch1.Animated = True
        Me.txtsearch1.BackColor = System.Drawing.Color.White
        Me.txtsearch1.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtsearch1.FocusedLineColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtsearch1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtsearch1.ForeColor = System.Drawing.Color.Black
        Me.txtsearch1.LineColor = System.Drawing.Color.Maroon
        Me.txtsearch1.Location = New System.Drawing.Point(10, 67)
        Me.txtsearch1.MaxLength = 32
        Me.txtsearch1.Name = "txtsearch1"
        Me.txtsearch1.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtsearch1.Size = New System.Drawing.Size(183, 26)
        Me.txtsearch1.TabIndex = 20
        '
        'lvblacklist
        '
        Me.lvblacklist.BackColor = System.Drawing.Color.White
        Me.lvblacklist.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lvblacklist.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader7, Me.ColumnHeader8, Me.ColumnHeader9})
        Me.lvblacklist.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.lvblacklist.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lvblacklist.FullRowSelect = True
        Me.lvblacklist.GridLines = True
        Me.lvblacklist.Location = New System.Drawing.Point(0, 107)
        Me.lvblacklist.Name = "lvblacklist"
        Me.lvblacklist.Size = New System.Drawing.Size(462, 271)
        Me.lvblacklist.TabIndex = 16
        Me.lvblacklist.UseCompatibleStateImageBehavior = False
        Me.lvblacklist.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader7
        '
        Me.ColumnHeader7.Text = "Acc No"
        Me.ColumnHeader7.Width = 100
        '
        'ColumnHeader8
        '
        Me.ColumnHeader8.Text = "Reason"
        Me.ColumnHeader8.Width = 200
        '
        'ColumnHeader9
        '
        Me.ColumnHeader9.Text = "Date Modified"
        Me.ColumnHeader9.Width = 100
        '
        'frmBlacklist
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(881, 647)
        Me.Controls.Add(Me.GunaGroupBox2)
        Me.Controls.Add(Me.gbRemhistory)
        Me.Controls.Add(Me.GunaGroupBox1)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmBlacklist"
        Me.Text = "frmBlacklist"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.GunaGroupBox1.ResumeLayout(False)
        Me.GunaGroupBox1.PerformLayout()
        Me.gbRemhistory.ResumeLayout(False)
        Me.gbRemhistory.PerformLayout()
        Me.GunaGroupBox2.ResumeLayout(False)
        Me.GunaGroupBox2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents btnClose As Guna.UI.WinForms.GunaImageButton
    Friend WithEvents GunaLabel1 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents txtsearch As Guna.UI.WinForms.GunaLineTextBox
    Friend WithEvents GunaGroupBox1 As Guna.UI.WinForms.GunaGroupBox
    Friend WithEvents lvaccounts As ListView
    Friend WithEvents ColumnHeader1 As ColumnHeader
    Friend WithEvents ColumnHeader2 As ColumnHeader
    Friend WithEvents ColumnHeader3 As ColumnHeader
    Friend WithEvents ColumnHeader4 As ColumnHeader
    Friend WithEvents GunaLabel3 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents GunaLabel2 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents gbRemhistory As Guna.UI.WinForms.GunaGroupBox
    Friend WithEvents btnblacklist As Guna.UI.WinForms.GunaAdvenceButton
    Friend WithEvents txtreason As RichTextBox
    Friend WithEvents lblaccselected As Guna.UI.WinForms.GunaLabel
    Friend WithEvents GunaLabel6 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents GunaGroupBox2 As Guna.UI.WinForms.GunaGroupBox
    Friend WithEvents GunaLabel4 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents GunaLabel5 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents txtsearch1 As Guna.UI.WinForms.GunaLineTextBox
    Friend WithEvents lvblacklist As ListView
    Friend WithEvents ColumnHeader7 As ColumnHeader
    Friend WithEvents ColumnHeader8 As ColumnHeader
    Friend WithEvents ColumnHeader9 As ColumnHeader
End Class
