Public Class Offer
    Public Property OfferedInstances As New Dictionary(Of Chore, List(Of Instance))
    Public Property Creator As Housemate

    Public Property Counteroffers As New List(Of Counteroffer)

    Public Sub New(ByRef creator As Housemate, offeredInstances As Dictionary(Of Chore, List(Of Instance)))
        'Me.Chores.AddRange(Chores)
        Me.Creator = creator
        Me.OfferedInstances = offeredInstances
    End Sub

    Public Class Counteroffer
        Public Property OfferedInstances As New Dictionary(Of Chore, List(Of Instance))
        Public Property Creator As Housemate
        Public Sub New(ByRef creator As Housemate, offeredInstances As Dictionary(Of Chore, List(Of Instance)))
            'Me.Chores.AddRange(Chores)
            Me.Creator = creator
            Me.OfferedInstances = offeredInstances
        End Sub
    End Class
    
End Class
