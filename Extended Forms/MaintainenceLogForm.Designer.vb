<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MaintainenceLogForm
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
        Me.Task_Box = New System.Windows.Forms.GroupBox()
        Me.Location = New System.Windows.Forms.TextBox()
        Me.TimeStamp = New System.Windows.Forms.DateTimePicker()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Status = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.LogId = New System.Windows.Forms.Label()
        Me.Username = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Log = New System.Windows.Forms.TextBox()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Header = New System.Windows.Forms.Label()
        Me.CancelBtn = New System.Windows.Forms.Button()
        Me.DeleteBtn = New System.Windows.Forms.Button()
        Me.OkBtn = New System.Windows.Forms.Button()
        Me.EditBtn = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Task_Box.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Task_Box
        '
        Me.Task_Box.BackColor = System.Drawing.Color.White
        Me.Task_Box.Controls.Add(Me.Location)
        Me.Task_Box.Controls.Add(Me.TimeStamp)
        Me.Task_Box.Controls.Add(Me.Label3)
        Me.Task_Box.Controls.Add(Me.Status)
        Me.Task_Box.Controls.Add(Me.Label1)
        Me.Task_Box.Controls.Add(Me.LogId)
        Me.Task_Box.Controls.Add(Me.Username)
        Me.Task_Box.Controls.Add(Me.Label9)
        Me.Task_Box.Controls.Add(Me.Label19)
        Me.Task_Box.Controls.Add(Me.Log)
        Me.Task_Box.Controls.Add(Me.Label20)
        Me.Task_Box.ForeColor = System.Drawing.Color.Black
        Me.Task_Box.Location = New System.Drawing.Point(1, 74)
        Me.Task_Box.Name = "Task_Box"
        Me.Task_Box.Size = New System.Drawing.Size(672, 468)
        Me.Task_Box.TabIndex = 62
        Me.Task_Box.TabStop = False
        Me.Task_Box.Text = "Maintainence Log:"
        '
        'Location
        '
        Me.Location.BackColor = System.Drawing.Color.White
        Me.Location.ForeColor = System.Drawing.Color.Black
        Me.Location.Location = New System.Drawing.Point(320, 79)
        Me.Location.Name = "Location"
        Me.Location.Size = New System.Drawing.Size(346, 22)
        Me.Location.TabIndex = 49
        '
        'TimeStamp
        '
        Me.TimeStamp.BackColor = System.Drawing.Color.White
        Me.TimeStamp.CustomFormat = "dd/MM/yyyy HH:mm"
        Me.TimeStamp.Enabled = False
        Me.TimeStamp.ForeColor = System.Drawing.Color.Black
        Me.TimeStamp.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.TimeStamp.Location = New System.Drawing.Point(320, 136)
        Me.TimeStamp.Name = "TimeStamp"
        Me.TimeStamp.Size = New System.Drawing.Size(346, 22)
        Me.TimeStamp.TabIndex = 48
        Me.TimeStamp.TabStop = False
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.White
        Me.Label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(8, 136)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(306, 16)
        Me.Label3.TabIndex = 47
        Me.Label3.Text = "Time:"
        '
        'Status
        '
        Me.Status.BackColor = System.Drawing.Color.White
        Me.Status.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Status.ForeColor = System.Drawing.Color.Black
        Me.Status.FormattingEnabled = True
        Me.Status.Items.AddRange(New Object() {"Completed", "Pending"})
        Me.Status.Location = New System.Drawing.Point(320, 107)
        Me.Status.Name = "Status"
        Me.Status.Size = New System.Drawing.Size(346, 21)
        Me.Status.TabIndex = 44
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.White
        Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(8, 108)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(306, 16)
        Me.Label1.TabIndex = 43
        Me.Label1.Text = "Status:"
        '
        'LogId
        '
        Me.LogId.BackColor = System.Drawing.Color.White
        Me.LogId.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.LogId.ForeColor = System.Drawing.Color.Black
        Me.LogId.Location = New System.Drawing.Point(8, 28)
        Me.LogId.Name = "LogId"
        Me.LogId.Size = New System.Drawing.Size(658, 16)
        Me.LogId.TabIndex = 42
        Me.LogId.Text = "Log ID:"
        '
        'Username
        '
        Me.Username.BackColor = System.Drawing.Color.White
        Me.Username.ForeColor = System.Drawing.Color.Black
        Me.Username.Location = New System.Drawing.Point(320, 53)
        Me.Username.Name = "Username"
        Me.Username.ReadOnly = True
        Me.Username.Size = New System.Drawing.Size(346, 22)
        Me.Username.TabIndex = 41
        '
        'Label9
        '
        Me.Label9.BackColor = System.Drawing.Color.White
        Me.Label9.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label9.ForeColor = System.Drawing.Color.Black
        Me.Label9.Location = New System.Drawing.Point(8, 55)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(306, 16)
        Me.Label9.TabIndex = 40
        Me.Label9.Text = "Username:"
        '
        'Label19
        '
        Me.Label19.BackColor = System.Drawing.Color.White
        Me.Label19.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label19.ForeColor = System.Drawing.Color.Black
        Me.Label19.Location = New System.Drawing.Point(8, 81)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(306, 16)
        Me.Label19.TabIndex = 24
        Me.Label19.Text = "Location:"
        '
        'Log
        '
        Me.Log.BackColor = System.Drawing.Color.White
        Me.Log.ForeColor = System.Drawing.Color.Black
        Me.Log.Location = New System.Drawing.Point(8, 192)
        Me.Log.Multiline = True
        Me.Log.Name = "Log"
        Me.Log.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.Log.Size = New System.Drawing.Size(658, 255)
        Me.Log.TabIndex = 21
        '
        'Label20
        '
        Me.Label20.BackColor = System.Drawing.Color.White
        Me.Label20.ForeColor = System.Drawing.Color.Black
        Me.Label20.Location = New System.Drawing.Point(6, 171)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(33, 16)
        Me.Label20.TabIndex = 23
        Me.Label20.Text = "Log:"
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.Color.White
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(76, 22)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(272, 37)
        Me.Label5.TabIndex = 65
        Me.Label5.Text = "Enter the information below for the maintainence log you wish to create."
        '
        'Header
        '
        Me.Header.BackColor = System.Drawing.Color.White
        Me.Header.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Header.Font = New System.Drawing.Font("Tahoma", 8.0!)
        Me.Header.ForeColor = System.Drawing.Color.Black
        Me.Header.Location = New System.Drawing.Point(1, 9)
        Me.Header.Name = "Header"
        Me.Header.Padding = New System.Windows.Forms.Padding(150, 0, 0, 0)
        Me.Header.Size = New System.Drawing.Size(672, 57)
        Me.Header.TabIndex = 63
        Me.Header.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'CancelBtn
        '
        Me.CancelBtn.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CancelBtn.BackColor = System.Drawing.Color.White
        Me.CancelBtn.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.CancelBtn.ForeColor = System.Drawing.Color.Black
        Me.CancelBtn.Image = Global.PMD.My.Resources.Resources._1364511183_dialog_close
        Me.CancelBtn.Location = New System.Drawing.Point(421, 554)
        Me.CancelBtn.Name = "CancelBtn"
        Me.CancelBtn.Size = New System.Drawing.Size(122, 26)
        Me.CancelBtn.TabIndex = 68
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
        Me.DeleteBtn.Location = New System.Drawing.Point(293, 554)
        Me.DeleteBtn.Name = "DeleteBtn"
        Me.DeleteBtn.Size = New System.Drawing.Size(122, 26)
        Me.DeleteBtn.TabIndex = 69
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
        Me.OkBtn.Location = New System.Drawing.Point(551, 553)
        Me.OkBtn.Name = "OkBtn"
        Me.OkBtn.Size = New System.Drawing.Size(122, 26)
        Me.OkBtn.TabIndex = 66
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
        Me.EditBtn.Location = New System.Drawing.Point(421, 553)
        Me.EditBtn.Name = "EditBtn"
        Me.EditBtn.Size = New System.Drawing.Size(122, 26)
        Me.EditBtn.TabIndex = 67
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
        Me.PictureBox1.Location = New System.Drawing.Point(10, 14)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(48, 49)
        Me.PictureBox1.TabIndex = 64
        Me.PictureBox1.TabStop = False
        '
        'MaintainenceLogForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.CancelBtn
        Me.ClientSize = New System.Drawing.Size(673, 583)
        Me.Controls.Add(Me.DeleteBtn)
        Me.Controls.Add(Me.OkBtn)
        Me.Controls.Add(Me.CancelBtn)
        Me.Controls.Add(Me.EditBtn)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Header)
        Me.Controls.Add(Me.Task_Box)
        Me.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MaximizeBox = False
        Me.Name = "MaintainenceLogForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "New Maintainence Log"
        Me.Task_Box.ResumeLayout(False)
        Me.Task_Box.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Task_Box As System.Windows.Forms.GroupBox
    Friend WithEvents LogId As System.Windows.Forms.Label
    Friend WithEvents Username As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents Log As System.Windows.Forms.TextBox
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Header As System.Windows.Forms.Label
    Friend WithEvents Status As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents OkBtn As System.Windows.Forms.Button
    Friend WithEvents CancelBtn As System.Windows.Forms.Button
    Friend WithEvents EditBtn As System.Windows.Forms.Button
    Friend WithEvents DeleteBtn As System.Windows.Forms.Button
    Friend WithEvents TimeStamp As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Location As System.Windows.Forms.TextBox
End Class
