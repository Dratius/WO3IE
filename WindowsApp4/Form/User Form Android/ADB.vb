Imports System.IO
Public Class ADB
    Dim inter As Interference
    Dim fst As FastBoot
    Dim droid As Android
    Dim myDoc = My.Computer.FileSystem.SpecialDirectories.MyDocuments & "\Android Tools\"

    Sub ADBComm(ByVal Arg As String)
        Dim procStartInfo As New ProcessStartInfo
        Dim proExecute As New Process

        Try
            With procStartInfo
                .CreateNoWindow = True
                .UseShellExecute = False
                .FileName = "adb.exe"
                .Arguments = Arg
                .RedirectStandardOutput = True
                .RedirectStandardInput = True
                .RedirectStandardError = True
            End With
            proExecute = Process.Start(procStartInfo)
            proExecute.WaitForExit()
            proExecute.StandardInput.WriteLine(Arg)
            proExecute.StandardInput.Close()
        Catch ex As Exception
            Application.Exit()
        Finally
            proExecute.Close()
            proExecute.Dispose()
        End Try
    End Sub

    Public Sub ExecuteCommand()

        Dim cmdInput As String = txt_RunADB.Text
        Dim proc As New Process

        proc.StartInfo.CreateNoWindow = True
        proc.StartInfo.UseShellExecute = False
        proc.StartInfo.FileName = "adb.exe"
        proc.StartInfo.Arguments = cmdInput
        proc.StartInfo.RedirectStandardOutput = True
        proc.StartInfo.RedirectStandardInput = True
        proc.StartInfo.RedirectStandardError = True
        proc.Start()

        proc.StandardInput.WriteLine(cmdInput)
        proc.StandardInput.Close()

        Dim line As String = Nothing
        Dim lines As Integer = 0
        While (proc.StandardOutput.EndOfStream = False)
            line = proc.StandardOutput.ReadLine
            txt_Logs.AppendText(line & vbNewLine)
            lines = lines + 1
        End While

        proc.Close()
        proc.Dispose()

        txt_RunADB.Text = ""
    End Sub

    Sub DisableAllControl()
        Try
            Dim i As Integer = -1
            Dim a As Control

            'MAIN TAB
            For Each a In GroupBox1.Controls
                If TypeOf a Is GroupBox Then
                    a.Enabled = False
                End If
            Next

            For Each a In gb_ManualADB.Controls
                If TypeOf a Is GroupBox Then
                    a.Enabled = False
                End If
            Next

            For Each a In GroupBox1.Controls
                If TypeOf a Is Button Then
                    a.Enabled = False
                End If
            Next

            For Each a In gb_RebootOptions.Controls
                If TypeOf a Is GroupBox Then
                    a.Enabled = False
                End If
            Next

            For Each a In gb_Sideload.Controls
                If TypeOf a Is GroupBox Then
                    a.Enabled = False
                End If
            Next

            For Each a In GroupBox1.Controls
                If TypeOf a Is RadioButton Then
                    a.Enabled = False
                End If
            Next

            For Each a In fst.gb_flash.Controls
                If TypeOf a Is GroupBox Then
                    a.Enabled = False
                End If
            Next

            For Each a In fst.gb_manualfastboot.Controls
                If TypeOf a Is GroupBox Then
                    a.Enabled = False
                End If
            Next

            For Each a In fst.gb_flash.Controls
                If TypeOf a Is CheckBox Then
                    a.Enabled = False
                End If
            Next

            For Each a In inter.gb_APKOptions.Controls
                If TypeOf a Is GroupBox Then
                    a.Enabled = False
                End If
            Next

            fst.btn_flash.Enabled = False
            inter.btn_InstallAPK.Enabled = False
            inter.btn_RefreshListAPK.Enabled = False
            inter.btn_RestoreAPK.Enabled = False
            inter.list_APK.Items.Clear()
        Catch ex As Exception
            MsgBox(ex.Message)
            Application.Exit()
        End Try
    End Sub

    Sub EnableAllControl()
        Try
            Dim i As Integer = -1
            Dim a As Control

            'MAIN TAB
            For Each a In GroupBox1.Controls
                If TypeOf a Is GroupBox Then
                    a.Enabled = True
                End If
            Next

            For Each a In gb_ManualADB.Controls
                If TypeOf a Is GroupBox Then
                    a.Enabled = True
                End If
            Next

            For Each a In GroupBox1.Controls
                If TypeOf a Is Button Then
                    a.Enabled = True
                End If
            Next

            For Each a In gb_RebootOptions.Controls
                If TypeOf a Is GroupBox Then
                    a.Enabled = True
                End If
            Next

            For Each a In gb_Sideload.Controls
                If TypeOf a Is GroupBox Then
                    a.Enabled = True
                End If
            Next

            For Each a In GroupBox1.Controls
                If TypeOf a Is RadioButton Then
                    a.Enabled = True
                End If
            Next

            For Each a In fst.gb_flash.Controls
                If TypeOf a Is GroupBox Then
                    a.Enabled = True
                End If
            Next

            For Each a In fst.gb_manualfastboot.Controls
                If TypeOf a Is GroupBox Then
                    a.Enabled = True
                End If
            Next

            For Each a In fst.gb_flash.Controls
                If TypeOf a Is CheckBox Then
                    a.Enabled = True
                End If
            Next

            For Each a In inter.gb_APKOptions.Controls
                If TypeOf a Is GroupBox Then
                    a.Enabled = True
                End If
            Next

            fst.btn_flash.Enabled = True
            inter.btn_InstallAPK.Enabled = True
            inter.btn_RefreshListAPK.Enabled = True
            inter.btn_RestoreAPK.Enabled = True
            inter.list_APK.Items.Clear()
        Catch ex As Exception
            MsgBox(ex.Message)
            Application.Exit()
        End Try
    End Sub

    Public Sub ADBSideload()

        Call DisableAllControl()
        ADBComm("sideload " & txt_SideloadPath.Text)

        System.Threading.Thread.Sleep(2000)
        txt_Logs.AppendText(lbl_time.Text.ToString & "Zip file successfully flashed" & vbNewLine)
        txt_Logs.ScrollToCaret()
        txt_SideloadPath.Text = ""
        cb_SideLoad.Checked = False
    End Sub

    Public Sub ADBSideloadM()

        btn_Sideload.Enabled = False
        ADBComm("reboot sideload " & txt_SideloadPath.Text)

        System.Threading.Thread.Sleep(2000)
        txt_Logs.AppendText(lbl_time.Text.ToString & "Zip file successfully flashed" & vbNewLine)
        txt_Logs.ScrollToCaret()
        txt_SideloadPath.Text = ""
        btn_Sideload.Enabled = True
    End Sub

    'Get connected Devices list function
    Public Sub DeviceList()

        Dim cmdInput As String = "devices -l"
        Dim proc As New Process

        Try
            proc.StartInfo.CreateNoWindow = True
            proc.StartInfo.UseShellExecute = False
            proc.StartInfo.FileName = "adb.exe"
            proc.StartInfo.Verb = "runas"
            proc.StartInfo.Arguments = cmdInput
            proc.StartInfo.RedirectStandardOutput = True
            proc.StartInfo.RedirectStandardInput = True
            proc.StartInfo.RedirectStandardError = True
            proc.Start()

            proc.StandardInput.WriteLine(cmdInput)
            proc.StandardInput.Close()
            Dim line As String = Nothing
            Dim lines As Integer = 0
            While (proc.StandardOutput.EndOfStream = False)
                line = proc.StandardOutput.ReadLine
                txt_Logs.AppendText(lbl_time.Text.ToString & line & vbNewLine)
                lines = lines + 1
            End While

        Finally
            proc.Close()
            proc.Dispose()
        End Try
    End Sub

    Public Sub GetSerialNumber()

        Dim cmdInput As String = "get-serialno"
        Dim proc As New Process

        proc.StartInfo.CreateNoWindow = True
        proc.StartInfo.UseShellExecute = False
        proc.StartInfo.FileName = "adb.exe"
        proc.StartInfo.Arguments = cmdInput
        proc.StartInfo.RedirectStandardOutput = True
        proc.StartInfo.RedirectStandardInput = True
        proc.StartInfo.RedirectStandardError = True
        proc.Start()

        proc.StandardInput.WriteLine(cmdInput)
        proc.StandardInput.Close()

        Dim line As String = Nothing
        Dim lines As Integer = 0
        While (proc.StandardOutput.EndOfStream = False)
            line = proc.StandardOutput.ReadLine
            txt_Logs.AppendText(lbl_time.Text.ToString & line & vbNewLine)
            lines = lines + 1
        End While

        proc.Close()
        proc.Dispose()
    End Sub

    Public Sub Reboot()

        ADBComm("reboot")

        System.Threading.Thread.Sleep(5000)
        txt_Logs.AppendText(lbl_time.Text.ToString & "Device Rebooted" & vbNewLine)
        txt_Logs.ScrollToCaret()
    End Sub

    'Reboot Device (Recovery Reboot) function
    Public Sub RebootRecovery()

        ADBComm("reboot recovery")

        System.Threading.Thread.Sleep(5000)
        txt_Logs.AppendText(lbl_time.Text.ToString & "Device Rebooted to Recovery" & vbNewLine)
        txt_Logs.ScrollToCaret()
    End Sub

    'Reboot Device (Bootloader/Fastboot Reboot) function
    Public Sub RebootBL()

        ADBComm("reboot-bootloader")

        System.Threading.Thread.Sleep(5000)
        txt_Logs.AppendText(lbl_time.Text.ToString & "Device Rebooted to Bootloader" & vbNewLine)
        txt_Logs.ScrollToCaret()
    End Sub

    'Push file function
    Sub Push()

        Enabled = False
        ADBComm("push """ & txt_PushPath.Text & """ " & txt_PushSDPath.Text)
        txt_Logs.AppendText(lbl_time.Text.ToString & "[" & txt_PushPath.Text & "] pushed to " & txt_PushSDPath.Text & vbNewLine)
        Me.Enabled = True
        txt_PushPath.Text = ""
        txt_PushSDPath.Text = ""
    End Sub

    'Pull file function
    Sub Pull()

        Enabled = False
        ADBComm("pull " & txt_PushSDPath.Text & "/" & txtx_PullFileName.Text & " """ & txt_PushPath.Text & """")
        txt_Logs.AppendText(lbl_time.Text.ToString & "[" & txtx_PullFileName.Text & "] pulled to " & txt_PushPath.Text & vbNewLine)
        Me.Enabled = True
        txt_PushPath.Text = ""
        txt_PushSDPath.Text = ""
    End Sub


    'Apk pull function
    Private Sub ApkPull()

        Dim ssl = cobo_apklist.SelectedItem.ToString
        Dim mydir = myDoc & "apk-dir\" & ssl & ".apk"

        Enabled = False
        ADBComm("pull " & txt_apkpath.Text & " """ & mydir & """")
        Process.Start(myDoc & "apk-dir\")
        txt_Logs.AppendText(lbl_time.Text.ToString & "[" & ssl & "] pulled" & vbNewLine)
        'TODO PopulateApkDir()
        Me.Enabled = True
        cobo_apklist.SelectedIndex = -1
    End Sub

    'Get Application Package function
    Public Sub PushPullPackagesList()
        cobo_apklist.Enabled = False
        cobo_apklist.Items.Clear()
        Dim cmdInput As String = "shell pm list packages -3"
        Dim proc As New Process

        proc.StartInfo.CreateNoWindow = True
        proc.StartInfo.UseShellExecute = False
        proc.StartInfo.FileName = "adb.exe"
        proc.StartInfo.Arguments = cmdInput
        proc.StartInfo.RedirectStandardOutput = True
        proc.StartInfo.RedirectStandardInput = True
        proc.StartInfo.RedirectStandardError = True
        proc.Start()

        proc.StandardInput.WriteLine(cmdInput)
        proc.StandardInput.Close()

        Dim line As String = Nothing
        Dim lines As Integer = 0
        While (proc.StandardOutput.EndOfStream = False)
            line = proc.StandardOutput.ReadLine
            cobo_apklist.Items.Add(line)
            lines = lines + 1
        End While

        proc.Close()
        proc.Dispose()

        'Clearing empty string on listbox
        Dim i As Integer
        Do While (cobo_apklist.Items.Count) - 1 >= i
            If String.IsNullOrEmpty(cobo_apklist.Items(i)) Then
                cobo_apklist.Items.Remove(cobo_apklist.Items(i))
                i -= 1
            End If
            i += 1
        Loop

        'Remove package: string from listbox
        'ADB Output is package:com.my.app
        For f As Integer = 0 To cobo_apklist.Items.Count - 1
            cobo_apklist.Items(f) = cobo_apklist.Items(f).ToString.Substring(8)
        Next

        cobo_apklist.Enabled = True
    End Sub

    'Get Apk Directory from selected package list function
    Public Sub GetApkDir()
        txt_apkpath.Text = "Getting Package Path..."
        Dim DummyTextbox As New TextBox
        Dim Dummy2 As New TextBox
        btn_apk_pull.Enabled = False
        If cobo_apklist.SelectedIndex = -1 Then
            Exit Sub
        Else
            DummyTextbox.Text = cobo_apklist.SelectedItem.ToString
        End If

        Dim cmdInput As String = "shell pm path " & DummyTextbox.Text
        Dim proc As New Process

        proc.StartInfo.CreateNoWindow = True
        proc.StartInfo.UseShellExecute = False
        proc.StartInfo.FileName = "adb.exe"
        proc.StartInfo.Arguments = cmdInput
        proc.StartInfo.RedirectStandardOutput = True
        proc.StartInfo.RedirectStandardInput = True
        proc.StartInfo.RedirectStandardError = True
        proc.Start()

        proc.StandardInput.WriteLine(cmdInput)
        proc.StandardInput.Close()

        Dim line As String = Nothing
        Dim lines As Integer = 0
        While (proc.StandardOutput.EndOfStream = False)
            line = proc.StandardOutput.ReadLine
            Dummy2.AppendText(line)
        End While

        proc.Close()
        proc.Dispose()

        txt_apkpath.Text = ""
        txt_apkpath.Text = Dummy2.Text.Substring(8)
        btn_apk_pull.Enabled = True
    End Sub

    Private Sub txt_PushPath_TextChanged(sender As Object, e As EventArgs) Handles txt_PushPath.TextChanged
        If txt_PushPath.Text = Nothing Or txt_PushSDPath.Text = Nothing Then
            Button1.Enabled = False
        Else
            Button1.Enabled = True
        End If
    End Sub

    Private Sub txt_PushSDPath_TextChanged(sender As Object, e As EventArgs) Handles txt_PushSDPath.TextChanged
        If txt_PushPath.Text = Nothing Or txt_PushSDPath.Text = Nothing Then
            Button1.Enabled = False
        Else
            Button1.Enabled = True
        End If
    End Sub

    Private Sub btn_PushBrowse_Click(sender As Object, e As EventArgs) Handles btn_PushBrowse.Click
        If RadioButton1.Checked = True Then
            Dim op As OpenFileDialog = New OpenFileDialog

            Dim FileName As String

            op.Title = "Browse File"
            op.Filter = "All Files (*.*)|*.*"
            op.InitialDirectory = My.Computer.FileSystem.SpecialDirectories.MyDocuments
            op.RestoreDirectory = True

            If op.ShowDialog = DialogResult.OK Then
                FileName = Path.GetFullPath(op.FileName)
                txt_PushPath.Text = FileName
            Else
                Exit Sub
            End If
        End If
        If RadioButton2.Checked = True Then
            Dim fd As FolderBrowserDialog = New FolderBrowserDialog
            Dim Fname As String

            fd.ShowNewFolderButton = True

            If fd.ShowDialog = Windows.Forms.DialogResult.OK Then
                Fname = fd.SelectedPath
                txt_PushPath.Text = Fname & "\" & txtx_PullFileName.Text
            Else
                Exit Sub
            End If
        End If
        If RadioButton1.Checked And RadioButton2.Checked = False Then
            MsgBox("Please select a Pull or Push Category")
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If RadioButton1.Checked = True Then
            If droid.lbl_DevInfo.Text = "No Device Detected" Then
                MsgBox("Please connect your device", MsgBoxStyle.Information, "Error")
                Exit Sub
            End If

            If txt_PushPath.Text = "" And txt_PushSDPath.Text = "" Then
                MessageBox.Show("Path cannot be empty", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            Else
                txt_Logs.AppendText(lbl_time.Text.ToString & "Pushing [" & txt_PushPath.Text & "]..." & vbNewLine)
                Call New Action(AddressOf Push).BeginInvoke(Nothing, Nothing)
            End If
        End If
        If RadioButton2.Checked = True Then
            If droid.lbl_DevInfo.Text = "No Device Detected" Then
                MsgBox("Please connect your device", MsgBoxStyle.Information, "Error")
                Exit Sub
            End If

            If txt_PushPath.Text = "" Or txt_PushSDPath.Text = "" Or txtx_PullFileName.Text = "" Then
                MessageBox.Show("Path/File Name cannot be empty", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            Else
                txt_Logs.AppendText(lbl_time.Text.ToString & "Pulling [" & txtx_PullFileName.Text & "] ..." & vbNewLine)
                Call New Action(AddressOf Pull).BeginInvoke(Nothing, Nothing)
            End If
        End If
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        lbl_time.Text = "[...." & Date.Now.ToLongTimeString & "....] "
    End Sub

    Private Sub txt_PushSDPath_MouseHover(sender As Object, e As EventArgs) Handles txt_PushSDPath.MouseHover
        txt_PushSDPath.Text.Trim()
    End Sub

    Private Sub txtx_PullFileName_MouseHover(sender As Object, e As EventArgs) Handles txtx_PullFileName.MouseHover
    End Sub

    Private Sub txtx_PullFileName_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtx_PullFileName.TextChanged
        If txt_PushPath.Text = Nothing Or txt_PushSDPath.Text = Nothing Or txtx_PullFileName.Text = Nothing And RadioButton2.Checked = True Then
            Button1.Enabled = False
        Else
            Button1.Enabled = True
        End If
    End Sub

    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton1.CheckedChanged
        If RadioButton1.Checked = True Then
            txtx_PullFileName.Enabled = False
            Label1.Text = "Select File:"
            Label2.Text = "Push To Android"

        ElseIf RadioButton1.Checked = False Then
            Label1.Text = "Save To:"
            Label2.Text = "Pull From Android"
            txtx_PullFileName.Enabled = True
        End If
    End Sub

    Private Sub RadioButton2_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton2.CheckedChanged

        If RadioButton2.Checked = True Then
            Label1.Text = "Save To:"
            Label2.Text = "Pull From Android"
            txtx_PullFileName.Enabled = True
        ElseIf RadioButton2.Checked = False Then
            txtx_PullFileName.Enabled = False
            Label1.Text = "Select File:"
            Label2.Text = "Push To Android"
        End If
    End Sub

    Private Sub btn_apk_pull_Click(sender As Object, e As EventArgs) Handles btn_apk_pull.Click

        If droid.lbl_DevInfo.Text = "No Device Detected" Then
            MsgBox("Please connect your device", MsgBoxStyle.Information, "Error")
            Exit Sub
        End If

        If cobo_apklist.SelectedIndex = -1 And txt_apkpath.Text = "" Then
            MsgBox("Please select the Apk from List")
            Exit Sub
        Else
            txt_Logs.AppendText(lbl_time.Text.ToString & "Pulling [" & cobo_apklist.SelectedItem.ToString & "]..." & vbNewLine)
            Call New Action(AddressOf ApkPull).BeginInvoke(Nothing, Nothing)
            Me.Enabled = False
        End If
    End Sub

    Private Sub cobo_apklist_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cobo_apklist.SelectedIndexChanged
        If cobo_apklist.SelectedIndex = -1 Then
            txt_apkpath.Text = ""
            Exit Sub
        End If
        Call New Action(AddressOf GetApkDir).BeginInvoke(Nothing, Nothing)
    End Sub

    Private Sub btn_DeviceList_Click(sender As Object, e As EventArgs) Handles btn_DeviceList.Click
        Call New Action(AddressOf DeviceList).BeginInvoke(Nothing, Nothing)
    End Sub

    Private Sub txt_Logs_TextChanged(sender As Object, e As EventArgs) Handles txt_Logs.TextChanged

    End Sub

    Private Sub btn_ShellConsole_Click(sender As Object, e As EventArgs) Handles btn_ShellConsole.Click
        txt_Logs.AppendText(lbl_time.Text.ToString & "Shell Started" & vbNewLine)
        Shell("adb.exe shell", AppWinStyle.NormalFocus, False, )
    End Sub

    Private Sub btn_GetSerialNumber_Click(sender As Object, e As EventArgs) Handles btn_GetSerialNumber.Click
        Call New Action(AddressOf GetSerialNumber).BeginInvoke(Nothing, Nothing)
    End Sub

    Private Sub btn_ClearLogs_Click(sender As Object, e As EventArgs) Handles btn_ClearLogs.Click
        txt_Logs.Text = ""
    End Sub

    Private Sub cb_RebootOptions_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cb_RebootOptions.SelectedIndexChanged
        If cb_RebootOptions.SelectedIndex = -1 Then
            btn_Reboot.Enabled = False
        Else
            btn_Reboot.Enabled = True
        End If
    End Sub

    Private Sub btn_Reboot_Click(sender As Object, e As EventArgs) Handles btn_Reboot.Click
        If cb_RebootOptions.SelectedIndex = 0 Then
            txt_Logs.AppendText(lbl_time.Text.ToString & "Rebooting Device " + "[" + droid.lbl_DevInfo.Text + "]..." & vbNewLine)
            txt_Logs.ScrollToCaret()
            Call New Action(AddressOf Reboot).BeginInvoke(Nothing, Nothing)
        ElseIf cb_RebootOptions.SelectedIndex = 1 Then
            txt_Logs.AppendText(lbl_time.Text.ToString & "Rebooting Device to Recovery " + "[" + droid.lbl_DevInfo.Text + "]..." & vbNewLine)
            txt_Logs.ScrollToCaret()
            Call New Action(AddressOf RebootRecovery).BeginInvoke(Nothing, Nothing)
        ElseIf cb_RebootOptions.SelectedIndex = 2 Then
            txt_Logs.AppendText(lbl_time.Text.ToString & "Rebooting Device to Bootloader " + "[" + droid.lbl_DevInfo.Text + "]..." & vbNewLine)
            txt_Logs.ScrollToCaret()
            Call New Action(AddressOf RebootBL).BeginInvoke(Nothing, Nothing)
        End If

        btn_Reboot.Enabled = False
        cb_RebootOptions.SelectedIndex = -1
    End Sub

    Private Sub btn_Sideload_Click(sender As Object, e As EventArgs) Handles btn_Sideload.Click

        Dim op As OpenFileDialog = New OpenFileDialog
        Dim strName As String

        op.Title = "Choose your backup file to Restore"
        op.InitialDirectory = My.Computer.FileSystem.SpecialDirectories.MyDocuments.ToString
        op.Filter = "Update ZIP (*.zip)|*.zip"
        op.RestoreDirectory = True

        If op.ShowDialog = DialogResult.OK Then
            strName = Path.GetFullPath(op.FileName)
            txt_SideloadPath.Text = strName
        Else
            Exit Sub
        End If

        Dim result As DialogResult = MessageBox.Show("Are you sure want to update update?", Me.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If result = Windows.Forms.DialogResult.OK Then
            If cb_SideLoad.Checked = True Then
                txt_Logs.AppendText(lbl_time.Text.ToString & "Flashing [" & txt_SideloadPath.Text & "]..." & vbNewLine)
                Call New Action(AddressOf ADBSideloadM).BeginInvoke(Nothing, Nothing)
            Else
                txt_Logs.AppendText(lbl_time.Text.ToString & "Rebooting to Recovery..." & vbNewLine)
                Call New Action(AddressOf RebootRecovery).BeginInvoke(Nothing, Nothing)
                txt_Logs.AppendText(lbl_time.Text.ToString & "Please Select Apply ADB Update on Your Phone" & vbNewLine)
                txt_Logs.AppendText(lbl_time.Text.ToString & "By Pressing Up and Down Volume button, To select Press Power." & vbNewLine)
                Call New Action(AddressOf ADBSideload).BeginInvoke(Nothing, Nothing)
            End If
        Else
            Exit Sub
        End If
    End Sub

    Private Sub btn_ExecuteADB_Click(sender As Object, e As EventArgs) Handles btn_ExecuteADB.Click
        Call New Action(AddressOf ExecuteCommand).BeginInvoke(Nothing, Nothing)
    End Sub
End Class
