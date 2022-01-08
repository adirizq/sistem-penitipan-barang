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
        Me.BtnKembali.Font = New System.Drawing.Font("Microsoft Tai Le", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnKembali.Location = New System.Drawing.Point(195, 151)
        Me.BtnKembali.Name = "BtnKembali"
        Me.BtnKembali.Size = New System.Drawing.Size(119, 28)
        Me.BtnKembali.TabIndex = 30
        Me.BtnKembali.Text = "Kembali"
        Me.BtnKembali.UseVisualStyleBackColor = True
        '
        'BtnHapus
        '
        Me.BtnHapus.Font = New System.Drawing.Font("Microsoft Tai Le", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnHapus.Location = New System.Drawing.Point(38, 151)
        Me.BtnHapus.Name = "BtnHapus"
        Me.BtnHapus.Size = New System.Drawing.Size(119, 28)
        Me.BtnHapus.TabIndex = 29
        Me.BtnHapus.Text = "Hapus"
        Me.BtnHapus.UseVisualStyleBackColor = True
        '
        'LblIDValue
        '
        Me.LblIDValue.Font = New System.Drawing.Font("Microsoft Tai Le", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblIDValue.Location = New System.Drawing.Point(12, 102)
        Me.LblIDValue.Name = "LblIDValue"
        Me.LblIDValue.Size = New System.Drawing.Size(332, 16)
        Me.LblIDValue.TabIndex = 27
        Me.LblIDValue.Text = "Biaya"
        Me.LblIDValue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LblAsk
        '
        Me.LblAsk.AutoSize = True
        Me.LblAsk.Font = New System.Drawing.Font("Microsoft Tai Le", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblAsk.Location = New System.Drawing.Point(28, 28)
        Me.LblAsk.Name = "LblAsk"
        Me.LblAsk.Size = New System.Drawing.Size(290, 16)
        Me.LblAsk.TabIndex = 28
        Me.LblAsk.Text = "Apakah anda yakin akan menghapus jenis loker :"
        '
        'LblLockerValue
        '
        Me.LblLockerValue.Font = New System.Drawing.Font("Microsoft Tai Le", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblLockerValue.Location = New System.Drawing.Point(15, 64)
        Me.LblLockerValue.Name = "LblLockerValue"
        Me.LblLockerValue.Size = New System.Drawing.Size(329, 35)
        Me.LblLockerValue.TabIndex = 26
        Me.LblLockerValue.Text = "Nama Locker"
        Me.LblLockerValue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'HapusLocker
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(356, 210)
        Me.Controls.Add(Me.BtnKembali)
        Me.Controls.Add(Me.BtnHapus)
        Me.Controls.Add(Me.LblIDValue)
        Me.Controls.Add(Me.LblAsk)
        Me.Controls.Add(Me.LblLockerValue)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(372, 249)
        Me.MinimumSize = New System.Drawing.Size(372, 249)
        Me.Name = "HapusLocker"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Hapus Locker"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BtnKembali As Button
    Friend WithEvents BtnHapus As Button
    Friend WithEvents LblIDValue As Label
    Friend WithEvents LblAsk As Label
    Friend WithEvents LblLockerValue As Label
End Class
