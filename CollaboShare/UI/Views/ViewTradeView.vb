Imports CollaboShare.UI.Controls

Namespace UI.Views
    Public Class ViewTradeView
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
                CounterofferButton.Visible = False
                CreatorLabel.Text = "You"
            Else
                CreatorLabel.Text = Offer.Creator.Name
            End If
            For Each c in Offer.OfferedInstances
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
            If Offer.Counteroffers.Count > 0 Then
                CounterofferFlowLayoutPanel.Controls.Clear
                For Each co As Offer.Counteroffer In Offer.Counteroffers
                    Dim itemControl As New CounterofferItemControl(co)
                    AddHandler itemControl.ViewCounterOffer, AddressOf CounterofferItem_ViewCounteroffer
                    CounterofferFlowLayoutPanel.Controls.Add(itemControl)
                Next
            End If
            
        End Sub

        Private Sub CounterofferButton_Click(sender As Object, e As EventArgs) Handles CounterofferButton.Click
            Phone.ChangeView(New CreateCounterofferView(offer))
        End Sub

        Private Sub BackButton_Click(sender As Object, e As EventArgs) Handles BackButton.Click
            Phone.ChangeView(New BulletinView)
        End Sub
        
        Private Sub CounterofferItem_ViewCounteroffer(sender As Object, e As EventArgs)
            Dim itemControl As CounterofferItemControl = sender
            Phone.ChangeView(New ViewCounterofferView(itemControl.Counteroffer, Me.Offer))
        End Sub
    End Class
End NameSpace