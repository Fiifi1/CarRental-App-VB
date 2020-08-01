Imports System.IO
Imports MySql.Data.MySqlClient


Public Class carList

    Dim rentalDB As New rental_db()

    'Method to add new rental record to rental table
    Public Function addCarRecord(ByVal model As String, ByVal type As String, ByVal year As String, ByVal regNo As String, ByVal colour As String, ByVal status As String) As Boolean
        Dim comm As New MySqlCommand("INSERT INTO `car`(`model`, `type`, `year`, `registration`, `color`, `status`) VALUES (@mod,@type,@year,@reg,@col,@stat)", rentalDB.makeConnection)

        '@fname,@sname,@nat,@idtype,@idnum,@idexpiry,@cartype,@modname,@pickdate,@duedate,@price

        comm.Parameters.Add("@mod", MySqlDbType.VarChar).Value = model

        comm.Parameters.Add("@type", MySqlDbType.VarChar).Value = type

        comm.Parameters.Add("@year", MySqlDbType.VarChar).Value = year

        comm.Parameters.Add("@reg", MySqlDbType.VarChar).Value = regNo

        comm.Parameters.Add("@col", MySqlDbType.VarChar).Value = colour

        comm.Parameters.Add("@stat", MySqlDbType.VarChar).Value = status

        rentalDB.startConnection()

        If comm.ExecuteNonQuery() = 1 Then

            Return True
        Else

            Return False
        End If

        rentalDB.endConnection()

    End Function


    Public Function updateCarRecord(ByVal id As Integer, ByVal model As String, ByVal type As String, ByVal year As String, ByVal regNo As String, ByVal colour As String, ByVal status As String) As Boolean
        Dim comm As New MySqlCommand("UPDATE `car` SET `model`=@mod,`type`=@type,`year`=@year,`registration`=@reg,`color`=@col,`status`=@stat WHERE `id`=@rid", rentalDB.makeConnection)

        '@fname,@sname,@nat,@idtype,@idnum,@idexpiry,@cartype,@modname,@pickdate,@duedate,@price
        comm.Parameters.Add("@rid", MySqlDbType.Int32).Value = id

        comm.Parameters.Add("@mod", MySqlDbType.VarChar).Value = model

        comm.Parameters.Add("@type", MySqlDbType.VarChar).Value = type

        comm.Parameters.Add("@year", MySqlDbType.VarChar).Value = year

        comm.Parameters.Add("@reg", MySqlDbType.VarChar).Value = regNo

        comm.Parameters.Add("@col", MySqlDbType.VarChar).Value = colour

        comm.Parameters.Add("@stat", MySqlDbType.VarChar).Value = status

        rentalDB.startConnection()

        If comm.ExecuteNonQuery() = 1 Then

            Return True
        Else

            Return False
        End If

        rentalDB.endConnection()

    End Function


    Public Function delCar(ByVal cid As Integer) As Boolean

        Dim comm As New MySqlCommand("DELETE FROM `car` WHERE `id` = @cid", rentalDB.makeConnection)

        comm.Parameters.Add("@cid", MySqlDbType.Int32).Value = cid
        rentalDB.startConnection()

        If comm.ExecuteNonQuery() = 1 Then

            Return True
        Else

            Return False
        End If

        rentalDB.endConnection()

    End Function


    Function readAllRecords(ByVal Comm As MySqlCommand) As DataTable

        Comm.Connection = rentalDB.makeConnection

        Dim readAdapt As New MySqlDataAdapter(Comm)
        Dim readTable As New DataTable()

        readAdapt.Fill(readTable)

        Return readTable

    End Function

End Class
