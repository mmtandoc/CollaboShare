Namespace UI.Views
    Public Class EditChoreView
        Public Event Confirmed As EventHandler
        Public Event Cancelled As EventHandler
        Public Property Chore As Chore
        Public Sub New(chore As Chore)
            Me.Chore = chore
            ' This call is required by the designer.
            InitializeComponent()

            ' Add any initialization after the InitializeComponent() call.
            FillFields(chore)
        End Sub

        Public Sub FillFields(chore As Chore)
            NameTextBox.Text = chore.Name
            DescriptionTextBox.Text = chore.Description
            RecurrenceControl1.SetRecurrence(chore.Frequency)
        End Sub

        Private Sub CancelButton_Click(sender As Object, e As EventArgs) Handles CancelButton.Click
            RaiseEvent Cancelled(Me, EventArgs.Empty)
        End Sub

        Private Sub ConfirmButton_Click(sender As Object, e As EventArgs) Handles ConfirmButton.Click
            RaiseEvent Confirmed(Me, EventArgs.Empty)
        End Sub
    End Class
End NameSpace