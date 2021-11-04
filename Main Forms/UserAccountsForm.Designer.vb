<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UserAccountsForm
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
        Me.GroupBox6 = New System.Windows.Forms.GroupBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.M_GrantAll = New System.Windows.Forms.CheckBox()
        Me.M_GrantDelete = New System.Windows.Forms.CheckBox()
        Me.M_GrantUpdate = New System.Windows.Forms.CheckBox()
        Me.M_GrantInsert = New System.Windows.Forms.CheckBox()
        Me.M_GrantSelect = New System.Windows.Forms.CheckBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.M_Password = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.M_Name = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.M_CreateAccount = New System.Windows.Forms.Button()
        Me.M_GrantAll2 = New System.Windows.Forms.CheckBox()
        Me.M_GrantDelete2 = New System.Windows.Forms.CheckBox()
        Me.M_GrantUpdate2 = New System.Windows.Forms.CheckBox()
        Me.M_GrantInsert2 = New System.Windows.Forms.CheckBox()
        Me.M_GrantSelect2 = New System.Windows.Forms.CheckBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.M_ModifyPrivileges = New System.Windows.Forms.Button()
        Me.M_DeleteAccount = New System.Windows.Forms.Button()
        Me.AccountsGrid = New System.Windows.Forms.DataGridView()
        Me.GroupBox6.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AccountsGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox6
        '
        Me.GroupBox6.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox6.BackColor = System.Drawing.Color.White
        Me.GroupBox6.Controls.Add(Me.PictureBox1)
        Me.GroupBox6.Controls.Add(Me.M_GrantAll)
        Me.GroupBox6.Controls.Add(Me.M_GrantDelete)
        Me.GroupBox6.Controls.Add(Me.M_GrantUpdate)
        Me.GroupBox6.Controls.Add(Me.M_GrantInsert)
        Me.GroupBox6.Controls.Add(Me.M_GrantSelect)
        Me.GroupBox6.Controls.Add(Me.Label12)
        Me.GroupBox6.Controls.Add(Me.M_Password)
        Me.GroupBox6.Controls.Add(Me.Label11)
        Me.GroupBox6.Controls.Add(Me.M_Name)
        Me.GroupBox6.Controls.Add(Me.Label10)
        Me.GroupBox6.Controls.Add(Me.M_CreateAccount)
        Me.GroupBox6.Controls.Add(Me.M_GrantAll2)
        Me.GroupBox6.Controls.Add(Me.M_GrantDelete2)
        Me.GroupBox6.Controls.Add(Me.M_GrantUpdate2)
        Me.GroupBox6.Controls.Add(Me.M_GrantInsert2)
        Me.GroupBox6.Controls.Add(Me.M_GrantSelect2)
        Me.GroupBox6.Controls.Add(Me.Label13)
        Me.GroupBox6.Controls.Add(Me.M_ModifyPrivileges)
        Me.GroupBox6.Controls.Add(Me.M_DeleteAccount)
        Me.GroupBox6.Controls.Add(Me.AccountsGrid)
        Me.GroupBox6.ForeColor = System.Drawing.Color.Black
        Me.GroupBox6.Location = New System.Drawing.Point(2, 12)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Size = New System.Drawing.Size(838, 645)
        Me.GroupBox6.TabIndex = 4
        Me.GroupBox6.TabStop = False
        Me.GroupBox6.Text = "User Accounts:"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.White
        Me.PictureBox1.ForeColor = System.Drawing.Color.Black
        Me.PictureBox1.Image = Global.PMD.My.Resources.Resources._1370545311_contact_new
        Me.PictureBox1.Location = New System.Drawing.Point(145, 140)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(72, 72)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox1.TabIndex = 30
        Me.PictureBox1.TabStop = False
        '
        'M_GrantAll
        '
        Me.M_GrantAll.AutoSize = True
        Me.M_GrantAll.BackColor = System.Drawing.Color.White
        Me.M_GrantAll.ForeColor = System.Drawing.Color.Black
        Me.M_GrantAll.Location = New System.Drawing.Point(149, 389)
        Me.M_GrantAll.Name = "M_GrantAll"
        Me.M_GrantAll.Size = New System.Drawing.Size(135, 17)
        Me.M_GrantAll.TabIndex = 29
        Me.M_GrantAll.Text = "Grant ALL PRIVILEGES"
        Me.M_GrantAll.UseVisualStyleBackColor = False
        '
        'M_GrantDelete
        '
        Me.M_GrantDelete.AutoSize = True
        Me.M_GrantDelete.BackColor = System.Drawing.Color.White
        Me.M_GrantDelete.ForeColor = System.Drawing.Color.Black
        Me.M_GrantDelete.Location = New System.Drawing.Point(149, 367)
        Me.M_GrantDelete.Name = "M_GrantDelete"
        Me.M_GrantDelete.Size = New System.Drawing.Size(94, 17)
        Me.M_GrantDelete.TabIndex = 28
        Me.M_GrantDelete.Text = "Grant DELETE"
        Me.M_GrantDelete.UseVisualStyleBackColor = False
        '
        'M_GrantUpdate
        '
        Me.M_GrantUpdate.AutoSize = True
        Me.M_GrantUpdate.BackColor = System.Drawing.Color.White
        Me.M_GrantUpdate.ForeColor = System.Drawing.Color.Black
        Me.M_GrantUpdate.Location = New System.Drawing.Point(48, 412)
        Me.M_GrantUpdate.Name = "M_GrantUpdate"
        Me.M_GrantUpdate.Size = New System.Drawing.Size(98, 17)
        Me.M_GrantUpdate.TabIndex = 27
        Me.M_GrantUpdate.Text = "Grant UPDATE"
        Me.M_GrantUpdate.UseVisualStyleBackColor = False
        '
        'M_GrantInsert
        '
        Me.M_GrantInsert.AutoSize = True
        Me.M_GrantInsert.BackColor = System.Drawing.Color.White
        Me.M_GrantInsert.Checked = True
        Me.M_GrantInsert.CheckState = System.Windows.Forms.CheckState.Checked
        Me.M_GrantInsert.ForeColor = System.Drawing.Color.Black
        Me.M_GrantInsert.Location = New System.Drawing.Point(48, 389)
        Me.M_GrantInsert.Name = "M_GrantInsert"
        Me.M_GrantInsert.Size = New System.Drawing.Size(93, 17)
        Me.M_GrantInsert.TabIndex = 26
        Me.M_GrantInsert.Text = "Grant INSERT"
        Me.M_GrantInsert.UseVisualStyleBackColor = False
        '
        'M_GrantSelect
        '
        Me.M_GrantSelect.AutoSize = True
        Me.M_GrantSelect.BackColor = System.Drawing.Color.White
        Me.M_GrantSelect.Checked = True
        Me.M_GrantSelect.CheckState = System.Windows.Forms.CheckState.Checked
        Me.M_GrantSelect.Enabled = False
        Me.M_GrantSelect.ForeColor = System.Drawing.Color.Black
        Me.M_GrantSelect.Location = New System.Drawing.Point(48, 367)
        Me.M_GrantSelect.Name = "M_GrantSelect"
        Me.M_GrantSelect.Size = New System.Drawing.Size(93, 17)
        Me.M_GrantSelect.TabIndex = 25
        Me.M_GrantSelect.Text = "Grant SELECT"
        Me.M_GrantSelect.UseVisualStyleBackColor = False
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.BackColor = System.Drawing.Color.White
        Me.Label12.ForeColor = System.Drawing.Color.Black
        Me.Label12.Location = New System.Drawing.Point(13, 336)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(129, 13)
        Me.Label12.TabIndex = 24
        Me.Label12.Text = "Account user privileges:"
        '
        'M_Password
        '
        Me.M_Password.BackColor = System.Drawing.Color.White
        Me.M_Password.ForeColor = System.Drawing.Color.Black
        Me.M_Password.Location = New System.Drawing.Point(124, 296)
        Me.M_Password.Name = "M_Password"
        Me.M_Password.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.M_Password.Size = New System.Drawing.Size(236, 22)
        Me.M_Password.TabIndex = 23
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.Color.White
        Me.Label11.ForeColor = System.Drawing.Color.Black
        Me.Label11.Location = New System.Drawing.Point(13, 299)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(105, 13)
        Me.Label11.TabIndex = 22
        Me.Label11.Text = "Account password:"
        '
        'M_Name
        '
        Me.M_Name.BackColor = System.Drawing.Color.White
        Me.M_Name.ForeColor = System.Drawing.Color.Black
        Me.M_Name.Location = New System.Drawing.Point(124, 258)
        Me.M_Name.Name = "M_Name"
        Me.M_Name.Size = New System.Drawing.Size(236, 22)
        Me.M_Name.TabIndex = 21
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.White
        Me.Label10.ForeColor = System.Drawing.Color.Black
        Me.Label10.Location = New System.Drawing.Point(13, 261)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(83, 13)
        Me.Label10.TabIndex = 20
        Me.Label10.Text = "Account name:"
        '
        'M_CreateAccount
        '
        Me.M_CreateAccount.BackColor = System.Drawing.Color.White
        Me.M_CreateAccount.ForeColor = System.Drawing.Color.Black
        Me.M_CreateAccount.Location = New System.Drawing.Point(218, 441)
        Me.M_CreateAccount.Name = "M_CreateAccount"
        Me.M_CreateAccount.Size = New System.Drawing.Size(142, 34)
        Me.M_CreateAccount.TabIndex = 19
        Me.M_CreateAccount.Text = "Create account"
        Me.M_CreateAccount.UseVisualStyleBackColor = False
        '
        'M_GrantAll2
        '
        Me.M_GrantAll2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.M_GrantAll2.AutoSize = True
        Me.M_GrantAll2.BackColor = System.Drawing.Color.White
        Me.M_GrantAll2.ForeColor = System.Drawing.Color.Black
        Me.M_GrantAll2.Location = New System.Drawing.Point(497, 539)
        Me.M_GrantAll2.Name = "M_GrantAll2"
        Me.M_GrantAll2.Size = New System.Drawing.Size(135, 17)
        Me.M_GrantAll2.TabIndex = 18
        Me.M_GrantAll2.Text = "Grant ALL PRIVILEGES"
        Me.M_GrantAll2.UseVisualStyleBackColor = False
        '
        'M_GrantDelete2
        '
        Me.M_GrantDelete2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.M_GrantDelete2.AutoSize = True
        Me.M_GrantDelete2.BackColor = System.Drawing.Color.White
        Me.M_GrantDelete2.ForeColor = System.Drawing.Color.Black
        Me.M_GrantDelete2.Location = New System.Drawing.Point(497, 516)
        Me.M_GrantDelete2.Name = "M_GrantDelete2"
        Me.M_GrantDelete2.Size = New System.Drawing.Size(94, 17)
        Me.M_GrantDelete2.TabIndex = 16
        Me.M_GrantDelete2.Text = "Grant DELETE"
        Me.M_GrantDelete2.UseVisualStyleBackColor = False
        '
        'M_GrantUpdate2
        '
        Me.M_GrantUpdate2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.M_GrantUpdate2.AutoSize = True
        Me.M_GrantUpdate2.BackColor = System.Drawing.Color.White
        Me.M_GrantUpdate2.ForeColor = System.Drawing.Color.Black
        Me.M_GrantUpdate2.Location = New System.Drawing.Point(392, 563)
        Me.M_GrantUpdate2.Name = "M_GrantUpdate2"
        Me.M_GrantUpdate2.Size = New System.Drawing.Size(98, 17)
        Me.M_GrantUpdate2.TabIndex = 15
        Me.M_GrantUpdate2.Text = "Grant UPDATE"
        Me.M_GrantUpdate2.UseVisualStyleBackColor = False
        '
        'M_GrantInsert2
        '
        Me.M_GrantInsert2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.M_GrantInsert2.AutoSize = True
        Me.M_GrantInsert2.BackColor = System.Drawing.Color.White
        Me.M_GrantInsert2.Checked = True
        Me.M_GrantInsert2.CheckState = System.Windows.Forms.CheckState.Checked
        Me.M_GrantInsert2.ForeColor = System.Drawing.Color.Black
        Me.M_GrantInsert2.Location = New System.Drawing.Point(392, 539)
        Me.M_GrantInsert2.Name = "M_GrantInsert2"
        Me.M_GrantInsert2.Size = New System.Drawing.Size(93, 17)
        Me.M_GrantInsert2.TabIndex = 14
        Me.M_GrantInsert2.Text = "Grant INSERT"
        Me.M_GrantInsert2.UseVisualStyleBackColor = False
        '
        'M_GrantSelect2
        '
        Me.M_GrantSelect2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.M_GrantSelect2.AutoSize = True
        Me.M_GrantSelect2.BackColor = System.Drawing.Color.White
        Me.M_GrantSelect2.Checked = True
        Me.M_GrantSelect2.CheckState = System.Windows.Forms.CheckState.Checked
        Me.M_GrantSelect2.Enabled = False
        Me.M_GrantSelect2.ForeColor = System.Drawing.Color.Black
        Me.M_GrantSelect2.Location = New System.Drawing.Point(392, 516)
        Me.M_GrantSelect2.Name = "M_GrantSelect2"
        Me.M_GrantSelect2.Size = New System.Drawing.Size(93, 17)
        Me.M_GrantSelect2.TabIndex = 13
        Me.M_GrantSelect2.Text = "Grant SELECT"
        Me.M_GrantSelect2.UseVisualStyleBackColor = False
        '
        'Label13
        '
        Me.Label13.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label13.AutoSize = True
        Me.Label13.BackColor = System.Drawing.Color.White
        Me.Label13.ForeColor = System.Drawing.Color.Black
        Me.Label13.Location = New System.Drawing.Point(389, 489)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(104, 13)
        Me.Label13.TabIndex = 12
        Me.Label13.Text = "Account privileges:"
        '
        'M_ModifyPrivileges
        '
        Me.M_ModifyPrivileges.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.M_ModifyPrivileges.BackColor = System.Drawing.Color.White
        Me.M_ModifyPrivileges.ForeColor = System.Drawing.Color.Black
        Me.M_ModifyPrivileges.Location = New System.Drawing.Point(508, 595)
        Me.M_ModifyPrivileges.Name = "M_ModifyPrivileges"
        Me.M_ModifyPrivileges.Size = New System.Drawing.Size(109, 34)
        Me.M_ModifyPrivileges.TabIndex = 4
        Me.M_ModifyPrivileges.Text = "Modify privileges"
        Me.M_ModifyPrivileges.UseVisualStyleBackColor = False
        '
        'M_DeleteAccount
        '
        Me.M_DeleteAccount.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.M_DeleteAccount.BackColor = System.Drawing.Color.White
        Me.M_DeleteAccount.ForeColor = System.Drawing.Color.Black
        Me.M_DeleteAccount.Location = New System.Drawing.Point(623, 595)
        Me.M_DeleteAccount.Name = "M_DeleteAccount"
        Me.M_DeleteAccount.Size = New System.Drawing.Size(109, 34)
        Me.M_DeleteAccount.TabIndex = 3
        Me.M_DeleteAccount.Text = "Delete account"
        Me.M_DeleteAccount.UseVisualStyleBackColor = False
        '
        'AccountsGrid
        '
        Me.AccountsGrid.AllowUserToAddRows = False
        Me.AccountsGrid.AllowUserToDeleteRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.White
        Me.AccountsGrid.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.AccountsGrid.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.AccountsGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.AccountsGrid.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.AccountsGrid.BackgroundColor = System.Drawing.SystemColors.Window
        Me.AccountsGrid.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.AccountsGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.AccountsGrid.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.AccountsGrid.Location = New System.Drawing.Point(392, 19)
        Me.AccountsGrid.Name = "AccountsGrid"
        Me.AccountsGrid.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        Me.AccountsGrid.RowHeadersVisible = False
        Me.AccountsGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.AccountsGrid.Size = New System.Drawing.Size(440, 456)
        Me.AccountsGrid.TabIndex = 2
        '
        'UserAccountsForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(840, 661)
        Me.Controls.Add(Me.GroupBox6)
        Me.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "UserAccountsForm"
        Me.Text = "User Accounts Management"
        Me.GroupBox6.ResumeLayout(False)
        Me.GroupBox6.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AccountsGrid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox6 As System.Windows.Forms.GroupBox
    Friend WithEvents M_GrantAll2 As System.Windows.Forms.CheckBox
    Friend WithEvents M_GrantDelete2 As System.Windows.Forms.CheckBox
    Friend WithEvents M_GrantUpdate2 As System.Windows.Forms.CheckBox
    Friend WithEvents M_GrantInsert2 As System.Windows.Forms.CheckBox
    Friend WithEvents M_GrantSelect2 As System.Windows.Forms.CheckBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents M_ModifyPrivileges As System.Windows.Forms.Button
    Friend WithEvents M_DeleteAccount As System.Windows.Forms.Button
    Friend WithEvents AccountsGrid As System.Windows.Forms.DataGridView
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents M_GrantAll As System.Windows.Forms.CheckBox
    Friend WithEvents M_GrantDelete As System.Windows.Forms.CheckBox
    Friend WithEvents M_GrantUpdate As System.Windows.Forms.CheckBox
    Friend WithEvents M_GrantInsert As System.Windows.Forms.CheckBox
    Friend WithEvents M_GrantSelect As System.Windows.Forms.CheckBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents M_Password As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents M_Name As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents M_CreateAccount As System.Windows.Forms.Button
End Class
