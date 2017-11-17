Namespace UI.Controls
    Public Class HousemateItemControl
        Public Event View As EventHandler
        Public Event Remove As EventHandler

        Public Property Housemate As Housemate
        Public Sub New(ByRef housemate As Housemate)
            Me.Housemate = housemate
            ' This call is required by the designer.
            InitializeComponent()

            ' Add any initialization after the InitializeComponent() call.
            Me.HousemateButton.Text = housemate.Name
        End Sub

        Private Sub OverflowButton_Click(sender As Object, e As EventArgs) Handles OverflowButton.Click
            Dim btnSender As Button = sender
            Dim ptLowerLeft = New Point(0, btnSender.Height)
            ptLowerLeft = btnSender.PointToScreen(ptLowerLeft)
            ContextMenuStrip1.Show(ptLowerLeft)
        End Sub

        Private Sub HousemateButton_Click(sender As Object, e As EventArgs) Handles HousemateButton.Click
            RaiseEvent View(Me, EventArgs.Empty)
        End Sub

        Private Sub RemoveToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RemoveToolStripMenuItem.Click
            RaiseEvent Remove(Me, EventArgs.Empty)
        End Sub
    End Class
End Namespace