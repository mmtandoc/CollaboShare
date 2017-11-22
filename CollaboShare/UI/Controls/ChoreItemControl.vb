Namespace UI.Controls
    Public Class ChoreItemControl
        Public Event View As EventHandler
        Public Event Volunteer As EventHandler
        Public Event CancelVolunteer As EventHandler
        Public Event Exclude As EventHandler
        Public Event CancelExclude As EventHandler
        Public Event Delete As EventHandler
        Public Event Edit As EventHandler
        Public Event SetDuration AS EventHandler

        Public ReadOnly Property Phone() As PhoneForm
            Get
                Return FindForm()
            End Get
        End Property


        Public Property Chore As Chore
        Public Sub New(ByRef chore As Chore)
            Me.Chore = chore
            ' This call is required by the designer.
            InitializeComponent()

            ' Add any initialization after the InitializeComponent() call.
            Me.ChoreButton.Text = chore.Name
        End Sub

        Protected Overrides Sub OnLoad(e As EventArgs)
            If Not IsNothing(Chore.Volunteer) Then
                If Chore.Volunteer.Equals(Phone.Profile) Then
                    VolunteerToolStripMenuItem.Visible = False
                    CancelVolunteerToolStripMenuItem.Visible = True
                Else
                    VolunteerToolStripMenuItem.Visible = False
                    CancelVolunteerToolStripMenuItem.Visible = False
                End If
            End If


            If Chore.Exclusions.Contains(Phone.Profile) Then
                ExcludeToolStripMenuItem.Visible = False
                CancelExclusionToolStripMenuItem.Visible = True
            End If
        End Sub

        Private Sub OverflowButton_Click(sender As Object, e As EventArgs) Handles OverflowButton.Click
            Dim btnSender As Button = sender
            Dim ptLowerLeft = New Point(0, btnSender.Height)
            ptLowerLeft = btnSender.PointToScreen(ptLowerLeft)
            ContextMenuStrip1.Show(ptLowerLeft)
        End Sub

        Private Sub ChoreButton_Click(sender As Object, e As EventArgs) Handles ChoreButton.Click
            RaiseEvent View(Me, EventArgs.Empty)
        End Sub

        Private Sub VolunteerToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles VolunteerToolStripMenuItem.Click
            RaiseEvent Volunteer(Me, EventArgs.Empty)
        End Sub

        Private Sub ExcludeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExcludeToolStripMenuItem.Click
            RaiseEvent Exclude(Me, EventArgs.Empty)
        End Sub

        Private Sub EditToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EditToolStripMenuItem.Click
            RaiseEvent Edit(Me, EventArgs.Empty)
        End Sub

        Private Sub DeleteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DeleteToolStripMenuItem.Click
            RaiseEvent Delete(Me, EventArgs.Empty)
        End Sub

        Private Sub CancelVolunteerToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CancelVolunteerToolStripMenuItem.Click
            RaiseEvent CancelVolunteer(Me, EventArgs.Empty)
        End Sub

        Private Sub CancelExclusionToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CancelExclusionToolStripMenuItem.Click
            RaiseEvent CancelExclude(Me, EventArgs.Empty)
        End Sub

        Private Sub SetDurationToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SetDurationToolStripMenuItem.Click
            RaiseEvent SetDuration(Me, EventArgs.Empty)
        End Sub
    End Class
End NameSpace