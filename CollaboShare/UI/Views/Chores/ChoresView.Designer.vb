<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ChoresView
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
        Me.FlowLayoutPanel1 = New System.Windows.Forms.FlowLayoutPanel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ChoresFlowLayoutPanel = New System.Windows.Forms.FlowLayoutPanel()
        Me.NewChoreButton = New System.Windows.Forms.Button()
        Me.FlowLayoutPanel1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'FlowLayoutPanel1
        '
        Me.FlowLayoutPanel1.Controls.Add(Me.Panel1)
        Me.FlowLayoutPanel1.Controls.Add(Me.ChoresFlowLayoutPanel)
        Me.FlowLayoutPanel1.Controls.Add(Me.NewChoreButton)
        Me.FlowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FlowLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        Me.FlowLayoutPanel1.Size = New System.Drawing.Size(267, 416)
        Me.FlowLayoutPanel1.TabIndex = 1
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.ControlDark
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Location = New System.Drawing.Point(3, 3)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(261, 40)
        Me.Panel1.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(3, 7)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(77, 24)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Chores"
        '
        'ChoresFlowLayoutPanel
        '
        Me.ChoresFlowLayoutPanel.AutoSize = True
        Me.ChoresFlowLayoutPanel.Location = New System.Drawing.Point(2, 48)
        Me.ChoresFlowLayoutPanel.Margin = New System.Windows.Forms.Padding(2)
        Me.ChoresFlowLayoutPanel.Name = "ChoresFlowLayoutPanel"
        Me.ChoresFlowLayoutPanel.Size = New System.Drawing.Size(0, 0)
        Me.ChoresFlowLayoutPanel.TabIndex = 10
        '
        'NewChoreButton
        '
        Me.NewChoreButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NewChoreButton.Location = New System.Drawing.Point(3, 53)
        Me.NewChoreButton.Name = "NewChoreButton"
        Me.NewChoreButton.Size = New System.Drawing.Size(261, 36)
        Me.NewChoreButton.TabIndex = 9
        Me.NewChoreButton.Text = "+ Create new chore"
        Me.NewChoreButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.NewChoreButton.UseVisualStyleBackColor = True
        '
        'ChoresView
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.FlowLayoutPanel1)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "ChoresView"
        Me.Size = New System.Drawing.Size(267, 416)
        Me.FlowLayoutPanel1.ResumeLayout(False)
        Me.FlowLayoutPanel1.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents FlowLayoutPanel1 As FlowLayoutPanel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents ChoresFlowLayoutPanel As FlowLayoutPanel
    Friend WithEvents NewChoreButton As Button
End Class
