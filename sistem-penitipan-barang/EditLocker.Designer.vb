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
        Me.lockerIdTitleLbl = New System.Windows.Forms.Label()
        Me.CBJenisKoleksi = New System.Windows.Forms.ComboBox()
        Me.LblJenisKoleksi = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
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
        Me.titleLbl.TabIndex = 2
        Me.titleLbl.Text = "Locker"
        '
        'lockerIdTitleLbl
        '
        Me.lockerIdTitleLbl.AutoSize = True
        Me.lockerIdTitleLbl.Font = New System.Drawing.Font("Microsoft Tai Le", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lockerIdTitleLbl.Location = New System.Drawing.Point(123, 20)
        Me.lockerIdTitleLbl.Margin = New System.Windows.Forms.Padding(0)
        Me.lockerIdTitleLbl.MaximumSize = New System.Drawing.Size(100, 34)
        Me.lockerIdTitleLbl.MinimumSize = New System.Drawing.Size(100, 34)
        Me.lockerIdTitleLbl.Name = "lockerIdTitleLbl"
        Me.lockerIdTitleLbl.Size = New System.Drawing.Size(100, 34)
        Me.lockerIdTitleLbl.TabIndex = 2
        Me.lockerIdTitleLbl.Text = "1"
        '
        'CBJenisKoleksi
        '
        Me.CBJenisKoleksi.Font = New System.Drawing.Font("Microsoft Tai Le", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CBJenisKoleksi.FormattingEnabled = True
        Me.CBJenisKoleksi.Location = New System.Drawing.Point(129, 77)
        Me.CBJenisKoleksi.Name = "CBJenisKoleksi"
        Me.CBJenisKoleksi.Size = New System.Drawing.Size(207, 24)
        Me.CBJenisKoleksi.TabIndex = 8
        '
        'LblJenisKoleksi
        '
        Me.LblJenisKoleksi.AutoSize = True
        Me.LblJenisKoleksi.Font = New System.Drawing.Font("Microsoft Tai Le", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblJenisKoleksi.Location = New System.Drawing.Point(28, 80)
        Me.LblJenisKoleksi.Name = "LblJenisKoleksi"
        Me.LblJenisKoleksi.Size = New System.Drawing.Size(81, 16)
        Me.LblJenisKoleksi.TabIndex = 7
        Me.LblJenisKoleksi.Text = "Jenis Koleksi"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Tai Le", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(28, 120)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(38, 16)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Biaya"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Tai Le", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(125, 117)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(55, 21)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "10000"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Tai Le", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(28, 160)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(44, 16)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Lokasi"
        '
        'TextBox1
        '
        Me.TextBox1.Font = New System.Drawing.Font("Microsoft Tai Le", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.Location = New System.Drawing.Point(129, 157)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(207, 24)
        Me.TextBox1.TabIndex = 9
        '
        'BtnUpdateLocker
        '
        Me.BtnUpdateLocker.Font = New System.Drawing.Font("Microsoft Tai Le", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnUpdateLocker.Location = New System.Drawing.Point(217, 208)
        Me.BtnUpdateLocker.Name = "BtnUpdateLocker"
        Me.BtnUpdateLocker.Size = New System.Drawing.Size(119, 28)
        Me.BtnUpdateLocker.TabIndex = 10
        Me.BtnUpdateLocker.Text = "Update Locker"
        Me.BtnUpdateLocker.UseVisualStyleBackColor = True
        '
        'EditLocker
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(372, 272)
        Me.Controls.Add(Me.BtnUpdateLocker)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.CBJenisKoleksi)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.LblJenisKoleksi)
        Me.Controls.Add(Me.lockerIdTitleLbl)
        Me.Controls.Add(Me.titleLbl)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(388, 311)
        Me.MinimumSize = New System.Drawing.Size(388, 311)
        Me.Name = "EditLocker"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Edit Locker"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents titleLbl As Label
    Friend WithEvents lockerIdTitleLbl As Label
    Friend WithEvents CBJenisKoleksi As ComboBox
    Friend WithEvents LblJenisKoleksi As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents BtnUpdateLocker As Button
End Class
