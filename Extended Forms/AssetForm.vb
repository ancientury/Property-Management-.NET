Imports System.Threading
Imports MySql.Data.MySqlClient
Imports System.IO

Public Class AssetForm

    Public Id, Asset_ID, Company, Address, SelectedAssetTable As String
    Public EditMode, NewRecord, PhotoAvailable As Boolean
    Dim LandlinesThread, SkyCardsThread, LogsThread As Thread
    Dim Tab1, Tab2, Tab3, Tab4, Tab5, Tab6, Tab7, Tab8, Tab9 As TabPage

    Private Sub ReadLogs()
        LogsThread = New Thread(AddressOf sqlLogs_Thread)
        LogsThread.IsBackground = True
        LogsThread.Start()
    End Sub

    Private Sub sqlLogs_Thread()
        ReadLogsData()
    End Sub

    Private Sub ReadLogsData()
        If Me.InvokeRequired Then
            Me.Invoke(New MethodInvoker(AddressOf ReadLogsData))
        Else
            ' Read Logs
            Dim sqlQuery As String = "SELECT LOG_ID, LOG_INDEX, LOG_TYPE, USERNAME, TIMESTAMP, COMMENT, TASK_STATUS FROM " & GlobalVars.tbl_LOGS & " WHERE PROPERTY_ID  = '" & Id & "' AND " & "LOG_FOR = 'Asset' AND LOG_ID = '" & Asset_ID & "' "
            Dim da As New MySqlDataAdapter(sqlQuery, GlobalVars.cn)
            Dim ds As New DataSet()

            Try
                da.Fill(ds)
                Dim dt As New DataTable("Logs")
                da.Fill(dt)
                dt.Columns("LOG_ID").ColumnName = "Log ID"
                dt.Columns("LOG_INDEX").ColumnName = "Log Number"
                dt.Columns("LOG_TYPE").ColumnName = "Log Type"
                dt.Columns("USERNAME").ColumnName = "Username"
                dt.Columns("TIMESTAMP").ColumnName = "Timestamp"
                dt.Columns("COMMENT").ColumnName = "Comment"
                dt.Columns("TASK_STATUS").ColumnName = "Task Status"
                LogsGrid.DataSource = dt
            Catch ex As Exception
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If
    End Sub

    Private Sub ReadLandlines()
        LandlinesThread = New Thread(AddressOf sqlLandlines_Thread)
        LandlinesThread.IsBackground = True
        LandlinesThread.Start()
    End Sub

    Private Sub ReadSkyCards()
        SkyCardsThread = New Thread(AddressOf sqlSkyCards_Thread)
        SkyCardsThread.IsBackground = True
        SkyCardsThread.Start()
    End Sub

    Private Sub sqlLandlines_Thread()
        ReadLandlinesData()
    End Sub
    Private Sub sqlSkyCards_Thread()
        ReadSkyCardsData()
    End Sub

    Private Sub ReadLandlinesData()
        If Me.InvokeRequired Then
            Me.Invoke(New MethodInvoker(AddressOf ReadLandlinesData))
        Else

            Dim sqlQuery As String = "SELECT TYPE, NUMBER, CONTRACT, STATUS FROM " & GlobalVars.tbl_LANDLINES & " WHERE PROPERTY_ID  = '" & Id & "' AND ASSET_ID = '" & Asset_ID & "' "
            Dim da As New MySqlDataAdapter(sqlQuery, GlobalVars.cn)
            Dim ds As New DataSet()

            Try
                da.Fill(ds)
                Dim dt As New DataTable("Landlines")
                da.Fill(dt)
                dt.Columns("TYPE").ColumnName = "Type"
                dt.Columns("NUMBER").ColumnName = "Number"
                dt.Columns("CONTRACT").ColumnName = "Contract"
                dt.Columns("STATUS").ColumnName = "Status"
                LandlineGrid.DataSource = dt
            Catch ex As Exception
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If
    End Sub

    Private Sub ReadSkyCardsData()
        If Me.InvokeRequired Then
            Me.Invoke(New MethodInvoker(AddressOf ReadSkyCardsData))
        Else

            Dim sqlQuery As String = "SELECT ASSET_ID, VIEWING_CARD_NUMBER, STATUS, LOCATION, CONTRACT FROM " & GlobalVars.tbl_SKY & " WHERE PROPERTY_ID  = '" & Id & "' AND ASSET_ID = '" & Asset_ID & "' "
            Dim da As New MySqlDataAdapter(sqlQuery, GlobalVars.cn)
            Dim ds As New DataSet()

            Try
                da.Fill(ds)
                Dim dt As New DataTable("Landlines")
                da.Fill(dt)
                dt.Columns("ASSET_ID").ColumnName = "Asset ID"
                dt.Columns("VIEWING_CARD_NUMBER").ColumnName = "Viewing card number"
                dt.Columns("STATUS").ColumnName = "Status"
                dt.Columns("LOCATION").ColumnName = "Location"
                dt.Columns("CONTRACT").ColumnName = "Contract"
                SkyGridView.DataSource = dt
            Catch ex As Exception
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If
    End Sub

    Private Sub AssetForm_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
        AssetType.DisabledItems(0) = True
        AssetType.DisabledItems(4) = True
        AssetType.DisabledItems(6) = True
        AssetType.DisabledItems(10) = True
        AssetType.DisabledItems(12) = True

        Tab1 = TabControl.TabPages("DataTab")
        Tab2 = TabControl.TabPages("VoiceTab")
        Tab3 = TabControl.TabPages("MobileTab")
        Tab4 = TabControl.TabPages("ApplianceTab")
        Tab5 = TabControl.TabPages("PCTab")
        Tab6 = TabControl.TabPages("TVTab")
        Tab7 = TabControl.TabPages("SkyTab")
        Tab8 = TabControl.TabPages("DVRTab")
        Tab9 = TabControl.TabPages("CarTab")

        For Each page As TabPage In TabControl.TabPages
            If Not page.Name = "MainTab" Then
                TabControl.TabPages.Remove(page)
            End If
        Next page

        If NewRecord = True Then
            Asset_ID = GlobalVars.randomID()
            Me.Text = "New Asset - " & Asset_ID
            Header.Text = Company & vbNewLine & Address & vbNewLine & "Property ID: " & Id
            AssetID.Text = "Asset ID: " & Asset_ID
            EditMode = True
            EditBtn_Click(Nothing, Nothing)
            EditBtn.Visible = False
            DeleteBtn.Visible = False
            CancelBtn.Visible = True
            AssetType_SelectionChangeCommitted(Nothing, Nothing)
        Else
            Me.Text = "Asset - " & Asset_ID
            Header.Text = Company & vbNewLine & Address & vbNewLine & "Property ID: " & Id

            For Each page As TabPage In TabControl.TabPages
                TabControl.TabPages.Remove(page)
            Next page

            'Load asset photo
            Dim cmd As New MySqlCommand("Select PICTURE, FILENAME From " & GlobalVars.tbl_PICTURES & " WHERE PROPERTY_ID = '" & Id & "' AND PICTURE_ID = '" & Asset_ID & "' ", GlobalVars.cn)
            Dim tempPath As String
            Using dr As MySqlDataReader = cmd.ExecuteReader()
                If dr.Read() Then
                    PhotoAvailable = True
                    tempPath = System.IO.Path.GetTempPath + dr.Item("FILENAME")
                    Dim fs As IO.FileStream = New IO.FileStream(tempPath, IO.FileMode.Create)
                    Dim b() As Byte = dr.Item("PICTURE")
                    fs.Write(b, 0, b.Length)
                    fs.Close()
                End If
            End Using


            If PhotoAvailable = True Then
                AssetPicture.Load(tempPath)
            End If


            cmd = New MySqlCommand("SELECT * FROM " & SelectedAssetTable & " WHERE PROPERTY_ID = '" & Id & "' AND ASSET_ID = '" & Asset_ID & "' ", GlobalVars.cn)

            Using dr As MySqlDataReader = cmd.ExecuteReader()
                If dr.Read() Then
                    AssetID.Text = "Asset ID: " & dr.Item("ASSET_ID")
                    If SelectedAssetTable = GlobalVars.tbl_DATA Then
                        AssetType.SelectedIndex = 1
                        If PhotoAvailable = False Then
                            AssetPicture.Image = AssetImageList.Images(1)
                        End If
                        Tab1.Text = "Data"
                        TabControl.TabPages.Insert(0, Tab1)
                        Data_Type.Text = dr.Item("TYPE").ToString
                        Data_Manufacturer.Text = dr.Item("MANUFACTURER").ToString
                        Data_Model.Text = dr.Item("MODEL_NUMBER").ToString
                        Data_IPAddress.Text = dr.Item("IP_ADDRESS").ToString
                        Data_Username.Text = dr.Item("USER_NAME").ToString
                        Data_Password.Text = dr.Item("PASSWORD").ToString
                        Data_Location.Text = dr.Item("LOCATION").ToString
                        DataBBContract.Text = dr.Item("BROADBAND_LINE").ToString
                        DataMaintainerContract.Text = dr.Item("MAINTAINER").ToString
                    ElseIf SelectedAssetTable = GlobalVars.tbl_VOICE Then
                        AssetType.SelectedIndex = 2
                        If PhotoAvailable = False Then
                            AssetPicture.Image = AssetImageList.Images(2)
                        End If
                        Tab2.Text = "Voice"
                        TabControl.TabPages.Insert(0, Tab2)
                        Voice_Manufacturer.Text = dr.Item("PBX_MANUFACTURER").ToString
                        Voice_Model.Text = dr.Item("PBX_MODEL").ToString
                        Voice_PIN.Text = dr.Item("PIN_NUMBER").ToString
                        Voice_Extensions.Text = dr.Item("EXTENSIONS").ToString
                        Voice_Location.Text = dr.Item("LOCATION").ToString
                        ReadLandlines()
                    ElseIf SelectedAssetTable = GlobalVars.tbl_MOBILE Then
                        AssetType.SelectedIndex = 3
                        If PhotoAvailable = False Then
                            AssetPicture.Image = AssetImageList.Images(3)
                        End If
                        Tab3.Text = "Mobile"
                        TabControl.TabPages.Insert(0, Tab3)
                        Mobile_Brand.Text = dr.Item("BRAND").ToString
                        Mobile_Model.Text = dr.Item("MODEL_NUMBER").ToString
                        Mobile_IMEI.Text = dr.Item("IMEI_NUMBER").ToString
                        Mobile_Network.Text = dr.Item("NETWORK").ToString
                        MobileContract.Text = dr.Item("CONTRACT").ToString
                    ElseIf SelectedAssetTable = GlobalVars.tbl_APPLIANCE Then
                        AssetType.SelectedIndex = 5
                        If PhotoAvailable = False Then
                            AssetPicture.Image = AssetImageList.Images(4)
                        End If
                        Tab4.Text = "Appliance"
                        TabControl.TabPages.Insert(0, Tab4)
                        Appliance_Type.Text = dr.Item("TYPE").ToString
                        Appliance_Manufacturer.Text = dr.Item("MANUFACTURER").ToString
                        Appliance_Model.Text = dr.Item("MODEL_NUMBER").ToString
                        Appliance_Serial.Text = dr.Item("SERIAL_NUMBER").ToString
                        Dim strArr() = dr.Item("WARRANTY").ToString.Split(" ")
                        Appliance_WarrantyPeriod.Text = strArr(0).Trim()
                        Appliance_Warranty.Text = strArr(1).Trim()
                        Appliance_Location.Text = dr.Item("LOCATION").ToString
                    ElseIf SelectedAssetTable = GlobalVars.tbl_PC Then
                        AssetType.SelectedIndex = 7
                        If PhotoAvailable = False Then
                            AssetPicture.Image = AssetImageList.Images(5)
                        End If
                        Tab5.Text = "PC"
                        TabControl.TabPages.Insert(0, Tab5)
                        PC_Manufacturer.Text = dr.Item("MANUFACTURER").ToString
                        PC_Model.Text = dr.Item("MODEL_NUMBER").ToString
                        PC_Serial.Text = dr.Item("SERIAL_NUMBER").ToString
                        Dim strArr() = dr.Item("WARRANTY").ToString.Split(" ")
                        PC_WarrantyPeriod.Text = strArr(0).Trim()
                        PC_Warranty.Text = strArr(1).Trim()
                        PC_Username.Text = dr.Item("USER_NAME").ToString
                        PC_Password.Text = dr.Item("PASSWORD").ToString
                        PC_Location.Text = dr.Item("LOCATION").ToString
                    ElseIf SelectedAssetTable = GlobalVars.tbl_TV Then
                        AssetType.SelectedIndex = 8
                        If PhotoAvailable = False Then
                            AssetPicture.Image = AssetImageList.Images(6)
                        End If
                        Tab6.Text = "TV"
                        TabControl.TabPages.Insert(0, Tab6)
                        TV_Manufacturer.Text = dr.Item("MANUFACTURER").ToString
                        TV_Model.Text = dr.Item("MODEL_NUMBER").ToString
                        TV_Serial.Text = dr.Item("SERIAL_NUMBER").ToString
                        Dim strArr() = dr.Item("WARRANTY").ToString.Split(" ")
                        TV_WarrantyPeriod.Text = strArr(0).Trim()
                        TV_Warranty.Text = strArr(1).Trim()
                        TV_Location.Text = dr.Item("LOCATION").ToString
                    ElseIf SelectedAssetTable = GlobalVars.tbl_SKY Then
                        AssetType.SelectedIndex = 9
                        AttachPhotoBtn.Visible = False
                        AssetPicture.Image = AssetImageList.Images(7)
                        Tab7.Text = "SkyBox"
                        TabControl.TabPages.Insert(0, Tab7)
                        ReadSkyCards()
                    ElseIf SelectedAssetTable = GlobalVars.tbl_DVRNVR Then
                        AssetType.SelectedIndex = 11
                        If PhotoAvailable = False Then
                            AssetPicture.Image = AssetImageList.Images(8)
                        End If
                        Tab8.Text = "DVR/NVR"
                        TabControl.TabPages.Insert(0, Tab8)
                        DVR_Model.Text = dr.Item("MODEL").ToString
                        DVR_Channels.Text = dr.Item("CHANNELS").ToString
                        DVR_Serial.Text = dr.Item("SERIAL_NUMBER").ToString
                        DVR_Username.Text = dr.Item("USER_NAME").ToString
                        DVR_Password.Text = dr.Item("PASSWORD").ToString
                        DVR_LicenseDue.Value = dr.Item("LICENSE_DUE").ToString
                        DVR_Software.Text = dr.Item("SOFTWARE").ToString
                        DVR_Location.Text = dr.Item("LOCATION").ToString
                        DVRMaintainerContract.Text = dr.Item("MAINTAINER").ToString
                    ElseIf SelectedAssetTable = GlobalVars.tbl_CAR Then
                        AssetType.SelectedIndex = 13
                        If PhotoAvailable = False Then
                            AssetPicture.Image = AssetImageList.Images(9)
                        End If
                        Tab9.Text = "Car"
                        TabControl.TabPages.Insert(0, Tab9)
                        Car_Make.Text = dr.Item("MAKE").ToString
                        Car_Model.Text = dr.Item("MODEL").ToString
                        Car_Keeper.Text = dr.Item("REGISTERED_KEEPER").ToString
                        Car_Keeper_Address.Text = dr.Item("KEEPER_ADDRESS").ToString
                        Car_VRN.Text = dr.Item("REGISTRATION_NUMBER").ToString
                        Car_Mileage.Text = dr.Item("MILEAGE").ToString
                        MOTContract.Text = dr.Item("MOT").ToString
                        TAXContract.Text = dr.Item("TAX").ToString
                        InsuranceContract.Text = dr.Item("INSURANCE").ToString
                    Else
                        SelectedAssetTable = Nothing
                    End If
                End If
            End Using

            ReadLogs()

            EditMode = False
            NewRecord = False
            EditBtn_Click(Nothing, Nothing)

        End If

        For Each tp As TabPage In Me.TabControl.TabPages
            tp.BackColor = Color.White
        Next
    End Sub

    Private Sub CancelBtn_Click(ByVal sender As Object, ByVal e As EventArgs) Handles CancelBtn.Click
        Me.Close()
    End Sub

    Private Sub AssetType_SelectionChangeCommitted(ByVal sender As Object, ByVal e As EventArgs) Handles AssetType.SelectionChangeCommitted
        If String.Compare(AssetType.Text, "Communication") <> 0 And String.Compare(AssetType.Text, "Domestic Appliances") <> 0 And String.Compare(AssetType.Text, "Entertainment") <> 0 And String.Compare(AssetType.Text, "Security") <> 0 And String.Compare(AssetType.Text, "Transport") <> 0 Then

            For Each page As TabPage In TabControl.TabPages
                TabControl.TabPages.Remove(page)
            Next page

            If AssetType.Text.Contains("Data") Then
                TabControl.TabPages.Insert(0, Tab1)
                TabControl.TabPages("DataTab").Text = "Data"
                AssetPicture.Image = AssetImageList.Images(1)
            ElseIf AssetType.Text.Contains("Voice") Then
                TabControl.TabPages.Insert(0, Tab2)
                TabControl.TabPages("VoiceTab").Text = "Voice"
                AssetPicture.Image = AssetImageList.Images(2)
            ElseIf AssetType.Text.Contains("Mobile") Then
                TabControl.TabPages.Insert(0, Tab3)
                TabControl.TabPages("MobileTab").Text = "Mobile"
                AssetPicture.Image = AssetImageList.Images(3)
            ElseIf AssetType.Text.Contains("Appliance") Then
                TabControl.TabPages.Insert(0, Tab4)
                TabControl.TabPages("ApplianceTab").Text = "Appliance"
                AssetPicture.Image = AssetImageList.Images(4)
            ElseIf AssetType.Text.Contains("PC") Then
                TabControl.TabPages.Insert(0, Tab5)
                TabControl.TabPages("PCTab").Text = "PC"
                AssetPicture.Image = AssetImageList.Images(5)
            ElseIf AssetType.Text.Contains("TV") Then
                TabControl.TabPages.Insert(0, Tab6)
                TabControl.TabPages("TVTab").Text = "TV"
                AssetPicture.Image = AssetImageList.Images(6)
            ElseIf AssetType.Text.Contains("Sky") Then
                TabControl.TabPages.Insert(0, Tab7)
                TabControl.TabPages("SkyTab").Text = "Sky"
                AssetPicture.Image = AssetImageList.Images(7)
            ElseIf AssetType.Text.Contains("DVR") Then
                TabControl.TabPages.Insert(0, Tab8)
                TabControl.TabPages("DVRTab").Text = "DVR/NVR"
                AssetPicture.Image = AssetImageList.Images(8)
            ElseIf AssetType.Text.Contains("Car") Then
                TabControl.TabPages.Insert(0, Tab9)
                TabControl.TabPages("CarTab").Text = "Car"
                AssetPicture.Image = AssetImageList.Images(9)
            End If

            For Each tp As TabPage In Me.TabControl.TabPages
                tp.BackColor = Color.White
            Next
        End If
    End Sub

    Private Sub LinkMaintainerBtn_Click(ByVal sender As Object, ByVal e As EventArgs) Handles LinkDataMaintainerBtn.Click, LinkDVRMaintainerBtn.Click
        If EditMode = False Then
            LinkContractForm.Id = Id
            If LinkContractForm.ShowDialog() = Windows.Forms.DialogResult.OK Then
                DataMaintainerContract.Text = "Maintained by " & LinkContractForm.ContractsGrid.CurrentRow.Cells.Item(1).Value & " - " & LinkContractForm.ContractsGrid.CurrentRow.Cells.Item(0).Value
            End If
        Else
            Dim form As New ContractForm
            Dim strArr() As String = DataMaintainerContract.Text.Split("-")
            If GlobalVars.isOpen("Contract - " & strArr(strArr.Length-1).Trim()) = False Then
                form.Id = Id
                form.Company = Company
                form.Address = Address
                form.Contract_ID = strArr(strArr.Length-1).Trim()
                form.ViewContract = True
                form.MdiParent = ParentMdiForm
                form.Show()
            End If
        End If
    End Sub

    Private Sub LinkBBBtn_Click(ByVal sender As Object, ByVal e As EventArgs) Handles LinkDataBBtn.Click
        If EditMode = False Then
            LinkContractForm.Id = Id
            If LinkContractForm.ShowDialog() = Windows.Forms.DialogResult.OK Then
                DataBBContract.Text = "Provided by " & LinkContractForm.ContractsGrid.CurrentRow.Cells.Item(1).Value & " - " & LinkContractForm.ContractsGrid.CurrentRow.Cells.Item(0).Value
            End If
        ElseIf GlobalVars.isOpen("Link Contract") = False Then
            Dim form As New ContractForm
            Dim strArr() As String = DataBBContract.Text.Split("-")
            If GlobalVars.isOpen("Contract - " & strArr(strArr.Length-1).Trim()) = False Then
                form.Id = Id
                form.Company = Company
                form.Address = Address
                form.Contract_ID = strArr(strArr.Length-1).Trim()
                form.ViewContract = True
                form.MdiParent = ParentMdiForm
                form.Show()
            End If
            End If
    End Sub

    Private Sub LinkMOTBtn_Click(ByVal sender As Object, ByVal e As EventArgs) Handles LinkMOTBtn.Click
        If EditMode = False Then
            LinkContractForm.Id = Id
            If LinkContractForm.ShowDialog() = Windows.Forms.DialogResult.OK Then
                MOTContract.Text = LinkContractForm.ContractsGrid.CurrentRow.Cells.Item(1).Value
            End If
        ElseIf GlobalVars.isOpen("Link Contract") = False Then
            Dim form As New ContractForm
            Dim strArr() As String = MOTContract.Text.Split("-")
            If GlobalVars.isOpen("Contract - " & strArr(strArr.Length-1).Trim()) = False Then
                form.Id = Id
                form.Company = Company
                form.Address = Address
                form.Contract_ID = strArr(strArr.Length-1).Trim()
                form.ViewContract = True
                form.MdiParent = ParentMdiForm
                form.Show()
            End If
            End If
    End Sub

    Private Sub LinkTAXBtn_Click(ByVal sender As Object, ByVal e As EventArgs) Handles LinkTAXBtn.Click

        If EditMode = False Then
            LinkContractForm.Id = Id
            If LinkContractForm.ShowDialog() = Windows.Forms.DialogResult.OK Then
                TAXContract.Text = LinkContractForm.ContractsGrid.CurrentRow.Cells.Item(1).Value
            End If
        Else
            Dim form As New ContractForm
            Dim strArr() As String = TAXContract.Text.Split("-")
            If GlobalVars.isOpen("Contract - " & strArr(strArr.Length-1).Trim()) = False Then
                form.Id = Id
                form.Company = Company
                form.Address = Address
                form.Contract_ID = strArr(strArr.Length-1).Trim()
                form.ViewContract = True
                form.MdiParent = ParentMdiForm
                form.Show()
            End If
            End If
    End Sub

    Private Sub LinkInsuranceBtn_Click(ByVal sender As Object, ByVal e As EventArgs) Handles LinkInsuranceBtn.Click
        If EditMode = False Then
            LinkContractForm.Id = Id
            If LinkContractForm.ShowDialog() = Windows.Forms.DialogResult.OK Then
                InsuranceContract.Text = LinkContractForm.ContractsGrid.CurrentRow.Cells.Item(1).Value
            End If
        ElseIf GlobalVars.isOpen("Link Contract") = False Then
            Dim form As New ContractForm
            Dim strArr() As String = InsuranceContract.Text.Split("-")
            If GlobalVars.isOpen("Contract - " & strArr(strArr.Length-1).Trim()) = False Then
                form.Id = Id
                form.Company = Company
                form.Address = Address
                form.Contract_ID = strArr(strArr.Length-1).Trim()
                form.ViewContract = True
                form.MdiParent = ParentMdiForm
                form.Show()
            End If
            End If
    End Sub

    Private Sub EditBtn_Click(ByVal sender As Object, ByVal e As EventArgs) Handles EditBtn.Click
        Select Case EditMode
            Case True
                AttachPhotoBtn.Visible = True
                If TabControl.TabPages.Contains(Tab1) Then
                    Data_Type.Enabled = True
                    Data_Manufacturer.ReadOnly = False
                    Data_Model.ReadOnly = False
                    Data_IPAddress.ReadOnly = False
                    Data_Username.ReadOnly = False
                    Data_Password.ReadOnly = False
                    Data_Location.ReadOnly = False
                    LinkDataBBtn.Enabled = True
                    LinkDataBBtn.Text = "Link Provider"
                    LinkDataMaintainerBtn.Enabled = True
                    LinkDataMaintainerBtn.Text = "Link Maintainer"
                ElseIf TabControl.TabPages.Contains(Tab2) Then
                    Voice_Manufacturer.ReadOnly = False
                    Voice_Model.ReadOnly = False
                    Voice_PIN.ReadOnly = False
                    Voice_Extensions.ReadOnly = False
                    If NewRecord = True Then
                        AddLineBtn.Enabled = False
                        RemoveLineBtn.Visible = False
                    Else
                        AddLineBtn.Enabled = True
                        RemoveLineBtn.Visible = True
                    End If
                ElseIf TabControl.TabPages.Contains(Tab3) Then
                    Mobile_Brand.ReadOnly = False
                    Mobile_Model.ReadOnly = False
                    Mobile_IMEI.ReadOnly = False
                    Mobile_Network.Enabled = True
                    LinkContractBtn.Enabled = True
                    LinkContractBtn.Text = "Link Contract"
                ElseIf TabControl.TabPages.Contains(Tab4) Then
                    Appliance_Type.ReadOnly = False
                    Appliance_Manufacturer.ReadOnly = False
                    Appliance_Model.ReadOnly = False
                    Appliance_Serial.ReadOnly = False
                    Appliance_Warranty.Enabled = True
                    Appliance_Location.Enabled = True
                ElseIf TabControl.TabPages.Contains(Tab5) Then
                    PC_Manufacturer.ReadOnly = False
                    PC_Model.ReadOnly = False
                    PC_Serial.ReadOnly = False
                    PC_Warranty.Enabled = True
                    PC_Username.ReadOnly = False
                    PC_Password.ReadOnly = False
                    PC_Location.ReadOnly = False
                ElseIf TabControl.TabPages.Contains(Tab6) Then
                    TV_Manufacturer.ReadOnly = False
                    TV_Model.ReadOnly = False
                    TV_Serial.ReadOnly = False
                    TV_Warranty.Enabled = True
                    TV_Location.ReadOnly = False
                ElseIf TabControl.TabPages.Contains(Tab7) Then
                    RemoveViewCardBtn.Visible = True
                ElseIf TabControl.TabPages.Contains(Tab8) Then
                    DVR_Model.ReadOnly = False
                    DVR_Channels.ReadOnly = False
                    DVR_Serial.ReadOnly = False
                    DVR_Username.ReadOnly = False
                    DVR_Password.ReadOnly = False
                    DVR_LicenseDue.Enabled = True
                    DVR_Software.ReadOnly = False
                    LinkDVRMaintainerBtn.Enabled = True
                    LinkDVRMaintainerBtn.Text = "Link Maintainer"
                ElseIf TabControl.TabPages.Contains(Tab9) Then
                    Car_Make.Enabled = True
                    Car_Model.ReadOnly = False
                    Car_VRN.ReadOnly = False
                    Car_Mileage.ReadOnly = False
                    LinkMOTBtn.Enabled = True
                    LinkMOTBtn.Text = "Link MOT"
                    LinkTAXBtn.Enabled = True
                    LinkTAXBtn.Text = "Link TAX"
                    LinkInsuranceBtn.Enabled = True
                    LinkInsuranceBtn.Text = "Link Insurance"
                End If
                DeleteLogBtn.Visible = True
                DeleteBtn.Visible = True
                ReadLogs()
                EditBtn.Text = "Cancel Edit"
                EditMode = False
            Case False
                AttachPhotoBtn.Visible = False
                AssetType.Enabled = False
                If TabControl.TabPages.Contains(Tab1) Then
                    Data_Type.Enabled = False
                    Data_Manufacturer.ReadOnly = True
                    Data_Model.ReadOnly = True
                    Data_IPAddress.ReadOnly = True
                    Data_Username.ReadOnly = True
                    Data_Password.ReadOnly = True
                    Data_Location.ReadOnly = True
                    If DataBBContract.Text = "None" Then
                        LinkDataBBtn.Enabled = False
                    Else
                        LinkDataBBtn.Text = "View Provider"
                    End If

                    If DataMaintainerContract.Text = "None" Then
                        LinkDataMaintainerBtn.Enabled = False
                    Else
                        LinkDataMaintainerBtn.Text = "View Maintainer"
                    End If

                ElseIf TabControl.TabPages.Contains(Tab2) Then
                    Voice_Manufacturer.ReadOnly = True
                    Voice_Model.ReadOnly = True
                    Voice_PIN.ReadOnly = True
                    Voice_Extensions.ReadOnly = True
                    RemoveLineBtn.Visible = False
                ElseIf TabControl.TabPages.Contains(Tab3) Then
                    Mobile_Brand.ReadOnly = True
                    Mobile_Model.ReadOnly = True
                    Mobile_IMEI.ReadOnly = True
                    Mobile_Network.Enabled = False
                    If MobileContract.Text = "None" Then
                        LinkContractBtn.Enabled = False
                    Else
                        LinkContractBtn.Text = "View Contract"
                    End If
                ElseIf TabControl.TabPages.Contains(Tab4) Then
                    Appliance_Type.ReadOnly = False
                    Appliance_Manufacturer.ReadOnly = False
                    Appliance_Model.ReadOnly = False
                    Appliance_Serial.ReadOnly = False
                    Appliance_Warranty.Enabled = True
                    Appliance_Location.Enabled = True
                ElseIf TabControl.TabPages.Contains(Tab5) Then
                    PC_Manufacturer.ReadOnly = True
                    PC_Model.ReadOnly = True
                    PC_Serial.ReadOnly = True
                    PC_Warranty.Enabled = False
                    PC_Username.ReadOnly = True
                    PC_Password.ReadOnly = True
                    PC_Location.ReadOnly = True
                ElseIf TabControl.TabPages.Contains(Tab6) Then
                    TV_Manufacturer.ReadOnly = True
                    TV_Model.ReadOnly = True
                    TV_Serial.ReadOnly = True
                    TV_Warranty.Enabled = False
                    TV_Location.ReadOnly = True
                ElseIf TabControl.TabPages.Contains(Tab7) Then
                    RemoveViewCardBtn.Visible = False
                ElseIf TabControl.TabPages.Contains(Tab8) Then
                    DVR_Model.ReadOnly = True
                    DVR_Channels.ReadOnly = True
                    DVR_Serial.ReadOnly = True
                    DVR_Username.ReadOnly = True
                    DVR_Password.ReadOnly = True
                    DVR_LicenseDue.Enabled = False
                    DVR_Software.ReadOnly = True
                    If DVRMaintainerContract.Text = "None" And EditMode = False Then
                        LinkDVRMaintainerBtn.Enabled = False
                    Else
                        LinkDVRMaintainerBtn.Text = "View Maintainer"
                    End If
                ElseIf TabControl.TabPages.Contains(Tab9) Then
                    Car_Make.Enabled = False
                    Car_Model.ReadOnly = True
                    Car_VRN.ReadOnly = True
                    Car_Mileage.ReadOnly = True

                    If MOTContract.Text = "No" And EditMode = False Then
                        LinkMOTBtn.Enabled = False
                    Else
                        LinkMOTBtn.Text = "View MOT"
                    End If
                    If TAXContract.Text = "No" And EditMode = False Then
                        LinkTAXBtn.Enabled = False
                    Else
                        LinkTAXBtn.Text = "View TAX"
                    End If
                    If InsuranceContract.Text = "No" And EditMode = False Then
                        LinkInsuranceBtn.Enabled = False
                    Else
                        LinkInsuranceBtn.Text = "View Insurance"
                    End If
                End If
                DeleteBtn.Visible = False
                DeleteLogBtn.Visible = False
                EditBtn.Text = "Edit"
                EditMode = True
        End Select
    End Sub

    Private Sub AddLineBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AddLineBtn.Click
        Dim NewLandlineDialog As New LandlineDialog
        NewLandlineDialog.Id = Id
        NewLandlineDialog.Asset_ID = Asset_ID
        NewLandlineDialog.NewRecord = True
        NewLandlineDialog.EditMode = True
        If NewLandlineDialog.ShowDialog() = Windows.Forms.DialogResult.OK Then
            ReadLandlines()
        End If
    End Sub

    Private Sub OkBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OkBtn.Click
        If EditMode = False Then

            If NewRecord = False And SettingsINI.ReadINIValue("Prompts", "AskBeforeModifyingAssets").Equals("Yes") Then
                If MessageBox.Show("Are you sure you want to modify this asset?.", "Prompt", MessageBoxButtons.YesNo, MessageBoxIcon.Information) = Windows.Forms.DialogResult.No Then
                    Exit Sub
                End If
            End If

            OkBtn.Enabled = False

            EditBtn_Click(Nothing, Nothing)

            Dim SelectedTable, sqlQuery As String
            Dim cmd As MySqlCommand

            If TabControl.TabPages.Contains(Tab1) Then
                SelectedTable = GlobalVars.tbl_DATA
                sqlQuery = "REPLACE INTO " & SelectedTable & " VALUES(@Id, @Username,  @Asset_ID, @Data_Type,  @Data_Manufacturer, @Data_Model,  @Data_IPAddress, @Data_Username,  @Data_Password, @Data_Location, @DataBBContract, @DataMaintainerContract) "
                cmd = New MySqlCommand(sqlQuery, GlobalVars.cn)
                cmd.Parameters.AddWithValue("@Id", Id)
                cmd.Parameters.AddWithValue("@Username", GlobalVars.Username)
                cmd.Parameters.AddWithValue("@Asset_ID", Asset_ID)
                cmd.Parameters.AddWithValue("@Data_Type", Data_Type.Text)
                cmd.Parameters.AddWithValue("@Data_Manufacturer", Data_Manufacturer.Text)
                cmd.Parameters.AddWithValue("@Data_Model", Data_Model.Text)
                cmd.Parameters.AddWithValue("@Data_IPAddress", Data_IPAddress.Text)
                cmd.Parameters.AddWithValue("@Data_Username", Data_Username.Text)
                cmd.Parameters.AddWithValue("@Data_Password", Data_Password.Text)
                cmd.Parameters.AddWithValue("@Data_Location", Data_Location.Text)
                cmd.Parameters.AddWithValue("@DataBBContract", DataBBContract.Text)
                cmd.Parameters.AddWithValue("@DataMaintainerContract", DataMaintainerContract.Text)
            ElseIf TabControl.TabPages.Contains(Tab2) Then
                SelectedTable = GlobalVars.tbl_VOICE
                sqlQuery = "REPLACE INTO " & SelectedTable & " VALUES(@Id, @Username,  @Asset_ID, @Voice_Manufacturer, @Voice_Model, @Voice_PIN, @Voice_Extensions, @Voice_Location) "
                cmd = New MySqlCommand(sqlQuery, GlobalVars.cn)
                cmd.Parameters.AddWithValue("@Id", Id)
                cmd.Parameters.AddWithValue("@Username", GlobalVars.Username)
                cmd.Parameters.AddWithValue("@Asset_ID", Asset_ID)
                cmd.Parameters.AddWithValue("@Voice_Manufacturer", Voice_Manufacturer.Text)
                cmd.Parameters.AddWithValue("@Voice_Model", Voice_Model.Text)
                cmd.Parameters.AddWithValue("@Voice_PIN", Voice_PIN.Text)
                cmd.Parameters.AddWithValue("@Voice_Extensions", Voice_Extensions.Text)
                cmd.Parameters.AddWithValue("@Voice_Location", Voice_Location.Text)
            ElseIf TabControl.TabPages.Contains(Tab3) Then
                SelectedTable = GlobalVars.tbl_MOBILE
                sqlQuery = "REPLACE INTO " & SelectedTable & " VALUES(@Id, @Username,  @Asset_ID, @Mobile_Brand, @Mobile_Model, @Mobile_IMEI, @Mobile_Network, @MobileContract) "
                cmd = New MySqlCommand(sqlQuery, GlobalVars.cn)
                cmd.Parameters.AddWithValue("@Id", Id)
                cmd.Parameters.AddWithValue("@Username", GlobalVars.Username)
                cmd.Parameters.AddWithValue("@Asset_ID", Asset_ID)
                cmd.Parameters.AddWithValue("@Mobile_Brand", Mobile_Brand.Text)
                cmd.Parameters.AddWithValue("@Mobile_Model", Mobile_Model.Text)
                cmd.Parameters.AddWithValue("@Mobile_IMEI", Mobile_IMEI.Text)
                cmd.Parameters.AddWithValue("@Mobile_Network", Mobile_Network.Text)
                cmd.Parameters.AddWithValue("@MobileContract", MobileContract.Text)
            ElseIf TabControl.TabPages.Contains(Tab4) Then
                SelectedTable = GlobalVars.tbl_APPLIANCE
                sqlQuery = "REPLACE INTO " & SelectedTable & " VALUES(@Id, @Username,  @Asset_ID, @Appliance_Type, @Appliance_Manufacturer, @Appliance_Model, @Appliance_Serial, @Appliance_Warranty, @Appliance_Location) "
                cmd = New MySqlCommand(sqlQuery, GlobalVars.cn)
                cmd.Parameters.AddWithValue("@Id", Id)
                cmd.Parameters.AddWithValue("@Username", GlobalVars.Username)
                cmd.Parameters.AddWithValue("@Asset_ID", Asset_ID)
                cmd.Parameters.AddWithValue("@Appliance_Type", Appliance_Type.Text)
                cmd.Parameters.AddWithValue("@Appliance_Manufacturer", Appliance_Manufacturer.Text)
                cmd.Parameters.AddWithValue("@Appliance_Model", Appliance_Model.Text)
                cmd.Parameters.AddWithValue("@Appliance_Serial", Appliance_Serial.Text)
                cmd.Parameters.AddWithValue("@Appliance_Warranty", Appliance_WarrantyPeriod.Text & " " & Appliance_Warranty.Text)
                cmd.Parameters.AddWithValue("@Appliance_Location", Appliance_Location.Text)
            ElseIf TabControl.TabPages.Contains(Tab5) Then
                SelectedTable = GlobalVars.tbl_PC
                sqlQuery = "REPLACE INTO " & SelectedTable & " VALUES(@Id, @Username,  @Asset_ID, @PC_Manufacturer, @PC_Model, @PC_Serial, @PC_Warranty, @PC_Username, @PC_Password, @PC_Location) "
                cmd = New MySqlCommand(sqlQuery, GlobalVars.cn)
                cmd.Parameters.AddWithValue("@Id", Id)
                cmd.Parameters.AddWithValue("@Username", GlobalVars.Username)
                cmd.Parameters.AddWithValue("@Asset_ID", Asset_ID)
                cmd.Parameters.AddWithValue("@PC_Manufacturer", PC_Manufacturer.Text)
                cmd.Parameters.AddWithValue("@PC_Model", PC_Model.Text)
                cmd.Parameters.AddWithValue("@PC_Serial", PC_Serial.Text)
                cmd.Parameters.AddWithValue("@PC_Warranty", PC_WarrantyPeriod.Text & " " & PC_Warranty.Text)
                cmd.Parameters.AddWithValue("@PC_Username", PC_Username.Text)
                cmd.Parameters.AddWithValue("@PC_Password", PC_Password.Text)
                cmd.Parameters.AddWithValue("@PC_Location", PC_Location.Text)
            ElseIf TabControl.TabPages.Contains(Tab6) Then
                SelectedTable = GlobalVars.tbl_TV
                sqlQuery = "REPLACE INTO " & SelectedTable & " VALUES(@Id, @Username,  @Asset_ID, @TV_Manufacturer, @TV_Model, @TV_Serial, @TV_Warranty, @TV_Location) "
                cmd = New MySqlCommand(sqlQuery, GlobalVars.cn)
                cmd.Parameters.AddWithValue("@Id", Id)
                cmd.Parameters.AddWithValue("@Username", GlobalVars.Username)
                cmd.Parameters.AddWithValue("@Asset_ID", Asset_ID)
                cmd.Parameters.AddWithValue("@TV_Manufacturer", TV_Manufacturer.Text)
                cmd.Parameters.AddWithValue("@TV_Model", TV_Model.Text)
                cmd.Parameters.AddWithValue("@TV_Serial", TV_Serial.Text)
                cmd.Parameters.AddWithValue("@TV_Warranty", TV_WarrantyPeriod.Text & " " & TV_Warranty.Text)
                cmd.Parameters.AddWithValue("@TV_Location", TV_Location.Text)
            ElseIf TabControl.TabPages.Contains(Tab8) Then
                SelectedTable = GlobalVars.tbl_DVRNVR
                Dim edObj = CDate(DVR_LicenseDue.Value)
                Dim ed As String
                ed = Format(edObj, "yyyyMMdd")

                sqlQuery = "REPLACE INTO " & SelectedTable & " VALUES(@Id, @Username,  @Asset_ID, @DVR_Model, @DVR_Channels, @DVR_Serial, @DVR_Username, @DVR_Password, @DVR_LicenseDue, @DVR_Software, @DVR_Location, @DVRMaintainerContract) "
                cmd = New MySqlCommand(sqlQuery, GlobalVars.cn)
                cmd.Parameters.AddWithValue("@Id", Id)
                cmd.Parameters.AddWithValue("@Username", GlobalVars.Username)
                cmd.Parameters.AddWithValue("@Asset_ID", Asset_ID)
                cmd.Parameters.AddWithValue("@DVR_Model", DVR_Model.Text)
                cmd.Parameters.AddWithValue("@DVR_Channels", DVR_Channels.Text)
                cmd.Parameters.AddWithValue("@DVR_Serial", DVR_Serial.Text)
                cmd.Parameters.AddWithValue("@DVR_Username", DVR_Username.Text)
                cmd.Parameters.AddWithValue("@DVR_Password", DVR_Password.Text)
                cmd.Parameters.AddWithValue("@DVR_LicenseDue", ed)
                cmd.Parameters.AddWithValue("@DVR_Software", DVR_Software.Text)
                cmd.Parameters.AddWithValue("@DVR_Location", DVR_Location.Text)
                cmd.Parameters.AddWithValue("@DVRMaintainerContract", DVRMaintainerContract.Text)
            ElseIf TabControl.TabPages.Contains(Tab9) Then
                SelectedTable = GlobalVars.tbl_CAR
                sqlQuery = "REPLACE INTO " & SelectedTable & " VALUES(@Id, @Username,  @Asset_ID, @Car_Make, @Car_Model, @Car_Keeper, @Car_Keeper_Address, @Car_VRN, @Car_Mileage, @MOTContract, @TAXContract, @InsuranceContract) "
                cmd = New MySqlCommand(sqlQuery, GlobalVars.cn)
                cmd.Parameters.AddWithValue("@Id", Id)
                cmd.Parameters.AddWithValue("@Username", GlobalVars.Username)
                cmd.Parameters.AddWithValue("@Asset_ID", Asset_ID)
                cmd.Parameters.AddWithValue("@Car_Make", Car_Make.Text)
                cmd.Parameters.AddWithValue("@Car_Model", Car_Model.Text)
                cmd.Parameters.AddWithValue("@Car_Keeper", Car_Keeper.Text)
                cmd.Parameters.AddWithValue("@Car_Keeper_Address", Car_Keeper_Address.Text)
                cmd.Parameters.AddWithValue("@Car_VRN", Car_VRN.Text)
                cmd.Parameters.AddWithValue("@Car_Mileage", Car_Mileage.Text)
                cmd.Parameters.AddWithValue("@MOTContract", MOTContract.Text)
                cmd.Parameters.AddWithValue("@TAXContract", TAXContract.Text)
                cmd.Parameters.AddWithValue("@InsuranceContract", InsuranceContract.Text)
            End If

            Try
                cmd.ExecuteNonQuery()
                OkBtn.Text = "OK"
                If NewRecord = True Then
                    Using _comm As New MySqlCommand()
                        With _comm
                            .Connection = GlobalVars.cn
                            .CommandText = "UPDATE " & GlobalVars.tbl_PROPERTIES & " SET TOTAL_ASSETS = TOTAL_ASSETS+1 WHERE PROPERTY_ID = '" & Id & "' "
                        End With
                        _comm.ExecuteNonQuery()
                    End Using
                    Me.Close()
                End If
            Catch ex As Exception
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Finally
                OkBtn.Enabled = True
            End Try
        Else
            Me.Close()
        End If
    End Sub

    Private Sub LinkContractBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LinkContractBtn.Click
        If EditMode = False Then
            LinkContractForm.Id = Id
            If LinkContractForm.ShowDialog() = Windows.Forms.DialogResult.OK Then
                MobileContract.Text = LinkContractForm.ContractsGrid.CurrentRow.Cells.Item(1).Value
            End If
        Else
            Dim form As New ContractForm
            Dim strArr() As String = MobileContract.Text.Split("-")
            If GlobalVars.isOpen("Contract - " & strArr(strArr.Length-1).Trim()) = False Then
                form.Id = Id
                form.Company = Company
                form.Address = Address
                form.Contract_ID = strArr(strArr.Length-1).Trim()
                form.ViewContract = True
                form.MdiParent = ParentMdiForm
                form.Show()
            End If
            End If
    End Sub

    Private Sub RemoveLineBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RemoveLineBtn.Click
        If MessageBox.Show("Are you sure you want to REMOVE this landline from this asset?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) = MsgBoxResult.Yes Then
            RemoveLineBtn.Enabled = False
            Dim sqlQuery As String = "DELETE FROM " & GlobalVars.tbl_LANDLINES & " WHERE PROPERTY_ID = @Id AND ASSET_ID = @Asset_ID AND TYPE = @Type AND NUMBER = @NUMBER AND CONTRACT = @Contract AND STATUS = @Status "
            Dim cmd As MySqlCommand
            cmd = New MySqlCommand(sqlQuery, GlobalVars.cn)
            cmd.Parameters.AddWithValue("@Id", Id)
            cmd.Parameters.AddWithValue("@Asset_ID", Asset_ID)
            cmd.Parameters.AddWithValue("@Type", LandlineGrid.CurrentRow.Cells(0).Value)
            cmd.Parameters.AddWithValue("@Number", LandlineGrid.CurrentRow.Cells(1).Value)
            cmd.Parameters.AddWithValue("@Contract", LandlineGrid.CurrentRow.Cells(2).Value)
            cmd.Parameters.AddWithValue("@Status", LandlineGrid.CurrentRow.Cells(3).Value)
            Try
                cmd.ExecuteNonQuery()
                ReadLandlines()
            Catch ex As Exception
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Finally
                RemoveLineBtn.Enabled = True
            End Try
        End If
    End Sub

    Private Sub AddViewCardBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AddViewCardBtn.Click
        Dim NewSkyDialog As New SkyDialog
        NewSkyDialog.Id = Id
        NewSkyDialog.Asset_ID = Asset_ID
        NewSkyDialog.NewRecord = True
        NewSkyDialog.EditMode = True
        If NewSkyDialog.ShowDialog() = Windows.Forms.DialogResult.OK Then
            ReadSkyCards()
        End If
    End Sub

    Private Sub RemoveViewCardBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RemoveViewCardBtn.Click
        If MessageBox.Show("Are you sure you want to REMOVE this viewing card from this asset?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) = MsgBoxResult.Yes Then
            RemoveViewCardBtn.Enabled = False
            Dim sqlQuery As String = "DELETE FROM " & GlobalVars.tbl_SKY & " WHERE PROPERTY_ID = '" & Id & "' AND ASSET_ID = '" & Asset_ID & "' "
            Dim cmd As MySqlCommand
            cmd = New MySqlCommand(sqlQuery, GlobalVars.cn)
            Try
                cmd.ExecuteNonQuery()
                ReadSkyCards()
            Catch ex As Exception
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Finally
                RemoveViewCardBtn.Enabled = True
            End Try
        End If
    End Sub

    Private Sub AttachPhotoBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AttachPhotoBtn.Click
        Dim openFileDialog = New OpenFileDialog()
        If openFileDialog.ShowDialog() = DialogResult.OK Then
            AttachPhotoBtn.Enabled = False
            AssetPicture.Load(openFileDialog.FileName)
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

                Dim sqlQuery As String = "REPLACE INTO " & GlobalVars.tbl_PICTURES & " VALUES(@Id, @Asset_ID, @Image, @Filename) "
                Dim cmd As New MySqlCommand(sqlQuery, GlobalVars.cn)
                cmd.Parameters.AddWithValue("@Id", Id)
                cmd.Parameters.AddWithValue("@Asset_ID", Asset_ID)
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

    Private Sub DeleteBtn_Click(sender As Object, e As EventArgs) Handles DeleteBtn.Click
        If SettingsINI.ReadINIValue("Prompts", "AskBeforeDeletingAssets").Equals("Yes") Then
            If MessageBox.Show("Are you sure you want to DELETE this asset from this property?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) = MsgBoxResult.No Then
                Exit Sub
            End If
        End If

        DeleteBtn.Enabled = False
        Dim sqlQuery As String = "DELETE FROM " & SelectedAssetTable & " WHERE PROPERTY_ID = '" & Id & "' AND ASSET_ID = '" & Asset_ID & "' "
        Dim cmd As MySqlCommand
        cmd = New MySqlCommand(sqlQuery, GlobalVars.cn)
        Try
            cmd.ExecuteNonQuery()
            Using _comm As New MySqlCommand()
                With _comm
                    .Connection = GlobalVars.cn
                    .CommandText = "UPDATE " & GlobalVars.tbl_PROPERTIES & " SET TOTAL_ASSETS = TOTAL_ASSETS-1 WHERE PROPERTY_ID = '" & Id & "' "
                End With
                _comm.ExecuteNonQuery()
            End Using
            Me.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            DeleteBtn.Enabled = True
        End Try
    End Sub

    Private Sub Appliance_WarrantyPeriod_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Appliance_WarrantyPeriod.KeyPress
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub PC_WarrantyPeriod_KeyPress(sender As Object, e As KeyPressEventArgs) Handles PC_WarrantyPeriod.KeyPress
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub TV_WarrantyPeriod_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TV_WarrantyPeriod.KeyPress
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub SkyGridView_CellMouseDoubleClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles SkyGridView.CellMouseDoubleClick
        If IsNothing(SkyGridView.CurrentRow) = False Then
            Dim NewSkyDialog As New SkyDialog
            NewSkyDialog.Id = Id
            NewSkyDialog.Asset_ID = SkyGridView.CurrentRow.Cells(0).Value.ToString
            NewSkyDialog.ShowDialog()
        End If
    End Sub

    Private Sub SkyTab_Enter(sender As Object, e As EventArgs) Handles SkyTab.Enter
        ReadSkyCardsData()
    End Sub

    Private Sub AddLogBtn_Click(sender As Object, e As EventArgs) Handles AddLogBtn.Click
        Dim NewLogForm As New LogForm
        NewLogForm.Id = Id
        NewLogForm.Log_ID = Asset_ID
        NewLogForm.Log_For = "Asset"
        NewLogForm.NewRecord = True
        If NewLogForm.ShowDialog() = Windows.Forms.DialogResult.OK Then
            ReadLogs()
        End If
    End Sub

    Private Sub LogsGrid_RowsAdded(sender As Object, e As DataGridViewRowsAddedEventArgs) Handles LogsGrid.RowsAdded
        If EditMode = True Then
            DeleteLogBtn.Enabled = True
        End If
    End Sub
End Class