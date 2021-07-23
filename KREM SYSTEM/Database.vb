Imports System.IO
Imports System.Data.SqlClient


Public Class Database

    Public Function get_connection() As String
        Dim connection As String
        connection = Nothing


        Try

            Dim openfile As StreamReader
            openfile = File.OpenText("c:\Connection\path1.txt")

            While openfile.Peek <> -1
                connection = openfile.ReadLine
            End While

            openfile.Close()
            'MsgBox("Connection Successful")
            'connection = "Data Source=MAYNARD-PC\SQLEXPRESS;Initial Catalog=KIREM;Integrated Security=True"
            'connection = "Data Source='103.8.25.228';Initial Catalog=KIREM;Integrated Security=False;User Id='kirem';Password='kirem12345';MultipleActiveResultSets=True"

        Catch ex As SqlException
            MsgBox(ex.Message & "error")
        Catch e As Exception
            MsgBox(e.Message)

        End Try


        Return connection

    End Function


End Class
