Public Class Login

    Public Shared User As User
    Public Shared data_user As List(Of String)

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        User = New User()

    End Sub


    Private Sub ButtonSignUp_Click(sender As Object, e As EventArgs) Handles ButtonSignUp.Click
        Me.Hide()
        Dim register = New Register
        register.Show()
    End Sub


    Private Sub ButtonSignIn_Click(sender As Object, e As EventArgs) Handles ButtonSignIn.Click
        Dim plainUsername As String = TextBoxUsername1.Text
        Dim plainPassword As String = TextBoxPassword1.Text

        data_user = User.CheckAuthDatabase(plainUsername, plainPassword)

        If data_user.Count > 0 Then
            User.GSUsername = data_user(1)
            Dim Main As Main = New Main()
            Main.Show()
            Me.Hide()
        Else
            MessageBox.Show("Wrong username or password")
        End If

    End Sub


    Private Sub Login_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        TextBoxUsername1.Text = ""
        TextBoxPassword1.Text = ""
    End Sub

End Class
