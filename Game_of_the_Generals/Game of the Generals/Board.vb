Imports FireSharp.Config
Imports FireSharp.Response
Imports FireSharp.Interfaces
Imports System.IO

Public Class gameboard

    Dim hostName As String
    Dim guestName As String
    Dim host As Boolean

    Private firebaseConnection As New FirebaseConfig With
        {
        .AuthSecret = "XMpD0khO3QHVDvlc1C3qyeWBu5OYC6Ctk2FupkIN",
        .BasePath = "https://game-of-the-generals-vb.firebaseio.com/"
        }

    Public Sub New(isHost As Boolean, ip As String)

        If (isHost) Then
            host = isHost

        Else


        End If

    End Sub

    Private Sub ready_Click(sender As Object, e As EventArgs) Handles ready.Click
        MessageBox.Show("ALL SET")
    End Sub
End Class