Public Class gameboard
    Private Sub Button61_Click(sender As Object, e As EventArgs) Handles b2.Click

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

    End Sub
End Class