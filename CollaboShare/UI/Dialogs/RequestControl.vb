Namespace UI.Dialogs
    Public Class RequestControl
        Public Event Close As EventHandler
        Public Property DialogResult As DialogResult = DialogResult.None

        Public Sub New(request As Request)

            ' This call is required by the designer.
            InitializeComponent()

            ' Add any initialization after the InitializeComponent() call.
            MessageLabel.Text = request.Message
            If request.Type = Request.RequestType.YesNo Then
                AcceptButton.Text = "Yes"
                CancelButton.Text = "No"
            Else
                AcceptButton.Text = "View"
                CancelButton.Text = "Ignore"
            End If
        End Sub

        Private Sub CancelButton_Click(sender As Object, e As EventArgs) Handles CancelButton.Click
            Me.DialogResult = DialogResult.No
            RaiseEvent Close(Me, EventArgs.Empty)
        End Sub

        Private Sub AcceptButton_Click(sender As Object, e As EventArgs) Handles AcceptButton.Click
            Me.DialogResult = DialogResult.Yes
            RaiseEvent Close(Me, EventArgs.Empty)
        End Sub
    End Class
End NameSpace