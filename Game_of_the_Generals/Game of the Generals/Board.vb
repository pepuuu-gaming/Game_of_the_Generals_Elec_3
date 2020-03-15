Imports FireSharp.Config
Imports FireSharp.Response
Imports FireSharp.Interfaces
Imports System.IO
Imports FireSharp.EventStreaming
Imports System.ComponentModel

Public Class Gameboard

    Dim playerName As String
    Dim roomName As String
    Dim roomNamePath As String
    Dim Player1PiecePath As String
    Dim Player2PiecePath As String
    'Dim ArbitraryPath As String
    Dim Player1AlivePath As String
    Dim Player2AlivePath As String
    Dim Player2MovePath As String
    Dim Player1Path As String
    Dim Player2Path As String
    Dim Player1MovePath As String

    Private client As IFirebaseClient
    Dim isGameTime As Boolean = False
    Dim isGameTimeDB As Boolean = False
    Dim hostName As String
    Dim guestName As String
    Dim host As Boolean
    Dim hostPossibleColor As Integer() = {125, 136, 159}
    Dim guestPossibleColor As Integer() = {199, 230, 223}
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
    Dim gridCoordinateObject(71) As Object
    Dim enemyGridCoordinateObject(71) As Object
    Dim firstPieceLocation As Integer()
    Dim firstClickPiece As Integer
    Dim clickedCoordinateValue As String
    Dim enemyClickedPiece As Integer
    Dim enemyClickedCoordinateValue As String
    Dim enemyClickedPieceObject As Object
    Dim counter As Integer = 0
    Dim yourGraveyard(2) As Integer
    Dim enemyGraveyard(2) As Integer
    Dim locationX As Integer() = {40, 88, 136, 184, 232, 280, 328}
    Dim locationY As Integer() = {154, 197, 240, 326, 369, 412}
    Dim winner As String = ""
    Dim winFromArbitrary As Boolean

    Private fcon As New FirebaseConfig With
        {
        .AuthSecret = "XMpD0khO3QHVDvlc1C3qyeWBu5OYC6Ctk2FupkIN",
        .BasePath = "https://game-of-the-generals-vb.firebaseio.com/"
        }

    'Public Function GetCoordinateInvertedString(a As Integer) As String
    '    Dim b As String
    '    Select Case a
    '        Case 0
    '            b = "i8"
    '        Case 1
    '            b = "i7"
    '        Case 2
    '            b = "i6"
    '        Case 3
    '            b = "i5"
    '        Case 4
    '            b = "i4"
    '        Case 5
    '            b = "i3"
    '        Case 6
    '            b = "i2"
    '        Case 7
    '            b = "i1"
    '        Case 8
    '            b = "h8"
    '        Case 9
    '            b = "h7"
    '        Case 10
    '            b = "f2"
    '        Case 11
    '            b = "f1"
    '        Case 12
    '            b = "e3"
    '        Case 13
    '            b = "e2"
    '        Case 14
    '            b = "e1"
    '        Case 15
    '            b = "d3"
    '        Case 16
    '            b = "d2"
    '        Case 17
    '            b = "d1"
    '        Case 18
    '            b = "c3"
    '        Case 19
    '            b = "c2"
    '        Case 20
    '            b = "c1"
    '        Case 21
    '            b = "b3"
    '        Case 22
    '            b = "b2"
    '        Case 23
    '            b = "b1"
    '        Case 24
    '            b = "a3"
    '        Case 25
    '            b = "a2"
    '        Case 26
    '            b = "a1"
    '    End Select
    '    Return b
    'End Function

    Public Sub GetAndSetEnemyLocation()
        SetPiecesAndCoordinateObject()
        GetEnemyPieceFromDatabase()

        Dim loc As Location = New Location
        Dim pieceCoor(2) As Integer

        For i = 0 To 20
            For j = 0 To 26
                If enemyPieceCoordinate(i) = GetCoordinateString(j) Then
                    pieceCoor = loc.LocationGet(enemyCoordinateObject(j))
                    loc.SetLocation(enemyObject(i), pieceCoor(0), pieceCoor(1))
                End If
            Next
        Next
    End Sub

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


        gridCoordinateObject(0) = a1
        gridCoordinateObject(1) = a2
        gridCoordinateObject(2) = a3
        gridCoordinateObject(3) = a4
        gridCoordinateObject(4) = a5
        gridCoordinateObject(5) = a6
        gridCoordinateObject(6) = a7
        gridCoordinateObject(7) = a8

        gridCoordinateObject(8) = b1
        gridCoordinateObject(9) = b2
        gridCoordinateObject(10) = b3
        gridCoordinateObject(11) = b4
        gridCoordinateObject(12) = b5
        gridCoordinateObject(13) = b6
        gridCoordinateObject(14) = b7
        gridCoordinateObject(15) = b8

        gridCoordinateObject(16) = c1
        gridCoordinateObject(17) = c2
        gridCoordinateObject(18) = c3
        gridCoordinateObject(19) = c4
        gridCoordinateObject(20) = c5
        gridCoordinateObject(21) = c6
        gridCoordinateObject(22) = c7
        gridCoordinateObject(23) = c8

        gridCoordinateObject(24) = d1
        gridCoordinateObject(25) = d2
        gridCoordinateObject(26) = d3
        gridCoordinateObject(27) = d4
        gridCoordinateObject(28) = d5
        gridCoordinateObject(29) = d6
        gridCoordinateObject(30) = d7
        gridCoordinateObject(31) = d8

        gridCoordinateObject(32) = e1
        gridCoordinateObject(33) = e2
        gridCoordinateObject(34) = e3
        gridCoordinateObject(35) = e4
        gridCoordinateObject(36) = e5
        gridCoordinateObject(37) = e6
        gridCoordinateObject(38) = e7
        gridCoordinateObject(39) = e8

        gridCoordinateObject(40) = f1
        gridCoordinateObject(41) = f2
        gridCoordinateObject(42) = f3
        gridCoordinateObject(43) = f4
        gridCoordinateObject(44) = f5
        gridCoordinateObject(45) = f6
        gridCoordinateObject(46) = f7
        gridCoordinateObject(47) = f8

        gridCoordinateObject(48) = g1
        gridCoordinateObject(49) = g2
        gridCoordinateObject(50) = g3
        gridCoordinateObject(51) = g4
        gridCoordinateObject(52) = g5
        gridCoordinateObject(53) = g6
        gridCoordinateObject(54) = g7
        gridCoordinateObject(55) = g8

        gridCoordinateObject(56) = h1
        gridCoordinateObject(57) = h2
        gridCoordinateObject(58) = h3
        gridCoordinateObject(59) = h4
        gridCoordinateObject(60) = h5
        gridCoordinateObject(61) = h6
        gridCoordinateObject(62) = h7
        gridCoordinateObject(63) = h8

        gridCoordinateObject(64) = i1
        gridCoordinateObject(65) = i2
        gridCoordinateObject(66) = i3
        gridCoordinateObject(67) = i4
        gridCoordinateObject(68) = i5
        gridCoordinateObject(69) = i6
        gridCoordinateObject(70) = i7
        gridCoordinateObject(71) = i8

        enemyGridCoordinateObject(0) = i8
        enemyGridCoordinateObject(1) = i7
        enemyGridCoordinateObject(2) = i6
        enemyGridCoordinateObject(3) = i5
        enemyGridCoordinateObject(4) = i4
        enemyGridCoordinateObject(5) = i3
        enemyGridCoordinateObject(6) = i2
        enemyGridCoordinateObject(7) = i1

        enemyGridCoordinateObject(8) = h8
        enemyGridCoordinateObject(9) = h7
        enemyGridCoordinateObject(10) = h6
        enemyGridCoordinateObject(11) = h5
        enemyGridCoordinateObject(12) = h4
        enemyGridCoordinateObject(13) = h3
        enemyGridCoordinateObject(14) = h2
        enemyGridCoordinateObject(15) = h1

        enemyGridCoordinateObject(16) = g8
        enemyGridCoordinateObject(17) = g7
        enemyGridCoordinateObject(18) = g6
        enemyGridCoordinateObject(19) = g5
        enemyGridCoordinateObject(20) = g4
        enemyGridCoordinateObject(21) = g3
        enemyGridCoordinateObject(22) = g2
        enemyGridCoordinateObject(23) = g1

        enemyGridCoordinateObject(24) = f8
        enemyGridCoordinateObject(25) = f7
        enemyGridCoordinateObject(26) = f6
        enemyGridCoordinateObject(27) = f5
        enemyGridCoordinateObject(28) = f4
        enemyGridCoordinateObject(29) = f3
        enemyGridCoordinateObject(30) = f2
        enemyGridCoordinateObject(31) = f1

        enemyGridCoordinateObject(32) = e8
        enemyGridCoordinateObject(33) = e7
        enemyGridCoordinateObject(34) = e6
        enemyGridCoordinateObject(35) = e5
        enemyGridCoordinateObject(36) = e4
        enemyGridCoordinateObject(37) = e3
        enemyGridCoordinateObject(38) = e2
        enemyGridCoordinateObject(39) = e1

        enemyGridCoordinateObject(40) = d8
        enemyGridCoordinateObject(41) = d7
        enemyGridCoordinateObject(42) = d6
        enemyGridCoordinateObject(43) = d5
        enemyGridCoordinateObject(44) = d4
        enemyGridCoordinateObject(45) = d3
        enemyGridCoordinateObject(46) = d2
        enemyGridCoordinateObject(47) = d1

        enemyGridCoordinateObject(48) = c8
        enemyGridCoordinateObject(49) = c7
        enemyGridCoordinateObject(50) = c6
        enemyGridCoordinateObject(51) = c5
        enemyGridCoordinateObject(52) = c4
        enemyGridCoordinateObject(53) = c3
        enemyGridCoordinateObject(54) = c2
        enemyGridCoordinateObject(55) = c1

        enemyGridCoordinateObject(56) = b8
        enemyGridCoordinateObject(57) = b7
        enemyGridCoordinateObject(58) = b6
        enemyGridCoordinateObject(59) = b5
        enemyGridCoordinateObject(60) = b4
        enemyGridCoordinateObject(61) = b3
        enemyGridCoordinateObject(62) = b2
        enemyGridCoordinateObject(63) = b1

        enemyGridCoordinateObject(64) = a8
        enemyGridCoordinateObject(65) = a7
        enemyGridCoordinateObject(66) = a6
        enemyGridCoordinateObject(67) = a5
        enemyGridCoordinateObject(68) = a4
        enemyGridCoordinateObject(69) = a3
        enemyGridCoordinateObject(70) = a2
        enemyGridCoordinateObject(71) = a1
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

    Public Function GetFullCoordinateString(a As Integer) As String
        Dim b As String
        Select Case a
            Case 0
                b = "a1"
            Case 1
                b = "a2"
            Case 2
                b = "a3"
            Case 3
                b = "a4"
            Case 4
                b = "a5"
            Case 5
                b = "a6"
            Case 6
                b = "a7"
            Case 7
                b = "a8"

            Case 8
                b = "b1"
            Case 9
                b = "b2"
            Case 10
                b = "b3"
            Case 11
                b = "b4"
            Case 12
                b = "b5"
            Case 13
                b = "b6"
            Case 14
                b = "b7"
            Case 15
                b = "b8"

            Case 16
                b = "c1"
            Case 17
                b = "c2"
            Case 18
                b = "c3"
            Case 19
                b = "c4"
            Case 20
                b = "c5"
            Case 21
                b = "c6"
            Case 22
                b = "c7"
            Case 23
                b = "c8"

            Case 25
                b = "d1"
            Case 25
                b = "d2"
            Case 26
                b = "d3"
            Case 27
                b = "d4"
            Case 28
                b = "d5"
            Case 29
                b = "d6"
            Case 30
                b = "d7"
            Case 31
                b = "d8"

            Case 32
                b = "e1"
            Case 33
                b = "e2"
            Case 34
                b = "e3"
            Case 35
                b = "e4"
            Case 36
                b = "e5"
            Case 37
                b = "e6"
            Case 38
                b = "e7"
            Case 39
                b = "e8"

            Case 40
                b = "f1"
            Case 41
                b = "f2"
            Case 42
                b = "f3"
            Case 43
                b = "f4"
            Case 44
                b = "f5"
            Case 45
                b = "f6"
            Case 46
                b = "f7"
            Case 47
                b = "f8"

            Case 48
                b = "g1"
            Case 49
                b = "g2"
            Case 50
                b = "g3"
            Case 51
                b = "g4"
            Case 52
                b = "g5"
            Case 53
                b = "g6"
            Case 54
                b = "g7"
            Case 55
                b = "g8"

            Case 56
                b = "h1"
            Case 57
                b = "h2"
            Case 58
                b = "h3"
            Case 59
                b = "h4"
            Case 60
                b = "h5"
            Case 61
                b = "h6"
            Case 62
                b = "h7"
            Case 63
                b = "h8"

            Case 64
                b = "i1"
            Case 65
                b = "i2"
            Case 66
                b = "i3"
            Case 67
                b = "i4"
            Case 68
                b = "i5"
            Case 69
                b = "i6"
            Case 70
                b = "i7"
            Case 71
                b = "i8"
        End Select

        Return b
    End Function

    Public Function GetLocationFirstPiece(sender As Object) As Integer()
        Dim retVal(2) As Integer

        SetPiecesAndCoordinateObject()
        Dim loc As Location = New Location
        Dim pieceCoor As Integer()
        Dim coorVal As Integer()

        pieceCoor = loc.LocationGet(sender)
        For j = 0 To 71
            coorVal = loc.LocationGet(gridCoordinateObject(j))
            If pieceCoor(0) = coorVal(0) And pieceCoor(1) = coorVal(1) Then
                retVal = coorVal
            End If
        Next
        Return retVal
    End Function

    Public Function IsItPossibleToMove(sender As Object, r As Integer()) As Boolean
        SetPiecesAndCoordinateObject()
        Dim loc As Location = New Location
        Dim pieceCoor As Integer()
        Dim coorVal As Integer()
        Dim coorVal1 As Integer()
        Dim coorVal2 As Integer()
        Dim coorVal3 As Integer()
        Dim coorVal4 As Integer()

        Dim b As Boolean

        pieceCoor = loc.LocationGet(sender)
        For i = 0 To 71
            coorVal = loc.LocationGet(gridCoordinateObject(i))
            If r(0) = coorVal(0) And r(1) = coorVal(1) Then
                If i <= 7 And i >= 0 Then
                    If i = 0 Then
                        coorVal1 = loc.LocationGet(gridCoordinateObject(i + 8))
                        coorVal2 = loc.LocationGet(gridCoordinateObject(i + 1))
                        If pieceCoor(0) = coorVal1(0) And pieceCoor(1) = coorVal1(1) Then
                            b = True
                        ElseIf pieceCoor(0) = coorVal2(1) And pieceCoor(1) = coorVal2(1) Then
                            b = True
                        Else
                            b = False
                        End If
                    ElseIf i = 7 Then
                        coorVal1 = loc.LocationGet(gridCoordinateObject(i + 8))
                        coorVal4 = loc.LocationGet(gridCoordinateObject(i - 1))
                        If pieceCoor(0) = coorVal1(0) And pieceCoor(1) = coorVal1(1) Then
                            b = True
                        ElseIf pieceCoor(0) = coorVal4(1) And pieceCoor(1) = coorVal4(1) Then
                            b = True
                        Else
                            b = False
                        End If
                    Else
                        coorVal1 = loc.LocationGet(gridCoordinateObject(i + 8))
                        coorVal2 = loc.LocationGet(gridCoordinateObject(i + 1))
                        coorVal4 = loc.LocationGet(gridCoordinateObject(i - 1))
                        If pieceCoor(0) = coorVal1(0) And pieceCoor(1) = coorVal1(1) Then
                            b = True
                        ElseIf pieceCoor(0) = coorVal2(0) And pieceCoor(1) = coorVal2(1) Then
                            b = True
                        ElseIf pieceCoor(0) = coorVal4(0) And pieceCoor(1) = coorVal4(1) Then
                            b = True
                        Else
                            b = False
                        End If

                    End If
                ElseIf i <= 71 And i >= 64 Then
                    If i = 64 Then
                        coorVal2 = loc.LocationGet(gridCoordinateObject(i + 1))
                        coorVal3 = loc.LocationGet(gridCoordinateObject(i - 8))
                        If pieceCoor(0) = coorVal2(0) And pieceCoor(1) = coorVal2(1) Then
                            b = True
                        ElseIf pieceCoor(0) = coorVal3(0) And pieceCoor(1) = coorVal3(1) Then
                            b = True
                        Else
                            b = False
                        End If
                    ElseIf i = 71 Then
                        coorVal3 = loc.LocationGet(gridCoordinateObject(i - 8))
                        coorVal4 = loc.LocationGet(gridCoordinateObject(i - 1))
                        If pieceCoor(0) = coorVal3(0) And pieceCoor(1) = coorVal3(1) Then
                            b = True
                        ElseIf pieceCoor(0) = coorVal4(0) And pieceCoor(1) = coorVal4(1) Then
                            b = True
                        Else
                            b = False
                        End If
                    Else
                        coorVal2 = loc.LocationGet(gridCoordinateObject(i + 1))
                        coorVal3 = loc.LocationGet(gridCoordinateObject(i - 8))
                        coorVal4 = loc.LocationGet(gridCoordinateObject(i - 1))
                        If pieceCoor(0) = coorVal2(0) And pieceCoor(1) = coorVal2(1) Then
                            b = True
                        ElseIf pieceCoor(0) = coorVal3(0) And pieceCoor(1) = coorVal3(1) Then
                            b = True
                        ElseIf pieceCoor(0) = coorVal4(0) And pieceCoor(1) = coorVal4(1) Then
                            b = True
                        Else
                            b = False
                        End If
                    End If

                ElseIf i = 8 Or i = 16 Or i = 24 Or i = 32 Or i = 40 Or i = 48 Or i = 56 Then
                    coorVal1 = loc.LocationGet(gridCoordinateObject(i + 8))
                    coorVal2 = loc.LocationGet(gridCoordinateObject(i + 1))
                    coorVal3 = loc.LocationGet(gridCoordinateObject(i - 8))
                    If pieceCoor(0) = coorVal1(0) And pieceCoor(1) = coorVal1(1) Then
                        b = True
                    ElseIf pieceCoor(0) = coorVal2(0) And pieceCoor(1) = coorVal2(1) Then
                        b = True
                    ElseIf pieceCoor(0) = coorVal3(0) And pieceCoor(1) = coorVal3(1) Then
                        b = True
                    Else
                        b = False
                    End If

                ElseIf i = 15 Or i = 23 Or i = 31 Or i = 39 Or i = 47 Or i = 55 Or i = 63 Then
                    coorVal1 = loc.LocationGet(gridCoordinateObject(i + 8))
                    coorVal3 = loc.LocationGet(gridCoordinateObject(i - 8))
                    coorVal4 = loc.LocationGet(gridCoordinateObject(i - 1))
                    If pieceCoor(0) = coorVal1(0) And pieceCoor(1) = coorVal1(1) Then
                        b = True
                    ElseIf pieceCoor(0) = coorVal3(0) And pieceCoor(1) = coorVal3(1) Then
                        b = True
                    ElseIf pieceCoor(0) = coorVal4(0) And pieceCoor(1) = coorVal4(1) Then
                        b = True
                    Else
                        b = False
                    End If

                Else
                    coorVal1 = loc.LocationGet(gridCoordinateObject(i + 8))
                    coorVal2 = loc.LocationGet(gridCoordinateObject(i + 1))
                    coorVal3 = loc.LocationGet(gridCoordinateObject(i - 8))
                    coorVal4 = loc.LocationGet(gridCoordinateObject(i - 1))
                    If pieceCoor(0) = coorVal1(0) And pieceCoor(1) = coorVal1(1) Then
                        b = True
                    ElseIf pieceCoor(0) = coorVal2(0) And pieceCoor(1) = coorVal2(1) Then
                        b = True
                    ElseIf pieceCoor(0) = coorVal3(0) And pieceCoor(1) = coorVal3(1) Then
                        b = True
                    ElseIf pieceCoor(0) = coorVal4(0) And pieceCoor(1) = coorVal4(1) Then
                        b = True
                    Else
                        b = False
                    End If
                End If
            End If
        Next
        Return b
    End Function

    Public Sub CheckPossibleMove(sender As Object, r As Integer())
        SetPiecesAndCoordinateObject()
        Dim piece As Piece = New Piece
        Dim loc As Location = New Location
        Dim pieceCoor(2) As Integer
        Dim coorVal(2) As Integer

        pieceCoor = loc.LocationGet(sender)
        For i = 0 To 71
            coorVal = loc.LocationGet(gridCoordinateObject(i))
            If pieceCoor(0) = coorVal(0) And pieceCoor(1) = coorVal(1) Then
                If i <= 7 And i >= 0 Then
                    If i = 0 Then
                        piece.SetPossibleMove(gridCoordinateObject(i + 8), r)
                        piece.SetPossibleMove(gridCoordinateObject(i + 1), r)
                    ElseIf i = 7 Then
                        piece.SetPossibleMove(gridCoordinateObject(i + 8), r)
                        piece.SetPossibleMove(gridCoordinateObject(i - 1), r)
                    Else
                        piece.SetPossibleMove(gridCoordinateObject(i + 8), r)
                        piece.SetPossibleMove(gridCoordinateObject(i - 1), r)
                        piece.SetPossibleMove(gridCoordinateObject(i + 1), r)
                    End If
                ElseIf i <= 71 And i >= 64 Then
                    If i = 64 Then
                        piece.SetPossibleMove(gridCoordinateObject(i + 1), r)
                        piece.SetPossibleMove(gridCoordinateObject(i - 8), r)
                    ElseIf i = 71 Then
                        piece.SetPossibleMove(gridCoordinateObject(i - 8), r)
                        piece.SetPossibleMove(gridCoordinateObject(i - 1), r)
                    Else
                        piece.SetPossibleMove(gridCoordinateObject(i - 1), r)
                        piece.SetPossibleMove(gridCoordinateObject(i + 1), r)
                        piece.SetPossibleMove(gridCoordinateObject(i - 8), r)
                    End If

                ElseIf i = 8 Or i = 16 Or i = 24 Or i = 32 Or i = 40 Or i = 48 Or i = 56 Then
                    piece.SetPossibleMove(gridCoordinateObject(i - 8), r)
                    piece.SetPossibleMove(gridCoordinateObject(i + 1), r)
                    piece.SetPossibleMove(gridCoordinateObject(i + 8), r)

                ElseIf i = 15 Or i = 23 Or i = 31 Or i = 39 Or i = 47 Or i = 55 Or i = 63 Then
                    piece.SetPossibleMove(gridCoordinateObject(i - 8), r)
                    piece.SetPossibleMove(gridCoordinateObject(i - 1), r)
                    piece.SetPossibleMove(gridCoordinateObject(i + 8), r)

                Else
                    piece.SetPossibleMove(gridCoordinateObject(i + 8), r)
                    piece.SetPossibleMove(gridCoordinateObject(i - 1), r)
                    piece.SetPossibleMove(gridCoordinateObject(i + 1), r)
                    piece.SetPossibleMove(gridCoordinateObject(i - 8), r)
                End If
            End If
        Next
    End Sub

    Public Sub SetMoveToDatabase()
        Dim move As Move = New Move With
            {
            .coordinate = clickedCoordinateValue,
            .piece = firstClickPiece
            }

        If host Then
            client.Set(Player1MovePath, move)
        Else
            client.Set(Player2MovePath, move)
        End If

    End Sub

    Public Sub SetCoordinateObject(a As Integer, b As Integer)
        SetPiecesAndCoordinateObject()
        Dim loc As Location = New Location
        Dim coorVal As Integer()

        'FIND COORDINATE AND SET IT
        'pieceCoor = loc.LocationGet(sender)
        For j = 0 To 71
            coorVal = loc.LocationGet(gridCoordinateObject(j))
            If a = coorVal(0) And b = coorVal(1) Then
                clickedCoordinateValue = GetFullCoordinateString(j)
            End If
        Next
    End Sub

    Public Sub SetFirstClickObject(sender)
        If sender.Equals(hp1) Then
            firstClickPiece = 1
        ElseIf sender.Equals(hp2) Then
            firstClickPiece = 2
        ElseIf sender.Equals(hp3) Then
            firstClickPiece = 3
        ElseIf sender.Equals(hp4) Then
            firstClickPiece = 4
        ElseIf sender.Equals(hp5) Then
            firstClickPiece = 5
        ElseIf sender.Equals(hp6) Then
            firstClickPiece = 6
        ElseIf sender.Equals(hp7) Then
            firstClickPiece = 7
        ElseIf sender.Equals(hp8) Then
            firstClickPiece = 8
        ElseIf sender.Equals(hp9) Then
            firstClickPiece = 9
        ElseIf sender.Equals(hp10) Then
            firstClickPiece = 10
        ElseIf sender.Equals(hp11) Then
            firstClickPiece = 11
        ElseIf sender.Equals(hp12) Then
            firstClickPiece = 12
        ElseIf sender.Equals(hp13) Then
            firstClickPiece = 13
        ElseIf sender.Equals(hp14) Then
            firstClickPiece = 14
        ElseIf sender.Equals(hp15) Then
            firstClickPiece = 15
        ElseIf sender.Equals(hp16) Then
            firstClickPiece = 16
        ElseIf sender.Equals(hp17) Then
            firstClickPiece = 17
        ElseIf sender.Equals(hp18) Then
            firstClickPiece = 18
        ElseIf sender.Equals(hp19) Then
            firstClickPiece = 19
        ElseIf sender.Equals(hp20) Then
            firstClickPiece = 20
        ElseIf sender.Equals(hp21) Then
            firstClickPiece = 21
        End If
    End Sub

    Public Sub SetPlayerTurn(b As Boolean)
        client.Set(roomNamePath + "/playerTurn", b)
    End Sub

    Public Function GetPlayerTurn() As Boolean
        Dim b As Boolean
        Dim res = client.Get(roomNamePath + "/playerTurn")
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

    Private Sub back_to_menu_Click(sender As Object, f As EventArgs) Handles back_to_menu.Click
        Select Case MessageBox.Show("Would you like to exit",
                                    "CAREFUL", MessageBoxButtons.YesNo,
                                        MessageBoxIcon.Question)
            Case DialogResult.Yes
                If host Then
                    Dim res = client.Delete(roomNamePath)
                End If
                homepage.Show()
                Me.Close()
            Case DialogResult.No

        End Select


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

    Public Sub GetName()
        hostName = roomName
        If host Then
            Dim res2 = client.Get(Player2Path + "/name")
            guestName = res2.ResultAs(Of String)
        Else
            guestName = playerName
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
            playerName = file_read.ReadLine
        End Using
        If playerName = roomName Then
            host = True
        Else
            host = False
        End If
    End Sub

    Public Sub ResetColors()
        Dim piece As New Piece
        Dim r As Integer() = {255, 255, 255}
        For i = 0 To 71
            piece.SetPossibleMove(gridCoordinateObject(i), r)
        Next
    End Sub

    Public Sub GetEnemyClickedPiece()
        If enemyClickedPiece = 1 Then
            enemyClickedPieceObject = ep1
        ElseIf enemyClickedPiece = 2 Then
            enemyClickedPieceObject = ep2
        ElseIf enemyClickedPiece = 3 Then
            enemyClickedPieceObject = ep3
        ElseIf enemyClickedPiece = 4 Then
            enemyClickedPieceObject = ep4
        ElseIf enemyClickedPiece = 5 Then
            enemyClickedPieceObject = ep5
        ElseIf enemyClickedPiece = 6 Then
            enemyClickedPieceObject = ep6
        ElseIf enemyClickedPiece = 7 Then
            enemyClickedPieceObject = ep7
        ElseIf enemyClickedPiece = 8 Then
            enemyClickedPieceObject = ep8
        ElseIf enemyClickedPiece = 9 Then
            enemyClickedPieceObject = ep9
        ElseIf enemyClickedPiece = 10 Then
            enemyClickedPieceObject = ep10
        ElseIf enemyClickedPiece = 11 Then
            enemyClickedPieceObject = ep11
        ElseIf enemyClickedPiece = 12 Then
            enemyClickedPieceObject = ep12
        ElseIf enemyClickedPiece = 13 Then
            enemyClickedPieceObject = ep13
        ElseIf enemyClickedPiece = 14 Then
            enemyClickedPieceObject = ep14
        ElseIf enemyClickedPiece = 15 Then
            enemyClickedPieceObject = ep15
        ElseIf enemyClickedPiece = 16 Then
            enemyClickedPieceObject = ep16
        ElseIf enemyClickedPiece = 17 Then
            enemyClickedPieceObject = ep17
        ElseIf enemyClickedPiece = 18 Then
            enemyClickedPieceObject = ep18
        ElseIf enemyClickedPiece = 19 Then
            enemyClickedPieceObject = ep19
        ElseIf enemyClickedPiece = 20 Then
            enemyClickedPieceObject = ep20
        ElseIf enemyClickedPiece = 21 Then
            enemyClickedPieceObject = ep21
        End If
    End Sub

    Public Sub GetEnemyMoveFromDatabase()
        SetPiecesAndCoordinateObject()

        Dim loc As Location = New Location
        Dim pieceCoor(2) As Integer

        Dim res As FirebaseResponse

        If host Then
            res = client.Get(Player2MovePath)
        Else
            res = client.Get(Player1MovePath)
        End If
        Dim move = res.ResultAs(Of Move)
        Dim b As Boolean = String.IsNullOrEmpty(move.coordinate)
        'MessageBox.Show("WWEEEW" & b)
        If String.IsNullOrEmpty(move.coordinate) Then
            MessageBox.Show("Opponent hasn't set his move")
        Else
            enemyClickedCoordinateValue = move.coordinate
            enemyClickedPiece = move.piece
            GetEnemyClickedPiece()
            For i = 0 To 71
                If enemyClickedCoordinateValue = GetFullCoordinateString(i) Then
                    pieceCoor = loc.LocationGet(enemyGridCoordinateObject(i))
                    loc.SetLocation(enemyClickedPieceObject, pieceCoor(0), pieceCoor(1))
                End If
            Next
        End If

    End Sub

    'Public Sub GetAndSetEnemyMove()
    '    SetPiecesAndCoordinateObject()
    '    GetEnemyMoveFromDatabase()
    '    GetEnemyClickedPiece()

    '    Dim loc As Location = New Location
    '    Dim pieceCoor(2) As Integer

    '    For i = 0 To 71
    '        If enemyClickedCoordinateValue = GetFullCoordinateString(i) Then
    '            pieceCoor = loc.LocationGet(enemyGridCoordinateObject(i))
    '            loc.SetLocation(enemyClickedPieceObject, pieceCoor(0), pieceCoor(1))
    '        End If
    '    Next

    'End Sub

    Public Sub SetCounter(a As Integer)
        'Dim a As Integer = GetCounter()
        client.Set(roomNamePath + "/counter", a + 1)
    End Sub

    Public Function GetCounter() As Integer
        Dim res = client.Get(roomNamePath + "/counter")
        Dim b As Integer = res.ResultAs(Of Integer)
        Return b
    End Function

    'Public Function GetPieceValue(sender As Object) As Integer
    '    Dim b As Integer
    '    If sender.Equals(hp1) Or sender.Equals(hp2) Or sender.Equals(hp3) Or sender.Equals(hp4) Or sender.Equals(hp5) Or sender.Equals(hp6) Or sender.Equals(ep1) Or sender.Equals(ep2) Or sender.Equals(ep3) Or sender.Equals(ep4) Or sender.Equals(ep5) Or sender.Equals(ep6) Then
    '        b = 1
    '    ElseIf sender.Equals(hp7) Or sender.Equals(hp7) Then
    '        b = 2
    '    ElseIf sender.Equals(hp8) Or sender.Equals(ep8) Then
    '        b = 3
    '    ElseIf sender.Equals(hp9) Or sender.Equals(hp8) Then
    '        b = 4
    '    ElseIf sender.Equals(hp10) Or sender.Equals(ep10) Then
    '        b = 5
    '    ElseIf sender.Equals(hp11) Or sender.Equals(ep11) Then
    '        b = 6
    '    ElseIf sender.Equals(hp12) Or sender.Equals(ep12) Then
    '        b = 7
    '    ElseIf sender.Equals(hp13) Or sender.Equals(ep13) Then
    '        b = 8
    '    ElseIf sender.Equals(hp14) Or sender.Equals(ep14) Then
    '        b = 9
    '    ElseIf sender.Equals(hp15) Or sender.Equals(ep15) Then
    '        b = 10
    '    ElseIf sender.Equals(hp16) Or sender.Equals(ep16) Then
    '        b = 11
    '    ElseIf sender.Equals(hp17) Or sender.Equals(ep17) Then
    '        b = 12
    '    ElseIf sender.Equals(hp18) Or sender.Equals(ep18) Then
    '        b = 13
    '    ElseIf sender.Equals(hp19) Or sender.Equals(hp20) Or sender.Equals(ep19) Or sender.Equals(ep20) Then
    '        b = 14
    '    ElseIf sender.Equals(hp21) Or sender.Equals(ep21) Then
    '        b = 0
    '    End If
    '    Return b
    'End Function

    Public Sub SetEnemyPieceValueArbitrary(sender As Object, b As Boolean)
        Dim a As String
        If host Then
            a = Player2AlivePath
        Else
            a = Player1AlivePath
        End If
        If sender.Equals(ep1) Then
            client.Set(a + "/p01", b)
        ElseIf sender.Equals(ep2) Then
            client.Set(a + "/p02", b)
        ElseIf sender.Equals(ep3) Then
            client.Set(a + "/p03", b)
        ElseIf sender.Equals(ep4) Then
            client.Set(a + "/p04", b)
        ElseIf sender.Equals(ep5) Then
            client.Set(a + "/p05", b)
        ElseIf sender.Equals(ep6) Then
            client.Set(a + "/p06", b)
        ElseIf sender.Equals(ep7) Then
            client.Set(a + "/p07", b)
        ElseIf sender.Equals(ep8) Then
            client.Set(a + "/p08", b)
        ElseIf sender.Equals(ep9) Then
            client.Set(a + "/p09", b)
        ElseIf sender.Equals(ep10) Then
            client.Set(a + "/p10", b)
        ElseIf sender.Equals(ep11) Then
            client.Set(a + "/p11", b)
        ElseIf sender.Equals(ep12) Then
            client.Set(a + "/p12", b)
        ElseIf sender.Equals(ep13) Then
            client.Set(a + "/p13", b)
        ElseIf sender.Equals(ep14) Then
            client.Set(a + "/p14", b)
        ElseIf sender.Equals(ep15) Then
            client.Set(a + "/p15", b)
        ElseIf sender.Equals(ep16) Then
            client.Set(a + "/p16", b)
        ElseIf sender.Equals(ep17) Then
            client.Set(a + "/p17", b)
        ElseIf sender.Equals(ep18) Then
            client.Set(a + "/p18", b)
        ElseIf sender.Equals(ep19) Then
            client.Set(a + "/p19", b)
        ElseIf sender.Equals(ep20) Then
            client.Set(a + "/p20", b)
        ElseIf sender.Equals(ep21) Then
            client.Set(a + "/p21", b)
        End If
    End Sub

    Public Sub SetYourPieceValueArbitrary(sender As Object, b As Boolean)
        Dim a As String
        If host Then
            a = Player1AlivePath
        Else
            a = Player2AlivePath
        End If
        If sender.Equals(hp1) Then
            client.Set(a + "/p01", b)
        ElseIf sender.Equals(hp2) Then
            client.Set(a + "/p02", b)
        ElseIf sender.Equals(hp3) Then
            client.Set(a + "/p03", b)
        ElseIf sender.Equals(hp4) Then
            client.Set(a + "/p04", b)
        ElseIf sender.Equals(hp5) Then
            client.Set(a + "/p05", b)
        ElseIf sender.Equals(hp6) Then
            client.Set(a + "/p06", b)
        ElseIf sender.Equals(hp7) Then
            client.Set(a + "/p07", b)
        ElseIf sender.Equals(hp8) Then
            client.Set(a + "/p08", b)
        ElseIf sender.Equals(hp9) Then
            client.Set(a + "/p09", b)
        ElseIf sender.Equals(hp10) Then
            client.Set(a + "/p10", b)
        ElseIf sender.Equals(hp11) Then
            client.Set(a + "/p11", b)
        ElseIf sender.Equals(hp12) Then
            client.Set(a + "/p12", b)
        ElseIf sender.Equals(hp13) Then
            client.Set(a + "/p13", b)
        ElseIf sender.Equals(hp14) Then
            client.Set(a + "/p14", b)
        ElseIf sender.Equals(hp15) Then
            client.Set(a + "/p15", b)
        ElseIf sender.Equals(hp16) Then
            client.Set(a + "/p16", b)
        ElseIf sender.Equals(hp17) Then
            client.Set(a + "/p17", b)
        ElseIf sender.Equals(hp18) Then
            client.Set(a + "/p18", b)
        ElseIf sender.Equals(hp19) Then
            client.Set(a + "/p19", b)
        ElseIf sender.Equals(hp20) Then
            client.Set(a + "/p20", b)
        ElseIf sender.Equals(hp21) Then
            client.Set(a + "/p21", b)
        End If
    End Sub

    'Public Sub SetArbitraryResult(sender As Object, sender2 As Object, a As Boolean, b As Boolean)
    '    'GET SENDER AND SENDER2 OBJECT
    '    If a And b Then
    '        SetYourPieceValueArbitrary(sender, a)
    '        SetEnemyPieceValueArbitrary(sender2, b)
    '    ElseIf Not a And Not b Then
    '        SetYourPieceValueArbitrary(sender, a)
    '        SetEnemyPieceValueArbitrary(sender2, b)
    '    ElseIf Not a And b Then
    '        SetYourPieceValueArbitrary(sender, a)
    '        SetEnemyPieceValueArbitrary(sender2, b)
    '    ElseIf a And Not b Then

    '    End If
    'End Sub

    Public Function Arbitrary(sender As Object, sender2 As Object) As Boolean
        Dim retVal As Boolean
        Dim a As Integer, b As Integer
        Dim c As Boolean, d As Boolean
        If sender.Equals(hp1) Or sender.Equals(hp2) Or sender.Equals(hp3) Or sender.Equals(hp4) Or sender.Equals(hp5) Or sender.Equals(hp6) Then
            If sender.Equals(hp1) Then
                yourGraveyard(0) = locationX(0)
            ElseIf sender.Equals(hp2) Then
                yourGraveyard(0) = locationX(1)
            ElseIf sender.Equals(hp3) Then
                yourGraveyard(0) = locationX(2)
            ElseIf sender.Equals(hp4) Then
                yourGraveyard(0) = locationX(3)
            ElseIf sender.Equals(hp5) Then
                yourGraveyard(0) = locationX(4)
            ElseIf sender.Equals(hp6) Then
                yourGraveyard(0) = locationX(5)
            End If
            a = 1
            yourGraveyard(1) = locationY(3)
        ElseIf sender.Equals(hp7) Then
            a = 2
            yourGraveyard(0) = locationX(6)
            yourGraveyard(1) = locationY(3)
        ElseIf sender.Equals(hp8) Then
            a = 3
            yourGraveyard(0) = locationX(0)
            yourGraveyard(1) = locationY(4)
        ElseIf sender.Equals(hp9) Then
            a = 4
            yourGraveyard(0) = locationX(1)
            yourGraveyard(1) = locationY(4)
        ElseIf sender.Equals(hp10) Then
            a = 5
            yourGraveyard(0) = locationX(2)
            yourGraveyard(1) = locationY(4)
        ElseIf sender.Equals(hp11) Then
            a = 6
            yourGraveyard(0) = locationX(3)
            yourGraveyard(1) = locationY(4)
        ElseIf sender.Equals(hp12) Then
            a = 7
            yourGraveyard(0) = locationX(4)
            yourGraveyard(1) = locationY(4)
        ElseIf sender.Equals(hp13) Then
            a = 8
            yourGraveyard(0) = locationX(5)
            yourGraveyard(1) = locationY(4)
        ElseIf sender.Equals(hp14) Then
            a = 9
            yourGraveyard(0) = locationX(6)
            yourGraveyard(1) = locationY(4)
        ElseIf sender.Equals(hp15) Then
            a = 10
            yourGraveyard(0) = locationX(0)
            yourGraveyard(1) = locationY(5)
        ElseIf sender.Equals(hp16) Then
            a = 11
            yourGraveyard(0) = locationX(1)
            yourGraveyard(1) = locationY(5)
        ElseIf sender.Equals(hp17) Then
            a = 12
            yourGraveyard(0) = locationX(2)
            yourGraveyard(1) = locationY(5)
        ElseIf sender.Equals(hp18) Then
            a = 13
            yourGraveyard(0) = locationX(3)
            yourGraveyard(1) = locationY(5)
        ElseIf sender.Equals(hp19) Or sender.Equals(hp20) Then
            a = 14
            If sender.Equals(hp19) Then
                yourGraveyard(0) = locationX(4)
            Else
                yourGraveyard(0) = locationX(5)
            End If
            yourGraveyard(1) = locationY(5)
        ElseIf sender.Equals(hp21) Then
            a = 0
            yourGraveyard(0) = locationX(6)
            yourGraveyard(1) = locationY(5)
        End If

        If sender2.Equals(ep1) Or sender2.Equals(ep2) Or sender2.Equals(ep3) Or sender2.Equals(ep4) Or sender2.Equals(ep5) Or sender2.Equals(ep6) Then
            If sender2.Equals(ep1) Then
                enemyGraveyard(0) = locationX(0)
            ElseIf sender2.Equals(ep2) Then
                enemyGraveyard(0) = locationX(1)
            ElseIf sender2.Equals(ep3) Then
                enemyGraveyard(0) = locationX(2)
            ElseIf sender2.Equals(ep4) Then
                enemyGraveyard(0) = locationX(3)
            ElseIf sender2.Equals(ep5) Then
                enemyGraveyard(0) = locationX(4)
            ElseIf sender2.Equals(ep6) Then
                enemyGraveyard(0) = locationX(5)
            End If
            b = 1
            enemyGraveyard(1) = locationY(0)
        ElseIf sender2.Equals(ep7) Then
            b = 2
            enemyGraveyard(0) = locationX(6)
            enemyGraveyard(1) = locationY(0)
        ElseIf sender2.Equals(ep8) Then
            b = 3
            enemyGraveyard(0) = locationX(0)
            enemyGraveyard(1) = locationY(1)
        ElseIf sender2.Equals(ep9) Then
            b = 4
            enemyGraveyard(0) = locationX(1)
            enemyGraveyard(1) = locationY(1)
        ElseIf sender2.Equals(ep10) Then
            b = 5
            enemyGraveyard(0) = locationX(2)
            enemyGraveyard(1) = locationY(1)
        ElseIf sender2.Equals(ep11) Then
            b = 6
            enemyGraveyard(0) = locationX(3)
            enemyGraveyard(1) = locationY(1)
        ElseIf sender2.Equals(ep12) Then
            b = 7
            enemyGraveyard(0) = locationX(4)
            enemyGraveyard(1) = locationY(1)
        ElseIf sender2.Equals(ep13) Then
            b = 8
            enemyGraveyard(0) = locationX(5)
            enemyGraveyard(1) = locationY(1)
        ElseIf sender2.Equals(ep14) Then
            b = 9
            enemyGraveyard(0) = locationX(6)
            enemyGraveyard(1) = locationY(1)
        ElseIf sender2.Equals(ep15) Then
            b = 10
            enemyGraveyard(0) = locationX(0)
            enemyGraveyard(1) = locationY(2)
        ElseIf sender2.Equals(ep16) Then
            b = 11
            enemyGraveyard(0) = locationX(1)
            enemyGraveyard(1) = locationY(2)
        ElseIf sender2.Equals(ep17) Then
            b = 12
            enemyGraveyard(0) = locationX(2)
            enemyGraveyard(1) = locationY(2)
        ElseIf sender2.Equals(ep18) Then
            b = 13
            enemyGraveyard(0) = locationX(3)
            enemyGraveyard(1) = locationY(2)
        ElseIf sender2.Equals(ep19) Or sender2.Equals(ep20) Then
            If sender2.Equals(ep19) Then
                enemyGraveyard(0) = locationX(4)
            Else
                enemyGraveyard(0) = locationX(5)
            End If
            b = 14
            enemyGraveyard(1) = locationY(2)
        ElseIf sender2.Equals(ep21) Then
            b = 0
            enemyGraveyard(0) = locationX(6)
            enemyGraveyard(1) = locationY(2)
        End If

        Dim piece As New Piece

        If a = b Then
            If a = 0 And b = 0 Then
                'SPECIAL ARBITRARY
                'AGGRESION VALUE
                'WHO CLICKED WINS
                c = True
                d = True
                winFromArbitrary = True
                retVal = True
                piece.Defeat(sender2, enemyGraveyard)
                piece.HideOrShowPiece(sender2, False)
            Else
                c = False
                d = False
                retVal = False
                piece.Defeat(sender, yourGraveyard)
                piece.Defeat(sender2, enemyGraveyard)
                piece.HideOrShowPiece(sender2, False)
            End If
        Else
            If a = 14 And b = 1 Then
                piece.Defeat(sender, yourGraveyard)
                c = False
                d = True
                retVal = False
            ElseIf a = 1 And b = 14 Then
                piece.Defeat(sender2, enemyGraveyard)
                piece.HideOrShowPiece(sender2, False)
                c = True
                d = False
                retVal = True
            Else
                If a > b Then
                    If b = 0 Then
                        'SET VALUE YOU WIN
                        winFromArbitrary = True
                        retVal = True
                    Else
                        piece.Defeat(sender2, enemyGraveyard)
                        piece.HideOrShowPiece(sender2, False)
                        c = True
                        d = False
                        retVal = True
                    End If
                Else
                    If a = 0 Then
                        'SET VALUE ENEMY WIN
                        winFromArbitrary = False
                        retVal = False
                    Else
                        piece.Defeat(sender, yourGraveyard)
                        c = False
                        d = True
                        retVal = False
                    End If
                End If
            End If
        End If
        SetYourPieceValueArbitrary(sender, c)
        SetEnemyPieceValueArbitrary(sender2, d)
        Return retVal
    End Function

    Public Sub SetEnemyAliveToBoard(b As Boolean, c As Integer)
        If Not b Then
            Dim piece As New Piece
            Select Case c
                Case 1 To 7
                    enemyGraveyard(1) = locationY(0)
                    If c = 1 Then
                        enemyGraveyard(0) = locationX(0)
                        piece.Defeat(ep1, enemyGraveyard)
                        piece.HideOrShowPiece(ep1, False)
                    ElseIf c = 2 Then
                        enemyGraveyard(0) = locationX(1)
                        piece.Defeat(ep2, enemyGraveyard)
                        piece.HideOrShowPiece(ep2, False)
                    ElseIf c = 3 Then
                        enemyGraveyard(0) = locationX(2)
                        piece.Defeat(ep3, enemyGraveyard)
                        piece.HideOrShowPiece(ep3, False)
                    ElseIf c = 4 Then
                        enemyGraveyard(0) = locationX(3)
                        piece.Defeat(ep4, enemyGraveyard)
                        piece.HideOrShowPiece(ep4, False)
                    ElseIf c = 5 Then
                        enemyGraveyard(0) = locationX(4)
                        piece.Defeat(ep5, enemyGraveyard)
                        piece.HideOrShowPiece(ep5, False)
                    ElseIf c = 6 Then
                        enemyGraveyard(0) = locationX(5)
                        piece.Defeat(ep6, enemyGraveyard)
                        piece.HideOrShowPiece(ep6, False)
                    ElseIf c = 7 Then
                        enemyGraveyard(0) = locationX(6)
                        piece.Defeat(ep7, enemyGraveyard)
                        piece.HideOrShowPiece(ep7, False)
                    End If

                Case 8 To 14
                    enemyGraveyard(1) = locationY(1)
                    If c = 8 Then
                        enemyGraveyard(0) = locationX(0)
                        piece.Defeat(ep8, enemyGraveyard)
                        piece.HideOrShowPiece(ep8, False)
                    ElseIf c = 9 Then
                        enemyGraveyard(0) = locationX(1)
                        piece.Defeat(ep9, enemyGraveyard)
                        piece.HideOrShowPiece(ep9, False)
                    ElseIf c = 10 Then
                        enemyGraveyard(0) = locationX(2)
                        piece.Defeat(ep10, enemyGraveyard)
                        piece.HideOrShowPiece(ep10, False)
                    ElseIf c = 11 Then
                        enemyGraveyard(0) = locationX(3)
                        piece.Defeat(ep11, enemyGraveyard)
                        piece.HideOrShowPiece(ep11, False)
                    ElseIf c = 12 Then
                        enemyGraveyard(0) = locationX(4)
                        piece.Defeat(ep12, enemyGraveyard)
                        piece.HideOrShowPiece(ep12, False)
                    ElseIf c = 13 Then
                        enemyGraveyard(0) = locationX(5)
                        piece.Defeat(ep13, enemyGraveyard)
                        piece.HideOrShowPiece(ep13, False)
                    ElseIf c = 14 Then
                        enemyGraveyard(0) = locationX(6)
                        piece.Defeat(ep14, enemyGraveyard)
                        piece.HideOrShowPiece(ep14, False)
                    End If
                Case 15 To 21
                    enemyGraveyard(1) = locationY(2)
                    If c = 15 Then
                        enemyGraveyard(0) = locationX(0)
                        piece.Defeat(ep15, enemyGraveyard)
                        piece.HideOrShowPiece(ep15, False)
                    ElseIf c = 16 Then
                        enemyGraveyard(0) = locationX(1)
                        piece.Defeat(ep16, enemyGraveyard)
                        piece.HideOrShowPiece(ep16, False)
                    ElseIf c = 17 Then
                        enemyGraveyard(0) = locationX(2)
                        piece.Defeat(ep17, enemyGraveyard)
                        piece.HideOrShowPiece(ep17, False)
                    ElseIf c = 18 Then
                        enemyGraveyard(0) = locationX(3)
                        piece.Defeat(ep18, enemyGraveyard)
                        piece.HideOrShowPiece(ep18, False)
                    ElseIf c = 19 Then
                        enemyGraveyard(0) = locationX(4)
                        piece.Defeat(ep19, enemyGraveyard)
                        piece.HideOrShowPiece(ep19, False)
                    ElseIf c = 20 Then
                        enemyGraveyard(0) = locationX(5)
                        piece.Defeat(ep20, enemyGraveyard)
                        piece.HideOrShowPiece(ep20, False)
                    ElseIf c = 21 Then
                        enemyGraveyard(0) = locationX(6)
                        piece.Defeat(ep21, enemyGraveyard)
                        piece.HideOrShowPiece(ep21, False)
                    End If
            End Select
        End If
    End Sub

    Public Sub SetYourAliveToBoard(b As Boolean, c As Integer)

        Dim piece As New Piece
        If Not b Then
            Select Case c
                Case 1 To 7
                    yourGraveyard(1) = locationY(3)
                    If c = 1 Then
                        yourGraveyard(0) = locationX(0)
                        piece.Defeat(hp1, yourGraveyard)
                    ElseIf c = 2 Then
                        yourGraveyard(0) = locationX(1)
                        piece.Defeat(hp2, yourGraveyard)
                    ElseIf c = 3 Then
                        yourGraveyard(0) = locationX(2)
                        piece.Defeat(hp3, yourGraveyard)
                    ElseIf c = 4 Then
                        yourGraveyard(0) = locationX(3)
                        piece.Defeat(hp4, yourGraveyard)
                    ElseIf c = 5 Then
                        yourGraveyard(0) = locationX(4)
                        piece.Defeat(hp5, yourGraveyard)
                    ElseIf c = 6 Then
                        yourGraveyard(0) = locationX(5)
                        piece.Defeat(hp6, yourGraveyard)
                    ElseIf c = 7 Then
                        yourGraveyard(0) = locationX(6)
                        piece.Defeat(hp7, yourGraveyard)
                    End If

                Case 8 To 14
                    yourGraveyard(1) = locationY(4)
                    If c = 8 Then
                        yourGraveyard(0) = locationX(0)
                        piece.Defeat(hp8, yourGraveyard)
                    ElseIf c = 9 Then
                        yourGraveyard(0) = locationX(1)
                        piece.Defeat(hp9, yourGraveyard)
                    ElseIf c = 10 Then
                        yourGraveyard(0) = locationX(2)
                        piece.Defeat(hp10, yourGraveyard)
                    ElseIf c = 11 Then
                        yourGraveyard(0) = locationX(3)
                        piece.Defeat(hp11, yourGraveyard)
                    ElseIf c = 12 Then
                        yourGraveyard(0) = locationX(4)
                        piece.Defeat(hp12, yourGraveyard)
                    ElseIf c = 13 Then
                        yourGraveyard(0) = locationX(5)
                        piece.Defeat(hp13, yourGraveyard)
                    ElseIf c = 14 Then
                        yourGraveyard(0) = locationX(6)
                        piece.Defeat(hp14, yourGraveyard)
                    End If
                Case 15 To 21
                    yourGraveyard(1) = locationY(5)
                    If c = 15 Then
                        yourGraveyard(0) = locationX(0)
                        piece.Defeat(hp15, yourGraveyard)
                    ElseIf c = 16 Then
                        yourGraveyard(0) = locationX(1)
                        piece.Defeat(hp16, yourGraveyard)
                    ElseIf c = 17 Then
                        yourGraveyard(0) = locationX(2)
                        piece.Defeat(hp17, yourGraveyard)
                    ElseIf c = 18 Then
                        yourGraveyard(0) = locationX(3)
                        piece.Defeat(hp18, yourGraveyard)
                    ElseIf c = 19 Then
                        yourGraveyard(0) = locationX(4)
                        piece.Defeat(hp19, yourGraveyard)
                    ElseIf c = 20 Then
                        yourGraveyard(0) = locationX(5)
                        piece.Defeat(hp20, yourGraveyard)
                    ElseIf c = 21 Then
                        yourGraveyard(0) = locationX(6)
                        piece.Defeat(hp21, yourGraveyard)
                    End If
            End Select
        End If
    End Sub

    Public Sub GetAlivePiece()
        Dim alive As New Alive
        Dim alive2 As New Alive
        Dim res = client.Get(Player1AlivePath)
        Dim res2 = client.Get(Player2AlivePath)
        If host Then
            alive = res.ResultAs(Of Alive)
            alive2 = res2.ResultAs(Of Alive)

            SetYourAliveToBoard(alive.p01, 1)
            SetYourAliveToBoard(alive.p02, 2)
            SetYourAliveToBoard(alive.p03, 3)
            SetYourAliveToBoard(alive.p04, 4)
            SetYourAliveToBoard(alive.p05, 5)
            SetYourAliveToBoard(alive.p06, 6)
            SetYourAliveToBoard(alive.p07, 7)
            SetYourAliveToBoard(alive.p08, 8)
            SetYourAliveToBoard(alive.p09, 9)
            SetYourAliveToBoard(alive.p10, 10)
            SetYourAliveToBoard(alive.p11, 11)
            SetYourAliveToBoard(alive.p12, 12)
            SetYourAliveToBoard(alive.p13, 13)
            SetYourAliveToBoard(alive.p14, 14)
            SetYourAliveToBoard(alive.p15, 15)
            SetYourAliveToBoard(alive.p16, 16)
            SetYourAliveToBoard(alive.p17, 17)
            SetYourAliveToBoard(alive.p18, 18)
            SetYourAliveToBoard(alive.p19, 19)
            SetYourAliveToBoard(alive.p20, 20)
            SetYourAliveToBoard(alive.p21, 21)

            SetEnemyAliveToBoard(alive2.p01, 1)
            SetEnemyAliveToBoard(alive2.p02, 2)
            SetEnemyAliveToBoard(alive2.p03, 3)
            SetEnemyAliveToBoard(alive2.p04, 4)
            SetEnemyAliveToBoard(alive2.p05, 5)
            SetEnemyAliveToBoard(alive2.p06, 6)
            SetEnemyAliveToBoard(alive2.p07, 7)
            SetEnemyAliveToBoard(alive2.p08, 8)
            SetEnemyAliveToBoard(alive2.p09, 9)
            SetEnemyAliveToBoard(alive2.p10, 10)
            SetEnemyAliveToBoard(alive2.p11, 11)
            SetEnemyAliveToBoard(alive2.p12, 12)
            SetEnemyAliveToBoard(alive2.p13, 13)
            SetEnemyAliveToBoard(alive2.p14, 14)
            SetEnemyAliveToBoard(alive2.p15, 15)
            SetEnemyAliveToBoard(alive2.p16, 16)
            SetEnemyAliveToBoard(alive2.p17, 17)
            SetEnemyAliveToBoard(alive2.p18, 18)
            SetEnemyAliveToBoard(alive2.p19, 19)
            SetEnemyAliveToBoard(alive2.p20, 20)
            SetEnemyAliveToBoard(alive2.p21, 21)
        Else
            alive = res2.ResultAs(Of Alive)
            alive2 = res.ResultAs(Of Alive)

            SetYourAliveToBoard(alive.p01, 1)
            SetYourAliveToBoard(alive.p02, 2)
            SetYourAliveToBoard(alive.p03, 3)
            SetYourAliveToBoard(alive.p04, 4)
            SetYourAliveToBoard(alive.p05, 5)
            SetYourAliveToBoard(alive.p06, 6)
            SetYourAliveToBoard(alive.p07, 7)
            SetYourAliveToBoard(alive.p08, 8)
            SetYourAliveToBoard(alive.p09, 9)
            SetYourAliveToBoard(alive.p10, 10)
            SetYourAliveToBoard(alive.p11, 11)
            SetYourAliveToBoard(alive.p12, 12)
            SetYourAliveToBoard(alive.p13, 13)
            SetYourAliveToBoard(alive.p14, 14)
            SetYourAliveToBoard(alive.p15, 15)
            SetYourAliveToBoard(alive.p16, 16)
            SetYourAliveToBoard(alive.p17, 17)
            SetYourAliveToBoard(alive.p18, 18)
            SetYourAliveToBoard(alive.p19, 19)
            SetYourAliveToBoard(alive.p20, 20)
            SetYourAliveToBoard(alive.p21, 21)

            SetEnemyAliveToBoard(alive2.p01, 1)
            SetEnemyAliveToBoard(alive2.p02, 2)
            SetEnemyAliveToBoard(alive2.p03, 3)
            SetEnemyAliveToBoard(alive2.p04, 4)
            SetEnemyAliveToBoard(alive2.p05, 5)
            SetEnemyAliveToBoard(alive2.p06, 6)
            SetEnemyAliveToBoard(alive2.p07, 7)
            SetEnemyAliveToBoard(alive2.p08, 8)
            SetEnemyAliveToBoard(alive2.p09, 9)
            SetEnemyAliveToBoard(alive2.p10, 10)
            SetEnemyAliveToBoard(alive2.p11, 11)
            SetEnemyAliveToBoard(alive2.p12, 12)
            SetEnemyAliveToBoard(alive2.p13, 13)
            SetEnemyAliveToBoard(alive2.p14, 14)
            SetEnemyAliveToBoard(alive2.p15, 15)
            SetEnemyAliveToBoard(alive2.p16, 16)
            SetEnemyAliveToBoard(alive2.p17, 17)
            SetEnemyAliveToBoard(alive2.p18, 18)
            SetEnemyAliveToBoard(alive2.p19, 19)
            SetEnemyAliveToBoard(alive2.p20, 20)
            SetEnemyAliveToBoard(alive2.p21, 21)
        End If

    End Sub

    Public Function CheckFlagIfReachEndPosition() As Boolean
        SetPiecesAndCoordinateObject()

        Dim loc As New Location

        'For j = 0 To 26
        '    pieceCoor = loc.LocationGet(pieceObject(i))
        '    coorVal = loc.LocationGet(coordinateObject(j))

        '    If pieceCoor(0) = coorVal(0) And pieceCoor(1) = coorVal(1) Then
        '        pieceCoordinate(i) = GetCoordinateString(j)
        '    End If
        'Next
        Dim pieceCoor As Integer()
        Dim coorVal As Integer()

        pieceCoor = loc.LocationGet(hp21)

        Dim retVal As Boolean

        For i = 0 To 71
            If i = 0 Or i = 8 Or i = 16 Or i = 24 Or i = 32 Or i = 40 Or i = 48 Or i = 56 Or i = 64 Then
                coorVal = loc.LocationGet(gridCoordinateObject(i))
                If pieceCoor(0) = coorVal(0) And pieceCoor(1) = coorVal(1) Then
                    retVal = True
                Else
                    retVal = False
                End If
            End If
        Next

        Return retVal
    End Function

    Public Function CheckSurroundingFlag() As Boolean
        SetPiecesAndCoordinateObject()
        Dim loc As Location = New Location
        Dim pieceCoor As Integer()
        Dim coorVal As Integer()
        Dim coorVal1 As Integer()
        Dim coorVal2 As Integer()
        Dim coorVal3 As Integer()
        'Dim coorVal4 As Integer()
        Dim r As Integer()
        Dim b As Boolean

        r = loc.LocationGet(hp21)
        If CheckFlagIfReachEndPosition() Then
            'MessageBox.Show("IT RUUNS!")
            For j = 0 To 20
                pieceCoor = loc.LocationGet(enemyObject(j)) 'enemy piece
                For i = 0 To 71
                    coorVal = loc.LocationGet(gridCoordinateObject(i))
                    If r(0) = coorVal(0) And r(1) = coorVal(1) Then
                        MessageBox.Show("IT RUNS")
                        If i = 0 Or i = 64 Then
                            If i = 0 Then
                                coorVal1 = loc.LocationGet(gridCoordinateObject(i + 8))
                                coorVal2 = loc.LocationGet(gridCoordinateObject(i + 1))
                                If pieceCoor(0) = coorVal1(0) And pieceCoor(1) = coorVal1(1) Then
                                    b = False
                                ElseIf pieceCoor(0) = coorVal2(1) And pieceCoor(1) = coorVal2(1) Then
                                    b = False
                                Else
                                    b = True
                                End If

                            ElseIf i = 64 Then
                                coorVal2 = loc.LocationGet(gridCoordinateObject(i + 1))
                                coorVal3 = loc.LocationGet(gridCoordinateObject(i - 8))
                                If pieceCoor(0) = coorVal2(0) And pieceCoor(1) = coorVal2(1) Then
                                    b = False
                                ElseIf pieceCoor(0) = coorVal3(0) And pieceCoor(1) = coorVal3(1) Then
                                    b = False
                                Else
                                    b = True
                                End If

                            ElseIf i = 8 Or i = 16 Or i = 24 Or i = 32 Or i = 40 Or i = 48 Or i = 56 Then
                                coorVal1 = loc.LocationGet(gridCoordinateObject(i + 8))
                                coorVal2 = loc.LocationGet(gridCoordinateObject(i + 1))
                                coorVal3 = loc.LocationGet(gridCoordinateObject(i - 8))
                                If pieceCoor(0) = coorVal1(0) And pieceCoor(1) = coorVal1(1) Then
                                    b = False
                                ElseIf pieceCoor(0) = coorVal2(0) And pieceCoor(1) = coorVal2(1) Then
                                    b = False
                                ElseIf pieceCoor(0) = coorVal3(0) And pieceCoor(1) = coorVal3(1) Then
                                    b = False
                                Else
                                    b = True
                                End If
                            End If
                        End If
                    End If
                Next
            Next
        End If

        Return b
    End Function

    Public Function DidYouWin() As Boolean
        If CheckSurroundingFlag() Then
            Return True
        ElseIf winFromArbitrary Then
            Return True
        Else
            Return False
        End If
    End Function

    Public Sub SetWinner(a As String)
        client.Set(roomNamePath + "/whoWin", a)
    End Sub

    Public Function GetWinner() As Boolean
        'Dim b As Boolean
        Dim res = client.Get(roomNamePath + "/whoWin")
        winner = res.ResultAs(Of String)

        If String.IsNullOrEmpty(winner) Then
            Return False
        Else
            Return True
        End If
    End Function

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
        Player1Path = roomNamePath + "/player1"
        Player2Path = roomNamePath + "/player2"
        Player1AlivePath = Player1Path + "/alive"
        Player2AlivePath = Player2Path + "/alive"
        Player1PiecePath = Player1Path + "/piece"
        Player2PiecePath = Player2Path + "/piece"
        'ArbitraryPath = roomNamePath + "/arbitrary"
        Player2MovePath = Player2Path + "/move"
        Player1MovePath = Player1Path + "/move"

        WinOrLose.Visible = False

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

    Dim showed = True
    'Dim firstPieceArbitrary As Integer
    'Dim secondPieceArbitrary As Integer
    Public Sub GetClickButton(sender As Object, e As EventArgs) Handles a6.Click, a7.Click, a8.Click, b6.Click, b7.Click, b8.Click, c6.Click, c7.Click, c8.Click, d6.Click, d7.Click, d8.Click, e6.Click, e7.Click, e8.Click, f6.Click, f7.Click, f8.Click, g6.Click, g7.Click, g8.Click, h6.Click, h7.Click, h8.Click, i6.Click, i7.Click, i8.Click,
        hp1.Click, hp2.Click, hp3.Click, hp4.Click, hp5.Click, hp6.Click, hp7.Click, hp8.Click, hp9.Click, hp10.Click,
        hp11.Click, hp12.Click, hp13.Click, hp14.Click, hp15.Click, hp16.Click, hp17.Click, hp18.Click, hp19.Click, hp20.Click, hp21.Click, a1.Click, a2.Click, a3.Click, a4.Click, a5.Click, b1.Click, b2.Click, b3.Click, b4.Click, b5.Click, c1.Click, c2.Click, c3.Click, c4.Click, c5.Click, d1.Click, d2.Click, d3.Click, d4.Click, d5.Click, e1.Click, e2.Click, e3.Click, e4.Click, e5.Click, f1.Click, f2.Click, f3.Click, f4.Click, f5.Click, g1.Click, g2.Click, g3.Click, g4.Click, g5.Click, h1.Click, h2.Click, h3.Click, h4.Click, h5.Click, i1.Click, i2.Click, i3.Click, i4.Click, i5.Click, ep1.Click,
        ep2.Click, ep3.Click, ep4.Click, ep5.Click, ep6.Click, ep7.Click, ep8.Click, ep9.Click, ep10.Click, ep11.Click, ep13.Click, ep14.Click, ep15.Click, ep16.Click, ep17.Click, ep18.Click, ep19.Click, ep20.Click, ready.Click, myName.Click



        'If sender.Equals(ep1) Then
        '    MessageBox.Show("EP1 CLICKED")
        'End If

        'CHECK IF PLAYER LEFT

        'LISTEN IF SOMEONE JOIN THE ROOM
        If Not Check() Then
            GetName()
            SetName()
        End If

        'CHECK IF ENEMY IS READY
        'IF ENEMY IS READY PIECE WILL SHOW TO YOU
        If host And showed Then
            If GetPlayer2ReadyStatus() Then
                GetAndSetEnemyLocation()
                ShowPiece(host)
                showed = False
            End If
        ElseIf Not host And showed Then
            If GetPlayer1ReadyStatus() Then
                GetAndSetEnemyLocation()
                ShowPiece(host)
                showed = False
            End If
        End If

        If sender.Equals(ready) Then
            If isGameTime And isGameTimeDB Then
                Dim l As Integer = GetCounter()
                If Not host Then
                    'GetAndSetEnemyMove()
                    GetEnemyMoveFromDatabase()
                    SetCounter(l)
                    GetAlivePiece()
                Else
                    If l > 0 Then
                        SetCounter(l)
                        'GetAndSetEnemyMove()
                        GetEnemyMoveFromDatabase()
                        GetAlivePiece()
                    End If
                End If
            Else
                GetLocation()
                isGameTime = True
                SetReadyToDatabase()
                SetPiecesToDatabase()
                MessageBox.Show("All Set!")
                ready.Enabled = False
            End If
        End If
        'LISTEN MOVES
        If isGameTime And isGameTimeDB Then
            'CHECK WHO WIN
            If GetWinner() Then
                WinOrLose.Visible = True
                'DISABLED ALL CLICK EXCEPT READY
                If winner = "player1" Then
                    If host Then
                        WinOrLose.Image = My.Resources.win
                    Else
                        WinOrLose.Image = My.Resources.lose
                    End If
                Else
                    If host Then
                        WinOrLose.Image = My.Resources.lose
                    Else
                        WinOrLose.Image = My.Resources.win
                    End If
                End If
            End If
            If DidYouWin() Then
                If host Then
                    SetWinner("player1")
                Else
                    SetWinner("player2")
                End If
            End If
            myName.Enabled = False
            ready.Enabled = True
            MessageBox.Show("GAME TIME")
            'RESET COLORS
            ResetColors()
            'METHOD GAME TIME
            'ready.Visible = False
            If host Then
                If GetPlayerTurn() Then
                    ready.Text = "SEND"
                    myNameLine.BackColor = Color.Green
                    enemyNameLine.BackColor = Color.Red
                    If firstClick Then
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
                            piece1 = DirectCast(sender, Button)
                            CheckPossibleMove(sender, hostPossibleColor)
                            firstPieceLocation = GetLocationFirstPiece(sender)
                            SetFirstClickObject(sender)
                            'firstPieceArbitrary = GetPieceValue(sender)
                            firstClick = False
                        Else
                            MessageBox.Show("Please select a piece")
                            firstClick = True
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
                            'SetPlayerTurn(host)
                            firstClick = True
                        Else
                            x2 = piece2.Location.X
                            y2 = piece2.Location.Y
                            'METHOD FOR Move
                            'If sender.Equals(a6) Then
                            '    piece1.Location = New Point(x2, y2)&
                            If IsItPossibleToMove(piece2, firstPieceLocation) Then
                                'ARBITRARY
                                If sender.Equals(ep1) Or
                                sender.Equals(ep2) Or
                                sender.Equals(ep3) Or
                                sender.Equals(ep4) Or
                                sender.Equals(ep5) Or
                                sender.Equals(ep6) Or
                                sender.Equals(ep7) Or
                                sender.Equals(ep8) Or
                                sender.Equals(ep9) Or
                                sender.Equals(ep10) Or
                                sender.Equals(ep11) Or
                                sender.Equals(ep12) Or
                                sender.Equals(ep13) Or
                                sender.Equals(ep14) Or
                                sender.Equals(ep15) Or
                                sender.Equals(ep16) Or
                                sender.Equals(ep17) Or
                                sender.Equals(ep18) Or
                                sender.Equals(ep19) Or
                                sender.Equals(ep20) Or
                                sender.Equals(ep21) Then
                                    'secondPieceArbitrary = GetPieceValue(sender)
                                    If Arbitrary(piece1, piece2) Then
                                        'HIDE/SHOW PIECE TO ENEMY
                                        piece1.Location = New Point(x2, y2)
                                    End If
                                    'METHOD TO SEND TO DATABASE
                                    SetCoordinateObject(x2, y2)
                                    SetMoveToDatabase()
                                    firstClick = True
                                    SetPlayerTurn(Not host)
                                Else
                                    piece1.Location = New Point(x2, y2)
                                    'METHOD TO SEND TO DATABASE
                                    SetCoordinateObject(x2, y2)
                                    SetMoveToDatabase()
                                    firstClick = True
                                    SetPlayerTurn(Not host)
                                End If
                            Else
                                    MessageBox.Show("You can only move one tile away")
                                ResetValue()
                                firstClick = True
                            End If
                        End If
                    End If
                Else
                    ready.Text = "RECEIVE"
                    MessageBox.Show("Opponent's Turn")
                    enemyNameLine.BackColor = Color.Green
                    myNameLine.BackColor = Color.Red
                    'If Not CheckfirstMove() Then
                    '    GetAndSetEnemyMove()
                    'Else
                    '    SetFirstMove(False)
                    'End If
                End If
            Else
                If GetPlayerTurn() Then
                    ready.Text = "RECEIVE"
                    MessageBox.Show("Opponent's Turn")
                    enemyNameLine.BackColor = Color.Green
                    myNameLine.BackColor = Color.Red
                Else
                    'If Not CheckfirstMove() Then
                    '    GetAndSetEnemyMove()
                    'End If
                    ready.Text = "SEND"
                    myNameLine.BackColor = Color.Green
                    enemyNameLine.BackColor = Color.Red
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
                            CheckPossibleMove(sender, guestPossibleColor)
                            firstPieceLocation = GetLocationFirstPiece(sender)
                            SetFirstClickObject(sender)
                            firstClick = False
                        Else
                            MessageBox.Show("Please select a piece")
                            firstClick = True
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
                            firstClick = True
                        Else
                            x2 = piece2.Location.X
                            y2 = piece2.Location.Y
                            'METHOD FOR Move
                            If IsItPossibleToMove(piece2, firstPieceLocation) Then
                                'ARBITRARY
                                If sender.Equals(ep1) Or
                                sender.Equals(ep2) Or
                                sender.Equals(ep3) Or
                                sender.Equals(ep4) Or
                                sender.Equals(ep5) Or
                                sender.Equals(ep6) Or
                                sender.Equals(ep7) Or
                                sender.Equals(ep8) Or
                                sender.Equals(ep9) Or
                                sender.Equals(ep10) Or
                                sender.Equals(ep11) Or
                                sender.Equals(ep12) Or
                                sender.Equals(ep13) Or
                                sender.Equals(ep14) Or
                                sender.Equals(ep15) Or
                                sender.Equals(ep16) Or
                                sender.Equals(ep17) Or
                                sender.Equals(ep18) Or
                                sender.Equals(ep19) Or
                                sender.Equals(ep20) Or
                                sender.Equals(ep21) Then
                                    'secondPieceArbitrary = GetPieceValue(sender)
                                    If Arbitrary(piece1, piece2) Then
                                        'HIDE/SHOW PIECE TO ENEMY
                                        piece1.Location = New Point(x2, y2)
                                    End If
                                    'METHOD TO SEND TO DATABASE
                                    SetCoordinateObject(x2, y2)
                                    SetMoveToDatabase()
                                    SetPlayerTurn(Not host)
                                    firstClick = True
                                Else
                                    piece1.Location = New Point(x2, y2)
                                    'METHOD TO SEND TO DATABASE
                                    SetCoordinateObject(x2, y2)
                                    SetMoveToDatabase()
                                    SetPlayerTurn(Not host)
                                    firstClick = True
                                End If
                            Else
                                MessageBox.Show("You can only move one tile away")
                                ResetValue()
                                firstClick = True
                            End If
                        End If
                    End If
                End If
            End If
        Else
            'STRATEGY TIME
            myName.Enabled = True
            If GetPlayer1ReadyStatus() And GetPlayer2ReadyStatus() Then
                isGameTimeDB = True
            Else
                If firstClick Then
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
                        piece1 = DirectCast(sender, Button)
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
End Class