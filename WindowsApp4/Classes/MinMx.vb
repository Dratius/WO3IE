Imports System
Imports System.Collections.Generic
Imports System.Text
Imports System.Drawing
Imports System.Data
Imports System.Windows.Forms

Namespace CustomWindowsForm
    Public Class MinMaxButton
        Inherits System.Windows.Forms.Button

        Private clr1 As Color
        Private color As Color = Color.Gray
        Private m_hovercolor As Color = Color.FromArgb(180, 200, 240)
        Private clickcolor As Color = Color.FromArgb(160, 180, 200)
        Private textX As Integer = 6
        Private textY As Integer = -20

        Public Enum CustomFormState
            Normal
            Maximize
        End Enum

        Private _customFormState As CustomFormState

        Public Property CFormState As CustomFormState
            Get
                Return _customFormState
            End Get
            Set(ByVal value As CustomFormState)
                _customFormState = value
                Invalidate()
            End Set
        End Property

        Public Property DisplayText As String
            Get
                Return Text1
            End Get
            Set(ByVal value As String)
                Text1 = value
                Invalidate()
            End Set
        End Property

        Public Property BZBackColor As Color
            Get
                Return color
            End Get
            Set(ByVal value As Color)
                color = value
                Invalidate()
            End Set
        End Property

        Public Property MouseHoverColor As Color
            Get
                Return m_hovercolor
            End Get
            Set(ByVal value As Color)
                m_hovercolor = value
                Invalidate()
            End Set
        End Property

        Public Property MouseClickColor1 As Color
            Get
                Return clickcolor
            End Get
            Set(ByVal value As Color)
                clickcolor = value
                Invalidate()
            End Set
        End Property

        Public Property TextLocation_X As Integer
            Get
                Return textX
            End Get
            Set(ByVal value As Integer)
                textX = value
                Invalidate()
            End Set
        End Property

        Public Property TextLocation_Y As Integer
            Get
                Return textY
            End Get
            Set(ByVal value As Integer)
                textY = value
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
            Get
                Return Text3
            End Get
            Set(value As String)
                Text3 = value
            End Set
        End Property

        Public Property Text3 As String
        Public Sub New()
            Me.Size = New System.Drawing.Size(31, 24)
            Me.ForeColor = Color.White
            Me.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.Text1 = "_"
            Text1 = Me.Text1
        End Sub

        Protected Overrides Sub OnMouseEnter(ByVal e As EventArgs)
            MyBase.OnMouseEnter(e)
            clr1 = color
            color = m_hovercolor
        End Sub

        Protected Overrides Sub OnMouseLeave(ByVal e As EventArgs)
            MyBase.OnMouseLeave(e)
            color = clr1
        End Sub

        Protected Overrides Sub OnMouseDown(ByVal mevent As MouseEventArgs)
            MyBase.OnMouseDown(mevent)
            color = clickcolor
        End Sub

        Protected Overrides Sub OnMouseUp(ByVal mevent As MouseEventArgs)
            MyBase.OnMouseUp(mevent)
            color = clr1
        End Sub

        Protected Overrides Sub OnPaint(ByVal pe As PaintEventArgs)
            MyBase.OnPaint(pe)

            Select Case _customFormState
                Case CustomFormState.Normal
                    pe.Graphics.FillRectangle(New SolidBrush(color), ClientRectangle)

                    For i As Integer = 0 To 2 - 1
                        pe.Graphics.DrawRectangle(New Pen(Me.ForeColor), textX + i + 1, textY, 10, 10)
                        pe.Graphics.FillRectangle(New SolidBrush(Me.ForeColor), textX + 1, textY - 1, 12, 4)
                    Next

                Case CustomFormState.Maximize
                    pe.Graphics.FillRectangle(New SolidBrush(color), ClientRectangle)

                    For i As Integer = 0 To 2 - 1
                        pe.Graphics.DrawRectangle(New Pen(Me.ForeColor), textX + 5, textY, 8, 8)
                        pe.Graphics.FillRectangle(New SolidBrush(Me.ForeColor), textX + 5, textY - 1, 9, 4)
                        pe.Graphics.DrawRectangle(New Pen(Me.ForeColor), textX + 2, textY + 5, 8, 8)
                        pe.Graphics.FillRectangle(New SolidBrush(Me.ForeColor), textX + 2, textY + 4, 9, 4)
                    Next
            End Select
        End Sub
    End Class
End Namespace

