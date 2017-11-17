Namespace UI.Views
    Public Class HomeView
        Public ReadOnly Property Phone() As PhoneForm
            Get
                Return FindForm()
            End Get
        End Property

        Private Sub ToDoListButton_Click(sender As Object, e As EventArgs) Handles ToDoListButton.Click
            Phone.ChangeView(New ToDoListView(Phone.Profile))
        End Sub

        Private Sub MyProfileButton_Click(sender As Object, e As EventArgs) Handles MyProfileButton.Click
            Phone.ChangeView(New ProfileView(Phone.Profile))
        End Sub

        Private Sub ChoresButton_Click(sender As Object, e As EventArgs) Handles ChoresButton.Click
            Phone.ChangeView(New ChoresView)
        End Sub

        Private Sub HouseholdButton_Click(sender As Object, e As EventArgs) Handles HouseholdButton.Click
            Phone.ChangeView(New HouseholdView)
        End Sub

        Private Sub BulletinButton_Click(sender As Object, e As EventArgs) Handles BulletinButton.Click
            Phone.ChangeView(New BulletinView)
        End Sub
    End Class
End NameSpace