Public Class Sales
    Private Sub ButtonNewCustomer_Click(sender As Object, e As EventArgs) Handles ButtonNewCustomer.Click
        AddCustomer.Show()
    End Sub

    Private Sub Sales_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Ist2gqDataSet.tblProduct' table. You can move, or remove it, as needed.
        Me.TblProductTableAdapter.Fill(Me.Ist2gqDataSet.tblProduct)

        If (Date.Today.Month.Equals("January") And Date.Today.Day.Equals(1)) Then
            Me.TblCustomerTableAdapter.setPointsToZero()
        End If

    End Sub

    Private Sub ButtonSearch_Click(sender As Object, e As EventArgs) Handles ButtonSearch.Click
        Me.TblProductTableAdapter.FillByDescription(Me.Ist2gqDataSet.tblProduct, "%" + TextBoxSearch.Text + "%")
    End Sub

    Private Sub ButtonRefresh_Click(sender As Object, e As EventArgs) Handles ButtonRefresh.Click
        Me.TblProductTableAdapter.Fill(Me.Ist2gqDataSet.tblProduct)
    End Sub

    Private Sub ButtonVerifyCustomer_Click(sender As Object, e As EventArgs) Handles ButtonVerifyCustomer.Click
        Dim numCustomers As Integer = Me.TblCustomerTableAdapter.getNumberCustomers(TextBoxPhoneNumber.Text)

        If (numCustomers > 0) Then
            MessageBox.Show("Customer exists.")
        Else
            MessageBox.Show("Customer does not exists.")
        End If

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

            Dim numCustomers As Integer = Me.TblCustomerTableAdapter.getNumberCustomers(TextBoxPhoneNumber.Text)

            If (TextBoxPhoneNumber.Text <> "" And numCustomers > 0) Then
                updateLoyaltyPoints(amountDue)
            ElseIf (TextBoxPhoneNumber.Text <> "" And numCustomers < 1) Then
                MessageBox.Show("Customer does not exists - Transaction Failed.")
                TextBoxPhoneNumber.Text = ""
                TextBoxPhoneNumber.Select()
                Exit Sub
            End If

            MessageBox.Show("Transaction processed successfully!")

            TextBoxAmountDue.Text = 0
            TextBoxAmountReceived.Text = 0
            TextBoxChange.Text = 0
            TextBoxPhoneNumber.Text = ""

            DataGridView1.Rows.Clear()

        Catch ex As Exception

            MessageBox.Show("An Error Occurred!")

        End Try
    End Sub

    Private Sub updateLoyaltyPoints(amount As Double)
        Dim numPoints As Integer = TblCustomerTableAdapter.getLoyaltyPoints(TextBoxPhoneNumber.Text)
        numPoints += amount * 0.1
        TblCustomerTableAdapter.updateLoyaltyPoints(numPoints.ToString(), TextBoxPhoneNumber.Text)
    End Sub

    Private Sub TextBoxSearch_TextChanged(sender As Object, e As EventArgs) Handles TextBoxSearch.TextChanged
        Dim search As String = "%" + TextBoxSearch.Text + "%"

        Me.TblProductTableAdapter.FillByDescription(Me.Ist2gqDataSet.tblProduct, search)
    End Sub

    Private Sub ButtonPrintReceipt_Click(sender As Object, e As EventArgs) Handles ButtonPrintReceipt.Click
        PrintDocument.Print()
    End Sub

    Private Sub PrintDocument_PrintPage(sender As Object, e As Printing.PrintPageEventArgs) Handles PrintDocument.PrintPage
        e.Graphics.DrawString("             ----------Milky Lane----------", TextBoxAmountDue.Font, Brushes.Black, 110, 100)
        e.Graphics.DrawString("Description  Price", TextBoxAmountDue.Font, Brushes.Black, 100, 120)

        Dim y As Integer = 140

        e.Graphics.DrawString("------------------------------------------------------------", TextBoxAmountDue.Font, Brushes.Black, 100, y)
        y += 20

        For Each row As DataGridViewRow In DataGridView1.Rows
            e.Graphics.DrawString(row.Cells(1).Value & "    " & row.Cells(2).Value, TextBoxAmountDue.Font, Brushes.Black, 100, y)
            y += 20
        Next

        e.Graphics.DrawString("------------------------------------------------------------", TextBoxAmountDue.Font, Brushes.Black, 100, y)
        y += 20

        e.Graphics.DrawString("Amount Due: " & TextBoxAmountDue.Text, TextBoxAmountDue.Font, Brushes.Black, 100, y)
        y += 20

        e.Graphics.DrawString("Amount Received: " & TextBoxAmountReceived.Text, TextBoxAmountDue.Font, Brushes.Black, 100, y)
        y += 20

        e.Graphics.DrawString("Change: " & TextBoxChange.Text, TextBoxAmountDue.Font, Brushes.Black, 100, y)
        y += 20

        e.Graphics.DrawString("------------------------------------------------------------", TextBoxAmountDue.Font, Brushes.Black, 100, y)
        y += 20

        e.Graphics.DrawString("Cashier Name: " & TblStaffTableAdapter.getStaffFirstName(MainMenu.userID) & " " & TblStaffTableAdapter.getStaffLastName(MainMenu.userID), TextBoxAmountDue.Font, Brushes.Black, 100, y)
        y += 20

        e.Graphics.DrawString("Thank you for shopping with us!", TextBoxAmountDue.Font, Brushes.Black, 100, y)
        y += 20

        e.Graphics.DrawString("------------------------------------------------------------", TextBoxAmountDue.Font, Brushes.Black, 100, y)
    End Sub

End Class