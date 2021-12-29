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
        Me.LblNoLockerValue = New System.Windows.Forms.Label()
        Me.LblKeterlambatan = New System.Windows.Forms.Label()
        Me.LblKeterlambatanValue = New System.Windows.Forms.Label()
        Me.btnKonfirmasi = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'LblDendaValue
        '
        Me.LblDendaValue.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LblDendaValue.Font = New System.Drawing.Font("Microsoft Tai Le", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblDendaValue.ForeColor = System.Drawing.Color.Firebrick
        Me.LblDendaValue.Location = New System.Drawing.Point(0, 305)
        Me.LblDendaValue.MaximumSize = New System.Drawing.Size(373, 31)
        Me.LblDendaValue.MinimumSize = New System.Drawing.Size(373, 31)
        Me.LblDendaValue.Name = "LblDendaValue"
        Me.LblDendaValue.Size = New System.Drawing.Size(373, 31)
        Me.LblDendaValue.TabIndex = 16
        Me.LblDendaValue.Text = "Rp.100000"
        Me.LblDendaValue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LblDenda
        '
        Me.LblDenda.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LblDenda.Font = New System.Drawing.Font("Microsoft Tai Le", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblDenda.Location = New System.Drawing.Point(0, 282)
        Me.LblDenda.MaximumSize = New System.Drawing.Size(373, 16)
        Me.LblDenda.MinimumSize = New System.Drawing.Size(373, 16)
        Me.LblDenda.Name = "LblDenda"
        Me.LblDenda.Size = New System.Drawing.Size(373, 16)
        Me.LblDenda.TabIndex = 17
        Me.LblDenda.Text = "Denda"
        Me.LblDenda.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'titleLbl
        '
        Me.titleLbl.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.titleLbl.Font = New System.Drawing.Font("Microsoft Tai Le", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.titleLbl.Location = New System.Drawing.Point(0, 25)
        Me.titleLbl.Margin = New System.Windows.Forms.Padding(3, 20, 3, 0)
        Me.titleLbl.MaximumSize = New System.Drawing.Size(373, 34)
        Me.titleLbl.MinimumSize = New System.Drawing.Size(373, 34)
        Me.titleLbl.Name = "titleLbl"
        Me.titleLbl.Size = New System.Drawing.Size(373, 34)
        Me.titleLbl.TabIndex = 0
        Me.titleLbl.Text = "Pengembalian Barang"
        Me.titleLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LblSewa
        '
        Me.LblSewa.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LblSewa.Font = New System.Drawing.Font("Microsoft Tai Le", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblSewa.Location = New System.Drawing.Point(0, 98)
        Me.LblSewa.MaximumSize = New System.Drawing.Size(373, 16)
        Me.LblSewa.MinimumSize = New System.Drawing.Size(373, 16)
        Me.LblSewa.Name = "LblSewa"
        Me.LblSewa.Size = New System.Drawing.Size(373, 16)
        Me.LblSewa.TabIndex = 18
        Me.LblSewa.Text = "No Sewa :"
        Me.LblSewa.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LblNoSewaValue
        '
        Me.LblNoSewaValue.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LblNoSewaValue.Font = New System.Drawing.Font("Microsoft Tai Le", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblNoSewaValue.Location = New System.Drawing.Point(0, 118)
        Me.LblNoSewaValue.MaximumSize = New System.Drawing.Size(373, 21)
        Me.LblNoSewaValue.MinimumSize = New System.Drawing.Size(373, 21)
        Me.LblNoSewaValue.Name = "LblNoSewaValue"
        Me.LblNoSewaValue.Size = New System.Drawing.Size(373, 21)
        Me.LblNoSewaValue.TabIndex = 18
        Me.LblNoSewaValue.Text = "1"
        Me.LblNoSewaValue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LblLocker
        '
        Me.LblLocker.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LblLocker.Font = New System.Drawing.Font("Microsoft Tai Le", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblLocker.Location = New System.Drawing.Point(0, 152)
        Me.LblLocker.MaximumSize = New System.Drawing.Size(373, 16)
        Me.LblLocker.MinimumSize = New System.Drawing.Size(373, 16)
        Me.LblLocker.Name = "LblLocker"
        Me.LblLocker.Size = New System.Drawing.Size(373, 16)
        Me.LblLocker.TabIndex = 18
        Me.LblLocker.Text = "No Locker :"
        Me.LblLocker.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LblNoLockerValue
        '
        Me.LblNoLockerValue.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LblNoLockerValue.Font = New System.Drawing.Font("Microsoft Tai Le", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblNoLockerValue.Location = New System.Drawing.Point(0, 173)
        Me.LblNoLockerValue.MaximumSize = New System.Drawing.Size(373, 21)
        Me.LblNoLockerValue.MinimumSize = New System.Drawing.Size(373, 21)
        Me.LblNoLockerValue.Name = "LblNoLockerValue"
        Me.LblNoLockerValue.Size = New System.Drawing.Size(373, 21)
        Me.LblNoLockerValue.TabIndex = 18
        Me.LblNoLockerValue.Text = "1"
        Me.LblNoLockerValue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LblKeterlambatan
        '
        Me.LblKeterlambatan.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LblKeterlambatan.Font = New System.Drawing.Font("Microsoft Tai Le", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblKeterlambatan.Location = New System.Drawing.Point(0, 206)
        Me.LblKeterlambatan.MaximumSize = New System.Drawing.Size(373, 16)
        Me.LblKeterlambatan.MinimumSize = New System.Drawing.Size(373, 16)
        Me.LblKeterlambatan.Name = "LblKeterlambatan"
        Me.LblKeterlambatan.Size = New System.Drawing.Size(373, 16)
        Me.LblKeterlambatan.TabIndex = 18
        Me.LblKeterlambatan.Text = "Keterlambatan :"
        Me.LblKeterlambatan.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LblKeterlambatanValue
        '
        Me.LblKeterlambatanValue.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LblKeterlambatanValue.Font = New System.Drawing.Font("Microsoft Tai Le", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblKeterlambatanValue.Location = New System.Drawing.Point(0, 228)
        Me.LblKeterlambatanValue.MaximumSize = New System.Drawing.Size(373, 21)
        Me.LblKeterlambatanValue.MinimumSize = New System.Drawing.Size(373, 21)
        Me.LblKeterlambatanValue.Name = "LblKeterlambatanValue"
        Me.LblKeterlambatanValue.Size = New System.Drawing.Size(373, 21)
        Me.LblKeterlambatanValue.TabIndex = 18
        Me.LblKeterlambatanValue.Text = "AA"
        Me.LblKeterlambatanValue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnKonfirmasi
        '
        Me.btnKonfirmasi.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnKonfirmasi.Font = New System.Drawing.Font("Microsoft Tai Le", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnKonfirmasi.Location = New System.Drawing.Point(25, 384)
        Me.btnKonfirmasi.MaximumSize = New System.Drawing.Size(323, 28)
        Me.btnKonfirmasi.MinimumSize = New System.Drawing.Size(323, 28)
        Me.btnKonfirmasi.Name = "btnKonfirmasi"
        Me.btnKonfirmasi.Size = New System.Drawing.Size(323, 28)
        Me.btnKonfirmasi.TabIndex = 1
        Me.btnKonfirmasi.Text = "Konfirmasi Pengembalian"
        Me.btnKonfirmasi.UseVisualStyleBackColor = True
        '
        'PengembalianBarang
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(373, 434)
        Me.Controls.Add(Me.btnKonfirmasi)
        Me.Controls.Add(Me.LblKeterlambatanValue)
        Me.Controls.Add(Me.LblKeterlambatan)
        Me.Controls.Add(Me.LblNoLockerValue)
        Me.Controls.Add(Me.LblLocker)
        Me.Controls.Add(Me.LblNoSewaValue)
        Me.Controls.Add(Me.LblSewa)
        Me.Controls.Add(Me.LblDendaValue)
        Me.Controls.Add(Me.LblDenda)
        Me.Controls.Add(Me.titleLbl)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(389, 473)
        Me.MinimumSize = New System.Drawing.Size(389, 473)
        Me.Name = "PengembalianBarang"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Pengembalian Barang"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents LblDendaValue As Label
    Friend WithEvents LblDenda As Label
    Friend WithEvents titleLbl As Label
    Friend WithEvents LblSewa As Label
    Friend WithEvents LblNoSewaValue As Label
    Friend WithEvents LblLocker As Label
    Friend WithEvents LblNoLockerValue As Label
    Friend WithEvents LblKeterlambatan As Label
    Friend WithEvents LblKeterlambatanValue As Label
    Friend WithEvents btnKonfirmasi As Button
End Class
