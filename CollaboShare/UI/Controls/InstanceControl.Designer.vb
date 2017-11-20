Namespace UI.Controls
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
    Partial Class InstanceControl
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
            Me.AssignedComboBox = New System.Windows.Forms.ComboBox()
            Me.InstanceLabel = New System.Windows.Forms.Label()
            Me.SuspendLayout()
            '
            'AssignedComboBox
            '
            Me.AssignedComboBox.FormattingEnabled = True
            Me.AssignedComboBox.Location = New System.Drawing.Point(3, 22)
            Me.AssignedComboBox.Name = "AssignedComboBox"
            Me.AssignedComboBox.Size = New System.Drawing.Size(210, 21)
            Me.AssignedComboBox.TabIndex = 0
            '
            'InstanceLabel
            '
            Me.InstanceLabel.AutoSize = True
            Me.InstanceLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.InstanceLabel.Location = New System.Drawing.Point(3, 4)
            Me.InstanceLabel.Name = "InstanceLabel"
            Me.InstanceLabel.Size = New System.Drawing.Size(84, 15)
            Me.InstanceLabel.TabIndex = 1
            Me.InstanceLabel.Text = "InstanceLabel"
            '
            'InstanceControl
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.Controls.Add(Me.InstanceLabel)
            Me.Controls.Add(Me.AssignedComboBox)
            Me.Name = "InstanceControl"
            Me.Size = New System.Drawing.Size(220, 45)
            Me.ResumeLayout(False)
            Me.PerformLayout()

        End Sub

        Friend WithEvents AssignedComboBox As ComboBox
        Friend WithEvents InstanceLabel As Label
    End Class
End Namespace