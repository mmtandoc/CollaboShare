Imports System.ComponentModel
Imports CollaboShare

Public Class Chore
    Public defaultChores As List(Of String) = New List(Of String) From
        {"Laundry", "Shopping", "Cleaning", "Take out garbage", "Cooking"}

    Public Property Name As String
    Public Property Description As String
    Public Property Frequency As IRecurrence
    Public ReadOnly Property Duration As TimeSpan
        Get
            Dim totalDuration = Durations.Values.Sum(Function(t) t.TotalMinutes)
            Return TimeSpan.FromMinutes(totalDuration / Durations.Count)
        End Get
    End Property
    Public Property Durations As New Dictionary(Of String, TimeSpan)
    Public ReadOnly Property DueDate As Date
        Get
            Return Frequency.GetNextDate
        End Get
    End Property

    Public Property PeopleRequired As Integer
    Public Property Changes As New Dictionary(Of String, Chore)

    Public ReadOnly Property Rating As Integer
        Get
            Return CalculateRating()
        End Get
    End Property

    Public Sub New(name As String, description As String, frequency As IRecurrence, duration As TimeSpan, dueDate As DateTime, peopleRequired As Integer, editor As Housemate)
        Me.Name = name
        Me.Description = description
        Me.Frequency = frequency
        Durations.Add(editor.Name, duration)
        Me.PeopleRequired = peopleRequired
        Changes.Add(editor.Name, Me)
    End Sub

    Public Sub Edit(name As String, description As String, frequency As IRecurrence, duration As TimeSpan, dueDate As DateTime, peopleRequired As Integer, editor As Housemate)
        Me.Name = name
        Me.Description = description
        Me.Frequency = frequency
        Durations.Add(editor.Name, duration)
        Me.PeopleRequired = peopleRequired
        Changes.Add(editor.Name, Me)
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
