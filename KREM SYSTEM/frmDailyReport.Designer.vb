<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDailyReport
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
        Dim ReportDataSource1 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Dim ReportDataSource2 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnClose = New Guna.UI.WinForms.GunaImageButton()
        Me.GunaLabel1 = New Guna.UI.WinForms.GunaLabel()
        Me.dtStart = New Guna.UI.WinForms.GunaDateTimePicker()
        Me.GunaLabel2 = New Guna.UI.WinForms.GunaLabel()
        Me.btnSearch = New Guna.UI.WinForms.GunaButton()
        Me.tabContents = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.dtDailyReportBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.dataset = New KREM_SYSTEM.dataset()
        Me.dtDailyReportTableAdapter = New KREM_SYSTEM.datasetTableAdapters.dtDailyReportTableAdapter()
        Me.ReportViewer2 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.dtSenderDetailsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.dtSenderDetailsTableAdapter = New KREM_SYSTEM.datasetTableAdapters.dtSenderDetailsTableAdapter()
        Me.Panel1.SuspendLayout()
        Me.tabContents.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        CType(Me.dtDailyReportBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dataset, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtSenderDetailsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.Panel1.TabIndex = 8
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
        Me.GunaLabel1.Size = New System.Drawing.Size(132, 15)
        Me.GunaLabel1.TabIndex = 0
        Me.GunaLabel1.Text = "Generate Daily Report"
        '
        'dtStart
        '
        Me.dtStart.BaseColor = System.Drawing.Color.White
        Me.dtStart.BorderColor = System.Drawing.Color.Silver
        Me.dtStart.CustomFormat = "dd/MM/yyyy"
        Me.dtStart.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right
        Me.dtStart.FocusedColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dtStart.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.dtStart.ForeColor = System.Drawing.Color.Black
        Me.dtStart.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtStart.Location = New System.Drawing.Point(86, 51)
        Me.dtStart.MaxDate = New Date(9998, 12, 31, 0, 0, 0, 0)
        Me.dtStart.MinDate = New Date(1753, 1, 1, 0, 0, 0, 0)
        Me.dtStart.Name = "dtStart"
        Me.dtStart.OnHoverBaseColor = System.Drawing.Color.White
        Me.dtStart.OnHoverBorderColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dtStart.OnHoverForeColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dtStart.OnPressedColor = System.Drawing.Color.Black
        Me.dtStart.Size = New System.Drawing.Size(223, 30)
        Me.dtStart.TabIndex = 10
        Me.dtStart.Text = "18/11/2019"
        Me.dtStart.Value = New Date(2019, 11, 18, 16, 22, 41, 991)
        '
        'GunaLabel2
        '
        Me.GunaLabel2.AutoSize = True
        Me.GunaLabel2.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel2.Location = New System.Drawing.Point(12, 59)
        Me.GunaLabel2.Name = "GunaLabel2"
        Me.GunaLabel2.Size = New System.Drawing.Size(67, 13)
        Me.GunaLabel2.TabIndex = 9
        Me.GunaLabel2.Text = "Select Date:"
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
        Me.btnSearch.Location = New System.Drawing.Point(330, 51)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnSearch.OnHoverBorderColor = System.Drawing.Color.Black
        Me.btnSearch.OnHoverForeColor = System.Drawing.Color.White
        Me.btnSearch.OnHoverImage = Nothing
        Me.btnSearch.OnPressedColor = System.Drawing.Color.Black
        Me.btnSearch.Size = New System.Drawing.Size(160, 30)
        Me.btnSearch.TabIndex = 13
        Me.btnSearch.Text = "Search"
        '
        'tabContents
        '
        Me.tabContents.Controls.Add(Me.TabPage1)
        Me.tabContents.Controls.Add(Me.TabPage2)
        Me.tabContents.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.tabContents.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tabContents.Location = New System.Drawing.Point(0, 87)
        Me.tabContents.Name = "tabContents"
        Me.tabContents.SelectedIndex = 0
        Me.tabContents.Size = New System.Drawing.Size(881, 560)
        Me.tabContents.TabIndex = 14
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.ReportViewer1)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(873, 534)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Transaction/Remittances"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'ReportViewer1
        '
        Me.ReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill
        ReportDataSource1.Name = "DailyReport"
        ReportDataSource1.Value = Me.dtDailyReportBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "KREM_SYSTEM.DailyReport.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(3, 3)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.PageCountMode = Microsoft.Reporting.WinForms.PageCountMode.Actual
        Me.ReportViewer1.Size = New System.Drawing.Size(867, 528)
        Me.ReportViewer1.TabIndex = 15
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.ReportViewer2)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(873, 534)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Customer List"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'dtDailyReportBindingSource
        '
        Me.dtDailyReportBindingSource.DataMember = "dtDailyReport"
        Me.dtDailyReportBindingSource.DataSource = Me.dataset
        '
        'dataset
        '
        Me.dataset.DataSetName = "dataset"
        Me.dataset.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'dtDailyReportTableAdapter
        '
        Me.dtDailyReportTableAdapter.ClearBeforeFill = True
        '
        'ReportViewer2
        '
        Me.ReportViewer2.Dock = System.Windows.Forms.DockStyle.Fill
        ReportDataSource2.Name = "CustomerDaily"
        ReportDataSource2.Value = Me.dtSenderDetailsBindingSource
        Me.ReportViewer2.LocalReport.DataSources.Add(ReportDataSource2)
        Me.ReportViewer2.LocalReport.ReportEmbeddedResource = "KREM_SYSTEM.CustomerDailyReport.rdlc"
        Me.ReportViewer2.Location = New System.Drawing.Point(3, 3)
        Me.ReportViewer2.Name = "ReportViewer2"
        Me.ReportViewer2.Size = New System.Drawing.Size(867, 528)
        Me.ReportViewer2.TabIndex = 0
        '
        'dtSenderDetailsBindingSource
        '
        Me.dtSenderDetailsBindingSource.DataMember = "dtSenderDetails"
        Me.dtSenderDetailsBindingSource.DataSource = Me.dataset
        '
        'dtSenderDetailsTableAdapter
        '
        Me.dtSenderDetailsTableAdapter.ClearBeforeFill = True
        '
        'frmDailyReport
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(881, 647)
        Me.Controls.Add(Me.tabContents)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.btnSearch)
        Me.Controls.Add(Me.dtStart)
        Me.Controls.Add(Me.GunaLabel2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmDailyReport"
        Me.Text = "frmDailyReport"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.tabContents.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage2.ResumeLayout(False)
        CType(Me.dtDailyReportBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dataset, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtSenderDetailsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Panel1 As Panel
    Friend WithEvents btnClose As Guna.UI.WinForms.GunaImageButton
    Friend WithEvents GunaLabel1 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents btnSearch As Guna.UI.WinForms.GunaButton
    Friend WithEvents dtStart As Guna.UI.WinForms.GunaDateTimePicker
    Friend WithEvents GunaLabel2 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents dtDailyReportBindingSource As BindingSource
    Friend WithEvents dataset As dataset
    Friend WithEvents dtDailyReportTableAdapter As datasetTableAdapters.dtDailyReportTableAdapter
    Friend WithEvents tabContents As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents ReportViewer2 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents dtSenderDetailsBindingSource As BindingSource
    Friend WithEvents dtSenderDetailsTableAdapter As datasetTableAdapters.dtSenderDetailsTableAdapter
End Class
