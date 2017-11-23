Namespace UI.Controls
    Public Class CounterofferItemControl
        Public Event ViewCounterOffer As EventHandler
        Public Property Counteroffer As Offer.Counteroffer
        
        Public ReadOnly Property Phone() As PhoneForm
            Get
                Return FindForm()
            End Get
        End Property
        
        Public Sub New(counteroffer As Offer.Counteroffer)
            Me.Counteroffer = counteroffer
            ' This call is required by the designer.
            InitializeComponent()

            ' Add any initialization after the InitializeComponent() call.
            
        End Sub
        
        Protected Overrides Sub OnLoad(e As EventArgs)
            If Counteroffer.Creator IsNot Phone.Profile Then
                OverflowButton.Visible = False
                CounterOfferButton.Text = "Counter-offer from " + Counteroffer.Creator.Name.Split(" ")(0)
                
            Else
                CounterOfferButton.Text = "Counter-offer from you"
            End If
        End Sub
        
        Private Sub EditToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EditToolStripMenuItem.Click

        End Sub

        Private Sub DeleteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DeleteToolStripMenuItem.Click
            Phone.Household.TradeOffers.Find(Function(offer) offer.Counteroffers.Contains(Me.Counteroffer)).Counteroffers.Remove(Me.Counteroffer)
        End Sub

        Private Sub CounterOfferButton_Click(sender As Object, e As EventArgs) Handles CounterOfferButton.Click
            RaiseEvent ViewCounterOffer(Me, EventArgs.Empty)
        End Sub
    End Class
End NameSpace