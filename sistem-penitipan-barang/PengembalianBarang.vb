Public Class PengembalianBarang

    Private dataSewaInformation As List(Of String)

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        dataSewaInformation = DataSewa.Sewa.GetDataSewaByID(DataSewa.selectedSewaID)

        LblNoSewaValue.Text = dataSewaInformation(0)
        LblNoLockerValue.Text = dataSewaInformation(1)

        Dim waktuPenyewaan As Date = dataSewaInformation(2)
        Dim durasiTs As TimeSpan = DateAndTime.Now - waktuPenyewaan
        Dim totalDurasiJam As Integer = Math.Ceiling(Convert.ToInt32(durasiTs.TotalMinutes) / 60)

        If totalDurasiJam > dataSewaInformation(5) Then
            LblKeterlambatanValue.Text = (totalDurasiJam - dataSewaInformation(5)).ToString() + " Jam"
            LblDendaValue.Text = "Rp." + (Integer.Parse(dataSewaInformation(6)).ToString("#,#"))
        Else
            LblKeterlambatanValue.Text = "0 Jam"
            LblDendaValue.Text = "Rp.0"
        End If

    End Sub

    Private Sub btnKonfirmasi_Click(sender As Object, e As EventArgs) Handles btnKonfirmasi.Click
        DataSewa.Sewa.UpdatePengembalianSewaByID(dataSewaInformation(0), dataSewaInformation(1))
        Me.Close()
    End Sub
End Class