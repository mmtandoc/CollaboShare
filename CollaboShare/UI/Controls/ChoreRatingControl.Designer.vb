Namespace UI.Controls
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
    Partial Class ChoreRatingControl
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
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ChoreRatingControl))
            Me.FlowLayoutPanel1 = New System.Windows.Forms.FlowLayoutPanel()
            Me.StarPictureBox1 = New System.Windows.Forms.PictureBox()
            Me.StarPictureBox2 = New System.Windows.Forms.PictureBox()
            Me.StarPictureBox3 = New System.Windows.Forms.PictureBox()
            Me.StarPictureBox4 = New System.Windows.Forms.PictureBox()
            Me.StarPictureBox5 = New System.Windows.Forms.PictureBox()
            Me.FlowLayoutPanel1.SuspendLayout()
            CType(Me.StarPictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.StarPictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.StarPictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.StarPictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.StarPictureBox5, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            '
            'FlowLayoutPanel1
            '
            Me.FlowLayoutPanel1.Controls.Add(Me.StarPictureBox1)
            Me.FlowLayoutPanel1.Controls.Add(Me.StarPictureBox2)
            Me.FlowLayoutPanel1.Controls.Add(Me.StarPictureBox3)
            Me.FlowLayoutPanel1.Controls.Add(Me.StarPictureBox4)
            Me.FlowLayoutPanel1.Controls.Add(Me.StarPictureBox5)
            Me.FlowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.FlowLayoutPanel1.Location = New System.Drawing.Point(0, 0)
            Me.FlowLayoutPanel1.Name = "FlowLayoutPanel1"
            Me.FlowLayoutPanel1.Size = New System.Drawing.Size(259, 53)
            Me.FlowLayoutPanel1.TabIndex = 0
            '
            'StarPictureBox1
            '
            Me.StarPictureBox1.Image = CType(resources.GetObject("StarPictureBox1.Image"), System.Drawing.Image)
            Me.StarPictureBox1.Location = New System.Drawing.Point(3, 3)
            Me.StarPictureBox1.Name = "StarPictureBox1"
            Me.StarPictureBox1.Size = New System.Drawing.Size(45, 47)
            Me.StarPictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
            Me.StarPictureBox1.TabIndex = 1
            Me.StarPictureBox1.TabStop = False
            Me.StarPictureBox1.Visible = False
            '
            'StarPictureBox2
            '
            Me.StarPictureBox2.Image = CType(resources.GetObject("StarPictureBox2.Image"), System.Drawing.Image)
            Me.StarPictureBox2.Location = New System.Drawing.Point(54, 3)
            Me.StarPictureBox2.Name = "StarPictureBox2"
            Me.StarPictureBox2.Size = New System.Drawing.Size(45, 47)
            Me.StarPictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
            Me.StarPictureBox2.TabIndex = 2
            Me.StarPictureBox2.TabStop = False
            Me.StarPictureBox2.Visible = False
            '
            'StarPictureBox3
            '
            Me.StarPictureBox3.Image = CType(resources.GetObject("StarPictureBox3.Image"), System.Drawing.Image)
            Me.StarPictureBox3.Location = New System.Drawing.Point(105, 3)
            Me.StarPictureBox3.Name = "StarPictureBox3"
            Me.StarPictureBox3.Size = New System.Drawing.Size(45, 47)
            Me.StarPictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
            Me.StarPictureBox3.TabIndex = 3
            Me.StarPictureBox3.TabStop = False
            Me.StarPictureBox3.Visible = False
            '
            'StarPictureBox4
            '
            Me.StarPictureBox4.Image = CType(resources.GetObject("StarPictureBox4.Image"), System.Drawing.Image)
            Me.StarPictureBox4.Location = New System.Drawing.Point(156, 3)
            Me.StarPictureBox4.Name = "StarPictureBox4"
            Me.StarPictureBox4.Size = New System.Drawing.Size(45, 47)
            Me.StarPictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
            Me.StarPictureBox4.TabIndex = 4
            Me.StarPictureBox4.TabStop = False
            Me.StarPictureBox4.Visible = False
            '
            'StarPictureBox5
            '
            Me.StarPictureBox5.Image = CType(resources.GetObject("StarPictureBox5.Image"), System.Drawing.Image)
            Me.StarPictureBox5.Location = New System.Drawing.Point(207, 3)
            Me.StarPictureBox5.Name = "StarPictureBox5"
            Me.StarPictureBox5.Size = New System.Drawing.Size(45, 47)
            Me.StarPictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
            Me.StarPictureBox5.TabIndex = 5
            Me.StarPictureBox5.TabStop = False
            Me.StarPictureBox5.Visible = False
            '
            'ChoreRatingControl
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.Controls.Add(Me.FlowLayoutPanel1)
            Me.Name = "ChoreRatingControl"
            Me.Size = New System.Drawing.Size(259, 53)
            Me.FlowLayoutPanel1.ResumeLayout(False)
            CType(Me.StarPictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.StarPictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.StarPictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.StarPictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.StarPictureBox5, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)

        End Sub

        Friend WithEvents FlowLayoutPanel1 As FlowLayoutPanel
        Friend WithEvents StarPictureBox1 As PictureBox
        Friend WithEvents StarPictureBox2 As PictureBox
        Friend WithEvents StarPictureBox3 As PictureBox
        Friend WithEvents StarPictureBox4 As PictureBox
        Friend WithEvents StarPictureBox5 As PictureBox
    End Class
End Namespace