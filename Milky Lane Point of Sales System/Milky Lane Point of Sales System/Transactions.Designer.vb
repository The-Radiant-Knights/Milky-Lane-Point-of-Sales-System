<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Transactions
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.LabelTransactions = New System.Windows.Forms.Label()
        Me.ButtonRemoveCustomer = New System.Windows.Forms.Button()
        Me.ButtonUpdate = New System.Windows.Forms.Button()
        Me.ButtonAddTransaction = New System.Windows.Forms.Button()
        Me.LabelSearch = New System.Windows.Forms.Label()
        Me.TextBoxSearch = New System.Windows.Forms.TextBox()
        Me.ButtonSearch = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LabelTransactions
        '
        Me.LabelTransactions.AutoSize = True
        Me.LabelTransactions.BackColor = System.Drawing.Color.Transparent
        Me.LabelTransactions.Font = New System.Drawing.Font("Arial Rounded MT Bold", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelTransactions.Location = New System.Drawing.Point(24, 41)
        Me.LabelTransactions.Name = "LabelTransactions"
        Me.LabelTransactions.Size = New System.Drawing.Size(149, 24)
        Me.LabelTransactions.TabIndex = 15
        Me.LabelTransactions.Text = "Transactions:"
        '
        'ButtonRemoveCustomer
        '
        Me.ButtonRemoveCustomer.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonRemoveCustomer.Location = New System.Drawing.Point(99, 396)
        Me.ButtonRemoveCustomer.Name = "ButtonRemoveCustomer"
        Me.ButtonRemoveCustomer.Size = New System.Drawing.Size(126, 43)
        Me.ButtonRemoveCustomer.TabIndex = 14
        Me.ButtonRemoveCustomer.Text = "Remove Transaction"
        Me.ButtonRemoveCustomer.UseVisualStyleBackColor = True
        '
        'ButtonUpdate
        '
        Me.ButtonUpdate.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonUpdate.Location = New System.Drawing.Point(231, 396)
        Me.ButtonUpdate.Name = "ButtonUpdate"
        Me.ButtonUpdate.Size = New System.Drawing.Size(141, 43)
        Me.ButtonUpdate.TabIndex = 13
        Me.ButtonUpdate.Text = "Update Transaction"
        Me.ButtonUpdate.UseVisualStyleBackColor = True
        '
        'ButtonAddTransaction
        '
        Me.ButtonAddTransaction.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonAddTransaction.Location = New System.Drawing.Point(378, 396)
        Me.ButtonAddTransaction.Name = "ButtonAddTransaction"
        Me.ButtonAddTransaction.Size = New System.Drawing.Size(137, 43)
        Me.ButtonAddTransaction.TabIndex = 12
        Me.ButtonAddTransaction.Text = "Add Transaction"
        Me.ButtonAddTransaction.UseVisualStyleBackColor = True
        '
        'LabelSearch
        '
        Me.LabelSearch.AutoSize = True
        Me.LabelSearch.BackColor = System.Drawing.Color.Transparent
        Me.LabelSearch.Font = New System.Drawing.Font("Arial Rounded MT Bold", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelSearch.Location = New System.Drawing.Point(336, 29)
        Me.LabelSearch.Name = "LabelSearch"
        Me.LabelSearch.Size = New System.Drawing.Size(66, 17)
        Me.LabelSearch.TabIndex = 11
        Me.LabelSearch.Text = "Search:"
        '
        'TextBoxSearch
        '
        Me.TextBoxSearch.Location = New System.Drawing.Point(776, 167)
        Me.TextBoxSearch.Name = "TextBoxSearch"
        Me.TextBoxSearch.Size = New System.Drawing.Size(177, 20)
        Me.TextBoxSearch.TabIndex = 10
        '
        'ButtonSearch
        '
        Me.ButtonSearch.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonSearch.Location = New System.Drawing.Point(446, 55)
        Me.ButtonSearch.Name = "ButtonSearch"
        Me.ButtonSearch.Size = New System.Drawing.Size(139, 33)
        Me.ButtonSearch.TabIndex = 9
        Me.ButtonSearch.Text = "Search"
        Me.ButtonSearch.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(27, 94)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(558, 284)
        Me.DataGridView1.TabIndex = 8
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(409, 29)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(176, 20)
        Me.TextBox1.TabIndex = 16
        '
        'Transactions
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Milky_Lane_Point_of_Sales_System.My.Resources.Resources.Background
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(615, 466)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.LabelTransactions)
        Me.Controls.Add(Me.ButtonRemoveCustomer)
        Me.Controls.Add(Me.ButtonUpdate)
        Me.Controls.Add(Me.ButtonAddTransaction)
        Me.Controls.Add(Me.LabelSearch)
        Me.Controls.Add(Me.TextBoxSearch)
        Me.Controls.Add(Me.ButtonSearch)
        Me.Controls.Add(Me.DataGridView1)
        Me.Font = New System.Drawing.Font("Arial Rounded MT Bold", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "Transactions"
        Me.Text = "Transactions"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LabelTransactions As Label
    Friend WithEvents ButtonRemoveCustomer As Button
    Friend WithEvents ButtonUpdate As Button
    Friend WithEvents ButtonAddTransaction As Button
    Friend WithEvents LabelSearch As Label
    Friend WithEvents TextBoxSearch As TextBox
    Friend WithEvents ButtonSearch As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents TextBox1 As TextBox
End Class
