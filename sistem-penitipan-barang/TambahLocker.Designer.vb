<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class TambahLocker
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
        Me.TxtNamaLocker = New System.Windows.Forms.TextBox()
        Me.LblLamaSewa = New System.Windows.Forms.Label()
        Me.CBUkuran = New System.Windows.Forms.ComboBox()
        Me.LblUkuran = New System.Windows.Forms.Label()
        Me.titleLbl = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TxtLokasi = New System.Windows.Forms.TextBox()
        Me.LblBiayaSewaValue = New System.Windows.Forms.Label()
        Me.LblBiayaSewa = New System.Windows.Forms.Label()
        Me.btnTambah = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'TxtNamaLocker
        '
        Me.TxtNamaLocker.Font = New System.Drawing.Font("Microsoft Tai Le", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtNamaLocker.Location = New System.Drawing.Point(133, 157)
        Me.TxtNamaLocker.Name = "TxtNamaLocker"
        Me.TxtNamaLocker.Size = New System.Drawing.Size(212, 24)
        Me.TxtNamaLocker.TabIndex = 14
        '
        'LblLamaSewa
        '
        Me.LblLamaSewa.AutoSize = True
        Me.LblLamaSewa.Font = New System.Drawing.Font("Microsoft Tai Le", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblLamaSewa.Location = New System.Drawing.Point(23, 160)
        Me.LblLamaSewa.Name = "LblLamaSewa"
        Me.LblLamaSewa.Size = New System.Drawing.Size(85, 16)
        Me.LblLamaSewa.TabIndex = 16
        Me.LblLamaSewa.Text = "Nama Locker"
        '
        'CBUkuran
        '
        Me.CBUkuran.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CBUkuran.Font = New System.Drawing.Font("Microsoft Tai Le", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CBUkuran.FormattingEnabled = True
        Me.CBUkuran.Location = New System.Drawing.Point(133, 112)
        Me.CBUkuran.Name = "CBUkuran"
        Me.CBUkuran.Size = New System.Drawing.Size(212, 24)
        Me.CBUkuran.TabIndex = 13
        '
        'LblUkuran
        '
        Me.LblUkuran.AutoSize = True
        Me.LblUkuran.Font = New System.Drawing.Font("Microsoft Tai Le", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblUkuran.Location = New System.Drawing.Point(23, 115)
        Me.LblUkuran.Name = "LblUkuran"
        Me.LblUkuran.Size = New System.Drawing.Size(91, 16)
        Me.LblUkuran.TabIndex = 15
        Me.LblUkuran.Text = "Ukuran Locker"
        '
        'titleLbl
        '
        Me.titleLbl.AutoSize = True
        Me.titleLbl.Font = New System.Drawing.Font("Microsoft Tai Le", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.titleLbl.Location = New System.Drawing.Point(0, 40)
        Me.titleLbl.MaximumSize = New System.Drawing.Size(373, 34)
        Me.titleLbl.MinimumSize = New System.Drawing.Size(373, 34)
        Me.titleLbl.Name = "titleLbl"
        Me.titleLbl.Size = New System.Drawing.Size(373, 34)
        Me.titleLbl.TabIndex = 12
        Me.titleLbl.Text = "Tambah Locker"
        Me.titleLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Tai Le", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(23, 207)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(44, 16)
        Me.Label1.TabIndex = 16
        Me.Label1.Text = "Lokasi"
        '
        'TxtLokasi
        '
        Me.TxtLokasi.Font = New System.Drawing.Font("Microsoft Tai Le", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtLokasi.Location = New System.Drawing.Point(133, 204)
        Me.TxtLokasi.Name = "TxtLokasi"
        Me.TxtLokasi.Size = New System.Drawing.Size(212, 24)
        Me.TxtLokasi.TabIndex = 14
        '
        'LblBiayaSewaValue
        '
        Me.LblBiayaSewaValue.AutoSize = True
        Me.LblBiayaSewaValue.Font = New System.Drawing.Font("Microsoft Tai Le", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblBiayaSewaValue.Location = New System.Drawing.Point(0, 301)
        Me.LblBiayaSewaValue.MaximumSize = New System.Drawing.Size(373, 31)
        Me.LblBiayaSewaValue.MinimumSize = New System.Drawing.Size(373, 31)
        Me.LblBiayaSewaValue.Name = "LblBiayaSewaValue"
        Me.LblBiayaSewaValue.Size = New System.Drawing.Size(373, 31)
        Me.LblBiayaSewaValue.TabIndex = 17
        Me.LblBiayaSewaValue.Text = "Rp.0"
        Me.LblBiayaSewaValue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LblBiayaSewa
        '
        Me.LblBiayaSewa.AutoSize = True
        Me.LblBiayaSewa.Font = New System.Drawing.Font("Microsoft Tai Le", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblBiayaSewa.Location = New System.Drawing.Point(0, 276)
        Me.LblBiayaSewa.MaximumSize = New System.Drawing.Size(373, 16)
        Me.LblBiayaSewa.MinimumSize = New System.Drawing.Size(373, 16)
        Me.LblBiayaSewa.Name = "LblBiayaSewa"
        Me.LblBiayaSewa.Size = New System.Drawing.Size(373, 16)
        Me.LblBiayaSewa.TabIndex = 18
        Me.LblBiayaSewa.Text = "Biaya Sewa Perjam"
        Me.LblBiayaSewa.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnTambah
        '
        Me.btnTambah.Font = New System.Drawing.Font("Microsoft Tai Le", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnTambah.Location = New System.Drawing.Point(25, 377)
        Me.btnTambah.MaximumSize = New System.Drawing.Size(323, 32)
        Me.btnTambah.MinimumSize = New System.Drawing.Size(323, 32)
        Me.btnTambah.Name = "btnTambah"
        Me.btnTambah.Size = New System.Drawing.Size(323, 32)
        Me.btnTambah.TabIndex = 19
        Me.btnTambah.Text = "Tambah"
        Me.btnTambah.UseVisualStyleBackColor = True
        '
        'TambahLocker
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(373, 434)
        Me.Controls.Add(Me.btnTambah)
        Me.Controls.Add(Me.LblBiayaSewaValue)
        Me.Controls.Add(Me.LblBiayaSewa)
        Me.Controls.Add(Me.TxtLokasi)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TxtNamaLocker)
        Me.Controls.Add(Me.LblLamaSewa)
        Me.Controls.Add(Me.CBUkuran)
        Me.Controls.Add(Me.LblUkuran)
        Me.Controls.Add(Me.titleLbl)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(389, 473)
        Me.MinimumSize = New System.Drawing.Size(389, 473)
        Me.Name = "TambahLocker"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Tambah Locker"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TxtNamaLocker As TextBox
    Friend WithEvents LblLamaSewa As Label
    Friend WithEvents CBUkuran As ComboBox
    Friend WithEvents LblUkuran As Label
    Friend WithEvents titleLbl As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents TxtLokasi As TextBox
    Friend WithEvents LblBiayaSewaValue As Label
    Friend WithEvents LblBiayaSewa As Label
    Friend WithEvents btnTambah As Button
End Class
