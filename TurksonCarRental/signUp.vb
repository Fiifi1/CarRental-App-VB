Public Class signUp

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click

        Me.Close()

    End Sub

    Private Sub linkSignUp_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles linkSignUp.LinkClicked

        Dim loginForm As New loginForm()
        loginForm.Show()
        Me.Close()

    End Sub

    Private Sub btnSignIn_Click(sender As Object, e As EventArgs) Handles btnSignIn.Click

        Dim newUser As New addUser()

        Dim userName As String = tbxUsername.Text
        Dim password As String = tbxPassword.Text
        Dim password2 As String = tbxPassword2.Text

        If checkEmptyBoxes() Then

            If password = password2 Then
                If newUser.addUser(userName, password) Then

                    MsgBox(userName & " was Added Successfully", MsgBoxStyle.Information, "Add New User")
                    resetForm()

                Else

                    MsgBox("Error! Could Not Add " & userName, MsgBoxStyle.Critical, "Add New User")

                End If
            Else

                MsgBox("Error!, Passwords do not match. ", MsgBoxStyle.Critical, "Add New User")

                End If
            Else

            MsgBox("Can not Submit an Empty Form!", MsgBoxStyle.Critical, "Add New User")

        End If

    End Sub

    Private Sub ckbxShow_CheckedChanged(sender As Object, e As EventArgs) Handles ckbxShow.CheckedChanged
        If tbxPassword.UseSystemPasswordChar Then
            tbxPassword.UseSystemPasswordChar = False
        Else
            tbxPassword.UseSystemPasswordChar = True
        End If
    End Sub

    Private Sub ckbxShow2_CheckedChanged(sender As Object, e As EventArgs) Handles ckbxShow2.CheckedChanged
        If tbxPassword2.UseSystemPasswordChar Then
            tbxPassword2.UseSystemPasswordChar = False
        Else
            tbxPassword2.UseSystemPasswordChar = True
        End If
    End Sub

    Function checkEmptyBoxes() As Boolean
        If tbxUsername.Text.Trim() = "" Or tbxPassword.Text.Trim() = "" Or tbxPassword2.Text.Trim() = "" Then

            Return False

        Else

            Return True

        End If
    End Function

    Sub resetForm()
        tbxUsername.Text = ""
        tbxPassword2.Text = ""
        tbxPassword.Text = ""
    End Sub

End Class