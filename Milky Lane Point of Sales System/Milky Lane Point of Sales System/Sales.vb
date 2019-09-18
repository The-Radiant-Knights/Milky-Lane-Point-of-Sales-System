Public Class Sales
    Private Sub ButtonNewCustomer_Click(sender As Object, e As EventArgs) Handles ButtonNewCustomer.Click
        AddCustomer.Show()
    End Sub

    Private Sub Sales_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Ist2gqDataSet.tblProduct' table. You can move, or remove it, as needed.
        Me.TblProductTableAdapter.Fill(Me.Ist2gqDataSet.tblProduct)

    End Sub

    Private Sub ButtonSearch_Click(sender As Object, e As EventArgs) Handles ButtonSearch.Click
        Me.TblProductTableAdapter.FillByDescription(Me.Ist2gqDataSet.tblProduct, "%" + TextBoxSearch.Text + "%")
    End Sub

    Private Sub ButtonRefresh_Click(sender As Object, e As EventArgs) Handles ButtonRefresh.Click
        Me.TblProductTableAdapter.Fill(Me.Ist2gqDataSet.tblProduct)
    End Sub

    Private Sub ButtonVerifyCustomer_Click(sender As Object, e As EventArgs) Handles ButtonVerifyCustomer.Click
        Dim numCustomers As Integer = Me.TblCustomerTableAdapter.getNumberCustomers(TextBoxPhoneNumber.Text)
        MessageBox.Show("Customer exists.")
    End Sub

    Private Sub ButtonAdd_Click(sender As Object, e As EventArgs) Handles ButtonAdd.Click

    End Sub
End Class