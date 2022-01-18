<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MonitorLocker
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
        Me.DataGridViewMonitorLocker = New System.Windows.Forms.DataGridView()
        Me.BtnEditLocker = New System.Windows.Forms.Button()
        Me.BtnUpdateStatus = New System.Windows.Forms.Button()
        Me.BtnTambah = New System.Windows.Forms.Button()
        Me.BtnHapus = New System.Windows.Forms.Button()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.LblUserIdentity = New System.Windows.Forms.Label()
        CType(Me.DataGridViewMonitorLocker, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridViewMonitorLocker
        '
        Me.DataGridViewMonitorLocker.AllowUserToAddRows = False
        Me.DataGridViewMonitorLocker.AllowUserToDeleteRows = False
        Me.DataGridViewMonitorLocker.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridViewMonitorLocker.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridViewMonitorLocker.Location = New System.Drawing.Point(32, 70)
        Me.DataGridViewMonitorLocker.Name = "DataGridViewMonitorLocker"
        Me.DataGridViewMonitorLocker.ReadOnly = True
        Me.DataGridViewMonitorLocker.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders
        Me.DataGridViewMonitorLocker.Size = New System.Drawing.Size(1046, 450)
        Me.DataGridViewMonitorLocker.TabIndex = 0
        '
        'BtnEditLocker
        '
        Me.BtnEditLocker.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(114, Byte), Integer), CType(CType(122, Byte), Integer))
        Me.BtnEditLocker.FlatAppearance.BorderSize = 0
        Me.BtnEditLocker.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnEditLocker.Font = New System.Drawing.Font("Poppins", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnEditLocker.ForeColor = System.Drawing.Color.White
        Me.BtnEditLocker.Location = New System.Drawing.Point(967, 538)
        Me.BtnEditLocker.Name = "BtnEditLocker"
        Me.BtnEditLocker.Size = New System.Drawing.Size(109, 30)
        Me.BtnEditLocker.TabIndex = 1
        Me.BtnEditLocker.Text = "Edit Locker"
        Me.BtnEditLocker.UseVisualStyleBackColor = False
        '
        'BtnUpdateStatus
        '
        Me.BtnUpdateStatus.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(114, Byte), Integer), CType(CType(122, Byte), Integer))
        Me.BtnUpdateStatus.FlatAppearance.BorderSize = 0
        Me.BtnUpdateStatus.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnUpdateStatus.Font = New System.Drawing.Font("Poppins", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnUpdateStatus.ForeColor = System.Drawing.Color.White
        Me.BtnUpdateStatus.Location = New System.Drawing.Point(823, 538)
        Me.BtnUpdateStatus.Name = "BtnUpdateStatus"
        Me.BtnUpdateStatus.Size = New System.Drawing.Size(125, 30)
        Me.BtnUpdateStatus.TabIndex = 2
        Me.BtnUpdateStatus.Text = "Update Status"
        Me.BtnUpdateStatus.UseVisualStyleBackColor = False
        '
        'BtnTambah
        '
        Me.BtnTambah.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(114, Byte), Integer), CType(CType(122, Byte), Integer))
        Me.BtnTambah.FlatAppearance.BorderSize = 0
        Me.BtnTambah.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnTambah.Font = New System.Drawing.Font("Poppins", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnTambah.ForeColor = System.Drawing.Color.White
        Me.BtnTambah.Location = New System.Drawing.Point(672, 538)
        Me.BtnTambah.Name = "BtnTambah"
        Me.BtnTambah.Size = New System.Drawing.Size(133, 30)
        Me.BtnTambah.TabIndex = 11
        Me.BtnTambah.Text = "Tambah Locker"
        Me.BtnTambah.UseVisualStyleBackColor = False
        '
        'BtnHapus
        '
        Me.BtnHapus.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(114, Byte), Integer), CType(CType(122, Byte), Integer))
        Me.BtnHapus.FlatAppearance.BorderSize = 0
        Me.BtnHapus.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnHapus.Font = New System.Drawing.Font("Poppins", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnHapus.ForeColor = System.Drawing.Color.White
        Me.BtnHapus.Location = New System.Drawing.Point(531, 538)
        Me.BtnHapus.Name = "BtnHapus"
        Me.BtnHapus.Size = New System.Drawing.Size(124, 30)
        Me.BtnHapus.TabIndex = 12
        Me.BtnHapus.Text = "Hapus Locker"
        Me.BtnHapus.UseVisualStyleBackColor = False
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Font = New System.Drawing.Font("Poppins", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(114, Byte), Integer), CType(CType(122, Byte), Integer))
        Me.lblTitle.Location = New System.Drawing.Point(26, 22)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(131, 34)
        Me.lblTitle.TabIndex = 15
        Me.lblTitle.Text = "Data Locker"
        Me.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'LblUserIdentity
        '
        Me.LblUserIdentity.AutoSize = True
        Me.LblUserIdentity.Font = New System.Drawing.Font("Poppins", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblUserIdentity.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(114, Byte), Integer), CType(CType(122, Byte), Integer))
        Me.LblUserIdentity.Location = New System.Drawing.Point(974, 33)
        Me.LblUserIdentity.Name = "LblUserIdentity"
        Me.LblUserIdentity.Size = New System.Drawing.Size(104, 23)
        Me.LblUserIdentity.TabIndex = 14
        Me.LblUserIdentity.Text = "Admin  [ID : 1]"
        Me.LblUserIdentity.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'MonitorLocker
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(252, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1110, 600)
        Me.Controls.Add(Me.lblTitle)
        Me.Controls.Add(Me.LblUserIdentity)
        Me.Controls.Add(Me.BtnHapus)
        Me.Controls.Add(Me.BtnTambah)
        Me.Controls.Add(Me.BtnUpdateStatus)
        Me.Controls.Add(Me.BtnEditLocker)
        Me.Controls.Add(Me.DataGridViewMonitorLocker)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(1110, 600)
        Me.MinimumSize = New System.Drawing.Size(1110, 600)
        Me.Name = "MonitorLocker"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Monitor Locker"
        CType(Me.DataGridViewMonitorLocker, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DataGridViewMonitorLocker As DataGridView
    Friend WithEvents BtnEditLocker As Button
    Friend WithEvents BtnUpdateStatus As Button
    Friend WithEvents BtnTambah As Button
    Friend WithEvents BtnHapus As Button
    Friend WithEvents lblTitle As Label
    Friend WithEvents LblUserIdentity As Label
End Class
