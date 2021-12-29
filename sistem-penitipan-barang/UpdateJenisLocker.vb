Public Class UpdateJenisLocker
    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Dim jenisLockerInformation = JenisLocker.ClassJenisLocker.GetJenisUkuranInformationByID(JenisLocker.selectedJenisLockerID)

        txtUkuran.Text = jenisLockerInformation(1).ToString()
        TxtBiaya.Text = jenisLockerInformation(2).ToString()
    End Sub

    Private Sub BtnUpdateLocker_Click(sender As Object, e As EventArgs) Handles BtnUpdateLocker.Click
        JenisLocker.ClassJenisLocker.ukuranJenisLocker = txtUkuran.Text.ToString()
        JenisLocker.ClassJenisLocker.biayaJenisLocker = Integer.Parse(TxtBiaya.Text)

        JenisLocker.ClassJenisLocker.UpdateJenisUkuranByID(JenisLocker.selectedJenisLockerID, JenisLocker.ClassJenisLocker.biayaJenisLocker, JenisLocker.ClassJenisLocker.ukuranJenisLocker)

        Me.Close()
    End Sub
End Class