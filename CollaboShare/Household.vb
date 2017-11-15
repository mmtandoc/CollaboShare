Public Class Household
    Public Property Name As String
    Public Property Address As String
    Public Property Housemates As List(Of Housemate) = New List(Of Housemate)
    Public Property Chores As List(Of Chore) = New List(Of Chore)

    Public Sub New(ByVal name, Optional ByVal address = "")
        Me.Name = name
        Me.Address = address
    End Sub

    Public Sub New()
    End Sub

    Public Function RequestJoin(ByRef newHousemate)
        Dim answers As List(Of Boolean) = New List(Of Boolean)
        For Each housemate As Housemate In Housemates
            'answer = housemate.ReceiveRequest(Requests.JoinHousehold)
            Dim answer = True
            answers.Add(answer)
        Next

        Return Not answers.Contains(True)
    End Function

    Public Sub AddHousemate(ByRef housemate)
        Housemates.Add(housemate)
    End Sub

    Public Sub RemoveHousemate(ByRef removedHousemate)
        Housemates.Remove(removedHousemate)
    End Sub

    Public Sub AddChore(ByRef newChore)
        Chores.Add(newChore)
    End Sub

    Public Sub RemoveChore(ByRef removedChore)
        Chores.Remove(removedChore)
    End Sub

    Public Sub DistributeChores()

    End Sub
End Class