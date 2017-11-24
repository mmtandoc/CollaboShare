Namespace UI.Controls
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
    Partial Class HousemateItemControl
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
        Me.components = New System.ComponentModel.Container()
        Me.OverflowButton = New System.Windows.Forms.Button()
        Me.HousemateButton = New System.Windows.Forms.Button()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.RemoveToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ContextMenuStrip1.SuspendLayout
        Me.SuspendLayout
        '
        'OverflowButton
        '
        Me.OverflowButton.BackgroundImage = Global.CollaboShare.My.Resources.Resources.MoreVertical
        Me.OverflowButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.OverflowButton.Location = New System.Drawing.Point(213, 4)
        Me.OverflowButton.Margin = New System.Windows.Forms.Padding(2)
        Me.OverflowButton.Name = "OverflowButton"
        Me.OverflowButton.Size = New System.Drawing.Size(27, 35)
        Me.OverflowButton.TabIndex = 11
        Me.OverflowButton.UseVisualStyleBackColor = true
        '
        'HousemateButton
        '
        Me.HousemateButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.HousemateButton.Location = New System.Drawing.Point(2, 3)
        Me.HousemateButton.Name = "HousemateButton"
        Me.HousemateButton.Size = New System.Drawing.Size(206, 36)
        Me.HousemateButton.TabIndex = 10
        Me.HousemateButton.Text = "HousemateName"
        Me.HousemateButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.HousemateButton.UseVisualStyleBackColor = true
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.RemoveToolStripMenuItem})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(118, 26)
        '
        'RemoveToolStripMenuItem
        '
        Me.RemoveToolStripMenuItem.Name = "RemoveToolStripMenuItem"
        Me.RemoveToolStripMenuItem.Size = New System.Drawing.Size(117, 22)
        Me.RemoveToolStripMenuItem.Text = "Remove"
        '
        'HousemateItemControl
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.OverflowButton)
        Me.Controls.Add(Me.HousemateButton)
        Me.Name = "HousemateItemControl"
        Me.Size = New System.Drawing.Size(245, 42)
        Me.ContextMenuStrip1.ResumeLayout(false)
        Me.ResumeLayout(false)

End Sub

        Friend WithEvents OverflowButton As Button
        Friend WithEvents HousemateButton As Button
        Friend WithEvents ContextMenuStrip1 As ContextMenuStrip
        Friend WithEvents RemoveToolStripMenuItem As ToolStripMenuItem
    End Class
End Namespace