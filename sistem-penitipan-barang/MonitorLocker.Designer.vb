﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MonitorLocker
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
        Me.DataGridViewMonitorLocker = New System.Windows.Forms.DataGridView()
        Me.titleLbl = New System.Windows.Forms.Label()
        Me.BtnEditLocker = New System.Windows.Forms.Button()
        Me.BtnUpdateStatus = New System.Windows.Forms.Button()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.DataSewaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MonitorLockerToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.JenisLockerToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        CType(Me.DataGridViewMonitorLocker, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'DataGridViewMonitorLocker
        '
        Me.DataGridViewMonitorLocker.AllowUserToAddRows = False
        Me.DataGridViewMonitorLocker.AllowUserToDeleteRows = False
        Me.DataGridViewMonitorLocker.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridViewMonitorLocker.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridViewMonitorLocker.Location = New System.Drawing.Point(26, 90)
        Me.DataGridViewMonitorLocker.Name = "DataGridViewMonitorLocker"
        Me.DataGridViewMonitorLocker.ReadOnly = True
        Me.DataGridViewMonitorLocker.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders
        Me.DataGridViewMonitorLocker.Size = New System.Drawing.Size(634, 250)
        Me.DataGridViewMonitorLocker.TabIndex = 0
        '
        'titleLbl
        '
        Me.titleLbl.AutoSize = True
        Me.titleLbl.Font = New System.Drawing.Font("Microsoft Tai Le", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.titleLbl.Location = New System.Drawing.Point(20, 40)
        Me.titleLbl.Name = "titleLbl"
        Me.titleLbl.Size = New System.Drawing.Size(213, 34)
        Me.titleLbl.TabIndex = 1
        Me.titleLbl.Text = "Monitor Locker"
        '
        'BtnEditLocker
        '
        Me.BtnEditLocker.Font = New System.Drawing.Font("Microsoft Tai Le", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnEditLocker.Location = New System.Drawing.Point(576, 363)
        Me.BtnEditLocker.Name = "BtnEditLocker"
        Me.BtnEditLocker.Size = New System.Drawing.Size(84, 28)
        Me.BtnEditLocker.TabIndex = 1
        Me.BtnEditLocker.Text = "Edit Locker"
        Me.BtnEditLocker.UseVisualStyleBackColor = True
        '
        'BtnUpdateStatus
        '
        Me.BtnUpdateStatus.Font = New System.Drawing.Font("Microsoft Tai Le", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnUpdateStatus.Location = New System.Drawing.Point(464, 363)
        Me.BtnUpdateStatus.Name = "BtnUpdateStatus"
        Me.BtnUpdateStatus.Size = New System.Drawing.Size(98, 28)
        Me.BtnUpdateStatus.TabIndex = 2
        Me.BtnUpdateStatus.Text = "Update Status"
        Me.BtnUpdateStatus.UseVisualStyleBackColor = True
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DataSewaToolStripMenuItem, Me.MonitorLockerToolStripMenuItem, Me.JenisLockerToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(684, 24)
        Me.MenuStrip1.TabIndex = 8
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'DataSewaToolStripMenuItem
        '
        Me.DataSewaToolStripMenuItem.Name = "DataSewaToolStripMenuItem"
        Me.DataSewaToolStripMenuItem.Size = New System.Drawing.Size(73, 20)
        Me.DataSewaToolStripMenuItem.Text = "Data Sewa"
        '
        'MonitorLockerToolStripMenuItem
        '
        Me.MonitorLockerToolStripMenuItem.Name = "MonitorLockerToolStripMenuItem"
        Me.MonitorLockerToolStripMenuItem.Size = New System.Drawing.Size(100, 20)
        Me.MonitorLockerToolStripMenuItem.Text = "Monitor Locker"
        '
        'JenisLockerToolStripMenuItem
        '
        Me.JenisLockerToolStripMenuItem.Name = "JenisLockerToolStripMenuItem"
        Me.JenisLockerToolStripMenuItem.Size = New System.Drawing.Size(82, 20)
        Me.JenisLockerToolStripMenuItem.Text = "Jenis Locker"
        '
        'MonitorLocker
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(684, 416)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.BtnUpdateStatus)
        Me.Controls.Add(Me.BtnEditLocker)
        Me.Controls.Add(Me.titleLbl)
        Me.Controls.Add(Me.DataGridViewMonitorLocker)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(700, 455)
        Me.MinimumSize = New System.Drawing.Size(700, 455)
        Me.Name = "MonitorLocker"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Monitor Locker"
        CType(Me.DataGridViewMonitorLocker, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DataGridViewMonitorLocker As DataGridView
    Friend WithEvents titleLbl As Label
    Friend WithEvents BtnEditLocker As Button
    Friend WithEvents BtnUpdateStatus As Button
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents DataSewaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MonitorLockerToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents JenisLockerToolStripMenuItem As ToolStripMenuItem
End Class
