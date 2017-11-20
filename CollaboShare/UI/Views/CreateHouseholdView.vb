Namespace UI.Views
    Public Class CreateHouseholdView
        Public Event Confirmed As EventHandler
        Public Event Cancelled As EventHandler
        Public ReadOnly Property Phone() As PhoneForm
            Get
                Return FindForm()
            End Get
        End Property

        Private Sub ConfirmButton_Click(sender As Object, e As EventArgs) Handles ConfirmButton.Click
            'RaiseEvent Confirmed(Me, EventArgs.Empty)
            Phone.Household = New Household(NameTextBox.Text, AddressTextBox.Text)
            PhoneForm.Households.Add(Phone.Household)
            Phone.Household.Housemates.Add(Phone.Profile)
            Phone.ChangeView(New HomeView)
        End Sub

        Private Sub CancelButton_Click(sender As Object, e As EventArgs) Handles CancelButton.Click
            'RaiseEvent Cancelled(Me, EventArgs.Empty)
            Phone.ChangeView(New JoinHouseholdView)
        End Sub
    End Class
End Namespace