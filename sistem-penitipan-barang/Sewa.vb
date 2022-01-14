Imports MySql.Data.MySqlClient
Public Class Sewa

    Public Shared dbConn As New MySqlConnection
    Public Shared sqlCommand As New MySqlCommand
    Public Shared sqlRead As MySqlDataReader
    Private sqlQuery As String

    Private server As String = "127.0.0.1"
    Private username As String = "root"
    Private password As String = ""
    Private database As String = "sistem_penitipan_barang"

    Private idSewa As Integer
    Private tglSewa As Date
    Private tglKembali As Date
    Private tagihanAwal As Integer
    Private lamaPinjam As Integer
    Private denda As Integer
    Private totalTagihan As Integer

    Public Property IDSewaProperty() As Integer
        Get
            Return idSewa
        End Get
        Set(ByVal value As Integer)
            idSewa = value
        End Set
    End Property

    Public Property TglSewaProperty() As Date
        Get
            Return tglSewa
        End Get
        Set(ByVal value As Date)
            tglSewa = value
        End Set
    End Property

    Public Property TglKembaliProperty() As Date
        Get
            Return tglKembali
        End Get
        Set(ByVal value As Date)
            tglKembali = value
        End Set
    End Property

    Public Property TagihanAwalProperty() As Integer
        Get
            Return tagihanAwal
        End Get
        Set(ByVal value As Integer)
            tagihanAwal = value
        End Set
    End Property

    Public Property LamaPinjamProperty() As Integer
        Get
            Return lamaPinjam
        End Get
        Set(ByVal value As Integer)
            lamaPinjam = value
        End Set
    End Property

    Public Property DendaProperty() As Integer
        Get
            Return denda
        End Get
        Set(ByVal value As Integer)
            denda = value
        End Set
    End Property

    Public Property TotalTagihanProperty() As Integer
        Get
            Return totalTagihan
        End Get
        Set(ByVal value As Integer)
            totalTagihan = value
        End Set
    End Property

    Public Function GetDataSewaDatabase() As DataTable
        Dim result As New DataTable
        Dim data As New DataTable

        Try
            dbConn.ConnectionString = "server =" + server + ";" + "user id=" + username + ";" _
            + "password =" + password + ";" + "database =" + database
            dbConn.Open()
            sqlCommand.Connection = dbConn
            sqlCommand.CommandText = "SELECT
                                        p.id AS 'No Sewa',
                                        l.nama AS 'Nama Locker',
                                        p.tanggal_sewa AS 'Tanggal Sewa',
                                        p.tanggal_kembali AS 'Tanggal Pengembalian',
                                        p.bayar_sebelum_pinjam AS 'Tagihan Normal',
                                        p.rencana_pinjam AS 'Durasi Peminjaman',
                                        p.kelebihan_pinjam AS 'Denda',
                                        p.total_bayar AS 'Total Tagihan'
                                        FROM penyewaan p JOIN locker l ON p.id_locker = l.id"

            sqlRead = sqlCommand.ExecuteReader

            data.Load(sqlRead)
            sqlRead.Close()
            dbConn.Close()

            result = data.Clone()
            result.Columns("Tagihan Normal").DataType = GetType(String)
            result.Columns("Durasi Peminjaman").DataType = GetType(String)
            result.Columns("Denda").DataType = GetType(String)
            result.Columns("Total Tagihan").DataType = GetType(String)

            For Each row In data.Rows
                result.ImportRow(row)
            Next

            For Each row In result.Rows
                If IsDBNull(row(3)) Then
                    Dim waktuPenyewaan As Date = row(2)
                    Dim durasiTs As TimeSpan = DateAndTime.Now - waktuPenyewaan
                    Dim totalDurasiJam As Integer = Math.Ceiling(Convert.ToInt32(durasiTs.TotalMinutes) / 60)

                    Dim tagihanNormal = row(4)
                    Dim durasiPeminjaman = row(5)
                    Dim denda = 0
                    Dim totalTagihan = tagihanNormal + denda

                    If totalDurasiJam > durasiPeminjaman Then
                        Dim hargaPerjam = tagihanNormal / durasiPeminjaman

                        denda = (totalDurasiJam - durasiPeminjaman) * (hargaPerjam + 2000)
                        totalTagihan = tagihanNormal + denda

                        row(6) = "Rp." + (Integer.Parse(denda)).ToString("#,#")

                        UpdateTagihanSewaByID(row(0), denda, totalTagihan)
                    Else
                        row(6) = "Rp.0"
                    End If

                    row(4) = "Rp." + (Integer.Parse(tagihanNormal)).ToString("#,#")
                    row(5) = durasiPeminjaman.ToString() + " Jam"
                    row(7) = "Rp." + (Integer.Parse(totalTagihan)).ToString("#,#")
                Else
                    Dim tagihanNormal = row(4)
                    Dim durasiPeminjaman = row(5)
                    Dim denda = row(6)
                    Dim totalTagihan = row(7)

                    If denda = 0 Then
                        row(6) = "Rp.0"
                    Else
                        row(6) = "Rp." + (Integer.Parse(denda)).ToString("#,#")
                    End If

                    row(4) = "Rp." + (Integer.Parse(tagihanNormal)).ToString("#,#")
                    row(5) = durasiPeminjaman.ToString() + " Jam"
                    row(7) = "Rp." + (Integer.Parse(totalTagihan)).ToString("#,#")
                End If
            Next

            Return result
        Catch ex As Exception
            MessageBox.Show(ex.ToString())
        Finally
            dbConn.Dispose()
        End Try
    End Function

    Public Function GetIdLockerByIDSewa(ID As Integer) As Integer
        Dim result As Integer

        Try
            dbConn.ConnectionString = "server =" + server + ";" + "user id=" + username + ";" _
            + "password =" + password + ";" + "database =" + database
            dbConn.Open()
            sqlCommand.Connection = dbConn
            sqlCommand.CommandText = "SELECT id_locker FROM penyewaan WHERE id=" & ID

            sqlRead = sqlCommand.ExecuteReader

            If (sqlRead.Read()) Then
                result = sqlRead.GetValue(0)
            End If

            sqlRead.Close()
            dbConn.Close()
            Return result
        Catch ex As Exception
            MessageBox.Show(ex.ToString())
        Finally
            dbConn.Dispose()
        End Try
    End Function

    Public Function InsertDataSewaDatabase(idLocker As Integer, bayarSebelumPinjam As Integer, rencanaPinjam As Integer)
        Try
            dbConn.ConnectionString = "server =" + server + ";" + "user id=" + username + ";" _
            + "password =" + password + ";" + "database =" + database
            dbConn.Open()
            sqlCommand.Connection = dbConn
            sqlCommand.CommandText = "INSERT INTO penyewaan (
                                        id_locker, tanggal_sewa, tanggal_kembali, bayar_sebelum_pinjam, rencana_pinjam,
                                        kelebihan_pinjam, total_bayar) VALUES (" & idLocker & ", '" &
                                        DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") & "', NULL, " & bayarSebelumPinjam & ", " & rencanaPinjam &
                                        ", 0, " & bayarSebelumPinjam & ")"

            sqlRead = sqlCommand.ExecuteReader

            DataSewa.Locker.UpdateLockerStatusByID(idLocker, "Terisi")

            MessageBox.Show("Berhasil menambahkan data sewa")

            sqlRead.Close()
            dbConn.Close()
        Catch ex As Exception
            MessageBox.Show(ex.ToString())
        Finally
            dbConn.Dispose()
        End Try
    End Function

    Public Function UpdateTagihanSewaByID(ID As Integer, denda As Integer, totalTagihan As Integer)
        Try
            dbConn.ConnectionString = "server =" + server + ";" + "user id=" + username + ";" _
            + "password =" + password + ";" + "database =" + database
            dbConn.Open()
            sqlCommand.Connection = dbConn
            sqlCommand.CommandText = "UPDATE penyewaan SET " &
                                        "kelebihan_pinjam = " & denda & ", " &
                                        "total_bayar = " & totalTagihan & " " &
                                        "WHERE id = " & ID

            sqlRead = sqlCommand.ExecuteReader
            sqlRead.Close()
            dbConn.Close()
        Catch ex As Exception
            MessageBox.Show(ex.ToString())
        Finally
            dbConn.Dispose()
        End Try
    End Function

    Public Function UpdatePengembalianSewaByID(ID As Integer, IDLocker As Integer)
        Try
            dbConn.ConnectionString = "server =" + server + ";" + "user id=" + username + ";" _
            + "password =" + password + ";" + "database =" + database
            dbConn.Open()
            sqlCommand.Connection = dbConn
            sqlCommand.CommandText = "update penyewaan set " &
                                        "tanggal_kembali = '" & DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss") & "' " &
                                        "where id = " & ID

            DataSewa.Locker.UpdateLockerStatusByID(IDLocker, "kosong")

            sqlRead = sqlCommand.ExecuteReader
            sqlRead.Close()
            dbConn.Close()
            MessageBox.Show("pengembalian barang berhasil")
        Catch ex As Exception
            MessageBox.Show(ex.ToString())
        Finally
            dbConn.Dispose()
        End Try
    End Function
End Class
