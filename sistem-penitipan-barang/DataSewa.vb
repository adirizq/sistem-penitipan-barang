Public Class DataSewa

    Public Shared Sewa As Sewa
    Public Shared Locker As Locker
    Public Shared ClassJenisLocker As ClassJenisLocker

    Public Shared selectedSewaID As Integer

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Sewa = New Sewa()
        Locker = New Locker()
        ClassJenisLocker = New ClassJenisLocker()

        ReloadDataTableDatabase()

        If (DataGridViewDataSewa.Rows.Count > 0) Then
            selectedSewaID = DataGridViewDataSewa.Rows(0).Cells(0).Value
        End If

    End Sub

    Private Sub ReloadDataTableDatabase()
        DataGridViewDataSewa.DataSource = Sewa.GetDataSewaDatabase()
    End Sub

    Private Sub DataSewa_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        Me.CenterToScreen()

        ReloadDataTableDatabase()

        If (DataGridViewDataSewa.Rows.Count > 0) Then
            DataGridViewDataSewa.CurrentCell = DataGridViewDataSewa.Rows(0).Cells(0)
            selectedSewaID = DataGridViewDataSewa.Rows(0).Cells(0).Value
        End If
    End Sub

    Private Sub DataSewaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DataSewaToolStripMenuItem.Click
        Me.Show()
    End Sub

    Private Sub MonitorLockerToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MonitorLockerToolStripMenuItem.Click
        Dim monitorLocker = New MonitorLocker
        monitorLocker.Show()
        Me.Hide()
    End Sub

    Private Sub JenisLockerToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles JenisLockerToolStripMenuItem.Click
        Dim jenisLocker = New JenisLocker
        jenisLocker.Show()
        Me.Hide()
    End Sub

    Private Sub BtnTambahData_Click(sender As Object, e As EventArgs) Handles BtnTambahData.Click
        Dim tambahSewa = New AddSewa
        tambahSewa.Show()
    End Sub

    Private Sub BtnPengembalian_Click(sender As Object, e As EventArgs) Handles BtnPengembalian.Click
        If DataSewa.Sewa.GetDataSewaByID(DataSewa.selectedSewaID)(3) = "" Then
            Debug.WriteLine("Kosong")
            Dim pengembalianBarang = New PengembalianBarang
            pengembalianBarang.Show()
        Else
            MessageBox.Show("Barang sudah dikembalikan ke pemilik barang")
            Debug.WriteLine(DataSewa.Sewa.GetDataSewaByID(DataSewa.selectedSewaID)(3))
        End If
    End Sub

    Private Sub DataGridViewDataSewa_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridViewDataSewa.CellClick
        Dim index As Integer = e.RowIndex
        Dim selectedRow As DataGridViewRow
        If (index >= 0) Then
            selectedRow = DataGridViewDataSewa.Rows(index)
            selectedSewaID = selectedRow.Cells(0).Value
        End If
    End Sub

End Class