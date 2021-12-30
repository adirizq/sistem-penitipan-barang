Imports System.Net.Mail

Public Class Register
    Dim passwordValidation = True
    Dim emailValidation = False

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        LblNotValid.Visible = False
        LblNotMatch.Visible = False

    End Sub

    Private Sub BtnRegister_Click(sender As Object, e As EventArgs) Handles BtnRegister.Click
        Dim registeredUsername = TxtUsername.Text
        Dim registeredPassword = TxtPassword.Text
        Dim registeredEmail = TxtEmail.Text

        If registeredUsername.Length > 0 And registeredPassword.Length > 0 And registeredEmail.Length > 0 Then
            If passwordValidation And emailValidation Then
                Login.User.AddUsersDatabase(registeredUsername, registeredPassword, registeredEmail)
                Login.Show()
                Me.Close()
            Else
                MessageBox.Show("Please fix the error(s)!")
            End If
        Else
            MessageBox.Show("Please fill all fields")
        End If
    End Sub

    Private Sub TxtPassword_TextChanged(sender As Object, e As EventArgs) Handles TxtPassword.TextChanged
        passwordValidation = validatePassword()
    End Sub

    Private Sub TxtRetypePassword_TextChanged(sender As Object, e As EventArgs) Handles TxtRetypePassword.TextChanged
        passwordValidation = validatePassword()
    End Sub

    Private Sub TxtEmail_Leave(sender As Object, e As EventArgs) Handles TxtEmail.Leave
        Try
            Dim testEmail = New MailAddress(TxtEmail.Text)
            LblNotValid.Visible = False
            emailValidation = True
        Catch ex As Exception
            LblNotValid.Visible = True
            emailValidation = False
        End Try
    End Sub

    Private Function validatePassword() As Boolean
        If TxtPassword.Text = TxtRetypePassword.Text Then
            LblNotMatch.Visible = False
            Return True
        Else
            LblNotMatch.Visible = True
            Return False
        End If
    End Function
End Class