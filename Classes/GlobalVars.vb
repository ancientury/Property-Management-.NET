Imports System.Data
Imports MySql.Data.MySqlClient
Public Class GlobalVars
    'Logged in User
    Public Shared Username As String

    'Threads
    Public Shared cnThread As Threading.Thread

    'Database
    Public Shared DBName As String

    'Tables
    Public Shared tbl_APPLIANCE As String
    Public Shared tbl_ACCOUNTS As String
    Public Shared tbl_PROPERTIES As String
    Public Shared tbl_CONTRACTS As String
    Public Shared tbl_CONTACTS As String
    Public Shared tbl_INVOICES As String
    Public Shared tbl_DOCS As String
    Public Shared tbl_DATA As String
    Public Shared tbl_VOICE As String
    Public Shared tbl_LANDLINES As String
    Public Shared tbl_MOBILE As String
    Public Shared tbl_PC As String
    Public Shared tbl_TV As String
    Public Shared tbl_SKY As String
    Public Shared tbl_DVRNVR As String
    Public Shared tbl_CAR As String
    Public Shared tbl_LOGS As String
    Public Shared tbl_MLOGS As String
    Public Shared tbl_TASKS As String
    Public Shared tbl_PICTURES As String

    'Keys
    Public Shared PRIMARY_KEY As String

    'SQL connection string
    Public Shared connectionString As String

    'SQL Connection
    Public Shared cn As MySqlConnection

    'Login
    Public Shared LoggedState As Boolean = False

    'Random ID Function
    Public Shared Function randomID() As String
        Dim RND As New Random
        Dim UpperAlpha As String() = {"A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "O", "P", "Q", "R", "S", "T", "U", "V", "W", "X", "Y", "Z"}
        Dim randStr As String = vbNull

        Do Until Len(randStr) > 5
            If RND.Next(1, 4) = 2 Then randStr &= UpperAlpha(RND.Next(1, 26))
            If RND.Next(1, 4) = 3 Then randStr &= CStr(RND.Next(1, 10))
        Loop

        Return randStr
    End Function

    Public Shared Function isOpen(ByVal formText As String) As Boolean
        Dim frm As Form
        Dim i As Integer = 0
        Dim found As Boolean = False

        While i < Application.OpenForms.Count
            frm = Application.OpenForms.Item(i)

            If frm.Text.ToLower = formText.ToLower Then
                found = True
                frm.BringToFront()
                Exit While
            End If

            i += 1
        End While

        Return found
    End Function

    Public Shared Sub SetPage(HiddenTabCont As TabControl, VisibleTabCont As TabControl, Key As String, enable As Boolean)
        If enable Then
            If Not VisibleTabCont.TabPages.ContainsKey(Key) Then
                VisibleTabCont.TabPages.Add(HiddenTabCont.TabPages(Key))
                HiddenTabCont.TabPages.RemoveByKey(Key)
            End If
        Else
            If VisibleTabCont.TabPages.ContainsKey(Key) Then
                HiddenTabCont.TabPages.Add(VisibleTabCont.TabPages(Key))
                VisibleTabCont.TabPages.RemoveByKey(Key)
            End If
        End If
    End Sub


    Public Shared Sub LogOut()
        Try
            GlobalVars.cn.Dispose()
        Catch ex As Exception
            MsgBox(ex.Message.ToString, MsgBoxStyle.Exclamation, "Error")
        Finally
            ParentMdiForm.MdiPanel.Text = ""
            ParentMdiForm.MdiPanel.Enabled = False
            ParentMdiForm.ShowTasksStripMenuItem1.Enabled = False
            ParentMdiForm.LogOutToolStripMenuItem2.Enabled = False
            LoginForm.LoginPanel.Enabled = True
            GlobalVars.LoggedState = False
            ParentMdiForm.ReconnectTimer.Enabled = False
        End Try
    End Sub
End Class
