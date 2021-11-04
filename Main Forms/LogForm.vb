Imports System.Data
Imports MySql.Data.MySqlClient
Public Class LogForm
    Public Id, Log_ID, Log_Index, Log_For, Task_ID As String
    Dim Tab1, Tab2 As TabPage
    Public EditMode, NewRecord As Boolean

    Private Sub LogType_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles LogType.SelectionChangeCommitted
        For Each page As TabPage In TabControl.TabPages
            TabControl.TabPages.Remove(page)
        Next page
        If LogType.Text.Contains("Email") Then
            Username.Enabled = True
            TimeStamp.Enabled = True
            Comment.Enabled = True
            TabControl.TabPages.Insert(0, Tab1)
        ElseIf LogType.Text.Contains("Phone") Then
            Username.Enabled = True
            TimeStamp.Enabled = True
            Comment.Enabled = True
            TabControl.TabPages.Insert(0, Tab2)
        Else
            Username.Enabled = False
            TimeStamp.Enabled = False
            Comment.Enabled = False
        End If
    End Sub

    Private Sub LogForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Tab1 = TabControl.TabPages("EmailTab")
        Tab2 = TabControl.TabPages("PhoneTab")
        For Each page As TabPage In TabControl.TabPages
            If Not page.Name = "MainTab" Then
                TabControl.TabPages.Remove(page)
            End If
        Next page
        If NewRecord = True Then
            Me.Text = "New Log - " & Log_ID
            TimeStamp.Value = System.DateTime.Now.ToString("dd/MM/yyyy hh:mm:ss")
            Username.Text = GlobalVars.Username
            NewRecord = True
            EditMode = True
            EditBtn_Click(Nothing, Nothing)
            EditBtn.Visible = False
            DeleteBtn.Visible = False
            CancelBtn.Visible = True
        Else
            Me.Text = "Log - " & Log_ID
            Dim cmd As New MySqlCommand("SELECT * FROM " & GlobalVars.tbl_LOGS & " WHERE LOG_ID = @LOG_ID AND LOG_INDEX = '" & Log_Index & "' ", GlobalVars.cn)
            cmd.Parameters.AddWithValue("@LOG_ID", Log_ID)

            Using dr As MySqlDataReader = cmd.ExecuteReader()
                If dr.Read() Then
                    LogType.Text = dr.Item("LOG_TYPE").ToString
                    Username.Text = dr.Item("USERNAME").ToString
                    TimeStamp.Text = dr.Item("TIMESTAMP").ToString
                    For Each page As TabPage In TabControl.TabPages
                        TabControl.TabPages.Remove(page)
                    Next page
                    If LogType.Text = "Email" Then
                        TabControl.TabPages.Insert(0, Tab1)
                        EmailTo.Text = dr.Item("EMAIL_TO").ToString
                        EmailFrom.Text = dr.Item("EMAIL_FROM").ToString
                    ElseIf LogType.Text = "Phone Call" Then
                        TabControl.TabPages.Insert(0, Tab2)
                        CallTo.Text = dr.Item("CALL_TO").ToString
                        CallFrom.Text = dr.Item("CALL_FROM").ToString
                        VoicemailTo.Text = dr.Item("VOICEMAIL_TO").ToString
                        VoicemailFrom.Text = dr.Item("VOICEMAIL_FROM").ToString
                    End If
                    Task_ID = dr.Item("TASK_ID").ToString
                    Comment.Text = dr.Item("COMMENT").ToString
                End If
            End Using

            cmd = New MySqlCommand("SELECT * FROM " & GlobalVars.tbl_TASKS & " WHERE TASK_ID = @LOG_ID", GlobalVars.cn)
            cmd.Parameters.AddWithValue("@LOG_ID", Log_ID)

            Using dr As MySqlDataReader = cmd.ExecuteReader()
                If dr.Read() Then
                    TaskID.Text = "Task ID: " & dr.Item("TASK_ID").ToString
                    TaskName.Text = "Name: " & dr.Item("TASK_NAME").ToString
                    TaskImportance.Text = "Importance: " & dr.Item("TASK_IMPORTANCE").ToString
                    TaskStatus.Text = "Status: " & dr.Item("TASK_STATUS").ToString
                    TaskDueDate.Text = "Due: " & dr.Item("TASK_DUE").ToString
                    TaskNote.Text = dr.Item("TASK_NOTE").ToString
                    ViewTaskBtn.Enabled = True
                    DismissTaskBtn.Enabled = True
                End If
            End Using
            NewRecord = False
            EditMode = False
            EditBtn_Click(Nothing, Nothing)
        End If
    End Sub

    Private Sub OkBtn_Click(sender As Object, e As EventArgs) Handles OkBtn.Click
        If EditMode = False Then

            If LogType.SelectedIndex < 0 Then
                GoTo Invalid
            ElseIf LogType.SelectedIndex = 0 Then
                If EmailTo.TextLength < 1 And EmailFrom.TextLength < 1 Then
                    GoTo Invalid
                End If
            ElseIf LogType.SelectedIndex = 1 Then
                If CallTo.TextLength < 1 And CallFrom.TextLength < 1 Then
                    GoTo Invalid
                End If
            End If

            GoTo Valid
Invalid:
            MessageBox.Show("You must fill in all required fields before proceeding.", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub
Valid:

            Dim sqlQuery As String = "REPLACE INTO " & GlobalVars.tbl_LOGS & " VALUES (@Id, @Log_ID, @Index, @Username, @Log_For, @LogType, @TimeStamp, @EmailTo, @EmailFrom, @CallTo, @CallFrom, @VoicemailTo, @VoicemailFrom, @Task_ID, @Task_Status, @Comment) "

            EditBtn_Click(Nothing, Nothing)

            Dim cmd As MySqlCommand
            cmd = New MySqlCommand(sqlQuery, GlobalVars.cn)
            cmd.Parameters.AddWithValue("@Id", Id)
            cmd.Parameters.AddWithValue("@Log_ID", Log_ID)
            If NewRecord = False Then
                cmd.Parameters.AddWithValue("@Index", Log_Index)
            Else
                cmd.Parameters.AddWithValue("@Index", 0)
            End If
            cmd.Parameters.AddWithValue("@Username", GlobalVars.Username)
            cmd.Parameters.AddWithValue("@Log_For", Log_For)
            cmd.Parameters.AddWithValue("@LogType", LogType.Text)
            cmd.Parameters.AddWithValue("@TimeStamp", TimeStamp.Value.ToString("yyyy-MM-dd HH:mm:ss"))
            cmd.Parameters.AddWithValue("@EmailTo", EmailTo.Text)
            cmd.Parameters.AddWithValue("@EmailFrom", EmailFrom.Text)
            cmd.Parameters.AddWithValue("@CallTo", CallTo.Text)
            cmd.Parameters.AddWithValue("@CallFrom", CallFrom.Text)
            cmd.Parameters.AddWithValue("@VoicemailTo", VoicemailTo.Text)
            cmd.Parameters.AddWithValue("@VoicemailFrom", VoicemailFrom.Text)
            cmd.Parameters.AddWithValue("@Task_ID", Task_ID)
            Dim strArr() As String = TaskStatus.Text.Split(":")
            cmd.Parameters.AddWithValue("@Task_Status", strArr(1).Trim())
            cmd.Parameters.AddWithValue("@Comment", Comment.Text)
            Try
                cmd.ExecuteNonQuery()
                OkBtn.Text = "OK"
                If NewRecord = True Then
                    Me.DialogResult = Windows.Forms.DialogResult.OK
                    Me.Close()
                End If
            Catch ex As Exception
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        Else
            Me.Close()
        End If
    End Sub

    Private Sub CreateTaskBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CreateTaskBtn.Click
        If String.IsNullOrEmpty(Task_ID) = False Then
            If MessageBox.Show("Are you sure you want to Dismiss this task and create another one?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) = MsgBoxResult.Yes Then
                ViewTaskBtn.Enabled = False
CREATE_TASK:
                TaskForm.Task_ID = Log_ID
                TaskForm.NewRecord = True
                If TaskForm.ShowDialog() = Windows.Forms.DialogResult.OK Then
                    Dim cmd As New MySqlCommand("SELECT * FROM " & GlobalVars.tbl_TASKS & " WHERE TASK_ID = @LOG_ID", GlobalVars.cn)
                    cmd.Parameters.AddWithValue("@LOG_ID", Log_ID)

                    Using dr As MySqlDataReader = cmd.ExecuteReader()
                        If dr.Read() Then
                            TaskID.Text = "Task ID: " & dr.Item("TASK_ID")
                            TaskName.Text = "Name: " & dr.Item("TASK_NAME")
                            TaskImportance.Text = "Importance: " & dr.Item("TASK_IMPORTANCE")
                            TaskStatus.Text = "Status: " & dr.Item("TASK_STATUS")
                            TaskDueDate.Text = "Due: " & dr.Item("TASK_DUE")
                            TaskNote.Text = dr.Item("TASK_NOTE")
                            ViewTaskBtn.Enabled = True
                            DismissTaskBtn.Enabled = True
                        End If
                    End Using
                End If
            End If
        Else : GoTo CREATE_TASK
        End If
    End Sub

    Private Sub ViewTaskBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ViewTaskBtn.Click
        TaskForm.Task_ID = Log_ID
        TaskForm.NewRecord = False
        If TaskForm.ShowDialog() = Windows.Forms.DialogResult.OK Then
            Dim cmd As New MySqlCommand("SELECT * FROM " & GlobalVars.tbl_TASKS & " WHERE TASK_ID = @LOG_ID", GlobalVars.cn)
            cmd.Parameters.AddWithValue("@LOG_ID", Log_ID)

            Using dr As MySqlDataReader = cmd.ExecuteReader()
                If dr.Read() Then
                    TaskID.Text = "Task ID: " & dr.Item("TASK_ID")
                    TaskName.Text = "Name: " & dr.Item("TASK_NAME")
                    TaskImportance.Text = "Importance: " & dr.Item("TASK_IMPORTANCE")
                    TaskStatus.Text = "Status: " & dr.Item("TASK_STATUS")
                    TaskDueDate.Text = "Due: " & dr.Item("TASK_DUE")
                    TaskNote.Text = dr.Item("TASK_NOTE")
                End If
            End Using
        End If
    End Sub

    Private Sub DeleteBtn_Click(sender As Object, e As EventArgs) Handles DeleteBtn.Click
        If SettingsINI.ReadINIValue("Prompts", "AskBeforeDeletingLogs").Equals("Yes") Then
            If MessageBox.Show("Are you sure you want to DELETE this log?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) = MsgBoxResult.No Then
                Exit Sub
            End If
        End If

        Dim sqlQuery As String = "DELETE FROM " & GlobalVars.tbl_LOGS & " WHERE PROPERTY_ID  = '" & Id & "' AND LOG_ID = '" & Log_ID & "' AND LOG_INDEX = '" & Log_Index & "' "
        Dim cmd As MySqlCommand
        cmd = New MySqlCommand(sqlQuery, GlobalVars.cn)
        Try
            cmd.ExecuteNonQuery()
            Me.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub EditBtn_Click(sender As Object, e As EventArgs) Handles EditBtn.Click
        Select Case EditMode
            Case True
                LogType.Enabled = True
                EmailTo.ReadOnly = False
                EmailFrom.ReadOnly = False
                CallTo.ReadOnly = False
                CallFrom.ReadOnly = False
                VoicemailTo.ReadOnly = False
                VoicemailFrom.ReadOnly = False
                Comment.ReadOnly = False
                CreateTaskBtn.Enabled = True
                EditBtn.Text = "Cancel Edit"
                DeleteBtn.Visible = True
                EditMode = False
            Case False
                LogType.Enabled = False
                EmailTo.ReadOnly = True
                EmailFrom.ReadOnly = True
                CallTo.ReadOnly = True
                CallFrom.ReadOnly = True
                VoicemailTo.ReadOnly = True
                VoicemailFrom.ReadOnly = True
                Comment.ReadOnly = True
                CreateTaskBtn.Enabled = False
                EditBtn.Text = "Edit"
                DeleteBtn.Visible = False
                EditMode = True
        End Select
    End Sub

    Private Sub DismissTaskBtn_Click(sender As Object, e As EventArgs) Handles DismissTaskBtn.Click
        If MessageBox.Show("Are you sure you want to DELETE this task?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) = MsgBoxResult.Yes Then
            Dim sqlQuery As String = "DELETE FROM " & GlobalVars.tbl_TASKS & " WHERE TASK_ID  = '" & Task_ID & "' "
            Dim cmd As MySqlCommand
            cmd = New MySqlCommand(sqlQuery, GlobalVars.cn)
            Try
                cmd.ExecuteNonQuery()
                TaskID.Text = "Task ID: N/A"
                TaskName.Text = "Name: N/A"
                TaskImportance.Text = "Importance: N/A"
                TaskStatus.Text = "Status: N/A"
                TaskDueDate.Text = "Due: N/A"
                TaskNote.Text = ""
                DismissTaskBtn.Enabled = False
            Catch ex As Exception
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If
    End Sub
End Class