Namespace UI.Dialogs
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial Class NotificationControl
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
            Me.MessageLabel = New System.Windows.Forms.Label()
            Me.AcceptButton = New System.Windows.Forms.Button()
            Me.SuspendLayout()
            '
            'MessageLabel
            '
            Me.MessageLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.MessageLabel.Location = New System.Drawing.Point(14, 13)
            Me.MessageLabel.Name = "MessageLabel"
            Me.MessageLabel.Size = New System.Drawing.Size(208, 64)
            Me.MessageLabel.TabIndex = 11
            Me.MessageLabel.Text = "NOTIFICATION MESSAGE"
            '
            'AcceptButton
            '
            Me.AcceptButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.AcceptButton.Location = New System.Drawing.Point(81, 90)
            Me.AcceptButton.Name = "AcceptButton"
            Me.AcceptButton.Size = New System.Drawing.Size(75, 29)
            Me.AcceptButton.TabIndex = 10
            Me.AcceptButton.Text = "Ok"
            Me.AcceptButton.UseVisualStyleBackColor = True
            '
            'NotificationControl
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.BackColor = System.Drawing.SystemColors.ControlLight
            Me.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.Controls.Add(Me.MessageLabel)
            Me.Controls.Add(Me.AcceptButton)
            Me.Location = New System.Drawing.Point(16, 143)
            Me.Name = "NotificationControl"
            Me.Size = New System.Drawing.Size(234, 130)
            Me.ResumeLayout(False)

        End Sub

        Friend WithEvents MessageLabel As Label
        Friend WithEvents AcceptButton As Button
    End Class
End NameSpace