Public Class DataSewa
    Private Sub MonitorLockerToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MonitorLockerToolStripMenuItem.Click
        Dim monitorLocker = New MonitorLocker
        monitorLocker.Show()
        Me.Hide()
    End Sub

    Private Sub DataSewaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DataSewaToolStripMenuItem.Click
        Me.Show()
    End Sub
End Class