<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CanteenMenuChoice
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
        Me.Label_Waffle = New System.Windows.Forms.Label()
        Me.Button_Brekky = New System.Windows.Forms.Button()
        Me.Button_Lunch = New System.Windows.Forms.Button()
        Me.Button_Quit = New System.Windows.Forms.Button()
        Me.Button_LogO = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label_Waffle
        '
        Me.Label_Waffle.AutoSize = True
        Me.Label_Waffle.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_Waffle.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.Label_Waffle.Location = New System.Drawing.Point(59, 99)
        Me.Label_Waffle.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label_Waffle.Name = "Label_Waffle"
        Me.Label_Waffle.Size = New System.Drawing.Size(349, 24)
        Me.Label_Waffle.TabIndex = 0
        Me.Label_Waffle.Text = "Select the Menu that you wish to access:"
        '
        'Button_Brekky
        '
        Me.Button_Brekky.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.Button_Brekky.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.Button_Brekky.Location = New System.Drawing.Point(47, 162)
        Me.Button_Brekky.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Button_Brekky.Name = "Button_Brekky"
        Me.Button_Brekky.Size = New System.Drawing.Size(159, 142)
        Me.Button_Brekky.TabIndex = 1
        Me.Button_Brekky.Text = "Breakfast Menu: Accessed from 9:40 to 10:40"
        Me.Button_Brekky.UseVisualStyleBackColor = False
        '
        'Button_Lunch
        '
        Me.Button_Lunch.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.Button_Lunch.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.Button_Lunch.Location = New System.Drawing.Point(249, 162)
        Me.Button_Lunch.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Button_Lunch.Name = "Button_Lunch"
        Me.Button_Lunch.Size = New System.Drawing.Size(159, 142)
        Me.Button_Lunch.TabIndex = 3
        Me.Button_Lunch.Text = "Lunch Menu: Accessed from 13:00 to 13:40"
        Me.Button_Lunch.UseVisualStyleBackColor = False
        '
        'Button_Quit
        '
        Me.Button_Quit.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.Button_Quit.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.Button_Quit.Location = New System.Drawing.Point(393, 13)
        Me.Button_Quit.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Button_Quit.Name = "Button_Quit"
        Me.Button_Quit.Size = New System.Drawing.Size(69, 28)
        Me.Button_Quit.TabIndex = 4
        Me.Button_Quit.Text = "Quit"
        Me.Button_Quit.UseVisualStyleBackColor = False
        '
        'Button_LogO
        '
        Me.Button_LogO.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.Button_LogO.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.Button_LogO.Location = New System.Drawing.Point(393, 49)
        Me.Button_LogO.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Button_LogO.Name = "Button_LogO"
        Me.Button_LogO.Size = New System.Drawing.Size(68, 28)
        Me.Button_LogO.TabIndex = 5
        Me.Button_LogO.Text = "Logout"
        Me.Button_LogO.UseVisualStyleBackColor = False
        '
        'CanteenMenuChoice
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.ClientSize = New System.Drawing.Size(487, 372)
        Me.Controls.Add(Me.Button_LogO)
        Me.Controls.Add(Me.Button_Quit)
        Me.Controls.Add(Me.Button_Lunch)
        Me.Controls.Add(Me.Button_Brekky)
        Me.Controls.Add(Me.Label_Waffle)
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "CanteenMenuChoice"
        Me.Text = "CanteenMenuChoice"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label_Waffle As Label
    Friend WithEvents Button_Brekky As Button
    Friend WithEvents Button_Lunch As Button
    Friend WithEvents Button_Quit As Button
    Friend WithEvents Button_LogO As Button
End Class
