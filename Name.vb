''' <summary>Holds names so that their components are re-organizable </summary>
Public Class Name

    Protected Firstname As String
    Protected MiddleName As String
    Protected MiddleInitial As String

    ''' <summary> Paternal Last Name </summary>
    Protected LastName1 As String

    ''' <summary> Maternal Last Name </summary>
    Protected LastName2 As String

    Public Sub New(Firstname As String, MiddleName As String, Lastname1 As String, Lastname2 As String)
        Me.Firstname = Firstname
        Me.MiddleName = MiddleName
        If Not String.IsNullOrWhiteSpace(MiddleName) Then MiddleInitial = MiddleName(0) Else MiddleInitial=""
        Me.LastName1 = Lastname1
        Me.LastName2 = Lastname2
    End Sub

    Public Sub New(Firstname As String, Lastname As String)
        Me.New(Firstname, "", Lastname, "")
    End Sub

    Public Sub New(Firstname As String, Lastname1 As String, Lastname2 As String)
        Me.New(Firstname, "", Lastname1, Lastname2)
    End Sub

    Public Overrides Function Equals(obj As Object) As Boolean
        Dim othername As Name = TryCast(obj, Name)
        If IsNothing(othername) Then Return False
        Return Firstname = othername.Firstname And MiddleName = othername.MiddleName And LastName1 = othername.LastName1 And LastName2 = othername.LastName2
    End Function

    Public Overrides Function ToString() As String
        If String.IsNullOrWhiteSpace(MiddleName) Then
            Return Firstname & " " & LastName1 & " " & LastName2
        Else
            Return Firstname & " " & MiddleName & " " & LastName1 & " " & LastName2
        End If

    End Function


End Class
