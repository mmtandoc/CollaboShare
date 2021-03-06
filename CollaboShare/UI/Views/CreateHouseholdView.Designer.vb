﻿Namespace UI.Views
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial Class CreateHouseholdView
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
            Me.FlowLayoutPanel1 = New System.Windows.Forms.FlowLayoutPanel()
            Me.Label5 = New System.Windows.Forms.Label()
            Me.NameTextBox = New System.Windows.Forms.TextBox()
            Me.Label2 = New System.Windows.Forms.Label()
            Me.AddressTextBox = New System.Windows.Forms.TextBox()
            Me.CancelButton = New System.Windows.Forms.Button()
            Me.ConfirmButton = New System.Windows.Forms.Button()
            Me.Panel1.SuspendLayout()
            Me.FlowLayoutPanel1.SuspendLayout()
            Me.SuspendLayout()
            '
            'Panel1
            '
            Me.Panel1.BackColor = System.Drawing.SystemColors.ControlDark
            Me.Panel1.Controls.Add(Me.Label1)
            Me.Panel1.Location = New System.Drawing.Point(3, 3)
            Me.Panel1.Name = "Panel1"
            Me.Panel1.Size = New System.Drawing.Size(261, 40)
            Me.Panel1.TabIndex = 3
            '
            'Label1
            '
            Me.Label1.AutoSize = True
            Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label1.Location = New System.Drawing.Point(3, 7)
            Me.Label1.Name = "Label1"
            Me.Label1.Size = New System.Drawing.Size(205, 24)
            Me.Label1.TabIndex = 1
            Me.Label1.Text = "Enter household info"
            '
            'FlowLayoutPanel1
            '
            Me.FlowLayoutPanel1.Controls.Add(Me.Panel1)
            Me.FlowLayoutPanel1.Controls.Add(Me.Label5)
            Me.FlowLayoutPanel1.Controls.Add(Me.NameTextBox)
            Me.FlowLayoutPanel1.Controls.Add(Me.Label2)
            Me.FlowLayoutPanel1.Controls.Add(Me.AddressTextBox)
            Me.FlowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top
            Me.FlowLayoutPanel1.Location = New System.Drawing.Point(0, 0)
            Me.FlowLayoutPanel1.Name = "FlowLayoutPanel1"
            Me.FlowLayoutPanel1.Size = New System.Drawing.Size(267, 357)
            Me.FlowLayoutPanel1.TabIndex = 7
            '
            'Label5
            '
            Me.Label5.AutoSize = True
            Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label5.Location = New System.Drawing.Point(3, 46)
            Me.Label5.Name = "Label5"
            Me.Label5.Size = New System.Drawing.Size(134, 20)
            Me.Label5.TabIndex = 1
            Me.Label5.Text = "Household name:"
            '
            'NameTextBox
            '
            Me.NameTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.NameTextBox.Location = New System.Drawing.Point(3, 69)
            Me.NameTextBox.Name = "NameTextBox"
            Me.NameTextBox.Size = New System.Drawing.Size(251, 26)
            Me.NameTextBox.TabIndex = 0
            '
            'Label2
            '
            Me.Label2.AutoSize = True
            Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label2.Location = New System.Drawing.Point(3, 98)
            Me.Label2.Name = "Label2"
            Me.Label2.Size = New System.Drawing.Size(72, 20)
            Me.Label2.TabIndex = 5
            Me.Label2.Text = "Address:"
            '
            'AddressTextBox
            '
            Me.AddressTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.AddressTextBox.Location = New System.Drawing.Point(3, 121)
            Me.AddressTextBox.Name = "AddressTextBox"
            Me.AddressTextBox.Size = New System.Drawing.Size(251, 26)
            Me.AddressTextBox.TabIndex = 4
            '
            'CancelButton
            '
            Me.CancelButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.CancelButton.Location = New System.Drawing.Point(10, 373)
            Me.CancelButton.Name = "CancelButton"
            Me.CancelButton.Size = New System.Drawing.Size(75, 27)
            Me.CancelButton.TabIndex = 9
            Me.CancelButton.Text = "Cancel"
            Me.CancelButton.UseVisualStyleBackColor = True
            '
            'ConfirmButton
            '
            Me.ConfirmButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.ConfirmButton.Location = New System.Drawing.Point(179, 373)
            Me.ConfirmButton.Name = "ConfirmButton"
            Me.ConfirmButton.Size = New System.Drawing.Size(75, 27)
            Me.ConfirmButton.TabIndex = 8
            Me.ConfirmButton.Text = "Confirm"
            Me.ConfirmButton.UseVisualStyleBackColor = True
            '
            'CreateHouseholdView
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.Controls.Add(Me.FlowLayoutPanel1)
            Me.Controls.Add(Me.CancelButton)
            Me.Controls.Add(Me.ConfirmButton)
            Me.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
            Me.Name = "CreateHouseholdView"
            Me.Size = New System.Drawing.Size(267, 416)
            Me.Panel1.ResumeLayout(False)
            Me.Panel1.PerformLayout()
            Me.FlowLayoutPanel1.ResumeLayout(False)
            Me.FlowLayoutPanel1.PerformLayout()
            Me.ResumeLayout(False)

        End Sub

        Friend WithEvents Panel1 As Panel
        Friend WithEvents Label1 As Label
        Friend WithEvents FlowLayoutPanel1 As FlowLayoutPanel
        Friend WithEvents Label5 As Label
        Friend WithEvents NameTextBox As TextBox
        Friend WithEvents Label2 As Label
        Friend WithEvents AddressTextBox As TextBox
        Friend WithEvents CancelButton As Button
        Friend WithEvents ConfirmButton As Button
    End Class
End NameSpace