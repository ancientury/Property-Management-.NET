Imports System.Windows.Forms
Imports System.Data
Imports MySql.Data.MySqlClient
Imports System.Threading

Public Class LinkContractForm
    Public Id As String
    Private ContractsThread As Thread
    Private Sub ReadContractsData()
        If Me.InvokeRequired Then
            Me.Invoke(New MethodInvoker(AddressOf ReadContractsData))
        Else

            Dim sqlQuery As String = "SELECT CONTRACT_ID, CONTRACT_NAME, START_DATE, END_DATE, PAYMENT_TYPE, PAYMENT_METHOD, CONTRACT_FEE FROM " & GlobalVars.tbl_CONTRACTS & " WHERE PROPERTY_ID  = '" & Id & "'"
            Dim da As New MySqlDataAdapter(sqlQuery, GlobalVars.cn)
            Dim ds As New DataSet()

            Try
                da.Fill(ds)
                Dim dt As New DataTable("Contracts")
                da.Fill(dt)
                ContractsGrid.DataSource = dt
            Catch ex As Exception
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If
    End Sub
    Private Sub ReadContracts()
        ContractsThread = New Thread(AddressOf sqlContracts_Thread)
        ContractsThread.IsBackground = True
        ContractsThread.Start()
    End Sub

    Private Sub sqlContracts_Thread()
        ReadContractsData()
    End Sub
    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.Close()
    End Sub

    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub

    Private Sub LinkContract_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ReadContracts()
    End Sub

    Private Sub Refresh2Btn_Click(sender As Object, e As EventArgs) Handles Refresh2Btn.Click
        ReadContracts()
    End Sub
End Class
