Public Class DataSewa

    Public Shared Sewa As Sewa
    Public Shared Locker As Locker
    Public Shared ClassJenisLocker As ClassJenisLocker

    Private selectedRow As DataGridViewRow
    Private dataSewaDt As DataTable
    Private signOut = False

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Sewa = New Sewa()
        Locker = New Locker()
        ClassJenisLocker = New ClassJenisLocker()

        LblUserIdentity.Text = Login.data_user(1).ToString() + "  [ID: " + Login.data_user(0).ToString() + "]"

        ReloadDataTableDatabase()

        If (DataGridViewDataSewa.Rows.Count > 0) Then
            DataGridViewDataSewa.CurrentCell = DataGridViewDataSewa.Rows(0).Cells(0)
            selectedRow = DataGridViewDataSewa.Rows(0)
        End If

    End Sub

    Private Sub ReloadDataTableDatabase()
        dataSewaDt = Sewa.GetDataSewaDatabase()
        DataGridViewDataSewa.DataSource = dataSewaDt
    End Sub

    Private Sub DataSewa_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        Me.CenterToScreen()

        ReloadDataTableDatabase()

        If (DataGridViewDataSewa.Rows.Count > 0) Then
            DataGridViewDataSewa.CurrentCell = DataGridViewDataSewa.Rows(0).Cells(0)
            selectedRow = DataGridViewDataSewa.Rows(0)
        End If

        signOut = False
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
        Dim dataJenisLocker = DataSewa.ClassJenisLocker.GetDataJenisUkuranDatabase()
        If dataJenisLocker.Rows.Count < 1 Then
            MessageBox.Show("Belum ada data locker, harap buat locker terlebih dahulu!")
        Else
            Dim tambahSewa = New AddSewa
            tambahSewa.Show()
        End If
    End Sub

    Private Sub BtnPengembalian_Click(sender As Object, e As EventArgs) Handles BtnPengembalian.Click
        If dataSewaDt.Rows.Count > 0 Then
            If IsDBNull(selectedRow.Cells(3).Value) Then
                Sewa.IDSewaProperty = selectedRow.Cells(0).Value
                Locker.NamaLockerProperty = selectedRow.Cells(1).Value
                Sewa.TglSewaProperty = selectedRow.Cells(2).Value
                Sewa.LamaPinjamProperty = getNumeric(selectedRow.Cells(5).Value)
                Sewa.DendaProperty = getNumeric(selectedRow.Cells(6).Value)

                Dim pengembalianBarang = New PengembalianBarang
                pengembalianBarang.Show()
            Else
                MessageBox.Show("Barang sudah dikembalikan ke pemilik barang")
            End If
        Else
            MessageBox.Show("No data selected")
        End If
    End Sub

    Private Sub DataGridViewDataSewa_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridViewDataSewa.CellClick
        Dim index As Integer = e.RowIndex
        If (index >= 0) Then
            selectedRow = DataGridViewDataSewa.Rows(index)
        End If
    End Sub

    Private Sub BtnSignOut_Click(sender As Object, e As EventArgs) Handles BtnSignOut.Click
        Dim result As DialogResult = MessageBox.Show("Are you sure you want to sign out?", "Confirmation", MessageBoxButtons.YesNo)
        If result = DialogResult.Yes Then
            signOut = True
            Login.Show()
            Me.Close()
        End If
    End Sub

    Private Sub DataSewa_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        If Not signOut Then
            Login.Close()
        End If
    End Sub

    Public Function getNumeric(value As String) As Integer
        Dim output As New System.Text.StringBuilder
        For i = 0 To value.Length - 1
            If IsNumeric(value(i)) Then
                output.Append(value(i))
            End If
        Next
        Return Integer.Parse(output.ToString())
    End Function
End Class