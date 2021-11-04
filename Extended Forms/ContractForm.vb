Imports System.Data
Imports MySql.Data.MySqlClient
Imports System.Threading
Public Class ContractForm
    Public Id, Address, Company, Contract_ID, Reminder_ID As String
    Public EditMode, NewRecord, ViewContract As Boolean
    Dim Tab1, Tab2, Tab3 As TabPage
    Private LogsThread As Thread

    Private Sub ReadLogs()
        LogsThread = New Thread(AddressOf sqlLogs_Thread)
        LogsThread.IsBackground = True
        LogsThread.Start()
    End Sub

    Private Sub sqlLogs_Thread()
        ReadLogsData()
    End Sub

    Private Sub ReadLogsData()
        If Me.InvokeRequired Then
            Me.Invoke(New MethodInvoker(AddressOf ReadLogsData))
        Else
            ' Read Logs
            Dim sqlQuery As String = "SELECT LOG_ID, LOG_INDEX, LOG_TYPE, USERNAME, TIMESTAMP, COMMENT, TASK_STATUS FROM " & GlobalVars.tbl_LOGS & " WHERE PROPERTY_ID  = '" & Id & "' AND " & "LOG_FOR = 'Contract' AND LOG_ID = '" & Contract_ID & "' "
            Dim da As New MySqlDataAdapter(sqlQuery, GlobalVars.cn)
            Dim ds As New DataSet()

            Try
                da.Fill(ds)
                Dim dt As New DataTable("Logs")
                da.Fill(dt)
                dt.Columns("LOG_ID").ColumnName = "Log ID"
                dt.Columns("LOG_INDEX").ColumnName = "Log Number"
                dt.Columns("LOG_TYPE").ColumnName = "Log Type"
                dt.Columns("USERNAME").ColumnName = "Username"
                dt.Columns("TIMESTAMP").ColumnName = "Timestamp"
                dt.Columns("COMMENT").ColumnName = "Comment"
                dt.Columns("TASK_STATUS").ColumnName = "Task Status"
                LogsGrid.DataSource = dt
            Catch ex As Exception
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If
    End Sub

    Private Sub OkBtn_Click(sender As Object, e As EventArgs) Handles OkBtn.Click
        If EditMode = False Then

            If NewRecord = False And SettingsINI.ReadINIValue("Prompts", "AskBeforeModifyingContracts").Equals("Yes") Then
                If MessageBox.Show("Are you sure you want to modify this contract?.", "Prompt", MessageBoxButtons.YesNo, MessageBoxIcon.Information) = Windows.Forms.DialogResult.No Then
                    Exit Sub
                End If
            End If

            If ContractType.SelectedIndex < 0 Then
                GoTo Invalid
            End If
            If ContractCompany.TextLength < 1 Then
                GoTo Invalid
            End If
            If PaymentType.SelectedIndex < 0 Then
                GoTo Invalid
            End If
            If ContractLength.SelectedIndex < 0 Then
                GoTo Invalid
            End If
            If PaymentMethod.SelectedIndex < 0 Then
                GoTo Invalid
            End If

            GoTo Valid

Invalid:
            MessageBox.Show("You must fill in all required fields before proceeding.", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub

Valid:
            EditBtn_Click(Nothing, Nothing)
            Dim sdObj = CDate(StartDate.Value)
            Dim edObj = CDate(EndDate.Value)
            Dim sd, ed As String

            sd = Format(sdObj, "yyyyMMdd")
            ed = Format(edObj, "yyyyMMdd")

            Dim sqlQuery As String = "REPLACE INTO " & GlobalVars.tbl_CONTRACTS & " VALUES(@Id, @Contract_ID, @Username, @ContractType, @ContractCompany, @ContractLength, @SDate, @EDate, @AccountNumber, @SecurityAnswer, @AccountHolder, @AccountHolderAddress, @Mobile_Network, @Mobile_Number, @Mobile_Plan, @Landline_Number, @Landline_Provider, @Landline_Service_Plan, @Broadband_Landline_Contract, @Broadband_Provider, @Broadband_Service_Plan, @PaymentType, @PaymentMethod, @ContractFee, @Reminder_ID) "

            Dim cmd As MySqlCommand
            cmd = New MySqlCommand(sqlQuery, GlobalVars.cn)
            cmd.Parameters.AddWithValue("@Id", Id)
            cmd.Parameters.AddWithValue("@Contract_ID", Contract_ID)
            cmd.Parameters.AddWithValue("@Username", GlobalVars.Username)
            cmd.Parameters.AddWithValue("@ContractType", ContractType.Text)
            cmd.Parameters.AddWithValue("@ContractCompany", ContractCompany.Text)
            cmd.Parameters.AddWithValue("@ContractLength", ContractLength.Text)
            cmd.Parameters.AddWithValue("@SDate", sd)
            cmd.Parameters.AddWithValue("@EDate", ed)
            cmd.Parameters.AddWithValue("@AccountNumber", AccountNumber.Text)
            cmd.Parameters.AddWithValue("@SecurityAnswer", SecurityAnswer.Text)
            cmd.Parameters.AddWithValue("@AccountHolder", AccountHolder.Text)
            cmd.Parameters.AddWithValue("@AccountHolderAddress", AccountHolderAddress.Text)
            cmd.Parameters.AddWithValue("@Mobile_Network", Mobile_Network.Text)
            cmd.Parameters.AddWithValue("@Mobile_Number", Mobile_Number.Text)
            cmd.Parameters.AddWithValue("@Mobile_Plan", Mobile_Plan.Text)
            cmd.Parameters.AddWithValue("@Landline_Number", Landline_Number.Text)
            cmd.Parameters.AddWithValue("@Landline_Provider", Landline_Provider.Text)
            cmd.Parameters.AddWithValue("@Landline_Service_Plan", Landline_Service_Plan.Text)
            cmd.Parameters.AddWithValue("@Broadband_Landline_Contract", Broadband_Landline_Contract.Text)
            cmd.Parameters.AddWithValue("@Broadband_Provider", Broadband_Provider.Text)
            cmd.Parameters.AddWithValue("@Broadband_Service_Plan", Broadband_Service_Plan.Text)
            cmd.Parameters.AddWithValue("@PaymentType", PaymentType.Text)
            cmd.Parameters.AddWithValue("@PaymentMethod", PaymentMethod.Text)
            cmd.Parameters.AddWithValue("@ContractFee", ContractFee.Value)
            cmd.Parameters.AddWithValue("@Reminder_ID", Reminder_ID)
            Try
                cmd.ExecuteNonQuery()

                    Try
                        sqlQuery = "REPLACE INTO " & GlobalVars.tbl_TASKS & " VALUES(@Task_ID, @Username, @TaskName, @TaskStatus, @TaskImportance, @CreatedDate, @DueDate, @TaskReminder, @RemindBeforeDays, @TaskNote) "

                        cmd = New MySqlCommand(sqlQuery, GlobalVars.cn)
                        cmd.Parameters.AddWithValue("@Task_ID", Reminder_ID)
                        cmd.Parameters.AddWithValue("@Username", GlobalVars.Username)
                        cmd.Parameters.AddWithValue("@TaskName", ContractCompany.Text & " Contract")
                        cmd.Parameters.AddWithValue("@TaskStatus", "Pending")
                        cmd.Parameters.AddWithValue("@TaskImportance", "Important")
                        cmd.Parameters.AddWithValue("@CreatedDate", sd)
                    cmd.Parameters.AddWithValue("@DueDate", ed)
                    If Reminder_CheckBox.Checked Then
                        cmd.Parameters.AddWithValue("@TaskReminder", "Yes")
                    Else
                        cmd.Parameters.AddWithValue("@TaskReminder", "No")
                    End If
                    cmd.Parameters.AddWithValue("@RemindBeforeDays", Reminder_Days.Text & " days")
                    cmd.Parameters.AddWithValue("@TaskNote", "Contract with " & ContractCompany.Text & " reminder!" & vbNewLine & "Start date: " & sd & vbNewLine & "Expiry date: " & ed)
                Catch ex As Exception
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End Try


                OkBtn.Text = "OK"
                If NewRecord = True Then
                    Using _comm As New MySqlCommand()
                        With _comm
                            .Connection = GlobalVars.cn
                            .CommandText = "UPDATE " & GlobalVars.tbl_PROPERTIES & " SET TOTAL_CONTRACTS = TOTAL_CONTRACTS+1 WHERE PROPERTY_ID = '" & Id & "' "
                        End With
                        _comm.ExecuteNonQuery()
                    End Using
                    Me.Close()
                End If
            Catch ex As Exception
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
            DetailsForm.ReadContracts()
        Else
            Me.Close()
        End If
    End Sub

    Private Sub ContractForm_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load

        Tab1 = TabControl.TabPages("MobileTab")
        Tab2 = TabControl.TabPages("LandlineTab")
        Tab3 = TabControl.TabPages("BroadbandTab")

        For Each page As TabPage In TabControl.TabPages
            If Not page.Name = "MainTab" Then
                TabControl.TabPages.Remove(page)
            End If
        Next page

        If NewRecord = False Then
            Me.Text = "Contract - " & Contract_ID
            Header.Text = Company & vbNewLine & Address & vbNewLine & "Property ID: " & Id
            Dim cmd As New MySqlCommand("Select * From " & GlobalVars.tbl_CONTRACTS & " WHERE CONTRACT_ID = @CONTRACT_ID", GlobalVars.cn)
            cmd.Parameters.AddWithValue("@CONTRACT_ID", Contract_ID)

            Using dr As MySqlDataReader = cmd.ExecuteReader()
                If dr.Read() Then
                    ContractType.Text = dr.Item("CONTRACT_TYPE").ToString
                    ContractCompany.Text = dr.Item("CONTRACT_NAME").ToString
                    ContractLength.Text = dr.Item("CONTRACT_LENGTH").ToString
                    StartDate.Text = dr.Item("START_DATE").ToString
                    EndDate.Text = dr.Item("END_DATE").ToString
                    AccountNumber.Text = dr.Item("ACCOUNT_NUMBER").ToString
                    SecurityAnswer.Text = dr.Item("SECURITY_ANSWER").ToString
                    AccountHolder.Text = dr.Item("ACCOUNT_HOLDER").ToString
                    AccountHolderAddress.Text = dr.Item("ACCOUNT_HOLDER_ADDRESS").ToString
                    PaymentType.Text = dr.Item("PAYMENT_TYPE").ToString
                    PaymentMethod.Text = dr.Item("PAYMENT_METHOD").ToString
                    ContractFee.Text = dr.Item("CONTRACT_FEE").ToString
                    For Each page As TabPage In TabControl.TabPages
                        TabControl.TabPages.Remove(page)
                    Next page
                    If String.Equals(ContractType.Text, "Mobile") Then
                        TabControl.TabPages.Insert(0, Tab1)
                        Mobile_Network.Text = dr.Item("M_SERVICE_PROVIDER").ToString
                        Mobile_Number.Text = dr.Item("M_PHONE_NUMBER").ToString
                        Mobile_Plan.Text = dr.Item("M_SERVICE_PLAN").ToString
                    ElseIf String.Equals(ContractType.Text, "Landline") Then
                        TabControl.TabPages.Insert(0, Tab2)
                        Landline_Number.Text = dr.Item("L_LANDLINE_NUMBER").ToString
                        Landline_Provider.Text = dr.Item("L_SERVICE_PROVIDER").ToString
                        Landline_Service_Plan.Text = dr.Item("L_SERVICE_PLAN").ToString
                    ElseIf String.Equals(ContractType.Text, "Broadband") Then
                        TabControl.TabPages.Insert(0, Tab3)
                        Broadband_Landline_Contract.Text = dr.Item("B_LANDLINE").ToString
                        Broadband_Provider.Text = dr.Item("B_SERVICE_PROVIDER").ToString
                        Broadband_Service_Plan.Text = dr.Item("B_SERVICE_PLAN").ToString
                    End If
                    Reminder_ID = dr.Item("REMINDER_ID")
                End If
            End Using

            NewRecord = False
            EditMode = False
            EditBtn_Click(Nothing, Nothing)

            ReadLogs()

        ElseIf NewRecord = True Then
            Contract_ID = GlobalVars.randomID()
            Reminder_ID = GlobalVars.randomID()
            Header.Text = Company & vbNewLine & Address & vbNewLine & "Property ID: " & Id
            Me.Text = "New Contract - " & Contract_ID
            ContractType.Enabled = True
            StartDate.Value = System.DateTime.Now.ToString("yyyy/MM/dd")
            EndDate.Value = System.DateTime.Now.ToString("yyyy/MM/dd")
            NewRecord = True
            EditMode = True
            EditBtn_Click(Nothing, Nothing)
            EditBtn.Visible = False
            CancelBtn.Visible = True
        End If
    End Sub

    Private Sub ContractFee_KeyPress(sender As Object, e As KeyPressEventArgs)
        If Char.IsControl(e.KeyChar) = False Then
            If Char.IsDigit(e.KeyChar) Or e.KeyChar = "." Then
                If ContractFee.Text.Contains(".") Then
                    If ContractFee.Text.Split(".")(1).Length < 2 Then
                        If Char.IsDigit(e.KeyChar) = False Then
                            e.Handled = True
                        End If
                    Else
                        e.Handled = True
                    End If
                End If
            Else
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub ContactTelephone_KeyPress(sender As Object, e As KeyPressEventArgs)
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub ReminderDays_KeyPress(sender As Object, e As KeyPressEventArgs)
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub EditBtn_Click(sender As Object, e As EventArgs) Handles EditBtn.Click
        Select Case EditMode
            Case True
                ContractLength.Enabled = True
                StartDate.Enabled = True
                EndDate.Enabled = True
                ContractCompany.ReadOnly = False
                PaymentType.Enabled = True
                PaymentMethod.Enabled = True
                ContractFee.ReadOnly = False
                AccountNumber.ReadOnly = False
                SecurityAnswer.ReadOnly = False
                AccountHolder.ReadOnly = False
                AccountHolderAddress.ReadOnly = False
                Mobile_Network.Enabled = True
                Mobile_Plan.ReadOnly = False
                Mobile_Number.ReadOnly = False
                Landline_Provider.Enabled = True
                Landline_Service_Plan.ReadOnly = False
                Broadband_Provider.Enabled = True
                Broadband_Service_Plan.ReadOnly = False
                LinkLandlineBtn.Enabled = True
                DeleteBtn.Visible = True
                DeleteLogBtn.Visible = True
                EditBtn.Text = "Cancel Changes"
                OkBtn.Text = "Save Changes"
                EditMode = False
            Case False
                ContractType.Enabled = False
                ContractCompany.ReadOnly = True
                ContractLength.Enabled = False
                StartDate.Enabled = False
                EndDate.Enabled = False
                PaymentType.Enabled = False
                PaymentMethod.Enabled = False
                ContractFee.ReadOnly = True
                AccountNumber.ReadOnly = True
                SecurityAnswer.ReadOnly = True
                AccountHolder.ReadOnly = True
                AccountHolderAddress.ReadOnly = True
                Mobile_Network.Enabled = False
                Mobile_Plan.ReadOnly = True
                Mobile_Number.ReadOnly = True
                Landline_Provider.Enabled = False
                Landline_Service_Plan.ReadOnly = True
                Broadband_Provider.Enabled = False
                Broadband_Service_Plan.ReadOnly = True
                LinkLandlineBtn.Enabled = False
                DeleteBtn.Visible = False
                DeleteLogBtn.Visible = False
                EditBtn.Text = "Edit"
                OkBtn.Text = "OK"
                EditMode = True
        End Select
    End Sub

    Private Sub CancelBtn_Click(sender As Object, e As EventArgs) Handles CancelBtn.Click
        Me.Close()
    End Sub


    Private Sub ReminderDays_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub ContractType_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles ContractType.SelectionChangeCommitted
        For Each page As TabPage In TabControl.TabPages
            TabControl.TabPages.Remove(page)
        Next page
        If ContractType.Text.Contains("Mobile") Then
            TabControl.TabPages.Insert(0, Tab1)
            ContractCompany.Enabled = True
            ContractLength.Enabled = True
            StartDate.Enabled = True
            EndDate.Enabled = True
            AccountNumber.ReadOnly = False
            SecurityAnswer.ReadOnly = False
            AccountHolder.ReadOnly = False
            PaymentType.Enabled = True
            PaymentMethod.Enabled = True
            ContractFee.Enabled = True
            Log_Box.Enabled = True
            TabControl.Visible = True
        ElseIf ContractType.Text.Contains("Landline") Then
            TabControl.TabPages.Insert(0, Tab2)
            ContractCompany.Enabled = True
            ContractLength.Enabled = True
            StartDate.Enabled = True
            EndDate.Enabled = True
            AccountNumber.ReadOnly = False
            SecurityAnswer.ReadOnly = False
            AccountHolder.ReadOnly = False
            PaymentType.Enabled = True
            PaymentMethod.Enabled = True
            ContractFee.Enabled = True
            Log_Box.Enabled = True
            TabControl.Visible = True
        ElseIf ContractType.Text.Contains("Broadband") Then
            TabControl.TabPages.Insert(0, Tab3)
            ContractCompany.Enabled = True
            ContractLength.Enabled = True
            StartDate.Enabled = True
            EndDate.Enabled = True
            AccountNumber.ReadOnly = False
            SecurityAnswer.ReadOnly = False
            AccountHolder.ReadOnly = False
            PaymentType.Enabled = True
            PaymentMethod.Enabled = True
            ContractFee.Enabled = True
            Log_Box.Enabled = True
            TabControl.Visible = True
        ElseIf String.Equals(ContractType.Text, "") = False Then
            ContractCompany.Enabled = True
            ContractLength.Enabled = True
            StartDate.Enabled = True
            EndDate.Enabled = True
            AccountNumber.ReadOnly = False
            SecurityAnswer.ReadOnly = False
            AccountHolder.ReadOnly = False
            PaymentType.Enabled = True
            PaymentMethod.Enabled = True
            ContractFee.Enabled = True
            Log_Box.Enabled = True
            TabControl.Visible = False
        Else
            ContractCompany.Enabled = False
            ContractLength.Enabled = False
            StartDate.Enabled = False
            EndDate.Enabled = False
            AccountNumber.ReadOnly = True
            SecurityAnswer.ReadOnly = True
            AccountHolder.ReadOnly = True
            PaymentType.Enabled = False
            PaymentMethod.Enabled = False
            ContractFee.Enabled = False
            Log_Box.Enabled = False
            TabControl.Visible = False
        End If
    End Sub

    Private Sub AddLogBtn_Click(ByVal sender As Object, ByVal e As EventArgs) Handles AddLogBtn.Click
        Dim NewLogForm As New LogForm
        NewLogForm.Id = Id
        NewLogForm.Log_ID = Contract_ID
        NewLogForm.Log_For = "Contract"
        NewLogForm.NewRecord = True
        If NewLogForm.ShowDialog() = Windows.Forms.DialogResult.OK Then
            ReadLogs()
        End If
    End Sub

    Private Sub DeleteBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DeleteBtn.Click
        If SettingsINI.ReadINIValue("Prompts", "AskBeforeDeletingContracts").Equals("Yes") Then
            If MessageBox.Show("Are you sure you want to DELETE this contract from this property?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) = MsgBoxResult.No Then
                Exit Sub
            End If
        End If

        Dim sqlQuery As String = "DELETE FROM " & GlobalVars.tbl_CONTRACTS & " WHERE PROPERTY_ID  = '" & Id & "' AND CONTRACT_ID = '" & Contract_ID & "'"
        Dim cmd As MySqlCommand
        cmd = New MySqlCommand(sqlQuery, GlobalVars.cn)
        Try
            cmd.ExecuteNonQuery()
            Using _comm As New MySqlCommand()
                With _comm
                    .Connection = GlobalVars.cn
                    .CommandText = "UPDATE " & GlobalVars.tbl_PROPERTIES & " SET TOTAL_CONTRACTS = TOTAL_CONTRACTS-1 WHERE PROPERTY_ID = '" & Id & "' "
                End With
                _comm.ExecuteNonQuery()
            End Using
            Me.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub Landline_LinkBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Landline_LinkBtn.Click
        If EditMode = True Then
            LinkContractForm.Id = Id
            If LinkContractForm.ShowDialog() = Windows.Forms.DialogResult.OK Then
                Landline_Number.Text = LinkContractForm.ContractsGrid.CurrentRow.Cells.Item(1).Value & " - " & LinkContractForm.ContractsGrid.CurrentRow.Cells.Item(0).Value
            End If
        Else
            Dim form As New ContractForm
            Dim strArr() As String = Landline_Number.Text.Split("-")
            If GlobalVars.isOpen("Contract - " & strArr(1).Trim()) = False Then
                form.Company = Company
                form.Id = Id
                form.Contract_ID = strArr(1).Trim()
                form.ViewContract = True
                form.MdiParent = ParentMdiForm
                form.Show()
            End If
        End If
    End Sub

    Private Sub DeleteLogBtn_Click(sender As Object, e As EventArgs) Handles DeleteLogBtn.Click
        If MessageBox.Show("Are you sure you want to DELETE this log from this contract?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) = MsgBoxResult.Yes Then
            Dim sqlQuery As String = "DELETE FROM " & GlobalVars.tbl_LOGS & " WHERE PROPERTY_ID  = '" & Id & "' AND LOG_INDEX = '" & LogsGrid.CurrentRow.Cells.Item(1).Value.ToString & "' AND LOG_ID = '" & Contract_ID & "' AND LOG_FOR = 'Contract' "
            Dim cmd As MySqlCommand
            cmd = New MySqlCommand(sqlQuery, GlobalVars.cn)
            Try
                cmd.ExecuteNonQuery()
                ReadLogs()
            Catch ex As Exception
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If
    End Sub

    Private Sub LogsGrid_CellMouseDoubleClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles LogsGrid.CellMouseDoubleClick
        If GlobalVars.isOpen("Log - " & LogsGrid.CurrentRow.Cells.Item(0).Value.ToString) = False Then
            Dim NewLogForm As New LogForm
            NewLogForm.Id = Id
            NewLogForm.Log_ID = LogsGrid.CurrentRow.Cells.Item(0).Value.ToString
            NewLogForm.Log_Index = LogsGrid.CurrentRow.Cells.Item(1).Value.ToString
            NewLogForm.Log_For = "Contract"
            NewLogForm.MdiParent = ParentMdiForm
            NewLogForm.Show()
        End If
    End Sub

    Private Sub ContractLength_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles ContractLength.SelectionChangeCommitted, StartDate.ValueChanged
        If ContractLength.SelectedIndex = 0 Then
            EndDate.Value = StartDate.Value
            EndDate.Value = EndDate.Value.AddMonths(1)
        ElseIf ContractLength.SelectedIndex = 1 Then
            EndDate.Value = StartDate.Value
            EndDate.Value = EndDate.Value.AddMonths(3)
        ElseIf ContractLength.SelectedIndex = 2 Then
            EndDate.Value = StartDate.Value
            EndDate.Value = EndDate.Value.AddMonths(6)
        ElseIf ContractLength.SelectedIndex = 3 Then
            EndDate.Value = StartDate.Value
            EndDate.Value = EndDate.Value.AddMonths(12)
        ElseIf ContractLength.SelectedIndex = 4 Then
            EndDate.Value = StartDate.Value
            EndDate.Value = EndDate.Value.AddMonths(18)
        ElseIf ContractLength.SelectedIndex = 5 Then
            EndDate.Value = StartDate.Value
            EndDate.Value = EndDate.Value.AddMonths(24)
        ElseIf ContractLength.SelectedIndex = 6 Then
            EndDate.Value = StartDate.Value
            Try
                EndDate.Value = EndDate.Value.AddMonths(Convert.ToInt32(InputBox("Enter the number of months in the field below.", "Contract Length", "1")))
            Catch ex As Exception
                MsgBox("Only numbers are allowed!", MsgBoxStyle.Exclamation, "Error")
            End Try
            If EndDate.Value.Equals(StartDate.Value) Then
                ContractLength.SelectedIndex = -1
            End If
        End If
    End Sub

    Private Sub Reminder_Days_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Reminder_Days.KeyPress
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub Mobile_Number_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Mobile_Number.KeyPress
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub LogsGrid_RowsAdded(sender As Object, e As DataGridViewRowsAddedEventArgs) Handles LogsGrid.RowsAdded
        DeleteLogBtn.Enabled = True
    End Sub
End Class