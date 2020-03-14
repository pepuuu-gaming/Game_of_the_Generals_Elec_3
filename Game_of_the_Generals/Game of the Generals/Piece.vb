Public Class Piece

    Public Sub Setprivate(a As Button, r As Integer())
        a.BackgroundImage = My.Resources.private_2x
        a.BackgroundImageLayout = ImageLayout.Center
        a.BackColor = Color.FromArgb(r(0), r(1), r(1))
    End Sub

    Public Sub Setsergeant(a As Button, r As Integer())
        a.BackgroundImage = My.Resources.sergeant_2x
        a.BackgroundImageLayout = ImageLayout.Center
        a.BackColor = Color.FromArgb(r(0), r(1), r(1))
    End Sub

    Public Sub Setlieutenant_2nd(a As Button, r As Integer())
        a.BackgroundImage = My.Resources.lieutenant_2nd_2x
        a.BackgroundImageLayout = ImageLayout.Center
        a.BackColor = Color.FromArgb(r(0), r(1), r(1))
    End Sub

    Public Sub Setlieutenant_1st(a As Button, r As Integer())
        a.BackgroundImage = My.Resources.lieutenant_1st_2x
        a.BackgroundImageLayout = ImageLayout.Center
        a.BackColor = Color.FromArgb(r(0), r(1), r(1))
    End Sub

    Public Sub Setcaptain(a As Button, r As Integer())
        a.BackgroundImage = My.Resources.captain_2x
        a.BackgroundImageLayout = ImageLayout.Center
        a.BackColor = Color.FromArgb(r(0), r(1), r(1))
    End Sub

    Public Sub Setmajor(a As Button, r As Integer())
        a.BackgroundImage = My.Resources.major_2x
        a.BackgroundImageLayout = ImageLayout.Center
        a.BackColor = Color.FromArgb(r(0), r(1), r(1))
    End Sub

    Public Sub Setlieutenant_colonel(a As Button, r As Integer())
        a.BackgroundImage = My.Resources.lieutenant_colonel_2x
        a.BackgroundImageLayout = ImageLayout.Center
        a.BackColor = Color.FromArgb(r(0), r(1), r(1))
    End Sub

    Public Sub Setcolonel(a As Button, r As Integer())
        a.BackgroundImage = My.Resources.colonel_2x
        a.BackgroundImageLayout = ImageLayout.Center
        a.BackColor = Color.FromArgb(r(0), r(1), r(1))
    End Sub

    Public Sub Setbrigadier_general(a As Button, r As Integer())
        a.BackgroundImage = My.Resources.brigadier_general_2x
        a.BackgroundImageLayout = ImageLayout.Center
        a.BackColor = Color.FromArgb(r(0), r(1), r(1))
    End Sub

    Public Sub Setmajor_general(a As Button, r As Integer())
        a.BackgroundImage = My.Resources.major_general_2x
        a.BackgroundImageLayout = ImageLayout.Center
        a.BackColor = Color.FromArgb(r(0), r(1), r(1))
    End Sub

    Public Sub Setlieutenant_general(a As Button, r As Integer())
        a.BackgroundImage = My.Resources.lieutenant_general_2x
        a.BackgroundImageLayout = ImageLayout.Center
        a.BackColor = Color.FromArgb(r(0), r(1), r(1))
    End Sub

    Public Sub Setgeneral(a As Button, r As Integer())
        a.BackgroundImage = My.Resources.general_2x
        a.BackgroundImageLayout = ImageLayout.Center
        a.BackColor = Color.FromArgb(r(0), r(1), r(1))
    End Sub

    Public Sub Setgeneral_of_the_army(a As Button, r As Integer())
        a.BackgroundImage = My.Resources.general_of_the_army_2x
        a.BackgroundImageLayout = ImageLayout.Center
        a.BackColor = Color.FromArgb(r(0), r(1), r(1))
    End Sub

    Public Sub Setspy(a As Button, r As Integer())
        a.BackgroundImage = My.Resources.spy_2x
        a.BackgroundImageLayout = ImageLayout.Center
        a.BackColor = Color.FromArgb(r(0), r(1), r(1))
    End Sub

    Public Sub Setflag(a As Button, r As Integer())
        a.BackgroundImage = My.Resources.flag_2x
        a.BackgroundImageLayout = ImageLayout.Center
        a.BackColor = Color.FromArgb(r(0), r(1), r(1))
    End Sub
    Public Sub UnsetButtonImage(a As Button)
        a.BackgroundImage = Nothing
        a.BackColor = Nothing
    End Sub

End Class
