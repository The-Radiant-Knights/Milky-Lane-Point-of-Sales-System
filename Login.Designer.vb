<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Login
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Login))
        Me.btnLogin = New System.Windows.Forms.Button()
        Me.lblLogin = New System.Windows.Forms.Label()
        Me.lblPassword = New System.Windows.Forms.Label()
        Me.edtPassword = New System.Windows.Forms.TextBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.lblChangePassword = New System.Windows.Forms.Label()
        Me.cmbUsers = New System.Windows.Forms.ComboBox()
        Me.pbxHidePass = New System.Windows.Forms.PictureBox()
        Me.pbxShowPass = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbxHidePass, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbxShowPass, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnLogin
        '
        Me.btnLogin.Font = New System.Drawing.Font("Arial Rounded MT Bold", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLogin.Location = New System.Drawing.Point(58, 254)
        Me.btnLogin.Name = "btnLogin"
        Me.btnLogin.Size = New System.Drawing.Size(165, 32)
        Me.btnLogin.TabIndex = 1
        Me.btnLogin.Text = "Sign in"
        Me.btnLogin.UseVisualStyleBackColor = True
        Me.btnLogin.Visible = False
        '
        'lblLogin
        '
        Me.lblLogin.AutoSize = True
        Me.lblLogin.BackColor = System.Drawing.Color.Transparent
        Me.lblLogin.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLogin.Location = New System.Drawing.Point(12, 143)
        Me.lblLogin.Name = "lblLogin"
        Me.lblLogin.Size = New System.Drawing.Size(42, 15)
        Me.lblLogin.TabIndex = 2
        Me.lblLogin.Text = "User:"
        '
        'lblPassword
        '
        Me.lblPassword.AutoSize = True
        Me.lblPassword.BackColor = System.Drawing.Color.Transparent
        Me.lblPassword.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPassword.Location = New System.Drawing.Point(12, 194)
        Me.lblPassword.Name = "lblPassword"
        Me.lblPassword.Size = New System.Drawing.Size(75, 15)
        Me.lblPassword.TabIndex = 3
        Me.lblPassword.Text = "Password:"
        Me.lblPassword.Visible = False
        '
        'edtPassword
        '
        Me.edtPassword.Location = New System.Drawing.Point(93, 192)
        Me.edtPassword.Name = "edtPassword"
        Me.edtPassword.Size = New System.Drawing.Size(165, 20)
        Me.edtPassword.TabIndex = 5
        Me.edtPassword.UseSystemPasswordChar = True
        Me.edtPassword.Visible = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.Location = New System.Drawing.Point(46, -12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(200, 152)
        Me.PictureBox1.TabIndex = 6
        Me.PictureBox1.TabStop = False
        '
        'lblChangePassword
        '
        Me.lblChangePassword.AutoSize = True
        Me.lblChangePassword.BackColor = System.Drawing.Color.Transparent
        Me.lblChangePassword.Font = New System.Drawing.Font("Arial Narrow", 8.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblChangePassword.ForeColor = System.Drawing.Color.Red
        Me.lblChangePassword.Location = New System.Drawing.Point(175, 215)
        Me.lblChangePassword.Name = "lblChangePassword"
        Me.lblChangePassword.Size = New System.Drawing.Size(83, 15)
        Me.lblChangePassword.TabIndex = 7
        Me.lblChangePassword.Text = "Forgot Password?"
        Me.lblChangePassword.Visible = False
        '
        'cmbUsers
        '
        Me.cmbUsers.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbUsers.FormattingEnabled = True
        Me.cmbUsers.Items.AddRange(New Object() {"Cashier", "Manager"})
        Me.cmbUsers.Location = New System.Drawing.Point(93, 141)
        Me.cmbUsers.Name = "cmbUsers"
        Me.cmbUsers.Size = New System.Drawing.Size(165, 21)
        Me.cmbUsers.TabIndex = 8
        '
        'pbxHidePass
        '
        Me.pbxHidePass.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pbxHidePass.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pbxHidePass.Image = Global.Milky_Lane_Point_of_Sales_System.My.Resources.Resources.betterClosedEye
        Me.pbxHidePass.Location = New System.Drawing.Point(236, 192)
        Me.pbxHidePass.Name = "pbxHidePass"
        Me.pbxHidePass.Size = New System.Drawing.Size(22, 20)
        Me.pbxHidePass.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbxHidePass.TabIndex = 9
        Me.pbxHidePass.TabStop = False
        Me.pbxHidePass.Visible = False
        '
        'pbxShowPass
        '
        Me.pbxShowPass.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pbxShowPass.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pbxShowPass.Image = Global.Milky_Lane_Point_of_Sales_System.My.Resources.Resources.OpenEye
        Me.pbxShowPass.Location = New System.Drawing.Point(236, 192)
        Me.pbxShowPass.Name = "pbxShowPass"
        Me.pbxShowPass.Size = New System.Drawing.Size(22, 20)
        Me.pbxShowPass.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbxShowPass.TabIndex = 10
        Me.pbxShowPass.TabStop = False
        Me.pbxShowPass.UseWaitCursor = True
        Me.pbxShowPass.Visible = False
        '
        'Login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(290, 310)
        Me.Controls.Add(Me.pbxShowPass)
        Me.Controls.Add(Me.pbxHidePass)
        Me.Controls.Add(Me.cmbUsers)
        Me.Controls.Add(Me.lblChangePassword)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.edtPassword)
        Me.Controls.Add(Me.lblPassword)
        Me.Controls.Add(Me.lblLogin)
        Me.Controls.Add(Me.btnLogin)
        Me.Name = "Login"
        Me.Text = "Milky Lane Point Of Sales System"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbxHidePass, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbxShowPass, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnLogin As Button
    Friend WithEvents lblLogin As Label
    Friend WithEvents lblPassword As Label
    Friend WithEvents edtPassword As TextBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents lblChangePassword As Label
    Friend WithEvents cmbUsers As ComboBox
    Friend WithEvents pbxHidePass As PictureBox
    Friend WithEvents pbxShowPass As PictureBox
End Class
