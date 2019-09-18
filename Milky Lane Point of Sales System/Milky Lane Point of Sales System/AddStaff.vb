Public Class AddStaff
    Private Sub ButtonAddEmployee_Click(sender As Object, e As EventArgs) Handles ButtonAddEmployee.Click
        Try
            BindingSourceStaff.EndEdit()
            TblStaffTableAdapter1.Update(Ist2gqDataSet)
            MessageBox.Show("Staff updated/added successfully")
            Me.Close()
        Catch ex As Exception
            MessageBox.Show("Error Occurred")
        End Try
    End Sub

    Private Sub AddStaff_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.TblStaffTableAdapter1.Fill(Me.Ist2gqDataSet.tblStaff)
        BindingSourceStaff.MoveLast()
        BindingSourceStaff.AddNew()
        Dim numProducts As Integer = Ist2gqDataSet.tblStaff.Rows.Count
        TextBoxID.Text = numProducts + 1
    End Sub
End Class