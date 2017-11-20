Imports CollaboShare

Public Class ToDoList
    Inherits List(Of Task)

    Public Class Task
        Implements IComparable(Of Task)

        Public Property RelatedChore As Chore
        Public Property Instance As DateTime
        Public ReadOnly Property DueDate As DateTime
            Get
                Return Instance.AddDays(ExtensionDays)
            End Get
        End Property
        Public Property ExtensionDays As Integer = 0
        Public Property Completed As Boolean = False

        Public Sub New(ByRef relatedChore As Chore, instance As DateTime)
            Me.RelatedChore = relatedChore
            Me.Instance = instance
        End Sub

        Public Function CompareTo(other As Task) As Integer Implements IComparable(Of Task).CompareTo
            Return DueDate.CompareTo(other.DueDate)
        End Function

        Public Overrides Function ToString() As String
            Return RelatedChore.Name + " (" + Instance.ToShortDateString() + ")"
        End Function
    End Class
End Class


