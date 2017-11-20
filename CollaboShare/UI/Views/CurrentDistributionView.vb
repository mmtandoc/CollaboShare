Namespace UI.Views
    Public Class CurrentDistributionView
        Public ReadOnly Property Phone() As PhoneForm
            Get
                Return FindForm()
            End Get
        End Property


        Public Sub New()

            ' This call is required by the designer.
            InitializeComponent()


        End Sub

        Protected Overrides Sub OnLoad(e As EventArgs)
            If Not IsNothing(Phone.Household.Distribution) Then
                Panel3.Controls.Clear()
                Panel3.Controls.Add(New DistributionControl(Phone.Household.Distribution))
            End If

        End Sub

        Private Sub BackButton_Click(sender As Object, e As EventArgs) Handles BackButton.Click
            Phone.ChangeView(New HomeView)
        End Sub

        Private Sub CustomDistributionButton_Click(sender As Object, e As EventArgs) Handles CustomDistributionButton.Click
            Phone.ChangeView(New CreateDistributionView())
        End Sub

        Private Sub ProposedDistributionButton_Click(sender As Object, e As EventArgs) Handles ProposedDistributionButton.Click
            Phone.ChangeView(New ProposedDistributionView(Phone.Household.DistributeChores()))
        End Sub

        Private Sub ResetDistributionButton_Click(sender As Object, e As EventArgs) Handles ResetDistributionButton.Click
            Phone.Household.Distribution = Nothing
            Phone.ChangeView(New CurrentDistributionView)
        End Sub
    End Class
End Namespace