Imports System.IO
Imports MySql.Data.MySqlClient

Public Class rentalList

    Dim rentalDB As New rental_db()

    'Method to add new rental record to rental table
    Public Function addRentRecord(ByVal fname As String, ByVal sname As String, ByVal nat As String, ByVal idType As String, ByVal idNumber As String, ByVal idExpiry As Date, ByVal carType As String, ByVal carName As String, ByVal pickDate As Date, ByVal dueDate As Date, ByVal price As Double) As Boolean
        Dim comm As New MySqlCommand("INSERT INTO `rental`(`cus_fname`, `cus_sname`, `nationality`, `id_type`, `id_number`, `id_expiry_date`, `car_type`, `model_name`, `pickup_date`, `due_date`, `price`) VALUES (@fname,@sname,@nat,@idtype,@idnum,@idexpiry,@cartype,@modname,@pickdate,@duedate,@price)", rentalDB.makeConnection)

        '@fname,@sname,@nat,@idtype,@idnum,@idexpiry,@cartype,@modname,@pickdate,@duedate,@price

        comm.Parameters.Add("@fname", MySqlDbType.VarChar).Value = fname

        comm.Parameters.Add("@sname", MySqlDbType.VarChar).Value = sname

        comm.Parameters.Add("@nat", MySqlDbType.VarChar).Value = nat

        comm.Parameters.Add("@idtype", MySqlDbType.VarChar).Value = idType

        comm.Parameters.Add("@idnum", MySqlDbType.VarChar).Value = idNumber

        comm.Parameters.Add("@idexpiry", MySqlDbType.Date).Value = idExpiry

        comm.Parameters.Add("@cartype", MySqlDbType.VarChar).Value = carType

        comm.Parameters.Add("@modname", MySqlDbType.VarChar).Value = carName

        comm.Parameters.Add("@pickdate", MySqlDbType.Date).Value = pickDate

        comm.Parameters.Add("@duedate", MySqlDbType.Date).Value = dueDate

        comm.Parameters.Add("@price", MySqlDbType.Double).Value = price

        rentalDB.startConnection()

        If comm.ExecuteNonQuery() = 1 Then

            Return True
        Else

            Return False
        End If

        rentalDB.endConnection()

    End Function


    Public Function updateRentRecord(ByVal id As Integer, ByVal fname As String, ByVal sname As String, ByVal nat As String, ByVal idType As String, ByVal idNumber As String, ByVal idExpiry As Date, ByVal carType As String, ByVal carName As String, ByVal pickDate As Date, ByVal dueDate As Date, ByVal price As Double) As Boolean
        Dim comm As New MySqlCommand("UPDATE `rental` SET `cus_fname`=@fname,`cus_sname`=@sname,`nationality`=@nat,`id_type`=@idtype,`id_number`=@idnum,`id_expiry_date`=@idexpiry,`car_type`=@cartype,`model_name`=@modname,`pickup_date`=@pickdate,`due_date`=@duedate,`price`=@price WHERE `id`=@rid", rentalDB.makeConnection)

        '@fname,@sname,@nat,@idtype,@idnum,@idexpiry,@cartype,@modname,@pickdate,@duedate,@price
        comm.Parameters.Add("@rid", MySqlDbType.Int32).Value = id

        comm.Parameters.Add("@fname", MySqlDbType.VarChar).Value = fname

        comm.Parameters.Add("@sname", MySqlDbType.VarChar).Value = sname

        comm.Parameters.Add("@nat", MySqlDbType.VarChar).Value = nat

        comm.Parameters.Add("@idtype", MySqlDbType.VarChar).Value = idType

        comm.Parameters.Add("@idnum", MySqlDbType.VarChar).Value = idNumber

        comm.Parameters.Add("@idexpiry", MySqlDbType.Date).Value = idExpiry

        comm.Parameters.Add("@cartype", MySqlDbType.VarChar).Value = carType

        comm.Parameters.Add("@modname", MySqlDbType.VarChar).Value = carName

        comm.Parameters.Add("@pickdate", MySqlDbType.Date).Value = pickDate

        comm.Parameters.Add("@duedate", MySqlDbType.Date).Value = dueDate

        comm.Parameters.Add("@price", MySqlDbType.Double).Value = price

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
