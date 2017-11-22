Namespace UI.Controls
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
    Partial Class ExtensionPopupControl
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
            Me.Label2 = New System.Windows.Forms.Label()
            Me.Label1 = New System.Windows.Forms.Label()
            Me.CancelButton = New System.Windows.Forms.Button()
            Me.DaysNumericUpDown = New System.Windows.Forms.NumericUpDown()
            CType(Me.DaysNumericUpDown, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            '
            'AcceptButton
            '
            Me.AcceptButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.AcceptButton.Location = New System.Drawing.Point(141, 92)
            Me.AcceptButton.Name = "AcceptButton"
            Me.AcceptButton.Size = New System.Drawing.Size(75, 30)
            Me.AcceptButton.TabIndex = 7
            Me.AcceptButton.Text = "Accept"
            Me.AcceptButton.UseVisualStyleBackColor = True
            '
            'Label2
            '
            Me.Label2.AutoSize = True
            Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label2.Location = New System.Drawing.Point(123, 58)
            Me.Label2.Name = "Label2"
            Me.Label2.Size = New System.Drawing.Size(38, 16)
            Me.Label2.TabIndex = 15
            Me.Label2.Text = "days"
            '
            'Label1
            '
            Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label1.Location = New System.Drawing.Point(14, 8)
            Me.Label1.Name = "Label1"
            Me.Label1.Size = New System.Drawing.Size(206, 44)
            Me.Label1.TabIndex = 13
            Me.Label1.Text = "Length of extension:"
            '
            'CancelButton
            '
            Me.CancelButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.CancelButton.Location = New System.Drawing.Point(17, 92)
            Me.CancelButton.Name = "CancelButton"
            Me.CancelButton.Size = New System.Drawing.Size(75, 30)
            Me.CancelButton.TabIndex = 11
            Me.CancelButton.Text = "Cancel"
            Me.CancelButton.UseVisualStyleBackColor = True
            '
            'DaysNumericUpDown
            '
            Me.DaysNumericUpDown.Location = New System.Drawing.Point(55, 55)
            Me.DaysNumericUpDown.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
            Me.DaysNumericUpDown.Name = "DaysNumericUpDown"
            Me.DaysNumericUpDown.Size = New System.Drawing.Size(62, 20)
            Me.DaysNumericUpDown.TabIndex = 16
            Me.DaysNumericUpDown.Value = New Decimal(New Integer() {1, 0, 0, 0})
            '
            'ExtensionPopupControl
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.BackColor = System.Drawing.SystemColors.ControlLight
            Me.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.Controls.Add(Me.DaysNumericUpDown)
            Me.Controls.Add(Me.Label2)
            Me.Controls.Add(Me.Label1)
            Me.Controls.Add(Me.CancelButton)
            Me.Controls.Add(Me.AcceptButton)
            Me.Location = New System.Drawing.Point(16, 143)
            Me.Name = "ExtensionPopupControl"
            Me.Size = New System.Drawing.Size(234, 130)
            CType(Me.DaysNumericUpDown, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)
            Me.PerformLayout()

        End Sub

        Friend WithEvents AcceptButton As Button
        Friend WithEvents Label2 As Label
        Friend WithEvents Label1 As Label
        Friend WithEvents CancelButton As Button
        Friend WithEvents DaysNumericUpDown As NumericUpDown
    End Class
End Namespace