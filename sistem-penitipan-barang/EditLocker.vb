Public Class EditLocker

    Private dataJenisLocker As DataTable
    Private selectedIndexUkuran As Integer

    Private jenisUkuran
    Private lockerInfo
    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        dataJenisLocker = MonitorLocker.ClassJenisLocker.GetDataJenisUkuranDatabase()
        lockerInfo = MonitorLocker.Locker.GetLockerInformationByID(MonitorLocker.selectedLockerID)

        CBUkuran.DataSource = dataJenisLocker
        CBUkuran.DisplayMember = "Ukuran"

        titleLbl.Text = "Locker " & MonitorLocker.selectedLockerNama
        LblID.Text = MonitorLocker.selectedLockerID

        selectedIndexUkuran = CBUkuran.SelectedIndex
        LblBiayaValue.Text = dataJenisLocker.Rows(selectedIndexUkuran)("Biaya")

        TxtNama.Text = lockerInfo(2)
        TxtLokasi.Text = lockerInfo(3)

    End Sub

    Private Sub CBUkuran_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CBUkuran.SelectedIndexChanged
        selectedIndexUkuran = CBUkuran.SelectedIndex
        LblBiayaValue.Text = dataJenisLocker.Rows(selectedIndexUkuran)("Biaya")
    End Sub

    Private Sub BtnUpdateLocker_Click(sender As Object, e As EventArgs) Handles BtnUpdateLocker.Click
        Dim idUkuranNew = dataJenisLocker.Rows(selectedIndexUkuran)("id")
        Dim namaNew = TxtNama.Text
        Dim lokasiNew = TxtLokasi.Text

        Dim selectedItem = CBUkuran.SelectedItem()

        MonitorLocker.Locker.UpdateLockerDataByID(MonitorLocker.selectedLockerID, idUkuranNew, namaNew, lokasiNew)

        Me.Close()
    End Sub

End Class