<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class DataSewa
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
        Me.BtnPengembalian = New System.Windows.Forms.Button()
        Me.BtnTambahData = New System.Windows.Forms.Button()
        Me.titleLbl = New System.Windows.Forms.Label()
        Me.DataGridViewDataSewa = New System.Windows.Forms.DataGridView()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.DataSewaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MonitorLockerToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.JenisLockerToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        CType(Me.DataGridViewDataSewa, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'BtnPengembalian
        '
        Me.BtnPengembalian.Font = New System.Drawing.Font("Microsoft Tai Le", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnPengembalian.Location = New System.Drawing.Point(750, 563)
        Me.BtnPengembalian.Name = "BtnPengembalian"
        Me.BtnPengembalian.Size = New System.Drawing.Size(151, 28)
        Me.BtnPengembalian.TabIndex = 6
        Me.BtnPengembalian.Text = "Pengembalian Barang"
        Me.BtnPengembalian.UseVisualStyleBackColor = True
        '
        'BtnTambahData
        '
        Me.BtnTambahData.Font = New System.Drawing.Font("Microsoft Tai Le", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnTambahData.Location = New System.Drawing.Point(917, 563)
        Me.BtnTambahData.Name = "BtnTambahData"
        Me.BtnTambahData.Size = New System.Drawing.Size(143, 28)
        Me.BtnTambahData.TabIndex = 4
        Me.BtnTambahData.Text = "Tambah Data Sewa"
        Me.BtnTambahData.UseVisualStyleBackColor = True
        '
        'titleLbl
        '
        Me.titleLbl.AutoSize = True
        Me.titleLbl.Font = New System.Drawing.Font("Microsoft Tai Le", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.titleLbl.Location = New System.Drawing.Point(20, 40)
        Me.titleLbl.Name = "titleLbl"
        Me.titleLbl.Size = New System.Drawing.Size(150, 34)
        Me.titleLbl.TabIndex = 5
        Me.titleLbl.Text = "Data Sewa"
        '
        'DataGridViewDataSewa
        '
        Me.DataGridViewDataSewa.AllowUserToAddRows = False
        Me.DataGridViewDataSewa.AllowUserToDeleteRows = False
        Me.DataGridViewDataSewa.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridViewDataSewa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridViewDataSewa.Location = New System.Drawing.Point(26, 90)
        Me.DataGridViewDataSewa.Name = "DataGridViewDataSewa"
        Me.DataGridViewDataSewa.ReadOnly = True
        Me.DataGridViewDataSewa.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.DataGridViewDataSewa.Size = New System.Drawing.Size(1034, 450)
        Me.DataGridViewDataSewa.TabIndex = 3
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DataSewaToolStripMenuItem, Me.MonitorLockerToolStripMenuItem, Me.JenisLockerToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1084, 24)
        Me.MenuStrip1.TabIndex = 7
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
        'DataSewa
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1084, 616)
        Me.Controls.Add(Me.BtnPengembalian)
        Me.Controls.Add(Me.BtnTambahData)
        Me.Controls.Add(Me.titleLbl)
        Me.Controls.Add(Me.DataGridViewDataSewa)
        Me.Controls.Add(Me.MenuStrip1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MainMenuStrip = Me.MenuStrip1
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(1100, 655)
        Me.MinimumSize = New System.Drawing.Size(1100, 655)
        Me.Name = "DataSewa"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Data Sewa"
        CType(Me.DataGridViewDataSewa, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BtnPengembalian As Button
    Friend WithEvents BtnTambahData As Button
    Friend WithEvents titleLbl As Label
    Friend WithEvents DataGridViewDataSewa As DataGridView
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents DataSewaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MonitorLockerToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents JenisLockerToolStripMenuItem As ToolStripMenuItem
End Class
