<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AdminForm
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
        Me.components = New System.ComponentModel.Container()
        Me.DataGridView_AdminDisplayUsers = New System.Windows.Forms.DataGridView()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TextBox_SearchUser = New System.Windows.Forms.TextBox()
        Me.Button_Logout = New System.Windows.Forms.Button()
        Me.Button_Quit = New System.Windows.Forms.Button()
        Me.ContextMenuStrip_AdminDisplayAllUsers = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.UserToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.UpgradeUserToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EditUserToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DeleteUserToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DowngradeUserToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Label_AdminLoad = New System.Windows.Forms.Label()
        Me.TextBox_EditUsername = New System.Windows.Forms.TextBox()
        Me.TextBox_EditFirstname = New System.Windows.Forms.TextBox()
        Me.TextBox_EditSurname = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Button_EditUserCancel = New System.Windows.Forms.Button()
        Me.Button_EditUserSave = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TextBox_EditBalance = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.DataGridView_AdminDisplayUsers, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.ContextMenuStrip_AdminDisplayAllUsers.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'DataGridView_AdminDisplayUsers
        '
        Me.DataGridView_AdminDisplayUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView_AdminDisplayUsers.Location = New System.Drawing.Point(4, 37)
        Me.DataGridView_AdminDisplayUsers.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.DataGridView_AdminDisplayUsers.Name = "DataGridView_AdminDisplayUsers"
        Me.DataGridView_AdminDisplayUsers.RowHeadersWidth = 51
        Me.DataGridView_AdminDisplayUsers.Size = New System.Drawing.Size(751, 244)
        Me.DataGridView_AdminDisplayUsers.TabIndex = 0
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.TextBox_SearchUser)
        Me.Panel1.Controls.Add(Me.DataGridView_AdminDisplayUsers)
        Me.Panel1.Location = New System.Drawing.Point(10, 289)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(759, 284)
        Me.Panel1.TabIndex = 2
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(466, 11)
        Me.Label5.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(134, 17)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Search Username : "
        '
        'TextBox_SearchUser
        '
        Me.TextBox_SearchUser.Location = New System.Drawing.Point(618, 9)
        Me.TextBox_SearchUser.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TextBox_SearchUser.Name = "TextBox_SearchUser"
        Me.TextBox_SearchUser.Size = New System.Drawing.Size(132, 22)
        Me.TextBox_SearchUser.TabIndex = 3
        '
        'Button_Logout
        '
        Me.Button_Logout.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.Button_Logout.Location = New System.Drawing.Point(665, 51)
        Me.Button_Logout.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Button_Logout.Name = "Button_Logout"
        Me.Button_Logout.Size = New System.Drawing.Size(100, 28)
        Me.Button_Logout.TabIndex = 6
        Me.Button_Logout.Text = "Logout"
        Me.Button_Logout.UseVisualStyleBackColor = False
        '
        'Button_Quit
        '
        Me.Button_Quit.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.Button_Quit.Location = New System.Drawing.Point(665, 15)
        Me.Button_Quit.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Button_Quit.Name = "Button_Quit"
        Me.Button_Quit.Size = New System.Drawing.Size(100, 28)
        Me.Button_Quit.TabIndex = 7
        Me.Button_Quit.Text = "Quit"
        Me.Button_Quit.UseVisualStyleBackColor = False
        '
        'ContextMenuStrip_AdminDisplayAllUsers
        '
        Me.ContextMenuStrip_AdminDisplayAllUsers.ImageScalingSize = New System.Drawing.Size(28, 28)
        Me.ContextMenuStrip_AdminDisplayAllUsers.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.UserToolStripMenuItem})
        Me.ContextMenuStrip_AdminDisplayAllUsers.Name = "ContextMenuStrip_AdminDisplayAllUsers"
        Me.ContextMenuStrip_AdminDisplayAllUsers.Size = New System.Drawing.Size(108, 28)
        '
        'UserToolStripMenuItem
        '
        Me.UserToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.UpgradeUserToolStripMenuItem, Me.EditUserToolStripMenuItem, Me.DeleteUserToolStripMenuItem, Me.DowngradeUserToolStripMenuItem})
        Me.UserToolStripMenuItem.Name = "UserToolStripMenuItem"
        Me.UserToolStripMenuItem.Size = New System.Drawing.Size(107, 24)
        Me.UserToolStripMenuItem.Text = "User"
        '
        'UpgradeUserToolStripMenuItem
        '
        Me.UpgradeUserToolStripMenuItem.Name = "UpgradeUserToolStripMenuItem"
        Me.UpgradeUserToolStripMenuItem.Size = New System.Drawing.Size(203, 26)
        Me.UpgradeUserToolStripMenuItem.Text = "Upgrade User"
        '
        'EditUserToolStripMenuItem
        '
        Me.EditUserToolStripMenuItem.Name = "EditUserToolStripMenuItem"
        Me.EditUserToolStripMenuItem.Size = New System.Drawing.Size(203, 26)
        Me.EditUserToolStripMenuItem.Text = "Edit User"
        '
        'DeleteUserToolStripMenuItem
        '
        Me.DeleteUserToolStripMenuItem.Name = "DeleteUserToolStripMenuItem"
        Me.DeleteUserToolStripMenuItem.Size = New System.Drawing.Size(203, 26)
        Me.DeleteUserToolStripMenuItem.Text = "Delete User"
        '
        'DowngradeUserToolStripMenuItem
        '
        Me.DowngradeUserToolStripMenuItem.Name = "DowngradeUserToolStripMenuItem"
        Me.DowngradeUserToolStripMenuItem.Size = New System.Drawing.Size(203, 26)
        Me.DowngradeUserToolStripMenuItem.Text = "Downgrade User"
        '
        'Label_AdminLoad
        '
        Me.Label_AdminLoad.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_AdminLoad.Location = New System.Drawing.Point(28, 15)
        Me.Label_AdminLoad.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label_AdminLoad.Name = "Label_AdminLoad"
        Me.Label_AdminLoad.Size = New System.Drawing.Size(619, 45)
        Me.Label_AdminLoad.TabIndex = 8
        Me.Label_AdminLoad.Text = "Label1"
        Me.Label_AdminLoad.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TextBox_EditUsername
        '
        Me.TextBox_EditUsername.Location = New System.Drawing.Point(114, 36)
        Me.TextBox_EditUsername.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TextBox_EditUsername.Name = "TextBox_EditUsername"
        Me.TextBox_EditUsername.Size = New System.Drawing.Size(132, 22)
        Me.TextBox_EditUsername.TabIndex = 9
        '
        'TextBox_EditFirstname
        '
        Me.TextBox_EditFirstname.Location = New System.Drawing.Point(114, 77)
        Me.TextBox_EditFirstname.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TextBox_EditFirstname.Name = "TextBox_EditFirstname"
        Me.TextBox_EditFirstname.Size = New System.Drawing.Size(132, 22)
        Me.TextBox_EditFirstname.TabIndex = 10
        '
        'TextBox_EditSurname
        '
        Me.TextBox_EditSurname.Location = New System.Drawing.Point(114, 117)
        Me.TextBox_EditSurname.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TextBox_EditSurname.Name = "TextBox_EditSurname"
        Me.TextBox_EditSurname.Size = New System.Drawing.Size(132, 22)
        Me.TextBox_EditSurname.TabIndex = 11
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.GroupBox1.Controls.Add(Me.Button_EditUserCancel)
        Me.GroupBox1.Controls.Add(Me.Button_EditUserSave)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.TextBox_EditBalance)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.TextBox_EditUsername)
        Me.GroupBox1.Controls.Add(Me.TextBox_EditSurname)
        Me.GroupBox1.Controls.Add(Me.TextBox_EditFirstname)
        Me.GroupBox1.Location = New System.Drawing.Point(9, 88)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.GroupBox1.Size = New System.Drawing.Size(768, 195)
        Me.GroupBox1.TabIndex = 12
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Edit User:"
        '
        'Button_EditUserCancel
        '
        Me.Button_EditUserCancel.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.Button_EditUserCancel.Location = New System.Drawing.Point(620, 159)
        Me.Button_EditUserCancel.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Button_EditUserCancel.Name = "Button_EditUserCancel"
        Me.Button_EditUserCancel.Size = New System.Drawing.Size(144, 32)
        Me.Button_EditUserCancel.TabIndex = 18
        Me.Button_EditUserCancel.Text = "Cancel"
        Me.Button_EditUserCancel.UseVisualStyleBackColor = False
        '
        'Button_EditUserSave
        '
        Me.Button_EditUserSave.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.Button_EditUserSave.Location = New System.Drawing.Point(620, 123)
        Me.Button_EditUserSave.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Button_EditUserSave.Name = "Button_EditUserSave"
        Me.Button_EditUserSave.Size = New System.Drawing.Size(144, 32)
        Me.Button_EditUserSave.TabIndex = 17
        Me.Button_EditUserSave.Text = "Save"
        Me.Button_EditUserSave.UseVisualStyleBackColor = False
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(265, 36)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(95, 19)
        Me.Label4.TabIndex = 16
        Me.Label4.Text = "Balance :"
        '
        'TextBox_EditBalance
        '
        Me.TextBox_EditBalance.Location = New System.Drawing.Point(367, 36)
        Me.TextBox_EditBalance.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TextBox_EditBalance.Name = "TextBox_EditBalance"
        Me.TextBox_EditBalance.Size = New System.Drawing.Size(132, 22)
        Me.TextBox_EditBalance.TabIndex = 15
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(12, 119)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(95, 19)
        Me.Label3.TabIndex = 14
        Me.Label3.Text = "Surname :"
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(12, 79)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(95, 19)
        Me.Label2.TabIndex = 13
        Me.Label2.Text = "Firstname :"
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(12, 36)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(95, 19)
        Me.Label1.TabIndex = 12
        Me.Label1.Text = "Username :"
        '
        'AdminForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.ClientSize = New System.Drawing.Size(785, 588)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label_AdminLoad)
        Me.Controls.Add(Me.Button_Quit)
        Me.Controls.Add(Me.Button_Logout)
        Me.Controls.Add(Me.Panel1)
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "AdminForm"
        Me.Text = "AdminForm"
        CType(Me.DataGridView_AdminDisplayUsers, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ContextMenuStrip_AdminDisplayAllUsers.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents DataGridView_AdminDisplayUsers As DataGridView
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Button_Logout As Button
    Friend WithEvents Button_Quit As Button
    Friend WithEvents ContextMenuStrip_AdminDisplayAllUsers As ContextMenuStrip
    Friend WithEvents UserToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents UpgradeUserToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EditUserToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DeleteUserToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Label_AdminLoad As Label
    Friend WithEvents DowngradeUserToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TextBox_SearchUser As TextBox
    Friend WithEvents TextBox_EditUsername As TextBox
    Friend WithEvents TextBox_EditFirstname As TextBox
    Friend WithEvents TextBox_EditSurname As TextBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label4 As Label
    Friend WithEvents TextBox_EditBalance As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Button_EditUserCancel As Button
    Friend WithEvents Button_EditUserSave As Button
    Friend WithEvents Label5 As Label
End Class
