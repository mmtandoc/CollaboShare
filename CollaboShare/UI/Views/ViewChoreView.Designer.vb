Namespace UI.Views
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
    Partial Class ViewChoreView
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
            Me.Label8 = New System.Windows.Forms.Label()
            Me.FlowLayoutPanel1 = New System.Windows.Forms.FlowLayoutPanel()
            Me.Label6 = New System.Windows.Forms.Label()
            Me.NameLabel = New System.Windows.Forms.Label()
            Me.Label5 = New System.Windows.Forms.Label()
            Me.DueDateLabel = New System.Windows.Forms.Label()
            Me.Label4 = New System.Windows.Forms.Label()
            Me.FrequencyLabel = New System.Windows.Forms.Label()
            Me.Label3 = New System.Windows.Forms.Label()
            Me.PeopleRequiredLabel = New System.Windows.Forms.Label()
            Me.Label2 = New System.Windows.Forms.Label()
            Me.DurationLabel = New System.Windows.Forms.Label()
            Me.Label1 = New System.Windows.Forms.Label()
            Me.DescriptionLabel = New System.Windows.Forms.Label()
            Me.BackButton = New System.Windows.Forms.Button()
            Me.ratingLabel = New System.Windows.Forms.Label()
            Me.rating = New System.Windows.Forms.Label()
            Me.Panel1.SuspendLayout()
            Me.FlowLayoutPanel1.SuspendLayout()
            Me.SuspendLayout()
            '
            'Panel1
            '
            Me.Panel1.BackColor = System.Drawing.SystemColors.ControlDark
            Me.Panel1.Controls.Add(Me.Label8)
            Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
            Me.Panel1.Location = New System.Drawing.Point(0, 0)
            Me.Panel1.Name = "Panel1"
            Me.Panel1.Size = New System.Drawing.Size(267, 40)
            Me.Panel1.TabIndex = 15
            '
            'Label8
            '
            Me.Label8.AutoSize = True
            Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label8.Location = New System.Drawing.Point(3, 7)
            Me.Label8.Name = "Label8"
            Me.Label8.Size = New System.Drawing.Size(116, 24)
            Me.Label8.TabIndex = 1
            Me.Label8.Text = "View chore"
            '
            'FlowLayoutPanel1
            '
            Me.FlowLayoutPanel1.Controls.Add(Me.Label6)
            Me.FlowLayoutPanel1.Controls.Add(Me.NameLabel)
            Me.FlowLayoutPanel1.Controls.Add(Me.Label5)
            Me.FlowLayoutPanel1.Controls.Add(Me.DueDateLabel)
            Me.FlowLayoutPanel1.Controls.Add(Me.Label4)
            Me.FlowLayoutPanel1.Controls.Add(Me.FrequencyLabel)
            Me.FlowLayoutPanel1.Controls.Add(Me.Label3)
            Me.FlowLayoutPanel1.Controls.Add(Me.PeopleRequiredLabel)
            Me.FlowLayoutPanel1.Controls.Add(Me.Label2)
            Me.FlowLayoutPanel1.Controls.Add(Me.DurationLabel)
            Me.FlowLayoutPanel1.Controls.Add(Me.ratingLabel)
            Me.FlowLayoutPanel1.Controls.Add(Me.rating)
            Me.FlowLayoutPanel1.Controls.Add(Me.Label1)
            Me.FlowLayoutPanel1.Controls.Add(Me.DescriptionLabel)
            Me.FlowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown
            Me.FlowLayoutPanel1.Location = New System.Drawing.Point(0, 46)
            Me.FlowLayoutPanel1.Name = "FlowLayoutPanel1"
            Me.FlowLayoutPanel1.Padding = New System.Windows.Forms.Padding(5, 0, 5, 0)
            Me.FlowLayoutPanel1.Size = New System.Drawing.Size(264, 328)
            Me.FlowLayoutPanel1.TabIndex = 16
            '
            'Label6
            '
            Me.Label6.AutoSize = True
            Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label6.Location = New System.Drawing.Point(8, 0)
            Me.Label6.Name = "Label6"
            Me.Label6.Size = New System.Drawing.Size(43, 15)
            Me.Label6.TabIndex = 12
            Me.Label6.Text = "Chore:"
            '
            'NameLabel
            '
            Me.NameLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.NameLabel.Location = New System.Drawing.Point(8, 15)
            Me.NameLabel.Name = "NameLabel"
            Me.NameLabel.Size = New System.Drawing.Size(231, 27)
            Me.NameLabel.TabIndex = 11
            Me.NameLabel.Text = "ChoreName"
            Me.NameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            '
            'Label5
            '
            Me.Label5.AutoSize = True
            Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label5.Location = New System.Drawing.Point(8, 42)
            Me.Label5.Name = "Label5"
            Me.Label5.Size = New System.Drawing.Size(60, 15)
            Me.Label5.TabIndex = 10
            Me.Label5.Text = "Due date:"
            '
            'DueDateLabel
            '
            Me.DueDateLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.DueDateLabel.Location = New System.Drawing.Point(8, 57)
            Me.DueDateLabel.Name = "DueDateLabel"
            Me.DueDateLabel.Size = New System.Drawing.Size(231, 27)
            Me.DueDateLabel.TabIndex = 2
            Me.DueDateLabel.Text = "DueDate"
            Me.DueDateLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            '
            'Label4
            '
            Me.Label4.AutoSize = True
            Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label4.Location = New System.Drawing.Point(8, 84)
            Me.Label4.Name = "Label4"
            Me.Label4.Size = New System.Drawing.Size(67, 15)
            Me.Label4.TabIndex = 9
            Me.Label4.Text = "Frequency:"
            '
            'FrequencyLabel
            '
            Me.FrequencyLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.FrequencyLabel.Location = New System.Drawing.Point(8, 99)
            Me.FrequencyLabel.Name = "FrequencyLabel"
            Me.FrequencyLabel.Size = New System.Drawing.Size(231, 27)
            Me.FrequencyLabel.TabIndex = 5
            Me.FrequencyLabel.Text = "Frequency"
            Me.FrequencyLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            '
            'Label3
            '
            Me.Label3.AutoSize = True
            Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label3.Location = New System.Drawing.Point(8, 126)
            Me.Label3.Name = "Label3"
            Me.Label3.Size = New System.Drawing.Size(98, 15)
            Me.Label3.TabIndex = 8
            Me.Label3.Text = "People required:"
            '
            'PeopleRequiredLabel
            '
            Me.PeopleRequiredLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.PeopleRequiredLabel.Location = New System.Drawing.Point(8, 141)
            Me.PeopleRequiredLabel.Name = "PeopleRequiredLabel"
            Me.PeopleRequiredLabel.Size = New System.Drawing.Size(231, 27)
            Me.PeopleRequiredLabel.TabIndex = 4
            Me.PeopleRequiredLabel.Text = "PeopleRequired"
            Me.PeopleRequiredLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            '
            'Label2
            '
            Me.Label2.AutoSize = True
            Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label2.Location = New System.Drawing.Point(8, 168)
            Me.Label2.Name = "Label2"
            Me.Label2.Size = New System.Drawing.Size(57, 15)
            Me.Label2.TabIndex = 7
            Me.Label2.Text = "Duration:"
            '
            'DurationLabel
            '
            Me.DurationLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.DurationLabel.Location = New System.Drawing.Point(8, 183)
            Me.DurationLabel.Name = "DurationLabel"
            Me.DurationLabel.Size = New System.Drawing.Size(231, 27)
            Me.DurationLabel.TabIndex = 3
            Me.DurationLabel.Text = "Duration"
            Me.DurationLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            '
            'Label1
            '
            Me.Label1.AutoSize = True
            Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label1.Location = New System.Drawing.Point(8, 236)
            Me.Label1.Margin = New System.Windows.Forms.Padding(3, 0, 3, 3)
            Me.Label1.Name = "Label1"
            Me.Label1.Size = New System.Drawing.Size(72, 15)
            Me.Label1.TabIndex = 6
            Me.Label1.Text = "Description:"
            '
            'DescriptionLabel
            '
            Me.DescriptionLabel.BackColor = System.Drawing.SystemColors.HighlightText
            Me.DescriptionLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.DescriptionLabel.Location = New System.Drawing.Point(8, 254)
            Me.DescriptionLabel.Name = "DescriptionLabel"
            Me.DescriptionLabel.Size = New System.Drawing.Size(218, 69)
            Me.DescriptionLabel.TabIndex = 1
            Me.DescriptionLabel.Text = "Description"
            '
            'BackButton
            '
            Me.BackButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.BackButton.Location = New System.Drawing.Point(10, 380)
            Me.BackButton.Name = "BackButton"
            Me.BackButton.Size = New System.Drawing.Size(75, 27)
            Me.BackButton.TabIndex = 18
            Me.BackButton.Text = "Back"
            Me.BackButton.UseVisualStyleBackColor = True
            '
            'ratingLabel
            '
            Me.ratingLabel.AutoSize = True
            Me.ratingLabel.Location = New System.Drawing.Point(8, 210)
            Me.ratingLabel.Name = "ratingLabel"
            Me.ratingLabel.Size = New System.Drawing.Size(41, 13)
            Me.ratingLabel.TabIndex = 13
            Me.ratingLabel.Text = "Rating:"
            '
            'rating
            '
            Me.rating.AutoSize = True
            Me.rating.Location = New System.Drawing.Point(8, 223)
            Me.rating.Name = "rating"
            Me.rating.Size = New System.Drawing.Size(13, 13)
            Me.rating.TabIndex = 14
            Me.rating.Text = "0"
            '
            'ViewChoreView
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.Controls.Add(Me.Panel1)
            Me.Controls.Add(Me.FlowLayoutPanel1)
            Me.Controls.Add(Me.BackButton)
            Me.Name = "ViewChoreView"
            Me.Size = New System.Drawing.Size(267, 416)
            Me.Panel1.ResumeLayout(False)
            Me.Panel1.PerformLayout()
            Me.FlowLayoutPanel1.ResumeLayout(False)
            Me.FlowLayoutPanel1.PerformLayout()
            Me.ResumeLayout(False)

        End Sub

        Friend WithEvents Panel1 As Panel
        Friend WithEvents Label8 As Label
        Friend WithEvents FlowLayoutPanel1 As FlowLayoutPanel
        Friend WithEvents DescriptionLabel As Label
        Friend WithEvents BackButton As Button
        Friend WithEvents DueDateLabel As Label
        Friend WithEvents FrequencyLabel As Label
        Friend WithEvents PeopleRequiredLabel As Label
        Friend WithEvents DurationLabel As Label
        Friend WithEvents Label5 As Label
        Friend WithEvents Label4 As Label
        Friend WithEvents Label3 As Label
        Friend WithEvents Label2 As Label
        Friend WithEvents Label1 As Label
        Friend WithEvents Label6 As Label
        Friend WithEvents NameLabel As Label
        Friend WithEvents ratingLabel As Label
        Friend WithEvents rating As Label
    End Class
End Namespace