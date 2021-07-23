<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmsenderdetails
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
        Me.pbPic = New System.Windows.Forms.PictureBox()
        Me.GunaGroupBox1 = New Guna.UI.WinForms.GunaGroupBox()
        Me.lblpob = New Guna.UI.WinForms.GunaLabel()
        Me.lblincome = New Guna.UI.WinForms.GunaLabel()
        Me.lbloccupation = New Guna.UI.WinForms.GunaLabel()
        Me.lbldob = New Guna.UI.WinForms.GunaLabel()
        Me.lblphone = New Guna.UI.WinForms.GunaLabel()
        Me.lbladdress = New Guna.UI.WinForms.GunaLabel()
        Me.lblnationality = New Guna.UI.WinForms.GunaLabel()
        Me.lblic = New Guna.UI.WinForms.GunaLabel()
        Me.lblsender = New Guna.UI.WinForms.GunaLabel()
        Me.GunaLabel12 = New Guna.UI.WinForms.GunaLabel()
        Me.GunaLabel10 = New Guna.UI.WinForms.GunaLabel()
        Me.GunaLabel9 = New Guna.UI.WinForms.GunaLabel()
        Me.GunaLabel8 = New Guna.UI.WinForms.GunaLabel()
        Me.GunaLabel7 = New Guna.UI.WinForms.GunaLabel()
        Me.GunaLabel6 = New Guna.UI.WinForms.GunaLabel()
        Me.GunaLabel5 = New Guna.UI.WinForms.GunaLabel()
        Me.GunaLabel4 = New Guna.UI.WinForms.GunaLabel()
        Me.GunaLabel2 = New Guna.UI.WinForms.GunaLabel()
        Me.Panel1.SuspendLayout()
        CType(Me.pbPic, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GunaGroupBox1.SuspendLayout()
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
        Me.Panel1.Size = New System.Drawing.Size(1031, 42)
        Me.Panel1.TabIndex = 2
        '
        'btnClose
        '
        Me.btnClose.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.btnClose.Dock = System.Windows.Forms.DockStyle.Right
        Me.btnClose.Image = Global.KREM_SYSTEM.My.Resources.Resources._error
        Me.btnClose.ImageSize = New System.Drawing.Size(32, 32)
        Me.btnClose.Location = New System.Drawing.Point(988, 0)
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
        Me.GunaLabel1.Size = New System.Drawing.Size(88, 15)
        Me.GunaLabel1.TabIndex = 0
        Me.GunaLabel1.Text = "Sender Details"
        '
        'pbPic
        '
        Me.pbPic.BackColor = System.Drawing.Color.White
        Me.pbPic.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.pbPic.Image = Global.KREM_SYSTEM.My.Resources.Resources.noimage
        Me.pbPic.Location = New System.Drawing.Point(12, 67)
        Me.pbPic.Name = "pbPic"
        Me.pbPic.Size = New System.Drawing.Size(571, 402)
        Me.pbPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbPic.TabIndex = 41
        Me.pbPic.TabStop = False
        '
        'GunaGroupBox1
        '
        Me.GunaGroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GunaGroupBox1.BaseColor = System.Drawing.Color.White
        Me.GunaGroupBox1.BorderColor = System.Drawing.Color.Gainsboro
        Me.GunaGroupBox1.Controls.Add(Me.lblpob)
        Me.GunaGroupBox1.Controls.Add(Me.lblincome)
        Me.GunaGroupBox1.Controls.Add(Me.lbloccupation)
        Me.GunaGroupBox1.Controls.Add(Me.lbldob)
        Me.GunaGroupBox1.Controls.Add(Me.lblphone)
        Me.GunaGroupBox1.Controls.Add(Me.lbladdress)
        Me.GunaGroupBox1.Controls.Add(Me.lblnationality)
        Me.GunaGroupBox1.Controls.Add(Me.lblic)
        Me.GunaGroupBox1.Controls.Add(Me.lblsender)
        Me.GunaGroupBox1.Controls.Add(Me.GunaLabel12)
        Me.GunaGroupBox1.Controls.Add(Me.GunaLabel10)
        Me.GunaGroupBox1.Controls.Add(Me.GunaLabel9)
        Me.GunaGroupBox1.Controls.Add(Me.GunaLabel8)
        Me.GunaGroupBox1.Controls.Add(Me.GunaLabel7)
        Me.GunaGroupBox1.Controls.Add(Me.GunaLabel6)
        Me.GunaGroupBox1.Controls.Add(Me.GunaLabel5)
        Me.GunaGroupBox1.Controls.Add(Me.GunaLabel4)
        Me.GunaGroupBox1.Controls.Add(Me.GunaLabel2)
        Me.GunaGroupBox1.LineBottom = 1
        Me.GunaGroupBox1.LineColor = System.Drawing.Color.FromArgb(CType(CType(1, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(203, Byte), Integer))
        Me.GunaGroupBox1.LineLeft = 1
        Me.GunaGroupBox1.LineRight = 1
        Me.GunaGroupBox1.Location = New System.Drawing.Point(590, 67)
        Me.GunaGroupBox1.Name = "GunaGroupBox1"
        Me.GunaGroupBox1.Size = New System.Drawing.Size(429, 402)
        Me.GunaGroupBox1.TabIndex = 42
        Me.GunaGroupBox1.Text = "Personal Information"
        Me.GunaGroupBox1.TextLocation = New System.Drawing.Point(10, 8)
        '
        'lblpob
        '
        Me.lblpob.AutoSize = True
        Me.lblpob.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblpob.ForeColor = System.Drawing.Color.Black
        Me.lblpob.Location = New System.Drawing.Point(123, 345)
        Me.lblpob.Name = "lblpob"
        Me.lblpob.Size = New System.Drawing.Size(34, 15)
        Me.lblpob.TabIndex = 56
        Me.lblpob.Text = "none"
        '
        'lblincome
        '
        Me.lblincome.AutoSize = True
        Me.lblincome.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblincome.ForeColor = System.Drawing.Color.Black
        Me.lblincome.Location = New System.Drawing.Point(123, 308)
        Me.lblincome.Name = "lblincome"
        Me.lblincome.Size = New System.Drawing.Size(34, 15)
        Me.lblincome.TabIndex = 55
        Me.lblincome.Text = "none"
        '
        'lbloccupation
        '
        Me.lbloccupation.AutoSize = True
        Me.lbloccupation.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbloccupation.ForeColor = System.Drawing.Color.Black
        Me.lbloccupation.Location = New System.Drawing.Point(123, 279)
        Me.lbloccupation.Name = "lbloccupation"
        Me.lbloccupation.Size = New System.Drawing.Size(34, 15)
        Me.lbloccupation.TabIndex = 54
        Me.lbloccupation.Text = "none"
        '
        'lbldob
        '
        Me.lbldob.AutoSize = True
        Me.lbldob.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbldob.ForeColor = System.Drawing.Color.Black
        Me.lbldob.Location = New System.Drawing.Point(123, 246)
        Me.lbldob.Name = "lbldob"
        Me.lbldob.Size = New System.Drawing.Size(34, 15)
        Me.lbldob.TabIndex = 53
        Me.lbldob.Text = "none"
        '
        'lblphone
        '
        Me.lblphone.AutoSize = True
        Me.lblphone.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblphone.ForeColor = System.Drawing.Color.Black
        Me.lblphone.Location = New System.Drawing.Point(123, 212)
        Me.lblphone.Name = "lblphone"
        Me.lblphone.Size = New System.Drawing.Size(34, 15)
        Me.lblphone.TabIndex = 52
        Me.lblphone.Text = "none"
        '
        'lbladdress
        '
        Me.lbladdress.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbladdress.ForeColor = System.Drawing.Color.Black
        Me.lbladdress.Location = New System.Drawing.Point(123, 140)
        Me.lbladdress.Name = "lbladdress"
        Me.lbladdress.Size = New System.Drawing.Size(277, 67)
        Me.lbladdress.TabIndex = 51
        Me.lbladdress.Text = "none"
        '
        'lblnationality
        '
        Me.lblnationality.AutoSize = True
        Me.lblnationality.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblnationality.ForeColor = System.Drawing.Color.Black
        Me.lblnationality.Location = New System.Drawing.Point(123, 113)
        Me.lblnationality.Name = "lblnationality"
        Me.lblnationality.Size = New System.Drawing.Size(34, 15)
        Me.lblnationality.TabIndex = 50
        Me.lblnationality.Text = "none"
        '
        'lblic
        '
        Me.lblic.AutoSize = True
        Me.lblic.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblic.ForeColor = System.Drawing.Color.Black
        Me.lblic.Location = New System.Drawing.Point(123, 80)
        Me.lblic.Name = "lblic"
        Me.lblic.Size = New System.Drawing.Size(34, 15)
        Me.lblic.TabIndex = 49
        Me.lblic.Text = "none"
        '
        'lblsender
        '
        Me.lblsender.AutoSize = True
        Me.lblsender.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblsender.ForeColor = System.Drawing.Color.Black
        Me.lblsender.Location = New System.Drawing.Point(123, 45)
        Me.lblsender.Name = "lblsender"
        Me.lblsender.Size = New System.Drawing.Size(34, 15)
        Me.lblsender.TabIndex = 48
        Me.lblsender.Text = "none"
        '
        'GunaLabel12
        '
        Me.GunaLabel12.AutoSize = True
        Me.GunaLabel12.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.GunaLabel12.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.GunaLabel12.Location = New System.Drawing.Point(3, 345)
        Me.GunaLabel12.Name = "GunaLabel12"
        Me.GunaLabel12.Size = New System.Drawing.Size(77, 15)
        Me.GunaLabel12.TabIndex = 47
        Me.GunaLabel12.Text = "Place of Birth"
        '
        'GunaLabel10
        '
        Me.GunaLabel10.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.GunaLabel10.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.GunaLabel10.Location = New System.Drawing.Point(3, 308)
        Me.GunaLabel10.Name = "GunaLabel10"
        Me.GunaLabel10.Size = New System.Drawing.Size(114, 30)
        Me.GunaLabel10.TabIndex = 46
        Me.GunaLabel10.Text = "Source of Income"
        '
        'GunaLabel9
        '
        Me.GunaLabel9.AutoSize = True
        Me.GunaLabel9.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.GunaLabel9.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.GunaLabel9.Location = New System.Drawing.Point(3, 279)
        Me.GunaLabel9.Name = "GunaLabel9"
        Me.GunaLabel9.Size = New System.Drawing.Size(69, 15)
        Me.GunaLabel9.TabIndex = 45
        Me.GunaLabel9.Text = "Occupation"
        '
        'GunaLabel8
        '
        Me.GunaLabel8.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.GunaLabel8.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.GunaLabel8.Location = New System.Drawing.Point(3, 246)
        Me.GunaLabel8.Name = "GunaLabel8"
        Me.GunaLabel8.Size = New System.Drawing.Size(79, 30)
        Me.GunaLabel8.TabIndex = 44
        Me.GunaLabel8.Text = "Date of Birth"
        '
        'GunaLabel7
        '
        Me.GunaLabel7.AutoSize = True
        Me.GunaLabel7.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.GunaLabel7.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.GunaLabel7.Location = New System.Drawing.Point(3, 212)
        Me.GunaLabel7.Name = "GunaLabel7"
        Me.GunaLabel7.Size = New System.Drawing.Size(88, 15)
        Me.GunaLabel7.TabIndex = 43
        Me.GunaLabel7.Text = "Phone Number"
        '
        'GunaLabel6
        '
        Me.GunaLabel6.AutoSize = True
        Me.GunaLabel6.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.GunaLabel6.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.GunaLabel6.Location = New System.Drawing.Point(3, 140)
        Me.GunaLabel6.Name = "GunaLabel6"
        Me.GunaLabel6.Size = New System.Drawing.Size(49, 15)
        Me.GunaLabel6.TabIndex = 42
        Me.GunaLabel6.Text = "Address"
        '
        'GunaLabel5
        '
        Me.GunaLabel5.AutoSize = True
        Me.GunaLabel5.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.GunaLabel5.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.GunaLabel5.Location = New System.Drawing.Point(3, 113)
        Me.GunaLabel5.Name = "GunaLabel5"
        Me.GunaLabel5.Size = New System.Drawing.Size(65, 15)
        Me.GunaLabel5.TabIndex = 41
        Me.GunaLabel5.Text = "Nationality"
        '
        'GunaLabel4
        '
        Me.GunaLabel4.AutoSize = True
        Me.GunaLabel4.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.GunaLabel4.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.GunaLabel4.Location = New System.Drawing.Point(3, 80)
        Me.GunaLabel4.Name = "GunaLabel4"
        Me.GunaLabel4.Size = New System.Drawing.Size(68, 15)
        Me.GunaLabel4.TabIndex = 40
        Me.GunaLabel4.Text = "IC/Passport"
        '
        'GunaLabel2
        '
        Me.GunaLabel2.AutoSize = True
        Me.GunaLabel2.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.GunaLabel2.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.GunaLabel2.Location = New System.Drawing.Point(3, 45)
        Me.GunaLabel2.Name = "GunaLabel2"
        Me.GunaLabel2.Size = New System.Drawing.Size(86, 15)
        Me.GunaLabel2.TabIndex = 39
        Me.GunaLabel2.Text = "Sender's Name"
        '
        'frmsenderdetails
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1031, 502)
        Me.ControlBox = False
        Me.Controls.Add(Me.GunaGroupBox1)
        Me.Controls.Add(Me.pbPic)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Name = "frmsenderdetails"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.pbPic, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GunaGroupBox1.ResumeLayout(False)
        Me.GunaGroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents btnClose As Guna.UI.WinForms.GunaImageButton
    Friend WithEvents GunaLabel1 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents pbPic As PictureBox
    Friend WithEvents GunaGroupBox1 As Guna.UI.WinForms.GunaGroupBox
    Friend WithEvents lblpob As Guna.UI.WinForms.GunaLabel
    Friend WithEvents lblincome As Guna.UI.WinForms.GunaLabel
    Friend WithEvents lbloccupation As Guna.UI.WinForms.GunaLabel
    Friend WithEvents lbldob As Guna.UI.WinForms.GunaLabel
    Friend WithEvents lblphone As Guna.UI.WinForms.GunaLabel
    Friend WithEvents lbladdress As Guna.UI.WinForms.GunaLabel
    Friend WithEvents lblnationality As Guna.UI.WinForms.GunaLabel
    Friend WithEvents lblic As Guna.UI.WinForms.GunaLabel
    Friend WithEvents lblsender As Guna.UI.WinForms.GunaLabel
    Friend WithEvents GunaLabel12 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents GunaLabel10 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents GunaLabel9 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents GunaLabel8 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents GunaLabel7 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents GunaLabel6 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents GunaLabel5 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents GunaLabel4 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents GunaLabel2 As Guna.UI.WinForms.GunaLabel
End Class
