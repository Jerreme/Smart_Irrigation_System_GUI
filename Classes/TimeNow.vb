Public Class TimeNow

    Public Function Get_Seconds() As String '--> ex: 20
        Return Date.Now.ToString("ss")
    End Function

    Public Function Get_Time_Long() As String '--> ex: 1:45:30 PM
        Return Date.Now.ToString("T")
    End Function

    Public Function Get_Time_Short() As String '--> ex: 1:45 PM
        Return Date.Now.ToString("t")
    End Function

    Public Function Get_Day_Short() As String '--> ex: Mon
        Return Date.Now.ToString("ddd")
    End Function
    Public Function Get_Day_Long() As String '--> ex: Monday
        Return Date.Now.ToString("dddd")
    End Function

    Public Function Get_Date_Short(sep As String) As String '--> ex: 05-22-22
        Dim date_now As String =
            Date.Now.ToString("MM") + sep +
            Date.Now.ToString("dd") + sep +
            Date.Now.ToString("yy")
        Return date_now
    End Function

    Public Function Get_Date_Long(sep As String) As String '--> ex: Tue 05-22-22
        Dim date_now As String =
            Date.Now.ToString("ddd").ToUpper + " " + Get_Date_Short("-")
        Return date_now
    End Function


End Class
