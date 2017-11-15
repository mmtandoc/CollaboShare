<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class HouseholdControl
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
        Me.HouseholdNameLabel = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'HouseholdNameLabel
        '
        Me.HouseholdNameLabel.AutoSize = True
        Me.HouseholdNameLabel.BackColor = System.Drawing.SystemColors.Control
        Me.HouseholdNameLabel.Font = New System.Drawing.Font("Roboto", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.HouseholdNameLabel.Location = New System.Drawing.Point(8, 6)
        Me.HouseholdNameLabel.Name = "HouseholdNameLabel"
        Me.HouseholdNameLabel.Size = New System.Drawing.Size(69, 25)
        Me.HouseholdNameLabel.TabIndex = 0
        Me.HouseholdNameLabel.Text = "Label1"
        '
        'HouseholdControl
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.HouseholdNameLabel)
        Me.Name = "HouseholdControl"
        Me.Size = New System.Drawing.Size(261, 40)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents HouseholdNameLabel As Label
End Class
