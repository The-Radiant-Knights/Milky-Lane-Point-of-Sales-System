Public Class IndividualProduct
    Private Sub IndividualProduct_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.TblProductTableAdapter1.Fill(Me.Ist2gqDataSet1.tblProduct)
    End Sub

    Private Sub ButtonNextProduct_Click(sender As Object, e As EventArgs) Handles ButtonNextProduct.Click
        BindingSourceProduct.MoveNext()
    End Sub

    Private Sub ButtonPreviousProduct_Click(sender As Object, e As EventArgs) Handles ButtonPreviousProduct.Click
        BindingSourceProduct.MovePrevious()
    End Sub

    Private Sub ButtonAddProduct_Click(sender As Object, e As EventArgs) Handles ButtonAddProduct.Click
        BindingSourceProduct.MoveLast()
        BindingSourceProduct.AddNew()
        Dim numProducts As Integer = Ist2gqDataSet1.tblProduct.Rows.Count
        TextBoxID.Text = numProducts + 1
    End Sub

    Private Sub ButtonUpdateProduct_Click(sender As Object, e As EventArgs) Handles ButtonUpdateProduct.Click
        Try
            BindingSourceProduct.EndEdit()
            TblProductTableAdapter1.Update(Ist2gqDataSet1)
            MessageBox.Show("Product updated/added successfully")
        Catch ex As Exception
            MessageBox.Show("Error Occurred")
        End Try
    End Sub

    Private Sub ButtonRemoveProduct_Click(sender As Object, e As EventArgs) Handles ButtonRemoveProduct.Click
        Dim choice As Integer
        choice = MessageBox.Show("Are you sure you want to delete this record", "Confirmation", MessageBoxButtons.YesNo)
        If choice = DialogResult.Yes Then
            BindingSourceProduct.RemoveCurrent()
            BindingSourceProduct.EndEdit()
            TblProductTableAdapter1.Update(Ist2gqDataSet1)
        Else
            MessageBox.Show("Deletion Cancelled")
        End If
    End Sub
End Class