Public Class TutorialPage7
    Private Sub BtnTutorialNext_Click(sender As Object, e As EventArgs) Handles BtnTutorialNext.Click
        TutorialPage8.Show()
        Me.Hide()
    End Sub

    Private Sub back_to_menu_Click(sender As Object, e As EventArgs) Handles back_to_menu.Click
        TutorialPage6.Show()
        Me.Hide()
    End Sub

    Private Sub TutorialPage7_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim a As RoundButton = New RoundButton
        a.Round(BtnTutorialNext, 40)
    End Sub
End Class