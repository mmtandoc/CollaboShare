Namespace UI.Views
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
    Partial Class CurrentDistributionView
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
            Me.Label1 = New System.Windows.Forms.Label()
            Me.AcceptButton = New System.Windows.Forms.Button()
            Me.BackButton = New System.Windows.Forms.Button()
            Me.FlowLayoutPanel1 = New System.Windows.Forms.FlowLayoutPanel()
            Me.Panel2 = New System.Windows.Forms.Panel()
            Me.Label2 = New System.Windows.Forms.Label()
            Me.ProposedDistributionButton = New System.Windows.Forms.Button()
            Me.CustomDistributionButton = New System.Windows.Forms.Button()
            Me.Panel1.SuspendLayout()
            Me.FlowLayoutPanel1.SuspendLayout()
            Me.Panel2.SuspendLayout()
            Me.SuspendLayout()
            '
            'Panel1
            '
            Me.Panel1.BackColor = System.Drawing.SystemColors.ControlDark
            Me.Panel1.Controls.Add(Me.Label1)
            Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
            Me.Panel1.Location = New System.Drawing.Point(0, 0)
            Me.Panel1.Name = "Panel1"
            Me.Panel1.Size = New System.Drawing.Size(267, 40)
            Me.Panel1.TabIndex = 12
            '
            'Label1
            '
            Me.Label1.AutoSize = True
            Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label1.Location = New System.Drawing.Point(3, 7)
            Me.Label1.Name = "Label1"
            Me.Label1.Size = New System.Drawing.Size(236, 24)
            Me.Label1.TabIndex = 1
            Me.Label1.Text = "View current distribution"
            '
            'AcceptButton
            '
            Me.AcceptButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.AcceptButton.Location = New System.Drawing.Point(152, 374)
            Me.AcceptButton.Name = "AcceptButton"
            Me.AcceptButton.Size = New System.Drawing.Size(75, 30)
            Me.AcceptButton.TabIndex = 11
            Me.AcceptButton.Text = "Accept"
            Me.AcceptButton.UseVisualStyleBackColor = True
            '
            'BackButton
            '
            Me.BackButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.BackButton.Location = New System.Drawing.Point(24, 374)
            Me.BackButton.Name = "BackButton"
            Me.BackButton.Size = New System.Drawing.Size(75, 30)
            Me.BackButton.TabIndex = 10
            Me.BackButton.Text = "Back"
            Me.BackButton.UseVisualStyleBackColor = True
            '
            'FlowLayoutPanel1
            '
            Me.FlowLayoutPanel1.AutoScroll = True
            Me.FlowLayoutPanel1.Controls.Add(Me.Panel2)
            Me.FlowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown
            Me.FlowLayoutPanel1.Location = New System.Drawing.Point(0, 47)
            Me.FlowLayoutPanel1.Name = "FlowLayoutPanel1"
            Me.FlowLayoutPanel1.Size = New System.Drawing.Size(267, 317)
            Me.FlowLayoutPanel1.TabIndex = 13
            Me.FlowLayoutPanel1.WrapContents = False
            '
            'Panel2
            '
            Me.Panel2.Controls.Add(Me.Label2)
            Me.Panel2.Controls.Add(Me.ProposedDistributionButton)
            Me.Panel2.Controls.Add(Me.CustomDistributionButton)
            Me.Panel2.Location = New System.Drawing.Point(3, 3)
            Me.Panel2.Name = "Panel2"
            Me.Panel2.Size = New System.Drawing.Size(261, 122)
            Me.Panel2.TabIndex = 3
            '
            'Label2
            '
            Me.Label2.AutoSize = True
            Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label2.Location = New System.Drawing.Point(17, 10)
            Me.Label2.Name = "Label2"
            Me.Label2.Size = New System.Drawing.Size(226, 20)
            Me.Label2.TabIndex = 3
            Me.Label2.Text = "There is no current distribution."
            '
            'ProposedDistributionButton
            '
            Me.ProposedDistributionButton.Location = New System.Drawing.Point(21, 68)
            Me.ProposedDistributionButton.Name = "ProposedDistributionButton"
            Me.ProposedDistributionButton.Size = New System.Drawing.Size(75, 51)
            Me.ProposedDistributionButton.TabIndex = 4
            Me.ProposedDistributionButton.Text = "View Proposed Distribution"
            Me.ProposedDistributionButton.UseVisualStyleBackColor = True
            '
            'CustomDistributionButton
            '
            Me.CustomDistributionButton.Location = New System.Drawing.Point(149, 68)
            Me.CustomDistributionButton.Name = "CustomDistributionButton"
            Me.CustomDistributionButton.Size = New System.Drawing.Size(75, 51)
            Me.CustomDistributionButton.TabIndex = 5
            Me.CustomDistributionButton.Text = "Create Custom Distribution"
            Me.CustomDistributionButton.UseVisualStyleBackColor = True
            '
            'CurrentDistributionView
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.Controls.Add(Me.Panel1)
            Me.Controls.Add(Me.AcceptButton)
            Me.Controls.Add(Me.BackButton)
            Me.Controls.Add(Me.FlowLayoutPanel1)
            Me.Name = "CurrentDistributionView"
            Me.Size = New System.Drawing.Size(267, 416)
            Me.Panel1.ResumeLayout(False)
            Me.Panel1.PerformLayout()
            Me.FlowLayoutPanel1.ResumeLayout(False)
            Me.Panel2.ResumeLayout(False)
            Me.Panel2.PerformLayout()
            Me.ResumeLayout(False)

        End Sub

        Friend WithEvents Panel1 As Panel
        Friend WithEvents Label1 As Label
        Friend WithEvents AcceptButton As Button
        Friend WithEvents BackButton As Button
        Friend WithEvents FlowLayoutPanel1 As FlowLayoutPanel
        Friend WithEvents Panel2 As Panel
        Friend WithEvents Label2 As Label
        Friend WithEvents ProposedDistributionButton As Button
        Friend WithEvents CustomDistributionButton As Button
    End Class
End Namespace