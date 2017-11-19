Namespace UI.Views

    Public Class ChorePreferencesView
        Public Property Housemate As Housemate
        Public Property Household As Household

        Public ReadOnly Property Phone() As PhoneForm
            Get
                Return FindForm()
            End Get
        End Property

        Public Sub New(ByRef housemate As Housemate, ByRef household As Household)
            Me.Housemate = housemate
            Me.Household = household
            ' This call is required by the designer.
            InitializeComponent()

            ' Add any initialization after the InitializeComponent() call.

        End Sub

        Protected Overrides Sub OnLoad(e As EventArgs)
            For Each c As Chore In Household.Chores
                Dim rank As Integer = ChoreRankListView.Items.Count + 1
                If Housemate.ChorePreferences.ContainsKey(c) Then
                    rank = Housemate.ChorePreferences(c)
                End If
                Dim item As ListViewItem = CreateChoreListItem(c, rank)
                ChoreRankListView.Items.Add(item)
            Next
            Me.ChoreRankListView.ListViewItemSorter = New ListViewItemComparer(1)
            ChoreRankListView.Sort()
        End Sub

        Private Function CreateChoreListItem(ByRef chore As Chore, rank As Integer) As ListViewItem
            Dim item As New ListViewItem With {
                .Text = chore.Name,
                .Tag = chore
            }
            item.SubItems.Add(rank.ToString)
            Return item
        End Function


        Private Sub UpButton_Click(sender As Object, e As EventArgs) Handles UpButton.Click
            If Not IsNothing(ChoreRankListView.SelectedItems) Then
                Dim selectedItem As ListViewItem = ChoreRankListView.SelectedItems(0)
                Dim index = ChoreRankListView.Items.IndexOf(selectedItem)
                If index > 0 Then
                    ChoreRankListView.Items.Remove(selectedItem)
                    selectedItem.SubItems(1).Text = (index - 1).ToString
                    ChoreRankListView.Items.Insert(index - 1, selectedItem)
                    RerankChores()
                End If
            End If

        End Sub

        Private Sub DownButton_Click(sender As Object, e As EventArgs) Handles DownButton.Click
            If Not IsNothing(ChoreRankListView.SelectedItems) Then
                Dim selectedItem As ListViewItem = ChoreRankListView.SelectedItems(0)
                Dim index = ChoreRankListView.Items.IndexOf(selectedItem)

                If index < ChoreRankListView.Items.Count - 1 Then
                    ChoreRankListView.Items.Remove(selectedItem)
                    selectedItem.SubItems(1).Text = (index + 2).ToString
                    ChoreRankListView.Items.Insert(index + 1, selectedItem)
                    RerankChores()
                End If
            End If
        End Sub

        Private Sub RerankChores()
            For Each item As ListViewItem In ChoreRankListView.Items
                Dim rank = ChoreRankListView.Items.IndexOf(item) + 1
                item.SubItems(1).Text = rank.ToString
            Next
            ChoreRankListView.Sort()
        End Sub

        Private Sub ConfirmButton_Click(sender As Object, e As EventArgs) Handles ConfirmButton.Click
            Housemate.ChorePreferences.Clear()
            For Each item As ListViewItem In ChoreRankListView.Items
                Housemate.ChorePreferences.Add(item.Tag, Integer.Parse(item.SubItems(1).Text))
            Next

            Phone.ChangeView(New ProfileView(Housemate))
        End Sub

        Private Class ListViewItemComparer
            Implements IComparer
            Private col As Integer = 0

            Public Sub New(column As Integer)
                col = column
            End Sub

            Public Function Compare(x As Object, y As Object) As Integer Implements IComparer.Compare
                Dim returnVal As Integer = -1
                returnVal = [String].Compare(CType(x, ListViewItem).SubItems(col).Text, CType(y, ListViewItem).SubItems(col).Text)
                Return returnVal
            End Function
        End Class

    End Class
End Namespace