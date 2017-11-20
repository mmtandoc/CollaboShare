Public Class Offer
    Public Property OfferedInstances As New List(Of Instance)
    Public Property Creator As Housemate

    Public Property Counteroffers As New List(Of Counteroffer)

    Public Sub New(ByRef creator As Housemate, ParamArray offeredInstances() As Instance)
        'Me.Chores.AddRange(Chores)
        Me.Creator = creator
    End Sub

    Public Class Counteroffer
        Public Property OfferedInstances As New List(Of Instance)
        Public Property Creator As Housemate
        Public Sub New(ByRef creator As Housemate, ParamArray offeredInstances() As Instance)
            'Me.Chores.AddRange(Chores)
            Me.Creator = creator
        End Sub
    End Class
End Class
