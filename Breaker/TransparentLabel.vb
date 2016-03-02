Public Class TransparentLabel
    Inherits Label

    Private _transparency As Int32 = 255

    Protected Overrides Sub OnPaintBackground(pevent As PaintEventArgs)
        MyBase.OnPaintBackground(pevent)
        Using b As New SolidBrush(Color.FromArgb(Transparency, BackColor))
            If Image IsNot Nothing Then
                pevent.Graphics.DrawImage(Image, 0, 0)
                pevent.Graphics.FillRectangle(b, Me.ClientRectangle)
            Else
                pevent.Graphics.FillRectangle(b, Me.ClientRectangle)
            End If
        End Using
    End Sub

    Protected Overrides Sub OnPaint(e As PaintEventArgs)
        MyBase.OnPaint(e)
        MyBase.OnPaintBackground(e)
        e.Graphics.CompositingMode = Drawing2D.CompositingMode.SourceOver
        e.Graphics.CompositingQuality = Drawing2D.CompositingQuality.GammaCorrected
        e.Graphics.SmoothingMode = Drawing2D.SmoothingMode.AntiAlias
    End Sub

    Public Property Transparency As Int32
        Get
            Return _transparency
        End Get
        Set(value As Int32)
            If value < 0 OrElse value > 255 Then
                Throw New ArgumentException("Transparency must be an integer value from 0 to 255")
            Else
                _transparency = value
            End If
            Me.Refresh()
        End Set
    End Property

End Class
