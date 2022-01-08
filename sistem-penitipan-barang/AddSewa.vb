Public Class AddSewa
    Private validData
    Private biayaPerjam As Integer
    Private availabeLocker As DataTable
    Private dataJenisLocker As DataTable
    Private selectedIndexUkuran As Integer

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        validData = True

        dataJenisLocker = DataSewa.ClassJenisLocker.GetDataJenisUkuranDatabase()
        CBUkuran.DataSource = dataJenisLocker
        CBUkuran.DisplayMember = "Ukuran"

        selectedIndexUkuran = CBUkuran.SelectedIndex
        biayaPerjam = GetIntegerValue(dataJenisLocker.Rows(selectedIndexUkuran)("Biaya").ToString())

        UpdateAvailableLocker()

    End Sub

    Private Sub CBUkuran_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CBUkuran.SelectedIndexChanged
        selectedIndexUkuran = CBUkuran.SelectedIndex
        UpdateAvailableLocker()
        biayaPerjam = GetIntegerValue(dataJenisLocker.Rows(selectedIndexUkuran)("Biaya").ToString())
        If (TxtLamaSewa.TextLength > 0) Then
            Dim totalBiaya = biayaPerjam * Integer.Parse(TxtLamaSewa.Text)
            LblBiayaSewaValue.Text = "Rp." & totalBiaya
        Else
            LblBiayaSewaValue.Text = "Rp.0"
        End If
    End Sub

    Private Sub TxtLamaSewa_TextChanged(sender As Object, e As EventArgs) Handles TxtLamaSewa.TextChanged
        If CBUkuran.Items.Count > 0 Then
            If (TxtLamaSewa.TextLength > 0) Then
                Dim totalBiaya = biayaPerjam * Integer.Parse(TxtLamaSewa.Text)
                LblBiayaSewaValue.Text = "Rp." & totalBiaya
            Else
                LblBiayaSewaValue.Text = "Rp.0"
            End If
        End If
    End Sub

    Private Sub UpdateAvailableLocker()
        availabeLocker = DataSewa.Locker.GetDataAvailableLockerByUkuranID(dataJenisLocker.Rows(selectedIndexUkuran)("ID"))
        CBLocker.Enabled = True
        CBLocker.DataSource = availabeLocker
        CBLocker.DisplayMember = "Nama"
        If CBLocker.Items.Count < 1 Then
            CBLocker.Enabled = False
        End If
    End Sub

    Private Function GetIntegerValue(S As String) As String
        Return New String(S.Where(Function(x As Char) System.Char.IsDigit(x)).ToArray)
    End Function

    Private Sub btnTambah_Click(sender As Object, e As EventArgs) Handles btnTambah.Click
        If CBUkuran.Items.Count > 0 Then
            If (validData And TxtLamaSewa.TextLength > 0) Then
                Dim selectedLockerID = availabeLocker.Rows(CBLocker.SelectedIndex)("ID")
                DataSewa.Sewa.InsertDataSewaDatabase(selectedLockerID, (Integer.Parse(TxtLamaSewa.Text)) * biayaPerjam, Integer.Parse(TxtLamaSewa.Text))
                Me.Close()
            Else
                MessageBox.Show("Harap pilih nomor locker dan isi lama durasi sewa")
            End If
        End If
    End Sub

    Private Sub TxtLamaSewa_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtLamaSewa.KeyPress
        If Not Char.IsNumber(e.KeyChar) And Not e.KeyChar = Chr(Keys.Delete) And Not e.KeyChar = Chr(Keys.Back) Then
            e.Handled = True
            MessageBox.Show("Masukan Hanya Angka")
        End If
    End Sub
End Class