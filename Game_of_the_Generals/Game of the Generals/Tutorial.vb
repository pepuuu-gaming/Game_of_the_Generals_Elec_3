Public Class Tutorial

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles ButtonProceed.Click
        TutorialPage1.Show()
        Me.Close()
    End Sub

    Private Sub Tutorial_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim a As RoundButton = New RoundButton
        a.Round(ButtonProceed, 40)
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub back_to_menu_Click(sender As Object, e As EventArgs) Handles back_to_menu.Click
        homepage.Show()
        Me.Hide()
    End Sub
End Class


