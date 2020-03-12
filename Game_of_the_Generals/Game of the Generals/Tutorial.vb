Public Class Tutorial

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles BtnBattlefield.Click
        TutorialPage1.Show()
        Me.Hide()
    End Sub

    Private Sub Tutorial_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim a As RoundButton = New RoundButton
        a.Round(BtnBattlefield, 40)
        a.Round(BtnGameplay, 40)
        a.Round(BtnObjective, 40)
        a.Round(BtnSoldiers, 40)

    End Sub

    Private Sub back_to_menu_Click(sender As Object, e As EventArgs) Handles back_to_menu.Click
        homepage.Show()
        Me.Hide()
    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles BtnObjective.Click
        TutorialPage2.Show()
        Me.Hide()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles BtnSoldiers.Click
        TutorialPage3.Show()
        Me.Hide()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles BtnGameplay.Click
        TutorialPage8.Show()
        Me.Hide()
    End Sub
End Class


