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
End Class