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

    Private Sub TxtBiaya_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtBiaya.KeyPress
        If Not Char.IsNumber(e.KeyChar) And Not e.KeyChar = Chr(Keys.Delete) And Not e.KeyChar = Chr(Keys.Back) Then
            e.Handled = True
            MessageBox.Show("Masukan Hanya Angka")
        End If
    End Sub

End Class