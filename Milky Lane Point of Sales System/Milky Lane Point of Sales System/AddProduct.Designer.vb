<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AddProduct
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AddProduct))
        Me.ButtonAddProduct = New System.Windows.Forms.Button()
        Me.LabelAddCustomer = New System.Windows.Forms.Label()
        Me.TextBoxAmountSold = New System.Windows.Forms.TextBox()
        Me.BindingSourceProduct = New System.Windows.Forms.BindingSource(Me.components)
        Me.Ist2gqDataSet1 = New Milky_Lane_Point_of_Sales_System.ist2gqDataSet()
        Me.labelAmountSold = New System.Windows.Forms.Label()
        Me.TextBoxPrice = New System.Windows.Forms.TextBox()
        Me.LabelLastPrice = New System.Windows.Forms.Label()
        Me.TextBoxDescription = New System.Windows.Forms.TextBox()
        Me.LabelFirstDescription = New System.Windows.Forms.Label()
        Me.TableAdapterManager1 = New Milky_Lane_Point_of_Sales_System.ist2gqDataSetTableAdapters.TableAdapterManager()
        Me.TblProductTableAdapter1 = New Milky_Lane_Point_of_Sales_System.ist2gqDataSetTableAdapters.tblProductTableAdapter()
        Me.LabelID = New System.Windows.Forms.Label()
        Me.TextBoxID = New System.Windows.Forms.TextBox()
        CType(Me.BindingSourceProduct, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Ist2gqDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ButtonAddProduct
        '
        Me.ButtonAddProduct.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonAddProduct.Location = New System.Drawing.Point(246, 244)
        Me.ButtonAddProduct.Name = "ButtonAddProduct"
        Me.ButtonAddProduct.Size = New System.Drawing.Size(165, 40)
        Me.ButtonAddProduct.TabIndex = 19
        Me.ButtonAddProduct.Text = "Add Product"
        Me.ButtonAddProduct.UseVisualStyleBackColor = True
        '
        'LabelAddCustomer
        '
        Me.LabelAddCustomer.AutoSize = True
        Me.LabelAddCustomer.BackColor = System.Drawing.Color.Transparent
        Me.LabelAddCustomer.Font = New System.Drawing.Font("Arial Rounded MT Bold", 18.0!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelAddCustomer.Location = New System.Drawing.Point(113, 21)
        Me.LabelAddCustomer.Name = "LabelAddCustomer"
        Me.LabelAddCustomer.Size = New System.Drawing.Size(215, 28)
        Me.LabelAddCustomer.TabIndex = 18
        Me.LabelAddCustomer.Text = "Add New Product"
        '
        'TextBoxAmountSold
        '
        Me.TextBoxAmountSold.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BindingSourceProduct, "Amount_Sold", True))
        Me.TextBoxAmountSold.Location = New System.Drawing.Point(177, 199)
        Me.TextBoxAmountSold.Name = "TextBoxAmountSold"
        Me.TextBoxAmountSold.Size = New System.Drawing.Size(234, 20)
        Me.TextBoxAmountSold.TabIndex = 15
        Me.TextBoxAmountSold.Text = "0"
        '
        'BindingSourceProduct
        '
        Me.BindingSourceProduct.DataMember = "tblProduct"
        Me.BindingSourceProduct.DataSource = Me.Ist2gqDataSet1
        '
        'Ist2gqDataSet1
        '
        Me.Ist2gqDataSet1.DataSetName = "ist2gqDataSet"
        Me.Ist2gqDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'labelAmountSold
        '
        Me.labelAmountSold.AutoSize = True
        Me.labelAmountSold.BackColor = System.Drawing.Color.Transparent
        Me.labelAmountSold.Font = New System.Drawing.Font("Arial Rounded MT Bold", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labelAmountSold.Location = New System.Drawing.Point(22, 202)
        Me.labelAmountSold.Name = "labelAmountSold"
        Me.labelAmountSold.Size = New System.Drawing.Size(105, 17)
        Me.labelAmountSold.TabIndex = 14
        Me.labelAmountSold.Text = "Amount Sold:"
        '
        'TextBoxPrice
        '
        Me.TextBoxPrice.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BindingSourceProduct, "Price", True))
        Me.TextBoxPrice.Location = New System.Drawing.Point(177, 157)
        Me.TextBoxPrice.Name = "TextBoxPrice"
        Me.TextBoxPrice.Size = New System.Drawing.Size(234, 20)
        Me.TextBoxPrice.TabIndex = 13
        '
        'LabelLastPrice
        '
        Me.LabelLastPrice.AutoSize = True
        Me.LabelLastPrice.BackColor = System.Drawing.Color.Transparent
        Me.LabelLastPrice.Font = New System.Drawing.Font("Arial Rounded MT Bold", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelLastPrice.Location = New System.Drawing.Point(22, 160)
        Me.LabelLastPrice.Name = "LabelLastPrice"
        Me.LabelLastPrice.Size = New System.Drawing.Size(56, 17)
        Me.LabelLastPrice.TabIndex = 12
        Me.LabelLastPrice.Text = "Price: "
        '
        'TextBoxDescription
        '
        Me.TextBoxDescription.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BindingSourceProduct, "Product_Description", True))
        Me.TextBoxDescription.Location = New System.Drawing.Point(177, 122)
        Me.TextBoxDescription.Name = "TextBoxDescription"
        Me.TextBoxDescription.Size = New System.Drawing.Size(234, 20)
        Me.TextBoxDescription.TabIndex = 11
        '
        'LabelFirstDescription
        '
        Me.LabelFirstDescription.AutoSize = True
        Me.LabelFirstDescription.BackColor = System.Drawing.Color.Transparent
        Me.LabelFirstDescription.Font = New System.Drawing.Font("Arial Rounded MT Bold", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelFirstDescription.Location = New System.Drawing.Point(22, 122)
        Me.LabelFirstDescription.Name = "LabelFirstDescription"
        Me.LabelFirstDescription.Size = New System.Drawing.Size(97, 17)
        Me.LabelFirstDescription.TabIndex = 10
        Me.LabelFirstDescription.Text = "Description:"
        '
        'TableAdapterManager1
        '
        Me.TableAdapterManager1.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager1.tblCustomerTableAdapter = Nothing
        Me.TableAdapterManager1.tblInvoiceTableAdapter = Nothing
        Me.TableAdapterManager1.tblProductTableAdapter = Me.TblProductTableAdapter1
        Me.TableAdapterManager1.tblStaffTableAdapter = Nothing
        Me.TableAdapterManager1.UpdateOrder = Milky_Lane_Point_of_Sales_System.ist2gqDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'TblProductTableAdapter1
        '
        Me.TblProductTableAdapter1.ClearBeforeFill = True
        '
        'LabelID
        '
        Me.LabelID.AutoSize = True
        Me.LabelID.BackColor = System.Drawing.Color.Transparent
        Me.LabelID.Font = New System.Drawing.Font("Arial Rounded MT Bold", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelID.Location = New System.Drawing.Point(22, 83)
        Me.LabelID.Name = "LabelID"
        Me.LabelID.Size = New System.Drawing.Size(29, 17)
        Me.LabelID.TabIndex = 20
        Me.LabelID.Text = "ID:"
        '
        'TextBoxID
        '
        Me.TextBoxID.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BindingSourceProduct, "Product_Description", True))
        Me.TextBoxID.Enabled = False
        Me.TextBoxID.Location = New System.Drawing.Point(177, 84)
        Me.TextBoxID.Name = "TextBoxID"
        Me.TextBoxID.Size = New System.Drawing.Size(234, 20)
        Me.TextBoxID.TabIndex = 21
        '
        'AddProduct
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Milky_Lane_Point_of_Sales_System.My.Resources.Resources.Background
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(433, 304)
        Me.Controls.Add(Me.TextBoxID)
        Me.Controls.Add(Me.LabelID)
        Me.Controls.Add(Me.ButtonAddProduct)
        Me.Controls.Add(Me.LabelAddCustomer)
        Me.Controls.Add(Me.TextBoxAmountSold)
        Me.Controls.Add(Me.labelAmountSold)
        Me.Controls.Add(Me.TextBoxPrice)
        Me.Controls.Add(Me.LabelLastPrice)
        Me.Controls.Add(Me.TextBoxDescription)
        Me.Controls.Add(Me.LabelFirstDescription)
        Me.Font = New System.Drawing.Font("Arial Rounded MT Bold", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "AddProduct"
        Me.Text = "Add Product"
        CType(Me.BindingSourceProduct, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Ist2gqDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ButtonAddProduct As Button
    Friend WithEvents LabelAddCustomer As Label
    Friend WithEvents TextBoxAmountSold As TextBox
    Friend WithEvents labelAmountSold As Label
    Friend WithEvents TextBoxPrice As TextBox
    Friend WithEvents LabelLastPrice As Label
    Friend WithEvents TextBoxDescription As TextBox
    Friend WithEvents LabelFirstDescription As Label
    Friend WithEvents BindingSourceProduct As BindingSource
    Friend WithEvents Ist2gqDataSet1 As ist2gqDataSet
    Friend WithEvents TableAdapterManager1 As ist2gqDataSetTableAdapters.TableAdapterManager
    Friend WithEvents TblProductTableAdapter1 As ist2gqDataSetTableAdapters.tblProductTableAdapter
    Friend WithEvents LabelID As Label
    Friend WithEvents TextBoxID As TextBox
End Class
