Namespace UI.Views
    Public Class ToDoListView
        Public Property Profile As Housemate
        Public ReadOnly Property Phone() As PhoneForm
            Get
                Return FindForm()
            End Get
        End Property

        Public ReadOnly Property IsOwner As Boolean
            Get
                Return Phone.Profile.Equals(Profile)
            End Get
        End Property

        Public Sub New(profile As Housemate)
            Me.Profile = profile
            ' This call is required by the designer.
            InitializeComponent()

            ' Add any initialization after the InitializeComponent() call.

        End Sub

        Protected Overrides Sub OnLoad(e As EventArgs)
            MyBase.OnLoad(e)
            TasksFlowLayoutPanel.Controls.Clear()
            For Each task As ToDoList.Task In Profile.ToDoList
                Dim taskItem As New TaskItemControl(task, IsOwner)
                AddHandler taskItem.View, AddressOf TaskItem_View
                AddHandler taskItem.RequestExtension, AddressOf TaskItem_RequestExtension
            Next
        End Sub

        Private Sub TaskItem_View(sender As Object, e As EventArgs)
            Dim relatedChore = DirectCast(sender, TaskItemControl).Task.RelatedChore
            Phone.ChangeView(New ViewChoreView(relatedChore))
        End Sub

        Private Sub TaskItem_RequestExtension(sender As Object, e As EventArgs)

        End Sub
    End Class
End NameSpace