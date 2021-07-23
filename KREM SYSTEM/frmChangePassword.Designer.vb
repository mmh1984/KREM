<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmChangePassword
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
        Me.btnCancel = New Guna.UI.WinForms.GunaButton()
        Me.btnSave = New Guna.UI.WinForms.GunaButton()
        Me.GunaGroupBox1 = New Guna.UI.WinForms.GunaGroupBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.GunaLabel4 = New Guna.UI.WinForms.GunaLabel()
        Me.cbshowpass = New Guna.UI.WinForms.GunaCheckBox()
        Me.GunaLabel3 = New Guna.UI.WinForms.GunaLabel()
        Me.txtconfirmpass = New Guna.UI.WinForms.GunaLineTextBox()
        Me.GunaLabel2 = New Guna.UI.WinForms.GunaLabel()
        Me.txtnewpass = New Guna.UI.WinForms.GunaLineTextBox()
        Me.Panel1.SuspendLayout()
        Me.GunaGroupBox1.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.GunaLabel1.Size = New System.Drawing.Size(103, 15)
        Me.GunaLabel1.TabIndex = 0
        Me.GunaLabel1.Text = "Change Password"
        '
        'btnCancel
        '
        Me.btnCancel.AnimationHoverSpeed = 0.07!
        Me.btnCancel.AnimationSpeed = 0.03!
        Me.btnCancel.BaseColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.btnCancel.BorderColor = System.Drawing.Color.Black
        Me.btnCancel.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btnCancel.FocusedColor = System.Drawing.Color.Empty
        Me.btnCancel.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btnCancel.ForeColor = System.Drawing.Color.White
        Me.btnCancel.Image = Global.KREM_SYSTEM.My.Resources.Resources.Cancel_32
        Me.btnCancel.ImageSize = New System.Drawing.Size(20, 20)
        Me.btnCancel.Location = New System.Drawing.Point(339, 224)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.OnHoverBaseColor = System.Drawing.Color.Maroon
        Me.btnCancel.OnHoverBorderColor = System.Drawing.Color.Black
        Me.btnCancel.OnHoverForeColor = System.Drawing.Color.White
        Me.btnCancel.OnHoverImage = Nothing
        Me.btnCancel.OnPressedColor = System.Drawing.Color.Black
        Me.btnCancel.Size = New System.Drawing.Size(123, 42)
        Me.btnCancel.TabIndex = 1
        Me.btnCancel.Text = "Cancel"
        '
        'btnSave
        '
        Me.btnSave.AnimationHoverSpeed = 0.07!
        Me.btnSave.AnimationSpeed = 0.03!
        Me.btnSave.BaseColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(163, Byte), Integer), CType(CType(69, Byte), Integer))
        Me.btnSave.BorderColor = System.Drawing.Color.Black
        Me.btnSave.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btnSave.FocusedColor = System.Drawing.Color.Empty
        Me.btnSave.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btnSave.ForeColor = System.Drawing.Color.White
        Me.btnSave.Image = Global.KREM_SYSTEM.My.Resources.Resources.Save_48
        Me.btnSave.ImageSize = New System.Drawing.Size(20, 20)
        Me.btnSave.Location = New System.Drawing.Point(176, 224)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnSave.OnHoverBorderColor = System.Drawing.Color.Black
        Me.btnSave.OnHoverForeColor = System.Drawing.Color.White
        Me.btnSave.OnHoverImage = Nothing
        Me.btnSave.OnPressedColor = System.Drawing.Color.Black
        Me.btnSave.Size = New System.Drawing.Size(126, 42)
        Me.btnSave.TabIndex = 0
        Me.btnSave.Text = "Save Changes"
        '
        'GunaGroupBox1
        '
        Me.GunaGroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GunaGroupBox1.BaseColor = System.Drawing.Color.White
        Me.GunaGroupBox1.BorderColor = System.Drawing.Color.Gainsboro
        Me.GunaGroupBox1.Controls.Add(Me.PictureBox2)
        Me.GunaGroupBox1.Controls.Add(Me.btnCancel)
        Me.GunaGroupBox1.Controls.Add(Me.PictureBox1)
        Me.GunaGroupBox1.Controls.Add(Me.btnSave)
        Me.GunaGroupBox1.Controls.Add(Me.GunaLabel4)
        Me.GunaGroupBox1.Controls.Add(Me.cbshowpass)
        Me.GunaGroupBox1.Controls.Add(Me.GunaLabel3)
        Me.GunaGroupBox1.Controls.Add(Me.txtconfirmpass)
        Me.GunaGroupBox1.Controls.Add(Me.GunaLabel2)
        Me.GunaGroupBox1.Controls.Add(Me.txtnewpass)
        Me.GunaGroupBox1.ForeColor = System.Drawing.Color.White
        Me.GunaGroupBox1.LineColor = System.Drawing.Color.RoyalBlue
        Me.GunaGroupBox1.Location = New System.Drawing.Point(121, 67)
        Me.GunaGroupBox1.Name = "GunaGroupBox1"
        Me.GunaGroupBox1.Size = New System.Drawing.Size(620, 313)
        Me.GunaGroupBox1.TabIndex = 3
        Me.GunaGroupBox1.Text = "Enter New Password"
        Me.GunaGroupBox1.TextLocation = New System.Drawing.Point(10, 8)
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = Global.KREM_SYSTEM.My.Resources.Resources.icons8_key_50
        Me.PictureBox2.Location = New System.Drawing.Point(205, 146)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(13, 15)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 15
        Me.PictureBox2.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.KREM_SYSTEM.My.Resources.Resources.icons8_key_50
        Me.PictureBox1.Location = New System.Drawing.Point(205, 104)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(13, 15)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 14
        Me.PictureBox1.TabStop = False
        '
        'GunaLabel4
        '
        Me.GunaLabel4.AutoSize = True
        Me.GunaLabel4.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel4.ForeColor = System.Drawing.Color.Red
        Me.GunaLabel4.Location = New System.Drawing.Point(173, 62)
        Me.GunaLabel4.Name = "GunaLabel4"
        Me.GunaLabel4.Size = New System.Drawing.Size(332, 15)
        Me.GunaLabel4.TabIndex = 13
        Me.GunaLabel4.Text = "*Password must be at least 6 characters long (Maximum of 16)"
        '
        'cbshowpass
        '
        Me.cbshowpass.BaseColor = System.Drawing.Color.White
        Me.cbshowpass.CheckedOffColor = System.Drawing.Color.Gray
        Me.cbshowpass.CheckedOnColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cbshowpass.FillColor = System.Drawing.Color.White
        Me.cbshowpass.ForeColor = System.Drawing.Color.Black
        Me.cbshowpass.Location = New System.Drawing.Point(392, 177)
        Me.cbshowpass.Name = "cbshowpass"
        Me.cbshowpass.Size = New System.Drawing.Size(111, 20)
        Me.cbshowpass.TabIndex = 12
        Me.cbshowpass.Text = "Show Password"
        '
        'GunaLabel3
        '
        Me.GunaLabel3.AutoSize = True
        Me.GunaLabel3.Font = New System.Drawing.Font("Segoe UI Semilight", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel3.ForeColor = System.Drawing.Color.Black
        Me.GunaLabel3.Location = New System.Drawing.Point(95, 146)
        Me.GunaLabel3.Name = "GunaLabel3"
        Me.GunaLabel3.Size = New System.Drawing.Size(104, 15)
        Me.GunaLabel3.TabIndex = 11
        Me.GunaLabel3.Text = "Confirm Password:"
        '
        'txtconfirmpass
        '
        Me.txtconfirmpass.Animated = True
        Me.txtconfirmpass.BackColor = System.Drawing.Color.White
        Me.txtconfirmpass.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtconfirmpass.FocusedLineColor = System.Drawing.Color.Green
        Me.txtconfirmpass.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtconfirmpass.ForeColor = System.Drawing.Color.DimGray
        Me.txtconfirmpass.LineColor = System.Drawing.Color.DodgerBlue
        Me.txtconfirmpass.Location = New System.Drawing.Point(231, 135)
        Me.txtconfirmpass.MaxLength = 16
        Me.txtconfirmpass.Name = "txtconfirmpass"
        Me.txtconfirmpass.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtconfirmpass.Size = New System.Drawing.Size(262, 26)
        Me.txtconfirmpass.TabIndex = 10
        Me.txtconfirmpass.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'GunaLabel2
        '
        Me.GunaLabel2.AutoSize = True
        Me.GunaLabel2.Font = New System.Drawing.Font("Segoe UI Semilight", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel2.ForeColor = System.Drawing.Color.Black
        Me.GunaLabel2.Location = New System.Drawing.Point(114, 104)
        Me.GunaLabel2.Name = "GunaLabel2"
        Me.GunaLabel2.Size = New System.Drawing.Size(85, 15)
        Me.GunaLabel2.TabIndex = 9
        Me.GunaLabel2.Text = "New Password:"
        '
        'txtnewpass
        '
        Me.txtnewpass.Animated = True
        Me.txtnewpass.BackColor = System.Drawing.Color.White
        Me.txtnewpass.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtnewpass.FocusedLineColor = System.Drawing.Color.Green
        Me.txtnewpass.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtnewpass.ForeColor = System.Drawing.Color.DimGray
        Me.txtnewpass.LineColor = System.Drawing.Color.DodgerBlue
        Me.txtnewpass.Location = New System.Drawing.Point(231, 93)
        Me.txtnewpass.MaxLength = 16
        Me.txtnewpass.Name = "txtnewpass"
        Me.txtnewpass.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtnewpass.Size = New System.Drawing.Size(262, 26)
        Me.txtnewpass.TabIndex = 8
        Me.txtnewpass.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'frmChangePassword
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(881, 429)
        Me.Controls.Add(Me.GunaGroupBox1)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmChangePassword"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmChangePassword"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.GunaGroupBox1.ResumeLayout(False)
        Me.GunaGroupBox1.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents btnClose As Guna.UI.WinForms.GunaImageButton
    Friend WithEvents GunaLabel1 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents btnCancel As Guna.UI.WinForms.GunaButton
    Friend WithEvents btnSave As Guna.UI.WinForms.GunaButton
    Friend WithEvents GunaGroupBox1 As Guna.UI.WinForms.GunaGroupBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents GunaLabel4 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents cbshowpass As Guna.UI.WinForms.GunaCheckBox
    Friend WithEvents GunaLabel3 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents txtconfirmpass As Guna.UI.WinForms.GunaLineTextBox
    Friend WithEvents GunaLabel2 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents txtnewpass As Guna.UI.WinForms.GunaLineTextBox
End Class
