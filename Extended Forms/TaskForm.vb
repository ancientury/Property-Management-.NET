Imports MySql.Data.MySqlClient

Public Class TaskForm
    Public Task_ID As String
    Public EditMode, NewRecord As Boolean
    Private Sub OkBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OkBtn.Click
        If EditMode = False Then
            If TaskName.TextLength < 1 Then
                GoTo Invalid
            End If
            If TaskStatus.SelectedIndex < 0 Then
                GoTo Invalid
            End If
            If TaskImportance.SelectedIndex < 0 Then
                GoTo Invalid
            End If
            If TaskDueDate.CustomFormat.Equals(" ") Then
                GoTo Invalid
            End If

            GoTo Valid

Invalid:
            MessageBox.Show("You must fill in all required fields before proceeding.", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub

Valid:
            EditBtn_Click(Nothing, Nothing)
            Dim sdObj = CDate(DateTime.Now)
            Dim edObj = CDate(TaskDueDate.Value)
            Dim sd, ed As String

            sd = Format(sdObj, "yyyy-MM-dd HH:mm")
            ed = Format(edObj, "yyyy-MM-dd HH:mm")

            Dim TaskReminder As String
            If ReminderCheckBox.CheckState = CheckState.Checked Then
                TaskReminder = "Yes"
            Else
                TaskReminder = "No"
            End If

            Dim sqlQuery As String = "REPLACE INTO " & GlobalVars.tbl_TASKS & " VALUES(@Task_ID, @Username, @TaskName, @TaskStatus, @TaskImportance, @CreatedDate, @DueDate, @TaskReminder, @RemindBeforeDays, @TaskNote) "

            Dim cmd As MySqlCommand
            cmd = New MySqlCommand(sqlQuery, GlobalVars.cn)
            cmd.Parameters.AddWithValue("@Task_ID", Task_ID)
            cmd.Parameters.AddWithValue("@Username", GlobalVars.Username)
            cmd.Parameters.AddWithValue("@TaskName", TaskName.Text)
            cmd.Parameters.AddWithValue("@TaskStatus", TaskStatus.Text)
            cmd.Parameters.AddWithValue("@TaskImportance", TaskImportance.Text)
            cmd.Parameters.AddWithValue("@CreatedDate", sd)
            cmd.Parameters.AddWithValue("@DueDate", ed)
            cmd.Parameters.AddWithValue("@TaskReminder", TaskReminder)
            cmd.Parameters.AddWithValue("@RemindBeforeDays", TaskReminder_Days.Text & " days")
            cmd.Parameters.AddWithValue("@TaskNote", TaskNote.Text)
            Try
                cmd.ExecuteNonQuery()
                OkBtn.Text = "OK"
                Me.DialogResult = Windows.Forms.DialogResult.OK
                If NewRecord = True Then
                    Me.Close()
                End If
            Catch ex As Exception
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        Else
            Me.Close()
        End If
    End Sub

    Private Sub AddTaskForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If NewRecord = True Then
            If String.IsNullOrEmpty(Task_ID) = True Then
                Task_ID = GlobalVars.randomID()
            End If

            TaskId.Text = "Task ID: " & Task_ID
            EditMode = True
            EditBtn_Click(Nothing, Nothing)
            DeleteBtn.Visible = False
            EditBtn.Visible = False
            CancelBtn.Visible = True
        Else
            Me.Text = "Task - " & Task_ID
            Dim cmd As New MySqlCommand("SELECT * FROM " & GlobalVars.tbl_TASKS & " WHERE TASK_ID = @TASK_ID", GlobalVars.cn)
            cmd.Parameters.AddWithValue("@TASK_ID", Task_ID)

            Using dr As MySqlDataReader = cmd.ExecuteReader()
                If dr.Read() Then
                    TaskId.Text = "Task ID: " & dr.Item("TASK_ID")
                    TaskName.Text = dr.Item("TASK_NAME")
                    TaskImportance.Text = dr.Item("TASK_IMPORTANCE")
                    TaskStatus.Text = dr.Item("TASK_STATUS")
                    TaskCreatedDate.Text = dr.Item("TASK_CREATED")
                    TaskDueDate.Text = dr.Item("TASK_DUE")
                    If dr.Item("TASK_REMINDER") = "Yes" Then
                        ReminderCheckBox.CheckState = CheckState.Checked
                    Else
                        ReminderCheckBox.CheckState = CheckState.Unchecked
                    End If
                    Dim strArr() As String = dr.Item("TASK_REMINDERDAYS").ToString.Split(" ")
                    TaskReminder_Days.Text = strArr(0)
                    TaskNote.Text = dr.Item("TASK_NOTE")
                End If
            End Using
            EditMode = False
            EditBtn_Click(Nothing, Nothing)
            EditBtn.Visible = True
            CancelBtn.Visible = False
        End If
    End Sub

    Private Sub EditBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EditBtn.Click
        Select Case EditMode
            Case True
                TaskName.ReadOnly = False
                TaskImportance.Enabled = True
                TaskStatus.Enabled = True
                TaskDueDate.Enabled = True
                TaskReminder_Days.ReadOnly = False
                TaskNote.ReadOnly = False
                ReminderCheckBox.Enabled = True
                DeleteBtn.Visible = True
                EditMode = False
                EditBtn.Text = "Cancel Edit"
            Case False
                TaskName.ReadOnly = True
                TaskImportance.Enabled = False
                TaskStatus.Enabled = False
                TaskDueDate.Enabled = False
                TaskReminder_Days.ReadOnly = True
                TaskNote.ReadOnly = True
                ReminderCheckBox.Enabled = False
                DeleteBtn.Visible = False
                EditMode = True
                EditBtn.Text = "Edit"
        End Select
    End Sub

    Private Sub DeleteBtn_Click(sender As Object, e As EventArgs) Handles DeleteBtn.Click
        If MessageBox.Show("Are you sure you want to DELETE this task?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) = MsgBoxResult.Yes Then
            Dim sqlQuery As String = "DELETE FROM " & GlobalVars.tbl_TASKS & " WHERE TASK_ID = '" & Task_ID & "' "
            Dim cmd As MySqlCommand
            cmd = New MySqlCommand(sqlQuery, GlobalVars.cn)
            Try
                cmd.ExecuteNonQuery()
                Me.Close()
            Catch ex As Exception
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If
    End Sub

    Private Sub TaskStatus_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles TaskStatus.SelectionChangeCommitted
        If TaskStatus.SelectedIndex = 1 Then
            If MessageBox.Show("Are you sure you want to mark this task as 'Completed'. If you mark this task as 'Completed' you will not be reminded about it in the future.", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) = MsgBoxResult.Yes Then
                ReminderCheckBox.CheckState = CheckState.Unchecked
                ReminderCheckBox.Enabled = False
            End If
        End If
    End Sub

    Private Sub TaskDueDate_ValueChanged(sender As Object, e As EventArgs) Handles TaskDueDate.ValueChanged
        TaskDueDate.CustomFormat = "dd/MM/yyyy HH:mm"
    End Sub

    Private Sub Reminder_Days_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TaskReminder_Days.KeyPress
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub ReminderCheckBox_CheckStateChanged(sender As Object, e As EventArgs) Handles ReminderCheckBox.CheckStateChanged
        If ReminderCheckBox.Checked Then
            RemindMeLabel.Enabled = True
            TaskReminder_Days.Enabled = True
        Else
            RemindMeLabel.Enabled = False
            TaskReminder_Days.Enabled = False
        End If
    End Sub
End Class