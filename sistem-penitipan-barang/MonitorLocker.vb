﻿Public Class MonitorLocker

    Public Shared Locker As Locker

    Public Shared selectedLockerID As Integer

    Private toJenisLocker = False

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Locker = DataSewa.Locker
        ReloadDataTableDatabase()

        LblUserIdentity.Text = Login.data_user(1).ToString() + "  [ID: " + Login.data_user(0).ToString() + "]"

        If (DataGridViewMonitorLocker.Rows.Count > 0) Then
            DataGridViewMonitorLocker.Rows(0).Cells(0).Selected = True
            selectedLockerID = DataGridViewMonitorLocker.Rows(0).Cells(0).Value
        End If

    End Sub

    Private Sub MonitorLocker_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        ReloadDataTableDatabase()

        If (DataGridViewMonitorLocker.Rows.Count > 0) Then
            DataGridViewMonitorLocker.Rows(0).Cells(0).Selected = True
            selectedLockerID = DataGridViewMonitorLocker.Rows(0).Cells(0).Value
        End If
    End Sub

    Private Sub ReloadDataTableDatabase()
        DataGridViewMonitorLocker.DataSource = Locker.GetDataLockerDatabase()
    End Sub

    Private Sub DataGridViewMonitorLocker_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridViewMonitorLocker.CellClick
        Dim index As Integer = e.RowIndex
        Dim selectedRow As DataGridViewRow
        If (index >= 0) Then
            selectedRow = DataGridViewMonitorLocker.Rows(index)
            selectedLockerID = selectedRow.Cells(0).Value
        End If
    End Sub

    Private Sub BtnEditLocker_Click(sender As Object, e As EventArgs) Handles BtnEditLocker.Click
        Dim editLocker = New EditLocker
        editLocker.Show()
    End Sub

    Private Sub BtnUpdateStatus_Click(sender As Object, e As EventArgs) Handles BtnUpdateStatus.Click
        Dim updateStatus = New UpdateStatusLocker
        updateStatus.Show()
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

    Private Sub MonitorLocker_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        If Not toJenisLocker Then
            DataSewa.Show()
        End If
    End Sub

End Class