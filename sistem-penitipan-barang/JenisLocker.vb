Public Class JenisLocker

    Public Shared ClassJenisLocker As ClassJenisLocker
    Public Shared selectedJenisLockerID As Integer

    Private toMonitorLocker = False

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        ClassJenisLocker = DataSewa.ClassJenisLocker
        ReloadDataTableDatabase()

        If (DataGridViewJenisLocker.Rows.Count > 0) Then
            DataGridViewJenisLocker.Rows(0).Cells(0).Selected = True
            selectedJenisLockerID = DataGridViewJenisLocker.Rows(0).Cells(0).Value
        End If

    End Sub

    Private Sub JenisLocker_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        ReloadDataTableDatabase()

        If (DataGridViewJenisLocker.Rows.Count > 0) Then
            DataGridViewJenisLocker.Rows(0).Cells(0).Selected = True
            selectedJenisLockerID = DataGridViewJenisLocker.Rows(0).Cells(0).Value
        End If
    End Sub

    Private Sub ReloadDataTableDatabase()
        DataGridViewJenisLocker.DataSource = ClassJenisLocker.GetDataJenisUkuranDatabase()
    End Sub

    Private Sub DataGridViewJenisLocker_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridViewJenisLocker.CellClick
        Dim index As Integer = e.RowIndex
        Dim selectedRow As DataGridViewRow
        If (index >= 0) Then
            selectedRow = DataGridViewJenisLocker.Rows(index)
            selectedJenisLockerID = selectedRow.Cells(0).Value
        End If
    End Sub

    Private Sub BtnTambah_Click(sender As Object, e As EventArgs) Handles BtnTambah.Click
        Dim tambahJenisLocker = New TambahJenisLocker
        tambahJenisLocker.Show()
    End Sub

    Private Sub BtnUpdate_Click(sender As Object, e As EventArgs) Handles BtnUpdate.Click
        Dim updateJenisLocker = New UpdateJenisLocker
        updateJenisLocker.Show()
    End Sub

    Private Sub BtnHapus_Click(sender As Object, e As EventArgs) Handles BtnHapus.Click
        Dim hapusJenisLocker = New HapusJenisLocker
        hapusJenisLocker.Show()
    End Sub

    Private Sub DataSewaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DataSewaToolStripMenuItem.Click
        Me.Close()
        DataSewa.Show()
    End Sub

    Private Sub MonitorLockerToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MonitorLockerToolStripMenuItem.Click
        toMonitorLocker = True
        Me.Close()
        Dim monitorLocker = New MonitorLocker
        monitorLocker.Show()
    End Sub

    Private Sub JenisLockerToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles JenisLockerToolStripMenuItem.Click
        Me.Show()
    End Sub

    Private Sub JenisLocker_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        If Not toMonitorLocker Then
            DataSewa.Show()
        End If
    End Sub
End Class