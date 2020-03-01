Public Class TutorialPage8
    Private Sub back_to_menu_Click(sender As Object, e As EventArgs) Handles back_to_menu.Click
        TutorialPage7.Show()
        Me.Hide()
    End Sub

    Private Sub BtnTutorialNext_Click(sender As Object, e As EventArgs) Handles BtnTutorialNext.Click
        'TutorialPage9.Show()
        Me.Hide()
    End Sub

    Private Sub TutorialPage8_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim a As RoundButton = New RoundButton
        a.Round(BtnTutorialNext, 40)
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub
End Class