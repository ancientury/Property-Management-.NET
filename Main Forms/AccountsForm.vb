Imports MySql.Data.MySqlClient
Imports System.Threading
Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.Shared

Public Class AccountsForm
    Public Id As String
    Private InvoicesThread As Thread
    Private dt As DataTable
    Private FundSourceText As String
    Private isPaidIn, ForwardedBalance As Boolean
    Public Sub ReadInvoices()
        InvoicesThread = New Thread(AddressOf sqlInvoices_Thread)
        InvoicesThread.IsBackground = True
        InvoicesThread.Start()
    End Sub

    Private Sub sqlInvoices_Thread()
        ReadInvoicesData()
    End Sub

    Private Sub ReadInvoicesData()
        If Me.InvokeRequired Then
            Me.Invoke(New MethodInvoker(AddressOf ReadInvoicesData))
        Else
            Dim strArr() As String = PropertyNameCombo.Text.Split("-")
            Id = strArr(strArr.Length - 1).Trim()

            LatestPayedIn.Text = "0.00"
            Balance.Text = "0.00"
            PayedIn.Text = "0.00"
            PayedOut.Text = "0.00"
            ClosingBalance.Text = "0.00"
            UnpaidBalance.Text = "0.00"
            CalcNote.Visible = True
            CalcNote2.Visible = True

            Dim Date1 As Date = Date.ParseExact(FromDate.Text, "dd/MM/yyyy", System.Globalization.DateTimeFormatInfo.InvariantInfo)
            Dim Date2 As Date = Date.ParseExact(ToDate.Text, "dd/MM/yyyy", System.Globalization.DateTimeFormatInfo.InvariantInfo)
            Dim backwardDte As Date = date1
            Dim forwardDte As Date = Format("yyyy-MM-dd", Date2.AddDays(-1))

            ' Balance Brought forward
            Dim cmd As MySqlCommand
            cmd = New MySqlCommand("SELECT * FROM " & GlobalVars.tbl_ACCOUNTS & " WHERE PROPERTY_ID = '" & Id & "' ORDER BY DATE DESC ", GlobalVars.cn)

            Using dr As MySqlDataReader = cmd.ExecuteReader()
                While dr.Read()
                    If dr.Item("DATE") <= Date1 Then
                        Balance.Text = dr.Item("CLOSING_BALANCE")
                        ClosingBalance.Text = dr.Item("CLOSING_BALANCE")
                        backwardDte = Format("yyyy-MM-dd", dr.Item("DATE"))
                        ForwardedBalance = True
                        Exit While
                    End If
                End While
            End Using

            If ForwardedBalance = True Then
                ' Bring date of forwarded balance
                cmd = New MySqlCommand("SELECT PAYMENT_DATE FROM " & GlobalVars.tbl_INVOICES & " WHERE PROPERTY_ID = '" & Id & "' ORDER BY PAYMENT_DATE DESC ", GlobalVars.cn)

                Using dr As MySqlDataReader = cmd.ExecuteReader()
                    While dr.Read()
                        If dr.Item("PAYMENT_DATE") <= backwardDte Then
                            backwardDte = Format("yyyy-MM-dd", dr.Item("PAYMENT_DATE"))
                            Exit While
                        End If
                    End While
                End Using
            End If


            Dim sqlQuery, PaymentStatus As String
            If ShowPaidChkBox.Checked = True And ShowUnpaidChkBox.Checked = True Then
                PaymentStatus = ""
            ElseIf ShowPaidChkBox.Checked = True Then
                PaymentStatus = "AND PAYMENT_STATUS = 'Paid'"
            ElseIf ShowUnpaidChkBox.Checked = True Then
                PaymentStatus = "AND PAYMENT_STATUS = 'Unpaid'"
            Else
                PaymentStatus = "AND PAYMENT_STATUS = 'N/A'"
            End If

            sqlQuery = "SELECT PAYMENT_DATE, PAYMENT_STATUS, PAYMENT_TYPE, INVOICE_ID, COMPANY, INVOICE_TYPE, COMMENTS, INVOICE_DATE, PAYMENT_AMOUNT FROM " & GlobalVars.tbl_INVOICES & " WHERE PROPERTY_ID  = '" & Id & "' AND PAYMENT_DATE BETWEEN '" & backwardDte.ToString("yyyy-MM-dd") & "' AND '" & Date2.ToString("yyyy-MM-dd") & "' " & PaymentStatus & " ORDER BY PAYMENT_DATE ASC, INVOICE_DATE ASC "
            Dim da As New MySqlDataAdapter(sqlQuery, GlobalVars.cn)
            Dim ds As New DataSet()

            Try
                da.Fill(ds)
                dt = New DataTable("Invoices")
                da.Fill(dt)

                dt.Columns("PAYMENT_DATE").ColumnName = "Payment Date"
                dt.Columns("PAYMENT_STATUS").ColumnName = "Payment Status"
                dt.Columns("PAYMENT_TYPE").ColumnName = "Payment Type"
                dt.Columns("INVOICE_ID").ColumnName = "Invoice Ref"
                dt.Columns("COMPANY").ColumnName = "Invoice Company"
                dt.Columns("INVOICE_TYPE").ColumnName = "Invoice Type"
                dt.Columns("COMMENTS").ColumnName = "Comments"
                dt.Columns("INVOICE_DATE").ColumnName = "Invoice Date"
                dt.Columns("PAYMENT_AMOUNT").ColumnName = "Paid Out"
                dt.Columns.Add("Paid In")
                dt.Columns.Add("Balance")

                InvoicesGrid.DataSource = dt
                PaidInvoicesLabel.Text = "Paid Invoices: " & InvoicesGrid.RowCount

                For i = 0 To InvoicesGrid.RowCount - 1 Step 1
                    isPaidIn = False

                    If InvoicesGrid.Rows(i).Cells(1).Value.ToString.Equals("Unpaid") = False Then
                        If ForwardedBalance = False Then
                            If InvoicesGrid.Rows(i).Cells(3).Value.ToString.StartsWith("FUND-") = True Then
                                InvoicesGrid.Rows(i).Cells(9).Value = Format(InvoicesGrid.Rows(i).Cells(8).Value, "0.00")
                                InvoicesGrid.Rows(i).Cells(8).Value = "0.00"

                                LatestPayedIn.Text = InvoicesGrid.Rows(i).Cells(9).Value
                                FundSourceText = InvoicesGrid.Rows(i).Cells(6).Value & vbNewLine & "Date: " & InvoicesGrid.Rows(i).Cells(0).Value
                                InvoicesGrid.Rows(i).Cells(10).Value = Format(ClosingBalance.Value - InvoicesGrid.Rows(i).Cells(8).Value + InvoicesGrid.Rows(i).Cells(9).Value, "0.00")
                                isPaidIn = True
                                ClosingBalance.Text = ClosingBalance.Value + InvoicesGrid.Rows(i).Cells(9).Value
                                PayedIn.Text = PayedIn.Value + InvoicesGrid.Rows(i).Cells(9).Value
                            Else
                                InvoicesGrid.Rows(i).Cells(9).Value = "0.00"
                            End If
                            If isPaidIn = False Then
                                InvoicesGrid.Rows(i).Cells(10).Value = Format(ClosingBalance.Value - InvoicesGrid.Rows(i).Cells(8).Value + InvoicesGrid.Rows(i).Cells(9).Value, "0.00")
                            End If

                            ClosingBalance.Text = ClosingBalance.Value - InvoicesGrid.Rows(i).Cells(8).Value
                            PayedOut.Text = PayedOut.Value + InvoicesGrid.Rows(i).Cells(8).Value
                        Else
                            InvoicesGrid.Rows(i).Cells(1).Value = ""
                            InvoicesGrid.Rows(i).Cells(2).Value = "BALANCE BROUGHT FORWARD"
                            InvoicesGrid.Rows(i).Cells(3).Value = ""
                            InvoicesGrid.Rows(i).Cells(4).Value = ""
                            InvoicesGrid.Rows(i).Cells(5).Value = ""
                            InvoicesGrid.Rows(i).Cells(6).Value = ""
                            InvoicesGrid.Rows(i).Cells(7).Value = ""
                            InvoicesGrid.Rows(i).Cells(8).Value = 0.0
                            InvoicesGrid.Rows(i).Cells(9).Value = 0.0
                            InvoicesGrid.Rows(i).Cells(10).Value = Balance.Value
                        End If

                        ForwardedBalance = False

                    ElseIf InvoicesGrid.Rows(i).Cells(1).Value.ToString.Equals("Unpaid") = True Then
                        UnpaidBalance.Text = UnpaidBalance.Value + InvoicesGrid.Rows(i).Cells(8).Value
                    End If

                Next

                If InvoicesGrid.RowCount - 1 >= 0 Then
                    ' Store closing balance
                    Using _comm As New MySqlCommand()
                        With _comm
                            .Connection = GlobalVars.cn
                            .CommandText = "REPLACE INTO " & GlobalVars.tbl_ACCOUNTS & " VALUES(@Id, @Date, @ClosingBalance) "
                            .Parameters.AddWithValue("@Id", Id)
                            .Parameters.AddWithValue("@Date", forwardDte)
                            .Parameters.AddWithValue("@ClosingBalance", InvoicesGrid.Rows(InvoicesGrid.RowCount - 1).Cells(10).Value)
                        End With
                        _comm.ExecuteNonQuery()
                    End Using
                End If


                CalcNote.Visible = False
                CalcNote2.Visible = False
            Catch ex As Exception
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Finally
                AddFundsBtn.Enabled = True
            End Try
        End If
    End Sub

    Private Sub AccountsForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LatestPayedIn.ForeColor = Color.DarkGreen
        PayedOut.ForeColor = Color.Red
        LatestPayedIn.BackColor = Color.WhiteSmoke
        Balance.BackColor = Color.WhiteSmoke
        PayedIn.BackColor = Color.WhiteSmoke
        PayedOut.BackColor = Color.WhiteSmoke

        Dim cmd As MySqlCommand
        cmd = New MySqlCommand("SELECT * FROM " & GlobalVars.tbl_PROPERTIES & " ", GlobalVars.cn)

        Using dr As MySqlDataReader = cmd.ExecuteReader()
            While dr.Read()
                PropertyNameCombo.Items.Add(dr.Item("COMPANY").ToString & " - " & dr.Item("PROPERTY_ID").ToString)
            End While
        End Using

    End Sub

    Private Sub AddFundsBtn_Click(sender As Object, e As EventArgs) Handles AddFundsBtn.Click
        Dim NewFundsForm As New AddFundsForm
        NewFundsForm.Id = Id
        NewFundsForm.CurrentDate.Text = Date.Now.ToString("dd/MM/yyyy")
        If NewFundsForm.ShowDialog() = Windows.Forms.DialogResult.OK Then
            If IsDate(FromDate.Text) And IsDate(ToDate.Text) Then
                ReadInvoices()
            End If
        End If
    End Sub

    Private Sub PropertyNameCombo_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles PropertyNameCombo.SelectionChangeCommitted, ShowUnpaidChkBox.CheckedChanged, ShowPaidChkBox.CheckedChanged
        StatementTypeCombo.Enabled = True
        If IsDate(FromDate.Text) And IsDate(ToDate.Text) Then
            ReadInvoices()
        End If
    End Sub

    Private Sub StatementTypeCombo_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles StatementTypeCombo.SelectionChangeCommitted
        StatementNote.Visible = False
        YearCombo.Enabled = True
        MonthCombo.Enabled = True
        YearCombo.Text = Date.Now.Year
        MonthCombo.SelectedIndex = Date.Now.Month - 1
        PreviousBtn.Enabled = True
        NextBtn.Enabled = True
        Dim dte As New Date(Convert.ToInt32(YearCombo.Text), MonthCombo.SelectedIndex + 1, 1)
        If StatementTypeCombo.SelectedIndex = 0 Then
            FromDate.Text = dte
            ToDate.Text = dte.AddMonths(1)
        ElseIf StatementTypeCombo.SelectedIndex = 1 Then
            FromDate.Text = dte
            ToDate.Text = dte.AddMonths(3)
        ElseIf StatementTypeCombo.SelectedIndex = 2 Then
            FromDate.Text = dte
            ToDate.Text = dte.AddYears(1)
        End If
        If IsDate(FromDate.Text) And IsDate(ToDate.Text) Then
            ReadInvoices()
        End If
    End Sub

    Private Sub NextBtn_Click(sender As Object, e As EventArgs) Handles NextBtn.Click
        Dim dte As Date = Date.ParseExact(FromDate.Text, "dd/MM/yyyy", System.Globalization.DateTimeFormatInfo.InvariantInfo)
        If StatementTypeCombo.SelectedIndex = 0 Then
            FromDate.Text = dte.AddMonths(1)
            ToDate.Text = dte.AddMonths(2)
        ElseIf StatementTypeCombo.SelectedIndex = 1 Then
            FromDate.Text = dte.AddMonths(3)
            ToDate.Text = dte.AddMonths(6)
        ElseIf StatementTypeCombo.SelectedIndex = 2 Then
            FromDate.Text = dte.AddYears(1)
            ToDate.Text = dte.AddYears(2)
        End If
        If IsDate(FromDate.Text) And IsDate(ToDate.Text) Then
            ReadInvoices()
        End If
    End Sub

    Private Sub MonthCombo_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles MonthCombo.SelectionChangeCommitted
        Dim dte As New Date(Convert.ToInt32(YearCombo.Text), MonthCombo.SelectedIndex + 1, 1)
        If StatementTypeCombo.SelectedIndex = 0 Then
            FromDate.Text = dte
            ToDate.Text = dte.AddMonths(1)
        ElseIf StatementTypeCombo.SelectedIndex = 1 Then
            FromDate.Text = dte
            ToDate.Text = dte.AddMonths(3)
        ElseIf StatementTypeCombo.SelectedIndex = 2 Then
            FromDate.Text = dte
            ToDate.Text = dte.AddYears(1)
        End If
        If IsDate(FromDate.Text) And IsDate(ToDate.Text) Then
            ReadInvoices()
        End If
    End Sub

    Private Sub YearCombo_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles YearCombo.SelectionChangeCommitted
        Dim dte As New Date(Convert.ToInt32(YearCombo.Text), MonthCombo.SelectedIndex + 1, 1)
        If StatementTypeCombo.SelectedIndex = 0 Then
            FromDate.Text = dte
            ToDate.Text = dte.AddMonths(1)
        ElseIf StatementTypeCombo.SelectedIndex = 1 Then
            FromDate.Text = dte
            ToDate.Text = dte.AddMonths(3)
        ElseIf StatementTypeCombo.SelectedIndex = 2 Then
            FromDate.Text = dte
            ToDate.Text = dte.AddYears(1)
        End If
        If IsDate(FromDate.Text) And IsDate(ToDate.Text) Then
            ReadInvoices()
        End If
    End Sub

    Private Sub PreviousBtn_Click(sender As Object, e As EventArgs) Handles PreviousBtn.Click
        Dim dte As Date = Date.ParseExact(ToDate.Text, "dd/MM/yyyy", System.Globalization.DateTimeFormatInfo.InvariantInfo)
        If StatementTypeCombo.SelectedIndex = 0 Then
            FromDate.Text = dte.AddMonths(-2)
            ToDate.Text = dte.AddMonths(-1)
        ElseIf StatementTypeCombo.SelectedIndex = 1 Then
            FromDate.Text = dte.AddMonths(-6)
            ToDate.Text = dte.AddMonths(-3)
        ElseIf StatementTypeCombo.SelectedIndex = 2 Then
            FromDate.Text = dte.AddYears(-2)
            ToDate.Text = dte.AddYears(-1)
        End If
        If IsDate(FromDate.Text) And IsDate(ToDate.Text) Then
            ReadInvoices()
        End If
    End Sub

    Private Sub GenerateBtn_Click(sender As Object, e As EventArgs) Handles GenerateBtn.Click
        If InvoicesGrid.RowCount = 0 Then
            MessageBox.Show("You have no paid invoices in the date you selected!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        Else
            Dim rptDoc As ReportDocument
            rptDoc = New CrystalReport
            rptDoc.SetDataSource(dt)
            ReportForm.CrystalReportViewer1.ReportSource = rptDoc
            ReportForm.ShowDialog()
        End If
    End Sub

    Private Sub LatestPayedIn_MouseHover(sender As Object, e As EventArgs)
        If LatestPayedIn.Value <> 0.0 Then
            FundSourceBalloonTip.SetBalloonText(LatestPayedIn, FundSourceText)
            FundSourceBalloonTip.SetBalloonCaption(LatestPayedIn, "Fund Source")
            FundSourceBalloonTip.ShowBalloon(LatestPayedIn)
        End If
    End Sub

    Private Sub InvoicesGrid_CellMouseDoubleClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles InvoicesGrid.CellMouseDoubleClick
        If GlobalVars.isOpen("Invoice - " & InvoicesGrid.CurrentRow.Cells.Item(0).Value.ToString) = False And IsNothing(InvoicesGrid.CurrentRow) = False And InvoicesGrid.CurrentRow.Cells.Item(1).Value.Equals("BALANCE BROUGHT FORWARD") = False And InvoicesGrid.CurrentRow.Cells(2).Value.ToString.StartsWith("FUND-") = False Then
            Dim form As New InvoiceForm
            Dim strArr() As String = PropertyNameCombo.Text.Split("-")
            form.Company = strArr(0).Trim()
            form.Id = Id
            form.Invoice_ID = InvoicesGrid.CurrentRow.Cells.Item(2).Value.ToString
            If form.ShowDialog() Then
                ReadInvoices()
            End If
        End If
    End Sub

End Class