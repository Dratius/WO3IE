<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Settings
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.TC_Settings = New System.Windows.Forms.TabControl()
        Me.Tab_ADBSettings = New System.Windows.Forms.TabPage()
        Me.gb_ADBWifi = New System.Windows.Forms.GroupBox()
        Me.lbl_HowToIP = New System.Windows.Forms.Label()
        Me.lbl_defPort = New System.Windows.Forms.Label()
        Me.btn_connectwifi = New System.Windows.Forms.Button()
        Me.lbl_DevIP = New System.Windows.Forms.Label()
        Me.lbl_port = New System.Windows.Forms.Label()
        Me.txt_ipaddr = New System.Windows.Forms.TextBox()
        Me.txt_tcpip = New System.Windows.Forms.TextBox()
        Me.gb_ADBRestart = New System.Windows.Forms.GroupBox()
        Me.lbl_tcport = New System.Windows.Forms.Label()
        Me.txt_tcport = New System.Windows.Forms.TextBox()
        Me.btn_adbTCPIP = New System.Windows.Forms.Button()
        Me.btn_adbUSB = New System.Windows.Forms.Button()
        Me.btn_AdbUnroot = New System.Windows.Forms.Button()
        Me.btn_adbRoot = New System.Windows.Forms.Button()
        Me.tb_apkt_sett = New System.Windows.Forms.TabPage()
        Me.lbl_apkt_warn_settings = New System.Windows.Forms.Label()
        Me.gb_apkt_sett = New System.Windows.Forms.GroupBox()
        Me.btn_apkt_opendir = New System.Windows.Forms.Button()
        Me.cobo_apkt_opendir = New System.Windows.Forms.ComboBox()
        Me.lbl_apkt_opendir = New System.Windows.Forms.Label()
        Me.btn_apkt_clearfolder = New System.Windows.Forms.Button()
        Me.cobo_apkt_clrfolder = New System.Windows.Forms.ComboBox()
        Me.lbl_apkt_clearfolder = New System.Windows.Forms.Label()
        Me.gb_apkt_comsets = New System.Windows.Forms.GroupBox()
        Me.lbl_apkt_hz = New System.Windows.Forms.Label()
        Me.txt_apkt_heapsz = New System.Windows.Forms.TextBox()
        Me.cobo_apkt_decompile = New System.Windows.Forms.ComboBox()
        Me.lbl_apkt_decom = New System.Windows.Forms.Label()
        Me.cobo_apkt_rescomlv = New System.Windows.Forms.ComboBox()
        Me.lbl_apkt_rescom = New System.Windows.Forms.Label()
        Me.cobo_apkt_apkcomlv = New System.Windows.Forms.ComboBox()
        Me.lbl_apkt_comlv = New System.Windows.Forms.Label()
        Me.TC_Settings.SuspendLayout()
        Me.Tab_ADBSettings.SuspendLayout()
        Me.gb_ADBWifi.SuspendLayout()
        Me.gb_ADBRestart.SuspendLayout()
        Me.tb_apkt_sett.SuspendLayout()
        Me.gb_apkt_sett.SuspendLayout()
        Me.gb_apkt_comsets.SuspendLayout()
        Me.SuspendLayout()
        '
        'TC_Settings
        '
        Me.TC_Settings.Controls.Add(Me.Tab_ADBSettings)
        Me.TC_Settings.Controls.Add(Me.tb_apkt_sett)
        Me.TC_Settings.Font = New System.Drawing.Font("High Tower Text", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TC_Settings.Location = New System.Drawing.Point(-1, 14)
        Me.TC_Settings.Name = "TC_Settings"
        Me.TC_Settings.SelectedIndex = 0
        Me.TC_Settings.Size = New System.Drawing.Size(406, 509)
        Me.TC_Settings.TabIndex = 3
        '
        'Tab_ADBSettings
        '
        Me.Tab_ADBSettings.Controls.Add(Me.gb_ADBWifi)
        Me.Tab_ADBSettings.Controls.Add(Me.gb_ADBRestart)
        Me.Tab_ADBSettings.Location = New System.Drawing.Point(4, 24)
        Me.Tab_ADBSettings.Name = "Tab_ADBSettings"
        Me.Tab_ADBSettings.Padding = New System.Windows.Forms.Padding(3)
        Me.Tab_ADBSettings.Size = New System.Drawing.Size(398, 481)
        Me.Tab_ADBSettings.TabIndex = 0
        Me.Tab_ADBSettings.Text = "ADB Settings"
        Me.Tab_ADBSettings.UseVisualStyleBackColor = True
        '
        'gb_ADBWifi
        '
        Me.gb_ADBWifi.Controls.Add(Me.lbl_HowToIP)
        Me.gb_ADBWifi.Controls.Add(Me.lbl_defPort)
        Me.gb_ADBWifi.Controls.Add(Me.btn_connectwifi)
        Me.gb_ADBWifi.Controls.Add(Me.lbl_DevIP)
        Me.gb_ADBWifi.Controls.Add(Me.lbl_port)
        Me.gb_ADBWifi.Controls.Add(Me.txt_ipaddr)
        Me.gb_ADBWifi.Controls.Add(Me.txt_tcpip)
        Me.gb_ADBWifi.Location = New System.Drawing.Point(6, 7)
        Me.gb_ADBWifi.Name = "gb_ADBWifi"
        Me.gb_ADBWifi.Size = New System.Drawing.Size(346, 300)
        Me.gb_ADBWifi.TabIndex = 0
        Me.gb_ADBWifi.TabStop = False
        Me.gb_ADBWifi.Text = "Connect Over WiFi"
        '
        'lbl_HowToIP
        '
        Me.lbl_HowToIP.Location = New System.Drawing.Point(9, 140)
        Me.lbl_HowToIP.Name = "lbl_HowToIP"
        Me.lbl_HowToIP.Size = New System.Drawing.Size(284, 65)
        Me.lbl_HowToIP.TabIndex = 7
        Me.lbl_HowToIP.Text = "To Check IP On Your Device :" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Settings -> About -> Status -> IP Address"
        Me.lbl_HowToIP.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'lbl_defPort
        '
        Me.lbl_defPort.AutoSize = True
        Me.lbl_defPort.Location = New System.Drawing.Point(177, 38)
        Me.lbl_defPort.Name = "lbl_defPort"
        Me.lbl_defPort.Size = New System.Drawing.Size(148, 15)
        Me.lbl_defPort.TabIndex = 5
        Me.lbl_defPort.Text = "(Default / Standard is 5555)"
        '
        'btn_connectwifi
        '
        Me.btn_connectwifi.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_connectwifi.Location = New System.Drawing.Point(9, 208)
        Me.btn_connectwifi.Name = "btn_connectwifi"
        Me.btn_connectwifi.Size = New System.Drawing.Size(284, 46)
        Me.btn_connectwifi.TabIndex = 4
        Me.btn_connectwifi.Text = "Connect"
        Me.btn_connectwifi.UseVisualStyleBackColor = True
        '
        'lbl_DevIP
        '
        Me.lbl_DevIP.AutoSize = True
        Me.lbl_DevIP.Location = New System.Drawing.Point(6, 88)
        Me.lbl_DevIP.Name = "lbl_DevIP"
        Me.lbl_DevIP.Size = New System.Drawing.Size(115, 15)
        Me.lbl_DevIP.TabIndex = 3
        Me.lbl_DevIP.Text = "Device IP Address :"
        '
        'lbl_port
        '
        Me.lbl_port.AutoSize = True
        Me.lbl_port.Location = New System.Drawing.Point(6, 38)
        Me.lbl_port.Name = "lbl_port"
        Me.lbl_port.Size = New System.Drawing.Size(121, 15)
        Me.lbl_port.TabIndex = 2
        Me.lbl_port.Text = "ADB Port (TCPIP) :"
        '
        'txt_ipaddr
        '
        Me.txt_ipaddr.Location = New System.Drawing.Point(127, 84)
        Me.txt_ipaddr.Name = "txt_ipaddr"
        Me.txt_ipaddr.Size = New System.Drawing.Size(198, 23)
        Me.txt_ipaddr.TabIndex = 1
        '
        'txt_tcpip
        '
        Me.txt_tcpip.Location = New System.Drawing.Point(133, 35)
        Me.txt_tcpip.Name = "txt_tcpip"
        Me.txt_tcpip.Size = New System.Drawing.Size(38, 23)
        Me.txt_tcpip.TabIndex = 0
        Me.txt_tcpip.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'gb_ADBRestart
        '
        Me.gb_ADBRestart.Controls.Add(Me.lbl_tcport)
        Me.gb_ADBRestart.Controls.Add(Me.txt_tcport)
        Me.gb_ADBRestart.Controls.Add(Me.btn_adbTCPIP)
        Me.gb_ADBRestart.Controls.Add(Me.btn_adbUSB)
        Me.gb_ADBRestart.Controls.Add(Me.btn_AdbUnroot)
        Me.gb_ADBRestart.Controls.Add(Me.btn_adbRoot)
        Me.gb_ADBRestart.Cursor = System.Windows.Forms.Cursors.Default
        Me.gb_ADBRestart.Location = New System.Drawing.Point(6, 314)
        Me.gb_ADBRestart.Name = "gb_ADBRestart"
        Me.gb_ADBRestart.Size = New System.Drawing.Size(346, 150)
        Me.gb_ADBRestart.TabIndex = 1
        Me.gb_ADBRestart.TabStop = False
        Me.gb_ADBRestart.Text = "ADB Restart"
        '
        'lbl_tcport
        '
        Me.lbl_tcport.AutoSize = True
        Me.lbl_tcport.Location = New System.Drawing.Point(245, 31)
        Me.lbl_tcport.Name = "lbl_tcport"
        Me.lbl_tcport.Size = New System.Drawing.Size(80, 15)
        Me.lbl_tcport.TabIndex = 5
        Me.lbl_tcport.Text = "TCPIP Port :"
        '
        'txt_tcport
        '
        Me.txt_tcport.Location = New System.Drawing.Point(258, 52)
        Me.txt_tcport.Name = "txt_tcport"
        Me.txt_tcport.Size = New System.Drawing.Size(45, 23)
        Me.txt_tcport.TabIndex = 4
        Me.txt_tcport.Text = "5555"
        Me.txt_tcport.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'btn_adbTCPIP
        '
        Me.btn_adbTCPIP.Location = New System.Drawing.Point(114, 77)
        Me.btn_adbTCPIP.Name = "btn_adbTCPIP"
        Me.btn_adbTCPIP.Size = New System.Drawing.Size(98, 46)
        Me.btn_adbTCPIP.TabIndex = 3
        Me.btn_adbTCPIP.Text = "ADB TCPIP"
        Me.btn_adbTCPIP.UseVisualStyleBackColor = True
        '
        'btn_adbUSB
        '
        Me.btn_adbUSB.Location = New System.Drawing.Point(6, 77)
        Me.btn_adbUSB.Name = "btn_adbUSB"
        Me.btn_adbUSB.Size = New System.Drawing.Size(98, 46)
        Me.btn_adbUSB.TabIndex = 2
        Me.btn_adbUSB.Text = "ADB USB"
        Me.btn_adbUSB.UseVisualStyleBackColor = True
        '
        'btn_AdbUnroot
        '
        Me.btn_AdbUnroot.Location = New System.Drawing.Point(114, 22)
        Me.btn_AdbUnroot.Name = "btn_AdbUnroot"
        Me.btn_AdbUnroot.Size = New System.Drawing.Size(98, 48)
        Me.btn_AdbUnroot.TabIndex = 1
        Me.btn_AdbUnroot.Text = "ADB Unroot"
        Me.btn_AdbUnroot.UseVisualStyleBackColor = True
        '
        'btn_adbRoot
        '
        Me.btn_adbRoot.Location = New System.Drawing.Point(6, 22)
        Me.btn_adbRoot.Name = "btn_adbRoot"
        Me.btn_adbRoot.Size = New System.Drawing.Size(98, 48)
        Me.btn_adbRoot.TabIndex = 0
        Me.btn_adbRoot.Text = "ADB Root"
        Me.btn_adbRoot.UseVisualStyleBackColor = True
        '
        'tb_apkt_sett
        '
        Me.tb_apkt_sett.Controls.Add(Me.lbl_apkt_warn_settings)
        Me.tb_apkt_sett.Controls.Add(Me.gb_apkt_sett)
        Me.tb_apkt_sett.Controls.Add(Me.gb_apkt_comsets)
        Me.tb_apkt_sett.Location = New System.Drawing.Point(4, 24)
        Me.tb_apkt_sett.Name = "tb_apkt_sett"
        Me.tb_apkt_sett.Padding = New System.Windows.Forms.Padding(3)
        Me.tb_apkt_sett.Size = New System.Drawing.Size(398, 481)
        Me.tb_apkt_sett.TabIndex = 1
        Me.tb_apkt_sett.Text = "Apk Editor Settings"
        Me.tb_apkt_sett.UseVisualStyleBackColor = True
        '
        'lbl_apkt_warn_settings
        '
        Me.lbl_apkt_warn_settings.Location = New System.Drawing.Point(12, 405)
        Me.lbl_apkt_warn_settings.Name = "lbl_apkt_warn_settings"
        Me.lbl_apkt_warn_settings.Size = New System.Drawing.Size(332, 51)
        Me.lbl_apkt_warn_settings.TabIndex = 8
        Me.lbl_apkt_warn_settings.Text = "Got stuck on decompiling/compiling? Change and reduce the Heap Size value"
        Me.lbl_apkt_warn_settings.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'gb_apkt_sett
        '
        Me.gb_apkt_sett.Controls.Add(Me.btn_apkt_opendir)
        Me.gb_apkt_sett.Controls.Add(Me.cobo_apkt_opendir)
        Me.gb_apkt_sett.Controls.Add(Me.lbl_apkt_opendir)
        Me.gb_apkt_sett.Controls.Add(Me.btn_apkt_clearfolder)
        Me.gb_apkt_sett.Controls.Add(Me.cobo_apkt_clrfolder)
        Me.gb_apkt_sett.Controls.Add(Me.lbl_apkt_clearfolder)
        Me.gb_apkt_sett.Location = New System.Drawing.Point(6, 254)
        Me.gb_apkt_sett.Name = "gb_apkt_sett"
        Me.gb_apkt_sett.Size = New System.Drawing.Size(341, 135)
        Me.gb_apkt_sett.TabIndex = 3
        Me.gb_apkt_sett.TabStop = False
        Me.gb_apkt_sett.Text = "Settings"
        '
        'btn_apkt_opendir
        '
        Me.btn_apkt_opendir.Enabled = False
        Me.btn_apkt_opendir.Location = New System.Drawing.Point(244, 89)
        Me.btn_apkt_opendir.Name = "btn_apkt_opendir"
        Me.btn_apkt_opendir.Size = New System.Drawing.Size(75, 27)
        Me.btn_apkt_opendir.TabIndex = 11
        Me.btn_apkt_opendir.Text = "Open"
        Me.btn_apkt_opendir.UseVisualStyleBackColor = True
        '
        'cobo_apkt_opendir
        '
        Me.cobo_apkt_opendir.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cobo_apkt_opendir.FormattingEnabled = True
        Me.cobo_apkt_opendir.Items.AddRange(New Object() {"/apk-dir/", "/apk-sign/", "/projects/"})
        Me.cobo_apkt_opendir.Location = New System.Drawing.Point(109, 85)
        Me.cobo_apkt_opendir.Name = "cobo_apkt_opendir"
        Me.cobo_apkt_opendir.Size = New System.Drawing.Size(129, 23)
        Me.cobo_apkt_opendir.TabIndex = 10
        '
        'lbl_apkt_opendir
        '
        Me.lbl_apkt_opendir.AutoSize = True
        Me.lbl_apkt_opendir.Location = New System.Drawing.Point(6, 89)
        Me.lbl_apkt_opendir.Name = "lbl_apkt_opendir"
        Me.lbl_apkt_opendir.Size = New System.Drawing.Size(82, 15)
        Me.lbl_apkt_opendir.TabIndex = 9
        Me.lbl_apkt_opendir.Text = "Open Folder :"
        '
        'btn_apkt_clearfolder
        '
        Me.btn_apkt_clearfolder.Enabled = False
        Me.btn_apkt_clearfolder.Location = New System.Drawing.Point(244, 20)
        Me.btn_apkt_clearfolder.Name = "btn_apkt_clearfolder"
        Me.btn_apkt_clearfolder.Size = New System.Drawing.Size(75, 27)
        Me.btn_apkt_clearfolder.TabIndex = 8
        Me.btn_apkt_clearfolder.Text = "Clear"
        Me.btn_apkt_clearfolder.UseVisualStyleBackColor = True
        '
        'cobo_apkt_clrfolder
        '
        Me.cobo_apkt_clrfolder.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cobo_apkt_clrfolder.FormattingEnabled = True
        Me.cobo_apkt_clrfolder.Items.AddRange(New Object() {"/apk-dir/", "/apk-sign/", "/projects/"})
        Me.cobo_apkt_clrfolder.Location = New System.Drawing.Point(109, 20)
        Me.cobo_apkt_clrfolder.Name = "cobo_apkt_clrfolder"
        Me.cobo_apkt_clrfolder.Size = New System.Drawing.Size(129, 23)
        Me.cobo_apkt_clrfolder.TabIndex = 7
        '
        'lbl_apkt_clearfolder
        '
        Me.lbl_apkt_clearfolder.AutoSize = True
        Me.lbl_apkt_clearfolder.Location = New System.Drawing.Point(6, 23)
        Me.lbl_apkt_clearfolder.Name = "lbl_apkt_clearfolder"
        Me.lbl_apkt_clearfolder.Size = New System.Drawing.Size(81, 15)
        Me.lbl_apkt_clearfolder.TabIndex = 6
        Me.lbl_apkt_clearfolder.Text = "Clear Folder :"
        '
        'gb_apkt_comsets
        '
        Me.gb_apkt_comsets.Controls.Add(Me.lbl_apkt_hz)
        Me.gb_apkt_comsets.Controls.Add(Me.txt_apkt_heapsz)
        Me.gb_apkt_comsets.Controls.Add(Me.cobo_apkt_decompile)
        Me.gb_apkt_comsets.Controls.Add(Me.lbl_apkt_decom)
        Me.gb_apkt_comsets.Controls.Add(Me.cobo_apkt_rescomlv)
        Me.gb_apkt_comsets.Controls.Add(Me.lbl_apkt_rescom)
        Me.gb_apkt_comsets.Controls.Add(Me.cobo_apkt_apkcomlv)
        Me.gb_apkt_comsets.Controls.Add(Me.lbl_apkt_comlv)
        Me.gb_apkt_comsets.Location = New System.Drawing.Point(6, 7)
        Me.gb_apkt_comsets.Name = "gb_apkt_comsets"
        Me.gb_apkt_comsets.Size = New System.Drawing.Size(341, 226)
        Me.gb_apkt_comsets.TabIndex = 2
        Me.gb_apkt_comsets.TabStop = False
        Me.gb_apkt_comsets.Text = "Compressor Settings"
        '
        'lbl_apkt_hz
        '
        Me.lbl_apkt_hz.AutoSize = True
        Me.lbl_apkt_hz.Location = New System.Drawing.Point(7, 167)
        Me.lbl_apkt_hz.Name = "lbl_apkt_hz"
        Me.lbl_apkt_hz.Size = New System.Drawing.Size(68, 15)
        Me.lbl_apkt_hz.TabIndex = 7
        Me.lbl_apkt_hz.Text = "Heap Size :"
        '
        'txt_apkt_heapsz
        '
        Me.txt_apkt_heapsz.Location = New System.Drawing.Point(136, 164)
        Me.txt_apkt_heapsz.MaxLength = 4
        Me.txt_apkt_heapsz.Name = "txt_apkt_heapsz"
        Me.txt_apkt_heapsz.Size = New System.Drawing.Size(71, 23)
        Me.txt_apkt_heapsz.TabIndex = 6
        Me.txt_apkt_heapsz.Text = "1024"
        Me.txt_apkt_heapsz.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'cobo_apkt_decompile
        '
        Me.cobo_apkt_decompile.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cobo_apkt_decompile.FormattingEnabled = True
        Me.cobo_apkt_decompile.Items.AddRange(New Object() {"Sources and Resources Files", "Source Files only", "Resource Files only", "Raw Format Only"})
        Me.cobo_apkt_decompile.Location = New System.Drawing.Point(136, 123)
        Me.cobo_apkt_decompile.Name = "cobo_apkt_decompile"
        Me.cobo_apkt_decompile.Size = New System.Drawing.Size(157, 23)
        Me.cobo_apkt_decompile.TabIndex = 5
        '
        'lbl_apkt_decom
        '
        Me.lbl_apkt_decom.AutoSize = True
        Me.lbl_apkt_decom.Location = New System.Drawing.Point(6, 127)
        Me.lbl_apkt_decom.Name = "lbl_apkt_decom"
        Me.lbl_apkt_decom.Size = New System.Drawing.Size(106, 15)
        Me.lbl_apkt_decom.TabIndex = 4
        Me.lbl_apkt_decom.Text = "Decompile Mode :"
        '
        'cobo_apkt_rescomlv
        '
        Me.cobo_apkt_rescomlv.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cobo_apkt_rescomlv.FormattingEnabled = True
        Me.cobo_apkt_rescomlv.Items.AddRange(New Object() {"0", "1", "2", "3", "4", "5", "6", "7", "8", "9"})
        Me.cobo_apkt_rescomlv.Location = New System.Drawing.Point(222, 77)
        Me.cobo_apkt_rescomlv.Name = "cobo_apkt_rescomlv"
        Me.cobo_apkt_rescomlv.Size = New System.Drawing.Size(71, 23)
        Me.cobo_apkt_rescomlv.TabIndex = 3
        '
        'lbl_apkt_rescom
        '
        Me.lbl_apkt_rescom.AutoSize = True
        Me.lbl_apkt_rescom.Location = New System.Drawing.Point(7, 81)
        Me.lbl_apkt_rescom.Name = "lbl_apkt_rescom"
        Me.lbl_apkt_rescom.Size = New System.Drawing.Size(200, 15)
        Me.lbl_apkt_rescom.TabIndex = 2
        Me.lbl_apkt_rescom.Text = "Resources.arcs Compression Level :"
        '
        'cobo_apkt_apkcomlv
        '
        Me.cobo_apkt_apkcomlv.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cobo_apkt_apkcomlv.FormattingEnabled = True
        Me.cobo_apkt_apkcomlv.Items.AddRange(New Object() {"0", "1", "2", "3", "4", "5", "6", "7", "8", "9"})
        Me.cobo_apkt_apkcomlv.Location = New System.Drawing.Point(179, 31)
        Me.cobo_apkt_apkcomlv.Name = "cobo_apkt_apkcomlv"
        Me.cobo_apkt_apkcomlv.Size = New System.Drawing.Size(114, 23)
        Me.cobo_apkt_apkcomlv.TabIndex = 1
        '
        'lbl_apkt_comlv
        '
        Me.lbl_apkt_comlv.AutoSize = True
        Me.lbl_apkt_comlv.Location = New System.Drawing.Point(7, 35)
        Me.lbl_apkt_comlv.Name = "lbl_apkt_comlv"
        Me.lbl_apkt_comlv.Size = New System.Drawing.Size(142, 15)
        Me.lbl_apkt_comlv.TabIndex = 0
        Me.lbl_apkt_comlv.Text = "Apk Compression Level :"
        '
        'Settings
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(399, 519)
        Me.Controls.Add(Me.TC_Settings)
        Me.Font = New System.Drawing.Font("Minion Pro", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.HelpButton = True
        Me.Name = "Settings"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Settings"
        Me.TC_Settings.ResumeLayout(False)
        Me.Tab_ADBSettings.ResumeLayout(False)
        Me.gb_ADBWifi.ResumeLayout(False)
        Me.gb_ADBWifi.PerformLayout()
        Me.gb_ADBRestart.ResumeLayout(False)
        Me.gb_ADBRestart.PerformLayout()
        Me.tb_apkt_sett.ResumeLayout(False)
        Me.gb_apkt_sett.ResumeLayout(False)
        Me.gb_apkt_sett.PerformLayout()
        Me.gb_apkt_comsets.ResumeLayout(False)
        Me.gb_apkt_comsets.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TC_Settings As TabControl
    Friend WithEvents Tab_ADBSettings As TabPage
    Friend WithEvents gb_ADBWifi As GroupBox
    Friend WithEvents lbl_HowToIP As Label
    Friend WithEvents lbl_defPort As Label
    Friend WithEvents btn_connectwifi As Button
    Friend WithEvents lbl_DevIP As Label
    Friend WithEvents lbl_port As Label
    Friend WithEvents txt_ipaddr As TextBox
    Friend WithEvents txt_tcpip As TextBox
    Friend WithEvents gb_ADBRestart As GroupBox
    Friend WithEvents lbl_tcport As Label
    Friend WithEvents txt_tcport As TextBox
    Friend WithEvents btn_adbTCPIP As Button
    Friend WithEvents btn_adbUSB As Button
    Friend WithEvents btn_AdbUnroot As Button
    Friend WithEvents btn_adbRoot As Button
    Friend WithEvents tb_apkt_sett As TabPage
    Friend WithEvents lbl_apkt_warn_settings As Label
    Friend WithEvents gb_apkt_sett As GroupBox
    Friend WithEvents btn_apkt_opendir As Button
    Friend WithEvents cobo_apkt_opendir As ComboBox
    Friend WithEvents lbl_apkt_opendir As Label
    Friend WithEvents btn_apkt_clearfolder As Button
    Friend WithEvents cobo_apkt_clrfolder As ComboBox
    Friend WithEvents lbl_apkt_clearfolder As Label
    Friend WithEvents gb_apkt_comsets As GroupBox
    Friend WithEvents lbl_apkt_hz As Label
    Friend WithEvents txt_apkt_heapsz As TextBox
    Friend WithEvents cobo_apkt_decompile As ComboBox
    Friend WithEvents lbl_apkt_decom As Label
    Friend WithEvents cobo_apkt_rescomlv As ComboBox
    Friend WithEvents lbl_apkt_rescom As Label
    Friend WithEvents cobo_apkt_apkcomlv As ComboBox
    Friend WithEvents lbl_apkt_comlv As Label
End Class
