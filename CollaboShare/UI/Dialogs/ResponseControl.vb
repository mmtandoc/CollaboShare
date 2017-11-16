Namespace UI.Dialogs
    Public Class ResponseControl
        Public Property Response As Response
        Public Property Closed = False
        Public Sub New(response As Response)
            Me.Response = response

            ' This call is required by the designer.
            InitializeComponent()

            ' Add any initialization after the InitializeComponent() call.
            Me.MessageLabel.Text = response.Message
        End Sub

        Private Sub AcceptButton_Click(sender As Object, e As EventArgs) Handles AcceptButton.Click
            Closed = True
        End Sub
    End Class
End NameSpace