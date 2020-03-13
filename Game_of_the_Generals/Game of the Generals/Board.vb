Imports System.Net.Sockets
Imports System.Net

Public Class gameboard

    Dim playerChar As Char
    Dim opponentChar As Char
    Dim sock As Socket
    Dim serverSocket As TcpListener
    Dim clientSocket As TcpClient

    Public Sub New(isHost As Boolean, ip As String)

        InitializeComponent()
        CheckForIllegalCrossThreadCalls = False

        If (isHost) Then

            playerChar = "X"
            opponentChar = "O"
            serverSocket = New TcpListener(IPAddress.Any, 3306)
            serverSocket.Start()
            sock = serverSocket.AcceptSocket()

        Else

            playerChar = "O"
            opponentChar = "X"

            Try

                clientSocket = New TcpClient(ip, 3306)
                sock = clientSocket.Client
                BackgroundWorker1.RunWorkerAsync()

            Catch ex As Exception

                MessageBox.Show(ex.Message)
                Close()

            End Try

        End If

    End Sub

    Private Sub BackgroundWorker1_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles BackgroundWorker1.DoWork

        If checkState() Then

            Return
            freezeBoard()
            opponentName.Text = "Opponent's Turn"
            receiveMove()
            opponentName.Text = "Your Turn"

        End If

        If Not checkState() Then

            unfreezeBoard()

        End If

    End Sub

    Private Function checkState() As Boolean
        ' Horizontals
        If a1.Text = b1.Text And b1.Text = c1.Text And c1.Text IsNot "" Then
            If a1.Text(0) = playerChar Then
                opponentName.Text = "You Won"
            Else
                opponentName.Text = "You Lost"
            End If
            Return True
        End If

        If a2.Text = b2.Text And b2.Text = c2.Text And c2.Text IsNot "" Then
            If a1.Text(0) = playerChar Then
                opponentName.Text = "You Won"
            Else
                opponentName.Text = "You Lost"
            End If
            Return True
        End If

        If a3.Text = b3.Text And b3.Text = c3.Text And c3.Text IsNot "" Then
            If a1.Text(0) = playerChar Then
                opponentName.Text = "You Won"
            Else
                opponentName.Text = "You Lost"
            End If
            Return True
        End If

        Return False
    End Function

    Private Sub freezeBoard()

        ' col a
        a1.Enabled = False
        a2.Enabled = False
        a3.Enabled = False
        a4.Enabled = False
        a5.Enabled = False
        a6.Enabled = False
        a7.Enabled = False
        a8.Enabled = False

        ' b
        b1.Enabled = False
        b2.Enabled = False
        b3.Enabled = False
        b4.Enabled = False
        b5.Enabled = False
        b6.Enabled = False
        b7.Enabled = False
        b8.Enabled = False

        ' c
        c1.Enabled = False
        c2.Enabled = False
        c3.Enabled = False
        c4.Enabled = False
        c5.Enabled = False
        c6.Enabled = False
        c7.Enabled = False
        c8.Enabled = False

        ' d
        d1.Enabled = False
        d2.Enabled = False
        d3.Enabled = False
        d4.Enabled = False
        d5.Enabled = False
        d6.Enabled = False
        d7.Enabled = False
        d8.Enabled = False

        ' e
        e1.Enabled = False
        e2.Enabled = False
        e3.Enabled = False
        e4.Enabled = False
        e5.Enabled = False
        e6.Enabled = False
        e7.Enabled = False
        e8.Enabled = False

        ' f
        f1.Enabled = False
        f2.Enabled = False
        f3.Enabled = False
        f4.Enabled = False
        f5.Enabled = False
        f6.Enabled = False
        f7.Enabled = False
        f8.Enabled = False

        ' g
        g1.Enabled = False
        g2.Enabled = False
        g3.Enabled = False
        g4.Enabled = False
        g5.Enabled = False
        g6.Enabled = False
        g7.Enabled = False
        g8.Enabled = False

        ' h
        h1.Enabled = False
        h2.Enabled = False
        h3.Enabled = False
        h4.Enabled = False
        h5.Enabled = False
        h6.Enabled = False
        h7.Enabled = False
        h8.Enabled = False

        ' i
        i1.Enabled = False
        i2.Enabled = False
        i3.Enabled = False
        i4.Enabled = False
        i5.Enabled = False
        i6.Enabled = False
        i7.Enabled = False
        i8.Enabled = False

    End Sub

    Private Sub unfreezeBoard()

        ' col a
        If a1.Text = "" Then
            a1.Enabled = True
        End If
        If a2.Text = "" Then
            a2.Enabled = True
        End If
        If a3.Text = "" Then
            a3.Enabled = True
        End If
        If a4.Text = "" Then
            a4.Enabled = True
        End If
        If a5.Text = "" Then
            a5.Enabled = True
        End If
        If a6.Text = "" Then
            a6.Enabled = True
        End If
        If a7.Text = "" Then
            a7.Enabled = True
        End If
        If a8.Text = "" Then
            a8.Enabled = True
        End If

        ' b
        If b1.Text = "" Then
            b1.Enabled = True
        End If
        If b2.Text = "" Then
            b2.Enabled = True
        End If
        If b3.Text = "" Then
            b3.Enabled = True
        End If
        If b4.Text = "" Then
            b4.Enabled = True
        End If
        If b5.Text = "" Then
            b5.Enabled = True
        End If
        If b6.Text = "" Then
            b6.Enabled = True
        End If
        If b7.Text = "" Then
            b7.Enabled = True
        End If
        If b8.Text = "" Then
            b8.Enabled = True
        End If

        ' c
        If c1.Text = "" Then
            c1.Enabled = True
        End If
        If c2.Text = "" Then
            c2.Enabled = True
        End If
        If c3.Text = "" Then
            c3.Enabled = True
        End If
        If c4.Text = "" Then
            c4.Enabled = True
        End If
        If c5.Text = "" Then
            c5.Enabled = True
        End If
        If c6.Text = "" Then
            c6.Enabled = True
        End If
        If c7.Text = "" Then
            c7.Enabled = True
        End If
        If c8.Text = "" Then
            c8.Enabled = True
        End If

        ' d
        If d1.Text = "" Then
            d1.Enabled = True
        End If
        If d2.Text = "" Then
            d2.Enabled = True
        End If
        If d3.Text = "" Then
            d3.Enabled = True
        End If
        If d4.Text = "" Then
            d4.Enabled = True
        End If
        If d5.Text = "" Then
            d5.Enabled = True
        End If
        If d6.Text = "" Then
            d6.Enabled = True
        End If
        If d7.Text = "" Then
            d7.Enabled = True
        End If
        If d8.Text = "" Then
            d8.Enabled = True
        End If

        ' e
        If e1.Text = "" Then
            e1.Enabled = True
        End If
        If e2.Text = "" Then
            e2.Enabled = True
        End If
        If e3.Text = "" Then
            e3.Enabled = True
        End If
        If e4.Text = "" Then
            e4.Enabled = True
        End If
        If e5.Text = "" Then
            e5.Enabled = True
        End If
        If e6.Text = "" Then
            e6.Enabled = True
        End If
        If e7.Text = "" Then
            e7.Enabled = True
        End If
        If e8.Text = "" Then
            e8.Enabled = True
        End If

        ' f
        If f1.Text = "" Then
            f1.Enabled = True
        End If
        If f2.Text = "" Then
            f2.Enabled = True
        End If
        If f3.Text = "" Then
            f3.Enabled = True
        End If
        If f4.Text = "" Then
            f4.Enabled = True
        End If
        If f5.Text = "" Then
            f5.Enabled = True
        End If
        If f6.Text = "" Then
            f6.Enabled = True
        End If
        If f7.Text = "" Then
            f7.Enabled = True
        End If
        If f8.Text = "" Then
            f8.Enabled = True
        End If

        ' g
        If g1.Text = "" Then
            g1.Enabled = True
        End If
        If g2.Text = "" Then
            g2.Enabled = True
        End If
        If g3.Text = "" Then
            g3.Enabled = True
        End If
        If g4.Text = "" Then
            g4.Enabled = True
        End If
        If g5.Text = "" Then
            g5.Enabled = True
        End If
        If g6.Text = "" Then
            g6.Enabled = True
        End If
        If g7.Text = "" Then
            g7.Enabled = True
        End If
        If g8.Text = "" Then
            g8.Enabled = True
        End If

        ' h
        If h1.Text = "" Then
            h1.Enabled = True
        End If
        If h2.Text = "" Then
            h2.Enabled = True
        End If
        If h3.Text = "" Then
            h3.Enabled = True
        End If
        If h4.Text = "" Then
            h4.Enabled = True
        End If
        If h5.Text = "" Then
            h5.Enabled = True
        End If
        If h6.Text = "" Then
            h6.Enabled = True
        End If
        If h7.Text = "" Then
            h7.Enabled = True
        End If
        If h8.Text = "" Then
            h8.Enabled = True
        End If

        ' i
        If i1.Text = "" Then
            i1.Enabled = True
        End If
        If i2.Text = "" Then
            i2.Enabled = True
        End If
        If i3.Text = "" Then
            i3.Enabled = True
        End If
        If i4.Text = "" Then
            i4.Enabled = True
        End If
        If i5.Text = "" Then
            i5.Enabled = True
        End If
        If i6.Text = "" Then
            i6.Enabled = True
        End If
        If i7.Text = "" Then
            i7.Enabled = True
        End If
        If i8.Text = "" Then
            i8.Enabled = True
        End If

    End Sub

    ' Wait message sent by opponent
    ' Contains number of button that the opponent has placed his  'X' or 'O'
    Private Sub receiveMove()

        Dim bytesFrom(1) As Byte
        sock.Receive(bytesFrom)
        'networkStream.Read(bytesFrom, 0, bytesFrom.Length)

        ' col a
        If (bytesFrom(0) = 1) Then
            a1.Text = opponentChar.ToString()
        End If
        If (bytesFrom(0) = 1) Then
            a2.Text = opponentChar.ToString()
        End If
        If (bytesFrom(0) = 1) Then
            a3.Text = opponentChar.ToString()
        End If
        If (bytesFrom(0) = 1) Then
            a4.Text = opponentChar.ToString()
        End If
        If (bytesFrom(0) = 1) Then
            a5.Text = opponentChar.ToString()
        End If
        If (bytesFrom(0) = 1) Then
            a6.Text = opponentChar.ToString()
        End If
        If (bytesFrom(0) = 1) Then
            a7.Text = opponentChar.ToString()
        End If
        If (bytesFrom(0) = 1) Then
            a8.Text = opponentChar.ToString()
        End If

        ' col b
        If (bytesFrom(0) = 1) Then
            b1.Text = opponentChar.ToString()
        End If
        If (bytesFrom(0) = 1) Then
        End If
        If (bytesFrom(0) = 1) Then
            b3.Text = opponentChar.ToString()
        End If
        If (bytesFrom(0) = 1) Then
            b4.Text = opponentChar.ToString()
        End If
        If (bytesFrom(0) = 1) Then
            b5.Text = opponentChar.ToString()
        End If
        If (bytesFrom(0) = 1) Then
            b6.Text = opponentChar.ToString()
        End If
        If (bytesFrom(0) = 1) Then
            b7.Text = opponentChar.ToString()
        End If
        If (bytesFrom(0) = 1) Then
            b8.Text = opponentChar.ToString()
        End If

        ' col c
        If (bytesFrom(0) = 1) Then
            c1.Text = opponentChar.ToString()
        End If
        If (bytesFrom(0) = 1) Then
            c2.Text = opponentChar.ToString()

        End If
        If (bytesFrom(0) = 1) Then
            c3.Text = opponentChar.ToString()
        End If

        If (bytesFrom(0) = 1) Then
            c4.Text = opponentChar.ToString()
        End If
        If (bytesFrom(0) = 1) Then
            c5.Text = opponentChar.ToString()
        End If
        If (bytesFrom(0) = 1) Then
            c6.Text = opponentChar.ToString()
        End If
        If (bytesFrom(0) = 1) Then
            c7.Text = opponentChar.ToString()
        End If
        If (bytesFrom(0) = 1) Then
            c8.Text = opponentChar.ToString()
        End If

        ' col d
        If (bytesFrom(0) = 1) Then
            d1.Text = opponentChar.ToString()
        End If
        If (bytesFrom(0) = 1) Then
            d2.Text = opponentChar.ToString()
        End If
        If (bytesFrom(0) = 1) Then
            d3.Text = opponentChar.ToString()
        End If
        If (bytesFrom(0) = 1) Then
            d4.Text = opponentChar.ToString()
        End If
        If (bytesFrom(0) = 1) Then
            d5.Text = opponentChar.ToString()
        End If
        If (bytesFrom(0) = 1) Then
            d6.Text = opponentChar.ToString()
        End If
        If (bytesFrom(0) = 1) Then
            d7.Text = opponentChar.ToString()
        End If
        If (bytesFrom(0) = 1) Then
            d8.Text = opponentChar.ToString()
        End If

        ' col e
        If (bytesFrom(0) = 1) Then
            e1.Text = opponentChar.ToString()
        End If
        If (bytesFrom(0) = 1) Then
            e2.Text = opponentChar.ToString()
        End If
        If (bytesFrom(0) = 1) Then
            e3.Text = opponentChar.ToString()
        End If
        If (bytesFrom(0) = 1) Then
            e4.Text = opponentChar.ToString()
        End If
        If (bytesFrom(0) = 1) Then
            e5.Text = opponentChar.ToString()
        End If
        If (bytesFrom(0) = 1) Then
            e6.Text = opponentChar.ToString()
        End If
        If (bytesFrom(0) = 1) Then
            e7.Text = opponentChar.ToString()
        End If
        If (bytesFrom(0) = 1) Then
            e8.Text = opponentChar.ToString()
        End If

        ' col f
        If (bytesFrom(0) = 1) Then
            f1.Text = opponentChar.ToString()
        End If
        If (bytesFrom(0) = 1) Then
            f2.Text = opponentChar.ToString()
        End If
        If (bytesFrom(0) = 1) Then
            f3.Text = opponentChar.ToString()
        End If
        If (bytesFrom(0) = 1) Then
            f4.Text = opponentChar.ToString()
        End If
        If (bytesFrom(0) = 1) Then
            f5.Text = opponentChar.ToString()
        End If
        If (bytesFrom(0) = 1) Then
            f6.Text = opponentChar.ToString()
        End If
        If (bytesFrom(0) = 1) Then
            f7.Text = opponentChar.ToString()
        End If
        If (bytesFrom(0) = 1) Then
            f8.Text = opponentChar.ToString()
        End If

        ' col g
        If (bytesFrom(0) = 1) Then
            g1.Text = opponentChar.ToString()
        End If
        If (bytesFrom(0) = 1) Then
            g2.Text = opponentChar.ToString()
        End If
        If (bytesFrom(0) = 1) Then
            g3.Text = opponentChar.ToString()
        End If
        If (bytesFrom(0) = 1) Then
            g4.Text = opponentChar.ToString()
        End If
        If (bytesFrom(0) = 1) Then
            g5.Text = opponentChar.ToString()
        End If
        If (bytesFrom(0) = 1) Then
            g6.Text = opponentChar.ToString()
        End If
        If (bytesFrom(0) = 1) Then
            g7.Text = opponentChar.ToString()
        End If
        If (bytesFrom(0) = 1) Then
            g8.Text = opponentChar.ToString()
        End If

        ' col h
        If (bytesFrom(0) = 1) Then
            h1.Text = opponentChar.ToString()
        End If
        If (bytesFrom(0) = 1) Then
            h2.Text = opponentChar.ToString()
        End If
        If (bytesFrom(0) = 1) Then
            h3.Text = opponentChar.ToString()
        End If
        If (bytesFrom(0) = 1) Then
            h4.Text = opponentChar.ToString()
        End If
        If (bytesFrom(0) = 1) Then
            h5.Text = opponentChar.ToString()
        End If
        If (bytesFrom(0) = 1) Then
            h6.Text = opponentChar.ToString()
        End If
        If (bytesFrom(0) = 1) Then
            h7.Text = opponentChar.ToString()
        End If
        If (bytesFrom(0) = 1) Then
            h8.Text = opponentChar.ToString()
        End If

        ' col i
        If (bytesFrom(0) = 1) Then
            i1.Text = opponentChar.ToString()
        End If
        If (bytesFrom(0) = 1) Then
            i2.Text = opponentChar.ToString()
        End If
        If (bytesFrom(0) = 1) Then
            i3.Text = opponentChar.ToString()
        End If
        If (bytesFrom(0) = 1) Then
            i4.Text = opponentChar.ToString()
        End If
        If (bytesFrom(0) = 1) Then
            i5.Text = opponentChar.ToString()
        End If
        If (bytesFrom(0) = 1) Then
            i6.Text = opponentChar.ToString()
        End If
        If (bytesFrom(0) = 1) Then
            i7.Text = opponentChar.ToString()
        End If
        If (bytesFrom(0) = 1) Then

            i8.Text = opponentChar.ToString()
        End If

    End Sub

    Private Sub back_to_menu_Click(sender As Object, e As EventArgs) Handles back_to_menu.Click
        homepage.Show()
        Me.Hide()
    End Sub

    Private Sub gameboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load



        Dim tile_a As RoundButton = New RoundButton
        tile_a.Round(a1, 10)
        tile_a.Round(a2, 10)
        tile_a.Round(a3, 10)
        tile_a.Round(a4, 10)
        tile_a.Round(a5, 10)
        tile_a.Round(a6, 10)
        tile_a.Round(a7, 10)
        tile_a.Round(a8, 10)

        Dim tile_b As RoundButton = New RoundButton
        tile_b.Round(b1, 10)
        tile_b.Round(b2, 10)
        tile_b.Round(b3, 10)
        tile_b.Round(b4, 10)
        tile_b.Round(b5, 10)
        tile_b.Round(b6, 10)
        tile_b.Round(b7, 10)
        tile_b.Round(b8, 10)

        Dim tile_c As RoundButton = New RoundButton
        tile_c.Round(c1, 10)
        tile_c.Round(c2, 10)
        tile_c.Round(c3, 10)
        tile_c.Round(c4, 10)
        tile_c.Round(c5, 10)
        tile_c.Round(c6, 10)
        tile_c.Round(c7, 10)
        tile_c.Round(c8, 10)

        Dim tile_d As RoundButton = New RoundButton
        tile_d.Round(d1, 10)
        tile_d.Round(d2, 10)
        tile_d.Round(d3, 10)
        tile_d.Round(d4, 10)
        tile_d.Round(d5, 10)
        tile_d.Round(d6, 10)
        tile_d.Round(d7, 10)
        tile_d.Round(d8, 10)

        Dim tile_e As RoundButton = New RoundButton
        tile_e.Round(e1, 10)
        tile_e.Round(e2, 10)
        tile_e.Round(e3, 10)
        tile_e.Round(e4, 10)
        tile_e.Round(e5, 10)
        tile_e.Round(e6, 10)
        tile_e.Round(e7, 10)
        tile_e.Round(e8, 10)

        Dim tile_f As RoundButton = New RoundButton
        tile_f.Round(f1, 10)
        tile_f.Round(f2, 10)
        tile_f.Round(f3, 10)
        tile_f.Round(f4, 10)
        tile_f.Round(f5, 10)
        tile_f.Round(f6, 10)
        tile_f.Round(f7, 10)
        tile_f.Round(f8, 10)

        Dim tile_g As RoundButton = New RoundButton
        tile_g.Round(g1, 10)
        tile_g.Round(g2, 10)
        tile_g.Round(g3, 10)
        tile_g.Round(g4, 10)
        tile_g.Round(g5, 10)
        tile_g.Round(g6, 10)
        tile_g.Round(g7, 10)
        tile_g.Round(g8, 10)

        Dim tile_h As RoundButton = New RoundButton
        tile_h.Round(h1, 10)
        tile_h.Round(h2, 10)
        tile_h.Round(h3, 10)
        tile_h.Round(h4, 10)
        tile_h.Round(h5, 10)
        tile_h.Round(h6, 10)
        tile_h.Round(h7, 10)
        tile_h.Round(h8, 10)

        Dim tile_i As RoundButton = New RoundButton
        tile_i.Round(i1, 10)
        tile_i.Round(i2, 10)
        tile_i.Round(i3, 10)
        tile_i.Round(i4, 10)
        tile_i.Round(i5, 10)
        tile_i.Round(i6, 10)
        tile_i.Round(i7, 10)
        tile_i.Round(i8, 10)

        tile_a.Round(ready, 10)

    End Sub

    Private Sub a1_Click(sender As Object, e As EventArgs) Handles a1.Click
        Dim num() As Byte = {1}
        sock.Send(num)
        a1.Text = playerChar.ToString()
        BackgroundWorker1.RunWorkerAsync()
    End Sub

    Private Sub a2_Click(sender As Object, e As EventArgs) Handles a2.Click
        Dim num() As Byte = {2}
        sock.Send(num)
        a2.Text = playerChar.ToString()
        BackgroundWorker1.RunWorkerAsync()
    End Sub

    Private Sub a3_Click(sender As Object, e As EventArgs) Handles a3.Click
        Dim num() As Byte = {3}
        sock.Send(num)
        a3.Text = playerChar.ToString()
        BackgroundWorker1.RunWorkerAsync()
    End Sub

    Private Sub a4_Click(sender As Object, e As EventArgs) Handles a4.Click
        Dim num() As Byte = {4}
        sock.Send(num)
        a4.Text = playerChar.ToString()
        BackgroundWorker1.RunWorkerAsync()
    End Sub

    Private Sub a5_Click(sender As Object, e As EventArgs) Handles a5.Click
        Dim num() As Byte = {5}
        sock.Send(num)
        a5.Text = playerChar.ToString()
        BackgroundWorker1.RunWorkerAsync()
    End Sub

    Private Sub a6_Click(sender As Object, e As EventArgs) Handles a6.Click
        Dim num() As Byte = {6}
        sock.Send(num)
        a6.Text = playerChar.ToString()
        BackgroundWorker1.RunWorkerAsync()
    End Sub

    Private Sub a7_Click(sender As Object, e As EventArgs) Handles a7.Click
        Dim num() As Byte = {7}
        sock.Send(num)
        a7.Text = playerChar.ToString()
        BackgroundWorker1.RunWorkerAsync()
    End Sub

    Private Sub a8_Click(sender As Object, e As EventArgs) Handles a8.Click
        Dim num() As Byte = {8}
        sock.Send(num)
        a8.Text = playerChar.ToString()
        BackgroundWorker1.RunWorkerAsync()
    End Sub

    Private Sub b1_Click(sender As Object, e As EventArgs) Handles b1.Click
        Dim num() As Byte = {9}
        sock.Send(num)
        b1.Text = playerChar.ToString()
        BackgroundWorker1.RunWorkerAsync()
    End Sub

    Private Sub Button61_Click(sender As Object, e As EventArgs) Handles b2.Click
        Dim num() As Byte = {10}
        sock.Send(num)
        b2.Text = playerChar.ToString()
        BackgroundWorker1.RunWorkerAsync()
    End Sub

    Private Sub b3_Click(sender As Object, e As EventArgs) Handles b3.Click
        Dim num() As Byte = {11}
        sock.Send(num)
        b3.Text = playerChar.ToString()
        BackgroundWorker1.RunWorkerAsync()
    End Sub

    Private Sub b4_Click(sender As Object, e As EventArgs) Handles b4.Click
        Dim num() As Byte = {12}
        sock.Send(num)
        b4.Text = playerChar.ToString()
        BackgroundWorker1.RunWorkerAsync()
    End Sub

    Private Sub b5_Click(sender As Object, e As EventArgs) Handles b5.Click
        Dim num() As Byte = {13}
        sock.Send(num)
        b5.Text = playerChar.ToString()
        BackgroundWorker1.RunWorkerAsync()
    End Sub

    Private Sub b6_Click(sender As Object, e As EventArgs) Handles b6.Click
        Dim num() As Byte = {14}
        sock.Send(num)
        b6.Text = playerChar.ToString()
        BackgroundWorker1.RunWorkerAsync()
    End Sub

    Private Sub b7_Click(sender As Object, e As EventArgs) Handles b7.Click
        Dim num() As Byte = {15}
        sock.Send(num)
        b7.Text = playerChar.ToString()
        BackgroundWorker1.RunWorkerAsync()
    End Sub

    Private Sub b8_Click(sender As Object, e As EventArgs) Handles b8.Click
        Dim num() As Byte = {16}
        sock.Send(num)
        b8.Text = playerChar.ToString()
        BackgroundWorker1.RunWorkerAsync()
    End Sub

    Private Sub c1_Click(sender As Object, e As EventArgs) Handles c1.Click
        Dim num() As Byte = {17}
        sock.Send(num)
        c1.Text = playerChar.ToString()
        BackgroundWorker1.RunWorkerAsync()
    End Sub

    Private Sub c2_Click(sender As Object, e As EventArgs) Handles c2.Click
        Dim num() As Byte = {18}
        sock.Send(num)
        c2.Text = playerChar.ToString()
        BackgroundWorker1.RunWorkerAsync()
    End Sub

    Private Sub c3_Click(sender As Object, e As EventArgs) Handles c3.Click
        Dim num() As Byte = {19}
        sock.Send(num)
        c3.Text = playerChar.ToString()
        BackgroundWorker1.RunWorkerAsync()
    End Sub

    Private Sub c4_Click(sender As Object, e As EventArgs) Handles c4.Click
        Dim num() As Byte = {20}
        sock.Send(num)
        c4.Text = playerChar.ToString()
        BackgroundWorker1.RunWorkerAsync()
    End Sub

    Private Sub c5_Click(sender As Object, e As EventArgs) Handles c5.Click
        Dim num() As Byte = {21}
        sock.Send(num)
        c5.Text = playerChar.ToString()
        BackgroundWorker1.RunWorkerAsync()
    End Sub

    Private Sub c6_Click(sender As Object, e As EventArgs) Handles c6.Click
        Dim num() As Byte = {22}
        sock.Send(num)
        c6.Text = playerChar.ToString()
        BackgroundWorker1.RunWorkerAsync()
    End Sub

    Private Sub c7_Click(sender As Object, e As EventArgs) Handles c7.Click
        Dim num() As Byte = {23}
        sock.Send(num)
        c7.Text = playerChar.ToString()
        BackgroundWorker1.RunWorkerAsync()
    End Sub

    Private Sub c8_Click(sender As Object, e As EventArgs) Handles c8.Click
        Dim num() As Byte = {24}
        sock.Send(num)
        c8.Text = playerChar.ToString()
        BackgroundWorker1.RunWorkerAsync()
    End Sub

    Private Sub d1_Click(sender As Object, e As EventArgs) Handles d1.Click
        Dim num() As Byte = {25}
        sock.Send(num)
        d1.Text = playerChar.ToString()
        BackgroundWorker1.RunWorkerAsync()
    End Sub

    Private Sub d2_Click(sender As Object, e As EventArgs) Handles d2.Click
        Dim num() As Byte = {26}
        sock.Send(num)
        d2.Text = playerChar.ToString()
        BackgroundWorker1.RunWorkerAsync()
    End Sub

    Private Sub d3_Click(sender As Object, e As EventArgs) Handles d3.Click
        Dim num() As Byte = {27}
        sock.Send(num)
        d3.Text = playerChar.ToString()
        BackgroundWorker1.RunWorkerAsync()
    End Sub

    Private Sub d4_Click(sender As Object, e As EventArgs) Handles d4.Click
        Dim num() As Byte = {28}
        sock.Send(num)
        d4.Text = playerChar.ToString()
        BackgroundWorker1.RunWorkerAsync()
    End Sub

    Private Sub d5_Click(sender As Object, e As EventArgs) Handles d5.Click
        Dim num() As Byte = {29}
        sock.Send(num)
        d5.Text = playerChar.ToString()
        BackgroundWorker1.RunWorkerAsync()
    End Sub

    Private Sub d6_Click(sender As Object, e As EventArgs) Handles d6.Click
        Dim num() As Byte = {30}
        sock.Send(num)
        d6.Text = playerChar.ToString()
        BackgroundWorker1.RunWorkerAsync()
    End Sub

    Private Sub d7_Click(sender As Object, e As EventArgs) Handles d7.Click
        Dim num() As Byte = {31}
        sock.Send(num)
        d7.Text = playerChar.ToString()
        BackgroundWorker1.RunWorkerAsync()
    End Sub

    Private Sub d8_Click(sender As Object, e As EventArgs) Handles d8.Click
        Dim num() As Byte = {32}
        sock.Send(num)
        d8.Text = playerChar.ToString()
        BackgroundWorker1.RunWorkerAsync()
    End Sub

    Private Sub e1_Click(sender As Object, e As EventArgs) Handles e1.Click
        Dim num() As Byte = {33}
        sock.Send(num)
        e1.Text = playerChar.ToString()
        BackgroundWorker1.RunWorkerAsync()
    End Sub

    Private Sub e2_Click(sender As Object, e As EventArgs) Handles e2.Click
        Dim num() As Byte = {34}
        sock.Send(num)
        e2.Text = playerChar.ToString()
        BackgroundWorker1.RunWorkerAsync()
    End Sub

    Private Sub e3_Click(sender As Object, e As EventArgs) Handles e3.Click
        Dim num() As Byte = {35}
        sock.Send(num)
        e3.Text = playerChar.ToString()
        BackgroundWorker1.RunWorkerAsync()
    End Sub

    Private Sub e4_Click(sender As Object, e As EventArgs) Handles e4.Click
        Dim num() As Byte = {36}
        sock.Send(num)
        e4.Text = playerChar.ToString()
        BackgroundWorker1.RunWorkerAsync()
    End Sub

    Private Sub e5_Click(sender As Object, e As EventArgs) Handles e5.Click
        Dim num() As Byte = {37}
        sock.Send(num)
        e5.Text = playerChar.ToString()
        BackgroundWorker1.RunWorkerAsync()
    End Sub

    Private Sub e6_Click(sender As Object, e As EventArgs) Handles e6.Click
        Dim num() As Byte = {38}
        sock.Send(num)
        e6.Text = playerChar.ToString()
        BackgroundWorker1.RunWorkerAsync()
    End Sub

    Private Sub e7_Click(sender As Object, e As EventArgs) Handles e7.Click
        Dim num() As Byte = {39}
        sock.Send(num)
        e7.Text = playerChar.ToString()
        BackgroundWorker1.RunWorkerAsync()
    End Sub

    Private Sub e8_Click(sender As Object, e As EventArgs) Handles e8.Click
        Dim num() As Byte = {40}
        sock.Send(num)
        e8.Text = playerChar.ToString()
        BackgroundWorker1.RunWorkerAsync()
    End Sub

    Private Sub f1_Click(sender As Object, e As EventArgs) Handles f1.Click
        Dim num() As Byte = {41}
        sock.Send(num)
        f1.Text = playerChar.ToString()
        BackgroundWorker1.RunWorkerAsync()
    End Sub

    Private Sub f2_Click(sender As Object, e As EventArgs) Handles f2.Click
        Dim num() As Byte = {42}
        sock.Send(num)
        f2.Text = playerChar.ToString()
        BackgroundWorker1.RunWorkerAsync()
    End Sub

    Private Sub f3_Click(sender As Object, e As EventArgs) Handles f3.Click
        Dim num() As Byte = {43}
        sock.Send(num)
        f3.Text = playerChar.ToString()
        BackgroundWorker1.RunWorkerAsync()
    End Sub

    Private Sub f4_Click(sender As Object, e As EventArgs) Handles f4.Click
        Dim num() As Byte = {44}
        sock.Send(num)
        f4.Text = playerChar.ToString()
        BackgroundWorker1.RunWorkerAsync()
    End Sub

    Private Sub f5_Click(sender As Object, e As EventArgs) Handles f5.Click
        Dim num() As Byte = {45}
        sock.Send(num)
        f5.Text = playerChar.ToString()
        BackgroundWorker1.RunWorkerAsync()
    End Sub

    Private Sub f6_Click(sender As Object, e As EventArgs) Handles f6.Click
        Dim num() As Byte = {46}
        sock.Send(num)
        f6.Text = playerChar.ToString()
        BackgroundWorker1.RunWorkerAsync()
    End Sub

    Private Sub f7_Click(sender As Object, e As EventArgs) Handles f7.Click
        Dim num() As Byte = {47}
        sock.Send(num)
        f7.Text = playerChar.ToString()
        BackgroundWorker1.RunWorkerAsync()
    End Sub

    Private Sub f8_Click(sender As Object, e As EventArgs) Handles f8.Click
        Dim num() As Byte = {48}
        sock.Send(num)
        f8.Text = playerChar.ToString()
        BackgroundWorker1.RunWorkerAsync()
    End Sub

    Private Sub g1_Click(sender As Object, e As EventArgs) Handles g1.Click
        Dim num() As Byte = {49}
        sock.Send(num)
        g1.Text = playerChar.ToString()
        BackgroundWorker1.RunWorkerAsync()
    End Sub

    Private Sub g2_Click(sender As Object, e As EventArgs) Handles g2.Click
        Dim num() As Byte = {50}
        sock.Send(num)
        g2.Text = playerChar.ToString()
        BackgroundWorker1.RunWorkerAsync()
    End Sub

    Private Sub g3_Click(sender As Object, e As EventArgs) Handles g3.Click
        Dim num() As Byte = {51}
        sock.Send(num)
        g3.Text = playerChar.ToString()
        BackgroundWorker1.RunWorkerAsync()
    End Sub

    Private Sub g4_Click(sender As Object, e As EventArgs) Handles g4.Click
        Dim num() As Byte = {52}
        sock.Send(num)
        g4.Text = playerChar.ToString()
        BackgroundWorker1.RunWorkerAsync()
    End Sub

    Private Sub g5_Click(sender As Object, e As EventArgs) Handles g5.Click
        Dim num() As Byte = {53}
        sock.Send(num)
        g5.Text = playerChar.ToString()
        BackgroundWorker1.RunWorkerAsync()
    End Sub

    Private Sub g6_Click(sender As Object, e As EventArgs) Handles g6.Click
        Dim num() As Byte = {54}
        sock.Send(num)
        g6.Text = playerChar.ToString()
        BackgroundWorker1.RunWorkerAsync()
    End Sub

    Private Sub g7_Click(sender As Object, e As EventArgs) Handles g7.Click
        Dim num() As Byte = {55}
        sock.Send(num)
        g7.Text = playerChar.ToString()
        BackgroundWorker1.RunWorkerAsync()
    End Sub

    Private Sub g8_Click(sender As Object, e As EventArgs) Handles g8.Click
        Dim num() As Byte = {56}
        sock.Send(num)
        g8.Text = playerChar.ToString()
        BackgroundWorker1.RunWorkerAsync()
    End Sub

    Private Sub h1_Click(sender As Object, e As EventArgs) Handles h1.Click
        Dim num() As Byte = {57}
        sock.Send(num)
        h1.Text = playerChar.ToString()
        BackgroundWorker1.RunWorkerAsync()
    End Sub

    Private Sub h2_Click(sender As Object, e As EventArgs) Handles h2.Click
        Dim num() As Byte = {58}
        sock.Send(num)
        h2.Text = playerChar.ToString()
        BackgroundWorker1.RunWorkerAsync()
    End Sub

    Private Sub h3_Click(sender As Object, e As EventArgs) Handles h3.Click
        Dim num() As Byte = {59}
        sock.Send(num)
        h3.Text = playerChar.ToString()
        BackgroundWorker1.RunWorkerAsync()
    End Sub

    Private Sub h4_Click(sender As Object, e As EventArgs) Handles h4.Click
        Dim num() As Byte = {60}
        sock.Send(num)
        h4.Text = playerChar.ToString()
        BackgroundWorker1.RunWorkerAsync()
    End Sub

    Private Sub h5_Click(sender As Object, e As EventArgs) Handles h5.Click
        Dim num() As Byte = {61}
        sock.Send(num)
        h5.Text = playerChar.ToString()
        BackgroundWorker1.RunWorkerAsync()
    End Sub

    Private Sub h6_Click(sender As Object, e As EventArgs) Handles h6.Click
        Dim num() As Byte = {62}
        sock.Send(num)
        h6.Text = playerChar.ToString()
        BackgroundWorker1.RunWorkerAsync()
    End Sub

    Private Sub h7_Click(sender As Object, e As EventArgs) Handles h7.Click
        Dim num() As Byte = {63}
        sock.Send(num)
        h7.Text = playerChar.ToString()
        BackgroundWorker1.RunWorkerAsync()
    End Sub

    Private Sub h8_Click(sender As Object, e As EventArgs) Handles h8.Click
        Dim num() As Byte = {64}
        sock.Send(num)
        h8.Text = playerChar.ToString()
        BackgroundWorker1.RunWorkerAsync()
    End Sub

    Private Sub i1_Click(sender As Object, e As EventArgs) Handles i1.Click
        Dim num() As Byte = {65}
        sock.Send(num)
        i1.Text = playerChar.ToString()
        BackgroundWorker1.RunWorkerAsync()
    End Sub

    Private Sub i2_Click(sender As Object, e As EventArgs) Handles i2.Click
        Dim num() As Byte = {66}
        sock.Send(num)
        i2.Text = playerChar.ToString()
        BackgroundWorker1.RunWorkerAsync()
    End Sub

    Private Sub i3_Click(sender As Object, e As EventArgs) Handles i3.Click
        Dim num() As Byte = {67}
        sock.Send(num)
        i3.Text = playerChar.ToString()
        BackgroundWorker1.RunWorkerAsync()
    End Sub

    Private Sub i4_Click(sender As Object, e As EventArgs) Handles i4.Click
        Dim num() As Byte = {68}
        sock.Send(num)
        i4.Text = playerChar.ToString()
        BackgroundWorker1.RunWorkerAsync()
    End Sub

    Private Sub i5_Click(sender As Object, e As EventArgs) Handles i5.Click
        Dim num() As Byte = {69}
        sock.Send(num)
        i5.Text = playerChar.ToString()
        BackgroundWorker1.RunWorkerAsync()
    End Sub

    Private Sub i6_Click(sender As Object, e As EventArgs) Handles i6.Click
        Dim num() As Byte = {70}
        sock.Send(num)
        i6.Text = playerChar.ToString()
        BackgroundWorker1.RunWorkerAsync()
    End Sub

    Private Sub i7_Click(sender As Object, e As EventArgs) Handles i7.Click
        Dim num() As Byte = {71}
        sock.Send(num)
        i7.Text = playerChar.ToString()
        BackgroundWorker1.RunWorkerAsync()
    End Sub

    Private Sub i8_Click(sender As Object, e As EventArgs) Handles i8.Click
        Dim num() As Byte = {72}
        sock.Send(num)
        i8.Text = playerChar.ToString()
        BackgroundWorker1.RunWorkerAsync()
    End Sub

    Private Sub gameboard_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing

        BackgroundWorker1.WorkerSupportsCancellation = True
        BackgroundWorker1.CancelAsync()

        If serverSocket IsNot "" Then
            serverSocket.Stop()
        End If

    End Sub

    Private Sub ready_Click(sender As Object, e As EventArgs) Handles ready.Click

    End Sub

    Private Sub opponentName_Click(sender As Object, e As EventArgs) Handles opponentName.Click

    End Sub
End Class