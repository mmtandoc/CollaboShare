Public Class Offer
    Public Property Chores As New List(Of ToDoList.Task)
    Public Property Creator As Housemate

    Public Property Counteroffers As New List(Of Counteroffer)

    Public Sub New(ByRef creator As Housemate, chores As List(Of ToDoList.Task))
        Me.Chores.AddRange(chores)
        Me.Creator = creator
    End Sub

    Public Class Counteroffer
        Public Property Chores As New List(Of Chore)
        Public Property Creator As Housemate
        Public Sub New(ByRef creator As Housemate, ParamArray chores() As Chore)
            Me.Chores.AddRange(chores)
            Me.Creator = creator
        End Sub
    End Class
End Class
