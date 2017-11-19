Namespace UI.Views
    Public Class CreateChoreView
        Public Event Confirmed As EventHandler
        Public Event Cancelled As EventHandler
        Public ReadOnly Property Phone() As PhoneForm
            Get
                Return FindForm()
            End Get
        End Property

        Public Function CreateChore()
            Return New Chore(NameTextBox.Text, DescriptionTextBox.Text, RecurrenceControl1.GetRecurrence, New TimeSpan(0, Integer.Parse(DurationMaskedTextBox.Text), 0), PeopleRequiredNumericUpDown.Value, Phone.Profile)
        End Function

        Private Sub CancelButton_Click(sender As Object, e As EventArgs) Handles CancelButton.Click
            Phone.ChangeView(New ChoresView)
        End Sub

        Private Sub ConfirmButton_Click(sender As Object, e As EventArgs) Handles ConfirmButton.Click
            Phone.Household.Chores.Add(CreateChore())
            Phone.ChangeView(New ChoresView)
        End Sub
    End Class
End Namespace