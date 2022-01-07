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
        Me.titleLbl.Font = New System.Drawing.Font("Microsoft Tai Le", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.titleLbl.Location = New System.Drawing.Point(20, 20)
        Me.titleLbl.MaximumSize = New System.Drawing.Size(210, 34)
        Me.titleLbl.MinimumSize = New System.Drawing.Size(210, 34)
        Me.titleLbl.Name = "titleLbl"
        Me.titleLbl.Size = New System.Drawing.Size(210, 34)
        Me.titleLbl.TabIndex = 4
        Me.titleLbl.Text = "Locker"
        '
        'BtnUpdateStatus
        '
        Me.BtnUpdateStatus.Font = New System.Drawing.Font("Microsoft Tai Le", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnUpdateStatus.Location = New System.Drawing.Point(104, 187)
        Me.BtnUpdateStatus.Name = "BtnUpdateStatus"
        Me.BtnUpdateStatus.Size = New System.Drawing.Size(119, 28)
        Me.BtnUpdateStatus.TabIndex = 11
        Me.BtnUpdateStatus.Text = "Update Status"
        Me.BtnUpdateStatus.UseVisualStyleBackColor = True
        '
        'GBStatus
        '
        Me.GBStatus.Controls.Add(Me.RDTerisi)
        Me.GBStatus.Controls.Add(Me.RDKosong)
        Me.GBStatus.Font = New System.Drawing.Font("Microsoft Tai Le", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GBStatus.Location = New System.Drawing.Point(26, 73)
        Me.GBStatus.Name = "GBStatus"
        Me.GBStatus.Size = New System.Drawing.Size(197, 91)
        Me.GBStatus.TabIndex = 13
        Me.GBStatus.TabStop = False
        Me.GBStatus.Text = "Status"
        '
        'RDTerisi
        '
        Me.RDTerisi.AutoSize = True
        Me.RDTerisi.Location = New System.Drawing.Point(19, 51)
        Me.RDTerisi.Name = "RDTerisi"
        Me.RDTerisi.Size = New System.Drawing.Size(57, 20)
        Me.RDTerisi.TabIndex = 0
        Me.RDTerisi.TabStop = True
        Me.RDTerisi.Text = "Terisi"
        Me.RDTerisi.UseVisualStyleBackColor = True
        '
        'RDKosong
        '
        Me.RDKosong.AutoSize = True
        Me.RDKosong.Location = New System.Drawing.Point(20, 28)
        Me.RDKosong.Name = "RDKosong"
        Me.RDKosong.Size = New System.Drawing.Size(71, 20)
        Me.RDKosong.TabIndex = 0
        Me.RDKosong.TabStop = True
        Me.RDKosong.Text = "Kosong"
        Me.RDKosong.UseVisualStyleBackColor = True
        '
        'UpdateStatusLocker
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(251, 241)
        Me.Controls.Add(Me.GBStatus)
        Me.Controls.Add(Me.BtnUpdateStatus)
        Me.Controls.Add(Me.titleLbl)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(267, 280)
        Me.MinimumSize = New System.Drawing.Size(267, 280)
        Me.Name = "UpdateStatusLocker"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Update Status"
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
