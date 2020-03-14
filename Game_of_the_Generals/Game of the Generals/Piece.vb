Public Class Piece

    Public Sub SetPrivate(a As Button, color As Color)
        a.BackgroundImage = My.Resources.private_2x
        a.BackgroundImageLayout = ImageLayout.Center
        a.BackColor = color
    End Sub

End Class
