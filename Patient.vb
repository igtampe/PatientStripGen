Public Class Patient

    Protected PatientName As Name
    Protected PatientRecord As Integer
    Protected PatientInsurance As String
    Protected Diagnosis As String
    Protected RoomNumber As Integer

    Protected AllVisits As ArrayList

    Public Sub New(PName As Name, PRecord As Integer, PInsurance As String, PDiagnosis As String, PRoomNumber As Integer, FirstVisit As PatientVisit)
        PatientName = PName
        PatientRecord = PRecord
        PatientInsurance = PInsurance
        Diagnosis = PDiagnosis
        RoomNumber = PRoomNumber
        AllVisits = New ArrayList From {FirstVisit}
    End Sub

    Public Sub AddVIsit(Visit As PatientVisit)
        AllVisits.Add(Visit)
    End Sub

    Public Sub SetRoomNumber(RNumber As Integer)
        RoomNumber = RNumber
    End Sub

    Public Sub SetDiagnosis(NewDiagnosis As String)
        Diagnosis = NewDiagnosis
    End Sub

    Public Sub SetInsurance(NewInsurance As String)
        PatientInsurance = NewInsurance
    End Sub

    Public Overrides Function Equals(obj As Object) As Boolean
        Dim OtherPatient As Patient = TryCast(obj, Patient)
        If IsNothing(OtherPatient) Then Return False

        'This should be enough
        Return PatientRecord = OtherPatient.PatientRecord
    End Function

End Class
