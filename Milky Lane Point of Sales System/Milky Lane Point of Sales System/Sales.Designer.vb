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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Sales))
        Me.GroupBoxCustomerDetails = New System.Windows.Forms.GroupBox()
        Me.ButtonVerifyCustomer = New System.Windows.Forms.Button()
        Me.ButtonNewCustomer = New System.Windows.Forms.Button()
        Me.TextBoxPhoneNumber = New System.Windows.Forms.TextBox()
        Me.LabelPhoneNumber = New System.Windows.Forms.Label()
        Me.GroupBoxProducts = New System.Windows.Forms.GroupBox()
        Me.ButtonAdd = New System.Windows.Forms.Button()
        Me.ButtonRefresh = New System.Windows.Forms.Button()
        Me.DataGridView2 = New System.Windows.Forms.DataGridView()
        Me.ButtonSearch = New System.Windows.Forms.Button()
        Me.LabelSearch = New System.Windows.Forms.Label()
        Me.TextBoxSearch = New System.Windows.Forms.TextBox()
        Me.GroupBoxInvoice = New System.Windows.Forms.GroupBox()
        Me.ButtonRemove = New System.Windows.Forms.Button()
        Me.ButtonCalculateChange = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Product_ID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Product_Description = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Price = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Amount_Sold = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LabelChange = New System.Windows.Forms.Label()
        Me.LabelAmountReceived = New System.Windows.Forms.Label()
        Me.LabelAmountDue = New System.Windows.Forms.Label()
        Me.TextBoxChange = New System.Windows.Forms.TextBox()
        Me.TextBoxAmountReceived = New System.Windows.Forms.TextBox()
        Me.TextBoxAmountDue = New System.Windows.Forms.TextBox()
        Me.ButtonPay = New System.Windows.Forms.Button()
        Me.BindingSourceCustomer = New System.Windows.Forms.BindingSource(Me.components)
        Me.ProductIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ProductDescriptionDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PriceDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AmountSoldDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TblProductBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Ist2gqDataSet = New Milky_Lane_Point_of_Sales_System.ist2gqDataSet()
        Me.TblProductTableAdapter = New Milky_Lane_Point_of_Sales_System.ist2gqDataSetTableAdapters.tblProductTableAdapter()
        Me.TableAdapterManager = New Milky_Lane_Point_of_Sales_System.ist2gqDataSetTableAdapters.TableAdapterManager()
        Me.TblCustomerTableAdapter = New Milky_Lane_Point_of_Sales_System.ist2gqDataSetTableAdapters.tblCustomerTableAdapter()
        Me.TblInvoiceTableAdapter = New Milky_Lane_Point_of_Sales_System.ist2gqDataSetTableAdapters.tblInvoiceTableAdapter()
        Me.GroupBoxCustomerDetails.SuspendLayout()
        Me.GroupBoxProducts.SuspendLayout()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBoxInvoice.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BindingSourceCustomer, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblProductBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Ist2gqDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.GroupBoxCustomerDetails.Size = New System.Drawing.Size(494, 115)
        Me.GroupBoxCustomerDetails.TabIndex = 0
        Me.GroupBoxCustomerDetails.TabStop = False
        Me.GroupBoxCustomerDetails.Text = "Customer Details"
        '
        'ButtonVerifyCustomer
        '
        Me.ButtonVerifyCustomer.Location = New System.Drawing.Point(297, 73)
        Me.ButtonVerifyCustomer.Name = "ButtonVerifyCustomer"
        Me.ButtonVerifyCustomer.Size = New System.Drawing.Size(106, 23)
        Me.ButtonVerifyCustomer.TabIndex = 3
        Me.ButtonVerifyCustomer.Text = "Verify Customer"
        Me.ButtonVerifyCustomer.UseVisualStyleBackColor = True
        '
        'ButtonNewCustomer
        '
        Me.ButtonNewCustomer.Location = New System.Drawing.Point(173, 73)
        Me.ButtonNewCustomer.Name = "ButtonNewCustomer"
        Me.ButtonNewCustomer.Size = New System.Drawing.Size(106, 23)
        Me.ButtonNewCustomer.TabIndex = 2
        Me.ButtonNewCustomer.Text = "New Customer"
        Me.ButtonNewCustomer.UseVisualStyleBackColor = True
        '
        'TextBoxPhoneNumber
        '
        Me.TextBoxPhoneNumber.Location = New System.Drawing.Point(173, 28)
        Me.TextBoxPhoneNumber.Name = "TextBoxPhoneNumber"
        Me.TextBoxPhoneNumber.Size = New System.Drawing.Size(230, 20)
        Me.TextBoxPhoneNumber.TabIndex = 1
        '
        'LabelPhoneNumber
        '
        Me.LabelPhoneNumber.AutoSize = True
        Me.LabelPhoneNumber.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelPhoneNumber.Location = New System.Drawing.Point(42, 28)
        Me.LabelPhoneNumber.Name = "LabelPhoneNumber"
        Me.LabelPhoneNumber.Size = New System.Drawing.Size(103, 20)
        Me.LabelPhoneNumber.TabIndex = 0
        Me.LabelPhoneNumber.Text = "Phone Number:"
        '
        'GroupBoxProducts
        '
        Me.GroupBoxProducts.BackColor = System.Drawing.Color.Transparent
        Me.GroupBoxProducts.Controls.Add(Me.ButtonAdd)
        Me.GroupBoxProducts.Controls.Add(Me.ButtonRefresh)
        Me.GroupBoxProducts.Controls.Add(Me.DataGridView2)
        Me.GroupBoxProducts.Controls.Add(Me.ButtonSearch)
        Me.GroupBoxProducts.Controls.Add(Me.LabelSearch)
        Me.GroupBoxProducts.Controls.Add(Me.TextBoxSearch)
        Me.GroupBoxProducts.Location = New System.Drawing.Point(13, 135)
        Me.GroupBoxProducts.Name = "GroupBoxProducts"
        Me.GroupBoxProducts.Size = New System.Drawing.Size(494, 380)
        Me.GroupBoxProducts.TabIndex = 1
        Me.GroupBoxProducts.TabStop = False
        Me.GroupBoxProducts.Text = "Products"
        '
        'ButtonAdd
        '
        Me.ButtonAdd.Location = New System.Drawing.Point(374, 341)
        Me.ButtonAdd.Name = "ButtonAdd"
        Me.ButtonAdd.Size = New System.Drawing.Size(106, 23)
        Me.ButtonAdd.TabIndex = 14
        Me.ButtonAdd.Text = "Add"
        Me.ButtonAdd.UseVisualStyleBackColor = True
        '
        'ButtonRefresh
        '
        Me.ButtonRefresh.Location = New System.Drawing.Point(250, 65)
        Me.ButtonRefresh.Name = "ButtonRefresh"
        Me.ButtonRefresh.Size = New System.Drawing.Size(106, 23)
        Me.ButtonRefresh.TabIndex = 13
        Me.ButtonRefresh.Text = "Refresh"
        Me.ButtonRefresh.UseVisualStyleBackColor = True
        '
        'DataGridView2
        '
        Me.DataGridView2.AutoGenerateColumns = False
        Me.DataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView2.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ProductIDDataGridViewTextBoxColumn, Me.ProductDescriptionDataGridViewTextBoxColumn, Me.PriceDataGridViewTextBoxColumn, Me.AmountSoldDataGridViewTextBoxColumn})
        Me.DataGridView2.DataSource = Me.TblProductBindingSource
        Me.DataGridView2.Location = New System.Drawing.Point(10, 98)
        Me.DataGridView2.Name = "DataGridView2"
        Me.DataGridView2.Size = New System.Drawing.Size(478, 223)
        Me.DataGridView2.TabIndex = 12
        '
        'ButtonSearch
        '
        Me.ButtonSearch.Location = New System.Drawing.Point(374, 65)
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
        Me.LabelSearch.Location = New System.Drawing.Point(155, 36)
        Me.LabelSearch.Name = "LabelSearch"
        Me.LabelSearch.Size = New System.Drawing.Size(55, 20)
        Me.LabelSearch.TabIndex = 4
        Me.LabelSearch.Text = "Search:"
        '
        'TextBoxSearch
        '
        Me.TextBoxSearch.Location = New System.Drawing.Point(250, 39)
        Me.TextBoxSearch.Name = "TextBoxSearch"
        Me.TextBoxSearch.Size = New System.Drawing.Size(230, 20)
        Me.TextBoxSearch.TabIndex = 4
        '
        'GroupBoxInvoice
        '
        Me.GroupBoxInvoice.BackColor = System.Drawing.Color.Transparent
        Me.GroupBoxInvoice.Controls.Add(Me.ButtonRemove)
        Me.GroupBoxInvoice.Controls.Add(Me.ButtonCalculateChange)
        Me.GroupBoxInvoice.Controls.Add(Me.DataGridView1)
        Me.GroupBoxInvoice.Controls.Add(Me.LabelChange)
        Me.GroupBoxInvoice.Controls.Add(Me.LabelAmountReceived)
        Me.GroupBoxInvoice.Controls.Add(Me.LabelAmountDue)
        Me.GroupBoxInvoice.Controls.Add(Me.TextBoxChange)
        Me.GroupBoxInvoice.Controls.Add(Me.TextBoxAmountReceived)
        Me.GroupBoxInvoice.Controls.Add(Me.TextBoxAmountDue)
        Me.GroupBoxInvoice.Controls.Add(Me.ButtonPay)
        Me.GroupBoxInvoice.Location = New System.Drawing.Point(513, 12)
        Me.GroupBoxInvoice.Name = "GroupBoxInvoice"
        Me.GroupBoxInvoice.Size = New System.Drawing.Size(474, 503)
        Me.GroupBoxInvoice.TabIndex = 2
        Me.GroupBoxInvoice.TabStop = False
        Me.GroupBoxInvoice.Text = "Invoice"
        '
        'ButtonRemove
        '
        Me.ButtonRemove.Location = New System.Drawing.Point(324, 340)
        Me.ButtonRemove.Name = "ButtonRemove"
        Me.ButtonRemove.Size = New System.Drawing.Size(121, 23)
        Me.ButtonRemove.TabIndex = 13
        Me.ButtonRemove.Text = "Remove"
        Me.ButtonRemove.UseVisualStyleBackColor = True
        '
        'ButtonCalculateChange
        '
        Me.ButtonCalculateChange.Location = New System.Drawing.Point(150, 464)
        Me.ButtonCalculateChange.Name = "ButtonCalculateChange"
        Me.ButtonCalculateChange.Size = New System.Drawing.Size(121, 23)
        Me.ButtonCalculateChange.TabIndex = 12
        Me.ButtonCalculateChange.Text = "Calculate Change"
        Me.ButtonCalculateChange.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Product_ID, Me.Product_Description, Me.Price, Me.Amount_Sold})
        Me.DataGridView1.Location = New System.Drawing.Point(17, 29)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(451, 295)
        Me.DataGridView1.TabIndex = 11
        '
        'Product_ID
        '
        Me.Product_ID.HeaderText = "Product_ID"
        Me.Product_ID.Name = "Product_ID"
        Me.Product_ID.ReadOnly = True
        '
        'Product_Description
        '
        Me.Product_Description.HeaderText = "Product_Description"
        Me.Product_Description.Name = "Product_Description"
        Me.Product_Description.ReadOnly = True
        '
        'Price
        '
        Me.Price.HeaderText = "Price"
        Me.Price.Name = "Price"
        Me.Price.ReadOnly = True
        '
        'Amount_Sold
        '
        Me.Amount_Sold.HeaderText = "Amount_Sold"
        Me.Amount_Sold.Name = "Amount_Sold"
        Me.Amount_Sold.ReadOnly = True
        '
        'LabelChange
        '
        Me.LabelChange.AutoSize = True
        Me.LabelChange.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelChange.Location = New System.Drawing.Point(56, 431)
        Me.LabelChange.Name = "LabelChange"
        Me.LabelChange.Size = New System.Drawing.Size(59, 20)
        Me.LabelChange.TabIndex = 10
        Me.LabelChange.Text = "Change:"
        '
        'LabelAmountReceived
        '
        Me.LabelAmountReceived.AutoSize = True
        Me.LabelAmountReceived.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelAmountReceived.Location = New System.Drawing.Point(56, 405)
        Me.LabelAmountReceived.Name = "LabelAmountReceived"
        Me.LabelAmountReceived.Size = New System.Drawing.Size(120, 20)
        Me.LabelAmountReceived.TabIndex = 9
        Me.LabelAmountReceived.Text = "Amount Received:"
        '
        'LabelAmountDue
        '
        Me.LabelAmountDue.AutoSize = True
        Me.LabelAmountDue.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelAmountDue.Location = New System.Drawing.Point(56, 379)
        Me.LabelAmountDue.Name = "LabelAmountDue"
        Me.LabelAmountDue.Size = New System.Drawing.Size(86, 20)
        Me.LabelAmountDue.TabIndex = 8
        Me.LabelAmountDue.Text = "Amount Due:"
        '
        'TextBoxChange
        '
        Me.TextBoxChange.Location = New System.Drawing.Point(178, 431)
        Me.TextBoxChange.Name = "TextBoxChange"
        Me.TextBoxChange.Size = New System.Drawing.Size(230, 20)
        Me.TextBoxChange.TabIndex = 7
        Me.TextBoxChange.Text = "0"
        '
        'TextBoxAmountReceived
        '
        Me.TextBoxAmountReceived.Location = New System.Drawing.Point(178, 405)
        Me.TextBoxAmountReceived.Name = "TextBoxAmountReceived"
        Me.TextBoxAmountReceived.Size = New System.Drawing.Size(230, 20)
        Me.TextBoxAmountReceived.TabIndex = 6
        Me.TextBoxAmountReceived.Text = "0"
        '
        'TextBoxAmountDue
        '
        Me.TextBoxAmountDue.Location = New System.Drawing.Point(178, 379)
        Me.TextBoxAmountDue.Name = "TextBoxAmountDue"
        Me.TextBoxAmountDue.Size = New System.Drawing.Size(230, 20)
        Me.TextBoxAmountDue.TabIndex = 5
        Me.TextBoxAmountDue.Text = "0"
        '
        'ButtonPay
        '
        Me.ButtonPay.Location = New System.Drawing.Point(324, 464)
        Me.ButtonPay.Name = "ButtonPay"
        Me.ButtonPay.Size = New System.Drawing.Size(121, 23)
        Me.ButtonPay.TabIndex = 0
        Me.ButtonPay.Text = "Pay"
        Me.ButtonPay.UseVisualStyleBackColor = True
        '
        'ProductIDDataGridViewTextBoxColumn
        '
        Me.ProductIDDataGridViewTextBoxColumn.DataPropertyName = "Product_ID"
        Me.ProductIDDataGridViewTextBoxColumn.HeaderText = "Product_ID"
        Me.ProductIDDataGridViewTextBoxColumn.Name = "ProductIDDataGridViewTextBoxColumn"
        Me.ProductIDDataGridViewTextBoxColumn.ReadOnly = True
        '
        'ProductDescriptionDataGridViewTextBoxColumn
        '
        Me.ProductDescriptionDataGridViewTextBoxColumn.DataPropertyName = "Product_Description"
        Me.ProductDescriptionDataGridViewTextBoxColumn.HeaderText = "Product_Description"
        Me.ProductDescriptionDataGridViewTextBoxColumn.Name = "ProductDescriptionDataGridViewTextBoxColumn"
        '
        'PriceDataGridViewTextBoxColumn
        '
        Me.PriceDataGridViewTextBoxColumn.DataPropertyName = "Price"
        Me.PriceDataGridViewTextBoxColumn.HeaderText = "Price"
        Me.PriceDataGridViewTextBoxColumn.Name = "PriceDataGridViewTextBoxColumn"
        '
        'AmountSoldDataGridViewTextBoxColumn
        '
        Me.AmountSoldDataGridViewTextBoxColumn.DataPropertyName = "Amount_Sold"
        Me.AmountSoldDataGridViewTextBoxColumn.HeaderText = "Amount_Sold"
        Me.AmountSoldDataGridViewTextBoxColumn.Name = "AmountSoldDataGridViewTextBoxColumn"
        '
        'TblProductBindingSource
        '
        Me.TblProductBindingSource.DataMember = "tblProduct"
        Me.TblProductBindingSource.DataSource = Me.Ist2gqDataSet
        '
        'Ist2gqDataSet
        '
        Me.Ist2gqDataSet.DataSetName = "ist2gqDataSet"
        Me.Ist2gqDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TblProductTableAdapter
        '
        Me.TblProductTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.tblCustomerTableAdapter = Nothing
        Me.TableAdapterManager.tblInvoiceTableAdapter = Nothing
        Me.TableAdapterManager.tblProductTableAdapter = Me.TblProductTableAdapter
        Me.TableAdapterManager.tblStaffTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = Milky_Lane_Point_of_Sales_System.ist2gqDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'TblCustomerTableAdapter
        '
        Me.TblCustomerTableAdapter.ClearBeforeFill = True
        '
        'TblInvoiceTableAdapter
        '
        Me.TblInvoiceTableAdapter.ClearBeforeFill = True
        '
        'Sales
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Milky_Lane_Point_of_Sales_System.My.Resources.Resources.Background
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(999, 527)
        Me.Controls.Add(Me.GroupBoxInvoice)
        Me.Controls.Add(Me.GroupBoxProducts)
        Me.Controls.Add(Me.GroupBoxCustomerDetails)
        Me.Font = New System.Drawing.Font("Arial Rounded MT Bold", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Sales"
        Me.Text = "Sales"
        Me.GroupBoxCustomerDetails.ResumeLayout(False)
        Me.GroupBoxCustomerDetails.PerformLayout()
        Me.GroupBoxProducts.ResumeLayout(False)
        Me.GroupBoxProducts.PerformLayout()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBoxInvoice.ResumeLayout(False)
        Me.GroupBoxInvoice.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BindingSourceCustomer, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblProductBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Ist2gqDataSet, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents Ist2gqDataSet As ist2gqDataSet
    Friend WithEvents TblProductBindingSource As BindingSource
    Friend WithEvents TblProductTableAdapter As ist2gqDataSetTableAdapters.tblProductTableAdapter
    Friend WithEvents TableAdapterManager As ist2gqDataSetTableAdapters.TableAdapterManager
    Friend WithEvents ButtonRefresh As Button
    Friend WithEvents ProductIDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ProductDescriptionDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PriceDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents AmountSoldDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TblCustomerTableAdapter As ist2gqDataSetTableAdapters.tblCustomerTableAdapter
    Friend WithEvents BindingSourceCustomer As BindingSource
    Friend WithEvents ButtonAdd As Button
    Friend WithEvents Product_ID As DataGridViewTextBoxColumn
    Friend WithEvents Product_Description As DataGridViewTextBoxColumn
    Friend WithEvents Price As DataGridViewTextBoxColumn
    Friend WithEvents Amount_Sold As DataGridViewTextBoxColumn
    Friend WithEvents ButtonCalculateChange As Button
    Friend WithEvents ButtonRemove As Button
    Friend WithEvents TblInvoiceTableAdapter As ist2gqDataSetTableAdapters.tblInvoiceTableAdapter
End Class
