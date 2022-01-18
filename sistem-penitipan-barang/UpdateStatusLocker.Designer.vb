<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class UpdateStatusLocker
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
        Me.BtnUpdateStatus = New System.Windows.Forms.Button()
        Me.GBStatus = New System.Windows.Forms.GroupBox()
        Me.RDTerisi = New System.Windows.Forms.RadioButton()
        Me.RDKosong = New System.Windows.Forms.RadioButton()
        Me.GBStatus.SuspendLayout()
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
        Me.titleLbl.Size = New System.Drawing.Size(360, 62)
        Me.titleLbl.TabIndex = 4
        Me.titleLbl.Text = "Locker"
        Me.titleLbl.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'BtnUpdateStatus
        '
        Me.BtnUpdateStatus.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(114, Byte), Integer), CType(CType(122, Byte), Integer))
        Me.BtnUpdateStatus.FlatAppearance.BorderSize = 0
        Me.BtnUpdateStatus.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnUpdateStatus.Font = New System.Drawing.Font("Poppins SemiBold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnUpdateStatus.ForeColor = System.Drawing.Color.White
        Me.BtnUpdateStatus.Location = New System.Drawing.Point(32, 238)
        Me.BtnUpdateStatus.Name = "BtnUpdateStatus"
        Me.BtnUpdateStatus.Size = New System.Drawing.Size(296, 30)
        Me.BtnUpdateStatus.TabIndex = 11
        Me.BtnUpdateStatus.Text = "Update Status"
        Me.BtnUpdateStatus.UseVisualStyleBackColor = False
        '
        'GBStatus
        '
        Me.GBStatus.Controls.Add(Me.RDTerisi)
        Me.GBStatus.Controls.Add(Me.RDKosong)
        Me.GBStatus.Font = New System.Drawing.Font("Poppins", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GBStatus.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(114, Byte), Integer), CType(CType(122, Byte), Integer))
        Me.GBStatus.Location = New System.Drawing.Point(32, 97)
        Me.GBStatus.Name = "GBStatus"
        Me.GBStatus.Size = New System.Drawing.Size(296, 91)
        Me.GBStatus.TabIndex = 13
        Me.GBStatus.TabStop = False
        Me.GBStatus.Text = "Status"
        '
        'RDTerisi
        '
        Me.RDTerisi.AutoSize = True
        Me.RDTerisi.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(114, Byte), Integer), CType(CType(122, Byte), Integer))
        Me.RDTerisi.Location = New System.Drawing.Point(19, 51)
        Me.RDTerisi.Name = "RDTerisi"
        Me.RDTerisi.Size = New System.Drawing.Size(61, 27)
        Me.RDTerisi.TabIndex = 0
        Me.RDTerisi.TabStop = True
        Me.RDTerisi.Text = "Terisi"
        Me.RDTerisi.UseVisualStyleBackColor = True
        '
        'RDKosong
        '
        Me.RDKosong.AutoSize = True
        Me.RDKosong.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(114, Byte), Integer), CType(CType(122, Byte), Integer))
        Me.RDKosong.Location = New System.Drawing.Point(20, 28)
        Me.RDKosong.Name = "RDKosong"
        Me.RDKosong.Size = New System.Drawing.Size(76, 27)
        Me.RDKosong.TabIndex = 0
        Me.RDKosong.TabStop = True
        Me.RDKosong.Text = "Kosong"
        Me.RDKosong.UseVisualStyleBackColor = True
        '
        'UpdateStatusLocker
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(252, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(360, 300)
        Me.Controls.Add(Me.GBStatus)
        Me.Controls.Add(Me.BtnUpdateStatus)
        Me.Controls.Add(Me.titleLbl)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "UpdateStatusLocker"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.GBStatus.ResumeLayout(False)
        Me.GBStatus.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents titleLbl As Label
    Friend WithEvents BtnUpdateStatus As Button
    Friend WithEvents GBStatus As GroupBox
    Friend WithEvents RDTerisi As RadioButton
    Friend WithEvents RDKosong As RadioButton
End Class
