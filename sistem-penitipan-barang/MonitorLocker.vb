﻿Public Class MonitorLocker

    Public Shared Locker As Locker
    Public Shared selectedLockerID As Integer

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Locker = New Locker()
        ReloadDataTableDatabase()

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
        selectedRow = DataGridViewMonitorLocker.Rows(index)

        selectedLockerID = selectedRow.Cells(0).Value
    End Sub

    Private Sub BtnEditLocker_Click(sender As Object, e As EventArgs) Handles BtnEditLocker.Click
        Dim editLocker = New EditLocker
        editLocker.Show()
    End Sub

    Private Sub BtnUpdateStatus_Click(sender As Object, e As EventArgs) Handles BtnUpdateStatus.Click
        Dim updateStatus = New UpdateStatusLocker
        updateStatus.Show()
    End Sub


End Class