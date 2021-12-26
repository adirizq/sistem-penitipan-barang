Public Class MonitorLocker
    Private Sub BtnEditLocker_Click(sender As Object, e As EventArgs) Handles BtnEditLocker.Click
        Dim editLocker = New EditLocker
        editLocker.Show()
    End Sub

    Private Sub BtnUpdateStatus_Click(sender As Object, e As EventArgs) Handles BtnUpdateStatus.Click
        Dim updateStatus = New UpdateStatusLocker
        updateStatus.show()
    End Sub
End Class