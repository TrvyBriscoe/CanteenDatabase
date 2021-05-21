Public Class AdminForm
    Dim SQL As New SQLControl
    Dim loggedinAdmin As userInstance
    Dim val As ValidCredentials
    Dim chosenPriv As String = ""
    Dim cants = "Canteen"
    Private Sub AdminForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'updates the admin datagrid
        updateAdminDG()
    End Sub
    Public Sub loadAdmin(user As userInstance)
        loggedinAdmin = user
        'shows the admins surname and firstname
        Label_AdminLoad.Text = "Welcome Administrator"
        GroupBox1.Hide()
    End Sub
    Public Sub updateAdminDG()
        'loads the records from the tblMainAccount into a datagrid to be viewed
        SQL.loadDataGrid("SELECT Username, FirstName, LastName, ChildFName, Balance, Privilege FROM tblMainAccount", DataGridView_AdminDisplayUsers)
    End Sub
    Public Sub upgradeUser()
        'get chosen username
        Dim chosenUsername As String = DataGridView_AdminDisplayUsers.SelectedRows(0).Cells(0).Value.ToString()

        If loggedinAdmin.getUsername() = chosenUsername Then
            MessageBox.Show("You cannot make changes to your own account", "User Upgrade Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            ' if the privilege is standard the privilege is updated to admin
            SQL.AddParam("@pUsername", chosenUsername)
            SQL.ExecQuery("SELECT Privilege FROM tblMainAccount WHERE Username = @pUsername")
            For Each r In SQL.SQLDS.Tables(0).Rows
                chosenPriv = r("Privilege")
            Next

            If chosenPriv = "Standard" Then ' if the user is standard
                ' updates users privilege to admin
                SQL.AddParam("@pNewPriv", "Admin")
                SQL.AddParam("@pUsername", chosenUsername)
                SQL.UpdateRecord("UPDATE tblMainAccount SET Privilege = @pNewPriv WHERE Username = @pUsername")
                MessageBox.Show("User Upgraded", "User Upgrade", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                updateAdminDG()
            ElseIf chosenPriv = "Canteen" Then
                MsgBox("Cannot Upgrade/Downgrade a Canteen Account")
            Else
                ' does nothing if the user is already an admin
                MessageBox.Show("User is already an admin", "Upgrade User", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        End If
    End Sub

    Public Sub downgradeUser()
        'get chosen username

        Dim chosenUsername As String = DataGridView_AdminDisplayUsers.SelectedRows(0).Cells(0).Value.ToString()
        If loggedinAdmin.getUsername = chosenUsername Then
                'prevents the current logged in user from downgrading themselves
                MessageBox.Show("You cannot make changes to your own account", "User Downgrade Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Else
                ' if the account is an admin downgrades the privilege to standard
                SQL.AddParam("@pUsername", chosenUsername)
                SQL.ExecQuery("SELECT Privilege FROM tblMainAccount WHERE Username = @pUsername")
                For Each r In SQL.SQLDS.Tables(0).Rows
                    chosenPriv = r("Privilege")
                Next

            If chosenPriv = "Admin" Then ' if the user is admin the privilege shown on the database is changed to standard
                ' updates privilege within the database
                SQL.AddParam("@pNewPriv", "Standard")
                SQL.AddParam("@pUsername", chosenUsername)
                SQL.UpdateRecord("UPDATE tblMainAccount SET Privilege = @pNewPriv WHERE Username = @pUsername")
                MessageBox.Show("User Downgraded", "User Downgraded", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                updateAdminDG()
            ElseIf chosenPriv = "Canteen" Then
                MsgBox("Cannot Upgrade/Downgrade a Canteen Account")
            Else
                    ' does nothing if the user is already a standard user
                    MessageBox.Show("User is already standard", "Downgrade User", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            End If

    End Sub

    Public Sub editUser()
        'displays the groupbox ontop of the datagrid
        GroupBox1.Show()
        TextBox_EditUsername.Text = DataGridView_AdminDisplayUsers.SelectedRows(0).Cells(0).Value.ToString()
        TextBox_EditUsername.Enabled = False
        SQL.AddParam("@pUsername", DataGridView_AdminDisplayUsers.SelectedRows(0).Cells(0).Value.ToString())
        SQL.ExecQuery("SELECT Firstname, LastName, Balance FROM tblMainAccount WHERE Username = @pUsername")
        For Each r In SQL.SQLDS.Tables(0).Rows
            'loads the balance, firstname and last name of a user to textboxes ontop of the datagrid
            TextBox_EditBalance.Text = r("Balance")
            TextBox_EditFirstname.Text = r("Firstname")
            TextBox_EditSurname.Text = r("LastName")
        Next
    End Sub

    Public Sub deleteUser()
        ' this will get the username of the user that is selected in the datagridview
        Dim chosenUsername As String = DataGridView_AdminDisplayUsers.SelectedRows(0).Cells(0).Value.ToString()
        If chosenUsername = loggedinAdmin.getUsername() Then
            'prevents a user from deleting themselves
            MessageBox.Show("You cannot delete the user that is logged in", "User Delete Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            SQL.AddParam("@pUsername", chosenUsername)
            SQL.ExecQuery("SELECT Privilege FROM tblMainAccount WHERE Username = @pUsername")
            For Each r In SQL.SQLDS.Tables(0).Rows
                chosenPriv = r("Privilege")
            Next
            If chosenPriv = "Admin" Then
                MsgBox("Cannot Delete Another Admin Account")
                updateAdminDG()
            ElseIf chosenPriv = "Canteen" Then
                MsgBox("Cannot Delete a Canteen Account")
            Else
                'gets the username of a user if they wish to remove themselves from the program
                If MsgBox("Are you sure you want to delete " & DataGridView_AdminDisplayUsers.SelectedRows(0).Cells(2).Value.ToString() & ", " & DataGridView_AdminDisplayUsers.SelectedRows(0).Cells(1).Value.ToString() & "?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                    SQL.AddParam("@pUName", chosenUsername)
                    SQL.UpdateRecord("DELETE FROM tblMainAccount WHERE Username = @pUName")
                    SQL.UpdateRecord("DELETE FROM tblStudent WHERE PUserName = @pUName")
                    MessageBox.Show("User and details have been deleted", "User Deletion", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    updateAdminDG()
                    ' this will delete the chosen users record from the table
                Else
                    ' does nothing
                End If
            End If
        End If
    End Sub


    Private Sub DataGridView_AdminDisplayUsers_MouseClick(sender As Object, e As MouseEventArgs) Handles DataGridView_AdminDisplayUsers.MouseClick
        If e.Button = MouseButtons.Right Then
            If DataGridView_AdminDisplayUsers.SelectedRows.Count > 0 Then
                ' show right click menu with user information options
                ContextMenuStrip_AdminDisplayAllUsers.Show(MousePosition)
            End If
        End If
    End Sub
    Private Sub DeleteUserToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DeleteUserToolStripMenuItem.Click
        deleteUser()
    End Sub
    Private Sub UpgradeUserToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles UpgradeUserToolStripMenuItem.Click
        upgradeUser()
    End Sub

    Private Sub DowngradeUserToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DowngradeUserToolStripMenuItem.Click
        downgradeUser()
    End Sub

    Private Sub Button_EditUserSave_Click(sender As Object, e As EventArgs) Handles Button_EditUserSave.Click
        If TextBox_EditBalance.Text = "" Or TextBox_EditFirstname.Text = "" Or TextBox_EditSurname.Text = "" Then
            'makes sure users enter all the required information
            MessageBox.Show("Please ensure all fields are full", "Edit User Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            SQL.AddParam("@pFirstname", TextBox_EditFirstname.Text)
            SQL.AddParam("@pSurname", TextBox_EditSurname.Text)
            SQL.AddParam("@pBalance", TextBox_EditBalance.Text)
            SQL.AddParam("@pUsername", TextBox_EditUsername.Text)
            'updates the required fields in the database accordingly
            SQL.UpdateRecord("UPDATE tblMainAccount SET Firstname = @pFirstname, LastName = @pSurname, Balance = @pBalance WHERE Username = @pUsername")
            MessageBox.Show("Update Complete", "Update User", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            loggedinAdmin = New userInstance(TextBox_EditUsername.Text)
            loadAdmin(loggedinAdmin)
            updateAdminDG()
            GroupBox1.Hide()
        End If
    End Sub

    Private Sub EditUserToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EditUserToolStripMenuItem.Click
        editUser()
    End Sub

    Private Sub Button_EditUserCancel_Click(sender As Object, e As EventArgs) Handles Button_EditUserCancel.Click
        GroupBox1.Hide()
    End Sub

    Private Sub TextBox_SearchUserUser_TextChanged(sender As Object, e As EventArgs) Handles TextBox_SearchUser.TextChanged
        SQL.AddParam("@pUsername", TextBox_SearchUser.Text)
        SQL.loadDataGrid("SELECT * FROM tblMainAccount WHERE(Username LIKE '%' & @pUsername & '%')", DataGridView_AdminDisplayUsers)
        ' this will return the users which meet the criteria set in the username textbox
    End Sub

    Private Sub Button_Logout_Click(sender As Object, e As EventArgs) Handles Button_Logout.Click
        'logsout of the application
        LoginPage.Show()
        Me.Hide()
    End Sub

    Private Sub Button_Quit_Click(sender As Object, e As EventArgs) Handles Button_Quit.Click
        'quits the applicaition
        If MsgBox("Are you sure you want to Exit? ", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
            Application.Exit()
        End If
    End Sub
End Class