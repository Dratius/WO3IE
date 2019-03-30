Imports System.Text.RegularExpressions
Imports System.IO
Public Class Settings
    Dim db As ADB
    Dim inter As Interference
    Dim adv As Advanced

    Public Shared myDoc = My.Computer.FileSystem.SpecialDirectories.MyDocuments & "\WOX3IE\"

    Public Sub ConnectWiFi()

        Dim cmdInput As String = "connect " & txt_ipaddr.Text & ":" & txt_tcpip.Text
        Dim proc As New Process

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
        While (proc.StandardOutput.EndOfStream = False)
            line = proc.StandardOutput.ReadLine
            If line.Contains("unable to connect to " & txt_ipaddr.Text & ":" & txt_tcpip.Text) Then
                db.txt_Logs.AppendText(line & vbNewLine)
                db.txt_Logs.AppendText(db.lbl_time.Text.ToString & "Please check your IP Address or Port Number" & vbNewLine)
            Else
                btn_connectwifi.Text = "Disconnect"
                txt_ipaddr.Enabled = False
                txt_tcpip.Enabled = False
                db.txt_Logs.AppendText(line & vbNewLine)
                db.txt_Logs.AppendText(db.lbl_time.Text.ToString & "Please unplug the USB Cabble to continue" & vbNewLine)
            End If
        End While

        proc.Close()
        proc.Dispose()
    End Sub

    Public Sub DisconnectWiFi()

        Dim cmdInput As String = "disconnect " & txt_ipaddr.Text & ":" & txt_tcpip.Text
        Dim proc As New Process

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

        proc.Close()
        proc.Dispose()
    End Sub

    Public Sub ADBRestartUSB()
        inter.ADBComm("usb")
    End Sub

    Sub CheckDir()
        If My.Computer.FileSystem.DirectoryExists(myDoc & "projects\" & adv.list_apkt.SelectedItem.ToString) Then
            Shell("cmd.exe /c rmdir /S /Q """ & myDoc & "projects\" & adv.list_apkt.SelectedItem.ToString & """")
        Else
            Exit Sub
        End If
    End Sub

    Sub Cleardir1()

        My.Computer.FileSystem.DeleteDirectory(myDoc & "apk-dir", FileIO.DeleteDirectoryOption.DeleteAllContents)
        My.Computer.FileSystem.CreateDirectory(myDoc & "apk-dir")
        db.txt_Logs.AppendText(db.lbl_time.Text.ToString & "All files in /apk-dir/ folder has been cleared..." & vbNewLine)
        cobo_apkt_clrfolder.SelectedIndex = -1
        cobo_apkt_clrfolder.Enabled = True
        adv.PopulateApkDir()
    End Sub

    Sub Cleardir2()

        My.Computer.FileSystem.DeleteDirectory(myDoc & "apk-sign", FileIO.DeleteDirectoryOption.DeleteAllContents)
        My.Computer.FileSystem.CreateDirectory(myDoc & "apk-sign")
        db.txt_Logs.AppendText(db.lbl_time.Text.ToString & "All files in /apk-sign/ folder has been cleared..." & vbNewLine)
        cobo_apkt_clrfolder.SelectedIndex = -1
        cobo_apkt_clrfolder.Enabled = True
        adv.PopulateApkDir()
    End Sub

    Sub Cleardir3()

        My.Computer.FileSystem.DeleteDirectory(myDoc & "projects", FileIO.DeleteDirectoryOption.DeleteAllContents)
        My.Computer.FileSystem.CreateDirectory(myDoc & "projects")
        db.txt_Logs.AppendText(db.lbl_time.Text.ToString & "All files in /projects/ folder has been cleared..." & vbNewLine)
        cobo_apkt_clrfolder.SelectedIndex = -1
        cobo_apkt_clrfolder.Enabled = True
        adv.PopulateApkDir()
    End Sub

    Sub DeleteProjectFolder()

        Dim mycom = My.Computer.FileSystem

        adv.ApktControlDisable()

        CheckDir()
        If mycom.FileExists(myDoc & "apk-sign\signed" & adv.list_apkt.SelectedItem) Then
            File.Delete(myDoc & "apk-sign\signed" & adv.list_apkt.SelectedItem)
        End If
        If mycom.FileExists(myDoc & "apk-sign\unsigned" & adv.list_apkt.SelectedItem) Then
            File.Delete(myDoc & "apk-sign\unsigned" & adv.list_apkt.SelectedItem)
        End If
        adv.PopulateApkDir()
        db.txt_Logs.AppendText(db.lbl_time.Text.ToString & "Project Folder Deleted..." & vbNewLine)
    End Sub

    Sub DeleteAllApkAndProject()

        Dim mycom = My.Computer.FileSystem

        adv.ApktControlDisable()

        CheckDir()
        If mycom.FileExists(myDoc & "apk-sign\signed" & adv.list_apkt.SelectedItem) Then
            File.Delete(myDoc & "apk-sign\signed" & adv.list_apkt.SelectedItem)
        End If
        If mycom.FileExists(myDoc & "apk-sign\unsigned" & adv.list_apkt.SelectedItem) Then
            File.Delete(myDoc & "apk-sign\unsigned" & adv.list_apkt.SelectedItem)
        End If
        File.Delete(myDoc & "apk-dir\" & adv.list_apkt.SelectedItem)
        adv.PopulateApkDir()
        db.txt_Logs.AppendText(db.lbl_time.Text.ToString & "All Deleted..." & vbNewLine)
    End Sub

    Private Sub btn_connectwifi_Click(sender As Object, e As EventArgs) Handles btn_connectwifi.Click
        Select Case btn_connectwifi.Text
            Case "Connect"
                inter.ADBComm("tcpip " & txt_tcpip.Text)
                If txt_ipaddr.Text = "" Or txt_tcpip.Text = "" Then
                    MessageBox.Show("Please fill the empty Textbox", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    Exit Sub
                Else
                    Call New Action(AddressOf ConnectWiFi).BeginInvoke(Nothing, Nothing)
                End If
            Case "Disconnect"
                inter.Timer1.Stop()
                Call New Action(AddressOf DisconnectWiFi).BeginInvoke(Nothing, Nothing)
                db.txt_Logs.AppendText(db.lbl_time.Text.ToString & "Disconnected from " & txt_ipaddr.Text & ":" & txt_tcpip.Text & vbNewLine)
                Call New Action(AddressOf ADBRestartUSB).BeginInvoke(Nothing, Nothing)
                inter.list_APK.Items.Clear()
                db.txt_Logs.AppendText(db.lbl_time.Text.ToString & "ADB restarted listening to USB" & vbNewLine)
                btn_connectwifi.Text = "Connect"
                txt_ipaddr.Enabled = True
                txt_tcpip.Enabled = True
        End Select

    End Sub

    Private Sub btn_adbTCPIP_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_adbTCPIP.Click

        inter.ADBComm("tcpip " & txt_tcport.Text)
        db.txt_Logs.AppendText(db.lbl_time.Text.ToString & "ADB restarted listening via TCPIP" & vbNewLine)
    End Sub

    Private Sub btn_adbUSB_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_adbUSB.Click

        inter.ADBComm("usb")
        db.txt_Logs.AppendText(db.lbl_time.Text.ToString & "ADB restarted listening via USB" & vbNewLine)
    End Sub

    Private Sub btn_adbRoot_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_adbRoot.Click

        inter.ADBComm("root")
        db.txt_Logs.AppendText(db.lbl_time.Text.ToString & "ADB restarted listening with Root Permisions" & vbNewLine)
    End Sub

    Private Sub btn_AdbUnroot_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_AdbUnroot.Click

        inter.ADBComm("unroot")
        db.txt_Logs.AppendText(db.lbl_time.Text.ToString & "ADB restarted listening with Normal Permissions" & vbNewLine)
    End Sub

    Private Sub txt_apkt_heapsz_TextChanged(sender As Object, e As EventArgs) Handles txt_apkt_heapsz.TextChanged
        Dim digitsOnly As Regex = New Regex("[^\d]")
        txt_apkt_heapsz.Text = digitsOnly.Replace(txt_apkt_heapsz.Text, "")
    End Sub

    Private Sub cobo_apkt_clrfolder_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cobo_apkt_clrfolder.SelectedIndexChanged
        If cobo_apkt_clrfolder.SelectedIndex = -1 Then
            btn_apkt_clearfolder.Enabled = False
        Else
            btn_apkt_clearfolder.Enabled = True
        End If
    End Sub

    Private Sub btn_apkt_clearfolder_Click(sender As Object, e As EventArgs) Handles btn_apkt_clearfolder.Click
        btn_apkt_clearfolder.Enabled = False
        Select Case cobo_apkt_clrfolder.SelectedIndex
            Case 0
                db.txt_Logs.AppendText(db.lbl_time.Text.ToString & "Clearing /apk-dir/ folder..." & vbNewLine)
                cobo_apkt_clrfolder.Enabled = False
                Call New Action(AddressOf Cleardir1).BeginInvoke(Nothing, Nothing)
            Case 1
                db.txt_Logs.AppendText(db.lbl_time.Text.ToString & "Clearing /apk-sign/ folder..." & vbNewLine)
                cobo_apkt_clrfolder.Enabled = False
                Call New Action(AddressOf Cleardir2).BeginInvoke(Nothing, Nothing)
            Case 2
                db.txt_Logs.AppendText(db.lbl_time.Text.ToString & "Clearing /projects/ folder..." & vbNewLine)
                cobo_apkt_clrfolder.Enabled = False
                Call New Action(AddressOf Cleardir3).BeginInvoke(Nothing, Nothing)
        End Select
    End Sub

    Private Sub cobo_apkt_opendir_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cobo_apkt_opendir.SelectedIndexChanged
        If cobo_apkt_opendir.SelectedIndex = -1 Then
            btn_apkt_opendir.Enabled = False
        Else
            btn_apkt_opendir.Enabled = True
        End If
    End Sub

    Private Sub btn_apkt_opendir_Click(sender As Object, e As EventArgs) Handles btn_apkt_opendir.Click
        Select Case cobo_apkt_opendir.SelectedIndex
            Case 0
                Process.Start(myDoc & "apk-dir\")
                cobo_apkt_opendir.SelectedIndex = -1
            Case 1
                Process.Start(myDoc & "apk-sign\")
                cobo_apkt_opendir.SelectedIndex = -1
            Case 2
                Process.Start(myDoc & "projects\")
                cobo_apkt_opendir.SelectedIndex = -1
        End Select
    End Sub
End Class