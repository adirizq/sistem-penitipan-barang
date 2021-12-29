Public Class TambahJenisLocker

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
    End Sub

    Private Sub BtnTambahLocker_Click(sender As Object, e As EventArgs) Handles BtnTambahLocker.Click
        JenisLocker.ClassJenisLocker.ukuranJenisLocker = txtUkuran.Text.ToString()
        JenisLocker.ClassJenisLocker.biayaJenisLocker = Integer.Parse(TxtBiaya.Text)

        JenisLocker.ClassJenisLocker.AddDataJenisUkuranDatabase(JenisLocker.ClassJenisLocker.ukuranJenisLocker,
                                                                JenisLocker.ClassJenisLocker.biayaJenisLocker)

        Me.Close()
    End Sub

    Private Sub TxtBiaya_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtBiaya.KeyPress
        If Not Char.IsNumber(e.KeyChar) And Not e.KeyChar = Chr(Keys.Delete) And Not e.KeyChar = Chr(Keys.Back) Then
            e.Handled = True
            MessageBox.Show("Masukan Hanya Angka")
        End If
    End Sub
End Class