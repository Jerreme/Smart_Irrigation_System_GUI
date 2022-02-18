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
        Dim ChartArea3 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend3 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim Series3 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim ChartArea4 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend4 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim Series4 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Dashboard_Main))
        Me.BODY = New System.Windows.Forms.Panel()
        Me.Main = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.Chart2 = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.Chart1 = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.BOTTOM = New System.Windows.Forms.Panel()
        Me.comLabel = New System.Windows.Forms.Label()
        Me.snackbar1 = New Bunifu.UI.WinForms.BunifuSnackbar(Me.components)
        Me.Cover = New System.Windows.Forms.Label()
        Me.Guna2DragControl1 = New Guna.UI2.WinForms.Guna2DragControl(Me.components)
        Me.TOP = New Bunifu.UI.WinForms.BunifuPanel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PARENT = New System.Windows.Forms.Panel()
        Me.BunifuPictureBox3 = New Bunifu.UI.WinForms.BunifuPictureBox()
        Me.BunifuPictureBox2 = New Bunifu.UI.WinForms.BunifuPictureBox()
        Me.floatingPanel = New Bunifu.UI.WinForms.BunifuPanel()
        Me.options_btn = New Guna.UI2.WinForms.Guna2Button()
        Me.history_btn = New Guna.UI2.WinForms.Guna2Button()
        Me.dashboard_btn = New Guna.UI2.WinForms.Guna2Button()
        Me.serial_port = New System.IO.Ports.SerialPort(Me.components)
        Me.COMLISTENER = New System.Windows.Forms.Timer(Me.components)
        Me.Label3 = New System.Windows.Forms.Label()
        Me.BODY.SuspendLayout()
        Me.Main.SuspendLayout()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Chart2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Chart1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.BOTTOM.SuspendLayout()
        Me.TOP.SuspendLayout()
        Me.PARENT.SuspendLayout()
        CType(Me.BunifuPictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BunifuPictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.floatingPanel.SuspendLayout()
        Me.SuspendLayout()
        '
        'BODY
        '
        Me.BODY.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BODY.BackColor = System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.BODY.Controls.Add(Me.Main)
        Me.BODY.Location = New System.Drawing.Point(0, 45)
        Me.BODY.Margin = New System.Windows.Forms.Padding(0)
        Me.BODY.Name = "BODY"
        Me.BODY.Size = New System.Drawing.Size(800, 415)
        Me.BODY.TabIndex = 4
        '
        'Main
        '
        Me.Main.BackColor = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(239, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.Main.Controls.Add(Me.Label3)
        Me.Main.Controls.Add(Me.Label2)
        Me.Main.Controls.Add(Me.PictureBox4)
        Me.Main.Controls.Add(Me.PictureBox3)
        Me.Main.Controls.Add(Me.Chart2)
        Me.Main.Controls.Add(Me.Chart1)
        Me.Main.Controls.Add(Me.PictureBox2)
        Me.Main.Controls.Add(Me.PictureBox1)
        Me.Main.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Main.Location = New System.Drawing.Point(0, 0)
        Me.Main.Name = "Main"
        Me.Main.Size = New System.Drawing.Size(800, 415)
        Me.Main.TabIndex = 0
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.White
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(96, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(411, 90)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(144, 50)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "80 %"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PictureBox4
        '
        Me.PictureBox4.BackColor = System.Drawing.Color.White
        Me.PictureBox4.Image = Global.Smart_Irrigation_System_GUI.My.Resources.Resources.temperature_48px
        Me.PictureBox4.Location = New System.Drawing.Point(521, 297)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(24, 24)
        Me.PictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox4.TabIndex = 5
        Me.PictureBox4.TabStop = False
        '
        'PictureBox3
        '
        Me.PictureBox3.BackColor = System.Drawing.Color.White
        Me.PictureBox3.Image = Global.Smart_Irrigation_System_GUI.My.Resources.Resources.humidity_48px
        Me.PictureBox3.Location = New System.Drawing.Point(521, 154)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(24, 24)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox3.TabIndex = 4
        Me.PictureBox3.TabStop = False
        '
        'Chart2
        '
        ChartArea3.AxisX.IsLabelAutoFit = False
        ChartArea3.AxisX.LabelStyle.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        ChartArea3.AxisX.LabelStyle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(0, Byte), Integer))
        ChartArea3.AxisX.LineColor = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(235, Byte), Integer))
        ChartArea3.AxisX.MajorGrid.LineColor = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(235, Byte), Integer))
        ChartArea3.AxisX.MajorTickMark.LineColor = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(235, Byte), Integer))
        ChartArea3.AxisY.IsLabelAutoFit = False
        ChartArea3.AxisY.LabelStyle.Font = New System.Drawing.Font("Segoe UI Semibold", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        ChartArea3.AxisY.LabelStyle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(0, Byte), Integer))
        ChartArea3.AxisY.LineColor = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(235, Byte), Integer))
        ChartArea3.AxisY.MajorGrid.LineColor = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(235, Byte), Integer))
        ChartArea3.AxisY.MajorTickMark.LineColor = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(235, Byte), Integer))
        ChartArea3.AxisY.MinorGrid.LineColor = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(235, Byte), Integer))
        ChartArea3.AxisY.MinorTickMark.LineColor = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(235, Byte), Integer))
        ChartArea3.BorderColor = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(235, Byte), Integer))
        ChartArea3.Name = "ChartArea1"
        Me.Chart2.ChartAreas.Add(ChartArea3)
        Legend3.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Legend3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(0, Byte), Integer))
        Legend3.IsTextAutoFit = False
        Legend3.Name = "Legend1"
        Me.Chart2.Legends.Add(Legend3)
        Me.Chart2.Location = New System.Drawing.Point(126, 194)
        Me.Chart2.Name = "Chart2"
        Series3.BorderWidth = 2
        Series3.ChartArea = "ChartArea1"
        Series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline
        Series3.Color = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(0, Byte), Integer))
        Series3.Legend = "Legend1"
        Series3.Name = "Temperature"
        Me.Chart2.Series.Add(Series3)
        Me.Chart2.Size = New System.Drawing.Size(429, 137)
        Me.Chart2.TabIndex = 3
        Me.Chart2.Tag = "255, 153, 0"
        Me.Chart2.Text = "Chart2"
        '
        'Chart1
        '
        ChartArea4.AxisX.IsLabelAutoFit = False
        ChartArea4.AxisX.LabelStyle.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        ChartArea4.AxisX.LabelStyle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(96, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(249, Byte), Integer))
        ChartArea4.AxisX.LineColor = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(235, Byte), Integer))
        ChartArea4.AxisX.MajorGrid.LineColor = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(235, Byte), Integer))
        ChartArea4.AxisX.MajorTickMark.LineColor = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(235, Byte), Integer))
        ChartArea4.AxisY.IsLabelAutoFit = False
        ChartArea4.AxisY.LabelStyle.Font = New System.Drawing.Font("Segoe UI Semibold", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        ChartArea4.AxisY.LabelStyle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(96, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(249, Byte), Integer))
        ChartArea4.AxisY.LineColor = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(235, Byte), Integer))
        ChartArea4.AxisY.MajorGrid.LineColor = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(235, Byte), Integer))
        ChartArea4.AxisY.MajorTickMark.LineColor = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(235, Byte), Integer))
        ChartArea4.Name = "ChartArea1"
        Me.Chart1.ChartAreas.Add(ChartArea4)
        Legend4.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Legend4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(96, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(249, Byte), Integer))
        Legend4.IsTextAutoFit = False
        Legend4.Name = "Legend1"
        Me.Chart1.Legends.Add(Legend4)
        Me.Chart1.Location = New System.Drawing.Point(128, 51)
        Me.Chart1.Name = "Chart1"
        Series4.BorderWidth = 2
        Series4.ChartArea = "ChartArea1"
        Series4.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline
        Series4.Color = System.Drawing.Color.FromArgb(CType(CType(96, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(249, Byte), Integer))
        Series4.Legend = "Legend1"
        Series4.Name = "Humidity       "
        Me.Chart1.Series.Add(Series4)
        Me.Chart1.Size = New System.Drawing.Size(427, 137)
        Me.Chart1.TabIndex = 2
        Me.Chart1.Tag = "96, 180, 249"
        Me.Chart1.Text = "Chart1"
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
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Smart_Irrigation_System_GUI.My.Resources.Resources.plant3
        Me.PictureBox1.Location = New System.Drawing.Point(657, 139)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(211, 280)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'BOTTOM
        '
        Me.BOTTOM.BackColor = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(239, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.BOTTOM.Controls.Add(Me.comLabel)
        Me.BOTTOM.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.BOTTOM.Location = New System.Drawing.Point(0, 460)
        Me.BOTTOM.Margin = New System.Windows.Forms.Padding(0)
        Me.BOTTOM.Name = "BOTTOM"
        Me.BOTTOM.Size = New System.Drawing.Size(800, 40)
        Me.BOTTOM.TabIndex = 5
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
        '
        'snackbar1
        '
        Me.snackbar1.AllowDragging = False
        Me.snackbar1.AllowMultipleViews = False
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
        Me.Cover.Size = New System.Drawing.Size(76, 55)
        Me.Cover.TabIndex = 1
        '
        'Guna2DragControl1
        '
        Me.Guna2DragControl1.TargetControl = Me.TOP
        '
        'TOP
        '
        Me.TOP.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TOP.BackgroundColor = System.Drawing.Color.White
        Me.TOP.BackgroundImage = CType(resources.GetObject("TOP.BackgroundImage"), System.Drawing.Image)
        Me.TOP.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.TOP.BorderColor = System.Drawing.Color.Transparent
        Me.TOP.BorderRadius = 50
        Me.TOP.BorderThickness = 0
        Me.TOP.Controls.Add(Me.Label1)
        Me.TOP.Location = New System.Drawing.Point(0, -18)
        Me.TOP.Margin = New System.Windows.Forms.Padding(0)
        Me.TOP.Name = "TOP"
        Me.TOP.ShowBorders = True
        Me.TOP.Size = New System.Drawing.Size(800, 63)
        Me.TOP.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.White
        Me.Label1.Font = New System.Drawing.Font("Segoe UI Semibold", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(86, 8)
        Me.Label1.Name = "Label1"
        Me.Label1.Padding = New System.Windows.Forms.Padding(10, 0, 0, 0)
        Me.Label1.Size = New System.Drawing.Size(241, 63)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "SMART IRRIGATION SYSTEM"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'PARENT
        '
        Me.PARENT.BackColor = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(239, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.PARENT.Controls.Add(Me.BunifuPictureBox3)
        Me.PARENT.Controls.Add(Me.Cover)
        Me.PARENT.Controls.Add(Me.BunifuPictureBox2)
        Me.PARENT.Controls.Add(Me.TOP)
        Me.PARENT.Controls.Add(Me.floatingPanel)
        Me.PARENT.Controls.Add(Me.BODY)
        Me.PARENT.Controls.Add(Me.BOTTOM)
        Me.PARENT.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PARENT.Location = New System.Drawing.Point(0, 0)
        Me.PARENT.Name = "PARENT"
        Me.PARENT.Size = New System.Drawing.Size(800, 500)
        Me.PARENT.TabIndex = 5
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
        Me.options_btn.Image = CType(resources.GetObject("options_btn.Image"), System.Drawing.Image)
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
        Me.history_btn.Image = Global.Smart_Irrigation_System_GUI.My.Resources.Resources.hour_glass_48px_gray
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
        'COMLISTENER
        '
        Me.COMLISTENER.Interval = 200
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.White
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(411, 234)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(144, 50)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "40 °C"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Dashboard_Main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(239, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(800, 500)
        Me.Controls.Add(Me.PARENT)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(816, 539)
        Me.MinimumSize = New System.Drawing.Size(816, 539)
        Me.Name = "Dashboard_Main"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Tag = "816, 539"
        Me.BODY.ResumeLayout(False)
        Me.Main.ResumeLayout(False)
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Chart2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Chart1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.BOTTOM.ResumeLayout(False)
        Me.TOP.ResumeLayout(False)
        Me.PARENT.ResumeLayout(False)
        CType(Me.BunifuPictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BunifuPictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.floatingPanel.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents floatingPanel As Bunifu.UI.WinForms.BunifuPanel
    Friend WithEvents TOP As Bunifu.UI.WinForms.BunifuPanel
    Friend WithEvents BODY As Panel
    Friend WithEvents BunifuPictureBox2 As Bunifu.UI.WinForms.BunifuPictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents dashboard_btn As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents options_btn As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents history_btn As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents snackbar1 As Bunifu.UI.WinForms.BunifuSnackbar
    Friend WithEvents Main As Panel
    Friend WithEvents Cover As Label
    Friend WithEvents Guna2DragControl1 As Guna.UI2.WinForms.Guna2DragControl
    Friend WithEvents BOTTOM As Panel
    Friend WithEvents PARENT As Panel
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
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
End Class
