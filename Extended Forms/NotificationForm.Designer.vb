<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class NotificationForm
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
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Header = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Description = New System.Windows.Forms.TextBox()
        Me.DueDate = New System.Windows.Forms.Label()
        Me.Subject = New System.Windows.Forms.Label()
        Me.ComboItem1 = New DevComponents.Editors.ComboItem()
        Me.GalleryContainer1 = New DevComponents.DotNetBar.GalleryContainer()
        Me.ComboItem2 = New DevComponents.Editors.ComboItem()
        Me.ComboItem3 = New DevComponents.Editors.ComboItem()
        Me.MarkTaskBtn = New DevComponents.DotNetBar.ButtonX()
        Me.ViewTaskBtn = New DevComponents.DotNetBar.ButtonX()
        Me.DismissBtn = New DevComponents.DotNetBar.ButtonX()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.GroupBox1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.Color.White
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(98, 28)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(315, 56)
        Me.Label5.TabIndex = 68
        Me.Label5.Text = "You have an overdue reminder. You can " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "either dismiss the task or mark it as com" & _
    "pleted."
        '
        'Header
        '
        Me.Header.BackColor = System.Drawing.Color.White
        Me.Header.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Header.Font = New System.Drawing.Font("Tahoma", 8.0!)
        Me.Header.ForeColor = System.Drawing.Color.Black
        Me.Header.Location = New System.Drawing.Point(2, 9)
        Me.Header.Name = "Header"
        Me.Header.Padding = New System.Windows.Forms.Padding(150, 0, 0, 0)
        Me.Header.Size = New System.Drawing.Size(521, 75)
        Me.Header.TabIndex = 66
        Me.Header.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.White
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Description)
        Me.GroupBox1.Controls.Add(Me.DueDate)
        Me.GroupBox1.Controls.Add(Me.Subject)
        Me.GroupBox1.ForeColor = System.Drawing.Color.Black
        Me.GroupBox1.Location = New System.Drawing.Point(2, 87)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(521, 208)
        Me.GroupBox1.TabIndex = 69
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Notification:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.White
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(6, 77)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(69, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Description:"
        '
        'Description
        '
        Me.Description.BackColor = System.Drawing.Color.White
        Me.Description.ForeColor = System.Drawing.Color.Black
        Me.Description.Location = New System.Drawing.Point(9, 100)
        Me.Description.Multiline = True
        Me.Description.Name = "Description"
        Me.Description.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.Description.Size = New System.Drawing.Size(503, 97)
        Me.Description.TabIndex = 3
        '
        'DueDate
        '
        Me.DueDate.AutoSize = True
        Me.DueDate.BackColor = System.Drawing.Color.White
        Me.DueDate.ForeColor = System.Drawing.Color.Black
        Me.DueDate.Location = New System.Drawing.Point(6, 50)
        Me.DueDate.Name = "DueDate"
        Me.DueDate.Size = New System.Drawing.Size(57, 13)
        Me.DueDate.TabIndex = 2
        Me.DueDate.Text = "Due date:"
        '
        'Subject
        '
        Me.Subject.AutoSize = True
        Me.Subject.BackColor = System.Drawing.Color.White
        Me.Subject.ForeColor = System.Drawing.Color.Black
        Me.Subject.Location = New System.Drawing.Point(6, 23)
        Me.Subject.Name = "Subject"
        Me.Subject.Size = New System.Drawing.Size(48, 13)
        Me.Subject.TabIndex = 0
        Me.Subject.Text = "Subject:"
        '
        'ComboItem1
        '
        Me.ComboItem1.Text = "1 Hour"
        '
        'GalleryContainer1
        '
        '
        '
        '
        Me.GalleryContainer1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.GalleryContainer1.EnableGalleryPopup = False
        Me.GalleryContainer1.LayoutOrientation = DevComponents.DotNetBar.eOrientation.Vertical
        Me.GalleryContainer1.MinimumSize = New System.Drawing.Size(150, 200)
        Me.GalleryContainer1.MultiLine = False
        Me.GalleryContainer1.Name = "GalleryContainer1"
        Me.GalleryContainer1.PopupUsesStandardScrollbars = False
        '
        '
        '
        Me.GalleryContainer1.TitleStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        'ComboItem2
        '
        Me.ComboItem2.Text = "2 Hours"
        '
        'ComboItem3
        '
        Me.ComboItem3.Text = "3 Hours"
        '
        'MarkTaskBtn
        '
        Me.MarkTaskBtn.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.MarkTaskBtn.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.MarkTaskBtn.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.MarkTaskBtn.Image = Global.PMD.My.Resources.Resources._1370461355_tick_16
        Me.MarkTaskBtn.Location = New System.Drawing.Point(353, 301)
        Me.MarkTaskBtn.Name = "MarkTaskBtn"
        Me.MarkTaskBtn.Size = New System.Drawing.Size(170, 30)
        Me.MarkTaskBtn.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.MarkTaskBtn.TabIndex = 106
        Me.MarkTaskBtn.Text = "Mark as completed"
        '
        'ViewTaskBtn
        '
        Me.ViewTaskBtn.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.ViewTaskBtn.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ViewTaskBtn.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.ViewTaskBtn.Image = Global.PMD.My.Resources.Resources._1367010962_application_view_detail
        Me.ViewTaskBtn.Location = New System.Drawing.Point(170, 301)
        Me.ViewTaskBtn.Name = "ViewTaskBtn"
        Me.ViewTaskBtn.Size = New System.Drawing.Size(177, 30)
        Me.ViewTaskBtn.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.ViewTaskBtn.TabIndex = 105
        Me.ViewTaskBtn.Text = "View Task"
        '
        'DismissBtn
        '
        Me.DismissBtn.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.DismissBtn.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DismissBtn.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.DismissBtn.Image = Global.PMD.My.Resources.Resources._1370307616_appointment_missed
        Me.DismissBtn.Location = New System.Drawing.Point(2, 301)
        Me.DismissBtn.Name = "DismissBtn"
        Me.DismissBtn.Size = New System.Drawing.Size(162, 30)
        Me.DismissBtn.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.DismissBtn.TabIndex = 104
        Me.DismissBtn.Text = "Dismiss"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.White
        Me.PictureBox1.ForeColor = System.Drawing.Color.Black
        Me.PictureBox1.Image = Global.PMD.My.Resources.Resources._1370305115_alarm
        Me.PictureBox1.Location = New System.Drawing.Point(11, 14)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(64, 64)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox1.TabIndex = 67
        Me.PictureBox1.TabStop = False
        '
        'NotificationForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(524, 337)
        Me.Controls.Add(Me.MarkTaskBtn)
        Me.Controls.Add(Me.ViewTaskBtn)
        Me.Controls.Add(Me.DismissBtn)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Header)
        Me.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.Name = "NotificationForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Reminder Notification"
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
    Friend WithEvents DismissBtn As DevComponents.DotNetBar.ButtonX
    Friend WithEvents DueDate As System.Windows.Forms.Label
    Friend WithEvents Subject As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Description As System.Windows.Forms.TextBox
    Friend WithEvents ViewTaskBtn As DevComponents.DotNetBar.ButtonX
    Friend WithEvents ComboItem1 As DevComponents.Editors.ComboItem
    Friend WithEvents ComboItem2 As DevComponents.Editors.ComboItem
    Friend WithEvents ComboItem3 As DevComponents.Editors.ComboItem
    Friend WithEvents GalleryContainer1 As DevComponents.DotNetBar.GalleryContainer
    Friend WithEvents MarkTaskBtn As DevComponents.DotNetBar.ButtonX
End Class
