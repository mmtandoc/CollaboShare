Namespace UI
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
    Partial Class ControlForm
        Inherits System.Windows.Forms.Form

        'Form overrides dispose to clean up the component list.
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
            Me.Scenario1Button = New System.Windows.Forms.Button()
            Me.Button1 = New System.Windows.Forms.Button()
            Me.SuspendLayout()
            '
            'Scenario1Button
            '
            Me.Scenario1Button.Location = New System.Drawing.Point(12, 34)
            Me.Scenario1Button.Name = "Scenario1Button"
            Me.Scenario1Button.Size = New System.Drawing.Size(75, 23)
            Me.Scenario1Button.TabIndex = 0
            Me.Scenario1Button.Text = "Scenario 1"
            Me.Scenario1Button.UseVisualStyleBackColor = True
            '
            'Button1
            '
            Me.Button1.Location = New System.Drawing.Point(129, 34)
            Me.Button1.Name = "Button1"
            Me.Button1.Size = New System.Drawing.Size(75, 23)
            Me.Button1.TabIndex = 1
            Me.Button1.Text = "Scenario 2"
            Me.Button1.UseVisualStyleBackColor = True
            '
            'ControlForm
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(216, 85)
            Me.Controls.Add(Me.Button1)
            Me.Controls.Add(Me.Scenario1Button)
            Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
            Me.Margin = New System.Windows.Forms.Padding(2)
            Me.MaximizeBox = False
            Me.Name = "ControlForm"
            Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
            Me.Text = "A7 Control"
            Me.ResumeLayout(False)

        End Sub

        Friend WithEvents Scenario1Button As Button
        Friend WithEvents Button1 As Button
    End Class
End Namespace