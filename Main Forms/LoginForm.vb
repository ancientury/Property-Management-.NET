Imports System.Data
Imports MySql.Data.MySqlClient
Imports System.Data.SqlClient
Imports System.Threading
Imports Microsoft.VisualBasic

Public Class LoginForm
    Private LoginThread As System.Threading.Thread

    Private Sub SetControlsBeforeLogin()
        LoginPanel.Enabled = False
        ParentMdiForm.Status.Text = "Connecting to database..."
        ParentMdiForm.progressBar.Visible = True
    End Sub
    Private Sub SetControlsLoginFailed()
        LoginPanel.Enabled = True
        ParentMdiForm.Status.Text = "Login failed!"
        ParentMdiForm.progressBar.Visible = False
    End Sub

    Private Sub SetControlsLoginSuccess()
        ' Save credentials to settings ini file
        If rememberMe.CheckState = CheckState.Checked Then
            SettingsINI.WriteINIValue("Login", "RememberMe", "1")
            Dim i As Integer
            For i = 0 To 10 Step 1
                If String.IsNullOrEmpty(SettingsINI.ReadINIValue("Login", "User" & i)) = True Then
                    Exit For
                End If
            Next
            If SettingsINI.ReadINIValue("Login", "User" & i - 1).Equals(DBUsername.Text) = False Then
                SettingsINI.WriteINIValue("Login", "User" & i, DBUsername.Text)
            End If
        Else
            SettingsINI.WriteINIValue("Login", "RememberMe", "0")
        End If

        SettingsINI.WriteINIValue("Login", "RememberedUser", DBUsername.Text)
        SettingsINI.WriteINIValue("Login", "RememberedPass", DBPassword.Text)

        LoginPanel.Enabled = False

        ParentMdiForm.MdiPanel.Enabled = True
        ParentMdiForm.MdiPanel.Text = "Logged in as " & DBUsername.Text
        ParentMdiForm.Status.Text = "Connection established!"

        Me.Close()

    End Sub
    Public Sub SqlLogin()

        Invoke(Sub() SetControlsBeforeLogin())

        Dim cnn As SqlConnection = New SqlConnection(GlobalVars.connectionString)
        Try
            cnn.Open()
            Invoke(Sub()
                       MessageBox.Show("Connection established!", "Login", MessageBoxButtons.OK, MessageBoxIcon.Information)
                       SetControlsLoginSuccess()
                   End Sub)
        Catch ex As Exception
            Invoke(Sub()
                       MessageBox.Show(ex.Message, "Login", MessageBoxButtons.OK, MessageBoxIcon.Error)
                       SetControlsLoginFailed()
                   End Sub)
        Finally
            cnn.Close()
        End Try

    End Sub
    Public Sub Login_Click(ByVal sender As Object, ByVal e As EventArgs) Handles LoginBtn.Click

        SettingsINI.WriteINIValue("Login", "Hostname", DBHost.Text)

        GlobalVars.connectionString = "Server=" + DBHost.Text + ";Database=" + GlobalVars.DBName + ";User Id=" + DBUsername.Text + ";Password=" + DBPassword.Text + ";"
        GlobalVars.Username = DBUsername.Text

        LoginThread = New Thread(Sub() SqlLogin())
        LoginThread.IsBackground = True
        LoginThread.Start()

    End Sub

    Private Sub LoginForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        DBHost.Text = SettingsINI.ReadINIValue("Login", "Hostname")
        If SettingsINI.ReadINIValue("Login", "RememberMe") = "1" Then
            DBUsername.Text = SettingsINI.ReadINIValue("Login", "RememberedUser")
            DBPassword.Text = SettingsINI.ReadINIValue("Login", "RememberedPass")
            rememberMe.Checked = True
            Dim i As Integer
            For i = 0 To 10 Step 1
                If String.IsNullOrEmpty(SettingsINI.ReadINIValue("Login", "User" & i)) = True Then
                    Exit For
                Else
                    DBUsername.Items.Add(SettingsINI.ReadINIValue("Login", "User" & i))
                End If
            Next
        End If

    End Sub

    Private Sub ExitBtn_Click(sender As Object, e As EventArgs) Handles ExitBtn.Click
        ParentMdiForm.exitApp = True
        Application.Exit()
    End Sub

    Private Sub DBPassword_KeyPress(sender As Object, e As KeyPressEventArgs) Handles DBPassword.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            LoginBtn.PerformClick()
        End If
    End Sub
End Class