Imports Microsoft.Win32

Public Class ParentMdiForm

    Public exitApp As Boolean
    Public Sub CheckForExistingInstance()
        'Get number of processes of you program
        If Process.GetProcessesByName _
          (Process.GetCurrentProcess.ProcessName).Length > 1 Then

            MessageBox.Show _
             ("Another Instance of this process is already running",
                 "Multiple Instances Forbidden",
                  MessageBoxButtons.OK,
                 MessageBoxIcon.Exclamation)
            exitApp = True
            Application.Exit()

        End If
    End Sub

    Private Sub ParentForm_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
        SysTrayIcon.Text = Me.Text

        If SettingsINI.ReadINIValue("Startup", "WindowPos").Equals("Hidden") Then
            Try
                SysTrayIcon.Visible = True
                Me.Hide()
            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.Critical)
            End Try
        End If

#If DEBUG Then

#Else
        ' Load Startup Settings
        Dim regKey As Microsoft.Win32.RegistryKey
        Try
            regKey = Registry.LocalMachine.OpenSubKey("SOFTWARE\Microsoft\Windows\CurrentVersion\Run", True)
            If ReadINIValue("Startup", "LaunchAtStartup").Equals("Yes") Then
                regKey.SetValue("Property Management .NET", Application.ExecutablePath)
                regKey.Close()
                If ReadINIValue("Startup", "AutoLoginAtStartup").Equals("Yes") Then
                    LoginForm.userName.Text = ReadINIValue("Startup", "AutoLoginUsername")
                    LoginForm.password.Text = ReadINIValue("Startup", "AutoLoginPassword")
                    LoginForm.Login_Click(Nothing, Nothing)
                End If
            ElseIf ReadINIValue("Startup", "LaunchAtStartup").Equals("No") Then
                regKey.DeleteValue("Property Management .NET", False)
            End If
        Catch ex As Exception
            MsgBox(ex.Message & ". Make sure you run as an administrator!", MsgBoxStyle.Critical)
        End Try
#End If

        progressBar.Visible = False
        LoginForm.MdiParent = Me
        LoginForm.Show()
    End Sub

    Private Sub ManageBtn_Click(ByVal sender As Object, ByVal e As EventArgs) Handles ManageBtn.Click
        MainForm.Text = "Properties"
        MainForm.MdiParent = Me
        MainForm.Show()
    End Sub

    Private Sub SettingsBtn_Click(ByVal sender As Object, ByVal e As EventArgs) Handles SettingsBtn.Click
        SettingsForm.MdiParent = Me
        SettingsForm.Show()
    End Sub

    Private Sub LogOutBtn_Click(ByVal sender As Object, ByVal e As EventArgs) Handles LogOutBtn.Click
        For Each frm As Form In Me.MdiChildren
            frm.Close()
        Next
        LoginForm.MdiParent = Me
        LoginForm.Show()
    End Sub

    Private Sub LogOutToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        For Each frm As Form In Me.MdiChildren
            frm.Close()
        Next
        LoginForm.MdiParent = Me
        LoginForm.Show()
    End Sub

    Private Sub ExitToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        exitApp = True
        Application.Exit()
    End Sub

    Private Sub SearchBtn_Click(ByVal sender As Object, ByVal e As EventArgs) Handles SearchBtn.Click
        SearchForm.MdiParent = Me
        SearchForm.Show()
    End Sub

    Private Sub AccManagementBtn_Click(ByVal sender As Object, ByVal e As EventArgs) Handles AccManagementBtn.Click
        UserAccountsForm.MdiParent = Me
        UserAccountsForm.Show()
    End Sub

    Private Sub RemindersBtn_Click(ByVal sender As Object, ByVal e As EventArgs) Handles RemindersBtn.Click
        TasksForm.MdiParent = Me
        TasksForm.firstStart = False
        TasksForm.VisibilityTimer.Enabled = True
        TasksForm.Show()
    End Sub

    Private Sub ParentMdiForm_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        If exitApp = False Then
            Try
                e.Cancel = True
                SysTrayIcon.Visible = True
                Me.Hide()
            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.Critical)
            End Try
        End If
    End Sub

    Private Sub ShowToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ShowToolStripMenuItem.Click
        Try
            Me.Show()
            Me.WindowState = FormWindowState.Maximized
            Me.BringToFront()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub

    Private Sub ExitToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem1.Click
        Try
            exitApp = True
            Application.Exit()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub

    Private Sub LogOutToolStripMenuItem2_Click(sender As Object, e As EventArgs) Handles LogOutToolStripMenuItem2.Click
        For Each frm As Form In Me.MdiChildren
            frm.Close()
        Next
        LoginForm.MdiParent = Me
        LoginForm.Show()
    End Sub

    Private Sub ParentMdiForm_Shown(sender As Object, e As EventArgs) Handles MyBase.Shown
        Try
            Me.WindowState = FormWindowState.Maximized
            SysTrayIcon.Visible = False
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub

    Private Sub ParentMdiForm_Resize(sender As Object, e As EventArgs) Handles MyBase.Resize
        Try
            If Me.WindowState = FormWindowState.Minimized Then
                SysTrayIcon.Visible = True
            ElseIf Me.WindowState = FormWindowState.Maximized Or Me.WindowState = FormWindowState.Normal Then
                SysTrayIcon.Visible = False
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub

    Private Sub SysTrayIcon_DoubleClick(sender As Object, e As EventArgs) Handles SysTrayIcon.DoubleClick
        Try
            Me.WindowState = FormWindowState.Maximized
            Me.Show()
            SysTrayIcon.Visible = False
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub

    Private Sub ReconnectTimer_Tick(sender As Object, e As EventArgs) Handles ReconnectTimer.Tick
        If GlobalVars.LoggedState = True Then
            If GlobalVars.cn.State = ConnectionState.Closed Then
                Status.Text = "Connection dropped. Reconnecting..."
                System.Threading.Thread.Sleep(2000)
                GlobalVars.cn.Close()
            End If
        End If
    End Sub

    Private Sub ShowTasksToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ShowTasksStripMenuItem1.Click
        Me.Show()
        TasksForm.MdiParent = Me
        TasksForm.firstStart = False
        TasksForm.VisibilityTimer.Enabled = True
        TasksForm.Show()
    End Sub

    Private Sub ExitBtn_Click(sender As Object, e As EventArgs) Handles ExitBtn.Click
        exitApp = True
        Application.Exit()
    End Sub

    Private Sub AccountsBtn_Click(sender As Object, e As EventArgs) Handles AccountsBtn.Click
        AccountsForm.MdiParent = Me
        AccountsForm.Show()
    End Sub

    Private Sub UpdateBtn_Click(sender As Object, e As EventArgs) Handles UpdateBtn.Click
        If System.IO.File.Exists("wyUpdate.exe") Then
            Process.Start("wyUpdate.exe")
        Else
            MsgBox("Updater not found. Contact us for assistance!", MsgBoxStyle.Exclamation, "Error")
        End If
    End Sub
End Class