Imports System.Environment
Imports System.Data.SqlClient


Module MacolaStartup

    Friend cn As SqlConnection
    Public Sub MacStartup(db As String)

        Dim ConnStr As String = "Data Source=" & My.Settings.DefaultServer & ";Initial Catalog=" & db & ";Persist Security Info=True;User ID=sa;Password=STMARTIN"
        cn = New SqlConnection
        cn.ConnectionString = ConnStr
        cn.Open()

    End Sub

End Module
