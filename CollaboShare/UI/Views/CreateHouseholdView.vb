Namespace UI.Views
    Public Class CreateHouseholdView
        Public Event Confirmed As EventHandler
        Public Event Cancelled As EventHandler

        Private Sub ConfirmButton_Click(sender As Object, e As EventArgs) Handles ConfirmButton.Click
            RaiseEvent Confirmed(Me, EventArgs.Empty)
        End Sub

        Private Sub CancelButton_Click(sender As Object, e As EventArgs) Handles CancelButton.Click
            RaiseEvent Cancelled(Me, EventArgs.Empty)
        End Sub
    End Class
End NameSpace