Public Class Form1

    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        'Declaration of Object
        Dim Sickcancer As Cancer
        Dim SickFlue As Influenza

        Dim decfee As Decimal
        Dim fluefee As Decimal

        
        Sickcancer = New Cancer(txtCode.Text,
                                txtDiagnose.Text,
                                txtPractice.Text,
                                txtTreatment.Text)
        Sickcancer.SickID = txtCode.Text
        Sickcancer.DurationOfTreatment = CInt(txtTreatment.Text)
        Sickcancer.Doctors = txtPractice.Text
        Sickcancer.Scanningfee = txtDiagnose.Text


        SickFlue = New Influenza(txtCode.Text,
                                 txtDiagnose.Text,
                                 txtPractice.Text,
                                 txtTreatment.Text)
        SickFlue.SickID = txtCode.Text
        SickFlue.DurationOfTreatment = CInt(txtTreatment.Text)
        SickFlue.Doctors = txtPractice.Text
        SickFlue.consultF = txtDiagnose.Text

        If radCancer.Checked Then
            decfee = Sickcancer.TreatmentAmount()
            lblAmount.Text = FormatCurrency(decfee, 2)
        ElseIf radInflue.Checked Then
            fluefee = SickFlue.TreatmentAmount()
            lblAmount.Text = FormatCurrency(fluefee, 2)
        End If
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        'Clear all controls
        txtCode.Clear()
        txtDiagnose.Clear()
        txtPractice.Clear()
        txtTreatment.Clear()
        lblAmount.Text = " "
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        'Close the progam
        Close()
    End Sub
End Class
