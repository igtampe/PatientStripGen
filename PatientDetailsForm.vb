Public Class PatientDetailsForm

    Public MyPatient As Patient

    ''' <summary> Specifies if the form should be in NEW mode</summary>
    Public NewMode As Boolean = False

    ''' <summary> Specifies whether or not to commit changes made</summary>
    Public Commit As Boolean = False

    ''' <summary> Specifies whether or not to mark the current patient as complete </summary>
    Public MarkComplete As Boolean = False


    Private Sub TimeToStartTheShow() Handles MyBase.Load
        'o l i

        AdminDateLBL.Text = ""
        VisitsListView.Items.Clear()

        If NewMode Then
            'Set a few things for newmode
            FileToolStripMenuItem.Enabled = False
            Me.Text = "New Patient"

        Else
            'Make sure we can't edit some of the original information for this patient if this patient isn't new
            FirstNameTXB.ReadOnly = True
            PLastNameTXB.ReadOnly = True
            MLastNameTXB.ReadOnly = True
            RecNumberTXB.ReadOnly = True
            Me.Text = MyPatient.getName.ToString & " (" & MyPatient.getRecord & ")"

            'Assume we have a patient specified. Let's go ahead and populate the form.
            PopulateForm()

        End If
    End Sub

    ''' <summary> Populates the form </summary>
    Private Sub PopulateForm()
        FirstNameTXB.Text = MyPatient.getName.getFirst
        PLastNameTXB.Text = MyPatient.getName.getPaternal
        MLastNameTXB.Text = MyPatient.getName.getMaternal
        RecNumberTXB.Text = MyPatient.getRecord
        RoomNumberTXB.Text = MyPatient.GetRoomNumber
        InsuranceTXB.Text = MyPatient.getInsurance
        DiagnosisTXB.Text = MyPatient.getDiagnosis
        AdminDateLBL.Text = TryCast(MyPatient.getVisits.Item(0), PatientVisit).getDate.ToString("D")

        PopulateListView()
    End Sub

    ''' <summary> Populates the list view with the specified arraylist of visits</summary>
    Private Sub PopulateListView()

        VisitsListView.Items.Clear()


        For Each Visit As PatientVisit In MyPatient.getVisits

            Dim VisitAsListview As ListViewItem = New ListViewItem With {.Text = Visit.getDate.ToString("d")}
            VisitAsListview.SubItems.Add(Visit.getLocaleAsString)
            VisitAsListview.SubItems.Add(Visit.getVisitTypeAsString)
            VisitAsListview.SubItems.Add(Visit.getNotes)

            VisitsListView.Items.Add(VisitAsListview)

        Next

    End Sub

    Private Sub CANCELBTN_Click(sender As Object, e As EventArgs) Handles CANCELBTN.Click

        'just in case
        Commit = False

        Close()
    End Sub

    Private Sub AddNewVisitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AddNewVisitToolStripMenuItem.Click

        'Creates a form to create the visit
        Dim NewVisitForm As PatientVisitForm = New PatientVisitForm
        NewVisitForm.ShowDialog()

        'If there was a visit created, add the return visit.
        If Not IsNothing(NewVisitForm.ReturnVisit) Then
            MyPatient.AddVIsit(NewVisitForm.ReturnVisit)
            PopulateListView()
        End If

    End Sub

    Private Sub MarkAsCompleteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MarkAsCompleteToolStripMenuItem.Click
        MarkComplete = True
        NowForTheClosingAct()
    End Sub

    Private Sub NowForTheClosingAct() Handles OKBTN.Click

        Dim RecordNum As Integer
        Dim RoomNum As Integer

        Try
            RecordNum = CInt(RecNumberTXB.Text)
            RoomNum = CInt(RoomNumberTXB.Text)
        Catch ex As Exception
            Debug.WriteLine(ex.Message & vbNewLine & vbNewLine & ex.StackTrace)
            MsgBox("Unable to convert Record Number or Room Number to integer. Perhaps there are non-number characters there?", MsgBoxStyle.OkOnly + MsgBoxStyle.Critical)
        End Try

        If NewMode Then

            'Create the first visit
            'Creates a form to create the visit
            Dim NewVisitForm As PatientVisitForm = New PatientVisitForm
            NewVisitForm.ShowDialog()

            If IsNothing(NewVisitForm.ReturnVisit) Then
                MsgBox("Cannot create a patient without a first visit!", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly)
                Return
            End If

            MyPatient = New Patient(New Name(FirstNameTXB.Text, PLastNameTXB.Text, MLastNameTXB.Text), RecordNum, InsuranceTXB.Text, DiagnosisTXB.Text, RoomNum, NewVisitForm.ReturnVisit)
            Commit = True
            Close()

        Else

            'These are the only things you can change on the form
            MyPatient.SetRoomNumber(RoomNum)
            MyPatient.SetDiagnosis(DiagnosisTXB.Text)
            MyPatient.SetInsurance(InsuranceTXB.Text)

            Commit = True
            If MarkComplete Then MyPatient.MarkComplete()
            Close()

        End If

    End Sub

    Private Sub AboutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AboutToolStripMenuItem.Click
        AboutForm.ShowDialog()
    End Sub
End Class