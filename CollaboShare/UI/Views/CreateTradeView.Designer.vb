Namespace UI.Views
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial Class CreateTradeView
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
            Me.TasksCheckedListBox = New System.Windows.Forms.CheckedListBox()
            Me.CancelButton = New System.Windows.Forms.Button()
            Me.SubmitButton = New System.Windows.Forms.Button()
            Me.Panel1.SuspendLayout()
            Me.SuspendLayout()
            '
            'Panel1
            '
            Me.Panel1.BackColor = System.Drawing.SystemColors.ControlDark
            Me.Panel1.Controls.Add(Me.Label1)
            Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
            Me.Panel1.Location = New System.Drawing.Point(0, 0)
            Me.Panel1.Name = "Panel1"
            Me.Panel1.Size = New System.Drawing.Size(267, 40)
            Me.Panel1.TabIndex = 16
            '
            'Label1
            '
            Me.Label1.AutoSize = True
            Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label1.Location = New System.Drawing.Point(3, 7)
            Me.Label1.Name = "Label1"
            Me.Label1.Size = New System.Drawing.Size(171, 24)
            Me.Label1.TabIndex = 1
            Me.Label1.Text = "Create trade offer"
            '
            'TasksCheckedListBox
            '
            Me.TasksCheckedListBox.FormattingEnabled = True
            Me.TasksCheckedListBox.Location = New System.Drawing.Point(6, 44)
            Me.TasksCheckedListBox.Name = "TasksCheckedListBox"
            Me.TasksCheckedListBox.Size = New System.Drawing.Size(258, 244)
            Me.TasksCheckedListBox.TabIndex = 17
            '
            'CancelButton
            '
            Me.CancelButton.Location = New System.Drawing.Point(14, 377)
            Me.CancelButton.Name = "CancelButton"
            Me.CancelButton.Size = New System.Drawing.Size(75, 23)
            Me.CancelButton.TabIndex = 18
            Me.CancelButton.Text = "Cancel"
            Me.CancelButton.UseVisualStyleBackColor = True
            '
            'SubmitButton
            '
            Me.SubmitButton.Location = New System.Drawing.Point(179, 377)
            Me.SubmitButton.Name = "SubmitButton"
            Me.SubmitButton.Size = New System.Drawing.Size(75, 23)
            Me.SubmitButton.TabIndex = 19
            Me.SubmitButton.Text = "Submit"
            Me.SubmitButton.UseVisualStyleBackColor = True
            '
            'CreateTradeView
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.Controls.Add(Me.SubmitButton)
            Me.Controls.Add(Me.CancelButton)
            Me.Controls.Add(Me.TasksCheckedListBox)
            Me.Controls.Add(Me.Panel1)
            Me.Name = "CreateTradeView"
            Me.Size = New System.Drawing.Size(267, 416)
            Me.Panel1.ResumeLayout(False)
            Me.Panel1.PerformLayout()
            Me.ResumeLayout(False)

        End Sub

        Friend WithEvents Panel1 As Panel
        Friend WithEvents Label1 As Label
        Friend WithEvents TasksCheckedListBox As CheckedListBox
        Friend WithEvents CancelButton As Button
        Friend WithEvents SubmitButton As Button
    End Class
End NameSpace