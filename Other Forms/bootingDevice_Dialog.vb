
Public Class bootingDevice_Dialog

    Public booted As Boolean = False
    Public failed As Boolean = False
    Private count As Integer = 0

    Private Sub bootingDevice_Dialog_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Start()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If booted Then
            Me.DialogResult = System.Windows.Forms.DialogResult.OK
            Timer1.Stop()
            Me.Close()
        ElseIf failed Then
            label.Text = "Aborting"
            label.ForeColor = Color.Red
            Label2.Text = "Arduino Board is Not Connected"
            failed = False
            count = 18
        ElseIf count >= 24 Then
            Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
            Timer1.Stop()
            Me.Close()
        End If

        count += 1
    End Sub
End Class
