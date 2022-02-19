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
        SERIALLISTENER.Start()

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
            'BODY.Controls.Add(currentForm) 'this is not necessary

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

    Const chartMaximum As Integer = 100
    Const chartMinimum As Integer = -10
    Const ChartLimit As Integer = 30
    Private Sub Dashboard_Main_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        For i = 0 To ChartLimit Step 1
            Chart1.Series("Humidity       ").Points.AddY(0)
            If Chart1.Series(0).Points.Count = ChartLimit Then
                Chart1.Series(0).Points.RemoveAt(0)
            End If

            Chart2.Series("Temperature").Points.AddY(0)
            If Chart2.Series(0).Points.Count = ChartLimit Then
                Chart2.Series(0).Points.RemoveAt(0)
            End If
        Next

        Chart1.ChartAreas(0).AxisY.Maximum = chartMaximum
        Chart1.ChartAreas(0).AxisY.Minimum = chartMinimum

        Chart1.ChartAreas("ChartArea1").AxisY.LabelStyle.Enabled = True
        Chart1.ChartAreas("ChartArea1").AxisX.LabelStyle.Enabled = True

        Chart2.ChartAreas(0).AxisY.Maximum = chartMaximum
        Chart2.ChartAreas(0).AxisY.Minimum = chartMinimum

        Chart2.ChartAreas("ChartArea1").AxisY.LabelStyle.Enabled = True
        Chart2.ChartAreas("ChartArea1").AxisX.LabelStyle.Enabled = True

    End Sub

    ' T for Temperature , H for Humidity, S for Sun, B for Battery
    Dim T_DATA, T_Res, H_DATA, H_Res As String
    Dim S_DATA, S_Res, B_DATA, B_Res As String

    Dim Initial As String
    Dim errorOccured As Boolean = False

    Private Sub SERIALLISTENER_Tick(sender As Object, e As EventArgs) Handles SERIALLISTENER.Tick
        If connected Then
            Dim ReceivedData = serial_port.ReadExisting  '--> Read incoming serial data

            Dim TB As New TextBox
            TB.Multiline = True
            TB.Text = ReceivedData   '--> Enter serial data into the textbox

            If TB.Lines.Count > 0 Then
                If Not Failures(TB.Lines(0).ToString) Then '---> If Not Failures Occured
                    Dim temp As String

                    temp = TB.Lines(0)
                    Initial = temp.Substring(0, 1) ' ---> HUMIDITY DATA
                    If Initial = "H" Then
                        H_DATA = temp
                    End If

                    temp = TB.Lines(1)
                    Initial = temp.Substring(0, 1) ' ---> TEMPERATURE DATA
                    If Initial = "T" Then
                        T_DATA = temp
                    End If

                    temp = TB.Lines(2)
                    Initial = temp.Substring(0, 1) ' ---> SUN DATA
                    If Initial = "S" Then
                        S_DATA = temp
                    End If

                    temp = TB.Lines(3)
                    Initial = temp.Substring(0, 1) ' ---> BATTERY DATA
                    If Initial = "B" Then
                        B_DATA = temp
                    End If

                    ' ˅ Get Result ˅
                    H_Res = Mid(H_DATA, 2, H_DATA.Length)
                    T_Res = Mid(T_DATA, 2, T_DATA.Length)
                    S_Res = Mid(S_DATA, 2, S_DATA.Length)
                    B_Res = Mid(B_DATA, 2, B_DATA.Length)

                    ' ˅ Display Results ˅
                    HumidVal.Text = H_Res & " %"
                    TempVal.Text = T_Res & " °C"
                    SunVal.Text = S_Res & " %"
                    BattVal.Text = B_Res & " %"

                    '-----------Enter the temperature and humidity values into the chart-----------------------------------
                    ' ˅ Update Chart1 Maximum Value if needed ˅
                    If H_Res > chartMaximum Then
                        Chart1.ChartAreas(0).AxisY.Maximum = H_Res
                    Else
                        Chart1.ChartAreas(0).AxisY.Maximum = chartMaximum
                    End If

                    ' ˅ Update Chart2 Maximum Value if needed ˅
                    If T_Res > chartMaximum Then
                        Chart2.ChartAreas(0).AxisY.Maximum = T_Res
                    Else
                        Chart2.ChartAreas(0).AxisY.Maximum = chartMaximum
                    End If

                    ' ˅ Add Value to the Chart1 ˅
                    Chart1.Series("Humidity       ").Points.AddY(H_Res)
                    If Chart1.Series(0).Points.Count = ChartLimit Then
                        Chart1.Series(0).Points.RemoveAt(0)
                    End If

                    ' ˅ Add Value to the Chart2 ˅
                    Chart2.Series("Temperature").Points.AddY(T_Res)
                    If Chart2.Series(0).Points.Count = ChartLimit Then
                        Chart2.Series(0).Points.RemoveAt(0)
                    End If
                    '------------------------------------------------------------------------------------------------------

                    '-----------Enter the Sun Value into the Circular Progress---------------------------------------------
                    If Int(S_Res) >= sunLevel.Minimum AndAlso (S_Res) <= sunLevel.Maximum Then
                        sunLevel.Value = Int(S_Res)
                    End If
                    '------------------------------------------------------------------------------------------------------

                    '-----------Enter the Battery Value into the Battery Display-------------------------------------------
                    If Int(B_Res) >= 0 AndAlso Int(B_Res) <= 100 Then
                        Dim batt_height As Integer = (Int(B_Res) / 100) * 60 '--> 60 is the maximum height
                        battLevel.Height = batt_height
                    End If
                    '------------------------------------------------------------------------------------------------------

                End If
                End If
        End If
    End Sub

    Function Failures(firstLine As String) As Boolean
        If firstLine.Equals("Failed to read from DHT sensor!") Then
            If Not errorOccured Then
                errorOccured = True
                snackbar1.Show(
                            Me,
                            "Error Reading From Arduino Board",
                            Bunifu.UI.WinForms.BunifuSnackbar.MessageTypes.Error,
                            2000, "",
                            Bunifu.UI.WinForms.BunifuSnackbar.Positions.TopRight)
            End If
            Return True
        End If

        Return False
    End Function
End Class
