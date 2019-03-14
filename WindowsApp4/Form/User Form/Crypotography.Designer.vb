<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Crypotography
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
        Me.Button1 = New System.Windows.Forms.Button()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog()
        Me.RichTextBox1 = New System.Windows.Forms.RichTextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.rbXor = New System.Windows.Forms.RadioButton()
        Me.txtIV = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtKey = New System.Windows.Forms.TextBox()
        Me.lblKey = New System.Windows.Forms.Label()
        Me.rbRC2 = New System.Windows.Forms.RadioButton()
        Me.rbDES = New System.Windows.Forms.RadioButton()
        Me.rbTripleDES = New System.Windows.Forms.RadioButton()
        Me.rbRijndael = New System.Windows.Forms.RadioButton()
        Me.btnDecrypt = New System.Windows.Forms.Button()
        Me.btnEncrypt = New System.Windows.Forms.Button()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.txtLog = New System.Windows.Forms.TextBox()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(27, 73)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(158, 25)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "File to Encrypt/ Decrypt"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'TextBox2
        '
        Me.TextBox2.Font = New System.Drawing.Font("Chaparral Pro", 9.749999!)
        Me.TextBox2.Location = New System.Drawing.Point(191, 154)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(430, 23)
        Me.TextBox2.TabIndex = 29
        '
        'TextBox1
        '
        Me.TextBox1.Font = New System.Drawing.Font("Chaparral Pro", 9.749999!)
        Me.TextBox1.Location = New System.Drawing.Point(191, 73)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(430, 23)
        Me.TextBox1.TabIndex = 31
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(27, 151)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(158, 25)
        Me.Button2.TabIndex = 30
        Me.Button2.Text = "Encrypt/ Decrypt to File"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Font = New System.Drawing.Font("Trebuchet MS", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.Location = New System.Drawing.Point(27, 104)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(158, 41)
        Me.Button3.TabIndex = 32
        Me.Button3.Text = "Swap"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'RichTextBox1
        '
        Me.RichTextBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.RichTextBox1.Font = New System.Drawing.Font("Rockwell", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RichTextBox1.Location = New System.Drawing.Point(14, 362)
        Me.RichTextBox1.Name = "RichTextBox1"
        Me.RichTextBox1.Size = New System.Drawing.Size(607, 144)
        Me.RichTextBox1.TabIndex = 37
        Me.RichTextBox1.Text = ""
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.rbXor)
        Me.GroupBox1.Controls.Add(Me.txtIV)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.txtKey)
        Me.GroupBox1.Controls.Add(Me.lblKey)
        Me.GroupBox1.Controls.Add(Me.rbRC2)
        Me.GroupBox1.Controls.Add(Me.rbDES)
        Me.GroupBox1.Controls.Add(Me.rbTripleDES)
        Me.GroupBox1.Controls.Add(Me.rbRijndael)
        Me.GroupBox1.Location = New System.Drawing.Point(14, 182)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(611, 46)
        Me.GroupBox1.TabIndex = 36
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "CryptAlgorithms"
        '
        'rbXor
        '
        Me.rbXor.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.rbXor.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.rbXor.Font = New System.Drawing.Font("Rockwell", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbXor.Location = New System.Drawing.Point(260, 21)
        Me.rbXor.Name = "rbXor"
        Me.rbXor.Size = New System.Drawing.Size(58, 19)
        Me.rbXor.TabIndex = 14
        Me.rbXor.Tag = "5"
        Me.rbXor.Text = "XorTS"
        '
        'txtIV
        '
        Me.txtIV.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.txtIV.Font = New System.Drawing.Font("Rockwell", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtIV.Location = New System.Drawing.Point(522, 21)
        Me.txtIV.Name = "txtIV"
        Me.txtIV.Size = New System.Drawing.Size(70, 20)
        Me.txtIV.TabIndex = 7
        '
        'Label1
        '
        Me.Label1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label1.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label1.Font = New System.Drawing.Font("Rockwell", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(496, 19)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(23, 19)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "IV"
        '
        'txtKey
        '
        Me.txtKey.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.txtKey.Font = New System.Drawing.Font("Rockwell", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtKey.Location = New System.Drawing.Point(375, 21)
        Me.txtKey.Name = "txtKey"
        Me.txtKey.Size = New System.Drawing.Size(111, 20)
        Me.txtKey.TabIndex = 5
        '
        'lblKey
        '
        Me.lblKey.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblKey.Font = New System.Drawing.Font("Rockwell", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblKey.Location = New System.Drawing.Point(345, 21)
        Me.lblKey.Name = "lblKey"
        Me.lblKey.Size = New System.Drawing.Size(29, 19)
        Me.lblKey.TabIndex = 4
        Me.lblKey.Text = "Key"
        '
        'rbRC2
        '
        Me.rbRC2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.rbRC2.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.rbRC2.Font = New System.Drawing.Font("Rockwell", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbRC2.Location = New System.Drawing.Point(208, 21)
        Me.rbRC2.Name = "rbRC2"
        Me.rbRC2.Size = New System.Drawing.Size(48, 19)
        Me.rbRC2.TabIndex = 3
        Me.rbRC2.Tag = "4"
        Me.rbRC2.Text = "RC2"
        '
        'rbDES
        '
        Me.rbDES.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.rbDES.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.rbDES.Font = New System.Drawing.Font("Rockwell", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbDES.Location = New System.Drawing.Point(160, 21)
        Me.rbDES.Name = "rbDES"
        Me.rbDES.Size = New System.Drawing.Size(68, 19)
        Me.rbDES.TabIndex = 2
        Me.rbDES.Tag = "3"
        Me.rbDES.Text = "DES"
        '
        'rbTripleDES
        '
        Me.rbTripleDES.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.rbTripleDES.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.rbTripleDES.Font = New System.Drawing.Font("Rockwell", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbTripleDES.Location = New System.Drawing.Point(78, 21)
        Me.rbTripleDES.Name = "rbTripleDES"
        Me.rbTripleDES.Size = New System.Drawing.Size(81, 19)
        Me.rbTripleDES.TabIndex = 1
        Me.rbTripleDES.Tag = "2"
        Me.rbTripleDES.Text = "TripleDES"
        '
        'rbRijndael
        '
        Me.rbRijndael.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.rbRijndael.Checked = True
        Me.rbRijndael.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.rbRijndael.Font = New System.Drawing.Font("Rockwell", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbRijndael.Location = New System.Drawing.Point(8, 21)
        Me.rbRijndael.Name = "rbRijndael"
        Me.rbRijndael.Size = New System.Drawing.Size(68, 19)
        Me.rbRijndael.TabIndex = 0
        Me.rbRijndael.TabStop = True
        Me.rbRijndael.Tag = "1"
        Me.rbRijndael.Text = "Rijndael"
        '
        'btnDecrypt
        '
        Me.btnDecrypt.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnDecrypt.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.btnDecrypt.Font = New System.Drawing.Font("Rockwell", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDecrypt.Location = New System.Drawing.Point(308, 512)
        Me.btnDecrypt.Name = "btnDecrypt"
        Me.btnDecrypt.Size = New System.Drawing.Size(80, 33)
        Me.btnDecrypt.TabIndex = 35
        Me.btnDecrypt.Text = "Decrypt"
        '
        'btnEncrypt
        '
        Me.btnEncrypt.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnEncrypt.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.btnEncrypt.Font = New System.Drawing.Font("Rockwell", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEncrypt.Location = New System.Drawing.Point(222, 512)
        Me.btnEncrypt.Name = "btnEncrypt"
        Me.btnEncrypt.Size = New System.Drawing.Size(80, 33)
        Me.btnEncrypt.TabIndex = 34
        Me.btnEncrypt.Text = "Encrypt"
        '
        'txtLog
        '
        Me.txtLog.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtLog.Font = New System.Drawing.Font("Rockwell", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLog.Location = New System.Drawing.Point(14, 252)
        Me.txtLog.Multiline = True
        Me.txtLog.Name = "txtLog"
        Me.txtLog.ReadOnly = True
        Me.txtLog.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.txtLog.Size = New System.Drawing.Size(607, 104)
        Me.txtLog.TabIndex = 33
        Me.txtLog.Text = "LogFile"
        '
        'Crypotography
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit
        Me.Controls.Add(Me.RichTextBox1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btnDecrypt)
        Me.Controls.Add(Me.btnEncrypt)
        Me.Controls.Add(Me.txtLog)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.Button1)
        Me.Name = "Crypotography"
        Me.Size = New System.Drawing.Size(641, 565)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents SaveFileDialog1 As SaveFileDialog
    Friend WithEvents RichTextBox1 As RichTextBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents rbXor As RadioButton
    Friend WithEvents txtIV As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txtKey As TextBox
    Friend WithEvents lblKey As Label
    Friend WithEvents rbRC2 As RadioButton
    Friend WithEvents rbDES As RadioButton
    Friend WithEvents rbTripleDES As RadioButton
    Friend WithEvents rbRijndael As RadioButton
    Friend WithEvents btnDecrypt As Button
    Friend WithEvents btnEncrypt As Button
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents txtLog As TextBox
End Class
