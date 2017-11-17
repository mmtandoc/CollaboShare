Public Class State
    Public Property Households As New List(Of Household)
    Public Property SubjectA As UserState

    Public Property SubjectB As UserState

    Public Sub New(households As List(Of Household), subjectAState As UserState, subjectBState As UserState)
        Me.Households = households
        Me.SubjectA = subjectAState
        Me.SubjectB = subjectBState
    End Sub

    Public Class UserState
        Public Property JoinedHousehold As Household = Nothing
        Public Property Profile As Housemate = Nothing

        Public Sub New()

        End Sub

        Public Sub New(ByRef joinedHousehold As Household, ByRef profile As Housemate)
            Me.JoinedHousehold = joinedHousehold
            Me.Profile = profile
        End Sub

        Public Function IsEmpty() As Boolean
            If IsNothing(JoinedHousehold) And IsNothing(Profile) Then
                Return True
            Else
                Return False
            End If
        End Function

    End Class
End Class
