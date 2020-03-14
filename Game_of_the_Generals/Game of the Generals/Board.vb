Imports FireSharp.Config
Imports FireSharp.Response
Imports FireSharp.Interfaces
Imports System.IO

Public Class gameboard

    Dim isHost As Boolean = True
    Dim hostName As String
    Dim guestName As String
    Dim host As Boolean
    Dim hR As Integer = 20
    Dim hG As Integer = 45
    Dim hB As Integer = 76

    Dim gR As Integer = 159
    Dim gG As Integer = 211
    Dim gB As Integer = 199

    Private firebaseConnection As New FirebaseConfig With
        {
        .AuthSecret = "XMpD0khO3QHVDvlc1C3qyeWBu5OYC6Ctk2FupkIN",
        .BasePath = "https://game-of-the-generals-vb.firebaseio.com/"
        }


    Public Sub SetPieces()
        Dim piece As Piece = New Piece

        If isHost Then
            piece.Setprivate(b6, hR, hG, hB)
            piece.Setprivate(c6, hR, hG, hB)
            piece.Setprivate(d6, hR, hG, hB)
            piece.Setprivate(e6, hR, hG, hB)
            piece.Setprivate(f6, hR, hG, hB)
            piece.Setprivate(g6, hR, hG, hB)
            piece.Setsergeant(h6, hR, hG, hB)

            piece.Setlieutenant_2nd(b7, hR, hG, hB)
            piece.Setlieutenant_1st(c7, hR, hG, hB)
            piece.Setcaptain(d7, hR, hG, hB)
            piece.Setmajor(e7, hR, hG, hB)
            piece.Setlieutenant_colonel(f7, hR, hG, hB)
            piece.Setcolonel(g7, hR, hG, hB)
            piece.Setbrigadier_general(h7, hR, hG, hB)

            piece.Setmajor_general(b8, hR, hG, hB)
            piece.Setlieutenant_general(c8, hR, hG, hB)
            piece.Setgeneral(d8, hR, hG, hB)
            piece.Setgeneral_of_the_army(e8, hR, hG, hB)
            piece.Setspy(f8, hR, hG, hB)
            piece.Setspy(g8, hR, hG, hB)
            piece.Setflag(h8, hR, hG, hB)

        Else

            piece.Setprivate(b3, gR, gG, gB)
            piece.Setprivate(c3, gR, gG, gB)
            piece.Setprivate(d3, gR, gG, gB)
            piece.Setprivate(e3, gR, gG, gB)
            piece.Setprivate(f3, gR, gG, gB)
            piece.Setprivate(g3, gR, gG, gB)
            piece.Setsergeant(h3, gR, gG, gB)

            piece.Setlieutenant_2nd(b2, gR, gG, gB)
            piece.Setlieutenant_1st(c2, gR, gG, gB)
            piece.Setcaptain(d2, gR, gG, gB)
            piece.Setmajor(e2, gR, gG, gB)
            piece.Setlieutenant_colonel(f2, gR, gG, gB)
            piece.Setcolonel(g2, gR, gG, gB)
            piece.Setbrigadier_general(h2, gR, gG, gB)

            piece.Setmajor_general(b1, gR, gG, gB)
            piece.Setlieutenant_general(c1, gR, gG, gB)
            piece.Setgeneral(d1, gR, gG, gB)
            piece.Setgeneral_of_the_army(e1, gR, gG, gB)
            piece.Setspy(f1, gR, gG, gB)
            piece.Setspy(g1, gR, gG, gB)
            piece.Setflag(h1, gR, gG, gB)

        End If

    End Sub

    Public Sub getClickButtonH(sender As Object, e As EventArgs) Handles a6.Click, a7.Click, a8.Click, b6.Click, b7.Click, b8.Click, c6.Click, c7.Click, c8.Click, d6.Click, d7.Click, d8.Click, e6.Click, e7.Click, e8.Click, f6.Click, f7.Click, f8.Click, g6.Click, g7.Click, g8.Click, h6.Click, h7.Click, h8.Click, i6.Click, i7.Click, i8.Click
        If isHost Then
            Dim test As Button
            test = DirectCast(sender, Button)
            test.BackColor = Color.Red
        Else
            MessageBox.Show("You,re coordinate is from A1 to I3")
        End If
    End Sub

    Public Sub getClickButtonNH(sender As Object, e As EventArgs) Handles a1.Click, a2.Click, a3.Click, b1.Click, b2.Click, b3.Click, c1.Click, c2.Click, c3.Click, d1.Click, d2.Click, d3.Click, e1.Click, e2.Click, e3.Click, f1.Click, f2.Click, f3.Click, g1.Click, g2.Click, g3.Click, h1.Click, h2.Click, h3.Click, i1.Click, i2.Click, i3.Click
        If Not isHost Then
            Dim test As Button
            test = DirectCast(sender, Button)
            test.BackColor = Color.Red
        Else
            MessageBox.Show("You,re coordinate is from A6 to I8")
        End If
    End Sub

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

        SetPieces()
    End Sub
End Class