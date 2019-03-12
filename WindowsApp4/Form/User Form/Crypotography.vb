﻿Imports System.IO
Public Class Crypotography
    Private rbProviderClick As Crypter.CryptAlgorithms
    Private WithEvents Watcher As New System.IO.FileSystemWatcher()
    Private Sub Crypotography_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub ButtonClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click, btnDecrypt.Click, btnEncrypt.Click, Button2.Click, Button3.Click

        Dim btn As Button = CType(sender, Button)
        btn.Enabled = False

        If btn Is Button1 Then
            With OpenFileDialog1
                .Filter = ""
                If .ShowDialog() <> DialogResult.Cancel Then
                    TextBox1.Text = .FileName
                    txtLog.Text &= "FileIn: " & .FileName & vbCrLf
                End If
            End With
        ElseIf btn Is Button2 Then
            With SaveFileDialog1
                .Filter = ""
                .RestoreDirectory = True
                If .ShowDialog() = DialogResult.OK Then
                    TextBox2.Text = .FileName
                    txtLog.Text &= "FileOut " & .FileName & vbCrLf
                End If
            End With
        ElseIf btn Is btnEncrypt OrElse btn Is btnDecrypt Then
            Try
                Dim oCrypt As New Crypter(Crypter.CryptAlgorithms.Rijndael)
                With oCrypt
                    .FileIn = TextBox1.Text.Trim
                    .FileOut = TextBox2.Text.Trim
                    .Key = txtKey.Text.Trim
                    .IV = txtIV.Text.Trim
                    .CryptAlgorithm = rbProviderClick

                    If btn Is btnEncrypt Then
                        txtLog.Text &= "Encrypting with Crypt Provider " & .CryptAlgorithm("") & vbCrLf
                        .Encrypt()
                    Else
                        txtLog.AppendText("Decrypting with Crypt Provider " & oCrypt.CryptAlgorithm("") & vbCrLf)
                        oCrypt.Decrypt()
                    End If

                    RichTextBox1.Clear()
                    If .FileOut <> "" Then
                        RichTextBox1.LoadFile(.FileOut, RichTextBoxStreamType.PlainText)
                    Else
                        RichTextBox1.LoadFile(.FileIn, RichTextBoxStreamType.PlainText)
                    End If
                End With
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
        ElseIf btn Is Button3 Then
            txtLog.Text &= "Swap File: " & TextBox2.Text & vbCrLf
            TextBox1.Tag = TextBox1.Text
            TextBox1.Text = TextBox2.Text
            TextBox2.Text = CType(TextBox1.Tag, String)
        End If
        btn.Enabled = True
    End Sub
    Private Sub rb_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbRijndael.Click, rbDES.Click, rbRC2.Click, rbTripleDES.Click, rbXor.Click
        rbProviderClick = CType(DirectCast(sender, RadioButton).Tag, Crypter.CryptAlgorithms)
    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim args As String() = System.Environment.GetCommandLineArgs
        If args.Length > 1 Then TextBox1.Text = args(1)
        If args.Length > 2 Then TextBox2.Text = args(2)

        rbProviderClick = Crypter.CryptAlgorithms.Rijndael
        With ToolTip1
            .AutoPopDelay = 5000
            .InitialDelay = 10
            .ReshowDelay = 500
            .ShowAlways = True
            .SetToolTip(Me.rbRijndael, "256 bits Crypting")
            .SetToolTip(Me.rbTripleDES, "192 bit Crypting")
            .SetToolTip(Me.rbDES, "64 bits Crypting")
            .SetToolTip(Me.rbRC2, "128 bits Crypting")
            .SetToolTip(Me.rbXor, "256 bits Crypting" & vbCrLf & "can be modified in SourceCode" & vbCrLf & vbCrLf & "Written by Ted Schopenhouer")
            .SetToolTip(Me.txtIV, "Sets the initialization vector (IV) for the symmetric algorithm")
            .SetToolTip(Me.txtKey, "Sets the secret key for the symmetric algorithm.")
            .SetToolTip(Me.Button3, "Swap FileNameIn to FileNameOut" & vbCrLf & "and" & vbCrLf & "Swap FileNameOut to FileNameIn")
            .SetToolTip(Me.Button2, "If Empty FileNameOut, FileNameIn will be overwrite!")
            .SetToolTip(Me.Button1, "FileName to (En/De)Crypt")
        End With
        With Watcher
            .Path = "\"
            .Filter = "*.*"
            .IncludeSubdirectories = True
            .NotifyFilter = NotifyFilters.LastWrite Or NotifyFilters.LastAccess Or NotifyFilters.FileName Or NotifyFilters.Size
            .EnableRaisingEvents = True
        End With
    End Sub

    Private Sub Watcher_Created(ByVal sender As Object, ByVal e As System.IO.FileSystemEventArgs) Handles Watcher.Created, Watcher.Deleted, Watcher.Changed
        txtLog.AppendText(e.ChangeType.ToString & " <--> " & e.Name & ControlChars.CrLf)
    End Sub

    Private Sub Watcher_Renamed(ByVal sender As Object, ByVal e As System.IO.RenamedEventArgs) Handles Watcher.Renamed
        txtLog.AppendText(e.ChangeType.ToString & " <--> " & e.Name & ControlChars.CrLf)
    End Sub

    Private Sub Watcher_Error(ByVal sender As Object, ByVal e As System.IO.ErrorEventArgs) Handles Watcher.Error
        txtLog.AppendText(e.GetException.Message.ToString & vbCrLf)
    End Sub

End Class