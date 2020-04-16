Imports System.IO
Imports Microsoft.Office.Interop.Excel

Public Class MainForm

    '------------------[Some Arraylists we need to setup]------------------

    ''' <summary>All Patients we're dealing with</summary>
    Public AllPatients As ArrayList

    ''' <summary>All PatientDetailForms we have open</summary>
    Public AllWindows As ArrayList

    '------------------[Dealing with the patients and the patient files]------------------

    Private Sub StartTheShow() Handles MyBase.Shown

        'Create the arraylists
        AllPatients = New ArrayList
        AllWindows = New ArrayList

        'Load the file, if it exists
        If File.Exists("MyPatients.PFILE") Then
            'load it
            FileOpen(1, "MyPatients.PFILE", OpenMode.Input)

            'Just a dummy line to indicate this file exists.
            LineInput(1)

            While Not EOF(1)
                'FNAME LNAME LNAME~RECNUM~INSUR~DIAG~ROOM~ACTIVE~DATE`LOCALE`TYPE`NOTES:DATE`LOCALE`TYPE`NOTES:DATE`LOCALE`TYPE`NOTES
                Dim ReadLine() As String = LineInput(1).Split("~") 'Get the line
                If ReadLine.Count > 1 Then 'Make sure it's a line that's actually readable
                    Dim PNAMESplit As String() = ReadLine(0).Split(" ") 'Get the name
                    Dim PNAME As Name
                    Select Case PNAMESplit.Count
                        Case 2
                            'Assume there's only one lastname
                            PNAME = New Name(PNAMESplit(0), PNAMESplit(1))
                        Case 3
                            'assume there's both last names
                            PNAME = New Name(PNAMESplit(0), PNAMESplit(1), PNAMESplit(2))
                        Case 4
                            'assume there's both last names *and* a middle name innitial which I'm not going to store as the actual middle innitial in the name class because
                            'I'd need to account for that litterally everywhere else. Dad said no middle names but then there are middle innitials in his old strips so yeah.
                            PNAME = New Name(PNAMESplit(0) & " " & PNAMESplit(1), PNAMESplit(2), PNAMESplit(3))
                    End Select

                    'Get the other parts
                    Dim RecNum As Integer = ReadLine(1)
                    Dim Insur As String = ReadLine(2)
                    Dim Diag As String = ReadLine(3)
                    Dim Room As String = ReadLine(4)
                    Dim Complete As Boolean = ReadLine(5)

                    'Setup for getting visits
                    Dim AllVisits As String() = ReadLine(6).Split(":")
                    Dim AllVisitsAsVisits As ArrayList = New ArrayList

                    'Get visits
                    For Each WholeVisit As String In AllVisits
                        'god we have to split this many times jesus christo
                        Dim Thisvisit As String() = WholeVisit.Split("`")
                        'OH JESU
                        Dim ThisDate As String() = Thisvisit(0).Split("/")
                        AllVisitsAsVisits.Add(New PatientVisit(New Date(ThisDate(2), ThisDate(0), ThisDate(1)), Thisvisit(1), Thisvisit(2), Thisvisit(3)))
                    Next

                    'Actually create the patient
                    Dim ThePatient As Patient = New Patient(PNAME, RecNum, Insur, Diag, Room, TryCast(AllVisitsAsVisits.Item(0), PatientVisit))

                    'Add the other visits
                    For I = 1 To AllVisitsAsVisits.Count - 1
                        ThePatient.AddVIsit(TryCast(AllVisitsAsVisits.Item(I), PatientVisit))
                    Next

                    'Mark the patient as complete if he is complete
                    If Complete Then ThePatient.MarkComplete()

                    'Add the patient to the list!
                    AllPatients.Add(ThePatient)
                End If
            End While

            'Close the file and populate both listviews
            FileClose(1)
            populateListViews()

        Else
            'No file exists. Give a tiny welcome message!
            MsgBox("Welcome to Patient Strip Generator! I hope this will help you keep track of patients and generate strips for billing" & vbNewLine & vbNewLine & "To start, create your first patient. If you find any bugs, please tell me immediately!", MsgBoxStyle.Information)
        End If

    End Sub

    ''' <summary> Add the specified new patient </summary>
    ''' <returns>True if it was added, false if it was not possible</returns>
    Public Function AddPatient(NuPatient As Patient)
        'Check if we contain it
        If AllPatients.Contains(New Patient(NuPatient.getRecord)) Then
            MsgBox("Cannot add this patient! A patient with the same record number already exists!", MsgBoxStyle.Critical)
            Return False
        End If

        'add it, repopulate the listviews, and lets get the heck out of here.
        AllPatients.Add(NuPatient)
        populateListViews()
        Return True
    End Function

    ''' <summary>Update the specified patient with the current version.</summary>
    ''' <returns>True if it was possible, false if not</returns>
    Public Function UpdatePatient(NuPatient As Patient)
        Try
            'Try to add it
            AllPatients.Item(GetPatientIndex(NuPatient.getRecord)) = NuPatient
            populateListViews()
            Return True
        Catch
            'J u s t     i n      c a s e
            'The only thing I could see happening is that the NuPatient's record might not be in the array, which *should* not happen, but we will do esto just in case.
            MsgBox("Could not update " & NuPatient.getName.ToString, vbCritical)
            Return False
        End Try
    End Function


    ''' <summary>Gets the index of the patient with the specified record on the allpatients arraylist</summary>
    ''' <param name="Record">Record you want to look up</param>
    ''' <returns>index of the patient with the specified record on the allpatients arraylist</returns>
    Private Function GetPatientIndex(Record As Integer)
        Return AllPatients.IndexOf(New Patient(Record))
    End Function

    ''' <summary>Populate all the listviews</summary>
    Private Sub populateListViews()

        'Clear the lists
        ActivePatientsListview.Items.Clear()
        CompletedPatientListview.Items.Clear()

        'Open the file so we can *save it*, and print the first dummy line (Which we can use to save the date)
        FileOpen(1, "MyPatients.PFILE", OpenMode.Output)
        PrintLine(1, "PatientFile Generated " & DateTime.Now.ToString())

        For Each P As Patient In AllPatients
            'Print the patient. Formatting is handled by the Patient Class
            PrintLine(1, P.ToString)

            'Create the listview item with the information of the patient
            Dim PAsListview = New ListViewItem(P.getName.ToString)
            PAsListview.SubItems.Add(P.getRecord)
            PAsListview.SubItems.Add(P.GetRoomNumber)
            PAsListview.SubItems.Add(TryCast(P.getVisits.Item(0), PatientVisit).getDate.ToString("d"))
            PAsListview.SubItems.Add(TryCast(P.getVisits.Item(P.getVisits.Count - 1), PatientVisit).getDate.ToString("d"))

            'Find the floor that this patient is in. In case the room doesn't start with a number, we have this try catch.
            Dim Floornumber As Integer
            Try
                Floornumber = P.GetRoomNumber.ToString().Substring(0, 1)
            Catch ex As Exception
                Floornumber = -1
            End Try

            'Add it to the appropriate listview
            If P.isComplete Then
                CompletedPatientListview.Items.Add(PAsListview)
            Else
                Try
                    PAsListview.Group = ActivePatientsListview.Groups.Item(Floornumber - 1)
                Catch ex As Exception
                    'Nothing really, just put it in the default group.
                End Try
                ActivePatientsListview.Items.Add(PAsListview)
            End If

        Next

        'Close the file since we're done
        FileClose(1)

    End Sub

    '------------------[Button Clicks]------------------

    Private Sub NewPatient() Handles NewPatientToolStripMenuItem.Click
        Dim newPatientForm As PatientDetailsForm = New PatientDetailsForm With {.NewMode = True}
        newPatientForm.Show()
    End Sub

    Private Sub ShowAbout() Handles AboutToolStripMenuItem.Click
        AboutForm.ShowDialog()
    End Sub

    Private Sub DeletePatients() Handles DeleteSelectedPatientsToolStripMenuItem.Click

        'Ask to make sure the user actually wants to do this
        Dim Result As MsgBoxResult = MsgBox("This will delete all checked items in the Completed section. Are you sure you want to do this?", MsgBoxStyle.Question + MsgBoxStyle.YesNo)

        'If yes, delete
        If Result = MsgBoxResult.Yes Then

            For Each Cosita As ListViewItem In CompletedPatientListview.CheckedItems
                'remove it from allpatients. We can use a dummy patient with the same Record, which is the only thing the .Equals function needs
                AllPatients.Remove(New Patient(Cosita.SubItems.Item(1).Text))
            Next

            'Repopulate
            populateListViews()
        End If

    End Sub

    Private Sub DoubleClickActive() Handles ActivePatientsListview.DoubleClick
        Try
            'Create the window
            Dim ExistingPatientDetailsForm As PatientDetailsForm = New PatientDetailsForm With {
            .MyPatient = TryCast(AllPatients.Item(GetPatientIndex(ActivePatientsListview.SelectedItems.Item(0).SubItems.Item(1).Text)), Patient)}

            'Look for another window that potentially may exist. If it does, highlight it, if not, show the new one.
            Dim PotentialOtherWindow As PatientDetailsForm = RegisterWindow(ExistingPatientDetailsForm)
            If Not IsNothing(PotentialOtherWindow) Then PotentialOtherWindow.Activate() Else ExistingPatientDetailsForm.Show()

        Catch ex As Exception
            'In the event that the user double-clicks on an area without an item.
        End Try

    End Sub

    Private Sub DoubleClickComplete() Handles CompletedPatientListview.DoubleClick
        Try
            'Create the window
            Dim ExistingPatientDetailsForm As PatientDetailsForm = New PatientDetailsForm With {
            .MyPatient = TryCast(AllPatients.Item(GetPatientIndex(CompletedPatientListview.SelectedItems.Item(0).SubItems.Item(1).Text)), Patient),
            .CompleteMode = True}

            'Look for another window that potentially may exist. If it does, highlight it, if not, show the new one.
            Dim PotentialOtherWindow As PatientDetailsForm = RegisterWindow(ExistingPatientDetailsForm)
            If Not IsNothing(PotentialOtherWindow) Then PotentialOtherWindow.TopMost = True Else ExistingPatientDetailsForm.Show()

        Catch ex As Exception
            'In the event that the user double-clicks on an area without an item.
        End Try

    End Sub

    '------------------[Dealing with windows]------------------

    ''' <summary>registers a patient details form in the AllWindows arraylist</summary>
    ''' <param name="Window">The PatientDetailsForm you want to register</param>
    ''' <returns>A PatientDetailsForm that is already registered that holds the same patient, if it exists. Otherwise, nothing.</returns>
    Private Function RegisterWindow(Window As PatientDetailsForm) As PatientDetailsForm

        'Make sure the window doesn't already exist
        For Each W As PatientDetailsForm In AllWindows
            'If the window already exists, return that window
            If Window.MyPatient.Equals(W.MyPatient) Then Return W
        Next

        'The Window doesn't exist! Add it to the list, and return nothing.
        AllWindows.Add(Window)
        Return Nothing

    End Function

    ''' <summary>DeRegister the PatientDetailsForm with the specified patient from the AllWindows arraylist</summary>
    ''' <param name="NuPatient">The patient that the window you want to de-register contains.</param>
    Public Sub DeRegisterWindow(NuPatient As Patient)
        For Each W As PatientDetailsForm In AllWindows

            'If we find the patient, remove it, and reutrn
            If NuPatient.Equals(W.MyPatient) Then
                AllWindows.Remove(W)
                Return
            End If
        Next
    End Sub


    '------------------[Dealing with Exporting and generating strips]------------------

    Private Sub TimeToExport() Handles ExportCompletePatientsToolStripMenuItem.Click

        'Now lets make an excel
        Dim ExcelApp As _Application = New Application()
        ExcelApp.Workbooks.Add()
        Dim ExcelBook As _Workbook = ExcelApp.Workbooks(1)
        Dim CurrentWorksheet As _Worksheet = ExcelBook.Sheets(1)

        'Make it visible so the user can see what we're doing :)
        ExcelApp.Visible = True

        'Geta all the patients to export
        Dim PatientsToExport As ArrayList = New ArrayList
        For Each Item As ListViewItem In CompletedPatientListview.CheckedItems
            PatientsToExport.Add(AllPatients.Item(GetPatientIndex(Item.SubItems(1).Text)))
        Next

        'Set some basic stuff up. The user may need to do a few things, but that's ok
        CurrentWorksheet.PageSetup.Orientation = XlPageOrientation.xlLandscape
        CurrentWorksheet.PageSetup.PrintArea = "$A$1:$Q$46"

        'Get us a current row indicator
        Dim Row As Integer = 1

        'For each patient, make a strip, and move us down.
        For Each Guy As Patient In PatientsToExport
            MakeStrip(Guy, Row, CurrentWorksheet)
            Row += 4
        Next

    End Sub

    ''' <summary>Make a patient billing strip, starting on the specified row</summary>
    ''' <param name="Guy">The patient you want to make a strip with</param>
    ''' <param name="Row">Row the strip starts on</param>
    ''' <param name="Sheet">The sheet we're working on</param>
    Public Sub MakeStrip(Guy As Patient, Row As Integer, Sheet As _Worksheet)
        Dim Range As Range

        'Name
        Range = Sheet.Range("A" & Row, "B" & Row)
        Range.Merge()
        Range.Value = Guy.getName.ToString
        Range.Font.Bold = True
        Range.HorizontalAlignment = HorizontalAlignment.Center

        'Rec#
        Sheet.Range("A" & (Row + 1)).Value = "REC#: " & Guy.getRecord

        'ROOM
        Sheet.Range("B" & (Row + 1)).Value = "ROOM: " & Guy.GetRoomNumber

        'Insurance
        Range = Sheet.Range("A" & (Row + 2), "B" & (Row + 2))
        Range.Merge()
        Range.ColumnWidth = 17.14
        Range.Value = "INS: " & Guy.getInsurance

        'Diagnosis
        Range = Sheet.Range("A" & (Row + 3), "B" & (Row + 3))
        Range.Merge()
        Range.Value = "DIAG: " & Guy.getDiagnosis

        'Border of Card
        Range = Sheet.Range("A" & Row, "B" & (Row + 3))
        Range.BorderAround2(XlLineStyle.xlContinuous)

        'Set a few things before we start working on the visits, including a Column Offset integer
        Dim PrevDate As Date = Nothing
        Dim NothingDate As Date = Nothing
        Dim Offset As Integer = 0

        'We have to add a nothing date because a date set to nothing is not nothing, it's January 1st, 1 AD. 
        'VB.NET is weird.

        'Add each visit
        For Each visit As PatientVisit In Guy.getVisits
            'Check to make sure all days are accounted for (even ones without a visit that passed between visits)
            If Not PrevDate.Equals(NothingDate) Then
                'Get the time between the last visit and this visit
                Dim Doot As TimeSpan = visit.getDate.Subtract(PrevDate)
                If Doot.TotalDays > 1 Then
                    'If there's more tha none, add the days without a visit.
                    For X = 1 To Doot.TotalDays - 1
                        MakeEmptyCard(PrevDate.AddDays(X), Offset, Row, Sheet)
                        Offset += 1
                    Next
                End If
            End If

            'Make the visit card
            MakeVisitCard(visit, Offset, Row, Sheet)

            'Update our previous date
            PrevDate = visit.getDate

            'Update our column offset.
            Offset += 1

        Next

    End Sub

    ''' <summary> Make a visitation card at the specified Row with the specified Column Offset from the first visit card (0 is the first card)</summary>
    ''' <param name="Visit">The Visit the card will be made with</param>
    ''' <param name="Offset">Column offset from the first card (The first card is 0)</param>
    ''' <param name="Row">Row we're starting at</param>
    ''' <param name="sheet">Sheet we're working on</param>
    Private Sub MakeVisitCard(Visit As PatientVisit, Offset As Integer, Row As Integer, sheet As _Worksheet)
        Dim Range As Range

        'Date
        Range = sheet.Range("C" & Row)
        Range.Offset(0, Offset).Value = Visit.getDate.Month & "/" & Visit.getDate.Day
        Range.Offset(0, Offset).HorizontalAlignment = XlHAlign.xlHAlignCenter

        'Ward vs ICU
        Range = sheet.Range("C" & Row + 1)
        Range.Offset(0, Offset).Value = Visit.getLocaleAsShortString
        Range.Offset(0, Offset).Font.Bold = True
        Range.Offset(0, Offset).HorizontalAlignment = XlHAlign.xlHAlignCenter

        'Consult vs Follow Up
        Range = sheet.Range("C" & Row + 2)
        Range.Offset(0, Offset).Value = Visit.getVisitTypeAsShortString
        Range.Offset(0, Offset).Font.Bold = True
        Range.Offset(0, Offset).HorizontalAlignment = XlHAlign.xlHAlignCenter

        'Note
        Range = sheet.Range("C" & Row + 3)
        Range.Offset(0, Offset).Value = Visit.getNotes
        Range.Offset(0, Offset).HorizontalAlignment = XlHAlign.xlHAlignCenter

        'Outside Border of Visit
        Range = sheet.Range("C" & Row, "C" & Row + 3)
        Range.Offset(0, Offset).BorderAround2(XlLineStyle.xlContinuous)

    End Sub

    ''' <summary> Make an empty visit card.</summary>
    ''' <param name="D">Date where there wasn't a visit</param>
    ''' <param name="Offset">Column Offset from the first card (The first card is 0)</param>
    ''' <param name="Row">Row we're starting at</param>
    ''' <param name="sheet">Sheet we're working on</param>
    Private Sub MakeEmptyCard(D As Date, Offset As Integer, Row As Integer, sheet As _Worksheet)
        Dim Range As Range

        'Date
        Range = sheet.Range("C" & Row)
        Range.Offset(0, Offset).Value = D.Month & "/" & D.Day
        Range.Offset(0, Offset).HorizontalAlignment = XlHAlign.xlHAlignCenter

        'Ward vs ICU
        Range = sheet.Range("C" & Row + 1)
        Range.Offset(0, Offset).Value = "-"
        Range.Offset(0, Offset).Font.Bold = True
        Range.Offset(0, Offset).HorizontalAlignment = XlHAlign.xlHAlignCenter

        'Outside Border of Visit
        Range = sheet.Range("C" & Row + 0, "C" & Row + 3)
        Range.Offset(0, Offset).BorderAround2(XlLineStyle.xlContinuous)

    End Sub


End Class
