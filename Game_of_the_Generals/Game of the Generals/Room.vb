Public Class Room
    Private Sub Room_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim d As RoundButton = New RoundButton
        d.Round(ButtonConnect, 20)
        d.Round(ButtonHostGame, 20)

    End Sub

    Private Sub ButtonConnect_Click(sender As Object, e As EventArgs) Handles ButtonConnect.Click
        Dim newGame As gameboard = New gameboard(False, TextBox1.Text)
        Visible = False
        If Not newGame.IsDisposed Then
            newGame.ShowDialog()
            Visible = True
        End If
        'gameboard.Show()
        'Me.Close()
    End Sub

    Private Sub ButtonHostGame_Click(sender As Object, e As EventArgs) Handles ButtonHostGame.Click
        Dim newGame As gameboard = New gameboard(True, "")
        Visible = False
        If Not newGame.IsDisposed Then
            newGame.ShowDialog()
            Visible = True
        End If
        'gameboard.Show()
        'Me.Close()
    End Sub

    Private Sub back_to_menu_Click(sender As Object, e As EventArgs) Handles back_to_menu.Click
        homepage.Show()
        Me.Close()
    End Sub
End Class