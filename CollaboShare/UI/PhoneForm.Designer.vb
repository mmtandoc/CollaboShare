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
        Me.NavPanel = New System.Windows.Forms.Panel()
        Me.BulletinButton = New System.Windows.Forms.Button()
        Me.TodoListButton = New System.Windows.Forms.Button()
        Me.ChoresButton = New System.Windows.Forms.Button()
        Me.HouseholdButton = New System.Windows.Forms.Button()
        Me.ProfileButton = New System.Windows.Forms.Button()
        Me.ViewPanel = New System.Windows.Forms.Panel()
        Me.NavPanel.SuspendLayout()
        Me.SuspendLayout()
        '
        'NavPanel
        '
        Me.NavPanel.Controls.Add(Me.BulletinButton)
        Me.NavPanel.Controls.Add(Me.TodoListButton)
        Me.NavPanel.Controls.Add(Me.ChoresButton)
        Me.NavPanel.Controls.Add(Me.HouseholdButton)
        Me.NavPanel.Controls.Add(Me.ProfileButton)
        Me.NavPanel.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.NavPanel.Location = New System.Drawing.Point(0, 421)
        Me.NavPanel.Name = "NavPanel"
        Me.NavPanel.Size = New System.Drawing.Size(284, 53)
        Me.NavPanel.TabIndex = 1
        '
        'BulletinButton
        '
        Me.BulletinButton.BackgroundImage = Global.CollaboShare_Prototype_1.My.Resources.Resources.Meeting
        Me.BulletinButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.BulletinButton.Location = New System.Drawing.Point(231, 2)
        Me.BulletinButton.Margin = New System.Windows.Forms.Padding(2)
        Me.BulletinButton.Name = "BulletinButton"
        Me.BulletinButton.Size = New System.Drawing.Size(47, 47)
        Me.BulletinButton.TabIndex = 6
        Me.BulletinButton.UseVisualStyleBackColor = True
        '
        'TodoListButton
        '
        Me.TodoListButton.BackgroundImage = Global.CollaboShare_Prototype_1.My.Resources.Resources.List
        Me.TodoListButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.TodoListButton.Location = New System.Drawing.Point(175, 2)
        Me.TodoListButton.Margin = New System.Windows.Forms.Padding(2)
        Me.TodoListButton.Name = "TodoListButton"
        Me.TodoListButton.Size = New System.Drawing.Size(47, 47)
        Me.TodoListButton.TabIndex = 5
        Me.TodoListButton.UseVisualStyleBackColor = True
        '
        'ChoresButton
        '
        Me.ChoresButton.BackgroundImage = Global.CollaboShare_Prototype_1.My.Resources.Resources.Chore
        Me.ChoresButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.ChoresButton.Location = New System.Drawing.Point(119, 2)
        Me.ChoresButton.Margin = New System.Windows.Forms.Padding(2)
        Me.ChoresButton.Name = "ChoresButton"
        Me.ChoresButton.Size = New System.Drawing.Size(47, 47)
        Me.ChoresButton.TabIndex = 4
        Me.ChoresButton.UseVisualStyleBackColor = True
        '
        'HouseholdButton
        '
        Me.HouseholdButton.BackgroundImage = Global.CollaboShare_Prototype_1.My.Resources.Resources.Home
        Me.HouseholdButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.HouseholdButton.Location = New System.Drawing.Point(7, 2)
        Me.HouseholdButton.Margin = New System.Windows.Forms.Padding(2)
        Me.HouseholdButton.Name = "HouseholdButton"
        Me.HouseholdButton.Size = New System.Drawing.Size(47, 47)
        Me.HouseholdButton.TabIndex = 2
        Me.HouseholdButton.UseVisualStyleBackColor = True
        '
        'ProfileButton
        '
        Me.ProfileButton.BackgroundImage = Global.CollaboShare_Prototype_1.My.Resources.Resources.User
        Me.ProfileButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.ProfileButton.Location = New System.Drawing.Point(63, 2)
        Me.ProfileButton.Margin = New System.Windows.Forms.Padding(2)
        Me.ProfileButton.Name = "ProfileButton"
        Me.ProfileButton.Size = New System.Drawing.Size(47, 47)
        Me.ProfileButton.TabIndex = 1
        Me.ProfileButton.UseVisualStyleBackColor = True
        '
        'ViewPanel
        '
        Me.ViewPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ViewPanel.Location = New System.Drawing.Point(0, 0)
        Me.ViewPanel.Name = "ViewPanel"
        Me.ViewPanel.Size = New System.Drawing.Size(284, 421)
        Me.ViewPanel.TabIndex = 2
        '
        'PhoneForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 474)
        Me.Controls.Add(Me.ViewPanel)
        Me.Controls.Add(Me.NavPanel)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "PhoneForm"
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
End Class
