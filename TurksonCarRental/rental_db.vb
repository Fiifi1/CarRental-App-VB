Imports MySql.Data.MySqlClient

Public Class rental_db

    'show sql data source
    'This string can be changed depending on the PC the application is being run on

    Private conn As New MySqlConnection("datasource=localhost;port=3306;username=root;password=;database=turkson_rental_db")

    'setup new sql connection
    ReadOnly Property makeConnection() As MySqlConnection
        Get
            Return conn
        End Get
    End Property

    'open connection if closed
    Sub startConnection()
        If conn.State = ConnectionState.Closed Then
            conn.Open()
        End If
    End Sub

    Sub endConnection()
        If conn.State = ConnectionState.Open Then
            conn.Close()
        End If
    End Sub

End Class
