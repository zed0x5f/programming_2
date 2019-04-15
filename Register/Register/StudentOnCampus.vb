Public Class StudentOnCampus
    Inherits Student
    Private _cooper As Boolean
    Private _craig As Boolean
    Private _julian As Boolean
    'Letter D is lateral, (.0)

    Public Sub New(ByVal strStudentId As String,
            ByVal strStudentName As String,
            ByVal strMajor As String,
            ByVal intUnits As Integer,
            ByVal cooper As Boolean,
            ByVal craig As Boolean,
            ByVal julian As Boolean)
        MyBase.New(strStudentId,
            strStudentName,
            strMajor,
            intUnits)
        _cooper = cooper
        _craig = craig
        _julian = julian
    End Sub

    Public Overrides Function ComputeCost() As Double
        Dim HousingCost As Decimal

        If _cooper Then HousingCost = 2900D
        If _craig Then HousingCost = 3400D
        If _julian Then HousingCost = 4000D

        _cost = (_numberOfUnits * _costPerUnit) + HousingCost
        'New ArrayList({_studentId, _studentName, _major, _cost}
        Return MyBase.ComputeCost()
    End Function
End Class
