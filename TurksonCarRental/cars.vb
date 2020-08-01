Imports System.IO
Imports MySql.Data.MySqlClient

Public Class cars

    Dim newCar As New carList()

    Private Sub cars_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim commString As String = "SELECT * FROM `car`"

        Dim comm As New MySqlCommand(commString)

        populateTable(comm)

    End Sub

    Public Sub populateTable(ByVal comm As MySqlCommand)
        dgvCars.ReadOnly = True

        dgvCars.DataSource = newCar.readAllRecords(comm)

        dgvCars.AllowUserToAddRows = False

        'Total number of student after search
        lblTotalCars.Text = "Total : " & dgvCars.Rows.Count

    End Sub

    Private Sub btnAddCar_Click(sender As Object, e As EventArgs) Handles btnAddCar.Click

        Dim model As String = tbxModelName.Text
        Dim type As String = tbxType.Text
        Dim year As String = tbxYear.Text
        Dim reg As String = tbxRegistration.Text
        Dim color As String = tbxColor.Text
        'Whether the car is available or unavailable
        Dim status As String = tbxStatus.Text

        If checkEmptyBoxes() Then

            If newCar.addCarRecord(model, type, year, reg, color, status) Then

                MsgBox(model & " was added Successfully!", MsgBoxStyle.Information, "New Car Entry")

                Dim commString As String = "SELECT * FROM `car`"
                Dim comm As New MySqlCommand(commString)
                populateTable(comm)

                resetForm()

            Else

                MsgBox("Could not add New car, check database connection!", MsgBoxStyle.Critical, "New Car Entry")

            End If


        Else

            MsgBox("Some Entries Cannot be empty!", MsgBoxStyle.Critical, "New Car Entry")

        End If


    End Sub

    Private Sub btnUpdateCar_Click(sender As Object, e As EventArgs) Handles btnUpdateCar.Click

        Dim cid As Integer = Convert.ToInt32(tbxID.Text)
        Dim model As String = tbxModelName.Text
        Dim type As String = tbxType.Text
        Dim year As String = tbxYear.Text
        Dim reg As String = tbxRegistration.Text
        Dim color As String = tbxColor.Text
        'Whether the car is available or unavailable
        Dim status As String = tbxStatus.Text

        If checkEmptyBoxes() Then

            If newCar.updateCarRecord(cid, model, type, year, reg, color, status) Then

                MsgBox(model & " info was updated Successfully!", MsgBoxStyle.Information, "Update Car Entry")

                Dim commString As String = "SELECT * FROM `car`"
                Dim comm As New MySqlCommand(commString)
                populateTable(comm)

                resetForm()

            Else

                MsgBox("Could not update car props, check database connection!", MsgBoxStyle.Critical, "Update Car Entry")

            End If


        Else

            MsgBox("Some Entries Cannot be empty!", MsgBoxStyle.Critical, "Update Car Entry")

        End If

    End Sub

    Function checkEmptyBoxes() As Boolean
        If tbxModelName.Text.Trim() = "" Or tbxYear.Text.Trim() = "" Or tbxRegistration.Text.Trim() = "" Or
             tbxStatus.Text = "" Then

            Return False

        Else

            Return True

        End If
    End Function

    Sub resetForm()

        tbxModelName.Text = ""
        tbxYear.Text = ""
        tbxType.Text = ""
        tbxRegistration.Text = ""
        tbxColor.Text = ""
        tbxStatus.Text = ""


    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click

        Dim commString As String = "SELECT * FROM `car` WHERE CONCAT(`model`,`type`,`year`,`registration`)LIKE '%" & tbxSearch.Text & "%'"
        Dim comm As New MySqlCommand(commString)
        populateTable(comm)

    End Sub

    Private Sub tbxSearch_TextChanged(sender As Object, e As EventArgs) Handles tbxSearch.TextChanged

        Dim commString As String = "SELECT * FROM `car` WHERE CONCAT(`model`,`type`,`year`,`registration`)LIKE '%" & tbxSearch.Text & "%'"
        Dim comm As New MySqlCommand(commString)
        populateTable(comm)

    End Sub

    Private Sub dgvCars_Click(sender As Object, e As EventArgs) Handles dgvCars.Click

        tbxID.Text = dgvCars.CurrentRow.Cells(0).Value.ToString
        tbxModelName.Text = dgvCars.CurrentRow.Cells(1).Value.ToString
        tbxType.Text = dgvCars.CurrentRow.Cells(2).Value.ToString
        tbxYear.Text = dgvCars.CurrentRow.Cells(3).Value.ToString
        tbxRegistration.Text = dgvCars.CurrentRow.Cells(4).Value.ToString
        tbxColor.Text = dgvCars.CurrentRow.Cells(5).Value.ToString
        tbxStatus.Text = dgvCars.CurrentRow.Cells(6).Value.ToString

    End Sub

    Private Sub btnDeleteCar_Click(sender As Object, e As EventArgs) Handles btnDeleteCar.Click

        Try
            Dim carId As Integer = Convert.ToInt32(tbxID.Text)

            'Confirm deletion
            If MsgBox("Are you sure", MsgBoxStyle.YesNo, "Remove Car") = MsgBoxResult.Yes Then

                If newCar.delCar(carId) Then
                    MsgBox("Successfully Deleted Car Record", MsgBoxStyle.Information, "Remove Car")

                    Dim commString As String = "SELECT * FROM `car`"
                    Dim comm As New MySqlCommand(commString)
                    populateTable(comm)

                    resetForm()

                Else

                    MsgBox("Student cannot be found", MsgBoxStyle.Information, "Remove Car")

                End If
            End If
        Catch ex As Exception
            MsgBox("Invalid Car Record", MsgBoxStyle.Information, "Remove Car")
        End Try

    End Sub

End Class