Namespace UI.Views
    Public Class CreateChoreView
        Public Event Confirmed As EventHandler
        Public Event Cancelled As EventHandler
        Public Function CreateChore()
            Return New Chore(NameTextBox.Text, DescriptionTextBox.Text, RecurrenceControl1.GetRecurrence, New TimeSpan(0, Integer.Parse(DurationMaskedTextBox.Text), 0), RecurrenceControl1.DueDateDateTimePicker.Value, PeopleRequiredNumericUpDown.Value)
        End Function

        Private Sub CancelButton_Click(sender As Object, e As EventArgs) Handles CancelButton.Click
            RaiseEvent Cancelled(Me, EventArgs.Empty)
        End Sub

        Private Sub ConfirmButton_Click(sender As Object, e As EventArgs) Handles ConfirmButton.Click
            RaiseEvent Confirmed(Me, EventArgs.Empty)
        End Sub
    End Class
End NameSpace