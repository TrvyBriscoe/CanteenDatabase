<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MainAccount
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainAccount))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label_Balance = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label_Tiempo = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label_DisplayHP = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Button_Logout = New System.Windows.Forms.Button()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.ComboBox_Child = New System.Windows.Forms.ComboBox()
        Me.Label_Diet = New System.Windows.Forms.Label()
        Me.Label_Lunch = New System.Windows.Forms.Label()
        Me.Label_Breakfast = New System.Windows.Forms.Label()
        Me.LabelLunchIntro = New System.Windows.Forms.Label()
        Me.Label_BreakIntro = New System.Windows.Forms.Label()
        Me.Label_ChildIntro = New System.Windows.Forms.Label()
        Me.Tab_Settings = New System.Windows.Forms.TabPage()
        Me.Panel_Allowance = New System.Windows.Forms.Panel()
        Me.Button_RemoveAllowance = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Button_UpdateAllowance = New System.Windows.Forms.Button()
        Me.TextBox_Allowance = New System.Windows.Forms.TextBox()
        Me.Label_Allowance = New System.Windows.Forms.Label()
        Me.Button_ChangeP = New System.Windows.Forms.Button()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.Button_AddFunds = New System.Windows.Forms.Button()
        Me.Label_Wass = New System.Windows.Forms.Label()
        Me.DatabaseNEADataSetBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.GroupBox1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.Tab_Settings.SuspendLayout()
        Me.Panel_Allowance.SuspendLayout()
        Me.TabPage3.SuspendLayout()
        CType(Me.DatabaseNEADataSetBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(138, 19)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(65, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Label1"
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.GroupBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label_Balance)
        Me.GroupBox1.Controls.Add(Me.Button1)
        Me.GroupBox1.Controls.Add(Me.Label_Tiempo)
        Me.GroupBox1.Controls.Add(Me.PictureBox1)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(-2, -4)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Size = New System.Drawing.Size(634, 105)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = " "
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(139, 56)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(262, 16)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Your current balance is displayed below:"
        '
        'Label_Balance
        '
        Me.Label_Balance.AutoSize = True
        Me.Label_Balance.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_Balance.Location = New System.Drawing.Point(446, 53)
        Me.Label_Balance.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label_Balance.Name = "Label_Balance"
        Me.Label_Balance.Size = New System.Drawing.Size(59, 20)
        Me.Label_Balance.TabIndex = 3
        Me.Label_Balance.Text = "Label2"
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Button1.Location = New System.Drawing.Point(536, 16)
        Me.Button1.Margin = New System.Windows.Forms.Padding(4)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(85, 28)
        Me.Button1.TabIndex = 2
        Me.Button1.Text = "Exit "
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Label_Tiempo
        '
        Me.Label_Tiempo.AutoSize = True
        Me.Label_Tiempo.Location = New System.Drawing.Point(449, 9)
        Me.Label_Tiempo.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label_Tiempo.Name = "Label_Tiempo"
        Me.Label_Tiempo.Size = New System.Drawing.Size(64, 16)
        Me.Label_Tiempo.TabIndex = 2
        Me.Label_Tiempo.Text = "00:00:00"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(15, 16)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(74, 77)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 1
        Me.PictureBox1.TabStop = False
        '
        'Label_DisplayHP
        '
        Me.Label_DisplayHP.AutoSize = True
        Me.Label_DisplayHP.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_DisplayHP.Location = New System.Drawing.Point(440, 17)
        Me.Label_DisplayHP.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label_DisplayHP.Name = "Label_DisplayHP"
        Me.Label_DisplayHP.Size = New System.Drawing.Size(51, 18)
        Me.Label_DisplayHP.TabIndex = 5
        Me.Label_DisplayHP.Text = "Label2"
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        '
        'Button_Logout
        '
        Me.Button_Logout.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Button_Logout.Location = New System.Drawing.Point(531, 55)
        Me.Button_Logout.Margin = New System.Windows.Forms.Padding(4)
        Me.Button_Logout.Name = "Button_Logout"
        Me.Button_Logout.Size = New System.Drawing.Size(88, 28)
        Me.Button_Logout.TabIndex = 4
        Me.Button_Logout.Text = "Logout"
        Me.Button_Logout.UseVisualStyleBackColor = False
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.Tab_Settings)
        Me.TabControl1.Controls.Add(Me.TabPage3)
        Me.TabControl1.Location = New System.Drawing.Point(3, 124)
        Me.TabControl1.Margin = New System.Windows.Forms.Padding(4)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(630, 323)
        Me.TabControl1.TabIndex = 5
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.Label4)
        Me.TabPage1.Controls.Add(Me.ComboBox_Child)
        Me.TabPage1.Controls.Add(Me.Label_DisplayHP)
        Me.TabPage1.Controls.Add(Me.Label_Diet)
        Me.TabPage1.Controls.Add(Me.Label_Lunch)
        Me.TabPage1.Controls.Add(Me.Label_Breakfast)
        Me.TabPage1.Controls.Add(Me.LabelLunchIntro)
        Me.TabPage1.Controls.Add(Me.Label_BreakIntro)
        Me.TabPage1.Controls.Add(Me.Label_ChildIntro)
        Me.TabPage1.Location = New System.Drawing.Point(4, 25)
        Me.TabPage1.Margin = New System.Windows.Forms.Padding(4)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(4)
        Me.TabPage1.Size = New System.Drawing.Size(622, 294)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Your Child"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(25, 17)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(350, 16)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Please select your child's ID from the dropdown below:"
        '
        'ComboBox_Child
        '
        Me.ComboBox_Child.FormattingEnabled = True
        Me.ComboBox_Child.Location = New System.Drawing.Point(28, 36)
        Me.ComboBox_Child.Name = "ComboBox_Child"
        Me.ComboBox_Child.Size = New System.Drawing.Size(92, 24)
        Me.ComboBox_Child.TabIndex = 7
        '
        'Label_Diet
        '
        Me.Label_Diet.AutoSize = True
        Me.Label_Diet.Location = New System.Drawing.Point(25, 264)
        Me.Label_Diet.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label_Diet.Name = "Label_Diet"
        Me.Label_Diet.Size = New System.Drawing.Size(51, 16)
        Me.Label_Diet.TabIndex = 6
        Me.Label_Diet.Text = "Label4"
        '
        'Label_Lunch
        '
        Me.Label_Lunch.AutoSize = True
        Me.Label_Lunch.Location = New System.Drawing.Point(25, 220)
        Me.Label_Lunch.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label_Lunch.Name = "Label_Lunch"
        Me.Label_Lunch.Size = New System.Drawing.Size(51, 16)
        Me.Label_Lunch.TabIndex = 5
        Me.Label_Lunch.Text = "Label4"
        '
        'Label_Breakfast
        '
        Me.Label_Breakfast.AutoSize = True
        Me.Label_Breakfast.Location = New System.Drawing.Point(25, 137)
        Me.Label_Breakfast.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label_Breakfast.Name = "Label_Breakfast"
        Me.Label_Breakfast.Size = New System.Drawing.Size(51, 16)
        Me.Label_Breakfast.TabIndex = 4
        Me.Label_Breakfast.Text = "Label4"
        '
        'LabelLunchIntro
        '
        Me.LabelLunchIntro.AutoSize = True
        Me.LabelLunchIntro.Location = New System.Drawing.Point(25, 176)
        Me.LabelLunchIntro.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LabelLunchIntro.Name = "LabelLunchIntro"
        Me.LabelLunchIntro.Size = New System.Drawing.Size(51, 16)
        Me.LabelLunchIntro.TabIndex = 3
        Me.LabelLunchIntro.Text = "Label4"
        '
        'Label_BreakIntro
        '
        Me.Label_BreakIntro.AutoSize = True
        Me.Label_BreakIntro.Location = New System.Drawing.Point(25, 110)
        Me.Label_BreakIntro.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label_BreakIntro.Name = "Label_BreakIntro"
        Me.Label_BreakIntro.Size = New System.Drawing.Size(51, 16)
        Me.Label_BreakIntro.TabIndex = 2
        Me.Label_BreakIntro.Text = "Label4"
        '
        'Label_ChildIntro
        '
        Me.Label_ChildIntro.AutoSize = True
        Me.Label_ChildIntro.Location = New System.Drawing.Point(25, 79)
        Me.Label_ChildIntro.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label_ChildIntro.Name = "Label_ChildIntro"
        Me.Label_ChildIntro.Size = New System.Drawing.Size(51, 16)
        Me.Label_ChildIntro.TabIndex = 1
        Me.Label_ChildIntro.Text = "Label4"
        '
        'Tab_Settings
        '
        Me.Tab_Settings.Controls.Add(Me.Panel_Allowance)
        Me.Tab_Settings.Controls.Add(Me.Button_ChangeP)
        Me.Tab_Settings.Location = New System.Drawing.Point(4, 25)
        Me.Tab_Settings.Margin = New System.Windows.Forms.Padding(4)
        Me.Tab_Settings.Name = "Tab_Settings"
        Me.Tab_Settings.Padding = New System.Windows.Forms.Padding(4)
        Me.Tab_Settings.Size = New System.Drawing.Size(622, 294)
        Me.Tab_Settings.TabIndex = 1
        Me.Tab_Settings.Text = "Settings"
        Me.Tab_Settings.UseVisualStyleBackColor = True
        '
        'Panel_Allowance
        '
        Me.Panel_Allowance.Controls.Add(Me.Button_RemoveAllowance)
        Me.Panel_Allowance.Controls.Add(Me.Label3)
        Me.Panel_Allowance.Controls.Add(Me.Button_UpdateAllowance)
        Me.Panel_Allowance.Controls.Add(Me.TextBox_Allowance)
        Me.Panel_Allowance.Controls.Add(Me.Label_Allowance)
        Me.Panel_Allowance.Location = New System.Drawing.Point(143, 7)
        Me.Panel_Allowance.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel_Allowance.Name = "Panel_Allowance"
        Me.Panel_Allowance.Size = New System.Drawing.Size(448, 277)
        Me.Panel_Allowance.TabIndex = 0
        '
        'Button_RemoveAllowance
        '
        Me.Button_RemoveAllowance.Location = New System.Drawing.Point(155, 201)
        Me.Button_RemoveAllowance.Margin = New System.Windows.Forms.Padding(4)
        Me.Button_RemoveAllowance.Name = "Button_RemoveAllowance"
        Me.Button_RemoveAllowance.Size = New System.Drawing.Size(88, 48)
        Me.Button_RemoveAllowance.TabIndex = 4
        Me.Button_RemoveAllowance.Text = "Save Changes"
        Me.Button_RemoveAllowance.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(53, 167)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(339, 16)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "To remove the spending limit press the button below:" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'Button_UpdateAllowance
        '
        Me.Button_UpdateAllowance.Location = New System.Drawing.Point(157, 100)
        Me.Button_UpdateAllowance.Margin = New System.Windows.Forms.Padding(4)
        Me.Button_UpdateAllowance.Name = "Button_UpdateAllowance"
        Me.Button_UpdateAllowance.Size = New System.Drawing.Size(88, 47)
        Me.Button_UpdateAllowance.TabIndex = 2
        Me.Button_UpdateAllowance.Text = "Save Changes"
        Me.Button_UpdateAllowance.UseVisualStyleBackColor = True
        '
        'TextBox_Allowance
        '
        Me.TextBox_Allowance.Location = New System.Drawing.Point(127, 68)
        Me.TextBox_Allowance.Margin = New System.Windows.Forms.Padding(4)
        Me.TextBox_Allowance.Name = "TextBox_Allowance"
        Me.TextBox_Allowance.Size = New System.Drawing.Size(140, 22)
        Me.TextBox_Allowance.TabIndex = 1
        '
        'Label_Allowance
        '
        Me.Label_Allowance.AutoSize = True
        Me.Label_Allowance.Location = New System.Drawing.Point(15, 29)
        Me.Label_Allowance.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label_Allowance.Name = "Label_Allowance"
        Me.Label_Allowance.Size = New System.Drawing.Size(458, 16)
        Me.Label_Allowance.TabIndex = 0
        Me.Label_Allowance.Text = "To create a spending limit please enter the amount in the textbox below:"
        '
        'Button_ChangeP
        '
        Me.Button_ChangeP.Location = New System.Drawing.Point(24, 107)
        Me.Button_ChangeP.Margin = New System.Windows.Forms.Padding(4)
        Me.Button_ChangeP.Name = "Button_ChangeP"
        Me.Button_ChangeP.Size = New System.Drawing.Size(88, 52)
        Me.Button_ChangeP.TabIndex = 0
        Me.Button_ChangeP.Text = "Change Password" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.Button_ChangeP.UseVisualStyleBackColor = True
        '
        'TabPage3
        '
        Me.TabPage3.Controls.Add(Me.Button_AddFunds)
        Me.TabPage3.Controls.Add(Me.Label_Wass)
        Me.TabPage3.Location = New System.Drawing.Point(4, 25)
        Me.TabPage3.Margin = New System.Windows.Forms.Padding(4)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Padding = New System.Windows.Forms.Padding(4)
        Me.TabPage3.Size = New System.Drawing.Size(622, 294)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "Add Funds"
        Me.TabPage3.UseVisualStyleBackColor = True
        '
        'Button_AddFunds
        '
        Me.Button_AddFunds.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Button_AddFunds.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Button_AddFunds.Location = New System.Drawing.Point(228, 78)
        Me.Button_AddFunds.Margin = New System.Windows.Forms.Padding(4)
        Me.Button_AddFunds.Name = "Button_AddFunds"
        Me.Button_AddFunds.Size = New System.Drawing.Size(135, 70)
        Me.Button_AddFunds.TabIndex = 2
        Me.Button_AddFunds.Text = "Top Up Account"
        Me.Button_AddFunds.UseVisualStyleBackColor = False
        '
        'Label_Wass
        '
        Me.Label_Wass.AutoSize = True
        Me.Label_Wass.Location = New System.Drawing.Point(186, 42)
        Me.Label_Wass.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label_Wass.Name = "Label_Wass"
        Me.Label_Wass.Size = New System.Drawing.Size(198, 16)
        Me.Label_Wass.TabIndex = 0
        Me.Label_Wass.Text = "Top Up using the button below"
        '
        'MainAccount
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.ClientSize = New System.Drawing.Size(633, 451)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.Button_Logout)
        Me.Controls.Add(Me.GroupBox1)
        Me.Font = New System.Drawing.Font("Arial", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "MainAccount"
        Me.Text = "MainAccount"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.Tab_Settings.ResumeLayout(False)
        Me.Panel_Allowance.ResumeLayout(False)
        Me.Panel_Allowance.PerformLayout()
        Me.TabPage3.ResumeLayout(False)
        Me.TabPage3.PerformLayout()
        CType(Me.DatabaseNEADataSetBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Label_Tiempo As Label
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Label_Balance As Label
    Friend WithEvents Button_Logout As Button
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents Tab_Settings As TabPage
    Friend WithEvents TabPage3 As TabPage
    Friend WithEvents Label_Wass As Label
    Friend WithEvents Button_AddFunds As Button
    Friend WithEvents DatabaseNEADataSetBindingSource As BindingSource

    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Button_ChangeP As Button
    Friend WithEvents Panel_Allowance As Panel
    Friend WithEvents Button_RemoveAllowance As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents Button_UpdateAllowance As Button
    Friend WithEvents TextBox_Allowance As TextBox
    Friend WithEvents Label_Allowance As Label
    Friend WithEvents Label_ChildIntro As Label
    Friend WithEvents Label_BreakIntro As Label
    Friend WithEvents Label_Lunch As Label
    Friend WithEvents Label_Breakfast As Label
    Friend WithEvents LabelLunchIntro As Label
    Friend WithEvents Label_Diet As Label
    Friend WithEvents Label_DisplayHP As Label
    Friend WithEvents ComboBox_Child As ComboBox
    Friend WithEvents Label4 As Label
End Class
