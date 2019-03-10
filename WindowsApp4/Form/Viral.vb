Public Class Viral
    Private filesaved As Integer
    Public Property Timer1 As Object

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        BatchVault2.BringToFront()
        PanelLeft.Height = ButtonVirus.Height
        PanelLeft.Top = ButtonVirus.Top
        Flash()
        MaximizeBox = False
    End Sub

    Private Async Sub Flash()
        For i = 0 To 80
            Await Task.Delay(800)
            PanelLeft.Visible = Not PanelLeft.Visible
        Next
        PanelLeft.Visible = True
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles ButtonVirus.Click
        Button7.Visible = True
        BatchVault2.BringToFront()
        PanelLeft.Height = ButtonVirus.Height
        PanelLeft.Top = ButtonVirus.Top
        Flash()
    End Sub

    Private Sub Virus1_Load(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        Button7.Visible = False
        'Button2.Visible = True
        Ransomwares2.BringToFront()
        PanelLeft.Height = Button1.Height
        PanelLeft.Top = Button1.Top
        Flash()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs)
        ThirdEYE.Show()
    End Sub

    Private Sub Button2_Click_1(sender As Object, e As EventArgs) Handles Button2.Click
        Dim result As Integer = MessageBox.Show("Exit Now!!", "WX3", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
        If result = DialogResult.No Then
            MessageBox.Show("Process Aborted")
        ElseIf result = DialogResult.Yes Then
            Close()
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Virus2_Load(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        SaveFileDialog1.Filter = "Batch files(*.bat)|*.bat|Text files (*.txt)|*.txt|All files (*.*)|*.*"
        If SaveFileDialog1.ShowDialog = DialogResult.OK _
        Then
            filesaved = 1
            My.Computer.FileSystem.WriteAllText _
            (SaveFileDialog1.FileName, BatchVault2.RichTextBox1.Text, True)
        End If

    End Sub
End Class