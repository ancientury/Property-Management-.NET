<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SettingsForm
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
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.AdvTree1 = New DevComponents.AdvTree.AdvTree()
        Me.GeneralNode = New DevComponents.AdvTree.Node()
        Me.Node1 = New DevComponents.AdvTree.Node()
        Me.Node2 = New DevComponents.AdvTree.Node()
        Me.Node3 = New DevComponents.AdvTree.Node()
        Me.DBNode = New DevComponents.AdvTree.Node()
        Me.DBPrefixesNode = New DevComponents.AdvTree.Node()
        Me.NodeConnector1 = New DevComponents.AdvTree.NodeConnector()
        Me.ElementStyle1 = New DevComponents.DotNetBar.ElementStyle()
        Me.SettingsTabControl = New System.Windows.Forms.TabControl()
        Me.MainTab = New System.Windows.Forms.TabPage()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.StartupTab = New System.Windows.Forms.TabPage()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.AutoLoginCheckbox = New DevComponents.DotNetBar.Controls.CheckBoxX()
        Me.TestLoginBtn = New DevComponents.DotNetBar.ButtonX()
        Me.ShowPassCharsCheckbox = New DevComponents.DotNetBar.Controls.CheckBoxX()
        Me.LabelX2 = New DevComponents.DotNetBar.LabelX()
        Me.LabelX1 = New DevComponents.DotNetBar.LabelX()
        Me.PasswordTextBox = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.UsernameTextBox = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.LaunchStartUpCheckBox = New DevComponents.DotNetBar.Controls.CheckBoxX()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.HiddenRadioBtn = New System.Windows.Forms.RadioButton()
        Me.NormalRadioBtn = New System.Windows.Forms.RadioButton()
        Me.PromptsTab = New System.Windows.Forms.TabPage()
        Me.GroupBox10 = New System.Windows.Forms.GroupBox()
        Me.NotifyReminder = New DevComponents.DotNetBar.Controls.CheckBoxX()
        Me.GroupBox9 = New System.Windows.Forms.GroupBox()
        Me.AskBeforeDeletingLogs = New DevComponents.DotNetBar.Controls.CheckBoxX()
        Me.GroupBox8 = New System.Windows.Forms.GroupBox()
        Me.AskBeforeModifyingInvoices = New DevComponents.DotNetBar.Controls.CheckBoxX()
        Me.AskBeforeDeletingInvoices = New DevComponents.DotNetBar.Controls.CheckBoxX()
        Me.GroupBox7 = New System.Windows.Forms.GroupBox()
        Me.NotifyUpdate = New DevComponents.DotNetBar.Controls.CheckBoxX()
        Me.GroupBox6 = New System.Windows.Forms.GroupBox()
        Me.AskBeforeModifyingContracts = New DevComponents.DotNetBar.Controls.CheckBoxX()
        Me.AskBeforeDeletingContracts = New DevComponents.DotNetBar.Controls.CheckBoxX()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.AskBeforeModifyingAssets = New DevComponents.DotNetBar.Controls.CheckBoxX()
        Me.AskBeforeDeletingAssets = New DevComponents.DotNetBar.Controls.CheckBoxX()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.AskBeforeModifyingProperties = New DevComponents.DotNetBar.Controls.CheckBoxX()
        Me.AskBeforeDeletingProperties = New DevComponents.DotNetBar.Controls.CheckBoxX()
        Me.FontsTab = New System.Windows.Forms.TabPage()
        Me.DBPrefixesTab = New System.Windows.Forms.TabPage()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.S_AccountsTable = New System.Windows.Forms.TextBox()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.S_MLogsTable = New System.Windows.Forms.TextBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.S_LandlinesTable = New System.Windows.Forms.TextBox()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.S_PicturesTable = New System.Windows.Forms.TextBox()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.S_LogsTable = New System.Windows.Forms.TextBox()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.S_TasksTable = New System.Windows.Forms.TextBox()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.S_ContactsTable = New System.Windows.Forms.TextBox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.S_CarTable = New System.Windows.Forms.TextBox()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.S_DVRNVRTable = New System.Windows.Forms.TextBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.S_SkyTable = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.S_TVTable = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.S_PCTable = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.S_ApplianceTable = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.S_MobileTable = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.S_VoiceTable = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.S_DataTable = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.S_DocTable = New System.Windows.Forms.TextBox()
        Me.DefaultSettings = New System.Windows.Forms.Button()
        Me.ApplySettings = New System.Windows.Forms.Button()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.S_InvoicesTable = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.S_ContractsTable = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.S_PKEY = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.S_PropertiesTable = New System.Windows.Forms.TextBox()
        Me.FontDialog1 = New System.Windows.Forms.FontDialog()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        CType(Me.AdvTree1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SettingsTabControl.SuspendLayout()
        Me.MainTab.SuspendLayout()
        Me.StartupTab.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.PromptsTab.SuspendLayout()
        Me.GroupBox10.SuspendLayout()
        Me.GroupBox9.SuspendLayout()
        Me.GroupBox8.SuspendLayout()
        Me.GroupBox7.SuspendLayout()
        Me.GroupBox6.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.DBPrefixesTab.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.SuspendLayout()
        '
        'SplitContainer1
        '
        Me.SplitContainer1.BackColor = System.Drawing.Color.White
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel2
        Me.SplitContainer1.ForeColor = System.Drawing.Color.Black
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer1.Name = "SplitContainer1"
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(211, Byte), Integer), CType(CType(211, Byte), Integer), CType(CType(211, Byte), Integer))
        Me.SplitContainer1.Panel1.Controls.Add(Me.AdvTree1)
        Me.SplitContainer1.Panel1.ForeColor = System.Drawing.Color.Black
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(211, Byte), Integer), CType(CType(211, Byte), Integer), CType(CType(211, Byte), Integer))
        Me.SplitContainer1.Panel2.Controls.Add(Me.SettingsTabControl)
        Me.SplitContainer1.Panel2.ForeColor = System.Drawing.Color.Black
        Me.SplitContainer1.Size = New System.Drawing.Size(799, 700)
        Me.SplitContainer1.SplitterDistance = 192
        Me.SplitContainer1.TabIndex = 6
        '
        'AdvTree1
        '
        Me.AdvTree1.AccessibleRole = System.Windows.Forms.AccessibleRole.Outline
        Me.AdvTree1.AllowDrop = True
        Me.AdvTree1.BackColor = System.Drawing.Color.White
        '
        '
        '
        Me.AdvTree1.BackgroundStyle.Class = "TreeBorderKey"
        Me.AdvTree1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.AdvTree1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.AdvTree1.ForeColor = System.Drawing.Color.Black
        Me.AdvTree1.Location = New System.Drawing.Point(0, 0)
        Me.AdvTree1.Name = "AdvTree1"
        Me.AdvTree1.Nodes.AddRange(New DevComponents.AdvTree.Node() {Me.GeneralNode, Me.DBNode})
        Me.AdvTree1.NodesConnector = Me.NodeConnector1
        Me.AdvTree1.NodeStyle = Me.ElementStyle1
        Me.AdvTree1.PathSeparator = ";"
        Me.AdvTree1.Size = New System.Drawing.Size(192, 700)
        Me.AdvTree1.Styles.Add(Me.ElementStyle1)
        Me.AdvTree1.TabIndex = 0
        Me.AdvTree1.Text = "AdvTree1"
        '
        'GeneralNode
        '
        Me.GeneralNode.Expanded = True
        Me.GeneralNode.Name = "GeneralNode"
        Me.GeneralNode.Nodes.AddRange(New DevComponents.AdvTree.Node() {Me.Node1, Me.Node2, Me.Node3})
        Me.GeneralNode.Text = "General"
        '
        'Node1
        '
        Me.Node1.Expanded = True
        Me.Node1.Name = "Node1"
        Me.Node1.Text = "Startup"
        '
        'Node2
        '
        Me.Node2.Expanded = True
        Me.Node2.Name = "Node2"
        Me.Node2.Text = "Prompts and Notifications"
        '
        'Node3
        '
        Me.Node3.Expanded = True
        Me.Node3.Name = "Node3"
        Me.Node3.Text = "Fonts"
        '
        'DBNode
        '
        Me.DBNode.Expanded = True
        Me.DBNode.Name = "DBNode"
        Me.DBNode.Nodes.AddRange(New DevComponents.AdvTree.Node() {Me.DBPrefixesNode})
        Me.DBNode.Text = "Database"
        '
        'DBPrefixesNode
        '
        Me.DBPrefixesNode.Expanded = True
        Me.DBPrefixesNode.Name = "DBPrefixesNode"
        Me.DBPrefixesNode.Text = "Database Prefixes"
        '
        'NodeConnector1
        '
        Me.NodeConnector1.LineColor = System.Drawing.Color.FromArgb(CType(CType(135, Byte), Integer), CType(CType(135, Byte), Integer), CType(CType(135, Byte), Integer))
        '
        'ElementStyle1
        '
        Me.ElementStyle1.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.ElementStyle1.Name = "ElementStyle1"
        Me.ElementStyle1.TextColor = System.Drawing.Color.Black
        '
        'SettingsTabControl
        '
        Me.SettingsTabControl.Controls.Add(Me.MainTab)
        Me.SettingsTabControl.Controls.Add(Me.StartupTab)
        Me.SettingsTabControl.Controls.Add(Me.PromptsTab)
        Me.SettingsTabControl.Controls.Add(Me.FontsTab)
        Me.SettingsTabControl.Controls.Add(Me.DBPrefixesTab)
        Me.SettingsTabControl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SettingsTabControl.ForeColor = System.Drawing.Color.Black
        Me.SettingsTabControl.Location = New System.Drawing.Point(0, 0)
        Me.SettingsTabControl.Name = "SettingsTabControl"
        Me.SettingsTabControl.SelectedIndex = 0
        Me.SettingsTabControl.Size = New System.Drawing.Size(603, 700)
        Me.SettingsTabControl.TabIndex = 0
        '
        'MainTab
        '
        Me.MainTab.Controls.Add(Me.Label11)
        Me.MainTab.ForeColor = System.Drawing.Color.Black
        Me.MainTab.Location = New System.Drawing.Point(4, 22)
        Me.MainTab.Name = "MainTab"
        Me.MainTab.Padding = New System.Windows.Forms.Padding(3)
        Me.MainTab.Size = New System.Drawing.Size(595, 674)
        Me.MainTab.TabIndex = 0
        Me.MainTab.Text = "Settings"
        Me.MainTab.UseVisualStyleBackColor = True
        '
        'Label11
        '
        Me.Label11.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.Black
        Me.Label11.Location = New System.Drawing.Point(54, 314)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(493, 21)
        Me.Label11.TabIndex = 0
        Me.Label11.Text = "<-- Select the type of setting you want to view/edit from the left panel"
        '
        'StartupTab
        '
        Me.StartupTab.Controls.Add(Me.GroupBox2)
        Me.StartupTab.Controls.Add(Me.GroupBox1)
        Me.StartupTab.ForeColor = System.Drawing.Color.Black
        Me.StartupTab.Location = New System.Drawing.Point(4, 22)
        Me.StartupTab.Name = "StartupTab"
        Me.StartupTab.Size = New System.Drawing.Size(595, 674)
        Me.StartupTab.TabIndex = 2
        Me.StartupTab.Text = "Startup"
        Me.StartupTab.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.AutoLoginCheckbox)
        Me.GroupBox2.Controls.Add(Me.TestLoginBtn)
        Me.GroupBox2.Controls.Add(Me.ShowPassCharsCheckbox)
        Me.GroupBox2.Controls.Add(Me.LabelX2)
        Me.GroupBox2.Controls.Add(Me.LabelX1)
        Me.GroupBox2.Controls.Add(Me.PasswordTextBox)
        Me.GroupBox2.Controls.Add(Me.UsernameTextBox)
        Me.GroupBox2.Controls.Add(Me.LaunchStartUpCheckBox)
        Me.GroupBox2.ForeColor = System.Drawing.Color.Black
        Me.GroupBox2.Location = New System.Drawing.Point(15, 226)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(559, 289)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Windows Startup"
        '
        'AutoLoginCheckbox
        '
        '
        '
        '
        Me.AutoLoginCheckbox.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.AutoLoginCheckbox.ForeColor = System.Drawing.Color.Black
        Me.AutoLoginCheckbox.Location = New System.Drawing.Point(42, 73)
        Me.AutoLoginCheckbox.Name = "AutoLoginCheckbox"
        Me.AutoLoginCheckbox.Size = New System.Drawing.Size(351, 23)
        Me.AutoLoginCheckbox.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.AutoLoginCheckbox.TabIndex = 8
        Me.AutoLoginCheckbox.Text = "Auto-login at startup using the following username and password"
        '
        'TestLoginBtn
        '
        Me.TestLoginBtn.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.TestLoginBtn.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.TestLoginBtn.Enabled = False
        Me.TestLoginBtn.Location = New System.Drawing.Point(238, 250)
        Me.TestLoginBtn.Name = "TestLoginBtn"
        Me.TestLoginBtn.Size = New System.Drawing.Size(75, 23)
        Me.TestLoginBtn.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.TestLoginBtn.TabIndex = 7
        Me.TestLoginBtn.Text = "Test Login"
        '
        'ShowPassCharsCheckbox
        '
        '
        '
        '
        Me.ShowPassCharsCheckbox.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.ShowPassCharsCheckbox.Enabled = False
        Me.ShowPassCharsCheckbox.ForeColor = System.Drawing.Color.Black
        Me.ShowPassCharsCheckbox.Location = New System.Drawing.Point(161, 216)
        Me.ShowPassCharsCheckbox.Name = "ShowPassCharsCheckbox"
        Me.ShowPassCharsCheckbox.Size = New System.Drawing.Size(163, 23)
        Me.ShowPassCharsCheckbox.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.ShowPassCharsCheckbox.TabIndex = 6
        Me.ShowPassCharsCheckbox.Text = "Show password characters"
        '
        'LabelX2
        '
        '
        '
        '
        Me.LabelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX2.ForeColor = System.Drawing.Color.Black
        Me.LabelX2.Location = New System.Drawing.Point(161, 159)
        Me.LabelX2.Name = "LabelX2"
        Me.LabelX2.Size = New System.Drawing.Size(75, 23)
        Me.LabelX2.TabIndex = 5
        Me.LabelX2.Text = "Password:"
        '
        'LabelX1
        '
        '
        '
        '
        Me.LabelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX1.ForeColor = System.Drawing.Color.Black
        Me.LabelX1.Location = New System.Drawing.Point(161, 102)
        Me.LabelX1.Name = "LabelX1"
        Me.LabelX1.Size = New System.Drawing.Size(75, 23)
        Me.LabelX1.TabIndex = 4
        Me.LabelX1.Text = "Username:"
        '
        'PasswordTextBox
        '
        Me.PasswordTextBox.BackColor = System.Drawing.Color.White
        '
        '
        '
        Me.PasswordTextBox.Border.Class = "TextBoxBorder"
        Me.PasswordTextBox.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.PasswordTextBox.ForeColor = System.Drawing.Color.Black
        Me.PasswordTextBox.Location = New System.Drawing.Point(161, 188)
        Me.PasswordTextBox.Name = "PasswordTextBox"
        Me.PasswordTextBox.ReadOnly = True
        Me.PasswordTextBox.Size = New System.Drawing.Size(245, 22)
        Me.PasswordTextBox.TabIndex = 3
        '
        'UsernameTextBox
        '
        Me.UsernameTextBox.BackColor = System.Drawing.Color.White
        '
        '
        '
        Me.UsernameTextBox.Border.Class = "TextBoxBorder"
        Me.UsernameTextBox.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.UsernameTextBox.ForeColor = System.Drawing.Color.Black
        Me.UsernameTextBox.Location = New System.Drawing.Point(161, 131)
        Me.UsernameTextBox.Name = "UsernameTextBox"
        Me.UsernameTextBox.ReadOnly = True
        Me.UsernameTextBox.Size = New System.Drawing.Size(245, 22)
        Me.UsernameTextBox.TabIndex = 2
        '
        'LaunchStartUpCheckBox
        '
        '
        '
        '
        Me.LaunchStartUpCheckBox.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LaunchStartUpCheckBox.Checked = True
        Me.LaunchStartUpCheckBox.CheckState = System.Windows.Forms.CheckState.Checked
        Me.LaunchStartUpCheckBox.CheckValue = "Y"
        Me.LaunchStartUpCheckBox.ForeColor = System.Drawing.Color.Black
        Me.LaunchStartUpCheckBox.Location = New System.Drawing.Point(42, 44)
        Me.LaunchStartUpCheckBox.Name = "LaunchStartUpCheckBox"
        Me.LaunchStartUpCheckBox.Size = New System.Drawing.Size(337, 23)
        Me.LaunchStartUpCheckBox.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.LaunchStartUpCheckBox.TabIndex = 0
        Me.LaunchStartUpCheckBox.Text = "Launch Property Management .NET when windows starts"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.HiddenRadioBtn)
        Me.GroupBox1.Controls.Add(Me.NormalRadioBtn)
        Me.GroupBox1.ForeColor = System.Drawing.Color.Black
        Me.GroupBox1.Location = New System.Drawing.Point(15, 86)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(559, 102)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Window Position"
        '
        'HiddenRadioBtn
        '
        Me.HiddenRadioBtn.AutoSize = True
        Me.HiddenRadioBtn.ForeColor = System.Drawing.Color.Black
        Me.HiddenRadioBtn.Location = New System.Drawing.Point(330, 44)
        Me.HiddenRadioBtn.Name = "HiddenRadioBtn"
        Me.HiddenRadioBtn.Size = New System.Drawing.Size(135, 17)
        Me.HiddenRadioBtn.TabIndex = 1
        Me.HiddenRadioBtn.TabStop = True
        Me.HiddenRadioBtn.Text = "Hidden in system tray"
        Me.HiddenRadioBtn.UseVisualStyleBackColor = True
        '
        'NormalRadioBtn
        '
        Me.NormalRadioBtn.AutoSize = True
        Me.NormalRadioBtn.Checked = True
        Me.NormalRadioBtn.ForeColor = System.Drawing.Color.Black
        Me.NormalRadioBtn.Location = New System.Drawing.Point(101, 44)
        Me.NormalRadioBtn.Name = "NormalRadioBtn"
        Me.NormalRadioBtn.Size = New System.Drawing.Size(62, 17)
        Me.NormalRadioBtn.TabIndex = 0
        Me.NormalRadioBtn.TabStop = True
        Me.NormalRadioBtn.Text = "Normal"
        Me.NormalRadioBtn.UseVisualStyleBackColor = True
        '
        'PromptsTab
        '
        Me.PromptsTab.Controls.Add(Me.GroupBox10)
        Me.PromptsTab.Controls.Add(Me.GroupBox9)
        Me.PromptsTab.Controls.Add(Me.GroupBox8)
        Me.PromptsTab.Controls.Add(Me.GroupBox7)
        Me.PromptsTab.Controls.Add(Me.GroupBox6)
        Me.PromptsTab.Controls.Add(Me.GroupBox5)
        Me.PromptsTab.Controls.Add(Me.GroupBox3)
        Me.PromptsTab.ForeColor = System.Drawing.Color.Black
        Me.PromptsTab.Location = New System.Drawing.Point(4, 22)
        Me.PromptsTab.Name = "PromptsTab"
        Me.PromptsTab.Size = New System.Drawing.Size(595, 674)
        Me.PromptsTab.TabIndex = 3
        Me.PromptsTab.Text = "Prompts"
        Me.PromptsTab.UseVisualStyleBackColor = True
        '
        'GroupBox10
        '
        Me.GroupBox10.Controls.Add(Me.NotifyReminder)
        Me.GroupBox10.ForeColor = System.Drawing.Color.Black
        Me.GroupBox10.Location = New System.Drawing.Point(18, 447)
        Me.GroupBox10.Name = "GroupBox10"
        Me.GroupBox10.Size = New System.Drawing.Size(541, 54)
        Me.GroupBox10.TabIndex = 7
        Me.GroupBox10.TabStop = False
        Me.GroupBox10.Text = "Tasks/Reminders"
        '
        'NotifyReminder
        '
        '
        '
        '
        Me.NotifyReminder.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.NotifyReminder.Checked = True
        Me.NotifyReminder.CheckState = System.Windows.Forms.CheckState.Checked
        Me.NotifyReminder.CheckValue = "Y"
        Me.NotifyReminder.ForeColor = System.Drawing.Color.Black
        Me.NotifyReminder.Location = New System.Drawing.Point(56, 21)
        Me.NotifyReminder.Name = "NotifyReminder"
        Me.NotifyReminder.Size = New System.Drawing.Size(430, 23)
        Me.NotifyReminder.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.NotifyReminder.TabIndex = 0
        Me.NotifyReminder.Text = "Notify when a reminder is overdue"
        '
        'GroupBox9
        '
        Me.GroupBox9.Controls.Add(Me.AskBeforeDeletingLogs)
        Me.GroupBox9.ForeColor = System.Drawing.Color.Black
        Me.GroupBox9.Location = New System.Drawing.Point(18, 387)
        Me.GroupBox9.Name = "GroupBox9"
        Me.GroupBox9.Size = New System.Drawing.Size(541, 54)
        Me.GroupBox9.TabIndex = 6
        Me.GroupBox9.TabStop = False
        Me.GroupBox9.Text = "Logs"
        '
        'AskBeforeDeletingLogs
        '
        '
        '
        '
        Me.AskBeforeDeletingLogs.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.AskBeforeDeletingLogs.Checked = True
        Me.AskBeforeDeletingLogs.CheckState = System.Windows.Forms.CheckState.Checked
        Me.AskBeforeDeletingLogs.CheckValue = "Y"
        Me.AskBeforeDeletingLogs.ForeColor = System.Drawing.Color.Black
        Me.AskBeforeDeletingLogs.Location = New System.Drawing.Point(56, 21)
        Me.AskBeforeDeletingLogs.Name = "AskBeforeDeletingLogs"
        Me.AskBeforeDeletingLogs.Size = New System.Drawing.Size(430, 23)
        Me.AskBeforeDeletingLogs.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.AskBeforeDeletingLogs.TabIndex = 0
        Me.AskBeforeDeletingLogs.Text = "Ask before deleting logs"
        '
        'GroupBox8
        '
        Me.GroupBox8.Controls.Add(Me.AskBeforeModifyingInvoices)
        Me.GroupBox8.Controls.Add(Me.AskBeforeDeletingInvoices)
        Me.GroupBox8.ForeColor = System.Drawing.Color.Black
        Me.GroupBox8.Location = New System.Drawing.Point(18, 297)
        Me.GroupBox8.Name = "GroupBox8"
        Me.GroupBox8.Size = New System.Drawing.Size(541, 84)
        Me.GroupBox8.TabIndex = 5
        Me.GroupBox8.TabStop = False
        Me.GroupBox8.Text = "Invoices"
        '
        'AskBeforeModifyingInvoices
        '
        '
        '
        '
        Me.AskBeforeModifyingInvoices.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.AskBeforeModifyingInvoices.ForeColor = System.Drawing.Color.Black
        Me.AskBeforeModifyingInvoices.Location = New System.Drawing.Point(56, 50)
        Me.AskBeforeModifyingInvoices.Name = "AskBeforeModifyingInvoices"
        Me.AskBeforeModifyingInvoices.Size = New System.Drawing.Size(430, 23)
        Me.AskBeforeModifyingInvoices.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.AskBeforeModifyingInvoices.TabIndex = 1
        Me.AskBeforeModifyingInvoices.Text = "Ask before modifying invoices"
        '
        'AskBeforeDeletingInvoices
        '
        '
        '
        '
        Me.AskBeforeDeletingInvoices.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.AskBeforeDeletingInvoices.Checked = True
        Me.AskBeforeDeletingInvoices.CheckState = System.Windows.Forms.CheckState.Checked
        Me.AskBeforeDeletingInvoices.CheckValue = "Y"
        Me.AskBeforeDeletingInvoices.ForeColor = System.Drawing.Color.Black
        Me.AskBeforeDeletingInvoices.Location = New System.Drawing.Point(56, 21)
        Me.AskBeforeDeletingInvoices.Name = "AskBeforeDeletingInvoices"
        Me.AskBeforeDeletingInvoices.Size = New System.Drawing.Size(430, 23)
        Me.AskBeforeDeletingInvoices.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.AskBeforeDeletingInvoices.TabIndex = 0
        Me.AskBeforeDeletingInvoices.Text = "Ask before deleting invoices"
        '
        'GroupBox7
        '
        Me.GroupBox7.Controls.Add(Me.NotifyUpdate)
        Me.GroupBox7.ForeColor = System.Drawing.Color.Black
        Me.GroupBox7.Location = New System.Drawing.Point(18, 516)
        Me.GroupBox7.Name = "GroupBox7"
        Me.GroupBox7.Size = New System.Drawing.Size(541, 69)
        Me.GroupBox7.TabIndex = 4
        Me.GroupBox7.TabStop = False
        Me.GroupBox7.Text = "Update"
        '
        'NotifyUpdate
        '
        '
        '
        '
        Me.NotifyUpdate.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.NotifyUpdate.Checked = True
        Me.NotifyUpdate.CheckState = System.Windows.Forms.CheckState.Checked
        Me.NotifyUpdate.CheckValue = "Y"
        Me.NotifyUpdate.ForeColor = System.Drawing.Color.Black
        Me.NotifyUpdate.Location = New System.Drawing.Point(56, 25)
        Me.NotifyUpdate.Name = "NotifyUpdate"
        Me.NotifyUpdate.Size = New System.Drawing.Size(430, 23)
        Me.NotifyUpdate.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.NotifyUpdate.TabIndex = 1
        Me.NotifyUpdate.Text = "Notify when update is found"
        '
        'GroupBox6
        '
        Me.GroupBox6.Controls.Add(Me.AskBeforeModifyingContracts)
        Me.GroupBox6.Controls.Add(Me.AskBeforeDeletingContracts)
        Me.GroupBox6.ForeColor = System.Drawing.Color.Black
        Me.GroupBox6.Location = New System.Drawing.Point(18, 210)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Size = New System.Drawing.Size(541, 81)
        Me.GroupBox6.TabIndex = 3
        Me.GroupBox6.TabStop = False
        Me.GroupBox6.Text = "Contracts"
        '
        'AskBeforeModifyingContracts
        '
        '
        '
        '
        Me.AskBeforeModifyingContracts.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.AskBeforeModifyingContracts.ForeColor = System.Drawing.Color.Black
        Me.AskBeforeModifyingContracts.Location = New System.Drawing.Point(56, 50)
        Me.AskBeforeModifyingContracts.Name = "AskBeforeModifyingContracts"
        Me.AskBeforeModifyingContracts.Size = New System.Drawing.Size(430, 23)
        Me.AskBeforeModifyingContracts.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.AskBeforeModifyingContracts.TabIndex = 1
        Me.AskBeforeModifyingContracts.Text = "Ask before modifying contracts"
        '
        'AskBeforeDeletingContracts
        '
        '
        '
        '
        Me.AskBeforeDeletingContracts.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.AskBeforeDeletingContracts.Checked = True
        Me.AskBeforeDeletingContracts.CheckState = System.Windows.Forms.CheckState.Checked
        Me.AskBeforeDeletingContracts.CheckValue = "Y"
        Me.AskBeforeDeletingContracts.ForeColor = System.Drawing.Color.Black
        Me.AskBeforeDeletingContracts.Location = New System.Drawing.Point(56, 21)
        Me.AskBeforeDeletingContracts.Name = "AskBeforeDeletingContracts"
        Me.AskBeforeDeletingContracts.Size = New System.Drawing.Size(430, 23)
        Me.AskBeforeDeletingContracts.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.AskBeforeDeletingContracts.TabIndex = 0
        Me.AskBeforeDeletingContracts.Text = "Ask before deleting contracts"
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.AskBeforeModifyingAssets)
        Me.GroupBox5.Controls.Add(Me.AskBeforeDeletingAssets)
        Me.GroupBox5.ForeColor = System.Drawing.Color.Black
        Me.GroupBox5.Location = New System.Drawing.Point(18, 122)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(541, 82)
        Me.GroupBox5.TabIndex = 2
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "Assets"
        '
        'AskBeforeModifyingAssets
        '
        '
        '
        '
        Me.AskBeforeModifyingAssets.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.AskBeforeModifyingAssets.ForeColor = System.Drawing.Color.Black
        Me.AskBeforeModifyingAssets.Location = New System.Drawing.Point(56, 50)
        Me.AskBeforeModifyingAssets.Name = "AskBeforeModifyingAssets"
        Me.AskBeforeModifyingAssets.Size = New System.Drawing.Size(430, 23)
        Me.AskBeforeModifyingAssets.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.AskBeforeModifyingAssets.TabIndex = 1
        Me.AskBeforeModifyingAssets.Text = "Ask before modifying assets"
        '
        'AskBeforeDeletingAssets
        '
        '
        '
        '
        Me.AskBeforeDeletingAssets.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.AskBeforeDeletingAssets.ForeColor = System.Drawing.Color.Black
        Me.AskBeforeDeletingAssets.Location = New System.Drawing.Point(56, 21)
        Me.AskBeforeDeletingAssets.Name = "AskBeforeDeletingAssets"
        Me.AskBeforeDeletingAssets.Size = New System.Drawing.Size(430, 23)
        Me.AskBeforeDeletingAssets.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.AskBeforeDeletingAssets.TabIndex = 0
        Me.AskBeforeDeletingAssets.Text = "Ask before deleting assets"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.AskBeforeModifyingProperties)
        Me.GroupBox3.Controls.Add(Me.AskBeforeDeletingProperties)
        Me.GroupBox3.ForeColor = System.Drawing.Color.Black
        Me.GroupBox3.Location = New System.Drawing.Point(18, 30)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(541, 86)
        Me.GroupBox3.TabIndex = 1
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Properties"
        '
        'AskBeforeModifyingProperties
        '
        '
        '
        '
        Me.AskBeforeModifyingProperties.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.AskBeforeModifyingProperties.ForeColor = System.Drawing.Color.Black
        Me.AskBeforeModifyingProperties.Location = New System.Drawing.Point(56, 50)
        Me.AskBeforeModifyingProperties.Name = "AskBeforeModifyingProperties"
        Me.AskBeforeModifyingProperties.Size = New System.Drawing.Size(430, 23)
        Me.AskBeforeModifyingProperties.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.AskBeforeModifyingProperties.TabIndex = 1
        Me.AskBeforeModifyingProperties.Text = "Ask before modifying properties"
        '
        'AskBeforeDeletingProperties
        '
        '
        '
        '
        Me.AskBeforeDeletingProperties.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.AskBeforeDeletingProperties.Checked = True
        Me.AskBeforeDeletingProperties.CheckState = System.Windows.Forms.CheckState.Checked
        Me.AskBeforeDeletingProperties.CheckValue = "Y"
        Me.AskBeforeDeletingProperties.ForeColor = System.Drawing.Color.Black
        Me.AskBeforeDeletingProperties.Location = New System.Drawing.Point(56, 21)
        Me.AskBeforeDeletingProperties.Name = "AskBeforeDeletingProperties"
        Me.AskBeforeDeletingProperties.Size = New System.Drawing.Size(430, 23)
        Me.AskBeforeDeletingProperties.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.AskBeforeDeletingProperties.TabIndex = 0
        Me.AskBeforeDeletingProperties.Text = "Ask before deleting properties"
        '
        'FontsTab
        '
        Me.FontsTab.ForeColor = System.Drawing.Color.Black
        Me.FontsTab.Location = New System.Drawing.Point(4, 22)
        Me.FontsTab.Name = "FontsTab"
        Me.FontsTab.Size = New System.Drawing.Size(595, 674)
        Me.FontsTab.TabIndex = 4
        Me.FontsTab.Text = "Fonts"
        Me.FontsTab.UseVisualStyleBackColor = True
        '
        'DBPrefixesTab
        '
        Me.DBPrefixesTab.Controls.Add(Me.GroupBox4)
        Me.DBPrefixesTab.ForeColor = System.Drawing.Color.Black
        Me.DBPrefixesTab.Location = New System.Drawing.Point(4, 22)
        Me.DBPrefixesTab.Name = "DBPrefixesTab"
        Me.DBPrefixesTab.Padding = New System.Windows.Forms.Padding(3)
        Me.DBPrefixesTab.Size = New System.Drawing.Size(595, 674)
        Me.DBPrefixesTab.TabIndex = 1
        Me.DBPrefixesTab.Text = "Database"
        Me.DBPrefixesTab.UseVisualStyleBackColor = True
        '
        'GroupBox4
        '
        Me.GroupBox4.BackColor = System.Drawing.Color.White
        Me.GroupBox4.Controls.Add(Me.Label10)
        Me.GroupBox4.Controls.Add(Me.S_AccountsTable)
        Me.GroupBox4.Controls.Add(Me.Label24)
        Me.GroupBox4.Controls.Add(Me.S_MLogsTable)
        Me.GroupBox4.Controls.Add(Me.Label17)
        Me.GroupBox4.Controls.Add(Me.S_LandlinesTable)
        Me.GroupBox4.Controls.Add(Me.Label21)
        Me.GroupBox4.Controls.Add(Me.S_PicturesTable)
        Me.GroupBox4.Controls.Add(Me.Label22)
        Me.GroupBox4.Controls.Add(Me.S_LogsTable)
        Me.GroupBox4.Controls.Add(Me.Label23)
        Me.GroupBox4.Controls.Add(Me.S_TasksTable)
        Me.GroupBox4.Controls.Add(Me.Label20)
        Me.GroupBox4.Controls.Add(Me.S_ContactsTable)
        Me.GroupBox4.Controls.Add(Me.Label18)
        Me.GroupBox4.Controls.Add(Me.S_CarTable)
        Me.GroupBox4.Controls.Add(Me.Label19)
        Me.GroupBox4.Controls.Add(Me.S_DVRNVRTable)
        Me.GroupBox4.Controls.Add(Me.Label16)
        Me.GroupBox4.Controls.Add(Me.S_SkyTable)
        Me.GroupBox4.Controls.Add(Me.Label15)
        Me.GroupBox4.Controls.Add(Me.S_TVTable)
        Me.GroupBox4.Controls.Add(Me.Label14)
        Me.GroupBox4.Controls.Add(Me.S_PCTable)
        Me.GroupBox4.Controls.Add(Me.Label7)
        Me.GroupBox4.Controls.Add(Me.S_ApplianceTable)
        Me.GroupBox4.Controls.Add(Me.Label6)
        Me.GroupBox4.Controls.Add(Me.S_MobileTable)
        Me.GroupBox4.Controls.Add(Me.Label3)
        Me.GroupBox4.Controls.Add(Me.S_VoiceTable)
        Me.GroupBox4.Controls.Add(Me.Label2)
        Me.GroupBox4.Controls.Add(Me.S_DataTable)
        Me.GroupBox4.Controls.Add(Me.Label1)
        Me.GroupBox4.Controls.Add(Me.S_DocTable)
        Me.GroupBox4.Controls.Add(Me.DefaultSettings)
        Me.GroupBox4.Controls.Add(Me.ApplySettings)
        Me.GroupBox4.Controls.Add(Me.Label9)
        Me.GroupBox4.Controls.Add(Me.S_InvoicesTable)
        Me.GroupBox4.Controls.Add(Me.Label8)
        Me.GroupBox4.Controls.Add(Me.S_ContractsTable)
        Me.GroupBox4.Controls.Add(Me.Label4)
        Me.GroupBox4.Controls.Add(Me.S_PKEY)
        Me.GroupBox4.Controls.Add(Me.Label5)
        Me.GroupBox4.Controls.Add(Me.S_PropertiesTable)
        Me.GroupBox4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox4.ForeColor = System.Drawing.Color.Black
        Me.GroupBox4.Location = New System.Drawing.Point(3, 3)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(589, 668)
        Me.GroupBox4.TabIndex = 6
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Database Prefixes"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.White
        Me.Label10.ForeColor = System.Drawing.Color.Black
        Me.Label10.Location = New System.Drawing.Point(16, 317)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(86, 13)
        Me.Label10.TabIndex = 48
        Me.Label10.Text = "Accounts table:"
        '
        'S_AccountsTable
        '
        Me.S_AccountsTable.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.S_AccountsTable.BackColor = System.Drawing.Color.White
        Me.S_AccountsTable.ForeColor = System.Drawing.Color.Black
        Me.S_AccountsTable.Location = New System.Drawing.Point(152, 314)
        Me.S_AccountsTable.Name = "S_AccountsTable"
        Me.S_AccountsTable.Size = New System.Drawing.Size(426, 22)
        Me.S_AccountsTable.TabIndex = 49
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.BackColor = System.Drawing.Color.White
        Me.Label24.ForeColor = System.Drawing.Color.Black
        Me.Label24.Location = New System.Drawing.Point(16, 344)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(136, 13)
        Me.Label24.TabIndex = 46
        Me.Label24.Text = "Maintainence Logs table:"
        '
        'S_MLogsTable
        '
        Me.S_MLogsTable.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.S_MLogsTable.BackColor = System.Drawing.Color.White
        Me.S_MLogsTable.ForeColor = System.Drawing.Color.Black
        Me.S_MLogsTable.Location = New System.Drawing.Point(152, 341)
        Me.S_MLogsTable.Name = "S_MLogsTable"
        Me.S_MLogsTable.Size = New System.Drawing.Size(426, 22)
        Me.S_MLogsTable.TabIndex = 47
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.BackColor = System.Drawing.Color.White
        Me.Label17.ForeColor = System.Drawing.Color.Black
        Me.Label17.Location = New System.Drawing.Point(16, 290)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(88, 13)
        Me.Label17.TabIndex = 44
        Me.Label17.Text = "Landlines table:"
        '
        'S_LandlinesTable
        '
        Me.S_LandlinesTable.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.S_LandlinesTable.BackColor = System.Drawing.Color.White
        Me.S_LandlinesTable.ForeColor = System.Drawing.Color.Black
        Me.S_LandlinesTable.Location = New System.Drawing.Point(152, 287)
        Me.S_LandlinesTable.Name = "S_LandlinesTable"
        Me.S_LandlinesTable.Size = New System.Drawing.Size(426, 22)
        Me.S_LandlinesTable.TabIndex = 45
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.BackColor = System.Drawing.Color.White
        Me.Label21.ForeColor = System.Drawing.Color.Black
        Me.Label21.Location = New System.Drawing.Point(16, 263)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(79, 13)
        Me.Label21.TabIndex = 42
        Me.Label21.Text = "Pictures table:"
        '
        'S_PicturesTable
        '
        Me.S_PicturesTable.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.S_PicturesTable.BackColor = System.Drawing.Color.White
        Me.S_PicturesTable.ForeColor = System.Drawing.Color.Black
        Me.S_PicturesTable.Location = New System.Drawing.Point(152, 260)
        Me.S_PicturesTable.Name = "S_PicturesTable"
        Me.S_PicturesTable.Size = New System.Drawing.Size(426, 22)
        Me.S_PicturesTable.TabIndex = 43
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.BackColor = System.Drawing.Color.White
        Me.Label22.ForeColor = System.Drawing.Color.Black
        Me.Label22.Location = New System.Drawing.Point(16, 235)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(63, 13)
        Me.Label22.TabIndex = 40
        Me.Label22.Text = "Logs table:"
        '
        'S_LogsTable
        '
        Me.S_LogsTable.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.S_LogsTable.BackColor = System.Drawing.Color.White
        Me.S_LogsTable.ForeColor = System.Drawing.Color.Black
        Me.S_LogsTable.Location = New System.Drawing.Point(152, 232)
        Me.S_LogsTable.Name = "S_LogsTable"
        Me.S_LogsTable.Size = New System.Drawing.Size(426, 22)
        Me.S_LogsTable.TabIndex = 41
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.BackColor = System.Drawing.Color.White
        Me.Label23.ForeColor = System.Drawing.Color.Black
        Me.Label23.Location = New System.Drawing.Point(16, 208)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(66, 13)
        Me.Label23.TabIndex = 38
        Me.Label23.Text = "Tasks table:"
        '
        'S_TasksTable
        '
        Me.S_TasksTable.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.S_TasksTable.BackColor = System.Drawing.Color.White
        Me.S_TasksTable.ForeColor = System.Drawing.Color.Black
        Me.S_TasksTable.Location = New System.Drawing.Point(152, 205)
        Me.S_TasksTable.Name = "S_TasksTable"
        Me.S_TasksTable.Size = New System.Drawing.Size(426, 22)
        Me.S_TasksTable.TabIndex = 39
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.BackColor = System.Drawing.Color.White
        Me.Label20.ForeColor = System.Drawing.Color.Black
        Me.Label20.Location = New System.Drawing.Point(16, 179)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(84, 13)
        Me.Label20.TabIndex = 36
        Me.Label20.Text = "Contacts table:"
        '
        'S_ContactsTable
        '
        Me.S_ContactsTable.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.S_ContactsTable.BackColor = System.Drawing.Color.White
        Me.S_ContactsTable.ForeColor = System.Drawing.Color.Black
        Me.S_ContactsTable.Location = New System.Drawing.Point(152, 176)
        Me.S_ContactsTable.Name = "S_ContactsTable"
        Me.S_ContactsTable.Size = New System.Drawing.Size(426, 22)
        Me.S_ContactsTable.TabIndex = 37
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.BackColor = System.Drawing.Color.White
        Me.Label18.ForeColor = System.Drawing.Color.Black
        Me.Label18.Location = New System.Drawing.Point(16, 599)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(98, 13)
        Me.Label18.TabIndex = 33
        Me.Label18.Text = "Assets - Car table:"
        '
        'S_CarTable
        '
        Me.S_CarTable.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.S_CarTable.BackColor = System.Drawing.Color.White
        Me.S_CarTable.ForeColor = System.Drawing.Color.Black
        Me.S_CarTable.Location = New System.Drawing.Point(152, 596)
        Me.S_CarTable.Name = "S_CarTable"
        Me.S_CarTable.Size = New System.Drawing.Size(426, 22)
        Me.S_CarTable.TabIndex = 34
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.BackColor = System.Drawing.Color.White
        Me.Label19.ForeColor = System.Drawing.Color.Black
        Me.Label19.Location = New System.Drawing.Point(16, 571)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(129, 13)
        Me.Label19.TabIndex = 31
        Me.Label19.Text = "Assets - DVR/NVR table:"
        '
        'S_DVRNVRTable
        '
        Me.S_DVRNVRTable.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.S_DVRNVRTable.BackColor = System.Drawing.Color.White
        Me.S_DVRNVRTable.ForeColor = System.Drawing.Color.Black
        Me.S_DVRNVRTable.Location = New System.Drawing.Point(152, 568)
        Me.S_DVRNVRTable.Name = "S_DVRNVRTable"
        Me.S_DVRNVRTable.Size = New System.Drawing.Size(426, 22)
        Me.S_DVRNVRTable.TabIndex = 32
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.BackColor = System.Drawing.Color.White
        Me.Label16.ForeColor = System.Drawing.Color.Black
        Me.Label16.Location = New System.Drawing.Point(16, 542)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(98, 13)
        Me.Label16.TabIndex = 29
        Me.Label16.Text = "Assets - Sky table:"
        '
        'S_SkyTable
        '
        Me.S_SkyTable.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.S_SkyTable.BackColor = System.Drawing.Color.White
        Me.S_SkyTable.ForeColor = System.Drawing.Color.Black
        Me.S_SkyTable.Location = New System.Drawing.Point(152, 539)
        Me.S_SkyTable.Name = "S_SkyTable"
        Me.S_SkyTable.Size = New System.Drawing.Size(426, 22)
        Me.S_SkyTable.TabIndex = 30
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.BackColor = System.Drawing.Color.White
        Me.Label15.ForeColor = System.Drawing.Color.Black
        Me.Label15.Location = New System.Drawing.Point(16, 515)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(93, 13)
        Me.Label15.TabIndex = 27
        Me.Label15.Text = "Assets - TV table:"
        '
        'S_TVTable
        '
        Me.S_TVTable.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.S_TVTable.BackColor = System.Drawing.Color.White
        Me.S_TVTable.ForeColor = System.Drawing.Color.Black
        Me.S_TVTable.Location = New System.Drawing.Point(152, 512)
        Me.S_TVTable.Name = "S_TVTable"
        Me.S_TVTable.Size = New System.Drawing.Size(426, 22)
        Me.S_TVTable.TabIndex = 28
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.BackColor = System.Drawing.Color.White
        Me.Label14.ForeColor = System.Drawing.Color.Black
        Me.Label14.Location = New System.Drawing.Point(16, 487)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(94, 13)
        Me.Label14.TabIndex = 25
        Me.Label14.Text = "Assets - PC table:"
        '
        'S_PCTable
        '
        Me.S_PCTable.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.S_PCTable.BackColor = System.Drawing.Color.White
        Me.S_PCTable.ForeColor = System.Drawing.Color.Black
        Me.S_PCTable.Location = New System.Drawing.Point(152, 484)
        Me.S_PCTable.Name = "S_PCTable"
        Me.S_PCTable.Size = New System.Drawing.Size(426, 22)
        Me.S_PCTable.TabIndex = 26
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.White
        Me.Label7.ForeColor = System.Drawing.Color.Black
        Me.Label7.Location = New System.Drawing.Point(16, 459)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(132, 13)
        Me.Label7.TabIndex = 23
        Me.Label7.Text = "Assets - Appliance table:"
        '
        'S_ApplianceTable
        '
        Me.S_ApplianceTable.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.S_ApplianceTable.BackColor = System.Drawing.Color.White
        Me.S_ApplianceTable.ForeColor = System.Drawing.Color.Black
        Me.S_ApplianceTable.Location = New System.Drawing.Point(152, 456)
        Me.S_ApplianceTable.Name = "S_ApplianceTable"
        Me.S_ApplianceTable.Size = New System.Drawing.Size(426, 22)
        Me.S_ApplianceTable.TabIndex = 24
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.White
        Me.Label6.ForeColor = System.Drawing.Color.Black
        Me.Label6.Location = New System.Drawing.Point(16, 432)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(117, 13)
        Me.Label6.TabIndex = 21
        Me.Label6.Text = "Assets - Mobile table:"
        '
        'S_MobileTable
        '
        Me.S_MobileTable.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.S_MobileTable.BackColor = System.Drawing.Color.White
        Me.S_MobileTable.ForeColor = System.Drawing.Color.Black
        Me.S_MobileTable.Location = New System.Drawing.Point(152, 429)
        Me.S_MobileTable.Name = "S_MobileTable"
        Me.S_MobileTable.Size = New System.Drawing.Size(426, 22)
        Me.S_MobileTable.TabIndex = 22
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.White
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(16, 404)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(109, 13)
        Me.Label3.TabIndex = 19
        Me.Label3.Text = "Assets - Voice table:"
        '
        'S_VoiceTable
        '
        Me.S_VoiceTable.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.S_VoiceTable.BackColor = System.Drawing.Color.White
        Me.S_VoiceTable.ForeColor = System.Drawing.Color.Black
        Me.S_VoiceTable.Location = New System.Drawing.Point(152, 401)
        Me.S_VoiceTable.Name = "S_VoiceTable"
        Me.S_VoiceTable.Size = New System.Drawing.Size(426, 22)
        Me.S_VoiceTable.TabIndex = 20
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.White
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(16, 378)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(105, 13)
        Me.Label2.TabIndex = 17
        Me.Label2.Text = "Assets - Data table:"
        '
        'S_DataTable
        '
        Me.S_DataTable.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.S_DataTable.BackColor = System.Drawing.Color.White
        Me.S_DataTable.ForeColor = System.Drawing.Color.Black
        Me.S_DataTable.Location = New System.Drawing.Point(152, 375)
        Me.S_DataTable.Name = "S_DataTable"
        Me.S_DataTable.Size = New System.Drawing.Size(426, 22)
        Me.S_DataTable.TabIndex = 18
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.White
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(16, 152)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(97, 13)
        Me.Label1.TabIndex = 15
        Me.Label1.Text = "Documents table:"
        '
        'S_DocTable
        '
        Me.S_DocTable.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.S_DocTable.BackColor = System.Drawing.Color.White
        Me.S_DocTable.ForeColor = System.Drawing.Color.Black
        Me.S_DocTable.Location = New System.Drawing.Point(152, 149)
        Me.S_DocTable.Name = "S_DocTable"
        Me.S_DocTable.Size = New System.Drawing.Size(426, 22)
        Me.S_DocTable.TabIndex = 16
        '
        'DefaultSettings
        '
        Me.DefaultSettings.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DefaultSettings.BackColor = System.Drawing.Color.White
        Me.DefaultSettings.ForeColor = System.Drawing.Color.Black
        Me.DefaultSettings.Image = Global.PMD.My.Resources.Resources._1365117598_adept_update
        Me.DefaultSettings.Location = New System.Drawing.Point(423, 633)
        Me.DefaultSettings.Name = "DefaultSettings"
        Me.DefaultSettings.Size = New System.Drawing.Size(75, 23)
        Me.DefaultSettings.TabIndex = 14
        Me.DefaultSettings.Text = "Default"
        Me.DefaultSettings.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.DefaultSettings.UseVisualStyleBackColor = False
        '
        'ApplySettings
        '
        Me.ApplySettings.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ApplySettings.BackColor = System.Drawing.Color.White
        Me.ApplySettings.ForeColor = System.Drawing.Color.Black
        Me.ApplySettings.Image = Global.PMD.My.Resources.Resources._1364677427_tick
        Me.ApplySettings.Location = New System.Drawing.Point(504, 633)
        Me.ApplySettings.Name = "ApplySettings"
        Me.ApplySettings.Size = New System.Drawing.Size(75, 23)
        Me.ApplySettings.TabIndex = 4
        Me.ApplySettings.Text = "Apply"
        Me.ApplySettings.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.ApplySettings.UseVisualStyleBackColor = False
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.White
        Me.Label9.ForeColor = System.Drawing.Color.Black
        Me.Label9.Location = New System.Drawing.Point(16, 124)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(80, 13)
        Me.Label9.TabIndex = 10
        Me.Label9.Text = "Invoices table:"
        '
        'S_InvoicesTable
        '
        Me.S_InvoicesTable.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.S_InvoicesTable.BackColor = System.Drawing.Color.White
        Me.S_InvoicesTable.ForeColor = System.Drawing.Color.Black
        Me.S_InvoicesTable.Location = New System.Drawing.Point(152, 121)
        Me.S_InvoicesTable.Name = "S_InvoicesTable"
        Me.S_InvoicesTable.Size = New System.Drawing.Size(426, 22)
        Me.S_InvoicesTable.TabIndex = 11
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.White
        Me.Label8.ForeColor = System.Drawing.Color.Black
        Me.Label8.Location = New System.Drawing.Point(16, 97)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(88, 13)
        Me.Label8.TabIndex = 8
        Me.Label8.Text = "Contracts table:"
        '
        'S_ContractsTable
        '
        Me.S_ContractsTable.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.S_ContractsTable.BackColor = System.Drawing.Color.White
        Me.S_ContractsTable.ForeColor = System.Drawing.Color.Black
        Me.S_ContractsTable.Location = New System.Drawing.Point(152, 94)
        Me.S_ContractsTable.Name = "S_ContractsTable"
        Me.S_ContractsTable.Size = New System.Drawing.Size(426, 22)
        Me.S_ContractsTable.TabIndex = 9
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.White
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(16, 43)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(67, 13)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "Primary key:"
        '
        'S_PKEY
        '
        Me.S_PKEY.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.S_PKEY.BackColor = System.Drawing.Color.White
        Me.S_PKEY.ForeColor = System.Drawing.Color.Black
        Me.S_PKEY.Location = New System.Drawing.Point(152, 40)
        Me.S_PKEY.Name = "S_PKEY"
        Me.S_PKEY.Size = New System.Drawing.Size(426, 22)
        Me.S_PKEY.TabIndex = 1
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.White
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(16, 69)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(91, 13)
        Me.Label5.TabIndex = 2
        Me.Label5.Text = "Properties table:"
        '
        'S_PropertiesTable
        '
        Me.S_PropertiesTable.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.S_PropertiesTable.BackColor = System.Drawing.Color.White
        Me.S_PropertiesTable.ForeColor = System.Drawing.Color.Black
        Me.S_PropertiesTable.Location = New System.Drawing.Point(152, 66)
        Me.S_PropertiesTable.Name = "S_PropertiesTable"
        Me.S_PropertiesTable.Size = New System.Drawing.Size(426, 22)
        Me.S_PropertiesTable.TabIndex = 3
        '
        'SettingsForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(799, 700)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "SettingsForm"
        Me.Text = "Settings"
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        CType(Me.AdvTree1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SettingsTabControl.ResumeLayout(False)
        Me.MainTab.ResumeLayout(False)
        Me.MainTab.PerformLayout()
        Me.StartupTab.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.PromptsTab.ResumeLayout(False)
        Me.GroupBox10.ResumeLayout(False)
        Me.GroupBox9.ResumeLayout(False)
        Me.GroupBox8.ResumeLayout(False)
        Me.GroupBox7.ResumeLayout(False)
        Me.GroupBox6.ResumeLayout(False)
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.DBPrefixesTab.ResumeLayout(False)
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents AdvTree1 As DevComponents.AdvTree.AdvTree
    Friend WithEvents GeneralNode As DevComponents.AdvTree.Node
    Friend WithEvents NodeConnector1 As DevComponents.AdvTree.NodeConnector
    Friend WithEvents ElementStyle1 As DevComponents.DotNetBar.ElementStyle
    Friend WithEvents Node1 As DevComponents.AdvTree.Node
    Friend WithEvents Node2 As DevComponents.AdvTree.Node
    Friend WithEvents Node3 As DevComponents.AdvTree.Node
    Friend WithEvents DBNode As DevComponents.AdvTree.Node
    Friend WithEvents DBPrefixesNode As DevComponents.AdvTree.Node
    Friend WithEvents SettingsTabControl As System.Windows.Forms.TabControl
    Friend WithEvents MainTab As System.Windows.Forms.TabPage
    Friend WithEvents StartupTab As System.Windows.Forms.TabPage
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents TestLoginBtn As DevComponents.DotNetBar.ButtonX
    Friend WithEvents ShowPassCharsCheckbox As DevComponents.DotNetBar.Controls.CheckBoxX
    Friend WithEvents LabelX2 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX1 As DevComponents.DotNetBar.LabelX
    Friend WithEvents PasswordTextBox As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents UsernameTextBox As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents LaunchStartUpCheckBox As DevComponents.DotNetBar.Controls.CheckBoxX
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents HiddenRadioBtn As System.Windows.Forms.RadioButton
    Friend WithEvents NormalRadioBtn As System.Windows.Forms.RadioButton
    Friend WithEvents PromptsTab As System.Windows.Forms.TabPage
    Friend WithEvents GroupBox6 As System.Windows.Forms.GroupBox
    Friend WithEvents AskBeforeModifyingContracts As DevComponents.DotNetBar.Controls.CheckBoxX
    Friend WithEvents AskBeforeDeletingContracts As DevComponents.DotNetBar.Controls.CheckBoxX
    Friend WithEvents GroupBox5 As System.Windows.Forms.GroupBox
    Friend WithEvents AskBeforeModifyingAssets As DevComponents.DotNetBar.Controls.CheckBoxX
    Friend WithEvents AskBeforeDeletingAssets As DevComponents.DotNetBar.Controls.CheckBoxX
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents AskBeforeModifyingProperties As DevComponents.DotNetBar.Controls.CheckBoxX
    Friend WithEvents AskBeforeDeletingProperties As DevComponents.DotNetBar.Controls.CheckBoxX
    Friend WithEvents FontsTab As System.Windows.Forms.TabPage
    Friend WithEvents DBPrefixesTab As System.Windows.Forms.TabPage
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents Label24 As System.Windows.Forms.Label
    Friend WithEvents S_MLogsTable As System.Windows.Forms.TextBox
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents S_PicturesTable As System.Windows.Forms.TextBox
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents S_LogsTable As System.Windows.Forms.TextBox
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents S_TasksTable As System.Windows.Forms.TextBox
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents S_ContactsTable As System.Windows.Forms.TextBox
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents S_CarTable As System.Windows.Forms.TextBox
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents S_DVRNVRTable As System.Windows.Forms.TextBox
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents S_SkyTable As System.Windows.Forms.TextBox
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents S_TVTable As System.Windows.Forms.TextBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents S_PCTable As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents S_ApplianceTable As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents S_MobileTable As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents S_VoiceTable As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents S_DataTable As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents S_DocTable As System.Windows.Forms.TextBox
    Friend WithEvents DefaultSettings As System.Windows.Forms.Button
    Friend WithEvents ApplySettings As System.Windows.Forms.Button
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents S_InvoicesTable As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents S_ContractsTable As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents S_PKEY As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents S_PropertiesTable As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents S_AccountsTable As System.Windows.Forms.TextBox
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents S_LandlinesTable As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents AutoLoginCheckbox As DevComponents.DotNetBar.Controls.CheckBoxX
    Friend WithEvents GroupBox10 As System.Windows.Forms.GroupBox
    Friend WithEvents NotifyReminder As DevComponents.DotNetBar.Controls.CheckBoxX
    Friend WithEvents GroupBox9 As System.Windows.Forms.GroupBox
    Friend WithEvents AskBeforeDeletingLogs As DevComponents.DotNetBar.Controls.CheckBoxX
    Friend WithEvents GroupBox8 As System.Windows.Forms.GroupBox
    Friend WithEvents AskBeforeModifyingInvoices As DevComponents.DotNetBar.Controls.CheckBoxX
    Friend WithEvents AskBeforeDeletingInvoices As DevComponents.DotNetBar.Controls.CheckBoxX
    Friend WithEvents GroupBox7 As System.Windows.Forms.GroupBox
    Friend WithEvents NotifyUpdate As DevComponents.DotNetBar.Controls.CheckBoxX
    Friend WithEvents FontDialog1 As System.Windows.Forms.FontDialog
End Class
