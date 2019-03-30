Imports System.Text.RegularExpressions
Public Class More
    Dim db As ADB
    Dim inter As Interference

    Public Shared myDoc = My.Computer.FileSystem.SpecialDirectories.MyDocuments & "\WOX3IE\"

    Public Sub SwipeKey()

        Dim X1 As String = txt_SwipeX1.Text
        Dim X2 As String = txt_SwipeX2.Text
        Dim Y1 As String = txt_SwipeY1.Text
        Dim Y2 As String = txt_SwipeY2.Text
        Dim Time As String = txt_SwipeDuration.Text
        Dim s As String = " "
        db.txt_Logs.AppendText(db.lbl_time.Text.ToString & "Swiping Screen to " & X1 & s & Y1 & s & X2 & s & Y2 & s & Time & vbNewLine)
        inter.ADBComm("shell input swipe " & X1 & s & Y1 & s & X2 & s & Y2 & s & Time)
    End Sub

    Public Sub KeyInputTextEvent()

        inter.ADBComm("shell input text " & txt_InputKey.Text)
        inter.ADBComm("shell keyevent 4")
        txt_InputKey.Text = ""
        txt_InputKey.ReadOnly = False
    End Sub

    Public Sub PreferredNetwork()


        '11 (LTE) 1 (GSM) 12 (LTE/WCDMA) 9 (LTE+WCDMA/GSM) 0(WCDMA/GSM) 2 (WCDMA) 6 (EvDo Only) 5 (CDMA Only) 7 (Auto Mode) 8 (LTE+CDMA/EvDO)
        Dim netmode As String = "shell su -c settings put global preferred_network_mode "

        'Enabling Airplane Mode Commands
        'Enabling Airplane is a trick to change device preffered network without rebooting device
        Dim AirplaneA1 As String = "shell su -c settings put global airplane_mode_on 1"
        Dim AirplaneA2 As String = "shell su -c am broadcast -a android.intent.action.AIRPLANE_MODE --ez state true"

        'Disabling Airplane Mode Commands
        Dim AirplaneB1 As String = "shell su -c settings put global airplane_mode_on 0"
        Dim AirplaneB2 As String = "shell su -c am broadcast -a android.intent.action.AIRPLANE_MODE --ez state false"

        Dim s As String = "Changing Network Preferred to "
        Dim NetName As String = cb_prefnetwork.SelectedItem.ToString & "..." & vbNewLine
        Dim b As String = "Network Preferred Changed" & vbNewLine

        Select Case cb_prefnetwork.SelectedIndex
            Case 0
                db.txt_Logs.AppendText(db.lbl_time.Text.ToString & s & NetName)
                inter.ADBComm(netmode & "1")
                inter.ADBComm(AirplaneA1)
                inter.ADBComm(AirplaneA2)
                Threading.Thread.Sleep(2000)
                inter.ADBComm(AirplaneB1)
                inter.ADBComm(AirplaneB2)
                db.txt_Logs.AppendText(db.lbl_time.Text.ToString & b)
            Case 1
                db.txt_Logs.AppendText(db.lbl_time.Text.ToString & s & NetName)
                inter.ADBComm(netmode & "0")
                inter.ADBComm(AirplaneA1)
                inter.ADBComm(AirplaneA2)
                Threading.Thread.Sleep(2000)
                inter.ADBComm(AirplaneB1)
                inter.ADBComm(AirplaneB2)
                db.txt_Logs.AppendText(db.lbl_time.Text.ToString & b)
            Case 2
                db.txt_Logs.AppendText(db.lbl_time.Text.ToString & s & NetName)
                inter.ADBComm(netmode & "9")
                inter.ADBComm(AirplaneA1)
                inter.ADBComm(AirplaneA2)
                Threading.Thread.Sleep(2000)
                inter.ADBComm(AirplaneB1)
                inter.ADBComm(AirplaneB2)
                db.txt_Logs.AppendText(db.lbl_time.Text.ToString & b)
            Case 3
                db.txt_Logs.AppendText(db.lbl_time.Text.ToString & s & NetName)
                inter.ADBComm(netmode & "2")
                inter.ADBComm(AirplaneA1)
                inter.ADBComm(AirplaneA2)
                Threading.Thread.Sleep(2000)
                inter.ADBComm(AirplaneB1)
                inter.ADBComm(AirplaneB2)
                db.txt_Logs.AppendText(db.lbl_time.Text.ToString & b)
            Case 4
                db.txt_Logs.AppendText(db.lbl_time.Text.ToString & s & NetName)
                inter.ADBComm(netmode & "12")
                inter.ADBComm(AirplaneA1)
                inter.ADBComm(AirplaneA2)
                Threading.Thread.Sleep(2000)
                inter.ADBComm(AirplaneB1)
                inter.ADBComm(AirplaneB2)
                db.txt_Logs.AppendText(db.lbl_time.Text.ToString & b)
            Case 5
                db.txt_Logs.AppendText(db.lbl_time.Text.ToString & s & NetName)
                inter.ADBComm(netmode & "11")
                inter.ADBComm(AirplaneA1)
                inter.ADBComm(AirplaneA2)
                Threading.Thread.Sleep(2000)
                inter.ADBComm(AirplaneB1)
                inter.ADBComm(AirplaneB2)
                db.txt_Logs.AppendText(db.lbl_time.Text.ToString & b)
            Case 6
                db.txt_Logs.AppendText(db.lbl_time.Text.ToString & s & NetName)
                inter.ADBComm(netmode & "5")
                inter.ADBComm(AirplaneA1)
                inter.ADBComm(AirplaneA2)
                Threading.Thread.Sleep(2000)
                inter.ADBComm(AirplaneB1)
                inter.ADBComm(AirplaneB2)
                db.txt_Logs.AppendText(db.lbl_time.Text.ToString & b)
            Case 7
                db.txt_Logs.AppendText(db.lbl_time.Text.ToString & s & NetName)
                inter.ADBComm(netmode & "6")
                inter.ADBComm(AirplaneA1)
                inter.ADBComm(AirplaneA2)
                Threading.Thread.Sleep(2000)
                inter.ADBComm(AirplaneB1)
                inter.ADBComm(AirplaneB2)
                db.txt_Logs.AppendText(db.lbl_time.Text.ToString & b)
            Case 8
                db.txt_Logs.AppendText(db.lbl_time.Text.ToString & s & NetName)
                inter.ADBComm(netmode & "7")
                inter.ADBComm(AirplaneA1)
                inter.ADBComm(AirplaneA2)
                Threading.Thread.Sleep(2000)
                inter.ADBComm(AirplaneB1)
                inter.ADBComm(AirplaneB2)
                db.txt_Logs.AppendText(db.lbl_time.Text.ToString & b)
            Case 9
                db.txt_Logs.AppendText(s & NetName)
                inter.ADBComm(netmode & "8")
                inter.ADBComm(AirplaneA1)
                inter.ADBComm(AirplaneA2)
                Threading.Thread.Sleep(2000)
                inter.ADBComm(AirplaneB1)
                inter.ADBComm(AirplaneB2)
                db.txt_Logs.AppendText(db.lbl_time.Text.ToString & b)
        End Select

        db.txt_Logs.ScrollToCaret()
        btn_prefnetwork.Enabled = False
        cb_prefnetwork.SelectedIndex = -1

    End Sub

    Public Sub ScreenCapture()

        Dim dates As String = Now.Month.ToString & "_" & Now.Day.ToString & "_" & Now.Hour.ToString & "_" & Now.Minute.ToString & "_" & Now.Second.ToString

        Dim sc1 As String = "shell screencap -p /sdcard/sctp.tmp" 'Fungsi untuk melakukan Screenshoot lalu disimpan di /sdcard
        Dim sc2 As String = "pull /sdcard/sctp.tmp """ & myDoc & "screenshoot\screenshoot_" & dates & ".png""" 'fungsi untuk mengunduh hasil screenshoot di /sdcard
        Dim sc3 As String = "shell rm -f /sdcard/sctp.tmp" 'menghapus file temp hasil screenshoot pada /sdcard

        db.txt_Logs.AppendText(db.lbl_time.Text.ToString & "Capturing Screen..." & vbNewLine)
        inter.ADBComm(sc1)
        db.txt_Logs.AppendText(db.lbl_time.Text.ToString & "Saving Screenshoot..." & vbNewLine)
        inter.ADBComm(sc2)
        db.txt_Logs.AppendText(db.lbl_time.Text.ToString & "Removing temp file..." & vbNewLine)
        inter.ADBComm(sc3)
        db.txt_Logs.AppendText(db.lbl_time.Text.ToString & "Screenshoot Saved" & vbNewLine)

        db.txt_Logs.ScrollToCaret()
        Process.Start(myDoc & "screenshoot\")
        btn_Screenshoot.Enabled = True
    End Sub

    Public Sub ScreenOnOff()

        Dim dummytextbox As New TextBox
        dummytextbox.Text = ""
        Dim cmdInput As String = "shell dumpsys power | grep ""mInteractive"""
        Dim proc As New Process

        proc.StartInfo.CreateNoWindow = True
        proc.StartInfo.UseShellExecute = False
        proc.StartInfo.FileName = "adb.exe"
        proc.StartInfo.Arguments = cmdInput
        proc.StartInfo.Verb = "runas"
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
            dummytextbox.AppendText(line & vbNewLine)
            lines = lines + 1
        End While

        Try
            If proc.HasExited = False Then
                proc.Close()
                proc.Dispose()
            End If
        Catch ex As Exception

        End Try

        If dummytextbox.Text.Contains("mInteractive=false") Then
            inter.ADBComm("shell input keyevent 26")
            db.txt_Logs.AppendText(db.lbl_time.Text.ToString & "Turning on screen.." & vbNewLine)
        ElseIf dummytextbox.Text.Contains("mInteractive=true") Then
            inter.ADBComm("shell input keyevent 26")
            db.txt_Logs.AppendText(db.lbl_time.Text.ToString & "Turning off screen.." & vbNewLine)
        End If
        btn_TurnOnOffScreen.Enabled = True
        db.txt_Logs.ScrollToCaret()
        dummytextbox.Dispose()
    End Sub

    Private Sub txt_SwipeX1_TextChanged(sender As Object, e As EventArgs) Handles txt_SwipeX1.TextChanged
        Dim digitsOnly As Regex = New Regex("[^\d]")
        txt_SwipeX1.Text = digitsOnly.Replace(txt_SwipeX1.Text, "")
    End Sub

    Private Sub txt_SwipeX2_TextChanged(sender As Object, e As EventArgs) Handles txt_SwipeX2.TextChanged
        Dim digitsOnly As Regex = New Regex("[^\d]")
        txt_SwipeX2.Text = digitsOnly.Replace(txt_SwipeX2.Text, "")
    End Sub

    Private Sub txt_SwipeDuration_TextChanged(sender As Object, e As EventArgs) Handles txt_SwipeDuration.TextChanged
        Dim digitsOnly As Regex = New Regex("[^\d]")
        txt_SwipeDuration.Text = digitsOnly.Replace(txt_SwipeDuration.Text, "")
    End Sub

    Private Sub txt_SwipeY1_TextChanged(sender As Object, e As EventArgs) Handles txt_SwipeY1.TextChanged
        Dim digitsOnly As Regex = New Regex("[^\d]")
        txt_SwipeY1.Text = digitsOnly.Replace(txt_SwipeY1.Text, "")
    End Sub

    Private Sub txt_SwipeY2_TextChanged(sender As Object, e As EventArgs) Handles txt_SwipeY2.TextChanged
        Dim digitsOnly As Regex = New Regex("[^\d]")
        txt_SwipeY2.Text = digitsOnly.Replace(txt_SwipeY2.Text, "")
    End Sub

    Private Sub btn_SwipeSend_Click(sender As Object, e As EventArgs) Handles btn_SwipeSend.Click
        Dim i As String = Nothing

        If txt_SwipeX1.Text = i Or txt_SwipeX2.Text = i Or txt_SwipeY1.Text = i Or txt_SwipeY2.Text = i Or txt_SwipeDuration.Text = i Then
            MessageBox.Show("Please fill the empty Textbox", Me.Text, MessageBoxButtons.AbortRetryIgnore, MessageBoxIcon.Exclamation)
            Exit Sub
        End If

        Call New Action(AddressOf SwipeKey).BeginInvoke(Nothing, Nothing)
    End Sub

    Private Sub txt_InputKey_TextChanged(sender As Object, e As EventArgs) Handles txt_InputKey.TextChanged
        If txt_InputKey.Text = "" Then
            btn_KeyInputText.Enabled = False
        Else
            btn_KeyInputText.Enabled = True
        End If
    End Sub

    Private Sub btn_KeyInputText_Click(sender As Object, e As EventArgs) Handles btn_KeyInputText.Click
        btn_KeyInputText.Enabled = False
        txt_InputKey.ReadOnly = True
        Dim strReplace As String
        While txt_InputKey.Text.Contains(" ")
            strReplace = txt_InputKey.Text.Replace(" ", "%s")
            txt_InputKey.Text = strReplace
        End While
        Call New Action(AddressOf KeyInputTextEvent).BeginInvoke(Nothing, Nothing)
    End Sub

    Private Sub cb_prefnetwork_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cb_prefnetwork.SelectedIndexChanged
        If cb_prefnetwork.SelectedIndex = -1 Then
            btn_prefnetwork.Enabled = False
        Else
            btn_prefnetwork.Enabled = True
        End If
    End Sub

    Private Sub btn_prefnetwork_Click(sender As Object, e As EventArgs) Handles btn_prefnetwork.Click
        Call New Action(AddressOf PreferredNetwork).BeginInvoke(Nothing, Nothing)
    End Sub

    Private Sub btn_Screenshoot_Click(sender As Object, e As EventArgs) Handles btn_Screenshoot.Click
        btn_Screenshoot.Enabled = False
        Call New Action(AddressOf ScreenCapture).BeginInvoke(Nothing, Nothing)
    End Sub

    Private Sub btn_TurnOnOffScreen_Click(sender As Object, e As EventArgs) Handles btn_TurnOnOffScreen.Click
        btn_TurnOnOffScreen.Enabled = False
        Call New Action(AddressOf ScreenOnOff).BeginInvoke(Nothing, Nothing)
    End Sub

    Private Sub cb_ToogleRoot_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cb_ToogleRoot.SelectedIndexChanged
        If cb_ToogleRoot.SelectedIndex = -1 Then
            btn_ToogleRoot.Enabled = False
        Else
            btn_ToogleRoot.Enabled = True
        End If
    End Sub

    Private Sub btn_ToogleRoot_Click(sender As Object, e As EventArgs) Handles btn_ToogleRoot.Click

        Dim i As Integer = -1

        Select Case cb_ToogleRoot.SelectedIndex
            Case 0
                db.txt_Logs.AppendText(db.lbl_time.Text.ToString & "Enabling wifi.." & vbNewLine)
                inter.ADBComm("shell su -c svc wifi enable")
                cb_ToogleRoot.SelectedIndex = i
                db.txt_Logs.AppendText(db.lbl_time.Text.ToString & "Wifi Enabled" & vbNewLine)
            Case 1
                db.txt_Logs.AppendText(db.lbl_time.Text.ToString & "Disabling wifi.." & vbNewLine)
                inter.ADBComm("shell su -c svc wifi disable")
                cb_ToogleRoot.SelectedIndex = i
                db.txt_Logs.AppendText(db.lbl_time.Text.ToString & "Wifi Disabled" & vbNewLine)
            Case 2
                db.txt_Logs.AppendText(db.lbl_time.Text.ToString & "Enabling Mobile Data.." & vbNewLine)
                inter.ADBComm("shell su -c svc data enable")
                cb_ToogleRoot.SelectedIndex = i
                db.txt_Logs.AppendText(db.lbl_time.Text.ToString & "Mobile Data Enabled" & vbNewLine)
            Case 3
                db.txt_Logs.AppendText(db.lbl_time.Text.ToString & "Disabling Mobile Data..." & vbNewLine)
                inter.ADBComm("shell su -c svc data disable")
                cb_ToogleRoot.SelectedIndex = i
                db.txt_Logs.AppendText(db.lbl_time.Text.ToString & "Mobile Data Disabled" & vbNewLine)
            Case 4
                db.txt_Logs.AppendText(db.lbl_time.Text.ToString & "Enabling Screen Stay On..." & vbNewLine)
                inter.ADBComm("shell su -c svc power stayon true")
                cb_ToogleRoot.SelectedIndex = i
                db.txt_Logs.AppendText(db.lbl_time.Text.ToString & "Screen Stay On Enabled" & vbNewLine)
            Case 5
                db.txt_Logs.AppendText(db.lbl_time.Text.ToString & "Disabling Screen Stay On..." & vbNewLine)
                inter.ADBComm("shell su -c svc power stayon false")
                cb_ToogleRoot.SelectedIndex = i
                db.txt_Logs.AppendText(db.lbl_time.Text.ToString & "Screen Stay On Disabled" & vbNewLine)
        End Select
    End Sub

    Public Sub ScreenRecord()

        Dim dates As String = Now.Month.ToString & "_" & Now.Day.ToString & "_" & Now.Hour.ToString & "_" & Now.Minute.ToString & "_" & Now.Second.ToString

        If cb_ShowTouches.Checked = True Then
            inter.ADBComm("shell settings put system show_touches 1")
        End If

        'Fungsi untuk melakukan Screen Recording lalu disimpan di /sdcard
        Dim sc1 As String = "shell screenrecord --size " & txt_VidResW.Text & "x" & txt_VidResH.Text & " --time-limit " & txt_VideoTime.Text & " --bit-rate " & txt_VideoBitrate.Text & " /sdcard/scrd.tmp"
        Dim sc2 As String = "pull /sdcard/scrd.tmp """ & myDoc & "screenrecord\screenrecord_" & dates & ".mp4""" 'fungsi untuk mengunduh hasil video recording di /sdcard
        Dim sc3 As String = "shell rm -f /sdcard/scrd.tmp" 'menghapus file temp hasil video recording pada /sdcard

        db.txt_Logs.AppendText(db.lbl_time.Text.ToString & "Start Recording with this setting [ Res :" & txt_VidResW.Text & "x" & txt_VidResH.Text & " Time :" & txt_VideoTime.Text & " Bitrate :" & txt_VideoBitrate.Text & " ]" & vbNewLine)
        db.txt_Logs.AppendText(db.lbl_time.Text.ToString & "Recording..." & vbNewLine)
        inter.ADBComm(sc1)
        db.txt_Logs.AppendText(db.lbl_time.Text.ToString & "Saving Screen Recording..." & vbNewLine)
        inter.ADBComm(sc2)
        db.txt_Logs.AppendText(db.lbl_time.Text.ToString & "Removing temp file..." & vbNewLine)
        inter.ADBComm(sc3)
        db.txt_Logs.AppendText(db.lbl_time.Text.ToString & "Screen Recording Saved" & vbNewLine)

        If cb_ShowTouches.Checked = True Then
            inter.ADBComm("shell settings put system show_touches 0")
        End If

        db.txt_Logs.ScrollToCaret()
        Call db.EnableAllControl()
        Process.Start(myDoc & "screenrecord\")
        cb_ShowTouches.Enabled = True
        pb_RecordVideo.Value = 0
    End Sub

    Public Sub MakeCall()

        db.txt_Logs.AppendText(db.lbl_time.Text.ToString & "Calling " & txt_Dialer.Text & vbNewLine)
        inter.ADBComm("shell am start -a android.intent.action.CALL -d tel:" & txt_Dialer.Text)
        txt_Dialer.Text = ""
    End Sub

    Private Sub txt_VidResW_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_VidResW.KeyPress
        If Not Char.IsNumber(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub txt_VidResW_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_VidResW.TextChanged
        Dim digitsOnly As Regex = New Regex("[^\d]")
        txt_VidResW.Text = digitsOnly.Replace(txt_VidResW.Text, "")
    End Sub

    Private Sub txt_VidResH_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_VidResH.KeyPress
        If Not Char.IsNumber(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub txt_VidResH_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_VidResH.TextChanged
        Dim digitsOnly As Regex = New Regex("[^\d]")
        txt_VidResH.Text = digitsOnly.Replace(txt_VidResH.Text, "")
    End Sub

    Private Sub txt_VideoTime_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_VideoTime.KeyPress
        If Not Char.IsNumber(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub txt_VideoTime_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_VideoTime.TextChanged
        Dim digitsOnly As Regex = New Regex("[^\d]")
        txt_VideoTime.Text = digitsOnly.Replace(txt_VideoTime.Text, "")
    End Sub

    Private Sub txt_VideoBitrate_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_VideoBitrate.KeyPress
        If Not Char.IsNumber(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub txt_VideoBitrate_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_VideoBitrate.TextChanged
        Dim digitsOnly As Regex = New Regex("[^\d]")
        txt_VideoBitrate.Text = digitsOnly.Replace(txt_VideoBitrate.Text, "")
    End Sub

    Private Sub txt_Dialer_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_Dialer.KeyPress
        If Not Char.IsNumber(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If

        Select Case e.KeyChar
            Case ChrW(Keys.Enter)
                Call btn_Call_Click(sender, e)
        End Select
    End Sub

    Private Sub txt_Dialer_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_Dialer.TextChanged
        Dim digitsOnly As Regex = New Regex("[^\d]")
        txt_Dialer.Text = digitsOnly.Replace(txt_Dialer.Text, "")

        If txt_Dialer.Text = "" Then
            btn_Call.Enabled = False
        Else
            btn_Call.Enabled = True
        End If
    End Sub

    Private Sub btn_RecordVideo_Click(sender As Object, e As EventArgs) Handles btn_RecordVideo.Click
        If txt_VidResH.Text = "" Or txt_VidResW.Text = "" Or txt_VideoTime.Text = "" Or txt_VideoBitrate.Text = "" Then
            MessageBox.Show("Please fill the empty Text Box", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If

        Call db.DisableAllControl()
        cb_ShowTouches.Enabled = False

        pb_RecordVideo.Maximum = txt_VideoTime.Text

        inter.Timer1.Enabled = True
        inter.Timer1.Start()

        Call New Action(AddressOf ScreenRecord).BeginInvoke(Nothing, Nothing)
    End Sub

    Private Sub btn_Call_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Call.Click
        Call New Action(AddressOf MakeCall).BeginInvoke(Nothing, Nothing)
    End Sub
End Class
