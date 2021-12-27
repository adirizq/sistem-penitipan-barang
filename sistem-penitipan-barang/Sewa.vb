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
                                        CONCAT('Rp.', bayar_sebelum_pinjam) AS 'Tagihan Normal',
                                        CONCAT(rencana_pinjam, ' jam') AS 'Durasi Peminjaman',
                                        CONCAT('Rp.', kelebihan_pinjam) AS 'Denda',
                                        CONCAT('Rp.', total_bayar) AS 'Total Tagihan'
                                        FROM penyewaan"

            sqlRead = sqlCommand.ExecuteReader

            result.Load(sqlRead)
            sqlRead.Close()
            dbConn.Close()
            Return result
        Catch ex As Exception
            MessageBox.Show(ex.ToString())
        Finally
            dbConn.Dispose()
        End Try
    End Function
End Class
