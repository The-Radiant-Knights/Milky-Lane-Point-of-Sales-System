Public Class IndividualStaff
    Private Sub IndividualStaff_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TblStaffTableAdapter1.Fill(Ist2gqDataSet1.tblStaff)
    End Sub

    Private Sub ButtonUpdateEmployee_Click(sender As Object, e As EventArgs) Handles ButtonUpdateEmployee.Click
        Try
            BindingSourceStaff.EndEdit()
            TblStaffTableAdapter1.Update(Ist2gqDataSet1)
            MessageBox.Show("Customer updated/added successfully")
        Catch ex As Exception
            MessageBox.Show("Error Occurred")
        End Try
    End Sub

    Private Sub ButtonRemoveEmployee_Click(sender As Object, e As EventArgs) Handles ButtonRemoveEmployee.Click
        Dim choice As Integer
        choice = MessageBox.Show("Are you sure you want to delete this record", "Confirmation", MessageBoxButtons.YesNo)
        If choice = DialogResult.Yes Then
            BindingSourceStaff.RemoveCurrent()
            BindingSourceStaff.EndEdit()
            TblStaffTableAdapter1.Update(Ist2gqDataSet1)
        Else
            MessageBox.Show("Deletion Cancelled")
        End If
    End Sub

    Private Sub ButtonNextEmployee_Click(sender As Object, e As EventArgs) Handles ButtonNextEmployee.Click
        BindingSourceStaff.MoveNext()
    End Sub

    Private Sub ButtonPreviousEmployee_Click(sender As Object, e As EventArgs) Handles ButtonPreviousEmployee.Click
        BindingSourceStaff.MovePrevious()
    End Sub

    Private Sub ButtonAddEmployee_Click(sender As Object, e As EventArgs) Handles ButtonAddEmployee.Click
        BindingSourceStaff.MoveLast()
        BindingSourceStaff.AddNew()
        Dim numProducts As Integer = Ist2gqDataSet1.tblProduct.Rows.Count
        TextBoxID.Text = numProducts + 1
    End Sub
End Class