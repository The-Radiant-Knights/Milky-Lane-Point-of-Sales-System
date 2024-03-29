﻿Public Class MainMenu

    Public userID As Integer

    Private Sub ButtonSales_Click(sender As Object, e As EventArgs) Handles ButtonSales.Click
        Sales.Show()
    End Sub

    Private Sub ButtonExit_Click(sender As Object, e As EventArgs) Handles ButtonExit.Click
        Application.Exit()
    End Sub

    Private Sub MainMenu_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        userID = Login.userID

        LabelDate.Text = Date.UtcNow.Date
        LabelUsername.Text = Login.userType

        If Login.userType <> "Manager" Then
            ButtonProducts.Enabled = False
            ButtonStaff.Enabled = False
            ButtonTransactions.Enabled = False
        End If
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