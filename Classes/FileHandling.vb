Imports System.IO

Public Class FileHandling
    Inherits TimeNow

    Dim dataFile As String = Application.StartupPath & "\DAILY LOGS\"
    Dim eventFile As String = Application.StartupPath & "\EVENT LOG.txt"
    Dim reportFile As String = Application.StartupPath & "\REPORT LOG.txt"

    Public Sub New()
        CreateDirectory(Application.StartupPath & "\DAILY LOGS")

        CreateFile(dataFile & Get_Date_Long("-") & ".txt")
        CreateFile(eventFile)
        CreateFile(reportFile)
    End Sub
    Public Function ReadData() As String()
        Dim data_file As String = dataFile & Get_Date_Long("-") & ".txt"
        CreateFile(data_file)
        ReadData = File.ReadAllLines(data_file)
        Return ReadData
    End Function

    Public Function ReadEvent() As String()
        CreateFile(eventFile)
        ReadEvent = File.ReadAllLines(eventFile)
        Return ReadEvent
    End Function

    Public Function ReadReport() As String()
        CreateFile(reportFile)
        ReadReport = File.ReadAllLines(reportFile)
        Return ReadReport
    End Function

    Public Sub WriteTo_DataFile(text As String)
        WriteData(dataFile & Get_Date_Long("-") & ".txt", text, True)
    End Sub

    Public Sub WriteTo_EventFile(text As String)
        WriteData(eventFile, text, True)
    End Sub

    Public Sub WriteTo_ReportFile(text As String)
        WriteData(reportFile, text, True)
    End Sub

    Private Sub WriteData(path As String, text As String, append As Boolean)
        Dim filewritter As System.IO.StreamWriter = My.Computer.FileSystem.OpenTextFileWriter(path, append)
        filewritter.WriteLine(text)
        filewritter.Close()
    End Sub

    Private Sub CreateFile(filename As String)
        If Not System.IO.File.Exists(filename) Then
            System.IO.File.Create(filename).Dispose()
        End If
    End Sub

    Private Sub CreateDirectory(path As String)
        If Not System.IO.Directory.Exists(path) Then
            System.IO.Directory.CreateDirectory(path)
        End If
    End Sub

    Public Function GetDate() As String
        Dim now As String =
            Date.Now.ToString("ddd").ToUpper + " " +
            Date.Now.ToString("MM") + "-" +
            Date.Now.ToString("dd") + "-" +
            Date.Now.ToString("yy")
        Return now
    End Function
End Class
