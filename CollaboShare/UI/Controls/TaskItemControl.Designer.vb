Namespace UI.Controls
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial Class TaskItemControl
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
            Me.CompletedResizableCheckBox = New ResizableCheckBox()
            Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
            Me.ViewChoreToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
            Me.ExtensionToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
            Me.TaskNameLabel = New System.Windows.Forms.Label()
            Me.OverflowButton = New System.Windows.Forms.Button()
            Me.ContextMenuStrip1.SuspendLayout()
            Me.SuspendLayout()
            '
            'CompletedResizableCheckBox
            '
            Me.CompletedResizableCheckBox.BoxSize = New System.Drawing.Size(25, 25)
            Me.CompletedResizableCheckBox.Location = New System.Drawing.Point(3, 2)
            Me.CompletedResizableCheckBox.Name = "CompletedResizableCheckBox"
            Me.CompletedResizableCheckBox.Size = New System.Drawing.Size(29, 27)
            Me.CompletedResizableCheckBox.TabIndex = 0
            Me.CompletedResizableCheckBox.UseVisualStyleBackColor = True
            '
            'ContextMenuStrip1
            '
            Me.ContextMenuStrip1.ImageScalingSize = New System.Drawing.Size(24, 24)
            Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ViewChoreToolStripMenuItem, Me.ExtensionToolStripMenuItem})
            Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
            Me.ContextMenuStrip1.Size = New System.Drawing.Size(170, 48)
            '
            'ViewChoreToolStripMenuItem
            '
            Me.ViewChoreToolStripMenuItem.Name = "ViewChoreToolStripMenuItem"
            Me.ViewChoreToolStripMenuItem.Size = New System.Drawing.Size(169, 22)
            Me.ViewChoreToolStripMenuItem.Text = "View Chore"
            '
            'ExtensionToolStripMenuItem
            '
            Me.ExtensionToolStripMenuItem.Name = "ExtensionToolStripMenuItem"
            Me.ExtensionToolStripMenuItem.Size = New System.Drawing.Size(169, 22)
            Me.ExtensionToolStripMenuItem.Text = "Request Extension"
            '
            'TaskNameLabel
            '
            Me.TaskNameLabel.AutoSize = True
            Me.TaskNameLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.TaskNameLabel.Location = New System.Drawing.Point(31, 7)
            Me.TaskNameLabel.Name = "TaskNameLabel"
            Me.TaskNameLabel.Size = New System.Drawing.Size(76, 16)
            Me.TaskNameLabel.TabIndex = 11
            Me.TaskNameLabel.Text = "TaskName"
            '
            'OverflowButton
            '
            Me.OverflowButton.BackgroundImage = Global.CollaboShare.My.Resources.Resources.MoreVertical
            Me.OverflowButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
            Me.OverflowButton.Location = New System.Drawing.Point(198, 1)
            Me.OverflowButton.Margin = New System.Windows.Forms.Padding(2)
            Me.OverflowButton.Name = "OverflowButton"
            Me.OverflowButton.Size = New System.Drawing.Size(26, 29)
            Me.OverflowButton.TabIndex = 10
            Me.OverflowButton.UseVisualStyleBackColor = True
            '
            'TaskItemControl
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.Controls.Add(Me.TaskNameLabel)
            Me.Controls.Add(Me.OverflowButton)
            Me.Controls.Add(Me.CompletedResizableCheckBox)
            Me.Name = "TaskItemControl"
            Me.Size = New System.Drawing.Size(228, 31)
            Me.ContextMenuStrip1.ResumeLayout(False)
            Me.ResumeLayout(False)
            Me.PerformLayout()

        End Sub

        Friend WithEvents CompletedResizableCheckBox As ResizableCheckBox
        Friend WithEvents ContextMenuStrip1 As ContextMenuStrip
        Friend WithEvents ViewChoreToolStripMenuItem As ToolStripMenuItem
        Friend WithEvents ExtensionToolStripMenuItem As ToolStripMenuItem
        Friend WithEvents OverflowButton As Button
        Friend WithEvents TaskNameLabel As Label
    End Class
End NameSpace