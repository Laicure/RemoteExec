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
        Me.toolStripCBInterval = New System.Windows.Forms.ToolStripComboBox()
        Me.toolStripOccu = New System.Windows.Forms.ToolStripMenuItem()
        Me.notIcon = New System.Windows.Forms.NotifyIcon(Me.components)
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
        Me.conMenuOptions.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.toolStripCBInterval, Me.toolStripOccu})
        Me.conMenuOptions.Name = "conMenuOptions"
        Me.conMenuOptions.ShowCheckMargin = True
        Me.conMenuOptions.ShowImageMargin = False
        Me.conMenuOptions.Size = New System.Drawing.Size(182, 75)
        '
        'toolStripCBInterval
        '
        Me.toolStripCBInterval.BackColor = System.Drawing.Color.Black
        Me.toolStripCBInterval.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.toolStripCBInterval.ForeColor = System.Drawing.Color.White
        Me.toolStripCBInterval.Items.AddRange(New Object() {"1min", "2mins", "3mins", "4mins", "5mins", "6mins", "7mins", "8mins", "9mins", "10mins", "15mins", "20mins", "25mins", "30mins"})
        Me.toolStripCBInterval.Name = "toolStripCBInterval"
        Me.toolStripCBInterval.Size = New System.Drawing.Size(121, 23)
        Me.toolStripCBInterval.ToolTipText = "Interval for checking scripts using the given path"
        '
        'toolStripOccu
        '
        Me.toolStripOccu.Checked = True
        Me.toolStripOccu.CheckOnClick = True
        Me.toolStripOccu.CheckState = System.Windows.Forms.CheckState.Checked
        Me.toolStripOccu.ForeColor = System.Drawing.Color.White
        Me.toolStripOccu.Name = "toolStripOccu"
        Me.toolStripOccu.Size = New System.Drawing.Size(181, 22)
        Me.toolStripOccu.Text = "Run Script Once"
        Me.toolStripOccu.ToolTipText = "Run script once every time a new script is detected"
        '
        'notIcon
        '
        Me.notIcon.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info
        Me.notIcon.BalloonTipTitle = "Remote Executor"
        Me.notIcon.Text = "Remote Exec"
        '
        'MainX
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
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
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Remote Executor"
        Me.conMenuOptions.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents timGetExec As System.Windows.Forms.Timer
    Friend WithEvents txtURL As System.Windows.Forms.TextBox
    Friend WithEvents butHide As System.Windows.Forms.Button
    Friend WithEvents butOptions As System.Windows.Forms.Button
    Friend WithEvents conMenuOptions As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents toolStripCBInterval As System.Windows.Forms.ToolStripComboBox
    Friend WithEvents toolStripOccu As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents notIcon As System.Windows.Forms.NotifyIcon
End Class
