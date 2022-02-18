<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Dashboard_Main
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Dashboard_Main))
        Me.BODY = New System.Windows.Forms.Panel()
        Me.Main = New System.Windows.Forms.Panel()
        Me.BunifuPictureBox1 = New Bunifu.UI.WinForms.BunifuPictureBox()
        Me.BunifuPictureBox2 = New Bunifu.UI.WinForms.BunifuPictureBox()
        Me.floatingPanel = New Bunifu.UI.WinForms.BunifuPanel()
        Me.options_btn = New Guna.UI2.WinForms.Guna2Button()
        Me.history_btn = New Guna.UI2.WinForms.Guna2Button()
        Me.dashboard_btn = New Guna.UI2.WinForms.Guna2Button()
        Me.TOP = New Bunifu.UI.WinForms.BunifuPanel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.snackbar1 = New Bunifu.UI.WinForms.BunifuSnackbar(Me.components)
        Me.Cover = New System.Windows.Forms.Label()
        Me.BODY.SuspendLayout()
        CType(Me.BunifuPictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BunifuPictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.floatingPanel.SuspendLayout()
        Me.TOP.SuspendLayout()
        Me.SuspendLayout()
        '
        'BODY
        '
        Me.BODY.BackColor = System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.BODY.Controls.Add(Me.Main)
        Me.BODY.Location = New System.Drawing.Point(0, 62)
        Me.BODY.Margin = New System.Windows.Forms.Padding(0)
        Me.BODY.Name = "BODY"
        Me.BODY.Size = New System.Drawing.Size(800, 442)
        Me.BODY.TabIndex = 4
        '
        'Main
        '
        Me.Main.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Main.Location = New System.Drawing.Point(0, 0)
        Me.Main.Name = "Main"
        Me.Main.Size = New System.Drawing.Size(800, 442)
        Me.Main.TabIndex = 0
        '
        'BunifuPictureBox1
        '
        Me.BunifuPictureBox1.AllowFocused = False
        Me.BunifuPictureBox1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BunifuPictureBox1.AutoSizeHeight = True
        Me.BunifuPictureBox1.BackColor = System.Drawing.Color.White
        Me.BunifuPictureBox1.BorderRadius = 25
        Me.BunifuPictureBox1.Image = Global.Smart_Irrigation_System_GUI.My.Resources.Resources.Logo
        Me.BunifuPictureBox1.IsCircle = False
        Me.BunifuPictureBox1.Location = New System.Drawing.Point(30, 20)
        Me.BunifuPictureBox1.Name = "BunifuPictureBox1"
        Me.BunifuPictureBox1.Size = New System.Drawing.Size(50, 50)
        Me.BunifuPictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.BunifuPictureBox1.TabIndex = 3
        Me.BunifuPictureBox1.TabStop = False
        Me.BunifuPictureBox1.Type = Bunifu.UI.WinForms.BunifuPictureBox.Types.Circle
        '
        'BunifuPictureBox2
        '
        Me.BunifuPictureBox2.AllowFocused = False
        Me.BunifuPictureBox2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.BunifuPictureBox2.AutoSizeHeight = True
        Me.BunifuPictureBox2.BackColor = System.Drawing.Color.White
        Me.BunifuPictureBox2.BorderRadius = 38
        Me.BunifuPictureBox2.Image = CType(resources.GetObject("BunifuPictureBox2.Image"), System.Drawing.Image)
        Me.BunifuPictureBox2.IsCircle = True
        Me.BunifuPictureBox2.Location = New System.Drawing.Point(17, 7)
        Me.BunifuPictureBox2.Margin = New System.Windows.Forms.Padding(10)
        Me.BunifuPictureBox2.Name = "BunifuPictureBox2"
        Me.BunifuPictureBox2.Size = New System.Drawing.Size(76, 76)
        Me.BunifuPictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.BunifuPictureBox2.TabIndex = 3
        Me.BunifuPictureBox2.TabStop = False
        Me.BunifuPictureBox2.Type = Bunifu.UI.WinForms.BunifuPictureBox.Types.Circle
        '
        'floatingPanel
        '
        Me.floatingPanel.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(97, Byte), Integer))
        Me.floatingPanel.BackgroundImage = CType(resources.GetObject("floatingPanel.BackgroundImage"), System.Drawing.Image)
        Me.floatingPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.floatingPanel.BorderColor = System.Drawing.Color.Transparent
        Me.floatingPanel.BorderRadius = 28
        Me.floatingPanel.BorderThickness = 1
        Me.floatingPanel.Controls.Add(Me.options_btn)
        Me.floatingPanel.Controls.Add(Me.history_btn)
        Me.floatingPanel.Controls.Add(Me.dashboard_btn)
        Me.floatingPanel.Location = New System.Drawing.Point(33, 180)
        Me.floatingPanel.Name = "floatingPanel"
        Me.floatingPanel.ShowBorders = True
        Me.floatingPanel.Size = New System.Drawing.Size(44, 169)
        Me.floatingPanel.TabIndex = 2
        '
        'options_btn
        '
        Me.options_btn.BackColor = System.Drawing.Color.Transparent
        Me.options_btn.BorderRadius = 8
        Me.options_btn.CheckedState.Parent = Me.options_btn
        Me.options_btn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.options_btn.CustomImages.Parent = Me.options_btn
        Me.options_btn.FillColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(97, Byte), Integer))
        Me.options_btn.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.options_btn.ForeColor = System.Drawing.Color.White
        Me.options_btn.HoverState.FillColor = System.Drawing.Color.FromArgb(CType(CType(57, Byte), Integer), CType(CType(191, Byte), Integer), CType(CType(115, Byte), Integer))
        Me.options_btn.HoverState.Parent = Me.options_btn
        Me.options_btn.Image = Global.Smart_Irrigation_System_GUI.My.Resources.Resources.settings_48px
        Me.options_btn.ImageOffset = New System.Drawing.Point(1, 0)
        Me.options_btn.ImageSize = New System.Drawing.Size(17, 17)
        Me.options_btn.Location = New System.Drawing.Point(5, 115)
        Me.options_btn.Margin = New System.Windows.Forms.Padding(0)
        Me.options_btn.Name = "options_btn"
        Me.options_btn.PressedColor = System.Drawing.Color.FromArgb(CType(CType(57, Byte), Integer), CType(CType(163, Byte), Integer), CType(CType(103, Byte), Integer))
        Me.options_btn.ShadowDecoration.Parent = Me.options_btn
        Me.options_btn.Size = New System.Drawing.Size(34, 34)
        Me.options_btn.TabIndex = 7
        '
        'history_btn
        '
        Me.history_btn.BackColor = System.Drawing.Color.Transparent
        Me.history_btn.BorderRadius = 8
        Me.history_btn.CheckedState.Parent = Me.history_btn
        Me.history_btn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.history_btn.CustomImages.Parent = Me.history_btn
        Me.history_btn.FillColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(97, Byte), Integer))
        Me.history_btn.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.history_btn.ForeColor = System.Drawing.Color.White
        Me.history_btn.HoverState.FillColor = System.Drawing.Color.FromArgb(CType(CType(57, Byte), Integer), CType(CType(191, Byte), Integer), CType(CType(115, Byte), Integer))
        Me.history_btn.HoverState.Parent = Me.history_btn
        Me.history_btn.Image = Global.Smart_Irrigation_System_GUI.My.Resources.Resources.hour_glass_48px
        Me.history_btn.ImageOffset = New System.Drawing.Point(1, 0)
        Me.history_btn.ImageSize = New System.Drawing.Size(18, 18)
        Me.history_btn.Location = New System.Drawing.Point(5, 67)
        Me.history_btn.Margin = New System.Windows.Forms.Padding(0)
        Me.history_btn.Name = "history_btn"
        Me.history_btn.PressedColor = System.Drawing.Color.FromArgb(CType(CType(57, Byte), Integer), CType(CType(163, Byte), Integer), CType(CType(103, Byte), Integer))
        Me.history_btn.ShadowDecoration.Parent = Me.history_btn
        Me.history_btn.Size = New System.Drawing.Size(34, 34)
        Me.history_btn.TabIndex = 7
        '
        'dashboard_btn
        '
        Me.dashboard_btn.BackColor = System.Drawing.Color.Transparent
        Me.dashboard_btn.BorderRadius = 8
        Me.dashboard_btn.CheckedState.Parent = Me.dashboard_btn
        Me.dashboard_btn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.dashboard_btn.CustomImages.Parent = Me.dashboard_btn
        Me.dashboard_btn.FillColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(97, Byte), Integer))
        Me.dashboard_btn.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.dashboard_btn.ForeColor = System.Drawing.Color.White
        Me.dashboard_btn.HoverState.FillColor = System.Drawing.Color.FromArgb(CType(CType(57, Byte), Integer), CType(CType(191, Byte), Integer), CType(CType(115, Byte), Integer))
        Me.dashboard_btn.HoverState.Parent = Me.dashboard_btn
        Me.dashboard_btn.Image = Global.Smart_Irrigation_System_GUI.My.Resources.Resources.bar_chart_48px
        Me.dashboard_btn.ImageSize = New System.Drawing.Size(15, 15)
        Me.dashboard_btn.Location = New System.Drawing.Point(5, 19)
        Me.dashboard_btn.Margin = New System.Windows.Forms.Padding(0)
        Me.dashboard_btn.Name = "dashboard_btn"
        Me.dashboard_btn.PressedColor = System.Drawing.Color.FromArgb(CType(CType(57, Byte), Integer), CType(CType(163, Byte), Integer), CType(CType(103, Byte), Integer))
        Me.dashboard_btn.ShadowDecoration.Parent = Me.dashboard_btn
        Me.dashboard_btn.Size = New System.Drawing.Size(34, 34)
        Me.dashboard_btn.TabIndex = 7
        '
        'TOP
        '
        Me.TOP.BackgroundColor = System.Drawing.Color.White
        Me.TOP.BackgroundImage = CType(resources.GetObject("TOP.BackgroundImage"), System.Drawing.Image)
        Me.TOP.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.TOP.BorderColor = System.Drawing.Color.Transparent
        Me.TOP.BorderRadius = 50
        Me.TOP.BorderThickness = 0
        Me.TOP.Controls.Add(Me.Label1)
        Me.TOP.Location = New System.Drawing.Point(0, -19)
        Me.TOP.Margin = New System.Windows.Forms.Padding(0)
        Me.TOP.Name = "TOP"
        Me.TOP.ShowBorders = True
        Me.TOP.Size = New System.Drawing.Size(800, 81)
        Me.TOP.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.White
        Me.Label1.Font = New System.Drawing.Font("Segoe UI Semibold", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(91, 26)
        Me.Label1.Name = "Label1"
        Me.Label1.Padding = New System.Windows.Forms.Padding(10, 0, 0, 0)
        Me.Label1.Size = New System.Drawing.Size(241, 55)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "SMART IRRIGATION SYSTEM"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'snackbar1
        '
        Me.snackbar1.AllowDragging = False
        Me.snackbar1.AllowMultipleViews = True
        Me.snackbar1.ClickToClose = True
        Me.snackbar1.DoubleClickToClose = False
        Me.snackbar1.DurationAfterIdle = 2000
        Me.snackbar1.ErrorOptions.ActionBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.snackbar1.ErrorOptions.ActionBorderColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.snackbar1.ErrorOptions.ActionBorderRadius = 1
        Me.snackbar1.ErrorOptions.ActionFont = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold)
        Me.snackbar1.ErrorOptions.ActionForeColor = System.Drawing.Color.Black
        Me.snackbar1.ErrorOptions.BackColor = System.Drawing.Color.White
        Me.snackbar1.ErrorOptions.BorderColor = System.Drawing.Color.White
        Me.snackbar1.ErrorOptions.CloseIconColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(199, Byte), Integer))
        Me.snackbar1.ErrorOptions.Font = New System.Drawing.Font("Segoe UI", 9.75!)
        Me.snackbar1.ErrorOptions.ForeColor = System.Drawing.Color.Black
        Me.snackbar1.ErrorOptions.Icon = CType(resources.GetObject("resource.Icon"), System.Drawing.Image)
        Me.snackbar1.ErrorOptions.IconLeftMargin = 12
        Me.snackbar1.FadeCloseIcon = False
        Me.snackbar1.Host = Bunifu.UI.WinForms.BunifuSnackbar.Hosts.FormOwner
        Me.snackbar1.InformationOptions.ActionBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.snackbar1.InformationOptions.ActionBorderColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.snackbar1.InformationOptions.ActionBorderRadius = 1
        Me.snackbar1.InformationOptions.ActionFont = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold)
        Me.snackbar1.InformationOptions.ActionForeColor = System.Drawing.Color.Black
        Me.snackbar1.InformationOptions.BackColor = System.Drawing.Color.White
        Me.snackbar1.InformationOptions.BorderColor = System.Drawing.Color.White
        Me.snackbar1.InformationOptions.CloseIconColor = System.Drawing.Color.FromArgb(CType(CType(145, Byte), Integer), CType(CType(213, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.snackbar1.InformationOptions.Font = New System.Drawing.Font("Segoe UI", 9.75!)
        Me.snackbar1.InformationOptions.ForeColor = System.Drawing.Color.Black
        Me.snackbar1.InformationOptions.Icon = CType(resources.GetObject("resource.Icon1"), System.Drawing.Image)
        Me.snackbar1.InformationOptions.IconLeftMargin = 12
        Me.snackbar1.Margin = 10
        Me.snackbar1.MaximumSize = New System.Drawing.Size(0, 0)
        Me.snackbar1.MaximumViews = 7
        Me.snackbar1.MessageRightMargin = 15
        Me.snackbar1.MinimumSize = New System.Drawing.Size(0, 0)
        Me.snackbar1.ShowBorders = False
        Me.snackbar1.ShowCloseIcon = False
        Me.snackbar1.ShowIcon = True
        Me.snackbar1.ShowShadows = True
        Me.snackbar1.SuccessOptions.ActionBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.snackbar1.SuccessOptions.ActionBorderColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.snackbar1.SuccessOptions.ActionBorderRadius = 1
        Me.snackbar1.SuccessOptions.ActionFont = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold)
        Me.snackbar1.SuccessOptions.ActionForeColor = System.Drawing.Color.Black
        Me.snackbar1.SuccessOptions.BackColor = System.Drawing.Color.White
        Me.snackbar1.SuccessOptions.BorderColor = System.Drawing.Color.White
        Me.snackbar1.SuccessOptions.CloseIconColor = System.Drawing.Color.FromArgb(CType(CType(246, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(237, Byte), Integer))
        Me.snackbar1.SuccessOptions.Font = New System.Drawing.Font("Segoe UI", 9.75!)
        Me.snackbar1.SuccessOptions.ForeColor = System.Drawing.Color.Black
        Me.snackbar1.SuccessOptions.Icon = CType(resources.GetObject("resource.Icon2"), System.Drawing.Image)
        Me.snackbar1.SuccessOptions.IconLeftMargin = 12
        Me.snackbar1.ViewsMargin = 7
        Me.snackbar1.WarningOptions.ActionBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.snackbar1.WarningOptions.ActionBorderColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.snackbar1.WarningOptions.ActionBorderRadius = 1
        Me.snackbar1.WarningOptions.ActionFont = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold)
        Me.snackbar1.WarningOptions.ActionForeColor = System.Drawing.Color.Black
        Me.snackbar1.WarningOptions.BackColor = System.Drawing.Color.White
        Me.snackbar1.WarningOptions.BorderColor = System.Drawing.Color.White
        Me.snackbar1.WarningOptions.CloseIconColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(143, Byte), Integer))
        Me.snackbar1.WarningOptions.Font = New System.Drawing.Font("Segoe UI", 9.75!)
        Me.snackbar1.WarningOptions.ForeColor = System.Drawing.Color.Black
        Me.snackbar1.WarningOptions.Icon = CType(resources.GetObject("resource.Icon3"), System.Drawing.Image)
        Me.snackbar1.WarningOptions.IconLeftMargin = 12
        Me.snackbar1.ZoomCloseIcon = True
        '
        'Cover
        '
        Me.Cover.BackColor = System.Drawing.Color.White
        Me.Cover.Location = New System.Drawing.Point(17, 7)
        Me.Cover.Name = "Cover"
        Me.Cover.Size = New System.Drawing.Size(76, 55)
        Me.Cover.TabIndex = 1
        '
        'Dashboard_Main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(800, 500)
        Me.Controls.Add(Me.BunifuPictureBox1)
        Me.Controls.Add(Me.Cover)
        Me.Controls.Add(Me.BunifuPictureBox2)
        Me.Controls.Add(Me.floatingPanel)
        Me.Controls.Add(Me.BODY)
        Me.Controls.Add(Me.TOP)
        Me.MinimumSize = New System.Drawing.Size(816, 539)
        Me.Name = "Dashboard_Main"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.BODY.ResumeLayout(False)
        CType(Me.BunifuPictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BunifuPictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.floatingPanel.ResumeLayout(False)
        Me.TOP.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents floatingPanel As Bunifu.UI.WinForms.BunifuPanel
    Friend WithEvents TOP As Bunifu.UI.WinForms.BunifuPanel
    Friend WithEvents BODY As Panel
    Friend WithEvents BunifuPictureBox1 As Bunifu.UI.WinForms.BunifuPictureBox
    Friend WithEvents BunifuPictureBox2 As Bunifu.UI.WinForms.BunifuPictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents dashboard_btn As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents options_btn As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents history_btn As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents snackbar1 As Bunifu.UI.WinForms.BunifuSnackbar
    Friend WithEvents Main As Panel
    Friend WithEvents Cover As Label
End Class
