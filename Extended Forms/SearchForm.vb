Imports MySql.Data.MySqlClient
Imports System.Threading

Public Class SearchForm
    Private SearchThread As Thread
    Private Sub SearchData()
        If Me.InvokeRequired Then
            Me.Invoke(New MethodInvoker(AddressOf SearchData))
        Else
            ParentMdiForm.Status.Text = "Searching..."
            ParentMdiForm.progressBar.Visible = True

            Dim SelectedTable, SelectedKey As String
            If SearchIn.GetItemText(SearchIn.SelectedItem) = "Properties" Then
                SelectedTable = GlobalVars.tbl_PROPERTIES
                If SearchBy.GetItemText(SearchBy.SelectedItem) = "Property ID" Then
                    SelectedKey = "PROPERTY_ID"
                ElseIf SearchBy.GetItemText(SearchBy.SelectedItem) = "Contract ID" Then
                    SelectedTable = GlobalVars.tbl_CONTRACTS
                    SelectedKey = "CONTRACT_ID"
                ElseIf SearchBy.GetItemText(SearchBy.SelectedItem) = "Invoice ID" Then
                    SelectedTable = GlobalVars.tbl_INVOICES
                    SelectedKey = "INVOICE_ID"
                End If
            ElseIf SearchIn.GetItemText(SearchIn.SelectedItem) = "Contracts" Then
                SelectedTable = GlobalVars.tbl_CONTRACTS
                If SearchBy.GetItemText(SearchBy.SelectedItem) = "Property ID" Then
                    SelectedKey = "PROPERTY_ID"
                ElseIf SearchBy.GetItemText(SearchBy.SelectedItem) = "Contract ID" Then
                    SelectedKey = "CONTRACT_ID"
                End If
            ElseIf SearchIn.GetItemText(SearchIn.SelectedItem) = "Invoices" Then
                SelectedTable = GlobalVars.tbl_INVOICES
                If SearchBy.GetItemText(SearchBy.SelectedItem) = "Property ID" Then
                    SelectedKey = "PROPERTY_ID"
                ElseIf SearchBy.GetItemText(SearchBy.SelectedItem) = "Contract ID" Then
                    SelectedKey = "LINKED_CONTRACT_ID"
                ElseIf SearchBy.GetItemText(SearchBy.SelectedItem) = "Invoice ID" Then
                    SelectedKey = "INVOICE_ID"
                End If
            Else
                SelectedTable = Nothing
                SelectedKey = Nothing
            End If

            Dim sqlQuery As String = "SELECT * FROM " & SelectedTable & " WHERE " & SelectedKey & " LIKE '%" & SearchText.Text & "%' "
            Dim da As New MySqlDataAdapter(sqlQuery, GlobalVars.cn)
            Dim ds As New DataSet()

            Try
                da.Fill(ds)
                Dim dt As New DataTable("Search")
                da.Fill(dt)
                SearchGrid.DataSource = dt
            Catch ex As Exception
                ParentMdiForm.Status.Text = "Failed to recieve search data!"
                ParentMdiForm.progressBar.Visible = False
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                SearchBtn.Enabled = True
            Finally
                ParentMdiForm.Status.Text = "Done."
                ParentMdiForm.progressBar.Visible = False
                SearchBtn.Enabled = True
                If SearchGrid.RowCount > 0 And SearchIn.GetItemText(SearchIn.SelectedItem) = "Contracts" Then
                    ViewBtn.Text = "View Contract"
                    ViewBtn.Visible = True
                    ViewPropertyBtn.Enabled = True
                ElseIf SearchGrid.RowCount > 0 And SearchIn.GetItemText(SearchIn.SelectedItem) = "Invoices" Then
                    ViewBtn.Text = "View Invoice"
                    ViewBtn.Visible = True
                    ViewPropertyBtn.Enabled = True
                ElseIf SearchGrid.RowCount > 0 And SearchIn.GetItemText(SearchIn.SelectedItem) = "Properties" Then
                    ViewPropertyBtn.Enabled = True
                    ViewBtn.Visible = False
                Else
                    ViewBtn.Visible = False
                    ViewPropertyBtn.Enabled = False
                End If
            End Try
            End If
    End Sub

    Private Sub sqlSearch_Thread()
        SearchData()
    End Sub
    Private Sub SearchBtn_Click(sender As Object, e As EventArgs) Handles SearchBtn.Click
        SearchBtn.Enabled = False
        SearchThread = New Thread(AddressOf sqlSearch_Thread)
        SearchThread.IsBackground = True
        SearchThread.Start()
    End Sub

    Private Sub ViewPropertyBtn_Click(sender As Object, e As EventArgs) Handles ViewPropertyBtn.Click
        If IsNothing(SearchGrid.CurrentRow) = False And GlobalVars.isOpen("Property Details - " & SearchGrid.CurrentRow.Cells.Item(1).Value.ToString) = False Then
            Dim form As New DetailsForm
            form.Id = SearchGrid.CurrentRow.Cells.Item(0).Value
            form.MdiParent = ParentMdiForm
            form.Show()
        End If
    End Sub

    Private Sub ViewBtn_Click(sender As Object, e As EventArgs) Handles ViewBtn.Click
        If IsNothing(SearchGrid.CurrentRow) = False And GlobalVars.isOpen("Contract - " & SearchGrid.CurrentRow.Cells.Item(0).Value.ToString) = False Then
            Dim form As New ContractForm
            form.Company = SearchGrid.CurrentRow.Cells.Item(2).Value.ToString
            form.Id = SearchGrid.CurrentRow.Cells.Item(0).Value.ToString
            form.Contract_ID = SearchGrid.CurrentRow.Cells.Item(1).Value.ToString
            form.ViewContract = True
            form.MdiParent = ParentMdiForm
            form.Show()
        End If
    End Sub

    Private Sub SearchForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        SearchIn.SelectedItem = SearchIn.Items(0)
        SearchBy.SelectedItem = SearchBy.Items(0)
    End Sub
End Class