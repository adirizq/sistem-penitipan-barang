Imports System.ComponentModel

Public Class Main

    Public Shared Sewa As Sewa
    Public Shared Locker As Locker
    Public Shared ClassJenisLocker As ClassJenisLocker

    Private currentChildForm As Form
    Private lastForm As Integer
    Private isSignOut As Boolean

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Sewa = New Sewa()
        Locker = New Locker()
        ClassJenisLocker = New ClassJenisLocker()

        isSignOut = False

        SetSelected(LblSewaSelected, BtnSewa, New DataSewa)
        lastForm = 0

    End Sub

    Private Sub SetSelected(lblSelected As Label, btnSelected As Button, formSelected As Form)
        BtnSewa.ForeColor = Color.FromArgb(153, 199, 202)
        BtnLocker.ForeColor = Color.FromArgb(153, 199, 202)
        BtnJenisLocker.ForeColor = Color.FromArgb(153, 199, 202)

        LblSewaSelected.Visible = False
        LblLockerSelected.Visible = False
        LblJenisLockerSelected.Visible = False

        btnSelected.ForeColor = Color.White

        lblSelected.Visible = True

        OpenChildForm(formSelected)
    End Sub

    Private Sub OpenChildForm(childForm As Form)
        If currentChildForm IsNot Nothing Then
            currentChildForm.Close()
        End If
        currentChildForm = childForm

        childForm.TopLevel = False
        childForm.FormBorderStyle = FormBorderStyle.None

        PanelContent.Controls.Add(childForm)
        PanelContent.Tag = childForm

        childForm.BringToFront()
        childForm.Show()
    End Sub

    Private Sub Main_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        If lastForm = 0 Then
            SetSelected(LblSewaSelected, BtnSewa, New DataSewa)
        ElseIf lastForm = 1 Then
            SetSelected(LblLockerSelected, BtnLocker, New MonitorLocker)
        ElseIf lastForm = 2 Then
            SetSelected(LblJenisLockerSelected, BtnJenisLocker, New JenisLocker)
        End If
    End Sub

    Private Sub BtnSewa_Click(sender As Object, e As EventArgs) Handles BtnSewa.Click
        SetSelected(LblSewaSelected, BtnSewa, New DataSewa)
        lastForm = 0
    End Sub

    Private Sub BtnLocker_Click(sender As Object, e As EventArgs) Handles BtnLocker.Click
        SetSelected(LblLockerSelected, BtnLocker, New MonitorLocker)
        lastForm = 1
    End Sub

    Private Sub BtnJenisLocker_Click(sender As Object, e As EventArgs) Handles BtnJenisLocker.Click
        SetSelected(LblJenisLockerSelected, BtnJenisLocker, New JenisLocker)
        lastForm = 2
    End Sub

    Public Sub SignOut()
        isSignOut = True
        Me.Close()
    End Sub

    Private Sub Main_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        If isSignOut Then
            Login.Show()
        Else
            Application.Exit()
        End If
    End Sub

    Private Sub BtnSignOut_Click(sender As Object, e As EventArgs) Handles BtnSignOut.Click
        Dim result As DialogResult = MessageBox.Show("Are you sure you want to sign out?", "Confirmation", MessageBoxButtons.YesNo)
        If result = DialogResult.Yes Then
            SignOut()
        End If
    End Sub

End Class