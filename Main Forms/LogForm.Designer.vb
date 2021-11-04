<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class LogForm
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.TabControl = New System.Windows.Forms.TabControl()
        Me.MainTab = New System.Windows.Forms.TabPage()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.EmailTab = New System.Windows.Forms.TabPage()
        Me.EmailTo = New System.Windows.Forms.TextBox()
        Me.EmailFrom = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.PhoneTab = New System.Windows.Forms.TabPage()
        Me.VoicemailFrom = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.VoicemailTo = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.CallTo = New System.Windows.Forms.TextBox()
        Me.CallFrom = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.TimeStamp = New System.Windows.Forms.DateTimePicker()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.LogType = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Username = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Header = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Comment = New System.Windows.Forms.TextBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.DismissTaskBtn = New DevComponents.DotNetBar.ButtonX()
        Me.ViewTaskBtn = New DevComponents.DotNetBar.ButtonX()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.TaskNote = New System.Windows.Forms.TextBox()
        Me.TaskStatus = New System.Windows.Forms.Label()
        Me.TaskDueDate = New System.Windows.Forms.Label()
        Me.TaskImportance = New System.Windows.Forms.Label()
        Me.CreateTaskBtn = New DevComponents.DotNetBar.ButtonX()
        Me.TaskID = New System.Windows.Forms.Label()
        Me.TaskName = New System.Windows.Forms.Label()
        Me.CancelBtn = New System.Windows.Forms.Button()
        Me.DeleteBtn = New System.Windows.Forms.Button()
        Me.OkBtn = New System.Windows.Forms.Button()
        Me.EditBtn = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.GroupBox1.SuspendLayout()
        Me.TabControl.SuspendLayout()
        Me.MainTab.SuspendLayout()
        Me.EmailTab.SuspendLayout()
        Me.PhoneTab.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.White
        Me.GroupBox1.Controls.Add(Me.TabControl)
        Me.GroupBox1.Controls.Add(Me.TimeStamp)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.LogType)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Username)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.ForeColor = System.Drawing.Color.Black
        Me.GroupBox1.Location = New System.Drawing.Point(12, 69)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(452, 316)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Log:"
        '
        'TabControl
        '
        Me.TabControl.Controls.Add(Me.MainTab)
        Me.TabControl.Controls.Add(Me.EmailTab)
        Me.TabControl.Controls.Add(Me.PhoneTab)
        Me.TabControl.ForeColor = System.Drawing.Color.Black
        Me.TabControl.Location = New System.Drawing.Point(9, 106)
        Me.TabControl.Name = "TabControl"
        Me.TabControl.SelectedIndex = 0
        Me.TabControl.Size = New System.Drawing.Size(435, 201)
        Me.TabControl.TabIndex = 36
        '
        'MainTab
        '
        Me.MainTab.Controls.Add(Me.Label13)
        Me.MainTab.ForeColor = System.Drawing.Color.Black
        Me.MainTab.Location = New System.Drawing.Point(4, 22)
        Me.MainTab.Name = "MainTab"
        Me.MainTab.Padding = New System.Windows.Forms.Padding(3)
        Me.MainTab.Size = New System.Drawing.Size(427, 175)
        Me.MainTab.TabIndex = 0
        Me.MainTab.Text = "Select log type:"
        Me.MainTab.UseVisualStyleBackColor = True
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!)
        Me.Label13.ForeColor = System.Drawing.Color.Black
        Me.Label13.Location = New System.Drawing.Point(142, 63)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(149, 18)
        Me.Label13.TabIndex = 0
        Me.Label13.Text = "Select the type of log."
        '
        'EmailTab
        '
        Me.EmailTab.Controls.Add(Me.EmailTo)
        Me.EmailTab.Controls.Add(Me.EmailFrom)
        Me.EmailTab.Controls.Add(Me.Label7)
        Me.EmailTab.Controls.Add(Me.Label6)
        Me.EmailTab.ForeColor = System.Drawing.Color.Black
        Me.EmailTab.Location = New System.Drawing.Point(4, 22)
        Me.EmailTab.Name = "EmailTab"
        Me.EmailTab.Padding = New System.Windows.Forms.Padding(3)
        Me.EmailTab.Size = New System.Drawing.Size(427, 175)
        Me.EmailTab.TabIndex = 1
        Me.EmailTab.Text = "Email"
        Me.EmailTab.UseVisualStyleBackColor = True
        '
        'EmailTo
        '
        Me.EmailTo.BackColor = System.Drawing.Color.White
        Me.EmailTo.ForeColor = System.Drawing.Color.Black
        Me.EmailTo.Location = New System.Drawing.Point(124, 46)
        Me.EmailTo.Name = "EmailTo"
        Me.EmailTo.Size = New System.Drawing.Size(297, 22)
        Me.EmailTo.TabIndex = 3
        '
        'EmailFrom
        '
        Me.EmailFrom.BackColor = System.Drawing.Color.White
        Me.EmailFrom.ForeColor = System.Drawing.Color.Black
        Me.EmailFrom.Location = New System.Drawing.Point(124, 74)
        Me.EmailFrom.Name = "EmailFrom"
        Me.EmailFrom.Size = New System.Drawing.Size(297, 22)
        Me.EmailFrom.TabIndex = 2
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.ForeColor = System.Drawing.Color.Black
        Me.Label7.Location = New System.Drawing.Point(6, 49)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(77, 13)
        Me.Label7.TabIndex = 1
        Me.Label7.Text = "Sent email to:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.ForeColor = System.Drawing.Color.Black
        Me.Label6.Location = New System.Drawing.Point(6, 77)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(112, 13)
        Me.Label6.TabIndex = 0
        Me.Label6.Text = "Recieved email from:"
        '
        'PhoneTab
        '
        Me.PhoneTab.Controls.Add(Me.VoicemailFrom)
        Me.PhoneTab.Controls.Add(Me.Label15)
        Me.PhoneTab.Controls.Add(Me.VoicemailTo)
        Me.PhoneTab.Controls.Add(Me.Label11)
        Me.PhoneTab.Controls.Add(Me.CallTo)
        Me.PhoneTab.Controls.Add(Me.CallFrom)
        Me.PhoneTab.Controls.Add(Me.Label8)
        Me.PhoneTab.Controls.Add(Me.Label9)
        Me.PhoneTab.ForeColor = System.Drawing.Color.Black
        Me.PhoneTab.Location = New System.Drawing.Point(4, 22)
        Me.PhoneTab.Name = "PhoneTab"
        Me.PhoneTab.Padding = New System.Windows.Forms.Padding(3)
        Me.PhoneTab.Size = New System.Drawing.Size(427, 175)
        Me.PhoneTab.TabIndex = 2
        Me.PhoneTab.Text = "Phone Call"
        Me.PhoneTab.UseVisualStyleBackColor = True
        '
        'VoicemailFrom
        '
        Me.VoicemailFrom.BackColor = System.Drawing.Color.White
        Me.VoicemailFrom.ForeColor = System.Drawing.Color.Black
        Me.VoicemailFrom.Location = New System.Drawing.Point(124, 117)
        Me.VoicemailFrom.Name = "VoicemailFrom"
        Me.VoicemailFrom.Size = New System.Drawing.Size(297, 22)
        Me.VoicemailFrom.TabIndex = 11
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.ForeColor = System.Drawing.Color.Black
        Me.Label15.Location = New System.Drawing.Point(6, 120)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(86, 13)
        Me.Label15.TabIndex = 10
        Me.Label15.Text = "Voicemail from:"
        '
        'VoicemailTo
        '
        Me.VoicemailTo.BackColor = System.Drawing.Color.White
        Me.VoicemailTo.ForeColor = System.Drawing.Color.Black
        Me.VoicemailTo.Location = New System.Drawing.Point(124, 89)
        Me.VoicemailTo.Name = "VoicemailTo"
        Me.VoicemailTo.Size = New System.Drawing.Size(297, 22)
        Me.VoicemailTo.TabIndex = 9
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.ForeColor = System.Drawing.Color.Black
        Me.Label11.Location = New System.Drawing.Point(6, 92)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(73, 13)
        Me.Label11.TabIndex = 8
        Me.Label11.Text = "Voicemail to:"
        '
        'CallTo
        '
        Me.CallTo.BackColor = System.Drawing.Color.White
        Me.CallTo.ForeColor = System.Drawing.Color.Black
        Me.CallTo.Location = New System.Drawing.Point(124, 33)
        Me.CallTo.Name = "CallTo"
        Me.CallTo.Size = New System.Drawing.Size(297, 22)
        Me.CallTo.TabIndex = 7
        '
        'CallFrom
        '
        Me.CallFrom.BackColor = System.Drawing.Color.White
        Me.CallFrom.ForeColor = System.Drawing.Color.Black
        Me.CallFrom.Location = New System.Drawing.Point(124, 61)
        Me.CallFrom.Name = "CallFrom"
        Me.CallFrom.Size = New System.Drawing.Size(297, 22)
        Me.CallFrom.TabIndex = 6
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.ForeColor = System.Drawing.Color.Black
        Me.Label8.Location = New System.Drawing.Point(6, 36)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(77, 13)
        Me.Label8.TabIndex = 5
        Me.Label8.Text = "Phone call to:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.ForeColor = System.Drawing.Color.Black
        Me.Label9.Location = New System.Drawing.Point(6, 64)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(102, 13)
        Me.Label9.TabIndex = 4
        Me.Label9.Text = "Recieved call from:"
        '
        'TimeStamp
        '
        Me.TimeStamp.BackColor = System.Drawing.Color.White
        Me.TimeStamp.CustomFormat = "dd/MM/yyyy HH:mm:ss"
        Me.TimeStamp.Enabled = False
        Me.TimeStamp.ForeColor = System.Drawing.Color.Black
        Me.TimeStamp.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.TimeStamp.Location = New System.Drawing.Point(223, 78)
        Me.TimeStamp.Name = "TimeStamp"
        Me.TimeStamp.Size = New System.Drawing.Size(221, 22)
        Me.TimeStamp.TabIndex = 6
        Me.TimeStamp.TabStop = False
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.White
        Me.Label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(8, 78)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(208, 22)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Time Stamp:"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'LogType
        '
        Me.LogType.BackColor = System.Drawing.Color.White
        Me.LogType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.LogType.ForeColor = System.Drawing.Color.Black
        Me.LogType.FormattingEnabled = True
        Me.LogType.Items.AddRange(New Object() {"Email", "Phone Call"})
        Me.LogType.Location = New System.Drawing.Point(223, 21)
        Me.LogType.Name = "LogType"
        Me.LogType.Size = New System.Drawing.Size(222, 21)
        Me.LogType.TabIndex = 4
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.White
        Me.Label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(9, 22)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(208, 20)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Log Type:"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Username
        '
        Me.Username.BackColor = System.Drawing.Color.White
        Me.Username.Enabled = False
        Me.Username.ForeColor = System.Drawing.Color.Black
        Me.Username.Location = New System.Drawing.Point(223, 50)
        Me.Username.Name = "Username"
        Me.Username.ReadOnly = True
        Me.Username.Size = New System.Drawing.Size(221, 22)
        Me.Username.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.White
        Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(8, 50)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(208, 22)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Username:"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Header
        '
        Me.Header.BackColor = System.Drawing.Color.White
        Me.Header.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Header.Font = New System.Drawing.Font("Tahoma", 8.0!)
        Me.Header.ForeColor = System.Drawing.Color.Black
        Me.Header.Location = New System.Drawing.Point(12, 9)
        Me.Header.Name = "Header"
        Me.Header.Padding = New System.Windows.Forms.Padding(150, 0, 0, 0)
        Me.Header.Size = New System.Drawing.Size(774, 57)
        Me.Header.TabIndex = 29
        Me.Header.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.Color.White
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(87, 22)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(229, 37)
        Me.Label5.TabIndex = 31
        Me.Label5.Text = "Enter the information below for the log you wish to create."
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.White
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(12, 388)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(59, 13)
        Me.Label4.TabIndex = 40
        Me.Label4.Text = "Comment:"
        '
        'Comment
        '
        Me.Comment.BackColor = System.Drawing.Color.White
        Me.Comment.ForeColor = System.Drawing.Color.Black
        Me.Comment.Location = New System.Drawing.Point(14, 407)
        Me.Comment.Multiline = True
        Me.Comment.Name = "Comment"
        Me.Comment.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.Comment.Size = New System.Drawing.Size(774, 238)
        Me.Comment.TabIndex = 39
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.White
        Me.GroupBox2.Controls.Add(Me.DismissTaskBtn)
        Me.GroupBox2.Controls.Add(Me.ViewTaskBtn)
        Me.GroupBox2.Controls.Add(Me.Label14)
        Me.GroupBox2.Controls.Add(Me.TaskNote)
        Me.GroupBox2.Controls.Add(Me.TaskStatus)
        Me.GroupBox2.Controls.Add(Me.TaskDueDate)
        Me.GroupBox2.Controls.Add(Me.TaskImportance)
        Me.GroupBox2.Controls.Add(Me.CreateTaskBtn)
        Me.GroupBox2.Controls.Add(Me.TaskID)
        Me.GroupBox2.Controls.Add(Me.TaskName)
        Me.GroupBox2.ForeColor = System.Drawing.Color.Black
        Me.GroupBox2.Location = New System.Drawing.Point(469, 70)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(317, 315)
        Me.GroupBox2.TabIndex = 61
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Task:"
        '
        'DismissTaskBtn
        '
        Me.DismissTaskBtn.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.DismissTaskBtn.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DismissTaskBtn.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.DismissTaskBtn.Enabled = False
        Me.DismissTaskBtn.Image = Global.PMD.My.Resources.Resources._1364677462_1011
        Me.DismissTaskBtn.Location = New System.Drawing.Point(12, 286)
        Me.DismissTaskBtn.Name = "DismissTaskBtn"
        Me.DismissTaskBtn.Size = New System.Drawing.Size(102, 23)
        Me.DismissTaskBtn.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.DismissTaskBtn.TabIndex = 176
        Me.DismissTaskBtn.Text = "Dismiss Task"
        '
        'ViewTaskBtn
        '
        Me.ViewTaskBtn.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.ViewTaskBtn.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ViewTaskBtn.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.ViewTaskBtn.Enabled = False
        Me.ViewTaskBtn.Image = Global.PMD.My.Resources.Resources._1366156689_stock_new_24h_appointment
        Me.ViewTaskBtn.Location = New System.Drawing.Point(119, 286)
        Me.ViewTaskBtn.Name = "ViewTaskBtn"
        Me.ViewTaskBtn.Size = New System.Drawing.Size(91, 23)
        Me.ViewTaskBtn.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.ViewTaskBtn.TabIndex = 175
        Me.ViewTaskBtn.Text = "View Task"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.BackColor = System.Drawing.Color.White
        Me.Label14.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.Color.Black
        Me.Label14.Location = New System.Drawing.Point(11, 144)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(36, 15)
        Me.Label14.TabIndex = 174
        Me.Label14.Text = "Note:"
        '
        'TaskNote
        '
        Me.TaskNote.BackColor = System.Drawing.Color.White
        Me.TaskNote.ForeColor = System.Drawing.Color.Black
        Me.TaskNote.Location = New System.Drawing.Point(11, 164)
        Me.TaskNote.Multiline = True
        Me.TaskNote.Name = "TaskNote"
        Me.TaskNote.ReadOnly = True
        Me.TaskNote.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.TaskNote.Size = New System.Drawing.Size(296, 116)
        Me.TaskNote.TabIndex = 173
        '
        'TaskStatus
        '
        Me.TaskStatus.AutoSize = True
        Me.TaskStatus.BackColor = System.Drawing.Color.White
        Me.TaskStatus.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TaskStatus.ForeColor = System.Drawing.Color.Black
        Me.TaskStatus.Location = New System.Drawing.Point(11, 96)
        Me.TaskStatus.Name = "TaskStatus"
        Me.TaskStatus.Size = New System.Drawing.Size(67, 15)
        Me.TaskStatus.TabIndex = 172
        Me.TaskStatus.Text = "Status: N/A"
        '
        'TaskDueDate
        '
        Me.TaskDueDate.AutoSize = True
        Me.TaskDueDate.BackColor = System.Drawing.Color.White
        Me.TaskDueDate.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TaskDueDate.ForeColor = System.Drawing.Color.Black
        Me.TaskDueDate.Location = New System.Drawing.Point(11, 120)
        Me.TaskDueDate.Name = "TaskDueDate"
        Me.TaskDueDate.Size = New System.Drawing.Size(56, 15)
        Me.TaskDueDate.TabIndex = 171
        Me.TaskDueDate.Text = "Due: N/A"
        '
        'TaskImportance
        '
        Me.TaskImportance.AutoSize = True
        Me.TaskImportance.BackColor = System.Drawing.Color.White
        Me.TaskImportance.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TaskImportance.ForeColor = System.Drawing.Color.Black
        Me.TaskImportance.Location = New System.Drawing.Point(11, 72)
        Me.TaskImportance.Name = "TaskImportance"
        Me.TaskImportance.Size = New System.Drawing.Size(96, 15)
        Me.TaskImportance.TabIndex = 170
        Me.TaskImportance.Text = "Importance: N/A"
        '
        'CreateTaskBtn
        '
        Me.CreateTaskBtn.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.CreateTaskBtn.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CreateTaskBtn.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.CreateTaskBtn.Image = Global.PMD.My.Resources.Resources._1364676805_plus_16
        Me.CreateTaskBtn.Location = New System.Drawing.Point(215, 286)
        Me.CreateTaskBtn.Name = "CreateTaskBtn"
        Me.CreateTaskBtn.Size = New System.Drawing.Size(92, 23)
        Me.CreateTaskBtn.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.CreateTaskBtn.TabIndex = 169
        Me.CreateTaskBtn.Text = "Create Task"
        '
        'TaskID
        '
        Me.TaskID.AutoSize = True
        Me.TaskID.BackColor = System.Drawing.Color.White
        Me.TaskID.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TaskID.ForeColor = System.Drawing.Color.Black
        Me.TaskID.Location = New System.Drawing.Point(11, 25)
        Me.TaskID.Name = "TaskID"
        Me.TaskID.Size = New System.Drawing.Size(73, 15)
        Me.TaskID.TabIndex = 1
        Me.TaskID.Text = "Task ID: N/A"
        '
        'TaskName
        '
        Me.TaskName.AutoSize = True
        Me.TaskName.BackColor = System.Drawing.Color.White
        Me.TaskName.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TaskName.ForeColor = System.Drawing.Color.Black
        Me.TaskName.Location = New System.Drawing.Point(11, 49)
        Me.TaskName.Name = "TaskName"
        Me.TaskName.Size = New System.Drawing.Size(67, 15)
        Me.TaskName.TabIndex = 0
        Me.TaskName.Text = "Name: N/A"
        '
        'CancelBtn
        '
        Me.CancelBtn.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CancelBtn.BackColor = System.Drawing.Color.White
        Me.CancelBtn.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.CancelBtn.ForeColor = System.Drawing.Color.Black
        Me.CancelBtn.Image = Global.PMD.My.Resources.Resources._1364511183_dialog_close
        Me.CancelBtn.Location = New System.Drawing.Point(536, 655)
        Me.CancelBtn.Name = "CancelBtn"
        Me.CancelBtn.Size = New System.Drawing.Size(122, 26)
        Me.CancelBtn.TabIndex = 43
        Me.CancelBtn.Text = "Cancel"
        Me.CancelBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.CancelBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.CancelBtn.UseVisualStyleBackColor = False
        Me.CancelBtn.Visible = False
        '
        'DeleteBtn
        '
        Me.DeleteBtn.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DeleteBtn.BackColor = System.Drawing.Color.White
        Me.DeleteBtn.ForeColor = System.Drawing.Color.Black
        Me.DeleteBtn.Image = Global.PMD.My.Resources.Resources._1364511183_dialog_close
        Me.DeleteBtn.Location = New System.Drawing.Point(393, 654)
        Me.DeleteBtn.Name = "DeleteBtn"
        Me.DeleteBtn.Size = New System.Drawing.Size(137, 27)
        Me.DeleteBtn.TabIndex = 62
        Me.DeleteBtn.Text = "Delete Log"
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
        Me.OkBtn.Location = New System.Drawing.Point(666, 654)
        Me.OkBtn.Name = "OkBtn"
        Me.OkBtn.Size = New System.Drawing.Size(122, 26)
        Me.OkBtn.TabIndex = 41
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
        Me.EditBtn.Location = New System.Drawing.Point(536, 654)
        Me.EditBtn.Name = "EditBtn"
        Me.EditBtn.Size = New System.Drawing.Size(122, 26)
        Me.EditBtn.TabIndex = 42
        Me.EditBtn.Text = "Edit"
        Me.EditBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.EditBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.EditBtn.UseVisualStyleBackColor = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.White
        Me.PictureBox1.ForeColor = System.Drawing.Color.Black
        Me.PictureBox1.Image = Global.PMD.My.Resources.Resources._1368217289_book
        Me.PictureBox1.Location = New System.Drawing.Point(21, 14)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(48, 49)
        Me.PictureBox1.TabIndex = 30
        Me.PictureBox1.TabStop = False
        '
        'LogForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.CancelBtn
        Me.ClientSize = New System.Drawing.Size(793, 689)
        Me.Controls.Add(Me.DeleteBtn)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.OkBtn)
        Me.Controls.Add(Me.CancelBtn)
        Me.Controls.Add(Me.EditBtn)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Comment)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Header)
        Me.Controls.Add(Me.GroupBox1)
        Me.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "LogForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "New Log"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.TabControl.ResumeLayout(False)
        Me.MainTab.ResumeLayout(False)
        Me.MainTab.PerformLayout()
        Me.EmailTab.ResumeLayout(False)
        Me.EmailTab.PerformLayout()
        Me.PhoneTab.ResumeLayout(False)
        Me.PhoneTab.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Username As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Header As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents TimeStamp As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents LogType As System.Windows.Forms.ComboBox
    Friend WithEvents TabControl As System.Windows.Forms.TabControl
    Friend WithEvents MainTab As System.Windows.Forms.TabPage
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Comment As System.Windows.Forms.TextBox
    Friend WithEvents OkBtn As System.Windows.Forms.Button
    Friend WithEvents CancelBtn As System.Windows.Forms.Button
    Friend WithEvents EditBtn As System.Windows.Forms.Button
    Friend WithEvents EmailTab As System.Windows.Forms.TabPage
    Friend WithEvents PhoneTab As System.Windows.Forms.TabPage
    Friend WithEvents EmailTo As System.Windows.Forms.TextBox
    Friend WithEvents EmailFrom As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents CallTo As System.Windows.Forms.TextBox
    Friend WithEvents CallFrom As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents VoicemailTo As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents VoicemailFrom As System.Windows.Forms.TextBox
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents CreateTaskBtn As DevComponents.DotNetBar.ButtonX
    Friend WithEvents TaskID As System.Windows.Forms.Label
    Friend WithEvents TaskName As System.Windows.Forms.Label
    Friend WithEvents TaskStatus As System.Windows.Forms.Label
    Friend WithEvents TaskDueDate As System.Windows.Forms.Label
    Friend WithEvents TaskImportance As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents TaskNote As System.Windows.Forms.TextBox
    Friend WithEvents ViewTaskBtn As DevComponents.DotNetBar.ButtonX
    Friend WithEvents DeleteBtn As System.Windows.Forms.Button
    Friend WithEvents DismissTaskBtn As DevComponents.DotNetBar.ButtonX
End Class
