Public Class Staff
    Private Sub ButtonUpdate_Click(sender As Object, e As EventArgs) Handles ButtonUpdate.Click
        IndividualStaff.Show()
    End Sub

    Private Sub ButtonAddStaff_Click(sender As Object, e As EventArgs) Handles ButtonAddStaff.Click
        AddStaff.Show()
    End Sub

    Private Sub Staff_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Ist2gqDataSet.tblStaff' table. You can move, or remove it, as needed.
        Me.TblStaffTableAdapter.Fill(Me.Ist2gqDataSet.tblStaff)

    End Sub

    Private Sub ButtonSearch_Click(sender As Object, e As EventArgs) Handles ButtonSearch.Click
        Dim search As String = "%" + TextBoxSearch.Text + "%"

        Me.TblStaffTableAdapter.FillByName(Me.Ist2gqDataSet.tblStaff, search, search)
    End Sub

    Private Sub ButtonRefresh_Click(sender As Object, e As EventArgs) Handles ButtonRefresh.Click
        Me.TblStaffTableAdapter.Fill(Me.Ist2gqDataSet.tblStaff)
    End Sub

    Private Sub ButtonRemoveStaff_Click(sender As Object, e As EventArgs) Handles ButtonRemoveStaff.Click
        Dim choice As DialogResult
        choice = MessageBox.Show("Are you sure you want to delete this record", "Confirmation", MessageBoxButtons.YesNo)
        If choice = DialogResult.Yes Then
            TblStaffBindingSource.RemoveAt(DataGridView1.CurrentRow.Index)
            TblStaffBindingSource.EndEdit()
            TblStaffTableAdapter.Update(Ist2gqDataSet)
        Else
            MessageBox.Show("Deletion Cancelled")
        End If
    End Sub
End Class