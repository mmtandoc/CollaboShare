Public Class ResizableCheckBox
    Inherits CheckBox

    Public Property BoxSize As New Size(30, 30)

    Public Overrides Property AutoSize As Boolean
        Get
            Return MyBase.AutoSize
        End Get
        Set
            MyBase.AutoSize = False
        End Set
    End Property
    Protected Overrides Sub OnPaint(e As PaintEventArgs)
        MyBase.OnPaint(e)
        Dim rect As Rectangle = New Rectangle(New Point(0, 1), BoxSize)
        ControlPaint.DrawCheckBox(e.Graphics, rect, If(Me.Checked, ButtonState.Checked, ButtonState.Normal))
    End Sub

End Class

