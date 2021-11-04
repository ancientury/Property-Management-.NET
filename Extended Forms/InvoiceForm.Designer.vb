<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class InvoiceForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(InvoiceForm))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.InvoiceRef = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PaymentStatus = New System.Windows.Forms.ComboBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Contract = New System.Windows.Forms.Label()
        Me.LinkBtn = New System.Windows.Forms.Button()
        Me.Comments = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.ContactNumber = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.InvoiceType = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.PaymentDate = New System.Windows.Forms.DateTimePicker()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.PaymentMethod = New System.Windows.Forms.ComboBox()
        Me.PaymentType = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.InvoiceCompany = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.DocumentBrowser = New System.Windows.Forms.WebBrowser()
        Me.ScanBtn = New System.Windows.Forms.Button()
        Me.AttachBtn = New System.Windows.Forms.Button()
        Me.DocView = New System.Windows.Forms.ListView()
        Me.Filename = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.DateAdded = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Header = New System.Windows.Forms.Label()
        Me.BrowseFile = New System.Windows.Forms.OpenFileDialog()
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.CancelBtn = New System.Windows.Forms.Button()
        Me.DeleteBtn = New System.Windows.Forms.Button()
        Me.EditBtn = New System.Windows.Forms.Button()
        Me.OkBtn = New System.Windows.Forms.Button()
        Me.Amount = New PMD.CurrencyTextBox(Me.components)
        Me.GroupBox1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.BackColor = System.Drawing.Color.White
        Me.GroupBox1.Controls.Add(Me.InvoiceRef)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.PictureBox1)
        Me.GroupBox1.Controls.Add(Me.Amount)
        Me.GroupBox1.Controls.Add(Me.PaymentStatus)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.Contract)
        Me.GroupBox1.Controls.Add(Me.LinkBtn)
        Me.GroupBox1.Controls.Add(Me.Comments)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.ContactNumber)
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.InvoiceType)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.PaymentDate)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.PaymentMethod)
        Me.GroupBox1.Controls.Add(Me.PaymentType)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.InvoiceCompany)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.GroupBox2)
        Me.GroupBox1.Controls.Add(Me.ScanBtn)
        Me.GroupBox1.Controls.Add(Me.AttachBtn)
        Me.GroupBox1.Controls.Add(Me.DocView)
        Me.GroupBox1.Controls.Add(Me.Header)
        Me.GroupBox1.ForeColor = System.Drawing.Color.Black
        Me.GroupBox1.Location = New System.Drawing.Point(6, 4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(727, 674)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Invoice:"
        '
        'InvoiceRef
        '
        Me.InvoiceRef.BackColor = System.Drawing.Color.White
        Me.InvoiceRef.ForeColor = System.Drawing.Color.Black
        Me.InvoiceRef.Location = New System.Drawing.Point(102, 106)
        Me.InvoiceRef.Name = "InvoiceRef"
        Me.InvoiceRef.ReadOnly = True
        Me.InvoiceRef.Size = New System.Drawing.Size(266, 20)
        Me.InvoiceRef.TabIndex = 167
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.White
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.Black
        Me.Label10.Location = New System.Drawing.Point(6, 109)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(86, 13)
        Me.Label10.TabIndex = 166
        Me.Label10.Text = "Invoice Ref: *"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.White
        Me.PictureBox1.ForeColor = System.Drawing.Color.Black
        Me.PictureBox1.Image = Global.PMD.My.Resources.Resources._1371058292_invoice
        Me.PictureBox1.Location = New System.Drawing.Point(9, 32)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(64, 64)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox1.TabIndex = 165
        Me.PictureBox1.TabStop = False
        '
        'PaymentStatus
        '
        Me.PaymentStatus.BackColor = System.Drawing.Color.White
        Me.PaymentStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.PaymentStatus.Enabled = False
        Me.PaymentStatus.ForeColor = System.Drawing.Color.Black
        Me.PaymentStatus.FormattingEnabled = True
        Me.PaymentStatus.Items.AddRange(New Object() {"Paid", "Unpaid"})
        Me.PaymentStatus.Location = New System.Drawing.Point(102, 286)
        Me.PaymentStatus.Name = "PaymentStatus"
        Me.PaymentStatus.Size = New System.Drawing.Size(266, 21)
        Me.PaymentStatus.TabIndex = 163
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.White
        Me.Label9.ForeColor = System.Drawing.Color.Black
        Me.Label9.Location = New System.Drawing.Point(6, 289)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(91, 13)
        Me.Label9.TabIndex = 162
        Me.Label9.Text = "Payment Status: *"
        '
        'Contract
        '
        Me.Contract.AutoSize = True
        Me.Contract.BackColor = System.Drawing.Color.White
        Me.Contract.ForeColor = System.Drawing.Color.Black
        Me.Contract.Location = New System.Drawing.Point(99, 345)
        Me.Contract.Name = "Contract"
        Me.Contract.Size = New System.Drawing.Size(33, 13)
        Me.Contract.TabIndex = 161
        Me.Contract.Text = "None"
        '
        'LinkBtn
        '
        Me.LinkBtn.BackColor = System.Drawing.Color.White
        Me.LinkBtn.ForeColor = System.Drawing.Color.Black
        Me.LinkBtn.Location = New System.Drawing.Point(250, 369)
        Me.LinkBtn.Name = "LinkBtn"
        Me.LinkBtn.Size = New System.Drawing.Size(118, 23)
        Me.LinkBtn.TabIndex = 160
        Me.LinkBtn.Text = "Link Contract"
        Me.LinkBtn.UseVisualStyleBackColor = False
        '
        'Comments
        '
        Me.Comments.BackColor = System.Drawing.Color.White
        Me.Comments.ForeColor = System.Drawing.Color.Black
        Me.Comments.Location = New System.Drawing.Point(102, 441)
        Me.Comments.Multiline = True
        Me.Comments.Name = "Comments"
        Me.Comments.ReadOnly = True
        Me.Comments.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.Comments.Size = New System.Drawing.Size(266, 108)
        Me.Comments.TabIndex = 159
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.White
        Me.Label8.ForeColor = System.Drawing.Color.Black
        Me.Label8.Location = New System.Drawing.Point(6, 441)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(59, 13)
        Me.Label8.TabIndex = 158
        Me.Label8.Text = "Comments:"
        '
        'ContactNumber
        '
        Me.ContactNumber.BackColor = System.Drawing.Color.White
        Me.ContactNumber.ForeColor = System.Drawing.Color.Black
        Me.ContactNumber.Location = New System.Drawing.Point(102, 415)
        Me.ContactNumber.Name = "ContactNumber"
        Me.ContactNumber.ReadOnly = True
        Me.ContactNumber.Size = New System.Drawing.Size(266, 20)
        Me.ContactNumber.TabIndex = 156
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.Color.White
        Me.Label11.ForeColor = System.Drawing.Color.Black
        Me.Label11.Location = New System.Drawing.Point(6, 418)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(87, 13)
        Me.Label11.TabIndex = 157
        Me.Label11.Text = "Contact Number:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.White
        Me.Label7.ForeColor = System.Drawing.Color.Black
        Me.Label7.Location = New System.Drawing.Point(6, 345)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(85, 13)
        Me.Label7.TabIndex = 155
        Me.Label7.Text = "Linked Contract:"
        '
        'InvoiceType
        '
        Me.InvoiceType.BackColor = System.Drawing.Color.White
        Me.InvoiceType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.InvoiceType.Enabled = False
        Me.InvoiceType.ForeColor = System.Drawing.Color.Black
        Me.InvoiceType.FormattingEnabled = True
        Me.InvoiceType.Items.AddRange(New Object() {"One-off Invoice", "Contract Invoice"})
        Me.InvoiceType.Location = New System.Drawing.Point(102, 133)
        Me.InvoiceType.Name = "InvoiceType"
        Me.InvoiceType.Size = New System.Drawing.Size(266, 21)
        Me.InvoiceType.TabIndex = 154
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.White
        Me.Label6.ForeColor = System.Drawing.Color.Black
        Me.Label6.Location = New System.Drawing.Point(6, 136)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(79, 13)
        Me.Label6.TabIndex = 153
        Me.Label6.Text = "Invoice Type: *"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.White
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(6, 259)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(90, 13)
        Me.Label5.TabIndex = 152
        Me.Label5.Text = "Payment Amount:"
        '
        'PaymentDate
        '
        Me.PaymentDate.BackColor = System.Drawing.Color.White
        Me.PaymentDate.Enabled = False
        Me.PaymentDate.ForeColor = System.Drawing.Color.Black
        Me.PaymentDate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.PaymentDate.Location = New System.Drawing.Point(102, 313)
        Me.PaymentDate.MinDate = New Date(2000, 1, 1, 0, 0, 0, 0)
        Me.PaymentDate.Name = "PaymentDate"
        Me.PaymentDate.Size = New System.Drawing.Size(266, 20)
        Me.PaymentDate.TabIndex = 151
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.White
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(6, 317)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(77, 13)
        Me.Label4.TabIndex = 150
        Me.Label4.Text = "Payment Date:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.White
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(6, 196)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(85, 13)
        Me.Label3.TabIndex = 149
        Me.Label3.Text = "Payment Type: *"
        '
        'PaymentMethod
        '
        Me.PaymentMethod.BackColor = System.Drawing.Color.White
        Me.PaymentMethod.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.PaymentMethod.Enabled = False
        Me.PaymentMethod.ForeColor = System.Drawing.Color.Black
        Me.PaymentMethod.FormattingEnabled = True
        Me.PaymentMethod.Items.AddRange(New Object() {"One-Time", "Weekly", "Monthly", "Yearly"})
        Me.PaymentMethod.Location = New System.Drawing.Point(102, 223)
        Me.PaymentMethod.Name = "PaymentMethod"
        Me.PaymentMethod.Size = New System.Drawing.Size(266, 21)
        Me.PaymentMethod.TabIndex = 148
        '
        'PaymentType
        '
        Me.PaymentType.BackColor = System.Drawing.Color.White
        Me.PaymentType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.PaymentType.Enabled = False
        Me.PaymentType.ForeColor = System.Drawing.Color.Black
        Me.PaymentType.FormattingEnabled = True
        Me.PaymentType.Items.AddRange(New Object() {"Direct Debit", "Standing Order", "Cheque"})
        Me.PaymentType.Location = New System.Drawing.Point(102, 193)
        Me.PaymentType.Name = "PaymentType"
        Me.PaymentType.Size = New System.Drawing.Size(266, 21)
        Me.PaymentType.TabIndex = 147
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.White
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(6, 226)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(97, 13)
        Me.Label2.TabIndex = 146
        Me.Label2.Text = "Payment Method: *"
        '
        'InvoiceCompany
        '
        Me.InvoiceCompany.BackColor = System.Drawing.Color.White
        Me.InvoiceCompany.ForeColor = System.Drawing.Color.Black
        Me.InvoiceCompany.Location = New System.Drawing.Point(102, 163)
        Me.InvoiceCompany.Name = "InvoiceCompany"
        Me.InvoiceCompany.ReadOnly = True
        Me.InvoiceCompany.Size = New System.Drawing.Size(266, 20)
        Me.InvoiceCompany.TabIndex = 145
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.White
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(6, 166)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(61, 13)
        Me.Label1.TabIndex = 144
        Me.Label1.Text = "Company: *"
        '
        'GroupBox2
        '
        Me.GroupBox2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox2.BackColor = System.Drawing.Color.White
        Me.GroupBox2.Controls.Add(Me.DocumentBrowser)
        Me.GroupBox2.ForeColor = System.Drawing.Color.Black
        Me.GroupBox2.Location = New System.Drawing.Point(377, 29)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(344, 526)
        Me.GroupBox2.TabIndex = 124
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Document Preview:"
        '
        'DocumentBrowser
        '
        Me.DocumentBrowser.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DocumentBrowser.Location = New System.Drawing.Point(3, 16)
        Me.DocumentBrowser.MinimumSize = New System.Drawing.Size(20, 20)
        Me.DocumentBrowser.Name = "DocumentBrowser"
        Me.DocumentBrowser.Size = New System.Drawing.Size(338, 507)
        Me.DocumentBrowser.TabIndex = 3
        '
        'ScanBtn
        '
        Me.ScanBtn.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.ScanBtn.BackColor = System.Drawing.Color.White
        Me.ScanBtn.Cursor = System.Windows.Forms.Cursors.Default
        Me.ScanBtn.ForeColor = System.Drawing.Color.Black
        Me.ScanBtn.Image = Global.PMD.My.Resources.Resources._1366227956_magnifier_left
        Me.ScanBtn.Location = New System.Drawing.Point(6, 641)
        Me.ScanBtn.Name = "ScanBtn"
        Me.ScanBtn.Size = New System.Drawing.Size(142, 25)
        Me.ScanBtn.TabIndex = 35
        Me.ScanBtn.Text = "Scan a Document"
        Me.ScanBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ScanBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.ScanBtn.UseVisualStyleBackColor = False
        Me.ScanBtn.Visible = False
        '
        'AttachBtn
        '
        Me.AttachBtn.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.AttachBtn.BackColor = System.Drawing.Color.White
        Me.AttachBtn.Cursor = System.Windows.Forms.Cursors.Default
        Me.AttachBtn.ForeColor = System.Drawing.Color.Black
        Me.AttachBtn.Image = Global.PMD.My.Resources.Resources._1366094754_attach
        Me.AttachBtn.Location = New System.Drawing.Point(593, 641)
        Me.AttachBtn.Name = "AttachBtn"
        Me.AttachBtn.Size = New System.Drawing.Size(128, 25)
        Me.AttachBtn.TabIndex = 31
        Me.AttachBtn.Text = "Attach Document"
        Me.AttachBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.AttachBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.AttachBtn.UseVisualStyleBackColor = False
        Me.AttachBtn.Visible = False
        '
        'DocView
        '
        Me.DocView.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DocView.BackColor = System.Drawing.Color.White
        Me.DocView.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.Filename, Me.DateAdded})
        Me.DocView.ForeColor = System.Drawing.Color.Black
        Me.DocView.FullRowSelect = True
        Me.DocView.HideSelection = False
        Me.DocView.Location = New System.Drawing.Point(6, 571)
        Me.DocView.MultiSelect = False
        Me.DocView.Name = "DocView"
        Me.DocView.Size = New System.Drawing.Size(715, 64)
        Me.DocView.TabIndex = 2
        Me.DocView.UseCompatibleStateImageBehavior = False
        Me.DocView.View = System.Windows.Forms.View.Details
        '
        'Filename
        '
        Me.Filename.Text = "Filename"
        Me.Filename.Width = 344
        '
        'DateAdded
        '
        Me.DateAdded.Text = "Date Added"
        Me.DateAdded.Width = 343
        '
        'Header
        '
        Me.Header.BackColor = System.Drawing.Color.White
        Me.Header.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Header.ForeColor = System.Drawing.Color.Black
        Me.Header.Location = New System.Drawing.Point(6, 29)
        Me.Header.Name = "Header"
        Me.Header.Padding = New System.Windows.Forms.Padding(100, 0, 0, 0)
        Me.Header.Size = New System.Drawing.Size(362, 70)
        Me.Header.TabIndex = 33
        Me.Header.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'ImageList1
        '
        Me.ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        Me.ImageList1.Images.SetKeyName(0, "1366584947_attach.png")
        Me.ImageList1.Images.SetKeyName(1, "1366094754_attach.png")
        '
        'CancelBtn
        '
        Me.CancelBtn.BackColor = System.Drawing.Color.White
        Me.CancelBtn.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.CancelBtn.ForeColor = System.Drawing.Color.Black
        Me.CancelBtn.Image = Global.PMD.My.Resources.Resources._1364511183_dialog_close
        Me.CancelBtn.Location = New System.Drawing.Point(483, 684)
        Me.CancelBtn.Name = "CancelBtn"
        Me.CancelBtn.Size = New System.Drawing.Size(122, 26)
        Me.CancelBtn.TabIndex = 31
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
        Me.DeleteBtn.Location = New System.Drawing.Point(340, 684)
        Me.DeleteBtn.Name = "DeleteBtn"
        Me.DeleteBtn.Size = New System.Drawing.Size(137, 27)
        Me.DeleteBtn.TabIndex = 38
        Me.DeleteBtn.Text = "Delete Invoice"
        Me.DeleteBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.DeleteBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.DeleteBtn.UseVisualStyleBackColor = False
        Me.DeleteBtn.Visible = False
        '
        'EditBtn
        '
        Me.EditBtn.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.EditBtn.BackColor = System.Drawing.Color.White
        Me.EditBtn.ForeColor = System.Drawing.Color.Black
        Me.EditBtn.Image = Global.PMD.My.Resources.Resources._1364946094_pencil_16
        Me.EditBtn.Location = New System.Drawing.Point(483, 684)
        Me.EditBtn.Name = "EditBtn"
        Me.EditBtn.Size = New System.Drawing.Size(122, 26)
        Me.EditBtn.TabIndex = 30
        Me.EditBtn.Text = "Edit"
        Me.EditBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.EditBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.EditBtn.UseVisualStyleBackColor = False
        '
        'OkBtn
        '
        Me.OkBtn.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.OkBtn.BackColor = System.Drawing.Color.White
        Me.OkBtn.ForeColor = System.Drawing.Color.Black
        Me.OkBtn.Image = Global.PMD.My.Resources.Resources._1364677427_tick
        Me.OkBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.OkBtn.Location = New System.Drawing.Point(611, 684)
        Me.OkBtn.Name = "OkBtn"
        Me.OkBtn.Size = New System.Drawing.Size(122, 26)
        Me.OkBtn.TabIndex = 29
        Me.OkBtn.Text = "OK"
        Me.OkBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.OkBtn.UseVisualStyleBackColor = False
        '
        'Amount
        '
        Me.Amount.BackColor = System.Drawing.Color.White
        Me.Amount.ForeColor = System.Drawing.Color.Black
        Me.Amount.Location = New System.Drawing.Point(102, 256)
        Me.Amount.Name = "Amount"
        Me.Amount.Size = New System.Drawing.Size(266, 20)
        Me.Amount.TabIndex = 164
        Me.Amount.Text = "£0.00"
        '
        'InvoiceForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.CancelBtn
        Me.ClientSize = New System.Drawing.Size(738, 716)
        Me.Controls.Add(Me.DeleteBtn)
        Me.Controls.Add(Me.CancelBtn)
        Me.Controls.Add(Me.EditBtn)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.OkBtn)
        Me.MinimumSize = New System.Drawing.Size(754, 754)
        Me.Name = "InvoiceForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "New Invoice - "
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents DocView As System.Windows.Forms.ListView
    Friend WithEvents Filename As System.Windows.Forms.ColumnHeader
    Friend WithEvents DateAdded As System.Windows.Forms.ColumnHeader
    Friend WithEvents EditBtn As System.Windows.Forms.Button
    Friend WithEvents OkBtn As System.Windows.Forms.Button
    Friend WithEvents AttachBtn As System.Windows.Forms.Button
    Friend WithEvents BrowseFile As System.Windows.Forms.OpenFileDialog
    Friend WithEvents Header As System.Windows.Forms.Label
    Friend WithEvents ScanBtn As System.Windows.Forms.Button
    Friend WithEvents ImageList1 As System.Windows.Forms.ImageList
    Friend WithEvents CancelBtn As System.Windows.Forms.Button
    Friend WithEvents DeleteBtn As System.Windows.Forms.Button
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents DocumentBrowser As System.Windows.Forms.WebBrowser
    Friend WithEvents Amount As PMD.CurrencyTextBox
    Friend WithEvents PaymentStatus As System.Windows.Forms.ComboBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Contract As System.Windows.Forms.Label
    Friend WithEvents LinkBtn As System.Windows.Forms.Button
    Friend WithEvents Comments As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents ContactNumber As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents InvoiceType As System.Windows.Forms.ComboBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents PaymentDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents PaymentMethod As System.Windows.Forms.ComboBox
    Friend WithEvents PaymentType As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents InvoiceCompany As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents InvoiceRef As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
End Class
