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

        Private ReadOnly firstRun As Boolean = True


        Public Sub New(userState As State.UserState)
            If userState.IsEmpty Then
                Me.firstRun = True
            Else
                firstRun = False

                Me.Household = userState.JoinedHousehold
                Me.Profile = userState.Profile
            End If
            ' This call is required by the designer.
            InitializeComponent()

            ' Add any initialization after the InitializeComponent() call.
        End Sub

        Private Sub AddViewEventHandlers(ByRef viewControl As Control)
            Select Case viewControl.GetType()
                Case GetType(CreateUserView)
                    AddHandler DirectCast(viewControl, CreateUserView).Confirmed, AddressOf CreateUserView_Confirmed
                Case GetType(JoinHouseholdView)
                    AddHandler DirectCast(viewControl, JoinHouseholdView).RequestingHousehold,
                        AddressOf JoinHouseholdView_JoiningHousehold
                    AddHandler DirectCast(viewControl, JoinHouseholdView).CreatingHousehold,
                        AddressOf JoinHouseholdView_CreatingHousehold
                Case GetType(CreateHouseholdView)
                    AddHandler DirectCast(viewControl, CreateHouseholdView).Cancelled,
                        AddressOf CreateHouseholdView_Cancelled
                    AddHandler DirectCast(viewControl, CreateHouseholdView).Confirmed,
                        AddressOf CreateHouseholdView_Confirmed
                Case GetType(HomeView)
                    AddHandler DirectCast(viewControl, HomeView).HouseholdButton.Click,
                        Sub(s As Object, e As EventArgs) ChangeView(New HouseholdView)
                    AddHandler DirectCast(viewControl, HomeView).ChoresButton.Click,
                        Sub(s As Object, e As EventArgs) ChangeView(New ChoresView)
                    AddHandler DirectCast(viewControl, HomeView).MyProfileButton.Click,
                        Sub(s As Object, e As EventArgs) ChangeView(New ProfileView(Profile))
                    AddHandler DirectCast(viewControl, HomeView).ToDoListButton.Click,
                        Sub(s As Object, e As EventArgs) ChangeView(New ToDoListView(Profile))
                    AddHandler DirectCast(viewControl, HomeView).BulletinButton.Click,
                        Sub(s As Object, e As EventArgs) ChangeView(New BulletinView)
                Case GetType(ChoresView)
                    AddHandler DirectCast(viewControl, ChoresView).ViewChore, AddressOf ChoresView_ViewChore
                    AddHandler DirectCast(viewControl, ChoresView).CreateChore, Sub(s As Object, e As EventArgs) ChangeView(New CreateChoreView)
                Case GetType(ViewChoreView)
                    AddHandler DirectCast(viewControl, ViewChoreView).BackButton.Click, AddressOf ViewChoreView_Back

                Case GetType(CreateChoreView)
                    AddHandler DirectCast(viewControl, CreateChoreView).Confirmed, AddressOf CreateChoreView_Accepted
                    AddHandler DirectCast(viewControl, CreateChoreView).Cancelled, AddressOf CreateChoreView_Cancelled
                Case GetType(EditChoreView)

                Case Else

            End Select
        End Sub



        Public Sub ToggleNavBar(newView As Control)
            Dim viewType = TypeName(newView).GetType
            Dim hideNavBarViews =
                    {GetType(JoinHouseholdView), GetType(CreateUserView), GetType(CreateHouseholdView),
                     GetType(HomeView)}
            NavPanel.Visible = Not hideNavBarViews.Contains(viewType)
        End Sub

        Public Sub ChangeView(newView As Control)
            newView.Dock = DockStyle.Fill
            ToggleNavBar(newView)
            AddViewEventHandlers(newView)
            ViewPanel.Controls.Clear()
            ViewPanel.Controls.Add(newView)
        End Sub

        Public Async Function ShowRequestControl(requestControl As RequestControl) As Task(Of DialogResult)
            Me.Controls.Add(requestControl)
            DirectCast(requestControl, Control).BringToFront()
            Dim getResultTask As DialogResult = Await Task.Run(Function()
                                                                   Do Until Not (requestControl.DialogResult = DialogResult.None)

                                                                   Loop
                                                                   Return requestControl.DialogResult
                                                               End Function)
            Me.Controls.Remove(requestControl)
            Return getResultTask
        End Function

        Public Async Sub ShowResponseControl(responseControl As ResponseControl)
            Controls.Add(responseControl)
            responseControl.BringToFront()
            Await Task.Run(Sub()
                               Do Until responseControl.Closed

                               Loop
                           End Sub)
            Me.Controls.Remove(responseControl)
        End Sub

        Public Async Sub ShowNotificationControl(notificationControl As NotificationControl)
            Me.Controls.Add(notificationControl)
            notificationControl.BringToFront()
            Await Task.Run(Sub()
                               Do Until notificationControl.Closed

                               Loop
                           End Sub)
            Me.Controls.Remove(notificationControl)
        End Sub

        Public Sub ReceiveResponse(response As Response)
            ShowResponseControl(New ResponseControl(response))
            Select Case response.OriginalRequest.RequestedAction
                Case Request.RequestAction.JoinHousehold
                    If response.Success Then
                        JoinHousehold(response.OriginalRequest.RequestedObject)
                    End If
                Case Else
            End Select
        End Sub

        'Private Sub RequestControl_Close(sender As Object, e As EventArgs)
        '    Dim requestControl As RequestControl = sender
        '    dialogControlResult = requestControl.DialogResult
        'End Sub


        'Private Sub DialogControl_Closing(sender As Object, e As EventArgs)
        '    Dim dialogControl As IDialogControl = sender
        '    dialogControlResult = dialogControl.DialogResult
        'End Sub

        Protected Overrides Sub OnLoad(e As EventArgs)
            If firstRun Then
                ChangeView(New CreateUserView)
            Else
                ChangeView(New HomeView)
            End If
        End Sub


        'CreateUserView event handlers

        Public Sub CreateUserView_Confirmed(sender As Object, e As EventArgs)
            Dim view As CreateUserView = sender
            Me.Profile = New Housemate(view.FullNameTextBox.Text, view.PhoneNumberTextBox.Text,
                                       view.EmailAddressTextBox.Text, New Bitmap(50, 60))
            ChangeView(New JoinHouseholdView)
        End Sub


        'JoinHouseholdView event handlers

        Public Sub JoinHouseholdView_JoiningHousehold(sender As Object, e As EventArgs)
            RaiseEvent RequestSend(Me, e)
        End Sub

        Public Sub JoinHousehold(ByRef joiningHousehold As Household)
            joiningHousehold.AddHousemate(Me.Profile)
            Household = joiningHousehold
            ChangeView(New HomeView)
        End Sub

        Public Sub JoinHouseholdView_CreatingHousehold(sender As Object, e As EventArgs)
            ChangeView(New CreateHouseholdView)
        End Sub

        'CreateHouseholdView event handlers

        Public Sub CreateHouseholdView_Confirmed(sender As Object, e As EventArgs)
            Dim viewSender As CreateHouseholdView = sender
            Household = New Household(viewSender.NameTextBox.Text, viewSender.AddressTextBox.Text)
            Households.Add(Household)
            ChangeView(New HomeView)
        End Sub

        Public Sub CreateHouseholdView_Cancelled(sender As Object, e As EventArgs)
            ChangeView(New JoinHouseholdView)
        End Sub

        'HomeView event handlers

        'ChoresView event handlers
        Public Sub ChoresView_ViewChore(sender As Object, e As EventArgs)
            Dim chosenChore As Chore = CType(sender, ChoreItemControl).Chore
            ChangeView(New ViewChoreView(chosenChore))
        End Sub

        'ViewChoreView events handlers
        Public Sub ViewChoreView_Back(sender As Object, e As EventArgs)
            ChangeView(New ChoresView)
        End Sub

        'CreateChoreView event handlers
        Public Sub CreateChoreView_Cancelled(sender As Object, e As EventArgs)
            ChangeView(New ChoresView)
        End Sub

        Public Sub CreateChoreView_Accepted(sender As Object, e As EventArgs)
            Dim viewSender As CreateChoreView = sender
            Household.AddChore(viewSender.CreateChore)
            ChangeView(New ChoresView)
        End Sub

        'EditChoreView event handlers

        'HouseholdView events handlers

        'HousemateView event handlers

        'HousemateToDoListView

        'ToDoListView event handlers

        'ViewTaskView event handlers

        'ProfileView event handlers

        'EditProfileView event handlers

        'ChorePreferencesView eventhandlers

        'CurrentDistributionsView event handlers

        'ProposedDistributionView event handlers

        'CustomDistributionView event handlers

        'BulletinView event handlers

        'ViewTradeView event handlers

        'CreateTradeView event handlers

        'CreateCounterofferView event handlers

        'ViewCounterofferView event handlers

        'PollResultsView event handlers

        'VotePollView event handlers


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
    End Class
End NameSpace