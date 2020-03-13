Imports System.Net.Sockets
Imports System.Net
Imports System.IO
Imports System.ComponentModel

Public Class gameboard

    Dim playerChar As Char
    Dim opponentChar As Char
    Dim sock As Socket
    Dim serverSocket As TcpListener
    Dim clientSocket As TcpClient
    Dim hostName As String
    Dim guestName As String
    Dim host As Boolean

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