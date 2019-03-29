<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Advanced
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
        Me.TC_Advanced = New System.Windows.Forms.TabControl()
        Me.tb_select_apkt = New System.Windows.Forms.TabPage()
        Me.lbl_apkt_checkproj = New System.Windows.Forms.Label()
        Me.gb_apkt_at = New System.Windows.Forms.GroupBox()
        Me.btn_apkt_verify = New System.Windows.Forms.Button()
        Me.btn_apkt_marketsign = New System.Windows.Forms.Button()
        Me.btn_apkt_compile = New System.Windows.Forms.Button()
        Me.btn_apkt_decompile = New System.Windows.Forms.Button()
        Me.gb_apkt_st = New System.Windows.Forms.GroupBox()
        Me.btn_apkt_allinone = New System.Windows.Forms.Button()
        Me.btn_apkt_zipa = New System.Windows.Forms.Button()
        Me.btn_apkt_signapk = New System.Windows.Forms.Button()
        Me.btn_apkt_zip = New System.Windows.Forms.Button()
        Me.btn_apkt_extapk = New System.Windows.Forms.Button()
        Me.chbx_apkt_system = New System.Windows.Forms.CheckBox()
        Me.list_apkt = New System.Windows.Forms.ListBox()
        Me.tb_abe = New System.Windows.Forms.TabPage()
        Me.lbl_abe_readme2 = New System.Windows.Forms.Label()
        Me.ll_abe_installpolicy = New System.Windows.Forms.LinkLabel()
        Me.lbl_abe_readme = New System.Windows.Forms.Label()
        Me.lbl_abe_pass = New System.Windows.Forms.Label()
        Me.txt_abe_pass = New System.Windows.Forms.TextBox()
        Me.gb_abe = New System.Windows.Forms.GroupBox()
        Me.cb_abe_android = New System.Windows.Forms.CheckBox()
        Me.btn_abe_start = New System.Windows.Forms.Button()
        Me.rb_abe_pack = New System.Windows.Forms.RadioButton()
        Me.rb_abe_unpack = New System.Windows.Forms.RadioButton()
        Me.btn_abe_showtar = New System.Windows.Forms.Button()
        Me.lbl_abe_tarpath = New System.Windows.Forms.Label()
        Me.lbl_abe_abpath = New System.Windows.Forms.Label()
        Me.btn_abe_showab = New System.Windows.Forms.Button()
        Me.txt_abe_tarpath = New System.Windows.Forms.TextBox()
        Me.txt_abe_abpath = New System.Windows.Forms.TextBox()
        Me.tb_buildprop = New System.Windows.Forms.TabPage()
        Me.txt_buildprop = New ICSharpCode.TextEditor.TextEditorControl()
        Me.btn_BuildPropTweaks = New System.Windows.Forms.Button()
        Me.lbl_BuildPropStats = New System.Windows.Forms.Label()
        Me.btn_LoadBuildProp = New System.Windows.Forms.Button()
        Me.btn_BackupBuildProp = New System.Windows.Forms.Button()
        Me.btn_SaveBuildProp = New System.Windows.Forms.Button()
        Me.TC_Advanced.SuspendLayout()
        Me.tb_select_apkt.SuspendLayout()
        Me.gb_apkt_at.SuspendLayout()
        Me.gb_apkt_st.SuspendLayout()
        Me.tb_abe.SuspendLayout()
        Me.gb_abe.SuspendLayout()
        Me.tb_buildprop.SuspendLayout()
        Me.SuspendLayout()
        '
        'TC_Advanced
        '
        Me.TC_Advanced.AllowDrop = True
        Me.TC_Advanced.Controls.Add(Me.tb_select_apkt)
        Me.TC_Advanced.Controls.Add(Me.tb_abe)
        Me.TC_Advanced.Controls.Add(Me.tb_buildprop)
        Me.TC_Advanced.Font = New System.Drawing.Font("Agency FB", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TC_Advanced.Location = New System.Drawing.Point(3, 3)
        Me.TC_Advanced.Name = "TC_Advanced"
        Me.TC_Advanced.SelectedIndex = 0
        Me.TC_Advanced.Size = New System.Drawing.Size(883, 314)
        Me.TC_Advanced.TabIndex = 2
        '
        'tb_select_apkt
        '
        Me.tb_select_apkt.AllowDrop = True
        Me.tb_select_apkt.Controls.Add(Me.lbl_apkt_checkproj)
        Me.tb_select_apkt.Controls.Add(Me.gb_apkt_at)
        Me.tb_select_apkt.Controls.Add(Me.gb_apkt_st)
        Me.tb_select_apkt.Controls.Add(Me.chbx_apkt_system)
        Me.tb_select_apkt.Controls.Add(Me.list_apkt)
        Me.tb_select_apkt.Location = New System.Drawing.Point(4, 29)
        Me.tb_select_apkt.Name = "tb_select_apkt"
        Me.tb_select_apkt.Padding = New System.Windows.Forms.Padding(3)
        Me.tb_select_apkt.Size = New System.Drawing.Size(875, 281)
        Me.tb_select_apkt.TabIndex = 0
        Me.tb_select_apkt.Text = "Apk Editor"
        Me.tb_select_apkt.UseVisualStyleBackColor = True
        '
        'lbl_apkt_checkproj
        '
        Me.lbl_apkt_checkproj.Location = New System.Drawing.Point(673, 190)
        Me.lbl_apkt_checkproj.Name = "lbl_apkt_checkproj"
        Me.lbl_apkt_checkproj.Size = New System.Drawing.Size(107, 26)
        Me.lbl_apkt_checkproj.TabIndex = 9
        Me.lbl_apkt_checkproj.Text = "No File Selected"
        Me.lbl_apkt_checkproj.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'gb_apkt_at
        '
        Me.gb_apkt_at.Controls.Add(Me.btn_apkt_verify)
        Me.gb_apkt_at.Controls.Add(Me.btn_apkt_marketsign)
        Me.gb_apkt_at.Controls.Add(Me.btn_apkt_compile)
        Me.gb_apkt_at.Controls.Add(Me.btn_apkt_decompile)
        Me.gb_apkt_at.Location = New System.Drawing.Point(614, 44)
        Me.gb_apkt_at.Name = "gb_apkt_at"
        Me.gb_apkt_at.Size = New System.Drawing.Size(229, 119)
        Me.gb_apkt_at.TabIndex = 6
        Me.gb_apkt_at.TabStop = False
        Me.gb_apkt_at.Text = "Advanced Task"
        '
        'btn_apkt_verify
        '
        Me.btn_apkt_verify.Enabled = False
        Me.btn_apkt_verify.Location = New System.Drawing.Point(110, 67)
        Me.btn_apkt_verify.Name = "btn_apkt_verify"
        Me.btn_apkt_verify.Size = New System.Drawing.Size(95, 34)
        Me.btn_apkt_verify.TabIndex = 4
        Me.btn_apkt_verify.Text = "Verify"
        Me.btn_apkt_verify.UseVisualStyleBackColor = True
        '
        'btn_apkt_marketsign
        '
        Me.btn_apkt_marketsign.Location = New System.Drawing.Point(9, 67)
        Me.btn_apkt_marketsign.Name = "btn_apkt_marketsign"
        Me.btn_apkt_marketsign.Size = New System.Drawing.Size(95, 34)
        Me.btn_apkt_marketsign.TabIndex = 3
        Me.btn_apkt_marketsign.Text = "Market Sign"
        Me.btn_apkt_marketsign.UseVisualStyleBackColor = True
        '
        'btn_apkt_compile
        '
        Me.btn_apkt_compile.Location = New System.Drawing.Point(9, 25)
        Me.btn_apkt_compile.Name = "btn_apkt_compile"
        Me.btn_apkt_compile.Size = New System.Drawing.Size(95, 36)
        Me.btn_apkt_compile.TabIndex = 2
        Me.btn_apkt_compile.Text = "Compile"
        Me.btn_apkt_compile.UseVisualStyleBackColor = True
        '
        'btn_apkt_decompile
        '
        Me.btn_apkt_decompile.Location = New System.Drawing.Point(110, 25)
        Me.btn_apkt_decompile.Name = "btn_apkt_decompile"
        Me.btn_apkt_decompile.Size = New System.Drawing.Size(95, 36)
        Me.btn_apkt_decompile.TabIndex = 1
        Me.btn_apkt_decompile.Text = "Decompile"
        Me.btn_apkt_decompile.UseVisualStyleBackColor = True
        '
        'gb_apkt_st
        '
        Me.gb_apkt_st.Controls.Add(Me.btn_apkt_allinone)
        Me.gb_apkt_st.Controls.Add(Me.btn_apkt_zipa)
        Me.gb_apkt_st.Controls.Add(Me.btn_apkt_signapk)
        Me.gb_apkt_st.Controls.Add(Me.btn_apkt_zip)
        Me.gb_apkt_st.Controls.Add(Me.btn_apkt_extapk)
        Me.gb_apkt_st.Location = New System.Drawing.Point(390, 44)
        Me.gb_apkt_st.Name = "gb_apkt_st"
        Me.gb_apkt_st.Size = New System.Drawing.Size(207, 185)
        Me.gb_apkt_st.TabIndex = 5
        Me.gb_apkt_st.TabStop = False
        Me.gb_apkt_st.Text = "Simple Task"
        '
        'btn_apkt_allinone
        '
        Me.btn_apkt_allinone.Location = New System.Drawing.Point(56, 125)
        Me.btn_apkt_allinone.Name = "btn_apkt_allinone"
        Me.btn_apkt_allinone.Size = New System.Drawing.Size(95, 47)
        Me.btn_apkt_allinone.TabIndex = 1
        Me.btn_apkt_allinone.Text = "Zip - Sign"
        Me.btn_apkt_allinone.UseVisualStyleBackColor = True
        '
        'btn_apkt_zipa
        '
        Me.btn_apkt_zipa.Location = New System.Drawing.Point(106, 73)
        Me.btn_apkt_zipa.Name = "btn_apkt_zipa"
        Me.btn_apkt_zipa.Size = New System.Drawing.Size(95, 46)
        Me.btn_apkt_zipa.TabIndex = 3
        Me.btn_apkt_zipa.Text = "Zip-Align"
        Me.btn_apkt_zipa.UseVisualStyleBackColor = True
        '
        'btn_apkt_signapk
        '
        Me.btn_apkt_signapk.Location = New System.Drawing.Point(0, 73)
        Me.btn_apkt_signapk.Name = "btn_apkt_signapk"
        Me.btn_apkt_signapk.Size = New System.Drawing.Size(95, 46)
        Me.btn_apkt_signapk.TabIndex = 2
        Me.btn_apkt_signapk.Text = "Sign"
        Me.btn_apkt_signapk.UseVisualStyleBackColor = True
        '
        'btn_apkt_zip
        '
        Me.btn_apkt_zip.Location = New System.Drawing.Point(0, 25)
        Me.btn_apkt_zip.Name = "btn_apkt_zip"
        Me.btn_apkt_zip.Size = New System.Drawing.Size(95, 36)
        Me.btn_apkt_zip.TabIndex = 1
        Me.btn_apkt_zip.Text = "Zip"
        Me.btn_apkt_zip.UseVisualStyleBackColor = True
        '
        'btn_apkt_extapk
        '
        Me.btn_apkt_extapk.Location = New System.Drawing.Point(106, 25)
        Me.btn_apkt_extapk.Name = "btn_apkt_extapk"
        Me.btn_apkt_extapk.Size = New System.Drawing.Size(95, 36)
        Me.btn_apkt_extapk.TabIndex = 0
        Me.btn_apkt_extapk.Text = "Extract"
        Me.btn_apkt_extapk.UseVisualStyleBackColor = True
        '
        'chbx_apkt_system
        '
        Me.chbx_apkt_system.AutoSize = True
        Me.chbx_apkt_system.Location = New System.Drawing.Point(6, 6)
        Me.chbx_apkt_system.Name = "chbx_apkt_system"
        Me.chbx_apkt_system.Size = New System.Drawing.Size(166, 24)
        Me.chbx_apkt_system.TabIndex = 4
        Me.chbx_apkt_system.Text = "System Apk (Retains Signature)"
        Me.chbx_apkt_system.UseVisualStyleBackColor = True
        '
        'list_apkt
        '
        Me.list_apkt.AllowDrop = True
        Me.list_apkt.FormattingEnabled = True
        Me.list_apkt.ItemHeight = 20
        Me.list_apkt.Location = New System.Drawing.Point(6, 44)
        Me.list_apkt.Name = "list_apkt"
        Me.list_apkt.ScrollAlwaysVisible = True
        Me.list_apkt.Size = New System.Drawing.Size(365, 204)
        Me.list_apkt.Sorted = True
        Me.list_apkt.TabIndex = 0
        '
        'tb_abe
        '
        Me.tb_abe.Controls.Add(Me.lbl_abe_readme2)
        Me.tb_abe.Controls.Add(Me.ll_abe_installpolicy)
        Me.tb_abe.Controls.Add(Me.lbl_abe_readme)
        Me.tb_abe.Controls.Add(Me.lbl_abe_pass)
        Me.tb_abe.Controls.Add(Me.txt_abe_pass)
        Me.tb_abe.Controls.Add(Me.gb_abe)
        Me.tb_abe.Location = New System.Drawing.Point(4, 29)
        Me.tb_abe.Name = "tb_abe"
        Me.tb_abe.Padding = New System.Windows.Forms.Padding(3)
        Me.tb_abe.Size = New System.Drawing.Size(875, 281)
        Me.tb_abe.TabIndex = 3
        Me.tb_abe.Text = "ADB Backup Extractor"
        Me.tb_abe.UseVisualStyleBackColor = True
        '
        'lbl_abe_readme2
        '
        Me.lbl_abe_readme2.AutoSize = True
        Me.lbl_abe_readme2.Location = New System.Drawing.Point(6, 246)
        Me.lbl_abe_readme2.Name = "lbl_abe_readme2"
        Me.lbl_abe_readme2.Size = New System.Drawing.Size(330, 20)
        Me.lbl_abe_readme2.TabIndex = 15
        Me.lbl_abe_readme2.Text = "(I only provided for Java RE 8 only, For lower version check readme.txt)"
        '
        'll_abe_installpolicy
        '
        Me.ll_abe_installpolicy.AutoSize = True
        Me.ll_abe_installpolicy.Location = New System.Drawing.Point(394, 221)
        Me.ll_abe_installpolicy.Name = "ll_abe_installpolicy"
        Me.ll_abe_installpolicy.Size = New System.Drawing.Size(63, 20)
        Me.ll_abe_installpolicy.TabIndex = 14
        Me.ll_abe_installpolicy.TabStop = True
        Me.ll_abe_installpolicy.Text = "Modified JCE"
        '
        'lbl_abe_readme
        '
        Me.lbl_abe_readme.AutoSize = True
        Me.lbl_abe_readme.Location = New System.Drawing.Point(3, 207)
        Me.lbl_abe_readme.Name = "lbl_abe_readme"
        Me.lbl_abe_readme.Size = New System.Drawing.Size(353, 20)
        Me.lbl_abe_readme.TabIndex = 13
        Me.lbl_abe_readme.Text = "If you are working with password encrypted adb backups, you need to install :"
        '
        'lbl_abe_pass
        '
        Me.lbl_abe_pass.AutoSize = True
        Me.lbl_abe_pass.Location = New System.Drawing.Point(6, 22)
        Me.lbl_abe_pass.Name = "lbl_abe_pass"
        Me.lbl_abe_pass.Size = New System.Drawing.Size(198, 20)
        Me.lbl_abe_pass.TabIndex = 12
        Me.lbl_abe_pass.Text = "Password (Leave it blank if no password) :"
        '
        'txt_abe_pass
        '
        Me.txt_abe_pass.Location = New System.Drawing.Point(218, 19)
        Me.txt_abe_pass.Name = "txt_abe_pass"
        Me.txt_abe_pass.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txt_abe_pass.Size = New System.Drawing.Size(309, 26)
        Me.txt_abe_pass.TabIndex = 11
        '
        'gb_abe
        '
        Me.gb_abe.Controls.Add(Me.cb_abe_android)
        Me.gb_abe.Controls.Add(Me.btn_abe_start)
        Me.gb_abe.Controls.Add(Me.rb_abe_pack)
        Me.gb_abe.Controls.Add(Me.rb_abe_unpack)
        Me.gb_abe.Controls.Add(Me.btn_abe_showtar)
        Me.gb_abe.Controls.Add(Me.lbl_abe_tarpath)
        Me.gb_abe.Controls.Add(Me.lbl_abe_abpath)
        Me.gb_abe.Controls.Add(Me.btn_abe_showab)
        Me.gb_abe.Controls.Add(Me.txt_abe_tarpath)
        Me.gb_abe.Controls.Add(Me.txt_abe_abpath)
        Me.gb_abe.Location = New System.Drawing.Point(6, 64)
        Me.gb_abe.Name = "gb_abe"
        Me.gb_abe.Size = New System.Drawing.Size(555, 140)
        Me.gb_abe.TabIndex = 0
        Me.gb_abe.TabStop = False
        Me.gb_abe.Text = "Unpack / Pack"
        '
        'cb_abe_android
        '
        Me.cb_abe_android.AutoSize = True
        Me.cb_abe_android.Checked = True
        Me.cb_abe_android.CheckState = System.Windows.Forms.CheckState.Checked
        Me.cb_abe_android.Location = New System.Drawing.Point(443, 16)
        Me.cb_abe_android.Name = "cb_abe_android"
        Me.cb_abe_android.Size = New System.Drawing.Size(95, 24)
        Me.cb_abe_android.TabIndex = 9
        Me.cb_abe_android.Text = "Android 4.4.3+"
        Me.cb_abe_android.UseVisualStyleBackColor = True
        '
        'btn_abe_start
        '
        Me.btn_abe_start.Enabled = False
        Me.btn_abe_start.Location = New System.Drawing.Point(456, 46)
        Me.btn_abe_start.Name = "btn_abe_start"
        Me.btn_abe_start.Size = New System.Drawing.Size(82, 75)
        Me.btn_abe_start.TabIndex = 8
        Me.btn_abe_start.Text = "Unpack"
        Me.btn_abe_start.UseVisualStyleBackColor = True
        '
        'rb_abe_pack
        '
        Me.rb_abe_pack.AutoSize = True
        Me.rb_abe_pack.Location = New System.Drawing.Point(302, 19)
        Me.rb_abe_pack.Name = "rb_abe_pack"
        Me.rb_abe_pack.Size = New System.Drawing.Size(48, 24)
        Me.rb_abe_pack.TabIndex = 7
        Me.rb_abe_pack.Text = "Pack"
        Me.rb_abe_pack.UseVisualStyleBackColor = True
        '
        'rb_abe_unpack
        '
        Me.rb_abe_unpack.AutoSize = True
        Me.rb_abe_unpack.Checked = True
        Me.rb_abe_unpack.Location = New System.Drawing.Point(212, 19)
        Me.rb_abe_unpack.Name = "rb_abe_unpack"
        Me.rb_abe_unpack.Size = New System.Drawing.Size(58, 24)
        Me.rb_abe_unpack.TabIndex = 6
        Me.rb_abe_unpack.TabStop = True
        Me.rb_abe_unpack.Text = "Unpack"
        Me.rb_abe_unpack.UseVisualStyleBackColor = True
        '
        'btn_abe_showtar
        '
        Me.btn_abe_showtar.Font = New System.Drawing.Font("Bebas", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_abe_showtar.Location = New System.Drawing.Point(406, 88)
        Me.btn_abe_showtar.Name = "btn_abe_showtar"
        Me.btn_abe_showtar.Size = New System.Drawing.Size(30, 33)
        Me.btn_abe_showtar.TabIndex = 5
        Me.btn_abe_showtar.Text = "..."
        Me.btn_abe_showtar.UseVisualStyleBackColor = True
        '
        'lbl_abe_tarpath
        '
        Me.lbl_abe_tarpath.AutoSize = True
        Me.lbl_abe_tarpath.Location = New System.Drawing.Point(16, 97)
        Me.lbl_abe_tarpath.Name = "lbl_abe_tarpath"
        Me.lbl_abe_tarpath.Size = New System.Drawing.Size(66, 20)
        Me.lbl_abe_tarpath.TabIndex = 4
        Me.lbl_abe_tarpath.Text = "Tar file path :"
        '
        'lbl_abe_abpath
        '
        Me.lbl_abe_abpath.AutoSize = True
        Me.lbl_abe_abpath.Location = New System.Drawing.Point(16, 55)
        Me.lbl_abe_abpath.Name = "lbl_abe_abpath"
        Me.lbl_abe_abpath.Size = New System.Drawing.Size(62, 20)
        Me.lbl_abe_abpath.TabIndex = 3
        Me.lbl_abe_abpath.Text = "AB file path :"
        '
        'btn_abe_showab
        '
        Me.btn_abe_showab.Font = New System.Drawing.Font("Bebas", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_abe_showab.Location = New System.Drawing.Point(406, 46)
        Me.btn_abe_showab.Name = "btn_abe_showab"
        Me.btn_abe_showab.Size = New System.Drawing.Size(30, 32)
        Me.btn_abe_showab.TabIndex = 2
        Me.btn_abe_showab.Text = "..."
        Me.btn_abe_showab.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btn_abe_showab.UseVisualStyleBackColor = True
        '
        'txt_abe_tarpath
        '
        Me.txt_abe_tarpath.Location = New System.Drawing.Point(108, 94)
        Me.txt_abe_tarpath.Name = "txt_abe_tarpath"
        Me.txt_abe_tarpath.ReadOnly = True
        Me.txt_abe_tarpath.Size = New System.Drawing.Size(292, 26)
        Me.txt_abe_tarpath.TabIndex = 1
        '
        'txt_abe_abpath
        '
        Me.txt_abe_abpath.Location = New System.Drawing.Point(108, 52)
        Me.txt_abe_abpath.Name = "txt_abe_abpath"
        Me.txt_abe_abpath.ReadOnly = True
        Me.txt_abe_abpath.Size = New System.Drawing.Size(292, 26)
        Me.txt_abe_abpath.TabIndex = 0
        '
        'tb_buildprop
        '
        Me.tb_buildprop.Controls.Add(Me.txt_buildprop)
        Me.tb_buildprop.Controls.Add(Me.btn_BuildPropTweaks)
        Me.tb_buildprop.Controls.Add(Me.lbl_BuildPropStats)
        Me.tb_buildprop.Controls.Add(Me.btn_LoadBuildProp)
        Me.tb_buildprop.Controls.Add(Me.btn_BackupBuildProp)
        Me.tb_buildprop.Controls.Add(Me.btn_SaveBuildProp)
        Me.tb_buildprop.Location = New System.Drawing.Point(4, 29)
        Me.tb_buildprop.Name = "tb_buildprop"
        Me.tb_buildprop.Padding = New System.Windows.Forms.Padding(3)
        Me.tb_buildprop.Size = New System.Drawing.Size(875, 281)
        Me.tb_buildprop.TabIndex = 4
        Me.tb_buildprop.Text = "Build Prop Editor"
        Me.tb_buildprop.UseVisualStyleBackColor = True
        '
        'txt_buildprop
        '
        Me.txt_buildprop.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.txt_buildprop.Enabled = False
        Me.txt_buildprop.IsReadOnly = False
        Me.txt_buildprop.LineViewerStyle = ICSharpCode.TextEditor.Document.LineViewerStyle.FullRow
        Me.txt_buildprop.Location = New System.Drawing.Point(6, 9)
        Me.txt_buildprop.Name = "txt_buildprop"
        Me.txt_buildprop.Size = New System.Drawing.Size(863, 206)
        Me.txt_buildprop.TabIndex = 8
        '
        'btn_BuildPropTweaks
        '
        Me.btn_BuildPropTweaks.Enabled = False
        Me.btn_BuildPropTweaks.Location = New System.Drawing.Point(227, 231)
        Me.btn_BuildPropTweaks.Name = "btn_BuildPropTweaks"
        Me.btn_BuildPropTweaks.Size = New System.Drawing.Size(66, 44)
        Me.btn_BuildPropTweaks.TabIndex = 3
        Me.btn_BuildPropTweaks.Text = "Tweaks"
        Me.btn_BuildPropTweaks.UseVisualStyleBackColor = True
        '
        'lbl_BuildPropStats
        '
        Me.lbl_BuildPropStats.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbl_BuildPropStats.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_BuildPropStats.ForeColor = System.Drawing.Color.Black
        Me.lbl_BuildPropStats.Location = New System.Drawing.Point(326, 231)
        Me.lbl_BuildPropStats.Name = "lbl_BuildPropStats"
        Me.lbl_BuildPropStats.Size = New System.Drawing.Size(273, 44)
        Me.lbl_BuildPropStats.TabIndex = 7
        Me.lbl_BuildPropStats.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btn_LoadBuildProp
        '
        Me.btn_LoadBuildProp.Location = New System.Drawing.Point(9, 231)
        Me.btn_LoadBuildProp.Name = "btn_LoadBuildProp"
        Me.btn_LoadBuildProp.Size = New System.Drawing.Size(66, 44)
        Me.btn_LoadBuildProp.TabIndex = 0
        Me.btn_LoadBuildProp.Text = "Load"
        Me.btn_LoadBuildProp.UseVisualStyleBackColor = True
        '
        'btn_BackupBuildProp
        '
        Me.btn_BackupBuildProp.Enabled = False
        Me.btn_BackupBuildProp.Location = New System.Drawing.Point(155, 231)
        Me.btn_BackupBuildProp.Name = "btn_BackupBuildProp"
        Me.btn_BackupBuildProp.Size = New System.Drawing.Size(66, 44)
        Me.btn_BackupBuildProp.TabIndex = 2
        Me.btn_BackupBuildProp.Text = "Backup"
        Me.btn_BackupBuildProp.UseVisualStyleBackColor = True
        '
        'btn_SaveBuildProp
        '
        Me.btn_SaveBuildProp.Enabled = False
        Me.btn_SaveBuildProp.Location = New System.Drawing.Point(81, 231)
        Me.btn_SaveBuildProp.Name = "btn_SaveBuildProp"
        Me.btn_SaveBuildProp.Size = New System.Drawing.Size(66, 44)
        Me.btn_SaveBuildProp.TabIndex = 1
        Me.btn_SaveBuildProp.Text = "Save"
        Me.btn_SaveBuildProp.UseVisualStyleBackColor = True
        '
        'Advanced
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit
        Me.Controls.Add(Me.TC_Advanced)
        Me.Name = "Advanced"
        Me.Size = New System.Drawing.Size(918, 360)
        Me.TC_Advanced.ResumeLayout(False)
        Me.tb_select_apkt.ResumeLayout(False)
        Me.tb_select_apkt.PerformLayout()
        Me.gb_apkt_at.ResumeLayout(False)
        Me.gb_apkt_st.ResumeLayout(False)
        Me.tb_abe.ResumeLayout(False)
        Me.tb_abe.PerformLayout()
        Me.gb_abe.ResumeLayout(False)
        Me.gb_abe.PerformLayout()
        Me.tb_buildprop.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TC_Advanced As TabControl
    Friend WithEvents tb_select_apkt As TabPage
    Friend WithEvents lbl_apkt_checkproj As Label
    Friend WithEvents gb_apkt_at As GroupBox
    Friend WithEvents btn_apkt_verify As Button
    Friend WithEvents btn_apkt_marketsign As Button
    Friend WithEvents btn_apkt_compile As Button
    Friend WithEvents btn_apkt_decompile As Button
    Friend WithEvents gb_apkt_st As GroupBox
    Friend WithEvents btn_apkt_allinone As Button
    Friend WithEvents btn_apkt_zipa As Button
    Friend WithEvents btn_apkt_signapk As Button
    Friend WithEvents btn_apkt_zip As Button
    Friend WithEvents btn_apkt_extapk As Button
    Friend WithEvents chbx_apkt_system As CheckBox
    Friend WithEvents list_apkt As ListBox
    Friend WithEvents tb_abe As TabPage
    Friend WithEvents lbl_abe_readme2 As Label
    Friend WithEvents ll_abe_installpolicy As LinkLabel
    Friend WithEvents lbl_abe_readme As Label
    Friend WithEvents lbl_abe_pass As Label
    Friend WithEvents txt_abe_pass As TextBox
    Friend WithEvents gb_abe As GroupBox
    Friend WithEvents cb_abe_android As CheckBox
    Friend WithEvents btn_abe_start As Button
    Friend WithEvents rb_abe_pack As RadioButton
    Friend WithEvents rb_abe_unpack As RadioButton
    Friend WithEvents btn_abe_showtar As Button
    Friend WithEvents lbl_abe_tarpath As Label
    Friend WithEvents lbl_abe_abpath As Label
    Friend WithEvents btn_abe_showab As Button
    Friend WithEvents txt_abe_tarpath As TextBox
    Friend WithEvents txt_abe_abpath As TextBox
    Friend WithEvents tb_buildprop As TabPage
    Friend WithEvents btn_BuildPropTweaks As Button
    Friend WithEvents lbl_BuildPropStats As Label
    Friend WithEvents btn_LoadBuildProp As Button
    Friend WithEvents btn_BackupBuildProp As Button
    Friend WithEvents btn_SaveBuildProp As Button
    Friend WithEvents txt_buildprop As ICSharpCode.TextEditor.TextEditorControl
End Class
