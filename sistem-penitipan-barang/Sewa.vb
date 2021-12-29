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

    Public Function GetDataSewaDatabase() As DataTable
        Dim result As New DataTable
        Dim data As New DataTable

        Try
            dbConn.ConnectionString = "server =" + server + ";" + "user id=" + username + ";" _
            + "password =" + password + ";" + "database =" + database
            dbConn.Open()
            sqlCommand.Connection = dbConn
            sqlCommand.CommandText = "SELECT
                                        id AS 'No Sewa',
                                        id_locker AS 'No Locker',
                                        tanggal_sewa AS 'Tanggal Sewa',
                                        tanggal_kembali AS 'Tanggal Pengembalian',
                                        bayar_sebelum_pinjam AS 'Tagihan Normal',
                                        rencana_pinjam AS 'Durasi Peminjaman',
                                        kelebihan_pinjam AS 'Denda',
                                        total_bayar AS 'Total Tagihan'
                                        FROM penyewaan"

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

                    If totalDurasiJam > row(5) Then
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
                    Dim waktuPenyewaan As Date = row(2)
                    Dim waktuPengembalian As Date = row(3)
                    Dim durasiTs As TimeSpan = waktuPengembalian - waktuPenyewaan
                    Dim totalDurasiJam As Integer = Math.Ceiling(Convert.ToInt32(durasiTs.TotalMinutes) / 60)

                    Dim tagihanNormal = row(4)
                    Dim durasiPeminjaman = row(5)
                    Dim denda = 0
                    Dim totalTagihan = tagihanNormal + denda

                    If totalDurasiJam > row(5) Then
                        Dim hargaPerjam = tagihanNormal / durasiPeminjaman

                        denda = (totalDurasiJam - durasiPeminjaman) * (hargaPerjam + 2000)
                        totalTagihan = tagihanNormal + denda

                        row(6) = "Rp." + (Integer.Parse(denda)).ToString("#,#")
                    Else
                        row(6) = "Rp.0"
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

    Public Function GetDataSewaByID(ID As Integer) As List(Of String)
        Dim result As New List(Of String)

        Try
            dbConn.ConnectionString = "server =" + server + ";" + "user id=" + username + ";" _
            + "password =" + password + ";" + "database =" + database
            dbConn.Open()
            sqlCommand.Connection = dbConn
            sqlCommand.CommandText = "SELECT id, id_locker, tanggal_sewa, tanggal_kembali,
                                      bayar_sebelum_pinjam, rencana_pinjam, kelebihan_pinjam, total_bayar 
                                      FROM penyewaan WHERE id=" & ID

            sqlRead = sqlCommand.ExecuteReader

            If (sqlRead.Read()) Then
                result.Add(sqlRead.GetValue(0))
                result.Add(sqlRead.GetValue(1))
                result.Add(sqlRead.GetValue(2))

                If IsDBNull(sqlRead.GetValue(3)) Then
                    result.Add("")
                Else
                    result.Add(sqlRead.GetValue(3))
                End If

                result.Add(sqlRead.GetValue(4))
                result.Add(sqlRead.GetValue(5))
                result.Add(sqlRead.GetValue(6))
                result.Add(sqlRead.GetValue(7))

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

    Public Function UpdatePengembalianSewaByID(ID As Integer)
        Try
            dbConn.ConnectionString = "server =" + server + ";" + "user id=" + username + ";" _
            + "password =" + password + ";" + "database =" + database
            dbConn.Open()
            sqlCommand.Connection = dbConn
            sqlCommand.CommandText = "UPDATE penyewaan SET " &
                                        "tanggal_kembali = '" & DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") & "' " &
                                        "WHERE id = " & ID

            sqlRead = sqlCommand.ExecuteReader
            sqlRead.Close()
            dbConn.Close()
            MessageBox.Show("Pengembalian barang berhasil")
        Catch ex As Exception
            MessageBox.Show(ex.ToString())
        Finally
            dbConn.Dispose()
        End Try
    End Function
End Class
