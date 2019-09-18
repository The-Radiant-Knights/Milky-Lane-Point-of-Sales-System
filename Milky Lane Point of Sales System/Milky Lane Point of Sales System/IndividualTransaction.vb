Public Class IndividualTransaction
    Private Sub ButtonNextTransaction_Click(sender As Object, e As EventArgs) Handles ButtonNextTransaction.Click
        BindingSourceInvoice.MoveNext()
    End Sub

    Private Sub ButtonPreviousTransaction_Click(sender As Object, e As EventArgs) Handles ButtonPreviousTransaction.Click
        BindingSourceInvoice.MovePrevious()
    End Sub

    Private Sub ButtonUpdateTransaction_Click(sender As Object, e As EventArgs) Handles ButtonUpdateTransaction.Click
        Try
            BindingSourceInvoice.EndEdit()
            TblInvoiceTableAdapter.Update(Ist2gqDataSet)
            MessageBox.Show("Customer updated/added successfully")
        Catch ex As Exception
            MessageBox.Show("Error Occurred")
        End Try
    End Sub

    Private Sub ButtonAddTransaction_Click(sender As Object, e As EventArgs) Handles ButtonAddTransaction.Click
        BindingSourceInvoice.MoveLast()
        BindingSourceInvoice.AddNew()
    End Sub

    Private Sub IndividualTransaction_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TblInvoiceTableAdapter.Fill(Ist2gqDataSet.tblInvoice)
    End Sub
End Class