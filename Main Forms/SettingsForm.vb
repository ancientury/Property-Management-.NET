Imports Microsoft.Win32

Public Class SettingsForm
    Private Tab1, Tab2, Tab3, Tab4 As TabPage
    Private Sub ApplySettings_Click(ByVal sender As Object, ByVal e As EventArgs) Handles ApplySettings.Click
        SettingsINI.WriteINIValue("DB Prefixes", "DB Properties table", S_PropertiesTable.Text)
        SettingsINI.WriteINIValue("DB Prefixes", "DB Primary key", S_PKEY.Text)
        SettingsINI.WriteINIValue("DB Prefixes", "DB Contracts table", S_ContractsTable.Text)
        SettingsINI.WriteINIValue("DB Prefixes", "DB Invoices table", S_InvoicesTable.Text)
        SettingsINI.WriteINIValue("DB Prefixes", "DB Contacts table", S_ContactsTable.Text)
        SettingsINI.WriteINIValue("DB Prefixes", "DB Document table", S_DocTable.Text)
        SettingsINI.WriteINIValue("DB Prefixes", "DB Data table", S_DataTable.Text)
        SettingsINI.WriteINIValue("DB Prefixes", "DB Voice table", S_VoiceTable.Text)
        SettingsINI.WriteINIValue("DB Prefixes", "DB Mobile table", S_MobileTable.Text)
        SettingsINI.WriteINIValue("DB Prefixes", "DB Appliance table", S_ApplianceTable.Text)
        SettingsINI.WriteINIValue("DB Prefixes", "DB Accounts table", S_AccountsTable.Text)
        SettingsINI.WriteINIValue("DB Prefixes", "DB PC table", S_PCTable.Text)
        SettingsINI.WriteINIValue("DB Prefixes", "DB TV table", S_TVTable.Text)
        SettingsINI.WriteINIValue("DB Prefixes", "DB Sky table", S_SkyTable.Text)
        SettingsINI.WriteINIValue("DB Prefixes", "DB DVR/NVR table", S_DVRNVRTable.Text)
        SettingsINI.WriteINIValue("DB Prefixes", "DB Car table", S_CarTable.Text)
        SettingsINI.WriteINIValue("DB Prefixes", "DB Tasks table", S_TasksTable.Text)
        SettingsINI.WriteINIValue("DB Prefixes", "DB Logs table", S_LogsTable.Text)
        SettingsINI.WriteINIValue("DB Prefixes", "DB Maintainence Logs table", S_MLogsTable.Text)
        SettingsINI.WriteINIValue("DB Prefixes", "DB Pictures table", S_PicturesTable.Text)
        SettingsINI.WriteINIValue("DB Prefixes", "DB Landlines table", S_LandlinesTable.Text)

        GlobalVars.PRIMARY_KEY = S_PKEY.Text
        GlobalVars.tbl_PROPERTIES = GlobalVars.DBName & "." & S_PropertiesTable.Text
        GlobalVars.tbl_CONTRACTS = GlobalVars.DBName & "." & S_ContractsTable.Text
        GlobalVars.tbl_CONTACTS = GlobalVars.DBName & "." & S_ContactsTable.Text
        GlobalVars.tbl_INVOICES = GlobalVars.DBName & "." & S_InvoicesTable.Text
        GlobalVars.tbl_DOCS = GlobalVars.DBName & "." & S_DocTable.Text
        GlobalVars.tbl_DATA = GlobalVars.DBName & "." & S_DataTable.Text
        GlobalVars.tbl_VOICE = GlobalVars.DBName & "." & S_VoiceTable.Text
        GlobalVars.tbl_MOBILE = GlobalVars.DBName & "." & S_MobileTable.Text
        GlobalVars.tbl_APPLIANCE = GlobalVars.DBName & "." & S_ApplianceTable.Text
        GlobalVars.tbl_ACCOUNTS = GlobalVars.DBName & "." & S_AccountsTable.Text
        GlobalVars.tbl_PC = GlobalVars.DBName & "." & S_PCTable.Text
        GlobalVars.tbl_TV = GlobalVars.DBName & "." & S_TVTable.Text
        GlobalVars.tbl_SKY = GlobalVars.DBName & "." & S_SkyTable.Text
        GlobalVars.tbl_DVRNVR = GlobalVars.DBName & "." & S_DVRNVRTable.Text
        GlobalVars.tbl_CAR = GlobalVars.DBName & "." & S_CarTable.Text
        GlobalVars.tbl_TASKS = GlobalVars.DBName & "." & S_TasksTable.Text
        GlobalVars.tbl_LOGS = GlobalVars.DBName & "." & S_LogsTable.Text
        GlobalVars.tbl_MLOGS = GlobalVars.DBName & "." & S_MLogsTable.Text
        GlobalVars.tbl_PICTURES = GlobalVars.DBName & "." & S_PicturesTable.Text
        GlobalVars.tbl_LANDLINES = GlobalVars.DBName & "." & S_LandlinesTable.Text

        MessageBox.Show(Me, "Database Settings applied!", "DB Prefixes", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub SettingsForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Tab1 = SettingsTabControl.TabPages("StartupTab")
        Tab2 = SettingsTabControl.TabPages("PromptsTab")
        Tab3 = SettingsTabControl.TabPages("FontsTab")
        Tab4 = SettingsTabControl.TabPages("DBPrefixesTab")

        For Each page As TabPage In SettingsTabControl.TabPages
            If Not page.Name = "MainTab" Then
                SettingsTabControl.TabPages.Remove(page)
            End If
        Next page

        ' DB Prefixes
        S_PKEY.Text = SettingsINI.ReadINIValue("DB Prefixes", "DB Primary key")
        S_PropertiesTable.Text = SettingsINI.ReadINIValue("DB Prefixes", "DB Properties table")
        S_InvoicesTable.Text = SettingsINI.ReadINIValue("DB Prefixes", "DB Invoices table")
        S_ContractsTable.Text = SettingsINI.ReadINIValue("DB Prefixes", "DB Contracts table")
        S_DocTable.Text = SettingsINI.ReadINIValue("DB Prefixes", "DB Document table")
        S_DataTable.Text = SettingsINI.ReadINIValue("DB Prefixes", "DB Data table")
        S_VoiceTable.Text = SettingsINI.ReadINIValue("DB Prefixes", "DB Voice table")
        S_MobileTable.Text = SettingsINI.ReadINIValue("DB Prefixes", "DB Mobile table")
        S_ApplianceTable.Text = SettingsINI.ReadINIValue("DB Prefixes", "DB Appliance table")
        S_AccountsTable.Text = SettingsINI.ReadINIValue("DB Prefixes", "DB Accounts table")
        S_PCTable.Text = SettingsINI.ReadINIValue("DB Prefixes", "DB PC table")
        S_TVTable.Text = SettingsINI.ReadINIValue("DB Prefixes", "DB TV table")
        S_SkyTable.Text = SettingsINI.ReadINIValue("DB Prefixes", "DB Sky table")
        S_DVRNVRTable.Text = SettingsINI.ReadINIValue("DB Prefixes", "DB DVR/NVR table")
        S_CarTable.Text = SettingsINI.ReadINIValue("DB Prefixes", "DB Car table")
        S_ContactsTable.Text = SettingsINI.ReadINIValue("DB Prefixes", "DB Contacts table")
        S_TasksTable.Text = SettingsINI.ReadINIValue("DB Prefixes", "DB Tasks table")
        S_LogsTable.Text = SettingsINI.ReadINIValue("DB Prefixes", "DB Logs table")
        S_MLogsTable.Text = SettingsINI.ReadINIValue("DB Prefixes", "DB Maintainence Logs table")
        S_PicturesTable.Text = SettingsINI.ReadINIValue("DB Prefixes", "DB Pictures table")
        S_LandlinesTable.Text = SettingsINI.ReadINIValue("DB Prefixes", "DB Landlines table")

        ' Startup
        If SettingsINI.ReadINIValue("Startup", "WindowPos").Equals("Normal") Then
            NormalRadioBtn.Checked = True
        ElseIf SettingsINI.ReadINIValue("Startup", "WindowPos").Equals("Hidden") Then
            HiddenRadioBtn.Checked = True
        End If

        If SettingsINI.ReadINIValue("Startup", "LaunchAtStartup").Equals("Yes") Then
            LaunchStartUpCheckBox.CheckState = CheckState.Checked
            If SettingsINI.ReadINIValue("Startup", "AutoLoginAtStartup").Equals("Yes") Then
                AutoLoginCheckbox.CheckState = CheckState.Checked
                UsernameTextBox.Text = SettingsINI.ReadINIValue("Startup", "AutoLoginUsername")
                PasswordTextBox.Text = SettingsINI.ReadINIValue("Startup", "AutoLoginPassword")
            ElseIf SettingsINI.ReadINIValue("Startup", "AutoLoginAtStartup").Equals("No") Then
                AutoLoginCheckbox.CheckState = CheckState.Unchecked
                UsernameTextBox.Text = SettingsINI.ReadINIValue("Startup", "AutoLoginUsername")
                PasswordTextBox.Text = SettingsINI.ReadINIValue("Startup", "AutoLoginPassword")
            End If
        ElseIf SettingsINI.ReadINIValue("Startup", "LaunchAtStartup").Equals("No") Then
            LaunchStartUpCheckBox.CheckState = CheckState.Unchecked
        End If

        ' Prompts
        If SettingsINI.ReadINIValue("Prompts", "AskBeforeDeletingProperties").Equals("Yes") Then
            AskBeforeDeletingProperties.CheckState = CheckState.Checked
        ElseIf SettingsINI.ReadINIValue("Prompts", "AskBeforeDeletingProperties").Equals("No") Then
            AskBeforeDeletingProperties.CheckState = CheckState.Unchecked
        End If
        If SettingsINI.ReadINIValue("Prompts", "AskBeforeModifyingProperties").Equals("Yes") Then
            AskBeforeModifyingProperties.CheckState = CheckState.Checked
        ElseIf SettingsINI.ReadINIValue("Prompts", "AskBeforeModifyingProperties").Equals("No") Then
            AskBeforeModifyingProperties.CheckState = CheckState.Unchecked
        End If

        If SettingsINI.ReadINIValue("Prompts", "AskBeforeDeletingAssets").Equals("Yes") Then
            AskBeforeDeletingAssets.CheckState = CheckState.Checked
        ElseIf SettingsINI.ReadINIValue("Prompts", "AskBeforeDeletingAssets").Equals("No") Then
            AskBeforeDeletingAssets.CheckState = CheckState.Unchecked
        End If
        If SettingsINI.ReadINIValue("Prompts", "AskBeforeModifyingAssets").Equals("Yes") Then
            AskBeforeModifyingAssets.CheckState = CheckState.Checked
        ElseIf SettingsINI.ReadINIValue("Prompts", "AskBeforeModifyingAssets").Equals("No") Then
            AskBeforeModifyingAssets.CheckState = CheckState.Unchecked
        End If

        If SettingsINI.ReadINIValue("Prompts", "AskBeforeDeletingContracts").Equals("Yes") Then
            AskBeforeDeletingContracts.CheckState = CheckState.Checked
        ElseIf SettingsINI.ReadINIValue("Prompts", "AskBeforeDeletingContracts").Equals("No") Then
            AskBeforeDeletingContracts.CheckState = CheckState.Unchecked
        End If
        If SettingsINI.ReadINIValue("Prompts", "AskBeforeModifyingContracts").Equals("Yes") Then
            AskBeforeModifyingContracts.CheckState = CheckState.Checked
        ElseIf SettingsINI.ReadINIValue("Prompts", "AskBeforeModifyingContracts").Equals("No") Then
            AskBeforeModifyingContracts.CheckState = CheckState.Unchecked
        End If

        If SettingsINI.ReadINIValue("Prompts", "AskBeforeDeletingInvoices").Equals("Yes") Then
            AskBeforeDeletingInvoices.CheckState = CheckState.Checked
        ElseIf SettingsINI.ReadINIValue("Prompts", "AskBeforeDeletingInvoices").Equals("No") Then
            AskBeforeDeletingInvoices.CheckState = CheckState.Unchecked
        End If
        If SettingsINI.ReadINIValue("Prompts", "AskBeforeModifyingInvoices").Equals("Yes") Then
            AskBeforeModifyingInvoices.CheckState = CheckState.Checked
        ElseIf SettingsINI.ReadINIValue("Prompts", "AskBeforeModifyingInvoices").Equals("No") Then
            AskBeforeModifyingInvoices.CheckState = CheckState.Unchecked
        End If

        If SettingsINI.ReadINIValue("Prompts", "AskBeforeDeletingLogs").Equals("Yes") Then
            AskBeforeDeletingLogs.CheckState = CheckState.Checked
        ElseIf SettingsINI.ReadINIValue("Prompts", "AskBeforeDeletingLogs").Equals("No") Then
            AskBeforeDeletingLogs.CheckState = CheckState.Unchecked
        End If


        If SettingsINI.ReadINIValue("Prompts", "NotifyReminder").Equals("Yes") Then
            NotifyReminder.CheckState = CheckState.Checked
        ElseIf SettingsINI.ReadINIValue("Prompts", "NotifyReminder").Equals("No") Then
            NotifyReminder.CheckState = CheckState.Unchecked
        End If

        If SettingsINI.ReadINIValue("Prompts", "NotifyUpdate").Equals("Yes") Then
            NotifyUpdate.CheckState = CheckState.Checked
        ElseIf SettingsINI.ReadINIValue("Prompts", "NotifyUpdate").Equals("No") Then
            NotifyUpdate.CheckState = CheckState.Unchecked
        End If


    End Sub

    Private Sub Node1_NodeClick(sender As Object, e As EventArgs) Handles Node1.NodeClick
        For Each page As TabPage In SettingsTabControl.TabPages
            SettingsTabControl.TabPages.Remove(page)
        Next page
        SettingsTabControl.TabPages.Insert(0, Tab1)
    End Sub

    Private Sub Node2_NodeClick(sender As Object, e As EventArgs) Handles Node2.NodeClick
        For Each page As TabPage In SettingsTabControl.TabPages
            SettingsTabControl.TabPages.Remove(page)
        Next page
        SettingsTabControl.TabPages.Insert(0, Tab2)
    End Sub

    Private Sub Node3_NodeClick(sender As Object, e As EventArgs) Handles Node3.NodeClick
        For Each page As TabPage In SettingsTabControl.TabPages
            SettingsTabControl.TabPages.Remove(page)
        Next page
        SettingsTabControl.TabPages.Insert(0, Tab3)
    End Sub

    Private Sub DBPrefixesNode_NodeClick(sender As Object, e As EventArgs) Handles DBPrefixesNode.NodeClick
        For Each page As TabPage In SettingsTabControl.TabPages
            SettingsTabControl.TabPages.Remove(page)
        Next page
        SettingsTabControl.TabPages.Insert(0, Tab4)
    End Sub

    Private Sub NormalRadioBtn_CheckedChanged(sender As Object, e As EventArgs) Handles NormalRadioBtn.CheckedChanged
        If NormalRadioBtn.Checked = True Then
            SettingsINI.WriteINIValue("Startup", "WindowPos", "Normal")
        ElseIf NormalRadioBtn.Checked = False Then
            SettingsINI.WriteINIValue("Startup", "WindowPos", "Hidden")
        End If
    End Sub

    Private Sub LaunchStartUpCheckBox_CheckValueChanged(sender As Object, e As EventArgs) Handles LaunchStartUpCheckBox.CheckValueChanged
        Dim regKey As Microsoft.Win32.RegistryKey
        regKey = Registry.LocalMachine.OpenSubKey("SOFTWARE\Microsoft\Windows\CurrentVersion\Run", True)
        If LaunchStartUpCheckBox.Checked = True Then
            SettingsINI.WriteINIValue("Startup", "LaunchAtStartup", "Yes")
            AutoLoginCheckbox.CheckState = CheckState.Unchecked
            AutoLoginCheckbox.Enabled = True
            regKey.SetValue("Property Management .NET", Application.ExecutablePath)
            regKey.Close()
        ElseIf LaunchStartUpCheckBox.Checked = False Then
            SettingsINI.WriteINIValue("Startup", "LaunchAtStartup", "No")
            AutoLoginCheckbox.CheckState = CheckState.Unchecked
            AutoLoginCheckbox.Enabled = False
            regKey.DeleteValue("Property Management .NET", False)
        End If
    End Sub

    Private Sub AutoLoginCheckbox_CheckValueChanged(sender As Object, e As EventArgs) Handles AutoLoginCheckbox.CheckValueChanged
        If AutoLoginCheckbox.Checked = True Then
            SettingsINI.WriteINIValue("Startup", "AutoLoginAtStartup", "Yes")
            SettingsINI.WriteINIValue("Startup", "AutoLoginUsername", UsernameTextBox.Text)
            SettingsINI.WriteINIValue("Startup", "AutoLoginPassword", PasswordTextBox.Text)
            UsernameTextBox.ReadOnly = False
            PasswordTextBox.ReadOnly = False
            ShowPassCharsCheckbox.Enabled = True
            TestLoginBtn.Enabled = True
        ElseIf AutoLoginCheckbox.Checked = False Then
            SettingsINI.WriteINIValue("Startup", "AutoLoginAtStartup", "No")
            UsernameTextBox.ReadOnly = True
            PasswordTextBox.ReadOnly = True
            ShowPassCharsCheckbox.Enabled = False
            TestLoginBtn.Enabled = False
        End If
    End Sub

    Private Sub AskBeforeDeletingProperties_CheckValueChanged(sender As Object, e As EventArgs) Handles AskBeforeDeletingProperties.CheckValueChanged
        If AskBeforeDeletingProperties.Checked = True Then
            SettingsINI.WriteINIValue("Prompts", "AskBeforeDeletingProperties", "Yes")
        ElseIf AskBeforeDeletingProperties.Checked = False Then
            SettingsINI.WriteINIValue("Prompts", "AskBeforeDeletingProperties", "No")
        End If
    End Sub

    Private Sub AskBeforeDeletingAssets_CheckValueChanged(sender As Object, e As EventArgs) Handles AskBeforeDeletingAssets.CheckValueChanged
        If AskBeforeDeletingAssets.Checked = True Then
            SettingsINI.WriteINIValue("Prompts", "AskBeforeDeletingAssets", "Yes")
        ElseIf AskBeforeDeletingAssets.Checked = False Then
            SettingsINI.WriteINIValue("Prompts", "AskBeforeDeletingAssets", "No")
        End If
    End Sub

    Private Sub AskBeforeDeletingContracts_CheckValueChanged(sender As Object, e As EventArgs) Handles AskBeforeDeletingContracts.CheckValueChanged
        If AskBeforeDeletingContracts.Checked = True Then
            SettingsINI.WriteINIValue("Prompts", "AskBeforeDeletingContracts", "Yes")
        ElseIf AskBeforeDeletingContracts.Checked = False Then
            SettingsINI.WriteINIValue("Prompts", "AskBeforeDeletingContracts", "No")
        End If
    End Sub

    Private Sub AskBeforeDeletingInvoices_CheckValueChanged(sender As Object, e As EventArgs) Handles AskBeforeDeletingInvoices.CheckValueChanged
        If AskBeforeDeletingInvoices.Checked = True Then
            SettingsINI.WriteINIValue("Prompts", "AskBeforeDeletingInvoices", "Yes")
        ElseIf AskBeforeDeletingInvoices.Checked = False Then
            SettingsINI.WriteINIValue("Prompts", "AskBeforeDeletingInvoices", "No")
        End If
    End Sub

    Private Sub AskBeforeDeletingLogs_CheckValueChanged(sender As Object, e As EventArgs) Handles AskBeforeDeletingLogs.CheckValueChanged
        If AskBeforeDeletingLogs.Checked = True Then
            SettingsINI.WriteINIValue("Prompts", "AskBeforeDeletingLogs", "Yes")
        ElseIf AskBeforeDeletingLogs.Checked = False Then
            SettingsINI.WriteINIValue("Prompts", "AskBeforeDeletingLogs", "No")
        End If
    End Sub

    Private Sub NotifyReminder_CheckValueChanged(sender As Object, e As EventArgs) Handles NotifyReminder.CheckValueChanged
        If NotifyReminder.Checked = True Then
            SettingsINI.WriteINIValue("Prompts", "NotifyReminder", "Yes")
        ElseIf NotifyReminder.Checked = False Then
            SettingsINI.WriteINIValue("Prompts", "NotifyReminder", "No")
        End If
    End Sub

    Private Sub NotifyUpdate_CheckValueChanged(sender As Object, e As EventArgs) Handles NotifyUpdate.CheckValueChanged
        If NotifyUpdate.Checked = True Then
            SettingsINI.WriteINIValue("Prompts", "NotifyUpdate", "Yes")
        ElseIf NotifyUpdate.Checked = False Then
            SettingsINI.WriteINIValue("Prompts", "NotifyUpdate", "No")
        End If
    End Sub

    Private Sub AskBeforeModifyingProperties_CheckValueChanged(sender As Object, e As EventArgs) Handles AskBeforeModifyingProperties.CheckValueChanged
        If AskBeforeModifyingProperties.Checked = True Then
            SettingsINI.WriteINIValue("Prompts", "AskBeforeModifyingProperties", "Yes")
        ElseIf AskBeforeModifyingProperties.Checked = False Then
            SettingsINI.WriteINIValue("Prompts", "AskBeforeModifyingProperties", "No")
        End If
    End Sub

    Private Sub AskBeforeModifyingAssets_CheckValueChanged(sender As Object, e As EventArgs) Handles AskBeforeModifyingAssets.CheckValueChanged
        If AskBeforeModifyingAssets.Checked = True Then
            SettingsINI.WriteINIValue("Prompts", "AskBeforeModifyingAssets", "Yes")
        ElseIf AskBeforeModifyingAssets.Checked = False Then
            SettingsINI.WriteINIValue("Prompts", "AskBeforeModifyingAssets", "No")
        End If
    End Sub

    Private Sub AskBeforeModifyingContracts_CheckValueChanged(sender As Object, e As EventArgs) Handles AskBeforeModifyingContracts.CheckValueChanged
        If AskBeforeModifyingContracts.Checked = True Then
            SettingsINI.WriteINIValue("Prompts", "AskBeforeModifyingContracts", "Yes")
        ElseIf AskBeforeModifyingContracts.Checked = False Then
            SettingsINI.WriteINIValue("Prompts", "AskBeforeModifyingContracts", "No")
        End If
    End Sub

    Private Sub AskBeforeModifyingInvoices_CheckValueChanged(sender As Object, e As EventArgs) Handles AskBeforeModifyingInvoices.CheckValueChanged
        If AskBeforeModifyingInvoices.Checked = True Then
            SettingsINI.WriteINIValue("Prompts", "AskBeforeModifyingInvoices", "Yes")
        ElseIf AskBeforeModifyingInvoices.Checked = False Then
            SettingsINI.WriteINIValue("Prompts", "AskBeforeModifyingInvoices", "No")
        End If
    End Sub
End Class