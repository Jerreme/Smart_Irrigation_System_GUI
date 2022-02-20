<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class watering_Dialog
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(watering_Dialog))
        Me.loadingBar = New Bunifu.UI.WinForms.BunifuProgressBar()
        Me.Okay_btn = New Guna.UI2.WinForms.Guna2Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Guna2DragControl1 = New Guna.UI2.WinForms.Guna2DragControl(Me.components)
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.SuspendLayout()
        '
        'loadingBar
        '
        Me.loadingBar.AllowAnimations = False
        Me.loadingBar.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.loadingBar.Animation = 0
        Me.loadingBar.AnimationSpeed = 220
        Me.loadingBar.AnimationStep = 10
        Me.loadingBar.BackColor = System.Drawing.Color.FromArgb(CType(CType(223, Byte), Integer), CType(CType(223, Byte), Integer), CType(CType(223, Byte), Integer))
        Me.loadingBar.BackgroundImage = CType(resources.GetObject("loadingBar.BackgroundImage"), System.Drawing.Image)
        Me.loadingBar.BorderColor = System.Drawing.Color.White
        Me.loadingBar.BorderRadius = 9
        Me.loadingBar.BorderThickness = 1
        Me.loadingBar.Location = New System.Drawing.Point(25, 60)
        Me.loadingBar.Maximum = 100
        Me.loadingBar.MaximumValue = 100
        Me.loadingBar.Minimum = 0
        Me.loadingBar.MinimumValue = 0
        Me.loadingBar.Name = "loadingBar"
        Me.loadingBar.Orientation = System.Windows.Forms.Orientation.Horizontal
        Me.loadingBar.ProgressBackColor = System.Drawing.Color.FromArgb(CType(CType(223, Byte), Integer), CType(CType(223, Byte), Integer), CType(CType(223, Byte), Integer))
        Me.loadingBar.ProgressColorLeft = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(97, Byte), Integer))
        Me.loadingBar.ProgressColorRight = System.Drawing.Color.FromArgb(CType(CType(49, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(150, Byte), Integer))
        Me.loadingBar.Size = New System.Drawing.Size(214, 13)
        Me.loadingBar.TabIndex = 1
        Me.loadingBar.Value = 0
        Me.loadingBar.ValueByTransition = 0
        '
        'Okay_btn
        '
        Me.Okay_btn.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.Okay_btn.Animated = True
        Me.Okay_btn.BackColor = System.Drawing.Color.White
        Me.Okay_btn.BorderRadius = 12
        Me.Okay_btn.CheckedState.Parent = Me.Okay_btn
        Me.Okay_btn.CustomImages.Parent = Me.Okay_btn
        Me.Okay_btn.FillColor = System.Drawing.Color.FromArgb(CType(CType(49, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(150, Byte), Integer))
        Me.Okay_btn.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Okay_btn.ForeColor = System.Drawing.Color.White
        Me.Okay_btn.HoverState.Parent = Me.Okay_btn
        Me.Okay_btn.Location = New System.Drawing.Point(72, 70)
        Me.Okay_btn.Name = "Okay_btn"
        Me.Okay_btn.PressedColor = System.Drawing.Color.White
        Me.Okay_btn.PressedDepth = 10
        Me.Okay_btn.ShadowDecoration.Parent = Me.Okay_btn
        Me.Okay_btn.Size = New System.Drawing.Size(120, 40)
        Me.Okay_btn.TabIndex = 2
        Me.Okay_btn.Text = "Okay"
        Me.Okay_btn.Visible = False
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.Label1.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 26)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(240, 18)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Watering Plant1..."
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Guna2DragControl1
        '
        Me.Guna2DragControl1.TargetControl = Me
        '
        'Timer1
        '
        '
        'Label2
        '
        Me.Label2.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Silver
        Me.Label2.Location = New System.Drawing.Point(12, 113)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(240, 16)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "will automatically close in 5"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.Label2.Visible = False
        '
        'Timer2
        '
        Me.Timer2.Interval = 1000
        '
        'watering_Dialog
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.ClientSize = New System.Drawing.Size(264, 141)
        Me.ControlBox = False
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Okay_btn)
        Me.Controls.Add(Me.loadingBar)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "watering_Dialog"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = " "
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents loadingBar As Bunifu.UI.WinForms.BunifuProgressBar
    Friend WithEvents Okay_btn As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Guna2DragControl1 As Guna.UI2.WinForms.Guna2DragControl
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Label2 As Label
    Friend WithEvents Timer2 As Timer
End Class
