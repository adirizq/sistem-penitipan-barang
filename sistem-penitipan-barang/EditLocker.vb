Public Class EditLocker

    Private jenisUkuran
    Private lockerInfo
    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        jenisUkuran = MonitorLocker.Locker.GetJenisUkuranInformation()
        lockerInfo = MonitorLocker.Locker.GetLockerInformationByID(MonitorLocker.selectedLockerID)

        LblLockerIdTitle.Text = MonitorLocker.selectedLockerID

        CBUkuran.Items.Clear()

        For Each ukuran In jenisUkuran
            CBUkuran.Items.Add(ukuran(1))
            If ukuran(0) = lockerInfo(1) Then
                CBUkuran.SelectedItem = ukuran(1)
                LblBiayaValue.Text = "Rp." & ukuran(2) & "/Jam"
            End If
        Next

        TxtLokasi.Text = lockerInfo(2)

    End Sub

    Private Sub CBUkuran_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CBUkuran.SelectedIndexChanged
        Dim selectedItem = CBUkuran.SelectedItem()

        For Each ukuran In jenisUkuran
            If ukuran(1) = selectedItem Then
                CBUkuran.SelectedItem = ukuran(1)
                LblBiayaValue.Text = "Rp." & ukuran(2) & "/Jam"
            End If
        Next
    End Sub

    Private Sub BtnUpdateLocker_Click(sender As Object, e As EventArgs) Handles BtnUpdateLocker.Click
        Dim idUkuranNew As Integer
        Dim lokasNew = TxtLokasi.Text

        Dim selectedItem = CBUkuran.SelectedItem()

        For Each ukuran In jenisUkuran
            If ukuran(1) = selectedItem Then
                idUkuranNew = ukuran(0)
            End If
        Next

        MonitorLocker.Locker.UpdateLockerDataByID(MonitorLocker.selectedLockerID, idUkuranNew, lokasNew)

        Me.Close()
    End Sub
End Class