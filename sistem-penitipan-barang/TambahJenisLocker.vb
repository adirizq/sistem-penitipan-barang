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
End Class