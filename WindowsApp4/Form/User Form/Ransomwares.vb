Imports System.Text.RegularExpressions
Public Class Ransomwares
    Dim days As Double
    Dim hour As Double
    Dim minute As Double
    Dim second As Double
    Private TargetDT As DateTime
    Private CountDownFrom As TimeSpan
    Private CompTime As System.Int32
    Public M As Main
    Public OK As Boolean
    Public ofd As New OpenFileDialog

    Private Sub frmSinglePlayer_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        TextBox1.Text = 1
        TextBox2.Text = 10
        TextBox3.Text = 1
        TextBox4.Text = 15
    End Sub

    Private Sub tmrCountdown_Tick(sender As Object, e As System.EventArgs) Handles tmrCountdown.Tick
        CountDownFrom = TargetDT - DateTime.Now
        Dim output As TimeSpan = New TimeSpan(CountDownFrom.Days, CountDownFrom.Hours, CountDownFrom.Minutes, CountDownFrom.Seconds)
        ThirdEYE.Label2.Text = output.ToString

        If (CountDownFrom.Ticks < 0) Then
            tmrCountdown.Stop()
        End If
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If TextBox1.Text.Trim = "" Or TextBox2.Text.Trim = "" Or TextBox3.Text.Trim = "" Or TextBox4.Text.Trim = "" Then
            MessageBox.Show("Input, Please!!! (Digits Only)", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If
        TargetDT = DateTime.Now
        hour = System.Convert.ToDouble(TextBox1.Text)
        minute = System.Convert.ToDouble(TextBox2.Text)
        second = System.Convert.ToDouble(TextBox4.Text)
        days = System.Convert.ToDouble(TextBox3.Text)
        TargetDT = TargetDT.AddHours(hour)
        TargetDT = TargetDT.AddMinutes(minute)
        TargetDT = TargetDT.AddSeconds(second)
        TargetDT = TargetDT.AddDays(days)
        tmrCountdown.Start()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked = True Then
            CompTime = Environment.TickCount
            Timer1.Start()
        Else
            Timer1.Stop()
        End If
    End Sub

    Private Sub TextBoxes_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox1.KeyPress, TextBox2.KeyPress, TextBox3.KeyPress, TextBox4.KeyPress
        If Not Char.IsNumber(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub TextBox1_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles TextBox1.TextChanged
        Dim digitsOnly As Regex = New Regex("[^\d]")
        TextBox1.Text = digitsOnly.Replace(TextBox1.Text, "")
        Dim intValue As Integer
        If Integer.TryParse(TextBox1.Text, intValue) AndAlso intValue >= 0 AndAlso intValue <= 900 Then
        Else
            MessageBox.Show("Input Hours Are MAX Of 900 hrs And MIN Of 0 hrs", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
            TextBox1.Text = ""
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        ThirdEYE.Show()
    End Sub

    Private Sub TextBox2_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles TextBox2.TextChanged
        Dim digitsOnly As Regex = New Regex("[^\d]")
        TextBox2.Text = digitsOnly.Replace(TextBox2.Text, "")
        Dim intValue As Integer
        If Integer.TryParse(TextBox2.Text, intValue) AndAlso intValue >= 0 AndAlso intValue <= 60 Then
        Else
            MessageBox.Show("Input Minutes Are MAX Of 60 min And MIN Of 0 min", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
            TextBox2.Text = ""
        End If
    End Sub

    Private Sub Timer1_Tick_1(sender As Object, e As EventArgs) Handles Timer1.Tick

        Dim CurTickValue As System.Int32 = Environment.TickCount
        Dim Difference As System.Int32 = CurTickValue - CompTime

        Dim Days As System.Int32
        Dim Hours As System.Int32
        Dim Minutes As System.Int32
        Dim Seconds As System.Int32

        Days = (Difference / (86400 * 999)) Mod 365
        Hours = (Difference / (3600 * 999)) Mod 24
        Minutes = (Difference / (60 * 999)) Mod 60
        Seconds = (Difference / 999) Mod 60

        ThirdEYE.Label1.Text = String.Format("{0} Days, {1} hours, {2} minutes {3} seconds",
                                CStr(Days),
                                CStr(Hours),
                                CStr(Minutes),
                                CStr(Seconds))

    End Sub

    Private Sub Button2_Click_1(sender As Object, e As EventArgs) Handles Button2.Click
        Timer1.Stop()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        tmrCountdown.Stop()
        tmrCountdown.Start()
    End Sub

    Private Sub PictureBox1_Click_1(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Try
            With ofd
                .Filter = "Image File(*.JPEG;*.JPG)|*.JPEG;*.JPG;|All files (*.*)|*.*"
                .Title = "Select a Image File"
                .InitialDirectory = Application.StartupPath
            End With

            If ofd.ShowDialog = Windows.Forms.DialogResult.OK Then
                PictureBox1.ImageLocation = ofd.FileName
                PictureBox1.BackgroundImage = PictureBox1.Image
                ThirdEYE.BackgroundImage = PictureBox1.BackgroundImage
            Else
                PictureBox1.ImageLocation = Nothing
            End If

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub
End Class