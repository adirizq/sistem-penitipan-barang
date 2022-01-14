Imports MySql.Data.MySqlClient

Public Class ClassJenisLocker

    Private ukuranLocker As String
    Private biayaLocker As Integer

    Public Shared dbConn As New MySqlConnection
    Public Shared sqlCommand As New MySqlCommand
    Public Shared sqlRead As MySqlDataReader
    Private sqlQuery As String

    Private server As String = "127.0.0.1"
    Private username As String = "root"
    Private password As String = ""
    Private database As String = "sistem_penitipan_barang"

    Public Property ukuranJenisLocker() As String
        Get
            Return ukuranLocker
        End Get
        Set(ByVal value As String)
            ukuranLocker = value
        End Set
    End Property

    Public Property biayaJenisLocker() As String
        Get
            Return biayaLocker
        End Get
        Set(ByVal value As String)
            biayaLocker = value
        End Set
    End Property

    Public Function GetDataJenisUkuranDatabase() As DataTable
        Dim result As New DataTable

        Try
            dbConn.ConnectionString = "server =" + server + ";" + "user id=" + username + ";" _
            + "password =" + password + ";" + "database =" + database
            dbConn.Open()
            sqlCommand.Connection = dbConn
            sqlCommand.CommandText = "SELECT
                                        id AS 'ID',
                                        ukuran AS 'Ukuran',
                                        CONCAT('Rp.', biaya, '/Jam') AS 'Biaya'
                                        FROM jenis_ukuran"

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

    Public Function AddDataJenisUkuranDatabase(ukuranLocker As String, biayaLocker As Integer)

        dbConn.ConnectionString = "server =" + server + ";" + "user id =" + username + ";" + "password =" + password + ";" + "database =" + database

        Try
            dbConn.Open()
            sqlCommand.Connection = dbConn
            sqlQuery = "INSERT INTO jenis_ukuran(ukuran, biaya) VALUES(
            '" & ukuranLocker & "',
            '" & biayaLocker & "')"

            sqlCommand = New MySqlCommand(sqlQuery, dbConn)
            sqlRead = sqlCommand.ExecuteReader
            dbConn.Close()

            'sistem_penitipan_barang.sqlDt.Load(sqlRead)
            sqlRead.Close()
            dbConn.Close()

        Catch ex As Exception
            MessageBox.Show(ex.ToString())
        Finally
            dbConn.Dispose()
        End Try
    End Function

    Public Function GetJenisUkuranInformationByID(ID As Integer) As List(Of String)
        Dim result As New List(Of String)

        Try
            dbConn.ConnectionString = "server =" + server + ";" + "user id=" + username + ";" _
            + "password =" + password + ";" + "database =" + database
            dbConn.Open()
            sqlCommand.Connection = dbConn
            sqlCommand.CommandText = "SELECT id, ukuran, biaya FROM jenis_ukuran
                                      WHERE id=" & ID

            sqlRead = sqlCommand.ExecuteReader

            While sqlRead.Read
                result.Add(sqlRead.GetString(0).ToString())
                result.Add(sqlRead.GetString(1).ToString())
                result.Add(sqlRead.GetString(2).ToString())
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

    Public Function UpdateJenisUkuranByID(ID As Integer, biayaLocker As Integer, ukuranLocker As String)
        Try
            dbConn.ConnectionString = "server =" + server + ";" + "user id=" + username + ";" _
            + "password =" + password + ";" + "database =" + database
            dbConn.Open()
            sqlCommand.Connection = dbConn
            sqlCommand.CommandText = "UPDATE jenis_ukuran SET ukuran='" & ukuranLocker & "', " &
                                     "biaya='" & biayaLocker & "' " &
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

    Public Function DeleteJenisUkuranByID(ID As Integer)


        dbConn.ConnectionString = "Server =" + server + ";" + "User id =" + username + ";" + "Password =" + password + ";" + "Database =" + database

        'Try
        dbConn.Open()
        sqlCommand.Connection = dbConn
        sqlQuery = "DELETE FROM jenis_ukuran " &
                "WHERE id='" & ID & "'"

        Debug.WriteLine(sqlQuery)

        sqlCommand = New MySqlCommand(sqlQuery, dbConn)
        sqlRead = sqlCommand.ExecuteReader
        dbConn.Close()

        'Perpustakaan.sqlDt.Load(sqlRead)
        sqlRead.Close()
        dbConn.Close()


        'Catch ex As Exception
        'Return ex.Message
        'Finally
        'dbConn.Dispose()
        'End Try
    End Function
    Public Function GetJenisUkuranInformation() As ArrayList
        Dim result As New ArrayList

        Try
            dbConn.ConnectionString = "server =" + server + ";" + "user id=" + username + ";" _
            + "password =" + password + ";" + "database =" + database
            dbConn.Open()
            sqlCommand.Connection = dbConn
            sqlCommand.CommandText = "SELECT id, ukuran, biaya FROM jenis_ukuran"

            sqlRead = sqlCommand.ExecuteReader

            While sqlRead.Read()
                result.Add({sqlRead.GetValue(0), sqlRead.GetValue(1), sqlRead.GetValue(2)})
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

    Public Function GetJenisUkuranInformationByUkuran(ukuran As String) As List(Of String)
        Dim result As New List(Of String)

        Try
            dbConn.ConnectionString = "server =" + server + ";" + "user id=" + username + ";" _
            + "password =" + password + ";" + "database =" + database
            dbConn.Open()
            sqlCommand.Connection = dbConn
            sqlCommand.CommandText = "SELECT id, ukuran, biaya FROM jenis_ukuran
                                      WHERE ukuran='" & ukuran & "'"

            sqlRead = sqlCommand.ExecuteReader

            If (sqlRead.Read()) Then
                result.Add(sqlRead.GetValue(0))
                result.Add(sqlRead.GetValue(1))
                result.Add(sqlRead.GetValue(2))
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

End Class
