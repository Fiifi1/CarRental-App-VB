Imports System.IO
Imports MySql.Data.MySqlClient

Public Class rental
    '@fname,@sname,@nat,@idtype,@idnum,@idexpiry,@cartype,@modname,@pickdate,@duedate,@price

    Dim newRent As New rentalList()

    Private Sub btnAddRecord_Click(sender As Object, e As EventArgs) Handles btnAddRecord.Click

        Dim fname As String = tbxFirstName.Text
        Dim sname As String = tbxSurname.Text
        Dim nat As String = tbxNationaliy.Text
        Dim idType As String = tbxIdType.Text
        Dim idNum As String = tbxIdNumber.Text
        Dim idExp As Date = dateExpiry.Value
        Dim carType As String = tbxCarType.Text
        Dim carName As String = tbxModel.Text
        Dim pickDate As Date = datePickUp.Value
        Dim dueDate As Date = dateDue.Value
        Dim price As Double = numPrice.Value

        Dim idExpiryYear As Integer = dateExpiry.Value.Year
        Dim currentYear As Integer = Date.Now.Year
        Dim yearDiff As Integer = idExpiryYear - currentYear

        If yearDiff > 0 Then

            If checkEmptyBoxes() Then

                If newRent.addRentRecord(fname, sname, nat, idType, idNum, idExp, carType, carName, pickDate, dueDate, price) Then

                    MsgBox("New Record for " & fname & " inserted Successfully", MsgBoxStyle.Information, "Add New Rental Record")

                    Dim commString As String = "SELECT * FROM `rental`"
                    Dim comm As New MySqlCommand(commString)
                    populateTable(comm)

                    resetForm()

                End If

            Else

                MsgBox("A Field may be Empty or Date Incorrect!", MsgBoxStyle.Critical, "Add New Rental Record")

            End If

        Else

            MsgBox("ID card cannot be in expiry year or expired!", MsgBoxStyle.Critical, "Add New Rental Record")

        End If


    End Sub

    Private Sub rental_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim commString As String = "SELECT * FROM `rental`"

        Dim comm As New MySqlCommand(commString)

        populateTable(comm)


    End Sub

    Public Sub populateTable(ByVal comm As MySqlCommand)
        dgvRental.ReadOnly = True

        dgvRental.DataSource = newRent.readAllRecords(comm)

        dgvRental.AllowUserToAddRows = False

        'Total number of student after search
        lblTotalRecords.Text = "Total : " & dgvRental.Rows.Count

    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click

        Dim commString As String = "SELECT * FROM `rental` WHERE CONCAT(`cus_fname`,`cus_sname`,`nationality`,`id_type`)LIKE '%" & tbxSearch.Text & "%'"

        Dim comm As New MySqlCommand(commString)

        populateTable(comm)

    End Sub

    Private Sub tbxSearch_TextChanged(sender As Object, e As EventArgs) Handles tbxSearch.TextChanged

        Dim commString As String = "SELECT * FROM `rental` WHERE CONCAT(`cus_fname`,`cus_sname`,`nationality`,`id_type`)LIKE '%" & tbxSearch.Text & "%'"

        Dim comm As New MySqlCommand(commString)

        populateTable(comm)

    End Sub

    Private Sub dgvRental_Click(sender As Object, e As EventArgs) Handles dgvRental.Click

        tbxId.Text = dgvRental.CurrentRow.Cells(0).Value.ToString
        tbxFirstName.Text = dgvRental.CurrentRow.Cells(1).Value.ToString
        tbxSurname.Text = dgvRental.CurrentRow.Cells(2).Value.ToString
        tbxNationaliy.Text = dgvRental.CurrentRow.Cells(3).Value.ToString
        tbxIdType.Text = dgvRental.CurrentRow.Cells(4).Value.ToString
        tbxIdNumber.Text = dgvRental.CurrentRow.Cells(5).Value.ToString
        dateExpiry.Value = dgvRental.CurrentRow.Cells(6).Value
        tbxCarType.Text = dgvRental.CurrentRow.Cells(7).Value.ToString
        tbxModel.Text = dgvRental.CurrentRow.Cells(8).Value.ToString
        datePickUp.Value = dgvRental.CurrentRow.Cells(9).Value
        dateDue.Value = dgvRental.CurrentRow.Cells(10).Value
        numPrice.Value = dgvRental.CurrentRow.Cells(11).Value

    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click

        Dim recId As Integer = Convert.ToInt32(tbxId.Text)
        Dim fname As String = tbxFirstName.Text
        Dim sname As String = tbxSurname.Text
        Dim nat As String = tbxNationaliy.Text
        Dim idType As String = tbxIdType.Text
        Dim idNum As String = tbxIdNumber.Text
        Dim idExp As Date = dateExpiry.Value
        Dim carType As String = tbxCarType.Text
        Dim carName As String = tbxModel.Text
        Dim pickDate As Date = datePickUp.Value
        Dim dueDate As Date = dateDue.Value
        Dim price As Double = numPrice.Value

        Dim idExpiryYear As Integer = dateExpiry.Value.Year
        Dim currentYear As Integer = Date.Now.Year
        Dim yearDiff As Integer = idExpiryYear - currentYear

        If yearDiff > 0 Then

            If checkEmptyBoxes() Then

                If newRent.updateRentRecord(recId, fname, sname, nat, idType, idNum, idExp, carType, carName, pickDate, dueDate, price) Then

                    MsgBox("Record updated for " & fname & " Successfully", MsgBoxStyle.Information, "Update Rental Record")

                    Dim commString As String = "SELECT * FROM `rental`"
                    Dim comm As New MySqlCommand(commString)
                    populateTable(comm)

                    resetForm()

                End If

            Else

                MsgBox("A Field may be Empty or Date Incorrect!", MsgBoxStyle.Critical, "Update Rental Record")

            End If

        Else

            MsgBox("ID card cannot be in expiry year or expired!", MsgBoxStyle.Critical, "Update Rental Record")

        End If

    End Sub

    Function checkEmptyBoxes() As Boolean
        If tbxFirstName.Text.Trim() = "" Or tbxSurname.Text.Trim() = "" Or tbxNationaliy.Text.Trim() = "" Or
             tbxIdType.Text = "" Or tbxIdNumber.Text.Trim() = "" Or tbxCarType.Text.Trim() = "" Or
             tbxModel.Text.Trim() = "" Then

            Return False

        Else

            Return True

        End If
    End Function

    Sub resetForm()

        tbxFirstName.Text = ""
        tbxSurname.Text = ""
        tbxNationaliy.Text = ""
        tbxIdType.Text = ""
        tbxIdNumber.Text = ""
        dateExpiry.Value = Date.Now()
        tbxCarType.Text = ""
        tbxModel.Text = ""
        datePickUp.Value = Date.Now()
        dateDue.Value = Date.Now()
        numPrice.Value = 100


    End Sub

End Class