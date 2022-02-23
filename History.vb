Public Class History

    Private fileClass As FileHandling
    Private timeClass As TimeNow
    Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        fileClass = New FileHandling
        timeClass = New TimeNow

        UpdateistoryForm("DATA")
        UpdateistoryForm("EVENTS")
        UpdateistoryForm("REPORTS")

        date_label.Text = timeClass.Get_Date_Short("/")
    End Sub

    Public Sub UpdateistoryForm(Log_Type As String)
        'Dim allLines As String() = fileClass.ReadData()
        Dim textbox As Bunifu.UI.WinForms.BunifuTextBox
        Dim allLines As String()

        If Log_Type.Equals("DATA") Then
            textbox = dataLog
            allLines = fileClass.ReadData()
        ElseIf Log_Type.Equals("EVENTS") Then
            textbox = eventLog
            allLines = fileClass.ReadEvent()
        ElseIf Log_Type.Equals("REPORTS") Then
            textbox = reportLog
            allLines = fileClass.ReadReport()
        Else
            ReDim allLines(0)
            allLines(0) = "An Error Occured while fetching data"
            textbox = dataLog
        End If

        textbox.Text = ""

        If Not allLines.Length = 0 Then

            If allLines.Length <= 100 Then
                For Each line As String In allLines
                    textbox.AppendText(line & vbNewLine)
                Next
            Else
                For i As Integer = allLines.Length - 100 To allLines.Length - 1 Step 1
                    textbox.AppendText(allLines(i).ToString & vbNewLine)
                Next
            End If

            textbox.SelectionStart = dataLog.Text.Length
            textbox.ScrollToCaret()
            textbox.Refresh()
        End If
    End Sub

    Public Sub Update_DataBox(Log_Type As String, data As String)
        Dim textbox As Bunifu.UI.WinForms.BunifuTextBox
        Dim allLines As String()

        If Log_Type.Equals("DATA") Then
            textbox = dataLog
            allLines = fileClass.ReadData()
        ElseIf Log_Type.Equals("EVENTS") Then
            textbox = eventLog
            allLines = fileClass.ReadEvent()
        ElseIf Log_Type.Equals("REPORTS") Then
            textbox = reportLog
            allLines = fileClass.ReadReport()
        Else
            ReDim allLines(0)
            allLines(0) = "An Error Occured while fetching data"
            textbox = reportLog
        End If

        If textbox.Lines.Length >= 100 Then
            Dim t As String = ""

            For i As Integer = allLines.Length - 100 To allLines.Length - 2 Step 1
                t += allLines(i).ToString & vbNewLine
            Next
            textbox.Text = t
        End If

        date_label.Text = timeClass.Get_Date_Short("/")
        textbox.AppendText(data & vbNewLine)
    End Sub

    Private Sub refresh_data_Click(sender As Object, e As EventArgs) Handles refresh_data.Click
        dataLog.SelectionStart = dataLog.Text.Length
        dataLog.ScrollToCaret()
        dataLog.Refresh()
    End Sub

    Private Sub refresh_events_Click(sender As Object, e As EventArgs) Handles refresh_events.Click
        eventLog.SelectionStart = dataLog.Text.Length
        eventLog.ScrollToCaret()
        eventLog.Refresh()
    End Sub

    Private Sub refresh_reports_Click(sender As Object, e As EventArgs) Handles refresh_reports.Click
        reportLog.SelectionStart = dataLog.Text.Length
        reportLog.ScrollToCaret()
        reportLog.Refresh()
    End Sub


    'Public Sub Update_DataBox(data As String)
    '    If dataLog.Lines.Length >= 100 Then
    '        Dim t As String = ""
    '        Dim allLines As String() = fileClass.ReadData()

    '        For i As Integer = allLines.Length - 100 To allLines.Length - 2 Step 1
    '            t += allLines(i).ToString & vbNewLine
    '        Next
    '        dataLog.Text = t
    '    End If

    '    dataLog.AppendText(data & vbNewLine)
    'End Sub

End Class