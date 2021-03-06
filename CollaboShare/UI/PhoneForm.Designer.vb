﻿Imports CollaboShare.UI.Views

Namespace UI
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
    Partial Class PhoneForm
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
            Me.components = New System.ComponentModel.Container()
            Me.NavPanel = New System.Windows.Forms.Panel()
            Me.DistributionButton = New System.Windows.Forms.Button()
            Me.BulletinButton = New System.Windows.Forms.Button()
            Me.TodoListButton = New System.Windows.Forms.Button()
            Me.ChoresButton = New System.Windows.Forms.Button()
            Me.HouseholdButton = New System.Windows.Forms.Button()
            Me.ProfileButton = New System.Windows.Forms.Button()
            Me.ViewPanel = New System.Windows.Forms.Panel()
            Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
            Me.NavPanel.SuspendLayout()
            Me.SuspendLayout()
            '
            'NavPanel
            '
            Me.NavPanel.BackColor = System.Drawing.SystemColors.ControlLight
            Me.NavPanel.Controls.Add(Me.DistributionButton)
            Me.NavPanel.Controls.Add(Me.BulletinButton)
            Me.NavPanel.Controls.Add(Me.TodoListButton)
            Me.NavPanel.Controls.Add(Me.ChoresButton)
            Me.NavPanel.Controls.Add(Me.HouseholdButton)
            Me.NavPanel.Controls.Add(Me.ProfileButton)
            Me.NavPanel.Dock = System.Windows.Forms.DockStyle.Bottom
            Me.NavPanel.Location = New System.Drawing.Point(0, 416)
            Me.NavPanel.Name = "NavPanel"
            Me.NavPanel.Size = New System.Drawing.Size(267, 52)
            Me.NavPanel.TabIndex = 1
            '
            'DistributionButton
            '
            Me.DistributionButton.BackColor = System.Drawing.SystemColors.Control
            Me.DistributionButton.BackgroundImage = Global.CollaboShare.My.Resources.Resources.pie_chart_with_information
            Me.DistributionButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
            Me.DistributionButton.Location = New System.Drawing.Point(138, 7)
            Me.DistributionButton.Margin = New System.Windows.Forms.Padding(2)
            Me.DistributionButton.Name = "DistributionButton"
            Me.DistributionButton.Size = New System.Drawing.Size(38, 38)
            Me.DistributionButton.TabIndex = 7
            Me.ToolTip1.SetToolTip(Me.DistributionButton, "Distribution")
            Me.DistributionButton.UseVisualStyleBackColor = False
            '
            'BulletinButton
            '
            Me.BulletinButton.BackColor = System.Drawing.SystemColors.Control
            Me.BulletinButton.BackgroundImage = Global.CollaboShare.My.Resources.Resources.Meeting
            Me.BulletinButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
            Me.BulletinButton.Location = New System.Drawing.Point(224, 7)
            Me.BulletinButton.Margin = New System.Windows.Forms.Padding(2)
            Me.BulletinButton.Name = "BulletinButton"
            Me.BulletinButton.Size = New System.Drawing.Size(38, 38)
            Me.BulletinButton.TabIndex = 6
            Me.ToolTip1.SetToolTip(Me.BulletinButton, "Trading && Polls")
            Me.BulletinButton.UseVisualStyleBackColor = False
            '
            'TodoListButton
            '
            Me.TodoListButton.BackColor = System.Drawing.SystemColors.Control
            Me.TodoListButton.BackgroundImage = Global.CollaboShare.My.Resources.Resources.List
            Me.TodoListButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
            Me.TodoListButton.Location = New System.Drawing.Point(181, 7)
            Me.TodoListButton.Margin = New System.Windows.Forms.Padding(2)
            Me.TodoListButton.Name = "TodoListButton"
            Me.TodoListButton.Size = New System.Drawing.Size(38, 38)
            Me.TodoListButton.TabIndex = 5
            Me.ToolTip1.SetToolTip(Me.TodoListButton, "To-do List")
            Me.TodoListButton.UseVisualStyleBackColor = False
            '
            'ChoresButton
            '
            Me.ChoresButton.BackColor = System.Drawing.SystemColors.Control
            Me.ChoresButton.BackgroundImage = Global.CollaboShare.My.Resources.Resources.Chore
            Me.ChoresButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
            Me.ChoresButton.Location = New System.Drawing.Point(95, 7)
            Me.ChoresButton.Margin = New System.Windows.Forms.Padding(2)
            Me.ChoresButton.Name = "ChoresButton"
            Me.ChoresButton.Size = New System.Drawing.Size(38, 38)
            Me.ChoresButton.TabIndex = 4
            Me.ToolTip1.SetToolTip(Me.ChoresButton, "Chores")
            Me.ChoresButton.UseVisualStyleBackColor = False
            '
            'HouseholdButton
            '
            Me.HouseholdButton.BackColor = System.Drawing.SystemColors.Control
            Me.HouseholdButton.BackgroundImage = Global.CollaboShare.My.Resources.Resources.Home
            Me.HouseholdButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
            Me.HouseholdButton.Location = New System.Drawing.Point(9, 7)
            Me.HouseholdButton.Margin = New System.Windows.Forms.Padding(2)
            Me.HouseholdButton.Name = "HouseholdButton"
            Me.HouseholdButton.Size = New System.Drawing.Size(38, 38)
            Me.HouseholdButton.TabIndex = 2
            Me.HouseholdButton.UseVisualStyleBackColor = False
            '
            'ProfileButton
            '
            Me.ProfileButton.BackColor = System.Drawing.SystemColors.Control
            Me.ProfileButton.BackgroundImage = Global.CollaboShare.My.Resources.Resources.User
            Me.ProfileButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
            Me.ProfileButton.Location = New System.Drawing.Point(52, 7)
            Me.ProfileButton.Margin = New System.Windows.Forms.Padding(2)
            Me.ProfileButton.Name = "ProfileButton"
            Me.ProfileButton.Size = New System.Drawing.Size(38, 38)
            Me.ProfileButton.TabIndex = 1
            Me.ToolTip1.SetToolTip(Me.ProfileButton, "My Profile")
            Me.ProfileButton.UseVisualStyleBackColor = False
            '
            'ViewPanel
            '
            Me.ViewPanel.Dock = System.Windows.Forms.DockStyle.Fill
            Me.ViewPanel.Location = New System.Drawing.Point(0, 0)
            Me.ViewPanel.Name = "ViewPanel"
            Me.ViewPanel.Size = New System.Drawing.Size(267, 416)
            Me.ViewPanel.TabIndex = 2
            '
            'PhoneForm
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(267, 468)
            Me.Controls.Add(Me.ViewPanel)
            Me.Controls.Add(Me.NavPanel)
            Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
            Me.Margin = New System.Windows.Forms.Padding(2)
            Me.MaximizeBox = False
            Me.Name = "PhoneForm"
            Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
            Me.Text = "PhoneForm"
            Me.NavPanel.ResumeLayout(False)
            Me.ResumeLayout(False)

        End Sub

        Friend WithEvents NavPanel As Panel
        Friend WithEvents JoinHouseholdView1 As JoinHouseholdView
        Friend WithEvents BulletinButton As Button
        Friend WithEvents TodoListButton As Button
        Friend WithEvents ChoresButton As Button
        Friend WithEvents HouseholdButton As Button
        Friend WithEvents ProfileButton As Button
        Friend WithEvents ViewPanel As Panel
        Friend WithEvents DistributionButton As Button
        Friend WithEvents ToolTip1 As ToolTip
    End Class
End Namespace