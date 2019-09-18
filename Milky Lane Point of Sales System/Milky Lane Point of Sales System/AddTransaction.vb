Public Class AddTransaction
    Private Sub AddTransaction_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.TblInvoiceTableAdapter1.Fill(Me.Ist2gqDataSet.tblInvoice)
        BindingSourceInvoice.MoveLast()
        BindingSourceInvoice.AddNew()
        Dim numProducts As Integer = Ist2gqDataSet.tblInvoice.Rows.Count
        TextBoxID.Text = numProducts + 1
    End Sub

    Private Sub ButtonAddCustomer_Click(sender As Object, e As EventArgs) Handles ButtonAddCustomer.Click
        Try
            BindingSourceInvoice.EndEdit()
            TblInvoiceTableAdapter1.Update(Ist2gqDataSet)
            MessageBox.Show("Product updated/added successfully")
            Me.Close()
        Catch ex As Exception
            MessageBox.Show("Error Occurred")
        End Try
    End Sub
End Class