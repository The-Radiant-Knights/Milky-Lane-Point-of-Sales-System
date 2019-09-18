Public Class AddCustomer
    Private Sub AddCustomer_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        BindingSourceCustomer.MoveLast()
    End Sub

    Private Sub ButtonAddCustomer_Click(sender As Object, e As EventArgs) Handles ButtonAddCustomer.Click
        Try
            BindingSourceCustomer.AddNew()
            BindingSourceCustomer.EndEdit()
            TblCustomerTableAdapter.Update(Ist2gqDataSet)
        Catch ex As Exception
            MessageBox.Show("An Error Occurred!")
        End Try
    End Sub
End Class