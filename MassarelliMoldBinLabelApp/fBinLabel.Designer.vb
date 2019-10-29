<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class fBinLabel
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(fBinLabel))
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.crvBinLabel = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.ContainerControl = Me
        '
        'crvBinLabel
        '
        Me.crvBinLabel.ActiveViewIndex = -1
        Me.crvBinLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.crvBinLabel.CachedPageNumberPerDoc = 10
        Me.crvBinLabel.Cursor = System.Windows.Forms.Cursors.Default
        Me.crvBinLabel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.crvBinLabel.Location = New System.Drawing.Point(0, 0)
        Me.crvBinLabel.Name = "crvBinLabel"
        Me.crvBinLabel.Size = New System.Drawing.Size(696, 649)
        Me.crvBinLabel.TabIndex = 0
        '
        'Timer1
        '
        '
        'fBinLabel
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(696, 649)
        Me.Controls.Add(Me.crvBinLabel)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "fBinLabel"
        Me.Text = "Bin Labels"
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ErrorProvider1 As System.Windows.Forms.ErrorProvider
    Friend WithEvents crvBinLabel As CrystalDecisions.Windows.Forms.CrystalReportViewer
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    'Friend WithEvents CrystalReportViewer1 As CrystalDecisions.Windows.Forms.CrystalReportViewer
    'Friend WithEvents CrystalReport11 As MassarelliMoldLabelApp.CrystalReport1
End Class
