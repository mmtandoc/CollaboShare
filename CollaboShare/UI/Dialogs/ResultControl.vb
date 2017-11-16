Public Class ResultControl
    Public Property Response As Response
    Public Sub New(response As Response)
        Me.Response = response

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Me.MessageLabel.Text = response.Message
    End Sub
End Class
