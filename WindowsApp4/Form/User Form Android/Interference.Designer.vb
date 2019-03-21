<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Interference
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
        Me.rb_FilterAppAll = New System.Windows.Forms.RadioButton()
        Me.rb_FilterSystemApp = New System.Windows.Forms.RadioButton()
        Me.rb_FilterAppUser = New System.Windows.Forms.RadioButton()
        Me.list_APK = New System.Windows.Forms.ListBox()
        Me.gb_APKOptions = New System.Windows.Forms.GroupBox()
        Me.lbl_time = New System.Windows.Forms.Label()
        Me.rb_All = New System.Windows.Forms.RadioButton()
        Me.rb_AllApp = New System.Windows.Forms.RadioButton()
        Me.rb_SelectedAppOnly = New System.Windows.Forms.RadioButton()
        Me.btn_RestoreAPK = New System.Windows.Forms.Button()
        Me.btn_ClearAPKData = New System.Windows.Forms.Button()
        Me.btn_BackupAPK = New System.Windows.Forms.Button()
        Me.btn_RunAPK = New System.Windows.Forms.Button()
        Me.btn_ForceCloseAPK = New System.Windows.Forms.Button()
        Me.btn_InstallAPK = New System.Windows.Forms.Button()
        Me.btn_RefreshListAPK = New System.Windows.Forms.Button()
        Me.btn_UninstallAPK = New System.Windows.Forms.Button()
        Me.lbl_warn3 = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.gb_APKOptions.SuspendLayout()
        Me.SuspendLayout()
        '
        'rb_FilterAppAll
        '
        Me.rb_FilterAppAll.AutoSize = True
        Me.rb_FilterAppAll.Font = New System.Drawing.Font("Agency FB", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rb_FilterAppAll.Location = New System.Drawing.Point(599, 159)
        Me.rb_FilterAppAll.Name = "rb_FilterAppAll"
        Me.rb_FilterAppAll.Size = New System.Drawing.Size(116, 24)
        Me.rb_FilterAppAll.TabIndex = 26
        Me.rb_FilterAppAll.Text = "User  + System App"
        Me.rb_FilterAppAll.UseVisualStyleBackColor = True
        '
        'rb_FilterSystemApp
        '
        Me.rb_FilterSystemApp.AutoSize = True
        Me.rb_FilterSystemApp.Font = New System.Drawing.Font("Agency FB", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rb_FilterSystemApp.Location = New System.Drawing.Point(599, 89)
        Me.rb_FilterSystemApp.Name = "rb_FilterSystemApp"
        Me.rb_FilterSystemApp.Size = New System.Drawing.Size(79, 24)
        Me.rb_FilterSystemApp.TabIndex = 25
        Me.rb_FilterSystemApp.Text = "System App"
        Me.rb_FilterSystemApp.UseVisualStyleBackColor = True
        '
        'rb_FilterAppUser
        '
        Me.rb_FilterAppUser.AutoSize = True
        Me.rb_FilterAppUser.Checked = True
        Me.rb_FilterAppUser.Font = New System.Drawing.Font("Agency FB", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rb_FilterAppUser.Location = New System.Drawing.Point(599, 19)
        Me.rb_FilterAppUser.Name = "rb_FilterAppUser"
        Me.rb_FilterAppUser.Size = New System.Drawing.Size(67, 24)
        Me.rb_FilterAppUser.TabIndex = 24
        Me.rb_FilterAppUser.TabStop = True
        Me.rb_FilterAppUser.Text = "User App"
        Me.rb_FilterAppUser.UseVisualStyleBackColor = True
        '
        'list_APK
        '
        Me.list_APK.Font = New System.Drawing.Font("Agency FB", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.list_APK.FormattingEnabled = True
        Me.list_APK.ItemHeight = 20
        Me.list_APK.Location = New System.Drawing.Point(3, 19)
        Me.list_APK.Name = "list_APK"
        Me.list_APK.ScrollAlwaysVisible = True
        Me.list_APK.Size = New System.Drawing.Size(564, 164)
        Me.list_APK.Sorted = True
        Me.list_APK.TabIndex = 23
        '
        'gb_APKOptions
        '
        Me.gb_APKOptions.Controls.Add(Me.lbl_time)
        Me.gb_APKOptions.Controls.Add(Me.rb_All)
        Me.gb_APKOptions.Controls.Add(Me.rb_AllApp)
        Me.gb_APKOptions.Controls.Add(Me.rb_SelectedAppOnly)
        Me.gb_APKOptions.Controls.Add(Me.btn_RestoreAPK)
        Me.gb_APKOptions.Controls.Add(Me.btn_ClearAPKData)
        Me.gb_APKOptions.Controls.Add(Me.btn_BackupAPK)
        Me.gb_APKOptions.Controls.Add(Me.btn_RunAPK)
        Me.gb_APKOptions.Controls.Add(Me.btn_ForceCloseAPK)
        Me.gb_APKOptions.Controls.Add(Me.btn_InstallAPK)
        Me.gb_APKOptions.Controls.Add(Me.btn_RefreshListAPK)
        Me.gb_APKOptions.Controls.Add(Me.btn_UninstallAPK)
        Me.gb_APKOptions.Font = New System.Drawing.Font("Agency FB", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gb_APKOptions.Location = New System.Drawing.Point(3, 219)
        Me.gb_APKOptions.Name = "gb_APKOptions"
        Me.gb_APKOptions.Size = New System.Drawing.Size(837, 125)
        Me.gb_APKOptions.TabIndex = 27
        Me.gb_APKOptions.TabStop = False
        Me.gb_APKOptions.Text = "Options"
        '
        'lbl_time
        '
        Me.lbl_time.AutoSize = True
        Me.lbl_time.Location = New System.Drawing.Point(804, 19)
        Me.lbl_time.Name = "lbl_time"
        Me.lbl_time.Size = New System.Drawing.Size(27, 20)
        Me.lbl_time.TabIndex = 22
        Me.lbl_time.Text = "time"
        Me.lbl_time.Visible = False
        '
        'rb_All
        '
        Me.rb_All.AutoSize = True
        Me.rb_All.Location = New System.Drawing.Point(568, 86)
        Me.rb_All.Name = "rb_All"
        Me.rb_All.Size = New System.Drawing.Size(189, 24)
        Me.rb_All.TabIndex = 21
        Me.rb_All.Text = "All Applications + System Applications" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.rb_All.UseVisualStyleBackColor = True
        '
        'rb_AllApp
        '
        Me.rb_AllApp.AutoSize = True
        Me.rb_AllApp.Location = New System.Drawing.Point(568, 56)
        Me.rb_AllApp.Name = "rb_AllApp"
        Me.rb_AllApp.Size = New System.Drawing.Size(90, 24)
        Me.rb_AllApp.TabIndex = 20
        Me.rb_AllApp.Text = "All Applications"
        Me.rb_AllApp.UseVisualStyleBackColor = True
        '
        'rb_SelectedAppOnly
        '
        Me.rb_SelectedAppOnly.AutoSize = True
        Me.rb_SelectedAppOnly.Checked = True
        Me.rb_SelectedAppOnly.Location = New System.Drawing.Point(568, 25)
        Me.rb_SelectedAppOnly.Name = "rb_SelectedAppOnly"
        Me.rb_SelectedAppOnly.Size = New System.Drawing.Size(82, 24)
        Me.rb_SelectedAppOnly.TabIndex = 19
        Me.rb_SelectedAppOnly.TabStop = True
        Me.rb_SelectedAppOnly.Text = "Selected App"
        Me.rb_SelectedAppOnly.UseVisualStyleBackColor = True
        '
        'btn_RestoreAPK
        '
        Me.btn_RestoreAPK.Font = New System.Drawing.Font("Agency FB", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_RestoreAPK.Location = New System.Drawing.Point(326, 34)
        Me.btn_RestoreAPK.Name = "btn_RestoreAPK"
        Me.btn_RestoreAPK.Size = New System.Drawing.Size(91, 60)
        Me.btn_RestoreAPK.TabIndex = 18
        Me.btn_RestoreAPK.Text = "Restore"
        Me.btn_RestoreAPK.UseVisualStyleBackColor = True
        '
        'btn_ClearAPKData
        '
        Me.btn_ClearAPKData.Enabled = False
        Me.btn_ClearAPKData.Font = New System.Drawing.Font("Agency FB", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_ClearAPKData.Location = New System.Drawing.Point(229, 19)
        Me.btn_ClearAPKData.Name = "btn_ClearAPKData"
        Me.btn_ClearAPKData.Size = New System.Drawing.Size(91, 38)
        Me.btn_ClearAPKData.TabIndex = 12
        Me.btn_ClearAPKData.Text = "Clear Data"
        Me.btn_ClearAPKData.UseVisualStyleBackColor = True
        '
        'btn_BackupAPK
        '
        Me.btn_BackupAPK.Enabled = False
        Me.btn_BackupAPK.Font = New System.Drawing.Font("Agency FB", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_BackupAPK.Location = New System.Drawing.Point(471, 20)
        Me.btn_BackupAPK.Name = "btn_BackupAPK"
        Me.btn_BackupAPK.Size = New System.Drawing.Size(91, 88)
        Me.btn_BackupAPK.TabIndex = 16
        Me.btn_BackupAPK.Text = "Backup"
        Me.btn_BackupAPK.UseVisualStyleBackColor = True
        '
        'btn_RunAPK
        '
        Me.btn_RunAPK.Enabled = False
        Me.btn_RunAPK.Font = New System.Drawing.Font("Agency FB", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_RunAPK.Location = New System.Drawing.Point(6, 63)
        Me.btn_RunAPK.Name = "btn_RunAPK"
        Me.btn_RunAPK.Size = New System.Drawing.Size(91, 38)
        Me.btn_RunAPK.TabIndex = 15
        Me.btn_RunAPK.Text = "Run App"
        Me.btn_RunAPK.UseVisualStyleBackColor = True
        '
        'btn_ForceCloseAPK
        '
        Me.btn_ForceCloseAPK.Enabled = False
        Me.btn_ForceCloseAPK.Font = New System.Drawing.Font("Agency FB", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_ForceCloseAPK.Location = New System.Drawing.Point(117, 63)
        Me.btn_ForceCloseAPK.Name = "btn_ForceCloseAPK"
        Me.btn_ForceCloseAPK.Size = New System.Drawing.Size(91, 38)
        Me.btn_ForceCloseAPK.TabIndex = 14
        Me.btn_ForceCloseAPK.Text = "Force Close"
        Me.btn_ForceCloseAPK.UseVisualStyleBackColor = True
        '
        'btn_InstallAPK
        '
        Me.btn_InstallAPK.Font = New System.Drawing.Font("Agency FB", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_InstallAPK.Location = New System.Drawing.Point(6, 19)
        Me.btn_InstallAPK.Name = "btn_InstallAPK"
        Me.btn_InstallAPK.Size = New System.Drawing.Size(91, 38)
        Me.btn_InstallAPK.TabIndex = 13
        Me.btn_InstallAPK.Text = "Install"
        Me.btn_InstallAPK.UseVisualStyleBackColor = True
        '
        'btn_RefreshListAPK
        '
        Me.btn_RefreshListAPK.Font = New System.Drawing.Font("Agency FB", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_RefreshListAPK.Location = New System.Drawing.Point(229, 63)
        Me.btn_RefreshListAPK.Name = "btn_RefreshListAPK"
        Me.btn_RefreshListAPK.Size = New System.Drawing.Size(91, 38)
        Me.btn_RefreshListAPK.TabIndex = 8
        Me.btn_RefreshListAPK.Text = "Refresh"
        Me.btn_RefreshListAPK.UseVisualStyleBackColor = True
        '
        'btn_UninstallAPK
        '
        Me.btn_UninstallAPK.Enabled = False
        Me.btn_UninstallAPK.Font = New System.Drawing.Font("Agency FB", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_UninstallAPK.Location = New System.Drawing.Point(117, 19)
        Me.btn_UninstallAPK.Name = "btn_UninstallAPK"
        Me.btn_UninstallAPK.Size = New System.Drawing.Size(91, 38)
        Me.btn_UninstallAPK.TabIndex = 10
        Me.btn_UninstallAPK.Text = "Uninstall"
        Me.btn_UninstallAPK.UseVisualStyleBackColor = True
        '
        'lbl_warn3
        '
        Me.lbl_warn3.Location = New System.Drawing.Point(684, 19)
        Me.lbl_warn3.Name = "lbl_warn3"
        Me.lbl_warn3.Size = New System.Drawing.Size(215, 74)
        Me.lbl_warn3.TabIndex = 19
        Me.lbl_warn3.Text = "- Be Careful -" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "App Backup And Restore Is Still Buggy" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Check The Backup File Befo" &
    "re Restore"
        Me.lbl_warn3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Timer1
        '
        Me.Timer1.Interval = 1000
        '
        'Interference
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit
        Me.Controls.Add(Me.lbl_warn3)
        Me.Controls.Add(Me.gb_APKOptions)
        Me.Controls.Add(Me.rb_FilterAppAll)
        Me.Controls.Add(Me.rb_FilterSystemApp)
        Me.Controls.Add(Me.rb_FilterAppUser)
        Me.Controls.Add(Me.list_APK)
        Me.Name = "Interference"
        Me.Size = New System.Drawing.Size(918, 360)
        Me.gb_APKOptions.ResumeLayout(False)
        Me.gb_APKOptions.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents rb_FilterAppAll As RadioButton
    Friend WithEvents rb_FilterSystemApp As RadioButton
    Friend WithEvents rb_FilterAppUser As RadioButton
    Friend WithEvents list_APK As ListBox
    Friend WithEvents gb_APKOptions As GroupBox
    Friend WithEvents lbl_warn3 As Label
    Friend WithEvents btn_RestoreAPK As Button
    Friend WithEvents btn_ClearAPKData As Button
    Friend WithEvents btn_BackupAPK As Button
    Friend WithEvents btn_RunAPK As Button
    Friend WithEvents btn_ForceCloseAPK As Button
    Friend WithEvents btn_InstallAPK As Button
    Friend WithEvents btn_RefreshListAPK As Button
    Friend WithEvents btn_UninstallAPK As Button
    Friend WithEvents lbl_time As Label
    Friend WithEvents rb_All As RadioButton
    Friend WithEvents rb_AllApp As RadioButton
    Friend WithEvents rb_SelectedAppOnly As RadioButton
    Friend WithEvents Timer1 As Timer
End Class
