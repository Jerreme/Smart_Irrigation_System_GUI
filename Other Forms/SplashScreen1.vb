
Public NotInheritable Class SplashScreen1

    'Private DASHBOARD As Dashboard_Main
    Private Val As Integer = 0

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If Val >= 100 Then
            Timer1.Stop()
        Else
            Me.Invoke(
            Sub()
                Val += 20
                bar.Value = Val
                barLabel.Text = Val.ToString & "%"
                bar.Invalidate()
            End Sub)
        End If


        'If Val = 100 Then
        '    DASHBOARD = New Dashboard_Main
        '    DASHBOARD.Show()

        '    Timer1.Stop()
        '    Me.Dispose()
        'End If
    End Sub
End Class
