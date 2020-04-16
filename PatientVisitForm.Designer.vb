<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PatientVisitForm
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
        Me.VisitLayout = New System.Windows.Forms.TableLayoutPanel()
        Me.CANCELBTN = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.DatePicker = New System.Windows.Forms.DateTimePicker()
        Me.VLocale = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.NotesTXB = New System.Windows.Forms.TextBox()
        Me.VType = New System.Windows.Forms.ComboBox()
        Me.OKBTN = New System.Windows.Forms.Button()
        Me.VisitLayout.SuspendLayout()
        Me.SuspendLayout()
        '
        'VisitLayout
        '
        Me.VisitLayout.ColumnCount = 2
        Me.VisitLayout.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 218.0!))
        Me.VisitLayout.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 147.0!))
        Me.VisitLayout.Controls.Add(Me.CANCELBTN, 0, 4)
        Me.VisitLayout.Controls.Add(Me.Label1, 0, 0)
        Me.VisitLayout.Controls.Add(Me.Label2, 1, 0)
        Me.VisitLayout.Controls.Add(Me.DatePicker, 0, 1)
        Me.VisitLayout.Controls.Add(Me.VLocale, 1, 1)
        Me.VisitLayout.Controls.Add(Me.Label3, 1, 2)
        Me.VisitLayout.Controls.Add(Me.Label4, 0, 2)
        Me.VisitLayout.Controls.Add(Me.NotesTXB, 0, 3)
        Me.VisitLayout.Controls.Add(Me.VType, 1, 3)
        Me.VisitLayout.Controls.Add(Me.OKBTN, 1, 4)
        Me.VisitLayout.Dock = System.Windows.Forms.DockStyle.Fill
        Me.VisitLayout.Location = New System.Drawing.Point(0, 0)
        Me.VisitLayout.Name = "VisitLayout"
        Me.VisitLayout.RowCount = 5
        Me.VisitLayout.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 18.0!))
        Me.VisitLayout.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.VisitLayout.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 22.0!))
        Me.VisitLayout.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 31.0!))
        Me.VisitLayout.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.VisitLayout.Size = New System.Drawing.Size(365, 138)
        Me.VisitLayout.TabIndex = 0
        '
        'CANCELBTN
        '
        Me.CANCELBTN.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CANCELBTN.Location = New System.Drawing.Point(3, 104)
        Me.CANCELBTN.Name = "CANCELBTN"
        Me.CANCELBTN.Size = New System.Drawing.Size(212, 31)
        Me.CANCELBTN.TabIndex = 9
        Me.CANCELBTN.Text = "Cancel"
        Me.CANCELBTN.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(3, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(66, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Date Of Visit"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(221, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(70, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Visit Location"
        '
        'DatePicker
        '
        Me.DatePicker.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DatePicker.Location = New System.Drawing.Point(3, 21)
        Me.DatePicker.Name = "DatePicker"
        Me.DatePicker.Size = New System.Drawing.Size(212, 20)
        Me.DatePicker.TabIndex = 2
        '
        'VLocale
        '
        Me.VLocale.Dock = System.Windows.Forms.DockStyle.Fill
        Me.VLocale.FormattingEnabled = True
        Me.VLocale.Items.AddRange(New Object() {"WARD", "ICU"})
        Me.VLocale.Location = New System.Drawing.Point(221, 21)
        Me.VLocale.Name = "VLocale"
        Me.VLocale.Size = New System.Drawing.Size(141, 21)
        Me.VLocale.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(221, 48)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(53, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Visit Type"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(3, 48)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(35, 13)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "Notes"
        '
        'NotesTXB
        '
        Me.NotesTXB.Dock = System.Windows.Forms.DockStyle.Fill
        Me.NotesTXB.Location = New System.Drawing.Point(3, 73)
        Me.NotesTXB.Name = "NotesTXB"
        Me.NotesTXB.Size = New System.Drawing.Size(212, 20)
        Me.NotesTXB.TabIndex = 6
        '
        'VType
        '
        Me.VType.Dock = System.Windows.Forms.DockStyle.Fill
        Me.VType.FormattingEnabled = True
        Me.VType.Items.AddRange(New Object() {"CONSULT", "FOLLOW-UP"})
        Me.VType.Location = New System.Drawing.Point(221, 73)
        Me.VType.Name = "VType"
        Me.VType.Size = New System.Drawing.Size(141, 21)
        Me.VType.TabIndex = 7
        '
        'OKBTN
        '
        Me.OKBTN.Dock = System.Windows.Forms.DockStyle.Fill
        Me.OKBTN.Location = New System.Drawing.Point(221, 104)
        Me.OKBTN.Name = "OKBTN"
        Me.OKBTN.Size = New System.Drawing.Size(141, 31)
        Me.OKBTN.TabIndex = 8
        Me.OKBTN.Text = "OK"
        Me.OKBTN.UseVisualStyleBackColor = True
        '
        'PatientVisitForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(365, 138)
        Me.Controls.Add(Me.VisitLayout)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow
        Me.Name = "PatientVisitForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "New Visit"
        Me.VisitLayout.ResumeLayout(False)
        Me.VisitLayout.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents VisitLayout As TableLayoutPanel
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents DatePicker As DateTimePicker
    Friend WithEvents VLocale As ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents NotesTXB As TextBox
    Friend WithEvents VType As ComboBox
    Friend WithEvents CANCELBTN As Button
    Friend WithEvents OKBTN As Button
End Class
