Public Class Poll
    Public Property Question As String
    Public Property Choices As New Dictionary(Of String, List(Of Housemate))
    
    Public Sub New(choices As List(Of String))
        For Each c As String In choices
            Me.Choices.Add(c, New List(Of Housemate))
        Next
    End Sub
    
    Public Sub Vote(choice As String, voter As Housemate)
        If Choices.Any(Function(pair) pair.Value.Contains(voter))
            Choices.Where(Function(pair) pair.Value.Contains(voter)).First.Value.Remove(voter)            
        End If  
        Choices(choice).Add(voter)
        Choices = Choices.OrderByDescending(Function(x) x.Value.Count)
    End Sub
    
    Public Function Results() As Dictionary(Of String, Integer)
        Return Choices.Select(Function(pair) New KeyValuePair(Of String, integer)(pair.Key, pair.Value.Count)).OrderByDescending(Function(x) x.Value)
    End Function

End Class
