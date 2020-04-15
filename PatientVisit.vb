Public Class PatientVisit

    Private DateOfVisit As Date
    Private Locale As VisitLocale
    Private Type As VisitType
    Private Notes As String

    Public Enum VisitLocale As Integer
        Ward = 0
        ICU = 1
    End Enum

    Public Enum VisitType As Integer
        Consult = 0
        FollowUp = 1
    End Enum

    Public Sub New(DOV As Date, Locale As VisitLocale, Type As VisitType, Notes As String)
        Me.DateOfVisit = DOV
        Me.Locale = Locale
        Me.Type = Type
        Me.Notes = Notes
    End Sub

    'I'm like 90% sure this should be set in stone, and shouldn't be editable
    'At least, for accountability reasons

    Public Function getDate() As Date
        Return DateOfVisit
    End Function

    Public Function getLocale() As VisitLocale
        Return Locale
    End Function

    Public Function getLocaleAsString() As String
        Select Case Locale
            Case VisitLocale.Ward
                Return "WARD"
            Case VisitLocale.ICU
                Return "ICU"
            Case Else
                Return "?"
        End Select
    End Function

    Public Function getLocaleAsShortString() As String
        Select Case Locale
            Case VisitLocale.Ward
                Return "W"
            Case VisitLocale.ICU
                Return "ICU"
            Case Else
                Return "?"
        End Select
    End Function


    Public Function getVisitType() As VisitType
        Return Type
    End Function

    Public Function getVisitTypeAsString() As String
        Select Case Type
            Case VisitType.Consult
                Return "CONSULT"
            Case VisitType.FollowUp
                Return "FOLLOW-UP"
            Case Else
                Return "?"
        End Select
    End Function

    Public Function getVisitTypeAsShortString() As String
        Return getVisitTypeAsString(0)
    End Function

    Public Function getNotes() As String
        Return Notes
    End Function

    Public Overrides Function ToString() As String
        '5/15/2020`1`1`Dead
        Dim Loc As Integer = Locale
        Dim Typ As Integer = Type
        Return String.Join("`", DateOfVisit.ToString("d"), Loc, Typ, Notes)
    End Function


End Class
