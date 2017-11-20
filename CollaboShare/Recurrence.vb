
Imports System.Runtime.CompilerServices

Public Interface IRecurrence
    Property StartDate As DateTime
    Property Interval As Integer

    Function GetNextDate() As DateTime

    Function GetNextDate(afterDate As DateTime) As DateTime

    Function GetAverageFrequency() As TimeSpan

    Function GetInstances() As List(Of Instance)

    Function ToString() As String
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
        Return GetNextDate(DateTime.Now.Date)
    End Function

    Public Function GetNextDate(afterDate As DateTime) As DateTime Implements IRecurrence.GetNextDate
        Dim nextDate As DateTime = _StartDate
        While nextDate.Date.CompareTo(afterDate.Date) <= 0
            nextDate = nextDate.AddDays(Interval)
        End While
        Return nextDate
    End Function

    Public Function GetAverageFrequency() As TimeSpan Implements IRecurrence.GetAverageFrequency
        Return TimeSpan.FromDays(Interval)
    End Function

    Public Function GetInstances() As List(Of Instance) Implements IRecurrence.GetInstances
        Dim instances As New List(Of Instance)
        For i = 0 To 6
            instances.Add(New Instance(Me, i + 1))
        Next
        Return instances
    End Function

    Public Overrides Function ToString() As String Implements IRecurrence.ToString
        If Interval = 1 Then
            Return "Repeats every day"
        Else
            Return String.Format("Repeats every {0} days", Interval)
        End If
    End Function
End Class

Public Class WeeklyRecurrence
    Implements IRecurrence
    Private _weekdays As Boolean() = {False, True, True, True, True, True, False}

    Public Property DaysOfWeek As Boolean() = {False, False, False, False, False, False, False}

    Public Property StartDate As Date Implements IRecurrence.StartDate

    Public Property Interval As Integer Implements IRecurrence.Interval

    Public Sub New(startDate As DateTime, interval As Integer)
        Me.StartDate = startDate
        Me.Interval = interval

        Me.DaysOfWeek(startDate.DayOfWeek) = True
    End Sub

    Public Sub New(startDate As DateTime, interval As Integer, daysOfWeek() As Boolean)
        Me.StartDate = startDate
        Me.Interval = interval
        For i As Integer = 0 To 6
            Me.DaysOfWeek(i) = daysOfWeek(i)
        Next
    End Sub

    Public Function GetNextDate() As DateTime Implements IRecurrence.GetNextDate
        Return GetNextDate(DateTime.Now.Date)
    End Function

    Public Function GetNextDate(afterDate As DateTime) As DateTime Implements IRecurrence.GetNextDate
        Dim nextDate As DateTime = Me.StartDate.AddDays(-(StartDate.DayOfWeek))
        Dim done As Boolean = False
        While Not done
            For i As Integer = 0 To 7
                If nextDate.Date.CompareTo(afterDate.Date) > 0 And DaysOfWeek.ElementAt(nextDate.DayOfWeek) Then
                    done = True
                    Exit For
                End If
                nextDate = nextDate.AddDays(1)
            Next
            If Not done Then
                nextDate = nextDate.AddDays(((Interval - 1) * 7) + 1)
            End If
        End While
        Return nextDate
    End Function

    Public Function GetAverageFrequency() As TimeSpan Implements IRecurrence.GetAverageFrequency
        Return TimeSpan.FromDays((Interval * 7) / DaysOfWeek.Count(Function(x) x = True))
    End Function

    Public Function GetInstances() As List(Of Instance) Implements IRecurrence.GetInstances
        Dim instances As New List(Of Instance)
        For i = 0 To 6
            If DaysOfWeek(i) Then
                instances.Add(New Instance(Me, i + 1))
            End If
        Next
        Return instances
    End Function

    Public Overrides Function ToString() As String Implements IRecurrence.ToString
        Dim daysOfWeekStrings As New List(Of String)
        For i = 0 To 6
            If DaysOfWeek(i) Then
                daysOfWeekStrings.Add(WeekdayName(i + 1, True, FirstDayOfWeek.Sunday))
            End If
        Next

        Dim daysOfWeekString As String = String.Join(", ", daysOfWeekStrings)

        If DaysOfWeek.Equals(_weekdays) Then
            daysOfWeekString = "weekdays (Mon-Fri)"
        End If

        If Interval = 1 Then
            Return "Repeats weekly on " + daysOfWeekString
        Else
            Return "Repeats every " + Interval + " weeks on " + daysOfWeekString
        End If
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
        Return GetNextDate(DateTime.Now.Date)
    End Function

    Public Function GetNextDate(afterDate As DateTime) As DateTime Implements IRecurrence.GetNextDate
        Dim nextDate As DateTime = _StartDate
        While nextDate.Date.CompareTo(afterDate.Date) <= 0
            nextDate = nextDate.AddMonths(_Interval)
        End While
        Return nextDate
    End Function

    Public Function GetAverageFrequency() As TimeSpan Implements IRecurrence.GetAverageFrequency
        Return TimeSpan.FromDays(Interval * 30.44)
    End Function

    Public Function GetInstances() As List(Of Instance) Implements IRecurrence.GetInstances
        Return {New Instance(Me, StartDate.Day)}.ToList()
    End Function

    Public Overrides Function ToString() As String Implements IRecurrence.ToString
        If Interval = 1 Then
            Return "Repeats monthly on day " + StartDate.Day
        Else
            Return "Repeats every " + Interval + " months on " + StartDate.Day
        End If
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
        Return GetNextDate(DateTime.Now.Date)
    End Function

    Public Function GetNextDate(afterDate As DateTime) As DateTime Implements IRecurrence.GetNextDate
        Dim nextDate As DateTime = Me.StartDate
        While nextDate.Date.CompareTo(afterDate.Date) <= 0
            nextDate = nextDate.AddYears(Me.Interval)
        End While
        Return nextDate
    End Function

    Public Function GetAverageFrequency() As TimeSpan Implements IRecurrence.GetAverageFrequency
        Return TimeSpan.FromDays(Interval * 365.25)
    End Function

    Public Function GetInstances() As List(Of Instance) Implements IRecurrence.GetInstances
        Return {New Instance(Me, StartDate.DayOfYear)}.ToList()
    End Function

    Public Overrides Function ToString() As String Implements IRecurrence.ToString
        If Interval = 1 Then
            Return "Annually on " + MonthName(StartDate.Month) + StartDate.Day
        Else
            Return "Repeats every " + Interval + " years on " + MonthName(StartDate.Month) + StartDate.Day
        End If
    End Function
End Class

