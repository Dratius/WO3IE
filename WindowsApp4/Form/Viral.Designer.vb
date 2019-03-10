Imports WindowsApp4

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Viral
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Viral))
        Me.NotifyIcon1 = New System.Windows.Forms.NotifyIcon(Me.components)
        Me.PageSetupDialog1 = New System.Windows.Forms.PageSetupDialog()
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog()
        Me.EventLog1 = New System.Diagnostics.EventLog()
        Me.PanelLeft = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Button7 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.ButtonVirus = New System.Windows.Forms.Button()
        Me.HelpProvider1 = New System.Windows.Forms.HelpProvider()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.FontDialog1 = New System.Windows.Forms.FontDialog()
        Me.Ransomwares2 = New WindowsApp4.Ransomwares()
        Me.BatchVault2 = New WindowsApp4.BatchVault()
        CType(Me.EventLog1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.Panel4.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'NotifyIcon1
        '
        Me.NotifyIcon1.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info
        Me.NotifyIcon1.Text = "Wildxe"
        Me.NotifyIcon1.Visible = True
        '
        'EventLog1
        '
        Me.EventLog1.Log = "Application"
        Me.EventLog1.SynchronizingObject = Me
        '
        'PanelLeft
        '
        Me.PanelLeft.BackColor = System.Drawing.Color.Lime
        Me.PanelLeft.Location = New System.Drawing.Point(140, 77)
        Me.PanelLeft.Name = "PanelLeft"
        Me.HelpProvider1.SetShowHelp(Me.PanelLeft, True)
        Me.PanelLeft.Size = New System.Drawing.Size(10, 62)
        Me.PanelLeft.TabIndex = 4
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(23, Byte), Integer), CType(CType(54, Byte), Integer), CType(CType(76, Byte), Integer))
        Me.Panel2.Controls.Add(Me.Button7)
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Controls.Add(Me.Button1)
        Me.Panel2.Controls.Add(Me.PanelLeft)
        Me.Panel2.Controls.Add(Me.ButtonVirus)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel2.ForeColor = System.Drawing.Color.Goldenrod
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.HelpProvider1.SetShowHelp(Me.Panel2, True)
        Me.Panel2.Size = New System.Drawing.Size(150, 645)
        Me.Panel2.TabIndex = 1
        '
        'Button7
        '
        Me.Button7.BackColor = System.Drawing.Color.SlateGray
        Me.Button7.FlatAppearance.BorderColor = System.Drawing.Color.Aqua
        Me.Button7.FlatAppearance.BorderSize = 3
        Me.Button7.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Green
        Me.Button7.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Goldenrod
        Me.Button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button7.Font = New System.Drawing.Font("Stencil", 11.25!)
        Me.Button7.ForeColor = System.Drawing.Color.Black
        Me.Button7.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Button7.Location = New System.Drawing.Point(19, 544)
        Me.Button7.Name = "Button7"
        Me.HelpProvider1.SetShowHelp(Me.Button7, True)
        Me.Button7.Size = New System.Drawing.Size(103, 31)
        Me.Button7.TabIndex = 33
        Me.Button7.Text = "Save As"
        Me.Button7.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Freestyle Script", 26.25!)
        Me.Label1.ForeColor = System.Drawing.Color.DarkGoldenrod
        Me.Label1.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label1.Location = New System.Drawing.Point(12, 13)
        Me.Label1.Name = "Label1"
        Me.HelpProvider1.SetShowHelp(Me.Label1, True)
        Me.Label1.Size = New System.Drawing.Size(122, 42)
        Me.Label1.TabIndex = 32
        Me.Label1.Text = "<ER40R>"
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Transparent
        Me.Button1.BackgroundImage = Global.WindowsApp4.My.Resources.Resources._1564510
        Me.Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Chartreuse
        Me.Button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Tan
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Bold)
        Me.Button1.ForeColor = System.Drawing.Color.White
        Me.Button1.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Button1.Location = New System.Drawing.Point(0, 145)
        Me.Button1.Name = "Button1"
        Me.HelpProvider1.SetShowHelp(Me.Button1, True)
        Me.Button1.Size = New System.Drawing.Size(131, 62)
        Me.Button1.TabIndex = 31
        Me.Button1.Text = "Ransomwares"
        Me.Button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button1.UseVisualStyleBackColor = False
        '
        'ButtonVirus
        '
        Me.ButtonVirus.BackColor = System.Drawing.Color.Transparent
        Me.ButtonVirus.BackgroundImage = Global.WindowsApp4.My.Resources.Resources._1564534
        Me.ButtonVirus.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.ButtonVirus.FlatAppearance.BorderSize = 0
        Me.ButtonVirus.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Chartreuse
        Me.ButtonVirus.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Tan
        Me.ButtonVirus.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonVirus.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Bold)
        Me.ButtonVirus.ForeColor = System.Drawing.Color.White
        Me.ButtonVirus.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ButtonVirus.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.ButtonVirus.Location = New System.Drawing.Point(0, 77)
        Me.ButtonVirus.Name = "ButtonVirus"
        Me.HelpProvider1.SetShowHelp(Me.ButtonVirus, True)
        Me.ButtonVirus.Size = New System.Drawing.Size(131, 62)
        Me.ButtonVirus.TabIndex = 0
        Me.ButtonVirus.Text = "Batch Virus"
        Me.ButtonVirus.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ButtonVirus.UseVisualStyleBackColor = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Cyan
        Me.Panel1.Controls.Add(Me.Panel3)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(150, 0)
        Me.Panel1.Name = "Panel1"
        Me.HelpProvider1.SetShowHelp(Me.Panel1, True)
        Me.Panel1.Size = New System.Drawing.Size(641, 10)
        Me.Panel1.TabIndex = 5
        '
        'Panel3
        '
        Me.Panel3.Location = New System.Drawing.Point(407, 12)
        Me.Panel3.Name = "Panel3"
        Me.HelpProvider1.SetShowHelp(Me.Panel3, True)
        Me.Panel3.Size = New System.Drawing.Size(225, 50)
        Me.Panel3.TabIndex = 32
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Panel4.Controls.Add(Me.Button3)
        Me.Panel4.Controls.Add(Me.Button2)
        Me.Panel4.Controls.Add(Me.PictureBox1)
        Me.Panel4.Location = New System.Drawing.Point(150, 12)
        Me.Panel4.Name = "Panel4"
        Me.HelpProvider1.SetShowHelp(Me.Panel4, True)
        Me.Panel4.Size = New System.Drawing.Size(641, 47)
        Me.Panel4.TabIndex = 32
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.Transparent
        Me.Button3.BackgroundImage = Global.WindowsApp4.My.Resources.Resources._1250668
        Me.Button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Button3.FlatAppearance.BorderSize = 0
        Me.Button3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.RoyalBlue
        Me.Button3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Cyan
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button3.Font = New System.Drawing.Font("Century Gothic", 27.75!)
        Me.Button3.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Button3.Location = New System.Drawing.Point(581, 4)
        Me.Button3.Name = "Button3"
        Me.HelpProvider1.SetShowHelp(Me.Button3, True)
        Me.Button3.Size = New System.Drawing.Size(21, 18)
        Me.Button3.TabIndex = 33
        Me.Button3.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.Transparent
        Me.Button2.BackgroundImage = Global.WindowsApp4.My.Resources.Resources._63373
        Me.Button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Button2.FlatAppearance.BorderSize = 0
        Me.Button2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red
        Me.Button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Cyan
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Button2.Location = New System.Drawing.Point(608, 4)
        Me.Button2.Name = "Button2"
        Me.HelpProvider1.SetShowHelp(Me.Button2, True)
        Me.Button2.Size = New System.Drawing.Size(21, 18)
        Me.Button2.TabIndex = 32
        Me.Button2.UseVisualStyleBackColor = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Gainsboro
        Me.PictureBox1.Image = Global.WindowsApp4.My.Resources.Resources.BRILLIANT_ARTS_LOGO_MAIN
        Me.PictureBox1.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.HelpProvider1.SetShowHelp(Me.PictureBox1, True)
        Me.PictureBox1.Size = New System.Drawing.Size(48, 50)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 31
        Me.PictureBox1.TabStop = False
        '
        'Ransomwares2
        '
        Me.Ransomwares2.Location = New System.Drawing.Point(150, 77)
        Me.Ransomwares2.Name = "Ransomwares2"
        Me.Ransomwares2.Size = New System.Drawing.Size(641, 565)
        Me.Ransomwares2.TabIndex = 34
        '
        'BatchVault2
        '
        Me.BatchVault2.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.BatchVault2.Location = New System.Drawing.Point(150, 77)
        Me.BatchVault2.Name = "BatchVault2"
        Me.BatchVault2.Size = New System.Drawing.Size(641, 565)
        Me.BatchVault2.TabIndex = 33
        Me.BatchVault2.Timer1 = Nothing
        '
        'Viral
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit
        Me.BackColor = System.Drawing.Color.White
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.ClientSize = New System.Drawing.Size(791, 645)
        Me.Controls.Add(Me.Ransomwares2)
        Me.Controls.Add(Me.BatchVault2)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel2)
        Me.Font = New System.Drawing.Font("Century Gothic", 12.0!)
        Me.ForeColor = System.Drawing.Color.DarkRed
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "Viral"
        Me.HelpProvider1.SetShowHelp(Me, True)
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "WOX3IE"
        Me.TransparencyKey = System.Drawing.Color.Goldenrod
        CType(Me.EventLog1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel4.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents NotifyIcon1 As NotifyIcon
    Friend WithEvents PageSetupDialog1 As PageSetupDialog
    Friend WithEvents SaveFileDialog1 As SaveFileDialog
    Friend WithEvents EventLog1 As EventLog
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents PanelLeft As Panel
    Friend WithEvents ButtonVirus As Button
    Friend WithEvents CloseButton As WindowsApp4.ButtonZ.ButtonZ
    Friend WithEvents HelpProvider1 As HelpProvider
    Friend WithEvents FontDialog1 As FontDialog
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Button7 As Button
    Friend WithEvents Ransomwares2 As Global.WindowsApp4.Ransomwares
    Friend WithEvents BatchVault2 As Global.WindowsApp4.BatchVault
End Class
