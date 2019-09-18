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
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.ButtonSearch = New System.Windows.Forms.Button()
        Me.TextBoxSearch = New System.Windows.Forms.TextBox()
        Me.LabelSearch = New System.Windows.Forms.Label()
        Me.ButtonAddCustomer = New System.Windows.Forms.Button()
        Me.ButtonUpdate = New System.Windows.Forms.Button()
        Me.ButtonRemoveCustomer = New System.Windows.Forms.Button()
        Me.LabelCustomers = New System.Windows.Forms.Label()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(24, 91)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(558, 284)
        Me.DataGridView1.TabIndex = 0
        '
        'ButtonSearch
        '
        Me.ButtonSearch.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonSearch.Location = New System.Drawing.Point(443, 52)
        Me.ButtonSearch.Name = "ButtonSearch"
        Me.ButtonSearch.Size = New System.Drawing.Size(139, 33)
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
        'Customer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Milky_Lane_Point_of_Sales_System.My.Resources.Resources.Background
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(609, 459)
        Me.Controls.Add(Me.LabelCustomers)
        Me.Controls.Add(Me.ButtonRemoveCustomer)
        Me.Controls.Add(Me.ButtonUpdate)
        Me.Controls.Add(Me.ButtonAddCustomer)
        Me.Controls.Add(Me.LabelSearch)
        Me.Controls.Add(Me.TextBoxSearch)
        Me.Controls.Add(Me.ButtonSearch)
        Me.Controls.Add(Me.DataGridView1)
        Me.Font = New System.Drawing.Font("Arial Rounded MT Bold", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "Customer"
        Me.Text = "Customer"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
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
End Class
