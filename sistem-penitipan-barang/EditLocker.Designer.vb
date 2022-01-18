<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class EditLocker
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
        Me.CBUkuran = New System.Windows.Forms.ComboBox()
        Me.LblBiayaValue = New System.Windows.Forms.Label()
        Me.TxtNama = New System.Windows.Forms.TextBox()
        Me.BtnUpdateLocker = New System.Windows.Forms.Button()
        Me.titleLbl = New System.Windows.Forms.Label()
        Me.TxtLokasi = New System.Windows.Forms.TextBox()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.LabelUkuran = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.LblBiayaSewa = New System.Windows.Forms.Label()
        Me.Panel3.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
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
        Me.CBUkuran.Name = "CBUkuran"
        Me.CBUkuran.Size = New System.Drawing.Size(256, 31)
        Me.CBUkuran.TabIndex = 1
        '
        'LblBiayaValue
        '
        Me.LblBiayaValue.Font = New System.Drawing.Font("Poppins", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblBiayaValue.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(114, Byte), Integer), CType(CType(122, Byte), Integer))
        Me.LblBiayaValue.Location = New System.Drawing.Point(0, 367)
        Me.LblBiayaValue.Name = "LblBiayaValue"
        Me.LblBiayaValue.Size = New System.Drawing.Size(360, 34)
        Me.LblBiayaValue.TabIndex = 7
        Me.LblBiayaValue.Text = "10000"
        Me.LblBiayaValue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TxtNama
        '
        Me.TxtNama.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.TxtNama.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxtNama.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TxtNama.Font = New System.Drawing.Font("Poppins", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtNama.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(114, Byte), Integer), CType(CType(122, Byte), Integer))
        Me.TxtNama.Location = New System.Drawing.Point(20, 10)
        Me.TxtNama.Name = "TxtNama"
        Me.TxtNama.Size = New System.Drawing.Size(256, 20)
        Me.TxtNama.TabIndex = 2
        '
        'BtnUpdateLocker
        '
        Me.BtnUpdateLocker.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(114, Byte), Integer), CType(CType(122, Byte), Integer))
        Me.BtnUpdateLocker.FlatAppearance.BorderSize = 0
        Me.BtnUpdateLocker.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnUpdateLocker.Font = New System.Drawing.Font("Poppins SemiBold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnUpdateLocker.ForeColor = System.Drawing.Color.White
        Me.BtnUpdateLocker.Location = New System.Drawing.Point(32, 432)
        Me.BtnUpdateLocker.Name = "BtnUpdateLocker"
        Me.BtnUpdateLocker.Size = New System.Drawing.Size(296, 32)
        Me.BtnUpdateLocker.TabIndex = 4
        Me.BtnUpdateLocker.Text = "Update Locker"
        Me.BtnUpdateLocker.UseVisualStyleBackColor = False
        '
        'titleLbl
        '
        Me.titleLbl.Dock = System.Windows.Forms.DockStyle.Top
        Me.titleLbl.Font = New System.Drawing.Font("Poppins", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.titleLbl.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(114, Byte), Integer), CType(CType(122, Byte), Integer))
        Me.titleLbl.Location = New System.Drawing.Point(0, 0)
        Me.titleLbl.Name = "titleLbl"
        Me.titleLbl.Padding = New System.Windows.Forms.Padding(0, 32, 0, 0)
        Me.titleLbl.Size = New System.Drawing.Size(360, 68)
        Me.titleLbl.TabIndex = 0
        Me.titleLbl.Text = "Locker"
        Me.titleLbl.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'TxtLokasi
        '
        Me.TxtLokasi.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.TxtLokasi.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxtLokasi.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TxtLokasi.Font = New System.Drawing.Font("Poppins", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtLokasi.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(114, Byte), Integer), CType(CType(122, Byte), Integer))
        Me.TxtLokasi.Location = New System.Drawing.Point(20, 10)
        Me.TxtLokasi.Name = "TxtLokasi"
        Me.TxtLokasi.Size = New System.Drawing.Size(256, 20)
        Me.TxtLokasi.TabIndex = 3
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Panel3.Controls.Add(Me.CBUkuran)
        Me.Panel3.Location = New System.Drawing.Point(32, 111)
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
        Me.Label2.Location = New System.Drawing.Point(28, 174)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(50, 23)
        Me.Label2.TabIndex = 27
        Me.Label2.Text = "Nama"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Panel2.Controls.Add(Me.TxtNama)
        Me.Panel2.Location = New System.Drawing.Point(32, 200)
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
        Me.LabelUkuran.Location = New System.Drawing.Point(28, 85)
        Me.LabelUkuran.Name = "LabelUkuran"
        Me.LabelUkuran.Size = New System.Drawing.Size(56, 23)
        Me.LabelUkuran.TabIndex = 24
        Me.LabelUkuran.Text = "Ukuran"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Panel1.Controls.Add(Me.TxtLokasi)
        Me.Panel1.Location = New System.Drawing.Point(32, 278)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Padding = New System.Windows.Forms.Padding(20, 10, 20, 10)
        Me.Panel1.Size = New System.Drawing.Size(296, 40)
        Me.Panel1.TabIndex = 25
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Poppins", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(114, Byte), Integer), CType(CType(122, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(28, 252)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(50, 23)
        Me.Label1.TabIndex = 27
        Me.Label1.Text = "Lokasi"
        '
        'LblBiayaSewa
        '
        Me.LblBiayaSewa.Font = New System.Drawing.Font("Poppins", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblBiayaSewa.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(114, Byte), Integer), CType(CType(122, Byte), Integer))
        Me.LblBiayaSewa.Location = New System.Drawing.Point(0, 342)
        Me.LblBiayaSewa.Name = "LblBiayaSewa"
        Me.LblBiayaSewa.Size = New System.Drawing.Size(360, 19)
        Me.LblBiayaSewa.TabIndex = 28
        Me.LblBiayaSewa.Text = "Biaya Sewa Perjam"
        Me.LblBiayaSewa.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'EditLocker
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(252, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(360, 494)
        Me.Controls.Add(Me.LblBiayaSewa)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.LabelUkuran)
        Me.Controls.Add(Me.BtnUpdateLocker)
        Me.Controls.Add(Me.LblBiayaValue)
        Me.Controls.Add(Me.titleLbl)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "EditLocker"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Panel3.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents CBUkuran As ComboBox
    Friend WithEvents LblBiayaValue As Label
    Friend WithEvents TxtNama As TextBox
    Friend WithEvents BtnUpdateLocker As Button
    Friend WithEvents titleLbl As Label
    Friend WithEvents TxtLokasi As TextBox
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents LabelUkuran As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents LblBiayaSewa As Label
End Class
