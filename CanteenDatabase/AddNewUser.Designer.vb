<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AddNewUser
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TextBox_User = New System.Windows.Forms.TextBox()
        Me.TextBox_Pass1 = New System.Windows.Forms.TextBox()
        Me.TextBox_Pass2 = New System.Windows.Forms.TextBox()
        Me.TextBox_FirstName = New System.Windows.Forms.TextBox()
        Me.TextBox_LastName = New System.Windows.Forms.TextBox()
        Me.TextBox_Child = New System.Windows.Forms.TextBox()
        Me.Button_Add = New System.Windows.Forms.Button()
        Me.Label_Medium = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.TextBox_UID = New System.Windows.Forms.TextBox()
        Me.Button_Close = New System.Windows.Forms.Button()
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.ComboBox_SchoolSelect = New System.Windows.Forms.ComboBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.TextBox_Maiden = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.Label1.Location = New System.Drawing.Point(89, 16)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(174, 17)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Enter your username here"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.Label2.Location = New System.Drawing.Point(89, 90)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(171, 17)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Enter your password here"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.Label3.Location = New System.Drawing.Point(89, 122)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(186, 17)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Confirm your Password here"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.Label4.Location = New System.Drawing.Point(89, 157)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(175, 17)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Enter your first Name here"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.Label5.Location = New System.Drawing.Point(89, 192)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(172, 17)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Enter your last name here"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.Label6.Location = New System.Drawing.Point(89, 220)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(213, 17)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Enter your childs first name here"
        '
        'TextBox_User
        '
        Me.TextBox_User.Location = New System.Drawing.Point(357, 16)
        Me.TextBox_User.Margin = New System.Windows.Forms.Padding(4)
        Me.TextBox_User.Name = "TextBox_User"
        Me.TextBox_User.Size = New System.Drawing.Size(175, 22)
        Me.TextBox_User.TabIndex = 6
        '
        'TextBox_Pass1
        '
        Me.TextBox_Pass1.Location = New System.Drawing.Point(357, 87)
        Me.TextBox_Pass1.Margin = New System.Windows.Forms.Padding(4)
        Me.TextBox_Pass1.Name = "TextBox_Pass1"
        Me.TextBox_Pass1.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.TextBox_Pass1.Size = New System.Drawing.Size(175, 22)
        Me.TextBox_Pass1.TabIndex = 7
        '
        'TextBox_Pass2
        '
        Me.TextBox_Pass2.Location = New System.Drawing.Point(357, 122)
        Me.TextBox_Pass2.Margin = New System.Windows.Forms.Padding(4)
        Me.TextBox_Pass2.Name = "TextBox_Pass2"
        Me.TextBox_Pass2.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.TextBox_Pass2.Size = New System.Drawing.Size(175, 22)
        Me.TextBox_Pass2.TabIndex = 8
        '
        'TextBox_FirstName
        '
        Me.TextBox_FirstName.Location = New System.Drawing.Point(357, 157)
        Me.TextBox_FirstName.Margin = New System.Windows.Forms.Padding(4)
        Me.TextBox_FirstName.Name = "TextBox_FirstName"
        Me.TextBox_FirstName.Size = New System.Drawing.Size(175, 22)
        Me.TextBox_FirstName.TabIndex = 9
        '
        'TextBox_LastName
        '
        Me.TextBox_LastName.Location = New System.Drawing.Point(357, 187)
        Me.TextBox_LastName.Margin = New System.Windows.Forms.Padding(4)
        Me.TextBox_LastName.Name = "TextBox_LastName"
        Me.TextBox_LastName.Size = New System.Drawing.Size(175, 22)
        Me.TextBox_LastName.TabIndex = 10
        '
        'TextBox_Child
        '
        Me.TextBox_Child.Location = New System.Drawing.Point(357, 217)
        Me.TextBox_Child.Margin = New System.Windows.Forms.Padding(4)
        Me.TextBox_Child.Name = "TextBox_Child"
        Me.TextBox_Child.Size = New System.Drawing.Size(175, 22)
        Me.TextBox_Child.TabIndex = 11
        '
        'Button_Add
        '
        Me.Button_Add.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.Button_Add.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.Button_Add.Location = New System.Drawing.Point(381, 391)
        Me.Button_Add.Margin = New System.Windows.Forms.Padding(4)
        Me.Button_Add.Name = "Button_Add"
        Me.Button_Add.Size = New System.Drawing.Size(130, 39)
        Me.Button_Add.TabIndex = 12
        Me.Button_Add.Text = "Add Account"
        Me.Button_Add.UseVisualStyleBackColor = False
        '
        'Label_Medium
        '
        Me.Label_Medium.AutoSize = True
        Me.Label_Medium.ForeColor = System.Drawing.Color.Black
        Me.Label_Medium.Location = New System.Drawing.Point(378, 42)
        Me.Label_Medium.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label_Medium.Name = "Label_Medium"
        Me.Label_Medium.Size = New System.Drawing.Size(127, 17)
        Me.Label_Medium.TabIndex = 14
        Me.Label_Medium.Text = "Password Strength"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.Label7.Location = New System.Drawing.Point(89, 250)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(204, 17)
        Me.Label7.TabIndex = 16
        Me.Label7.Text = "Enter a unique ID for your child" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'TextBox_UID
        '
        Me.TextBox_UID.Location = New System.Drawing.Point(357, 250)
        Me.TextBox_UID.Margin = New System.Windows.Forms.Padding(4)
        Me.TextBox_UID.Name = "TextBox_UID"
        Me.TextBox_UID.Size = New System.Drawing.Size(175, 22)
        Me.TextBox_UID.TabIndex = 17
        '
        'Button_Close
        '
        Me.Button_Close.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.Button_Close.ForeColor = System.Drawing.Color.Maroon
        Me.Button_Close.Location = New System.Drawing.Point(623, 3)
        Me.Button_Close.Margin = New System.Windows.Forms.Padding(4)
        Me.Button_Close.Name = "Button_Close"
        Me.Button_Close.Size = New System.Drawing.Size(36, 30)
        Me.Button_Close.TabIndex = 18
        Me.Button_Close.Text = "X"
        Me.Button_Close.UseVisualStyleBackColor = False
        '
        'ProgressBar1
        '
        Me.ProgressBar1.Location = New System.Drawing.Point(390, 63)
        Me.ProgressBar1.Margin = New System.Windows.Forms.Padding(4)
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(115, 16)
        Me.ProgressBar1.TabIndex = 19
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.Label8.Location = New System.Drawing.Point(89, 287)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(169, 17)
        Me.Label8.TabIndex = 20
        Me.Label8.Text = "Please select your school"
        '
        'ComboBox_SchoolSelect
        '
        Me.ComboBox_SchoolSelect.FormattingEnabled = True
        Me.ComboBox_SchoolSelect.Items.AddRange(New Object() {"NorthSide Hills (.438)", "WestSide Valley (.319)"})
        Me.ComboBox_SchoolSelect.Location = New System.Drawing.Point(357, 284)
        Me.ComboBox_SchoolSelect.Name = "ComboBox_SchoolSelect"
        Me.ComboBox_SchoolSelect.Size = New System.Drawing.Size(175, 24)
        Me.ComboBox_SchoolSelect.TabIndex = 21
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.Label9.Location = New System.Drawing.Point(89, 321)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(254, 17)
        Me.Label9.TabIndex = 22
        Me.Label9.Text = "Enter your mother's maiden name here"
        '
        'TextBox_Maiden
        '
        Me.TextBox_Maiden.Location = New System.Drawing.Point(357, 316)
        Me.TextBox_Maiden.Name = "TextBox_Maiden"
        Me.TextBox_Maiden.Size = New System.Drawing.Size(175, 22)
        Me.TextBox_Maiden.TabIndex = 23
        '
        'AddNewUser
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.ClientSize = New System.Drawing.Size(672, 512)
        Me.Controls.Add(Me.TextBox_Maiden)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.ComboBox_SchoolSelect)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.ProgressBar1)
        Me.Controls.Add(Me.Button_Close)
        Me.Controls.Add(Me.TextBox_UID)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label_Medium)
        Me.Controls.Add(Me.Button_Add)
        Me.Controls.Add(Me.TextBox_Child)
        Me.Controls.Add(Me.TextBox_LastName)
        Me.Controls.Add(Me.TextBox_FirstName)
        Me.Controls.Add(Me.TextBox_Pass2)
        Me.Controls.Add(Me.TextBox_Pass1)
        Me.Controls.Add(Me.TextBox_User)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "AddNewUser"
        Me.Text = "AddNewUser"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents TextBox_User As TextBox
    Friend WithEvents TextBox_Pass1 As TextBox
    Friend WithEvents TextBox_Pass2 As TextBox
    Friend WithEvents TextBox_FirstName As TextBox
    Friend WithEvents TextBox_LastName As TextBox
    Friend WithEvents TextBox_Child As TextBox
    Friend WithEvents Button_Add As Button
    Friend WithEvents Label_Medium As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents TextBox_UID As TextBox
    Friend WithEvents Button_Close As Button
    Friend WithEvents ProgressBar1 As ProgressBar
    Friend WithEvents Label8 As Label
    Friend WithEvents ComboBox_SchoolSelect As ComboBox
    Friend WithEvents Label9 As Label
    Friend WithEvents TextBox_Maiden As TextBox
End Class
