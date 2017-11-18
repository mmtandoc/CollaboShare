Public Class Notification
    Public Property Sender As Housemate
    Public Property Message As String
    Public Sub New(ByRef sender As Housemate, message As String)
        Me.Sender = sender
        Me.Message = message
    End Sub
End Class


Public Class NotificationEventArgs
    Inherits EventArgs
    Public Property Notification As Notification
    Public Sub New(notification As Notification)
        Me.Notification = notification
    End Sub

End Class
