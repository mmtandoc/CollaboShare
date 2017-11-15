Public Class HouseholdControl


    Private Sub HouseholdControl_MouseClick(sender As Object, e As MouseEventArgs) Handles MyBase.MouseClick

    End Sub

    Private Sub HouseholdControl_MouseEnter(sender As Object, e As EventArgs) Handles MyBase.MouseEnter
        Me.BackColor = SystemColors.ControlDark
    End Sub

    Private Sub HouseholdControl_MouseLeave(sender As Object, e As EventArgs) Handles MyBase.MouseLeave
        Me.BackColor = SystemColors.Control
    End Sub

    Private Sub HouseholdControl_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
