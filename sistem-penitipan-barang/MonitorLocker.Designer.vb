<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
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
        Me.titleLabel = New System.Windows.Forms.Label()
        Me.BtnEditLocker = New System.Windows.Forms.Button()
        Me.BtnUpdateStatus = New System.Windows.Forms.Button()
        CType(Me.DataGridViewMonitorLocker, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridViewMonitorLocker
        '
        Me.DataGridViewMonitorLocker.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridViewMonitorLocker.Location = New System.Drawing.Point(26, 70)
        Me.DataGridViewMonitorLocker.Name = "DataGridViewMonitorLocker"
        Me.DataGridViewMonitorLocker.Size = New System.Drawing.Size(634, 250)
        Me.DataGridViewMonitorLocker.TabIndex = 0
        '
        'titleLabel
        '
        Me.titleLabel.AutoSize = True
        Me.titleLabel.Font = New System.Drawing.Font("Microsoft Tai Le", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.titleLabel.Location = New System.Drawing.Point(20, 20)
        Me.titleLabel.Name = "titleLabel"
        Me.titleLabel.Size = New System.Drawing.Size(213, 34)
        Me.titleLabel.TabIndex = 1
        Me.titleLabel.Text = "Monitor Locker"
        '
        'BtnEditLocker
        '
        Me.BtnEditLocker.Location = New System.Drawing.Point(576, 343)
        Me.BtnEditLocker.Name = "BtnEditLocker"
        Me.BtnEditLocker.Size = New System.Drawing.Size(84, 23)
        Me.BtnEditLocker.TabIndex = 2
        Me.BtnEditLocker.Text = "Edit Locker"
        Me.BtnEditLocker.UseVisualStyleBackColor = True
        '
        'BtnUpdateStatus
        '
        Me.BtnUpdateStatus.Location = New System.Drawing.Point(464, 343)
        Me.BtnUpdateStatus.Name = "BtnUpdateStatus"
        Me.BtnUpdateStatus.Size = New System.Drawing.Size(98, 23)
        Me.BtnUpdateStatus.TabIndex = 2
        Me.BtnUpdateStatus.Text = "Update Status"
        Me.BtnUpdateStatus.UseVisualStyleBackColor = True
        '
        'MonitorLocker
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(684, 391)
        Me.Controls.Add(Me.BtnUpdateStatus)
        Me.Controls.Add(Me.BtnEditLocker)
        Me.Controls.Add(Me.titleLabel)
        Me.Controls.Add(Me.DataGridViewMonitorLocker)
        Me.Name = "MonitorLocker"
        Me.Text = "Monitor Locker"
        CType(Me.DataGridViewMonitorLocker, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DataGridViewMonitorLocker As DataGridView
    Friend WithEvents titleLabel As Label
    Friend WithEvents BtnEditLocker As Button
    Friend WithEvents BtnUpdateStatus As Button
End Class
