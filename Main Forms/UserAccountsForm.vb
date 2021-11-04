Imports System.Threading
Imports MySql.Data.MySqlClient

Public Class UserAccountsForm
    Private InvoicesThread As Thread
    Private Prevs As String

    Public Sub ReadAccounts()
        InvoicesThread = New Thread(AddressOf sqlAccounts_Thread)
        InvoicesThread.IsBackground = True
        InvoicesThread.Start()
    End Sub

    Private Sub sqlAccounts_Thread()
        ReadAccountsData()
    End Sub

    Private Sub ReadAccountsData()
        If Me.InvokeRequired Then
            Me.Invoke(New MethodInvoker(AddressOf ReadAccountsData))
        Else

            Dim sqlQuery As String = "SELECT USER, SELECT_PRIV, INSERT_PRIV, UPDATE_PRIV, DELETE_PRIV, CREATE_PRIV FROM mysql.user"
            Dim da As New MySqlDataAdapter(sqlQuery, GlobalVars.cn)
            Dim ds As New DataSet()

            Try
                da.Fill(ds)
                Dim dt As New DataTable("USERS")
                da.Fill(dt)

                AccountsGrid.DataSource = dt
            Catch ex As Exception
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If
    End Sub

    Private Sub UserAccountsForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ReadAccounts()
    End Sub

    Private Sub M_CreateAccount_Click(sender As Object, e As EventArgs) Handles M_CreateAccount.Click
        If MessageBox.Show("Are you sure you want to Create this user account?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Information) = MsgBoxResult.Yes Then
            M_CreateAccount.Enabled = False
            Dim sqlQuery As String = " ON PMD.* TO '" & M_Name.Text & "'@'%' IDENTIFIED BY '" & M_Password.Text & "' "

            If M_GrantSelect.Checked Then
                Prevs = "SELECT"
            End If
            If M_GrantInsert.Checked Then
                If M_GrantSelect.Checked Then
                    Prevs = Prevs & ", INSERT"
                Else
                    Prevs = Prevs & "INSERT"
                End If
            End If
            If M_GrantUpdate.Checked Then
                If M_GrantSelect.Checked Or M_GrantInsert.Checked Then
                    Prevs = Prevs & ", UPDATE"
                Else
                    Prevs = Prevs & "UPDATE"
                End If
            End If

            If M_GrantDelete.Checked Then
                If M_GrantSelect.Checked Or M_GrantInsert.Checked Or M_GrantUpdate.Checked Then
                    Prevs = Prevs & ", UPDATE"
                Else
                    Prevs = Prevs & "UPDATE"
                End If
            End If

            sqlQuery = "GRANT " & Prevs & sqlQuery

            Dim cmd As MySqlCommand
            cmd = New MySqlCommand(sqlQuery, GlobalVars.cn)
            Try
                cmd.ExecuteNonQuery()
                MessageBox.Show("Account created successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                ReadAccounts()
            Catch ex As Exception
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Finally
                M_Name.Text = ""
                M_Password.Text = ""
                M_CreateAccount.Enabled = True
            End Try
        End If
    End Sub
End Class