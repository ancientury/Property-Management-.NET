Imports System.Data
Imports MySql.Data.MySqlClient
Imports System.IO
Imports System.Threading

Public Class InvoiceForm
    Public Id, Invoice_ID, Contract_ID, Company, Address As String
    Public EditMode, NewRecord As Boolean
    Private DocPath, tempPath As String
    Private DocsThread As Thread
    Private Sub ReadDocs()
        DocsThread = New Thread(AddressOf sqlDocs_Thread)
        DocsThread.IsBackground = True
        DocsThread.Start()
    End Sub
    Private Sub DeleteDocs()
        DocsThread = New Thread(AddressOf sqlDelDocs_Thread)
        DocsThread.IsBackground = True
        DocsThread.Start()
    End Sub
    Private Sub sqlDocs_Thread()
        ReadDocsData()
    End Sub
    Private Sub sqlDelDocs_Thread()
        DeleteDocsData()
    End Sub
    Private Sub ReadDocsData()
        If Me.InvokeRequired Then
            Me.Invoke(New MethodInvoker(AddressOf ReadDocsData))
        Else
            Dim cmd As New MySqlCommand("Select DOC_FILE, FILENAME, DATE_ADDED From " & GlobalVars.tbl_DOCS & " WHERE INVOICE_ID = @Invoice_ID", GlobalVars.cn)
            cmd.Parameters.AddWithValue("@Invoice_ID", Invoice_ID)
            tempPath = System.IO.Path.GetTempPath + "doc" + Invoice_ID + ".pdf"

            Using dr As MySqlDataReader = cmd.ExecuteReader()
                If dr.Read() Then
                    Dim fs As IO.FileStream = New IO.FileStream(tempPath, IO.FileMode.Create)
                    Dim b() As Byte = dr.Item("DOC_FILE")
                    fs.Write(b, 0, b.Length)
                    fs.Close()
                    Dim vals(1) As String
                    Dim itms As ListViewItem
                    vals(0) = dr.Item("FILENAME").ToString
                    vals(1) = dr.Item("DATE_ADDED").ToString
                    itms = New ListViewItem(vals)
                    DocView.Items.Add(itms)
                    DocumentBrowser.Navigate(tempPath)
                Else
                    My.Resources._1366598510_X.Save(System.IO.Path.GetTempPath + "blank.png")
                    DocumentBrowser.Navigate(System.IO.Path.GetTempPath + "blank.png")
                End If
            End Using
        End If
    End Sub
    Private Sub DeleteDocsData()
        If Me.InvokeRequired Then
            Me.Invoke(New MethodInvoker(AddressOf DeleteDocsData))
        Else
            Dim sqlQuery As String = "DELETE FROM " & GlobalVars.tbl_DOCS & " WHERE INVOICE_ID = @Invoice_ID "
            Dim cmd As MySqlCommand
            cmd = New MySqlCommand(sqlQuery, GlobalVars.cn)
            cmd.Parameters.AddWithValue("@Invoice_ID", Invoice_ID)
            Try
                cmd.ExecuteNonQuery()
                DocView.Items.Clear()
            Catch ex As Exception
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If
    End Sub
    Private Sub AttachBtn_Click(sender As Object, e As EventArgs) Handles AttachBtn.Click

        If DocView.Items.Count >= 1 Then
            If MessageBox.Show(Me, "Are you sure you want to REMOVE this document from this invoice?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) = Windows.Forms.DialogResult.Yes Then
                My.Resources._1366598510_X.Save(System.IO.Path.GetTempPath + "blank.png")
                DocumentBrowser.Navigate(System.IO.Path.GetTempPath + "blank.png")
                DeleteDocs()
                AttachBtn.Image = ImageList1.Images.Item(0)
                AttachBtn.Text = "Attach Document"
            End If
        Else
            BrowseFile.Filter = "PDF files (*.pdf)|*.pdf|DOC files (*.doc)|*.doc|DOCX files (*.docx)|*.docx|XLSM files (*.xlsm)|*.xlsm|XLTX (*.xltx)|*.xltx|XLTM (*.xltm)|*.xltm"
            If BrowseFile.ShowDialog = DialogResult.OK Then
                DocPath = BrowseFile.FileName
                Dim vals(1) As String
                Dim itms As ListViewItem
                vals(0) = Path.GetFileName(DocPath)
                vals(1) = DateTime.Now.ToString("yyyy-MM-dd")
                itms = New ListViewItem(vals)
                DocView.Items.Add(itms)
                DocumentBrowser.Navigate(BrowseFile.FileName)
                AttachBtn.Image = ImageList1.Images.Item(1)
                AttachBtn.Text = "Detach Document"
            End If
        End If
    End Sub

    Private Sub InvoiceForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If Invoice_ID = "" Then
            Header.Text = Company & vbNewLine & Address & vbNewLine & "Property ID: " & Id
            Invoice_ID = "OUREF-" & GlobalVars.randomID
            InvoiceRef.Text = Invoice_ID
            Me.Text = "New Invoice - " & Invoice_ID
            EditMode = True
            NewRecord = True
            EditBtn_Click(Nothing, Nothing)
            EditBtn.Visible = False
            CancelBtn.Visible = True
        Else
            Me.Text = "Invoice - " & Invoice_ID
            Header.Text = Company & vbNewLine & Address & vbNewLine & "Property ID: " & Id
            ReadDocs()
            Dim cmd As New MySqlCommand("SELECT * FROM " & GlobalVars.tbl_INVOICES & " WHERE PROPERTY_ID = '" & Id & "' AND INVOICE_ID = '" & Invoice_ID & "' ", GlobalVars.cn)

            Using dr As MySqlDataReader = cmd.ExecuteReader()
                If dr.Read() Then
                    InvoiceRef.Text = dr.Item("INVOICE_ID").ToString
                    InvoiceType.Text = dr.Item("INVOICE_TYPE").ToString
                    InvoiceCompany.Text = dr.Item("COMPANY").ToString
                    PaymentType.Text = dr.Item("PAYMENT_TYPE").ToString
                    PaymentMethod.Text = dr.Item("PAYMENT_METHOD").ToString
                    Amount.Text = dr.Item("PAYMENT_AMOUNT").ToString
                    PaymentStatus.Text = dr.Item("PAYMENT_STATUS").ToString
                    PaymentDate.Text = dr.Item("PAYMENT_DATE").ToString
                    Contract.Text = dr.Item("LINKED_CONTRACT").ToString
                    ContactNumber.Text = dr.Item("CONTACT_NUMBER").ToString
                    Comments.Text = dr.Item("COMMENTS").ToString
                    EditMode = False
                    NewRecord = False
                    EditBtn_Click(Nothing, Nothing)
                End If
            End Using
        End If
    End Sub

    Private Sub ScanBtn_Click(sender As Object, e As EventArgs) Handles ScanBtn.Click
        Dim WinDir As String
        WinDir = Environment.GetFolderPath(Environment.SpecialFolder.System)
        Process.Start(WinDir + "\wiaacmgr.exe")
    End Sub

    Private Sub LinkBtn_Click(sender As Object, e As EventArgs) Handles LinkBtn.Click
        If EditMode = False Then
            LinkContractForm.Id = Id
            If LinkContractForm.ShowDialog() = Windows.Forms.DialogResult.OK Then
                Contract.Text = "Contract by " & LinkContractForm.ContractsGrid.CurrentRow.Cells(1).Value.ToString & " - " & LinkContractForm.ContractsGrid.CurrentRow.Cells(0).Value.ToString
            End If
        Else
            Dim form As New ContractForm
            Dim strArr() As String = Contract.Text.Split("-")
            If GlobalVars.isOpen("Contract - " & strArr(strArr.Length - 1).Trim()) = False Then
                form.Id = Id
                form.Company = Company
                form.Address = Address
                form.Contract_ID = strArr(strArr.Length - 1).Trim()
                form.ViewContract = True
                form.Show()
            End If
        End If
    End Sub

    Private Sub OkBtn_Click(sender As Object, e As EventArgs) Handles OkBtn.Click
        If EditMode = False Then

            If NewRecord = False And SettingsINI.ReadINIValue("Prompts", "AskBeforeModifyingInvoices").Equals("Yes") Then
                If MessageBox.Show("Are you sure you want to modify this invoice?.", "Prompt", MessageBoxButtons.YesNo, MessageBoxIcon.Information) = Windows.Forms.DialogResult.No Then
                    Exit Sub
                End If
            End If


            If InvoiceType.SelectedIndex < 0 Then
                GoTo Invalid
            End If
            If InvoiceCompany.TextLength < 1 Then
                GoTo Invalid
            End If
            If PaymentType.SelectedIndex < 0 Then
                GoTo Invalid
            End If
            If PaymentMethod.SelectedIndex < 0 Then
                GoTo Invalid
            End If
            If PaymentStatus.SelectedIndex < 0 Then
                GoTo Invalid
            End If


            GoTo Valid

Invalid:
            MessageBox.Show("You must fill in all required fields before proceeding.", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub

Valid:

            EditBtn_Click(Nothing, Nothing)

            Dim dObj = CDate(PaymentDate.Value)
            Dim dte As String
            dte = Format(dObj, "yyyyMMdd")

            Dim sqlQuery As String = "REPLACE INTO " & GlobalVars.tbl_INVOICES & " VALUES(@Id, @Username, @InvoiceID, @InvoiceDate, @InvoiceType, @InvoiceCompany, @PaymentType, @PaymentMethod, @PaymentAmount, @PaymentStatus, @PaymentDate, @ContactNumber, @Comments, @Contract) "

            Dim cmd As MySqlCommand
            cmd = New MySqlCommand(sqlQuery, GlobalVars.cn)
            cmd.Parameters.AddWithValue("@Id", Id)
            cmd.Parameters.AddWithValue("@Username", GlobalVars.Username)
            cmd.Parameters.AddWithValue("@InvoiceID", Invoice_ID)
            cmd.Parameters.AddWithValue("@InvoiceDate", Date.Now.ToString("yyyy-MM-dd"))
            cmd.Parameters.AddWithValue("@InvoiceType", InvoiceType.Text)
            cmd.Parameters.AddWithValue("@InvoiceCompany", InvoiceCompany.Text)
            cmd.Parameters.AddWithValue("@PaymentType", PaymentType.Text)
            cmd.Parameters.AddWithValue("@PaymentMethod", PaymentMethod.Text)
            cmd.Parameters.AddWithValue("@PaymentAmount", Amount.Value)
            cmd.Parameters.AddWithValue("@PaymentStatus", PaymentStatus.Text)
            cmd.Parameters.AddWithValue("@PaymentDate", dte)
            cmd.Parameters.AddWithValue("@ContactNumber", ContactNumber.Text)
            cmd.Parameters.AddWithValue("@Comments", Comments.Text)
            cmd.Parameters.AddWithValue("@Contract", Contract.Text)
            Try
                cmd.ExecuteNonQuery()
                OkBtn.Text = "OK"
            Catch ex As Exception
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try

            If DocView.Items.Count > 0 Then
                If IsNothing(DocPath) = False Then
                    sqlQuery = "REPLACE INTO " & GlobalVars.tbl_DOCS & " VALUES(@Id, @Invoice_ID, @Doc,  @Filename, @DateAdded) "

                    Dim Doc As Byte() = File.ReadAllBytes(DocPath)

                    cmd = New MySqlCommand(sqlQuery, GlobalVars.cn)
                    cmd.Parameters.AddWithValue("@Id", Id)
                    cmd.Parameters.AddWithValue("@Invoice_ID", Invoice_ID)
                    cmd.Parameters.AddWithValue("@Doc", Doc)
                    cmd.Parameters.AddWithValue("@Filename", DocView.Items(0).SubItems(0).Text)
                    cmd.Parameters.AddWithValue("@DateAdded", DocView.Items(0).SubItems(1).Text)

                    Try
                        cmd.ExecuteNonQuery()
                        OkBtn.Text = "OK"
                    Catch ex As Exception
                        MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End Try
                End If
            End If
            If NewRecord = True Then
                Using _comm As New MySqlCommand()
                    With _comm
                        .Connection = GlobalVars.cn
                        .CommandText = "UPDATE " & GlobalVars.tbl_PROPERTIES & " SET TOTAL_INVOICES = TOTAL_INVOICES+1 WHERE PROPERTY_ID = '" & Id & "' "
                    End With
                    _comm.ExecuteNonQuery()
                End Using
                Me.Close()
            End If
        Else
            Me.Close()
        End If
    End Sub

    Private Sub EditBtn_Click(sender As Object, e As EventArgs) Handles EditBtn.Click
        Select Case EditMode
            Case True
                InvoiceType.Enabled = True
                InvoiceCompany.ReadOnly = False
                PaymentType.Enabled = True
                PaymentMethod.Enabled = True
                Amount.ReadOnly = False
                PaymentStatus.Enabled = True
                PaymentDate.Enabled = True
                LinkBtn.Enabled = True
                LinkBtn.Text = "Link Contract"
                ContactNumber.ReadOnly = False
                Comments.ReadOnly = False
                If DocView.Items.Count < 1 Then
                    AttachBtn.Image = ImageList1.Images.Item(0)
                    AttachBtn.Text = "Attach Document"
                Else
                    AttachBtn.Image = ImageList1.Images.Item(1)
                    AttachBtn.Text = "Detach Document"
                End If
                EditBtn.Text = "Cancel Changes"
                OkBtn.Text = "Save Changes"
                ScanBtn.Visible = True
                AttachBtn.Visible = True
                DeleteBtn.Visible = True
                EditMode = False
            Case False
                InvoiceType.Enabled = False
                InvoiceCompany.ReadOnly = True
                PaymentType.Enabled = False
                PaymentMethod.Enabled = False
                Amount.ReadOnly = True
                PaymentStatus.Enabled = False
                PaymentDate.Enabled = False
                If Contract.Text = "None" Then
                    LinkBtn.Enabled = False
                Else
                    LinkBtn.Text = "View Contract"
                End If
                ContactNumber.ReadOnly = True
                Comments.ReadOnly = True
                ScanBtn.Visible = False
                EditBtn.Text = "Edit"
                OkBtn.Text = "OK"
                AttachBtn.Visible = False
                DeleteBtn.Visible = False
                EditMode = True
        End Select
    End Sub

    Private Sub Type_DropDownClosed(sender As Object, e As EventArgs) Handles InvoiceType.SelectionChangeCommitted
        If InvoiceType.SelectedIndex = 1 Then
            LinkBtn.Enabled = True
            If MessageBox.Show(Me, "Would you like to link this invoice to a contract?", "Contract", MessageBoxButtons.YesNo, MessageBoxIcon.Information) = Windows.Forms.DialogResult.Yes Then
                LinkContractForm.Id = Id
                If LinkContractForm.ShowDialog() = Windows.Forms.DialogResult.OK Then
                    Contract.Text = "Contract by " & LinkContractForm.ContractsGrid.CurrentRow.Cells.Item(1).Value.ToString & " - " & LinkContractForm.ContractsGrid.CurrentRow.Cells.Item(0).Value.ToString
                    PaymentMethod.SelectedIndex = 1
                Else
                    Contract.Text = "None"
                    InvoiceType.SelectedIndex = -1
                    LinkBtn.Enabled = False
                    PaymentMethod.SelectedIndex = -1
                End If
            Else
                Contract.Text = "None"
                InvoiceType.SelectedIndex = -1
                LinkBtn.Enabled = False
            End If
        Else
            Contract.Text = "None"
        End If
    End Sub

    Private Sub DeleteBtn_Click(sender As Object, e As EventArgs) Handles DeleteBtn.Click
        If SettingsINI.ReadINIValue("Prompts", "AskBeforeDeletingInvoices").Equals("Yes") Then
            If MessageBox.Show("Are you sure you want to DELETE this invoice from this property?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) = MsgBoxResult.No Then
                Exit Sub
            End If
        End If

        Dim sqlQuery As String = "DELETE FROM " & GlobalVars.tbl_INVOICES & " WHERE PROPERTY_ID  = '" & Id & "' AND INVOICE_ID = '" & Invoice_ID & "'"
        Dim cmd As MySqlCommand
        cmd = New MySqlCommand(sqlQuery, GlobalVars.cn)
        Try
            cmd.ExecuteNonQuery()
            Using _comm As New MySqlCommand()
                With _comm
                    .Connection = GlobalVars.cn
                    .CommandText = "UPDATE " & GlobalVars.tbl_PROPERTIES & " SET TOTAL_INVOICES = TOTAL_INVOICES-1 WHERE PROPERTY_ID = '" & Id & "' "
                End With
                _comm.ExecuteNonQuery()
            End Using
            Me.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub Amount_KeyPress(sender As Object, e As KeyPressEventArgs)
        If Char.IsControl(e.KeyChar) = False Then
            If Char.IsDigit(e.KeyChar) Or e.KeyChar = "." Then
                If Amount.Text.Contains(".") Then
                    If Amount.Text.Split(".")(1).Length < 2 Then
                        If Char.IsDigit(e.KeyChar) = False Then
                            e.Handled = True
                        End If
                    Else
                        e.Handled = True
                    End If
                End If
            Else
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub ContactNumber_KeyPress(sender As Object, e As KeyPressEventArgs)
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub PaymentMethod_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles PaymentMethod.SelectionChangeCommitted
        If PaymentMethod.SelectedIndex = 0 Then
            InvoiceType.SelectedIndex = 0
        End If
    End Sub

    Private Sub InvoiceForm_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        DetailsForm.ReadInvoices()
    End Sub
End Class