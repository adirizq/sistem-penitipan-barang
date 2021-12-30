<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Register
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
        Me.ButtonRegister = New System.Windows.Forms.Button()
        Me.TextBoxPassword = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TextBoxUserName = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'ButtonRegister
        '
        Me.ButtonRegister.Location = New System.Drawing.Point(439, 246)
        Me.ButtonRegister.Name = "ButtonRegister"
        Me.ButtonRegister.Size = New System.Drawing.Size(75, 23)
        Me.ButtonRegister.TabIndex = 9
        Me.ButtonRegister.Text = "Register"
        Me.ButtonRegister.UseVisualStyleBackColor = True
        '
        'TextBoxPassword
        '
        Me.TextBoxPassword.Location = New System.Drawing.Point(228, 143)
        Me.TextBoxPassword.Name = "TextBoxPassword"
        Me.TextBoxPassword.Size = New System.Drawing.Size(214, 20)
        Me.TextBoxPassword.TabIndex = 8
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(88, 143)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(53, 13)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Password"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(88, 96)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(55, 13)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Username"
        '
        'TextBoxUserName
        '
        Me.TextBoxUserName.Location = New System.Drawing.Point(228, 96)
        Me.TextBoxUserName.Name = "TextBoxUserName"
        Me.TextBoxUserName.Size = New System.Drawing.Size(214, 20)
        Me.TextBoxUserName.TabIndex = 5
        '
        'Register
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(645, 450)
        Me.Controls.Add(Me.ButtonRegister)
        Me.Controls.Add(Me.TextBoxPassword)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TextBoxUserName)
        Me.Name = "Register"
        Me.Text = "Register"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ButtonRegister As Button
    Friend WithEvents TextBoxPassword As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents TextBoxUserName As TextBox
End Class
