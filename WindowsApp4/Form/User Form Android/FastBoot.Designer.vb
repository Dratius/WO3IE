<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FastBoot
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
        Me.gb_flash = New System.Windows.Forms.GroupBox()
        Me.lbl_fl_warning = New System.Windows.Forms.Label()
        Me.btn_flash = New System.Windows.Forms.Button()
        Me.cb_fl_cache = New System.Windows.Forms.CheckBox()
        Me.txt_fl_cache = New System.Windows.Forms.TextBox()
        Me.lbl_fl_cache = New System.Windows.Forms.Label()
        Me.cb_fl_data = New System.Windows.Forms.CheckBox()
        Me.txt_fl_data = New System.Windows.Forms.TextBox()
        Me.lbl_fl_data = New System.Windows.Forms.Label()
        Me.cb_fl_sys = New System.Windows.Forms.CheckBox()
        Me.txt_fl_sys = New System.Windows.Forms.TextBox()
        Me.lbl_fl_sys = New System.Windows.Forms.Label()
        Me.cb_fl_boot = New System.Windows.Forms.CheckBox()
        Me.txt_fl_boot = New System.Windows.Forms.TextBox()
        Me.lbl_fl_boot = New System.Windows.Forms.Label()
        Me.cb_fl_rec = New System.Windows.Forms.CheckBox()
        Me.txt_fl_rec = New System.Windows.Forms.TextBox()
        Me.lbl_fl_rec = New System.Windows.Forms.Label()
        Me.gb_manualfastboot = New System.Windows.Forms.GroupBox()
        Me.lbl_fl_warn2 = New System.Windows.Forms.Label()
        Me.btn_manualfastboot = New System.Windows.Forms.Button()
        Me.txt_manualfastboot = New System.Windows.Forms.TextBox()
        Me.gb_flash.SuspendLayout()
        Me.gb_manualfastboot.SuspendLayout()
        Me.SuspendLayout()
        '
        'gb_flash
        '
        Me.gb_flash.Controls.Add(Me.lbl_fl_warning)
        Me.gb_flash.Controls.Add(Me.btn_flash)
        Me.gb_flash.Controls.Add(Me.cb_fl_cache)
        Me.gb_flash.Controls.Add(Me.txt_fl_cache)
        Me.gb_flash.Controls.Add(Me.lbl_fl_cache)
        Me.gb_flash.Controls.Add(Me.cb_fl_data)
        Me.gb_flash.Controls.Add(Me.txt_fl_data)
        Me.gb_flash.Controls.Add(Me.lbl_fl_data)
        Me.gb_flash.Controls.Add(Me.cb_fl_sys)
        Me.gb_flash.Controls.Add(Me.txt_fl_sys)
        Me.gb_flash.Controls.Add(Me.lbl_fl_sys)
        Me.gb_flash.Controls.Add(Me.cb_fl_boot)
        Me.gb_flash.Controls.Add(Me.txt_fl_boot)
        Me.gb_flash.Controls.Add(Me.lbl_fl_boot)
        Me.gb_flash.Controls.Add(Me.cb_fl_rec)
        Me.gb_flash.Controls.Add(Me.txt_fl_rec)
        Me.gb_flash.Controls.Add(Me.lbl_fl_rec)
        Me.gb_flash.Font = New System.Drawing.Font("Agency FB", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gb_flash.Location = New System.Drawing.Point(3, 3)
        Me.gb_flash.Name = "gb_flash"
        Me.gb_flash.Size = New System.Drawing.Size(590, 225)
        Me.gb_flash.TabIndex = 11
        Me.gb_flash.TabStop = False
        Me.gb_flash.Text = "Flashing"
        '
        'lbl_fl_warning
        '
        Me.lbl_fl_warning.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_fl_warning.ForeColor = System.Drawing.Color.Red
        Me.lbl_fl_warning.Location = New System.Drawing.Point(63, 192)
        Me.lbl_fl_warning.Name = "lbl_fl_warning"
        Me.lbl_fl_warning.Size = New System.Drawing.Size(392, 18)
        Me.lbl_fl_warning.TabIndex = 18
        Me.lbl_fl_warning.Text = "Flashing wrong files may cause your device to hardbrick"
        Me.lbl_fl_warning.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btn_flash
        '
        Me.btn_flash.FlatAppearance.BorderColor = System.Drawing.Color.DarkRed
        Me.btn_flash.FlatAppearance.BorderSize = 4
        Me.btn_flash.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Linen
        Me.btn_flash.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_flash.Location = New System.Drawing.Point(464, 38)
        Me.btn_flash.Name = "btn_flash"
        Me.btn_flash.Size = New System.Drawing.Size(75, 148)
        Me.btn_flash.TabIndex = 17
        Me.btn_flash.Text = "Flash"
        Me.btn_flash.UseVisualStyleBackColor = True
        '
        'cb_fl_cache
        '
        Me.cb_fl_cache.AutoSize = True
        Me.cb_fl_cache.Location = New System.Drawing.Point(440, 166)
        Me.cb_fl_cache.Name = "cb_fl_cache"
        Me.cb_fl_cache.Size = New System.Drawing.Size(15, 14)
        Me.cb_fl_cache.TabIndex = 16
        Me.cb_fl_cache.UseVisualStyleBackColor = True
        '
        'txt_fl_cache
        '
        Me.txt_fl_cache.Location = New System.Drawing.Point(66, 163)
        Me.txt_fl_cache.Name = "txt_fl_cache"
        Me.txt_fl_cache.ReadOnly = True
        Me.txt_fl_cache.Size = New System.Drawing.Size(368, 26)
        Me.txt_fl_cache.TabIndex = 15
        Me.txt_fl_cache.WordWrap = False
        '
        'lbl_fl_cache
        '
        Me.lbl_fl_cache.AutoSize = True
        Me.lbl_fl_cache.Location = New System.Drawing.Point(7, 166)
        Me.lbl_fl_cache.Name = "lbl_fl_cache"
        Me.lbl_fl_cache.Size = New System.Drawing.Size(35, 20)
        Me.lbl_fl_cache.TabIndex = 14
        Me.lbl_fl_cache.Text = "Cache"
        '
        'cb_fl_data
        '
        Me.cb_fl_data.AutoSize = True
        Me.cb_fl_data.Location = New System.Drawing.Point(440, 134)
        Me.cb_fl_data.Name = "cb_fl_data"
        Me.cb_fl_data.Size = New System.Drawing.Size(15, 14)
        Me.cb_fl_data.TabIndex = 13
        Me.cb_fl_data.UseVisualStyleBackColor = True
        '
        'txt_fl_data
        '
        Me.txt_fl_data.Location = New System.Drawing.Point(66, 131)
        Me.txt_fl_data.Name = "txt_fl_data"
        Me.txt_fl_data.ReadOnly = True
        Me.txt_fl_data.Size = New System.Drawing.Size(368, 26)
        Me.txt_fl_data.TabIndex = 12
        Me.txt_fl_data.WordWrap = False
        '
        'lbl_fl_data
        '
        Me.lbl_fl_data.AutoSize = True
        Me.lbl_fl_data.Location = New System.Drawing.Point(7, 134)
        Me.lbl_fl_data.Name = "lbl_fl_data"
        Me.lbl_fl_data.Size = New System.Drawing.Size(28, 20)
        Me.lbl_fl_data.TabIndex = 11
        Me.lbl_fl_data.Text = "Data"
        '
        'cb_fl_sys
        '
        Me.cb_fl_sys.AutoSize = True
        Me.cb_fl_sys.Location = New System.Drawing.Point(440, 102)
        Me.cb_fl_sys.Name = "cb_fl_sys"
        Me.cb_fl_sys.Size = New System.Drawing.Size(15, 14)
        Me.cb_fl_sys.TabIndex = 10
        Me.cb_fl_sys.UseVisualStyleBackColor = True
        '
        'txt_fl_sys
        '
        Me.txt_fl_sys.Location = New System.Drawing.Point(66, 99)
        Me.txt_fl_sys.Name = "txt_fl_sys"
        Me.txt_fl_sys.ReadOnly = True
        Me.txt_fl_sys.Size = New System.Drawing.Size(368, 26)
        Me.txt_fl_sys.TabIndex = 9
        Me.txt_fl_sys.WordWrap = False
        '
        'lbl_fl_sys
        '
        Me.lbl_fl_sys.AutoSize = True
        Me.lbl_fl_sys.Location = New System.Drawing.Point(7, 102)
        Me.lbl_fl_sys.Name = "lbl_fl_sys"
        Me.lbl_fl_sys.Size = New System.Drawing.Size(42, 20)
        Me.lbl_fl_sys.TabIndex = 8
        Me.lbl_fl_sys.Text = "System"
        '
        'cb_fl_boot
        '
        Me.cb_fl_boot.AutoSize = True
        Me.cb_fl_boot.Location = New System.Drawing.Point(440, 70)
        Me.cb_fl_boot.Name = "cb_fl_boot"
        Me.cb_fl_boot.Size = New System.Drawing.Size(15, 14)
        Me.cb_fl_boot.TabIndex = 7
        Me.cb_fl_boot.UseVisualStyleBackColor = True
        '
        'txt_fl_boot
        '
        Me.txt_fl_boot.Location = New System.Drawing.Point(66, 67)
        Me.txt_fl_boot.Name = "txt_fl_boot"
        Me.txt_fl_boot.ReadOnly = True
        Me.txt_fl_boot.Size = New System.Drawing.Size(368, 26)
        Me.txt_fl_boot.TabIndex = 6
        Me.txt_fl_boot.WordWrap = False
        '
        'lbl_fl_boot
        '
        Me.lbl_fl_boot.AutoSize = True
        Me.lbl_fl_boot.Location = New System.Drawing.Point(7, 70)
        Me.lbl_fl_boot.Name = "lbl_fl_boot"
        Me.lbl_fl_boot.Size = New System.Drawing.Size(28, 20)
        Me.lbl_fl_boot.TabIndex = 5
        Me.lbl_fl_boot.Text = "Boot"
        '
        'cb_fl_rec
        '
        Me.cb_fl_rec.AutoSize = True
        Me.cb_fl_rec.Location = New System.Drawing.Point(440, 38)
        Me.cb_fl_rec.Name = "cb_fl_rec"
        Me.cb_fl_rec.Size = New System.Drawing.Size(15, 14)
        Me.cb_fl_rec.TabIndex = 4
        Me.cb_fl_rec.UseVisualStyleBackColor = True
        '
        'txt_fl_rec
        '
        Me.txt_fl_rec.Location = New System.Drawing.Point(66, 35)
        Me.txt_fl_rec.Name = "txt_fl_rec"
        Me.txt_fl_rec.ReadOnly = True
        Me.txt_fl_rec.Size = New System.Drawing.Size(368, 26)
        Me.txt_fl_rec.TabIndex = 3
        Me.txt_fl_rec.WordWrap = False
        '
        'lbl_fl_rec
        '
        Me.lbl_fl_rec.AutoSize = True
        Me.lbl_fl_rec.Location = New System.Drawing.Point(7, 38)
        Me.lbl_fl_rec.Name = "lbl_fl_rec"
        Me.lbl_fl_rec.Size = New System.Drawing.Size(52, 20)
        Me.lbl_fl_rec.TabIndex = 0
        Me.lbl_fl_rec.Text = "Recovery"
        '
        'gb_manualfastboot
        '
        Me.gb_manualfastboot.Controls.Add(Me.lbl_fl_warn2)
        Me.gb_manualfastboot.Controls.Add(Me.btn_manualfastboot)
        Me.gb_manualfastboot.Controls.Add(Me.txt_manualfastboot)
        Me.gb_manualfastboot.Font = New System.Drawing.Font("Agency FB", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gb_manualfastboot.Location = New System.Drawing.Point(3, 243)
        Me.gb_manualfastboot.Name = "gb_manualfastboot"
        Me.gb_manualfastboot.Size = New System.Drawing.Size(590, 84)
        Me.gb_manualfastboot.TabIndex = 12
        Me.gb_manualfastboot.TabStop = False
        Me.gb_manualfastboot.Text = "Fastboot Manual Commands"
        '
        'lbl_fl_warn2
        '
        Me.lbl_fl_warn2.AutoSize = True
        Me.lbl_fl_warn2.Location = New System.Drawing.Point(402, 41)
        Me.lbl_fl_warn2.Name = "lbl_fl_warn2"
        Me.lbl_fl_warn2.Size = New System.Drawing.Size(164, 20)
        Me.lbl_fl_warn2.TabIndex = 19
        Me.lbl_fl_warn2.Text = "Make sure you are in fastboot mode"
        '
        'btn_manualfastboot
        '
        Me.btn_manualfastboot.Location = New System.Drawing.Point(297, 38)
        Me.btn_manualfastboot.Name = "btn_manualfastboot"
        Me.btn_manualfastboot.Size = New System.Drawing.Size(99, 27)
        Me.btn_manualfastboot.TabIndex = 18
        Me.btn_manualfastboot.Text = "Send"
        Me.btn_manualfastboot.UseVisualStyleBackColor = True
        '
        'txt_manualfastboot
        '
        Me.txt_manualfastboot.Location = New System.Drawing.Point(6, 39)
        Me.txt_manualfastboot.Name = "txt_manualfastboot"
        Me.txt_manualfastboot.Size = New System.Drawing.Size(285, 26)
        Me.txt_manualfastboot.TabIndex = 16
        '
        'FastBoot
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit
        Me.Controls.Add(Me.gb_manualfastboot)
        Me.Controls.Add(Me.gb_flash)
        Me.Name = "FastBoot"
        Me.Size = New System.Drawing.Size(918, 360)
        Me.gb_flash.ResumeLayout(False)
        Me.gb_flash.PerformLayout()
        Me.gb_manualfastboot.ResumeLayout(False)
        Me.gb_manualfastboot.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents gb_flash As GroupBox
    Friend WithEvents lbl_fl_warning As Label
    Friend WithEvents btn_flash As Button
    Friend WithEvents cb_fl_cache As CheckBox
    Friend WithEvents txt_fl_cache As TextBox
    Friend WithEvents lbl_fl_cache As Label
    Friend WithEvents cb_fl_data As CheckBox
    Friend WithEvents txt_fl_data As TextBox
    Friend WithEvents lbl_fl_data As Label
    Friend WithEvents cb_fl_sys As CheckBox
    Friend WithEvents txt_fl_sys As TextBox
    Friend WithEvents lbl_fl_sys As Label
    Friend WithEvents cb_fl_boot As CheckBox
    Friend WithEvents txt_fl_boot As TextBox
    Friend WithEvents lbl_fl_boot As Label
    Friend WithEvents cb_fl_rec As CheckBox
    Friend WithEvents txt_fl_rec As TextBox
    Friend WithEvents lbl_fl_rec As Label
    Friend WithEvents gb_manualfastboot As GroupBox
    Friend WithEvents lbl_fl_warn2 As Label
    Friend WithEvents btn_manualfastboot As Button
    Friend WithEvents txt_manualfastboot As TextBox
End Class
