<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainForm))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.DataGridMenu = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ManageStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EditStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AddStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RefreshStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ImageList = New System.Windows.Forms.ImageList(Me.components)
        Me.ExportMenu = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ExportToExcelToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExportToCSVToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Statusl = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripProgressBar1 = New System.Windows.Forms.ToolStripProgressBar()
        Me.MainTabControl = New DevComponents.DotNetBar.TabControl()
        Me.Tab1 = New DevComponents.DotNetBar.TabControlPanel()
        Me.SearchBtn = New DevComponents.DotNetBar.ButtonX()
        Me.DataGrid = New DevComponents.DotNetBar.Controls.DataGridViewX()
        Me.ExportBtn = New DevComponents.DotNetBar.ButtonX()
        Me.RefreshBtn = New DevComponents.DotNetBar.ButtonX()
        Me.AddBtn = New DevComponents.DotNetBar.ButtonX()
        Me.ManageBtn = New DevComponents.DotNetBar.ButtonX()
        Me.TabItem1 = New DevComponents.DotNetBar.TabItem(Me.components)
        Me.DataGridMenu.SuspendLayout()
        Me.ExportMenu.SuspendLayout()
        CType(Me.MainTabControl, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MainTabControl.SuspendLayout()
        Me.Tab1.SuspendLayout()
        CType(Me.DataGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridMenu
        '
        Me.DataGridMenu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ManageStripMenuItem, Me.EditStripMenuItem, Me.AddStripMenuItem, Me.RefreshStripMenuItem})
        Me.DataGridMenu.Name = "DataGridMenu"
        Me.DataGridMenu.Size = New System.Drawing.Size(212, 92)
        '
        'ManageStripMenuItem
        '
        Me.ManageStripMenuItem.Enabled = False
        Me.ManageStripMenuItem.Name = "ManageStripMenuItem"
        Me.ManageStripMenuItem.Size = New System.Drawing.Size(211, 22)
        Me.ManageStripMenuItem.Text = "Manage selected Property"
        '
        'EditStripMenuItem
        '
        Me.EditStripMenuItem.Enabled = False
        Me.EditStripMenuItem.Name = "EditStripMenuItem"
        Me.EditStripMenuItem.Size = New System.Drawing.Size(211, 22)
        Me.EditStripMenuItem.Text = "Edit selected Property"
        '
        'AddStripMenuItem
        '
        Me.AddStripMenuItem.Name = "AddStripMenuItem"
        Me.AddStripMenuItem.Size = New System.Drawing.Size(211, 22)
        Me.AddStripMenuItem.Text = "Add new Property"
        '
        'RefreshStripMenuItem
        '
        Me.RefreshStripMenuItem.Name = "RefreshStripMenuItem"
        Me.RefreshStripMenuItem.Size = New System.Drawing.Size(211, 22)
        Me.RefreshStripMenuItem.Text = "Refresh Properties"
        '
        'ImageList
        '
        Me.ImageList.ImageStream = CType(resources.GetObject("ImageList.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList.TransparentColor = System.Drawing.Color.Transparent
        Me.ImageList.Images.SetKeyName(0, "1364417267_personal.png")
        Me.ImageList.Images.SetKeyName(1, "1364438555_icon_key.gif")
        Me.ImageList.Images.SetKeyName(2, "1364438651_info.png")
        '
        'ExportMenu
        '
        Me.ExportMenu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ExportToExcelToolStripMenuItem, Me.ExportToCSVToolStripMenuItem})
        Me.ExportMenu.Name = "ExportMenu"
        Me.ExportMenu.Size = New System.Drawing.Size(153, 48)
        '
        'ExportToExcelToolStripMenuItem
        '
        Me.ExportToExcelToolStripMenuItem.Name = "ExportToExcelToolStripMenuItem"
        Me.ExportToExcelToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.ExportToExcelToolStripMenuItem.Text = "Export to Excel"
        '
        'ExportToCSVToolStripMenuItem
        '
        Me.ExportToCSVToolStripMenuItem.Name = "ExportToCSVToolStripMenuItem"
        Me.ExportToCSVToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.ExportToCSVToolStripMenuItem.Text = "Export to CSV"
        '
        'Statusl
        '
        Me.Statusl.Name = "Statusl"
        Me.Statusl.Size = New System.Drawing.Size(23, 23)
        Me.Statusl.Text = "gfdg"
        '
        'ToolStripProgressBar1
        '
        Me.ToolStripProgressBar1.Name = "ToolStripProgressBar1"
        Me.ToolStripProgressBar1.Size = New System.Drawing.Size(100, 16)
        '
        'MainTabControl
        '
        Me.MainTabControl.BackColor = System.Drawing.Color.White
        Me.MainTabControl.CanReorderTabs = True
        Me.MainTabControl.CloseButtonOnTabsVisible = True
        Me.MainTabControl.CloseButtonPosition = DevComponents.DotNetBar.eTabCloseButtonPosition.Right
        Me.MainTabControl.CloseButtonVisible = True
        Me.MainTabControl.Controls.Add(Me.Tab1)
        Me.MainTabControl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.MainTabControl.ForeColor = System.Drawing.Color.Black
        Me.MainTabControl.Location = New System.Drawing.Point(0, 0)
        Me.MainTabControl.Name = "MainTabControl"
        Me.MainTabControl.SelectedTabFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.MainTabControl.SelectedTabIndex = 0
        Me.MainTabControl.Size = New System.Drawing.Size(805, 695)
        Me.MainTabControl.Style = DevComponents.DotNetBar.eTabStripStyle.Metro
        Me.MainTabControl.TabIndex = 2
        Me.MainTabControl.TabLayoutType = DevComponents.DotNetBar.eTabLayoutType.FixedWithNavigationBox
        Me.MainTabControl.Tabs.Add(Me.TabItem1)
        Me.MainTabControl.Text = "TabControl1"
        '
        'Tab1
        '
        Me.Tab1.Controls.Add(Me.SearchBtn)
        Me.Tab1.Controls.Add(Me.DataGrid)
        Me.Tab1.Controls.Add(Me.ExportBtn)
        Me.Tab1.Controls.Add(Me.RefreshBtn)
        Me.Tab1.Controls.Add(Me.AddBtn)
        Me.Tab1.Controls.Add(Me.ManageBtn)
        Me.Tab1.DisabledBackColor = System.Drawing.Color.Empty
        Me.Tab1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Tab1.Location = New System.Drawing.Point(0, 27)
        Me.Tab1.Name = "Tab1"
        Me.Tab1.Padding = New System.Windows.Forms.Padding(1)
        Me.Tab1.Size = New System.Drawing.Size(805, 668)
        Me.Tab1.Style.BackColor1.Color = System.Drawing.Color.White
        Me.Tab1.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me.Tab1.Style.BorderColor.Color = System.Drawing.Color.FromArgb(CType(CType(211, Byte), Integer), CType(CType(211, Byte), Integer), CType(CType(211, Byte), Integer))
        Me.Tab1.Style.BorderSide = CType(((DevComponents.DotNetBar.eBorderSide.Left Or DevComponents.DotNetBar.eBorderSide.Right) _
            Or DevComponents.DotNetBar.eBorderSide.Bottom), DevComponents.DotNetBar.eBorderSide)
        Me.Tab1.Style.GradientAngle = 90
        Me.Tab1.TabIndex = 1
        Me.Tab1.TabItem = Me.TabItem1
        '
        'SearchBtn
        '
        Me.SearchBtn.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.SearchBtn.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.SearchBtn.Image = Global.PMD.My.Resources.Resources._1367126706_Magnifier2
        Me.SearchBtn.ImageTextSpacing = 3
        Me.SearchBtn.Location = New System.Drawing.Point(4, 96)
        Me.SearchBtn.Name = "SearchBtn"
        Me.SearchBtn.Size = New System.Drawing.Size(139, 44)
        Me.SearchBtn.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.SearchBtn.TabIndex = 62
        Me.SearchBtn.Text = "Search Records"
        Me.SearchBtn.TextAlignment = DevComponents.DotNetBar.eButtonTextAlignment.Left
        '
        'DataGrid
        '
        Me.DataGrid.AllowUserToAddRows = False
        Me.DataGrid.AllowUserToDeleteRows = False
        Me.DataGrid.AllowUserToOrderColumns = True
        Me.DataGrid.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGrid.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells
        Me.DataGrid.BackgroundColor = System.Drawing.Color.White
        Me.DataGrid.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.DataGrid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black
        Me.DataGrid.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.DataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGrid.DefaultCellStyle = DataGridViewCellStyle2
        Me.DataGrid.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.DataGrid.EnableHeadersVisualStyles = False
        Me.DataGrid.GridColor = System.Drawing.Color.FromArgb(CType(CType(170, Byte), Integer), CType(CType(170, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.DataGrid.Location = New System.Drawing.Point(149, 2)
        Me.DataGrid.MultiSelect = False
        Me.DataGrid.Name = "DataGrid"
        Me.DataGrid.ReadOnly = True
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black
        Me.DataGrid.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.DataGrid.RowHeadersVisible = False
        Me.DataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGrid.Size = New System.Drawing.Size(653, 662)
        Me.DataGrid.TabIndex = 61
        Me.DataGrid.TabStop = False
        '
        'ExportBtn
        '
        Me.ExportBtn.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.ExportBtn.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.ExportBtn.Image = Global.PMD.My.Resources.Resources._1364519814_export1
        Me.ExportBtn.ImageTextSpacing = 2
        Me.ExportBtn.Location = New System.Drawing.Point(4, 195)
        Me.ExportBtn.Name = "ExportBtn"
        Me.ExportBtn.Size = New System.Drawing.Size(139, 44)
        Me.ExportBtn.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.ExportBtn.TabIndex = 60
        Me.ExportBtn.Text = "Export"
        Me.ExportBtn.TextAlignment = DevComponents.DotNetBar.eButtonTextAlignment.Left
        '
        'RefreshBtn
        '
        Me.RefreshBtn.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.RefreshBtn.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.RefreshBtn.Image = Global.PMD.My.Resources.Resources._1366929476_adept_update
        Me.RefreshBtn.ImageTextSpacing = 3
        Me.RefreshBtn.Location = New System.Drawing.Point(4, 145)
        Me.RefreshBtn.Name = "RefreshBtn"
        Me.RefreshBtn.Size = New System.Drawing.Size(139, 44)
        Me.RefreshBtn.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.RefreshBtn.TabIndex = 59
        Me.RefreshBtn.Text = "Refresh Records"
        Me.RefreshBtn.TextAlignment = DevComponents.DotNetBar.eButtonTextAlignment.Left
        '
        'AddBtn
        '
        Me.AddBtn.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.AddBtn.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.AddBtn.Image = Global.PMD.My.Resources.Resources._1364439132_plus_32
        Me.AddBtn.ImageTextSpacing = 3
        Me.AddBtn.Location = New System.Drawing.Point(4, 46)
        Me.AddBtn.Name = "AddBtn"
        Me.AddBtn.Size = New System.Drawing.Size(139, 44)
        Me.AddBtn.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.AddBtn.TabIndex = 58
        Me.AddBtn.Text = "Add Property"
        Me.AddBtn.TextAlignment = DevComponents.DotNetBar.eButtonTextAlignment.Left
        '
        'ManageBtn
        '
        Me.ManageBtn.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.ManageBtn.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.ManageBtn.Enabled = False
        Me.ManageBtn.Image = Global.PMD.My.Resources.Resources._1366929459_personal
        Me.ManageBtn.Location = New System.Drawing.Point(4, 2)
        Me.ManageBtn.Name = "ManageBtn"
        Me.ManageBtn.Size = New System.Drawing.Size(139, 38)
        Me.ManageBtn.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.ManageBtn.TabIndex = 57
        Me.ManageBtn.Text = "Manage Property"
        Me.ManageBtn.TextAlignment = DevComponents.DotNetBar.eButtonTextAlignment.Left
        '
        'TabItem1
        '
        Me.TabItem1.AttachedControl = Me.Tab1
        Me.TabItem1.Image = Global.PMD.My.Resources.Resources._1364417267_personal
        Me.TabItem1.Name = "TabItem1"
        Me.TabItem1.Text = "Properties"
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(805, 695)
        Me.Controls.Add(Me.MainTabControl)
        Me.DoubleBuffered = True
        Me.MinimumSize = New System.Drawing.Size(650, 550)
        Me.Name = "MainForm"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Manage Properties"
        Me.DataGridMenu.ResumeLayout(False)
        Me.ExportMenu.ResumeLayout(False)
        CType(Me.MainTabControl, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MainTabControl.ResumeLayout(False)
        Me.Tab1.ResumeLayout(False)
        CType(Me.DataGrid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents DataGridMenu As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents ManageStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EditStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RefreshStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ImageList As System.Windows.Forms.ImageList
    Friend WithEvents ExportMenu As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents ExportToExcelToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ExportToCSVToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Statusl As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents AddStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripProgressBar1 As System.Windows.Forms.ToolStripProgressBar
    Friend WithEvents MainTabControl As DevComponents.DotNetBar.TabControl
    Friend WithEvents Tab1 As DevComponents.DotNetBar.TabControlPanel
    Friend WithEvents TabItem1 As DevComponents.DotNetBar.TabItem
    Friend WithEvents ExportBtn As DevComponents.DotNetBar.ButtonX
    Friend WithEvents RefreshBtn As DevComponents.DotNetBar.ButtonX
    Friend WithEvents AddBtn As DevComponents.DotNetBar.ButtonX
    Friend WithEvents ManageBtn As DevComponents.DotNetBar.ButtonX
    Friend WithEvents DataGrid As DevComponents.DotNetBar.Controls.DataGridViewX
    Friend WithEvents SearchBtn As DevComponents.DotNetBar.ButtonX

End Class
