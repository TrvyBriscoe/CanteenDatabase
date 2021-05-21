<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AddFunds
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
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label_Credit = New System.Windows.Forms.Label()
        Me.TextBox_CNumbers = New System.Windows.Forms.TextBox()
        Me.TextBox_CExpiry = New System.Windows.Forms.TextBox()
        Me.TextBox_CVV = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TextBox_Topup = New System.Windows.Forms.TextBox()
        Me.Button_Help = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.Button1.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.Button1.Location = New System.Drawing.Point(151, 237)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(95, 41)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Pay"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Label_Credit
        '
        Me.Label_Credit.AutoSize = True
        Me.Label_Credit.Location = New System.Drawing.Point(58, 30)
        Me.Label_Credit.Name = "Label_Credit"
        Me.Label_Credit.Size = New System.Drawing.Size(276, 17)
        Me.Label_Credit.TabIndex = 1
        Me.Label_Credit.Text = "Please enter your credit card details below"
        '
        'TextBox_CNumbers
        '
        Me.TextBox_CNumbers.Location = New System.Drawing.Point(127, 70)
        Me.TextBox_CNumbers.MaxLength = 16
        Me.TextBox_CNumbers.Name = "TextBox_CNumbers"
        Me.TextBox_CNumbers.Size = New System.Drawing.Size(183, 22)
        Me.TextBox_CNumbers.TabIndex = 2
        '
        'TextBox_CExpiry
        '
        Me.TextBox_CExpiry.Location = New System.Drawing.Point(127, 117)
        Me.TextBox_CExpiry.MaxLength = 4
        Me.TextBox_CExpiry.Name = "TextBox_CExpiry"
        Me.TextBox_CExpiry.Size = New System.Drawing.Size(78, 22)
        Me.TextBox_CExpiry.TabIndex = 3
        '
        'TextBox_CVV
        '
        Me.TextBox_CVV.Location = New System.Drawing.Point(265, 117)
        Me.TextBox_CVV.MaxLength = 3
        Me.TextBox_CVV.Name = "TextBox_CVV"
        Me.TextBox_CVV.Size = New System.Drawing.Size(58, 22)
        Me.TextBox_CVV.TabIndex = 4
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(101, 154)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(233, 17)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "How much would you like to top up?"
        '
        'TextBox_Topup
        '
        Me.TextBox_Topup.Location = New System.Drawing.Point(146, 188)
        Me.TextBox_Topup.Name = "TextBox_Topup"
        Me.TextBox_Topup.Size = New System.Drawing.Size(100, 22)
        Me.TextBox_Topup.TabIndex = 6
        '
        'Button_Help
        '
        Me.Button_Help.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.Button_Help.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.Button_Help.Location = New System.Drawing.Point(354, 20)
        Me.Button_Help.Name = "Button_Help"
        Me.Button_Help.Size = New System.Drawing.Size(41, 36)
        Me.Button_Help.TabIndex = 7
        Me.Button_Help.Text = "?"
        Me.Button_Help.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(224, 120)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(35, 17)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "CVV"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(41, 120)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(80, 17)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "Expiry Date"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(29, 73)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(92, 17)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "Card Number"
        '
        'AddFunds
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.ClientSize = New System.Drawing.Size(427, 307)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Button_Help)
        Me.Controls.Add(Me.TextBox_Topup)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TextBox_CVV)
        Me.Controls.Add(Me.TextBox_CExpiry)
        Me.Controls.Add(Me.TextBox_CNumbers)
        Me.Controls.Add(Me.Label_Credit)
        Me.Controls.Add(Me.Button1)
        Me.Name = "AddFunds"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents Label_Credit As Label
    Friend WithEvents TextBox_CNumbers As TextBox
    Friend WithEvents TextBox_CExpiry As TextBox
    Friend WithEvents TextBox_CVV As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents TextBox_Topup As TextBox
    Friend WithEvents Button_Help As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
End Class
