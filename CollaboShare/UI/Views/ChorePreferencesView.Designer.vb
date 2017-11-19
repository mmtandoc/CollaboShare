Namespace UI.Views
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
    Partial Class ChorePreferencesView
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
            Me.Label1 = New System.Windows.Forms.Label()
            Me.Panel1 = New System.Windows.Forms.Panel()
            Me.ChoreRankListView = New System.Windows.Forms.ListView()
            Me.RankColumnHeader = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
            Me.ChoreNameColumnHeader = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
            Me.UpButton = New System.Windows.Forms.Button()
            Me.DownButton = New System.Windows.Forms.Button()
            Me.ConfirmButton = New System.Windows.Forms.Button()
            Me.Panel1.SuspendLayout()
            Me.SuspendLayout()
            '
            'Label1
            '
            Me.Label1.AutoSize = True
            Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label1.Location = New System.Drawing.Point(3, 7)
            Me.Label1.Name = "Label1"
            Me.Label1.Size = New System.Drawing.Size(218, 24)
            Me.Label1.TabIndex = 1
            Me.Label1.Text = "Set chore preferences"
            '
            'Panel1
            '
            Me.Panel1.BackColor = System.Drawing.SystemColors.ControlDark
            Me.Panel1.Controls.Add(Me.Label1)
            Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
            Me.Panel1.Location = New System.Drawing.Point(0, 0)
            Me.Panel1.Name = "Panel1"
            Me.Panel1.Size = New System.Drawing.Size(267, 40)
            Me.Panel1.TabIndex = 17
            '
            'ChoreRankListView
            '
            Me.ChoreRankListView.AllowDrop = True
            Me.ChoreRankListView.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ChoreNameColumnHeader, Me.RankColumnHeader})
            Me.ChoreRankListView.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.ChoreRankListView.FullRowSelect = True
            Me.ChoreRankListView.GridLines = True
            Me.ChoreRankListView.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable
            Me.ChoreRankListView.HideSelection = False
            Me.ChoreRankListView.Location = New System.Drawing.Point(5, 46)
            Me.ChoreRankListView.MultiSelect = False
            Me.ChoreRankListView.Name = "ChoreRankListView"
            Me.ChoreRankListView.Size = New System.Drawing.Size(257, 293)
            Me.ChoreRankListView.Sorting = System.Windows.Forms.SortOrder.Descending
            Me.ChoreRankListView.TabIndex = 0
            Me.ChoreRankListView.UseCompatibleStateImageBehavior = False
            Me.ChoreRankListView.View = System.Windows.Forms.View.Details
            '
            'RankColumnHeader
            '
            Me.RankColumnHeader.Text = "Rank"
            Me.RankColumnHeader.Width = 47
            '
            'ChoreNameColumnHeader
            '
            Me.ChoreNameColumnHeader.Text = "Chore"
            Me.ChoreNameColumnHeader.Width = 204
            '
            'UpButton
            '
            Me.UpButton.Location = New System.Drawing.Point(161, 345)
            Me.UpButton.Name = "UpButton"
            Me.UpButton.Size = New System.Drawing.Size(48, 25)
            Me.UpButton.TabIndex = 18
            Me.UpButton.Text = "Up"
            Me.UpButton.UseVisualStyleBackColor = True
            '
            'DownButton
            '
            Me.DownButton.Location = New System.Drawing.Point(215, 345)
            Me.DownButton.Name = "DownButton"
            Me.DownButton.Size = New System.Drawing.Size(47, 25)
            Me.DownButton.TabIndex = 19
            Me.DownButton.Text = "Down"
            Me.DownButton.UseVisualStyleBackColor = True
            '
            'ConfirmButton
            '
            Me.ConfirmButton.Location = New System.Drawing.Point(181, 383)
            Me.ConfirmButton.Name = "ConfirmButton"
            Me.ConfirmButton.Size = New System.Drawing.Size(75, 23)
            Me.ConfirmButton.TabIndex = 20
            Me.ConfirmButton.Text = "Confirm"
            Me.ConfirmButton.UseVisualStyleBackColor = True
            '
            'ChorePreferencesView
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.Controls.Add(Me.ConfirmButton)
            Me.Controls.Add(Me.DownButton)
            Me.Controls.Add(Me.UpButton)
            Me.Controls.Add(Me.ChoreRankListView)
            Me.Controls.Add(Me.Panel1)
            Me.Name = "ChorePreferencesView"
            Me.Size = New System.Drawing.Size(267, 416)
            Me.Panel1.ResumeLayout(False)
            Me.Panel1.PerformLayout()
            Me.ResumeLayout(False)

        End Sub

        Friend WithEvents Label1 As Label
        Friend WithEvents Panel1 As Panel
        Friend WithEvents ChoreRankListView As ListView
        Friend WithEvents RankColumnHeader As ColumnHeader
        Friend WithEvents ChoreNameColumnHeader As ColumnHeader
        Friend WithEvents UpButton As Button
        Friend WithEvents DownButton As Button
        Friend WithEvents ConfirmButton As Button
    End Class
End Namespace