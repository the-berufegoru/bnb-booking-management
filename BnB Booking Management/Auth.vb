Public Class Auth

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        Dim Username As String = txtUsername.Text
        Dim Password As String = mskTxtPassword.Text

        If Username = "giftmoobi@gmail.com" Then
            If Password = "Mk327452_" Then
                MessageBox.Show("logged in.")
            Else
                MessageBox.Show("Invalid username or password.")
            End If
        Else
            MessageBox.Show("Invalid username or password.")
        End If
    End Sub
End Class
