Public Class MonitorLocker

    Public Shared Locker As Locker
    Public Shared ClassJenisLocker As ClassJenisLocker

    Private selectedRow As DataGridViewRow
    Private toJenisLocker = False
    Private lockerData As DataTable

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Locker = DataSewa.Locker
        ClassJenisLocker = DataSewa.ClassJenisLocker
        ReloadDataTableDatabase()

        LblUserIdentity.Text = Login.data_user(1).ToString() + "  [ID: " + Login.data_user(0).ToString() + "]"

        If (DataGridViewMonitorLocker.Rows.Count > 0) Then
            DataGridViewMonitorLocker.Rows(0).Cells(0).Selected = True
            selectedRow = DataGridViewMonitorLocker.Rows(0)
        End If

    End Sub

    Private Sub MonitorLocker_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        ReloadDataTableDatabase()

        If (DataGridViewMonitorLocker.Rows.Count > 0) Then
            DataGridViewMonitorLocker.Rows(0).Cells(0).Selected = True
            selectedRow = DataGridViewMonitorLocker.Rows(0)
        End If
    End Sub

    Private Sub ReloadDataTableDatabase()
        lockerData = Locker.GetDataLockerDatabase()
        DataGridViewMonitorLocker.DataSource = lockerData
    End Sub

    Private Sub DataGridViewMonitorLocker_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridViewMonitorLocker.CellClick
        Dim index As Integer = e.RowIndex
        If (index >= 0) Then
            selectedRow = DataGridViewMonitorLocker.Rows(index)
        End If
    End Sub

    Private Sub DataSewaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DataSewaToolStripMenuItem.Click
        Me.Close()
        DataSewa.Show()
    End Sub

    Private Sub MonitorLockerToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MonitorLockerToolStripMenuItem.Click
        Me.Show()
    End Sub

    Private Sub JenisLockerToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles JenisLockerToolStripMenuItem.Click
        toJenisLocker = True
        Me.Close()
        Dim jenisLocker = New JenisLocker
        jenisLocker.Show()
    End Sub

    Private Sub BtnEditLocker_Click(sender As Object, e As EventArgs) Handles BtnEditLocker.Click
        If lockerData.Rows.Count > 0 Then
            UpdateLocalLockerData()

            Dim editLocker = New EditLocker
            editLocker.Show()
        Else
            MessageBox.Show("No data selected")
        End If
    End Sub

    Private Sub BtnUpdateStatus_Click(sender As Object, e As EventArgs) Handles BtnUpdateStatus.Click
        If lockerData.Rows.Count > 0 Then
            UpdateLocalLockerData()

            Dim updateStatus = New UpdateStatusLocker
            updateStatus.Show()
        Else
            MessageBox.Show("No data selected")
        End If
    End Sub

    Private Sub BtnTambah_Click(sender As Object, e As EventArgs) Handles BtnTambah.Click
        Dim dataJenisLocker = MonitorLocker.ClassJenisLocker.GetDataJenisUkuranDatabase()
        If dataJenisLocker.Rows.Count < 1 Then
            MessageBox.Show("Belum ada data jenis locker, harap buat jenis locker terlebih dahulu!")
        Else
            Dim tambahLocker = New TambahLocker
            tambahLocker.Show()
        End If
    End Sub

    Private Sub BtnHapus_Click(sender As Object, e As EventArgs) Handles BtnHapus.Click
        If lockerData.Rows.Count > 0 Then
            UpdateLocalLockerData()

            Dim hapusLocker = New HapusLocker
            hapusLocker.Show()
        Else
            MessageBox.Show("No data selected")
        End If
    End Sub

    Private Sub MonitorLocker_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        If Not toJenisLocker Then
            DataSewa.Show()
        End If
    End Sub

    Private Function UpdateLocalLockerData()
        Locker.IDLockerProperty = selectedRow.Cells(0).Value
        Locker.NamaLockerProperty = selectedRow.Cells(1).Value
        ClassJenisLocker.ukuranJenisLocker = selectedRow.Cells(2).Value
        Locker.LokasiProperty = selectedRow.Cells(4).Value
        Locker.StatusProperty = selectedRow.Cells(5).Value
    End Function

End Class