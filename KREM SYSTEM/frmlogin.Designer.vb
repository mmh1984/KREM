<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmLogin
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.BunifuCustomLabel2 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.BunifuCustomLabel1 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.btnloginasadmin = New Guna.UI.WinForms.GunaGradientButton()
        Me.btnlogincounter = New Guna.UI.WinForms.GunaGradientButton()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnClose = New Guna.UI.WinForms.GunaImageButton()
        Me.GunaLabel1 = New Guna.UI.WinForms.GunaLabel()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'BunifuCustomLabel2
        '
        Me.BunifuCustomLabel2.BackColor = System.Drawing.Color.Transparent
        Me.BunifuCustomLabel2.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuCustomLabel2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.BunifuCustomLabel2.Location = New System.Drawing.Point(117, 240)
        Me.BunifuCustomLabel2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.BunifuCustomLabel2.Name = "BunifuCustomLabel2"
        Me.BunifuCustomLabel2.Size = New System.Drawing.Size(453, 69)
        Me.BunifuCustomLabel2.TabIndex = 6
        Me.BunifuCustomLabel2.Text = "Unit 1.28a, First Floor, Block C" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Yayasan Sultan Haji Hassanal Bolkiah Building C" &
    "omplex" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Bandar Seri Begawan, BS8811, Brunei/Muara" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Brunei Darussalam"
        Me.BunifuCustomLabel2.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'BunifuCustomLabel1
        '
        Me.BunifuCustomLabel1.BackColor = System.Drawing.Color.Transparent
        Me.BunifuCustomLabel1.Font = New System.Drawing.Font("Segoe UI Semibold", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuCustomLabel1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.BunifuCustomLabel1.Location = New System.Drawing.Point(90, 160)
        Me.BunifuCustomLabel1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.BunifuCustomLabel1.Name = "BunifuCustomLabel1"
        Me.BunifuCustomLabel1.Size = New System.Drawing.Size(499, 80)
        Me.BunifuCustomLabel1.TabIndex = 5
        Me.BunifuCustomLabel1.Text = "KEMUDA REMITTANCE " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "SERVICES"
        Me.BunifuCustomLabel1.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox2.Image = Global.KREM_SYSTEM.My.Resources.Resources.logo
        Me.PictureBox2.Location = New System.Drawing.Point(273, 55)
        Me.PictureBox2.Margin = New System.Windows.Forms.Padding(2, 4, 2, 4)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(129, 101)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 4
        Me.PictureBox2.TabStop = False
        '
        'btnloginasadmin
        '
        Me.btnloginasadmin.AnimationHoverSpeed = 0.07!
        Me.btnloginasadmin.AnimationSpeed = 0.03!
        Me.btnloginasadmin.BaseColor1 = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.btnloginasadmin.BaseColor2 = System.Drawing.Color.FromArgb(CType(CType(7, Byte), Integer), CType(CType(91, Byte), Integer), CType(CType(75, Byte), Integer))
        Me.btnloginasadmin.BorderColor = System.Drawing.Color.Black
        Me.btnloginasadmin.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btnloginasadmin.FocusedColor = System.Drawing.Color.Empty
        Me.btnloginasadmin.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btnloginasadmin.ForeColor = System.Drawing.Color.White
        Me.btnloginasadmin.Image = Global.KREM_SYSTEM.My.Resources.Resources.user_4
        Me.btnloginasadmin.ImageSize = New System.Drawing.Size(20, 20)
        Me.btnloginasadmin.Location = New System.Drawing.Point(160, 322)
        Me.btnloginasadmin.Name = "btnloginasadmin"
        Me.btnloginasadmin.OnHoverBaseColor1 = System.Drawing.Color.FromArgb(CType(CType(155, Byte), Integer), CType(CType(145, Byte), Integer), CType(CType(221, Byte), Integer))
        Me.btnloginasadmin.OnHoverBaseColor2 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnloginasadmin.OnHoverBorderColor = System.Drawing.Color.Black
        Me.btnloginasadmin.OnHoverForeColor = System.Drawing.Color.White
        Me.btnloginasadmin.OnHoverImage = Nothing
        Me.btnloginasadmin.OnPressedColor = System.Drawing.Color.Black
        Me.btnloginasadmin.Size = New System.Drawing.Size(173, 42)
        Me.btnloginasadmin.TabIndex = 7
        Me.btnloginasadmin.Text = "Login as Administrator"
        '
        'btnlogincounter
        '
        Me.btnlogincounter.AnimationHoverSpeed = 0.07!
        Me.btnlogincounter.AnimationSpeed = 0.03!
        Me.btnlogincounter.BaseColor1 = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.btnlogincounter.BaseColor2 = System.Drawing.Color.FromArgb(CType(CType(7, Byte), Integer), CType(CType(91, Byte), Integer), CType(CType(75, Byte), Integer))
        Me.btnlogincounter.BorderColor = System.Drawing.Color.Black
        Me.btnlogincounter.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btnlogincounter.FocusedColor = System.Drawing.Color.Empty
        Me.btnlogincounter.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btnlogincounter.ForeColor = System.Drawing.Color.White
        Me.btnlogincounter.Image = Global.KREM_SYSTEM.My.Resources.Resources.user_4
        Me.btnlogincounter.ImageSize = New System.Drawing.Size(20, 20)
        Me.btnlogincounter.Location = New System.Drawing.Point(339, 322)
        Me.btnlogincounter.Name = "btnlogincounter"
        Me.btnlogincounter.OnHoverBaseColor1 = System.Drawing.Color.FromArgb(CType(CType(155, Byte), Integer), CType(CType(145, Byte), Integer), CType(CType(221, Byte), Integer))
        Me.btnlogincounter.OnHoverBaseColor2 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnlogincounter.OnHoverBorderColor = System.Drawing.Color.Black
        Me.btnlogincounter.OnHoverForeColor = System.Drawing.Color.White
        Me.btnlogincounter.OnHoverImage = Nothing
        Me.btnlogincounter.OnPressedColor = System.Drawing.Color.Black
        Me.btnlogincounter.Size = New System.Drawing.Size(173, 42)
        Me.btnlogincounter.TabIndex = 8
        Me.btnlogincounter.Text = "Login as Counter"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(8, Byte), Integer), CType(CType(46, Byte), Integer), CType(CType(39, Byte), Integer))
        Me.Panel1.Controls.Add(Me.btnClose)
        Me.Panel1.Controls.Add(Me.GunaLabel1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.ForeColor = System.Drawing.Color.White
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(664, 32)
        Me.Panel1.TabIndex = 9
        '
        'btnClose
        '
        Me.btnClose.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btnClose.Dock = System.Windows.Forms.DockStyle.Right
        Me.btnClose.Image = Global.KREM_SYSTEM.My.Resources.Resources._error
        Me.btnClose.ImageSize = New System.Drawing.Size(20, 20)
        Me.btnClose.Location = New System.Drawing.Point(621, 0)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.OnHoverImage = Nothing
        Me.btnClose.OnHoverImageOffset = New System.Drawing.Point(0, 0)
        Me.btnClose.Size = New System.Drawing.Size(43, 32)
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
        Me.GunaLabel1.Text = "Kemuda Remittance"
        '
        'frmLogin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.KREM_SYSTEM.My.Resources.Resources.backgroun
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(664, 471)
        Me.ControlBox = False
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.btnlogincounter)
        Me.Controls.Add(Me.btnloginasadmin)
        Me.Controls.Add(Me.BunifuCustomLabel2)
        Me.Controls.Add(Me.BunifuCustomLabel1)
        Me.Controls.Add(Me.PictureBox2)
        Me.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Margin = New System.Windows.Forms.Padding(2, 4, 2, 4)
        Me.Name = "frmLogin"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents BunifuCustomLabel2 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents BunifuCustomLabel1 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents btnloginasadmin As Guna.UI.WinForms.GunaGradientButton
    Friend WithEvents btnlogincounter As Guna.UI.WinForms.GunaGradientButton
    Friend WithEvents Panel1 As Panel
    Friend WithEvents btnClose As Guna.UI.WinForms.GunaImageButton
    Friend WithEvents GunaLabel1 As Guna.UI.WinForms.GunaLabel
End Class
