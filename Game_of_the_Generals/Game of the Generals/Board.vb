Imports FireSharp.Config
Imports FireSharp.Response
Imports FireSharp.Interfaces
Imports System.IO
Imports FireSharp.EventStreaming
Imports System.ComponentModel

Public Class Gameboard

    Dim name As String
    Dim roomName As String
    Dim roomNamePath As String
    Dim Player1PiecePath As String
    Dim Player2PiecePath As String
    Dim ArbitraryPath As String
    Dim MovePath As String
    Dim Player1Path As String
    Dim Player2Path As String

    Private client As IFirebaseClient
    Dim isGameTime As Boolean = False
    Dim isGameTimeDB As Boolean = False
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
    Dim piece1 As Button
    Dim piece2 As Button
    Dim pieceObject(21) As Object
    Dim enemyObject(21) As Object
    Dim coordinateObject(27) As Object
    Dim enemyCoordinateObject(27) As Object
    Dim pieceCoordinate(21) As String
    Dim enemyPieceCoordinate(21) As String

    Private fcon As New FirebaseConfig With
        {
        .AuthSecret = "XMpD0khO3QHVDvlc1C3qyeWBu5OYC6Ctk2FupkIN",
        .BasePath = "https://game-of-the-generals-vb.firebaseio.com/"
        }

    Public Function GetCoordinateInvertedString(a As Integer) As String
        Dim b As String
        Select Case a
            Case 0
                b = "i3"
            Case 1
                b = "i2"
            Case 2
                b = "i1"
            Case 3
                b = "h3"
            Case 4
                b = "h2"
            Case 5
                b = "h1"
            Case 6
                b = "g3"
            Case 7
                b = "g2"
            Case 8
                b = "g1"
            Case 9
                b = "f3"
            Case 10
                b = "f2"
            Case 11
                b = "f1"
            Case 12
                b = "e3"
            Case 13
                b = "e2"
            Case 14
                b = "e1"
            Case 15
                b = "d3"
            Case 16
                b = "d2"
            Case 17
                b = "d1"
            Case 18
                b = "c3"
            Case 19
                b = "c2"
            Case 20
                b = "c1"
            Case 21
                b = "b3"
            Case 22
                b = "b2"
            Case 23
                b = "b1"
            Case 24
                b = "a3"
            Case 25
                b = "a2"
            Case 26
                b = "a1"
        End Select
        Return b
    End Function

    Public Sub GetAndSetEnemyLocation()
        SetPiecesAndCoordinateObject()
        GetEnemyPieceFromDatabase()

        Dim loc As Location = New Location
        Dim pieceCoor(2) As Integer
        'Dim coorVal(2) As Integer

        'If enemyPieceCoordinate(0) = GetCoordinateString(0) Then
        '    enemyObject(0) = GetCoordinateInvertedString(0)
        'End If


        'For i = 0 To 20
        '    For j = 0 To 26
        '        pieceCoor = loc.LocationGet(pieceObject(i))
        '        coorVal = loc.LocationGet(coordinateObject(j))

        '        If pieceCoor(0) = coorVal(0) And pieceCoor(1) = coorVal(1) Then
        '            pieceCoordinate(i) = GetCoordinateString(j)
        '        End If
        '    Next
        'Next

        For i = 0 To 20
            For j = 0 To 26
                If enemyPieceCoordinate(i) = GetCoordinateString(j) Then
                    pieceCoor = loc.LocationGet(enemyCoordinateObject(j))
                    loc.SetLocation(enemyObject(i), pieceCoor(0), pieceCoor(1))
                End If
            Next
        Next
    End Sub

    'Public Sub SetEnemyPieceToBoard()
    '    GetEnemyLocation()
    '    ep1.Location = New Point(b6.Location.X, b6.Location.Y)
    '    ep2.Location = New Point(c6.Location.X, c6.Location.Y)
    '    ep3.Location = New Point(d6.Location.X, d6.Location.Y)
    '    ep4.Location = New Point(e6.Location.X, e6.Location.Y)
    '    ep5.Location = New Point(f6.Location.X, f6.Location.Y)
    '    ep6.Location = New Point(g6.Location.X, g6.Location.Y)
    '    ep7.Location = New Point(h6.Location.X, h6.Location.Y)
    '    ep8.Location = New Point(b7.Location.X, b7.Location.Y)
    '    ep9.Location = New Point(c7.Location.X, c7.Location.Y)
    '    ep10.Location = New Point(d7.Location.X, d7.Location.Y)

    '    ep11.Location = New Point(e7.Location.X, e7.Location.Y)
    '    ep12.Location = New Point(f7.Location.X, f7.Location.Y)
    '    ep13.Location = New Point(g7.Location.X, g7.Location.Y)
    '    ep14.Location = New Point(h7.Location.X, h7.Location.Y)
    '    ep15.Location = New Point(b8.Location.X, b8.Location.Y)
    '    ep16.Location = New Point(c8.Location.X, c8.Location.Y)
    '    ep17.Location = New Point(d8.Location.X, d8.Location.Y)
    '    ep18.Location = New Point(e8.Location.X, e8.Location.Y)
    '    ep19.Location = New Point(f8.Location.X, f8.Location.Y)
    '    ep20.Location = New Point(g8.Location.X, g8.Location.Y)

    '    ep21.Location = New Point(h8.Location.X, h8.Location.Y)
    'End Sub


    Public Sub GetEnemyPieceFromDatabase()
        Dim piece As New Piece()
        Dim res As FirebaseResponse
        If host Then
            res = client.Get(Player2PiecePath)
        Else
            res = client.Get(Player1PiecePath)
        End If
        piece = res.ResultAs(Of Piece)
        enemyPieceCoordinate(0) = piece.p01
        enemyPieceCoordinate(1) = piece.p02
        enemyPieceCoordinate(2) = piece.p03
        enemyPieceCoordinate(3) = piece.p04
        enemyPieceCoordinate(4) = piece.p05
        enemyPieceCoordinate(5) = piece.p06
        enemyPieceCoordinate(6) = piece.p07
        enemyPieceCoordinate(7) = piece.p08
        enemyPieceCoordinate(8) = piece.p09
        enemyPieceCoordinate(9) = piece.p10

        enemyPieceCoordinate(10) = piece.p11
        enemyPieceCoordinate(11) = piece.p12
        enemyPieceCoordinate(12) = piece.p13
        enemyPieceCoordinate(13) = piece.p14
        enemyPieceCoordinate(14) = piece.p15
        enemyPieceCoordinate(15) = piece.p16
        enemyPieceCoordinate(16) = piece.p17
        enemyPieceCoordinate(17) = piece.p18
        enemyPieceCoordinate(18) = piece.p19
        enemyPieceCoordinate(19) = piece.p20

        enemyPieceCoordinate(20) = piece.p21

    End Sub

    Public Sub SetPiecesToDatabase()
        Dim piece As New Piece() With {
            .p01 = pieceCoordinate(0),
            .p02 = pieceCoordinate(1),
            .p03 = pieceCoordinate(2),
            .p04 = pieceCoordinate(3),
            .p05 = pieceCoordinate(4),
            .p06 = pieceCoordinate(5),
            .p07 = pieceCoordinate(6),
            .p08 = pieceCoordinate(7),
            .p09 = pieceCoordinate(8),
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
        If host Then
            client.Update(Player1PiecePath, piece)
        Else
            client.Update(Player2PiecePath, piece)
        End If
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


        enemyObject(0) = ep1
        enemyObject(1) = ep2
        enemyObject(2) = ep3
        enemyObject(3) = ep4
        enemyObject(4) = ep5
        enemyObject(5) = ep6
        enemyObject(6) = ep7
        enemyObject(7) = ep8
        enemyObject(8) = ep9
        enemyObject(9) = ep10
        enemyObject(10) = ep11
        enemyObject(11) = ep12
        enemyObject(12) = ep13
        enemyObject(13) = ep14
        enemyObject(14) = ep15
        enemyObject(15) = ep16
        enemyObject(16) = ep17
        enemyObject(17) = ep18
        enemyObject(18) = ep19
        enemyObject(19) = ep20
        enemyObject(20) = ep21


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


        enemyCoordinateObject(0) = i3
        enemyCoordinateObject(1) = i2
        enemyCoordinateObject(2) = i1

        enemyCoordinateObject(3) = h3
        enemyCoordinateObject(4) = h2
        enemyCoordinateObject(5) = h1

        enemyCoordinateObject(6) = g3
        enemyCoordinateObject(7) = g2
        enemyCoordinateObject(8) = g1

        enemyCoordinateObject(9) = f3
        enemyCoordinateObject(10) = f2
        enemyCoordinateObject(11) = f1

        enemyCoordinateObject(12) = e3
        enemyCoordinateObject(13) = e2
        enemyCoordinateObject(14) = e1

        enemyCoordinateObject(15) = d3
        enemyCoordinateObject(16) = d2
        enemyCoordinateObject(17) = d1

        enemyCoordinateObject(18) = c3
        enemyCoordinateObject(19) = c2
        enemyCoordinateObject(20) = c1

        enemyCoordinateObject(21) = b3
        enemyCoordinateObject(22) = b2
        enemyCoordinateObject(23) = b1

        enemyCoordinateObject(24) = a3
        enemyCoordinateObject(25) = a2
        enemyCoordinateObject(26) = a1


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

    Public Sub SetYourPieces(colorSet As Integer())
        Dim piece As Piece = New Piece
        piece.Setprivate(hp1, colorSet)
        piece.Setprivate(hp2, colorSet)
        piece.Setprivate(hp3, colorSet)
        piece.Setprivate(hp4, colorSet)
        piece.Setprivate(hp5, colorSet)
        piece.Setprivate(hp6, colorSet)
        piece.Setsergeant(hp7, colorSet)

        piece.Setlieutenant_2nd(hp8, colorSet)
        piece.Setlieutenant_1st(hp9, colorSet)
        piece.Setcaptain(hp10, colorSet)
        piece.Setmajor(hp11, colorSet)
        piece.Setlieutenant_colonel(hp12, colorSet)
        piece.Setcolonel(hp13, colorSet)
        piece.Setbrigadier_general(hp14, colorSet)

        piece.Setmajor_general(hp15, colorSet)
        piece.Setlieutenant_general(hp16, colorSet)
        piece.Setgeneral(hp17, colorSet)
        piece.Setgeneral_of_the_army(hp18, colorSet)
        piece.Setspy(hp19, colorSet)
        piece.Setspy(hp20, colorSet)
        piece.Setflag(hp21, colorSet)
    End Sub

    Public Sub SetPieces()
        If host Then
            SetYourPieces(hostColor)
        Else
            SetYourPieces(guestColor)
        End If
    End Sub

    Public Sub SetPieceToBoard()
        hp1.Location = New Point(b6.Location.X, b6.Location.Y)
        hp2.Location = New Point(c6.Location.X, c6.Location.Y)
        hp3.Location = New Point(d6.Location.X, d6.Location.Y)
        hp4.Location = New Point(e6.Location.X, e6.Location.Y)
        hp5.Location = New Point(f6.Location.X, f6.Location.Y)
        hp6.Location = New Point(g6.Location.X, g6.Location.Y)
        hp7.Location = New Point(h6.Location.X, h6.Location.Y)
        hp8.Location = New Point(b7.Location.X, b7.Location.Y)
        hp9.Location = New Point(c7.Location.X, c7.Location.Y)
        hp10.Location = New Point(d7.Location.X, d7.Location.Y)

        hp11.Location = New Point(e7.Location.X, e7.Location.Y)
        hp12.Location = New Point(f7.Location.X, f7.Location.Y)
        hp13.Location = New Point(g7.Location.X, g7.Location.Y)
        hp14.Location = New Point(h7.Location.X, h7.Location.Y)
        hp15.Location = New Point(b8.Location.X, b8.Location.Y)
        hp16.Location = New Point(c8.Location.X, c8.Location.Y)
        hp17.Location = New Point(d8.Location.X, d8.Location.Y)
        hp18.Location = New Point(e8.Location.X, e8.Location.Y)
        hp19.Location = New Point(f8.Location.X, f8.Location.Y)
        hp20.Location = New Point(g8.Location.X, g8.Location.Y)

        hp21.Location = New Point(h8.Location.X, h8.Location.Y)

    End Sub

    Public Function Check() As Boolean
        If guestName <> "Waiting for opponent" Then
            Return True
        Else
            Return False
        End If
    End Function

    Public Sub GetClickButton(sender As Object, e As EventArgs) Handles a6.Click, a7.Click, a8.Click, b6.Click, b7.Click, b8.Click, c6.Click, c7.Click, c8.Click, d6.Click, d7.Click, d8.Click, e6.Click, e7.Click, e8.Click, f6.Click, f7.Click, f8.Click, g6.Click, g7.Click, g8.Click, h6.Click, h7.Click, h8.Click, i6.Click, i7.Click, i8.Click,
        hp1.Click, hp2.Click, hp3.Click, hp4.Click, hp5.Click, hp6.Click, hp7.Click, hp8.Click, hp9.Click, hp10.Click,
        hp11.Click, hp12.Click, hp13.Click, hp14.Click, hp15.Click, hp16.Click, hp17.Click, hp18.Click, hp19.Click, hp20.Click, hp21.Click


        'LISTEN IF SOMEONE JOIN THE ROOM
        If Not Check() Then
            GetName()
            SetName()
        End If

        'CHECK IF ENEMY IS READY
        'IF ENEMY IS READY PIECE WILL SHOW TO YOU
        If host Then
            If GetPlayer2ReadyStatus() Then
                GetAndSetEnemyLocation()
                ShowPiece(host)
            End If
        Else
            If GetPlayer1ReadyStatus() Then
                GetAndSetEnemyLocation()
                ShowPiece(host)
            End If
        End If

        'LISTEN MOVES

        If isGameTime And isGameTimeDB Then
            MessageBox.Show("GAME TIME")
            'METHOD GAME TIME
            ready.Visible = False
            If host Then
                If PlayerTurn() Then
                    myName.BackColor = Color.Green
                    enemyName.BackColor = Color.Red
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
                            firstClick = False
                        Else
                            MessageBox.Show("Please select a piece")
                        End If
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
                            MessageBox.Show("You can't swap now. Please select on the coordinate")
                        Else
                            x2 = piece2.Location.X
                            y2 = piece2.Location.Y
                            piece1.Location = New Point(x2, y2)
                            firstClick = True
                            'METHOD TO SEND TO DATABASE

                        End If
                    End If
                Else
                    MessageBox.Show("Opponent's Turn")
                    enemyName.BackColor = Color.Green
                    myName.BackColor = Color.Red
                End If
            Else
                If PlayerTurn() Then
                    MessageBox.Show("Opponent's Turn")
                    enemyName.BackColor = Color.Green
                    myName.BackColor = Color.Red
                Else
                    myName.BackColor = Color.Green
                    enemyName.BackColor = Color.Red
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
                            firstClick = False
                        Else
                            MessageBox.Show("Please select a piece")
                        End If
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
                            MessageBox.Show("You can't swap now. Please select on the coordinate")
                        Else
                            x2 = piece2.Location.X
                            y2 = piece2.Location.Y
                            piece1.Location = New Point(x2, y2)
                            firstClick = True
                            'METHOD TO SEND TO DATABASE

                        End If
                    End If
                End If
            End If
        Else
            'STRATEGY TIME
            If GetPlayer1ReadyStatus() And GetPlayer2ReadyStatus() Then
                isGameTimeDB = True
            Else
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
                        'swapEnabled = True
                        x = piece1.Location.X
                        y = piece1.Location.Y
                        firstClick = False
                    Else
                        MessageBox.Show("Please select a piece")
                        '    swapEnabled = False
                        '    x = piece1.Location.X
                        '    y = piece1.Location.Y
                    End If
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
                        x2 = piece2.Location.X
                        y2 = piece2.Location.Y

                        SwapPiece(x, y, x2, y2)
                        ResetValue()
                    ElseIf sender.Equals(a6) Or
                            sender.Equals(a7) Or
                            sender.Equals(a8) Or
                            sender.Equals(b6) Or
                            sender.Equals(b7) Or
                            sender.Equals(b8) Or
                            sender.Equals(c6) Or
                            sender.Equals(c7) Or
                            sender.Equals(c8) Or
                            sender.Equals(d6) Or
                            sender.Equals(d7) Or
                            sender.Equals(d8) Or
                            sender.Equals(e6) Or
                            sender.Equals(e7) Or
                            sender.Equals(e8) Or
                            sender.Equals(f6) Or
                            sender.Equals(f7) Or
                            sender.Equals(f8) Or
                            sender.Equals(g6) Or
                            sender.Equals(g7) Or
                            sender.Equals(g8) Or
                            sender.Equals(h6) Or
                            sender.Equals(h7) Or
                            sender.Equals(h8) Or
                            sender.Equals(i6) Or
                            sender.Equals(i7) Or
                            sender.Equals(i8) Then
                        x2 = piece2.Location.X
                        y2 = piece2.Location.Y
                        piece1.Location = New Point(x2, y2)
                        ResetValue()
                    Else
                        MessageBox.Show("You can only move and swap piece from A6 to I8")
                    End If
                    firstClick = True
                End If
            End If
        End If
    End Sub

    Public Function PlayerTurn() As Boolean
        Dim b As Boolean
        Dim res = client.Get(roomNamePath + "/isReady")
        b = res.ResultAs(Of Boolean)

        Return b
    End Function



    Public Sub ResetValue()
        x = 0
        y = 0
        x2 = 0
        y2 = 0
    End Sub

    Public Function GetPlayer2ReadyStatus() As Boolean
        Dim a As Boolean
        Dim res = client.Get(Player2Path + "/isReady")
        a = res.ResultAs(Of Boolean)

        Return a
    End Function

    Public Function GetPlayer1ReadyStatus() As Boolean
        Dim b As Boolean
        Dim res2 = client.Get(Player1Path + "/isReady")
        b = res2.ResultAs(Of Boolean)
        Return b
    End Function


    Public Sub SwapPiece(a As Integer, b As Integer, a2 As Integer, b2 As Integer)
        piece1.Location = New Point(a2, b2) ' SECOND COORDINATE A2 And B2
        piece2.Location = New Point(a, b) 'FIRST COORDINATE A and B

    End Sub

    Private Sub back_to_menu_Click(sender As Object, e As EventArgs) Handles back_to_menu.Click
        homepage.Show()
        Me.Close()
    End Sub

    Public Sub ShowHideEnemyPiece(b As Boolean)
        ep1.Visible = b
        ep2.Visible = b
        ep3.Visible = b
        ep4.Visible = b
        ep5.Visible = b
        ep6.Visible = b
        ep7.Visible = b
        ep8.Visible = b
        ep9.Visible = b
        ep10.Visible = b

        ep11.Visible = b
        ep12.Visible = b
        ep13.Visible = b
        ep14.Visible = b
        ep15.Visible = b
        ep16.Visible = b
        ep17.Visible = b
        ep18.Visible = b
        ep19.Visible = b
        ep20.Visible = b

        ep21.Visible = b
    End Sub

    Public Sub SetEnemyPiece(b As Integer())
        Dim piece As Piece = New Piece
        piece.Setenemy(ep1, b)
        piece.Setenemy(ep2, b)
        piece.Setenemy(ep3, b)
        piece.Setenemy(ep4, b)
        piece.Setenemy(ep5, b)
        piece.Setenemy(ep6, b)
        piece.Setenemy(ep7, b)
        piece.Setenemy(ep8, b)
        piece.Setenemy(ep9, b)
        piece.Setenemy(ep10, b)

        piece.Setenemy(ep11, b)
        piece.Setenemy(ep12, b)
        piece.Setenemy(ep13, b)
        piece.Setenemy(ep14, b)
        piece.Setenemy(ep15, b)
        piece.Setenemy(ep16, b)
        piece.Setenemy(ep17, b)
        piece.Setenemy(ep18, b)
        piece.Setenemy(ep19, b)
        piece.Setenemy(ep20, b)

        piece.Setenemy(ep21, b)
    End Sub

    Public Sub ShowPiece(b As Boolean)
        If b Then
            SetEnemyPiece(guestColor)
            ShowHideEnemyPiece(True)
        Else
            SetEnemyPiece(hostColor)
            ShowHideEnemyPiece(True)
        End If
    End Sub

    Public Sub SetReadyToDatabase()
        Dim res As FirebaseResponse
        If host Then
            res = client.Set(Player1Path + "/isReady", True)
        Else
            res = client.Set(Player2Path + "/isReady", True)
        End If
    End Sub

    Private Sub Ready_Click(sender As Object, e As EventArgs) Handles ready.Click
        GetLocation()
        isGameTime = True
        SetReadyToDatabase()
        SetPiecesToDatabase()
        MessageBox.Show("All Set!")
        ready.Enabled = False
    End Sub


    Public Sub GetName()
        hostName = roomName
        If host Then
            Dim res2 = client.Get(Player2Path + "/name")
            guestName = res2.ResultAs(Of String)
        Else
            guestName = name
        End If
    End Sub

    Public Sub SetName()
        If host Then
            enemyName.Text = guestName
            myName.Text = hostName
        Else
            enemyName.Text = hostName
            myName.Text = guestName
        End If
    End Sub

    Public Sub GetRole()
        Dim file_name = "name.txt"
        Using file_read As StreamReader = New StreamReader(file_name)
            name = file_read.ReadLine
        End Using
        If name = roomName Then
            host = True
        Else
            host = False
        End If
    End Sub

    Private Sub Gameboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            client = New FireSharp.FirebaseClient(fcon)
        Catch
            MessageBox.Show("there was a problem in the internet connection")
        End Try

        Dim file_name2 = "Roomname.txt"
        Using file_read As StreamReader = New StreamReader(file_name2)
            roomName = file_read.ReadLine
        End Using

        roomNamePath = "room/" + roomName
        Player1PiecePath = roomNamePath + "/player1" + "/piece"
        Player2PiecePath = roomNamePath + "/player2" + "/piece"
        ArbitraryPath = roomNamePath + "/arbitrary"
        MovePath = roomNamePath + "/move"
        Player1Path = roomNamePath + "/player1"
        Player2Path = roomNamePath + "/player2"

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

        GetRole()
        GetName()
        SetName()
        ShowHideEnemyPiece(False)
        SetPieceToBoard()
        SetPieces()
    End Sub

    Private Sub Gameboard_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        Select Case MessageBox.Show("Would you like to exit",
                                    "CAREFUL", MessageBoxButtons.YesNo,
                                        MessageBoxIcon.Question)
            Case DialogResult.Yes
                If host Then
                    Dim res = client.Delete(roomNamePath)
                End If
                End
            Case DialogResult.No
                e.Cancel = True
        End Select
    End Sub
End Class