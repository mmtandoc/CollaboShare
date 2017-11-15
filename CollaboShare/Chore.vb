Imports CollaboShare_Prototype_1

Public Class Chore
    Public defaultChores As List(Of String) = New List(Of String) From
        {"Laundry", "Shopping", "Cleaning", "Take out garbage", "Cooking"}



    Private nameValue As String
    Private descriptionValue As String
    Private frequencyValue As Recurrence
    Private durationValue As TimeSpan
    Private dueDateValue As DateTime
    Private peopleRequiredValue As Integer

    Public Property Name As String
        Get
            Return nameValue
        End Get
        Set(value As String)
            nameValue = value
        End Set
    End Property

    Public Property Description As String
        Get
            Return descriptionValue
        End Get
        Set(value As String)
            descriptionValue = value
        End Set
    End Property

    Public Property Frequency As Recurrence
        Get
            Return frequencyValue
        End Get
        Set(value As Recurrence)
            frequencyValue = value
        End Set
    End Property

    Public Property Duration As TimeSpan
        Get
            Return durationValue
        End Get
        Set(value As TimeSpan)
            durationValue = value
        End Set
    End Property

    Public Property DueDate As Date
        Get
            Return dueDateValue
        End Get
        Set(value As Date)
            dueDateValue = value
        End Set
    End Property

    Public Property PeopleRequired As Integer
        Get
            Return peopleRequiredValue
        End Get
        Set(value As Integer)
            peopleRequiredValue = value
        End Set
    End Property

    Public ReadOnly Property Rating As Integer
        Get
            Return CalculateRating()
        End Get
    End Property

    Public Sub New(name As String, description As String, frequency As Recurrence, duration As TimeSpan, dueDate As DateTime, peopleRequired As Integer)
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
