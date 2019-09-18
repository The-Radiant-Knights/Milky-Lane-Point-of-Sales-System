<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class IndividualTransaction
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
        Me.DateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.LabelTransaction = New System.Windows.Forms.Label()
        Me.TextBoxStaffID = New System.Windows.Forms.TextBox()
        Me.LabelStaffID = New System.Windows.Forms.Label()
        Me.labelDate = New System.Windows.Forms.Label()
        Me.TextBoxAmountPaid = New System.Windows.Forms.TextBox()
        Me.LabelAmountPaid = New System.Windows.Forms.Label()
        Me.TextBoxAmount = New System.Windows.Forms.TextBox()
        Me.LabelFirstAmount = New System.Windows.Forms.Label()
        Me.ButtonPreviousTransaction = New System.Windows.Forms.Button()
        Me.ButtonNextTransaction = New System.Windows.Forms.Button()
        Me.ButtonAddTransaction = New System.Windows.Forms.Button()
        Me.ButtonRemoveTransaction = New System.Windows.Forms.Button()
        Me.ButtonUpdateTransaction = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'DateTimePicker
        '
        Me.DateTimePicker.Location = New System.Drawing.Point(189, 156)
        Me.DateTimePicker.Name = "DateTimePicker"
        Me.DateTimePicker.Size = New System.Drawing.Size(234, 20)
        Me.DateTimePicker.TabIndex = 30
        '
        'LabelTransaction
        '
        Me.LabelTransaction.AutoSize = True
        Me.LabelTransaction.BackColor = System.Drawing.Color.Transparent
        Me.LabelTransaction.Font = New System.Drawing.Font("Arial Rounded MT Bold", 18.0!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelTransaction.Location = New System.Drawing.Point(153, 24)
        Me.LabelTransaction.Name = "LabelTransaction"
        Me.LabelTransaction.Size = New System.Drawing.Size(150, 28)
        Me.LabelTransaction.TabIndex = 28
        Me.LabelTransaction.Text = "Transaction"
        '
        'TextBoxStaffID
        '
        Me.TextBoxStaffID.Location = New System.Drawing.Point(189, 193)
        Me.TextBoxStaffID.Name = "TextBoxStaffID"
        Me.TextBoxStaffID.Size = New System.Drawing.Size(234, 20)
        Me.TextBoxStaffID.TabIndex = 27
        '
        'LabelStaffID
        '
        Me.LabelStaffID.AutoSize = True
        Me.LabelStaffID.BackColor = System.Drawing.Color.Transparent
        Me.LabelStaffID.Font = New System.Drawing.Font("Arial Rounded MT Bold", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelStaffID.Location = New System.Drawing.Point(34, 196)
        Me.LabelStaffID.Name = "LabelStaffID"
        Me.LabelStaffID.Size = New System.Drawing.Size(67, 17)
        Me.LabelStaffID.TabIndex = 26
        Me.LabelStaffID.Text = "Staff ID:"
        '
        'labelDate
        '
        Me.labelDate.AutoSize = True
        Me.labelDate.BackColor = System.Drawing.Color.Transparent
        Me.labelDate.Font = New System.Drawing.Font("Arial Rounded MT Bold", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labelDate.Location = New System.Drawing.Point(34, 156)
        Me.labelDate.Name = "labelDate"
        Me.labelDate.Size = New System.Drawing.Size(47, 17)
        Me.labelDate.TabIndex = 25
        Me.labelDate.Text = "Date:"
        '
        'TextBoxAmountPaid
        '
        Me.TextBoxAmountPaid.Location = New System.Drawing.Point(189, 111)
        Me.TextBoxAmountPaid.Name = "TextBoxAmountPaid"
        Me.TextBoxAmountPaid.Size = New System.Drawing.Size(234, 20)
        Me.TextBoxAmountPaid.TabIndex = 24
        '
        'LabelAmountPaid
        '
        Me.LabelAmountPaid.AutoSize = True
        Me.LabelAmountPaid.BackColor = System.Drawing.Color.Transparent
        Me.LabelAmountPaid.Font = New System.Drawing.Font("Arial Rounded MT Bold", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelAmountPaid.Location = New System.Drawing.Point(34, 114)
        Me.LabelAmountPaid.Name = "LabelAmountPaid"
        Me.LabelAmountPaid.Size = New System.Drawing.Size(105, 17)
        Me.LabelAmountPaid.TabIndex = 23
        Me.LabelAmountPaid.Text = "Amount Paid:"
        '
        'TextBoxAmount
        '
        Me.TextBoxAmount.Location = New System.Drawing.Point(189, 76)
        Me.TextBoxAmount.Name = "TextBoxAmount"
        Me.TextBoxAmount.Size = New System.Drawing.Size(234, 20)
        Me.TextBoxAmount.TabIndex = 22
        '
        'LabelFirstAmount
        '
        Me.LabelFirstAmount.AutoSize = True
        Me.LabelFirstAmount.BackColor = System.Drawing.Color.Transparent
        Me.LabelFirstAmount.Font = New System.Drawing.Font("Arial Rounded MT Bold", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelFirstAmount.Location = New System.Drawing.Point(34, 76)
        Me.LabelFirstAmount.Name = "LabelFirstAmount"
        Me.LabelFirstAmount.Size = New System.Drawing.Size(69, 17)
        Me.LabelFirstAmount.TabIndex = 21
        Me.LabelFirstAmount.Text = "Amount:"
        '
        'ButtonPreviousTransaction
        '
        Me.ButtonPreviousTransaction.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonPreviousTransaction.Location = New System.Drawing.Point(100, 295)
        Me.ButtonPreviousTransaction.Name = "ButtonPreviousTransaction"
        Me.ButtonPreviousTransaction.Size = New System.Drawing.Size(129, 40)
        Me.ButtonPreviousTransaction.TabIndex = 35
        Me.ButtonPreviousTransaction.Text = "Previous Transaction"
        Me.ButtonPreviousTransaction.UseVisualStyleBackColor = True
        '
        'ButtonNextTransaction
        '
        Me.ButtonNextTransaction.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonNextTransaction.Location = New System.Drawing.Point(235, 295)
        Me.ButtonNextTransaction.Name = "ButtonNextTransaction"
        Me.ButtonNextTransaction.Size = New System.Drawing.Size(129, 40)
        Me.ButtonNextTransaction.TabIndex = 34
        Me.ButtonNextTransaction.Text = "Next Transaction"
        Me.ButtonNextTransaction.UseVisualStyleBackColor = True
        '
        'ButtonAddTransaction
        '
        Me.ButtonAddTransaction.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonAddTransaction.Location = New System.Drawing.Point(293, 249)
        Me.ButtonAddTransaction.Name = "ButtonAddTransaction"
        Me.ButtonAddTransaction.Size = New System.Drawing.Size(129, 40)
        Me.ButtonAddTransaction.TabIndex = 33
        Me.ButtonAddTransaction.Text = "Add Transaction"
        Me.ButtonAddTransaction.UseVisualStyleBackColor = True
        '
        'ButtonRemoveTransaction
        '
        Me.ButtonRemoveTransaction.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonRemoveTransaction.Location = New System.Drawing.Point(158, 249)
        Me.ButtonRemoveTransaction.Name = "ButtonRemoveTransaction"
        Me.ButtonRemoveTransaction.Size = New System.Drawing.Size(129, 40)
        Me.ButtonRemoveTransaction.TabIndex = 32
        Me.ButtonRemoveTransaction.Text = "Remove Transaction"
        Me.ButtonRemoveTransaction.UseVisualStyleBackColor = True
        '
        'ButtonUpdateTransaction
        '
        Me.ButtonUpdateTransaction.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonUpdateTransaction.Location = New System.Drawing.Point(26, 249)
        Me.ButtonUpdateTransaction.Name = "ButtonUpdateTransaction"
        Me.ButtonUpdateTransaction.Size = New System.Drawing.Size(126, 40)
        Me.ButtonUpdateTransaction.TabIndex = 31
        Me.ButtonUpdateTransaction.Text = "Update Transaction"
        Me.ButtonUpdateTransaction.UseVisualStyleBackColor = True
        '
        'IndividualTransaction
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Milky_Lane_Point_of_Sales_System.My.Resources.Resources.Background
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(452, 361)
        Me.Controls.Add(Me.ButtonPreviousTransaction)
        Me.Controls.Add(Me.ButtonNextTransaction)
        Me.Controls.Add(Me.ButtonAddTransaction)
        Me.Controls.Add(Me.ButtonRemoveTransaction)
        Me.Controls.Add(Me.ButtonUpdateTransaction)
        Me.Controls.Add(Me.DateTimePicker)
        Me.Controls.Add(Me.LabelTransaction)
        Me.Controls.Add(Me.TextBoxStaffID)
        Me.Controls.Add(Me.LabelStaffID)
        Me.Controls.Add(Me.labelDate)
        Me.Controls.Add(Me.TextBoxAmountPaid)
        Me.Controls.Add(Me.LabelAmountPaid)
        Me.Controls.Add(Me.TextBoxAmount)
        Me.Controls.Add(Me.LabelFirstAmount)
        Me.Font = New System.Drawing.Font("Arial Rounded MT Bold", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "IndividualTransaction"
        Me.Text = "Transaction"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DateTimePicker As DateTimePicker
    Friend WithEvents LabelTransaction As Label
    Friend WithEvents TextBoxStaffID As TextBox
    Friend WithEvents LabelStaffID As Label
    Friend WithEvents labelDate As Label
    Friend WithEvents TextBoxAmountPaid As TextBox
    Friend WithEvents LabelAmountPaid As Label
    Friend WithEvents TextBoxAmount As TextBox
    Friend WithEvents LabelFirstAmount As Label
    Friend WithEvents ButtonPreviousTransaction As Button
    Friend WithEvents ButtonNextTransaction As Button
    Friend WithEvents ButtonAddTransaction As Button
    Friend WithEvents ButtonRemoveTransaction As Button
    Friend WithEvents ButtonUpdateTransaction As Button
End Class
