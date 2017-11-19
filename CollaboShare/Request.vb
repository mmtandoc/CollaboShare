Public Class Request
    Public Enum RequestType
        YesNo
        ViewIgnore
    End Enum
    Public Enum RequestAction
        JoinHousehold
        Volunteer
        Exclusion
        Extension
        ProposedDistribution
        CustomDistribution
        Trade
        Excuse
    End Enum
    Public Property Sender As Housemate
    Public Property Recipients As List(Of Housemate)
    Public Property Type As RequestType
    Public Property Message As String
    Public Property RequestedAction As RequestAction
    Public Property RequestedObject
    Public Property ViewPage As View = Nothing
    Public Property ViewObject = Nothing

    Public Property YesMessage As String
    Public Property NoMessage As String

    Public Class JoinHouseholdRequest
        Inherits Request

        Public Sub New(ByRef sender As Housemate, ByRef household As Household)
            Me.Sender = sender
            RequestedObject = household
            Recipients = household.Housemates
            Message = sender.Name + " would like to join your household."
            Type = RequestType.YesNo
            RequestedAction = RequestAction.JoinHousehold

            YesMessage = "You have been accepted into the household."
            NoMessage = "You were not accepted into the household"

        End Sub
    End Class
    Public Class VolunteerRequest
        Inherits Request

        Public Sub New(ByRef sender As Housemate, ByRef household As Household, ByRef chore As Chore)
            Me.Sender = sender
            RequestedObject = chore
            Recipients = household.Housemates.FindAll(Function(h) Not h.Name.Equals(Me.Sender.Name))
            Message = sender.Name & " would like to volunteer for chore '" & chore.Name + "'."
            RequestedAction = RequestAction.Volunteer
            Type = RequestType.YesNo

            YesMessage = "Your request to volunteer for chore '" + chore.Name + "' was accepted."
            YesMessage = "Your request to volunteer for chore '" + chore.Name + "' was refused."
        End Sub
    End Class

    Public Class ExtensionRequest
        Inherits Request
        Public Sub New(ByRef sender As Housemate, ByRef household As Household, ByRef task As ToDoList.Task, extensionDays As Integer)
            Me.Sender = sender
            RequestedObject = New Tuple(Of ToDoList.Task, Integer)(task, extensionDays)
            Message = sender.Name + " would like to extend the task '" + task.RelatedChore.Name + "' from " + task.Instance.ToShortDateString() + " to " + task.Instance.AddDays(extensionDays).ToShortDateString + "."
            Recipients = household.Housemates.FindAll(Function(h) Not h.Name.Equals(Me.Sender.Name))
            RequestedAction = RequestAction.Extension
            Type = RequestType.YesNo

            YesMessage = "Your request to extend your task '" + task.RelatedChore.Name + "' from " + task.Instance.ToShortDateString() + " to " + task.Instance.AddDays(extensionDays).ToShortDateString + " was accepted."
            YesMessage = "Your request to extend your task '" + task.RelatedChore.Name + "' from " + task.Instance.ToShortDateString() + " to " + task.Instance.AddDays(extensionDays).ToShortDateString + " was refused."
        End Sub
    End Class

    Public Function GetResponse(accepted As Boolean)
        If accepted Then
            Return New Response(True, YesMessage, Me)
        Else
            Return New Response(False, NoMessage, Me)
        End If
    End Function


End Class

Public Class RequestEventArgs
    Inherits EventArgs
    Public Property Request As Request
    Public Sub New(request As Request)
        Me.Request = request
    End Sub

End Class
