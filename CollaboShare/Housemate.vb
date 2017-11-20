Public Class Housemate
    Public Property Name As String
    Public Property PhoneNumber As String
    Public Property Email As String
    Public Property Photo As Image

    Public Property ChorePreferences As New Dictionary(Of Chore, Integer)

    Public Property ToDoList As New ToDoList

    Public Sub New(name As String, phoneNumber As String, email As String)
        Me.New(name, phoneNumber, email, New Bitmap(40, 60))
    End Sub

    Public Sub New(name As String, phoneNumber As String, email As String, photo As Image)
        Me.Name = name
        Me.PhoneNumber = phoneNumber
        Me.Email = email
        Me.Photo = photo
    End Sub

    Public Overrides Function ToString() As String
        Return Name
    End Function
End Class
