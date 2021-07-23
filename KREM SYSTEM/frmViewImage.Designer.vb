<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmViewImage
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
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.btnRotate = New Guna.UI.WinForms.GunaButton()
        Me.btncancel = New System.Windows.Forms.Button()
        Me.btnok = New System.Windows.Forms.Button()
        Me.pbPic = New System.Windows.Forms.PictureBox()
        Me.btnbrowse = New Guna.UI.WinForms.GunaButton()
        Me.Panel1.SuspendLayout()
        CType(Me.pbPic, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.AutoScroll = True
        Me.Panel1.AutoSize = True
        Me.Panel1.Controls.Add(Me.pbPic)
        Me.Panel1.Location = New System.Drawing.Point(12, 9)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(686, 409)
        Me.Panel1.TabIndex = 24
        '
        'btnRotate
        '
        Me.btnRotate.AnimationHoverSpeed = 0.07!
        Me.btnRotate.AnimationSpeed = 0.03!
        Me.btnRotate.BaseColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnRotate.BorderColor = System.Drawing.Color.Black
        Me.btnRotate.FocusedColor = System.Drawing.Color.Empty
        Me.btnRotate.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btnRotate.ForeColor = System.Drawing.Color.White
        Me.btnRotate.Image = Global.KREM_SYSTEM.My.Resources.Resources.icons8_restart_50
        Me.btnRotate.ImageSize = New System.Drawing.Size(20, 20)
        Me.btnRotate.Location = New System.Drawing.Point(733, 79)
        Me.btnRotate.Name = "btnRotate"
        Me.btnRotate.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnRotate.OnHoverBorderColor = System.Drawing.Color.Black
        Me.btnRotate.OnHoverForeColor = System.Drawing.Color.White
        Me.btnRotate.OnHoverImage = Nothing
        Me.btnRotate.OnPressedColor = System.Drawing.Color.Black
        Me.btnRotate.Size = New System.Drawing.Size(180, 42)
        Me.btnRotate.TabIndex = 29
        Me.btnRotate.Text = "Rotate Image"
        '
        'btncancel
        '
        Me.btncancel.BackColor = System.Drawing.Color.FromArgb(CType(CType(220, Byte), Integer), CType(CType(53, Byte), Integer), CType(CType(69, Byte), Integer))
        Me.btncancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btncancel.FlatAppearance.BorderSize = 0
        Me.btncancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btncancel.Image = Global.KREM_SYSTEM.My.Resources.Resources.Cancel_32
        Me.btncancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btncancel.Location = New System.Drawing.Point(750, 361)
        Me.btncancel.Name = "btncancel"
        Me.btncancel.Size = New System.Drawing.Size(139, 46)
        Me.btncancel.TabIndex = 28
        Me.btncancel.Text = "      Cancel"
        Me.btncancel.UseVisualStyleBackColor = False
        '
        'btnok
        '
        Me.btnok.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnok.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.btnok.FlatAppearance.BorderSize = 0
        Me.btnok.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnok.Image = Global.KREM_SYSTEM.My.Resources.Resources.icons8_checkmark_50
        Me.btnok.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnok.Location = New System.Drawing.Point(750, 309)
        Me.btnok.Name = "btnok"
        Me.btnok.Size = New System.Drawing.Size(139, 46)
        Me.btnok.TabIndex = 27
        Me.btnok.Text = "Update"
        Me.btnok.UseVisualStyleBackColor = False
        '
        'pbPic
        '
        Me.pbPic.BackColor = System.Drawing.Color.White
        Me.pbPic.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pbPic.Location = New System.Drawing.Point(0, 0)
        Me.pbPic.Name = "pbPic"
        Me.pbPic.Size = New System.Drawing.Size(686, 409)
        Me.pbPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbPic.TabIndex = 22
        Me.pbPic.TabStop = False
        '
        'btnbrowse
        '
        Me.btnbrowse.AnimationHoverSpeed = 0.07!
        Me.btnbrowse.AnimationSpeed = 0.03!
        Me.btnbrowse.BaseColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnbrowse.BorderColor = System.Drawing.Color.Black
        Me.btnbrowse.FocusedColor = System.Drawing.Color.Empty
        Me.btnbrowse.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btnbrowse.ForeColor = System.Drawing.Color.White
        Me.btnbrowse.Image = Global.KREM_SYSTEM.My.Resources.Resources.icons8_send_hot_list_50
        Me.btnbrowse.ImageSize = New System.Drawing.Size(20, 20)
        Me.btnbrowse.Location = New System.Drawing.Point(733, 21)
        Me.btnbrowse.Name = "btnbrowse"
        Me.btnbrowse.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(151, Byte), Integer), CType(CType(143, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnbrowse.OnHoverBorderColor = System.Drawing.Color.Black
        Me.btnbrowse.OnHoverForeColor = System.Drawing.Color.White
        Me.btnbrowse.OnHoverImage = Nothing
        Me.btnbrowse.OnPressedColor = System.Drawing.Color.Black
        Me.btnbrowse.Size = New System.Drawing.Size(180, 42)
        Me.btnbrowse.TabIndex = 22
        Me.btnbrowse.Text = "Change/Select Photo"
        '
        'frmViewImage
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(975, 472)
        Me.ControlBox = False
        Me.Controls.Add(Me.btnRotate)
        Me.Controls.Add(Me.btncancel)
        Me.Controls.Add(Me.btnok)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.btnbrowse)
        Me.Name = "frmViewImage"
        Me.Text = "Passport/IC Viewer"
        Me.Panel1.ResumeLayout(False)
        CType(Me.pbPic, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnbrowse As Guna.UI.WinForms.GunaButton
    Friend WithEvents Panel1 As Panel
    Friend WithEvents pbPic As PictureBox
    Friend WithEvents btncancel As Button
    Friend WithEvents btnok As Button
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents btnRotate As Guna.UI.WinForms.GunaButton
End Class
