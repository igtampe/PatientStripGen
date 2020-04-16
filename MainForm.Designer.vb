<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MainForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim ListViewGroup1 As System.Windows.Forms.ListViewGroup = New System.Windows.Forms.ListViewGroup("1st Floor", System.Windows.Forms.HorizontalAlignment.Left)
        Dim ListViewGroup2 As System.Windows.Forms.ListViewGroup = New System.Windows.Forms.ListViewGroup("2nd Floor", System.Windows.Forms.HorizontalAlignment.Left)
        Dim ListViewGroup3 As System.Windows.Forms.ListViewGroup = New System.Windows.Forms.ListViewGroup("3rd Floor", System.Windows.Forms.HorizontalAlignment.Left)
        Dim ListViewGroup4 As System.Windows.Forms.ListViewGroup = New System.Windows.Forms.ListViewGroup("4th Floor", System.Windows.Forms.HorizontalAlignment.Left)
        Dim ListViewGroup5 As System.Windows.Forms.ListViewGroup = New System.Windows.Forms.ListViewGroup("5th Floor", System.Windows.Forms.HorizontalAlignment.Left)
        Dim ListViewGroup6 As System.Windows.Forms.ListViewGroup = New System.Windows.Forms.ListViewGroup("6th Floor", System.Windows.Forms.HorizontalAlignment.Left)
        Dim ListViewGroup7 As System.Windows.Forms.ListViewGroup = New System.Windows.Forms.ListViewGroup("7th Floor", System.Windows.Forms.HorizontalAlignment.Left)
        Dim ListViewItem1 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem(New String() {"Juan Del Pueblo", "11020", "602", "5/15/2020", "5/20/2020"}, -1)
        Dim ListViewItem2 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem(New String() {"Juan Del Pueblo", "11020", "602", "5/15/2020", "5/20/2020"}, -1)
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.ActiveTableLayout = New System.Windows.Forms.TableLayoutPanel()
        Me.ActivePatientsListview = New System.Windows.Forms.ListView()
        Me.LName = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Record = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Room = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.DateAdmin = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.DateLastVisit = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.CompletedPatientListview = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader4 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader5 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NewPatientToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExportCompletePatientsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DeleteSelectedPatientsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.ActiveTableLayout.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.TableLayoutPanel2.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControl1.Location = New System.Drawing.Point(0, 24)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(579, 624)
        Me.TabControl1.TabIndex = 0
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.ActiveTableLayout)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(571, 598)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Active Patients"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'ActiveTableLayout
        '
        Me.ActiveTableLayout.ColumnCount = 1
        Me.ActiveTableLayout.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.ActiveTableLayout.Controls.Add(Me.ActivePatientsListview, 0, 0)
        Me.ActiveTableLayout.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ActiveTableLayout.Location = New System.Drawing.Point(3, 3)
        Me.ActiveTableLayout.Name = "ActiveTableLayout"
        Me.ActiveTableLayout.RowCount = 1
        Me.ActiveTableLayout.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 85.53259!))
        Me.ActiveTableLayout.Size = New System.Drawing.Size(565, 592)
        Me.ActiveTableLayout.TabIndex = 2
        '
        'ActivePatientsListview
        '
        Me.ActivePatientsListview.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.LName, Me.Record, Me.Room, Me.DateAdmin, Me.DateLastVisit})
        Me.ActivePatientsListview.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ActivePatientsListview.ForeColor = System.Drawing.SystemColors.WindowText
        Me.ActivePatientsListview.FullRowSelect = True
        ListViewGroup1.Header = "1st Floor"
        ListViewGroup1.Name = "F1"
        ListViewGroup2.Header = "2nd Floor"
        ListViewGroup2.Name = "F2"
        ListViewGroup3.Header = "3rd Floor"
        ListViewGroup3.Name = "F3"
        ListViewGroup4.Header = "4th Floor"
        ListViewGroup4.Name = "F4"
        ListViewGroup5.Header = "5th Floor"
        ListViewGroup5.Name = "F5"
        ListViewGroup6.Header = "6th Floor"
        ListViewGroup6.Name = "F6"
        ListViewGroup7.Header = "7th Floor"
        ListViewGroup7.Name = "F7"
        Me.ActivePatientsListview.Groups.AddRange(New System.Windows.Forms.ListViewGroup() {ListViewGroup1, ListViewGroup2, ListViewGroup3, ListViewGroup4, ListViewGroup5, ListViewGroup6, ListViewGroup7})
        Me.ActivePatientsListview.HideSelection = False
        ListViewItem1.Group = ListViewGroup6
        ListViewItem1.StateImageIndex = 0
        Me.ActivePatientsListview.Items.AddRange(New System.Windows.Forms.ListViewItem() {ListViewItem1})
        Me.ActivePatientsListview.Location = New System.Drawing.Point(3, 3)
        Me.ActivePatientsListview.Name = "ActivePatientsListview"
        Me.ActivePatientsListview.Size = New System.Drawing.Size(559, 586)
        Me.ActivePatientsListview.TabIndex = 2
        Me.ActivePatientsListview.UseCompatibleStateImageBehavior = False
        Me.ActivePatientsListview.View = System.Windows.Forms.View.Details
        '
        'LName
        '
        Me.LName.Text = "Name"
        Me.LName.Width = 180
        '
        'Record
        '
        Me.Record.Text = "Record #"
        Me.Record.Width = 58
        '
        'Room
        '
        Me.Room.Text = "Room #"
        '
        'DateAdmin
        '
        Me.DateAdmin.Text = "Date of Admission"
        Me.DateAdmin.Width = 103
        '
        'DateLastVisit
        '
        Me.DateLastVisit.Text = "Last Visit"
        Me.DateLastVisit.Width = 67
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.TableLayoutPanel2)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(571, 598)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Completed Patients"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.ColumnCount = 1
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel2.Controls.Add(Me.CompletedPatientListview, 0, 0)
        Me.TableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(3, 3)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 1
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 96.37795!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(565, 592)
        Me.TableLayoutPanel2.TabIndex = 2
        '
        'CompletedPatientListview
        '
        Me.CompletedPatientListview.CheckBoxes = True
        Me.CompletedPatientListview.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3, Me.ColumnHeader4, Me.ColumnHeader5})
        Me.CompletedPatientListview.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CompletedPatientListview.FullRowSelect = True
        Me.CompletedPatientListview.HideSelection = False
        ListViewItem2.StateImageIndex = 0
        Me.CompletedPatientListview.Items.AddRange(New System.Windows.Forms.ListViewItem() {ListViewItem2})
        Me.CompletedPatientListview.Location = New System.Drawing.Point(3, 3)
        Me.CompletedPatientListview.Name = "CompletedPatientListview"
        Me.CompletedPatientListview.Size = New System.Drawing.Size(559, 586)
        Me.CompletedPatientListview.TabIndex = 1
        Me.CompletedPatientListview.UseCompatibleStateImageBehavior = False
        Me.CompletedPatientListview.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "Name"
        Me.ColumnHeader1.Width = 180
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Record #"
        Me.ColumnHeader2.Width = 58
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "Room #"
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "Date of Admission"
        Me.ColumnHeader4.Width = 103
        '
        'ColumnHeader5
        '
        Me.ColumnHeader5.Text = "Last Visit"
        Me.ColumnHeader5.Width = 67
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.HelpToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(579, 24)
        Me.MenuStrip1.TabIndex = 1
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NewPatientToolStripMenuItem, Me.ExportCompletePatientsToolStripMenuItem, Me.DeleteSelectedPatientsToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.FileToolStripMenuItem.Text = "File"
        '
        'NewPatientToolStripMenuItem
        '
        Me.NewPatientToolStripMenuItem.Name = "NewPatientToolStripMenuItem"
        Me.NewPatientToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.N), System.Windows.Forms.Keys)
        Me.NewPatientToolStripMenuItem.Size = New System.Drawing.Size(248, 22)
        Me.NewPatientToolStripMenuItem.Text = "New Patient"
        '
        'ExportCompletePatientsToolStripMenuItem
        '
        Me.ExportCompletePatientsToolStripMenuItem.Name = "ExportCompletePatientsToolStripMenuItem"
        Me.ExportCompletePatientsToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.E), System.Windows.Forms.Keys)
        Me.ExportCompletePatientsToolStripMenuItem.Size = New System.Drawing.Size(248, 22)
        Me.ExportCompletePatientsToolStripMenuItem.Text = "Export Complete Patients"
        Me.ExportCompletePatientsToolStripMenuItem.ToolTipText = "Exports the checked off patients in the Completed Patients section to Patient Bil" &
    "ling Strips"
        '
        'DeleteSelectedPatientsToolStripMenuItem
        '
        Me.DeleteSelectedPatientsToolStripMenuItem.Name = "DeleteSelectedPatientsToolStripMenuItem"
        Me.DeleteSelectedPatientsToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.Delete
        Me.DeleteSelectedPatientsToolStripMenuItem.Size = New System.Drawing.Size(248, 22)
        Me.DeleteSelectedPatientsToolStripMenuItem.Text = "Delete Selected Patients"
        Me.DeleteSelectedPatientsToolStripMenuItem.ToolTipText = "Deletes all ticked patients in the Completed Patients tab"
        '
        'HelpToolStripMenuItem
        '
        Me.HelpToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AboutToolStripMenuItem})
        Me.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem"
        Me.HelpToolStripMenuItem.Size = New System.Drawing.Size(44, 20)
        Me.HelpToolStripMenuItem.Text = "Help"
        '
        'AboutToolStripMenuItem
        '
        Me.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        Me.AboutToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F1
        Me.AboutToolStripMenuItem.Size = New System.Drawing.Size(126, 22)
        Me.AboutToolStripMenuItem.Text = "About"
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(579, 648)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "MainForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "PatientStrip Generator"
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.ActiveTableLayout.ResumeLayout(False)
        Me.TabPage2.ResumeLayout(False)
        Me.TableLayoutPanel2.ResumeLayout(False)
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents ActiveTableLayout As TableLayoutPanel
    Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
    Friend WithEvents CompletedPatientListview As ListView
    Friend WithEvents ColumnHeader1 As ColumnHeader
    Friend WithEvents ColumnHeader2 As ColumnHeader
    Friend WithEvents ColumnHeader3 As ColumnHeader
    Friend WithEvents ColumnHeader4 As ColumnHeader
    Friend WithEvents ColumnHeader5 As ColumnHeader
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents NewPatientToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents HelpToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AboutToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ActivePatientsListview As ListView
    Friend WithEvents LName As ColumnHeader
    Friend WithEvents Record As ColumnHeader
    Friend WithEvents Room As ColumnHeader
    Friend WithEvents DateAdmin As ColumnHeader
    Friend WithEvents DateLastVisit As ColumnHeader
    Friend WithEvents ExportCompletePatientsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DeleteSelectedPatientsToolStripMenuItem As ToolStripMenuItem
End Class
