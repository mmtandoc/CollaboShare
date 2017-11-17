Public Class ViewChoreView
    Public Property ChosenChore As Chore
    Public Sub New(ByRef chosenChore As Chore)
        Me.ChosenChore = chosenChore
        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        ShowChore(Me.ChosenChore)
    End Sub

    Public Sub ShowChore(chore As Chore)
        NameLabel.Text = chore.Name
        If chore.Duration.Hours = 0 Then
            DurationLabel.Text = String.Format("{0:%m} minutes", chore.Duration)
        Else
            DurationLabel.Text = String.Format("{0:%h} hours {0:%m} minutes", chore.Duration)
        End If
        PeopleRequiredLabel.Text = chore.PeopleRequired.ToString
        DueDateLabel.Text = "Due date: " + chore.DueDate.ToShortDateString
        DescriptionLabel.Text = chore.Description
    End Sub

End Class
