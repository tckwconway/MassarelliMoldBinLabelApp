Imports CrystalDecisions.CrystalReports
Imports CrystalDecisions.ReportSource
Imports CrystalDecisions.Shared
Imports CrystalDecisions.Windows
Public Class fBinLabel
    Private dsBinLabel As DataSet
    Private sPrintHandle As String
    Private sPrinterName As String
    Private Enum PrintOrPreview
        Print = 1
        Preview = 2
    End Enum
    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub
    Public Sub New(ds As DataSet, PrintHandle As String, PrinterName As String)

        ' This call is required by the designer.
        InitializeComponent()
        dsBinLabel = ds
        sPrintHandle = PrintHandle
        sPrinterName = PrinterName
        ' Add any initialization after the InitializeComponent() call.

    End Sub

    Private Sub fBinLabel_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Dim rpt As New CrystalDecisions.CrystalReports.Engine.ReportDocument
        
        Dim rptName As String = System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().CodeBase) & "\MoldBinLabel.rpt"
        rptName = New Uri(rptName).LocalPath

        rpt.Load(rptName)

        With rpt
            .SetDataSource(dsBinLabel.Tables("Table1"))
            .PrintOptions.PrinterName = sPrinterName
            .ReadRecords()
        End With

        If sPrintHandle = PrintOrPreview.Print.ToString Then
            rpt.PrintToPrinter(1, False, 0, 0)
            Me.Close()
        Else

            With crvBinLabel
                .ShowExportButton = False
                .ShowGroupTreeButton = False
                .ShowExportButton = False
                .ShowRefreshButton = False
                .ShowZoomButton = True
                .ToolPanelView = Forms.ToolPanelViewType.None
                .ReportSource = rpt

            End With
        End If

    End Sub

    Private Sub fBinLabel_Shown(sender As Object, e As System.EventArgs) Handles Me.Shown
        With Timer1
            .Interval = 250
            .Enabled = True
        End With
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As System.EventArgs) Handles Timer1.Tick
        Timer1.Enabled = False
        crvBinLabel.Zoom(2)
    End Sub
End Class