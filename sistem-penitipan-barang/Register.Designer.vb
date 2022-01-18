<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Register
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
        Me.LabelNotvalid = New System.Windows.Forms.Label()
        Me.LabelNotmatch = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.TextBoxRetypePassword = New System.Windows.Forms.TextBox()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.TextBoxPassword = New System.Windows.Forms.TextBox()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.TextBoxEmail = New System.Windows.Forms.TextBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.TextBoxUsername = New System.Windows.Forms.TextBox()
        Me.ButtonRegister = New System.Windows.Forms.Button()
        Me.ButtonCancel = New System.Windows.Forms.Button()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.LabelLogin = New System.Windows.Forms.Label()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.Panel1.SuspendLayout()
        Me.Panel5.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel6.SuspendLayout()
        Me.SuspendLayout()
        '
        'LabelNotvalid
        '
        Me.LabelNotvalid.AutoSize = True
        Me.LabelNotvalid.Font = New System.Drawing.Font("Poppins", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelNotvalid.ForeColor = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(71, Byte), Integer))
        Me.LabelNotvalid.Location = New System.Drawing.Point(344, 283)
        Me.LabelNotvalid.Name = "LabelNotvalid"
        Me.LabelNotvalid.Size = New System.Drawing.Size(109, 23)
        Me.LabelNotvalid.TabIndex = 18
        Me.LabelNotvalid.Text = "*Email not valid"
        '
        'LabelNotmatch
        '
        Me.LabelNotmatch.AutoSize = True
        Me.LabelNotmatch.Font = New System.Drawing.Font("Poppins", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelNotmatch.ForeColor = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(71, Byte), Integer))
        Me.LabelNotmatch.Location = New System.Drawing.Point(277, 469)
        Me.LabelNotmatch.Name = "LabelNotmatch"
        Me.LabelNotmatch.Size = New System.Drawing.Size(176, 23)
        Me.LabelNotmatch.TabIndex = 19
        Me.LabelNotmatch.Text = "*Password doesn't match"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(114, Byte), Integer), CType(CType(122, Byte), Integer))
        Me.Panel1.Controls.Add(Me.Label8)
        Me.Panel1.Controls.Add(Me.LabelNotmatch)
        Me.Panel1.Controls.Add(Me.Panel5)
        Me.Panel1.Controls.Add(Me.LabelNotvalid)
        Me.Panel1.Controls.Add(Me.Panel4)
        Me.Panel1.Controls.Add(Me.Panel3)
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Controls.Add(Me.ButtonRegister)
        Me.Panel1.Controls.Add(Me.ButtonCancel)
        Me.Panel1.Controls.Add(Me.Label10)
        Me.Panel1.Controls.Add(Me.Label9)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(500, 660)
        Me.Panel1.TabIndex = 20
        '
        'Label8
        '
        Me.Label8.Font = New System.Drawing.Font("Poppins", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.White
        Me.Label8.Location = New System.Drawing.Point(34, 37)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(175, 60)
        Me.Label8.TabIndex = 9
        Me.Label8.Text = "Sign Up"
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(147, Byte), Integer))
        Me.Panel5.Controls.Add(Me.TextBoxRetypePassword)
        Me.Panel5.Location = New System.Drawing.Point(45, 422)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Padding = New System.Windows.Forms.Padding(20, 10, 20, 10)
        Me.Panel5.Size = New System.Drawing.Size(408, 44)
        Me.Panel5.TabIndex = 10
        '
        'TextBoxRetypePassword
        '
        Me.TextBoxRetypePassword.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(147, Byte), Integer))
        Me.TextBoxRetypePassword.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBoxRetypePassword.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TextBoxRetypePassword.Font = New System.Drawing.Font("Poppins", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxRetypePassword.ForeColor = System.Drawing.Color.White
        Me.TextBoxRetypePassword.Location = New System.Drawing.Point(20, 10)
        Me.TextBoxRetypePassword.Name = "TextBoxRetypePassword"
        Me.TextBoxRetypePassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.TextBoxRetypePassword.Size = New System.Drawing.Size(368, 24)
        Me.TextBoxRetypePassword.TabIndex = 4
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(147, Byte), Integer))
        Me.Panel4.Controls.Add(Me.TextBoxPassword)
        Me.Panel4.Location = New System.Drawing.Point(45, 329)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Padding = New System.Windows.Forms.Padding(20, 10, 20, 10)
        Me.Panel4.Size = New System.Drawing.Size(408, 44)
        Me.Panel4.TabIndex = 9
        '
        'TextBoxPassword
        '
        Me.TextBoxPassword.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(147, Byte), Integer))
        Me.TextBoxPassword.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBoxPassword.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TextBoxPassword.Font = New System.Drawing.Font("Poppins", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxPassword.ForeColor = System.Drawing.Color.White
        Me.TextBoxPassword.Location = New System.Drawing.Point(20, 10)
        Me.TextBoxPassword.Name = "TextBoxPassword"
        Me.TextBoxPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.TextBoxPassword.Size = New System.Drawing.Size(368, 24)
        Me.TextBoxPassword.TabIndex = 3
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(147, Byte), Integer))
        Me.Panel3.Controls.Add(Me.TextBoxEmail)
        Me.Panel3.Location = New System.Drawing.Point(45, 236)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Padding = New System.Windows.Forms.Padding(20, 10, 20, 10)
        Me.Panel3.Size = New System.Drawing.Size(408, 44)
        Me.Panel3.TabIndex = 8
        '
        'TextBoxEmail
        '
        Me.TextBoxEmail.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(147, Byte), Integer))
        Me.TextBoxEmail.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBoxEmail.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TextBoxEmail.Font = New System.Drawing.Font("Poppins", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxEmail.ForeColor = System.Drawing.Color.White
        Me.TextBoxEmail.Location = New System.Drawing.Point(20, 10)
        Me.TextBoxEmail.Name = "TextBoxEmail"
        Me.TextBoxEmail.Size = New System.Drawing.Size(368, 24)
        Me.TextBoxEmail.TabIndex = 2
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(147, Byte), Integer))
        Me.Panel2.Controls.Add(Me.TextBoxUsername)
        Me.Panel2.Location = New System.Drawing.Point(45, 143)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Padding = New System.Windows.Forms.Padding(20, 10, 20, 10)
        Me.Panel2.Size = New System.Drawing.Size(408, 44)
        Me.Panel2.TabIndex = 7
        '
        'TextBoxUsername
        '
        Me.TextBoxUsername.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(147, Byte), Integer))
        Me.TextBoxUsername.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBoxUsername.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TextBoxUsername.Font = New System.Drawing.Font("Poppins", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxUsername.ForeColor = System.Drawing.Color.White
        Me.TextBoxUsername.Location = New System.Drawing.Point(20, 10)
        Me.TextBoxUsername.Name = "TextBoxUsername"
        Me.TextBoxUsername.Size = New System.Drawing.Size(368, 24)
        Me.TextBoxUsername.TabIndex = 1
        '
        'ButtonRegister
        '
        Me.ButtonRegister.BackColor = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(71, Byte), Integer))
        Me.ButtonRegister.FlatAppearance.BorderSize = 0
        Me.ButtonRegister.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonRegister.Font = New System.Drawing.Font("Poppins", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonRegister.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(114, Byte), Integer), CType(CType(122, Byte), Integer))
        Me.ButtonRegister.Location = New System.Drawing.Point(45, 524)
        Me.ButtonRegister.Name = "ButtonRegister"
        Me.ButtonRegister.Size = New System.Drawing.Size(408, 38)
        Me.ButtonRegister.TabIndex = 5
        Me.ButtonRegister.Text = "Create Account"
        Me.ButtonRegister.UseVisualStyleBackColor = False
        '
        'ButtonCancel
        '
        Me.ButtonCancel.FlatAppearance.BorderSize = 0
        Me.ButtonCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonCancel.Font = New System.Drawing.Font("Poppins", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonCancel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(71, Byte), Integer))
        Me.ButtonCancel.Location = New System.Drawing.Point(45, 581)
        Me.ButtonCancel.Name = "ButtonCancel"
        Me.ButtonCancel.Size = New System.Drawing.Size(408, 38)
        Me.ButtonCancel.TabIndex = 6
        Me.ButtonCancel.Text = "Back"
        Me.ButtonCancel.UseVisualStyleBackColor = True
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Poppins", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.White
        Me.Label10.Location = New System.Drawing.Point(44, 391)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(148, 28)
        Me.Label10.TabIndex = 4
        Me.Label10.Text = "Retype Password"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Poppins", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.White
        Me.Label9.Location = New System.Drawing.Point(44, 298)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(88, 28)
        Me.Label9.TabIndex = 4
        Me.Label9.Text = "Password"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Poppins", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(44, 205)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(55, 28)
        Me.Label6.TabIndex = 4
        Me.Label6.Text = "Email"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Poppins", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(40, 112)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(94, 28)
        Me.Label7.TabIndex = 3
        Me.Label7.Text = "Username"
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(71, Byte), Integer))
        Me.Label5.Location = New System.Drawing.Point(200, 302)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(40, 40)
        Me.Label5.TabIndex = 3
        '
        'LabelLogin
        '
        Me.LabelLogin.BackColor = System.Drawing.Color.Transparent
        Me.LabelLogin.Font = New System.Drawing.Font("Poppins", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelLogin.ForeColor = System.Drawing.Color.White
        Me.LabelLogin.Location = New System.Drawing.Point(229, 288)
        Me.LabelLogin.Name = "LabelLogin"
        Me.LabelLogin.Size = New System.Drawing.Size(195, 76)
        Me.LabelLogin.TabIndex = 2
        Me.LabelLogin.Text = "Nitips."
        '
        'Panel6
        '
        Me.Panel6.BackgroundImage = Global.sistem_penitipan_barang.My.Resources.Resources.Image
        Me.Panel6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel6.Controls.Add(Me.Label5)
        Me.Panel6.Controls.Add(Me.LabelLogin)
        Me.Panel6.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel6.Location = New System.Drawing.Point(500, 0)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(610, 660)
        Me.Panel6.TabIndex = 24
        '
        'Register
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(252, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1110, 660)
        Me.Controls.Add(Me.Panel6)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "Register"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel5.ResumeLayout(False)
        Me.Panel5.PerformLayout()
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel6.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents LabelNotvalid As Label
    Friend WithEvents LabelNotmatch As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label8 As Label
    Friend WithEvents Panel3 As Panel
    Friend WithEvents TextBoxEmail As TextBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents TextBoxUsername As TextBox
    Friend WithEvents ButtonRegister As Button
    Friend WithEvents ButtonCancel As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents LabelLogin As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Panel5 As Panel
    Friend WithEvents TextBoxRetypePassword As TextBox
    Friend WithEvents Panel4 As Panel
    Friend WithEvents TextBoxPassword As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Panel6 As Panel
End Class
