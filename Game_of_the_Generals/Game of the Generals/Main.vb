﻿Public Class homepage
    Private Sub homepage_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        My.Computer.Audio.Play(My.Resources.GOG, AudioPlayMode.BackgroundLoop)
        Dim a As RoundButton = New RoundButton
        a.Round(ButtonPlay, 40)

        Dim b As RoundButton = New RoundButton
        b.Round(ButtonTutorials, 40)

        Dim c As RoundButton = New RoundButton
        c.Round(ButtonOptions, 40)



    End Sub


    Private Sub ButtonPlay_Click(sender As Object, e As EventArgs) Handles ButtonPlay.Click
        Room.Show()
        Me.Hide()
    End Sub

    Private Sub ButtonTutorials_Click(sender As Object, e As EventArgs) Handles ButtonTutorials.Click
        Tutorial.Show()
        Me.Hide()
    End Sub

    Private Sub ButtonOptions_Click(sender As Object, e As EventArgs) Handles ButtonOptions.Click
        Options.Show()
        Me.Hide()
    End Sub
End Class
