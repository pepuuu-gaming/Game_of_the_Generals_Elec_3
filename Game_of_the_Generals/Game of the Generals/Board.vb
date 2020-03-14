Imports FireSharp.Config
Imports FireSharp.Response
Imports FireSharp.Interfaces
Imports System.IO

Public Class gameboard

    Dim roomName As String
    Dim roomNamePath As String
    Dim piecePlayer1Path As String
    Dim piecePlayer2Path As String
    Dim arbitraryPath As String
    Dim movePath As String
    Dim player1Path As String
    Dim player2Path As String
    Dim 

    Private client As IFirebaseClient
    Dim isGameTime As Boolean = False
    Dim hostName As String
    Dim guestName As String
    Dim host As Boolean
    Dim hostColor As Integer() = {20, 45, 76}
    Dim guestColor As Integer() = {159, 211, 199}
    Dim firstClick As Boolean = True
    Dim x As Integer = 0
    Dim y As Integer = 0
    Dim x2 As Integer = 0
    Dim y2 As Integer = 0
    Dim swapEnabled As Boolean
    Dim piece1 As Button
    Dim piece2 As Button
    Dim pieceObject(21) As Object
    Dim pieceObjectList As New List(Of Location)
    Dim coordinateObject(27) As Object
    Dim pieceCoordinate(21) As String

    Private fcon As New FirebaseConfig With
        {
        .AuthSecret = "XMpD0khO3QHVDvlc1C3qyeWBu5OYC6Ctk2FupkIN",
        .BasePath = "https://game-of-the-generals-vb.firebaseio.com/"
        }

    'Public Sub New(Host As Boolean)

    '    ' This call is required by the designer.
    '    InitializeComponent()

    '    ' Add any initialization after the InitializeComponent() call.

    'End Sub



    Public Sub SetPiecesToDatabase()
        Dim piece As New Piece() With {
            .p1 = pieceCoordinate(0),
            .p2 = pieceCoordinate(1),
            .p3 = pieceCoordinate(2),
            .p4 = pieceCoordinate(3),
            .p5 = pieceCoordinate(4),
            .p6 = pieceCoordinate(5),
            .p7 = pieceCoordinate(6),
            .p8 = pieceCoordinate(7),
            .p9 = pieceCoordinate(8),
            .p10 = pieceCoordinate(9),
            .p11 = pieceCoordinate(10),
            .p12 = pieceCoordinate(11),
            .p13 = pieceCoordinate(12),
            .p14 = pieceCoordinate(13),
            .p15 = pieceCoordinate(14),
            .p16 = pieceCoordinate(15),
            .p17 = pieceCoordinate(16),
            .p18 = pieceCoordinate(17),
            .p19 = pieceCoordinate(18),
            .p20 = pieceCoordinate(19),
            .p21 = pieceCoordinate(20)
        }

    End Sub

    Public Sub SetPiecesAndCoordinateObject()
        pieceObject(0) = hp1
        pieceObject(1) = hp2
        pieceObject(2) = hp3
        pieceObject(3) = hp4
        pieceObject(4) = hp5
        pieceObject(5) = hp6
        pieceObject(6) = hp7
        pieceObject(7) = hp8
        pieceObject(8) = hp9
        pieceObject(9) = hp10
        pieceObject(10) = hp11
        pieceObject(11) = hp12
        pieceObject(12) = hp13
        pieceObject(13) = hp14
        pieceObject(14) = hp15
        pieceObject(15) = hp16
        pieceObject(16) = hp17
        pieceObject(17) = hp18
        pieceObject(18) = hp19
        pieceObject(19) = hp20
        pieceObject(20) = hp21

        coordinateObject(0) = a6
        coordinateObject(1) = a7
        coordinateObject(2) = a8

        coordinateObject(3) = b6
        coordinateObject(4) = b7
        coordinateObject(5) = b8

        coordinateObject(6) = c6
        coordinateObject(7) = c7
        coordinateObject(8) = c8

        coordinateObject(9) = d6
        coordinateObject(10) = d7
        coordinateObject(11) = d8

        coordinateObject(12) = e6
        coordinateObject(13) = e7
        coordinateObject(14) = e8

        coordinateObject(15) = f6
        coordinateObject(16) = f7
        coordinateObject(17) = f8

        coordinateObject(18) = g6
        coordinateObject(19) = g7
        coordinateObject(20) = g8

        coordinateObject(21) = h6
        coordinateObject(22) = h7
        coordinateObject(23) = h8

        coordinateObject(24) = i6
        coordinateObject(25) = i7
        coordinateObject(26) = i8


    End Sub

    Public Sub GetLocation()
        SetPiecesAndCoordinateObject()
        Dim loc As Location = New Location
        Dim pieceCoor(2) As Integer
        Dim coorVal(2) As Integer

        For i = 0 To 20
            For j = 0 To 26
                pieceCoor = loc.LocationGet(pieceObject(i))
                coorVal = loc.LocationGet(coordinateObject(j))

                If pieceCoor(0) = coorVal(0) And pieceCoor(1) = coorVal(1) Then
                    pieceCoordinate(i) = GetCoordinateString(j)
                End If
            Next
        Next
    End Sub

    Public Function GetCoordinateString(a As Integer) As String
        Dim b As String
        Select Case a
            Case 0
                b = "a6"
            Case 1
                b = "a7"
            Case 2
                b = "a8"
            Case 3
                b = "b6"
            Case 4
                b = "b7"
            Case 5
                b = "b8"
            Case 6
                b = "c6"
            Case 7
                b = "c7"
            Case 8
                b = "c8"
            Case 9
                b = "d6"
            Case 10
                b = "d7"
            Case 11
                b = "d8"
            Case 12
                b = "e6"
            Case 13
                b = "e7"
            Case 14
                b = "e8"
            Case 15
                b = "f6"
            Case 16
                b = "f7"
            Case 17
                b = "f8"
            Case 18
                b = "g6"
            Case 19
                b = "g7"
            Case 20
                b = "g8"
            Case 21
                b = "h6"
            Case 22
                b = "h7"
            Case 23
                b = "h8"
            Case 24
                b = "i6"
            Case 25
                b = "i7"
            Case 26
                b = "i8"
        End Select
        Return b
    End Function

    Public Sub SetPiecesHost()
        Dim piece As Piece = New Piece
        piece.Setprivate(hp1, hostColor)
        piece.Setprivate(hp2, hostColor)
        piece.Setprivate(hp3, hostColor)
        piece.Setprivate(hp4, hostColor)
        piece.Setprivate(hp5, hostColor)
        piece.Setprivate(hp6, hostColor)
        piece.Setsergeant(hp7, hostColor)

        piece.Setlieutenant_2nd(hp8, hostColor)
        piece.Setlieutenant_1st(hp9, hostColor)
        piece.Setcaptain(hp10, hostColor)
        piece.Setmajor(hp11, hostColor)
        piece.Setlieutenant_colonel(hp12, hostColor)
        piece.Setcolonel(hp13, hostColor)
        piece.Setbrigadier_general(hp14, hostColor)

        piece.Setmajor_general(hp15, hostColor)
        piece.Setlieutenant_general(hp16, hostColor)
        piece.Setgeneral(hp17, hostColor)
        piece.Setgeneral_of_the_army(hp18, hostColor)
        piece.Setspy(hp19, hostColor)
        piece.Setspy(hp20, hostColor)
        piece.Setflag(hp21, hostColor)
    End Sub

    Public Sub SetPiecesGuest()
        Dim piece As Piece = New Piece
        piece.Setprivate(ep1, guestColor)
        piece.Setprivate(ep2, guestColor)
        piece.Setprivate(ep3, guestColor)
        piece.Setprivate(ep4, guestColor)
        piece.Setprivate(ep5, guestColor)
        piece.Setprivate(ep6, guestColor)
        piece.Setsergeant(ep7, guestColor)

        piece.Setlieutenant_2nd(ep8, guestColor)
        piece.Setlieutenant_1st(ep9, guestColor)
        piece.Setcaptain(ep10, guestColor)
        piece.Setmajor(ep11, guestColor)
        piece.Setlieutenant_colonel(ep12, guestColor)
        piece.Setcolonel(ep13, guestColor)
        piece.Setbrigadier_general(ep14, guestColor)

        piece.Setmajor_general(ep15, guestColor)
        piece.Setlieutenant_general(ep16, guestColor)
        piece.Setgeneral(ep17, guestColor)
        piece.Setgeneral_of_the_army(ep18, guestColor)
        piece.Setspy(ep19, guestColor)
        piece.Setspy(ep20, guestColor)
        piece.Setflag(ep21, guestColor)
    End Sub

    Public Sub SetPieces()
        SetPiecesHost()
        SetPiecesGuest()



    End Sub

    Public Sub getClickButton(sender As Object, e As EventArgs) Handles a6.Click, a7.Click, a8.Click, b6.Click, b7.Click, b8.Click, c6.Click, c7.Click, c8.Click, d6.Click, d7.Click, d8.Click, e6.Click, e7.Click, e8.Click, f6.Click, f7.Click, f8.Click, g6.Click, g7.Click, g8.Click, h6.Click, h7.Click, h8.Click, i6.Click, i7.Click, i8.Click,
        hp1.Click, hp2.Click, hp3.Click, hp4.Click, hp5.Click, hp6.Click, hp7.Click, hp8.Click, hp9.Click, hp10.Click,
        hp11.Click, hp12.Click, hp13.Click, hp14.Click, hp15.Click, hp16.Click, hp17.Click, hp18.Click, hp19.Click, hp20.Click, hp21.Click

        If Not isGameTime Then
            If firstClick Then
                piece1 = DirectCast(sender, Button)
                If sender.Equals(hp1) Or
                    sender.Equals(hp2) Or
                    sender.Equals(hp3) Or
                    sender.Equals(hp4) Or
                    sender.Equals(hp5) Or
                    sender.Equals(hp6) Or
                    sender.Equals(hp7) Or
                    sender.Equals(hp8) Or
                    sender.Equals(hp9) Or
                    sender.Equals(hp10) Or
                    sender.Equals(hp11) Or
                    sender.Equals(hp12) Or
                    sender.Equals(hp13) Or
                    sender.Equals(hp14) Or
                    sender.Equals(hp15) Or
                    sender.Equals(hp16) Or
                    sender.Equals(hp17) Or
                    sender.Equals(hp18) Or
                    sender.Equals(hp19) Or
                    sender.Equals(hp20) Or
                    sender.Equals(hp21) Then
                    swapEnabled = True
                    x = piece1.Location.X
                    y = piece1.Location.Y
                Else
                    swapEnabled = False
                    piece1.BackColor = Color.Red
                    x = piece1.Location.X
                    y = piece1.Location.Y
                End If
                firstClick = False
            Else
                piece2 = DirectCast(sender, Button)
                If sender.Equals(hp1) Or
                    sender.Equals(hp2) Or
                    sender.Equals(hp3) Or
                    sender.Equals(hp4) Or
                    sender.Equals(hp5) Or
                    sender.Equals(hp6) Or
                    sender.Equals(hp7) Or
                    sender.Equals(hp8) Or
                    sender.Equals(hp9) Or
                    sender.Equals(hp10) Or
                    sender.Equals(hp11) Or
                    sender.Equals(hp12) Or
                    sender.Equals(hp13) Or
                    sender.Equals(hp14) Or
                    sender.Equals(hp15) Or
                    sender.Equals(hp16) Or
                    sender.Equals(hp17) Or
                    sender.Equals(hp18) Or
                    sender.Equals(hp19) Or
                    sender.Equals(hp20) Or
                    sender.Equals(hp21) Then
                    If swapEnabled Then
                        x2 = piece2.Location.X
                        y2 = piece2.Location.Y

                        SwapPiece(x, y, x2, y2)
                        ResetValue()
                    Else
                        piece2.Location = New Point(x, y)
                    End If
                Else
                    MessageBox.Show("Select piece to move")
                End If
                firstClick = True
            End If
        Else
            MessageBox.Show("GAME TIME")
            'CHECK IF ENEMY IS READY
        End If
    End Sub

    Public Sub ResetValue()
        x = 0
        y = 0
        x2 = 0
        y2 = 0
    End Sub

    Public Sub SwapPiece(a As Integer, b As Integer, a2 As Integer, b2 As Integer)
        piece1.Location = New Point(a2, b2) ' SECOND COORDINATE A2 And B2
        piece2.Location = New Point(a, b) 'FIRST COORDINATE A and B

    End Sub

    Private Sub back_to_menu_Click(sender As Object, e As EventArgs) Handles back_to_menu.Click
        homepage.Show()
        Me.Close()
    End Sub

    Public Sub SetPiece()

    End Sub

    Private Sub ready_Click(sender As Object, e As EventArgs) Handles ready.Click
        GetLocation()
        isGameTime = True


        'For index = 0 To pieceCoordinate.Length - 1
        '    MessageBox.Show(pieceCoordinate(index))
        'Next
    End Sub

    Private Sub gameboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            client = New FireSharp.FirebaseClient(fcon)
        Catch
            MessageBox.Show("there was a problem in the internet connection")
        End Try


        'Dim name As String
        Dim file_name2 = "Roomname.txt"
        Using file_read As StreamReader = New StreamReader(file_name2)
            roomName = file_read.ReadLine
        End Using

        roomNamePath = "rooms/" + roomName
        piecePlayer1Path = roomNamePath + "/player1" + "/piece"
        piecePlayer2Path = roomNamePath + "/player2" + "/piece"
        arbitraryPath = roomNamePath + "/arbitrary"
        movePath = roomNamePath + "/move"
        player1Path = roomNamePath + "/player1"
        player2Path = roomNamePath + "/player2"



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

        a.Round(hp1, 10)
        a.Round(hp2, 10)
        a.Round(hp3, 10)
        a.Round(hp4, 10)
        a.Round(hp5, 10)
        a.Round(hp6, 10)
        a.Round(hp7, 10)
        a.Round(hp8, 10)
        a.Round(hp9, 10)
        a.Round(hp10, 10)
        a.Round(hp11, 10)
        a.Round(hp12, 10)
        a.Round(hp13, 10)
        a.Round(hp14, 10)
        a.Round(hp15, 10)
        a.Round(hp16, 10)
        a.Round(hp17, 10)
        a.Round(hp18, 10)
        a.Round(hp19, 10)
        a.Round(hp20, 10)
        a.Round(hp21, 10)

        a.Round(ep1, 10)
        a.Round(ep2, 10)
        a.Round(ep3, 10)
        a.Round(ep4, 10)
        a.Round(ep5, 10)
        a.Round(ep6, 10)
        a.Round(ep7, 10)
        a.Round(ep8, 10)
        a.Round(ep9, 10)
        a.Round(ep10, 10)
        a.Round(ep11, 10)
        a.Round(ep12, 10)
        a.Round(ep13, 10)
        a.Round(ep14, 10)
        a.Round(ep15, 10)
        a.Round(ep16, 10)
        a.Round(ep17, 10)
        a.Round(ep18, 10)
        a.Round(ep19, 10)
        a.Round(ep20, 10)
        a.Round(ep21, 10)


        SetPieces()
    End Sub


End Class