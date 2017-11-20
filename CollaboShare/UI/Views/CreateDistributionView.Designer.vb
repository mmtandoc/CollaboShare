Namespace UI.Views
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
    Partial Class CreateDistributionView
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
            Me.InstancesFlowLayoutPanel = New System.Windows.Forms.FlowLayoutPanel()
            Me.Label1 = New System.Windows.Forms.Label()
            Me.Panel1 = New System.Windows.Forms.Panel()
            Me.CancelButton = New System.Windows.Forms.Button()
            Me.ConfirmButton = New System.Windows.Forms.Button()
            Me.Panel1.SuspendLayout()
            Me.SuspendLayout()
            '
            'InstancesFlowLayoutPanel
            '
            Me.InstancesFlowLayoutPanel.AutoScroll = True
            Me.InstancesFlowLayoutPanel.FlowDirection = System.Windows.Forms.FlowDirection.TopDown
            Me.InstancesFlowLayoutPanel.Location = New System.Drawing.Point(0, 39)
            Me.InstancesFlowLayoutPanel.Name = "InstancesFlowLayoutPanel"
            Me.InstancesFlowLayoutPanel.Size = New System.Drawing.Size(267, 330)
            Me.InstancesFlowLayoutPanel.TabIndex = 16
            Me.InstancesFlowLayoutPanel.WrapContents = False
            '
            'Label1
            '
            Me.Label1.AutoSize = True
            Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label1.Location = New System.Drawing.Point(3, 7)
            Me.Label1.Name = "Label1"
            Me.Label1.Size = New System.Drawing.Size(179, 24)
            Me.Label1.TabIndex = 1
            Me.Label1.Text = "Create distribution"
            '
            'Panel1
            '
            Me.Panel1.BackColor = System.Drawing.SystemColors.ControlDark
            Me.Panel1.Controls.Add(Me.Label1)
            Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
            Me.Panel1.Location = New System.Drawing.Point(0, 0)
            Me.Panel1.Name = "Panel1"
            Me.Panel1.Size = New System.Drawing.Size(267, 40)
            Me.Panel1.TabIndex = 17
            '
            'CancelButton
            '
            Me.CancelButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.CancelButton.Location = New System.Drawing.Point(11, 375)
            Me.CancelButton.Name = "CancelButton"
            Me.CancelButton.Size = New System.Drawing.Size(75, 27)
            Me.CancelButton.TabIndex = 19
            Me.CancelButton.Text = "Cancel"
            Me.CancelButton.UseVisualStyleBackColor = True
            '
            'ConfirmButton
            '
            Me.ConfirmButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.ConfirmButton.Location = New System.Drawing.Point(180, 375)
            Me.ConfirmButton.Name = "ConfirmButton"
            Me.ConfirmButton.Size = New System.Drawing.Size(75, 27)
            Me.ConfirmButton.TabIndex = 18
            Me.ConfirmButton.Text = "Confirm"
            Me.ConfirmButton.UseVisualStyleBackColor = True
            '
            'CreateDistributionView
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.Controls.Add(Me.CancelButton)
            Me.Controls.Add(Me.ConfirmButton)
            Me.Controls.Add(Me.InstancesFlowLayoutPanel)
            Me.Controls.Add(Me.Panel1)
            Me.Name = "CreateDistributionView"
            Me.Size = New System.Drawing.Size(267, 416)
            Me.Panel1.ResumeLayout(False)
            Me.Panel1.PerformLayout()
            Me.ResumeLayout(False)

        End Sub

        Friend WithEvents InstancesFlowLayoutPanel As FlowLayoutPanel
        Friend WithEvents Label1 As Label
        Friend WithEvents Panel1 As Panel
        Friend WithEvents CancelButton As Button
        Friend WithEvents ConfirmButton As Button
    End Class
End Namespace