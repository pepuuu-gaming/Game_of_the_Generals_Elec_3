Public Class gameboard
    Private Sub Button61_Click(sender As Object, e As EventArgs) Handles b2.Click

    End Sub

    Private Sub back_to_menu_Click(sender As Object, e As EventArgs) Handles back_to_menu.Click
        homepage.Show()
        Me.Hide()
    End Sub

    Private Sub gameboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim tile_a1 As RoundButton = New RoundButton
        tile_a1.Round(a1, 10)

        Dim tile_a2 As RoundButton = New RoundButton
        tile_a2.Round(a2, 10)

        Dim tile_a3 As RoundButton = New RoundButton
        tile_a3.Round(a3, 10)

        Dim tile_a4 As RoundButton = New RoundButton
        tile_a4.Round(a4, 10)

        Dim tile_a5 As RoundButton = New RoundButton
        tile_a5.Round(a5, 10)

        Dim tile_a6 As RoundButton = New RoundButton
        tile_a6.Round(a6, 10)

        Dim tile_a7 As RoundButton = New RoundButton
        tile_a7.Round(a7, 10)

        Dim tile_a8 As RoundButton = New RoundButton
        tile_a8.Round(a8, 10)

        Dim tile_b1 As RoundButton = New RoundButton
        tile_b1.Round(b1, 10)

        Dim tile_b2 As RoundButton = New RoundButton
        tile_b2.Round(b2, 10)

        Dim tile_b3 As RoundButton = New RoundButton
        tile_b3.Round(b3, 10)

        Dim tile_b4 As RoundButton = New RoundButton
        tile_b4.Round(b4, 10)

        Dim tile_b5 As RoundButton = New RoundButton
        tile_b5.Round(b5, 10)

        Dim tile_b6 As RoundButton = New RoundButton
        tile_b6.Round(b6, 10)

        Dim tile_b7 As RoundButton = New RoundButton
        tile_b7.Round(b7, 10)

        Dim tile_b8 As RoundButton = New RoundButton
        tile_b8.Round(b8, 10)

        Dim tile_c1 As RoundButton = New RoundButton
        tile_c1.Round(c1, 10)

        Dim tile_c2 As RoundButton = New RoundButton
        tile_c2.Round(c2, 10)

        Dim tile_c3 As RoundButton = New RoundButton
        tile_c3.Round(c3, 10)

        Dim tile_c4 As RoundButton = New RoundButton
        tile_c4.Round(c4, 10)

        Dim tile_c5 As RoundButton = New RoundButton
        tile_c5.Round(c5, 10)

        Dim tile_c6 As RoundButton = New RoundButton
        tile_c6.Round(c6, 10)

        Dim tile_c7 As RoundButton = New RoundButton
        tile_c7.Round(c7, 10)

        Dim tile_c8 As RoundButton = New RoundButton
        tile_c8.Round(c8, 10)

        Dim tile_d1 As RoundButton = New RoundButton
        tile_d1.Round(d1, 10)

        Dim tile_d2 As RoundButton = New RoundButton
        tile_d2.Round(d2, 10)

        Dim tile_d3 As RoundButton = New RoundButton
        tile_d3.Round(d3, 10)

        Dim tile_d4 As RoundButton = New RoundButton
        tile_d4.Round(d4, 10)

        Dim tile_d5 As RoundButton = New RoundButton
        tile_d5.Round(d5, 10)

        Dim tile_d6 As RoundButton = New RoundButton
        tile_d6.Round(d6, 10)

        Dim tile_d7 As RoundButton = New RoundButton
        tile_d7.Round(d7, 10)

        Dim tile_d8 As RoundButton = New RoundButton
        tile_d8.Round(d8, 10)

        Dim tile_e1 As RoundButton = New RoundButton
        tile_e1.Round(e1, 10)

        Dim tile_e2 As RoundButton = New RoundButton
        tile_e2.Round(e2, 10)

        Dim tile_e3 As RoundButton = New RoundButton
        tile_e3.Round(e3, 10)

        Dim tile_e4 As RoundButton = New RoundButton
        tile_e4.Round(e4, 10)

        Dim tile_e5 As RoundButton = New RoundButton
        tile_e5.Round(e5, 10)

        Dim tile_e6 As RoundButton = New RoundButton
        tile_e6.Round(e6, 10)

        Dim tile_e7 As RoundButton = New RoundButton
        tile_e7.Round(e7, 10)

        Dim tile_e8 As RoundButton = New RoundButton
        tile_e8.Round(e8, 10)

        Dim tile_f1 As RoundButton = New RoundButton
        tile_f1.Round(f1, 10)

        Dim tile_f2 As RoundButton = New RoundButton
        tile_f2.Round(f2, 10)

        Dim tile_f3 As RoundButton = New RoundButton
        tile_f3.Round(f3, 10)

        Dim tile_f4 As RoundButton = New RoundButton
        tile_f4.Round(f4, 10)

        Dim tile_f5 As RoundButton = New RoundButton
        tile_f5.Round(f5, 10)

        Dim tile_f6 As RoundButton = New RoundButton
        tile_f6.Round(f6, 10)

        Dim tile_f7 As RoundButton = New RoundButton
        tile_f7.Round(f7, 10)

        Dim tile_f8 As RoundButton = New RoundButton
        tile_f8.Round(f8, 10)

        Dim tile_g1 As RoundButton = New RoundButton
        tile_g1.Round(g1, 10)

        Dim tile_g2 As RoundButton = New RoundButton
        tile_g2.Round(g2, 10)

        Dim tile_g3 As RoundButton = New RoundButton
        tile_g3.Round(g3, 10)

        Dim tile_g4 As RoundButton = New RoundButton
        tile_g4.Round(g4, 10)

        Dim tile_g5 As RoundButton = New RoundButton
        tile_g5.Round(g5, 10)

        Dim tile_g6 As RoundButton = New RoundButton
        tile_g6.Round(g6, 10)

        Dim tile_g7 As RoundButton = New RoundButton
        tile_g7.Round(g7, 10)

        Dim tile_g8 As RoundButton = New RoundButton
        tile_g8.Round(g8, 10)

        Dim tile_h1 As RoundButton = New RoundButton
        tile_h1.Round(h1, 10)

        Dim tile_h2 As RoundButton = New RoundButton
        tile_h2.Round(h2, 10)

        Dim tile_h3 As RoundButton = New RoundButton
        tile_h3.Round(h3, 10)

        Dim tile_h4 As RoundButton = New RoundButton
        tile_h4.Round(h4, 10)

        Dim tile_h5 As RoundButton = New RoundButton
        tile_h5.Round(h5, 10)

        Dim tile_h6 As RoundButton = New RoundButton
        tile_h6.Round(h6, 10)

        Dim tile_h7 As RoundButton = New RoundButton
        tile_h7.Round(h7, 10)

        Dim tile_h8 As RoundButton = New RoundButton
        tile_h8.Round(h8, 10)

        Dim tile_i1 As RoundButton = New RoundButton
        tile_i1.Round(i1, 10)

        Dim tile_i2 As RoundButton = New RoundButton
        tile_i2.Round(i2, 10)

        Dim tile_i3 As RoundButton = New RoundButton
        tile_i3.Round(i3, 10)

        Dim tile_i4 As RoundButton = New RoundButton
        tile_i4.Round(i4, 10)

        Dim tile_i5 As RoundButton = New RoundButton
        tile_i5.Round(i5, 10)

        Dim tile_i6 As RoundButton = New RoundButton
        tile_i6.Round(i6, 10)

        Dim tile_i7 As RoundButton = New RoundButton
        tile_i7.Round(i7, 10)

        Dim tile_i8 As RoundButton = New RoundButton
        tile_i8.Round(i8, 10)

    End Sub
End Class