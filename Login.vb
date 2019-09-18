Public Class Login
    Private Sub ButtonLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        MainMenu.Show()
    End Sub

    Private Sub cmbUsers_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbUsers.SelectedIndexChanged
        edtPassword.Visible() = True
        lblChangePassword.Visible() = True
        lblPassword.Visible() = True
        pbxShowPass.Visible() = True
        edtPassword.Select()
    End Sub

    Private Sub pbxShowPass_Click(sender As Object, e As EventArgs) Handles pbxShowPass.Click
        pbxHidePass.Visible() = True
        pbxShowPass.Visible() = False
        edtPassword.UseSystemPasswordChar() = False
    End Sub

    Private Sub pbxHidePass_Click(sender As Object, e As EventArgs) Handles pbxHidePass.Click
        pbxShowPass.Visible() = True
        pbxHidePass.Visible() = False
        edtPassword.UseSystemPasswordChar() = True
    End Sub

    Private Sub lblChangePassword_Click(sender As Object, e As EventArgs) Handles lblChangePassword.Click

    End Sub

    Private Sub edtPassword_TextChanged(sender As Object, e As EventArgs) Handles edtPassword.TextChanged
        btnLogin.Visible() = True
    End Sub
End Class
