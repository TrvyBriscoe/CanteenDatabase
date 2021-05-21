<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class LoginPage
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
        Me.Button_LPLogin = New System.Windows.Forms.Button()
        Me.TextBoxLPUser = New System.Windows.Forms.TextBox()
        Me.TextBox_LPPass = New System.Windows.Forms.TextBox()
        Me.LabelLPUser = New System.Windows.Forms.Label()
        Me.Label_LPPass = New System.Windows.Forms.Label()
        Me.Button_AddUser = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button_CloseApp = New System.Windows.Forms.Button()
        Me.Label_forgotPW = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Button_LPLogin
        '
        Me.Button_LPLogin.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.Button_LPLogin.Font = New System.Drawing.Font("Arial", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button_LPLogin.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.Button_LPLogin.Location = New System.Drawing.Point(292, 294)
        Me.Button_LPLogin.Margin = New System.Windows.Forms.Padding(4)
        Me.Button_LPLogin.Name = "Button_LPLogin"
        Me.Button_LPLogin.Size = New System.Drawing.Size(100, 46)
        Me.Button_LPLogin.TabIndex = 1
        Me.Button_LPLogin.Text = "Login"
        Me.Button_LPLogin.UseVisualStyleBackColor = False
        '
        'TextBoxLPUser
        '
        Me.TextBoxLPUser.ForeColor = System.Drawing.SystemColors.WindowText
        Me.TextBoxLPUser.Location = New System.Drawing.Point(292, 212)
        Me.TextBoxLPUser.Margin = New System.Windows.Forms.Padding(4)
        Me.TextBoxLPUser.Name = "TextBoxLPUser"
        Me.TextBoxLPUser.Size = New System.Drawing.Size(132, 22)
        Me.TextBoxLPUser.TabIndex = 2
        '
        'TextBox_LPPass
        '
        Me.TextBox_LPPass.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox_LPPass.Location = New System.Drawing.Point(292, 259)
        Me.TextBox_LPPass.Margin = New System.Windows.Forms.Padding(4)
        Me.TextBox_LPPass.Name = "TextBox_LPPass"
        Me.TextBox_LPPass.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.TextBox_LPPass.Size = New System.Drawing.Size(132, 22)
        Me.TextBox_LPPass.TabIndex = 3
        '
        'LabelLPUser
        '
        Me.LabelLPUser.AutoSize = True
        Me.LabelLPUser.Font = New System.Drawing.Font("Arial", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelLPUser.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.LabelLPUser.Location = New System.Drawing.Point(178, 215)
        Me.LabelLPUser.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LabelLPUser.Name = "LabelLPUser"
        Me.LabelLPUser.Size = New System.Drawing.Size(83, 19)
        Me.LabelLPUser.TabIndex = 4
        Me.LabelLPUser.Text = "Username"
        '
        'Label_LPPass
        '
        Me.Label_LPPass.AutoSize = True
        Me.Label_LPPass.Font = New System.Drawing.Font("Arial", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_LPPass.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.Label_LPPass.Location = New System.Drawing.Point(178, 262)
        Me.Label_LPPass.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label_LPPass.Name = "Label_LPPass"
        Me.Label_LPPass.Size = New System.Drawing.Size(80, 19)
        Me.Label_LPPass.TabIndex = 5
        Me.Label_LPPass.Text = "Password"
        '
        'Button_AddUser
        '
        Me.Button_AddUser.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.Button_AddUser.Font = New System.Drawing.Font("Arial", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button_AddUser.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.Button_AddUser.Location = New System.Drawing.Point(292, 362)
        Me.Button_AddUser.Margin = New System.Windows.Forms.Padding(4)
        Me.Button_AddUser.Name = "Button_AddUser"
        Me.Button_AddUser.Size = New System.Drawing.Size(203, 40)
        Me.Button_AddUser.TabIndex = 6
        Me.Button_AddUser.Text = "Create New Account"
        Me.Button_AddUser.UseVisualStyleBackColor = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.Button_CloseApp)
        Me.Panel1.Location = New System.Drawing.Point(1, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(634, 75)
        Me.Panel1.TabIndex = 8
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft YaHei", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label1.Location = New System.Drawing.Point(189, 23)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(276, 37)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Meadows Canteen"
        '
        'Button_CloseApp
        '
        Me.Button_CloseApp.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Button_CloseApp.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.Button_CloseApp.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button_CloseApp.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Button_CloseApp.Location = New System.Drawing.Point(587, 23)
        Me.Button_CloseApp.Name = "Button_CloseApp"
        Me.Button_CloseApp.Size = New System.Drawing.Size(33, 33)
        Me.Button_CloseApp.TabIndex = 0
        Me.Button_CloseApp.Text = "X"
        Me.Button_CloseApp.UseVisualStyleBackColor = False
        '
        'Label_forgotPW
        '
        Me.Label_forgotPW.AutoSize = True
        Me.Label_forgotPW.Location = New System.Drawing.Point(253, 423)
        Me.Label_forgotPW.Name = "Label_forgotPW"
        Me.Label_forgotPW.Size = New System.Drawing.Size(213, 17)
        Me.Label_forgotPW.TabIndex = 9
        Me.Label_forgotPW.Text = "Have you forgot your password?"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label2.Font = New System.Drawing.Font("Arial", 22.2!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.Label2.Location = New System.Drawing.Point(284, 132)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(144, 43)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "Sign In"
        '
        'LoginPage
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.ClientSize = New System.Drawing.Size(633, 556)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label_forgotPW)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Button_AddUser)
        Me.Controls.Add(Me.Label_LPPass)
        Me.Controls.Add(Me.LabelLPUser)
        Me.Controls.Add(Me.TextBox_LPPass)
        Me.Controls.Add(Me.TextBoxLPUser)
        Me.Controls.Add(Me.Button_LPLogin)
        Me.Cursor = System.Windows.Forms.Cursors.Default
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "LoginPage"
        Me.Text = "Form1"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Button_LPLogin As Button
    Friend WithEvents TextBoxLPUser As TextBox
    Friend WithEvents TextBox_LPPass As TextBox
    Friend WithEvents LabelLPUser As Label
    Friend WithEvents Label_LPPass As Label
    Friend WithEvents Button_AddUser As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label_forgotPW As Label
    Friend WithEvents Button_CloseApp As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
End Class
