Imports System.Threading

Public Class Dashboard_Main
    Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Me.DoubleBuffered = True
        Me.MaximizedBounds = Screen.PrimaryScreen.WorkingArea

        'Assignment
        thread1 = New Thread(New ThreadStart(AddressOf loadAllChilForms))
        thread1.Start()
        comsClass = New Coms()
        COMLISTENER.Start()

        setActiveBtnn(dashboard_btn)
    End Sub

    'Initializations
    Dim active_btn As Guna.UI2.WinForms.Guna2Button
    Dim thread1

    'Floating Buttons
    Public active_col As Color = Color.FromArgb(57, 191, 115)
    Dim iddle_Col As Color = Color.FromArgb(39, 174, 97)

    'Forms
    Dim historyForm As History
    Dim optionsForm As Options
    Dim currentForm As Form

    'Classes
    Dim comsClass As Coms

    'Global Variables
    Dim connected As Boolean = False

    Sub setActiveBtnn(sender As Object)
        active_btn = CType(sender, Guna.UI2.WinForms.Guna2Button)

        If (active_btn IsNot dashboard_btn) Then
            dashboard_btn.FillColor = iddle_Col
            dashboard_btn.Image = My.Resources.ResourceManager.GetObject("bar_chart_48px_gray")
        Else
            active_btn.Image = My.Resources.ResourceManager.GetObject("bar_chart_48px")
        End If
        If (active_btn IsNot history_btn) Then
            history_btn.FillColor = iddle_Col
            history_btn.Image = My.Resources.ResourceManager.GetObject("hour_glass_48px_gray")
        Else
            active_btn.Image = My.Resources.ResourceManager.GetObject("hour_glass_48px")
        End If
        If (active_btn IsNot options_btn) Then
            options_btn.FillColor = iddle_Col
            options_btn.Image = My.Resources.ResourceManager.GetObject("settings_48px_gray")
        Else
            active_btn.Image = My.Resources.ResourceManager.GetObject("settings_48px")
        End If

        active_btn.FillColor = active_col
    End Sub

    Sub loadAllChilForms()
        historyForm = New History
        historyForm.TopLevel = False
        historyForm.Dock = DockStyle.Fill

        optionsForm = New Options
        optionsForm.TopLevel = False
        optionsForm.Dock = DockStyle.Fill

        BODY.Invoke(
            Sub()
                BODY.Controls.Add(historyForm)
                BODY.Controls.Add(optionsForm)

                historyForm.Hide()
                optionsForm.Hide()
            End Sub)

    End Sub

    Private Sub OpenForm(otherForm As Object)
        BODY.SuspendLayout()

        If (otherForm Is historyForm Or otherForm Is optionsForm) Then
            If currentForm IsNot Nothing Then
                currentForm.Hide()
            End If
            If Main.Visible Then
                Main.Visible = False
            End If
            currentForm = CType(otherForm, Form)
            'BODY.Controls.Add(currentForm)

            currentForm.Show()
            currentForm.BringToFront()
        ElseIf (otherForm.GetType Is GetType(System.Windows.Forms.Panel)) Then
            If currentForm IsNot Nothing Then
                currentForm.Hide()
                currentForm = Nothing
            End If
            Main.Visible = True
        End If

        BODY.ResumeLayout()
    End Sub
    Private Sub dashboard_btn_Click(sender As Object, e As EventArgs) Handles dashboard_btn.Click
        If (active_btn IsNot CType(sender, Guna.UI2.WinForms.Guna2Button)) Then
            setActiveBtnn(sender)
            OpenForm(Main)
        End If
    End Sub

    Private Sub history_btn_Click(sender As Object, e As EventArgs) Handles history_btn.Click
        If (active_btn IsNot CType(sender, Guna.UI2.WinForms.Guna2Button)) Then
            setActiveBtnn(sender)
            OpenForm(historyForm)
        End If
    End Sub

    Private Sub options_btn_Click(sender As Object, e As EventArgs) Handles options_btn.Click
        If (active_btn IsNot CType(sender, Guna.UI2.WinForms.Guna2Button)) Then
            setActiveBtnn(sender)
            OpenForm(optionsForm)
        End If
    End Sub

    Private Sub COMLISTENER_Tick(sender As Object, e As EventArgs) Handles COMLISTENER.Tick
        Dim res As Integer = comsClass.comListen(serial_port)

        If (res = 1) Then
            snackbar1.Show(
                    Me,
                    "Connected Succesfully",
                    Bunifu.UI.WinForms.BunifuSnackbar.MessageTypes.Information,
                    2000, "",
                    Bunifu.UI.WinForms.BunifuSnackbar.Positions.TopRight)

            connected = True
            comLabel.Text = comsClass.comPort
            comLabel.ForeColor = Color.FromArgb(54, 115, 169) 'Blue
        ElseIf (res = 0) Then
            snackbar1.Show(
                    Me,
                    "Arduino Board has been Disconnected",
                    Bunifu.UI.WinForms.BunifuSnackbar.MessageTypes.Warning,
                    2000, "",
                    Bunifu.UI.WinForms.BunifuSnackbar.Positions.TopRight)

            connected = False
            comLabel.Text = "NOT CONNECTED"
            comLabel.ForeColor = Color.FromArgb(241, 74, 22) 'Red
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)
        If connected Then
            serial_port.Write("A")
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs)
        If connected Then
            serial_port.Write("a")
        End If
    End Sub

End Class
