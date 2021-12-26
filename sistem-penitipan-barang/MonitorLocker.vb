Public Class MonitorLocker
    Private Sub BtnEditLocker_Click(sender As Object, e As EventArgs) Handles BtnEditLocker.Click
        Dim editLocker = New EditLocker
        editLocker.Show()
    End Sub
End Class