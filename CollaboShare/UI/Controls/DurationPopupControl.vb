Namespace UI.Controls
    Public Class DurationPopupControl
        Public Property Housemate As Housemate
        Public Property Chore As Chore

        Public Property Accepted As Boolean = False

        Public Sub New(ByRef housemate As Housemate, chore As Chore)
            Me.Housemate = housemate
            Me.Chore = chore
            ' This call is required by the designer.
            InitializeComponent()

            ' Add any initialization after the InitializeComponent() call.

        End Sub

        Private Sub CancelButton_Click(sender As Object, e As EventArgs) Handles CancelButton.Click
            Me.Parent.Controls.Remove(Me)
        End Sub

        Private Sub AcceptButton_Click(sender As Object, e As EventArgs) Handles AcceptButton.Click
            If Chore.Durations.ContainsKey(Housemate.Name) Then
                Chore.Durations(Housemate.Name) = New TimeSpan(0, 0, DurationNumericUpDown.Value, 0)
            Else
                Chore.Durations.Add(Housemate.Name, New TimeSpan(0, 0, DurationNumericUpDown.Value, 0))
            End If
            Me.Parent.Controls.Remove(Me)
        End Sub
    End Class
End Namespace