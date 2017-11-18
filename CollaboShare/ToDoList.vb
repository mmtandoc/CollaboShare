Public Class ToDoList
    Inherits List(Of Task)
    Public Class Task
        Public Property RelatedChore As Chore
        Public Property Instance As DateTime
        Public Property Completed As Boolean = False

        Public Sub New(ByRef relatedChore As Chore, instance As DateTime)
            Me.RelatedChore = relatedChore
            Me.Instance = instance
        End Sub

    End Class
End Class


