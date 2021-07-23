<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmRemittanceReport
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
        Dim ReportDataSource3 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Dim ReportDataSource4 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Me.dtRemittanceHistoryBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.dataset = New KREM_SYSTEM.dataset()
        Me.dtRemittanceHistoryRangeBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.GunaLabel1 = New Guna.UI.WinForms.GunaLabel()
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.dtRemittanceHistoryTableAdapter = New KREM_SYSTEM.datasetTableAdapters.dtRemittanceHistoryTableAdapter()
        Me.ReportViewer2 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.dtRemittanceHistoryRangeTableAdapter = New KREM_SYSTEM.datasetTableAdapters.dtRemittanceHistoryRangeTableAdapter()
        CType(Me.dtRemittanceHistoryBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dataset, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtRemittanceHistoryRangeBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'dtRemittanceHistoryBindingSource
        '
        Me.dtRemittanceHistoryBindingSource.DataMember = "dtRemittanceHistory"
        Me.dtRemittanceHistoryBindingSource.DataSource = Me.dataset
        '
        'dataset
        '
        Me.dataset.DataSetName = "dataset"
        Me.dataset.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'dtRemittanceHistoryRangeBindingSource
        '
        Me.dtRemittanceHistoryRangeBindingSource.DataMember = "dtRemittanceHistoryRange"
        Me.dtRemittanceHistoryRangeBindingSource.DataSource = Me.dataset
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(63, Byte), Integer))
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.Button1)
        Me.Panel1.Controls.Add(Me.GunaLabel1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.ForeColor = System.Drawing.Color.White
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(881, 36)
        Me.Panel1.TabIndex = 3
        '
        'Button1
        '
        Me.Button1.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Button1.Dock = System.Windows.Forms.DockStyle.Right
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Image = Global.KREM_SYSTEM.My.Resources.Resources._error
        Me.Button1.Location = New System.Drawing.Point(840, 0)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(39, 34)
        Me.Button1.TabIndex = 1
        Me.Button1.UseVisualStyleBackColor = True
        '
        'GunaLabel1
        '
        Me.GunaLabel1.AutoSize = True
        Me.GunaLabel1.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel1.Location = New System.Drawing.Point(12, 12)
        Me.GunaLabel1.Name = "GunaLabel1"
        Me.GunaLabel1.Size = New System.Drawing.Size(115, 15)
        Me.GunaLabel1.TabIndex = 0
        Me.GunaLabel1.Text = "Remittance History"
        '
        'ReportViewer1
        '
        Me.ReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill
        ReportDataSource3.Name = "RemHistory"
        ReportDataSource3.Value = Me.dtRemittanceHistoryBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource3)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "KREM_SYSTEM.RemittanceHistory.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(0, 36)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.Size = New System.Drawing.Size(881, 611)
        Me.ReportViewer1.TabIndex = 4
        '
        'dtRemittanceHistoryTableAdapter
        '
        Me.dtRemittanceHistoryTableAdapter.ClearBeforeFill = True
        '
        'ReportViewer2
        '
        ReportDataSource4.Name = "RemHistoryRange"
        ReportDataSource4.Value = Me.dtRemittanceHistoryRangeBindingSource
        Me.ReportViewer2.LocalReport.DataSources.Add(ReportDataSource4)
        Me.ReportViewer2.LocalReport.ReportEmbeddedResource = "KREM_SYSTEM.RemHistoryRange.rdlc"
        Me.ReportViewer2.Location = New System.Drawing.Point(167, 109)
        Me.ReportViewer2.Name = "ReportViewer2"
        Me.ReportViewer2.Size = New System.Drawing.Size(396, 246)
        Me.ReportViewer2.TabIndex = 5
        '
        'dtRemittanceHistoryRangeTableAdapter
        '
        Me.dtRemittanceHistoryRangeTableAdapter.ClearBeforeFill = True
        '
        'frmRemittanceReport
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(881, 647)
        Me.Controls.Add(Me.ReportViewer2)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmRemittanceReport"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "frmRemittanceReport"
        CType(Me.dtRemittanceHistoryBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dataset, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtRemittanceHistoryRangeBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents GunaLabel1 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents Button1 As Button
    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents dtRemittanceHistoryBindingSource As BindingSource
    Friend WithEvents dataset As dataset
    Friend WithEvents dtRemittanceHistoryTableAdapter As datasetTableAdapters.dtRemittanceHistoryTableAdapter
    Friend WithEvents ReportViewer2 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents dtRemittanceHistoryRangeBindingSource As BindingSource
    Friend WithEvents dtRemittanceHistoryRangeTableAdapter As datasetTableAdapters.dtRemittanceHistoryRangeTableAdapter
End Class
