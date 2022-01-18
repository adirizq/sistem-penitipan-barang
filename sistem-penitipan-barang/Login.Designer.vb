<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Login
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
        Me.TextBoxUsername1 = New System.Windows.Forms.TextBox()
        Me.TextBoxPassword1 = New System.Windows.Forms.TextBox()
        Me.LabelLogin = New System.Windows.Forms.Label()
        Me.LabelUsername = New System.Windows.Forms.Label()
        Me.LabelPassword = New System.Windows.Forms.Label()
        Me.ButtonSignUp = New System.Windows.Forms.Button()
        Me.ButtonSignIn = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel4.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TextBoxUsername1
        '
        Me.TextBoxUsername1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(147, Byte), Integer))
        Me.TextBoxUsername1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBoxUsername1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TextBoxUsername1.Font = New System.Drawing.Font("Poppins", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxUsername1.ForeColor = System.Drawing.Color.White
        Me.TextBoxUsername1.Location = New System.Drawing.Point(20, 10)
        Me.TextBoxUsername1.Name = "TextBoxUsername1"
        Me.TextBoxUsername1.Size = New System.Drawing.Size(368, 24)
        Me.TextBoxUsername1.TabIndex = 0
        '
        'TextBoxPassword1
        '
        Me.TextBoxPassword1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(147, Byte), Integer))
        Me.TextBoxPassword1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBoxPassword1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TextBoxPassword1.Font = New System.Drawing.Font("Poppins", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxPassword1.ForeColor = System.Drawing.Color.White
        Me.TextBoxPassword1.Location = New System.Drawing.Point(20, 10)
        Me.TextBoxPassword1.Name = "TextBoxPassword1"
        Me.TextBoxPassword1.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.TextBoxPassword1.Size = New System.Drawing.Size(368, 24)
        Me.TextBoxPassword1.TabIndex = 1
        '
        'LabelLogin
        '
        Me.LabelLogin.AutoSize = True
        Me.LabelLogin.Font = New System.Drawing.Font("Poppins", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelLogin.ForeColor = System.Drawing.Color.White
        Me.LabelLogin.Location = New System.Drawing.Point(80, 81)
        Me.LabelLogin.Name = "LabelLogin"
        Me.LabelLogin.Size = New System.Drawing.Size(192, 84)
        Me.LabelLogin.TabIndex = 2
        Me.LabelLogin.Text = "Nitips."
        '
        'LabelUsername
        '
        Me.LabelUsername.AutoSize = True
        Me.LabelUsername.Font = New System.Drawing.Font("Poppins", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelUsername.ForeColor = System.Drawing.Color.White
        Me.LabelUsername.Location = New System.Drawing.Point(40, 239)
        Me.LabelUsername.Name = "LabelUsername"
        Me.LabelUsername.Size = New System.Drawing.Size(94, 28)
        Me.LabelUsername.TabIndex = 3
        Me.LabelUsername.Text = "Username"
        '
        'LabelPassword
        '
        Me.LabelPassword.AutoSize = True
        Me.LabelPassword.Font = New System.Drawing.Font("Poppins", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelPassword.ForeColor = System.Drawing.Color.White
        Me.LabelPassword.Location = New System.Drawing.Point(44, 332)
        Me.LabelPassword.Name = "LabelPassword"
        Me.LabelPassword.Size = New System.Drawing.Size(88, 28)
        Me.LabelPassword.TabIndex = 4
        Me.LabelPassword.Text = "Password"
        '
        'ButtonSignUp
        '
        Me.ButtonSignUp.FlatAppearance.BorderSize = 0
        Me.ButtonSignUp.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonSignUp.Font = New System.Drawing.Font("Poppins", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonSignUp.ForeColor = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(71, Byte), Integer))
        Me.ButtonSignUp.Location = New System.Drawing.Point(45, 513)
        Me.ButtonSignUp.Name = "ButtonSignUp"
        Me.ButtonSignUp.Size = New System.Drawing.Size(408, 38)
        Me.ButtonSignUp.TabIndex = 3
        Me.ButtonSignUp.Text = "Sign Up"
        Me.ButtonSignUp.UseVisualStyleBackColor = True
        '
        'ButtonSignIn
        '
        Me.ButtonSignIn.BackColor = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(71, Byte), Integer))
        Me.ButtonSignIn.FlatAppearance.BorderSize = 0
        Me.ButtonSignIn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonSignIn.Font = New System.Drawing.Font("Poppins", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonSignIn.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(114, Byte), Integer), CType(CType(122, Byte), Integer))
        Me.ButtonSignIn.Location = New System.Drawing.Point(45, 456)
        Me.ButtonSignIn.Name = "ButtonSignIn"
        Me.ButtonSignIn.Size = New System.Drawing.Size(408, 38)
        Me.ButtonSignIn.TabIndex = 2
        Me.ButtonSignIn.Text = "Sign In"
        Me.ButtonSignIn.UseVisualStyleBackColor = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(114, Byte), Integer), CType(CType(122, Byte), Integer))
        Me.Panel1.Controls.Add(Me.Panel3)
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.ButtonSignIn)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.ButtonSignUp)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.LabelPassword)
        Me.Panel1.Controls.Add(Me.LabelLogin)
        Me.Panel1.Controls.Add(Me.LabelUsername)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(500, 660)
        Me.Panel1.TabIndex = 7
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Poppins", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(40, 182)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(406, 25)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "yang mudah digunakan."
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Poppins", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(40, 158)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(406, 25)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Sistem penitipan barang buatan para pemula "
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(71, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(46, 95)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(40, 40)
        Me.Label1.TabIndex = 3
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(147, Byte), Integer))
        Me.Panel2.Controls.Add(Me.TextBoxUsername1)
        Me.Panel2.Location = New System.Drawing.Point(45, 270)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Padding = New System.Windows.Forms.Padding(20, 10, 20, 10)
        Me.Panel2.Size = New System.Drawing.Size(408, 44)
        Me.Panel2.TabIndex = 7
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(147, Byte), Integer))
        Me.Panel3.Controls.Add(Me.TextBoxPassword1)
        Me.Panel3.Location = New System.Drawing.Point(45, 363)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Padding = New System.Windows.Forms.Padding(20, 10, 20, 10)
        Me.Panel3.Size = New System.Drawing.Size(408, 44)
        Me.Panel3.TabIndex = 8
        '
        'Panel4
        '
        Me.Panel4.Controls.Add(Me.PictureBox1)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel4.Location = New System.Drawing.Point(500, 0)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(610, 660)
        Me.Panel4.TabIndex = 8
        '
        'PictureBox1
        '
        Me.PictureBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PictureBox1.Image = Global.sistem_penitipan_barang.My.Resources.Resources.Image
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(610, 660)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'Login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(252, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1110, 660)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "Login"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.Panel4.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TextBoxUsername1 As TextBox
    Friend WithEvents TextBoxPassword1 As TextBox
    Friend WithEvents LabelLogin As Label
    Friend WithEvents LabelUsername As Label
    Friend WithEvents LabelPassword As Label
    Friend WithEvents ButtonSignUp As Button
    Friend WithEvents ButtonSignIn As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel4 As Panel
    Friend WithEvents PictureBox1 As PictureBox
End Class
