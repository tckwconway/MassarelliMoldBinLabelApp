Imports System.Text.RegularExpressions

Module Utilities

    Public Sub UnselectDataGridViewRows(ByVal dgv As DataGridView)
        For Each rw As DataGridViewRow In dgv.Rows
            rw.Selected = False
        Next
    End Sub

    Public Function ReplaceLineBreak(txt As String, replacewith As String) As String
        Dim formattedText As String = Regex.Replace(txt, "\r\n", replacewith, RegexOptions.Multiline)
        Return formattedText
    End Function

    Public Function ReplaceSpaces(txt As String, replacewith As String) As String
        Dim formattedText As String = ""
        Dim regWhitespace As New Regex("\s")

        Dim regSpace As New Regex(" ")

        formattedText = regWhitespace.Replace(txt, String.Empty)
        formattedText = regSpace.Replace(formattedText, String.Empty)
        Return formattedText
    End Function

    Declare Function GetUserName Lib "advapi32.dll" Alias _
     "GetUserNameA" (ByVal lpBuffer As String, _
     ByRef nSize As Integer) As Integer

    Public Function GetUserName() As String
        Dim iReturn As Integer
        Dim userName As String
        userName = New String(CChar(" "), 50)
        iReturn = GetUserName(userName, 50)
        GetUserName = userName.Substring(0, userName.IndexOf(Chr(0)))
    End Function

    Public Sub SaveSettings(username As String, applicationname As String, printername As String, _
                            createdt As Integer, lastdt As Integer)



    End Sub
    Public Sub SaveSettings(username As String, applicationname As String, printername As String, _
                            lastdt As Integer)



    End Sub

End Module
