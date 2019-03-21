Imports System.IO
Public Class FastBoot

    Dim db As ADB

    Public Sub ADBComm(ByVal Arg As String)
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

    Sub FastbootFlashRec()
        Dim cmdInput As String = "flash recovery """ & txt_fl_rec.Text & """"
        Dim proc As New Process

        proc.StartInfo.CreateNoWindow = True
        proc.StartInfo.UseShellExecute = False
        proc.StartInfo.FileName = "fastboot.exe"
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
            db.txt_Logs.AppendText(line & vbNewLine)
            lines = lines + 1
        End While

        proc.Close()
        proc.Dispose()
    End Sub

    Sub FastbootFlashBoot()
        Dim cmdInput As String = "flash boot """ & txt_fl_boot.Text & """"
        Dim proc As New Process

        proc.StartInfo.CreateNoWindow = True
        proc.StartInfo.UseShellExecute = False
        proc.StartInfo.FileName = "fastboot.exe"
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
            db.txt_Logs.AppendText(line & vbNewLine)
            lines = lines + 1
        End While

        proc.WaitForExit()
        proc.Close()
        proc.Dispose()
    End Sub

    'Fastboot Flash System function
    Sub FastbootFlashSys()
        Dim cmdInput As String = "flash system """ & txt_fl_sys.Text & """"
        Dim proc As New Process

        proc.StartInfo.CreateNoWindow = True
        proc.StartInfo.UseShellExecute = False
        proc.StartInfo.FileName = "fastboot.exe"
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
            db.txt_Logs.AppendText(line & vbNewLine)
            lines = lines + 1
        End While

        proc.WaitForExit()
        proc.Close()
        proc.Dispose()
    End Sub

    'Fastboot Flash Data function
    Sub FastbootFlashData()
        Dim cmdInput As String = "flash data """ & txt_fl_data.Text & """"
        Dim proc As New Process

        proc.StartInfo.CreateNoWindow = True
        proc.StartInfo.UseShellExecute = False
        proc.StartInfo.FileName = "fastboot.exe"
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
            db.txt_Logs.AppendText(line & vbNewLine)
            lines = lines + 1
        End While

        proc.WaitForExit()
        proc.Close()
        proc.Dispose()
    End Sub

    'Fastboot Flash Cache function
    Sub FastbootFlashCache()
        Dim cmdInput As String = "flash cache """ & txt_fl_cache.Text & """"
        Dim proc As New Process

        proc.StartInfo.CreateNoWindow = True
        proc.StartInfo.UseShellExecute = False
        proc.StartInfo.FileName = "fastboot.exe"
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
            db.txt_Logs.AppendText(line & vbNewLine)
            lines = lines + 1
        End While

        proc.WaitForExit()
        proc.Close()
        proc.Dispose()
    End Sub

    Public Sub RebootBL()

        ADBComm("reboot-bootloader")

        System.Threading.Thread.Sleep(5000)
        db.txt_Logs.AppendText(db.lbl_time.Text.ToString & "Device Rebooted to Bootloader" & vbNewLine)
        db.txt_Logs.ScrollToCaret()
    End Sub

    Sub FastbootFlash()
        db.txt_Logs.AppendText("Rebooting to Bootloader..." & vbNewLine)
        RebootBL()
        db.txt_Logs.AppendText("Flashing..." & vbNewLine)
        If cb_fl_rec.CheckState = CheckState.Checked Then
            FastbootFlashRec()
        End If
        If cb_fl_boot.CheckState = CheckState.Checked Then
            FastbootFlashBoot()
        End If
        If cb_fl_sys.CheckState = CheckState.Checked Then
            FastbootFlashSys()
        End If
        If cb_fl_data.CheckState = CheckState.Checked Then
            FastbootFlashData()
        End If
        If cb_fl_cache.CheckState = CheckState.Checked Then
            FastbootFlashCache()
        End If
    End Sub

    Sub FastbootManual()
        Dim cmdInput As String = txt_manualfastboot.Text
        Dim proc As New Process

        proc.StartInfo.CreateNoWindow = True
        proc.StartInfo.UseShellExecute = False
        proc.StartInfo.FileName = "fastboot.exe"
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
            db.txt_Logs.AppendText(line & vbNewLine)
            lines = lines + 1
        End While

        proc.Close()
        proc.Dispose()
    End Sub

    Private Sub cb_fl_rec_CheckedChanged(sender As Object, e As EventArgs) Handles cb_fl_rec.CheckedChanged
        Dim op As OpenFileDialog = New OpenFileDialog
        Dim strName As String

        op.Title = "Choose your recovery image"
        op.InitialDirectory = My.Computer.FileSystem.SpecialDirectories.MyDocuments.ToString
        op.Filter = "Image File (*.img)|*.img"
        op.RestoreDirectory = True

        If cb_fl_rec.CheckState = CheckState.Checked Then
            If op.ShowDialog = DialogResult.OK Then
                strName = Path.GetFullPath(op.FileName)
                txt_fl_rec.Text = strName
            Else
                cb_fl_rec.Checked = False
                Exit Sub
            End If
        ElseIf cb_fl_rec.CheckState = CheckState.Unchecked Then
            txt_fl_rec.Text = Nothing
            Exit Sub
        End If
    End Sub

    Private Sub cb_fl_boot_CheckedChanged(sender As Object, e As EventArgs) Handles cb_fl_boot.CheckedChanged
        Dim op As OpenFileDialog = New OpenFileDialog
        Dim strName As String

        op.Title = "Choose your boot image"
        op.InitialDirectory = My.Computer.FileSystem.SpecialDirectories.MyDocuments.ToString
        op.Filter = "Image File (*.img)|*.img"
        op.RestoreDirectory = True

        If cb_fl_boot.CheckState = CheckState.Checked Then
            If op.ShowDialog = DialogResult.OK Then
                strName = Path.GetFullPath(op.FileName)
                txt_fl_boot.Text = strName
            Else
                cb_fl_boot.Checked = False
                Exit Sub
            End If
        ElseIf cb_fl_boot.CheckState = CheckState.Unchecked Then
            txt_fl_boot.Text = Nothing
            Exit Sub
        End If
    End Sub

    Private Sub cb_fl_sys_CheckedChanged(sender As Object, e As EventArgs) Handles cb_fl_sys.CheckedChanged
        Dim op As OpenFileDialog = New OpenFileDialog
        Dim strName As String

        op.Title = "Choose your system image"
        op.InitialDirectory = My.Computer.FileSystem.SpecialDirectories.MyDocuments.ToString
        op.Filter = "Image File (*.img)|*.img"
        op.RestoreDirectory = True

        If cb_fl_sys.CheckState = CheckState.Checked Then
            If op.ShowDialog = DialogResult.OK Then
                strName = Path.GetFullPath(op.FileName)
                txt_fl_sys.Text = strName
            Else
                cb_fl_sys.Checked = False
                Exit Sub
            End If
        ElseIf cb_fl_sys.CheckState = CheckState.Unchecked Then
            txt_fl_sys.Text = Nothing
            Exit Sub
        End If
    End Sub

    Private Sub cb_fl_data_CheckedChanged(sender As Object, e As EventArgs) Handles cb_fl_data.CheckedChanged
        Dim op As OpenFileDialog = New OpenFileDialog
        Dim strName As String

        op.Title = "Choose your data image"
        op.InitialDirectory = My.Computer.FileSystem.SpecialDirectories.MyDocuments.ToString
        op.Filter = "Image File (*.img)|*.img"
        op.RestoreDirectory = True

        If cb_fl_data.CheckState = CheckState.Checked Then
            If op.ShowDialog = DialogResult.OK Then
                strName = Path.GetFullPath(op.FileName)
                txt_fl_data.Text = strName
            Else
                cb_fl_data.Checked = False
                Exit Sub
            End If
        ElseIf cb_fl_data.CheckState = CheckState.Unchecked Then
            txt_fl_data.Text = Nothing
            Exit Sub
        End If
    End Sub

    Private Sub cb_fl_cache_CheckedChanged(sender As Object, e As EventArgs) Handles cb_fl_cache.CheckedChanged
        Dim op As OpenFileDialog = New OpenFileDialog
        Dim strName As String

        op.Title = "Choose your cache image"
        op.InitialDirectory = My.Computer.FileSystem.SpecialDirectories.MyDocuments.ToString
        op.Filter = "Image File (*.img)|*.img"
        op.RestoreDirectory = True

        If cb_fl_cache.CheckState = CheckState.Checked Then
            If op.ShowDialog = DialogResult.OK Then
                strName = Path.GetFullPath(op.FileName)
                txt_fl_cache.Text = strName
            Else
                cb_fl_cache.Checked = False
                Exit Sub
            End If
        ElseIf cb_fl_cache.CheckState = CheckState.Unchecked Then
            txt_fl_cache.Text = Nothing
            Exit Sub
        End If
    End Sub

    Private Sub btn_flash_Click(sender As Object, e As EventArgs) Handles btn_flash.Click
        Dim result As DialogResult = MessageBox.Show("Are you sure want to flash all these files?", Me.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If result = Windows.Forms.DialogResult.OK Then
            btn_flash.Enabled = False
            Call New Action(AddressOf FastbootFlash).BeginInvoke(Nothing, Nothing)
        Else
            Exit Sub
        End If
    End Sub

    Private Sub btn_manualfastboot_Click(sender As Object, e As EventArgs) Handles btn_manualfastboot.Click
        If txt_manualfastboot.Text = Nothing Then
            MsgBox("Please input your commands", MsgBoxStyle.Exclamation)
        Else
            Call New Action(AddressOf FastbootManual).BeginInvoke(Nothing, Nothing)
        End If
    End Sub

    Private Sub btn_flash_GotFocus(sender As Object, e As EventArgs) Handles btn_flash.GotFocus
        btn_flash.FlatAppearance.Equals(ButtonBorderStyle.Dashed)
    End Sub
End Class
