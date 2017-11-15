Public Class Notification

End Class

Public Class RequestEventArgs
    Inherits EventArgs
    Public Property Request As Request
    Public Sub New(request As Request)
        Me.Request = request
    End Sub

End Class

Public Class Request
    Public Enum RequestType
        YesNo
        ViewIgnore
    End Enum
    Public Enum RequestAction
        JoinHousehold
        Volunteer
        Exclusion
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
    Public Property ViewPage As View
    Public Property ViewObject

    Public Class JoinHouseholdRequest
        Inherits Request

        Public Sub New(ByRef sender As Housemate, ByRef household As Household)
            Me.Sender = sender
            RequestedObject = household
            Me.Recipients = household.Housemates
            Me.Message = sender.Name + " would like to join your household."
            Me.Type = RequestType.YesNo
            Me.RequestedAction = RequestAction.JoinHousehold
            ViewPage = Nothing
            ViewObject = Nothing
        End Sub
    End Class
    Public Class VolunteerRequest
        Inherits Request

        Public Sub New(ByRef sender As Housemate, ByRef household As Household, ByRef chore As Chore)
            Me.Sender = sender
            RequestedObject = chore
            Me.Recipients = household.Housemates.FindAll(Function(h) h.Name.Equals(Me.Sender.Name))
            RequestedAction = RequestAction.Volunteer
            Type = RequestType.YesNo
            ViewPage = Nothing
            ViewObject = Nothing
        End Sub
    End Class


End Class

Public Class Response
    Public Property Success As Boolean
    Public Property Message As String

    Public Sub New(success As Boolean, message As String)
        Me.Success = success
        Me.Message = message
    End Sub
End Class
