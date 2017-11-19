﻿Namespace UI.Controls
    Public Class ExtensionPopupControl
        Public Event Closed As EventHandler
        Public Property Housemate As Housemate
        Public Property Task As ToDoList.Task

        Public Property Accepted As Boolean = False

        Public Sub New(ByRef housemate As Housemate, task As ToDoList.Task)
            Me.Housemate = housemate
            Me.Task = task
            ' This call is required by the designer.
            InitializeComponent()

            ' Add any initialization after the InitializeComponent() call.

        End Sub

        Private Sub CancelButton_Click(sender As Object, e As EventArgs) Handles CancelButton.Click
            Accepted = False
            RaiseEvent Closed(Me, EventArgs.Empty)
        End Sub

        Private Sub AcceptButton_Click(sender As Object, e As EventArgs) Handles AcceptButton.Click
            Accepted = True
            RaiseEvent Closed(Me, EventArgs.Empty)
        End Sub
    End Class
End Namespace