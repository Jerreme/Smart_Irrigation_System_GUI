Imports System.Threading

Public NotInheritable Class SplashScreen1
    'TODO: This form can easily be set as the splash screen for the application by going to the "Application" tab
    '  of the Project Designer ("Properties" under the "Project" menu).

    Dim th1 As Thread = New Thread(New ThreadStart(AddressOf animation))
    Sub New()

        ' This call is required by the designer.
        InitializeComponent()
        FormBorderStyle = FormBorderStyle.None
        Me.CheckForIllegalCrossThreadCalls = False
        ' Add any initialization after the InitializeComponent() call.

        Me.DoubleBuffered = True
        th1.Start()
    End Sub

    Private Sub animation()
        Label1.Text = "Starting | 25%"
        Thread.Sleep(200)
        Label1.Text = "Initialyzing | 50%"
        Thread.Sleep(200)
        Label1.Text = "Processing | 75%"
        Thread.Sleep(200)
        Label1.Text = "Launching... | 100%"
        Refresh()
    End Sub
End Class
