Public Class Student

    Protected _strStudentID As String
    Protected _strStudentName As String
    Protected _intUnits As Integer
    Protected _strMajor As String

    Protected _decCost As Decimal
    Protected _decCostPerUnit As Decimal = 450D

    Sub New(ByVal strStudentID As String, ByVal strStudentName As String, ByVal intUnits As String, strMajor As String)

        _strStudentID = strStudentID
        _strStudentName = strStudentName
        _intUnits = Convert.ToInt32(intUnits)
        _strMajor = strMajor

    End Sub

    Overridable Function ComputeCosts() As Decimal

        _decCost = _intUnits * _decCostPerUnit
        Return _decCost

    End Function

End Class
