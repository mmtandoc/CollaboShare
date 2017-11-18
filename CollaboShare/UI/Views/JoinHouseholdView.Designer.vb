Namespace UI.Views
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial Class JoinHouseholdView
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
            Me.FlowLayoutPanel1 = New System.Windows.Forms.FlowLayoutPanel()
            Me.HouseholdsFlowLayoutPanel = New System.Windows.Forms.FlowLayoutPanel()
            Me.NewHouseholdButton = New System.Windows.Forms.Button()
            Me.Panel1 = New System.Windows.Forms.Panel()
            Me.Label1 = New System.Windows.Forms.Label()
            Me.FlowLayoutPanel1.SuspendLayout()
            Me.Panel1.SuspendLayout()
            Me.SuspendLayout()
            '
            'FlowLayoutPanel1
            '
            Me.FlowLayoutPanel1.Controls.Add(Me.HouseholdsFlowLayoutPanel)
            Me.FlowLayoutPanel1.Controls.Add(Me.NewHouseholdButton)
            Me.FlowLayoutPanel1.Location = New System.Drawing.Point(0, 40)
            Me.FlowLayoutPanel1.Name = "FlowLayoutPanel1"
            Me.FlowLayoutPanel1.Size = New System.Drawing.Size(267, 376)
            Me.FlowLayoutPanel1.TabIndex = 0
            '
            'HouseholdsFlowLayoutPanel
            '
            Me.HouseholdsFlowLayoutPanel.AutoSize = True
            Me.HouseholdsFlowLayoutPanel.Location = New System.Drawing.Point(7, 2)
            Me.HouseholdsFlowLayoutPanel.Margin = New System.Windows.Forms.Padding(7, 2, 7, 2)
            Me.HouseholdsFlowLayoutPanel.Name = "HouseholdsFlowLayoutPanel"
            Me.HouseholdsFlowLayoutPanel.Size = New System.Drawing.Size(0, 0)
            Me.HouseholdsFlowLayoutPanel.TabIndex = 10
            '
            'NewHouseholdButton
            '
            Me.NewHouseholdButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.NewHouseholdButton.Location = New System.Drawing.Point(10, 7)
            Me.NewHouseholdButton.Margin = New System.Windows.Forms.Padding(10, 3, 3, 3)
            Me.NewHouseholdButton.Name = "NewHouseholdButton"
            Me.NewHouseholdButton.Size = New System.Drawing.Size(242, 36)
            Me.NewHouseholdButton.TabIndex = 9
            Me.NewHouseholdButton.Text = "+ Create new household"
            Me.NewHouseholdButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            Me.NewHouseholdButton.UseVisualStyleBackColor = True
            '
            'Panel1
            '
            Me.Panel1.BackColor = System.Drawing.SystemColors.ControlDark
            Me.Panel1.Controls.Add(Me.Label1)
            Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
            Me.Panel1.Location = New System.Drawing.Point(0, 0)
            Me.Panel1.Name = "Panel1"
            Me.Panel1.Size = New System.Drawing.Size(267, 40)
            Me.Panel1.TabIndex = 2
            '
            'Label1
            '
            Me.Label1.AutoSize = True
            Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label1.Location = New System.Drawing.Point(3, 7)
            Me.Label1.Name = "Label1"
            Me.Label1.Size = New System.Drawing.Size(171, 24)
            Me.Label1.TabIndex = 1
            Me.Label1.Text = "Join a household"
            '
            'JoinHouseholdView
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.Controls.Add(Me.Panel1)
            Me.Controls.Add(Me.FlowLayoutPanel1)
            Me.Name = "JoinHouseholdView"
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
        Friend WithEvents NewHouseholdButton As Button
        Friend WithEvents HouseholdsFlowLayoutPanel As FlowLayoutPanel
    End Class
End NameSpace