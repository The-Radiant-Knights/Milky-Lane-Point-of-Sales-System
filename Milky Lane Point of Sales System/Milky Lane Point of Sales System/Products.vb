Public Class Products
    Private Sub ButtonAddProduct_Click(sender As Object, e As EventArgs) Handles ButtonAddProduct.Click
        AddProduct.Show()
    End Sub

    Private Sub ButtonUpdate_Click(sender As Object, e As EventArgs) Handles ButtonUpdate.Click
        IndividualProduct.Show()
    End Sub

    Private Sub Products_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Ist2gqDataSet.tblProduct' table. You can move, or remove it, as needed.
        Me.TblProductTableAdapter.Fill(Me.Ist2gqDataSet.tblProduct)

    End Sub

    Private Sub ButtonRefresh_Click(sender As Object, e As EventArgs) Handles ButtonRefresh.Click
        Me.TblProductTableAdapter.Fill(Me.Ist2gqDataSet.tblProduct)
    End Sub

    Private Sub ButtonRemoveProduct_Click(sender As Object, e As EventArgs) Handles ButtonRemoveProduct.Click
        Dim choice As DialogResult
        choice = MessageBox.Show("Are you sure you want to delete this record", "Confirmation", MessageBoxButtons.YesNo)
        If choice = DialogResult.Yes Then
            TblProductBindingSource.RemoveAt(DataGridView1.CurrentRow.Index)
            TblProductBindingSource.EndEdit()
            TblProductTableAdapter.Update(Ist2gqDataSet)
        Else
            MessageBox.Show("Deletion Cancelled")
        End If
    End Sub

    Private Sub ButtonSearch_Click(sender As Object, e As EventArgs) Handles ButtonSearch.Click
        Dim search As String = "%" + TextBoxSearch.Text + "%"

        Me.TblProductTableAdapter.FillByDescription(Me.Ist2gqDataSet.tblProduct, search)
    End Sub

    Private Sub TextBoxSearch_TextChanged(sender As Object, e As EventArgs) Handles TextBoxSearch.TextChanged
        Dim search As String = "%" + TextBoxSearch.Text + "%"

        Me.TblProductTableAdapter.FillByDescription(Me.Ist2gqDataSet.tblProduct, search)
    End Sub
End Class