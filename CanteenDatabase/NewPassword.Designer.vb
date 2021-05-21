<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class NewPassword
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
        Me.TextBox_FirstP = New System.Windows.Forms.TextBox()
        Me.TextBox_SecondP = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TextBox_OldPass = New System.Windows.Forms.TextBox()
        Me.Button_close = New System.Windows.Forms.Button()
        Me.Label_Medium = New System.Windows.Forms.Label()
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.Label1.Location = New System.Drawing.Point(97, 108)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(204, 17)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Enter your new password here:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.Label2.Location = New System.Drawing.Point(79, 168)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(230, 17)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Please confirm your new password:"
        '
        'TextBox_FirstP
        '
        Me.TextBox_FirstP.Location = New System.Drawing.Point(102, 142)
        Me.TextBox_FirstP.Margin = New System.Windows.Forms.Padding(4)
        Me.TextBox_FirstP.Name = "TextBox_FirstP"
        Me.TextBox_FirstP.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.TextBox_FirstP.Size = New System.Drawing.Size(199, 22)
        Me.TextBox_FirstP.TabIndex = 2
        '
        'TextBox_SecondP
        '
        Me.TextBox_SecondP.Location = New System.Drawing.Point(102, 191)
        Me.TextBox_SecondP.Margin = New System.Windows.Forms.Padding(4)
        Me.TextBox_SecondP.Name = "TextBox_SecondP"
        Me.TextBox_SecondP.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.TextBox_SecondP.Size = New System.Drawing.Size(199, 22)
        Me.TextBox_SecondP.TabIndex = 3
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.Button1.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.Button1.Location = New System.Drawing.Point(147, 236)
        Me.Button1.Margin = New System.Windows.Forms.Padding(4)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(116, 43)
        Me.Button1.TabIndex = 4
        Me.Button1.Text = "Save Changes"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.Label3.Location = New System.Drawing.Point(97, 52)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(198, 17)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Enter your old password here:"
        '
        'TextBox_OldPass
        '
        Me.TextBox_OldPass.Location = New System.Drawing.Point(102, 82)
        Me.TextBox_OldPass.Margin = New System.Windows.Forms.Padding(4)
        Me.TextBox_OldPass.Name = "TextBox_OldPass"
        Me.TextBox_OldPass.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.TextBox_OldPass.Size = New System.Drawing.Size(199, 22)
        Me.TextBox_OldPass.TabIndex = 6
        '
        'Button_close
        '
        Me.Button_close.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.Button_close.Location = New System.Drawing.Point(338, 5)
        Me.Button_close.Margin = New System.Windows.Forms.Padding(4)
        Me.Button_close.Name = "Button_close"
        Me.Button_close.Size = New System.Drawing.Size(25, 24)
        Me.Button_close.TabIndex = 7
        Me.Button_close.Text = "X"
        Me.Button_close.UseVisualStyleBackColor = False
        '
        'Label_Medium
        '
        Me.Label_Medium.AutoSize = True
        Me.Label_Medium.ForeColor = System.Drawing.Color.Black
        Me.Label_Medium.Location = New System.Drawing.Point(136, 9)
        Me.Label_Medium.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label_Medium.Name = "Label_Medium"
        Me.Label_Medium.Size = New System.Drawing.Size(127, 17)
        Me.Label_Medium.TabIndex = 23
        Me.Label_Medium.Text = "Password Strength"
        '
        'ProgressBar1
        '
        Me.ProgressBar1.Location = New System.Drawing.Point(139, 32)
        Me.ProgressBar1.Margin = New System.Windows.Forms.Padding(4)
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(115, 16)
        Me.ProgressBar1.TabIndex = 22
        '
        'NewPassword
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.ClientSize = New System.Drawing.Size(379, 321)
        Me.Controls.Add(Me.Label_Medium)
        Me.Controls.Add(Me.ProgressBar1)
        Me.Controls.Add(Me.Button_close)
        Me.Controls.Add(Me.TextBox_OldPass)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.TextBox_SecondP)
        Me.Controls.Add(Me.TextBox_FirstP)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "NewPassword"
        Me.Text = "NewPassword"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents TextBox_FirstP As TextBox
    Friend WithEvents TextBox_SecondP As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents TextBox_OldPass As TextBox
    Friend WithEvents Button_close As Button
    Friend WithEvents Label_Medium As Label
    Friend WithEvents ProgressBar1 As ProgressBar
End Class
