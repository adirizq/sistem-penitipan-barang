﻿Public Class AddSewa
    Private jenisUkuran
    Private lockerInfo
    Private availabeLocker
    Private validData
    Private biayaPerjam


    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        validData = True

        jenisUkuran = DataSewa.Locker.GetJenisUkuranInformation()
        CBUkuran.Items.Clear()
        For Each ukuran In jenisUkuran
            CBUkuran.Items.Add(ukuran(1))
        Next
        CBUkuran.SelectedIndex() = 0

        UpdateAvailableLocker()

    End Sub

    Private Sub CBUkuran_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CBUkuran.SelectedIndexChanged
        UpdateAvailableLocker()
        biayaPerjam = DataSewa.Locker.GetJenisUkuranInformationByUkuran(CBUkuran.SelectedItem())(2)
        If (TxtLamaSewa.TextLength > 0) Then
            Dim txtBiaya = (biayaPerjam * Integer.Parse(TxtLamaSewa.Text))
            LblBiayaSewaValue.Text = "Rp." & txtBiaya
        Else
            LblBiayaSewaValue.Text = "Rp.0"
        End If
    End Sub

    Private Sub TxtLamaSewa_TextChanged(sender As Object, e As EventArgs) Handles TxtLamaSewa.TextChanged
        biayaPerjam = DataSewa.Locker.GetJenisUkuranInformationByUkuran(CBUkuran.SelectedItem())(2)
        If (TxtLamaSewa.TextLength > 0) Then
            Dim txtBiaya = (biayaPerjam * Integer.Parse(TxtLamaSewa.Text))
            LblBiayaSewaValue.Text = "Rp." & txtBiaya
        Else
            LblBiayaSewaValue.Text = "Rp.0"
        End If
    End Sub

    Private Sub UpdateAvailableLocker()
        availabeLocker = DataSewa.Locker.GetDataAvailableLockerByUkuran(CBUkuran.SelectedItem())
        CBLocker.Items.Clear()
        CBLocker.Enabled = True
        validData = True
        For Each locker In availabeLocker
            CBLocker.Items.Add(locker)
        Next
        If CBLocker.Items.Count = 0 Then
            CBLocker.Items.Add("Semua Locker Sudah Terisi")
            CBLocker.Enabled = False
            validData = False
        End If
        CBLocker.SelectedIndex() = 0
    End Sub

    Private Sub btnTambah_Click(sender As Object, e As EventArgs) Handles btnTambah.Click
        If (validData And TxtLamaSewa.TextLength > 0) Then
            DataSewa.Sewa.InsertDataSewaDatabase(CBLocker.SelectedItem(), (Integer.Parse(TxtLamaSewa.Text)) * biayaPerjam, Integer.Parse(TxtLamaSewa.Text))
            Me.Close()
        Else
            MessageBox.Show("Harap pilih nomor locker dan isi lama durasi sewa")
        End If
    End Sub


End Class