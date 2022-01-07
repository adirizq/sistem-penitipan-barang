Public Class TambahLocker
    Private dataJenisLocker As DataTable
    Private selectedIndexUkuran As Integer
    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        dataJenisLocker = MonitorLocker.ClassJenisLocker.GetDataJenisUkuranDatabase()
        CBUkuran.DataSource = dataJenisLocker
        CBUkuran.DisplayMember = "Ukuran"

        selectedIndexUkuran = CBUkuran.SelectedIndex
        LblBiayaSewaValue.Text = dataJenisLocker.Rows(selectedIndexUkuran)("Biaya").ToString()

    End Sub

    Private Sub CBUkuran_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CBUkuran.SelectedIndexChanged
        selectedIndexUkuran = CBUkuran.SelectedIndex
        LblBiayaSewaValue.Text = dataJenisLocker.Rows(selectedIndexUkuran)("Biaya").ToString()
    End Sub

    Private Sub btnTambah_Click(sender As Object, e As EventArgs) Handles btnTambah.Click
        If TxtNamaLocker.TextLength > 0 And TxtLokasi.TextLength > 0 Then
            Dim nama = TxtNamaLocker.Text
            Dim lokasi = TxtLokasi.Text
            Dim id_ukuran = dataJenisLocker.Rows(selectedIndexUkuran)("id")

            MonitorLocker.Locker.InsertDataLocker(id_ukuran, nama, lokasi)
            Me.Close()
        Else
            MessageBox.Show("Harap isi semua form")
        End If
    End Sub
End Class