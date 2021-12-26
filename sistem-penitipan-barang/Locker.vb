Imports System.Text
Imports MySql.Data.MySqlClient

Public Class Locker

    Public Shared dbConn As New MySqlConnection
    Public Shared sqlCommand As New MySqlCommand
    Public Shared sqlRead As MySqlDataReader
    Private sqlQuery As String

    Private server As String = "127.0.0.1"
    Private username As String = "root"
    Private password As String = ""
    Private database As String = "sistem_penitipan_barang"

    Public Function GetDataLockerDatabase() As DataTable
        Dim result As New DataTable

        dbConn.ConnectionString = "server =" + server + ";" + "user id=" + username + ";" _
            + "password =" + password + ";" + "database =" + database
        dbConn.Open()
        sqlCommand.Connection = dbConn
        sqlCommand.CommandText = "SELECT
                                  l.id AS 'ID',
                                  u.ukuran AS 'Ukuran',
                                  CONCAT('Rp.', u.biaya, '/Jam') AS 'Biaya',
                                  l.lokasi AS 'Lokasi',
                                  l.status AS 'Status'
                                  FROM locker l JOIN jenis_ukuran u"

        sqlRead = sqlCommand.ExecuteReader

        result.Load(sqlRead)
        sqlRead.Close()
        dbConn.Close()
        Return result
    End Function
End Class
