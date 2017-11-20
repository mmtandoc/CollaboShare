Public Class Distribution

    Public Property Household As Household
    Public Property ChoreInstances As New Dictionary(Of Chore, SortedDictionary(Of Instance, Housemate))

    Public Sub New(choreInstances As Dictionary(Of Chore, SortedDictionary(Of Instance, Housemate)))
        Me.ChoreInstances = choreInstances
    End Sub

    Public Sub New(ByRef household As Household)
        Me.Household = household
        For Each c As Chore In household.Chores
            ChoreInstances(c) = New SortedDictionary(Of Instance, Housemate)
            Dim instances As List(Of Instance) = c.Frequency.GetInstances
            For Each i As Instance In instances
                ChoreInstances(c).Add(i, Nothing)
            Next
        Next
    End Sub

End Class

Public Class Instance
    Implements IComparable(Of Instance)

    Public Property Recurrence As IRecurrence
    Public Property Value As Integer

    Private Property DateInterval As DateInterval

    Public Sub New(recurrence As IRecurrence, value As Integer)
        Me.Recurrence = recurrence
        Me.Value = value
        Select Case recurrence.GetType
            Case GetType(DailyRecurrence)
                DateInterval = DateInterval.Weekday
            Case GetType(WeeklyRecurrence)
                DateInterval = DateInterval.Weekday
            Case GetType(MonthlyRecurrence)
                DateInterval = DateInterval.Day
            Case Else
                DateInterval = DateInterval.DayOfYear
        End Select
    End Sub

    Public Function GetNextDate()
        Return GetNextDate(DateTime.Now.Date)
    End Function

    Public Function GetNextDate(afterDate As DateTime)

        Dim start = afterDate
        Dim nextDate = Recurrence.GetNextDate(start)
        Do Until DatePart(DateInterval, nextDate) = Value
            nextDate = Recurrence.GetNextDate(nextDate)
        Loop
        Return nextDate
    End Function

    Public Function CompareTo(other As Instance) As Integer Implements IComparable(Of Instance).CompareTo
        Return Value.CompareTo(other.Value)
    End Function

    Public Overrides Function ToString() As String
        Select Case Recurrence.GetType
            Case GetType(DailyRecurrence)
                Return WeekdayName(Value)
            Case GetType(WeeklyRecurrence)
                Return WeekdayName(Value)
            Case GetType(MonthlyRecurrence)
                Return Recurrence.ToString
            Case Else
                Return Recurrence.ToString
        End Select
    End Function

End Class
