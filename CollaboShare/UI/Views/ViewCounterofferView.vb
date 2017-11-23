Namespace UI.Views
    Public Class ViewCounterofferView
        Public Event AcceptedCounteroffer As EventHandler
        Public Property Counteroffer As Offer.Counteroffer
        Public Property Offer As Offer
        
        Public ReadOnly Property Phone() As PhoneForm
            Get
                Return FindForm()
            End Get
        End Property

        Public Sub New(counteroffer As Offer.Counteroffer, offer As Offer)
            Me.Counteroffer = counteroffer
            Me.Offer = offer
            ' This call is required by the designer.
            InitializeComponent()

            ' Add any initialization after the InitializeComponent() call.

        End Sub
        
        Protected Overrides Sub OnLoad(e As EventArgs)
            If Offer.Creator Is Phone.Profile Then
                CreatorLabel.Text = "You"
                AcceptButton.Visible = True
            Else
                CreatorLabel.Text = Counteroffer.Creator.Name
                AcceptButton.Visible = False
            End If
            For Each c in Counteroffer.OfferedInstances
                For Each i in c.Value
                    Dim instanceLabel As New Label With {
                            .Text = c.Key.Name + " (" + i.ToString + ")",
                            .AutoSize = True,
                            .Font = New Font("Microsoft Sans Serif", 8.25!, FontStyle.Regular, GraphicsUnit.Point, 0),
                            .Location = New Point(3, 0)
                            }
                    OfferedFlowLayoutPanel.Controls.Add(instanceLabel)
                Next
            Next
        End Sub

        Private Sub BackButton_Click(sender As Object, e As EventArgs) Handles BackButton.Click
            Phone.PreviousView
        End Sub

        Private Sub AcceptButton_Click(sender As Object, e As EventArgs) Handles AcceptButton.Click
            Phone.Household.Trade(Offer, Counteroffer)
            Phone.Household.TradeOffers.Remove(Offer)
            Dim notification As New Notification(Phone.Profile, {Counteroffer.Creator}.ToList, Phone.Profile.Name + " has accepted your counter-offer.")
            RaiseEvent AcceptedCounteroffer(Me, New NotificationEventArgs(notification))
            Phone.ChangeView(New HomeView)
        End Sub
    End Class
End NameSpace