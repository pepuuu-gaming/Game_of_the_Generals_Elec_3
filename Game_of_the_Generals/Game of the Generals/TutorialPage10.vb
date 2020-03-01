Public Class TutorialPage10
    Private Sub back_to_menu_Click(sender As Object, e As EventArgs) Handles back_to_menu.Click
        TutorialPage9.Show()
        Me.Hide()
    End Sub

    Private Sub TutorialPage10_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim a As RoundButton = New RoundButton
        a.Round(BtnTutorialNext, 40)
    End Sub

    Private Sub BtnTutorialNext_Click(sender As Object, e As EventArgs) Handles BtnTutorialNext.Click
        'TutorialPage11.Show()
        Me.Hide()
    End Sub
End Class