<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class SplashScreen1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(SplashScreen1))
        Me.barLabel = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.bar = New Bunifu.UI.WinForms.BunifuProgressBar()
        Me.BunifuPictureBox1 = New Bunifu.UI.WinForms.BunifuPictureBox()
        Me.Label2 = New System.Windows.Forms.Label()
        CType(Me.BunifuPictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'barLabel
        '
        Me.barLabel.AutoSize = True
        Me.barLabel.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.barLabel.ForeColor = System.Drawing.Color.White
        Me.barLabel.Location = New System.Drawing.Point(25, 155)
        Me.barLabel.Name = "barLabel"
        Me.barLabel.Size = New System.Drawing.Size(22, 13)
        Me.barLabel.TabIndex = 0
        Me.barLabel.Text = "0%"
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 1
        '
        'bar
        '
        Me.bar.AllowAnimations = False
        Me.bar.Animation = 0
        Me.bar.AnimationSpeed = 220
        Me.bar.AnimationStep = 10
        Me.bar.BackColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(97, Byte), Integer))
        Me.bar.BackgroundImage = CType(resources.GetObject("bar.BackgroundImage"), System.Drawing.Image)
        Me.bar.BorderColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(97, Byte), Integer))
        Me.bar.BorderRadius = 5
        Me.bar.BorderThickness = 1
        Me.bar.Location = New System.Drawing.Point(21, 171)
        Me.bar.Maximum = 100
        Me.bar.MaximumValue = 100
        Me.bar.Minimum = 0
        Me.bar.MinimumValue = 0
        Me.bar.Name = "bar"
        Me.bar.Orientation = System.Windows.Forms.Orientation.Horizontal
        Me.bar.ProgressBackColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(97, Byte), Integer))
        Me.bar.ProgressColorLeft = System.Drawing.Color.White
        Me.bar.ProgressColorRight = System.Drawing.Color.White
        Me.bar.Size = New System.Drawing.Size(290, 10)
        Me.bar.TabIndex = 1
        Me.bar.Value = 0
        Me.bar.ValueByTransition = 0
        '
        'BunifuPictureBox1
        '
        Me.BunifuPictureBox1.AllowFocused = False
        Me.BunifuPictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.BunifuPictureBox1.AutoSizeHeight = True
        Me.BunifuPictureBox1.BorderRadius = 30
        Me.BunifuPictureBox1.Image = Global.Smart_Irrigation_System_GUI.My.Resources.Resources.Logo
        Me.BunifuPictureBox1.IsCircle = True
        Me.BunifuPictureBox1.Location = New System.Drawing.Point(136, 52)
        Me.BunifuPictureBox1.Name = "BunifuPictureBox1"
        Me.BunifuPictureBox1.Size = New System.Drawing.Size(60, 60)
        Me.BunifuPictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.BunifuPictureBox1.TabIndex = 2
        Me.BunifuPictureBox1.TabStop = False
        Me.BunifuPictureBox1.Type = Bunifu.UI.WinForms.BunifuPictureBox.Types.Circle
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(46, 121)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(241, 30)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "PLANTITO APP"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'SplashScreen1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(97, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(332, 202)
        Me.ControlBox = False
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.BunifuPictureBox1)
        Me.Controls.Add(Me.bar)
        Me.Controls.Add(Me.barLabel)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "SplashScreen1"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        CType(Me.BunifuPictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents barLabel As Label
    Friend WithEvents Timer1 As Timer
    Friend WithEvents bar As Bunifu.UI.WinForms.BunifuProgressBar
    Friend WithEvents BunifuPictureBox1 As Bunifu.UI.WinForms.BunifuPictureBox
    Friend WithEvents Label2 As Label
End Class
