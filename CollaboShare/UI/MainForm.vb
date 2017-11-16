Imports CollaboShare.UI.Dialogs

Namespace UI
    Public Class MainForm
        Public Property Households As New List(Of Household)
        Private ReadOnly states As New Dictionary(Of String, State)
        Private ReadOnly phoneForms As New List(Of PhoneForm)

        Public Sub ChangeState(state As State)
            For Each phoneForm As PhoneForm In phoneForms
                phoneForm.Close()
            Next

            phoneForms.Clear()

            Dim phoneForm1 = New PhoneForm(state.Households, state.SubjectA) With {
                    .Name = "SubjectA_Phone"
                    }
            AddHandler phoneForm1.RequestSend, AddressOf PhoneForm_RequestSend
            AddHandler phoneForm1.NotificationSend, AddressOf PhoneForm_NotificationSend

            Dim phoneForm2 = New PhoneForm(state.Households, state.SubjectB) With {
                    .Name = "SubjectB_Phone"
                    }
            AddHandler phoneForm2.RequestSend, AddressOf PhoneForm_RequestSend
            AddHandler phoneForm2.NotificationSend, AddressOf PhoneForm_NotificationSend

            phoneForms.AddRange({phoneForm1, phoneForm2})

            phoneForm1.Show()
            phoneForm2.Show()
        End Sub

        Public Sub CreateDefaultStates()
            Dim stateHousehold As New Household("B's Household")
            stateHousehold.Chores.AddRange({
                                          New Chore("Wash the dishes", "", New DailyRecurrence(Date.Now, 2),
                                                    New TimeSpan(0, 20, 0), Date.Now.AddDays(1), 1),
                                          New Chore("Clean the kitchen", "",
                                                    New WeeklyRecurrence(Date.Now.AddDays(-1), 1),
                                                    New TimeSpan(0, 20, 0), Date.Now.AddDays(1), 1),
                                          New Chore("Take out the garbage", "",
                                                    New WeeklyRecurrence(Date.Now.AddDays(-1), 1),
                                                    New TimeSpan(0, 10, 0), Date.Now.AddDays(1), 1),
                                          New Chore("Buy groceries", "", New WeeklyRecurrence(Date.Now.AddDays(-1), 1),
                                                    New TimeSpan(0, 10, 0), Date.Now.AddDays(1), 1)
                                      })
            stateHousehold.Housemates.AddRange({
                                              New Housemate("B User", "301-252-7823", "b.user@email.com"),
                                              New Housemate("John Smith", "123-123-1234", "john.smith@email.com")
                                          })
            states.Add("Scenario 1",
                       New State({stateHousehold}.ToList(), New State.UserState(),
                                 New State.UserState(stateHousehold, stateHousehold.Housemates.ElementAt(0))))
        End Sub

        Public Function GetOtherPhone(phone As PhoneForm)
            Return phoneForms.Find(Function(pf) Not pf.Equals(phone))
        End Function

        Private Sub PhoneForm_NotificationSend(sender As Object, e As NotificationEventArgs)
            Dim recipient As PhoneForm = GetOtherPhone(sender)
            recipient.ShowNotificationControl(New NotificationControl(e.Notification))
        End Sub

        Private Async Sub PhoneForm_RequestSend(sender As PhoneForm, e As RequestEventArgs)
            Dim recipient As PhoneForm = GetOtherPhone(sender)
            Dim response = Await recipient.ShowRequestControl(New RequestControl(e.Request))
            If response = DialogResult.Yes Then
                sender.ReceiveResponse(New Response(True, "You have been accepted to the household.", e.Request))
            End If
        End Sub


        Protected Overrides Sub OnLoad(e As EventArgs)
            CreateDefaultStates()
            ChangeState(states("Scenario 1"))
        End Sub

        Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
            ChangeState(states("Scenario 1"))
        End Sub
    End Class
End Namespace