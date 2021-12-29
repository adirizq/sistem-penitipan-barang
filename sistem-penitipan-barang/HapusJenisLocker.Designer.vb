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
        Me.LblJenisLockerValue.Font = New System.Drawing.Font("Microsoft Tai Le", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblJenisLockerValue.Location = New System.Drawing.Point(15, 60)
        Me.LblJenisLockerValue.Name = "LblJenisLockerValue"
        Me.LblJenisLockerValue.Size = New System.Drawing.Size(329, 35)
        Me.LblJenisLockerValue.TabIndex = 6
        Me.LblJenisLockerValue.Text = "Nama Locker"
        Me.LblJenisLockerValue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LblAsk
        '
        Me.LblAsk.AutoSize = True
        Me.LblAsk.Font = New System.Drawing.Font("Microsoft Tai Le", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblAsk.Location = New System.Drawing.Point(28, 24)
        Me.LblAsk.Name = "LblAsk"
        Me.LblAsk.Size = New System.Drawing.Size(290, 16)
        Me.LblAsk.TabIndex = 23
        Me.LblAsk.Text = "Apakah anda yakin akan menghapus jenis loker :"
        '
        'BtnHapus
        '
        Me.BtnHapus.Font = New System.Drawing.Font("Microsoft Tai Le", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnHapus.Location = New System.Drawing.Point(38, 147)
        Me.BtnHapus.Name = "BtnHapus"
        Me.BtnHapus.Size = New System.Drawing.Size(119, 28)
        Me.BtnHapus.TabIndex = 24
        Me.BtnHapus.Text = "Hapus"
        Me.BtnHapus.UseVisualStyleBackColor = True
        '
        'BtnKembali
        '
        Me.BtnKembali.Font = New System.Drawing.Font("Microsoft Tai Le", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnKembali.Location = New System.Drawing.Point(195, 147)
        Me.BtnKembali.Name = "BtnKembali"
        Me.BtnKembali.Size = New System.Drawing.Size(119, 28)
        Me.BtnKembali.TabIndex = 25
        Me.BtnKembali.Text = "Kembali"
        Me.BtnKembali.UseVisualStyleBackColor = True
        '
        'LblBiayaValue
        '
        Me.LblBiayaValue.Font = New System.Drawing.Font("Microsoft Tai Le", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblBiayaValue.Location = New System.Drawing.Point(12, 98)
        Me.LblBiayaValue.Name = "LblBiayaValue"
        Me.LblBiayaValue.Size = New System.Drawing.Size(332, 16)
        Me.LblBiayaValue.TabIndex = 23
        Me.LblBiayaValue.Text = "Biaya"
        Me.LblBiayaValue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'HapusJenisLocker
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(356, 210)
        Me.Controls.Add(Me.BtnKembali)
        Me.Controls.Add(Me.BtnHapus)
        Me.Controls.Add(Me.LblBiayaValue)
        Me.Controls.Add(Me.LblAsk)
        Me.Controls.Add(Me.LblJenisLockerValue)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(372, 249)
        Me.MinimumSize = New System.Drawing.Size(372, 249)
        Me.Name = "HapusJenisLocker"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Hapus Jenis Locker"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LblJenisLockerValue As Label
    Friend WithEvents LblAsk As Label
    Friend WithEvents BtnHapus As Button
    Friend WithEvents BtnKembali As Button
    Friend WithEvents LblBiayaValue As Label
End Class
