Public Class Login

    Public Shared DataSewa As DataSewa
    Public Shared User As User

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        DataSewa = New DataSewa()
        User = New User()

    End Sub

    Private Sub BtnLogin_Click(sender As Object, e As EventArgs) Handles BtnLogin.Click

        Dim plainUsername As String = TxtUsername.Text
        Dim plainPassword As String = TxtPassword.Text

        Dim data_user As List(Of String) = User.CheckAuthDatabase(plainUsername, plainPassword)

        If data_user.Count > 0 Then
            User.GSUsername = data_user(1)
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

End Class