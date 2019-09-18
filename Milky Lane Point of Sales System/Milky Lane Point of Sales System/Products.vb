Public Class Products
    Private Sub ButtonAddProduct_Click(sender As Object, e As EventArgs) Handles ButtonAddProduct.Click
        AddProduct.Show()
    End Sub

    Private Sub ButtonUpdate_Click(sender As Object, e As EventArgs) Handles ButtonUpdate.Click
        IndividualProduct.Show()
    End Sub
End Class