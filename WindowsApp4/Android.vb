Public Class Android

    Private Sub Android_Load(sender As Object, e As EventArgs) Handles Me.Load
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

    Private Sub Buttonall_MouseHover(sender As Object, e As EventArgs) Handles Button4.MouseHover, Button5.MouseHover, Button3.MouseHover, ButtonAdb.MouseHover, ButtonFstbt.MouseHover

    End Sub
End Class