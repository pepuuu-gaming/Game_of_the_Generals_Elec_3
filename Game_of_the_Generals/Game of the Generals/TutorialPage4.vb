﻿Public Class TutorialPage4
    Private Sub back_to_menu_Click(sender As Object, e As EventArgs) Handles back_to_menu.Click
        TutorialPage3.Show()
        Me.Hide()
    End Sub

    Private Sub TutorialPage4_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim a As RoundButton = New RoundButton
        a.Round(BtnTutorialNext, 40)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles BtnTutorialNext.Click
        TutorialPage5.Show()
        Me.Hide()
    End Sub
End Class