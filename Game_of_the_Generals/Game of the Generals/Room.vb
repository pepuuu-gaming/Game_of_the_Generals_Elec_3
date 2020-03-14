Imports System.IO
Imports FireSharp.Config
Imports FireSharp.Response
Imports FireSharp.Interfaces
Public Class Room
    Dim a As String
    Private fcon As New FirebaseConfig With
        {
        .AuthSecret = "XMpD0khO3QHVDvlc1C3qyeWBu5OYC6Ctk2FupkIN",
        .BasePath = "https://game-of-the-generals-vb.firebaseio.com/"
        }

    Private client As IFirebaseClient


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

        Dim res = client.Get("room/" + TextBox1.Text)

        If res Is Nothing Then
            MessageBox.Show("Room isn't available\n You can create the room and host it")
            TextBox1.BackColor = Color.Green
        Else
            'Dim newGame As gameboard = New gameboard(False)
            'If Not newGame.IsDisposed Then
            '    newGame.ShowDialog()
            '    Visible = True
            'End If
        End If

        'gameboard.Show()
        'Me.Close()
    End Sub

    Private Sub ButtonHostGame_Click(sender As Object, e As EventArgs) Handles ButtonHostGame.Click
        a = TextBox1.Text
        'client.Set("room/" + TextBox1.Text, "") 'ROOM SETTINGS

        'Dim res = client.Get("Users/" + name_input)
        'Dim b As String
        'b = res.ResultAs(Of String)

        'If IsNothing(b) Then
        '    MessageBox.Show("Name available")
        '    client.Set("Users/" + name_input, "")
        '    MessageBox.Show("Hi " & name_input & " your data was stored successfully.")
        '    TextBox1.BackColor = Color.White
        'Else
        '    MessageBox.Show("Name already Taken")
        '    TextBox1.BackColor = Color.Red
        'End If
        If a.Count > 0 Then
            Dim res = client.Get("room/" + TextBox1.Text)
            Dim b As String
            b = res.ResultAs(Of String)
            If Not IsNothing(b) Then
                MessageBox.Show("Room is already created")
                TextBox1.BackColor = Color.Red
            Else
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
                        .p1 = "",
                        .p2 = "",
                        .p3 = "",
                        .p4 = "",
                        .p5 = "",
                        .p6 = "",
                        .p7 = "",
                        .p8 = "",
                        .p9 = "",
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
                    .name = ""
                    }

                Dim roomDatabase As New RoomDatabase With
                    {
                    .isReady = False,
                    .playerTurn = False,
                    .whoWin = ""
                    }


                client.Set("room/" + TextBox1.Text, roomDatabase) 'ROOM SETTINGS
                client.Set("room/" + TextBox1.Text + "/arbitrary", arbitrary)
                client.Set("room/" + TextBox1.Text + "/move", move)
                client.Set("room/" + TextBox1.Text + "/player1", player1)
                client.Set("room/" + TextBox1.Text + "/player2", player2)
                client.Set("room/" + TextBox1.Text + "/player1" + "/piece", piece)
                client.Set("room/" + TextBox1.Text + "/player2" + "/piece", piece)
                'Dim newGame As gameboard = New gameboard(True)
                'Visible = False
                'If Not newGame.IsDisposed Then
                '    newGame.ShowDialog()
                '    Visible = True
                'End If
                gameboard.Show()
                Me.Close()
            End If
        Else
            MessageBox.Show("Please type the room name")
        End If


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