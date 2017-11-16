Namespace UI.Views
    Public Class CreateUserView
        Public Event Confirmed As EventHandler
        Public Event Cancelled(sender As Object, e As EventArgs)

        Private Sub ConfirmButton_Click(sender As Object, e As EventArgs) Handles ConfirmButton.Click
            RaiseEvent Confirmed(Me, e)
        End Sub
    End Class
End NameSpace