Imports SpeechLib
Public Class Loader
    Public WithEvents vox As New SpVoice
    Public RateOfSpeech As Integer = 0
    Sub TypingText(ByVal Word As String)
        Static NextChar As Integer
        Dim Length As Integer
        Dim Display As String
        NextChar = NextChar + 1
        Length = Length + 1
        Display = Mid$(Word, NextChar, Length)
        Label5.Text = Label5.Text & Display
    End Sub
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Label3.Text = ProgressBar1.Value.ToString() + " %" + " "
        If ProgressBar1.Value < 10 And ProgressBar1.Value > 0 Then
            Label4.Text = "Loading Some Few Specs..."
        ElseIf ProgressBar1.Value < 15 And ProgressBar1.Value > 10 Then
            Label4.Text = "Organizing Codes and Elements..."
        ElseIf ProgressBar1.Value < 20 And ProgressBar1.Value > 15 Then
            Label4.Text = "Proccessing The Data..."
        ElseIf ProgressBar1.Value < 30 And ProgressBar1.Value > 20 Then
            Label4.ForeColor = Color.Blue
            Label4.Text = "Reporting."
        ElseIf ProgressBar1.Value < 40 And ProgressBar1.Value > 30 Then
            Label4.ForeColor = Color.Brown
            Label4.Text = "Analyzing Report....."
        ElseIf ProgressBar1.Value < 50 And ProgressBar1.Value > 40 Then
            Label4.ForeColor = Color.Orange
            Label4.Text = "Re-Analyzing Scripts..."
        ElseIf ProgressBar1.Value < 60 And ProgressBar1.Value > 50 Then
            Label4.ForeColor = Color.Orange
            Label4.Text = "Breaking Down....."
        ElseIf ProgressBar1.Value < 70 And ProgressBar1.Value > 60 Then
            Label4.ForeColor = Color.Orange
            Label4.Text = "Finishing up."
        ElseIf ProgressBar1.Value < 80 And ProgressBar1.Value > 70 Then
            Label4.ForeColor = Color.Orange
            Label4.Text = "Preparing Tabs......"
        ElseIf ProgressBar1.Value < 90 And ProgressBar1.Value > 80 Then
            Label4.ForeColor = Color.Purple
            Label4.Text = "Preparing Console Screen."
        ElseIf ProgressBar1.Value < 100 And ProgressBar1.Value > 90 Then
            Label4.ForeColor = Color.Red
            Label4.Text = "Al-most done."
        End If
        ProgressBar1.BackColor = Color.White
        If ProgressBar1.Value = 100% Then
            Timer1.Enabled = False
            vox.Speak("", SpeechVoiceSpeakFlags.SVSFPurgeBeforeSpeak)
            Viral.Show()
            Me.Close()
        Else
            ProgressBar1.Value = ProgressBar1.Value + 1
        End If
    End Sub

    Private Sub Loader_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Label5.Text = ""
    End Sub

    Private Sub Timersec_Tick(sender As Object, e As EventArgs) Handles Timersec.Tick
        vox.Rate = RateOfSpeech
        TypingText("This Section is Filled with Open Malwares, created with no intention" & vbCrLf & "of bieng used maliciosly as any damage caused upon your system Or" & vbCrLf & "any other, we would not be hold up to any responsibility from your" & vbCrLf & "actions.")
        vox.Speak(Label6.Text, SpeechVoiceSpeakFlags.SVSFlagsAsync)
        Label6.Text = "This Section is Filled with Open Malwares, created with no intention of bieng used maliciosly as any damage caused upon your system or any other, we would not be hold up to any responsibility from your actions."
    End Sub
End Class