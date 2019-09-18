<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AddTransaction
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
        Me.ButtonAddCustomer = New System.Windows.Forms.Button()
        Me.LabelAddTransaction = New System.Windows.Forms.Label()
        Me.TextBoxStaffID = New System.Windows.Forms.TextBox()
        Me.LabelStaffID = New System.Windows.Forms.Label()
        Me.labelDate = New System.Windows.Forms.Label()
        Me.TextBoxAmountPaid = New System.Windows.Forms.TextBox()
        Me.LabelAmountPaid = New System.Windows.Forms.Label()
        Me.TextBoxAmount = New System.Windows.Forms.TextBox()
        Me.LabelFirstAmount = New System.Windows.Forms.Label()
        Me.DateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.SuspendLayout()
        '
        'ButtonAddCustomer
        '
        Me.ButtonAddCustomer.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonAddCustomer.Location = New System.Drawing.Point(252, 246)
        Me.ButtonAddCustomer.Name = "ButtonAddCustomer"
        Me.ButtonAddCustomer.Size = New System.Drawing.Size(165, 40)
        Me.ButtonAddCustomer.TabIndex = 19
        Me.ButtonAddCustomer.Text = "Add Customer"
        Me.ButtonAddCustomer.UseVisualStyleBackColor = True
        '
        'LabelAddTransaction
        '
        Me.LabelAddTransaction.AutoSize = True
        Me.LabelAddTransaction.BackColor = System.Drawing.Color.Transparent
        Me.LabelAddTransaction.Font = New System.Drawing.Font("Arial Rounded MT Bold", 18.0!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelAddTransaction.Location = New System.Drawing.Point(100, 27)
        Me.LabelAddTransaction.Name = "LabelAddTransaction"
        Me.LabelAddTransaction.Size = New System.Drawing.Size(261, 28)
        Me.LabelAddTransaction.TabIndex = 18
        Me.LabelAddTransaction.Text = "Add New Transaction"
        '
        'TextBoxStaffID
        '
        Me.TextBoxStaffID.Location = New System.Drawing.Point(183, 196)
        Me.TextBoxStaffID.Name = "TextBoxStaffID"
        Me.TextBoxStaffID.Size = New System.Drawing.Size(234, 20)
        Me.TextBoxStaffID.TabIndex = 17
        '
        'LabelStaffID
        '
        Me.LabelStaffID.AutoSize = True
        Me.LabelStaffID.BackColor = System.Drawing.Color.Transparent
        Me.LabelStaffID.Font = New System.Drawing.Font("Arial Rounded MT Bold", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelStaffID.Location = New System.Drawing.Point(28, 199)
        Me.LabelStaffID.Name = "LabelStaffID"
        Me.LabelStaffID.Size = New System.Drawing.Size(67, 17)
        Me.LabelStaffID.TabIndex = 16
        Me.LabelStaffID.Text = "Staff ID:"
        '
        'labelDate
        '
        Me.labelDate.AutoSize = True
        Me.labelDate.BackColor = System.Drawing.Color.Transparent
        Me.labelDate.Font = New System.Drawing.Font("Arial Rounded MT Bold", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labelDate.Location = New System.Drawing.Point(28, 159)
        Me.labelDate.Name = "labelDate"
        Me.labelDate.Size = New System.Drawing.Size(47, 17)
        Me.labelDate.TabIndex = 14
        Me.labelDate.Text = "Date:"
        '
        'TextBoxAmountPaid
        '
        Me.TextBoxAmountPaid.Location = New System.Drawing.Point(183, 114)
        Me.TextBoxAmountPaid.Name = "TextBoxAmountPaid"
        Me.TextBoxAmountPaid.Size = New System.Drawing.Size(234, 20)
        Me.TextBoxAmountPaid.TabIndex = 13
        '
        'LabelAmountPaid
        '
        Me.LabelAmountPaid.AutoSize = True
        Me.LabelAmountPaid.BackColor = System.Drawing.Color.Transparent
        Me.LabelAmountPaid.Font = New System.Drawing.Font("Arial Rounded MT Bold", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelAmountPaid.Location = New System.Drawing.Point(28, 117)
        Me.LabelAmountPaid.Name = "LabelAmountPaid"
        Me.LabelAmountPaid.Size = New System.Drawing.Size(105, 17)
        Me.LabelAmountPaid.TabIndex = 12
        Me.LabelAmountPaid.Text = "Amount Paid:"
        '
        'TextBoxAmount
        '
        Me.TextBoxAmount.Location = New System.Drawing.Point(183, 79)
        Me.TextBoxAmount.Name = "TextBoxAmount"
        Me.TextBoxAmount.Size = New System.Drawing.Size(234, 20)
        Me.TextBoxAmount.TabIndex = 11
        '
        'LabelFirstAmount
        '
        Me.LabelFirstAmount.AutoSize = True
        Me.LabelFirstAmount.BackColor = System.Drawing.Color.Transparent
        Me.LabelFirstAmount.Font = New System.Drawing.Font("Arial Rounded MT Bold", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelFirstAmount.Location = New System.Drawing.Point(28, 79)
        Me.LabelFirstAmount.Name = "LabelFirstAmount"
        Me.LabelFirstAmount.Size = New System.Drawing.Size(69, 17)
        Me.LabelFirstAmount.TabIndex = 10
        Me.LabelFirstAmount.Text = "Amount:"
        '
        'DateTimePicker
        '
        Me.DateTimePicker.Location = New System.Drawing.Point(183, 159)
        Me.DateTimePicker.Name = "DateTimePicker"
        Me.DateTimePicker.Size = New System.Drawing.Size(234, 20)
        Me.DateTimePicker.TabIndex = 20
        '
        'AddTransaction
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Milky_Lane_Point_of_Sales_System.My.Resources.Resources.Background
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(456, 306)
        Me.Controls.Add(Me.DateTimePicker)
        Me.Controls.Add(Me.ButtonAddCustomer)
        Me.Controls.Add(Me.LabelAddTransaction)
        Me.Controls.Add(Me.TextBoxStaffID)
        Me.Controls.Add(Me.LabelStaffID)
        Me.Controls.Add(Me.labelDate)
        Me.Controls.Add(Me.TextBoxAmountPaid)
        Me.Controls.Add(Me.LabelAmountPaid)
        Me.Controls.Add(Me.TextBoxAmount)
        Me.Controls.Add(Me.LabelFirstAmount)
        Me.Font = New System.Drawing.Font("Arial Rounded MT Bold", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "AddTransaction"
        Me.Text = "Add Transaction"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ButtonAddCustomer As Button
    Friend WithEvents LabelAddTransaction As Label
    Friend WithEvents TextBoxStaffID As TextBox
    Friend WithEvents LabelStaffID As Label
    Friend WithEvents labelDate As Label
    Friend WithEvents TextBoxAmountPaid As TextBox
    Friend WithEvents LabelAmountPaid As Label
    Friend WithEvents TextBoxAmount As TextBox
    Friend WithEvents LabelFirstAmount As Label
    Friend WithEvents DateTimePicker As DateTimePicker
End Class
