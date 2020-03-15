Imports System.IO
Imports FireSharp.Config
Imports FireSharp.Response
Imports FireSharp.Interfaces
Imports Newtonsoft.Json.Linq
Imports System.ComponentModel

Public Class Room
    Dim a As String
    Private fcon As New FirebaseConfig With
        {
        .AuthSecret = "XMpD0khO3QHVDvlc1C3qyeWBu5OYC6Ctk2FupkIN",
        .BasePath = "https://game-of-the-generals-vb.firebaseio.com/"
        }

    Private client As IFirebaseClient
    Dim roomName As String
    Dim file_name As String
    Dim playerName As String

    Private Sub Room_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim d As RoundButton = New RoundButton
        d.Round(ButtonConnect, 20)
        d.Round(ButtonHostGame, 20)

        Try
            client = New FireSharp.FirebaseClient(fcon)
        Catch
            MessageBox.Show("there was a problem in the internet connection")
        End Try
    End Sub

    Private Sub ButtonConnect_Click(sender As Object, e As EventArgs) Handles ButtonConnect.Click


        If a.Count > 0 Then
            Dim res = client.Get("room/" + TextBox1.Text)
            Dim d As JObject

            d = res.ResultAs(Of JObject)
            If Not IsNothing(d) Then
                file_name = "Roomname"
                roomName = TextBox1.Text
                file_name += ".txt"
                Using file_write As StreamWriter = New StreamWriter(file_name)
                    file_write.WriteLine(roomName)
                End Using
                'Dim name As String
                Dim file_name2 = "name.txt"
                Try
                    Using file_read As StreamReader = New StreamReader(file_name2)
                        playerName = file_read.ReadLine
                    End Using
                Catch ex As Exception
                    MessageBox.Show("Set your name first in the options menu. The game will now exit")
                    End
                End Try
                client.Set("room/" + TextBox1.Text + "/player2" + "/name", playerName) 'SET PLAYER 2 NAME
                Gameboard.Show()
                Me.Close()
            Else
                MessageBox.Show("Room isn't available. Double check your spelling also its Case sensitive. You can create the room and invite your friend")
                ButtonHostGame.BackColor = Color.Green
                ButtonConnect.BackColor = Color.Red
            End If
        Else
            MessageBox.Show("Please type the room name")
        End If
    End Sub

    Private Sub ButtonHostGame_Click(sender As Object, e As EventArgs) Handles ButtonHostGame.Click
        a = TextBox1.Text


        Dim file_name2 = "name.txt"
        Try
            Using file_read As StreamReader = New StreamReader(file_name2)
                playerName = file_read.ReadLine
            End Using

            roomName = playerName

            file_name = "Roomname"

            file_name += ".txt"
            Using file_write As StreamWriter = New StreamWriter(file_name)
                file_write.WriteLine(roomName)
            End Using
            Dim arbitrary As New Arbitrary() With {
            .p1 = "",
            .p2 = "",
            .isDraw = False,
            .isWin = False
            }
            Dim move As New Move With
            {
            .coordinate = "",
            .piece = 0
            }
            Dim piece As New Piece() With {
                .p01 = "",
                .p02 = "",
                .p03 = "",
                .p04 = "",
                .p05 = "",
                .p06 = "",
                .p07 = "",
                .p08 = "",
                .p09 = "",
                .p10 = "",
                .p11 = "",
                .p12 = "",
                .p13 = "",
                .p14 = "",
                .p15 = "",
                .p16 = "",
                .p17 = "",
                .p18 = "",
                .p19 = "",
                .p20 = "",
                .p21 = ""
            }
            Dim player1 As New Player1 With
            {
            .isReady = False,
            .name = ""
            }
            Dim player2 As New Player2 With
            {
            .isReady = False,
            .name = "Waiting for opponent"
            }

            Dim roomDatabase As New RoomDatabase With
            {
            .firstMove = True,
            .playerTurn = True,
            .whoWin = ""
            }

            'Dim name As String
            'Dim file_name2 = "name.txt"
            'Using file_read As StreamReader = New StreamReader(file_name2)
            '    name = file_read.ReadLine
            'End Using

            client.Set("room/" + roomName, roomDatabase) 'ROOM SETTINGS
            client.Set("room/" + roomName + "/arbitrary", arbitrary)
            client.Set("room/" + roomName + "/player1", player1)
            client.Set("room/" + roomName + "/player2", player2)
            client.Set("room/" + roomName + "/player1" + "/move", move)
            client.Set("room/" + roomName + "/player2" + "/move", move)
            client.Set("room/" + roomName + "/player1" + "/piece", piece)
            client.Set("room/" + roomName + "/player2" + "/piece", piece)

            client.Set("room/" + roomName + "/player1" + "/name", playerName) 'SET PLAYER 1 NAME
            Gameboard.Show()
            Me.Close()
        Catch ex As Exception
            MessageBox.Show("Set your name first in the options menu. The game will now exit")
            End
        End Try
    End Sub

    Private Sub back_to_menu_Click(sender As Object, e As EventArgs) Handles back_to_menu.Click
        homepage.Show()
        Me.Close()
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        a = TextBox1.Text

        If a.Count <= 0 Then
            TextBox1.BackColor = Color.Red
        Else
            TextBox1.BackColor = Color.White
        End If
    End Sub
End Class