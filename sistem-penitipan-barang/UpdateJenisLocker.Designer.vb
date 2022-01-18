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
        Me.BtnUpdateLocker = New System.Windows.Forms.Button()
        Me.TxtBiaya = New System.Windows.Forms.TextBox()
        Me.txtUkuran = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.LabelUkuran = New System.Windows.Forms.Label()
        Me.LabelBiaya = New System.Windows.Forms.Label()
        Me.Panel3.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'BtnUpdateLocker
        '
        Me.BtnUpdateLocker.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(114, Byte), Integer), CType(CType(122, Byte), Integer))
        Me.BtnUpdateLocker.FlatAppearance.BorderSize = 0
        Me.BtnUpdateLocker.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnUpdateLocker.Font = New System.Drawing.Font("Poppins SemiBold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnUpdateLocker.ForeColor = System.Drawing.Color.White
        Me.BtnUpdateLocker.Location = New System.Drawing.Point(32, 238)
        Me.BtnUpdateLocker.Name = "BtnUpdateLocker"
        Me.BtnUpdateLocker.Size = New System.Drawing.Size(296, 30)
        Me.BtnUpdateLocker.TabIndex = 3
        Me.BtnUpdateLocker.Text = "Update Jenis Locker"
        Me.BtnUpdateLocker.UseVisualStyleBackColor = False
        '
        'TxtBiaya
        '
        Me.TxtBiaya.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.TxtBiaya.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxtBiaya.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TxtBiaya.Font = New System.Drawing.Font("Poppins", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtBiaya.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(114, Byte), Integer), CType(CType(122, Byte), Integer))
        Me.TxtBiaya.Location = New System.Drawing.Point(20, 10)
        Me.TxtBiaya.Name = "TxtBiaya"
        Me.TxtBiaya.Size = New System.Drawing.Size(256, 20)
        Me.TxtBiaya.TabIndex = 2
        '
        'txtUkuran
        '
        Me.txtUkuran.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txtUkuran.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtUkuran.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtUkuran.Font = New System.Drawing.Font("Poppins", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUkuran.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(114, Byte), Integer), CType(CType(122, Byte), Integer))
        Me.txtUkuran.Location = New System.Drawing.Point(20, 10)
        Me.txtUkuran.Name = "txtUkuran"
        Me.txtUkuran.Size = New System.Drawing.Size(256, 20)
        Me.txtUkuran.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label1.Font = New System.Drawing.Font("Poppins", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(114, Byte), Integer), CType(CType(122, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(0, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Padding = New System.Windows.Forms.Padding(0, 16, 0, 0)
        Me.Label1.Size = New System.Drawing.Size(360, 49)
        Me.Label1.TabIndex = 18
        Me.Label1.Text = "Update Jenis Locker"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Panel3.Controls.Add(Me.TxtBiaya)
        Me.Panel3.Location = New System.Drawing.Point(32, 174)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Padding = New System.Windows.Forms.Padding(20, 10, 20, 10)
        Me.Panel3.Size = New System.Drawing.Size(296, 40)
        Me.Panel3.TabIndex = 24
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Panel2.Controls.Add(Me.txtUkuran)
        Me.Panel2.Location = New System.Drawing.Point(32, 93)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Padding = New System.Windows.Forms.Padding(20, 10, 20, 10)
        Me.Panel2.Size = New System.Drawing.Size(296, 40)
        Me.Panel2.TabIndex = 23
        '
        'LabelUkuran
        '
        Me.LabelUkuran.AutoSize = True
        Me.LabelUkuran.Font = New System.Drawing.Font("Poppins", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelUkuran.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(114, Byte), Integer), CType(CType(122, Byte), Integer))
        Me.LabelUkuran.Location = New System.Drawing.Point(28, 67)
        Me.LabelUkuran.Name = "LabelUkuran"
        Me.LabelUkuran.Size = New System.Drawing.Size(56, 23)
        Me.LabelUkuran.TabIndex = 22
        Me.LabelUkuran.Text = "Ukuran"
        '
        'LabelBiaya
        '
        Me.LabelBiaya.AutoSize = True
        Me.LabelBiaya.Font = New System.Drawing.Font("Poppins", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelBiaya.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(114, Byte), Integer), CType(CType(122, Byte), Integer))
        Me.LabelBiaya.Location = New System.Drawing.Point(28, 148)
        Me.LabelBiaya.Name = "LabelBiaya"
        Me.LabelBiaya.Size = New System.Drawing.Size(46, 23)
        Me.LabelBiaya.TabIndex = 25
        Me.LabelBiaya.Text = "Biaya"
        '
        'UpdateJenisLocker
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(252, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(360, 300)
        Me.Controls.Add(Me.LabelBiaya)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.LabelUkuran)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.BtnUpdateLocker)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "UpdateJenisLocker"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents BtnUpdateLocker As Button
    Friend WithEvents TxtBiaya As TextBox
    Friend WithEvents txtUkuran As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents LabelUkuran As Label
    Friend WithEvents LabelBiaya As Label
End Class
