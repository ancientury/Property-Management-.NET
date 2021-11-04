Imports DevComponents.Schedule.Model
Imports System.Threading
Imports MySql.Data.MySqlClient

Public Class TasksForm

    Dim numReminders As Integer = 0
    Public _Model As New CalendarModel()
    Private TasksThread, RemindersThread As Thread
    Private reminderDone, keepInvisible, tasksMapped As Boolean
    Public firstStart As Boolean = True

    Public Sub New()

        ' This call is required by the Windows Form Designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        keepInvisible = True
        MonthCombo.SelectedIndex = Calendar.MonthView.StartDate.Month - 1
        YearCombo.Text = Calendar.MonthView.StartDate.Year.ToString
        Calendar.CalendarModel = _Model
        ReadTasks()
        TasksTimer.Interval = 5000
        TasksTimer.Enabled = True
    End Sub

    Protected Overrides Sub SetVisibleCore(ByVal value As Boolean)
        If keepInvisible Then
            MyBase.SetVisibleCore(False)
        Else
            MyBase.SetVisibleCore(value)
        End If
    End Sub

    Private Sub ShowReminders()
        RemindersThread = New Thread(AddressOf Reminders_Thread)
        RemindersThread.IsBackground = True
        RemindersThread.Start()
    End Sub

    Public Sub ReadTasks()
        TasksThread = New Thread(AddressOf sqlTasks_Thread)
        TasksThread.IsBackground = True
        TasksThread.Start()
    End Sub

    Private Sub Reminders_Thread()
        ShowNumberReminders()
    End Sub

    Private Sub sqlTasks_Thread()
        ReadTasksData()
    End Sub

    Private Sub ShowNumberReminders()
        If Me.InvokeRequired Then
            Me.Invoke(New MethodInvoker(AddressOf ShowNumberReminders))
        Else
            Try
                If numReminders > 0 Then
                    TasksTimer.Interval = 10000
                    ParentMdiForm.SysTrayIcon.Visible = True
                    ParentMdiForm.SysTrayIcon.ShowBalloonTip(10000, "Reminders", numReminders.ToString & " reminder(s) are overdue. Click here for more details.", ToolTipIcon.Info)
                End If
            Catch ex As Exception
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If
    End Sub

    Private Sub ReadTasksData()
        If Me.InvokeRequired Then
            Me.Invoke(New MethodInvoker(AddressOf ReadTasksData))
        Else
            ' Read Tasks
            Dim sqlQuery As String = "SELECT TASK_ID, USERNAME, TASK_NAME, TASK_STATUS, TASK_IMPORTANCE, TASK_CREATED, TASK_DUE, TASK_REMINDER, TASK_REMINDERDAYS, TASK_NOTE FROM " & GlobalVars.tbl_TASKS & " "
            Dim da As New MySqlDataAdapter(sqlQuery, GlobalVars.cn)
            Dim ds As New DataSet()

            Try
                da.Fill(ds)
                Dim dt As New DataTable("Tasks")
                da.Fill(dt)
                dt.Columns("TASK_ID").ColumnName = "ID"
                dt.Columns("USERNAME").ColumnName = "Username"
                dt.Columns("TASK_NAME").ColumnName = "Subject"
                dt.Columns("TASK_STATUS").ColumnName = "Status"
                dt.Columns("TASK_IMPORTANCE").ColumnName = "Importance"
                dt.Columns("TASK_CREATED").ColumnName = "Date Created"
                dt.Columns("TASK_DUE").ColumnName = "Due date"
                dt.Columns("TASK_REMINDER").ColumnName = "Reminder"
                dt.Columns("TASK_REMINDERDAYS").ColumnName = "Remind before"
                dt.Columns("TASK_NOTE").ColumnName = "Note"
                TasksGrid.DataSource = dt
                numReminders = 0
                _Model.Appointments.Clear()

                For i = 0 To TasksGrid.RowCount - 1 Step 1
                    Dim task As New Appointment()
                    task.Subject = TasksGrid.Rows(i).Cells(2).Value.ToString & " - " & TasksGrid.Rows(i).Cells(0).Value.ToString
                    task.Description = TasksGrid.Rows(i).Cells(8).Value.ToString
                    task.StartTime = TasksGrid.Rows(i).Cells(6).Value
                    If TasksGrid.Rows(i).Cells(7).Value.ToString.Equals("Yes") = True And TasksGrid.Rows(i).Cells(3).Value.ToString.Equals("Completed") = False And TasksGrid.Rows(i).Cells(3).Value.ToString.Equals("Dismissed") = False Then
                        Dim strArr() As String = TasksGrid.Rows(i).Cells(8).Value.ToString.Split(" ")
                        task.Reminders.Add(New Reminder(task.StartTime.AddDays(-CInt(strArr(0)))))
                        task.StartTimeAction = eStartTimeAction.StartTimeReachedEvent
                    End If
                    task.EndTime = task.StartTime.AddHours(4)
                    If TasksGrid.Rows(i).Cells(4).Value.ToString.Equals("Important") And TasksGrid.Rows(i).Cells(3).Value.ToString.Equals("Completed") = False And TasksGrid.Rows(i).Cells(3).Value.ToString.Equals("Dismissed") = False Then
                        task.CategoryColor = Appointment.CategoryRed
                    ElseIf TasksGrid.Rows(i).Cells(3).Value.ToString.Equals("Completed") = False And TasksGrid.Rows(i).Cells(3).Value.ToString.Equals("Dismissed") = False Then
                        task.CategoryColor = Appointment.CategoryGreen
                    Else
                        task.CategoryColor = "#DDDDDDDD"
                    End If
                    task.TimeMarkedAs = Appointment.TimerMarkerTentative
                    task.Locked = True
                    task.DisplayTemplate =
                        "<font size=""+2"" color=""#006EFF"">[StartDate]</font><br/><br/>" & _
                        "<font color=""#00AD20""><b>[Subject]</b></font><br/>" & _
                        "<b>[Description]</b>"
                    _Model.Appointments.Add(task)
                Next
            Catch ex As Exception
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If
    End Sub

    Private Sub DayBtn_Click(sender As Object, e As EventArgs) Handles DayBtn.Click
        Calendar.SelectedView = DevComponents.DotNetBar.Schedule.eCalendarView.Day
    End Sub

    Private Sub WeekBtn_Click(sender As Object, e As EventArgs) Handles WeekBtn.Click
        Calendar.SelectedView = DevComponents.DotNetBar.Schedule.eCalendarView.Week
    End Sub

    Private Sub MonthBtn_Click(sender As Object, e As EventArgs) Handles MonthBtn.Click
        Calendar.SelectedView = DevComponents.DotNetBar.Schedule.eCalendarView.Month
    End Sub

    Private Sub YearBtn_Click(sender As Object, e As EventArgs) Handles YearBtn.Click
        Calendar.SelectedView = DevComponents.DotNetBar.Schedule.eCalendarView.Year
    End Sub

    Private Sub TodayBtn_Click(sender As Object, e As EventArgs) Handles TodayBtn.Click
        Calendar.ShowDate(Date.Today)
    End Sub

    Private Sub SwitchListBtn_ValueChanged(sender As Object, e As EventArgs) Handles SwitchListBtn.ValueChanged
        If SwitchListBtn.Value = True Then
            TasksGrid.Visible = False
            EditTaskBtn.Enabled = False
            DeleteTaskBtn.Enabled = False
            Calendar.Location = New Point(0, 50)
            Calendar.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Bottom Or AnchorStyles.Right
            Calendar.Size = New Point(Me.Width - 17, Navigator.Location.Y - 70)
        Else
            TasksGrid.Visible = True
            EditTaskBtn.Enabled = True
            DeleteTaskBtn.Enabled = True
            Calendar.Location = New Point(0, TasksGrid.Location.Y + TasksGrid.Size.Height + 10)
            Calendar.Anchor = AnchorStyles.Left Or AnchorStyles.Bottom Or AnchorStyles.Right
            Calendar.Size = New Point(Me.Width - 17, Calendar.Height - TasksGrid.Height)
        End If
    End Sub

    Private Sub AddTaskBtn_Click(sender As Object, e As EventArgs) Handles AddTaskBtn.Click
        Dim NewTaskForm As New TaskForm
        NewTaskForm.NewRecord = True
        If NewTaskForm.ShowDialog() = Windows.Forms.DialogResult.OK Then
            ReadTasks()
        End If
    End Sub

    Private Sub TasksGrid_CellMouseDoubleClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles TasksGrid.CellMouseDoubleClick
        If GlobalVars.isOpen("Task - " & TasksGrid.CurrentRow.Cells.Item(0).Value.ToString) = False Then
            Dim NewTaskForm As New TaskForm
            NewTaskForm.Task_ID = TasksGrid.CurrentRow.Cells.Item(0).Value.ToString
            NewTaskForm.MdiParent = ParentMdiForm
            NewTaskForm.Show()
        End If
    End Sub

    Private Sub MonthCombo_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles MonthCombo.SelectionChangeCommitted
        Dim mDate As Date = Calendar.MonthView.StartDate.ToString()
        Dim newDate As New Date(mDate.Year, MonthCombo.SelectedIndex + 1, mDate.Day)
        Calendar.ShowDate(newDate)
    End Sub

    Private Sub YearCombo_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles YearCombo.SelectionChangeCommitted
        Dim yDate As Date = Calendar.MonthView.StartDate.ToString()
        Dim newDate As New Date(Convert.ToInt32(YearCombo.Text), yDate.Month, yDate.Day)
        Calendar.ShowDate(newDate)
    End Sub

    Private Sub Calendar_ItemDoubleClick(sender As Object, e As MouseEventArgs) Handles Calendar.ItemDoubleClick
        For i = 0 To Calendar.SelectedAppointments.Count() - 1 Step 1
            If Calendar.SelectedAppointments(i).IsSelected = True Then
                Dim strArr() As String = Calendar.SelectedAppointments(i).Appointment.Subject.Split("-")
                If GlobalVars.isOpen("Task - " & strArr(strArr.Length-1).Trim()) = False Then
                    Dim NewTaskForm As New TaskForm
                    NewTaskForm.Task_ID = strArr(strArr.Length-1).Trim()
                    NewTaskForm.MdiParent = ParentMdiForm
                    NewTaskForm.Show()
                End If
            End If
        Next
    End Sub

    Private Sub TasksForm_Enter(sender As Object, e As EventArgs) Handles MyBase.Enter
        ReadTasks()
    End Sub

    Private Sub Calendar_AppointmentReminder(sender As Object, e As ReminderEventArgs) Handles Calendar.AppointmentReminder
        Dim strArr() As String = e.Reminder.Appointment.Subject.Split("-")
        If GlobalVars.isOpen("Reminder Notification - " & strArr(strArr.Length-1).Trim()) = False Then
            Dim NewNotificationForm As New NotificationForm
            NewNotificationForm.Task_ID = strArr(strArr.Length-1).Trim()
            NewNotificationForm.Show()
        End If
        If e.Reminder.ReminderTime > Date.Now Then
            numReminders += 1
        End If
    End Sub

    Private Sub TasksTimer_Tick(sender As Object, e As EventArgs) Handles TasksTimer.Tick
        If reminderDone = False Then
            ShowReminders()
            reminderDone = True
            Exit Sub
        Else
            ParentMdiForm.SysTrayIcon.Visible = False
            TasksTimer.Enabled = False
        End If
    End Sub

    Private Sub VisibilityTimer_Tick(sender As Object, e As EventArgs) Handles VisibilityTimer.Tick
        If firstStart = True Then
            keepInvisible = True
            firstStart = False
        Else
            keepInvisible = False
            Me.Visible = True
        End If
        VisibilityTimer.Enabled = False
    End Sub

    Private Sub EditTaskBtn_Click(sender As Object, e As EventArgs) Handles EditTaskBtn.Click
        If GlobalVars.isOpen("Task - " & TasksGrid.CurrentRow.Cells.Item(0).Value.ToString) = False Then
            Dim NewTaskForm As New TaskForm
            NewTaskForm.Task_ID = TasksGrid.CurrentRow.Cells.Item(0).Value.ToString
            NewTaskForm.MdiParent = ParentMdiForm
            NewTaskForm.Show()
        End If
    End Sub

    Private Sub DeleteTaskBtn_Click(sender As Object, e As EventArgs) Handles DeleteTaskBtn.Click
        If MessageBox.Show("Are you sure you want to DELETE this task?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) = MsgBoxResult.Yes Then
            Dim sqlQuery As String = "DELETE FROM " & GlobalVars.tbl_TASKS & " WHERE TASK_ID = '" & TasksGrid.CurrentRow.Cells.Item(0).Value.ToString & "' "
            Dim cmd As MySqlCommand
            cmd = New MySqlCommand(sqlQuery, GlobalVars.cn)
            Try
                cmd.ExecuteNonQuery()
                ReadTasks()
            Catch ex As Exception
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If
    End Sub

    Private Sub FindTaskBtn_Click(sender As Object, e As EventArgs) Handles FindTaskBtn.Click
        QuickSearchForm.sForm = "Tasks"
        QuickSearchForm.ShowDialog()
    End Sub

    Private Sub RemindersTimer_Tick(sender As Object, e As EventArgs) Handles RemindersTimer.Tick
        ReadTasks()
    End Sub

    Private Sub TasksForm_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        e.Cancel = True
        Me.Hide()
    End Sub

    Private Sub TasksForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub TasksGrid_RowsAdded(sender As Object, e As DataGridViewRowsAddedEventArgs) Handles TasksGrid.RowsAdded
        EditTaskBtn.Enabled = True
        DeleteTaskBtn.Enabled = True
    End Sub
End Class