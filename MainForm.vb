﻿Imports System.IO

Public Class MainForm

    Public AllPatients As ArrayList

    Private Sub StartTheShow() Handles MyBase.Shown

        'Create the arraylist
        AllPatients = New ArrayList

        'Load the file

        If File.Exists("MyPatients.PFILE") Then
            'load it
            FileOpen(1, "MyPatients.PFILE", OpenMode.Input)

            'Just a dummy line to indicate this file exists.
            LineInput(1)

            While Not EOF(1)
                Dim ReadLine() As String = LineInput(1).Split("~")
                If ReadLine.Count > 1 Then
                    Dim PNAMESplit As String() = ReadLine(0).Split(" ")
                    Dim PNAME As Name
                    If String.IsNullOrWhiteSpace(PNAMESplit(2)) Then
                        'Assume there's only one lastname
                        PNAME = New Name(PNAMESplit(0), PNAMESplit(1))
                    Else
                        PNAME = New Name(PNAMESplit(0), PNAMESplit(1), PNAMESplit(2))
                        'assume there's both last names
                    End If

                    Dim RecNum As Integer = ReadLine(1)
                    Dim Insur As String = ReadLine(2)
                    Dim Diag As String = ReadLine(3)
                    Dim Room As Integer = ReadLine(4)
                    Dim Complete As Boolean = ReadLine(5)

                    Dim AllVisits As String() = ReadLine(6).Split(":")
                    Dim AllVisitsAsVisits As ArrayList = New ArrayList

                    For Each WholeVisit As String In AllVisits
                        'god we have to split this many times jesus christo
                        Dim Thisvisit As String() = WholeVisit.Split("`")
                        'OH JESU
                        Dim ThisDate As String() = Thisvisit(0).Split("/")
                        AllVisitsAsVisits.Add(New PatientVisit(New Date(ThisDate(2), ThisDate(0), ThisDate(1)), Thisvisit(1), Thisvisit(2), Thisvisit(3)))
                    Next

                    'Oh jesu this happens *every time for every line*

                    Dim ThePatient As Patient = New Patient(PNAME, RecNum, Insur, Diag, Room, TryCast(AllVisitsAsVisits.Item(0), PatientVisit))

                    'Add the other visits
                    For I = 1 To AllVisitsAsVisits.Count - 1
                        ThePatient.AddVIsit(TryCast(AllVisitsAsVisits.Item(I), PatientVisit))
                    Next

                    'Mark the patient as complete if he is complete
                    If Complete Then ThePatient.MarkComplete()

                    'Add the patient to the list!
                    AllPatients.Add(ThePatient)

                    'Basically
                    'FNAME LNAME LNAME~RECNUM~INSUR~DIAG~ROOM~ACTIVE~DATE`LOCALE`TYPE`NOTES:DATE`LOCALE`TYPE`NOTES:DATE`LOCALE`TYPE`NOTES
                    'Juan Del Pueblo~1101~MCSLife~Death~201~0~5/10/2020`1`1`Not dead:5/15/2020`1`1`Dead

                    'Nice

                End If
            End While

            FileClose(1)
            populateListViews()

        Else
            'No file exists
            MsgBox("Welcome to Patient Strip Generator! I hope this will help you keep track of patients and generate strips for billing" & vbNewLine & vbNewLine & "To start, create your first patient. If you find any bugs, please tell me immediately!", MsgBoxStyle.Information)
        End If

    End Sub

    Private Sub NewPatientToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NewPatientToolStripMenuItem.Click

        Dim newPatientForm As PatientDetailsForm = New PatientDetailsForm With {.NewMode = True}
        newPatientForm.ShowDialog()
        If newPatientForm.Commit Then
            AllPatients.Add(newPatientForm.MyPatient)
            populateListViews()
        End If

    End Sub

    Private Sub populateListViews()

        ActivePatientsListview.Items.Clear()
        CompletedPatientListview.Items.Clear()

        FileOpen(1, "MyPatients.PFILE", OpenMode.Output)

        PrintLine(1, "PatientFile Generated " & DateTime.Now.ToString())

        For Each P As Patient In AllPatients
            PrintLine(1, P.ToString)

            Dim PAsListview = New ListViewItem(P.getName.ToString)
            PAsListview.SubItems.Add(P.getRecord)
            PAsListview.SubItems.Add(P.GetRoomNumber)
            PAsListview.SubItems.Add(TryCast(P.getVisits.Item(0), PatientVisit).getDate.ToString("d"))
            PAsListview.SubItems.Add(TryCast(P.getVisits.Item(P.getVisits.Count - 1), PatientVisit).getDate.ToString("d"))

            If P.isComplete Then
                CompletedPatientListview.Items.Add(PAsListview)
            Else
                ActivePatientsListview.Items.Add(PAsListview)
            End If

        Next

        FileClose(1)

    End Sub

    Private Sub AboutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AboutToolStripMenuItem.Click
        AboutForm.ShowDialog()
    End Sub

    Private Sub DeleteSelectedPatientsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DeleteSelectedPatientsToolStripMenuItem.Click
        'Also no
    End Sub

    Private Sub ExportCompletePatientsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExportCompletePatientsToolStripMenuItem.Click
        'We're not quite there yet!
        MsgBox("We're not quite there yet!", MsgBoxStyle.Information)

        'We need to export them to an excel file, and then we have to format it

        'Also I don't know if we should delete the items automatically or not.
        'Perhaps we can select items to delete.

    End Sub

    Private Sub ActivePatientsListview_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ActivePatientsListview.DoubleClick
        Dim ExistingPatientDetailsForm As PatientDetailsForm = New PatientDetailsForm With {
            .MyPatient = TryCast(AllPatients.Item(GetPatientIndex(ActivePatientsListview.SelectedItems.Item(0).SubItems.Item(1).Text)), Patient)
        }

        ExistingPatientDetailsForm.ShowDialog()

        If ExistingPatientDetailsForm.Commit Then
            AllPatients.Item(GetPatientIndex(ExistingPatientDetailsForm.MyPatient.getRecord)) = ExistingPatientDetailsForm.MyPatient
            populateListViews()
        End If


    End Sub

    Private Function GetPatientIndex(Record As Integer)
        Return AllPatients.IndexOf(New Patient(Record))
    End Function

End Class
