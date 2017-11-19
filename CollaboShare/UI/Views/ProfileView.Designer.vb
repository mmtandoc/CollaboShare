Namespace UI.Views
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
    Partial Class ProfileView
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
            Me.Label6 = New System.Windows.Forms.Label()
            Me.BackButton = New System.Windows.Forms.Button()
            Me.EditButton = New System.Windows.Forms.Button()
            Me.FlowLayoutPanel1 = New System.Windows.Forms.FlowLayoutPanel()
            Me.Label5 = New System.Windows.Forms.Label()
            Me.NameLabel = New System.Windows.Forms.Label()
            Me.Label4 = New System.Windows.Forms.Label()
            Me.PhoneNumberLabel = New System.Windows.Forms.Label()
            Me.Label3 = New System.Windows.Forms.Label()
            Me.EmailAddressLabel = New System.Windows.Forms.Label()
            Me.PhotoPictureBox = New System.Windows.Forms.PictureBox()
            Me.ToDoListButton = New System.Windows.Forms.Button()
            Me.ChorePreferencesButton = New System.Windows.Forms.Button()
            Me.Panel1.SuspendLayout()
            Me.FlowLayoutPanel1.SuspendLayout()
            CType(Me.PhotoPictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
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
            Me.Panel1.TabIndex = 15
            '
            'Label6
            '
            Me.Label6.AutoSize = True
            Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label6.Location = New System.Drawing.Point(3, 7)
            Me.Label6.Name = "Label6"
            Me.Label6.Size = New System.Drawing.Size(121, 24)
            Me.Label6.TabIndex = 1
            Me.Label6.Text = "View Profile"
            '
            'BackButton
            '
            Me.BackButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.BackButton.Location = New System.Drawing.Point(10, 379)
            Me.BackButton.Name = "BackButton"
            Me.BackButton.Size = New System.Drawing.Size(75, 27)
            Me.BackButton.TabIndex = 18
            Me.BackButton.Text = "Back"
            Me.BackButton.UseVisualStyleBackColor = True
            '
            'EditButton
            '
            Me.EditButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.EditButton.Location = New System.Drawing.Point(180, 379)
            Me.EditButton.Name = "EditButton"
            Me.EditButton.Size = New System.Drawing.Size(75, 27)
            Me.EditButton.TabIndex = 17
            Me.EditButton.Text = "Edit"
            Me.EditButton.UseVisualStyleBackColor = True
            '
            'FlowLayoutPanel1
            '
            Me.FlowLayoutPanel1.Controls.Add(Me.Label5)
            Me.FlowLayoutPanel1.Controls.Add(Me.NameLabel)
            Me.FlowLayoutPanel1.Controls.Add(Me.Label4)
            Me.FlowLayoutPanel1.Controls.Add(Me.PhoneNumberLabel)
            Me.FlowLayoutPanel1.Controls.Add(Me.Label3)
            Me.FlowLayoutPanel1.Controls.Add(Me.EmailAddressLabel)
            Me.FlowLayoutPanel1.Controls.Add(Me.PhotoPictureBox)
            Me.FlowLayoutPanel1.Controls.Add(Me.ToDoListButton)
            Me.FlowLayoutPanel1.Controls.Add(Me.ChorePreferencesButton)
            Me.FlowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown
            Me.FlowLayoutPanel1.Location = New System.Drawing.Point(1, 44)
            Me.FlowLayoutPanel1.Name = "FlowLayoutPanel1"
            Me.FlowLayoutPanel1.Padding = New System.Windows.Forms.Padding(5, 0, 5, 0)
            Me.FlowLayoutPanel1.Size = New System.Drawing.Size(264, 328)
            Me.FlowLayoutPanel1.TabIndex = 19
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
            Me.NameLabel.Text = "Name"
            Me.NameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            '
            'Label4
            '
            Me.Label4.AutoSize = True
            Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label4.Location = New System.Drawing.Point(8, 42)
            Me.Label4.Name = "Label4"
            Me.Label4.Size = New System.Drawing.Size(92, 15)
            Me.Label4.TabIndex = 9
            Me.Label4.Text = "Phone number:"
            '
            'PhoneNumberLabel
            '
            Me.PhoneNumberLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.PhoneNumberLabel.Location = New System.Drawing.Point(8, 57)
            Me.PhoneNumberLabel.Name = "PhoneNumberLabel"
            Me.PhoneNumberLabel.Size = New System.Drawing.Size(231, 27)
            Me.PhoneNumberLabel.TabIndex = 5
            Me.PhoneNumberLabel.Text = "PhoneNumber"
            Me.PhoneNumberLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            '
            'Label3
            '
            Me.Label3.AutoSize = True
            Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label3.Location = New System.Drawing.Point(8, 84)
            Me.Label3.Name = "Label3"
            Me.Label3.Size = New System.Drawing.Size(89, 15)
            Me.Label3.TabIndex = 8
            Me.Label3.Text = "Email address:"
            '
            'EmailAddressLabel
            '
            Me.EmailAddressLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.EmailAddressLabel.Location = New System.Drawing.Point(8, 99)
            Me.EmailAddressLabel.Name = "EmailAddressLabel"
            Me.EmailAddressLabel.Size = New System.Drawing.Size(231, 27)
            Me.EmailAddressLabel.TabIndex = 4
            Me.EmailAddressLabel.Text = "EmailAddress"
            Me.EmailAddressLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            '
            'PhotoPictureBox
            '
            Me.PhotoPictureBox.Location = New System.Drawing.Point(8, 129)
            Me.PhotoPictureBox.Name = "PhotoPictureBox"
            Me.PhotoPictureBox.Size = New System.Drawing.Size(100, 127)
            Me.PhotoPictureBox.TabIndex = 11
            Me.PhotoPictureBox.TabStop = False
            '
            'ToDoListButton
            '
            Me.ToDoListButton.Location = New System.Drawing.Point(8, 262)
            Me.ToDoListButton.Name = "ToDoListButton"
            Me.ToDoListButton.Size = New System.Drawing.Size(100, 23)
            Me.ToDoListButton.TabIndex = 12
            Me.ToDoListButton.Text = "See To-Do List"
            Me.ToDoListButton.UseVisualStyleBackColor = True
            '
            'ChorePreferencesButton
            '
            Me.ChorePreferencesButton.Location = New System.Drawing.Point(8, 291)
            Me.ChorePreferencesButton.Name = "ChorePreferencesButton"
            Me.ChorePreferencesButton.Size = New System.Drawing.Size(149, 21)
            Me.ChorePreferencesButton.TabIndex = 13
            Me.ChorePreferencesButton.Text = "Set Chore Preferences"
            Me.ChorePreferencesButton.UseVisualStyleBackColor = True
            '
            'ProfileView
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.Controls.Add(Me.FlowLayoutPanel1)
            Me.Controls.Add(Me.Panel1)
            Me.Controls.Add(Me.BackButton)
            Me.Controls.Add(Me.EditButton)
            Me.Margin = New System.Windows.Forms.Padding(2)
            Me.Name = "ProfileView"
            Me.Size = New System.Drawing.Size(267, 416)
            Me.Panel1.ResumeLayout(False)
            Me.Panel1.PerformLayout()
            Me.FlowLayoutPanel1.ResumeLayout(False)
            Me.FlowLayoutPanel1.PerformLayout()
            CType(Me.PhotoPictureBox, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)

        End Sub

        Friend WithEvents Panel1 As Panel
        Friend WithEvents Label6 As Label
        Friend WithEvents BackButton As Button
        Friend WithEvents EditButton As Button
        Friend WithEvents FlowLayoutPanel1 As FlowLayoutPanel
        Friend WithEvents Label5 As Label
        Friend WithEvents NameLabel As Label
        Friend WithEvents Label4 As Label
        Friend WithEvents PhoneNumberLabel As Label
        Friend WithEvents Label3 As Label
        Friend WithEvents EmailAddressLabel As Label
        Friend WithEvents PhotoPictureBox As PictureBox
        Friend WithEvents ToDoListButton As Button
        Friend WithEvents ChorePreferencesButton As Button
    End Class
End NameSpace