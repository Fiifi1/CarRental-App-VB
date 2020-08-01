Imports MySql.Data.MySqlClient

Public Class loginForm

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub btnSignIn_Click(sender As Object, e As EventArgs) Handles btnSignIn.Click

        Dim rentalDB As New rental_db()
        Dim adapt As New MySqlDataAdapter()
        Dim dtable As New DataTable()
        Dim comm As New MySqlCommand("SELECT * FROM `user` WHERE `username` = @usr AND `password` = @pwd", rentalDB.makeConnection)

        comm.Parameters.Add("@usr", MySqlDbType.VarChar).Value = tbxUsername.Text
        comm.Parameters.Add("@pwd", MySqlDbType.VarChar).Value = tbxPassword.Text

        adapt.SelectCommand = comm
        adapt.Fill(dtable)

        'Validate form from database
        If dtable.Rows.Count > 0 Then
            Dim dashboardForm As New dashboard()
            dashboardForm.Show()
            Me.Close()
        Else
            MsgBox("Incorrect Credentials!", MsgBoxStyle.Critical, "Login Error")
        End If

    End Sub

    Private Sub ckbxShow_CheckedChanged(sender As Object, e As EventArgs) Handles ckbxShow.CheckedChanged

        If tbxPassword.UseSystemPasswordChar Then
            tbxPassword.UseSystemPasswordChar = False
        Else
            tbxPassword.UseSystemPasswordChar = True
        End If

    End Sub

    Private Sub linkSignUp_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles linkSignUp.LinkClicked

        Dim signUpForm As New signUp()
        signUpForm.Show()
        Me.Close()

    End Sub
End Class
