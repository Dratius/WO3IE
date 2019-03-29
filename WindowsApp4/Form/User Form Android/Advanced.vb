Imports System.IO
Public Class Advanced
    Dim db As ADB
    Dim inter As Interference
    Public Shared myDoc = My.Computer.FileSystem.SpecialDirectories.MyDocuments & "\WOX3IE\"

    Public Sub ZzCmd(ByVal args As String)
        Dim cmdInput As String = args
        Dim proc As New Process

        proc.StartInfo.CreateNoWindow = True
        proc.StartInfo.UseShellExecute = False
        proc.StartInfo.FileName = "7za.exe"
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
            db.txt_Logs.AppendText(line & vbNewLine)
            lines = lines + 1
        End While

        Try
            If proc.HasExited = False Then
                proc.Close()
                proc.Dispose()
            End If
        Catch ex As Exception

        End Try

    End Sub

    Public Sub JavaCmd(ByVal args As String)
        Dim cmdInput As String = args
        Dim proc As New Process

        proc.StartInfo.CreateNoWindow = True
        proc.StartInfo.UseShellExecute = False
        proc.StartInfo.FileName = "cmd.exe"
        proc.StartInfo.Arguments = cmdInput
        proc.StartInfo.Verb = "runas"
        proc.StartInfo.RedirectStandardOutput = True
        proc.StartInfo.RedirectStandardInput = True
        proc.StartInfo.RedirectStandardError = True
        proc.Start()

        proc.StandardInput.WriteLine(cmdInput)
        proc.StandardInput.Close()

        Dim line As String = Nothing
        Dim lineErr As String = Nothing
        Dim lines As Integer = 0
        While (proc.StandardOutput.EndOfStream = False)
            line = proc.StandardOutput.ReadLine
            db.txt_Logs.AppendText(line & vbNewLine)
            lines = lines + 1
        End While

        lineErr = proc.StandardError.ReadToEnd
        If Not lineErr = Nothing Then
            db.txt_Logs.AppendText(lineErr & vbNewLine)
        End If

        Try
            If proc.HasExited = False Then
                proc.Close()
                proc.Dispose()
            End If
        Catch ex As Exception

        End Try

    End Sub

    Public Sub ZipaCmd(ByVal args As String)
        Dim cmdInput As String = args
        Dim proc As New Process

        proc.StartInfo.CreateNoWindow = True
        proc.StartInfo.UseShellExecute = False
        proc.StartInfo.FileName = "bin/zipalign.exe"
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
            db.txt_Logs.AppendText(line & vbNewLine)
            lines = lines + 1
        End While

        Dim lineErr As String = Nothing

        lineErr = proc.StandardError.ReadToEnd
        db.txt_Logs.AppendText(lineErr & vbNewLine)

        Try
            If proc.HasExited = False Then
                proc.Close()
                proc.Dispose()
            End If
        Catch ex As Exception

        End Try

    End Sub

    Sub CheckDir()
        If My.Computer.FileSystem.DirectoryExists(myDoc & "projects\" & list_apkt.SelectedItem.ToString) Then
            Shell("cmd.exe /c rmdir /S /Q """ & myDoc & "projects\" & list_apkt.SelectedItem.ToString & """")
        Else
            Exit Sub
        End If
    End Sub

    Private Sub ZipApk()

        'Set variables
        Dim quot As String = """"
        'Dim lls As String = cobo_apkt_apkcomlv.SelectedItem.ToString
        Dim ssl As String = list_apkt.SelectedItem.ToString
        Dim spath As String = quot & myDoc & "apk-dir\" & quot
        Dim ppath As String = quot & myDoc & "projects\" & ssl & quot
        Dim unsigname As String = quot & myDoc & "apk-sign\unsigned" & ssl & quot

        If chbx_apkt_system.Checked = False Then
            Shell("cmd.exe /c rmdir /S /Q " & ppath & "\META-INF", AppWinStyle.Hide, True)
        End If

        ZzCmd("a -tzip " & unsigname & " " & ppath & " " & "-mx") 'TODO lls)

        db.txt_Logs.AppendText(db.lbl_time.Text.ToString & "Finished..." & vbNewLine)

        Dim result As DialogResult = MessageBox.Show("Do you want open " & ssl & " rebuild apk folder ?", "Open Folder", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation)
        If result = Windows.Forms.DialogResult.Yes Then
            Process.Start(myDoc & "apk-sign\")
        End If

        PopulateApkDir()
    End Sub

    Private Sub SignApk()

        Dim quot As String = """"
        Dim ssl As String = list_apkt.SelectedItem.ToString
        Dim ppath As String = myDoc & "apk-sign/"
        Dim unsigname As String = quot & myDoc & "apk-sign/unsigned" & ssl & quot
        Dim signedname As String = quot & myDoc & "apk-sign/signed" & ssl & quot
        Dim java As String = "/c java -Xmx" 'TODO & txt_apkt_heapsz.Text.ToString & "m -jar bin/signapk.jar -w bin/testkey.x509.pem bin/testkey.pk8 "

        If Not My.Computer.FileSystem.FileExists(myDoc & "apk-sign\unsigned" & ssl) Then
            db.txt_Logs.AppendText(db.lbl_time.Text.ToString & "Project file for this apk does not exist..." & vbNewLine)
            db.txt_Logs.AppendText(db.lbl_time.Text.ToString & "Failed..." & vbNewLine)
            Exit Sub
        End If

        If My.Computer.FileSystem.FileExists(myDoc & "apk-sign\signed" & ssl) Then
            My.Computer.FileSystem.DeleteFile(myDoc & "apk-sign\signed" & ssl, FileIO.UIOption.OnlyErrorDialogs, FileIO.RecycleOption.DeletePermanently)
            Exit Sub
        End If

        JavaCmd(java & unsigname & " " & signedname)

        db.txt_Logs.AppendText(db.lbl_time.Text.ToString & "Finished..." & vbNewLine)
        Dim result As DialogResult = MessageBox.Show("Do you want open " & ssl & " signed folder ?", "Open Folder", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation)
        If result = Windows.Forms.DialogResult.Yes Then
            Process.Start(ppath)
        End If

        PopulateApkDir()
    End Sub

    Private Sub ZipaApk()

        Dim mdir = My.Computer.FileSystem
        Dim quot As String = """"
        Dim ssl As String = list_apkt.SelectedItem.ToString
        Dim ppath = myDoc
        Dim NnameS As String = "signed" & ssl
        Dim NnameU As String = "unsigned" & ssl
        Dim signameQ As String = quot & ppath & "apk-sign\signed" & ssl & quot
        Dim unsignameQ As String = quot & ppath & "apk-sign\unsigned" & ssl & quot
        Dim signame As String = ppath & "apk-sign\signed" & ssl
        Dim unsigname As String = ppath & "apk-sign\unsigned" & ssl
        Dim signameA As String = quot & ppath & "apk-sign\signedaligned" & ssl & quot
        Dim unsignameA As String = quot & ppath & "apk-sign\unsignedaligned" & ssl & quot

        If mdir.FileExists(signame) Then
            ZipaCmd("-f 4 " & signameQ & " " & signameA)
            mdir.DeleteFile(signame)
            mdir.RenameFile(ppath & "apk-sign\signedaligned" & ssl, NnameS)
            db.txt_Logs.AppendText(db.lbl_time.Text.ToString & NnameS & " has been zipaligned" & vbNewLine)
        End If

        If mdir.FileExists(unsigname) Then
            ZipaCmd("-f 4 " & unsignameQ & " " & unsignameA)
            mdir.DeleteFile(unsigname)
            mdir.RenameFile(ppath & "apk-sign\unsignedaligned" & ssl, NnameU)
            db.txt_Logs.AppendText(db.lbl_time.Text.ToString & NnameU & " has been zipaligned" & vbNewLine)
        End If

        db.txt_Logs.AppendText(db.lbl_time.Text.ToString & "Finished..." & vbNewLine)
        Dim result As DialogResult = MessageBox.Show("Do you want open " & ssl & " zipaligned folder ?", "Open Folder", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation)
        If result = Windows.Forms.DialogResult.Yes Then
            Process.Start(myDoc & "apk-sign\")
        End If

        PopulateApkDir()
    End Sub

    Private Sub list_apkt_SelectedIndexChanged(sender As Object, e As EventArgs) Handles list_apkt.SelectedIndexChanged
        Dim mydir = myDoc
        Dim mycom = My.Computer.FileSystem
        Dim selc = list_apkt.SelectedItem

        If list_apkt.SelectedIndex = -1 Then
            Exit Sub
        End If

        For Each item In list_apkt.SelectedItem
            If mycom.DirectoryExists(mydir & "projects\" & selc.ToString) Then
                gb_apkt_at.Enabled = True
                gb_apkt_st.Enabled = True
                btn_apkt_compile.Enabled = True
                btn_apkt_zip.Enabled = True
                btn_apkt_zipa.Enabled = True
                btn_apkt_allinone.Enabled = True
                btn_apkt_extapk.Enabled = True
                btn_apkt_decompile.Enabled = True
                lbl_apkt_checkproj.Text = "Project Exist"
                lbl_apkt_checkproj.ForeColor = Color.Green
            Else
                gb_apkt_at.Enabled = True
                gb_apkt_st.Enabled = True
                lbl_apkt_checkproj.Text = "Project Not Exist"
                lbl_apkt_checkproj.ForeColor = Color.Red
                btn_apkt_compile.Enabled = False
                btn_apkt_zip.Enabled = False
                btn_apkt_zipa.Enabled = False
                btn_apkt_allinone.Enabled = False
                btn_apkt_extapk.Enabled = True
                btn_apkt_decompile.Enabled = True
            End If

            If mycom.FileExists(mydir & "apk-sign\" & "unsigned" & selc.ToString) Then
                btn_apkt_signapk.Enabled = True
            Else
                btn_apkt_signapk.Enabled = False
            End If

            If mycom.FileExists(myDoc & "apk-sign\signed" & list_apkt.SelectedItem.ToString) Then
                btn_apkt_marketsign.Enabled = True
            Else
                btn_apkt_marketsign.Enabled = False
            End If
        Next
    End Sub

    Public Function GetJavaInstallationPath() As String
        Dim EnvironmentPath As String = Environment.GetEnvironmentVariable("JAVA_HOME")

        If Not String.IsNullOrEmpty(EnvironmentPath) Then
            Return EnvironmentPath
        End If

        Const JAVA_KEY As String = "SOFTWARE\JavaSoft\Java Runtime Environment\"
        Dim localKey = Microsoft.Win32.RegistryKey.OpenBaseKey(Microsoft.Win32.RegistryHive.LocalMachine, Microsoft.Win32.RegistryView.Registry32)
        localKey.OpenSubKey(JAVA_KEY)

        Using rk = localKey.OpenSubKey(JAVA_KEY)
            If rk IsNot Nothing Then
                Dim currentVersion As String = rk.GetValue("CurrentVersion").ToString()
                Using key = rk.OpenSubKey(currentVersion)
                    Return key.GetValue("JavaHome").ToString
                End Using
            End If
        End Using
        Return Nothing
    End Function

    Sub ApktControlDisable()
        gb_apkt_st.Enabled = False
        gb_apkt_at.Enabled = False
        'TODO gb_apkt_comsets.Enabled = False
        'TODO gb_apkt_sett.Enabled = False
        list_apkt.Enabled = False
        btn_apkt_marketsign.Enabled = False
        chbx_apkt_system.Enabled = False
    End Sub

    Private Sub ExtractApk()

        'Set variables
        Dim quot As String = """"
        Dim spath As String = quot & myDoc & "apk-dir\" & quot
        Dim ssl As String = list_apkt.SelectedItem.ToString
        Dim cmd As String = quot & myDoc & "projects\" & ssl & quot

        'Check if folder exist
        'If exist delete it
        CheckDir()

        'Command for extracting Apk
        ZzCmd("x -o" & cmd & " " & spath)

        db.txt_Logs.AppendText(db.lbl_time.Text.ToString & "Done..." & vbNewLine)

        Dim result As DialogResult = MessageBox.Show("Do you want open " & ssl & " Project folder ?", "Open Folder", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation)
        If result = Windows.Forms.DialogResult.Yes Then
            Process.Start(cmd)
        End If

        'Refresh the list box
        PopulateApkDir()
    End Sub

    Private Sub DecompileApk()

        Dim mycom = My.Computer.FileSystem
        Dim quot As String = """"
        Dim ssl As String = list_apkt.SelectedItem.ToString
        Dim apkdir As String = quot & My.Computer.FileSystem.SpecialDirectories.MyDocuments & "/Android Tools/apk-dir/" & ssl & quot
        Dim proj As String = quot & My.Computer.FileSystem.SpecialDirectories.MyDocuments & "/Android Tools/projects/" & ssl & quot
        Dim projsys As String = "projects/" & "system" & ssl
        Dim cmd0 As String = "/c java -Xmx" & txt_apkt_heapsz.Text.ToString & "m -jar bin/apktool.jar d " & apkdir & " " & "-o" & " " & proj
        Dim cmd1 As String = "/c java -Xmx" & txt_apkt_heapsz.Text.ToString & "m -jar bin/apktool.jar d -r " & apkdir & " " & "-o" & " " & proj
        Dim cmd2 As String = "/c java -Xmx" & txt_apkt_heapsz.Text.ToString & "m -jar bin/apktool.jar d -s " & apkdir & " " & "-o" & " " & proj
        Dim cmd3 As String = "/c java -Xmx" & txt_apkt_heapsz.Text.ToString & "m -jar bin/apktool.jar d -r -s " & apkdir & " " & "-o" & " " & proj
        Dim cmd4 As String = "/c java -Xmx" & txt_apkt_heapsz.Text.ToString & "m -jar bin/apktool.jar b " & apkdir & " " & "-o" & " " & projsys


        If mycom.FileExists(myDoc & "apk-sign\signed" & ssl) Then
            mycom.DeleteFile(myDoc & "apk-sign\signed" & ssl, FileIO.UIOption.OnlyErrorDialogs, FileIO.RecycleOption.DeletePermanently)
        End If
        If mycom.FileExists(myDoc & "apk-sign\unsigned" & ssl) Then
            mycom.DeleteFile(myDoc & "apk-sign\unsigned" & ssl, FileIO.UIOption.OnlyErrorDialogs, FileIO.RecycleOption.DeletePermanently)
        End If
        If mycom.FileExists(myDoc & "apk-sign\system" & ssl) Then
            mycom.DeleteFile(myDoc & "apk-sign\system" & ssl, FileIO.UIOption.OnlyErrorDialogs, FileIO.RecycleOption.DeletePermanently)
        End If

        CheckDir()

        db.txt_Logs.AppendText(db.lbl_time.Text.ToString & "Decompiling Apk " & cobo_apkt_decompile.SelectedItem.ToString & vbNewLine)

        If chbx_apkt_system.Checked = True Then
            JavaCmd(cmd4)
        ElseIf chbx_apkt_system.Checked = False Then
            If cobo_apkt_decompile.SelectedIndex = 0 Then
                JavaCmd(cmd0)
            ElseIf cobo_apkt_decompile.SelectedIndex = 1 Then
                JavaCmd(cmd1)
            ElseIf cobo_apkt_decompile.SelectedIndex = 2 Then
                JavaCmd(cmd2)
            ElseIf cobo_apkt_decompile.SelectedIndex = 3 Then
                JavaCmd(cmd3)
            End If
        End If

        If db.txt_Logs.Text.Contains("Exception") Then
            db.txt_Logs.AppendText(db.lbl_time.Text.ToString & "Decompiling failed. Errors found. Check the logs above." & vbNewLine)
            PopulateApkDir()
            Exit Sub
        End If

        If chbx_apkt_system.Checked = True Then
            Dim result As DialogResult = MessageBox.Show("Do you want open the project folder?", Me.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If result = DialogResult.Yes Then
                Process.Start(myDoc & "projects\" & "system" & ssl)
            End If
        ElseIf chbx_apkt_system.Checked = False Then
            Dim result As DialogResult = MessageBox.Show("Do you want open the project folder?", Me.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If result = DialogResult.Yes Then
                Process.Start(myDoc & "projects\" & ssl)
            End If
        End If

        db.txt_Logs.AppendText(db.lbl_time.Text.ToString & "Finished..." & vbNewLine)
        PopulateApkDir()
    End Sub

    'Compiling Apk function
    Private Sub CompileApk()

        Dim mycom = My.Computer.FileSystem
        Dim quot As String = """"
        Dim ssl As String = list_apkt.SelectedItem.ToString
        Dim apkdir As String = quot & My.Computer.FileSystem.SpecialDirectories.MyDocuments & "/Android Tools/apk-sign/unsigned" & ssl & quot
        Dim proj As String = quot & My.Computer.FileSystem.SpecialDirectories.MyDocuments & "/Android Tools/projects/" & ssl & quot
        Dim cmd As String = "/c java -Xmx" & txt_apkt_heapsz.Text.ToString & "m -jar bin/apktool.jar b " & proj & " " & "-o" & " " & apkdir

        If mycom.FileExists(myDoc & "apk-sign\signed" & ssl) Then
            mycom.DeleteFile(myDoc & "apk-sign\signed" & ssl, FileIO.UIOption.OnlyErrorDialogs, FileIO.RecycleOption.DeletePermanently)
        End If
        If mycom.FileExists(myDoc & "apk-sign\unsigned" & ssl) Then
            mycom.DeleteFile(myDoc & "apk-sign\unsigned" & ssl, FileIO.UIOption.OnlyErrorDialogs, FileIO.RecycleOption.DeletePermanently)
        End If

        JavaCmd(cmd)

        If db.txt_Logs.Text.Contains("Exception") Then
            db.txt_Logs.AppendText(db.lbl_time.Text.ToString & "Compiling failed. Errors found. Check the logs above." & vbNewLine)
            PopulateApkDir()
            Exit Sub
        End If

        db.txt_Logs.AppendText(db.lbl_time.Text.ToString & "Finished..." & vbNewLine)
        Dim result As DialogResult = MessageBox.Show("Do you want open " & ssl & " compiled folder ?", "Open Folder", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation)
        If result = Windows.Forms.DialogResult.Yes Then
            Process.Start(myDoc & "apk-sign\")
        End If

        PopulateApkDir()
    End Sub

    'Market Sign Apk function
    Sub MarketSign()

        Dim q As String = """"
        Dim n As String = "&"
        Dim Keystore As String = " set KEYSTORE_FILE=bin\apksigner.keystore "
        Dim KeystoreAlias As String = " set KEYSTORE_ALIAS=bin\apksigner.keystore "
        Dim Javac_Path As String = " set JAVAC_PATH=%JAVA_HOME%\bin\ "
        Dim PATH As String = " set PATH=%PATH%;%JAVAC_PATH%; "
        Dim Commands As String = "call jarsigner -sigalg MD5withRSA -digestalg SHA1 -keystore %KEYSTORE_FILE% -storepass %KEYSTORE_PASS% -keypass %KEYSTORE_PASS% -signedjar "
        Dim Signed As String = myDoc & "apk-sign\signed" & list_apkt.SelectedItem.ToString
        Dim Unsigned As String = myDoc & "apk-sign\unsigned" & list_apkt.SelectedItem.ToString
        Dim args As String = "/k" & Keystore & n & KeystoreAlias & n & Javac_Path & n & PATH & Commands & q & Signed & q & " " & q & Unsigned & q & " " & "%KEYSTORE_ALIAS%"

        Dim cmdInput As String = args
        Dim proc As New Process

        proc.StartInfo.CreateNoWindow = True
        proc.StartInfo.UseShellExecute = False
        proc.StartInfo.FileName = "cmd.exe"
        proc.StartInfo.Arguments = cmdInput
        proc.StartInfo.RedirectStandardOutput = True
        proc.StartInfo.RedirectStandardInput = True
        proc.StartInfo.RedirectStandardError = True
        proc.Start()

        proc.StandardInput.WriteLine(cmdInput)
        proc.StandardInput.Close()

        proc.Close()
        proc.Dispose()

        My.Computer.FileSystem.DeleteFile(myDoc & "apk-sign\unsigned" & list_apkt.SelectedItem.ToString)
        db.txt_Logs.AppendText(db.lbl_time.Text.ToString & list_apkt.SelectedItem.ToString & " Signed finished..." & vbNewLine)
    End Sub

    Sub PopulateApkDir()
        Dim files() As String = Directory.GetFiles(myDoc & "apk-dir\", "*.*")
        Dim AllowedExtension As String = ".apk"
        list_apkt.Items.Clear()
        For Each File In files
            If AllowedExtension.Contains(Path.GetExtension(File).ToLower) Then
                list_apkt.Items.Add(Path.GetFileName(File))
            End If
        Next

        lbl_apkt_checkproj.Text = "No File Selected"
        lbl_apkt_checkproj.ForeColor = Color.Black

        If list_apkt.SelectedIndex = -1 Then
            'TODO gb_apkt_comsets.Enabled = True
            'TODO gb_apkt_sett.Enabled = True
            gb_apkt_st.Enabled = False
            gb_apkt_at.Enabled = False
            list_apkt.Enabled = True
            chbx_apkt_system.Enabled = True
        End If
    End Sub

    Private Sub AlliApk()

        Dim quot As String = """"
        'TODO Dim lls As String = cobo_apkt_apkcomlv.SelectedItem.ToString
        Dim ssl As String = list_apkt.SelectedItem.ToString
        Dim spath As String = quot & myDoc & "apk-dir\" & quot
        Dim ppath As String = quot & myDoc & "projects\" & ssl & quot
        Dim unsigname As String = quot & myDoc & "apk-sign\unsigned" & ssl & quot

        If chbx_apkt_system.Checked = False Then
            Shell("cmd.exe /c rmdir /S /Q " & ppath & "\META-INF", AppWinStyle.Hide, True)
        End If

        ZzCmd("a -tzip " & unsigname & " " & ppath & " " & "-mx") 'TODO & lls)

        db.txt_Logs.AppendText(db.lbl_time.Text.ToString & "Signing Apk..." & vbNewLine)
        Call New Action(AddressOf SignApk).BeginInvoke(Nothing, Nothing)
    End Sub

    Sub ClearABE()
        txt_abe_abpath.Text = ""
        txt_abe_tarpath.Text = ""
        txt_abe_pass.Text = ""
    End Sub

    Sub EnableABE()
        txt_abe_pass.Enabled = True
        btn_abe_showab.Enabled = True
        btn_abe_showtar.Enabled = True
    End Sub

    Sub ABEPackWithoutPass()

        Dim quot As String = """"
        Dim cmd0 As String = "/c java -jar bin/abe.jar pack " & quot & txt_abe_tarpath.Text & quot & " " & quot & txt_abe_abpath.Text & quot
        JavaCmd(cmd0)
        db.txt_Logs.AppendText(db.lbl_time.Text.ToString & "File Packed to " & txt_abe_abpath.Text & vbNewLine)
        btn_abe_start.Enabled = True
        ClearABE()
        EnableABE()
    End Sub

    Sub ABEPackWithoutPassKK()

        Dim quot As String = """"
        Dim cmd0 As String = "/c java -jar bin/abe.jar pack-kk " & quot & txt_abe_tarpath.Text & quot & " " & quot & txt_abe_abpath.Text & quot
        JavaCmd(cmd0)
        db.txt_Logs.AppendText(db.lbl_time.Text.ToString & "File Packed to " & txt_abe_abpath.Text & vbNewLine)
        btn_abe_start.Enabled = True
        ClearABE()
        EnableABE()
    End Sub

    Sub ABEPackWithPass()

        Dim quot As String = """"
        Dim pass As String = " " & txt_abe_pass.Text
        Dim cmd0 As String = "/c java -jar bin/abe.jar pack " & quot & txt_abe_tarpath.Text & quot & " " & quot & txt_abe_abpath.Text & quot & pass
        JavaCmd(cmd0)
        db.txt_Logs.AppendText(db.lbl_time.Text.ToString & "File Packed to " & txt_abe_abpath.Text & vbNewLine)
        btn_abe_start.Enabled = True
        ClearABE()
        EnableABE()
    End Sub

    Sub ABEPackWithPassKK()

        Dim quot As String = """"
        Dim pass As String = " " & txt_abe_pass.Text
        Dim cmd0 As String = "/c java -jar bin/abe.jar pack-kk " & quot & txt_abe_tarpath.Text & quot & " " & quot & txt_abe_abpath.Text & quot & pass
        JavaCmd(cmd0)
        db.txt_Logs.AppendText(db.lbl_time.Text.ToString & "File Packed to " & txt_abe_abpath.Text & vbNewLine)
        btn_abe_start.Enabled = True
        ClearABE()
        EnableABE()
    End Sub

    Sub ABEUnpackWithoutPass()

        Dim quot As String = """"
        Dim cmd0 As String = "/c java -jar bin/abe.jar unpack " & quot & txt_abe_abpath.Text & quot & " " & quot & txt_abe_tarpath.Text & quot
        JavaCmd(cmd0)
        db.txt_Logs.AppendText(db.lbl_time.Text.ToString & "File Unpacked to " & txt_abe_tarpath.Text & vbNewLine)
        btn_abe_start.Enabled = True
        ClearABE()
        EnableABE()
    End Sub

    'Android Backup Extractor Unpack with password function
    Sub ABEUnpackWithPass()

        Dim quot As String = """"
        Dim pass As String = " " & txt_abe_pass.Text
        Dim cmd0 As String = "/c java -jar bin/abe.jar unpack " & quot & txt_abe_abpath.Text & quot & " " & quot & txt_abe_tarpath.Text & quot & pass
        JavaCmd(cmd0)
        db.txt_Logs.AppendText(db.lbl_time.Text.ToString & "File Unpacked to " & txt_abe_tarpath.Text & vbNewLine)
        btn_abe_start.Enabled = True
        ClearABE()
        EnableABE()
    End Sub

    Public Sub SaveBuildProp()

        Dim DummyTextbox As New Windows.Forms.TextBox
        DummyTextbox.Multiline = True
        DummyTextbox.WordWrap = False

        Dim cmdInput As String = "shell cat /proc/mounts | grep system"
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

        Dim s As String = proc.StandardOutput.ReadLine
        Dim words As String() = s.Split(New Char() {" "c})
        Dim word As String
        Dim strText() As String

        For Each word In words
            DummyTextbox.AppendText(word + vbNewLine)
        Next

        proc.Close()
        proc.Dispose()

        strText = Split(DummyTextbox.Text, vbCrLf)

        inter.ADBComm("push """ & My.Computer.FileSystem.SpecialDirectories.MyDocuments & "/Android Tools/build.prop"" /sdcard/tmp.ahs")
        db.txt_Logs.AppendText(db.lbl_time.Text.ToString & "Pushing build.prop to /sdcard/..." & vbNewLine)

        inter.ADBComm("shell su -c mount -o rw,remount,rw -t " & strText(2) & " " & strText(0) & " " & strText(1))
        db.txt_Logs.AppendText(db.lbl_time.Text.ToString & "Mounting /system/ as Read-Write..." & vbNewLine)

        inter.ADBComm("shell su -c cp /sdcard/tmp.ahs /system/build.prop")
        db.txt_Logs.AppendText(db.lbl_time.Text.ToString & "Copying build.prop to /system/..." & vbNewLine)

        inter.ADBComm("shell su -c chmod 644 /system/build.prop")
        db.txt_Logs.AppendText(db.lbl_time.Text.ToString & "Changing build.prop Permission to 644 (rw-r--r--)..." & vbNewLine)

        inter.ADBComm("shell su -c rm /sdcard/tmp.ahs")
        db.txt_Logs.AppendText(db.lbl_time.Text.ToString & "Removing temp file..." & vbNewLine)

        inter.ADBComm("shell su -c mount -o ro,remount,ro -t " & strText(2) & " " & strText(0) & " " & strText(1))
        db.txt_Logs.AppendText(db.lbl_time.Text.ToString & "Mounting /system/ as Read-Only..." & vbNewLine)

        DummyTextbox.Dispose()
        db.txt_Logs.AppendText(db.lbl_time.Text.ToString & "Finished..." & vbNewLine)

        Dim result As DialogResult = MessageBox.Show("Do you want to reboot?", Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If result = Windows.Forms.DialogResult.OK Then
            Call db.DisableAllControl()
            inter.ADBComm("reboot")
            System.Threading.Thread.Sleep(4000)
            Call db.EnableAllControl()
        Else
            Exit Sub
        End If
    End Sub

    Private Sub btn_apkt_extapk_Click(sender As Object, e As EventArgs) Handles btn_apkt_extapk.Click
        Call ApktControlDisable()
        db.txt_Logs.AppendText(db.lbl_time.Text.ToString & "Extracting..." & vbNewLine)
        Call New Action(AddressOf ExtractApk).BeginInvoke(Nothing, Nothing)
    End Sub

    Private Sub btn_apkt_zip_Click(sender As Object, e As EventArgs) Handles btn_apkt_zip.Click
        Call ApktControlDisable()
        db.txt_Logs.AppendText(db.lbl_time.Text.ToString & "Building Apk..." & vbNewLine)
        Call New Action(AddressOf ZipApk).BeginInvoke(Nothing, Nothing)
    End Sub

    Private Sub btn_apkt_signapk_Click(sender As Object, e As EventArgs) Handles btn_apkt_signapk.Click
        If chbx_apkt_system.Checked = True Then
            MsgBox("You cannot signing system App", MsgBoxStyle.Information)
            Exit Sub
        End If

        Call ApktControlDisable()
        db.txt_Logs.AppendText(db.lbl_time.Text.ToString & "Signing Apk..." & vbNewLine)
        Call New Action(AddressOf SignApk).BeginInvoke(Nothing, Nothing)
    End Sub

    Private Sub btn_apkt_zipa_Click(sender As Object, e As EventArgs) Handles btn_apkt_zipa.Click
        Call ApktControlDisable()
        db.txt_Logs.AppendText(db.lbl_time.Text.ToString & "Aligning Apk..." & vbNewLine)
        Call New Action(AddressOf ZipaApk).BeginInvoke(Nothing, Nothing)
    End Sub

    Private Sub btn_apkt_allinone_Click(sender As Object, e As EventArgs) Handles btn_apkt_allinone.Click
        If chbx_apkt_system.Checked = True Then
            MsgBox("You cannot signing system App", MsgBoxStyle.Information)
            Exit Sub
        End If

        Call ApktControlDisable()
        db.txt_Logs.AppendText(db.lbl_time.Text.ToString & "Zipping and Aligning..." & vbNewLine)
        Call New Action(AddressOf AlliApk).BeginInvoke(Nothing, Nothing)
    End Sub

    Private Sub btn_apkt_decompile_Click(sender As Object, e As EventArgs) Handles btn_apkt_decompile.Click
        Call ApktControlDisable()
        db.txt_Logs.Text = ""
        Call New Action(AddressOf DecompileApk).BeginInvoke(Nothing, Nothing)
    End Sub

    Private Sub btn_apkt_compile_Click(sender As Object, e As EventArgs) Handles btn_apkt_compile.Click
        Call ApktControlDisable()
        db.txt_Logs.Text = ""
        Call New Action(AddressOf CompileApk).BeginInvoke(Nothing, Nothing)
    End Sub

    Private Sub btn_apkt_marketsign_Click(sender As Object, e As EventArgs) Handles btn_apkt_marketsign.Click
        Dim result As DialogResult = MessageBox.Show("- Java JDK must be installed before this option will function" & vbNewLine &
                                                     "- Set The Environment Variables and set the path to your JAVA_HOME" & vbNewLine &
                                                     "- For ex define it as C:\Program Files\Java\jdk1.6.0_43 as a sys var slot" & vbNewLine & vbNewLine &
                                                     "Continue Signing?", "Readme", MessageBoxButtons.YesNo, MessageBoxIcon.Information)
        If result = Windows.Forms.DialogResult.Yes Then
            If Not My.Computer.FileSystem.FileExists(Application.StartupPath & "\apk-sign\signed" & list_apkt.SelectedItem.ToString) Then
                db.txt_Logs.AppendText(db.lbl_time.Text.ToString & "Signing " & list_apkt.SelectedItem.ToString & " with Market Signer..." & vbNewLine)
                Call New Action(AddressOf MarketSign).BeginInvoke(Nothing, Nothing)
            Else
                MsgBox("Signed Apk does not exist", MsgBoxStyle.Information, "File not exist")
                Exit Sub
            End If
        Else
            Exit Sub
        End If
    End Sub

    Private Sub rb_abe_unpack_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rb_abe_unpack.CheckedChanged
        If rb_abe_unpack.Checked = True Then
            btn_abe_start.Text = "Unpack"
        End If
    End Sub

    Private Sub rb_abe_pack_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rb_abe_pack.CheckedChanged
        If rb_abe_pack.Checked = True Then
            btn_abe_start.Text = "Pack"
        End If
    End Sub

    Private Sub txt_abe_abpath_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_abe_abpath.TextChanged
        If txt_abe_abpath.Text = Nothing Or txt_abe_tarpath.Text = Nothing Then
            btn_abe_start.Enabled = False
        Else
            btn_abe_start.Enabled = True
        End If
    End Sub

    Private Sub txt_abe_tarpath_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_abe_tarpath.TextChanged
        If txt_abe_abpath.Text = Nothing Or txt_abe_tarpath.Text = Nothing Then
            btn_abe_start.Enabled = False
        Else
            btn_abe_start.Enabled = True
        End If
    End Sub

    Private Sub btn_abe_showab_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_abe_showab.Click
        If rb_abe_pack.Checked = True Then
            Dim sd As SaveFileDialog = New SaveFileDialog
            Dim strName As String

            sd.Title = "Save your ADB Backup file"
            sd.InitialDirectory = My.Computer.FileSystem.SpecialDirectories.MyDocuments.ToString
            sd.Filter = "ADB Backup (*.ab)|*.ab"
            sd.RestoreDirectory = True

            If sd.ShowDialog = DialogResult.OK Then
                strName = Path.GetFullPath(sd.FileName)
                txt_abe_abpath.Text = strName
            Else
                Exit Sub
            End If
        Else
            Dim op As OpenFileDialog = New OpenFileDialog
            Dim strName As String

            op.Title = "Choose your ADB Backup file"
            op.InitialDirectory = My.Computer.FileSystem.SpecialDirectories.MyDocuments.ToString
            op.Filter = "ADB Backup (*.ab)|*.ab"
            op.RestoreDirectory = True

            If op.ShowDialog = DialogResult.OK Then
                strName = Path.GetFullPath(op.FileName)
                txt_abe_abpath.Text = strName
            Else
                Exit Sub
            End If
        End If
    End Sub

    Private Sub btn_abe_showtar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_abe_showtar.Click
        If rb_abe_unpack.Checked = True Then
            Dim sd As SaveFileDialog = New SaveFileDialog
            Dim strName As String

            sd.Title = "Save your Tar Zip file"
            sd.InitialDirectory = My.Computer.FileSystem.SpecialDirectories.MyDocuments.ToString
            sd.Filter = "Tar Zip (*.tar)|*.tar"
            sd.RestoreDirectory = True

            If sd.ShowDialog = DialogResult.OK Then
                strName = Path.GetFullPath(sd.FileName)
                txt_abe_tarpath.Text = strName
            Else
                Exit Sub
            End If
        Else
            Dim op As OpenFileDialog = New OpenFileDialog
            Dim strName As String

            op.Title = "Choose your Tar Zip file"
            op.InitialDirectory = My.Computer.FileSystem.SpecialDirectories.MyDocuments.ToString
            op.Filter = "Tar Zip (*.tar)|*.tar"
            op.RestoreDirectory = True

            If op.ShowDialog = DialogResult.OK Then
                strName = Path.GetFullPath(op.FileName)
                txt_abe_tarpath.Text = strName
            Else
                Exit Sub
            End If
        End If
    End Sub

    Private Sub btn_abe_start_Click(sender As Object, e As EventArgs) Handles btn_abe_start.Click
        btn_abe_start.Enabled = False

        'Functions is called by name on the button
        Select Case btn_abe_start.Text
            Case "Unpack"
                db.txt_Logs.AppendText(db.lbl_time.Text.ToString & "Unpacking..." & vbNewLine)
                If txt_abe_pass.Text = Nothing Then
                    Call New Action(AddressOf ABEUnpackWithoutPass).BeginInvoke(Nothing, Nothing)
                Else
                    Call New Action(AddressOf ABEUnpackWithPass).BeginInvoke(Nothing, Nothing)
                End If
            Case "Pack"
                db.txt_Logs.AppendText(db.lbl_time.Text.ToString & "Packing..." & vbNewLine)
                If txt_abe_pass.Text = Nothing Then
                    If cb_abe_android.CheckState = CheckState.Checked Then
                        Call New Action(AddressOf ABEPackWithoutPassKK).BeginInvoke(Nothing, Nothing)
                    Else
                        Call New Action(AddressOf ABEPackWithoutPass).BeginInvoke(Nothing, Nothing)
                    End If
                Else
                    If cb_abe_android.CheckState = CheckState.Checked Then
                        Call New Action(AddressOf ABEPackWithPassKK).BeginInvoke(Nothing, Nothing)
                    Else
                        Call New Action(AddressOf ABEPackWithPass).BeginInvoke(Nothing, Nothing)
                    End If
                End If
        End Select
    End Sub

    Private Sub ll_abe_installpolicy_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles ll_abe_installpolicy.LinkClicked

        Dim result As DialogResult = MessageBox.Show("This is for Java JRE Version 8+ Only." & vbNewLine &
                                                     "If your Java JRE is lower than this please download and install it manually to %JAVA_PATH%/bin/security/(here)." _
                                                     , "Information", MessageBoxButtons.OKCancel, MessageBoxIcon.Information)

        If result = DialogResult.OK Then
            My.Computer.FileSystem.DeleteFile(GetJavaInstallationPath() & "\lib\security\local_policy.jar")
            My.Computer.FileSystem.DeleteFile(GetJavaInstallationPath() & "\lib\security\US_export_policy.jar")

            My.Computer.FileSystem.CopyFile(Application.StartupPath & "\UnlimitedJCEPolicyJDK8\local_policy.jar", GetJavaInstallationPath() & "\lib\security\local_policy.jar", True)
            My.Computer.FileSystem.CopyFile(Application.StartupPath & "\UnlimitedJCEPolicyJDK8\US_export_policy.jar", GetJavaInstallationPath() & "\lib\security\US_export_policy.jar", True)
            db.txt_Logs.AppendText(db.lbl_time.Text.ToString & "Policy Security replaced and installed" & vbNewLine)
        Else
            Exit Sub
        End If
    End Sub

    Private Sub btn_LoadBuildProp_Click(sender As Object, e As EventArgs) Handles btn_LoadBuildProp.Click
        txt_buildprop.Text = Nothing
        inter.ADBComm("pull /system/build.prop """ & My.Computer.FileSystem.SpecialDirectories.MyDocuments & "/Android Tools/build.prop""")

        txt_buildprop.LoadFile(myDoc & "build.prop")

        btn_SaveBuildProp.Enabled = True
        btn_BackupBuildProp.Enabled = True
        btn_BuildPropTweaks.Enabled = True
        db.txt_Logs.AppendText(db.lbl_time.Text.ToString & "build.prop has been loaded" & vbNewLine)
        txt_buildprop.Enabled = True
    End Sub

    Private Sub btn_SaveBuildProp_Click(sender As Object, e As EventArgs) Handles btn_SaveBuildProp.Click
        txt_buildprop.SaveFile(myDoc & "build.prop")

        Dim result As DialogResult = MessageBox.Show("Do you want to push edited build.prop to system? (Root Only)", Me.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If result = Windows.Forms.DialogResult.Yes Then
            btn_SaveBuildProp.Enabled = False
            Call New Action(AddressOf SaveBuildProp).BeginInvoke(Nothing, Nothing)
        Else
            Exit Sub
        End If
    End Sub

    Private Sub btn_BackupBuildProp_Click(sender As Object, e As EventArgs) Handles btn_BackupBuildProp.Click
        If My.Computer.FileSystem.FileExists(myDoc & "build.prop") = True Then
            My.Computer.FileSystem.CopyFile(myDoc & "build.prop", myDoc & "build.prop.bak")
            db.txt_Logs.AppendText(db.lbl_time.Text.ToString & "build.prop has been backup as build.prop.bak" & vbNewLine)
        Else
            MessageBox.Show("Please load the Build Prop first", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub
End Class
