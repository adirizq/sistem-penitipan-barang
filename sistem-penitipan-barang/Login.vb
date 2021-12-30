Public Class Login

    Public Shared DataSewa As DataSewa
    Public Shared User As User
    Public Shared data_user As List(Of String)

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        User = New User()

    End Sub

    Private Sub BtnLogin_Click(sender As Object, e As EventArgs) Handles BtnLogin.Click

        Dim plainUsername As String = TxtUsername.Text
        Dim plainPassword As String = TxtPassword.Text

        data_user = User.CheckAuthDatabase(plainUsername, plainPassword)

        If data_user.Count > 0 Then
            User.GSUsername = data_user(1)
            DataSewa = New DataSewa()
            DataSewa.Show()
            Me.Hide()
        Else
            MessageBox.Show("Wrong username or password")
        End If

    End Sub

    Private Sub BtnRegister_Click(sender As Object, e As EventArgs) Handles BtnRegister.Click
        Me.Hide()
        Dim register = New Register
        register.Show()
    End Sub

    Private Sub Login_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        TxtUsername.Text = ""
        TxtPassword.Text = ""
    End Sub
End Class