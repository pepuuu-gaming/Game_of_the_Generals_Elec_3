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

    'Public Sub New(isHost As Boolean, ip As String)

    '    If (isHost) Then
    '        host = isHost

    '    Else


    '    End If

    'End Sub

    Private Sub back_to_menu_Click(sender As Object, e As EventArgs) Handles back_to_menu.Click
        homepage.Show()
        Me.Close()
    End Sub

    Private Sub ready_Click(sender As Object, e As EventArgs) Handles ready.Click
        MessageBox.Show("ALL SET")
    End Sub

    Private Sub gameboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim a As RoundButton = New RoundButton
        a.Round(a1, 10)
        a.Round(a2, 10)
        a.Round(a3, 10)
        a.Round(a4, 10)
        a.Round(a5, 10)
        a.Round(a6, 10)
        a.Round(a7, 10)
        a.Round(a8, 10)

        a.Round(b1, 10)
        a.Round(b2, 10)
        a.Round(b3, 10)
        a.Round(b4, 10)
        a.Round(b5, 10)
        a.Round(b6, 10)
        a.Round(b7, 10)
        a.Round(b8, 10)

        a.Round(c1, 10)
        a.Round(c2, 10)
        a.Round(c3, 10)
        a.Round(c4, 10)
        a.Round(c5, 10)
        a.Round(c6, 10)
        a.Round(c7, 10)
        a.Round(c8, 10)

        a.Round(d1, 10)
        a.Round(d2, 10)
        a.Round(d3, 10)
        a.Round(d4, 10)
        a.Round(d5, 10)
        a.Round(d6, 10)
        a.Round(d7, 10)
        a.Round(d8, 10)

        a.Round(e1, 10)
        a.Round(e2, 10)
        a.Round(e3, 10)
        a.Round(e4, 10)
        a.Round(e5, 10)
        a.Round(e6, 10)
        a.Round(e7, 10)
        a.Round(e8, 10)

        a.Round(f1, 10)
        a.Round(f2, 10)
        a.Round(f3, 10)
        a.Round(f4, 10)
        a.Round(f5, 10)
        a.Round(f6, 10)
        a.Round(f7, 10)
        a.Round(f8, 10)

        a.Round(g1, 10)
        a.Round(g2, 10)
        a.Round(g3, 10)
        a.Round(g4, 10)
        a.Round(g5, 10)
        a.Round(g6, 10)
        a.Round(g7, 10)
        a.Round(g8, 10)

        a.Round(h1, 10)
        a.Round(h2, 10)
        a.Round(h3, 10)
        a.Round(h4, 10)
        a.Round(h5, 10)
        a.Round(h6, 10)
        a.Round(h7, 10)
        a.Round(h8, 10)

        a.Round(i1, 10)
        a.Round(i2, 10)
        a.Round(i3, 10)
        a.Round(i4, 10)
        a.Round(i5, 10)
        a.Round(i6, 10)
        a.Round(i7, 10)
        a.Round(i8, 10)

        c6.BackgroundImage = My.Resources.general_of_the_army_2x
        c6.BackgroundImageLayout = ImageLayout.Center
        c6.BackColor = Color.FromArgb(20, 45, 76)
    End Sub

    Private Sub i1_Click(sender As Object, e As EventArgs) Handles i1.Click

    End Sub

    Private Sub h1_Click(sender As Object, e As EventArgs) Handles h1.Click

    End Sub

    Private Sub g1_Click(sender As Object, e As EventArgs) Handles g1.Click

    End Sub

    Private Sub f1_Click(sender As Object, e As EventArgs) Handles f1.Click

    End Sub

    Private Sub d1_Click(sender As Object, e As EventArgs) Handles d1.Click

    End Sub

    Private Sub e1_Click(sender As Object, e As EventArgs) Handles e1.Click

    End Sub

    Private Sub c1_Click(sender As Object, e As EventArgs) Handles c1.Click

    End Sub

    Private Sub b1_Click(sender As Object, e As EventArgs) Handles b1.Click

    End Sub

    Private Sub a1_Click(sender As Object, e As EventArgs) Handles a1.Click

    End Sub

    Private Sub i2_Click(sender As Object, e As EventArgs) Handles i2.Click

    End Sub

    Private Sub h2_Click(sender As Object, e As EventArgs) Handles h2.Click

    End Sub

    Private Sub g2_Click(sender As Object, e As EventArgs) Handles g2.Click

    End Sub

    Private Sub f2_Click(sender As Object, e As EventArgs) Handles f2.Click

    End Sub

    Private Sub d2_Click(sender As Object, e As EventArgs) Handles d2.Click

    End Sub

    Private Sub e2_Click(sender As Object, e As EventArgs) Handles e2.Click

    End Sub

    Private Sub c2_Click(sender As Object, e As EventArgs) Handles c2.Click

    End Sub

    Private Sub b2_Click(sender As Object, e As EventArgs) Handles b2.Click

    End Sub

    Private Sub a2_Click(sender As Object, e As EventArgs) Handles a2.Click

    End Sub

    Private Sub i3_Click(sender As Object, e As EventArgs) Handles i3.Click

    End Sub

    Private Sub h3_Click(sender As Object, e As EventArgs) Handles h3.Click

    End Sub

    Private Sub g3_Click(sender As Object, e As EventArgs) Handles g3.Click

    End Sub

    Private Sub f3_Click(sender As Object, e As EventArgs) Handles f3.Click

    End Sub

    Private Sub d3_Click(sender As Object, e As EventArgs) Handles d3.Click

    End Sub

    Private Sub e3_Click(sender As Object, e As EventArgs) Handles e3.Click

    End Sub

    Private Sub c3_Click(sender As Object, e As EventArgs) Handles c3.Click

    End Sub

    Private Sub b3_Click(sender As Object, e As EventArgs) Handles b3.Click

    End Sub

    Private Sub a3_Click(sender As Object, e As EventArgs) Handles a3.Click

    End Sub

    Private Sub i4_Click(sender As Object, e As EventArgs) Handles i4.Click

    End Sub

    Private Sub h4_Click(sender As Object, e As EventArgs) Handles h4.Click

    End Sub

    Private Sub g4_Click(sender As Object, e As EventArgs) Handles g4.Click

    End Sub

    Private Sub f4_Click(sender As Object, e As EventArgs) Handles f4.Click

    End Sub

    Private Sub d4_Click(sender As Object, e As EventArgs) Handles d4.Click

    End Sub

    Private Sub e4_Click(sender As Object, e As EventArgs) Handles e4.Click

    End Sub

    Private Sub c4_Click(sender As Object, e As EventArgs) Handles c4.Click

    End Sub

    Private Sub b4_Click(sender As Object, e As EventArgs) Handles b4.Click

    End Sub

    Private Sub a4_Click(sender As Object, e As EventArgs) Handles a4.Click

    End Sub

    Private Sub i5_Click(sender As Object, e As EventArgs) Handles i5.Click

    End Sub

    Private Sub h5_Click(sender As Object, e As EventArgs) Handles h5.Click

    End Sub

    Private Sub g5_Click(sender As Object, e As EventArgs) Handles g5.Click

    End Sub

    Private Sub f5_Click(sender As Object, e As EventArgs) Handles f5.Click

    End Sub

    Private Sub d5_Click(sender As Object, e As EventArgs) Handles d5.Click

    End Sub

    Private Sub e5_Click(sender As Object, e As EventArgs) Handles e5.Click

    End Sub

    Private Sub c5_Click(sender As Object, e As EventArgs) Handles c5.Click

    End Sub

    Private Sub b5_Click(sender As Object, e As EventArgs) Handles b5.Click

    End Sub

    Private Sub a5_Click(sender As Object, e As EventArgs) Handles a5.Click

    End Sub

    Private Sub i6_Click(sender As Object, e As EventArgs) Handles i6.Click

    End Sub

    Private Sub h6_Click(sender As Object, e As EventArgs) Handles h6.Click

    End Sub

    Private Sub g6_Click(sender As Object, e As EventArgs) Handles g6.Click

    End Sub

    Private Sub f6_Click(sender As Object, e As EventArgs) Handles f6.Click

    End Sub

    Private Sub d6_Click(sender As Object, e As EventArgs) Handles d6.Click

    End Sub

    Private Sub e6_Click(sender As Object, e As EventArgs) Handles e6.Click

    End Sub

    Private Sub c6_Click(sender As Object, e As EventArgs) Handles c6.Click

    End Sub

    Private Sub b6_Click(sender As Object, e As EventArgs) Handles b6.Click

    End Sub

    Private Sub a6_Click(sender As Object, e As EventArgs) Handles a6.Click

    End Sub

    Private Sub i7_Click(sender As Object, e As EventArgs) Handles i7.Click

    End Sub

    Private Sub h7_Click(sender As Object, e As EventArgs) Handles h7.Click

    End Sub

    Private Sub g7_Click(sender As Object, e As EventArgs) Handles g7.Click

    End Sub

    Private Sub f7_Click(sender As Object, e As EventArgs) Handles f7.Click

    End Sub

    Private Sub d7_Click(sender As Object, e As EventArgs) Handles d7.Click

    End Sub

    Private Sub e7_Click(sender As Object, e As EventArgs) Handles e7.Click

    End Sub

    Private Sub c7_Click(sender As Object, e As EventArgs) Handles c7.Click

    End Sub

    Private Sub b7_Click(sender As Object, e As EventArgs) Handles b7.Click

    End Sub

    Private Sub a7_Click(sender As Object, e As EventArgs) Handles a7.Click

    End Sub

    Private Sub i8_Click(sender As Object, e As EventArgs) Handles i8.Click

    End Sub

    Private Sub h8_Click(sender As Object, e As EventArgs) Handles h8.Click

    End Sub

    Private Sub g8_Click(sender As Object, e As EventArgs) Handles g8.Click

    End Sub

    Private Sub f8_Click(sender As Object, e As EventArgs) Handles f8.Click

    End Sub

    Private Sub d8_Click(sender As Object, e As EventArgs) Handles d8.Click

    End Sub

    Private Sub e8_Click(sender As Object, e As EventArgs) Handles e8.Click

    End Sub

    Private Sub c8_Click(sender As Object, e As EventArgs) Handles c8.Click

    End Sub

    Private Sub b8_Click(sender As Object, e As EventArgs) Handles b8.Click

    End Sub

    Private Sub a8_Click(sender As Object, e As EventArgs) Handles a8.Click

    End Sub

    Private Sub settings_Click(sender As Object, e As EventArgs) Handles settings.Click

    End Sub

    Private Sub message_Click(sender As Object, e As EventArgs) Handles message.Click

    End Sub

    Private Sub pause_Click(sender As Object, e As EventArgs) Handles pause.Click

    End Sub

    Private Sub BackgroundWorker1_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles BackgroundWorker1.DoWork

    End Sub
End Class