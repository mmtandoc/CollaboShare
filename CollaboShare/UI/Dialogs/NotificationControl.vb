Public Class NotificationControl
    Public Property Closed = False
    Public Sub New(notification As Notification)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Me.MessageLabel.Text = notification.Message
    End Sub

    Private Sub AcceptButton_Click(sender As Object, e As EventArgs) Handles AcceptButton.Click
        Closed = True
    End Sub
End Class
