Namespace UI.Controls
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial Class CounterofferItemControl
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
        Me.components = New System.ComponentModel.Container()
        Me.CounterOfferButton = New System.Windows.Forms.Button()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.EditToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DeleteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OverflowButton = New System.Windows.Forms.Button()
        Me.ContextMenuStrip1.SuspendLayout
        Me.SuspendLayout
        '
        'CounterOfferButton
        '
        Me.CounterOfferButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.CounterOfferButton.Location = New System.Drawing.Point(2, 3)
        Me.CounterOfferButton.Name = "CounterOfferButton"
        Me.CounterOfferButton.Size = New System.Drawing.Size(216, 31)
        Me.CounterOfferButton.TabIndex = 12
        Me.CounterOfferButton.Text = "Offer"
        Me.CounterOfferButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.CounterOfferButton.UseVisualStyleBackColor = true
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.EditToolStripMenuItem, Me.DeleteToolStripMenuItem})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(108, 48)
        '
        'EditToolStripMenuItem
        '
        Me.EditToolStripMenuItem.Name = "EditToolStripMenuItem"
        Me.EditToolStripMenuItem.Size = New System.Drawing.Size(107, 22)
        Me.EditToolStripMenuItem.Text = "Edit"
        '
        'DeleteToolStripMenuItem
        '
        Me.DeleteToolStripMenuItem.Name = "DeleteToolStripMenuItem"
        Me.DeleteToolStripMenuItem.Size = New System.Drawing.Size(107, 22)
        Me.DeleteToolStripMenuItem.Text = "Delete"
        '
        'OverflowButton
        '
        Me.OverflowButton.BackgroundImage = Global.CollaboShare.My.Resources.Resources.MoreVertical
        Me.OverflowButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.OverflowButton.Location = New System.Drawing.Point(223, 3)
        Me.OverflowButton.Margin = New System.Windows.Forms.Padding(2)
        Me.OverflowButton.Name = "OverflowButton"
        Me.OverflowButton.Size = New System.Drawing.Size(22, 31)
        Me.OverflowButton.TabIndex = 13
        Me.OverflowButton.UseVisualStyleBackColor = true
        '
        'CounterofferItemControl
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.CounterOfferButton)
        Me.Controls.Add(Me.OverflowButton)
        Me.Name = "CounterofferItemControl"
        Me.Size = New System.Drawing.Size(247, 37)
        Me.ContextMenuStrip1.ResumeLayout(false)
        Me.ResumeLayout(false)

End Sub

        Friend WithEvents CounterOfferButton As Button
        Friend WithEvents ContextMenuStrip1 As ContextMenuStrip
        Friend WithEvents EditToolStripMenuItem As ToolStripMenuItem
        Friend WithEvents DeleteToolStripMenuItem As ToolStripMenuItem
        Friend WithEvents OverflowButton As Button
    End Class
End NameSpace