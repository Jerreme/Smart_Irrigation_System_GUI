<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class bootingDevice_Dialog
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
        Me.label = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.BunifuCircleProgress1 = New Bunifu.UI.WinForms.BunifuCircleProgress()
        Me.drag = New Guna.UI2.WinForms.Guna2DragControl(Me.components)
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.SuspendLayout()
        '
        'label
        '
        Me.label.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.label.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label.Location = New System.Drawing.Point(12, 18)
        Me.label.Name = "label"
        Me.label.Size = New System.Drawing.Size(240, 18)
        Me.label.TabIndex = 4
        Me.label.Text = "Arduino Board Is Booting"
        Me.label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label2
        '
        Me.Label2.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Silver
        Me.Label2.Location = New System.Drawing.Point(12, 110)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(240, 16)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "this will close automatically"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'BunifuCircleProgress1
        '
        Me.BunifuCircleProgress1.Animated = True
        Me.BunifuCircleProgress1.AnimationInterval = 8
        Me.BunifuCircleProgress1.AnimationSpeed = 1
        Me.BunifuCircleProgress1.BackColor = System.Drawing.Color.Transparent
        Me.BunifuCircleProgress1.CircleMargin = 8
        Me.BunifuCircleProgress1.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuCircleProgress1.ForeColor = System.Drawing.Color.White
        Me.BunifuCircleProgress1.IsPercentage = False
        Me.BunifuCircleProgress1.LineProgressThickness = 7
        Me.BunifuCircleProgress1.LineThickness = 5
        Me.BunifuCircleProgress1.Location = New System.Drawing.Point(102, 41)
        Me.BunifuCircleProgress1.Name = "BunifuCircleProgress1"
        Me.BunifuCircleProgress1.ProgressAnimationSpeed = 200
        Me.BunifuCircleProgress1.ProgressBackColor = System.Drawing.Color.White
        Me.BunifuCircleProgress1.ProgressColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(97, Byte), Integer))
        Me.BunifuCircleProgress1.ProgressColor2 = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(97, Byte), Integer))
        Me.BunifuCircleProgress1.ProgressEndCap = Bunifu.UI.WinForms.BunifuCircleProgress.CapStyles.Round
        Me.BunifuCircleProgress1.ProgressFillStyle = Bunifu.UI.WinForms.BunifuCircleProgress.FillStyles.Gradient
        Me.BunifuCircleProgress1.ProgressStartCap = Bunifu.UI.WinForms.BunifuCircleProgress.CapStyles.Round
        Me.BunifuCircleProgress1.SecondaryFont = New System.Drawing.Font("Microsoft Sans Serif", 16.0!)
        Me.BunifuCircleProgress1.Size = New System.Drawing.Size(60, 60)
        Me.BunifuCircleProgress1.SubScriptColor = System.Drawing.Color.FromArgb(CType(CType(166, Byte), Integer), CType(CType(166, Byte), Integer), CType(CType(166, Byte), Integer))
        Me.BunifuCircleProgress1.SubScriptMargin = New System.Windows.Forms.Padding(5, -20, 0, 0)
        Me.BunifuCircleProgress1.SubScriptText = ""
        Me.BunifuCircleProgress1.SuperScriptColor = System.Drawing.Color.FromArgb(CType(CType(166, Byte), Integer), CType(CType(166, Byte), Integer), CType(CType(166, Byte), Integer))
        Me.BunifuCircleProgress1.SuperScriptMargin = New System.Windows.Forms.Padding(5, 20, 0, 0)
        Me.BunifuCircleProgress1.SuperScriptText = ""
        Me.BunifuCircleProgress1.TabIndex = 16
        Me.BunifuCircleProgress1.Text = "30"
        Me.BunifuCircleProgress1.TextMargin = New System.Windows.Forms.Padding(0)
        Me.BunifuCircleProgress1.Value = 30
        Me.BunifuCircleProgress1.ValueByTransition = 30
        Me.BunifuCircleProgress1.ValueMargin = New System.Windows.Forms.Padding(0)
        '
        'drag
        '
        Me.drag.TargetControl = Me
        '
        'Timer1
        '
        Me.Timer1.Interval = 500
        '
        'bootingDevice_Dialog
        '
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(264, 141)
        Me.ControlBox = False
        Me.Controls.Add(Me.BunifuCircleProgress1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.label)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Name = "bootingDevice_Dialog"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = " "
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents dragControl As Guna.UI2.WinForms.Guna2DragControl
    Friend WithEvents label As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents BunifuCircleProgress1 As Bunifu.UI.WinForms.BunifuCircleProgress
    Friend WithEvents drag As Guna.UI2.WinForms.Guna2DragControl
    Friend WithEvents Timer1 As Timer
End Class
