Public Class MainMenu
    Private Sub ButtonSales_Click(sender As Object, e As EventArgs) Handles ButtonSales.Click
        Sales.Show()
    End Sub

    Private Sub ButtonExit_Click(sender As Object, e As EventArgs) Handles ButtonExit.Click
        Application.Exit()
    End Sub

    Private Sub MainMenu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LabelDate.Text = Date.UtcNow.Date
        'Set Username label
    End Sub

    Private Sub ButtonCustomers_Click(sender As Object, e As EventArgs) Handles ButtonCustomers.Click
        Customer.Show()
    End Sub

    Private Sub ButtonTransactions_Click(sender As Object, e As EventArgs) Handles ButtonTransactions.Click
        Transactions.Show()
    End Sub

    Private Sub ButtonProducts_Click(sender As Object, e As EventArgs) Handles ButtonProducts.Click
        Products.Show()
    End Sub

    Private Sub ButtonStaff_Click(sender As Object, e As EventArgs) Handles ButtonStaff.Click
        Staff.Show()
    End Sub
End Class