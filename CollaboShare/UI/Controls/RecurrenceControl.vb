﻿Namespace UI.Controls
    Public Class RecurrenceControl


        Public Function GetRecurrence() As IRecurrence
            Dim result As IRecurrence
            Dim dueDate = DueDateDateTimePicker.Value
            Select Case FrequencyComboBox.SelectedIndex
                Case 0
                    result = New DailyRecurrence(dueDate, 1)
                Case 1
                    result = New WeeklyRecurrence(dueDate, 1)
                Case 2
                    result = New MonthlyRecurrence(dueDate, 1)
                Case 3
                    result = New MonthlyRecurrence(dueDate, 1)
                Case Else
                    Select Case CustomTabControl.SelectedIndex
                        Case 0
                            Dim interval = DailyNumericUpDown.Value
                            result = New DailyRecurrence(dueDate, interval)
                        Case 1
                            Dim interval = WeeklyNumericUpDown.Value
                            result = New WeeklyRecurrence(dueDate, interval)
                        Case 2
                            Dim interval = MonthlyNumericUpDown.Value
                            result = New MonthlyRecurrence(dueDate, interval)
                        Case Else
                            Dim interval = AnnuallyNumericUpDown.Value
                            result = New MonthlyRecurrence(dueDate, interval)
                    End Select
            End Select
            Return result
        End Function

        Public Sub SetRecurrence(recurrence As IRecurrence)
            DueDateDateTimePicker.Value = recurrence.StartDate
            If recurrence.Interval = 1 Then
                Select Case TypeName(recurrence)
                    Case "DailyRecurrence"
                        FrequencyComboBox.SelectedIndex = 0
                    Case "WeeklyRecurrence"
                        FrequencyComboBox.SelectedIndex = 1
                    Case "MonthlyRecurrence"
                        FrequencyComboBox.SelectedIndex = 2
                    Case "YearlyRecurrence"
                        FrequencyComboBox.SelectedIndex = 3
                End Select
            Else
                FrequencyComboBox.SelectedIndex = 4
                Select Case TypeName(recurrence)
                    Case "DailyRecurrence"
                        CustomTabControl.SelectedIndex = 0
                        DailyNumericUpDown.Value = recurrence.Interval
                    Case "WeeklyRecurrence"
                        CustomTabControl.SelectedIndex = 1
                        WeeklyNumericUpDown.Value = recurrence.Interval

                        Dim daysOfWeek = CType(recurrence, WeeklyRecurrence).DaysOfWeek
                        Dim daysOfWeekCheckBoxes = {SundayCheckBox, MondayCheckBox, TuesdayCheckBox, WednesdayCheckBox, ThursdayCheckBox, FridayCheckBox, SaturdayCheckBox}

                        For index = 0 To 6
                            daysOfWeekCheckBoxes(index).Checked = daysOfWeek(index)
                        Next

                    Case "MonthlyRecurrence"
                        CustomTabControl.SelectedIndex = 2
                        MonthlyNumericUpDown.Value = recurrence.Interval
                    Case "YearlyRecurrence"
                        CustomTabControl.SelectedIndex = 3
                        AnnuallyNumericUpDown.Value = recurrence.Interval
                End Select
            End If

        End Sub

        Private Sub FrequencyComboBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles FrequencyComboBox.SelectedIndexChanged
            If FrequencyComboBox.SelectedText = "Custom..." Then
                CustomTabControl.Visible = True
            Else
                CustomTabControl.Visible = False
            End If
        End Sub
    End Class
End NameSpace