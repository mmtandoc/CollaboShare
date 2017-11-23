Namespace UI.Controls
    Public Class DistributionControl
        Public Property Distribution
        Public Sub New(distribution As Distribution)
            Me.Distribution = distribution
            ' This call is required by the designer.
            InitializeComponent()

            ' Add any initialization after the InitializeComponent() call.
            For Each c As KeyValuePair(Of Chore, SortedDictionary(Of Instance, Housemate)) In distribution.ChoreInstances
                Dim choreLabel As New Label With {
                        .AutoSize = True,
                        .Font = New Font("Microsoft Sans Serif", 9.25!, FontStyle.Bold, GraphicsUnit.Point, 0),
                        .Location = New Point(3, 0),
                        .Text = c.Key.Name + vbNewLine + "(" + c.Key.Frequency.ToString + ")",
                        .Margin = New Padding(0, 5, 0, 2)
                        }
                FlowLayoutPanel1.Controls.Add(choreLabel)
                For Each i As KeyValuePair(Of Instance, Housemate) In c.Value
                    Dim instanceLabel As New Label With {
                            .Text = i.Key.ToString() + "    (" + i.Value.Name.Split(" "c)(0) + ")",
                            .AutoSize = True,
                            .Font = New Font("Microsoft Sans Serif", 9.25!, FontStyle.Regular, GraphicsUnit.Point, 0),
                            .Location = New Point(3, 0),
                            .Margin = New Padding(0, 2, 0, 2)
                            }
                    FlowLayoutPanel1.Controls.Add(instanceLabel)

                Next
            Next
        End Sub
    End Class
End NameSpace