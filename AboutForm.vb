Public NotInheritable Class AboutForm

    ''' <summary>Set the stuff</summary>
    Private Sub FillMeUp() Handles MyBase.Load
        Text = "About PSG"
        LabelProductName.Text = "Patient Billing Strip Generator"
        LabelVersion.Text = String.Format("Version {0}", My.Application.Info.Version.ToString)
        LabelCopyright.Text = My.Application.Info.Copyright
        LabelCompanyName.Text = My.Application.Info.CompanyName
    End Sub

    Private Sub Adiosito() Handles OKButton.Click
        Me.Close()
    End Sub

End Class
