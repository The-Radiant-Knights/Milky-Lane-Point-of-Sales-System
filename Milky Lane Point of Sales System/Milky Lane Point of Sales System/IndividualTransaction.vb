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
        Dim numProducts As Integer = Ist2gqDataSet.tblInvoice.Rows.Count
        TextBoxID.Text = numProducts + 1
    End Sub

    Private Sub IndividualTransaction_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TblInvoiceTableAdapter.Fill(Ist2gqDataSet.tblInvoice)
    End Sub

    Private Sub ButtonRemoveTransaction_Click(sender As Object, e As EventArgs) Handles ButtonRemoveTransaction.Click
        Dim choice As Integer
        choice = MessageBox.Show("Are you sure you want to delete this record", "Confirmation", MessageBoxButtons.YesNo)
        If choice = DialogResult.Yes Then
            BindingSourceInvoice.RemoveCurrent()
            BindingSourceInvoice.EndEdit()
            TblInvoiceTableAdapter.Update(Ist2gqDataSet)
        Else
            MessageBox.Show("Deletion Cancelled")
        End If
    End Sub
End Class