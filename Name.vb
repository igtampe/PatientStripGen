''' <summary>Holds names so that their components are re-organizable </summary>
Public Class Name

    Private Firstname As String
    Private MiddleName As String
    Private MiddleInitial As String

    ''' <summary> Paternal Last Name </summary>
    Protected LastName1 As String

    ''' <summary> Maternal Last Name </summary>
    Protected LastName2 As String

    ''' <summary> Main Constructor </summary>
    ''' <param name="Firstname"></param>
    ''' <param name="MiddleName"></param>
    ''' <param name="Lastname1">Paternal Last Name</param>
    ''' <param name="Lastname2">Maternal Last Name</param>
    Public Sub New(Firstname As String, MiddleName As String, Lastname1 As String, Lastname2 As String)
        Me.Firstname = Firstname
        Me.MiddleName = MiddleName
        If Not String.IsNullOrWhiteSpace(MiddleName) Then MiddleInitial = MiddleName(0) Else MiddleInitial=""
        Me.LastName1 = Lastname1
        Me.LastName2 = Lastname2
    End Sub

    ''' <summary>
    ''' Simplest constructor
    ''' </summary>
    ''' <param name="Firstname"></param>
    ''' <param name="Lastname"></param>
    Public Sub New(Firstname As String, Lastname As String)
        Me.New(Firstname, "", Lastname, "")
    End Sub

    ''' <summary>
    ''' Simpler constructor
    ''' </summary>
    ''' <param name="Firstname"></param>
    ''' <param name="Lastname1">Paternal Last Name</param>
    ''' <param name="Lastname2">Maternal Last Name</param>
    Public Sub New(Firstname As String, Lastname1 As String, Lastname2 As String)
        Me.New(Firstname, "", Lastname1, Lastname2)
    End Sub

    ''' <summary>Gets first name </summary>
    Public Function getFirst() As String
        Return Firstname
    End Function

    ''' <summary>Gets middle name </summary>
    Public Function getMiddle() As String
        Return MiddleName
    End Function

    ''' <summary>Gets middle innitial</summary>
    Public Function getMiddleInitial() As String
        Return MiddleInitial
    End Function

    ''' <summary>Gets Paternal (first) last name</summary>
    Public Function getPaternal() As String
        Return LastName1
    End Function

    ''' <summary>Gets Maternal (Second) last name</summary>
    Public Function getMaternal() As String
        Return LastName2
    End Function

    ''' <summary> Equals function </summary>
    ''' <param name="obj">Something to compare (Hopefully something that's a name)</param>
    ''' <returns>True if it's a name, and if all internal properties match</returns>
    Public Overrides Function Equals(obj As Object) As Boolean
        Dim othername As Name = TryCast(obj, Name)
        If IsNothing(othername) Then Return False
        Return Firstname = othername.Firstname And MiddleName = othername.MiddleName And LastName1 = othername.LastName1 And LastName2 = othername.LastName2
    End Function

    ''' <summary>To String</summary>
    ''' <returns>FirstName Middlename(if any) PaternalLastName MaternalLastName</returns>
    Public Overrides Function ToString() As String
        If String.IsNullOrWhiteSpace(MiddleName) Then
            Return Firstname & " " & LastName1 & " " & LastName2
        Else
            Return Firstname & " " & MiddleName & " " & LastName1 & " " & LastName2
        End If

    End Function


End Class
