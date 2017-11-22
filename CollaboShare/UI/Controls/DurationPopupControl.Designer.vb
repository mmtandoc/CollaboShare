Namespace UI.Controls
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
    Partial Class DurationPopupControl
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
        Me.CancelButton = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.DurationNumericUpDown = New System.Windows.Forms.NumericUpDown()
        CType(Me.DurationNumericUpDown,System.ComponentModel.ISupportInitialize).BeginInit
        Me.SuspendLayout
        '
        'AcceptButton
        '
        Me.AcceptButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.AcceptButton.Location = New System.Drawing.Point(141, 90)
        Me.AcceptButton.Name = "AcceptButton"
        Me.AcceptButton.Size = New System.Drawing.Size(75, 30)
        Me.AcceptButton.TabIndex = 7
        Me.AcceptButton.Text = "Accept"
        Me.AcceptButton.UseVisualStyleBackColor = true
        '
        'CancelButton
        '
        Me.CancelButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.CancelButton.Location = New System.Drawing.Point(13, 90)
        Me.CancelButton.Name = "CancelButton"
        Me.CancelButton.Size = New System.Drawing.Size(75, 30)
        Me.CancelButton.TabIndex = 6
        Me.CancelButton.Text = "Cancel"
        Me.CancelButton.UseVisualStyleBackColor = true
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.Label1.Location = New System.Drawing.Point(10, 6)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(206, 44)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "Estimated time required to complete chore:"
        '
        'Label2
        '
        Me.Label2.AutoSize = true
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.Label2.Location = New System.Drawing.Point(120, 56)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(54, 16)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "minutes"
        '
        'DurationNumericUpDown
        '
        Me.DurationNumericUpDown.Location = New System.Drawing.Point(41, 56)
        Me.DurationNumericUpDown.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.DurationNumericUpDown.Name = "DurationNumericUpDown"
        Me.DurationNumericUpDown.Size = New System.Drawing.Size(73, 20)
        Me.DurationNumericUpDown.TabIndex = 11
        Me.DurationNumericUpDown.Value = New Decimal(New Integer() {10, 0, 0, 0})
        '
        'DurationPopupControl
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlLight
        Me.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Controls.Add(Me.DurationNumericUpDown)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.AcceptButton)
        Me.Controls.Add(Me.CancelButton)
        Me.Location = New System.Drawing.Point(16, 143)
        Me.Name = "DurationPopupControl"
        Me.Size = New System.Drawing.Size(234, 130)
        CType(Me.DurationNumericUpDown,System.ComponentModel.ISupportInitialize).EndInit
        Me.ResumeLayout(false)
        Me.PerformLayout

End Sub

        Friend WithEvents AcceptButton As Button
        Friend WithEvents CancelButton As Button
        Friend WithEvents Label1 As Label
        Friend WithEvents Label2 As Label
        Friend WithEvents DurationNumericUpDown As NumericUpDown
    End Class
End Namespace