<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class AddSewa
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
        Me.titleLbl = New System.Windows.Forms.Label()
        Me.CBUkuran = New System.Windows.Forms.ComboBox()
        Me.TxtLamaSewa = New System.Windows.Forms.TextBox()
        Me.CBLocker = New System.Windows.Forms.ComboBox()
        Me.LblBiayaSewa = New System.Windows.Forms.Label()
        Me.LblBiayaSewaValue = New System.Windows.Forms.Label()
        Me.LblWarn = New System.Windows.Forms.Label()
        Me.btnTambah = New System.Windows.Forms.Button()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.LabelUkuran = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Panel3.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'titleLbl
        '
        Me.titleLbl.Dock = System.Windows.Forms.DockStyle.Top
        Me.titleLbl.Font = New System.Drawing.Font("Poppins", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.titleLbl.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(114, Byte), Integer), CType(CType(122, Byte), Integer))
        Me.titleLbl.Location = New System.Drawing.Point(0, 0)
        Me.titleLbl.Name = "titleLbl"
        Me.titleLbl.Padding = New System.Windows.Forms.Padding(0, 32, 0, 0)
        Me.titleLbl.Size = New System.Drawing.Size(380, 62)
        Me.titleLbl.TabIndex = 0
        Me.titleLbl.Text = "Tambah Data Sewa"
        Me.titleLbl.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'CBUkuran
        '
        Me.CBUkuran.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.CBUkuran.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CBUkuran.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CBUkuran.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CBUkuran.Font = New System.Drawing.Font("Poppins", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CBUkuran.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(114, Byte), Integer), CType(CType(122, Byte), Integer))
        Me.CBUkuran.FormattingEnabled = True
        Me.CBUkuran.Location = New System.Drawing.Point(20, 10)
        Me.CBUkuran.Margin = New System.Windows.Forms.Padding(0)
        Me.CBUkuran.Name = "CBUkuran"
        Me.CBUkuran.Size = New System.Drawing.Size(256, 31)
        Me.CBUkuran.TabIndex = 1
        '
        'TxtLamaSewa
        '
        Me.TxtLamaSewa.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.TxtLamaSewa.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxtLamaSewa.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TxtLamaSewa.Font = New System.Drawing.Font("Poppins", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtLamaSewa.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(114, Byte), Integer), CType(CType(122, Byte), Integer))
        Me.TxtLamaSewa.Location = New System.Drawing.Point(20, 10)
        Me.TxtLamaSewa.MaxLength = 4
        Me.TxtLamaSewa.Name = "TxtLamaSewa"
        Me.TxtLamaSewa.Size = New System.Drawing.Size(256, 20)
        Me.TxtLamaSewa.TabIndex = 3
        '
        'CBLocker
        '
        Me.CBLocker.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.CBLocker.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CBLocker.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CBLocker.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CBLocker.Font = New System.Drawing.Font("Poppins", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CBLocker.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(114, Byte), Integer), CType(CType(122, Byte), Integer))
        Me.CBLocker.FormattingEnabled = True
        Me.CBLocker.Location = New System.Drawing.Point(20, 10)
        Me.CBLocker.Margin = New System.Windows.Forms.Padding(0)
        Me.CBLocker.Name = "CBLocker"
        Me.CBLocker.Size = New System.Drawing.Size(256, 31)
        Me.CBLocker.TabIndex = 2
        '
        'LblBiayaSewa
        '
        Me.LblBiayaSewa.Font = New System.Drawing.Font("Poppins", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblBiayaSewa.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(114, Byte), Integer), CType(CType(122, Byte), Integer))
        Me.LblBiayaSewa.Location = New System.Drawing.Point(0, 363)
        Me.LblBiayaSewa.Name = "LblBiayaSewa"
        Me.LblBiayaSewa.Size = New System.Drawing.Size(380, 20)
        Me.LblBiayaSewa.TabIndex = 11
        Me.LblBiayaSewa.Text = "Biaya Sewa"
        Me.LblBiayaSewa.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LblBiayaSewaValue
        '
        Me.LblBiayaSewaValue.Font = New System.Drawing.Font("Poppins", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblBiayaSewaValue.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(114, Byte), Integer), CType(CType(122, Byte), Integer))
        Me.LblBiayaSewaValue.Location = New System.Drawing.Point(0, 381)
        Me.LblBiayaSewaValue.Name = "LblBiayaSewaValue"
        Me.LblBiayaSewaValue.Size = New System.Drawing.Size(380, 37)
        Me.LblBiayaSewaValue.TabIndex = 11
        Me.LblBiayaSewaValue.Text = "Rp.0"
        Me.LblBiayaSewaValue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LblWarn
        '
        Me.LblWarn.Font = New System.Drawing.Font("Poppins", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblWarn.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(114, Byte), Integer), CType(CType(122, Byte), Integer))
        Me.LblWarn.Location = New System.Drawing.Point(0, 418)
        Me.LblWarn.Name = "LblWarn"
        Me.LblWarn.Padding = New System.Windows.Forms.Padding(32, 0, 32, 0)
        Me.LblWarn.Size = New System.Drawing.Size(380, 32)
        Me.LblWarn.TabIndex = 11
        Me.LblWarn.Text = "*Tidak termasuk denda keterlambatan pengambilan barang"
        Me.LblWarn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnTambah
        '
        Me.btnTambah.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(114, Byte), Integer), CType(CType(122, Byte), Integer))
        Me.btnTambah.FlatAppearance.BorderSize = 0
        Me.btnTambah.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnTambah.Font = New System.Drawing.Font("Poppins SemiBold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnTambah.ForeColor = System.Drawing.Color.White
        Me.btnTambah.Location = New System.Drawing.Point(32, 482)
        Me.btnTambah.Name = "btnTambah"
        Me.btnTambah.Size = New System.Drawing.Size(316, 30)
        Me.btnTambah.TabIndex = 4
        Me.btnTambah.Text = "Tambah"
        Me.btnTambah.UseVisualStyleBackColor = False
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Panel3.Controls.Add(Me.CBUkuran)
        Me.Panel3.Location = New System.Drawing.Point(44, 111)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Padding = New System.Windows.Forms.Padding(20, 10, 20, 10)
        Me.Panel3.Size = New System.Drawing.Size(296, 51)
        Me.Panel3.TabIndex = 26
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Poppins", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(114, Byte), Integer), CType(CType(122, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(40, 269)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(86, 23)
        Me.Label2.TabIndex = 27
        Me.Label2.Text = "Lama Sewa"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Panel2.Controls.Add(Me.Label3)
        Me.Panel2.Controls.Add(Me.TxtLamaSewa)
        Me.Panel2.Location = New System.Drawing.Point(44, 295)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Padding = New System.Windows.Forms.Padding(20, 10, 20, 10)
        Me.Panel2.Size = New System.Drawing.Size(296, 40)
        Me.Panel2.TabIndex = 25
        '
        'LabelUkuran
        '
        Me.LabelUkuran.AutoSize = True
        Me.LabelUkuran.Font = New System.Drawing.Font("Poppins", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelUkuran.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(114, Byte), Integer), CType(CType(122, Byte), Integer))
        Me.LabelUkuran.Location = New System.Drawing.Point(40, 85)
        Me.LabelUkuran.Name = "LabelUkuran"
        Me.LabelUkuran.Size = New System.Drawing.Size(56, 23)
        Me.LabelUkuran.TabIndex = 24
        Me.LabelUkuran.Text = "Ukuran"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Panel1.Controls.Add(Me.CBLocker)
        Me.Panel1.Location = New System.Drawing.Point(44, 203)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Padding = New System.Windows.Forms.Padding(20, 10, 20, 10)
        Me.Panel1.Size = New System.Drawing.Size(296, 51)
        Me.Panel1.TabIndex = 28
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Poppins", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(114, Byte), Integer), CType(CType(122, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(40, 177)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(52, 23)
        Me.Label1.TabIndex = 27
        Me.Label1.Text = "Locker"
        '
        'Label3
        '
        Me.Label3.Dock = System.Windows.Forms.DockStyle.Right
        Me.Label3.Font = New System.Drawing.Font("Poppins", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(114, Byte), Integer), CType(CType(122, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(235, 10)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(41, 20)
        Me.Label3.TabIndex = 29
        Me.Label3.Text = "Jam"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'AddSewa
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(252, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(380, 544)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.LabelUkuran)
        Me.Controls.Add(Me.btnTambah)
        Me.Controls.Add(Me.LblBiayaSewaValue)
        Me.Controls.Add(Me.LblWarn)
        Me.Controls.Add(Me.LblBiayaSewa)
        Me.Controls.Add(Me.titleLbl)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "AddSewa"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Panel3.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents titleLbl As Label
    Friend WithEvents CBUkuran As ComboBox
    Friend WithEvents TxtLamaSewa As TextBox
    Friend WithEvents CBLocker As ComboBox
    Friend WithEvents LblBiayaSewa As Label
    Friend WithEvents LblBiayaSewaValue As Label
    Friend WithEvents LblWarn As Label
    Friend WithEvents btnTambah As Button
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents LabelUkuran As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents Label3 As Label
End Class
