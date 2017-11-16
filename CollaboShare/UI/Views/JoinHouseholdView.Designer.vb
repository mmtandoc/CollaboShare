﻿Namespace UI.Views
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial Class JoinHouseholdView
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
            Me.FlowLayoutPanel1 = New System.Windows.Forms.FlowLayoutPanel()
            Me.Panel1 = New System.Windows.Forms.Panel()
            Me.Label1 = New System.Windows.Forms.Label()
            Me.Household1Button = New System.Windows.Forms.Button()
            Me.Household2Button = New System.Windows.Forms.Button()
            Me.Household3Button = New System.Windows.Forms.Button()
            Me.NewHouseholdButton = New System.Windows.Forms.Button()
            Me.HouseholdsFlowLayoutPanel = New System.Windows.Forms.FlowLayoutPanel()
            Me.FlowLayoutPanel1.SuspendLayout()
            Me.Panel1.SuspendLayout()
            Me.HouseholdsFlowLayoutPanel.SuspendLayout()
            Me.SuspendLayout()
            '
            'FlowLayoutPanel1
            '
            Me.FlowLayoutPanel1.Controls.Add(Me.Panel1)
            Me.FlowLayoutPanel1.Controls.Add(Me.HouseholdsFlowLayoutPanel)
            Me.FlowLayoutPanel1.Controls.Add(Me.NewHouseholdButton)
            Me.FlowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.FlowLayoutPanel1.Location = New System.Drawing.Point(0, 0)
            Me.FlowLayoutPanel1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
            Me.FlowLayoutPanel1.Name = "FlowLayoutPanel1"
            Me.FlowLayoutPanel1.Size = New System.Drawing.Size(400, 640)
            Me.FlowLayoutPanel1.TabIndex = 0
            '
            'Panel1
            '
            Me.Panel1.BackColor = System.Drawing.SystemColors.ControlDark
            Me.Panel1.Controls.Add(Me.Label1)
            Me.Panel1.Location = New System.Drawing.Point(4, 5)
            Me.Panel1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
            Me.Panel1.Name = "Panel1"
            Me.Panel1.Size = New System.Drawing.Size(392, 62)
            Me.Panel1.TabIndex = 2
            '
            'Label1
            '
            Me.Label1.AutoSize = True
            Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label1.Location = New System.Drawing.Point(4, 11)
            Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
            Me.Label1.Name = "Label1"
            Me.Label1.Size = New System.Drawing.Size(251, 33)
            Me.Label1.TabIndex = 1
            Me.Label1.Text = "Join a household"
            '
            'Household1Button
            '
            Me.Household1Button.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Household1Button.Location = New System.Drawing.Point(4, 5)
            Me.Household1Button.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
            Me.Household1Button.Name = "Household1Button"
            Me.Household1Button.Size = New System.Drawing.Size(392, 55)
            Me.Household1Button.TabIndex = 6
            Me.Household1Button.Text = "Household 1"
            Me.Household1Button.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            Me.Household1Button.UseVisualStyleBackColor = True
            '
            'Household2Button
            '
            Me.Household2Button.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Household2Button.Location = New System.Drawing.Point(4, 70)
            Me.Household2Button.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
            Me.Household2Button.Name = "Household2Button"
            Me.Household2Button.Size = New System.Drawing.Size(392, 55)
            Me.Household2Button.TabIndex = 7
            Me.Household2Button.Text = "Household 2"
            Me.Household2Button.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            Me.Household2Button.UseVisualStyleBackColor = True
            '
            'Household3Button
            '
            Me.Household3Button.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Household3Button.Location = New System.Drawing.Point(4, 135)
            Me.Household3Button.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
            Me.Household3Button.Name = "Household3Button"
            Me.Household3Button.Size = New System.Drawing.Size(392, 55)
            Me.Household3Button.TabIndex = 8
            Me.Household3Button.Text = "Household 3"
            Me.Household3Button.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            Me.Household3Button.UseVisualStyleBackColor = True
            '
            'NewHouseholdButton
            '
            Me.NewHouseholdButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.NewHouseholdButton.Location = New System.Drawing.Point(4, 278)
            Me.NewHouseholdButton.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
            Me.NewHouseholdButton.Name = "NewHouseholdButton"
            Me.NewHouseholdButton.Size = New System.Drawing.Size(392, 55)
            Me.NewHouseholdButton.TabIndex = 9
            Me.NewHouseholdButton.Text = "+ Create new household"
            Me.NewHouseholdButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            Me.NewHouseholdButton.UseVisualStyleBackColor = True
            '
            'HouseholdsFlowLayoutPanel
            '
            Me.HouseholdsFlowLayoutPanel.AutoSize = True
            Me.HouseholdsFlowLayoutPanel.Controls.Add(Me.Household1Button)
            Me.HouseholdsFlowLayoutPanel.Controls.Add(Me.Household2Button)
            Me.HouseholdsFlowLayoutPanel.Controls.Add(Me.Household3Button)
            Me.HouseholdsFlowLayoutPanel.Location = New System.Drawing.Point(3, 75)
            Me.HouseholdsFlowLayoutPanel.Name = "HouseholdsFlowLayoutPanel"
            Me.HouseholdsFlowLayoutPanel.Size = New System.Drawing.Size(400, 195)
            Me.HouseholdsFlowLayoutPanel.TabIndex = 10
            '
            'JoinHouseholdView
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.Controls.Add(Me.FlowLayoutPanel1)
            Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
            Me.Name = "JoinHouseholdView"
            Me.Size = New System.Drawing.Size(400, 640)
            Me.FlowLayoutPanel1.ResumeLayout(False)
            Me.FlowLayoutPanel1.PerformLayout()
            Me.Panel1.ResumeLayout(False)
            Me.Panel1.PerformLayout()
            Me.HouseholdsFlowLayoutPanel.ResumeLayout(False)
            Me.ResumeLayout(False)

        End Sub

        Friend WithEvents FlowLayoutPanel1 As FlowLayoutPanel
        Friend WithEvents Panel1 As Panel
        Friend WithEvents Label1 As Label
        Friend WithEvents Household1Button As Button
        Friend WithEvents Household2Button As Button
        Friend WithEvents Household3Button As Button
        Friend WithEvents NewHouseholdButton As Button
        Friend WithEvents HouseholdsFlowLayoutPanel As FlowLayoutPanel
    End Class
End NameSpace