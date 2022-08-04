Public Class Influenza

    Inherits Sick

    Private Consultationfee As Decimal

    Public Sub New(ByVal SickIDs As String,
                   ByVal DurationOfTreatments As Integer,
                   ByVal DoctorsIDs As String,
                   ByVal Pfees As Decimal)

        MyBase.New(SickIDs, DurationOfTreatments, DoctorsIDs)
        Consultationfee = Pfees
    End Sub

    Public Property consultF() As Decimal
        Get
            Return Consultationfee
        End Get
        Set(ByVal consultfees As Decimal)
            Consultationfee = consultfees
        End Set
    End Property


    Public Overrides Function TreatmentAmount() As Decimal

        Const Medicationfees As Decimal = 350.5D
        Const Discount As Decimal = 0.02D
        Dim feesPaid As Decimal

        If Consultationfee > 600 Then
            Consultationfee = Consultationfee - (Consultationfee * Discount)
        End If

        feesPaid = Consultationfee + Medicationfees

        Return feesPaid
    End Function


End Class
