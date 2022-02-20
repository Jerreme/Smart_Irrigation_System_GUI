Imports System.Threading

Public Class watering_Dialog

    Public done_sginal As Boolean = False
    Public plant As String = "Plant"

    Private waited As Integer = 0
    Private dialog_result As System.Windows.Forms.DialogResult

    Private Sub Okay_btn_Click(sender As Object, e As EventArgs) Handles Okay_btn.Click
        Me.DialogResult = dialog_result
        Me.Close()
    End Sub

    Private Sub watering_Dialog_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Label1.Text = "Watering " & plant & "..."
        Timer1.Start()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        waited += 1
        If waited <= 100 Then
            If Not done_sginal Then
                loadingBar.Value = waited
            Else
                Timer1.Interval = 1
                loadingBar.Value = waited
            End If
        End If


        If loadingBar.Value = 80 And Not done_sginal Then
            Timer1.Interval = 400
        ElseIf loadingBar.Value = 97 And Not done_sginal Then
            Timer1.Interval = 1000
        ElseIf loadingBar.Value = 100 And done_sginal Then
            dialog_result = DialogResult.OK
            Timer1.Stop()
            Timer2.Start()
            Thread.Sleep(200)

            Label1.Text = plant & " Done!"
            loadingBar.Visible = False
            Okay_btn.Visible = True
        ElseIf waited > 100 Then
            dialog_result = DialogResult.Abort
            Timer1.Stop()
            Timer2.Start()
            Thread.Sleep(200)

            Label1.Text = "Something went wrong :("
            Label1.ForeColor = Color.Red
            loadingBar.Visible = False
            Okay_btn.Visible = True
        End If

    End Sub

    Dim remaining_time As Integer = 7
    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        Label2.Text = "will automatically close in " & remaining_time.ToString
        If remaining_time = 5 Then
            Label2.Visible = True
        End If

        If remaining_time = 0 Then
            Timer2.Stop()
            Me.DialogResult = dialog_result
            Me.Close()
        Else
            remaining_time -= 1
        End If
    End Sub
End Class
