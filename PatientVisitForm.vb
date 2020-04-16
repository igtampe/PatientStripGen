Public Class PatientVisitForm

    Public ReturnVisit As PatientVisit

    Private Sub SetIcon() Handles Me.Load
        Icon = My.Resources.JustPSG
    End Sub

    Private Sub CommittalClose() Handles OKBTN.Click

        'Some basic validation
        If Not (VLocale.SelectedIndex = 0 Or VLocale.SelectedIndex = 1) Then
            MsgBox("Please select a visit location", MsgBoxStyle.OkOnly + MsgBoxStyle.Exclamation)
            Return
        End If

        If Not (VType.SelectedIndex = 0 Or VType.SelectedIndex = 1) Then
            MsgBox("Please select a visit type", MsgBoxStyle.OkOnly + MsgBoxStyle.Exclamation)
            Return
        End If

        'Create the return visit
        ReturnVisit = New PatientVisit(DatePicker.Value, VLocale.SelectedIndex, VType.SelectedIndex, NotesTXB.Text)
        Close()
    End Sub

    Private Sub NonCommittalClose() Handles CANCELBTN.Click
        Close()
    End Sub
End Class