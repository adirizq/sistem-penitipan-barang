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
        Me.ButtonCancel = New System.Windows.Forms.Button()
        Me.ButtonRegister = New System.Windows.Forms.Button()
        Me.LabelPassword = New System.Windows.Forms.Label()
        Me.LabelUsername = New System.Windows.Forms.Label()
        Me.LabelRegister = New System.Windows.Forms.Label()
        Me.TextBoxEmail = New System.Windows.Forms.TextBox()
        Me.TextBoxUsername2 = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TextBoxRetypePassword = New System.Windows.Forms.TextBox()
        Me.TextBoxPassword2 = New System.Windows.Forms.TextBox()
        Me.LabelNotvalid = New System.Windows.Forms.Label()
        Me.LabelNotmatch = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'ButtonCancel
        '
        Me.ButtonCancel.Location = New System.Drawing.Point(388, 366)
        Me.ButtonCancel.Name = "ButtonCancel"
        Me.ButtonCancel.Size = New System.Drawing.Size(86, 20)
        Me.ButtonCancel.TabIndex = 13
        Me.ButtonCancel.Text = "Cancel"
        Me.ButtonCancel.UseVisualStyleBackColor = True
        '
        'ButtonRegister
        '
        Me.ButtonRegister.Location = New System.Drawing.Point(157, 366)
        Me.ButtonRegister.Name = "ButtonRegister"
        Me.ButtonRegister.Size = New System.Drawing.Size(95, 20)
        Me.ButtonRegister.TabIndex = 12
        Me.ButtonRegister.Text = "Sign Up"
        Me.ButtonRegister.UseVisualStyleBackColor = True
        '
        'LabelPassword
        '
        Me.LabelPassword.AutoSize = True
        Me.LabelPassword.Font = New System.Drawing.Font("Segoe UI", 11.0!)
        Me.LabelPassword.Location = New System.Drawing.Point(61, 146)
        Me.LabelPassword.Name = "LabelPassword"
        Me.LabelPassword.Size = New System.Drawing.Size(46, 20)
        Me.LabelPassword.TabIndex = 11
        Me.LabelPassword.Text = "Email"
        '
        'LabelUsername
        '
        Me.LabelUsername.AutoSize = True
        Me.LabelUsername.Font = New System.Drawing.Font("Segoe UI", 11.0!)
        Me.LabelUsername.Location = New System.Drawing.Point(58, 94)
        Me.LabelUsername.Name = "LabelUsername"
        Me.LabelUsername.Size = New System.Drawing.Size(75, 20)
        Me.LabelUsername.TabIndex = 10
        Me.LabelUsername.Text = "Username"
        '
        'LabelRegister
        '
        Me.LabelRegister.AutoSize = True
        Me.LabelRegister.Font = New System.Drawing.Font("Palatino Linotype", 25.0!, System.Drawing.FontStyle.Bold)
        Me.LabelRegister.Location = New System.Drawing.Point(217, 29)
        Me.LabelRegister.Name = "LabelRegister"
        Me.LabelRegister.Size = New System.Drawing.Size(147, 46)
        Me.LabelRegister.TabIndex = 9
        Me.LabelRegister.Text = "Register"
        '
        'TextBoxEmail
        '
        Me.TextBoxEmail.Location = New System.Drawing.Point(234, 146)
        Me.TextBoxEmail.Name = "TextBoxEmail"
        Me.TextBoxEmail.Size = New System.Drawing.Size(308, 20)
        Me.TextBoxEmail.TabIndex = 8
        '
        'TextBoxUsername2
        '
        Me.TextBoxUsername2.Location = New System.Drawing.Point(234, 94)
        Me.TextBoxUsername2.Name = "TextBoxUsername2"
        Me.TextBoxUsername2.Size = New System.Drawing.Size(308, 20)
        Me.TextBoxUsername2.TabIndex = 7
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 11.0!)
        Me.Label1.Location = New System.Drawing.Point(63, 255)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(120, 20)
        Me.Label1.TabIndex = 17
        Me.Label1.Text = "Retype Password"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 11.0!)
        Me.Label2.Location = New System.Drawing.Point(60, 204)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(70, 20)
        Me.Label2.TabIndex = 16
        Me.Label2.Text = "Password"
        '
        'TextBoxRetypePassword
        '
        Me.TextBoxRetypePassword.Location = New System.Drawing.Point(234, 252)
        Me.TextBoxRetypePassword.Name = "TextBoxRetypePassword"
        Me.TextBoxRetypePassword.Size = New System.Drawing.Size(308, 20)
        Me.TextBoxRetypePassword.TabIndex = 15
        '
        'TextBoxPassword2
        '
        Me.TextBoxPassword2.Location = New System.Drawing.Point(234, 204)
        Me.TextBoxPassword2.Name = "TextBoxPassword2"
        Me.TextBoxPassword2.Size = New System.Drawing.Size(308, 20)
        Me.TextBoxPassword2.TabIndex = 14
        '
        'LabelNotvalid
        '
        Me.LabelNotvalid.AutoSize = True
        Me.LabelNotvalid.Font = New System.Drawing.Font("Segoe UI", 8.0!)
        Me.LabelNotvalid.ForeColor = System.Drawing.Color.Red
        Me.LabelNotvalid.Location = New System.Drawing.Point(234, 168)
        Me.LabelNotvalid.Name = "LabelNotvalid"
        Me.LabelNotvalid.Size = New System.Drawing.Size(87, 13)
        Me.LabelNotvalid.TabIndex = 18
        Me.LabelNotvalid.Text = "*Email not valid"
        '
        'LabelNotmatch
        '
        Me.LabelNotmatch.AutoSize = True
        Me.LabelNotmatch.Font = New System.Drawing.Font("Segoe UI", 8.0!)
        Me.LabelNotmatch.ForeColor = System.Drawing.Color.Red
        Me.LabelNotmatch.Location = New System.Drawing.Point(234, 275)
        Me.LabelNotmatch.Name = "LabelNotmatch"
        Me.LabelNotmatch.Size = New System.Drawing.Size(137, 13)
        Me.LabelNotmatch.TabIndex = 19
        Me.LabelNotmatch.Text = "*Password doesn't match"
        '
        'Register
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(597, 468)
        Me.Controls.Add(Me.LabelNotmatch)
        Me.Controls.Add(Me.LabelNotvalid)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TextBoxRetypePassword)
        Me.Controls.Add(Me.TextBoxPassword2)
        Me.Controls.Add(Me.ButtonCancel)
        Me.Controls.Add(Me.ButtonRegister)
        Me.Controls.Add(Me.LabelPassword)
        Me.Controls.Add(Me.LabelUsername)
        Me.Controls.Add(Me.LabelRegister)
        Me.Controls.Add(Me.TextBoxEmail)
        Me.Controls.Add(Me.TextBoxUsername2)
        Me.Name = "Register"
        Me.Text = "Register"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ButtonCancel As Button
    Friend WithEvents ButtonRegister As Button
    Friend WithEvents LabelPassword As Label
    Friend WithEvents LabelUsername As Label
    Friend WithEvents LabelRegister As Label
    Friend WithEvents TextBoxEmail As TextBox
    Friend WithEvents TextBoxUsername2 As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents TextBoxRetypePassword As TextBox
    Friend WithEvents TextBoxPassword2 As TextBox
    Friend WithEvents LabelNotvalid As Label
    Friend WithEvents LabelNotmatch As Label
End Class
