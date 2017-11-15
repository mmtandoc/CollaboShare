Imports CollaboShare_Prototype_1.Request

Public Class PhoneForm
    Public Event RequestSend As EventHandler
    Public Event NotificationSend As EventHandler

    Public Enum Views
        CreateUserView
        JoinHouseholdView
        CreateHouseholdView
        HomeView
        ChoresView
        CreateChoreView
        EditChoreView
        ToDoListView
        BulletinView
        ProfileView
        HouseholdView
    End Enum

    Private dialogControlResult As DialogResult = DialogResult.None

    Public Property Households As List(Of Household)

    Public Property Household As Household

    Public Property Profile As Housemate

    Private firstRun As Boolean = True
    Private pastViews As Stack(Of Views)


    Public Sub New(ByRef households As List(Of Household))
        Me.New(households, New State.UserState())
    End Sub

    Public Sub New(ByRef households As List(Of Household), userState As State.UserState)
        Me.Households = households
        If userState.IsEmpty Then
            Me.firstRun = True
        Else
            firstRun = False
            Me.Profile = userState.Profile
            Me.Household = userState.JoinedHousehold
        End If
        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub

    Public Sub ChangeView(newView As Views)
        Dim viewControl As Control = Nothing

        If newView = Views.JoinHouseholdView Or newView = Views.CreateUserView Or newView = Views.HomeView Then
            NavPanel.Visible = False
        Else
            NavPanel.Visible = True
        End If

        Select Case newView
            Case Views.CreateUserView
                viewControl = New CreateUserView()
                AddHandler CType(viewControl, CreateUserView).Confirmed, AddressOf CreateUserView_Confirmed
            Case Views.JoinHouseholdView
                viewControl = New JoinHouseholdView()
                AddHandler CType(viewControl, JoinHouseholdView).RequestingHousehold, AddressOf JoinHouseholdView_JoiningHousehold
                AddHandler CType(viewControl, JoinHouseholdView).CreatingHousehold, AddressOf JoinHouseholdView_CreatingHousehold
            Case Views.CreateHouseholdView
                viewControl = New CreateHouseholdView()
                AddHandler CType(viewControl, CreateHouseholdView).Cancelled, AddressOf CreateHouseholdView_Cancelled
                AddHandler CType(viewControl, CreateHouseholdView).Confirmed, AddressOf CreateHouseholdView_Confirmed
            Case Views.HomeView
                viewControl = New HomeView()
                AddHandler CType(viewControl, HomeView).HouseholdButton.Click, Sub(s As Object, e As EventArgs) ChangeView(Views.HouseholdView)
                AddHandler CType(viewControl, HomeView).ChoresButton.Click, Sub(s As Object, e As EventArgs) ChangeView(Views.ChoresView)
                AddHandler CType(viewControl, HomeView).MyProfileButton.Click, Sub(s As Object, e As EventArgs) ChangeView(Views.ProfileView)
                AddHandler CType(viewControl, HomeView).ToDoListButton.Click, Sub(s As Object, e As EventArgs) ChangeView(Views.ToDoListView)
                AddHandler CType(viewControl, HomeView).BulletinButton.Click, Sub(s As Object, e As EventArgs) ChangeView(Views.BulletinView)
            Case Views.ChoresView
                viewControl = New ChoresView
            Case Views.CreateChoreView
                viewControl = New CreateChoreView
        End Select

        If Not IsNothing(viewControl) Then
            ViewPanel.Controls.Clear()
            ViewPanel.Controls.Add(viewControl)
        End If

    End Sub

    Public Sub PreviousView()
        ChangeView(pastViews.Pop())
    End Sub

    'Public Async Function ShowDialogControl(dialogControl As IDialogControl) As Task(Of DialogResult)
    '    AddHandler dialogControl.Closing, AddressOf DialogControl_Closing
    '    Me.Controls.Add(dialogControl)
    '    DirectCast(dialogControl, Control).BringToFront()
    '    Dim getResultTask As DialogResult = Await Task.Run(Function()
    '                                                           Dim dialog As IDialogControl = Me.Controls.Item(Me.Controls.IndexOf(dialogControl))
    '                                                           Do Until Not (dialog.DialogResult = DialogResult.None)

    '                                                           Loop
    '                                                           Return dialog.DialogResult
    '                                                       End Function)
    '    MsgBox(getResultTask.ToString)
    '    Return getResultTask
    'End Function

    Public Async Function ShowRequestControl(requestControl As RequestControl) As Task(Of DialogResult)
        'AddHandler requestControl.Close, AddressOf RequestControl_Close
        Me.Controls.Add(requestControl)
        DirectCast(requestControl, Control).BringToFront()
        Dim getResultTask As DialogResult = Await Task.Run(Function()
                                                               Do Until Not (requestControl.DialogResult = DialogResult.None)

                                                               Loop
                                                               Return requestControl.DialogResult
                                                           End Function)
        MsgBox(getResultTask.ToString)
        Me.Controls.Remove(requestControl)
        Return getResultTask
    End Function

    Public Async Sub ShowResponseControl(responseControl As ResponseControl)
        'AddHandler responseControl.Close, AddressOf RequestControl_Close
        Me.Controls.Add(responseControl)
        DirectCast(responseControl, Control).BringToFront()
        Await Task.Run(Sub()
                           Do Until responseControl.Closed

                           Loop
                       End Sub)
        Me.Controls.Remove(responseControl)
    End Sub

    Public Async Sub ShowNotificationControl(notificationControl As NotificationControl)
        'AddHandler responseControl.Close, AddressOf RequestControl_Close
        Me.Controls.Add(notificationControl)
        DirectCast(notificationControl, Control).BringToFront()
        Await Task.Run(Sub()
                           Do Until notificationControl.Closed

                           Loop
                       End Sub)
        Me.Controls.Remove(notificationControl)
    End Sub

    Public Sub ReceiveResponse(response As Response)
        ShowResponseControl(New ResponseControl(response))
        Select Case response.OriginalRequest.RequestedAction
            Case RequestAction.JoinHousehold
                ShowResponseControl(New ResponseControl(response))
                If response.Success Then
                    ChangeView(Views.HomeView)
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
            ChangeView(Views.CreateUserView)
        Else
            ChangeView(Views.HomeView)
        End If
    End Sub


    'CreateUserView event handlers

    Public Sub CreateUserView_Confirmed(sender As Object, e As EventArgs)
        Dim view As CreateUserView = sender
        Me.Profile = New Housemate(view.FullNameTextBox.Text, view.PhoneNumberTextBox.Text, view.EmailAddressTextBox.Text, New Bitmap(50, 60))
        ChangeView(Views.JoinHouseholdView)
    End Sub


    'JoinHouseholdView event handlers

    Public Sub JoinHouseholdView_JoiningHousehold(sender As Object, e As EventArgs)
        RaiseEvent RequestSend(Me, e)
        Dim joinHouseholdE As RequestEventArgs = e
        Household = joinHouseholdE.Request.RequestedObject
    End Sub

    Public Sub JoinHousehold(ByRef household As Household)
        household.AddHousemate(Me.Profile)
        Me.Household = household
        ChangeView(Views.CreateHouseholdView)
    End Sub

    Public Sub JoinHouseholdView_CreatingHousehold(sender As Object, e As EventArgs)
        ChangeView(Views.CreateHouseholdView)
    End Sub

    'CreateHouseholdView event handlers

    Public Sub CreateHouseholdView_Confirmed(sender As Object, e As EventArgs)
        Dim viewSender As CreateHouseholdView = sender
        Me.Household = New Household(viewSender.NameTextBox.Text, viewSender.AddressTextBox.Text)
        ChangeView(Views.HomeView)
    End Sub

    Public Sub CreateHouseholdView_Cancelled(sender As Object, e As EventArgs)
        ChangeView(Views.JoinHouseholdView)
    End Sub

    'HomeView event handlers

    'ChoresView event handlers

    'ViewChoreView events handlers

    'CreateChoreView event handlers

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
        ChangeView(Views.ProfileView)
    End Sub

    Private Sub ChoresButton_Click(sender As Object, e As EventArgs) Handles ChoresButton.Click
        ChangeView(Views.ChoresView)
    End Sub

    Private Sub TodoListButton_Click(sender As Object, e As EventArgs) Handles TodoListButton.Click
        ChangeView(Views.ToDoListView)
    End Sub

    Private Sub HouseholdButton_Click(sender As Object, e As EventArgs) Handles HouseholdButton.Click
        ChangeView(Views.HouseholdView)
    End Sub

    Private Sub BulletinButton_Click(sender As Object, e As EventArgs) Handles BulletinButton.Click
        ChangeView(Views.BulletinView)
    End Sub

End Class
