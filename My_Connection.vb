Imports MySql.Data.MySqlClient
Public Class My_Connection

    Private connection As New MySqlConnection("datasource=sql2.freemysqlhosting.net;port=3306;username=sql2329716;password=nM9*mN4%;database=sql2329716")

    ReadOnly Property getConnection() As MySqlConnection
        Get
            Return connection

        End Get
    End Property

    Sub openConnection()
        If connection.State = ConnectionState.Closed Then
            connection.Open()
        End If
    End Sub

    Sub closeConnection()
        If connection.State = ConnectionState.Open Then
            connection.Close()
        End If
    End Sub
End Class