Namespace UI.Controls
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial Class ChoreItemControl
        Inherits System.Windows.Forms.UserControl

        'UserControl overrides dispose to clean up the component list.
        <System.Diagnostics.DebuggerNonUserCode()> _
        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            Try
                If disposing AndAlso components IsNot Nothing Then
                    components.Dispose()
                End If
            Finally
                MyBase.Dispose(disposing)
            End Try
        End Sub

        'Required by the Windows Form Designer
        Private components As System.ComponentModel.IContainer

        'NOTE: The following procedure is required by the Windows Form Designer
        'It can be modified using the Windows Form Designer.  
        'Do not modify it using the code editor.
        <System.Diagnostics.DebuggerStepThrough()> _
        Private Sub InitializeComponent()
            Me.components = New System.ComponentModel.Container()
            Me.ChoreButton = New System.Windows.Forms.Button()
            Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
            Me.VolunteerToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
            Me.ExcludeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
            Me.EditToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
            Me.DeleteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
            Me.OverflowButton = New System.Windows.Forms.Button()
            Me.ContextMenuStrip1.SuspendLayout()
            Me.SuspendLayout()
            '
            'ChoreButton
            '
            Me.ChoreButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.ChoreButton.Location = New System.Drawing.Point(3, 3)
            Me.ChoreButton.Name = "ChoreButton"
            Me.ChoreButton.Size = New System.Drawing.Size(229, 36)
            Me.ChoreButton.TabIndex = 8
            Me.ChoreButton.Text = "ChoreName"
            Me.ChoreButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            Me.ChoreButton.UseVisualStyleBackColor = True
            '
            'ContextMenuStrip1
            '
            Me.ContextMenuStrip1.ImageScalingSize = New System.Drawing.Size(24, 24)
            Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.VolunteerToolStripMenuItem, Me.ExcludeToolStripMenuItem, Me.EditToolStripMenuItem, Me.DeleteToolStripMenuItem})
            Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
            Me.ContextMenuStrip1.Size = New System.Drawing.Size(125, 92)
            '
            'VolunteerToolStripMenuItem
            '
            Me.VolunteerToolStripMenuItem.Name = "VolunteerToolStripMenuItem"
            Me.VolunteerToolStripMenuItem.Size = New System.Drawing.Size(124, 22)
            Me.VolunteerToolStripMenuItem.Text = "Volunteer"
            '
            'ExcludeToolStripMenuItem
            '
            Me.ExcludeToolStripMenuItem.Name = "ExcludeToolStripMenuItem"
            Me.ExcludeToolStripMenuItem.Size = New System.Drawing.Size(124, 22)
            Me.ExcludeToolStripMenuItem.Text = "Exclude"
            '
            'EditToolStripMenuItem
            '
            Me.EditToolStripMenuItem.Name = "EditToolStripMenuItem"
            Me.EditToolStripMenuItem.Size = New System.Drawing.Size(124, 22)
            Me.EditToolStripMenuItem.Text = "Edit"
            '
            'DeleteToolStripMenuItem
            '
            Me.DeleteToolStripMenuItem.Name = "DeleteToolStripMenuItem"
            Me.DeleteToolStripMenuItem.Size = New System.Drawing.Size(124, 22)
            Me.DeleteToolStripMenuItem.Text = "Delete"
            '
            'OverflowButton
            '
            Me.OverflowButton.BackgroundImage = Global.CollaboShare.My.Resources.Resources.MoreVertical
            Me.OverflowButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
            Me.OverflowButton.Location = New System.Drawing.Point(237, 3)
            Me.OverflowButton.Margin = New System.Windows.Forms.Padding(2)
            Me.OverflowButton.Name = "OverflowButton"
            Me.OverflowButton.Size = New System.Drawing.Size(26, 36)
            Me.OverflowButton.TabIndex = 9
            Me.OverflowButton.UseVisualStyleBackColor = True
            '
            'ChoreItemControl
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ContextMenuStrip = Me.ContextMenuStrip1
            Me.Controls.Add(Me.OverflowButton)
            Me.Controls.Add(Me.ChoreButton)
            Me.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
            Me.Name = "ChoreItemControl"
            Me.Size = New System.Drawing.Size(265, 42)
            Me.ContextMenuStrip1.ResumeLayout(False)
            Me.ResumeLayout(False)

        End Sub

        Friend WithEvents OverflowButton As Button
        Friend WithEvents ChoreButton As Button
        Friend WithEvents ContextMenuStrip1 As ContextMenuStrip
        Friend WithEvents VolunteerToolStripMenuItem As ToolStripMenuItem
        Friend WithEvents ExcludeToolStripMenuItem As ToolStripMenuItem
        Friend WithEvents EditToolStripMenuItem As ToolStripMenuItem
        Friend WithEvents DeleteToolStripMenuItem As ToolStripMenuItem
    End Class
End NameSpace