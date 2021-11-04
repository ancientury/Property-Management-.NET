<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AssetForm
    Inherits DevComponents.DotNetBar.Metro.MetroForm

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle10 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AssetForm))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.AssetType = New PMD.SortComboBox()
        Me.Log_Box = New System.Windows.Forms.GroupBox()
        Me.AddLogBtn = New DevComponents.DotNetBar.ButtonX()
        Me.DeleteLogBtn = New DevComponents.DotNetBar.ButtonX()
        Me.LogsGrid = New DevComponents.DotNetBar.Controls.DataGridViewX()
        Me.AttachPhotoBtn = New DevComponents.DotNetBar.ButtonX()
        Me.AssetID = New System.Windows.Forms.Label()
        Me.TabControl = New System.Windows.Forms.TabControl()
        Me.MainTab = New System.Windows.Forms.TabPage()
        Me.Label59 = New System.Windows.Forms.Label()
        Me.DataTab = New System.Windows.Forms.TabPage()
        Me.DataMaintainerContract = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.LinkDataMaintainerBtn = New System.Windows.Forms.Button()
        Me.DataBBContract = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.LinkDataBBtn = New System.Windows.Forms.Button()
        Me.Data_Type = New System.Windows.Forms.ComboBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Data_Location = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Data_Password = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Data_Username = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Data_IPAddress = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Data_Model = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Data_Manufacturer = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.VoiceTab = New System.Windows.Forms.TabPage()
        Me.Voice_Location = New System.Windows.Forms.TextBox()
        Me.Label40 = New System.Windows.Forms.Label()
        Me.Label60 = New System.Windows.Forms.Label()
        Me.Voice_Extensions = New System.Windows.Forms.TextBox()
        Me.LandlineGrid = New System.Windows.Forms.DataGridView()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Voice_PIN = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Voice_Model = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Voice_Manufacturer = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.RemoveLineBtn = New System.Windows.Forms.Button()
        Me.AddLineBtn = New System.Windows.Forms.Button()
        Me.MobileTab = New System.Windows.Forms.TabPage()
        Me.Mobile_Brand = New System.Windows.Forms.TextBox()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.LinkContractBtn = New System.Windows.Forms.Button()
        Me.MobileContract = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Mobile_Network = New System.Windows.Forms.ComboBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Mobile_IMEI = New System.Windows.Forms.TextBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Mobile_Model = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.ApplianceTab = New System.Windows.Forms.TabPage()
        Me.Appliance_WarrantyPeriod = New System.Windows.Forms.TextBox()
        Me.Appliance_Warranty = New System.Windows.Forms.ComboBox()
        Me.Appliance_Location = New System.Windows.Forms.TextBox()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.Appliance_Serial = New System.Windows.Forms.TextBox()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.Appliance_Type = New System.Windows.Forms.TextBox()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Appliance_Model = New System.Windows.Forms.TextBox()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.Appliance_Manufacturer = New System.Windows.Forms.TextBox()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.PCTab = New System.Windows.Forms.TabPage()
        Me.PC_WarrantyPeriod = New System.Windows.Forms.TextBox()
        Me.PC_Location = New System.Windows.Forms.TextBox()
        Me.Label32 = New System.Windows.Forms.Label()
        Me.PC_Password = New System.Windows.Forms.TextBox()
        Me.Label31 = New System.Windows.Forms.Label()
        Me.PC_Warranty = New System.Windows.Forms.ComboBox()
        Me.PC_Username = New System.Windows.Forms.TextBox()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.Label27 = New System.Windows.Forms.Label()
        Me.PC_Serial = New System.Windows.Forms.TextBox()
        Me.Label28 = New System.Windows.Forms.Label()
        Me.PC_Model = New System.Windows.Forms.TextBox()
        Me.Label29 = New System.Windows.Forms.Label()
        Me.PC_Manufacturer = New System.Windows.Forms.TextBox()
        Me.Label30 = New System.Windows.Forms.Label()
        Me.TVTab = New System.Windows.Forms.TabPage()
        Me.TV_WarrantyPeriod = New System.Windows.Forms.TextBox()
        Me.TV_Location = New System.Windows.Forms.TextBox()
        Me.Label33 = New System.Windows.Forms.Label()
        Me.TV_Warranty = New System.Windows.Forms.ComboBox()
        Me.Label36 = New System.Windows.Forms.Label()
        Me.TV_Serial = New System.Windows.Forms.TextBox()
        Me.Label37 = New System.Windows.Forms.Label()
        Me.TV_Model = New System.Windows.Forms.TextBox()
        Me.Label38 = New System.Windows.Forms.Label()
        Me.TV_Manufacturer = New System.Windows.Forms.TextBox()
        Me.Label39 = New System.Windows.Forms.Label()
        Me.SkyTab = New System.Windows.Forms.TabPage()
        Me.RemoveViewCardBtn = New System.Windows.Forms.Button()
        Me.AddViewCardBtn = New System.Windows.Forms.Button()
        Me.SkyGridView = New System.Windows.Forms.DataGridView()
        Me.DVRTab = New System.Windows.Forms.TabPage()
        Me.DVR_Location = New System.Windows.Forms.TextBox()
        Me.Label41 = New System.Windows.Forms.Label()
        Me.DVRMaintainerContract = New System.Windows.Forms.Label()
        Me.Label50 = New System.Windows.Forms.Label()
        Me.LinkDVRMaintainerBtn = New System.Windows.Forms.Button()
        Me.DVR_Software = New System.Windows.Forms.TextBox()
        Me.Label48 = New System.Windows.Forms.Label()
        Me.DVR_LicenseDue = New System.Windows.Forms.DateTimePicker()
        Me.Label47 = New System.Windows.Forms.Label()
        Me.DVR_Password = New System.Windows.Forms.TextBox()
        Me.Label35 = New System.Windows.Forms.Label()
        Me.DVR_Username = New System.Windows.Forms.TextBox()
        Me.Label43 = New System.Windows.Forms.Label()
        Me.DVR_Serial = New System.Windows.Forms.TextBox()
        Me.Label44 = New System.Windows.Forms.Label()
        Me.DVR_Channels = New System.Windows.Forms.TextBox()
        Me.Label45 = New System.Windows.Forms.Label()
        Me.DVR_Model = New System.Windows.Forms.TextBox()
        Me.Label46 = New System.Windows.Forms.Label()
        Me.CarTab = New System.Windows.Forms.TabPage()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Car_Keeper_Address = New System.Windows.Forms.TextBox()
        Me.Label42 = New System.Windows.Forms.Label()
        Me.Car_Keeper = New System.Windows.Forms.TextBox()
        Me.Label34 = New System.Windows.Forms.Label()
        Me.Car_Make = New System.Windows.Forms.ComboBox()
        Me.InsuranceContract = New System.Windows.Forms.Label()
        Me.Label62 = New System.Windows.Forms.Label()
        Me.LinkInsuranceBtn = New System.Windows.Forms.Button()
        Me.TAXContract = New System.Windows.Forms.Label()
        Me.Label56 = New System.Windows.Forms.Label()
        Me.LinkTAXBtn = New System.Windows.Forms.Button()
        Me.MOTContract = New System.Windows.Forms.Label()
        Me.Label58 = New System.Windows.Forms.Label()
        Me.LinkMOTBtn = New System.Windows.Forms.Button()
        Me.Car_Mileage = New System.Windows.Forms.TextBox()
        Me.Label54 = New System.Windows.Forms.Label()
        Me.Car_VRN = New System.Windows.Forms.TextBox()
        Me.Label52 = New System.Windows.Forms.Label()
        Me.Label51 = New System.Windows.Forms.Label()
        Me.Car_Model = New System.Windows.Forms.TextBox()
        Me.Label49 = New System.Windows.Forms.Label()
        Me.AssetPicture = New System.Windows.Forms.PictureBox()
        Me.Header = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.AssetImageList = New System.Windows.Forms.ImageList(Me.components)
        Me.DeleteBtn = New System.Windows.Forms.Button()
        Me.CancelBtn = New System.Windows.Forms.Button()
        Me.OkBtn = New System.Windows.Forms.Button()
        Me.EditBtn = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.Log_Box.SuspendLayout()
        CType(Me.LogsGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabControl.SuspendLayout()
        Me.MainTab.SuspendLayout()
        Me.DataTab.SuspendLayout()
        Me.VoiceTab.SuspendLayout()
        CType(Me.LandlineGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MobileTab.SuspendLayout()
        Me.ApplianceTab.SuspendLayout()
        Me.PCTab.SuspendLayout()
        Me.TVTab.SuspendLayout()
        Me.SkyTab.SuspendLayout()
        CType(Me.SkyGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.DVRTab.SuspendLayout()
        Me.CarTab.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.AssetPicture, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.BackColor = System.Drawing.Color.White
        Me.GroupBox1.Controls.Add(Me.AssetType)
        Me.GroupBox1.Controls.Add(Me.Log_Box)
        Me.GroupBox1.Controls.Add(Me.AttachPhotoBtn)
        Me.GroupBox1.Controls.Add(Me.AssetID)
        Me.GroupBox1.Controls.Add(Me.TabControl)
        Me.GroupBox1.Controls.Add(Me.AssetPicture)
        Me.GroupBox1.Controls.Add(Me.Header)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.ForeColor = System.Drawing.Color.Black
        Me.GroupBox1.Location = New System.Drawing.Point(2, 3)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(714, 749)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Asset:"
        '
        'AssetType
        '
        Me.AssetType.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.AssetType.BackColor = System.Drawing.Color.White
        Me.AssetType.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.AssetType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.AssetType.ForeColor = System.Drawing.Color.Black
        Me.AssetType.FormattingEnabled = True
        Me.AssetType.Items.AddRange(New Object() {"Communication", "-- Data", "-- Voice (Landline)", "-- Mobile", "Domestic Appliances", "-- Appliance", "Entertainment", "-- PC", "-- TV", "-- Sky Box", "Security", "-- DVR/NVR", "Transport", "-- Car"})
        Me.AssetType.Location = New System.Drawing.Point(352, 213)
        Me.AssetType.Name = "AssetType"
        Me.AssetType.Size = New System.Drawing.Size(355, 21)
        Me.AssetType.TabIndex = 174
        '
        'Log_Box
        '
        Me.Log_Box.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Log_Box.BackColor = System.Drawing.Color.White
        Me.Log_Box.Controls.Add(Me.AddLogBtn)
        Me.Log_Box.Controls.Add(Me.DeleteLogBtn)
        Me.Log_Box.Controls.Add(Me.LogsGrid)
        Me.Log_Box.ForeColor = System.Drawing.Color.Black
        Me.Log_Box.Location = New System.Drawing.Point(3, 594)
        Me.Log_Box.Name = "Log_Box"
        Me.Log_Box.Padding = New System.Windows.Forms.Padding(5, 0, 5, 35)
        Me.Log_Box.Size = New System.Drawing.Size(708, 149)
        Me.Log_Box.TabIndex = 173
        Me.Log_Box.TabStop = False
        Me.Log_Box.Text = "Log:"
        '
        'AddLogBtn
        '
        Me.AddLogBtn.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.AddLogBtn.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.AddLogBtn.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.AddLogBtn.Image = Global.PMD.My.Resources.Resources._1364676805_plus_161
        Me.AddLogBtn.Location = New System.Drawing.Point(581, 117)
        Me.AddLogBtn.Name = "AddLogBtn"
        Me.AddLogBtn.Size = New System.Drawing.Size(122, 26)
        Me.AddLogBtn.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.AddLogBtn.TabIndex = 168
        Me.AddLogBtn.Text = "New Log"
        '
        'DeleteLogBtn
        '
        Me.DeleteLogBtn.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.DeleteLogBtn.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DeleteLogBtn.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.DeleteLogBtn.Enabled = False
        Me.DeleteLogBtn.HotTrackingStyle = DevComponents.DotNetBar.eHotTrackingStyle.Color
        Me.DeleteLogBtn.Image = Global.PMD.My.Resources.Resources._1364511183_dialog_close1
        Me.DeleteLogBtn.Location = New System.Drawing.Point(451, 117)
        Me.DeleteLogBtn.Name = "DeleteLogBtn"
        Me.DeleteLogBtn.Size = New System.Drawing.Size(122, 26)
        Me.DeleteLogBtn.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.DeleteLogBtn.TabIndex = 169
        Me.DeleteLogBtn.Text = "Delete Log"
        Me.DeleteLogBtn.Visible = False
        '
        'LogsGrid
        '
        Me.LogsGrid.AllowUserToAddRows = False
        Me.LogsGrid.AllowUserToDeleteRows = False
        Me.LogsGrid.AllowUserToOrderColumns = True
        Me.LogsGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.LogsGrid.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells
        Me.LogsGrid.BackgroundColor = System.Drawing.Color.White
        Me.LogsGrid.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.LogsGrid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.Black
        Me.LogsGrid.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle6
        Me.LogsGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle7.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle7.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle7.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.LogsGrid.DefaultCellStyle = DataGridViewCellStyle7
        Me.LogsGrid.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.LogsGrid.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.LogsGrid.EnableHeadersVisualStyles = False
        Me.LogsGrid.GridColor = System.Drawing.Color.FromArgb(CType(CType(170, Byte), Integer), CType(CType(170, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.LogsGrid.Location = New System.Drawing.Point(5, 16)
        Me.LogsGrid.MultiSelect = False
        Me.LogsGrid.Name = "LogsGrid"
        Me.LogsGrid.ReadOnly = True
        DataGridViewCellStyle8.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle8.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.Black
        Me.LogsGrid.RowHeadersDefaultCellStyle = DataGridViewCellStyle8
        Me.LogsGrid.RowHeadersVisible = False
        Me.LogsGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.LogsGrid.Size = New System.Drawing.Size(698, 98)
        Me.LogsGrid.TabIndex = 64
        Me.LogsGrid.TabStop = False
        '
        'AttachPhotoBtn
        '
        Me.AttachPhotoBtn.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.AttachPhotoBtn.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.AttachPhotoBtn.Image = Global.PMD.My.Resources.Resources._1366094008_link
        Me.AttachPhotoBtn.Location = New System.Drawing.Point(231, 183)
        Me.AttachPhotoBtn.Name = "AttachPhotoBtn"
        Me.AttachPhotoBtn.Size = New System.Drawing.Size(115, 26)
        Me.AttachPhotoBtn.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.AttachPhotoBtn.TabIndex = 172
        Me.AttachPhotoBtn.Text = "Attach Photo"
        Me.AttachPhotoBtn.Visible = False
        '
        'AssetID
        '
        Me.AssetID.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.AssetID.BackColor = System.Drawing.Color.White
        Me.AssetID.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.AssetID.ForeColor = System.Drawing.Color.Black
        Me.AssetID.Location = New System.Drawing.Point(9, 244)
        Me.AssetID.Name = "AssetID"
        Me.AssetID.Size = New System.Drawing.Size(699, 20)
        Me.AssetID.TabIndex = 35
        Me.AssetID.Text = "Asset ID:"
        Me.AssetID.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'TabControl
        '
        Me.TabControl.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TabControl.Controls.Add(Me.MainTab)
        Me.TabControl.Controls.Add(Me.DataTab)
        Me.TabControl.Controls.Add(Me.VoiceTab)
        Me.TabControl.Controls.Add(Me.MobileTab)
        Me.TabControl.Controls.Add(Me.ApplianceTab)
        Me.TabControl.Controls.Add(Me.PCTab)
        Me.TabControl.Controls.Add(Me.TVTab)
        Me.TabControl.Controls.Add(Me.SkyTab)
        Me.TabControl.Controls.Add(Me.DVRTab)
        Me.TabControl.Controls.Add(Me.CarTab)
        Me.TabControl.ForeColor = System.Drawing.Color.Black
        Me.TabControl.Location = New System.Drawing.Point(10, 270)
        Me.TabControl.Name = "TabControl"
        Me.TabControl.SelectedIndex = 0
        Me.TabControl.Size = New System.Drawing.Size(698, 318)
        Me.TabControl.TabIndex = 34
        '
        'MainTab
        '
        Me.MainTab.BackColor = System.Drawing.Color.FromArgb(CType(CType(211, Byte), Integer), CType(CType(211, Byte), Integer), CType(CType(211, Byte), Integer))
        Me.MainTab.Controls.Add(Me.Label59)
        Me.MainTab.ForeColor = System.Drawing.Color.Black
        Me.MainTab.Location = New System.Drawing.Point(4, 22)
        Me.MainTab.Name = "MainTab"
        Me.MainTab.Padding = New System.Windows.Forms.Padding(3)
        Me.MainTab.Size = New System.Drawing.Size(690, 292)
        Me.MainTab.TabIndex = 9
        Me.MainTab.Text = "Choose Asset type:"
        '
        'Label59
        '
        Me.Label59.AutoSize = True
        Me.Label59.BackColor = System.Drawing.Color.White
        Me.Label59.Font = New System.Drawing.Font("Segoe UI", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label59.ForeColor = System.Drawing.Color.Black
        Me.Label59.Location = New System.Drawing.Point(231, 186)
        Me.Label59.Name = "Label59"
        Me.Label59.Size = New System.Drawing.Size(212, 28)
        Me.Label59.TabIndex = 7
        Me.Label59.Text = "Choose the Asset Type."
        '
        'DataTab
        '
        Me.DataTab.AutoScroll = True
        Me.DataTab.BackColor = System.Drawing.Color.FromArgb(CType(CType(211, Byte), Integer), CType(CType(211, Byte), Integer), CType(CType(211, Byte), Integer))
        Me.DataTab.Controls.Add(Me.DataMaintainerContract)
        Me.DataTab.Controls.Add(Me.Label12)
        Me.DataTab.Controls.Add(Me.LinkDataMaintainerBtn)
        Me.DataTab.Controls.Add(Me.DataBBContract)
        Me.DataTab.Controls.Add(Me.Label10)
        Me.DataTab.Controls.Add(Me.LinkDataBBtn)
        Me.DataTab.Controls.Add(Me.Data_Type)
        Me.DataTab.Controls.Add(Me.Label8)
        Me.DataTab.Controls.Add(Me.Data_Location)
        Me.DataTab.Controls.Add(Me.Label7)
        Me.DataTab.Controls.Add(Me.Data_Password)
        Me.DataTab.Controls.Add(Me.Label6)
        Me.DataTab.Controls.Add(Me.Data_Username)
        Me.DataTab.Controls.Add(Me.Label5)
        Me.DataTab.Controls.Add(Me.Data_IPAddress)
        Me.DataTab.Controls.Add(Me.Label4)
        Me.DataTab.Controls.Add(Me.Data_Model)
        Me.DataTab.Controls.Add(Me.Label3)
        Me.DataTab.Controls.Add(Me.Data_Manufacturer)
        Me.DataTab.Controls.Add(Me.Label1)
        Me.DataTab.ForeColor = System.Drawing.Color.Black
        Me.DataTab.Location = New System.Drawing.Point(4, 22)
        Me.DataTab.Name = "DataTab"
        Me.DataTab.Padding = New System.Windows.Forms.Padding(3)
        Me.DataTab.Size = New System.Drawing.Size(690, 292)
        Me.DataTab.TabIndex = 0
        Me.DataTab.Text = "Input - Data"
        '
        'DataMaintainerContract
        '
        Me.DataMaintainerContract.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.DataMaintainerContract.BackColor = System.Drawing.Color.White
        Me.DataMaintainerContract.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DataMaintainerContract.ForeColor = System.Drawing.Color.Black
        Me.DataMaintainerContract.Location = New System.Drawing.Point(323, 229)
        Me.DataMaintainerContract.Name = "DataMaintainerContract"
        Me.DataMaintainerContract.Size = New System.Drawing.Size(243, 30)
        Me.DataMaintainerContract.TabIndex = 45
        Me.DataMaintainerContract.Text = "None"
        '
        'Label12
        '
        Me.Label12.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label12.BackColor = System.Drawing.Color.White
        Me.Label12.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.Black
        Me.Label12.Location = New System.Drawing.Point(15, 230)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(302, 20)
        Me.Label12.TabIndex = 44
        Me.Label12.Text = "Maintainer:"
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'LinkDataMaintainerBtn
        '
        Me.LinkDataMaintainerBtn.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.LinkDataMaintainerBtn.BackColor = System.Drawing.Color.White
        Me.LinkDataMaintainerBtn.ForeColor = System.Drawing.Color.Black
        Me.LinkDataMaintainerBtn.Location = New System.Drawing.Point(571, 226)
        Me.LinkDataMaintainerBtn.Name = "LinkDataMaintainerBtn"
        Me.LinkDataMaintainerBtn.Size = New System.Drawing.Size(98, 23)
        Me.LinkDataMaintainerBtn.TabIndex = 43
        Me.LinkDataMaintainerBtn.Text = "Link Maintainer"
        Me.LinkDataMaintainerBtn.UseVisualStyleBackColor = False
        '
        'DataBBContract
        '
        Me.DataBBContract.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.DataBBContract.BackColor = System.Drawing.Color.White
        Me.DataBBContract.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DataBBContract.ForeColor = System.Drawing.Color.Black
        Me.DataBBContract.Location = New System.Drawing.Point(323, 193)
        Me.DataBBContract.Name = "DataBBContract"
        Me.DataBBContract.Size = New System.Drawing.Size(243, 33)
        Me.DataBBContract.TabIndex = 42
        Me.DataBBContract.Text = "None"
        '
        'Label10
        '
        Me.Label10.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label10.BackColor = System.Drawing.Color.White
        Me.Label10.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.Black
        Me.Label10.Location = New System.Drawing.Point(15, 195)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(302, 20)
        Me.Label10.TabIndex = 41
        Me.Label10.Text = "Broadband Line:"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'LinkDataBBtn
        '
        Me.LinkDataBBtn.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.LinkDataBBtn.BackColor = System.Drawing.Color.White
        Me.LinkDataBBtn.ForeColor = System.Drawing.Color.Black
        Me.LinkDataBBtn.Location = New System.Drawing.Point(571, 193)
        Me.LinkDataBBtn.Name = "LinkDataBBtn"
        Me.LinkDataBBtn.Size = New System.Drawing.Size(98, 23)
        Me.LinkDataBBtn.TabIndex = 39
        Me.LinkDataBBtn.Text = "Link Provider"
        Me.LinkDataBBtn.UseVisualStyleBackColor = False
        '
        'Data_Type
        '
        Me.Data_Type.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Data_Type.BackColor = System.Drawing.Color.White
        Me.Data_Type.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Data_Type.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Data_Type.ForeColor = System.Drawing.Color.Black
        Me.Data_Type.FormattingEnabled = True
        Me.Data_Type.Items.AddRange(New Object() {"Router", "Access Point", "PowerLine"})
        Me.Data_Type.Location = New System.Drawing.Point(325, 24)
        Me.Data_Type.Name = "Data_Type"
        Me.Data_Type.Size = New System.Drawing.Size(344, 24)
        Me.Data_Type.TabIndex = 13
        '
        'Label8
        '
        Me.Label8.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label8.BackColor = System.Drawing.Color.White
        Me.Label8.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Black
        Me.Label8.Location = New System.Drawing.Point(15, 26)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(302, 20)
        Me.Label8.TabIndex = 12
        Me.Label8.Text = "Type:"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Data_Location
        '
        Me.Data_Location.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Data_Location.BackColor = System.Drawing.Color.White
        Me.Data_Location.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Data_Location.ForeColor = System.Drawing.Color.Black
        Me.Data_Location.Location = New System.Drawing.Point(325, 168)
        Me.Data_Location.MaxLength = 50
        Me.Data_Location.Name = "Data_Location"
        Me.Data_Location.Size = New System.Drawing.Size(344, 22)
        Me.Data_Location.TabIndex = 11
        '
        'Label7
        '
        Me.Label7.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label7.BackColor = System.Drawing.Color.White
        Me.Label7.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Black
        Me.Label7.Location = New System.Drawing.Point(15, 169)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(302, 20)
        Me.Label7.TabIndex = 10
        Me.Label7.Text = "Location:"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Data_Password
        '
        Me.Data_Password.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Data_Password.BackColor = System.Drawing.Color.White
        Me.Data_Password.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Data_Password.ForeColor = System.Drawing.Color.Black
        Me.Data_Password.Location = New System.Drawing.Point(325, 145)
        Me.Data_Password.MaxLength = 50
        Me.Data_Password.Name = "Data_Password"
        Me.Data_Password.Size = New System.Drawing.Size(344, 22)
        Me.Data_Password.TabIndex = 9
        '
        'Label6
        '
        Me.Label6.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label6.BackColor = System.Drawing.Color.White
        Me.Label6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Black
        Me.Label6.Location = New System.Drawing.Point(15, 146)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(302, 20)
        Me.Label6.TabIndex = 8
        Me.Label6.Text = "Password:"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Data_Username
        '
        Me.Data_Username.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Data_Username.BackColor = System.Drawing.Color.White
        Me.Data_Username.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Data_Username.ForeColor = System.Drawing.Color.Black
        Me.Data_Username.Location = New System.Drawing.Point(325, 121)
        Me.Data_Username.MaxLength = 50
        Me.Data_Username.Name = "Data_Username"
        Me.Data_Username.Size = New System.Drawing.Size(344, 22)
        Me.Data_Username.TabIndex = 7
        '
        'Label5
        '
        Me.Label5.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label5.BackColor = System.Drawing.Color.White
        Me.Label5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(15, 122)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(302, 20)
        Me.Label5.TabIndex = 6
        Me.Label5.Text = "Username:"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Data_IPAddress
        '
        Me.Data_IPAddress.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Data_IPAddress.BackColor = System.Drawing.Color.White
        Me.Data_IPAddress.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Data_IPAddress.ForeColor = System.Drawing.Color.Black
        Me.Data_IPAddress.Location = New System.Drawing.Point(325, 97)
        Me.Data_IPAddress.MaxLength = 15
        Me.Data_IPAddress.Name = "Data_IPAddress"
        Me.Data_IPAddress.Size = New System.Drawing.Size(344, 22)
        Me.Data_IPAddress.TabIndex = 5
        '
        'Label4
        '
        Me.Label4.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label4.BackColor = System.Drawing.Color.White
        Me.Label4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(15, 98)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(302, 20)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "IP Address:"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Data_Model
        '
        Me.Data_Model.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Data_Model.BackColor = System.Drawing.Color.White
        Me.Data_Model.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Data_Model.ForeColor = System.Drawing.Color.Black
        Me.Data_Model.Location = New System.Drawing.Point(325, 73)
        Me.Data_Model.MaxLength = 50
        Me.Data_Model.Name = "Data_Model"
        Me.Data_Model.Size = New System.Drawing.Size(344, 22)
        Me.Data_Model.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label3.BackColor = System.Drawing.Color.White
        Me.Label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(15, 74)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(302, 20)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Model Number:"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Data_Manufacturer
        '
        Me.Data_Manufacturer.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Data_Manufacturer.BackColor = System.Drawing.Color.White
        Me.Data_Manufacturer.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Data_Manufacturer.ForeColor = System.Drawing.Color.Black
        Me.Data_Manufacturer.Location = New System.Drawing.Point(325, 49)
        Me.Data_Manufacturer.MaxLength = 50
        Me.Data_Manufacturer.Name = "Data_Manufacturer"
        Me.Data_Manufacturer.Size = New System.Drawing.Size(344, 22)
        Me.Data_Manufacturer.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label1.BackColor = System.Drawing.Color.White
        Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(15, 50)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(302, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Manufacturer:"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'VoiceTab
        '
        Me.VoiceTab.AutoScroll = True
        Me.VoiceTab.BackColor = System.Drawing.Color.FromArgb(CType(CType(211, Byte), Integer), CType(CType(211, Byte), Integer), CType(CType(211, Byte), Integer))
        Me.VoiceTab.Controls.Add(Me.Voice_Location)
        Me.VoiceTab.Controls.Add(Me.Label40)
        Me.VoiceTab.Controls.Add(Me.Label60)
        Me.VoiceTab.Controls.Add(Me.Voice_Extensions)
        Me.VoiceTab.Controls.Add(Me.LandlineGrid)
        Me.VoiceTab.Controls.Add(Me.Label14)
        Me.VoiceTab.Controls.Add(Me.Voice_PIN)
        Me.VoiceTab.Controls.Add(Me.Label13)
        Me.VoiceTab.Controls.Add(Me.Voice_Model)
        Me.VoiceTab.Controls.Add(Me.Label11)
        Me.VoiceTab.Controls.Add(Me.Voice_Manufacturer)
        Me.VoiceTab.Controls.Add(Me.Label9)
        Me.VoiceTab.Controls.Add(Me.RemoveLineBtn)
        Me.VoiceTab.Controls.Add(Me.AddLineBtn)
        Me.VoiceTab.ForeColor = System.Drawing.Color.Black
        Me.VoiceTab.Location = New System.Drawing.Point(4, 22)
        Me.VoiceTab.Name = "VoiceTab"
        Me.VoiceTab.Padding = New System.Windows.Forms.Padding(3)
        Me.VoiceTab.Size = New System.Drawing.Size(690, 292)
        Me.VoiceTab.TabIndex = 1
        Me.VoiceTab.Text = "Input - Voice"
        '
        'Voice_Location
        '
        Me.Voice_Location.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Voice_Location.BackColor = System.Drawing.Color.White
        Me.Voice_Location.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Voice_Location.ForeColor = System.Drawing.Color.Black
        Me.Voice_Location.Location = New System.Drawing.Point(310, 114)
        Me.Voice_Location.MaxLength = 5
        Me.Voice_Location.Name = "Voice_Location"
        Me.Voice_Location.Size = New System.Drawing.Size(355, 22)
        Me.Voice_Location.TabIndex = 15
        '
        'Label40
        '
        Me.Label40.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label40.BackColor = System.Drawing.Color.White
        Me.Label40.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label40.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label40.ForeColor = System.Drawing.Color.Black
        Me.Label40.Location = New System.Drawing.Point(17, 114)
        Me.Label40.Name = "Label40"
        Me.Label40.Size = New System.Drawing.Size(287, 20)
        Me.Label40.TabIndex = 14
        Me.Label40.Text = "Location:"
        Me.Label40.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label60
        '
        Me.Label60.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label60.BackColor = System.Drawing.Color.White
        Me.Label60.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label60.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label60.ForeColor = System.Drawing.Color.Black
        Me.Label60.Location = New System.Drawing.Point(17, 139)
        Me.Label60.Name = "Label60"
        Me.Label60.Size = New System.Drawing.Size(648, 20)
        Me.Label60.TabIndex = 13
        Me.Label60.Text = "Landlines:"
        Me.Label60.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Voice_Extensions
        '
        Me.Voice_Extensions.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Voice_Extensions.BackColor = System.Drawing.Color.White
        Me.Voice_Extensions.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Voice_Extensions.ForeColor = System.Drawing.Color.Black
        Me.Voice_Extensions.Location = New System.Drawing.Point(310, 89)
        Me.Voice_Extensions.MaxLength = 5
        Me.Voice_Extensions.Name = "Voice_Extensions"
        Me.Voice_Extensions.Size = New System.Drawing.Size(355, 22)
        Me.Voice_Extensions.TabIndex = 12
        '
        'LandlineGrid
        '
        Me.LandlineGrid.AllowUserToAddRows = False
        Me.LandlineGrid.AllowUserToDeleteRows = False
        DataGridViewCellStyle9.BackColor = System.Drawing.Color.White
        Me.LandlineGrid.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle9
        Me.LandlineGrid.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LandlineGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.LandlineGrid.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.LandlineGrid.BackgroundColor = System.Drawing.SystemColors.Window
        Me.LandlineGrid.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.LandlineGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.LandlineGrid.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.LandlineGrid.Location = New System.Drawing.Point(17, 166)
        Me.LandlineGrid.Name = "LandlineGrid"
        Me.LandlineGrid.ReadOnly = True
        Me.LandlineGrid.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        Me.LandlineGrid.RowHeadersVisible = False
        Me.LandlineGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.LandlineGrid.Size = New System.Drawing.Size(648, 89)
        Me.LandlineGrid.TabIndex = 9
        '
        'Label14
        '
        Me.Label14.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label14.BackColor = System.Drawing.Color.White
        Me.Label14.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.Color.Black
        Me.Label14.Location = New System.Drawing.Point(17, 89)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(287, 20)
        Me.Label14.TabIndex = 8
        Me.Label14.Text = "Extensions:"
        Me.Label14.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Voice_PIN
        '
        Me.Voice_PIN.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Voice_PIN.BackColor = System.Drawing.Color.White
        Me.Voice_PIN.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Voice_PIN.ForeColor = System.Drawing.Color.Black
        Me.Voice_PIN.Location = New System.Drawing.Point(310, 62)
        Me.Voice_PIN.MaxLength = 50
        Me.Voice_PIN.Name = "Voice_PIN"
        Me.Voice_PIN.Size = New System.Drawing.Size(355, 22)
        Me.Voice_PIN.TabIndex = 7
        '
        'Label13
        '
        Me.Label13.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label13.BackColor = System.Drawing.Color.White
        Me.Label13.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.Black
        Me.Label13.Location = New System.Drawing.Point(17, 63)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(287, 20)
        Me.Label13.TabIndex = 6
        Me.Label13.Text = "PIN Number:"
        Me.Label13.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Voice_Model
        '
        Me.Voice_Model.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Voice_Model.BackColor = System.Drawing.Color.White
        Me.Voice_Model.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Voice_Model.ForeColor = System.Drawing.Color.Black
        Me.Voice_Model.Location = New System.Drawing.Point(310, 37)
        Me.Voice_Model.MaxLength = 50
        Me.Voice_Model.Name = "Voice_Model"
        Me.Voice_Model.Size = New System.Drawing.Size(355, 22)
        Me.Voice_Model.TabIndex = 5
        '
        'Label11
        '
        Me.Label11.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label11.BackColor = System.Drawing.Color.White
        Me.Label11.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.Black
        Me.Label11.Location = New System.Drawing.Point(17, 38)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(287, 20)
        Me.Label11.TabIndex = 4
        Me.Label11.Text = "PBX Model:"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Voice_Manufacturer
        '
        Me.Voice_Manufacturer.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Voice_Manufacturer.BackColor = System.Drawing.Color.White
        Me.Voice_Manufacturer.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Voice_Manufacturer.ForeColor = System.Drawing.Color.Black
        Me.Voice_Manufacturer.Location = New System.Drawing.Point(310, 12)
        Me.Voice_Manufacturer.MaxLength = 50
        Me.Voice_Manufacturer.Name = "Voice_Manufacturer"
        Me.Voice_Manufacturer.Size = New System.Drawing.Size(355, 22)
        Me.Voice_Manufacturer.TabIndex = 3
        '
        'Label9
        '
        Me.Label9.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label9.BackColor = System.Drawing.Color.White
        Me.Label9.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.Black
        Me.Label9.Location = New System.Drawing.Point(17, 13)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(287, 20)
        Me.Label9.TabIndex = 2
        Me.Label9.Text = "PBX Manufacturer:"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'RemoveLineBtn
        '
        Me.RemoveLineBtn.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.RemoveLineBtn.BackColor = System.Drawing.Color.White
        Me.RemoveLineBtn.ForeColor = System.Drawing.Color.Black
        Me.RemoveLineBtn.Image = Global.PMD.My.Resources.Resources._1364945045_list_remove
        Me.RemoveLineBtn.Location = New System.Drawing.Point(419, 261)
        Me.RemoveLineBtn.Name = "RemoveLineBtn"
        Me.RemoveLineBtn.Size = New System.Drawing.Size(122, 25)
        Me.RemoveLineBtn.TabIndex = 11
        Me.RemoveLineBtn.Text = "Remove Landline"
        Me.RemoveLineBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.RemoveLineBtn.UseVisualStyleBackColor = False
        Me.RemoveLineBtn.Visible = False
        '
        'AddLineBtn
        '
        Me.AddLineBtn.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.AddLineBtn.BackColor = System.Drawing.Color.White
        Me.AddLineBtn.Cursor = System.Windows.Forms.Cursors.Default
        Me.AddLineBtn.ForeColor = System.Drawing.Color.Black
        Me.AddLineBtn.Image = Global.PMD.My.Resources.Resources._1364676805_plus_161
        Me.AddLineBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.AddLineBtn.Location = New System.Drawing.Point(543, 261)
        Me.AddLineBtn.Name = "AddLineBtn"
        Me.AddLineBtn.Size = New System.Drawing.Size(122, 25)
        Me.AddLineBtn.TabIndex = 10
        Me.AddLineBtn.Text = "Add Landline"
        Me.AddLineBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.AddLineBtn.UseVisualStyleBackColor = False
        '
        'MobileTab
        '
        Me.MobileTab.AutoScroll = True
        Me.MobileTab.BackColor = System.Drawing.Color.FromArgb(CType(CType(211, Byte), Integer), CType(CType(211, Byte), Integer), CType(CType(211, Byte), Integer))
        Me.MobileTab.Controls.Add(Me.Mobile_Brand)
        Me.MobileTab.Controls.Add(Me.Label19)
        Me.MobileTab.Controls.Add(Me.LinkContractBtn)
        Me.MobileTab.Controls.Add(Me.MobileContract)
        Me.MobileTab.Controls.Add(Me.Label18)
        Me.MobileTab.Controls.Add(Me.Mobile_Network)
        Me.MobileTab.Controls.Add(Me.Label17)
        Me.MobileTab.Controls.Add(Me.Mobile_IMEI)
        Me.MobileTab.Controls.Add(Me.Label16)
        Me.MobileTab.Controls.Add(Me.Mobile_Model)
        Me.MobileTab.Controls.Add(Me.Label15)
        Me.MobileTab.ForeColor = System.Drawing.Color.Black
        Me.MobileTab.Location = New System.Drawing.Point(4, 22)
        Me.MobileTab.Name = "MobileTab"
        Me.MobileTab.Padding = New System.Windows.Forms.Padding(3)
        Me.MobileTab.Size = New System.Drawing.Size(690, 292)
        Me.MobileTab.TabIndex = 2
        Me.MobileTab.Text = "Input - Mobile"
        '
        'Mobile_Brand
        '
        Me.Mobile_Brand.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Mobile_Brand.BackColor = System.Drawing.Color.White
        Me.Mobile_Brand.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Mobile_Brand.ForeColor = System.Drawing.Color.Black
        Me.Mobile_Brand.Location = New System.Drawing.Point(310, 25)
        Me.Mobile_Brand.MaxLength = 20
        Me.Mobile_Brand.Name = "Mobile_Brand"
        Me.Mobile_Brand.Size = New System.Drawing.Size(361, 22)
        Me.Mobile_Brand.TabIndex = 46
        '
        'Label19
        '
        Me.Label19.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label19.BackColor = System.Drawing.Color.White
        Me.Label19.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label19.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.ForeColor = System.Drawing.Color.Black
        Me.Label19.Location = New System.Drawing.Point(16, 25)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(288, 20)
        Me.Label19.TabIndex = 45
        Me.Label19.Text = "Brand:"
        Me.Label19.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'LinkContractBtn
        '
        Me.LinkContractBtn.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.LinkContractBtn.BackColor = System.Drawing.Color.White
        Me.LinkContractBtn.Enabled = False
        Me.LinkContractBtn.ForeColor = System.Drawing.Color.Black
        Me.LinkContractBtn.Location = New System.Drawing.Point(564, 129)
        Me.LinkContractBtn.Name = "LinkContractBtn"
        Me.LinkContractBtn.Size = New System.Drawing.Size(107, 25)
        Me.LinkContractBtn.TabIndex = 44
        Me.LinkContractBtn.Text = "Link Contract"
        Me.LinkContractBtn.UseVisualStyleBackColor = False
        '
        'MobileContract
        '
        Me.MobileContract.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.MobileContract.BackColor = System.Drawing.Color.White
        Me.MobileContract.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MobileContract.ForeColor = System.Drawing.Color.Black
        Me.MobileContract.Location = New System.Drawing.Point(308, 129)
        Me.MobileContract.Name = "MobileContract"
        Me.MobileContract.Size = New System.Drawing.Size(251, 23)
        Me.MobileContract.TabIndex = 43
        Me.MobileContract.Text = "Offline"
        '
        'Label18
        '
        Me.Label18.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label18.BackColor = System.Drawing.Color.White
        Me.Label18.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label18.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.ForeColor = System.Drawing.Color.Black
        Me.Label18.Location = New System.Drawing.Point(16, 127)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(288, 23)
        Me.Label18.TabIndex = 8
        Me.Label18.Text = "Contract:"
        Me.Label18.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Mobile_Network
        '
        Me.Mobile_Network.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Mobile_Network.BackColor = System.Drawing.Color.White
        Me.Mobile_Network.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Mobile_Network.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Mobile_Network.ForeColor = System.Drawing.Color.Black
        Me.Mobile_Network.FormattingEnabled = True
        Me.Mobile_Network.Items.AddRange(New Object() {"Three", "O2", "Orange", "T-Mobile", "EE (Orange/T-Mobile)", "Vodafone"})
        Me.Mobile_Network.Location = New System.Drawing.Point(310, 101)
        Me.Mobile_Network.Name = "Mobile_Network"
        Me.Mobile_Network.Size = New System.Drawing.Size(361, 24)
        Me.Mobile_Network.TabIndex = 7
        '
        'Label17
        '
        Me.Label17.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label17.BackColor = System.Drawing.Color.White
        Me.Label17.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.ForeColor = System.Drawing.Color.Black
        Me.Label17.Location = New System.Drawing.Point(16, 102)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(288, 20)
        Me.Label17.TabIndex = 6
        Me.Label17.Text = "Network:"
        Me.Label17.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Mobile_IMEI
        '
        Me.Mobile_IMEI.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Mobile_IMEI.BackColor = System.Drawing.Color.White
        Me.Mobile_IMEI.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Mobile_IMEI.ForeColor = System.Drawing.Color.Black
        Me.Mobile_IMEI.Location = New System.Drawing.Point(310, 75)
        Me.Mobile_IMEI.MaxLength = 50
        Me.Mobile_IMEI.Name = "Mobile_IMEI"
        Me.Mobile_IMEI.Size = New System.Drawing.Size(361, 22)
        Me.Mobile_IMEI.TabIndex = 5
        '
        'Label16
        '
        Me.Label16.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label16.BackColor = System.Drawing.Color.White
        Me.Label16.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.ForeColor = System.Drawing.Color.Black
        Me.Label16.Location = New System.Drawing.Point(16, 76)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(288, 20)
        Me.Label16.TabIndex = 4
        Me.Label16.Text = "IMEI Number:"
        Me.Label16.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Mobile_Model
        '
        Me.Mobile_Model.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Mobile_Model.BackColor = System.Drawing.Color.White
        Me.Mobile_Model.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Mobile_Model.ForeColor = System.Drawing.Color.Black
        Me.Mobile_Model.Location = New System.Drawing.Point(310, 50)
        Me.Mobile_Model.MaxLength = 50
        Me.Mobile_Model.Name = "Mobile_Model"
        Me.Mobile_Model.Size = New System.Drawing.Size(361, 22)
        Me.Mobile_Model.TabIndex = 3
        '
        'Label15
        '
        Me.Label15.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label15.BackColor = System.Drawing.Color.White
        Me.Label15.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.Color.Black
        Me.Label15.Location = New System.Drawing.Point(16, 51)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(288, 20)
        Me.Label15.TabIndex = 2
        Me.Label15.Text = "Model Number:"
        Me.Label15.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'ApplianceTab
        '
        Me.ApplianceTab.AutoScroll = True
        Me.ApplianceTab.BackColor = System.Drawing.Color.FromArgb(CType(CType(211, Byte), Integer), CType(CType(211, Byte), Integer), CType(CType(211, Byte), Integer))
        Me.ApplianceTab.Controls.Add(Me.Appliance_WarrantyPeriod)
        Me.ApplianceTab.Controls.Add(Me.Appliance_Warranty)
        Me.ApplianceTab.Controls.Add(Me.Appliance_Location)
        Me.ApplianceTab.Controls.Add(Me.Label25)
        Me.ApplianceTab.Controls.Add(Me.Label24)
        Me.ApplianceTab.Controls.Add(Me.Appliance_Serial)
        Me.ApplianceTab.Controls.Add(Me.Label23)
        Me.ApplianceTab.Controls.Add(Me.Appliance_Type)
        Me.ApplianceTab.Controls.Add(Me.Label20)
        Me.ApplianceTab.Controls.Add(Me.Appliance_Model)
        Me.ApplianceTab.Controls.Add(Me.Label21)
        Me.ApplianceTab.Controls.Add(Me.Appliance_Manufacturer)
        Me.ApplianceTab.Controls.Add(Me.Label22)
        Me.ApplianceTab.ForeColor = System.Drawing.Color.Black
        Me.ApplianceTab.Location = New System.Drawing.Point(4, 22)
        Me.ApplianceTab.Name = "ApplianceTab"
        Me.ApplianceTab.Padding = New System.Windows.Forms.Padding(3)
        Me.ApplianceTab.Size = New System.Drawing.Size(690, 292)
        Me.ApplianceTab.TabIndex = 3
        Me.ApplianceTab.Text = "Input - Appliance"
        '
        'Appliance_WarrantyPeriod
        '
        Me.Appliance_WarrantyPeriod.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Appliance_WarrantyPeriod.BackColor = System.Drawing.Color.White
        Me.Appliance_WarrantyPeriod.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Appliance_WarrantyPeriod.ForeColor = System.Drawing.Color.Black
        Me.Appliance_WarrantyPeriod.Location = New System.Drawing.Point(313, 125)
        Me.Appliance_WarrantyPeriod.Name = "Appliance_WarrantyPeriod"
        Me.Appliance_WarrantyPeriod.Size = New System.Drawing.Size(200, 22)
        Me.Appliance_WarrantyPeriod.TabIndex = 32
        '
        'Appliance_Warranty
        '
        Me.Appliance_Warranty.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Appliance_Warranty.BackColor = System.Drawing.Color.White
        Me.Appliance_Warranty.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Appliance_Warranty.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Appliance_Warranty.ForeColor = System.Drawing.Color.Black
        Me.Appliance_Warranty.FormattingEnabled = True
        Me.Appliance_Warranty.Items.AddRange(New Object() {"Years", "Months", "Weeks", "Days"})
        Me.Appliance_Warranty.Location = New System.Drawing.Point(517, 125)
        Me.Appliance_Warranty.Name = "Appliance_Warranty"
        Me.Appliance_Warranty.Size = New System.Drawing.Size(148, 23)
        Me.Appliance_Warranty.TabIndex = 31
        '
        'Appliance_Location
        '
        Me.Appliance_Location.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Appliance_Location.BackColor = System.Drawing.Color.White
        Me.Appliance_Location.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Appliance_Location.ForeColor = System.Drawing.Color.Black
        Me.Appliance_Location.Location = New System.Drawing.Point(313, 149)
        Me.Appliance_Location.MaxLength = 50
        Me.Appliance_Location.Name = "Appliance_Location"
        Me.Appliance_Location.Size = New System.Drawing.Size(352, 22)
        Me.Appliance_Location.TabIndex = 25
        '
        'Label25
        '
        Me.Label25.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label25.BackColor = System.Drawing.Color.White
        Me.Label25.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label25.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label25.ForeColor = System.Drawing.Color.Black
        Me.Label25.Location = New System.Drawing.Point(16, 149)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(291, 20)
        Me.Label25.TabIndex = 24
        Me.Label25.Text = "Location:"
        Me.Label25.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label24
        '
        Me.Label24.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label24.BackColor = System.Drawing.Color.White
        Me.Label24.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label24.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label24.ForeColor = System.Drawing.Color.Black
        Me.Label24.Location = New System.Drawing.Point(16, 125)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(291, 20)
        Me.Label24.TabIndex = 22
        Me.Label24.Text = "Warranty (Period):"
        Me.Label24.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Appliance_Serial
        '
        Me.Appliance_Serial.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Appliance_Serial.BackColor = System.Drawing.Color.White
        Me.Appliance_Serial.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Appliance_Serial.ForeColor = System.Drawing.Color.Black
        Me.Appliance_Serial.Location = New System.Drawing.Point(313, 100)
        Me.Appliance_Serial.MaxLength = 50
        Me.Appliance_Serial.Name = "Appliance_Serial"
        Me.Appliance_Serial.Size = New System.Drawing.Size(352, 22)
        Me.Appliance_Serial.TabIndex = 21
        '
        'Label23
        '
        Me.Label23.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label23.BackColor = System.Drawing.Color.White
        Me.Label23.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label23.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label23.ForeColor = System.Drawing.Color.Black
        Me.Label23.Location = New System.Drawing.Point(16, 100)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(291, 20)
        Me.Label23.TabIndex = 20
        Me.Label23.Text = "Serial Number:"
        Me.Label23.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Appliance_Type
        '
        Me.Appliance_Type.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Appliance_Type.BackColor = System.Drawing.Color.White
        Me.Appliance_Type.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Appliance_Type.ForeColor = System.Drawing.Color.Black
        Me.Appliance_Type.Location = New System.Drawing.Point(313, 26)
        Me.Appliance_Type.MaxLength = 50
        Me.Appliance_Type.Name = "Appliance_Type"
        Me.Appliance_Type.Size = New System.Drawing.Size(352, 22)
        Me.Appliance_Type.TabIndex = 19
        '
        'Label20
        '
        Me.Label20.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label20.BackColor = System.Drawing.Color.White
        Me.Label20.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label20.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.ForeColor = System.Drawing.Color.Black
        Me.Label20.Location = New System.Drawing.Point(16, 26)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(291, 20)
        Me.Label20.TabIndex = 18
        Me.Label20.Text = "Appliance Type:"
        Me.Label20.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Appliance_Model
        '
        Me.Appliance_Model.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Appliance_Model.BackColor = System.Drawing.Color.White
        Me.Appliance_Model.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Appliance_Model.ForeColor = System.Drawing.Color.Black
        Me.Appliance_Model.Location = New System.Drawing.Point(313, 75)
        Me.Appliance_Model.MaxLength = 50
        Me.Appliance_Model.Name = "Appliance_Model"
        Me.Appliance_Model.Size = New System.Drawing.Size(352, 22)
        Me.Appliance_Model.TabIndex = 17
        '
        'Label21
        '
        Me.Label21.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label21.BackColor = System.Drawing.Color.White
        Me.Label21.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label21.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.ForeColor = System.Drawing.Color.Black
        Me.Label21.Location = New System.Drawing.Point(16, 75)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(291, 20)
        Me.Label21.TabIndex = 16
        Me.Label21.Text = "Model Number:"
        Me.Label21.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Appliance_Manufacturer
        '
        Me.Appliance_Manufacturer.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Appliance_Manufacturer.BackColor = System.Drawing.Color.White
        Me.Appliance_Manufacturer.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Appliance_Manufacturer.ForeColor = System.Drawing.Color.Black
        Me.Appliance_Manufacturer.Location = New System.Drawing.Point(313, 50)
        Me.Appliance_Manufacturer.MaxLength = 50
        Me.Appliance_Manufacturer.Name = "Appliance_Manufacturer"
        Me.Appliance_Manufacturer.Size = New System.Drawing.Size(352, 22)
        Me.Appliance_Manufacturer.TabIndex = 15
        '
        'Label22
        '
        Me.Label22.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label22.BackColor = System.Drawing.Color.White
        Me.Label22.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label22.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label22.ForeColor = System.Drawing.Color.Black
        Me.Label22.Location = New System.Drawing.Point(16, 51)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(291, 20)
        Me.Label22.TabIndex = 14
        Me.Label22.Text = "Manufacturer:"
        Me.Label22.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'PCTab
        '
        Me.PCTab.AutoScroll = True
        Me.PCTab.BackColor = System.Drawing.Color.FromArgb(CType(CType(211, Byte), Integer), CType(CType(211, Byte), Integer), CType(CType(211, Byte), Integer))
        Me.PCTab.Controls.Add(Me.PC_WarrantyPeriod)
        Me.PCTab.Controls.Add(Me.PC_Location)
        Me.PCTab.Controls.Add(Me.Label32)
        Me.PCTab.Controls.Add(Me.PC_Password)
        Me.PCTab.Controls.Add(Me.Label31)
        Me.PCTab.Controls.Add(Me.PC_Warranty)
        Me.PCTab.Controls.Add(Me.PC_Username)
        Me.PCTab.Controls.Add(Me.Label26)
        Me.PCTab.Controls.Add(Me.Label27)
        Me.PCTab.Controls.Add(Me.PC_Serial)
        Me.PCTab.Controls.Add(Me.Label28)
        Me.PCTab.Controls.Add(Me.PC_Model)
        Me.PCTab.Controls.Add(Me.Label29)
        Me.PCTab.Controls.Add(Me.PC_Manufacturer)
        Me.PCTab.Controls.Add(Me.Label30)
        Me.PCTab.ForeColor = System.Drawing.Color.Black
        Me.PCTab.Location = New System.Drawing.Point(4, 22)
        Me.PCTab.Name = "PCTab"
        Me.PCTab.Padding = New System.Windows.Forms.Padding(3)
        Me.PCTab.Size = New System.Drawing.Size(690, 292)
        Me.PCTab.TabIndex = 4
        Me.PCTab.Text = "Input - PC"
        '
        'PC_WarrantyPeriod
        '
        Me.PC_WarrantyPeriod.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.PC_WarrantyPeriod.BackColor = System.Drawing.Color.White
        Me.PC_WarrantyPeriod.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PC_WarrantyPeriod.ForeColor = System.Drawing.Color.Black
        Me.PC_WarrantyPeriod.Location = New System.Drawing.Point(310, 93)
        Me.PC_WarrantyPeriod.Name = "PC_WarrantyPeriod"
        Me.PC_WarrantyPeriod.Size = New System.Drawing.Size(203, 22)
        Me.PC_WarrantyPeriod.TabIndex = 47
        '
        'PC_Location
        '
        Me.PC_Location.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.PC_Location.BackColor = System.Drawing.Color.White
        Me.PC_Location.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PC_Location.ForeColor = System.Drawing.Color.Black
        Me.PC_Location.Location = New System.Drawing.Point(310, 168)
        Me.PC_Location.MaxLength = 50
        Me.PC_Location.Name = "PC_Location"
        Me.PC_Location.Size = New System.Drawing.Size(355, 22)
        Me.PC_Location.TabIndex = 46
        '
        'Label32
        '
        Me.Label32.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label32.BackColor = System.Drawing.Color.White
        Me.Label32.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label32.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label32.ForeColor = System.Drawing.Color.Black
        Me.Label32.Location = New System.Drawing.Point(16, 168)
        Me.Label32.Name = "Label32"
        Me.Label32.Size = New System.Drawing.Size(288, 20)
        Me.Label32.TabIndex = 45
        Me.Label32.Text = "Location:"
        Me.Label32.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'PC_Password
        '
        Me.PC_Password.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.PC_Password.BackColor = System.Drawing.Color.White
        Me.PC_Password.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PC_Password.ForeColor = System.Drawing.Color.Black
        Me.PC_Password.Location = New System.Drawing.Point(310, 143)
        Me.PC_Password.MaxLength = 50
        Me.PC_Password.Name = "PC_Password"
        Me.PC_Password.Size = New System.Drawing.Size(355, 22)
        Me.PC_Password.TabIndex = 44
        '
        'Label31
        '
        Me.Label31.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label31.BackColor = System.Drawing.Color.White
        Me.Label31.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label31.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label31.ForeColor = System.Drawing.Color.Black
        Me.Label31.Location = New System.Drawing.Point(16, 143)
        Me.Label31.Name = "Label31"
        Me.Label31.Size = New System.Drawing.Size(288, 20)
        Me.Label31.TabIndex = 43
        Me.Label31.Text = "Password"
        Me.Label31.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'PC_Warranty
        '
        Me.PC_Warranty.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.PC_Warranty.BackColor = System.Drawing.Color.White
        Me.PC_Warranty.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.PC_Warranty.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PC_Warranty.ForeColor = System.Drawing.Color.Black
        Me.PC_Warranty.FormattingEnabled = True
        Me.PC_Warranty.Items.AddRange(New Object() {"Years", "Months", "Weeks", "Days"})
        Me.PC_Warranty.Location = New System.Drawing.Point(517, 93)
        Me.PC_Warranty.Name = "PC_Warranty"
        Me.PC_Warranty.Size = New System.Drawing.Size(148, 23)
        Me.PC_Warranty.TabIndex = 42
        '
        'PC_Username
        '
        Me.PC_Username.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.PC_Username.BackColor = System.Drawing.Color.White
        Me.PC_Username.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PC_Username.ForeColor = System.Drawing.Color.Black
        Me.PC_Username.Location = New System.Drawing.Point(310, 118)
        Me.PC_Username.MaxLength = 50
        Me.PC_Username.Name = "PC_Username"
        Me.PC_Username.Size = New System.Drawing.Size(355, 22)
        Me.PC_Username.TabIndex = 40
        '
        'Label26
        '
        Me.Label26.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label26.BackColor = System.Drawing.Color.White
        Me.Label26.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label26.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label26.ForeColor = System.Drawing.Color.Black
        Me.Label26.Location = New System.Drawing.Point(16, 118)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(288, 20)
        Me.Label26.TabIndex = 39
        Me.Label26.Text = "Username:"
        Me.Label26.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label27
        '
        Me.Label27.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label27.BackColor = System.Drawing.Color.White
        Me.Label27.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label27.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label27.ForeColor = System.Drawing.Color.Black
        Me.Label27.Location = New System.Drawing.Point(16, 93)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(288, 20)
        Me.Label27.TabIndex = 38
        Me.Label27.Text = "Warranty (Period):"
        Me.Label27.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'PC_Serial
        '
        Me.PC_Serial.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.PC_Serial.BackColor = System.Drawing.Color.White
        Me.PC_Serial.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PC_Serial.ForeColor = System.Drawing.Color.Black
        Me.PC_Serial.Location = New System.Drawing.Point(310, 68)
        Me.PC_Serial.MaxLength = 50
        Me.PC_Serial.Name = "PC_Serial"
        Me.PC_Serial.Size = New System.Drawing.Size(355, 22)
        Me.PC_Serial.TabIndex = 37
        '
        'Label28
        '
        Me.Label28.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label28.BackColor = System.Drawing.Color.White
        Me.Label28.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label28.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label28.ForeColor = System.Drawing.Color.Black
        Me.Label28.Location = New System.Drawing.Point(16, 68)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(288, 20)
        Me.Label28.TabIndex = 36
        Me.Label28.Text = "Serial Number:"
        Me.Label28.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'PC_Model
        '
        Me.PC_Model.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.PC_Model.BackColor = System.Drawing.Color.White
        Me.PC_Model.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PC_Model.ForeColor = System.Drawing.Color.Black
        Me.PC_Model.Location = New System.Drawing.Point(310, 44)
        Me.PC_Model.MaxLength = 50
        Me.PC_Model.Name = "PC_Model"
        Me.PC_Model.Size = New System.Drawing.Size(355, 22)
        Me.PC_Model.TabIndex = 35
        '
        'Label29
        '
        Me.Label29.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label29.BackColor = System.Drawing.Color.White
        Me.Label29.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label29.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label29.ForeColor = System.Drawing.Color.Black
        Me.Label29.Location = New System.Drawing.Point(16, 44)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(288, 20)
        Me.Label29.TabIndex = 34
        Me.Label29.Text = "Model Number:"
        Me.Label29.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'PC_Manufacturer
        '
        Me.PC_Manufacturer.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.PC_Manufacturer.BackColor = System.Drawing.Color.White
        Me.PC_Manufacturer.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PC_Manufacturer.ForeColor = System.Drawing.Color.Black
        Me.PC_Manufacturer.Location = New System.Drawing.Point(310, 21)
        Me.PC_Manufacturer.MaxLength = 50
        Me.PC_Manufacturer.Name = "PC_Manufacturer"
        Me.PC_Manufacturer.Size = New System.Drawing.Size(355, 22)
        Me.PC_Manufacturer.TabIndex = 33
        '
        'Label30
        '
        Me.Label30.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label30.BackColor = System.Drawing.Color.White
        Me.Label30.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label30.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label30.ForeColor = System.Drawing.Color.Black
        Me.Label30.Location = New System.Drawing.Point(16, 21)
        Me.Label30.Name = "Label30"
        Me.Label30.Size = New System.Drawing.Size(288, 20)
        Me.Label30.TabIndex = 32
        Me.Label30.Text = "Manufacturer:"
        Me.Label30.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'TVTab
        '
        Me.TVTab.AutoScroll = True
        Me.TVTab.BackColor = System.Drawing.Color.FromArgb(CType(CType(211, Byte), Integer), CType(CType(211, Byte), Integer), CType(CType(211, Byte), Integer))
        Me.TVTab.Controls.Add(Me.TV_WarrantyPeriod)
        Me.TVTab.Controls.Add(Me.TV_Location)
        Me.TVTab.Controls.Add(Me.Label33)
        Me.TVTab.Controls.Add(Me.TV_Warranty)
        Me.TVTab.Controls.Add(Me.Label36)
        Me.TVTab.Controls.Add(Me.TV_Serial)
        Me.TVTab.Controls.Add(Me.Label37)
        Me.TVTab.Controls.Add(Me.TV_Model)
        Me.TVTab.Controls.Add(Me.Label38)
        Me.TVTab.Controls.Add(Me.TV_Manufacturer)
        Me.TVTab.Controls.Add(Me.Label39)
        Me.TVTab.ForeColor = System.Drawing.Color.Black
        Me.TVTab.Location = New System.Drawing.Point(4, 22)
        Me.TVTab.Name = "TVTab"
        Me.TVTab.Padding = New System.Windows.Forms.Padding(3)
        Me.TVTab.Size = New System.Drawing.Size(690, 292)
        Me.TVTab.TabIndex = 5
        Me.TVTab.Text = "Input - TV"
        '
        'TV_WarrantyPeriod
        '
        Me.TV_WarrantyPeriod.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.TV_WarrantyPeriod.BackColor = System.Drawing.Color.White
        Me.TV_WarrantyPeriod.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TV_WarrantyPeriod.ForeColor = System.Drawing.Color.Black
        Me.TV_WarrantyPeriod.Location = New System.Drawing.Point(314, 96)
        Me.TV_WarrantyPeriod.Name = "TV_WarrantyPeriod"
        Me.TV_WarrantyPeriod.Size = New System.Drawing.Size(209, 22)
        Me.TV_WarrantyPeriod.TabIndex = 62
        '
        'TV_Location
        '
        Me.TV_Location.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.TV_Location.BackColor = System.Drawing.Color.White
        Me.TV_Location.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TV_Location.ForeColor = System.Drawing.Color.Black
        Me.TV_Location.Location = New System.Drawing.Point(314, 121)
        Me.TV_Location.MaxLength = 50
        Me.TV_Location.Name = "TV_Location"
        Me.TV_Location.Size = New System.Drawing.Size(351, 22)
        Me.TV_Location.TabIndex = 61
        '
        'Label33
        '
        Me.Label33.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label33.BackColor = System.Drawing.Color.White
        Me.Label33.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label33.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label33.ForeColor = System.Drawing.Color.Black
        Me.Label33.Location = New System.Drawing.Point(16, 121)
        Me.Label33.Name = "Label33"
        Me.Label33.Size = New System.Drawing.Size(292, 20)
        Me.Label33.TabIndex = 60
        Me.Label33.Text = "Location:"
        Me.Label33.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'TV_Warranty
        '
        Me.TV_Warranty.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.TV_Warranty.BackColor = System.Drawing.Color.White
        Me.TV_Warranty.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.TV_Warranty.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TV_Warranty.ForeColor = System.Drawing.Color.Black
        Me.TV_Warranty.FormattingEnabled = True
        Me.TV_Warranty.Items.AddRange(New Object() {"Years", "Months", "Weeks", "Days"})
        Me.TV_Warranty.Location = New System.Drawing.Point(526, 96)
        Me.TV_Warranty.Name = "TV_Warranty"
        Me.TV_Warranty.Size = New System.Drawing.Size(139, 23)
        Me.TV_Warranty.TabIndex = 57
        '
        'Label36
        '
        Me.Label36.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label36.BackColor = System.Drawing.Color.White
        Me.Label36.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label36.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label36.ForeColor = System.Drawing.Color.Black
        Me.Label36.Location = New System.Drawing.Point(16, 96)
        Me.Label36.Name = "Label36"
        Me.Label36.Size = New System.Drawing.Size(292, 20)
        Me.Label36.TabIndex = 53
        Me.Label36.Text = "Warranty (Period):"
        Me.Label36.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'TV_Serial
        '
        Me.TV_Serial.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.TV_Serial.BackColor = System.Drawing.Color.White
        Me.TV_Serial.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TV_Serial.ForeColor = System.Drawing.Color.Black
        Me.TV_Serial.Location = New System.Drawing.Point(314, 71)
        Me.TV_Serial.MaxLength = 50
        Me.TV_Serial.Name = "TV_Serial"
        Me.TV_Serial.Size = New System.Drawing.Size(351, 22)
        Me.TV_Serial.TabIndex = 52
        '
        'Label37
        '
        Me.Label37.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label37.BackColor = System.Drawing.Color.White
        Me.Label37.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label37.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label37.ForeColor = System.Drawing.Color.Black
        Me.Label37.Location = New System.Drawing.Point(16, 71)
        Me.Label37.Name = "Label37"
        Me.Label37.Size = New System.Drawing.Size(292, 20)
        Me.Label37.TabIndex = 51
        Me.Label37.Text = "Serial Number:"
        Me.Label37.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'TV_Model
        '
        Me.TV_Model.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.TV_Model.BackColor = System.Drawing.Color.White
        Me.TV_Model.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TV_Model.ForeColor = System.Drawing.Color.Black
        Me.TV_Model.Location = New System.Drawing.Point(314, 45)
        Me.TV_Model.MaxLength = 50
        Me.TV_Model.Name = "TV_Model"
        Me.TV_Model.Size = New System.Drawing.Size(351, 22)
        Me.TV_Model.TabIndex = 50
        '
        'Label38
        '
        Me.Label38.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label38.BackColor = System.Drawing.Color.White
        Me.Label38.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label38.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label38.ForeColor = System.Drawing.Color.Black
        Me.Label38.Location = New System.Drawing.Point(16, 45)
        Me.Label38.Name = "Label38"
        Me.Label38.Size = New System.Drawing.Size(292, 20)
        Me.Label38.TabIndex = 49
        Me.Label38.Text = "Model Number:"
        Me.Label38.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'TV_Manufacturer
        '
        Me.TV_Manufacturer.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.TV_Manufacturer.BackColor = System.Drawing.Color.White
        Me.TV_Manufacturer.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TV_Manufacturer.ForeColor = System.Drawing.Color.Black
        Me.TV_Manufacturer.Location = New System.Drawing.Point(314, 21)
        Me.TV_Manufacturer.MaxLength = 50
        Me.TV_Manufacturer.Name = "TV_Manufacturer"
        Me.TV_Manufacturer.Size = New System.Drawing.Size(351, 22)
        Me.TV_Manufacturer.TabIndex = 48
        '
        'Label39
        '
        Me.Label39.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label39.BackColor = System.Drawing.Color.White
        Me.Label39.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label39.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label39.ForeColor = System.Drawing.Color.Black
        Me.Label39.Location = New System.Drawing.Point(16, 21)
        Me.Label39.Name = "Label39"
        Me.Label39.Size = New System.Drawing.Size(292, 20)
        Me.Label39.TabIndex = 47
        Me.Label39.Text = "Manufacturer:"
        Me.Label39.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'SkyTab
        '
        Me.SkyTab.AutoScroll = True
        Me.SkyTab.BackColor = System.Drawing.Color.FromArgb(CType(CType(211, Byte), Integer), CType(CType(211, Byte), Integer), CType(CType(211, Byte), Integer))
        Me.SkyTab.Controls.Add(Me.RemoveViewCardBtn)
        Me.SkyTab.Controls.Add(Me.AddViewCardBtn)
        Me.SkyTab.Controls.Add(Me.SkyGridView)
        Me.SkyTab.ForeColor = System.Drawing.Color.Black
        Me.SkyTab.Location = New System.Drawing.Point(4, 22)
        Me.SkyTab.Name = "SkyTab"
        Me.SkyTab.Padding = New System.Windows.Forms.Padding(3)
        Me.SkyTab.Size = New System.Drawing.Size(690, 292)
        Me.SkyTab.TabIndex = 6
        Me.SkyTab.Text = "Input - SkyBox"
        '
        'RemoveViewCardBtn
        '
        Me.RemoveViewCardBtn.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.RemoveViewCardBtn.BackColor = System.Drawing.Color.White
        Me.RemoveViewCardBtn.ForeColor = System.Drawing.Color.Black
        Me.RemoveViewCardBtn.Image = Global.PMD.My.Resources.Resources._1364945045_list_remove
        Me.RemoveViewCardBtn.Location = New System.Drawing.Point(409, 261)
        Me.RemoveViewCardBtn.Name = "RemoveViewCardBtn"
        Me.RemoveViewCardBtn.Size = New System.Drawing.Size(143, 25)
        Me.RemoveViewCardBtn.TabIndex = 78
        Me.RemoveViewCardBtn.Text = "Remove Viewing Card"
        Me.RemoveViewCardBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.RemoveViewCardBtn.UseVisualStyleBackColor = False
        Me.RemoveViewCardBtn.Visible = False
        '
        'AddViewCardBtn
        '
        Me.AddViewCardBtn.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.AddViewCardBtn.BackColor = System.Drawing.Color.White
        Me.AddViewCardBtn.Cursor = System.Windows.Forms.Cursors.Default
        Me.AddViewCardBtn.ForeColor = System.Drawing.Color.Black
        Me.AddViewCardBtn.Image = Global.PMD.My.Resources.Resources._1364676805_plus_161
        Me.AddViewCardBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.AddViewCardBtn.Location = New System.Drawing.Point(558, 261)
        Me.AddViewCardBtn.Name = "AddViewCardBtn"
        Me.AddViewCardBtn.Size = New System.Drawing.Size(128, 25)
        Me.AddViewCardBtn.TabIndex = 77
        Me.AddViewCardBtn.Text = "Add Viewing Card"
        Me.AddViewCardBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.AddViewCardBtn.UseVisualStyleBackColor = False
        '
        'SkyGridView
        '
        Me.SkyGridView.AllowUserToAddRows = False
        Me.SkyGridView.AllowUserToDeleteRows = False
        DataGridViewCellStyle10.BackColor = System.Drawing.Color.White
        Me.SkyGridView.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle10
        Me.SkyGridView.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SkyGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.SkyGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.SkyGridView.BackgroundColor = System.Drawing.SystemColors.Window
        Me.SkyGridView.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.SkyGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.SkyGridView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.SkyGridView.Location = New System.Drawing.Point(4, 6)
        Me.SkyGridView.Name = "SkyGridView"
        Me.SkyGridView.ReadOnly = True
        Me.SkyGridView.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        Me.SkyGridView.RowHeadersVisible = False
        Me.SkyGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.SkyGridView.Size = New System.Drawing.Size(681, 249)
        Me.SkyGridView.TabIndex = 76
        '
        'DVRTab
        '
        Me.DVRTab.AutoScroll = True
        Me.DVRTab.BackColor = System.Drawing.Color.FromArgb(CType(CType(211, Byte), Integer), CType(CType(211, Byte), Integer), CType(CType(211, Byte), Integer))
        Me.DVRTab.Controls.Add(Me.DVR_Location)
        Me.DVRTab.Controls.Add(Me.Label41)
        Me.DVRTab.Controls.Add(Me.DVRMaintainerContract)
        Me.DVRTab.Controls.Add(Me.Label50)
        Me.DVRTab.Controls.Add(Me.LinkDVRMaintainerBtn)
        Me.DVRTab.Controls.Add(Me.DVR_Software)
        Me.DVRTab.Controls.Add(Me.Label48)
        Me.DVRTab.Controls.Add(Me.DVR_LicenseDue)
        Me.DVRTab.Controls.Add(Me.Label47)
        Me.DVRTab.Controls.Add(Me.DVR_Password)
        Me.DVRTab.Controls.Add(Me.Label35)
        Me.DVRTab.Controls.Add(Me.DVR_Username)
        Me.DVRTab.Controls.Add(Me.Label43)
        Me.DVRTab.Controls.Add(Me.DVR_Serial)
        Me.DVRTab.Controls.Add(Me.Label44)
        Me.DVRTab.Controls.Add(Me.DVR_Channels)
        Me.DVRTab.Controls.Add(Me.Label45)
        Me.DVRTab.Controls.Add(Me.DVR_Model)
        Me.DVRTab.Controls.Add(Me.Label46)
        Me.DVRTab.ForeColor = System.Drawing.Color.Black
        Me.DVRTab.Location = New System.Drawing.Point(4, 22)
        Me.DVRTab.Name = "DVRTab"
        Me.DVRTab.Padding = New System.Windows.Forms.Padding(3)
        Me.DVRTab.Size = New System.Drawing.Size(690, 292)
        Me.DVRTab.TabIndex = 7
        Me.DVRTab.Text = "Input - DVR/NVR"
        '
        'DVR_Location
        '
        Me.DVR_Location.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.DVR_Location.BackColor = System.Drawing.Color.White
        Me.DVR_Location.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DVR_Location.ForeColor = System.Drawing.Color.Black
        Me.DVR_Location.Location = New System.Drawing.Point(305, 190)
        Me.DVR_Location.MaxLength = 50
        Me.DVR_Location.Name = "DVR_Location"
        Me.DVR_Location.Size = New System.Drawing.Size(360, 22)
        Me.DVR_Location.TabIndex = 80
        '
        'Label41
        '
        Me.Label41.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label41.BackColor = System.Drawing.Color.White
        Me.Label41.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label41.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label41.ForeColor = System.Drawing.Color.Black
        Me.Label41.Location = New System.Drawing.Point(17, 190)
        Me.Label41.Name = "Label41"
        Me.Label41.Size = New System.Drawing.Size(277, 20)
        Me.Label41.TabIndex = 79
        Me.Label41.Text = "Location:"
        Me.Label41.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'DVRMaintainerContract
        '
        Me.DVRMaintainerContract.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.DVRMaintainerContract.BackColor = System.Drawing.Color.White
        Me.DVRMaintainerContract.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DVRMaintainerContract.ForeColor = System.Drawing.Color.Black
        Me.DVRMaintainerContract.Location = New System.Drawing.Point(305, 217)
        Me.DVRMaintainerContract.Name = "DVRMaintainerContract"
        Me.DVRMaintainerContract.Size = New System.Drawing.Size(244, 46)
        Me.DVRMaintainerContract.TabIndex = 78
        Me.DVRMaintainerContract.Text = "None"
        '
        'Label50
        '
        Me.Label50.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label50.BackColor = System.Drawing.Color.White
        Me.Label50.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label50.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label50.ForeColor = System.Drawing.Color.Black
        Me.Label50.Location = New System.Drawing.Point(17, 216)
        Me.Label50.Name = "Label50"
        Me.Label50.Size = New System.Drawing.Size(277, 20)
        Me.Label50.TabIndex = 77
        Me.Label50.Text = "Maintainer:"
        Me.Label50.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'LinkDVRMaintainerBtn
        '
        Me.LinkDVRMaintainerBtn.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.LinkDVRMaintainerBtn.BackColor = System.Drawing.Color.White
        Me.LinkDVRMaintainerBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LinkDVRMaintainerBtn.ForeColor = System.Drawing.Color.Black
        Me.LinkDVRMaintainerBtn.Location = New System.Drawing.Point(554, 216)
        Me.LinkDVRMaintainerBtn.Name = "LinkDVRMaintainerBtn"
        Me.LinkDVRMaintainerBtn.Size = New System.Drawing.Size(111, 23)
        Me.LinkDVRMaintainerBtn.TabIndex = 76
        Me.LinkDVRMaintainerBtn.Text = "Link Maintainer"
        Me.LinkDVRMaintainerBtn.UseVisualStyleBackColor = False
        '
        'DVR_Software
        '
        Me.DVR_Software.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.DVR_Software.BackColor = System.Drawing.Color.White
        Me.DVR_Software.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DVR_Software.ForeColor = System.Drawing.Color.Black
        Me.DVR_Software.Location = New System.Drawing.Point(305, 165)
        Me.DVR_Software.MaxLength = 50
        Me.DVR_Software.Name = "DVR_Software"
        Me.DVR_Software.Size = New System.Drawing.Size(360, 22)
        Me.DVR_Software.TabIndex = 75
        '
        'Label48
        '
        Me.Label48.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label48.BackColor = System.Drawing.Color.White
        Me.Label48.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label48.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label48.ForeColor = System.Drawing.Color.Black
        Me.Label48.Location = New System.Drawing.Point(17, 165)
        Me.Label48.Name = "Label48"
        Me.Label48.Size = New System.Drawing.Size(277, 20)
        Me.Label48.TabIndex = 74
        Me.Label48.Text = "Software:"
        Me.Label48.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'DVR_LicenseDue
        '
        Me.DVR_LicenseDue.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.DVR_LicenseDue.BackColor = System.Drawing.Color.White
        Me.DVR_LicenseDue.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DVR_LicenseDue.ForeColor = System.Drawing.Color.Black
        Me.DVR_LicenseDue.Location = New System.Drawing.Point(305, 140)
        Me.DVR_LicenseDue.Name = "DVR_LicenseDue"
        Me.DVR_LicenseDue.Size = New System.Drawing.Size(360, 22)
        Me.DVR_LicenseDue.TabIndex = 73
        '
        'Label47
        '
        Me.Label47.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label47.BackColor = System.Drawing.Color.White
        Me.Label47.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label47.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label47.ForeColor = System.Drawing.Color.Black
        Me.Label47.Location = New System.Drawing.Point(17, 140)
        Me.Label47.Name = "Label47"
        Me.Label47.Size = New System.Drawing.Size(277, 20)
        Me.Label47.TabIndex = 72
        Me.Label47.Text = "License due:"
        Me.Label47.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'DVR_Password
        '
        Me.DVR_Password.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.DVR_Password.BackColor = System.Drawing.Color.White
        Me.DVR_Password.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DVR_Password.ForeColor = System.Drawing.Color.Black
        Me.DVR_Password.Location = New System.Drawing.Point(305, 116)
        Me.DVR_Password.MaxLength = 50
        Me.DVR_Password.Name = "DVR_Password"
        Me.DVR_Password.Size = New System.Drawing.Size(360, 22)
        Me.DVR_Password.TabIndex = 71
        '
        'Label35
        '
        Me.Label35.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label35.BackColor = System.Drawing.Color.White
        Me.Label35.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label35.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label35.ForeColor = System.Drawing.Color.Black
        Me.Label35.Location = New System.Drawing.Point(17, 116)
        Me.Label35.Name = "Label35"
        Me.Label35.Size = New System.Drawing.Size(277, 20)
        Me.Label35.TabIndex = 70
        Me.Label35.Text = "Password"
        Me.Label35.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'DVR_Username
        '
        Me.DVR_Username.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.DVR_Username.BackColor = System.Drawing.Color.White
        Me.DVR_Username.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DVR_Username.ForeColor = System.Drawing.Color.Black
        Me.DVR_Username.Location = New System.Drawing.Point(305, 92)
        Me.DVR_Username.MaxLength = 50
        Me.DVR_Username.Name = "DVR_Username"
        Me.DVR_Username.Size = New System.Drawing.Size(360, 22)
        Me.DVR_Username.TabIndex = 69
        '
        'Label43
        '
        Me.Label43.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label43.BackColor = System.Drawing.Color.White
        Me.Label43.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label43.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label43.ForeColor = System.Drawing.Color.Black
        Me.Label43.Location = New System.Drawing.Point(17, 92)
        Me.Label43.Name = "Label43"
        Me.Label43.Size = New System.Drawing.Size(277, 20)
        Me.Label43.TabIndex = 68
        Me.Label43.Text = "Username:"
        Me.Label43.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'DVR_Serial
        '
        Me.DVR_Serial.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.DVR_Serial.BackColor = System.Drawing.Color.White
        Me.DVR_Serial.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DVR_Serial.ForeColor = System.Drawing.Color.Black
        Me.DVR_Serial.Location = New System.Drawing.Point(305, 68)
        Me.DVR_Serial.MaxLength = 50
        Me.DVR_Serial.Name = "DVR_Serial"
        Me.DVR_Serial.Size = New System.Drawing.Size(360, 22)
        Me.DVR_Serial.TabIndex = 67
        '
        'Label44
        '
        Me.Label44.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label44.BackColor = System.Drawing.Color.White
        Me.Label44.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label44.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label44.ForeColor = System.Drawing.Color.Black
        Me.Label44.Location = New System.Drawing.Point(17, 68)
        Me.Label44.Name = "Label44"
        Me.Label44.Size = New System.Drawing.Size(277, 20)
        Me.Label44.TabIndex = 66
        Me.Label44.Text = "Serial Number:"
        Me.Label44.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'DVR_Channels
        '
        Me.DVR_Channels.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.DVR_Channels.BackColor = System.Drawing.Color.White
        Me.DVR_Channels.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DVR_Channels.ForeColor = System.Drawing.Color.Black
        Me.DVR_Channels.Location = New System.Drawing.Point(305, 44)
        Me.DVR_Channels.MaxLength = 5
        Me.DVR_Channels.Name = "DVR_Channels"
        Me.DVR_Channels.Size = New System.Drawing.Size(360, 22)
        Me.DVR_Channels.TabIndex = 65
        '
        'Label45
        '
        Me.Label45.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label45.BackColor = System.Drawing.Color.White
        Me.Label45.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label45.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label45.ForeColor = System.Drawing.Color.Black
        Me.Label45.Location = New System.Drawing.Point(17, 44)
        Me.Label45.Name = "Label45"
        Me.Label45.Size = New System.Drawing.Size(277, 20)
        Me.Label45.TabIndex = 64
        Me.Label45.Text = "Channels:"
        Me.Label45.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'DVR_Model
        '
        Me.DVR_Model.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.DVR_Model.BackColor = System.Drawing.Color.White
        Me.DVR_Model.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DVR_Model.ForeColor = System.Drawing.Color.Black
        Me.DVR_Model.Location = New System.Drawing.Point(305, 21)
        Me.DVR_Model.MaxLength = 50
        Me.DVR_Model.Name = "DVR_Model"
        Me.DVR_Model.Size = New System.Drawing.Size(360, 22)
        Me.DVR_Model.TabIndex = 63
        '
        'Label46
        '
        Me.Label46.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label46.BackColor = System.Drawing.Color.White
        Me.Label46.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label46.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label46.ForeColor = System.Drawing.Color.Black
        Me.Label46.Location = New System.Drawing.Point(17, 21)
        Me.Label46.Name = "Label46"
        Me.Label46.Size = New System.Drawing.Size(277, 20)
        Me.Label46.TabIndex = 62
        Me.Label46.Text = "Model:"
        Me.Label46.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'CarTab
        '
        Me.CarTab.AutoScroll = True
        Me.CarTab.BackColor = System.Drawing.Color.FromArgb(CType(CType(211, Byte), Integer), CType(CType(211, Byte), Integer), CType(CType(211, Byte), Integer))
        Me.CarTab.Controls.Add(Me.GroupBox2)
        Me.CarTab.Controls.Add(Me.Car_Make)
        Me.CarTab.Controls.Add(Me.InsuranceContract)
        Me.CarTab.Controls.Add(Me.Label62)
        Me.CarTab.Controls.Add(Me.LinkInsuranceBtn)
        Me.CarTab.Controls.Add(Me.TAXContract)
        Me.CarTab.Controls.Add(Me.Label56)
        Me.CarTab.Controls.Add(Me.LinkTAXBtn)
        Me.CarTab.Controls.Add(Me.MOTContract)
        Me.CarTab.Controls.Add(Me.Label58)
        Me.CarTab.Controls.Add(Me.LinkMOTBtn)
        Me.CarTab.Controls.Add(Me.Car_Mileage)
        Me.CarTab.Controls.Add(Me.Label54)
        Me.CarTab.Controls.Add(Me.Car_VRN)
        Me.CarTab.Controls.Add(Me.Label52)
        Me.CarTab.Controls.Add(Me.Label51)
        Me.CarTab.Controls.Add(Me.Car_Model)
        Me.CarTab.Controls.Add(Me.Label49)
        Me.CarTab.ForeColor = System.Drawing.Color.Black
        Me.CarTab.Location = New System.Drawing.Point(4, 22)
        Me.CarTab.Name = "CarTab"
        Me.CarTab.Padding = New System.Windows.Forms.Padding(3)
        Me.CarTab.Size = New System.Drawing.Size(690, 292)
        Me.CarTab.TabIndex = 8
        Me.CarTab.Text = "Input - Car"
        '
        'GroupBox2
        '
        Me.GroupBox2.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.GroupBox2.BackColor = System.Drawing.Color.White
        Me.GroupBox2.Controls.Add(Me.Car_Keeper_Address)
        Me.GroupBox2.Controls.Add(Me.Label42)
        Me.GroupBox2.Controls.Add(Me.Car_Keeper)
        Me.GroupBox2.Controls.Add(Me.Label34)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.ForeColor = System.Drawing.Color.Black
        Me.GroupBox2.Location = New System.Drawing.Point(13, 75)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(643, 149)
        Me.GroupBox2.TabIndex = 86
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Registered Keeper:"
        '
        'Car_Keeper_Address
        '
        Me.Car_Keeper_Address.BackColor = System.Drawing.Color.White
        Me.Car_Keeper_Address.ForeColor = System.Drawing.Color.Black
        Me.Car_Keeper_Address.Location = New System.Drawing.Point(11, 75)
        Me.Car_Keeper_Address.MaxLength = 200
        Me.Car_Keeper_Address.Multiline = True
        Me.Car_Keeper_Address.Name = "Car_Keeper_Address"
        Me.Car_Keeper_Address.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.Car_Keeper_Address.Size = New System.Drawing.Size(628, 64)
        Me.Car_Keeper_Address.TabIndex = 89
        '
        'Label42
        '
        Me.Label42.BackColor = System.Drawing.Color.White
        Me.Label42.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label42.ForeColor = System.Drawing.Color.Black
        Me.Label42.Location = New System.Drawing.Point(11, 50)
        Me.Label42.Name = "Label42"
        Me.Label42.Size = New System.Drawing.Size(628, 20)
        Me.Label42.TabIndex = 88
        Me.Label42.Text = "Address:"
        Me.Label42.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Car_Keeper
        '
        Me.Car_Keeper.BackColor = System.Drawing.Color.White
        Me.Car_Keeper.ForeColor = System.Drawing.Color.Black
        Me.Car_Keeper.Location = New System.Drawing.Point(284, 21)
        Me.Car_Keeper.MaxLength = 25
        Me.Car_Keeper.Name = "Car_Keeper"
        Me.Car_Keeper.Size = New System.Drawing.Size(355, 22)
        Me.Car_Keeper.TabIndex = 87
        '
        'Label34
        '
        Me.Label34.BackColor = System.Drawing.Color.White
        Me.Label34.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label34.ForeColor = System.Drawing.Color.Black
        Me.Label34.Location = New System.Drawing.Point(11, 21)
        Me.Label34.Name = "Label34"
        Me.Label34.Size = New System.Drawing.Size(255, 20)
        Me.Label34.TabIndex = 86
        Me.Label34.Text = "Name:"
        Me.Label34.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Car_Make
        '
        Me.Car_Make.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Car_Make.BackColor = System.Drawing.Color.White
        Me.Car_Make.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Car_Make.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Car_Make.ForeColor = System.Drawing.Color.Black
        Me.Car_Make.FormattingEnabled = True
        Me.Car_Make.Items.AddRange(New Object() {"Acura", "Audi", "BMW", "Buick", "Cadillac", "Chevrolet", "Chrysler", "Dodge", "Eagle", "Ferrari", "Ford", "GMC", "Honda", "Hummer", "Hyundai", "Infiniti", "Isuzu", "Jaguar", "Jeep", "Kia", "Lamborghini", "Land Rover", "Lexus", "Lincoln", "Lotus", "Mazda", "Mercedes-Benz", "Mercury", "Mitsubishi", "Nissan", "Peugeot", "Porsche", "Saab", "Saturn", "Subaru", "Suzuki", "Toyota", "Volkswagen", "Volvo"})
        Me.Car_Make.Location = New System.Drawing.Point(301, 19)
        Me.Car_Make.Name = "Car_Make"
        Me.Car_Make.Size = New System.Drawing.Size(355, 24)
        Me.Car_Make.TabIndex = 83
        '
        'InsuranceContract
        '
        Me.InsuranceContract.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.InsuranceContract.BackColor = System.Drawing.Color.White
        Me.InsuranceContract.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.InsuranceContract.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.InsuranceContract.ForeColor = System.Drawing.Color.Black
        Me.InsuranceContract.Location = New System.Drawing.Point(299, 335)
        Me.InsuranceContract.Name = "InsuranceContract"
        Me.InsuranceContract.Size = New System.Drawing.Size(244, 18)
        Me.InsuranceContract.TabIndex = 82
        Me.InsuranceContract.Text = "No"
        Me.InsuranceContract.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label62
        '
        Me.Label62.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label62.BackColor = System.Drawing.Color.White
        Me.Label62.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label62.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label62.ForeColor = System.Drawing.Color.Black
        Me.Label62.Location = New System.Drawing.Point(12, 334)
        Me.Label62.Name = "Label62"
        Me.Label62.Size = New System.Drawing.Size(278, 20)
        Me.Label62.TabIndex = 81
        Me.Label62.Text = "Insurance:"
        Me.Label62.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'LinkInsuranceBtn
        '
        Me.LinkInsuranceBtn.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.LinkInsuranceBtn.BackColor = System.Drawing.Color.White
        Me.LinkInsuranceBtn.ForeColor = System.Drawing.Color.Black
        Me.LinkInsuranceBtn.Location = New System.Drawing.Point(551, 334)
        Me.LinkInsuranceBtn.Name = "LinkInsuranceBtn"
        Me.LinkInsuranceBtn.Size = New System.Drawing.Size(105, 23)
        Me.LinkInsuranceBtn.TabIndex = 80
        Me.LinkInsuranceBtn.Text = "Link Insurance"
        Me.LinkInsuranceBtn.UseVisualStyleBackColor = False
        '
        'TAXContract
        '
        Me.TAXContract.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.TAXContract.BackColor = System.Drawing.Color.White
        Me.TAXContract.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.TAXContract.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TAXContract.ForeColor = System.Drawing.Color.Black
        Me.TAXContract.Location = New System.Drawing.Point(299, 314)
        Me.TAXContract.Name = "TAXContract"
        Me.TAXContract.Size = New System.Drawing.Size(244, 18)
        Me.TAXContract.TabIndex = 79
        Me.TAXContract.Text = "No"
        Me.TAXContract.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label56
        '
        Me.Label56.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label56.BackColor = System.Drawing.Color.White
        Me.Label56.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label56.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label56.ForeColor = System.Drawing.Color.Black
        Me.Label56.Location = New System.Drawing.Point(13, 312)
        Me.Label56.Name = "Label56"
        Me.Label56.Size = New System.Drawing.Size(277, 20)
        Me.Label56.TabIndex = 78
        Me.Label56.Text = "TAX:"
        Me.Label56.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'LinkTAXBtn
        '
        Me.LinkTAXBtn.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.LinkTAXBtn.BackColor = System.Drawing.Color.White
        Me.LinkTAXBtn.ForeColor = System.Drawing.Color.Black
        Me.LinkTAXBtn.Location = New System.Drawing.Point(551, 312)
        Me.LinkTAXBtn.Name = "LinkTAXBtn"
        Me.LinkTAXBtn.Size = New System.Drawing.Size(105, 23)
        Me.LinkTAXBtn.TabIndex = 77
        Me.LinkTAXBtn.Text = "Link TAX"
        Me.LinkTAXBtn.UseVisualStyleBackColor = False
        '
        'MOTContract
        '
        Me.MOTContract.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.MOTContract.BackColor = System.Drawing.Color.White
        Me.MOTContract.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.MOTContract.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MOTContract.ForeColor = System.Drawing.Color.Black
        Me.MOTContract.Location = New System.Drawing.Point(299, 291)
        Me.MOTContract.Name = "MOTContract"
        Me.MOTContract.Size = New System.Drawing.Size(244, 19)
        Me.MOTContract.TabIndex = 76
        Me.MOTContract.Text = "No"
        Me.MOTContract.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label58
        '
        Me.Label58.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label58.BackColor = System.Drawing.Color.White
        Me.Label58.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label58.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label58.ForeColor = System.Drawing.Color.Black
        Me.Label58.Location = New System.Drawing.Point(12, 288)
        Me.Label58.Name = "Label58"
        Me.Label58.Size = New System.Drawing.Size(278, 20)
        Me.Label58.TabIndex = 75
        Me.Label58.Text = "MOT:"
        Me.Label58.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'LinkMOTBtn
        '
        Me.LinkMOTBtn.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.LinkMOTBtn.BackColor = System.Drawing.Color.White
        Me.LinkMOTBtn.ForeColor = System.Drawing.Color.Black
        Me.LinkMOTBtn.Location = New System.Drawing.Point(551, 289)
        Me.LinkMOTBtn.Name = "LinkMOTBtn"
        Me.LinkMOTBtn.Size = New System.Drawing.Size(105, 23)
        Me.LinkMOTBtn.TabIndex = 74
        Me.LinkMOTBtn.Text = "Link MOT"
        Me.LinkMOTBtn.UseVisualStyleBackColor = False
        '
        'Car_Mileage
        '
        Me.Car_Mileage.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Car_Mileage.BackColor = System.Drawing.Color.White
        Me.Car_Mileage.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Car_Mileage.ForeColor = System.Drawing.Color.Black
        Me.Car_Mileage.Location = New System.Drawing.Point(300, 253)
        Me.Car_Mileage.MaxLength = 15
        Me.Car_Mileage.Name = "Car_Mileage"
        Me.Car_Mileage.Size = New System.Drawing.Size(355, 22)
        Me.Car_Mileage.TabIndex = 73
        '
        'Label54
        '
        Me.Label54.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label54.BackColor = System.Drawing.Color.White
        Me.Label54.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label54.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label54.ForeColor = System.Drawing.Color.Black
        Me.Label54.Location = New System.Drawing.Point(12, 253)
        Me.Label54.Name = "Label54"
        Me.Label54.Size = New System.Drawing.Size(278, 20)
        Me.Label54.TabIndex = 72
        Me.Label54.Text = "Mileage:"
        Me.Label54.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Car_VRN
        '
        Me.Car_VRN.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Car_VRN.BackColor = System.Drawing.Color.White
        Me.Car_VRN.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Car_VRN.ForeColor = System.Drawing.Color.Black
        Me.Car_VRN.Location = New System.Drawing.Point(300, 228)
        Me.Car_VRN.MaxLength = 20
        Me.Car_VRN.Name = "Car_VRN"
        Me.Car_VRN.Size = New System.Drawing.Size(355, 22)
        Me.Car_VRN.TabIndex = 69
        '
        'Label52
        '
        Me.Label52.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label52.BackColor = System.Drawing.Color.White
        Me.Label52.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label52.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label52.ForeColor = System.Drawing.Color.Black
        Me.Label52.Location = New System.Drawing.Point(12, 229)
        Me.Label52.Name = "Label52"
        Me.Label52.Size = New System.Drawing.Size(278, 20)
        Me.Label52.TabIndex = 68
        Me.Label52.Text = "Registration Number:"
        Me.Label52.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label51
        '
        Me.Label51.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label51.BackColor = System.Drawing.Color.White
        Me.Label51.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label51.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label51.ForeColor = System.Drawing.Color.Black
        Me.Label51.Location = New System.Drawing.Point(13, 19)
        Me.Label51.Name = "Label51"
        Me.Label51.Size = New System.Drawing.Size(277, 20)
        Me.Label51.TabIndex = 66
        Me.Label51.Text = "Make:"
        Me.Label51.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Car_Model
        '
        Me.Car_Model.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Car_Model.BackColor = System.Drawing.Color.White
        Me.Car_Model.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Car_Model.ForeColor = System.Drawing.Color.Black
        Me.Car_Model.Location = New System.Drawing.Point(301, 45)
        Me.Car_Model.MaxLength = 25
        Me.Car_Model.Name = "Car_Model"
        Me.Car_Model.Size = New System.Drawing.Size(355, 22)
        Me.Car_Model.TabIndex = 65
        '
        'Label49
        '
        Me.Label49.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label49.BackColor = System.Drawing.Color.White
        Me.Label49.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label49.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label49.ForeColor = System.Drawing.Color.Black
        Me.Label49.Location = New System.Drawing.Point(13, 45)
        Me.Label49.Name = "Label49"
        Me.Label49.Size = New System.Drawing.Size(277, 20)
        Me.Label49.TabIndex = 64
        Me.Label49.Text = "Model:"
        Me.Label49.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'AssetPicture
        '
        Me.AssetPicture.BackColor = System.Drawing.Color.White
        Me.AssetPicture.ForeColor = System.Drawing.Color.Black
        Me.AssetPicture.Image = Global.PMD.My.Resources.Resources._1369846665_Document_write_icon
        Me.AssetPicture.Location = New System.Drawing.Point(13, 24)
        Me.AssetPicture.Name = "AssetPicture"
        Me.AssetPicture.Size = New System.Drawing.Size(212, 185)
        Me.AssetPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.AssetPicture.TabIndex = 32
        Me.AssetPicture.TabStop = False
        '
        'Header
        '
        Me.Header.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Header.BackColor = System.Drawing.Color.White
        Me.Header.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Header.Font = New System.Drawing.Font("Tahoma", 8.0!)
        Me.Header.ForeColor = System.Drawing.Color.Black
        Me.Header.Location = New System.Drawing.Point(10, 20)
        Me.Header.Name = "Header"
        Me.Header.Padding = New System.Windows.Forms.Padding(250, 0, 0, 0)
        Me.Header.Size = New System.Drawing.Size(698, 192)
        Me.Header.TabIndex = 31
        Me.Header.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.White
        Me.Label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(9, 215)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(337, 20)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Asset Type:"
        '
        'AssetImageList
        '
        Me.AssetImageList.ImageStream = CType(resources.GetObject("AssetImageList.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.AssetImageList.TransparentColor = System.Drawing.Color.Transparent
        Me.AssetImageList.Images.SetKeyName(0, "1369846665_Document-write-icon.png")
        Me.AssetImageList.Images.SetKeyName(1, "1369846901_access_point.png")
        Me.AssetImageList.Images.SetKeyName(2, "1369846953_contact.png")
        Me.AssetImageList.Images.SetKeyName(3, "1369847023_Apple iPhone.png")
        Me.AssetImageList.Images.SetKeyName(4, "1369847130_questionmark.png")
        Me.AssetImageList.Images.SetKeyName(5, "1369847202_mycomputer.png")
        Me.AssetImageList.Images.SetKeyName(6, "1369847220_tv.png")
        Me.AssetImageList.Images.SetKeyName(7, "SkyLogo_300x300.jpg_177254702.jpg")
        Me.AssetImageList.Images.SetKeyName(8, "1369847481_224261-camera-web.png")
        Me.AssetImageList.Images.SetKeyName(9, "1369847540_CarGrey.png")
        '
        'DeleteBtn
        '
        Me.DeleteBtn.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DeleteBtn.BackColor = System.Drawing.Color.White
        Me.DeleteBtn.ForeColor = System.Drawing.Color.Black
        Me.DeleteBtn.Image = Global.PMD.My.Resources.Resources._1364511183_dialog_close
        Me.DeleteBtn.Location = New System.Drawing.Point(339, 758)
        Me.DeleteBtn.Name = "DeleteBtn"
        Me.DeleteBtn.Size = New System.Drawing.Size(121, 26)
        Me.DeleteBtn.TabIndex = 38
        Me.DeleteBtn.Text = "Delete Asset"
        Me.DeleteBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.DeleteBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.DeleteBtn.UseVisualStyleBackColor = False
        Me.DeleteBtn.Visible = False
        '
        'CancelBtn
        '
        Me.CancelBtn.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CancelBtn.BackColor = System.Drawing.Color.White
        Me.CancelBtn.ForeColor = System.Drawing.Color.Black
        Me.CancelBtn.Image = Global.PMD.My.Resources.Resources._1364677462_1011
        Me.CancelBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.CancelBtn.Location = New System.Drawing.Point(466, 758)
        Me.CancelBtn.Name = "CancelBtn"
        Me.CancelBtn.Size = New System.Drawing.Size(121, 26)
        Me.CancelBtn.TabIndex = 31
        Me.CancelBtn.Text = "Cancel"
        Me.CancelBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.CancelBtn.UseVisualStyleBackColor = False
        Me.CancelBtn.Visible = False
        '
        'OkBtn
        '
        Me.OkBtn.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.OkBtn.BackColor = System.Drawing.Color.White
        Me.OkBtn.ForeColor = System.Drawing.Color.Black
        Me.OkBtn.Image = Global.PMD.My.Resources.Resources._1364677427_tick
        Me.OkBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.OkBtn.Location = New System.Drawing.Point(594, 758)
        Me.OkBtn.Name = "OkBtn"
        Me.OkBtn.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.OkBtn.Size = New System.Drawing.Size(122, 26)
        Me.OkBtn.TabIndex = 32
        Me.OkBtn.Text = "OK"
        Me.OkBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.OkBtn.UseVisualStyleBackColor = False
        '
        'EditBtn
        '
        Me.EditBtn.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.EditBtn.BackColor = System.Drawing.Color.White
        Me.EditBtn.ForeColor = System.Drawing.Color.Black
        Me.EditBtn.Image = Global.PMD.My.Resources.Resources._1364946094_pencil_16
        Me.EditBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.EditBtn.Location = New System.Drawing.Point(466, 758)
        Me.EditBtn.Name = "EditBtn"
        Me.EditBtn.Size = New System.Drawing.Size(121, 26)
        Me.EditBtn.TabIndex = 33
        Me.EditBtn.Text = "Edit"
        Me.EditBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.EditBtn.UseVisualStyleBackColor = False
        '
        'AssetForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(719, 790)
        Me.Controls.Add(Me.DeleteBtn)
        Me.Controls.Add(Me.CancelBtn)
        Me.Controls.Add(Me.OkBtn)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.EditBtn)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Name = "AssetForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Asset - "
        Me.GroupBox1.ResumeLayout(False)
        Me.Log_Box.ResumeLayout(False)
        CType(Me.LogsGrid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabControl.ResumeLayout(False)
        Me.MainTab.ResumeLayout(False)
        Me.MainTab.PerformLayout()
        Me.DataTab.ResumeLayout(False)
        Me.DataTab.PerformLayout()
        Me.VoiceTab.ResumeLayout(False)
        Me.VoiceTab.PerformLayout()
        CType(Me.LandlineGrid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MobileTab.ResumeLayout(False)
        Me.MobileTab.PerformLayout()
        Me.ApplianceTab.ResumeLayout(False)
        Me.ApplianceTab.PerformLayout()
        Me.PCTab.ResumeLayout(False)
        Me.PCTab.PerformLayout()
        Me.TVTab.ResumeLayout(False)
        Me.TVTab.PerformLayout()
        Me.SkyTab.ResumeLayout(False)
        CType(Me.SkyGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.DVRTab.ResumeLayout(False)
        Me.DVRTab.PerformLayout()
        Me.CarTab.ResumeLayout(False)
        Me.CarTab.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.AssetPicture, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents AssetPicture As System.Windows.Forms.PictureBox
    Friend WithEvents Header As System.Windows.Forms.Label
    Friend WithEvents TabControl As System.Windows.Forms.TabControl
    Friend WithEvents DataTab As System.Windows.Forms.TabPage
    Friend WithEvents Data_Type As System.Windows.Forms.ComboBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Data_Location As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Data_Password As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Data_Username As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Data_IPAddress As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Data_Model As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Data_Manufacturer As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents DataMaintainerContract As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents LinkDataMaintainerBtn As System.Windows.Forms.Button
    Friend WithEvents DataBBContract As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents LinkDataBBtn As System.Windows.Forms.Button
    Friend WithEvents VoiceTab As System.Windows.Forms.TabPage
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Voice_PIN As System.Windows.Forms.TextBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Voice_Model As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Voice_Manufacturer As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents LandlineGrid As System.Windows.Forms.DataGridView
    Friend WithEvents RemoveLineBtn As System.Windows.Forms.Button
    Friend WithEvents AddLineBtn As System.Windows.Forms.Button
    Friend WithEvents MobileTab As System.Windows.Forms.TabPage
    Friend WithEvents Mobile_Brand As System.Windows.Forms.TextBox
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents LinkContractBtn As System.Windows.Forms.Button
    Friend WithEvents MobileContract As System.Windows.Forms.Label
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents Mobile_Network As System.Windows.Forms.ComboBox
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents Mobile_IMEI As System.Windows.Forms.TextBox
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Mobile_Model As System.Windows.Forms.TextBox
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents ApplianceTab As System.Windows.Forms.TabPage
    Friend WithEvents Appliance_Location As System.Windows.Forms.TextBox
    Friend WithEvents Label25 As System.Windows.Forms.Label
    Friend WithEvents Label24 As System.Windows.Forms.Label
    Friend WithEvents Appliance_Serial As System.Windows.Forms.TextBox
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents Appliance_Type As System.Windows.Forms.TextBox
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents Appliance_Model As System.Windows.Forms.TextBox
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents Appliance_Manufacturer As System.Windows.Forms.TextBox
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents Appliance_Warranty As System.Windows.Forms.ComboBox
    Friend WithEvents PCTab As System.Windows.Forms.TabPage
    Friend WithEvents PC_Location As System.Windows.Forms.TextBox
    Friend WithEvents Label32 As System.Windows.Forms.Label
    Friend WithEvents PC_Password As System.Windows.Forms.TextBox
    Friend WithEvents Label31 As System.Windows.Forms.Label
    Friend WithEvents PC_Warranty As System.Windows.Forms.ComboBox
    Friend WithEvents PC_Username As System.Windows.Forms.TextBox
    Friend WithEvents Label26 As System.Windows.Forms.Label
    Friend WithEvents Label27 As System.Windows.Forms.Label
    Friend WithEvents PC_Serial As System.Windows.Forms.TextBox
    Friend WithEvents Label28 As System.Windows.Forms.Label
    Friend WithEvents PC_Model As System.Windows.Forms.TextBox
    Friend WithEvents Label29 As System.Windows.Forms.Label
    Friend WithEvents PC_Manufacturer As System.Windows.Forms.TextBox
    Friend WithEvents Label30 As System.Windows.Forms.Label
    Friend WithEvents TVTab As System.Windows.Forms.TabPage
    Friend WithEvents TV_Location As System.Windows.Forms.TextBox
    Friend WithEvents Label33 As System.Windows.Forms.Label
    Friend WithEvents TV_Warranty As System.Windows.Forms.ComboBox
    Friend WithEvents Label36 As System.Windows.Forms.Label
    Friend WithEvents TV_Serial As System.Windows.Forms.TextBox
    Friend WithEvents Label37 As System.Windows.Forms.Label
    Friend WithEvents TV_Model As System.Windows.Forms.TextBox
    Friend WithEvents Label38 As System.Windows.Forms.Label
    Friend WithEvents TV_Manufacturer As System.Windows.Forms.TextBox
    Friend WithEvents Label39 As System.Windows.Forms.Label
    Friend WithEvents SkyTab As System.Windows.Forms.TabPage
    Friend WithEvents DVRTab As System.Windows.Forms.TabPage
    Friend WithEvents Label47 As System.Windows.Forms.Label
    Friend WithEvents DVR_Password As System.Windows.Forms.TextBox
    Friend WithEvents Label35 As System.Windows.Forms.Label
    Friend WithEvents DVR_Username As System.Windows.Forms.TextBox
    Friend WithEvents Label43 As System.Windows.Forms.Label
    Friend WithEvents DVR_Serial As System.Windows.Forms.TextBox
    Friend WithEvents Label44 As System.Windows.Forms.Label
    Friend WithEvents DVR_Channels As System.Windows.Forms.TextBox
    Friend WithEvents Label45 As System.Windows.Forms.Label
    Friend WithEvents DVR_Model As System.Windows.Forms.TextBox
    Friend WithEvents Label46 As System.Windows.Forms.Label
    Friend WithEvents DVR_Software As System.Windows.Forms.TextBox
    Friend WithEvents Label48 As System.Windows.Forms.Label
    Friend WithEvents DVR_LicenseDue As System.Windows.Forms.DateTimePicker
    Friend WithEvents DVRMaintainerContract As System.Windows.Forms.Label
    Friend WithEvents Label50 As System.Windows.Forms.Label
    Friend WithEvents LinkDVRMaintainerBtn As System.Windows.Forms.Button
    Friend WithEvents CarTab As System.Windows.Forms.TabPage
    Friend WithEvents InsuranceContract As System.Windows.Forms.Label
    Friend WithEvents Label62 As System.Windows.Forms.Label
    Friend WithEvents LinkInsuranceBtn As System.Windows.Forms.Button
    Friend WithEvents TAXContract As System.Windows.Forms.Label
    Friend WithEvents Label56 As System.Windows.Forms.Label
    Friend WithEvents LinkTAXBtn As System.Windows.Forms.Button
    Friend WithEvents MOTContract As System.Windows.Forms.Label
    Friend WithEvents Label58 As System.Windows.Forms.Label
    Friend WithEvents LinkMOTBtn As System.Windows.Forms.Button
    Friend WithEvents Car_Mileage As System.Windows.Forms.TextBox
    Friend WithEvents Label54 As System.Windows.Forms.Label
    Friend WithEvents Car_VRN As System.Windows.Forms.TextBox
    Friend WithEvents Label52 As System.Windows.Forms.Label
    Friend WithEvents Label51 As System.Windows.Forms.Label
    Friend WithEvents Car_Model As System.Windows.Forms.TextBox
    Friend WithEvents Label49 As System.Windows.Forms.Label
    Friend WithEvents Car_Make As System.Windows.Forms.ComboBox
    Friend WithEvents MainTab As System.Windows.Forms.TabPage
    Friend WithEvents Label59 As System.Windows.Forms.Label
    Friend WithEvents Voice_Extensions As System.Windows.Forms.TextBox
    Friend WithEvents Label60 As System.Windows.Forms.Label
    Friend WithEvents EditBtn As System.Windows.Forms.Button
    Friend WithEvents CancelBtn As System.Windows.Forms.Button
    Friend WithEvents OkBtn As System.Windows.Forms.Button
    Friend WithEvents RemoveViewCardBtn As System.Windows.Forms.Button
    Friend WithEvents AddViewCardBtn As System.Windows.Forms.Button
    Friend WithEvents SkyGridView As System.Windows.Forms.DataGridView
    Friend WithEvents AssetImageList As System.Windows.Forms.ImageList
    Friend WithEvents AssetID As System.Windows.Forms.Label
    Friend WithEvents Voice_Location As System.Windows.Forms.TextBox
    Friend WithEvents Label40 As System.Windows.Forms.Label
    Friend WithEvents DVR_Location As System.Windows.Forms.TextBox
    Friend WithEvents Label41 As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Car_Keeper_Address As System.Windows.Forms.TextBox
    Friend WithEvents Label42 As System.Windows.Forms.Label
    Friend WithEvents Car_Keeper As System.Windows.Forms.TextBox
    Friend WithEvents Label34 As System.Windows.Forms.Label
    Friend WithEvents DeleteBtn As System.Windows.Forms.Button
    Friend WithEvents AttachPhotoBtn As DevComponents.DotNetBar.ButtonX
    Friend WithEvents Appliance_WarrantyPeriod As System.Windows.Forms.TextBox
    Friend WithEvents PC_WarrantyPeriod As System.Windows.Forms.TextBox
    Friend WithEvents TV_WarrantyPeriod As System.Windows.Forms.TextBox
    Friend WithEvents Log_Box As System.Windows.Forms.GroupBox
    Friend WithEvents AddLogBtn As DevComponents.DotNetBar.ButtonX
    Friend WithEvents DeleteLogBtn As DevComponents.DotNetBar.ButtonX
    Friend WithEvents LogsGrid As DevComponents.DotNetBar.Controls.DataGridViewX
    Friend WithEvents AssetType As PMD.SortComboBox
End Class
