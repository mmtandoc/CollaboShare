Imports CollaboShare.UI.Controls

Namespace UI.Views
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
    Partial Class CreateChoreView
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
        Me.NameTextBox = New System.Windows.Forms.TextBox()
        Me.FlowLayoutPanel1 = New System.Windows.Forms.FlowLayoutPanel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.DescriptionTextBox = New System.Windows.Forms.TextBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.DurationNumericUpDown = New System.Windows.Forms.NumericUpDown()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.PeopleRequiredNumericUpDown = New System.Windows.Forms.NumericUpDown()
        Me.RecurrenceControl1 = New CollaboShare.UI.Controls.RecurrenceControl()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.CancelButton = New System.Windows.Forms.Button()
        Me.ConfirmButton = New System.Windows.Forms.Button()
        Me.FlowLayoutPanel1.SuspendLayout
        Me.Panel2.SuspendLayout
        CType(Me.DurationNumericUpDown,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.PeopleRequiredNumericUpDown,System.ComponentModel.ISupportInitialize).BeginInit
        Me.Panel1.SuspendLayout
        Me.SuspendLayout
        '
        'NameTextBox
        '
        Me.NameTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.NameTextBox.Location = New System.Drawing.Point(8, 19)
        Me.NameTextBox.Name = "NameTextBox"
        Me.NameTextBox.Size = New System.Drawing.Size(244, 22)
        Me.NameTextBox.TabIndex = 14
        '
        'FlowLayoutPanel1
        '
        Me.FlowLayoutPanel1.Controls.Add(Me.Label2)
        Me.FlowLayoutPanel1.Controls.Add(Me.NameTextBox)
        Me.FlowLayoutPanel1.Controls.Add(Me.Label5)
        Me.FlowLayoutPanel1.Controls.Add(Me.DescriptionTextBox)
        Me.FlowLayoutPanel1.Controls.Add(Me.Panel2)
        Me.FlowLayoutPanel1.Controls.Add(Me.RecurrenceControl1)
        Me.FlowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown
        Me.FlowLayoutPanel1.Location = New System.Drawing.Point(0, 41)
        Me.FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        Me.FlowLayoutPanel1.Padding = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.FlowLayoutPanel1.Size = New System.Drawing.Size(267, 328)
        Me.FlowLayoutPanel1.TabIndex = 12
        '
        'Label2
        '
        Me.Label2.AutoSize = true
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.Label2.Location = New System.Drawing.Point(8, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(84, 16)
        Me.Label2.TabIndex = 15
        Me.Label2.Text = "Chore name:"
        '
        'Label5
        '
        Me.Label5.AutoSize = true
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.Label5.Location = New System.Drawing.Point(8, 44)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(138, 16)
        Me.Label5.TabIndex = 13
        Me.Label5.Text = "Description (optional):"
        '
        'DescriptionTextBox
        '
        Me.DescriptionTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.DescriptionTextBox.Location = New System.Drawing.Point(8, 63)
        Me.DescriptionTextBox.Name = "DescriptionTextBox"
        Me.DescriptionTextBox.Size = New System.Drawing.Size(244, 22)
        Me.DescriptionTextBox.TabIndex = 12
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.DurationNumericUpDown)
        Me.Panel2.Controls.Add(Me.Label4)
        Me.Panel2.Controls.Add(Me.Label3)
        Me.Panel2.Controls.Add(Me.PeopleRequiredNumericUpDown)
        Me.Panel2.Location = New System.Drawing.Point(8, 91)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(251, 49)
        Me.Panel2.TabIndex = 18
        '
        'DurationNumericUpDown
        '
        Me.DurationNumericUpDown.Location = New System.Drawing.Point(127, 4)
        Me.DurationNumericUpDown.Minimum = New Decimal(New Integer() {10, 0, 0, 0})
        Me.DurationNumericUpDown.Name = "DurationNumericUpDown"
        Me.DurationNumericUpDown.Size = New System.Drawing.Size(65, 20)
        Me.DurationNumericUpDown.TabIndex = 18
        Me.DurationNumericUpDown.Value = New Decimal(New Integer() {10, 0, 0, 0})
        '
        'Label4
        '
        Me.Label4.AutoSize = true
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.Label4.Location = New System.Drawing.Point(3, 27)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(108, 16)
        Me.Label4.TabIndex = 17
        Me.Label4.Text = "People required:"
        '
        'Label3
        '
        Me.Label3.AutoSize = true
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.Label3.Location = New System.Drawing.Point(3, 5)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(118, 16)
        Me.Label3.TabIndex = 16
        Me.Label3.Text = "Duration (minutes):"
        '
        'PeopleRequiredNumericUpDown
        '
        Me.PeopleRequiredNumericUpDown.Location = New System.Drawing.Point(127, 27)
        Me.PeopleRequiredNumericUpDown.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.PeopleRequiredNumericUpDown.Name = "PeopleRequiredNumericUpDown"
        Me.PeopleRequiredNumericUpDown.Size = New System.Drawing.Size(44, 20)
        Me.PeopleRequiredNumericUpDown.TabIndex = 0
        Me.PeopleRequiredNumericUpDown.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'RecurrenceControl1
        '
        Me.RecurrenceControl1.Location = New System.Drawing.Point(8, 146)
        Me.RecurrenceControl1.Name = "RecurrenceControl1"
        Me.RecurrenceControl1.Size = New System.Drawing.Size(251, 177)
        Me.RecurrenceControl1.TabIndex = 16
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.ControlDark
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(267, 40)
        Me.Panel1.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.AutoSize = true
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.Label1.Location = New System.Drawing.Point(3, 7)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(176, 24)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Create new chore"
        '
        'CancelButton
        '
        Me.CancelButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.CancelButton.Location = New System.Drawing.Point(10, 380)
        Me.CancelButton.Name = "CancelButton"
        Me.CancelButton.Size = New System.Drawing.Size(75, 27)
        Me.CancelButton.TabIndex = 14
        Me.CancelButton.Text = "Cancel"
        Me.CancelButton.UseVisualStyleBackColor = true
        '
        'ConfirmButton
        '
        Me.ConfirmButton.Enabled = false
        Me.ConfirmButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.ConfirmButton.Location = New System.Drawing.Point(179, 380)
        Me.ConfirmButton.Name = "ConfirmButton"
        Me.ConfirmButton.Size = New System.Drawing.Size(75, 27)
        Me.ConfirmButton.TabIndex = 13
        Me.ConfirmButton.Text = "Confirm"
        Me.ConfirmButton.UseVisualStyleBackColor = true
        '
        'CreateChoreView
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.FlowLayoutPanel1)
        Me.Controls.Add(Me.CancelButton)
        Me.Controls.Add(Me.ConfirmButton)
        Me.Name = "CreateChoreView"
        Me.Size = New System.Drawing.Size(267, 416)
        Me.FlowLayoutPanel1.ResumeLayout(false)
        Me.FlowLayoutPanel1.PerformLayout
        Me.Panel2.ResumeLayout(false)
        Me.Panel2.PerformLayout
        CType(Me.DurationNumericUpDown,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.PeopleRequiredNumericUpDown,System.ComponentModel.ISupportInitialize).EndInit
        Me.Panel1.ResumeLayout(false)
        Me.Panel1.PerformLayout
        Me.ResumeLayout(false)

End Sub

        Friend WithEvents NameTextBox As TextBox
        Friend WithEvents FlowLayoutPanel1 As FlowLayoutPanel
        Friend WithEvents Panel1 As Panel
        Friend WithEvents Label1 As Label
        Friend WithEvents Label2 As Label
        Friend WithEvents Label5 As Label
        Friend WithEvents DescriptionTextBox As TextBox
        Friend WithEvents RecurrenceControl1 As RecurrenceControl
        Friend WithEvents CancelButton As Button
        Friend WithEvents ConfirmButton As Button
        Friend WithEvents Panel2 As Panel
        Friend WithEvents Label4 As Label
        Friend WithEvents Label3 As Label
        Friend WithEvents PeopleRequiredNumericUpDown As NumericUpDown
        Friend WithEvents DurationNumericUpDown As NumericUpDown
    End Class
End NameSpace