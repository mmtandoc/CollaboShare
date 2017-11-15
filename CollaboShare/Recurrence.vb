Public Class Recurrence

    Public Class DailyRecurrence
        Inherits Recurrence
        Private _startDate As DateTime
        Private _interval As Integer

        Public Sub New(startDate As DateTime, interval As Integer)
            _startDate = startDate
            _interval = interval
        End Sub

        Public Function GetNextDate()
            Return GetNextDate(DateTime.Now)
        End Function

        Public Function GetNextDate(afterDate As DateTime) As DateTime
            Dim nextDate As DateTime = _startDate
            While nextDate.CompareTo(afterDate) > 0
                nextDate = nextDate.AddDays(_interval)
            End While
            Return nextDate
        End Function
    End Class

    Public Class WeeklyRecurrence
        Inherits Recurrence
        Public Enum DayOfWeek
            Sunday
            Monday
            Tuesday
            Wednesday
            Thursday
            Friday
            Saturday
        End Enum

        Private _startDate As DateTime
        Private _interval As Integer
        Private _daysOfWeek As Boolean() = New Boolean() {False, False, False, False, False, False, False}

        Public Sub New(startDate As DateTime, interval As Integer)
            _startDate = startDate
            _interval = interval
            _daysOfWeek.SetValue(True, startDate.DayOfWeek)
        End Sub

        Public Sub New(startDate As DateTime, interval As Integer, daysOfWeek() As Boolean)
            _startDate = startDate
            _interval = interval
            _daysOfWeek = daysOfWeek
        End Sub

        Public Function GetNextDate()
            Return GetNextDate(DateTime.Now)
        End Function

        Public Function GetNextDate(afterDate As DateTime) As DateTime
            Return DateTime.Now
        End Function
    End Class

    Public Class MonthlyRecurrence
        Inherits Recurrence
        Private _startDate As DateTime
        Private _interval As Integer

        Public Sub New(startDate As DateTime, interval As Integer)
            _startDate = startDate
            _interval = interval
        End Sub

        Public Function GetNextDate()
            Return GetNextDate(DateTime.Now)
        End Function

        Public Function GetNextDate(afterDate As DateTime) As DateTime
            Dim nextDate As DateTime = _startDate
            While nextDate.CompareTo(afterDate) > 0
                nextDate = nextDate.AddMonths(_interval)
            End While
            Return nextDate
        End Function
    End Class

    Public Class YearlyRecurrence
        Inherits Recurrence
        Private _startDate As DateTime
        Private _interval As Integer

        Public Sub New(startDate As DateTime, interval As Integer)
            _startDate = startDate
            _interval = interval
        End Sub

        Public Function GetNextDate()
            Return GetNextDate(DateTime.Now)
        End Function

        Public Function GetNextDate(afterDate As DateTime) As DateTime
            Dim nextDate As DateTime = _startDate
            While nextDate.CompareTo(afterDate) > 0
                nextDate = nextDate.AddYears(_interval)
            End While
            Return nextDate
        End Function
    End Class
End Class

