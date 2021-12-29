Public Class HapusJenisLocker

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Dim jenisLockerInformation = JenisLocker.ClassJenisLocker.GetJenisUkuranInformationByID(JenisLocker.selectedJenisLockerID)

        LblJenisLockerValue.Text = jenisLockerInformation(1).ToString()
        LblBiayaValue.Text = "(Rp." + (Integer.Parse(jenisLockerInformation(2))).ToString("#,#") + "/Jam)"

    End Sub

    Private Sub BtnKembali_Click(sender As Object, e As EventArgs) Handles BtnKembali.Click
        Me.Close()
    End Sub

    Private Sub BtnHapus_Click(sender As Object, e As EventArgs) Handles BtnHapus.Click
        JenisLocker.ClassJenisLocker.DeleteJenisUkuranByID(JenisLocker.selectedJenisLockerID)
        Me.Close()
    End Sub

End Class