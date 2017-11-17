Namespace UI.Views
    Public Class CreateUserView
        Public Event Confirmed As EventHandler

        Public ReadOnly Property Phone() As PhoneForm
            Get
                Return FindForm()
            End Get
        End Property

        Private Sub ConfirmButton_Click(sender As Object, e As EventArgs) Handles ConfirmButton.Click
            Phone.Profile = New Housemate(FullNameTextBox.Text, PhoneNumberTextBox.Text,
                                          EmailAddressTextBox.Text, New Bitmap(50, 60))
            Phone.ChangeView(New JoinHouseholdView)
        End Sub
    End Class
End Namespace