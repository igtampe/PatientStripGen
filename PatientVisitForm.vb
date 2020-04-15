Public Class PatientVisitForm

    Public ReturnVisit As PatientVisit

    Private Sub OKBTN_Click(sender As Object, e As EventArgs) Handles OKBTN.Click
        If Not (VLocale.SelectedIndex = 0 Or VLocale.SelectedIndex = 1) Then
            MsgBox("Please select a visit location", MsgBoxStyle.OkOnly + MsgBoxStyle.Exclamation)
            Return
        End If

        If Not (VType.SelectedIndex = 0 Or VType.SelectedIndex = 1) Then
            MsgBox("Please select a visit type", MsgBoxStyle.OkOnly + MsgBoxStyle.Exclamation)
            Return
        End If

        ReturnVisit = New PatientVisit(DatePicker.Value, VLocale.SelectedIndex, VType.SelectedIndex, NotesTXB.Text)
        Close()
    End Sub

    Private Sub CANCELBTN_Click(sender As Object, e As EventArgs) Handles CANCELBTN.Click
        Close()
    End Sub
End Class