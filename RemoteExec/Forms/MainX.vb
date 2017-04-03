Public Class MainX
    Private Sub MainX_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        notIcon.Icon = My.Resources.script

        toolStriptxtInterval.Text = FormatNumber(My.Settings.RefInterval.ToString, 0)

        txtURL.Text = My.Settings.ScriptPath
        toolStripChOccuOnce.Checked = My.Settings.RunOncePerScript
    End Sub

    Private Sub timGetExec_Tick(sender As Object, e As EventArgs) Handles timGetExec.Tick

    End Sub

    Private Sub butHide_Click(sender As Object, e As EventArgs) Handles butHide.Click
        Me.Hide()
        notIcon.Visible = True

        My.Settings.RefInterval = CInt(Val(toolStriptxtInterval.Text))
        My.Settings.ScriptPath = txtURL.Text
        My.Settings.RunOncePerScript = toolStripChOccuOnce.Checked
        My.Settings.Save()

        timGetExec.Interval = CInt(Val(toolStriptxtInterval.Text) * 60000)
        timGetExec.Enabled = True
    End Sub

    Private Sub notIcon_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles notIcon.MouseDoubleClick
        Me.Show()
        Me.Activate()
        notIcon.Visible = False
    End Sub

    Private Sub butOptions_MouseDown(sender As Object, e As MouseEventArgs) Handles butOptions.MouseDown
        conMenuOptions.Show(MousePosition.X, MousePosition.Y)
    End Sub

    Private Sub conMenuOptions_Closing(sender As Object, e As ToolStripDropDownClosingEventArgs) Handles conMenuOptions.Closing
        If String.IsNullOrWhiteSpace(toolStriptxtInterval.Text) Or Not IsNumeric(toolStriptxtInterval.Text) Then
            toolStriptxtInterval.Text = "4"            
        End If
        toolStriptxtInterval.Text = FormatNumber(toolStriptxtInterval.Text, 0)
    End Sub
End Class