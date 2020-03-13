Imports System.IO

Public Class PopupNameInputBox

    Dim name_input As String
    Dim file_name As String

    Private Sub setHostName_Click(sender As Object, e As EventArgs) Handles setHostName.Click
        file_name = "host"
        name_input = TextBox1.Text
        file_name += ".txt"
        Try
            Using file_write As StreamWriter = New StreamWriter(file_name)
                file_write.WriteLine(name_input)
            End Using
        Catch ex As Exception
            Dim error_key As String = ex.ToString
            MessageBox.Show("The file can't be processed " + error_key)
        End Try
    End Sub

    Private Sub setGuestName_Click(sender As Object, e As EventArgs) Handles setGuestName.Click
        file_name = "guest"
        name_input = TextBox1.Text
        file_name += ".txt"
        Try
            Using file_write As StreamWriter = New StreamWriter(file_name)
                file_write.WriteLine(name_input)
            End Using
        Catch ex As Exception
            Dim error_key As String = ex.ToString
            MessageBox.Show("The file can't be processed " + error_key)
        End Try
    End Sub

    Private Sub PopupNameInputBox_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim r As RoundButton = New RoundButton
        r.Round(setHostName, 10)
        r.Round(setGuestName, 10)
    End Sub
End Class