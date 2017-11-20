Imports CollaboShare.UI.Controls

Namespace UI.Views
    Public Class ToDoListView
        Public Event RequestingExtension As EventHandler
        Public Property Profile As Housemate
        Dim WithEvents ExtensionControl As ExtensionPopupControl = Nothing
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
            If IsOwner Then
                ToDoListLabel.Text = "My To-do list"
            Else
                ToDoListLabel.Text = Profile.Name.Split(" "c)(0) + "'s To-do list"
            End If

            Profile.ToDoList.Sort()
            Dim dateGroups = Profile.ToDoList.GroupBy(Function(k) New With {Key .DueDate = k.DueDate.Date})


            For Each dateGroup In dateGroups
                Dim dateLabel As New Label With {
                        .AutoSize = True,
                        .Font = New Font("Microsoft Sans Serif", 11.25!, FontStyle.Bold Or FontStyle.Underline, GraphicsUnit.Point, 0),
                        .Location = New Point(3, 0),
                        .Text = dateGroup.Key.DueDate.ToLongDateString()
                        }
                TasksFlowLayoutPanel.Controls.Add(dateLabel)
                For Each task As ToDoList.Task In dateGroup
                    Dim taskItem As New TaskItemControl(task, IsOwner)
                    AddHandler taskItem.View, AddressOf TaskItem_View
                    AddHandler taskItem.RequestExtension, AddressOf TaskItem_RequestExtension
                    TasksFlowLayoutPanel.Controls.Add(taskItem)
                Next
            Next

        End Sub

        Private Sub TaskItem_View(sender As Object, e As EventArgs)
            Dim relatedChore = DirectCast(sender, TaskItemControl).Task.RelatedChore
            Phone.ChangeView(New ViewChoreView(relatedChore))
        End Sub

        Private Sub TaskItem_RequestExtension(sender As Object, e As EventArgs)
            Dim taskSender As TaskItemControl = sender
            ExtensionControl = New ExtensionPopupControl(Phone.Profile, taskSender.Task)
            Phone.Controls.Add(ExtensionControl)
            ExtensionControl.BringToFront()
            AddHandler ExtensionControl.RequestingExtension, AddressOf ExtensionPopupControl_RequestExtension
            AddHandler ExtensionControl.Closed, Sub()
                                                    Phone.Controls.Remove(ExtensionControl)
                                                    ExtensionControl = Nothing
                                                End Sub
        End Sub


        Private Sub ExtensionPopupControl_RequestExtension(sender As Object, e As EventArgs)
            Dim controlSender As ExtensionPopupControl = sender
            Dim request As Request = New Request.ExtensionRequest(Profile, Phone.Household, controlSender.Task, Integer.Parse(controlSender.ExtensionMaskedTextBox.Text))
            RaiseEvent RequestingExtension(sender, New RequestEventArgs(request))
        End Sub

        Private Sub TasksFlowLayoutPanel_Paint(sender As Object, e As PaintEventArgs) Handles TasksFlowLayoutPanel.Paint

        End Sub
    End Class
End Namespace