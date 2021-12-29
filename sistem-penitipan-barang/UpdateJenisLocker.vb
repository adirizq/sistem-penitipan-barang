Public Class UpdateJenisLocker
    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        txtUkuran.Text = JenisLocker.ClassJenisLocker.ukuranJenisLocker
        TxtBiaya.Text = JenisLocker.ClassJenisLocker.biayaJenisLocker
    End Sub

    Private Sub BtnUpdateLocker_Click(sender As Object, e As EventArgs) Handles BtnUpdateLocker.Click
        JenisLocker.ClassJenisLocker.ukuranJenisLocker = txtUkuran.Text.ToString()
        JenisLocker.ClassJenisLocker.biayaJenisLocker = Integer.Parse(TxtBiaya.Text)

        JenisLocker.ClassJenisLocker.UpdateJenisUkuranByID(JenisLocker.selectedJenisLockerID, JenisLocker.ClassJenisLocker.biayaJenisLocker, JenisLocker.ClassJenisLocker.ukuranJenisLocker)

        Dim BukaJenisLocker = New JenisLocker()
        BukaJenisLocker.Show()
        Me.Close()
    End Sub
End Class