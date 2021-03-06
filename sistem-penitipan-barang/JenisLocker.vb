Public Class JenisLocker

    Public Shared ClassJenisLocker As ClassJenisLocker
    Public Shared selectedJenisLockerID As Integer

    Private dataJenisLocker As DataTable

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        ClassJenisLocker = Main.ClassJenisLocker
        ReloadDataTableDatabase()

        'LblUserIdentity.Text = Login.data_user(1).ToString() + "  [ID: " + Login.data_user(0).ToString() + "]"

        If (DataGridViewJenisLocker.Rows.Count > 0) Then
            DataGridViewJenisLocker.Rows(0).Cells(0).Selected = True
            selectedJenisLockerID = DataGridViewJenisLocker.Rows(0).Cells(0).Value
        End If

        LblUserIdentity.Text = Login.data_user(1).ToString() + "  [ID: " + Login.data_user(0).ToString() + "]"

    End Sub

    Private Sub JenisLocker_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        MessageBox.Show("Activated")
        ReloadDataTableDatabase()

        If (DataGridViewJenisLocker.Rows.Count > 0) Then
            DataGridViewJenisLocker.Rows(0).Cells(0).Selected = True
            selectedJenisLockerID = DataGridViewJenisLocker.Rows(0).Cells(0).Value
        End If
    End Sub

    Private Sub ReloadDataTableDatabase()
        dataJenisLocker = ClassJenisLocker.GetDataJenisUkuranDatabase()
        DataGridViewJenisLocker.DataSource = dataJenisLocker
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
        If dataJenisLocker.Rows.Count > 0 Then
            Dim updateJenisLocker = New UpdateJenisLocker
            updateJenisLocker.Show()
        Else
            MessageBox.Show("No data selected")
        End If
    End Sub

    Private Sub BtnHapus_Click(sender As Object, e As EventArgs) Handles BtnHapus.Click
        If dataJenisLocker.Rows.Count > 0 Then
            Dim hapusJenisLocker = New HapusJenisLocker
            hapusJenisLocker.Show()
        Else
            MessageBox.Show("No data selected")
        End If
    End Sub

End Class