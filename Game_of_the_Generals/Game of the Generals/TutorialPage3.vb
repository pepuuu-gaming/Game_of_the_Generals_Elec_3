﻿Public Class TutorialPage3
    Private Sub TutorialPage3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim a As RoundButton = New RoundButton
        a.Round(BtnTutorialNext, 40)
    End Sub

    Private Sub back_to_menu_Click(sender As Object, e As EventArgs) Handles back_to_menu.Click
        Tutorial.Show()
        Me.Hide()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles BtnTutorialNext.Click
        TutorialPage4.Show()
        Me.Hide()
    End Sub


End Class