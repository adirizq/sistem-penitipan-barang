<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UpdateJenisLocker
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.BtnUpdateLocker = New System.Windows.Forms.Button()
        Me.TxtBiaya = New System.Windows.Forms.TextBox()
        Me.LblBiaya = New System.Windows.Forms.Label()
        Me.LblUkuran = New System.Windows.Forms.Label()
        Me.txtUkuran = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft YaHei UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.MaximumSize = New System.Drawing.Size(204, 26)
        Me.Label1.MinimumSize = New System.Drawing.Size(204, 26)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(204, 26)
        Me.Label1.TabIndex = 23
        Me.Label1.Text = "Update Jenis Locker"
        '
        'BtnUpdateLocker
        '
        Me.BtnUpdateLocker.Font = New System.Drawing.Font("Microsoft Tai Le", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnUpdateLocker.Location = New System.Drawing.Point(209, 142)
        Me.BtnUpdateLocker.Name = "BtnUpdateLocker"
        Me.BtnUpdateLocker.Size = New System.Drawing.Size(119, 28)
        Me.BtnUpdateLocker.TabIndex = 3
        Me.BtnUpdateLocker.Text = "Update Locker"
        Me.BtnUpdateLocker.UseVisualStyleBackColor = True
        '
        'TxtBiaya
        '
        Me.TxtBiaya.Font = New System.Drawing.Font("Microsoft Tai Le", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtBiaya.Location = New System.Drawing.Point(116, 92)
        Me.TxtBiaya.Name = "TxtBiaya"
        Me.TxtBiaya.Size = New System.Drawing.Size(212, 24)
        Me.TxtBiaya.TabIndex = 2
        '
        'LblBiaya
        '
        Me.LblBiaya.AutoSize = True
        Me.LblBiaya.Font = New System.Drawing.Font("Microsoft Tai Le", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblBiaya.Location = New System.Drawing.Point(15, 95)
        Me.LblBiaya.Name = "LblBiaya"
        Me.LblBiaya.Size = New System.Drawing.Size(38, 16)
        Me.LblBiaya.TabIndex = 21
        Me.LblBiaya.Text = "Biaya"
        '
        'LblUkuran
        '
        Me.LblUkuran.AutoSize = True
        Me.LblUkuran.Font = New System.Drawing.Font("Microsoft Tai Le", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblUkuran.Location = New System.Drawing.Point(15, 55)
        Me.LblUkuran.Name = "LblUkuran"
        Me.LblUkuran.Size = New System.Drawing.Size(49, 16)
        Me.LblUkuran.TabIndex = 22
        Me.LblUkuran.Text = "Ukuran"
        '
        'txtUkuran
        '
        Me.txtUkuran.Font = New System.Drawing.Font("Microsoft Tai Le", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUkuran.Location = New System.Drawing.Point(116, 52)
        Me.txtUkuran.Name = "txtUkuran"
        Me.txtUkuran.Size = New System.Drawing.Size(212, 24)
        Me.txtUkuran.TabIndex = 1
        '
        'UpdateJenisLocker
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(340, 181)
        Me.Controls.Add(Me.txtUkuran)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.BtnUpdateLocker)
        Me.Controls.Add(Me.TxtBiaya)
        Me.Controls.Add(Me.LblBiaya)
        Me.Controls.Add(Me.LblUkuran)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(356, 220)
        Me.MinimumSize = New System.Drawing.Size(356, 220)
        Me.Name = "UpdateJenisLocker"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Update Jenis Locker"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents BtnUpdateLocker As Button
    Friend WithEvents TxtBiaya As TextBox
    Friend WithEvents LblBiaya As Label
    Friend WithEvents LblUkuran As Label
    Friend WithEvents txtUkuran As TextBox
End Class
