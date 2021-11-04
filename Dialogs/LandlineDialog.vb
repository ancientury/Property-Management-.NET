Imports MySql.Data.MySqlClient

Public Class LandlineDialog
    Public Id, Company, Asset_ID As String
    Public EditMode, NewRecord As Boolean
    Private Sub LinkContractBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LinkContractBtn.Click
        If EditMode = True Then
            LinkContractForm.Id = Id
            If LinkContractForm.ShowDialog() = Windows.Forms.DialogResult.OK Then
                LandlineContract.Text = "Provided by " & LinkContractForm.ContractsGrid.CurrentRow.Cells.Item(1).Value & " - " & LinkContractForm.ContractsGrid.CurrentRow.Cells.Item(0).Value
            End If
        Else
            Dim form As New ContractForm
            Dim strArr() As String = LandlineContract.Text.Split("-")
            If GlobalVars.isOpen("Contract - " & strArr(1).Trim()) = False Then
                form.Company = Company
                form.Id = Id
                form.Contract_ID = strArr(1).Trim()
                form.ViewContract = True
                form.MdiParent = ParentMdiForm
                form.ShowDialog()
            End If
        End If
    End Sub

    Private Sub EditBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EditBtn.Click
        Select Case EditMode
            Case True
                Landline_Number.ReadOnly = False
                Landline_Type.Enabled = True
                Landline_Status.Enabled = True
                LinkContractBtn.Text = "Link Contract"
                EditBtn.Text = "Cancel Edit"
                EditMode = False
            Case False
                Landline_Number.ReadOnly = True
                Landline_Type.Enabled = False
                Landline_Status.Enabled = False
                LinkContractBtn.Text = "View Contract"
                EditBtn.Text = "Edit"
                EditMode = True
        End Select
    End Sub

    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK_Button.Click
        If EditMode = True Then
            If Landline_Number.Text.Length > 5 And Landline_Type.SelectedIndex <> -1 And Landline_Status.SelectedIndex <> -1 Then
                Dim sqlQuery As String = "REPLACE INTO " & GlobalVars.tbl_LANDLINES & " VALUES(@Id, @Asset_ID, @Username,  @Landline_Type, @Landline_Number, @LandlineContract, @Landline_Status, @Landline_Location) "

                Dim cmd As MySqlCommand
                cmd = New MySqlCommand(sqlQuery, GlobalVars.cn)
                cmd.Parameters.AddWithValue("@Id", Id)
                cmd.Parameters.AddWithValue("@Asset_ID", Asset_ID)
                cmd.Parameters.AddWithValue("@Username", GlobalVars.Username)
                cmd.Parameters.AddWithValue("@Landline_Type", Landline_Type.Text)
                cmd.Parameters.AddWithValue("@Landline_Number", Landline_Number.Text)
                cmd.Parameters.AddWithValue("@LandlineContract", LandlineContract.Text)
                cmd.Parameters.AddWithValue("@Landline_Status", Landline_Status.Text)
                cmd.Parameters.AddWithValue("@Landline_Location", Landline_Location.Text)
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

    Private Sub LandlineDialog_Load(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If NewRecord = True Then
            CancelBtn.Visible = True
            EditBtn_Click(Nothing, Nothing)
        Else
            EditBtn.Visible = True
            EditBtn_Click(Nothing, Nothing)
            Dim cmd As New MySqlCommand("SELECT * FROM " & GlobalVars.tbl_LANDLINES & " WHERE PROPERTY_ID = '" & Id & "' AND ASSET_ID = @ASSET_ID ", GlobalVars.cn)
            cmd.Parameters.AddWithValue("@ASSET_ID", Asset_ID)

            Using dr As MySqlDataReader = cmd.ExecuteReader()
                If dr.Read() Then
                    Landline_Type.Text = dr.Item("TYPE")
                    Landline_Number.Text = dr.Item("NUMBER")
                    LandlineContract.Text = dr.Item("CONTRACT")
                    Landline_Status.Text = dr.Item("STATUS")
                    Landline_Location.Text = dr.Item("LOCATION")
                End If
            End Using
        End If
    End Sub

End Class