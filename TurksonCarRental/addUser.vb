Imports System.IO
Imports MySql.Data.MySqlClient

Public Class addUser

    Dim rentalDB As New rental_db()

    Public Function addUser(ByVal uname As String, ByVal pwd As String) As Boolean
        Dim comm As New MySqlCommand("INSERT INTO `user`(`username`, `password`) VALUES (@uname,@pwd)", rentalDB.makeConnection)

        comm.Parameters.Add("@uname", MySqlDbType.VarChar).Value = uname

        comm.Parameters.Add("@pwd", MySqlDbType.VarChar).Value = pwd

        rentalDB.startConnection()

        If comm.ExecuteNonQuery() = 1 Then

            Return True
        Else

            Return False
        End If

        rentalDB.endConnection()

    End Function


End Class
