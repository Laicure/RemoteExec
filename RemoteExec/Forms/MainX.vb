Public Class MainX
    Private Sub MainX_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        notIcon.Icon = My.Resources.script
        toolStripCBInterval.SelectedIndex = 3
        timGetExec.Enabled = True
    End Sub

    Private Sub timGetExec_Tick(sender As Object, e As EventArgs) Handles timGetExec.Tick

    End Sub

    Private Sub butHide_Click(sender As Object, e As EventArgs) Handles butHide.Click
        Me.Hide()
        notIcon.Visible = True
    End Sub

    Private Sub notIcon_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles notIcon.MouseDoubleClick
        Me.Show()
        Me.Activate()
        notIcon.Visible = False
    End Sub

    Private Sub butOptions_MouseDown(sender As Object, e As MouseEventArgs) Handles butOptions.MouseDown
        conMenuOptions.Show(MousePosition.X, MousePosition.Y)
    End Sub
End Class