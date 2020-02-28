Public Class Tutorial

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        TutorialPage1.Show()
        Me.Close()
    End Sub

    Private Sub Tutorial_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim a As RoundButton = New RoundButton
        a.Round(Button1, 40)
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub
End Class


