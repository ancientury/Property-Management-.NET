<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ContractForm
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
        Dim DataGridViewCellStyle16 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle17 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle18 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.ContractFee = New PMD.CurrencyTextBox(Me.components)
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.EndDate = New System.Windows.Forms.DateTimePicker()
        Me.ContractLength = New System.Windows.Forms.ComboBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.PaymentMethod = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.AccountHolderAddress = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.AccountHolder = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.SecurityAnswer = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.AccountNumber = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.StartDate = New System.Windows.Forms.DateTimePicker()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Reminder_Box = New System.Windows.Forms.GroupBox()
        Me.ViewReminderBtn = New DevComponents.DotNetBar.ButtonX()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Reminder_Days = New System.Windows.Forms.TextBox()
        Me.Reminder_CheckBox = New System.Windows.Forms.CheckBox()
        Me.ContractCompany = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PaymentType = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TabControl = New System.Windows.Forms.TabControl()
        Me.MainTab = New System.Windows.Forms.TabPage()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.MobileTab = New System.Windows.Forms.TabPage()
        Me.Mobile_Plan = New System.Windows.Forms.TextBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Mobile_Number = New System.Windows.Forms.TextBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Mobile_Network = New System.Windows.Forms.ComboBox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.LandlineTab = New System.Windows.Forms.TabPage()
        Me.Landline_Number = New System.Windows.Forms.Label()
        Me.Landline_LinkBtn = New System.Windows.Forms.Button()
        Me.Landline_Provider = New System.Windows.Forms.ComboBox()
        Me.Landline_Service_Plan = New System.Windows.Forms.TextBox()
        Me.Label32 = New System.Windows.Forms.Label()
        Me.Label31 = New System.Windows.Forms.Label()
        Me.Label29 = New System.Windows.Forms.Label()
        Me.BroadbandTab = New System.Windows.Forms.TabPage()
        Me.Broadband_Provider = New System.Windows.Forms.ComboBox()
        Me.Broadband_Service_Plan = New System.Windows.Forms.TextBox()
        Me.Label33 = New System.Windows.Forms.Label()
        Me.Label35 = New System.Windows.Forms.Label()
        Me.Broadband_Landline_Contract = New System.Windows.Forms.Label()
        Me.Label37 = New System.Windows.Forms.Label()
        Me.LinkLandlineBtn = New System.Windows.Forms.Button()
        Me.ContractType = New System.Windows.Forms.ComboBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Header = New System.Windows.Forms.Label()
        Me.Log_Box = New System.Windows.Forms.GroupBox()
        Me.AddLogBtn = New DevComponents.DotNetBar.ButtonX()
        Me.DeleteLogBtn = New DevComponents.DotNetBar.ButtonX()
        Me.LogsGrid = New DevComponents.DotNetBar.Controls.DataGridViewX()
        Me.DeleteBtn = New System.Windows.Forms.Button()
        Me.OkBtn = New System.Windows.Forms.Button()
        Me.CancelBtn = New System.Windows.Forms.Button()
        Me.EditBtn = New System.Windows.Forms.Button()
        Me.ButtonItem1 = New DevComponents.DotNetBar.ButtonItem()
        Me.ButtonItem2 = New DevComponents.DotNetBar.ButtonItem()
        Me.GroupBox1.SuspendLayout()
        Me.Reminder_Box.SuspendLayout()
        Me.TabControl.SuspendLayout()
        Me.MainTab.SuspendLayout()
        Me.MobileTab.SuspendLayout()
        Me.LandlineTab.SuspendLayout()
        Me.BroadbandTab.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Log_Box.SuspendLayout()
        CType(Me.LogsGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.White
        Me.GroupBox1.Controls.Add(Me.ContractFee)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.EndDate)
        Me.GroupBox1.Controls.Add(Me.ContractLength)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.PaymentMethod)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.AccountHolderAddress)
        Me.GroupBox1.Controls.Add(Me.Label15)
        Me.GroupBox1.Controls.Add(Me.AccountHolder)
        Me.GroupBox1.Controls.Add(Me.Label14)
        Me.GroupBox1.Controls.Add(Me.SecurityAnswer)
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Controls.Add(Me.AccountNumber)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.StartDate)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Reminder_Box)
        Me.GroupBox1.Controls.Add(Me.ContractCompany)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.PaymentType)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.TabControl)
        Me.GroupBox1.Controls.Add(Me.ContractType)
        Me.GroupBox1.Controls.Add(Me.Label12)
        Me.GroupBox1.Controls.Add(Me.PictureBox1)
        Me.GroupBox1.Controls.Add(Me.Header)
        Me.GroupBox1.ForeColor = System.Drawing.Color.Black
        Me.GroupBox1.Location = New System.Drawing.Point(1, 2)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(829, 473)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Contract:"
        '
        'ContractFee
        '
        Me.ContractFee.BackColor = System.Drawing.Color.White
        Me.ContractFee.ForeColor = System.Drawing.Color.Black
        Me.ContractFee.Location = New System.Drawing.Point(102, 226)
        Me.ContractFee.Name = "ContractFee"
        Me.ContractFee.Size = New System.Drawing.Size(247, 20)
        Me.ContractFee.TabIndex = 101
        Me.ContractFee.Text = "£0.00"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.White
        Me.Label10.ForeColor = System.Drawing.Color.Black
        Me.Label10.Location = New System.Drawing.Point(194, 201)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(58, 13)
        Me.Label10.TabIndex = 99
        Me.Label10.Text = "Start Date:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.White
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(352, 201)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(55, 13)
        Me.Label4.TabIndex = 98
        Me.Label4.Text = "End Date:"
        '
        'EndDate
        '
        Me.EndDate.BackColor = System.Drawing.Color.White
        Me.EndDate.Enabled = False
        Me.EndDate.ForeColor = System.Drawing.Color.Black
        Me.EndDate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.EndDate.Location = New System.Drawing.Point(409, 199)
        Me.EndDate.MinDate = New Date(2000, 1, 1, 0, 0, 0, 0)
        Me.EndDate.Name = "EndDate"
        Me.EndDate.Size = New System.Drawing.Size(96, 20)
        Me.EndDate.TabIndex = 97
        Me.EndDate.Value = New Date(2013, 4, 7, 20, 37, 10, 0)
        '
        'ContractLength
        '
        Me.ContractLength.BackColor = System.Drawing.Color.White
        Me.ContractLength.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ContractLength.Enabled = False
        Me.ContractLength.ForeColor = System.Drawing.Color.Black
        Me.ContractLength.FormattingEnabled = True
        Me.ContractLength.Items.AddRange(New Object() {"Rolling", "3 Months", "6 Months", "12 Months", "18 Months", "24 Months", "Other"})
        Me.ContractLength.Location = New System.Drawing.Point(102, 197)
        Me.ContractLength.Name = "ContractLength"
        Me.ContractLength.Size = New System.Drawing.Size(90, 21)
        Me.ContractLength.TabIndex = 96
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.White
        Me.Label8.ForeColor = System.Drawing.Color.Black
        Me.Label8.Location = New System.Drawing.Point(5, 227)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(75, 13)
        Me.Label8.TabIndex = 94
        Me.Label8.Text = "Contract fee: *"
        '
        'PaymentMethod
        '
        Me.PaymentMethod.BackColor = System.Drawing.Color.White
        Me.PaymentMethod.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.PaymentMethod.Enabled = False
        Me.PaymentMethod.ForeColor = System.Drawing.Color.Black
        Me.PaymentMethod.FormattingEnabled = True
        Me.PaymentMethod.Items.AddRange(New Object() {"Monthly", "Quarterly", "Yearly"})
        Me.PaymentMethod.Location = New System.Drawing.Point(355, 225)
        Me.PaymentMethod.Name = "PaymentMethod"
        Me.PaymentMethod.Size = New System.Drawing.Size(150, 21)
        Me.PaymentMethod.TabIndex = 92
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.Color.White
        Me.Label6.ForeColor = System.Drawing.Color.Black
        Me.Label6.Location = New System.Drawing.Point(537, 303)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(265, 20)
        Me.Label6.TabIndex = 91
        Me.Label6.Text = "___________________________________________"
        '
        'AccountHolderAddress
        '
        Me.AccountHolderAddress.BackColor = System.Drawing.Color.White
        Me.AccountHolderAddress.ForeColor = System.Drawing.Color.Black
        Me.AccountHolderAddress.Location = New System.Drawing.Point(513, 215)
        Me.AccountHolderAddress.Multiline = True
        Me.AccountHolderAddress.Name = "AccountHolderAddress"
        Me.AccountHolderAddress.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.AccountHolderAddress.Size = New System.Drawing.Size(307, 84)
        Me.AccountHolderAddress.TabIndex = 90
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.BackColor = System.Drawing.Color.White
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.Color.Black
        Me.Label15.Location = New System.Drawing.Point(511, 195)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(122, 13)
        Me.Label15.TabIndex = 89
        Me.Label15.Text = "Account holder address:"
        '
        'AccountHolder
        '
        Me.AccountHolder.BackColor = System.Drawing.Color.White
        Me.AccountHolder.ForeColor = System.Drawing.Color.Black
        Me.AccountHolder.Location = New System.Drawing.Point(614, 163)
        Me.AccountHolder.Name = "AccountHolder"
        Me.AccountHolder.Size = New System.Drawing.Size(206, 20)
        Me.AccountHolder.TabIndex = 88
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.BackColor = System.Drawing.Color.White
        Me.Label14.ForeColor = System.Drawing.Color.Black
        Me.Label14.Location = New System.Drawing.Point(511, 163)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(82, 13)
        Me.Label14.TabIndex = 87
        Me.Label14.Text = "Account holder:"
        '
        'SecurityAnswer
        '
        Me.SecurityAnswer.BackColor = System.Drawing.Color.White
        Me.SecurityAnswer.ForeColor = System.Drawing.Color.Black
        Me.SecurityAnswer.Location = New System.Drawing.Point(614, 137)
        Me.SecurityAnswer.Name = "SecurityAnswer"
        Me.SecurityAnswer.Size = New System.Drawing.Size(206, 20)
        Me.SecurityAnswer.TabIndex = 86
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.Color.White
        Me.Label11.ForeColor = System.Drawing.Color.Black
        Me.Label11.Location = New System.Drawing.Point(511, 137)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(85, 13)
        Me.Label11.TabIndex = 85
        Me.Label11.Text = "Security answer:"
        '
        'AccountNumber
        '
        Me.AccountNumber.BackColor = System.Drawing.Color.White
        Me.AccountNumber.ForeColor = System.Drawing.Color.Black
        Me.AccountNumber.Location = New System.Drawing.Point(614, 109)
        Me.AccountNumber.Name = "AccountNumber"
        Me.AccountNumber.Size = New System.Drawing.Size(206, 20)
        Me.AccountNumber.TabIndex = 84
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.White
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(511, 108)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(88, 13)
        Me.Label2.TabIndex = 83
        Me.Label2.Text = "Account number:"
        '
        'StartDate
        '
        Me.StartDate.BackColor = System.Drawing.Color.White
        Me.StartDate.Enabled = False
        Me.StartDate.ForeColor = System.Drawing.Color.Black
        Me.StartDate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.StartDate.Location = New System.Drawing.Point(255, 198)
        Me.StartDate.MinDate = New Date(2000, 1, 1, 0, 0, 0, 0)
        Me.StartDate.Name = "StartDate"
        Me.StartDate.Size = New System.Drawing.Size(95, 20)
        Me.StartDate.TabIndex = 73
        Me.StartDate.Value = New Date(2013, 4, 7, 20, 37, 10, 0)
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.White
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(5, 199)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(89, 13)
        Me.Label3.TabIndex = 75
        Me.Label3.Text = "Contract period: *"
        '
        'Reminder_Box
        '
        Me.Reminder_Box.BackColor = System.Drawing.Color.White
        Me.Reminder_Box.Controls.Add(Me.ViewReminderBtn)
        Me.Reminder_Box.Controls.Add(Me.Label7)
        Me.Reminder_Box.Controls.Add(Me.Reminder_Days)
        Me.Reminder_Box.Controls.Add(Me.Reminder_CheckBox)
        Me.Reminder_Box.ForeColor = System.Drawing.Color.Black
        Me.Reminder_Box.Location = New System.Drawing.Point(514, 328)
        Me.Reminder_Box.Name = "Reminder_Box"
        Me.Reminder_Box.Size = New System.Drawing.Size(306, 129)
        Me.Reminder_Box.TabIndex = 72
        Me.Reminder_Box.TabStop = False
        Me.Reminder_Box.Text = "Reminder:"
        '
        'ViewReminderBtn
        '
        Me.ViewReminderBtn.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.ViewReminderBtn.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.ViewReminderBtn.Enabled = False
        Me.ViewReminderBtn.Image = Global.PMD.My.Resources.Resources._1366156689_stock_new_24h_appointment
        Me.ViewReminderBtn.Location = New System.Drawing.Point(177, 94)
        Me.ViewReminderBtn.Name = "ViewReminderBtn"
        Me.ViewReminderBtn.Size = New System.Drawing.Size(122, 26)
        Me.ViewReminderBtn.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.ViewReminderBtn.TabIndex = 169
        Me.ViewReminderBtn.Text = "View Reminder"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.White
        Me.Label7.ForeColor = System.Drawing.Color.Black
        Me.Label7.Location = New System.Drawing.Point(150, 59)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(37, 13)
        Me.Label7.TabIndex = 82
        Me.Label7.Text = "Day(s)"
        '
        'Reminder_Days
        '
        Me.Reminder_Days.BackColor = System.Drawing.Color.White
        Me.Reminder_Days.ForeColor = System.Drawing.Color.Black
        Me.Reminder_Days.Location = New System.Drawing.Point(100, 56)
        Me.Reminder_Days.Name = "Reminder_Days"
        Me.Reminder_Days.Size = New System.Drawing.Size(44, 20)
        Me.Reminder_Days.TabIndex = 81
        Me.Reminder_Days.Text = "1"
        '
        'Reminder_CheckBox
        '
        Me.Reminder_CheckBox.AutoSize = True
        Me.Reminder_CheckBox.BackColor = System.Drawing.Color.White
        Me.Reminder_CheckBox.ForeColor = System.Drawing.Color.Black
        Me.Reminder_CheckBox.Location = New System.Drawing.Point(29, 32)
        Me.Reminder_CheckBox.Name = "Reminder_CheckBox"
        Me.Reminder_CheckBox.Size = New System.Drawing.Size(207, 17)
        Me.Reminder_CheckBox.TabIndex = 0
        Me.Reminder_CheckBox.Text = "Remind me before contract expires by:"
        Me.Reminder_CheckBox.UseVisualStyleBackColor = False
        '
        'ContractCompany
        '
        Me.ContractCompany.BackColor = System.Drawing.Color.White
        Me.ContractCompany.ForeColor = System.Drawing.Color.Black
        Me.ContractCompany.Location = New System.Drawing.Point(102, 135)
        Me.ContractCompany.Name = "ContractCompany"
        Me.ContractCompany.Size = New System.Drawing.Size(403, 20)
        Me.ContractCompany.TabIndex = 63
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.White
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(5, 138)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(90, 13)
        Me.Label1.TabIndex = 62
        Me.Label1.Text = "Company name: *"
        '
        'PaymentType
        '
        Me.PaymentType.BackColor = System.Drawing.Color.White
        Me.PaymentType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.PaymentType.Enabled = False
        Me.PaymentType.ForeColor = System.Drawing.Color.Black
        Me.PaymentType.FormattingEnabled = True
        Me.PaymentType.Items.AddRange(New Object() {"Direct Debit", "Standing Order", "Cheque"})
        Me.PaymentType.Location = New System.Drawing.Point(102, 166)
        Me.PaymentType.Name = "PaymentType"
        Me.PaymentType.Size = New System.Drawing.Size(403, 21)
        Me.PaymentType.TabIndex = 50
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.White
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(5, 169)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(96, 13)
        Me.Label5.TabIndex = 54
        Me.Label5.Text = "Payment method: *"
        '
        'TabControl
        '
        Me.TabControl.Controls.Add(Me.MainTab)
        Me.TabControl.Controls.Add(Me.MobileTab)
        Me.TabControl.Controls.Add(Me.LandlineTab)
        Me.TabControl.Controls.Add(Me.BroadbandTab)
        Me.TabControl.ForeColor = System.Drawing.Color.Black
        Me.TabControl.Location = New System.Drawing.Point(8, 251)
        Me.TabControl.Name = "TabControl"
        Me.TabControl.SelectedIndex = 0
        Me.TabControl.Size = New System.Drawing.Size(497, 207)
        Me.TabControl.TabIndex = 35
        '
        'MainTab
        '
        Me.MainTab.Controls.Add(Me.Label13)
        Me.MainTab.ForeColor = System.Drawing.Color.Black
        Me.MainTab.Location = New System.Drawing.Point(4, 22)
        Me.MainTab.Name = "MainTab"
        Me.MainTab.Padding = New System.Windows.Forms.Padding(3)
        Me.MainTab.Size = New System.Drawing.Size(489, 181)
        Me.MainTab.TabIndex = 0
        Me.MainTab.Text = "Select contract type:"
        Me.MainTab.UseVisualStyleBackColor = True
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!)
        Me.Label13.ForeColor = System.Drawing.Color.Black
        Me.Label13.Location = New System.Drawing.Point(148, 74)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(183, 18)
        Me.Label13.TabIndex = 0
        Me.Label13.Text = "Select the type of contract."
        '
        'MobileTab
        '
        Me.MobileTab.Controls.Add(Me.Mobile_Plan)
        Me.MobileTab.Controls.Add(Me.Label17)
        Me.MobileTab.Controls.Add(Me.Mobile_Number)
        Me.MobileTab.Controls.Add(Me.Label16)
        Me.MobileTab.Controls.Add(Me.Mobile_Network)
        Me.MobileTab.Controls.Add(Me.Label18)
        Me.MobileTab.ForeColor = System.Drawing.Color.Black
        Me.MobileTab.Location = New System.Drawing.Point(4, 22)
        Me.MobileTab.Name = "MobileTab"
        Me.MobileTab.Padding = New System.Windows.Forms.Padding(3)
        Me.MobileTab.Size = New System.Drawing.Size(489, 181)
        Me.MobileTab.TabIndex = 1
        Me.MobileTab.Text = "Mobile Contract"
        Me.MobileTab.UseVisualStyleBackColor = True
        '
        'Mobile_Plan
        '
        Me.Mobile_Plan.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Mobile_Plan.BackColor = System.Drawing.Color.White
        Me.Mobile_Plan.ForeColor = System.Drawing.Color.Black
        Me.Mobile_Plan.Location = New System.Drawing.Point(246, 68)
        Me.Mobile_Plan.Multiline = True
        Me.Mobile_Plan.Name = "Mobile_Plan"
        Me.Mobile_Plan.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.Mobile_Plan.Size = New System.Drawing.Size(240, 105)
        Me.Mobile_Plan.TabIndex = 50
        '
        'Label17
        '
        Me.Label17.BackColor = System.Drawing.Color.White
        Me.Label17.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label17.ForeColor = System.Drawing.Color.Black
        Me.Label17.Location = New System.Drawing.Point(6, 70)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(223, 20)
        Me.Label17.TabIndex = 51
        Me.Label17.Text = "Service plan:"
        '
        'Mobile_Number
        '
        Me.Mobile_Number.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Mobile_Number.BackColor = System.Drawing.Color.White
        Me.Mobile_Number.ForeColor = System.Drawing.Color.Black
        Me.Mobile_Number.Location = New System.Drawing.Point(246, 41)
        Me.Mobile_Number.Name = "Mobile_Number"
        Me.Mobile_Number.Size = New System.Drawing.Size(240, 20)
        Me.Mobile_Number.TabIndex = 48
        '
        'Label16
        '
        Me.Label16.BackColor = System.Drawing.Color.White
        Me.Label16.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label16.ForeColor = System.Drawing.Color.Black
        Me.Label16.Location = New System.Drawing.Point(6, 43)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(223, 20)
        Me.Label16.TabIndex = 49
        Me.Label16.Text = "Mobile number:"
        '
        'Mobile_Network
        '
        Me.Mobile_Network.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Mobile_Network.BackColor = System.Drawing.Color.White
        Me.Mobile_Network.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Mobile_Network.ForeColor = System.Drawing.Color.Black
        Me.Mobile_Network.FormattingEnabled = True
        Me.Mobile_Network.Items.AddRange(New Object() {"Three", "O2", "Orange", "T-Mobile", "EE (Orange/T-Mobile)", "Vodafone"})
        Me.Mobile_Network.Location = New System.Drawing.Point(246, 13)
        Me.Mobile_Network.Name = "Mobile_Network"
        Me.Mobile_Network.Size = New System.Drawing.Size(240, 21)
        Me.Mobile_Network.TabIndex = 47
        '
        'Label18
        '
        Me.Label18.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label18.ForeColor = System.Drawing.Color.Black
        Me.Label18.Location = New System.Drawing.Point(6, 13)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(223, 23)
        Me.Label18.TabIndex = 46
        Me.Label18.Text = "Service provider"
        Me.Label18.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'LandlineTab
        '
        Me.LandlineTab.Controls.Add(Me.Landline_Number)
        Me.LandlineTab.Controls.Add(Me.Landline_LinkBtn)
        Me.LandlineTab.Controls.Add(Me.Landline_Provider)
        Me.LandlineTab.Controls.Add(Me.Landline_Service_Plan)
        Me.LandlineTab.Controls.Add(Me.Label32)
        Me.LandlineTab.Controls.Add(Me.Label31)
        Me.LandlineTab.Controls.Add(Me.Label29)
        Me.LandlineTab.ForeColor = System.Drawing.Color.Black
        Me.LandlineTab.Location = New System.Drawing.Point(4, 22)
        Me.LandlineTab.Name = "LandlineTab"
        Me.LandlineTab.Padding = New System.Windows.Forms.Padding(3)
        Me.LandlineTab.Size = New System.Drawing.Size(489, 181)
        Me.LandlineTab.TabIndex = 2
        Me.LandlineTab.Text = "Landline Contract"
        Me.LandlineTab.UseVisualStyleBackColor = True
        '
        'Landline_Number
        '
        Me.Landline_Number.ForeColor = System.Drawing.Color.Black
        Me.Landline_Number.Location = New System.Drawing.Point(245, 13)
        Me.Landline_Number.Name = "Landline_Number"
        Me.Landline_Number.Size = New System.Drawing.Size(145, 18)
        Me.Landline_Number.TabIndex = 71
        Me.Landline_Number.Text = "None."
        '
        'Landline_LinkBtn
        '
        Me.Landline_LinkBtn.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Landline_LinkBtn.ForeColor = System.Drawing.Color.Black
        Me.Landline_LinkBtn.Location = New System.Drawing.Point(396, 11)
        Me.Landline_LinkBtn.Name = "Landline_LinkBtn"
        Me.Landline_LinkBtn.Size = New System.Drawing.Size(91, 23)
        Me.Landline_LinkBtn.TabIndex = 70
        Me.Landline_LinkBtn.Text = "Link Landline"
        Me.Landline_LinkBtn.UseVisualStyleBackColor = True
        '
        'Landline_Provider
        '
        Me.Landline_Provider.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Landline_Provider.BackColor = System.Drawing.Color.White
        Me.Landline_Provider.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Landline_Provider.ForeColor = System.Drawing.Color.Black
        Me.Landline_Provider.FormattingEnabled = True
        Me.Landline_Provider.Items.AddRange(New Object() {"AOL", "Auracall", "BE broadband", "BT Business phone", "Direct Save Telecom", "BT", "Madasafish", "O2", "Orange", "The Phone Co-op", "Plusnet", "Post Office", "Primus Business", "Primus Saver", "Sky Talk", "TalkTalk", "Tesco", "Virgin Media", "Virgin Media National Broadband", "Vonage", "YourCalls.net"})
        Me.Landline_Provider.Location = New System.Drawing.Point(247, 41)
        Me.Landline_Provider.Name = "Landline_Provider"
        Me.Landline_Provider.Size = New System.Drawing.Size(239, 21)
        Me.Landline_Provider.TabIndex = 68
        '
        'Landline_Service_Plan
        '
        Me.Landline_Service_Plan.BackColor = System.Drawing.Color.White
        Me.Landline_Service_Plan.ForeColor = System.Drawing.Color.Black
        Me.Landline_Service_Plan.Location = New System.Drawing.Point(247, 67)
        Me.Landline_Service_Plan.Multiline = True
        Me.Landline_Service_Plan.Name = "Landline_Service_Plan"
        Me.Landline_Service_Plan.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.Landline_Service_Plan.Size = New System.Drawing.Size(239, 106)
        Me.Landline_Service_Plan.TabIndex = 65
        '
        'Label32
        '
        Me.Label32.BackColor = System.Drawing.Color.White
        Me.Label32.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label32.ForeColor = System.Drawing.Color.Black
        Me.Label32.Location = New System.Drawing.Point(6, 69)
        Me.Label32.Name = "Label32"
        Me.Label32.Size = New System.Drawing.Size(223, 20)
        Me.Label32.TabIndex = 66
        Me.Label32.Text = "Service plan:"
        '
        'Label31
        '
        Me.Label31.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label31.ForeColor = System.Drawing.Color.Black
        Me.Label31.Location = New System.Drawing.Point(6, 41)
        Me.Label31.Name = "Label31"
        Me.Label31.Size = New System.Drawing.Size(223, 20)
        Me.Label31.TabIndex = 63
        Me.Label31.Text = "Service provider:"
        Me.Label31.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label29
        '
        Me.Label29.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label29.ForeColor = System.Drawing.Color.Black
        Me.Label29.Location = New System.Drawing.Point(6, 13)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(223, 20)
        Me.Label29.TabIndex = 60
        Me.Label29.Text = "Landline:"
        Me.Label29.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'BroadbandTab
        '
        Me.BroadbandTab.Controls.Add(Me.Broadband_Provider)
        Me.BroadbandTab.Controls.Add(Me.Broadband_Service_Plan)
        Me.BroadbandTab.Controls.Add(Me.Label33)
        Me.BroadbandTab.Controls.Add(Me.Label35)
        Me.BroadbandTab.Controls.Add(Me.Broadband_Landline_Contract)
        Me.BroadbandTab.Controls.Add(Me.Label37)
        Me.BroadbandTab.Controls.Add(Me.LinkLandlineBtn)
        Me.BroadbandTab.ForeColor = System.Drawing.Color.Black
        Me.BroadbandTab.Location = New System.Drawing.Point(4, 22)
        Me.BroadbandTab.Name = "BroadbandTab"
        Me.BroadbandTab.Padding = New System.Windows.Forms.Padding(3)
        Me.BroadbandTab.Size = New System.Drawing.Size(489, 181)
        Me.BroadbandTab.TabIndex = 3
        Me.BroadbandTab.Text = "Broadband"
        Me.BroadbandTab.UseVisualStyleBackColor = True
        '
        'Broadband_Provider
        '
        Me.Broadband_Provider.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Broadband_Provider.BackColor = System.Drawing.Color.White
        Me.Broadband_Provider.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Broadband_Provider.ForeColor = System.Drawing.Color.Black
        Me.Broadband_Provider.FormattingEnabled = True
        Me.Broadband_Provider.Items.AddRange(New Object() {"AOL", "BE", "BT", "O2", "Orange", "Plusnet", "Sky", "TalkTalk", "Three", "Virgin Media"})
        Me.Broadband_Provider.Location = New System.Drawing.Point(249, 40)
        Me.Broadband_Provider.Name = "Broadband_Provider"
        Me.Broadband_Provider.Size = New System.Drawing.Size(237, 21)
        Me.Broadband_Provider.TabIndex = 75
        '
        'Broadband_Service_Plan
        '
        Me.Broadband_Service_Plan.BackColor = System.Drawing.Color.White
        Me.Broadband_Service_Plan.ForeColor = System.Drawing.Color.Black
        Me.Broadband_Service_Plan.Location = New System.Drawing.Point(249, 67)
        Me.Broadband_Service_Plan.Multiline = True
        Me.Broadband_Service_Plan.Name = "Broadband_Service_Plan"
        Me.Broadband_Service_Plan.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.Broadband_Service_Plan.Size = New System.Drawing.Size(236, 103)
        Me.Broadband_Service_Plan.TabIndex = 73
        '
        'Label33
        '
        Me.Label33.BackColor = System.Drawing.Color.White
        Me.Label33.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label33.ForeColor = System.Drawing.Color.Black
        Me.Label33.Location = New System.Drawing.Point(6, 69)
        Me.Label33.Name = "Label33"
        Me.Label33.Size = New System.Drawing.Size(223, 20)
        Me.Label33.TabIndex = 74
        Me.Label33.Text = "Service plan:"
        '
        'Label35
        '
        Me.Label35.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label35.ForeColor = System.Drawing.Color.Black
        Me.Label35.Location = New System.Drawing.Point(6, 41)
        Me.Label35.Name = "Label35"
        Me.Label35.Size = New System.Drawing.Size(223, 20)
        Me.Label35.TabIndex = 71
        Me.Label35.Text = "Service provider:"
        Me.Label35.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Broadband_Landline_Contract
        '
        Me.Broadband_Landline_Contract.ForeColor = System.Drawing.Color.Black
        Me.Broadband_Landline_Contract.Location = New System.Drawing.Point(246, 13)
        Me.Broadband_Landline_Contract.Name = "Broadband_Landline_Contract"
        Me.Broadband_Landline_Contract.Size = New System.Drawing.Size(142, 18)
        Me.Broadband_Landline_Contract.TabIndex = 69
        Me.Broadband_Landline_Contract.Text = "None."
        '
        'Label37
        '
        Me.Label37.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label37.ForeColor = System.Drawing.Color.Black
        Me.Label37.Location = New System.Drawing.Point(6, 13)
        Me.Label37.Name = "Label37"
        Me.Label37.Size = New System.Drawing.Size(223, 20)
        Me.Label37.TabIndex = 68
        Me.Label37.Text = "Landline:"
        Me.Label37.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'LinkLandlineBtn
        '
        Me.LinkLandlineBtn.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LinkLandlineBtn.ForeColor = System.Drawing.Color.Black
        Me.LinkLandlineBtn.Location = New System.Drawing.Point(396, 10)
        Me.LinkLandlineBtn.Name = "LinkLandlineBtn"
        Me.LinkLandlineBtn.Size = New System.Drawing.Size(91, 23)
        Me.LinkLandlineBtn.TabIndex = 67
        Me.LinkLandlineBtn.Text = "Link Landline"
        Me.LinkLandlineBtn.UseVisualStyleBackColor = True
        '
        'ContractType
        '
        Me.ContractType.BackColor = System.Drawing.Color.White
        Me.ContractType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ContractType.ForeColor = System.Drawing.Color.Black
        Me.ContractType.FormattingEnabled = True
        Me.ContractType.Items.AddRange(New Object() {"Mobile", "Landline", "Broadband", "Water", "Gas", "Electricity", "Council Tax", "Service Charge", "Building Insurance", "Car Insurance", "TV License", "TV Package ", "Maintenance Contract"})
        Me.ContractType.Location = New System.Drawing.Point(102, 106)
        Me.ContractType.Name = "ContractType"
        Me.ContractType.Size = New System.Drawing.Size(403, 21)
        Me.ContractType.TabIndex = 32
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.BackColor = System.Drawing.Color.White
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.Black
        Me.Label12.Location = New System.Drawing.Point(5, 108)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(95, 13)
        Me.Label12.TabIndex = 33
        Me.Label12.Text = "Type of contract: *"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.White
        Me.PictureBox1.ForeColor = System.Drawing.Color.Black
        Me.PictureBox1.Image = Global.PMD.My.Resources.Resources._1371058447_drawing_pen
        Me.PictureBox1.Location = New System.Drawing.Point(11, 26)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(64, 64)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox1.TabIndex = 28
        Me.PictureBox1.TabStop = False
        '
        'Header
        '
        Me.Header.BackColor = System.Drawing.Color.White
        Me.Header.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Header.Font = New System.Drawing.Font("Tahoma", 8.0!)
        Me.Header.ForeColor = System.Drawing.Color.Black
        Me.Header.Location = New System.Drawing.Point(8, 23)
        Me.Header.Name = "Header"
        Me.Header.Padding = New System.Windows.Forms.Padding(100, 0, 0, 0)
        Me.Header.Size = New System.Drawing.Size(812, 68)
        Me.Header.TabIndex = 23
        Me.Header.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Log_Box
        '
        Me.Log_Box.BackColor = System.Drawing.Color.White
        Me.Log_Box.Controls.Add(Me.AddLogBtn)
        Me.Log_Box.Controls.Add(Me.DeleteLogBtn)
        Me.Log_Box.Controls.Add(Me.LogsGrid)
        Me.Log_Box.ForeColor = System.Drawing.Color.Black
        Me.Log_Box.Location = New System.Drawing.Point(1, 481)
        Me.Log_Box.Name = "Log_Box"
        Me.Log_Box.Size = New System.Drawing.Size(829, 238)
        Me.Log_Box.TabIndex = 36
        Me.Log_Box.TabStop = False
        Me.Log_Box.Text = "Log:"
        '
        'AddLogBtn
        '
        Me.AddLogBtn.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.AddLogBtn.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.AddLogBtn.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.AddLogBtn.Image = Global.PMD.My.Resources.Resources._1364676805_plus_161
        Me.AddLogBtn.Location = New System.Drawing.Point(702, 205)
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
        Me.DeleteLogBtn.Location = New System.Drawing.Point(572, 205)
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
        Me.LogsGrid.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LogsGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.LogsGrid.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells
        Me.LogsGrid.BackgroundColor = System.Drawing.Color.White
        Me.LogsGrid.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.LogsGrid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised
        DataGridViewCellStyle16.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle16.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle16.SelectionForeColor = System.Drawing.Color.Black
        Me.LogsGrid.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle16
        Me.LogsGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle17.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle17.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle17.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle17.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle17.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle17.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle17.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.LogsGrid.DefaultCellStyle = DataGridViewCellStyle17
        Me.LogsGrid.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.LogsGrid.EnableHeadersVisualStyles = False
        Me.LogsGrid.GridColor = System.Drawing.Color.FromArgb(CType(CType(170, Byte), Integer), CType(CType(170, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.LogsGrid.Location = New System.Drawing.Point(6, 18)
        Me.LogsGrid.MultiSelect = False
        Me.LogsGrid.Name = "LogsGrid"
        Me.LogsGrid.ReadOnly = True
        DataGridViewCellStyle18.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle18.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle18.SelectionForeColor = System.Drawing.Color.Black
        Me.LogsGrid.RowHeadersDefaultCellStyle = DataGridViewCellStyle18
        Me.LogsGrid.RowHeadersVisible = False
        Me.LogsGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.LogsGrid.Size = New System.Drawing.Size(819, 182)
        Me.LogsGrid.TabIndex = 64
        Me.LogsGrid.TabStop = False
        '
        'DeleteBtn
        '
        Me.DeleteBtn.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DeleteBtn.BackColor = System.Drawing.Color.White
        Me.DeleteBtn.ForeColor = System.Drawing.Color.Black
        Me.DeleteBtn.Image = Global.PMD.My.Resources.Resources._1364511183_dialog_close
        Me.DeleteBtn.Location = New System.Drawing.Point(435, 723)
        Me.DeleteBtn.Name = "DeleteBtn"
        Me.DeleteBtn.Size = New System.Drawing.Size(137, 27)
        Me.DeleteBtn.TabIndex = 37
        Me.DeleteBtn.Text = "Delete Contract"
        Me.DeleteBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.DeleteBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.DeleteBtn.UseVisualStyleBackColor = False
        Me.DeleteBtn.Visible = False
        '
        'OkBtn
        '
        Me.OkBtn.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.OkBtn.BackColor = System.Drawing.Color.White
        Me.OkBtn.ForeColor = System.Drawing.Color.Black
        Me.OkBtn.Image = Global.PMD.My.Resources.Resources._1364677427_tick
        Me.OkBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.OkBtn.Location = New System.Drawing.Point(708, 723)
        Me.OkBtn.Name = "OkBtn"
        Me.OkBtn.Size = New System.Drawing.Size(122, 27)
        Me.OkBtn.TabIndex = 14
        Me.OkBtn.Text = "OK"
        Me.OkBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.OkBtn.UseVisualStyleBackColor = False
        '
        'CancelBtn
        '
        Me.CancelBtn.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CancelBtn.BackColor = System.Drawing.Color.White
        Me.CancelBtn.ForeColor = System.Drawing.Color.Black
        Me.CancelBtn.Image = Global.PMD.My.Resources.Resources._1364511183_dialog_close
        Me.CancelBtn.Location = New System.Drawing.Point(578, 723)
        Me.CancelBtn.Name = "CancelBtn"
        Me.CancelBtn.Size = New System.Drawing.Size(122, 27)
        Me.CancelBtn.TabIndex = 29
        Me.CancelBtn.Text = "Cancel"
        Me.CancelBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.CancelBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.CancelBtn.UseVisualStyleBackColor = False
        Me.CancelBtn.Visible = False
        '
        'EditBtn
        '
        Me.EditBtn.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.EditBtn.BackColor = System.Drawing.Color.White
        Me.EditBtn.ForeColor = System.Drawing.Color.Black
        Me.EditBtn.Image = Global.PMD.My.Resources.Resources._1364946094_pencil_16
        Me.EditBtn.Location = New System.Drawing.Point(579, 723)
        Me.EditBtn.Name = "EditBtn"
        Me.EditBtn.Size = New System.Drawing.Size(122, 27)
        Me.EditBtn.TabIndex = 27
        Me.EditBtn.Text = "Edit"
        Me.EditBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.EditBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.EditBtn.UseVisualStyleBackColor = False
        '
        'ButtonItem1
        '
        Me.ButtonItem1.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText
        Me.ButtonItem1.Image = Global.PMD.My.Resources.Resources._1364676805_plus_16
        Me.ButtonItem1.Name = "ButtonItem1"
        Me.ButtonItem1.SubItemsExpandWidth = 14
        Me.ButtonItem1.Text = "Add Reminder"
        '
        'ButtonItem2
        '
        Me.ButtonItem2.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText
        Me.ButtonItem2.Image = Global.PMD.My.Resources.Resources._1364676805_plus_16
        Me.ButtonItem2.Name = "ButtonItem2"
        Me.ButtonItem2.SubItemsExpandWidth = 14
        Me.ButtonItem2.Text = "Add Reminder"
        '
        'ContractForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(831, 754)
        Me.Controls.Add(Me.DeleteBtn)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.OkBtn)
        Me.Controls.Add(Me.CancelBtn)
        Me.Controls.Add(Me.EditBtn)
        Me.Controls.Add(Me.Log_Box)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "ContractForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "New Contract - "
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.Reminder_Box.ResumeLayout(False)
        Me.Reminder_Box.PerformLayout()
        Me.TabControl.ResumeLayout(False)
        Me.MainTab.ResumeLayout(False)
        Me.MainTab.PerformLayout()
        Me.MobileTab.ResumeLayout(False)
        Me.MobileTab.PerformLayout()
        Me.LandlineTab.ResumeLayout(False)
        Me.LandlineTab.PerformLayout()
        Me.BroadbandTab.ResumeLayout(False)
        Me.BroadbandTab.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Log_Box.ResumeLayout(False)
        CType(Me.LogsGrid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents OkBtn As System.Windows.Forms.Button
    Friend WithEvents EditBtn As System.Windows.Forms.Button
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Header As System.Windows.Forms.Label
    Friend WithEvents CancelBtn As System.Windows.Forms.Button
    Friend WithEvents TabControl As System.Windows.Forms.TabControl
    Friend WithEvents MainTab As System.Windows.Forms.TabPage
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents MobileTab As System.Windows.Forms.TabPage
    Friend WithEvents ContractType As System.Windows.Forms.ComboBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents Mobile_Plan As System.Windows.Forms.TextBox
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents Mobile_Number As System.Windows.Forms.TextBox
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Mobile_Network As System.Windows.Forms.ComboBox
    Friend WithEvents LandlineTab As System.Windows.Forms.TabPage
    Friend WithEvents Label29 As System.Windows.Forms.Label
    Friend WithEvents Landline_Service_Plan As System.Windows.Forms.TextBox
    Friend WithEvents Label32 As System.Windows.Forms.Label
    Friend WithEvents Label31 As System.Windows.Forms.Label
    Friend WithEvents BroadbandTab As System.Windows.Forms.TabPage
    Friend WithEvents Broadband_Service_Plan As System.Windows.Forms.TextBox
    Friend WithEvents Label33 As System.Windows.Forms.Label
    Friend WithEvents Label35 As System.Windows.Forms.Label
    Friend WithEvents Broadband_Landline_Contract As System.Windows.Forms.Label
    Friend WithEvents Label37 As System.Windows.Forms.Label
    Friend WithEvents LinkLandlineBtn As System.Windows.Forms.Button
    Friend WithEvents Log_Box As System.Windows.Forms.GroupBox
    Friend WithEvents LogsGrid As DevComponents.DotNetBar.Controls.DataGridViewX
    Friend WithEvents PaymentType As System.Windows.Forms.ComboBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents AddLogBtn As DevComponents.DotNetBar.ButtonX
    Friend WithEvents DeleteLogBtn As DevComponents.DotNetBar.ButtonX
    Friend WithEvents ButtonItem1 As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents ButtonItem2 As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents ContractCompany As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents StartDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Reminder_Box As System.Windows.Forms.GroupBox
    Friend WithEvents Landline_Provider As System.Windows.Forms.ComboBox
    Friend WithEvents Broadband_Provider As System.Windows.Forms.ComboBox
    Friend WithEvents DeleteBtn As System.Windows.Forms.Button
    Friend WithEvents AccountHolderAddress As System.Windows.Forms.TextBox
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents AccountHolder As System.Windows.Forms.TextBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents SecurityAnswer As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents AccountNumber As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Reminder_Days As System.Windows.Forms.TextBox
    Friend WithEvents Reminder_CheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents Landline_Number As System.Windows.Forms.Label
    Friend WithEvents Landline_LinkBtn As System.Windows.Forms.Button
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents ViewReminderBtn As DevComponents.DotNetBar.ButtonX
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents EndDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents ContractLength As System.Windows.Forms.ComboBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents PaymentMethod As System.Windows.Forms.ComboBox
    Friend WithEvents ContractFee As PMD.CurrencyTextBox
End Class
