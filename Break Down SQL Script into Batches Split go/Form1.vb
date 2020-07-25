Public Class Form1

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        Dim f = From sql In System.IO.Directory.GetFiles("c:\sqls\", "*.sql") Order By sql

        For Each s As String In f

            Dim FullSQL As String = System.IO.File.ReadAllText(s)
            FullSQL = FullSQL.Replace(vbCrLf & "go" & vbCrLf, vbCrLf & "|" & vbCrLf)
            FullSQL = FullSQL.Replace(vbCrLf & "Go" & vbCrLf, vbCrLf & "|" & vbCrLf)
            FullSQL = FullSQL.Replace(vbCrLf & "gO" & vbCrLf, vbCrLf & "|" & vbCrLf)
            FullSQL = FullSQL.Replace(vbCrLf & "GO" & vbCrLf, vbCrLf & "|" & vbCrLf)

            Dim batches() As String = FullSQL.Split("|")

            For Each b As String In batches
                MsgBox(b)
            Next

        Next

    End Sub
End Class
