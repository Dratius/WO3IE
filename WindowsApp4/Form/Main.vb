Public Class Main
    Sub TypingText(ByVal Word As String)
        Static NextChar As Integer
        Dim Length As Integer
        Dim Display As String
        NextChar = NextChar + 1
        Length = Length + 1
        Display = Mid$(Word, NextChar, Length)
        Label2.Text = Label2.Text & Display
    End Sub
    Private Sub Main_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Label2.Text = ""
        Text = "WX3 User @" + Environment.UserName
        Label1.Text = "Welcome  " + Environment.UserName
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles TimerPanel.Tick
        TypingText("To The WX3 Control Panel. Filled with Sections of Different Categories")
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Loader.Show()
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Android.Show()
    End Sub
End Class