Imports MySql.Data.MySqlClient

Public Class SkyDialog
    Public Id, Company, Asset_ID As String
    Public EditMode, NewRecord As Boolean
    Private Sub LinkContractBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LinkContractBtn.Click
        If EditMode = True Then
            LinkContractForm.Id = Id
            If LinkContractForm.ShowDialog() = Windows.Forms.DialogResult.OK Then
                CardContract.Text = "Provided by " & LinkContractForm.ContractsGrid.CurrentRow.Cells.Item(1).Value & " - " & LinkContractForm.ContractsGrid.CurrentRow.Cells.Item(0).Value
            End If
        Else
            Dim form As New ContractForm
            Dim strArr() As String = CardContract.Text.Split("-")
            form.Company = Company
            form.Id = Id
            form.Contract_ID = strArr(1).Trim()
            form.ViewContract = True
            form.MdiParent = ParentMdiForm
            form.ShowDialog()
        End If
    End Sub

    Private Sub EditBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EditBtn.Click
        Select Case EditMode
            Case True
                Card_Number.ReadOnly = False
                Card_Status.Enabled = True
                LinkContractBtn.Enabled = True
                LinkContractBtn.Text = "Link Contract"
                EditBtn.Text = "Cancel Edit"
                EditMode = False
            Case False
                Card_Number.ReadOnly = True
                Card_Status.Enabled = False
                If CardContract.Text = "None" Then
                    LinkContractBtn.Enabled = False
                Else
                    LinkContractBtn.Text = "View Contract"
                End If
                EditBtn.Text = "Edit"
                EditMode = True
        End Select
    End Sub

    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK_Button.Click
        If EditMode = False Then
            If Card_Number.Text.Length > 5 And Card_Status.SelectedIndex <> -1 Then
                Dim sqlQuery As String = "REPLACE INTO " & GlobalVars.tbl_SKY & " VALUES(@Id, @Username, @Asset_ID, @Card_Number, @CardContract, @Card_Status, @Card_Location) "

                Dim cmd As MySqlCommand
                cmd = New MySqlCommand(sqlQuery, GlobalVars.cn)
                cmd.Parameters.AddWithValue("@Id", Id)
                cmd.Parameters.AddWithValue("@Username", GlobalVars.Username)
                cmd.Parameters.AddWithValue("@Asset_ID", Asset_ID)
                cmd.Parameters.AddWithValue("@Card_Number", Card_Number.Text)
                cmd.Parameters.AddWithValue("@CardContract", CardContract.Text)
                cmd.Parameters.AddWithValue("@Card_Status", Card_Status.Text)
                cmd.Parameters.AddWithValue("@Card_Location", Card_Location.Text)
                Try
                    cmd.ExecuteNonQuery()
                    Me.DialogResult = System.Windows.Forms.DialogResult.OK
                    Me.Close()
                Catch ex As Exception
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End Try
            Else
                MessageBox.Show("Please fill in and verify all fields before proceeding!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            End If
        Else
            Me.Close()
        End If
    End Sub

    Private Sub SkyDialog_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If NewRecord = True Then
            CancelBtn.Visible = True
            EditBtn_Click(Nothing, Nothing)
        Else
            EditBtn.Visible = True
            EditBtn_Click(Nothing, Nothing)
            Dim cmd As New MySqlCommand("SELECT * FROM " & GlobalVars.tbl_SKY & " WHERE PROPERTY_ID = '" & Id & "' AND ASSET_ID = @ASSET_ID ", GlobalVars.cn)
            cmd.Parameters.AddWithValue("@ASSET_ID", Asset_ID)

            Using dr As MySqlDataReader = cmd.ExecuteReader()
                If dr.Read() Then
                    Card_Number.Text = dr.Item("VIEWING_CARD_NUMBER")
                    CardContract.Text = dr.Item("CONTRACT")
                    Card_Status.Text = dr.Item("STATUS")
                    Card_Location.Text = dr.Item("LOCATION")
                End If
            End Using
        End If
    End Sub
End Class