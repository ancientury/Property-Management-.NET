<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SearchForm
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.SearchBy = New DevComponents.DotNetBar.Controls.ComboBoxEx()
        Me.ComboItem4 = New DevComponents.Editors.ComboItem()
        Me.ComboItem5 = New DevComponents.Editors.ComboItem()
        Me.ComboItem6 = New DevComponents.Editors.ComboItem()
        Me.SearchIn = New DevComponents.DotNetBar.Controls.ComboBoxEx()
        Me.ComboItem1 = New DevComponents.Editors.ComboItem()
        Me.ComboItem2 = New DevComponents.Editors.ComboItem()
        Me.ComboItem3 = New DevComponents.Editors.ComboItem()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.SearchText = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.SearchGrid = New DevComponents.DotNetBar.Controls.DataGridViewX()
        Me.ViewBtn = New DevComponents.DotNetBar.ButtonX()
        Me.ViewPropertyBtn = New DevComponents.DotNetBar.ButtonX()
        Me.SearchBtn = New DevComponents.DotNetBar.ButtonX()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.SearchGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.White
        Me.GroupBox1.Controls.Add(Me.SearchBy)
        Me.GroupBox1.Controls.Add(Me.SearchIn)
        Me.GroupBox1.Controls.Add(Me.SearchBtn)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.SearchText)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.GroupBox2)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupBox1.ForeColor = System.Drawing.Color.Black
        Me.GroupBox1.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(800, 158)
        Me.GroupBox1.TabIndex = 4
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Search:"
        '
        'SearchBy
        '
        Me.SearchBy.DisplayMember = "Text"
        Me.SearchBy.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.SearchBy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.SearchBy.ForeColor = System.Drawing.Color.Black
        Me.SearchBy.FormattingEnabled = True
        Me.SearchBy.ItemHeight = 14
        Me.SearchBy.Items.AddRange(New Object() {Me.ComboItem4, Me.ComboItem5, Me.ComboItem6})
        Me.SearchBy.Location = New System.Drawing.Point(79, 59)
        Me.SearchBy.Name = "SearchBy"
        Me.SearchBy.Size = New System.Drawing.Size(310, 20)
        Me.SearchBy.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.SearchBy.TabIndex = 10
        '
        'ComboItem4
        '
        Me.ComboItem4.Text = "Property ID"
        '
        'ComboItem5
        '
        Me.ComboItem5.Text = "Contract ID"
        '
        'ComboItem6
        '
        Me.ComboItem6.Text = "Invoice ID"
        '
        'SearchIn
        '
        Me.SearchIn.DisplayMember = "Text"
        Me.SearchIn.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.SearchIn.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.SearchIn.ForeColor = System.Drawing.Color.Black
        Me.SearchIn.FormattingEnabled = True
        Me.SearchIn.ItemHeight = 14
        Me.SearchIn.Items.AddRange(New Object() {Me.ComboItem1, Me.ComboItem2, Me.ComboItem3})
        Me.SearchIn.Location = New System.Drawing.Point(79, 27)
        Me.SearchIn.Name = "SearchIn"
        Me.SearchIn.Size = New System.Drawing.Size(310, 20)
        Me.SearchIn.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.SearchIn.TabIndex = 9
        '
        'ComboItem1
        '
        Me.ComboItem1.Text = "Properties"
        '
        'ComboItem2
        '
        Me.ComboItem2.Text = "Contracts"
        '
        'ComboItem3
        '
        Me.ComboItem3.Text = "Invoices"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.White
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(9, 66)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(58, 13)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Search by:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.White
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(9, 34)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(59, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Search for:"
        '
        'SearchText
        '
        Me.SearchText.BackColor = System.Drawing.Color.White
        Me.SearchText.ForeColor = System.Drawing.Color.Black
        Me.SearchText.Location = New System.Drawing.Point(79, 95)
        Me.SearchText.Name = "SearchText"
        Me.SearchText.Size = New System.Drawing.Size(310, 20)
        Me.SearchText.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.White
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(9, 98)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(64, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Search text:"
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.White
        Me.GroupBox2.Controls.Add(Me.CheckBox1)
        Me.GroupBox2.ForeColor = System.Drawing.Color.Black
        Me.GroupBox2.Location = New System.Drawing.Point(395, 9)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(397, 105)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Search Options:"
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.BackColor = System.Drawing.Color.White
        Me.CheckBox1.ForeColor = System.Drawing.Color.Black
        Me.CheckBox1.Location = New System.Drawing.Point(31, 26)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(167, 17)
        Me.CheckBox1.TabIndex = 0
        Me.CheckBox1.Text = "Perform case-sensitive search"
        Me.CheckBox1.UseVisualStyleBackColor = False
        '
        'SearchGrid
        '
        Me.SearchGrid.AllowUserToAddRows = False
        Me.SearchGrid.AllowUserToDeleteRows = False
        Me.SearchGrid.AllowUserToOrderColumns = True
        Me.SearchGrid.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SearchGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells
        Me.SearchGrid.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells
        Me.SearchGrid.BackgroundColor = System.Drawing.Color.White
        Me.SearchGrid.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.SearchGrid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black
        Me.SearchGrid.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.SearchGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.SearchGrid.DefaultCellStyle = DataGridViewCellStyle2
        Me.SearchGrid.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.SearchGrid.EnableHeadersVisualStyles = False
        Me.SearchGrid.GridColor = System.Drawing.Color.FromArgb(CType(CType(170, Byte), Integer), CType(CType(170, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.SearchGrid.Location = New System.Drawing.Point(0, 164)
        Me.SearchGrid.MultiSelect = False
        Me.SearchGrid.Name = "SearchGrid"
        Me.SearchGrid.ReadOnly = True
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black
        Me.SearchGrid.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.SearchGrid.RowHeadersVisible = False
        Me.SearchGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.SearchGrid.Size = New System.Drawing.Size(800, 382)
        Me.SearchGrid.TabIndex = 62
        Me.SearchGrid.TabStop = False
        '
        'ViewBtn
        '
        Me.ViewBtn.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.ViewBtn.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.ViewBtn.Image = Global.PMD.My.Resources.Resources._1367010962_application_view_detail
        Me.ViewBtn.Location = New System.Drawing.Point(489, 552)
        Me.ViewBtn.Name = "ViewBtn"
        Me.ViewBtn.Size = New System.Drawing.Size(147, 26)
        Me.ViewBtn.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.ViewBtn.TabIndex = 64
        Me.ViewBtn.Text = "View "
        Me.ViewBtn.Visible = False
        '
        'ViewPropertyBtn
        '
        Me.ViewPropertyBtn.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.ViewPropertyBtn.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.ViewPropertyBtn.Enabled = False
        Me.ViewPropertyBtn.Image = Global.PMD.My.Resources.Resources._1367010776_Home
        Me.ViewPropertyBtn.Location = New System.Drawing.Point(642, 552)
        Me.ViewPropertyBtn.Name = "ViewPropertyBtn"
        Me.ViewPropertyBtn.Size = New System.Drawing.Size(158, 26)
        Me.ViewPropertyBtn.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.ViewPropertyBtn.TabIndex = 63
        Me.ViewPropertyBtn.Text = "View Property"
        '
        'SearchBtn
        '
        Me.SearchBtn.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.SearchBtn.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.SearchBtn.Image = Global.PMD.My.Resources.Resources._1366156454_Magnifier2
        Me.SearchBtn.Location = New System.Drawing.Point(12, 121)
        Me.SearchBtn.Name = "SearchBtn"
        Me.SearchBtn.Size = New System.Drawing.Size(377, 28)
        Me.SearchBtn.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.SearchBtn.TabIndex = 8
        Me.SearchBtn.Text = "Search"
        '
        'SearchForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 578)
        Me.Controls.Add(Me.ViewBtn)
        Me.Controls.Add(Me.ViewPropertyBtn)
        Me.Controls.Add(Me.SearchGrid)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "SearchForm"
        Me.Text = "Search"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.SearchGrid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents SearchText As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents CheckBox1 As System.Windows.Forms.CheckBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents SearchBtn As DevComponents.DotNetBar.ButtonX
    Friend WithEvents SearchGrid As DevComponents.DotNetBar.Controls.DataGridViewX
    Friend WithEvents ViewPropertyBtn As DevComponents.DotNetBar.ButtonX
    Friend WithEvents ViewBtn As DevComponents.DotNetBar.ButtonX
    Friend WithEvents SearchBy As DevComponents.DotNetBar.Controls.ComboBoxEx
    Friend WithEvents ComboItem4 As DevComponents.Editors.ComboItem
    Friend WithEvents ComboItem5 As DevComponents.Editors.ComboItem
    Friend WithEvents ComboItem6 As DevComponents.Editors.ComboItem
    Friend WithEvents SearchIn As DevComponents.DotNetBar.Controls.ComboBoxEx
    Friend WithEvents ComboItem1 As DevComponents.Editors.ComboItem
    Friend WithEvents ComboItem2 As DevComponents.Editors.ComboItem
    Friend WithEvents ComboItem3 As DevComponents.Editors.ComboItem
End Class
