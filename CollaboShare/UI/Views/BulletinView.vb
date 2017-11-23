Imports CollaboShare.UI.Controls

Namespace UI.Views
    Public Class BulletinView
        Public ReadOnly Property Phone() As PhoneForm
            Get
                Return FindForm()
            End Get
        End Property

        Protected Overrides Sub OnLoad(e As EventArgs)
            For Each o As Offer In Phone.Household.TradeOffers
                Dim offerItem As New OfferItemControl(o)
                AddHandler offerItem.ViewOffer, AddressOf OfferItemControl_ViewOffer
                TradesFlowLayoutPanel.Controls.Add(offerItem)
            Next
        End Sub

        Private Sub BackButton_Click(sender As Object, e As EventArgs) Handles BackButton.Click
            Phone.ChangeView(New HomeView)
        End Sub

        Private Sub NewTradeButton_Click(sender As Object, e As EventArgs) Handles NewTradeButton.Click
            Phone.ChangeView(New CreateTradeView())
        End Sub

        Private Sub OfferItemControl_ViewOffer(sender As Object, e As EventArgs)
            Dim itemSender As OfferItemControl = sender
            Phone.ChangeView(New ViewTradeView(itemSender.Offer))
        End Sub

    End Class
End NameSpace