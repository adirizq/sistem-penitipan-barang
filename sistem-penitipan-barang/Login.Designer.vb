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
        Me.SuspendLayout()
        '
        'TextBoxUsername1
        '
        Me.TextBoxUsername1.Location = New System.Drawing.Point(153, 158)
        Me.TextBoxUsername1.Name = "TextBoxUsername1"
        Me.TextBoxUsername1.Size = New System.Drawing.Size(359, 23)
        Me.TextBoxUsername1.TabIndex = 0
        '
        'TextBoxPassword1
        '
        Me.TextBoxPassword1.Location = New System.Drawing.Point(153, 217)
        Me.TextBoxPassword1.Name = "TextBoxPassword1"
        Me.TextBoxPassword1.Size = New System.Drawing.Size(359, 23)
        Me.TextBoxPassword1.TabIndex = 1
        '
        'LabelLogin
        '
        Me.LabelLogin.AutoSize = True
        Me.LabelLogin.Font = New System.Drawing.Font("Palatino Linotype", 25.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.LabelLogin.Location = New System.Drawing.Point(231, 46)
        Me.LabelLogin.Name = "LabelLogin"
        Me.LabelLogin.Size = New System.Drawing.Size(111, 46)
        Me.LabelLogin.TabIndex = 2
        Me.LabelLogin.Text = "Login"
        '
        'LabelUsername
        '
        Me.LabelUsername.AutoSize = True
        Me.LabelUsername.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.LabelUsername.Location = New System.Drawing.Point(54, 158)
        Me.LabelUsername.Name = "LabelUsername"
        Me.LabelUsername.Size = New System.Drawing.Size(75, 20)
        Me.LabelUsername.TabIndex = 3
        Me.LabelUsername.Text = "Username"
        '
        'LabelPassword
        '
        Me.LabelPassword.AutoSize = True
        Me.LabelPassword.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.LabelPassword.Location = New System.Drawing.Point(57, 217)
        Me.LabelPassword.Name = "LabelPassword"
        Me.LabelPassword.Size = New System.Drawing.Size(70, 20)
        Me.LabelPassword.TabIndex = 4
        Me.LabelPassword.Text = "Password"
        '
        'ButtonSignUp
        '
        Me.ButtonSignUp.Location = New System.Drawing.Point(153, 334)
        Me.ButtonSignUp.Name = "ButtonSignUp"
        Me.ButtonSignUp.Size = New System.Drawing.Size(111, 23)
        Me.ButtonSignUp.TabIndex = 5
        Me.ButtonSignUp.Text = "Sign Up"
        Me.ButtonSignUp.UseVisualStyleBackColor = True
        '
        'ButtonSignIn
        '
        Me.ButtonSignIn.Location = New System.Drawing.Point(412, 334)
        Me.ButtonSignIn.Name = "ButtonSignIn"
        Me.ButtonSignIn.Size = New System.Drawing.Size(100, 23)
        Me.ButtonSignIn.TabIndex = 6
        Me.ButtonSignIn.Text = "Sign In"
        Me.ButtonSignIn.UseVisualStyleBackColor = True
        '
        'Login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(581, 448)
        Me.Controls.Add(Me.ButtonSignIn)
        Me.Controls.Add(Me.ButtonSignUp)
        Me.Controls.Add(Me.LabelPassword)
        Me.Controls.Add(Me.LabelUsername)
        Me.Controls.Add(Me.LabelLogin)
        Me.Controls.Add(Me.TextBoxPassword1)
        Me.Controls.Add(Me.TextBoxUsername1)
        Me.Name = "Login"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TextBoxUsername1 As TextBox
    Friend WithEvents TextBoxPassword1 As TextBox
    Friend WithEvents LabelLogin As Label
    Friend WithEvents LabelUsername As Label
    Friend WithEvents LabelPassword As Label
    Friend WithEvents ButtonSignUp As Button
    Friend WithEvents ButtonSignIn As Button
End Class
