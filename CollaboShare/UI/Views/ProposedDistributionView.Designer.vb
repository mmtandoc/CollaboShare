Namespace UI.Views
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
    Partial Class ProposedDistributionView
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
            Me.AcceptButton = New System.Windows.Forms.Button()
            Me.RejectButton = New System.Windows.Forms.Button()
            Me.Panel1 = New System.Windows.Forms.Panel()
            Me.Label1 = New System.Windows.Forms.Label()
            Me.FlowLayoutPanel1 = New System.Windows.Forms.FlowLayoutPanel()
            Me.Panel1.SuspendLayout()
            Me.SuspendLayout()
            '
            'AcceptButton
            '
            Me.AcceptButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.AcceptButton.Location = New System.Drawing.Point(152, 361)
            Me.AcceptButton.Name = "AcceptButton"
            Me.AcceptButton.Size = New System.Drawing.Size(75, 30)
            Me.AcceptButton.TabIndex = 7
            Me.AcceptButton.Text = "Accept"
            Me.AcceptButton.UseVisualStyleBackColor = True
            '
            'RejectButton
            '
            Me.RejectButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.RejectButton.Location = New System.Drawing.Point(24, 361)
            Me.RejectButton.Name = "RejectButton"
            Me.RejectButton.Size = New System.Drawing.Size(75, 30)
            Me.RejectButton.TabIndex = 6
            Me.RejectButton.Text = "Reject"
            Me.RejectButton.UseVisualStyleBackColor = True
            '
            'Panel1
            '
            Me.Panel1.BackColor = System.Drawing.SystemColors.ControlDark
            Me.Panel1.Controls.Add(Me.Label1)
            Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
            Me.Panel1.Location = New System.Drawing.Point(0, 0)
            Me.Panel1.Name = "Panel1"
            Me.Panel1.Size = New System.Drawing.Size(267, 40)
            Me.Panel1.TabIndex = 8
            '
            'Label1
            '
            Me.Label1.AutoSize = True
            Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label1.Location = New System.Drawing.Point(3, 7)
            Me.Label1.Name = "Label1"
            Me.Label1.Size = New System.Drawing.Size(259, 24)
            Me.Label1.TabIndex = 1
            Me.Label1.Text = "View proposed distribution"
            '
            'FlowLayoutPanel1
            '
            Me.FlowLayoutPanel1.AutoScroll = True
            Me.FlowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown
            Me.FlowLayoutPanel1.Location = New System.Drawing.Point(0, 34)
            Me.FlowLayoutPanel1.Name = "FlowLayoutPanel1"
            Me.FlowLayoutPanel1.Size = New System.Drawing.Size(267, 317)
            Me.FlowLayoutPanel1.TabIndex = 9
            Me.FlowLayoutPanel1.WrapContents = False
            '
            'ProposedDistributionView
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.Controls.Add(Me.FlowLayoutPanel1)
            Me.Controls.Add(Me.Panel1)
            Me.Controls.Add(Me.AcceptButton)
            Me.Controls.Add(Me.RejectButton)
            Me.Name = "ProposedDistributionView"
            Me.Size = New System.Drawing.Size(267, 416)
            Me.Panel1.ResumeLayout(False)
            Me.Panel1.PerformLayout()
            Me.ResumeLayout(False)

        End Sub

        Friend WithEvents AcceptButton As Button
        Friend WithEvents RejectButton As Button
        Friend WithEvents Panel1 As Panel
        Friend WithEvents Label1 As Label
        Friend WithEvents FlowLayoutPanel1 As FlowLayoutPanel
    End Class
End Namespace