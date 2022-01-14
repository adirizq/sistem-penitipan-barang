Public Class PengembalianBarang
    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        LblNoSewaValue.Text = DataSewa.Sewa.IDSewaProperty
        LblNamaLockerValue.Text = DataSewa.Locker.NamaLockerProperty

        Dim waktuPenyewaan As Date = DataSewa.Sewa.TglSewaProperty
        Dim durasiTs As TimeSpan = DateAndTime.Now - waktuPenyewaan
        Dim totalDurasiJam As Integer = Math.Ceiling(Convert.ToInt32(durasiTs.TotalMinutes) / 60)

        If totalDurasiJam > DataSewa.Sewa.LamaPinjamProperty Then
            LblKeterlambatanValue.Text = (totalDurasiJam - DataSewa.Sewa.LamaPinjamProperty).ToString() + " Jam"
            LblDendaValue.Text = "Rp." + (Integer.Parse(DataSewa.Sewa.DendaProperty).ToString("#,#"))
        Else
            LblKeterlambatanValue.Text = "0 Jam"
            LblDendaValue.Text = "Rp.0"
        End If

    End Sub

    Private Sub btnKonfirmasi_Click(sender As Object, e As EventArgs) Handles btnKonfirmasi.Click
        DataSewa.Locker.IDLockerProperty = DataSewa.Sewa.GetIdLockerByIDSewa(DataSewa.Sewa.IDSewaProperty)

        DataSewa.Sewa.UpdatePengembalianSewaByID(DataSewa.Sewa.IDSewaProperty, DataSewa.Locker.IDLockerProperty)
        Me.Close()
    End Sub
End Class