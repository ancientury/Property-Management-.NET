Public Class QuickSearchForm
    Public sForm As String

    Public Shared Function SearchGridValue(ByVal dtg As DataGridView, ByVal ColumnName As String, ByVal ValueToSearch As String) As Boolean
        Dim Found As Boolean = False
        Dim StringToSearch As String = ""
        Dim ValueToSearchFor As String = ValueToSearch.Trim.ToLower
        Dim CurrentRowIndex As Integer = 0
        Try
            If dtg.Rows.Count = 0 Then
                CurrentRowIndex = 0
            Else
                CurrentRowIndex = dtg.CurrentRow.Index + 1
            End If
            If CurrentRowIndex > dtg.Rows.Count Then
                CurrentRowIndex = dtg.Rows.Count - 1
            End If
            If dtg.Rows.Count > 0 Then
                For Each gRow As DataGridViewRow In dtg.Rows
                    StringToSearch = gRow.Cells(ColumnName).Value.ToString.Trim.ToLower
                    If StringToSearch.Contains(ValueToSearchFor) Then
                        Dim myCurrentCell As DataGridViewCell = gRow.Cells(ColumnName)
                        dtg.CurrentCell = myCurrentCell
                        Found = True
                    End If
                    If Found Then
                        Exit For
                    End If
                Next
            End If
            If Not Found Then
                If dtg.Rows.Count > 0 Then
                    Dim myFirstCurrentCell As DataGridViewCell = dtg.Rows(0).Cells(ColumnName)
                    dtg.CurrentCell = myFirstCurrentCell
                End If
            End If
        Catch ex As Exception
            MsgBox("Error: " & ex.Message, MsgBoxStyle.Information)
        End Try
        Return Found
    End Function

    Private Sub QuickSearchForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If sForm = "Properties" Then
            SearchByCombo.Items.Add("Property ID")
            SearchByCombo.Items.Add("Company")
            SearchByCombo.Items.Add("City")
            SearchByCombo.Items.Add("County")
            SearchByCombo.Items.Add("Postcode")
            SearchByCombo.Items.Add("Telephone")
        ElseIf sForm = "Tasks" Then
            SearchByCombo.Items.Add("ID")
            SearchByCombo.Items.Add("Username")
            SearchByCombo.Items.Add("Subject")
            SearchByCombo.Items.Add("Date Created")
            SearchByCombo.Items.Add("Due date")
        End If
    End Sub

    Private Sub SearchBtn_Click(sender As Object, e As EventArgs) Handles SearchBtn.Click
        If sForm = "Properties" Then
            SearchGridValue(MainForm.DataGrid, SearchByCombo.Text, SearchText.Text)
            Me.Close()
        ElseIf sForm = "Tasks" Then
            SearchGridValue(TasksForm.TasksGrid, SearchByCombo.Text, SearchText.Text)
            Me.Close()
        End If
    End Sub
End Class