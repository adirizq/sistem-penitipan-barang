<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class HapusLocker
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
        Me.BtnKembali = New System.Windows.Forms.Button()
        Me.BtnHapus = New System.Windows.Forms.Button()
        Me.LblIDValue = New System.Windows.Forms.Label()
        Me.LblAsk = New System.Windows.Forms.Label()
        Me.LblLockerValue = New System.Windows.Forms.Label()
        Me.SuspendLayout()
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
        Me.BtnKembali.TabIndex = 30
        Me.BtnKembali.Text = "Kembali"
        Me.BtnKembali.UseVisualStyleBackColor = True
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
        Me.BtnHapus.TabIndex = 29
        Me.BtnHapus.Text = "Hapus"
        Me.BtnHapus.UseVisualStyleBackColor = False
        '
        'LblIDValue
        '
        Me.LblIDValue.Font = New System.Drawing.Font("Poppins", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblIDValue.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(114, Byte), Integer), CType(CType(122, Byte), Integer))
        Me.LblIDValue.Location = New System.Drawing.Point(0, 128)
        Me.LblIDValue.Name = "LblIDValue"
        Me.LblIDValue.Size = New System.Drawing.Size(360, 21)
        Me.LblIDValue.TabIndex = 27
        Me.LblIDValue.Text = "Biaya"
        Me.LblIDValue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LblAsk
        '
        Me.LblAsk.Dock = System.Windows.Forms.DockStyle.Top
        Me.LblAsk.Font = New System.Drawing.Font("Poppins", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblAsk.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(114, Byte), Integer), CType(CType(122, Byte), Integer))
        Me.LblAsk.Location = New System.Drawing.Point(0, 0)
        Me.LblAsk.Name = "LblAsk"
        Me.LblAsk.Padding = New System.Windows.Forms.Padding(0, 32, 0, 0)
        Me.LblAsk.Size = New System.Drawing.Size(360, 64)
        Me.LblAsk.TabIndex = 28
        Me.LblAsk.Text = "Apakah anda yakin menghapus loker :"
        Me.LblAsk.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'LblLockerValue
        '
        Me.LblLockerValue.Font = New System.Drawing.Font("Poppins", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblLockerValue.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(114, Byte), Integer), CType(CType(122, Byte), Integer))
        Me.LblLockerValue.Location = New System.Drawing.Point(0, 87)
        Me.LblLockerValue.Name = "LblLockerValue"
        Me.LblLockerValue.Size = New System.Drawing.Size(360, 55)
        Me.LblLockerValue.TabIndex = 26
        Me.LblLockerValue.Text = "Nama Locker"
        Me.LblLockerValue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'HapusLocker
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(252, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(360, 300)
        Me.Controls.Add(Me.BtnKembali)
        Me.Controls.Add(Me.BtnHapus)
        Me.Controls.Add(Me.LblIDValue)
        Me.Controls.Add(Me.LblAsk)
        Me.Controls.Add(Me.LblLockerValue)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "HapusLocker"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents BtnKembali As Button
    Friend WithEvents BtnHapus As Button
    Friend WithEvents LblIDValue As Label
    Friend WithEvents LblAsk As Label
    Friend WithEvents LblLockerValue As Label
End Class
