Imports MySql.Data.MySqlClient

Public Class NotificationForm
    Private Declare Function SetForegroundWindow Lib "user32" (ByVal hWnd As IntPtr) As Integer
    Public Task_ID As String
    Private DueDte As Date

    Private Sub NotificationForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        SetForegroundWindow(Me.Handle)
        Dim cmd As New MySqlCommand("SELECT * FROM " & GlobalVars.tbl_TASKS & " WHERE TASK_ID = @TASK_ID", GlobalVars.cn)
        cmd.Parameters.AddWithValue("@TASK_ID", Task_ID)

        Using dr As MySqlDataReader = cmd.ExecuteReader()
            If dr.Read() Then
                Me.Text = "Reminder Notification - " & dr.Item("TASK_ID")
                Subject.Text = "Subject: " & dr.Item("TASK_NAME")
                DueDate.Text = "Due date: " & dr.Item("TASK_DUE")
                Description.Text = dr.Item("TASK_NOTE")
                DueDte = dr.Item("TASK_DUE")
            End If
        End Using
    End Sub

    Private Sub ViewTaskBtn_Click(sender As Object, e As EventArgs) Handles ViewTaskBtn.Click
        If GlobalVars.isOpen("Task - " & Task_ID) = False Then
            Dim NewTaskForm As New TaskForm
            NewTaskForm.Task_ID = Task_ID
            If NewTaskForm.ShowDialog() Then
                Dim cmd As New MySqlCommand("SELECT * FROM " & GlobalVars.tbl_TASKS & " WHERE TASK_ID = @TASK_ID", GlobalVars.cn)
                cmd.Parameters.AddWithValue("@TASK_ID", Task_ID)

                Using dr As MySqlDataReader = cmd.ExecuteReader()
                    If dr.Read() Then
                        If dr.Item("TASK_STATUS") = "Completed" Or dr.Item("TASK_STATUS") = "Dismissed" Or dr.Item("TASK_REMINDER") = "No" Then
                            TasksForm.ReadTasks()
                            Me.Close()
                        End If
                    End If
                End Using
            End If
        End If
    End Sub

    Private Sub DismissBtn_Click(sender As Object, e As EventArgs) Handles DismissBtn.Click
        If MessageBox.Show("Are you sure you want to DISMISS this task?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) = MsgBoxResult.Yes Then
            Dim sqlQuery As String = "UPDATE " & GlobalVars.tbl_TASKS & " SET TASK_STATUS = 'Dismissed' WHERE TASK_ID  = '" & Task_ID & "' "
            Dim cmd As MySqlCommand
            cmd = New MySqlCommand(sqlQuery, GlobalVars.cn)
            Try
                cmd.ExecuteNonQuery()
                TasksForm.ReadTasks()
                Me.Close()
            Catch ex As Exception
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If
    End Sub

    Private Sub MarkTaskBtn_Click(sender As Object, e As EventArgs) Handles MarkTaskBtn.Click
        If MessageBox.Show("Are you sure you want to mark this task as completed?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Information) = MsgBoxResult.Yes Then
            Dim sqlQuery As String = "UPDATE " & GlobalVars.tbl_TASKS & " SET TASK_STATUS = 'Completed' WHERE TASK_ID  = '" & Task_ID & "' "
            Dim cmd As MySqlCommand
            cmd = New MySqlCommand(sqlQuery, GlobalVars.cn)
            Try
                cmd.ExecuteNonQuery()
                TasksForm.ReadTasks()
                Me.Close()
            Catch ex As Exception
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If
    End Sub
End Class