<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class EditLocker
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
        Me.LblLockerIdTitle = New System.Windows.Forms.Label()
        Me.CBUkuran = New System.Windows.Forms.ComboBox()
        Me.LblUkuran = New System.Windows.Forms.Label()
        Me.LblBiaya = New System.Windows.Forms.Label()
        Me.LblBiayaValue = New System.Windows.Forms.Label()
        Me.LblLokasi = New System.Windows.Forms.Label()
        Me.TxtLokasi = New System.Windows.Forms.TextBox()
        Me.BtnUpdateLocker = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'titleLbl
        '
        Me.titleLbl.AutoSize = True
        Me.titleLbl.Font = New System.Drawing.Font("Microsoft Tai Le", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.titleLbl.Location = New System.Drawing.Point(20, 20)
        Me.titleLbl.MaximumSize = New System.Drawing.Size(100, 34)
        Me.titleLbl.MinimumSize = New System.Drawing.Size(100, 34)
        Me.titleLbl.Name = "titleLbl"
        Me.titleLbl.Size = New System.Drawing.Size(100, 34)
        Me.titleLbl.TabIndex = 0
        Me.titleLbl.Text = "Locker"
        '
        'LblLockerIdTitle
        '
        Me.LblLockerIdTitle.AutoSize = True
        Me.LblLockerIdTitle.Font = New System.Drawing.Font("Microsoft Tai Le", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblLockerIdTitle.Location = New System.Drawing.Point(123, 20)
        Me.LblLockerIdTitle.Margin = New System.Windows.Forms.Padding(0)
        Me.LblLockerIdTitle.MaximumSize = New System.Drawing.Size(100, 34)
        Me.LblLockerIdTitle.MinimumSize = New System.Drawing.Size(100, 34)
        Me.LblLockerIdTitle.Name = "LblLockerIdTitle"
        Me.LblLockerIdTitle.Size = New System.Drawing.Size(100, 34)
        Me.LblLockerIdTitle.TabIndex = 0
        Me.LblLockerIdTitle.Text = "1"
        '
        'CBUkuran
        '
        Me.CBUkuran.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CBUkuran.Font = New System.Drawing.Font("Microsoft Tai Le", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CBUkuran.FormattingEnabled = True
        Me.CBUkuran.Location = New System.Drawing.Point(124, 77)
        Me.CBUkuran.Name = "CBUkuran"
        Me.CBUkuran.Size = New System.Drawing.Size(212, 24)
        Me.CBUkuran.TabIndex = 1
        '
        'LblUkuran
        '
        Me.LblUkuran.AutoSize = True
        Me.LblUkuran.Font = New System.Drawing.Font("Microsoft Tai Le", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblUkuran.Location = New System.Drawing.Point(23, 80)
        Me.LblUkuran.Name = "LblUkuran"
        Me.LblUkuran.Size = New System.Drawing.Size(49, 16)
        Me.LblUkuran.TabIndex = 7
        Me.LblUkuran.Text = "Ukuran"
        '
        'LblBiaya
        '
        Me.LblBiaya.AutoSize = True
        Me.LblBiaya.Font = New System.Drawing.Font("Microsoft Tai Le", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblBiaya.Location = New System.Drawing.Point(23, 120)
        Me.LblBiaya.Name = "LblBiaya"
        Me.LblBiaya.Size = New System.Drawing.Size(38, 16)
        Me.LblBiaya.TabIndex = 7
        Me.LblBiaya.Text = "Biaya"
        '
        'LblBiayaValue
        '
        Me.LblBiayaValue.AutoSize = True
        Me.LblBiayaValue.Font = New System.Drawing.Font("Microsoft Tai Le", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblBiayaValue.Location = New System.Drawing.Point(120, 117)
        Me.LblBiayaValue.Name = "LblBiayaValue"
        Me.LblBiayaValue.Size = New System.Drawing.Size(55, 21)
        Me.LblBiayaValue.TabIndex = 7
        Me.LblBiayaValue.Text = "10000"
        '
        'LblLokasi
        '
        Me.LblLokasi.AutoSize = True
        Me.LblLokasi.Font = New System.Drawing.Font("Microsoft Tai Le", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblLokasi.Location = New System.Drawing.Point(23, 160)
        Me.LblLokasi.Name = "LblLokasi"
        Me.LblLokasi.Size = New System.Drawing.Size(44, 16)
        Me.LblLokasi.TabIndex = 7
        Me.LblLokasi.Text = "Lokasi"
        '
        'TxtLokasi
        '
        Me.TxtLokasi.Font = New System.Drawing.Font("Microsoft Tai Le", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtLokasi.Location = New System.Drawing.Point(124, 157)
        Me.TxtLokasi.Name = "TxtLokasi"
        Me.TxtLokasi.Size = New System.Drawing.Size(212, 24)
        Me.TxtLokasi.TabIndex = 2
        '
        'BtnUpdateLocker
        '
        Me.BtnUpdateLocker.Font = New System.Drawing.Font("Microsoft Tai Le", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnUpdateLocker.Location = New System.Drawing.Point(217, 208)
        Me.BtnUpdateLocker.Name = "BtnUpdateLocker"
        Me.BtnUpdateLocker.Size = New System.Drawing.Size(119, 28)
        Me.BtnUpdateLocker.TabIndex = 3
        Me.BtnUpdateLocker.Text = "Update Locker"
        Me.BtnUpdateLocker.UseVisualStyleBackColor = True
        '
        'EditLocker
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(369, 268)
        Me.Controls.Add(Me.BtnUpdateLocker)
        Me.Controls.Add(Me.TxtLokasi)
        Me.Controls.Add(Me.CBUkuran)
        Me.Controls.Add(Me.LblBiayaValue)
        Me.Controls.Add(Me.LblLokasi)
        Me.Controls.Add(Me.LblBiaya)
        Me.Controls.Add(Me.LblUkuran)
        Me.Controls.Add(Me.LblLockerIdTitle)
        Me.Controls.Add(Me.titleLbl)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(385, 307)
        Me.MinimumSize = New System.Drawing.Size(385, 307)
        Me.Name = "EditLocker"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Edit Locker"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents titleLbl As Label
    Friend WithEvents LblLockerIdTitle As Label
    Friend WithEvents CBUkuran As ComboBox
    Friend WithEvents LblUkuran As Label
    Friend WithEvents LblBiaya As Label
    Friend WithEvents LblBiayaValue As Label
    Friend WithEvents LblLokasi As Label
    Friend WithEvents TxtLokasi As TextBox
    Friend WithEvents BtnUpdateLocker As Button
End Class
