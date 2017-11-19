Namespace UI.Views
    Public Class EditChoreView
        Public Event Confirmed As EventHandler
        Public Event Cancelled As EventHandler

        Public ReadOnly Property Phone() As PhoneForm
            Get
                Return FindForm()
            End Get
        End Property

        Public Property Chore As Chore
        Public Sub New(chore As Chore)
            Me.Chore = chore
            ' This call is required by the designer.
            InitializeComponent()

            ' Add any initialization after the InitializeComponent() call.
            FillFields(chore)
        End Sub

        Public Sub FillFields(chore As Chore)
            NameTextBox.Text = chore.Name
            DescriptionTextBox.Text = chore.Description
            RecurrenceControl1.SetRecurrence(chore.Frequency)
            DurationMaskedTextBox.Text = chore.Duration.Minutes.ToString
            PeopleRequiredNumericUpDown.Value = chore.PeopleRequired
        End Sub

        Private Sub CancelButton_Click(sender As Object, e As EventArgs) Handles CancelButton.Click
            Phone.ChangeView(New ChoresView)
        End Sub

        Private Sub ConfirmButton_Click(sender As Object, e As EventArgs) Handles ConfirmButton.Click
            Chore.Edit(NameTextBox.Text, DescriptionTextBox.Text, RecurrenceControl1.GetRecurrence, New TimeSpan(0, Integer.Parse(DurationMaskedTextBox.Text), 0), PeopleRequiredNumericUpDown.Value, Phone.Profile)
            Phone.ChangeView(New ChoresView)
        End Sub
    End Class
End NameSpace