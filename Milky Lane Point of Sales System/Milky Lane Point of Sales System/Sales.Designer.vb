<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Sales
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.GroupBoxCustomerDetails = New System.Windows.Forms.GroupBox()
        Me.ButtonVerifyCustomer = New System.Windows.Forms.Button()
        Me.ButtonNewCustomer = New System.Windows.Forms.Button()
        Me.TextBoxPhoneNumber = New System.Windows.Forms.TextBox()
        Me.LabelPhoneNumber = New System.Windows.Forms.Label()
        Me.GroupBoxProducts = New System.Windows.Forms.GroupBox()
        Me.ButtonSearch = New System.Windows.Forms.Button()
        Me.LabelSearch = New System.Windows.Forms.Label()
        Me.TextBoxSearch = New System.Windows.Forms.TextBox()
        Me.GroupBoxInvoice = New System.Windows.Forms.GroupBox()
        Me.LabelChange = New System.Windows.Forms.Label()
        Me.LabelAmountReceived = New System.Windows.Forms.Label()
        Me.LabelAmountDue = New System.Windows.Forms.Label()
        Me.TextBoxChange = New System.Windows.Forms.TextBox()
        Me.TextBoxAmountReceived = New System.Windows.Forms.TextBox()
        Me.TextBoxAmountDue = New System.Windows.Forms.TextBox()
        Me.ButtonPay = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.DataGridView2 = New System.Windows.Forms.DataGridView()
        Me.GroupBoxCustomerDetails.SuspendLayout()
        Me.GroupBoxProducts.SuspendLayout()
        Me.GroupBoxInvoice.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBoxCustomerDetails
        '
        Me.GroupBoxCustomerDetails.BackColor = System.Drawing.Color.Transparent
        Me.GroupBoxCustomerDetails.Controls.Add(Me.ButtonVerifyCustomer)
        Me.GroupBoxCustomerDetails.Controls.Add(Me.ButtonNewCustomer)
        Me.GroupBoxCustomerDetails.Controls.Add(Me.TextBoxPhoneNumber)
        Me.GroupBoxCustomerDetails.Controls.Add(Me.LabelPhoneNumber)
        Me.GroupBoxCustomerDetails.Location = New System.Drawing.Point(13, 13)
        Me.GroupBoxCustomerDetails.Name = "GroupBoxCustomerDetails"
        Me.GroupBoxCustomerDetails.Size = New System.Drawing.Size(368, 115)
        Me.GroupBoxCustomerDetails.TabIndex = 0
        Me.GroupBoxCustomerDetails.TabStop = False
        Me.GroupBoxCustomerDetails.Text = "Customer Details"
        '
        'ButtonVerifyCustomer
        '
        Me.ButtonVerifyCustomer.Location = New System.Drawing.Point(240, 73)
        Me.ButtonVerifyCustomer.Name = "ButtonVerifyCustomer"
        Me.ButtonVerifyCustomer.Size = New System.Drawing.Size(106, 23)
        Me.ButtonVerifyCustomer.TabIndex = 3
        Me.ButtonVerifyCustomer.Text = "Verify Customer"
        Me.ButtonVerifyCustomer.UseVisualStyleBackColor = True
        '
        'ButtonNewCustomer
        '
        Me.ButtonNewCustomer.Location = New System.Drawing.Point(116, 73)
        Me.ButtonNewCustomer.Name = "ButtonNewCustomer"
        Me.ButtonNewCustomer.Size = New System.Drawing.Size(106, 23)
        Me.ButtonNewCustomer.TabIndex = 2
        Me.ButtonNewCustomer.Text = "New Customer"
        Me.ButtonNewCustomer.UseVisualStyleBackColor = True
        '
        'TextBoxPhoneNumber
        '
        Me.TextBoxPhoneNumber.Location = New System.Drawing.Point(116, 28)
        Me.TextBoxPhoneNumber.Name = "TextBoxPhoneNumber"
        Me.TextBoxPhoneNumber.Size = New System.Drawing.Size(230, 20)
        Me.TextBoxPhoneNumber.TabIndex = 1
        '
        'LabelPhoneNumber
        '
        Me.LabelPhoneNumber.AutoSize = True
        Me.LabelPhoneNumber.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelPhoneNumber.Location = New System.Drawing.Point(6, 29)
        Me.LabelPhoneNumber.Name = "LabelPhoneNumber"
        Me.LabelPhoneNumber.Size = New System.Drawing.Size(103, 20)
        Me.LabelPhoneNumber.TabIndex = 0
        Me.LabelPhoneNumber.Text = "Phone Number:"
        '
        'GroupBoxProducts
        '
        Me.GroupBoxProducts.BackColor = System.Drawing.Color.Transparent
        Me.GroupBoxProducts.Controls.Add(Me.DataGridView2)
        Me.GroupBoxProducts.Controls.Add(Me.ButtonSearch)
        Me.GroupBoxProducts.Controls.Add(Me.LabelSearch)
        Me.GroupBoxProducts.Controls.Add(Me.TextBoxSearch)
        Me.GroupBoxProducts.Location = New System.Drawing.Point(13, 135)
        Me.GroupBoxProducts.Name = "GroupBoxProducts"
        Me.GroupBoxProducts.Size = New System.Drawing.Size(368, 322)
        Me.GroupBoxProducts.TabIndex = 1
        Me.GroupBoxProducts.TabStop = False
        Me.GroupBoxProducts.Text = "Products"
        '
        'ButtonSearch
        '
        Me.ButtonSearch.Location = New System.Drawing.Point(240, 48)
        Me.ButtonSearch.Name = "ButtonSearch"
        Me.ButtonSearch.Size = New System.Drawing.Size(106, 23)
        Me.ButtonSearch.TabIndex = 5
        Me.ButtonSearch.Text = "Search"
        Me.ButtonSearch.UseVisualStyleBackColor = True
        '
        'LabelSearch
        '
        Me.LabelSearch.AutoSize = True
        Me.LabelSearch.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelSearch.Location = New System.Drawing.Point(6, 19)
        Me.LabelSearch.Name = "LabelSearch"
        Me.LabelSearch.Size = New System.Drawing.Size(55, 20)
        Me.LabelSearch.TabIndex = 4
        Me.LabelSearch.Text = "Search:"
        '
        'TextBoxSearch
        '
        Me.TextBoxSearch.Location = New System.Drawing.Point(116, 22)
        Me.TextBoxSearch.Name = "TextBoxSearch"
        Me.TextBoxSearch.Size = New System.Drawing.Size(230, 20)
        Me.TextBoxSearch.TabIndex = 4
        '
        'GroupBoxInvoice
        '
        Me.GroupBoxInvoice.BackColor = System.Drawing.Color.Transparent
        Me.GroupBoxInvoice.Controls.Add(Me.DataGridView1)
        Me.GroupBoxInvoice.Controls.Add(Me.LabelChange)
        Me.GroupBoxInvoice.Controls.Add(Me.LabelAmountReceived)
        Me.GroupBoxInvoice.Controls.Add(Me.LabelAmountDue)
        Me.GroupBoxInvoice.Controls.Add(Me.TextBoxChange)
        Me.GroupBoxInvoice.Controls.Add(Me.TextBoxAmountReceived)
        Me.GroupBoxInvoice.Controls.Add(Me.TextBoxAmountDue)
        Me.GroupBoxInvoice.Controls.Add(Me.ButtonPay)
        Me.GroupBoxInvoice.Location = New System.Drawing.Point(407, 13)
        Me.GroupBoxInvoice.Name = "GroupBoxInvoice"
        Me.GroupBoxInvoice.Size = New System.Drawing.Size(419, 444)
        Me.GroupBoxInvoice.TabIndex = 2
        Me.GroupBoxInvoice.TabStop = False
        Me.GroupBoxInvoice.Text = "Invoice"
        '
        'LabelChange
        '
        Me.LabelChange.AutoSize = True
        Me.LabelChange.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelChange.Location = New System.Drawing.Point(17, 376)
        Me.LabelChange.Name = "LabelChange"
        Me.LabelChange.Size = New System.Drawing.Size(59, 20)
        Me.LabelChange.TabIndex = 10
        Me.LabelChange.Text = "Change:"
        '
        'LabelAmountReceived
        '
        Me.LabelAmountReceived.AutoSize = True
        Me.LabelAmountReceived.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelAmountReceived.Location = New System.Drawing.Point(17, 350)
        Me.LabelAmountReceived.Name = "LabelAmountReceived"
        Me.LabelAmountReceived.Size = New System.Drawing.Size(120, 20)
        Me.LabelAmountReceived.TabIndex = 9
        Me.LabelAmountReceived.Text = "Amount Received:"
        '
        'LabelAmountDue
        '
        Me.LabelAmountDue.AutoSize = True
        Me.LabelAmountDue.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelAmountDue.Location = New System.Drawing.Point(17, 324)
        Me.LabelAmountDue.Name = "LabelAmountDue"
        Me.LabelAmountDue.Size = New System.Drawing.Size(86, 20)
        Me.LabelAmountDue.TabIndex = 8
        Me.LabelAmountDue.Text = "Amount Due:"
        '
        'TextBoxChange
        '
        Me.TextBoxChange.Location = New System.Drawing.Point(139, 376)
        Me.TextBoxChange.Name = "TextBoxChange"
        Me.TextBoxChange.Size = New System.Drawing.Size(230, 20)
        Me.TextBoxChange.TabIndex = 7
        '
        'TextBoxAmountReceived
        '
        Me.TextBoxAmountReceived.Location = New System.Drawing.Point(139, 350)
        Me.TextBoxAmountReceived.Name = "TextBoxAmountReceived"
        Me.TextBoxAmountReceived.Size = New System.Drawing.Size(230, 20)
        Me.TextBoxAmountReceived.TabIndex = 6
        '
        'TextBoxAmountDue
        '
        Me.TextBoxAmountDue.Location = New System.Drawing.Point(139, 324)
        Me.TextBoxAmountDue.Name = "TextBoxAmountDue"
        Me.TextBoxAmountDue.Size = New System.Drawing.Size(230, 20)
        Me.TextBoxAmountDue.TabIndex = 5
        '
        'ButtonPay
        '
        Me.ButtonPay.Location = New System.Drawing.Point(285, 409)
        Me.ButtonPay.Name = "ButtonPay"
        Me.ButtonPay.Size = New System.Drawing.Size(121, 23)
        Me.ButtonPay.TabIndex = 0
        Me.ButtonPay.Text = "Pay"
        Me.ButtonPay.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(17, 28)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(389, 280)
        Me.DataGridView1.TabIndex = 11
        '
        'DataGridView2
        '
        Me.DataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView2.Location = New System.Drawing.Point(10, 87)
        Me.DataGridView2.Name = "DataGridView2"
        Me.DataGridView2.Size = New System.Drawing.Size(346, 223)
        Me.DataGridView2.TabIndex = 12
        '
        'Sales
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Milky_Lane_Point_of_Sales_System.My.Resources.Resources.Background
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(838, 462)
        Me.Controls.Add(Me.GroupBoxInvoice)
        Me.Controls.Add(Me.GroupBoxProducts)
        Me.Controls.Add(Me.GroupBoxCustomerDetails)
        Me.Font = New System.Drawing.Font("Arial Rounded MT Bold", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "Sales"
        Me.Text = "Sales"
        Me.GroupBoxCustomerDetails.ResumeLayout(False)
        Me.GroupBoxCustomerDetails.PerformLayout()
        Me.GroupBoxProducts.ResumeLayout(False)
        Me.GroupBoxProducts.PerformLayout()
        Me.GroupBoxInvoice.ResumeLayout(False)
        Me.GroupBoxInvoice.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBoxCustomerDetails As GroupBox
    Friend WithEvents LabelPhoneNumber As Label
    Friend WithEvents ButtonVerifyCustomer As Button
    Friend WithEvents ButtonNewCustomer As Button
    Friend WithEvents TextBoxPhoneNumber As TextBox
    Friend WithEvents GroupBoxProducts As GroupBox
    Friend WithEvents ButtonSearch As Button
    Friend WithEvents LabelSearch As Label
    Friend WithEvents TextBoxSearch As TextBox
    Friend WithEvents GroupBoxInvoice As GroupBox
    Friend WithEvents LabelChange As Label
    Friend WithEvents LabelAmountReceived As Label
    Friend WithEvents LabelAmountDue As Label
    Friend WithEvents TextBoxChange As TextBox
    Friend WithEvents TextBoxAmountReceived As TextBox
    Friend WithEvents TextBoxAmountDue As TextBox
    Friend WithEvents ButtonPay As Button
    Friend WithEvents DataGridView2 As DataGridView
    Friend WithEvents DataGridView1 As DataGridView
End Class
