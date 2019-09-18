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
        Me.ButtonAddCustomer = New System.Windows.Forms.Button()
        Me.LabelAddCustomer = New System.Windows.Forms.Label()
        Me.TextBoxAmountSold = New System.Windows.Forms.TextBox()
        Me.labelAmountSold = New System.Windows.Forms.Label()
        Me.TextBoxPrice = New System.Windows.Forms.TextBox()
        Me.LabelLastPrice = New System.Windows.Forms.Label()
        Me.TextBoxDescription = New System.Windows.Forms.TextBox()
        Me.LabelFirstDescription = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'ButtonAddCustomer
        '
        Me.ButtonAddCustomer.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonAddCustomer.Location = New System.Drawing.Point(242, 195)
        Me.ButtonAddCustomer.Name = "ButtonAddCustomer"
        Me.ButtonAddCustomer.Size = New System.Drawing.Size(165, 40)
        Me.ButtonAddCustomer.TabIndex = 19
        Me.ButtonAddCustomer.Text = "Add Customer"
        Me.ButtonAddCustomer.UseVisualStyleBackColor = True
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
        Me.TextBoxAmountSold.Location = New System.Drawing.Point(173, 150)
        Me.TextBoxAmountSold.Name = "TextBoxAmountSold"
        Me.TextBoxAmountSold.Size = New System.Drawing.Size(234, 20)
        Me.TextBoxAmountSold.TabIndex = 15
        Me.TextBoxAmountSold.Text = "0"
        '
        'labelAmountSold
        '
        Me.labelAmountSold.AutoSize = True
        Me.labelAmountSold.BackColor = System.Drawing.Color.Transparent
        Me.labelAmountSold.Font = New System.Drawing.Font("Arial Rounded MT Bold", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labelAmountSold.Location = New System.Drawing.Point(18, 153)
        Me.labelAmountSold.Name = "labelAmountSold"
        Me.labelAmountSold.Size = New System.Drawing.Size(105, 17)
        Me.labelAmountSold.TabIndex = 14
        Me.labelAmountSold.Text = "Amount Sold:"
        '
        'TextBoxPrice
        '
        Me.TextBoxPrice.Location = New System.Drawing.Point(173, 108)
        Me.TextBoxPrice.Name = "TextBoxPrice"
        Me.TextBoxPrice.Size = New System.Drawing.Size(234, 20)
        Me.TextBoxPrice.TabIndex = 13
        '
        'LabelLastPrice
        '
        Me.LabelLastPrice.AutoSize = True
        Me.LabelLastPrice.BackColor = System.Drawing.Color.Transparent
        Me.LabelLastPrice.Font = New System.Drawing.Font("Arial Rounded MT Bold", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelLastPrice.Location = New System.Drawing.Point(18, 111)
        Me.LabelLastPrice.Name = "LabelLastPrice"
        Me.LabelLastPrice.Size = New System.Drawing.Size(56, 17)
        Me.LabelLastPrice.TabIndex = 12
        Me.LabelLastPrice.Text = "Price: "
        '
        'TextBoxDescription
        '
        Me.TextBoxDescription.Location = New System.Drawing.Point(173, 73)
        Me.TextBoxDescription.Name = "TextBoxDescription"
        Me.TextBoxDescription.Size = New System.Drawing.Size(234, 20)
        Me.TextBoxDescription.TabIndex = 11
        '
        'LabelFirstDescription
        '
        Me.LabelFirstDescription.AutoSize = True
        Me.LabelFirstDescription.BackColor = System.Drawing.Color.Transparent
        Me.LabelFirstDescription.Font = New System.Drawing.Font("Arial Rounded MT Bold", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelFirstDescription.Location = New System.Drawing.Point(18, 73)
        Me.LabelFirstDescription.Name = "LabelFirstDescription"
        Me.LabelFirstDescription.Size = New System.Drawing.Size(97, 17)
        Me.LabelFirstDescription.TabIndex = 10
        Me.LabelFirstDescription.Text = "Description:"
        '
        'AddProduct
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Milky_Lane_Point_of_Sales_System.My.Resources.Resources.Background
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(433, 256)
        Me.Controls.Add(Me.ButtonAddCustomer)
        Me.Controls.Add(Me.LabelAddCustomer)
        Me.Controls.Add(Me.TextBoxAmountSold)
        Me.Controls.Add(Me.labelAmountSold)
        Me.Controls.Add(Me.TextBoxPrice)
        Me.Controls.Add(Me.LabelLastPrice)
        Me.Controls.Add(Me.TextBoxDescription)
        Me.Controls.Add(Me.LabelFirstDescription)
        Me.Font = New System.Drawing.Font("Arial Rounded MT Bold", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "AddProduct"
        Me.Text = "Add Product"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ButtonAddCustomer As Button
    Friend WithEvents LabelAddCustomer As Label
    Friend WithEvents TextBoxAmountSold As TextBox
    Friend WithEvents labelAmountSold As Label
    Friend WithEvents TextBoxPrice As TextBox
    Friend WithEvents LabelLastPrice As Label
    Friend WithEvents TextBoxDescription As TextBox
    Friend WithEvents LabelFirstDescription As Label
End Class
