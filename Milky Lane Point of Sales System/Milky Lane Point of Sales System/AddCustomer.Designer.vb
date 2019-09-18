<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AddCustomer
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
        Me.LabelFirstName = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.LabelLastName = New System.Windows.Forms.Label()
        Me.TextBoxLastName = New System.Windows.Forms.TextBox()
        Me.labelContactNumber = New System.Windows.Forms.Label()
        Me.TextBoxContactNumber = New System.Windows.Forms.TextBox()
        Me.LabelEmail = New System.Windows.Forms.Label()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.LabelAddCustomer = New System.Windows.Forms.Label()
        Me.ButtonAddCustomer = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'LabelFirstName
        '
        Me.LabelFirstName.AutoSize = True
        Me.LabelFirstName.BackColor = System.Drawing.Color.Transparent
        Me.LabelFirstName.Font = New System.Drawing.Font("Arial Rounded MT Bold", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelFirstName.Location = New System.Drawing.Point(12, 75)
        Me.LabelFirstName.Name = "LabelFirstName"
        Me.LabelFirstName.Size = New System.Drawing.Size(92, 17)
        Me.LabelFirstName.TabIndex = 0
        Me.LabelFirstName.Text = "First Name:"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(167, 75)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(234, 20)
        Me.TextBox1.TabIndex = 1
        '
        'LabelLastName
        '
        Me.LabelLastName.AutoSize = True
        Me.LabelLastName.BackColor = System.Drawing.Color.Transparent
        Me.LabelLastName.Font = New System.Drawing.Font("Arial Rounded MT Bold", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelLastName.Location = New System.Drawing.Point(12, 113)
        Me.LabelLastName.Name = "LabelLastName"
        Me.LabelLastName.Size = New System.Drawing.Size(90, 17)
        Me.LabelLastName.TabIndex = 2
        Me.LabelLastName.Text = "Last Name:"
        '
        'TextBoxLastName
        '
        Me.TextBoxLastName.Location = New System.Drawing.Point(167, 110)
        Me.TextBoxLastName.Name = "TextBoxLastName"
        Me.TextBoxLastName.Size = New System.Drawing.Size(234, 20)
        Me.TextBoxLastName.TabIndex = 3
        '
        'labelContactNumber
        '
        Me.labelContactNumber.AutoSize = True
        Me.labelContactNumber.BackColor = System.Drawing.Color.Transparent
        Me.labelContactNumber.Font = New System.Drawing.Font("Arial Rounded MT Bold", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labelContactNumber.Location = New System.Drawing.Point(12, 155)
        Me.labelContactNumber.Name = "labelContactNumber"
        Me.labelContactNumber.Size = New System.Drawing.Size(132, 17)
        Me.labelContactNumber.TabIndex = 4
        Me.labelContactNumber.Text = "Contact Number:"
        '
        'TextBoxContactNumber
        '
        Me.TextBoxContactNumber.Location = New System.Drawing.Point(167, 152)
        Me.TextBoxContactNumber.Name = "TextBoxContactNumber"
        Me.TextBoxContactNumber.Size = New System.Drawing.Size(234, 20)
        Me.TextBoxContactNumber.TabIndex = 5
        '
        'LabelEmail
        '
        Me.LabelEmail.AutoSize = True
        Me.LabelEmail.BackColor = System.Drawing.Color.Transparent
        Me.LabelEmail.Font = New System.Drawing.Font("Arial Rounded MT Bold", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelEmail.Location = New System.Drawing.Point(12, 195)
        Me.LabelEmail.Name = "LabelEmail"
        Me.LabelEmail.Size = New System.Drawing.Size(53, 17)
        Me.LabelEmail.TabIndex = 6
        Me.LabelEmail.Text = "Email:"
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(167, 192)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(234, 20)
        Me.TextBox2.TabIndex = 7
        '
        'LabelAddCustomer
        '
        Me.LabelAddCustomer.AutoSize = True
        Me.LabelAddCustomer.BackColor = System.Drawing.Color.Transparent
        Me.LabelAddCustomer.Font = New System.Drawing.Font("Arial Rounded MT Bold", 18.0!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelAddCustomer.Location = New System.Drawing.Point(107, 23)
        Me.LabelAddCustomer.Name = "LabelAddCustomer"
        Me.LabelAddCustomer.Size = New System.Drawing.Size(236, 28)
        Me.LabelAddCustomer.TabIndex = 8
        Me.LabelAddCustomer.Text = "Add New Customer"
        '
        'ButtonAddCustomer
        '
        Me.ButtonAddCustomer.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonAddCustomer.Location = New System.Drawing.Point(236, 242)
        Me.ButtonAddCustomer.Name = "ButtonAddCustomer"
        Me.ButtonAddCustomer.Size = New System.Drawing.Size(165, 40)
        Me.ButtonAddCustomer.TabIndex = 9
        Me.ButtonAddCustomer.Text = "Add Customer"
        Me.ButtonAddCustomer.UseVisualStyleBackColor = True
        '
        'AddCustomer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Milky_Lane_Point_of_Sales_System.My.Resources.Resources.Background
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(444, 304)
        Me.Controls.Add(Me.ButtonAddCustomer)
        Me.Controls.Add(Me.LabelAddCustomer)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.LabelEmail)
        Me.Controls.Add(Me.TextBoxContactNumber)
        Me.Controls.Add(Me.labelContactNumber)
        Me.Controls.Add(Me.TextBoxLastName)
        Me.Controls.Add(Me.LabelLastName)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.LabelFirstName)
        Me.Font = New System.Drawing.Font("Arial Rounded MT Bold", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "AddCustomer"
        Me.Text = "Add New Customer"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LabelFirstName As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents LabelLastName As Label
    Friend WithEvents TextBoxLastName As TextBox
    Friend WithEvents labelContactNumber As Label
    Friend WithEvents TextBoxContactNumber As TextBox
    Friend WithEvents LabelEmail As Label
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents LabelAddCustomer As Label
    Friend WithEvents ButtonAddCustomer As Button
End Class
