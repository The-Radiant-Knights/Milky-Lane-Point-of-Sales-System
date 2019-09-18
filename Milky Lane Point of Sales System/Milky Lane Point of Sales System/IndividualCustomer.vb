Public Class IndividualCustomer
    Private Sub IndividualCustomer_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TblCustomerTableAdapter.Fill(Ist2gqDataSet.tblCustomer)
    End Sub

    Private Sub ButtonNextCustomer_Click(sender As Object, e As EventArgs) Handles ButtonNextCustomer.Click
        BindingSourceCustomer.MoveNext()
    End Sub

    Private Sub ButtonPreviousCustomer_Click(sender As Object, e As EventArgs) Handles ButtonPreviousCustomer.Click
        BindingSourceCustomer.MovePrevious()
    End Sub

    Private Sub ButtonUpdateCustomer_Click(sender As Object, e As EventArgs) Handles ButtonUpdateCustomer.Click
        Try
            BindingSourceCustomer.EndEdit()
            TblCustomerTableAdapter.Update(Ist2gqDataSet)
            MessageBox.Show("Customer updated/added successfully")
        Catch ex As Exception
            MessageBox.Show("Error Occurred")
        End Try
    End Sub

    Private Sub ButtonAddCustomer_Click(sender As Object, e As EventArgs) Handles ButtonAddCustomer.Click
        BindingSourceCustomer.MoveLast()
        BindingSourceCustomer.AddNew()
    End Sub

    Private Sub ButtonRemoveCustomer_Click(sender As Object, e As EventArgs) Handles ButtonRemoveCustomer.Click
        Dim choice As Integer
        choice = MessageBox.Show("Are you sure you want to delete this record", "Confirmation", MessageBoxButtons.YesNo)
        If choice = DialogResult.Yes Then
            BindingSourceCustomer.RemoveCurrent()
            BindingSourceCustomer.EndEdit()
            TblCustomerTableAdapter.Update(Ist2gqDataSet)
        Else
            MessageBox.Show("Deletion Cancelled")
        End If
    End Sub
End Class