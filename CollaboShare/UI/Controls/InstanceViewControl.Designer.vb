Namespace UI.Controls
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial Class InstanceViewControl
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
            Me.InstanceLabel = New System.Windows.Forms.Label()
            Me.AssignedLabel = New System.Windows.Forms.Label()
            Me.SuspendLayout()
            '
            'InstanceLabel
            '
            Me.InstanceLabel.AutoSize = True
            Me.InstanceLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.InstanceLabel.Location = New System.Drawing.Point(3, 4)
            Me.InstanceLabel.Name = "InstanceLabel"
            Me.InstanceLabel.Size = New System.Drawing.Size(51, 18)
            Me.InstanceLabel.TabIndex = 0
            Me.InstanceLabel.Text = "Label1"
            Me.InstanceLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            '
            'AssignedLabel
            '
            Me.AssignedLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.AssignedLabel.Location = New System.Drawing.Point(113, 2)
            Me.AssignedLabel.Name = "AssignedLabel"
            Me.AssignedLabel.Size = New System.Drawing.Size(138, 23)
            Me.AssignedLabel.TabIndex = 1
            Me.AssignedLabel.Text = "AssignedHousemate"
            Me.AssignedLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'InstanceViewControl
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.Controls.Add(Me.AssignedLabel)
            Me.Controls.Add(Me.InstanceLabel)
            Me.Name = "InstanceViewControl"
            Me.Size = New System.Drawing.Size(251, 28)
            Me.ResumeLayout(False)
            Me.PerformLayout()

        End Sub

        Friend WithEvents InstanceLabel As Label
        Friend WithEvents AssignedLabel As Label
    End Class
End NameSpace