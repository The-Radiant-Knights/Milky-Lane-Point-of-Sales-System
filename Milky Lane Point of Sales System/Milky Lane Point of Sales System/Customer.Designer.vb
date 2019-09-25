<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Customer
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Customer))
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.CustomerPhoneNoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CustomerLastNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CustomerFirstNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CustomerEmailDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CustomerPointsDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TblCustomerBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Ist2gqDataSet = New Milky_Lane_Point_of_Sales_System.ist2gqDataSet()
        Me.ButtonSearch = New System.Windows.Forms.Button()
        Me.TextBoxSearch = New System.Windows.Forms.TextBox()
        Me.LabelSearch = New System.Windows.Forms.Label()
        Me.ButtonAddCustomer = New System.Windows.Forms.Button()
        Me.ButtonUpdate = New System.Windows.Forms.Button()
        Me.ButtonRemoveCustomer = New System.Windows.Forms.Button()
        Me.LabelCustomers = New System.Windows.Forms.Label()
        Me.TblCustomerTableAdapter = New Milky_Lane_Point_of_Sales_System.ist2gqDataSetTableAdapters.tblCustomerTableAdapter()
        Me.TableAdapterManager = New Milky_Lane_Point_of_Sales_System.ist2gqDataSetTableAdapters.TableAdapterManager()
        Me.ButtonRefresh = New System.Windows.Forms.Button()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblCustomerBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Ist2gqDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.CustomerPhoneNoDataGridViewTextBoxColumn, Me.CustomerLastNameDataGridViewTextBoxColumn, Me.CustomerFirstNameDataGridViewTextBoxColumn, Me.CustomerEmailDataGridViewTextBoxColumn, Me.CustomerPointsDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.TblCustomerBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(24, 91)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.Size = New System.Drawing.Size(558, 284)
        Me.DataGridView1.TabIndex = 0
        '
        'CustomerPhoneNoDataGridViewTextBoxColumn
        '
        Me.CustomerPhoneNoDataGridViewTextBoxColumn.DataPropertyName = "Customer_PhoneNo"
        Me.CustomerPhoneNoDataGridViewTextBoxColumn.HeaderText = "Customer_PhoneNo"
        Me.CustomerPhoneNoDataGridViewTextBoxColumn.Name = "CustomerPhoneNoDataGridViewTextBoxColumn"
        Me.CustomerPhoneNoDataGridViewTextBoxColumn.ReadOnly = True
        '
        'CustomerLastNameDataGridViewTextBoxColumn
        '
        Me.CustomerLastNameDataGridViewTextBoxColumn.DataPropertyName = "Customer_LastName"
        Me.CustomerLastNameDataGridViewTextBoxColumn.HeaderText = "Customer_LastName"
        Me.CustomerLastNameDataGridViewTextBoxColumn.Name = "CustomerLastNameDataGridViewTextBoxColumn"
        Me.CustomerLastNameDataGridViewTextBoxColumn.ReadOnly = True
        '
        'CustomerFirstNameDataGridViewTextBoxColumn
        '
        Me.CustomerFirstNameDataGridViewTextBoxColumn.DataPropertyName = "Customer_FirstName"
        Me.CustomerFirstNameDataGridViewTextBoxColumn.HeaderText = "Customer_FirstName"
        Me.CustomerFirstNameDataGridViewTextBoxColumn.Name = "CustomerFirstNameDataGridViewTextBoxColumn"
        Me.CustomerFirstNameDataGridViewTextBoxColumn.ReadOnly = True
        '
        'CustomerEmailDataGridViewTextBoxColumn
        '
        Me.CustomerEmailDataGridViewTextBoxColumn.DataPropertyName = "Customer_Email"
        Me.CustomerEmailDataGridViewTextBoxColumn.HeaderText = "Customer_Email"
        Me.CustomerEmailDataGridViewTextBoxColumn.Name = "CustomerEmailDataGridViewTextBoxColumn"
        Me.CustomerEmailDataGridViewTextBoxColumn.ReadOnly = True
        '
        'CustomerPointsDataGridViewTextBoxColumn
        '
        Me.CustomerPointsDataGridViewTextBoxColumn.DataPropertyName = "Customer_Points"
        Me.CustomerPointsDataGridViewTextBoxColumn.HeaderText = "Customer_Points"
        Me.CustomerPointsDataGridViewTextBoxColumn.Name = "CustomerPointsDataGridViewTextBoxColumn"
        Me.CustomerPointsDataGridViewTextBoxColumn.ReadOnly = True
        '
        'TblCustomerBindingSource
        '
        Me.TblCustomerBindingSource.DataMember = "tblCustomer"
        Me.TblCustomerBindingSource.DataSource = Me.Ist2gqDataSet
        '
        'Ist2gqDataSet
        '
        Me.Ist2gqDataSet.DataSetName = "ist2gqDataSet"
        Me.Ist2gqDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ButtonSearch
        '
        Me.ButtonSearch.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonSearch.Location = New System.Drawing.Point(472, 52)
        Me.ButtonSearch.Name = "ButtonSearch"
        Me.ButtonSearch.Size = New System.Drawing.Size(110, 33)
        Me.ButtonSearch.TabIndex = 1
        Me.ButtonSearch.Text = "Search"
        Me.ButtonSearch.UseVisualStyleBackColor = True
        '
        'TextBoxSearch
        '
        Me.TextBoxSearch.Location = New System.Drawing.Point(405, 26)
        Me.TextBoxSearch.Name = "TextBoxSearch"
        Me.TextBoxSearch.Size = New System.Drawing.Size(177, 20)
        Me.TextBoxSearch.TabIndex = 2
        '
        'LabelSearch
        '
        Me.LabelSearch.AutoSize = True
        Me.LabelSearch.BackColor = System.Drawing.Color.Transparent
        Me.LabelSearch.Font = New System.Drawing.Font("Arial Rounded MT Bold", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelSearch.Location = New System.Drawing.Point(333, 26)
        Me.LabelSearch.Name = "LabelSearch"
        Me.LabelSearch.Size = New System.Drawing.Size(66, 17)
        Me.LabelSearch.TabIndex = 3
        Me.LabelSearch.Text = "Search:"
        '
        'ButtonAddCustomer
        '
        Me.ButtonAddCustomer.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonAddCustomer.Location = New System.Drawing.Point(360, 393)
        Me.ButtonAddCustomer.Name = "ButtonAddCustomer"
        Me.ButtonAddCustomer.Size = New System.Drawing.Size(137, 43)
        Me.ButtonAddCustomer.TabIndex = 4
        Me.ButtonAddCustomer.Text = "Add Customer"
        Me.ButtonAddCustomer.UseVisualStyleBackColor = True
        '
        'ButtonUpdate
        '
        Me.ButtonUpdate.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonUpdate.Location = New System.Drawing.Point(228, 393)
        Me.ButtonUpdate.Name = "ButtonUpdate"
        Me.ButtonUpdate.Size = New System.Drawing.Size(126, 43)
        Me.ButtonUpdate.TabIndex = 5
        Me.ButtonUpdate.Text = "Update Customer"
        Me.ButtonUpdate.UseVisualStyleBackColor = True
        '
        'ButtonRemoveCustomer
        '
        Me.ButtonRemoveCustomer.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonRemoveCustomer.Location = New System.Drawing.Point(96, 393)
        Me.ButtonRemoveCustomer.Name = "ButtonRemoveCustomer"
        Me.ButtonRemoveCustomer.Size = New System.Drawing.Size(126, 43)
        Me.ButtonRemoveCustomer.TabIndex = 6
        Me.ButtonRemoveCustomer.Text = "Remove Customer"
        Me.ButtonRemoveCustomer.UseVisualStyleBackColor = True
        '
        'LabelCustomers
        '
        Me.LabelCustomers.AutoSize = True
        Me.LabelCustomers.BackColor = System.Drawing.Color.Transparent
        Me.LabelCustomers.Font = New System.Drawing.Font("Arial Rounded MT Bold", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelCustomers.Location = New System.Drawing.Point(21, 38)
        Me.LabelCustomers.Name = "LabelCustomers"
        Me.LabelCustomers.Size = New System.Drawing.Size(128, 24)
        Me.LabelCustomers.TabIndex = 7
        Me.LabelCustomers.Text = "Customers:"
        '
        'TblCustomerTableAdapter
        '
        Me.TblCustomerTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.tblCustomerTableAdapter = Me.TblCustomerTableAdapter
        Me.TableAdapterManager.tblInvoiceTableAdapter = Nothing
        Me.TableAdapterManager.tblProductTableAdapter = Nothing
        Me.TableAdapterManager.tblStaffTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = Milky_Lane_Point_of_Sales_System.ist2gqDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'ButtonRefresh
        '
        Me.ButtonRefresh.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonRefresh.Location = New System.Drawing.Point(336, 52)
        Me.ButtonRefresh.Name = "ButtonRefresh"
        Me.ButtonRefresh.Size = New System.Drawing.Size(110, 33)
        Me.ButtonRefresh.TabIndex = 8
        Me.ButtonRefresh.Text = "Refresh"
        Me.ButtonRefresh.UseVisualStyleBackColor = True
        '
        'Customer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Milky_Lane_Point_of_Sales_System.My.Resources.Resources.Background
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(609, 459)
        Me.Controls.Add(Me.ButtonRefresh)
        Me.Controls.Add(Me.LabelCustomers)
        Me.Controls.Add(Me.ButtonRemoveCustomer)
        Me.Controls.Add(Me.ButtonUpdate)
        Me.Controls.Add(Me.ButtonAddCustomer)
        Me.Controls.Add(Me.LabelSearch)
        Me.Controls.Add(Me.TextBoxSearch)
        Me.Controls.Add(Me.ButtonSearch)
        Me.Controls.Add(Me.DataGridView1)
        Me.Font = New System.Drawing.Font("Arial Rounded MT Bold", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Customer"
        Me.Text = "Customer"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblCustomerBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Ist2gqDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents ButtonSearch As Button
    Friend WithEvents TextBoxSearch As TextBox
    Friend WithEvents LabelSearch As Label
    Friend WithEvents ButtonAddCustomer As Button
    Friend WithEvents ButtonUpdate As Button
    Friend WithEvents ButtonRemoveCustomer As Button
    Friend WithEvents LabelCustomers As Label
    Friend WithEvents Ist2gqDataSet As ist2gqDataSet
    Friend WithEvents TblCustomerBindingSource As BindingSource
    Friend WithEvents TblCustomerTableAdapter As ist2gqDataSetTableAdapters.tblCustomerTableAdapter
    Friend WithEvents TableAdapterManager As ist2gqDataSetTableAdapters.TableAdapterManager
    Friend WithEvents CustomerPhoneNoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CustomerLastNameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CustomerFirstNameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CustomerEmailDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CustomerPointsDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ButtonRefresh As Button
End Class
