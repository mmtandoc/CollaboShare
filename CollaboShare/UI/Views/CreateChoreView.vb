Namespace UI.Views
    Public Class CreateChoreView
        Public Event Confirmed As EventHandler
        Public Event Cancelled As EventHandler
        Public ReadOnly Property Profile As Housemate
            Get
                Dim phone As PhoneForm = Me.FindForm()
                Return phone.Profile
            End Get
        End Property
        Public Function CreateChore()
            Return New Chore(NameTextBox.Text, DescriptionTextBox.Text, RecurrenceControl1.GetRecurrence, New TimeSpan(0, Integer.Parse(DurationMaskedTextBox.Text), 0), RecurrenceControl1.DueDateDateTimePicker.Value, PeopleRequiredNumericUpDown.Value, Profile)
        End Function

        Private Sub CancelButton_Click(sender As Object, e As EventArgs) Handles CancelButton.Click
            RaiseEvent Cancelled(Me, EventArgs.Empty)
        End Sub

        Private Sub ConfirmButton_Click(sender As Object, e As EventArgs) Handles ConfirmButton.Click
            RaiseEvent Confirmed(Me, EventArgs.Empty)
        End Sub
    End Class
End NameSpace