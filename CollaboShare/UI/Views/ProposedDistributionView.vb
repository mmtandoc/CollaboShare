Namespace UI.Views
    Public Class ProposedDistributionView
        Public ReadOnly Property Phone() As PhoneForm
            Get
                Return FindForm()
            End Get
        End Property

        Public Property Distribution As Distribution

        Public Sub New(distribution As Distribution)
            Me.Distribution = distribution
            ' This call is required by the designer.
            InitializeComponent()

            ' Add any initialization after the InitializeComponent() call.
            'For Each c As KeyValuePair(Of Chore, SortedDictionary(Of Instance, Housemate)) In distribution.ChoreInstances
            '    Dim choreLabel As New Label With {
            '            .AutoSize = True,
            '            .Font = New Font("Microsoft Sans Serif", 9.25!, FontStyle.Bold, GraphicsUnit.Point, 0),
            '            .Location = New Point(3, 0),
            '            .Text = c.Key.Name + vbNewLine + "(" + c.Key.Frequency.ToString + ")"
            '            }
            '    FlowLayoutPanel1.Controls.Add(choreLabel)
            '    For Each i As KeyValuePair(Of Instance, Housemate) In c.Value
            '        Dim instanceLabel As New Label With {
            '            .Text = i.Key.ToString() + "    (" + i.Value.Name + ")",
            '            .AutoSize = True,
            '            .Font = New Font("Microsoft Sans Serif", 8.25!, FontStyle.Regular, GraphicsUnit.Point, 0),
            '            .Location = New Point(3, 0)
            '        }
            '        FlowLayoutPanel1.Controls.Add(instanceLabel)
            '    Next
            'Next
            FlowLayoutPanel1.Controls.Add(New DistributionControl(distribution))
        End Sub

        Private Sub RejectButton_Click(sender As Object, e As EventArgs) Handles RejectButton.Click
            If Not IsNothing(Phone.CurrentRequest) Then
                Phone.CurrentRequest.DialogResult = DialogResult.No
            End If

            Phone.PreviousView()
        End Sub

        Private Sub AcceptButton_Click(sender As Object, e As EventArgs) Handles AcceptButton.Click
            If Not IsNothing(Phone.CurrentRequest) Then
                Phone.CurrentRequest.DialogResult = DialogResult.Yes
            Else
                Phone.Household.Distribution = Distribution
            End If
            Phone.PreviousView()
        End Sub
    End Class
End Namespace