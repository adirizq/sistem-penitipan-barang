Public Class HapusJenisLocker

    Private Sub BtnKembali_Click(sender As Object, e As EventArgs) Handles BtnKembali.Click
        Dim BukaJenisLocker = New JenisLocker()
        BukaJenisLocker.Show()
        Me.Close()
    End Sub

    Private Sub BtnHapus_Click(sender As Object, e As EventArgs) Handles BtnHapus.Click
        JenisLocker.ClassJenisLocker.DeleteJenisUkuranByID(JenisLocker.selectedJenisLockerID)
        Me.Close()
    End Sub
End Class