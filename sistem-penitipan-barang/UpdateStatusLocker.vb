Public Class UpdateStatusLocker
    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Dim status = MonitorLocker.Locker.GetLockerInformationByID(MonitorLocker.selectedLockerID)(3)

        titleLbl.Text = "Locker " & MonitorLocker.selectedLockerNama

        If String.Compare(status, "Kosong") = 0 Then
            RDKosong.Checked = True
        ElseIf String.Compare(status, "Terisi") = 0 Then
            RDTerisi.Checked = True
        End If
    End Sub

    Private Sub BtnUpdateStatus_Click(sender As Object, e As EventArgs) Handles BtnUpdateStatus.Click
        If RDKosong.Checked = True Then
            MonitorLocker.Locker.UpdateLockerStatusByID(MonitorLocker.selectedLockerID, "Kosong")
        ElseIf RDTerisi.Checked = True Then
            MonitorLocker.Locker.UpdateLockerStatusByID(MonitorLocker.selectedLockerID, "Terisi")
        End If

        Me.Close()
    End Sub
End Class