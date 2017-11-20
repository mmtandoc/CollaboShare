Namespace UI.Views
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial Class HouseholdView
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
            Me.Label6 = New System.Windows.Forms.Label()
            Me.FlowLayoutPanel1 = New System.Windows.Forms.FlowLayoutPanel()
            Me.Label5 = New System.Windows.Forms.Label()
            Me.NameLabel = New System.Windows.Forms.Label()
            Me.Label4 = New System.Windows.Forms.Label()
            Me.AddressLabel = New System.Windows.Forms.Label()
            Me.Label3 = New System.Windows.Forms.Label()
            Me.HousemateFlowLayoutPanel = New System.Windows.Forms.FlowLayoutPanel()
            Me.BackButton = New System.Windows.Forms.Button()
            Me.WithdrawButton = New System.Windows.Forms.Button()
            Me.Panel1.SuspendLayout()
            Me.FlowLayoutPanel1.SuspendLayout()
            Me.SuspendLayout()
            '
            'Panel1
            '
            Me.Panel1.BackColor = System.Drawing.SystemColors.ControlDark
            Me.Panel1.Controls.Add(Me.Label6)
            Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
            Me.Panel1.Location = New System.Drawing.Point(0, 0)
            Me.Panel1.Name = "Panel1"
            Me.Panel1.Size = New System.Drawing.Size(267, 40)
            Me.Panel1.TabIndex = 19
            '
            'Label6
            '
            Me.Label6.AutoSize = True
            Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label6.Location = New System.Drawing.Point(3, 7)
            Me.Label6.Name = "Label6"
            Me.Label6.Size = New System.Drawing.Size(159, 24)
            Me.Label6.TabIndex = 1
            Me.Label6.Text = "Your household"
            '
            'FlowLayoutPanel1
            '
            Me.FlowLayoutPanel1.Controls.Add(Me.Label5)
            Me.FlowLayoutPanel1.Controls.Add(Me.NameLabel)
            Me.FlowLayoutPanel1.Controls.Add(Me.Label4)
            Me.FlowLayoutPanel1.Controls.Add(Me.AddressLabel)
            Me.FlowLayoutPanel1.Controls.Add(Me.Label3)
            Me.FlowLayoutPanel1.Controls.Add(Me.HousemateFlowLayoutPanel)
            Me.FlowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown
            Me.FlowLayoutPanel1.Location = New System.Drawing.Point(0, 51)
            Me.FlowLayoutPanel1.Name = "FlowLayoutPanel1"
            Me.FlowLayoutPanel1.Padding = New System.Windows.Forms.Padding(5, 0, 5, 0)
            Me.FlowLayoutPanel1.Size = New System.Drawing.Size(264, 296)
            Me.FlowLayoutPanel1.TabIndex = 20
            '
            'Label5
            '
            Me.Label5.AutoSize = True
            Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label5.Location = New System.Drawing.Point(8, 0)
            Me.Label5.Name = "Label5"
            Me.Label5.Size = New System.Drawing.Size(44, 15)
            Me.Label5.TabIndex = 10
            Me.Label5.Text = "Name:"
            '
            'NameLabel
            '
            Me.NameLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.NameLabel.Location = New System.Drawing.Point(8, 15)
            Me.NameLabel.Name = "NameLabel"
            Me.NameLabel.Size = New System.Drawing.Size(231, 27)
            Me.NameLabel.TabIndex = 2
            Me.NameLabel.Text = "HouseholdName"
            Me.NameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            '
            'Label4
            '
            Me.Label4.AutoSize = True
            Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label4.Location = New System.Drawing.Point(8, 42)
            Me.Label4.Name = "Label4"
            Me.Label4.Size = New System.Drawing.Size(54, 15)
            Me.Label4.TabIndex = 9
            Me.Label4.Text = "Address:"
            '
            'AddressLabel
            '
            Me.AddressLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.AddressLabel.Location = New System.Drawing.Point(8, 57)
            Me.AddressLabel.Name = "AddressLabel"
            Me.AddressLabel.Size = New System.Drawing.Size(231, 27)
            Me.AddressLabel.TabIndex = 5
            Me.AddressLabel.Text = "Address"
            Me.AddressLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            '
            'Label3
            '
            Me.Label3.AutoSize = True
            Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label3.Location = New System.Drawing.Point(8, 84)
            Me.Label3.Name = "Label3"
            Me.Label3.Size = New System.Drawing.Size(80, 15)
            Me.Label3.TabIndex = 8
            Me.Label3.Text = "Housemates:"
            '
            'HousemateFlowLayoutPanel
            '
            Me.HousemateFlowLayoutPanel.FlowDirection = System.Windows.Forms.FlowDirection.TopDown
            Me.HousemateFlowLayoutPanel.Location = New System.Drawing.Point(8, 102)
            Me.HousemateFlowLayoutPanel.Name = "HousemateFlowLayoutPanel"
            Me.HousemateFlowLayoutPanel.Size = New System.Drawing.Size(250, 180)
            Me.HousemateFlowLayoutPanel.TabIndex = 11
            '
            'BackButton
            '
            Me.BackButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.BackButton.Location = New System.Drawing.Point(10, 385)
            Me.BackButton.Name = "BackButton"
            Me.BackButton.Size = New System.Drawing.Size(75, 27)
            Me.BackButton.TabIndex = 21
            Me.BackButton.Text = "Back"
            Me.BackButton.UseVisualStyleBackColor = True
            '
            'WithdrawButton
            '
            Me.WithdrawButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.WithdrawButton.Location = New System.Drawing.Point(144, 371)
            Me.WithdrawButton.Name = "WithdrawButton"
            Me.WithdrawButton.Size = New System.Drawing.Size(114, 41)
            Me.WithdrawButton.TabIndex = 12
            Me.WithdrawButton.Text = "Withdraw from household"
            Me.WithdrawButton.UseVisualStyleBackColor = True
            '
            'HouseholdView
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.Controls.Add(Me.Panel1)
            Me.Controls.Add(Me.FlowLayoutPanel1)
            Me.Controls.Add(Me.BackButton)
            Me.Controls.Add(Me.WithdrawButton)
            Me.Margin = New System.Windows.Forms.Padding(2)
            Me.Name = "HouseholdView"
            Me.Size = New System.Drawing.Size(267, 416)
            Me.Panel1.ResumeLayout(False)
            Me.Panel1.PerformLayout()
            Me.FlowLayoutPanel1.ResumeLayout(False)
            Me.FlowLayoutPanel1.PerformLayout()
            Me.ResumeLayout(False)

        End Sub

        Friend WithEvents Panel1 As Panel
        Friend WithEvents Label6 As Label
        Friend WithEvents FlowLayoutPanel1 As FlowLayoutPanel
        Friend WithEvents Label5 As Label
        Friend WithEvents NameLabel As Label
        Friend WithEvents Label4 As Label
        Friend WithEvents AddressLabel As Label
        Friend WithEvents Label3 As Label
        Friend WithEvents BackButton As Button
        Friend WithEvents HousemateFlowLayoutPanel As FlowLayoutPanel
        Friend WithEvents WithdrawButton As Button
    End Class
End NameSpace