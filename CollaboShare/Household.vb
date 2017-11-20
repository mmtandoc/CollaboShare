Public Class Household
    Public Property Name As String
    Public Property Address As String
    Public Property Housemates As List(Of Housemate) = New List(Of Housemate)
    Public Property Chores As List(Of Chore) = New List(Of Chore)

    Private _Distribution As Distribution = Nothing
    Public Property Distribution As Distribution
        Get
            Return _Distribution
        End Get
        Set
            _Distribution = Value
            UpdateToDoLists()
        End Set
    End Property


    Public Sub New(ByVal name, Optional ByVal address = "")
        Me.Name = name
        Me.Address = address
    End Sub

    Public Sub New()
    End Sub

    Public Sub RemoveHousemate(ByRef housemate As Housemate)
        If Housemates.Contains(housemate) Then
            For Each c As Chore In Chores
                If c.Volunteer.Equals(housemate) Then
                    c.Volunteer = Nothing
                End If
                If c.Exclusions.Contains(housemate) Then
                    c.Exclusions.Remove(housemate)
                End If
            Next
            Housemates.Remove(housemate)
        End If
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

    Public Function DistributeChores() As Distribution
        Return New Distribution(Me)
    End Function

    Public Sub UpdateToDoLists()
        If Not IsNothing(Distribution) Then
            For Each c As KeyValuePair(Of Chore, SortedDictionary(Of Instance, Housemate)) In Distribution.ChoreInstances
                For Each i As KeyValuePair(Of Instance, Housemate) In c.Value
                    Dim task As New ToDoList.Task(c.Key, i.Key.GetNextDate)
                    i.Value.ToDoList.Add(task)
                Next
            Next
        End If
    End Sub

End Class