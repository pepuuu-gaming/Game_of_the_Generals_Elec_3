Public Class RoundButton
    Public Sub Round(button_name As Button, size As Integer)
        Dim button As New Drawing2D.GraphicsPath
        button.StartFigure()
        button.AddArc(New RectangleF(0, 0, size, size), 180, 90)
        button.AddLine(20, 0, button_name.Width - 20, 0)

        button.AddArc(New RectangleF(button_name.Width - size, 0, size, size), -90, 90)
        button.AddLine(button_name.Width, 20, button_name.Width, button_name.Height - size)

        button.AddArc(New RectangleF(button_name.Width - size, button_name.Height - size, size, size), 0, 90)
        button.AddLine(button_name.Width - size, button_name.Height, 20, button_name.Height)

        button.AddArc(New RectangleF(0, button_name.Height - size, size, size), 90, 90)

        button.CloseFigure()
        button_name.Region = New Region(button)
    End Sub
End Class

