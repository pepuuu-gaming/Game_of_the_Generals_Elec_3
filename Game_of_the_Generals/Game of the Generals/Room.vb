Public Class Room
    Private Sub Room_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim d As RoundButton = New RoundButton
        d.Round(ButtonConnect, 20)
        d.Round(ButtonHostGame, 20)

    End Sub

    Private Sub ButtonConnect_Click(sender As Object, e As EventArgs) Handles ButtonConnect.Click
        gameboard.Show()
        Me.Close()
    End Sub

    Private Sub ButtonHostGame_Click(sender As Object, e As EventArgs) Handles ButtonHostGame.Click
        gameboard.Show()
        Me.Close()
    End Sub

    Private Sub back_to_menu_Click(sender As Object, e As EventArgs) Handles back_to_menu.Click
        homepage.Show()
        Me.Close()
    End Sub
End Class