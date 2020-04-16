Public Class PatientVisit

    '------------------[Variables]------------------

    Private ReadOnly DateOfVisit As Date
    Private ReadOnly Locale As VisitLocale
    Private ReadOnly Type As VisitType
    Private ReadOnly Notes As String

    Public Enum VisitLocale As Integer
        Ward = 0
        ICU = 1
    End Enum

    Public Enum VisitType As Integer
        Consult = 0
        FollowUp = 1
    End Enum

    '------------------[Constructor]------------------

    Public Sub New(DOV As Date, Locale As VisitLocale, Type As VisitType, Notes As String)
        Me.DateOfVisit = DOV
        Me.Locale = Locale
        Me.Type = Type
        Me.Notes = Notes
    End Sub

    'I'm like 90% sure this should be set in stone, and shouldn't be editable
    'At least, for accountability reasons

    '------------------[Getters]------------------

    Public Function GetDate() As Date
        Return DateOfVisit
    End Function

    Public Function GetLocale() As VisitLocale
        Return Locale
    End Function

    ''' <summary>
    ''' Gets the locale as a string
    ''' </summary>
    ''' <returns>WARD or ICU (Or ? just in case the locale isn't set)</returns>
    Public Function GetLocaleAsString() As String
        Select Case Locale
            Case VisitLocale.Ward
                Return "WARD"
            Case VisitLocale.ICU
                Return "ICU"
            Case Else
                Return "?"
        End Select
    End Function

    ''' <summary>
    ''' Gets locale as Short String
    ''' </summary>
    ''' <returns>W or ICU (or ? just in case the locale isn't set)</returns>
    Public Function GetLocaleAsShortString() As String
        Select Case Locale
            Case VisitLocale.Ward
                Return "W"
            Case VisitLocale.ICU
                Return "ICU"
            Case Else
                Return "?"
        End Select
    End Function

    Public Function GetVisitType() As VisitType
        Return Type
    End Function

    ''' <summary>
    ''' Gets visit type as string
    ''' </summary>
    ''' <returns>CONSULT or FOLLOW-UP (or ? in case type isn't set)</returns>
    Public Function GetVisitTypeAsString() As String
        Select Case Type
            Case VisitType.Consult
                Return "CONSULT"
            Case VisitType.FollowUp
                Return "FOLLOW-UP"
            Case Else
                Return "?"
        End Select
    End Function

    ''' <summary>
    ''' Gets visit type as short string
    ''' </summary>
    ''' <returns>C or F (or ? in case type isn't set)</returns>
    Public Function GetVisitTypeAsShortString() As String
        Return GetVisitTypeAsString(0)
    End Function

    Public Function GetNotes() As String
        Return Notes
    End Function

    '------------------[Object Overrides]------------------

    ''' <summary>
    ''' Returns a string representing this visit for saving
    ''' </summary>
    ''' <returns>MM/DD/YYYY`LOCALE(as int)`TYPE(as int)`Notes</returns>
    Public Overrides Function ToString() As String
        '5/15/2020`1`1`Dead
        Dim Loc As Integer = Locale
        Dim Typ As Integer = Type
        Return String.Join("`", DateOfVisit.ToString("d"), Loc, Typ, Notes)
    End Function


End Class
