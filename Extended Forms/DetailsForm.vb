Imports System.Data
Imports MySql.Data.MySqlClient
Imports System.Threading
Imports System.IO
Imports System.Data.SqlClient

Public Class DetailsForm
    Public Id, SelectedAssetTable, AssetType As String
    Private totalAssets, totalContracts, totalInvoices, SelectedTab As Integer
    Public EditMode, NewRecord, CheckEdit As Boolean
    Private PhotoThread, DeleteThread, ContractsThread, ContactsThread, InvoicesThread, AssetsThread, MLogsThread As Thread

    Private Sub DeleteProperty()
        DeleteThread = New Thread(AddressOf sqlDelete_Thread)
        DeleteThread.IsBackground = True
        DeleteThread.Start()
    End Sub

    Public Sub ReadContracts()
        ContractsThread = New Thread(AddressOf sqlContracts_Thread)
        ContractsThread.IsBackground = True
        ContractsThread.Start()
    End Sub

    Public Sub ReadContacts()
        ContactsThread = New Thread(AddressOf sqlContacts_Thread)
        ContactsThread.IsBackground = True
        ContactsThread.Start()
    End Sub

    Public Sub ReadInvoices()
        InvoicesThread = New Thread(AddressOf sqlInvoices_Thread)
        InvoicesThread.IsBackground = True
        InvoicesThread.Start()
    End Sub

    Public Sub ReadMLogs()
        MLogsThread = New Thread(AddressOf sqlMLogs_Thread)
        MLogsThread.IsBackground = True
        MLogsThread.Start()
    End Sub

    Public Sub ReadAssets()
        AssetsThread = New Thread(AddressOf sqlAssets_Thread)
        AssetsThread.IsBackground = True
        AssetsThread.Start()
    End Sub

    Private Sub sqlInvoices_Thread()
        ReadInvoicesData()
    End Sub

    Private Sub sqlMLogs_Thread()
        ReadLogsData()
    End Sub

    Private Sub sqlAssets_Thread()
        ReadAssetsData()
    End Sub

    Private Sub sqlContracts_Thread()
        ReadContractsData()
    End Sub

    Private Sub sqlContacts_Thread()
        ReadContactsData()
    End Sub

    Private Sub sqlDelete_Thread()
        DeletePropertiesData()
    End Sub

    Private Sub DeletePropertiesData()
        Dim sqlQuery As String = "DELETE FROM " & GlobalVars.tbl_PROPERTIES & " WHERE PROPERTY_ID  = '" & Id & "'"
        Dim cmd As MySqlCommand
        cmd = New MySqlCommand(sqlQuery, GlobalVars.cn)
        Try
            cmd.ExecuteNonQuery()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

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
                dt.Columns("CONTRACT_ID").ColumnName = "Contract ID"
                dt.Columns("CONTRACT_NAME").ColumnName = "Company Name"
                dt.Columns("START_DATE").ColumnName = "Start Date"
                dt.Columns("END_DATE").ColumnName = "Expiry Date"
                dt.Columns("PAYMENT_TYPE").ColumnName = "Payment Type"
                dt.Columns("PAYMENT_METHOD").ColumnName = "Payment Method"
                dt.Columns("CONTRACT_FEE").ColumnName = "Contract Fee"

                Dim saveRow As Integer = 0
                If ContractsGrid.Rows.Count > 0 Then
                    saveRow = ContractsGrid.CurrentRow.Index
                End If

                ContractsGrid.DataSource = dt

                If saveRow <> 0 And saveRow < ContractsGrid.Rows.Count Then
                    ContractsGrid.CurrentCell = ContractsGrid.Rows(saveRow).Cells(0)
                    ContractsGrid.Rows(saveRow).Selected = True
                End If
            Catch ex As Exception
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If
    End Sub

    Private Sub ReadContactsData()
        If Me.InvokeRequired Then
            Me.Invoke(New MethodInvoker(AddressOf ReadContactsData))
        Else

            Dim sqlQuery As String = "SELECT CONTACT_ID, CONTACT_NAME, CONTACT_NUMBER, CONTACT_EMAIL FROM " & GlobalVars.tbl_CONTACTS & " WHERE PROPERTY_ID  = '" & Id & "' "
            Dim da As New MySqlDataAdapter(sqlQuery, GlobalVars.cn)
            Dim ds As New DataSet()

            Try
                da.Fill(ds)
                Dim dt As New DataTable("Contacts")
                da.Fill(dt)
                dt.Columns("CONTACT_ID").ColumnName = "Contact ID"
                dt.Columns("CONTACT_NAME").ColumnName = "Contact Name"
                dt.Columns("CONTACT_NUMBER").ColumnName = "Contact Number"
                dt.Columns("CONTACT_EMAIL").ColumnName = "Contact Email"

                Dim saveRow As Integer = 0
                If ContactsGrid.Rows.Count > 0 Then
                    saveRow = ContactsGrid.CurrentRow.Index
                End If

                ContactsGrid.DataSource = dt

                If saveRow <> 0 And saveRow < ContactsGrid.Rows.Count Then
                    ContactsGrid.CurrentCell = ContactsGrid.Rows(saveRow).Cells(0)
                    ContactsGrid.Rows(saveRow).Selected = True
                End If
            Catch ex As Exception
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If
    End Sub

    Private Sub ReadAssetsData()
        If Me.InvokeRequired Then
            Me.Invoke(New MethodInvoker(AddressOf ReadAssetsData))
        Else
            Dim sqlQuery As String
            If AssetType.Contains("Data") Then
                SelectedAssetTable = GlobalVars.tbl_DATA
                sqlQuery = "SELECT ASSET_ID, TYPE, MANUFACTURER, MODEL_NUMBER, LOCATION FROM " & SelectedAssetTable & " WHERE PROPERTY_ID  = '" & Id & "'"
            ElseIf AssetType.Contains("Voice") Then
                SelectedAssetTable = GlobalVars.tbl_VOICE
                sqlQuery = "SELECT ASSET_ID, PBX_MANUFACTURER, PBX_MODEL, PIN_NUMBER, LOCATION FROM " & SelectedAssetTable & " WHERE PROPERTY_ID  = '" & Id & "'"
            ElseIf AssetType.Contains("Mobile") Then
                SelectedAssetTable = GlobalVars.tbl_MOBILE
                sqlQuery = "SELECT ASSET_ID, BRAND, MODEL_NUMBER, IMEI_NUMBER, NETWORK FROM " & SelectedAssetTable & " WHERE PROPERTY_ID  = '" & Id & "'"
            ElseIf AssetType.Contains("Appliance") Then
                SelectedAssetTable = GlobalVars.tbl_APPLIANCE
                sqlQuery = "SELECT ASSET_ID, TYPE, MANUFACTURER, MODEL_NUMBER, SERIAL_NUMBER, LOCATION FROM " & SelectedAssetTable & " WHERE PROPERTY_ID  = '" & Id & "'"
            ElseIf AssetType.Contains("PC") Then
                SelectedAssetTable = GlobalVars.tbl_PC
                sqlQuery = "SELECT ASSET_ID, MANUFACTURER, MODEL_NUMBER, SERIAL_NUMBER, LOCATION FROM " & SelectedAssetTable & " WHERE PROPERTY_ID  = '" & Id & "'"
            ElseIf AssetType.Contains("TV") Then
                SelectedAssetTable = GlobalVars.tbl_TV
                sqlQuery = "SELECT ASSET_ID, MANUFACTURER, MODEL_NUMBER, SERIAL_NUMBER, LOCATION FROM " & SelectedAssetTable & " WHERE PROPERTY_ID  = '" & Id & "'"
            ElseIf AssetType.Contains("Sky") Then
                SelectedAssetTable = GlobalVars.tbl_SKY
                sqlQuery = "SELECT ASSET_ID, VIEWING_CARD_NUMBER, STATUS, LOCATION FROM " & SelectedAssetTable & " WHERE PROPERTY_ID  = '" & Id & "'"
            ElseIf AssetType.Contains("DVR") Then
                SelectedAssetTable = GlobalVars.tbl_DVRNVR
                sqlQuery = "SELECT ASSET_ID, MODEL, CHANNELS, SERIAL_NUMBER, SOFTWARE FROM " & SelectedAssetTable & " WHERE PROPERTY_ID  = '" & Id & "'"
            ElseIf AssetType.Contains("Car") Then
                SelectedAssetTable = GlobalVars.tbl_CAR
                sqlQuery = "SELECT ASSET_ID, MAKE, MODEL, REGISTRATION_NUMBER, REGISTERED_KEEPER FROM " & SelectedAssetTable & " WHERE PROPERTY_ID  = '" & Id & "'"
            Else
                SelectedAssetTable = Nothing
            End If

            Dim da As New MySqlDataAdapter(sqlQuery, GlobalVars.cn)
            Dim ds As New DataSet()

            Try
                da.Fill(ds)
                Dim dt As New DataTable("Assets")
                da.Fill(dt)

                If AssetType.Contains("Data") Then
                    dt.Columns("TYPE").ColumnName = "Device Type"
                    dt.Columns("MANUFACTURER").ColumnName = "Manufacturer"
                    dt.Columns("MODEL_NUMBER").ColumnName = "Model Number"
                    dt.Columns("LOCATION").ColumnName = "Location"
                ElseIf AssetType.Contains("Voice") Then
                    dt.Columns("PBX_MANUFACTURER").ColumnName = "PBX Manufacturer"
                    dt.Columns("PBX_MODEL").ColumnName = "PBX Model"
                    dt.Columns("PIN_NUMBER").ColumnName = "PIN Number"
                    dt.Columns("LOCATION").ColumnName = "Location"
                ElseIf AssetType.Contains("Mobile") Then
                    dt.Columns("BRAND").ColumnName = "Mobile Brand"
                    dt.Columns("MODEL_NUMBER").ColumnName = "Model"
                    dt.Columns("IMEI_NUMBER").ColumnName = "IMEI Number"
                    dt.Columns("NETWORK").ColumnName = "Network"
                ElseIf AssetType.Contains("Appliance") Then
                    dt.Columns("TYPE").ColumnName = "Appliance Type"
                    dt.Columns("MANUFACTURER").ColumnName = "Appliance Manufacturer"
                    dt.Columns("MODEL_NUMBER").ColumnName = "Model Number"
                    dt.Columns("SERIAL_NUMBER").ColumnName = "Serial Number"
                    dt.Columns("LOCATION").ColumnName = "Location"
                ElseIf AssetType.Contains("PC") Then
                    dt.Columns("MANUFACTURER").ColumnName = "PC Manufacturer"
                    dt.Columns("MODEL_NUMBER").ColumnName = "Model Number"
                    dt.Columns("SERIAL_NUMBER").ColumnName = "Serial Number"
                    dt.Columns("LOCATION").ColumnName = "Location"
                ElseIf AssetType.Contains("TV") Then
                    dt.Columns("MANUFACTURER").ColumnName = "TV Manufacturer"
                    dt.Columns("MODEL_NUMBER").ColumnName = "Model Number"
                    dt.Columns("SERIAL_NUMBER").ColumnName = "Serial Number"
                    dt.Columns("LOCATION").ColumnName = "Location"
                ElseIf AssetType.Contains("Sky") Then
                    dt.Columns("VIEWING_CARD_NUMBER").ColumnName = "Viewing Card Number"
                    dt.Columns("STATUS").ColumnName = "Status"
                    dt.Columns("LOCATION").ColumnName = "Location"
                ElseIf AssetType.Contains("DVR") Then
                    dt.Columns("MODEL").ColumnName = "DVR/NVR Model"
                    dt.Columns("CHANNELS").ColumnName = "Channels"
                    dt.Columns("SERIAL_NUMBER").ColumnName = "Serial_Number"
                    dt.Columns("SOFTWARE").ColumnName = "Software"
                ElseIf AssetType.Contains("Car") Then
                    dt.Columns("MAKE").ColumnName = "Car Make"
                    dt.Columns("MODEL").ColumnName = "Model"
                    dt.Columns("REGISTRATION_NUMBER").ColumnName = "Registration Number"
                    dt.Columns("REGISTERED_KEEPER").ColumnName = "Registered Keeper"
                End If
                AssetsPanel.Visible = False
                Dim saveRow As Integer = 0
                If AssetsGrid.Rows.Count > 0 Then
                    saveRow = AssetsGrid.CurrentRow.Index
                End If
                AssetsGrid.DataSource = dt
                If saveRow <> 0 And saveRow < AssetsGrid.Rows.Count Then
                    AssetsGrid.CurrentCell = AssetsGrid.Rows(saveRow).Cells(0)
                    AssetsGrid.Rows(saveRow).Selected = True
                End If
            Catch ex As Exception
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If
    End Sub

    Private Sub ReadInvoicesData()
        If Me.InvokeRequired Then
            Me.Invoke(New MethodInvoker(AddressOf ReadInvoicesData))
        Else

            Dim sqlQuery As String = "SELECT INVOICE_ID, INVOICE_TYPE, COMPANY, PAYMENT_TYPE, PAYMENT_AMOUNT, PAYMENT_DATE, PAYMENT_STATUS, CONTACT_NUMBER FROM " & GlobalVars.tbl_INVOICES & " WHERE PROPERTY_ID  = '" & Id & "' AND INVOICE_ID NOT LIKE 'FUND-%'"
            Dim da As New MySqlDataAdapter(sqlQuery, GlobalVars.cn)
            Dim ds As New DataSet()

            Try
                da.Fill(ds)
                Dim dt As New DataTable("Invoices")
                da.Fill(dt)

                dt.Columns("INVOICE_ID").ColumnName = "Invoice ID"
                dt.Columns("INVOICE_TYPE").ColumnName = "Invoice Type"
                dt.Columns("COMPANY").ColumnName = "Company Name"
                dt.Columns("PAYMENT_TYPE").ColumnName = "Payment Type"
                dt.Columns("PAYMENT_AMOUNT").ColumnName = "Payment Amount"
                dt.Columns("PAYMENT_DATE").ColumnName = "Payment Date"
                dt.Columns("PAYMENT_STATUS").ColumnName = "Payment Status"
                dt.Columns("CONTACT_NUMBER").ColumnName = "Contact Number"

                Dim saveRow As Integer = 0
                If InvoicesGrid.Rows.Count > 0 Then
                    saveRow = InvoicesGrid.CurrentRow.Index
                End If
                InvoicesGrid.DataSource = dt
                If saveRow <> 0 And saveRow < InvoicesGrid.Rows.Count Then
                    InvoicesGrid.CurrentCell = InvoicesGrid.Rows(saveRow).Cells(0)
                    InvoicesGrid.Rows(saveRow).Selected = True
                End If
            Catch ex As Exception
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If
    End Sub

    Private Sub ReadLogsData()
        If Me.InvokeRequired Then
            Me.Invoke(New MethodInvoker(AddressOf ReadLogsData))
        Else

            Dim sqlQuery As String = "SELECT LOG_ID, USERNAME, LOCATION, STATUS, TIME, LOG FROM " & GlobalVars.tbl_MLOGS & " WHERE PROPERTY_ID  = '" & Id & "'"
            Dim da As New MySqlDataAdapter(sqlQuery, GlobalVars.cn)
            Dim ds As New DataSet()

            Try
                da.Fill(ds)
                Dim dt As New DataTable("MLogs")
                da.Fill(dt)

                dt.Columns("LOG_ID").ColumnName = "Log ID"
                dt.Columns("USERNAME").ColumnName = "Username"
                dt.Columns("LOCATION").ColumnName = "Location"
                dt.Columns("STATUS").ColumnName = "Status"
                dt.Columns("TIME").ColumnName = "Time"
                dt.Columns("LOG").ColumnName = "Log"

                Dim saveRow As Integer = 0
                If LogsGrid.Rows.Count > 0 Then
                    saveRow = LogsGrid.CurrentRow.Index
                End If
                LogsGrid.DataSource = dt
                If saveRow <> 0 And saveRow < LogsGrid.Rows.Count Then
                    LogsGrid.CurrentCell = LogsGrid.Rows(saveRow).Cells(0)
                    LogsGrid.Rows(saveRow).Selected = True
                End If
            Catch ex As Exception
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If
    End Sub

    Private Sub DetailsForm_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
        CheckEdit = False

        If NewRecord = True Then
            Me.Text = "New Property"
            SaveBtn.Text = "Save"
            EditMode = True
            NewRecord = True
            EditBtn.PerformClick()
            EditBtn.Visible = False
            Tab2.Enabled = False
            Tab3.Enabled = False
            Tab4.Enabled = False
            Tab5.Enabled = False
        Else
            ' Load Property Photo



            Dim cnn As SqlConnection = New SqlConnection(GlobalVars.connectionString)
            Dim cmd As SqlCommand
            Dim query As String

            Try
                cnn.Open()

                query = "SELECT * FROM photos WHERE property_id = @PROPERTY_ID AND id = 1"
                cmd = New SqlCommand(query, cnn)
                cmd.Parameters.AddWithValue("@PROPERTY_ID", Id)

                Using dr As SqlDataReader = cmd.ExecuteReader()
                    If dr.Read() Then

                        Dim tempPath As String = System.IO.Path.GetTempPath + dr.Item("FILENAME")
                        Dim fs As IO.FileStream = New IO.FileStream(tempPath, IO.FileMode.Create)
                        Dim b() As Byte = dr.Item("PICTURE")
                        fs.Write(b, 0, b.Length)
                        fs.Close()

                        PropertyPicture.Load(tempPath)

                    End If
                End Using

                query = "SELECT * FROM properties WHERE id = @PROPERTY_ID"
                cmd = New SqlCommand(query, cnn)
                cmd.Parameters.AddWithValue("@PROPERTY_ID", Id)

                Using dr As SqlDataReader = cmd.ExecuteReader()
                    If dr.Read() Then
                        Company.Text = dr.Item("company")
                        Address.Text = dr.Item("address")
                        Country.Text = dr.Item("country")
                        County.Text = dr.Item("county")
                        City.Text = dr.Item("city")
                        Postcode.Text = dr.Item("postcode")
                        Telephone.Text = dr.Item("telephone")
                        Notes.Text = dr.Item("note")
                        GasMeterType.Text = dr.Item("gas_meter_type")
                        GasMeterReading.Text = dr.Item("gas_meter_reading")
                        GasTimeStamp.Value = CDate(dr.Item("gas_meter_timestamp"))
                        ElectricityMeterType.Text = dr.Item("electricity_meter_type")
                        ElectricityMeterReading.Text = dr.Item("electricity_meter_reading")
                        ElectricityTimeStamp.Value = CDate(dr.Item("electricity_meter_timestamp"))
                        WaterMeterType.Text = dr.Item("water_meter_type")
                        WaterMeterReading.Text = dr.Item("water_meter_reading")
                        WaterTimeStamp.Value = CDate(dr.Item("water_meter_timestamp"))

                        Header.Text = Company.Text & vbNewLine & Address.Text & vbNewLine & vbNewLine & "Property ID: " & Id & vbNewLine & "Total Assets: " & totalAssets.ToString & vbNewLine & "Total Contracts: " & totalContracts.ToString & vbNewLine & "Total Invoices: " & totalInvoices.ToString
                    End If
                End Using

            Catch ex As Exception
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Finally
                cnn.Close()
            End Try

            Me.Text = "Property Details - " & Company.Text
            EditMode = False
            NewRecord = False
            EditBtn.PerformClick()

            'ReadContacts()

        End If
    End Sub

    Private Sub CloseBtn_Click(ByVal sender As Object, ByVal e As EventArgs) Handles CloseBtn.Click
        Me.Close()
    End Sub

    Private Sub EditBtn_Click(ByVal sender As Object, ByVal e As EventArgs) Handles EditBtn.Click
        Select Case EditMode
            Case True
                If TabControl.SelectedPanel Is Tab1 Then
                    AttachPhotoBtn.Visible = True
                    Company.ReadOnly = False
                    Address.ReadOnly = False
                    Country.Enabled = True
                    County.Enabled = True
                    City.Enabled = True
                    Postcode.ReadOnly = False
                    Telephone.ReadOnly = False
                    Notes.ReadOnly = False
                    GasMeterType.Enabled = True
                    GasMeterReading.ReadOnly = False
                    GasTimeStamp.Enabled = True
                    ElectricityMeterType.Enabled = True
                    ElectricityMeterReading.ReadOnly = False
                    ElectricityTimeStamp.Enabled = True
                    WaterMeterType.Enabled = True
                    WaterMeterReading.ReadOnly = False
                    WaterTimeStamp.Enabled = True
                    SaveBtn.Visible = True
                    If NewRecord = False Then
                        DeleteBtn.Visible = True
                    End If
                ElseIf TabControl.SelectedPanel Is Tab2 Then
                    RemoveAssetBtn.Visible = True
                ElseIf TabControl.SelectedPanel Is Tab3 Then
                    RemoveContractBtn.Visible = True
                ElseIf TabControl.SelectedPanel Is Tab4 Then
                    RemoveInvoiceBtn.Visible = True
                ElseIf TabControl.SelectedPanel Is Tab5 Then
                    RemoveMLogBtn.Visible = True
                End If
                EditBtn.Text = "Cancel Edit"

                If NewRecord = False Then
                    ReadContacts()
                End If

                EditMode = False
            Case False
                If TabControl.SelectedPanel Is Tab1 Then
                    AttachPhotoBtn.Visible = False
                    Address.ReadOnly = True
                    Company.ReadOnly = True
                    Country.Enabled = False
                    County.Enabled = False
                    City.Enabled = False
                    Postcode.ReadOnly = True
                    Telephone.ReadOnly = True
                    Notes.ReadOnly = True
                    GasMeterType.Enabled = False
                    GasMeterReading.ReadOnly = True
                    GasTimeStamp.Enabled = False
                    ElectricityMeterType.Enabled = False
                    ElectricityMeterReading.ReadOnly = True
                    ElectricityTimeStamp.Enabled = False
                    WaterMeterType.Enabled = False
                    WaterMeterReading.ReadOnly = True
                    WaterTimeStamp.Enabled = False
                    SaveBtn.Visible = False
                    DeleteContactBtn.Visible = False
                    DeleteBtn.Visible = False
                ElseIf TabControl.SelectedPanel Is Tab2 Then
                    RemoveAssetBtn.Visible = False
                ElseIf TabControl.SelectedPanel Is Tab3 Then
                    RemoveContractBtn.Visible = False
                ElseIf TabControl.SelectedPanel Is Tab4 Then
                    RemoveInvoiceBtn.Visible = False
                ElseIf TabControl.SelectedPanel Is Tab5 Then
                    RemoveMLogBtn.Visible = False
                End If
                EditBtn.Text = "Edit"
                EditMode = True
        End Select
    End Sub

    Private Sub SaveBtn_Click(ByVal sender As Object, ByVal e As EventArgs) Handles SaveBtn.Click
        SaveBtn.Enabled = False

        Dim cnn As SqlConnection = New SqlConnection(GlobalVars.connectionString)
        Dim cmd As SqlCommand
        Dim query As String

        Try
            cnn.Open()

            If NewRecord = True Then
                query = "INSERT INTO properties VALUES(@Username, @Company, @Address, @Country, @County, @City, @Postcode, @Telephone, @Notes, @GasMeterType, @GasMeterReading, @GasTimeStamp, @ElectricityMeterType, @ElectricityMeterReading, @ElectricityTimeStamp, @WaterMeterType, @WaterMeterReading, @WaterTimeStamp) "
                cmd = New SqlCommand(query, cnn)
                cmd.Parameters.AddWithValue("@Username", GlobalVars.Username)
                cmd.Parameters.AddWithValue("@Company", Company.Text)
                cmd.Parameters.AddWithValue("@Address", Address.Text)
                cmd.Parameters.AddWithValue("@Country", Country.Text)
                cmd.Parameters.AddWithValue("@County", County.Text)
                cmd.Parameters.AddWithValue("@City", City.Text)
                cmd.Parameters.AddWithValue("@Postcode", Postcode.Text)
                cmd.Parameters.AddWithValue("@Telephone", Telephone.Text)
                cmd.Parameters.AddWithValue("@Notes", Notes.Text)
                cmd.Parameters.AddWithValue("@GasMeterType", GasMeterType.Text)
                cmd.Parameters.AddWithValue("@GasMeterReading", GasMeterReading.Text)
                cmd.Parameters.AddWithValue("@GasTimeStamp", GasTimeStamp.Value.ToString("yyyy-MM-dd HH:mm:ss"))
                cmd.Parameters.AddWithValue("@ElectricityMeterType", ElectricityMeterType.Text)
                cmd.Parameters.AddWithValue("@ElectricityMeterReading", ElectricityMeterReading.Text)
                cmd.Parameters.AddWithValue("@ElectricityTimeStamp", ElectricityTimeStamp.Value.ToString("yyyy-MM-dd HH:mm:ss"))
                cmd.Parameters.AddWithValue("@WaterMeterType", WaterMeterType.Text)
                cmd.Parameters.AddWithValue("@WaterMeterReading", WaterMeterReading.Text)
                cmd.Parameters.AddWithValue("@WaterTimeStamp", WaterTimeStamp.Value.ToString("yyyy-MM-dd HH:mm:ss"))
            Else

                If NewRecord = False And SettingsINI.ReadINIValue("Prompts", "AskBeforeModifyingProperties").Equals("Yes") Then
                    If MessageBox.Show("Are you sure you want to modify this property?.", "Prompt", MessageBoxButtons.YesNo, MessageBoxIcon.Information) = Windows.Forms.DialogResult.No Then
                        Exit Try
                    End If
                End If

                query = "UPDATE properties SET COMPANY = @Company, ADDRESS = @Address, COUNTY = @County, CITY = @City, POSTCODE = @Postcode, TELEPHONE = @Telephone, NOTES = @Notes, GAS_METER_TYPE = @GasMeterType, ELECTRICITY_METER_TYPE = @ElectricityMeterType, WATER_METER_TYPE = @WaterMeterType, GAS_METER_READING =  @GasMeterReading, GAS_METER_TIMESTAMP = @GasTimeStamp, ELECTRICITY_METER_READING = @ElectricityMeterReading, ELECTRICITY_METER_TIMESTAMP = @ElectricityTimeStamp, WATER_METER_READING = @WaterMeterReading, WATER_METER_TIMESTAMP = @WaterTimeStamp WHERE PROPERTY_ID = @Id "
                cmd = New SqlCommand(query, cnn)
                cmd.Parameters.AddWithValue("@Id", Id)
                cmd.Parameters.AddWithValue("@Company", Company.Text)
                cmd.Parameters.AddWithValue("@Address", Address.Text)
                cmd.Parameters.AddWithValue("@County", County.Text)
                cmd.Parameters.AddWithValue("@City", City.Text)
                cmd.Parameters.AddWithValue("@Postcode", Postcode.Text)
                cmd.Parameters.AddWithValue("@Telephone", Telephone.Text)
                cmd.Parameters.AddWithValue("@Notes", Notes.Text)
                cmd.Parameters.AddWithValue("@GasMeterType", GasMeterType.Text)
                cmd.Parameters.AddWithValue("@ElectricityMeterType", ElectricityMeterType.Text)
                cmd.Parameters.AddWithValue("@WaterMeterType", WaterMeterType.Text)
                cmd.Parameters.AddWithValue("@GasMeterReading", GasMeterReading.Text)
                cmd.Parameters.AddWithValue("@GasTimeStamp", GasTimeStamp.Value.ToString("yyyy-MM-dd HH:mm:ss"))
                cmd.Parameters.AddWithValue("@ElectricityMeterReading", ElectricityMeterReading.Text)
                cmd.Parameters.AddWithValue("@ElectricityTimeStamp", ElectricityTimeStamp.Value.ToString("yyyy-MM-dd HH:mm:ss"))
                cmd.Parameters.AddWithValue("@WaterMeterReading", WaterMeterReading.Text)
                cmd.Parameters.AddWithValue("@WaterTimeStamp", WaterTimeStamp.Value.ToString("yyyy-MM-dd HH:mm:ss"))
            End If


            cmd.ExecuteNonQuery()

            NewRecord = False
            EditBtn.Visible = True
            EditBtn.PerformClick()

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            cnn.Close()
            SaveBtn.Enabled = True
        End Try

    End Sub

    Private Sub DeleteBtn_Click(ByVal sender As Object, ByVal e As EventArgs) Handles DeleteBtn.Click
        If SettingsINI.ReadINIValue("Prompts", "AskBeforeDeletingInvoices").Equals("Yes") Then
            If MessageBox.Show("Are you sure you want to DELETE this property from the database?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) = MsgBoxResult.No Then
                Exit Sub
            End If
        End If

        DeleteProperty()
        MainForm.ReadProperties()
        Me.Close()
    End Sub

    Private Sub CompanyName_TextChanged(ByVal sender As Object, ByVal e As EventArgs)
        Me.Text = "Property Details - " & Company.Text
        Header.Text = Company.Text & vbNewLine & "Property ID: " & Id
    End Sub

    Private Sub Telephone_KeyPress(ByVal sender As Object, ByVal e As KeyPressEventArgs)
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub AddContractBtn_Click(ByVal sender As Object, ByVal e As EventArgs) Handles ButtonX1.Click
        Dim form As New ContractForm
        form.Id = Id
        form.NewRecord = True
        form.ShowDialog()
    End Sub

    Public Sub Tab3_Enter(ByVal sender As Object, ByVal e As EventArgs) Handles Tab3.Enter
        ReadContracts()
    End Sub

    Private Sub Refresh2Btn_Click(ByVal sender As Object, ByVal e As EventArgs) Handles Refresh2Btn.Click
        ReadContracts()
    End Sub

    Private Sub RemoveContractBtn_Click(ByVal sender As Object, ByVal e As EventArgs) Handles RemoveContractBtn.Click
        If SettingsINI.ReadINIValue("Prompts", "AskBeforeDeletingContracts").Equals("Yes") Then
            If MessageBox.Show("Are you sure you want to DELETE this contract from this property?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) = MsgBoxResult.No Then
                Exit Sub
            End If
        End If

        Dim sqlQuery As String = "DELETE FROM " & GlobalVars.tbl_CONTRACTS & " WHERE PROPERTY_ID  = '" & Id & "' AND CONTRACT_ID = '" & ContractsGrid.CurrentRow.Cells.Item(0).Value & "'"
        Dim cmd As MySqlCommand
        cmd = New MySqlCommand(sqlQuery, GlobalVars.cn)
        Try
            cmd.ExecuteNonQuery()
            Using _comm As New MySqlCommand()
                With _comm
                    .Connection = GlobalVars.cn
                    .CommandText = "UPDATE " & GlobalVars.tbl_PROPERTIES & " SET TOTAL_CONTRACTS = TOTAL_CONTRACTS-1 WHERE PROPERTY_ID = '" & Id & "' "
                End With
                _comm.ExecuteNonQuery()
            End Using
            ReadContracts()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub ContractsGrid_CellMouseDoubleClick(ByVal sender As Object, ByVal e As DataGridViewCellMouseEventArgs) Handles ContractsGrid.CellMouseDoubleClick
        If GlobalVars.isOpen("Contract - " & ContractsGrid.CurrentRow.Cells.Item(0).Value.ToString) = False And IsNothing(ContractsGrid.CurrentRow) = False Then
            Dim form As New ContractForm
            form.Id = Id
            form.Company = Company.Text
            form.Address = Address.Text
            form.Contract_ID = ContractsGrid.CurrentRow.Cells.Item(0).Value.ToString
            form.MdiParent = ParentMdiForm
            form.Show()
        End If
    End Sub

    Private Sub AddAssetBtn_Click(ByVal sender As Object, ByVal e As EventArgs) Handles AddAssetBtn.Click
        Dim form As New AssetForm
        form.Id = Id
        form.Company = Company.Text
        form.Address = Address.Text
        form.NewRecord = True
        form.ShowDialog()
    End Sub

    Private Sub AddInvoiceBtn_Click(ByVal sender As Object, ByVal e As EventArgs) Handles AddInvoiceBtn.Click
        Dim form As New InvoiceForm
        form.Id = Id
        form.Company = Company.Text
        form.Address = Address.Text
        form.Invoice_ID = ""
        form.EditBtn.Visible = False
        form.ShowDialog()
    End Sub

    Private Sub Tab4_Enter(ByVal sender As Object, ByVal e As EventArgs) Handles Tab4.Enter
        ReadInvoices()
    End Sub

    Private Sub Refresh3Btn_Click(ByVal sender As Object, ByVal e As EventArgs) Handles Refresh3Btn.Click
        ReadInvoices()
    End Sub

    Private Sub RemoveInvoiceBtn_Click(ByVal sender As Object, ByVal e As EventArgs) Handles RemoveInvoiceBtn.Click
        If SettingsINI.ReadINIValue("Prompts", "AskBeforeDeletingInvoices").Equals("Yes") Then
            If MessageBox.Show("Are you sure you want to DELETE this invoice from this property?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) = MsgBoxResult.No Then
                Exit Sub
            End If
        End If

        Dim sqlQuery As String = "DELETE FROM " & GlobalVars.tbl_INVOICES & " WHERE PROPERTY_ID  = '" & Id & "' AND INVOICE_ID = '" & InvoicesGrid.CurrentRow.Cells(0).Value.ToString & "'"
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
            ReadInvoices()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub InvoicesGrid_CellMouseDoubleClick(ByVal sender As Object, ByVal e As DataGridViewCellMouseEventArgs) Handles InvoicesGrid.CellMouseDoubleClick
        If GlobalVars.isOpen("Invoice - " & InvoicesGrid.CurrentRow.Cells.Item(0).Value.ToString) = False And IsNothing(InvoicesGrid.CurrentRow) = False Then
            Dim form As New InvoiceForm
            form.Id = Id
            form.Company = Company.Text
            form.Address = Address.Text
            form.Invoice_ID = InvoicesGrid.CurrentRow.Cells.Item(0).Value.ToString
            form.MdiParent = ParentMdiForm
            form.Show()
        End If
    End Sub


    Private Sub County_KeyUp(ByVal sender As Object, ByVal e As KeyEventArgs) Handles County.KeyUp
        AutoComplete(County, e)
    End Sub

    Private Sub City_KeyUp(ByVal sender As Object, ByVal e As KeyEventArgs) Handles City.KeyUp
        AutoComplete(City, e)
    End Sub

    Private Sub Postcode_TextChanged(ByVal sender As Object, ByVal e As EventArgs)
        Postcode.Text.Trim()
    End Sub

    Private Sub Telephone_KeyPress_1(ByVal sender As Object, ByVal e As KeyPressEventArgs)
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub AddContactBtn_Click(ByVal sender As Object, ByVal e As EventArgs) Handles AddContactBtn.Click
        Dim NewContactDialog As New ContactDialog
        NewContactDialog.Id = Id
        NewContactDialog.NewRecord = True
        NewContactDialog.EditMode = True
        If NewContactDialog.ShowDialog() = Windows.Forms.DialogResult.OK Then
            ReadContacts()
        End If
    End Sub

    Private Sub DeleteContactBtn_Click(ByVal sender As Object, ByVal e As EventArgs) Handles DeleteContactBtn.Click
        If MessageBox.Show("Are you sure you want to REMOVE this contact from this property?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) = MsgBoxResult.Yes Then
            DeleteContactBtn.Enabled = False
            Dim sqlQuery As String = "DELETE FROM " & GlobalVars.tbl_CONTACTS & " WHERE PROPERTY_ID = '" & Id & "' AND CONTACT_ID = '" & ContactsGrid.CurrentRow.Cells(0).Value & "' "
            Dim cmd As MySqlCommand
            cmd = New MySqlCommand(sqlQuery, GlobalVars.cn)
            Try
                cmd.ExecuteNonQuery()
                ReadContacts()
            Catch ex As Exception
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Finally
                DeleteContactBtn.Enabled = True
            End Try
        End If
    End Sub

    Private Sub TabControl_SelectedTabChanging(ByVal sender As Object, ByVal e As DevComponents.DotNetBar.TabStripTabChangingEventArgs) Handles TabControl.SelectedTabChanging
        If EditMode = False And CheckEdit = True Then
            EditBtn_Click(Nothing, Nothing)
        End If
        CheckEdit = True
    End Sub

    Private Sub EditContactBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EditContactBtn.Click
        Dim NewContactDialog As New ContactDialog
        NewContactDialog.Id = Id
        NewContactDialog.Staff_ID = ContactsGrid.CurrentRow.Cells.Item(0).Value.ToString
        NewContactDialog.EditMode = True
        If NewContactDialog.ShowDialog() = Windows.Forms.DialogResult.OK Then
            ReadContacts()
        End If
    End Sub

    Private Sub ContactsGrid_CellMouseDoubleClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs)
        Dim NewContactDialog As New ContactDialog
        NewContactDialog.Id = Id
        NewContactDialog.Staff_ID = ContactsGrid.CurrentRow.Cells.Item(0).Value.ToString
        NewContactDialog.EditMode = False
        If NewContactDialog.ShowDialog() = Windows.Forms.DialogResult.OK Then
            ReadContacts()
        End If
    End Sub

    Private Sub AttachPhotoBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AttachPhotoBtn.Click
        Dim openFileDialog = New OpenFileDialog()
        If openFileDialog.ShowDialog() = DialogResult.OK Then
            AttachPhotoBtn.Enabled = False
            PropertyPicture.Load(openFileDialog.FileName)
            openFileDialog.Filter = "Picture files (*.jpg)|*.jpg;*.jpeg;*.png;*.bmp"
            Dim FileSize As UInt32
            Dim rawData() As Byte
            Dim fs As FileStream
            Try
                fs = New FileStream(openFileDialog.FileName, FileMode.Open, FileAccess.Read)
                FileSize = fs.Length
                rawData = New Byte(FileSize) {}
                fs.Read(rawData, 0, FileSize)
                fs.Close()

                Dim sqlQuery As String = "REPLACE INTO " & GlobalVars.tbl_PICTURES & " VALUES(@Id, @Picture_Id, @Image, @Filename) "
                Dim cmd As New MySqlCommand(sqlQuery, GlobalVars.cn)
                cmd.Parameters.AddWithValue("@Id", Id)
                cmd.Parameters.AddWithValue("@Picture_Id", Id)
                cmd.Parameters.AddWithValue("@Image", rawData)
                cmd.Parameters.AddWithValue("@Filename", IO.Path.GetFileName(openFileDialog.FileName))
                cmd.ExecuteNonQuery()
            Catch ex As Exception
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Finally
                AttachPhotoBtn.Enabled = True
            End Try
        End If
    End Sub

    Private Sub AssetsGrid_CellMouseDoubleClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles AssetsGrid.CellMouseDoubleClick
        If GlobalVars.isOpen("Asset - " & AssetsGrid.CurrentRow.Cells.Item(0).Value.ToString) = False And IsNothing(AssetsGrid.CurrentRow) = False Then
            If AssetType.Contains("Sky") Then
                Dim NewSkyDialog As New SkyDialog
                NewSkyDialog.Id = Id
                NewSkyDialog.Asset_ID = AssetsGrid.CurrentRow.Cells(0).Value.ToString
                NewSkyDialog.ShowDialog()
            Else
                Dim form As New AssetForm
                form.Id = Id
                form.Company = Company.Text
                form.Address = Address.Text
                form.Asset_ID = AssetsGrid.CurrentRow.Cells.Item(0).Value.ToString
                form.SelectedAssetTable = SelectedAssetTable
                form.MdiParent = ParentMdiForm
                form.Show()
            End If
        End If
    End Sub

    Private Sub Tab5_Enter(sender As Object, e As EventArgs) Handles Tab5.Enter
        ReadMLogs()
    End Sub

    Private Sub AddMLogBtn_Click(sender As Object, e As EventArgs) Handles AddMLogBtn.Click
        Dim form As New MaintainenceLogForm
        form.Id = Id
        form.NewRecord = True
        form.ShowDialog()
    End Sub

    Private Sub RemoveMLogBtn_Click(sender As Object, e As EventArgs) Handles RemoveMLogBtn.Click
        If MessageBox.Show("Are you sure you want to DELETE this log?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) = MsgBoxResult.Yes Then
            Dim sqlQuery As String = "DELETE FROM " & GlobalVars.tbl_MLOGS & " PROPERTY_ID = '" & Id & "' WHERE LOG_ID = '" & LogsGrid.CurrentRow.Cells(0).Value.ToString & "' "
            Dim cmd As MySqlCommand
            cmd = New MySqlCommand(sqlQuery, GlobalVars.cn)
            Try
                cmd.ExecuteNonQuery()
                Me.Close()
            Catch ex As Exception
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If
    End Sub

    Private Sub LogsGrid_CellMouseDoubleClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles LogsGrid.CellMouseDoubleClick
        If GlobalVars.isOpen("Maintainence Log - " & LogsGrid.CurrentRow.Cells.Item(0).Value.ToString) = False And IsNothing(LogsGrid.CurrentRow) = False Then
            Dim form As New MaintainenceLogForm
            form.Id = Id
            form.Log_ID = LogsGrid.CurrentRow.Cells.Item(0).Value.ToString
            form.MdiParent = ParentMdiForm
            form.Show()
        End If
    End Sub

    Private Sub Telephone_KeyPress_2(sender As Object, e As KeyPressEventArgs) Handles Telephone.KeyPress
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub ContactsGrid_RowsAdded(sender As Object, e As DataGridViewRowsAddedEventArgs) Handles ContactsGrid.RowsAdded
        EditContactBtn.Enabled = True
        If EditMode = True Then
            DeleteContactBtn.Enabled = True
        End If
    End Sub

    Private Sub AssetsGrid_RowsAdded(sender As Object, e As DataGridViewRowsAddedEventArgs) Handles AssetsGrid.RowsAdded
        RemoveAssetBtn.Enabled = True
    End Sub

    Private Sub ContractsGrid_RowsAdded(sender As Object, e As DataGridViewRowsAddedEventArgs) Handles ContractsGrid.RowsAdded
        RemoveContractBtn.Enabled = True
    End Sub

    Private Sub InvoicesGrid_RowsAdded(sender As Object, e As DataGridViewRowsAddedEventArgs) Handles InvoicesGrid.RowsAdded
        RemoveInvoiceBtn.Enabled = True
    End Sub

    Private Sub LogsGrid_RowsAdded(sender As Object, e As DataGridViewRowsAddedEventArgs) Handles LogsGrid.RowsAdded
        RemoveMLogBtn.Enabled = True
    End Sub

    Private Sub Company_TextChanged(sender As Object, e As EventArgs) Handles Company.TextChanged
        If NewRecord = True Then
            Header.Text = "Company: " & Company.Text
        End If
    End Sub

    Private Sub MeterTypeCombo_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles GasMeterType.SelectionChangeCommitted
        If GasMeterType.SelectedIndex = 0 Then
            GasMeterReading.MaxLength = 4
            GasChart.ChartType = DevComponents.DotNetBar.eMicroChartType.Line
            GasChart.DataPoints = New List(Of Double)(New Double() {10, 40, 30, 20, 80})
            GasChart.Text = "Profit: "
        ElseIf GasMeterType.SelectedIndex = 1 Then
            GasMeterReading.MaxLength = 5
        End If
    End Sub

    Private Sub Refresh4Btn_Click(sender As Object, e As EventArgs) Handles Refresh4Btn.Click
        ReadMLogs()
    End Sub

    Private Sub DataBtn_Click(sender As Object, e As EventArgs) Handles DataBtn.Click
        AssetType = "Data"
        ReadAssets()
    End Sub

    Private Sub VoiceBtn_Click(sender As Object, e As EventArgs) Handles VoiceBtn.Click
        AssetType = "Voice"
        ReadAssets()
    End Sub

    Private Sub MobileBtn_Click(sender As Object, e As EventArgs) Handles MobileBtn.Click
        AssetType = "Mobile"
        ReadAssets()
    End Sub

    Private Sub ApplianceBtn_Click(sender As Object, e As EventArgs) Handles ApplianceBtn.Click
        AssetType = "Appliance"
        ReadAssets()
    End Sub

    Private Sub PCBtn_Click(sender As Object, e As EventArgs) Handles PCBtn.Click
        AssetType = "PC"
        ReadAssets()
    End Sub

    Private Sub TVBtn_Click(sender As Object, e As EventArgs) Handles TVBtn.Click
        AssetType = "TV"
        ReadAssets()
    End Sub

    Private Sub DVRNVRBtn_Click(sender As Object, e As EventArgs) Handles DVRNVRBtn.Click
        AssetType = "DVR"
        ReadAssets()
    End Sub

    Private Sub CarBtn_Click(sender As Object, e As EventArgs) Handles CarBtn.Click
        AssetType = "Car"
        ReadAssets()
    End Sub

    Private Sub AssetCategoriesBtn_Click(sender As Object, e As EventArgs) Handles AssetCategoriesBtn.Click
        AssetsPanel.Visible = True
    End Sub

    Private Sub SkyBtn_Click(sender As Object, e As EventArgs) Handles SkyBtn.Click
        AssetType = "Car"
        ReadAssets()
    End Sub

    Private Sub AssetsPanel_VisibleChanged(sender As Object, e As EventArgs) Handles AssetsPanel.VisibleChanged
        If AssetsPanel.Visible = False Then
            AssetCategoriesBtn.Enabled = True
            Refresh1Btn.Enabled = True
        Else
            AssetCategoriesBtn.Enabled = False
            Refresh1Btn.Enabled = False
        End If
    End Sub

    Private Sub Refresh1Btn_Click(sender As Object, e As EventArgs) Handles Refresh1Btn.Click
        ReadAssets()
    End Sub
End Class