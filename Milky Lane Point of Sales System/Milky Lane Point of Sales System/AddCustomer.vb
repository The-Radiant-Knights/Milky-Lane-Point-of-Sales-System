Public Class AddCustomer
    Private Sub AddCustomer_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.TblCustomerTableAdapter.Fill(Me.Ist2gqDataSet.tblCustomer)
        BindingSourceCustomer.MoveLast()
        BindingSourceCustomer.AddNew()
    End Sub

    Private Sub ButtonAddCustomer_Click(sender As Object, e As EventArgs) Handles ButtonAddCustomer.Click
        Try
            BindingSourceCustomer.EndEdit()
            TblCustomerTableAdapter.Update(Ist2gqDataSet)
            Me.Close()
        Catch ex As Exception
            MessageBox.Show("An Error Occurred!")
        End Try
    End Sub
End Class