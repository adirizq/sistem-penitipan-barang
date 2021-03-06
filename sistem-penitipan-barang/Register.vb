Imports System.ComponentModel
Imports System.Net.Mail

Public Class Register
    Dim passwordValidation = True
    Dim emailValidation = False
    Dim toLogin = False

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        LabelNotvalid.Visible = False
        LabelNotmatch.Visible = False

    End Sub

    Private Sub ButtonRegister_Click(sender As Object, e As EventArgs) Handles ButtonRegister.Click
        Dim registeredUsername = TextBoxUsername.Text
        Dim registeredPassword = TextBoxPassword.Text
        Dim registeredEmail = TextBoxEmail.Text

        If registeredUsername.Length > 0 And registeredPassword.Length > 0 And registeredEmail.Length > 0 Then
            If passwordValidation And emailValidation Then
                Login.User.AddUsersDatabase(registeredUsername, registeredPassword, registeredEmail)
                Login.Show()
                toLogin = True
                Me.Close()
            Else
                MessageBox.Show("Please fix the error(s)!")
            End If
        Else
            MessageBox.Show("Please fill all fields")
        End If
    End Sub

    Private Sub TextBoxPassword2_TextChanged(sender As Object, e As EventArgs) Handles TextBoxPassword.TextChanged
        passwordValidation = validatePassword()
    End Sub

    Private Sub TextBoxRetypePasssword_TextChanged(sender As Object, e As EventArgs) Handles TextBoxRetypePassword.TextChanged
        passwordValidation = validatePassword()
    End Sub

    Private Sub TextBoxEmail_Leave(sender As Object, e As EventArgs) Handles TextBoxEmail.Leave
        Try
            Dim testEmail = New MailAddress(TextBoxEmail.Text)
            LabelNotvalid.Visible = False
            emailValidation = True
        Catch ex As Exception
            LabelNotvalid.Visible = True
            emailValidation = False
        End Try
    End Sub

    Private Function validatePassword() As Boolean
        If TextBoxPassword.Text = TextBoxRetypePassword.Text Then
            LabelNotmatch.Visible = False
            Return True
        Else
            LabelNotmatch.Visible = True
            Return False
        End If
    End Function

    Private Sub ButtonCancel_Click(sender As Object, e As EventArgs) Handles ButtonCancel.Click
        toLogin = True
        Me.Close()
    End Sub

    Private Sub Register_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        If toLogin Then
            Login.Show()
        Else
            Application.Exit()
        End If
    End Sub
End Class