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
        Dim totalDurasi As TimeSpan = DateAndTime.Now - waktuPenyewaan

        Dim durasiInt = Convert.ToInt32(totalDurasi.TotalHours)

        LblDendaValue.Text = durasiInt.ToString()
        LblLokasiValue.Text = totalDurasi.ToString()
        LblDenda.Text = (Convert.ToInt32(totalDurasi.TotalMinutes) Mod 60).ToString()

    End Sub

End Class