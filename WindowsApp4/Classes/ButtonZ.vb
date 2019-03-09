Imports System
Imports System.Collections.Generic
Imports System.Text
Imports System.Drawing
Imports System.Data
Imports System.Windows.Forms

Namespace WindowsApp4.ButtonZ

    Public Class ButtonZ
        Inherits System.Windows.Forms.Button

        Private clr1 As Color

        Private color As Color = Color.Teal

        Private m_hovercolor As Color = Color.FromArgb(0, 0, 140)

        Private clickcolor As Color = Color.FromArgb(160, 180, 200)

        Private textX As Integer = 6

        Private textY As Integer = -20

        Public Property DisplayText As String
            Get
                Return Me.Text1
            End Get
            Set
                Me.Text1 = Value
                Invalidate()
            End Set
        End Property

        Public Property BZBackColor As Color
            Get
                Return Me.color
            End Get
            Set
                Me.color = Value
                Invalidate()
            End Set
        End Property

        Public Property MouseHoverColor As Color
            Get
                Return Me.m_hovercolor
            End Get
            Set
                Me.m_hovercolor = Value
                Invalidate()
            End Set
        End Property

        Public Property MouseClickColor1 As Color
            Get
                Return Me.clickcolor
            End Get
            Set
                Me.clickcolor = Value
                Invalidate()
            End Set
        End Property

        Public Property TextLocation_X As Integer
            Get
                Return Me.textX
            End Get
            Set
                Me.textX = Value
                Invalidate()
            End Set
        End Property

        Public Property TextLocation_Y As Integer
            Get
                Return Me.textY
            End Get
            Set
                Me.textY = Value
                Invalidate()
            End Set
        End Property

        Public Property Text1 As String
            Get
                Return Text2
            End Get
            Set(value As String)
                Text2 = value
            End Set
        End Property

        Public Property Text2 As String
        Public Sub New()
            MyBase.New
            Me.Size = New System.Drawing.Size(31, 24)
            Me.ForeColor = Color.White
            Me.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.Font = New System.Drawing.Font("Microsoft YaHei UI", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Text1 = "_"
            Me.Text1 = Me.Text1
        End Sub

        'method mouse enter
        Protected Overrides Sub OnMouseEnter(ByVal e As EventArgs)
            MyBase.OnMouseEnter(e)
            Me.clr1 = Me.color
            Me.color = Me.m_hovercolor
        End Sub

        'method mouse leave
        Protected Overrides Sub OnMouseLeave(ByVal e As EventArgs)
            MyBase.OnMouseLeave(e)
            Me.color = Me.clr1
        End Sub

        Protected Overrides Sub OnMouseDown(ByVal mevent As MouseEventArgs)
            MyBase.OnMouseDown(mevent)
            Me.color = Me.clickcolor
        End Sub

        Protected Overrides Sub OnMouseUp(ByVal mevent As MouseEventArgs)
            MyBase.OnMouseUp(mevent)
            Me.color = Me.clr1
        End Sub

        Protected Overrides Sub OnPaint(ByVal pe As PaintEventArgs)
            MyBase.OnPaint(pe)
            Me.Text1 = Me.Text1
            If ((Me.textX = 100) _
                        AndAlso (Me.textY = 25)) Then
                Me.textX = ((Me.Width / 3) _
                            + 10)
                Me.textY = ((Me.Height / 2) _
                            - 1)
            End If

            Dim p As Point = New Point(Me.textX, Me.textY)
            pe.Graphics.FillRectangle(New SolidBrush(Me.color), ClientRectangle)
            pe.Graphics.DrawString(Me.Text1, Me.Font, New SolidBrush(Me.ForeColor), p)
        End Sub
    End Class
End Namespace
