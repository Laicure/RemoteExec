Public Class MainX
    Dim fetchedScript As String = Nothing
    Dim scriptFetchError As Boolean = False
    Dim ScriptContent As String = Nothing
    Dim ScriptRan As Boolean = False    

    Private Sub MainX_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Icon = My.Resources.script
        notIcon.Icon = My.Resources.script

        toolStriptxtInterval.Text = FormatNumber(My.Settings.RefInterval.ToString, 2)

        txtURL.Text = My.Settings.ScriptPath
        toolStripChOccuOnce.Checked = My.Settings.RunOncePerScript
        toolStripChAutoStealth.Checked = My.Settings.AutoStealth
    End Sub

    Private Sub MainX_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Me.Hide()

        My.Settings.RefInterval = Val(toolStriptxtInterval.Text)
        My.Settings.ScriptPath = txtURL.Text
        My.Settings.RunOncePerScript = toolStripChOccuOnce.Checked
        My.Settings.AutoStealth = toolStripChAutoStealth.Checked
        My.Settings.Save()
    End Sub

    Private Sub timGetExec_Tick(sender As Object, e As EventArgs) Handles timGetExec.Tick
        If Not bgGetScript.IsBusy Then
            bgGetScript.RunWorkerAsync()
        End If
    End Sub

    Private Sub bgGetScript_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles bgGetScript.DoWork
        timGetExec.Enabled = False
        Try
            Using client As New Net.WebClient, reader As IO.StreamReader = New IO.StreamReader(client.OpenRead(txtURL.Text))
                fetchedScript = reader.ReadLine.Normalize
            End Using
            scriptFetchError = False
        Catch ex As Exception
            scriptFetchError = True
        End Try
    End Sub

    Private Sub bgGetScript_RunWorkerCompleted(sender As Object, e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles bgGetScript.RunWorkerCompleted
        'check if content is same else exec
        If Not fetchedScript = ScriptContent Then
            ScriptContent = fetchedScript

            'script ran reset (also new scripts)
            ScriptRan = False
        End If

        'exec script
        If Not ScriptRan Then            

            If toolStripChOccuOnce.Checked Then
                ScriptRan = True
            Else
                ScriptRan = False
            End If
        End If

        'continue timer
        timGetExec.Enabled = True
    End Sub

    Private Sub butHide_Click(sender As Object, e As EventArgs) Handles butHide.Click
        If Not Uri.IsWellFormedUriString(txtURL.Text, UriKind.Absolute) Then
            MessageBox.Show("Invalid Script Path!", "Invalid!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtURL.Focus()
            Exit Sub
        End If

        Me.Hide()
        notIcon.Visible = True

        My.Settings.RefInterval = Val(toolStriptxtInterval.Text)
        My.Settings.ScriptPath = txtURL.Text
        My.Settings.RunOncePerScript = toolStripChOccuOnce.Checked
        My.Settings.AutoStealth = toolStripChAutoStealth.Checked
        My.Settings.Save()

        timGetExec.Interval = CInt(Val(toolStriptxtInterval.Text) * 60000)
        timGetExec.Enabled = True
    End Sub

    Private Sub notIcon_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles notIcon.MouseDoubleClick
        timGetExec.Enabled = False
        ScriptContent = Nothing

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
        toolStriptxtInterval.Text = FormatNumber(toolStriptxtInterval.Text, 2)
    End Sub

End Class