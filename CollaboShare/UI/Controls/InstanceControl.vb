Namespace UI.Controls
    Public Class InstanceControl

        Public ReadOnly Property Phone() As PhoneForm
            Get
                Return FindForm()
            End Get
        End Property

        Public Property Instance As Instance
        Public Property Chore As Chore
        Public ReadOnly Property AssignedHousemate As Housemate
            Get
                Return AssignedComboBox.SelectedItem
            End Get
        End Property
        Public Sub New(instance As Instance, chore As Chore)
            Me.Instance = instance
            Me.Chore = chore
            ' This call is required by the designer.
            InitializeComponent()

            ' Add any initialization after the InitializeComponent() call.
            InstanceLabel.Text = instance.ToString
        End Sub

        Protected Overrides Sub OnLoad(e As EventArgs)
            If IsNothing(Chore.Volunteer) Then
                For Each h As Housemate In Phone.Household.Housemates
                    If Not Chore.Exclusions.Contains(h) Then
                        AssignedComboBox.Items.Add(h)
                    End If
                Next
            Else
                AssignedComboBox.Items.Add(Chore.Volunteer)
            End If

        End Sub
    End Class
End Namespace