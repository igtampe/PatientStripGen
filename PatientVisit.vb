Public Class PatientVisit

    Protected DateOfVisit As Date
    Protected Locale As VisitLocale
    Protected Type As VisitType
    Protected Notes As String

    Public Enum VisitLocale
        Ward
        ICU
    End Enum

    Public Enum VisitType
        Consult
        FollowUp
    End Enum

    Public Sub New(DOV As Date, Locale As VisitLocale, Type As VisitType, Notes As String)
        Me.DateOfVisit = DOV
        Me.Locale = Locale
        Me.Type = Type
        Me.Notes = Notes
    End Sub

    'I'm like 90% sure this should be set in stone, and shouldn't be editable
    'At least, for accountability reasons

End Class
