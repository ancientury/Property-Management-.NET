Imports System.Windows.Forms
Imports System.Text.RegularExpressions
Imports MySql.Data.MySqlClient

Public Class ContactDialog

    Public Id, Staff_ID As String
    Public NewRecord = False, EditMode As Boolean
    Function IsValidEmailFormat(ByVal s As String) As Boolean
        If ContactEmail.Text.Length > 0 Then
            Return Regex.IsMatch(s, "^([0-9a-zA-Z]([-\.\w]*[0-9a-zA-Z])*@([0-9a-zA-Z][-\w]*[0-9a-zA-Z]\.)+[a-zA-Z]{2,9})$")
        Else
            Return True
        End If
    End Function
    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK_Button.Click
        If EditMode = False Then
            If ContactName.Text.Length > 1 And IsValidEmailFormat(ContactEmail.Text) = True And ContactNumber.Text.Length > 5 Then
                Dim sqlQuery As String = "REPLACE INTO " & GlobalVars.tbl_CONTACTS & " VALUES(@Id, @Staff_ID, @Username, @ContactName, @ContactNumber, @ContactEmail, @ContactAddress) "

                Dim cmd As MySqlCommand
                cmd = New MySqlCommand(sqlQuery, GlobalVars.cn)
                cmd.Parameters.AddWithValue("@Id", Id)
                cmd.Parameters.AddWithValue("@Staff_Id", Staff_ID)
                cmd.Parameters.AddWithValue("@Username", GlobalVars.Username)
                cmd.Parameters.AddWithValue("@ContactName", ContactName.Text)
                cmd.Parameters.AddWithValue("@ContactNumber", ContactNumber.Text)
                cmd.Parameters.AddWithValue("@ContactEmail", ContactEmail.Text)
                cmd.Parameters.AddWithValue("@ContactAddress", ContactAddress.Text)
                Try
                    cmd.ExecuteNonQuery()
                Catch ex As Exception
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Finally
                    Me.DialogResult = System.Windows.Forms.DialogResult.OK
                    Me.Close()
                End Try
            Else
                MessageBox.Show("Please fill in and verify all fields before proceeding!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            End If
        Else
            Me.Close()
        End If
    End Sub

    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub

    Private Sub ContactEmail_KeyPress(sender As Object, e As KeyPressEventArgs) Handles ContactEmail.KeyPress
        Dim ac As String = "@"
        If e.KeyChar <> ChrW(Keys.Back) Then
            If Asc(e.KeyChar) < 97 Or Asc(e.KeyChar) > 122 Then
                If Asc(e.KeyChar) <> 46 And Asc(e.KeyChar) <> 95 Then
                    If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                        If ac.IndexOf(e.KeyChar) = -1 Then
                            e.Handled = True

                        Else

                            If ContactEmail.Text.Contains("@") And e.KeyChar = "@" Then
                                e.Handled = True
                            End If

                        End If


                    End If
                End If
            End If

        End If
    End Sub

    Private Sub ContactNumber_KeyPress(sender As Object, e As KeyPressEventArgs) Handles ContactNumber.KeyPress
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub ContactDialog_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If NewRecord = True Then
            Staff_ID = GlobalVars.randomID()
            ContactID.Text = "Staff ID: " & Staff_ID
            CancelBtn.Visible = True
            EditBtn_Click(Nothing, Nothing)
        Else
            ContactID.Text = "Staff ID: " & Staff_ID
            EditBtn.Visible = True
            EditBtn_Click(Nothing, Nothing)
            Dim cmd As New MySqlCommand("SELECT * FROM " & GlobalVars.tbl_CONTACTS & " WHERE CONTACT_ID = @CONTACT_ID", GlobalVars.cn)
            cmd.Parameters.AddWithValue("@CONTACT_ID", Staff_ID)

            Using dr As MySqlDataReader = cmd.ExecuteReader()
                If dr.Read() Then
                    ContactName.Text = dr.Item("CONTACT_NAME")
                    ContactNumber.Text = dr.Item("CONTACT_NUMBER")
                    ContactEmail.Text = dr.Item("CONTACT_EMAIL")
                    ContactAddress.Text = dr.Item("CONTACT_ADDRESS")
                End If
            End Using
        End If
    End Sub

    Private Sub EditBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EditBtn.Click
        Select Case EditMode
            Case True
                ContactName.ReadOnly = False
                ContactNumber.ReadOnly = False
                ContactEmail.ReadOnly = False
                ContactAddress.ReadOnly = False
                EditBtn.Text = "Cancel Edit"
                EditMode = False
            Case False
                ContactName.ReadOnly = True
                ContactNumber.ReadOnly = True
                ContactEmail.ReadOnly = True
                ContactAddress.ReadOnly = True
                EditBtn.Text = "Edit"
                EditMode = True
        End Select
    End Sub
End Class
