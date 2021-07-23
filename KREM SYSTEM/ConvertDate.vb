Public Class ConvertDate

    Public Function convert_date(ByVal dt As String)

        Dim datevar As Date
        datevar = Convert.ToDateTime(dt)
        MsgBox("Date: " & datevar.ToString("dd/MM/yyyy"))
        Return datevar.ToString("dd/MM/yyyy")
    End Function


End Class
