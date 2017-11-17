Namespace UI.Views
    Public Class EditProfileView
        Public Property Housemate As Housemate
        Public ReadOnly Property Phone As PhoneForm
            Get
                Return FindForm()
            End Get
        End Property
        Public Sub New(ByRef housemate As Housemate)
            Me.Housemate = housemate
            ' This call is required by the designer.
            InitializeComponent()

            ' Add any initialization after the InitializeComponent() call.
            FullNameTextBox.Text = housemate.Name
            PhoneNumberTextBox.Text = housemate.PhoneNumber
            EmailAddressTextBox.Text = housemate.Email
        End Sub

        Private Sub ConfirmButton_Click(sender As Object, e As EventArgs) Handles ConfirmButton.Click
            Housemate.Name = FullNameTextBox.Text
            Housemate.PhoneNumber = PhoneNumberTextBox.Text
            Housemate.Email = EmailAddressTextBox.Text
            Phone.ChangeView(New ProfileView(Phone.Profile))
        End Sub

        Private Sub CancelButton_Click(sender As Object, e As EventArgs) Handles CancelButton.Click
            Phone.ChangeView(New ProfileView(Phone.Profile))
        End Sub
    End Class
End NameSpace