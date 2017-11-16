Imports CollaboShare_Prototype_1

Public Class JoinHouseholdDialog
    Implements IDialogControl
    Public Event Closing As EventHandler Implements IDialogControl.Closing

    Public Sub New(householdName As String)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        DialogTextLabel.Text = $"Request to join {householdName}?"
    End Sub

    Public Property DialogResult As DialogResult Implements IDialogControl.DialogResult

    Private Sub ConfirmButton_Click(sender As Object, e As EventArgs) Handles ConfirmButton.Click
        Me.DialogResult = DialogResult.Yes
        Me.Parent.Controls.Remove(Me)
        RaiseEvent Closing(Me, EventArgs.Empty)
    End Sub

    Private Sub CancelButton_Click(sender As Object, e As EventArgs) Handles CancelButton.Click
        Me.DialogResult = DialogResult.No
        Me.Parent.Controls.Remove(Me)
        RaiseEvent Closing(Me, EventArgs.Empty)
    End Sub
End Class
