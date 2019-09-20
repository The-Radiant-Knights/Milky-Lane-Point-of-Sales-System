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
        ' DataGridView1.Rows.Add()

        If (DataGridView2.Rows.Count > 0) Then
            If (DataGridView2.CurrentRow IsNot Nothing) Then
                DataGridView1.Rows.Add(DataGridView2.CurrentRow.Cells(0).Value,
                                       DataGridView2.CurrentRow.Cells(1).Value,
                                       DataGridView2.CurrentRow.Cells(2).Value,
                                       DataGridView2.CurrentRow.Cells(3).Value)
            End If
        End If

        Dim amountDue As Double = 0.0

        For Each row As DataGridViewRow In DataGridView1.Rows
            If (row.Cells(2).Value IsNot Nothing) Then
                amountDue += Double.Parse(row.Cells(2).Value)
            End If
        Next

        TextBoxAmountDue.Text = amountDue

    End Sub

    Private Sub ButtonCalculateChange_Click(sender As Object, e As EventArgs) Handles ButtonCalculateChange.Click
        Try
            Dim amountDue As Double = Double.Parse(TextBoxAmountDue.Text)
            Dim amountReceived As Double = Double.Parse(TextBoxAmountReceived.Text)

            If amountDue < amountReceived Then
                TextBoxChange.Text = amountReceived - amountDue
            ElseIf amountReceived < amountDue Then
                TextBoxChange.Text = 0
            Else
                TextBoxChange.Text = 0
            End If
        Catch ex As Exception
            MessageBox.Show("An Error Occurred!")
        End Try
    End Sub

    Private Sub ButtonRemove_Click(sender As Object, e As EventArgs) Handles ButtonRemove.Click
        Try
            Dim choice As DialogResult
            choice = MessageBox.Show("Are you sure you want to remove this product", "Confirmation", MessageBoxButtons.YesNo)
            If choice = DialogResult.Yes Then
                DataGridView1.Rows.RemoveAt(DataGridView1.CurrentRow.Index)
                MessageBox.Show("Product Removed")

                Dim amountDue As Double = 0.0

                For Each row As DataGridViewRow In DataGridView1.Rows
                    If (row.Cells(2).Value IsNot Nothing) Then
                        amountDue += Double.Parse(row.Cells(2).Value)
                    End If
                Next

                TextBoxAmountDue.Text = amountDue
            Else
                MessageBox.Show("Deletion Cancelled")
            End If
        Catch ex As Exception
            MessageBox.Show("An Error Occurred!")
        End Try
    End Sub

    Private Sub ButtonPay_Click(sender As Object, e As EventArgs) Handles ButtonPay.Click
        Try
            Dim amountDue As Double = Double.Parse(TextBoxAmountDue.Text)
            Dim change As Double = Double.Parse(TextBoxChange.Text)
            Dim amountReceived As Double = Double.Parse(TextBoxAmountReceived.Text)
            Dim todayDate As Date = Date.Now
            Dim staffID As Integer = MainMenu.userID
            TblInvoiceTableAdapter.InsertNewInvoice(amountDue, amountReceived, todayDate, staffID)

            updateLoyaltyPoints(amountDue)

            MessageBox.Show("Transaction processed successfully!")

            TextBoxAmountDue.Text = 0
            TextBoxAmountReceived.Text = 0
            TextBoxChange.Text = 0
            TextBoxPhoneNumber.Text = 0

            DataGridView1.Rows.Clear()

        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub

    Private Sub updateLoyaltyPoints(amount As Double)
        Dim numPoints As Integer = TblCustomerTableAdapter.getLoyaltyPoints(TextBoxPhoneNumber.Text)
        numPoints += amount * 0.1
        TblCustomerTableAdapter.updateLoyaltyPoints(numPoints.ToString(), TextBoxPhoneNumber.Text)
    End Sub

End Class