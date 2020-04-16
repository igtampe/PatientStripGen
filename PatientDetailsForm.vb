Public Class PatientDetailsForm

    '------------------[Some variables and flags]------------------

    ''' <summary>The patient this window is holding/displaying</summary>
    Public MyPatient As Patient

    ''' <summary> Specifies if the form should be in NEW mode</summary>
    Public NewMode As Boolean = False

    ''' <summary> Specifies if the form should be in NEW mode</summary>
    Public CompleteMode As Boolean = False

    '------------------[Startup and Visit handling]------------------

    Private Sub TimeToStartTheShow() Handles MyBase.Load
        'o l i

        'Clear a few things
        AdminDateLBL.Text = ""
        VisitsListView.Items.Clear()

        If NewMode Then
            'Set a few things for newmode
            FileToolStripMenuItem.Enabled = False
            Text = "New Patient"

        Else
            'Make sure we can't edit some of the original information for this patient if this patient isn't new
            FirstNameTXB.ReadOnly = True
            PLastNameTXB.ReadOnly = True
            MLastNameTXB.ReadOnly = True
            RecNumberTXB.ReadOnly = True
            Text = MyPatient.getName.ToString & " (" & MyPatient.getRecord & ")"

            'Assume we have a patient specified. Let's go ahead and populate the form.
            PopulateForm()

            If CompleteMode Then
                'Make the rest of this form read-only
                RoomNumberTXB.ReadOnly = True
                InsuranceTXB.ReadOnly = True
                DiagnosisTXB.ReadOnly = True
                FileToolStripMenuItem.Enabled = False

                CANCELBTN.Enabled = False

            End If

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

        'Clear items on the list view
        VisitsListView.Items.Clear()

        'Add each visit to the list view
        For Each Visit As PatientVisit In MyPatient.getVisits

            'Create the list view item with the current Visit's information
            Dim VisitAsListview As ListViewItem = New ListViewItem With {.Text = Visit.getDate.ToString("d")}
            VisitAsListview.SubItems.Add(Visit.getLocaleAsString)
            VisitAsListview.SubItems.Add(Visit.getVisitTypeAsString)
            VisitAsListview.SubItems.Add(Visit.getNotes)

            'a d d     i t
            VisitsListView.Items.Add(VisitAsListview)

        Next

    End Sub

    '------------------[Buttons]------------------

    Private Sub NonCommitClose() Handles CANCELBTN.Click, ExitToolStripMenuItem.Click
        Close()
    End Sub

    Private Sub AddNewVisit() Handles AddNewVisitToolStripMenuItem.Click

        'Just in case someone does CTRL+N
        If NewMode Or CompleteMode Then Return

        'Creates a form to create the visit
        Dim NewVisitForm As PatientVisitForm = New PatientVisitForm
        NewVisitForm.ShowDialog()

        'If there was a visit created, add the return visit.
        If Not IsNothing(NewVisitForm.ReturnVisit) Then
            MyPatient.AddVIsit(NewVisitForm.ReturnVisit)
            PopulateListView()
        End If

    End Sub

    Private Sub CompleteMe() Handles MarkAsCompleteToolStripMenuItem.Click
        MyPatient.MarkComplete()
        NowForTheClosingAct()
    End Sub

    Private Sub AboutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AboutToolStripMenuItem.Click
        AboutForm.ShowDialog()
    End Sub

    Private Sub NowForTheClosingAct() Handles OKBTN.Click

        'If we're complete, do nothing, just close it.
        If CompleteMode Then
            Close()
            Return
        End If

        'Check if the form is valid
        If Not isValid() Then
            Return
        End If

        If NewMode Then
            'Create the first visit
            Dim NewVisitForm As PatientVisitForm = New PatientVisitForm
            NewVisitForm.ShowDialog()

            'Make sure there is actualy a new visit
            If IsNothing(NewVisitForm.ReturnVisit) Then
                MsgBox("Cannot create a patient without a first visit!", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly)
                Return
            End If

            'Make the patient
            MyPatient = New Patient(New Name(FirstNameTXB.Text, PLastNameTXB.Text, MLastNameTXB.Text), RecNumberTXB.Text, InsuranceTXB.Text, DiagnosisTXB.Text, RoomNumberTXB.Text, NewVisitForm.ReturnVisit)

            'If we could add it, then we can close
            If MainForm.AddPatient(MyPatient) Then Close()

        Else

            'These are the only things you can change on the form
            MyPatient.SetRoomNumber(RoomNumberTXB.Text)
            MyPatient.SetDiagnosis(DiagnosisTXB.Text)
            MyPatient.SetInsurance(InsuranceTXB.Text)

            'If we were able to update the patient, we can close the form
            If MainForm.UpdatePatient(MyPatient) Then Close()
        End If

    End Sub

    '------------------[Other Operations]------------------

    Private Sub theEndCredits() Handles Me.Closing
        MainForm.DeRegisterWindow(MyPatient)
    End Sub

    ''' <summary>Checks if the form is validly filled</summary>
    ''' <returns>true if yes, false if no</returns>
    Private Function isValid() As Boolean

        If String.IsNullOrWhiteSpace(FirstNameTXB.Text) Then
            MsgBox("I need a first name!", vbExclamation)
            Return False
        End If


        If String.IsNullOrWhiteSpace(PLastNameTXB.Text) Then
            MsgBox("I need at least one last name", vbExclamation)
            Return False
        End If

        If String.IsNullOrWhiteSpace(RecNumberTXB.Text) Then
            MsgBox("Record number not specified!", vbExclamation)
            Return False
        End If

        Try
            Dim recnumber As Integer = CInt(RecNumberTXB.Text)
        Catch ex As Exception
            MsgBox("Record number could not be converted to a number. It needs to be a number!", vbExclamation)
            Return False
        End Try


        If String.IsNullOrWhiteSpace(InsuranceTXB.Text) Then
            MsgBox("Insurance not specfied!", vbExclamation)
            Return False
        End If

        If String.IsNullOrWhiteSpace(DiagnosisTXB.Text) Then
            MsgBox("Diagnosis not specfied! (If anything put N/A)", vbExclamation)
            Return False
        End If

        If String.IsNullOrWhiteSpace(RoomNumberTXB.Text) Then
            MsgBox("Room Number not specfied!", vbExclamation)
            Return False
        End If

        Return True

    End Function

End Class