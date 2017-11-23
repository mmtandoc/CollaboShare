Namespace UI.Views
    Public Class CreateCounterofferView
        Public Event CreatedCounteroffer As EventHandler
        
        Public Property Offer As Offer

        Public ReadOnly Property Phone() As PhoneForm
            Get
                Return FindForm()
            End Get
        End Property
        
        Public Sub New(offer As Offer)
            Me.Offer = offer
            ' This call is required by the designer.
            InitializeComponent()

            ' Add any initialization after the InitializeComponent() call.

        End Sub

        Protected Overrides Sub OnLoad(e As EventArgs)
            For Each c In _
                Phone.Household.Distribution.ChoreInstances.Where(
                    Function(keyValuePair) keyValuePair.Value.Values.Any(Function(housemate) housemate Is Phone.Profile))
                Dim choreTreeNode As New TreeNode(c.Key.Name)
                choreTreeNode.Tag = c.Key
                InstancesTreeView.Nodes.Add(choreTreeNode)
                For Each i In c.Value.Where(Function(pair) pair.Value Is Phone.Profile)
                    Dim instanceTreeNode As New TreeNode(i.Key.ToString)
                    instanceTreeNode.Tag = i.Key
                    choreTreeNode.Nodes.Add(instanceTreeNode)
                Next
            Next
        End Sub

        Public Function GetCounteroffer() As Offer.Counteroffer
            Dim offers As New Dictionary(Of Chore, List(Of Instance))
            For Each cn As TreeNode In InstancesTreeView.Nodes.Cast(Of TreeNode).Where(Function(node) node.Nodes.Cast(Of TreeNode).Any(Function(treeNode) treeNode.Checked))
                Dim instances As New List(Of Instance)
                For Each i In cn.Nodes.Cast(Of TreeNode).Where(Function(result) result.Checked)
                    instances.Add(i.Tag)
                Next
                offers.Add(cn.Tag, instances)
            Next
            'Dim offeredInstances As List(Of Instance) =
            '        (From cn As TreeNode In InstancesTreeView.Nodes
            '        From i In cn.Nodes.Cast (Of TreeNode).Where(Function(result) result.Checked) Select i.Tag).Cast _
            '        (Of Instance)().ToList()
            If offers.Count = 0 Then
                Return Nothing
            Else 
                Return New Offer.Counteroffer(Phone.Profile, offers)
            End If
        End Function

        Private Sub CancelButton_Click(sender As Object, e As EventArgs) Handles CancelButton.Click
            Phone.ChangeView(New BulletinView)
        End Sub

        Private Sub SubmitButton_Click(sender As Object, e As EventArgs) Handles SubmitButton.Click
            'Dim request As New Request.OfferRequest(Phone.Profile, Phone.Household, GetOffer)
            Dim notification As New Notification(Phone.Profile, Phone.Household.Housemates.Where(Function(housemate) housemate IsNot Phone.Profile).ToList, Phone.Profile.Name + " has created a new trade request. Check the 'trades' section.")
            RaiseEvent CreatedCounteroffer(Me, New NotificationEventArgs(notification))
            Offer.Counteroffers.Add(GetCounteroffer)
            Phone.ChangeView(New ViewTradeView(Offer))
        End Sub

        Private Sub InstancesTreeView_AfterCheck(sender As Object, e As TreeViewEventArgs) Handles InstancesTreeView.AfterCheck
            if e.Action <> TreeViewAction.Unknown Then
                For Each node As TreeNode In e.Node.Nodes
                    node.Checked = e.Node.Checked
                Next
            End If
            
            If InstancesTreeView.Nodes.Cast(Of TreeNode).Any(Function(node) node.Checked) Or e.Node.Nodes.Cast(Of TreeNode).Any(Function(node) node.Checked) Then
                SubmitButton.Enabled = True
            Else 
                SubmitButton.Enabled = False
            End If
            
        End Sub
    End Class
End NameSpace