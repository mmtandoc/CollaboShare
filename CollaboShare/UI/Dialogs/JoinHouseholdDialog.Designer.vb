<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class JoinHouseholdDialog
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
        Me.CancelButton = New System.Windows.Forms.Button()
        Me.ConfirmButton = New System.Windows.Forms.Button()
        Me.DialogTextLabel = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'CancelButton
        '
        Me.CancelButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CancelButton.Location = New System.Drawing.Point(14, 69)
        Me.CancelButton.Name = "CancelButton"
        Me.CancelButton.Size = New System.Drawing.Size(75, 30)
        Me.CancelButton.TabIndex = 1
        Me.CancelButton.Text = "Cancel"
        Me.CancelButton.UseVisualStyleBackColor = True
        '
        'ConfirmButton
        '
        Me.ConfirmButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ConfirmButton.Location = New System.Drawing.Point(141, 69)
        Me.ConfirmButton.Name = "ConfirmButton"
        Me.ConfirmButton.Size = New System.Drawing.Size(75, 30)
        Me.ConfirmButton.TabIndex = 2
        Me.ConfirmButton.Text = "Request"
        Me.ConfirmButton.UseVisualStyleBackColor = True
        '
        'DialogTextLabel
        '
        Me.DialogTextLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DialogTextLabel.Location = New System.Drawing.Point(8, 8)
        Me.DialogTextLabel.Name = "DialogTextLabel"
        Me.DialogTextLabel.Size = New System.Drawing.Size(208, 53)
        Me.DialogTextLabel.TabIndex = 3
        Me.DialogTextLabel.Text = "Request to join HOUSEHOLD?"
        '
        'JoinHouseholdDialog
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Controls.Add(Me.DialogTextLabel)
        Me.Controls.Add(Me.ConfirmButton)
        Me.Controls.Add(Me.CancelButton)
        Me.Name = "JoinHouseholdDialog"
        Me.Size = New System.Drawing.Size(232, 106)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents CancelButton As Button
    Friend WithEvents ConfirmButton As Button
    Friend WithEvents DialogTextLabel As Label
End Class
