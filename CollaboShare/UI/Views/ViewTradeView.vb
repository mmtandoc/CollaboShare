Namespace UI.Views
    Public Class ViewTradeView
        Public Property Trade As Offer
        Public ReadOnly Property Phone() As PhoneForm
            Get
                Return FindForm()
            End Get
        End Property
        Public Sub New(trade As Offer)

            ' This call is required by the designer.
            InitializeComponent()

            ' Add any initialization after the InitializeComponent() call.

        End Sub

        Protected Overrides Sub OnLoad(e As EventArgs)

        End Sub
    End Class
End NameSpace