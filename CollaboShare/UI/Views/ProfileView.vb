Namespace UI.Views
    Public Class ProfileView

        Public ReadOnly Property Phone As PhoneForm
            Get
                Return FindForm()
            End Get
        End Property

        Public Property Housemate As Housemate

        Public Sub New(ByRef housemate As Housemate)
            Me.Housemate = housemate
            ' This call is required by the designer.
            InitializeComponent()

            ' Add any initialization after the InitializeComponent() call.
            NameLabel.Text = housemate.Name
            PhoneNumberLabel.Text = housemate.PhoneNumber
            EmailAddressLabel.Text = housemate.Email
            PhotoPictureBox.Image = housemate.Photo
        End Sub

        Protected Overrides Sub OnLoad(e As EventArgs)
            EditButton.Visible = Phone.Profile.Equals(Housemate)
            ChorePreferencesButton.Visible = Phone.Profile.Equals(Housemate)
        End Sub

        Private Sub EditButton_Click(sender As Object, e As EventArgs) Handles EditButton.Click
            Phone.ChangeView(New EditProfileView(Phone.Profile))
        End Sub

        Private Sub BackButton_Click(sender As Object, e As EventArgs) Handles BackButton.Click
            Phone.ChangeView(New HomeView)
        End Sub

        Private Sub ToDoListButton_Click(sender As Object, e As EventArgs) Handles ToDoListButton.Click
            Phone.ChangeView(New ToDoListView(Housemate))
        End Sub

        Private Sub ChorePreferencesButton_Click(sender As Object, e As EventArgs) Handles ChorePreferencesButton.Click
            Phone.ChangeView(New ChorePreferencesView(Housemate, Phone.Household))
        End Sub
    End Class
End NameSpace