Imports CollaboShare.UI.Controls
Imports CollaboShare.UI.Dialogs
Imports CollaboShare.UI.Views

Namespace UI
    Public Class PhoneForm
        Public Event RequestSend As EventHandler
        Public Event NotificationSend As EventHandler

        Public Shared Property Households As List(Of Household)

        Public Property Household As Household

        Public Property Profile As Housemate

        Private ReadOnly _firstRun As Boolean = True

        Private Property PastViews As New Stack(Of Control)

        Public Property CurrentRequest As RequestControl = Nothing
        Public Shared Property AutoDistribution As Distribution

        Public Sub New(userState As State.UserState)
            If userState.IsEmpty Then
                _firstRun = True
            Else
                _firstRun = False

                Me.Household = userState.JoinedHousehold
                Me.Profile = userState.Profile
            End If
            ' This call is required by the designer.
            InitializeComponent()

            ' Add any initialization after the InitializeComponent() call.
        End Sub

        Private Sub AddViewEventHandlers(ByRef viewControl As Control)
            Select Case viewControl.GetType()
                Case GetType(JoinHouseholdView)
                    AddHandler DirectCast(viewControl, JoinHouseholdView).RequestingHousehold,
                        Sub(sender As Object, e As EventArgs) RaiseEvent RequestSend(Me, e)
                Case GetType(ChoresView)
                    AddHandler DirectCast(viewControl, ChoresView).RequestingVolunteer, Sub(sender As Object, e As EventArgs) RaiseEvent RequestSend(Me, e)
                    AddHandler DirectCast(viewControl, ChoresView).RequestingExclusion, Sub(sender As Object, e As EventArgs) RaiseEvent RequestSend(Me, e)
                Case GetType(HouseholdView)
                    AddHandler DirectCast(viewControl, HouseholdView).RemovedHousemate, Sub(sender As Object, e As EventArgs) RaiseEvent NotificationSend(Me, e)
                    AddHandler DirectCast(viewControl, HouseholdView).Withdrawed, Sub(sender As Object, e As EventArgs) RaiseEvent NotificationSend(Me, e)
                Case GetType(CreateDistributionView)
                    AddHandler DirectCast(viewControl, CreateDistributionView).RequestingDistribution, Sub(sender As Object, e As EventArgs) RaiseEvent RequestSend(Me, e)
                Case GetType(ToDoListView)
                    AddHandler DirectCast(viewControl, ToDoListView).RequestingExtension, Sub(sender As Object, e As EventArgs) RaiseEvent RequestSend(Me, e)
                Case GetType(CreateTradeView)
                    AddHandler DirectCast(viewControl, CreateTradeView).CreatedTrade, Sub(sender As Object, e As EventArgs) RaiseEvent RequestSend(Me, e)
            End Select
        End Sub


        Private Sub ToggleNavBar(newView As Control)
            Dim viewType = newView.GetType
            Dim hideNavBarViews =
                    {GetType(JoinHouseholdView), GetType(CreateUserView), GetType(CreateHouseholdView),
                     GetType(HomeView)}
            NavPanel.Visible = Not hideNavBarViews.Contains(viewType)
        End Sub

        Public Sub PreviousView()
            If PastViews.Count <> 0 Then
                ChangeView(PastViews.Pop)
            End If
        End Sub

        Public Sub ChangeView(newView As Control)
            If ViewPanel.Controls.Count <> 0 Then
                PastViews.Push(ViewPanel.Controls(0))
            End If

            If newView.GetType() Is GetType(HomeView) Then
                PastViews.Clear()
            End If

            newView.Dock = DockStyle.Fill
            ToggleNavBar(newView)
            AddViewEventHandlers(newView)
            ViewPanel.Controls.Clear()
            ViewPanel.Controls.Add(newView)
        End Sub

        Public Async Function ShowRequestControl(requestControl As RequestControl) As Task(Of DialogResult)
            CurrentRequest = requestControl
            Me.Controls.Add(requestControl)
            DirectCast(requestControl, Control).BringToFront()
            Dim getResultTask As DialogResult = Await Task.Run(Function()
                                                                   Threading.SpinWait.SpinUntil(Function() requestControl.DialogResult <> DialogResult.None)
                                                                   Return requestControl.DialogResult
                                                               End Function)
            Me.Controls.Remove(requestControl)
            CurrentRequest = Nothing
            Return getResultTask
        End Function

        Public Async Sub ShowResponseControl(responseControl As ResponseControl)
            Controls.Add(responseControl)
            responseControl.BringToFront()
            Await Task.Run(Sub()
                               Threading.SpinWait.SpinUntil(Function() responseControl.Closed)
                           End Sub)
            Me.Controls.Remove(responseControl)
        End Sub

        Public Async Sub ShowNotificationControl(notificationControl As NotificationControl)
            Me.Controls.Add(notificationControl)
            notificationControl.BringToFront()
            Await Task.Run(Sub()
                               Threading.SpinWait.SpinUntil(Function() notificationControl.Closed)
                           End Sub)
            Me.Controls.Remove(notificationControl)
        End Sub

        Public Sub ReceiveResponse(response As Response)
            ShowResponseControl(New ResponseControl(response))
            Select Case response.OriginalRequest.RequestedAction
                Case Request.RequestAction.JoinHousehold
                    If response.Success Then
                        'JoinHousehold(response.OriginalRequest.RequestedObject)
                        Dim joiningHousehold As Household = response.OriginalRequest.RequestedObject
                        joiningHousehold.Housemates.Add(Me.Profile)
                        Household = joiningHousehold
                        ChangeView(New HomeView)
                    End If
                Case Request.RequestAction.Volunteer
                    If response.Success Then
                        Dim chore As Chore = response.OriginalRequest.RequestedObject
                        chore.Volunteer = Profile
                        If ViewPanel.Controls(0).GetType = GetType(ChoresView) Then
                            ChangeView(New ChoresView)
                        End If
                    End If
                Case Request.RequestAction.Exclusion
                    If response.Success Then
                        Dim chore As Chore = response.OriginalRequest.RequestedObject
                        chore.Exclusions.Add(Profile)
                        If ViewPanel.Controls(0).GetType = GetType(ChoresView) Then
                            ChangeView(New ChoresView)
                        End If
                    End If
                Case Request.RequestAction.CustomDistribution
                    If response.Success Then
                        Dim distribution As Distribution = response.OriginalRequest.RequestedObject
                        Household.Distribution = distribution
                    End If
                Case Request.RequestAction.Extension
                    If response.Success Then
                        Dim taskTuple As Tuple(Of ToDoList.Task, Integer) = response.OriginalRequest.RequestedObject
                        taskTuple.Item1.ExtensionDays += taskTuple.Item2
                        If ViewPanel.Controls(0).GetType = GetType(ToDoListView) Then
                            ChangeView(New ToDoListView(Profile))
                        End If
                    End If
            End Select
        End Sub

        Protected Overrides Sub OnLoad(e As EventArgs)
            If _firstRun Then
                ChangeView(New CreateUserView)
            Else
                ChangeView(New HomeView)
            End If
        End Sub

        'JoinHouseholdView event handlers

        Public Sub JoinHouseholdView_JoiningHousehold(sender As Object, e As EventArgs)
            RaiseEvent RequestSend(Me, e)
        End Sub

        Public Sub VolunteerChore(ByRef chore As Chore)
            chore.Volunteer = Profile
        End Sub

        Public Sub ExcludeChore(ByRef chore As Chore)
            chore.Exclusions.Add(Profile)
        End Sub

        Public Sub JoinHousehold(ByRef joiningHousehold As Household)
            joiningHousehold.Housemates.Add(Me.Profile)
            Household = joiningHousehold
            ChangeView(New HomeView)
        End Sub

        Private Sub ProfileButton_Click(sender As Object, e As EventArgs) Handles ProfileButton.Click
            ChangeView(New ProfileView(Profile))
        End Sub

        Private Sub ChoresButton_Click(sender As Object, e As EventArgs) Handles ChoresButton.Click
            ChangeView(New ChoresView)
        End Sub

        Private Sub TodoListButton_Click(sender As Object, e As EventArgs) Handles TodoListButton.Click
            ChangeView(New ToDoListView(Profile))
        End Sub

        Private Sub HouseholdButton_Click(sender As Object, e As EventArgs) Handles HouseholdButton.Click
            ChangeView(New HouseholdView)
        End Sub

        Private Sub BulletinButton_Click(sender As Object, e As EventArgs) Handles BulletinButton.Click
            ChangeView(New BulletinView)
        End Sub

        Private Sub DistributionButton_Click(sender As Object, e As EventArgs) Handles DistributionButton.Click
            ChangeView(New CurrentDistributionView)
        End Sub
    End Class
End Namespace