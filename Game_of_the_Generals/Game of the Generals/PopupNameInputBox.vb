Imports System.IO
Imports FireSharp.Config
Imports FireSharp.Response
Imports FireSharp.Interfaces

Public Class PopupNameInputBox

    Private client As IFirebaseClient
    Dim name_input As String
    Dim file_name As String
    'Dim isCheck As Boolean = True

    Private fcon As New FirebaseConfig With
        {
        .AuthSecret = "XMpD0khO3QHVDvlc1C3qyeWBu5OYC6Ctk2FupkIN",
        .BasePath = "https://game-of-the-generals-vb.firebaseio.com/"
        }

    Private Sub setHostName_Click(sender As Object, e As EventArgs) Handles setHostName.Click
        file_name = "name"
        name_input = TextBox1.Text
        file_name += ".txt"
        Try
            Using file_write As StreamWriter = New StreamWriter(file_name)
                file_write.WriteLine(name_input)
            End Using

            Dim res = client.Get("Users/" + TextBox1.Text)
            If Not res Is Nothing Then
                MessageBox.Show("Name already Taken")
            Else
                'MessageBox.Show("Name available")
                client.Set("Users/" + name_input, "")
                MessageBox.Show("Hi " & name_input & " your data was stored successfully.")
            End If
            'If isCheck Then

            'Else
            '    MessageBox.Show("Hi " & name_input & " your data was stored successfully.")
            'End If
        Catch ex As Exception
            Dim error_key As String = ex.ToString
            MessageBox.Show("The file can't be processed " + error_key)
        End Try
    End Sub

    'Private Sub setGuestName_Click(sender As Object, e As EventArgs)
    '    file_name = "guest"
    '    name_input = TextBox1.Text
    '    file_name += ".txt"
    '    Try
    '        Using file_write As StreamWriter = New StreamWriter(file_name)
    '            file_write.WriteLine(name_input)
    '        End Using
    '    Catch ex As Exception
    '        Dim error_key As String = ex.ToString
    '        MessageBox.Show("The file can't be processed " + error_key)
    '    End Try
    'End Sub

    Private Sub PopupNameInputBox_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim r As RoundButton = New RoundButton
        r.Round(setHostName, 10)

        Try
            client = New FireSharp.FirebaseClient(fcon)
        Catch
            MessageBox.Show("there was a problem in the internet connection")
        End Try
        'r.Round(setGuestName, 10)
    End Sub
End Class