Imports GemBox.Spreadsheet
Imports GemBox.Spreadsheet.WinFormsUtilities
Imports System.Data.SqlClient
Imports System.Threading

Public Class MainForm

    Private PropertiesThread As System.Threading.Thread

    Public Sub New()
        SpreadsheetInfo.SetLicense("FREE-LIMITED-KEY")
        InitializeComponent()
    End Sub


    Public Sub ReadProperties()
        PropertiesThread = New Thread(AddressOf ReadPropertiesData)
        PropertiesThread.IsBackground = True
        PropertiesThread.Start()
    End Sub

    Private Sub ReadPropertiesData()
        If Me.InvokeRequired Then
            Me.Invoke(New MethodInvoker(AddressOf ReadPropertiesData))
        Else
            ParentMdiForm.Status.Text = "Retrieving data..."
            ParentMdiForm.progressBar.Visible = True

            Dim query As String = "SELECT id, company, address, county, city, postcode, telephone FROM properties"

            Dim cnn As SqlConnection = New SqlConnection(GlobalVars.connectionString)
            Dim cmd As SqlCommand = New SqlCommand(query, cnn)

            Dim da As SqlDataAdapter = New SqlDataAdapter(cmd)
            Dim ds As DataSet = New DataSet()

            Try
                da.Fill(ds)

                Dim dt As New DataTable("Properties")
                da.Fill(dt)
                dt.Columns("id").ColumnName = "Property ID"
                dt.Columns("company").ColumnName = "Company"
                dt.Columns("address").ColumnName = "Address"
                dt.Columns("county").ColumnName = "County"
                dt.Columns("city").ColumnName = "City"
                dt.Columns("postcode").ColumnName = "Postcode"
                dt.Columns("telephone").ColumnName = "Telephone"
                DataGrid.DataSource = dt

            Catch ex As Exception
                ParentMdiForm.Status.Text = "Failed to recieve data!"
                ParentMdiForm.progressBar.Visible = False
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Finally
                ParentMdiForm.Status.Text = "Done."
                ParentMdiForm.progressBar.Visible = False
                DataGrid.Enabled = True
                RefreshBtn.Enabled = True
            End Try
        End If
    End Sub


    Private Sub DataGrid_CellMouseDown(sender As Object, e As DataGridViewCellMouseEventArgs)
        If e.ColumnIndex >= 0 And e.RowIndex >= 0 Then
            DataGrid.CurrentCell = DataGrid.Rows(e.RowIndex).Cells(e.ColumnIndex)
        End If
    End Sub

    Private Sub DataGrid_CellMouseDoubleClick(ByVal sender As Object, ByVal e As DataGridViewCellMouseEventArgs) Handles DataGrid.CellMouseDoubleClick
        If IsNothing(DataGrid.CurrentRow) = False And GlobalVars.isOpen("Property Details - " & DataGrid.CurrentRow.Cells.Item(1).Value.ToString) = False Then
            Dim form As New DetailsForm
            form.Id = DataGrid.CurrentRow.Cells.Item(0).Value
            form.MdiParent = ParentMdiForm
            Me.WindowState = FormWindowState.Normal
            form.WindowState = FormWindowState.Normal
            form.Show()
        End If
    End Sub

    Private Sub RefreshPropertiesToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles RefreshStripMenuItem.Click
        ReadProperties()
    End Sub

    Private Sub RefreshBtn_Click(ByVal sender As Object, ByVal e As EventArgs) Handles RefreshBtn.Click
        DataGrid.Enabled = False
        RefreshBtn.Enabled = False
        ReadProperties()
    End Sub

    Private Sub AddBtn_Click(ByVal sender As Object, ByVal e As EventArgs) Handles AddBtn.Click
        Dim form As New DetailsForm
        form.NewRecord = True
        form.MdiParent = ParentMdiForm
        form.Show()
    End Sub

    Private Sub ManageBtn_Click(ByVal sender As Object, ByVal e As EventArgs) Handles ManageBtn.Click
        If DataGrid.CurrentRow.Selected And GlobalVars.isOpen("Property Details - " & DataGrid.CurrentRow.Cells.Item(1).Value) = False Then
            Dim form As New DetailsForm
            form.Id = DataGrid.CurrentRow.Cells.Item(0).Value
            form.MdiParent = ParentMdiForm
            form.Show()
        End If
    End Sub

    Private Sub ExportBtn_Click(ByVal sender As Object, ByVal e As EventArgs) Handles ExportBtn.Click
        ExportMenu.Show(ExportBtn, 0, ExportBtn.Height)
    End Sub

    Private Sub ExportToExcelToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles ExportToExcelToolStripMenuItem.Click
        Dim dgv As DataGridView = DataGrid
        Dim saveFileDialog = New SaveFileDialog()
        saveFileDialog.Filter = "XLS files (*.xls)|*.xls|XLT files (*.xlt)|*.xlt|XLSX files (*.xlsx)|*.xlsx|XLSM files (*.xlsm)|*.xlsm|XLTX (*.xltx)|*.xltx|XLTM (*.xltm)|*.xltm"
        saveFileDialog.FilterIndex = 3
        If (saveFileDialog.ShowDialog() = DialogResult.OK) Then
            Dim ef = New ExcelFile()
            Dim ws = ef.Worksheets.Add("Sheet")
            DataGridViewConverter.ImportFromDataGridView(ws, DataGrid, New ImportFromDataGridViewOptions() With {.ColumnHeaders = True})
            ef.Save(saveFileDialog.FileName)
            MessageBox.Show("Exported to Excel: " & saveFileDialog.FileName, "Done!", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub ExportToCSVToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles ExportToCSVToolStripMenuItem.Click
        Dim dgv As DataGridView = DataGrid
        Dim saveFileDialog = New SaveFileDialog()
        saveFileDialog.Filter = "CSV (*.csv)|*.csv"
        saveFileDialog.FilterIndex = 1
        If (saveFileDialog.ShowDialog() = DialogResult.OK) Then
            Dim ef = New ExcelFile()
            Dim ws = ef.Worksheets.Add("Sheet")
            DataGridViewConverter.ImportFromDataGridView(ws, DataGrid, New ImportFromDataGridViewOptions() With {.ColumnHeaders = True})
            ef.Save(saveFileDialog.FileName)
            MessageBox.Show("Exported to CSV: " & saveFileDialog.FileName, "Done!", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub MainForm_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
        ReadProperties()
    End Sub

    Private Sub DataGrid_RowsAdded(ByVal sender As Object, ByVal e As DataGridViewRowsAddedEventArgs) Handles DataGrid.RowsAdded
        ManageBtn.Enabled = True
        DataGridMenu.Items.Item(0).Enabled = True
        DataGridMenu.Items.Item(1).Enabled = True
    End Sub

    Private Sub DataGrid_RowsRemoved(ByVal sender As Object, ByVal e As DataGridViewRowsRemovedEventArgs)
        If IsNothing(DataGrid.CurrentRow) = False Then
            ManageBtn.Enabled = True
            DataGridMenu.Items.Item(0).Enabled = True
            DataGridMenu.Items.Item(1).Enabled = True
        Else
            ManageBtn.Enabled = False
            DataGridMenu.Items.Item(0).Enabled = False
            DataGridMenu.Items.Item(1).Enabled = False
        End If
    End Sub


    Private Sub AddStripMenuItem_Click(sender As Object, e As EventArgs) Handles AddStripMenuItem.Click
        Dim form As New DetailsForm
        form.Id = ""
        form.MdiParent = ParentMdiForm
        form.Show()
    End Sub

    Private Sub MainTabControl_Click(sender As Object, e As EventArgs) Handles MainTabControl.Click
        Me.Text = MainTabControl.SelectedTab.Text
    End Sub

    Private Sub SearchBtn_Click(sender As Object, e As EventArgs) Handles SearchBtn.Click
        QuickSearchForm.sForm = "Properties"
        QuickSearchForm.ShowDialog()
    End Sub
End Class
