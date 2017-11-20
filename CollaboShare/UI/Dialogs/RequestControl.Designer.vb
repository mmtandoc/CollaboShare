Namespace UI.Dialogs
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial Class RequestControl
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
            Me.CancelButton = New System.Windows.Forms.Button()
            Me.SuspendLayout()
            '
            'MessageLabel
            '
            Me.MessageLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.MessageLabel.Location = New System.Drawing.Point(13, 12)
            Me.MessageLabel.Name = "MessageLabel"
            Me.MessageLabel.Size = New System.Drawing.Size(208, 64)
            Me.MessageLabel.TabIndex = 6
            Me.MessageLabel.Text = "REQUESTMESSAGE"
            '
            'AcceptButton
            '
            Me.AcceptButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.AcceptButton.Location = New System.Drawing.Point(144, 90)
            Me.AcceptButton.Name = "AcceptButton"
            Me.AcceptButton.Size = New System.Drawing.Size(75, 30)
            Me.AcceptButton.TabIndex = 5
            Me.AcceptButton.Text = "Accept"
            Me.AcceptButton.UseVisualStyleBackColor = True
            '
            'CancelButton
            '
            Me.CancelButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.CancelButton.Location = New System.Drawing.Point(16, 90)
            Me.CancelButton.Name = "CancelButton"
            Me.CancelButton.Size = New System.Drawing.Size(75, 30)
            Me.CancelButton.TabIndex = 4
            Me.CancelButton.Text = "Cancel"
            Me.CancelButton.UseVisualStyleBackColor = True
            '
            'RequestControl
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.BackColor = System.Drawing.SystemColors.ControlLight
            Me.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.Controls.Add(Me.MessageLabel)
            Me.Controls.Add(Me.AcceptButton)
            Me.Controls.Add(Me.CancelButton)
            Me.Location = New System.Drawing.Point(16, 143)
            Me.Margin = New System.Windows.Forms.Padding(2)
            Me.Name = "RequestControl"
            Me.Size = New System.Drawing.Size(234, 130)
            Me.ResumeLayout(False)

        End Sub

        Friend WithEvents MessageLabel As Label
        Friend WithEvents AcceptButton As Button
        Friend WithEvents CancelButton As Button
    End Class
End NameSpace