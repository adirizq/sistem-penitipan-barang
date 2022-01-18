<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PengembalianBarang
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
        Me.LblDendaValue = New System.Windows.Forms.Label()
        Me.LblDenda = New System.Windows.Forms.Label()
        Me.titleLbl = New System.Windows.Forms.Label()
        Me.LblSewa = New System.Windows.Forms.Label()
        Me.LblNoSewaValue = New System.Windows.Forms.Label()
        Me.LblLocker = New System.Windows.Forms.Label()
        Me.LblNamaLockerValue = New System.Windows.Forms.Label()
        Me.LblKeterlambatan = New System.Windows.Forms.Label()
        Me.LblKeterlambatanValue = New System.Windows.Forms.Label()
        Me.btnKonfirmasi = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'LblDendaValue
        '
        Me.LblDendaValue.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LblDendaValue.Font = New System.Drawing.Font("Poppins", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblDendaValue.ForeColor = System.Drawing.Color.Firebrick
        Me.LblDendaValue.Location = New System.Drawing.Point(0, 326)
        Me.LblDendaValue.Name = "LblDendaValue"
        Me.LblDendaValue.Size = New System.Drawing.Size(380, 31)
        Me.LblDendaValue.TabIndex = 16
        Me.LblDendaValue.Text = "Rp.100000"
        Me.LblDendaValue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LblDenda
        '
        Me.LblDenda.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LblDenda.Font = New System.Drawing.Font("Poppins", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblDenda.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(114, Byte), Integer), CType(CType(122, Byte), Integer))
        Me.LblDenda.Location = New System.Drawing.Point(0, 303)
        Me.LblDenda.Name = "LblDenda"
        Me.LblDenda.Size = New System.Drawing.Size(380, 18)
        Me.LblDenda.TabIndex = 17
        Me.LblDenda.Text = "Denda"
        Me.LblDenda.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'titleLbl
        '
        Me.titleLbl.Dock = System.Windows.Forms.DockStyle.Top
        Me.titleLbl.Font = New System.Drawing.Font("Poppins", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.titleLbl.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(114, Byte), Integer), CType(CType(122, Byte), Integer))
        Me.titleLbl.Location = New System.Drawing.Point(0, 0)
        Me.titleLbl.Margin = New System.Windows.Forms.Padding(3, 20, 3, 0)
        Me.titleLbl.Name = "titleLbl"
        Me.titleLbl.Padding = New System.Windows.Forms.Padding(0, 32, 0, 0)
        Me.titleLbl.Size = New System.Drawing.Size(380, 65)
        Me.titleLbl.TabIndex = 0
        Me.titleLbl.Text = "Pengembalian Barang"
        Me.titleLbl.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'LblSewa
        '
        Me.LblSewa.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LblSewa.Font = New System.Drawing.Font("Poppins", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblSewa.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(114, Byte), Integer), CType(CType(122, Byte), Integer))
        Me.LblSewa.Location = New System.Drawing.Point(0, 104)
        Me.LblSewa.Name = "LblSewa"
        Me.LblSewa.Size = New System.Drawing.Size(380, 18)
        Me.LblSewa.TabIndex = 18
        Me.LblSewa.Text = "No Sewa :"
        Me.LblSewa.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LblNoSewaValue
        '
        Me.LblNoSewaValue.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LblNoSewaValue.Font = New System.Drawing.Font("Poppins", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblNoSewaValue.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(114, Byte), Integer), CType(CType(122, Byte), Integer))
        Me.LblNoSewaValue.Location = New System.Drawing.Point(0, 124)
        Me.LblNoSewaValue.Name = "LblNoSewaValue"
        Me.LblNoSewaValue.Size = New System.Drawing.Size(380, 23)
        Me.LblNoSewaValue.TabIndex = 18
        Me.LblNoSewaValue.Text = "1"
        Me.LblNoSewaValue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LblLocker
        '
        Me.LblLocker.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LblLocker.Font = New System.Drawing.Font("Poppins", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblLocker.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(114, Byte), Integer), CType(CType(122, Byte), Integer))
        Me.LblLocker.Location = New System.Drawing.Point(0, 158)
        Me.LblLocker.Name = "LblLocker"
        Me.LblLocker.Size = New System.Drawing.Size(380, 18)
        Me.LblLocker.TabIndex = 18
        Me.LblLocker.Text = "Nama Locker :"
        Me.LblLocker.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LblNamaLockerValue
        '
        Me.LblNamaLockerValue.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LblNamaLockerValue.Font = New System.Drawing.Font("Poppins", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblNamaLockerValue.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(114, Byte), Integer), CType(CType(122, Byte), Integer))
        Me.LblNamaLockerValue.Location = New System.Drawing.Point(0, 179)
        Me.LblNamaLockerValue.Name = "LblNamaLockerValue"
        Me.LblNamaLockerValue.Size = New System.Drawing.Size(380, 23)
        Me.LblNamaLockerValue.TabIndex = 18
        Me.LblNamaLockerValue.Text = "1"
        Me.LblNamaLockerValue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LblKeterlambatan
        '
        Me.LblKeterlambatan.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LblKeterlambatan.Font = New System.Drawing.Font("Poppins", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblKeterlambatan.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(114, Byte), Integer), CType(CType(122, Byte), Integer))
        Me.LblKeterlambatan.Location = New System.Drawing.Point(0, 212)
        Me.LblKeterlambatan.Name = "LblKeterlambatan"
        Me.LblKeterlambatan.Size = New System.Drawing.Size(380, 18)
        Me.LblKeterlambatan.TabIndex = 18
        Me.LblKeterlambatan.Text = "Keterlambatan :"
        Me.LblKeterlambatan.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LblKeterlambatanValue
        '
        Me.LblKeterlambatanValue.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LblKeterlambatanValue.Font = New System.Drawing.Font("Poppins", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblKeterlambatanValue.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(114, Byte), Integer), CType(CType(122, Byte), Integer))
        Me.LblKeterlambatanValue.Location = New System.Drawing.Point(0, 234)
        Me.LblKeterlambatanValue.Name = "LblKeterlambatanValue"
        Me.LblKeterlambatanValue.Size = New System.Drawing.Size(380, 23)
        Me.LblKeterlambatanValue.TabIndex = 18
        Me.LblKeterlambatanValue.Text = "AA"
        Me.LblKeterlambatanValue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnKonfirmasi
        '
        Me.btnKonfirmasi.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnKonfirmasi.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(114, Byte), Integer), CType(CType(122, Byte), Integer))
        Me.btnKonfirmasi.FlatAppearance.BorderSize = 0
        Me.btnKonfirmasi.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnKonfirmasi.Font = New System.Drawing.Font("Poppins SemiBold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnKonfirmasi.ForeColor = System.Drawing.Color.White
        Me.btnKonfirmasi.Location = New System.Drawing.Point(32, 422)
        Me.btnKonfirmasi.Name = "btnKonfirmasi"
        Me.btnKonfirmasi.Size = New System.Drawing.Size(316, 30)
        Me.btnKonfirmasi.TabIndex = 1
        Me.btnKonfirmasi.Text = "Konfirmasi Pengembalian"
        Me.btnKonfirmasi.UseVisualStyleBackColor = False
        '
        'PengembalianBarang
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(252, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(380, 484)
        Me.Controls.Add(Me.btnKonfirmasi)
        Me.Controls.Add(Me.LblKeterlambatanValue)
        Me.Controls.Add(Me.LblKeterlambatan)
        Me.Controls.Add(Me.LblNamaLockerValue)
        Me.Controls.Add(Me.LblLocker)
        Me.Controls.Add(Me.LblNoSewaValue)
        Me.Controls.Add(Me.LblSewa)
        Me.Controls.Add(Me.LblDendaValue)
        Me.Controls.Add(Me.LblDenda)
        Me.Controls.Add(Me.titleLbl)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "PengembalianBarang"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents LblDendaValue As Label
    Friend WithEvents LblDenda As Label
    Friend WithEvents titleLbl As Label
    Friend WithEvents LblSewa As Label
    Friend WithEvents LblNoSewaValue As Label
    Friend WithEvents LblLocker As Label
    Friend WithEvents LblNamaLockerValue As Label
    Friend WithEvents LblKeterlambatan As Label
    Friend WithEvents LblKeterlambatanValue As Label
    Friend WithEvents btnKonfirmasi As Button
End Class
