<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AddFundsForm
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
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Header = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.CurrentDate = New System.Windows.Forms.DateTimePicker()
        Me.PaymentType = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.PropertyName = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.FundSource = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.CancelBtn = New System.Windows.Forms.Button()
        Me.OkBtn = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Amount = New PMD.CurrencyTextBox(Me.components)
        Me.ConfirmAmount = New PMD.CurrencyTextBox(Me.components)
        Me.GroupBox1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.Color.White
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(91, 26)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(339, 37)
        Me.Label5.TabIndex = 68
        Me.Label5.Text = "Enter the amount of funds you want to add to the selected property."
        '
        'Header
        '
        Me.Header.BackColor = System.Drawing.Color.White
        Me.Header.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Header.Font = New System.Drawing.Font("Tahoma", 8.0!)
        Me.Header.ForeColor = System.Drawing.Color.Black
        Me.Header.Location = New System.Drawing.Point(1, 8)
        Me.Header.Name = "Header"
        Me.Header.Padding = New System.Windows.Forms.Padding(150, 0, 0, 0)
        Me.Header.Size = New System.Drawing.Size(516, 75)
        Me.Header.TabIndex = 66
        Me.Header.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.White
        Me.GroupBox1.Controls.Add(Me.CurrentDate)
        Me.GroupBox1.Controls.Add(Me.PaymentType)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.PropertyName)
        Me.GroupBox1.Controls.Add(Me.Amount)
        Me.GroupBox1.Controls.Add(Me.ConfirmAmount)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.FundSource)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.ForeColor = System.Drawing.Color.Black
        Me.GroupBox1.Location = New System.Drawing.Point(1, 92)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(516, 334)
        Me.GroupBox1.TabIndex = 69
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Add funds:"
        '
        'CurrentDate
        '
        Me.CurrentDate.BackColor = System.Drawing.Color.White
        Me.CurrentDate.ForeColor = System.Drawing.Color.Black
        Me.CurrentDate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.CurrentDate.Location = New System.Drawing.Point(254, 129)
        Me.CurrentDate.MinDate = New Date(2000, 1, 1, 0, 0, 0, 0)
        Me.CurrentDate.Name = "CurrentDate"
        Me.CurrentDate.Size = New System.Drawing.Size(251, 22)
        Me.CurrentDate.TabIndex = 152
        '
        'PaymentType
        '
        Me.PaymentType.BackColor = System.Drawing.Color.White
        Me.PaymentType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.PaymentType.ForeColor = System.Drawing.Color.Black
        Me.PaymentType.FormattingEnabled = True
        Me.PaymentType.Items.AddRange(New Object() {"Direct Debit", "Bank Transfer", "Cheque"})
        Me.PaymentType.Location = New System.Drawing.Point(253, 46)
        Me.PaymentType.Name = "PaymentType"
        Me.PaymentType.Size = New System.Drawing.Size(253, 21)
        Me.PaymentType.TabIndex = 148
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.White
        Me.Label4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(9, 48)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(239, 16)
        Me.Label4.TabIndex = 54
        Me.Label4.Text = "Payment Type:"
        '
        'PropertyName
        '
        Me.PropertyName.BackColor = System.Drawing.Color.White
        Me.PropertyName.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PropertyName.ForeColor = System.Drawing.Color.Black
        Me.PropertyName.Location = New System.Drawing.Point(9, 25)
        Me.PropertyName.Name = "PropertyName"
        Me.PropertyName.Size = New System.Drawing.Size(496, 16)
        Me.PropertyName.TabIndex = 53
        Me.PropertyName.Text = "Company Name:"
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.White
        Me.Label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(9, 131)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(239, 16)
        Me.Label3.TabIndex = 47
        Me.Label3.Text = "Date:"
        '
        'FundSource
        '
        Me.FundSource.BackColor = System.Drawing.Color.White
        Me.FundSource.ForeColor = System.Drawing.Color.Black
        Me.FundSource.Location = New System.Drawing.Point(9, 210)
        Me.FundSource.Multiline = True
        Me.FundSource.Name = "FundSource"
        Me.FundSource.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.FundSource.Size = New System.Drawing.Size(500, 111)
        Me.FundSource.TabIndex = 46
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.White
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(6, 191)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(500, 16)
        Me.Label2.TabIndex = 45
        Me.Label2.Text = "Fund Source: *"
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.White
        Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(9, 103)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(239, 16)
        Me.Label1.TabIndex = 43
        Me.Label1.Text = "Confirm Amount: *"
        '
        'Label9
        '
        Me.Label9.BackColor = System.Drawing.Color.White
        Me.Label9.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label9.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.Black
        Me.Label9.Location = New System.Drawing.Point(9, 75)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(239, 16)
        Me.Label9.TabIndex = 41
        Me.Label9.Text = "Amount: *"
        '
        'CancelBtn
        '
        Me.CancelBtn.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CancelBtn.BackColor = System.Drawing.Color.White
        Me.CancelBtn.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.CancelBtn.ForeColor = System.Drawing.Color.Black
        Me.CancelBtn.Image = Global.PMD.My.Resources.Resources._1364511183_dialog_close
        Me.CancelBtn.Location = New System.Drawing.Point(265, 432)
        Me.CancelBtn.Name = "CancelBtn"
        Me.CancelBtn.Size = New System.Drawing.Size(122, 26)
        Me.CancelBtn.TabIndex = 71
        Me.CancelBtn.Text = "Cancel"
        Me.CancelBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.CancelBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.CancelBtn.UseVisualStyleBackColor = False
        '
        'OkBtn
        '
        Me.OkBtn.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.OkBtn.BackColor = System.Drawing.Color.White
        Me.OkBtn.ForeColor = System.Drawing.Color.Black
        Me.OkBtn.Image = Global.PMD.My.Resources.Resources._1364677427_tick
        Me.OkBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.OkBtn.Location = New System.Drawing.Point(395, 432)
        Me.OkBtn.Name = "OkBtn"
        Me.OkBtn.Size = New System.Drawing.Size(122, 26)
        Me.OkBtn.TabIndex = 70
        Me.OkBtn.Text = "Add Funds"
        Me.OkBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.OkBtn.UseVisualStyleBackColor = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.White
        Me.PictureBox1.ForeColor = System.Drawing.Color.Black
        Me.PictureBox1.Image = Global.PMD.My.Resources.Resources._1370980152_Purse
        Me.PictureBox1.Location = New System.Drawing.Point(10, 13)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(64, 64)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox1.TabIndex = 67
        Me.PictureBox1.TabStop = False
        '
        'Amount
        '
        Me.Amount.BackColor = System.Drawing.Color.White
        Me.Amount.ForeColor = System.Drawing.Color.Black
        Me.Amount.Location = New System.Drawing.Point(253, 73)
        Me.Amount.Name = "Amount"
        Me.Amount.Size = New System.Drawing.Size(252, 22)
        Me.Amount.TabIndex = 51
        Me.Amount.Text = "£0.00"
        '
        'ConfirmAmount
        '
        Me.ConfirmAmount.BackColor = System.Drawing.Color.White
        Me.ConfirmAmount.ForeColor = System.Drawing.Color.Black
        Me.ConfirmAmount.Location = New System.Drawing.Point(253, 101)
        Me.ConfirmAmount.Name = "ConfirmAmount"
        Me.ConfirmAmount.Size = New System.Drawing.Size(252, 22)
        Me.ConfirmAmount.TabIndex = 50
        Me.ConfirmAmount.Text = "£0.00"
        '
        'AddFundsForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.CancelBtn
        Me.ClientSize = New System.Drawing.Size(518, 462)
        Me.ControlBox = False
        Me.Controls.Add(Me.OkBtn)
        Me.Controls.Add(Me.CancelBtn)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Header)
        Me.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Name = "AddFundsForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Add Funds"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Header As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents FundSource As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents OkBtn As System.Windows.Forms.Button
    Friend WithEvents CancelBtn As System.Windows.Forms.Button
    Friend WithEvents ConfirmAmount As PMD.CurrencyTextBox
    Friend WithEvents Amount As PMD.CurrencyTextBox
    Friend WithEvents PropertyName As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents PaymentType As System.Windows.Forms.ComboBox
    Friend WithEvents CurrentDate As System.Windows.Forms.DateTimePicker
End Class
