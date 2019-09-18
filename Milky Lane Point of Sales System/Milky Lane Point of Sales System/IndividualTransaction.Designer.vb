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
        Me.components = New System.ComponentModel.Container()
        Me.DateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.LabelTransaction = New System.Windows.Forms.Label()
        Me.TextBoxStaffID = New System.Windows.Forms.TextBox()
        Me.LabelStaffID = New System.Windows.Forms.Label()
        Me.labelDate = New System.Windows.Forms.Label()
        Me.TextBoxAmountPaid = New System.Windows.Forms.TextBox()
        Me.LabelAmountPaid = New System.Windows.Forms.Label()
        Me.TextBoxAmount = New System.Windows.Forms.TextBox()
        Me.LabelFirstAmount = New System.Windows.Forms.Label()
        Me.ButtonNextTransaction = New System.Windows.Forms.Button()
        Me.ButtonAddTransaction = New System.Windows.Forms.Button()
        Me.ButtonRemoveTransaction = New System.Windows.Forms.Button()
        Me.ButtonUpdateTransaction = New System.Windows.Forms.Button()
        Me.ButtonPreviousTransaction = New System.Windows.Forms.Button()
        Me.Ist2gqDataSet = New Milky_Lane_Point_of_Sales_System.ist2gqDataSet()
        Me.TableAdapterManager = New Milky_Lane_Point_of_Sales_System.ist2gqDataSetTableAdapters.TableAdapterManager()
        Me.TblInvoiceTableAdapter = New Milky_Lane_Point_of_Sales_System.ist2gqDataSetTableAdapters.tblInvoiceTableAdapter()
        Me.BindingSourceInvoice = New System.Windows.Forms.BindingSource(Me.components)
        Me.TextBoxID = New System.Windows.Forms.TextBox()
        Me.LabelID = New System.Windows.Forms.Label()
        CType(Me.Ist2gqDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BindingSourceInvoice, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DateTimePicker
        '
        Me.DateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.BindingSourceInvoice, "Invoice_Date", True))
        Me.DateTimePicker.Location = New System.Drawing.Point(184, 205)
        Me.DateTimePicker.Name = "DateTimePicker"
        Me.DateTimePicker.Size = New System.Drawing.Size(234, 20)
        Me.DateTimePicker.TabIndex = 30
        '
        'LabelTransaction
        '
        Me.LabelTransaction.AutoSize = True
        Me.LabelTransaction.BackColor = System.Drawing.Color.Transparent
        Me.LabelTransaction.Font = New System.Drawing.Font("Arial Rounded MT Bold", 18.0!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelTransaction.Location = New System.Drawing.Point(148, 18)
        Me.LabelTransaction.Name = "LabelTransaction"
        Me.LabelTransaction.Size = New System.Drawing.Size(150, 28)
        Me.LabelTransaction.TabIndex = 28
        Me.LabelTransaction.Text = "Transaction"
        '
        'TextBoxStaffID
        '
        Me.TextBoxStaffID.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BindingSourceInvoice, "Staff_ID", True))
        Me.TextBoxStaffID.Location = New System.Drawing.Point(184, 242)
        Me.TextBoxStaffID.Name = "TextBoxStaffID"
        Me.TextBoxStaffID.Size = New System.Drawing.Size(234, 20)
        Me.TextBoxStaffID.TabIndex = 27
        '
        'LabelStaffID
        '
        Me.LabelStaffID.AutoSize = True
        Me.LabelStaffID.BackColor = System.Drawing.Color.Transparent
        Me.LabelStaffID.Font = New System.Drawing.Font("Arial Rounded MT Bold", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelStaffID.Location = New System.Drawing.Point(29, 245)
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
        Me.labelDate.Location = New System.Drawing.Point(29, 205)
        Me.labelDate.Name = "labelDate"
        Me.labelDate.Size = New System.Drawing.Size(47, 17)
        Me.labelDate.TabIndex = 25
        Me.labelDate.Text = "Date:"
        '
        'TextBoxAmountPaid
        '
        Me.TextBoxAmountPaid.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BindingSourceInvoice, "Amount_Paid", True))
        Me.TextBoxAmountPaid.Location = New System.Drawing.Point(184, 160)
        Me.TextBoxAmountPaid.Name = "TextBoxAmountPaid"
        Me.TextBoxAmountPaid.Size = New System.Drawing.Size(234, 20)
        Me.TextBoxAmountPaid.TabIndex = 24
        '
        'LabelAmountPaid
        '
        Me.LabelAmountPaid.AutoSize = True
        Me.LabelAmountPaid.BackColor = System.Drawing.Color.Transparent
        Me.LabelAmountPaid.Font = New System.Drawing.Font("Arial Rounded MT Bold", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelAmountPaid.Location = New System.Drawing.Point(29, 163)
        Me.LabelAmountPaid.Name = "LabelAmountPaid"
        Me.LabelAmountPaid.Size = New System.Drawing.Size(105, 17)
        Me.LabelAmountPaid.TabIndex = 23
        Me.LabelAmountPaid.Text = "Amount Paid:"
        '
        'TextBoxAmount
        '
        Me.TextBoxAmount.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BindingSourceInvoice, "Invoice_Amount", True))
        Me.TextBoxAmount.Location = New System.Drawing.Point(184, 125)
        Me.TextBoxAmount.Name = "TextBoxAmount"
        Me.TextBoxAmount.Size = New System.Drawing.Size(234, 20)
        Me.TextBoxAmount.TabIndex = 22
        '
        'LabelFirstAmount
        '
        Me.LabelFirstAmount.AutoSize = True
        Me.LabelFirstAmount.BackColor = System.Drawing.Color.Transparent
        Me.LabelFirstAmount.Font = New System.Drawing.Font("Arial Rounded MT Bold", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelFirstAmount.Location = New System.Drawing.Point(29, 125)
        Me.LabelFirstAmount.Name = "LabelFirstAmount"
        Me.LabelFirstAmount.Size = New System.Drawing.Size(69, 17)
        Me.LabelFirstAmount.TabIndex = 21
        Me.LabelFirstAmount.Text = "Amount:"
        '
        'ButtonNextTransaction
        '
        Me.ButtonNextTransaction.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonNextTransaction.Location = New System.Drawing.Point(230, 344)
        Me.ButtonNextTransaction.Name = "ButtonNextTransaction"
        Me.ButtonNextTransaction.Size = New System.Drawing.Size(129, 40)
        Me.ButtonNextTransaction.TabIndex = 34
        Me.ButtonNextTransaction.Text = "Next Transaction"
        Me.ButtonNextTransaction.UseVisualStyleBackColor = True
        '
        'ButtonAddTransaction
        '
        Me.ButtonAddTransaction.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonAddTransaction.Location = New System.Drawing.Point(288, 298)
        Me.ButtonAddTransaction.Name = "ButtonAddTransaction"
        Me.ButtonAddTransaction.Size = New System.Drawing.Size(129, 40)
        Me.ButtonAddTransaction.TabIndex = 33
        Me.ButtonAddTransaction.Text = "Add Transaction"
        Me.ButtonAddTransaction.UseVisualStyleBackColor = True
        '
        'ButtonRemoveTransaction
        '
        Me.ButtonRemoveTransaction.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonRemoveTransaction.Location = New System.Drawing.Point(153, 298)
        Me.ButtonRemoveTransaction.Name = "ButtonRemoveTransaction"
        Me.ButtonRemoveTransaction.Size = New System.Drawing.Size(129, 40)
        Me.ButtonRemoveTransaction.TabIndex = 32
        Me.ButtonRemoveTransaction.Text = "Remove Transaction"
        Me.ButtonRemoveTransaction.UseVisualStyleBackColor = True
        '
        'ButtonUpdateTransaction
        '
        Me.ButtonUpdateTransaction.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonUpdateTransaction.Location = New System.Drawing.Point(21, 298)
        Me.ButtonUpdateTransaction.Name = "ButtonUpdateTransaction"
        Me.ButtonUpdateTransaction.Size = New System.Drawing.Size(126, 40)
        Me.ButtonUpdateTransaction.TabIndex = 31
        Me.ButtonUpdateTransaction.Text = "Update/Save Transaction"
        Me.ButtonUpdateTransaction.UseVisualStyleBackColor = True
        '
        'ButtonPreviousTransaction
        '
        Me.ButtonPreviousTransaction.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonPreviousTransaction.Location = New System.Drawing.Point(95, 344)
        Me.ButtonPreviousTransaction.Name = "ButtonPreviousTransaction"
        Me.ButtonPreviousTransaction.Size = New System.Drawing.Size(129, 40)
        Me.ButtonPreviousTransaction.TabIndex = 35
        Me.ButtonPreviousTransaction.Text = "Previous Transaction"
        Me.ButtonPreviousTransaction.UseVisualStyleBackColor = True
        '
        'Ist2gqDataSet
        '
        Me.Ist2gqDataSet.DataSetName = "ist2gqDataSet"
        Me.Ist2gqDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.tblCustomerTableAdapter = Nothing
        Me.TableAdapterManager.tblInvoiceTableAdapter = Me.TblInvoiceTableAdapter
        Me.TableAdapterManager.tblProductTableAdapter = Nothing
        Me.TableAdapterManager.tblStaffTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = Milky_Lane_Point_of_Sales_System.ist2gqDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'TblInvoiceTableAdapter
        '
        Me.TblInvoiceTableAdapter.ClearBeforeFill = True
        '
        'BindingSourceInvoice
        '
        Me.BindingSourceInvoice.DataMember = "tblInvoice"
        Me.BindingSourceInvoice.DataSource = Me.Ist2gqDataSet
        '
        'TextBoxID
        '
        Me.TextBoxID.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BindingSourceInvoice, "Invoice_No", True))
        Me.TextBoxID.Enabled = False
        Me.TextBoxID.Location = New System.Drawing.Point(183, 83)
        Me.TextBoxID.Name = "TextBoxID"
        Me.TextBoxID.Size = New System.Drawing.Size(234, 20)
        Me.TextBoxID.TabIndex = 36
        '
        'LabelID
        '
        Me.LabelID.AutoSize = True
        Me.LabelID.BackColor = System.Drawing.Color.Transparent
        Me.LabelID.Font = New System.Drawing.Font("Arial Rounded MT Bold", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelID.Location = New System.Drawing.Point(29, 82)
        Me.LabelID.Name = "LabelID"
        Me.LabelID.Size = New System.Drawing.Size(29, 17)
        Me.LabelID.TabIndex = 37
        Me.LabelID.Text = "ID:"
        '
        'IndividualTransaction
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Milky_Lane_Point_of_Sales_System.My.Resources.Resources.Background
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(452, 402)
        Me.Controls.Add(Me.LabelID)
        Me.Controls.Add(Me.TextBoxID)
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
        CType(Me.Ist2gqDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BindingSourceInvoice, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents ButtonNextTransaction As Button
    Friend WithEvents ButtonAddTransaction As Button
    Friend WithEvents ButtonRemoveTransaction As Button
    Friend WithEvents ButtonUpdateTransaction As Button
    Friend WithEvents ButtonPreviousTransaction As Button
    Friend WithEvents Ist2gqDataSet As ist2gqDataSet
    Friend WithEvents TableAdapterManager As ist2gqDataSetTableAdapters.TableAdapterManager
    Friend WithEvents TblInvoiceTableAdapter As ist2gqDataSetTableAdapters.tblInvoiceTableAdapter
    Friend WithEvents BindingSourceInvoice As BindingSource
    Friend WithEvents TextBoxID As TextBox
    Friend WithEvents LabelID As Label
End Class
