Public Class EditLocker

    Private dataJenisLocker As DataTable
    Private selectedIndexUkuran As Integer

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        dataJenisLocker = MonitorLocker.ClassJenisLocker.GetDataJenisUkuranDatabase()

        CBUkuran.DataSource = dataJenisLocker
        CBUkuran.DisplayMember = "Ukuran"
        CBUkuran.ValueMember = "Ukuran"
        CBUkuran.SelectedValue = MonitorLocker.ClassJenisLocker.ukuranJenisLocker

        titleLbl.Text = "Locker " & MonitorLocker.Locker.NamaLockerProperty

        selectedIndexUkuran = CBUkuran.SelectedIndex
        LblBiayaValue.Text = dataJenisLocker.Rows(selectedIndexUkuran)("Biaya")

        TxtNama.Text = MonitorLocker.Locker.NamaLockerProperty
        TxtLokasi.Text = MonitorLocker.Locker.LokasiProperty

    End Sub

    Private Sub CBUkuran_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CBUkuran.SelectedIndexChanged
        selectedIndexUkuran = CBUkuran.SelectedIndex
        LblBiayaValue.Text = dataJenisLocker.Rows(selectedIndexUkuran)("Biaya")
    End Sub

    Private Sub BtnUpdateLocker_Click(sender As Object, e As EventArgs) Handles BtnUpdateLocker.Click
        Dim idUkuranNew = dataJenisLocker.Rows(selectedIndexUkuran)("id")
        MonitorLocker.Locker.NamaLockerProperty = TxtNama.Text
        MonitorLocker.Locker.LokasiProperty = TxtLokasi.Text

        MonitorLocker.Locker.UpdateLockerDataByID(MonitorLocker.Locker.IDLockerProperty, idUkuranNew, MonitorLocker.Locker.NamaLockerProperty, MonitorLocker.Locker.LokasiProperty)

        Me.Close()
    End Sub

End Class