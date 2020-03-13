Public Class Options
    Private Sub back_to_menu_Click(sender As Object, e As EventArgs) Handles back_to_menu.Click
        homepage.Show()
        Me.Hide()
    End Sub
    Private Sub Options_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub BtnPlayerName_Click(sender As Object, e As EventArgs) Handles BtnPlayerName.Click
        Dim name = New PopupNameInputBox()
        name.Show()
    End Sub

    Private Sub BtnSounds_Click(sender As Object, e As EventArgs) Handles BtnSounds.Click

    End Sub

    Private Sub BtnMusic_Click(sender As Object, e As EventArgs)
        My.Computer.Audio.Stop()
        BtnDisableMusic.Visible = False
        BtnEnableMusic.Visible = True
    End Sub

    Private Sub BtnDisableMusic_Click(sender As Object, e As EventArgs) Handles BtnEnableMusic.Click
        My.Computer.Audio.Play(My.Resources.GOG, AudioPlayMode.BackgroundLoop)
        BtnDisableMusic.Visible = True
        BtnEnableMusic.Visible = False
    End Sub

    Private Sub BtnDisableMusic_Click_1(sender As Object, e As EventArgs) Handles BtnDisableMusic.Click
        My.Computer.Audio.Stop()
        BtnDisableMusic.Visible = False
        BtnEnableMusic.Visible = True
    End Sub
End Class