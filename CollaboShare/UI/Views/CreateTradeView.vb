Namespace UI.Views
    Public Class CreateTradeView
        Public Event CreatedTrade As EventHandler
        Public ReadOnly Property Phone() As PhoneForm
            Get
                Return FindForm()
            End Get
        End Property

        Protected Overrides Sub OnLoad(e As EventArgs)
            For Each t As ToDoList.Task In Phone.Profile.ToDoList
                TasksCheckedListBox.Items.Add(t)
            Next
        End Sub

        Public Function GetOffer() As Offer
            Dim offeredTasks As List(Of ToDoList.Task) = TasksCheckedListBox.CheckedItems.OfType(Of ToDoList.Task)
            'Return New Offer(Phone.Profile, offeredTasks)
        End Function

        Private Sub CancelButton_Click(sender As Object, e As EventArgs) Handles CancelButton.Click
            Phone.ChangeView(New BulletinView)
        End Sub

        Private Sub SubmitButton_Click(sender As Object, e As EventArgs) Handles SubmitButton.Click
            Dim request As New Request.OfferRequest(Phone.Profile, Phone.Household, GetOffer)
            'RaiseEvent CreatedTrade(Me, RequestEventArgs(request))
        End Sub
    End Class
End NameSpace