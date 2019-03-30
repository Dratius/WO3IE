<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ADB
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btn_apk_pull = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txt_apkpath = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.cobo_apklist = New System.Windows.Forms.ComboBox()
        Me.RadioButton2 = New System.Windows.Forms.RadioButton()
        Me.RadioButton1 = New System.Windows.Forms.RadioButton()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtx_PullFileName = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lbl_time = New System.Windows.Forms.Label()
        Me.btn_PushBrowse = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txt_PushSDPath = New System.Windows.Forms.TextBox()
        Me.txt_PushPath = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.btn_GetSerialNumber = New System.Windows.Forms.Button()
        Me.btn_DeviceList = New System.Windows.Forms.Button()
        Me.btn_ShellConsole = New System.Windows.Forms.Button()
        Me.txt_Logs = New System.Windows.Forms.TextBox()
        Me.btn_ClearLogs = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.gb_RebootOptions = New System.Windows.Forms.GroupBox()
        Me.btn_Reboot = New System.Windows.Forms.Button()
        Me.cb_RebootOptions = New System.Windows.Forms.ComboBox()
        Me.gb_Sideload = New System.Windows.Forms.GroupBox()
        Me.cb_SideLoad = New System.Windows.Forms.CheckBox()
        Me.btn_Sideload = New System.Windows.Forms.Button()
        Me.txt_SideloadPath = New System.Windows.Forms.TextBox()
        Me.gb_ManualADB = New System.Windows.Forms.GroupBox()
        Me.btn_ExecuteADB = New System.Windows.Forms.Button()
        Me.txt_RunADB = New System.Windows.Forms.TextBox()
        Me.GroupBox1.SuspendLayout()
        Me.gb_RebootOptions.SuspendLayout()
        Me.gb_Sideload.SuspendLayout()
        Me.gb_ManualADB.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btn_apk_pull)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.txt_apkpath)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.cobo_apklist)
        Me.GroupBox1.Controls.Add(Me.RadioButton2)
        Me.GroupBox1.Controls.Add(Me.RadioButton1)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.txtx_PullFileName)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.lbl_time)
        Me.GroupBox1.Controls.Add(Me.btn_PushBrowse)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.txt_PushSDPath)
        Me.GroupBox1.Controls.Add(Me.txt_PushPath)
        Me.GroupBox1.Controls.Add(Me.Button1)
        Me.GroupBox1.Controls.Add(Me.btn_GetSerialNumber)
        Me.GroupBox1.Controls.Add(Me.btn_DeviceList)
        Me.GroupBox1.Controls.Add(Me.btn_ShellConsole)
        Me.GroupBox1.Font = New System.Drawing.Font("Agency FB", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.DarkGreen
        Me.GroupBox1.Location = New System.Drawing.Point(3, 20)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(526, 323)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "ADB Shells"
        '
        'btn_apk_pull
        '
        Me.btn_apk_pull.Enabled = False
        Me.btn_apk_pull.Location = New System.Drawing.Point(363, 194)
        Me.btn_apk_pull.Name = "btn_apk_pull"
        Me.btn_apk_pull.Size = New System.Drawing.Size(98, 63)
        Me.btn_apk_pull.TabIndex = 26
        Me.btn_apk_pull.Text = "Pull"
        Me.btn_apk_pull.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(7, 234)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(53, 20)
        Me.Label4.TabIndex = 25
        Me.Label4.Text = "Apk Path :"
        '
        'txt_apkpath
        '
        Me.txt_apkpath.Location = New System.Drawing.Point(66, 231)
        Me.txt_apkpath.Name = "txt_apkpath"
        Me.txt_apkpath.ReadOnly = True
        Me.txt_apkpath.Size = New System.Drawing.Size(282, 26)
        Me.txt_apkpath.TabIndex = 24
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(0, 194)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(60, 20)
        Me.Label5.TabIndex = 23
        Me.Label5.Text = "Select Apk :"
        '
        'cobo_apklist
        '
        Me.cobo_apklist.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cobo_apklist.FormattingEnabled = True
        Me.cobo_apklist.Location = New System.Drawing.Point(66, 194)
        Me.cobo_apklist.Name = "cobo_apklist"
        Me.cobo_apklist.Size = New System.Drawing.Size(282, 28)
        Me.cobo_apklist.Sorted = True
        Me.cobo_apklist.TabIndex = 22
        '
        'RadioButton2
        '
        Me.RadioButton2.AutoSize = True
        Me.RadioButton2.Location = New System.Drawing.Point(271, 156)
        Me.RadioButton2.Name = "RadioButton2"
        Me.RadioButton2.Size = New System.Drawing.Size(47, 24)
        Me.RadioButton2.TabIndex = 21
        Me.RadioButton2.TabStop = True
        Me.RadioButton2.Text = "PULL"
        Me.RadioButton2.UseVisualStyleBackColor = True
        '
        'RadioButton1
        '
        Me.RadioButton1.AutoSize = True
        Me.RadioButton1.Location = New System.Drawing.Point(183, 156)
        Me.RadioButton1.Name = "RadioButton1"
        Me.RadioButton1.Size = New System.Drawing.Size(51, 24)
        Me.RadioButton1.TabIndex = 20
        Me.RadioButton1.TabStop = True
        Me.RadioButton1.Text = "PUSH"
        Me.RadioButton1.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(397, 100)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(52, 20)
        Me.Label3.TabIndex = 19
        Me.Label3.Text = "File Name:"
        '
        'txtx_PullFileName
        '
        Me.txtx_PullFileName.Enabled = False
        Me.txtx_PullFileName.Location = New System.Drawing.Point(401, 123)
        Me.txtx_PullFileName.Name = "txtx_PullFileName"
        Me.txtx_PullFileName.Size = New System.Drawing.Size(119, 26)
        Me.txtx_PullFileName.TabIndex = 18
        Me.txtx_PullFileName.Text = "Eg: example.mp3"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(112, 100)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(80, 20)
        Me.Label2.TabIndex = 17
        Me.Label2.Text = "Push to Android:"
        '
        'lbl_time
        '
        Me.lbl_time.AutoSize = True
        Me.lbl_time.Location = New System.Drawing.Point(493, 22)
        Me.lbl_time.Name = "lbl_time"
        Me.lbl_time.Size = New System.Drawing.Size(27, 20)
        Me.lbl_time.TabIndex = 15
        Me.lbl_time.Text = "time"
        Me.lbl_time.Visible = False
        '
        'btn_PushBrowse
        '
        Me.btn_PushBrowse.Font = New System.Drawing.Font("Agency FB", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_PushBrowse.Location = New System.Drawing.Point(400, 61)
        Me.btn_PushBrowse.Name = "btn_PushBrowse"
        Me.btn_PushBrowse.Size = New System.Drawing.Size(120, 25)
        Me.btn_PushBrowse.TabIndex = 16
        Me.btn_PushBrowse.Text = "Browse..."
        Me.btn_PushBrowse.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(112, 38)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(54, 20)
        Me.Label1.TabIndex = 14
        Me.Label1.Text = "Select File:"
        '
        'txt_PushSDPath
        '
        Me.txt_PushSDPath.Location = New System.Drawing.Point(112, 123)
        Me.txt_PushSDPath.Name = "txt_PushSDPath"
        Me.txt_PushSDPath.Size = New System.Drawing.Size(282, 26)
        Me.txt_PushSDPath.TabIndex = 13
        Me.txt_PushSDPath.Text = "Eg: /sdcard"
        '
        'txt_PushPath
        '
        Me.txt_PushPath.Location = New System.Drawing.Point(112, 61)
        Me.txt_PushPath.Name = "txt_PushPath"
        Me.txt_PushPath.ReadOnly = True
        Me.txt_PushPath.Size = New System.Drawing.Size(282, 26)
        Me.txt_PushPath.TabIndex = 12
        '
        'Button1
        '
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button1.Location = New System.Drawing.Point(0, 43)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(106, 106)
        Me.Button1.TabIndex = 11
        Me.Button1.Text = "Pull or Push"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'btn_GetSerialNumber
        '
        Me.btn_GetSerialNumber.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_GetSerialNumber.Location = New System.Drawing.Point(0, 280)
        Me.btn_GetSerialNumber.Name = "btn_GetSerialNumber"
        Me.btn_GetSerialNumber.Size = New System.Drawing.Size(171, 36)
        Me.btn_GetSerialNumber.TabIndex = 10
        Me.btn_GetSerialNumber.Text = "Device Serial Number"
        Me.btn_GetSerialNumber.UseVisualStyleBackColor = True
        '
        'btn_DeviceList
        '
        Me.btn_DeviceList.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_DeviceList.Location = New System.Drawing.Point(354, 283)
        Me.btn_DeviceList.Name = "btn_DeviceList"
        Me.btn_DeviceList.Size = New System.Drawing.Size(171, 34)
        Me.btn_DeviceList.TabIndex = 9
        Me.btn_DeviceList.Text = "Devices List"
        Me.btn_DeviceList.UseVisualStyleBackColor = True
        '
        'btn_ShellConsole
        '
        Me.btn_ShellConsole.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_ShellConsole.Location = New System.Drawing.Point(177, 281)
        Me.btn_ShellConsole.Name = "btn_ShellConsole"
        Me.btn_ShellConsole.Size = New System.Drawing.Size(171, 36)
        Me.btn_ShellConsole.TabIndex = 7
        Me.btn_ShellConsole.Text = "Shell Console"
        Me.btn_ShellConsole.UseVisualStyleBackColor = True
        '
        'txt_Logs
        '
        Me.txt_Logs.Cursor = System.Windows.Forms.Cursors.Default
        Me.txt_Logs.Font = New System.Drawing.Font("Adobe Heiti Std R", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_Logs.Location = New System.Drawing.Point(3, 379)
        Me.txt_Logs.Multiline = True
        Me.txt_Logs.Name = "txt_Logs"
        Me.txt_Logs.ReadOnly = True
        Me.txt_Logs.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txt_Logs.Size = New System.Drawing.Size(879, 126)
        Me.txt_Logs.TabIndex = 1
        Me.txt_Logs.WordWrap = False
        '
        'btn_ClearLogs
        '
        Me.btn_ClearLogs.Font = New System.Drawing.Font("Maiandra GD", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_ClearLogs.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_ClearLogs.Location = New System.Drawing.Point(344, 511)
        Me.btn_ClearLogs.Name = "btn_ClearLogs"
        Me.btn_ClearLogs.Size = New System.Drawing.Size(151, 43)
        Me.btn_ClearLogs.TabIndex = 2
        Me.btn_ClearLogs.Text = "Clear Logs"
        Me.btn_ClearLogs.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Maiandra GD", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(4, 363)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(41, 16)
        Me.Label6.TabIndex = 26
        Me.Label6.Text = "LOGS"
        '
        'gb_RebootOptions
        '
        Me.gb_RebootOptions.Controls.Add(Me.btn_Reboot)
        Me.gb_RebootOptions.Controls.Add(Me.cb_RebootOptions)
        Me.gb_RebootOptions.Font = New System.Drawing.Font("Agency FB", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gb_RebootOptions.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.gb_RebootOptions.Location = New System.Drawing.Point(550, 143)
        Me.gb_RebootOptions.Name = "gb_RebootOptions"
        Me.gb_RebootOptions.Size = New System.Drawing.Size(180, 92)
        Me.gb_RebootOptions.TabIndex = 27
        Me.gb_RebootOptions.TabStop = False
        Me.gb_RebootOptions.Text = "Reboot Options"
        '
        'btn_Reboot
        '
        Me.btn_Reboot.Enabled = False
        Me.btn_Reboot.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Reboot.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_Reboot.Location = New System.Drawing.Point(6, 55)
        Me.btn_Reboot.Name = "btn_Reboot"
        Me.btn_Reboot.Size = New System.Drawing.Size(161, 25)
        Me.btn_Reboot.TabIndex = 1
        Me.btn_Reboot.Text = "Reboot Now"
        Me.btn_Reboot.UseVisualStyleBackColor = True
        '
        'cb_RebootOptions
        '
        Me.cb_RebootOptions.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cb_RebootOptions.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cb_RebootOptions.FormattingEnabled = True
        Me.cb_RebootOptions.Items.AddRange(New Object() {"Normal Reboot", "Recovery", "Bootloader"})
        Me.cb_RebootOptions.Location = New System.Drawing.Point(7, 20)
        Me.cb_RebootOptions.Name = "cb_RebootOptions"
        Me.cb_RebootOptions.Size = New System.Drawing.Size(160, 23)
        Me.cb_RebootOptions.TabIndex = 0
        '
        'gb_Sideload
        '
        Me.gb_Sideload.Controls.Add(Me.cb_SideLoad)
        Me.gb_Sideload.Controls.Add(Me.btn_Sideload)
        Me.gb_Sideload.Controls.Add(Me.txt_SideloadPath)
        Me.gb_Sideload.Font = New System.Drawing.Font("Agency FB", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gb_Sideload.Location = New System.Drawing.Point(550, 251)
        Me.gb_Sideload.Name = "gb_Sideload"
        Me.gb_Sideload.Size = New System.Drawing.Size(352, 54)
        Me.gb_Sideload.TabIndex = 28
        Me.gb_Sideload.TabStop = False
        Me.gb_Sideload.Text = "Sideload"
        '
        'cb_SideLoad
        '
        Me.cb_SideLoad.AutoSize = True
        Me.cb_SideLoad.Location = New System.Drawing.Point(6, 22)
        Me.cb_SideLoad.Name = "cb_SideLoad"
        Me.cb_SideLoad.Size = New System.Drawing.Size(48, 22)
        Me.cb_SideLoad.TabIndex = 3
        Me.cb_SideLoad.Text = "6.0+"
        Me.cb_SideLoad.UseVisualStyleBackColor = True
        '
        'btn_Sideload
        '
        Me.btn_Sideload.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Sideload.Location = New System.Drawing.Point(283, 13)
        Me.btn_Sideload.Name = "btn_Sideload"
        Me.btn_Sideload.Size = New System.Drawing.Size(63, 33)
        Me.btn_Sideload.TabIndex = 2
        Me.btn_Sideload.Text = "Flash"
        Me.btn_Sideload.UseVisualStyleBackColor = True
        '
        'txt_SideloadPath
        '
        Me.txt_SideloadPath.Location = New System.Drawing.Point(59, 20)
        Me.txt_SideloadPath.Name = "txt_SideloadPath"
        Me.txt_SideloadPath.ReadOnly = True
        Me.txt_SideloadPath.Size = New System.Drawing.Size(218, 25)
        Me.txt_SideloadPath.TabIndex = 0
        '
        'gb_ManualADB
        '
        Me.gb_ManualADB.Controls.Add(Me.btn_ExecuteADB)
        Me.gb_ManualADB.Controls.Add(Me.txt_RunADB)
        Me.gb_ManualADB.Font = New System.Drawing.Font("Agency FB", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gb_ManualADB.Location = New System.Drawing.Point(550, 63)
        Me.gb_ManualADB.Name = "gb_ManualADB"
        Me.gb_ManualADB.Size = New System.Drawing.Size(355, 58)
        Me.gb_ManualADB.TabIndex = 29
        Me.gb_ManualADB.TabStop = False
        Me.gb_ManualADB.Text = "ADB Manual Commands"
        '
        'btn_ExecuteADB
        '
        Me.btn_ExecuteADB.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_ExecuteADB.Location = New System.Drawing.Point(299, 26)
        Me.btn_ExecuteADB.Name = "btn_ExecuteADB"
        Me.btn_ExecuteADB.Size = New System.Drawing.Size(39, 23)
        Me.btn_ExecuteADB.TabIndex = 1
        Me.btn_ExecuteADB.Text = ">"
        Me.btn_ExecuteADB.UseVisualStyleBackColor = True
        '
        'txt_RunADB
        '
        Me.txt_RunADB.Location = New System.Drawing.Point(6, 24)
        Me.txt_RunADB.Name = "txt_RunADB"
        Me.txt_RunADB.Size = New System.Drawing.Size(274, 25)
        Me.txt_RunADB.TabIndex = 0
        '
        'ADB
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit
        Me.Controls.Add(Me.gb_ManualADB)
        Me.Controls.Add(Me.gb_Sideload)
        Me.Controls.Add(Me.gb_RebootOptions)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.btn_ClearLogs)
        Me.Controls.Add(Me.txt_Logs)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "ADB"
        Me.Size = New System.Drawing.Size(918, 557)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.gb_RebootOptions.ResumeLayout(False)
        Me.gb_Sideload.ResumeLayout(False)
        Me.gb_Sideload.PerformLayout()
        Me.gb_ManualADB.ResumeLayout(False)
        Me.gb_ManualADB.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Button1 As Button
    Friend WithEvents btn_GetSerialNumber As Button
    Friend WithEvents btn_DeviceList As Button
    Friend WithEvents btn_ShellConsole As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents lbl_time As Label
    Friend WithEvents btn_PushBrowse As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents txt_PushSDPath As TextBox
    Friend WithEvents txt_PushPath As TextBox
    Friend WithEvents RadioButton2 As RadioButton
    Friend WithEvents RadioButton1 As RadioButton
    Friend WithEvents Label3 As Label
    Friend WithEvents txtx_PullFileName As TextBox
    Friend WithEvents btn_apk_pull As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents txt_apkpath As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents cobo_apklist As ComboBox
    Public WithEvents txt_Logs As TextBox
    Friend WithEvents btn_ClearLogs As Button
    Friend WithEvents Label6 As Label
    Friend WithEvents gb_RebootOptions As GroupBox
    Friend WithEvents btn_Reboot As Button
    Friend WithEvents cb_RebootOptions As ComboBox
    Friend WithEvents gb_Sideload As GroupBox
    Friend WithEvents cb_SideLoad As CheckBox
    Friend WithEvents btn_Sideload As Button
    Friend WithEvents txt_SideloadPath As TextBox
    Friend WithEvents gb_ManualADB As GroupBox
    Friend WithEvents btn_ExecuteADB As Button
    Friend WithEvents txt_RunADB As TextBox
End Class
