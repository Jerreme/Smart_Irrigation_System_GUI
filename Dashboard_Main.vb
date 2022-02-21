Imports System.Threading

Public Class Dashboard_Main
    Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        'Me.DoubleBuffered = True '---> Uncomment if Flickerings occurs

        'Start Up
        LOADT_STARTUP_VALUES()

        COMLISTENER.Start()
    End Sub

    '-----------------------------Variables---------------------------------------
    'Initializations
    Private active_btn As Guna.UI2.WinForms.Guna2Button
    Private active_btn_overrides As Guna.UI2.WinForms.Guna2Button
    Private active_btn_controls As Guna.UI2.WinForms.Guna2Button

    'Floating Buttons Colors
    Private ReadOnly foreground_col As Color = Color.FromArgb(64, 64, 64)
    Private ReadOnly active_col As Color = Color.FromArgb(57, 191, 115)
    Private ReadOnly iddle_Col As Color = Color.FromArgb(39, 174, 97)

    'Manual Overrides Colors
    Private ReadOnly active_col2 As Color = active_col
    Private ReadOnly iddle_Col2 As Color = Color.FromArgb(233, 245, 239)

    'Controls Colors
    Private ReadOnly active_col3 As Color = Color.FromArgb(255, 216, 102)
    Private ReadOnly iddle_Col3 As Color = Color.FromArgb(245, 242, 233)

    'Forms
    Private historyForm As History
    Private optionsForm As Options
    Private currentForm As Form
    Private wateringDialog As watering_Dialog

    'Classes
    Private comsClass As Coms

    'Constants
    Private Const chartMaximum As Integer = 100
    Private Const chartMinimum As Integer = -10
    Private Const ChartLimit As Integer = 30

    'Global Variables
    Private connected As Boolean = False
    Private errorOccured As Boolean = True
    Private lights_Active As Boolean = False
    Private pump_Active As Boolean = False
    Private watering_Active As Boolean = False

    ' T for Temperature , H for Humidity, S for Sun, B for Battery, V for Volt
    Private T_DATA, T_Res, H_DATA, H_Res As String
    Private S_DATA, S_Res, B_DATA, B_Res As String
    Private V_DATA, V_Res, Initial As String

    'Snackbar Param Values
    Private ReadOnly Error_Type = Bunifu.UI.WinForms.BunifuSnackbar.MessageTypes.Error
    Private ReadOnly Succes_Type = Bunifu.UI.WinForms.BunifuSnackbar.MessageTypes.Success
    Private ReadOnly Information_Type = Bunifu.UI.WinForms.BunifuSnackbar.MessageTypes.Information
    Private ReadOnly Warning_Type = Bunifu.UI.WinForms.BunifuSnackbar.MessageTypes.Warning

    Private ReadOnly TopRight_pos = Bunifu.UI.WinForms.BunifuSnackbar.Positions.TopRight
    Private ReadOnly TopCenter_pos = Bunifu.UI.WinForms.BunifuSnackbar.Positions.TopCenter
    Private ReadOnly BottomCenter_pos = Bunifu.UI.WinForms.BunifuSnackbar.Positions.BottomCenter

    '-----------------------------End of Variables-----------------------------------

    Sub LOADT_STARTUP_VALUES()
        historyForm = New History
        historyForm.TopLevel = False
        historyForm.Dock = DockStyle.Fill

        optionsForm = New Options
        optionsForm.TopLevel = False
        optionsForm.Dock = DockStyle.Fill

        BODY.Controls.Add(historyForm)
        BODY.Controls.Add(optionsForm)

        historyForm.Hide()
        optionsForm.Hide()

        comsClass = New Coms()
        setActiveBtn(dashboard_btn)

        '------------------Reset to Startup Values-------------------
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
        Chart2.ChartAreas(0).AxisY.Maximum = chartMaximum
        Chart2.ChartAreas(0).AxisY.Minimum = chartMinimum

        HumidVal.Text = "0" & " %"
        TempVal.Text = "0" & " %"

        sunLevel.ValueByTransition = 0
        SunVal.Text = "0" & " %"

        battLevel.ValueByTransition = 0
        BattVal.Text = "0" & " %"
        voltLabel.Text = "-- --"
        '--------------------------End-------------------------------
    End Sub


    '----------------------------Buttons Hover & Clicked Features---------------------------------
    Sub setActiveBtn(sender As Object)
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

    Sub setActiveBtn_plants(sender As Object)
        If connected And Not errorOccured Then
            active_btn_overrides = CType(sender, Guna.UI2.WinForms.Guna2Button)

            If (active_btn_overrides IsNot plant1_btn) Then
                setBtn_To_Inactive(plant1_btn)
                'plant1_btn.Enabled = False
            End If

            If (active_btn_overrides IsNot plant2_btn) Then
                setBtn_To_Inactive(plant2_btn)
                'plant2_btn.Enabled = False
            End If

            active_btn_overrides.ForeColor = Color.White
            active_btn_overrides.HoverState.FillColor = active_col2
            active_btn_overrides.FillColor = active_col2
            'active_btn_overrides.Enabled = True
        End If
    End Sub

    Sub setActiveBtn_controls(sender As Object)
        If connected And Not errorOccured Then
            active_btn_controls = CType(sender, Guna.UI2.WinForms.Guna2Button)

            active_btn_controls.ForeColor = Color.White
            active_btn_controls.HoverState.FillColor = active_col3
            active_btn_controls.FillColor = active_col3
        End If
    End Sub

    Private Sub setBtn_To_Inactive(sender As Object)
        If sender Is plant1_btn Or sender Is plant2_btn Then
            sender.HoverState.FillColor = Color.FromArgb(195, 247, 215)
            sender.FillColor = iddle_Col2
            sender.ForeColor = foreground_col
        ElseIf sender Is lights_btn Or sender Is pump_btn Then
            sender.HoverState.FillColor = Color.FromArgb(247, 234, 195)
            sender.FillColor = iddle_Col3
            sender.ForeColor = foreground_col
        End If
    End Sub
    '---------------------------------------------End---------------------------------------------------


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
            'BODY.Controls.Add(currentForm) '---> this is not necessary

            decor1.Visible = False
            currentForm.Show()
            currentForm.BringToFront()
        ElseIf (otherForm.GetType Is GetType(System.Windows.Forms.Panel)) Then
            If currentForm IsNot Nothing Then
                currentForm.Hide()
                currentForm = Nothing
            End If
            decor1.Visible = True
            Main.Visible = True
        End If

        BODY.ResumeLayout()
    End Sub

    Sub send_Command(sender As Object)
        If connected And Not errorOccured Then
            If (sender Is plant1_btn AndAlso Not watering_Active) Then
                serial_port.Write("P") '--> send command to water plant1
                watering_Active = True

                wateringDialog = New watering_Dialog
                wateringDialog.plant = "Plant 1"
                wateringDialog.ShowDialog()

                watering_Active = False
                active_btn_overrides = Nothing
                setBtn_To_Inactive(plant1_btn)
                setBtn_To_Inactive(plant2_btn)
                'plant2_btn.Enabled = True

                If wateringDialog.DialogResult = DialogResult.OK Then
                    show_snackbar("Plant 1 watered recently", Succes_Type, TopRight_pos)
                Else
                    show_snackbar("Error Occured while watering Plant 1", Error_Type, TopRight_pos)
                End If

            ElseIf (sender Is plant2_btn AndAlso Not watering_Active) Then
                serial_port.Write("p") '--> send command to water plant2
                watering_Active = True

                wateringDialog = New watering_Dialog
                wateringDialog.plant = "Plant 2"
                wateringDialog.ShowDialog()

                watering_Active = False
                active_btn_overrides = Nothing
                setBtn_To_Inactive(plant1_btn)
                setBtn_To_Inactive(plant2_btn)
                'plant1_btn.Enabled = True

                If wateringDialog.DialogResult = DialogResult.OK Then
                    show_snackbar("Plant 2 watered recently", Succes_Type, TopRight_pos)
                Else
                    show_snackbar("Error Occured while watering Plant 2", Error_Type, TopRight_pos)
                End If

            ElseIf (sender Is lights_btn And Not lights_Active) Then
                serial_port.Write("L") '--> send command turn On Lights
                lights_Active = True
            ElseIf (sender Is lights_btn And lights_Active) Then
                serial_port.Write("l") '--> send commandturn Off Lights
                lights_Active = False

            ElseIf (sender Is pump_btn And Not pump_Active) Then
                serial_port.Write("U") '--> send command turn On Pump
                pump_Active = True
            ElseIf (sender Is pump_btn And pump_Active) Then
                serial_port.Write("u") '--> send command turn Off Pump
                pump_Active = False
            End If
        End If
    End Sub


    '-----------------------------------------Events----------------------------------------------
    Private Sub dashboard_btn_Click(sender As Object, e As EventArgs) Handles dashboard_btn.Click
        If (active_btn IsNot CType(sender, Guna.UI2.WinForms.Guna2Button)) Then
            setActiveBtn(sender)
            OpenForm(Main)
        End If
    End Sub

    Private Sub history_btn_Click(sender As Object, e As EventArgs) Handles history_btn.Click
        If (active_btn IsNot CType(sender, Guna.UI2.WinForms.Guna2Button)) Then
            setActiveBtn(sender)
            OpenForm(historyForm)
        End If
    End Sub

    Private Sub options_btn_Click(sender As Object, e As EventArgs) Handles options_btn.Click
        If (active_btn IsNot CType(sender, Guna.UI2.WinForms.Guna2Button)) Then
            setActiveBtn(sender)
            OpenForm(optionsForm)
        End If
    End Sub

    Private Sub plant1_btn_Click(sender As Object, e As EventArgs) Handles plant1_btn.Click
        If (active_btn_overrides IsNot CType(sender, Guna.UI2.WinForms.Guna2Button)) Then
            setActiveBtn_plants(sender)
            send_Command(sender)
        ElseIf active_btn_overrides Is lights_btn Then
            setBtn_To_Inactive(sender)
        End If
    End Sub

    Private Sub plant2_btn_Click(sender As Object, e As EventArgs) Handles plant2_btn.Click
        If (active_btn_overrides IsNot CType(sender, Guna.UI2.WinForms.Guna2Button)) Then
            setActiveBtn_plants(sender)
            send_Command(sender)
        ElseIf active_btn_overrides Is lights_btn Then
            setBtn_To_Inactive(sender)
        End If
    End Sub

    Private Sub lights_btn_Click(sender As Object, e As EventArgs) Handles lights_btn.Click
        If Not lights_Active Then
            setActiveBtn_controls(sender)
            send_Command(sender)
        Else
            setBtn_To_Inactive(sender)
            send_Command(sender)
        End If
    End Sub

    Private Sub pump_btn_Click(sender As Object, e As EventArgs) Handles pump_btn.Click
        If Not pump_Active Then
            setActiveBtn_controls(sender)
            send_Command(sender)
        ElseIf pump_Active Then
            setBtn_To_Inactive(sender)
            send_Command(sender)
        End If
    End Sub


    Private Sub COMLISTENER_Tick(sender As Object, e As EventArgs) Handles COMLISTENER.Tick
        Dim res As Integer = comsClass.comListen(serial_port)

        If (res = 1) Then
            show_snackbar("Connected Succesfully", Information_Type, TopRight_pos)
            connected = True
            comLabel.Text = comsClass.comPort
            comLabel.ForeColor = Color.FromArgb(54, 115, 169) 'Blue

            If Not SERIALLISTENER.Enabled Then
                SERIALLISTENER.Start()
            End If
        ElseIf (res = 0) Then
            show_snackbar("Arduino Board is not connected", Warning_Type, TopRight_pos)
            connected = False
            comLabel.Text = "NOT CONNECTED"
            comLabel.ForeColor = Color.FromArgb(241, 74, 22) 'Red

            If SERIALLISTENER.Enabled Then
                SERIALLISTENER.Stop()
            End If
        End If
    End Sub

    Private Sub SERIALLISTENER_Tick(sender As Object, e As EventArgs) Handles SERIALLISTENER.Tick
        If connected Then
            Try
                Dim ReceivedData = serial_port.ReadExisting  '--> Read incoming serial data

                Dim TB As New TextBox
                TB.Multiline = True
                TB.Text = ReceivedData   '--> Enter serial data into the textbox

                If TB.Lines.Count > 0 Then
                    If Not Failures(TB.Lines(0).ToString) Then '---> If Not Failures Occured

                        If TB.Lines.Count > 2 Then
                            Displays_Gathered_Data(TB)
                        ElseIf TB.Lines(0).Equals("Plant 1 Done :)") Then
                            wateringDialog.done_sginal = True
                        ElseIf TB.Lines(0).Equals("Plant 2 Done :)") Then
                            wateringDialog.done_sginal = True
                        ElseIf TB.Lines(0).Equals("Hi VB") Then
                            serial_port.Write("?") '--> Reply to Arduino
                        End If

                    End If
                End If
            Catch ex As Exception
                show_snackbar(ex.ToString, Error_Type, BottomCenter_pos)
            End Try
        End If
    End Sub

    Function Failures(firstLine As String) As Boolean
        If firstLine.Equals("Device is not yet powered! [Delegate]") Then
            show_snackbar("Device is not yet powered! [ACTION IS NEEDED]", Error_Type, TopCenter_pos)
            errorOccured = True
            comLabel.ForeColor = Color.FromArgb(241, 74, 22) 'Red
            Return True
        Else
            errorOccured = False
            comLabel.ForeColor = Color.FromArgb(54, 115, 169) 'Blue
            Return False
        End If
    End Function

    Sub show_snackbar(
                    text As String,
                    type As Bunifu.UI.WinForms.BunifuSnackbar.MessageTypes,
                    pos As Bunifu.UI.WinForms.BunifuSnackbar.Positions)

        snackbar1.Show(Me, text, type, 2000, "", pos)
    End Sub

    Sub Displays_Gathered_Data(TB As TextBox)
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

        temp = TB.Lines(4)
        Initial = temp.Substring(0, 1) ' ---> VOLTAGE DATA
        If Initial = "V" Then
            V_DATA = temp
        End If

        ' ˅ Get Result ˅
        H_Res = Mid(H_DATA, 2, H_DATA.Length)
        T_Res = Mid(T_DATA, 2, T_DATA.Length)
        S_Res = Mid(S_DATA, 2, S_DATA.Length)
        B_Res = Mid(B_DATA, 2, B_DATA.Length)
        V_Res = Mid(V_DATA, 2, V_DATA.Length)

        ' ˅ Display Results ˅
        HumidVal.Text = H_Res & " %"
        TempVal.Text = T_Res & " °C"
        SunVal.Text = S_Res & " %"
        BattVal.Text = B_Res & " %"
        voltLabel.Text = V_Res & " V"

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

        '-----------Enter the Sun Value into the Circular Progress Bar-----------------------------------------
        If Int(S_Res) >= sunLevel.Minimum AndAlso (S_Res) <= sunLevel.Maximum Then
            sunLevel.ValueByTransition = Int(S_Res)
        End If
        '------------------------------------------------------------------------------------------------------

        '-----------Enter the Battery Value into the Battery Display-------------------------------------------
        If Int(B_Res) >= 0 AndAlso Int(B_Res) <= 100 Then
            'Dim batt_height As Integer = (Int(B_Res) / 100) * 60 '--> 60 is the maximum height '--> Old technique for Displaying Battery Level Indicator Graphic 
            'battLevel.Height = batt_height

            If Int(B_Res) < 100 Then
                battFull.BackgroundColor = Color.FromArgb(237, 235, 235)
                battLevel.BackColor = Color.FromArgb(237, 235, 235)
                battLevel.ProgressColorLeft = Color.FromArgb(138, 58, 225)
                battLevel.ProgressColorRight = Color.FromArgb(138, 58, 225)
            Else
                battFull.BackgroundColor = Color.FromArgb(39, 174, 97)
                battLevel.BackColor = Color.FromArgb(39, 174, 97)
                battLevel.ProgressColorLeft = Color.FromArgb(39, 174, 97)
                battLevel.ProgressColorRight = Color.FromArgb(39, 174, 97)
            End If

            battLevel.ValueByTransition = B_Res
        End If
        '------------------------------------------------------------------------------------------------------

    End Sub
End Class
