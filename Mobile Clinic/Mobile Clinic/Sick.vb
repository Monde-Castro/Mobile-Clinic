Public Class Sick

    Private MSickID As String
    Private MDurationOfTreatments As String
    Private MDoctorsID As String

    Public Sub New(ByVal SickID As String,
                    ByVal DurationOfTreatments As Integer,
                    ByVal DoctorsID As String)

        MSickID = SickID
        MDurationOfTreatments = DurationOfTreatments
        MDoctorsID = DoctorsID
    End Sub


    Public Property SickID() As String
        Get
            SickID = MSickID
            Return MSickID
        End Get
        Set(ByVal SickID As String)
            MSickID = SickID
        End Set
    End Property

    Public Property DurationOfTreatment() As Integer
        Get
            DurationOfTreatment = MDurationOfTreatments
            Return MDurationOfTreatments
        End Get
        Set(ByVal duration As Integer)
            MDurationOfTreatments = duration
        End Set
    End Property


    Public Property Doctors() As String
        Get
            Doctors = MDoctorsID
            Return MDoctorsID
        End Get
        Set(ByVal sDoctors As String)
            MDoctorsID = sDoctors
        End Set
    End Property


    Public Overridable Function TreatmentAmount() As Decimal


    End Function

End Class
