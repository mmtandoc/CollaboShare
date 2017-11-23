Namespace UI.Views
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial Class ViewTradeView
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.BackButton = New System.Windows.Forms.Button()
        Me.FlowLayoutPanel1 = New System.Windows.Forms.FlowLayoutPanel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.CreatorLabel = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.OfferedFlowLayoutPanel = New System.Windows.Forms.FlowLayoutPanel()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.CounterofferFlowLayoutPanel = New System.Windows.Forms.FlowLayoutPanel()
        Me.CounterofferButton = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout
        Me.FlowLayoutPanel1.SuspendLayout
        Me.CounterofferFlowLayoutPanel.SuspendLayout
        Me.SuspendLayout
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.ControlDark
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(267, 40)
        Me.Panel1.TabIndex = 17
        '
        'Label1
        '
        Me.Label1.AutoSize = true
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.Label1.Location = New System.Drawing.Point(3, 7)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(156, 24)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "View trade offer"
        '
        'BackButton
        '
        Me.BackButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.BackButton.Location = New System.Drawing.Point(16, 371)
        Me.BackButton.Name = "BackButton"
        Me.BackButton.Size = New System.Drawing.Size(75, 26)
        Me.BackButton.TabIndex = 20
        Me.BackButton.Text = "Back"
        Me.BackButton.UseVisualStyleBackColor = true
        '
        'FlowLayoutPanel1
        '
        Me.FlowLayoutPanel1.AutoScroll = true
        Me.FlowLayoutPanel1.Controls.Add(Me.Label2)
        Me.FlowLayoutPanel1.Controls.Add(Me.CreatorLabel)
        Me.FlowLayoutPanel1.Controls.Add(Me.Label3)
        Me.FlowLayoutPanel1.Controls.Add(Me.OfferedFlowLayoutPanel)
        Me.FlowLayoutPanel1.Controls.Add(Me.Label4)
        Me.FlowLayoutPanel1.Controls.Add(Me.CounterofferFlowLayoutPanel)
        Me.FlowLayoutPanel1.Controls.Add(Me.CounterofferButton)
        Me.FlowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown
        Me.FlowLayoutPanel1.Location = New System.Drawing.Point(7, 46)
        Me.FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        Me.FlowLayoutPanel1.Size = New System.Drawing.Size(249, 293)
        Me.FlowLayoutPanel1.TabIndex = 22
        '
        'Label2
        '
        Me.Label2.AutoSize = true
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.Label2.Location = New System.Drawing.Point(3, 4)
        Me.Label2.Margin = New System.Windows.Forms.Padding(3, 4, 3, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(55, 16)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Creator:"
        '
        'CreatorLabel
        '
        Me.CreatorLabel.AutoSize = true
        Me.CreatorLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.CreatorLabel.Location = New System.Drawing.Point(3, 20)
        Me.CreatorLabel.Name = "CreatorLabel"
        Me.CreatorLabel.Size = New System.Drawing.Size(104, 20)
        Me.CreatorLabel.TabIndex = 1
        Me.CreatorLabel.Text = "CreatorName"
        '
        'Label3
        '
        Me.Label3.AutoSize = true
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.Label3.Location = New System.Drawing.Point(3, 44)
        Me.Label3.Margin = New System.Windows.Forms.Padding(3, 4, 3, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(99, 16)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Chores offered:"
        '
        'OfferedFlowLayoutPanel
        '
        Me.OfferedFlowLayoutPanel.AutoSize = true
        Me.OfferedFlowLayoutPanel.FlowDirection = System.Windows.Forms.FlowDirection.TopDown
        Me.OfferedFlowLayoutPanel.Location = New System.Drawing.Point(3, 63)
        Me.OfferedFlowLayoutPanel.Name = "OfferedFlowLayoutPanel"
        Me.OfferedFlowLayoutPanel.Size = New System.Drawing.Size(0, 0)
        Me.OfferedFlowLayoutPanel.TabIndex = 3
        '
        'Label4
        '
        Me.Label4.AutoSize = true
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.Label4.Location = New System.Drawing.Point(3, 70)
        Me.Label4.Margin = New System.Windows.Forms.Padding(3, 4, 3, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(94, 16)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Counter-offers:"
        '
        'CounterofferFlowLayoutPanel
        '
        Me.CounterofferFlowLayoutPanel.AutoSize = true
        Me.CounterofferFlowLayoutPanel.Controls.Add(Me.Label5)
        Me.CounterofferFlowLayoutPanel.FlowDirection = System.Windows.Forms.FlowDirection.TopDown
        Me.CounterofferFlowLayoutPanel.Location = New System.Drawing.Point(3, 89)
        Me.CounterofferFlowLayoutPanel.Name = "CounterofferFlowLayoutPanel"
        Me.CounterofferFlowLayoutPanel.Size = New System.Drawing.Size(39, 13)
        Me.CounterofferFlowLayoutPanel.TabIndex = 5
        '
        'CounterofferButton
        '
        Me.CounterofferButton.Location = New System.Drawing.Point(3, 108)
        Me.CounterofferButton.Name = "CounterofferButton"
        Me.CounterofferButton.Size = New System.Drawing.Size(121, 29)
        Me.CounterofferButton.TabIndex = 6
        Me.CounterofferButton.Text = "Make Counter-offer"
        Me.CounterofferButton.UseVisualStyleBackColor = true
        '
        'Label5
        '
        Me.Label5.AutoSize = true
        Me.Label5.Location = New System.Drawing.Point(3, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(33, 13)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "None"
        '
        'ViewTradeView
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.FlowLayoutPanel1)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.BackButton)
        Me.Name = "ViewTradeView"
        Me.Size = New System.Drawing.Size(267, 416)
        Me.Panel1.ResumeLayout(false)
        Me.Panel1.PerformLayout
        Me.FlowLayoutPanel1.ResumeLayout(false)
        Me.FlowLayoutPanel1.PerformLayout
        Me.CounterofferFlowLayoutPanel.ResumeLayout(false)
        Me.CounterofferFlowLayoutPanel.PerformLayout
        Me.ResumeLayout(false)

End Sub

        Friend WithEvents Panel1 As Panel
        Friend WithEvents Label1 As Label
        Friend WithEvents BackButton As Button
        Friend WithEvents FlowLayoutPanel1 As FlowLayoutPanel
        Friend WithEvents Label2 As Label
        Friend WithEvents CreatorLabel As Label
        Friend WithEvents Label3 As Label
        Friend WithEvents OfferedFlowLayoutPanel As FlowLayoutPanel
        Friend WithEvents Label4 As Label
        Friend WithEvents CounterofferFlowLayoutPanel As FlowLayoutPanel
        Friend WithEvents CounterofferButton As Button
        Friend WithEvents Label5 As Label
    End Class
End NameSpace