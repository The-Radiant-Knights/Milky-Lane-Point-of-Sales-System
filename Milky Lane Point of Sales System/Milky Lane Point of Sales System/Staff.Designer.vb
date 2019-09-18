<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Staff
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
        Me.LabelStaff = New System.Windows.Forms.Label()
        Me.ButtonRemoveStaff = New System.Windows.Forms.Button()
        Me.ButtonUpdate = New System.Windows.Forms.Button()
        Me.ButtonAddStaff = New System.Windows.Forms.Button()
        Me.LabelSearch = New System.Windows.Forms.Label()
        Me.TextBoxSearch = New System.Windows.Forms.TextBox()
        Me.ButtonSearch = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Ist2gqDataSet = New Milky_Lane_Point_of_Sales_System.ist2gqDataSet()
        Me.TblStaffBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TblStaffTableAdapter = New Milky_Lane_Point_of_Sales_System.ist2gqDataSetTableAdapters.tblStaffTableAdapter()
        Me.TableAdapterManager = New Milky_Lane_Point_of_Sales_System.ist2gqDataSetTableAdapters.TableAdapterManager()
        Me.StaffIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.StaffLastNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.StaffFirstNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.StaffPasscodeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.StaffRoleDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ButtonRefresh = New System.Windows.Forms.Button()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Ist2gqDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblStaffBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LabelStaff
        '
        Me.LabelStaff.AutoSize = True
        Me.LabelStaff.BackColor = System.Drawing.Color.Transparent
        Me.LabelStaff.Font = New System.Drawing.Font("Arial Rounded MT Bold", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelStaff.Location = New System.Drawing.Point(9, 28)
        Me.LabelStaff.Name = "LabelStaff"
        Me.LabelStaff.Size = New System.Drawing.Size(64, 24)
        Me.LabelStaff.TabIndex = 15
        Me.LabelStaff.Text = "Staff:"
        '
        'ButtonRemoveStaff
        '
        Me.ButtonRemoveStaff.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonRemoveStaff.Location = New System.Drawing.Point(84, 383)
        Me.ButtonRemoveStaff.Name = "ButtonRemoveStaff"
        Me.ButtonRemoveStaff.Size = New System.Drawing.Size(126, 43)
        Me.ButtonRemoveStaff.TabIndex = 14
        Me.ButtonRemoveStaff.Text = "Remove Staff"
        Me.ButtonRemoveStaff.UseVisualStyleBackColor = True
        '
        'ButtonUpdate
        '
        Me.ButtonUpdate.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonUpdate.Location = New System.Drawing.Point(216, 383)
        Me.ButtonUpdate.Name = "ButtonUpdate"
        Me.ButtonUpdate.Size = New System.Drawing.Size(126, 43)
        Me.ButtonUpdate.TabIndex = 13
        Me.ButtonUpdate.Text = "Update Staff"
        Me.ButtonUpdate.UseVisualStyleBackColor = True
        '
        'ButtonAddStaff
        '
        Me.ButtonAddStaff.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonAddStaff.Location = New System.Drawing.Point(348, 383)
        Me.ButtonAddStaff.Name = "ButtonAddStaff"
        Me.ButtonAddStaff.Size = New System.Drawing.Size(137, 43)
        Me.ButtonAddStaff.TabIndex = 12
        Me.ButtonAddStaff.Text = "Add Staff"
        Me.ButtonAddStaff.UseVisualStyleBackColor = True
        '
        'LabelSearch
        '
        Me.LabelSearch.AutoSize = True
        Me.LabelSearch.BackColor = System.Drawing.Color.Transparent
        Me.LabelSearch.Font = New System.Drawing.Font("Arial Rounded MT Bold", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelSearch.Location = New System.Drawing.Point(321, 16)
        Me.LabelSearch.Name = "LabelSearch"
        Me.LabelSearch.Size = New System.Drawing.Size(66, 17)
        Me.LabelSearch.TabIndex = 11
        Me.LabelSearch.Text = "Search:"
        '
        'TextBoxSearch
        '
        Me.TextBoxSearch.Location = New System.Drawing.Point(393, 16)
        Me.TextBoxSearch.Name = "TextBoxSearch"
        Me.TextBoxSearch.Size = New System.Drawing.Size(177, 20)
        Me.TextBoxSearch.TabIndex = 10
        '
        'ButtonSearch
        '
        Me.ButtonSearch.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonSearch.Location = New System.Drawing.Point(455, 42)
        Me.ButtonSearch.Name = "ButtonSearch"
        Me.ButtonSearch.Size = New System.Drawing.Size(115, 33)
        Me.ButtonSearch.TabIndex = 9
        Me.ButtonSearch.Text = "Search"
        Me.ButtonSearch.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.StaffIDDataGridViewTextBoxColumn, Me.StaffLastNameDataGridViewTextBoxColumn, Me.StaffFirstNameDataGridViewTextBoxColumn, Me.StaffPasscodeDataGridViewTextBoxColumn, Me.StaffRoleDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.TblStaffBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(12, 81)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(558, 284)
        Me.DataGridView1.TabIndex = 8
        '
        'Ist2gqDataSet
        '
        Me.Ist2gqDataSet.DataSetName = "ist2gqDataSet"
        Me.Ist2gqDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TblStaffBindingSource
        '
        Me.TblStaffBindingSource.DataMember = "tblStaff"
        Me.TblStaffBindingSource.DataSource = Me.Ist2gqDataSet
        '
        'TblStaffTableAdapter
        '
        Me.TblStaffTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.tblCustomerTableAdapter = Nothing
        Me.TableAdapterManager.tblInvoiceTableAdapter = Nothing
        Me.TableAdapterManager.tblProductTableAdapter = Nothing
        Me.TableAdapterManager.tblStaffTableAdapter = Me.TblStaffTableAdapter
        Me.TableAdapterManager.UpdateOrder = Milky_Lane_Point_of_Sales_System.ist2gqDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'StaffIDDataGridViewTextBoxColumn
        '
        Me.StaffIDDataGridViewTextBoxColumn.DataPropertyName = "Staff_ID"
        Me.StaffIDDataGridViewTextBoxColumn.HeaderText = "Staff_ID"
        Me.StaffIDDataGridViewTextBoxColumn.Name = "StaffIDDataGridViewTextBoxColumn"
        Me.StaffIDDataGridViewTextBoxColumn.ReadOnly = True
        '
        'StaffLastNameDataGridViewTextBoxColumn
        '
        Me.StaffLastNameDataGridViewTextBoxColumn.DataPropertyName = "Staff_LastName"
        Me.StaffLastNameDataGridViewTextBoxColumn.HeaderText = "Staff_LastName"
        Me.StaffLastNameDataGridViewTextBoxColumn.Name = "StaffLastNameDataGridViewTextBoxColumn"
        '
        'StaffFirstNameDataGridViewTextBoxColumn
        '
        Me.StaffFirstNameDataGridViewTextBoxColumn.DataPropertyName = "Staff_FirstName"
        Me.StaffFirstNameDataGridViewTextBoxColumn.HeaderText = "Staff_FirstName"
        Me.StaffFirstNameDataGridViewTextBoxColumn.Name = "StaffFirstNameDataGridViewTextBoxColumn"
        '
        'StaffPasscodeDataGridViewTextBoxColumn
        '
        Me.StaffPasscodeDataGridViewTextBoxColumn.DataPropertyName = "Staff_Passcode"
        Me.StaffPasscodeDataGridViewTextBoxColumn.HeaderText = "Staff_Passcode"
        Me.StaffPasscodeDataGridViewTextBoxColumn.Name = "StaffPasscodeDataGridViewTextBoxColumn"
        '
        'StaffRoleDataGridViewTextBoxColumn
        '
        Me.StaffRoleDataGridViewTextBoxColumn.DataPropertyName = "Staff_Role"
        Me.StaffRoleDataGridViewTextBoxColumn.HeaderText = "Staff_Role"
        Me.StaffRoleDataGridViewTextBoxColumn.Name = "StaffRoleDataGridViewTextBoxColumn"
        '
        'ButtonRefresh
        '
        Me.ButtonRefresh.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonRefresh.Location = New System.Drawing.Point(324, 42)
        Me.ButtonRefresh.Name = "ButtonRefresh"
        Me.ButtonRefresh.Size = New System.Drawing.Size(115, 33)
        Me.ButtonRefresh.TabIndex = 16
        Me.ButtonRefresh.Text = "Refresh"
        Me.ButtonRefresh.UseVisualStyleBackColor = True
        '
        'Staff
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Milky_Lane_Point_of_Sales_System.My.Resources.Resources.Background
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(588, 443)
        Me.Controls.Add(Me.ButtonRefresh)
        Me.Controls.Add(Me.LabelStaff)
        Me.Controls.Add(Me.ButtonRemoveStaff)
        Me.Controls.Add(Me.ButtonUpdate)
        Me.Controls.Add(Me.ButtonAddStaff)
        Me.Controls.Add(Me.LabelSearch)
        Me.Controls.Add(Me.TextBoxSearch)
        Me.Controls.Add(Me.ButtonSearch)
        Me.Controls.Add(Me.DataGridView1)
        Me.Font = New System.Drawing.Font("Arial Rounded MT Bold", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "Staff"
        Me.Text = "Staff"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Ist2gqDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblStaffBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LabelStaff As Label
    Friend WithEvents ButtonRemoveStaff As Button
    Friend WithEvents ButtonUpdate As Button
    Friend WithEvents ButtonAddStaff As Button
    Friend WithEvents LabelSearch As Label
    Friend WithEvents TextBoxSearch As TextBox
    Friend WithEvents ButtonSearch As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Ist2gqDataSet As ist2gqDataSet
    Friend WithEvents TblStaffBindingSource As BindingSource
    Friend WithEvents TblStaffTableAdapter As ist2gqDataSetTableAdapters.tblStaffTableAdapter
    Friend WithEvents TableAdapterManager As ist2gqDataSetTableAdapters.TableAdapterManager
    Friend WithEvents StaffIDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents StaffLastNameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents StaffFirstNameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents StaffPasscodeDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents StaffRoleDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ButtonRefresh As Button
End Class
