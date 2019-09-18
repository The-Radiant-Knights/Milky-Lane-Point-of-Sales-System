<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class IndividualCustomer
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
        Me.LabelCustomer = New System.Windows.Forms.Label()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.BindingSourceCustomer = New System.Windows.Forms.BindingSource(Me.components)
        Me.Ist2gqDataSet = New Milky_Lane_Point_of_Sales_System.ist2gqDataSet()
        Me.LabelEmail = New System.Windows.Forms.Label()
        Me.TextBoxContactNumber = New System.Windows.Forms.TextBox()
        Me.labelContactNumber = New System.Windows.Forms.Label()
        Me.TextBoxLastName = New System.Windows.Forms.TextBox()
        Me.LabelLastName = New System.Windows.Forms.Label()
        Me.TextBoxFirstName = New System.Windows.Forms.TextBox()
        Me.LabelFirstName = New System.Windows.Forms.Label()
        Me.TextBoxPoints = New System.Windows.Forms.TextBox()
        Me.LabelPoints = New System.Windows.Forms.Label()
        Me.ButtonUpdateCustomer = New System.Windows.Forms.Button()
        Me.ButtonRemoveCustomer = New System.Windows.Forms.Button()
        Me.ButtonAddCustomer = New System.Windows.Forms.Button()
        Me.ButtonNextCustomer = New System.Windows.Forms.Button()
        Me.ButtonPreviousCustomer = New System.Windows.Forms.Button()
        Me.TblCustomerTableAdapter = New Milky_Lane_Point_of_Sales_System.ist2gqDataSetTableAdapters.tblCustomerTableAdapter()
        Me.TableAdapterManager = New Milky_Lane_Point_of_Sales_System.ist2gqDataSetTableAdapters.TableAdapterManager()
        CType(Me.BindingSourceCustomer, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Ist2gqDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LabelCustomer
        '
        Me.LabelCustomer.AutoSize = True
        Me.LabelCustomer.BackColor = System.Drawing.Color.Transparent
        Me.LabelCustomer.Font = New System.Drawing.Font("Arial Rounded MT Bold", 18.0!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelCustomer.Location = New System.Drawing.Point(170, 24)
        Me.LabelCustomer.Name = "LabelCustomer"
        Me.LabelCustomer.Size = New System.Drawing.Size(125, 28)
        Me.LabelCustomer.TabIndex = 18
        Me.LabelCustomer.Text = "Customer"
        '
        'TextBox2
        '
        Me.TextBox2.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BindingSourceCustomer, "Customer_Email", True))
        Me.TextBox2.Location = New System.Drawing.Point(196, 191)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(234, 20)
        Me.TextBox2.TabIndex = 17
        '
        'BindingSourceCustomer
        '
        Me.BindingSourceCustomer.DataMember = "tblCustomer"
        Me.BindingSourceCustomer.DataSource = Me.Ist2gqDataSet
        '
        'Ist2gqDataSet
        '
        Me.Ist2gqDataSet.DataSetName = "ist2gqDataSet"
        Me.Ist2gqDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'LabelEmail
        '
        Me.LabelEmail.AutoSize = True
        Me.LabelEmail.BackColor = System.Drawing.Color.Transparent
        Me.LabelEmail.Font = New System.Drawing.Font("Arial Rounded MT Bold", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelEmail.Location = New System.Drawing.Point(41, 194)
        Me.LabelEmail.Name = "LabelEmail"
        Me.LabelEmail.Size = New System.Drawing.Size(53, 17)
        Me.LabelEmail.TabIndex = 16
        Me.LabelEmail.Text = "Email:"
        '
        'TextBoxContactNumber
        '
        Me.TextBoxContactNumber.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BindingSourceCustomer, "Customer_PhoneNo", True, System.Windows.Forms.DataSourceUpdateMode.OnValidation, "000 000 000", "000 000 000 "))
        Me.TextBoxContactNumber.Location = New System.Drawing.Point(196, 151)
        Me.TextBoxContactNumber.Name = "TextBoxContactNumber"
        Me.TextBoxContactNumber.Size = New System.Drawing.Size(234, 20)
        Me.TextBoxContactNumber.TabIndex = 15
        '
        'labelContactNumber
        '
        Me.labelContactNumber.AutoSize = True
        Me.labelContactNumber.BackColor = System.Drawing.Color.Transparent
        Me.labelContactNumber.Font = New System.Drawing.Font("Arial Rounded MT Bold", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labelContactNumber.Location = New System.Drawing.Point(41, 154)
        Me.labelContactNumber.Name = "labelContactNumber"
        Me.labelContactNumber.Size = New System.Drawing.Size(132, 17)
        Me.labelContactNumber.TabIndex = 14
        Me.labelContactNumber.Text = "Contact Number:"
        '
        'TextBoxLastName
        '
        Me.TextBoxLastName.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BindingSourceCustomer, "Customer_LastName", True))
        Me.TextBoxLastName.Location = New System.Drawing.Point(196, 109)
        Me.TextBoxLastName.Name = "TextBoxLastName"
        Me.TextBoxLastName.Size = New System.Drawing.Size(234, 20)
        Me.TextBoxLastName.TabIndex = 13
        '
        'LabelLastName
        '
        Me.LabelLastName.AutoSize = True
        Me.LabelLastName.BackColor = System.Drawing.Color.Transparent
        Me.LabelLastName.Font = New System.Drawing.Font("Arial Rounded MT Bold", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelLastName.Location = New System.Drawing.Point(41, 112)
        Me.LabelLastName.Name = "LabelLastName"
        Me.LabelLastName.Size = New System.Drawing.Size(90, 17)
        Me.LabelLastName.TabIndex = 12
        Me.LabelLastName.Text = "Last Name:"
        '
        'TextBoxFirstName
        '
        Me.TextBoxFirstName.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BindingSourceCustomer, "Customer_FirstName", True))
        Me.TextBoxFirstName.Location = New System.Drawing.Point(196, 74)
        Me.TextBoxFirstName.Name = "TextBoxFirstName"
        Me.TextBoxFirstName.Size = New System.Drawing.Size(234, 20)
        Me.TextBoxFirstName.TabIndex = 11
        '
        'LabelFirstName
        '
        Me.LabelFirstName.AutoSize = True
        Me.LabelFirstName.BackColor = System.Drawing.Color.Transparent
        Me.LabelFirstName.Font = New System.Drawing.Font("Arial Rounded MT Bold", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelFirstName.Location = New System.Drawing.Point(41, 74)
        Me.LabelFirstName.Name = "LabelFirstName"
        Me.LabelFirstName.Size = New System.Drawing.Size(92, 17)
        Me.LabelFirstName.TabIndex = 10
        Me.LabelFirstName.Text = "First Name:"
        '
        'TextBoxPoints
        '
        Me.TextBoxPoints.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BindingSourceCustomer, "Customer_Points", True))
        Me.TextBoxPoints.Location = New System.Drawing.Point(196, 227)
        Me.TextBoxPoints.Name = "TextBoxPoints"
        Me.TextBoxPoints.Size = New System.Drawing.Size(234, 20)
        Me.TextBoxPoints.TabIndex = 20
        '
        'LabelPoints
        '
        Me.LabelPoints.AutoSize = True
        Me.LabelPoints.BackColor = System.Drawing.Color.Transparent
        Me.LabelPoints.Font = New System.Drawing.Font("Arial Rounded MT Bold", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelPoints.Location = New System.Drawing.Point(41, 230)
        Me.LabelPoints.Name = "LabelPoints"
        Me.LabelPoints.Size = New System.Drawing.Size(58, 17)
        Me.LabelPoints.TabIndex = 21
        Me.LabelPoints.Text = "Points:"
        '
        'ButtonUpdateCustomer
        '
        Me.ButtonUpdateCustomer.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonUpdateCustomer.Location = New System.Drawing.Point(34, 279)
        Me.ButtonUpdateCustomer.Name = "ButtonUpdateCustomer"
        Me.ButtonUpdateCustomer.Size = New System.Drawing.Size(126, 40)
        Me.ButtonUpdateCustomer.TabIndex = 22
        Me.ButtonUpdateCustomer.Text = "Update/Save  Customer"
        Me.ButtonUpdateCustomer.UseVisualStyleBackColor = True
        '
        'ButtonRemoveCustomer
        '
        Me.ButtonRemoveCustomer.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonRemoveCustomer.Location = New System.Drawing.Point(166, 279)
        Me.ButtonRemoveCustomer.Name = "ButtonRemoveCustomer"
        Me.ButtonRemoveCustomer.Size = New System.Drawing.Size(129, 40)
        Me.ButtonRemoveCustomer.TabIndex = 23
        Me.ButtonRemoveCustomer.Text = "Remove Customer"
        Me.ButtonRemoveCustomer.UseVisualStyleBackColor = True
        '
        'ButtonAddCustomer
        '
        Me.ButtonAddCustomer.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonAddCustomer.Location = New System.Drawing.Point(301, 279)
        Me.ButtonAddCustomer.Name = "ButtonAddCustomer"
        Me.ButtonAddCustomer.Size = New System.Drawing.Size(129, 40)
        Me.ButtonAddCustomer.TabIndex = 24
        Me.ButtonAddCustomer.Text = "Add Customer"
        Me.ButtonAddCustomer.UseVisualStyleBackColor = True
        '
        'ButtonNextCustomer
        '
        Me.ButtonNextCustomer.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonNextCustomer.Location = New System.Drawing.Point(243, 325)
        Me.ButtonNextCustomer.Name = "ButtonNextCustomer"
        Me.ButtonNextCustomer.Size = New System.Drawing.Size(129, 40)
        Me.ButtonNextCustomer.TabIndex = 25
        Me.ButtonNextCustomer.Text = "Next Customer"
        Me.ButtonNextCustomer.UseVisualStyleBackColor = True
        '
        'ButtonPreviousCustomer
        '
        Me.ButtonPreviousCustomer.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonPreviousCustomer.Location = New System.Drawing.Point(108, 325)
        Me.ButtonPreviousCustomer.Name = "ButtonPreviousCustomer"
        Me.ButtonPreviousCustomer.Size = New System.Drawing.Size(129, 40)
        Me.ButtonPreviousCustomer.TabIndex = 26
        Me.ButtonPreviousCustomer.Text = "Previous Customer"
        Me.ButtonPreviousCustomer.UseVisualStyleBackColor = True
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
        'IndividualCustomer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Milky_Lane_Point_of_Sales_System.My.Resources.Resources.Background
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(470, 395)
        Me.Controls.Add(Me.ButtonPreviousCustomer)
        Me.Controls.Add(Me.ButtonNextCustomer)
        Me.Controls.Add(Me.ButtonAddCustomer)
        Me.Controls.Add(Me.ButtonRemoveCustomer)
        Me.Controls.Add(Me.ButtonUpdateCustomer)
        Me.Controls.Add(Me.LabelPoints)
        Me.Controls.Add(Me.TextBoxPoints)
        Me.Controls.Add(Me.LabelCustomer)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.LabelEmail)
        Me.Controls.Add(Me.TextBoxContactNumber)
        Me.Controls.Add(Me.labelContactNumber)
        Me.Controls.Add(Me.TextBoxLastName)
        Me.Controls.Add(Me.LabelLastName)
        Me.Controls.Add(Me.TextBoxFirstName)
        Me.Controls.Add(Me.LabelFirstName)
        Me.Name = "IndividualCustomer"
        Me.Text = "Customer"
        CType(Me.BindingSourceCustomer, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Ist2gqDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LabelCustomer As Label
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents LabelEmail As Label
    Friend WithEvents TextBoxContactNumber As TextBox
    Friend WithEvents labelContactNumber As Label
    Friend WithEvents TextBoxLastName As TextBox
    Friend WithEvents LabelLastName As Label
    Friend WithEvents TextBoxFirstName As TextBox
    Friend WithEvents LabelFirstName As Label
    Friend WithEvents TextBoxPoints As TextBox
    Friend WithEvents LabelPoints As Label
    Friend WithEvents ButtonUpdateCustomer As Button
    Friend WithEvents ButtonRemoveCustomer As Button
    Friend WithEvents ButtonAddCustomer As Button
    Friend WithEvents ButtonNextCustomer As Button
    Friend WithEvents ButtonPreviousCustomer As Button
    Friend WithEvents TblCustomerTableAdapter As ist2gqDataSetTableAdapters.tblCustomerTableAdapter
    Friend WithEvents TableAdapterManager As ist2gqDataSetTableAdapters.TableAdapterManager
    Friend WithEvents BindingSourceCustomer As BindingSource
    Friend WithEvents Ist2gqDataSet As ist2gqDataSet
End Class
