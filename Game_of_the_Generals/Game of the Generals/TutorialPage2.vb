Public Class TutorialPage2

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        TutorialPage3.Show()
        Me.Hide()
    End Sub

    Private Sub back_to_menu_Click(sender As Object, e As EventArgs) Handles back_to_menu.Click
        TutorialPage1.Show()
        Me.Hide()
    End Sub

    Private Sub TutorialPage2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim a As RoundButton = New RoundButton
        a.Round(Button1, 40)
    End Sub
End Class