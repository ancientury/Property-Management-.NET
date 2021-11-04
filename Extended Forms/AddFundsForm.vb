Imports MySql.Data.MySqlClient

Public Class AddFundsForm
    Public Id As String
    Private Sub OkBtn_Click(sender As Object, e As EventArgs) Handles OkBtn.Click
        If Amount.Value = ConfirmAmount.Value And Amount.Value <> 0.0 Then

            If PaymentType.SelectedIndex < 0 Then
                GoTo Invalid
            End If
            If FundSource.TextLength < 1 Then
                GoTo Invalid
            End If


            GoTo Valid

Invalid:
            MessageBox.Show("You must fill in all required fields before proceeding.", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub

Valid:
            Try
                Dim sqlQuery As String = "REPLACE INTO " & GlobalVars.tbl_INVOICES & " VALUES(@Id, @Username, @InvoiceID, @InvoiceDate, @InvoiceType, @InvoiceCompany, @PaymentType, @PaymentMethod, @PaymentAmount, @PaymentStatus, @PaymentDate, @ContactNumber, @Comments, @Contract) "


                Dim dte As Date = Format("yyyy-MM-dd", CurrentDate.Text)
                Dim cmd As MySqlCommand
                cmd = New MySqlCommand(sqlQuery, GlobalVars.cn)
                cmd.Parameters.AddWithValue("@Id", Id)
                cmd.Parameters.AddWithValue("@Username", GlobalVars.Username)
                cmd.Parameters.AddWithValue("@InvoiceID", "FUND-" & GlobalVars.randomID)
                cmd.Parameters.AddWithValue("@InvoiceDate", dte)
                cmd.Parameters.AddWithValue("@InvoiceType", "Fund Transfer")
                cmd.Parameters.AddWithValue("@InvoiceCompany", "Check Fund Source")
                cmd.Parameters.AddWithValue("@PaymentType", PaymentType.Text)
                cmd.Parameters.AddWithValue("@PaymentMethod", "")
                cmd.Parameters.AddWithValue("@PaymentAmount", Amount.Value)
                cmd.Parameters.AddWithValue("@PaymentStatus", "Paid")
                cmd.Parameters.AddWithValue("@PaymentDate", dte)
                cmd.Parameters.AddWithValue("@ContactNumber", "")
                cmd.Parameters.AddWithValue("@Comments", FundSource.Text)
                cmd.Parameters.AddWithValue("@Contract", "None")

                cmd.ExecuteNonQuery()
                Me.DialogResult = Windows.Forms.DialogResult.OK

            Catch ex As Exception
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Finally
                Me.Close()
            End Try
        Else
            MessageBox.Show("Please confirm the amount you want to add!", "Confirm", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If
    End Sub

    Private Sub AddFundsForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class