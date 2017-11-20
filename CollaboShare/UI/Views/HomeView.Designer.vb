Namespace UI.Views
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial Class HomeView
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
            Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
            Me.ToDoListButton = New System.Windows.Forms.Button()
            Me.MyProfileButton = New System.Windows.Forms.Button()
            Me.ChoresButton = New System.Windows.Forms.Button()
            Me.HouseholdButton = New System.Windows.Forms.Button()
            Me.BulletinButton = New System.Windows.Forms.Button()
            Me.Label1 = New System.Windows.Forms.Label()
            Me.Label2 = New System.Windows.Forms.Label()
            Me.Label3 = New System.Windows.Forms.Label()
            Me.Label4 = New System.Windows.Forms.Label()
            Me.Label5 = New System.Windows.Forms.Label()
            Me.DistributionButton = New System.Windows.Forms.Button()
            Me.Label6 = New System.Windows.Forms.Label()
            Me.TableLayoutPanel1.SuspendLayout()
            Me.SuspendLayout()
            '
            'TableLayoutPanel1
            '
            Me.TableLayoutPanel1.ColumnCount = 2
            Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
            Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
            Me.TableLayoutPanel1.Controls.Add(Me.ToDoListButton, 0, 0)
            Me.TableLayoutPanel1.Controls.Add(Me.MyProfileButton, 1, 0)
            Me.TableLayoutPanel1.Controls.Add(Me.ChoresButton, 0, 2)
            Me.TableLayoutPanel1.Controls.Add(Me.HouseholdButton, 1, 2)
            Me.TableLayoutPanel1.Controls.Add(Me.BulletinButton, 0, 4)
            Me.TableLayoutPanel1.Controls.Add(Me.Label1, 0, 3)
            Me.TableLayoutPanel1.Controls.Add(Me.Label2, 0, 1)
            Me.TableLayoutPanel1.Controls.Add(Me.Label3, 1, 1)
            Me.TableLayoutPanel1.Controls.Add(Me.Label4, 1, 3)
            Me.TableLayoutPanel1.Controls.Add(Me.Label5, 0, 5)
            Me.TableLayoutPanel1.Controls.Add(Me.DistributionButton, 1, 4)
            Me.TableLayoutPanel1.Controls.Add(Me.Label6, 1, 5)
            Me.TableLayoutPanel1.Location = New System.Drawing.Point(19, 21)
            Me.TableLayoutPanel1.Margin = New System.Windows.Forms.Padding(2)
            Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
            Me.TableLayoutPanel1.RowCount = 6
            Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33334!))
            Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
            Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33332!))
            Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
            Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33334!))
            Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
            Me.TableLayoutPanel1.Size = New System.Drawing.Size(233, 371)
            Me.TableLayoutPanel1.TabIndex = 0
            '
            'ToDoListButton
            '
            Me.ToDoListButton.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.ToDoListButton.BackgroundImage = Global.CollaboShare.My.Resources.Resources.List
            Me.ToDoListButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
            Me.ToDoListButton.Location = New System.Drawing.Point(7, 7)
            Me.ToDoListButton.Margin = New System.Windows.Forms.Padding(7)
            Me.ToDoListButton.Name = "ToDoListButton"
            Me.ToDoListButton.Size = New System.Drawing.Size(102, 89)
            Me.ToDoListButton.TabIndex = 0
            Me.ToDoListButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter
            Me.ToDoListButton.UseVisualStyleBackColor = True
            '
            'MyProfileButton
            '
            Me.MyProfileButton.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.MyProfileButton.BackgroundImage = Global.CollaboShare.My.Resources.Resources.User
            Me.MyProfileButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
            Me.MyProfileButton.Location = New System.Drawing.Point(123, 7)
            Me.MyProfileButton.Margin = New System.Windows.Forms.Padding(7)
            Me.MyProfileButton.Name = "MyProfileButton"
            Me.MyProfileButton.Size = New System.Drawing.Size(103, 89)
            Me.MyProfileButton.TabIndex = 0
            Me.MyProfileButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter
            Me.MyProfileButton.UseVisualStyleBackColor = True
            '
            'ChoresButton
            '
            Me.ChoresButton.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.ChoresButton.BackgroundImage = Global.CollaboShare.My.Resources.Resources.Chore
            Me.ChoresButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
            Me.ChoresButton.Location = New System.Drawing.Point(7, 130)
            Me.ChoresButton.Margin = New System.Windows.Forms.Padding(7)
            Me.ChoresButton.Name = "ChoresButton"
            Me.ChoresButton.Size = New System.Drawing.Size(102, 89)
            Me.ChoresButton.TabIndex = 0
            Me.ChoresButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter
            Me.ChoresButton.UseVisualStyleBackColor = True
            '
            'HouseholdButton
            '
            Me.HouseholdButton.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.HouseholdButton.BackgroundImage = Global.CollaboShare.My.Resources.Resources.Home
            Me.HouseholdButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
            Me.HouseholdButton.ImageAlign = System.Drawing.ContentAlignment.TopCenter
            Me.HouseholdButton.Location = New System.Drawing.Point(123, 130)
            Me.HouseholdButton.Margin = New System.Windows.Forms.Padding(7)
            Me.HouseholdButton.Name = "HouseholdButton"
            Me.HouseholdButton.Size = New System.Drawing.Size(103, 89)
            Me.HouseholdButton.TabIndex = 0
            Me.HouseholdButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter
            Me.HouseholdButton.UseVisualStyleBackColor = True
            '
            'BulletinButton
            '
            Me.BulletinButton.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.BulletinButton.BackgroundImage = Global.CollaboShare.My.Resources.Resources.Meeting
            Me.BulletinButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
            Me.BulletinButton.Location = New System.Drawing.Point(7, 253)
            Me.BulletinButton.Margin = New System.Windows.Forms.Padding(7)
            Me.BulletinButton.Name = "BulletinButton"
            Me.BulletinButton.Size = New System.Drawing.Size(102, 89)
            Me.BulletinButton.TabIndex = 0
            Me.BulletinButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter
            Me.BulletinButton.UseVisualStyleBackColor = True
            '
            'Label1
            '
            Me.Label1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label1.Location = New System.Drawing.Point(3, 226)
            Me.Label1.Name = "Label1"
            Me.Label1.Size = New System.Drawing.Size(110, 20)
            Me.Label1.TabIndex = 1
            Me.Label1.Text = "Chores"
            Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
            '
            'Label2
            '
            Me.Label2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label2.Location = New System.Drawing.Point(3, 103)
            Me.Label2.Name = "Label2"
            Me.Label2.Size = New System.Drawing.Size(110, 20)
            Me.Label2.TabIndex = 1
            Me.Label2.Text = "To-do List"
            Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
            '
            'Label3
            '
            Me.Label3.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label3.Location = New System.Drawing.Point(119, 103)
            Me.Label3.Name = "Label3"
            Me.Label3.Size = New System.Drawing.Size(111, 20)
            Me.Label3.TabIndex = 1
            Me.Label3.Text = "My Profile"
            Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
            '
            'Label4
            '
            Me.Label4.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label4.Location = New System.Drawing.Point(119, 226)
            Me.Label4.Name = "Label4"
            Me.Label4.Size = New System.Drawing.Size(111, 20)
            Me.Label4.TabIndex = 1
            Me.Label4.Text = "Household"
            Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
            '
            'Label5
            '
            Me.Label5.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label5.Location = New System.Drawing.Point(3, 349)
            Me.Label5.Name = "Label5"
            Me.Label5.Size = New System.Drawing.Size(110, 20)
            Me.Label5.TabIndex = 1
            Me.Label5.Text = "Trading && Polls"
            Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
            '
            'DistributionButton
            '
            Me.DistributionButton.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.DistributionButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
            Me.DistributionButton.Location = New System.Drawing.Point(123, 253)
            Me.DistributionButton.Margin = New System.Windows.Forms.Padding(7)
            Me.DistributionButton.Name = "DistributionButton"
            Me.DistributionButton.Size = New System.Drawing.Size(103, 89)
            Me.DistributionButton.TabIndex = 0
            Me.DistributionButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter
            Me.DistributionButton.UseVisualStyleBackColor = True
            '
            'Label6
            '
            Me.Label6.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label6.Location = New System.Drawing.Point(119, 349)
            Me.Label6.Name = "Label6"
            Me.Label6.Size = New System.Drawing.Size(111, 20)
            Me.Label6.TabIndex = 1
            Me.Label6.Text = "Distributions"
            Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
            '
            'HomeView
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.Controls.Add(Me.TableLayoutPanel1)
            Me.Margin = New System.Windows.Forms.Padding(2)
            Me.Name = "HomeView"
            Me.Size = New System.Drawing.Size(267, 416)
            Me.TableLayoutPanel1.ResumeLayout(False)
            Me.ResumeLayout(False)

        End Sub

        Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
        Friend WithEvents ToDoListButton As Button
        Friend WithEvents MyProfileButton As Button
        Friend WithEvents ChoresButton As Button
        Friend WithEvents HouseholdButton As Button
        Friend WithEvents BulletinButton As Button
        Friend WithEvents Label1 As Label
        Friend WithEvents Label2 As Label
        Friend WithEvents Label3 As Label
        Friend WithEvents Label4 As Label
        Friend WithEvents Label5 As Label
        Friend WithEvents DistributionButton As Button
        Friend WithEvents Label6 As Label
    End Class
End NameSpace