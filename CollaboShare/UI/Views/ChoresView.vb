Imports System.ComponentModel
Imports CollaboShare.UI.Controls
Imports CollaboShare.UI.Dialogs

Namespace UI.Views
    Public Class ChoresView
        Public Event RequestingVolunteer As EventHandler
        Public Event RequestingExclusion As EventHandler

        <DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)>
        Public ReadOnly Property Household As Household
            Get
                Dim phone As PhoneForm = Me.FindForm()
                Return phone.Household
            End Get
        End Property

        Public ReadOnly Property Phone As PhoneForm
            Get
                Return FindForm()
            End Get
        End Property

        Protected Overrides Sub OnLoad(e As EventArgs)
            MyBase.OnLoad(e)
            Me.ChoresFlowLayoutPanel.Controls.Clear()
            For Each chore As Chore In Household.Chores
                AddChoreItem(chore)
            Next
        End Sub

        Private Sub AddChoreItem(ByRef chore As Chore)
            Dim newChoreItem = New ChoreItemControl(chore)
            AddHandler newChoreItem.View, AddressOf ChoreItem_View
            AddHandler newChoreItem.Edit, AddressOf ChoreItem_Edit
            AddHandler newChoreItem.Delete, AddressOf ChoreItem_Delete
            AddHandler newChoreItem.Volunteer, AddressOf ChoreItem_Volunteer
            AddHandler newChoreItem.CancelVolunteer, AddressOf ChoreItem_CancelVolunteer
            AddHandler newChoreItem.Exclude, AddressOf ChoreItem_Exclude
            AddHandler newChoreItem.CancelExclude, AddressOf ChoreItem_CancelExclude
            ChoresFlowLayoutPanel.Controls.Add(newChoreItem)
        End Sub

        Private Sub ChoreItem_View(sender As Object, e As EventArgs)
            Dim choreItem As ChoreItemControl = sender
            'RaiseEvent ViewChore(choreItem, e)
            Phone.ChangeView(New ViewChoreView(choreItem.Chore))
        End Sub

        Private Sub ChoreItem_Volunteer(sender As Object, e As EventArgs)
            Dim choreItem As ChoreItemControl = sender
            Dim requestedChore = choreItem.Chore
            Dim request As Request = New Request.VolunteerRequest(Phone.Profile, Phone.Household, requestedChore)
            RaiseEvent RequestingVolunteer(sender, New RequestEventArgs(request))
        End Sub

        Public Sub ChoreItem_CancelVolunteer(sender As Object, e As EventArgs)
            Dim choreItem As ChoreItemControl = sender
            choreItem.Chore.Volunteer = Nothing
            Dim _
                notification As _
                    New Notification(Phone.Profile, New List(Of Housemate)({Phone.Profile}),
                                     "You have cancelled volunteering for chore '" + choreItem.Chore.Name + "'.")
            Phone.ShowNotificationControl(New NotificationControl(notification))
            Phone.ChangeView(New ChoresView)
        End Sub

        Public Sub ChoreItem_CancelExclude(sender As Object, e As EventArgs)
            Dim choreItem As ChoreItemControl = sender
            choreItem.Chore.Exclusions.Remove(Phone.Profile)
            Dim _
                notification As _
                    New Notification(Phone.Profile, New List(Of Housemate)({Phone.Profile}),
                                     "You have cancelled your exclusion from chore '" + choreItem.Chore.Name + "'.")
            Phone.ShowNotificationControl(New NotificationControl(notification))
            Phone.ChangeView(New ChoresView)
        End Sub

        Private Sub ChoreItem_Exclude(sender As Object, e As EventArgs)
            Dim choreItem As ChoreItemControl = sender
            Dim requestedChore = choreItem.Chore
            If requestedChore.Exclusions.Count = Household.Housemates.Count - 1 Then
                Phone.ShowNotificationControl((New NotificationControl(New Notification(Phone.Profile, {Phone.Profile}.ToList, "Everyone else in your household is already excluded from this chore."))))
            Else
                Dim request As Request = New Request.ExclusionRequest(Phone.Profile, Phone.Household, requestedChore)
                RaiseEvent RequestingVolunteer(sender, New RequestEventArgs(request))
            End If
        End Sub

        Private Sub ChoreItem_Edit(sender As Object, e As EventArgs)
            Dim choreItem As ChoreItemControl = sender
            'RaiseEvent EditChore(choreItem, e)
            Phone.ChangeView(New EditChoreView(choreItem.Chore))
        End Sub

        Private Sub ChoreItem_Delete(sender As Object, e As EventArgs)
            Dim choreItem As ChoreItemControl = sender
            'RaiseEvent DeleteChore(choreItem, e)
            Phone.Household.Chores.Remove(choreItem.Chore)
            ChoresFlowLayoutPanel.Controls.Remove(choreItem)
        End Sub

        Private Sub NewChoreButton_Click(sender As Object, e As EventArgs) Handles NewChoreButton.Click
            'RaiseEvent CreateChore(Me, EventArgs.Empty)
            Phone.ChangeView(New CreateChoreView)
        End Sub
    End Class
End Namespace