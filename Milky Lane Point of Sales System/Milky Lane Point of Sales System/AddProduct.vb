Public Class AddProduct
    Private Sub ButtonAddCustomer_Click(sender As Object, e As EventArgs) Handles ButtonAddProduct.Click
        Try
            BindingSourceProduct.EndEdit()
            TblProductTableAdapter1.Update(Ist2gqDataSet1)
            MessageBox.Show("Customer updated/added successfully")
            Me.Close()
        Catch ex As Exception
            MessageBox.Show("Error Occurred")
        End Try
    End Sub

    Private Sub AddProduct_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.TblProductTableAdapter1.Fill(Me.Ist2gqDataSet1.tblProduct)
        BindingSourceProduct.MoveLast()
        BindingSourceProduct.AddNew()
        Dim numProducts As Integer = Ist2gqDataSet1.tblProduct.Rows.Count
        TextBoxID.Text = numProducts + 1
    End Sub
End Class