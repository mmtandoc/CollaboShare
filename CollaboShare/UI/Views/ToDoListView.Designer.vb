Namespace UI.Views
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
    Partial Class ToDoListView
        Inherits System.Windows.Forms.UserControl

        'UserControl overrides dispose to clean up the component list.
        <System.Diagnostics.DebuggerNonUserCode()>
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
        <System.Diagnostics.DebuggerStepThrough()>
        Private Sub InitializeComponent()
            Me.Panel1 = New System.Windows.Forms.Panel()
            Me.ToDoListLabel = New System.Windows.Forms.Label()
            Me.TasksFlowLayoutPanel = New System.Windows.Forms.FlowLayoutPanel()
            Me.Panel2 = New System.Windows.Forms.Panel()
            Me.Label2 = New System.Windows.Forms.Label()
            Me.CurrentDistributionButton = New System.Windows.Forms.Button()
            Me.Panel1.SuspendLayout()
            Me.TasksFlowLayoutPanel.SuspendLayout()
            Me.Panel2.SuspendLayout()
            Me.SuspendLayout()
            '
            'Panel1
            '
            Me.Panel1.BackColor = System.Drawing.SystemColors.ControlDark
            Me.Panel1.Controls.Add(Me.ToDoListLabel)
            Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
            Me.Panel1.Location = New System.Drawing.Point(0, 0)
            Me.Panel1.Name = "Panel1"
            Me.Panel1.Size = New System.Drawing.Size(267, 40)
            Me.Panel1.TabIndex = 15
            '
            'ToDoListLabel
            '
            Me.ToDoListLabel.AutoSize = True
            Me.ToDoListLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.ToDoListLabel.Location = New System.Drawing.Point(3, 7)
            Me.ToDoListLabel.Name = "ToDoListLabel"
            Me.ToDoListLabel.Size = New System.Drawing.Size(97, 24)
            Me.ToDoListLabel.TabIndex = 1
            Me.ToDoListLabel.Text = "To-do list"
            '
            'TasksFlowLayoutPanel
            '
            Me.TasksFlowLayoutPanel.AutoScroll = True
            Me.TasksFlowLayoutPanel.Controls.Add(Me.Panel2)
            Me.TasksFlowLayoutPanel.FlowDirection = System.Windows.Forms.FlowDirection.TopDown
            Me.TasksFlowLayoutPanel.Location = New System.Drawing.Point(0, 39)
            Me.TasksFlowLayoutPanel.Name = "TasksFlowLayoutPanel"
            Me.TasksFlowLayoutPanel.Size = New System.Drawing.Size(267, 377)
            Me.TasksFlowLayoutPanel.TabIndex = 2
            Me.TasksFlowLayoutPanel.WrapContents = False
            '
            'Panel2
            '
            Me.Panel2.AutoScroll = True
            Me.Panel2.Controls.Add(Me.Label2)
            Me.Panel2.Controls.Add(Me.CurrentDistributionButton)
            Me.Panel2.Location = New System.Drawing.Point(3, 3)
            Me.Panel2.Name = "Panel2"
            Me.Panel2.Size = New System.Drawing.Size(261, 136)
            Me.Panel2.TabIndex = 4
            '
            'Label2
            '
            Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label2.Location = New System.Drawing.Point(7, 1)
            Me.Label2.Name = "Label2"
            Me.Label2.Size = New System.Drawing.Size(251, 70)
            Me.Label2.TabIndex = 3
            Me.Label2.Text = "You have no tasks assigned to you. Please check to see if your chores are distrib" &
    "uted."
            '
            'CurrentDistributionButton
            '
            Me.CurrentDistributionButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.CurrentDistributionButton.Location = New System.Drawing.Point(76, 74)
            Me.CurrentDistributionButton.Name = "CurrentDistributionButton"
            Me.CurrentDistributionButton.Size = New System.Drawing.Size(96, 40)
            Me.CurrentDistributionButton.TabIndex = 5
            Me.CurrentDistributionButton.Text = "View Current Distribution"
            Me.CurrentDistributionButton.UseVisualStyleBackColor = True
            '
            'ToDoListView
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.Controls.Add(Me.TasksFlowLayoutPanel)
            Me.Controls.Add(Me.Panel1)
            Me.Margin = New System.Windows.Forms.Padding(2)
            Me.Name = "ToDoListView"
            Me.Size = New System.Drawing.Size(267, 416)
            Me.Panel1.ResumeLayout(False)
            Me.Panel1.PerformLayout()
            Me.TasksFlowLayoutPanel.ResumeLayout(False)
            Me.Panel2.ResumeLayout(False)
            Me.ResumeLayout(False)

        End Sub

        Friend WithEvents Panel1 As Panel
        Friend WithEvents TasksFlowLayoutPanel As FlowLayoutPanel
        Friend WithEvents ToDoListLabel As Label
        Friend WithEvents Panel2 As Panel
        Friend WithEvents Label2 As Label
        Friend WithEvents CurrentDistributionButton As Button
    End Class
End NameSpace