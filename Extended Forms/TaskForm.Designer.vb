<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class TaskForm
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
        Me.RemindMeLabel = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.TaskReminder_Days = New System.Windows.Forms.TextBox()
        Me.TaskCreatedDate = New System.Windows.Forms.DateTimePicker()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.ReminderCheckBox = New System.Windows.Forms.CheckBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TaskImportance = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TaskId = New System.Windows.Forms.Label()
        Me.TaskName = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.TaskDueDate = New System.Windows.Forms.DateTimePicker()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.TaskStatus = New System.Windows.Forms.ComboBox()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.TaskNote = New System.Windows.Forms.TextBox()
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
        Me.Task_Box.Controls.Add(Me.RemindMeLabel)
        Me.Task_Box.Controls.Add(Me.Label7)
        Me.Task_Box.Controls.Add(Me.TaskReminder_Days)
        Me.Task_Box.Controls.Add(Me.TaskCreatedDate)
        Me.Task_Box.Controls.Add(Me.Label3)
        Me.Task_Box.Controls.Add(Me.ReminderCheckBox)
        Me.Task_Box.Controls.Add(Me.Label2)
        Me.Task_Box.Controls.Add(Me.TaskImportance)
        Me.Task_Box.Controls.Add(Me.Label1)
        Me.Task_Box.Controls.Add(Me.TaskId)
        Me.Task_Box.Controls.Add(Me.TaskName)
        Me.Task_Box.Controls.Add(Me.Label9)
        Me.Task_Box.Controls.Add(Me.TaskDueDate)
        Me.Task_Box.Controls.Add(Me.Label10)
        Me.Task_Box.Controls.Add(Me.TaskStatus)
        Me.Task_Box.Controls.Add(Me.Label19)
        Me.Task_Box.Controls.Add(Me.TaskNote)
        Me.Task_Box.Controls.Add(Me.Label20)
        Me.Task_Box.ForeColor = System.Drawing.Color.Black
        Me.Task_Box.Location = New System.Drawing.Point(1, 103)
        Me.Task_Box.Name = "Task_Box"
        Me.Task_Box.Size = New System.Drawing.Size(516, 506)
        Me.Task_Box.TabIndex = 62
        Me.Task_Box.TabStop = False
        Me.Task_Box.Text = "Task:"
        '
        'RemindMeLabel
        '
        Me.RemindMeLabel.AutoSize = True
        Me.RemindMeLabel.BackColor = System.Drawing.Color.White
        Me.RemindMeLabel.Enabled = False
        Me.RemindMeLabel.ForeColor = System.Drawing.Color.Black
        Me.RemindMeLabel.Location = New System.Drawing.Point(250, 223)
        Me.RemindMeLabel.Name = "RemindMeLabel"
        Me.RemindMeLabel.Size = New System.Drawing.Size(168, 13)
        Me.RemindMeLabel.TabIndex = 86
        Me.RemindMeLabel.Text = "Remind me before due date by:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.White
        Me.Label7.ForeColor = System.Drawing.Color.Black
        Me.Label7.Location = New System.Drawing.Point(469, 223)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(37, 13)
        Me.Label7.TabIndex = 85
        Me.Label7.Text = "Day(s)"
        '
        'TaskReminder_Days
        '
        Me.TaskReminder_Days.BackColor = System.Drawing.Color.White
        Me.TaskReminder_Days.Enabled = False
        Me.TaskReminder_Days.ForeColor = System.Drawing.Color.Black
        Me.TaskReminder_Days.Location = New System.Drawing.Point(425, 220)
        Me.TaskReminder_Days.Name = "TaskReminder_Days"
        Me.TaskReminder_Days.Size = New System.Drawing.Size(40, 22)
        Me.TaskReminder_Days.TabIndex = 84
        Me.TaskReminder_Days.Text = "0"
        '
        'TaskCreatedDate
        '
        Me.TaskCreatedDate.BackColor = System.Drawing.Color.White
        Me.TaskCreatedDate.CustomFormat = "dd/MM/yyyy HH:mm"
        Me.TaskCreatedDate.Enabled = False
        Me.TaskCreatedDate.ForeColor = System.Drawing.Color.Black
        Me.TaskCreatedDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.TaskCreatedDate.Location = New System.Drawing.Point(253, 136)
        Me.TaskCreatedDate.Name = "TaskCreatedDate"
        Me.TaskCreatedDate.Size = New System.Drawing.Size(255, 22)
        Me.TaskCreatedDate.TabIndex = 48
        Me.TaskCreatedDate.TabStop = False
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.White
        Me.Label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(8, 136)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(239, 16)
        Me.Label3.TabIndex = 47
        Me.Label3.Text = "Created:"
        '
        'ReminderCheckBox
        '
        Me.ReminderCheckBox.AutoSize = True
        Me.ReminderCheckBox.BackColor = System.Drawing.Color.White
        Me.ReminderCheckBox.ForeColor = System.Drawing.Color.Black
        Me.ReminderCheckBox.Location = New System.Drawing.Point(253, 193)
        Me.ReminderCheckBox.Name = "ReminderCheckBox"
        Me.ReminderCheckBox.Size = New System.Drawing.Size(143, 17)
        Me.ReminderCheckBox.TabIndex = 46
        Me.ReminderCheckBox.Text = "Remind me of this task"
        Me.ReminderCheckBox.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.White
        Me.Label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(8, 190)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(239, 16)
        Me.Label2.TabIndex = 45
        Me.Label2.Text = "Reminder:"
        '
        'TaskImportance
        '
        Me.TaskImportance.BackColor = System.Drawing.Color.White
        Me.TaskImportance.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.TaskImportance.ForeColor = System.Drawing.Color.Black
        Me.TaskImportance.FormattingEnabled = True
        Me.TaskImportance.Items.AddRange(New Object() {"Important", "Unimportant"})
        Me.TaskImportance.Location = New System.Drawing.Point(253, 107)
        Me.TaskImportance.Name = "TaskImportance"
        Me.TaskImportance.Size = New System.Drawing.Size(255, 21)
        Me.TaskImportance.TabIndex = 44
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.White
        Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(8, 108)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(239, 16)
        Me.Label1.TabIndex = 43
        Me.Label1.Text = "Importance:"
        '
        'TaskId
        '
        Me.TaskId.BackColor = System.Drawing.Color.White
        Me.TaskId.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.TaskId.ForeColor = System.Drawing.Color.Black
        Me.TaskId.Location = New System.Drawing.Point(8, 28)
        Me.TaskId.Name = "TaskId"
        Me.TaskId.Size = New System.Drawing.Size(500, 16)
        Me.TaskId.TabIndex = 42
        Me.TaskId.Text = "Task ID:"
        '
        'TaskName
        '
        Me.TaskName.BackColor = System.Drawing.Color.White
        Me.TaskName.ForeColor = System.Drawing.Color.Black
        Me.TaskName.Location = New System.Drawing.Point(253, 53)
        Me.TaskName.Name = "TaskName"
        Me.TaskName.Size = New System.Drawing.Size(255, 22)
        Me.TaskName.TabIndex = 41
        '
        'Label9
        '
        Me.Label9.BackColor = System.Drawing.Color.White
        Me.Label9.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label9.ForeColor = System.Drawing.Color.Black
        Me.Label9.Location = New System.Drawing.Point(8, 55)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(239, 16)
        Me.Label9.TabIndex = 40
        Me.Label9.Text = "Name:"
        '
        'TaskDueDate
        '
        Me.TaskDueDate.BackColor = System.Drawing.Color.White
        Me.TaskDueDate.CustomFormat = " "
        Me.TaskDueDate.ForeColor = System.Drawing.Color.Black
        Me.TaskDueDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.TaskDueDate.Location = New System.Drawing.Point(253, 165)
        Me.TaskDueDate.Name = "TaskDueDate"
        Me.TaskDueDate.Size = New System.Drawing.Size(255, 22)
        Me.TaskDueDate.TabIndex = 39
        Me.TaskDueDate.TabStop = False
        '
        'Label10
        '
        Me.Label10.BackColor = System.Drawing.Color.White
        Me.Label10.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label10.ForeColor = System.Drawing.Color.Black
        Me.Label10.Location = New System.Drawing.Point(8, 165)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(239, 16)
        Me.Label10.TabIndex = 38
        Me.Label10.Text = "Due:"
        '
        'TaskStatus
        '
        Me.TaskStatus.BackColor = System.Drawing.Color.White
        Me.TaskStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.TaskStatus.ForeColor = System.Drawing.Color.Black
        Me.TaskStatus.FormattingEnabled = True
        Me.TaskStatus.Items.AddRange(New Object() {"Pending", "Completed", "Dismissed"})
        Me.TaskStatus.Location = New System.Drawing.Point(253, 80)
        Me.TaskStatus.Name = "TaskStatus"
        Me.TaskStatus.Size = New System.Drawing.Size(255, 21)
        Me.TaskStatus.TabIndex = 37
        '
        'Label19
        '
        Me.Label19.BackColor = System.Drawing.Color.White
        Me.Label19.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label19.ForeColor = System.Drawing.Color.Black
        Me.Label19.Location = New System.Drawing.Point(8, 81)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(239, 16)
        Me.Label19.TabIndex = 24
        Me.Label19.Text = "Status:"
        '
        'TaskNote
        '
        Me.TaskNote.BackColor = System.Drawing.Color.White
        Me.TaskNote.ForeColor = System.Drawing.Color.Black
        Me.TaskNote.Location = New System.Drawing.Point(8, 264)
        Me.TaskNote.Multiline = True
        Me.TaskNote.Name = "TaskNote"
        Me.TaskNote.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.TaskNote.Size = New System.Drawing.Size(500, 225)
        Me.TaskNote.TabIndex = 21
        '
        'Label20
        '
        Me.Label20.BackColor = System.Drawing.Color.White
        Me.Label20.ForeColor = System.Drawing.Color.Black
        Me.Label20.Location = New System.Drawing.Point(6, 248)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(42, 11)
        Me.Label20.TabIndex = 23
        Me.Label20.Text = "Note:"
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.Color.White
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(84, 22)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(229, 37)
        Me.Label5.TabIndex = 65
        Me.Label5.Text = "Enter the information below for the task you wish to create."
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
        Me.Header.Size = New System.Drawing.Size(516, 75)
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
        Me.CancelBtn.Location = New System.Drawing.Point(265, 613)
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
        Me.DeleteBtn.Location = New System.Drawing.Point(137, 613)
        Me.DeleteBtn.Name = "DeleteBtn"
        Me.DeleteBtn.Size = New System.Drawing.Size(122, 26)
        Me.DeleteBtn.TabIndex = 69
        Me.DeleteBtn.Text = "Delete Task"
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
        Me.OkBtn.Location = New System.Drawing.Point(395, 613)
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
        Me.EditBtn.Location = New System.Drawing.Point(265, 612)
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
        Me.PictureBox1.Image = Global.PMD.My.Resources.Resources._1369851516_Gnome_Task_Due_64
        Me.PictureBox1.Location = New System.Drawing.Point(10, 14)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(64, 64)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox1.TabIndex = 64
        Me.PictureBox1.TabStop = False
        '
        'TaskForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.CancelBtn
        Me.ClientSize = New System.Drawing.Size(517, 642)
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
        Me.Name = "TaskForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "New Task"
        Me.Task_Box.ResumeLayout(False)
        Me.Task_Box.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Task_Box As System.Windows.Forms.GroupBox
    Friend WithEvents TaskId As System.Windows.Forms.Label
    Friend WithEvents TaskName As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents TaskDueDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents TaskStatus As System.Windows.Forms.ComboBox
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents TaskNote As System.Windows.Forms.TextBox
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Header As System.Windows.Forms.Label
    Friend WithEvents TaskImportance As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents OkBtn As System.Windows.Forms.Button
    Friend WithEvents CancelBtn As System.Windows.Forms.Button
    Friend WithEvents EditBtn As System.Windows.Forms.Button
    Friend WithEvents ReminderCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents DeleteBtn As System.Windows.Forms.Button
    Friend WithEvents TaskCreatedDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents TaskReminder_Days As System.Windows.Forms.TextBox
    Friend WithEvents RemindMeLabel As System.Windows.Forms.Label
End Class
