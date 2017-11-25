Imports CollaboShare.UI

Public Class Household
    Public Property Name As String
    Public Property Address As String
    Public Property Housemates As List(Of Housemate) = New List(Of Housemate)
    Public Property Chores As List(Of Chore) = New List(Of Chore)

    Public Property TradeOffers As New List(Of Offer)
    
    Public Property CurrentPolls As New SortedDictionary(Of Date, Poll)
    
    Public Property PastPolls As New SortedDictionary(Of Date, Poll)

    Private _Distribution As Distribution = Nothing
    Public Property Distribution As Distribution
        Get
            Return _Distribution
        End Get
        Set
            _Distribution = Value
            UpdateToDoLists()
            TradeOffers.Clear
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
        Dim choreInstances As New Dictionary(Of Chore, SortedDictionary(Of Instance, Housemate))
        Dim rng As New Random()
        For Each c As Chore In Me.Chores
            choreInstances(c) = New SortedDictionary(Of Instance, Housemate)
            Dim instances As List(Of Instance) = c.Frequency.GetInstances
            For Each i As Instance In instances
                Dim randomHousemate = Me.Housemates(rng.Next(0, Me.Housemates.Count))
                choreInstances(c).Add(i, randomHousemate)
            Next
        Next
        Return New Distribution(choreInstances)
    End Function

    Public Sub UpdateToDoLists()
        For Each h As Housemate In Me.Housemates
            h.ToDoList.Clear()
        Next
        If Not IsNothing(Distribution) Then
            For Each c As KeyValuePair(Of Chore, SortedDictionary(Of Instance, Housemate)) In Distribution.ChoreInstances
                Dim task As New ToDoList.Task(c.Key, c.Value.First.Key.GetNextDate)
                c.Value.First.Value.ToDoList.Add(task)
                'For Each i As KeyValuePair(Of Instance, Housemate) In c.Value
                '    Dim task As New ToDoList.Task(c.Key, i.Key.GetNextDate)
                '    i.Value.ToDoList.Add(task)
                'Next
            Next
        End If
    End Sub
    
    Public Sub Trade(offer As Offer, counteroffer As Offer.Counteroffer)
        Dim housemate1 = offer.Creator
        Dim housemate2 = counteroffer.Creator
        
        Dim changes As New Dictionary(Of Chore, SortedDictionary(Of Instance, Housemate))

        For Each o In offer.OfferedInstances
            Dim instances = Distribution.ChoreInstances.Item(o.Key).Where(Function(pair) o.Value.Contains(pair.Key))
            If Not changes.ContainsKey(o.Key) Then
                changes.Add(o.Key, New SortedDictionary(Of Instance,Housemate))
            End If
            
            For Each i In instances
                changes(o.Key).Add(i.Key, housemate2)
            Next
        Next
        
        For Each o In counteroffer.OfferedInstances
            Dim instances = Distribution.ChoreInstances.Item(o.Key).Where(Function(pair) o.Value.Contains(pair.Key))
            If Not changes.ContainsKey(o.Key) Then
                changes.Add(o.Key, New SortedDictionary(Of Instance,Housemate))
            End If
            For Each i In instances
                changes(o.Key).Add(i.Key, housemate1)
            Next
        Next
        
        For Each c In changes
            For Each i In c.Value
                Distribution.ChoreInstances(c.Key)(i.Key) = i.Value
            Next
        Next
        
    End Sub

End Class