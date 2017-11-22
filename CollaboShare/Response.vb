Public Class Response
    Public Property Success As Boolean
    Public Property Message As String
    Public Property OriginalRequest As Request

    Public Sub New(success As Boolean, message As String, originalRequest As Request)
        Me.Success = success
        Me.Message = message
        Me.OriginalRequest = originalRequest
    End Sub

    Public Sub New(success As Boolean, originalRequest As Request)
        Me.Success = success
        Me.OriginalRequest = originalRequest
        If success Then
            Message = originalRequest.YesMessage
        Else
            Message = originalRequest.NoMessage
        End If
        'Select Case originalRequest.RequestedAction
        '    Case Request.RequestAction.JoinHousehold
        '        If success Then
        '            Message = "You have been accepted into the household."
        '        Else
        '            Message = "You were not accepted into the household."
        '        End If
        '    Case Request.RequestAction.ProposedDistribution
        '        If success Then
        '            Message = "You have been accepted into the household."
        '        Else
        '            Message = "You were not accepted into the household."
        '        End If
        '    Case Request.RequestAction.CustomDistribution
        '        If success Then
        '            Message = "You have been accepted into the household."
        '        Else
        '            Message = "You were not accepted into the household."
        '        End If
        '    Case Request.RequestAction.Trade
        '        If success Then
        '            Message = "You have been accepted into the household."
        '        Else
        '            Message = "You were not accepted into the household."
        '        End If
        '    Case Request.RequestAction.Excuse
        '        If success Then
        '            Message = "You have been accepted into the household."
        '        Else
        '            Message = "You were not accepted into the household."
        '        End If
        '    Case Request.RequestAction.Volunteer
        '        If success Then
        '            Message = "Your request to volunteer for the chore '" + CType(originalRequest.RequestedObject, Chore).Name + "' has been accepted."
        '        Else
        '            Message = "Your request to volunteer for the chore '" + CType(originalRequest.RequestedObject, Chore).Name + "' has been accepted."
        '        End If
        '    Case Request.RequestAction.Exclusion
        '        If success Then
        '            Message = "You have been accepted into the household."
        '        Else
        '            Message = "You were not accepted into the household."
        '        End If
        'End Select
    End Sub

End Class