<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainMenu
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
        Me.ButtonExit = New System.Windows.Forms.Button()
        Me.ButtonSales = New System.Windows.Forms.Button()
        Me.ButtonTransactions = New System.Windows.Forms.Button()
        Me.ButtonProducts = New System.Windows.Forms.Button()
        Me.ButtonStaff = New System.Windows.Forms.Button()
        Me.ButtonCustomers = New System.Windows.Forms.Button()
        Me.ButtonSettings = New System.Windows.Forms.Button()
        Me.LabelDate = New System.Windows.Forms.Label()
        Me.LabelUsername = New System.Windows.Forms.Label()
        Me.LabelVersionNumber = New System.Windows.Forms.Label()
        Me.PictureBoxLogo = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBoxLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ButtonExit
        '
        Me.ButtonExit.Font = New System.Drawing.Font("Arial Rounded MT Bold", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonExit.Location = New System.Drawing.Point(1, 410)
        Me.ButtonExit.Name = "ButtonExit"
        Me.ButtonExit.Size = New System.Drawing.Size(181, 73)
        Me.ButtonExit.TabIndex = 0
        Me.ButtonExit.Text = "Exit"
        Me.ButtonExit.UseVisualStyleBackColor = True
        '
        'ButtonSales
        '
        Me.ButtonSales.Font = New System.Drawing.Font("Arial Rounded MT Bold", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonSales.Location = New System.Drawing.Point(1, 0)
        Me.ButtonSales.Name = "ButtonSales"
        Me.ButtonSales.Size = New System.Drawing.Size(181, 73)
        Me.ButtonSales.TabIndex = 1
        Me.ButtonSales.Text = "Sales"
        Me.ButtonSales.UseVisualStyleBackColor = True
        '
        'ButtonTransactions
        '
        Me.ButtonTransactions.Font = New System.Drawing.Font("Arial Rounded MT Bold", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonTransactions.Location = New System.Drawing.Point(1, 134)
        Me.ButtonTransactions.Name = "ButtonTransactions"
        Me.ButtonTransactions.Size = New System.Drawing.Size(181, 73)
        Me.ButtonTransactions.TabIndex = 2
        Me.ButtonTransactions.Text = "Transactions"
        Me.ButtonTransactions.UseVisualStyleBackColor = True
        '
        'ButtonProducts
        '
        Me.ButtonProducts.Font = New System.Drawing.Font("Arial Rounded MT Bold", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonProducts.Location = New System.Drawing.Point(1, 201)
        Me.ButtonProducts.Name = "ButtonProducts"
        Me.ButtonProducts.Size = New System.Drawing.Size(181, 73)
        Me.ButtonProducts.TabIndex = 3
        Me.ButtonProducts.Text = "Products"
        Me.ButtonProducts.UseVisualStyleBackColor = True
        '
        'ButtonStaff
        '
        Me.ButtonStaff.Font = New System.Drawing.Font("Arial Rounded MT Bold", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonStaff.Location = New System.Drawing.Point(1, 270)
        Me.ButtonStaff.Name = "ButtonStaff"
        Me.ButtonStaff.Size = New System.Drawing.Size(181, 73)
        Me.ButtonStaff.TabIndex = 4
        Me.ButtonStaff.Text = "Staff"
        Me.ButtonStaff.UseVisualStyleBackColor = True
        '
        'ButtonCustomers
        '
        Me.ButtonCustomers.Font = New System.Drawing.Font("Arial Rounded MT Bold", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonCustomers.Location = New System.Drawing.Point(1, 67)
        Me.ButtonCustomers.Name = "ButtonCustomers"
        Me.ButtonCustomers.Size = New System.Drawing.Size(181, 73)
        Me.ButtonCustomers.TabIndex = 5
        Me.ButtonCustomers.Text = "Customers"
        Me.ButtonCustomers.UseVisualStyleBackColor = True
        '
        'ButtonSettings
        '
        Me.ButtonSettings.Font = New System.Drawing.Font("Arial Rounded MT Bold", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonSettings.Location = New System.Drawing.Point(1, 340)
        Me.ButtonSettings.Name = "ButtonSettings"
        Me.ButtonSettings.Size = New System.Drawing.Size(181, 73)
        Me.ButtonSettings.TabIndex = 6
        Me.ButtonSettings.Text = "Settings"
        Me.ButtonSettings.UseVisualStyleBackColor = True
        '
        'LabelDate
        '
        Me.LabelDate.AutoSize = True
        Me.LabelDate.Font = New System.Drawing.Font("Arial Rounded MT Bold", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelDate.Location = New System.Drawing.Point(188, 9)
        Me.LabelDate.Name = "LabelDate"
        Me.LabelDate.Size = New System.Drawing.Size(57, 24)
        Me.LabelDate.TabIndex = 7
        Me.LabelDate.Text = "Date"
        '
        'LabelUsername
        '
        Me.LabelUsername.AutoSize = True
        Me.LabelUsername.Font = New System.Drawing.Font("Arial Rounded MT Bold", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelUsername.Location = New System.Drawing.Point(554, 9)
        Me.LabelUsername.Name = "LabelUsername"
        Me.LabelUsername.Size = New System.Drawing.Size(114, 24)
        Me.LabelUsername.TabIndex = 8
        Me.LabelUsername.Text = "Username"
        '
        'LabelVersionNumber
        '
        Me.LabelVersionNumber.AutoSize = True
        Me.LabelVersionNumber.BackColor = System.Drawing.Color.Transparent
        Me.LabelVersionNumber.Font = New System.Drawing.Font("Arial Rounded MT Bold", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelVersionNumber.Location = New System.Drawing.Point(518, 447)
        Me.LabelVersionNumber.Name = "LabelVersionNumber"
        Me.LabelVersionNumber.Size = New System.Drawing.Size(162, 24)
        Me.LabelVersionNumber.TabIndex = 9
        Me.LabelVersionNumber.Text = "Version no. 1.0"
        '
        'PictureBoxLogo
        '
        Me.PictureBoxLogo.BackColor = System.Drawing.Color.Transparent
        Me.PictureBoxLogo.BackgroundImage = Global.Milky_Lane_Point_of_Sales_System.My.Resources.Resources.MilkyLaneLogo
        Me.PictureBoxLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBoxLogo.Location = New System.Drawing.Point(217, 36)
        Me.PictureBoxLogo.Name = "PictureBoxLogo"
        Me.PictureBoxLogo.Size = New System.Drawing.Size(427, 408)
        Me.PictureBoxLogo.TabIndex = 10
        Me.PictureBoxLogo.TabStop = False
        '
        'MainMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.BackgroundImage = Global.Milky_Lane_Point_of_Sales_System.My.Resources.Resources.Background
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(680, 480)
        Me.Controls.Add(Me.PictureBoxLogo)
        Me.Controls.Add(Me.LabelVersionNumber)
        Me.Controls.Add(Me.LabelUsername)
        Me.Controls.Add(Me.LabelDate)
        Me.Controls.Add(Me.ButtonSettings)
        Me.Controls.Add(Me.ButtonCustomers)
        Me.Controls.Add(Me.ButtonStaff)
        Me.Controls.Add(Me.ButtonProducts)
        Me.Controls.Add(Me.ButtonTransactions)
        Me.Controls.Add(Me.ButtonSales)
        Me.Controls.Add(Me.ButtonExit)
        Me.Font = New System.Drawing.Font("Arial Rounded MT Bold", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "MainMenu"
        Me.Text = "MainMenu"
        CType(Me.PictureBoxLogo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ButtonExit As Button
    Friend WithEvents ButtonSales As Button
    Friend WithEvents ButtonTransactions As Button
    Friend WithEvents ButtonProducts As Button
    Friend WithEvents ButtonStaff As Button
    Friend WithEvents ButtonCustomers As Button
    Friend WithEvents ButtonSettings As Button
    Friend WithEvents LabelDate As Label
    Friend WithEvents LabelUsername As Label
    Friend WithEvents LabelVersionNumber As Label
    Friend WithEvents PictureBoxLogo As PictureBox
End Class
