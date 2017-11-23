Namespace UI.Controls
    Public Class OfferItemControl
        Public Event ViewOffer As EventHandler
        Public Property Offer As Offer
        
        Public ReadOnly Property Phone() As PhoneForm
            Get
                Return FindForm()
            End Get
        End Property
        
        Public Sub New(offer As Offer)
            Me.Offer = offer
            ' This call is required by the designer.
            InitializeComponent()

            ' Add any initialization after the InitializeComponent() call.
            
        End Sub
        
        Protected Overrides Sub OnLoad(e As EventArgs)
            If Offer.Creator Is Phone.Profile Then
                OverflowButton.Visible = True
                OfferButton.Text = "Trade request from you"
            Else 
                OverflowButton.Visible = False
                OfferButton.Text = "Trade request from " + Offer.Creator.Name.Split(" ")(0)
            End If
        End Sub
        
        Private Sub EditToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EditToolStripMenuItem.Click

        End Sub

        Private Sub DeleteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DeleteToolStripMenuItem.Click
            Phone.Household.TradeOffers.Remove(Me.Offer)
        End Sub

        Private Sub OfferButton_Click(sender As Object, e As EventArgs) Handles OfferButton.Click
            RaiseEvent ViewOffer(Me, EventArgs.Empty)
        End Sub

        Private Sub OverflowButton_Click(sender As Object, e As EventArgs) Handles OverflowButton.Click
            Dim btnSender As Button = sender
            Dim ptLowerLeft = New Point(0, btnSender.Height)
            ptLowerLeft = btnSender.PointToScreen(ptLowerLeft)
            ContextMenuStrip1.Show(ptLowerLeft)
        End Sub
    End Class
End NameSpace