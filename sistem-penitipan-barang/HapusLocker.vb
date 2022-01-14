Public Class HapusLocker

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        LblLockerValue.Text = "Locker " & MonitorLocker.Locker.NamaLockerProperty
        LblIDValue.Text = "ID Locker: " & MonitorLocker.Locker.IDLockerProperty

    End Sub

    Private Sub BtnHapus_Click(sender As Object, e As EventArgs) Handles BtnHapus.Click
        MonitorLocker.Locker.DeleteDataLocker(MonitorLocker.Locker.IDLockerProperty)
        Me.Close()
    End Sub

    Private Sub BtnKembali_Click(sender As Object, e As EventArgs) Handles BtnKembali.Click
        Me.Close()
    End Sub
End Class