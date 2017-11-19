Imports CollaboShare.UI

Public Class Notification
    Public Property Sender As Housemate
    Public Property Message As String
    Public Property Recipients As New List(Of Housemate)

    Public Sub New(ByRef sender As Housemate, recipients As List(Of Housemate), message As String)
        Me.Sender = sender
        Me.Recipients = recipients
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
