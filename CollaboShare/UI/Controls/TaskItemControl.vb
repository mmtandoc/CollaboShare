Imports System.Security.Cryptography.X509Certificates

Public Class TaskItemControl
    Public Event View As EventHandler
    Public Event RequestExtension As EventHandler
    Public Property Task As ToDoList.Task
    Private _AllowModification As Boolean

    Public Sub New(ByRef task As ToDoList.Task, allowModification As Boolean)
        Me.Task = task

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        CompletedResizableCheckBox.AutoCheck = allowModification
        ExtensionToolStripMenuItem.Visible = allowModification
        Me.TaskNameLabel.Text = task.RelatedChore.Name
        Me.CompletedResizableCheckBox.Checked = task.Completed
    End Sub

    Private Sub ViewChoreToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ViewChoreToolStripMenuItem.Click
        RaiseEvent View(Me, EventArgs.Empty)
    End Sub

    Private Sub ExtensionToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExtensionToolStripMenuItem.Click
        RaiseEvent RequestExtension(Me, EventArgs.Empty)
    End Sub

    Private Sub CompletedResizableCheckBox_CheckedChanged(sender As Object, e As EventArgs) Handles CompletedResizableCheckBox.CheckedChanged
        Task.Completed = CompletedResizableCheckBox.Checked
    End Sub

    Private Sub OverflowButton_Click(sender As Object, e As EventArgs) Handles OverflowButton.Click
        Dim btnSender As Button = sender
        Dim ptLowerLeft = New Point(0, btnSender.Height)
        ptLowerLeft = btnSender.PointToScreen(ptLowerLeft)
        ContextMenuStrip1.Show(ptLowerLeft)
    End Sub
End Class
