<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class LoginForm
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
    Protected Overrides ReadOnly Property CreateParams() As CreateParams
        Get
            Dim cp As CreateParams = MyBase.CreateParams
            Const CS_DBLCLKS As Int32 = &H8
            Const CS_NOCLOSE As Int32 = &H200
            cp.ClassStyle = CS_DBLCLKS Or CS_NOCLOSE
            Return cp
        End Get
    End Property
    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.LoginPanel = New System.Windows.Forms.GroupBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.DBHost = New System.Windows.Forms.TextBox()
        Me.GroupPanel1 = New DevComponents.DotNetBar.Controls.GroupPanel()
        Me.DBUsername = New System.Windows.Forms.ComboBox()
        Me.rememberMe = New System.Windows.Forms.CheckBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.DBPassword = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ExitBtn = New DevComponents.DotNetBar.ButtonX()
        Me.LoginBtn = New DevComponents.DotNetBar.ButtonX()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.LoginPanel.SuspendLayout()
        Me.GroupPanel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LoginPanel
        '
        Me.LoginPanel.BackColor = System.Drawing.Color.White
        Me.LoginPanel.Controls.Add(Me.Label3)
        Me.LoginPanel.Controls.Add(Me.DBHost)
        Me.LoginPanel.Controls.Add(Me.GroupPanel1)
        Me.LoginPanel.Controls.Add(Me.ExitBtn)
        Me.LoginPanel.Controls.Add(Me.LoginBtn)
        Me.LoginPanel.Controls.Add(Me.PictureBox1)
        Me.LoginPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LoginPanel.ForeColor = System.Drawing.Color.Black
        Me.LoginPanel.Location = New System.Drawing.Point(0, 0)
        Me.LoginPanel.Name = "LoginPanel"
        Me.LoginPanel.Size = New System.Drawing.Size(700, 517)
        Me.LoginPanel.TabIndex = 16
        Me.LoginPanel.TabStop = False
        Me.LoginPanel.Text = "Login"
        '
        'Label3
        '
        Me.Label3.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(236, 227)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(73, 13)
        Me.Label3.TabIndex = 30
        Me.Label3.Text = "Hostname/IP:"
        '
        'DBHost
        '
        Me.DBHost.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.DBHost.BackColor = System.Drawing.Color.White
        Me.DBHost.ForeColor = System.Drawing.Color.Black
        Me.DBHost.Location = New System.Drawing.Point(238, 248)
        Me.DBHost.Name = "DBHost"
        Me.DBHost.Size = New System.Drawing.Size(224, 20)
        Me.DBHost.TabIndex = 29
        Me.DBHost.Text = "localhost"
        '
        'GroupPanel1
        '
        Me.GroupPanel1.BackColor = System.Drawing.Color.White
        Me.GroupPanel1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.GroupPanel1.Controls.Add(Me.DBUsername)
        Me.GroupPanel1.Controls.Add(Me.rememberMe)
        Me.GroupPanel1.Controls.Add(Me.Label2)
        Me.GroupPanel1.Controls.Add(Me.DBPassword)
        Me.GroupPanel1.Controls.Add(Me.Label1)
        Me.GroupPanel1.DisabledBackColor = System.Drawing.Color.Empty
        Me.GroupPanel1.Location = New System.Drawing.Point(206, 286)
        Me.GroupPanel1.Name = "GroupPanel1"
        Me.GroupPanel1.Size = New System.Drawing.Size(289, 124)
        '
        '
        '
        Me.GroupPanel1.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.GroupPanel1.Style.BackColorGradientAngle = 90
        Me.GroupPanel1.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.GroupPanel1.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupPanel1.Style.BorderBottomWidth = 1
        Me.GroupPanel1.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.GroupPanel1.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupPanel1.Style.BorderLeftWidth = 1
        Me.GroupPanel1.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupPanel1.Style.BorderRightWidth = 1
        Me.GroupPanel1.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupPanel1.Style.BorderTopWidth = 1
        Me.GroupPanel1.Style.CornerDiameter = 4
        Me.GroupPanel1.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded
        Me.GroupPanel1.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center
        Me.GroupPanel1.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.GroupPanel1.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near
        '
        '
        '
        Me.GroupPanel1.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        '
        '
        Me.GroupPanel1.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.GroupPanel1.TabIndex = 22
        '
        'DBUsername
        '
        Me.DBUsername.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.DBUsername.BackColor = System.Drawing.Color.White
        Me.DBUsername.ForeColor = System.Drawing.Color.Black
        Me.DBUsername.FormattingEnabled = True
        Me.DBUsername.Location = New System.Drawing.Point(30, 24)
        Me.DBUsername.Name = "DBUsername"
        Me.DBUsername.Size = New System.Drawing.Size(224, 21)
        Me.DBUsername.TabIndex = 23
        '
        'rememberMe
        '
        Me.rememberMe.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.rememberMe.AutoSize = True
        Me.rememberMe.BackColor = System.Drawing.Color.Transparent
        Me.rememberMe.ForeColor = System.Drawing.Color.Black
        Me.rememberMe.Location = New System.Drawing.Point(34, 95)
        Me.rememberMe.Name = "rememberMe"
        Me.rememberMe.Size = New System.Drawing.Size(95, 17)
        Me.rememberMe.TabIndex = 25
        Me.rememberMe.Text = "Remember Me"
        Me.rememberMe.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(29, 52)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(56, 13)
        Me.Label2.TabIndex = 27
        Me.Label2.Text = "Password:"
        '
        'DBPassword
        '
        Me.DBPassword.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.DBPassword.BackColor = System.Drawing.Color.White
        Me.DBPassword.ForeColor = System.Drawing.Color.Black
        Me.DBPassword.Location = New System.Drawing.Point(30, 68)
        Me.DBPassword.Name = "DBPassword"
        Me.DBPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.DBPassword.Size = New System.Drawing.Size(224, 20)
        Me.DBPassword.TabIndex = 24
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(29, 7)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(58, 13)
        Me.Label1.TabIndex = 26
        Me.Label1.Text = "Username:"
        '
        'ExitBtn
        '
        Me.ExitBtn.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.ExitBtn.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.ExitBtn.Image = Global.PMD.My.Resources.Resources._1369843451_Log_Out
        Me.ExitBtn.Location = New System.Drawing.Point(354, 433)
        Me.ExitBtn.Name = "ExitBtn"
        Me.ExitBtn.Size = New System.Drawing.Size(122, 44)
        Me.ExitBtn.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.ExitBtn.TabIndex = 6
        Me.ExitBtn.Text = "Exit"
        '
        'LoginBtn
        '
        Me.LoginBtn.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.LoginBtn.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.LoginBtn.Image = Global.PMD.My.Resources.Resources._1366954939_login
        Me.LoginBtn.Location = New System.Drawing.Point(225, 433)
        Me.LoginBtn.Name = "LoginBtn"
        Me.LoginBtn.Size = New System.Drawing.Size(125, 44)
        Me.LoginBtn.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.LoginBtn.TabIndex = 5
        Me.LoginBtn.Text = "Login"
        '
        'PictureBox1
        '
        Me.PictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.PictureBox1.BackColor = System.Drawing.Color.White
        Me.PictureBox1.ForeColor = System.Drawing.Color.Black
        Me.PictureBox1.Image = Global.PMD.My.Resources.Resources.Manager
        Me.PictureBox1.Location = New System.Drawing.Point(225, 51)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(251, 157)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox1.TabIndex = 17
        Me.PictureBox1.TabStop = False
        '
        'LoginForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(700, 517)
        Me.ControlBox = False
        Me.Controls.Add(Me.LoginPanel)
        Me.DoubleBuffered = True
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "LoginForm"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Property Management .NET - Login"
        Me.LoginPanel.ResumeLayout(False)
        Me.LoginPanel.PerformLayout()
        Me.GroupPanel1.ResumeLayout(False)
        Me.GroupPanel1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents LoginPanel As System.Windows.Forms.GroupBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents LoginBtn As DevComponents.DotNetBar.ButtonX
    Friend WithEvents ExitBtn As DevComponents.DotNetBar.ButtonX
    Friend WithEvents GroupPanel1 As DevComponents.DotNetBar.Controls.GroupPanel
    Friend WithEvents DBUsername As ComboBox
    Friend WithEvents rememberMe As CheckBox
    Friend WithEvents Label2 As Label
    Friend WithEvents DBPassword As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents DBHost As TextBox
End Class
