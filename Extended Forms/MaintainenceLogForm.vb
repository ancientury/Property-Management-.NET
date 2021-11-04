Imports MySql.Data.MySqlClient

Public Class MaintainenceLogForm
    Public Id, Log_ID As String
    Public EditMode, NewRecord As Boolean
    Private Sub OkBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OkBtn.Click
        If EditMode = False Then
            If Username.TextLength < 1 Then
                GoTo Invalid
            End If
            If Status.SelectedIndex < 0 Then
                GoTo Invalid
            End If

            GoTo Valid

Invalid:
            MessageBox.Show("You must fill in all required fields before proceeding.", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub

Valid:
            EditBtn_Click(Nothing, Nothing)

            Dim sqlQuery As String = "REPLACE INTO " & GlobalVars.tbl_MLOGS & " VALUES(@Id, @Log_ID, @Username, @Location, @Status, @TimeStamp, @Log) "

            Dim cmd As MySqlCommand
            cmd = New MySqlCommand(sqlQuery, GlobalVars.cn)
            cmd.Parameters.AddWithValue("@Id", Id)
            cmd.Parameters.AddWithValue("@Log_ID", LOG_ID)
            cmd.Parameters.AddWithValue("@Username", GlobalVars.Username)
            cmd.Parameters.AddWithValue("@Location", Location.Text)
            cmd.Parameters.AddWithValue("@Status", Status.Text)
            cmd.Parameters.AddWithValue("@TimeStamp", Format(TimeStamp.Value, "yyyy-MM-dd HH:mm"))
            cmd.Parameters.AddWithValue("@Log", Log.Text)
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

    Private Sub MaintainenceLogForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If NewRecord = True Then
            If String.IsNullOrEmpty(Log_ID) = True Then
                Log_ID = GlobalVars.randomID()
            End If
            LogId.Text = "Log ID: " & Log_ID
            Username.Text = GlobalVars.Username
            TimeStamp.Text = System.DateTime.Now.ToString("dd/MM/yyyy HH:mm")
            EditMode = True
            EditBtn_Click(Nothing, Nothing)
            DeleteBtn.Visible = False
            EditBtn.Visible = False
            CancelBtn.Visible = True
        Else
            Me.Text = "Maintainence Log - " & Log_ID
            Dim cmd As New MySqlCommand("SELECT * FROM " & GlobalVars.tbl_MLOGS & " WHERE LOG_ID = @LOG_ID", GlobalVars.cn)
            cmd.Parameters.AddWithValue("@LOG_ID", Log_ID)

            Using dr As MySqlDataReader = cmd.ExecuteReader()
                If dr.Read() Then
                    LogId.Text = "Log ID: " & dr.Item("LOG_ID")
                    Username.Text = dr.Item("USERNAME")
                    Status.Text = dr.Item("STATUS")
                    Location.Text = dr.Item("LOCATION")
                    TimeStamp.Text = dr.Item("TIME")
                    Log.Text = dr.Item("LOG")
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
                Status.Enabled = True
                Location.ReadOnly = False
                TimeStamp.Enabled = True
                Log.ReadOnly = False
                DeleteBtn.Visible = True
                EditMode = False
                OkBtn.Text = "Save Changes"
                EditBtn.Text = "Cancel Changes"
            Case False
                Status.Enabled = False
                Location.ReadOnly = True
                TimeStamp.Enabled = False
                Log.ReadOnly = True
                DeleteBtn.Visible = False
                EditMode = True
                OkBtn.Text = "OK"
                EditBtn.Text = "Edit"
        End Select
    End Sub

    Private Sub DeleteBtn_Click(sender As Object, e As EventArgs) Handles DeleteBtn.Click
        If MessageBox.Show("Are you sure you want to DELETE this log?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) = MsgBoxResult.Yes Then
            Dim sqlQuery As String = "DELETE FROM " & GlobalVars.tbl_MLOGS & " WHERE LOG_ID = '" & Log_ID & "' "
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

    Private Sub MaintainenceLogForm_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        DetailsForm.ReadMLogs()
    End Sub
End Class