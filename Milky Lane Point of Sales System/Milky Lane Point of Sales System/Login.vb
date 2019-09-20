Public Class Login

    Public userType As String
    Public userID As Integer

    Private Sub ButtonLogin_Click(sender As Object, e As EventArgs) Handles ButtonLogin.Click

        Try
            Dim num As Integer = TblStaffTableAdapter.checkLogin(TextBoxLogin.Text, TextBoxPassword.Text)

            If num = 1 Then
                userType = TblStaffTableAdapter.getRole(TextBoxLogin.Text)
                userID = Integer.Parse(TextBoxLogin.Text)
                MainMenu.Show()
                Me.Close()
            Else
                MessageBox.Show("Incorrect username or passcode.")
            End If
        Catch ex As Exception
            MessageBox.Show("Incorrect username or passcode.")
        End Try

    End Sub

    Private Sub Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.TblStaffTableAdapter.Fill(Me.Ist2gqDataSet.tblStaff)
    End Sub
End Class
