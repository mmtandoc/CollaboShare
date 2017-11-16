Imports CollaboShare_Prototype_1

Public Class Chore
    Public defaultChores As List(Of String) = New List(Of String) From
        {"Laundry", "Shopping", "Cleaning", "Take out garbage", "Cooking"}

    Public Property Name As String

    Public Property Description As String

    Public Property Frequency As IRecurrence

    Public Property Duration As TimeSpan

    Public Property DueDate As Date

    Public Property PeopleRequired As Integer

    Public ReadOnly Property Rating As Integer
        Get
            Return CalculateRating()
        End Get
    End Property

    Public Sub New(name As String, description As String, frequency As IRecurrence, duration As TimeSpan, dueDate As DateTime, peopleRequired As Integer)
        Me.Name = name
        Me.Description = description
        Me.Frequency = frequency
        Me.Duration = duration
        Me.DueDate = dueDate
        Me.PeopleRequired = peopleRequired
    End Sub

    Private Function CalculateRating() As Integer
        Dim frequencyWeight = 1
        Dim durationWeight = 1
        Dim peopleRequiredWeight = 1

        'Dim rating = (durationWeight * Duration.TotalMinutes) / ((peopleRequiredWeight * PeopleRequired) * (frequencyWeight * Recurrence.Value))
        Dim rating = 5

        Return rating
    End Function

End Class
