<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Android
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
        Me.components = New System.ComponentModel.Container()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.lbl_Battery = New System.Windows.Forms.Label()
        Me.pb_BatteryBar = New System.Windows.Forms.ProgressBar()
        Me.lbl_Batt = New System.Windows.Forms.Label()
        Me.lbl_DevInfo = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Buttonpps = New System.Windows.Forms.Button()
        Me.ButtonFstbt = New System.Windows.Forms.Button()
        Me.PanelBottom = New System.Windows.Forms.Panel()
        Me.ButtonAdb = New System.Windows.Forms.Button()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.Adb1 = New Global.WindowsApp4.ADB()
        Me.FastBoot1 = New Global.WindowsApp4.FastBoot()
        Me.Interference1 = New Global.WindowsApp4.Interference()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.HotTrack
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(10, 631)
        Me.Panel1.TabIndex = 0
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.lbl_Battery)
        Me.Panel2.Controls.Add(Me.pb_BatteryBar)
        Me.Panel2.Controls.Add(Me.lbl_Batt)
        Me.Panel2.Controls.Add(Me.lbl_DevInfo)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel2.Location = New System.Drawing.Point(10, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(107, 631)
        Me.Panel2.TabIndex = 1
        '
        'lbl_Battery
        '
        Me.lbl_Battery.AutoSize = True
        Me.lbl_Battery.Font = New System.Drawing.Font("High Tower Text", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Battery.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lbl_Battery.Location = New System.Drawing.Point(40, 59)
        Me.lbl_Battery.Name = "lbl_Battery"
        Me.lbl_Battery.Size = New System.Drawing.Size(12, 15)
        Me.lbl_Battery.TabIndex = 13
        Me.lbl_Battery.Text = "-"
        '
        'pb_BatteryBar
        '
        Me.pb_BatteryBar.Location = New System.Drawing.Point(3, 34)
        Me.pb_BatteryBar.MarqueeAnimationSpeed = 10
        Me.pb_BatteryBar.Name = "pb_BatteryBar"
        Me.pb_BatteryBar.Size = New System.Drawing.Size(98, 18)
        Me.pb_BatteryBar.TabIndex = 12
        '
        'lbl_Batt
        '
        Me.lbl_Batt.AutoSize = True
        Me.lbl_Batt.Font = New System.Drawing.Font("High Tower Text", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Batt.ForeColor = System.Drawing.Color.Green
        Me.lbl_Batt.Location = New System.Drawing.Point(6, 9)
        Me.lbl_Batt.Name = "lbl_Batt"
        Me.lbl_Batt.Size = New System.Drawing.Size(78, 22)
        Me.lbl_Batt.TabIndex = 11
        Me.lbl_Batt.Text = "Battery :"
        '
        'lbl_DevInfo
        '
        Me.lbl_DevInfo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_DevInfo.ForeColor = System.Drawing.Color.Red
        Me.lbl_DevInfo.Location = New System.Drawing.Point(6, 137)
        Me.lbl_DevInfo.Name = "lbl_DevInfo"
        Me.lbl_DevInfo.Size = New System.Drawing.Size(95, 73)
        Me.lbl_DevInfo.TabIndex = 10
        Me.lbl_DevInfo.Text = "No Device Detected"
        Me.lbl_DevInfo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.Button5)
        Me.Panel3.Controls.Add(Me.Button4)
        Me.Panel3.Controls.Add(Me.Buttonpps)
        Me.Panel3.Controls.Add(Me.ButtonFstbt)
        Me.Panel3.Controls.Add(Me.PanelBottom)
        Me.Panel3.Controls.Add(Me.ButtonAdb)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel3.Location = New System.Drawing.Point(117, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(920, 72)
        Me.Panel3.TabIndex = 3
        '
        'Button5
        '
        Me.Button5.FlatAppearance.BorderColor = System.Drawing.Color.LawnGreen
        Me.Button5.FlatAppearance.BorderSize = 4
        Me.Button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button5.Font = New System.Drawing.Font("High Tower Text", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button5.Location = New System.Drawing.Point(494, 22)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(116, 30)
        Me.Button5.TabIndex = 5
        Me.Button5.Text = "ADB"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.FlatAppearance.BorderColor = System.Drawing.Color.LawnGreen
        Me.Button4.FlatAppearance.BorderSize = 4
        Me.Button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button4.Font = New System.Drawing.Font("High Tower Text", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.Location = New System.Drawing.Point(372, 22)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(116, 30)
        Me.Button4.TabIndex = 4
        Me.Button4.Text = "ADB"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Buttonpps
        '
        Me.Buttonpps.FlatAppearance.BorderColor = System.Drawing.Color.LawnGreen
        Me.Buttonpps.FlatAppearance.BorderSize = 4
        Me.Buttonpps.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Buttonpps.Font = New System.Drawing.Font("High Tower Text", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Buttonpps.Location = New System.Drawing.Point(250, 22)
        Me.Buttonpps.Name = "Buttonpps"
        Me.Buttonpps.Size = New System.Drawing.Size(116, 30)
        Me.Buttonpps.TabIndex = 3
        Me.Buttonpps.Text = "APPS"
        Me.Buttonpps.UseVisualStyleBackColor = True
        '
        'ButtonFstbt
        '
        Me.ButtonFstbt.FlatAppearance.BorderColor = System.Drawing.Color.LawnGreen
        Me.ButtonFstbt.FlatAppearance.BorderSize = 4
        Me.ButtonFstbt.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonFstbt.Font = New System.Drawing.Font("High Tower Text", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonFstbt.Location = New System.Drawing.Point(128, 22)
        Me.ButtonFstbt.Name = "ButtonFstbt"
        Me.ButtonFstbt.Size = New System.Drawing.Size(116, 30)
        Me.ButtonFstbt.TabIndex = 2
        Me.ButtonFstbt.Text = "FASTBOOT"
        Me.ButtonFstbt.UseVisualStyleBackColor = True
        '
        'PanelBottom
        '
        Me.PanelBottom.BackColor = System.Drawing.Color.Chartreuse
        Me.PanelBottom.Location = New System.Drawing.Point(6, 58)
        Me.PanelBottom.Name = "PanelBottom"
        Me.PanelBottom.Size = New System.Drawing.Size(116, 10)
        Me.PanelBottom.TabIndex = 1
        '
        'ButtonAdb
        '
        Me.ButtonAdb.FlatAppearance.BorderColor = System.Drawing.Color.LawnGreen
        Me.ButtonAdb.FlatAppearance.BorderSize = 4
        Me.ButtonAdb.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonAdb.Font = New System.Drawing.Font("High Tower Text", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonAdb.Location = New System.Drawing.Point(6, 22)
        Me.ButtonAdb.Name = "ButtonAdb"
        Me.ButtonAdb.Size = New System.Drawing.Size(116, 30)
        Me.ButtonAdb.TabIndex = 0
        Me.ButtonAdb.Text = "ADB"
        Me.ButtonAdb.UseVisualStyleBackColor = True
        '
        'Adb1
        '
        Me.Adb1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Adb1.Location = New System.Drawing.Point(117, 72)
        Me.Adb1.Name = "Adb1"
        Me.Adb1.Size = New System.Drawing.Size(920, 559)
        Me.Adb1.TabIndex = 4
        '
        'FastBoot1
        '
        Me.FastBoot1.Location = New System.Drawing.Point(117, 72)
        Me.FastBoot1.Name = "FastBoot1"
        Me.FastBoot1.Size = New System.Drawing.Size(918, 360)
        Me.FastBoot1.TabIndex = 5
        '
        'Interference1
        '
        Me.Interference1.Location = New System.Drawing.Point(116, 72)
        Me.Interference1.Name = "Interference1"
        Me.Interference1.Size = New System.Drawing.Size(918, 360)
        Me.Interference1.TabIndex = 6
        '
        'Android
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1037, 631)
        Me.Controls.Add(Me.Interference1)
        Me.Controls.Add(Me.FastBoot1)
        Me.Controls.Add(Me.Adb1)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "Android"
        Me.ShowIcon = False
        Me.Text = "Android Tools"
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Button5 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Buttonpps As Button
    Friend WithEvents ButtonFstbt As Button
    Friend WithEvents PanelBottom As Panel
    Friend WithEvents ButtonAdb As Button
    Friend WithEvents Adb1 As Global.WindowsApp4.ADB
    Friend WithEvents pb_BatteryBar As ProgressBar
    Friend WithEvents lbl_Batt As Label
    Friend WithEvents lbl_DevInfo As Label
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents lbl_Battery As Label
    Friend WithEvents FastBoot1 As Global.WindowsApp4.FastBoot
    Friend WithEvents Interference1 As Global.WindowsApp4.Interference
End Class
