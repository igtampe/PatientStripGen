Public Class Patient

    Private PatientName As Name
    Private PatientRecord As Integer
    Private PatientInsurance As String
    Private Diagnosis As String
    Private RoomNumber As String
    Private Complete As Boolean

    Private AllVisits As ArrayList

    ''' <summary>
    ''' This is purely to lookup other records.
    ''' </summary>
    ''' <param name="Record"></param>
    Public Sub New(Record As Integer)
        PatientRecord = Record
    End Sub

    Public Sub New(PName As Name, PRecord As Integer, PInsurance As String, PDiagnosis As String, PRoomNumber As String, FirstVisit As PatientVisit)
        PatientName = PName
        PatientRecord = PRecord
        PatientInsurance = PInsurance
        Diagnosis = PDiagnosis
        RoomNumber = PRoomNumber
        AllVisits = New ArrayList From {FirstVisit}
        Complete = False
    End Sub

    Public Function getName() As Name
        Return PatientName
    End Function

    Public Function getRecord() As Integer
        Return PatientRecord
    End Function

    Public Function getInsurance() As String
        Return PatientInsurance
    End Function

    Public Function getDiagnosis() As String
        Return Diagnosis
    End Function

    Public Sub SetDiagnosis(NewDiagnosis As String)
        Diagnosis = NewDiagnosis
    End Sub

    Public Function GetRoomNumber() As String
        Return RoomNumber
    End Function

    Public Sub SetRoomNumber(RNumber As String)
        RoomNumber = RNumber
    End Sub

    Public Function getVisits() As ArrayList
        Return AllVisits
    End Function

    Public Sub AddVIsit(Visit As PatientVisit)
        AllVisits.Add(Visit)
    End Sub

    Public Sub SetInsurance(NewInsurance As String)
        PatientInsurance = NewInsurance
    End Sub

    Public Sub MarkComplete()
        Complete = True
    End Sub

    Public Function isComplete() As Boolean
        Return Complete
    End Function

    Public Overrides Function Equals(obj As Object) As Boolean
        Dim OtherPatient As Patient = TryCast(obj, Patient)
        If IsNothing(OtherPatient) Then Return False

        'This should be enough
        Return PatientRecord = OtherPatient.PatientRecord
    End Function

    Public Overrides Function ToString() As String
        'FNAME LNAME LNAME~RECNUM~INSUR~DIAG~ROOM~COMPLETE~DATE`LOCALE`TYPE`NOTES:DATE`LOCALE`TYPE`NOTES:DATE`LOCALE`TYPE`NOTES
        'Juan Del Pueblo~1101~MCSLife~Death~201~0~5/10/2020`1`1`Not dead:5/15/2020`1`1`Dead
        Return String.Join("~", PatientName.ToString, PatientRecord, PatientInsurance, Diagnosis, RoomNumber, Complete, String.Join(":", AllVisits.ToArray))
    End Function

End Class
