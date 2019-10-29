<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class fMoldLabelApp
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(fMoldLabelApp))
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.lblCurrentDB = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ddPrinterList = New System.Windows.Forms.ToolStripDropDownButton()
        Me.lblDivider1 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.lblCurrent = New System.Windows.Forms.ToolStripStatusLabel()
        Me.lblCurrentPrinter = New System.Windows.Forms.ToolStripStatusLabel()
        Me.lblSaved = New System.Windows.Forms.ToolStripStatusLabel()
        Me.lblDivider2 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.lblReportLocation = New System.Windows.Forms.ToolStripStatusLabel()
        Me.lblDivider3 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.lblUserName = New System.Windows.Forms.ToolStripStatusLabel()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.tbPreviewPath = New System.Windows.Forms.TextBox()
        Me.tbDataPath = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.DataGridView2 = New System.Windows.Forms.DataGridView()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Panel10 = New System.Windows.Forms.Panel()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.btnPreview = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.tbMold = New System.Windows.Forms.RichTextBox()
        Me.btnPrint = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel7 = New System.Windows.Forms.Panel()
        Me.btnRefreshDB = New System.Windows.Forms.Button()
        Me.cbDBList = New System.Windows.Forms.ComboBox()
        Me.btnSaveDefaultDB = New System.Windows.Forms.Button()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.Timer3 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer4 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer5 = New System.Windows.Forms.Timer(Me.components)
        Me.ofdOpenFile = New System.Windows.Forms.OpenFileDialog()
        Me.StatusStrip1.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.Panel5.SuspendLayout()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel4.SuspendLayout()
        Me.Panel10.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel7.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.lblCurrentDB, Me.ddPrinterList, Me.lblDivider1, Me.lblCurrent, Me.lblCurrentPrinter, Me.lblSaved, Me.lblDivider2, Me.lblReportLocation, Me.lblDivider3, Me.lblUserName})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 557)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Padding = New System.Windows.Forms.Padding(1, 0, 19, 0)
        Me.StatusStrip1.Size = New System.Drawing.Size(974, 23)
        Me.StatusStrip1.TabIndex = 61
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'lblCurrentDB
        '
        Me.lblCurrentDB.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCurrentDB.Name = "lblCurrentDB"
        Me.lblCurrentDB.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblCurrentDB.Size = New System.Drawing.Size(0, 18)
        Me.lblCurrentDB.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.lblCurrentDB.Visible = False
        '
        'ddPrinterList
        '
        Me.ddPrinterList.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ddPrinterList.Image = Global.MassarelliMoldBinLabelApp.My.Resources.Resources.Printer1616
        Me.ddPrinterList.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ddPrinterList.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ddPrinterList.Name = "ddPrinterList"
        Me.ddPrinterList.Size = New System.Drawing.Size(105, 21)
        Me.ddPrinterList.Text = "Printer List"
        Me.ddPrinterList.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblDivider1
        '
        Me.lblDivider1.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Left
        Me.lblDivider1.BorderStyle = System.Windows.Forms.Border3DStyle.Sunken
        Me.lblDivider1.Name = "lblDivider1"
        Me.lblDivider1.Size = New System.Drawing.Size(4, 18)
        '
        'lblCurrent
        '
        Me.lblCurrent.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCurrent.Name = "lblCurrent"
        Me.lblCurrent.Size = New System.Drawing.Size(109, 18)
        Me.lblCurrent.Text = "Current Printer: "
        '
        'lblCurrentPrinter
        '
        Me.lblCurrentPrinter.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCurrentPrinter.Name = "lblCurrentPrinter"
        Me.lblCurrentPrinter.Size = New System.Drawing.Size(0, 18)
        '
        'lblSaved
        '
        Me.lblSaved.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSaved.Image = Global.MassarelliMoldBinLabelApp.My.Resources.Resources.SaveCheck1616
        Me.lblSaved.Name = "lblSaved"
        Me.lblSaved.Size = New System.Drawing.Size(127, 18)
        Me.lblSaved.Text = "Printer Saved!"
        Me.lblSaved.Visible = False
        '
        'lblDivider2
        '
        Me.lblDivider2.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Left
        Me.lblDivider2.BorderStyle = System.Windows.Forms.Border3DStyle.Sunken
        Me.lblDivider2.Name = "lblDivider2"
        Me.lblDivider2.Size = New System.Drawing.Size(4, 18)
        '
        'lblReportLocation
        '
        Me.lblReportLocation.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblReportLocation.Name = "lblReportLocation"
        Me.lblReportLocation.Size = New System.Drawing.Size(0, 18)
        '
        'lblDivider3
        '
        Me.lblDivider3.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Left
        Me.lblDivider3.BorderStyle = System.Windows.Forms.Border3DStyle.Sunken
        Me.lblDivider3.Name = "lblDivider3"
        Me.lblDivider3.Size = New System.Drawing.Size(4, 18)
        '
        'lblUserName
        '
        Me.lblUserName.Name = "lblUserName"
        Me.lblUserName.Size = New System.Drawing.Size(0, 18)
        '
        'Timer1
        '
        '
        'Timer2
        '
        '
        'tbPreviewPath
        '
        Me.tbPreviewPath.Location = New System.Drawing.Point(1155, 31)
        Me.tbPreviewPath.Margin = New System.Windows.Forms.Padding(4)
        Me.tbPreviewPath.Name = "tbPreviewPath"
        Me.tbPreviewPath.Size = New System.Drawing.Size(67, 22)
        Me.tbPreviewPath.TabIndex = 68
        Me.tbPreviewPath.Visible = False
        '
        'tbDataPath
        '
        Me.tbDataPath.Location = New System.Drawing.Point(1155, 63)
        Me.tbDataPath.Margin = New System.Windows.Forms.Padding(4)
        Me.tbDataPath.Name = "tbDataPath"
        Me.tbDataPath.Size = New System.Drawing.Size(67, 22)
        Me.tbDataPath.TabIndex = 69
        Me.tbDataPath.Visible = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(1053, 37)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(90, 17)
        Me.Label3.TabIndex = 70
        Me.Label3.Text = "Preview Path"
        Me.Label3.Visible = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(1053, 71)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(71, 17)
        Me.Label4.TabIndex = 71
        Me.Label4.Text = "Data Path"
        Me.Label4.Visible = False
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.Panel1)
        Me.Panel3.Controls.Add(Me.Panel2)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel3.Location = New System.Drawing.Point(0, 0)
        Me.Panel3.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(974, 557)
        Me.Panel3.TabIndex = 80
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Panel5)
        Me.Panel1.Controls.Add(Me.Panel4)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(974, 557)
        Me.Panel1.TabIndex = 85
        '
        'Panel5
        '
        Me.Panel5.Controls.Add(Me.DataGridView2)
        Me.Panel5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel5.Location = New System.Drawing.Point(0, 74)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(974, 483)
        Me.Panel5.TabIndex = 79
        '
        'DataGridView2
        '
        Me.DataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataGridView2.Location = New System.Drawing.Point(0, 0)
        Me.DataGridView2.Name = "DataGridView2"
        Me.DataGridView2.RowTemplate.Height = 24
        Me.DataGridView2.Size = New System.Drawing.Size(974, 483)
        Me.DataGridView2.TabIndex = 80
        '
        'Panel4
        '
        Me.Panel4.Controls.Add(Me.Panel10)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel4.Location = New System.Drawing.Point(0, 0)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(974, 74)
        Me.Panel4.TabIndex = 77
        '
        'Panel10
        '
        Me.Panel10.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel10.Controls.Add(Me.btnClear)
        Me.Panel10.Controls.Add(Me.btnDelete)
        Me.Panel10.Controls.Add(Me.btnPreview)
        Me.Panel10.Controls.Add(Me.Label1)
        Me.Panel10.Controls.Add(Me.tbMold)
        Me.Panel10.Controls.Add(Me.btnPrint)
        Me.Panel10.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel10.Location = New System.Drawing.Point(0, 0)
        Me.Panel10.MinimumSize = New System.Drawing.Size(756, 80)
        Me.Panel10.Name = "Panel10"
        Me.Panel10.Size = New System.Drawing.Size(974, 80)
        Me.Panel10.TabIndex = 3
        '
        'btnClear
        '
        Me.btnClear.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.btnClear.Location = New System.Drawing.Point(809, 11)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(147, 51)
        Me.btnClear.TabIndex = 200
        Me.btnClear.Text = "Clear All"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnDelete
        '
        Me.btnDelete.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.btnDelete.Location = New System.Drawing.Point(667, 11)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(136, 51)
        Me.btnDelete.TabIndex = 199
        Me.btnDelete.Text = "Delete Row"
        Me.btnDelete.UseVisualStyleBackColor = True
        '
        'btnPreview
        '
        Me.btnPreview.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.btnPreview.Location = New System.Drawing.Point(530, 11)
        Me.btnPreview.Name = "btnPreview"
        Me.btnPreview.Size = New System.Drawing.Size(131, 51)
        Me.btnPreview.TabIndex = 198
        Me.btnPreview.Text = "Preview"
        Me.btnPreview.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Bold)
        Me.Label1.Location = New System.Drawing.Point(16, 16)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(125, 39)
        Me.Label1.TabIndex = 197
        Me.Label1.Text = "Mold #"
        '
        'tbMold
        '
        Me.tbMold.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.tbMold.Font = New System.Drawing.Font("Microsoft Sans Serif", 22.0!, System.Drawing.FontStyle.Bold)
        Me.tbMold.Location = New System.Drawing.Point(149, 9)
        Me.tbMold.Margin = New System.Windows.Forms.Padding(4)
        Me.tbMold.Name = "tbMold"
        Me.tbMold.Size = New System.Drawing.Size(195, 51)
        Me.tbMold.TabIndex = 196
        Me.tbMold.Text = ""
        '
        'btnPrint
        '
        Me.btnPrint.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Bold)
        Me.btnPrint.Location = New System.Drawing.Point(351, 9)
        Me.btnPrint.Name = "btnPrint"
        Me.btnPrint.Size = New System.Drawing.Size(131, 51)
        Me.btnPrint.TabIndex = 195
        Me.btnPrint.Text = "Print"
        Me.btnPrint.UseVisualStyleBackColor = True
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.Panel7)
        Me.Panel2.Controls.Add(Me.Panel6)
        Me.Panel2.Location = New System.Drawing.Point(0, 600)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1225, 44)
        Me.Panel2.TabIndex = 82
        Me.Panel2.Visible = False
        '
        'Panel7
        '
        Me.Panel7.Controls.Add(Me.btnRefreshDB)
        Me.Panel7.Controls.Add(Me.cbDBList)
        Me.Panel7.Controls.Add(Me.btnSaveDefaultDB)
        Me.Panel7.Controls.Add(Me.PictureBox2)
        Me.Panel7.Controls.Add(Me.Label7)
        Me.Panel7.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel7.Location = New System.Drawing.Point(0, 0)
        Me.Panel7.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel7.Name = "Panel7"
        Me.Panel7.Size = New System.Drawing.Size(810, 44)
        Me.Panel7.TabIndex = 83
        '
        'btnRefreshDB
        '
        Me.btnRefreshDB.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRefreshDB.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnRefreshDB.Location = New System.Drawing.Point(255, 7)
        Me.btnRefreshDB.Margin = New System.Windows.Forms.Padding(4)
        Me.btnRefreshDB.Name = "btnRefreshDB"
        Me.btnRefreshDB.Size = New System.Drawing.Size(31, 26)
        Me.btnRefreshDB.TabIndex = 190
        Me.btnRefreshDB.UseVisualStyleBackColor = True
        '
        'cbDBList
        '
        Me.cbDBList.FormattingEnabled = True
        Me.cbDBList.Location = New System.Drawing.Point(115, 7)
        Me.cbDBList.Margin = New System.Windows.Forms.Padding(4)
        Me.cbDBList.Name = "cbDBList"
        Me.cbDBList.Size = New System.Drawing.Size(131, 24)
        Me.cbDBList.TabIndex = 189
        '
        'btnSaveDefaultDB
        '
        Me.btnSaveDefaultDB.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSaveDefaultDB.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnSaveDefaultDB.Location = New System.Drawing.Point(285, 7)
        Me.btnSaveDefaultDB.Margin = New System.Windows.Forms.Padding(4)
        Me.btnSaveDefaultDB.Name = "btnSaveDefaultDB"
        Me.btnSaveDefaultDB.Size = New System.Drawing.Size(31, 26)
        Me.btnSaveDefaultDB.TabIndex = 191
        Me.btnSaveDefaultDB.UseVisualStyleBackColor = True
        '
        'PictureBox2
        '
        Me.PictureBox2.Location = New System.Drawing.Point(17, 10)
        Me.PictureBox2.Margin = New System.Windows.Forms.Padding(4)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(21, 18)
        Me.PictureBox2.TabIndex = 188
        Me.PictureBox2.TabStop = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(47, 11)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(42, 17)
        Me.Label7.TabIndex = 187
        Me.Label7.Text = "&Data:"
        '
        'Panel6
        '
        Me.Panel6.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel6.Location = New System.Drawing.Point(810, 0)
        Me.Panel6.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(415, 44)
        Me.Panel6.TabIndex = 82
        '
        'Timer3
        '
        '
        'Timer4
        '
        '
        'ofdOpenFile
        '
        Me.ofdOpenFile.DefaultExt = "btw"
        Me.ofdOpenFile.Filter = "Crystal Report (*.rpt)|*.rpt"
        Me.ofdOpenFile.Title = "Open BarTender Label Format"
        '
        'fMoldLabelApp
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(974, 580)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.tbDataPath)
        Me.Controls.Add(Me.tbPreviewPath)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MinimumSize = New System.Drawing.Size(933, 300)
        Me.Name = "fMoldLabelApp"
        Me.Text = "Print Mold Labels"
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel5.ResumeLayout(False)
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel4.ResumeLayout(False)
        Me.Panel10.ResumeLayout(False)
        Me.Panel10.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel7.ResumeLayout(False)
        Me.Panel7.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents lblCurrentDB As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents Timer2 As System.Windows.Forms.Timer
    Friend WithEvents tbPreviewPath As System.Windows.Forms.TextBox
    Friend WithEvents tbDataPath As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Panel7 As System.Windows.Forms.Panel
    Friend WithEvents Panel6 As System.Windows.Forms.Panel
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Private WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents btnRefreshDB As System.Windows.Forms.Button
    Friend WithEvents cbDBList As System.Windows.Forms.ComboBox
    Friend WithEvents btnSaveDefaultDB As System.Windows.Forms.Button
    Friend WithEvents Timer3 As System.Windows.Forms.Timer
    Friend WithEvents Timer4 As System.Windows.Forms.Timer
    Friend WithEvents Timer5 As System.Windows.Forms.Timer
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Private WithEvents ofdOpenFile As System.Windows.Forms.OpenFileDialog
    Friend WithEvents Panel5 As System.Windows.Forms.Panel
    Friend WithEvents DataGridView2 As System.Windows.Forms.DataGridView
    Friend WithEvents lblReportLocation As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents Panel10 As System.Windows.Forms.Panel
    Friend WithEvents btnClear As System.Windows.Forms.Button
    Friend WithEvents btnDelete As System.Windows.Forms.Button
    Friend WithEvents btnPreview As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents tbMold As System.Windows.Forms.RichTextBox
    Friend WithEvents btnPrint As System.Windows.Forms.Button
    Friend WithEvents ddPrinterList As System.Windows.Forms.ToolStripDropDownButton
    Friend WithEvents lblCurrentPrinter As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents lblDivider1 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents lblCurrent As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents lblSaved As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents lblDivider2 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents lblDivider3 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents lblUserName As System.Windows.Forms.ToolStripStatusLabel

End Class
