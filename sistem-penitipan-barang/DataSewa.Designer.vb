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
        Me.DataGridViewDataSewa = New System.Windows.Forms.DataGridView()
        Me.LblUserIdentity = New System.Windows.Forms.Label()
        Me.lblTitle = New System.Windows.Forms.Label()
        CType(Me.DataGridViewDataSewa, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BtnPengembalian
        '
        Me.BtnPengembalian.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(114, Byte), Integer), CType(CType(122, Byte), Integer))
        Me.BtnPengembalian.FlatAppearance.BorderSize = 0
        Me.BtnPengembalian.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnPengembalian.Font = New System.Drawing.Font("Poppins", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnPengembalian.ForeColor = System.Drawing.Color.White
        Me.BtnPengembalian.Location = New System.Drawing.Point(710, 538)
        Me.BtnPengembalian.Name = "BtnPengembalian"
        Me.BtnPengembalian.Size = New System.Drawing.Size(185, 30)
        Me.BtnPengembalian.TabIndex = 6
        Me.BtnPengembalian.Text = "Pengembalian Barang"
        Me.BtnPengembalian.UseVisualStyleBackColor = False
        '
        'BtnTambahData
        '
        Me.BtnTambahData.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(114, Byte), Integer), CType(CType(122, Byte), Integer))
        Me.BtnTambahData.FlatAppearance.BorderSize = 0
        Me.BtnTambahData.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnTambahData.Font = New System.Drawing.Font("Poppins", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnTambahData.ForeColor = System.Drawing.Color.White
        Me.BtnTambahData.Location = New System.Drawing.Point(914, 538)
        Me.BtnTambahData.Name = "BtnTambahData"
        Me.BtnTambahData.Size = New System.Drawing.Size(164, 30)
        Me.BtnTambahData.TabIndex = 4
        Me.BtnTambahData.Text = "Tambah Data Sewa"
        Me.BtnTambahData.UseVisualStyleBackColor = False
        '
        'DataGridViewDataSewa
        '
        Me.DataGridViewDataSewa.AllowUserToAddRows = False
        Me.DataGridViewDataSewa.AllowUserToDeleteRows = False
        Me.DataGridViewDataSewa.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridViewDataSewa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridViewDataSewa.Location = New System.Drawing.Point(32, 70)
        Me.DataGridViewDataSewa.Name = "DataGridViewDataSewa"
        Me.DataGridViewDataSewa.ReadOnly = True
        Me.DataGridViewDataSewa.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.DataGridViewDataSewa.Size = New System.Drawing.Size(1046, 450)
        Me.DataGridViewDataSewa.TabIndex = 3
        '
        'LblUserIdentity
        '
        Me.LblUserIdentity.AutoSize = True
        Me.LblUserIdentity.Font = New System.Drawing.Font("Poppins", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblUserIdentity.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(114, Byte), Integer), CType(CType(122, Byte), Integer))
        Me.LblUserIdentity.Location = New System.Drawing.Point(974, 33)
        Me.LblUserIdentity.Name = "LblUserIdentity"
        Me.LblUserIdentity.Size = New System.Drawing.Size(104, 23)
        Me.LblUserIdentity.TabIndex = 9
        Me.LblUserIdentity.Text = "Admin  [ID : 1]"
        Me.LblUserIdentity.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Font = New System.Drawing.Font("Poppins", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(114, Byte), Integer), CType(CType(122, Byte), Integer))
        Me.lblTitle.Location = New System.Drawing.Point(26, 22)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(120, 34)
        Me.lblTitle.TabIndex = 9
        Me.lblTitle.Text = "Data Sewa"
        Me.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'DataSewa
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(252, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1110, 600)
        Me.Controls.Add(Me.lblTitle)
        Me.Controls.Add(Me.LblUserIdentity)
        Me.Controls.Add(Me.BtnPengembalian)
        Me.Controls.Add(Me.BtnTambahData)
        Me.Controls.Add(Me.DataGridViewDataSewa)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(1110, 600)
        Me.MinimumSize = New System.Drawing.Size(1110, 600)
        Me.Name = "DataSewa"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Data Sewa"
        CType(Me.DataGridViewDataSewa, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BtnPengembalian As Button
    Friend WithEvents BtnTambahData As Button
    Friend WithEvents DataGridViewDataSewa As DataGridView
    Friend WithEvents LblUserIdentity As Label
    Friend WithEvents lblTitle As Label
End Class
