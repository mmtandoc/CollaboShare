Imports CollaboShare.UI.Controls

Namespace UI.Views
    Public Class HouseholdView
        Public Event RemovedHousemate As EventHandler
        Public ReadOnly Property Phone() As PhoneForm
            Get
                Return FindForm()
            End Get
        End Property

        Public Sub New()

            ' This call is required by the designer.
            InitializeComponent()

            ' Add any initialization after the InitializeComponent() call.

        End Sub

        Protected Overrides Sub OnLoad(e As EventArgs)
            MyBase.OnLoad(e)
            NameLabel.Text = Phone.Household.Name
            AddressLabel.Text = Phone.Household.Address
            Me.HousemateFlowLayoutPanel.Controls.Clear()
            For Each housemate As Housemate In Phone.Household.Housemates
                If Not housemate.Equals(Phone.Profile) Then
                    AddHousemateItem(housemate)
                End If
            Next
        End Sub

        Private Sub AddHousemateItem(ByRef housemate As Housemate)
            Dim newItem = New HousemateItemControl(housemate)
            AddHandler newItem.View, AddressOf HousemateItem_View
            AddHandler newItem.Remove, AddressOf HousemateItem_Remove
            HousemateFlowLayoutPanel.Controls.Add(newItem)
        End Sub


        Private Sub HousemateItem_View(sender As Object, e As EventArgs)
            Dim housemateItem As HousemateItemControl = sender
            Phone.ChangeView(New ProfileView(housemateItem.Housemate))
        End Sub

        Private Sub HousemateItem_Remove(sender As Object, e As EventArgs)
            Dim housemateItem As HousemateItemControl = sender
            Phone.Household.Housemates.Remove(housemateItem.Housemate)
            HousemateFlowLayoutPanel.Controls.Remove(housemateItem)
            Dim notification As New Notification(Phone.Profile, Phone.Household.Housemates.FindAll(Function(h) Not h.Equals(Phone.Profile)), housemateItem.Housemate.Name + " has been removed from the household.")
            RaiseEvent RemovedHousemate(Me, New NotificationEventArgs(notification))
            Phone.Household.DistributeChores()
        End Sub

        Private Sub BackButton_Click(sender As Object, e As EventArgs) Handles BackButton.Click
            Phone.ChangeView(New HomeView)
        End Sub
    End Class
End Namespace