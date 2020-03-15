
Public Class Location


    Public Function LocationGet(a As Object) As Integer()
        Dim b(2) As Integer
        Dim c As Button = DirectCast(a, Button)
        b(0) = c.Location.X
        b(1) = c.Location.Y
        Return b
    End Function

    Public Sub SetLocation(a As Object, x As Integer, y As Integer)
        Dim c As Button = DirectCast(a, Button)

        c.Location = New Point(x, y)

    End Sub
End Class
