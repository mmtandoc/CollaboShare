Imports System.ComponentModel
Imports CollaboShare.UI.Controls

Namespace UI.Views
    Public Class ChoresView
        Public Event CreateChore As EventHandler
        Public Event ViewChore As EventHandler
        Public Event EditChore As EventHandler
        Public Event DeleteChore As EventHandler
        Public Event VolunteerChore As EventHandler
        Public Event ExcludeChore As EventHandler

        <DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)>
        Public ReadOnly Property Household() As Household
            Get
                Dim phone As PhoneForm = Me.FindForm()
                Return phone.Household
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
            AddHandler newChoreItem.Exclude, AddressOf ChoreItem_Exclude
            ChoresFlowLayoutPanel.Controls.Add(newChoreItem)
        End Sub

        Private Sub ChoreItem_View(sender As Object, e As EventArgs)
            Dim choreItem As ChoreItemControl = sender
            RaiseEvent ViewChore(choreItem.Chore, e)
        End Sub

        Private Sub ChoreItem_Volunteer(sender As Object, e As EventArgs)
            Dim choreItem As ChoreItemControl = sender
            RaiseEvent VolunteerChore(choreItem.Chore, e)
        End Sub

        Private Sub ChoreItem_Exclude(sender As Object, e As EventArgs)
            Dim choreItem As ChoreItemControl = sender
            RaiseEvent ExcludeChore(choreItem.Chore, e)
        End Sub

        Private Sub ChoreItem_Edit(sender As Object, e As EventArgs)
            Dim choreItem As ChoreItemControl = sender
            RaiseEvent EditChore(choreItem.Chore, e)
        End Sub

        Private Sub ChoreItem_Delete(sender As Object, e As EventArgs)
            Dim choreItem As ChoreItemControl = sender
            RaiseEvent DeleteChore(choreItem.Chore, e)
        End Sub

        Private Sub NewChoreButton_Click(sender As Object, e As EventArgs) Handles NewChoreButton.Click
            RaiseEvent CreateChore(Me, EventArgs.Empty)
        End Sub


    End Class
End Namespace