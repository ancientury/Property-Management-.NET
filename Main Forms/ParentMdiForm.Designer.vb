<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ParentMdiForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ParentMdiForm))
        Me.MetroBar = New DevComponents.DotNetBar.Metro.MetroStatusBar()
        Me.Status = New DevComponents.DotNetBar.LabelItem()
        Me.progressBar = New DevComponents.DotNetBar.ProgressBarItem()
        Me.StyleManager1 = New DevComponents.DotNetBar.StyleManager(Me.components)
        Me.MdiPanel = New DevComponents.DotNetBar.RibbonBar()
        Me.ManageBtn = New DevComponents.DotNetBar.ButtonItem()
        Me.AccountsBtn = New DevComponents.DotNetBar.ButtonItem()
        Me.SearchBtn = New DevComponents.DotNetBar.ButtonItem()
        Me.RemindersBtn = New DevComponents.DotNetBar.ButtonItem()
        Me.SettingsBtn = New DevComponents.DotNetBar.ButtonItem()
        Me.AccManagementBtn = New DevComponents.DotNetBar.ButtonItem()
        Me.UpdateBtn = New DevComponents.DotNetBar.ButtonItem()
        Me.LogOutBtn = New DevComponents.DotNetBar.ButtonItem()
        Me.ExitBtn = New DevComponents.DotNetBar.ButtonItem()
        Me.SysTrayIcon = New System.Windows.Forms.NotifyIcon(Me.components)
        Me.SysTrayMenu = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ShowToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ShowTasksStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.LogOutToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ReconnectTimer = New System.Windows.Forms.Timer(Me.components)
        Me.MainMenu = New System.Windows.Forms.MenuStrip()
        Me.SysTrayMenu.SuspendLayout()
        Me.SuspendLayout()
        '
        'MetroBar
        '
        Me.MetroBar.AntiAlias = False
        Me.MetroBar.BackColor = System.Drawing.Color.White
        '
        '
        '
        Me.MetroBar.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.MetroBar.ContainerControlProcessDialogKey = True
        Me.MetroBar.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.MetroBar.FadeEffect = False
        Me.MetroBar.Font = New System.Drawing.Font("Segoe UI", 10.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MetroBar.ForeColor = System.Drawing.Color.Black
        Me.MetroBar.Items.AddRange(New DevComponents.DotNetBar.BaseItem() {Me.Status, Me.progressBar})
        Me.MetroBar.Location = New System.Drawing.Point(0, 646)
        Me.MetroBar.Name = "MetroBar"
        Me.MetroBar.Size = New System.Drawing.Size(890, 22)
        Me.MetroBar.TabIndex = 1
        '
        'Status
        '
        Me.Status.Name = "Status"
        Me.Status.Text = "Property Management .NET"
        '
        'progressBar
        '
        '
        '
        '
        Me.progressBar.BackStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.progressBar.ChunkGradientAngle = 0.0!
        Me.progressBar.ItemAlignment = DevComponents.DotNetBar.eItemAlignment.Far
        Me.progressBar.MenuVisibility = DevComponents.DotNetBar.eMenuVisibility.VisibleAlways
        Me.progressBar.Name = "progressBar"
        Me.progressBar.RecentlyUsed = False
        '
        'StyleManager1
        '
        Me.StyleManager1.ManagerStyle = DevComponents.DotNetBar.eStyle.Metro
        Me.StyleManager1.MetroColorParameters = New DevComponents.DotNetBar.Metro.ColorTables.MetroColorGeneratorParameters(System.Drawing.Color.White, System.Drawing.Color.FromArgb(CType(CType(43, Byte), Integer), CType(CType(87, Byte), Integer), CType(CType(154, Byte), Integer)))
        '
        'MdiPanel
        '
        Me.MdiPanel.AutoOverflowEnabled = True
        Me.MdiPanel.BackColor = System.Drawing.Color.White
        '
        '
        '
        Me.MdiPanel.BackgroundMouseOverStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        '
        '
        Me.MdiPanel.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.MdiPanel.ContainerControlProcessDialogKey = True
        Me.MdiPanel.Dock = System.Windows.Forms.DockStyle.Top
        Me.MdiPanel.Enabled = False
        Me.MdiPanel.ForeColor = System.Drawing.Color.Black
        Me.MdiPanel.Items.AddRange(New DevComponents.DotNetBar.BaseItem() {Me.ManageBtn, Me.AccountsBtn, Me.SearchBtn, Me.RemindersBtn, Me.SettingsBtn, Me.AccManagementBtn, Me.UpdateBtn, Me.LogOutBtn, Me.ExitBtn})
        Me.MdiPanel.ItemSpacing = 0
        Me.MdiPanel.Location = New System.Drawing.Point(0, 24)
        Me.MdiPanel.Name = "MdiPanel"
        Me.MdiPanel.Size = New System.Drawing.Size(890, 61)
        Me.MdiPanel.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.MdiPanel.TabIndex = 4
        '
        '
        '
        Me.MdiPanel.TitleStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        '
        '
        Me.MdiPanel.TitleStyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        'ManageBtn
        '
        Me.ManageBtn.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText
        Me.ManageBtn.Image = Global.PMD.My.Resources.Resources._1369843066_personal
        Me.ManageBtn.Name = "ManageBtn"
        Me.ManageBtn.SubItemsExpandWidth = 14
        Me.ManageBtn.Text = "Properties"
        '
        'AccountsBtn
        '
        Me.AccountsBtn.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText
        Me.AccountsBtn.Image = Global.PMD.My.Resources.Resources._1370904205_table_money
        Me.AccountsBtn.Name = "AccountsBtn"
        Me.AccountsBtn.SubItemsExpandWidth = 14
        Me.AccountsBtn.Text = "Accounts"
        '
        'SearchBtn
        '
        Me.SearchBtn.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText
        Me.SearchBtn.Image = Global.PMD.My.Resources.Resources._1369843309_search
        Me.SearchBtn.Name = "SearchBtn"
        Me.SearchBtn.SubItemsExpandWidth = 14
        Me.SearchBtn.Text = "Search"
        '
        'RemindersBtn
        '
        Me.RemindersBtn.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText
        Me.RemindersBtn.Image = Global.PMD.My.Resources.Resources._1369843356_preferences_calendar_and_tasks
        Me.RemindersBtn.Name = "RemindersBtn"
        Me.RemindersBtn.SubItemsExpandWidth = 14
        Me.RemindersBtn.Text = "Reminders"
        '
        'SettingsBtn
        '
        Me.SettingsBtn.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText
        Me.SettingsBtn.Image = Global.PMD.My.Resources.Resources._1369843377_cog_icon_2_48x48
        Me.SettingsBtn.Name = "SettingsBtn"
        Me.SettingsBtn.SubItemsExpandWidth = 14
        Me.SettingsBtn.Text = "Settings"
        '
        'AccManagementBtn
        '
        Me.AccManagementBtn.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText
        Me.AccManagementBtn.Image = Global.PMD.My.Resources.Resources._1369843403_preferences_desktop_user_password
        Me.AccManagementBtn.Name = "AccManagementBtn"
        Me.AccManagementBtn.SubItemsExpandWidth = 14
        Me.AccManagementBtn.Text = "User Account Management"
        '
        'UpdateBtn
        '
        Me.UpdateBtn.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText
        Me.UpdateBtn.Image = Global.PMD.My.Resources.Resources._1372966538_system_software_update
        Me.UpdateBtn.Name = "UpdateBtn"
        Me.UpdateBtn.SubItemsExpandWidth = 14
        Me.UpdateBtn.Text = "Check for update"
        '
        'LogOutBtn
        '
        Me.LogOutBtn.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText
        Me.LogOutBtn.Image = Global.PMD.My.Resources.Resources._1369843433_gnome_session_logout
        Me.LogOutBtn.Name = "LogOutBtn"
        Me.LogOutBtn.SubItemsExpandWidth = 14
        Me.LogOutBtn.Text = "Log out"
        '
        'ExitBtn
        '
        Me.ExitBtn.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText
        Me.ExitBtn.Image = Global.PMD.My.Resources.Resources._1369843451_Log_Out
        Me.ExitBtn.Name = "ExitBtn"
        Me.ExitBtn.SubItemsExpandWidth = 14
        Me.ExitBtn.Text = "Exit"
        '
        'SysTrayIcon
        '
        Me.SysTrayIcon.ContextMenuStrip = Me.SysTrayMenu
        Me.SysTrayIcon.Icon = CType(resources.GetObject("SysTrayIcon.Icon"), System.Drawing.Icon)
        '
        'SysTrayMenu
        '
        Me.SysTrayMenu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ShowToolStripMenuItem, Me.ShowTasksStripMenuItem1, Me.LogOutToolStripMenuItem2, Me.ExitToolStripMenuItem1})
        Me.SysTrayMenu.Name = "SysTrayMenu"
        Me.SysTrayMenu.Size = New System.Drawing.Size(165, 114)
        '
        'ShowToolStripMenuItem
        '
        Me.ShowToolStripMenuItem.Name = "ShowToolStripMenuItem"
        Me.ShowToolStripMenuItem.Size = New System.Drawing.Size(164, 22)
        Me.ShowToolStripMenuItem.Text = "Show"
        '
        'ShowTasksStripMenuItem1
        '
        Me.ShowTasksStripMenuItem1.Enabled = False
        Me.ShowTasksStripMenuItem1.Name = "ShowTasksStripMenuItem1"
        Me.ShowTasksStripMenuItem1.Size = New System.Drawing.Size(164, 22)
        Me.ShowTasksStripMenuItem1.Text = "Tasks/Reminders"
        '
        'LogOutToolStripMenuItem2
        '
        Me.LogOutToolStripMenuItem2.Enabled = False
        Me.LogOutToolStripMenuItem2.Name = "LogOutToolStripMenuItem2"
        Me.LogOutToolStripMenuItem2.Size = New System.Drawing.Size(164, 22)
        Me.LogOutToolStripMenuItem2.Text = "Log Out"
        '
        'ExitToolStripMenuItem1
        '
        Me.ExitToolStripMenuItem1.Name = "ExitToolStripMenuItem1"
        Me.ExitToolStripMenuItem1.Size = New System.Drawing.Size(164, 22)
        Me.ExitToolStripMenuItem1.Text = "Exit"
        '
        'ReconnectTimer
        '
        Me.ReconnectTimer.Interval = 3000
        '
        'MainMenu
        '
        Me.MainMenu.BackColor = System.Drawing.Color.White
        Me.MainMenu.ForeColor = System.Drawing.Color.Black
        Me.MainMenu.Location = New System.Drawing.Point(0, 0)
        Me.MainMenu.Name = "MainMenu"
        Me.MainMenu.Size = New System.Drawing.Size(890, 24)
        Me.MainMenu.TabIndex = 11
        Me.MainMenu.Text = "MenuStrip1"
        '
        'ParentMdiForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.ClientSize = New System.Drawing.Size(890, 668)
        Me.Controls.Add(Me.MdiPanel)
        Me.Controls.Add(Me.MetroBar)
        Me.Controls.Add(Me.MainMenu)
        Me.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.MainMenu
        Me.Name = "ParentMdiForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Property Management .NET (Build v0.9.9.5)"
        Me.TitleText = "<span><b><font color=""#1F497D""> Property Management .NET (Build v0.9.9.5)</font><" & _
    "/b></span>"
        Me.SysTrayMenu.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MetroBar As DevComponents.DotNetBar.Metro.MetroStatusBar
    Friend WithEvents Status As DevComponents.DotNetBar.LabelItem
    Friend WithEvents progressBar As DevComponents.DotNetBar.ProgressBarItem
    Friend WithEvents StyleManager1 As DevComponents.DotNetBar.StyleManager
    Friend WithEvents MdiPanel As DevComponents.DotNetBar.RibbonBar
    Friend WithEvents ManageBtn As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents SearchBtn As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents RemindersBtn As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents SettingsBtn As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents AccManagementBtn As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents LogOutBtn As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents SysTrayIcon As System.Windows.Forms.NotifyIcon
    Friend WithEvents SysTrayMenu As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents ShowToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ShowTasksStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LogOutToolStripMenuItem2 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ReconnectTimer As System.Windows.Forms.Timer
    Friend WithEvents ExitBtn As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents AccountsBtn As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents MainMenu As System.Windows.Forms.MenuStrip
    Friend WithEvents UpdateBtn As DevComponents.DotNetBar.ButtonItem
End Class
