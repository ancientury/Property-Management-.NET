<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class TasksForm
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Calendar = New DevComponents.DotNetBar.Schedule.CalendarView()
        Me.RibbonBar1 = New DevComponents.DotNetBar.RibbonBar()
        Me.AddTaskBtn = New DevComponents.DotNetBar.ButtonItem()
        Me.EditTaskBtn = New DevComponents.DotNetBar.ButtonItem()
        Me.DeleteTaskBtn = New DevComponents.DotNetBar.ButtonItem()
        Me.LabelItem3 = New DevComponents.DotNetBar.LabelItem()
        Me.SwitchListBtn = New DevComponents.DotNetBar.SwitchButtonItem()
        Me.LabelItem2 = New DevComponents.DotNetBar.LabelItem()
        Me.DayBtn = New DevComponents.DotNetBar.ButtonItem()
        Me.WeekBtn = New DevComponents.DotNetBar.ButtonItem()
        Me.MonthBtn = New DevComponents.DotNetBar.ButtonItem()
        Me.YearBtn = New DevComponents.DotNetBar.ButtonItem()
        Me.LabelItem1 = New DevComponents.DotNetBar.LabelItem()
        Me.TodayBtn = New DevComponents.DotNetBar.ButtonItem()
        Me.FindTaskBtn = New DevComponents.DotNetBar.ButtonItem()
        Me.ButtonItem3 = New DevComponents.DotNetBar.ButtonItem()
        Me.Navigator = New DevComponents.DotNetBar.Schedule.DateNavigator()
        Me.MonthCombo = New System.Windows.Forms.ComboBox()
        Me.YearCombo = New System.Windows.Forms.ComboBox()
        Me.TasksGrid = New DevComponents.DotNetBar.Controls.DataGridViewX()
        Me.TasksTimer = New System.Windows.Forms.Timer(Me.components)
        Me.VisibilityTimer = New System.Windows.Forms.Timer(Me.components)
        Me.RemindersTimer = New System.Windows.Forms.Timer(Me.components)
        Me.Navigator.SuspendLayout()
        CType(Me.TasksGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Calendar
        '
        Me.Calendar.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Calendar.BackColor = System.Drawing.Color.White
        '
        '
        '
        Me.Calendar.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.Calendar.ContainerControlProcessDialogKey = True
        Me.Calendar.EnableDragDrop = False
        Me.Calendar.ForeColor = System.Drawing.Color.Black
        Me.Calendar.HighlightCurrentDay = True
        Me.Calendar.IsMonthSideBarVisible = False
        Me.Calendar.Location = New System.Drawing.Point(0, 233)
        Me.Calendar.MultiUserTabHeight = 21
        Me.Calendar.Name = "Calendar"
        Me.Calendar.SelectedView = DevComponents.DotNetBar.Schedule.eCalendarView.Month
        Me.Calendar.ShowTabs = False
        Me.Calendar.Size = New System.Drawing.Size(797, 403)
        Me.Calendar.TabIndex = 0
        Me.Calendar.TimeIndicator.BorderColor = System.Drawing.Color.Empty
        Me.Calendar.TimeIndicator.Tag = Nothing
        Me.Calendar.TimeSlotDuration = 30
        '
        'RibbonBar1
        '
        Me.RibbonBar1.AutoOverflowEnabled = True
        Me.RibbonBar1.BackColor = System.Drawing.Color.White
        '
        '
        '
        Me.RibbonBar1.BackgroundMouseOverStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        '
        '
        Me.RibbonBar1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.RibbonBar1.ContainerControlProcessDialogKey = True
        Me.RibbonBar1.Dock = System.Windows.Forms.DockStyle.Top
        Me.RibbonBar1.ForeColor = System.Drawing.Color.Black
        Me.RibbonBar1.Items.AddRange(New DevComponents.DotNetBar.BaseItem() {Me.AddTaskBtn, Me.EditTaskBtn, Me.DeleteTaskBtn, Me.LabelItem3, Me.SwitchListBtn, Me.LabelItem2, Me.DayBtn, Me.WeekBtn, Me.MonthBtn, Me.YearBtn, Me.LabelItem1, Me.TodayBtn, Me.FindTaskBtn})
        Me.RibbonBar1.Location = New System.Drawing.Point(0, 0)
        Me.RibbonBar1.Name = "RibbonBar1"
        Me.RibbonBar1.Size = New System.Drawing.Size(797, 45)
        Me.RibbonBar1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.RibbonBar1.TabIndex = 1
        '
        '
        '
        Me.RibbonBar1.TitleStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        '
        '
        Me.RibbonBar1.TitleStyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        'AddTaskBtn
        '
        Me.AddTaskBtn.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText
        Me.AddTaskBtn.Image = Global.PMD.My.Resources.Resources._1364676805_plus_16
        Me.AddTaskBtn.Name = "AddTaskBtn"
        Me.AddTaskBtn.SubItemsExpandWidth = 14
        Me.AddTaskBtn.Text = "Add Task"
        '
        'EditTaskBtn
        '
        Me.EditTaskBtn.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText
        Me.EditTaskBtn.Enabled = False
        Me.EditTaskBtn.Image = Global.PMD.My.Resources.Resources._1364946094_pencil_16
        Me.EditTaskBtn.Name = "EditTaskBtn"
        Me.EditTaskBtn.SubItemsExpandWidth = 14
        Me.EditTaskBtn.Text = "Edit"
        '
        'DeleteTaskBtn
        '
        Me.DeleteTaskBtn.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText
        Me.DeleteTaskBtn.Enabled = False
        Me.DeleteTaskBtn.Image = Global.PMD.My.Resources.Resources._1364511183_dialog_close
        Me.DeleteTaskBtn.Name = "DeleteTaskBtn"
        Me.DeleteTaskBtn.SubItemsExpandWidth = 14
        Me.DeleteTaskBtn.Text = "Delete"
        '
        'LabelItem3
        '
        Me.LabelItem3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.75!)
        Me.LabelItem3.Name = "LabelItem3"
        Me.LabelItem3.SingleLineColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.LabelItem3.Text = " |"
        '
        'SwitchListBtn
        '
        Me.SwitchListBtn.Name = "SwitchListBtn"
        Me.SwitchListBtn.OffBackColor = System.Drawing.Color.Gainsboro
        Me.SwitchListBtn.OffText = "Unlist"
        Me.SwitchListBtn.OnText = "List"
        Me.SwitchListBtn.SwitchBackColor = System.Drawing.SystemColors.InactiveCaptionText
        '
        'LabelItem2
        '
        Me.LabelItem2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.75!)
        Me.LabelItem2.Name = "LabelItem2"
        Me.LabelItem2.SingleLineColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.LabelItem2.Text = " |"
        '
        'DayBtn
        '
        Me.DayBtn.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText
        Me.DayBtn.Image = Global.PMD.My.Resources.Resources._1367010962_application_view_detail
        Me.DayBtn.Name = "DayBtn"
        Me.DayBtn.SubItemsExpandWidth = 14
        Me.DayBtn.Text = "Day"
        '
        'WeekBtn
        '
        Me.WeekBtn.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText
        Me.WeekBtn.Image = Global.PMD.My.Resources.Resources._1367010962_application_view_detail
        Me.WeekBtn.Name = "WeekBtn"
        Me.WeekBtn.SubItemsExpandWidth = 14
        Me.WeekBtn.Text = "Week"
        '
        'MonthBtn
        '
        Me.MonthBtn.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText
        Me.MonthBtn.Image = Global.PMD.My.Resources.Resources._1367010962_application_view_detail
        Me.MonthBtn.Name = "MonthBtn"
        Me.MonthBtn.SubItemsExpandWidth = 14
        Me.MonthBtn.Text = "Month"
        '
        'YearBtn
        '
        Me.YearBtn.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText
        Me.YearBtn.Image = Global.PMD.My.Resources.Resources._1367010962_application_view_detail
        Me.YearBtn.Name = "YearBtn"
        Me.YearBtn.SubItemsExpandWidth = 14
        Me.YearBtn.Text = "Year"
        '
        'LabelItem1
        '
        Me.LabelItem1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.75!)
        Me.LabelItem1.Name = "LabelItem1"
        Me.LabelItem1.SingleLineColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.LabelItem1.Text = " |"
        '
        'TodayBtn
        '
        Me.TodayBtn.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText
        Me.TodayBtn.Image = Global.PMD.My.Resources.Resources._1367128004_calendar_today
        Me.TodayBtn.Name = "TodayBtn"
        Me.TodayBtn.SubItemsExpandWidth = 14
        Me.TodayBtn.Text = "Today"
        '
        'FindTaskBtn
        '
        Me.FindTaskBtn.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText
        Me.FindTaskBtn.Image = Global.PMD.My.Resources.Resources._1367128105_Magnifier2
        Me.FindTaskBtn.Name = "FindTaskBtn"
        Me.FindTaskBtn.SubItemsExpandWidth = 14
        Me.FindTaskBtn.Text = "Find"
        '
        'ButtonItem3
        '
        Me.ButtonItem3.Name = "ButtonItem3"
        Me.ButtonItem3.SubItemsExpandWidth = 14
        Me.ButtonItem3.Text = "Add Reminder"
        '
        'Navigator
        '
        Me.Navigator.CalendarView = Me.Calendar
        Me.Navigator.CanvasColor = System.Drawing.SystemColors.Control
        Me.Navigator.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Metro
        Me.Navigator.Controls.Add(Me.MonthCombo)
        Me.Navigator.Controls.Add(Me.YearCombo)
        Me.Navigator.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Navigator.Location = New System.Drawing.Point(0, 642)
        Me.Navigator.Name = "Navigator"
        Me.Navigator.Size = New System.Drawing.Size(797, 30)
        Me.Navigator.Style.Alignment = System.Drawing.StringAlignment.Center
        Me.Navigator.Style.BackColor1.Color = System.Drawing.Color.White
        Me.Navigator.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me.Navigator.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.Navigator.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.Navigator.Style.GradientAngle = 90
        Me.Navigator.TabIndex = 2
        '
        'MonthCombo
        '
        Me.MonthCombo.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.MonthCombo.BackColor = System.Drawing.Color.White
        Me.MonthCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.MonthCombo.ForeColor = System.Drawing.Color.Black
        Me.MonthCombo.FormattingEnabled = True
        Me.MonthCombo.Items.AddRange(New Object() {"January", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December"})
        Me.MonthCombo.Location = New System.Drawing.Point(611, 5)
        Me.MonthCombo.Name = "MonthCombo"
        Me.MonthCombo.Size = New System.Drawing.Size(121, 21)
        Me.MonthCombo.TabIndex = 65
        '
        'YearCombo
        '
        Me.YearCombo.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.YearCombo.BackColor = System.Drawing.Color.White
        Me.YearCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.YearCombo.ForeColor = System.Drawing.Color.Black
        Me.YearCombo.FormattingEnabled = True
        Me.YearCombo.Items.AddRange(New Object() {"2010", "2011", "2012", "2013", "2014", "2015", "2016", "2017", "2018", "2019", "2020", "2021", "2022", "2023", "2024", "2025", "2026", "2027", "2028", "2029", "2030", "2031", "2032", "2033", "2034", "2035", "2036", "2037", "2038", "2039", "2040", "2041", "2042", "2043", "2044", "2045", "2046", "2047", "2048", "2049", "2050", "2051", "2052", "2053", "2054", "2055", "2056", "2057", "2058", "2059", "2060", "2061", "2062", "2063", "2064", "2065", "2066", "2067", "2068", "2069", "2070", "2071", "2072", "2073", "2074", "2075", "2076", "2077", "2078", "2079", "2080", "2081", "2082", "2083", "2084", "2085", "2086", "2087", "2088", "2089", "2090", "2091", "2092", "2093", "2094", "2095", "2096", "2097", "2098", "2099", "2100", "2101", "2102", "2103", "2104", "2105", "2106", "2107", "2108", "2109", "2110", "2111", "2112", "2113", "2114", "2115", "2116", "2117", "2118", "2119", "2120", "2121", "2122", "2123", "2124", "2125", "2126", "2127", "2128", "2129", "2130", "2131", "2132", "2133", "2134", "2135", "2136", "2137", "2138", "2139", "2140", "2141", "2142", "2143", "2144", "2145", "2146", "2147", "2148", "2149", "2150", "2151", "2152", "2153", "2154", "2155", "2156", "2157", "2158", "2159", "2160", "2161", "2162", "2163", "2164", "2165", "2166", "2167", "2168", "2169", "2170", "2171", "2172", "2173", "2174", "2175", "2176", "2177", "2178", "2179", "2180", "2181", "2182", "2183", "2184", "2185", "2186", "2187", "2188", "2189", "2190", "2191", "2192", "2193", "2194", "2195", "2196", "2197", "2198", "2199", "2200"})
        Me.YearCombo.Location = New System.Drawing.Point(738, 5)
        Me.YearCombo.Name = "YearCombo"
        Me.YearCombo.Size = New System.Drawing.Size(55, 21)
        Me.YearCombo.TabIndex = 64
        '
        'TasksGrid
        '
        Me.TasksGrid.AllowUserToAddRows = False
        Me.TasksGrid.AllowUserToDeleteRows = False
        Me.TasksGrid.AllowUserToOrderColumns = True
        Me.TasksGrid.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TasksGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.TasksGrid.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells
        Me.TasksGrid.BackgroundColor = System.Drawing.Color.White
        Me.TasksGrid.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.TasksGrid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black
        Me.TasksGrid.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.TasksGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.TasksGrid.DefaultCellStyle = DataGridViewCellStyle2
        Me.TasksGrid.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.TasksGrid.EnableHeadersVisualStyles = False
        Me.TasksGrid.GridColor = System.Drawing.Color.FromArgb(CType(CType(170, Byte), Integer), CType(CType(170, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.TasksGrid.Location = New System.Drawing.Point(2, 51)
        Me.TasksGrid.MultiSelect = False
        Me.TasksGrid.Name = "TasksGrid"
        Me.TasksGrid.ReadOnly = True
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black
        Me.TasksGrid.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.TasksGrid.RowHeadersVisible = False
        Me.TasksGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.TasksGrid.Size = New System.Drawing.Size(795, 176)
        Me.TasksGrid.TabIndex = 64
        Me.TasksGrid.TabStop = False
        '
        'TasksTimer
        '
        Me.TasksTimer.Interval = 5000
        '
        'VisibilityTimer
        '
        Me.VisibilityTimer.Enabled = True
        Me.VisibilityTimer.Interval = 1
        '
        'RemindersTimer
        '
        Me.RemindersTimer.Enabled = True
        Me.RemindersTimer.Interval = 60000
        '
        'TasksForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(797, 672)
        Me.Controls.Add(Me.TasksGrid)
        Me.Controls.Add(Me.Navigator)
        Me.Controls.Add(Me.RibbonBar1)
        Me.Controls.Add(Me.Calendar)
        Me.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MinimumSize = New System.Drawing.Size(813, 710)
        Me.Name = "TasksForm"
        Me.Opacity = 0.0R
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Tasks"
        Me.Navigator.ResumeLayout(False)
        Me.Navigator.PerformLayout()
        CType(Me.TasksGrid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Calendar As DevComponents.DotNetBar.Schedule.CalendarView
    Friend WithEvents RibbonBar1 As DevComponents.DotNetBar.RibbonBar
    Friend WithEvents AddTaskBtn As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents EditTaskBtn As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents DeleteTaskBtn As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents LabelItem1 As DevComponents.DotNetBar.LabelItem
    Friend WithEvents DayBtn As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents WeekBtn As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents MonthBtn As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents YearBtn As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents TodayBtn As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents ButtonItem3 As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents FindTaskBtn As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents Navigator As DevComponents.DotNetBar.Schedule.DateNavigator
    Friend WithEvents SwitchListBtn As DevComponents.DotNetBar.SwitchButtonItem
    Friend WithEvents LabelItem3 As DevComponents.DotNetBar.LabelItem
    Friend WithEvents LabelItem2 As DevComponents.DotNetBar.LabelItem
    Friend WithEvents MonthCombo As System.Windows.Forms.ComboBox
    Friend WithEvents YearCombo As System.Windows.Forms.ComboBox
    Friend WithEvents TasksGrid As DevComponents.DotNetBar.Controls.DataGridViewX
    Friend WithEvents TasksTimer As System.Windows.Forms.Timer
    Friend WithEvents VisibilityTimer As System.Windows.Forms.Timer
    Friend WithEvents RemindersTimer As System.Windows.Forms.Timer
End Class
