<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PatientDetailsForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim ListViewItem1 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem(New String() {"1/10/2020", "WARD", "FOLLOW-UP", "33"}, -1)
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AddNewVisitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MarkAsCompleteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PatientLayout = New System.Windows.Forms.TableLayoutPanel()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.MLastNameTXB = New System.Windows.Forms.TextBox()
        Me.PLastNameTXB = New System.Windows.Forms.TextBox()
        Me.FirstNameTXB = New System.Windows.Forms.TextBox()
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.RecNumberTXB = New System.Windows.Forms.TextBox()
        Me.RoomNumberTXB = New System.Windows.Forms.TextBox()
        Me.InsuranceTXB = New System.Windows.Forms.TextBox()
        Me.TableLayoutPanel3 = New System.Windows.Forms.TableLayoutPanel()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.DiagnosisTXB = New System.Windows.Forms.TextBox()
        Me.AdminDateLBL = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.VisitsListView = New System.Windows.Forms.ListView()
        Me.VDate = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.VLocale = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.VType = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.VNotes = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ButtonLayout = New System.Windows.Forms.TableLayoutPanel()
        Me.OKBTN = New System.Windows.Forms.Button()
        Me.CANCELBTN = New System.Windows.Forms.Button()
        Me.MenuStrip1.SuspendLayout()
        Me.PatientLayout.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.TableLayoutPanel2.SuspendLayout()
        Me.TableLayoutPanel3.SuspendLayout()
        Me.ButtonLayout.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.HelpToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(658, 24)
        Me.MenuStrip1.TabIndex = 1
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AddNewVisitToolStripMenuItem, Me.MarkAsCompleteToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.FileToolStripMenuItem.Text = "File"
        '
        'AddNewVisitToolStripMenuItem
        '
        Me.AddNewVisitToolStripMenuItem.Name = "AddNewVisitToolStripMenuItem"
        Me.AddNewVisitToolStripMenuItem.Size = New System.Drawing.Size(170, 22)
        Me.AddNewVisitToolStripMenuItem.Text = "Add New Visit"
        '
        'MarkAsCompleteToolStripMenuItem
        '
        Me.MarkAsCompleteToolStripMenuItem.Name = "MarkAsCompleteToolStripMenuItem"
        Me.MarkAsCompleteToolStripMenuItem.Size = New System.Drawing.Size(170, 22)
        Me.MarkAsCompleteToolStripMenuItem.Text = "Mark as Complete"
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
        Me.AboutToolStripMenuItem.Size = New System.Drawing.Size(107, 22)
        Me.AboutToolStripMenuItem.Text = "About"
        '
        'PatientLayout
        '
        Me.PatientLayout.ColumnCount = 1
        Me.PatientLayout.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.PatientLayout.Controls.Add(Me.TableLayoutPanel1, 0, 0)
        Me.PatientLayout.Controls.Add(Me.TableLayoutPanel2, 0, 1)
        Me.PatientLayout.Controls.Add(Me.TableLayoutPanel3, 0, 2)
        Me.PatientLayout.Controls.Add(Me.Label10, 0, 3)
        Me.PatientLayout.Controls.Add(Me.VisitsListView, 0, 4)
        Me.PatientLayout.Controls.Add(Me.ButtonLayout, 0, 5)
        Me.PatientLayout.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PatientLayout.Location = New System.Drawing.Point(0, 24)
        Me.PatientLayout.Name = "PatientLayout"
        Me.PatientLayout.RowCount = 6
        Me.PatientLayout.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 56.0!))
        Me.PatientLayout.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 53.0!))
        Me.PatientLayout.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50.0!))
        Me.PatientLayout.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 19.0!))
        Me.PatientLayout.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.PatientLayout.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 37.0!))
        Me.PatientLayout.Size = New System.Drawing.Size(658, 607)
        Me.PatientLayout.TabIndex = 2
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 3
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 72.19251!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 211.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 206.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.Label4, 2, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Label3, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Label2, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.MLastNameTXB, 2, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.PLastNameTXB, 1, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.FirstNameTXB, 0, 1)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(3, 3)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 2
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 21.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(652, 50)
        Me.TableLayoutPanel1.TabIndex = 1
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(449, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(102, 13)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Maternal Last Name"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(238, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(100, 13)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Paternal Last Name"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(3, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(57, 13)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "First Name"
        '
        'MLastNameTXB
        '
        Me.MLastNameTXB.Dock = System.Windows.Forms.DockStyle.Fill
        Me.MLastNameTXB.Location = New System.Drawing.Point(449, 24)
        Me.MLastNameTXB.Name = "MLastNameTXB"
        Me.MLastNameTXB.Size = New System.Drawing.Size(200, 20)
        Me.MLastNameTXB.TabIndex = 5
        '
        'PLastNameTXB
        '
        Me.PLastNameTXB.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PLastNameTXB.Location = New System.Drawing.Point(238, 24)
        Me.PLastNameTXB.Name = "PLastNameTXB"
        Me.PLastNameTXB.Size = New System.Drawing.Size(205, 20)
        Me.PLastNameTXB.TabIndex = 3
        '
        'FirstNameTXB
        '
        Me.FirstNameTXB.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FirstNameTXB.Location = New System.Drawing.Point(3, 24)
        Me.FirstNameTXB.Name = "FirstNameTXB"
        Me.FirstNameTXB.Size = New System.Drawing.Size(229, 20)
        Me.FirstNameTXB.TabIndex = 1
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.ColumnCount = 3
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 51.54321!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 48.45679!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 355.0!))
        Me.TableLayoutPanel2.Controls.Add(Me.Label5, 0, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.Label6, 1, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.Label7, 2, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.RecNumberTXB, 0, 1)
        Me.TableLayoutPanel2.Controls.Add(Me.RoomNumberTXB, 1, 1)
        Me.TableLayoutPanel2.Controls.Add(Me.InsuranceTXB, 2, 1)
        Me.TableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(3, 59)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 2
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 38.29787!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 61.70213!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(652, 47)
        Me.TableLayoutPanel2.TabIndex = 2
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(3, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(82, 13)
        Me.Label5.TabIndex = 7
        Me.Label5.Text = "Record Number"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(156, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(75, 13)
        Me.Label6.TabIndex = 8
        Me.Label6.Text = "Room Number"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(299, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(54, 13)
        Me.Label7.TabIndex = 9
        Me.Label7.Text = "Insurance"
        '
        'RecNumberTXB
        '
        Me.RecNumberTXB.Dock = System.Windows.Forms.DockStyle.Fill
        Me.RecNumberTXB.Location = New System.Drawing.Point(3, 20)
        Me.RecNumberTXB.Name = "RecNumberTXB"
        Me.RecNumberTXB.Size = New System.Drawing.Size(147, 20)
        Me.RecNumberTXB.TabIndex = 10
        '
        'RoomNumberTXB
        '
        Me.RoomNumberTXB.Dock = System.Windows.Forms.DockStyle.Fill
        Me.RoomNumberTXB.Location = New System.Drawing.Point(156, 20)
        Me.RoomNumberTXB.Name = "RoomNumberTXB"
        Me.RoomNumberTXB.Size = New System.Drawing.Size(137, 20)
        Me.RoomNumberTXB.TabIndex = 11
        '
        'InsuranceTXB
        '
        Me.InsuranceTXB.Dock = System.Windows.Forms.DockStyle.Fill
        Me.InsuranceTXB.Location = New System.Drawing.Point(299, 20)
        Me.InsuranceTXB.Name = "InsuranceTXB"
        Me.InsuranceTXB.Size = New System.Drawing.Size(350, 20)
        Me.InsuranceTXB.TabIndex = 12
        '
        'TableLayoutPanel3
        '
        Me.TableLayoutPanel3.ColumnCount = 2
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel3.Controls.Add(Me.Label8, 0, 0)
        Me.TableLayoutPanel3.Controls.Add(Me.Label9, 1, 0)
        Me.TableLayoutPanel3.Controls.Add(Me.DiagnosisTXB, 0, 1)
        Me.TableLayoutPanel3.Controls.Add(Me.AdminDateLBL, 1, 1)
        Me.TableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel3.Location = New System.Drawing.Point(3, 112)
        Me.TableLayoutPanel3.Name = "TableLayoutPanel3"
        Me.TableLayoutPanel3.RowCount = 2
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 17.0!))
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 23.0!))
        Me.TableLayoutPanel3.Size = New System.Drawing.Size(652, 44)
        Me.TableLayoutPanel3.TabIndex = 3
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(3, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(53, 13)
        Me.Label8.TabIndex = 0
        Me.Label8.Text = "Diagnosis"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(329, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(92, 13)
        Me.Label9.TabIndex = 1
        Me.Label9.Text = "Date of Admission"
        '
        'DiagnosisTXB
        '
        Me.DiagnosisTXB.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DiagnosisTXB.Location = New System.Drawing.Point(3, 20)
        Me.DiagnosisTXB.Name = "DiagnosisTXB"
        Me.DiagnosisTXB.Size = New System.Drawing.Size(320, 20)
        Me.DiagnosisTXB.TabIndex = 2
        '
        'AdminDateLBL
        '
        Me.AdminDateLBL.AutoSize = True
        Me.AdminDateLBL.Location = New System.Drawing.Point(329, 17)
        Me.AdminDateLBL.Name = "AdminDateLBL"
        Me.AdminDateLBL.Size = New System.Drawing.Size(59, 13)
        Me.AdminDateLBL.TabIndex = 3
        Me.AdminDateLBL.Text = "1/10/2020"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(3, 159)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(75, 13)
        Me.Label10.TabIndex = 4
        Me.Label10.Text = "Previous Visits"
        '
        'VisitsListView
        '
        Me.VisitsListView.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.VDate, Me.VLocale, Me.VType, Me.VNotes})
        Me.VisitsListView.Dock = System.Windows.Forms.DockStyle.Fill
        Me.VisitsListView.FullRowSelect = True
        Me.VisitsListView.HideSelection = False
        Me.VisitsListView.Items.AddRange(New System.Windows.Forms.ListViewItem() {ListViewItem1})
        Me.VisitsListView.Location = New System.Drawing.Point(3, 181)
        Me.VisitsListView.MultiSelect = False
        Me.VisitsListView.Name = "VisitsListView"
        Me.VisitsListView.Size = New System.Drawing.Size(652, 386)
        Me.VisitsListView.TabIndex = 5
        Me.VisitsListView.UseCompatibleStateImageBehavior = False
        Me.VisitsListView.View = System.Windows.Forms.View.Details
        '
        'VDate
        '
        Me.VDate.Text = "Date"
        Me.VDate.Width = 89
        '
        'VLocale
        '
        Me.VLocale.Text = "Locale"
        '
        'VType
        '
        Me.VType.Text = "Visit Type"
        Me.VType.Width = 82
        '
        'VNotes
        '
        Me.VNotes.Text = "Notes"
        Me.VNotes.Width = 367
        '
        'ButtonLayout
        '
        Me.ButtonLayout.ColumnCount = 3
        Me.ButtonLayout.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.ButtonLayout.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 104.0!))
        Me.ButtonLayout.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 83.0!))
        Me.ButtonLayout.Controls.Add(Me.OKBTN, 2, 0)
        Me.ButtonLayout.Controls.Add(Me.CANCELBTN, 1, 0)
        Me.ButtonLayout.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ButtonLayout.Location = New System.Drawing.Point(3, 573)
        Me.ButtonLayout.Name = "ButtonLayout"
        Me.ButtonLayout.RowCount = 1
        Me.ButtonLayout.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.ButtonLayout.Size = New System.Drawing.Size(652, 31)
        Me.ButtonLayout.TabIndex = 6
        '
        'OKBTN
        '
        Me.OKBTN.Dock = System.Windows.Forms.DockStyle.Fill
        Me.OKBTN.Location = New System.Drawing.Point(572, 3)
        Me.OKBTN.Name = "OKBTN"
        Me.OKBTN.Size = New System.Drawing.Size(77, 25)
        Me.OKBTN.TabIndex = 0
        Me.OKBTN.Text = "OK"
        Me.OKBTN.UseVisualStyleBackColor = True
        '
        'CANCELBTN
        '
        Me.CANCELBTN.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CANCELBTN.Location = New System.Drawing.Point(468, 3)
        Me.CANCELBTN.Name = "CANCELBTN"
        Me.CANCELBTN.Size = New System.Drawing.Size(98, 25)
        Me.CANCELBTN.TabIndex = 1
        Me.CANCELBTN.Text = "Cancel"
        Me.CANCELBTN.UseVisualStyleBackColor = True
        '
        'PatientDetailsForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(658, 631)
        Me.Controls.Add(Me.PatientLayout)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "PatientDetailsForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Details"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.PatientLayout.ResumeLayout(False)
        Me.PatientLayout.PerformLayout()
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        Me.TableLayoutPanel2.ResumeLayout(False)
        Me.TableLayoutPanel2.PerformLayout()
        Me.TableLayoutPanel3.ResumeLayout(False)
        Me.TableLayoutPanel3.PerformLayout()
        Me.ButtonLayout.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AddNewVisitToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MarkAsCompleteToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents HelpToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AboutToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PatientLayout As TableLayoutPanel
    Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents RecNumberTXB As TextBox
    Friend WithEvents RoomNumberTXB As TextBox
    Friend WithEvents InsuranceTXB As TextBox
    Friend WithEvents TableLayoutPanel3 As TableLayoutPanel
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents DiagnosisTXB As TextBox
    Friend WithEvents AdminDateLBL As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents VisitsListView As ListView
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents MLastNameTXB As TextBox
    Friend WithEvents PLastNameTXB As TextBox
    Friend WithEvents FirstNameTXB As TextBox
    Friend WithEvents VDate As ColumnHeader
    Friend WithEvents VLocale As ColumnHeader
    Friend WithEvents VType As ColumnHeader
    Friend WithEvents VNotes As ColumnHeader
    Friend WithEvents ButtonLayout As TableLayoutPanel
    Friend WithEvents OKBTN As Button
    Friend WithEvents CANCELBTN As Button
End Class
