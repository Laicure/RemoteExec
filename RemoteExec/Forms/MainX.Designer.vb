<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainX
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
        Me.timGetExec = New System.Windows.Forms.Timer(Me.components)
        Me.txtURL = New System.Windows.Forms.TextBox()
        Me.butHide = New System.Windows.Forms.Button()
        Me.butOptions = New System.Windows.Forms.Button()
        Me.conMenuOptions = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.toolStriptxtInterval = New System.Windows.Forms.ToolStripTextBox()
        Me.toolStripChOccuOnce = New System.Windows.Forms.ToolStripMenuItem()
        Me.toolStripChAutoStealth = New System.Windows.Forms.ToolStripMenuItem()
        Me.notIcon = New System.Windows.Forms.NotifyIcon(Me.components)
        Me.bgGetScript = New System.ComponentModel.BackgroundWorker()
        Me.tipper = New System.Windows.Forms.ToolTip(Me.components)
        Me.conMenuOptions.SuspendLayout()
        Me.SuspendLayout()
        '
        'timGetExec
        '
        Me.timGetExec.Interval = 420000
        '
        'txtURL
        '
        Me.txtURL.BackColor = System.Drawing.Color.Black
        Me.txtURL.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtURL.ForeColor = System.Drawing.Color.White
        Me.txtURL.Location = New System.Drawing.Point(1, 1)
        Me.txtURL.Name = "txtURL"
        Me.txtURL.Size = New System.Drawing.Size(240, 22)
        Me.txtURL.TabIndex = 0
        Me.txtURL.TabStop = False
        Me.tipper.SetToolTip(Me.txtURL, "Script path")
        Me.txtURL.WordWrap = False
        '
        'butHide
        '
        Me.butHide.BackColor = System.Drawing.Color.Black
        Me.butHide.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.butHide.Location = New System.Drawing.Point(240, 0)
        Me.butHide.Name = "butHide"
        Me.butHide.Size = New System.Drawing.Size(43, 24)
        Me.butHide.TabIndex = 1
        Me.butHide.TabStop = False
        Me.butHide.Text = "Hide"
        Me.tipper.SetToolTip(Me.butHide, "Hide and Start the countdown")
        Me.butHide.UseVisualStyleBackColor = False
        '
        'butOptions
        '
        Me.butOptions.BackColor = System.Drawing.Color.Black
        Me.butOptions.ContextMenuStrip = Me.conMenuOptions
        Me.butOptions.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.butOptions.Location = New System.Drawing.Point(282, 0)
        Me.butOptions.Name = "butOptions"
        Me.butOptions.Size = New System.Drawing.Size(61, 24)
        Me.butOptions.TabIndex = 2
        Me.butOptions.TabStop = False
        Me.butOptions.Text = "Options"
        Me.butOptions.UseVisualStyleBackColor = False
        '
        'conMenuOptions
        '
        Me.conMenuOptions.BackColor = System.Drawing.Color.Black
        Me.conMenuOptions.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.toolStriptxtInterval, Me.toolStripChOccuOnce, Me.toolStripChAutoStealth})
        Me.conMenuOptions.Name = "conMenuOptions"
        Me.conMenuOptions.ShowCheckMargin = True
        Me.conMenuOptions.ShowImageMargin = False
        Me.conMenuOptions.Size = New System.Drawing.Size(161, 73)
        '
        'toolStriptxtInterval
        '
        Me.toolStriptxtInterval.BackColor = System.Drawing.Color.Black
        Me.toolStriptxtInterval.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.toolStriptxtInterval.ForeColor = System.Drawing.Color.White
        Me.toolStriptxtInterval.Name = "toolStriptxtInterval"
        Me.toolStriptxtInterval.Size = New System.Drawing.Size(100, 23)
        Me.toolStriptxtInterval.Text = "4"
        Me.toolStriptxtInterval.TextBoxTextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.toolStriptxtInterval.ToolTipText = "Execution and Script path check interval in minutes"
        '
        'toolStripChOccuOnce
        '
        Me.toolStripChOccuOnce.Checked = True
        Me.toolStripChOccuOnce.CheckOnClick = True
        Me.toolStripChOccuOnce.CheckState = System.Windows.Forms.CheckState.Checked
        Me.toolStripChOccuOnce.ForeColor = System.Drawing.Color.White
        Me.toolStripChOccuOnce.Name = "toolStripChOccuOnce"
        Me.toolStripChOccuOnce.Size = New System.Drawing.Size(160, 22)
        Me.toolStripChOccuOnce.Text = "Run Script Once"
        Me.toolStripChOccuOnce.ToolTipText = "Newly detected script is run only once" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "(prevents execution loop)"
        '
        'toolStripChAutoStealth
        '
        Me.toolStripChAutoStealth.CheckOnClick = True
        Me.toolStripChAutoStealth.ForeColor = System.Drawing.Color.White
        Me.toolStripChAutoStealth.Name = "toolStripChAutoStealth"
        Me.toolStripChAutoStealth.Size = New System.Drawing.Size(160, 22)
        Me.toolStripChAutoStealth.Text = "Auto Start"
        Me.toolStripChAutoStealth.ToolTipText = "Auto Starts the app without showing any UI"
        '
        'notIcon
        '
        Me.notIcon.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info
        Me.notIcon.BalloonTipTitle = "Remote Executor"
        Me.notIcon.Text = "Remote Exec"
        '
        'bgGetScript
        '
        '
        'tipper
        '
        Me.tipper.BackColor = System.Drawing.Color.White
        Me.tipper.ForeColor = System.Drawing.Color.Black
        Me.tipper.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info
        Me.tipper.ToolTipTitle = "RemoteExec"
        Me.tipper.UseAnimation = False
        Me.tipper.UseFading = False
        '
        'MainX
        '
        Me.AcceptButton = Me.butHide
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(343, 24)
        Me.Controls.Add(Me.butOptions)
        Me.Controls.Add(Me.butHide)
        Me.Controls.Add(Me.txtURL)
        Me.DoubleBuffered = True
        Me.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.White
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "MainX"
        Me.Padding = New System.Windows.Forms.Padding(1)
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Remote Executor"
        Me.TopMost = True
        Me.conMenuOptions.ResumeLayout(False)
        Me.conMenuOptions.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents timGetExec As System.Windows.Forms.Timer
    Friend WithEvents txtURL As System.Windows.Forms.TextBox
    Friend WithEvents butHide As System.Windows.Forms.Button
    Friend WithEvents butOptions As System.Windows.Forms.Button
    Friend WithEvents conMenuOptions As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents toolStripChOccuOnce As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents notIcon As System.Windows.Forms.NotifyIcon
    Friend WithEvents toolStriptxtInterval As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents bgGetScript As System.ComponentModel.BackgroundWorker
    Friend WithEvents tipper As System.Windows.Forms.ToolTip
    Friend WithEvents toolStripChAutoStealth As System.Windows.Forms.ToolStripMenuItem
End Class
