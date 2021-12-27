Public Class DataSewa
    Private Sub MonitorLockerToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MonitorLockerToolStripMenuItem.Click
        Dim monitorLocker = New MonitorLocker
        monitorLocker.Show()
        Me.Hide()
    End Sub

    Private Sub DataSewaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DataSewaToolStripMenuItem.Click
        Me.Show()
    End Sub

    Private Sub BtnTambahData_Click(sender As Object, e As EventArgs) Handles BtnTambahData.Click
        Dim tambahSewa = New AddSewa
        tambahSewa.Show()
    End Sub

    Private Sub DataSewa_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        Me.CenterToScreen()
    End Sub

    Private Sub BtnPengembalian_Click(sender As Object, e As EventArgs) Handles BtnPengembalian.Click
        Dim pengembalianBarang = New PengembalianBarang
        pengembalianBarang.Show()
    End Sub
End Class