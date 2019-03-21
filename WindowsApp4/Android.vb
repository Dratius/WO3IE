Public Class Android

    Public Sub GetDevInfo()
        Dim cmdInput As String = "shell getprop ro.product.model"
        Dim proc As New Process

        Try
            proc.StartInfo.CreateNoWindow = True
            proc.StartInfo.UseShellExecute = False
            proc.StartInfo.FileName = "adb.exe"
            proc.StartInfo.Verb = "runas"
            proc.StartInfo.Arguments = cmdInput
            proc.StartInfo.RedirectStandardOutput = True
            proc.StartInfo.RedirectStandardInput = True
            proc.StartInfo.RedirectStandardError = True
            proc.Start()

            proc.StandardInput.WriteLine(cmdInput)
            proc.StandardInput.Close()
            lbl_DevInfo.Text = proc.StandardOutput.ReadLine

            If lbl_DevInfo.Text = "" Then
                lbl_DevInfo.Text = "No Device Detected"
            End If
        Finally
            proc.Close()
            proc.Dispose()
        End Try
    End Sub

    Private Sub Android_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        PanelBottom.Width = ButtonAdb.Width
        PanelBottom.Left = ButtonAdb.Left
    End Sub

    Private Sub ButtonAdb_Click(sender As Object, e As EventArgs) Handles ButtonAdb.Click
        PanelBottom.Width = ButtonAdb.Width
        PanelBottom.Left = ButtonAdb.Left
    End Sub

    Private Sub ButtonFstbt_Click(sender As Object, e As EventArgs) Handles ButtonFstbt.Click
        PanelBottom.Width = ButtonFstbt.Width
        PanelBottom.Left = ButtonFstbt.Left
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        PanelBottom.Width = Button3.Width
        PanelBottom.Left = Button3.Left
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        PanelBottom.Width = Button4.Width
        PanelBottom.Left = Button4.Left
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        PanelBottom.Width = Button5.Width
        PanelBottom.Left = Button5.Left
    End Sub

    Private Sub Buttonall_MouseHover(sender As Object, e As EventArgs) Handles ButtonFstbt.MouseHover, ButtonAdb.MouseHover, Button5.MouseHover, Button4.MouseHover, Button3.MouseHover

    End Sub

    Private Sub pb_BatteryBar_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles pb_BatteryBar.MouseHover
        If pb_BatteryBar.Value = pb_BatteryBar.Maximum Then
            ToolTip1.Show("Battery Charged", pb_BatteryBar)
        ElseIf pb_BatteryBar.Value = 0 Then
            ToolTip1.Show("Battery Capacity Not Available", pb_BatteryBar)
        Else
            ToolTip1.Show("Battery Charging", pb_BatteryBar)
        End If
    End Sub

    Private Sub lbl_Battery_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles lbl_Battery.TextChanged
        If lbl_Battery.Text = "-" Then
            pb_BatteryBar.Value = 0
        ElseIf lbl_Battery.Text = Nothing Then
            pb_BatteryBar.Value = 0
        Else
            pb_BatteryBar.Value = lbl_Battery.Text
        End If
    End Sub
End Class