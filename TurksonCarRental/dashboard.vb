Public Class dashboard

    Private Sub RentalToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RentalToolStripMenuItem.Click

        Dim rentalForm As New rental()
        rentalForm.Show(Me)

    End Sub

    Private Sub CarsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CarsToolStripMenuItem.Click
        Dim carForm As New cars()
        carForm.Show(Me)
    End Sub

    Private Sub dashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Label1.Text = "Date : " & Date.Now()
    End Sub
End Class