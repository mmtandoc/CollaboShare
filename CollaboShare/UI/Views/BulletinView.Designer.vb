Namespace UI.Views
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
    Partial Class BulletinView
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.BackButton = New System.Windows.Forms.Button()
        Me.FlowLayoutPanel1 = New System.Windows.Forms.FlowLayoutPanel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TradesFlowLayoutPanel = New System.Windows.Forms.FlowLayoutPanel()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.NewTradeButton = New System.Windows.Forms.Button()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TradesTabPage = New System.Windows.Forms.TabPage()
        Me.PollsTabPage = New System.Windows.Forms.TabPage()
        Me.FlowLayoutPanel2 = New System.Windows.Forms.FlowLayoutPanel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.CurrentPollsFlowLayoutPanel = New System.Windows.Forms.FlowLayoutPanel()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.CreatePollButton = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.PastPollsFlowLayoutPanel = New System.Windows.Forms.FlowLayoutPanel()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout
        Me.FlowLayoutPanel1.SuspendLayout
        Me.TradesFlowLayoutPanel.SuspendLayout
        Me.TabControl1.SuspendLayout
        Me.TradesTabPage.SuspendLayout
        Me.PollsTabPage.SuspendLayout
        Me.FlowLayoutPanel2.SuspendLayout
        Me.CurrentPollsFlowLayoutPanel.SuspendLayout
        Me.PastPollsFlowLayoutPanel.SuspendLayout
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
        Me.Panel1.TabIndex = 15
        '
        'Label1
        '
        Me.Label1.AutoSize = true
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.Label1.Location = New System.Drawing.Point(3, 7)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(140, 24)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Bulletin Board"
        '
        'BackButton
        '
        Me.BackButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.BackButton.Location = New System.Drawing.Point(17, 378)
        Me.BackButton.Name = "BackButton"
        Me.BackButton.Size = New System.Drawing.Size(75, 27)
        Me.BackButton.TabIndex = 18
        Me.BackButton.Text = "Back"
        Me.BackButton.UseVisualStyleBackColor = true
        '
        'FlowLayoutPanel1
        '
        Me.FlowLayoutPanel1.AutoScroll = true
        Me.FlowLayoutPanel1.Controls.Add(Me.Label2)
        Me.FlowLayoutPanel1.Controls.Add(Me.TradesFlowLayoutPanel)
        Me.FlowLayoutPanel1.Controls.Add(Me.NewTradeButton)
        Me.FlowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FlowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown
        Me.FlowLayoutPanel1.Location = New System.Drawing.Point(3, 3)
        Me.FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        Me.FlowLayoutPanel1.Size = New System.Drawing.Size(250, 279)
        Me.FlowLayoutPanel1.TabIndex = 19
        '
        'Label2
        '
        Me.Label2.AutoSize = true
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline),System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.Label2.Location = New System.Drawing.Point(3, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(196, 20)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Current trade requests:"
        '
        'TradesFlowLayoutPanel
        '
        Me.TradesFlowLayoutPanel.AutoSize = true
        Me.TradesFlowLayoutPanel.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.TradesFlowLayoutPanel.Controls.Add(Me.Label5)
        Me.TradesFlowLayoutPanel.FlowDirection = System.Windows.Forms.FlowDirection.TopDown
        Me.TradesFlowLayoutPanel.Location = New System.Drawing.Point(3, 23)
        Me.TradesFlowLayoutPanel.Name = "TradesFlowLayoutPanel"
        Me.TradesFlowLayoutPanel.Size = New System.Drawing.Size(138, 20)
        Me.TradesFlowLayoutPanel.TabIndex = 1
        '
        'Label5
        '
        Me.Label5.AutoSize = true
        Me.Label5.Location = New System.Drawing.Point(3, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(132, 20)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "No current trades"
        '
        'NewTradeButton
        '
        Me.NewTradeButton.Location = New System.Drawing.Point(3, 49)
        Me.NewTradeButton.Name = "NewTradeButton"
        Me.NewTradeButton.Size = New System.Drawing.Size(221, 31)
        Me.NewTradeButton.TabIndex = 0
        Me.NewTradeButton.Text = "+ Make Trade Request"
        Me.NewTradeButton.UseVisualStyleBackColor = true
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TradesTabPage)
        Me.TabControl1.Controls.Add(Me.PollsTabPage)
        Me.TabControl1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.TabControl1.Location = New System.Drawing.Point(3, 46)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(264, 318)
        Me.TabControl1.TabIndex = 0
        '
        'TradesTabPage
        '
        Me.TradesTabPage.Controls.Add(Me.FlowLayoutPanel1)
        Me.TradesTabPage.Location = New System.Drawing.Point(4, 29)
        Me.TradesTabPage.Name = "TradesTabPage"
        Me.TradesTabPage.Padding = New System.Windows.Forms.Padding(3)
        Me.TradesTabPage.Size = New System.Drawing.Size(256, 285)
        Me.TradesTabPage.TabIndex = 0
        Me.TradesTabPage.Text = "Trading"
        Me.TradesTabPage.UseVisualStyleBackColor = true
        '
        'PollsTabPage
        '
        Me.PollsTabPage.Controls.Add(Me.FlowLayoutPanel2)
        Me.PollsTabPage.Location = New System.Drawing.Point(4, 29)
        Me.PollsTabPage.Name = "PollsTabPage"
        Me.PollsTabPage.Padding = New System.Windows.Forms.Padding(3)
        Me.PollsTabPage.Size = New System.Drawing.Size(256, 285)
        Me.PollsTabPage.TabIndex = 1
        Me.PollsTabPage.Text = "Polls"
        Me.PollsTabPage.UseVisualStyleBackColor = true
        '
        'FlowLayoutPanel2
        '
        Me.FlowLayoutPanel2.Controls.Add(Me.Label3)
        Me.FlowLayoutPanel2.Controls.Add(Me.CurrentPollsFlowLayoutPanel)
        Me.FlowLayoutPanel2.Controls.Add(Me.CreatePollButton)
        Me.FlowLayoutPanel2.Controls.Add(Me.Label6)
        Me.FlowLayoutPanel2.Controls.Add(Me.PastPollsFlowLayoutPanel)
        Me.FlowLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FlowLayoutPanel2.FlowDirection = System.Windows.Forms.FlowDirection.TopDown
        Me.FlowLayoutPanel2.Location = New System.Drawing.Point(3, 3)
        Me.FlowLayoutPanel2.Name = "FlowLayoutPanel2"
        Me.FlowLayoutPanel2.Size = New System.Drawing.Size(250, 279)
        Me.FlowLayoutPanel2.TabIndex = 1
        '
        'Label3
        '
        Me.Label3.AutoSize = true
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline),System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.Label3.Location = New System.Drawing.Point(3, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(117, 20)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Current Polls:"
        '
        'CurrentPollsFlowLayoutPanel
        '
        Me.CurrentPollsFlowLayoutPanel.AutoSize = true
        Me.CurrentPollsFlowLayoutPanel.Controls.Add(Me.Label4)
        Me.CurrentPollsFlowLayoutPanel.Location = New System.Drawing.Point(3, 23)
        Me.CurrentPollsFlowLayoutPanel.Name = "CurrentPollsFlowLayoutPanel"
        Me.CurrentPollsFlowLayoutPanel.Size = New System.Drawing.Size(125, 20)
        Me.CurrentPollsFlowLayoutPanel.TabIndex = 1
        '
        'Label4
        '
        Me.Label4.AutoSize = true
        Me.Label4.Location = New System.Drawing.Point(3, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(119, 20)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "No current polls"
        '
        'CreatePollButton
        '
        Me.CreatePollButton.Location = New System.Drawing.Point(3, 49)
        Me.CreatePollButton.Name = "CreatePollButton"
        Me.CreatePollButton.Size = New System.Drawing.Size(244, 29)
        Me.CreatePollButton.TabIndex = 2
        Me.CreatePollButton.Text = "+ Create New Poll"
        Me.CreatePollButton.UseVisualStyleBackColor = true
        '
        'Label6
        '
        Me.Label6.AutoSize = true
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline),System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.Label6.Location = New System.Drawing.Point(3, 81)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(93, 20)
        Me.Label6.TabIndex = 3
        Me.Label6.Text = "Past Polls:"
        '
        'PastPollsFlowLayoutPanel
        '
        Me.PastPollsFlowLayoutPanel.AutoSize = true
        Me.PastPollsFlowLayoutPanel.Controls.Add(Me.Label7)
        Me.PastPollsFlowLayoutPanel.Location = New System.Drawing.Point(3, 104)
        Me.PastPollsFlowLayoutPanel.Name = "PastPollsFlowLayoutPanel"
        Me.PastPollsFlowLayoutPanel.Size = New System.Drawing.Size(106, 20)
        Me.PastPollsFlowLayoutPanel.TabIndex = 4
        '
        'Label7
        '
        Me.Label7.AutoSize = true
        Me.Label7.Location = New System.Drawing.Point(3, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(100, 20)
        Me.Label7.TabIndex = 0
        Me.Label7.Text = "No past polls"
        '
        'BulletinView
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.BackButton)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "BulletinView"
        Me.Size = New System.Drawing.Size(267, 416)
        Me.Panel1.ResumeLayout(false)
        Me.Panel1.PerformLayout
        Me.FlowLayoutPanel1.ResumeLayout(false)
        Me.FlowLayoutPanel1.PerformLayout
        Me.TradesFlowLayoutPanel.ResumeLayout(false)
        Me.TradesFlowLayoutPanel.PerformLayout
        Me.TabControl1.ResumeLayout(false)
        Me.TradesTabPage.ResumeLayout(false)
        Me.PollsTabPage.ResumeLayout(false)
        Me.FlowLayoutPanel2.ResumeLayout(false)
        Me.FlowLayoutPanel2.PerformLayout
        Me.CurrentPollsFlowLayoutPanel.ResumeLayout(false)
        Me.CurrentPollsFlowLayoutPanel.PerformLayout
        Me.PastPollsFlowLayoutPanel.ResumeLayout(false)
        Me.PastPollsFlowLayoutPanel.PerformLayout
        Me.ResumeLayout(false)

End Sub

        Friend WithEvents Panel1 As Panel
        Friend WithEvents Label1 As Label
        Friend WithEvents BackButton As Button
        Friend WithEvents FlowLayoutPanel1 As FlowLayoutPanel
        Friend WithEvents Label2 As Label
        Friend WithEvents NewTradeButton As Button
        Friend WithEvents TradesFlowLayoutPanel As FlowLayoutPanel
        Friend WithEvents Label5 As Label
        Friend WithEvents TabControl1 As TabControl
        Friend WithEvents TradesTabPage As TabPage
        Friend WithEvents PollsTabPage As TabPage
        Friend WithEvents Label3 As Label
        Friend WithEvents FlowLayoutPanel2 As FlowLayoutPanel
        Friend WithEvents CurrentPollsFlowLayoutPanel As FlowLayoutPanel
        Friend WithEvents Label4 As Label
        Friend WithEvents CreatePollButton As Button
        Friend WithEvents Label6 As Label
        Friend WithEvents PastPollsFlowLayoutPanel As FlowLayoutPanel
        Friend WithEvents Label7 As Label
    End Class
End Namespace