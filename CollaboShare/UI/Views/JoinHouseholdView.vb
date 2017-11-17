﻿Imports System.ComponentModel

Namespace UI.Views

    Public Class JoinHouseholdView
        Public Event RequestingHousehold As EventHandler
        Public Event CreatingHousehold As EventHandler

        Private _households As New List(Of Household)

        Public ReadOnly Property Phone() As PhoneForm
            Get
                Return FindForm()
            End Get
        End Property

        Protected Overrides Sub OnLoad(e As EventArgs)
            MyBase.OnLoad(e)
            Me.HouseholdsFlowLayoutPanel.Controls.Clear()
            For Each household As Household In PhoneForm.Households
                AddNewHouseholdButton(household)
            Next
        End Sub


        Public Sub AddNewHouseholdButton(household As Household)
            Dim householdButton = New Button With {
                    .Font = New Font("Microsoft Sans Serif", 14.25!, FontStyle.Regular, GraphicsUnit.Point, CType(0, Byte)),
                    .Location = New Point(4, 70),
                    .Margin = New Padding(4, 5, 4, 5),
                    .Size = New Size(247, 36),
                    .Text = household.Name,
                    .TextAlign = ContentAlignment.MiddleLeft
                    }
            AddHandler householdButton.Click, AddressOf HouseholdButton_Click
            HouseholdsFlowLayoutPanel.Controls.Add(householdButton)
        End Sub


        Private Sub HouseholdButton_Click(sender As Object, e As EventArgs) Handles Household3Button.Click, Household2Button.Click, Household1Button.Click
            'TODO: Show confirmation dialog ("Request to join household? Yes/No?")
            Dim requestedHousehold = PhoneForm.Households.ElementAt(HouseholdsFlowLayoutPanel.Controls.IndexOf(sender))
            Dim request As Request = New Request.JoinHouseholdRequest(Phone.Profile, requestedHousehold)
            RaiseEvent RequestingHousehold(sender, New RequestEventArgs(request))
        End Sub

        Private Sub NewHouseholdButton_Click(sender As Object, e As EventArgs) Handles NewHouseholdButton.Click
            Phone.ChangeView(New CreateHouseholdView)
        End Sub
    End Class
End NameSpace