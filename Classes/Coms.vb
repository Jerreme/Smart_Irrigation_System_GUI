Imports System.Threading
Public Class Coms
    Friend WithEvents my_serial_port As System.IO.Ports.SerialPort

    Public comPort As String = ""
    Private prevComPort As String = ""
    Private connected As Boolean = True

    Sub connectComPort(comName As String)
        If (comName <> "") Then
            my_serial_port.PortName = comName

            Try
                If (Not my_serial_port.IsOpen) Then
                    my_serial_port.Open()
                    'my_serial_port.Write("t")
                End If
            Catch ex As Exception
                Console.WriteLine("Err @Coms:connectComPort = ")
            End Try

        End If
    End Sub
    Function checkComPort() As Boolean
        Dim detected As String = ""

        For Each names As String In My.Computer.Ports.SerialPortNames
            If (Not names.Equals("")) Then
                detected = names
            End If
        Next

        If (Not detected.Equals("")) Then
            If (Not detected.Equals(comPort)) Then
                comPort = detected
                'if comport has changed connect again
                connectComPort(detected)
            End If
            Return True
        Else
            Return False
        End If
    End Function

    Public Function comListen(serialport As IO.Ports.SerialPort) As Integer
        If (serialport IsNot my_serial_port) Then
            my_serial_port = serialport
        End If

        If (checkComPort()) Then
            If (Not connected Or Not comPort.Equals(prevComPort)) Then
                my_serial_port.Write("?")
                prevComPort = comPort
                connected = True
                Return 1
            Else
                Return 2
            End If
        Else
            If (connected) Then
                connected = False
                comPort = ""
                Return 0
            Else
                Return 3
            End If
        End If
    End Function
End Class

