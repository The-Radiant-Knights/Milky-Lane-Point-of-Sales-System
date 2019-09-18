Public Class Transactions

    Private Sub ButtonAddTransaction_Click(sender As Object, e As EventArgs) Handles ButtonAddTransaction.Click
        AddTransaction.Show()
    End Sub

    Private Sub ButtonUpdate_Click(sender As Object, e As EventArgs) Handles ButtonUpdate.Click
        IndividualTransaction.Show()
    End Sub
End Class