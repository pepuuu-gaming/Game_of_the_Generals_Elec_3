Public Class homepage
    Private Sub homepage_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim a As RoundButton = New RoundButton
        a.Round(Button1, 40)

        Dim b As RoundButton = New RoundButton
        b.Round(Button2, 40)

        Dim c As RoundButton = New RoundButton
        c.Round(Button3, 40)



    End Sub


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        gameboard.Show()
        Me.Hide()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        'tutorials.Show()
        Me.Hide()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        'options.Show()
        Me.Hide()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Tutorial.Show()
    End Sub
End Class
