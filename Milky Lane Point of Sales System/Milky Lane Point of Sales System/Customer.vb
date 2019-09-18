Public Class Customer
    Private Sub ButtonAddCustomer_Click(sender As Object, e As EventArgs) Handles ButtonAddCustomer.Click
        AddCustomer.Show()
    End Sub

    Private Sub ButtonUpdate_Click(sender As Object, e As EventArgs) Handles ButtonUpdate.Click
        IndividualCustomer.Show()
    End Sub

    Private Sub Customer_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Ist2gqDataSet.tblCustomer' table. You can move, or remove it, as needed.
        Me.TblCustomerTableAdapter.Fill(Me.Ist2gqDataSet.tblCustomer)

    End Sub

    Private Sub ButtonSearch_Click(sender As Object, e As EventArgs) Handles ButtonSearch.Click
        Dim search As String = "%" + TextBoxSearch.Text + "%"

        Me.TblCustomerTableAdapter.FillByPhoneNumber(Me.Ist2gqDataSet.tblCustomer, search)
    End Sub

    Private Sub ButtonRemoveCustomer_Click(sender As Object, e As EventArgs) Handles ButtonRemoveCustomer.Click
        Dim choice As DialogResult
        choice = MessageBox.Show("Are you sure you want to delete this record", "Confirmation", MessageBoxButtons.YesNo)
        If choice = DialogResult.Yes Then
            TblCustomerBindingSource.RemoveAt(DataGridView1.CurrentRow.Index)
            TblCustomerBindingSource.EndEdit()
            TblCustomerTableAdapter.Update(Ist2gqDataSet)
        Else
            MessageBox.Show("Deletion Cancelled")
        End If
    End Sub

    Private Sub ButtonRefresh_Click(sender As Object, e As EventArgs) Handles ButtonRefresh.Click
        Me.TblCustomerTableAdapter.Fill(Me.Ist2gqDataSet.tblCustomer)
    End Sub
End Class