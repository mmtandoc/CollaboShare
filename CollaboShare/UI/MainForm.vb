Public Class MainForm
    Public Property Households As New List(Of Household)
    Private states As New Dictionary(Of String, State)
    Private phoneForms As New List(Of PhoneForm)

    Public Sub ChangeState(state As State)
        For Each phoneForm As PhoneForm In phoneForms
            phoneForm.Close()
        Next

        phoneForms.Clear()

        Dim phoneForm1 = New PhoneForm(state.Households, state.SubjectA) With {
            .Name = "SubjectA_Phone"
        }
        AddHandler phoneForm1.RequestSend, AddressOf PhoneForm_NotificationSend

        Dim phoneForm2 = New PhoneForm(state.Households, state.SubjectB) With {
            .Name = "SubjectB_Phone"
        }
        phoneForms.AddRange({phoneForm1, phoneForm2})

        phoneForm1.Show()
        phoneForm2.Show()
    End Sub

    Public Sub CreateDefaultStates()
        Dim household As New Household("B's Household")
        household.Chores.AddRange({
            New Chore("Wash the dishes", "", New Recurrence.DailyRecurrence(Date.Now, 2), New TimeSpan(0, 20, 0), Date.Now.AddDays(1), 1),
            New Chore("Clean the kitchen", "", New Recurrence.WeeklyRecurrence(Date.Now.AddDays(-1), 1), New TimeSpan(0, 20, 0), Date.Now.AddDays(1), 1),
            New Chore("Take out the garbage", "", New Recurrence.WeeklyRecurrence(Date.Now.AddDays(-1), 1), New TimeSpan(0, 10, 0), Date.Now.AddDays(1), 1),
            New Chore("Buy groceries", "", New Recurrence.WeeklyRecurrence(Date.Now.AddDays(-1), 1), New TimeSpan(0, 10, 0), Date.Now.AddDays(1), 1)
                                  })
        household.Housemates.AddRange({
            New Housemate("B User", "301-252-7823", "b.user@email.com"),
            New Housemate("John Smith", "123-123-1234", "john.smith@email.com")
        })

        Dim households As New List(Of Household) From {household}
        states.Add("Scenario 1", New State(households, New State.UserState(), New State.UserState(household, household.Housemates.ElementAt(0))))
    End Sub

    Public Async Sub PhoneForm_NotificationSend(sender As Object, e As EventArgs)
        Dim result = Await SendNotification(New JoinHouseholdDialog("test"))
    End Sub

    Public Async Function SendNotification(dialogControl As IDialogControl) As Task(Of DialogResult)
        Return Await phoneForms(1).ShowDialogControl(dialogControl)
    End Function

    Protected Overrides Sub OnLoad(e As EventArgs)
        CreateDefaultStates()
        ChangeState(states("Scenario 1"))
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ChangeState(states("Scenario 1"))
    End Sub
End Class