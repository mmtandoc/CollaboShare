Namespace UI.Controls
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial Class RecurrenceControl
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
            Me.GroupBox1 = New System.Windows.Forms.GroupBox()
            Me.FrequencyComboBox = New System.Windows.Forms.ComboBox()
            Me.CustomTabControl = New System.Windows.Forms.TabControl()
            Me.DailyTabPage = New System.Windows.Forms.TabPage()
            Me.Label2 = New System.Windows.Forms.Label()
            Me.DailyNumericUpDown = New System.Windows.Forms.NumericUpDown()
            Me.Label1 = New System.Windows.Forms.Label()
            Me.WeeklyTabPage = New System.Windows.Forms.TabPage()
            Me.Label3 = New System.Windows.Forms.Label()
            Me.WeeklyNumericUpDown = New System.Windows.Forms.NumericUpDown()
            Me.Label4 = New System.Windows.Forms.Label()
            Me.GroupBox2 = New System.Windows.Forms.GroupBox()
            Me.SaturdayCheckBox = New System.Windows.Forms.CheckBox()
            Me.SundayCheckBox = New System.Windows.Forms.CheckBox()
            Me.FridayCheckBox = New System.Windows.Forms.CheckBox()
            Me.MondayCheckBox = New System.Windows.Forms.CheckBox()
            Me.ThursdayCheckBox = New System.Windows.Forms.CheckBox()
            Me.TuesdayCheckBox = New System.Windows.Forms.CheckBox()
            Me.WednesdayCheckBox = New System.Windows.Forms.CheckBox()
            Me.MonthlyTabPage = New System.Windows.Forms.TabPage()
            Me.Label5 = New System.Windows.Forms.Label()
            Me.MonthlyNumericUpDown = New System.Windows.Forms.NumericUpDown()
            Me.Label6 = New System.Windows.Forms.Label()
            Me.AnnuallyTabPage = New System.Windows.Forms.TabPage()
            Me.Label7 = New System.Windows.Forms.Label()
            Me.AnnuallyNumericUpDown = New System.Windows.Forms.NumericUpDown()
            Me.Label8 = New System.Windows.Forms.Label()
            Me.GroupBox3 = New System.Windows.Forms.GroupBox()
            Me.DueDateDateTimePicker = New System.Windows.Forms.DateTimePicker()
            Me.GroupBox1.SuspendLayout()
            Me.CustomTabControl.SuspendLayout()
            Me.DailyTabPage.SuspendLayout()
            CType(Me.DailyNumericUpDown, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.WeeklyTabPage.SuspendLayout()
            CType(Me.WeeklyNumericUpDown, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.GroupBox2.SuspendLayout()
            Me.MonthlyTabPage.SuspendLayout()
            CType(Me.MonthlyNumericUpDown, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.AnnuallyTabPage.SuspendLayout()
            CType(Me.AnnuallyNumericUpDown, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.GroupBox3.SuspendLayout()
            Me.SuspendLayout()
            '
            'GroupBox1
            '
            Me.GroupBox1.Controls.Add(Me.FrequencyComboBox)
            Me.GroupBox1.Controls.Add(Me.CustomTabControl)
            Me.GroupBox1.Location = New System.Drawing.Point(3, 39)
            Me.GroupBox1.Name = "GroupBox1"
            Me.GroupBox1.Size = New System.Drawing.Size(245, 141)
            Me.GroupBox1.TabIndex = 0
            Me.GroupBox1.TabStop = False
            Me.GroupBox1.Text = "Frequency"
            '
            'FrequencyComboBox
            '
            Me.FrequencyComboBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.FrequencyComboBox.FormattingEnabled = True
            Me.FrequencyComboBox.Items.AddRange(New Object() {"Every day", "Every week", "Every month", "Every year", "Custom..."})
            Me.FrequencyComboBox.Location = New System.Drawing.Point(8, 19)
            Me.FrequencyComboBox.Name = "FrequencyComboBox"
            Me.FrequencyComboBox.Size = New System.Drawing.Size(203, 23)
            Me.FrequencyComboBox.TabIndex = 0
            Me.FrequencyComboBox.Text = "Every..."
            '
            'CustomTabControl
            '
            Me.CustomTabControl.Controls.Add(Me.DailyTabPage)
            Me.CustomTabControl.Controls.Add(Me.WeeklyTabPage)
            Me.CustomTabControl.Controls.Add(Me.MonthlyTabPage)
            Me.CustomTabControl.Controls.Add(Me.AnnuallyTabPage)
            Me.CustomTabControl.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.CustomTabControl.Location = New System.Drawing.Point(4, 42)
            Me.CustomTabControl.Multiline = True
            Me.CustomTabControl.Name = "CustomTabControl"
            Me.CustomTabControl.SelectedIndex = 0
            Me.CustomTabControl.Size = New System.Drawing.Size(235, 99)
            Me.CustomTabControl.TabIndex = 5
            Me.CustomTabControl.Visible = False
            '
            'DailyTabPage
            '
            Me.DailyTabPage.Controls.Add(Me.Label2)
            Me.DailyTabPage.Controls.Add(Me.DailyNumericUpDown)
            Me.DailyTabPage.Controls.Add(Me.Label1)
            Me.DailyTabPage.Location = New System.Drawing.Point(4, 24)
            Me.DailyTabPage.Name = "DailyTabPage"
            Me.DailyTabPage.Padding = New System.Windows.Forms.Padding(3)
            Me.DailyTabPage.Size = New System.Drawing.Size(227, 71)
            Me.DailyTabPage.TabIndex = 0
            Me.DailyTabPage.Text = "Daily"
            Me.DailyTabPage.UseVisualStyleBackColor = True
            '
            'Label2
            '
            Me.Label2.AutoSize = True
            Me.Label2.Location = New System.Drawing.Point(106, 5)
            Me.Label2.Name = "Label2"
            Me.Label2.Size = New System.Drawing.Size(32, 15)
            Me.Label2.TabIndex = 2
            Me.Label2.Text = "days"
            '
            'DailyNumericUpDown
            '
            Me.DailyNumericUpDown.Location = New System.Drawing.Point(51, 3)
            Me.DailyNumericUpDown.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
            Me.DailyNumericUpDown.Name = "DailyNumericUpDown"
            Me.DailyNumericUpDown.Size = New System.Drawing.Size(49, 21)
            Me.DailyNumericUpDown.TabIndex = 1
            Me.DailyNumericUpDown.Value = New Decimal(New Integer() {1, 0, 0, 0})
            '
            'Label1
            '
            Me.Label1.AutoSize = True
            Me.Label1.Location = New System.Drawing.Point(6, 5)
            Me.Label1.Name = "Label1"
            Me.Label1.Size = New System.Drawing.Size(36, 15)
            Me.Label1.TabIndex = 0
            Me.Label1.Text = "Every"
            '
            'WeeklyTabPage
            '
            Me.WeeklyTabPage.Controls.Add(Me.Label3)
            Me.WeeklyTabPage.Controls.Add(Me.WeeklyNumericUpDown)
            Me.WeeklyTabPage.Controls.Add(Me.Label4)
            Me.WeeklyTabPage.Controls.Add(Me.GroupBox2)
            Me.WeeklyTabPage.Location = New System.Drawing.Point(4, 24)
            Me.WeeklyTabPage.Name = "WeeklyTabPage"
            Me.WeeklyTabPage.Padding = New System.Windows.Forms.Padding(3)
            Me.WeeklyTabPage.Size = New System.Drawing.Size(227, 71)
            Me.WeeklyTabPage.TabIndex = 1
            Me.WeeklyTabPage.Text = "Weekly"
            Me.WeeklyTabPage.UseVisualStyleBackColor = True
            '
            'Label3
            '
            Me.Label3.AutoSize = True
            Me.Label3.Location = New System.Drawing.Point(106, 5)
            Me.Label3.Name = "Label3"
            Me.Label3.Size = New System.Drawing.Size(42, 15)
            Me.Label3.TabIndex = 5
            Me.Label3.Text = "weeks"
            '
            'WeeklyNumericUpDown
            '
            Me.WeeklyNumericUpDown.Location = New System.Drawing.Point(51, 3)
            Me.WeeklyNumericUpDown.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
            Me.WeeklyNumericUpDown.Name = "WeeklyNumericUpDown"
            Me.WeeklyNumericUpDown.Size = New System.Drawing.Size(49, 21)
            Me.WeeklyNumericUpDown.TabIndex = 4
            Me.WeeklyNumericUpDown.Value = New Decimal(New Integer() {1, 0, 0, 0})
            '
            'Label4
            '
            Me.Label4.AutoSize = True
            Me.Label4.Location = New System.Drawing.Point(6, 5)
            Me.Label4.Name = "Label4"
            Me.Label4.Size = New System.Drawing.Size(36, 15)
            Me.Label4.TabIndex = 3
            Me.Label4.Text = "Every"
            '
            'GroupBox2
            '
            Me.GroupBox2.Controls.Add(Me.SaturdayCheckBox)
            Me.GroupBox2.Controls.Add(Me.SundayCheckBox)
            Me.GroupBox2.Controls.Add(Me.FridayCheckBox)
            Me.GroupBox2.Controls.Add(Me.MondayCheckBox)
            Me.GroupBox2.Controls.Add(Me.ThursdayCheckBox)
            Me.GroupBox2.Controls.Add(Me.TuesdayCheckBox)
            Me.GroupBox2.Controls.Add(Me.WednesdayCheckBox)
            Me.GroupBox2.Location = New System.Drawing.Point(4, 19)
            Me.GroupBox2.Name = "GroupBox2"
            Me.GroupBox2.Size = New System.Drawing.Size(246, 50)
            Me.GroupBox2.TabIndex = 7
            Me.GroupBox2.TabStop = False
            '
            'SaturdayCheckBox
            '
            Me.SaturdayCheckBox.AutoSize = True
            Me.SaturdayCheckBox.Location = New System.Drawing.Point(115, 30)
            Me.SaturdayCheckBox.Name = "SaturdayCheckBox"
            Me.SaturdayCheckBox.Size = New System.Drawing.Size(44, 19)
            Me.SaturdayCheckBox.TabIndex = 6
            Me.SaturdayCheckBox.Text = "Sat"
            Me.SaturdayCheckBox.UseVisualStyleBackColor = True
            '
            'SundayCheckBox
            '
            Me.SundayCheckBox.AutoSize = True
            Me.SundayCheckBox.Location = New System.Drawing.Point(5, 8)
            Me.SundayCheckBox.Name = "SundayCheckBox"
            Me.SundayCheckBox.Size = New System.Drawing.Size(48, 19)
            Me.SundayCheckBox.TabIndex = 0
            Me.SundayCheckBox.Text = "Sun"
            Me.SundayCheckBox.UseVisualStyleBackColor = True
            '
            'FridayCheckBox
            '
            Me.FridayCheckBox.AutoSize = True
            Me.FridayCheckBox.Location = New System.Drawing.Point(63, 30)
            Me.FridayCheckBox.Name = "FridayCheckBox"
            Me.FridayCheckBox.Size = New System.Drawing.Size(40, 19)
            Me.FridayCheckBox.TabIndex = 5
            Me.FridayCheckBox.Text = "Fri"
            Me.FridayCheckBox.UseVisualStyleBackColor = True
            '
            'MondayCheckBox
            '
            Me.MondayCheckBox.AutoSize = True
            Me.MondayCheckBox.Location = New System.Drawing.Point(63, 8)
            Me.MondayCheckBox.Name = "MondayCheckBox"
            Me.MondayCheckBox.Size = New System.Drawing.Size(51, 19)
            Me.MondayCheckBox.TabIndex = 1
            Me.MondayCheckBox.Text = "Mon"
            Me.MondayCheckBox.UseVisualStyleBackColor = True
            '
            'ThursdayCheckBox
            '
            Me.ThursdayCheckBox.AutoSize = True
            Me.ThursdayCheckBox.Location = New System.Drawing.Point(5, 30)
            Me.ThursdayCheckBox.Name = "ThursdayCheckBox"
            Me.ThursdayCheckBox.Size = New System.Drawing.Size(57, 19)
            Me.ThursdayCheckBox.TabIndex = 4
            Me.ThursdayCheckBox.Text = "Thurs"
            Me.ThursdayCheckBox.UseVisualStyleBackColor = True
            '
            'TuesdayCheckBox
            '
            Me.TuesdayCheckBox.AutoSize = True
            Me.TuesdayCheckBox.Location = New System.Drawing.Point(115, 8)
            Me.TuesdayCheckBox.Name = "TuesdayCheckBox"
            Me.TuesdayCheckBox.Size = New System.Drawing.Size(53, 19)
            Me.TuesdayCheckBox.TabIndex = 2
            Me.TuesdayCheckBox.Text = "Tues"
            Me.TuesdayCheckBox.UseVisualStyleBackColor = True
            '
            'WednesdayCheckBox
            '
            Me.WednesdayCheckBox.AutoSize = True
            Me.WednesdayCheckBox.Location = New System.Drawing.Point(169, 8)
            Me.WednesdayCheckBox.Name = "WednesdayCheckBox"
            Me.WednesdayCheckBox.Size = New System.Drawing.Size(54, 19)
            Me.WednesdayCheckBox.TabIndex = 3
            Me.WednesdayCheckBox.Text = "Wed."
            Me.WednesdayCheckBox.UseVisualStyleBackColor = True
            '
            'MonthlyTabPage
            '
            Me.MonthlyTabPage.Controls.Add(Me.Label5)
            Me.MonthlyTabPage.Controls.Add(Me.MonthlyNumericUpDown)
            Me.MonthlyTabPage.Controls.Add(Me.Label6)
            Me.MonthlyTabPage.Location = New System.Drawing.Point(4, 24)
            Me.MonthlyTabPage.Name = "MonthlyTabPage"
            Me.MonthlyTabPage.Padding = New System.Windows.Forms.Padding(3)
            Me.MonthlyTabPage.Size = New System.Drawing.Size(227, 71)
            Me.MonthlyTabPage.TabIndex = 2
            Me.MonthlyTabPage.Text = "Monthly"
            Me.MonthlyTabPage.UseVisualStyleBackColor = True
            '
            'Label5
            '
            Me.Label5.AutoSize = True
            Me.Label5.Location = New System.Drawing.Point(106, 5)
            Me.Label5.Name = "Label5"
            Me.Label5.Size = New System.Drawing.Size(48, 15)
            Me.Label5.TabIndex = 8
            Me.Label5.Text = "months"
            '
            'MonthlyNumericUpDown
            '
            Me.MonthlyNumericUpDown.Location = New System.Drawing.Point(51, 3)
            Me.MonthlyNumericUpDown.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
            Me.MonthlyNumericUpDown.Name = "MonthlyNumericUpDown"
            Me.MonthlyNumericUpDown.Size = New System.Drawing.Size(49, 21)
            Me.MonthlyNumericUpDown.TabIndex = 7
            Me.MonthlyNumericUpDown.Value = New Decimal(New Integer() {1, 0, 0, 0})
            '
            'Label6
            '
            Me.Label6.AutoSize = True
            Me.Label6.Location = New System.Drawing.Point(6, 5)
            Me.Label6.Name = "Label6"
            Me.Label6.Size = New System.Drawing.Size(36, 15)
            Me.Label6.TabIndex = 6
            Me.Label6.Text = "Every"
            '
            'AnnuallyTabPage
            '
            Me.AnnuallyTabPage.Controls.Add(Me.Label7)
            Me.AnnuallyTabPage.Controls.Add(Me.AnnuallyNumericUpDown)
            Me.AnnuallyTabPage.Controls.Add(Me.Label8)
            Me.AnnuallyTabPage.Location = New System.Drawing.Point(4, 24)
            Me.AnnuallyTabPage.Name = "AnnuallyTabPage"
            Me.AnnuallyTabPage.Padding = New System.Windows.Forms.Padding(3)
            Me.AnnuallyTabPage.Size = New System.Drawing.Size(227, 71)
            Me.AnnuallyTabPage.TabIndex = 3
            Me.AnnuallyTabPage.Text = "Annually"
            Me.AnnuallyTabPage.UseVisualStyleBackColor = True
            '
            'Label7
            '
            Me.Label7.AutoSize = True
            Me.Label7.Location = New System.Drawing.Point(106, 5)
            Me.Label7.Name = "Label7"
            Me.Label7.Size = New System.Drawing.Size(36, 15)
            Me.Label7.TabIndex = 8
            Me.Label7.Text = "years"
            '
            'AnnuallyNumericUpDown
            '
            Me.AnnuallyNumericUpDown.Location = New System.Drawing.Point(51, 3)
            Me.AnnuallyNumericUpDown.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
            Me.AnnuallyNumericUpDown.Name = "AnnuallyNumericUpDown"
            Me.AnnuallyNumericUpDown.Size = New System.Drawing.Size(49, 21)
            Me.AnnuallyNumericUpDown.TabIndex = 7
            Me.AnnuallyNumericUpDown.Value = New Decimal(New Integer() {1, 0, 0, 0})
            '
            'Label8
            '
            Me.Label8.AutoSize = True
            Me.Label8.Location = New System.Drawing.Point(6, 5)
            Me.Label8.Name = "Label8"
            Me.Label8.Size = New System.Drawing.Size(36, 15)
            Me.Label8.TabIndex = 6
            Me.Label8.Text = "Every"
            '
            'GroupBox3
            '
            Me.GroupBox3.Controls.Add(Me.DueDateDateTimePicker)
            Me.GroupBox3.Location = New System.Drawing.Point(3, 0)
            Me.GroupBox3.Name = "GroupBox3"
            Me.GroupBox3.Size = New System.Drawing.Size(245, 39)
            Me.GroupBox3.TabIndex = 6
            Me.GroupBox3.TabStop = False
            Me.GroupBox3.Text = "Due Date"
            '
            'DueDateDateTimePicker
            '
            Me.DueDateDateTimePicker.Location = New System.Drawing.Point(8, 15)
            Me.DueDateDateTimePicker.MinDate = New Date(2017, 11, 20, 0, 0, 0, 0)
            Me.DueDateDateTimePicker.Name = "DueDateDateTimePicker"
            Me.DueDateDateTimePicker.Size = New System.Drawing.Size(200, 20)
            Me.DueDateDateTimePicker.TabIndex = 0
            '
            'RecurrenceControl
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.Controls.Add(Me.GroupBox3)
            Me.Controls.Add(Me.GroupBox1)
            Me.Name = "RecurrenceControl"
            Me.Size = New System.Drawing.Size(251, 177)
            Me.GroupBox1.ResumeLayout(False)
            Me.CustomTabControl.ResumeLayout(False)
            Me.DailyTabPage.ResumeLayout(False)
            Me.DailyTabPage.PerformLayout()
            CType(Me.DailyNumericUpDown, System.ComponentModel.ISupportInitialize).EndInit()
            Me.WeeklyTabPage.ResumeLayout(False)
            Me.WeeklyTabPage.PerformLayout()
            CType(Me.WeeklyNumericUpDown, System.ComponentModel.ISupportInitialize).EndInit()
            Me.GroupBox2.ResumeLayout(False)
            Me.GroupBox2.PerformLayout()
            Me.MonthlyTabPage.ResumeLayout(False)
            Me.MonthlyTabPage.PerformLayout()
            CType(Me.MonthlyNumericUpDown, System.ComponentModel.ISupportInitialize).EndInit()
            Me.AnnuallyTabPage.ResumeLayout(False)
            Me.AnnuallyTabPage.PerformLayout()
            CType(Me.AnnuallyNumericUpDown, System.ComponentModel.ISupportInitialize).EndInit()
            Me.GroupBox3.ResumeLayout(False)
            Me.ResumeLayout(False)

        End Sub

        Friend WithEvents GroupBox1 As GroupBox
        Friend WithEvents CustomTabControl As TabControl
        Friend WithEvents DailyTabPage As TabPage
        Friend WithEvents WeeklyTabPage As TabPage
        Friend WithEvents MonthlyTabPage As TabPage
        Friend WithEvents AnnuallyTabPage As TabPage
        Friend WithEvents DailyNumericUpDown As NumericUpDown
        Friend WithEvents Label1 As Label
        Friend WithEvents Label2 As Label
        Friend WithEvents Label3 As Label
        Friend WithEvents WeeklyNumericUpDown As NumericUpDown
        Friend WithEvents Label4 As Label
        Friend WithEvents Label5 As Label
        Friend WithEvents MonthlyNumericUpDown As NumericUpDown
        Friend WithEvents Label6 As Label
        Friend WithEvents Label7 As Label
        Friend WithEvents AnnuallyNumericUpDown As NumericUpDown
        Friend WithEvents Label8 As Label
        Friend WithEvents SaturdayCheckBox As CheckBox
        Friend WithEvents FridayCheckBox As CheckBox
        Friend WithEvents ThursdayCheckBox As CheckBox
        Friend WithEvents WednesdayCheckBox As CheckBox
        Friend WithEvents TuesdayCheckBox As CheckBox
        Friend WithEvents MondayCheckBox As CheckBox
        Friend WithEvents SundayCheckBox As CheckBox
        Friend WithEvents GroupBox2 As GroupBox
        Friend WithEvents GroupBox3 As GroupBox
        Friend WithEvents DueDateDateTimePicker As DateTimePicker
        Friend WithEvents FrequencyComboBox As ComboBox
    End Class
End NameSpace