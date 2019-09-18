Public Class SplashScreen

    Dim progress As Integer = 0

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        progress += 1

        If (progress = 50) Then
            Login.Show()
            Me.Close()
        End If
    End Sub
End Class