Imports CollaboShare

Public Interface IRecurrence
    Property StartDate As DateTime
    Property Interval As Integer

    Function GetNextDate() As DateTime

    Function GetNextDate(afterDate As DateTime) As DateTime

End Interface


Public Class DailyRecurrence
    Implements IRecurrence
    Public Property StartDate As Date Implements IRecurrence.StartDate
    Public Property Interval As Integer Implements IRecurrence.Interval

    Public Sub New(startDate As DateTime, interval As Integer)
        Me.StartDate = startDate
        Me.Interval = interval
    End Sub

    Public Function GetNextDate() As DateTime Implements IRecurrence.GetNextDate
        Return GetNextDate(DateTime.Now)
    End Function

    Public Function GetNextDate(afterDate As DateTime) As DateTime Implements IRecurrence.GetNextDate
        Dim nextDate As DateTime = _StartDate
        While nextDate.CompareTo(afterDate) > 0
            nextDate = nextDate.AddDays(_Interval)
        End While
        Return nextDate
    End Function
End Class

Public Class WeeklyRecurrence
    Implements IRecurrence
    Public Enum DayOfWeek
        Sunday
        Monday
        Tuesday
        Wednesday
        Thursday
        Friday
        Saturday
    End Enum

    Public Property DaysOfWeek As Boolean() = New Boolean() {False, False, False, False, False, False, False}

    Public Property StartDate As Date Implements IRecurrence.StartDate

    Public Property Interval As Integer Implements IRecurrence.Interval

    Public Sub New(startDate As DateTime, interval As Integer)
        Me.StartDate = startDate
        Me.Interval = interval
        Me.DaysOfWeek.SetValue(True, startDate.DayOfWeek)
    End Sub

    Public Sub New(startDate As DateTime, interval As Integer, daysOfWeek() As Boolean)
        Me.StartDate = startDate
        Me.Interval = interval
        Me.DaysOfWeek = daysOfWeek
    End Sub

    Public Function GetNextDate() As DateTime Implements IRecurrence.GetNextDate
        Return GetNextDate(DateTime.Now)
    End Function

    Public Function GetNextDate(afterDate As DateTime) As DateTime Implements IRecurrence.GetNextDate
        Return DateTime.Now
    End Function
End Class

Public Class MonthlyRecurrence
    Implements IRecurrence

    Public Property StartDate As Date Implements IRecurrence.StartDate

    Public Property Interval As Integer Implements IRecurrence.Interval

    Public Sub New(startDate As DateTime, interval As Integer)
        Me.StartDate = startDate
        Me.Interval = interval
    End Sub

    Public Function GetNextDate() As DateTime Implements IRecurrence.GetNextDate
        Return GetNextDate(DateTime.Now)
    End Function

    Public Function GetNextDate(afterDate As DateTime) As DateTime Implements IRecurrence.GetNextDate
        Dim nextDate As DateTime = _StartDate
        While nextDate.CompareTo(afterDate) > 0
            nextDate = nextDate.AddMonths(_Interval)
        End While
        Return nextDate
    End Function
End Class

Public Class YearlyRecurrence
    Implements IRecurrence
    Public Property Interval As Integer Implements IRecurrence.Interval
    Public Property StartDate As DateTime Implements IRecurrence.StartDate

    Public Sub New(startDate As DateTime, interval As Integer)
        Me.StartDate = startDate
        Me.Interval = interval
    End Sub

    Public Function GetNextDate() As DateTime Implements IRecurrence.GetNextDate
        Return GetNextDate(DateTime.Now)
    End Function

    Public Function GetNextDate(afterDate As DateTime) As DateTime Implements IRecurrence.GetNextDate
        Dim nextDate As DateTime = Me.StartDate
        While nextDate.CompareTo(afterDate) > 0
            nextDate = nextDate.AddYears(Me.Interval)
        End While
        Return nextDate
    End Function
End Class

