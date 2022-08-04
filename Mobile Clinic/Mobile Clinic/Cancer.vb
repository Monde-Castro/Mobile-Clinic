Public Class Cancer

    Inherits Sick

    Private Scanfee As Decimal

    Public Sub New(ByVal SickIDs As String,
                   ByVal DurationOfTreatments As Integer,
                   ByVal DoctorsIDs As String,
                   ByVal sfee As Decimal)

        MyBase.New(SickIDs, DurationOfTreatments, DoctorsIDs)
        Scanfee = sfee
    End Sub


    Public Property Scanningfee() As Decimal
        Get
            Return Scanfee
        End Get
        Set(ByVal sfees As Decimal)
            Scanfee = sfees
        End Set
    End Property


    Public Overrides Function TreatmentAmount() As Decimal

        Dim diagfee As Decimal
        Const Medication As Decimal = 400D

        If Scanfee > 600 Then
            MessageBox.Show("Sorry we canno't treat you")
        Else
            diagfee = Medication + Scanfee
        End If

        Return diagfee
    End Function

   
End Class
