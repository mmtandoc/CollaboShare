Namespace UI
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial Class ControlForm
        Inherits System.Windows.Forms.Form

        'Form overrides dispose to clean up the component list.
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
            Me.Scenario1Button = New System.Windows.Forms.Button()
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
            'ControlForm
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(216, 85)
            Me.Controls.Add(Me.Scenario1Button)
            Me.Margin = New System.Windows.Forms.Padding(2)
            Me.Name = "ControlForm"
            Me.Text = "MainForm"
            Me.ResumeLayout(False)

        End Sub

        Friend WithEvents Scenario1Button As Button
    End Class
End NameSpace