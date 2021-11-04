<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AccountsForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AccountsForm))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.PaidInvoicesLabel = New System.Windows.Forms.Label()
        Me.InvoicesGrid = New DevComponents.DotNetBar.Controls.DataGridViewX()
        Me.StatementNote = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.PropertyNameCombo = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.MonthCombo = New System.Windows.Forms.ComboBox()
        Me.YearCombo = New System.Windows.Forms.ComboBox()
        Me.StatementTypeCombo = New DevComponents.DotNetBar.Controls.ComboBoxEx()
        Me.ItemMonthly = New DevComponents.Editors.ComboItem()
        Me.ItemQuarterly = New DevComponents.Editors.ComboItem()
        Me.ItemYearly = New DevComponents.Editors.ComboItem()
        Me.ShowUnpaidChkBox = New DevComponents.DotNetBar.Controls.CheckBoxX()
        Me.ShowPaidChkBox = New DevComponents.DotNetBar.Controls.CheckBoxX()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.GenerateBtn = New DevComponents.DotNetBar.ButtonX()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.ToDate = New System.Windows.Forms.Label()
        Me.FromDate = New System.Windows.Forms.Label()
        Me.AddFundsBtn = New DevComponents.DotNetBar.ButtonX()
        Me.LabelX1 = New DevComponents.DotNetBar.LabelX()
        Me.NextBtn = New DevComponents.DotNetBar.ButtonX()
        Me.PreviousBtn = New DevComponents.DotNetBar.ButtonX()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.CalcNote2 = New System.Windows.Forms.Label()
        Me.CalcNote = New System.Windows.Forms.Label()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.LatestPayedIn = New PMD.CurrencyTextBox(Me.components)
        Me.Label4 = New System.Windows.Forms.Label()
        Me.ClosingBalance = New PMD.CurrencyTextBox(Me.components)
        Me.UnpaidLabel = New System.Windows.Forms.Label()
        Me.PayedOut = New PMD.CurrencyTextBox(Me.components)
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Balance = New PMD.CurrencyTextBox(Me.components)
        Me.PayedIn = New PMD.CurrencyTextBox(Me.components)
        Me.Label3 = New System.Windows.Forms.Label()
        Me.UnpaidBalance = New PMD.CurrencyTextBox(Me.components)
        Me.FundSourceBalloonTip = New DevComponents.DotNetBar.BalloonTip()
        Me.GroupBox1.SuspendLayout()
        CType(Me.InvoicesGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.White
        Me.GroupBox1.Controls.Add(Me.PaidInvoicesLabel)
        Me.GroupBox1.Controls.Add(Me.InvoicesGrid)
        Me.GroupBox1.Controls.Add(Me.StatementNote)
        Me.GroupBox1.Controls.Add(Me.GroupBox3)
        Me.GroupBox1.Controls.Add(Me.GroupBox4)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.ToDate)
        Me.GroupBox1.Controls.Add(Me.FromDate)
        Me.GroupBox1.Controls.Add(Me.AddFundsBtn)
        Me.GroupBox1.Controls.Add(Me.LabelX1)
        Me.GroupBox1.Controls.Add(Me.NextBtn)
        Me.GroupBox1.Controls.Add(Me.PreviousBtn)
        Me.GroupBox1.Controls.Add(Me.GroupBox2)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox1.ForeColor = System.Drawing.Color.Black
        Me.GroupBox1.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(826, 718)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Accounts"
        '
        'PaidInvoicesLabel
        '
        Me.PaidInvoicesLabel.AutoSize = True
        Me.PaidInvoicesLabel.BackColor = System.Drawing.Color.White
        Me.PaidInvoicesLabel.ForeColor = System.Drawing.Color.Black
        Me.PaidInvoicesLabel.Location = New System.Drawing.Point(6, 400)
        Me.PaidInvoicesLabel.Name = "PaidInvoicesLabel"
        Me.PaidInvoicesLabel.Size = New System.Drawing.Size(51, 13)
        Me.PaidInvoicesLabel.TabIndex = 99
        Me.PaidInvoicesLabel.Text = "Invoices:"
        '
        'InvoicesGrid
        '
        Me.InvoicesGrid.AllowUserToAddRows = False
        Me.InvoicesGrid.AllowUserToDeleteRows = False
        Me.InvoicesGrid.AllowUserToOrderColumns = True
        Me.InvoicesGrid.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.InvoicesGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.InvoicesGrid.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells
        Me.InvoicesGrid.BackgroundColor = System.Drawing.Color.White
        Me.InvoicesGrid.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.InvoicesGrid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black
        Me.InvoicesGrid.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.InvoicesGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.InvoicesGrid.DefaultCellStyle = DataGridViewCellStyle2
        Me.InvoicesGrid.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.InvoicesGrid.EnableHeadersVisualStyles = False
        Me.InvoicesGrid.GridColor = System.Drawing.Color.FromArgb(CType(CType(170, Byte), Integer), CType(CType(170, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.InvoicesGrid.Location = New System.Drawing.Point(9, 417)
        Me.InvoicesGrid.MultiSelect = False
        Me.InvoicesGrid.Name = "InvoicesGrid"
        Me.InvoicesGrid.ReadOnly = True
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black
        Me.InvoicesGrid.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.InvoicesGrid.RowHeadersVisible = False
        Me.InvoicesGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.InvoicesGrid.Size = New System.Drawing.Size(804, 288)
        Me.InvoicesGrid.TabIndex = 98
        Me.InvoicesGrid.TabStop = False
        '
        'StatementNote
        '
        Me.StatementNote.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.StatementNote.AutoSize = True
        Me.StatementNote.BackColor = System.Drawing.Color.White
        Me.StatementNote.ForeColor = System.Drawing.Color.Black
        Me.StatementNote.Location = New System.Drawing.Point(306, 385)
        Me.StatementNote.Name = "StatementNote"
        Me.StatementNote.Size = New System.Drawing.Size(221, 13)
        Me.StatementNote.TabIndex = 97
        Me.StatementNote.Text = "Please select property and statement date"
        '
        'GroupBox3
        '
        Me.GroupBox3.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox3.BackColor = System.Drawing.Color.White
        Me.GroupBox3.Controls.Add(Me.PropertyNameCombo)
        Me.GroupBox3.Controls.Add(Me.Label5)
        Me.GroupBox3.ForeColor = System.Drawing.Color.Black
        Me.GroupBox3.Location = New System.Drawing.Point(9, 206)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(804, 55)
        Me.GroupBox3.TabIndex = 96
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Property:"
        '
        'PropertyNameCombo
        '
        Me.PropertyNameCombo.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PropertyNameCombo.BackColor = System.Drawing.Color.White
        Me.PropertyNameCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.PropertyNameCombo.ForeColor = System.Drawing.Color.Black
        Me.PropertyNameCombo.FormattingEnabled = True
        Me.PropertyNameCombo.Location = New System.Drawing.Point(140, 21)
        Me.PropertyNameCombo.Name = "PropertyNameCombo"
        Me.PropertyNameCombo.Size = New System.Drawing.Size(608, 21)
        Me.PropertyNameCombo.TabIndex = 1
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.White
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(45, 24)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(90, 13)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "Company Name:"
        '
        'GroupBox4
        '
        Me.GroupBox4.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox4.BackColor = System.Drawing.Color.White
        Me.GroupBox4.Controls.Add(Me.MonthCombo)
        Me.GroupBox4.Controls.Add(Me.YearCombo)
        Me.GroupBox4.Controls.Add(Me.StatementTypeCombo)
        Me.GroupBox4.Controls.Add(Me.ShowUnpaidChkBox)
        Me.GroupBox4.Controls.Add(Me.ShowPaidChkBox)
        Me.GroupBox4.Controls.Add(Me.Label10)
        Me.GroupBox4.Controls.Add(Me.GenerateBtn)
        Me.GroupBox4.ForeColor = System.Drawing.Color.Black
        Me.GroupBox4.Location = New System.Drawing.Point(9, 267)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(804, 76)
        Me.GroupBox4.TabIndex = 94
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Statement:"
        '
        'MonthCombo
        '
        Me.MonthCombo.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.MonthCombo.BackColor = System.Drawing.Color.White
        Me.MonthCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.MonthCombo.Enabled = False
        Me.MonthCombo.ForeColor = System.Drawing.Color.Black
        Me.MonthCombo.FormattingEnabled = True
        Me.MonthCombo.Items.AddRange(New Object() {"January", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December"})
        Me.MonthCombo.Location = New System.Drawing.Point(368, 45)
        Me.MonthCombo.Name = "MonthCombo"
        Me.MonthCombo.Size = New System.Drawing.Size(205, 21)
        Me.MonthCombo.TabIndex = 103
        '
        'YearCombo
        '
        Me.YearCombo.BackColor = System.Drawing.Color.White
        Me.YearCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.YearCombo.Enabled = False
        Me.YearCombo.ForeColor = System.Drawing.Color.Black
        Me.YearCombo.FormattingEnabled = True
        Me.YearCombo.Items.AddRange(New Object() {"2010", "2011", "2012", "2013", "2014", "2015", "2016", "2017", "2018", "2019", "2020", "2021", "2022", "2023", "2024", "2025", "2026", "2027", "2028", "2029", "2030", "2031", "2032", "2033", "2034", "2035", "2036", "2037", "2038", "2039", "2040", "2041", "2042", "2043", "2044", "2045", "2046", "2047", "2048", "2049", "2050", "2051", "2052", "2053", "2054", "2055", "2056", "2057", "2058", "2059", "2060", "2061", "2062", "2063", "2064", "2065", "2066", "2067", "2068", "2069", "2070", "2071", "2072", "2073", "2074", "2075", "2076", "2077", "2078", "2079", "2080", "2081", "2082", "2083", "2084", "2085", "2086", "2087", "2088", "2089", "2090", "2091", "2092", "2093", "2094", "2095", "2096", "2097", "2098", "2099", "2100", "2101", "2102", "2103", "2104", "2105", "2106", "2107", "2108", "2109", "2110", "2111", "2112", "2113", "2114", "2115", "2116", "2117", "2118", "2119", "2120", "2121", "2122", "2123", "2124", "2125", "2126", "2127", "2128", "2129", "2130", "2131", "2132", "2133", "2134", "2135", "2136", "2137", "2138", "2139", "2140", "2141", "2142", "2143", "2144", "2145", "2146", "2147", "2148", "2149", "2150", "2151", "2152", "2153", "2154", "2155", "2156", "2157", "2158", "2159", "2160", "2161", "2162", "2163", "2164", "2165", "2166", "2167", "2168", "2169", "2170", "2171", "2172", "2173", "2174", "2175", "2176", "2177", "2178", "2179", "2180", "2181", "2182", "2183", "2184", "2185", "2186", "2187", "2188", "2189", "2190", "2191", "2192", "2193", "2194", "2195", "2196", "2197", "2198", "2199", "2200"})
        Me.YearCombo.Location = New System.Drawing.Point(194, 45)
        Me.YearCombo.Name = "YearCombo"
        Me.YearCombo.Size = New System.Drawing.Size(168, 21)
        Me.YearCombo.TabIndex = 102
        '
        'StatementTypeCombo
        '
        Me.StatementTypeCombo.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.StatementTypeCombo.DisplayMember = "Text"
        Me.StatementTypeCombo.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.StatementTypeCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.StatementTypeCombo.Enabled = False
        Me.StatementTypeCombo.ForeColor = System.Drawing.Color.Black
        Me.StatementTypeCombo.FormattingEnabled = True
        Me.StatementTypeCombo.ItemHeight = 16
        Me.StatementTypeCombo.Items.AddRange(New Object() {Me.ItemMonthly, Me.ItemQuarterly, Me.ItemYearly})
        Me.StatementTypeCombo.Location = New System.Drawing.Point(194, 17)
        Me.StatementTypeCombo.Name = "StatementTypeCombo"
        Me.StatementTypeCombo.Size = New System.Drawing.Size(379, 22)
        Me.StatementTypeCombo.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.StatementTypeCombo.TabIndex = 101
        '
        'ItemMonthly
        '
        Me.ItemMonthly.Text = "Monthly"
        '
        'ItemQuarterly
        '
        Me.ItemQuarterly.Text = "Quarterly"
        '
        'ItemYearly
        '
        Me.ItemYearly.Text = "Yearly"
        '
        'ShowUnpaidChkBox
        '
        Me.ShowUnpaidChkBox.AutoSize = True
        '
        '
        '
        Me.ShowUnpaidChkBox.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.ShowUnpaidChkBox.CheckSignSize = New System.Drawing.Size(18, 18)
        Me.ShowUnpaidChkBox.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ShowUnpaidChkBox.Location = New System.Drawing.Point(48, 46)
        Me.ShowUnpaidChkBox.Name = "ShowUnpaidChkBox"
        Me.ShowUnpaidChkBox.Size = New System.Drawing.Size(112, 20)
        Me.ShowUnpaidChkBox.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.ShowUnpaidChkBox.TabIndex = 100
        Me.ShowUnpaidChkBox.Text = "Unpaid Invoices"
        '
        'ShowPaidChkBox
        '
        Me.ShowPaidChkBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        '
        '
        '
        Me.ShowPaidChkBox.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.ShowPaidChkBox.Checked = True
        Me.ShowPaidChkBox.CheckSignSize = New System.Drawing.Size(18, 18)
        Me.ShowPaidChkBox.CheckState = System.Windows.Forms.CheckState.Checked
        Me.ShowPaidChkBox.CheckValue = "Y"
        Me.ShowPaidChkBox.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ShowPaidChkBox.Location = New System.Drawing.Point(48, 18)
        Me.ShowPaidChkBox.Name = "ShowPaidChkBox"
        Me.ShowPaidChkBox.Size = New System.Drawing.Size(100, 23)
        Me.ShowPaidChkBox.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.ShowPaidChkBox.TabIndex = 99
        Me.ShowPaidChkBox.Text = "Paid Invoices"
        '
        'Label10
        '
        Me.Label10.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.White
        Me.Label10.ForeColor = System.Drawing.Color.Black
        Me.Label10.Location = New System.Drawing.Point(634, 1)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(114, 13)
        Me.Label10.TabIndex = 98
        Me.Label10.Text = "Customer Statement:"
        '
        'GenerateBtn
        '
        Me.GenerateBtn.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.GenerateBtn.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GenerateBtn.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.GenerateBtn.Image = Global.PMD.My.Resources.Resources._1373215226_taxes
        Me.GenerateBtn.Location = New System.Drawing.Point(593, 21)
        Me.GenerateBtn.Name = "GenerateBtn"
        Me.GenerateBtn.Size = New System.Drawing.Size(199, 46)
        Me.GenerateBtn.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.GenerateBtn.TabIndex = 96
        Me.GenerateBtn.Text = "Generate Report"
        '
        'Label9
        '
        Me.Label9.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.White
        Me.Label9.ForeColor = System.Drawing.Color.Black
        Me.Label9.Location = New System.Drawing.Point(407, 355)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(11, 13)
        Me.Label9.TabIndex = 92
        Me.Label9.Text = "-"
        '
        'ToDate
        '
        Me.ToDate.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.ToDate.AutoSize = True
        Me.ToDate.BackColor = System.Drawing.Color.White
        Me.ToDate.ForeColor = System.Drawing.Color.Black
        Me.ToDate.Location = New System.Drawing.Point(463, 355)
        Me.ToDate.Name = "ToDate"
        Me.ToDate.Size = New System.Drawing.Size(0, 13)
        Me.ToDate.TabIndex = 91
        '
        'FromDate
        '
        Me.FromDate.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.FromDate.AutoSize = True
        Me.FromDate.BackColor = System.Drawing.Color.White
        Me.FromDate.ForeColor = System.Drawing.Color.Black
        Me.FromDate.Location = New System.Drawing.Point(322, 355)
        Me.FromDate.Name = "FromDate"
        Me.FromDate.Size = New System.Drawing.Size(0, 13)
        Me.FromDate.TabIndex = 90
        '
        'AddFundsBtn
        '
        Me.AddFundsBtn.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.AddFundsBtn.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.AddFundsBtn.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.AddFundsBtn.Enabled = False
        Me.AddFundsBtn.Image = Global.PMD.My.Resources.Resources._1370905490_money_pound_add
        Me.AddFundsBtn.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top
        Me.AddFundsBtn.Location = New System.Drawing.Point(610, 48)
        Me.AddFundsBtn.Name = "AddFundsBtn"
        Me.AddFundsBtn.Shape = New DevComponents.DotNetBar.RoundRectangleShapeDescriptor(0, 10, 0, 10)
        Me.AddFundsBtn.Size = New System.Drawing.Size(203, 152)
        Me.AddFundsBtn.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.AddFundsBtn.TabIndex = 82
        Me.AddFundsBtn.Text = "Add funds"
        Me.AddFundsBtn.TextColor = System.Drawing.Color.Black
        '
        'LabelX1
        '
        Me.LabelX1.AutoSize = True
        Me.LabelX1.BackColor = System.Drawing.Color.White
        '
        '
        '
        Me.LabelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX1.ForeColor = System.Drawing.Color.Black
        Me.LabelX1.Image = Global.PMD.My.Resources.Resources._1370904205_table_money
        Me.LabelX1.Location = New System.Drawing.Point(22, 29)
        Me.LabelX1.Name = "LabelX1"
        Me.LabelX1.Size = New System.Drawing.Size(134, 36)
        Me.LabelX1.TabIndex = 2
        Me.LabelX1.Text = "Accounts Summary:"
        Me.LabelX1.TextAlignment = System.Drawing.StringAlignment.Far
        '
        'NextBtn
        '
        Me.NextBtn.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.NextBtn.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.NextBtn.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.NextBtn.Enabled = False
        Me.NextBtn.Location = New System.Drawing.Point(719, 349)
        Me.NextBtn.Name = "NextBtn"
        Me.NextBtn.Size = New System.Drawing.Size(94, 23)
        Me.NextBtn.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.NextBtn.TabIndex = 1
        Me.NextBtn.Text = "Next >>"
        '
        'PreviousBtn
        '
        Me.PreviousBtn.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.PreviousBtn.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.PreviousBtn.Enabled = False
        Me.PreviousBtn.Location = New System.Drawing.Point(9, 349)
        Me.PreviousBtn.Name = "PreviousBtn"
        Me.PreviousBtn.Size = New System.Drawing.Size(94, 23)
        Me.PreviousBtn.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.PreviousBtn.TabIndex = 0
        Me.PreviousBtn.Text = "<< Previous"
        '
        'GroupBox2
        '
        Me.GroupBox2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox2.BackColor = System.Drawing.Color.White
        Me.GroupBox2.Controls.Add(Me.CalcNote2)
        Me.GroupBox2.Controls.Add(Me.CalcNote)
        Me.GroupBox2.Controls.Add(Me.TableLayoutPanel1)
        Me.GroupBox2.ForeColor = System.Drawing.Color.Black
        Me.GroupBox2.Location = New System.Drawing.Point(9, 41)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(599, 159)
        Me.GroupBox2.TabIndex = 69
        Me.GroupBox2.TabStop = False
        '
        'CalcNote2
        '
        Me.CalcNote2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CalcNote2.AutoSize = True
        Me.CalcNote2.BackColor = System.Drawing.Color.Transparent
        Me.CalcNote2.ForeColor = System.Drawing.Color.Black
        Me.CalcNote2.Location = New System.Drawing.Point(508, 86)
        Me.CalcNote2.Name = "CalcNote2"
        Me.CalcNote2.Size = New System.Drawing.Size(74, 13)
        Me.CalcNote2.TabIndex = 101
        Me.CalcNote2.Text = "Calculating..."
        Me.CalcNote2.Visible = False
        '
        'CalcNote
        '
        Me.CalcNote.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CalcNote.AutoSize = True
        Me.CalcNote.BackColor = System.Drawing.Color.Transparent
        Me.CalcNote.ForeColor = System.Drawing.Color.Black
        Me.CalcNote.Location = New System.Drawing.Point(223, 85)
        Me.CalcNote.Name = "CalcNote"
        Me.CalcNote.Size = New System.Drawing.Size(74, 13)
        Me.CalcNote.TabIndex = 102
        Me.CalcNote.Text = "Calculating..."
        Me.CalcNote.Visible = False
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel1.BackColor = System.Drawing.Color.Transparent
        Me.TableLayoutPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.TableLayoutPanel1.ColumnCount = 4
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 152.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 107.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 177.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.Label1, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.LatestPayedIn, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Label4, 2, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.ClosingBalance, 3, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.UnpaidLabel, 2, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.PayedOut, 3, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Label2, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.Label7, 2, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.Balance, 1, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.PayedIn, 1, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.Label3, 0, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.UnpaidBalance, 3, 2)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(13, 46)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 3
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 29.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(575, 88)
        Me.TableLayoutPanel1.TabIndex = 88
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.White
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(3, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(127, 13)
        Me.Label1.TabIndex = 88
        Me.Label1.Text = "Latest Deposit Amount:"
        '
        'LatestPayedIn
        '
        Me.LatestPayedIn.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LatestPayedIn.BackColor = System.Drawing.Color.White
        Me.LatestPayedIn.ForeColor = System.Drawing.Color.Black
        Me.LatestPayedIn.Location = New System.Drawing.Point(142, 3)
        Me.LatestPayedIn.Name = "LatestPayedIn"
        Me.LatestPayedIn.ReadOnly = True
        Me.LatestPayedIn.Size = New System.Drawing.Size(146, 22)
        Me.LatestPayedIn.TabIndex = 93
        Me.LatestPayedIn.Text = "£0.00"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.White
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(294, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(63, 13)
        Me.Label4.TabIndex = 95
        Me.Label4.Text = "Payed Out:"
        '
        'ClosingBalance
        '
        Me.ClosingBalance.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ClosingBalance.BackColor = System.Drawing.Color.White
        Me.ClosingBalance.ForeColor = System.Drawing.Color.Black
        Me.ClosingBalance.Location = New System.Drawing.Point(401, 34)
        Me.ClosingBalance.Name = "ClosingBalance"
        Me.ClosingBalance.ReadOnly = True
        Me.ClosingBalance.Size = New System.Drawing.Size(171, 22)
        Me.ClosingBalance.TabIndex = 98
        Me.ClosingBalance.Text = "£0.00"
        '
        'UnpaidLabel
        '
        Me.UnpaidLabel.AutoSize = True
        Me.UnpaidLabel.BackColor = System.Drawing.Color.White
        Me.UnpaidLabel.ForeColor = System.Drawing.Color.Black
        Me.UnpaidLabel.Location = New System.Drawing.Point(294, 59)
        Me.UnpaidLabel.Name = "UnpaidLabel"
        Me.UnpaidLabel.Size = New System.Drawing.Size(92, 13)
        Me.UnpaidLabel.TabIndex = 99
        Me.UnpaidLabel.Text = "Unpaid Amount:"
        '
        'PayedOut
        '
        Me.PayedOut.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PayedOut.BackColor = System.Drawing.Color.White
        Me.PayedOut.ForeColor = System.Drawing.Color.Black
        Me.PayedOut.Location = New System.Drawing.Point(401, 3)
        Me.PayedOut.Name = "PayedOut"
        Me.PayedOut.ReadOnly = True
        Me.PayedOut.Size = New System.Drawing.Size(171, 22)
        Me.PayedOut.TabIndex = 96
        Me.PayedOut.Text = "£0.00"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.White
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(3, 31)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(99, 13)
        Me.Label2.TabIndex = 89
        Me.Label2.Text = "Opening Balance:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.White
        Me.Label7.ForeColor = System.Drawing.Color.Black
        Me.Label7.Location = New System.Drawing.Point(294, 31)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(92, 13)
        Me.Label7.TabIndex = 97
        Me.Label7.Text = "Closing Balance:"
        '
        'Balance
        '
        Me.Balance.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Balance.BackColor = System.Drawing.Color.White
        Me.Balance.ForeColor = System.Drawing.Color.Black
        Me.Balance.Location = New System.Drawing.Point(142, 34)
        Me.Balance.Name = "Balance"
        Me.Balance.ReadOnly = True
        Me.Balance.Size = New System.Drawing.Size(146, 22)
        Me.Balance.TabIndex = 91
        Me.Balance.Text = "£0.00"
        '
        'PayedIn
        '
        Me.PayedIn.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PayedIn.BackColor = System.Drawing.Color.White
        Me.PayedIn.ForeColor = System.Drawing.Color.Black
        Me.PayedIn.Location = New System.Drawing.Point(142, 62)
        Me.PayedIn.Name = "PayedIn"
        Me.PayedIn.ReadOnly = True
        Me.PayedIn.Size = New System.Drawing.Size(146, 22)
        Me.PayedIn.TabIndex = 92
        Me.PayedIn.Text = "£0.00"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.White
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(3, 59)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(53, 13)
        Me.Label3.TabIndex = 90
        Me.Label3.Text = "Payed In:"
        '
        'UnpaidBalance
        '
        Me.UnpaidBalance.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.UnpaidBalance.BackColor = System.Drawing.Color.White
        Me.UnpaidBalance.ForeColor = System.Drawing.Color.Black
        Me.UnpaidBalance.Location = New System.Drawing.Point(401, 62)
        Me.UnpaidBalance.Name = "UnpaidBalance"
        Me.UnpaidBalance.ReadOnly = True
        Me.UnpaidBalance.Size = New System.Drawing.Size(171, 22)
        Me.UnpaidBalance.TabIndex = 100
        Me.UnpaidBalance.Text = "£0.00"
        '
        'FundSourceBalloonTip
        '
        Me.FundSourceBalloonTip.AlertAnimation = DevComponents.DotNetBar.eAlertAnimation.TopToBottom
        Me.FundSourceBalloonTip.CaptionIcon = CType(resources.GetObject("FundSourceBalloonTip.CaptionIcon"), System.Drawing.Icon)
        Me.FundSourceBalloonTip.ShowCloseButton = False
        Me.FundSourceBalloonTip.Style = DevComponents.DotNetBar.eBallonStyle.Office2007Alert
        '
        'AccountsForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(826, 718)
        Me.Controls.Add(Me.GroupBox1)
        Me.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MinimumSize = New System.Drawing.Size(800, 700)
        Me.Name = "AccountsForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Accounts"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.InvoicesGrid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents LabelX1 As DevComponents.DotNetBar.LabelX
    Friend WithEvents NextBtn As DevComponents.DotNetBar.ButtonX
    Friend WithEvents PreviousBtn As DevComponents.DotNetBar.ButtonX
    Friend WithEvents AddFundsBtn As DevComponents.DotNetBar.ButtonX
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents ToDate As System.Windows.Forms.Label
    Friend WithEvents FromDate As System.Windows.Forms.Label
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents PropertyNameCombo As System.Windows.Forms.ComboBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents GenerateBtn As DevComponents.DotNetBar.ButtonX
    Friend WithEvents StatementNote As System.Windows.Forms.Label
    Friend WithEvents InvoicesGrid As DevComponents.DotNetBar.Controls.DataGridViewX
    Friend WithEvents PaidInvoicesLabel As System.Windows.Forms.Label
    Friend WithEvents FundSourceBalloonTip As DevComponents.DotNetBar.BalloonTip
    Friend WithEvents ShowUnpaidChkBox As DevComponents.DotNetBar.Controls.CheckBoxX
    Friend WithEvents ShowPaidChkBox As DevComponents.DotNetBar.Controls.CheckBoxX
    Friend WithEvents CalcNote2 As System.Windows.Forms.Label
    Friend WithEvents CalcNote As System.Windows.Forms.Label
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents LatestPayedIn As PMD.CurrencyTextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents ClosingBalance As PMD.CurrencyTextBox
    Friend WithEvents UnpaidLabel As System.Windows.Forms.Label
    Friend WithEvents PayedOut As PMD.CurrencyTextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Balance As PMD.CurrencyTextBox
    Friend WithEvents PayedIn As PMD.CurrencyTextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents UnpaidBalance As PMD.CurrencyTextBox
    Friend WithEvents MonthCombo As System.Windows.Forms.ComboBox
    Friend WithEvents YearCombo As System.Windows.Forms.ComboBox
    Friend WithEvents StatementTypeCombo As DevComponents.DotNetBar.Controls.ComboBoxEx
    Friend WithEvents ItemMonthly As DevComponents.Editors.ComboItem
    Friend WithEvents ItemQuarterly As DevComponents.Editors.ComboItem
    Friend WithEvents ItemYearly As DevComponents.Editors.ComboItem
End Class
