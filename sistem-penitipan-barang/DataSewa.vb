﻿Public Class DataSewa

    Public Shared Sewa As Sewa
    Public Shared Locker As Locker

    Public Shared selectedLockerID As Integer

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Sewa = New Sewa()
        Locker = New Locker()

        ReloadDataTableDatabase()

        If (DataGridViewDataSewa.Rows.Count > 0) Then
            DataGridViewDataSewa.Rows(0).Cells(0).Selected = True
            selectedLockerID = DataGridViewDataSewa.Rows(0).Cells(0).Value
        End If

    End Sub

    Private Sub ReloadDataTableDatabase()
        DataGridViewDataSewa.DataSource = Sewa.GetDataSewaDatabase()
    End Sub

    Private Sub DataSewa_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        Me.CenterToScreen()

        ReloadDataTableDatabase()

        If (DataGridViewDataSewa.Rows.Count > 0) Then
            DataGridViewDataSewa.Rows(0).Cells(0).Selected = True
            selectedLockerID = DataGridViewDataSewa.Rows(0).Cells(0).Value
        End If
    End Sub

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

    Private Sub BtnPengembalian_Click(sender As Object, e As EventArgs) Handles BtnPengembalian.Click
        Dim pengembalianBarang = New PengembalianBarang
        pengembalianBarang.Show()
    End Sub
End Class