<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class More
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
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
        Me.components = New System.ComponentModel.Container()
        Me.tc_Extra = New System.Windows.Forms.TabControl()
        Me.tb_KeyEvent = New System.Windows.Forms.TabPage()
        Me.btn_SwipeSend = New System.Windows.Forms.Button()
        Me.lbl_SwipeDuration = New System.Windows.Forms.Label()
        Me.txt_SwipeDuration = New System.Windows.Forms.TextBox()
        Me.lbl_SwipeY2 = New System.Windows.Forms.Label()
        Me.txt_SwipeY2 = New System.Windows.Forms.TextBox()
        Me.lbl_SwipeY1 = New System.Windows.Forms.Label()
        Me.txt_SwipeY1 = New System.Windows.Forms.TextBox()
        Me.lbl_SwipeX2 = New System.Windows.Forms.Label()
        Me.txt_SwipeX2 = New System.Windows.Forms.TextBox()
        Me.lbl_SwipeX1 = New System.Windows.Forms.Label()
        Me.txt_SwipeX1 = New System.Windows.Forms.TextBox()
        Me.tb_InputKeyEvent = New System.Windows.Forms.TabPage()
        Me.txt_InputKey = New System.Windows.Forms.TextBox()
        Me.lbl_KeyInputTextWarn = New System.Windows.Forms.Label()
        Me.lbl_InputKey = New System.Windows.Forms.Label()
        Me.btn_KeyInputText = New System.Windows.Forms.Button()
        Me.tb_prefNetwork = New System.Windows.Forms.TabPage()
        Me.lbl_network2 = New System.Windows.Forms.Label()
        Me.btn_prefnetwork = New System.Windows.Forms.Button()
        Me.cb_prefnetwork = New System.Windows.Forms.ComboBox()
        Me.lbl_network1 = New System.Windows.Forms.Label()
        Me.tb_Misc = New System.Windows.Forms.TabPage()
        Me.btn_ShowDevice = New System.Windows.Forms.Button()
        Me.gb_ToogleRoot = New System.Windows.Forms.GroupBox()
        Me.btn_ToogleRoot = New System.Windows.Forms.Button()
        Me.cb_ToogleRoot = New System.Windows.Forms.ComboBox()
        Me.btn_TurnOnOffScreen = New System.Windows.Forms.Button()
        Me.btn_Screenshoot = New System.Windows.Forms.Button()
        Me.gb_Dialer = New System.Windows.Forms.GroupBox()
        Me.lbl_inputPhone = New System.Windows.Forms.Label()
        Me.btn_Call = New System.Windows.Forms.Button()
        Me.txt_Dialer = New System.Windows.Forms.TextBox()
        Me.gb_ScreenRecord = New System.Windows.Forms.GroupBox()
        Me.cb_ShowTouches = New System.Windows.Forms.CheckBox()
        Me.lbl_RecordProg = New System.Windows.Forms.Label()
        Me.lbl_Bitrate_2 = New System.Windows.Forms.Label()
        Me.lbl_TimeVid_2 = New System.Windows.Forms.Label()
        Me.lbl_x = New System.Windows.Forms.Label()
        Me.txt_VideoBitrate = New System.Windows.Forms.TextBox()
        Me.txt_VideoTime = New System.Windows.Forms.TextBox()
        Me.txt_VidResH = New System.Windows.Forms.TextBox()
        Me.txt_VidResW = New System.Windows.Forms.TextBox()
        Me.lbl_TimeVid = New System.Windows.Forms.Label()
        Me.lbl_Bitrate = New System.Windows.Forms.Label()
        Me.lbl_VidRes = New System.Windows.Forms.Label()
        Me.btn_RecordVideo = New System.Windows.Forms.Button()
        Me.pb_RecordVideo = New System.Windows.Forms.ProgressBar()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.tc_Extra.SuspendLayout()
        Me.tb_KeyEvent.SuspendLayout()
        Me.tb_InputKeyEvent.SuspendLayout()
        Me.tb_prefNetwork.SuspendLayout()
        Me.tb_Misc.SuspendLayout()
        Me.gb_ToogleRoot.SuspendLayout()
        Me.gb_Dialer.SuspendLayout()
        Me.gb_ScreenRecord.SuspendLayout()
        Me.SuspendLayout()
        '
        'tc_Extra
        '
        Me.tc_Extra.Controls.Add(Me.tb_KeyEvent)
        Me.tc_Extra.Controls.Add(Me.tb_InputKeyEvent)
        Me.tc_Extra.Controls.Add(Me.tb_prefNetwork)
        Me.tc_Extra.Controls.Add(Me.tb_Misc)
        Me.tc_Extra.Font = New System.Drawing.Font("Agency FB", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tc_Extra.Location = New System.Drawing.Point(10, 13)
        Me.tc_Extra.Name = "tc_Extra"
        Me.tc_Extra.SelectedIndex = 0
        Me.tc_Extra.Size = New System.Drawing.Size(286, 190)
        Me.tc_Extra.TabIndex = 8
        '
        'tb_KeyEvent
        '
        Me.tb_KeyEvent.Controls.Add(Me.btn_SwipeSend)
        Me.tb_KeyEvent.Controls.Add(Me.lbl_SwipeDuration)
        Me.tb_KeyEvent.Controls.Add(Me.txt_SwipeDuration)
        Me.tb_KeyEvent.Controls.Add(Me.lbl_SwipeY2)
        Me.tb_KeyEvent.Controls.Add(Me.txt_SwipeY2)
        Me.tb_KeyEvent.Controls.Add(Me.lbl_SwipeY1)
        Me.tb_KeyEvent.Controls.Add(Me.txt_SwipeY1)
        Me.tb_KeyEvent.Controls.Add(Me.lbl_SwipeX2)
        Me.tb_KeyEvent.Controls.Add(Me.txt_SwipeX2)
        Me.tb_KeyEvent.Controls.Add(Me.lbl_SwipeX1)
        Me.tb_KeyEvent.Controls.Add(Me.txt_SwipeX1)
        Me.tb_KeyEvent.Location = New System.Drawing.Point(4, 29)
        Me.tb_KeyEvent.Name = "tb_KeyEvent"
        Me.tb_KeyEvent.Size = New System.Drawing.Size(278, 157)
        Me.tb_KeyEvent.TabIndex = 2
        Me.tb_KeyEvent.Text = "Swipe Key"
        Me.tb_KeyEvent.UseVisualStyleBackColor = True
        '
        'btn_SwipeSend
        '
        Me.btn_SwipeSend.Location = New System.Drawing.Point(155, 83)
        Me.btn_SwipeSend.Name = "btn_SwipeSend"
        Me.btn_SwipeSend.Size = New System.Drawing.Size(110, 32)
        Me.btn_SwipeSend.TabIndex = 10
        Me.btn_SwipeSend.Text = "Send"
        Me.btn_SwipeSend.UseVisualStyleBackColor = True
        '
        'lbl_SwipeDuration
        '
        Me.lbl_SwipeDuration.AutoSize = True
        Me.lbl_SwipeDuration.Location = New System.Drawing.Point(6, 83)
        Me.lbl_SwipeDuration.Name = "lbl_SwipeDuration"
        Me.lbl_SwipeDuration.Size = New System.Drawing.Size(51, 20)
        Me.lbl_SwipeDuration.TabIndex = 9
        Me.lbl_SwipeDuration.Text = "Duration :"
        '
        'txt_SwipeDuration
        '
        Me.txt_SwipeDuration.Location = New System.Drawing.Point(76, 80)
        Me.txt_SwipeDuration.MaxLength = 4
        Me.txt_SwipeDuration.Name = "txt_SwipeDuration"
        Me.txt_SwipeDuration.Size = New System.Drawing.Size(43, 26)
        Me.txt_SwipeDuration.TabIndex = 8
        '
        'lbl_SwipeY2
        '
        Me.lbl_SwipeY2.AutoSize = True
        Me.lbl_SwipeY2.Location = New System.Drawing.Point(151, 51)
        Me.lbl_SwipeY2.Name = "lbl_SwipeY2"
        Me.lbl_SwipeY2.Size = New System.Drawing.Size(63, 20)
        Me.lbl_SwipeY2.TabIndex = 7
        Me.lbl_SwipeY2.Text = "Y2 Postion :"
        '
        'txt_SwipeY2
        '
        Me.txt_SwipeY2.Location = New System.Drawing.Point(221, 48)
        Me.txt_SwipeY2.MaxLength = 4
        Me.txt_SwipeY2.Name = "txt_SwipeY2"
        Me.txt_SwipeY2.Size = New System.Drawing.Size(43, 26)
        Me.txt_SwipeY2.TabIndex = 6
        '
        'lbl_SwipeY1
        '
        Me.lbl_SwipeY1.AutoSize = True
        Me.lbl_SwipeY1.Location = New System.Drawing.Point(154, 10)
        Me.lbl_SwipeY1.Name = "lbl_SwipeY1"
        Me.lbl_SwipeY1.Size = New System.Drawing.Size(60, 20)
        Me.lbl_SwipeY1.TabIndex = 5
        Me.lbl_SwipeY1.Text = "Y1 Postion :"
        '
        'txt_SwipeY1
        '
        Me.txt_SwipeY1.Location = New System.Drawing.Point(224, 7)
        Me.txt_SwipeY1.MaxLength = 4
        Me.txt_SwipeY1.Name = "txt_SwipeY1"
        Me.txt_SwipeY1.Size = New System.Drawing.Size(43, 26)
        Me.txt_SwipeY1.TabIndex = 4
        '
        'lbl_SwipeX2
        '
        Me.lbl_SwipeX2.AutoSize = True
        Me.lbl_SwipeX2.Location = New System.Drawing.Point(5, 48)
        Me.lbl_SwipeX2.Name = "lbl_SwipeX2"
        Me.lbl_SwipeX2.Size = New System.Drawing.Size(61, 20)
        Me.lbl_SwipeX2.TabIndex = 3
        Me.lbl_SwipeX2.Text = "X2 Postion :"
        '
        'txt_SwipeX2
        '
        Me.txt_SwipeX2.Location = New System.Drawing.Point(75, 45)
        Me.txt_SwipeX2.MaxLength = 4
        Me.txt_SwipeX2.Name = "txt_SwipeX2"
        Me.txt_SwipeX2.Size = New System.Drawing.Size(43, 26)
        Me.txt_SwipeX2.TabIndex = 2
        '
        'lbl_SwipeX1
        '
        Me.lbl_SwipeX1.AutoSize = True
        Me.lbl_SwipeX1.Location = New System.Drawing.Point(5, 13)
        Me.lbl_SwipeX1.Name = "lbl_SwipeX1"
        Me.lbl_SwipeX1.Size = New System.Drawing.Size(58, 20)
        Me.lbl_SwipeX1.TabIndex = 1
        Me.lbl_SwipeX1.Text = "X1 Postion :"
        '
        'txt_SwipeX1
        '
        Me.txt_SwipeX1.Location = New System.Drawing.Point(75, 10)
        Me.txt_SwipeX1.MaxLength = 4
        Me.txt_SwipeX1.Name = "txt_SwipeX1"
        Me.txt_SwipeX1.Size = New System.Drawing.Size(43, 26)
        Me.txt_SwipeX1.TabIndex = 0
        '
        'tb_InputKeyEvent
        '
        Me.tb_InputKeyEvent.Controls.Add(Me.txt_InputKey)
        Me.tb_InputKeyEvent.Controls.Add(Me.lbl_KeyInputTextWarn)
        Me.tb_InputKeyEvent.Controls.Add(Me.lbl_InputKey)
        Me.tb_InputKeyEvent.Controls.Add(Me.btn_KeyInputText)
        Me.tb_InputKeyEvent.Location = New System.Drawing.Point(4, 29)
        Me.tb_InputKeyEvent.Name = "tb_InputKeyEvent"
        Me.tb_InputKeyEvent.Padding = New System.Windows.Forms.Padding(3)
        Me.tb_InputKeyEvent.Size = New System.Drawing.Size(278, 157)
        Me.tb_InputKeyEvent.TabIndex = 1
        Me.tb_InputKeyEvent.Text = "Input Key"
        Me.tb_InputKeyEvent.UseVisualStyleBackColor = True
        '
        'txt_InputKey
        '
        Me.txt_InputKey.Location = New System.Drawing.Point(9, 39)
        Me.txt_InputKey.Name = "txt_InputKey"
        Me.txt_InputKey.Size = New System.Drawing.Size(184, 26)
        Me.txt_InputKey.TabIndex = 4
        '
        'lbl_KeyInputTextWarn
        '
        Me.lbl_KeyInputTextWarn.Font = New System.Drawing.Font("Orator Std", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_KeyInputTextWarn.Location = New System.Drawing.Point(3, 86)
        Me.lbl_KeyInputTextWarn.Name = "lbl_KeyInputTextWarn"
        Me.lbl_KeyInputTextWarn.Size = New System.Drawing.Size(269, 50)
        Me.lbl_KeyInputTextWarn.TabIndex = 3
        Me.lbl_KeyInputTextWarn.Text = "Make Sure You are in Text Box or Anything" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "(Some symbol does not work)"
        Me.lbl_KeyInputTextWarn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lbl_InputKey
        '
        Me.lbl_InputKey.AutoSize = True
        Me.lbl_InputKey.Location = New System.Drawing.Point(6, 4)
        Me.lbl_InputKey.Name = "lbl_InputKey"
        Me.lbl_InputKey.Size = New System.Drawing.Size(93, 20)
        Me.lbl_InputKey.TabIndex = 2
        Me.lbl_InputKey.Text = "Input Text to Send :"
        '
        'btn_KeyInputText
        '
        Me.btn_KeyInputText.Enabled = False
        Me.btn_KeyInputText.Location = New System.Drawing.Point(199, 39)
        Me.btn_KeyInputText.Name = "btn_KeyInputText"
        Me.btn_KeyInputText.Size = New System.Drawing.Size(75, 26)
        Me.btn_KeyInputText.TabIndex = 1
        Me.btn_KeyInputText.Text = "Send"
        Me.btn_KeyInputText.UseVisualStyleBackColor = True
        '
        'tb_prefNetwork
        '
        Me.tb_prefNetwork.Controls.Add(Me.lbl_network2)
        Me.tb_prefNetwork.Controls.Add(Me.btn_prefnetwork)
        Me.tb_prefNetwork.Controls.Add(Me.cb_prefnetwork)
        Me.tb_prefNetwork.Controls.Add(Me.lbl_network1)
        Me.tb_prefNetwork.Location = New System.Drawing.Point(4, 29)
        Me.tb_prefNetwork.Name = "tb_prefNetwork"
        Me.tb_prefNetwork.Padding = New System.Windows.Forms.Padding(3)
        Me.tb_prefNetwork.Size = New System.Drawing.Size(278, 157)
        Me.tb_prefNetwork.TabIndex = 3
        Me.tb_prefNetwork.Text = "Network"
        Me.tb_prefNetwork.UseVisualStyleBackColor = True
        '
        'lbl_network2
        '
        Me.lbl_network2.Font = New System.Drawing.Font("Orator Std", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_network2.ForeColor = System.Drawing.Color.Maroon
        Me.lbl_network2.Location = New System.Drawing.Point(7, 83)
        Me.lbl_network2.Name = "lbl_network2"
        Me.lbl_network2.Size = New System.Drawing.Size(265, 45)
        Me.lbl_network2.TabIndex = 3
        Me.lbl_network2.Text = "Sometimes Airplane Mode Is Not Getting Turned Off, Just Turning Off Manually And " &
    "Voila Your Network is Changed.  (For Root Only)"
        Me.lbl_network2.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'btn_prefnetwork
        '
        Me.btn_prefnetwork.Enabled = False
        Me.btn_prefnetwork.Location = New System.Drawing.Point(197, 35)
        Me.btn_prefnetwork.Name = "btn_prefnetwork"
        Me.btn_prefnetwork.Size = New System.Drawing.Size(75, 30)
        Me.btn_prefnetwork.TabIndex = 2
        Me.btn_prefnetwork.Text = "Apply"
        Me.btn_prefnetwork.UseVisualStyleBackColor = True
        '
        'cb_prefnetwork
        '
        Me.cb_prefnetwork.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cb_prefnetwork.FormattingEnabled = True
        Me.cb_prefnetwork.Items.AddRange(New Object() {"GSM Only", "GSM/WCDMA", "GSM/WCDMA/LTE", "WCDMA Only", "WCDMA/LTE", "LTE Only", "CDMA Only", "EvDo Only", "(Auto Mode)", "LTE/CDMA/EvDo"})
        Me.cb_prefnetwork.Location = New System.Drawing.Point(10, 37)
        Me.cb_prefnetwork.Name = "cb_prefnetwork"
        Me.cb_prefnetwork.Size = New System.Drawing.Size(181, 28)
        Me.cb_prefnetwork.TabIndex = 1
        '
        'lbl_network1
        '
        Me.lbl_network1.AutoSize = True
        Me.lbl_network1.Location = New System.Drawing.Point(7, 7)
        Me.lbl_network1.Name = "lbl_network1"
        Me.lbl_network1.Size = New System.Drawing.Size(117, 20)
        Me.lbl_network1.TabIndex = 0
        Me.lbl_network1.Text = "Preferred Network List :"
        '
        'tb_Misc
        '
        Me.tb_Misc.Controls.Add(Me.btn_ShowDevice)
        Me.tb_Misc.Controls.Add(Me.gb_ToogleRoot)
        Me.tb_Misc.Controls.Add(Me.btn_TurnOnOffScreen)
        Me.tb_Misc.Controls.Add(Me.btn_Screenshoot)
        Me.tb_Misc.Location = New System.Drawing.Point(4, 29)
        Me.tb_Misc.Name = "tb_Misc"
        Me.tb_Misc.Padding = New System.Windows.Forms.Padding(3)
        Me.tb_Misc.Size = New System.Drawing.Size(278, 157)
        Me.tb_Misc.TabIndex = 0
        Me.tb_Misc.Text = "Misc"
        Me.tb_Misc.UseVisualStyleBackColor = True
        '
        'btn_ShowDevice
        '
        Me.btn_ShowDevice.Font = New System.Drawing.Font("Agency FB", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_ShowDevice.Location = New System.Drawing.Point(6, 100)
        Me.btn_ShowDevice.Name = "btn_ShowDevice"
        Me.btn_ShowDevice.Size = New System.Drawing.Size(117, 42)
        Me.btn_ShowDevice.TabIndex = 3
        Me.btn_ShowDevice.Text = "Device Info"
        Me.btn_ShowDevice.UseVisualStyleBackColor = True
        '
        'gb_ToogleRoot
        '
        Me.gb_ToogleRoot.Controls.Add(Me.btn_ToogleRoot)
        Me.gb_ToogleRoot.Controls.Add(Me.cb_ToogleRoot)
        Me.gb_ToogleRoot.ForeColor = System.Drawing.Color.Red
        Me.gb_ToogleRoot.Location = New System.Drawing.Point(130, 7)
        Me.gb_ToogleRoot.Name = "gb_ToogleRoot"
        Me.gb_ToogleRoot.Size = New System.Drawing.Size(142, 135)
        Me.gb_ToogleRoot.TabIndex = 2
        Me.gb_ToogleRoot.TabStop = False
        Me.gb_ToogleRoot.Text = "Root Device Only"
        '
        'btn_ToogleRoot
        '
        Me.btn_ToogleRoot.Enabled = False
        Me.btn_ToogleRoot.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_ToogleRoot.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btn_ToogleRoot.Location = New System.Drawing.Point(6, 83)
        Me.btn_ToogleRoot.Name = "btn_ToogleRoot"
        Me.btn_ToogleRoot.Size = New System.Drawing.Size(130, 42)
        Me.btn_ToogleRoot.TabIndex = 1
        Me.btn_ToogleRoot.Text = "OK"
        Me.btn_ToogleRoot.UseVisualStyleBackColor = True
        '
        'cb_ToogleRoot
        '
        Me.cb_ToogleRoot.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cb_ToogleRoot.FormattingEnabled = True
        Me.cb_ToogleRoot.Items.AddRange(New Object() {"Wifi On", "WIfi Off", "Data On", "Data Off", "Stay Awake On", "Stay Awake Off"})
        Me.cb_ToogleRoot.Location = New System.Drawing.Point(6, 30)
        Me.cb_ToogleRoot.Name = "cb_ToogleRoot"
        Me.cb_ToogleRoot.Size = New System.Drawing.Size(129, 28)
        Me.cb_ToogleRoot.TabIndex = 0
        '
        'btn_TurnOnOffScreen
        '
        Me.btn_TurnOnOffScreen.Font = New System.Drawing.Font("Agency FB", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_TurnOnOffScreen.Location = New System.Drawing.Point(6, 54)
        Me.btn_TurnOnOffScreen.Name = "btn_TurnOnOffScreen"
        Me.btn_TurnOnOffScreen.Size = New System.Drawing.Size(117, 42)
        Me.btn_TurnOnOffScreen.TabIndex = 1
        Me.btn_TurnOnOffScreen.Text = "Turn On/Off Screen"
        Me.btn_TurnOnOffScreen.UseVisualStyleBackColor = True
        '
        'btn_Screenshoot
        '
        Me.btn_Screenshoot.Font = New System.Drawing.Font("Agency FB", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Screenshoot.Location = New System.Drawing.Point(5, 6)
        Me.btn_Screenshoot.Name = "btn_Screenshoot"
        Me.btn_Screenshoot.Size = New System.Drawing.Size(117, 42)
        Me.btn_Screenshoot.TabIndex = 0
        Me.btn_Screenshoot.Text = "Screenshoot"
        Me.btn_Screenshoot.UseVisualStyleBackColor = True
        '
        'gb_Dialer
        '
        Me.gb_Dialer.Controls.Add(Me.lbl_inputPhone)
        Me.gb_Dialer.Controls.Add(Me.btn_Call)
        Me.gb_Dialer.Controls.Add(Me.txt_Dialer)
        Me.gb_Dialer.Font = New System.Drawing.Font("Agency FB", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gb_Dialer.Location = New System.Drawing.Point(189, 212)
        Me.gb_Dialer.Name = "gb_Dialer"
        Me.gb_Dialer.Size = New System.Drawing.Size(493, 111)
        Me.gb_Dialer.TabIndex = 7
        Me.gb_Dialer.TabStop = False
        Me.gb_Dialer.Text = "Simulating Dialer"
        '
        'lbl_inputPhone
        '
        Me.lbl_inputPhone.AutoSize = True
        Me.lbl_inputPhone.Location = New System.Drawing.Point(6, 23)
        Me.lbl_inputPhone.Name = "lbl_inputPhone"
        Me.lbl_inputPhone.Size = New System.Drawing.Size(101, 20)
        Me.lbl_inputPhone.TabIndex = 2
        Me.lbl_inputPhone.Text = "Input Phone Number :"
        '
        'btn_Call
        '
        Me.btn_Call.Enabled = False
        Me.btn_Call.Location = New System.Drawing.Point(261, 49)
        Me.btn_Call.Name = "btn_Call"
        Me.btn_Call.Size = New System.Drawing.Size(55, 40)
        Me.btn_Call.TabIndex = 1
        Me.btn_Call.UseVisualStyleBackColor = True
        '
        'txt_Dialer
        '
        Me.txt_Dialer.Location = New System.Drawing.Point(6, 56)
        Me.txt_Dialer.Name = "txt_Dialer"
        Me.txt_Dialer.Size = New System.Drawing.Size(244, 26)
        Me.txt_Dialer.TabIndex = 0
        '
        'gb_ScreenRecord
        '
        Me.gb_ScreenRecord.Controls.Add(Me.cb_ShowTouches)
        Me.gb_ScreenRecord.Controls.Add(Me.lbl_RecordProg)
        Me.gb_ScreenRecord.Controls.Add(Me.lbl_Bitrate_2)
        Me.gb_ScreenRecord.Controls.Add(Me.lbl_TimeVid_2)
        Me.gb_ScreenRecord.Controls.Add(Me.lbl_x)
        Me.gb_ScreenRecord.Controls.Add(Me.txt_VideoBitrate)
        Me.gb_ScreenRecord.Controls.Add(Me.txt_VideoTime)
        Me.gb_ScreenRecord.Controls.Add(Me.txt_VidResH)
        Me.gb_ScreenRecord.Controls.Add(Me.txt_VidResW)
        Me.gb_ScreenRecord.Controls.Add(Me.lbl_TimeVid)
        Me.gb_ScreenRecord.Controls.Add(Me.lbl_Bitrate)
        Me.gb_ScreenRecord.Controls.Add(Me.lbl_VidRes)
        Me.gb_ScreenRecord.Controls.Add(Me.btn_RecordVideo)
        Me.gb_ScreenRecord.Controls.Add(Me.pb_RecordVideo)
        Me.gb_ScreenRecord.Font = New System.Drawing.Font("Agency FB", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gb_ScreenRecord.Location = New System.Drawing.Point(314, 13)
        Me.gb_ScreenRecord.Name = "gb_ScreenRecord"
        Me.gb_ScreenRecord.Size = New System.Drawing.Size(559, 190)
        Me.gb_ScreenRecord.TabIndex = 6
        Me.gb_ScreenRecord.TabStop = False
        Me.gb_ScreenRecord.Text = "Screen Recording (Android 4.4+)"
        '
        'cb_ShowTouches
        '
        Me.cb_ShowTouches.AutoSize = True
        Me.cb_ShowTouches.Location = New System.Drawing.Point(6, 160)
        Me.cb_ShowTouches.Name = "cb_ShowTouches"
        Me.cb_ShowTouches.Size = New System.Drawing.Size(93, 24)
        Me.cb_ShowTouches.TabIndex = 13
        Me.cb_ShowTouches.Text = "Show Touches"
        Me.cb_ShowTouches.UseVisualStyleBackColor = True
        '
        'lbl_RecordProg
        '
        Me.lbl_RecordProg.AutoSize = True
        Me.lbl_RecordProg.Location = New System.Drawing.Point(266, 20)
        Me.lbl_RecordProg.Name = "lbl_RecordProg"
        Me.lbl_RecordProg.Size = New System.Drawing.Size(102, 20)
        Me.lbl_RecordProg.TabIndex = 12
        Me.lbl_RecordProg.Text = "Recording Progress :"
        '
        'lbl_Bitrate_2
        '
        Me.lbl_Bitrate_2.AutoSize = True
        Me.lbl_Bitrate_2.Location = New System.Drawing.Point(132, 116)
        Me.lbl_Bitrate_2.Name = "lbl_Bitrate_2"
        Me.lbl_Bitrate_2.Size = New System.Drawing.Size(102, 20)
        Me.lbl_Bitrate_2.TabIndex = 11
        Me.lbl_Bitrate_2.Text = "(eg. 4000000/4MB)"
        '
        'lbl_TimeVid_2
        '
        Me.lbl_TimeVid_2.AutoSize = True
        Me.lbl_TimeVid_2.Location = New System.Drawing.Point(132, 75)
        Me.lbl_TimeVid_2.Name = "lbl_TimeVid_2"
        Me.lbl_TimeVid_2.Size = New System.Drawing.Size(73, 20)
        Me.lbl_TimeVid_2.TabIndex = 10
        Me.lbl_TimeVid_2.Text = "(Max 180 Sec)"
        '
        'lbl_x
        '
        Me.lbl_x.AutoSize = True
        Me.lbl_x.Location = New System.Drawing.Point(131, 32)
        Me.lbl_x.Name = "lbl_x"
        Me.lbl_x.Size = New System.Drawing.Size(15, 20)
        Me.lbl_x.TabIndex = 9
        Me.lbl_x.Text = "X"
        '
        'txt_VideoBitrate
        '
        Me.txt_VideoBitrate.Location = New System.Drawing.Point(76, 109)
        Me.txt_VideoBitrate.MaxLength = 9
        Me.txt_VideoBitrate.Name = "txt_VideoBitrate"
        Me.txt_VideoBitrate.Size = New System.Drawing.Size(50, 26)
        Me.txt_VideoBitrate.TabIndex = 8
        '
        'txt_VideoTime
        '
        Me.txt_VideoTime.Location = New System.Drawing.Point(76, 68)
        Me.txt_VideoTime.MaxLength = 4
        Me.txt_VideoTime.Name = "txt_VideoTime"
        Me.txt_VideoTime.Size = New System.Drawing.Size(50, 26)
        Me.txt_VideoTime.TabIndex = 7
        '
        'txt_VidResH
        '
        Me.txt_VidResH.Location = New System.Drawing.Point(151, 29)
        Me.txt_VidResH.MaxLength = 4
        Me.txt_VidResH.Name = "txt_VidResH"
        Me.txt_VidResH.Size = New System.Drawing.Size(50, 26)
        Me.txt_VidResH.TabIndex = 6
        '
        'txt_VidResW
        '
        Me.txt_VidResW.Location = New System.Drawing.Point(75, 29)
        Me.txt_VidResW.MaxLength = 4
        Me.txt_VidResW.Name = "txt_VidResW"
        Me.txt_VidResW.Size = New System.Drawing.Size(50, 26)
        Me.txt_VidResW.TabIndex = 5
        '
        'lbl_TimeVid
        '
        Me.lbl_TimeVid.AutoSize = True
        Me.lbl_TimeVid.Location = New System.Drawing.Point(7, 75)
        Me.lbl_TimeVid.Name = "lbl_TimeVid"
        Me.lbl_TimeVid.Size = New System.Drawing.Size(36, 20)
        Me.lbl_TimeVid.TabIndex = 4
        Me.lbl_TimeVid.Text = "Time :"
        '
        'lbl_Bitrate
        '
        Me.lbl_Bitrate.AutoSize = True
        Me.lbl_Bitrate.Location = New System.Drawing.Point(7, 116)
        Me.lbl_Bitrate.Name = "lbl_Bitrate"
        Me.lbl_Bitrate.Size = New System.Drawing.Size(44, 20)
        Me.lbl_Bitrate.TabIndex = 3
        Me.lbl_Bitrate.Text = "Bitrate :"
        '
        'lbl_VidRes
        '
        Me.lbl_VidRes.AutoSize = True
        Me.lbl_VidRes.Location = New System.Drawing.Point(6, 36)
        Me.lbl_VidRes.Name = "lbl_VidRes"
        Me.lbl_VidRes.Size = New System.Drawing.Size(58, 20)
        Me.lbl_VidRes.TabIndex = 2
        Me.lbl_VidRes.Text = "Resolution :"
        '
        'btn_RecordVideo
        '
        Me.btn_RecordVideo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_RecordVideo.Location = New System.Drawing.Point(270, 83)
        Me.btn_RecordVideo.Name = "btn_RecordVideo"
        Me.btn_RecordVideo.Size = New System.Drawing.Size(236, 41)
        Me.btn_RecordVideo.TabIndex = 1
        Me.btn_RecordVideo.Text = "Record Now"
        Me.btn_RecordVideo.UseVisualStyleBackColor = True
        '
        'pb_RecordVideo
        '
        Me.pb_RecordVideo.Location = New System.Drawing.Point(270, 50)
        Me.pb_RecordVideo.Name = "pb_RecordVideo"
        Me.pb_RecordVideo.Size = New System.Drawing.Size(236, 23)
        Me.pb_RecordVideo.TabIndex = 0
        '
        'Timer1
        '
        Me.Timer1.Interval = 1000
        '
        'More
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit
        Me.Controls.Add(Me.tc_Extra)
        Me.Controls.Add(Me.gb_Dialer)
        Me.Controls.Add(Me.gb_ScreenRecord)
        Me.Name = "More"
        Me.Size = New System.Drawing.Size(918, 360)
        Me.tc_Extra.ResumeLayout(False)
        Me.tb_KeyEvent.ResumeLayout(False)
        Me.tb_KeyEvent.PerformLayout()
        Me.tb_InputKeyEvent.ResumeLayout(False)
        Me.tb_InputKeyEvent.PerformLayout()
        Me.tb_prefNetwork.ResumeLayout(False)
        Me.tb_prefNetwork.PerformLayout()
        Me.tb_Misc.ResumeLayout(False)
        Me.gb_ToogleRoot.ResumeLayout(False)
        Me.gb_Dialer.ResumeLayout(False)
        Me.gb_Dialer.PerformLayout()
        Me.gb_ScreenRecord.ResumeLayout(False)
        Me.gb_ScreenRecord.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents tc_Extra As TabControl
    Friend WithEvents tb_KeyEvent As TabPage
    Friend WithEvents btn_SwipeSend As Button
    Friend WithEvents lbl_SwipeDuration As Label
    Friend WithEvents txt_SwipeDuration As TextBox
    Friend WithEvents lbl_SwipeY2 As Label
    Friend WithEvents txt_SwipeY2 As TextBox
    Friend WithEvents lbl_SwipeY1 As Label
    Friend WithEvents txt_SwipeY1 As TextBox
    Friend WithEvents lbl_SwipeX2 As Label
    Friend WithEvents txt_SwipeX2 As TextBox
    Friend WithEvents lbl_SwipeX1 As Label
    Friend WithEvents txt_SwipeX1 As TextBox
    Friend WithEvents tb_InputKeyEvent As TabPage
    Friend WithEvents txt_InputKey As TextBox
    Friend WithEvents lbl_KeyInputTextWarn As Label
    Friend WithEvents lbl_InputKey As Label
    Friend WithEvents btn_KeyInputText As Button
    Friend WithEvents tb_prefNetwork As TabPage
    Friend WithEvents lbl_network2 As Label
    Friend WithEvents btn_prefnetwork As Button
    Friend WithEvents cb_prefnetwork As ComboBox
    Friend WithEvents lbl_network1 As Label
    Friend WithEvents tb_Misc As TabPage
    Friend WithEvents btn_ShowDevice As Button
    Friend WithEvents gb_ToogleRoot As GroupBox
    Friend WithEvents btn_ToogleRoot As Button
    Friend WithEvents cb_ToogleRoot As ComboBox
    Friend WithEvents btn_TurnOnOffScreen As Button
    Friend WithEvents btn_Screenshoot As Button
    Friend WithEvents gb_Dialer As GroupBox
    Friend WithEvents lbl_inputPhone As Label
    Friend WithEvents btn_Call As Button
    Friend WithEvents txt_Dialer As TextBox
    Friend WithEvents gb_ScreenRecord As GroupBox
    Friend WithEvents cb_ShowTouches As CheckBox
    Friend WithEvents lbl_RecordProg As Label
    Friend WithEvents lbl_Bitrate_2 As Label
    Friend WithEvents lbl_TimeVid_2 As Label
    Friend WithEvents lbl_x As Label
    Friend WithEvents txt_VideoBitrate As TextBox
    Friend WithEvents txt_VideoTime As TextBox
    Friend WithEvents txt_VidResH As TextBox
    Friend WithEvents txt_VidResW As TextBox
    Friend WithEvents lbl_TimeVid As Label
    Friend WithEvents lbl_Bitrate As Label
    Friend WithEvents lbl_VidRes As Label
    Friend WithEvents btn_RecordVideo As Button
    Friend WithEvents pb_RecordVideo As ProgressBar
    Friend WithEvents Timer1 As Timer
End Class
