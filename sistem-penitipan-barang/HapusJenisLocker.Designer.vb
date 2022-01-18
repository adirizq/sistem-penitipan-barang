<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class HapusJenisLocker
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
        Me.LblJenisLockerValue = New System.Windows.Forms.Label()
        Me.LblAsk = New System.Windows.Forms.Label()
        Me.BtnHapus = New System.Windows.Forms.Button()
        Me.BtnKembali = New System.Windows.Forms.Button()
        Me.LblBiayaValue = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'LblJenisLockerValue
        '
        Me.LblJenisLockerValue.Font = New System.Drawing.Font("Poppins", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblJenisLockerValue.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(114, Byte), Integer), CType(CType(122, Byte), Integer))
        Me.LblJenisLockerValue.Location = New System.Drawing.Point(0, 87)
        Me.LblJenisLockerValue.Name = "LblJenisLockerValue"
        Me.LblJenisLockerValue.Size = New System.Drawing.Size(360, 55)
        Me.LblJenisLockerValue.TabIndex = 6
        Me.LblJenisLockerValue.Text = "Nama Locker"
        Me.LblJenisLockerValue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LblAsk
        '
        Me.LblAsk.Dock = System.Windows.Forms.DockStyle.Top
        Me.LblAsk.Font = New System.Drawing.Font("Poppins", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblAsk.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(114, Byte), Integer), CType(CType(122, Byte), Integer))
        Me.LblAsk.Location = New System.Drawing.Point(0, 0)
        Me.LblAsk.Name = "LblAsk"
        Me.LblAsk.Padding = New System.Windows.Forms.Padding(32, 32, 32, 0)
        Me.LblAsk.Size = New System.Drawing.Size(360, 55)
        Me.LblAsk.TabIndex = 1
        Me.LblAsk.Text = "Apakah anda yakin menghapus jenis loker :"
        Me.LblAsk.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'BtnHapus
        '
        Me.BtnHapus.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(114, Byte), Integer), CType(CType(122, Byte), Integer))
        Me.BtnHapus.FlatAppearance.BorderSize = 0
        Me.BtnHapus.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnHapus.Font = New System.Drawing.Font("Poppins SemiBold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnHapus.ForeColor = System.Drawing.Color.White
        Me.BtnHapus.Location = New System.Drawing.Point(32, 193)
        Me.BtnHapus.Name = "BtnHapus"
        Me.BtnHapus.Size = New System.Drawing.Size(296, 30)
        Me.BtnHapus.TabIndex = 24
        Me.BtnHapus.Text = "Hapus"
        Me.BtnHapus.UseVisualStyleBackColor = False
        '
        'BtnKembali
        '
        Me.BtnKembali.FlatAppearance.BorderSize = 0
        Me.BtnKembali.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnKembali.Font = New System.Drawing.Font("Poppins SemiBold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnKembali.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(114, Byte), Integer), CType(CType(122, Byte), Integer))
        Me.BtnKembali.Location = New System.Drawing.Point(32, 238)
        Me.BtnKembali.Name = "BtnKembali"
        Me.BtnKembali.Size = New System.Drawing.Size(296, 30)
        Me.BtnKembali.TabIndex = 25
        Me.BtnKembali.Text = "Kembali"
        Me.BtnKembali.UseVisualStyleBackColor = True
        '
        'LblBiayaValue
        '
        Me.LblBiayaValue.Font = New System.Drawing.Font("Poppins", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblBiayaValue.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(114, Byte), Integer), CType(CType(122, Byte), Integer))
        Me.LblBiayaValue.Location = New System.Drawing.Point(0, 128)
        Me.LblBiayaValue.Name = "LblBiayaValue"
        Me.LblBiayaValue.Size = New System.Drawing.Size(360, 21)
        Me.LblBiayaValue.TabIndex = 23
        Me.LblBiayaValue.Text = "Biaya"
        Me.LblBiayaValue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'HapusJenisLocker
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(252, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(360, 300)
        Me.Controls.Add(Me.BtnKembali)
        Me.Controls.Add(Me.BtnHapus)
        Me.Controls.Add(Me.LblBiayaValue)
        Me.Controls.Add(Me.LblAsk)
        Me.Controls.Add(Me.LblJenisLockerValue)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "HapusJenisLocker"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents LblJenisLockerValue As Label
    Friend WithEvents LblAsk As Label
    Friend WithEvents BtnHapus As Button
    Friend WithEvents BtnKembali As Button
    Friend WithEvents LblBiayaValue As Label
End Class
