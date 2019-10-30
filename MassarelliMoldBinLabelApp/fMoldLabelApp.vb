Imports CrystalDecisions.CrystalReports
Imports CrystalDecisions.ReportSource
Imports CrystalDecisions.Shared
Imports CrystalDecisions.Windows
Imports System.Data.SqlClient
Imports System.Drawing.Printing

Public Class fMoldLabelApp
    Private cOptionalCriteria As New OptionalCriteria
    Private LabelPrinter As String
    Private bIsLoading As Boolean = True
    Private bLeaveTextBoxOrderNo As Boolean
    Public dtPrint As New DataTable
    Public dsPrint As New DataSet
    Private PrintHandle As String
    Private rptName As String
    Private userName As String
    Private myPrinter As String

    Const loc As String = "002"

#Region "   Enums   "

    Private Enum PrintOrPreview
        Print = 1
        Preview = 2
    End Enum

    Private Enum SettingStatus
        INSERT = 0
        UPDATE = 1
        DELETE = 2
    End Enum
#End Region

#Region "   Load Form   "

    Private Sub fMoldLabelApp_Load(sender As Object, e As System.EventArgs) Handles Me.Load
        
        cOptionalCriteria.DBName = My.Settings.DefaultDB
        MacStartup(cOptionalCriteria.DBName)

        'Load the list of SQL Databases
        Try
            ListSQLDatabases()
        Catch ex As Exception
            MsgBox("ListSQLDatabases " & ex.Message)
        End Try

        cbDBList.Text = My.Settings.DefaultDB

        lblCurrentDB.Text = "Database: " & My.Settings.DefaultDB
        ' lblPrinterSaved.Visible = False

        rptName = System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().CodeBase) & "\MoldBinLabel.rpt"
        rptName = New Uri(rptName).LocalPath

        lblReportLocation.Text = "Report Path: " & rptName

        Timer1.Interval = 50
        Timer1.Enabled = True
    End Sub

#End Region

#Region "   Methods   "

    Private Sub LoadDataGridView(dt As DataTable)
        Dim dgv As DataGridView = CType(DataGridView2, DataGridView)
        Dim colCounter As Integer = 0
        Dim rowCounter As Integer = 3
        Dim cols() As String = {"item_no", "item_desc_1"}
        Dim dv As DataView = dt.DefaultView
        Dim dtDistinct As DataTable = dv.ToTable(True, cols)
        Dim r As Integer = 0
        With dgv
            .Rows.Insert(0)
            r = 0 'dgv.Rows.Count - 1
            For Each rw As DataRow In dtDistinct.Rows
                .Rows(r).Cells("item_no").Value = rw("item_no").ToString.Trim
                .Rows(r).Cells("item_desc_1").Value = rw("item_desc_1").ToString.Trim
                colCounter = 3
                For Each row In dt.Select("item_no = '" & rw("item_no") & "'")
                    .Rows(r).Cells(colCounter).Value = row("bin_no").ToString.Trim
                    colCounter += 1
                Next
            Next

            For Each cl As DataGridViewColumn In dgv.Columns
                Dim cel As DataGridViewCell = .Rows(r).Cells(cl.Index)
                If cel.Value = "" Then
                    cel.Style.BackColor = SystemColors.AppWorkspace
                End If
            Next

        End With
        Utilities.UnselectDataGridViewRows(dgv)

    End Sub

#End Region

#Region "   Create DataGridView   "

    Private Sub CreateBinListDataGridView(dgv As DataGridView)
        With dgv
            .AllowUserToAddRows = False
            .AllowUserToResizeRows = False
            .ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single
            With .ColumnHeadersDefaultCellStyle
                .Font = New Font("Segoe UI", 11, FontStyle.Bold)
                .Alignment = DataGridViewContentAlignment.MiddleCenter
            End With
            .DataSource = Nothing
            .DefaultCellStyle.Font = New Font("Segoe UI", 10)
            .EditMode = DataGridViewEditMode.EditOnKeystroke

            .EnableHeadersVisualStyles = False
            .RowHeadersVisible = True
            .RowHeadersWidth = 22
            .SelectionMode = DataGridViewSelectionMode.FullRowSelect
            .ScrollBars = ScrollBars.Both
            With .DefaultCellStyle
                .Font = New Font("Segoe UI", 10, FontStyle.Regular)
            End With
            If .RowCount > 0 Then .Rows.Clear()
            If .ColumnCount > 0 Then .Columns.Clear()

            With .Columns(.Columns.Add("item_no", "ItemNo"))
                .ToolTipText = "Item Number"
                .Width = 90
                .MinimumWidth = 50
                .HeaderCell.ToolTipText = .ToolTipText
                With .DefaultCellStyle
                    .Alignment = DataGridViewContentAlignment.MiddleLeft
                    .WrapMode = DataGridViewTriState.False
                End With
            End With

            With .Columns(.Columns.Add("item_desc_1", "ItemDescription"))
                .ToolTipText = "Item Description"
                .Width = 350
                .MinimumWidth = 70
                .HeaderCell.ToolTipText = .ToolTipText
                With .DefaultCellStyle
                    .Alignment = DataGridViewContentAlignment.MiddleLeft
                    .WrapMode = DataGridViewTriState.True
                End With
            End With

            With .Columns(.Columns.Add("loc", "Location"))
                .ToolTipText = "Location"
                .Width = 50
                .MinimumWidth = 30
                .HeaderCell.ToolTipText = .ToolTipText
                With .DefaultCellStyle
                    .Alignment = DataGridViewContentAlignment.MiddleCenter
                    .WrapMode = DataGridViewTriState.False
                End With
                .Visible = False
            End With

            With .Columns(.Columns.Add("bin_no_1", "Bin"))
                .ToolTipText = "Bin No"
                .Width = 70
                .MinimumWidth = 50
                .HeaderCell.ToolTipText = .ToolTipText
                With .DefaultCellStyle
                    .Alignment = DataGridViewContentAlignment.MiddleCenter
                    .WrapMode = DataGridViewTriState.False
                End With
            End With


            With .Columns(.Columns.Add("bin_no_2", "Bin"))
                .ToolTipText = "Bin No"
                .Width = 70
                .MinimumWidth = 50
                .HeaderCell.ToolTipText = .ToolTipText
                With .DefaultCellStyle
                    .Alignment = DataGridViewContentAlignment.MiddleCenter
                    .WrapMode = DataGridViewTriState.False
                End With
            End With


            With .Columns(.Columns.Add("bin_no_3", "Bin"))
                .ToolTipText = "Bin No"
                .Width = 70
                .MinimumWidth = 50
                .HeaderCell.ToolTipText = .ToolTipText
                With .DefaultCellStyle
                    .Alignment = DataGridViewContentAlignment.MiddleCenter
                    .WrapMode = DataGridViewTriState.False
                End With
            End With


            With .Columns(.Columns.Add("bin_no_4", "Bin"))
                .ToolTipText = "Bin No"
                .Width = 70
                .MinimumWidth = 50
                .HeaderCell.ToolTipText = .ToolTipText
                With .DefaultCellStyle
                    .Alignment = DataGridViewContentAlignment.MiddleCenter
                    .WrapMode = DataGridViewTriState.False
                End With
            End With


            With .Columns(.Columns.Add("bin_no_5", "Bin"))
                .ToolTipText = "Bin No"
                .Width = 70
                .MinimumWidth = 50
                .HeaderCell.ToolTipText = .ToolTipText
                With .DefaultCellStyle
                    .Alignment = DataGridViewContentAlignment.MiddleCenter
                    .WrapMode = DataGridViewTriState.False
                End With
            End With


            With .Columns(.Columns.Add("bin_no_6", "Bin"))
                .ToolTipText = "Bin No"
                .Width = 70
                .MinimumWidth = 50
                .HeaderCell.ToolTipText = .ToolTipText
                With .DefaultCellStyle
                    .Alignment = DataGridViewContentAlignment.MiddleCenter
                    .WrapMode = DataGridViewTriState.False
                End With
            End With


            With .Columns(.Columns.Add("bin_no_7", "Bin"))
                .ToolTipText = "Bin No"
                .Width = 70
                .MinimumWidth = 50
                .HeaderCell.ToolTipText = .ToolTipText
                With .DefaultCellStyle
                    .Alignment = DataGridViewContentAlignment.MiddleCenter
                    .WrapMode = DataGridViewTriState.False
                End With
            End With


            With .Columns(.Columns.Add("bin_no_8", "Bin"))
                .ToolTipText = "Bin No"
                .Width = 70
                .MinimumWidth = 50
                .HeaderCell.ToolTipText = .ToolTipText
                With .DefaultCellStyle
                    .Alignment = DataGridViewContentAlignment.MiddleCenter
                    .WrapMode = DataGridViewTriState.False
                End With
            End With


            With .Columns(.Columns.Add("bin_no_9", "Bin"))
                .ToolTipText = "Bin No"
                .Width = 70
                .MinimumWidth = 50
                .HeaderCell.ToolTipText = .ToolTipText
                With .DefaultCellStyle
                    .Alignment = DataGridViewContentAlignment.MiddleCenter
                    .WrapMode = DataGridViewTriState.False
                End With
            End With


            With .Columns(.Columns.Add("bin_no_10", "Bin"))
                .ToolTipText = "Bin No"
                .Width = 70
                .MinimumWidth = 50
                .HeaderCell.ToolTipText = .ToolTipText
                With .DefaultCellStyle
                    .Alignment = DataGridViewContentAlignment.MiddleCenter
                    .WrapMode = DataGridViewTriState.False
                End With
            End With


            With .Columns(.Columns.Add("bin_no_11", "Bin"))
                .ToolTipText = "Bin No"
                .Width = 70
                .MinimumWidth = 50
                .HeaderCell.ToolTipText = .ToolTipText
                With .DefaultCellStyle
                    .Alignment = DataGridViewContentAlignment.MiddleCenter
                    .WrapMode = DataGridViewTriState.False
                End With
            End With


            With .Columns(.Columns.Add("bin_no_12", "Bin"))
                .ToolTipText = "Bin No"
                .Width = 70
                .MinimumWidth = 50
                .HeaderCell.ToolTipText = .ToolTipText
                With .DefaultCellStyle
                    .Alignment = DataGridViewContentAlignment.MiddleCenter
                    .WrapMode = DataGridViewTriState.False
                End With
            End With


            With .Columns(.Columns.Add("bin_no_13", "Bin"))
                .ToolTipText = "Bin No"
                .Width = 70
                .MinimumWidth = 50
                .HeaderCell.ToolTipText = .ToolTipText
                With .DefaultCellStyle
                    .Alignment = DataGridViewContentAlignment.MiddleCenter
                    .WrapMode = DataGridViewTriState.False
                End With
            End With


            With .Columns(.Columns.Add("bin_no_14", "Bin"))
                .ToolTipText = "Bin No"
                .Width = 70
                .MinimumWidth = 50
                .HeaderCell.ToolTipText = .ToolTipText
                With .DefaultCellStyle
                    .Alignment = DataGridViewContentAlignment.MiddleCenter
                    .WrapMode = DataGridViewTriState.False
                End With
            End With


            With .Columns(.Columns.Add("bin_no_15", "Bin"))
                .ToolTipText = "Bin No"
                .Width = 70
                .MinimumWidth = 50
                .HeaderCell.ToolTipText = .ToolTipText
                With .DefaultCellStyle
                    .Alignment = DataGridViewContentAlignment.MiddleCenter
                    .WrapMode = DataGridViewTriState.False
                End With
            End With

        End With
    End Sub

#End Region

#Region "   Load Print Job   "

    Private Function GetPrintTable() As DataTable
        Dim dt As New DataTable
        With dt
            .Columns.Add("item_no", GetType(System.String))
            .Columns.Add("item_desc_1", GetType(System.String))
            .Columns.Add("bin_no", GetType(System.String))
        End With
        Return dt
    End Function

    Private Sub LoadPrintData()
        Dim dgv As DataGridView = CType(DataGridView2, DataGridView)
        dtPrint = GetPrintTable()
        For Each rw As DataGridViewRow In dgv.Rows
            Dim item_no As String = rw.Cells("item_no").Value.ToString.Trim
            Dim item_desc_1 As String = rw.Cells("item_desc_1").Value.ToString.Trim
            For i As Integer = 3 To 12
                If Not (rw.Cells(i).Value) Is Nothing Then
                    Dim bin_no As String = rw.Cells(i).Value.ToString.Trim
                    Dim r() As String = {item_no, item_desc_1, bin_no}
                    dtPrint.Rows.Add(r)
                Else
                    Exit For
                End If
            Next
        Next

        dsPrint.Tables.Add(dtPrint)
    End Sub

    Private Sub PrintLabels()

        Dim crv As New fBinLabel(dsPrint, PrintHandle, lblCurrentPrinter.Text.ToString.Trim)
        crv.Show()

    End Sub

#End Region

#Region "   Load Printer List   "

    Private Sub LoadPrinters()

        '' Find all printers installed
        'For Each Printer In PrinterSettings.InstalledPrinters
        '    cboPrinters.Items.Add(Printer.ToString)
        'Next Printer

        For Each printer In PrinterSettings.InstalledPrinters
            ddPrinterList.DropDownItems.Add(printer.ToString)
        Next

        ' Set the combo to the first printer in the list
        'cboPrinters.SelectedItem = My.Settings.Printer.ToString
        ddPrinterList.Text = ddPrinterList.Text
        userName = Utilities.GetUserName
        Dim dt As DataTable = BusObj.GetSettingsUser(cn, "Select printer_name from SETTINGS_MAS where usr_name = '" & userName & "'")
        Dim myPrinter As String = ""
        If dt Is Nothing OrElse dt.Rows.Count = 0 Then
            myPrinter = ""
        Else
            myPrinter = dt.Rows(0)(0).ToString.Trim
        End If
        lblCurrentPrinter.Text = myPrinter
    End Sub

#End Region

#Region "   Load SQL Database List   "

    Private Sub ListSQLDatabases()
        On Error Resume Next

        Dim cmd As New SqlCommand("", cn)
        Dim rdr As SqlDataReader
        cmd.CommandText = "exec sys.sp_databases"

        rdr = cmd.ExecuteReader()
        With cbDBList
            While (rdr.Read())
                If rdr.GetString(0).Substring(0, 4) = "DATA" Then .Items.Add(rdr.GetString(0))
            End While
        End With
        rdr.Dispose()
        cmd.Dispose()

    End Sub

#End Region

#Region "   Printer Status"

    Private Enum PrinterStatus
        PrinterIdle = 3
        PrinterPrinting = 4
        PrinterWarmingUp = 5
    End Enum

    Private Function PrinterStatusToString( _
    ByVal ps As PrinterStatus _
    ) As String
        Dim s As String
        Select Case ps
            Case PrinterStatus.PrinterIdle
                Return "idle"
            Case PrinterStatus.PrinterPrinting
                Return "printing"
            Case PrinterStatus.PrinterWarmingUp
                Return "warmup"
            Case Else
                Return "unknown"
        End Select
        Return s
    End Function

    Private Function CheckPrinter() As Boolean
        Dim bPrintStatus As Boolean = False
        Dim strPrintServer As String
        strPrintServer = "localhost"
        Dim WMIObject As String
        Dim PrinterSet As Object
        Dim Printer As Object

        WMIObject = "winmgmts://" & strPrintServer
        PrinterSet = GetObject(WMIObject).InstancesOf("win32_Printer")
        For Each Printer In PrinterSet
            'MsgBox( _
            'Printer.Name & ": " & _
            'PrinterStatusToString(Printer.PrinterStatus) _
            ')
            If Printer.Name = LabelPrinter Then
                If PrinterStatusToString(Printer.PrinterStatus) = "printing" Then
                    bPrintStatus = True
                Else
                    bPrintStatus = False
                End If
            End If

        Next
        Return bPrintStatus

    End Function

#End Region

#Region "   TextBox Events "

    Private Sub tbMold_Enter(sender As Object, e As System.EventArgs) Handles tbMold.Enter
        tbMold.BackColor = Color.FromArgb(255, 255, 128)
    End Sub

    Private Sub tbMold_Leave(sender As Object, e As System.EventArgs) Handles tbMold.Leave
        tbMold.BackColor = SystemColors.Window
        bLeaveTextBoxOrderNo = True
    End Sub

    Private Sub tbMold_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles tbMold.KeyDown
        If e.KeyCode = Keys.Enter Then
            Dim tb As RichTextBox = CType(sender, RichTextBox)
            With tb
                .Text = Utilities.ReplaceLineBreak(tb.Text, "")
                .Text = Utilities.ReplaceSpaces(.Text, "")
            End With

            With cOptionalCriteria
                .MoldItemNo = tb.Text.ToString.Trim
                .Location = loc

                Dim dt As DataTable = BusObj.GetBins(cn, .MoldItemNo, .Location)
                If dt.Rows.Count = 0 Then
                    MsgBox("There is no Bin at Warehouse 002 for Item " & .MoldItemNo & "." & vbCrLf & vbCrLf &
                           .MoldItemNo & " may be stored at Factory, 001.", MsgBoxStyle.OkOnly, "No Bin at 002 Warehouse")
                    tbMold.Clear()
                    tbMold.Text = ""
                    Exit Sub
                End If
                LoadDataGridView(dt)
                tbMold.Clear()
                tbMold.Text = ""

            End With
        End If

    End Sub

    Private Sub tbMold_KeyUp(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles tbMold.KeyUp
        If e.KeyCode = Keys.Enter Then
            tbMold.Text = ""
            tbMold.Clear()
        End If
    End Sub

#End Region

#Region "   DataGridView Events  "

    Private Sub DataGridView2_GotFocus(sender As Object, e As System.EventArgs) Handles DataGridView2.GotFocus
        Dim dgv As DataGridView = CType(sender, DataGridView)
        dgv.BackgroundColor = SystemColors.InactiveCaption
    End Sub

    Private Sub DataGridView2_LostFocus(sender As Object, e As System.EventArgs) Handles DataGridView2.LostFocus
        Dim dgv As DataGridView = CType(sender, DataGridView)
        dgv.BackgroundColor = SystemColors.AppWorkspace
    End Sub

    Private Sub DataGridView2_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles DataGridView2.KeyDown

        If e.KeyCode = Keys.Delete Then
            With Timer2
                .Interval = 250
                .Enabled = True
            End With
            tbMold.Focus()
        End If

    End Sub

#End Region

#Region "   Control Events   "

    Private Sub ddPrinterList_DropDownClosed(sender As Object, e As System.EventArgs) Handles ddPrinterList.DropDownClosed
        Dim dd As ToolStripDropDownButton = CType(sender, ToolStripDropDownButton)

        With My.Settings

            '.Printer = """"
            '.Save()
            'lblCurrentPrinter.Text = My.Settings.Printer.ToString.Trim
            'lblPrinterSaved.Visible = True
            'With Timer4
            '    .Interval = 1000
            '    .Enabled = True
            'End With
            'MsgBox("DefaPrinter Saved ")
        End With
        tbMold.Focus()
    End Sub

    Private Sub ddPrinterList_DropDownItemClicked(sender As Object, e As System.Windows.Forms.ToolStripItemClickedEventArgs) Handles ddPrinterList.DropDownItemClicked
        With My.Settings
            myPrinter = e.ClickedItem.Text
            SaveSettings()
            lblCurrentPrinter.Text = e.ClickedItem.Text.Trim
            lblSaved.Visible = True
            With Timer4
                .Interval = 1000
                .Enabled = True
            End With
        End With
    End Sub
    Private Sub SaveSettings()
        userName = Utilities.GetUserName
        Dim ssql As String = "Select usr_name from SETTINGS_MAS where usr_name = '" & userName & "'"
        Dim dt As DataTable = BusObj.GetSettingsUser(cn, ssql)

        Dim status As String = ""
        If dt Is Nothing OrElse dt.Rows.Count = 0 Then
            status = SettingStatus.INSERT.ToString
        Else
            status = SettingStatus.UPDATE.ToString
        End If



        Dim appName As String = Application.ProductName
        BusObj.SaveSettings(cn, status, userName, appName, myPrinter)
    End Sub
#End Region

#Region "   Button Events   "

    Private Sub btnPrint_Click(sender As System.Object, e As System.EventArgs) Handles btnPrint.Click, btnPreview.Click
        Dim dgv As DataGridView = CType(DataGridView2, DataGridView)
        If dgv.Rows.Count = 0 Then
            tbMold.Focus()
            Exit Sub
        End If

        Dim btn As Button = CType(sender, Button)
        'If cboPrinters.Text = "" Then
        '    MsgBox("Select a Printer from the Drop Down box to proceed.", MsgBoxStyle.OkOnly, "Printer Not Selected")
        '    Exit Sub
        'End If
        If btn.Name = btnPreview.Name Then
            PrintHandle = PrintOrPreview.Preview.ToString.Trim
        Else
            PrintHandle = PrintOrPreview.Print.ToString.Trim
        End If

        LoadPrintData()
        PrintLabels()

    End Sub

    Private Sub btnDelete_Click(sender As System.Object, e As System.EventArgs) Handles btnDelete.Click
        Dim dgv As DataGridView = CType(DataGridView2, DataGridView)
        With dgv
            For i = .SelectedRows.Count - 1 To 0 Step -1
                .Rows.Remove(.SelectedRows(i))
            Next
        End With
        Utilities.UnselectDataGridViewRows(dgv)
    End Sub

    Private Sub btnClear_Click(sender As System.Object, e As System.EventArgs) Handles btnClear.Click
        Dim dgv As DataGridView = CType(DataGridView2, DataGridView)

        If dgv.RowCount > 0 Then dgv.Rows.Clear()
        With tbMold
            .Text = ""
            .Focus()
        End With

    End Sub

#End Region

#Region "   Timer Events   "

    Private Sub Timer1_Tick(sender As System.Object, e As System.EventArgs) Handles Timer1.Tick

        CType(sender, Timer).Enabled = False
        tbMold.Focus()
        CreateBinListDataGridView(DataGridView2)
        LoadPrinters()
        userName = Utilities.GetUserName()
        lblUserName.Text = "User: " & userName

        bIsLoading = False
    End Sub

    Private Sub Timer2_Tick(sender As Object, e As System.EventArgs) Handles Timer2.Tick
        With Timer2
            .Enabled = False
        End With

        Dim dgv As DataGridView = CType(DataGridView2, DataGridView)
        Utilities.UnselectDataGridViewRows(dgv)

    End Sub

    Private Sub Timer3_Tick(sender As Object, e As System.EventArgs) Handles Timer3.Tick
        Timer3.Enabled = False
        tbMold.Text = ""
    End Sub

    Private Sub Timer4_Tick(sender As Object, e As System.EventArgs) Handles Timer4.Tick
        Timer4.Enabled = False
        lblSaved.Visible = False

    End Sub

    Private Sub tbMold_LostFocus(sender As Object, e As EventArgs) Handles tbMold.LostFocus

    End Sub

#End Region

End Class
