<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Main
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.BtnSignOut = New System.Windows.Forms.Button()
        Me.Title = New System.Windows.Forms.Label()
        Me.LblJenisLockerSelected = New System.Windows.Forms.Label()
        Me.LblLockerSelected = New System.Windows.Forms.Label()
        Me.LblSewaSelected = New System.Windows.Forms.Label()
        Me.BtnJenisLocker = New System.Windows.Forms.Button()
        Me.BtnLocker = New System.Windows.Forms.Button()
        Me.BtnSewa = New System.Windows.Forms.Button()
        Me.PanelContent = New System.Windows.Forms.FlowLayoutPanel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(114, Byte), Integer), CType(CType(122, Byte), Integer))
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.BtnSignOut)
        Me.Panel1.Controls.Add(Me.Title)
        Me.Panel1.Controls.Add(Me.LblJenisLockerSelected)
        Me.Panel1.Controls.Add(Me.LblLockerSelected)
        Me.Panel1.Controls.Add(Me.LblSewaSelected)
        Me.Panel1.Controls.Add(Me.BtnJenisLocker)
        Me.Panel1.Controls.Add(Me.BtnLocker)
        Me.Panel1.Controls.Add(Me.BtnSewa)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1110, 60)
        Me.Panel1.TabIndex = 1
        '
        'BtnSignOut
        '
        Me.BtnSignOut.BackColor = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(71, Byte), Integer))
        Me.BtnSignOut.FlatAppearance.BorderSize = 0
        Me.BtnSignOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnSignOut.Font = New System.Drawing.Font("Poppins", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnSignOut.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(114, Byte), Integer), CType(CType(122, Byte), Integer))
        Me.BtnSignOut.Location = New System.Drawing.Point(978, 15)
        Me.BtnSignOut.Name = "BtnSignOut"
        Me.BtnSignOut.Size = New System.Drawing.Size(100, 30)
        Me.BtnSignOut.TabIndex = 9
        Me.BtnSignOut.Text = "Sign Out"
        Me.BtnSignOut.UseVisualStyleBackColor = False
        '
        'Title
        '
        Me.Title.AutoSize = True
        Me.Title.Font = New System.Drawing.Font("Poppins", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Title.ForeColor = System.Drawing.Color.White
        Me.Title.Location = New System.Drawing.Point(49, 14)
        Me.Title.Name = "Title"
        Me.Title.Size = New System.Drawing.Size(96, 42)
        Me.Title.TabIndex = 6
        Me.Title.Text = "Nitips."
        '
        'LblJenisLockerSelected
        '
        Me.LblJenisLockerSelected.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(205, Byte), Integer), CType(CType(5, Byte), Integer))
        Me.LblJenisLockerSelected.Location = New System.Drawing.Point(625, 56)
        Me.LblJenisLockerSelected.Name = "LblJenisLockerSelected"
        Me.LblJenisLockerSelected.Size = New System.Drawing.Size(140, 4)
        Me.LblJenisLockerSelected.TabIndex = 5
        Me.LblJenisLockerSelected.Visible = False
        '
        'LblLockerSelected
        '
        Me.LblLockerSelected.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(205, Byte), Integer), CType(CType(5, Byte), Integer))
        Me.LblLockerSelected.Location = New System.Drawing.Point(485, 56)
        Me.LblLockerSelected.Name = "LblLockerSelected"
        Me.LblLockerSelected.Size = New System.Drawing.Size(140, 4)
        Me.LblLockerSelected.TabIndex = 4
        Me.LblLockerSelected.Visible = False
        '
        'LblSewaSelected
        '
        Me.LblSewaSelected.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(205, Byte), Integer), CType(CType(5, Byte), Integer))
        Me.LblSewaSelected.Location = New System.Drawing.Point(345, 56)
        Me.LblSewaSelected.Name = "LblSewaSelected"
        Me.LblSewaSelected.Size = New System.Drawing.Size(140, 4)
        Me.LblSewaSelected.TabIndex = 1
        Me.LblSewaSelected.Visible = False
        '
        'BtnJenisLocker
        '
        Me.BtnJenisLocker.FlatAppearance.BorderSize = 0
        Me.BtnJenisLocker.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnJenisLocker.Font = New System.Drawing.Font("Poppins", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnJenisLocker.ForeColor = System.Drawing.Color.FromArgb(CType(CType(153, Byte), Integer), CType(CType(199, Byte), Integer), CType(CType(202, Byte), Integer))
        Me.BtnJenisLocker.Location = New System.Drawing.Point(625, 0)
        Me.BtnJenisLocker.Name = "BtnJenisLocker"
        Me.BtnJenisLocker.Size = New System.Drawing.Size(140, 60)
        Me.BtnJenisLocker.TabIndex = 3
        Me.BtnJenisLocker.Text = "Jenis Locker"
        Me.BtnJenisLocker.UseVisualStyleBackColor = False
        '
        'BtnLocker
        '
        Me.BtnLocker.FlatAppearance.BorderSize = 0
        Me.BtnLocker.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnLocker.Font = New System.Drawing.Font("Poppins", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnLocker.ForeColor = System.Drawing.Color.FromArgb(CType(CType(153, Byte), Integer), CType(CType(199, Byte), Integer), CType(CType(202, Byte), Integer))
        Me.BtnLocker.Location = New System.Drawing.Point(485, 0)
        Me.BtnLocker.Name = "BtnLocker"
        Me.BtnLocker.Size = New System.Drawing.Size(140, 60)
        Me.BtnLocker.TabIndex = 2
        Me.BtnLocker.Text = "Data Locker"
        Me.BtnLocker.UseVisualStyleBackColor = False
        '
        'BtnSewa
        '
        Me.BtnSewa.FlatAppearance.BorderSize = 0
        Me.BtnSewa.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnSewa.Font = New System.Drawing.Font("Poppins", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnSewa.ForeColor = System.Drawing.Color.FromArgb(CType(CType(153, Byte), Integer), CType(CType(199, Byte), Integer), CType(CType(202, Byte), Integer))
        Me.BtnSewa.Location = New System.Drawing.Point(345, 0)
        Me.BtnSewa.Name = "BtnSewa"
        Me.BtnSewa.Size = New System.Drawing.Size(140, 60)
        Me.BtnSewa.TabIndex = 1
        Me.BtnSewa.Text = "Data Sewa"
        Me.BtnSewa.UseVisualStyleBackColor = False
        '
        'PanelContent
        '
        Me.PanelContent.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelContent.Location = New System.Drawing.Point(0, 60)
        Me.PanelContent.Name = "PanelContent"
        Me.PanelContent.Size = New System.Drawing.Size(1110, 600)
        Me.PanelContent.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(71, Byte), Integer))
        Me.Label1.Font = New System.Drawing.Font("Poppins", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(32, 21)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(20, 20)
        Me.Label1.TabIndex = 10
        '
        'Main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1110, 660)
        Me.Controls.Add(Me.PanelContent)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "Main"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents LblJenisLockerSelected As Label
    Friend WithEvents LblLockerSelected As Label
    Friend WithEvents LblSewaSelected As Label
    Friend WithEvents BtnJenisLocker As Button
    Friend WithEvents BtnLocker As Button
    Friend WithEvents BtnSewa As Button
    Friend WithEvents PanelContent As FlowLayoutPanel
    Friend WithEvents Title As Label
    Friend WithEvents BtnSignOut As Button
    Friend WithEvents Label1 As Label
End Class
