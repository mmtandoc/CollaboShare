Public Class RecurrenceControl
    Private Sub CustomRadioButton_CheckedChanged(sender As Object, e As EventArgs) Handles CustomRadioButton.CheckedChanged
        If CustomRadioButton.Checked Then
            CustomTabControl.Visible = True
        Else
            CustomTabControl.Visible = False
        End If
    End Sub

    Public Function GetRecurrence() As Recurrence
        Dim result As Recurrence
        Dim dueDate = DueDateDateTimePicker.Value
        If DailyRadioButton.Checked Then
            result = New Recurrence.DailyRecurrence(dueDate, 1)
        ElseIf WeeklyRadioButton.Checked Then
            result = New Recurrence.WeeklyRecurrence(dueDate, 1)
        ElseIf MonthlyRadioButton.Checked Then
            result = New Recurrence.MonthlyRecurrence(dueDate, 1)
        ElseIf YearlyRadioButton.Checked Then
            result = New Recurrence.MonthlyRecurrence(dueDate, 1)
        Else
            Select Case CustomTabControl.SelectedIndex
                Case 0
                    Dim interval = DailyNumericUpDown.Value
                    result = New Recurrence.DailyRecurrence(dueDate, interval)
                Case 1
                    Dim interval = WeeklyNumericUpDown.Value
                    result = New Recurrence.WeeklyRecurrence(dueDate, interval)
                Case 2
                    Dim interval = MonthlyNumericUpDown.Value
                    result = New Recurrence.MonthlyRecurrence(dueDate, interval)
                Case Else
                    Dim interval = AnnuallyNumericUpDown.Value
                    result = New Recurrence.MonthlyRecurrence(dueDate, interval)
            End Select
        End If
        Return result
    End Function

End Class
