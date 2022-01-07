Imports System.Text
Imports MySql.Data.MySqlClient

Public Class Locker

    Public Shared dbConn As New MySqlConnection
    Public Shared sqlCommand As New MySqlCommand
    Public Shared sqlRead As MySqlDataReader

    Private server As String = "127.0.0.1"
    Private username As String = "root"
    Private password As String = ""
    Private database As String = "sistem_penitipan_barang"

    Public Function GetDataLockerDatabase() As DataTable
        Dim result As New DataTable

        Try
            dbConn.ConnectionString = "server =" + server + ";" + "user id=" + username + ";" _
            + "password =" + password + ";" + "database =" + database
            dbConn.Open()
            sqlCommand.Connection = dbConn
            sqlCommand.CommandText = "SELECT
                                        l.id AS 'ID Locker',
                                        l.nama As 'Nama Locker',
                                        u.ukuran AS 'Ukuran',
                                        CONCAT('Rp.', u.biaya, '/Jam') AS 'Biaya',
                                        l.lokasi AS 'Lokasi',
                                        l.status AS 'Status'
                                        FROM locker l JOIN jenis_ukuran u
                                        ON l.id_ukuran = u.id"

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

    Public Function GetDataAvailableLockerByUkuran(ukuran As String) As List(Of Integer)
        Dim result As New List(Of Integer)

        Try
            dbConn.ConnectionString = "server =" + server + ";" + "user id=" + username + ";" _
            + "password =" + password + ";" + "database =" + database
            dbConn.Open()
            sqlCommand.Connection = dbConn
            sqlCommand.CommandText = "SELECT l.id FROM locker l JOIN jenis_ukuran u
                                      ON l.id_ukuran = u.id 
                                      WHERE l.status = 'Kosong' AND u.ukuran = '" & ukuran & "'"

            sqlRead = sqlCommand.ExecuteReader

            While sqlRead.Read()
                result.Add(sqlRead.GetValue(0))
            End While

            sqlRead.Close()
            dbConn.Close()
            Return result
        Catch ex As Exception
            MessageBox.Show(ex.ToString())
        Finally
            dbConn.Dispose()
        End Try
    End Function

    Public Function UpdateLockerStatusByID(ID As Integer, status As String)
        Try
            dbConn.ConnectionString = "server =" + server + ";" + "user id=" + username + ";" _
            + "password =" + password + ";" + "database =" + database
            dbConn.Open()
            sqlCommand.Connection = dbConn
            sqlCommand.CommandText = "UPDATE locker SET status='" & status & "' " &
                                     "WHERE id=" & ID

            sqlRead = sqlCommand.ExecuteReader

            sqlRead.Close()
            dbConn.Close()
        Catch ex As Exception
            MessageBox.Show(ex.ToString())
        Finally
            dbConn.Dispose()
        End Try
    End Function

    Public Function GetLockerInformationByID(ID As Integer) As List(Of String)
        Dim result As New List(Of String)

        Try
            dbConn.ConnectionString = "server =" + server + ";" + "user id=" + username + ";" _
            + "password =" + password + ";" + "database =" + database
            dbConn.Open()
            sqlCommand.Connection = dbConn
            sqlCommand.CommandText = "SELECT id, id_ukuran, lokasi, status FROM locker
                                      WHERE id=" & ID

            sqlRead = sqlCommand.ExecuteReader

            If (sqlRead.Read()) Then
                result.Add(sqlRead.GetString(0))
                result.Add(sqlRead.GetString(1))
                result.Add(sqlRead.GetString(2))
                result.Add(sqlRead.GetString(3))
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

    Public Function UpdateLockerDataByID(ID As Integer, IDUkuran As Integer, lokasi As String)
        Try
            dbConn.ConnectionString = "server =" + server + ";" + "user id=" + username + ";" _
            + "password =" + password + ";" + "database =" + database
            dbConn.Open()
            sqlCommand.Connection = dbConn
            sqlCommand.CommandText = "UPDATE locker SET id_ukuran='" & IDUkuran & "', " &
                                     "lokasi='" & lokasi & "' " &
                                     "WHERE id=" & ID

            sqlRead = sqlCommand.ExecuteReader

            sqlRead.Close()
            dbConn.Close()
        Catch ex As Exception
            MessageBox.Show(ex.ToString())
        Finally
            dbConn.Dispose()
        End Try
    End Function

    Public Function InsertDataLocker(id_ukuran As Integer, nama As String, lokasi As String)
        Try
            dbConn.ConnectionString = "server =" + server + ";" + "user id=" + username + ";" _
            + "password =" + password + ";" + "database =" + database
            dbConn.Open()
            sqlCommand.Connection = dbConn
            sqlCommand.CommandText = "INSERT INTO locker (id_ukuran, nama, lokasi, status) VALUES (" &
                                     id_ukuran & ", '" & nama & "', '" & lokasi & "', 'Kosong' )"

            sqlRead = sqlCommand.ExecuteReader

            sqlRead.Close()
            dbConn.Close()

            MessageBox.Show("Berhasil Menambahkan Data Locker")
        Catch ex As Exception
            MessageBox.Show(ex.ToString())
        Finally
            dbConn.Dispose()
        End Try
    End Function
End Class
