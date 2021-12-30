
Imports System.Security.Cryptography
    Public Class Login


        Private Sub Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        End Sub


        Private TripleDes As New TripleDESCryptoServiceProvider

        Public Function EncryptData(ByVal plainText As String)

            Dim plaintextbytes() As Byte =
                System.Text.Encoding.Unicode.GetBytes(plainText)

            Dim ms As New System.IO.MemoryStream

            Dim encstream As New CryptoStream(ms, TripleDes.CreateEncryptor(), System.Security.Cryptography.CryptoStreamMode.Write)

            encstream.Write(plaintextbytes, 0, plaintextbytes.Length)
            encstream.FlushFinalBlock()

            Return Convert.ToBase64String(ms.ToArray)

        End Function

        Private Sub ButtonLogin_Click(sender As Object, e As EventArgs) Handles ButtonLogin.Click
            Dim PlainUsername As String = TextBoxUserName.Text
            Dim PlainPassword As String = TextBoxPassword.Text

            Dim AuthStatus As Boolean = Users.CheckAuth(PlainUsername, PlainPassword)
            If AuthStatus Then
                Dim Perpustakaan = New Perpustakaan
                Perpustakaan.Show()
            Else
                MessageBox.Show("Wrong Password")
            End If


        End Sub
    End Class
