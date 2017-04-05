<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ExecMsgBox
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
        Me.rtbMsgBox = New System.Windows.Forms.RichTextBox()
        Me.SuspendLayout()
        '
        'rtbMsgBox
        '
        Me.rtbMsgBox.BackColor = System.Drawing.Color.Black
        Me.rtbMsgBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.rtbMsgBox.DetectUrls = False
        Me.rtbMsgBox.Dock = System.Windows.Forms.DockStyle.Fill
        Me.rtbMsgBox.ForeColor = System.Drawing.Color.White
        Me.rtbMsgBox.Location = New System.Drawing.Point(1, 1)
        Me.rtbMsgBox.Name = "rtbMsgBox"
        Me.rtbMsgBox.ReadOnly = True
        Me.rtbMsgBox.Size = New System.Drawing.Size(282, 159)
        Me.rtbMsgBox.TabIndex = 0
        Me.rtbMsgBox.TabStop = False
        Me.rtbMsgBox.Text = ""
        Me.rtbMsgBox.WordWrap = False
        '
        'ExecMsgBox
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(284, 161)
        Me.Controls.Add(Me.rtbMsgBox)
        Me.DoubleBuffered = True
        Me.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.ForeColor = System.Drawing.Color.White
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "ExecMsgBox"
        Me.Padding = New System.Windows.Forms.Padding(1)
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Remote Execution Message Box"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents rtbMsgBox As System.Windows.Forms.RichTextBox
End Class
