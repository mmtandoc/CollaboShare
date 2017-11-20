Imports CollaboShare.UI.Controls

Namespace UI.Views
    Public Class CreateDistributionView
        Public Event RequestingDistribution As EventHandler
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
            For Each c As Chore In Phone.Household.Chores
                AddChoreInstances(c)
            Next
        End Sub

        Private Sub AddChoreInstances(chore As Chore)
            Dim choreLabel As New Label With {
                .AutoSize = True,
                .Font = New Font("Microsoft Sans Serif", 9.25!, FontStyle.Bold, GraphicsUnit.Point, 0),
                .Location = New Point(3, 0),
                .Text = chore.Name + vbNewLine + "(" + chore.Frequency.ToString + ")"
            }
            Dim choreFlowLayoutPanel As New FlowLayoutPanel()
            choreFlowLayoutPanel.FlowDirection = FlowDirection.TopDown
            choreFlowLayoutPanel.AutoSize = True
            choreFlowLayoutPanel.Tag = chore

            choreFlowLayoutPanel.Controls.Add(choreLabel)
            Dim instances As List(Of Instance) = chore.Frequency.GetInstances()
            For Each i As Instance In instances
                Dim instanceControl As New InstanceControl(i, chore)
                choreFlowLayoutPanel.Controls.Add(instanceControl)
            Next
            InstancesFlowLayoutPanel.Controls.Add(choreFlowLayoutPanel)
        End Sub

        Public Function GetDistribution() As Distribution
            Dim distribution As New Dictionary(Of Chore, SortedDictionary(Of Instance, Housemate))
            For Each c As FlowLayoutPanel In InstancesFlowLayoutPanel.Controls.OfType(Of FlowLayoutPanel)
                Dim assignedInstances As New SortedDictionary(Of Instance, Housemate)
                For Each i As InstanceControl In c.Controls.OfType(Of InstanceControl)
                    assignedInstances.Add(i.Instance, i.AssignedHousemate)
                Next
                distribution.Add(c.Tag, assignedInstances)
            Next
            Return New Distribution(distribution)
        End Function

        Private Sub ConfirmButton_Click(sender As Object, e As EventArgs) Handles ConfirmButton.Click
            Dim request As New Request.DistributionRequest(Phone.Profile, Phone.Household, GetDistribution)
            RaiseEvent RequestingDistribution(Me, New RequestEventArgs(request))
            Phone.ChangeView(New HomeView)
        End Sub

        Private Sub CancelButton_Click(sender As Object, e As EventArgs) Handles CancelButton.Click
            Phone.ChangeView(New HomeView)
        End Sub
    End Class
End Namespace