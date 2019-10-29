Imports System.Data.SqlClient
Public Class BusObj


    Public Shared Function GetBins(cn As SqlConnection, item_no As String, loc As String)
        Dim dt As DataTable = DAC.ExecuteSP_DataTable(My.Resources.SP_spIMGetBinLabels_MAS, cn, _
                              DAC.Parameter(My.Resources.PARAM_iItemNo, item_no, ParameterDirection.Input), _
                              DAC.Parameter(My.Resources.PARAM_iLoc, loc, ParameterDirection.Input))
        Return dt

    End Function

    Public Shared Sub SaveSettings(cn As SqlConnection, status As String, username As String, applicationname As String,
                                    printername As String)
        DAC.ExecuteSP(My.Resources.SP_spSettings_MAS, cn, _
                      DAC.Parameter(My.Resources.PARAM_iStatus, status, ParameterDirection.Input), _
                      DAC.Parameter(My.Resources.PARAM_iUserName, username, ParameterDirection.Input), _
                      DAC.Parameter(My.Resources.PARAM_iApplicationName, applicationname, ParameterDirection.Input), _
                      DAC.Parameter(My.Resources.PARAM_iPrinterName, printername, ParameterDirection.Input))


    End Sub

    Public Shared Function GetSettingsUser(cn As SqlConnection, ssql As String) As DataTable
        Dim dt As DataTable = DAC.ExecuteSQL_DataSet(ssql, cn, "UserName")

        Return dt
    End Function
End Class
