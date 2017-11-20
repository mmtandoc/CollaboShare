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
            Me.BackButton = New System.Windows.Forms.Button()
            Me.Panel2 = New System.Windows.Forms.Panel()
            Me.Label2 = New System.Windows.Forms.Label()
            Me.ProposedDistributionButton = New System.Windows.Forms.Button()
            Me.CustomDistributionButton = New System.Windows.Forms.Button()
            Me.Panel3 = New System.Windows.Forms.Panel()
            Me.ResetDistributionButton = New System.Windows.Forms.Button()
            Me.Panel1.SuspendLayout()
            Me.Panel2.SuspendLayout()
            Me.Panel3.SuspendLayout()
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
            'BackButton
            '
            Me.BackButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.BackButton.Location = New System.Drawing.Point(13, 374)
            Me.BackButton.Name = "BackButton"
            Me.BackButton.Size = New System.Drawing.Size(86, 42)
            Me.BackButton.TabIndex = 10
            Me.BackButton.Text = "Back"
            Me.BackButton.UseVisualStyleBackColor = True
            '
            'Panel2
            '
            Me.Panel2.Controls.Add(Me.Label2)
            Me.Panel2.Controls.Add(Me.ProposedDistributionButton)
            Me.Panel2.Controls.Add(Me.CustomDistributionButton)
            Me.Panel2.Location = New System.Drawing.Point(9, 22)
            Me.Panel2.Name = "Panel2"
            Me.Panel2.Size = New System.Drawing.Size(240, 122)
            Me.Panel2.TabIndex = 3
            '
            'Label2
            '
            Me.Label2.AutoSize = True
            Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label2.Location = New System.Drawing.Point(7, 10)
            Me.Label2.Name = "Label2"
            Me.Label2.Size = New System.Drawing.Size(226, 20)
            Me.Label2.TabIndex = 3
            Me.Label2.Text = "There is no current distribution."
            '
            'ProposedDistributionButton
            '
            Me.ProposedDistributionButton.Location = New System.Drawing.Point(19, 68)
            Me.ProposedDistributionButton.Name = "ProposedDistributionButton"
            Me.ProposedDistributionButton.Size = New System.Drawing.Size(75, 51)
            Me.ProposedDistributionButton.TabIndex = 4
            Me.ProposedDistributionButton.Text = "View Proposed Distribution"
            Me.ProposedDistributionButton.UseVisualStyleBackColor = True
            '
            'CustomDistributionButton
            '
            Me.CustomDistributionButton.Location = New System.Drawing.Point(147, 68)
            Me.CustomDistributionButton.Name = "CustomDistributionButton"
            Me.CustomDistributionButton.Size = New System.Drawing.Size(75, 51)
            Me.CustomDistributionButton.TabIndex = 5
            Me.CustomDistributionButton.Text = "Create Custom Distribution"
            Me.CustomDistributionButton.UseVisualStyleBackColor = True
            '
            'Panel3
            '
            Me.Panel3.Controls.Add(Me.Panel2)
            Me.Panel3.Location = New System.Drawing.Point(4, 44)
            Me.Panel3.Name = "Panel3"
            Me.Panel3.Size = New System.Drawing.Size(259, 324)
            Me.Panel3.TabIndex = 13
            '
            'ResetDistributionButton
            '
            Me.ResetDistributionButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.ResetDistributionButton.Location = New System.Drawing.Point(167, 374)
            Me.ResetDistributionButton.Name = "ResetDistributionButton"
            Me.ResetDistributionButton.Size = New System.Drawing.Size(86, 42)
            Me.ResetDistributionButton.TabIndex = 14
            Me.ResetDistributionButton.Text = "Reset Distribution"
            Me.ResetDistributionButton.UseVisualStyleBackColor = True
            '
            'CurrentDistributionView
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.Controls.Add(Me.ResetDistributionButton)
            Me.Controls.Add(Me.Panel3)
            Me.Controls.Add(Me.Panel1)
            Me.Controls.Add(Me.BackButton)
            Me.Name = "CurrentDistributionView"
            Me.Size = New System.Drawing.Size(267, 416)
            Me.Panel1.ResumeLayout(False)
            Me.Panel1.PerformLayout()
            Me.Panel2.ResumeLayout(False)
            Me.Panel2.PerformLayout()
            Me.Panel3.ResumeLayout(False)
            Me.ResumeLayout(False)

        End Sub

        Friend WithEvents Panel1 As Panel
        Friend WithEvents Label1 As Label
        Friend WithEvents BackButton As Button
        Friend WithEvents Panel2 As Panel
        Friend WithEvents Label2 As Label
        Friend WithEvents ProposedDistributionButton As Button
        Friend WithEvents CustomDistributionButton As Button
        Friend WithEvents Panel3 As Panel
        Friend WithEvents ResetDistributionButton As Button
    End Class
End Namespace