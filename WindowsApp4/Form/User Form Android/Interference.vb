Imports System.IO
Public Class Interference

    Dim db As ADB
    Dim fst As FastBoot
    Public Shared txt_Path As Object = New TextBox

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

    'Fungsi adb untuk melakukan Backup Aplikasi Terpilih
    Private Sub BackupSelectedAPK()
        Dim ssl = list_APK.SelectedItem.ToString

        If list_APK.SelectedIndex = -1 Then
            MsgBox("Please selected App first to backup")
            Exit Sub
        End If

        ADBComm("backup -f " & """" & txt_Path.Text & """" & " -apk " & """" & ssl & """")

        db.txt_Logs.AppendText(lbl_time.Text.ToString & "[" & ssl & "] Successfully Backup" & vbNewLine)
        db.txt_Logs.ScrollToCaret()
        txt_Path.Text = ""
        list_APK.SelectedIndex = -1
    End Sub

    'Fungsi adb untuk melakukan Backup semua Aplikasi
    Private Sub BackupAllAPK()
        Dim ssl = list_APK.SelectedItem.ToString
        If txt_Path.Text = "" Then
            MsgBox("Please choose path to backup")
            Exit Sub
        End If

        db.txt_Logs.AppendText("Backup [ ALL USER APK ] Please wait..." & vbNewLine)
        ADBComm("backup -f " & """" & txt_Path.Text & """" & " -all -apk -nosystem")

        db.txt_Logs.AppendText(lbl_time.Text.ToString & "[All User Apk] Successfully Backup" & vbNewLine)
        db.txt_Logs.ScrollToCaret()
        txt_Path.Text = ""
        list_APK.SelectedIndex = -1
        'db.Enabled = True
    End Sub

    'Fungsi adb untuk melakukan Backup semua Aplikasi + System Aplikasi
    Private Sub BackupAllAPKSystem()
        If txt_Path.Text = "" Then
            MsgBox("Please choose path to backup")
            Exit Sub
        End If

        ADBComm("backup -f " & """" & txt_Path.Text & """" & " -all -apk -system")

        db.txt_Logs.AppendText(lbl_time.Text.ToString & "[All User + system Apk] Successfully Backup" & vbNewLine)
        db.txt_Logs.ScrollToCaret()
        txt_Path.Text = ""
        list_APK.SelectedIndex = -1
    End Sub

    Public Sub PackagesList()
        list_APK.BeginUpdate()
        Dim a As Control

        list_APK.Enabled = False
        list_APK.Items.Clear()
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

        'Mengisi Value ke dalam listbox
        Dim line As String = Nothing
        Dim lines As Integer = 0
        While (proc.StandardOutput.EndOfStream = False)
            line = proc.StandardOutput.ReadLine
            list_APK.Items.Add(line)
            lines = lines + 1
        End While

        proc.Close()
        proc.Dispose()

        'Mengahpus seluruh String kosong yang terdapat dalam listbox
        Dim i As Integer
        Do While (list_APK.Items.Count) - 1 >= i
            If String.IsNullOrEmpty(list_APK.Items(i)) Then
                list_APK.Items.Remove(list_APK.Items(i))
                i -= 1
            End If
            i += 1
        Loop

        'Remove package: string from listbox
        'ADB Output is package:com.my.app
        For f As Integer = 0 To list_APK.Items.Count - 1
            list_APK.Items(f) = list_APK.Items(f).ToString.Substring(8)
        Next


        For Each a In gb_APKOptions.Controls
            If TypeOf a Is Button Then
                a.Enabled = True
            End If
        Next

        list_APK.Enabled = True
        list_APK.EndUpdate()
    End Sub

    Public Sub PackagesListSystem()
        list_APK.BeginUpdate()
        Dim a As Control

        For Each a In gb_APKOptions.Controls
            If TypeOf a Is Button Then
                a.Enabled = False
            End If
        Next

        list_APK.Enabled = False
        list_APK.Items.Clear()
        Dim cmdInput As String = "shell pm list packages -s"
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

        'Mengisi Value ke dalam listbox
        Dim line As String = Nothing
        Dim lines As Integer = 0
        While (proc.StandardOutput.EndOfStream = False)
            line = proc.StandardOutput.ReadLine
            list_APK.Items.Add(line)
            lines = lines + 1
        End While

        proc.Close()
        proc.Dispose()

        'Mengahpus seluruh String kosong yang terdapat dalam listbox
        Dim i As Integer
        Do While (list_APK.Items.Count) - 1 >= i
            If String.IsNullOrEmpty(list_APK.Items(i)) Then
                list_APK.Items.Remove(list_APK.Items(i))
                i -= 1
            End If
            i += 1
        Loop

        'Remove package: string from listbox
        'ADB Output is package:com.my.app
        For f As Integer = 0 To list_APK.Items.Count - 1
            list_APK.Items(f) = list_APK.Items(f).ToString.Substring(8)
        Next

        For Each a In gb_APKOptions.Controls
            If TypeOf a Is Button Then
                a.Enabled = True
            End If
        Next

        list_APK.Enabled = True
        list_APK.EndUpdate()
    End Sub

    'Get Applications list (User + System App) function
    Public Sub PackagesListAll()
        list_APK.BeginUpdate()
        Dim a As Control

        For Each a In gb_APKOptions.Controls
            If TypeOf a Is Button Then
                a.Enabled = False
            End If
        Next

        list_APK.Enabled = False
        list_APK.Items.Clear()
        Dim cmdInput As String = "shell pm list packages"
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

        'Mengisi Value ke dalam listbox
        Dim line As String = Nothing
        Dim lines As Integer = 0
        While (proc.StandardOutput.EndOfStream = False)
            line = proc.StandardOutput.ReadLine
            list_APK.Items.Add(line)
            lines = lines + 1
        End While

        proc.Close()
        proc.Dispose()

        'Mengahpus seluruh String kosong yang terdapat dalam listbox
        Dim i As Integer
        Do While (list_APK.Items.Count) - 1 >= i
            If String.IsNullOrEmpty(list_APK.Items(i)) Then
                list_APK.Items.Remove(list_APK.Items(i))
                i -= 1
            End If
            i += 1
        Loop

        'Remove package: string from listbox
        'ADB Output is package:com.my.app
        For f As Integer = 0 To list_APK.Items.Count - 1
            list_APK.Items(f) = list_APK.Items(f).ToString.Substring(8)
        Next

        For Each a In gb_APKOptions.Controls
            If TypeOf a Is Button Then
                a.Enabled = True
            End If
        Next

        list_APK.Enabled = True
        list_APK.EndUpdate()
    End Sub

    Public Sub InstallAPK()

        Call db.DisableAllControl()
        db.txt_Logs.AppendText(db.lbl_time.Text.ToString & "Installing [" & txt_Path.Text & "]..." & vbNewLine)
        fst.ADBComm("install " & """" & txt_Path.Text & """")

        db.txt_Logs.AppendText(db.lbl_time.Text.ToString & "[" & txt_Path.Text & "] Successfully Installed" & vbNewLine)
        db.txt_Logs.ScrollToCaret()
        Call db.EnableAllControl()
        txt_Path.Text = ""
    End Sub

    Public Sub UninstallAPK()

        Dim ssl = list_APK.SelectedItem.ToString
        Call db.DisableAllControl()

        db.txt_Logs.AppendText(db.lbl_time.Text.ToString & "Uninstalling [" & ssl & "]..." & vbNewLine)
        fst.ADBComm("uninstall " & ssl)

        db.txt_Logs.AppendText(db.lbl_time.Text.ToString & "[" & ssl & "] Successfully Uninstalled" & vbNewLine)
        db.txt_Logs.ScrollToCaret()

        Call db.EnableAllControl()
        Call New Action(AddressOf PackagesList).BeginInvoke(Nothing, Nothing)
    End Sub

    'Clear Application data function
    Public Sub ClearDataAPK()

        Dim ssl = list_APK.SelectedItem.ToString
        Call db.DisableAllControl()
        fst.ADBComm("shell pm clear " & ssl)

        db.txt_Logs.AppendText(db.lbl_time.Text.ToString & "Data and Cache Clear Successfully" & vbNewLine)
        db.txt_Logs.ScrollToCaret()

        Call db.EnableAllControl()
        Call New Action(AddressOf PackagesList).BeginInvoke(Nothing, Nothing)
    End Sub

    'Force closing Application function
    Public Sub ForceCloseAPK()

        Dim ssl = list_APK.SelectedItem.ToString
        Call db.DisableAllControl()
        fst.ADBComm("shell am force-stop " & ssl)

        db.txt_Logs.AppendText(db.lbl_time.Text.ToString & "[" & ssl & "] Proccess Ended" & vbNewLine)
        db.txt_Logs.ScrollToCaret()

        Call db.EnableAllControl()
        Call New Action(AddressOf PackagesList).BeginInvoke(Nothing, Nothing)
    End Sub

    'Start Application function
    Public Sub RunAPK()

        Dim ssl = list_APK.SelectedItem.ToString
        db.txt_Logs.AppendText(db.lbl_time.Text.ToString & "Starting [" & ssl & "]..." & vbNewLine)
        fst.ADBComm("shell monkey -p " & ssl & " -c android.intent.category.LAUNCHER 1")
        db.txt_Logs.AppendText(db.lbl_time.Text.ToString & "[" & ssl & "] Started" & vbNewLine)
        db.txt_Logs.ScrollToCaret()
    End Sub

    'Restore Application function
    Public Sub RestoreAPK()

        If txt_Path.Text = "" Then
            MsgBox("Please selected Restore File first to Restore")
            Exit Sub
        End If

        Call db.DisableAllControl()

        db.txt_Logs.AppendText(db.lbl_time.Text.ToString & "Please input your password then click Backup on Your Phone" & vbNewLine)
        fst.ADBComm("shell input keyevent 26")
        db.txt_Logs.AppendText(db.lbl_time.Text.ToString & "Restoring [" & txt_Path.Text & "]..." & vbNewLine)
        fst.ADBComm("restore " & """" & txt_Path.Text & """")

        db.txt_Logs.AppendText(db.lbl_time.Text.ToString & "[" & txt_Path.Text & "] Successfully Restore" & vbNewLine)
        db.txt_Logs.ScrollToCaret()
        Call db.EnableAllControl()
        txt_Path.Text = ""
        list_APK.SelectedIndex = -1
    End Sub

    Private Sub btn_InstallAPK_Click_1(sender As Object, e As EventArgs) Handles btn_InstallAPK.Click
        Dim fd As OpenFileDialog = New OpenFileDialog
        Dim strName As String

        fd.Title = "Choose APK To Install"
        fd.InitialDirectory = My.Computer.FileSystem.SpecialDirectories.MyDocuments.ToString
        fd.Filter = "Android Package (*.apk)|*.apk"
        fd.RestoreDirectory = True

        If fd.ShowDialog = DialogResult.OK Then
            strName = System.IO.Path.GetFullPath(fd.FileName)
            txt_Path.Text = strName
        Else
            Exit Sub
        End If
        Call New Action(AddressOf InstallAPK).BeginInvoke(Nothing, Nothing)
    End Sub

    Private Sub btn_UninstallAPK_Click(sender As Object, e As EventArgs) Handles btn_UninstallAPK.Click
        If list_APK.SelectedIndex = -1 Then
            MessageBox.Show("Please select App you want to Uninstall", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If

        btn_UninstallAPK.Enabled = False
        btn_RefreshListAPK.Enabled = False
        Call New Action(AddressOf UninstallAPK).BeginInvoke(Nothing, Nothing)
    End Sub

    Private Sub btn_RunAPK_Click(sender As Object, e As EventArgs) Handles btn_RunAPK.Click
        If list_APK.SelectedIndex = -1 Then
            MessageBox.Show("Please select the App you want to start", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If

        Call New Action(AddressOf RunAPK).BeginInvoke(Nothing, Nothing)
    End Sub

    Private Sub btn_ForceCloseAPK_Click(sender As Object, e As EventArgs) Handles btn_ForceCloseAPK.Click
        If list_APK.SelectedIndex = -1 Then
            MessageBox.Show("Please select App you want to close", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If

        Dim ssl = list_APK.SelectedItem.ToString

        btn_ForceCloseAPK.Enabled = False
        btn_RefreshListAPK.Enabled = False
        db.txt_Logs.AppendText(db.lbl_time.Text.ToString & "Killing " + "[" + ssl + "]..." & vbNewLine)
        db.txt_Logs.ScrollToCaret()
        Call New Action(AddressOf ForceCloseAPK).BeginInvoke(Nothing, Nothing)
    End Sub

    Private Sub btn_BackupAPK_Click(sender As Object, e As EventArgs) Handles btn_BackupAPK.Click
        Dim sd As SaveFileDialog = New SaveFileDialog
        Dim strName As String
        If rb_SelectedAppOnly.Checked = True Then

            sd.Title = "Choose Path To Backup Application"
            sd.InitialDirectory = My.Computer.FileSystem.SpecialDirectories.MyDocuments.ToString
            sd.Filter = "ADB Backup (*.ab)|*.ab"
            sd.RestoreDirectory = True

            If sd.ShowDialog = DialogResult.OK Then
                strName = Path.GetFullPath(sd.FileName)
                txt_Path.Text = strName
            Else
                Me.Enabled = True
                Exit Sub
            End If
            db.txt_Logs.AppendText(lbl_time.Text.ToString & "Backuping [" & list_APK.SelectedItem.ToString & "]..." & vbNewLine)
            Call New Action(AddressOf BackupSelectedAPK).BeginInvoke(Nothing, Nothing)
            MessageBox.Show("Please unlock your device then enter your password to encrypt backup or You can leave it blank then click Start Backup on Your Device", "App Backup", MessageBoxButtons.OK, MessageBoxIcon.Information)
        ElseIf rb_AllApp.Checked = True Then
            Me.Enabled = False
            Dim result As DialogResult = MessageBox.Show("Are you sure want to backup whole App?" & vbNewLine _
                                                         & "It's can take long time..", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If result = Windows.Forms.DialogResult.OK Then

                sd.Title = "Choose Path To Backup Application"
                sd.InitialDirectory = My.Computer.FileSystem.SpecialDirectories.MyDocuments.ToString
                sd.Filter = "ADB Backup (*.ab)|*.ab"
                sd.RestoreDirectory = True

                If sd.ShowDialog = DialogResult.OK Then
                    strName = Path.GetFullPath(sd.FileName)
                    txt_Path.Text = strName
                Else
                    Me.Enabled = True
                    Exit Sub
                End If
                db.txt_Logs.AppendText(lbl_time.Text.ToString & "Backuping [All User Apk]..." & vbNewLine)
                Call New Action(AddressOf BackupAllAPK).BeginInvoke(Nothing, Nothing)
                MessageBox.Show("Please unlock your device then enter your password to encrypt backup or You can leave it blank then click Start Backup on Your Device", "App Backup", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                Me.Enabled = True
                Exit Sub
            End If
        ElseIf rb_All.Checked = True Then
            Me.Enabled = False
            Dim result As DialogResult = MessageBox.Show("Are you sure want to backup whole App + System App?" & vbNewLine _
                                                         & "It's can take long time..", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If result = Windows.Forms.DialogResult.OK Then


                sd.Title = "Choose Path To Backup Application"
                sd.InitialDirectory = My.Computer.FileSystem.SpecialDirectories.MyDocuments.ToString
                sd.Filter = "ADB Backup (*.ab)|*.ab"
                sd.RestoreDirectory = True

                If sd.ShowDialog = DialogResult.OK Then

                    strName = Path.GetFullPath(sd.FileName)
                    txt_Path.Text = strName
                Else
                    Me.Enabled = True
                    Exit Sub
                End If
                db.txt_Logs.AppendText(lbl_time.Text.ToString & "Backuping [All User + System Apk]..." & vbNewLine)
                Call New Action(AddressOf BackupAllAPKSystem).BeginInvoke(Nothing, Nothing)
                MessageBox.Show("Please unlock your device then enter your password to encrypt backup or You can leave it blank then click Start Backup on Your Device", "App Backup", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                Me.Enabled = True
                Exit Sub
            End If

        End If
    End Sub

    Private Sub btn_RestoreAPK_Click(sender As Object, e As EventArgs) Handles btn_RestoreAPK.Click
        Dim op As OpenFileDialog = New OpenFileDialog
        Dim strName As String

        op.Title = "Choose your backup file to Restore"
        op.InitialDirectory = My.Computer.FileSystem.SpecialDirectories.MyDocuments.ToString
        op.Filter = "ADB Backup (*.ab)|*.ab"
        op.RestoreDirectory = True

        If op.ShowDialog = DialogResult.OK Then
            strName = Path.GetFullPath(op.FileName)
            txt_Path.Text = strName
        Else
            Exit Sub
        End If
        Call New Action(AddressOf RestoreAPK).BeginInvoke(Nothing, Nothing)
    End Sub

    Private Sub btn_ClearAPKData_Click(sender As Object, e As EventArgs) Handles btn_ClearAPKData.Click
        If list_APK.SelectedIndex = -1 Then
            MessageBox.Show("Please select App you want to Clear Data", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If

        Dim ssl = list_APK.SelectedItem.ToString

        btn_ClearAPKData.Enabled = False
        btn_RefreshListAPK.Enabled = False
        db.txt_Logs.AppendText(db.lbl_time.Text.ToString & "Clearing Data and Cache " + "[" + ssl + "]..." & vbNewLine)
        db.txt_Logs.ScrollToCaret()
        Call New Action(AddressOf ClearDataAPK).BeginInvoke(Nothing, Nothing)
    End Sub

    Private Sub btn_RefreshListAPK_Click(sender As Object, e As EventArgs) Handles btn_RefreshListAPK.Click
        Dim a As Control

        For Each a In gb_APKOptions.Controls
            If TypeOf a Is Button Then
                a.Enabled = False
            End If
        Next

        If rb_FilterAppUser.Checked = True Then
            Call New Action(AddressOf PackagesList).BeginInvoke(Nothing, Nothing)
        ElseIf rb_FilterSystemApp.Checked = True Then
            Call New Action(AddressOf PackagesListSystem).BeginInvoke(Nothing, Nothing)
        ElseIf rb_FilterAppAll.Checked = True Then
            Call New Action(AddressOf PackagesListAll).BeginInvoke(Nothing, Nothing)
        End If

        list_APK.SelectedIndex = -1
    End Sub

    Private Sub Interference_Load(sender As Object, e As EventArgs) Handles Me.Load
        Timer1.Start()
        CheckForIllegalCrossThreadCalls = False

        If list_APK.SelectedIndex = -1 Then
            rb_SelectedAppOnly.Enabled = False
            rb_AllApp.Checked = True
            rb_SelectedAppOnly.Checked = False
            rb_SelectedAppOnly.Text = "Selected App (App not selected)"
        End If
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        lbl_time.Text = "[" & System.DateTime.Now.ToLongTimeString & "] "
    End Sub
End Class
