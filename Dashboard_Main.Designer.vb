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
        Dim ChartArea1 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend1 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim Series1 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim ChartArea2 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend2 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim Series2 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Me.BODY_PANEL = New System.Windows.Forms.Panel()
        Me.Main = New System.Windows.Forms.Panel()
        Me.BunifuPanel5 = New Bunifu.UI.WinForms.BunifuPanel()
        Me.pump_btn = New Guna.UI2.WinForms.Guna2Button()
        Me.lights_btn = New Guna.UI2.WinForms.Guna2Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.BunifuPanel4 = New Bunifu.UI.WinForms.BunifuPanel()
        Me.plant2_btn = New Guna.UI2.WinForms.Guna2Button()
        Me.plant1_btn = New Guna.UI2.WinForms.Guna2Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.BunifuPanel2 = New Bunifu.UI.WinForms.BunifuPanel()
        Me.battPanel = New System.Windows.Forms.Panel()
        Me.battLevel = New Bunifu.UI.WinForms.BunifuProgressBar()
        Me.battFull = New Bunifu.UI.WinForms.BunifuPanel()
        Me.voltLabel = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.PictureBox6 = New System.Windows.Forms.PictureBox()
        Me.BattVal = New System.Windows.Forms.Label()
        Me.BunifuPanel1 = New Bunifu.UI.WinForms.BunifuPanel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.sunLevel = New Bunifu.UI.WinForms.BunifuCircleProgress()
        Me.SunVal = New System.Windows.Forms.Label()
        Me.PictureBox5 = New System.Windows.Forms.PictureBox()
        Me.chart2_panel = New System.Windows.Forms.Panel()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.TempVal = New System.Windows.Forms.Label()
        Me.Chart2 = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.chart1_panel = New System.Windows.Forms.Panel()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.HumidVal = New System.Windows.Forms.Label()
        Me.Chart1 = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.BOTTOM_PANEL = New System.Windows.Forms.Panel()
        Me.decor1 = New System.Windows.Forms.PictureBox()
        Me.comLabel = New System.Windows.Forms.Label()
        Me.snackbar1 = New Bunifu.UI.WinForms.BunifuSnackbar(Me.components)
        Me.Cover = New System.Windows.Forms.Label()
        Me.dragControl = New Guna.UI2.WinForms.Guna2DragControl(Me.components)
        Me.TOP_PANEL = New Bunifu.UI.WinForms.BunifuPanel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.dateLabel = New System.Windows.Forms.Label()
        Me.PARENT_PANEL = New System.Windows.Forms.Panel()
        Me.BunifuPictureBox3 = New Bunifu.UI.WinForms.BunifuPictureBox()
        Me.BunifuPictureBox2 = New Bunifu.UI.WinForms.BunifuPictureBox()
        Me.floatingPanel = New Bunifu.UI.WinForms.BunifuPanel()
        Me.options_btn = New Guna.UI2.WinForms.Guna2Button()
        Me.history_btn = New Guna.UI2.WinForms.Guna2Button()
        Me.dashboard_btn = New Guna.UI2.WinForms.Guna2Button()
        Me.serial_port = New System.IO.Ports.SerialPort(Me.components)
        Me.COMLISTENER = New System.Windows.Forms.Timer(Me.components)
        Me.SERIALLISTENER = New System.Windows.Forms.Timer(Me.components)
        Me.dateListener = New System.Windows.Forms.Timer(Me.components)
        Me.BunifuToolTip1 = New Bunifu.UI.WinForms.BunifuToolTip(Me.components)
        Me.update_log = New System.Windows.Forms.Timer(Me.components)
        Me.BODY_PANEL.SuspendLayout()
        Me.Main.SuspendLayout()
        Me.BunifuPanel5.SuspendLayout()
        Me.BunifuPanel4.SuspendLayout()
        Me.BunifuPanel2.SuspendLayout()
        Me.battPanel.SuspendLayout()
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.BunifuPanel1.SuspendLayout()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.chart2_panel.SuspendLayout()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Chart2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.chart1_panel.SuspendLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Chart1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.BOTTOM_PANEL.SuspendLayout()
        CType(Me.decor1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TOP_PANEL.SuspendLayout()
        Me.PARENT_PANEL.SuspendLayout()
        CType(Me.BunifuPictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BunifuPictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.floatingPanel.SuspendLayout()
        Me.SuspendLayout()
        '
        'BODY_PANEL
        '
        Me.BODY_PANEL.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BODY_PANEL.BackColor = System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.BODY_PANEL.Controls.Add(Me.Main)
        Me.BODY_PANEL.Location = New System.Drawing.Point(0, 45)
        Me.BODY_PANEL.Margin = New System.Windows.Forms.Padding(0)
        Me.BODY_PANEL.Name = "BODY_PANEL"
        Me.BODY_PANEL.Size = New System.Drawing.Size(800, 415)
        Me.BODY_PANEL.TabIndex = 4
        Me.BunifuToolTip1.SetToolTip(Me.BODY_PANEL, "")
        Me.BunifuToolTip1.SetToolTipIcon(Me.BODY_PANEL, Nothing)
        Me.BunifuToolTip1.SetToolTipTitle(Me.BODY_PANEL, "")
        '
        'Main
        '
        Me.Main.BackColor = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(239, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.Main.Controls.Add(Me.BunifuPanel5)
        Me.Main.Controls.Add(Me.BunifuPanel4)
        Me.Main.Controls.Add(Me.BunifuPanel2)
        Me.Main.Controls.Add(Me.BunifuPanel1)
        Me.Main.Controls.Add(Me.chart2_panel)
        Me.Main.Controls.Add(Me.chart1_panel)
        Me.Main.Controls.Add(Me.PictureBox2)
        Me.Main.Controls.Add(Me.PictureBox1)
        Me.Main.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Main.Location = New System.Drawing.Point(0, 0)
        Me.Main.Name = "Main"
        Me.Main.Size = New System.Drawing.Size(800, 415)
        Me.Main.TabIndex = 0
        Me.BunifuToolTip1.SetToolTip(Me.Main, "")
        Me.BunifuToolTip1.SetToolTipIcon(Me.Main, Nothing)
        Me.BunifuToolTip1.SetToolTipTitle(Me.Main, "")
        '
        'BunifuPanel5
        '
        Me.BunifuPanel5.BackgroundColor = System.Drawing.Color.White
        Me.BunifuPanel5.BackgroundImage = CType(resources.GetObject("BunifuPanel5.BackgroundImage"), System.Drawing.Image)
        Me.BunifuPanel5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BunifuPanel5.BorderColor = System.Drawing.Color.Transparent
        Me.BunifuPanel5.BorderRadius = 16
        Me.BunifuPanel5.BorderThickness = 1
        Me.BunifuPanel5.Controls.Add(Me.pump_btn)
        Me.BunifuPanel5.Controls.Add(Me.lights_btn)
        Me.BunifuPanel5.Controls.Add(Me.Label6)
        Me.BunifuPanel5.Location = New System.Drawing.Point(469, 320)
        Me.BunifuPanel5.Margin = New System.Windows.Forms.Padding(5)
        Me.BunifuPanel5.Name = "BunifuPanel5"
        Me.BunifuPanel5.ShowBorders = True
        Me.BunifuPanel5.Size = New System.Drawing.Size(297, 83)
        Me.BunifuPanel5.TabIndex = 13
        Me.BunifuToolTip1.SetToolTip(Me.BunifuPanel5, "")
        Me.BunifuToolTip1.SetToolTipIcon(Me.BunifuPanel5, Nothing)
        Me.BunifuToolTip1.SetToolTipTitle(Me.BunifuPanel5, "")
        '
        'pump_btn
        '
        Me.pump_btn.Animated = True
        Me.pump_btn.BackColor = System.Drawing.Color.White
        Me.pump_btn.BorderRadius = 10
        Me.pump_btn.CheckedState.Parent = Me.pump_btn
        Me.pump_btn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pump_btn.CustomImages.Parent = Me.pump_btn
        Me.pump_btn.FillColor = System.Drawing.Color.FromArgb(CType(CType(245, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(233, Byte), Integer))
        Me.pump_btn.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.pump_btn.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.pump_btn.HoverState.FillColor = System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(195, Byte), Integer))
        Me.pump_btn.HoverState.Parent = Me.pump_btn
        Me.pump_btn.Image = Global.Smart_Irrigation_System_GUI.My.Resources.Resources.pump_64px
        Me.pump_btn.ImageOffset = New System.Drawing.Point(10, 10)
        Me.pump_btn.ImageSize = New System.Drawing.Size(28, 28)
        Me.pump_btn.Location = New System.Drawing.Point(204, 6)
        Me.pump_btn.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.pump_btn.Name = "pump_btn"
        Me.pump_btn.PressedColor = System.Drawing.Color.White
        Me.pump_btn.PressedDepth = 10
        Me.pump_btn.ShadowDecoration.Parent = Me.pump_btn
        Me.pump_btn.Size = New System.Drawing.Size(82, 70)
        Me.pump_btn.TabIndex = 25
        Me.pump_btn.Tag = "255, 216, 102"
        Me.pump_btn.Text = "Pump"
        Me.pump_btn.TextOffset = New System.Drawing.Point(-7, -18)
        Me.BunifuToolTip1.SetToolTip(Me.pump_btn, "Turn On/Off pump")
        Me.BunifuToolTip1.SetToolTipIcon(Me.pump_btn, Nothing)
        Me.BunifuToolTip1.SetToolTipTitle(Me.pump_btn, "")
        '
        'lights_btn
        '
        Me.lights_btn.Animated = True
        Me.lights_btn.BackColor = System.Drawing.Color.White
        Me.lights_btn.BorderRadius = 10
        Me.lights_btn.CheckedState.Parent = Me.lights_btn
        Me.lights_btn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lights_btn.CustomImages.Parent = Me.lights_btn
        Me.lights_btn.FillColor = System.Drawing.Color.FromArgb(CType(CType(245, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(233, Byte), Integer))
        Me.lights_btn.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lights_btn.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lights_btn.HoverState.FillColor = System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(195, Byte), Integer))
        Me.lights_btn.HoverState.Parent = Me.lights_btn
        Me.lights_btn.Image = Global.Smart_Irrigation_System_GUI.My.Resources.Resources.light_64px
        Me.lights_btn.ImageOffset = New System.Drawing.Point(10, 10)
        Me.lights_btn.ImageSize = New System.Drawing.Size(28, 28)
        Me.lights_btn.Location = New System.Drawing.Point(112, 6)
        Me.lights_btn.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.lights_btn.Name = "lights_btn"
        Me.lights_btn.PressedColor = System.Drawing.Color.White
        Me.lights_btn.PressedDepth = 10
        Me.lights_btn.ShadowDecoration.Parent = Me.lights_btn
        Me.lights_btn.Size = New System.Drawing.Size(82, 70)
        Me.lights_btn.TabIndex = 24
        Me.lights_btn.Tag = "245, 242, 233"
        Me.lights_btn.Text = "Lights"
        Me.lights_btn.TextOffset = New System.Drawing.Point(-7, -18)
        Me.BunifuToolTip1.SetToolTip(Me.lights_btn, "Turn On/Off lights")
        Me.BunifuToolTip1.SetToolTipIcon(Me.lights_btn, Nothing)
        Me.BunifuToolTip1.SetToolTipTitle(Me.lights_btn, "")
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.Color.White
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold)
        Me.Label6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(191, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.Label6.Location = New System.Drawing.Point(12, 0)
        Me.Label6.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(90, 83)
        Me.Label6.TabIndex = 21
        Me.Label6.Text = "Controls"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.BunifuToolTip1.SetToolTip(Me.Label6, "")
        Me.BunifuToolTip1.SetToolTipIcon(Me.Label6, Nothing)
        Me.BunifuToolTip1.SetToolTipTitle(Me.Label6, "")
        '
        'BunifuPanel4
        '
        Me.BunifuPanel4.BackgroundColor = System.Drawing.Color.White
        Me.BunifuPanel4.BackgroundImage = CType(resources.GetObject("BunifuPanel4.BackgroundImage"), System.Drawing.Image)
        Me.BunifuPanel4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BunifuPanel4.BorderColor = System.Drawing.Color.Transparent
        Me.BunifuPanel4.BorderRadius = 16
        Me.BunifuPanel4.BorderThickness = 1
        Me.BunifuPanel4.Controls.Add(Me.plant2_btn)
        Me.BunifuPanel4.Controls.Add(Me.plant1_btn)
        Me.BunifuPanel4.Controls.Add(Me.Label5)
        Me.BunifuPanel4.Location = New System.Drawing.Point(116, 320)
        Me.BunifuPanel4.Margin = New System.Windows.Forms.Padding(5)
        Me.BunifuPanel4.Name = "BunifuPanel4"
        Me.BunifuPanel4.ShowBorders = True
        Me.BunifuPanel4.Size = New System.Drawing.Size(343, 83)
        Me.BunifuPanel4.TabIndex = 12
        Me.BunifuToolTip1.SetToolTip(Me.BunifuPanel4, "")
        Me.BunifuToolTip1.SetToolTipIcon(Me.BunifuPanel4, Nothing)
        Me.BunifuToolTip1.SetToolTipTitle(Me.BunifuPanel4, "")
        '
        'plant2_btn
        '
        Me.plant2_btn.Animated = True
        Me.plant2_btn.BackColor = System.Drawing.Color.White
        Me.plant2_btn.BorderRadius = 10
        Me.plant2_btn.CheckedState.Parent = Me.plant2_btn
        Me.plant2_btn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.plant2_btn.CustomImages.Parent = Me.plant2_btn
        Me.plant2_btn.FillColor = System.Drawing.Color.FromArgb(CType(CType(233, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(239, Byte), Integer))
        Me.plant2_btn.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.plant2_btn.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.plant2_btn.HoverState.FillColor = System.Drawing.Color.FromArgb(CType(CType(195, Byte), Integer), CType(CType(247, Byte), Integer), CType(CType(215, Byte), Integer))
        Me.plant2_btn.HoverState.Parent = Me.plant2_btn
        Me.plant2_btn.Image = Global.Smart_Irrigation_System_GUI.My.Resources.Resources.plant_icon4
        Me.plant2_btn.ImageOffset = New System.Drawing.Point(10, 10)
        Me.plant2_btn.ImageSize = New System.Drawing.Size(22, 26)
        Me.plant2_btn.Location = New System.Drawing.Point(227, 6)
        Me.plant2_btn.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.plant2_btn.Name = "plant2_btn"
        Me.plant2_btn.PressedColor = System.Drawing.Color.White
        Me.plant2_btn.PressedDepth = 10
        Me.plant2_btn.ShadowDecoration.Parent = Me.plant2_btn
        Me.plant2_btn.Size = New System.Drawing.Size(105, 70)
        Me.plant2_btn.TabIndex = 23
        Me.plant2_btn.Text = "Plant 2"
        Me.plant2_btn.TextOffset = New System.Drawing.Point(-7, -18)
        Me.BunifuToolTip1.SetToolTip(Me.plant2_btn, "Waters Plant 2")
        Me.BunifuToolTip1.SetToolTipIcon(Me.plant2_btn, Nothing)
        Me.BunifuToolTip1.SetToolTipTitle(Me.plant2_btn, "")
        '
        'plant1_btn
        '
        Me.plant1_btn.Animated = True
        Me.plant1_btn.BackColor = System.Drawing.Color.White
        Me.plant1_btn.BorderRadius = 10
        Me.plant1_btn.CheckedState.Parent = Me.plant1_btn
        Me.plant1_btn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.plant1_btn.CustomImages.Parent = Me.plant1_btn
        Me.plant1_btn.FillColor = System.Drawing.Color.FromArgb(CType(CType(233, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(239, Byte), Integer))
        Me.plant1_btn.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.plant1_btn.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.plant1_btn.HoverState.FillColor = System.Drawing.Color.FromArgb(CType(CType(195, Byte), Integer), CType(CType(247, Byte), Integer), CType(CType(215, Byte), Integer))
        Me.plant1_btn.HoverState.Parent = Me.plant1_btn
        Me.plant1_btn.Image = CType(resources.GetObject("plant1_btn.Image"), System.Drawing.Image)
        Me.plant1_btn.ImageOffset = New System.Drawing.Point(10, 10)
        Me.plant1_btn.ImageSize = New System.Drawing.Size(22, 26)
        Me.plant1_btn.Location = New System.Drawing.Point(112, 6)
        Me.plant1_btn.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.plant1_btn.Name = "plant1_btn"
        Me.plant1_btn.PressedColor = System.Drawing.Color.White
        Me.plant1_btn.PressedDepth = 10
        Me.plant1_btn.ShadowDecoration.Parent = Me.plant1_btn
        Me.plant1_btn.Size = New System.Drawing.Size(105, 70)
        Me.plant1_btn.TabIndex = 22
        Me.plant1_btn.Text = "Plant 1"
        Me.plant1_btn.TextOffset = New System.Drawing.Point(-7, -18)
        Me.BunifuToolTip1.SetToolTip(Me.plant1_btn, "Waters Plant 1")
        Me.BunifuToolTip1.SetToolTipIcon(Me.plant1_btn, Nothing)
        Me.BunifuToolTip1.SetToolTipTitle(Me.plant1_btn, "")
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.Color.White
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold)
        Me.Label5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(97, Byte), Integer))
        Me.Label5.Location = New System.Drawing.Point(12, 0)
        Me.Label5.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(90, 83)
        Me.Label5.TabIndex = 20
        Me.Label5.Text = "Manual Override"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.BunifuToolTip1.SetToolTip(Me.Label5, "")
        Me.BunifuToolTip1.SetToolTipIcon(Me.Label5, Nothing)
        Me.BunifuToolTip1.SetToolTipTitle(Me.Label5, "")
        '
        'BunifuPanel2
        '
        Me.BunifuPanel2.BackgroundColor = System.Drawing.Color.White
        Me.BunifuPanel2.BackgroundImage = CType(resources.GetObject("BunifuPanel2.BackgroundImage"), System.Drawing.Image)
        Me.BunifuPanel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BunifuPanel2.BorderColor = System.Drawing.Color.Transparent
        Me.BunifuPanel2.BorderRadius = 16
        Me.BunifuPanel2.BorderThickness = 1
        Me.BunifuPanel2.Controls.Add(Me.battPanel)
        Me.BunifuPanel2.Controls.Add(Me.voltLabel)
        Me.BunifuPanel2.Controls.Add(Me.Label3)
        Me.BunifuPanel2.Controls.Add(Me.PictureBox6)
        Me.BunifuPanel2.Controls.Add(Me.BattVal)
        Me.BunifuPanel2.Location = New System.Drawing.Point(546, 170)
        Me.BunifuPanel2.Margin = New System.Windows.Forms.Padding(5)
        Me.BunifuPanel2.Name = "BunifuPanel2"
        Me.BunifuPanel2.ShowBorders = True
        Me.BunifuPanel2.Size = New System.Drawing.Size(220, 140)
        Me.BunifuPanel2.TabIndex = 11
        Me.BunifuToolTip1.SetToolTip(Me.BunifuPanel2, "")
        Me.BunifuToolTip1.SetToolTipIcon(Me.BunifuPanel2, Nothing)
        Me.BunifuToolTip1.SetToolTipTitle(Me.BunifuPanel2, "")
        '
        'battPanel
        '
        Me.battPanel.BackColor = System.Drawing.Color.White
        Me.battPanel.Controls.Add(Me.battLevel)
        Me.battPanel.Controls.Add(Me.battFull)
        Me.battPanel.Location = New System.Drawing.Point(39, 41)
        Me.battPanel.Name = "battPanel"
        Me.battPanel.Size = New System.Drawing.Size(45, 73)
        Me.battPanel.TabIndex = 20
        Me.BunifuToolTip1.SetToolTip(Me.battPanel, "")
        Me.BunifuToolTip1.SetToolTipIcon(Me.battPanel, Nothing)
        Me.BunifuToolTip1.SetToolTipTitle(Me.battPanel, "")
        '
        'battLevel
        '
        Me.battLevel.AllowAnimations = False
        Me.battLevel.Animation = 0
        Me.battLevel.AnimationSpeed = 220
        Me.battLevel.AnimationStep = 10
        Me.battLevel.BackColor = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(235, Byte), Integer))
        Me.battLevel.BackgroundImage = CType(resources.GetObject("battLevel.BackgroundImage"), System.Drawing.Image)
        Me.battLevel.BorderColor = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(235, Byte), Integer))
        Me.battLevel.BorderRadius = 12
        Me.battLevel.BorderThickness = 1
        Me.battLevel.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.battLevel.Location = New System.Drawing.Point(0, 8)
        Me.battLevel.Maximum = 100
        Me.battLevel.MaximumValue = 100
        Me.battLevel.Minimum = 0
        Me.battLevel.MinimumValue = 0
        Me.battLevel.Name = "battLevel"
        Me.battLevel.Orientation = System.Windows.Forms.Orientation.Vertical
        Me.battLevel.ProgressBackColor = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(235, Byte), Integer))
        Me.battLevel.ProgressColorLeft = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(225, Byte), Integer))
        Me.battLevel.ProgressColorRight = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(225, Byte), Integer))
        Me.battLevel.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.battLevel.Size = New System.Drawing.Size(45, 65)
        Me.battLevel.TabIndex = 20
        Me.BunifuToolTip1.SetToolTip(Me.battLevel, "")
        Me.BunifuToolTip1.SetToolTipIcon(Me.battLevel, Nothing)
        Me.BunifuToolTip1.SetToolTipTitle(Me.battLevel, "")
        Me.battLevel.Value = 50
        Me.battLevel.ValueByTransition = 50
        '
        'battFull
        '
        Me.battFull.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.battFull.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(235, Byte), Integer))
        Me.battFull.BackgroundImage = CType(resources.GetObject("battFull.BackgroundImage"), System.Drawing.Image)
        Me.battFull.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.battFull.BorderColor = System.Drawing.Color.Transparent
        Me.battFull.BorderRadius = 4
        Me.battFull.BorderThickness = 0
        Me.battFull.Location = New System.Drawing.Point(13, 0)
        Me.battFull.Name = "battFull"
        Me.battFull.ShowBorders = True
        Me.battFull.Size = New System.Drawing.Size(18, 20)
        Me.battFull.TabIndex = 14
        Me.BunifuToolTip1.SetToolTip(Me.battFull, "")
        Me.BunifuToolTip1.SetToolTipIcon(Me.battFull, Nothing)
        Me.BunifuToolTip1.SetToolTipTitle(Me.battFull, "")
        '
        'voltLabel
        '
        Me.voltLabel.BackColor = System.Drawing.Color.White
        Me.voltLabel.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.voltLabel.ForeColor = System.Drawing.Color.Gray
        Me.voltLabel.Location = New System.Drawing.Point(110, 90)
        Me.voltLabel.Name = "voltLabel"
        Me.voltLabel.Size = New System.Drawing.Size(85, 15)
        Me.voltLabel.TabIndex = 12
        Me.voltLabel.Text = "3.87 V"
        Me.voltLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.BunifuToolTip1.SetToolTip(Me.voltLabel, "")
        Me.BunifuToolTip1.SetToolTipIcon(Me.voltLabel, Nothing)
        Me.BunifuToolTip1.SetToolTipTitle(Me.voltLabel, "")
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.White
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold)
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(225, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(88, 12)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(44, 13)
        Me.Label3.TabIndex = 18
        Me.Label3.Text = "Battery"
        Me.BunifuToolTip1.SetToolTip(Me.Label3, "")
        Me.BunifuToolTip1.SetToolTipIcon(Me.Label3, Nothing)
        Me.BunifuToolTip1.SetToolTipTitle(Me.Label3, "")
        '
        'PictureBox6
        '
        Me.PictureBox6.BackColor = System.Drawing.Color.White
        Me.PictureBox6.Image = Global.Smart_Irrigation_System_GUI.My.Resources.Resources.lightning_bolt_48px
        Me.PictureBox6.Location = New System.Drawing.Point(183, 104)
        Me.PictureBox6.Name = "PictureBox6"
        Me.PictureBox6.Size = New System.Drawing.Size(24, 24)
        Me.PictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox6.TabIndex = 9
        Me.PictureBox6.TabStop = False
        Me.BunifuToolTip1.SetToolTip(Me.PictureBox6, "")
        Me.BunifuToolTip1.SetToolTipIcon(Me.PictureBox6, Nothing)
        Me.BunifuToolTip1.SetToolTipTitle(Me.PictureBox6, "")
        '
        'BattVal
        '
        Me.BattVal.BackColor = System.Drawing.Color.White
        Me.BattVal.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BattVal.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(225, Byte), Integer))
        Me.BattVal.Location = New System.Drawing.Point(105, 50)
        Me.BattVal.Margin = New System.Windows.Forms.Padding(0)
        Me.BattVal.Name = "BattVal"
        Me.BattVal.Size = New System.Drawing.Size(90, 50)
        Me.BattVal.TabIndex = 8
        Me.BattVal.Text = "55 %"
        Me.BattVal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.BunifuToolTip1.SetToolTip(Me.BattVal, "")
        Me.BunifuToolTip1.SetToolTipIcon(Me.BattVal, Nothing)
        Me.BunifuToolTip1.SetToolTipTitle(Me.BattVal, "")
        '
        'BunifuPanel1
        '
        Me.BunifuPanel1.BackgroundColor = System.Drawing.Color.White
        Me.BunifuPanel1.BackgroundImage = CType(resources.GetObject("BunifuPanel1.BackgroundImage"), System.Drawing.Image)
        Me.BunifuPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BunifuPanel1.BorderColor = System.Drawing.Color.Transparent
        Me.BunifuPanel1.BorderRadius = 16
        Me.BunifuPanel1.BorderThickness = 1
        Me.BunifuPanel1.Controls.Add(Me.Label2)
        Me.BunifuPanel1.Controls.Add(Me.sunLevel)
        Me.BunifuPanel1.Controls.Add(Me.SunVal)
        Me.BunifuPanel1.Controls.Add(Me.PictureBox5)
        Me.BunifuPanel1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(200, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.BunifuPanel1.Location = New System.Drawing.Point(546, 20)
        Me.BunifuPanel1.Margin = New System.Windows.Forms.Padding(5)
        Me.BunifuPanel1.Name = "BunifuPanel1"
        Me.BunifuPanel1.ShowBorders = True
        Me.BunifuPanel1.Size = New System.Drawing.Size(220, 140)
        Me.BunifuPanel1.TabIndex = 10
        Me.BunifuToolTip1.SetToolTip(Me.BunifuPanel1, "")
        Me.BunifuToolTip1.SetToolTipIcon(Me.BunifuPanel1, Nothing)
        Me.BunifuToolTip1.SetToolTipTitle(Me.BunifuPanel1, "")
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.White
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold)
        Me.Label2.Location = New System.Drawing.Point(73, 12)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(75, 13)
        Me.Label2.TabIndex = 17
        Me.Label2.Text = "Sun Intensity"
        Me.BunifuToolTip1.SetToolTip(Me.Label2, "")
        Me.BunifuToolTip1.SetToolTipIcon(Me.Label2, Nothing)
        Me.BunifuToolTip1.SetToolTipTitle(Me.Label2, "")
        '
        'sunLevel
        '
        Me.sunLevel.Animated = False
        Me.sunLevel.AnimationInterval = 1
        Me.sunLevel.AnimationSpeed = 1
        Me.sunLevel.BackColor = System.Drawing.Color.Transparent
        Me.sunLevel.CircleMargin = 15
        Me.sunLevel.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.sunLevel.ForeColor = System.Drawing.Color.White
        Me.sunLevel.IsPercentage = False
        Me.sunLevel.LineProgressThickness = 7
        Me.sunLevel.LineThickness = 4
        Me.sunLevel.Location = New System.Drawing.Point(16, 30)
        Me.sunLevel.Name = "sunLevel"
        Me.sunLevel.ProgressAnimationSpeed = 200
        Me.sunLevel.ProgressBackColor = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(235, Byte), Integer))
        Me.sunLevel.ProgressColor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(200, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.sunLevel.ProgressColor2 = System.Drawing.Color.DarkTurquoise
        Me.sunLevel.ProgressEndCap = Bunifu.UI.WinForms.BunifuCircleProgress.CapStyles.Round
        Me.sunLevel.ProgressFillStyle = Bunifu.UI.WinForms.BunifuCircleProgress.FillStyles.Solid
        Me.sunLevel.ProgressStartCap = Bunifu.UI.WinForms.BunifuCircleProgress.CapStyles.Round
        Me.sunLevel.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.sunLevel.SecondaryFont = New System.Drawing.Font("Microsoft Sans Serif", 16.0!)
        Me.sunLevel.Size = New System.Drawing.Size(90, 90)
        Me.sunLevel.Step = 1
        Me.sunLevel.SubScriptColor = System.Drawing.Color.FromArgb(CType(CType(166, Byte), Integer), CType(CType(166, Byte), Integer), CType(CType(166, Byte), Integer))
        Me.sunLevel.SubScriptMargin = New System.Windows.Forms.Padding(5, -20, 0, 0)
        Me.sunLevel.SubScriptText = ""
        Me.sunLevel.SuperScriptColor = System.Drawing.Color.FromArgb(CType(CType(166, Byte), Integer), CType(CType(166, Byte), Integer), CType(CType(166, Byte), Integer))
        Me.sunLevel.SuperScriptMargin = New System.Windows.Forms.Padding(5, 20, 0, 0)
        Me.sunLevel.SuperScriptText = ""
        Me.sunLevel.TabIndex = 16
        Me.sunLevel.Text = "30"
        Me.sunLevel.TextMargin = New System.Windows.Forms.Padding(0, 3, 0, 0)
        Me.BunifuToolTip1.SetToolTip(Me.sunLevel, "")
        Me.BunifuToolTip1.SetToolTipIcon(Me.sunLevel, Nothing)
        Me.BunifuToolTip1.SetToolTipTitle(Me.sunLevel, "")
        Me.sunLevel.Value = 30
        Me.sunLevel.ValueByTransition = 30
        Me.sunLevel.ValueMargin = New System.Windows.Forms.Padding(0, 3, 0, 0)
        '
        'SunVal
        '
        Me.SunVal.BackColor = System.Drawing.Color.White
        Me.SunVal.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SunVal.ForeColor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(200, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.SunVal.Location = New System.Drawing.Point(105, 50)
        Me.SunVal.Margin = New System.Windows.Forms.Padding(0)
        Me.SunVal.Name = "SunVal"
        Me.SunVal.Size = New System.Drawing.Size(90, 50)
        Me.SunVal.TabIndex = 7
        Me.SunVal.Text = "30 %"
        Me.SunVal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.BunifuToolTip1.SetToolTip(Me.SunVal, "")
        Me.BunifuToolTip1.SetToolTipIcon(Me.SunVal, Nothing)
        Me.BunifuToolTip1.SetToolTipTitle(Me.SunVal, "")
        '
        'PictureBox5
        '
        Me.PictureBox5.BackColor = System.Drawing.Color.White
        Me.PictureBox5.Image = Global.Smart_Irrigation_System_GUI.My.Resources.Resources.sun_48px
        Me.PictureBox5.Location = New System.Drawing.Point(183, 104)
        Me.PictureBox5.Name = "PictureBox5"
        Me.PictureBox5.Size = New System.Drawing.Size(24, 24)
        Me.PictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox5.TabIndex = 8
        Me.PictureBox5.TabStop = False
        Me.BunifuToolTip1.SetToolTip(Me.PictureBox5, "")
        Me.BunifuToolTip1.SetToolTipIcon(Me.PictureBox5, Nothing)
        Me.BunifuToolTip1.SetToolTipTitle(Me.PictureBox5, "")
        '
        'chart2_panel
        '
        Me.chart2_panel.Controls.Add(Me.PictureBox4)
        Me.chart2_panel.Controls.Add(Me.TempVal)
        Me.chart2_panel.Controls.Add(Me.Chart2)
        Me.chart2_panel.Location = New System.Drawing.Point(116, 170)
        Me.chart2_panel.Margin = New System.Windows.Forms.Padding(5)
        Me.chart2_panel.Name = "chart2_panel"
        Me.chart2_panel.Size = New System.Drawing.Size(420, 140)
        Me.chart2_panel.TabIndex = 9
        Me.BunifuToolTip1.SetToolTip(Me.chart2_panel, "")
        Me.BunifuToolTip1.SetToolTipIcon(Me.chart2_panel, Nothing)
        Me.BunifuToolTip1.SetToolTipTitle(Me.chart2_panel, "")
        '
        'PictureBox4
        '
        Me.PictureBox4.BackColor = System.Drawing.Color.White
        Me.PictureBox4.Image = Global.Smart_Irrigation_System_GUI.My.Resources.Resources.temperature_48px
        Me.PictureBox4.Location = New System.Drawing.Point(386, 104)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(24, 24)
        Me.PictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox4.TabIndex = 5
        Me.PictureBox4.TabStop = False
        Me.BunifuToolTip1.SetToolTip(Me.PictureBox4, "")
        Me.BunifuToolTip1.SetToolTipIcon(Me.PictureBox4, Nothing)
        Me.BunifuToolTip1.SetToolTipTitle(Me.PictureBox4, "")
        '
        'TempVal
        '
        Me.TempVal.BackColor = System.Drawing.Color.White
        Me.TempVal.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TempVal.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.TempVal.Location = New System.Drawing.Point(270, 50)
        Me.TempVal.Name = "TempVal"
        Me.TempVal.Size = New System.Drawing.Size(144, 50)
        Me.TempVal.TabIndex = 7
        Me.TempVal.Text = "40 °C"
        Me.TempVal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.BunifuToolTip1.SetToolTip(Me.TempVal, "")
        Me.BunifuToolTip1.SetToolTipIcon(Me.TempVal, Nothing)
        Me.BunifuToolTip1.SetToolTipTitle(Me.TempVal, "")
        '
        'Chart2
        '
        ChartArea1.AxisX.IsLabelAutoFit = False
        ChartArea1.AxisX.LabelStyle.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        ChartArea1.AxisX.LabelStyle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(0, Byte), Integer))
        ChartArea1.AxisX.LineColor = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(235, Byte), Integer))
        ChartArea1.AxisX.MajorGrid.LineColor = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(235, Byte), Integer))
        ChartArea1.AxisX.MajorTickMark.LineColor = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(235, Byte), Integer))
        ChartArea1.AxisY.IsLabelAutoFit = False
        ChartArea1.AxisY.LabelStyle.Font = New System.Drawing.Font("Segoe UI Semibold", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        ChartArea1.AxisY.LabelStyle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(0, Byte), Integer))
        ChartArea1.AxisY.LineColor = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(235, Byte), Integer))
        ChartArea1.AxisY.MajorGrid.LineColor = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(235, Byte), Integer))
        ChartArea1.AxisY.MajorTickMark.LineColor = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(235, Byte), Integer))
        ChartArea1.AxisY.MinorGrid.LineColor = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(235, Byte), Integer))
        ChartArea1.AxisY.MinorTickMark.LineColor = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(235, Byte), Integer))
        ChartArea1.BorderColor = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(235, Byte), Integer))
        ChartArea1.Name = "ChartArea1"
        Me.Chart2.ChartAreas.Add(ChartArea1)
        Legend1.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Legend1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(0, Byte), Integer))
        Legend1.IsTextAutoFit = False
        Legend1.Name = "Legend1"
        Me.Chart2.Legends.Add(Legend1)
        Me.Chart2.Location = New System.Drawing.Point(0, 0)
        Me.Chart2.Margin = New System.Windows.Forms.Padding(0)
        Me.Chart2.Name = "Chart2"
        Series1.BorderWidth = 2
        Series1.ChartArea = "ChartArea1"
        Series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline
        Series1.Color = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(0, Byte), Integer))
        Series1.Legend = "Legend1"
        Series1.Name = "Temperature"
        Me.Chart2.Series.Add(Series1)
        Me.Chart2.Size = New System.Drawing.Size(420, 140)
        Me.Chart2.TabIndex = 3
        Me.Chart2.Tag = "255, 153, 0"
        Me.Chart2.Text = "Chart2"
        Me.BunifuToolTip1.SetToolTip(Me.Chart2, "")
        Me.BunifuToolTip1.SetToolTipIcon(Me.Chart2, Nothing)
        Me.BunifuToolTip1.SetToolTipTitle(Me.Chart2, "")
        '
        'chart1_panel
        '
        Me.chart1_panel.Controls.Add(Me.PictureBox3)
        Me.chart1_panel.Controls.Add(Me.HumidVal)
        Me.chart1_panel.Controls.Add(Me.Chart1)
        Me.chart1_panel.Location = New System.Drawing.Point(116, 20)
        Me.chart1_panel.Margin = New System.Windows.Forms.Padding(5)
        Me.chart1_panel.Name = "chart1_panel"
        Me.chart1_panel.Size = New System.Drawing.Size(420, 140)
        Me.chart1_panel.TabIndex = 8
        Me.BunifuToolTip1.SetToolTip(Me.chart1_panel, "")
        Me.BunifuToolTip1.SetToolTipIcon(Me.chart1_panel, Nothing)
        Me.BunifuToolTip1.SetToolTipTitle(Me.chart1_panel, "")
        '
        'PictureBox3
        '
        Me.PictureBox3.BackColor = System.Drawing.Color.White
        Me.PictureBox3.Image = Global.Smart_Irrigation_System_GUI.My.Resources.Resources.humidity_48px
        Me.PictureBox3.Location = New System.Drawing.Point(386, 104)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(24, 24)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox3.TabIndex = 4
        Me.PictureBox3.TabStop = False
        Me.BunifuToolTip1.SetToolTip(Me.PictureBox3, "")
        Me.BunifuToolTip1.SetToolTipIcon(Me.PictureBox3, Nothing)
        Me.BunifuToolTip1.SetToolTipTitle(Me.PictureBox3, "")
        '
        'HumidVal
        '
        Me.HumidVal.BackColor = System.Drawing.Color.White
        Me.HumidVal.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.HumidVal.ForeColor = System.Drawing.Color.FromArgb(CType(CType(96, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.HumidVal.Location = New System.Drawing.Point(270, 50)
        Me.HumidVal.Name = "HumidVal"
        Me.HumidVal.Size = New System.Drawing.Size(144, 50)
        Me.HumidVal.TabIndex = 6
        Me.HumidVal.Text = "80 %"
        Me.HumidVal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.BunifuToolTip1.SetToolTip(Me.HumidVal, "")
        Me.BunifuToolTip1.SetToolTipIcon(Me.HumidVal, Nothing)
        Me.BunifuToolTip1.SetToolTipTitle(Me.HumidVal, "")
        '
        'Chart1
        '
        ChartArea2.AxisX.IsLabelAutoFit = False
        ChartArea2.AxisX.LabelStyle.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        ChartArea2.AxisX.LabelStyle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(96, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(249, Byte), Integer))
        ChartArea2.AxisX.LineColor = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(235, Byte), Integer))
        ChartArea2.AxisX.MajorGrid.LineColor = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(235, Byte), Integer))
        ChartArea2.AxisX.MajorTickMark.LineColor = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(235, Byte), Integer))
        ChartArea2.AxisY.IsLabelAutoFit = False
        ChartArea2.AxisY.LabelStyle.Font = New System.Drawing.Font("Segoe UI Semibold", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        ChartArea2.AxisY.LabelStyle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(96, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(249, Byte), Integer))
        ChartArea2.AxisY.LineColor = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(235, Byte), Integer))
        ChartArea2.AxisY.MajorGrid.LineColor = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(235, Byte), Integer))
        ChartArea2.AxisY.MajorTickMark.LineColor = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(235, Byte), Integer))
        ChartArea2.Name = "ChartArea1"
        Me.Chart1.ChartAreas.Add(ChartArea2)
        Legend2.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Legend2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(96, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(249, Byte), Integer))
        Legend2.IsTextAutoFit = False
        Legend2.Name = "Legend1"
        Me.Chart1.Legends.Add(Legend2)
        Me.Chart1.Location = New System.Drawing.Point(0, 0)
        Me.Chart1.Margin = New System.Windows.Forms.Padding(0)
        Me.Chart1.Name = "Chart1"
        Series2.BorderWidth = 2
        Series2.ChartArea = "ChartArea1"
        Series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline
        Series2.Color = System.Drawing.Color.FromArgb(CType(CType(96, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(249, Byte), Integer))
        Series2.Legend = "Legend1"
        Series2.Name = "Humidity       "
        Me.Chart1.Series.Add(Series2)
        Me.Chart1.Size = New System.Drawing.Size(420, 140)
        Me.Chart1.TabIndex = 2
        Me.Chart1.Tag = "96, 180, 249"
        Me.Chart1.Text = "Chart1"
        Me.BunifuToolTip1.SetToolTip(Me.Chart1, "")
        Me.BunifuToolTip1.SetToolTipIcon(Me.Chart1, Nothing)
        Me.BunifuToolTip1.SetToolTipTitle(Me.Chart1, "")
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = Global.Smart_Irrigation_System_GUI.My.Resources.Resources.plant6
        Me.PictureBox2.Location = New System.Drawing.Point(-78, -57)
        Me.PictureBox2.Margin = New System.Windows.Forms.Padding(0)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(176, 228)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox2.TabIndex = 1
        Me.PictureBox2.TabStop = False
        Me.BunifuToolTip1.SetToolTip(Me.PictureBox2, "")
        Me.BunifuToolTip1.SetToolTipIcon(Me.PictureBox2, Nothing)
        Me.BunifuToolTip1.SetToolTipTitle(Me.PictureBox2, "")
        '
        'PictureBox1
        '
        Me.PictureBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PictureBox1.Image = Global.Smart_Irrigation_System_GUI.My.Resources.Resources.plant3
        Me.PictureBox1.Location = New System.Drawing.Point(618, 136)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(247, 324)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        Me.PictureBox1.Tag = "211, 280"
        Me.BunifuToolTip1.SetToolTip(Me.PictureBox1, "")
        Me.BunifuToolTip1.SetToolTipIcon(Me.PictureBox1, Nothing)
        Me.BunifuToolTip1.SetToolTipTitle(Me.PictureBox1, "")
        '
        'BOTTOM_PANEL
        '
        Me.BOTTOM_PANEL.BackColor = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(239, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.BOTTOM_PANEL.Controls.Add(Me.decor1)
        Me.BOTTOM_PANEL.Controls.Add(Me.comLabel)
        Me.BOTTOM_PANEL.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.BOTTOM_PANEL.Location = New System.Drawing.Point(0, 460)
        Me.BOTTOM_PANEL.Margin = New System.Windows.Forms.Padding(0)
        Me.BOTTOM_PANEL.Name = "BOTTOM_PANEL"
        Me.BOTTOM_PANEL.Size = New System.Drawing.Size(800, 40)
        Me.BOTTOM_PANEL.TabIndex = 5
        Me.BunifuToolTip1.SetToolTip(Me.BOTTOM_PANEL, "")
        Me.BunifuToolTip1.SetToolTipIcon(Me.BOTTOM_PANEL, Nothing)
        Me.BunifuToolTip1.SetToolTipTitle(Me.BOTTOM_PANEL, "")
        '
        'decor1
        '
        Me.decor1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.decor1.Image = Global.Smart_Irrigation_System_GUI.My.Resources.Resources.plant3
        Me.decor1.Location = New System.Drawing.Point(618, -278)
        Me.decor1.Margin = New System.Windows.Forms.Padding(0)
        Me.decor1.Name = "decor1"
        Me.decor1.Size = New System.Drawing.Size(247, 324)
        Me.decor1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.decor1.TabIndex = 1
        Me.decor1.TabStop = False
        Me.BunifuToolTip1.SetToolTip(Me.decor1, "")
        Me.BunifuToolTip1.SetToolTipIcon(Me.decor1, Nothing)
        Me.BunifuToolTip1.SetToolTipTitle(Me.decor1, "")
        '
        'comLabel
        '
        Me.comLabel.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.comLabel.Font = New System.Drawing.Font("Segoe UI", 9.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.comLabel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(54, Byte), Integer), CType(CType(115, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.comLabel.Location = New System.Drawing.Point(16, 5)
        Me.comLabel.Name = "comLabel"
        Me.comLabel.Size = New System.Drawing.Size(118, 30)
        Me.comLabel.TabIndex = 0
        Me.comLabel.Text = "COM"
        Me.comLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BunifuToolTip1.SetToolTip(Me.comLabel, "")
        Me.BunifuToolTip1.SetToolTipIcon(Me.comLabel, Nothing)
        Me.BunifuToolTip1.SetToolTipTitle(Me.comLabel, "")
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
        Me.Cover.Location = New System.Drawing.Point(17, -10)
        Me.Cover.Name = "Cover"
        Me.Cover.Size = New System.Drawing.Size(76, 46)
        Me.Cover.TabIndex = 1
        Me.BunifuToolTip1.SetToolTip(Me.Cover, "")
        Me.BunifuToolTip1.SetToolTipIcon(Me.Cover, Nothing)
        Me.BunifuToolTip1.SetToolTipTitle(Me.Cover, "")
        '
        'dragControl
        '
        Me.dragControl.TargetControl = Me.TOP_PANEL
        '
        'TOP_PANEL
        '
        Me.TOP_PANEL.BackgroundColor = System.Drawing.Color.White
        Me.TOP_PANEL.BackgroundImage = CType(resources.GetObject("TOP_PANEL.BackgroundImage"), System.Drawing.Image)
        Me.TOP_PANEL.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.TOP_PANEL.BorderColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(228, Byte), Integer), CType(CType(230, Byte), Integer))
        Me.TOP_PANEL.BorderRadius = 50
        Me.TOP_PANEL.BorderThickness = 1
        Me.TOP_PANEL.Controls.Add(Me.Label1)
        Me.TOP_PANEL.Controls.Add(Me.Label4)
        Me.TOP_PANEL.Controls.Add(Me.dateLabel)
        Me.TOP_PANEL.Location = New System.Drawing.Point(-5, -18)
        Me.TOP_PANEL.Margin = New System.Windows.Forms.Padding(0)
        Me.TOP_PANEL.Name = "TOP_PANEL"
        Me.TOP_PANEL.ShowBorders = True
        Me.TOP_PANEL.Size = New System.Drawing.Size(818, 63)
        Me.TOP_PANEL.TabIndex = 3
        Me.BunifuToolTip1.SetToolTip(Me.TOP_PANEL, "")
        Me.BunifuToolTip1.SetToolTipIcon(Me.TOP_PANEL, Nothing)
        Me.BunifuToolTip1.SetToolTipTitle(Me.TOP_PANEL, "")
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.White
        Me.Label1.Font = New System.Drawing.Font("Segoe UI Semibold", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(104, 31)
        Me.Label1.Margin = New System.Windows.Forms.Padding(0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(77, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "PLANTITO"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BunifuToolTip1.SetToolTip(Me.Label1, "")
        Me.BunifuToolTip1.SetToolTipIcon(Me.Label1, Nothing)
        Me.BunifuToolTip1.SetToolTipTitle(Me.Label1, "")
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.White
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.DarkGray
        Me.Label4.Location = New System.Drawing.Point(181, 31)
        Me.Label4.Margin = New System.Windows.Forms.Padding(0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(168, 20)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "SMART IRRIGATION SYSTEM"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BunifuToolTip1.SetToolTip(Me.Label4, "")
        Me.BunifuToolTip1.SetToolTipIcon(Me.Label4, Nothing)
        Me.BunifuToolTip1.SetToolTipTitle(Me.Label4, "")
        '
        'dateLabel
        '
        Me.dateLabel.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dateLabel.BackColor = System.Drawing.Color.White
        Me.dateLabel.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dateLabel.Location = New System.Drawing.Point(651, 31)
        Me.dateLabel.Name = "dateLabel"
        Me.dateLabel.Size = New System.Drawing.Size(142, 23)
        Me.dateLabel.TabIndex = 1
        Me.dateLabel.Text = "Time"
        Me.dateLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BunifuToolTip1.SetToolTip(Me.dateLabel, "")
        Me.BunifuToolTip1.SetToolTipIcon(Me.dateLabel, Nothing)
        Me.BunifuToolTip1.SetToolTipTitle(Me.dateLabel, "")
        '
        'PARENT_PANEL
        '
        Me.PARENT_PANEL.BackColor = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(239, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.PARENT_PANEL.Controls.Add(Me.BunifuPictureBox3)
        Me.PARENT_PANEL.Controls.Add(Me.Cover)
        Me.PARENT_PANEL.Controls.Add(Me.BunifuPictureBox2)
        Me.PARENT_PANEL.Controls.Add(Me.TOP_PANEL)
        Me.PARENT_PANEL.Controls.Add(Me.floatingPanel)
        Me.PARENT_PANEL.Controls.Add(Me.BODY_PANEL)
        Me.PARENT_PANEL.Controls.Add(Me.BOTTOM_PANEL)
        Me.PARENT_PANEL.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PARENT_PANEL.Location = New System.Drawing.Point(0, 0)
        Me.PARENT_PANEL.Name = "PARENT_PANEL"
        Me.PARENT_PANEL.Size = New System.Drawing.Size(800, 500)
        Me.PARENT_PANEL.TabIndex = 5
        Me.BunifuToolTip1.SetToolTip(Me.PARENT_PANEL, "")
        Me.BunifuToolTip1.SetToolTipIcon(Me.PARENT_PANEL, Nothing)
        Me.BunifuToolTip1.SetToolTipTitle(Me.PARENT_PANEL, "")
        '
        'BunifuPictureBox3
        '
        Me.BunifuPictureBox3.AllowFocused = False
        Me.BunifuPictureBox3.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.BunifuPictureBox3.AutoSizeHeight = True
        Me.BunifuPictureBox3.BackColor = System.Drawing.Color.White
        Me.BunifuPictureBox3.BorderRadius = 25
        Me.BunifuPictureBox3.Image = Global.Smart_Irrigation_System_GUI.My.Resources.Resources.Logo
        Me.BunifuPictureBox3.IsCircle = False
        Me.BunifuPictureBox3.Location = New System.Drawing.Point(30, 3)
        Me.BunifuPictureBox3.Name = "BunifuPictureBox3"
        Me.BunifuPictureBox3.Size = New System.Drawing.Size(50, 50)
        Me.BunifuPictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.BunifuPictureBox3.TabIndex = 4
        Me.BunifuPictureBox3.TabStop = False
        Me.BunifuToolTip1.SetToolTip(Me.BunifuPictureBox3, "")
        Me.BunifuToolTip1.SetToolTipIcon(Me.BunifuPictureBox3, Nothing)
        Me.BunifuToolTip1.SetToolTipTitle(Me.BunifuPictureBox3, "")
        Me.BunifuPictureBox3.Type = Bunifu.UI.WinForms.BunifuPictureBox.Types.Circle
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
        Me.BunifuPictureBox2.Location = New System.Drawing.Point(17, -10)
        Me.BunifuPictureBox2.Margin = New System.Windows.Forms.Padding(10)
        Me.BunifuPictureBox2.Name = "BunifuPictureBox2"
        Me.BunifuPictureBox2.Size = New System.Drawing.Size(76, 76)
        Me.BunifuPictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.BunifuPictureBox2.TabIndex = 3
        Me.BunifuPictureBox2.TabStop = False
        Me.BunifuToolTip1.SetToolTip(Me.BunifuPictureBox2, "")
        Me.BunifuToolTip1.SetToolTipIcon(Me.BunifuPictureBox2, Nothing)
        Me.BunifuToolTip1.SetToolTipTitle(Me.BunifuPictureBox2, "")
        Me.BunifuPictureBox2.Type = Bunifu.UI.WinForms.BunifuPictureBox.Types.Circle
        '
        'floatingPanel
        '
        Me.floatingPanel.Anchor = System.Windows.Forms.AnchorStyles.Left
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
        Me.floatingPanel.MaximumSize = New System.Drawing.Size(44, 169)
        Me.floatingPanel.MinimumSize = New System.Drawing.Size(44, 169)
        Me.floatingPanel.Name = "floatingPanel"
        Me.floatingPanel.ShowBorders = True
        Me.floatingPanel.Size = New System.Drawing.Size(44, 169)
        Me.floatingPanel.TabIndex = 2
        Me.BunifuToolTip1.SetToolTip(Me.floatingPanel, "")
        Me.BunifuToolTip1.SetToolTipIcon(Me.floatingPanel, Nothing)
        Me.BunifuToolTip1.SetToolTipTitle(Me.floatingPanel, "")
        '
        'options_btn
        '
        Me.options_btn.Animated = True
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
        Me.options_btn.Image = Global.Smart_Irrigation_System_GUI.My.Resources.Resources.info_48px_gray
        Me.options_btn.ImageOffset = New System.Drawing.Point(1, 0)
        Me.options_btn.ImageSize = New System.Drawing.Size(17, 17)
        Me.options_btn.Location = New System.Drawing.Point(5, 115)
        Me.options_btn.Margin = New System.Windows.Forms.Padding(0)
        Me.options_btn.Name = "options_btn"
        Me.options_btn.PressedColor = System.Drawing.Color.White
        Me.options_btn.PressedDepth = 15
        Me.options_btn.ShadowDecoration.Parent = Me.options_btn
        Me.options_btn.Size = New System.Drawing.Size(34, 34)
        Me.options_btn.TabIndex = 7
        Me.BunifuToolTip1.SetToolTip(Me.options_btn, "View Info")
        Me.BunifuToolTip1.SetToolTipIcon(Me.options_btn, Nothing)
        Me.BunifuToolTip1.SetToolTipTitle(Me.options_btn, "")
        '
        'history_btn
        '
        Me.history_btn.Animated = True
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
        Me.history_btn.Image = Global.Smart_Irrigation_System_GUI.My.Resources.Resources.hour_glass_48px_gray
        Me.history_btn.ImageOffset = New System.Drawing.Point(1, 0)
        Me.history_btn.ImageSize = New System.Drawing.Size(18, 18)
        Me.history_btn.Location = New System.Drawing.Point(5, 67)
        Me.history_btn.Margin = New System.Windows.Forms.Padding(0)
        Me.history_btn.Name = "history_btn"
        Me.history_btn.PressedColor = System.Drawing.Color.White
        Me.history_btn.PressedDepth = 15
        Me.history_btn.ShadowDecoration.Parent = Me.history_btn
        Me.history_btn.Size = New System.Drawing.Size(34, 34)
        Me.history_btn.TabIndex = 7
        Me.BunifuToolTip1.SetToolTip(Me.history_btn, "View Log")
        Me.BunifuToolTip1.SetToolTipIcon(Me.history_btn, Nothing)
        Me.BunifuToolTip1.SetToolTipTitle(Me.history_btn, "")
        '
        'dashboard_btn
        '
        Me.dashboard_btn.Animated = True
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
        Me.dashboard_btn.PressedColor = System.Drawing.Color.White
        Me.dashboard_btn.PressedDepth = 15
        Me.dashboard_btn.ShadowDecoration.Parent = Me.dashboard_btn
        Me.dashboard_btn.Size = New System.Drawing.Size(34, 34)
        Me.dashboard_btn.TabIndex = 7
        Me.dashboard_btn.Tag = "57, 163, 103"
        Me.BunifuToolTip1.SetToolTip(Me.dashboard_btn, "View Dashboard")
        Me.BunifuToolTip1.SetToolTipIcon(Me.dashboard_btn, Nothing)
        Me.BunifuToolTip1.SetToolTipTitle(Me.dashboard_btn, "")
        '
        'serial_port
        '
        Me.serial_port.ReadTimeout = 50
        '
        'COMLISTENER
        '
        '
        'SERIALLISTENER
        '
        Me.SERIALLISTENER.Interval = 1000
        '
        'dateListener
        '
        Me.dateListener.Interval = 500
        '
        'BunifuToolTip1
        '
        Me.BunifuToolTip1.Active = True
        Me.BunifuToolTip1.AlignTextWithTitle = False
        Me.BunifuToolTip1.AllowAutoClose = False
        Me.BunifuToolTip1.AllowFading = True
        Me.BunifuToolTip1.AutoCloseDuration = 5000
        Me.BunifuToolTip1.BackColor = System.Drawing.SystemColors.Control
        Me.BunifuToolTip1.BorderColor = System.Drawing.Color.Gainsboro
        Me.BunifuToolTip1.ClickToShowDisplayControl = False
        Me.BunifuToolTip1.ConvertNewlinesToBreakTags = True
        Me.BunifuToolTip1.DisplayControl = Nothing
        Me.BunifuToolTip1.EntryAnimationSpeed = 350
        Me.BunifuToolTip1.ExitAnimationSpeed = 200
        Me.BunifuToolTip1.GenerateAutoCloseDuration = False
        Me.BunifuToolTip1.IconMargin = 6
        Me.BunifuToolTip1.InitialDelay = 0
        Me.BunifuToolTip1.Name = "BunifuToolTip1"
        Me.BunifuToolTip1.Opacity = 1.0R
        Me.BunifuToolTip1.OverrideToolTipTitles = False
        Me.BunifuToolTip1.Padding = New System.Windows.Forms.Padding(10)
        Me.BunifuToolTip1.ReshowDelay = 100
        Me.BunifuToolTip1.ShowAlways = True
        Me.BunifuToolTip1.ShowBorders = False
        Me.BunifuToolTip1.ShowIcons = True
        Me.BunifuToolTip1.ShowShadows = True
        Me.BunifuToolTip1.Tag = Nothing
        Me.BunifuToolTip1.TextFont = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.BunifuToolTip1.TextForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.BunifuToolTip1.TextMargin = 2
        Me.BunifuToolTip1.TitleFont = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.BunifuToolTip1.TitleForeColor = System.Drawing.Color.Black
        Me.BunifuToolTip1.ToolTipPosition = New System.Drawing.Point(0, 0)
        Me.BunifuToolTip1.ToolTipTitle = Nothing
        '
        'update_log
        '
        Me.update_log.Interval = 500
        '
        'Dashboard_Main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(239, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(800, 500)
        Me.Controls.Add(Me.PARENT_PANEL)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(816, 539)
        Me.MinimumSize = New System.Drawing.Size(816, 539)
        Me.Name = "Dashboard_Main"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Tag = "816, 539"
        Me.BODY_PANEL.ResumeLayout(False)
        Me.Main.ResumeLayout(False)
        Me.BunifuPanel5.ResumeLayout(False)
        Me.BunifuPanel4.ResumeLayout(False)
        Me.BunifuPanel2.ResumeLayout(False)
        Me.BunifuPanel2.PerformLayout()
        Me.battPanel.ResumeLayout(False)
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).EndInit()
        Me.BunifuPanel1.ResumeLayout(False)
        Me.BunifuPanel1.PerformLayout()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).EndInit()
        Me.chart2_panel.ResumeLayout(False)
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Chart2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.chart1_panel.ResumeLayout(False)
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Chart1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.BOTTOM_PANEL.ResumeLayout(False)
        CType(Me.decor1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TOP_PANEL.ResumeLayout(False)
        Me.TOP_PANEL.PerformLayout()
        Me.PARENT_PANEL.ResumeLayout(False)
        CType(Me.BunifuPictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BunifuPictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.floatingPanel.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents floatingPanel As Bunifu.UI.WinForms.BunifuPanel
    Friend WithEvents TOP_PANEL As Bunifu.UI.WinForms.BunifuPanel
    Friend WithEvents BODY_PANEL As Panel
    Friend WithEvents BunifuPictureBox2 As Bunifu.UI.WinForms.BunifuPictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents dashboard_btn As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents options_btn As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents history_btn As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents snackbar1 As Bunifu.UI.WinForms.BunifuSnackbar
    Friend WithEvents Main As Panel
    Friend WithEvents Cover As Label
    Friend WithEvents dragControl As Guna.UI2.WinForms.Guna2DragControl
    Friend WithEvents BOTTOM_PANEL As Panel
    Friend WithEvents PARENT_PANEL As Panel
    Friend WithEvents BunifuPictureBox3 As Bunifu.UI.WinForms.BunifuPictureBox
    Friend WithEvents comLabel As Label
    Friend WithEvents COMLISTENER As Timer
    Friend WithEvents serial_port As IO.Ports.SerialPort
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Chart2 As DataVisualization.Charting.Chart
    Friend WithEvents Chart1 As DataVisualization.Charting.Chart
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents HumidVal As Label
    Friend WithEvents TempVal As Label
    Friend WithEvents SERIALLISTENER As Timer
    Friend WithEvents chart2_panel As Panel
    Friend WithEvents chart1_panel As Panel
    Friend WithEvents BunifuPanel2 As Bunifu.UI.WinForms.BunifuPanel
    Friend WithEvents BunifuPanel1 As Bunifu.UI.WinForms.BunifuPanel
    Friend WithEvents BattVal As Label
    Friend WithEvents PictureBox5 As PictureBox
    Friend WithEvents SunVal As Label
    Friend WithEvents PictureBox6 As PictureBox
    Friend WithEvents sunLevel As Bunifu.UI.WinForms.BunifuCircleProgress
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents voltLabel As Label
    Friend WithEvents BunifuPanel5 As Bunifu.UI.WinForms.BunifuPanel
    Friend WithEvents BunifuPanel4 As Bunifu.UI.WinForms.BunifuPanel
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents plant1_btn As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents plant2_btn As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents lights_btn As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents pump_btn As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents decor1 As PictureBox
    Friend WithEvents battPanel As Panel
    Friend WithEvents battLevel As Bunifu.UI.WinForms.BunifuProgressBar
    Friend WithEvents battFull As Bunifu.UI.WinForms.BunifuPanel
    Friend WithEvents dateLabel As Label
    Friend WithEvents dateListener As Timer
    Friend WithEvents BunifuToolTip1 As Bunifu.UI.WinForms.BunifuToolTip
    Friend WithEvents update_log As Timer
    Friend WithEvents Label4 As Label
End Class
