<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class JenisLocker
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
        Me.BtnTambah = New System.Windows.Forms.Button()
        Me.BtnHapus = New System.Windows.Forms.Button()
        Me.titleLbl = New System.Windows.Forms.Label()
        Me.DataGridViewJenisLocker = New System.Windows.Forms.DataGridView()
        Me.BtnUpdate = New System.Windows.Forms.Button()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.DataSewaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MonitorLockerToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.JenisLockerToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        CType(Me.DataGridViewJenisLocker, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'BtnTambah
        '
        Me.BtnTambah.Font = New System.Drawing.Font("Microsoft Tai Le", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnTambah.Location = New System.Drawing.Point(356, 362)
        Me.BtnTambah.Name = "BtnTambah"
        Me.BtnTambah.Size = New System.Drawing.Size(98, 28)
        Me.BtnTambah.TabIndex = 6
        Me.BtnTambah.Text = "Tambah"
        Me.BtnTambah.UseVisualStyleBackColor = True
        '
        'BtnHapus
        '
        Me.BtnHapus.Font = New System.Drawing.Font("Microsoft Tai Le", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnHapus.Location = New System.Drawing.Point(576, 363)
        Me.BtnHapus.Name = "BtnHapus"
        Me.BtnHapus.Size = New System.Drawing.Size(84, 28)
        Me.BtnHapus.TabIndex = 4
        Me.BtnHapus.Text = "Hapus"
        Me.BtnHapus.UseVisualStyleBackColor = True
        '
        'titleLbl
        '
        Me.titleLbl.AutoSize = True
        Me.titleLbl.Font = New System.Drawing.Font("Microsoft Tai Le", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.titleLbl.Location = New System.Drawing.Point(20, 40)
        Me.titleLbl.Name = "titleLbl"
        Me.titleLbl.Size = New System.Drawing.Size(170, 34)
        Me.titleLbl.TabIndex = 5
        Me.titleLbl.Text = "Jenis Locker"
        '
        'DataGridViewJenisLocker
        '
        Me.DataGridViewJenisLocker.AllowUserToAddRows = False
        Me.DataGridViewJenisLocker.AllowUserToDeleteRows = False
        Me.DataGridViewJenisLocker.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridViewJenisLocker.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridViewJenisLocker.Location = New System.Drawing.Point(26, 90)
        Me.DataGridViewJenisLocker.Name = "DataGridViewJenisLocker"
        Me.DataGridViewJenisLocker.ReadOnly = True
        Me.DataGridViewJenisLocker.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders
        Me.DataGridViewJenisLocker.Size = New System.Drawing.Size(634, 250)
        Me.DataGridViewJenisLocker.TabIndex = 3
        '
        'BtnUpdate
        '
        Me.BtnUpdate.Font = New System.Drawing.Font("Microsoft Tai Le", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnUpdate.Location = New System.Drawing.Point(466, 363)
        Me.BtnUpdate.Name = "BtnUpdate"
        Me.BtnUpdate.Size = New System.Drawing.Size(98, 28)
        Me.BtnUpdate.TabIndex = 7
        Me.BtnUpdate.Text = "Update"
        Me.BtnUpdate.UseVisualStyleBackColor = True
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
        'JenisLocker
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(684, 416)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.BtnUpdate)
        Me.Controls.Add(Me.BtnTambah)
        Me.Controls.Add(Me.BtnHapus)
        Me.Controls.Add(Me.titleLbl)
        Me.Controls.Add(Me.DataGridViewJenisLocker)
        Me.MaximumSize = New System.Drawing.Size(700, 455)
        Me.MinimumSize = New System.Drawing.Size(700, 455)
        Me.Name = "JenisLocker"
        Me.Text = "JenisLocker"
        CType(Me.DataGridViewJenisLocker, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BtnTambah As Button
    Friend WithEvents BtnHapus As Button
    Friend WithEvents titleLbl As Label
    Friend WithEvents DataGridViewJenisLocker As DataGridView
    Friend WithEvents BtnUpdate As Button
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents DataSewaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MonitorLockerToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents JenisLockerToolStripMenuItem As ToolStripMenuItem
End Class
