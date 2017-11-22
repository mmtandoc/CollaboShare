Namespace UI.Controls
    Public Class ChoreRatingControl
        Private stars As New List(Of PictureBox)

        Public Sub New(rating As Integer)

            ' This call is required by the designer.
            InitializeComponent()

            ' Add any initialization after the InitializeComponent() call.
            stars.AddRange({StarPictureBox1, StarPictureBox2, StarPictureBox3, StarPictureBox4, StarPictureBox5})

            For index = 0 To rating - 1
                stars(index).Visible = True
            Next
        End Sub
    End Class
End Namespace