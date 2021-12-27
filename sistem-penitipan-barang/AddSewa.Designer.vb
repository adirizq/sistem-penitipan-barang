<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AddSewa
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
        Me.titleLbl = New System.Windows.Forms.Label()
        Me.CBUkuran = New System.Windows.Forms.ComboBox()
        Me.LblUkuran = New System.Windows.Forms.Label()
        Me.TxtLamaSewa = New System.Windows.Forms.TextBox()
        Me.LblLamaSewa = New System.Windows.Forms.Label()
        Me.CBLocker = New System.Windows.Forms.ComboBox()
        Me.LblLocker = New System.Windows.Forms.Label()
        Me.Lbl1 = New System.Windows.Forms.Label()
        Me.LblBiayaSewa = New System.Windows.Forms.Label()
        Me.LblBiayaSewaValue = New System.Windows.Forms.Label()
        Me.LblWarn = New System.Windows.Forms.Label()
        Me.btnTambah = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'titleLbl
        '
        Me.titleLbl.AutoSize = True
        Me.titleLbl.Font = New System.Drawing.Font("Microsoft Tai Le", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.titleLbl.Location = New System.Drawing.Point(0, 25)
        Me.titleLbl.MaximumSize = New System.Drawing.Size(373, 34)
        Me.titleLbl.MinimumSize = New System.Drawing.Size(373, 34)
        Me.titleLbl.Name = "titleLbl"
        Me.titleLbl.Size = New System.Drawing.Size(373, 34)
        Me.titleLbl.TabIndex = 0
        Me.titleLbl.Text = "Tambah Data Sewa"
        Me.titleLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'CBUkuran
        '
        Me.CBUkuran.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CBUkuran.Font = New System.Drawing.Font("Microsoft Tai Le", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CBUkuran.FormattingEnabled = True
        Me.CBUkuran.Location = New System.Drawing.Point(133, 90)
        Me.CBUkuran.Name = "CBUkuran"
        Me.CBUkuran.Size = New System.Drawing.Size(212, 24)
        Me.CBUkuran.TabIndex = 1
        '
        'LblUkuran
        '
        Me.LblUkuran.AutoSize = True
        Me.LblUkuran.Font = New System.Drawing.Font("Microsoft Tai Le", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblUkuran.Location = New System.Drawing.Point(23, 93)
        Me.LblUkuran.Name = "LblUkuran"
        Me.LblUkuran.Size = New System.Drawing.Size(91, 16)
        Me.LblUkuran.TabIndex = 9
        Me.LblUkuran.Text = "Ukuran Locker"
        '
        'TxtLamaSewa
        '
        Me.TxtLamaSewa.Font = New System.Drawing.Font("Microsoft Tai Le", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtLamaSewa.Location = New System.Drawing.Point(133, 180)
        Me.TxtLamaSewa.Name = "TxtLamaSewa"
        Me.TxtLamaSewa.Size = New System.Drawing.Size(174, 24)
        Me.TxtLamaSewa.TabIndex = 3
        '
        'LblLamaSewa
        '
        Me.LblLamaSewa.AutoSize = True
        Me.LblLamaSewa.Font = New System.Drawing.Font("Microsoft Tai Le", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblLamaSewa.Location = New System.Drawing.Point(23, 183)
        Me.LblLamaSewa.Name = "LblLamaSewa"
        Me.LblLamaSewa.Size = New System.Drawing.Size(73, 16)
        Me.LblLamaSewa.TabIndex = 11
        Me.LblLamaSewa.Text = "Lama Sewa"
        '
        'CBLocker
        '
        Me.CBLocker.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CBLocker.Font = New System.Drawing.Font("Microsoft Tai Le", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CBLocker.FormattingEnabled = True
        Me.CBLocker.Location = New System.Drawing.Point(133, 135)
        Me.CBLocker.Name = "CBLocker"
        Me.CBLocker.Size = New System.Drawing.Size(212, 24)
        Me.CBLocker.TabIndex = 2
        '
        'LblLocker
        '
        Me.LblLocker.AutoSize = True
        Me.LblLocker.Font = New System.Drawing.Font("Microsoft Tai Le", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblLocker.Location = New System.Drawing.Point(23, 138)
        Me.LblLocker.Name = "LblLocker"
        Me.LblLocker.Size = New System.Drawing.Size(68, 16)
        Me.LblLocker.TabIndex = 13
        Me.LblLocker.Text = "No Locker"
        '
        'Lbl1
        '
        Me.Lbl1.AutoSize = True
        Me.Lbl1.Font = New System.Drawing.Font("Microsoft Tai Le", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl1.Location = New System.Drawing.Point(314, 179)
        Me.Lbl1.MaximumSize = New System.Drawing.Size(0, 24)
        Me.Lbl1.MinimumSize = New System.Drawing.Size(0, 24)
        Me.Lbl1.Name = "Lbl1"
        Me.Lbl1.Size = New System.Drawing.Size(31, 24)
        Me.Lbl1.TabIndex = 14
        Me.Lbl1.Text = "Jam"
        Me.Lbl1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LblBiayaSewa
        '
        Me.LblBiayaSewa.AutoSize = True
        Me.LblBiayaSewa.Font = New System.Drawing.Font("Microsoft Tai Le", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblBiayaSewa.Location = New System.Drawing.Point(0, 242)
        Me.LblBiayaSewa.MaximumSize = New System.Drawing.Size(373, 16)
        Me.LblBiayaSewa.MinimumSize = New System.Drawing.Size(373, 16)
        Me.LblBiayaSewa.Name = "LblBiayaSewa"
        Me.LblBiayaSewa.Size = New System.Drawing.Size(373, 16)
        Me.LblBiayaSewa.TabIndex = 11
        Me.LblBiayaSewa.Text = "Biaya Sewa"
        Me.LblBiayaSewa.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LblBiayaSewaValue
        '
        Me.LblBiayaSewaValue.AutoSize = True
        Me.LblBiayaSewaValue.Font = New System.Drawing.Font("Microsoft Tai Le", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblBiayaSewaValue.Location = New System.Drawing.Point(0, 267)
        Me.LblBiayaSewaValue.MaximumSize = New System.Drawing.Size(373, 31)
        Me.LblBiayaSewaValue.MinimumSize = New System.Drawing.Size(373, 31)
        Me.LblBiayaSewaValue.Name = "LblBiayaSewaValue"
        Me.LblBiayaSewaValue.Size = New System.Drawing.Size(373, 31)
        Me.LblBiayaSewaValue.TabIndex = 11
        Me.LblBiayaSewaValue.Text = "Rp.100000"
        Me.LblBiayaSewaValue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LblWarn
        '
        Me.LblWarn.AutoSize = True
        Me.LblWarn.Font = New System.Drawing.Font("Microsoft Tai Le", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblWarn.Location = New System.Drawing.Point(25, 310)
        Me.LblWarn.MaximumSize = New System.Drawing.Size(323, 32)
        Me.LblWarn.MinimumSize = New System.Drawing.Size(323, 32)
        Me.LblWarn.Name = "LblWarn"
        Me.LblWarn.Size = New System.Drawing.Size(323, 32)
        Me.LblWarn.TabIndex = 11
        Me.LblWarn.Text = "*Tidak termasuk denda keterlambatan pengambilan barang"
        Me.LblWarn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnTambah
        '
        Me.btnTambah.Font = New System.Drawing.Font("Microsoft Tai Le", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnTambah.Location = New System.Drawing.Point(25, 374)
        Me.btnTambah.MaximumSize = New System.Drawing.Size(323, 32)
        Me.btnTambah.MinimumSize = New System.Drawing.Size(323, 32)
        Me.btnTambah.Name = "btnTambah"
        Me.btnTambah.Size = New System.Drawing.Size(323, 32)
        Me.btnTambah.TabIndex = 4
        Me.btnTambah.Text = "Tambah"
        Me.btnTambah.UseVisualStyleBackColor = True
        '
        'AddSewa
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(373, 434)
        Me.Controls.Add(Me.btnTambah)
        Me.Controls.Add(Me.Lbl1)
        Me.Controls.Add(Me.CBLocker)
        Me.Controls.Add(Me.LblLocker)
        Me.Controls.Add(Me.TxtLamaSewa)
        Me.Controls.Add(Me.LblBiayaSewaValue)
        Me.Controls.Add(Me.LblWarn)
        Me.Controls.Add(Me.LblBiayaSewa)
        Me.Controls.Add(Me.LblLamaSewa)
        Me.Controls.Add(Me.CBUkuran)
        Me.Controls.Add(Me.LblUkuran)
        Me.Controls.Add(Me.titleLbl)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(389, 473)
        Me.MinimumSize = New System.Drawing.Size(389, 473)
        Me.Name = "AddSewa"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Tambah Data Sewa"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents titleLbl As Label
    Friend WithEvents CBUkuran As ComboBox
    Friend WithEvents LblUkuran As Label
    Friend WithEvents TxtLamaSewa As TextBox
    Friend WithEvents LblLamaSewa As Label
    Friend WithEvents CBLocker As ComboBox
    Friend WithEvents LblLocker As Label
    Friend WithEvents Lbl1 As Label
    Friend WithEvents LblBiayaSewa As Label
    Friend WithEvents LblBiayaSewaValue As Label
    Friend WithEvents LblWarn As Label
    Friend WithEvents btnTambah As Button
End Class
