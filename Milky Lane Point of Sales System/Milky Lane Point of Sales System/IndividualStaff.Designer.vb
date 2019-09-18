<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class IndividualStaff
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
        Me.ButtonPreviousEmployee = New System.Windows.Forms.Button()
        Me.ButtonNextEmployee = New System.Windows.Forms.Button()
        Me.ButtonAddEmployee = New System.Windows.Forms.Button()
        Me.ButtonRemoveEmployee = New System.Windows.Forms.Button()
        Me.ButtonUpdateEmployee = New System.Windows.Forms.Button()
        Me.LabelRoles = New System.Windows.Forms.Label()
        Me.TextBoxRole = New System.Windows.Forms.TextBox()
        Me.LabelEmployee = New System.Windows.Forms.Label()
        Me.TextBoxPassword = New System.Windows.Forms.TextBox()
        Me.TextBoxFirstName = New System.Windows.Forms.TextBox()
        Me.labelFirstName = New System.Windows.Forms.Label()
        Me.TextBoxLastName = New System.Windows.Forms.TextBox()
        Me.LabelLastName = New System.Windows.Forms.Label()
        Me.TextBoxID = New System.Windows.Forms.TextBox()
        Me.LabelID = New System.Windows.Forms.Label()
        Me.LabelPassword = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'ButtonPreviousEmployee
        '
        Me.ButtonPreviousEmployee.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonPreviousEmployee.Location = New System.Drawing.Point(87, 319)
        Me.ButtonPreviousEmployee.Name = "ButtonPreviousEmployee"
        Me.ButtonPreviousEmployee.Size = New System.Drawing.Size(129, 40)
        Me.ButtonPreviousEmployee.TabIndex = 41
        Me.ButtonPreviousEmployee.Text = "Previous Employee"
        Me.ButtonPreviousEmployee.UseVisualStyleBackColor = True
        '
        'ButtonNextEmployee
        '
        Me.ButtonNextEmployee.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonNextEmployee.Location = New System.Drawing.Point(222, 319)
        Me.ButtonNextEmployee.Name = "ButtonNextEmployee"
        Me.ButtonNextEmployee.Size = New System.Drawing.Size(129, 40)
        Me.ButtonNextEmployee.TabIndex = 40
        Me.ButtonNextEmployee.Text = "Next Employee"
        Me.ButtonNextEmployee.UseVisualStyleBackColor = True
        '
        'ButtonAddEmployee
        '
        Me.ButtonAddEmployee.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonAddEmployee.Location = New System.Drawing.Point(280, 273)
        Me.ButtonAddEmployee.Name = "ButtonAddEmployee"
        Me.ButtonAddEmployee.Size = New System.Drawing.Size(129, 40)
        Me.ButtonAddEmployee.TabIndex = 39
        Me.ButtonAddEmployee.Text = "Add Employee"
        Me.ButtonAddEmployee.UseVisualStyleBackColor = True
        '
        'ButtonRemoveEmployee
        '
        Me.ButtonRemoveEmployee.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonRemoveEmployee.Location = New System.Drawing.Point(145, 273)
        Me.ButtonRemoveEmployee.Name = "ButtonRemoveEmployee"
        Me.ButtonRemoveEmployee.Size = New System.Drawing.Size(129, 40)
        Me.ButtonRemoveEmployee.TabIndex = 38
        Me.ButtonRemoveEmployee.Text = "Remove Employee"
        Me.ButtonRemoveEmployee.UseVisualStyleBackColor = True
        '
        'ButtonUpdateEmployee
        '
        Me.ButtonUpdateEmployee.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonUpdateEmployee.Location = New System.Drawing.Point(13, 273)
        Me.ButtonUpdateEmployee.Name = "ButtonUpdateEmployee"
        Me.ButtonUpdateEmployee.Size = New System.Drawing.Size(126, 40)
        Me.ButtonUpdateEmployee.TabIndex = 37
        Me.ButtonUpdateEmployee.Text = "Update Employee"
        Me.ButtonUpdateEmployee.UseVisualStyleBackColor = True
        '
        'LabelRoles
        '
        Me.LabelRoles.AutoSize = True
        Me.LabelRoles.BackColor = System.Drawing.Color.Transparent
        Me.LabelRoles.Font = New System.Drawing.Font("Arial Rounded MT Bold", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelRoles.Location = New System.Drawing.Point(20, 224)
        Me.LabelRoles.Name = "LabelRoles"
        Me.LabelRoles.Size = New System.Drawing.Size(46, 17)
        Me.LabelRoles.TabIndex = 36
        Me.LabelRoles.Text = "Role:"
        '
        'TextBoxRole
        '
        Me.TextBoxRole.Location = New System.Drawing.Point(175, 221)
        Me.TextBoxRole.Name = "TextBoxRole"
        Me.TextBoxRole.Size = New System.Drawing.Size(234, 20)
        Me.TextBoxRole.TabIndex = 35
        '
        'LabelEmployee
        '
        Me.LabelEmployee.AutoSize = True
        Me.LabelEmployee.BackColor = System.Drawing.Color.Transparent
        Me.LabelEmployee.Font = New System.Drawing.Font("Arial Rounded MT Bold", 18.0!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelEmployee.Location = New System.Drawing.Point(149, 18)
        Me.LabelEmployee.Name = "LabelEmployee"
        Me.LabelEmployee.Size = New System.Drawing.Size(126, 28)
        Me.LabelEmployee.TabIndex = 34
        Me.LabelEmployee.Text = "Employee"
        '
        'TextBoxPassword
        '
        Me.TextBoxPassword.Location = New System.Drawing.Point(175, 185)
        Me.TextBoxPassword.Name = "TextBoxPassword"
        Me.TextBoxPassword.Size = New System.Drawing.Size(234, 20)
        Me.TextBoxPassword.TabIndex = 33
        '
        'TextBoxFirstName
        '
        Me.TextBoxFirstName.Location = New System.Drawing.Point(175, 145)
        Me.TextBoxFirstName.Name = "TextBoxFirstName"
        Me.TextBoxFirstName.Size = New System.Drawing.Size(234, 20)
        Me.TextBoxFirstName.TabIndex = 32
        '
        'labelFirstName
        '
        Me.labelFirstName.AutoSize = True
        Me.labelFirstName.BackColor = System.Drawing.Color.Transparent
        Me.labelFirstName.Font = New System.Drawing.Font("Arial Rounded MT Bold", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labelFirstName.Location = New System.Drawing.Point(20, 148)
        Me.labelFirstName.Name = "labelFirstName"
        Me.labelFirstName.Size = New System.Drawing.Size(92, 17)
        Me.labelFirstName.TabIndex = 31
        Me.labelFirstName.Text = "First Name:"
        '
        'TextBoxLastName
        '
        Me.TextBoxLastName.Location = New System.Drawing.Point(175, 103)
        Me.TextBoxLastName.Name = "TextBoxLastName"
        Me.TextBoxLastName.Size = New System.Drawing.Size(234, 20)
        Me.TextBoxLastName.TabIndex = 30
        '
        'LabelLastName
        '
        Me.LabelLastName.AutoSize = True
        Me.LabelLastName.BackColor = System.Drawing.Color.Transparent
        Me.LabelLastName.Font = New System.Drawing.Font("Arial Rounded MT Bold", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelLastName.Location = New System.Drawing.Point(20, 106)
        Me.LabelLastName.Name = "LabelLastName"
        Me.LabelLastName.Size = New System.Drawing.Size(90, 17)
        Me.LabelLastName.TabIndex = 29
        Me.LabelLastName.Text = "Last Name:"
        '
        'TextBoxID
        '
        Me.TextBoxID.Enabled = False
        Me.TextBoxID.Location = New System.Drawing.Point(175, 69)
        Me.TextBoxID.Name = "TextBoxID"
        Me.TextBoxID.Size = New System.Drawing.Size(234, 20)
        Me.TextBoxID.TabIndex = 28
        '
        'LabelID
        '
        Me.LabelID.AutoSize = True
        Me.LabelID.BackColor = System.Drawing.Color.Transparent
        Me.LabelID.Font = New System.Drawing.Font("Arial Rounded MT Bold", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelID.Location = New System.Drawing.Point(20, 68)
        Me.LabelID.Name = "LabelID"
        Me.LabelID.Size = New System.Drawing.Size(29, 17)
        Me.LabelID.TabIndex = 27
        Me.LabelID.Text = "ID:"
        '
        'LabelPassword
        '
        Me.LabelPassword.AutoSize = True
        Me.LabelPassword.BackColor = System.Drawing.Color.Transparent
        Me.LabelPassword.Font = New System.Drawing.Font("Arial Rounded MT Bold", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelPassword.Location = New System.Drawing.Point(18, 188)
        Me.LabelPassword.Name = "LabelPassword"
        Me.LabelPassword.Size = New System.Drawing.Size(85, 17)
        Me.LabelPassword.TabIndex = 42
        Me.LabelPassword.Text = "Password:"
        '
        'IndividualStaff
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Milky_Lane_Point_of_Sales_System.My.Resources.Resources.Background
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(441, 381)
        Me.Controls.Add(Me.LabelPassword)
        Me.Controls.Add(Me.ButtonPreviousEmployee)
        Me.Controls.Add(Me.ButtonNextEmployee)
        Me.Controls.Add(Me.ButtonAddEmployee)
        Me.Controls.Add(Me.ButtonRemoveEmployee)
        Me.Controls.Add(Me.ButtonUpdateEmployee)
        Me.Controls.Add(Me.LabelRoles)
        Me.Controls.Add(Me.TextBoxRole)
        Me.Controls.Add(Me.LabelEmployee)
        Me.Controls.Add(Me.TextBoxPassword)
        Me.Controls.Add(Me.TextBoxFirstName)
        Me.Controls.Add(Me.labelFirstName)
        Me.Controls.Add(Me.TextBoxLastName)
        Me.Controls.Add(Me.LabelLastName)
        Me.Controls.Add(Me.TextBoxID)
        Me.Controls.Add(Me.LabelID)
        Me.Font = New System.Drawing.Font("Arial Rounded MT Bold", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "IndividualStaff"
        Me.Text = "Employee"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ButtonPreviousEmployee As Button
    Friend WithEvents ButtonNextEmployee As Button
    Friend WithEvents ButtonAddEmployee As Button
    Friend WithEvents ButtonRemoveEmployee As Button
    Friend WithEvents ButtonUpdateEmployee As Button
    Friend WithEvents LabelRoles As Label
    Friend WithEvents TextBoxRole As TextBox
    Friend WithEvents LabelEmployee As Label
    Friend WithEvents TextBoxPassword As TextBox
    Friend WithEvents TextBoxFirstName As TextBox
    Friend WithEvents labelFirstName As Label
    Friend WithEvents TextBoxLastName As TextBox
    Friend WithEvents LabelLastName As Label
    Friend WithEvents TextBoxID As TextBox
    Friend WithEvents LabelID As Label
    Friend WithEvents LabelPassword As Label
End Class
