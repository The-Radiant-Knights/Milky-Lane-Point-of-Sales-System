<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AddStaff
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
        Me.ButtonAddEmployee = New System.Windows.Forms.Button()
        Me.LabelAddCustomer = New System.Windows.Forms.Label()
        Me.LabelRole = New System.Windows.Forms.Label()
        Me.TextBoxPassword = New System.Windows.Forms.TextBox()
        Me.labelPassword = New System.Windows.Forms.Label()
        Me.TextBoxLastName = New System.Windows.Forms.TextBox()
        Me.LabelLastName = New System.Windows.Forms.Label()
        Me.TextBoxFirstName = New System.Windows.Forms.TextBox()
        Me.LabelFirstName = New System.Windows.Forms.Label()
        Me.ComboBoxRole = New System.Windows.Forms.ComboBox()
        Me.Ist2gqDataSet = New Milky_Lane_Point_of_Sales_System.ist2gqDataSet()
        Me.TableAdapterManager1 = New Milky_Lane_Point_of_Sales_System.ist2gqDataSetTableAdapters.TableAdapterManager()
        Me.TblStaffTableAdapter1 = New Milky_Lane_Point_of_Sales_System.ist2gqDataSetTableAdapters.tblStaffTableAdapter()
        Me.BindingSourceStaff = New System.Windows.Forms.BindingSource(Me.components)
        Me.TextBoxID = New System.Windows.Forms.TextBox()
        Me.LabelID = New System.Windows.Forms.Label()
        CType(Me.Ist2gqDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BindingSourceStaff, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ButtonAddEmployee
        '
        Me.ButtonAddEmployee.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonAddEmployee.Location = New System.Drawing.Point(244, 272)
        Me.ButtonAddEmployee.Name = "ButtonAddEmployee"
        Me.ButtonAddEmployee.Size = New System.Drawing.Size(165, 40)
        Me.ButtonAddEmployee.TabIndex = 19
        Me.ButtonAddEmployee.Text = "Add Employee"
        Me.ButtonAddEmployee.UseVisualStyleBackColor = True
        '
        'LabelAddCustomer
        '
        Me.LabelAddCustomer.AutoSize = True
        Me.LabelAddCustomer.BackColor = System.Drawing.Color.Transparent
        Me.LabelAddCustomer.Font = New System.Drawing.Font("Arial Rounded MT Bold", 18.0!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelAddCustomer.Location = New System.Drawing.Point(113, 20)
        Me.LabelAddCustomer.Name = "LabelAddCustomer"
        Me.LabelAddCustomer.Size = New System.Drawing.Size(237, 28)
        Me.LabelAddCustomer.TabIndex = 18
        Me.LabelAddCustomer.Text = "Add New Employee"
        '
        'LabelRole
        '
        Me.LabelRole.AutoSize = True
        Me.LabelRole.BackColor = System.Drawing.Color.Transparent
        Me.LabelRole.Font = New System.Drawing.Font("Arial Rounded MT Bold", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelRole.Location = New System.Drawing.Point(20, 225)
        Me.LabelRole.Name = "LabelRole"
        Me.LabelRole.Size = New System.Drawing.Size(46, 17)
        Me.LabelRole.TabIndex = 16
        Me.LabelRole.Text = "Role:"
        '
        'TextBoxPassword
        '
        Me.TextBoxPassword.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BindingSourceStaff, "Staff_Passcode", True))
        Me.TextBoxPassword.Location = New System.Drawing.Point(175, 182)
        Me.TextBoxPassword.Name = "TextBoxPassword"
        Me.TextBoxPassword.Size = New System.Drawing.Size(234, 20)
        Me.TextBoxPassword.TabIndex = 15
        '
        'labelPassword
        '
        Me.labelPassword.AutoSize = True
        Me.labelPassword.BackColor = System.Drawing.Color.Transparent
        Me.labelPassword.Font = New System.Drawing.Font("Arial Rounded MT Bold", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labelPassword.Location = New System.Drawing.Point(20, 185)
        Me.labelPassword.Name = "labelPassword"
        Me.labelPassword.Size = New System.Drawing.Size(85, 17)
        Me.labelPassword.TabIndex = 14
        Me.labelPassword.Text = "Password:"
        '
        'TextBoxLastName
        '
        Me.TextBoxLastName.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BindingSourceStaff, "Staff_LastName", True))
        Me.TextBoxLastName.Location = New System.Drawing.Point(175, 140)
        Me.TextBoxLastName.Name = "TextBoxLastName"
        Me.TextBoxLastName.Size = New System.Drawing.Size(234, 20)
        Me.TextBoxLastName.TabIndex = 13
        '
        'LabelLastName
        '
        Me.LabelLastName.AutoSize = True
        Me.LabelLastName.BackColor = System.Drawing.Color.Transparent
        Me.LabelLastName.Font = New System.Drawing.Font("Arial Rounded MT Bold", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelLastName.Location = New System.Drawing.Point(20, 143)
        Me.LabelLastName.Name = "LabelLastName"
        Me.LabelLastName.Size = New System.Drawing.Size(90, 17)
        Me.LabelLastName.TabIndex = 12
        Me.LabelLastName.Text = "Last Name:"
        '
        'TextBoxFirstName
        '
        Me.TextBoxFirstName.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BindingSourceStaff, "Staff_FirstName", True))
        Me.TextBoxFirstName.Location = New System.Drawing.Point(175, 105)
        Me.TextBoxFirstName.Name = "TextBoxFirstName"
        Me.TextBoxFirstName.Size = New System.Drawing.Size(234, 20)
        Me.TextBoxFirstName.TabIndex = 11
        '
        'LabelFirstName
        '
        Me.LabelFirstName.AutoSize = True
        Me.LabelFirstName.BackColor = System.Drawing.Color.Transparent
        Me.LabelFirstName.Font = New System.Drawing.Font("Arial Rounded MT Bold", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelFirstName.Location = New System.Drawing.Point(20, 105)
        Me.LabelFirstName.Name = "LabelFirstName"
        Me.LabelFirstName.Size = New System.Drawing.Size(92, 17)
        Me.LabelFirstName.TabIndex = 10
        Me.LabelFirstName.Text = "First Name:"
        '
        'ComboBoxRole
        '
        Me.ComboBoxRole.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BindingSourceStaff, "Staff_Role", True))
        Me.ComboBoxRole.FormattingEnabled = True
        Me.ComboBoxRole.Items.AddRange(New Object() {"Manager", "Cashier", "Waiter", "Waitress", "Janitor"})
        Me.ComboBoxRole.Location = New System.Drawing.Point(175, 225)
        Me.ComboBoxRole.Name = "ComboBoxRole"
        Me.ComboBoxRole.Size = New System.Drawing.Size(234, 20)
        Me.ComboBoxRole.TabIndex = 20
        '
        'Ist2gqDataSet
        '
        Me.Ist2gqDataSet.DataSetName = "ist2gqDataSet"
        Me.Ist2gqDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TableAdapterManager1
        '
        Me.TableAdapterManager1.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager1.tblCustomerTableAdapter = Nothing
        Me.TableAdapterManager1.tblInvoiceTableAdapter = Nothing
        Me.TableAdapterManager1.tblProductTableAdapter = Nothing
        Me.TableAdapterManager1.tblStaffTableAdapter = Me.TblStaffTableAdapter1
        Me.TableAdapterManager1.UpdateOrder = Milky_Lane_Point_of_Sales_System.ist2gqDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'TblStaffTableAdapter1
        '
        Me.TblStaffTableAdapter1.ClearBeforeFill = True
        '
        'BindingSourceStaff
        '
        Me.BindingSourceStaff.DataMember = "tblStaff"
        Me.BindingSourceStaff.DataSource = Me.Ist2gqDataSet
        '
        'TextBoxID
        '
        Me.TextBoxID.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BindingSourceStaff, "Staff_ID", True))
        Me.TextBoxID.Enabled = False
        Me.TextBoxID.Location = New System.Drawing.Point(175, 68)
        Me.TextBoxID.Name = "TextBoxID"
        Me.TextBoxID.Size = New System.Drawing.Size(234, 20)
        Me.TextBoxID.TabIndex = 21
        '
        'LabelID
        '
        Me.LabelID.AutoSize = True
        Me.LabelID.BackColor = System.Drawing.Color.Transparent
        Me.LabelID.Font = New System.Drawing.Font("Arial Rounded MT Bold", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelID.Location = New System.Drawing.Point(20, 68)
        Me.LabelID.Name = "LabelID"
        Me.LabelID.Size = New System.Drawing.Size(29, 17)
        Me.LabelID.TabIndex = 22
        Me.LabelID.Text = "ID:"
        '
        'AddStaff
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Milky_Lane_Point_of_Sales_System.My.Resources.Resources.Background
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(445, 326)
        Me.Controls.Add(Me.LabelID)
        Me.Controls.Add(Me.TextBoxID)
        Me.Controls.Add(Me.ComboBoxRole)
        Me.Controls.Add(Me.ButtonAddEmployee)
        Me.Controls.Add(Me.LabelAddCustomer)
        Me.Controls.Add(Me.LabelRole)
        Me.Controls.Add(Me.TextBoxPassword)
        Me.Controls.Add(Me.labelPassword)
        Me.Controls.Add(Me.TextBoxLastName)
        Me.Controls.Add(Me.LabelLastName)
        Me.Controls.Add(Me.TextBoxFirstName)
        Me.Controls.Add(Me.LabelFirstName)
        Me.Font = New System.Drawing.Font("Arial Rounded MT Bold", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "AddStaff"
        Me.Text = "Add Employee"
        CType(Me.Ist2gqDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BindingSourceStaff, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ButtonAddEmployee As Button
    Friend WithEvents LabelAddCustomer As Label
    Friend WithEvents LabelRole As Label
    Friend WithEvents TextBoxPassword As TextBox
    Friend WithEvents labelPassword As Label
    Friend WithEvents TextBoxLastName As TextBox
    Friend WithEvents LabelLastName As Label
    Friend WithEvents TextBoxFirstName As TextBox
    Friend WithEvents LabelFirstName As Label
    Friend WithEvents ComboBoxRole As ComboBox
    Friend WithEvents Ist2gqDataSet As ist2gqDataSet
    Friend WithEvents TableAdapterManager1 As ist2gqDataSetTableAdapters.TableAdapterManager
    Friend WithEvents TblStaffTableAdapter1 As ist2gqDataSetTableAdapters.tblStaffTableAdapter
    Friend WithEvents BindingSourceStaff As BindingSource
    Friend WithEvents TextBoxID As TextBox
    Friend WithEvents LabelID As Label
End Class
