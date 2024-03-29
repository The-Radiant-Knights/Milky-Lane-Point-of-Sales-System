﻿Public Class Transactions

    Private Sub ButtonAddTransaction_Click(sender As Object, e As EventArgs) Handles ButtonAddTransaction.Click
        AddTransaction.Show()
    End Sub

    Private Sub ButtonUpdate_Click(sender As Object, e As EventArgs) Handles ButtonUpdate.Click
        IndividualTransaction.Show()
    End Sub

    Private Sub Transactions_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Ist2gqDataSet.tblInvoice' table. You can move, or remove it, as needed.
        Me.TblInvoiceTableAdapter.Fill(Me.Ist2gqDataSet.tblInvoice)

    End Sub

    Private Sub ButtonRemoveCustomer_Click(sender As Object, e As EventArgs) Handles ButtonRemoveCustomer.Click
        Dim choice As DialogResult
        choice = MessageBox.Show("Are you sure you want to delete this record", "Confirmation", MessageBoxButtons.YesNo)
        If choice = DialogResult.Yes Then
            TblInvoiceBindingSource.RemoveAt(DataGridView1.CurrentRow.Index)
            TblInvoiceBindingSource.EndEdit()
            TblInvoiceTableAdapter.Update(Ist2gqDataSet)
        Else
            MessageBox.Show("Deletion Cancelled")
        End If
    End Sub

    Private Sub ButtonRefresh_Click(sender As Object, e As EventArgs) Handles ButtonRefresh.Click
        Me.TblInvoiceTableAdapter.Fill(Me.Ist2gqDataSet.tblInvoice)
    End Sub

    Private Sub ButtonSearch_Click(sender As Object, e As EventArgs) Handles ButtonSearch.Click
        Dim search As Int16 = Convert.ToInt16(TextBox1.Text.Trim())

        Me.TblInvoiceTableAdapter.FillByInvoiceNo(Me.Ist2gqDataSet.tblInvoice, search)
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        Try
            Dim search As Int16 = Convert.ToInt16(TextBox1.Text.Trim())

            Me.TblInvoiceTableAdapter.FillByInvoiceNo(Me.Ist2gqDataSet.tblInvoice, search)
        Catch ex As Exception
            MessageBox.Show("An Error Occurred!")
            TextBox1.Clear()
        End Try
    End Sub

    Private Sub ButtonStatistics_Click(sender As Object, e As EventArgs) Handles ButtonStatistics.Click
        TransactionStatistics.Show()
    End Sub
End Class